Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos

  Public Class ConfiguracionVehicular_BLL
    Dim objDataAccessLayer As New ConfiguracionVehicular_DAL

    Public Function Registrar_Configuracion_Vehicular(ByVal objEntidad As ConfiguracionVehicular) As ConfiguracionVehicular
      Return objDataAccessLayer.Registrar_Configuracion_Vehicular(objEntidad)
    End Function

    Public Function Listar_Configuracion_Vehicular(ByVal objetoParametro As Hashtable) As List(Of ConfiguracionVehicular)
      Try
        Return objDataAccessLayer.Listar_Configuracion_Vehicular(objetoParametro)
      Catch
        Return New List(Of ConfiguracionVehicular)
      End Try
    End Function
  End Class

End Namespace


