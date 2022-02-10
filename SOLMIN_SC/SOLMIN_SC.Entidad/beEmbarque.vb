Public Class beEmbarque
    Private _PNNORSCI As Decimal = 0
    Private _PNCCLNT As Decimal = 0
    Private _PSNORCML As String = ""
    Private _PNNRITEM As Decimal = 0
    Private _PNNRPEMB As Decimal = 0
    Private _PSSBITOC As String = ""
    Private _PNQTPCM2 As Decimal = 0

    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
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
    Public Property PSNORCML() As String
        Get
            Return _PSNORCML
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property
    Public Property PNNRITEM() As Decimal
        Get
            Return _PNNRITEM
        End Get
        Set(ByVal value As Decimal)
            _PNNRITEM = value
        End Set
    End Property
    Public Property PNNRPEMB() As Decimal
        Get
            Return _PNNRPEMB
        End Get
        Set(ByVal value As Decimal)
            _PNNRPEMB = value
        End Set
    End Property
    Public Property PSSBITOC() As String
        Get
            Return _PSSBITOC
        End Get
        Set(ByVal value As String)
            _PSSBITOC = value
        End Set
    End Property
    Public Property PNQTPCM2() As Decimal
        Get
            Return _PNQTPCM2
        End Get
        Set(ByVal value As Decimal)
            _PNQTPCM2 = value
        End Set
    End Property
End Class
