

Public Class ServicioCotizacion_BLL

    Dim objDataAccessLayer As New mantenimientos.ServicioCotizacion_DAL

    Public Function Listar_Servicio_Cotizacion_DropDownList(ByVal objentidad As mantenimientos.ServicioCotizacion) As DataTable
        Return objDataAccessLayer.Listar_Servicio_Cotizacion_DropDownList(objentidad)
    End Function


    Public Function Listar_Servicio_Cotizacion(ByVal objentidad As mantenimientos.ServicioCotizacion) As DataTable
        Return objDataAccessLayer.Listar_Servicio_Cotizacion(objentidad)
    End Function

End Class
