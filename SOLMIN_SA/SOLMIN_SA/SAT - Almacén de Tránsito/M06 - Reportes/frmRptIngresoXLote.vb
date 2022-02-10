Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.TYPEDEF.OrdenCompra
'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes

Imports RANSA.Utilitario


Public Class frmRptIngresoXLote


    Private strReporteseleccionado As String = ""
    Private _widthLeftRight As Int32
    Private objTemp As TipoDato_ResultaReporte
    Private strDetalleReporte As String = ""

    Private a As Boolean
    Private b As Boolean
    Private c As Boolean
    Private d As Boolean

    Private Sub frmRptIngresoXLote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        '-- Crear status por control con F4
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RepRecepcionPorAlmacenClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

        objAppConfig = Nothing
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As RANSA.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click
        If fblnValidaInformacion() Then
            pcxEspera.Visible = True
            pcxEspera.Left = (KryptonHeaderGroup1.Width / 2) - (pcxEspera.Width / 2)
            pcxEspera.Top = (KryptonHeaderGroup1.Height / 2) - (pcxEspera.Height / 2)
            tsbEnviarCorreo.Enabled = False
            tsbExportarExcel.Enabled = False
            btnGenerarReporte.Enabled = False

            bgwGifAnimado.RunWorkerAsync()
        End If
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
        btnGenerarReporte.Enabled = True
        tsbEnviarCorreo.Enabled = True
        tsbExportarExcel.Enabled = True
        crvReporte.Visible = True
        crvReporte.ReportSource = objTemp.pReporte
    End Sub
    Sub pGenerarReporte()
        Dim objAppConfig As cAppConfig = New cAppConfig

        pReporteReporteDeRecepciones()
        strDetalleReporte = "Reporte de Recepciones"

        objAppConfig.ConfigType = 1
        objAppConfig.SetValue("RepRecepcionPorAlmacenClienteCodigo", txtCliente.pCodigo)
        objAppConfig = Nothing
    End Sub

    Private Sub pReporteReporteDeRecepciones()

        Dim dstTemp As DataSet = Nothing
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        Dim obrReporteAT As New brReporteAT
        With obeFiltro
            .PNCCLNT = txtCliente.pCodigo
            .PNFECINI = dteFechaInicial.Value
            .PNFECFIN = dteFechaFinal.Value
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
        End With
        Dim objTemp2 As New TipoDato_ResultaReporte
        Dim rptTemp As ReportDocument

        dstTemp = obrReporteAT.fdstReporteIngresos(obeFiltro)
        If dstTemp.Tables.Count > 0 Then
            rptTemp = New rptIngresosPorLote
            dstTemp.Tables(0).TableName = "IngresoPorLote"
            rptTemp.SetDataSource(dstTemp.Tables(0))
            rptTemp.Refresh()
            ' Ingresamos parametros adicionales
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rptTemp.SetParameterValue("pFechaInicial", dteFechaInicial.Value)
            rptTemp.SetParameterValue("pFechaFinal", dteFechaFinal.Value)
            ' Generamos el Nuevo Tipo de Datos
            objTemp2.add_Tables(dstTemp)
            objTemp2.pReporte = rptTemp
        End If
        objTemp = objTemp2

    End Sub
    Private Function ReturnTableFormatedIngresoEgreso(ByVal tabla As DataTable, ByVal llave As String) As DataTable
        Dim OdtNew As New DataTable
        OdtNew = tabla.Copy
        For i As Integer = OdtNew.Columns.Count - 1 To 1 Step -1
            Select Case OdtNew.Columns(i).ColumnName
                Case "CREFFW"
                    OdtNew.Columns.RemoveAt(i)
                Case "CCLNT"
                    OdtNew.Columns.RemoveAt(i)
                Case "TCMPCL"
                    OdtNew.Columns.RemoveAt(i)
            End Select
        Next
        Return OdtNew
    End Function

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Call mpEnviarEMail(objTemp, strDetalleReporte, "Informe : " + strDetalleReporte)
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
        Dim oDtExcel As New DataTable
        Dim strTitulo As String = ""
        strTitulo = Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial
        oDtExcel = ReturnTableFormatedIngresoEgreso(objTemp.Tables(0), "")
        'oDtExcel = objTemp.Tables(0)
        strReporteseleccionado = "A05"
        Call mpGenerarXLS(strReporteseleccionado, oDtExcel, strTitulo)
    End Sub
End Class

