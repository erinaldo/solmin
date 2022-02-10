Public Class beInferfazSapPedido
    Private _CCMPN As String = String.Empty
    Private _CRGVTA As String = String.Empty
    Private _CCLNT As Decimal = 0
    Private _DCENSA As String = String.Empty
    Private _PSCULUSA As String = String.Empty
    Private _PSNTRMNL As String = String.Empty
    Private _PSNUMDES As String = String.Empty

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property

    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property
    Public Property DCENSA() As String
        Get
            Return _DCENSA
        End Get
        Set(ByVal value As String)
            _DCENSA = value
        End Set
    End Property

    Public Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property

    Public Property PSNTRMNL() As String
        Get
            Return _PSNTRMNL
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property

    Public Property PSNUMDES() As String
        Get
            Return _PSNUMDES
        End Get
        Set(ByVal value As String)
            _PSNUMDES = value
        End Set
    End Property

End Class
