Public Class frmSolicitudTransporte

    Private Sub frmSolicitudTransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UcSolicitudTransporte.pUsuario = HelpUtil.UserName
            UcSolicitudTransporte.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            UcSolicitudTransporte.pInicializar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
