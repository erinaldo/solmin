Public Class beProveedor
    Inherits beBase

    Private _PNCPRVCL As Decimal = 0
    Private _PSTPRVCL As String = ""
    Private _PSTPRCL1 As String = ""
    Private _PNNRUCPR As Decimal = 0
    Private _PSTNACPR As String = ""
    Private _PSTDRPRC As String = ""
    Private _PNCPAIS As Decimal = 0
    Private _PSTNROFX As String = ""
    Private _PSTLFNO1 As String = ""
    Private _PSTEMAI2 As String = ""
    Private _PSTPRSCN As String = ""
    Private _PSTLFNO2 As String = ""
    Private _PSTEMAI3 As String = ""
    Private _PNNDSDMP As Decimal = 0
    Private _PSSESTRG As String = ""
    Private _PNFULTAC As Decimal = 0
    Private _PNHULTAC As Decimal = 0
    Private _PSCULUSA As String = ""
    Private _PSCUSCRT As String = ""
    Private _PNFCHCRT As Decimal = 0
    Private _PNHRACRT As Decimal = 0
    Private _PNUPDATE_IDENT As Decimal = 0
    Private _PSNRUCPRSTR As String = ""
    Private _PSCPRVCLSTR As String = ""
    Private _PSBUSQUEDA As String = ""
    Private _PNCCLNT As Decimal = 0
    Private _PSSTPORL As String = ""
    Private _RELACION As String = ""
    Private _CREACION As String = ""
    Private _PSDIRCOMPLETO As String = ""
    Private _PSNOMCOMPLETO As String = ""
    Public _PSCPRPCL As String = ""

    Public Property PSNOMCOMPLETO() As String
        Get
            Return _PSNOMCOMPLETO
        End Get
        Set(ByVal value As String)
            _PSNOMCOMPLETO = value
        End Set
    End Property

    Public Property PSDIRCOMPLETO() As String
        Get
            Return _PSDIRCOMPLETO
        End Get
        Set(ByVal value As String)
            _PSDIRCOMPLETO = value
        End Set
    End Property

    Public Property CREACION() As String
        Get
            Return _CREACION.Trim
        End Get
        Set(ByVal value As String)
            _CREACION = value
        End Set
    End Property


    Public Property RELACION() As String
        Get
            Return _RELACION
        End Get
        Set(ByVal value As String)
            _RELACION = value
        End Set
    End Property

    Public Property PSSTPORL() As String
        Get
            Return _PSSTPORL
        End Get
        Set(ByVal value As String)
            _PSSTPORL = value
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

    Public Property PSBUSQUEDA() As String
        Get
            Return _PSBUSQUEDA
        End Get
        Set(ByVal value As String)
            _PSBUSQUEDA = value
        End Set
    End Property

    Public Property PSCPRVCLSTR() As String
        Get
            Return _PSCPRVCLSTR
        End Get
        Set(ByVal value As String)
            _PSCPRVCLSTR = value
        End Set
    End Property

    Public Property PSNRUCPRSTR() As String
        Get
            Return _PSNRUCPRSTR
        End Get
        Set(ByVal value As String)
            _PSNRUCPRSTR = value
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
    Public Property PSTPRVCL() As String
        Get
            Return (_PSTPRVCL)
        End Get
        Set(ByVal value As String)
            _PSTPRVCL = value
        End Set
    End Property
    Public Property PSTPRCL1() As String
        Get
            Return (_PSTPRCL1)
        End Get
        Set(ByVal value As String)
            _PSTPRCL1 = value
        End Set
    End Property
    Public Property PNNRUCPR() As Decimal
        Get
            Return (_PNNRUCPR)
        End Get
        Set(ByVal value As Decimal)
            _PNNRUCPR = value
        End Set
    End Property
    Public Property PSTNACPR() As String
        Get
            Return (_PSTNACPR)
        End Get
        Set(ByVal value As String)
            _PSTNACPR = value
        End Set
    End Property
    Public Property PSTDRPRC() As String
        Get
            Return (_PSTDRPRC)
        End Get
        Set(ByVal value As String)
            _PSTDRPRC = value
        End Set
    End Property
    Public Property PNCPAIS() As Decimal
        Get
            Return (_PNCPAIS)
        End Get
        Set(ByVal value As Decimal)
            _PNCPAIS = value
        End Set
    End Property
    Public Property PSTNROFX() As String
        Get
            Return (_PSTNROFX)
        End Get
        Set(ByVal value As String)
            _PSTNROFX = value
        End Set
    End Property
    Public Property PSTLFNO1() As String
        Get
            Return (_PSTLFNO1)
        End Get
        Set(ByVal value As String)
            _PSTLFNO1 = value
        End Set
    End Property
    Public Property PSTEMAI2() As String
        Get
            Return (_PSTEMAI2)
        End Get
        Set(ByVal value As String)
            _PSTEMAI2 = value
        End Set
    End Property
    Public Property PSTPRSCN() As String
        Get
            Return (_PSTPRSCN)
        End Get
        Set(ByVal value As String)
            _PSTPRSCN = value
        End Set
    End Property
    Public Property PSTLFNO2() As String
        Get
            Return (_PSTLFNO2)
        End Get
        Set(ByVal value As String)
            _PSTLFNO2 = value
        End Set
    End Property
    Public Property PSTEMAI3() As String
        Get
            Return (_PSTEMAI3)
        End Get
        Set(ByVal value As String)
            _PSTEMAI3 = value
        End Set
    End Property
    Public Property PNNDSDMP() As Decimal
        Get
            Return (_PNNDSDMP)
        End Get
        Set(ByVal value As Decimal)
            _PNNDSDMP = value
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
    Public Property PNUPDATE_IDENT() As Decimal
        Get
            Return (_PNUPDATE_IDENT)
        End Get
        Set(ByVal value As Decimal)
            _PNUPDATE_IDENT = value
        End Set
    End Property
    Public Property PSCPRPCL() As String
        Get
            Return _PSCPRPCL
        End Get
        Set(ByVal value As String)
            _PSCPRPCL = value
        End Set
    End Property
    Public Sub Trim()
        PSTPRVCL = PSTPRVCL.Trim
        PSTPRCL1 = PSTPRCL1.Trim
        PSTNACPR = PSTNACPR.Trim
        PSTDRPRC = PSTDRPRC.Trim
        PSTLFNO1 = PSTLFNO1.Trim
        PSTEMAI2 = PSTEMAI2.Trim
        PSTPRSCN = PSTPRSCN.Trim
        PSTLFNO2 = PSTLFNO2.Trim
        PSTEMAI3 = PSTEMAI3.Trim
        PSSESTRG = PSSESTRG.Trim
        PSCULUSA = PSCULUSA.Trim
        PSCUSCRT = PSCUSCRT.Trim
        PSNRUCPRSTR = PSNRUCPRSTR.Trim
        PSCPRVCLSTR = PSCPRVCLSTR.Trim
    End Sub

    Public Sub pclear()
        PNCPRVCL = 0
        PSTPRVCL = ""
        PSTPRCL1 = ""
        PNNRUCPR = 0
        PSTNACPR = ""
        PSTDRPRC = ""
        PNCPAIS = 0
        PSTNROFX = 0
        PSTLFNO1 = ""
        PSTEMAI2 = ""
        PSTPRSCN = ""
        PSTLFNO2 = ""
        PSTEMAI3 = ""
        PNNDSDMP = 0
        PSSESTRG = ""
        PNFULTAC = 0
        PNHULTAC = 0
        PSCULUSA = ""
        PSCUSCRT = ""
        PNFCHCRT = 0
        PNHRACRT = 0
        PNUPDATE_IDENT = 0
        PSNRUCPRSTR = ""
        PSCPRVCLSTR = ""
    End Sub
End Class
Public Class TD_Qry_Proveedor
    Public PSCPRVCLSTR As String = ""
    Public PSNRUCPRSTR As String = ""
    Public PSTPRVCL As String = ""
    Public PSBUSQUEDA As String = ""
    Public Sub clear()
        PSCPRVCLSTR = ""
        PSNRUCPRSTR = ""
        PSTPRVCL = ""
        PSBUSQUEDA = ""
    End Sub
End Class
Public Class InfoProveedor
    Public PNCPRVCL As String = ""
    Public PNNRUCPR As String
    Public PSTPRVCL As String = ""
    Public Sub clear()
        PNCPRVCL = 0
        PNNRUCPR = 0
        PSTPRVCL = ""
    End Sub
End Class