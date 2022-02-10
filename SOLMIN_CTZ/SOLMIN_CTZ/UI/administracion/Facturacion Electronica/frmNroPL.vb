Public Class frmNroPreDocumento
    Public NRO_PL As Decimal = 0
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If Val(txtPL.Text.Trim) = 0 Then
                MessageBox.Show("Ingrese número válido")
                Exit Sub
            End If
            NRO_PL = Val(txtPL.Text.Trim)
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class