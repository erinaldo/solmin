Public Class Rubro
    Private _NRRUBR As Double = 0
    Private _CSCDSP As String = ""
    Private _CRGVTA As String = ""
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _NOMRUB As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _SESTRG As String = ""

    Property NRRUBR() As Double
        Get
            Return _NRRUBR
        End Get
        Set(ByVal value As Double)
            _NRRUBR = value
        End Set
    End Property

    Property CSCDSP() As String
        Get
            Return _CSCDSP
        End Get
        Set(ByVal value As String)
            _CSCDSP = value
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

    Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Property NOMRUB() As String
        Get
            Return _NOMRUB
        End Get
        Set(ByVal value As String)
            _NOMRUB = value
        End Set
    End Property

    Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
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

    Public Property FCHCRT() As String
        Get
            Return _FCHCRT
        End Get
        Set(ByVal Value As String)
            _FCHCRT = Value
        End Set
    End Property

    Public Property HRACRT() As String
        Get
            Return _HRACRT
        End Get
        Set(ByVal Value As String)
            _HRACRT = Value
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

End Class
