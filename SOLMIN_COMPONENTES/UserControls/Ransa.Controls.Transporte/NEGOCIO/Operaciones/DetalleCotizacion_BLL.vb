

Public Class DetalleCotizacion_BLL

    Private objDatos As New DetalleCotizacion_DAL

    Public Function ListaDetalleCotizacion(ByVal lobjEntidad As Hashtable) As List(Of Detalle_Cotizacion)
        Return objDatos.ListaDetalleCotizacion(lobjEntidad)
    End Function

    Public Function ListaCotizacionPorAprobar(ByVal lobjEntidad As Hashtable) As List(Of Detalle_Cotizacion)
        Return objDatos.ListaCotizacionPorAprobar(lobjEntidad)
    End Function

    Public Function Guardar_Detalle_Cotizacion(ByVal lobjEntidad As Detalle_Cotizacion) As Detalle_Cotizacion
        Return objDatos.Guardar_Detalle_Cotizacion(lobjEntidad)
    End Function

    Public Function Modificar_Detalle_Cotizacion(ByVal lobjEntidad As Detalle_Cotizacion) As String
        Return objDatos.Modificar_Detalle_Cotizacion(lobjEntidad)
    End Function

    Public Function Eliminar(ByVal lobjEntidad As Detalle_Cotizacion) As Double
        Return objDatos.Eliminar(lobjEntidad)
    End Function

    Public Function Buscar_Detalle_Cotizacion(ByVal obe_Detalle_Cotizacion As Detalle_Cotizacion) As Detalle_Cotizacion
        Return objDatos.Buscar_Detalle_Cotizacion(obe_Detalle_Cotizacion)
    End Function
    

End Class
