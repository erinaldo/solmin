
Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.TYPEDEF.OrdenCompra
Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes
Imports RANSA.Utilitario

Public Class frmReporteEntrega
    Private objTemp As TipoDato_ResultaReporte

    Private Sub frmRptIngresoXAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-- Crear status por control con F4
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RepRecepcionPorAlmacenClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

        'tsbAmpliar.Image = pbxAmpliar.Image
        dteFechaInicial.Value = Now
        dteFechaInicial.Checked = False
        dteFechaFinal.Value = Now
        dteFechaFinal.Checked = False

        objAppConfig = Nothing
    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If txtCliente.pCodigo = 0 Then strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
        Return blnResultado
    End Function

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pGenerarReporte()
    End Sub
    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        tsbGenerarReporte.Enabled = True
        'tsbExportarPDF.Enabled = True
        tsbEnviarCorreo.Enabled = True
        tsbExportarExcel.Enabled = True
        crvReporte.Visible = True
        crvReporte.ReportSource = objTemp.pReporte
    End Sub
    Sub pGenerarReporte()
        Dim objAppConfig As cAppConfig = New cAppConfig
        If Me.rbtOrdenDeCompra.Checked Then
            pReporteEntegaPorOC()
        Else
            pReporteEntegaPorItem()
        End If
        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("RepRecepcionPorAlmacenClienteCodigo", txtCliente.pCodigo)
        objAppConfig = Nothing
    End Sub

    Private Sub pReporteEntegaPorItem(Optional ByVal tipoExcel As String = "", Optional ByVal TipoReporte As String = "")

        Dim crParameterDiscreteValue As CrystalDecisions.Shared.ParameterDiscreteValue
        Dim crParameterFieldDefinitions As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
        Dim crParameterFieldLocation As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
        Dim crParameterValues As CrystalDecisions.Shared.ParameterValues
        '-----------------

        Dim objDs As New DataSet
        Dim objDt As DataTable
        Dim objrptEmbAlm As New rptEntregaEmbAlmItem
        Dim pnCliente As Integer = Me.txtCliente.pCodigo
        Dim pnFechaIni As Integer = HelpClass.CDate_a_Numero8Digitos(Me.dteFechaInicial.Value)
        Dim pnFechaFin As Integer = HelpClass.CDate_a_Numero8Digitos(Me.dteFechaFinal.Value)
        Dim oReporte = New brReporteDS
        objDt = oReporte.dtRepEntregaEmbAlmItem(pnCliente, pnFechaIni, pnFechaFin)

        objDt.TableName = "dtRepEntregaEmbAlm"
        objDs.Tables.Add(objDt.Copy)
        objrptEmbAlm.SetDataSource(objDs)
        '------------------------------
        crParameterFieldDefinitions = objrptEmbAlm.DataDefinition.ParameterFields
        crParameterFieldLocation = crParameterFieldDefinitions.Item("@RangoFechas")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = "Desde: " & Me.dteFechaInicial.Value.Date & " Hasta: " & Me.dteFechaFinal.Value.Date
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)
        '--------------------------------------
        objTemp = New TipoDato_ResultaReporte
        objTemp.Tables.Add(objDt.Copy)
        objTemp.pReporte = objrptEmbAlm
    End Sub


    Private Sub pReporteEntegaPorOC(Optional ByVal tipoExcel As String = "", Optional ByVal TipoReporte As String = "")


        Dim crParameterDiscreteValue As CrystalDecisions.Shared.ParameterDiscreteValue
        Dim crParameterFieldDefinitions As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
        Dim crParameterFieldLocation As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
        Dim crParameterValues As CrystalDecisions.Shared.ParameterValues
        '-----------------

        Dim objDs As New DataSet
        Dim objDt As DataTable
        Dim objrptEmbAlm As New rptEntregaEmbAlmOc
        Dim pnCliente As Integer = Me.txtCliente.pCodigo
        Dim pnFechaIni As Integer = HelpClass.CDate_a_Numero8Digitos(Me.dteFechaInicial.Value)
        Dim pnFechaFin As Integer = HelpClass.CDate_a_Numero8Digitos(Me.dteFechaFinal.Value)
        Dim oReporte = New brReporteDS
        objDt = oReporte.dtRepEntregaEmbAlmOC(pnCliente, pnFechaIni, pnFechaFin)

        objDt.TableName = "dtRepEntregaEmbAlm"
        objDs.Tables.Add(objDt.Copy)
        objrptEmbAlm.SetDataSource(objDs)
        '------------------------------
        crParameterFieldDefinitions = objrptEmbAlm.DataDefinition.ParameterFields
        crParameterFieldLocation = crParameterFieldDefinitions.Item("@RangoFechas")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = "Desde: " & Me.dteFechaInicial.Value.Date & " Hasta: " & Me.dteFechaFinal.Value.Date
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)
        '--------------------------------------
        objTemp = New TipoDato_ResultaReporte
        objTemp.Tables.Add(objDt.Copy)
        objTemp.pReporte = objrptEmbAlm

    End Sub

    Private Function ReturnTableFormated(ByVal oDt As DataTable) As DataTable
        Dim oDtFiltro As New DataTable

        Dim OdtNew As New DataTable
        Dim oDr As DataRow
        OdtNew = oDt.Clone
        For i As Integer = 0 To oDt.Rows.Count
            If i = oDt.Rows.Count Then
                oDtFiltro = SelectDataTable(oDt, "TIPO = '" + oDt.Rows(i - 1).Item("TIPO") + "'")
                oDr = OdtNew.NewRow()
                oDr(1) = "SUB TOTALES : "
                oDr("DIF_FECHAS") = SumarDataTable(oDtFiltro, "DIF_FECHAS")
                OdtNew.Rows.Add(oDr)

                oDr = OdtNew.NewRow()
                oDr(1) = "TOTALES : "
                oDr("DIF_FECHAS") = SumarDataTable(oDt, "DIF_FECHAS")
                OdtNew.Rows.Add(oDr)
                Exit For
            End If
            If i > 1 AndAlso oDt.Rows(i).Item("TIPO") <> oDt.Rows(i - 1).Item("TIPO") Then
                oDtFiltro = SelectDataTable(oDt, "TIPO = '" + oDt.Rows(i - 1).Item("TIPO") + "'")
                oDr = OdtNew.NewRow()
                oDr(1) = "SUB TOTALES : "
                oDr("DIF_FECHAS") = SumarDataTable(oDtFiltro, "DIF_FECHAS")
                OdtNew.Rows.Add(oDr)
            End If

            OdtNew.ImportRow(oDt.Rows(i))
        Next
        Return OdtNew
    End Function

    Private Function SumarDataTable(ByVal oDt As DataTable, ByVal strNombreColumna As String) As Decimal
        Dim decSuma As Decimal = 0
        For index As Integer = 0 To oDt.Rows.Count - 1
            decSuma = decSuma + oDt.Rows(index).Item(strNombreColumna)
        Next
        Return decSuma
    End Function

    Private Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String) As DataTable
        Dim rows As DataRow()
        Dim dtNew As DataTable

        dtNew = dt.Clone()
        rows = dt.Select(filter)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next

        Return dtNew
    End Function


    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Call mpEnviarEMail(objTemp, "", "Informe : " + "")
    End Sub

    Private Sub tsbExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dlgSavePDF As SaveFileDialog = New SaveFileDialog
        dlgSavePDF.Filter = "Adobe Acrobat PDF (*.pdf)|*.pdf"
        dlgSavePDF.CheckPathExists = True
        If dlgSavePDF.ShowDialog = Windows.Forms.DialogResult.OK Then
            objTemp.pReporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dlgSavePDF.FileName)
        End If
        dlgSavePDF.Dispose()
        dlgSavePDF = Nothing
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            Dim oDtExcel As New DataTable
            If Me.rbtOrdenDeCompra.Checked Then
                oDtExcel = ReturnTableFormated(objTemp.Tables(0))
                ExportarExcelOC(oDtExcel)
            Else
                ExportarExcelItem(objTemp.Tables(0))
            End If
        Catch : End Try
    End Sub


    Private Sub ExportarExcelItem(ByVal oDtExcel As DataTable)
        Dim oDt As New DataTable
        Dim oDs As New DataSet
        oDt = oDtExcel.Copy
        Dim objListdt As New List(Of DataTable)
        oDt.Columns.Remove("CCLNT")
        oDt.Columns.Remove("TCMPCL")
        oDt.Columns.Remove("QRLCSC")

        oDt.Columns("NORSCI").ColumnName = "EMBARQUE"
        oDt.Columns("PNNMOS").ColumnName = "O/S AGENCIA"
        oDt.Columns("TNMAGC").ColumnName = "AGENCIA CARGA"
        oDt.Columns("TCANAL").ColumnName = "CANAL"
        oDt.Columns("TNRODU").ColumnName = "DUA"
        oDt.Columns("NDOCEM").ColumnName = "BL"
        oDt.Columns("REFDO1").ColumnName = "REF. DOCUMENTO"
        oDt.Columns("FRETES").ColumnName = "ENTREGA ALMACEN (1) "
        oDt.Columns("NORCML").ColumnName = "ORDEN DE COMPRA"
        oDt.Columns("CMRCLR").ColumnName = "COD. MERCADER�A"
        oDt.Columns("QTRMC").ColumnName = "CANTIDA"
        oDt.Columns("NORDSR").ColumnName = "ORDEN DE SERVICIO"
        oDt.Columns("FRLZSR").ColumnName = "FECHA (2)"
        oDt.Columns("NGUIRN").ColumnName = "GU�A INGRESO"
        oDt.Columns("TDITES").ColumnName = "MERCADERIA"
        oDt.Columns("DIF_FECHAS").ColumnName = "# DIAS (2)-(1)"

        oDs.Tables.Add(oDt)

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    End Sub

    Private Sub ExportarExcelOC(ByVal oDtExcel As DataTable)
        Dim oDt As New DataTable
        oDt = oDtExcel.Copy
        Dim oDs As New DataSet

        'Eliminado
        oDt.Columns.Remove("CCLNT")
        oDt.Columns.Remove("TCMPCL")
        oDt.Columns("FRLZSR").ColumnName = "FECHA (2)"
        oDt.Columns("NORCML").ColumnName = "ORDEN DE COMPRA"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("NGUICL").ColumnName = "GU�A PROVEEDOR"
        oDt.Columns("TTINTC").ColumnName = "INCOTERM"
        oDt.Columns("NGUIRN").ColumnName = "GUIA INGRESO"
        oDt.Columns("NORSCI").ColumnName = "EMBARQUE"
        oDt.Columns("PNNMOS").ColumnName = "O/S AGENCIA"
        oDt.Columns("REFDO1").ColumnName = "REF. DOCUMENTO"
        oDt.Columns("NDOCEM").ColumnName = "BL"
        oDt.Columns("TNRODU").ColumnName = "DUA"
        oDt.Columns("FRETES").ColumnName = "ENTREGA ALMACEN (1)"
        oDt.Columns("TIPO").ColumnName = "TIPO"
        oDt.Columns("DIF_FECHAS").ColumnName = "# DIAS (2)-(1)"""

        oDt.TableName = "ENTREGA-ALMACEN"

        oDs.Tables.Add(oDt)

        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    End Sub



    Private Sub tsbGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarReporte.Click

        If fblnValidaInformacion() Then
            pcxEspera.Visible = True
            pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
            pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)
            'tsbExportarPDF.Enabled = False
            tsbEnviarCorreo.Enabled = False
            tsbExportarExcel.Enabled = False
            tsbGenerarReporte.Enabled = False
            crvReporte.Visible = False
            bgwGifAnimado.RunWorkerAsync()
        End If
    End Sub

End Class
