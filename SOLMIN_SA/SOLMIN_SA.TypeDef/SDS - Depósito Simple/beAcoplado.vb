Public Class beAcoplado

    Inherits beBase(Of beAcoplado)
    Private _PNCTRSPT As Decimal
    Private _PSNPLCAC As String
    Private _PSTCLRUN As String
    Private _PNQPSTRA As Decimal
    Private _PNNEJSUN As Decimal
    Private _PNNCPCRU As Decimal
    Private _PSNSRCHU As String
    Private _PNFFBRUN As Decimal
    Private _PNQLNGAC As Decimal
    Private _PNQANCAC As Decimal
    Private _PNQALTAC As Decimal
    Private _PNQVLTTR As Decimal
    Private _PSSESTUN As String
    Private _PSSTPOUN As String
    Private _PNFPRXDS As Decimal
    Private _PSTOBSIN As String
    Private _PSSINPUN As String
    Private _PNFINPUN As Decimal
    Private _PNCTPCRA As Decimal
    Private _PNFULTAC As Decimal
    Private _PNHULTAC As Decimal
    Private _PSCULUSA As String
    Private _PSNTRMNL As String
    Private _PSCUSCRT As String
    Private _PNFCHCRT As Decimal
    Private _PNHRACRT As Decimal
    Private _PSNTRMCR As String
    Private _PSNPLUNR As String
    Private _PSNRGMT2 As String
    Private _PSTCNFG2 As String
    Private _PSTMRCVH As String
    Private _PSNCRHB2 As String
    Private _PNNORINS As Decimal
    Private _PNUPDATE_IDENT As Decimal

    Public Property PNCTRSPT() As Decimal
        Get
            Return (_PNCTRSPT)
        End Get
        Set(ByVal value As Decimal)
            _PNCTRSPT = value
        End Set
    End Property
    Public Property PSNPLCAC() As String
        Get
            Return (_PSNPLCAC)
        End Get
        Set(ByVal value As String)
            _PSNPLCAC = value
        End Set
    End Property
    Public Property PSTCLRUN() As String
        Get
            Return (_PSTCLRUN)
        End Get
        Set(ByVal value As String)
            _PSTCLRUN = value
        End Set
    End Property
    Public Property PNQPSTRA() As Decimal
        Get
            Return (_PNQPSTRA)
        End Get
        Set(ByVal value As Decimal)
            _PNQPSTRA = value
        End Set
    End Property
    Public Property PNNEJSUN() As Decimal
        Get
            Return (_PNNEJSUN)
        End Get
        Set(ByVal value As Decimal)
            _PNNEJSUN = value
        End Set
    End Property
    Public Property PNNCPCRU() As Decimal
        Get
            Return (_PNNCPCRU)
        End Get
        Set(ByVal value As Decimal)
            _PNNCPCRU = value
        End Set
    End Property
    Public Property PSNSRCHU() As String
        Get
            Return (_PSNSRCHU)
        End Get
        Set(ByVal value As String)
            _PSNSRCHU = value
        End Set
    End Property
    Public Property PNFFBRUN() As Decimal
        Get
            Return (_PNFFBRUN)
        End Get
        Set(ByVal value As Decimal)
            _PNFFBRUN = value
        End Set
    End Property
    Public Property PNQLNGAC() As Decimal
        Get
            Return (_PNQLNGAC)
        End Get
        Set(ByVal value As Decimal)
            _PNQLNGAC = value
        End Set
    End Property
    Public Property PNQANCAC() As Decimal
        Get
            Return (_PNQANCAC)
        End Get
        Set(ByVal value As Decimal)
            _PNQANCAC = value
        End Set
    End Property
    Public Property PNQALTAC() As Decimal
        Get
            Return (_PNQALTAC)
        End Get
        Set(ByVal value As Decimal)
            _PNQALTAC = value
        End Set
    End Property
    Public Property PNQVLTTR() As Decimal
        Get
            Return (_PNQVLTTR)
        End Get
        Set(ByVal value As Decimal)
            _PNQVLTTR = value
        End Set
    End Property
    Public Property PSSESTUN() As String
        Get
            Return (_PSSESTUN)
        End Get
        Set(ByVal value As String)
            _PSSESTUN = value
        End Set
    End Property
    Public Property PSSTPOUN() As String
        Get
            Return (_PSSTPOUN)
        End Get
        Set(ByVal value As String)
            _PSSTPOUN = value
        End Set
    End Property
    Public Property PNFPRXDS() As Decimal
        Get
            Return (_PNFPRXDS)
        End Get
        Set(ByVal value As Decimal)
            _PNFPRXDS = value
        End Set
    End Property
    Public Property PSTOBSIN() As String
        Get
            Return (_PSTOBSIN)
        End Get
        Set(ByVal value As String)
            _PSTOBSIN = value
        End Set
    End Property
    Public Property PSSINPUN() As String
        Get
            Return (_PSSINPUN)
        End Get
        Set(ByVal value As String)
            _PSSINPUN = value
        End Set
    End Property
    Public Property PNFINPUN() As Decimal
        Get
            Return (_PNFINPUN)
        End Get
        Set(ByVal value As Decimal)
            _PNFINPUN = value
        End Set
    End Property
    Public Property PNCTPCRA() As Decimal
        Get
            Return (_PNCTPCRA)
        End Get
        Set(ByVal value As Decimal)
            _PNCTPCRA = value
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
    Public Property PSCUSCRT() As String
        Get
            Return (_PSCUSCRT)
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
        End Set
    End Property
    Public Property PNFCHCRT() As Decimal
        Get
            Return (_PNFCHCRT)
        End Get
        Set(ByVal value As Decimal)
            _PNFCHCRT = value
        End Set
    End Property
    Public Property PNHRACRT() As Decimal
        Get
            Return (_PNHRACRT)
        End Get
        Set(ByVal value As Decimal)
            _PNHRACRT = value
        End Set
    End Property
    Public Property PSNTRMCR() As String
        Get
            Return (_PSNTRMCR)
        End Get
        Set(ByVal value As String)
            _PSNTRMCR = value
        End Set
    End Property
    Public Property PSNPLUNR() As String
        Get
            Return (_PSNPLUNR)
        End Get
        Set(ByVal value As String)
            _PSNPLUNR = value
        End Set
    End Property
    Public Property PSNRGMT2() As String
        Get
            Return (_PSNRGMT2)
        End Get
        Set(ByVal value As String)
            _PSNRGMT2 = value
        End Set
    End Property
    Public Property PSTCNFG2() As String
        Get
            Return (_PSTCNFG2)
        End Get
        Set(ByVal value As String)
            _PSTCNFG2 = value
        End Set
    End Property
    Public Property PSTMRCVH() As String
        Get
            Return (_PSTMRCVH)
        End Get
        Set(ByVal value As String)
            _PSTMRCVH = value
        End Set
    End Property
    Public Property PSNCRHB2() As String
        Get
            Return (_PSNCRHB2)
        End Get
        Set(ByVal value As String)
            _PSNCRHB2 = value
        End Set
    End Property
    Public Property PNNORINS() As Decimal
        Get
            Return (_PNNORINS)
        End Get
        Set(ByVal value As Decimal)
            _PNNORINS = value
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