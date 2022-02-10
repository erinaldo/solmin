Public Class beCnsDetalleEmbarque
    Private _PNNORSCI As Decimal = 0
    Private _PSFORSCI As String = ""
    Private _PSFECINI As String = ""
    Private _PSFECVEN As String = ""
    Private _PSPNNMOS As String = ""
    Private _PNNTPODT As Decimal = 0
    Private _PNNCODRG As Decimal = 0
    Private _PNQCANTI As Decimal = 0
    Private _PSTDSCRG_REGIMEN As String = ""
    Private _PSTDSCRG_TIPO_CARGA As String = ""
    Private _PNDIFDIAS As Int32 = 0
    Private _POBESCALA As New beEscala
    Public Property PNNORSCI() As Decimal
        Get
            Return (_PNNORSCI)
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property

    Public Property PSFORSCI() As String
        Get
            Return (_PSFORSCI)
        End Get
        Set(ByVal value As String)
            _PSFORSCI = value
        End Set
    End Property


    Public Property PSPNNMOS() As String
        Get
            Return (_PSPNNMOS)
        End Get
        Set(ByVal value As String)
            _PSPNNMOS = value
        End Set
    End Property


    Public Property PSFECINI() As String
        Get
            Return (_PSFECINI)
        End Get
        Set(ByVal value As String)
            _PSFECINI = value
        End Set
    End Property
    Public Property PSFECVEN() As String
        Get
            Return (_PSFECVEN)
        End Get
        Set(ByVal value As String)
            _PSFECVEN = value
        End Set
    End Property

    Public Property PNNTPODT() As Decimal
        Get
            Return (_PNNTPODT)
        End Get
        Set(ByVal value As Decimal)
            _PNNTPODT = value
        End Set
    End Property
    Public Property PNNCODRG() As Decimal
        Get
            Return (_PNNCODRG)
        End Get
        Set(ByVal value As Decimal)
            _PNNCODRG = value
        End Set
    End Property

    Public Property PNQCANTI() As Decimal
        Get
            Return (_PNQCANTI)
        End Get
        Set(ByVal value As Decimal)
            _PNQCANTI = value
        End Set
    End Property
   
    Public Property PSTDSCRG_REGIMEN() As String
        Get
            Return (_PSTDSCRG_REGIMEN)
        End Get
        Set(ByVal value As String)
            _PSTDSCRG_REGIMEN = value
        End Set
    End Property

    Public Property PSTDSCRG_TIPO_CARGA() As String
        Get
            Return (_PSTDSCRG_TIPO_CARGA)
        End Get
        Set(ByVal value As String)
            _PSTDSCRG_TIPO_CARGA = value
        End Set
    End Property

    Public Property PNDIFDIAS() As Int32
        Get
            Return (_PNDIFDIAS)
        End Get
        Set(ByVal value As Int32)
            _PNDIFDIAS = value
        End Set
    End Property


    Public Property POBESCALA() As beEscala
        Get
            Return (_POBESCALA)
        End Get
        Set(ByVal value As beEscala)
            _POBESCALA = value
        End Set
    End Property



End Class
