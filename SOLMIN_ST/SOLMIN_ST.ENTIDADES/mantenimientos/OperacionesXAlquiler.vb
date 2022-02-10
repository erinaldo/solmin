Public Class OperacionesXAlquiler
    Private _NRALQT As Decimal = 0
    Private _NCRRRT As Decimal = 0
    Private _NOPRCN As Decimal = 0
    Private _CCMPN As String = ""
    Private _CCNCST As Decimal = 0
    Private _NKMRTA As Decimal = 0
    'Private _CRUTA As Decimal = 0
    Private _SESTRG As String = ""
    Private _CUSCRT As String = ""
    Private _FCHCRT As Decimal = 0
    Private _HRACRT As Decimal = 0
    Private _NTRMCR As String = ""
    Private _CULUSA As String = ""
    Private _FULTAC As Decimal = 0
    Private _HULTAC As Decimal = 0
    Private _NTRMNL As String = ""
    Private _CCLNT As Decimal = 0
    Private _NRUCTR As String = ""
    Private _TCMTRT As String = ""
    Private _FINCOP_S As String = ""
    Private _NORSRT As Decimal = 0
    Private _CCLNT_S As String = ""
    Private _RUTA As String = ""
    Private _CLCLOR As Decimal = 0
    Private _CLCLDS As Decimal = 0
    Private _CLCLOR_S As String = ""
    Private _CLCLDS_S As String = ""
    Private _NPLCUN As String = ""
    Private _NPLCAC As String = ""
    Private _CBRCNT As String = ""
    Private _CBRCND As String = ""
    Private _SESTOP As String = ""

    Private _CDVSN As String = ""
    Private _TOBRES As String = ""


    Public Property NRALQT() As Decimal
        Get
            Return _NRALQT
        End Get
        Set(ByVal value As Decimal)
            _NRALQT = value
        End Set
    End Property

    Public Property NCRRRT() As Decimal
        Get
            Return _NCRRRT
        End Get
        Set(ByVal value As Decimal)
            _NCRRRT = value
        End Set
    End Property

    '_NOPRCN
    Public Property NOPRCN() As Decimal
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Decimal)
            _NOPRCN = value
        End Set
    End Property

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property


    Public Property CCNCST() As Decimal
        Get
            Return _CCNCST
        End Get
        Set(ByVal value As Decimal)
            _CCNCST = value
        End Set
    End Property

    Public Property NKMRTA() As Decimal
        Get
            Return _NKMRTA
        End Get
        Set(ByVal value As Decimal)
            _NKMRTA = value
        End Set
    End Property

    'Public Property CRUTA() As Decimal
    '    Get
    '        Return _CRUTA
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _CRUTA = value
    '    End Set
    'End Property

    Public Property SESTRG() As String
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
        Set(ByVal value As String)
            _CUSCRT = value
        End Set
    End Property

    Public Property FCHCRT() As Decimal
        Get
            Return _FCHCRT
        End Get
        Set(ByVal value As Decimal)
            _FCHCRT = value
        End Set
    End Property

    Public Property HRACRT() As Decimal
        Get
            Return _HRACRT
        End Get
        Set(ByVal value As Decimal)
            _HRACRT = value
        End Set
    End Property

    Public Property NTRMCR() As String
        Get
            Return _NTRMCR
        End Get
        Set(ByVal value As String)
            _NTRMCR = value
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

    Public Property FULTAC() As Decimal
        Get
            Return _FULTAC
        End Get
        Set(ByVal value As Decimal)
            _FULTAC = value
        End Set
    End Property

    Public Property HULTAC() As Decimal
        Get
            Return _HULTAC
        End Get
        Set(ByVal value As Decimal)
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

    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Public Property FINCOP_S() As String
        Get
            Return _FINCOP_S
        End Get
        Set(ByVal value As String)
            _FINCOP_S = value
        End Set
    End Property

    Public Property NORSRT() As Decimal
        Get
            Return _NORSRT
        End Get
        Set(ByVal value As Decimal)
            _NORSRT = value
        End Set
    End Property

    Public Property CCLNT_S() As String
        Get
            Return _CCLNT_S
        End Get
        Set(ByVal value As String)
            _CCLNT_S = value
        End Set
    End Property

    Public Property RUTA() As String
        Get
            Return _RUTA
        End Get
        Set(ByVal value As String)
            _RUTA = value
        End Set
    End Property

    Public Property CLCLOR() As Decimal
        Get
            Return _CLCLOR
        End Get
        Set(ByVal value As Decimal)
            _CLCLOR = value
        End Set
    End Property

    Public Property CLCLDS() As Decimal
        Get
            Return _CLCLDS
        End Get
        Set(ByVal value As Decimal)
            _CLCLDS = value
        End Set
    End Property

    Public Property CLCLOR_S() As String
        Get
            Return _CLCLOR_S
        End Get
        Set(ByVal value As String)
            _CLCLOR_S = value
        End Set
    End Property

    Public Property CLCLDS_S() As String
        Get
            Return _CLCLDS_S
        End Get
        Set(ByVal value As String)
            _CLCLDS_S = value
        End Set
    End Property

    Public Property NPLCUN() As String
        Get
            Return _NPLCUN
        End Get
        Set(ByVal value As String)
            _NPLCUN = value
        End Set
    End Property

    Public Property NPLCAC() As String
        Get
            Return _NPLCAC
        End Get
        Set(ByVal value As String)
            _NPLCAC = value
        End Set
    End Property

    Public Property CBRCNT() As String
        Get
            Return _CBRCNT
        End Get
        Set(ByVal value As String)
            _CBRCNT = value
        End Set
    End Property

    Public Property CBRCND() As String
        Get
            Return _CBRCND
        End Get
        Set(ByVal value As String)
            _CBRCND = value
        End Set
    End Property

    Public Property SESTOP() As String
        Get
            Return _SESTOP
        End Get
        Set(ByVal value As String)
            _SESTOP = value
        End Set
    End Property
    Public Property NRUCTR() As String
        Get
            Return _NRUCTR
        End Get
        Set(ByVal value As String)
            _NRUCTR = value
        End Set
    End Property

    Public Property TCMTRT() As String
        Get
            Return _TCMTRT
        End Get
        Set(ByVal value As String)
            _TCMTRT = value
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

    Public Property TOBRES() As String
        Get
            Return _TOBRES
        End Get
        Set(ByVal value As String)
            _TOBRES = value
        End Set
    End Property
End Class
