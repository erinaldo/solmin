Public Class beInventarioExcel
    Private _PSCCMPN As String
    Private _PSCRGVTA As String
    Private _PNCPLNDV As Decimal
    Private _PNCCLNT As Decimal
    Private _PNNROERI As Decimal

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
End Class
