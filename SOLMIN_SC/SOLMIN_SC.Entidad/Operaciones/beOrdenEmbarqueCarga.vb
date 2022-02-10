Public Class beOrdenEmbarqueCarga
    Private _PSCCMPN As String = ""
    Private _PSNORCML As String = ""
    Private _PSSBITOC As String = ""
    Private _PSCTPCRG As String = ""
    Private _PSCTPCRG_DESC As String = ""
    Private _PSNUMDCR As String = ""
    Private _PSCREFFW As String = ""
    Private _PSTDSCIT As String = ""
    Private _PSTIPBTO As String = ""

    Private _PNCCLNT1 As Decimal = 0
    Private _PNCCLNT As Decimal = 0
    Private _PNNRITEM As Decimal = 0
    Private _PNNRPEMB As Decimal = 0
    Private _PNNSEQIN As Decimal = 0
    Private _PNQPSOMR As Decimal = 0
    Private _PNNCRRIN As Decimal = 0
    Private _PNQMTLRG As Decimal = 0
    Private _PNQMTANC As Decimal = 0
    Private _PNQMTALT As Decimal = 0
    Private _PNQVOLMR As Decimal = 0
    Private _PNPSOVOL As Decimal = 0
    Private _PNQSEDNA As Decimal = 0

    Private _PBFLGCHK As Boolean = False
    Private _PNNORSCI As Decimal = 0
    Private _PNQCTPQT As Decimal = 0
    Private _PNCPLNDV As Decimal = 0
    Private _PNQRLCSC As Decimal = 0
    Private _PSNTRMNL As String = ""
    Private _PSNGRPRV As String = ""

    Private _PNNCRRDT As Decimal = 0
    Private _PNQTPCM2 As Decimal = 0
    Private _PSTUNDIT As String = ""
    Private _PNCMNDA1 As Decimal = 0
    Private _PNIVUNIT As Decimal = 0
    Private _PNCPRVCL As Decimal = 0
    Public Property PNNCRRDT() As Decimal
        Get
            Return _PNNCRRDT
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRDT = value
        End Set
    End Property
    Public Property PNCCLNT1() As Decimal
        Get
            Return _PNCCLNT1
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT1 = value
        End Set
    End Property

    Public Property PNQRLCSC() As Decimal
        Get
            Return _PNQRLCSC
        End Get
        Set(ByVal value As Decimal)
            _PNQRLCSC = value
        End Set
    End Property

    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property
    Public Property PNQCTPQT() As Decimal
        Get
            Return _PNQCTPQT
        End Get
        Set(ByVal value As Decimal)
            _PNQCTPQT = value
        End Set
    End Property


    Public Property PBFLGCHK() As Boolean
        Get
            Return _PBFLGCHK
        End Get
        Set(ByVal value As Boolean)
            _PBFLGCHK = value
        End Set
    End Property

    Public Property PNQSEDNA() As Decimal
        Get
            Return _PNQSEDNA
        End Get
        Set(ByVal value As Decimal)
            _PNQSEDNA = value
        End Set
    End Property
    Public Property PNPSOVOL() As Decimal
        Get
            Return _PNPSOVOL
        End Get
        Set(ByVal value As Decimal)
            _PNPSOVOL = value
        End Set
    End Property
    Public Property PNQVOLMR() As Decimal
        Get
            Return _PNQVOLMR
        End Get
        Set(ByVal value As Decimal)
            _PNQVOLMR = value
        End Set
    End Property
    Public Property PNQMTALT() As Decimal
        Get
            Return _PNQMTALT
        End Get
        Set(ByVal value As Decimal)
            _PNQMTALT = value
        End Set
    End Property
    Public Property PNQMTANC() As Decimal
        Get
            Return _PNQMTANC
        End Get
        Set(ByVal value As Decimal)
            _PNQMTANC = value
        End Set
    End Property
    Public Property PNQMTLRG() As Decimal
        Get
            Return _PNQMTLRG
        End Get
        Set(ByVal value As Decimal)
            _PNQMTLRG = value
        End Set
    End Property
    Public Property PNNCRRIN() As Decimal
        Get
            Return _PNNCRRIN
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRIN = value
        End Set
    End Property
    Public Property PNQPSOMR() As Decimal
        Get
            Return _PNQPSOMR
        End Get
        Set(ByVal value As Decimal)
            _PNQPSOMR = value
        End Set
    End Property
    Public Property PNNSEQIN() As Decimal
        Get
            Return _PNNSEQIN
        End Get
        Set(ByVal value As Decimal)
            _PNNSEQIN = value
        End Set
    End Property
    Public Property PNNRPEMB() As Decimal
        Get
            Return _PNNRPEMB
        End Get
        Set(ByVal value As Decimal)
            _PNNRPEMB = value
        End Set
    End Property
    Public Property PNNRITEM() As Decimal
        Get
            Return _PNNRITEM
        End Get
        Set(ByVal value As Decimal)
            _PNNRITEM = value
        End Set
    End Property
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PSTIPBTO() As String
        Get
            Return _PSTIPBTO
        End Get
        Set(ByVal value As String)
            _PSTIPBTO = value
        End Set
    End Property
    Public Property PSTDSCIT() As String
        Get
            Return _PSTDSCIT
        End Get
        Set(ByVal value As String)
            _PSTDSCIT = value
        End Set
    End Property
    Public Property PSCREFFW() As String
        Get
            Return _PSCREFFW
        End Get
        Set(ByVal value As String)
            _PSCREFFW = value
        End Set
    End Property
    Public Property PSNUMDCR() As String
        Get
            Return _PSNUMDCR
        End Get
        Set(ByVal value As String)
            _PSNUMDCR = value
        End Set
    End Property
    Public Property PSCTPCRG() As String
        Get
            Return _PSCTPCRG
        End Get
        Set(ByVal value As String)
            _PSCTPCRG = value
        End Set
    End Property

    Public Property PSCTPCRG_DESC() As String
        Get
            Return _PSCTPCRG_DESC
        End Get
        Set(ByVal value As String)
            _PSCTPCRG_DESC = value
        End Set
    End Property


    Public Property PSSBITOC() As String
        Get
            Return _PSSBITOC
        End Get
        Set(ByVal value As String)
            _PSSBITOC = value
        End Set
    End Property
    Public Property PSNORCML() As String
        Get
            Return _PSNORCML
        End Get
        Set(ByVal value As String)
            _PSNORCML = value
        End Set
    End Property

    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    Public Property PSNTRMNL() As String
        Get
            Return _PSNTRMNL
        End Get
        Set(ByVal value As String)
            _PSNTRMNL = value
        End Set
    End Property

    Public Property PSNGRPRV() As String
        Get
            Return _PSNGRPRV
        End Get
        Set(ByVal value As String)
            _PSNGRPRV = value
        End Set
    End Property

    Public Property PNQTPCM2() As Decimal
        Get
            Return _PNQTPCM2
        End Get
        Set(ByVal value As Decimal)
            _PNQTPCM2 = value
        End Set
    End Property

    Public Property PSTUNDIT() As String
        Get
            Return _PSTUNDIT
        End Get
        Set(ByVal value As String)
            _PSTUNDIT = value
        End Set
    End Property

    Public Property PNCMNDA1() As Decimal
        Get
            Return _PNCMNDA1
        End Get
        Set(ByVal value As Decimal)
            _PNCMNDA1 = value
        End Set
    End Property
    Public Property PNIVUNIT() As Decimal
        Get
            Return _PNIVUNIT
        End Get
        Set(ByVal value As Decimal)
            _PNIVUNIT = value
        End Set
    End Property
    Public Property PNCPRVCL() As Decimal
        Get
            Return _PNCPRVCL
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property

End Class
