Public Class MedioTransporte

    Private _CTPMDT As Double
    Private _TTPMDT As String
    Private _CULUSA As String
    Private _FULTAC As Double
    Private _HULTAC As Double
    Private _NTRMNL As String
    Private _SESTRG As String
    Private _QPRCHF As Double
    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Public Property CTPMDT() As Double
        Get
            Return _CTPMDT
        End Get
        Set(ByVal value As Double)
            _CTPMDT = value
        End Set
    End Property
    Public Property TTPMDT() As String
        Get
            Return _TTPMDT
        End Get
        Set(ByVal value As String)
            _TTPMDT = value
        End Set
    End Property
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property
    Public Property FULTAC() As Double
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Double)
            _FULTAC = value
        End Set
    End Property
    Public Property HULTAC() As Double
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Double)
            _HULTAC = value
        End Set
    End Property
    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property
    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property
    Public Property QPRCHF() As Double
        Get
            Return _QPRCHF
        End Get
        Set(ByVal value As Double)
            _QPRCHF = value
        End Set
    End Property

End Class
