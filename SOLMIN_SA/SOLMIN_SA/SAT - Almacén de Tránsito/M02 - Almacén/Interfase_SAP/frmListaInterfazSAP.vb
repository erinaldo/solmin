Public Class frmListaInterfazSAP



    Public WriteOnly Property DataSource() As DataTable

        Set(ByVal value As DataTable)
            dgInterfaz.AutoGenerateColumns = False
            Me.dgInterfaz.DataSource = value
        End Set
    End Property


    Private _oDr As DataRowView
    Public ReadOnly Property oDr() As DataRowView
        Get
            Return _oDr
        End Get

    End Property

    Private Sub dgItemOC_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInterfaz.CellDoubleClick
        If Me.dgInterfaz.CurrentCellAddress.Y = -1 Then Exit Sub
        _oDr = Me.dgInterfaz.CurrentRow.DataBoundItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
