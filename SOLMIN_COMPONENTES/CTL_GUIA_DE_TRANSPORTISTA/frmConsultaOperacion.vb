Public Class frmConsultaOperacion

  Private _NOPRCN_1 As Int64
  Private _Tabla As DataTable

  Public ReadOnly Property Operacion() As Int64
    Get
      Return _NOPRCN_1
    End Get
  End Property

  Public WriteOnly Property Tabla() As DataTable
    Set(ByVal value As DataTable)
      _Tabla = value
    End Set
  End Property

  Private Sub dtgListaMovimiento_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaMovimiento.CellDoubleClick
    Me._NOPRCN_1 = Me.dtgListaMovimiento.Item("NOPRCN", Me.dtgListaMovimiento.CurrentCellAddress.Y).Value
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub frmMovimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.dtgListaMovimiento.DataSource = _Tabla
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Me.dtgListaMovimiento_CellDoubleClick(Nothing, Nothing)
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub
End Class
