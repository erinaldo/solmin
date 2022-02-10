Public Class GR_JSON_PACASMAYO
    Private _indicador_serie As String = ""
    Public Property indicador_serie() As String
        Get
            Return _indicador_serie
        End Get
        Set(ByVal value As String)
            _indicador_serie = value
        End Set
    End Property

    Private _numero_guia As String = ""
    Public Property numero_guia() As String
        Get
            Return _numero_guia
        End Get
        Set(ByVal value As String)
            _numero_guia = value
        End Set
    End Property
    Private _fecha_contabilizacion As String = ""
    Public Property fecha_contabilizacion() As String
        Get
            Return _fecha_contabilizacion
        End Get
        Set(ByVal value As String)
            _fecha_contabilizacion = value
        End Set
    End Property


    Private _direccion_cliente As String = ""
    Public Property direccion_cliente() As String
        Get
            Return _direccion_cliente
        End Get
        Set(ByVal value As String)
            _direccion_cliente = value
        End Set
    End Property

    Private _fecha_inicio_traslado As String = ""
    Public Property fecha_inicio_traslado() As String
        Get
            Return _fecha_inicio_traslado
        End Get
        Set(ByVal value As String)
            _fecha_inicio_traslado = value
        End Set
    End Property

    Private _ubigeo_partida As String = ""
    Public Property ubigeo_partida() As String
        Get
            Return _ubigeo_partida
        End Get
        Set(ByVal value As String)
            _ubigeo_partida = value
        End Set
    End Property

    Private _direccion_punto_origen As String = ""
    Public Property direccion_punto_origen() As String
        Get
            Return _direccion_punto_origen
        End Get
        Set(ByVal value As String)
            _direccion_punto_origen = value
        End Set
    End Property

    Private _ubigeo_llegada As String = ""
    Public Property ubigeo_llegada() As String
        Get
            Return _ubigeo_llegada
        End Get
        Set(ByVal value As String)
            _ubigeo_llegada = value
        End Set
    End Property

    Private _direccion_punto_llegada As String = ""
    Public Property direccion_punto_llegada() As String
        Get
            Return _direccion_punto_llegada
        End Get
        Set(ByVal value As String)
            _direccion_punto_llegada = value
        End Set
    End Property

    Private _ruc_transportista As String = ""
    Public Property ruc_transportista() As String
        Get
            Return _ruc_transportista
        End Get
        Set(ByVal value As String)
            _ruc_transportista = value
        End Set
    End Property

    Private _ruc_cliente As String = ""
    Public Property ruc_cliente() As String
        Get
            Return _ruc_cliente
        End Get
        Set(ByVal value As String)
            _ruc_cliente = value
        End Set
    End Property


    Private _razon_social_transportista As String = ""
    Public Property razon_social_transportista() As String
        Get
            Return _razon_social_transportista
        End Get
        Set(ByVal value As String)
            _razon_social_transportista = value
        End Set
    End Property
    Private _brevete_chofer As String = ""
    Public Property brevete_chofer() As String
        Get
            Return _brevete_chofer
        End Get
        Set(ByVal value As String)
            _brevete_chofer = value
        End Set
    End Property

    Private _nombre_chofer As String = ""
    Public Property nombre_chofer() As String
        Get
            Return _nombre_chofer
        End Get
        Set(ByVal value As String)
            _nombre_chofer = value
        End Set
    End Property

    Private _placa_vehicular As String = ""
    Public Property placa_vehicular() As String
        Get
            Return _placa_vehicular
        End Get
        Set(ByVal value As String)
            _placa_vehicular = value
        End Set
    End Property

    Private _placa_acoplado As String = ""
    Public Property placa_acoplado() As String
        Get
            Return _placa_acoplado
        End Get
        Set(ByVal value As String)
            _placa_acoplado = value
        End Set
    End Property

    Private _placa_mtc As String = ""
    Public Property placa_mtc() As String
        Get
            Return _placa_mtc
        End Get
        Set(ByVal value As String)
            _placa_mtc = value
        End Set
    End Property


    Private _marca_vehicular As String = ""
    Public Property marca_vehicular() As String
        Get
            Return _marca_vehicular
        End Get
        Set(ByVal value As String)
            _marca_vehicular = value
        End Set
    End Property

    Private _peso_total As String = ""
    Public Property peso_total() As String
        Get
            Return _peso_total
        End Get
        Set(ByVal value As String)
            _peso_total = value
        End Set
    End Property


    Private _observaciones As String = ""
    Public Property observaciones() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value
        End Set
    End Property

    Private _motivo_traslado As String = ""
    Public Property motivo_traslado() As String
        Get
            Return _motivo_traslado
        End Get
        Set(ByVal value As String)
            _motivo_traslado = value
        End Set
    End Property

    Private _descripcion_motivo As String = ""
    Public Property descripcion_motivo() As String
        Get
            Return _descripcion_motivo
        End Get
        Set(ByVal value As String)
            _descripcion_motivo = value
        End Set
    End Property

    Private _modalidad_traslado As String = ""
    Public Property modalidad_traslado() As String
        Get
            Return _modalidad_traslado
        End Get
        Set(ByVal value As String)
            _modalidad_traslado = value
        End Set
    End Property

    Private _correo As String = ""
    Public Property correo() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property


    Private _cantidad_bulto As String = ""
    Public Property cantidad_bulto() As String
        Get
            Return _cantidad_bulto
        End Get
        Set(ByVal value As String)
            _cantidad_bulto = value
        End Set
    End Property
 


    Private _lista_materiales As New List(Of lista_materiales)
    Public Property lista_materiales() As List(Of lista_materiales)
        Get
            Return _lista_materiales
        End Get
        Set(ByVal value As List(Of lista_materiales))
            _lista_materiales = value
        End Set
    End Property



