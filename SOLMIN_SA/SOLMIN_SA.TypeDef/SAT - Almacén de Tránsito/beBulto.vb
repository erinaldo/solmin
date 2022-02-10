Public Class beBulto
    'Inherits beBultoPK
    Inherits beBase(Of beBulto)

    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub

    ''' <summary>
    ''' Dagnino 09/25/2015
    ''' </summary>
    ''' <remarks></remarks>
    Private _PSCCMPN As String
    Private _PSCDVSN As String
    Private _PNCPLNDV As Decimal
    Private _PNCCLNT As Decimal
    Private _PSCREFFW As String
    Private _PNFSLFFW As Decimal
    Private _PSCBLTOR As String
    Private _PSCREEMB As String
    Private _PSDESCWB As String
    Private _PSTDSCIT As String
    Private _PNQREFFW As Decimal
    Private _PSTIPBTO As String
    Private _PNQPSOBL As Decimal
    Private _PSTUNPSO As String
    Private _PNQVLBTO As Decimal
    Private _PSTUNVOL As String
    Private _PNQAROCP As Decimal
    Private _PNQMTALT As Decimal
    Private _PNQMTANC As Decimal
    Private _PNQMTLRG As Decimal
    Private _PSCTPALM As String
    Private _PSCALMC As String
    Private _PSCZNALM As String
    Private _PSTUBRFR As String
    Private _PSSSTINV As String
    Private _PNFINGAL As Decimal
    Private _PNFSLDAL As Decimal
    Private _PNNGUIRM As Decimal
    Private _PNNROCTL As Decimal
    Private _PSSTRNSM As String
    Private _PNNORAGN As Decimal
    Private _PSSALTEM As String
    Private _PSSMTRCP As String
    Private _PSSSNCRG As String
    Private _PSCRTLTE As String
    Private _PNNTCKPS As Decimal
    Private _PSDCENSA As String
    Private _PSSTPING As String
    Private _PNNOPREC As Decimal
    Private _PNNOPDES As Decimal
    Private _PNCMEDTS As Decimal
    Private _PSRPNMSO As String
    Private _PSRPNMSD As String
    Private _PSFLGCNL As String
    Private _PNFCNFCL As Decimal
    Private _PNHCNFCL As Decimal
    Private _PSSTPREC As String
    Private _PSSTPDPC As String
    Private _PNFULFAC As Decimal
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSCUSCRT As String
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal
    Private _PSNORCML As String
    Private _PNNRITOC As Decimal
    Private _PSNFACPR As String
    Private _PSNRITFP As String
    Private _PNFFACPR As Decimal
    Private _PNNGUIPR As Decimal
    Private _PNQCNTDC As Decimal
    Private _PNQBLTSR As Decimal
    Private _PNQSLCNB As Decimal
    Private _PSSSTBLT As String
    Private _PSSITMAT As String
    Private _PNQBLRCO As Decimal
    Private _PSTTIPPQ As String
    Private _PNQPEPQT As Decimal
    Private _PNQVOPQT As Decimal
    Private _PNNRWBLL As Decimal
    Private _PSNFACMR As String
    Private _PSFLGQDM As String
    Private _PNLANCOS As Decimal
    Private _PSNFCPRT As String
    Private _PSNITPRT As String
    Private _PNFFCPRT As Decimal
    Private _PSNGRPRV As String
    Private _PNNRGUSA As Decimal
    Private _PSNMNFTF As String
    Private _PNNSEQCR As Decimal
    Private _PSMARRET As String
    Private _PSTNMMDT As String
    'Private _PSSTPDES As String
    '--------ACD------------
    Private _PSTCTCST As String
    Private _FECHA_INI As Integer
    Private _FECHA_FIN As Integer
    Private _PSMEDSUG As String
    Private _PSLOTE As String
    Private _PNISPARCIAL As Integer
    Private _PSNORCML_DESTINO As String
    Private _PNNRITOC_DESTINO As Decimal
    Private _PSCODCLIE As String
    Private _CLARSG As String
    Private _NROONU As String
    Private _TPOEMB As String
    Private _PSTCTCAL As String
    Private _PSUNSPSC As String = ""

    Private _PSNGUIRS As String = ""
    Private _PSNGUITS As String = ""
    Public Property PSLOTE() As String
        Get
            Return _PSLOTE
        End Get
        Set(ByVal value As String)
            _PSLOTE = value
        End Set
    End Property

    Public Property PSMEDSUG() As String
        Get
            Return _PSMEDSUG
        End Get
        Set(ByVal value As String)
            _PSMEDSUG = value
        End Set
    End Property

    Public Property FECHA_INI() As Integer
        Get
            Return (_FECHA_INI)
        End Get
        Set(ByVal value As Integer)
            _FECHA_INI = value
        End Set
    End Property

    Public Property FECHA_FIN() As Integer
        Get
            Return (_FECHA_FIN)
        End Get
        Set(ByVal value As Integer)
            _FECHA_FIN = value
        End Set
    End Property

    Public Property PSTCTCST() As String
        Get
            Return (_PSTCTCST)
        End Get
        Set(ByVal value As String)
            _PSTCTCST = value
        End Set
    End Property
    '---------------------
    Public Property PSNORCML() As String
        Get
            Return (_PSNORCML)
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property


    Private _PSTDSCML As String
    Public Property PSTDSCML() As String
        Get
            Return _PSTDSCML
        End Get
        Set(ByVal value As String)
            _PSTDSCML = value
        End Set
    End Property

    Public Property PNNRITOC() As Decimal
        Get
            Return (_PNNRITOC)
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC = value
        End Set
    End Property
    ''' <summary>
    ''' Número de Factura Proveedor
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSNFACPR() As String
        Get
            Return (_PSNFACPR)
        End Get
        Set(ByVal value As String)
            _PSNFACPR = value
        End Set
    End Property
    Public Property PSNRITFP() As String
        Get
            Return (_PSNRITFP)
        End Get
        Set(ByVal value As String)
            _PSNRITFP = value
        End Set
    End Property
    ''' <summary>
    ''' Fecha Factura Proveedor 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNFFACPR() As Decimal
        Get
            Return (_PNFFACPR)
        End Get
        Set(ByVal value As Decimal)
            _PNFFACPR = value
        End Set
    End Property



    ''' <summary>
    '''Fecha Factura Proveedor 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaFacturaProveedor() As Date
        Get
            Return NumeroAFecha(_PNFFACPR)
        End Get
        Set(ByVal value As Date)
            _PNFFACPR = CtypeDate(value)
        End Set
    End Property


    Public Property PNNGUIPR() As Decimal
        Get
            Return (_PNNGUIPR)
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIPR = value
        End Set
    End Property
    Public Property PNQCNTDC() As Decimal
        Get
            Return (_PNQCNTDC)
        End Get
        Set(ByVal value As Decimal)
            _PNQCNTDC = value
        End Set
    End Property
    Public Property PNQBLTSR() As Decimal
        Get
            Return (_PNQBLTSR)
        End Get
        Set(ByVal value As Decimal)
            _PNQBLTSR = value
        End Set
    End Property
    Public Property PNQSLCNB() As Decimal
        Get
            Return (_PNQSLCNB)
        End Get
        Set(ByVal value As Decimal)
            _PNQSLCNB = value
        End Set
    End Property
    Public Property PSSSTBLT() As String
        Get
            Return (_PSSSTBLT)
        End Get
        Set(ByVal value As String)
            _PSSSTBLT = value
        End Set
    End Property
    Public Property PSSITMAT() As String
        Get
            Return (_PSSITMAT)
        End Get
        Set(ByVal value As String)
            _PSSITMAT = value
        End Set
    End Property
    Public Property PNQBLRCO() As Decimal
        Get
            Return (_PNQBLRCO)
        End Get
        Set(ByVal value As Decimal)
            _PNQBLRCO = value
        End Set
    End Property
    Public Property PSTTIPPQ() As String
        Get
            Return (_PSTTIPPQ)
        End Get
        Set(ByVal value As String)
            _PSTTIPPQ = value
        End Set
    End Property
    Public Property PNQPEPQT() As Decimal
        Get
            Return (_PNQPEPQT)
        End Get
        Set(ByVal value As Decimal)
            _PNQPEPQT = value
        End Set
    End Property
    Public Property PNQVOPQT() As Decimal
        Get
            Return (_PNQVOPQT)
        End Get
        Set(ByVal value As Decimal)
            _PNQVOPQT = value
        End Set
    End Property
    Public Property PNNRWBLL() As Decimal
        Get
            Return (_PNNRWBLL)
        End Get
        Set(ByVal value As Decimal)
            _PNNRWBLL = value
        End Set
    End Property
    Public Property PSNFACMR() As String
        Get
            Return (_PSNFACMR)
        End Get
        Set(ByVal value As String)
            _PSNFACMR = value
        End Set
    End Property
    Public Property PSFLGQDM() As String
        Get
            Return (_PSFLGQDM)
        End Get
        Set(ByVal value As String)
            _PSFLGQDM = value
        End Set
    End Property
    Public Property PSMARRET() As String
        Get
            Return (_PSMARRET)
        End Get
        Set(ByVal value As String)
            _PSMARRET = value
        End Set
    End Property
    Public Property PNLANCOS() As Decimal
        Get
            Return (_PNLANCOS)
        End Get
        Set(ByVal value As Decimal)
            _PNLANCOS = value
        End Set
    End Property
    Public Property PSNFCPRT() As String
        Get
            Return (_PSNFCPRT)
        End Get
        Set(ByVal value As String)
            _PSNFCPRT = value
        End Set
    End Property
    Public Property PSNITPRT() As String
        Get
            Return (_PSNITPRT)
        End Get
        Set(ByVal value As String)
            _PSNITPRT = value
        End Set
    End Property
    Public Property PNFFCPRT() As Decimal
        Get
            Return (_PNFFCPRT)
        End Get
        Set(ByVal value As Decimal)
            _PNFFCPRT = value
        End Set
    End Property
    Public Property PSNGRPRV() As String
        Get
            Return (_PSNGRPRV)
        End Get
        Set(ByVal value As String)
            _PSNGRPRV = value
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

    Public Property PNNRGUSA() As Decimal
        Get
            Return (_PNNRGUSA)
        End Get
        Set(ByVal value As Decimal)
            _PNNRGUSA = value
        End Set
    End Property
    Public Property PSNMNFTF() As String
        Get
            Return (_PSNMNFTF)
        End Get
        Set(ByVal value As String)
            _PSNMNFTF = value
        End Set
    End Property
    Public Property PNNSEQCR() As Decimal
        Get
            Return (_PNNSEQCR)
        End Get
        Set(ByVal value As Decimal)
            _PNNSEQCR = value
        End Set
    End Property


    Private _PSCIDPAQ As String
    Public Property PSCIDPAQ() As String
        Get
            Return (_PSCIDPAQ)
        End Get
        Set(ByVal value As String)
            _PSCIDPAQ = value
        End Set
    End Property


    'Public Property PSSTPDES() As String
    '    Get
    '        Return _PSSTPDES
    '    End Get
    '    Set(ByVal value As String)
    '        _PSSTPDES = value
    '    End Set
    'End Property




