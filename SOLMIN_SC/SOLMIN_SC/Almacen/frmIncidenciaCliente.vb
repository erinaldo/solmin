Public Class frmIncidenciaCliente

    Private Sub frmIncidenciaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UcIncidenciaCliente1.pUsuario = HelpUtil.UserName
        UcIncidenciaCliente1.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        UcIncidenciaCliente1.pInicializar()
    End Sub
End Class
