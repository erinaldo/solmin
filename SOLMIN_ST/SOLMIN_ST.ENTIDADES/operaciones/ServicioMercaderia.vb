
Public Class ServicioMercaderia

  Private _NCTZCN As Int64 = 0
  Private _NCRRCT As Integer = 0
  Private _NCRRSR As Integer = 0
  Private _CSRCTZ As Integer = 0
  Private _CMRCDR As Integer = 0
  Private _TOBSSR As String = ""
  Private _CLCLOR As Integer = 0
  Private _CLCLDS As Integer = 0
  Private _ITRSRT As Double = 0
  Private _CMNTRN As Integer = 0
  Private _QIMFCD As Double = 0
  Private _QIMFCS As Double = 0
  Private _CMNLQT As Integer = 0
  Private _ILSFTR As Double = 0
  Private _ILCFTR As Double = 0
  Private _ILQFMX As Double = 0
  Private _ILQSMT As Double = 0
  Private _FULTAC As Integer = 0
  Private _HULTAC As Integer = 0
  Private _CULUSA As String = ""
  Private _NTRMNL As String = ""
  Private _CUSCRT As String = ""
  Private _FCHCRT As Integer = 0
  Private _HRACRT As Integer = 0
  Private _NTRMCR As String = ""
  Private _CUNSRA As String = ""
  Private _QDSTVR As Double = 0
  Private _SFCRTV As String = ""
  Private _SSRVCB As String = ""
  Private _SSRVPG As String = ""
  Private _SSRVFE As String = ""
  Private _CSTNDT As Double = 0
  Private _CCMPN As String = ""
    Private _CDVSN As String = ""

    Private _CUBORI As String = ""
    Public Property CUBORI() As String
        Get
            Return _CUBORI
        End Get
        Set(ByVal value As String)
            _CUBORI = value
        End Set
    End Property

    Private _UBIGEO_O As String = ""
    Public Property UBIGEO_O() As String
        Get
            Return _UBIGEO_O
        End Get
        Set(ByVal value As String)
            _UBIGEO_O = value
        End Set
    End Property

    Private _CUBDES As String = ""
    Public Property CUBDES() As String
        Get
            Return _CUBDES
        End Get
        Set(ByVal value As String)
            _CUBDES = value
        End Set
    End Property

    Private _UBIGEO_D As String = ""
    Public Property UBIGEO_D() As String
        Get
            Return _UBIGEO_D
        End Get
        Set(ByVal value As String)
            _UBIGEO_D = value
        End Set
    End Property


    Private _MONEDA_PAGAR As String = ""

    Public Property MONEDA_PAGAR() As String
        Get
            Return _MONEDA_PAGAR
        End Get
        Set(ByVal value As String)
            _MONEDA_PAGAR = value
        End Set
    End Property

    Private _MONEDA_COBRAR As String = ""

    Public Property MONEDA_COBRAR() As String
        Get
            Return _MONEDA_COBRAR
        End Get
        Set(ByVal value As String)
            _MONEDA_COBRAR = value
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

  Public Property CDVSN() As String
    Get
      Return _CDVSN
    End Get
    Set(ByVal value As String)
      _CDVSN = value
    End Set
  End Property

  Public Property NCTZCN() As Int64
    Get
      Return _NCTZCN
    End Get
    Set(ByVal Value As Int64)
      _NCTZCN = Value
    End Set
  End Property

  Public Property NCRRCT() As Integer
    Get
      Return _NCRRCT
    End Get
    Set(ByVal Value As Integer)
      _NCRRCT = Value
    End Set
  End Property

  Public Property NCRRSR() As Integer
    Get
      Return _NCRRSR
    End Get
    Set(ByVal Value As Integer)
      _NCRRSR = Value
    End Set
  End Property

  Public Property CSRCTZ() As Integer
    Get
      Return _CSRCTZ
    End Get
    Set(ByVal Value As Integer)
      _CSRCTZ = Value
    End Set
  End Property

  Public Property CMRCDR() As Integer
    Get
      Return _CMRCDR
    End Get
    Set(ByVal Value As Integer)
      _CMRCDR = Value
    End Set
  End Property

  Public Property TOBSSR() As String
    Get
      Return _TOBSSR
    End Get
    Set(ByVal Value As String)
      _TOBSSR = Value
    End Set
  End Property

  Public Property CLCLOR() As Integer
    Get
      Return _CLCLOR
    End Get
    Set(ByVal Value As Integer)
      _CLCLOR = Value
    End Set
  End Property

  Public Property CLCLDS() As Integer
    Get
      Return _CLCLDS
    End Get
    Set(ByVal Value As Integer)
      _CLCLDS = Value
    End Set
  End Property

  Public Property ITRSRT() As Double
    Get
      Return _ITRSRT
    End Get
    Set(ByVal Value As Double)
      _ITRSRT = Value
    End Set
  End Property

  Public Property CMNTRN() As Integer
    Get
      Return _CMNTRN
    End Get
    Set(ByVal Value As Integer)
      _CMNTRN = Value
    End Set
  End Property

  Public Property QIMFCD() As Double
    Get
      Return _QIMFCD
    End Get
    Set(ByVal Value As Double)
      _QIMFCD = Value
    End Set
  End Property

  Public Property QIMFCS() As Double
    Get
      Return _QIMFCS
    End Get
    Set(ByVal Value As Double)
      _QIMFCS = Value
    End Set
  End Property

  Public Property CMNLQT() As Integer
    Get
      Return _CMNLQT
    End Get
    Set(ByVal Value As Integer)
      _CMNLQT = Value
    End Set
  End Property

  Public Property ILSFTR() As Double
    Get
      Return _ILSFTR
    End Get
    Set(ByVal Value As Double)
      _ILSFTR = Value
    End Set
  End Property

  Public Property ILCFTR() As Double
    Get
      Return _ILCFTR
    End Get
    Set(ByVal Value As Double)
      _ILCFTR = Value
    End Set
  End Property

  Public Property ILQFMX() As Double
    Get
      Return _ILQFMX
    End Get
    Set(ByVal Value As Double)
      _ILQFMX = Value
    End Set
  End Property

  Public Property ILQSMT() As Double
    Get
      Return _ILQSMT
    End Get
    Set(ByVal Value As Double)
      _ILQSMT = Value
    End Set
  End Property

  Public Property FULTAC() As Integer
    Get
      Return _FULTAC
    End Get
    Set(ByVal Value As Integer)
      _FULTAC = Value
    End Set
  End Property

  Public Property HULTAC() As Integer
    Get
      Return _HULTAC
    End Get
    Set(ByVal Value As Integer)
      _HULTAC = Value
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

  Public Property NTRMNL() As String
    Get
      Return _NTRMNL
    End Get
    Set(ByVal Value As String)
      _NTRMNL = Value
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

  Public Property FCHCRT() As Integer
    Get
      Return _FCHCRT
    End Get
    Set(ByVal Value As Integer)
      _FCHCRT = Value
    End Set
  End Property

  Public Property HRACRT() As Integer
    Get
      Return _HRACRT
    End Get
    Set(ByVal Value As Integer)
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

  Public Property CUNSRA() As String
    Get
      Return _CUNSRA
    End Get
    Set(ByVal Value As String)
      _CUNSRA = Value
    End Set
  End Property

  Public Property QDSTVR() As Double
    Get
      Return _QDSTVR
    End Get
    Set(ByVal Value As Double)
      _QDSTVR = Value
    End Set
  End Property

  Public Property SFCRTV() As String
    Get
      Return _SFCRTV
    End Get
    Set(ByVal Value As String)
      _SFCRTV = Value
    End Set
  End Property

  Public Property SSRVCB() As String
    Get
      Return _SSRVCB
    End Get
    Set(ByVal Value As String)
      _SSRVCB = Value
    End Set
  End Property

  Public Property SSRVPG() As String
    Get
      Return _SSRVPG
    End Get
    Set(ByVal Value As String)
      _SSRVPG = Value
    End Set
  End Property

  Public Property SSRVFE() As String
    Get
      Return _SSRVFE
    End Get
    Set(ByVal Value As String)
      _SSRVFE = Value
    End Set
  End Property

  Public Property CSTNDT() As Double
    Get
      Return _CSTNDT
    End Get
    Set(ByVal Value As Double)
      _CSTNDT = Value
    End Set
  End Property


  Private _SERVICIO As String
  Public Property SERVICIO() As String
    Get
      Return _SERVICIO
    End Get
    Set(ByVal value As String)
      _SERVICIO = value
    End Set
  End Property


  Private _ORIGEN As String
  Public Property ORIGEN() As String
    Get
      Return _ORIGEN
    End Get
    Set(ByVal value As String)
      _ORIGEN = value
    End Set
  End Property


  Private _DESTINO As String
  Public Property DESTINO() As String
    Get
      Return _DESTINO
    End Get
    Set(ByVal value As String)
      _DESTINO = value
    End Set
  End Property


  Private _MONEDA As String
  Public Property MONEDA() As String
    Get
      Return _MONEDA
    End Get
    Set(ByVal value As String)
      _MONEDA = value
    End Set
  End Property




End Class
