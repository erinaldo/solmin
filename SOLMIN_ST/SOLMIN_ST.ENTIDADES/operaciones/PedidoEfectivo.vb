Public Class PedidoEfectivo

  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CZNFCC As Double = 0
  Private _CPLNDV As Double = 0
  Private _TPSLPE As String = ""
  Private _NMSLPE As Double = 0
  Private _FCSLPE As String = ""
  Private _FESLPE As String = ""
  Private _CMSLPE As Double = 0
  Private _ISLPES As Double = 0
  Private _IMTPOC As String = ""
  Private _CODDES As Double = 0
  Private _MOTIVO As String = ""
  Private _NORDSR As Double = 0
  Private _NCSLPE As Double = 0
  Private _FCJSPE As Double = 0
  Private _SSLPEL As Double = 0
  Private _NPLCUN As String = ""
  Private _NMRLQO As Double = 0
  Private _NMLQPR As Double = 0
  Private _SCNTR As String = ""
  Private _SESTRG As String = ""
  Private _FULTAC As String = "0"
  Private _HULTAC As String = "0"
  Private _CULUSA As String = ""
  Private _NTRMNL As String = ""
  Private _FCUSPV As String = ""
  Private _HRUSPV As String = ""
  Private _USRSPV As String = ""
  Private _CDGSVR As String = ""
  Private _IPEIRS As Double = 0
  Private _IPEIRD As Double = 0
  Private _CDGGSV As Double = 0
  Private _FCUOPR As Double = 0
  Private _HRUOPR As Double = 0
  Private _USROPR As String = ""
  Private _FCUADM As Double = 0
  Private _HRUADM As Double = 0
  Private _USRADM As String = ""
  Private _DATCRT As String = "0"
  Private _HRACRT As String = "0"
  Private _USRCRT As String = ""
  Private _MTVGRO As String = ""
  Private _ISLPED As Double = 0
  Private _NRFSAP As Double = 0
  Private _FSTTRS As String = ""
  Private _NCSOTR As Double = 0
  Private _NCRRSR As Double = 0
  Private _TMNDA As String = ""
  Private _TNMBOB As String = ""
  Private _FECINI As Double = 0
  Private _FECFIN As Double = 0
  Private _ESTADO As String = ""
  Private _NORINS As Double = 0
  Private _NOPRCN As Double = 0
  Private _COBRR As String = ""
  Private _ICTMYS As String = ""

  Public Property COBRR() As String
    Get
      Return _COBRR
    End Get
    Set(ByVal value As String)
      _COBRR = value
    End Set
  End Property

  Public Property NOPRCN() As Double
    Get
      Return _NOPRCN
    End Get
    Set(ByVal value As Double)
      _NOPRCN = value
    End Set
  End Property


  Private _CBRCNT As String
  Public Property CBRCNT() As String
    Get
      Return _CBRCNT
    End Get
    Set(ByVal value As String)
      _CBRCNT = value
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

  Public Property CZNFCC() As Double
    Get
      Return _CZNFCC
    End Get
    Set(ByVal Value As Double)
      _CZNFCC = Value
    End Set
  End Property

  Public Property CPLNDV() As Double
    Get
      Return _CPLNDV
    End Get
    Set(ByVal Value As Double)
      _CPLNDV = Value
    End Set
  End Property

  Public Property TPSLPE() As String
    Get
      Return _TPSLPE
    End Get
    Set(ByVal Value As String)
      _TPSLPE = Value
    End Set
  End Property

  Public Property NMSLPE() As Double
    Get
      Return _NMSLPE
    End Get
    Set(ByVal Value As Double)
      _NMSLPE = Value
    End Set
  End Property

  Public Property FCSLPE() As String
    Get
      Return _FCSLPE
    End Get
    Set(ByVal Value As String)
      _FCSLPE = Value
    End Set
  End Property

  Public Property FESLPE() As String
    Get
      Return _FESLPE
    End Get
    Set(ByVal Value As String)
      _FESLPE = Value
    End Set
  End Property

  Public Property CMSLPE() As Double
    Get
      Return _CMSLPE
    End Get
    Set(ByVal Value As Double)
      _CMSLPE = Value
    End Set
  End Property

  Public Property ISLPES() As Double
    Get
      Return _ISLPES
    End Get
    Set(ByVal Value As Double)
      _ISLPES = Value
    End Set
  End Property

  Public Property IMTPOC() As String
    Get
      Return _IMTPOC
    End Get
    Set(ByVal Value As String)
      _IMTPOC = Value
    End Set
  End Property

  Public Property CODDES() As Double
    Get
      Return _CODDES
    End Get
    Set(ByVal Value As Double)
      _CODDES = Value
    End Set
  End Property

  Public Property MOTIVO() As String
    Get
      Return _MOTIVO
    End Get
    Set(ByVal Value As String)
      _MOTIVO = Value
    End Set
  End Property

  Public Property NORDSR() As Double
    Get
      Return _NORDSR
    End Get
    Set(ByVal Value As Double)
      _NORDSR = Value
    End Set
  End Property

  Public Property NCSLPE() As Double
    Get
      Return _NCSLPE
    End Get
    Set(ByVal Value As Double)
      _NCSLPE = Value
    End Set
  End Property

  Public Property FCJSPE() As Double
    Get
      Return _FCJSPE
    End Get
    Set(ByVal Value As Double)
      _FCJSPE = Value
    End Set
  End Property

  Public Property SSLPEL() As Double
    Get
      Return _SSLPEL
    End Get
    Set(ByVal Value As Double)
      _SSLPEL = Value
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

  Public Property NMRLQO() As Double
    Get
      Return _NMRLQO
    End Get
    Set(ByVal Value As Double)
      _NMRLQO = Value
    End Set
  End Property

  Public Property NMLQPR() As Double
    Get
      Return _NMLQPR
    End Get
    Set(ByVal Value As Double)
      _NMLQPR = Value
    End Set
  End Property

  Public Property SCNTR() As String
    Get
      Return _SCNTR
    End Get
    Set(ByVal Value As String)
      _SCNTR = Value
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

  Public Property FULTAC() As String
    Get
      Return _FULTAC
    End Get
    Set(ByVal Value As String)
      _FULTAC = Value
    End Set
  End Property

  Public Property HULTAC() As String
    Get
      Return _HULTAC
    End Get
    Set(ByVal Value As String)
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

  Public Property FCUSPV() As String
    Get
      Return _FCUSPV
    End Get
    Set(ByVal Value As String)
      _FCUSPV = Value
    End Set
  End Property

  Public Property HRUSPV() As String
    Get
      Return _HRUSPV
    End Get
    Set(ByVal Value As String)
      _HRUSPV = Value
    End Set
  End Property

  Public Property USRSPV() As String
    Get
      Return _USRSPV
    End Get
    Set(ByVal Value As String)
      _USRSPV = Value
    End Set
  End Property

  Public Property CDGSVR() As String
    Get
      Return _CDGSVR
    End Get
    Set(ByVal Value As String)
      _CDGSVR = Value
    End Set
  End Property

  Public Property IPEIRS() As Double
    Get
      Return _IPEIRS
    End Get
    Set(ByVal Value As Double)
      _IPEIRS = Value
    End Set
  End Property

  Public Property IPEIRD() As Double
    Get
      Return _IPEIRD
    End Get
    Set(ByVal Value As Double)
      _IPEIRD = Value
    End Set
  End Property

  Public Property CDGGSV() As Double
    Get
      Return _CDGGSV
    End Get
    Set(ByVal Value As Double)
      _CDGGSV = Value
    End Set
  End Property

  Public Property FCUOPR() As Double
    Get
      Return _FCUOPR
    End Get
    Set(ByVal Value As Double)
      _FCUOPR = Value
    End Set
  End Property

  Public Property HRUOPR() As Double
    Get
      Return _HRUOPR
    End Get
    Set(ByVal Value As Double)
      _HRUOPR = Value
    End Set
  End Property

  Public Property USROPR() As String
    Get
      Return _USROPR
    End Get
    Set(ByVal Value As String)
      _USROPR = Value
    End Set
  End Property

  Public Property FCUADM() As Double
    Get
      Return _FCUADM
    End Get
    Set(ByVal Value As Double)
      _FCUADM = Value
    End Set
  End Property

  Public Property HRUADM() As Double
    Get
      Return _HRUADM
    End Get
    Set(ByVal Value As Double)
      _HRUADM = Value
    End Set
  End Property

  Public Property USRADM() As String
    Get
      Return _USRADM
    End Get
    Set(ByVal Value As String)
      _USRADM = Value
    End Set
  End Property

  Public Property DATCRT() As String
    Get
      Return _DATCRT
    End Get
    Set(ByVal Value As String)
      _DATCRT = Value
    End Set
  End Property

  Public Property HRACRT() As String
    Get
      Return _HRACRT
    End Get
    Set(ByVal Value As String)
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

  Public Property MTVGRO() As String
    Get
      Return _MTVGRO
    End Get
    Set(ByVal Value As String)
      _MTVGRO = Value
    End Set
  End Property

  Public Property ISLPED() As Double
    Get
      Return _ISLPED
    End Get
    Set(ByVal Value As Double)
      _ISLPED = Value
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

  Public Property NCSOTR() As Double
    Get
      Return _NCSOTR
    End Get
    Set(ByVal Value As Double)
      _NCSOTR = Value
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

  Public Property TMNDA() As String
    Get
      Return _TMNDA
    End Get
    Set(ByVal Value As String)
      _TMNDA = Value
    End Set
  End Property

  Public Property TNMBOB() As String
    Get
      Return _TNMBOB
    End Get
    Set(ByVal Value As String)
      _TNMBOB = Value
    End Set
  End Property

  Public Property FECINI() As Double
    Get
      Return _FECINI
    End Get
    Set(ByVal Value As Double)
      _FECINI = Value
    End Set
  End Property

  Public Property FECFIN() As Double
    Get
      Return _FECFIN
    End Get
    Set(ByVal Value As Double)
      _FECFIN = Value
    End Set
  End Property

  Public Property ESTADO() As String
    Get
      Return _ESTADO
    End Get
    Set(ByVal Value As String)
      _ESTADO = Value
    End Set
  End Property

  Public Property ICTMYS() As String
    Get
      Return _ICTMYS
    End Get
    Set(ByVal Value As String)
      _ICTMYS = Value
    End Set
  End Property

End Class