Public Class frmSeguimientoInc

    Private Sub frmSeguimientoInc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UcSeguimientoInc1.pUsuario = HelpUtil.UserName
        UcSeguimientoInc1.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        UcSeguimientoInc1.pInicializar()

    End Sub

End Class
