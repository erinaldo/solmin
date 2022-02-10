Public Class beDetalleCargaInternacional
    Private _PNNORSCI As Decimal = 0
    Private _PSPNNMOS As String = ""
    Private _PNNTPODT As Decimal = 0
    Private _PNNCODRG As Decimal = 0
    Private _PNNCRRDC As Decimal = 0
    Private _PNITTOPD As Decimal = 0
    Private _PSSORDOC As String = ""
    Private _PNQCANTI As Decimal = 0
    Private _PSTXT01 As String = ""
    Private _PSCULUSA As String = ""
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSSESTRG As String = ""
    Private _PNEXISTS As Decimal = 0
    Private _PSFECINI As String = ""
    Private _PSFECVEN As String = ""
    Private _PNFECINI As Decimal = 0
    Private _PNFECVEN As Decimal = 0


    Public Property PNNORSCI() As Decimal
        Get
            Return (_PNNORSCI)
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
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
    Public Property PNNCRRDC() As Decimal
        Get
            Return (_PNNCRRDC)
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRDC = value
        End Set
    End Property
    Public Property PNITTOPD() As Decimal
        Get
            Return (_PNITTOPD)
        End Get
        Set(ByVal value As Decimal)
            _PNITTOPD = value
        End Set
    End Property
    
    Public Property PSSORDOC() As String
        Get
            Return (_PSSORDOC)
        End Get
        Set(ByVal value As String)
            _PSSORDOC = value
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
    Public Property PSTXT01() As String
        Get
            Return (_PSTXT01)
        End Get
        Set(ByVal value As String)
            _PSTXT01 = value
        End Set
    End Property
   
    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property PNFULTAC() As Decimal
        Get
            Return (_PNFULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return (_PNHULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
        End Set
    End Property
    Public Property PSSESTRG() As String
        Get
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
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


    Public Property PNEXISTS() As Decimal
        Get
            Return (_PNEXISTS)
        End Get
        Set(ByVal value As Decimal)
            _PNEXISTS = value
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

    Public Property PNFECINI() As Decimal
        Get
            Return (_PNFECINI)
        End Get
        Set(ByVal value As Decimal)
            _PNFECINI = value
        End Set
    End Property

    Public Property PNFECVEN() As Decimal
        Get
            Return (_PNFECVEN)
        End Get
        Set(ByVal value As Decimal)
            _PNFECVEN = value
        End Set
    End Property

End Class
