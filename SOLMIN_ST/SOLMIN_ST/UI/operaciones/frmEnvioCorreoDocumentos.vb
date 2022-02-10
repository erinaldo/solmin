Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Security.Cryptography
Imports System.Web
Imports System.Text
Imports System.IO
Imports System.Threading
Imports Newtonsoft.Json

Public Class frmEnvioCorreoDocumentos

#Region "Declaracion de Variables"

    Public oDtDocumentos As New DataTable
    Public sSeguimiento As String = String.Empty
    Public nSeguimiento As String = String.Empty
    Public sUsuario As String = String.Empty
    Public sFecha As String = String.Empty
    Public sHora As String = String.Empty
    Public sHoraHtml As String = String.Empty
    Public sResponsable As String = String.Empty
    Public sObs As String = String.Empty
    Private nCorrEnvio As Integer = 0

    Public CompaniaDescripcion As String = String.Empty

    Private Const HTMLInicio As String = "<HTML><BODY>"
    Private Const HTMLFin As String = "</BODY></HTML>"
    Private Const HTMLSalto As String = "<br/>"
    Private Const HTMLEspacio As String = "&nbsp;"
    Private oHebraEnvioEmail As Thread
#End Region

#Region "Eventos de Control"
 
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

         
        If txtPara.Text.Trim.Split(";").Length > 1 Then
            MessageBox.Show("Solo puede enviar a un Destinatario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txtPara.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar un correo destino", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If



        Dim MailsAdress() As String = txtPara.Text.Split(";")
 
        For i As Integer = 0 To MailsAdress.Length - 1
            If Not Ransa.Utilitario.HelpClass.validar_Mail(MailsAdress(i)) Then              
                MessageBox.Show("Ingrese un Mail destino válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next

        If txtCopia.Text.Trim.Length > 0 Then
            Dim MailsCo() As String = txtCopia.Text.Split(";")
            For i As Integer = 0 To MailsCo.Length - 1
                If Not Ransa.Utilitario.HelpClass.validar_Mail(MailsCo(i).Trim) Then
                    MessageBox.Show("Ingrese un Mail Copia válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next
        End If
 

        ActualizarDocumentos()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    
#End Region


#Region "Procedimientos y funciones"

    Private Sub ActualizarDocumentos()
        Dim objLogicaReportes As New ReportesVariados_BLL
        Dim objOperacion As New TipoOperacion_BLL
        nCorrEnvio = objLogicaReportes.Lista_CorrelativoControl("SMTD02").Rows(0).Item("NULCTR")
        sHora = obtenerFormatoHora(sHoraHtml)
        Dim ht As New Hashtable

        For Each dr As DataRow In oDtDocumentos.Rows
            ht = New Hashtable
            ht.Add("PNNOPRCN", dr("NOPRCN"))
            ht.Add("PSSESTTP", nSeguimiento)
            ht.Add("PNFDSGDC", HelpClass.CtypeDate(sFecha))
            ht.Add("PNHDSGDC", sHora)
            ht.Add("PSURSPDC", sResponsable)
            ht.Add("PSTOBSSG", sObs)
            ht.Add("PSCUSCRT", sUsuario)
            ht.Add("PSNTRMCR", Ransa.Utilitario.HelpClass.NombreMaquina)
            ht.Add("PNNRSGDC", nCorrEnvio)
            If objOperacion.InsertaSeguimientoOperacion(ht) = 0 Then
                MessageBox.Show("Error al insertar Operacion " & dr("NOPRCN"))
            End If
        Next

        If SendMail() Then
            DialogResult = Windows.Forms.DialogResult.Yes
        Else
            MessageBox.Show("Error al Enviar Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'SendMailNode()
 
 

        'If SendMail2() Then
        '    DialogResult = Windows.Forms.DialogResult.Yes
        'Else
        '    MessageBox.Show("Error al Enviar Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
    End Sub

    Private Function SendMail() As Boolean
        Dim strSMSRespuesta As String = ""
        Dim strServer As String = System.Configuration.ConfigurationSettings.AppSettings("ServerMail").ToString()
        Dim strMailCo As String = System.Configuration.ConfigurationSettings.AppSettings("MailCO").ToString()
        Dim strMailFrom As String = System.Configuration.ConfigurationSettings.AppSettings("MailFrom").ToString()
        Dim strMailFromClave As String = System.Configuration.ConfigurationSettings.AppSettings("MailFromClave").ToString()
        'Dim strAdress As String = txtPara.Text.Trim
        Dim strAdress As String = txtPara.Text.Trim.Replace(" ", "").Trim
        Dim strCopia As String = txtCopia.Text.Trim.Replace(" ", "").Trim

        If Not Ransa.Utilitario.HelpClass.flSendMail(strServer, strMailCo, strMailFrom, strMailFromClave, _
               strAdress, "", txtAsunto.Text.Trim, CrearDatosCuerpoOperacion(True), True, strSMSRespuesta) Then
            MessageBox.Show(strSMSRespuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            If txtCopia.Text.Trim.Length > 0 Then
                'strAdress = txtCopia.Text.Trim
                strAdress = strCopia
                Ransa.Utilitario.HelpClass.flSendMail(strServer, "", strMailFrom, strMailFromClave, _
                strAdress, "", txtAsunto.Text.Trim, CrearDatosCuerpoOperacion(False), True, strSMSRespuesta)
                'ojo: quitar cuando termine la prueba.
                'MessageBox.Show(strSMSRespuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return True
    End Function



    Private Function SendMailNode() As Boolean

        Dim strSMSRespuesta As String = ""
        Dim strServer As String = System.Configuration.ConfigurationSettings.AppSettings("ServerMail").ToString()
        Dim strMailCo As String = System.Configuration.ConfigurationSettings.AppSettings("MailCO").ToString()
        Dim strMailFrom As String = System.Configuration.ConfigurationSettings.AppSettings("MailFrom").ToString()
        Dim strMailFromClave As String = System.Configuration.ConfigurationSettings.AppSettings("MailFromClave").ToString()
        'Dim strAdress As String = txtPara.Text.Trim
        Dim strAdress As String = txtPara.Text.Trim.Replace(" ", "").Trim
        Dim strCopia As String = txtCopia.Text.Trim.Replace(" ", "").Trim
        Dim cuerpo As String = CrearDatosCuerpoOperacion(False)

        Dim api_rest As New API_REST
        Dim orespuesta As New Object
        Dim jsonData As String = ""
        Try

            Dim JsObs As Dictionary(Of String, Object)
            JsObs = New Dictionary(Of String, Object)
            JsObs.Add("host", strServer)
            JsObs.Add("port", 587)
            JsObs.Add("from", strMailFrom)
            JsObs.Add("pass", strMailFromClave)
            JsObs.Add("to", strAdress)
            JsObs.Add("cc", strCopia)
            JsObs.Add("subject", txtAsunto.Text.Trim)
            JsObs.Add("text", "")
            JsObs.Add("html", cuerpo)

            jsonData = JsonConvert.SerializeObject(JsObs)
            Dim url_servicio As String = "http://localhost:8080/email/sendemail"
            orespuesta = api_rest.Post(url_servicio, jsonData, "", "")
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        

    End Function


    


 

    Public Function SendMail2() As Boolean
        Dim exito As Int32 = -1
        Dim bodyemailTo As String = ""
        Dim bodyemailCopia As String = ""
        Try
            'Dim strServer As String = System.Configuration.ConfigurationSettings.AppSettings("ServerMail").ToString()
            Dim MailAccount_Gmail As String = System.Configuration.ConfigurationSettings.AppSettings("MailCO").ToString()
            Dim MailPassword_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCOClave")
            Dim MailAccount As String = System.Configuration.ConfigurationSettings.AppSettings("MailFrom").ToString()
            Dim Mailpassword As String = System.Configuration.ConfigurationSettings.AppSettings("MailFromClave").ToString()

            Dim MailError As String = System.Configuration.ConfigurationManager.AppSettings("emailto_error")
            'Dim oclsEmailManager As New EnvioEmailTransferencia
            bodyemailTo = CrearDatosCuerpoOperacion(True)
            bodyemailCopia = CrearDatosCuerpoOperacion(False)
            Dim listEmailTo As String = txtPara.Text.Trim.Replace(" ", "").Trim
            Dim listEmailCC As String = txtCopia.Text.Trim.Replace(" ", "").Trim
            Dim paramEmail As New Hashtable()
            paramEmail("mail_subject") = txtAsunto.Text.Trim
            paramEmail("mail_account") = MailAccount
            paramEmail("mail_password") = Mailpassword
            paramEmail("gmail_account") = MailAccount_Gmail
            paramEmail("gmail_password") = MailPassword_Gmail
            If listEmailTo.Length > 0 Then
                paramEmail("mail_to") = listEmailTo
                EnvioBase(paramEmail, bodyemailTo)
            End If
            If listEmailCC.Length > 0 Then
                paramEmail("mail_to") = listEmailCC
                EnvioBase(paramEmail, bodyemailCopia)
            End If
 
            'oclsEmailManager.listEmailTo = txtPara.Text.Trim.Replace(" ", "").Trim
            'oclsEmailManager.listEmailCC = txtCopia.Text.Trim.Replace(" ", "").Trim
            'oclsEmailManager.mailto_error = MailError
            'oclsEmailManager.mailaccount = MailAccount
            'oclsEmailManager.mailpassword = Mailpassword
            'oclsEmailManager.MailBody = bodyemailTo
            'oclsEmailManager.MailBody2 = bodyemailCopia
            'oclsEmailManager.mailaccount_gmail = MailAccount_Gmail
            'oclsEmailManager.mailpassword_gmail = MailPassword_Gmail
            'oclsEmailManager.mailAsunto = txtAsunto.Text.Trim
            'If (oclsEmailManager.listEmailTo <> "") Then
            '    oclsEmailManager.Enviar_Email_Notificacion()
            '    exito = 1
            'Else
            '    MsgBox("Correo no enviado.No se encontró destinatarios.", MsgBoxStyle.Critical, "Aviso")
            '    exito = 0
            'End If

        Catch ex As Exception
            MessageBox.Show("Error al Enviar Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return exito

    End Function


    Private Sub EnvioBase(paramEmail As Hashtable, pBody As String)


        Dim oWsDoc As New StorageFileManager.ProxyFileManagerAWS.WsFileManager
        Dim respuesta As String = ""
        Dim status As String = ""
        Dim msg As String = ""
        Dim pEmailTo As String = paramEmail("mail_to")
        Dim pmail_subject As String = paramEmail("mail_subject")
        Dim mail_account As String = paramEmail("mail_account")
        Dim mail_password As String = paramEmail("mail_password")
        Dim gmail_account As String = paramEmail("gmail_account")
        Dim gmail_password As String = paramEmail("gmail_password")

        Dim ojsonEnvio = New Dictionary(Of String, Object)
        ojsonEnvio.Add("mail_account", mail_account)
        ojsonEnvio.Add("mail_password", mail_password)
        ojsonEnvio.Add("mail_to", pEmailTo)
        ojsonEnvio.Add("mail_cc", "")
        ojsonEnvio.Add("mail_bcc", "")
        ojsonEnvio.Add("mail_toerror", "")
        ojsonEnvio.Add("mail_subject", pmail_subject)

        Dim StrJson As String = JsonConvert.SerializeObject(ojsonEnvio)
        If (pEmailTo <> "") Then

            respuesta = oWsDoc.SendEmailOutlook(StrJson, pBody)
            status = respuesta.Split("-")(0)
            msg = respuesta.Split("-")(1)
            If status = "E" Then
                ojsonEnvio = New Dictionary(Of String, Object)
                ojsonEnvio.Add("mail_account", gmail_account)
                ojsonEnvio.Add("mail_password", gmail_password)
                ojsonEnvio.Add("mail_to", pEmailTo)
                ojsonEnvio.Add("mail_cc", "")
                ojsonEnvio.Add("mail_bcc", "")
                ojsonEnvio.Add("mail_toerror", "")
                ojsonEnvio.Add("mail_subject", pmail_subject)
                StrJson = JsonConvert.SerializeObject(ojsonEnvio)
                respuesta = oWsDoc.SendGmail(StrJson, pBody)
                status = respuesta.Split("-")(0)
                msg = respuesta.Split("-")(1)
                If status = "E" Then
                    MsgBox("Error en envío:" & msg, MsgBoxStyle.Critical, "Aviso")
                End If
            End If

        End If

 


    End Sub

  

    Private Function obtenerFormatoHora(ByRef horahtml As String) As Decimal
        Dim Hora As String
        Hora = Now.Hour.ToString.ToString.PadLeft(2, "0") & Now.Minute.ToString.ToString.PadLeft(2, "0") & Now.Second.ToString.ToString.PadLeft(2, "0")
        horahtml = Now.Hour.ToString.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.ToString.PadLeft(2, "0") & ":" & Now.Second.ToString.ToString.PadLeft(2, "0")
        Return Hora
    End Function

    Private Function CrearDatosCuerpoOperacion(ByVal bolTipoUrl As Boolean) As String

        Dim bodyemail As New StringBuilder
        bodyemail.Append(HTMLInicio)
        bodyemail.Append("<table border='0px'style='font-size:12px' >")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'; font-weight: bold>")
        bodyemail.Append("<b> Sres. </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5' ; font-weight: bold>")
        bodyemail.Append("El usuario <b> " & USUARIO & " </b>, ha transferido" & IIf(nSeguimiento = "S", " al ", " a ") & "  <b> " & sSeguimiento & " las siguientes operaciones:" & " </b> ")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append(HTMLSalto)

        bodyemail.Append("<tr>")
        bodyemail.Append("<td font-weight: bold>")
        bodyemail.Append("<b> Compañia </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(":&nbsp;" & CompaniaDescripcion)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td font-weight: bold>")
        bodyemail.Append("<b> Fecha </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(":&nbsp;" & sFecha)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td font-weight: bold>")
        bodyemail.Append("<b> Hora </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(":&nbsp;" & sHoraHtml)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td font-weight: bold>")
        bodyemail.Append("<b> Responsable </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(":&nbsp;" & sResponsable)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td font-weight: bold>")
        bodyemail.Append("<b> Observaci&oacute;n </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("<td>")
        bodyemail.Append(":&nbsp;" & sObs)
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td colspan='5'>")
        bodyemail.Append("<hr style='border-style: dotted; border-width:1px; width=50%' />")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")

        bodyemail.Append("<tr>")
        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Operaci&oacute;n </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Fecha Operaci&oacute;n </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Cliente Operaci&oacute;n </b>")
        bodyemail.Append("</td>")

        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Gu&iacute;a Transporte </b>")
        bodyemail.Append("</td>")


        bodyemail.Append("<td style='text-align:center'; font-weight: bold>")
        bodyemail.Append("<b> Area Origen </b>")
        bodyemail.Append("</td>")
        bodyemail.Append("</tr>")


        For Each dr As DataRow In oDtDocumentos.Rows
            bodyemail.Append("<tr>")
            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("NOPRCN").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("FINCOP").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("TCMPCL").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            'bodyemail.Append(dr("NGUITR").ToString)
            bodyemail.Append(dr("NGUITS").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("<td style='text-align:center'>")
            bodyemail.Append(dr("SESTTP").ToString)
            bodyemail.Append("</td>")

            bodyemail.Append("</tr>")
        Next

    If bolTipoUrl Then
      Dim strCodigo As String = nCorrEnvio.ToString
      Dim strUrl As String = System.Configuration.ConfigurationSettings.AppSettings("url").ToString()
      strCodigo = HttpUtility.UrlEncode(Encrypt(strCodigo, "SoloClave"))

            strUrl = strUrl & "?IDAPLICACION=TRANSPORTE&IDOPCION=OPT5x&x_launcher=yes&from_portal=false&Codigo=" & strCodigo
            'strUrl = strUrl & "?Codigo=" & strCodigo

      bodyemail.Append("<td colspan='5'; font-weight: bold>")
      bodyemail.Append("<a href='" & strUrl & "' target='_blank'  onclick='window.open(this.href, this.target, null,'height=250, width=250,status= no, resizable= no, scrollbars=no, toolbar=no,location=no,menubar=no '); return false;'>Confirmar</a>")
      bodyemail.Append("</td>")
      bodyemail.Append("</tr>")
    End If


        bodyemail.Append("</table>")
        bodyemail.Append(HTMLFin)

        Return bodyemail.ToString.Trim
    End Function



#End Region
 


    Private Shared key() As Byte = {}
    Private Shared IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF, &H80, &HFE}

    Private Function ExtrarLeft(ByVal str As String, ByVal Length As Integer) As String
        Return str.Substring(0, Length)
    End Function
    Private Function Encrypt(ByVal stringToEncrypt As String, _
    ByVal SEncryptionKey As String) As String
        Try
            key = System.Text.Encoding.UTF8.GetBytes(ExtrarLeft(SEncryptionKey, 8))
            Dim des As New DESCryptoServiceProvider()
            Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes( _
                stringToEncrypt)
            Dim ms As New MemoryStream()
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(key, IV), _
                  CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())
        Catch e As Exception
            Return e.Message
        End Try
    End Function


    Private Sub frmEnvioCorreoDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obtenerFormatoHora(sHoraHtml)
        WebBrowser1.DocumentText = CrearDatosCuerpoOperacion(False)
    End Sub
End Class
