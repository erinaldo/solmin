Imports System.Configuration.ConfigurationSettings
Module MainP

    Sub Main()
        Try
            Console.WriteLine("Enviando Email (Prox. 15 días)...")
            Dim obrEnvioPreEmbarque As New BL_CheckPointEnvioPreEmb
            obrEnvioPreEmbarque.MailAccount = Configuration.ConfigurationManager.AppSettings("email_account")
            obrEnvioPreEmbarque.Mailpassword = Configuration.ConfigurationManager.AppSettings("email_password")
            obrEnvioPreEmbarque.EMAILTO = Configuration.ConfigurationManager.AppSettings("emailto")
            obrEnvioPreEmbarque.EMAILBC = Configuration.ConfigurationManager.AppSettings("emailbc")
            obrEnvioPreEmbarque.MailAccount_Gmail = Configuration.ConfigurationManager.AppSettings("email_account_gmail")
            obrEnvioPreEmbarque.Mailpassword_Gmail = Configuration.ConfigurationManager.AppSettings("email_password_gmail")
            obrEnvioPreEmbarque.Emailto_ERROR = Configuration.ConfigurationManager.AppSettings("emailto_error")


            obrEnvioPreEmbarque.EnviarEmail_X_Modificacion_CheckPoint_PreEmb("EZ", 6318)
            Console.WriteLine("Se ha culminado el proceso...")
        Catch ex As Exception

        End Try

    End Sub
End Module
