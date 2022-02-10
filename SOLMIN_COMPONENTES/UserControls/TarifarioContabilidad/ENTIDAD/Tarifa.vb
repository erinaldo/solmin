Public Class Tarifa
    Private _NRTFSV As Double = 0
    Private _NRRNGO As Double = 0
    Private _CCMPN As String = ""
    Private _CDVSN As String = ""
    Private _CSRVNV As Double = 0
    Private _NRRUBR As Double = 0
    Private _CSCDSP As String = ""
    Private _CRGVTA As String = ""
    Private _CMNDA1 As Double = 0
    Private _NRSRRB As Double = 0
    Private _NRCTSL As Double = 0
    Private _CPLNDV As Double = 0
    Private _IVLSRV As Double = 0
    Private _FECINI As Double = 0
    Private _FECFIN As Double = 0
    Private _TOBS As String = ""
    Private _DESTAR As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _SESTRG As String = ""

    Public Property DESTAR() As String
        Get
            Return _DESTAR
        End Get
        Set(ByVal Value As String)
            _DESTAR = Value
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

    Public Property FECINI() As Double
        Get
            Return _FECINI
        End Get
        Set(ByVal Value As Double)
            _FECINI = Value
        End Set
    End Property

    Public Property FECFIN() As Double
        Get
            Return _FECFIN
        End Get
        Set(ByVal Value As Double)
            _FECFIN = Value
        End Set
    End Property

    Public Property IVLSRV() As Double
        Get
            Return _IVLSRV
        End Get
        Set(ByVal Value As Double)
            _IVLSRV = Value
        End Set
    End Property

    Public Property CPLNDV() As Double
        Get
            Return _CPLNDV
        End Get
        Set(ByVal Value As Double)
            _CPLNDV = Value
        End Set
    End Property

    Public Property NRCTSL() As Double
        Get
            Return _NRCTSL
        End Get
        Set(ByVal Value As Double)
            _NRCTSL = Value
        End Set
    End Property

    Public Property NRSRRB() As Double
        Get
            Return _NRSRRB
        End Get
        Set(ByVal Value As Double)
            _NRSRRB = Value
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

    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal Value As String)
            _CRGVTA = Value
        End Set
    End Property

    Public Property CSCDSP() As String
        Get
            Return _CSCDSP
        End Get
        Set(ByVal Value As String)
            _CSCDSP = Value
        End Set
    End Property

    Public Property NRRUBR() As Double
        Get
            Return _NRRUBR
        End Get
        Set(ByVal Value As Double)
            _NRRUBR = Value
        End Set
    End Property

    Public Property CSRVNV() As Double
        Get
            Return _CSRVNV
        End Get
        Set(ByVal Value As Double)
            _CSRVNV = Value
        End Set
    End Property

    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal Value As String)
            _CDVSN = Value
        End Set
    End Property

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal Value As String)
            _CCMPN = Value
        End Set
    End Property

    Public Property NRRNGO() As Double
        Get
            Return _NRRNGO
        End Get
        Set(ByVal Value As Double)
            _NRRNGO = Value
        End Set
    End Property

    Public Property NRTFSV() As Double
        Get
            Return _NRTFSV
        End Get
        Set(ByVal Value As Double)
            _NRTFSV = Value
        End Set
    End Property

End Class

