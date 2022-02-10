Public Class CategoriaChofer
    Private _SESTRG As String = ""
    Private _SCATEG As String = ""
    Private _TCATEG As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _CULUSA As String = ""
    Private _NTRMNL As String = ""
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
    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal Value As String)
            _SESTRG = Value
        End Set
    End Property

    Public Property SCATEG() As String
        Get
            Return _SCATEG
        End Get
        Set(ByVal Value As String)
            _SCATEG = Value
        End Set
    End Property

    Public Property TCATEG() As String
        Get
            Return _TCATEG
        End Get
        Set(ByVal Value As String)
            _TCATEG = Value
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

#End Region
End Class
