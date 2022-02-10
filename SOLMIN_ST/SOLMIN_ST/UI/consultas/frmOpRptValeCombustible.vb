Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmOpRptValeCombustible

#Region "Atributos"
  Private _CCMPN As String
  Private bolEstado As Boolean
  Private _CDVSN As String
  Private _CPLNDV As Double
#End Region

#Region "Properties"
  Public Property CCMPN() As String
    Get
      Return _CCMPN
    End Get
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property
  Public Property CDVSN() As String
    Get
      Return _CDVSN
    End Get
    Set(ByVal value As String)
      _CDVSN = value
    End Set
  End Property
  Public Property CPLNDV() As Double
    Get
      Return _CPLNDV
    End Get
    Set(ByVal value As Double)
      _CPLNDV = value
    End Set
  End Property
#End Region

#Region "Eventos"
  Private Sub frmOpRptValeCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.CargarTransportista()
    Me.CargarTracto()
    Me.CargarConductor()
  End Sub
  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub rbtnTransportista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnTransportista.CheckedChanged
    Me.ctbTransportista_1.Enabled = rbtnTransportista.Checked
  End Sub

  Private Sub rbtnTracto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnTracto.CheckedChanged
    Me.ctbTracto.Enabled = rbtnTracto.Checked
  End Sub

  Private Sub rbtnConductor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnConductor.CheckedChanged
    Me.ctbConductor.Enabled = rbtnConductor.Checked
  End Sub

  Private Sub rbtnTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnTodos.CheckedChanged
    Me.chkPropios.Enabled = rbtnTodos.Checked
    Me.chkTerceros.Enabled = rbtnTodos.Checked
  End Sub

  Private Sub chkPropios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPropios.CheckedChanged
    If bolEstado And chkTerceros.Checked Then
      bolEstado = False
      Me.chkTerceros.Checked = False
    End If
    bolEstado = True
  End Sub

  Private Sub chkTerceros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTerceros.CheckedChanged
    If bolEstado And Me.chkPropios.Checked Then
      bolEstado = False
      Me.chkPropios.Checked = False
    End If
    bolEstado = True
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Me.Imprimir()
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub
#End Region

#Region "Métodos y Funciones"
  Private Sub CargarTransportista()
    Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    obeTransportista.pCCMPN_Compania = _CCMPN
    Me.ctbTransportista_1.pCargar(obeTransportista)
  End Sub

  Private Sub CargarTracto()
    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoPK
    obeTracto.pCCMPN_Compania = _CCMPN
    Me.ctbTracto.pCargar(obeTracto)
  End Sub

  Private Sub CargarConductor()
    Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
        obeConductor.pCCMPN_Compania = CCMPN
    Me.ctbConductor.pCargar(obeConductor)
  End Sub

  Private Sub Imprimir()
    Dim obrValeCombustible As New ValeCombustible_BLL
    Dim obeValeCombustible As New ValeCombustible
    With obeValeCombustible
      .CTRSPT = Me.ctbTransportista_1.pCodigoRNS
      .CBRCNT = Me.ctbConductor.pBrevete
      .NPLVEH = Me.ctbTracto.pNroPlacaUnidad
      If Me.rbtTodos.Checked = True Then
        .STPVHT = IIf(Me.chkPropios.Checked, "P", IIf(Me.chkTerceros.Checked, "T", ""))
      Else
        .STPVHT = ""
      End If
      '.STPVHT = IIf(Not chkPropios.Enabled, "", IIf(Me.rbtnTodos.Checked, "", IIf(Me.chkPropios.Checked, "P", "T")))
      .SSVLCM = IIf(Me.rbtTodos.Checked, "", IIf(Me.rbtPendiente.Checked, "P", IIf(Me.rbtLiquidado.Checked, "L", "A")))
      .FECINI = HelpClass.CFecha_a_Numero8Digitos(Me.dtpLimiteInicial.Value)
      .FECFIN = HelpClass.CFecha_a_Numero8Digitos(Me.dtpLimiteFinal.Value)
      .CCMPN = CCMPN
      .CDVSN = CDVSN
      .CPLNDV = CPLNDV
    End With
    Dim olbeValeCombustible As New List(Of ValeCombustible)
    olbeValeCombustible = obrValeCombustible.Listar_Vale_Combustible_RPT(obeValeCombustible)
    If olbeValeCombustible.Count = 0 Then Exit Sub
    If Me.rbtnTodos.Checked OrElse Me.rbtnTransportista.Checked Then
      Dim objReporte As New rptListaValeCombustible
      Me.Imprimir(olbeValeCombustible, objReporte)
    End If
    If Me.rbtnTracto.Checked Then
      Dim objReporte As New rptListaValeCombustible_Tracto
      Me.Imprimir(olbeValeCombustible, objReporte)
    End If
    If Me.rbtnConductor.Checked Then
      Dim objReporte As New rptListaValeCombustible_Conductor
      Me.Imprimir(olbeValeCombustible, objReporte)
    End If
  End Sub

  Private Sub Imprimir(ByVal olbeValeCombustible As List(Of ValeCombustible), ByVal objReporte As Object)
    Dim obj_DataTable As New DataTable
    Dim obj_DataSet As New DataSet
    Dim ofrmPrintForm As New PrintForm
    obj_DataTable = HelpClass.GetDataSetNative(olbeValeCombustible)
    obj_DataTable.TableName = "ValeCombustible"
    obj_DataSet.Tables.Add(obj_DataTable.Copy)
    objReporte.SetDataSource(obj_DataSet)
    CType(objReporte.ReportDefinition.ReportObjects("lblFecIni"), TextObject).Text = Me.dtpLimiteInicial.Value.Date
    CType(objReporte.ReportDefinition.ReportObjects("lblFecFin"), TextObject).Text = Me.dtpLimiteFinal.Value.Date
    CType(objReporte.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
    CType(objReporte.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.rbtPendiente.Tag.ToString.Trim
    CType(objReporte.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.rbtAsignados.Tag.ToString.Trim
    CType(objReporte.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.rbtLiquidado.Tag.ToString.Trim
    ofrmPrintForm.ShowForm(objReporte, Me)
  End Sub

#End Region

End Class