End Class
Public Class lista_materiales

    Private _numero_documento_compra As String = ""
    Public Property numero_documento_compra() As String
        Get
            Return _numero_documento_compra
        End Get
        Set(ByVal value As String)
            _numero_documento_compra = value
        End Set
    End Property

    Private _posicion As String = ""
    Public Property posicion() As String
        Get
            Return _posicion
        End Get
        Set(ByVal value As String)
            _posicion = value
        End Set
    End Property

    Private _descripcion_compra As String = ""
    Public Property descripcion_compra() As String
        Get
            Return _descripcion_compra
        End Get
        Set(ByVal value As String)
            _descripcion_compra = value
        End Set
    End Property


    Private _descripcion_proveedor As String = ""
    Public Property descripcion_proveedor() As String
        Get
            Return _descripcion_proveedor
        End Get
        Set(ByVal value As String)
            _descripcion_proveedor = value
        End Set
    End Property

    Private _numero_bulto As String = ""
    Public Property numero_bulto() As String
        Get
            Return _numero_bulto
        End Get
        Set(ByVal value As String)
            _numero_bulto = value
        End Set
    End Property

    Private _descripcion_bulto As String = ""
    Public Property descripcion_bulto() As String
        Get
            Return _descripcion_bulto
        End Get
        Set(ByVal value As String)
            _descripcion_bulto = value
        End Set
    End Property

    Private _unidad_medida As String = ""
    Public Property unidad_medida() As String
        Get
            Return _unidad_medida
        End Get
        Set(ByVal value As String)
            _unidad_medida = value
        End Set
    End Property

    Private _cantidad_entrega As String = ""
    Public Property cantidad_entrega() As String
        Get
            Return _cantidad_entrega
        End Get
        Set(ByVal value As String)
            _cantidad_entrega = value
        End Set
    End Property

    Private _cantidad_guia As String = ""
    Public Property cantidad_guia() As String
        Get
            Return _cantidad_guia
        End Get
        Set(ByVal value As String)
            _cantidad_guia = value
        End Set
    End Property

    Private _guia_proveedor As String = ""
    Public Property guia_proveedor() As String
        Get
            Return _guia_proveedor
        End Get
        Set(ByVal value As String)
            _guia_proveedor = value
        End Set
    End Property

    Private _numero_material As String = ""
    Public Property numero_material() As String
        Get
            Return _numero_material
        End Get
        Set(ByVal value As String)
            _numero_material = value
        End Set
    End Property

    Private _descripcion_material As String = ""
    Public Property descripcion_material() As String
        Get
            Return _descripcion_material
        End Get
        Set(ByVal value As String)
            _descripcion_material = value
        End Set
    End Property

    Private _condicion As String = ""
    Public Property condicion() As String
        Get
            Return _condicion
        End Get
        Set(ByVal value As String)
            _condicion = value
        End Set
    End Property

    Private _clase_material As String = ""
    Public Property clase_material() As String
        Get
            Return _clase_material
        End Get
        Set(ByVal value As String)
            _clase_material = value
        End Set
    End Property

    Private _numero_articulo_europeo As String = ""
    Public Property numero_articulo_europeo() As String
        Get
            Return _numero_articulo_europeo
        End Get
        Set(ByVal value As String)
            _numero_articulo_europeo = value
        End Set
    End Property

    Private _peso_bulto As String = ""
    Public Property peso_bulto() As String
        Get
            Return _peso_bulto
        End Get
        Set(ByVal value As String)
            _peso_bulto = value
        End Set
    End Property

    Private _peso_item As String = ""
    Public Property peso_item() As String
        Get
            Return _peso_item
        End Get
        Set(ByVal value As String)
            _peso_item = value
        End Set
    End Property

End Class

Public Class anulacion_guia_remision
    Private _numero_guia As String = ""
    Public Property numero_guia() As String
        Get
            Return _numero_guia
        End Get
        Set(ByVal value As String)
            _numero_guia = value
        End Set
    End Property
    Private _tipo_documento As String = ""
    Public Property tipo_documento() As String
        Get
            Return _tipo_documento
        End Get
        Set(ByVal value As String)
            _tipo_documento = value
        End Set
    End Property

    Private _ruc_empresa_emisora As String = ""
    Public Property ruc_empresa_emisora() As String
        Get
            Return _ruc_empresa_emisora
        End Get
        Set(ByVal value As String)
            _ruc_empresa_emisora = value
        End Set
    End Property

    Private _motivo As String = ""
    Public Property motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
        End Set
    End Property






End Class

