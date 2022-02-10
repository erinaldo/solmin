Imports Microsoft.VisualBasic
Imports System.Net.Mail
Public Class clsEmailManager
    'Private _mailserver As String = ""
    'Private _port As String = ""
    Private _mailaccount As String = ""
    Private _mailpassword As String = ""

    Private _mailnotification As String = ""
    Private _mailnotificationCC As String = ""
    Private _mailnotificationBCC As String = ""


    'Private _mailnotificationError As String = ""
    'Private _mailSubjectError As String = ""
    'Private _mailbodyError As String = ""
   

    Private _mailbody As String = ""
    Private _attachment As String = ""
    Private _list_attach As New Generic.List(Of String)
    Private _mailSubject As String = ""

    'Private _ExitoEnvio As Integer = 0


    'Private _mailaccount As String = ""
    'Private _mailpassword As String = ""

    'Public Property ExitoEnvio() As Integer
    '    Get
    '        Return _ExitoEnvio
    '    End Get
    '    Set(ByVal value As Integer)
    '        _ExitoEnvio = value
    '    End Set
    'End Property

    Public Property MailSubject() As String
        Get
            Return _mailSubject
        End Get
        Set(ByVal value As String)
            _mailSubject = value
        End Set
    End Property

    'Public Property MailSubjectError() As String
    '    Get
    '        Return _mailSubjectError
    '    End Get
    '    Set(ByVal value As String)
    '        _mailSubjectError = value
    '    End Set
    'End Property

    '_mailSubjectError

    Public Property MailBody() As String
        Get
            Return _mailbody
        End Get
        Set(ByVal value As String)
            _mailbody = value
        End Set
    End Property


    'Public Property MailBodyError() As String
    '    Get
    '        Return _mailbodyError
    '    End Get
    '    Set(ByVal value As String)
    '        _mailbodyError = value
    '    End Set
    'End Property

    'Public Property MailServer() As String
    '    Get
    '        Return _mailserver
    '    End Get
    '    Set(ByVal value As String)
    '        _mailserver = value
    '    End Set
    'End Property

    Public Property MailNotification() As String
        Get
            Return _mailnotification
        End Get
        Set(ByVal value As String)
            _mailnotification = value
        End Set
    End Property

    Public Property mailnotificationCC() As String
        Get
            Return _mailnotificationCC
        End Get
        Set(ByVal value As String)
            _mailnotificationCC = value
        End Set
    End Property
    Public Property mailnotificationBCC() As String
        Get
            Return _mailnotificationBCC
        End Get
        Set(ByVal value As String)
            _mailnotificationBCC = value
        End Set
    End Property


    'Public Property MailNotificationError() As String
    '    Get
    '        Return _mailnotificationError
    '    End Get
    '    Set(ByVal value As String)
    '        _mailnotificationError = value
    '    End Set
    'End Property

   
    Public Property Attachment() As String
        Get
            Return _attachment
        End Get
        Set(ByVal value As String)
            _attachment = value
        End Set
    End Property

    Public Property Attachmentcollection() As Generic.List(Of String)
        Get
            Return _list_attach
        End Get
        Set(ByVal value As Generic.List(Of String))
            _list_attach = value
        End Set
    End Property

    'Public Property Port() As String
    '    Get
    '        Return _port
    '    End Get
    '    Set(ByVal value As String)
    '        _port = value
    '    End Set
    'End Property

   


    Public Property MailAccount() As String
        Get
            Return _mailaccount
        End Get
        Set(ByVal value As String)
            _mailaccount = value
        End Set
    End Property

    Public Property Mailpassword() As String
        Get
            Return _mailpassword
        End Get
        Set(ByVal value As String)
            _mailpassword = value
        End Set
    End Property


    Private _enablessl As Boolean
    Public Property EnableSSL() As Boolean
        Get
            Return _enablessl
        End Get
        Set(ByVal value As Boolean)
            _enablessl = value
        End Set
    End Property


    Public Sub SendMailProvider()


        Dim server As New Net.Mail.SmtpClient("pod51010.outlook.com")
        server.Port = 587
        server.EnableSsl = True
        server.Credentials = New System.Net.NetworkCredential(MailAccount, Mailpassword)

        Dim mail As New Net.Mail.MailMessage()
        mail.From = New Net.Mail.MailAddress(MailAccount)

        Dim Mails() As String = _mailnotification.Split(";")
        For i As Integer = 0 To Mails.Length - 1
            mail.To.Add(Mails(i))
        Next
        'Copia
        If mailnotificationCC.Length > 0 Then
            Dim MailsCC() As String = mailnotificationCC.Split(";")

            For i As Integer = 0 To MailsCC.Length - 1
                mail.CC.Add(MailsCC(i))
            Next
        End If

        'Copia Oculta
        If mailnotificationBCC.Length > 0 Then
            Dim MailsBCC() As String = mailnotificationBCC.Split(";")

            For i As Integer = 0 To MailsBCC.Length - 1
                mail.Bcc.Add(MailsBCC(i))
            Next
        End If
        mail.Subject = MailSubject
        mail.Body = MailBody
        mail.IsBodyHtml = True
        If _attachment <> "" Then
            Dim objAttachment As New System.Net.Mail.Attachment(_attachment)
            mail.Attachments.Add(objAttachment)
        End If

        If Me._list_attach.Count > 0 Then
            For i As Integer = 0 To Me._list_attach.Count - 1
                Dim objAttachment As New System.Net.Mail.Attachment(Me._list_attach(i))
                mail.Attachments.Add(objAttachment)
            Next
        End If


        If (_mailnotification.Trim.Length <> 0) Then
            server.Send(mail)
        End If
         
    End Sub
End Class



