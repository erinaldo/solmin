Public Class InformacionCarga_Detalle

    Private _codigoOC As String
    Private _numeroOC As String
    Private _numeroItem As String
    Private _cantidad As String
    Private _guiaRemision As String

    Public Property CodigoOC() As String
        Get
            Return _codigoOC
        End Get
        Set(ByVal Value As String)
            _codigoOC = Value
        End Set
    End Property

    Public Property NumeroOC() As String
        Get
            Return _numeroOC
        End Get
        Set(ByVal Value As String)
            _numeroOC = Value
        End Set
    End Property

    Public Property NumeroItem() As String
        Get
            Return _numeroItem
        End Get
        Set(ByVal Value As String)
            _numeroItem = Value
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

    Public Property GuiaRemision() As String
        Get
            Return _guiaRemision
        End Get
        Set(ByVal Value As String)
            _guiaRemision = Value
        End Set
    End Property
End Class
