Public Class beAdjuntarMercaderia
    Private _PSCORRELA As String
    Private _PSCMRCLR As String
    Private _PSTMRCD2 As String
    Private _PNQSFMC As Decimal
    Private _PSCUNCN5 As String

    Public Property PSCORRELA() As String
        Get
            Return (_PSCORRELA)
        End Get
        Set(ByVal value As String)
            _PSCORRELA = value
        End Set
    End Property

    Public Property PSCMRCLR() As String
        Get
            Return (_PSCMRCLR)
        End Get
        Set(ByVal value As String)
            _PSCMRCLR = value
        End Set
    End Property

    Public Property PSTMRCD2() As String
        Get
            Return (_PSTMRCD2)
        End Get
        Set(ByVal value As String)
            _PSTMRCD2 = value
        End Set
    End Property

    Public Property PNQSFMC() As Decimal
        Get
            Return (_PNQSFMC)
        End Get
        Set(ByVal value As Decimal)
            _PNQSFMC = value
        End Set
    End Property

    Public Property PSCUNCN5() As String
        Get
            Return (_PSCUNCN5)
        End Get
        Set(ByVal value As String)
            _PSCUNCN5 = value
        End Set
    End Property

End Class
