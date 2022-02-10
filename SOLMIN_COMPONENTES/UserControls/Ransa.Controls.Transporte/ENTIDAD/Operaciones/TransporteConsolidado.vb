Public Class TransporteConsolidado
#Region "Atributos"
  Private _pCCMPN As String = ""
  Private _pNMVJCS As Int64 = 0
  Private _pFCHVJC As Int64 = 0
  Private _pFCHVJC_S As String = ""
  Private _pFCHINI As Int64 = 0
  Private _pFCHFIN As Int64 = 0
  Private _pCTRSPT As Int64 = 0
  Private _pNPLCUN As String = ""
  Private _pNPLCAC As String = ""
  Private _pCBRCNT As String = ""
  Private _pCLCLOR As Double = 0
  Private _pCLCLDS As Double = 0
  Private _pPMRCMC As Double = 0
  Private _pQPSOBR As Double = 0
  Private _pQVLMOR As Double = 0
  Private _pCMEDTR As Double = 0
  Private _pTOBRCP As String = ""
  Private _pCDVSN As String = ""
  Private _pCPLNDV As Int64 = 0
  Private _pFLGSTS As String = ""
  Private _pSESTRG As String = ""
  Private _pCUSCTR As String = ""
  Private _pFCHCRT As Double = 0
  Private _pHRACRT As Double = 0
  Private _pNTRMCR As String = ""
  Private _pCULUSA As String = ""
  Private _pFULTAC As Double = 0
  Private _pHULTAC As Double = 0
  Private _pNTRMNL As String = ""
  Private _pRuta As String = ""
  Private _pTCMTRT As String = ""
  Private _pCBRCND As String = ""
  Private _pTNMMDT As String = ""
  Private _pNRUCTR As Int64 = 0

  Private _NCSOTR As String = ""
  Private _NCRRSR As Int32 = 0
  Private _NORSRT As String = ""
  Private _FECOST As String = ""
  Private _HRAOTR As String = ""
  Private _CCLNT As String = ""
  Private _CTPOSR As String = ""
  Private _CUNDVH As String = ""
  Private _CMRCDR As String = ""
  Private _TCMRCD As String = ""
  Private _QMRCDR As String = ""
  Private _CUNDMD As String = ""
  Private _CUNDMD_C As String = ""
  Private _QATNDR As String = ""
  Private _QSLCIT As String = ""
  Private _QATNAN As String = ""
  Private _FINCRG As String = ""
  Private _HINCIN As String = ""
  Private _FENTCL As String = ""
  Private _HRAENT As String = ""
  Private _CLCLOR_C As Int32 = 0
  Private _CLCLOR As String = ""
  Private _TDRCOR As String = ""
  Private _CLCLDS_C As Int32 = 0
  Private _CLCLDS As String = ""
  Private _TDRENT As String = ""
  Private _SESSLC As String = ""
  Private _SESTRG As String = ""
  Private _CUSCRT As String = ""
  Private _FCHCRT As String = ""
  Private _HRACRT As String = ""
  Private _NTRMCR As String = ""
  Private _CULUSA As String = ""
  Private _FULTAC As String = ""
  Private _HULTAC As String = ""
  Private _NTRMNL As String = ""
  Private _TCMPCL As String = ""
  Private _TOBS As String = ""
  Private _CLCLOR_CLCLDS As String = "" 'ruta
  Private _CANTOP As Double = 0
  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CPLNDV As Double = 0
  Private _SFCRTV As String = ""
  Private _NMOPMM As Double = 0
  Private _NCRRRT As Double = 0
  Private _NMOPRP As Double = 0
  Private _CMEDTR As Double = 0
  Private _TNMMDT As String = ""
  Private _NPLCUN As String = ""
  Private _CBRCNT As String = ""
  Private _CBRCND As String = ""
  Private _NOPRCN As Double = 0
  Private _NPLNMT As Double = 0
  Private _NORINS As String = ""
  Private _SEGUIMIENTO As String = ""
  Private _NCOREG As Int64 = 0
  Private _NGSGWP As String = ""
  Private _CCTCSC As String = ""
  Private _FE_INI As String = ""
  Private _FE_FIN As String = ""
  Private _NDCMFC As Int64 = 0
  Private _NGUITR As Int64 = 0D
  Private _NGUIRM As Int64 = 0D
  Private _PSCTRMNC As String = ""
  Private _PSNGUIRM As String = ""
  Private _TRFRN As String = ""

  Private _NDCPRF As Int64 = 0D
  Private _NPRLQD As Int64 = 0D
  Private _CTRSPT As Int64 = 0D
  Private _NMVJCS As Int64 = 0

    Private _pPSOVOL As Double = 0
    Private _CTPOVJ As String = ""
    Private _TIPO As Int32 = 0
    Private _SPRSTR As String

