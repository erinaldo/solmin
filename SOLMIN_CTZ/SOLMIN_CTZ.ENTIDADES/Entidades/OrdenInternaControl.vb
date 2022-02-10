Public Class OrdenInternaControl
    Inherits Base_BE

    Private _SESTOP As String = ""
    Private _FINCOP As String = ""
    Private _FTRMOP As String = ""
    Private _NOPRCN As String = ""
    Private _NPLNMT As String = ""
    Private _F_INICIO As String = ""
    Private _F_FINAL As String = ""
    Private _CCLORI As String = ""
    Private _NORDIN As String = ""
    Private _SACORI As String = ""

    Private _ESTADO_DETALLE As String = ""

    Private _CCMPN_DESC As String = ""
    Private _CDVSN_DESC As String = ""
    Private _CPLNDV_DESC As String = ""

    Private _oDtOI As DataTable
    Public Property oDtOI() As DataTable
        Get
            Return _oDtOI
        End Get
        Set(ByVal value As DataTable)
            _oDtOI = value
        End Set
    End Property

    Private _PNFACTURADOS As Integer
    Public Property PNFACTURADOS() As Integer
        Get
            Return _PNFACTURADOS
        End Get
        Set(ByVal value As Integer)
            _PNFACTURADOS = value
        End Set
    End Property

    Private _PNANULADOS As Integer
    Public Property PNANULADOS() As Integer
        Get
            Return _PNANULADOS
        End Get
        Set(ByVal value As Integer)
            _PNANULADOS = value
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

End Class
