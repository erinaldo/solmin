Public Class BE_Regimen

    Private _PNNORSCI As Decimal = 0
    Private _PSPNNMOS As String = ""
    Private _PSFORSCI As String = ""
    Private _PSREGIMEN As String = ""
    Private _PNNTPODT As Decimal = 0
    Private _PNNCODRG As Decimal = 0
    Private _PSFECINI As String = ""
    Private _PSFECVEN As String = ""
    Private _PSTOBSRL As String = ""
    Private _POBESCALA As New BE_Escala
    Private _PNDIFDIAS As Int32 = 0
    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property

    Public Property PSPNNMOS() As String
        Get
            Return _PSPNNMOS
        End Get
        Set(ByVal value As String)
            _PSPNNMOS = value
        End Set
    End Property

    Public Property PSFORSCI() As String
        Get
            Return _PSFORSCI
        End Get
        Set(ByVal value As String)
            _PSFORSCI = value
        End Set
    End Property

    Public Property PSREGIMEN() As String
        Get
            Return _PSREGIMEN
        End Get
        Set(ByVal value As String)
            _PSREGIMEN = value
        End Set
    End Property

    Public Property PNNTPODT() As Decimal
        Get
            Return _PNNTPODT
        End Get
        Set(ByVal value As Decimal)
            _PNNTPODT = value
        End Set
    End Property

    Public Property PNNCODRG() As Decimal
        Get
            Return _PNNCODRG
        End Get
        Set(ByVal value As Decimal)
            _PNNCODRG = value
        End Set
    End Property

    Public Property PSFECINI() As String
        Get
            Return _PSFECINI
        End Get
        Set(ByVal value As String)
            _PSFECINI = value
        End Set
    End Property
    Public Property PSFECVEN() As String
        Get
            Return _PSFECVEN
        End Get
        Set(ByVal value As String)
            _PSFECVEN = value
        End Set
    End Property
    Public Property PSTOBSRL() As String
        Get
            Return _PSTOBSRL
        End Get
        Set(ByVal value As String)
            _PSTOBSRL = value
        End Set
    End Property

    Public Property POBESCALA() As BE_Escala
        Get
            Return _POBESCALA
        End Get
        Set(ByVal value As BE_Escala)
            _POBESCALA = value
        End Set
    End Property

    Public Property PNDIFDIAS() As Int32
        Get
            Return _PNDIFDIAS
        End Get
        Set(ByVal value As Int32)
            _PNDIFDIAS = value
        End Set
    End Property




End Class
