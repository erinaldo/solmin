

Public Class beDespacho
    Inherits beBase(Of beDespacho)

    Private _PNCCLNT As Decimal = 0
    Private _PNCPLNCL As Decimal = 0
    Private _PSTCMPPL As String = ""
    Private _PSTDRCPL As String = ""
    Private _PSCTPDP6 As String = ""
    Private _PNCPLCLP As Decimal = 0
    Private _PNCPRVCL As Decimal = 0
    Private _CLIENTE As Decimal = 0
    Private _PNQPLANTA As Decimal = 0
    Private _PNFECHA_IN As Int64 = 0
    Private _PNFECHA_FIN As Int64 = 0
    Private _PSUSUARIO As String = ""
    Private _PSNTRMNL As String = ""
    Private _PSNLTECL As String = ""
    Private _PSSESTRG As String = ""
    Private _PSCPRVD As String = ""
    Private _PSSMTGRM As String = ""
    Private _PSMOTTRA As String = ""
    Private _PSCTPIS As String = ""
    Private _PNFRLZSR As Decimal = 0
    Private _PSSTRNSM As String = ""
    Private _PNFTRNSM As Decimal = 0
    Private _PNHTRNSM As Decimal = 0
    Private _PNFCHCRT As Decimal = 0
    Private _PNHRACRT As Decimal = 0
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSSTPODP As String = ""
    Private _PNNPRTIN As Decimal = 0

    Private _PNNRPDTS As Decimal
    Private _PSSESPRC As String

    Private _PSCCMPN As String
    Private _PSCDVSN As String
    Private _PNCPLNDV As Decimal


    Public Property PSNTRMNL() As String
        Get
            Return _PSNTRMNL
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property


    Public Property PSUSUARIO() As String
        Get
            Return _PSUSUARIO
        End Get
        Set(ByVal value As String)
            _PSUSUARIO = value
        End Set
    End Property


    Public Property PNFECHA_IN() As Int64
        Get
            Return _PNFECHA_IN
        End Get
        Set(ByVal value As Int64)
            _PNFECHA_IN = value
        End Set
    End Property



    Public Property PNFECHA_FIN() As Int64
        Get
            Return _PNFECHA_FIN
        End Get
        Set(ByVal value As Int64)
            _PNFECHA_FIN = value
        End Set
    End Property


    Public Property PNQPLANTA() As Decimal
        Get
            Return _PNQPLANTA
        End Get
        Set(ByVal value As Decimal)
            _PNQPLANTA = value
        End Set
    End Property


    Public Property CLIENTE() As Decimal
        Get
            Return _CLIENTE
        End Get
        Set(ByVal value As Decimal)
            _CLIENTE = value
        End Set
    End Property

    Private _TIPODEPOSITO As String

    Public Property TIPODEPOSITO() As String
        Get
            Return _TIPODEPOSITO
        End Get
        Set(ByVal value As String)
            _TIPODEPOSITO = value
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
    Public Property PNCPLNCL() As Decimal
        Get
            Return (_PNCPLNCL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNCL = value
        End Set
    End Property
    Public Property PSTCMPPL() As String
        Get
            Return (_PSTCMPPL)
        End Get
        Set(ByVal value As String)
            _PSTCMPPL = value
        End Set
    End Property
    Public Property PSTDRCPL() As String
        Get
            Return (_PSTDRCPL)
        End Get
        Set(ByVal value As String)
            _PSTDRCPL = value
        End Set
    End Property

    Public Property PSCTPDP6() As String
        Get
            Return _PSCTPDP6
        End Get
        Set(ByVal value As String)
            _PSCTPDP6 = value
        End Set
    End Property

    Public Property PNCPLCLP() As Decimal
        Get
            Return _PNCPLCLP
        End Get
        Set(ByVal value As Decimal)
            _PNCPLCLP = value
        End Set
    End Property


    Public Property PNCPRVCL() As Decimal
        Get
            Return _PNCPRVCL
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property

    Private _PSDESCLI As String
    Public Property PSDESCLI() As String
        Get
            Return _PSDESCLI
        End Get
        Set(ByVal value As String)
            _PSDESCLI = value
        End Set
    End Property

    Public Property PNNRPDTS() As Decimal
        Get
            Return _PNNRPDTS
        End Get
        Set(ByVal value As Decimal)
            _PNNRPDTS = value
        End Set
    End Property

    Public Property PSSESPRC() As String
        Get
            Return _PSSESPRC
        End Get
        Set(ByVal value As String)
            _PSSESPRC = value
        End Set
    End Property

    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

#Region "ABB"


    Private _PNCDPEPL As Decimal
    Public Property PNCDPEPL() As Decimal
        Get
            Return _PNCDPEPL
        End Get
        Set(ByVal value As Decimal)
            _PNCDPEPL = value
        End Set
    End Property

    Private _PNNGUIRN As Decimal
    Public Property PNNGUIRN() As Decimal
        Get
            Return _PNNGUIRN
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRN = value
        End Set
    End Property



    Private _PSTIPORG As String
    Public Property PSTIPORG() As String
        Get
            Return _PSTIPORG
        End Get
        Set(ByVal value As String)
            _PSTIPORG = value
        End Set
    End Property

    Private _PNNGUIRM As Decimal
    Public Property PNNGUIRM() As Decimal
        Get
            Return _PNNGUIRM
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRM = value
        End Set
    End Property



    Private _PNNGUISL As Decimal
    Public Property PNNGUISL() As Decimal
        Get
            Return _PNNGUISL
        End Get
        Set(ByVal value As Decimal)
            _PNNGUISL = value
        End Set
    End Property

    Private _PSGUIA As String
    Public Property PSGUIA() As String
        Get
            Return _PSGUIA
        End Get
        Set(ByVal value As String)
            _PSGUIA = value
        End Set
    End Property

    Private _PNNCRRGR As Decimal
    Public Property PNNCRRGR() As Decimal
        Get
            Return _PNNCRRGR
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRGR = value
        End Set
    End Property


    Private _PSCMRCLR As String
    Public Property PSCMRCLR() As String
        Get
            Return _PSCMRCLR
        End Get
        Set(ByVal value As String)
            _PSCMRCLR = value
        End Set
    End Property

    Private _PSTMRCD2 As String
    ''' <summary>
    ''' DESCRIPCION DE LA MERCADERIA 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTMRCD2() As String
        Get
            Return _PSTMRCD2
        End Get
        Set(ByVal value As String)
            _PSTMRCD2 = value
        End Set
    End Property


    Private _PSDEMERCA As String
    Public Property PSDEMERCA() As String
        Get
            Return _PSDEMERCA
        End Get
        Set(ByVal value As String)
            _PSDEMERCA = value
        End Set
    End Property

    Private newPropertyValue As Integer
    Public Property NewProperty() As Integer
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As Integer)
            newPropertyValue = value
        End Set
    End Property


    Private _PSCPRPCL As String
    Public Property PSCPRPCL() As String
        Get
            Return _PSCPRPCL
        End Get
        Set(ByVal value As String)
            _PSCPRPCL = value
        End Set
    End Property

    Private _PSNRUCPR As Decimal
    Public Property PSNRUCPR() As Decimal
        Get
            Return _PSNRUCPR
        End Get
        Set(ByVal value As Decimal)
            _PSNRUCPR = value
        End Set
    End Property


    Private _PSTDRPRC As String
    Public Property PSTDRPRC() As String
        Get
            Return _PSTDRPRC
        End Get
        Set(ByVal value As String)
            _PSTDRPRC = value
        End Set
    End Property


    Private _PSTDRPCP As String
    Public Property PSTDRPCP() As String
        Get
            Return _PSTDRPCP
        End Get
        Set(ByVal value As String)
            _PSTDRPCP = value
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


    Private _PSTCMPCL As String
    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property


    Private _PSTDRCOR As String
    Public Property PSTDRCOR() As String
        Get
            Return _PSTDRCOR
        End Get
        Set(ByVal value As String)
            _PSTDRCOR = value
        End Set
    End Property


    Private _PNQTRMC As Decimal
    Public Property PNQTRMC() As Decimal
        Get
            Return _PNQTRMC
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMC = value
        End Set
    End Property


    Private _PNQTRMP As Decimal
    Public Property PNQTRMP() As Decimal
        Get
            Return _PNQTRMP
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMP = value
        End Set
    End Property


    Private _PNQTRMV As Decimal
    Public Property PNQTRMV() As Decimal
        Get
            Return _PNQTRMV
        End Get
        Set(ByVal value As Decimal)
            _PNQTRMV = value
        End Set
    End Property



    Private _PSCULUSA As String

    Public Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property


    Private _PSNORCCL As String
    Public Property PSNORCCL() As String
        Get
            Return _PSNORCCL
        End Get
        Set(ByVal value As String)
            _PSNORCCL = value
        End Set
    End Property


    Private _PSDESMER As String
    Public Property PSDESMER() As String
        Get
            Return _PSDESMER
        End Get
        Set(ByVal value As String)
            _PSDESMER = value
        End Set
    End Property


    Private _PNNORDSR As Decimal
    Public Property PNNORDSR() As Decimal
        Get
            Return _PNNORDSR
        End Get
        Set(ByVal value As Decimal)
            _PNNORDSR = value
        End Set
    End Property


    Private _PSCMRCD As String
    Public Property PSCMRCD() As String
        Get
            Return _PSCMRCD
        End Get
        Set(ByVal value As String)
            _PSCMRCD = value
        End Set
    End Property


    Private _PNNCNTR As Decimal
    Public Property PNNCNTR() As Decimal
        Get
            Return _PNNCNTR
        End Get
        Set(ByVal value As Decimal)
            _PNNCNTR = value
        End Set
    End Property


    Private _PNNCRCTC As Decimal
    Public Property PNNCRCTC() As Decimal
        Get
            Return _PNNCRCTC
        End Get
        Set(ByVal value As Decimal)
            _PNNCRCTC = value
        End Set
    End Property


    Private _PNNAUTR As Decimal
    Public Property PNNAUTR() As Decimal
        Get
            Return _PNNAUTR
        End Get
        Set(ByVal value As Decimal)
            _PNNAUTR = value
        End Set
    End Property

    Private _PSCUNCN5 As String
    Public Property PSCUNCN5() As String
        Get
            Return _PSCUNCN5
        End Get
        Set(ByVal value As String)
            _PSCUNCN5 = value
        End Set
    End Property

    Private _PSCUNPS5 As String
    Public Property PSCUNPS5() As String
        Get
            Return _PSCUNPS5
        End Get
        Set(ByVal value As String)
            _PSCUNPS5 = value
        End Set
    End Property

    Private _PSCCUNVL5 As String
    Public Property PSCUNVL5() As String
        Get
            Return _PSCCUNVL5
        End Get
        Set(ByVal value As String)
            _PSCCUNVL5 = value
        End Set
    End Property


    Private _PSFUNDS2 As String
    Public Property PSFUNDS2() As String
        Get
            Return _PSFUNDS2
        End Get
        Set(ByVal value As String)
            _PSFUNDS2 = value
        End Set
    End Property

    Private _PNNDTDTK As Decimal
    Public Property PNNDTDTK() As Decimal
        Get
            Return _PNNDTDTK
        End Get
        Set(ByVal value As Decimal)
            _PNNDTDTK = value
        End Set
    End Property

    Private _PNNSLCSS As Decimal
    Public Property PNNSLCSS() As Decimal
        Get
            Return _PNNSLCSS
        End Get
        Set(ByVal value As Decimal)
            _PNNSLCSS = value
        End Set
    End Property



    Private _PNNSLCSR As Decimal
    Public Property PNNSLCSR() As Decimal
        Get
            Return _PNNSLCSR
        End Get
        Set(ByVal value As Decimal)
            _PNNSLCSR = value
        End Set
    End Property


    Private _PSCUNCN6 As String
    Public Property PSCUNCN6() As String
        Get
            Return _PSCUNCN6
        End Get
        Set(ByVal value As String)
            _PSCUNCN6 = value
        End Set
    End Property


    Private _PSCUNPS6 As String
    Public Property PSCUNPS6() As String
        Get
            Return _PSCUNPS6
        End Get
        Set(ByVal value As String)
            _PSCUNPS6 = value
        End Set
    End Property


    Private _PNCDREGP As Decimal
    Public Property PNCDREGP() As Decimal
        Get
            Return _PNCDREGP
        End Get
        Set(ByVal value As Decimal)
            _PNCDREGP = value
        End Set
    End Property







