
Public Class Detalle_Cotizacion

  Private _NCTZCN As Int64 = 0
  Private _NCRRCT As Integer
  Private _CMRCDR As String
  Private _CUNDMD As String = ""
  Private _CFRMPG As String = ""
  Private _SSGRCT As String = ""
  Private _CCMPSG As Integer
  Private _NPLSGC As Integer
  Private _QPRCS1 As Double
  Private _QMRCDR As Integer
  Private _PMRCDR As String
  Private _VMRCDR As Integer
  Private _LMRCDR As Integer
  Private _TRFMRC As String = ""
  Private _FINCSR As Integer
  Private _STPOMR As String = ""
  Private _FCRGMR As Integer
  Private _NPTSCR As Integer
  Private _NPTSDS As Integer
  Private _FENTMR As Integer
  Private _SCNDTR As String = ""
  Private _TMRCDR As Double
  Private _SRSTRC As String = ""
  Private _NORSRT As Int64 = 0
  Private _CTPOSR As String = ""
  Private _CTPSBS As String = ""
  Private _CCNDRT As Integer
  Private _CVPRCN As String = ""
  Private _NVJES As Integer
  Private _FULTAC As Integer
  Private _HULTAC As Integer
  Private _CULUSA As String = ""
  Private _NTRMNL As String = ""
  Private _CUSCRT As String = ""
  Private _FCHCRT As Integer
  Private _HRACRT As Integer
  Private _NTRMCR As String = ""
  Private _CTPUNV As String = ""
  Private _CFRAPG As String = ""
  Private _MERCAD As String = ""
  Private _UNIMED As String = ""
  Private _FFACTURA As String = ""
  Private _FPAGO As String = ""
  Private _SESTOS As String = ""
  Private _ESTADOOS As String = ""
  Private _SEGURO As String = ""
  Private _TUNDVH As String = ""
  Private _CCMPN As String = ""
  Private _CCNCST As String = ""
    Private _CCNCS1 As String = ""
    Private _MARGEN As Decimal = 0D
    Private _CRGVTA As String = ""
    Public Property MARGEN() As Decimal
        Get
            Return _MARGEN
        End Get
        Set(ByVal value As Decimal)
            _MARGEN = value
        End Set
    End Property

  Public Property CCNCST() As String
    Get
      Return _CCNCST
    End Get
    Set(ByVal value As String)
      _CCNCST = value
    End Set
  End Property

  Public Property CCNCS1() As String
    Get
      Return _CCNCS1
    End Get
    Set(ByVal value As String)
      _CCNCS1 = value
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

  Public Property SEGURO() As String
    Get
      Return _SEGURO
    End Get
    Set(ByVal value As String)
      _SEGURO = value
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

  Public Property CMRCDR() As String
    Get
      Return _CMRCDR
    End Get
    Set(ByVal Value As String)
      _CMRCDR = Value
    End Set
  End Property

  Public Property CUNDMD() As String
    Get
      Return _CUNDMD
    End Get
    Set(ByVal Value As String)
      _CUNDMD = Value
    End Set
  End Property

  Public Property CFRMPG() As String
    Get
      Return _CFRMPG
    End Get
    Set(ByVal Value As String)
      _CFRMPG = Value
    End Set
  End Property

  Public Property SSGRCT() As String
    Get
      Return _SSGRCT
    End Get
    Set(ByVal Value As String)
      _SSGRCT = Value
    End Set
  End Property

  Public Property CCMPSG() As Integer
    Get
      Return _CCMPSG
    End Get
    Set(ByVal Value As Integer)
      _CCMPSG = Value
    End Set
  End Property

  Public Property NPLSGC() As Integer
    Get
      Return _NPLSGC
    End Get
    Set(ByVal Value As Integer)
      _NPLSGC = Value
    End Set
  End Property

  Public Property QPRCS1() As Double
    Get
      Return _QPRCS1
    End Get
    Set(ByVal Value As Double)
      _QPRCS1 = Value
    End Set
  End Property

  Public Property QMRCDR() As Integer
    Get
      Return _QMRCDR
    End Get
    Set(ByVal Value As Integer)
      _QMRCDR = Value
    End Set
  End Property

  Public Property PMRCDR() As String
    Get
      Return _PMRCDR
    End Get
    Set(ByVal Value As String)
      _PMRCDR = Value
    End Set
  End Property

  Public Property VMRCDR() As Integer
    Get
      Return _VMRCDR
    End Get
    Set(ByVal Value As Integer)
      _VMRCDR = Value
    End Set
  End Property

  Public Property LMRCDR() As Integer
    Get
      Return _LMRCDR
    End Get
    Set(ByVal Value As Integer)
      _LMRCDR = Value
    End Set
  End Property

  Public Property TRFMRC() As String
    Get
      Return _TRFMRC
    End Get
    Set(ByVal Value As String)
      _TRFMRC = Value
    End Set
  End Property

  Public Property FINCSR() As Integer
    Get
      Return _FINCSR
    End Get
    Set(ByVal Value As Integer)
      _FINCSR = Value
    End Set
  End Property

  Public Property STPOMR() As String
    Get
      Return _STPOMR
    End Get
    Set(ByVal Value As String)
      _STPOMR = Value
    End Set
  End Property

  Public Property FCRGMR() As Integer
    Get
      Return _FCRGMR
    End Get
    Set(ByVal Value As Integer)
      _FCRGMR = Value
    End Set
  End Property

  Public Property NPTSCR() As Integer
    Get
      Return _NPTSCR
    End Get
    Set(ByVal Value As Integer)
      _NPTSCR = Value
    End Set
  End Property

  Public Property NPTSDS() As Integer
    Get
      Return _NPTSDS
    End Get
    Set(ByVal Value As Integer)
      _NPTSDS = Value
    End Set
  End Property

  Public Property FENTMR() As Integer
    Get
      Return _FENTMR
    End Get
    Set(ByVal Value As Integer)
      _FENTMR = Value
    End Set
  End Property

  Public Property SCNDTR() As String
    Get
      Return _SCNDTR
    End Get
    Set(ByVal Value As String)
      _SCNDTR = Value
    End Set
  End Property

  Public Property TMRCDR() As Double
    Get
      Return _TMRCDR
    End Get
    Set(ByVal Value As Double)
      _TMRCDR = Value
    End Set
  End Property

  Public Property SRSTRC() As String
    Get
      Return _SRSTRC
    End Get
    Set(ByVal Value As String)
      _SRSTRC = Value
    End Set
  End Property

  Public Property NORSRT() As Int64
    Get
      Return _NORSRT
    End Get
    Set(ByVal Value As Int64)
      _NORSRT = Value
    End Set
  End Property

  Public Property CTPOSR() As String
    Get
      Return _CTPOSR
    End Get
    Set(ByVal Value As String)
      _CTPOSR = Value
    End Set
  End Property

  Public Property CTPSBS() As String
    Get
      Return _CTPSBS
    End Get
    Set(ByVal Value As String)
      _CTPSBS = Value
    End Set
  End Property

  Public Property CCNDRT() As Integer
    Get
      Return _CCNDRT
    End Get
    Set(ByVal Value As Integer)
      _CCNDRT = Value
    End Set
  End Property

  Public Property CVPRCN() As String
    Get
      Return _CVPRCN
    End Get
    Set(ByVal Value As String)
      _CVPRCN = Value
    End Set
  End Property

  Public Property NVJES() As Integer
    Get
      Return _NVJES
    End Get
    Set(ByVal Value As Integer)
      _NVJES = Value
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

  Public Property CTPUNV() As String
    Get
      Return _CTPUNV
    End Get
    Set(ByVal Value As String)
      _CTPUNV = Value
    End Set
  End Property

  Public Property CFRAPG() As String
    Get
      Return _CFRAPG
    End Get
    Set(ByVal Value As String)
      _CFRAPG = Value
    End Set
  End Property

  Public Property MERCAD() As String
    Get
      Return _MERCAD
    End Get
    Set(ByVal value As String)
      _MERCAD = value
    End Set
  End Property

  Public Property UNIMED() As String
    Get
      Return _UNIMED
    End Get
    Set(ByVal value As String)
      _UNIMED = value
    End Set
  End Property

  Public Property FFACTURA() As String
    Get
      Return _FFACTURA
    End Get
    Set(ByVal value As String)
      _FFACTURA = value
    End Set
  End Property

  Public Property FPAGO() As String
    Get
      Return _FPAGO
    End Get
    Set(ByVal value As String)
      _FPAGO = value
    End Set
  End Property

  Public Property SESTOS() As String
    Get
      Return _SESTOS
    End Get
    Set(ByVal value As String)
      _SESTOS = value
    End Set
  End Property

  Public Property ESTADOOS() As String
    Get
      Return _ESTADOOS
    End Get
    Set(ByVal value As String)
      _ESTADOOS = value
    End Set
  End Property

  Public Property TUNDVH() As String
    Get
      Return _TUNDVH
    End Get
    Set(ByVal value As String)
      _TUNDVH = value
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

End Class

