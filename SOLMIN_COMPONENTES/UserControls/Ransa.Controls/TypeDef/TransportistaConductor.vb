Public Class TransportistaConductor
    Inherits Chofer

    Private _NRUCTR As String = ""
    Private _CBRCNT As String = ""
    Private _NPLCUN As String = ""
    Private _FECINI As String = "0"
    Private _FECFIN As String = "0"
    Private _TOBS As String = ""
    Private _SESTCH As String = ""
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _NTRMNL As String = ""
    Private _POS_RUC_ANTERIOR As String = ""
    Private _FLAG_SKIPCHECKS As String = ""


    Private _CDVSN As String
    Private _CPLNDV As Double = 0

    Public Overloads Property CBRCNT() As String
        Get
            Return _CBRCNT
        End Get
        Set(ByVal Value As String)
            _CBRCNT = Value
        End Set
    End Property


    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Public Property CPLNDV() As Double
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Double)
            _CPLNDV = value
        End Set
    End Property



    Public Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
        Set(ByVal Value As String)
            _NRUCTR = Value
        End Set
    End Property

    Public Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
        Set(ByVal Value As String)
            _NPLCUN = Value
        End Set
    End Property

    Public Property FECINI() As String
        Get
            Return _FECINI
        End Get
        Set(ByVal value As String)
            _FECINI = value
        End Set
    End Property

    Public Property FECFIN() As String
        Get
            Return _FECFIN
        End Get
        Set(ByVal value As String)
            _FECFIN = value
        End Set
    End Property

    Public Overloads Property SESTCH() As String
        Get
            Return _SESTCH
        End Get
        Set(ByVal value As String)
            _SESTCH = value
        End Set
    End Property

    Public Overloads Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Public Overloads Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal Value As String)
            _CUSCRT = Value
        End Set
    End Property

    Public Overloads Property FCHCRT() As Double
        Get
            Return _FCHCRT
        End Get
        Set(ByVal Value As Double)
            _FCHCRT = Value
        End Set
    End Property

    Public Overloads Property HRACRT() As Double
        Get
            Return _HRACRT
        End Get
        Set(ByVal Value As Double)
            _HRACRT = Value
        End Set
    End Property

    Public Overloads Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal Value As String)
            _NTRMCR = Value
        End Set
    End Property

    Public Overloads Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal Value As String)
            _CULUSA = Value
        End Set
    End Property

    Public Overloads Property FULTAC() As Double
        Get
            Return _FULTAC
        End Get
        Set(ByVal Value As Double)
            _FULTAC = Value
        End Set
    End Property

    Public Overloads Property HULTAC() As Double
        Get
            Return _HULTAC
        End Get
        Set(ByVal Value As Double)
            _HULTAC = Value
        End Set
    End Property

    Public Overloads Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal Value As String)
            _NTRMNL = Value
        End Set
    End Property

    Public Property POS_RUC_ANTERIOR() As String
        Get
            Return _POS_RUC_ANTERIOR
        End Get
        Set(ByVal value As String)
            _POS_RUC_ANTERIOR = value
        End Set
    End Property

    Public Property FLAG_SKIPCHECKS() As String
        Get
            Return _FLAG_SKIPCHECKS
        End Get
        Set(ByVal value As String)
            _FLAG_SKIPCHECKS = value
        End Set
    End Property

End Class
