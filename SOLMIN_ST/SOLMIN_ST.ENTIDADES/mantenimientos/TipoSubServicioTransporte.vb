Public Class TipoSubServicioTransporte

    Private _CTPOSR As String
    Private _CTPSBS As String
    Private _TCMSBS As String
    Private _TABSBS As String
    Private _FULTAC As Integer
    Private _HULTAC As Integer
    Private _CULUSA As String
    Private _NTRMNL As String
    Private _CUSCRT As String
    Private _FCHCRT As Integer
    Private _HRACRT As Integer
    Private _NTRMCR As String

    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property


    Public Property CTPOSR() As String
        Get
            Return _CTPOSR
        End Get
        Set(ByVal Value As String)
            _CTPOSR = Value
        End Set
    End Property

    Public Property CTPSBS() As String
        Get
            Return _CTPSBS
        End Get
        Set(ByVal Value As String)
            _CTPSBS = Value
        End Set
    End Property

    Public Property TCMSBS() As String
        Get
            Return _TCMSBS
        End Get
        Set(ByVal Value As String)
            _TCMSBS = Value
        End Set
    End Property

    Public Property TABSBS() As String
        Get
            Return _TABSBS
        End Get
        Set(ByVal Value As String)
            _TABSBS = Value
        End Set
    End Property

    Public Property FULTAC() As Integer
        Get
            Return _FULTAC
        End Get
        Set(ByVal Value As Integer)
            _FULTAC = Value
        End Set
    End Property

    Public Property HULTAC() As Integer
        Get
            Return _HULTAC
        End Get
        Set(ByVal Value As Integer)
            _HULTAC = Value
        End Set
    End Property

    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal Value As String)
            _CULUSA = Value
        End Set
    End Property

    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal Value As String)
            _NTRMNL = Value
        End Set
    End Property

    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal Value As String)
            _CUSCRT = Value
        End Set
    End Property

    Public Property FCHCRT() As Integer
        Get
            Return _FCHCRT
        End Get
        Set(ByVal Value As Integer)
            _FCHCRT = Value
        End Set
    End Property

    Public Property HRACRT() As Integer
        Get
            Return _HRACRT
        End Get
        Set(ByVal Value As Integer)
            _HRACRT = Value
        End Set
    End Property

    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal Value As String)
            _NTRMCR = Value
        End Set
    End Property



End Class
