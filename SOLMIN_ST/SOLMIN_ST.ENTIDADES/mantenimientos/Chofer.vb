Namespace mantenimientos

  Public Class Chofer

    Private _NCLICO As Double = 0
    Private _CBRCNT As String = ""
    Private _TNMCMC As String = ""
    Private _TAPPAC As String = ""
    Private _TAPMAC As String = ""
    Private _NLELCH As String = ""
    Private _CSGRSC As String = ""
    Private _TGRPSN As String = ""
    Private _SESTRG As String = ""
    Private _FVEDNI As String = ""
    Private _FEMLIC As String = ""
    Private _FVELIC As String = ""
    Private _CODSAP As String = ""
    Private _FECING As String = ""
    Private _TDRCC As String = ""
    Private _NRORPM As String = ""
    Private _TOBS As String = ""
    Private _TALPOL As String = ""
    Private _TALPAN As String = ""
    Private _TALBOT As String = ""
    Private _CUSCRT As String = ""
        Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _NTRMNL As String = ""
    Private _TCATLI As String = ""
    Private _CCATLI As String = ""
    Private _SINDRC As String = ""
    Private _IMG As Byte()
    Private _NOMBRECOMPLETO As String = ""
    Private _CTRSPT As Double = 0
    Private _ESTADO As String = ""
    Private _CCMPN As String
    Private _FLGAPR As String = ""
    Private _USRAPR As String = ""
    Private _FCHAPR As Double = 0
    Private _HRAAPR As Double = 0
    Private _FCHING As String = ""

    Public Property FCHING() As String
      Get
        Return _FCHING
      End Get
      Set(ByVal value As String)
        _FCHING = value
      End Set
    End Property

    Public Property FLGAPR() As String
      Get
        Return _FLGAPR
      End Get
      Set(ByVal value As String)
        _FLGAPR = value
      End Set
    End Property

    Public Property USRAPR() As String
      Get
        Return _USRAPR
      End Get
      Set(ByVal value As String)
        _USRAPR = value
      End Set
    End Property

    Public Property FCHAPR() As Double
      Get
        Return _FCHAPR
      End Get
      Set(ByVal value As Double)
        _FCHAPR = value
      End Set
    End Property

    Public Property HRAAPR() As Double
      Get
        Return _HRAAPR
      End Get
      Set(ByVal value As Double)
        _HRAAPR = value
      End Set
    End Property

    Public Property ESTADO()
      Get
        Return _ESTADO
      End Get
      Set(ByVal value)
        _ESTADO = value
      End Set
    End Property

    Public Property CCMPN() As String
      Get
        Return _CCMPN
      End Get
      Set(ByVal value As String)
        _CCMPN = value
      End Set
    End Property

    Public Property CTRSPT() As Double
      Get
        Return _CTRSPT
      End Get
      Set(ByVal value As Double)
        _CTRSPT = value
      End Set
    End Property

    Public Property IMG() As Byte()
      Get
        Return _IMG
      End Get
      Set(ByVal value As Byte())
        _IMG = value
      End Set
    End Property

    Public Property NCLICO() As Double
      Get
        Return _NCLICO
      End Get
      Set(ByVal value As Double)
        _NCLICO = value
      End Set
    End Property

    Public Property CBRCNT() As String
      Get
        Return _CBRCNT
      End Get
      Set(ByVal Value As String)
        _CBRCNT = Value
      End Set
    End Property

    Public Property TNMCMC() As String
      Get
        Return _TNMCMC
      End Get
      Set(ByVal Value As String)
        _TNMCMC = Value
      End Set
    End Property

    Public Property TAPPAC() As String
      Get
        Return _TAPPAC
      End Get
      Set(ByVal Value As String)
        _TAPPAC = Value
      End Set
    End Property

    Public Property TAPMAC() As String
      Get
        Return _TAPMAC
      End Get
      Set(ByVal Value As String)
        _TAPMAC = Value
      End Set
    End Property

    Public Property NLELCH() As String
      Get
        Return _NLELCH
      End Get
      Set(ByVal Value As String)
        _NLELCH = Value
      End Set
    End Property

    Public Property CSGRSC() As String
      Get
        Return _CSGRSC
      End Get
      Set(ByVal Value As String)
        _CSGRSC = Value
      End Set
    End Property

    Public Property TGRPSN() As String
      Get
        Return _TGRPSN
      End Get
      Set(ByVal Value As String)
        _TGRPSN = Value
      End Set
    End Property

    Public Property SESTRG() As String
      Get
        Return _SESTRG
      End Get
      Set(ByVal Value As String)
        _SESTRG = Value
      End Set
    End Property

    Public Property FVEDNI() As String
      Get
        Return _FVEDNI
      End Get
      Set(ByVal Value As String)
        _FVEDNI = Value
      End Set
    End Property

    Public Property FEMLIC() As String
      Get
        Return _FEMLIC
      End Get
      Set(ByVal Value As String)
        _FEMLIC = Value
      End Set
    End Property

    Public Property FVELIC() As String
      Get
        Return _FVELIC
      End Get
      Set(ByVal Value As String)
        _FVELIC = Value
      End Set
    End Property

    Public Property CODSAP() As String
      Get
        Return _CODSAP
      End Get
      Set(ByVal Value As String)
        _CODSAP = Value
      End Set
    End Property

    Public Property FECING() As String
      Get
        Return _FECING
      End Get
      Set(ByVal Value As String)
        _FECING = Value
      End Set
    End Property

    Public Property TDRCC() As String
      Get
        Return _TDRCC
      End Get
      Set(ByVal Value As String)
        _TDRCC = Value
      End Set
    End Property

    Public Property NRORPM() As String
      Get
        Return _NRORPM
      End Get
      Set(ByVal Value As String)
        _NRORPM = Value
      End Set
    End Property

    Public Property TOBS() As String
      Get
        Return _TOBS
      End Get
      Set(ByVal Value As String)
        _TOBS = Value
      End Set
    End Property

    Public Property TALPOL() As String
      Get
        Return _TALPOL
      End Get
      Set(ByVal Value As String)
        _TALPOL = Value
      End Set
    End Property

    Public Property TALPAN() As String
      Get
        Return _TALPAN
      End Get
      Set(ByVal Value As String)
        _TALPAN = Value
      End Set
    End Property

    Public Property TALBOT() As String
      Get
        Return _TALBOT
      End Get
      Set(ByVal Value As String)
        _TALBOT = Value
      End Set
    End Property

    Public Property CUSCRT() As String
      Get
        Return _CUSCRT
      End Get
      Set(ByVal Value As String)
        _CUSCRT = Value
      End Set
    End Property

    Public Property FCHCRT() As Double
      Get
        Return _FCHCRT
      End Get
      Set(ByVal Value As Double)
        _FCHCRT = Value
      End Set
    End Property

    Public Property HRACRT() As Double
      Get
        Return _HRACRT
      End Get
      Set(ByVal Value As Double)
        _HRACRT = Value
      End Set
    End Property

    Public Property NTRMCR() As String
      Get
        Return _NTRMCR
      End Get
      Set(ByVal Value As String)
        _NTRMCR = Value
      End Set
    End Property

    Public Property CULUSA() As String
      Get
        Return _CULUSA
      End Get
      Set(ByVal Value As String)
        _CULUSA = Value
      End Set
    End Property

    Public Property FULTAC() As Double
      Get
        Return _FULTAC
      End Get
      Set(ByVal Value As Double)
        _FULTAC = Value
      End Set
    End Property

    Public Property HULTAC() As Double
      Get
        Return _HULTAC
      End Get
      Set(ByVal Value As Double)
        _HULTAC = Value
      End Set
    End Property

    Public Property NTRMNL() As String
      Get
        Return _NTRMNL
      End Get
      Set(ByVal Value As String)
        _NTRMNL = Value
      End Set
    End Property

    Public Property TCATLI() As String
      Get
        Return _TCATLI
      End Get
      Set(ByVal value As String)
        _TCATLI = value
      End Set
    End Property

    Public Property CCATLI() As String
      Get
        Return _CCATLI
      End Get
      Set(ByVal value As String)
        _CCATLI = value
      End Set
    End Property

    Public Property SINDRC() As String
      Get
        Return _SINDRC
      End Get
      Set(ByVal value As String)
        _SINDRC = value
      End Set
    End Property

    Public Property NOMBRECOMPLETO() As String
      Get
        Return _NOMBRECOMPLETO
      End Get
      Set(ByVal value As String)
        _NOMBRECOMPLETO = value
      End Set
    End Property

  End Class

End Namespace

