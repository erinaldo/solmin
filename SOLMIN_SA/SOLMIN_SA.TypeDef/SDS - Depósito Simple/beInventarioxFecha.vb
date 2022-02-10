Public Class beInventarioxFecha

    Private _PSCCMPN As String
    Private _PSCCVSN As String
    Private _PNCPLNDV As Decimal
    Private _PNCCLNT As Decimal
    Private _PSCTPDP6 As String
    Private _PNFECINV As Decimal


    Public Property PSCCMPN() As String
        Get
            Return (_PSCCMPN)
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PSCCVSN() As String
        Get
            Return (_PSCCVSN)
        End Get
        Set(ByVal value As String)
            _PSCCVSN = value
        End Set
    End Property

    Public Property PNCPLNDV() As Decimal
        Get
            Return (_PNCPLNDV)
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PSCTPDP6() As String
        Get
            Return (_PSCTPDP6)
        End Get
        Set(ByVal value As String)
            _PSCTPDP6 = value
        End Set
    End Property

    Public Property PNFECINV() As Decimal
        Get
            Return (_PNFECINV)
        End Get
        Set(ByVal value As Decimal)
            _PNFECINV = value
        End Set
    End Property

End Class
