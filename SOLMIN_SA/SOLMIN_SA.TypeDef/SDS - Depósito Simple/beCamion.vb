Public Class beCamion

    Inherits beBase(Of beCamion)


#Region "AT"

    Private _PNCTRSPT As Decimal
    Private _PSNPLCUN As String
    Private _PNNEJSUN As Decimal
    Private _PSNSRCHU As String
    Private _PSNSRMTU As String
    Private _PNFFBRUN As Decimal
    Private _PSTCLRUN As String
    Private _PSTCRRUN As String
    Private _PNNCPCRU As Decimal
    Private _PNFINPUN As Decimal
    Private _PSSINPUN As String
    Private _PSTOBSIN As String
    Private _PNFPRXDS As Decimal
    Private _PSSTPOUN As String
    Private _PSSESTUN As String
    Private _PNQPSOTR As Decimal
    Private _PNQVLTTR As Decimal
    Private _PSSTMFRA As String
    Private _PSTMRCTR As String
    Private _PSNPLCAC As String
    Private _PSCBRCNT As String
    Private _PNFULASG As Decimal
    Private _PSSDCMPR As String
    Private _PSSUNVNR As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSNTRMCR As String
    Private _PNCIDMVL As Decimal
    Private _PSSTPVHT As String
    Private _PNQTCACT As Decimal
    Private _PNQTCANT As Decimal
    Private _PNNULGUN As Decimal
    Private _PSNRGMT1 As String
    Private _PSTCNFG1 As String
    Private _PNHRAINR As Decimal
    Private _PSSUSOVH As String
    Private _PSCTPUNV As String
    Private _PNCLVVEH As Decimal
    Private _PSNCRHB1 As String
    Private _PNNORINS As Decimal
    Private _PNUPDATE_IDENT As Decimal

    Public Property PNCTRSPT() As Decimal
        Get
            Return (_PNCTRSPT)
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSPT = value
        End Set
    End Property
    Public Property PSNPLCUN() As String
        Get
            Return (_PSNPLCUN)
        End Get
        Set(ByVal value As String)
            _PSNPLCUN = value
        End Set
    End Property
    Public Property PNNEJSUN() As Decimal
        Get
            Return (_PNNEJSUN)
        End Get
        Set(ByVal value As Decimal)
            _PNNEJSUN = value
        End Set
    End Property
    Public Property PSNSRCHU() As String
        Get
            Return (_PSNSRCHU)
        End Get
        Set(ByVal value As String)
            _PSNSRCHU = value
        End Set
    End Property
    Public Property PSNSRMTU() As String
        Get
            Return (_PSNSRMTU)
        End Get
        Set(ByVal value As String)
            _PSNSRMTU = value
        End Set
    End Property
    Public Property PNFFBRUN() As Decimal
        Get
            Return (_PNFFBRUN)
        End Get
        Set(ByVal value As Decimal)
            _PNFFBRUN = value
        End Set
    End Property
    Public Property PSTCLRUN() As String
        Get
            Return (_PSTCLRUN)
        End Get
        Set(ByVal value As String)
            _PSTCLRUN = value
        End Set
    End Property
    Public Property PSTCRRUN() As String
        Get
            Return (_PSTCRRUN)
        End Get
        Set(ByVal value As String)
            _PSTCRRUN = value
        End Set
    End Property
    Public Property PNNCPCRU() As Decimal
        Get
            Return (_PNNCPCRU)
        End Get
        Set(ByVal value As Decimal)
            _PNNCPCRU = value
        End Set
    End Property
    Public Property PNFINPUN() As Decimal
        Get
            Return (_PNFINPUN)
        End Get
        Set(ByVal value As Decimal)
            _PNFINPUN = value
        End Set
    End Property
    Public Property PSSINPUN() As String
        Get
            Return (_PSSINPUN)
        End Get
        Set(ByVal value As String)
            _PSSINPUN = value
        End Set
    End Property
    Public Property PSTOBSIN() As String
        Get
            Return (_PSTOBSIN)
        End Get
        Set(ByVal value As String)
            _PSTOBSIN = value
        End Set
    End Property
    Public Property PNFPRXDS() As Decimal
        Get
            Return (_PNFPRXDS)
        End Get
        Set(ByVal value As Decimal)
            _PNFPRXDS = value
        End Set
    End Property
    Public Property PSSTPOUN() As String
        Get
            Return (_PSSTPOUN)
        End Get
        Set(ByVal value As String)
            _PSSTPOUN = value
        End Set
    End Property
    Public Property PSSESTUN() As String
        Get
            Return (_PSSESTUN)
        End Get
        Set(ByVal value As String)
            _PSSESTUN = value
        End Set
    End Property
    Public Property PNQPSOTR() As Decimal
        Get
            Return (_PNQPSOTR)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSOTR = value
        End Set
    End Property
    Public Property PNQVLTTR() As Decimal
        Get
            Return (_PNQVLTTR)
        End Get
        Set(ByVal value As Decimal)
            _PNQVLTTR = value
        End Set
    End Property
    Public Property PSSTMFRA() As String
        Get
            Return (_PSSTMFRA)
        End Get
        Set(ByVal value As String)
            _PSSTMFRA = value
        End Set
    End Property
    Public Property PSTMRCTR() As String
        Get
            Return (_PSTMRCTR)
        End Get
        Set(ByVal value As String)
            _PSTMRCTR = value
        End Set
    End Property

    Public Property PSCBRCNT() As String
        Get
            Return (_PSCBRCNT)
        End Get
        Set(ByVal value As String)
            _PSCBRCNT = value
        End Set
    End Property
    Public Property PNFULASG() As Decimal
        Get
            Return (_PNFULASG)
        End Get
        Set(ByVal value As Decimal)
            _PNFULASG = value
        End Set
    End Property
    Public Property PSSDCMPR() As String
        Get
            Return (_PSSDCMPR)
        End Get
        Set(ByVal value As String)
            _PSSDCMPR = value
        End Set
    End Property
    Public Property PSSUNVNR() As String
        Get
            Return (_PSSUNVNR)
        End Get
        Set(ByVal value As String)
            _PSSUNVNR = value
        End Set
    End Property


    Public Property PSCUSCRT() As String
        Get
            Return (_PSCUSCRT)
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
        End Set
    End Property
    Public Property PNFCHCRT() As Decimal
        Get
            Return (_PNFCHCRT)
        End Get
        Set(ByVal value As Decimal)
            _PNFCHCRT = value
        End Set
    End Property
    Public Property PNHRACRT() As Decimal
        Get
            Return (_PNHRACRT)
        End Get
        Set(ByVal value As Decimal)
            _PNHRACRT = value
        End Set
    End Property
    Public Property PSNTRMCR() As String
        Get
            Return (_PSNTRMCR)
        End Get
        Set(ByVal value As String)
            _PSNTRMCR = value
        End Set
    End Property
    Public Property PNCIDMVL() As Decimal
        Get
            Return (_PNCIDMVL)
        End Get
        Set(ByVal value As Decimal)
            _PNCIDMVL = value
        End Set
    End Property
    Public Property PSSTPVHT() As String
        Get
            Return (_PSSTPVHT)
        End Get
        Set(ByVal value As String)
            _PSSTPVHT = value
        End Set
    End Property
    Public Property PNQTCACT() As Decimal
        Get
            Return (_PNQTCACT)
        End Get
        Set(ByVal value As Decimal)
            _PNQTCACT = value
        End Set
    End Property
    Public Property PNQTCANT() As Decimal
        Get
            Return (_PNQTCANT)
        End Get
        Set(ByVal value As Decimal)
            _PNQTCANT = value
        End Set
    End Property
    Public Property PNNULGUN() As Decimal
        Get
            Return (_PNNULGUN)
        End Get
        Set(ByVal value As Decimal)
            _PNNULGUN = value
        End Set
    End Property
    Public Property PSNRGMT1() As String
        Get
            Return (_PSNRGMT1)
        End Get
        Set(ByVal value As String)
            _PSNRGMT1 = value
        End Set
    End Property
    Public Property PSTCNFG1() As String
        Get
            Return (_PSTCNFG1)
        End Get
        Set(ByVal value As String)
            _PSTCNFG1 = value
        End Set
    End Property
    Public Property PNHRAINR() As Decimal
        Get
            Return (_PNHRAINR)
        End Get
        Set(ByVal value As Decimal)
            _PNHRAINR = value
        End Set
    End Property
    Public Property PSSUSOVH() As String
        Get
            Return (_PSSUSOVH)
        End Get
        Set(ByVal value As String)
            _PSSUSOVH = value
        End Set
    End Property
    Public Property PSCTPUNV() As String
        Get
            Return (_PSCTPUNV)
        End Get
        Set(ByVal value As String)
            _PSCTPUNV = value
        End Set
    End Property
    Public Property PNCLVVEH() As Decimal
        Get
            Return (_PNCLVVEH)
        End Get
        Set(ByVal value As Decimal)
            _PNCLVVEH = value
        End Set
    End Property
    Public Property PSNCRHB1() As String
        Get
            Return (_PSNCRHB1)
        End Get
        Set(ByVal value As String)
            _PSNCRHB1 = value
        End Set
    End Property
    Public Property PNNORINS() As Decimal
        Get
            Return (_PNNORINS)
        End Get
        Set(ByVal value As Decimal)
            _PNNORINS = value
        End Set
    End Property
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property



