Public Class beActualizaStockFisicoERI
    Private _PSCCMPN As String
    Private _PSCRGVTA As String
    Private _PNCPLNDV As Decimal
    Private _PNCCLNT As Decimal
    Private _PNNROERI As Decimal
    Private _PSCMRCLR As String
    Private _PNQSFMC As Decimal
    Private _PNQSFMP As Decimal
    Private _PSCUSERI As String
    Private _NTRMCR As String

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
            Return (_PSCRGVTA)
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

    Public Property PNNROERI() As Decimal
        Get
            Return (_PNNROERI)
        End Get
        Set(ByVal value As Decimal)
            _PNNROERI = value
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

    Public Property PNQSFMC() As String
        Get
            Return (_PNQSFMC)
        End Get
        Set(ByVal value As String)
            _PNQSFMC = value
        End Set
    End Property

    Public Property PNQSFMP() As String
        Get
            Return (_PNQSFMP)
        End Get
        Set(ByVal value As String)
            _PNQSFMP = value
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

    Public Property NTRMCR() As String
        Get
            Return (_NTRMCR)
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property
   
End Class
