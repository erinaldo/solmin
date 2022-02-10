Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Public Class Cotizacion_BLL
    Private objDatos As New Cotizacion_DAL

    Public Function Listar_Cotizaciones(ByVal lobjEntidad As Hashtable) As List(Of Cotizacion)
        Return objDatos.Listar_Cotizaciones(lobjEntidad)
    End Function
    Public Function Guardar_Cotizacion(ByVal objEntidad As Cotizacion) As List(Of Cotizacion)
        Return objDatos.Guardar_Cotizacion(objEntidad)
    End Function
    Public Function Modificar_Cotizacion(ByVal objEntidad As Cotizacion) As Double
        Return objDatos.Modificar_Cotizacion(objEntidad)
    End Function

    Public Function Reporte_Cotizacion(ByVal objEntidad As Hashtable) As List(Of Cotizacion)
        Return objDatos.Reporte_Cotizacion(objEntidad)
    End Function

    Public Function Eliminar(ByVal objEntidad As Cotizacion) As Double
        Return objDatos.Eliminar(objEntidad)
    End Function

    Public Function Buscar_Cotizacion(ByVal objEntidad As Cotizacion) As List(Of Cotizacion)
        Return objDatos.Buscar_Cotizacion(objEntidad)
  End Function

  Public Function Copiar_Cotizacion(ByVal objEntidad As Cotizacion) As Int32
    Return objDatos.Copiar_Cotizacion(objEntidad)
  End Function

End Class