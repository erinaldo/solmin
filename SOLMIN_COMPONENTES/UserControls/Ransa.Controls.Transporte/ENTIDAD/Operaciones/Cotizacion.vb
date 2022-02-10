Public Class Cotizacion

  Private _NCTZCN As String
  Private _CCLNT As String
  Private _CMNDA As Integer
  Private _FCTZCN As String
  Private _FVGCTZ As String
  Private _NCNTRT As String = ""
  Private _SESTCT As String = ""
  Private _TCNCLC As String = ""
  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CPLNDV As Integer
  Private _SCTZTR As String = ""
  Private _CMTVRC As Integer
  Private _FULTAC As Integer
  Private _HULTAC As Integer
  Private _CULUSA As String = ""
  Private _NTRMNL As String = ""
  Private _CUSCRT As String = ""
  Private _FCHCRT As Integer
  Private _HRACRT As Integer
  Private _NTRMCR As String = ""
  Private _TFRMPG As String = ""
  Private _TPRLUN As String = ""
  Private _TDRGDA As String = ""
  Private _TCARGO As String = ""
  Private _CPLNFC As Integer
  Private _SFLZNP As String = ""
  Private _SFSANF As Integer
  Private _SCBRMD As String = ""
  Private _CLIENTE As String

  Private _MERCA As String
  Private _RUCCLI As String
  Private _CSRCTZ As String
  Private _CTPOSR As String
  Private _CTPSBS As String
  Private _PMRCDR As String
  Private _DESSCZ As String
  Private _CMNTRN As String
  Private _ITRSRT As Double
  Private _CFRMPG As String
  Private _MONTRN As String
  Private _CMRCDR As String
  Private _QMRCDR As String
  Private _CUNDMD As String
  Private _SERVIC As String
  Private _NORSRT As Integer = 0
  Private _TUNDVH As String = ""
  Private _DESTIN As String
  Private _ORIGEN As String

  Public Property NORSRT() As Integer
    Get
      Return _NORSRT
    End Get
    Set(ByVal Value As Integer)
      _NORSRT = Value
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

  Public Property ORIGEN() As String
    Get
      Return _ORIGEN
    End Get
    Set(ByVal value As String)
      _ORIGEN = value
    End Set
  End Property

  Public Property DESTIN() As String
    Get
      Return _DESTIN
    End Get
    Set(ByVal value As String)
      _DESTIN = value
    End Set
  End Property

  Public Property SERVIC() As String
    Get
      Return _SERVIC
    End Get
    Set(ByVal value As String)
      _SERVIC = value
    End Set
  End Property


  Public Property QMRCDR() As String
    Get
      Return _QMRCDR
    End Get
    Set(ByVal value As String)
      _QMRCDR = value
    End Set
  End Property

  Public Property CUNDMD() As String
    Get
      Return _CUNDMD
    End Get
    Set(ByVal value As String)
      _CUNDMD = value
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

  Public Property MONTRN() As String
    Get
      Return _MONTRN
    End Get
    Set(ByVal value As String)
      _MONTRN = value
    End Set
  End Property

  Public Property CFRMPG() As String
    Get
      Return _CFRMPG
    End Get
    Set(ByVal value As String)
      _CFRMPG = value
    End Set
  End Property

  Public Property ITRSRT() As Double
    Get
      Return _ITRSRT
    End Get
    Set(ByVal value As Double)
      _ITRSRT = value
    End Set
  End Property

  Public Property CMNTRN() As String
    Get
      Return _CMNTRN
    End Get
    Set(ByVal value As String)
      _CMNTRN = value
    End Set
  End Property

  Public Property DESSCZ() As String
    Get
      Return _DESSCZ
    End Get
    Set(ByVal value As String)
      _DESSCZ = value
    End Set
  End Property

  Public Property PMRCDR() As String
    Get
      Return _PMRCDR
    End Get
    Set(ByVal value As String)
      _PMRCDR = value
    End Set
  End Property

  Public Property CTPSBS() As String
    Get
      Return _CTPSBS
    End Get
    Set(ByVal value As String)
      _CTPSBS = value
    End Set
  End Property

  Public Property CTPOSR() As String
    Get
      Return _CTPOSR
    End Get
    Set(ByVal value As String)
      _CTPOSR = value
    End Set
  End Property

  Public Property CSRCTZ() As String
    Get
      Return _CSRCTZ
    End Get
    Set(ByVal value As String)
      _CSRCTZ = value
    End Set
  End Property

  Public Property RUCCLI() As String
    Get
      Return _RUCCLI
    End Get
    Set(ByVal value As String)
      _RUCCLI = value
    End Set
  End Property

  Public Property MERCA() As String
    Get
      Return _MERCA
    End Get
    Set(ByVal value As String)
      _MERCA = value
    End Set
  End Property

  Public Property CLIENTE() As String
    Get
      Return _CLIENTE
    End Get
    Set(ByVal value As String)
      _CLIENTE = value
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



  Public Property NCTZCN() As String
    Get
      Return _NCTZCN
    End Get
    Set(ByVal Value As String)
      _NCTZCN = Value
    End Set
  End Property

  Public Property CCLNT() As String
    Get
      Return _CCLNT
    End Get
    Set(ByVal Value As String)
      _CCLNT = Value
    End Set
  End Property

  Public Property CMNDA() As Integer
    Get
      Return _CMNDA
    End Get
    Set(ByVal Value As Integer)
      _CMNDA = Value
    End Set
  End Property

  Public Property FCTZCN() As String
    Get
      Return _FCTZCN
    End Get
    Set(ByVal Value As String)
      _FCTZCN = Value
    End Set
  End Property

  Public Property FVGCTZ() As String
    Get
      Return _FVGCTZ
    End Get
    Set(ByVal Value As String)
      _FVGCTZ = Value
    End Set
  End Property

  Public Property NCNTRT() As String
    Get
      Return _NCNTRT
    End Get
    Set(ByVal Value As String)
      _NCNTRT = Value
    End Set
  End Property

  Public Property SESTCT() As String
    Get
      Return _SESTCT
    End Get
    Set(ByVal Value As String)
      _SESTCT = Value
    End Set
  End Property

  Public Property TCNCLC() As String
    Get
      Return _TCNCLC
    End Get
    Set(ByVal Value As String)
      _TCNCLC = Value
    End Set
  End Property

  Public Property CCMPN() As String
    Get
      Return _CCMPN
    End Get
    Set(ByVal Value As String)
      _CCMPN = Value
    End Set
  End Property

  Public Property CDVSN() As String
    Get
      Return _CDVSN
    End Get
    Set(ByVal Value As String)
      _CDVSN = Value
    End Set
  End Property

  Public Property CPLNDV() As Integer
    Get
      Return _CPLNDV
    End Get
    Set(ByVal Value As Integer)
      _CPLNDV = Value
    End Set
  End Property

  Public Property SCTZTR() As String
    Get
      Return _SCTZTR
    End Get
    Set(ByVal Value As String)
      _SCTZTR = Value
    End Set
  End Property

  Public Property CMTVRC() As Integer
    Get
      Return _CMTVRC
    End Get
    Set(ByVal Value As Integer)
      _CMTVRC = Value
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

  Public Property TFRMPG() As String
    Get
      Return _TFRMPG
    End Get
    Set(ByVal Value As String)
      _TFRMPG = Value
    End Set
  End Property

  Public Property TPRLUN() As String
    Get
      Return _TPRLUN
    End Get
    Set(ByVal Value As String)
      _TPRLUN = Value
    End Set
  End Property

  Public Property TDRGDA() As String
    Get
      Return _TDRGDA
    End Get
    Set(ByVal Value As String)
      _TDRGDA = Value
    End Set
  End Property

  Public Property TCARGO() As String
    Get
      Return _TCARGO
    End Get
    Set(ByVal Value As String)
      _TCARGO = Value
    End Set
  End Property

  Public Property CPLNFC() As Integer
    Get
      Return _CPLNFC
    End Get
    Set(ByVal Value As Integer)
      _CPLNFC = Value
    End Set
  End Property

  Public Property SFLZNP() As String
    Get
      Return _SFLZNP
    End Get
    Set(ByVal Value As String)
      _SFLZNP = Value
    End Set
  End Property

  Public Property SFSANF() As Integer
    Get
      Return _SFSANF
    End Get
    Set(ByVal Value As Integer)
      _SFSANF = Value
    End Set
  End Property

  Public Property SCBRMD() As String
    Get
      Return _SCBRMD
    End Get
    Set(ByVal Value As String)
      _SCBRMD = Value
    End Set
  End Property
End Class

