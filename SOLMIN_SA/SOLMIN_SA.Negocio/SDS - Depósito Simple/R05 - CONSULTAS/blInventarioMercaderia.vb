Imports RANSA.DATA
Imports RANSA.TYPEDEF
Public Class blInventarioMercaderia
    Public Function ListarInventarioMercaderiaxSerie(ByVal obeMercaderia As beMercaderia) As DataSet
        Return New daInventarioMercaderia().ListarInventarioMercaderiaxSerie(obeMercaderia)
    End Function
    Public Function ListarMercaderiaxClientexGrupoxFamilia(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Return New daInventarioMercaderia().ListarMercaderiaxClientexGrupoxFamilia(obeMercaderia)
    End Function
    Public Function ListarInventarioMercaderiaxUbicacion(ByVal obeMercaderia As beMercaderia) As DataSet
        Return New daInventarioMercaderia().ListarInventarioMercaderiaxUbicacion(obeMercaderia)
    End Function
    Public Function Lista_Orden_Servicio_por_Cliente(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Return New daInventarioMercaderia().Lista_Orden_Servicio_por_Cliente(obeMercaderia)
    End Function

    Public Function Lista_Solicitud_Servicio_por_Cliente(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Return New daInventarioMercaderia().Lista_Solicitud_Servicio_por_Cliente(obeMercaderia)
    End Function

    Public Function Lista_Solicitud_Servicio_por_Lote(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Return New daInventarioMercaderia().Lista_Solicitud_Servicio_por_Lote(obeMercaderia)
    End Function

    Public Function Lista_Solicitud_Servicio_Pendiente_por_Lote(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Return New daInventarioMercaderia().Lista_Solicitud_Servicio_Pendiente_por_Lote(obeMercaderia)
    End Function

    Public Function Lista_Movimiento_por_Posicion(ByVal obeAlmacen As beAlmacen) As DataSet
        Return New daInventarioMercaderia().Lista_Movimiento_por_Posicion(obeAlmacen)
    End Function
    Public Function Lista_Inventario_por_Posicion(ByVal obeAlmacen As beAlmacen) As DataSet
        Return New daInventarioMercaderia().Lista_Inventario_por_Posicion(obeAlmacen)
    End Function
    Public Function Lista_Solicitud_Servicio_por_Cliente_Exportar(ByVal obeMercaderia As beMercaderia) As List(Of beMercaderia)
        Return New daInventarioMercaderia().Lista_Solicitud_Servicio_por_Cliente_Exportar(obeMercaderia)
    End Function
End Class
