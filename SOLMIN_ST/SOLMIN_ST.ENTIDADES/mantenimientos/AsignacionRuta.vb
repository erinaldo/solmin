Public Class AsignacionRuta

    Private _CTPMDT As Double
    Private _CLCLOR As Double
    Private _CLCLDS As Double
    Private _IRTAVC As Double
    Private _FVGAVC As String
    Private _QDSTKM As Double
    Private _FULTAC As Double
    Private _HULTAC As Double
    Private _CULUSA As String
    Private _NTRMNL As String
    Private _SESTRG As String
    Private _ORIGEN As String
    Private _DESTINO As String
    Private _TTPMDT As String
    Private _IGSTVJ As Double
    Private _CCMPN As String = ""

   
#Region "Properties"
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Public Property IGSTVJ() As Double
        Get
            Return _IGSTVJ
        End Get
        Set(ByVal value As Double)
            _IGSTVJ = value
        End Set
    End Property


    Public Property CTPMDT() As Double
        Get
            Return _CTPMDT
        End Get
        Set(ByVal Value As Double)
            _CTPMDT = Value
        End Set
    End Property

    Public Property TTPMDT() As String
        Get
            Return _TTPMDT
        End Get
        Set(ByVal Value As String)
            _TTPMDT = Value
        End Set
    End Property

    Public Property CLCLOR() As Double
        Get
            Return _CLCLOR
        End Get
        Set(ByVal Value As Double)
            _CLCLOR = Value
        End Set
    End Property

    Public Property CLCLDS() As Double
        Get
            Return _CLCLDS
        End Get
        Set(ByVal Value As Double)
            _CLCLDS = Value
        End Set
    End Property

    Public Property IRTAVC() As Double
        Get
            Return _IRTAVC
        End Get
        Set(ByVal Value As Double)
            _IRTAVC = Value
        End Set
    End Property

    Public Property FVGAVC() As String
        Get
            Return _FVGAVC
        End Get
        Set(ByVal Value As String)
            _FVGAVC = Value
        End Set
    End Property

    Public Property QDSTKM() As Double
        Get
            Return _QDSTKM
        End Get
        Set(ByVal Value As Double)
            _QDSTKM = Value
        End Set
    End Property

    Public Property FULTAC() As Double
        Get
            Return _FULTAC
        End Get
        Set(ByVal Value As Double)
            _FULTAC = Value
        End Set
    End Property

    Public Property HULTAC() As Double
        Get
            Return _HULTAC
        End Get
        Set(ByVal Value As Double)
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

    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal Value As String)
            _SESTRG = Value
        End Set
    End Property
    Public Property ORIGEN() As String
        Get
            Return _ORIGEN
        End Get
        Set(ByVal Value As String)
            _ORIGEN = Value
        End Set
    End Property

    Public Property DESTINO() As String
        Get
            Return _DESTINO
        End Get
        Set(ByVal Value As String)
            _DESTINO = Value
        End Set
    End Property
#End Region
End Class