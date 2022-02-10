Public Class bePortalDetalle
    Private _PSFILTRO As String = ""
    Private _PSCLIENTE As Double = 0
    Private _PSITEM As String = ""
    Private _PSORDENCOMPRA As String = ""
    Private _PNCNTDESTINO As Double = 0
    Private _PNCNTALMACEN As Double = 0
    Private _PNCNTCLIENTE As Double = 0
    Private _PSCLIENTE_SOL As Double = 0
    Private _PSCLIENTE_NOMBRE As String = ""
    Private _PSTABLA As DataTable = Nothing

    Public Property PNCNTDESTINO() As Double
        Get
            Return _PNCNTDESTINO
        End Get
        Set(ByVal value As Double)
            _PNCNTDESTINO = value
        End Set
    End Property
    Public Property PNCNTALMACEN() As Double
        Get
            Return _PNCNTALMACEN
        End Get
        Set(ByVal value As Double)
            _PNCNTALMACEN = value
        End Set
    End Property
    Public Property PNCNTCLIENTE() As Double
        Get
            Return _PNCNTCLIENTE
        End Get
        Set(ByVal value As Double)
            _PNCNTCLIENTE = value
        End Set
    End Property

    Public Property PSFILTRO() As String
        Get
            Return _PSFILTRO
        End Get
        Set(ByVal value As String)
            _PSFILTRO = value
        End Set
    End Property

    Public Property PSITEM() As String
        Get
            Return _PSITEM
        End Get
        Set(ByVal value As String)
            _PSITEM = value
        End Set
    End Property
    Public Property PSORDENCOMPRA() As String
        Get
            Return _PSORDENCOMPRA
        End Get
        Set(ByVal value As String)
            _PSORDENCOMPRA = value
        End Set
    End Property

    Public Property PSCLIENTE() As Double
        Get
            Return _PSCLIENTE
        End Get
        Set(ByVal value As Double)
            _PSCLIENTE = value
        End Set
    End Property

    Public Property PSCLIENTE_SOL() As Double
        Get
            Return _PSCLIENTE_SOL
        End Get
        Set(ByVal value As Double)
            _PSCLIENTE_SOL = value
        End Set
    End Property

    Public Property PSCLIENTE_NOMBRE() As String
        Get
            Return _PSCLIENTE_NOMBRE
        End Get
        Set(ByVal value As String)
            _PSCLIENTE_NOMBRE = value
        End Set
    End Property

    Public Property PSTABLA() As DataTable
        Get
            Return _PSTABLA
        End Get
        Set(ByVal value As DataTable)
            _PSTABLA = value
        End Set
    End Property
End Class
