Public Class beUbicacion
    Inherits beBase(Of beUbicacion)

    Private _PSCTPALM As String = ""
    Private _PSCALMC As String = ""
    Private _PSCSECTR As String = ""
    Private _PSCPSCN As String = ""
    Private _PSCPSLL As String = ""
    Private _PSCCLMN As String = ""
    Private _PSCPRFMR As String = ""
    Private _PSCAPIMR As String = ""
    Private _PSCROTMR As String = ""
    Private _PNCSRVPK As Decimal = 0
    Private _PNNCOORX As Decimal = 0
    Private _PNNCOORY As Decimal = 0
    Private _PNNCOORZ As Decimal = 0
    Private _PNNCOOX2 As Decimal = 0
    Private _PNNCOOY2 As Decimal = 0
    Private _PNNCOOZ2 As Decimal = 0
    Private _PNQCMLRG As Decimal = 0
    Private _PNQSLETQ As Decimal = 0
    Private _PNQCMANC As Decimal = 0
    Private _PNQCMALT As Decimal = 0
    Private _PNCCLNRN As Decimal = 0
    Private _PSSSCPOS As String = ""
    Private _PNPRCUSO As Decimal = 0
    Private _PSCZNALM As String = ""
    Private _PSTFNCAC As String = ""
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSCULUSA As String = ""
    Private _PSSESTRG As String = ""
    Private _PNUPDATE_IDENT As Decimal = 0
    Private _PSCLIENTE As String = ""
    Private _PSTCMPOP As String = ""
    Private _PSTIPO As String = ""
    Private _PSALMACEN As String = ""
    Private _PNNORDSR As Int64 = 0
    Private _PSTMRCD2 As String = ""
    Private _PSESTADO As String = ""

    Private _PSTALMC As String = ""
    Private _PSTCMZNA As String = ""
    Private _PSTCMPAL As String = ""
    Private _PSTNMSCT As String = ""
    Private _PNCCLNT As Decimal = 0
    Private _esMovimientoInterno As Boolean = False

    Private _PSCTPALM_I As String = ""
    Private _PSCALMC_I As String = ""
    Private _PSCSECTR_I As String = ""
    Private _PSCPSCN_I As String = ""
    Private _PSCZNALM_I As String = ""
    Private _PSTALMC_I As String = ""
    Private _PSTCMPAL_I As String = ""
    Private _PSTCMZNA_I As String = ""
    Private _PSTNMSCT_I As String = ""
    Private _PNQTRMC_I As Decimal = 0
    Private _PSNTRMNL As String = ""
    Private _PSNTRMCR As String = ""
    Private _PNQTRMP As Decimal = 0
    Private _PNQTRMC As Decimal = 0
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PSTOBSRV As String = ""
    Private _PSEXISTEUBICACION As String = ""
    Private _PSREUBICACION As String = ""
    Private _PSCUSCRT As String = ""
    Private _PSINTERNO As String = ""
    Private _PSFLUJO As String = ""
    Private _PNCPLNFC As Decimal = 0

    Private _PSTPLNTA As String = ""
    Public Sub New()

    End Sub
    Public Property PSFLUJO() As String
        Get
            Return (_PSFLUJO)
        End Get
        Set(ByVal value As String)
            _PSFLUJO = value
        End Set
    End Property

    Public Property PSCTPALM_I() As String
        Get
            Return (_PSCTPALM_I)
        End Get
        Set(ByVal value As String)
            _PSCTPALM_I = value
        End Set
    End Property
    Public Property PSCALMC_I() As String
        Get
            Return (_PSCALMC_I)
        End Get
        Set(ByVal value As String)
            _PSCALMC_I = value
        End Set
    End Property
    Public Property PSCSECTR_I() As String
        Get
            Return (_PSCSECTR_I)
        End Get
        Set(ByVal value As String)
            _PSCSECTR_I = value
        End Set
    End Property
    Public Property PSCPSCN_I() As String
        Get
            Return (_PSCPSCN_I)
        End Get
        Set(ByVal value As String)
            _PSCPSCN_I = value
        End Set
    End Property

    Public Property PSCZNALM_I() As String
        Get
            Return (_PSCZNALM_I)
        End Get
        Set(ByVal value As String)
            _PSCZNALM_I = value
        End Set
    End Property

    Public Property PSTALMC_I() As String
        Get
            Return (_PSTALMC_I)
        End Get
        Set(ByVal value As String)
            _PSTALMC_I = value
        End Set
    End Property
    Public Property PSTCMPAL_I() As String
        Get
            Return (_PSTCMPAL_I)
        End Get
        Set(ByVal value As String)
            _PSTCMPAL_I = value
        End Set
    End Property
    Public Property PSTCMZNA_I() As String
        Get
            Return (_PSTCMZNA_I)
        End Get
        Set(ByVal value As String)
            _PSTCMZNA_I = value
        End Set
    End Property
    Public Property PSTNMSCT_I() As String
        Get
            Return (_PSTNMSCT_I)
        End Get
        Set(ByVal value As String)
            _PSTNMSCT_I = value
        End Set
    End Property



    Public Property PSNTRMNL() As String
        Get
            Return (_PSNTRMNL)
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
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

    Public Property PNQTRMP() As Decimal
        Get
            Return (_PNQTRMP)
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMP = value
        End Set
    End Property

    Public Property PNQTRMC() As Decimal
        Get
            Return (_PNQTRMC)
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMC = value
        End Set
    End Property
    Public Property PNQTRMC_I() As Decimal
        Get
            Return (_PNQTRMC_I)
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMC_I = value
        End Set
    End Property

    Public Property PSCCMPN() As String
        Get
            Return (_PSCCMPN)
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property
    Public Property PSCDVSN() As String
        Get
            Return (_PSCDVSN)
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property
    Public Property PSTOBSRV() As String
        Get
            Return (_PSTOBSRV)
        End Get
        Set(ByVal value As String)
            _PSTOBSRV = value
        End Set
    End Property
    Public Property PSEXISTEUBICACION() As String
        Get
            Return (_PSEXISTEUBICACION)
        End Get
        Set(ByVal value As String)
            _PSEXISTEUBICACION = value
        End Set
    End Property
    Public Property PSREUBICACION() As String
        Get
            Return (_PSREUBICACION)
        End Get
        Set(ByVal value As String)
            _PSREUBICACION = value
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

    Public Property PSINTERNO() As String
        Get
            Return (_PSINTERNO)
        End Get
        Set(ByVal value As String)
            _PSINTERNO = value
        End Set
    End Property





    Public Property esMovimientoInterno() As Boolean
        Get
            Return (_esMovimientoInterno)
        End Get
        Set(ByVal value As Boolean)
            _esMovimientoInterno = value
        End Set
    End Property


    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Public Property PSTNMSCT() As String
        Get
            Return (_PSTNMSCT)
        End Get
        Set(ByVal value As String)
            _PSTNMSCT = value
        End Set
    End Property


    Public Property PSTCMPAL() As String
        Get
            Return (_PSTCMPAL)
        End Get
        Set(ByVal value As String)
            _PSTCMPAL = value
        End Set
    End Property


    Public Property PSTCMZNA() As String
        Get
            Return (_PSTCMZNA)
        End Get
        Set(ByVal value As String)
            _PSTCMZNA = value
        End Set
    End Property

    Public Property PSTALMC() As String
        Get
            Return (_PSTALMC)
        End Get
        Set(ByVal value As String)
            _PSTALMC = value
        End Set
    End Property


    Public Property PNNORDSR() As Int64
        Get
            Return (_PNNORDSR)
        End Get
        Set(ByVal value As Int64)
            _PNNORDSR = value
        End Set
    End Property

    Public Property PSCTPALM() As String
        Get
            Return (_PSCTPALM)
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property
    Public Property PSCALMC() As String
        Get
            Return (_PSCALMC)
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property
    Public Property PSCSECTR() As String
        Get
            Return (_PSCSECTR)
        End Get
        Set(ByVal value As String)
            _PSCSECTR = value
        End Set
    End Property
    Public Property PSCPSCN() As String
        Get
            Return (_PSCPSCN)
        End Get
        Set(ByVal value As String)
            _PSCPSCN = value
        End Set
    End Property
    Public Property PSCPSLL() As String
        Get
            If _PSCPSLL Is Nothing Then _PSCPSLL = ""
            Return (_PSCPSLL)
        End Get
        Set(ByVal value As String)
            _PSCPSLL = value
        End Set
    End Property
    Public Property PSCCLMN() As String
        Get
            If _PSCCLMN Is Nothing Then _PSCCLMN = ""
            Return (_PSCCLMN)
        End Get
        Set(ByVal value As String)
            _PSCCLMN = value
        End Set
    End Property
    Public Property PSCPRFMR() As String
        Get
            Return (_PSCPRFMR)
        End Get
        Set(ByVal value As String)
            _PSCPRFMR = value
        End Set
    End Property
    Public Property PSCAPIMR() As String
        Get
            Return (_PSCAPIMR)
        End Get
        Set(ByVal value As String)
            _PSCAPIMR = value
        End Set
    End Property
    Public Property PSCROTMR() As String
        Get
            Return (_PSCROTMR)
        End Get
        Set(ByVal value As String)
            _PSCROTMR = value
        End Set
    End Property
    Public Property PNCSRVPK() As Decimal
        Get
            Return (_PNCSRVPK)
        End Get
        Set(ByVal value As Decimal)
            _PNCSRVPK = value
        End Set
    End Property
    Public Property PNNCOORX() As Decimal
        Get
            Return (_PNNCOORX)
        End Get
        Set(ByVal value As Decimal)
            _PNNCOORX = value
        End Set
    End Property
    Public Property PNNCOORY() As Decimal
        Get
            Return (_PNNCOORY)
        End Get
        Set(ByVal value As Decimal)
            _PNNCOORY = value
        End Set
    End Property
    Public Property PNNCOORZ() As Decimal
        Get
            Return (_PNNCOORZ)
        End Get
        Set(ByVal value As Decimal)
            _PNNCOORZ = value
        End Set
    End Property
    Public Property PNNCOOX2() As Decimal
        Get
            Return (_PNNCOOX2)
        End Get
        Set(ByVal value As Decimal)
            _PNNCOOX2 = value
        End Set
    End Property
    Public Property PNNCOOY2() As Decimal
        Get
            Return (_PNNCOOY2)
        End Get
        Set(ByVal value As Decimal)
            _PNNCOOY2 = value
        End Set
    End Property
    Public Property PNNCOOZ2() As Decimal
        Get
            Return (_PNNCOOZ2)
        End Get
        Set(ByVal value As Decimal)
            _PNNCOOZ2 = value
        End Set
    End Property
    Public Property PNQCMLRG() As Decimal
        Get
            Return (_PNQCMLRG)
        End Get
        Set(ByVal value As Decimal)
            _PNQCMLRG = value
        End Set
    End Property

    Public Property PNQSLETQ() As Decimal
        Get
            Return (_PNQSLETQ)
        End Get
        Set(ByVal value As Decimal)
            _PNQSLETQ = value
        End Set
    End Property

    Public Property PNQCMANC() As Decimal
        Get
            Return (_PNQCMANC)
        End Get
        Set(ByVal value As Decimal)
            _PNQCMANC = value
        End Set
    End Property
    Public Property PNQCMALT() As Decimal
        Get
            Return (_PNQCMALT)
        End Get
        Set(ByVal value As Decimal)
            _PNQCMALT = value
        End Set
    End Property
    Public Property PNCCLNRN() As Decimal
        Get
            Return (_PNCCLNRN)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNRN = value
        End Set
    End Property
    Public Property PSSSCPOS() As String
        Get
            If _PSSSCPOS Is Nothing Then _PSSSCPOS = ""
            Return (_PSSSCPOS)
        End Get
        Set(ByVal value As String)
            _PSSSCPOS = value
        End Set
    End Property
    Public Property PNPRCUSO() As Decimal
        Get
            Return (_PNPRCUSO)
        End Get
        Set(ByVal value As Decimal)
            _PNPRCUSO = value
        End Set
    End Property
    Public Property PSCZNALM() As String
        Get
            If _PSCZNALM Is Nothing Then _PSCZNALM = ""
            Return (_PSCZNALM)
        End Get
        Set(ByVal value As String)
            _PSCZNALM = value
        End Set
    End Property
    Public Property PSTFNCAC() As String
        Get
            If _PSTFNCAC Is Nothing Then _PSTFNCAC = ""
            Return (_PSTFNCAC)
        End Get
        Set(ByVal value As String)
            _PSTFNCAC = value
        End Set
    End Property
    Public Property PNFULTAC() As Decimal
        Get
            Return (_PNFULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return (_PNHULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            If _PSCULUSA Is Nothing Then _PSCULUSA = ""
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property PSSESTRG() As String
        Get
            If _PSSESTRG Is Nothing Then _PSSESTRG = ""
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
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

    Public Property PSCLIENTE() As String
        Get
            Return (_PSCLIENTE)
        End Get
        Set(ByVal value As String)
            _PSCLIENTE = value
        End Set
    End Property

    Public Property PSTCMPOP() As String
        Get
            Return (_PSTCMPOP)
        End Get
        Set(ByVal value As String)
            _PSTCMPOP = value
        End Set
    End Property

    Public Property PSTIPO() As String
        Get
            Return (_PSTIPO)
        End Get
        Set(ByVal value As String)
            _PSTIPO = value
        End Set
    End Property

    Public Property PSALMACEN() As String
        Get
            Return (_PSALMACEN)
        End Get
        Set(ByVal value As String)
            _PSALMACEN = value
        End Set
    End Property

    Public Property PSTMRCD2() As String
        Get
            Return (_PSTMRCD2)
        End Get
        Set(ByVal value As String)
            _PSTMRCD2 = value
        End Set
    End Property

    Public Property PSESTADO() As String
        Get
            Return (_PSESTADO)
        End Get
        Set(ByVal value As String)
            _PSESTADO = value
        End Set
    End Property


    Private _PNNCRRIN As Decimal
    Public Property PNNCRRIN() As Decimal
        Get
            Return _PNNCRRIN
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRIN = value
        End Set
    End Property


    Private _PSTIPO_ALMACEN As String = ""
    Public Property PSTIPO_ALMACEN() As String
        Get
            Return _PSTIPO_ALMACEN
        End Get
        Set(ByVal value As String)
            _PSTIPO_ALMACEN = value
        End Set
    End Property

 

    Private _PSZONA As String = ""
    Public Property PSZONA() As String
        Get
            Return _PSZONA
        End Get
        Set(ByVal value As String)
            _PSZONA = value
        End Set
    End Property


    Public Property PNCPLNFC() As Decimal
        Get
            Return _PNCPLNFC
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNFC = value
        End Set
    End Property

    Public Property PSTPLNTA() As String
        Get
            Return _PSTPLNTA
        End Get
        Set(ByVal value As String)
            _PSTPLNTA = value
        End Set
    End Property

   



End Class