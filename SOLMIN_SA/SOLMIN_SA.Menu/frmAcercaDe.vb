Public Class frmAcercaDe
    Private TextoPrivado As String = "Sistema Solmin - " & Today.Year
    Public Sub ShowForm(ByVal Texto As String, ByVal owner As IWin32Window)
        Me.txtMensaje.Text = IIf(Texto = "", TextoPrivado, Texto)
        Me.ShowDialog(owner)
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class
