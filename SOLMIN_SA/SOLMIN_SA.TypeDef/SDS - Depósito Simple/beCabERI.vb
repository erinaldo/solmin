Public Class beCabERI

    Private _PSCCMPN As String
    Private _PSCRGVTA As String
    Private _PNCPLNDV As Decimal
    Private _PNCCLNT As Decimal
    Private _PNFECINV As Decimal
    Private _PSCUSERI As String
    Private _PNTRMCR As String

    Public Property PSCCMPN() As String
        Get
            Return (_PSCCMPN)
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PSCRGVTA() As String
        Get
            Return _PSCRGVTA
        End Get
        Set(ByVal value As String)
            _PSCRGVTA = value
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

    Public Property PNFECINV() As Decimal
        Get
            Return (_PNFECINV)
        End Get
        Set(ByVal value As Decimal)
            _PNFECINV = value
        End Set
    End Property

    Public Property PSCUSERI() As String
        Get
            Return (_PSCUSERI)
        End Get
        Set(ByVal value As String)
            _PSCUSERI = value
        End Set
    End Property

    Public Property PNTRMCR() As String
        Get
            Return (_PNTRMCR)
        End Get
        Set(ByVal value As String)
            _PNTRMCR = value
        End Set
    End Property

End Class