#Region "ATRUBUTOS ADISIONALES"


    Private _PSMSGERR As String
    ''' <summary>
    ''' Atributo creado para retornar el error
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSMSGERR() As String
        Get
            Return _PSMSGERR
        End Get
        Set(ByVal value As String)
            _PSMSGERR = value
        End Set
    End Property

    Private _PSTDITES As String
    Public Property PSTDITES() As String
        Get
            Return _PSTDITES
        End Get
        Set(ByVal value As String)
            _PSTDITES = value
        End Set
    End Property


    Private _PSTLUGEN As String
    Public Property PSTLUGEN() As String
        Get
            Return _PSTLUGEN
        End Get
        Set(ByVal value As String)
            _PSTLUGEN = value
        End Set
    End Property


    Private _PSDSREFE As String
    ''' <summary>
    ''' referencia (usuario que realiza la recepcion fisica de la mercadería en ALMACEN)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSDSREFE() As String
        Get
            Return _PSDSREFE
        End Get
        Set(ByVal value As String)
            _PSDSREFE = value
        End Set
    End Property


    Private _PNESTADO As Decimal
    Public Property PNESTADO() As Decimal
        Get
            Return _PNESTADO
        End Get
        Set(ByVal value As Decimal)
            _PNESTADO = value
        End Set
    End Property

    Private _PNNRSITEM As Integer
    Public Property PNNRSITEM() As Integer
        Get
            Return _PNNRSITEM
        End Get
        Set(ByVal value As Integer)
            _PNNRSITEM = value
        End Set
    End Property


    Private _PNNITEMS As Integer
    Public Property PNNITEMS() As Integer
        Get
            Return _PNNITEMS
        End Get
        Set(ByVal value As Integer)
            _PNNITEMS = value
        End Set
    End Property






    Private _PSSMTRCP_D As String
    Public Property PSSMTRCP_D() As String
        Get
            Return _PSSMTRCP_D
        End Get
        Set(ByVal value As String)
            _PSSMTRCP_D = value
        End Set
    End Property


    Private _PSSSNCRG_D As String
    Public Property PSSSNCRG_D() As String
        Get
            Return _PSSSNCRG_D
        End Get
        Set(ByVal value As String)
            _PSSSNCRG_D = value
        End Set
    End Property


    Private _PNNROPLT As Decimal
    Public Property PNNROPLT() As Decimal
        Get
            Return _PNNROPLT
        End Get
        Set(ByVal value As Decimal)
            _PNNROPLT = value
        End Set
    End Property


    Private _PSCOD_STPDES As String
    Public Property PSCOD_STPDES() As String
        Get
            Return _PSCOD_STPDES
        End Get
        Set(ByVal value As String)
            _PSCOD_STPDES = value
        End Set
    End Property


    Private _PNFREFFW As Decimal

    Public Property PNFREFFW() As Decimal
        Get
            Return _PNFREFFW
        End Get
        Set(ByVal value As Decimal)
            _PNFREFFW = value
        End Set
    End Property


    ''' <summary>
    ''' fecha de ingreso
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FECING() As String
        Get
            Return NumeroAFecha(_PNFREFFW)
        End Get
    End Property

    Private _PSSBITOC As String

    Public Property PSSBITOC() As String
        Get
            Return _PSSBITOC
        End Get
        Set(ByVal value As String)
            _PSSBITOC = value
        End Set
    End Property


    Private _PSTCITCL As String
    Public Property PSTCITCL() As String
        Get
            Return _PSTCITCL
        End Get
        Set(ByVal value As String)
            _PSTCITCL = value
        End Set
    End Property


    Private _TCMAEM As String
    Public Property PSTCMAEM() As String
        Get
            Return _TCMAEM
        End Get
        Set(ByVal value As String)
            _TCMAEM = value
        End Set
    End Property

    Private _PSTCITPR As String
    Public Property PSTCITPR() As String
        Get
            Return _PSTCITPR
        End Get
        Set(ByVal value As String)
            _PSTCITPR = value
        End Set
    End Property


    Private _PSCPTDAR As String
    Public Property PSCPTDAR() As String
        Get
            Return _PSCPTDAR
        End Get
        Set(ByVal value As String)
            _PSCPTDAR = value
        End Set
    End Property


    Private _PNQCNTIT As Decimal
    Public Property PNQCNTIT() As Decimal
        Get
            Return _PNQCNTIT
        End Get
        Set(ByVal value As Decimal)
            _PNQCNTIT = value
        End Set
    End Property


    Private _PSTUNDIT As String
    Public Property PSTUNDIT() As String
        Get
            Return _PSTUNDIT
        End Get
        Set(ByVal value As String)
            _PSTUNDIT = value
        End Set
    End Property

    Private _PNIVUNIT As Decimal
    Public Property PNIVUNIT() As Decimal
        Get
            Return _PNIVUNIT
        End Get
        Set(ByVal value As Decimal)
            _PNIVUNIT = value
        End Set
    End Property


    Private _PNIVTOIT As Decimal
    Public Property PNIVTOIT() As Decimal
        Get
            Return _PNIVTOIT
        End Get
        Set(ByVal value As Decimal)
            _PNIVTOIT = value
        End Set
    End Property

    Private _PNQCNPEN As Decimal
    Public Property PNQCNPEN() As Decimal
        Get
            Return _PNQCNPEN
        End Get
        Set(ByVal value As Decimal)
            _PNQCNPEN = value
        End Set
    End Property


    Private _PNQCNRCP As Decimal
    Public Property PNQCNRCP() As Decimal
        Get
            Return _PNQCNRCP
        End Get
        Set(ByVal value As Decimal)
            _PNQCNRCP = value
        End Set
    End Property


