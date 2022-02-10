Imports System.ComponentModel
Imports RANSA.Utilitario

Public Class bePedidoPorPlanta
    Inherits beBase(Of bePedidoPorPlanta)

    Private _PNCDPEPL As Double
    Private _PNCDREGP As Double
    Private _PNNORDSR As Double
    Private _PNNCRRIN As Double
    Private _PSCMRCLR As String
    Private _PNFCHSPE As String
    Private _PNHRASPE As Double
    Private _PNCUSROL As Double
    Private _PNCCLNT As Double
    Private _PNCPLNCL As Double
    Private _PNCPRVCL As Double
    Private _PNCPLCLP As Double
    Private _PNQSRVC As Double
    Private _PSCUNCN6 As String
    Private _PNQEQUIV As Double
    Private _PSCUNCEQ As String
    Private _PNPSRVC As Double
    Private _PSCUNPS6 As String
    Private _PNQDSMC As Double
    Private _PNQDSMP As Double
    Private _PNNDCFCC As Double
    Private _PSSATSLS As String
    Private _PSSATNAL As String
    Private _PSFLGAPR As String
    Private _PSFLGURG As String
    Private _PSFLGATT As String
    Private _PSSBCKRD As String
    Private _PSSTPDSP As String
    Private _PSSTPPDD As String
    Private _PSNORCML As String
    Private _PNFDSPAL As String
    Private _PSTOBSMD As String
    Private _PSNRFRPD As String
    Private _PNNRITOC As Double
    Private _PNIMVTAD As Double
    Private _PNIMVTAS As Double
    Private _PNITTDDD As Double
    Private _PNITTDDS As Double
    Private _PNITTDDO As Double
    Private _PNCMNDPG As Double
    Private _PSCCNDPG As String
    Private _PNNROSEQ As Double
    Private _PSCCLVSG As String
    Private _PSUSRAUT As String
    Private _PSSTRNSM As String
    Private _PNFTRNSM As Double
    Private _PNHTRNSM As Double
    Private _PNFULTAC As String
    Private _PNHULTAC As Double
    Private _PSCULUSA As String
    Private _PNFCHCRT As Double
    Private _PNHRACRT As Double
    Private _PSCUSCRT As String
    Private _PSSESTRG As String
    Private _PSNPLCCM As String
    Private _PSNLTECL As String
    Private _PNUPDATE_IDENT As Double
    Private _CANTIDAD As Double
    Private _PSCTPDP6 As String
    Private _PSTMRCD2 As String
    Private _PSTCMPPL As String
    Private _PSDESPROV As String
    Private _PNQSLMC As Decimal
    Private _PNQSLMP As Decimal
    Private _PNQSLMV As Decimal
    Private _PNNCNTR As Decimal
    Private _PSCUNCN5 As String
    Private _PSCUNPS5 As String
    Private _PSCUNVL5 As String
    Private _PSCMRCD As String
    Private _PNNCRCTC As String
    Private _PNNAUTR As String
    Private _PSFUNDS2 As String
    Private _QPENDIN As Decimal
    Private _PPENDIN As Decimal
    Private _PNSALDO As Decimal
    Private _PNCANTIDAD As Decimal
    Private _CHECK As Boolean = False
    Private _PNATENDER As Decimal = 0
    Private _PSFUNCTL As String
    Private _PNCANT_OS_X_SKU As Decimal = 0
    Private _PSFUBICAC As String = ""
 

    Public Property PSFUBICAC() As String
        Get
            Return _PSFUBICAC
        End Get
        Set(ByVal value As String)
            _PSFUBICAC = value
        End Set
    End Property

    Public Property PNATENDER() As Decimal
        Get
            Return _PNATENDER
        End Get
        Set(ByVal value As Decimal)
            _PNATENDER = value
        End Set
    End Property


    Public Property CHECK() As Boolean
        Get
            Return _CHECK
        End Get
        Set(ByVal value As Boolean)
            _CHECK = value
        End Set
    End Property


    Public Property PSFUNDS2() As String
        Get
            Return _PSFUNDS2
        End Get
        Set(ByVal value As String)
            _PSFUNDS2 = value
        End Set
    End Property


    Public Property PNNAUTR() As String
        Get
            Return _PNNAUTR
        End Get
        Set(ByVal value As String)
            _PNNAUTR = value
        End Set
    End Property

    Public Property PNNCRCTC() As String
        Get
            Return _PNNCRCTC
        End Get
        Set(ByVal value As String)
            _PNNCRCTC = value
        End Set
    End Property

    Public Property PSCMRCD() As String
        Get
            Return _PSCMRCD
        End Get
        Set(ByVal value As String)
            _PSCMRCD = value
        End Set
    End Property

    Public Property PSCUNVL5() As String
        Get
            Return _PSCUNVL5
        End Get
        Set(ByVal value As String)
            _PSCUNVL5 = value
        End Set
    End Property

    Public Property PSCUNPS5() As String
        Get
            Return _PSCUNPS5
        End Get
        Set(ByVal value As String)
            _PSCUNPS5 = value
        End Set
    End Property

    Public Property PSCUNCN5() As String
        Get
            Return _PSCUNCN5
        End Get
        Set(ByVal value As String)
            _PSCUNCN5 = value
        End Set
    End Property

    Public Property PNNCNTR() As Decimal
        Get
            Return _PNNCNTR
        End Get
        Set(ByVal value As Decimal)
            _PNNCNTR = value
        End Set
    End Property


    Public Property PNQSLMV() As Decimal
        Get
            Return _PNQSLMV
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMV = value
        End Set
    End Property

    Public Property PNQSLMP() As Decimal
        Get
            Return _PNQSLMP
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMP = value
        End Set
    End Property

    Public Property PNQSLMC() As Decimal
        Get
            Return _PNQSLMC
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMC = value
        End Set
    End Property


    Public Property PSDESPROV() As String
        Get
            Return _PSDESPROV
        End Get
        Set(ByVal value As String)
            _PSDESPROV = value
        End Set
    End Property


    Public Property PSTCMPPL() As String
        Get
            Return _PSTCMPPL
        End Get
        Set(ByVal value As String)
            _PSTCMPPL = value
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

    Public Property PSTMRCD2() As String
        Get
            Return _PSTMRCD2
        End Get
        Set(ByVal value As String)
            _PSTMRCD2 = value
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


    Public Property CANTIDAD() As Double
        Get
            Return _CANTIDAD
        End Get
        Set(ByVal value As Double)
            _CANTIDAD = value
        End Set
    End Property


    Public Property PNCDPEPL() As Double
        Get
            Return (_PNCDPEPL)
        End Get
        Set(ByVal value As Double)
            _PNCDPEPL = value
        End Set
    End Property
    Public Property PNCDREGP() As Double
        Get
            Return (_PNCDREGP)
        End Get
        Set(ByVal value As Double)
            _PNCDREGP = value
        End Set
    End Property


    Private _CORRELATIVO As Integer
    Public Property CORRELATIVO() As Integer
        Get
            Return _CORRELATIVO
        End Get
        Set(ByVal value As Integer)
            _CORRELATIVO = value
        End Set
    End Property


    Private _PNNCRRLT As Decimal
    Public Property PNNCRRLT() As Decimal
        Get
            Return _PNNCRRLT
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRLT = value
        End Set
    End Property

    Public Property PNNORDSR() As Double
        Get
            Return (_PNNORDSR)
        End Get
        Set(ByVal value As Double)
            _PNNORDSR = value
        End Set
    End Property
    Public Property PNNCRRIN() As Double
        Get
            Return (_PNNCRRIN)
        End Get
        Set(ByVal value As Double)
            _PNNCRRIN = value
        End Set
    End Property
    Public Property PSCMRCLR() As String
        Get
            Return (_PSCMRCLR)
        End Get
        Set(ByVal value As String)
            _PSCMRCLR = value
        End Set
    End Property

    Public Property PNFCHSPE() As String
        Get
            Return (_PNFCHSPE)
        End Get
        Set(ByVal value As String)
            _PNFCHSPE = value
        End Set
    End Property

    Public Property PNHRASPE() As Double
        Get
            Return (_PNHRASPE)
        End Get
        Set(ByVal value As Double)
            _PNHRASPE = value
        End Set
    End Property
    Public Property PNCUSROL() As Double
        Get
            Return (_PNCUSROL)
        End Get
        Set(ByVal value As Double)
            _PNCUSROL = value
        End Set
    End Property
    Public Property PNCCLNT() As Double
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Double)
            _PNCCLNT = value
        End Set
    End Property
    Public Property PNCPLNCL() As Double
        Get
            Return (_PNCPLNCL)
        End Get
        Set(ByVal value As Double)
            _PNCPLNCL = value
        End Set
    End Property
    Public Property PNCPRVCL() As Double
        Get
            Return (_PNCPRVCL)
        End Get
        Set(ByVal value As Double)
            _PNCPRVCL = value
        End Set
    End Property
    Public Property PNCPLCLP() As Double
        Get
            Return (_PNCPLCLP)
        End Get
        Set(ByVal value As Double)
            _PNCPLCLP = value
        End Set
    End Property
    Public Property PNQSRVC() As Double
        Get
            Return (_PNQSRVC)
        End Get
        Set(ByVal value As Double)
            _PNQSRVC = value
        End Set
    End Property
    Public Property PSCUNCN6() As String
        Get
            Return (_PSCUNCN6)
        End Get
        Set(ByVal value As String)
            _PSCUNCN6 = value
        End Set
    End Property
    Public Property PNQEQUIV() As Double
        Get
            Return (_PNQEQUIV)
        End Get
        Set(ByVal value As Double)
            _PNQEQUIV = value
        End Set
    End Property
    Public Property PSCUNCEQ() As String
        Get
            Return (_PSCUNCEQ)
        End Get
        Set(ByVal value As String)
            _PSCUNCEQ = value
        End Set
    End Property
    Public Property PNPSRVC() As Double
        Get
            Return (_PNPSRVC)
        End Get
        Set(ByVal value As Double)
            _PNPSRVC = value
        End Set
    End Property
    Public Property PSCUNPS6() As String
        Get
            Return (_PSCUNPS6)
        End Get
        Set(ByVal value As String)
            _PSCUNPS6 = value
        End Set
    End Property
    Public Property PNQDSMC() As Double
        Get
            Return (_PNQDSMC)
        End Get
        Set(ByVal value As Double)
            _PNQDSMC = value
        End Set
    End Property
    Public Property PNQDSMP() As Double
        Get
            Return (_PNQDSMP)
        End Get
        Set(ByVal value As Double)
            _PNQDSMP = value
        End Set
    End Property
    Public Property PNNDCFCC() As Double
        Get
            Return (_PNNDCFCC)
        End Get
        Set(ByVal value As Double)
            _PNNDCFCC = value
        End Set
    End Property
    Public Property PSSATSLS() As String
        Get
            Return (_PSSATSLS)
        End Get
        Set(ByVal value As String)
            _PSSATSLS = value
        End Set
    End Property
    Public Property PSSATNAL() As String
        Get
            Return (_PSSATNAL)
        End Get
        Set(ByVal value As String)
            _PSSATNAL = value
        End Set
    End Property
    Public Property PSFLGAPR() As String
        Get
            Return (_PSFLGAPR)
        End Get
        Set(ByVal value As String)
            _PSFLGAPR = value
        End Set
    End Property
    Public Property PSFLGURG() As String
        Get
            Return (_PSFLGURG)
        End Get
        Set(ByVal value As String)
            _PSFLGURG = value
        End Set
    End Property
    Public Property PSFLGATT() As String
        Get
            Return (_PSFLGATT)
        End Get
        Set(ByVal value As String)
            _PSFLGATT = value
        End Set
    End Property
    Public Property PSSBCKRD() As String
        Get
            Return (_PSSBCKRD)
        End Get
        Set(ByVal value As String)
            _PSSBCKRD = value
        End Set
    End Property
    Public Property PSSTPDSP() As String
        Get
            Return (_PSSTPDSP)
        End Get
        Set(ByVal value As String)
            _PSSTPDSP = value
        End Set
    End Property
    Public Property PSSTPPDD() As String
        Get
            Return (_PSSTPPDD)
        End Get
        Set(ByVal value As String)
            _PSSTPPDD = value
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
    Public Property PNFDSPAL() As String
        Get
            Return (_PNFDSPAL)
        End Get
        Set(ByVal value As String)
            _PNFDSPAL = value
        End Set
    End Property
    Public Property PSTOBSMD() As String
        Get
            Return (_PSTOBSMD)
        End Get
        Set(ByVal value As String)
            _PSTOBSMD = value
        End Set
    End Property
    Public Property PSNRFRPD() As String
        Get
            Return (_PSNRFRPD)
        End Get
        Set(ByVal value As String)
            _PSNRFRPD = value
        End Set
    End Property
    Public Property PNNRITOC() As Double
        Get
            Return (_PNNRITOC)
        End Get
        Set(ByVal value As Double)
            _PNNRITOC = value
        End Set
    End Property
    Public Property PNIMVTAD() As Double
        Get
            Return (_PNIMVTAD)
        End Get
        Set(ByVal value As Double)
            _PNIMVTAD = value
        End Set
    End Property
    Public Property PNIMVTAS() As Double
        Get
            Return (_PNIMVTAS)
        End Get
        Set(ByVal value As Double)
            _PNIMVTAS = value
        End Set
    End Property
    Public Property PNITTDDD() As Double
        Get
            Return (_PNITTDDD)
        End Get
        Set(ByVal value As Double)
            _PNITTDDD = value
        End Set
    End Property
    Public Property PNITTDDS() As Double
        Get
            Return (_PNITTDDS)
        End Get
        Set(ByVal value As Double)
            _PNITTDDS = value
        End Set
    End Property
    Public Property PNITTDDO() As Double
        Get
            Return (_PNITTDDO)
        End Get
        Set(ByVal value As Double)
            _PNITTDDO = value
        End Set
    End Property
    Public Property PNCMNDPG() As Double
        Get
            Return (_PNCMNDPG)
        End Get
        Set(ByVal value As Double)
            _PNCMNDPG = value
        End Set
    End Property
    Public Property PSCCNDPG() As String
        Get
            Return (_PSCCNDPG)
        End Get
        Set(ByVal value As String)
            _PSCCNDPG = value
        End Set
    End Property
    Public Property PNNROSEQ() As Double
        Get
            Return (_PNNROSEQ)
        End Get
        Set(ByVal value As Double)
            _PNNROSEQ = value
        End Set
    End Property
    Public Property PSCCLVSG() As String
        Get
            Return (_PSCCLVSG)
        End Get
        Set(ByVal value As String)
            _PSCCLVSG = value
        End Set
    End Property
    Public Property PSUSRAUT() As String
        Get
            Return (_PSUSRAUT)
        End Get
        Set(ByVal value As String)
            _PSUSRAUT = value
        End Set
    End Property
    Public Property PSSTRNSM() As String
        Get
            Return (_PSSTRNSM)
        End Get
        Set(ByVal value As String)
            _PSSTRNSM = value
        End Set
    End Property
    Public Property PNFTRNSM() As Double
        Get
            Return (_PNFTRNSM)
        End Get
        Set(ByVal value As Double)
            _PNFTRNSM = value
        End Set
    End Property
    Public Property PNHTRNSM() As Double
        Get
            Return (_PNHTRNSM)
        End Get
        Set(ByVal value As Double)
            _PNHTRNSM = value
        End Set
    End Property
    Public Property PNFULTAC() As String
        Get
            Return (_PNFULTAC)
        End Get
        Set(ByVal value As String)
            _PNFULTAC = value
        End Set
    End Property

    Public Property PSFUNCTL() As String
        Get
            Return _PSFUNCTL
        End Get
        Set(ByVal value As String)
            _PSFUNCTL = value
        End Set
    End Property
    ''' <summary>
    ''' Fecha con Formato AAAAMMDD
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PNFULTAC_Con_Formato_AAAAMMDD() As Double
        Get
            Return HelpClass.TodayNumeric
        End Get
    End Property

    Public Property PNHULTAC() As Double
        Get
            Return (_PNHULTAC)
        End Get
        Set(ByVal value As Double)
            _PNHULTAC = value
        End Set
    End Property

    Public ReadOnly Property PNHULTAC_Con_Formato_HHMMSS() As Double
        Get
            Return HelpClass.NowNumeric
        End Get
    End Property

    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property PNFCHCRT() As Double
        Get
            Return (_PNFCHCRT)
        End Get
        Set(ByVal value As Double)
            _PNFCHCRT = value
        End Set
    End Property
    Public Property PNHRACRT() As Double
        Get
            Return (_PNHRACRT)
        End Get
        Set(ByVal value As Double)
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
    Public Property PSSESTRG() As String
        Get
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property
    Public Property PSNPLCCM() As String
        Get
            Return (_PSNPLCCM)
        End Get
        Set(ByVal value As String)
            _PSNPLCCM = value
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
    Public Property PNUPDATE_IDENT() As Double
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Double)
            _PNUPDATE_IDENT = value
        End Set
    End Property
    Public Property QPENDIN() As Decimal
        Get
            Return _QPENDIN
        End Get
        Set(ByVal value As Decimal)
            _QPENDIN = value
        End Set
    End Property

    Public Property PPENDIN() As Decimal
        Get
            Return _PPENDIN
        End Get
        Set(ByVal value As Decimal)
            _PPENDIN = value
        End Set
    End Property


    Public Property PNSALDO() As Decimal
        Get
            Return _PNSALDO
        End Get
        Set(ByVal value As Decimal)
            _PNSALDO = value
        End Set
    End Property

    Private _PSSCNTSR As String
    Public Property PSSCNTSR() As String
        Get
            Return _PSSCNTSR
        End Get
        Set(ByVal value As String)
            _PSSCNTSR = value
        End Set
    End Property


    Public Property PNCANTIDAD() As Decimal
        Get
            Return _PNCANTIDAD
        End Get
        Set(ByVal value As Decimal)
            _PNCANTIDAD = value
        End Set
    End Property


    Private _PSNRFRPD1 As String
    Public Property PSNRFRPD1() As String
        Get
            Return _PSNRFRPD1
        End Get
        Set(ByVal value As String)
            _PSNRFRPD1 = value
        End Set
    End Property

    ' <Browsable()> _
    Private _PSNRFTPD As String

    Public Property PSNRFTPD() As String
        Get
            Return _PSNRFTPD
        End Get
        Set(ByVal value As String)
            _PSNRFTPD = value
        End Set
    End Property

    Private _PSTCTCST As String = ""

    Public Property PSTCTCST() As String
        Get
            Return _PSTCTCST
        End Get
        Set(ByVal value As String)
            _PSTCTCST = value
        End Set
    End Property

    Private _PSMERCADERIA As String

    Public Property PSMERCADERIA() As String
        Get
            Return _PSMERCADERIA
        End Get
        Set(ByVal value As String)
            _PSMERCADERIA = value
        End Set
    End Property


    Private _ESTADO As Boolean

    Public Property ESTADO() As Boolean
        Get
            Return _ESTADO
        End Get
        Set(ByVal value As Boolean)
            _ESTADO = value
        End Set
    End Property


    Private _PSCLIENTE As String
    ''' <summary>
    ''' Cliente a entregar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCLIENTE() As String
        Get
            Return _PSCLIENTE
        End Get
        Set(ByVal value As String)
            _PSCLIENTE = value
        End Set
    End Property


    Private _PSDIRECCION As String
    ''' <summary>
    ''' Dirección de entrega
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSDIRECCION() As String
        Get
            Return _PSDIRECCION
        End Get
        Set(ByVal value As String)
            _PSDIRECCION = value
        End Set
    End Property



    ''' <summary>
    ''' Fecha de Solicitud formato DATE
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSFECSOL() As String
        Get
            Return NumeroAFecha(_PNFCHSPE)
        End Get
        Set(ByVal value As String)
            _PNFCHSPE = CtypeDate(value)
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CtypeDate(ByVal obj As Object) As Decimal
        Dim objDate As New Date
        If obj.Equals("") = True Then
            Return 0
        Else
            objDate = obj
        End If
        Return objDate.Year & "" & IIf(objDate.Month < 10, "0" & objDate.Month, objDate.Month) & "" & IIf(objDate.Day < 10, "0" & objDate.Day, objDate.Day)
    End Function

    ''' <summary>
    ''' Convierte número de ocho yyyymmdd digitos a cadena en formato (yyyy/mm/dd)
    ''' </summary>
    ''' <param name="oFecha">Número en formato yyyymmdd</param>
    ''' <returns>Retorna cadena en formato yyyy/mm/dd</returns>
    ''' <remarks></remarks>
    Public Function NumeroAFecha(ByVal oFecha As Object) As String
        If oFecha = 0 Then Return ""
        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""

        y = Left(oFecha.ToString(), 4)
        m = Right(Left(oFecha.ToString(), 6), 2)
        d = Right(oFecha.ToString(), 2)
        Return d & "/" & m & "/" & y
    End Function


    Private _PSTOBSGS As String
    Public Property PSTOBSGS() As String
        Get
            Return _PSTOBSGS
        End Get
        Set(ByVal value As String)
            _PSTOBSGS = value
        End Set
    End Property


    Private _PNFECCSP As Decimal
    Public Property PNFECCSP() As Decimal
        Get
            Return _PNFECCSP
        End Get
        Set(ByVal value As Decimal)
            _PNFECCSP = value
        End Set
    End Property


    Private _PSARESOL As String
    Public Property PSARESOL() As String
        Get
            Return _PSARESOL
        End Get
        Set(ByVal value As String)
            _PSARESOL = value
        End Set
    End Property

    Private _PNFMPDME As Decimal
    Public Property PNFMPDME() As Decimal
        Get
            Return _PNFMPDME
        End Get
        Set(ByVal value As Decimal)
            _PNFMPDME = value
        End Set
    End Property

    Private _PSCODPEDIDO As String
    Public Property PSCODPEDIDO() As String
        Get
            Return _PSCODPEDIDO
        End Get
        Set(ByVal value As String)
            _PSCODPEDIDO = value
        End Set
    End Property

    Private _PSCHK As String
    Public Property PSCHK() As String
        Get
            Return _PSCHK
        End Get
        Set(ByVal value As String)
            _PSCHK = value
        End Set
    End Property

    Public Property PNCANT_OS_X_SKU() As Decimal
        Get
            Return _PNCANT_OS_X_SKU
        End Get
        Set(ByVal value As Decimal)
            _PNCANT_OS_X_SKU = value
        End Set
    End Property

    Private _PSTOBS_CARGA_ITEM As String = ""
    Public Property PSTOBS_CARGA_ITEM() As String
        Get
            Return _PSTOBS_CARGA_ITEM
        End Get
        Set(ByVal value As String)
            _PSTOBS_CARGA_ITEM = value
        End Set
    End Property
    Public Sub New()
        Me.InicializeProperty(Me)
    End Sub
End Class