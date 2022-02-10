Public Class beUnidadVehicular

    Inherits beBase

    Private _PNCTRSP As Decimal
    Private _PSNPLCCM As String
    Private _PNPTRCM As Decimal
    Private _PNNANOCM As Decimal
    Private _PSTMRCCM As String
    Private _PSNMTRCM As String
    Private _PSSESTCM As String
    Private _PSNROPLA As String
    Private _PSNBRVC1 As String
    Private _PSNPLCAC As String
    Private _PNNTRNLL As Decimal
    Private _PNFASGTR As Decimal
    Private _PNHASGTR As Decimal
    Private _PSCULUSA As String
    Private _PNHULTAC As Decimal
    Private _PNFULTAC As Decimal
    Private _PNNTRMNL As String
    Private _PNSESTRG As String
    Private _PNUPID As Decimal


    Public Property PNCTRSP() As Decimal
        Get
            Return _PNCTRSP
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSP = value
        End Set
    End Property
    Public Property PSNPLCCM() As String
        Get
            Return (_PSNPLCCM)
        End Get
        Set(ByVal value As String)
            _PSNPLCCM = value
        End Set
    End Property
    Public Property PNPTRCM() As Decimal
        Get
            Return (_PNPTRCM)
        End Get
        Set(ByVal value As Decimal)
            _PNPTRCM = value
        End Set
    End Property
    Public Property PNNANOCM() As Decimal
        Get
            Return (_PNNANOCM)
        End Get
        Set(ByVal value As Decimal)
            _PNNANOCM = value
        End Set
    End Property
    Public Property PSTMRCCM() As String
        Get
            Return (_PSTMRCCM)
        End Get
        Set(ByVal value As String)
            _PSTMRCCM = value
        End Set
    End Property
    Public Property PSNMTRCM() As String
        Get
            Return (_PSNMTRCM)
        End Get
        Set(ByVal value As String)
            _PSNMTRCM = value
        End Set
    End Property
    Public Property PSSESTCM() As String
        Get
            Return (_PSSESTCM)
        End Get
        Set(ByVal value As String)
            _PSSESTCM = value
        End Set
    End Property
    Public Property PSNROPLA() As String
        Get
            Return _PSNROPLA
        End Get
        Set(ByVal value As String)
            _PSNROPLA = value
        End Set
    End Property
    Public Property PSNBRVC1() As String
        Get
            Return _PSNBRVC1
        End Get
        Set(ByVal value As String)
            _PSNBRVC1 = value
        End Set
    End Property
    Public Property PSNPLCAC() As String
        Get
            Return _PSNPLCAC
        End Get
        Set(ByVal value As String)
            _PSNPLCAC = value
        End Set
    End Property
    Public Property PNNTRNLL() As Decimal
        Get
            Return _PNNTRNLL
        End Get
        Set(ByVal value As Decimal)
            _PNNTRNLL = value
        End Set
    End Property
    Public Property PNFASGTR() As Decimal
        Get
            Return _PNFASGTR
        End Get
        Set(ByVal value As Decimal)
            _PNFASGTR = value
        End Set
    End Property
    Public Property PNHASGTR() As Decimal
        Get
            Return _PNHASGTR
        End Get
        Set(ByVal value As Decimal)
            _PNHASGTR = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            Return _PSCULUSA
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return _PNHULTAC
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
        End Set
    End Property
    Public Property PNFULTAC() As Decimal
        Get
            Return _PNFULTAC
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property
    Public Property PNNTRMNL() As String
        Get
            Return _PNNTRMNL
        End Get
        Set(ByVal value As String)
            _PNNTRMNL = value
        End Set
    End Property
    Public Property PNSESTRG() As String
        Get
            Return _PNSESTRG
        End Get
        Set(ByVal value As String)
            _PNSESTRG = value
        End Set
    End Property
    Public Property PNUPID() As Decimal
        Get
            Return _PNUPID
        End Get
        Set(ByVal value As Decimal)
            _PNUPID = value
        End Set
    End Property

End Class
Public Class beCamionFiltro
    Public CTRSPSTR As String = ""
    Public PAGESIZE As Int32 = 0
    Public PAGENUMBER As Int32 = 0
    Public PAGECOUNT As Int32 = 0
    Public Sub pclar()
        CTRSPSTR = ""
        PAGESIZE = 0
        PAGENUMBER = 0
        PAGECOUNT = 0
    End Sub
End Class