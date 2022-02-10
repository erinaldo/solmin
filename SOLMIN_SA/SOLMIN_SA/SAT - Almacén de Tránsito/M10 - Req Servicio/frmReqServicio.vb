Public Class frmReqServicio

    Private Sub frmReqServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            UcSolicitudRequerimiento1.pSystem_prefix = "SA"
            UcSolicitudRequerimiento1.pMailAccount = System.Configuration.ConfigurationManager.AppSettings("MailFrom")
            UcSolicitudRequerimiento1.pMailpassword = System.Configuration.ConfigurationManager.AppSettings("MailFromClave")

            UcSolicitudRequerimiento1.pMailAccount_Gmail = System.Configuration.ConfigurationManager.AppSettings("email_account_gmail")
            UcSolicitudRequerimiento1.pMailPassword_Gmail = System.Configuration.ConfigurationManager.AppSettings("email_password_gmail")
            UcSolicitudRequerimiento1.pMailto_Error = System.Configuration.ConfigurationManager.AppSettings("emailto_error")
            UcSolicitudRequerimiento1.pUsuario = objSeguridadBN.pUsuario
            UcSolicitudRequerimiento1.pNameForm = Me.Name

            UcSolicitudRequerimiento1.pInicializar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcSolicitudRequerimiento1_Load(sender As Object, e As EventArgs) Handles UcSolicitudRequerimiento1.Load

    End Sub
End Class
