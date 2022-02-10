Public Class SegEnvioRequerimiento
    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _NUMREQT As Decimal = 0D
    Public Property NUMREQT() As Decimal
        Get
            Return _NUMREQT
        End Get
        Set(ByVal value As Decimal)
            _NUMREQT = value
        End Set
    End Property

    Private _NCRRSG As Decimal = 0D
    Public Property NCRRSG() As Decimal
        Get
            Return _NCRRSG
        End Get
        Set(ByVal value As Decimal)
            _NCRRSG = value
        End Set
    End Property

    Private _SESREQT As String = ""
    Public Property SESREQT() As String
        Get
            Return _SESREQT
        End Get
        Set(ByVal value As String)
            _SESREQT = value
        End Set
    End Property

    Private _FDSGDC As Decimal = 0D
    Public Property FDSGDC() As Decimal
        Get
            Return _FDSGDC
        End Get
        Set(ByVal value As Decimal)
            _FDSGDC = value
        End Set
    End Property

    Private _FDSGDC_S As String = ""
    Public Property FDSGDC_S() As String
        Get
            Return _FDSGDC_S
        End Get
        Set(ByVal value As String)
            _FDSGDC_S = value
        End Set
    End Property

    Private _HDSGDC As Decimal = 0D
    Public Property HDSGDC() As Decimal
        Get
            Return _HDSGDC
        End Get
        Set(ByVal value As Decimal)
            _HDSGDC = value
        End Set
    End Property

    Private _HDSGDC_S As String = 0D
    Public Property HDSGDC_S() As String
        Get
            Return _HDSGDC_S
        End Get
        Set(ByVal value As String)
            _HDSGDC_S = value
        End Set
    End Property

    Private _URSPDC As String = ""
    Public Property URSPDC() As String
        Get
            Return _URSPDC
        End Get
        Set(ByVal value As String)
            _URSPDC = value
        End Set
    End Property

    Private _EMAIL As String = ""
    Public Property EMAIL() As String
        Get
            Return _EMAIL
        End Get
        Set(ByVal value As String)
            _EMAIL = value
        End Set
    End Property

    Private _CUERPONOTIF As String = ""
    Public Property CUERPONOTIF() As String
        Get
            Return _CUERPONOTIF
        End Get
        Set(ByVal value As String)
            _CUERPONOTIF = value
        End Set
    End Property

    Private _TOBSSG As String = ""
    Public Property TOBSSG() As String
        Get
            Return _TOBSSG
        End Get
        Set(ByVal value As String)
            _TOBSSG = value
        End Set
    End Property

    Private _SUBJECT As String = ""
    Public Property SUBJECT() As String
        Get
            Return _SUBJECT
        End Get
        Set(ByVal value As String)
            _SUBJECT = value
        End Set
    End Property

    Private _SESTRG As String = ""
    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Private _CUSCRT As String = ""
    Public Property CUSCRT() As String
        Get
            Return _CUSCRT
        End Get
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property

    Private _FCHCRT As String = ""
    Public Property FCHCRT() As String
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As String)
            _FCHCRT = value
        End Set
    End Property

    Private _HRACRT As String = ""
    Public Property HRACRT() As String
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As String)
            _HRACRT = value
        End Set
    End Property

    Private _NTRMCR As String = ""
    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
        End Set
    End Property

    Private _CULUSA As String = ""
    Public Property CULUSA() As String
        Get
            Return _CULUSA
        End Get
        Set(ByVal value As String)
            _CULUSA = value
        End Set
    End Property

    Private _FULTAC As Decimal = 0
    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property

    Private _HULTAC As Decimal = 0
    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
            _HULTAC = value
        End Set
    End Property

    Private _NTRMNL As String = ""
    Public Property NTRMNL() As String
        Get
            Return _NTRMNL
        End Get
        Set(ByVal value As String)
            _NTRMNL = value
        End Set
    End Property
End Class
