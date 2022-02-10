
Public Class ConsistenciaOperacion
    Private _Operacion As Double
    Public Property Operacion() As Double
        Get
            Return _Operacion
        End Get
        Set(ByVal value As Double)
            _Operacion = value
        End Set
    End Property

    Private _Factura As Double
    Public Property Factura() As Double
        Get
            Return _Factura
        End Get
        Set(ByVal value As Double)
            _Factura = value
        End Set
    End Property

    Private _Fecha As String
    Public Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property

    Private _Liberar As String
    Public Property Liberar() As String
        Get
            Return _Liberar
        End Get
        Set(ByVal value As String)
            _Liberar = value
        End Set
    End Property

    Private _ImporteFacturado As Double
    Public Property ImporteFacturado() As Double
        Get
            Return _ImporteFacturado
        End Get
        Set(ByVal value As Double)
            _ImporteFacturado = value
        End Set
    End Property
    Private _Importe As Double
    Public Property Importe() As Double
        Get
            Return _Importe
        End Get
        Set(ByVal value As Double)
            _Importe = value
        End Set
    End Property

    Private _TipoCambioFactura As Double
    Public Property TipoCambioFactura() As Double
        Get
            Return _TipoCambioFactura
        End Get
        Set(ByVal value As Double)
            _TipoCambioFactura = value
        End Set
    End Property

    Private _NotaCredito As String
    Public Property NotaCredito() As String
        Get
            Return _NotaCredito
        End Get
        Set(ByVal value As String)
            _NotaCredito = value
        End Set
    End Property

    Private _MonedaImporte As String
    Public Property MonedaImporte() As String
        Get
            Return _MonedaImporte
        End Get
        Set(ByVal value As String)
            _MonedaImporte = value
        End Set
    End Property

    Private _MonedaFactura As String
    Public Property MonedaFactura() As String
        Get
            Return _MonedaFactura
        End Get
        Set(ByVal value As String)
            _MonedaFactura = value
        End Set
    End Property


End Class