#End Region

#Region "Propiedades adisionales"
    Private _Estado As Boolean

    Public Property Estado() As Boolean
        Get
            Return _Estado
        End Get
        Set(ByVal value As Boolean)
            _Estado = value
        End Set
    End Property
    Private _PSNRFRPD As String
    ''' <summary>
    ''' REFERENCIA
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSNRFRPD() As String
        Get
            Return _PSNRFRPD
        End Get
        Set(ByVal value As String)
            _PSNRFRPD = value
        End Set
    End Property

    Private _PSNRFTPD As String

    ''' <summary>
    ''' TIPO DE REFERENCIA
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSNRFTPD() As String
        Get
            Return _PSNRFTPD
        End Get
        Set(ByVal value As String)
            _PSNRFTPD = value
        End Set
    End Property


    Private _PSNPLCCM As String
    ''' <summary>
    ''' PLACA
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSNPLCCM() As String
        Get
            Return _PSNPLCCM
        End Get
        Set(ByVal value As String)
            _PSNPLCCM = value
        End Set
    End Property


    Private _PNCTRSP As Decimal
    ''' <summary>
    ''' COD DE TRANSPORTISTA
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNCTRSP() As Decimal
        Get
            Return _PNCTRSP
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSP = value
        End Set
    End Property


    Private _PSTCMPTR As String
    ''' <summary>
    ''' DESCRIPCIÓN DEL TRANSPORTISTA
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTCMPTR() As String
        Get
            Return _PSTCMPTR
        End Get
        Set(ByVal value As String)
            _PSTCMPTR = value
        End Set
    End Property


    Private _PSTDRCTR As String
    ''' <summary>
    ''' DIRECCION DE TRANSPORTISTA
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTDRCTR() As String
        Get
            Return _PSTDRCTR
        End Get
        Set(ByVal value As String)
            _PSTDRCTR = value
        End Set
    End Property


    Private _PNNRUCT As Decimal
    ''' <summary>
    ''' RUC DEL TRANSPORTISTA
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNNRUCT() As Decimal
        Get
            Return _PNNRUCT
        End Get
        Set(ByVal value As Decimal)
            _PNNRUCT = value
        End Set
    End Property


    Private _PSTNMBCH As String
    ''' <summary>
    ''' NOMBRE DEL CHOFERE
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSTNMBCH() As String
        Get
            Return _PSTNMBCH
        End Get
        Set(ByVal value As String)
            _PSTNMBCH = value
        End Set
    End Property


    Private _PSNBRVCH As String
    ''' <summary>
    ''' BREVERE DEL CHOFER
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSNBRVCH() As String
        Get
            Return _PSNBRVCH
        End Get
        Set(ByVal value As String)
            _PSNBRVCH = value
        End Set
    End Property


    Private _PSTDRDST As String
    Public Property PSTDRDST() As String
        Get
            Return _PSTDRDST
        End Get
        Set(ByVal value As String)
            _PSTDRDST = value
        End Set
    End Property



    Private _PSCSRECL As String
    Public Property PSCSRECL() As String
        Get
            Return _PSCSRECL
        End Get
        Set(ByVal value As String)
            _PSCSRECL = value
        End Set
    End Property

    ''' <summary>
    ''' Representa el numero de lote en el cliente ABB, guardamos el pk  del detalle de pedido de ABB
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSNLTECL() As String
        Get
            Return (_PSNLTECL)
        End Get
        Set(ByVal value As String)
            _PSNLTECL = value
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

  
    Private _FechaAsignacion As String

    ''' <summary>
    ''' Atributo de fecha que su equivalencia es FechaAsignacion en formato de fecha
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNFASGTR() As Decimal
        Get
            Return CtypeDate(_FechaAsignacion)
        End Get
        Set(ByVal value As Decimal)
            _FechaAsignacion = NumeroAFecha(value)
        End Set
    End Property

    Public Property FechaAsignacion() As String
        Get
            Return _FechaAsignacion
        End Get
        Set(ByVal value As String)
            _FechaAsignacion = value
        End Set
    End Property



    Private _FechaEmisionGuia As String
    Public Property FechaEmisionGuia() As String
        Get
            Return _FechaEmisionGuia
        End Get
        Set(ByVal value As String)
            _FechaEmisionGuia = value
        End Set
    End Property

    Private _FechaInicioTraslado As String
    Public Property FechaInicioTraslado() As String
        Get
            Return _FechaInicioTraslado
        End Get
        Set(ByVal value As String)
            _FechaInicioTraslado = value
        End Set
    End Property


    Public Property PNFGUIRM() As Decimal
        Get
            Return CtypeDate(_FechaEmisionGuia)
        End Get
        Set(ByVal value As Decimal)
            _FechaEmisionGuia = NumeroAFecha(value)
        End Set
    End Property

    Public Property PNFINTRA() As Decimal
        Get
            Return CtypeDate(_FechaInicioTraslado)
        End Get
        Set(ByVal value As Decimal)
            _FechaInicioTraslado = NumeroAFecha(value)
        End Set
    End Property


    Private _PSCTPALM As String
    Public Property PSCTPALM() As String
        Get
            Return _PSCTPALM
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property


    Private _PSCALMC As String
    Public Property PSCALMC() As String
        Get
            Return _PSCALMC
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property



    Private _CZNALM As String
    Public Property PSCZNALM() As String
        Get
            Return _CZNALM
        End Get
        Set(ByVal value As String)
            _CZNALM = value
        End Set
    End Property

    'EGL - HUNDRED
    Private _PSCRTLTE As String
    Public Property PSCRTLTE() As String
        Get
            Return _PSCRTLTE
        End Get
        Set(ByVal value As String)
            _PSCRTLTE = value
        End Set
    End Property

    Private _PSSTPING As String
    Public Property PSSTPING() As String
        Get
            Return _PSSTPING
        End Get
        Set(ByVal value As String)
            _PSSTPING = value
        End Set
    End Property

    Private _PSSITUAC As String
    Public Property PSSITUAC() As String
        Get
            Return _PSSITUAC
        End Get
        Set(ByVal value As String)
            _PSSITUAC = value
        End Set
    End Property


    Private _PSCTPOAT As String
    Public Property PSCTPOAT() As String
        Get
            Return _PSCTPOAT
        End Get
        Set(ByVal value As String)
            _PSCTPOAT = value
        End Set
    End Property


    Private _PSDTPOAT As String
    Public Property PSDTPOAT() As String
        Get
            Return _PSDTPOAT
        End Get
        Set(ByVal value As String)
            _PSDTPOAT = value
        End Set
    End Property


    Private _PSNORCML As String
    Public Property PSNORCML() As String
        Get
            Return _PSNORCML
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property


    Private _PNNRITOC As Decimal
    Public Property PNNRITOC() As Decimal
        Get
            Return _PNNRITOC
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC = value
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


    Private _PSTDITES As String
    Public Property PSTDITES() As String
        Get
            Return _PSTDITES
        End Get
        Set(ByVal value As String)
            _PSTDITES = value
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


    Private _PSTOBSMD As String
    Public Property PSTOBSMD() As String
        Get
            Return _PSTOBSMD
        End Get
        Set(ByVal value As String)
            _PSTOBSMD = value
        End Set
    End Property


    Private _PSNRGMT1 As String
    Public Property PSNRGMT1() As String
        Get
            Return _PSNRGMT1
        End Get
        Set(ByVal value As String)
            _PSNRGMT1 = value
        End Set
    End Property


    Private _PSTOBSRM As String
    Public Property PSTOBSRM() As String
        Get
            Return _PSTOBSRM
        End Get
        Set(ByVal value As String)
            _PSTOBSRM = value
        End Set
    End Property


    Private _PNNDCFCC As Decimal
    Public Property PNNDCFCC() As Decimal
        Get
            Return _PNNDCFCC
        End Get
        Set(ByVal value As Decimal)
            _PNNDCFCC = value
        End Set
    End Property


    Private _FechaContrato As String


    Public Property PNFDCFCC() As Decimal
        Get
            Return CtypeDate(_FechaContrato)
        End Get
        Set(ByVal value As Decimal)
            _FechaContrato = NumeroAFecha(value)
        End Set
    End Property


    Public Property FechaContrato() As String
        Get
            Return _FechaContrato
        End Get
        Set(ByVal value As String)
            _FechaContrato = value
        End Set
    End Property


    Private _PSSERIE As String
    Public Property PSSERIE() As String
        Get
            Return _PSSERIE
        End Get
        Set(ByVal value As String)
            _PSSERIE = value
        End Set
    End Property


    Private _PSNROFIC As String
    Public Property PSNROFIC() As String
        Get
            Return _PSNROFIC
        End Get
        Set(ByVal value As String)
            _PSNROFIC = value
        End Set
    End Property


    Private _PSTDSDES As String
    Public Property PSTDSDES() As String
        Get
            Return _PSTDSDES
        End Get
        Set(ByVal value As String)
            _PSTDSDES = value
        End Set
    End Property

    Private _PSTOBSRV As String
    Public Property PSTOBSRV() As String
        Get
            Return _PSTOBSRV
        End Get
        Set(ByVal value As String)
            _PSTOBSRV = value
        End Set
    End Property

    Private _PSSTPORL As String
    Public Property PSSTPORL() As String
        Get
            Return _PSSTPORL
        End Get
        Set(ByVal value As String)
            _PSSTPORL = value
        End Set
    End Property

    Private _PSORIGEN As String
    Public Property PSORIGEN() As String
        Get
            Return _PSORIGEN
        End Get
        Set(ByVal value As String)
            _PSORIGEN = value
        End Set
    End Property

    Private _PSDESTINO As String
    Public Property PSDESTINO() As String
        Get
            Return _PSDESTINO
        End Get
        Set(ByVal value As String)
            _PSDESTINO = value
        End Set
    End Property


    Private _PSCLADES As String
    Public Property PSCLADES() As String
        Get
            Return _PSCLADES
        End Get
        Set(ByVal value As String)
            _PSCLADES = value
        End Set
    End Property


    Private _PSTIPCLI As String
    Public Property PSTIPCLI() As String
        Get
            Return _PSTIPCLI
        End Get
        Set(ByVal value As String)
            _PSTIPCLI = value
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

    Public Property PSCPRVD() As String
        Get
            Return (_PSCPRVD)
        End Get
        Set(ByVal value As String)
            _PSCPRVD = value
        End Set
    End Property

    Public Property PSSMTGRM() As String
        Get
            Return (_PSSMTGRM)
        End Get
        Set(ByVal value As String)
            _PSSMTGRM = value
        End Set
    End Property


    Private _CTPGUI As String
    Public Property PSCTPGUI() As String
        Get
            Return _CTPGUI
        End Get
        Set(ByVal value As String)
            _CTPGUI = value
        End Set
    End Property

    Public Property PSMOTTRA() As String
        Get
            Return (_PSMOTTRA)
        End Get
        Set(ByVal value As String)
            _PSMOTTRA = value
        End Set
    End Property



    Private _PNTDCFCC As Decimal
    Public Property PNTDCFCC() As Decimal
        Get
            Return _PNTDCFCC
        End Get
        Set(ByVal value As Decimal)
            _PNTDCFCC = value
        End Set
    End Property


    Private _PNQPSGU As Decimal
    Public Property PNQPSGU() As Decimal
        Get
            Return _PNQPSGU
        End Get
        Set(ByVal value As Decimal)
            _PNQPSGU = value
        End Set
    End Property


    Private _pRazonSocial As String
    Public Property pRazonSocial() As String
        Get
            Return _pRazonSocial
        End Get
        Set(ByVal value As String)
            _pRazonSocial = value
        End Set
    End Property

    Public Property PSCTPIS() As String
        Get
            Return _PSCTPIS
        End Get
        Set(ByVal value As String)
            _PSCTPIS = value
        End Set
    End Property

    Public Property PNFRLZSR() As Decimal
        Get
            Return _PNFRLZSR
        End Get
        Set(ByVal value As Decimal)
            _PNFRLZSR = value
        End Set
    End Property

    Public Property PSSTRNSM() As String
        Get
            Return _PSSTRNSM
        End Get
        Set(ByVal value As String)
            _PSSTRNSM = value
        End Set
    End Property

    Public Property PNFTRNSM() As Decimal
        Get
            Return _PNFTRNSM
        End Get
        Set(ByVal value As Decimal)
            _PNFTRNSM = value
        End Set
    End Property

    Public Property PNHTRNSM() As Decimal
        Get
            Return _PNHTRNSM
        End Get
        Set(ByVal value As Decimal)
            _PNHTRNSM = value
        End Set
    End Property

    Public Property PNFCHCRT() As Decimal
        Get
            Return _PNFCHCRT
        End Get
        Set(ByVal value As Decimal)
            _PNFCHCRT = value
        End Set
    End Property

    Public Property PNHRACRT() As Decimal
        Get
            Return _PNHRACRT
        End Get
        Set(ByVal value As Decimal)
            _PNHRACRT = value
        End Set
    End Property

    Public Property PNFULTAC() As Decimal
        Get
            Return _PNFULTAC
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property

    Public Property PNHULTAC() As Decimal
        Get
            Return _PNHULTAC
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
        End Set
    End Property

    Public Property PSSTPODP() As String
        Get
            Return _PSSTPODP
        End Get
        Set(ByVal value As String)
            _PSSTPODP = value
        End Set
    End Property

    Public Property PNNPRTIN() As Decimal
        Get
            Return _PNNPRTIN
        End Get
        Set(ByVal value As Decimal)
            _PNNPRTIN = value
        End Set
    End Property



    Private _PNQITEMS As Integer
    Public Property PNQITEMS() As Integer
        Get
            Return _PNQITEMS
        End Get
        Set(ByVal value As Integer)
            _PNQITEMS = value
        End Set
    End Property

    Private _PSCPSCN As String
    Public Property PSCPSCN() As String
        Get
            Return _PSCPSCN
        End Get
        Set(ByVal value As String)
            _PSCPSCN = value
        End Set
    End Property


    Private _CHK As Boolean
    Public Property CHK() As Boolean
        Get
            Return _CHK
        End Get
        Set(ByVal value As Boolean)
            _CHK = value
        End Set
    End Property

    Private _PNNCOPY As Decimal
    Public Property PNNCOPY() As Decimal
        Get
            Return _PNNCOPY
        End Get
        Set(ByVal value As Decimal)
            _PNNCOPY = value
        End Set
    End Property


    Private _PSSTPMOV As String
    Public Property PSSTPMOV() As String
        Get
            Return _PSSTPMOV
        End Get
        Set(ByVal value As String)
            _PSSTPMOV = value
        End Set
    End Property


    Private _PNQREMC As Decimal
    Public Property PNQREMC() As Decimal
        Get
            Return _PNQREMC
        End Get
        Set(ByVal value As Decimal)
            _PNQREMC = value
        End Set
    End Property



    Private _PNPREVTR As Decimal
    Public Property PNPREVTR() As Decimal
        Get
            Return _PNPREVTR
        End Get
        Set(ByVal value As Decimal)
            _PNPREVTR = value
        End Set
    End Property


    Private _PNQREVTR As Decimal
    Public Property PNQREVTR() As Decimal
        Get
            Return _PNQREVTR
        End Get
        Set(ByVal value As Decimal)
            _PNQREVTR = value
        End Set
    End Property


    Private _PNQSLMC As Decimal
    Public Property PNQSLMC() As Decimal
        Get
            Return _PNQSLMC
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMC = value
        End Set
    End Property


    Private _PSTRFRN2 As String
    Public Property PSTRFRN2() As String
        Get
            Return _PSTRFRN2
        End Get
        Set(ByVal value As String)
            _PSTRFRN2 = value
        End Set
    End Property

#End Region


    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub
End Class
