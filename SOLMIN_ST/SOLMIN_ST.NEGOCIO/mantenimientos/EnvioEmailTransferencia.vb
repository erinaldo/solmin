Imports System.Text
Imports System.Runtime.CompilerServices
Imports Ransa.Controls.Email
Imports System.Configuration
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES

Imports Newtonsoft.Json

Namespace mantenimientos

    Public Class EnvioEmailTransferencia

        Public mailaccount As String = ""
        Public mailpassword As String = ""
        Public mailaccount_gmail As String = ""
        Public mailpassword_gmail As String = ""
        Public mailto_error As String = ""
        Public MailBody As String = ""
        Public MailBody2 As String = ""
        Public listEmailTo As String = ""
        Public listEmailCC As String = ""
        Public mailAsunto As String = ""

        Public Function Enviar_Email_Notificacion() As Int32

            If listEmailTo.Length > 0 Then
                EnvioBase(listEmailTo, MailBody)
            End If
            If listEmailCC.Length > 0 Then
                EnvioBase(listEmailCC, MailBody2)
            End If

        End Function


        Private Sub EnvioBase(pEmailTo As String, pBody As String)

            Dim oWsDoc As New wsDocManager.WsFileManager
            Dim respuesta As String = ""
            Dim status As String = ""
            Dim msg As String = ""
            Try

                Dim ojsonEnvio = New Dictionary(Of String, Object)
                ojsonEnvio.Add("mail_account", Me.mailaccount)
                ojsonEnvio.Add("mail_password", Me.mailpassword)
                ojsonEnvio.Add("mail_to", pEmailTo)
                ojsonEnvio.Add("mail_cc", "")
                ojsonEnvio.Add("mail_bcc", "")
                ojsonEnvio.Add("mail_toerror", "")
                ojsonEnvio.Add("mail_subject", mailAsunto)

                Dim StrJson As String = JsonConvert.SerializeObject(ojsonEnvio)
                If (listEmailTo <> "") Then

                    respuesta = oWsDoc.SendEmailOutlook(StrJson, pBody)            
                    status = respuesta.Split("-")(0)
                    msg = respuesta.Split("-")(1)
                    If status = "E" Then

                        Try                        
                            ojsonEnvio = New Dictionary(Of String, Object)
                            ojsonEnvio.Add("mail_account", Me.mailaccount_gmail)
                            ojsonEnvio.Add("mail_password", Me.mailpassword_gmail)
                            ojsonEnvio.Add("mail_to", pEmailTo)
                            ojsonEnvio.Add("mail_cc", "")
                            ojsonEnvio.Add("mail_bcc", "")
                            ojsonEnvio.Add("mail_toerror", "")
                            ojsonEnvio.Add("mail_subject", mailAsunto)
                            StrJson = JsonConvert.SerializeObject(ojsonEnvio)
                            respuesta = oWsDoc.SendGmail(StrJson, pBody)
                            status = respuesta.Split("-")(0)
                            msg = respuesta.Split("-")(1)
                            If status = "E" Then
                                MsgBox("Error en envío:" & msg, MsgBoxStyle.Critical, "Aviso")
                            End If

                        Catch exx As Exception
                        End Try

                    End If
                  
                End If


            Catch ex As Exception
               
            End Try


        End Sub


    End Class
End Namespace