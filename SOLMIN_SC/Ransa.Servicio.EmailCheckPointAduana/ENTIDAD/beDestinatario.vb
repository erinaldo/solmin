Public Class beDestinatario
    Private _PNCCLNT As Decimal = 0
    'Private _PSBU As String = ""
    Private _PNNCRRIT As Decimal = 0
    Private _PSEMAILTO As String = ""
    Private _PSEMAILCC As String = ""
    Private _PSEMAILBC As String = ""
    Private _PSTIPO_ENVIO As String = ""
    Private _PSDIV_ENVIO As String = ""
    Private _PSFORMAT_ENVIO As String = ""
    Private _PSTIP_MAIL_DEST As String = ""
    Private _PSDES_CLIENTE As String = ""
    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property
    'Public Property PSBU() As String
    '    Get
    '        Return (_PSBU)
    '    End Get
    '    Set(ByVal value As String)
    '        _PSBU = value
    '    End Set
    'End Property
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

    Public Property PSFORMAT_ENVIO() As String
        Get
            Return (_PSFORMAT_ENVIO)
        End Get
        Set(ByVal value As String)
            _PSFORMAT_ENVIO = value
        End Set
    End Property

    Public Property PSTIPO_ENVIO() As String
        Get
            Return (_PSTIPO_ENVIO)
        End Get
        Set(ByVal value As String)
            _PSTIPO_ENVIO = value
        End Set
    End Property

    Public Property PSDIV_ENVIO() As String
        Get
            Return (_PSDIV_ENVIO)
        End Get
        Set(ByVal value As String)
            _PSDIV_ENVIO = value
        End Set
    End Property

    Public Property PSTIP_MAIL_DEST() As String
        Get
            Return _PSTIP_MAIL_DEST
        End Get
        Set(ByVal value As String)
            _PSTIP_MAIL_DEST = value
        End Set
    End Property

    Public Property PSDES_CLIENTE() As String
        Get
            Return _PSDES_CLIENTE
        End Get
        Set(ByVal value As String)
            _PSDES_CLIENTE = value
        End Set
    End Property



End Class
