Imports CrystalDecisions.CrystalReports.Engine

Public Class frmConsistenciaBulto_x_Operacion

  Private _NGUITR As Int64
  Public WriteOnly Property NGUITR() As Int64
    Set(ByVal value As Int64)
      _NGUITR = value
    End Set
  End Property

  Private _CTRMNC As Integer
  Public WriteOnly Property CTRMNC() As Integer
    Set(ByVal value As Integer)
      _CTRMNC = value
    End Set
  End Property

  Private _CCMPN As String
  Public WriteOnly Property CCMPN() As String
    Set(ByVal value As String)
      _CCMPN = value
    End Set
  End Property

  Private _CDVSN As String
  Public WriteOnly Property CDVSN() As String
    Set(ByVal value As String)
      _CDVSN = value
    End Set
  End Property

  Private _CPLNDV As Integer
  Public WriteOnly Property CPLNDV() As Integer
    Set(ByVal value As Integer)
      _CPLNDV = value
    End Set
  End Property

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub frmConsistenciaBulto_x_Operacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
      Dim objSolicitudTransporte As New NEGOCIO.mantenimientos.GuiaTransportista_BLL
      Dim oSolTrans As New ENTIDADES.Operaciones.Solicitud_Transporte
      oSolTrans.CTRSPT = _CTRMNC
      oSolTrans.NGUITR = _NGUITR
      oSolTrans.CCMPN = _CCMPN
      oSolTrans.CDVSN = _CDVSN
      oSolTrans.CPLNDV = _CPLNDV
      Dim objDataTable As DataTable = objSolicitudTransporte.Listar_Consistencia_Bulto_x_Operacion(oSolTrans)
      Me.txtMedioEnvio.Text = objDataTable.Rows(0).Item("MEDIO_ENVIO").ToString.Trim
      Me.dtgRecursosAsignados.DataSource = objDataTable.Copy
      Me.Alinear_Columnas_Grilla()
    Catch : End Try

  End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.dtgRecursosAsignados.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.dtgRecursosAsignados.ColumnCount - 1
      Me.dtgRecursosAsignados.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    If Me.dtgRecursosAsignados.RowCount <= 0 Then Exit Sub
    Dim objPrintForm As New PrintForm
    Dim objDs As New DataSet
    Dim objDt As New DataTable
    Dim objetoRep As New rptConsistencia_Bulto
    objDt = Me.dtgRecursosAsignados.DataSource
    objDt.TableName = "Bulto_Operacion"
    If objDt.Rows.Count = 0 Then
      HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
      Exit Sub
    End If
    objDs.Tables.Add(objDt.Copy)
    objetoRep.SetDataSource(objDs)
    CType(objetoRep.ReportDefinition.ReportObjects("txtTransportista"), TextObject).Text = Me.txtTransportista.Text
    CType(objetoRep.ReportDefinition.ReportObjects("txtPlaca"), TextObject).Text = Me.txtPlaca.Text
    CType(objetoRep.ReportDefinition.ReportObjects("txtAcoplado"), TextObject).Text = Me.txtAcoplado.Text
    CType(objetoRep.ReportDefinition.ReportObjects("txtConductor"), TextObject).Text = Me.txtConductor.Text
    CType(objetoRep.ReportDefinition.ReportObjects("txtGuiaTransporte"), TextObject).Text = Me.txtGuiaTransporte.Text
    CType(objetoRep.ReportDefinition.ReportObjects("txtOperacion"), TextObject).Text = Me.txtOperacion.Text
    CType(objetoRep.ReportDefinition.ReportObjects("txtRuta"), TextObject).Text = Me.txtOrigen.Text
    CType(objetoRep.ReportDefinition.ReportObjects("txtFecha"), TextObject).Text = Me.txtFecha.Text
    CType(objetoRep.ReportDefinition.ReportObjects("txtMedioEnvio"), TextObject).Text = Me.dtgRecursosAsignados.Item("MEDIO_ENVIO", 0).Value.ToString.Trim
    CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
    CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.txtPlaca.Tag.ToString.Trim
    CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.txtAcoplado.Tag.ToString.Trim
    CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.txtConductor.Tag.ToString.Trim
    objPrintForm.ShowForm(objetoRep, Me)
  End Sub
End Class
