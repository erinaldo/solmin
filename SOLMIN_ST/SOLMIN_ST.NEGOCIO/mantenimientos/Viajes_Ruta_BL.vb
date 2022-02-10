Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Namespace mantenimientos

    Public Class Viajes_Ruta_BL
        Public Function Insertar_Viaje_Ruta(ByVal objViaje_Ruta As Viaje_Ruta) As Integer
            Dim oDatos As New Viajes_Ruta_DAL
            Return oDatos.Insertar_Viaje_Ruta(objViaje_Ruta)
        End Function

        Public Function Actualizar_Viaje_Ruta(ByVal ObeViaje_Ruta As Viaje_Ruta) As Integer
            Dim oDatos As New Viajes_Ruta_DAL
            Return oDatos.Actualizar_Viaje_Ruta(ObeViaje_Ruta)
        End Function

        Public Function Listar_Viaje_Ruta(ByVal objViaje_Ruta As Viaje_Ruta) As List(Of Viaje_Ruta)
            Dim oDatos As New Viajes_Ruta_DAL
            Return oDatos.Listar_Viaje_Ruta(objViaje_Ruta)
        End Function

        Public Function Eliminar_Viaje_Ruta(ByVal ObeViaje_Ruta As Viaje_Ruta) As Integer
            Dim oDatos As New Viajes_Ruta_DAL
            Return oDatos.Eliminar_Viaje_Ruta(ObeViaje_Ruta)
        End Function
    End Class

End Namespace

