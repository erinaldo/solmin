
Public Class beKardex

    Private _PSCTPALM As String
    Private _PSTALMC As String
    Private _PSCALMC As String
    Private _PSCZNALM As String
    Private _PNNORDSR As Decimal
    Private _PSCUNPS7 As String
    Private _PSCUNCN7 As String
    Private _PNFULTIN As Decimal
    Private _PNFULTSL As Decimal
    Private _PNFPRCS As Decimal
    Private _PSTOBSR As String
    Private _PSSTPUN1 As String
    Private _PNQSLMC2 As Decimal
    Private _PNQSLMP2 As Decimal
    Private _PNQINMC1 As Decimal
    Private _PNQINMP1 As Decimal
    Private _PNQDSMC1 As Decimal
    Private _PNQDSMP1 As Decimal
    Private _PNQWRMC2 As Decimal
    Private _PNQWRMP2 As Decimal
    Private _PNQMRMC2 As Decimal
    Private _PNQMRMP2 As Decimal
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSNTRMNL As String
    Private _PSSESTRG As String
    Private _PNUPDATE_IDENT As Decimal


    Public Property PSCTPALM() As String
        Get
            Return (_PSCTPALM)
        End Get
        Set(ByVal value As String)
            _PSCTPALM = value
        End Set
    End Property

    Public Property PSTALMC() As String
        Get
            Return (_PSTALMC)
        End Get
        Set(ByVal value As String)
            _PSTALMC = value
        End Set
    End Property



    Private _PSTCMPAL As String
    Public Property PSTCMPAL() As String
        Get
            Return _PSTCMPAL
        End Get
        Set(ByVal value As String)
            _PSTCMPAL = value
        End Set
    End Property

    Public Property PSCALMC() As String
        Get
            Return (_PSCALMC)
        End Get
        Set(ByVal value As String)
            _PSCALMC = value
        End Set
    End Property
    Public Property PSCZNALM() As String
        Get
            Return (_PSCZNALM)
        End Get
        Set(ByVal value As String)
            _PSCZNALM = value
        End Set
    End Property

    Private _PSTCMZNA As String
    Public Property PSTCMZNA() As String
        Get
            Return _PSTCMZNA
        End Get
        Set(ByVal value As String)
            _PSTCMZNA = value
        End Set
    End Property

    Public Property PNNORDSR() As Decimal
        Get
            Return (_PNNORDSR)
        End Get
        Set(ByVal value As Decimal)
            _PNNORDSR = value
        End Set
    End Property
    Public Property PSCUNPS7() As String
        Get
            Return (_PSCUNPS7)
        End Get
        Set(ByVal value As String)
            _PSCUNPS7 = value
        End Set
    End Property
    Public Property PSCUNCN7() As String
        Get
            Return (_PSCUNCN7)
        End Get
        Set(ByVal value As String)
            _PSCUNCN7 = value
        End Set
    End Property
    Public Property PNFULTIN() As Decimal
        Get
            Return (_PNFULTIN)
        End Get
        Set(ByVal value As Decimal)
            _PNFULTIN = value
        End Set
    End Property
    Public Property PNFULTSL() As Decimal
        Get
            Return (_PNFULTSL)
        End Get
        Set(ByVal value As Decimal)
            _PNFULTSL = value
        End Set
    End Property
    Public Property PNFPRCS() As Decimal
        Get
            Return (_PNFPRCS)
        End Get
        Set(ByVal value As Decimal)
            _PNFPRCS = value
        End Set
    End Property
    Public Property PSTOBSR() As String
        Get
            Return (_PSTOBSR)
        End Get
        Set(ByVal value As String)
            _PSTOBSR = value
        End Set
    End Property
    Public Property PSSTPUN1() As String
        Get
            Return (_PSSTPUN1)
        End Get
        Set(ByVal value As String)
            _PSSTPUN1 = value
        End Set
    End Property
    Public Property PNQSLMC2() As Decimal
        Get
            Return (_PNQSLMC2)
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMC2 = value
        End Set
    End Property
    Public Property PNQSLMP2() As Decimal
        Get
            Return (_PNQSLMP2)
        End Get
        Set(ByVal value As Decimal)
            _PNQSLMP2 = value
        End Set
    End Property
    Public Property PNQINMC1() As Decimal
        Get
            Return (_PNQINMC1)
        End Get
        Set(ByVal value As Decimal)
            _PNQINMC1 = value
        End Set
    End Property
    Public Property PNQINMP1() As Decimal
        Get
            Return (_PNQINMP1)
        End Get
        Set(ByVal value As Decimal)
            _PNQINMP1 = value
        End Set
    End Property
    Public Property PNQDSMC1() As Decimal
        Get
            Return (_PNQDSMC1)
        End Get
        Set(ByVal value As Decimal)
            _PNQDSMC1 = value
        End Set
    End Property
    Public Property PNQDSMP1() As Decimal
        Get
            Return (_PNQDSMP1)
        End Get
        Set(ByVal value As Decimal)
            _PNQDSMP1 = value
        End Set
    End Property
    Public Property PNQWRMC2() As Decimal
        Get
            Return (_PNQWRMC2)
        End Get
        Set(ByVal value As Decimal)
            _PNQWRMC2 = value
        End Set
    End Property
    Public Property PNQWRMP2() As Decimal
        Get
            Return (_PNQWRMP2)
        End Get
        Set(ByVal value As Decimal)
            _PNQWRMP2 = value
        End Set
    End Property
    Public Property PNQMRMC2() As Decimal
        Get
            Return (_PNQMRMC2)
        End Get
        Set(ByVal value As Decimal)
            _PNQMRMC2 = value
        End Set
    End Property
    Public Property PNQMRMP2() As Decimal
        Get
            Return (_PNQMRMP2)
        End Get
        Set(ByVal value As Decimal)
            _PNQMRMP2 = value
        End Set
    End Property
    Public Property PNFULTAC() As Decimal
        Get
            Return (_PNFULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNFULTAC = value
        End Set
    End Property
    Public Property PNHULTAC() As Decimal
        Get
            Return (_PNHULTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNHULTAC = value
        End Set
    End Property
    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
        End Set
    End Property
    Public Property PSNTRMNL() As String
        Get
            Return (_PSNTRMNL)
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property
    Public Property PSSESTRG() As String
        Get
            Return (_PSSESTRG)
        End Get
        Set(ByVal value As String)
            _PSSESTRG = value
        End Set
    End Property
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property
End Class
