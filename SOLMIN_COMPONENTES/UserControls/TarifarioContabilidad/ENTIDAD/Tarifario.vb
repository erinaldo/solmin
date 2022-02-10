Public Class Tarifario
    Private _NRTARF As Double = 0
    Private _NRCTCL As Double = 0
    Private _CMNDA1 As Double = 0
    Private _TOBS As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _SESTRG As String = ""

    Public Property NRTARF() As Double
        Get
            Return _NRTARF
        End Get
        Set(ByVal Value As Double)
            _NRTARF = Value
        End Set
    End Property

    Public Property NRCTCL() As Double
        Get
            Return _NRCTCL
        End Get
        Set(ByVal Value As Double)
            _NRCTCL = Value
        End Set
    End Property

    Public Property CMNDA1() As Double
        Get
            Return _CMNDA1
        End Get
        Set(ByVal Value As Double)
            _CMNDA1 = Value
        End Set
    End Property

    Public Property TOBS() As String
        Get
            Return _TOBS
        End Get
        Set(ByVal Value As String)
            _TOBS = Value
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

End Class
