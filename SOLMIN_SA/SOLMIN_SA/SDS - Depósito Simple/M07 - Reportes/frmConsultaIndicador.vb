Imports RANSA.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario
Imports Ransa.TypeDef.Cliente
Imports RANSA.TYPEDEF.Mercaderia
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmConsultaIndicador
    Private odtMeses As New DataTable()
    Private MaxDiaMes As Int32 = 31
    Private AbrevMes As String = "Dia"
    Private oIndicador As New beIndicador
    Private odtIndicadorGeneral As New DataTable
    Private CCLNT_COD As Int64 = 0
    Private MES_INDEX As Int32 = 0
    Private CCMPN_COD As String = "INICIO"
    Private CDIV_COD As String = "INICIO"


    Private Sub frmConsultaIndicador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ClientePK As TD_ClientePK = New TD_ClientePK(0, objSeguridadBN.pUsuario)
            UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcCompania_Cmb011.pActualizar()
            dgIndicador.AutoGenerateColumns = False
            txtCliente.pCargar(ClientePK)
            ndAnio.Minimum = 0
            ndAnio.Maximum = HelpClass.TodayAnio
            ndAnio.Value = HelpClass.TodayAnio
            MostrarMeses_x_Anio()
            MES_INDEX = dbMes.SelectedIndex

            FormatearCabeceraColumna(False)
            FormatearFilas(False)
            dgIndicador.ReadOnly = True
            dgIndicador.AllowUserToResizeColumns = False
            dgIndicador.AllowUserToResizeRows = False
            dgIndicador.AllowUserToOrderColumns = False


            CCMPN_COD = UcCompania_Cmb011.CCMPN_CodigoCompania
            CDIV_COD = UcDivision_Cmb011.Division

            brIndicador.MaxDiasAbrevMes(ndAnio.Value, dbMes.SelectedValue, MaxDiaMes, AbrevMes)

            btnMantenimiento.Visible = False
        Catch : End Try
    End Sub

    Private Sub MostrarMeses_x_Anio()
        odtMeses.Rows.Clear()
        odtMeses = HelpClass.Meses(ndAnio.Value)
        dbMes.DataSource = odtMeses
        dbMes.ValueMember = "key"
        dbMes.DisplayMember = "value"
        dbMes.SelectedIndex = 0
    End Sub

    Private Sub FormatearFilas(ByVal Habilitar As Boolean)
        dgIndicador.ReadOnly = True
        For Each dr As DataGridViewRow In dgIndicador.Rows
            If (EsFilaEditable(dr.Cells("SINDC").Value.ToString.ToUpper)) Then
                dr.DefaultCellStyle.BackColor = Color.LightYellow
            End If
        Next
     
    End Sub
    Private Function ObtenerFilasEditables() As DataTable
        Dim nomColumna As String = ""
        Dim odtEditable As New DataTable
        odtEditable = odtIndicadorGeneral.Copy
        odtEditable.Rows.Clear()
        Dim dr As DataRow
        For Each drv As DataGridViewRow In dgIndicador.Rows
            If (EsFilaEditable(drv.Cells("SINDC").Value)) Then
                dr = odtEditable.NewRow()
                dr.Item("CTPOIN") = drv.Cells("CTPOIN").Value
                dr.Item("TTPOIN") = drv.Cells("TTPOIN").Value
                dr.Item("TINDCD") = drv.Cells("TINDCD").Value
                dr.Item("CUNDMD") = drv.Cells("CUNDMD").Value
                dr.Item("SINDC") = drv.Cells("SINDC").Value
                dr.Item("TOTAL") = drv.Cells("TOTAL").Value
                dr.Item("PROMEDIO") = drv.Cells("PROMEDIO").Value
                dr.Item("FLAG_TIPO") = drv.Cells("FLAG_TIPO").Value
                For index As Integer = 1 To MaxDiaMes
                    nomColumna = FormatoNombreColumna(index)
                    dr.Item(nomColumna) = drv.Cells(nomColumna).Value
                    If (IsNumeric(dr.Item(nomColumna))) Then
                        dr.Item(nomColumna) = HelpClass.ObjectToUInt64(dr.Item(nomColumna))
                    End If
                Next
                odtEditable.Rows.Add(dr)
            End If
        Next
        Return odtEditable
    End Function
    Private Function EsFilaEditable(ByVal Valor As String) As Boolean
        Dim retorno As Boolean = False
        If (Valor.Trim = "") Then
            retorno = True
        End If
        Return retorno
    End Function
    Private Sub FormatearCabeceraColumna(ByVal VerTodasColumnas As Boolean)
        Dim numColumnas As Int32 = 0
        Dim columna As String = ""
        numColumnas = 31
        For index As Integer = 1 To numColumnas
            columna = FormatoNombreColumna(index)
            dgIndicador.Columns(columna).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgIndicador.Columns(columna).SortMode = DataGridViewColumnSortMode.NotSortable
            If (VerTodasColumnas = True) Then
                dgIndicador.Columns(columna).HeaderText = AbrevMes & "-" & HelpClass.StringRight(columna, 2)
                If (index <= MaxDiaMes) Then
                    dgIndicador.Columns(columna).Visible = True
                Else
                    dgIndicador.Columns(columna).Visible = False
                End If
            Else
                dgIndicador.Columns(columna).Visible = False
            End If
        Next
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub
    Private Function ValidarIngreso() As String
        Dim str As String = ""

        ndAnio.Value = ndAnio.Value
        If (txtCliente.pCodigo = 0) Then
            str = "Seleccione Cliente"
        End If

        If (HelpClass.ObjectToString(ndAnio.Value) = "" Or HelpClass.ObjectToString(ndAnio.Value) = "0") Then
            str = str & Chr(13) & "Ingrese año."
        End If
        If (HelpClass.ObjectToInt64(ndAnio.Value) > HelpClass.TodayAnio) Then
            str = str & Chr(13) & "Año no operativo."
        End If
        If (ndAnio.Value = HelpClass.TodayAnio) Then
            If (HelpClass.ObjectToInt64(dbMes.SelectedValue) > HelpClass.TodayMes) Then
                str = str & Chr(13) & "Mes  no operativo."
            End If
        End If
        Return str
    End Function
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
           
            dgIndicador.DataSource = Nothing
            FormatearCabeceraColumna(False)
            Dim str As String = ""
            str = ValidarIngreso()
            If (str <> "") Then
                MessageBox.Show(str, "Actualizar Indicadores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            ActualizarConsulta()

        Catch ex As Exception

        End Try
    End Sub

    Private Function ObtenerFiltroIndicador() As beIndicador
        oIndicador.PNCCLNT = txtCliente.pCodigo
        oIndicador.PSTCMPL = txtCliente.pRazonSocial
        oIndicador.PNANIOEMI = ndAnio.Value
        oIndicador.PNMESEMI = dbMes.SelectedValue
        oIndicador.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        oIndicador.PSTCMPCM = UcCompania_Cmb011.CompanyName
        oIndicador.PSCDVSN = UcDivision_Cmb011.Division
        oIndicador.PSTCMPDV = UcDivision_Cmb011.DivisionDescripcion
        oIndicador.PNCCLNT = txtCliente.pCodigo
        oIndicador.PSCULUSA = objSeguridadBN.pUsuario
        oIndicador.PSNTRMNL = objSeguridadBN.pstrPCName
        oIndicador.PSABREVMES = AbrevMes
        Return oIndicador
    End Function
    Private Sub ActualizarConsulta()

        Dim obrIndicador As New brIndicador()
        odtIndicadorGeneral.Rows.Clear()
        oIndicador = ObtenerFiltroIndicador()
        odtIndicadorGeneral = obrIndicador.ListarIndicadorPivot(oIndicador).Tables(0)
        dgIndicador.DataSource = odtIndicadorGeneral
        CCLNT_COD = txtCliente.pCodigo
        FormatearCabeceraColumna(True)
        FormatearFilas(False)
    End Sub

    Private Function FormatoNombreColumna(ByVal numeroDia As Int32) As String
        Dim retorno As String = "DIA"
        Dim strDia As String = ""
        strDia = numeroDia.ToString.Trim
        If (strDia.Length <= 1) Then
            strDia = "0" & strDia
        End If
        retorno = retorno & strDia
        Return retorno
    End Function

    Private Sub LimpiarBusqueda()
        FormatearCabeceraColumna(False)
        odtIndicadorGeneral.Rows.Clear()
        dgIndicador.DataSource = Nothing
        dgIndicador.DataSource = odtIndicadorGeneral
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        Try
            If (CCLNT_COD <> txtCliente.pCodigo) Then ' verifica que se ha cambiado de cliente
                LimpiarBusqueda()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ndAnio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndAnio.ValueChanged
        Try
            brIndicador.MaxDiasAbrevMes(ndAnio.Value, dbMes.SelectedValue, MaxDiaMes, AbrevMes)
            LimpiarBusqueda()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnImprimirAnual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirAnual.Click

        Try
            Dim oPrintForm As New PrintForm()
            Dim orptIndicadorAnual As New rptIndicadorAnual()
            Dim obeIndicador As New beIndicador
            Dim obrIndicador As New brIndicador
            Dim odtRptAnual As New DataTable
            obeIndicador = ObtenerFiltroIndicador()
            odtRptAnual = obrIndicador.ListarIndicadorAnual(obeIndicador)
            orptIndicadorAnual.SetDataSource(odtRptAnual)
            CType(orptIndicadorAnual.ReportDefinition.ReportObjects("txtUsuario"), TextObject).Text = objSeguridadBN.pUsuario
            CType(orptIndicadorAnual.ReportDefinition.ReportObjects("txtAnio"), TextObject).Text = ndAnio.Value.ToString
            CType(orptIndicadorAnual.ReportDefinition.ReportObjects("txtCliente"), TextObject).Text = txtCliente.pCodigo & "-" & txtCliente.pRazonSocial
            oPrintForm.ShowForm(orptIndicadorAnual, Me)

        Catch ex As Exception

        End Try

    End Sub

    Private Function Generar_Reporte_Incidencias(ByVal cliente As String, ByVal anio As Integer, ByVal mes As Integer) As DataSet

        Dim dstReportefinal As New DataSet
        Dim dtbReporte As New DataTable("dtbIncidencias")
        Dim dtbreporte_resumen As New DataTable("detalle_Incidencia")

        Try

            Dim objIncidencias As New brIncidencias

            'creando las columnas al datatable
            dtbReporte.Columns.Add("dia1")
            dtbReporte.Columns.Add("dia")
            dtbReporte.Columns.Add("cant_reposicion")
            dtbReporte.Columns.Add("cant_error_codigo")
            dtbReporte.Columns.Add("cant_error_codigo_por_otro")
            dtbReporte.Columns.Add("error_ventas")
            dtbReporte.Columns.Add("error_no_contar_guias")
            dtbReporte.Columns.Add("error_no_cumplir_plazo")
            dtbReporte.Columns.Add("error_no_despachada")
            dtbReporte.Columns.Add("recarga_despachos")
            dtbReporte.Columns.Add("cliente")
            dtbReporte.Columns.Add("observaciones")

            dtbreporte_resumen.Columns.Add("tipo", Type.GetType("System.String"))
            dtbreporte_resumen.Columns.Add("cantidad", Type.GetType("System.Int32"))

            dtbreporte_resumen.Rows.Add(New Object() {"Reposicion por Daño", 0}) '0
            dtbreporte_resumen.Rows.Add(New Object() {"Error por Codigo", 0}) '1
            dtbreporte_resumen.Rows.Add(New Object() {"Error Codigo por Otro", 0}) '2
            dtbreporte_resumen.Rows.Add(New Object() {"Error por Ventas", 0}) '3
            dtbreporte_resumen.Rows.Add(New Object() {"No cuenta con Guias", 0}) '4
            dtbreporte_resumen.Rows.Add(New Object() {"No Cumple con Plazos", 0}) '5
            dtbreporte_resumen.Rows.Add(New Object() {"No Despachada", 0}) '6
            dtbreporte_resumen.Rows.Add(New Object() {"Recarga Despachos", 0}) '7

            'armando una estructura temporal
            For i As Integer = 1 To 30
                dtbReporte.Rows.Add(New Object() {(i & mes & anio), (IIf(i < 10, "0" & i, i) & "/" & IIf(mes < 10, "0" & mes, mes) & "/" & anio), "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"})
            Next

            'Obteniendo la colsulta inicial por rango de fechas
            Dim dtbTemporal As New DataTable
            Dim objParametros As New List(Of String)
            objParametros.Add(cliente)
            objParametros.Add(anio)
            objParametros.Add(mes)
            dtbTemporal = objIncidencias.Reporte_Incidencias(objParametros, 1)

            For i As Integer = 0 To dtbTemporal.Rows.Count - 1

                Dim dia_temporal As String = (dtbTemporal.Rows(i).Item("DDEMI").ToString().Trim() & dtbTemporal.Rows(i).Item("MESEMI").ToString().Trim() & dtbTemporal.Rows(i).Item("AÑOEMI").ToString().Trim())

                'recorre el reporte para rellenar los campos
                For x As Integer = 0 To dtbReporte.Rows.Count - 1

                    If dtbReporte.Rows(x).Item("dia1") = dia_temporal Then

                        If dtbTemporal.Rows(i).Item("CTPOIN").ToString().Trim() = "121" Then
                            dtbReporte.Rows(x).Item("cant_reposicion") = CInt(dtbReporte.Rows(x).Item("cant_reposicion")) + 1
                            dtbreporte_resumen.Rows(0).Item(1) = CInt(dtbreporte_resumen.Rows(0).Item(1)) + 1
                        End If

                        If dtbTemporal.Rows(i).Item("CTPOIN").ToString().Trim() = "122" Then
                            dtbReporte.Rows(x).Item("cant_error_codigo") = CInt(dtbReporte.Rows(x).Item("cant_reposicion")) + 1
                            dtbreporte_resumen.Rows(1).Item(1) = CInt(dtbreporte_resumen.Rows(1).Item(1)) + 1
                        End If

                        If dtbTemporal.Rows(i).Item("CTPOIN").ToString().Trim() = "123" Then
                            dtbReporte.Rows(x).Item("cant_error_codigo_por_otro") = CInt(dtbReporte.Rows(x).Item("cant_reposicion")) + 1
                            dtbreporte_resumen.Rows(2).Item(1) = CInt(dtbreporte_resumen.Rows(2).Item(1)) + 1
                        End If

                        If dtbTemporal.Rows(i).Item("CTPOIN").ToString().Trim() = "124" Then
                            dtbReporte.Rows(x).Item("error_ventas") = CInt(dtbReporte.Rows(x).Item("cant_reposicion")) + 1
                            dtbreporte_resumen.Rows(3).Item(1) = CInt(dtbreporte_resumen.Rows(3).Item(1)) + 1
                        End If

                        If dtbTemporal.Rows(i).Item("CTPOIN").ToString().Trim() = "125" Then
                            dtbReporte.Rows(x).Item("error_no_contar_guias") = CInt(dtbReporte.Rows(x).Item("cant_reposicion")) + 1
                            dtbreporte_resumen.Rows(4).Item(1) = CInt(dtbreporte_resumen.Rows(4).Item(1)) + 1
                        End If

                        If dtbTemporal.Rows(i).Item("CTPOIN").ToString().Trim() = "126" Then
                            dtbReporte.Rows(x).Item("error_no_cumplir_plazo") = CInt(dtbReporte.Rows(x).Item("cant_reposicion")) + 1
                            dtbreporte_resumen.Rows(5).Item(1) = CInt(dtbreporte_resumen.Rows(5).Item(1)) + 1
                        End If

                        dtbReporte.Rows(x).Item("observaciones") = (dtbTemporal.Rows(i).Item("TOBACT") & dtbTemporal.Rows(i).Item("TOBAC1")) & Chr(13)

                    End If

                Next

            Next

            ' dtbReporte.WriteXml("c:\xmlreporte.xml")

            'antes de enviarlo, eliminamos los dias que no tienen registro y formateamos las fechas
cicloborrado:
            For j As Integer = 0 To dtbReporte.Rows.Count - 1

                Dim parcial As Integer = 0

                For c As Integer = 1 To 9
                    If IsNumeric(dtbReporte.Rows(j).Item(c).ToString.Trim) Then
                        parcial = CInt(dtbReporte.Rows(j).Item(c).ToString.Trim) + parcial
                    End If
                Next

                If parcial = 0 Then
                    dtbReporte.Rows.RemoveAt(j)
                    GoTo cicloborrado
                    Exit For
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        dstReporteFinal.Tables.Add(dtbReporte)
        dstReporteFinal.Tables.Add(dtbreporte_resumen)

        Return dstReportefinal
    End Function

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim strMensaje As String = ""
        Dim oPrintForm As New PrintForm()
        Dim nomTxtObject As String = ""
        Dim columna As String = ""
        Dim obrIndicador As New brIndicador
        Dim orptIndicadorMensual As New rptIndicadorMensual
        Dim odsRPT As New DataSet
        Dim obeFiltro As New beIndicador

       


        Try
            strMensaje = ValidarIngreso()
            If (strMensaje <> "") Then
                MessageBox.Show(strMensaje, "Filtros Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            obeFiltro = ObtenerFiltroIndicador()
            odsRPT = obrIndicador.ListarIndicadorResumenMensual(obeFiltro)

            orptIndicadorMensual.SetDataSource(odsRPT.Tables(0))
            orptIndicadorMensual.Subreports.Item("rptGraficoMensual").SetDataSource(odsRPT.Tables(1))
            orptIndicadorMensual.Subreports.Item("rptGraficoERISKU").SetDataSource(odsRPT.Tables(2))
            orptIndicadorMensual.Subreports.Item("rptGraficoERISKU_x100").SetDataSource(odsRPT.Tables(3))
            orptIndicadorMensual.Subreports.Item("rptGraficoERIUBICACION").SetDataSource(odsRPT.Tables(4))
            orptIndicadorMensual.Subreports.Item("rptGraficoERIUBICACION_x100").SetDataSource(odsRPT.Tables(5))
            orptIndicadorMensual.Subreports.Item("rptGraficoOCUPACION").SetDataSource(odsRPT.Tables(6))
            orptIndicadorMensual.Subreports.Item("rptGraficoOCUPACION_x100").SetDataSource(odsRPT.Tables(7))

            Dim dtbIncidencia As New DataTable
            dtbIncidencia = Generar_Reporte_Incidencias(txtCliente.pCodigo, ndAnio.Value.ToString, dbMes.SelectedValue).Tables(0)
            ' orptIndicadorMensual.Subreports.Item("rptIncidencias").SetDataSource(dtbIncidencia)

            Dim dtbdetalle As New DataTable
            dtbdetalle = Generar_Reporte_Incidencias(txtCliente.pCodigo, ndAnio.Value.ToString, dbMes.SelectedValue).Tables(1)
            orptIndicadorMensual.Subreports.Item("rptDetalleIncidencia").SetDataSource(dtbdetalle)

            'datatable solo para el grafico
            Dim dtbGrafico As New DataTable
            dtbGrafico = Generar_Reporte_Incidencias(txtCliente.pCodigo, ndAnio.Value.ToString, dbMes.SelectedValue).Tables(1)
            orptIndicadorMensual.Subreports.Item("rptGraficoDetalleIncidencia").SetDataSource(dtbGrafico)

            CType(orptIndicadorMensual.ReportDefinition.ReportObjects("txtUsuario"), TextObject).Text = objSeguridadBN.pUsuario
            CType(orptIndicadorMensual.ReportDefinition.ReportObjects("txtAnio"), TextObject).Text = ndAnio.Value.ToString
            CType(orptIndicadorMensual.ReportDefinition.ReportObjects("txtMes"), TextObject).Text = dbMes.Text
            CType(orptIndicadorMensual.ReportDefinition.ReportObjects("txtCliente"), TextObject).Text = txtCliente.pCodigo & "-" & txtCliente.pRazonSocial
            For index As Integer = 1 To 31
                columna = HelpClass.StringRight(FormatoNombreColumna(index), 2)
                nomTxtObject = "txtDia"
                nomTxtObject = nomTxtObject & columna
                If (index > MaxDiaMes) Then
                    CType(orptIndicadorMensual.ReportDefinition.ReportObjects(nomTxtObject), TextObject).Text = ""
                Else
                    CType(orptIndicadorMensual.ReportDefinition.ReportObjects(nomTxtObject), TextObject).Text = AbrevMes & "-" & columna
                End If
            Next
            If (MaxDiaMes = 28) Then
                CType(orptIndicadorMensual.ReportDefinition.ReportObjects("Line37"), LineObject).LineColor = Color.White
                CType(orptIndicadorMensual.ReportDefinition.ReportObjects("Line38"), LineObject).LineColor = Color.White
            End If
            If (MaxDiaMes = 29) Then
                CType(orptIndicadorMensual.ReportDefinition.ReportObjects("Line38"), LineObject).LineColor = Color.White
            End If

            oPrintForm.ShowForm(orptIndicadorMensual, Me)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.TYPEDEF.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            If (CCMPN_COD <> UcDivision_Cmb011.Compania) Then
                UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
                UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
                UcDivision_Cmb011.pActualizar()
                CCMPN_COD = UcDivision_Cmb011.Compania
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.TYPEDEF.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        Try
            If (CDIV_COD <> UcDivision_Cmb011.Division) Then
                CDIV_COD = UcDivision_Cmb011.Division
                LimpiarBusqueda()
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtCliente_ExitFocusWithOutData() Handles txtCliente.ExitFocusWithOutData
        Try
            If (txtCliente.pCodigo = 0) Then
                LimpiarBusqueda()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbMes.SelectedIndexChanged
        Try
            If (MES_INDEX <> dbMes.SelectedIndex) Then
                LimpiarBusqueda()
                brIndicador.MaxDiasAbrevMes(ndAnio.Value, dbMes.SelectedValue, MaxDiaMes, AbrevMes)
                MES_INDEX = dbMes.SelectedIndex
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        If (dgIndicador.Rows.Count <= 0) Then
            Exit Sub
        End If
        Dim ofrmMantIndicador As New frmMantIndicador
        Dim odt As New DataTable
        Dim oInfoIndicador As New beIndicador
        Dim oFiltroIndicador As New beIndicador
        Try
            oFiltroIndicador = ObtenerFiltroIndicador()
            oInfoIndicador.PNCCLNT = oFiltroIndicador.PNCCLNT
            oInfoIndicador.PSTCMPL = oFiltroIndicador.PSTCMPL
            oInfoIndicador.PSCCMPN = oFiltroIndicador.PSCCMPN
            oInfoIndicador.PSTCMPCM = oFiltroIndicador.PSTCMPCM
            oInfoIndicador.PSCDVSN = oFiltroIndicador.PSCDVSN
            oInfoIndicador.PSTCMPDV = oFiltroIndicador.PSTCMPDV
            oInfoIndicador.PNMAXDIAS = oFiltroIndicador.PNMAXDIAS
            oInfoIndicador.PNANIOEMI = oFiltroIndicador.PNANIOEMI
            oInfoIndicador.PNMESEMI = oFiltroIndicador.PNMESEMI
            oInfoIndicador.PSABREVMES = oFiltroIndicador.PSABREVMES
            oInfoIndicador.PSCULUSA = objSeguridadBN.pUsuario
            oInfoIndicador.PSNTRMNL = objSeguridadBN.pstrPCName
            odt = ObtenerFilasEditables()
            ofrmMantIndicador.odtInfoIndicador = odt
            ofrmMantIndicador.oInfoIndicador = oInfoIndicador
            ofrmMantIndicador.ShowDialog(Me)
            If (ofrmMantIndicador.myDialogOk = True) Then
                tspOpcion.Enabled = False
                ActualizarConsulta()
                tspOpcion.Enabled = True
            End If
        Catch ex As Exception
            tspOpcion.Enabled = True
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If (dgIndicador.Rows.Count > 0) Then
                Dim oldtgExcel As New List(Of DataGridView)
                oldtgExcel.Add(Me.dgIndicador)
                HelpClass.ExportarExcel_Add0(oldtgExcel)
            End If
        
        Catch ex As Exception
        End Try

    End Sub



    Private Sub dgIndicador_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgIndicador.CellDoubleClick
        Try
            Dim CTPOIN_DESCRIPCION As String = ""
            'Para mantenimiento de las incidencias
            If (e.RowIndex <= -1) Then Exit Sub
            If (e.ColumnIndex >= 11 And e.ColumnIndex <= 41) Then
                If (IsNumeric(dgIndicador.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) Then
                    If (dgIndicador.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> 0) Then
                        Dim ofrmIndicadorObservacion As New frmIndicadorObservacion
                        Dim oInfobeIndicador As New beIndicador
                        oInfobeIndicador = ObtenerFiltroIndicador()
                        oInfobeIndicador.PNCTPOIN = dgIndicador.Rows(e.RowIndex).Cells("CTPOIN").Value
                        oInfobeIndicador.PNDDEMI = dgIndicador.Columns(e.ColumnIndex).Name.Trim.Substring(3, 2)
                        CTPOIN_DESCRIPCION = oInfobeIndicador.PNCTPOIN & " - " & HelpClass.ObjectToString(dgIndicador.Rows(e.RowIndex).Cells("TTPOIN").Value) & " - " & HelpClass.ObjectToString(dgIndicador.Rows(e.RowIndex).Cells("TINDCD").Value)
                        If (oInfobeIndicador.PNCTPOIN > 120 And oInfobeIndicador.PNCTPOIN < 130) Then
                            ofrmIndicadorObservacion.oInfoIndicador = oInfobeIndicador
                            ofrmIndicadorObservacion.CTPOIN_DESCRIPCION = CTPOIN_DESCRIPCION
                            ofrmIndicadorObservacion.ShowDialog(Me)
                        End If
                    End If
                End If
              
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgIndicador_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgIndicador.CellContentClick

    End Sub

    Private Sub btnMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMantenimiento.Click



        If Me.txtCliente.pRazonSocial = "" Then Exit Sub

        'debe de seleccionar el
        Dim objMantenimiento As New frmMantenimientoIndicador
        'objMantenimiento.Anio = ndAnio.Value.ToString
        'objMantenimiento.Mes = dbMes.SelectedValue
        'objMantenimiento.Cliente = Me.txtCliente.pCodigo
        'objMantenimiento.NombreCliente = Me.txtCliente.pRazonSocial
        objMantenimiento.ShowDialog(Me)

    End Sub

End Class