#End Region
#Region "Metodos"

    Public Property SPRSTR() As String
        Get
            Return _SPRSTR
        End Get
        Set(ByVal value As String)
            _SPRSTR = value
        End Set
    End Property

  Public Property PSOVOL() As Double
    Get
      Return _pPSOVOL
    End Get
    Set(ByVal value As Double)
      _pPSOVOL = value
    End Set
  End Property

  Public Property NRUCTR() As Int64
    Get
      Return _pNRUCTR
    End Get
    Set(ByVal value As Int64)
      _pNRUCTR = value
    End Set
  End Property
  Public Property Ruta() As String
    Get
      Return _pRuta
    End Get
    Set(ByVal value As String)
      _pRuta = value
    End Set
  End Property
  Public Property TCMTRT() As String
    Get
      Return _pTCMTRT
    End Get
    Set(ByVal value As String)
      _pTCMTRT = value
    End Set
  End Property

  Public Property FCHVJC_S() As String
    Get
      Return _pFCHVJC_S
    End Get
    Set(ByVal value As String)
      _pFCHVJC_S = value
    End Set
  End Property
  Public Property FCHVJC() As Int64
    Get
      Return _pFCHVJC
    End Get
    Set(ByVal value As Int64)
      _pFCHVJC = value
    End Set
  End Property
  Public Property FCHINI() As Int64
    Get
      Return _pFCHINI
    End Get
    Set(ByVal value As Int64)
      _pFCHINI = value
    End Set
  End Property
  Public Property FCHFIN() As Int64
    Get
      Return _pFCHFIN
    End Get
    Set(ByVal value As Int64)
      _pFCHFIN = value
    End Set
  End Property


  Public Property NPLCAC() As String
    Get
      Return _pNPLCAC
    End Get
    Set(ByVal value As String)
      _pNPLCAC = value
    End Set
  End Property


  Public Property PMRCMC() As Double
    Get
      Return _pPMRCMC
    End Get
    Set(ByVal value As Double)
      _pPMRCMC = value
    End Set
  End Property
  Public Property QPSOBR() As Double
    Get
      Return _pQPSOBR
    End Get
    Set(ByVal value As Double)
      _pQPSOBR = value
    End Set
  End Property
  Public Property QVLMOR() As Double
    Get
      Return _pQVLMOR
    End Get
    Set(ByVal value As Double)
      _pQVLMOR = value
    End Set
  End Property

  Public Property TOBRCP() As String
    Get
      Return _pTOBRCP
    End Get
    Set(ByVal value As String)
      _pTOBRCP = value
    End Set
  End Property


  Public Property FLGSTS() As String
    Get
      Return _pFLGSTS
    End Get
    Set(ByVal value As String)
      _pFLGSTS = value
    End Set
  End Property

  Public Property CUSCTR() As String
    Get
      Return _pCUSCTR
    End Get
    Set(ByVal value As String)
      _pCUSCTR = value
    End Set
  End Property


  Public Property NMVJCS() As Int64
    Get
      Return _NMVJCS
    End Get
    Set(ByVal value As Int64)
      _NMVJCS = value
    End Set
  End Property
  Public Property NDCPRF() As Int64
    Get
      Return _NDCPRF
    End Get
    Set(ByVal Value As Int64)
      _NDCPRF = Value
    End Set
  End Property
  Public Property NPRLQD() As Int64
    Get
      Return _NPRLQD
    End Get
    Set(ByVal Value As Int64)
      _NPRLQD = Value
    End Set
  End Property
  Public Property CTRSPT() As Int64
    Get
      Return _CTRSPT
    End Get
    Set(ByVal Value As Int64)
      _CTRSPT = Value
    End Set
  End Property

  Public Property PSCTRMNC() As String
    Get
      Return _PSCTRMNC
    End Get
    Set(ByVal Value As String)
      _PSCTRMNC = Value
    End Set
  End Property
  Public Property PSNGUIRM() As String
    Get
      Return _PSNGUIRM
    End Get
    Set(ByVal Value As String)
      _PSNGUIRM = Value
    End Set
  End Property

  Public Property NGUITR() As Int64
    Get
      Return _NGUITR
    End Get
    Set(ByVal Value As Int64)
      _NGUITR = Value
    End Set
  End Property
  Public Property NGUIRM() As Int64
    Get
      Return _NGUIRM
    End Get
    Set(ByVal Value As Int64)
      _NGUIRM = Value
    End Set
  End Property
  Public Property NDCMFC() As Int64
    Get
      Return _NDCMFC
    End Get
    Set(ByVal Value As Int64)
      _NDCMFC = Value
    End Set
  End Property

  Public Property FE_INI() As Double
    Get
      Return _FE_INI
    End Get
    Set(ByVal Value As Double)
      _FE_INI = Value
    End Set
  End Property

  Public Property FE_FIN() As Double
    Get
      Return _FE_FIN
    End Get
    Set(ByVal Value As Double)
      _FE_FIN = Value
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

  Public Property NPLNMT() As Double
    Get
      Return _NPLNMT
    End Get
    Set(ByVal Value As Double)
      _NPLNMT = Value
    End Set
  End Property


  Public Property NORINS() As String
    Get
      Return _NORINS
    End Get
    Set(ByVal Value As String)
      _NORINS = Value
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

  Public Property CBRCND() As String
    Get
      Return _CBRCND
    End Get
    Set(ByVal Value As String)
      _CBRCND = Value
    End Set
  End Property

  Public Property TNMMDT() As String
    Get
      Return _TNMMDT
    End Get
    Set(ByVal Value As String)
      _TNMMDT = Value
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

  Public Property CANTOP() As Double
    Get
      Return _CANTOP
    End Get
    Set(ByVal value As Double)
      _CANTOP = value
    End Set
  End Property

  Public Property CLCLOR_CLCLDS() As String
    Get
      Return Me._CLCLOR_CLCLDS
    End Get
    Set(ByVal value As String)
      Me._CLCLOR_CLCLDS = value
    End Set
  End Property

  Public Property NORSRT() As String
    Get
      Return Me._NORSRT
    End Get
    Set(ByVal value As String)
      Me._NORSRT = value
    End Set
  End Property

  Public Property TOBS() As String
    Get
      Return _TOBS
    End Get
    Set(ByVal value As String)
      _TOBS = value
    End Set
  End Property

  Public Property NCSOTR() As String
    Get
      Return _NCSOTR
    End Get
    Set(ByVal Value As String)
      _NCSOTR = Value
    End Set
  End Property

  Public Property NCRRSR() As Int32
    Get
      Return _NCRRSR
    End Get
    Set(ByVal value As Int32)
      _NCRRSR = value
    End Set
  End Property

  Public Property FECOST() As String
    Get
      Return _FECOST
    End Get
    Set(ByVal Value As String)
      _FECOST = Value
    End Set
  End Property

  Public Property HRAOTR() As String
    Get
      Return _HRAOTR
    End Get
    Set(ByVal Value As String)
      _HRAOTR = Value
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

  Public Property CTPOSR() As String
    Get
      Return _CTPOSR
    End Get
    Set(ByVal Value As String)
      _CTPOSR = Value
    End Set
  End Property

  Public Property CUNDVH() As String
    Get
      Return _CUNDVH
    End Get
    Set(ByVal Value As String)
      _CUNDVH = Value
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

  Public Property TCMRCD() As String
    Get
      Return _TCMRCD
    End Get
    Set(ByVal Value As String)
      _TCMRCD = Value
    End Set
  End Property

  Public Property QMRCDR() As String
    Get
      Return _QMRCDR
    End Get
    Set(ByVal Value As String)
      _QMRCDR = Value
    End Set
  End Property

  Public Property CUNDMD_C() As String
    Get
      Return _CUNDMD_C
    End Get
    Set(ByVal Value As String)
      _CUNDMD_C = Value
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

  Public Property QATNDR() As String
    Get
      Return _QATNDR
    End Get
    Set(ByVal Value As String)
      _QATNDR = Value
    End Set
  End Property

  Public Property QSLCIT() As String
    Get
      Return _QSLCIT
    End Get
    Set(ByVal Value As String)
      _QSLCIT = Value
    End Set
  End Property

  Public Property QATNAN() As String
    Get
      Return _QATNAN
    End Get
    Set(ByVal Value As String)
      _QATNAN = Value
    End Set
  End Property

  Public Property FINCRG() As String
    Get
      Return _FINCRG
    End Get
    Set(ByVal Value As String)
      _FINCRG = Value
    End Set
  End Property

  Public Property HINCIN() As String
    Get
      Return _HINCIN
    End Get
    Set(ByVal Value As String)
      _HINCIN = Value
    End Set
  End Property

  Public Property FENTCL() As String
    Get
      Return _FENTCL
    End Get
    Set(ByVal Value As String)
      _FENTCL = Value
    End Set
  End Property

  Public Property HRAENT() As String
    Get
      Return _HRAENT
    End Get
    Set(ByVal Value As String)
      _HRAENT = Value
    End Set
  End Property

  Public Property CLCLOR_C() As Int32
    Get
      Return _CLCLOR_C
    End Get
    Set(ByVal Value As Int32)
      _CLCLOR_C = Value
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

  Public Property TDRCOR() As String
    Get
      Return _TDRCOR
    End Get
    Set(ByVal Value As String)
      _TDRCOR = Value
    End Set
  End Property

  Public Property CLCLDS_C() As Int32
    Get
      Return _CLCLDS_C
    End Get
    Set(ByVal Value As Int32)
      _CLCLDS_C = Value
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

  Public Property TDRENT() As String
    Get
      Return _TDRENT
    End Get
    Set(ByVal Value As String)
      _TDRENT = Value
    End Set
  End Property

  Public Property SESSLC() As String
    Get
      Return _SESSLC
    End Get
    Set(ByVal Value As String)
      _SESSLC = Value
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

  Public Property CUSCRT() As String
    Get
      Return _CUSCRT
    End Get
    Set(ByVal Value As String)
      _CUSCRT = Value
    End Set
  End Property

  Public Property FCHCRT() As String
    Get
      Return _FCHCRT
    End Get
    Set(ByVal Value As String)
      _FCHCRT = Value
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

  Public Property NTRMNL() As String
    Get
      Return _NTRMNL
    End Get
    Set(ByVal Value As String)
      _NTRMNL = Value
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

  Public Property SFCRTV() As String
    Get
      Return _SFCRTV
    End Get
    Set(ByVal value As String)
      _SFCRTV = value
    End Set
  End Property

  Public Property NMOPMM() As Double
    Get
      Return _NMOPMM
    End Get
    Set(ByVal value As Double)
      _NMOPMM = value
    End Set
  End Property

  Public Property NCRRRT() As Double
    Get
      Return _NCRRRT
    End Get
    Set(ByVal value As Double)
      _NCRRRT = value
    End Set
  End Property

  Public Property NMOPRP() As Double
    Get
      Return _NMOPRP
    End Get
    Set(ByVal value As Double)
      _NMOPRP = value
    End Set
  End Property

  Public Property CMEDTR() As Double
    Get
      Return _CMEDTR
    End Get
    Set(ByVal value As Double)
      _CMEDTR = value
    End Set
  End Property

  Public Property SEGUIMIENTO() As String
    Get
      Return _SEGUIMIENTO
    End Get
    Set(ByVal Value As String)
      _SEGUIMIENTO = Value
    End Set
  End Property

  Public Property NCOREG() As Int64
    Get
      Return _NCOREG
    End Get
    Set(ByVal value As Int64)
      _NCOREG = value
    End Set
  End Property

  Public Property NGSGWP() As String
    Get
      Return _NGSGWP
    End Get
    Set(ByVal value As String)
      _NGSGWP = value
    End Set
  End Property

  Public Property CCTCSC() As String
    Get
      Return _CCTCSC
    End Get
    Set(ByVal Value As String)
      _CCTCSC = Value
    End Set
  End Property

  Public Property TRFRN() As String
    Get
      Return _TRFRN
    End Get
    Set(ByVal Value As String)
      _TRFRN = Value
    End Set
  End Property

  Public Property CTPOVJ() As String
    Get
      Return _CTPOVJ
    End Get
    Set(ByVal Value As String)
      _CTPOVJ = Value
    End Set
    End Property

    Public Property TIPO() As Int32
        Get
            Return _TIPO
        End Get
        Set(ByVal value As Int32)
            _TIPO = value
        End Set
    End Property

#End Region
End Class
