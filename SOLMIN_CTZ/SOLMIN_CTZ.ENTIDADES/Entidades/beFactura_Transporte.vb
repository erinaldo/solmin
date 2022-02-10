Public Class beFactura_Transporte

#Region "Atributo"
    Private _NOPRCN As Int64 = 0
    Private _NGUITR As Int64 = 0
    Private _FGUITR As Int64 = 0
    Private _FGUITR_S As String = ""
    Private _NMNFCR As Int64 = 0
    Private _CTRSPT As Int64 = 0
    Private _TCMTRT As String = ""
    Private _NPLVHT As String = ""
    Private _CBRCNT As String = ""
    Private _TDSTRT As String = ""
    Private _QCNDTG As Double = 0
    Private _ISRVGU As Double = 0
    Private _CMNDGU As String = ""
    Private _TOTSER As Double = 0
    Private _PBRTOR As Double = 0
    Private _QBLORG As Double = 0
    Private _QKLMRC As Double = 0

    Private _NORSRT As Int64 = 0
    Private _NRUCFC As Int64 = 0
    Private _NLBTEL As Int64 = 0
    Private _CCLNT As Int64 = 0
    Private _TCMPCL As String = ""
    Private _CCLNFC As Int64 = 0
    Private _TCMPFC As String = ""
    Private _TDRCFC As String = ""
    Private _CMRCDR As String = ""
    Private _TCMRCD As String = ""
    Private _CTPOSR As String = ""
    Private _TCMTPS As String = ""
    Private _CTPSBS As String = ""
    Private _TCMSBS As String = ""
    Private _SRPTRM As String = ""
    Private _RUTA As String = ""
    Private _CMNLQT As String = ""
    Private _TSGNMN_S As String = ""
    Private _TSGNMN_L As String = ""
    Private _CUNDSR As String = ""
    Private _ILQDTR As Double = 0
    Private _VLRFDT As Double = 0
    Private _TCMTRF As String = ""
    Private _IVNTA As Double = 0
    Private _CPRCN1 As String = ""
    Private _NSRCN1 As String = ""
    Private _TMNCNT As String = ""
    Private _CPRCN2 As String = ""
    Private _NSRCN2 As String = ""
    Private _TMNCN1 As String = ""
    Private _TDRCPL As String = ""
    Private _CPLNCL As Double = 0
    Private _PIGVA As Double = 0
    Private _CTIGVA As Integer = 0
    Private _INDICE As String = ""

    Private _TC_COBRAR As Double = 0
    Private _TC_PAGAR As Double = 0

    Private _SFCTTR As String = ""
    Private _SLQDTR As String = ""

    Private _QCNDLG As Double = 0
    Private _CUNDTR As String = ""
    Private _CSTNDT As Double = 0
    Private _TCNFVH As String = ""
    Private _PESOL As Double = 0
    Private _PBRDST As Double = 0
    Private _PMRCDR As Double = 0
    Private _QMRCDR As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _TCMCRA As String = ""

    Private _NDCPRF As Int64 = 0
    Private _FDCPRF As Int64 = 0
    Private _FDCPRF_S As String = ""
    Private _IMPOCOS As Decimal = 0
    Private _IMPOCOD As Decimal = 0
    Private _NPRLQD As Int64 = 0
    Private _ORGVTA As String = ""

    Private _FULTAC As String = ""
    Private _HULTAC As String = ""
    Private _CULUSA As String = ""
    Private _NTRMNL As String = ""
    Private _TCRVTA As String = ""
    Private _CRGVTA As String = ""
    Private _FEC_INI As Integer = 0
    Private _FEC_FIN As Integer = 0

    Private _CMNDA_COBRAR As Integer = 0
    Private _CMNDA_PAGAR As Integer = 0
    Private _MONEDA_COBRAR As String = ""
    Private _MONEDA_PAGAR As String = ""
    Private _NRUCTR As Double = 0

    Private _NRUCTR_LIQ As String = ""
    Private _TCMTRT_LIQ As String = ""

    Private _VLR_SOL As Decimal = 0
    Private _VLR_DOL As Decimal = 0
    Private _VLR_CANT As Decimal = 0
    Private _EN_VLR As String = ""
    Private _ACCION As String = ""

    Private _TPDCPE As String = ""
    Private _DCCLNT As String = ""
    Private _SBCLNT As String = ""
    Private _TIPODOC As String = ""
    Private _NROVLR As Double = 0
    Private _NSECFC As Decimal = 0
    Private _TIPO_PL As String = ""
    'Private _LISTA_CONS As String = ""

    Private _LISTA_A_PL As String = ""

    Private _LISTJSON As String = ""

    Private _CTPODC As Decimal = 0
    Private _NDCCTC As Decimal = 0
    Private _NINDRN As Decimal = 0

    Private _NCTDCC As Decimal = 0
    Private _FDCCTC As Decimal = 0

 