#End Region




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
    Public Property PNCPLNDV() As Decimal
        Get
            Return (_PNCPLNDV)
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    Private _PNPLANDES As Decimal
    Public Property PNPLANDES() As Decimal
        Get
            Return _PNPLANDES
        End Get
        Set(ByVal value As Decimal)
            _PNPLANDES = value
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

    Public Property PSCREFFW() As String
        Get
            Return (_PSCREFFW)
        End Get
        Set(ByVal value As String)
            _PSCREFFW = value
        End Set
    End Property


    Private _PNNSEQIN As Decimal
    Public Property PNNSEQIN() As Decimal
        Get
            Return _PNNSEQIN
        End Get
        Set(ByVal value As Decimal)
            _PNNSEQIN = value
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



    Public Property PNFSLFFW() As Decimal
        Get
            Return (_PNFSLFFW)
        End Get
        Set(ByVal value As Decimal)
            _PNFSLFFW = value
        End Set
    End Property


    Public Property PSCBLTOR() As String
        Get
            Return (_PSCBLTOR)
        End Get
        Set(ByVal value As String)
            _PSCBLTOR = value
        End Set
    End Property

    Public Property PSCREEMB() As String
        Get
            Return (_PSCREEMB)
        End Get
        Set(ByVal value As String)
            _PSCREEMB = value
        End Set
    End Property
    Public Property PSDESCWB() As String
        Get
            Return (_PSDESCWB)
        End Get
        Set(ByVal value As String)
            _PSDESCWB = value
        End Set
    End Property


    Private _PNIPBULT As Decimal
    Public Property PNIPBULT() As Decimal
        Get
            Return _PNIPBULT
        End Get
        Set(ByVal value As Decimal)
            _PNIPBULT = value
        End Set
    End Property

    Public Property PSTDSCIT() As String
        Get
            Return (_PSTDSCIT)
        End Get
        Set(ByVal value As String)
            _PSTDSCIT = value
        End Set
    End Property
    Public Property PNQREFFW() As Decimal
        Get
            Return (_PNQREFFW)
        End Get
        Set(ByVal value As Decimal)
            _PNQREFFW = value
        End Set
    End Property
    Public Property PSTIPBTO() As String
        Get
            Return (_PSTIPBTO)
        End Get
        Set(ByVal value As String)
            _PSTIPBTO = value
        End Set
    End Property
    Public Property PNQPSOBL() As Decimal
        Get
            Return (_PNQPSOBL)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSOBL = value
        End Set
    End Property
    Public Property PSTUNPSO() As String
        Get
            Return (_PSTUNPSO)
        End Get
        Set(ByVal value As String)
            _PSTUNPSO = value
        End Set
    End Property
    Public Property PNQVLBTO() As Decimal
        Get
            Return (_PNQVLBTO)
        End Get
        Set(ByVal value As Decimal)
            _PNQVLBTO = value
        End Set
    End Property
    Public Property PSTUNVOL() As String
        Get
            Return (_PSTUNVOL)
        End Get
        Set(ByVal value As String)
            _PSTUNVOL = value
        End Set
    End Property
    Public Property PNQAROCP() As Decimal
        Get
            Return (_PNQAROCP)
        End Get
        Set(ByVal value As Decimal)
            _PNQAROCP = value
        End Set
    End Property
    Public Property PNQMTALT() As Decimal
        Get
            Return (_PNQMTALT)
        End Get
        Set(ByVal value As Decimal)
            _PNQMTALT = value
        End Set
    End Property
    Public Property PNQMTANC() As Decimal
        Get
            Return (_PNQMTANC)
        End Get
        Set(ByVal value As Decimal)
            _PNQMTANC = value
        End Set
    End Property
    Public Property PNQMTLRG() As Decimal
        Get
            Return (_PNQMTLRG)
        End Get
        Set(ByVal value As Decimal)
            _PNQMTLRG = value
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
    Public Property PSCZNALM() As String
        Get
            Return (_PSCZNALM)
        End Get
        Set(ByVal value As String)
            _PSCZNALM = value
        End Set
    End Property
    Public Property PSTUBRFR() As String
        Get
            Return (_PSTUBRFR)
        End Get
        Set(ByVal value As String)
            _PSTUBRFR = value
        End Set
    End Property
    Public Property PSSSTINV() As String
        Get
            Return (_PSSSTINV)
        End Get
        Set(ByVal value As String)
            _PSSSTINV = value
        End Set
    End Property
    Public Property PNFINGAL() As Decimal
        Get
            Return (_PNFINGAL)
        End Get
        Set(ByVal value As Decimal)
            _PNFINGAL = value
        End Set
    End Property
    Public Property PNFSLDAL() As Decimal
        Get
            Return (_PNFSLDAL)
        End Get
        Set(ByVal value As Decimal)
            _PNFSLDAL = value
        End Set
    End Property
    Public Property PNNGUIRM() As Decimal
        Get
            Return (_PNNGUIRM)
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRM = value
        End Set
    End Property



    Private _PNCODTRA As Decimal
    ''' <summary>
    ''' Código de Transportista
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNCODTRA() As Decimal
        Get
            Return _PNCODTRA
        End Get
        Set(ByVal value As Decimal)
            _PNCODTRA = value
        End Set
    End Property


    Private _PNGUITRA As Decimal
    ''' <summary>
    ''' Guía Transportista
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNGUITRA() As Decimal
        Get
            Return _PNGUITRA
        End Get
        Set(ByVal value As Decimal)
            _PNGUITRA = value
        End Set
    End Property

    Public Property PNNROCTL() As Decimal
        Get
            Return (_PNNROCTL)
        End Get
        Set(ByVal value As Decimal)
            _PNNROCTL = value
        End Set
    End Property
    ''' <summary>
    ''' Sentido de Carga
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSSTRNSM() As String
        Get
            Return (_PSSTRNSM)
        End Get
        Set(ByVal value As String)
            _PSSTRNSM = value
        End Set
    End Property
    Public Property PNNORAGN() As Decimal
        Get
            Return (_PNNORAGN)
        End Get
        Set(ByVal value As Decimal)
            _PNNORAGN = value
        End Set
    End Property
    Public Property PSSALTEM() As String
        Get
            Return (_PSSALTEM)
        End Get
        Set(ByVal value As String)
            _PSSALTEM = value
        End Set
    End Property
    Public Property PSSMTRCP() As String
        Get
            Return (_PSSMTRCP)
        End Get
        Set(ByVal value As String)
            _PSSMTRCP = value
        End Set
    End Property
    Public Property PSSSNCRG() As String
        Get
            Return (_PSSSNCRG)
        End Get
        Set(ByVal value As String)
            _PSSSNCRG = value
        End Set
    End Property


    Private _PSTOBSGS As String
    Public Property PSTOBSGS() As String
        Get
            Return _PSTOBSGS
        End Get
        Set(ByVal value As String)
            _PSTOBSGS = value
        End Set
    End Property

    Public Property PSCRTLTE() As String
        Get
            Return (_PSCRTLTE)
        End Get
        Set(ByVal value As String)
            _PSCRTLTE = value
        End Set
    End Property
    Public Property PNNTCKPS() As Decimal
        Get
            Return (_PNNTCKPS)
        End Get
        Set(ByVal value As Decimal)
            _PNNTCKPS = value
        End Set
    End Property
    Public Property PSDCENSA() As String
        Get
            Return (_PSDCENSA)
        End Get
        Set(ByVal value As String)
            _PSDCENSA = value
        End Set
    End Property



    Private _PSNUMDES As String
    Public Property PSNUMDES() As String
        Get
            Return _PSNUMDES
        End Get
        Set(ByVal value As String)
            _PSNUMDES = value
        End Set
    End Property

    Public Property PSSTPING() As String
        Get
            Return (_PSSTPING)
        End Get
        Set(ByVal value As String)
            _PSSTPING = value
        End Set
    End Property


    Private _PSSTPING_D As String
    Public Property PSSTPING_D() As String
        Get
            Return _PSSTPING_D
        End Get
        Set(ByVal value As String)
            _PSSTPING_D = value
        End Set
    End Property

    Public Property PNNOPREC() As Decimal
        Get
            Return (_PNNOPREC)
        End Get
        Set(ByVal value As Decimal)
            _PNNOPREC = value
        End Set
    End Property
    Public Property PNNOPDES() As Decimal
        Get
            Return (_PNNOPDES)
        End Get
        Set(ByVal value As Decimal)
            _PNNOPDES = value
        End Set
    End Property
    Public Property PNCMEDTS() As Decimal
        Get
            Return (_PNCMEDTS)
        End Get
        Set(ByVal value As Decimal)
            _PNCMEDTS = value
        End Set
    End Property
    Public Property PSRPNMSO() As String
        Get
            Return (_PSRPNMSO)
        End Get
        Set(ByVal value As String)
            _PSRPNMSO = value
        End Set
    End Property
    Public Property PSRPNMSD() As String
        Get
            Return (_PSRPNMSD)
        End Get
        Set(ByVal value As String)
            _PSRPNMSD = value
        End Set
    End Property
    Public Property PSFLGCNL() As String
        Get
            Return (_PSFLGCNL)
        End Get
        Set(ByVal value As String)
            _PSFLGCNL = value
        End Set
    End Property


    Private _PSTOBSEN As String
    Public Property PSTOBSEN() As String
        Get
            Return _PSTOBSEN
        End Get
        Set(ByVal value As String)
            _PSTOBSEN = value
        End Set
    End Property

    Public Property PNFCNFCL() As Decimal
        Get
            Return (_PNFCNFCL)
        End Get
        Set(ByVal value As Decimal)
            _PNFCNFCL = value
        End Set
    End Property
    Public Property PNHCNFCL() As Decimal
        Get
            Return (_PNHCNFCL)
        End Get
        Set(ByVal value As Decimal)
            _PNHCNFCL = value
        End Set
    End Property
    Public Property PSSTPREC() As String
        Get
            Return (_PSSTPREC)
        End Get
        Set(ByVal value As String)
            _PSSTPREC = value
        End Set
    End Property
    Public Property PSSTPDPC() As String
        Get
            Return (_PSSTPDPC)
        End Get
        Set(ByVal value As String)
            _PSSTPDPC = value
        End Set
    End Property
    Public Property PNFULFAC() As Decimal
        Get
            Return (_PNFULFAC)
        End Get
        Set(ByVal value As Decimal)
            _PNFULFAC = value
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
    Public Property PSCUSCRT() As String
        Get
            Return (_PSCUSCRT)
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
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
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property PSSESTRG() As String
        Get
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



    Public Property PSTNMMDT() As String
        Get
            Return _PSTNMMDT
        End Get
        Set(ByVal value As String)
            _PSTNMMDT = value
        End Set
    End Property


    Private _PSMEDCONF As String
    Public Property PSMEDCONF() As String
        Get
            Return _PSMEDCONF
        End Get
        Set(ByVal value As String)
            _PSMEDCONF = value
        End Set
    End Property


    Private _PSTCTCSA As String

    ''' <summary>
    ''' iMPUTACION AEREA
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTCTCSA() As String
        Get
            Return _PSTCTCSA
        End Get
        Set(ByVal value As String)
            _PSTCTCSA = value
        End Set
    End Property


    Private _PSTCTCSF As String
    ''' <summary>
    ''' imPUTACION FLUVIAL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTCTCSF() As String
        Get
            Return _PSTCTCSF
        End Get
        Set(ByVal value As String)
            _PSTCTCSF = value
        End Set
    End Property



    Private _PSTCTAFE As String
    Public Property PSTCTAFE() As String
        Get
            Return _PSTCTAFE
        End Get
        Set(ByVal value As String)
            _PSTCTAFE = value
        End Set
    End Property

    Private _PNCMEDTC As Decimal
    Public Property PNCMEDTC() As Decimal
        Get
            Return _PNCMEDTC
        End Get
        Set(ByVal value As Decimal)
            _PNCMEDTC = value
        End Set
    End Property


    Private _PNFECINI As Decimal
    Public Property PNFECINI() As Decimal
        Get
            Return _PNFECINI
        End Get
        Set(ByVal value As Decimal)
            _PNFECINI = value
        End Set
    End Property






    Private _PNFECFIN As Decimal
    Public Property PNFECFIN() As Decimal
        Get
            Return _PNFECFIN
        End Get
        Set(ByVal value As Decimal)
            _PNFECFIN = value
        End Set
    End Property


    Private _PSTTINTC As String
    Public Property PSTTINTC() As String
        Get
            Return _PSTTINTC
        End Get
        Set(ByVal value As String)
            _PSTTINTC = value
        End Set
    End Property

    Private _CHECK As Boolean
    Public Property CHECK() As Boolean
        Get
            Return _CHECK
        End Get
        Set(ByVal value As Boolean)
            _CHECK = value
        End Set
    End Property


    Private _PSTIPO As String
    Public Property PSTIPO() As String
        Get
            Return _PSTIPO
        End Get
        Set(ByVal value As String)
            _PSTIPO = value
        End Set
    End Property

    Private _PSFECBULTO As String

    Public Property PSFECBULTO() As String
        Get
            Return _PSFECBULTO
        End Get
        Set(ByVal value As String)
            _PSFECBULTO = value
        End Set
    End Property



    Private _PSTPRVCL As String
    Public Property PSTPRVCL() As String
        Get
            Return _PSTPRVCL
        End Get
        Set(ByVal value As String)
            _PSTPRVCL = value
        End Set
    End Property
    Private _PSNREFCL As String

    Public Property PSNREFCL() As String
        Get
            Return _PSNREFCL
        End Get
        Set(ByVal value As String)
            _PSNREFCL = value
        End Set
    End Property

    Public Property PNISPARCIAL() As Integer
        Get
            Return _PNISPARCIAL
        End Get
        Set(ByVal value As Integer)
            _PNISPARCIAL = value
        End Set
    End Property

    Public Property PSNORCML_DESTINO() As String
        Get
            Return _PSNORCML_DESTINO
        End Get
        Set(ByVal value As String)
            _PSNORCML_DESTINO = value
        End Set
    End Property

    Public Property PNNRITOC_DESTINO() As Decimal
        Get
            Return _PNNRITOC_DESTINO
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC_DESTINO = value
        End Set
    End Property


    Private _PSPLANTA As String
    Public Property PSPLANTA() As String
        Get
            Return _PSPLANTA
        End Get
        Set(ByVal value As String)
            _PSPLANTA = value
        End Set
    End Property



    Private _PNCATCOPYA As Decimal
    ''' <summary>
    ''' Cantidad de copia que se puede realizar al imprimir en la impresora Zebra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNCATCOPYA() As Decimal
        Get
            Return _PNCATCOPYA
        End Get
        Set(ByVal value As Decimal)
            _PNCATCOPYA = value
        End Set
    End Property

    Private _PNFRQALC As Decimal

    Public Property PNFRQALC() As Decimal
        Get
            Return _PNFRQALC
        End Get
        Set(ByVal value As Decimal)
            _PNFRQALC = value
        End Set
    End Property

    ''' <summary>
    ''' Fecha Requerida Almacen Cliente 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSFechaReqAlmacen() As String
        Get
            Return NumeroAFecha(_PNFRQALC)
        End Get
        Set(ByVal value As String)
            _PNFRQALC = CtypeDate(value)
        End Set
    End Property

    ''' <summary>
    ''' Fecha de ing. Almacen
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaIngAlmacen() As String
        Get
            Return NumeroAFecha(_PNFINGAL)
        End Get
        Set(ByVal value As String)
            _PNFINGAL = CtypeDate(value)
        End Set
    End Property

    ''' <summary>
    ''' Fecha de ingreso Almacen Centro logistico
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaIngAlmacenCL() As String
        Get
            Return NumeroAFecha(_PNFREFFW)
        End Get
        Set(ByVal value As String)
            _PNFREFFW = CtypeDate(value)
        End Set
    End Property

    ''' <summary>
    ''' Fecha Salida almacen
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaSalAlmacen() As String
        Get
            Return NumeroAFecha(_PNFSLDAL)
        End Get
        Set(ByVal value As String)
            _PNFSLDAL = CtypeDate(value)
        End Set
    End Property

    ''' <summary>
    ''' fecha de Salida Almacen Centro Logistico
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaSalAlmacenCL() As String
        Get
            Return NumeroAFecha(_PNFSLFFW)
        End Get
        Set(ByVal value As String)
            _PNFSLFFW = CtypeDate(value)
        End Set
    End Property

    Private _PSTLUGOR As String
    ''' <summary>S
    ''' Lugar de Origen
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTLUGOR() As String
        Get
            Return _PSTLUGOR
        End Get
        Set(ByVal value As String)
            _PSTLUGOR = value
        End Set
    End Property





    Private _PNQPSTKI As Decimal
    Public Property PNQPSTKI() As Decimal
        Get
            Return _PNQPSTKI
        End Get
        Set(ByVal value As Decimal)
            _PNQPSTKI = value
        End Set
    End Property


    Private _PNQCNREC As Decimal
    Public Property PNQCNREC() As Decimal
        Get
            Return _PNQCNREC
        End Get
        Set(ByVal value As Decimal)
            _PNQCNREC = value
        End Set
    End Property


    Private _PSTDAITM As String
    Public Property PSTDAITM() As String
        Get
            Return _PSTDAITM
        End Get
        Set(ByVal value As String)
            _PSTDAITM = value
        End Set
    End Property


    Private _PNISDIST As Decimal
    ''' <summary>
    ''' Es cuenta de imputacion por distribucion 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNISDIST() As Decimal
        Get
            Return _PNISDIST
        End Get
        Set(ByVal value As Decimal)
            _PNISDIST = value
        End Set
    End Property
    Private _CPRCN1 As String
    Public Property PSCPRCN1() As String
        Get
            Return _CPRCN1
        End Get
        Set(ByVal value As String)
            _CPRCN1 = value
        End Set
    End Property

    Private _NSRCN1 As String
    Public Property PSNSRCN1() As String
        Get
            Return _NSRCN1
        End Get
        Set(ByVal value As String)
            _NSRCN1 = value
        End Set
    End Property
    Private _STPOCR As String
    Public Property PSSTPOCR() As String
        Get
            Return _STPOCR
        End Get
        Set(ByVal value As String)
            _STPOCR = value
        End Set
    End Property


    Private _PNQCTPQT As Decimal
    Public Property PNQCTPQT() As Decimal
        Get
            Return _PNQCTPQT
        End Get
        Set(ByVal value As Decimal)
            _PNQCTPQT = value
        End Set
    End Property


    Private _PNQVOLMR As Decimal
    Public Property PNQVOLMR() As Decimal
        Get
            Return _PNQVOLMR
        End Get
        Set(ByVal value As Decimal)
            _PNQVOLMR = value
        End Set
    End Property

    Public ReadOnly Property VOLUMENPAQUETE() As Decimal
        Get
            Return (_PNQMTLRG * _PNQMTANC * _PNQMTALT * _PNQCTPQT)
        End Get

    End Property


    Private _PNQPSOMR As Decimal
    Public Property PNQPSOMR() As Decimal
        Get
            Return _PNQPSOMR
        End Get
        Set(ByVal value As Decimal)
            _PNQPSOMR = value
        End Set
    End Property

    Public Property PSCODCLIE() As String
        Get
            Return _PSCODCLIE
        End Get
        Set(ByVal value As String)
            _PSCODCLIE = value
        End Set
    End Property


