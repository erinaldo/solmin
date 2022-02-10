

Public Class Acceso_Opciones_Usuario_BLL
  Private objDataAccessLayer As New Acceso_Opciones_Usuario_DAL

  Public Function Validar_Acceso_Opciones_Usuario(ByVal objetoParametro As Hashtable) As ClaseGeneral
    Return objDataAccessLayer.Validar_Acceso_Opciones_Usuario(objetoParametro)
  End Function

  Public Function Nombre_Usuario(ByVal objetoParametro As Hashtable) As String
    Return objDataAccessLayer.Nombre_Usuario(objetoParametro)
  End Function

End Class
