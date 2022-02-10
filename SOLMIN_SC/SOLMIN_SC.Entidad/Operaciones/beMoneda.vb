Public Class beMoneda
    Private _PNCMNDA1 As Decimal
    Private _PSTSGNMN As String

    Public Property PSTSGNMN() As String
        Get
            Return _PSTSGNMN
        End Get
        Set(ByVal value As String)
            _PSTSGNMN = value
        End Set
    End Property


    Public Property PNCMNDA1() As Decimal
        Get
            Return _PNCMNDA1
        End Get
        Set(ByVal value As Decimal)
            _PNCMNDA1 = value
        End Set
    End Property
End Class
