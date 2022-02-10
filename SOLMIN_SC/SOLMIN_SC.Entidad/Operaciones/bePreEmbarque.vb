Public Class bePreEmbarque
    Private _PNCCLNT As Decimal = 0
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PNNORSCI As Decimal = 0
    Private _PNNRPEMB As Decimal = 0
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSCULUSA As String = ""
    Private _PSNTRMNL As String = ""
    Private _PSSESTRG As String = ""
    Private _PNCAGNCR As Decimal = 0

    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PSCCMPN() As String
        Get
            Return (_PSCCMPN)
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Public Property PSCDVSN() As String
        Get
            Return (_PSCDVSN)
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property



    Public Property PNNORSCI() As Decimal
        Get
            Return (_PNNORSCI)
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property
    Public Property PNNRPEMB() As Decimal
        Get
            Return (_PNNRPEMB)
        End Get
        Set(ByVal value As Decimal)
            _PNNRPEMB = value
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
    Public Property PNCAGNCR() As Decimal
        Get
            Return (_PNCAGNCR)
        End Get
        Set(ByVal value As Decimal)
            _PNCAGNCR = value
        End Set
    End Property


End Class
