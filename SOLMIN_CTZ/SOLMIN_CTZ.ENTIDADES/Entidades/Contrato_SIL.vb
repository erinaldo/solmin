Public Class Contrato_SIL
    Private _NCTZCN As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CPLNDV As Double = 0
    Private _CCLNT As Double = 0
    Private _TRFSRC As String = ""
    Private _TCNCLC As String = ""
    Private _SESTCT As String = ""
    Private _FCTZCN As Double = 0
    Private _FVGNCT As Double = 0
    Private _SFRMFC As String = ""
    Private _CEJCT As Double = 0
    Private _PERFAC As String = ""
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0

    Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Property PERFAC() As String
        Get
            Return _PERFAC
        End Get
        Set(ByVal value As String)
            _PERFAC = value
        End Set
    End Property

    Property CEJCT() As Double
        Get
            Return _CEJCT
        End Get
        Set(ByVal value As Double)
            _CEJCT = value
        End Set
    End Property

    Property SFRMFC() As String
        Get
            Return _SFRMFC
        End Get
        Set(ByVal value As String)
            _SFRMFC = value
        End Set
    End Property

    Property FVGNCT() As Double
        Get
            Return _FVGNCT
        End Get
        Set(ByVal value As Double)
            _FVGNCT = value
        End Set
    End Property

    Property FCTZCN() As Double
        Get
            Return _FCTZCN
        End Get
        Set(ByVal value As Double)
            _FCTZCN = value
        End Set
    End Property

    Property SESTCT() As String
        Get
            Return _SESTCT
        End Get
        Set(ByVal value As String)
            _SESTCT = value
        End Set
    End Property

    Property TCNCLC() As String
        Get
            Return _TCNCLC
        End Get
        Set(ByVal value As String)
            _TCNCLC = value
        End Set
    End Property

    Property TRFSRC() As String
        Get
            Return _TRFSRC
        End Get
        Set(ByVal value As String)
            _TRFSRC = value
        End Set
    End Property

    Property CCLNT() As Double
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Double)
            _CCLNT = value
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

    Property CPLNDV() As Double
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Double)
            _CPLNDV = value
        End Set
    End Property

    Property NCTZCN() As Double
        Get
            Return _NCTZCN
        End Get
        Set(ByVal value As Double)
            _NCTZCN = value
        End Set
    End Property
End Class
