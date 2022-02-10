Public Class DespachoCarga

    Private _Idmovimiento As String
    Private _Origen As String
    Private _Destino As String
    Private _Fechamovimiento As String
    Private _Horamovimiento As String
    Private _Codtransporte As String
    Private _Tipotransporte As String
    Private _Marca As String
    Private _Modelo As String
    Private _Placa As String
    Private _Primernombre As String
    Private _Segundonombre As String
    Private _Apellidopaterno As String
    Private _Apellidomaterno As String
    Private _Tipodocumento As String
    Private _NumeroDocumento As String

    Private _DespachoDetalle As New List(Of DespachoCargaDetalle)

    Public Property Idmovimiento() As String
        Get
            Return _Idmovimiento
        End Get
        Set(ByVal Value As String)
            _Idmovimiento = Value
        End Set
    End Property

    Public Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal Value As String)
            _Origen = Value
        End Set
    End Property

    Public Property Destino() As String
        Get
            Return _Destino
        End Get
        Set(ByVal Value As String)
            _Destino = Value
        End Set
    End Property

    Public Property Fechamovimiento() As String
        Get
            Return _Fechamovimiento
        End Get
        Set(ByVal Value As String)
            _Fechamovimiento = Value
        End Set
    End Property

    Public Property Horamovimiento() As String
        Get
            Return _Horamovimiento
        End Get
        Set(ByVal Value As String)
            _Horamovimiento = Value
        End Set
    End Property

    Public Property Codtransporte() As String
        Get
            Return _Codtransporte
        End Get
        Set(ByVal Value As String)
            _Codtransporte = Value
        End Set
    End Property

    Public Property Tipotransporte() As String
        Get
            Return _Tipotransporte
        End Get
        Set(ByVal Value As String)
            _Tipotransporte = Value
        End Set
    End Property

    Public Property Marca() As String
        Get
            Return _Marca
        End Get
        Set(ByVal Value As String)
            _Marca = Value
        End Set
    End Property

    Public Property Modelo() As String
        Get
            Return _Modelo
        End Get
        Set(ByVal Value As String)
            _Modelo = Value
        End Set
    End Property

    Public Property Placa() As String
        Get
            Return _Placa
        End Get
        Set(ByVal Value As String)
            _Placa = Value
        End Set
    End Property

    Public Property Primernombre() As String
        Get
            Return _Primernombre
        End Get
        Set(ByVal Value As String)
            _Primernombre = Value
        End Set
    End Property

    Public Property Segundonombre() As String
        Get
            Return _Segundonombre
        End Get
        Set(ByVal Value As String)
            _Segundonombre = Value
        End Set
    End Property

    Public Property Apellidopaterno() As String
        Get
            Return _Apellidopaterno
        End Get
        Set(ByVal Value As String)
            _Apellidopaterno = Value
        End Set
    End Property

    Public Property Apellidomaterno() As String
        Get
            Return _Apellidomaterno
        End Get
        Set(ByVal Value As String)
            _Apellidomaterno = Value
        End Set
    End Property

    Public Property Tipodocumento() As String
        Get
            Return _Tipodocumento
        End Get
        Set(ByVal Value As String)
            _Tipodocumento = Value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return _NumeroDocumento
        End Get
        Set(ByVal Value As String)
            _NumeroDocumento = Value
        End Set
    End Property
    Public Property DespachoDetalleCollection() As List(Of DespachoCargaDetalle)
        Get
            Return _DespachoDetalle
        End Get
        Set(ByVal value As List(Of DespachoCargaDetalle))
            _DespachoDetalle = value
        End Set
    End Property

End Class
