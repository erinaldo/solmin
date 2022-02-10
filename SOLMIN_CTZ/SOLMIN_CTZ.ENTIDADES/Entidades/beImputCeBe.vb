Public Class beImputCeBe 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT

    Private _codCompania As String = String.Empty
    ''' <summary>
    ''' Código compañia
    ''' </summary>
    Public Property CodCompania() As String
        Get
            Return (_codCompania)
        End Get
        Set(ByVal value As String)
            _codCompania = value
        End Set
    End Property

    Private _codRegionVentaSAP As String = String.Empty
    ''' <summary>
    ''' Código region venta SAP
    ''' </summary>
    Public Property CodRegionVentaSAP() As String
        Get
            Return (_codRegionVentaSAP)
        End Get
        Set(ByVal value As String)
            _codRegionVentaSAP = value
        End Set
    End Property

    Private _codMacroServicioSAP As String = String.Empty
    ''' <summary>
    ''' Código macro servicio SAP
    ''' </summary>
    Public Property CodMacroServicioSAP() As String
        Get
            Return (_codMacroServicioSAP)
        End Get
        Set(ByVal value As String)
            _codMacroServicioSAP = value
        End Set
    End Property

    Private _codTipoServicioSAP As String = String.Empty
    ''' <summary>
    ''' Código tipo servicio SAP
    ''' </summary>
    Public Property CodTipoServicioSAP() As String
        Get
            Return (_codTipoServicioSAP)
        End Get
        Set(ByVal value As String)
            _codTipoServicioSAP = value
        End Set
    End Property

    Private _codTipoActivoSAP As String = String.Empty
    ''' <summary>
    ''' Código tipo activo SAP Propio
    ''' </summary>
    Public Property CodTipoActivoSAP() As String
        Get
            Return (_codTipoActivoSAP)
        End Get
        Set(ByVal value As String)
            _codTipoActivoSAP = value
        End Set
    End Property

    Private _codTipoActivoSAPT As String = String.Empty
    ''' <summary>
    ''' Código tipo activo SAP Tercero
    ''' </summary>
    Public Property CodTipoActivoSAP_T() As String
        Get
            Return (_codTipoActivoSAPT)
        End Get
        Set(ByVal value As String)
            _codTipoActivoSAPT = value
        End Set
    End Property

    Private _codSedeSAP As String = String.Empty
    ''' <summary>
    ''' Código sede SAP
    ''' </summary>
    Public Property CodSedeSAP() As String
        Get
            Return (_codSedeSAP)
        End Get
        Set(ByVal value As String)
            _codSedeSAP = value
        End Set
    End Property

    Private _codUnidadProdcutivaSAP As String = String.Empty
    ''' <summary>
    ''' Código unidad productiva SAP
    ''' </summary>
    Public Property CodUnidadProdcutivaSAP() As String
        Get
            Return (_codUnidadProdcutivaSAP)
        End Get
        Set(ByVal value As String)
            _codUnidadProdcutivaSAP = value
        End Set
    End Property

    Private _tipoCentroSAP As String = String.Empty
    ''' <summary>
    ''' Tipo centro SAP
    ''' </summary>
    Public Property TipoCentroSAP() As String
        Get
            Return (_tipoCentroSAP)
        End Get
        Set(ByVal value As String)
            _tipoCentroSAP = value
        End Set
    End Property


    Private _codigo As String = String.Empty
    ''' <summary>
    ''' Código
    ''' </summary>
    Public Property Codigo() As String
        Get
            Return (_codigo)
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Private _descripcion As String = String.Empty
    ''' <summary>
    ''' Descripción
    ''' </summary>
    Public Property Descripcion() As String
        Get
            Return (_descripcion)
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _codigoSAP As String = String.Empty
    ''' <summary>
    ''' Descripción
    ''' </summary>
    Public Property CodigoSAP() As String
        Get
            Return (_codigoSAP)
        End Get
        Set(ByVal value As String)
            _codigoSAP = value
        End Set
    End Property

    Private _tipoOrigen As String = String.Empty
    ''' <summary>
    ''' Tipo origen
    ''' </summary>
    Public Property TipoOrigen() As String
        Get
            Return (_tipoOrigen)
        End Get
        Set(ByVal value As String)
            _tipoOrigen = value
        End Set
    End Property
End Class
