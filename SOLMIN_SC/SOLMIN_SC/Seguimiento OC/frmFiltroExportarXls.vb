Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmFiltroExportarXls
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
        ExportarExcelOC(obrOrdenDeCompra.fdtIndicadorTiempoEntregaProveedor(pObeOrdenDeCompra))
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
        mtoDtFormater(DtResumen)
        For Each dr As DataRow In DtReporte.Rows
            nOrdenCompra = 0
            nDiaAtraso = 0
            nCambios = 0
            nCountdias = 0
            nTotalDiaAtraso = 0
            nTotalCambios = 0
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
                    nDiaAtraso = nDiaAtraso + IIf(drAux("NDIATR") > 0, drAux("NDIATR"), 0)
                    nCambios = nCambios + drAux("MOV_FECHAS")
                    nCountdias = nCountdias + 1
                    strOrdenCompra = drAux("NORCML").ToString.Trim
                Next
                nTotalDiaAtraso = nDiaAtraso / nCountdias
                nTotalCambios = nCambios / nCountdias

                drResumen = DtResumen.NewRow()
                drResumen("Proveedor") = ("" & dr("TPRVCL"))
                drResumen("Ruc") = ("" & dr("NRUCPR"))
                drResumen("OrdenCompra") = nOrdenCompra
                drResumen("DiasAtraso") = IIf(nTotalDiaAtraso.ToString.IndexOf(".") > 0, nTotalDiaAtraso.ToString("N1"), nTotalDiaAtraso)
                drResumen("Cambios") = IIf(nTotalCambios.ToString.IndexOf(".") > 0, nTotalCambios.ToString("N1"), nTotalCambios)
                DtResumen.Rows.Add(drResumen)
            End If
        Next
        Return DtResumen
    End Function

    Private Sub ExportarExcelOC(ByVal DtReporte As DataTable)
        Dim oDs As New DataSet
        Dim oDt As New DataTable
        Dim oDtResumen As New DataTable

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

        For Each oDr As DataRow In oDt.Rows
            If oDr("QBLTSR") = 0 Then
                oDr("FEACTU") = DBNull.Value
            End If
        Next

        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("TIPO_DOC").ColumnName = "TIPO"
        oDt.Columns("FORCML").ColumnName = "FECHA DE O/C"
        oDt.Columns("TPRVCL").ColumnName = "RAZÓN SOCIAL "
        oDt.Columns("TLUGEN").ColumnName = "LOTE"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR"
        oDt.Columns("NRITOC").ColumnName = "ITEM"
        oDt.Columns("TDITES").ColumnName = "DETALLE"
        oDt.Columns("QCNTIT").ColumnName = "QTA O/C"
        oDt.Columns("FMPIME").ColumnName = "FECHA PROMETIDA DE ENTREGA"
        oDt.Columns("FMPDME").ColumnName = "FECHA ESTIMADA DE ENTREGA"
        oDt.Columns("FEACTU").ColumnName = "FECHA ENTREGA ALMACÉN"
        oDt.Columns("NDIATR").ColumnName = "DÍAS ATRASO"
        oDt.Columns("MOV_FECHAS").ColumnName = "CANT. CAMBIOS"
        oDt.Columns("QBLTSR").ColumnName = "QTA RECIBIDA "
        oDt.Columns("QCNPEN").ColumnName = "QTA PENDIENTE"
        oDt.Columns("STFREC").ColumnName = "STATUS RECEPCIÓN"
        oDt.Columns("STFENT").ColumnName = "STATUS ENTREGA"
        oDt.Columns("TOBS").ColumnName = "BITÁCORA"
        'oDt.Columns("TPLNTA").ColumnName = "PLANTA DE ENTREGA"


        oDs.Tables.Add(oDt)

        oDtResumen.Columns("Proveedor").ColumnName = "RAZÓN SOCIAL"
        oDtResumen.Columns("Ruc").ColumnName = "RUC"
        oDtResumen.Columns("OrdenCompra").ColumnName = "CANT. ORDEN COMPRA"
        oDtResumen.Columns("DiasAtraso").ColumnName = "PROMEDIO DÍAS ATRASO"
        oDtResumen.Columns("Cambios").ColumnName = "PROMEDIO CAMBIOS"
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
        HelpClass.ExportExcelConTitulos(oDs, "Reporte Seguimiento OC Local", strlTitulo)
    End Sub

    Private Sub mtoDtFormater(ByVal cpoDataTable As DataTable)
        cpoDataTable.Columns.Add("Proveedor", GetType(String))
        cpoDataTable.Columns.Add("Ruc", GetType(String))
        cpoDataTable.Columns.Add("OrdenCompra", GetType(Integer))
        cpoDataTable.Columns.Add("DiasAtraso", GetType(String))
        cpoDataTable.Columns.Add("Cambios", GetType(String))

    End Sub

#End Region



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    


    Private Sub frmFiltroExportarXls_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbSituacionOC.pCargarPorCodigo = "T"
    End Sub
End Class
