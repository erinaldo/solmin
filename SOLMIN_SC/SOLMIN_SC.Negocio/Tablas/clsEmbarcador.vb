Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad

Public Class clsEmbarcador
  Dim objDatos As New Datos.clsEmbarcador

  Public Function Buscar_Embarcador(ByVal oEmbarcador As beEmbarcador)
    Dim odaEmbarcador As New Datos.clsEmbarcador()
    Dim odtEmbarcador As New DataTable
    odtEmbarcador = odaEmbarcador.Buscar_Embarador(oEmbarcador)
    Return odtEmbarcador
  End Function

  Public Function Registrar_Embarcador(ByVal oEmbarcador As beEmbarcador) As Integer
    Dim odaEmbarcador As New Datos.clsEmbarcador()
    Return odaEmbarcador.Registrar_Embarcador(oEmbarcador)
  End Function

  Public Function Eliminar_Embarcador(ByVal CAGNCR As Int32) As Integer
    Return objDatos.Eliminar_Embarcador(CAGNCR)
  End Function

  Public Function Restablecer_Embarcador(ByVal CAGNCR As Int32) As Integer
    Return objDatos.Restablecer_Embarcador(CAGNCR)
  End Function

  Public Function Actualizar_Embarcador(ByVal oEmbarcador As beEmbarcador) As Integer
    Return objDatos.Actualizar_Embarcador(oEmbarcador)
  End Function
End Class
