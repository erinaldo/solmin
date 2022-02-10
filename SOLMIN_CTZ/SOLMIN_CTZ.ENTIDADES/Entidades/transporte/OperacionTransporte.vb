Namespace Operaciones

  Public Class OperacionTransporte

#Region "Atributo"

    Private _NOPRCN As Double = 0
    Private _CTPOSR As String = ""
    Private _CTPSBS As String = ""
    Private _FINCOP As Double = 0
    Private _FINCOP_S As String = ""
    Private _FTRMOP As Double = 0
    Private _NPLNMT As Double = 0
    Private _SESTOP As String = ""
    Private _SFCTOP As String = ""
    Private _NDCPRF As Double = 0
    Private _FDCPRF As Double = 0
    Private _CTPDCF As Double = 0
    Private _NDCMFC As Double = 0
    Private _NORSRT As Double = 0 ' foreign key de tbl04
    Private _TRFSRC As String = ""
    Private _QMRCDR As Double = 0
    Private _PMRCDR As Double = 0
    Private _VMRCDR As Double = 0
    Private _CMRCDR As Double = 0
    Private _TRFMRC As String = ""
    Private _NINFOP As Double = 0
    Private _CCLNT As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Double = 0
    Private _NVJES As Double = 0
    Private _CVPRCN As String = ""
    Private _SCNTR As String = ""
    Private _CCLNFC As Double = 0
    Private _CPLNCL As Double = 0
    Private _SORGMV As String = ""
    Private _NDCORM As Double = 0
    Private _TNMBRM As String = ""
    Private _TDRCRM As String = ""
    Private _TPDCIR As String = ""
    Private _NRUCRM As Double = 0
    Private _TNMBCN As String = ""
    Private _TDRCNS As String = ""
    Private _TPDCIC As String = ""
    Private _NRUCCN As Double = 0
    Private _SINDPS As String = ""
    Private _CCNCST As Double = 0
    Private _ITPCMT As Double = 0
    Private _NPRLQD As Double = 0
    Private _NPRCRG As Double = 0
    Private _QCNTRC As Double = 0
    Private _QPSORC As Double = 0
    Private _NBKNCN As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _CULUSA As String = ""
    Private _NTRMNL As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _NTRMCR As String = ""

    Private _NGUITR As Double = 0
    Private _FGUITR As Double = 0
    Private _SESTGU As String = ""
    Private _NLQDCN As Double = 0
    Private _CLCLOR As String = ""
    Private _CLCLDS As String = ""
    Private _NGUIRF As Double = 0
    Private _FGUIRF As Double = 0
    Private _CTRSPT As Double = 0
    Private _NPLVHT As String = ""
    Private _CBRCNT As String = ""
    Private _FSLDCM As Double = 0
    Private _FLLGCM As Double = 0
    Private _TCMPCL As String = ""
    Private _COUNT As Double = 0
    Private _TCNTCS As String = ""
    Private _RUTA As String = ""
    Private _TCMPCF As String = ""
    Private _TPLNTA As String = ""
    Private _TCMTPS As String = ""
    Private _TCMSBS As String = ""
    Private _TCMRCD As String = ""
    Private _QKMREC As Double = 0
    Private _IMPOCOS As Double = 0
    Private _IMPOCOD As Double = 0
    Private _TCRVTA As String = ""
    Private _CRGVTA As String = ""
#End Region

