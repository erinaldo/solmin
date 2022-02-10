Public Class Servicio_BE
    Inherits Base_BE(Of Servicio_BE)

    ''' <summary>
    ''' Inicializa la clase  Servicio_BE
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

    Private _NOPRCN As Double = 0
    Private _CCLNT As Double = 0
    Private _CCLNFC As Double = 0
    Private _FOPRCN As Double = 0
    Private _NRTFSV As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _QATNAN As Double = 0
    Private _QATNRL As Double = 0
    Private _FECINI As Double = 0
    Private _FECFIN As Double = 0
    Private _TIPO As String = ""
    Private _STIPPR As String = ""
    Private _NORSCI As Double = 0
    Private _NORCML As String = ""
    Private _FLGFAC As String = ""
    Private _TOBS As String = ""
    Private _CMNDA1 As Integer = 0
    Private _NRITEM As Decimal = 0
    Private _TIPO_PROCESO As String = ""
    Private _TOTALDIAS As Integer = 0
    Private _SSTINV As String = ""
    Private _TCTCST As String = ""
    Private _TLUGEN As String = ""
    Private _CTPALM As String = ""
    Private _CALMC As String = ""
    Private _CZNALM As String = ""
    Private _BULTOS As DataTable = Nothing
    Private _TARIFA_DESC As String = ""
    Private _VALCTE As Decimal = 0D
    Private _TSGNMN As String = ""
    Private _IVLSRV As Decimal = 0D
    Private _TSRVC As String = ""
    Private _FATNSR As Double = 0D

    Private _CTRMNC As Double = 0D
    Private _NGUITR As Double = 0D

    Private _NSEQIN As Double = 1
    Private _SRBAFD As String = "" 
    Private _DESTAR As String = ""

    Private _SSNCRG As String = ""
    Private _SSNCRG_D As String = ""

    Private _TCMZNA As String = ""
    Private _TALMC As String = ""
    Private _TCMPAL As String = ""

    Private _FECSERV_INI As Double = 0
    Private _FECSERV_FIN As Double = 0

    Private _TPRVCL As String = ""
    Private _TDITES As String = ""
    Private _NDOCEM As String = ""
    Private _CMEDTR As String = ""


    Private _TCANAL As String = ""
    Private _TNMAGC As String = ""
    Private _REGIMEN As String = ""
    Private _DESPACHO As String = ""
    Private _TNRODU As String = ""
    Private _FOB As Decimal = 0
    Private _FLETE As Decimal = 0
    Private _SEGURO As Decimal = 0
    Private _CIF As Decimal = 0
    Private _NROS_REVISION As String = ""

    Private _ITCCTC As Decimal = 0
    Private _NDCCTC As Decimal = 0
    Private _FDCCTC As Decimal = 0

    Private _LIBERAR As String = ""
    Private _TABTPD As String = ""
    Private _NTRMNC As String = ""
    Private _FTIPOR As String = ""
    Private _TTPOMR As String = ""


    Private _CDIRSE As Integer
    Private _NGUIRS As String = ""

    Private _FECREV_INI As Decimal = 0
    Private _FECREV_FIN As Decimal = 0
    Private _LISTJSON As String = ""
    Private _ESRECCARGA As String = ""

    Private _IPRCDT As Decimal = 0
    Public Property CDIRSE() As Integer
        Get
            Return _CDIRSE
        End Get
        Set(ByVal value As Integer)
            _CDIRSE = value
        End Set
    End Property


    Public Property NSEQIN() As Double
        Get
            Return _NSEQIN
        End Get
        Set(ByVal value As Double)
            _NSEQIN = value
        End Set
    End Property

    Public Property CTRMNC() As Double
        Get
            Return _CTRMNC
        End Get
        Set(ByVal value As Double)
            _CTRMNC = value
        End Set
    End Property

    Public Property NGUITR() As Double
        Get
            Return _NGUITR
        End Get
        Set(ByVal value As Double)
            _NGUITR = value
        End Set
    End Property

    Public Property FATNSR() As Double
        Get
            Return _FATNSR
        End Get
        Set(ByVal value As Double)
            _FATNSR = value
        End Set
    End Property

    Public Property TSRVC() As String
        Get
            Return _TSRVC
        End Get
        Set(ByVal value As String)
            _TSRVC = value
        End Set
    End Property

    Public Property VALCTE() As Decimal
        Get
            Return _VALCTE
        End Get
        Set(ByVal value As Decimal)
            _VALCTE = value
        End Set
    End Property
    Public Property TSGNMN() As String
        Get
            Return _TSGNMN
        End Get
        Set(ByVal value As String)
            _TSGNMN = value
        End Set
    End Property
    Public Property IVLSRV() As Decimal
        Get
            Return _IVLSRV
        End Get
        Set(ByVal value As Decimal)
            _IVLSRV = value
        End Set
    End Property


    Public Property TARIFA_DESC() As String
        Get
            Return _TARIFA_DESC
        End Get
        Set(ByVal value As String)
            _TARIFA_DESC = value
        End Set
    End Property

    Public Property BULTOS() As DataTable
        Get
            Return _BULTOS
        End Get
        Set(ByVal value As DataTable)
            _BULTOS = value
        End Set
    End Property

    Public Property CTPALM() As String
        Get
            Return _CTPALM
        End Get
        Set(ByVal value As String)
            _CTPALM = value
        End Set
    End Property
    Public Property CALMC() As String
        Get
            Return _CALMC
        End Get
        Set(ByVal value As String)
            _CALMC = value
        End Set
    End Property
    Public Property CZNALM() As String
        Get
            Return _CZNALM
        End Get
        Set(ByVal value As String)
            _CZNALM = value
        End Set
    End Property

    Public Property TCTCST() As String
        Get
            Return _TCTCST
        End Get
        Set(ByVal value As String)
            _TCTCST = value
        End Set
    End Property
    Public Property TLUGEN() As String
        Get
            Return _TLUGEN
        End Get
        Set(ByVal value As String)
            _TLUGEN = value
        End Set
    End Property



    Public Property SSTINV() As String
        Get
            Return _SSTINV
        End Get
        Set(ByVal value As String)
            _SSTINV = value
        End Set
    End Property


    Public Property TOTALDIAS() As Integer
        Get
            Return _TOTALDIAS
        End Get
        Set(ByVal value As Integer)
            _TOTALDIAS = value
        End Set
    End Property
    Public Property TIPO_PROCESO() As String
        Get
            Return _TIPO_PROCESO
        End Get
        Set(ByVal value As String)
            _TIPO_PROCESO = value
        End Set
    End Property

    Public Property CMNDA1() As Integer
        Get
            Return _CMNDA1
        End Get
        Set(ByVal value As Integer)
            _CMNDA1 = value
        End Set
    End Property
    Private _FULTAC As Integer = 0
    Public Property FULTAC() As Integer
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Integer)
            _FULTAC = value
        End Set
    End Property

    Private _FLGPEN As String = "0"
    Private _PNNORSCI As Decimal = 0
    Public Property FLGPEN() As String
        Get
            Return _FLGPEN
        End Get
        Set(ByVal value As String)
            _FLGPEN = value
        End Set
    End Property
    Private _NSECFC As Double = 0
    Public Property NSECFC() As Double
        Get
            Return _NSECFC
        End Get
        Set(ByVal value As Double)
            _NSECFC = value
        End Set
    End Property
    Private _NSECFC_UPD As Double = 0
    Public Property NSECFC_UPD() As Double
        Get
            Return _NSECFC_UPD
        End Get
        Set(ByVal value As Double)
            _NSECFC_UPD = value
        End Set
    End Property

    Private _NCRRDC As Integer = 0
    Public Property NCRRDC() As Integer
        Get
            Return _NCRRDC
        End Get
        Set(ByVal value As Integer)
            _NCRRDC = value
        End Set
    End Property

    Public Property STIPPR() As String
        Get
            Return _STIPPR
        End Get
        Set(ByVal value As String)
            _STIPPR = value
        End Set
    End Property

    Private _TRDCCL As String
    Public Property TRDCCL() As String
        Get
            Return _TRDCCL
        End Get
        Set(ByVal value As String)
            _TRDCCL = value
        End Set
    End Property

    Public Property CCLNFC() As Integer
        Get
            Return _CCLNFC
        End Get
        Set(ByVal value As Integer)
            _CCLNFC = value
        End Set
    End Property
    Private _NGUIRM As Decimal = 0
    Public Property NGUIRM() As Decimal
        Get
            Return _NGUIRM
        End Get
        Set(ByVal value As Decimal)
            _NGUIRM = value
        End Set
    End Property
    Private _NRGUSA As Decimal = 0
    Public Property NRGUSA() As Decimal
        Get
            Return _NRGUSA
        End Get
        Set(ByVal value As Decimal)
            _NRGUSA = value
        End Set
    End Property
    Private _NROCTL As Decimal = 0
    Public Property NROCTL() As Decimal
        Get
            Return _NROCTL
        End Get
        Set(ByVal value As Decimal)
            _NROCTL = value
        End Set
    End Property
    Private _NROPLT As Decimal = 0
    Public Property NROPLT() As Decimal
        Get
            Return _NROPLT
        End Get
        Set(ByVal value As Decimal)
            _NROPLT = value
        End Set
    End Property
    Private _CREFFW As String = ""
    Public Property CREFFW() As String
        Get
            Return _CREFFW
        End Get
        Set(ByVal value As String)
            _CREFFW = value
        End Set
    End Property

    Private _QPRDFC As Integer = 0
    Public Property QPRDFC() As Integer
        Get
            Return _QPRDFC
        End Get
        Set(ByVal value As Integer)
            _QPRDFC = value
        End Set
    End Property
    Private _CPLNDV As Integer = 0
    Public Property CPLNDV() As Integer
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Integer)
            _CPLNDV = value
        End Set
    End Property
    Private _NOMSER As String = ""
    Public Property NOMSER() As String
        Get
            Return _NOMSER
        End Get
        Set(ByVal value As String)
            _NOMSER = value
        End Set
    End Property
    Private _QCNESP As Double = 0D
    Public Property QCNESP() As Double
        Get
            Return _QCNESP
        End Get
        Set(ByVal value As Double)
            _QCNESP = value
        End Set
    End Property
    Private _TUNDIT = ""
    Public Property TUNDIT() As String
        Get
            Return _TUNDIT
        End Get
        Set(ByVal value As String)
            _TUNDIT = value
        End Set
    End Property
    Private _TIPOALM As Integer = 0
    Public Property TIPOALM() As Integer
        Get
            Return _TIPOALM
        End Get
        Set(ByVal value As Integer)
            _TIPOALM = value
        End Set
    End Property
    Private _CPRCN1 As String = ""
    Public Property CPRCN1() As String
        Get
            Return _CPRCN1
        End Get
        Set(ByVal value As String)
            _CPRCN1 = value
        End Set
    End Property
    Private _NSRCN1 As String = ""
    Public Property NSRCN1() As String
        Get
            Return _NSRCN1
        End Get
        Set(ByVal value As String)
            _NSRCN1 = value
        End Set
    End Property
    Property TIPO() As String
        Get
            Return _TIPO
        End Get
        Set(ByVal value As String)
            _TIPO = value
        End Set
    End Property
    Property NOPRCN() As Double
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Double)
            _NOPRCN = value
        End Set
    End Property

    Private _NCRROP As Decimal
    Public Property NCRROP() As Decimal
        Get
            Return _NCRROP
        End Get
        Set(ByVal value As Decimal)
            _NCRROP = value
        End Set
    End Property

    Property CCLNT() As Double
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Double)
            _CCLNT = value
        End Set
    End Property
    Property FOPRCN() As Double
        Get
            Return _FOPRCN
        End Get
        Set(ByVal value As Double)
            _FOPRCN = value
        End Set
    End Property
    Property NRTFSV() As Double
        Get
            Return _NRTFSV
        End Get
        Set(ByVal value As Double)
            _NRTFSV = value
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
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal Value As String)
            _CCMPN = Value
        End Set
    End Property
    Property QATNAN() As Double
        Get
            Return _QATNAN
        End Get
        Set(ByVal value As Double)
            _QATNAN = value
        End Set
    End Property

    Property QATNRL() As Double
        Get
            Return _QATNRL
        End Get
        Set(ByVal value As Double)
            _QATNRL = value
        End Set
    End Property

    Property FECINI() As Double
        Get
            Return _FECINI
        End Get
        Set(ByVal value As Double)
            _FECINI = value
        End Set
    End Property

    Public Property FechaInicio() As String
        Get
            Return NumeroAFecha(_FECINI)
        End Get
        Set(ByVal value As String)
            _FECINI = CtypeDate(value)
        End Set
    End Property


    Property FECFIN() As Double
        Get
            Return _FECFIN
        End Get
        Set(ByVal value As Double)
            _FECFIN = value
        End Set
    End Property

    Public Property FechaFin() As String
        Get
            Return NumeroAFecha(_FECFIN)
        End Get
        Set(ByVal value As String)
            _FECFIN = CtypeDate(value)
        End Set
    End Property
    Property FLGFAC() As String
        Get
            Return _FLGFAC
        End Get
        Set(ByVal value As String)
            _FLGFAC = value
        End Set
    End Property
    Property NORSCI() As Double
        Get
            Return _NORSCI
        End Get
        Set(ByVal value As Double)
            _NORSCI = value
        End Set
    End Property
    Property NORCML() As String
        Get
            Return _NORCML
        End Get
        Set(ByVal value As String)
            _NORCML = value
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

    Private _TRFSRC As String

    Public Property TRFSRC() As String
        Get
            Return _TRFSRC
        End Get
        Set(ByVal value As String)
            _TRFSRC = value
        End Set
    End Property


    'Private _USUARIO As String
    'Public Property USUARIO() As String
    '    Get
    '        Return _USUARIO
    '    End Get
    '    Set(ByVal value As String)
    '        _USUARIO = value
    '    End Set
    'End Property

    Private _CCNTCS As String
    Public Property CCNTCS() As String
        Get
            Return _CCNTCS
        End Get
        Set(ByVal value As String)
            _CCNTCS = value
        End Set
    End Property

    Private _SESTRG As String
    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property
    Private _CCMPN_DESC As String = ""
    Public Property CCMPN_DESC() As String
        Get
            Return _CCMPN_DESC
        End Get
        Set(ByVal value As String)
            _CCMPN_DESC = value
        End Set
    End Property
    Private _CDVSN_DESC As String = ""
    Public Property CDVSN_DESC() As String
        Get
            Return _CDVSN_DESC
        End Get
        Set(ByVal value As String)
            _CDVSN_DESC = value
        End Set
    End Property
    Private _CPLNDV_DESC As String = ""
    Public Property CPLNDV_DESC() As String
        Get
            Return _CPLNDV_DESC
        End Get
        Set(ByVal value As String)
            _CPLNDV_DESC = value
        End Set
    End Property

    Private _TAG As String
    Public Property TAG() As String
        Get
            Return _TAG
        End Get
        Set(ByVal value As String)
            _TAG = value
        End Set
    End Property

    Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property

    Private _FINPRF As Decimal
    Public Property FINPRF() As Decimal
        Get
            Return _FINPRF
        End Get
        Set(ByVal value As Decimal)
            _FINPRF = value
        End Set
    End Property


    Private _FFNPRF As Decimal
    Public Property FFNPRF() As Decimal
        Get
            Return _FFNPRF
        End Get
        Set(ByVal value As Decimal)
            _FFNPRF = value
        End Set
    End Property



    Private _PSETA As String = ""
    Public Property PSETA() As String
        Get
            Return _PSETA
        End Get
        Set(ByVal value As String)
            _PSETA = value
        End Set
    End Property

    Private _PSETD As String = ""
    Public Property PSETD() As String
        Get
            Return _PSETD
        End Get
        Set(ByVal value As String)
            _PSETD = value
        End Set
    End Property

    Private _PSATD As String = ""
    Public Property PSATD() As String
        Get
            Return _PSATD
        End Get
        Set(ByVal value As String)
            _PSATD = value
        End Set
    End Property



    Private _PNFOB As Decimal = 0
    Public Property PNFOB() As Decimal
        Get
            Return _PNFOB
        End Get
        Set(ByVal value As Decimal)
            _PNFOB = value
        End Set
    End Property

    Private _PNFLETE As Decimal = 0
    Public Property PNFLETE() As Decimal
        Get
            Return _PNFLETE
        End Get
        Set(ByVal value As Decimal)
            _PNFLETE = value
        End Set
    End Property


    Private _PNSEGURO As Decimal = 0
    Public Property PNSEGURO() As Decimal
        Get
            Return _PNSEGURO
        End Get
        Set(ByVal value As Decimal)
            _PNSEGURO = value
        End Set
    End Property


    Private _PNCIF As Decimal = 0
    Public Property PNCIF() As Decimal
        Get
            Return _PNCIF
        End Get
        Set(ByVal value As Decimal)
            _PNCIF = value
        End Set
    End Property


    Private _PNFLAG_REGISTRO As Int32 = 0
    Public Property PNFLAG_REGISTRO() As Int32
        Get
            Return _PNFLAG_REGISTRO
        End Get
        Set(ByVal value As Int32)
            _PNFLAG_REGISTRO = value
        End Set
    End Property
    Public Property NRITEM() As Decimal
        Get
            Return _NRITEM
        End Get
        Set(ByVal value As Decimal)
            _NRITEM = value
        End Set
    End Property


    Private _NRRUBR As Decimal
    Public Property NRRUBR() As Decimal
        Get
            Return _NRRUBR
        End Get
        Set(ByVal value As Decimal)
            _NRRUBR = value
        End Set
    End Property


    Private _PNNMOS As Decimal
    Public Property PNNMOS() As Decimal
        Get
            Return _PNNMOS
        End Get
        Set(ByVal value As Decimal)
            _PNNMOS = value
        End Set
    End Property

    Private _PSBUSQUEDA As String
    Public Property PSBUSQUEDA() As String
        Get
            Return _PSBUSQUEDA
        End Get
        Set(ByVal value As String)
            _PSBUSQUEDA = value
        End Set
    End Property


    Private _CUNDMD As String
    Public Property CUNDMD() As String
        Get
            Return _CUNDMD
        End Get
        Set(ByVal value As String)
            _CUNDMD = value
        End Set
    End Property
    Private _NGUICL As String
    Public Property NGUICL() As String
        Get
            Return _NGUICL
        End Get
        Set(ByVal value As String)
            _NGUICL = value
        End Set
    End Property


    Private _NGUIRN As Decimal
    Public Property NGUIRN() As Decimal
        Get
            Return _NGUIRN
        End Get
        Set(ByVal value As Decimal)
            _NGUIRN = value
        End Set
    End Property

    Private _CSRVC As Decimal
    Public Property CSRVC() As Decimal
        Get
            Return _CSRVC
        End Get
        Set(ByVal value As Decimal)
            _CSRVC = value
        End Set
    End Property

    Private _NORCCL As String
    Public Property NORCCL() As String
        Get
            Return _NORCCL
        End Get
        Set(ByVal value As String)
            _NORCCL = value
        End Set
    End Property


    Private _STPODP As String
    ''' <summary>
    '''Flag. Tipo de Deposito
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property STPODP() As String
        Get
            Return _STPODP
        End Get
        Set(ByVal value As String)
            _STPODP = value
        End Set
    End Property


    Private _NSLCSR As Decimal
    ''' <summary>
    ''' Num Solicitud de Servicio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NSLCSR() As Decimal
        Get
            Return _NSLCSR
        End Get
        Set(ByVal value As Decimal)
            _NSLCSR = value
        End Set
    End Property


    Private _NORDSR As Decimal
    ''' <summary>
    ''' Num Orden Servicio 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NORDSR() As Decimal
        Get
            Return _NORDSR
        End Get
        Set(ByVal value As Decimal)
            _NORDSR = value
        End Set
    End Property


    Private _CTPALJ As String
    ''' <summary>
    '''  Tipo de Almacenaje
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CTPALJ() As String
        Get
            Return _CTPALJ
        End Get
        Set(ByVal value As String)
            _CTPALJ = value
        End Set
    End Property

    Private _CTPODC As Integer = 0
    Public Property CTPODC() As Integer
        Get
            Return _CTPODC
        End Get
        Set(ByVal value As Integer)
            _CTPODC = value
        End Set
    End Property

    Private _FINGAL As String
    Public Property FINGAL() As String
        Get
            Return _FINGAL
        End Get
        Set(ByVal value As String)
            _FINGAL = value
        End Set
    End Property
    Private _FSLDAL As String
    Public Property FSLDAL() As String
        Get
            Return _FSLDAL
        End Get
        Set(ByVal value As String)
            _FSLDAL = value
        End Set
    End Property

    Private _FREFFW As String
    Public Property FREFFW() As String
        Get
            Return _FREFFW
        End Get
        Set(ByVal value As String)
            _FREFFW = value
        End Set
    End Property

    Private _FSLFFW As String
    Public Property FSLFFW() As String
        Get
            Return _FSLFFW
        End Get
        Set(ByVal value As String)
            _FSLFFW = value
        End Set
    End Property

    Private _QPSOTT As Double = 0D
    Public Property QPSOTT() As Double
        Get
            Return _QPSOTT
        End Get
        Set(ByVal value As Double)
            _QPSOTT = value
        End Set
    End Property

    Private _QVOLMR As Double = 0D
    Public Property QVOLMR() As Double
        Get
            Return _QVOLMR
        End Get
        Set(ByVal value As Double)
            _QVOLMR = value
        End Set
    End Property

    Private _QARMTS As String
    Public Property QARMTS() As String
        Get
            Return _QARMTS
        End Get
        Set(ByVal value As String)
            _QARMTS = value
        End Set
    End Property
    Private _FPRCSO As Double
    Public Property FPRCSO() As Double
        Get
            Return _FPRCSO
        End Get
        Set(ByVal value As Double)
            _FPRCSO = value
        End Set
    End Property
    Private _NGRPRV As String
    Public Property NGRPRV() As String
        Get
            Return _NGRPRV
        End Get
        Set(ByVal value As String)
            _NGRPRV = value
        End Set
    End Property
    Private _MEDIOENVIO As Decimal
    Public Property MEDIOENVIO() As Decimal
        Get
            Return _MEDIOENVIO
        End Get
        Set(ByVal value As Decimal)
            _MEDIOENVIO = value
        End Set
    End Property


    Private _DESCWB As String = ""
    Public Property DESCWB() As String
        Get
            Return _DESCWB
        End Get
        Set(ByVal value As String)
            _DESCWB = value
        End Set
    End Property
    Private _TUBRFR As String = ""
    Public Property TUBRFR() As String
        Get
            Return _TUBRFR
        End Get
        Set(ByVal value As String)
            _TUBRFR = value
        End Set
    End Property
    Private _QREFFW As String = ""
    Public Property QREFFW() As String
        Get
            Return _QREFFW
        End Get
        Set(ByVal value As String)
            _QREFFW = value
        End Set
    End Property
    Private _TIPBTO As String = ""
    Public Property TIPBTO() As String
        Get
            Return _TIPBTO
        End Get
        Set(ByVal value As String)
            _TIPBTO = value
        End Set
    End Property
    Private _QPSOBL As String = ""
    Public Property QPSOBL() As String
        Get
            Return _QPSOBL
        End Get
        Set(ByVal value As String)
            _QPSOBL = value
        End Set
    End Property
    Private _TUNPSO As String = ""
    Public Property TUNPSO() As String
        Get
            Return _TUNPSO
        End Get
        Set(ByVal value As String)
            _TUNPSO = value
        End Set
    End Property
    Private _QVLBTO As String = ""
    Public Property QVLBTO() As String
        Get
            Return _QVLBTO
        End Get
        Set(ByVal value As String)
            _QVLBTO = value
        End Set
    End Property
    Private _TUNVOL As String = ""
    Public Property TUNVOL() As String
        Get
            Return _TUNVOL
        End Get
        Set(ByVal value As String)
            _TUNVOL = value
        End Set
    End Property
    Private _QAROCP As String = ""
    Public Property QAROCP() As String
        Get
            Return _QAROCP
        End Get
        Set(ByVal value As String)
            _QAROCP = value
        End Set
    End Property
    Private _CTPALMT As String = ""
    Public Property CTPALMT() As String
        Get
            Return _CTPALMT
        End Get
        Set(ByVal value As String)
            _CTPALMT = value
        End Set
    End Property


    Private _TCMPDV As String
    Public Property TCMPDV() As String
        Get
            Return _TCMPDV
        End Get
        Set(ByVal value As String)
            _TCMPDV = value
        End Set
    End Property

    Public Property SRBAFD() As String
        Get
            Return _SRBAFD
        End Get
        Set(ByVal value As String)
            _SRBAFD = value
        End Set
    End Property
    Public Property DESTAR() As String
        Get
            Return _DESTAR
        End Get
        Set(ByVal value As String)
            _DESTAR = value
        End Set
    End Property

    Public Property SSNCRG() As String
        Get
            Return _SSNCRG
        End Get
        Set(ByVal value As String)
            _SSNCRG = value
        End Set
    End Property

    Public Property SSNCRG_D() As String
        Get
            Return _SSNCRG_D
        End Get
        Set(ByVal value As String)
            _SSNCRG_D = value
        End Set
    End Property

    Public Property TCMZNA() As String
        Get
            Return _TCMZNA
        End Get
        Set(ByVal value As String)
            _TCMZNA = value
        End Set
    End Property

    Public Property TALMC() As String
        Get
            Return _TALMC
        End Get
        Set(ByVal value As String)
            _TALMC = value
        End Set
    End Property

    Public Property TCMPAL() As String
        Get
            Return _TCMPAL
        End Get
        Set(ByVal value As String)
            _TCMPAL = value
        End Set
    End Property

    Public Property FECSERV_INI() As Double
        Get
            Return _FECSERV_INI
        End Get
        Set(ByVal value As Double)
            _FECSERV_INI = value
        End Set
    End Property

    Public Property FECSERV_FIN() As Double
        Get
            Return _FECSERV_FIN
        End Get
        Set(ByVal value As Double)
            _FECSERV_FIN = value
        End Set
    End Property

    Private _CCLNT_DESC As String
    Public Property CCLNT_DESC() As String
        Get
            Return _CCLNT_DESC
        End Get
        Set(ByVal value As String)
            _CCLNT_DESC = value
        End Set
    End Property
    Private _TIPO_PLANTA As String
    Public Property TIPO_PLANTA() As String
        Get
            Return _TIPO_PLANTA
        End Get
        Set(ByVal value As String)
            _TIPO_PLANTA = value
        End Set
    End Property

    Private _TIPO_REV As String = ""
    Public Property TIPO_REV() As String
        Get
            Return _TIPO_REV
        End Get
        Set(ByVal value As String)
            _TIPO_REV = value
        End Set
    End Property

    Private _CRGVTA As String = ""
    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property

    Public Property TPRVCL() As String
        Get
            Return _TPRVCL
        End Get
        Set(ByVal value As String)
            _TPRVCL = value
        End Set
    End Property
    Public Property TDITES() As String
        Get
            Return _TDITES
        End Get
        Set(ByVal value As String)
            _TDITES = value
        End Set
    End Property

    Public Property NDOCEM() As String
        Get
            Return _NDOCEM
        End Get
        Set(ByVal value As String)
            _NDOCEM = value
        End Set
    End Property

    Public Property CMEDTR() As String
        Get
            Return _CMEDTR
        End Get
        Set(ByVal value As String)
            _CMEDTR = value
        End Set
    End Property
   

    Public Property TCANAL() As String
        Get
            Return _TCANAL
        End Get
        Set(ByVal value As String)
            _TCANAL = value
        End Set
    End Property

    Public Property TNMAGC() As String
        Get
            Return _TNMAGC
        End Get
        Set(ByVal value As String)
            _TNMAGC = value
        End Set
    End Property


    Public Property REGIMEN() As String
        Get
            Return _REGIMEN
        End Get
        Set(ByVal value As String)
            _REGIMEN = value
        End Set
    End Property


    Public Property DESPACHO() As String
        Get
            Return _DESPACHO
        End Get
        Set(ByVal value As String)
            _DESPACHO = value
        End Set
    End Property


    Public Property TNRODU() As String
        Get
            Return _TNRODU
        End Get
        Set(ByVal value As String)
            _TNRODU = value
        End Set
    End Property


    Public Property FOB() As Decimal
        Get
            Return _FOB
        End Get
        Set(ByVal value As Decimal)
            _FOB = value
        End Set
    End Property

    Public Property FLETE() As Decimal
        Get
            Return _FLETE
        End Get
        Set(ByVal value As Decimal)
            _FLETE = value
        End Set
    End Property


    Public Property SEGURO() As Decimal
        Get
            Return _SEGURO
        End Get
        Set(ByVal value As Decimal)
            _SEGURO = value
        End Set
    End Property

    Public Property CIF() As Decimal
        Get
            Return _CIF
        End Get
        Set(ByVal value As Decimal)
            _CIF = value
        End Set
    End Property

    Public Property NROS_REVISION() As String
        Get
            Return _NROS_REVISION
        End Get
        Set(ByVal value As String)
            _NROS_REVISION = value
        End Set
    End Property

    Private _STPTRA As String
    Public Property STPTRA() As String
        Get
            Return _STPTRA
        End Get
        Set(ByVal value As String)
            _STPTRA = value
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


    Public Property NDCCTC() As Decimal
        Get
            Return _NDCCTC
        End Get
        Set(ByVal value As Decimal)
            _NDCCTC = value
        End Set
    End Property


    Public Property FDCCTC() As Decimal
        Get
            Return _FDCCTC
        End Get
        Set(ByVal value As Decimal)
            _FDCCTC = value
        End Set
    End Property

    Public Property LIBERAR() As String
        Get
            Return _LIBERAR
        End Get
        Set(ByVal value As String)
            _LIBERAR = value
        End Set
    End Property

    Public Property TABTPD() As String
        Get
            Return _TABTPD
        End Get
        Set(ByVal value As String)
            _TABTPD = value
        End Set
    End Property

    Private _NRCTCL As Decimal
    Public Property NRCTCL() As Decimal
        Get
            Return _NRCTCL
        End Get
        Set(ByVal value As Decimal)
            _NRCTCL = value
        End Set
    End Property

    Public Property NTRMNC() As String
        Get
            Return _NTRMNC
        End Get
        Set(ByVal value As String)
            _NTRMNC = value
        End Set
    End Property


    Private _Provisionado As Integer
    Public Property Provisionado() As Integer
        Get
            Return _Provisionado
        End Get
        Set(ByVal value As Integer)
            _Provisionado = value
        End Set
    End Property

    Public Property FTIPOR() As String
        Get
            Return _FTIPOR
        End Get
        Set(ByVal value As String)
            _FTIPOR = value
        End Set
    End Property

    Public Property TTPOMR() As String
        Get
            Return _TTPOMR
        End Get
        Set(ByVal value As String)
            _TTPOMR = value
        End Set
    End Property

    '<[AHM]>
    ''TIPO DE SERVICIO
    Private _CDTSSP As String
    Public Property CDTSSP() As String
        Get
            Return _CDTSSP
        End Get
        Set(ByVal value As String)
            _CDTSSP = value
        End Set
    End Property

    ''UNIDAD PRODUCTIVA
    Private _CDUPSP As String
    Public Property CDUPSP() As String
        Get
            Return _CDUPSP
        End Get
        Set(ByVal value As String)
            _CDUPSP = value
        End Set
    End Property

    ''TIPO DE ACTIVO
    Private _PRCODI As String
    Public Property PRCODI() As String
        Get
            Return _PRCODI
        End Get
        Set(ByVal value As String)
            _PRCODI = value
        End Set
    End Property


    
    '</[AHM]>
 
