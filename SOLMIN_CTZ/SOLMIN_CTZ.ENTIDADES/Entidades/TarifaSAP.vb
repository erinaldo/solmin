'<[AHM]>
Public Class TarifaSAP

    Public _CodMaterial As String = ""
    Public Property CodMaterial() As String
        Get
            Return _CodMaterial
        End Get
        Set(ByVal value As String)
            _CodMaterial = value
        End Set
    End Property

    Public _CodRegionVenta As String = ""
    Public Property CodRegionVenta() As String
        Get
            Return _CodRegionVenta
        End Get
        Set(ByVal value As String)
            _CodRegionVenta = value
        End Set
    End Property

    Public _CanalDistribucion As String = ""
    Public Property CanalDistribucion() As String
        Get
            Return _CanalDistribucion
        End Get
        Set(ByVal value As String)
            _CanalDistribucion = value
        End Set
    End Property

    Public _EsValida As Boolean = False
    Public Property EsValida() As Boolean
        Get
            Return _EsValida
        End Get
        Set(ByVal value As Boolean)
            _EsValida = value
        End Set
    End Property

    Public _Observaciones As String = ""
    Public Property Observaciones() As String
        Get
            Return _Observaciones
        End Get
        Set(ByVal value As String)
            _Observaciones = value
        End Set
    End Property

End Class
'</[AHM]>