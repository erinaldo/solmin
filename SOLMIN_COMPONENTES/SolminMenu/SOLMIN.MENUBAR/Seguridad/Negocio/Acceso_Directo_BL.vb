
Imports System.Collections.Generic

Public Class Acceso_Directo_BL
  Private objDataAccessLayer As New Acceso_Directo_DAL
  Public Function Registra_Acceso_Directo(ByVal objEntidad As Acceso_DirectoBE) As Integer
    Return objDataAccessLayer.Registrar_AccesoDirecto(objEntidad)
  End Function
  Public Function Activa_Acceso_Directo(ByVal objEntidad As Acceso_DirectoBE) As Integer
    Return objDataAccessLayer.Activar_AccesoDirecto(objEntidad)
  End Function
  Public Function Elimina_Acceso_Directo(ByVal objEntidad As Acceso_DirectoBE) As Integer
    Return objDataAccessLayer.Eliminar_AccesoDirecto(objEntidad)
  End Function
  Public Function Lista_Acceso_Directo() As List(Of Acceso_DirectoBE)
    Try
      Return objDataAccessLayer.Listar_AccesoDirecto()
    Catch
      Return New List(Of Acceso_DirectoBE)
    End Try
  End Function
End Class