#Region "Datos adisionales Recojo"


    Private _PSTOBDGS As String

    Private _PNCTRSPT As Decimal
    Public Property PNCTRSPT() As Decimal
        Get
            Return _PNCTRSPT
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSPT = value
        End Set
    End Property


    Private _PSNPLCUN As String
    Public Property PSNPLCUN() As String
        Get
            Return _PSNPLCUN
        End Get
        Set(ByVal value As String)
            _PSNPLCUN = value
        End Set
    End Property

    Private _PSNPLCAC As String
    Public Property PSNPLCAC() As String
        Get
            Return _PSNPLCAC
        End Get
        Set(ByVal value As String)
            _PSNPLCAC = value
        End Set
    End Property



    Public Property PSTOBDGS() As String
        Get
            Return _PSTOBDGS
        End Get
        Set(ByVal value As String)
            _PSTOBDGS = value
        End Set
    End Property



    Private _PSCBRCNT As String
    Public Property PSCBRCNT() As String
        Get
            Return _PSCBRCNT
        End Get
        Set(ByVal value As String)
            _PSCBRCNT = value
        End Set
    End Property



    Private _PSSTPOCM As String
    Public Property PSSTPOCM() As String
        Get
            Return _PSSTPOCM
        End Get
        Set(ByVal value As String)
            _PSSTPOCM = value
        End Set
    End Property



    Private _PSSTPDSP As String
    Public Property PSSTPDSP() As String
        Get
            Return _PSSTPDSP
        End Get
        Set(ByVal value As String)
            _PSSTPDSP = value
        End Set
    End Property




    Private _CTPALM_DES As String
    Public Property PSCTPALM_DES() As String
        Get
            Return _CTPALM_DES
        End Get
        Set(ByVal value As String)
            _CTPALM_DES = value
        End Set
    End Property


    Private _CALMC_DES As String
    Public Property PSCALMC_DES() As String
        Get
            Return _CALMC_DES
        End Get
        Set(ByVal value As String)
            _CALMC_DES = value
        End Set
    End Property


    Private _CZNALM_DES As String
    Public Property PSCZNALM_DES() As String
        Get
            Return _CZNALM_DES
        End Get
        Set(ByVal value As String)
            _CZNALM_DES = value
        End Set
    End Property


    Private _CCLRS As String
    Public Property PSCCLRS() As String
        Get
            Return _CCLRS
        End Get
        Set(ByVal value As String)
            _CCLRS = value
        End Set
    End Property


    Private _CLSTRF As String
    Public Property PSCLSTRF() As String
        Get
            Return _CLSTRF
        End Get
        Set(ByVal value As String)
            _CLSTRF = value
        End Set
    End Property



    Private _PNFCHRMD As Decimal
    Public Property PNFCHRMD() As Decimal
        Get
            Return _PNFCHRMD
        End Get
        Set(ByVal value As Decimal)
            _PNFCHRMD = value
        End Set
    End Property

    Public Property FechaSolicitudMedio() As String
        Get
            Return NumeroAFecha(_PNFCHRMD)
        End Get
        Set(ByVal value As String)
            _PNFCHRMD = CtypeDate(value)
        End Set
    End Property

