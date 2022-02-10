Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad
Public Class clsVapores
  Dim objDatos As New Datos.clsVapores

  Public Function Buscar_Vapores(ByVal oVapores As beVapores)
    Dim odaVapores As New Datos.clsVapores()
    Dim odtVapores As New DataTable
    odtVapores = odaVapores.Buscar_Vapores(oVapores)
    Return odtVapores
  End Function

  Public Function Registrar_Vapores(ByVal oVapores As beVapores)
    Dim odaVapores As New Datos.clsVapores()
    Return odaVapores.Registrar_Vapores(oVapores)
  End Function

  Public Function Eliminar_Vapores(ByVal CVPRCN As String) As Integer
    Return objDatos.Eliminar_Vapores(CVPRCN)
  End Function

  Public Function Restablecer_Vapores(ByVal CVPRCN As String) As Integer
    Return objDatos.Restablecer_Vapores(CVPRCN)
  End Function


  Public Function Actualizar_Vapores(ByVal oVapores As beVapores) As Integer
    Return objDatos.Actualizar_Vapores(oVapores)
  End Function

End Class
