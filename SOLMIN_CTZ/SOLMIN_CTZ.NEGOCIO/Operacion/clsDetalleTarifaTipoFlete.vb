Imports SOLMIN_CTZ.Entidades
Public Class clsDetalleTarifaTipoFlete
    Private oDetalleTarifaTipoFlete As SOLMIN_CTZ.DATOS.clsDetalleTarifaTipoFlete
    Sub New()
        oDetalleTarifaTipoFlete = New SOLMIN_CTZ.DATOS.clsDetalleTarifaTipoFlete
    End Sub
    Public Function Listar_Detalle_Tarifa_Tipo_Flete(ByVal objEntidad As DetalleTarifaTipoFlete) As List(Of DetalleTarifaTipoFlete)
        Return oDetalleTarifaTipoFlete.Listar_Detalle_Tarifa_Tipo_Flete(objEntidad)
    End Function

    Public Function Existe_Flete_Ruta(ByVal objEntidad As DetalleTarifaTipoFlete) As Integer
        Return oDetalleTarifaTipoFlete.Existe_Flete_Ruta(objEntidad)
    End Function

    Public Function Eliminar_Detalle_Tarifa_Tipo_Flete(ByVal objEntidad As DetalleTarifaTipoFlete) As Integer
        Return oDetalleTarifaTipoFlete.Eliminar_Detalle_Tarifa_Tipo_Flete(objEntidad)
    End Function

    Public Function Actualizar_Detalle_Tarifa_Tipo_Flete(ByVal objEntidad As DetalleTarifaTipoFlete) As Int32
        Return oDetalleTarifaTipoFlete.Actualizar_Detalle_Tarifa_Tipo_Flete(objEntidad)
    End Function

    Public Function Registrar_Detalle_Tarifa_Tipo_Flete(ByVal objEntidad As DetalleTarifaTipoFlete) As Int32
        Return oDetalleTarifaTipoFlete.Registrar_Detalle_Tarifa_Tipo_Flete(objEntidad)
    End Function
End Class
