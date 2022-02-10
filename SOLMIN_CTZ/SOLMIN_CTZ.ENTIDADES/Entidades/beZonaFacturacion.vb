Public Class beZonaFacturacion

    Private _CZNFCC As Decimal
    Private _TZNFCC As String
    Property CZNFCC() As Decimal
        Get
            Return _CZNFCC
        End Get
        Set(ByVal value As Decimal)
            _CZNFCC = value
        End Set
    End Property


    Public Property TZNFCC() As String
        Get
            Return _TZNFCC
        End Get
        Set(ByVal value As String)
            _TZNFCC = value
        End Set
    End Property
End Class
