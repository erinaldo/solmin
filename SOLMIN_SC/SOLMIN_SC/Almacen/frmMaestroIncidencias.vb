Public Class frmMaestroIncidencias

    Private Sub frmMaestroIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UcMaestroIncidencias1.pUsuario = HelpUtil.UserName
            UcMaestroIncidencias1.pCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            UcMaestroIncidencias1.pInicializar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
