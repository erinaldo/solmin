Imports System.IO
Imports System.Configuration.ConfigurationSettings
Imports System.Text
Imports System.Windows.Forms
Module MainP

    Sub Main()
        Console.WriteLine("Iniciando proceso de envio (Fechas de Vencimiento)...")
        Try
            Dim obrEnvio As BL_FechaVencimiento
            Dim obeEmail As BE_Email
            obrEnvio = New BL_FechaVencimiento

            Dim oListDestinatario As New List(Of BE_Destinatario)
            'Dim sbListClient As New StringBuilder
            'sbListClient.Append(String.Format("{0},{1},{2},{3},{4}", 9425, 14284, 49490, 2287, 46550))
            'sbListClient.Append(String.Format(",{0},{1},{2},{3},{4}", 44871, 48622, 48623, 51872, 11496))
            'sbListClient.Append(String.Format(",{0},{1},{2},{3},{4}", 11249, 6787, 11232, 16168, 525))
            'sbListClient.Append(String.Format(",{0},{1},{2}", 44532, 49534, 30124))


            'oListDestinatario = obrEnvio.listaDestinatarioEnvio(sbListClient.ToString.Trim)
            oListDestinatario = obrEnvio.listaDestinatarioEnvio()
            Dim oListCliente As New List(Of Decimal)
            oListCliente = obrEnvio.ListarClienteDiferente(oListDestinatario)

            Dim email_account As String = Configuration.ConfigurationManager.AppSettings("email_account")
            Dim email_password As String = Configuration.ConfigurationManager.AppSettings("email_password")
            Dim emailbc As String = Configuration.ConfigurationManager.AppSettings("emailbc")
            Dim emailto_error As String = Configuration.ConfigurationManager.AppSettings("emailto_error")
            Dim email_account_gmail As String = Configuration.ConfigurationManager.AppSettings("email_account_gmail")
            Dim email_password_gmail As String = Configuration.ConfigurationManager.AppSettings("email_password_gmail")


            Dim beDestinatarioCartaFianza As BE_Destinatario
            Dim beDestinatarioRegTemporal As BE_Destinatario
            Dim beDestinatarioContenedor As BE_Destinatario
            For Each CCLNT As Decimal In oListCliente

                Console.WriteLine(String.Format("{0}:{1}", "Procesando Cliente", CCLNT))

                obrEnvio = New BL_FechaVencimiento
                obeEmail = New BE_Email
                beDestinatarioCartaFianza = obrEnvio.ConsolidarListaEnvioClienteTipoFechaVenc(oListDestinatario, CCLNT, BL_FechaVencimiento.TipoFechaVenc.VencCartaFianza)
                beDestinatarioRegTemporal = obrEnvio.ConsolidarListaEnvioClienteTipoFechaVenc(oListDestinatario, CCLNT, BL_FechaVencimiento.TipoFechaVenc.VencRegTemporal)
                beDestinatarioContenedor = obrEnvio.ConsolidarListaEnvioClienteTipoFechaVenc(oListDestinatario, CCLNT, BL_FechaVencimiento.TipoFechaVenc.VencContenedor)

                obeEmail.Emailto_Error = emailto_error
                obeEmail.MailAccount = email_account
                obeEmail.Mailpassword = email_password
                obeEmail.EmailBC = emailbc
                obeEmail.MailAccountGmail = email_account_gmail
                obeEmail.MailpasswordGmail = email_password_gmail


                obeEmail.EmailTO = beDestinatarioCartaFianza.PSEMAILTO
                obrEnvio.EnviarEmail_X_FecVencCartaFianza("EZ", CCLNT, beDestinatarioCartaFianza.PSTCMPCL, obeEmail)

                obeEmail.EMAILTO = beDestinatarioContenedor.PSEMAILTO
                obrEnvio.EnviarEmail_X_FecVencContenedor("EZ", CCLNT, beDestinatarioContenedor.PSTCMPCL, obeEmail)

                obeEmail.EMAILTO = beDestinatarioRegTemporal.PSEMAILTO
                obrEnvio.EnviarEmail_X_FecVencRegimen("EZ", CCLNT, beDestinatarioRegTemporal.PSTCMPCL, obeEmail)
            Next

            Console.WriteLine("Se ha culminado el proceso de envio (Fechas de Vencimiento)...")
        Catch ex As Exception
            Dim archivo As String = "LOG_FEC_VENC_" & Today.ToString("yyyMMdd") & ".txt"
            Dim path As String = Application.StartupPath & "\archivo"
            Dim sbError As New StringBuilder
            sbError.AppendLine()
            sbError.AppendLine(String.Format("Fecha:{0} - {1}", Today.ToString("dd/MM/yyyy"), Now.ToString("HH:mm:ss")))
            sbError.Append(ex.Message)
            sbError.AppendLine()
            Using sw As New System.IO.StreamWriter(archivo, True)
                sw.Write(sbError.ToString)
            End Using
        End Try
    End Sub

End Module
