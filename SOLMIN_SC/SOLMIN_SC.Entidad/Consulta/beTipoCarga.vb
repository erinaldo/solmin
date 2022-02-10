Public Class beTipoCarga
    Private _PNNORSCI As Decimal = 0
    Private _PSCOD_PUERTO As String = ""
    Private _PSPUERTO As String = ""
    Private _PNCOD_PAIS As Decimal = 0
    Private _PSPAIS As String = ""
    Private _PNFLETE As Decimal = 0
    Private _PNVOLUMEN As Decimal = 0
    Private _PNPESO As Decimal = 0
    Private _PNCOD_TRANSPORTE As Decimal = 0
    Private _PSTRANSPORTE As String = ""
    Private _PNCOD_FORWARDER As Decimal = 0
    Private _PSFORWARDER As String = ""
    Private _PSMERCADERIA As String = ""
    Private _PSTIPO_CARGA As String = ""
    Private _PSFECHA_ORDEN As String = ""
    Private _PSTCMPCL As String = ""
    Private _PSTMTVBJ As String = ""
    Private _PNCCLNT As Decimal = 0

    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal Value As Decimal)
            _PNNORSCI = Value
        End Set
    End Property


    Public Property PSCOD_PUERTO() As String
        Get
            Return _PSCOD_PUERTO
        End Get
        Set(ByVal value As String)
            _PSCOD_PUERTO = value
        End Set
    End Property

    Public Property PSPUERTO() As String
        Get
            Return _PSPUERTO
        End Get
        Set(ByVal value As String)
            _PSPUERTO = value
        End Set
    End Property


    Public Property PNCOD_PAIS() As Decimal
        Get
            Return _PNCOD_PAIS
        End Get
        Set(ByVal value As Decimal)
            _PNCOD_PAIS = value
        End Set
    End Property


    Public Property PSPAIS() As String
        Get
            Return _PSPAIS
        End Get
        Set(ByVal value As String)
            _PSPAIS = value
        End Set
    End Property

    Public Property PNFLETE() As Decimal
        Get
            Return _PNFLETE
        End Get
        Set(ByVal Value As Decimal)
            _PNFLETE = Value
        End Set
    End Property
    Public Property PNVOLUMEN() As Decimal
        Get
            Return _PNVOLUMEN
        End Get
        Set(ByVal Value As Decimal)
            _PNVOLUMEN = Value
        End Set
    End Property

    Public Property PNPESO() As Decimal
        Get
            Return _PNPESO
        End Get
        Set(ByVal Value As Decimal)
            _PNPESO = Value
        End Set
    End Property

    Public Property PNCOD_TRANSPORTE() As Decimal
        Get
            Return _PNCOD_TRANSPORTE
        End Get
        Set(ByVal Value As Decimal)
            _PNCOD_TRANSPORTE = Value
        End Set
    End Property
    Public Property PSTRANSPORTE() As String
        Get
            Return _PSTRANSPORTE
        End Get
        Set(ByVal value As String)
            _PSTRANSPORTE = value
        End Set
    End Property
    '
    Public Property PNCOD_FORWARDER() As Decimal
        Get
            Return _PNCOD_FORWARDER
        End Get
        Set(ByVal value As Decimal)
            _PNCOD_FORWARDER = value
        End Set
    End Property

    Public Property PSFORWARDER() As String
        Get
            Return _PSFORWARDER
        End Get
        Set(ByVal value As String)
            _PSFORWARDER = value
        End Set
    End Property
    Public Property PSMERCADERIA() As String
        Get
            Return _PSMERCADERIA
        End Get
        Set(ByVal value As String)
            _PSMERCADERIA = value
        End Set
    End Property

    Public Property PSTIPO_CARGA() As String
        Get
            Return _PSTIPO_CARGA
        End Get
        Set(ByVal value As String)
            _PSTIPO_CARGA = value
        End Set
    End Property
    Public Property PSFECHA_ORDEN() As String
        Get
            Return _PSFECHA_ORDEN
        End Get
        Set(ByVal value As String)
            _PSFECHA_ORDEN = value
        End Set
    End Property

    Public Property PSTCMPCL() As String
        Get
            Return _PSTCMPCL
        End Get
        Set(ByVal value As String)
            _PSTCMPCL = value
        End Set
    End Property

    Public Property PSTMTVBJ() As String
        Get
            Return _PSTMTVBJ
        End Get
        Set(ByVal value As String)
            _PSTMTVBJ = value
        End Set
    End Property

    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


End Class
