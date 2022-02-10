Imports SOLMIN_CTZ.Entidades
Public Class clsRangoTarifaXTarifaFlete
    Private oRangoTarifaXTarifaFlete As SOLMIN_CTZ.DATOS.clsRangoTarifaXTarifaFlete
    Sub New()
        oRangoTarifaXTarifaFlete = New SOLMIN_CTZ.DATOS.clsRangoTarifaXTarifaFlete
    End Sub
    Public Function Listar_Rango_Tarifa_X_Tarifa_Flete(ByVal objEntidad As RangoTarifaXTarifaFlete) As List(Of RangoTarifaXTarifaFlete)
        Return oRangoTarifaXTarifaFlete.Listar_Rango_Tarifa_X_Tarifa_Flete(objEntidad)
    End Function


    Public Function Actualizar_Rango_X_Tarifa_Flete(ByVal lista As List(Of RangoTarifaXTarifaFlete)) As Int32
        Return oRangoTarifaXTarifaFlete.Actualizar_Rango_X_Tarifa_Flete(lista)
    End Function

    Public Function Eliminar_Rango_X_Tarifa_Flete(ByVal objEntidad As RangoTarifaXTarifaFlete) As Boolean
        Return oRangoTarifaXTarifaFlete.Eliminar_Rango_X_Tarifa_Flete(objEntidad)
    End Function

End Class
