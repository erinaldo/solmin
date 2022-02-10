Public Class beDatosEmbarque
    Private _PNNORSCI As Decimal = 0
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PSNOREMB As String = ""
    Private _PNPNNMOS As Decimal = 0
    Private _PNCZNFCC As Decimal = 0
    Private _PSFORSCI As String = ""
    Private _PNFORSCI As Decimal = 0
    Private _PNCCLNT As Decimal = 0
    Private _PSNREFCL As String = ""
    Private _PSREFDO1 As String = ""
    Private _PNCPRVCL As Decimal = 0
    Private _PNCCIAIN As Decimal = 0
    Private _PSTRECOR As String = ""
    Private _PSTMARE1 As String = ""
    Private _PSTOBERV As String = ""
    Private _PSNDOCEM As String = ""
    Private _PNCPAIS As Decimal = 0
    Private _PNCMEDTR As Decimal = 0
    Private _PSCVPRCN As String = ""
    Private _PNCAGNCR As Decimal = 0
    Private _PNCCIANV As Decimal = 0
    Private _PNCTRSPT As Decimal = 0
    Private _PSCPRTOE As String = ""
    Private _PSFAPREV As String = ""
    Private _PSFAPRAR As String = ""
    Private _PNFAPREV As Decimal = 0
    Private _PNFAPRAR As Decimal = 0
    Private _PNQPSOEM As Decimal = 0
    Private _PSCPRTOA As String = ""
    Private _PSCTRMAL As String = ""
    Private _PNQPSOAR As Decimal = 0
    Private _PNNBLTAR As Decimal = 0
    Private _PNQVOLMR As Decimal = 0
    Private _PNNDIALB As Decimal = 0
    Private _PNNDIASE As Decimal = 0
    Private _PSTNMCTT As String = ""
    Private _PSTBFTRB As String = ""
    Private _PSTDRENT As String = ""
    Private _PSHORATN As String = ""
    Private _PSTPRSCN As String = ""
    Private _PSSESTRG As String = ""
    Private _PSTNRODU As String = ""
    Private _PSTCANAL As String = ""

    Private _PSURLARC As String = ""
    Private _PNNCODRG_DESPACHO As Decimal = 0
    Private _PSNDOCUM As String = ""

    Private _PNTRANSPORTE As Decimal = 0
    Private _PSNORCML As String = ""
    Private _PNALM_LOCAL As Decimal = 0

    Private _PSSESTRG_DESC As String = ""
    Private _PSTERCERO As String = ""

    'Private _PNNCODRG_REG As Decimal = 0
    'Private _PSFECVEN_REG As String = ""
    'Private _PSTOBSRL_REG As String = ""
    'Private _PNFECVEN_REG As Decimal = 0
    'Private _PNFECINI_REG As Decimal = 0
    Private _PSTDSCRG_REG As String = ""
    'Private _PSFECINI_REG As String = ""

    Private _PSTDSCRG_DESPACHO As String = ""
    Private _PNCPAIS_DESTINO As String = ""
    Private _PSFCEMSN As String = ""
    Private _PNFCEMSN As Decimal = 0

    Private _PNCHK_LEVANTE As Decimal = 0
    Private _PNCHK_ENTREGA_ALMACEN As Decimal = 0
    Private _PNCHK_PAGO_DERECHO As Decimal = 0
    Private _PNCHK_NUMERACION As Decimal = 0


    Private _PSTPSRVA As String = ""
    Private _PNTPORGE As Decimal = 0
    Private _PNTPOPRG As Decimal = 0
    Private _PSTCMTSR As String = ""
    Private _PSTCMRGA As String = ""

    Private _PSTCMPRO As String = ""

    Private _PSFTRORS_REG As String = ""
    Private _PNFTRORS_REG As Decimal = 0
    Private _PNPNNMOS_REG As Decimal = 0
    Private _PNNORSCO_REG As Decimal = 0

    Private _PNCAGNAD As Decimal = 0
    Private _PSFTRTSG As String = ""














    Private _PSTRSPCL As String = ""
    Private _PSTRSPRN As String = ""
    Public Property PNNORSCI() As Decimal
        Get
            Return (_PNNORSCI)
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
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
    Public Property PSNOREMB() As String
        Get
            Return (_PSNOREMB)
        End Get
        Set(ByVal value As String)
            _PSNOREMB = value
        End Set
    End Property
    Public Property PNPNNMOS() As Decimal
        Get
            Return (_PNPNNMOS)
        End Get
        Set(ByVal value As Decimal)
            _PNPNNMOS = value
        End Set
    End Property
    Public Property PNCZNFCC() As Decimal
        Get
            Return (_PNCZNFCC)
        End Get
        Set(ByVal value As Decimal)
            _PNCZNFCC = value
        End Set
    End Property
    Public Property PSFORSCI() As String
        Get
            Return (_PSFORSCI)
        End Get
        Set(ByVal value As String)
            _PSFORSCI = value
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
    Public Property PSNREFCL() As String
        Get
            Return (_PSNREFCL)
        End Get
        Set(ByVal value As String)
            _PSNREFCL = value
        End Set
    End Property
    Public Property PSREFDO1() As String
        Get
            Return (_PSREFDO1)
        End Get
        Set(ByVal value As String)
            _PSREFDO1 = value
        End Set
    End Property
    Public Property PNCPRVCL() As Decimal
        Get
            Return (_PNCPRVCL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property

    Public Property PNCCIAIN() As Decimal
        Get
            Return (_PNCCIAIN)
        End Get
        Set(ByVal value As Decimal)
            _PNCCIAIN = value
        End Set
    End Property


    Public Property PSTRECOR() As String
        Get
            Return (_PSTRECOR)
        End Get
        Set(ByVal value As String)
            _PSTRECOR = value
        End Set
    End Property
    Public Property PSTMARE1() As String
        Get
            Return (_PSTMARE1)
        End Get
        Set(ByVal value As String)
            _PSTMARE1 = value
        End Set
    End Property


    Public Property PSTOBERV() As String
        Get
            Return (_PSTOBERV)
        End Get
        Set(ByVal value As String)
            _PSTOBERV = value
        End Set
    End Property
    Public Property PSNDOCEM() As String
        Get
            Return (_PSNDOCEM)
        End Get
        Set(ByVal value As String)
            _PSNDOCEM = value
        End Set
    End Property
    Public Property PNCPAIS() As Decimal
        Get
            Return (_PNCPAIS)
        End Get
        Set(ByVal value As Decimal)
            _PNCPAIS = value
        End Set
    End Property

    Public Property PNCPAIS_DESTINO() As Decimal
        Get
            Return (_PNCPAIS_DESTINO)
        End Get
        Set(ByVal value As Decimal)
            _PNCPAIS_DESTINO = value
        End Set
    End Property


    Public Property PNCMEDTR() As Decimal
        Get
            Return (_PNCMEDTR)
        End Get
        Set(ByVal value As Decimal)
            _PNCMEDTR = value
        End Set
    End Property
    Public Property PSCVPRCN() As String
        Get
            Return (_PSCVPRCN)
        End Get
        Set(ByVal value As String)
            _PSCVPRCN = value
        End Set
    End Property
    Public Property PNCAGNCR() As Decimal
        Get
            Return (_PNCAGNCR)
        End Get
        Set(ByVal value As Decimal)
            _PNCAGNCR = value
        End Set
    End Property
    Public Property PNCCIANV() As Decimal
        Get
            Return (_PNCCIANV)
        End Get
        Set(ByVal value As Decimal)
            _PNCCIANV = value
        End Set
    End Property
    Public Property PNCTRSPT() As Decimal
        Get
            Return (_PNCTRSPT)
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSPT = value
        End Set
    End Property
    Public Property PSCPRTOE() As String
        Get
            Return (_PSCPRTOE)
        End Get
        Set(ByVal value As String)
            _PSCPRTOE = value
        End Set
    End Property
    Public Property PSFAPREV() As String
        Get
            Return (_PSFAPREV)
        End Get
        Set(ByVal value As String)
            _PSFAPREV = value
        End Set
    End Property
   
    Public Property PNQPSOEM() As Decimal
        Get
            Return (_PNQPSOEM)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSOEM = value
        End Set
    End Property
   
    Public Property PSCPRTOA() As String
        Get
            Return (_PSCPRTOA)
        End Get
        Set(ByVal value As String)
            _PSCPRTOA = value
        End Set
    End Property
    Public Property PSCTRMAL() As String
        Get
            Return (_PSCTRMAL)
        End Get
        Set(ByVal value As String)
            _PSCTRMAL = value
        End Set
    End Property

    Public Property PSFAPRAR() As String
        Get
            Return (_PSFAPRAR)
        End Get
        Set(ByVal value As String)
            _PSFAPRAR = value
        End Set
    End Property

    Public Property PNQPSOAR() As Decimal
        Get
            Return (_PNQPSOAR)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSOAR = value
        End Set
    End Property
    Public Property PNNBLTAR() As Decimal
        Get
            Return (_PNNBLTAR)
        End Get
        Set(ByVal value As Decimal)
            _PNNBLTAR = value
        End Set
    End Property
    Public Property PNQVOLMR() As Decimal
        Get
            Return (_PNQVOLMR)
        End Get
        Set(ByVal value As Decimal)
            _PNQVOLMR = value
        End Set
    End Property

    Public Property PNNDIALB() As Decimal
        Get
            Return (_PNNDIALB)
        End Get
        Set(ByVal value As Decimal)
            _PNNDIALB = value
        End Set
    End Property
    Public Property PNNDIASE() As Decimal
        Get
            Return (_PNNDIASE)
        End Get
        Set(ByVal value As Decimal)
            _PNNDIASE = value
        End Set
    End Property

    Public Property PSTNMCTT() As String
        Get
            Return (_PSTNMCTT)
        End Get
        Set(ByVal value As String)
            _PSTNMCTT = value
        End Set
    End Property
    Public Property PSTBFTRB() As String
        Get
            Return (_PSTBFTRB)
        End Get
        Set(ByVal value As String)
            _PSTBFTRB = value
        End Set
    End Property
    Public Property PSTDRENT() As String
        Get
            Return (_PSTDRENT)
        End Get
        Set(ByVal value As String)
            _PSTDRENT = value
        End Set
    End Property
    Public Property PSHORATN() As String
        Get
            Return (_PSHORATN)
        End Get
        Set(ByVal value As String)
            _PSHORATN = value
        End Set
    End Property
    Public Property PSTPRSCN() As String
        Get
            Return (_PSTPRSCN)
        End Get
        Set(ByVal value As String)
            _PSTPRSCN = value
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


    Public Property PSTNRODU() As String
        Get
            Return (_PSTNRODU)
        End Get
        Set(ByVal value As String)
            _PSTNRODU = value
        End Set
    End Property

    Public Property PSTCANAL() As String
        Get
            Return (_PSTCANAL)
        End Get
        Set(ByVal value As String)
            _PSTCANAL = value
        End Set
    End Property


    Public Property PSURLARC() As String
        Get
            Return (_PSURLARC)
        End Get
        Set(ByVal value As String)
            _PSURLARC = value
        End Set
    End Property
    Public Property PNFORSCI() As Decimal
        Get
            Return (_PNFORSCI)
        End Get
        Set(ByVal value As Decimal)
            _PNFORSCI = value
        End Set
    End Property


    Public Property PSNDOCUM() As String
        Get
            Return (_PSNDOCUM)
        End Get
        Set(ByVal value As String)
            _PSNDOCUM = value
        End Set
    End Property



    'Public Property PNNCODRG_REG() As Decimal
    '    Get
    '        Return (_PNNCODRG_REG)
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNNCODRG_REG = value
    '    End Set
    'End Property
    'Public Property PNDESPACHO() As Decimal
    '    Get
    '        Return (_PNDESPACHO)
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNDESPACHO = value
    '    End Set
    'End Property
    Public Property PNTRANSPORTE() As Decimal
        Get
            Return (_PNTRANSPORTE)
        End Get
        Set(ByVal value As Decimal)
            _PNTRANSPORTE = value
        End Set
    End Property
    Public Property PSNORCML() As String
        Get
            Return (_PSNORCML)
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property

    Public Property PNALM_LOCAL() As Decimal
        Get
            Return (_PNALM_LOCAL)
        End Get
        Set(ByVal value As Decimal)
            _PNALM_LOCAL = value
        End Set
    End Property


    Public Property PSSESTRG_DESC() As String
        Get
            Return (_PSSESTRG_DESC)
        End Get
        Set(ByVal value As String)
            _PSSESTRG_DESC = value
        End Set
    End Property

    Public Property PSTERCERO() As String
        Get
            Return (_PSTERCERO)
        End Get
        Set(ByVal value As String)
            _PSTERCERO = value
        End Set
    End Property

    'Public Property PSFECVEN_REG() As String
    '    Get
    '        Return (_PSFECVEN_REG)
    '    End Get
    '    Set(ByVal value As String)
    '        _PSFECVEN_REG = value
    '    End Set
    'End Property

    'Public Property PSTOBSRL_REG() As String
    '    Get
    '        Return (_PSTOBSRL_REG)
    '    End Get
    '    Set(ByVal value As String)
    '        _PSTOBSRL_REG = value
    '    End Set
    'End Property

    'Public Property PNFECVEN_REG() As Decimal
    '    Get
    '        Return (_PNFECVEN_REG)
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNFECVEN_REG = value
    '    End Set
    'End Property

    'Public Property PNFECINI_REG() As Decimal
    '    Get
    '        Return (_PNFECINI_REG)
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PNFECINI_REG = value
    '    End Set
    'End Property

    'Public Property PSFECINI_REG() As String
    '    Get
    '        Return (_PSFECINI_REG)
    '    End Get
    '    Set(ByVal value As String)
    '        _PSFECINI_REG = value
    '    End Set
    'End Property

    Public Property PSTDSCRG_REG() As String
        Get
            Return _PSTDSCRG_REG
        End Get
        Set(ByVal value As String)
            _PSTDSCRG_REG = value
        End Set
    End Property
    Public Property PSTDSCRG_DESPACHO() As String
        Get
            Return _PSTDSCRG_DESPACHO
        End Get
        Set(ByVal value As String)
            _PSTDSCRG_DESPACHO = value
        End Set
    End Property

    Public Property PSFCEMSN() As String
        Get
            Return (_PSFCEMSN)
        End Get
        Set(ByVal value As String)
            _PSFCEMSN = value
        End Set
    End Property

    Public Property PNFCEMSN() As Decimal
        Get
            Return (_PNFCEMSN)
        End Get
        Set(ByVal value As Decimal)
            _PNFCEMSN = value
        End Set
    End Property

    Public Property PNFAPREV() As Decimal
        Get
            Return (_PNFAPREV)
        End Get
        Set(ByVal value As Decimal)
            _PNFAPREV = value
        End Set
    End Property
    Public Property PNFAPRAR() As Decimal
        Get
            Return (_PNFAPRAR)
        End Get
        Set(ByVal value As Decimal)
            _PNFAPRAR = value
        End Set
    End Property

    Public Property PNCHK_LEVANTE() As Decimal
        Get
            Return (_PNCHK_LEVANTE)
        End Get
        Set(ByVal value As Decimal)
            _PNCHK_LEVANTE = value
        End Set
    End Property


    Public Property PNCHK_ENTREGA_ALMACEN() As Decimal
        Get
            Return (_PNCHK_ENTREGA_ALMACEN)
        End Get
        Set(ByVal value As Decimal)
            _PNCHK_ENTREGA_ALMACEN = value
        End Set
    End Property


    Public Property PNNCODRG_DESPACHO() As Decimal
        Get
            Return (_PNNCODRG_DESPACHO)
        End Get
        Set(ByVal value As Decimal)
            _PNNCODRG_DESPACHO = value
        End Set
    End Property


    Public Property PNCHK_PAGO_DERECHO() As Decimal
        Get
            Return (_PNCHK_PAGO_DERECHO)
        End Get
        Set(ByVal value As Decimal)
            _PNCHK_PAGO_DERECHO = value
        End Set
    End Property

    Public Property PNCHK_NUMERACION() As Decimal
        Get
            Return (_PNCHK_NUMERACION)
        End Get
        Set(ByVal value As Decimal)
            _PNCHK_NUMERACION = value
        End Set
    End Property


    Public Property PSTPSRVA() As String
        Get
            Return _PSTPSRVA
        End Get
        Set(ByVal value As String)
            _PSTPSRVA = value
        End Set
    End Property

    Public Property PNTPORGE() As Decimal
        Get
            Return (_PNTPORGE)
        End Get
        Set(ByVal value As Decimal)
            _PNTPORGE = value
        End Set
    End Property
    Public Property PNTPOPRG() As Decimal
        Get
            Return (_PNTPOPRG)
        End Get
        Set(ByVal value As Decimal)
            _PNTPOPRG = value
        End Set
    End Property

    Public Property PSTCMTSR() As String
        Get
            Return (_PSTCMTSR)
        End Get
        Set(ByVal value As String)
            _PSTCMTSR = value
        End Set
    End Property

    Public Property PSTCMRGA() As String
        Get
            Return (_PSTCMRGA)
        End Get
        Set(ByVal value As String)
            _PSTCMRGA = value
        End Set
    End Property

    Public Property PSTCMPRO() As String
        Get
            Return (_PSTCMPRO)
        End Get
        Set(ByVal value As String)
            _PSTCMPRO = value
        End Set
    End Property

    Public Property PSFTRORS_REG() As String
        Get
            Return (_PSFTRORS_REG)
        End Get
        Set(ByVal value As String)
            _PSFTRORS_REG = value
        End Set
    End Property

   
    Public Property PNNORSCO_REG() As Decimal
        Get
            Return (_PNNORSCO_REG)
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCO_REG = value
        End Set
    End Property

    Public Property PNPNNMOS_REG() As Decimal
        Get
            Return (_PNPNNMOS_REG)
        End Get
        Set(ByVal value As Decimal)
            _PNPNNMOS_REG = value
        End Set
    End Property

    Public Property PNFTRORS_REG() As Decimal
        Get
            Return (_PNFTRORS_REG)
        End Get
        Set(ByVal value As Decimal)
            _PNFTRORS_REG = value
        End Set
    End Property

    Public Property PNCAGNAD() As Decimal
        Get
            Return (_PNCAGNAD)
        End Get
        Set(ByVal value As Decimal)
            _PNCAGNAD = value
        End Set
    End Property

    Public Property PSTRSPCL() As String
        Get
            Return (_PSTRSPCL)
        End Get
        Set(ByVal value As String)
            _PSTRSPCL = value
        End Set
    End Property

    Public Property PSTRSPRN() As String
        Get
            Return (_PSTRSPRN)
        End Get
        Set(ByVal value As String)
            _PSTRSPRN = value
        End Set
    End Property

    Public Property PSFTRTSG() As String
        Get
            Return (_PSFTRTSG)
        End Get
        Set(ByVal value As String)
            _PSFTRTSG = value
        End Set
    End Property


End Class
