Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmConsultaLiquidacionGasto

  Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
    Dim objLogica As New LiquidacionGastos_BLL
    Dim obj_DataSet As New DataSet
    Dim objReporte As New rptLiquidacionGeneral
    Dim objParametro As New Hashtable

    objParametro.Add("PSCCLNT", IIf(Me.txtCliente.pCodigo = 0, "", Me.txtCliente.pCodigo))
    objParametro.Add("PNFECINI", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaInicio.Value))
    objParametro.Add("PNFECFIN", HelpClass.CFecha_a_Numero8Digitos(Me.dtpFechaFin.Value))
    Me.ControlVisorLiquidacion.Muestra_Imagen()
    obj_DataSet = objLogica.Listar_Liquidacion_General_RPT(objParametro)
    If obj_DataSet.Tables.Count = 0 Then
      Me.ControlVisorLiquidacion.ReportViewer.ReportSource = Nothing
      Exit Sub
    End If
    obj_DataSet.Tables(0).TableName = "RZTR61"
    obj_DataSet.Tables(1).TableName = "RZTR63"
    objReporte.SetDataSource(obj_DataSet)
    objReporte.SetParameterValue("pFecIni", Me.dtpFechaInicio.Value.Date)
    objReporte.SetParameterValue("pFecFin", Me.dtpFechaFin.Value.Date)
    objReporte.SetParameterValue("pUsuario", MainModule.USUARIO)
    Me.ControlVisorLiquidacion.ReportViewer.ReportSource = objReporte
    Me.ControlVisorLiquidacion.Ocultar_Imagen()
  End Sub

  Private Sub frmConsultaLiquidacionGasto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtCliente.pUsuario = MainModule.USUARIO

  End Sub

    Private Sub btnPorDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPorDetalle.Click
        Dim frm_Opcion_LiquidacionGasto As New frmOpRptLiquidacionGasto
        Dim obj_Logica As New LiquidacionGastos_BLL
        Dim objetoParametro As New Hashtable
        Dim obj_DataSet As New DataSet
        Dim objPrintForm As New PrintForm
        Dim objReporte As New rptListaLiquidacionGasto

        With frm_Opcion_LiquidacionGasto
            frm_Opcion_LiquidacionGasto.CCMPN = "EZ" 'ACTUALMENTE SE TRABAJA CON UNA EMPRESA
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

            objetoParametro.Add("PNCCLNT", .CCLNT)
            objetoParametro.Add("PNFECINI", .FECINI)
            objetoParametro.Add("PNFECFIN", .FECFIN)
            objetoParametro.Add("PSNPLCUN", .NPLCUN)
            objetoParametro.Add("PSCBRCNT", .CBRCNT)
            obj_DataSet = obj_Logica.Listar_Liquidacion_Gastos_RPT(objetoParametro)
            If obj_DataSet.Tables.Count = 0 Then Exit Sub
            obj_DataSet.Tables(0).TableName = "RZTR58"
            obj_DataSet.Tables(1).TableName = "RZTR63"

            CType(objReporte.ReportDefinition.ReportObjects("lblFecIni"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECINI)
            CType(objReporte.ReportDefinition.ReportObjects("lblFecFin"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECFIN)
            Select Case .Tag
                Case 0
                    CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR FECHA"
                Case 1
                    CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR CLIENTE"
                Case 2
                    CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR CONDUCTOR"
                Case 3
                    CType(objReporte.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = "POR TRACTO"
            End Select
            objReporte.SetDataSource(obj_DataSet)

            objPrintForm.ShowForm(objReporte, Me)
        End With
    End Sub

    Private Sub chkcbxPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
