Public Class AVC

  Private _NCTAVC As Double = 0
  Private _FINAVC As String
  Private _COBRR As Double = 0
  Private _NOPRCN As Double = 0
  Private _CTPMDT As Double = 0
  Private _CLCLOR As Double = 0
  Private _CLCLDS As Double = 0
  Private _IRTAVC As Double = 0
  Private _IARAVC As Double = 0
  Private _IORTAV As Double = 0
  Private _NSLCEN As Double = 0
  Private _CCNTCS As Double = 0
  Private _SVJEVC As String = ""
  Private _SESAVC As String = ""
  Private _SEMSRC As String = ""
  Private _NCAVCO As Double = 0
  Private _FCHCRT As Double = 0
  Private _HRACRT As Double = 0
  Private _USRCRT As String = ""
  Private _FCHLQD As String = "0"
  Private _HRALQD As Double = 0
  Private _USRLQD As String = ""
  Private _FCHANL As Double = 0
  Private _HRAANL As Double = 0
  Private _USRANL As String = ""
  Private _FULTAC As Double = 0
  Private _HULTAC As Double = 0
  Private _CULUSA As String = ""
  Private _NTRMNL As String = ""
  Private _NPLCUN As String = ""
  Private _CBRCNT As String = ""
  Private _SFLSPE As String = ""
  Private _NDIATR As Double = 0
  Private _NFCDIA As Double = 0
  Private _STPAVC As Double = 0
  Private _NORSRT As Double = 0
  Private _NCRRSR As Double = 0
  Private _NCSOTR As Double = 0
  Private _NRFSAP As Double = 0
  Private _FSTTRS As String = ""
  Private _TIPOCON As Double = 0
  Private _TNMBOB As String = ""
  Private _DESTINO As String = ""
  Private _ORIGEN As String = ""
  Private _RUTA As String = ""
  Private _NORINS As Double = 0
  Private _CCLNT As Double = 0
  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CPLNDV As Integer
  Private _NCSLPE As Double = 0
  Private _RETORNO As Double
  Private _SCATEG As String
  Private _TCATEG As String
  Private _NGUIRM As Double = 0
  Private _QDSTKM As Double = 0

  Public Property NGUIRM() As Double
    Get
      Return _NGUIRM
    End Get
    Set(ByVal value As Double)
      _NGUIRM = value
    End Set
  End Property

  Public Property QDSTKM() As Double
    Get
      Return _QDSTKM
    End Get
    Set(ByVal value As Double)
      _QDSTKM = value
    End Set
  End Property

  Public Property SCATEG() As String
    Get
      Return _SCATEG
    End Get
    Set(ByVal value As String)
      _SCATEG = value
    End Set
  End Property

  Public Property TCATEG() As String
    Get
      Return _TCATEG
    End Get
    Set(ByVal value As String)
      _TCATEG = value
    End Set
  End Property

  Public Property RETORNO() As Double
    Get
      Return _RETORNO
    End Get
    Set(ByVal value As Double)
      _RETORNO = value
    End Set
  End Property

  Public Property NCSLPE() As Double
    Get
      Return _NCSLPE
    End Get
    Set(ByVal value As Double)
      _NCSLPE = value
    End Set
  End Property

  Public Property CCLNT() As Double
    Get
      Return _CCLNT
    End Get
    Set(ByVal value As Double)
      _CCLNT = value
    End Set
  End Property

  Public Property NORINS() As Double
    Get
      Return _NORINS
    End Get
    Set(ByVal value As Double)
      _NORINS = value
    End Set
  End Property


  Private _TTPMDT As String
  Public Property TTPMDT() As String
    Get
      Return _TTPMDT
    End Get
    Set(ByVal value As String)
      _TTPMDT = value
    End Set
  End Property

  Public Property RUTA() As String
    Get
      Return _RUTA
    End Get
    Set(ByVal value As String)
      _RUTA = value
    End Set
  End Property



  Public Property DESTIN() As String
    Get
      Return _DESTINO
    End Get
    Set(ByVal value As String)
      _DESTINO = value
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


  Public Property TNMBOB() As String
    Get
      Return _TNMBOB
    End Get
    Set(ByVal value As String)
      _TNMBOB = value
    End Set
  End Property


  Public Property TIPOCON() As Double
    Get
      Return _TIPOCON
    End Get
    Set(ByVal value As Double)
      _TIPOCON = value
    End Set
  End Property


  Public Property NCRRSR() As Double
    Get
      Return _NCRRSR
    End Get
    Set(ByVal Value As Double)
      _NCRRSR = Value
    End Set
  End Property

  Public Property NCTAVC() As Double
    Get
      Return _NCTAVC
    End Get
    Set(ByVal Value As Double)
      _NCTAVC = Value
    End Set
  End Property

  Public Property FINAVC() As String
    Get
      Return _FINAVC
    End Get
    Set(ByVal Value As String)
      _FINAVC = Value
    End Set
  End Property

  Public Property COBRR() As Double
    Get
      Return _COBRR
    End Get
    Set(ByVal Value As Double)
      _COBRR = Value
    End Set
  End Property

  Public Property NOPRCN() As Double
    Get
      Return _NOPRCN
    End Get
    Set(ByVal Value As Double)
      _NOPRCN = Value
    End Set
  End Property

  Public Property CTPMDT() As Double
    Get
      Return _CTPMDT
    End Get
    Set(ByVal Value As Double)
      _CTPMDT = Value
    End Set
  End Property

  Public Property CLCLOR() As Double
    Get
      Return _CLCLOR
    End Get
    Set(ByVal Value As Double)
      _CLCLOR = Value
    End Set
  End Property

  Public Property CLCLDS() As Double
    Get
      Return _CLCLDS
    End Get
    Set(ByVal Value As Double)
      _CLCLDS = Value
    End Set
  End Property

  Public Property IRTAVC() As Double
    Get
      Return _IRTAVC
    End Get
    Set(ByVal Value As Double)
      _IRTAVC = Value
    End Set
  End Property

  Public Property IARAVC() As Double
    Get
      Return _IARAVC
    End Get
    Set(ByVal Value As Double)
      _IARAVC = Value
    End Set
  End Property

  Public Property IORTAV() As Double
    Get
      Return _IORTAV
    End Get
    Set(ByVal Value As Double)
      _IORTAV = Value
    End Set
  End Property

  Public Property NSLCEN() As Double
    Get
      Return _NSLCEN
    End Get
    Set(ByVal Value As Double)
      _NSLCEN = Value
    End Set
  End Property

  Public Property CCNTCS() As Double
    Get
      Return _CCNTCS
    End Get
    Set(ByVal Value As Double)
      _CCNTCS = Value
    End Set
  End Property

  Public Property SVJEVC() As String
    Get
      Return _SVJEVC
    End Get
    Set(ByVal Value As String)
      _SVJEVC = Value
    End Set
  End Property

  Public Property SESAVC() As String
    Get
      Return _SESAVC
    End Get
    Set(ByVal Value As String)
      _SESAVC = Value
    End Set
  End Property

  Public Property SEMSRC() As String
    Get
      Return _SEMSRC
    End Get
    Set(ByVal Value As String)
      _SEMSRC = Value
    End Set
  End Property

  Public Property NCAVCO() As Double
    Get
      Return _NCAVCO
    End Get
    Set(ByVal Value As Double)
      _NCAVCO = Value
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

  Public Property USRCRT() As String
    Get
      Return _USRCRT
    End Get
    Set(ByVal Value As String)
      _USRCRT = Value
    End Set
  End Property

  Public Property FCHLQD() As String
    Get
      Return _FCHLQD
    End Get
    Set(ByVal Value As String)
      _FCHLQD = Value
    End Set
  End Property

  Public Property HRALQD() As Double
    Get
      Return _HRALQD
    End Get
    Set(ByVal Value As Double)
      _HRALQD = Value
    End Set
  End Property

  Public Property USRLQD() As String
    Get
      Return _USRLQD
    End Get
    Set(ByVal Value As String)
      _USRLQD = Value
    End Set
  End Property

  Public Property FCHANL() As Double
    Get
      Return _FCHANL
    End Get
    Set(ByVal Value As Double)
      _FCHANL = Value
    End Set
  End Property

  Public Property HRAANL() As Double
    Get
      Return _HRAANL
    End Get
    Set(ByVal Value As Double)
      _HRAANL = Value
    End Set
  End Property

  Public Property USRANL() As String
    Get
      Return _USRANL
    End Get
    Set(ByVal Value As String)
      _USRANL = Value
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

  Public Property NPLCUN() As String
    Get
      Return _NPLCUN
    End Get
    Set(ByVal Value As String)
      _NPLCUN = Value
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

  Public Property SFLSPE() As String
    Get
      Return _SFLSPE
    End Get
    Set(ByVal Value As String)
      _SFLSPE = Value
    End Set
  End Property

  Public Property NDIATR() As Double
    Get
      Return _NDIATR
    End Get
    Set(ByVal Value As Double)
      _NDIATR = Value
    End Set
  End Property

  Public Property NFCDIA() As Double
    Get
      Return _NFCDIA
    End Get
    Set(ByVal Value As Double)
      _NFCDIA = Value
    End Set
  End Property

  Public Property STPAVC() As Double
    Get
      Return _STPAVC
    End Get
    Set(ByVal Value As Double)
      _STPAVC = Value
    End Set
  End Property

  Public Property NORSRT() As Double
    Get
      Return _NORSRT
    End Get
    Set(ByVal Value As Double)
      _NORSRT = Value
    End Set
  End Property

  Public Property NCSOTR() As Double
    Get
      Return _NCSOTR
    End Get
    Set(ByVal Value As Double)
      _NCSOTR = Value
    End Set
  End Property
  Public Property NRFSAP() As Double
    Get
      Return _NRFSAP
    End Get
    Set(ByVal Value As Double)
      _NRFSAP = Value
    End Set
  End Property

  Public Property FSTTRS() As String
    Get
      Return _FSTTRS
    End Get
    Set(ByVal Value As String)
      _FSTTRS = Value
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

End Class
