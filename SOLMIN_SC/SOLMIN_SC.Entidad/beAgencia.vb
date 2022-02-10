Public Class beAgencia

    Private _PNPNNMOS As Decimal = 0
    Private _PSTCANAL As String = ""
    Private _PSTNRODU As String = ""
    Private _PNCCLNT As Decimal = 0

    Public Property PNPNNMOS() As Decimal
        Get
            Return _PNPNNMOS
        End Get
        Set(ByVal value As Decimal)
            _PNPNNMOS = value
        End Set
    End Property


    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Private _PNCZNFCC As Decimal = 0
    Public Property PNCZNFCC() As Decimal
        Get
            Return _PNCZNFCC
        End Get
        Set(ByVal value As Decimal)
            _PNCZNFCC = value
        End Set
    End Property



    Public Property PSTCANAL() As String
        Get
            Return _PSTCANAL
        End Get
        Set(ByVal value As String)
            _PSTCANAL = value
        End Set
    End Property

    Public Property PSTNRODU() As String
        Get
            Return _PSTNRODU
        End Get
        Set(ByVal value As String)
            _PSTNRODU = value
        End Set
    End Property

End Class