#End Region

#Region "Properties"

    Public Property CMNDA_PAGAR() As Integer
        Get
            Return _CMNDA_PAGAR
        End Get
        Set(ByVal value As Integer)
            _CMNDA_PAGAR = value
        End Set
    End Property

    Public Property CMNDA_COBRAR() As Integer
        Get
            Return _CMNDA_COBRAR
        End Get
        Set(ByVal value As Integer)
            _CMNDA_COBRAR = value
        End Set
    End Property

    Public Property MONEDA_PAGAR() As String
        Get
            Return _MONEDA_PAGAR
        End Get
        Set(ByVal value As String)
            _MONEDA_PAGAR = value
        End Set
    End Property


    Public Property MONEDA_COBRAR() As String
        Get
            Return _MONEDA_COBRAR
        End Get
        Set(ByVal value As String)
            _MONEDA_COBRAR = value
        End Set
    End Property


    Public Property SFCTTR() As String
        Get
            Return _SFCTTR
        End Get
        Set(ByVal value As String)
            _SFCTTR = value
        End Set
    End Property

    Public Property SLQDTR() As String
        Get
            Return _SLQDTR
        End Get
        Set(ByVal value As String)
            _SLQDTR = value
        End Set
    End Property


    Public Property TC_COBRAR() As Decimal
        Get
            Return _TC_COBRAR
        End Get
        Set(ByVal value As Decimal)
            _TC_COBRAR = value
        End Set
    End Property

    Public Property TC_PAGAR() As Decimal
        Get
            Return _TC_PAGAR
        End Get
        Set(ByVal value As Decimal)
            _TC_PAGAR = value
        End Set
    End Property

    Public Property FEC_INI() As Integer
        Get
            Return _FEC_INI
        End Get
        Set(ByVal value As Integer)
            _FEC_INI = value
        End Set
    End Property

    Public Property FEC_FIN() As Integer
        Get
            Return _FEC_FIN
        End Get
        Set(ByVal value As Integer)
            _FEC_FIN = value
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

    Public Property TCRVTA() As String
        Get
            Return _TCRVTA
        End Get
        Set(ByVal value As String)
            _TCRVTA = value
        End Set
    End Property

    Public Property FULTAC() As String
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As String)
            _FULTAC = value
        End Set
    End Property

    Public Property HULTAC() As String
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As String)
            _HULTAC = value
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

    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property

    Public Property NPRLQD() As Int64
        Get
            Return _NPRLQD
        End Get
        Set(ByVal value As Int64)
            _NPRLQD = value
        End Set
    End Property

    Public Property IMPOCOS() As Decimal
        Get
            Return _IMPOCOS
        End Get
        Set(ByVal value As Decimal)
            _IMPOCOS = value
        End Set
    End Property

    Public Property IMPOCOD() As Decimal
        Get
            Return _IMPOCOD
        End Get
        Set(ByVal value As Decimal)
            _IMPOCOD = value
        End Set
    End Property

    Public Property NDCPRF() As Int64
        Get
            Return _NDCPRF
        End Get
        Set(ByVal value As Int64)
            _NDCPRF = value
        End Set
    End Property

    Public Property FDCPRF() As Int64
        Get
            Return _FDCPRF
        End Get
        Set(ByVal value As Int64)
            _FDCPRF = value
        End Set
    End Property

    Public Property FDCPRF_S() As String
        Get
            Return _FDCPRF_S
        End Get
        Set(ByVal value As String)
            _FDCPRF_S = value
        End Set
    End Property

    Public Property ORGVTA() As String
        Get
            Return _ORGVTA
        End Get
        Set(ByVal value As String)
            _ORGVTA = value
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

    Public Property NOPRCN() As Int64
        Get
            Return _NOPRCN
        End Get
        Set(ByVal Value As Int64)
            _NOPRCN = Value
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

    Public Property FGUITR() As Int64
        Get
            Return _FGUITR
        End Get
        Set(ByVal Value As Int64)
            _FGUITR = Value
        End Set
    End Property

    Public Property FGUITR_S() As String
        Get
            Return _FGUITR_S
        End Get
        Set(ByVal Value As String)
            _FGUITR_S = Value
        End Set
    End Property

    Public Property NMNFCR() As Int64
        Get
            Return _NMNFCR
        End Get
        Set(ByVal Value As Int64)
            _NMNFCR = Value
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

    Public Property TCMTRT() As String
        Get
            Return _TCMTRT
        End Get
        Set(ByVal Value As String)
            _TCMTRT = Value
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

    Public Property TDSTRT() As String
        Get
            Return _TDSTRT
        End Get
        Set(ByVal Value As String)
            _TDSTRT = Value
        End Set
    End Property

    Public Property QCNDTG() As Double
        Get
            Return _QCNDTG
        End Get
        Set(ByVal Value As Double)
            _QCNDTG = Value
        End Set
    End Property

    Public Property ISRVGU() As Double
        Get
            Return _ISRVGU
        End Get
        Set(ByVal Value As Double)
            _ISRVGU = Value
        End Set
    End Property

    Public Property CMNDGU() As String
        Get
            Return _CMNDGU
        End Get
        Set(ByVal Value As String)
            _CMNDGU = Value
        End Set
    End Property

    Public Property CMNLQT() As String
        Get
            Return _CMNLQT
        End Get
        Set(ByVal Value As String)
            _CMNLQT = Value
        End Set
    End Property

    Public Property TOTSER() As Double
        Get
            Return _TOTSER
        End Get
        Set(ByVal Value As Double)
            _TOTSER = Value
        End Set
    End Property

    Public Property PBRTOR() As Double
        Get
            Return _PBRTOR
        End Get
        Set(ByVal Value As Double)
            _PBRTOR = Value
        End Set
    End Property

    Public Property QBLORG() As Double
        Get
            Return _QBLORG
        End Get
        Set(ByVal Value As Double)
            _QBLORG = Value
        End Set
    End Property

    Public Property QKLMRC() As Double
        Get
            Return _QKLMRC
        End Get
        Set(ByVal Value As Double)
            _QKLMRC = Value
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

    Public Property CCLNT() As Int64
        Get
            Return _CCLNT
        End Get
        Set(ByVal Value As Int64)
            _CCLNT = Value
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

    Public Property CCLNFC() As Int64
        Get
            Return _CCLNFC
        End Get
        Set(ByVal Value As Int64)
            _CCLNFC = Value
        End Set
    End Property

    Public Property TCMPFC() As String
        Get
            Return _TCMPFC
        End Get
        Set(ByVal Value As String)
            _TCMPFC = Value
        End Set
    End Property

    Public Property TDRCFC() As String
        Get
            Return _TDRCFC
        End Get
        Set(ByVal Value As String)
            _TDRCFC = Value
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

    Public Property CTPOSR() As String
        Get
            Return _CTPOSR
        End Get
        Set(ByVal Value As String)
            _CTPOSR = Value
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

    Public Property CTPSBS() As String
        Get
            Return _CTPSBS
        End Get
        Set(ByVal Value As String)
            _CTPSBS = Value
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

    Public Property SRPTRM() As String
        Get
            Return _SRPTRM
        End Get
        Set(ByVal Value As String)
            _SRPTRM = Value
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

    Public Property TSGNMN_S() As String
        Get
            Return _TSGNMN_S
        End Get
        Set(ByVal Value As String)
            _TSGNMN_S = Value
        End Set
    End Property

    Public Property TSGNMN_L() As String
        Get
            Return _TSGNMN_L
        End Get
        Set(ByVal Value As String)
            _TSGNMN_L = Value
        End Set
    End Property

    Public Property CUNDSR() As String
        Get
            Return _CUNDSR
        End Get
        Set(ByVal Value As String)
            _CUNDSR = Value
        End Set
    End Property

    Public Property ILQDTR() As Double
        Get
            Return _ILQDTR
        End Get
        Set(ByVal Value As Double)
            _ILQDTR = Value
        End Set
    End Property

    Public Property VLRFDT() As Double
        Get
            Return _VLRFDT
        End Get
        Set(ByVal Value As Double)
            _VLRFDT = Value
        End Set
    End Property

    Public Property TCMTRF() As String
        Get
            Return _TCMTRF
        End Get
        Set(ByVal Value As String)
            _TCMTRF = Value
        End Set
    End Property

    Public Property NRUCFC() As Int64
        Get
            Return _NRUCFC
        End Get
        Set(ByVal Value As Int64)
            _NRUCFC = Value
        End Set
    End Property

    Public Property NLBTEL() As Int64
        Get
            Return _NLBTEL
        End Get
        Set(ByVal Value As Int64)
            _NLBTEL = Value
        End Set
    End Property

    Public Property IVNTA() As Double
        Get
            Return _IVNTA
        End Get
        Set(ByVal Value As Double)
            _IVNTA = Value
        End Set
    End Property

    Public Property CPRCN1() As String
        Get
            Return _CPRCN1
        End Get
        Set(ByVal Value As String)
            _CPRCN1 = Value
        End Set
    End Property

    Public Property NSRCN1() As String
        Get
            Return _NSRCN1
        End Get
        Set(ByVal Value As String)
            _NSRCN1 = Value
        End Set
    End Property

    Public Property TMNCNT() As String
        Get
            Return _TMNCNT
        End Get
        Set(ByVal Value As String)
            _TMNCNT = Value
        End Set
    End Property

    Public Property CPRCN2() As String
        Get
            Return _CPRCN2
        End Get
        Set(ByVal Value As String)
            _CPRCN2 = Value
        End Set
    End Property

    Public Property NSRCN2() As String
        Get
            Return _NSRCN2
        End Get
        Set(ByVal Value As String)
            _NSRCN2 = Value
        End Set
    End Property

    Public Property TMNCN1() As String
        Get
            Return _TMNCN1
        End Get
        Set(ByVal Value As String)
            _TMNCN1 = Value
        End Set
    End Property

    Public Property TDRCPL() As String
        Get
            Return _TDRCPL
        End Get
        Set(ByVal Value As String)
            _TDRCPL = Value
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

    Public Property PIGVA() As Double
        Get
            Return _PIGVA
        End Get
        Set(ByVal Value As Double)
            _PIGVA = Value
        End Set
    End Property

    Public Property CTIGVA() As Integer
        Get
            Return _CTIGVA
        End Get
        Set(ByVal Value As Integer)
            _CTIGVA = Value
        End Set
    End Property

    Public Property INDICE() As String
        Get
            Return _INDICE
        End Get
        Set(ByVal Value As String)
            _INDICE = Value
        End Set
    End Property

    Public Property QCNDLG() As Double
        Get
            Return _QCNDLG
        End Get
        Set(ByVal Value As Double)
            _QCNDLG = Value
        End Set
    End Property

    Public Property CUNDTR() As String
        Get
            Return _CUNDTR
        End Get
        Set(ByVal Value As String)
            _CUNDTR = Value
        End Set
    End Property

    Public Property CSTNDT() As Double
        Get
            Return _CSTNDT
        End Get
        Set(ByVal Value As Double)
            _CSTNDT = Value
        End Set
    End Property

    Public Property TCNFVH() As String
        Get
            Return _TCNFVH
        End Get
        Set(ByVal Value As String)
            _TCNFVH = Value
        End Set
    End Property

    Public Property PESOL() As Double
        Get
            Return _PESOL
        End Get
        Set(ByVal Value As Double)
            _PESOL = Value
        End Set
    End Property

    Public Property PBRDST() As Double
        Get
            Return _PBRDST
        End Get
        Set(ByVal Value As Double)
            _PBRDST = Value
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

    Public Property QMRCDR() As Double
        Get
            Return _QMRCDR
        End Get
        Set(ByVal Value As Double)
            _QMRCDR = Value
        End Set
    End Property

    Public Property TCMCRA() As String
        Get
            Return _TCMCRA
        End Get
        Set(ByVal Value As String)
            _TCMCRA = Value
        End Set
    End Property

    Public Property NRUCTR() As Double
        Get
            Return _NRUCTR
        End Get
        Set(ByVal Value As Double)
            _NRUCTR = Value
        End Set
    End Property


    Public Property NRUCTR_LIQ() As String
        Get
            Return _NRUCTR_LIQ
        End Get
        Set(ByVal Value As String)
            _NRUCTR_LIQ = Value
        End Set
    End Property
    Public Property TCMTRT_LIQ() As String
        Get
            Return _TCMTRT_LIQ
        End Get
        Set(ByVal Value As String)
            _TCMTRT_LIQ = Value
        End Set
    End Property

    Public Property VLR_SOL As Decimal
        Get
            Return _VLR_SOL
        End Get
        Set(ByVal Value As Decimal)
            _VLR_SOL = Value
        End Set
    End Property
    Public Property VLR_DOL As Decimal
        Get
            Return _VLR_DOL
        End Get
        Set(ByVal Value As Decimal)
            _VLR_DOL = Value
        End Set
    End Property
    Public Property VLR_CANT As Decimal
        Get
            Return _VLR_CANT
        End Get
        Set(ByVal Value As Decimal)
            _VLR_CANT = Value
        End Set
    End Property

    Public Property EN_VLR() As String
        Get
            Return _EN_VLR
        End Get
        Set(ByVal Value As String)
            _EN_VLR = Value
        End Set
    End Property

    Public Property ACCION() As String
        Get
            Return _ACCION
        End Get
        Set(ByVal Value As String)
            _ACCION = Value
        End Set
    End Property

    Public Property TPDCPE() As String
        Get
            Return _TPDCPE
        End Get
        Set(ByVal Value As String)
            _TPDCPE = Value
        End Set
    End Property
    Public Property DCCLNT() As String
        Get
            Return _DCCLNT
        End Get
        Set(ByVal Value As String)
            _DCCLNT = Value
        End Set
    End Property
    Public Property SBCLNT() As String
        Get
            Return _SBCLNT
        End Get
        Set(ByVal Value As String)
            _SBCLNT = Value
        End Set
    End Property

    Public Property TIPODOC() As String
        Get
            Return _TIPODOC
        End Get
        Set(ByVal Value As String)
            _TIPODOC = Value
        End Set
    End Property

    Public Property NROVLR As Decimal
        Get
            Return _NROVLR
        End Get
        Set(ByVal Value As Decimal)
            _NROVLR = Value
        End Set
    End Property

    Public Property NSECFC As Decimal
        Get
            Return _NSECFC
        End Get
        Set(ByVal Value As Decimal)
            _NSECFC = Value
        End Set
    End Property

    Public Property TIPO_PL() As String
        Get
            Return _TIPO_PL
        End Get
        Set(ByVal Value As String)
            _TIPO_PL = Value
        End Set
    End Property

    Public Property LISTA_A_PL() As String
        Get
            Return _LISTA_A_PL
        End Get
        Set(ByVal Value As String)
            _LISTA_A_PL = Value
        End Set
    End Property

    Public Property LISTJSON() As String
        Get
            Return _LISTJSON
        End Get
        Set(ByVal Value As String)
            _LISTJSON = Value
        End Set
    End Property

    Public Property CTPODC As Decimal
        Get
            Return _CTPODC
        End Get
        Set(ByVal Value As Decimal)
            _CTPODC = Value
        End Set
    End Property
    Public Property NDCCTC As Decimal
        Get
            Return _NDCCTC
        End Get
        Set(ByVal Value As Decimal)
            _NDCCTC = Value
        End Set
    End Property
    Public Property NINDRN As Decimal
        Get
            Return _NINDRN
        End Get
        Set(ByVal Value As Decimal)
            _NINDRN = Value
        End Set
    End Property

    Public Property NCTDCC As Decimal
        Get
            Return _NCTDCC
        End Get
        Set(ByVal Value As Decimal)
            _NCTDCC = Value
        End Set
    End Property

    Public Property FDCCTC As Decimal
        Get
            Return _FDCCTC
        End Get
        Set(ByVal Value As Decimal)
            _FDCCTC = Value
        End Set
    End Property


 
#End Region

End Class