#Region "Properties"

    Public Property CRGVTA() As String
      Get
        Return _CRGVTA
      End Get
      Set(ByVal Value As String)
        _CRGVTA = Value
      End Set
    End Property

    Public Property TCRVTA() As String
      Get
        Return _TCRVTA
      End Get
      Set(ByVal Value As String)
        _TCRVTA = Value
      End Set
    End Property

    Public Property RUTA() As String
      Get
        Return _RUTA
      End Get
      Set(ByVal Value As String)
        _RUTA = Value
      End Set
    End Property

    Public Property TCNTCS() As String
      Get
        Return _TCNTCS
      End Get
      Set(ByVal Value As String)
        _TCNTCS = Value
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

    Public Property FINCOP() As Double
      Get
        Return _FINCOP
      End Get
      Set(ByVal Value As Double)
        _FINCOP = Value
      End Set
    End Property

    Public Property FINCOP_S() As String
      Get
        Return _FINCOP_S
      End Get
      Set(ByVal value As String)
        _FINCOP_S = value
      End Set
    End Property

    Public Property FTRMOP() As Double
      Get
        Return _FTRMOP
      End Get
      Set(ByVal Value As Double)
        _FTRMOP = Value
      End Set
    End Property

    Public Property NPLNMT() As Double
      Get
        Return _NPLNMT
      End Get
      Set(ByVal Value As Double)
        _NPLNMT = Value
      End Set
    End Property

    Public Property SESTOP() As String
      Get
        Return _SESTOP
      End Get
      Set(ByVal Value As String)
        _SESTOP = Value
      End Set
    End Property

    Public Property SFCTOP() As String
      Get
        Return _SFCTOP
      End Get
      Set(ByVal Value As String)
        _SFCTOP = Value
      End Set
    End Property

    Public Property NDCPRF() As Double
      Get
        Return _NDCPRF
      End Get
      Set(ByVal Value As Double)
        _NDCPRF = Value
      End Set
    End Property

    Public Property FDCPRF() As Double
      Get
        Return _FDCPRF
      End Get
      Set(ByVal Value As Double)
        _FDCPRF = Value
      End Set
    End Property

    Public Property CTPDCF() As Double
      Get
        Return _CTPDCF
      End Get
      Set(ByVal Value As Double)
        _CTPDCF = Value
      End Set
    End Property

    Public Property NDCMFC() As Double
      Get
        Return _NDCMFC
      End Get
      Set(ByVal Value As Double)
        _NDCMFC = Value
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

    Public Property TRFSRC() As String
      Get
        Return _TRFSRC
      End Get
      Set(ByVal Value As String)
        _TRFSRC = Value
      End Set
    End Property

    Public Property QMRCDR() As Double
      Get
        Return _QMRCDR
      End Get
      Set(ByVal Value As Double)
        _QMRCDR = Value
      End Set
    End Property

    Public Property PMRCDR() As Double
      Get
        Return _PMRCDR
      End Get
      Set(ByVal Value As Double)
        _PMRCDR = Value
      End Set
    End Property

    Public Property VMRCDR() As Double
      Get
        Return _VMRCDR
      End Get
      Set(ByVal Value As Double)
        _VMRCDR = Value
      End Set
    End Property

    Public Property CMRCDR() As Double
      Get
        Return _CMRCDR
      End Get
      Set(ByVal Value As Double)
        _CMRCDR = Value
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

    Public Property NINFOP() As Double
      Get
        Return _NINFOP
      End Get
      Set(ByVal Value As Double)
        _NINFOP = Value
      End Set
    End Property

    Public Property CCLNT() As Double
      Get
        Return _CCLNT
      End Get
      Set(ByVal Value As Double)
        _CCLNT = Value
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

    Public Property CPLNDV() As Double
      Get
        Return _CPLNDV
      End Get
      Set(ByVal Value As Double)
        _CPLNDV = Value
      End Set
    End Property

    Public Property NVJES() As Double
      Get
        Return _NVJES
      End Get
      Set(ByVal Value As Double)
        _NVJES = Value
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

    Public Property SCNTR() As String
      Get
        Return _SCNTR
      End Get
      Set(ByVal Value As String)
        _SCNTR = Value
      End Set
    End Property

    Public Property CCLNFC() As Double
      Get
        Return _CCLNFC
      End Get
      Set(ByVal Value As Double)
        _CCLNFC = Value
      End Set
    End Property

    Public Property CPLNCL() As Double
      Get
        Return _CPLNCL
      End Get
      Set(ByVal Value As Double)
        _CPLNCL = Value
      End Set
    End Property

    Public Property SORGMV() As String
      Get
        Return _SORGMV
      End Get
      Set(ByVal Value As String)
        _SORGMV = Value
      End Set
    End Property

    Public Property NDCORM() As Double
      Get
        Return _NDCORM
      End Get
      Set(ByVal Value As Double)
        _NDCORM = Value
      End Set
    End Property

    Public Property TNMBRM() As String
      Get
        Return _TNMBRM
      End Get
      Set(ByVal Value As String)
        _TNMBRM = Value
      End Set
    End Property

    Public Property TDRCRM() As String
      Get
        Return _TDRCRM
      End Get
      Set(ByVal Value As String)
        _TDRCRM = Value
      End Set
    End Property

    Public Property TPDCIR() As String
      Get
        Return _TPDCIR
      End Get
      Set(ByVal Value As String)
        _TPDCIR = Value
      End Set
    End Property

    Public Property NRUCRM() As Double
      Get
        Return _NRUCRM
      End Get
      Set(ByVal Value As Double)
        _NRUCRM = Value
      End Set
    End Property

    Public Property TNMBCN() As String
      Get
        Return _TNMBCN
      End Get
      Set(ByVal Value As String)
        _TNMBCN = Value
      End Set
    End Property

    Public Property TDRCNS() As String
      Get
        Return _TDRCNS
      End Get
      Set(ByVal Value As String)
        _TDRCNS = Value
      End Set
    End Property

    Public Property TPDCIC() As String
      Get
        Return _TPDCIC
      End Get
      Set(ByVal Value As String)
        _TPDCIC = Value
      End Set
    End Property

    Public Property NRUCCN() As Double
      Get
        Return _NRUCCN
      End Get
      Set(ByVal Value As Double)
        _NRUCCN = Value
      End Set
    End Property

    Public Property SINDPS() As String
      Get
        Return _SINDPS
      End Get
      Set(ByVal Value As String)
        _SINDPS = Value
      End Set
    End Property

    Public Property CCNCST() As Double
      Get
        Return _CCNCST
      End Get
      Set(ByVal Value As Double)
        _CCNCST = Value
      End Set
    End Property

    Public Property ITPCMT() As Double
      Get
        Return _ITPCMT
      End Get
      Set(ByVal Value As Double)
        _ITPCMT = Value
      End Set
    End Property

    Public Property NPRLQD() As Double
      Get
        Return _NPRLQD
      End Get
      Set(ByVal Value As Double)
        _NPRLQD = Value
      End Set
    End Property

    Public Property NPRCRG() As Double
      Get
        Return _NPRCRG
      End Get
      Set(ByVal Value As Double)
        _NPRCRG = Value
      End Set
    End Property

    Public Property QCNTRC() As Double
      Get
        Return _QCNTRC
      End Get
      Set(ByVal Value As Double)
        _QCNTRC = Value
      End Set
    End Property

    Public Property QPSORC() As Double
      Get
        Return _QPSORC
      End Get
      Set(ByVal Value As Double)
        _QPSORC = Value
      End Set
    End Property

    Public Property NBKNCN() As String
      Get
        Return _NBKNCN
      End Get
      Set(ByVal Value As String)
        _NBKNCN = Value
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

    Public Property NGUITR() As Double
      Get
        Return _NGUITR
      End Get
      Set(ByVal Value As Double)
        _NGUITR = Value
      End Set
    End Property

    Public Property FGUITR() As Double
      Get
        Return _FGUITR
      End Get
      Set(ByVal Value As Double)
        _FGUITR = Value
      End Set
    End Property

    Public Property SESTGU() As String
      Get
        Return _SESTGU
      End Get
      Set(ByVal Value As String)
        _SESTGU = Value
      End Set
    End Property

    Public Property NLQDCN() As Double
      Get
        Return _NLQDCN
      End Get
      Set(ByVal Value As Double)
        _NLQDCN = Value
      End Set
    End Property

    Public Property CLCLOR() As String
      Get
        Return _CLCLOR
      End Get
      Set(ByVal Value As String)
        _CLCLOR = Value
      End Set
    End Property

    Public Property CLCLDS() As String
      Get
        Return _CLCLDS
      End Get
      Set(ByVal Value As String)
        _CLCLDS = Value
      End Set
    End Property

    Public Property NGUIRF() As Double
      Get
        Return _NGUIRF
      End Get
      Set(ByVal Value As Double)
        _NGUIRF = Value
      End Set
    End Property

    Public Property FGUIRF() As Double
      Get
        Return _FGUIRF
      End Get
      Set(ByVal Value As Double)
        _FGUIRF = Value
      End Set
    End Property

    Public Property CTRSPT() As Double
      Get
        Return _CTRSPT
      End Get
      Set(ByVal Value As Double)
        _CTRSPT = Value
      End Set
    End Property

    Public Property NPLVHT() As String
      Get
        Return _NPLVHT
      End Get
      Set(ByVal Value As String)
        _NPLVHT = Value
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

    Public Property FSLDCM() As Double
      Get
        Return _FSLDCM
      End Get
      Set(ByVal Value As Double)
        _FSLDCM = Value
      End Set
    End Property

    Public Property FLLGCM() As Double
      Get
        Return _FLLGCM
      End Get
      Set(ByVal Value As Double)
        _FLLGCM = Value
      End Set
    End Property

    Public Property TCMPCL() As String
      Get
        Return _TCMPCL
      End Get
      Set(ByVal Value As String)
        _TCMPCL = Value
      End Set
    End Property

    Public Property COUNT() As Double
      Get
        Return _COUNT
      End Get
      Set(ByVal Value As Double)
        _COUNT = Value
      End Set
    End Property

    Public Property TCMPCF() As String
      Get
        Return _TCMPCF
      End Get
      Set(ByVal Value As String)
        _TCMPCF = Value
      End Set
    End Property

    Public Property TPLNTA() As String
      Get
        Return _TPLNTA
      End Get
      Set(ByVal Value As String)
        _TPLNTA = Value
      End Set
    End Property

    Public Property TCMTPS() As String
      Get
        Return _TCMTPS
      End Get
      Set(ByVal Value As String)
        _TCMTPS = Value
      End Set
    End Property

    Public Property TCMSBS() As String
      Get
        Return _TCMSBS
      End Get
      Set(ByVal Value As String)
        _TCMSBS = Value
      End Set
    End Property

    Public Property TCMRCD() As String
      Get
        Return _TCMRCD
      End Get
      Set(ByVal Value As String)
        _TCMRCD = Value
      End Set
    End Property
    
    Public Property QKMREC() As Double
      Get
        Return _QKMREC
      End Get
      Set(ByVal Value As Double)
        _QKMREC = Value
      End Set
    End Property

    Public Property IMPOCOS() As Double
      Get
        Return _IMPOCOS
      End Get
      Set(ByVal Value As Double)
        _IMPOCOS = Value
      End Set
    End Property

    Public Property IMPOCOD() As Double
      Get
        Return _IMPOCOD
      End Get
      Set(ByVal Value As Double)
        _IMPOCOD = Value
      End Set
    End Property

#End Region

  End Class

End Namespace