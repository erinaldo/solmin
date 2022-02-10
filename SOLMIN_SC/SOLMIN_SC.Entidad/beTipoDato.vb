Public Class beTipoDato
    Private _PNNTPODT As Decimal = 0
    Private _PNNCODRG As Decimal = 0
    Private _PSTDSCRG As String = ""
    Private _PSSESTRG As String = ""
    Private _PNCCLNT As Integer = 0
    Private _PSTDSTPD As String = ""
    Private _PNQCNTN As Decimal = 0
    Public Property PNNTPODT() As Decimal
        Get
            Return _PNNTPODT
        End Get
        Set(ByVal value As Decimal)
            _PNNTPODT = value
        End Set
    End Property
    Public Property PNNCODRG() As Decimal
        Get
            Return _PNNCODRG
        End Get
        Set(ByVal value As Decimal)
            _PNNCODRG = value
        End Set
    End Property
    Public Property PSTDSCRG() As String
        Get
            Return _PSTDSCRG
        End Get
        Set(ByVal value As String)
            _PSTDSCRG = value
        End Set
    End Property
    Public Property PSTDSTPD() As String
        Get
            Return _PSTDSTPD
        End Get
        Set(ByVal value As String)
            _PSTDSTPD = value
        End Set
    End Property
    Public Property PSSESTRG() As String
        Get
            Return _PSSESTRG
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property
    Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property
    Property PNQCNTN() As Decimal
        Get
            Return _PNQCNTN
        End Get
        Set(ByVal value As Decimal)
            _PNQCNTN = value
        End Set
    End Property



End Class