#Region "TARIFA FIJA"

    Private _NDIAPL As Integer = 0
    Public Property NDIAPL() As Integer
        Get
            Return _NDIAPL
        End Get
        Set(ByVal value As Integer)
            _NDIAPL = value
        End Set
    End Property

    Private _NRTFSV_F As Double = 0
    Property NRTFSV_F() As Double
        Get
            Return _NRTFSV_F
        End Get
        Set(ByVal value As Double)
            _NRTFSV_F = value
        End Set
    End Property

 
    Private _QATNAN_F As Double = 0
    Property QATNAN_F() As Double
        Get
            Return _QATNAN_F
        End Get
        Set(ByVal value As Double)
            _QATNAN_F = value
        End Set
    End Property

    Private _QATNRL_F As Double = 0
    Property QATNRL_F() As Double
        Get
            Return _QATNRL_F
        End Get
        Set(ByVal value As Double)
            _QATNRL_F = value
        End Set
    End Property

    Private _IVLSRV_F As Decimal = 0D
    Public Property IVLSRV_F() As Decimal
        Get
            Return _IVLSRV_F
        End Get
        Set(ByVal value As Decimal)
            _IVLSRV_F = value
        End Set
    End Property

    'Tarifa referencial
    Private _CDTREF As Decimal = 0D
    Public Property CDTREF() As Decimal
        Get
            Return _CDTREF
        End Get
        Set(ByVal value As Decimal)
            _CDTREF = value
        End Set
    End Property


