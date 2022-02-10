Namespace Operaciones
  Public Class LiquidacionOperacion

#Region "Atributo"
    Private _NLQGST As Double = 0
    Private _NOPRCN As Double = 0
    Private _CCNCST As Double = 0
    Private _TCNTCS As String = ""
    Private _TOBS As String = ""
    Private _NCRRRT As Int32 = 0
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
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Int32 = 0

    Private _NLQDCN As Int64 = 0
    Private _FLQDCN As Int32 = 0
        Private _FLQDCN_S As String = ""
        Private _FLQDCN_FORMAT As String = ""
    Private _NORINS As Int64 = 0
        Private _NRFSAP As Int64 = 0
        Private _CADNRFSAP As String = ""
    Private _TSTERS As String = ""
    Private _FSTTRS As String = ""

    Private _NGUITR As Int64 = 0
    Private _CSRVC As Int32 = 0
    Private _NENMRS As Int64 = 0
    Private _CTRSPT As Int32 = 0
    Private _FCHCRT As Int32 = 0
    Private _TABTRF As String = ""
    Private _TCMTRT As String = ""
    Private _FCHCRT_S As String = ""
    Private _STATUS As Boolean = False
    Private _NUMOPG As Int64 = 0
    Private _ILQDTR As Double = 0
        Private _ITCCTC As Double = 0
        Private _IMPOCOS As Double = 0
        Private _IMPOCOD As Double = 0
        Private _TIPO As String = ""

        Private _QCNDLG As Decimal = 0
        Private _ILQDTR_TOT As Decimal = 0


        Private _FechaActual As Integer
        Private _TPLNTA As String = ""


        Private _ILQDTR_S As Decimal = 0
        Private _ILQDTR_D As Decimal = 0

        Private _SIN_REFSAP As Integer = 0
#End Region

#Region "Properties"

    Public Property STATUS() As Boolean
      Get
        Return _STATUS
      End Get
      Set(ByVal value As Boolean)
        _STATUS = value
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

    Public Property CPLNDV() As Int32
      Get
        Return _CPLNDV
      End Get
      Set(ByVal value As Int32)
        _CPLNDV = value
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

    Public Property NCRRRT() As Int32
      Get
        Return _NCRRRT
      End Get
      Set(ByVal Value As Int32)
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


        Public Property FLQDCN_FORMAT() As String
            Get
                Return _FLQDCN_FORMAT
            End Get
            Set(ByVal Value As String)
                _FLQDCN_FORMAT = Value
            End Set
        End Property

        '


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

    Public Property NLQDCN() As Int64
      Get
        Return _NLQDCN
      End Get
      Set(ByVal Value As Int64)
        _NLQDCN = Value
      End Set
    End Property

    Public Property FLQDCN() As Int32
      Get
        Return _FLQDCN
      End Get
      Set(ByVal Value As Int32)
        _FLQDCN = Value
      End Set
    End Property

    Public Property FLQDCN_S() As String
      Get
        Return _FLQDCN_S
      End Get
      Set(ByVal Value As String)
        _FLQDCN_S = Value
      End Set
    End Property

    Public Property NORINS() As Int64
      Get
        Return _NORINS
      End Get
      Set(ByVal Value As Int64)
        _NORINS = Value
      End Set
    End Property

    Public Property NRFSAP() As Int64
      Get
        Return _NRFSAP
      End Get
      Set(ByVal Value As Int64)
        _NRFSAP = Value
      End Set
    End Property

    Public Property TSTERS() As String
      Get
        Return _TSTERS
      End Get
      Set(ByVal Value As String)
        _TSTERS = Value
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

    Public Property NGUITR() As Int64
      Get
        Return _NGUITR
      End Get
      Set(ByVal value As Int64)
        _NGUITR = value
      End Set
    End Property

    Public Property CSRVC() As Int32
      Get
        Return _CSRVC
      End Get
      Set(ByVal value As Int32)
        _CSRVC = value
      End Set
    End Property

    Public Property NENMRS() As Int64
      Get
        Return _NENMRS
      End Get
      Set(ByVal Value As Int64)
        _NENMRS = Value
      End Set
    End Property

    Public Property CTRSPT() As Int32
      Get
        Return _CTRSPT
      End Get
      Set(ByVal value As Int32)
        _CTRSPT = value
      End Set
    End Property

    Public Property FCHCRT() As Int32
      Get
        Return _FCHCRT
      End Get
      Set(ByVal Value As Int32)
        _FCHCRT = Value
      End Set
    End Property

    Public Property TABTRF() As String
      Get
        Return _TABTRF
      End Get
      Set(ByVal Value As String)
        _TABTRF = Value
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

    Public Property FCHCRT_S() As String
      Get
        Return _FCHCRT_S
      End Get
      Set(ByVal Value As String)
        _FCHCRT_S = Value
      End Set
    End Property

    Public Property NUMOPG() As Int64
      Get
        Return _NUMOPG
      End Get
      Set(ByVal Value As Int64)
        _NUMOPG = Value
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

    Public Property ITCCTC() As Double
      Get
        Return _ITCCTC
      End Get
      Set(ByVal Value As Double)
        _ITCCTC = Value
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

        Public Property TIPO() As String
            Get
                Return _TIPO
            End Get
            Set(ByVal Value As String)
                _TIPO = Value
            End Set
        End Property


        Public Property QCNDLG() As Decimal
            Get
                Return _QCNDLG
            End Get
            Set(ByVal Value As Decimal)
                _QCNDLG = Value
            End Set
        End Property

        Public Property ILQDTR_TOT() As Decimal
            Get
                Return _ILQDTR_TOT
            End Get
            Set(ByVal Value As Decimal)
                _ILQDTR_TOT = Value
            End Set
        End Property


        Public Property ILQDTR_S() As Decimal
            Get
                Return _ILQDTR_S
            End Get
            Set(ByVal Value As Decimal)
                _ILQDTR_S = Value
            End Set
        End Property

        Public Property ILQDTR_D() As Decimal
            Get
                Return _ILQDTR_D
            End Get
            Set(ByVal Value As Decimal)
                _ILQDTR_D = Value
            End Set
        End Property
 


        Public Property FechaActual() As Integer
            Get
                Return _FechaActual
            End Get
            Set(ByVal value As Integer)
                _FechaActual = value
            End Set
        End Property

        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        Public Property TPLNTA() As String
            Get
                Return _TPLNTA
            End Get
            Set(ByVal Value As String)
                _TPLNTA = Value
            End Set
        End Property

        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        Public Property CADNRFSAP() As String
            Get
                Return _CADNRFSAP
            End Get
            Set(ByVal Value As String)
                _CADNRFSAP = Value
            End Set
        End Property

        Public Property SIN_REFSAP() As Integer
            Get
                Return _SIN_REFSAP
            End Get
            Set(ByVal value As Integer)
                _SIN_REFSAP = value
            End Set
        End Property

#End Region

  End Class
End Namespace

