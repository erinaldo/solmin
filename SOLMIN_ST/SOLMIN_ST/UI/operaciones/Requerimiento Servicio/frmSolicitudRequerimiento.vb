Public Class frmSolicitudRequerimiento

    Private Sub frmSolicitudRequerimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            UcSolicitudRequerimiento1.pSystem_prefix = "ST"
            UcSolicitudRequerimiento1.pMailAccount = System.Configuration.ConfigurationManager.AppSettings("MailFrom")
            UcSolicitudRequerimiento1.pMailpassword = System.Configuration.ConfigurationManager.AppSettings("MailFromClave")

            UcSolicitudRequerimiento1.pMailAccount_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCO")
            UcSolicitudRequerimiento1.pMailPassword_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCOClave")
            UcSolicitudRequerimiento1.pMailto_Error = System.Configuration.ConfigurationManager.AppSettings("emailto_error")
            UcSolicitudRequerimiento1.pUsuario = MainModule.USUARIO
            UcSolicitudRequerimiento1.pNameForm = Me.Name

            UcSolicitudRequerimiento1.pInicializar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
