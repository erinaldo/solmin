Public Class FacturaSIL
    Inherits Base_BE
#Region "Facturacion y Consistencia"
    '/////////////////////////////////
    '///Facturacion y Consistencia///
    '////////////////////////////////
    Private _NSECFC As Double = 0
    Private _TCMPDV As String = ""
    Private _CCLNFC As Double = 0
    Private _CPLNDV As String = ""
    Private _CMNDA1 As String = ""
    Private _CCNTCS As Double = 0
    Private _CRGVTA As String = ""

    Private _ITCCTC As Decimal = 0
    Private _CTPODC As Decimal = 0
    Private _NDCCTC As Decimal = 0
    Private _FDCCTC As Decimal = 0
    Private _LIBERAR As String = ""
    Private _PNCCLNT As Decimal = 0

    Property NSECFC() As Double
        Get
            Return _NSECFC
        End Get
        Set(ByVal value As Double)
            _NSECFC = value
        End Set
    End Property
    Property TCMPDV() As String
        Get
            Return _TCMPDV
        End Get
        Set(ByVal value As String)
            _TCMPDV = value
        End Set
    End Property
    Property CCLNFC() As Double
        Get
            Return _CCLNFC
        End Get
        Set(ByVal value As Double)
            _CCLNFC = value
        End Set
    End Property
    Property CPLNDV() As String
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As String)
            _CPLNDV = value
        End Set
    End Property
    Property CMNDA1() As String
        Get
            Return _CMNDA1
        End Get
        Set(ByVal value As String)
            _CMNDA1 = value
        End Set
    End Property
    Property CCNTCS() As Double
        Get
            Return _CCNTCS
        End Get
        Set(ByVal value As Double)
            _CCNTCS = value
        End Set
    End Property
    Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property
    Property ITCCTC() As Decimal
        Get
            Return _ITCCTC
        End Get
        Set(ByVal value As Decimal)
            _ITCCTC = value
        End Set
    End Property

    Property CTPODC() As Decimal
        Get
            Return _CTPODC
        End Get
        Set(ByVal value As Decimal)
            _CTPODC = value
        End Set
    End Property



    Property NDCCTC() As Decimal
        Get
            Return _NDCCTC
        End Get
        Set(ByVal value As Decimal)
            _NDCCTC = value
        End Set
    End Property

    Property FDCCTC() As Decimal
        Get
            Return _FDCCTC
        End Get
        Set(ByVal value As Decimal)
            _FDCCTC = value
        End Set
    End Property

    Property LIBERAR() As String
        Get
            Return _LIBERAR
        End Get
        Set(ByVal value As String)
            _LIBERAR = value
        End Set
    End Property

    Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property








    '//////////////////////////////
#End Region

