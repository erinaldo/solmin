Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmConfiguracionVehicular

#Region "Atributo"
  Private mQCRUTV As Double
  Private mTCNFVH As String
  Private mTDSCM1 As String
  Private mListaConfiguracion As List(Of ClaseGeneral)
#End Region

#Region "Properties"

  Public ReadOnly Property TCNFVH_1() As String
    Get
      Return mTCNFVH
    End Get
  End Property

  Public ReadOnly Property QCRUTV_1() As String
    Get
      Return mQCRUTV
    End Get
  End Property

  Public ReadOnly Property TDSCM1_1() As String
    Get
      Return mTDSCM1
    End Get
  End Property

  Public WriteOnly Property ListaConfiguracion() As List(Of ClaseGeneral)
    'Get
    '  Return mListaConfiguracion
    'End Get
    Set(ByVal value As List(Of ClaseGeneral))
      mListaConfiguracion = value
    End Set
  End Property

#End Region

#Region "Eventos"

  Private Sub frmConfiguracionVehicular_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.gwDatos.AutoGenerateColumns = False
    Me.gwDatos.DataSource = Me.mListaConfiguracion
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    If Me.gwDatos.RowCount = 0 OrElse Me.gwDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    If Me.gwDatos.CurrentRow.Selected = False Then Exit Sub
    Me.Asignando_Valor()
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub gwDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwDatos.DataBindingComplete
    If Me.gwDatos.RowCount = 0 Then Exit Sub
    Me.gwDatos.CurrentRow.Selected = False
  End Sub

  Private Sub gwDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwDatos.CellDoubleClick
    If Me.gwDatos.RowCount = 0 OrElse Me.gwDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    If Me.gwDatos.CurrentRow.Selected = False Then Exit Sub
    Me.Asignando_Valor()
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

#End Region

#Region "Metodos"
  Private Sub Asignando_Valor()
    Dim lint_Indice As Integer = Me.gwDatos.CurrentCellAddress.Y
    Me.mTCNFVH = Me.gwDatos.Item("TCNFVH", lint_Indice).Value.ToString
    Me.mTDSCM1 = Me.gwDatos.Item("TDSCM1", lint_Indice).Value.ToString
    Me.mQCRUTV = Me.gwDatos.Item("QCRUTV", lint_Indice).Value
  End Sub
#End Region
  
End Class
