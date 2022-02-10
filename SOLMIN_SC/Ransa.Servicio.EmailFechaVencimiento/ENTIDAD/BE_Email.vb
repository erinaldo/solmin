Public Class BE_Email
    Private _MailAccount As String = ""
    Private _Mailpassword As String = ""
    Private _MailAccount_gmail As String = ""
    Private _Mailpassword_gmail As String = ""
    Private _EmailTo As String = ""
    Private _EmailBC As String = ""
    Private _Emailto_error As String = ""

    Public Property MailAccount() As String
        Get
            Return _MailAccount
        End Get
        Set(ByVal value As String)
            _MailAccount = value
        End Set
    End Property
    Public Property Mailpassword() As String
        Get
            Return _Mailpassword
        End Get
        Set(ByVal value As String)
            _Mailpassword = value
        End Set
    End Property

    Public Property MailAccountGmail() As String
        Get
            Return _MailAccount_gmail
        End Get
        Set(ByVal value As String)
            _MailAccount_gmail = value
        End Set
    End Property
    Public Property MailpasswordGmail() As String
        Get
            Return _Mailpassword_gmail
        End Get
        Set(ByVal value As String)
            _Mailpassword_gmail = value
        End Set
    End Property



    Public Property EmailTO() As String
        Get
            Return _EmailTo
        End Get
        Set(ByVal value As String)
            _EmailTo = value
        End Set
    End Property



    Public Property EmailBC() As String
        Get
            Return _EmailBC
        End Get
        Set(ByVal value As String)
            _EmailBC = value
        End Set
    End Property
    Public Property Emailto_Error() As String
        Get
            Return _EmailTo_ERROR
        End Get
        Set(ByVal value As String)
            _EmailTo_ERROR = value
        End Set
    End Property


End Class