#End Region


    'miguel 31.01.2014   Canpos para Email y TipoMaterial
    Private _PSNMRGIM As Decimal
    Public Property PSNMRGIM() As Decimal
        Get
            Return _PSNMRGIM
        End Get
        Set(ByVal value As Decimal)
            _PSNMRGIM = value
        End Set
    End Property


    Private _PSTNMBAR As String
    Public Property PSTNMBAR() As String
        Get
            Return _PSTNMBAR
        End Get
        Set(ByVal value As String)
            _PSTNMBAR = value
        End Set
    End Property


    Private _PSTTPOMR As String

    Public Property PSTTPOMR() As String
        Get
            Return _PSTTPOMR
        End Get
        Set(ByVal value As String)
            _PSTTPOMR = value
        End Set
    End Property


    Private _psemailto As String

    Public Property PSemailto() As String
        Get
            Return _psemailto
        End Get
        Set(ByVal value As String)
            _psemailto = value
        End Set
    End Property



    'Private _PNCCMPN As String
    'Public Property PNCCMPN() As String
    '    Get
    '        Return _PNCCMPN
    '    End Get
    '    Set(ByVal value As String)
    '        _PNCCMPN = value
    '    End Set
    'End Property





    Private _PNTIPPROC As Integer
    Public Property PNTIPPROC() As Integer
        Get
            Return _PNTIPPROC
        End Get
        Set(ByVal value As Integer)
            _PNTIPPROC = value
        End Set
    End Property

    Private _PSNRPDTS As String 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)
    Public Property PSNRPDTS() As String
        Get
            Return _PSNRPDTS
        End Get
        Set(ByVal value As String)
            _PSNRPDTS = value
        End Set
    End Property

    Private _PSNROSEC As String 'ECM-HUNDRED-PRE-DESPACHOS-POR-PEDIDO-DE-TRASLADO(PYP_000221)
    Public Property PSNROSEC() As String
        Get
            Return _PSNROSEC
        End Get
        Set(ByVal value As String)
            _PSNROSEC = value
        End Set
    End Property

    Public Property CLARSG() As String
        Get
            Return _CLARSG
        End Get
        Set(ByVal value As String)
            _CLARSG = value
        End Set
    End Property

    Public Property NROONU() As String
        Get
            Return _NROONU
        End Get
        Set(ByVal value As String)
            _NROONU = value
        End Set
    End Property

    Public Property TPOEMB() As String
        Get
            Return _TPOEMB
        End Get
        Set(ByVal value As String)
            _TPOEMB = value
        End Set
    End Property

    Public Property PSTCTCAL() As String
        Get
            Return _PSTCTCAL
        End Get
        Set(ByVal value As String)
            _PSTCTCAL = value
        End Set
    End Property

    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-INICIO
    Private _PSDES_CND As String
    Private _PSFGIQBF As String
    Private _PSDES_CLASE As String
    Private _IN_CPRFUN As String
    Private _PSCUNMAT As String
    Private _PSFCHCAD As String

    Public Property PSDES_CND() As String
        Get
            Return (_PSDES_CND)
        End Get
        Set(ByVal value As String)
            _PSDES_CND = value
        End Set
    End Property

    Public Property PSFGIQBF() As String
        Get
            Return _PSFGIQBF
        End Get
        Set(ByVal value As String)
            _PSFGIQBF = value
        End Set
    End Property

    Public Property PSDES_CLASE() As String
        Get
            Return _PSDES_CLASE
        End Get
        Set(ByVal value As String)
            _PSDES_CLASE = value
        End Set
    End Property

    Public Property IN_CPRFUN() As String
        Get
            Return _IN_CPRFUN
        End Get
        Set(ByVal value As String)
            _IN_CPRFUN = value
        End Set
    End Property

    Public Property PSCUNMAT() As String
        Get
            Return _PSCUNMAT
        End Get
        Set(ByVal value As String)
            _PSCUNMAT = value
        End Set
    End Property

    Public Property PSFCHCAD() As String
        Get
            Return _PSFCHCAD
        End Get
        Set(ByVal value As String)
            _PSFCHCAD = value
        End Set
    End Property
    'CSR-HUNDRED-280916-MATERIALES-PELIGROSOS-FIN.

    'MPS
    Private _PSTTPCRG As String
    Public Property PSTTPCRG() As String
        Get
            Return _PSTTPCRG
        End Get
        Set(ByVal value As String)
            _PSTTPCRG = value
        End Set
    End Property


    Public Property PSUNSPSC() As String
        Get
            Return _PSUNSPSC
        End Get
        Set(ByVal value As String)
            _PSUNSPSC = value
        End Set
    End Property

    Private _PSINCBLT As String = ""
    Public Property PSINCBLT() As String
        Get
            Return _PSINCBLT
        End Get
        Set(ByVal value As String)
            _PSINCBLT = value
        End Set
    End Property


    'OMVB REQ15072019 HORA ENTREGA
    'PNHORIDE
    Private _PNHORIDE As Decimal
    Public Property PNHORIDE() As Decimal
        Get
            Return _PNHORIDE
        End Get
        Set(ByVal value As Decimal)
            _PNHORIDE = value
        End Set
    End Property
    'OMVB REQ15072019 HORA ENTREGA


    Private _PSTCMPCL As String
    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property

    Public Property FechaRecepcion() As String
        Get
            Return NumeroAFecha(_PNFREFFW)
        End Get
        Set(ByVal value As String)
            _PNFREFFW = CtypeDate(value)
        End Set
    End Property


    Private _InicioImpresion As Integer = 0
    Public Property InicioImpresion() As Integer
        Get
            Return _InicioImpresion
        End Get
        Set(ByVal value As Integer)
            _InicioImpresion = value
        End Set
    End Property
    Private _FinImpresion As Integer = 0
    Public Property FinImpresion() As Decimal
        Get
            Return _FinImpresion
        End Get
        Set(ByVal value As Decimal)
            _FinImpresion = value
        End Set
    End Property

    Private _PNCOMP_IMTERMEC As Int32 = 0

    Public Property PNCOMP_IMTERMEC() As Int32
        Get
            Return _PNCOMP_IMTERMEC
        End Get
        Set(ByVal value As Int32)
            _PNCOMP_IMTERMEC = value
        End Set
    End Property


    Private _PSNRPLTS As String = ""
    Public Property PSNRPLTS() As String
        Get
            Return _PSNRPLTS
        End Get
        Set(ByVal value As String)
            _PSNRPLTS = value
        End Set
    End Property


    Private _PNNRCTRL As Decimal = 0
    Public Property PNNRCTRL() As Decimal
        Get
            Return _PNNRCTRL
        End Get
        Set(ByVal value As Decimal)
            _PNNRCTRL = value
        End Set
    End Property

    Private _PSFGLPRD As String = ""
    Public Property PSFGLPRD() As String
        Get
            Return _PSFGLPRD
        End Get
        Set(ByVal value As String)
            _PSFGLPRD = value
        End Set
    End Property

    Public Property PSNGUIRS() As String
        Get
            Return _PSNGUIRS
        End Get
        Set(ByVal value As String)
            _PSNGUIRS = value
        End Set
    End Property

    Public Property PSNGUITS() As String
        Get
            Return _PSNGUITS
        End Get
        Set(ByVal value As String)
            _PSNGUITS = value
        End Set
    End Property

    Private _PNNCRRINOR As Decimal = 0
    Public Property PNNCRRINOR() As Decimal
        Get
            Return _PNNCRRINOR
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRINOR = value
        End Set
    End Property



End Class