#End Region




    Private _PNCTRSP As Decimal
    Private _PSNPLCCM As String
    Private _PNPTRCM As Decimal
    Private _PNNANOCM As Decimal
    Private _PSTMRCCM As String
    Private _PSNMTRCM As String
    Private _PSSESTCM As String
    Private _PSNROPLA As String
    Private _PSNBRVC1 As String

    Private _PNNTRNLL As Decimal
    Private _PNFASGTR As Decimal
    Private _PNHASGTR As Decimal
    Private _PNSESTRG As String
    Private _PNUPID As Decimal


    Public Property PNCTRSP() As Decimal
        Get
            Return _PNCTRSP
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSP = value
        End Set
    End Property
    Public Property PSNPLCCM() As String
        Get
            Return (_PSNPLCCM)
        End Get
        Set(ByVal value As String)
            _PSNPLCCM = value
        End Set
    End Property
    Public Property PNPTRCM() As Decimal
        Get
            Return (_PNPTRCM)
        End Get
        Set(ByVal value As Decimal)
            _PNPTRCM = value
        End Set
    End Property
    Public Property PNNANOCM() As Decimal
        Get
            Return (_PNNANOCM)
        End Get
        Set(ByVal value As Decimal)
            _PNNANOCM = value
        End Set
    End Property
    Public Property PSTMRCCM() As String
        Get
            Return (_PSTMRCCM)
        End Get
        Set(ByVal value As String)
            _PSTMRCCM = value
        End Set
    End Property
    Public Property PSNMTRCM() As String
        Get
            Return (_PSNMTRCM)
        End Get
        Set(ByVal value As String)
            _PSNMTRCM = value
        End Set
    End Property
    Public Property PSSESTCM() As String
        Get
            Return (_PSSESTCM)
        End Get
        Set(ByVal value As String)
            _PSSESTCM = value
        End Set
    End Property
    Public Property PSNROPLA() As String
        Get
            Return _PSNROPLA
        End Get
        Set(ByVal value As String)
            _PSNROPLA = value
        End Set
    End Property
    Public Property PSNBRVC1() As String
        Get
            Return _PSNBRVC1
        End Get
        Set(ByVal value As String)
            _PSNBRVC1 = value
        End Set
    End Property
    Public Property PSNPLCAC() As String
        Get
            Return _PSNPLCAC
        End Get
        Set(ByVal value As String)
            _PSNPLCAC = value
        End Set
    End Property
    Public Property PNNTRNLL() As Decimal
        Get
            Return _PNNTRNLL
        End Get
        Set(ByVal value As Decimal)
            _PNNTRNLL = value
        End Set
    End Property
    Public Property PNFASGTR() As Decimal
        Get
            Return _PNFASGTR
        End Get
        Set(ByVal value As Decimal)
            _PNFASGTR = value
        End Set
    End Property
    Public Property PNHASGTR() As Decimal
        Get
            Return _PNHASGTR
        End Get
        Set(ByVal value As Decimal)
            _PNHASGTR = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return _PNHULTAC
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
        End Set
    End Property
    Public Property PNFULTAC() As Decimal
        Get
            Return _PNFULTAC
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property
    Public Property PNSESTRG() As String
        Get
            Return _PNSESTRG
        End Get
        Set(ByVal value As String)
            _PNSESTRG = value
        End Set
    End Property
    Public Property PNUPID() As Decimal
        Get
            Return _PNUPID
        End Get
        Set(ByVal value As Decimal)
            _PNUPID = value
        End Set
    End Property

End Class
Public Class beCamionFiltro
    Public CTRSPSTR As String = ""
    Public PAGESIZE As Int32 = 0
    Public PAGENUMBER As Int32 = 0
    Public PAGECOUNT As Int32 = 0
    Public Sub pclar()
        CTRSPSTR = ""
        PAGESIZE = 0
        PAGENUMBER = 0
        PAGECOUNT = 0
    End Sub
End Class