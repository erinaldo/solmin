Public Class beClienteDireccion

    Private _PSTIPO As String
    Public Property PSTIPO() As String
        Get
            Return _PSTIPO
        End Get
        Set(ByVal value As String)
            _PSTIPO = value
        End Set
    End Property


    Private _PNCCLNT As Decimal
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Private _PNCDIRSE As Decimal
    Public Property PNCDIRSE() As Decimal
        Get
            Return _PNCDIRSE
        End Get
        Set(ByVal value As Decimal)
            _PNCDIRSE = value
        End Set
    End Property


    Private _PNCPLNDV As Decimal
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property


    Private _PNCZNFCC As Decimal
    Public Property PNCZNFCC() As Decimal
        Get
            Return _PNCZNFCC
        End Get
        Set(ByVal value As Decimal)
            _PNCZNFCC = value
        End Set
    End Property


    Private _PNITEM As Decimal
    Public Property PNITEM() As Decimal
        Get
            Return _PNITEM
        End Get
        Set(ByVal value As Decimal)
            _PNITEM = value
        End Set
    End Property




End Class
