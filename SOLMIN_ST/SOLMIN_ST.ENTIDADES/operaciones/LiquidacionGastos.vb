Namespace Operaciones
  Public Class LiquidacionGastos

#Region "Atributo"

    Private _NLQGST As Double = 0
    Private _CTRSPT As Double = 0
    Private _TCMTRT As String = ""
    Private _NRUCTR As String = ""
    Private _NPLCUN As String = ""
    Private _NPLCAC As String = ""
    Private _CBRCNT As String = ""
    Private _CBRCND As String = ""
    Private _SESTRG As String = ""
    Private _USRCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _FCHCRT_S As String = ""
    Private _HRACRT As Double = 0
    Private _USRCRR As String = ""
    Private _FCHCRR As Double = 0
    Private _HRACRR As Double = 0
    Private _USRAPR As String = ""
    Private _FCHAPR As Double = 0
    Private _HRAAPR As Double = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _NTRMNL As String = ""
    Private _QTCACT As Double = 0
    Private _QTCSDA As Double = 0
    Private _QTCLLG As Double = 0
    Private _NULGUN As Double = 0

    Private _NOPRCN As Double = 0
    Private _CCNCST As Double = 0
    Private _TCNTCS As String = ""
    Private _TOBS As String = ""

    Private _NCRRRT As Double = 0
    Private _CRUTA As Double = 0
    Private _TLGRSL As String = ""
    Private _FSLDCM As Double = 0
    Private _FSLDCM_S As String = ""
    Private _TLGRLL As String = ""
    Private _FLLGCM As Double = 0
    Private _FLLGCM_S As String = ""
    Private _TDSCAR As String = ""
    Private _TRLCGU As String = ""
    Private _NKMRTA As Double = 0

    Private _CCLNT As Double = 0
    Private _TCMPCL As String = ""
    Private _TRFMRC As String = ""
    Private _NPLNMT As Double = 0

    Private _CGSTOS As Double = 0
    Private _TGSTOS As String = ""
    Private _CDMNDA As Double = 0
    Private _TMNDA As String = ""
        Private _IGSTOS As Double = 0
        Private _IGSTOS_COD As Double = 0
    Private _IGSTOS1 As Double = 0
    Private _TOBDCT As String = ""
    Private _CLCLOR As Double = 0
    Private _CLCLDS As Double = 0
    Private _NCSOTR As Double = 0
    Private _NCRRSR As Double = 0
    Private _NCTAVC As Double = 0

    Private _NVLRNS As Double = 0
    Private _NVLGRF As Double = 0
    Private _CGRFO As Double = 0
    Private _TGRFO As String = ""
    Private _TGRIFO As String = ""
    Private _FCRCMB As Double = 0
    Private _FCRCMB_S As String = ""
    Private _QGLNCM As Double = 0
    Private _CTPCMB As String = ""
    Private _TDSCMB As String = ""
    Private _NKMRCR As Double = 0
    Private _ICSTOS As Double = 0
    Private _IVNTAS As Double = 0
    Private _NRSCVL As Double = 0
    Private _TGASTO As Double = 0
    Private _TAVC As Double = 0
        Private _CCMPN As String = ""
        Private _USER_CREACION As String = ""
        Private _USER_LIQUIDADOR As String = ""
        Private _FECINI As String = ""
        Private _FECFIN As String = ""
        Private _FECINI_S As String = ""
        Private _FECFIN_S As String = ""
        Private _TIPO As String = ""
        Private _FECIDE As String = ""
        Private _MONEDA As String = ""
        Private _GASTO_DESC As String = ""
        Private _CODIGOSAP As String = ""
#End Region

