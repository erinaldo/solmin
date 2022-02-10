Public Class beObservacionCarga
    Private _PNNORSCI As Decimal = 0
    Private _PNNRITEM As Decimal = 0
    Private _PNTFCOBS As Decimal = 0
    Private _PSTOBS As String = ""
    Private _PSCULUSA As String = ""
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PNNRPEMB As Decimal = 0
    Private _PSFECOBS As String = ""
    Private _PNEXISTS As Decimal = 0

    Public Property PNNORSCI() As Decimal
        Get
            Return (_PNNORSCI)
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property
    Public Property PNNRITEM() As Decimal
        Get
            Return (_PNNRITEM)
        End Get
        Set(ByVal value As Decimal)
            _PNNRITEM = value
        End Set
    End Property
    Public Property PNTFCOBS() As Decimal
        Get
            Return (_PNTFCOBS)
        End Get
        Set(ByVal value As Decimal)
            _PNTFCOBS = value
        End Set
    End Property
    Public Property PSTOBS() As String
        Get
            Return (_PSTOBS)
        End Get
        Set(ByVal value As String)
            _PSTOBS = value
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
   

    Public Property PNNRPEMB() As Decimal
        Get
            Return (_PNNRPEMB)
        End Get
        Set(ByVal value As Decimal)
            _PNNRPEMB = value
        End Set
    End Property

    Public Property PSFECOBS() As String
        Get
            Return (_PSFECOBS)
        End Get
        Set(ByVal value As String)
            _PSFECOBS = value
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


End Class
