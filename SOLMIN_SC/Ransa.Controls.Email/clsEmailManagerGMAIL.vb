Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports RC.Gmail
Imports System.Web.Mail
Public Class clsEmailManagerGMAIL
    'Private _mailserver As String = ""
    'Private _port As String = ""
    Private _mailaccount As String = ""
    Private _mailpassword As String = ""
    Private _mailnotification As String = ""
    Private _mailnotificationCC As String = ""
    Private _mailnotificationBCC As String = ""
    Private _mailbody As String = ""
    Private _attachment As String = ""
    Private _list_attach As New Generic.List(Of String)
    Private _mailSubject As String = ""
    'Private _ExitoEnvio As Integer = 0

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

    Public Property MailBody() As String
        Get
            Return _mailbody
        End Get
        Set(ByVal value As String)
            _mailbody = value
        End Set
    End Property

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


 

    Public Sub SendMailGmail()
        Dim gmailMsg As New RC.Gmail.GmailMessage(MailAccount, Mailpassword)
        gmailMsg.To = _mailnotification
        gmailMsg.From = MailAccount
        gmailMsg.Subject = MailSubject
        gmailMsg.Body = Me.MailBody
        gmailMsg.BodyFormat = Web.Mail.MailFormat.Html
        If (_mailnotificationCC.Trim.Length <> 0) Then
            gmailMsg.Cc = _mailnotificationCC
        End If
        If (_mailnotificationBCC.Trim.Length <> 0) Then
            gmailMsg.Bcc = _mailnotificationBCC
        End If
        If _attachment <> "" Then
            Dim objAttachment As New System.Net.Mail.Attachment(_attachment)
            gmailMsg.Attachments.Add(objAttachment)
        End If
        If Me._list_attach.Count > 0 Then
            For i As Integer = 0 To Me._list_attach.Count - 1
                Dim objAttachment As New MailAttachment(Me._list_attach(i))
                gmailMsg.Attachments.Add(objAttachment)
            Next
        End If
        Try
            If (_mailnotification.Trim.Length <> 0) Then
                gmailMsg.Send()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


End Class
