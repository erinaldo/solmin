Public Class beMedioTransporte
    Private _PNCMEDTR As Decimal = 0
    Private _PSTNMMDT As String = ""

    Public Property PNCMEDTR() As Decimal
        Get
            Return _PNCMEDTR
        End Get
        Set(ByVal value As Decimal)
            _PNCMEDTR = value
        End Set
    End Property

    Public Property PSTNMMDT() As String
        Get
            Return _PSTNMMDT
        End Get
        Set(ByVal value As String)
            _PSTNMMDT = value
        End Set
    End Property

End Class
