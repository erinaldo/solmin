Public Class Tarifa
    Private _NRTFSV As Double = 0
    Private _NRRNGO As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CSRVNV As Double = 0
    Private _CCNTCS As Double = 0

    Private _CCNBNS As String = ""

    Private _NRRUBR As Double = 0
    Private _CSCDSP As String = ""
    Private _CRGVTA As String = ""
    Private _CMNDA1 As Double = 0
    Private _NRSRRB As Double = 0
    Private _NRCTSL As Double = 0
    Private _CPLNDV As Double = 0
    Private _IVLSRV As Decimal = 0
    Private _FECINI As Double = 0
    Private _FECFIN As Double = 0
    Private _TOBS As String = ""
    Private _DESTAR As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _SESTRG As String = ""
    '-------------------------
    Private _MntTarifa As String = ""
    Private _DesConcepto As String = ""
    Private _CCLNFC As Double = 0
    Private _CCNCS1 As Double = 0 'String = ""
    Private _SFLZNP As String = ""
    Private _SFSANF As Double = 0 'String = ""
    Private _STSTRF As String = ""
    Private _SSCGST As String = ""
    Private _CMRCDR As String = ""
    Private _CTPOSR As String = ""
    Private _CTPSBS As String = ""
    Private _CFRMPG As Double = 0
    Private _SSGRCT As String = ""
    Private _CCMPSG As String = ""
    Private _NPLSGC As String = ""
    Private _QPRCS1 As Double = 0
    Private _QMRCDR As Double = 0
    Private _PMRCDR As Double = 0
    Private _VMRCDR As Double = 0
    Private _LMRCDR As Double = 0
    Private _TRFMRC As String = ""
    Private _CTPUNV As String = ""
    Private _CFRAPG As Double = 0
    Private _NORSRT As Double = 0
    Private _CUNDMD As String = ""
    Private _NTRMCR As String = ""
    Private _NTRMNL As String = ""
    Private _CCLNT As Double = 0
    Private _NRRELF As Double = 0
    Private _sNRTFSV As String = ""
    Private _TTPOMR As String = ""
    Private _CTPALM As String = ""

    Private _FTRTSG As String = ""

    Private _NCRRSR As Decimal = 0

    Private _MRGPOR As Double = 0
    Private _NLBFLT As Double = 0
    Private _APRBTF As String = ""
    Private _FCHAPR As Double = 0
    Private _OBSAPR As String = ""


    Public Property CTPALM() As String
        Get
            Return _CTPALM
        End Get
        Set(ByVal value As String)
            _CTPALM = value
        End Set
    End Property

    'azp
    Private _TSRVIN As String
    Public Property TSRVIN() As String
        Get
            Return _TSRVIN
        End Get
        Set(ByVal value As String)
            _TSRVIN = value
        End Set
    End Property

    'azp
    Public Property TTPOMR() As String
        Get
            Return _TTPOMR
        End Get
        Set(ByVal value As String)
            _TTPOMR = value
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
    'Private _VALCTE As String = ""
    'Public Property VALCTE() As String
    '    Get
    '        Return _VALCTE
    '    End Get
    '    Set(ByVal Value As String)
    '        _VALCTE = Value
    '    End Set
    'End Property
    Private _VALCTE As Decimal = 0
    Public Property VALCTE() As Decimal
        Get
            Return _VALCTE
        End Get
        Set(ByVal Value As Decimal)
            _VALCTE = Value
        End Set
    End Property

    Private _STPTRA As String = ""
    Public Property STPTRA() As String
        Get
            Return _STPTRA
        End Get
        Set(ByVal Value As String)
            _STPTRA = Value
        End Set
    End Property

    Public Property CCNBNS() As String
        Get
            Return _CCNBNS
        End Get
        Set(ByVal Value As String)
            _CCNBNS = Value
        End Set
    End Property


    Public Property MntTarifa() As String
        Get
            Return _MntTarifa
        End Get
        Set(ByVal Value As String)
            _MntTarifa = Value
        End Set
    End Property
    Public Property DesConcepto() As String
        Get
            Return _DesConcepto
        End Get
        Set(ByVal Value As String)
            _DesConcepto = Value
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

    Public Property DESTAR() As String
        Get
            Return _DESTAR
        End Get
        Set(ByVal Value As String)
            _DESTAR = Value
        End Set
    End Property

    Public Property TOBS() As String
        Get
            Return _TOBS
        End Get
        Set(ByVal Value As String)
            _TOBS = Value
        End Set
    End Property


    'Private _PRLBPG As Decimal
    'Public Property PRLBPG() As Decimal
    '    Get
    '        Return _PRLBPG
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PRLBPG = value
    '    End Set
    'End Property

    Private _PRLBPG As Double
    Public Property PRLBPG() As Double
        Get
            Return _PRLBPG
        End Get
        Set(ByVal value As Double)
            _PRLBPG = value
        End Set
    End Property


    'Private _NDIAPL As Decimal
    'Public Property NDIAPL() As Decimal
    '    Get
    '        Return _NDIAPL
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _NDIAPL = value
    '    End Set
    'End Property

    Private _NDIAPL As Double
    Public Property NDIAPL() As Double
        Get
            Return _NDIAPL
        End Get
        Set(ByVal value As Double)
            _NDIAPL = value
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

    'Public Property IVLSRV() As Double
    '    Get
    '        Return _IVLSRV
    '    End Get
    '    Set(ByVal Value As Double)
    '        _IVLSRV = Value
    '    End Set
    'End Property

    Public Property IVLSRV() As Decimal
        Get
            Return _IVLSRV
        End Get
        Set(ByVal Value As Decimal)
            _IVLSRV = Value
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

    Public Property NRCTSL() As Double
        Get
            Return _NRCTSL
        End Get
        Set(ByVal Value As Double)
            _NRCTSL = Value
        End Set
    End Property

    Public Property NRSRRB() As Double
        Get
            Return _NRSRRB
        End Get
        Set(ByVal Value As Double)
            _NRSRRB = Value
        End Set
    End Property

    Public Property CMNDA1() As Double
        Get
            Return _CMNDA1
        End Get
        Set(ByVal Value As Double)
            _CMNDA1 = Value
        End Set
    End Property

    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal Value As String)
            _CRGVTA = Value
        End Set
    End Property

    Public Property CSCDSP() As String
        Get
            Return _CSCDSP
        End Get
        Set(ByVal Value As String)
            _CSCDSP = Value
        End Set
    End Property

    Public Property NRRUBR() As Double
        Get
            Return _NRRUBR
        End Get
        Set(ByVal Value As Double)
            _NRRUBR = Value
        End Set
    End Property

    Public Property CSRVNV() As Double
        Get
            Return _CSRVNV
        End Get
        Set(ByVal Value As Double)
            _CSRVNV = Value
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

    Public Property NRRNGO() As Double
        Get
            Return _NRRNGO
        End Get
        Set(ByVal Value As Double)
            _NRRNGO = Value
        End Set
    End Property

    Public Property NRTFSV() As Double
        Get
            Return _NRTFSV
        End Get
        Set(ByVal Value As Double)
            _NRTFSV = Value
        End Set
    End Property

    Private _FAPLBR As String
    Public Property FAPLBR() As String
        Get
            Return _FAPLBR
        End Get
        Set(ByVal value As String)
            _FAPLBR = value
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

    Public Property CCLNFC() As Double
        Get
            Return _CCLNFC
        End Get
        Set(ByVal value As Double)
            If _CCLNFC = Value Then
                Return
            End If
            _CCLNFC = Value
        End Set
    End Property
    Public Property CCNCS1() As Double
        Get
            Return _CCNCS1
        End Get
        Set(ByVal value As Double)
            If _CCNCS1 = value Then
                Return
            End If
            _CCNCS1 = value
        End Set
    End Property

    Public Property SFLZNP() As String
        Get
            Return _SFLZNP
        End Get
        Set(ByVal value As String)
            If _SFLZNP = Value Then
                Return
            End If
            _SFLZNP = Value
        End Set
    End Property
    Public Property SFSANF() As Double
        Get
            Return _SFSANF
        End Get
        Set(ByVal value As Double)
            If _SFSANF = value Then
                Return
            End If
            _SFSANF = value
        End Set
    End Property
    Public Property STSTRF() As String
        Get
            Return _STSTRF
        End Get
        Set(ByVal value As String)
            If _STSTRF = Value Then
                Return
            End If
            _STSTRF = Value
        End Set
    End Property
    Public Property SSCGST() As String
        Get
            Return _SSCGST
        End Get
        Set(ByVal value As String)
            If _SSCGST = Value Then
                Return
            End If
            _SSCGST = Value
        End Set
    End Property
    Public Property CMRCDR() As String
        Get
            Return _CMRCDR
        End Get
        Set(ByVal value As String)
            If _CMRCDR = Value Then
                Return
            End If
            _CMRCDR = Value
        End Set
    End Property
    Public Property CTPOSR() As String
        Get
            Return _CTPOSR
        End Get
        Set(ByVal value As String)
            If _CTPOSR = Value Then
                Return
            End If
            _CTPOSR = Value
        End Set
    End Property
    Public Property CTPSBS() As String
        Get
            Return _CTPSBS
        End Get
        Set(ByVal value As String)
            If _CTPSBS = Value Then
                Return
            End If
            _CTPSBS = Value
        End Set
    End Property
    Public Property CFRMPG() As Double
        Get
            Return _CFRMPG
        End Get
        Set(ByVal value As Double)
            If _CFRMPG = value Then
                Return
            End If
            _CFRMPG = value
        End Set
    End Property
    Public Property SSGRCT() As String
        Get
            Return _SSGRCT
        End Get
        Set(ByVal value As String)
            If _SSGRCT = Value Then
                Return
            End If
            _SSGRCT = Value
        End Set
    End Property
    Public Property CCMPSG() As String
        Get
            Return _CCMPSG
        End Get
        Set(ByVal value As String)
            If _CCMPSG = Value Then
                Return
            End If
            _CCMPSG = Value
        End Set
    End Property
    Public Property NPLSGC() As String
        Get
            Return _NPLSGC
        End Get
        Set(ByVal value As String)
            If _NPLSGC = Value Then
                Return
            End If
            _NPLSGC = Value
        End Set
    End Property
    Public Property QPRCS1() As Double
        Get
            Return _QPRCS1
        End Get
        Set(ByVal value As Double)
            If _QPRCS1 = value Then
                Return
            End If
            _QPRCS1 = value
        End Set
    End Property
    Public Property QMRCDR() As Double
        Get
            Return _QMRCDR
        End Get
        Set(ByVal value As Double)
            If _QMRCDR = Value Then
                Return
            End If
            _QMRCDR = Value
        End Set
    End Property
    Public Property PMRCDR() As Double
        Get
            Return _PMRCDR
        End Get
        Set(ByVal value As Double)
            If _PMRCDR = Value Then
                Return
            End If
            _PMRCDR = Value
        End Set
    End Property
    Public Property VMRCDR() As Double
        Get
            Return _VMRCDR
        End Get
        Set(ByVal value As Double)
            If _VMRCDR = Value Then
                Return
            End If
            _VMRCDR = Value
        End Set
    End Property
    Public Property LMRCDR() As Double
        Get
            Return _LMRCDR
        End Get
        Set(ByVal value As Double)
            If _LMRCDR = Value Then
                Return
            End If
            _LMRCDR = Value
        End Set
    End Property
    Public Property TRFMRC() As String
        Get
            Return _TRFMRC
        End Get
        Set(ByVal value As String)
            If _TRFMRC = Value Then
                Return
            End If
            _TRFMRC = Value
        End Set
    End Property
    Public Property CTPUNV() As String
        Get
            Return _CTPUNV
        End Get
        Set(ByVal value As String)
            If _CTPUNV = Value Then
                Return
            End If
            _CTPUNV = Value
        End Set
    End Property
    Public Property CFRAPG() As Double
        Get
            Return _CFRAPG
        End Get
        Set(ByVal value As Double)
            If _CFRAPG = value Then
                Return
            End If
            _CFRAPG = value
        End Set
    End Property
    Public Property NORSRT() As Double
        Get
            Return _NORSRT
        End Get
        Set(ByVal value As Double)
            If _NORSRT = Value Then
                Return
            End If
            _NORSRT = Value
        End Set
    End Property

    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            If _NTRMCR = value Then
                Return
            End If
            _NTRMCR = value
        End Set
    End Property

    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            If _NTRMNL = value Then
                Return
            End If
            _NTRMNL = value
        End Set
    End Property

    Public Property CCLNT() As Double
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Double)
            If _CCLNT = value Then
                Return
            End If
            _CCLNT = value
        End Set
    End Property

    Public Property NRRELF() As Double
        Get
            Return _NRRELF
        End Get
        Set(ByVal value As Double)
            If _NRRELF = Value Then
                Return
            End If
            _NRRELF = Value
        End Set
    End Property

    Public ReadOnly Property COD_SERV() As String
        Get
            Return NRRUBR.ToString & " - " & NRSRRB.ToString
        End Get

    End Property

    Public Property sNRTFSV() As String
        Get
            Return _sNRTFSV
        End Get
        Set(ByVal value As String)
            If _sNRTFSV = value Then
                Return
            End If
            _sNRTFSV = value
        End Set
    End Property

 
    Private _NOMSER As String = ""
    Public Property NOMSER() As String
        Get
            Return _NOMSER
        End Get
        Set(ByVal value As String)
            If _NOMSER = value Then
                Return
            End If
            _NOMSER = value
        End Set
    End Property

    Private _TSGNMN As String = ""
    Public Property TSGNMN() As String
        Get
            Return _TSGNMN
        End Get
        Set(ByVal value As String)
            If _TSGNMN = value Then
                Return
            End If
            _TSGNMN = value
        End Set
    End Property

    Private _CDTREF As Double = 0
    Public Property CDTREF() As Double
        Get
            Return _CDTREF
        End Get
        Set(ByVal value As Double)
            If _CDTREF = value Then
                Return
            End If
            _CDTREF = value
        End Set
    End Property

    Private _TALMC As String = ""
    Public Property TALMC() As String
        Get
            Return _TALMC
        End Get
        Set(ByVal value As String)
            If _TALMC = value Then
                Return
            End If
            _TALMC = value
        End Set
    End Property

    Private _TIPMER As String = ""
    Public Property TIPMER() As String
        Get
            Return _TIPMER
        End Get
        Set(ByVal value As String)
            If _TIPMER = value Then
                Return
            End If
            _TIPMER = value
        End Set
    End Property


    Private _DIACOR As Int32 = 0
    Public Property DIACOR() As Int32
        Get
            Return _DIACOR
        End Get
        Set(ByVal value As Int32)
            If _DIACOR = value Then
                Return
            End If
            _DIACOR = value
        End Set
    End Property
    '<[AHM]>
    Private _CDSDSP As String = ""
    Public Property CDSDSP() As String
        Get
            Return _CDSDSP
        End Get
        Set(ByVal value As String)
            If _CDSDSP = value Then
                Return
            End If
            _CDSDSP = value
        End Set
    End Property

    Private _CDSRSP As String = ""
    Public Property CDSRSP() As String
        Get
            Return _CDSRSP
        End Get
        Set(ByVal value As String)
            If _CDSRSP = value Then
                Return
            End If
            _CDSRSP = value
        End Set
    End Property

    Public _CDTSSP As String = ""
    Public Property CDTSSP() As String
        Get
            Return _CDTSSP
        End Get
        Set(ByVal value As String)
            If _CDTSSP = value Then
                Return
            End If
            _CDTSSP = value
        End Set
    End Property

    Public _CDTASP As String = ""
    Public Property CDTASP() As String
        Get
            Return _CDTASP
        End Get
        Set(ByVal value As String)
            If _CDTASP = value Then
                Return
            End If
            _CDTASP = value
        End Set
    End Property

    Public _CDSPSP As String = ""
    Public Property CDSPSP() As String
        Get
            Return _CDSPSP
        End Get
        Set(ByVal value As String)
            If _CDSPSP = value Then
                Return
            End If
            _CDSPSP = value
        End Set
    End Property

    Public _CDUPSP As String = ""
    Public Property CDUPSP() As String
        Get
            Return _CDUPSP
        End Get
        Set(ByVal value As String)
            If _CDUPSP = value Then
                Return
            End If
            _CDUPSP = value
        End Set
    End Property

    Public _CDSCSP As String = ""

    Public Property CDSCSP() As String
        Get
            Return _CDSCSP
        End Get
        Set(ByVal value As String)
            If _CDSCSP = value Then
                Return
            End If
            _CDSCSP = value
        End Set
    End Property
    '</[AHM]>

    'RCS-HUNDRED-INICIO
    Private _CENCOS As Double

    Public Property CENCOS() As Double
        Get
            Return _CENCOS
        End Get
        Set(ByVal value As Double)
            _CENCOS = value
        End Set
    End Property

    Private _CENCO2 As Double

    Public Property CENCO2() As Double
        Get
            Return _CENCO2
        End Get
        Set(ByVal value As Double)
            _CENCO2 = value
        End Set
    End Property

    Private _ISRVTI As Double
    Private _CENCO1 As Double
    Private _CCNTBN As Double
    Private _CCNTB1 As Double
    Private _CENCO3 As Double
    Private _CPATIN As Double
    Private _CTTRAN As String
    Private _CTIPCG As String

    Public Property ISRVTI() As Double
        Get
            Return _ISRVTI
        End Get
        Set(ByVal value As Double)
            _ISRVTI = value
        End Set
    End Property

    Public Property CENCO1() As Double
        Get
            Return _CENCO1
        End Get
        Set(ByVal value As Double)
            _CENCO1 = value
        End Set
    End Property

    Public Property CCNTBN() As Double
        Get
            Return _CCNTBN
        End Get
        Set(ByVal value As Double)
            _CCNTBN = value
        End Set
    End Property

    Public Property CCNTB1() As Double
        Get
            Return _CCNTB1
        End Get
        Set(ByVal value As Double)
            _CCNTB1 = value
        End Set
    End Property

    Public Property CENCO3() As Double
        Get
            Return _CENCO3
        End Get
        Set(ByVal value As Double)
            _CENCO3 = value
        End Set
    End Property

    Public Property CPATIN() As Double
        Get
            Return _CPATIN
        End Get
        Set(ByVal value As Double)
            _CPATIN = value
        End Set
    End Property

    Public Property CTTRAN() As String
        Get
            Return _CTTRAN
        End Get
        Set(ByVal value As String)
            _CTTRAN = value
        End Set
    End Property

    Public Property CTIPCG() As String
        Get
            Return _CTIPCG
        End Get
        Set(ByVal value As String)
            _CTIPCG = value
        End Set
    End Property

    'RCS-HUNDRED-FIN

    'JM
    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property


    Private _CEBE_OR_T_DESC As String
    Public Property CEBE_OR_T_DESC() As String
        Get
            Return _CEBE_OR_T_DESC
        End Get
        Set(ByVal value As String)
            _CEBE_OR_T_DESC = value
        End Set
    End Property

    Private _CECO_OR_P_DESC As String
    Public Property CECO_OR_P_DESC() As String
        Get
            Return _CECO_OR_P_DESC
        End Get
        Set(ByVal value As String)
            _CECO_OR_P_DESC = value
        End Set
    End Property

    Private _CEBE_OR_P_DESC As String
    Public Property CEBE_OR_P_DESC() As String
        Get
            Return _CEBE_OR_P_DESC
        End Get
        Set(ByVal value As String)
            _CEBE_OR_P_DESC = value
        End Set
    End Property

    Private _CECO_OR_T_DESC As String
    Public Property CECO_OR_T_DESC() As String
        Get
            Return _CECO_OR_T_DESC
        End Get
        Set(ByVal value As String)
            _CECO_OR_T_DESC = value
        End Set
    End Property

    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    Private _CPLNFC As String
    ''' <summary>
    ''' Planta Factura
    ''' </summary>
    Public Property CPLNFC() As String
        Get
            Return _CPLNFC
        End Get
        Set(ByVal value As String)
            _CPLNFC = value
        End Set
    End Property

    Private _FTCLNT As String
    ''' <summary>
    ''' Tipo Cliente
    ''' </summary>
    Public Property FTCLNT() As String
        Get
            Return _FTCLNT
        End Get
        Set(ByVal value As String)
            _FTCLNT = value
        End Set
    End Property

    Private _SECTCCLNT As String
    ''' <summary>
    ''' Sector
    ''' </summary>
    Public Property SECTCCLNT() As String
        Get
            Return _SECTCCLNT
        End Get
        Set(ByVal value As String)
            _SECTCCLNT = value
        End Set
    End Property

    Private _CEBEP_D As String
    ''' <summary>
    ''' Descripción CeBe Propio
    ''' </summary>
    Public Property CEBEP_D() As String
        Get
            Return _CEBEP_D
        End Get
        Set(ByVal value As String)
            _CEBEP_D = value
        End Set
    End Property

    Private _CEBET_D As String
    ''' <summary>
    ''' Descripción CeBe  Tercero
    ''' </summary>
    Public Property CEBET_D() As String
        Get
            Return _CEBET_D
        End Get
        Set(ByVal value As String)
            _CEBET_D = value
        End Set
    End Property

    Private _CECOP_D As String
    ''' <summary>
    ''' Descripción CeCo Propio
    ''' </summary>
    Public Property CECOP_D() As String
        Get
            Return _CECOP_D
        End Get
        Set(ByVal value As String)
            _CECOP_D = value
        End Set
    End Property

    Private _CECOT_D As String
    ''' <summary>
    ''' Descripción CeCo Tercero
    ''' </summary>
    Public Property CECOT_D() As String
        Get
            Return _CECOT_D
        End Get
        Set(ByVal value As String)
            _CECOT_D = value
        End Set
    End Property

    Public Property FTRTSG() As String
        Get
            Return _FTRTSG
        End Get
        Set(ByVal value As String)
            _FTRTSG = value
        End Set
    End Property

    Public Property NCRRSR() As Decimal
        Get
            Return _NCRRSR
        End Get
        Set(ByVal value As Decimal)
            _NCRRSR = value
        End Set
    End Property
    '

    '---------------------------
    'nuevo
    Public Property MRGPOR() As Double
        Get
            Return _MRGPOR
        End Get
        Set(ByVal value As Double)
            If _MRGPOR = value Then
                Return
            End If
            _MRGPOR = value
        End Set
    End Property

    Public Property NLBFLT() As Double
        Get
            Return _NLBFLT
        End Get
        Set(ByVal value As Double)
            If _NLBFLT = value Then
                Return
            End If
            _NLBFLT = value
        End Set
    End Property



    Public Property APRBTF() As String
        Get
            Return _APRBTF
        End Get
        Set(ByVal value As String)
            _APRBTF = value
        End Set
    End Property

    Public Property FCHAPR() As Double
        Get
            Return _FCHAPR
        End Get
        Set(ByVal value As Double)
            If _FCHAPR = value Then
                Return
            End If
            _FCHAPR = value
        End Set
    End Property

    Public Property OBSAPR() As String
        Get
            Return _OBSAPR
        End Get
        Set(ByVal value As String)
            _OBSAPR = value
        End Set
    End Property






    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
End Class
