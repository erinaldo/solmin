Public Class frmRequerimientoServ

    Private Sub frmRequerimientoServ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            UcSolicitudRequerimiento1.pSystem_prefix = "SC"
            UcSolicitudRequerimiento1.pMailAccount = System.Configuration.ConfigurationManager.AppSettings("email_account")
            UcSolicitudRequerimiento1.pMailpassword = System.Configuration.ConfigurationManager.AppSettings("email_password")

            UcSolicitudRequerimiento1.pMailAccount_Gmail = System.Configuration.ConfigurationManager.AppSettings("email_account_gmail")
            UcSolicitudRequerimiento1.pMailPassword_Gmail = System.Configuration.ConfigurationManager.AppSettings("email_password_gmail")
            UcSolicitudRequerimiento1.pMailto_Error = System.Configuration.ConfigurationManager.AppSettings("emailto_error")
            UcSolicitudRequerimiento1.pUsuario = HelpUtil.UserName
            UcSolicitudRequerimiento1.pNameForm = Me.Name

            UcSolicitudRequerimiento1.pInicializar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
