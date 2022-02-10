
 
Namespace Operaciones

    Public Class OrdenServicio_BLL

        Dim objDataAccessLayer As New OrdenServicio_DAL

        Sub New()
        End Sub

        Public Function Listar_Ordenes_Servicio(ByVal objParametros As List(Of String)) As List(Of OrdenServicioTransporte)
            Return objDataAccessLayer.Listar_Ordenes_Servicio_x_Cliente(objParametros)
        End Function

        Public Function Obtener_Orden_Servicio(ByVal objEntidad As OrdenServicioTransporte) As OrdenServicioTransporte
            Return objDataAccessLayer.Obtener_Orden_Servicio(objEntidad)
        End Function

        Public Function GenerarOS(ByVal lobjEntidad As Hashtable) As Double
            Return objDataAccessLayer.GenerarOS(lobjEntidad)
        End Function

        Public Function Cerrar_OS(ByVal obeOrdenServicio As OrdenServicioTransporte) As Double
            Return objDataAccessLayer.Cerrar_OS(obeOrdenServicio)
        End Function

        Public Function GenerarOSxDetalleCotizacion(ByVal lobjEntidad As Hashtable) As Double
            Return objDataAccessLayer.GenerarOSxDetalleCotizacion(lobjEntidad)
        End Function

        Public Function Cerrar_OSxDetalleCotizacion(ByVal obeOrdenServicio As OrdenServicioTransporte) As Double
            Return objDataAccessLayer.CerrarOSxDetalleCotizacion(obeOrdenServicio)
        End Function
    End Class

End Namespace