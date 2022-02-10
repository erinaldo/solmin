Imports Ransa.Utilitario
Imports solmin_sc.Entidad
Imports solmin_sc.Negocio
 
Public Class frmFiltroExportarXls_2
    Private _pObeOrdenDeCompra As beOrdenCompra

    Public Property pObeOrdenDeCompra() As beOrdenCompra
        Get
            Return _pObeOrdenDeCompra
        End Get
        Set(ByVal value As beOrdenCompra)
            _pObeOrdenDeCompra = value
        End Set
    End Property

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim obrOrdenDeCompra As New clsOC
        With pObeOrdenDeCompra
            .FechaInicioEntregaProveedor = IIf(Me.dteFechaCompInicial.Checked, Me.dteFechaCompInicial.Value, "")
            .FechaFinEntregaProveedor = IIf(Me.dteFechaCompFinal.Checked, Me.dteFechaCompFinal.Value, "")
            .PSSTATOC = cmbSituacionOC.pInformacionSelec.pCCMPRN_Codigo
            .FechaInicioOC = _pObeOrdenDeCompra.FechaInicioOC
            .FechaFinOc = _pObeOrdenDeCompra.FechaFinOc
        End With
        ExportarExcelOC(obrOrdenDeCompra.fdtIndicadorTiempoEntregaProveedor_v2(pObeOrdenDeCompra))
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#Region "Exportar Excel"

    Private Sub ExportarExcel(ByVal oDtExcel As DataTable)
        If oDtExcel Is Nothing OrElse oDtExcel.Columns.Count = 0 Then Exit Sub
        Dim oDs As New DataSet
        oDs.Tables.Add(oDtExcel)

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & _pObeOrdenDeCompra.Cliente)
        strlTitulo.Add("Planta :\n" & _pObeOrdenDeCompra.Planta)
        If _pObeOrdenDeCompra.Proveedor.Trim.Equals("") Then
            strlTitulo.Add("Proveedor :\nTODOS")
        Else
            strlTitulo.Add("TProveedor :\n" & _pObeOrdenDeCompra.Proveedor)
        End If
        strlTitulo.Add("Fecha entrega proveedor:\n" & IIf(dteFechaCompInicial.Checked, dteFechaCompInicial.Value.Date, "") & " - " & IIf(dteFechaCompFinal.Checked, dteFechaCompFinal.Value.Date, ""))
        HelpClass.ExportExcelConTitulos(oDs, "Reporte Seguimiento OC Local", strlTitulo)
    End Sub

    Private Function GenerarResumen(ByVal DtReporte As DataTable) As DataTable
        Dim DtResumen As New DataTable
        Dim nOrdenCompra As Integer = 0
        Dim nDiaAtraso As Integer = 0
        Dim nCambios As Integer = 0
        Dim nTotalDiaAtraso As Decimal = 0
        Dim nTotalCambios As Decimal = 0
        Dim nCountdias As Integer = 0
        Dim blExisteProveedor As Boolean = False
        Dim strOrdenCompra As String = String.Empty
        Dim drResumen As DataRow

        Dim intVencidas As Integer = 0
        Dim intNoVencidas As Integer = 0

        Dim intVerde As Integer = 0
        Dim intAmarillo As Integer = 0
        Dim intRojo As Integer = 0

        mtoDtFormater(DtResumen)
        For Each dr As DataRow In DtReporte.Rows
            nOrdenCompra = 0
            nDiaAtraso = 0
            nCambios = 0
            nCountdias = 0
            nTotalDiaAtraso = 0
            nTotalCambios = 0
            intVencidas = 0
            intNoVencidas = 0

            intVerde = 0
            intAmarillo = 0
            intRojo = 0
            strOrdenCompra = String.Empty
            blExisteProveedor = False
            For Each drAux As DataRow In DtResumen.Select("Proveedor = '" & ("" & dr("TPRVCL")) & "'")
                blExisteProveedor = True
            Next
            If blExisteProveedor Then
                Continue For
            Else

                For Each drAux As DataRow In DtReporte.Select("ISNULL(TPRVCL,'') = '" & ("" & dr("TPRVCL")) & "'")
                    If drAux("NORCML").ToString.Trim <> strOrdenCompra Then
                        nOrdenCompra = nOrdenCompra + 1
                    End If
                    nDiaAtraso = nDiaAtraso + IIf(drAux("NRDIA_EC") > 0, drAux("NRDIA_EC"), 0)

                    intVencidas = intVencidas + IIf(drAux("STFENT").ToString.Trim.Equals("VENCIDO"), 1, 0)
                    intNoVencidas = intNoVencidas + IIf(drAux("STFENT").ToString.Trim.Equals("VENCIDO"), 0, 1)

                    'Verder
                    If drAux("NRDIA_EC") <= 5 And drAux("STFENT") = "VENCIDO" Then
                        intVerde += 1
                    End If
                    'Amarillo
                    If drAux("NRDIA_EC") > 5 And drAux("NRDIA_EC") <= 20 And drAux("STFENT") = "VENCIDO" Then
                        intAmarillo += 1
                    End If
                    'Rojo
                    If drAux("NRDIA_EC") > 20 And drAux("STFENT") = "VENCIDO" Then
                        intRojo += 1
                    End If

                    nCambios = nCambios + drAux("MOV_FECHAS")
                    nCountdias = nCountdias + 1
                    strOrdenCompra = drAux("NORCML").ToString.Trim
                Next
                nTotalDiaAtraso = nDiaAtraso / nCountdias
                nTotalCambios = nCambios / nCountdias

                drResumen = DtResumen.NewRow()
                drResumen("Proveedor") = ("" & dr("TPRVCL"))
                drResumen("Ruc") = ("" & dr("NRUCPR"))
                drResumen("No Vencidas") = intNoVencidas
                drResumen("Vencidas") = intVencidas
                drResumen("Total") = intVencidas + intNoVencidas
                drResumen("Vencidas \n Menor o igual a 5 días") = intVerde
                drResumen("Vencidas \n Entre 6 y 20 días") = intAmarillo
                drResumen("Vencidas \n Mayor a 21 días") = intRojo
                drResumen("Promedio de Retraso a la fecha") = IIf(intVencidas = 0, 0, nDiaAtraso / intVencidas)
                'drResumen("DiasAtraso") = IIf(nTotalDiaAtraso.ToString.IndexOf(".") > 0, nTotalDiaAtraso.ToString("N1"), nTotalDiaAtraso)
                'drResumen("Cambios") = IIf(nTotalCambios.ToString.IndexOf(".") > 0, nTotalCambios.ToString("N1"), nTotalCambios)
                DtResumen.Rows.Add(drResumen)
            End If
        Next
        DtResumen.DefaultView.Sort = " Vencidas DESC" 'Select("", "Vencidas DESC")
        Return DtResumen.DefaultView.ToTable()
    End Function

    Private Sub ExportarExcelOC(ByVal DtReporte As DataTable)
        Try
            Dim oDs As New DataSet
            Dim oDt As New DataTable
            Dim oDtResumen As New DataTable
            Dim strLetra As String = "C"
            Dim strLetra1 As String
            oDt = DtReporte.Copy
            DtReporte = DtReporte.Copy
            oDtResumen = GenerarResumen(DtReporte)

            oDt.TableName = "Seguimiento OC Local"
            oDtResumen.TableName = "Resumen"

            oDt.Columns.Remove("CCLNT")
            oDt.Columns.Remove("NRUCPR")
            oDt.Columns.Remove("TCMPCL")
            oDt.Columns.Remove("CPRVCL")
            oDt.Columns.Remove("TPLNTA")
            oDt.Columns.Add("CLASIFICACIÓN")
            For Each oDr As DataRow In oDt.Rows
                If oDr("QBLTSR") = 0 Then
                    oDr("FEACTU") = DBNull.Value
                End If

                'Verder
                If oDr("NRDIA_EC") <= 5 And oDr("STFENT") = "VENCIDO" Then
                    oDr("CLASIFICACIÓN") = "1"
                End If
                'Amarillo
                If oDr("NRDIA_EC") > 5 And oDr("NRDIA_EC") <= 20 And oDr("STFENT") = "VENCIDO" Then
                    oDr("CLASIFICACIÓN") = "2"
                End If
                'Rojo
                If oDr("NRDIA_EC") > 20 And oDr("STFENT") = "VENCIDO" Then
                    oDr("CLASIFICACIÓN") = "3"
                End If

            Next

            oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
            oDt.Columns("TIPO_DOC").ColumnName = "TIPO"
            oDt.Columns("TTINTC").ColumnName = "TERM. INTERNACIONAL"
            oDt.Columns("FORCML").ColumnName = "FECHA DE O/C"
            oDt.Columns("TPRVCL").ColumnName = "RAZÓN SOCIAL"
            oDt.Columns("TLUGOR").ColumnName = "LUGAR DE ORIGEN"
            oDt.Columns("TLUGEN").ColumnName = "LUGAR DE ENTREGA"
            oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR"
            oDt.Columns("NRITOC").ColumnName = "ITEM"
            oDt.Columns("TCITCL").ColumnName = "CÓDIGO PRODUCTO"
            oDt.Columns("TDITES").ColumnName = "DETALLE"
            oDt.Columns("QCNTIT").ColumnName = "QTA O/C"
            oDt.Columns("FMPDME").ColumnName = "FECHA ESTIMADA DE ENTREGA (A)"
            oDt.Columns("FMPIME").ColumnName = "FECHA REQUERIDA EN PLANTA (B)"


            'For intRow As Integer = 0 To oDt.Rows.Count - 1

            'Next
            If oDt.Rows.Count > 0 Then
                If oDt.Rows(0).Item("CHECK_148") = 1 Then
                    oDt.Columns("FESEST_148").ColumnName = String.Format("FECHA PROMETIDA DE ENTREGA ({0})", strLetra)
                    strLetra = "D"
                Else
                    oDt.Columns.Remove("FESEST_148")
                End If
                If oDt.Rows(0).Item("CHECK_3") = 1 Then
                    oDt.Columns("FESEST_3").ColumnName = String.Format("FECHA RECOJO DEL PROVEEDOR ({0})", strLetra)
                    strLetra = "E"
                Else
                    oDt.Columns.Remove("FESEST_3")
                End If
            End If
            oDt.Columns("FEACTU").ColumnName = String.Format("FECHA ENTREGA ALMACÉN ({0})", strLetra)
            strLetra1 = strLetra
            strLetra = "C"

            oDt.Columns("NRDIA_CA").ColumnName = String.Format("DÍAS DE ATRASO " & Chr(10) & "PROMETIDO ({0} - A)", strLetra)

            If oDt.Rows.Count > 0 Then
                If oDt.Rows(0).Item("CHECK_148") = 1 Then
                    oDt.Columns("NRDIA_EC").ColumnName = String.Format(" DÍAS DE ATRASO " & Chr(10) & " ENTREGA ({0} - {1})", strLetra1, strLetra)
                    strLetra = "D"
                Else
                    oDt.Columns.Remove("NRDIA_EC")
                End If
                If oDt.Rows(0).Item("CHECK_3") = 1 Then
                    oDt.Columns("NRDIA_ED").ColumnName = String.Format(" DÍAS DE ATRASO " & Chr(10) & " RECOJO ({0} - {1})", strLetra1, strLetra)
                Else
                    oDt.Columns.Remove("NRDIA_ED")
                End If
            End If

            oDt.Columns("MOV_FECHAS").ColumnName = "CANT. CAMBIOS"
            oDt.Columns("QBLTSR").ColumnName = "QTA RECIBIDA "
            oDt.Columns("QCNPEN").ColumnName = "QTA PENDIENTE"
            'oDt.Columns("TPLNTA").ColumnName = "PLANTA DE ENTREGA"
            oDt.Columns("STFREC").ColumnName = "STATUS RECEPCIÓN"
            oDt.Columns("STFENT").ColumnName = "STATUS ENTREGA"
            oDt.Columns("TOBS").ColumnName = "BITÁCORA"



            oDt.Columns.Remove("CHECK_148")
            oDt.Columns.Remove("CHECK_3")

            oDs.Tables.Add(oDt)

            'oDtResumen.Columns("Proveedor").ColumnName = "RAZÓN SOCIAL"
            'oDtResumen.Columns("Ruc").ColumnName = "RUC"
            'oDtResumen.Columns("OrdenCompra").ColumnName = "CANT. ORDEN COMPRA"
            'oDtResumen.Columns("DiasAtraso").ColumnName = "PROMEDIO DIAS ATRASO"
            'oDtResumen.Columns("Cambios").ColumnName = "PROMEDIO CAMBIOS"
            oDs.Tables.Add(oDtResumen)

            Dim strlTitulo As New List(Of String)
            strlTitulo.Add("Cliente :\n" & _pObeOrdenDeCompra.PNCCLNT & " - " & _pObeOrdenDeCompra.Cliente)
            strlTitulo.Add("Planta :\n" & _pObeOrdenDeCompra.Planta)
            If _pObeOrdenDeCompra.PSNORCML.Trim.Equals("") Then
                strlTitulo.Add("Nro. O/C :\nTODOS")
            Else
                strlTitulo.Add("Nro. O/C :\n" & _pObeOrdenDeCompra.PSNORCML)
            End If
            'If _pObeOrdenDeCompra.Proveedor.Trim.Equals("") Then
            '    strlTitulo.Add("Proveedor :\nTODOS")
            'Else
            '    strlTitulo.Add("TProveedor :\n" & _pObeOrdenDeCompra.Proveedor)
            'End If

            If cmbSituacionOC.pInformacionSelec.pCCMPRN_Codigo = "" Then
                strlTitulo.Add("Status :\nTODOS")
            Else
                strlTitulo.Add("Status :\n" & cmbSituacionOC.pInformacionSelec.pTDSDES_Detalle)
            End If
            strlTitulo.Add("Fecha estimada de entrega:\n" & IIf(dteFechaCompInicial.Checked, dteFechaCompInicial.Value.Date, "") & " - " & IIf(dteFechaCompFinal.Checked, dteFechaCompFinal.Value.Date, ""))
            HelpClass.ExportExcelConSeguimientoOC(oDs, "Reporte Seguimiento OC Local", strlTitulo)
        Catch ex As Exception
        End Try
       
       
    End Sub

    Private Sub mtoDtFormater(ByVal cpoDataTable As DataTable)
      
        cpoDataTable.Columns.Add("Proveedor", GetType(String))
        cpoDataTable.Columns.Add("Ruc", GetType(String))
        cpoDataTable.Columns.Add("No Vencidas", GetType(Integer))
        cpoDataTable.Columns.Add("Vencidas", GetType(Integer))
        cpoDataTable.Columns.Add("Total", GetType(Integer))
        cpoDataTable.Columns.Add("Vencidas \n Menor o igual a 5 días", GetType(Integer))
        cpoDataTable.Columns.Add("Vencidas \n Entre 6 y 20 días", GetType(Integer))
        cpoDataTable.Columns.Add("Vencidas \n Mayor a 21 días", GetType(Integer))
        cpoDataTable.Columns.Add("Promedio de Retraso a la fecha", GetType(Decimal))

        'cpoDataTable.Columns.Add("OrdenCompra", GetType(Integer))
        'cpoDataTable.Columns.Add("DiasAtraso", GetType(String))
        'cpoDataTable.Columns.Add("Cambios", GetType(String))

         End Sub

#End Region



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub




    Private Sub frmFiltroExportarXls_2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbSituacionOC.pCargarPorCodigo = "T"
    End Sub
End Class
