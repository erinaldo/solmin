Public Class frmMovimiento

  Private _NRGUSA_V As Int64
  Public ReadOnly Property Guia_Salida() As Int64
    Get
      Return _NRGUSA_V
    End Get
  End Property

  Private _Tabla As DataTable
  Public WriteOnly Property Tabla() As DataTable
    Set(ByVal value As DataTable)
      _Tabla = value
    End Set
  End Property

  Private Sub dtgListaMovimiento_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgListaMovimiento.CellDoubleClick
    _NRGUSA_V = Me.dtgListaMovimiento.Item("NRGUSA", Me.dtgListaMovimiento.CurrentCellAddress.Y).Value
    Me.DialogResult = Windows.Forms.DialogResult.OK
  End Sub

  Private Sub frmMovimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.dtgListaMovimiento.DataSource = _Tabla
  End Sub
End Class
