Public Class beCostoAgencia
    Private _PSIDUNICO As String = ""
    Private _PSVARCOSTO As String = ""
    Private _PBSELECCIONADO As Boolean = False
    Private _PBSELECCIONABLE As Boolean = False
    Private _PNCSRVRL As Decimal = 0
    Private _PSTCMTRF As String = ""
    Private _PNIMPORTE_TOTAL_DOL As Decimal = 0
    Private _PNIMPORTE_TOTAL_SOL As Decimal = 0
    Private _PNIMTPOC As Decimal = 0
    Private _PNTIPODOC As Decimal = 0
    Private _PNNUMDOC As Decimal = 0
    Private _PSTCMTPD As String = ""
    Private _PNIGV As Decimal = 0
    Private _PNIMPORTE_BASE_DOL As Decimal = 0
    Private _PNIMPORTE_BASE_SOL As Decimal = 0
    Private _PNIMPORTE_IGV_DOL As Decimal = 0
    Private _PNIMPORTE_IGV_SOL As Decimal = 0
    Public Property PSVARCOSTO() As String
        Get
            Return _PSVARCOSTO
        End Get
        Set(ByVal value As String)
            _PSVARCOSTO = value
        End Set
    End Property


    Public Property PNCSRVRL() As Decimal
        Get
            Return _PNCSRVRL
        End Get
        Set(ByVal value As Decimal)
            _PNCSRVRL = value
        End Set
    End Property
    Public Property PSTCMTRF() As String
        Get
            Return _PSTCMTRF
        End Get
        Set(ByVal value As String)
            _PSTCMTRF = value
        End Set
    End Property
    Public Property PNIMPORTE_TOTAL_DOL() As Decimal
        Get
            Return _PNIMPORTE_TOTAL_DOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_TOTAL_DOL = value
        End Set
    End Property

    Public Property PNIMPORTE_TOTAL_SOL() As Decimal
        Get
            Return _PNIMPORTE_TOTAL_SOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_TOTAL_SOL = value
        End Set
    End Property


    Public Property PNIMPORTE_BASE_DOL() As Decimal
        Get
            Return _PNIMPORTE_BASE_DOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_BASE_DOL = value
        End Set
    End Property

    Public Property PNIMPORTE_BASE_SOL() As Decimal
        Get
            Return _PNIMPORTE_BASE_SOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_BASE_SOL = value
        End Set
    End Property


    Public Property PBSELECCIONADO() As Boolean
        Get
            Return _PBSELECCIONADO
        End Get
        Set(ByVal value As Boolean)
            _PBSELECCIONADO = value
        End Set
    End Property


    Public Property PBSELECCIONABLE() As Boolean
        Get
            Return _PBSELECCIONABLE
        End Get
        Set(ByVal value As Boolean)
            _PBSELECCIONABLE = value
        End Set
    End Property

    Public Property PNIMTPOC() As Decimal
        Get
            Return _PNIMTPOC
        End Get
        Set(ByVal value As Decimal)
            _PNIMTPOC = value
        End Set
    End Property


    Public Property PNTIPODOC() As Decimal
        Get
            Return _PNTIPODOC
        End Get
        Set(ByVal value As Decimal)
            _PNTIPODOC = value
        End Set
    End Property

    Public Property PNNUMDOC() As Decimal
        Get
            Return _PNNUMDOC
        End Get
        Set(ByVal value As Decimal)
            _PNNUMDOC = value
        End Set
    End Property
    Public Property PSTCMTPD() As String
        Get
            Return _PSTCMTPD
        End Get
        Set(ByVal value As String)
            _PSTCMTPD = value
        End Set
    End Property

    Public Property PSIDUNICO() As String
        Get
            Return _PSIDUNICO
        End Get
        Set(ByVal value As String)
            _PSIDUNICO = value
        End Set
    End Property

    Public Property PNIGV() As Decimal
        Get
            Return _PNIGV
        End Get
        Set(ByVal value As Decimal)
            _PNIGV = value
        End Set
    End Property


    Public Property PNIMPORTE_IGV_DOL() As Decimal
        Get
            Return _PNIMPORTE_IGV_DOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_IGV_DOL = value
        End Set
    End Property

    Public Property PNIMPORTE_IGV_SOL() As Decimal
        Get
            Return _PNIMPORTE_IGV_SOL
        End Get
        Set(ByVal value As Decimal)
            _PNIMPORTE_IGV_SOL = value
        End Set
    End Property


End Class
