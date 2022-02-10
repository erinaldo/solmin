Public Class BE_Destinatario

    Private _PNCCLNT As Decimal = 0
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
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


    'Private _PS_CCLNT_NLTECL As String = ""
    'Public Property PS_CCLNT_NLTECL() As String
    '    Get
    '        Return _PS_CCLNT_NLTECL
    '    End Get
    '    Set(ByVal value As String)
    '        _PS_CCLNT_NLTECL = value
    '    End Set
    'End Property



    Private _PSTCMPCL As String = ""
    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property

   

    Private _PSEMAILTO As String = ""
    Public Property PSEMAILTO() As String
        Get
            Return _PSEMAILTO
        End Get
        Set(ByVal value As String)
            _PSEMAILTO = value
        End Set
    End Property

End Class