#End Region



    'JM

    Private _ISRVTI As Decimal
    Public Property ISRVTI() As Decimal
        Get
            Return _ISRVTI
        End Get
        Set(ByVal value As Decimal)
            _ISRVTI = value
        End Set
    End Property

    Private _ISRVTI_F As Decimal
    Public Property ISRVTI_F() As Decimal
        Get
            Return _ISRVTI_F
        End Get
        Set(ByVal value As Decimal)
            _ISRVTI_F = value
        End Set
    End Property

    Private _CENCOS As Integer
    Public Property CENCOS() As Integer
        Get
            Return _CENCOS
        End Get
        Set(ByVal value As Integer)
            _CENCOS = value
        End Set
    End Property


    Private _CENCO2 As Integer
    Public Property CENCO2() As Integer
        Get
            Return _CENCO2
        End Get
        Set(ByVal value As Integer)
            _CENCO2 = value
        End Set
    End Property

    Private _CCNBNS As String
    Public Property CCNBNS() As String
        Get
            Return _CCNBNS
        End Get
        Set(ByVal value As String)
            _CCNBNS = value
        End Set
    End Property

    Private _DOCVLR As String = ""
    Public Property DOCVLR() As String
        Get
            Return _DOCVLR
        End Get
        Set(ByVal value As String)
            _DOCVLR = value
        End Set
    End Property
    Private _NROVLR As Decimal = 0
    Public Property NROVLR() As Decimal
        Get
            Return _NROVLR
        End Get
        Set(ByVal value As Decimal)
            _NROVLR = value
        End Set
    End Property

    Public Property NGUIRS() As String
        Get
            Return _NGUIRS
        End Get
        Set(ByVal value As String)
            _NGUIRS = value
        End Set
    End Property


    Public Property FECREV_INI() As Decimal
        Get
            Return _FECREV_INI
        End Get
        Set(ByVal value As Decimal)
            _FECREV_INI = value
        End Set
    End Property
    Public Property FECREV_FIN() As Decimal
        Get
            Return _FECREV_FIN
        End Get
        Set(ByVal value As Decimal)
            _FECREV_FIN = value
        End Set
    End Property
    Public Property LISTJSON() As String
        Get
            Return _LISTJSON
        End Get
        Set(ByVal value As String)
            _LISTJSON = value
        End Set
    End Property

    Public Property ESRECCARGA() As String
        Get
            Return _ESRECCARGA
        End Get
        Set(ByVal value As String)
            _ESRECCARGA = value
        End Set
    End Property

    Public Property IPRCDT() As Decimal
        Get
            Return _IPRCDT
        End Get
        Set(ByVal value As Decimal)
            _IPRCDT = value
        End Set
    End Property



End Class

