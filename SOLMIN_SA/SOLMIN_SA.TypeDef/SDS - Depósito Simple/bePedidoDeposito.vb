Public Class bePedidoDeposito
    Inherits beBase(Of bePedidoDeposito)
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PNNPDDPR As String = ""
    Private _PNNCNTR As Decimal = 0
    Private _PSTABRCL As String = ""
    Private _PNFLLGD As Decimal = 0
    Private _PNQTTLBL As Decimal = 0
    Private _PSNCRTIN As String = ""
    Private _PNCAGNAD As Decimal = 0
    Private _PSTCMAA As String = ""
    Private _PNCCLNT As Decimal = 0
    Private _PSTCMPCL As String = ""
    Private _PSTCNSG As String = ""
    Private _PNFINGDP As Decimal = 0
    Private _PNHINGDP As Decimal = 0
    Private _PNFVNPDD As Decimal = 0
    Private _PSCUNDTR As String = ""
    Private _PSTBRUNT As String = ""
    Private _PNCEMTDP As Decimal = 0
    Private _PSTCMTRN As String = ""

    Private _PNCVSTRN As Decimal = 0
    Private _PSTBRVTR As String = ""
    Private _PSCVPRCN As String = ""
    Private _PSTCMPVP As String = ""
    Private _PSTBNVDP As String = ""
    Private _PSNMNFS As String = ""
    Private _PSNCNCEM As String = ""
    Private _PSNFCTCM As String = ""
    Private _PNFFCTCM As Decimal = 0
    Private _PNCPAIS As Decimal = 0
    Private _PSTCMPPS As String = ""
    Private _PSCPRTEM As String = ""
    Private _PSTCMPR1 As String = ""
    Private _PSCPRTOR As String = ""
    Private _PSTCMPR1O As String = ""
    Private _PNFEMBR As Decimal = 0
    Private _PSCPRTDS As String = ""
    Private _PSTCMPR1D As String = ""
    Private _PNIVLFOB As Decimal = 0
    Private _PNIVLFLT As Decimal = 0
    Private _PNIVLSGR As Decimal = 0
    Private _PNIVLCIF As Decimal = 0
    Private _PNQTPCPD As Decimal = 0
    Private _PNCTPOAD As Decimal = 0
    Private _PSTCMADN As String = ""
    Private _PNNPDDPA As Decimal = 0
    Private _PNFSLLAD As Decimal = 0
    Private _PNFSLLADINI As Decimal = 0
    Private _PNFSLLADFIN As Decimal = 0
    Private _PSCTRMDP As String = ""
    Private _PSTTRMAL As String = ""
    Private _PSCTPOCR As String = ""
    Private _PSTABTPC As String = ""
    Private _PNCEXCRI As Decimal = 0
    Private _PSTCMPEX As String = ""
    Private _PNQTTBLR As Decimal = 0
    Private _PNQPSOBR As Decimal = 0
    Private _PNQPSBRR As Decimal = 0
    Private _PNQPSONT As Decimal = 0
    Private _PNQPSNTR As Decimal = 0
    Private _PNFAFRO As Decimal = 0
    Private _PNFECHA As Decimal = 0


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

    Public Property PNNPDDPR() As Decimal
        Get
            Return (_PNNPDDPR)
        End Get
        Set(ByVal value As Decimal)
            _PNNPDDPR = value
        End Set
    End Property

    Public Property PNNCNTR() As Decimal
        Get
            Return (_PNNCNTR)
        End Get
        Set(ByVal value As Decimal)
            _PNNCNTR = value
        End Set
    End Property

    Public Property PSTABRCL() As String
        Get
            Return (_PSTABRCL)
        End Get
        Set(ByVal value As String)
            _PSTABRCL = value
        End Set
    End Property

    Private _FechaLlegada As String
    Public Property PNFLLGD() As Decimal
        Get
            Return CtypeDate(_FechaLlegada)
        End Get
        Set(ByVal value As Decimal)
            _FechaLlegada = NumeroAFecha(value)
        End Set
    End Property

    Public Property FechaLlegada() As String
        Get
            Return _FechaLlegada
        End Get
        Set(ByVal value As String)
            _FechaLlegada = value
        End Set
    End Property

    Public Property PNQTTLBL() As Decimal
        Get
            Return (_PNQTTLBL)
        End Get
        Set(ByVal value As Decimal)
            _PNQTTLBL = value
        End Set
    End Property

    Public Property PSNCRTIN() As String
        Get
            Return (_PSNCRTIN)
        End Get
        Set(ByVal value As String)
            _PSNCRTIN = value
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

    Public Property PSTCMAA() As String
        Get
            Return (_PSTCMAA)
        End Get
        Set(ByVal value As String)
            _PSTCMAA = value
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

    Public Property PSTCMPCL() As String
        Get
            Return (_PSTCMPCL)
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property

    Public Property PSTCNSG() As String
        Get
            Return (_PSTCNSG)
        End Get
        Set(ByVal value As String)
            _PSTCNSG = value
        End Set
    End Property

    Private _FechaIngresoDep As String
    Public Property PNFINGDP() As Decimal
        Get
            Return CtypeDate(_FechaIngresoDep)
        End Get
        Set(ByVal value As Decimal)
            _FechaIngresoDep = NumeroAFecha(value)
        End Set
    End Property

    Public Property FechaIngresoDep() As String
        Get
            Return _FechaIngresoDep
        End Get
        Set(ByVal value As String)
            _FechaIngresoDep = value
        End Set
    End Property

    Private _HoraIngDep As String

    Public Property PNHINGDP() As Decimal
        Get
            Return CtypeHour(_HoraIngDep)
        End Get
        Set(ByVal value As Decimal)
            _HoraIngDep = NumeroAHora(value)
        End Set
    End Property

    Public Property HoraIngDep() As String
        Get
            Return _HoraIngDep
        End Get
        Set(ByVal value As String)
            _HoraIngDep = value
        End Set
    End Property

    Private _FechaVencimientoPed As String
    Public Property PNFVNPDD() As Decimal
        Get
            Return CtypeDate(_FechaVencimientoPed)
        End Get
        Set(ByVal value As Decimal)
            _FechaVencimientoPed = NumeroAFecha(value)
        End Set
    End Property

    Public Property FechaVencimientoPed() As String
        Get
            Return _FechaVencimientoPed
        End Get
        Set(ByVal value As String)
            _FechaVencimientoPed = value
        End Set
    End Property

    Public Property PSCUNDTR() As String
        Get
            Return (_PSCUNDTR)
        End Get
        Set(ByVal value As String)
            _PSCUNDTR = value
        End Set
    End Property

    Public Property PSTBRUNT() As String
        Get
            Return (_PSTBRUNT)
        End Get
        Set(ByVal value As String)
            _PSTBRUNT = value
        End Set
    End Property

    Public Property PNCEMTDP() As Decimal
        Get
            Return (_PNCEMTDP)
        End Get
        Set(ByVal value As Decimal)
            _PNCEMTDP = value
        End Set
    End Property

    Public Property PSTCMTRN() As String
        Get
            Return (_PSTCMTRN)
        End Get
        Set(ByVal value As String)
            _PSTCMTRN = value
        End Set
    End Property

    Public Property PNCVSTRN() As Decimal
        Get
            Return (_PNCVSTRN)
        End Get
        Set(ByVal value As Decimal)
            _PNCVSTRN = value
        End Set
    End Property

    Public Property PSTBRVTR() As String
        Get
            Return (_PSTBRVTR)
        End Get
        Set(ByVal value As String)
            _PSTBRVTR = value
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

    Public Property PSTCMPVP() As String
        Get
            Return (_PSTCMPVP)
        End Get
        Set(ByVal value As String)
            _PSTCMPVP = value
        End Set
    End Property

    Public Property PSTBNVDP() As String
        Get
            Return (_PSTBNVDP)
        End Get
        Set(ByVal value As String)
            _PSTBNVDP = value
        End Set
    End Property

    Public Property PSNMNFS() As String
        Get
            Return (_PSNMNFS)
        End Get
        Set(ByVal value As String)
            _PSNMNFS = value
        End Set
    End Property

    Public Property PSNCNCEM() As String
        Get
            Return (_PSNCNCEM)
        End Get
        Set(ByVal value As String)
            _PSNCNCEM = value
        End Set
    End Property

    Public Property PSNFCTCM() As String
        Get
            Return (_PSNFCTCM)
        End Get
        Set(ByVal value As String)
            _PSNFCTCM = value
        End Set
    End Property

    Private _FechaFacturaCom As String
    Public Property PNFFCTCM() As Decimal
        Get
            Return CtypeDate(_FechaFacturaCom)
        End Get
        Set(ByVal value As Decimal)
            _FechaFacturaCom = NumeroAFecha(value)
        End Set
    End Property

    Public Property FechaFacturaCom() As String
        Get
            Return _FechaFacturaCom
        End Get
        Set(ByVal value As String)
            _FechaFacturaCom = value
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

    Public Property PSTCMPPS() As String
        Get
            Return (_PSTCMPPS)
        End Get
        Set(ByVal value As String)
            _PSTCMPPS = value
        End Set
    End Property

    Public Property PSCPRTEM() As String
        Get
            Return (_PSCPRTEM)
        End Get
        Set(ByVal value As String)
            _PSCPRTEM = value
        End Set
    End Property

    Public Property PSTCMPR1() As String
        Get
            Return (_PSTCMPR1)
        End Get
        Set(ByVal value As String)
            _PSTCMPR1 = value
        End Set
    End Property

    Public Property PSCPRTOR() As String
        Get
            Return (_PSCPRTOR)
        End Get
        Set(ByVal value As String)
            _PSCPRTOR = value
        End Set
    End Property

    Public Property PSTCMPR1O() As String
        Get
            Return (_PSTCMPR1O)
        End Get
        Set(ByVal value As String)
            _PSTCMPR1O = value
        End Set
    End Property

    Private _FechaExportacion As String
    Public Property PNFEMBR() As Decimal
        Get
            Return CtypeDate(_FechaExportacion)
        End Get
        Set(ByVal value As Decimal)
            _FechaExportacion = NumeroAFecha(value)
        End Set
    End Property


    Public Property FechaExportacion() As String
        Get
            Return _FechaExportacion
        End Get
        Set(ByVal value As String)
            _FechaExportacion = value
        End Set
    End Property

    Public Property PSCPRTDS() As String
        Get
            Return (_PSCPRTDS)
        End Get
        Set(ByVal value As String)
            _PSCPRTDS = value
        End Set
    End Property

    Public Property PSTCMPR1D() As String
        Get
            Return (_PSTCMPR1D)
        End Get
        Set(ByVal value As String)
            _PSTCMPR1D = value
        End Set
    End Property

    Public Property PNIVLFOB() As Decimal
        Get
            Return (_PNIVLFOB)
        End Get
        Set(ByVal value As Decimal)
            _PNIVLFOB = value
        End Set
    End Property

    Public Property PNIVLFLT() As Decimal
        Get
            Return (_PNIVLFLT)
        End Get
        Set(ByVal value As Decimal)
            _PNIVLFLT = value
        End Set
    End Property

    Public Property PNIVLSGR() As Decimal
        Get
            Return (_PNIVLSGR)
        End Get
        Set(ByVal value As Decimal)
            _PNIVLSGR = value
        End Set
    End Property

    Public Property PNIVLCIF() As Decimal
        Get
            Return (_PNIVLCIF)
        End Get
        Set(ByVal value As Decimal)
            _PNIVLCIF = value
        End Set
    End Property

    Public Property PNQTPCPD() As Decimal
        Get
            Return (_PNQTPCPD)
        End Get
        Set(ByVal value As Decimal)
            _PNQTPCPD = value
        End Set
    End Property

    Public Property PNCTPOAD() As Decimal
        Get
            Return (_PNCTPOAD)
        End Get
        Set(ByVal value As Decimal)
            _PNCTPOAD = value
        End Set
    End Property

    Public Property PSTCMADN() As String
        Get
            Return (_PSTCMADN)
        End Get
        Set(ByVal value As String)
            _PSTCMADN = value
        End Set
    End Property

    Public Property PNNPDDPA() As Decimal
        Get
            Return (_PNNPDDPA)
        End Get
        Set(ByVal value As Decimal)
            _PNNPDDPA = value
        End Set
    End Property

    Public Property PNFSLLADINI() As Decimal
        Get
            Return _PNFSLLADINI
        End Get
        Set(ByVal value As Decimal)
            _PNFSLLADINI = value
        End Set
    End Property

    Public Property PNFSLLADFIN() As Decimal
        Get
            Return _PNFSLLADFIN
        End Get
        Set(ByVal value As Decimal)
            _PNFSLLADFIN = value
        End Set
    End Property

    Public Property PSCTRMDP() As String
        Get
            Return (_PSCTRMDP)
        End Get
        Set(ByVal value As String)
            _PSCTRMDP = value
        End Set
    End Property

    Private _FechaNumPedAduana As String
    Public Property PNFSLLAD() As Decimal
        Get
            Return CtypeDate(_FechaNumPedAduana)
        End Get
        Set(ByVal value As Decimal)
            _FechaNumPedAduana = NumeroAFecha(value)
        End Set
    End Property

    Public Property FechaNumPedAduana() As String
        Get
            Return _FechaNumPedAduana
        End Get
        Set(ByVal value As String)
            _FechaNumPedAduana = value
        End Set
    End Property

    Public Property PSTTRMAL() As String
        Get
            Return (_PSTTRMAL)
        End Get
        Set(ByVal value As String)
            _PSTTRMAL = value
        End Set
    End Property

    Public Property PSCTPOCR() As String
        Get
            Return (_PSCTPOCR)
        End Get
        Set(ByVal value As String)
            _PSCTPOCR = value
        End Set
    End Property

    Public Property PSTABTPC() As String
        Get
            Return (_PSTABTPC)
        End Get
        Set(ByVal value As String)
            _PSTABTPC = value
        End Set
    End Property

    Public Property PNCEXCRI() As Decimal
        Get
            Return (_PNCEXCRI)
        End Get
        Set(ByVal value As Decimal)
            _PNCEXCRI = value
        End Set
    End Property

    Public Property PSTCMPEX() As String
        Get
            Return (_PSTCMPEX)
        End Get
        Set(ByVal value As String)
            _PSTCMPEX = value
        End Set
    End Property

    Public Property PNQTTBLR() As Decimal
        Get
            Return (_PNQTTBLR)
        End Get
        Set(ByVal value As Decimal)
            _PNQTTBLR = value
        End Set
    End Property

    Public Property PNQPSOBR() As Decimal
        Get
            Return (_PNQPSOBR)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSOBR = value
        End Set
    End Property

    Public Property PNQPSBRR() As Decimal
        Get
            Return (_PNQPSBRR)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSBRR = value
        End Set
    End Property

    Public Property PNQPSONT() As Decimal
        Get
            Return (_PNQPSONT)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSONT = value
        End Set
    End Property

    Public Property PNQPSNTR() As Decimal
        Get
            Return (_PNQPSNTR)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSNTR = value
        End Set
    End Property

    Private _FechaAforo As String
    Public Property PNFAFRO() As Decimal
        Get
            Return CtypeDate(_FechaAforo)
        End Get
        Set(ByVal value As Decimal)
            _FechaAforo = NumeroAFecha(value)
        End Set
    End Property

    Public Property FechaAforo() As String
        Get
            Return _FechaAforo
        End Get
        Set(ByVal value As String)
            _FechaAforo = value
        End Set
    End Property

    Public Property PNFECHA() As Decimal
        Get
            Return (_PNFECHA)
        End Get
        Set(ByVal value As Decimal)
            _PNFECHA = value
        End Set
    End Property


End Class

Public Class beFiltroPedidoDeposito
    Public PAGESIZE As Int32 = 0
    Public PAGENUMBER As Int32 = 0
    Public PAGECOUNT As Int32 = 0
    Public Sub pclear()
        PAGESIZE = 0
        PAGENUMBER = 0
        PAGECOUNT = 0
    End Sub

End Class