#Region "Facturacion SIL"

    'Private _CCMPN As String = ""
    'Private _CDVSN As String = ""
    Private _CCLNT As String = ""
    Private _F_INICIO As String = ""
    Private _F_FINAL As String = ""

    Private _SESTOP As String = ""
    Private _FINCOP As String = ""
    Private _FTRMOP As String = ""
    Private _NOPRCN As String = ""
    Private _NPLNMT As String = ""
    Private _CCLORI As String = ""
    Private _NORDIN As String = ""
    Private _SACORI As String = ""

    'Private _PageCount As Double = 0
    'Private _PageNumber As Double = 0
    'Private _PageSize As Double = 0

    Private _ESTADO_DETALLE As String = ""

    Private _CCMPN_DESC As String = ""
    Private _CDVSN_DESC As String = ""
    Private _CPLNDV_DESC As String = ""
    Private _CCLNOP As Decimal = 0 'Desarrollador 3 JD

    Property CCLNT() As String
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As String)
            _CCLNT = value
        End Set
    End Property

    Property CCMPN_DESC() As String
        Get
            Return _CCMPN_DESC
        End Get
        Set(ByVal value As String)
            _CCMPN_DESC = value
        End Set
    End Property

    Property CDVSN_DESC() As String
        Get
            Return _CDVSN_DESC
        End Get
        Set(ByVal value As String)
            _CDVSN_DESC = value
        End Set
    End Property

    Property CPLNDV_DESC() As String
        Get
            Return _CPLNDV_DESC
        End Get
        Set(ByVal value As String)
            _CPLNDV_DESC = value
        End Set
    End Property

    Property ESTADO_DETALLE() As String
        Get
            Return _ESTADO_DETALLE
        End Get
        Set(ByVal value As String)
            _ESTADO_DETALLE = value
        End Set
    End Property

    Property CCLORI() As String
        Get
            Return _CCLORI
        End Get
        Set(ByVal value As String)
            _CCLORI = value
        End Set
    End Property
    Property NORDIN() As String
        Get
            Return _NORDIN
        End Get
        Set(ByVal value As String)
            _NORDIN = value
        End Set
    End Property
    Property SACORI() As String
        Get
            Return _SACORI
        End Get
        Set(ByVal value As String)
            _SACORI = value
        End Set
    End Property

    Property F_INICIO() As String
        Get
            Return _F_INICIO
        End Get
        Set(ByVal value As String)
            _F_INICIO = value
        End Set
    End Property
    Property F_FINAL() As String
        Get
            Return _F_FINAL
        End Get
        Set(ByVal value As String)
            _F_FINAL = value
        End Set
    End Property
    'Property CCMPN() As String
    '    Get
    '        Return _CCMPN
    '    End Get
    '    Set(ByVal value As String)
    '        _CCMPN = value
    '    End Set
    'End Property

    'Property CDVSN() As String
    '    Get
    '        Return _CDVSN
    '    End Get
    '    Set(ByVal value As String)
    '        _CDVSN = value
    '    End Set
    'End Property

    Property SESTOP() As String
        Get
            Return _SESTOP
        End Get
        Set(ByVal value As String)
            _SESTOP = value
        End Set
    End Property

    Property FINCOP() As String
        Get
            Return _FINCOP
        End Get
        Set(ByVal value As String)
            _FINCOP = value
        End Set
    End Property
    Property FTRMOP() As String
        Get
            Return _FTRMOP
        End Get
        Set(ByVal value As String)
            _FTRMOP = value
        End Set
    End Property

    Property NOPRCN() As String
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As String)
            _NOPRCN = value
        End Set
    End Property
    Property NPLNMT() As String
        Get
            Return _NPLNMT
        End Get
        Set(ByVal value As String)
            _NPLNMT = value
        End Set
    End Property


    Private _TIPOFACTURA As Integer
    ''' <summary>
    ''' Formas de como debe de mostrar la factura
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TIPOFACTURA() As Integer
        Get
            Return _TIPOFACTURA
        End Get
        Set(ByVal value As Integer)
            _TIPOFACTURA = value
        End Set
    End Property

    'Desarrollador 3 JD
    Property CCLNOP() As Decimal
        Get
            Return _CCLNOP
        End Get
        Set(ByVal value As Decimal)
            _CCLNOP = value
        End Set
    End Property

    Private _NCRRPD As String = ""
    Public Property NCRRPD As String
        Get
            Return _NCRRPD
        End Get
        Set(ByVal value As String)
            _NCRRPD = value
        End Set
    End Property

    Private _NPRLQD As Decimal
    Public Property NPRLQD() As Decimal
        Get
            Return _NPRLQD
        End Get
        Set(ByVal value As Decimal)
            _NPRLQD = value
        End Set
    End Property


    'Property PageCount() As Double
    '    Get
    '        Return _PageCount
    '    End Get
    '    Set(ByVal value As Double)
    '        _PageCount = value
    '    End Set
    'End Property
    'Property PageNumber() As Double
    '    Get
    '        Return _PageNumber
    '    End Get
    '    Set(ByVal value As Double)
    '        _PageNumber = value
    '    End Set
    'End Property
    'Property PageSize() As Double
    '    Get
    '        Return _PageSize
    '    End Get
    '    Set(ByVal value As Double)
    '        _PageSize = value
    '    End Set
    'End Property
#End Region

End Class