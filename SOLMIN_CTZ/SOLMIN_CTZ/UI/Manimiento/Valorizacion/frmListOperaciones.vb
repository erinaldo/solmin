Public Class frmListOperaciones
    Public dtListOperaciones As New DataTable
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmListOperaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtgOpValorizacion.AutoGenerateColumns = False
            dtgOpValorizacion.DataSource = dtListOperaciones
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class