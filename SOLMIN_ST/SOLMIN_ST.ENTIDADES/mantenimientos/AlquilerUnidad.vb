Public Class AlquilerUnidad
    Private _NRALQT As Decimal = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Decimal = 0
    Private _NRUCTR As String = ""
    Private _STPRCS As String = ""
    Private _NPLRCS As String = ""
    Private _FCHASG As Decimal = 0
    Private _FVALIN As Decimal = 0
    Private _FVALFI As Decimal = 0
    Private _CSRVNV As Decimal = 0
    Private _CMNALQ As Decimal = 0
    Private _QCNALQ As Decimal = 0
    Private _IRVALQ As Decimal = 0
    Private _NKMRTA As Decimal = 0
    Private _SESALQ As String = ""
    Private _NORINS As Decimal = 0
    Private _NLQDCN As Decimal = 0
    Private _SESTRG As String = ""
    Private _TCMTRF As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Decimal = 0
    Private _HRACRT As Decimal = 0
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Decimal = 0
    Private _HULTAC As Decimal = 0
    Private _NTRMNL As String = ""
    Private _FCHASG_S As String = ""
    Private _FVALIN_S As String = ""
    Private _FVALFI_S As String = ""

    Private _TCMTRT As String = ""
    Private _TDSDES As String = ""
    Private _TMNDA As String = ""
    Private _IMP_TOTAL As Decimal = 0
    Private _SESALQ_S As String = ""

    Private _TIPO_UNIDAD As String = ""
    Private _MARCA As String = ""
    Private _CCLNT As Decimal = 0
    Private _FINCOPINI As Decimal = 0
    Private _FINCOPFIN As Decimal = 0
    Private _NOPRCN As Decimal = 0
    Private _FCHASGI As Decimal = 0
    Private _FCHASGF As Decimal = 0
    Private _CCNCS1 As Decimal = 0
    Private _FLQDCN As String = ""
    Private _NRFSAP As Decimal = 0
    Private _TSTERS As String = ""
    Private _FSTTRS As String = ""
    Private _NUMOPG As Decimal = 0
    Private _ILQDTR As Decimal = 0
    Private _ITCCTC As Decimal = 0
    Private _CSRVC As Decimal = 0
    Private _SERVICIO As String = ""



    Private _CUSRCR As String = ""
    Private _FCHCIE As String = ""
    Private _TOBRES As String = ""

    Private _CUSAPR As String = ""
    Private _FCHAPR As String = ""
    Private _TOBRES2 As String = ""
    Private _FLGAPR As String = ""
    
    Private _NCRRRT As Decimal = 0
    Private _FLGAPR_APR As String = ""
    Private _TOBS As String = ""
    Private _REFDO1 As String = ""

    Private _CMNAL1 As Decimal = 0
    Private _IRVAL1 As Decimal = 0
    Private _TOBRE3 As String = ""

    Private _CCLORI As String = ""


    Public Property CCLORI() As String
        Get
            Return _CCLORI
        End Get
        Set(ByVal value As String)
            _CCLORI = value
        End Set
    End Property

    Public Property NRALQT() As Decimal
        Get
            Return _NRALQT
        End Get
        Set(ByVal value As Decimal)
            _NRALQT = value
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

    Public Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
        Set(ByVal value As String)
            _NRUCTR = value
        End Set
    End Property

    Public Property CPLNDV() As Decimal
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Decimal)
            _CPLNDV = value
        End Set
    End Property


    Public Property STPRCS() As String
        Get
            Return _STPRCS
        End Get
        Set(ByVal value As String)
            _STPRCS = value
        End Set
    End Property

    Public Property NPLRCS() As String
        Get
            Return _NPLRCS
        End Get
        Set(ByVal value As String)
            _NPLRCS = value
        End Set
    End Property
    Public Property FCHASG() As Decimal
        Get
            Return _FCHASG
        End Get
        Set(ByVal value As Decimal)
            _FCHASG = value
        End Set
    End Property

    Public Property FVALIN() As Decimal
        Get
            Return _FVALIN
        End Get
        Set(ByVal value As Decimal)
            _FVALIN = value
        End Set
    End Property

    Public Property FVALFI() As Decimal
        Get
            Return _FVALFI
        End Get
        Set(ByVal value As Decimal)
            _FVALFI = value
        End Set
    End Property

    Public Property FCHASG_S() As String
        Get
            Return _FCHASG_S
        End Get
        Set(ByVal value As String)
            _FCHASG_S = value
        End Set
    End Property

    Public Property FVALIN_S() As String
        Get
            Return _FVALIN_S
        End Get
        Set(ByVal value As String)
            _FVALIN_S = value
        End Set
    End Property

    Public Property FVALFI_S() As String
        Get
            Return _FVALFI_S
        End Get
        Set(ByVal value As String)
            _FVALFI_S = value
        End Set
    End Property

    Public Property CSRVNV() As Decimal
        Get
            Return _CSRVNV
        End Get
        Set(ByVal value As Decimal)
            _CSRVNV = value
        End Set
    End Property

    Public Property CMNALQ() As Decimal
        Get
            Return _CMNALQ
        End Get
        Set(ByVal value As Decimal)
            _CMNALQ = value
        End Set
    End Property

    Public Property QCNALQ() As Decimal
        Get
            Return _QCNALQ
        End Get
        Set(ByVal value As Decimal)
            _QCNALQ = value
        End Set
    End Property

    Public Property IRVALQ() As Decimal
        Get
            Return _IRVALQ
        End Get
        Set(ByVal value As Decimal)
            _IRVALQ = value
        End Set
    End Property

    Public Property NKMRTA() As Decimal
        Get
            Return _NKMRTA
        End Get
        Set(ByVal value As Decimal)
            _NKMRTA = value
        End Set
    End Property

    Public Property SESALQ() As String
        Get
            Return _SESALQ
        End Get
        Set(ByVal value As String)
            _SESALQ = value
        End Set
    End Property

    Public Property NORINS() As Decimal
        Get
            Return _NORINS
        End Get
        Set(ByVal value As Decimal)
            _NORINS = value
        End Set
    End Property

    Public Property NLQDCN() As Decimal
        Get
            Return _NLQDCN
        End Get
        Set(ByVal value As Decimal)
            _NLQDCN = value
        End Set
    End Property

    Public Property FLQDCN() As String
        Get
            Return _FLQDCN
        End Get
        Set(ByVal value As String)
            _FLQDCN = value
        End Set
    End Property

    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Public Property TCMTRF() As String
        Get
            Return _TCMTRF
        End Get
        Set(ByVal value As String)
            _TCMTRF = value
        End Set
    End Property

    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property

    Public Property FCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property

    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property

    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property

    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property

    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
        End Set
    End Property

    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property

    '_TCMTRT
    Public Property TCMTRT() As String
        Get
            Return _TCMTRT
        End Get
        Set(ByVal value As String)
            _TCMTRT = value
        End Set
    End Property


    Public Property TDSDES() As String
        Get
            Return _TDSDES
        End Get
        Set(ByVal value As String)
            _TDSDES = value
        End Set
    End Property

    Public Property TMNDA() As String
        Get
            Return _TMNDA
        End Get
        Set(ByVal value As String)
            _TMNDA = value
        End Set
    End Property

    Public Property IMP_TOTAL() As Decimal
        Get
            Return _IMP_TOTAL
        End Get
        Set(ByVal value As Decimal)
            _IMP_TOTAL = value
        End Set
    End Property

    Public Property SESALQ_S() As String
        Get
            Return _SESALQ_S
        End Get
        Set(ByVal value As String)
            _SESALQ_S = value
        End Set
    End Property

    Public Property TIPO_UNIDAD() As String
        Get
            Return _TIPO_UNIDAD
        End Get
        Set(ByVal value As String)
            _TIPO_UNIDAD = value
        End Set
    End Property
    Public Property MARCA() As String
        Get
            Return _MARCA
        End Get
        Set(ByVal value As String)
            _MARCA = value
        End Set
    End Property

    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Public Property FCHASGI() As Decimal
        Get
            Return _FCHASGI
        End Get
        Set(ByVal value As Decimal)
            _FCHASGI = value
        End Set
    End Property

    Public Property FCHASGF() As Decimal
        Get
            Return _FCHASGF
        End Get
        Set(ByVal value As Decimal)
            _FCHASGF = value
        End Set
    End Property

    Public Property CCNCS1() As Decimal
        Get
            Return _CCNCS1
        End Get
        Set(ByVal value As Decimal)
            _CCNCS1 = value
        End Set
    End Property

    Public Property NRFSAP() As Decimal
        Get
            Return _NRFSAP
        End Get
        Set(ByVal value As Decimal)
            _NRFSAP = value
        End Set
    End Property

    Public Property TSTERS() As String
        Get
            Return _TSTERS
        End Get
        Set(ByVal value As String)
            _TSTERS = value
        End Set
    End Property


    Public Property FSTTRS() As String
        Get
            Return _FSTTRS
        End Get
        Set(ByVal value As String)
            _FSTTRS = value
        End Set
    End Property

    Public Property NUMOPG() As Decimal
        Get
            Return _NUMOPG
        End Get
        Set(ByVal value As Decimal)
            _NUMOPG = value
        End Set
    End Property

    Public Property ILQDTR() As Decimal
        Get
            Return _ILQDTR
        End Get
        Set(ByVal value As Decimal)
            _ILQDTR = value
        End Set
    End Property

    Public Property ITCCTC() As Decimal
        Get
            Return _ITCCTC
        End Get
        Set(ByVal value As Decimal)
            _ITCCTC = value
        End Set
    End Property

    Public Property CSRVC() As Decimal
        Get
            Return _CSRVC
        End Get
        Set(ByVal value As Decimal)
            _CSRVC = value
        End Set
    End Property

    Public Property SERVICIO() As String
        Get
            Return _SERVICIO
        End Get
        Set(ByVal value As String)
            _SERVICIO = value
        End Set
    End Property

    Public Property CUSRCR() As String
        Get
            Return _CUSRCR
        End Get
        Set(ByVal value As String)
            _CUSRCR = value
        End Set
    End Property

    Public Property FCHCIE() As String
        Get
            Return _FCHCIE
        End Get
        Set(ByVal value As String)
            _FCHCIE = value
        End Set
    End Property

    Public Property TOBRES() As String
        Get
            Return _TOBRES
        End Get
        Set(ByVal value As String)
            _TOBRES = value
        End Set
    End Property

    Public Property CUSAPR() As String
        Get
            Return _CUSAPR
        End Get
        Set(ByVal value As String)
            _CUSAPR = value
        End Set
    End Property

    Public Property FCHAPR() As String
        Get
            Return _FCHAPR
        End Get
        Set(ByVal value As String)
            _FCHAPR = value
        End Set
    End Property

    Public Property TOBRES2() As String
        Get
            Return _TOBRES2
        End Get
        Set(ByVal value As String)
            _TOBRES2 = value
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

    Public Property FLGAPR_APR() As String
        Get
            Return _FLGAPR_APR
        End Get
        Set(ByVal value As String)
            _FLGAPR_APR = value
        End Set
    End Property



    Public Property NCRRRT() As Decimal
        Get
            Return _NCRRRT
        End Get
        Set(ByVal value As Decimal)
            _NCRRRT = value
        End Set
    End Property



