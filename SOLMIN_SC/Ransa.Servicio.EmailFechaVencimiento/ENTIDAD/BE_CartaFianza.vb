Public Class BE_CartaFianza

    Private _PNNORSCI As Decimal = 0
    Private _PSPNNMOS As String = ""
    Private _PSFORSCI As String = ""
    Private _PSNDOCUM As String = ""
    Private _PNCBNCFN As Decimal = 0
    Private _PSTCMBCF As String = ""
    Private _PSFECINI As String = ""
    Private _PSFECVEN As String = ""
    Private _PNITTDOC As Decimal = 0
    Private _PSNMONOC As String = ""
    Private _PNCMNDA1 As Decimal = 0
    Private _POBESCALA As New BE_Escala
    Private _PNDIFDIAS As Int32 = 0
    Public Property PNNORSCI() As Decimal
        Get
            Return _PNNORSCI
        End Get
        Set(ByVal value As Decimal)
            _PNNORSCI = value
        End Set
    End Property

    Public Property PSPNNMOS() As String
        Get
            Return _PSPNNMOS
        End Get
        Set(ByVal value As String)
            _PSPNNMOS = value
        End Set
    End Property

    Public Property PSFORSCI() As String
        Get
            Return _PSFORSCI
        End Get
        Set(ByVal value As String)
            _PSFORSCI = value
        End Set
    End Property

    Public Property PSNDOCUM() As String
        Get
            Return _PSNDOCUM
        End Get
        Set(ByVal value As String)
            _PSNDOCUM = value
        End Set
    End Property


    Public Property PSFECINI() As String
        Get
            Return _PSFECINI
        End Get
        Set(ByVal value As String)
            _PSFECINI = value
        End Set
    End Property
    Public Property PSFECVEN() As String
        Get
            Return _PSFECVEN
        End Get
        Set(ByVal value As String)
            _PSFECVEN = value
        End Set
    End Property


    Public Property PNCBNCFN() As Decimal
        Get
            Return _PNCBNCFN
        End Get
        Set(ByVal value As Decimal)
            _PNCBNCFN = value
        End Set
    End Property


    Public Property PSTCMBCF() As String
        Get
            Return _PSTCMBCF
        End Get
        Set(ByVal value As String)
            _PSTCMBCF = value
        End Set
    End Property

    Public Property PNITTDOC() As Decimal
        Get
            Return _PNITTDOC
        End Get
        Set(ByVal value As Decimal)
            _PNITTDOC = value
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
    Public Property PNCMNDA1() As Decimal
        Get
            Return _PNCMNDA1
        End Get
        Set(ByVal value As Decimal)
            _PNCMNDA1 = value
        End Set
    End Property

    Public Property POBESCALA() As BE_Escala
        Get
            Return _POBESCALA
        End Get
        Set(ByVal value As BE_Escala)
            _POBESCALA = value
        End Set
    End Property

    Public Property PNDIFDIAS() As Int32
        Get
            Return _PNDIFDIAS
        End Get
        Set(ByVal value As Int32)
            _PNDIFDIAS = value
        End Set
    End Property


End Class
