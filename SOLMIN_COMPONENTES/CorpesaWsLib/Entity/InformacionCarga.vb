Public Class InformacionCarga

    Private _Codigooc As String
    Private _Fecharecepcion As String
    Private _Codigocarga As String
    Private _Codigocargaorigen As String
    Private _Cantidadrecibida As String
    Private _descripcion As String
    Private _guiapluspetrol As String
    Private _Tipocarga As String
    Private _Pesocarga As String
    Private _Unidadpeso As String
    Private _Unidadvolumen As String
    Private _Numeropaleta As String
    Private _Llegadadestino As String
    Private _volumenCarga As String
    Private _InformacionCargaDetalle As New List(Of InformacionCarga_Detalle)

    Public Property Codigooc() As String
        Get
            Return _Codigooc
        End Get
        Set(ByVal Value As String)
            _Codigooc = Value
        End Set
    End Property

    Public Property Fecharecepcion() As String
        Get
            Return _Fecharecepcion
        End Get
        Set(ByVal Value As String)
            _Fecharecepcion = Value
        End Set
    End Property

    Public Property Codigocarga() As String
        Get
            Return _Codigocarga
        End Get
        Set(ByVal Value As String)
            _Codigocarga = Value
        End Set
    End Property

    Public Property Codigocargaorigen() As String
        Get
            Return _Codigocargaorigen
        End Get
        Set(ByVal Value As String)
            _Codigocargaorigen = Value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal Value As String)
            _descripcion = Value
        End Set
    End Property

    Public Property GuiaPluspetrol() As String
        Get
            Return _guiapluspetrol
        End Get
        Set(ByVal Value As String)
            _guiapluspetrol = Value
        End Set
    End Property


    Public Property Cantidadrecibida() As String
        Get
            Return _Cantidadrecibida
        End Get
        Set(ByVal Value As String)
            _Cantidadrecibida = Value
        End Set
    End Property

    Public Property Tipocarga() As String
        Get
            Return _Tipocarga
        End Get
        Set(ByVal Value As String)
            _Tipocarga = Value
        End Set
    End Property

    Public Property Pesocarga() As String
        Get
            Return _Pesocarga
        End Get
        Set(ByVal Value As String)
            _Pesocarga = Value
        End Set
    End Property

    Public Property Unidadpeso() As String
        Get
            Return _Unidadpeso
        End Get
        Set(ByVal Value As String)
            _Unidadpeso = Value
        End Set
    End Property

    Public Property volumenCarga() As String
        Get
            Return _volumenCarga
        End Get
        Set(ByVal value As String)
            _volumenCarga = value
        End Set
    End Property

    Public Property Unidadvolumen() As String
        Get
            Return _Unidadvolumen
        End Get
        Set(ByVal Value As String)
            _Unidadvolumen = Value
        End Set
    End Property

    Public Property Numeropaleta() As String
        Get
            Return _Numeropaleta
        End Get
        Set(ByVal Value As String)
            _Numeropaleta = Value
        End Set
    End Property

    Public Property Llegadadestino() As String
        Get
            Return _Llegadadestino
        End Get
        Set(ByVal Value As String)
            _Llegadadestino = Value
        End Set
    End Property


    Public Property InformacionCargaDetalle() As List(Of InformacionCarga_Detalle)
        Get
            Return _InformacionCargaDetalle
        End Get
        Set(ByVal value As List(Of InformacionCarga_Detalle))
            _InformacionCargaDetalle = value
        End Set
    End Property

End Class
