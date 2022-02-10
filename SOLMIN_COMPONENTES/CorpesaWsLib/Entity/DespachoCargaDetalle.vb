Public Class DespachoCargaDetalle

    Private _idDetalle As String
    Private _IdMovimiento As String
    Private _codBarra As String
    Private _nroOrden As String
    Private _tipo As String
    Private _cantidad As String
    Private _nroGuia As String

    Public Property IdDetalle() As String
        Get
            Return _idDetalle
        End Get
        Set(ByVal Value As String)
            _idDetalle = Value
        End Set
    End Property

    Public Property IdMovimiento() As String
        Get
            Return _IdMovimiento
        End Get
        Set(ByVal value As String)
            _IdMovimiento = value
        End Set
    End Property

    Public Property CodBarra() As String
        Get
            Return _codBarra
        End Get
        Set(ByVal Value As String)
            _codBarra = Value
        End Set
    End Property

    Public Property NroOrden() As String
        Get
            Return _nroOrden
        End Get
        Set(ByVal Value As String)
            _nroOrden = Value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal Value As String)
            _tipo = Value
        End Set
    End Property

    Public Property Cantidad() As String
        Get
            Return _cantidad
        End Get
        Set(ByVal Value As String)
            _cantidad = Value
        End Set
    End Property

    Public Property NroGuia() As String
        Get
            Return _nroGuia
        End Get
        Set(ByVal Value As String)
            _nroGuia = Value
        End Set
    End Property

End Class
