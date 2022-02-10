
Public Class beDestinatario

    Private _PNCCLNT As Decimal = 0
    Private _PSBU As String = ""
    Private _PNNCRRIT As Decimal = 0
    Private _PSEMAILTO As String = ""
    Private _PSEMAILCC As String = ""
    Private _PSEMAILBC As String = ""

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property
    Public Property PSBU() As String
        Get
            Return (_PSBU)
        End Get
        Set(ByVal value As String)
            _PSBU = value
        End Set
    End Property
    Public Property PNNCRRIT() As Decimal
        Get
            Return (_PNNCRRIT)
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRIT = value
        End Set
    End Property
    Public Property PSEMAILTO() As String
        Get
            Return (_PSEMAILTO)
        End Get
        Set(ByVal value As String)
            _PSEMAILTO = value
        End Set
    End Property
    Public Property PSEMAILCC() As String
        Get
            Return (_PSEMAILCC)
        End Get
        Set(ByVal value As String)
            _PSEMAILCC = value
        End Set
    End Property
    Public Property PSEMAILBC() As String
        Get
            Return (_PSEMAILBC)
        End Get
        Set(ByVal value As String)
            _PSEMAILBC = value
        End Set
    End Property


    Private _PSTIPPROC As String
    Public Property PSTIPPROC() As String
        Get
            Return _PSTIPPROC
        End Get
        Set(ByVal value As String)
            _PSTIPPROC = value
        End Set
    End Property

    Private _PSTIP_MAIL_DEST As String
    Public Property PSTIP_MAIL_DEST() As String
        Get
            Return _PSTIP_MAIL_DEST
        End Get
        Set(ByVal value As String)
            _PSTIP_MAIL_DEST = value
        End Set
    End Property

    Private _PSNLTECL As String = ""
    Public Property PSNLTECL() As String
        Get
            Return _PSNLTECL
        End Get
        Set(ByVal value As String)
            _PSNLTECL = value
        End Set
    End Property

    Private _PSTNMYAP As String = ""
    Public Property PSTNMYAP() As String
        Get
            Return _PSTNMYAP
        End Get
        Set(ByVal value As String)
            _PSTNMYAP = value
        End Set
    End Property

    Private _PSNCRRIT As Decimal = 0D
    Public Property PSNCRRIT() As Decimal
        Get
            Return _PSNCRRIT
        End Get
        Set(ByVal value As Decimal)
            _PSNCRRIT = value
        End Set
    End Property

End Class
