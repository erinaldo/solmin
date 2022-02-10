Public Class beCostoTotalEmbarqueNacional

    Private _PSCVARBL As String = ""
    Private _PSNOMVAR As String = ""
    Private _PSVALVAR As String = ""

    Private _PSCODVAR As String = ""
    Private _PSNMONOC As String = ""

    Private _PNNORSCI As Nullable(Of Decimal)

    Private _PNIVLORG As Nullable(Of Decimal)
    Private _PNIVLDOL As Nullable(Of Decimal)
    Private _PNCMNDA1 As Nullable(Of Decimal)
    Private _PNNMRGIM As Nullable(Of Decimal)

    Public Property PNNORSCI() As Nullable(Of Decimal)
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _PNNORSCI = value
        End Set
    End Property

    Public Property PSNMONOC() As String
        Get
            Return _PSNMONOC
        End Get
        Set(ByVal value As String)
            _PSNMONOC = value
        End Set
    End Property

    Public Property PSCVARBL() As String
        Get
            Return _PSCVARBL
        End Get
        Set(ByVal value As String)
            _PSCVARBL = value
        End Set
    End Property

    Public Property PSCODVAR() As String
        Get
            Return _PSCODVAR
        End Get
        Set(ByVal value As String)
            _PSCODVAR = value
        End Set
    End Property

    Public Property PNIVLORG() As Nullable(Of Decimal)
        Get
            Return _PNIVLORG
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _PNIVLORG = value
        End Set
    End Property

    Public Property PNIVLDOL() As Nullable(Of Decimal)
        Get
            Return _PNIVLDOL
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _PNIVLDOL = value
        End Set
    End Property

    Public Property PNCMNDA1() As Nullable(Of Decimal)
        Get
            Return _PNCMNDA1
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _PNCMNDA1 = value
        End Set
    End Property

    Public Property PNNMRGIM() As Nullable(Of Decimal)
        Get
            Return _PNNMRGIM
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _PNNMRGIM = value
        End Set
    End Property

    Public Property PSNOMVAR() As String
        Get
            Return _PSNOMVAR
        End Get
        Set(ByVal value As String)
            _PSNOMVAR = value
        End Set
    End Property

    Public Property PSVALVAR() As String
        Get
            Return _PSVALVAR
        End Get
        Set(ByVal value As String)
            _PSVALVAR = value
        End Set
    End Property
End Class

