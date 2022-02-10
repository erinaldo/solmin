Public Class beCostoTotalEmbarque
    Private _PNNORSCI As Decimal = 0
    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property
    Private _PSCODVAR As String = ""
    Public Property PSCODVAR() As String
        Get
            Return _PSCODVAR
        End Get
        Set(ByVal value As String)
            _PSCODVAR = value
        End Set
    End Property

    Private _PNIVLORG As Decimal = 0
    Public Property PNIVLORG() As Decimal
        Get
            Return _PNIVLORG
        End Get
        Set(ByVal value As Decimal)
            _PNIVLORG = value
        End Set
    End Property

    Private _PNIVLDOL As Decimal = 0
    Public Property PNIVLDOL() As Decimal
        Get
            Return _PNIVLDOL
        End Get
        Set(ByVal value As Decimal)
            _PNIVLDOL = value
        End Set
    End Property

    Private _PNCMNDA1 As Decimal = 0
    Public Property PNCMNDA1() As Decimal
        Get
            Return _PNCMNDA1
        End Get
        Set(ByVal value As Decimal)
            _PNCMNDA1 = value
        End Set
    End Property

    Private _PSNMONOC As String = ""
    Public Property PSNMONOC() As String
        Get
            Return _PSNMONOC
        End Get
        Set(ByVal value As String)
            _PSNMONOC = value
        End Set
    End Property

End Class
