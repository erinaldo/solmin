Public Class FrmAplicacionN

    Private Sub FrmAplicacionN_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        UcAplicacionMain.Apli_Inicial = "SOLMIN" 'En caso de listar todos mandar vacio
        UcAplicacionMain.pCargar()

    End Sub
End Class
