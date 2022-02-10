Imports Ransa.TYPEDEF

Public Class beSerie

    Inherits beBase(Of beSerie)

    Private _PNNORDSR As Decimal = 0
    Private _PSCSRECL As String = ""
    Private _PSCSRECL_ANT As String = ""
    Private _PNNCRPLL As Decimal = 0
    Private _PNCCLNT As Decimal = 0
    Private _PSTDSMDL As String = ""
    Private _PNFINGAL As Decimal = 0
    Private _PNHINGAL As Decimal = 0
    Private _PNFSLDAL As Decimal = 0
    Private _PNHSLDAL As Decimal = 0
    Private _PSTOBSRV As String = ""
    Private _PNNGUIIN As Decimal = 0
    Private _PNNGUISL As Decimal = 0
    Private _PNNGUIRM As Decimal = 0
    Private _PSSTPING As String = ""
    Private _PSSSTINV As String = ""
    Private _PNFCHCRT As Decimal = 0
    Private _PNHRACRT As Decimal = 0
    Private _PSCUSCRT As String = ""
    Private _PSCULUSA As String = ""
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSSESTRG As String = ""
    Private _PNUPDATE_IDENT As Decimal = 0
    Private _IsDespacho As Boolean
    Private _CREACION As String = ""

    Public Property CREACION() As String
        Get
            Return _CREACION
        End Get
        Set(ByVal value As String)
            _CREACION = value
        End Set
    End Property


    Public Property PNESTADO() As Integer
        Get
            If _IsDespacho Then
                Return 1
            Else
                Return 0
            End If

            Return _IsDespacho
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                _IsDespacho = False
            Else
                _IsDespacho = True
            End If
        End Set
    End Property


    Public Property IsDespacho() As Boolean
        Get
            Return _IsDespacho
        End Get
        Set(ByVal value As Boolean)
            _IsDespacho = value
        End Set
    End Property

    Private _IsError As Boolean
    Public Property Isfallacy() As Boolean
        Get
            Return _IsError
        End Get
        Set(ByVal value As Boolean)
            _IsError = value
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
    Public Property PSCSRECL_ANT() As String
        Get
            Return (_PSCSRECL_ANT)
        End Get
        Set(ByVal value As String)
            _PSCSRECL_ANT = value
        End Set
    End Property

    Public Property PSCSRECL() As String
        Get
            Return (_PSCSRECL)
        End Get
        Set(ByVal value As String)
            _PSCSRECL = value
        End Set
    End Property
    Public Property PNNCRPLL() As Decimal
        Get
            Return (_PNNCRPLL)
        End Get
        Set(ByVal value As Decimal)
            _PNNCRPLL = value
        End Set
    End Property
    Public Property PNCCLNT() As Decimal
        Get
            Return (_PNCCLNT)
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property
    Public Property PSTDSMDL() As String
        Get
            Return (_PSTDSMDL)
        End Get
        Set(ByVal value As String)
            _PSTDSMDL = value
        End Set
    End Property
    Public Property PNFINGAL() As Decimal
        Get
            Return (_PNFINGAL)
        End Get
        Set(ByVal value As Decimal)
            _PNFINGAL = value
        End Set
    End Property
    Public Property PNHINGAL() As Decimal
        Get
            Return (_PNHINGAL)
        End Get
        Set(ByVal value As Decimal)
            _PNHINGAL = value
        End Set
    End Property
    Public Property PNFSLDAL() As Decimal
        Get
            Return (_PNFSLDAL)
        End Get
        Set(ByVal value As Decimal)
            _PNFSLDAL = value
        End Set
    End Property
    Public Property PNHSLDAL() As Decimal
        Get
            Return (_PNHSLDAL)
        End Get
        Set(ByVal value As Decimal)
            _PNHSLDAL = value
        End Set
    End Property
    Public Property PSTOBSRV() As String
        Get
            Return (_PSTOBSRV)
        End Get
        Set(ByVal value As String)
            _PSTOBSRV = value
        End Set
    End Property
    Public Property PNNGUIIN() As Decimal
        Get
            Return (_PNNGUIIN)
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIIN = value
        End Set
    End Property
    Public Property PNNGUISL() As Decimal
        Get
            Return (_PNNGUISL)
        End Get
        Set(ByVal value As Decimal)
            _PNNGUISL = value
        End Set
    End Property
    Public Property PNNGUIRM() As Decimal
        Get
            Return (_PNNGUIRM)
        End Get
        Set(ByVal value As Decimal)
            _PNNGUIRM = value
        End Set
    End Property
    Public Property PSSTPING() As String
        Get
            Return (_PSSTPING)
        End Get
        Set(ByVal value As String)
            _PSSTPING = value
        End Set
    End Property
    Public Property PSSSTINV() As String
        Get
            Return (_PSSSTINV)
        End Get
        Set(ByVal value As String)
            _PSSSTINV = value
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
    Public Property PSCUSCRT() As String
        Get
            Return (_PSCUSCRT)
        End Get
        Set(ByVal value As String)
            _PSCUSCRT = value
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

#Region "Propiedades Adisionales"

    Private _PNNRITOC As Decimal
    Public Property PNNRITOC() As Decimal
        Get
            Return _PNNRITOC
        End Get
        Set(ByVal value As Decimal)
            _PNNRITOC = value
        End Set
    End Property

#End Region
End Class