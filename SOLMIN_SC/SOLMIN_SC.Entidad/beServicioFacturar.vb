Public Class beServicioFacturar

    Private _PNCCLNT As Decimal = 0
    Private _PNNOPRCN As Decimal = 0
    Private _PNNCRROP As Decimal = 0
    Private _PNFOPRCN As Decimal = 0
    Private _PNCCLNFC As Decimal = 0
    Private _PNNRTFSV As Decimal = 0
    Private _PSCCMPN As String = ""
    Private _PSCDVSN As String = ""
    Private _PNCPLNDV As Decimal = 0
    Private _PSCTPALJ As String = ""
    Private _PNQATNAN As Decimal = 0
    Private _PNNORSCI As Decimal = 0
    Private _PSTOBS As String = ""
    Private _PSUSUARIO As String = ""
    Private _PSBUSQUEDA As String = ""
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PNNOPRCN() As Decimal
        Get
            Return _PNNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _PNNOPRCN = value
        End Set
    End Property

    Public Property PNNCRROP() As Decimal
        Get
            Return _PNNCRROP
        End Get
        Set(ByVal value As Decimal)
            _PNNCRROP = value
        End Set
    End Property

    Public Property PNFOPRCN() As Decimal
        Get
            Return _PNFOPRCN
        End Get
        Set(ByVal value As Decimal)
            _PNFOPRCN = value
        End Set
    End Property

    Public Property PNCCLNFC() As Decimal
        Get
            Return _PNCCLNFC
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNFC = value
        End Set
    End Property

    Public Property PNNRTFSV() As Decimal
        Get
            Return _PNNRTFSV
        End Get
        Set(ByVal value As Decimal)
            _PNNRTFSV = value
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


    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property
    Public Property PSCTPALJ() As String
        Get
            Return _PSCTPALJ
        End Get
        Set(ByVal value As String)
            _PSCTPALJ = value
        End Set
    End Property
    Public Property PNQATNAN() As Decimal
        Get
            Return _PNQATNAN
        End Get
        Set(ByVal value As Decimal)
            _PNQATNAN = value
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
    Public Property PSTOBS() As String
        Get
            Return _PSTOBS
        End Get
        Set(ByVal value As String)
            _PSTOBS = value
        End Set
    End Property
    Public Property PSUSUARIO() As String
        Get
            Return _PSUSUARIO
        End Get
        Set(ByVal value As String)
            _PSUSUARIO = value
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
    Public Property PSBUSQUEDA() As String
        Get
            Return _PSBUSQUEDA
        End Get
        Set(ByVal value As String)
            _PSBUSQUEDA = value
        End Set
    End Property



End Class
