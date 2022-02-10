Public Class frmIncidencia

    Private Sub frmIncidencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UcRegistroDeIncidencias.pUsuario = HelpUtil.UserName
            UcRegistroDeIncidencias.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy            
            UcRegistroDeIncidencias.pInicializar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub
End Class