#Region "Properties"

        Public Property CCMPN() As String
            Get
                Return _CCMPN
            End Get
            Set(ByVal value As String)
                _CCMPN = value
            End Set
        End Property

    Public Property TGASTO() As Double
      Get
        Return _TGASTO
      End Get
      Set(ByVal value As Double)
        _TGASTO = value
      End Set
    End Property

    Public Property TAVC() As Double
      Get
        Return _TAVC
      End Get
      Set(ByVal value As Double)
        _TAVC = value
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


    Public Property TMNDA() As String
      Get
        Return _TMNDA
      End Get
      Set(ByVal Value As String)
        _TMNDA = Value
      End Set
    End Property

    Public Property TGSTOS() As String
      Get
        Return _TGSTOS
      End Get
      Set(ByVal Value As String)
        _TGSTOS = Value
      End Set
    End Property

    Public Property NLQGST() As Double
      Get
        Return _NLQGST
      End Get
      Set(ByVal Value As Double)
        _NLQGST = Value
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

    Public Property TCMTRT() As String
      Get
        Return _TCMTRT
      End Get
      Set(ByVal Value As String)
        _TCMTRT = Value
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

    Public Property NPLCAC() As String
      Get
        Return _NPLCAC
      End Get
      Set(ByVal Value As String)
        _NPLCAC = Value
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

    Public Property SESTRG() As String
      Get
        Return _SESTRG
      End Get
      Set(ByVal Value As String)
        _SESTRG = Value
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

    Public Property FCHCRT() As Double
      Get
        Return _FCHCRT
      End Get
      Set(ByVal Value As Double)
        _FCHCRT = Value
      End Set
    End Property

    Public Property FCHCRT_S() As String
      Get
        Return _FCHCRT_S
      End Get
      Set(ByVal Value As String)
        _FCHCRT_S = Value
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

    Public Property USRCRR() As String
      Get
        Return _USRCRR
      End Get
      Set(ByVal Value As String)
        _USRCRR = Value
      End Set
    End Property

    Public Property FCHCRR() As Double
      Get
        Return _FCHCRR
      End Get
      Set(ByVal Value As Double)
        _FCHCRR = Value
      End Set
    End Property

    Public Property HRACRR() As Double
      Get
        Return _HRACRR
      End Get
      Set(ByVal Value As Double)
        _HRACRR = Value
      End Set
    End Property

    Public Property USRAPR() As String
      Get
        Return _USRAPR
      End Get
      Set(ByVal Value As String)
        _USRAPR = Value
      End Set
    End Property

    Public Property FCHAPR() As Double
      Get
        Return _FCHAPR
      End Get
      Set(ByVal Value As Double)
        _FCHAPR = Value
      End Set
    End Property

    Public Property HRAAPR() As Double
      Get
        Return _HRAAPR
      End Get
      Set(ByVal Value As Double)
        _HRAAPR = Value
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

    Public Property NTRMNL() As String
      Get
        Return _NTRMNL
      End Get
      Set(ByVal Value As String)
        _NTRMNL = Value
      End Set
    End Property

    Public Property QTCACT() As Double
      Get
        Return _QTCACT
      End Get
      Set(ByVal Value As Double)
        _QTCACT = Value
      End Set
    End Property

    Public Property QTCSDA() As Double
      Get
        Return _QTCSDA
      End Get
      Set(ByVal Value As Double)
        _QTCSDA = Value
      End Set
    End Property

    Public Property QTCLLG() As Double
      Get
        Return _QTCLLG
      End Get
      Set(ByVal Value As Double)
        _QTCLLG = Value
      End Set
    End Property

    Public Property NULGUN() As Double
      Get
        Return _NULGUN
      End Get
      Set(ByVal Value As Double)
        _NULGUN = Value
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

    Public Property CCNCST() As Double
      Get
        Return _CCNCST
      End Get
      Set(ByVal Value As Double)
        _CCNCST = Value
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

    Public Property TOBS() As String
      Get
        Return _TOBS
      End Get
      Set(ByVal Value As String)
        _TOBS = Value
      End Set
    End Property

    Public Property NCRRRT() As Double
      Get
        Return _NCRRRT
      End Get
      Set(ByVal Value As Double)
        _NCRRRT = Value
      End Set
    End Property

    Public Property CRUTA() As Double
      Get
        Return _CRUTA
      End Get
      Set(ByVal Value As Double)
        _CRUTA = Value
      End Set
    End Property

    Public Property TLGRSL() As String
      Get
        Return _TLGRSL
      End Get
      Set(ByVal Value As String)
        _TLGRSL = Value
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

    Public Property FSLDCM_S() As String
      Get
        Return _FSLDCM_S
      End Get
      Set(ByVal Value As String)
        _FSLDCM_S = Value
      End Set
    End Property

    Public Property TLGRLL() As String
      Get
        Return _TLGRLL
      End Get
      Set(ByVal Value As String)
        _TLGRLL = Value
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

    Public Property FLLGCM_S() As String
      Get
        Return _FLLGCM_S
      End Get
      Set(ByVal Value As String)
        _FLLGCM_S = Value
      End Set
    End Property


    Public Property TDSCAR() As String
      Get
        Return _TDSCAR
      End Get
      Set(ByVal Value As String)
        _TDSCAR = Value
      End Set
    End Property

    Public Property TRLCGU() As String
      Get
        Return _TRLCGU
      End Get
      Set(ByVal Value As String)
        _TRLCGU = Value
      End Set
    End Property

    Public Property NKMRTA() As Double
      Get
        Return _NKMRTA
      End Get
      Set(ByVal Value As Double)
        _NKMRTA = Value
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

    Public Property TCMPCL() As String
      Get
        Return _TCMPCL
      End Get
      Set(ByVal Value As String)
        _TCMPCL = Value
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

    Public Property NPLNMT() As Double
      Get
        Return _NPLNMT
      End Get
      Set(ByVal Value As Double)
        _NPLNMT = Value
      End Set
    End Property

    Public Property CGSTOS() As Double
      Get
        Return _CGSTOS
      End Get
      Set(ByVal Value As Double)
        _CGSTOS = Value
      End Set
    End Property

    Public Property CDMNDA() As Double
      Get
        Return _CDMNDA
      End Get
      Set(ByVal Value As Double)
        _CDMNDA = Value
      End Set
    End Property

    Public Property IGSTOS() As Double
      Get
        Return _IGSTOS
      End Get
      Set(ByVal Value As Double)
        _IGSTOS = Value
      End Set
        End Property


        Public Property IGSTOS_COD() As Double
            Get
                Return _IGSTOS_COD
            End Get
            Set(ByVal Value As Double)
                _IGSTOS_COD = Value
            End Set
        End Property
        '

    Public Property IGSTOS1() As Double
      Get
        Return _IGSTOS1
      End Get
      Set(ByVal Value As Double)
        _IGSTOS1 = Value
      End Set
    End Property

    Public Property TOBDCT() As String
      Get
        Return _TOBDCT
      End Get
      Set(ByVal Value As String)
        _TOBDCT = Value
      End Set
    End Property

    Public Property CLCLOR() As Double
      Get
        Return _CLCLOR
      End Get
      Set(ByVal value As Double)
        _CLCLOR = value
      End Set
    End Property

    Public Property CLCLDS() As Double
      Get
        Return _CLCLDS
      End Get
      Set(ByVal value As Double)
        _CLCLDS = value
      End Set
    End Property

    Public Property NRUCTR() As String
      Get
        Return _NRUCTR
      End Get
      Set(ByVal Value As String)
        _NRUCTR = Value
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

    Public Property NVLRNS() As Double
      Get
        Return _NVLRNS
      End Get
      Set(ByVal Value As Double)
        _NVLRNS = Value
      End Set
    End Property

    Public Property NVLGRF() As Double
      Get
        Return _NVLGRF
      End Get
      Set(ByVal Value As Double)
        _NVLGRF = Value
      End Set
    End Property

    Public Property CGRFO() As Double
      Get
        Return _CGRFO
      End Get
      Set(ByVal Value As Double)
        _CGRFO = Value
      End Set
    End Property

    Public Property TGRFO() As String
      Get
        Return _TGRFO
      End Get
      Set(ByVal Value As String)
        _TGRFO = Value
      End Set
    End Property

    Public Property TGRIFO() As String
      Get
        Return _TGRIFO
      End Get
      Set(ByVal Value As String)
        _TGRIFO = Value
      End Set
    End Property

    Public Property FCRCMB() As Double
      Get
        Return _FCRCMB
      End Get
      Set(ByVal Value As Double)
        _FCRCMB = Value
      End Set
    End Property

    Public Property FCRCMB_S() As String
      Get
        Return _FCRCMB_S
      End Get
      Set(ByVal Value As String)
        _FCRCMB_S = Value
      End Set
    End Property

    Public Property QGLNCM() As Double
      Get
        Return _QGLNCM
      End Get
      Set(ByVal Value As Double)
        _QGLNCM = Value
      End Set
    End Property

    Public Property CTPCMB() As String
      Get
        Return _CTPCMB
      End Get
      Set(ByVal Value As String)
        _CTPCMB = Value
      End Set
    End Property

    Public Property TDSCMB() As String
      Get
        Return _TDSCMB
      End Get
      Set(ByVal Value As String)
        _TDSCMB = Value
      End Set
    End Property

    Public Property NKMRCR() As Double
      Get
        Return _NKMRCR
      End Get
      Set(ByVal Value As Double)
        _NKMRCR = Value
      End Set
    End Property

    Public Property ICSTOS() As Double
      Get
        Return _ICSTOS
      End Get
      Set(ByVal Value As Double)
        _ICSTOS = Value
      End Set
    End Property

    Public Property IVNTAS() As Double
      Get
        Return _IVNTAS
      End Get
      Set(ByVal Value As Double)
        _IVNTAS = Value
      End Set
    End Property

    Public Property NRSCVL() As Double
      Get
        Return _NRSCVL
      End Get
      Set(ByVal Value As Double)
        _NRSCVL = Value
      End Set
    End Property

        Public Property USER_CREACION() As String
            Get
                Return _USER_CREACION
            End Get
            Set(ByVal Value As String)
                _USER_CREACION = Value
            End Set
        End Property
        Public Property USER_LIQUIDADOR() As String
            Get
                Return _USER_LIQUIDADOR
            End Get
            Set(ByVal Value As String)
                _USER_LIQUIDADOR = Value
            End Set
        End Property

        Public Property FECINI() As String
            Get
                Return _FECINI
            End Get
            Set(ByVal Value As String)
                _FECINI = Value
            End Set
        End Property
        Public Property FECFIN() As String
            Get
                Return _FECFIN
            End Get
            Set(ByVal Value As String)
                _FECFIN = Value
            End Set
        End Property
        Public Property TIPO() As String
            Get
                Return _TIPO
            End Get
            Set(ByVal Value As String)
                _TIPO = Value
            End Set
        End Property
        Public Property FECIDE() As String
            Get
                Return _FECIDE
            End Get
            Set(ByVal Value As String)
                _FECIDE = Value
            End Set
        End Property

        Public Property FECINI_S() As String
            Get
                Return _FECINI_S
            End Get
            Set(ByVal Value As String)
                _FECINI_S = Value
            End Set
        End Property
        Public Property FECFIN_S() As String
            Get
                Return _FECFIN_S
            End Get
            Set(ByVal Value As String)
                _FECFIN_S = Value
            End Set
        End Property

        Public Property MONEDA() As String
            Get
                Return _MONEDA
            End Get
            Set(ByVal Value As String)
                _MONEDA = Value
            End Set
        End Property

        Public Property GASTO_DESC() As String
            Get
                Return _GASTO_DESC
            End Get
            Set(ByVal Value As String)
                _GASTO_DESC = Value
            End Set
        End Property

        Public Property CODIGOSAP() As String
            Get
                Return _CODIGOSAP
            End Get
            Set(ByVal Value As String)
                _CODIGOSAP = Value
            End Set
        End Property

        'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-INICIO
        Dim _ncrrgt As Double
        Public Property NCRRGT() As Double
            Get
                Return _ncrrgt
            End Get
            Set(ByVal value As Double)
                _ncrrgt = Value
            End Set
        End Property

        Dim _nmslpe As String
        Public Property NMSLPE() As String
            Get
                Return _nmslpe
            End Get
            Set(ByVal value As String)
                _nmslpe = Value
            End Set
        End Property

        Dim _nrfsap As String
        Public Property NRFSAP() As String
            Get
                Return _nrfsap
            End Get
            Set(ByVal value As String)
                _nrfsap = Value
            End Set
        End Property

        Dim _aejins As String
        Public Property AEJINS() As String
            Get
                Return _aejins
            End Get
            Set(ByVal value As String)
                _aejins = Value
            End Set
        End Property

        Dim _islpes As String
        Public Property ISLPES() As String
            Get
                Return _islpes
            End Get
            Set(ByVal value As String)
                _islpes = Value
            End Set
        End Property

        Dim _tadsap As String
        Public Property TADSAP() As String
            Get
                Return _tadsap
            End Get
            Set(ByVal value As String)
                _tadsap = Value
            End Set
        End Property

        Dim _tpslpe As String
        Public Property TPSLPE() As String
            Get
                Return _tpslpe
            End Get
            Set(ByVal value As String)
                _tpslpe = value
            End Set
        End Property

        'ECM-HUNDRED-(TEP-000001-SOLMIN LIQUIDACION DE GASTOS)-FIN

#End Region

  End Class

End Namespace