#Region "Operaciones"
    Private _FINCOP_S As String = ""
    Private _NORSRT As Decimal = 0
    Private _CCLNT_S As String = ""
    Private _RUTA As String = ""
    Private _CLCLOR As Decimal = 0
    Private _CLCLDS As Decimal = 0
    Private _CLCLOR_S As String = ""
    Private _CLCLDS_S As String = ""
    Private _NPLCUN As String = ""
    Private _NPLCAC As String = ""
    Private _CBRCNT As String = ""
    Private _CBRCND As String = ""
    Private _SESTOP As String = ""
    Private _FATNSR As String = ""
    Public Property FINCOP_S() As String
        Get
            Return _FINCOP_S
        End Get
        Set(ByVal value As String)
            _FINCOP_S = value
        End Set
    End Property

    Public Property NORSRT() As Decimal
        Get
            Return _NORSRT
        End Get
        Set(ByVal value As Decimal)
            _NORSRT = value
        End Set
    End Property

    Public Property CCLNT_S() As String
        Get
            Return _CCLNT_S
        End Get
        Set(ByVal value As String)
            _CCLNT_S = value
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

    Public Property CLCLOR() As Decimal
        Get
            Return _CLCLOR
        End Get
        Set(ByVal value As Decimal)
            _CLCLOR = value
        End Set
    End Property

    Public Property CLCLDS() As Decimal
        Get
            Return _CLCLDS
        End Get
        Set(ByVal value As Decimal)
            _CLCLDS = value
        End Set
    End Property

    Public Property CLCLOR_S() As String
        Get
            Return _CLCLOR_S
        End Get
        Set(ByVal value As String)
            _CLCLOR_S = value
        End Set
    End Property

    Public Property CLCLDS_S() As String
        Get
            Return _CLCLDS_S
        End Get
        Set(ByVal value As String)
            _CLCLDS_S = value
        End Set
    End Property

    Public Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
        Set(ByVal value As String)
            _NPLCUN = value
        End Set
    End Property

    Public Property NPLCAC() As String
        Get
            Return _NPLCAC
        End Get
        Set(ByVal value As String)
            _NPLCAC = value
        End Set
    End Property

    Public Property CBRCNT() As String
        Get
            Return _CBRCNT
        End Get
        Set(ByVal value As String)
            _CBRCNT = value
        End Set
    End Property

    Public Property CBRCND() As String
        Get
            Return _CBRCND
        End Get
        Set(ByVal value As String)
            _CBRCND = value
        End Set
    End Property

    Public Property SESTOP() As String
        Get
            Return _SESTOP
        End Get
        Set(ByVal value As String)
            _SESTOP = value
        End Set
    End Property

    'Private _FINCOPINI As Decimal = 0
    'Private _FINCOPFIN As Decimal = 0
    Public Property FINCOPINI() As Decimal
        Get
            Return _FINCOPINI
        End Get
        Set(ByVal value As Decimal)
            _FINCOPINI = value
        End Set
    End Property

    Public Property FINCOPFIN() As Decimal
        Get
            Return _FINCOPFIN
        End Get
        Set(ByVal value As Decimal)
            _FINCOPFIN = value
        End Set
    End Property

    Public Property NOPRCN() As Decimal
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Decimal)
            _NOPRCN = value
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

    Public Property CMNAL1() As Decimal
        Get
            Return _CMNAL1
        End Get
        Set(ByVal value As Decimal)
            _CMNAL1 = value
        End Set
    End Property

    Public Property IRVAL1() As Decimal
        Get
            Return _IRVAL1
        End Get
        Set(ByVal value As Decimal)
            _IRVAL1 = value
        End Set
    End Property
    Public Property TOBRE3() As String
        Get
            Return _TOBRE3
        End Get
        Set(ByVal value As String)
            _TOBRE3 = value
        End Set
    End Property
    Public Property REFDO1() As String
        Get
            Return _REFDO1
        End Get
        Set(ByVal value As String)
            _REFDO1 = value
        End Set
    End Property

    Public Property FATNSR() As String
        Get
            Return _FATNSR
        End Get
        Set(ByVal value As String)
            _FATNSR = value
        End Set
    End Property
    '
#End Region

End Class
