Public Class bePlantaClienteProveedor
    Inherits beBase(Of bePlantaClienteProveedor)

    Private _PNCPRVCL As Decimal = 0
    Private _PNCPLCLP As Decimal = 0
    Private _PSTCMPCP As String = ""
    Private _PSTDRPCP As String = ""
    Private _PSNRCLED As String = ""
    Private _PSTDRDST As String = ""
    Private _PSMAILDS As String = ""
    Private _PSCRUTAT As String = ""
    Private _PNNCRRRT As Decimal = 0
    Private _PSCZNAVN As String = ""
    Private _PSCVNDRC As String = ""
    Private _PSCCLTTM As String = ""
    Private _PSCUSCRT As String = ""
    Private _PNFCHCRT As Decimal = 0
    Private _PNHRACRT As Decimal = 0
    Private _PSCULUSA As String = ""
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSSESTRG As String = ""
    Private _PNUPDATE_IDENT As Decimal = 0
    Private _CUBGE2 As Decimal = 0
    Private _UBIGEO As String = ""  '1

    Private _DirCompleta As String = ""
    Public Property PSDirCompleta() As String
        Get
            Return _DirCompleta
        End Get
        Set(ByVal value As String)
            _DirCompleta = value
        End Set
    End Property


    Public Property PNCPRVCL() As Decimal
        Get
            Return (_PNCPRVCL)
        End Get
        Set(ByVal value As Decimal)
            _PNCPRVCL = value
        End Set
    End Property
    Public Property PNCPLCLP() As Decimal
        Get
            Return (_PNCPLCLP)
        End Get
        Set(ByVal value As Decimal)
            _PNCPLCLP = value
        End Set
    End Property
    Public Property PSTCMPCP() As String
        Get
            Return (_PSTCMPCP)
        End Get
        Set(ByVal value As String)
            _PSTCMPCP = value
        End Set
    End Property
    Public Property PSTDRPCP() As String
        Get
            Return (_PSTDRPCP)
        End Get
        Set(ByVal value As String)
            _PSTDRPCP = value
        End Set
    End Property
    Public Property PSNRCLED() As String
        Get
            Return (_PSNRCLED)
        End Get
        Set(ByVal value As String)
            _PSNRCLED = value
        End Set
    End Property
    Public Property PSTDRDST() As String
        Get
            Return (_PSTDRDST)
        End Get
        Set(ByVal value As String)
            _PSTDRDST = value
        End Set
    End Property
    Public Property PSMAILDS() As String
        Get
            Return (_PSMAILDS)
        End Get
        Set(ByVal value As String)
            _PSMAILDS = value
        End Set
    End Property
    Public Property PSCRUTAT() As String
        Get
            Return (_PSCRUTAT)
        End Get
        Set(ByVal value As String)
            _PSCRUTAT = value
        End Set
    End Property
    Public Property PNNCRRRT() As Decimal
        Get
            Return (_PNNCRRRT)
        End Get
        Set(ByVal value As Decimal)
            _PNNCRRRT = value
        End Set
    End Property
    Public Property PSCZNAVN() As String
        Get
            Return (_PSCZNAVN)
        End Get
        Set(ByVal value As String)
            _PSCZNAVN = value
        End Set
    End Property
    Public Property PSCVNDRC() As String
        Get
            Return (_PSCVNDRC)
        End Get
        Set(ByVal value As String)
            _PSCVNDRC = value
        End Set
    End Property
    Public Property PSCCLTTM() As String
        Get
            Return (_PSCCLTTM)
        End Get
        Set(ByVal value As String)
            _PSCCLTTM = value
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
    Public Property PSCULUSA() As String
        Get
            Return (_PSCULUSA)
        End Get
        Set(ByVal value As String)
            _PSCULUSA = value
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
 
    Public Property PNCUBGE2() As Decimal
        Get
            Return _CUBGE2
        End Get
        Set(ByVal value As Decimal)
            _CUBGE2 = value
        End Set
    End Property
 
    Public Property PSUBIGEO() As String
        Get
            Return _UBIGEO
        End Get
        Set(ByVal value As String)
            _UBIGEO = value
        End Set
    End Property



End Class