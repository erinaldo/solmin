

Public Class Grifo

#Region "Atributo"

    Private _CGRFO As Double = 0
    Private _TGRFO As String = ""
    Private _TAGRFO As String = ""
    Private _NRUCGR As Double = 0
    Private _CUBGEO As Double = 0
    Private _TLCLGR As String = ""
    Private _SESTRG As String = ""
    Private _FULTAC As Double = 0
    Private _HULTAC As Double = 0
    Private _CULUSA As String = ""
    Private _NTRMNL As String = ""
    Private _USRCRT As String = ""
    Private _FCHCRT As Double = 0
    Private _HRACRT As Double = 0
    Private _NTRMCR As String = ""

    Private _NCRRTR As Double = 0
    Private _FCMBUS As Double = 0
    Private _FCMBUS_S As String = ""
    Private _CTPCMB As String = ""
    Private _IPRCMS As Double = 0
    Private _IPRCMD As Double = 0
    Private _SESTVG As String = ""
    Private _CCMPN As String = ""
#End Region

#Region "Properties"
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Public Property CGRFO() As Double
        Get
            Return _CGRFO
        End Get
        Set(ByVal Value As Double)
            _CGRFO = Value
        End Set
    End Property

    Public Property TGRFO() As String
        Get
            Return _TGRFO
        End Get
        Set(ByVal Value As String)
            _TGRFO = Value
        End Set
    End Property

    Public Property TAGRFO() As String
        Get
            Return _TAGRFO
        End Get
        Set(ByVal Value As String)
            _TAGRFO = Value
        End Set
    End Property

    Public Property NRUCGR() As Double
        Get
            Return _NRUCGR
        End Get
        Set(ByVal Value As Double)
            _NRUCGR = Value
        End Set
    End Property

    Public Property TLCLGR() As String
        Get
            Return _TLCLGR
        End Get
        Set(ByVal value As String)
            _TLCLGR = value
        End Set
    End Property

    Public Property CUBGEO() As Double
        Get
            Return _CUBGEO
        End Get
        Set(ByVal Value As Double)
            _CUBGEO = Value
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

    Public Property USRCRT() As String
        Get
            Return _USRCRT
        End Get
        Set(ByVal Value As String)
            _USRCRT = Value
        End Set
    End Property

    Public Property FCHCRT() As Double
        Get
            Return _FCHCRT
        End Get
        Set(ByVal Value As Double)
            _FCHCRT = Value
        End Set
    End Property

    Public Property HRACRT() As Double
        Get
            Return _HRACRT
        End Get
        Set(ByVal Value As Double)
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

    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal Value As String)
            _CULUSA = Value
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

    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal Value As String)
            _NTRMNL = Value
        End Set
    End Property


    Public Property NCRRTR() As Double
        Get
            Return _NCRRTR
        End Get
        Set(ByVal Value As Double)
            _NCRRTR = Value
        End Set
    End Property

    Public Property FCMBUS() As Double
        Get
            Return _FCMBUS
        End Get
        Set(ByVal Value As Double)
            _FCMBUS = Value
        End Set
    End Property

    Public Property FCMBUS_S() As String
        Get
            Return _FCMBUS_S
        End Get
        Set(ByVal Value As String)
            _FCMBUS_S = Value
        End Set
    End Property

    Public Property CTPCMB() As String
        Get
            Return _CTPCMB
        End Get
        Set(ByVal value As String)
            _CTPCMB = value
        End Set
    End Property

    Public Property IPRCMS() As Double
        Get
            Return _IPRCMS
        End Get
        Set(ByVal Value As Double)
            _IPRCMS = Value
        End Set
    End Property

    Public Property IPRCMD() As Double
        Get
            Return _IPRCMD
        End Get
        Set(ByVal Value As Double)
            _IPRCMD = Value
        End Set
    End Property

    Public Property SESTVG() As String
        Get
            Return _SESTVG
        End Get
        Set(ByVal Value As String)
            _SESTVG = Value
        End Set
    End Property

#End Region

End Class

