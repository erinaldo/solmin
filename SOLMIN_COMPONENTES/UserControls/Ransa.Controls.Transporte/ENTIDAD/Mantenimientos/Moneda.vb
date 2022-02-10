Public Class Moneda
    Private _CMNDA1 As Double = 0
    Private _FULTAC As String = ""
    Private _HULTAC As String = ""
    Private _TMNDA As String = 0
    Private _CMNDAD As Double = 0
    Private _TSGNMN As String = ""
    Private _TIPCAM As Double = 0
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
    Public Property CMNDA1() As Double
        Get
            Return _CMNDA1
        End Get
        Set(ByVal Value As Double)
            _CMNDA1 = Value
        End Set
    End Property

    Public Property FULTAC() As String
        Get
            Return _FULTAC
        End Get
        Set(ByVal Value As String)
            _FULTAC = Value
        End Set
    End Property

    Public Property HULTAC() As String
        Get
            Return _HULTAC
        End Get
        Set(ByVal Value As String)
            _HULTAC = Value
        End Set
    End Property

    Public Property TMNDA() As String
        Get
            Return _TMNDA
        End Get
        Set(ByVal Value As String)
            _TMNDA = Value
        End Set
    End Property

    Public Property CMNDAD() As Double
        Get
            Return _CMNDAD
        End Get
        Set(ByVal Value As Double)
            _CMNDAD = Value
        End Set
    End Property

    Public Property TSGNMN() As String
        Get
            Return _TSGNMN
        End Get
        Set(ByVal Value As String)
            _TSGNMN = Value
        End Set
    End Property

    Public Property TIPCAM() As Double
        Get
            Return _TIPCAM
        End Get
        Set(ByVal Value As Double)
            _TIPCAM = Value
        End Set
    End Property


#End Region
End Class
