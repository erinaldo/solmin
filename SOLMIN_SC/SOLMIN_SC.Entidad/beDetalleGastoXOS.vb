Public Class beDetalleGastoXOS

    Private _PNNORDSR As Decimal = 0
    Private _PNCZNFCC As Decimal = 0
    Private _PSTPSRVA As String = ""
    Private _PNCPLNDV As Decimal = 0

    Public Property PNNORDSR() As Decimal
        Get
            Return _PNNORDSR
        End Get
        Set(ByVal value As Decimal)
            _PNNORDSR = value
        End Set
    End Property

    Public Property PNCZNFCC() As Decimal
        Get
            Return _PNCZNFCC
        End Get
        Set(ByVal value As Decimal)
            _PNCZNFCC = value
        End Set
    End Property

    Public Property PSTPSRVA() As String
        Get
            Return _PSTPSRVA
        End Get
        Set(ByVal value As String)
            _PSTPSRVA = value
        End Set
    End Property

    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

End Class
