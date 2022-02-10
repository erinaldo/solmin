Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmReporteAnualSegLocal
    Private _pObeOrdenDeCompra As beOrdenCompra
    Private dsGeneral As DataSet
    Private strExportar As String

    Public Property pObeOrdenDeCompra() As beOrdenCompra
        Get
            Return _pObeOrdenDeCompra
        End Get
        Set(ByVal value As beOrdenCompra)
            _pObeOrdenDeCompra = value
        End Set
    End Property

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            strExportar = "EXCEL"
            If validarAnio() Then
                btnExportar.Enabled = False
                btnExportarPdf.Enabled = False
                txtAnio.Enabled = False
                icoEspera.Visible = True
                bgwExportar.RunWorkerAsync()
            End If
        Catch : End Try

    End Sub
#Region "Exportar Excel"

    'Private Sub ExportarExcel(ByVal oDtExcel As DataTable)
    '    If oDtExcel Is Nothing OrElse oDtExcel.Columns.Count = 0 Then Exit Sub
    '    Dim oDs As New DataSet
    '    oDs.Tables.Add(oDtExcel)

    '    Dim strlTitulo As New List(Of String)
    '    strlTitulo.Add("Cliente :\n" & _pObeOrdenDeCompra.Cliente)
    '    strlTitulo.Add("Planta :\n" & _pObeOrdenDeCompra.Planta)
    '    If _pObeOrdenDeCompra.Proveedor.Trim.Equals("") Then
    '        strlTitulo.Add("Proveedor :\nTODOS")
    '    Else
    '        strlTitulo.Add("TProveedor :\n" & _pObeOrdenDeCompra.Proveedor)
    '    End If
    '    strlTitulo.Add("Fecha entrega proveedor:\n" & IIf(dteFechaCompInicial.Checked, dteFechaCompInicial.Value.Date, "") & " - " & IIf(dteFechaCompFinal.Checked, dteFechaCompFinal.Value.Date, ""))
    '    HelpClass.ExportExcelConTitulos(oDs, "Reporte Seguimiento OC Local", strlTitulo)
    'End Sub

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
        DtResumen.DefaultView.Sort = "Vencidas DESC" 'Select("", "Vencidas DESC")

        Return DtResumen
    End Function
    Private Sub MostrarExportarExcelOC(ByVal dtsReport As DataSet)
        Try
            Dim strlTitulo As New List(Of String)
            strlTitulo.Add("Cliente :\n" & _pObeOrdenDeCompra.PNCCLNT & " - " & _pObeOrdenDeCompra.Cliente)
            strlTitulo.Add("Planta :\n" & _pObeOrdenDeCompra.Planta)
            strlTitulo.Add("Año:\n" & Me.txtAnio.Text)
            HelpClass.ExportExcelConSeguimientoOC_V3(dtsReport, Me.Text, strlTitulo)
            icoEspera.Visible = False
            dsGeneral = Nothing
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ExportarExcelOC()

        Dim oDs As New DataSet
        Dim dtsReport As New DataSet
        Dim dt As DataTable
        Dim obrOrdenDeCompra As New clsOC
        With pObeOrdenDeCompra
            .PNANIO = Me.txtAnio.Text
        End With
        oDs = obrOrdenDeCompra.fdsReporteAnualSegOC(pObeOrdenDeCompra)
        For index As Integer = 0 To 2
            dt = CrearTablaResumenMensualExcel(oDs.Tables(index))
            dtsReport.Tables.Add(dt.Copy)
        Next

        dt = oDs.Tables(3).Copy
        dt.TableName = "Table4"
        dtsReport.Tables.Add(dt.Copy)
        dsGeneral = dtsReport
    End Sub
    Private Function validarAnio() As Boolean
        If txtAnio.Text = "" Then
            MessageBox.Show("Debe ingresar un año", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        ElseIf Val(txtAnio.Text) < 1900 Or Val(txtAnio.Text) > Date.Now.Year Then
            MessageBox.Show(String.Format("El año, no se encuentra en el rango [1900 - {0}]", Date.Now.Year), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function
    Private Sub MostrarExportarPDFOC(ByVal dtsReport As DataSet)
        Try
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
            Dim rutaArchivo As String = Application.StartupPath.ToString & _
                                      "\report" & HelpClass.NowNumeric & ".pdf"
            CrDiskFileDestinationOptions.DiskFileName = rutaArchivo
            Dim miReporte As New crSeguimientoLocal

            Dim dtDataTabla1 As New DataTable
            Dim dtDataTabla2 As New DataTable
            Dim dtDataTabla3 As New DataTable
            Dim dtDataTabla4 As New DataTable
            Dim dtDataTabla5 As New DataTable

            dtDataTabla1.TableName = "DataTable1"
            dtDataTabla1 = dtsReport.Tables(0).Copy

            dtDataTabla4.TableName = "DataTable4"
            dtDataTabla4 = dtsReport.Tables(1).Copy

            dtDataTabla5.TableName = "DataTable5"
            dtDataTabla5 = dtsReport.Tables(2).Copy

            miReporte.SetDataSource(dtDataTabla1)
            miReporte.Subreports(0).SetDataSource(dtDataTabla4)
            miReporte.Subreports(1).SetDataSource(dtDataTabla5)
            miReporte.SetParameterValue("paramCliente", _pObeOrdenDeCompra.PNCCLNT & " - " & _pObeOrdenDeCompra.Cliente)
            miReporte.SetParameterValue("paramPlanta", _pObeOrdenDeCompra.Planta)
            miReporte.SetParameterValue("paramAnio", Me.txtAnio.Text)

            CrExportOptions = miReporte.ExportOptions
            With CrExportOptions

                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With


            miReporte.Export()
            AbrirDocumento(rutaArchivo)
            icoEspera.Visible = False
            dsGeneral = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub ExportarPDFOC()
        Dim oDs As New DataSet
        Dim dtsReport As New DataSet
        Dim dt As DataTable
        Dim obrOrdenDeCompra As New clsOC
        With pObeOrdenDeCompra
            .PNANIO = Me.txtAnio.Text
        End With
        oDs = obrOrdenDeCompra.fdsReporteAnualSegOC(pObeOrdenDeCompra)
        'For index As Integer = 0 To 2
        dt = CrearTablaResumenMensualPDF(oDs)
        dt.TableName = "Table1"
        dtsReport.Tables.Add(dt.Copy)
        ' Next
        dt = CrearTablaGraficoComprasAbiertas(dtsReport.Tables(0))
        dt.TableName = "Table4"
        dtsReport.Tables.Add(dt.Copy)

        dt = CrearTablaGraficoComprasVencidas(oDs.Tables(3))
        dt.TableName = "Table5"
        dtsReport.Tables.Add(dt.Copy)

        dsGeneral = dtsReport
    End Sub
    Public Shared Sub AbrirDocumento(ByVal Path As String)
        Try
            Dim InfoProceso As New System.Diagnostics.ProcessStartInfo
            Dim Proceso As New System.Diagnostics.Process
            With InfoProceso
                .FileName = Path
                .CreateNoWindow = True
                .ErrorDialog = True
                .UseShellExecute = True
                .WindowStyle = ProcessWindowStyle.Normal
            End With
            Proceso.StartInfo = InfoProceso
            Proceso.Start()
            Proceso.Dispose()
        Catch
        End Try
    End Sub
    Private Function CrearTablaResumenMensualExcel(ByVal dt As DataTable) As DataTable
        Dim dtTemp As New DataTable
        Dim dtv As New DataView(dt)
        dtv.Sort = "FORCML asc"
        Dim dataV As DataTable = dtv.ToTable(True, "FORCML", "ATETIM", "ATETAR", "NRDIA_EC")
        Dim column As String = ""

        'creandp el datatable dinamico de meses

        For i As Integer = 1 To 12
            If i < 10 Then
                column = String.Format("0{0}", i)
            Else
                column = i.ToString
            End If
            dtTemp.Columns.Add(column, GetType(Decimal))

        Next
        Dim datRowNew As DataRow
        For x As Integer = 0 To 2
            datRowNew = dtTemp.NewRow
            For c As Integer = 0 To dataV.Rows.Count - 1
                If x = 2 Then
                    If dataV.Rows(c).Item(x) <> 0 Then
                        datRowNew(dataV.Rows(c)("FORCML").ToString.Trim) = dataV.Rows(c).Item(x + 1) / dataV.Rows(c).Item(x)
                    End If
                Else
                    datRowNew(dataV.Rows(c)("FORCML").ToString.Trim) = dataV.Rows(c).Item(x + 1)
                End If
            Next
            dtTemp.Rows.Add(datRowNew)
        Next
        Return dtTemp
    End Function
    Private Function CrearTablaResumenMensualPDF(ByVal ds As DataSet) As DataTable
        Dim dtTemp As New DataTable
        Dim column As String = ""
        Dim lstMeses As New List(Of String)
        Dim lstItems As New List(Of String)
        Dim lstHeader As New List(Of String)
        lstMeses.Add("TODOS")
        lstMeses.Add("ENERO")
        lstMeses.Add("FEBRERO")
        lstMeses.Add("MARZO")
        lstMeses.Add("ABRIL")
        lstMeses.Add("MAYO")
        lstMeses.Add("JUNIO")
        lstMeses.Add("JULIO")
        lstMeses.Add("AGOSTO")
        lstMeses.Add("SETIEMBRE")
        lstMeses.Add("OCTUBRE")
        lstMeses.Add("NOVIEMBRE")
        lstMeses.Add("DICIEMBRE")

        lstItems.Add("Atenciones a tiempo")
        lstItems.Add("Atenciones tardias")
        lstItems.Add("Promedio días de atraso")

        lstHeader.Add("Lineas de Ordenes de Compras")
        lstHeader.Add("Lineas de Ordenes de Stock")
        lstHeader.Add("Lineas de Ordenes de Cargo Directo")

        'creandp el datatable dinamico de meses
        dtTemp.Columns.Add("TABLA", GetType(Integer))
        dtTemp.Columns.Add("HEADER", GetType(String))
        dtTemp.Columns.Add("ITEM", GetType(String))
        For i As Integer = 1 To 12
            dtTemp.Columns.Add(lstMeses(i), GetType(Decimal))
        Next
        Dim datRowNew As DataRow
        For s As Integer = 0 To ds.Tables.Count - 2
            Dim dtv As New DataView(ds.Tables(s))
            dtv.Sort = "FORCML asc"
            Dim dataV As DataTable = dtv.ToTable(True, "FORCML", "ATETIM", "ATETAR", "NRDIA_EC")

            For x As Integer = 0 To 2
                datRowNew = dtTemp.NewRow
                datRowNew("TABLA") = s + 1
                datRowNew("HEADER") = lstHeader(s)
                datRowNew("ITEM") = lstItems(x)
                For c As Integer = 0 To dataV.Rows.Count - 1
                    If x = 2 Then
                        If dataV.Rows(c).Item(x) <> 0 Then
                            column = lstMeses(CType(dataV.Rows(c)("FORCML").ToString.Trim, Integer))
                            datRowNew(column) = dataV.Rows(c).Item(x + 1) / dataV.Rows(c).Item(x)
                        End If
                    Else
                        datRowNew(lstMeses(CType(dataV.Rows(c)("FORCML").ToString.Trim, Integer))) = dataV.Rows(c).Item(x + 1)
                    End If
                Next
                dtTemp.Rows.Add(datRowNew)
            Next
        Next
        Return dtTemp
    End Function
    Private Function CrearTablaGraficoComprasAbiertas(ByVal dt As DataTable) As DataTable
        Dim dtTemp As New DataTable
        Dim dr As DataRow
        Dim lstItems As New List(Of String)
        dtTemp.Columns.Add("ITEM", GetType(String))
        dtTemp.Columns.Add("CANTIDAD", GetType(Decimal))
        dtTemp.Columns.Add("PORCENTAJE", GetType(Decimal))
        Dim suma As Decimal = 0
        Dim index As Integer = 0
        lstItems.Add("No vencidas")
        lstItems.Add("Vencidas")

        For row As Integer = 0 To dt.Rows.Count - 2
            If dt.Rows(row).Item("TABLA") = 1 Then
                If index < 2 Then
                    dr = dtTemp.NewRow
                    dr("ITEM") = lstItems(row)
                    For col As Integer = 3 To dt.Columns.Count - 1
                        If IsDBNull(dt.Rows(row).Item(col)) = False Then
                            suma += Convert.ToDecimal(dt.Rows(row).Item(col).ToString.Trim)
                        End If
                    Next
                    dr("CANTIDAD") = suma
                    suma = 0
                    dtTemp.Rows.Add(dr)
                    index += 1
                End If
            Else
                Exit For
            End If
        Next
        'CALCULAMOS EL TOTAL Y PORCENTAJES
        Dim total As Decimal
        total = dtTemp.Compute("sum(cantidad)", "")

        For row As Integer = 0 To dtTemp.Rows.Count - 1
            dtTemp.Rows(row).Item("PORCENTAJE") = (dtTemp.Rows(row).Item("CANTIDAD") / total) * 100
        Next

        Return dtTemp
    End Function
    Private Function CrearTablaGraficoComprasVencidas(ByVal dt As DataTable) As DataTable
        Dim dtTemp As New DataTable
        Dim dr As DataRow
        Dim lstItems As New List(Of String)
        dtTemp.Columns.Add("ITEM", GetType(String))
        dtTemp.Columns.Add("CANTIDAD", GetType(Decimal))
        dtTemp.Columns.Add("PORCENTAJE", GetType(Decimal))
        Dim suma As Decimal = 0

        lstItems.Add("Menor o igual a 5 días")
        lstItems.Add("Entre 6 y 20 días")
        lstItems.Add("Mayor o igual a 21 días")

        For row As Integer = 0 To dt.Rows.Count - 1
            For col As Integer = 1 To dt.Columns.Count - 1
                dr = dtTemp.NewRow
                dr("ITEM") = lstItems(col - 1)
                dr("CANTIDAD") = dt.Rows(row).Item(col)
                dtTemp.Rows.Add(dr)
            Next

        Next
        'CALCULAMOS EL TOTAL Y PORCENTAJES
        Dim total As Decimal
        total = dtTemp.Compute("sum(cantidad)", "")

        For row As Integer = 0 To dtTemp.Rows.Count - 1
            dtTemp.Rows(row).Item("PORCENTAJE") = (IIf(IsDBNull(dtTemp.Rows(row).Item("CANTIDAD")), 0, dtTemp.Rows(row).Item("CANTIDAD")) / total) * 100
        Next

        Return dtTemp
    End Function
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
    Private Sub txtAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnExportarPdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarPdf.Click
        Try
            strExportar = "PDF"
            If validarAnio() Then
                btnExportar.Enabled = False
                btnExportarPdf.Enabled = False
                txtAnio.Enabled = False
                icoEspera.Visible = True
                bgwExportar.RunWorkerAsync()
            End If
        Catch : End Try

    End Sub

    Private Sub frmReporteAnualSegLocal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtAnio.Text = Date.Now.Year
    End Sub

    Private Sub bgwExportar_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwExportar.DoWork
        If strExportar.Equals("PDF") Then
            ExportarPDFOC()
        ElseIf strExportar.Equals("EXCEL") Then
            ExportarExcelOC()
        End If

    End Sub

    Private Sub bgwExportar_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwExportar.RunWorkerCompleted
        If strExportar.Equals("PDF") Then
            MostrarExportarPDFOC(dsGeneral)
        ElseIf strExportar.Equals("EXCEL") Then
            MostrarExportarExcelOC(dsGeneral)
        End If

    End Sub
End Class
