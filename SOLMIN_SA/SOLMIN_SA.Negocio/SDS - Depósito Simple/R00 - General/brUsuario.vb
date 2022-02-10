Imports RANSA.DATA
Imports RANSA.TypeDef
Public Class brUsuario
    Public Function Validar_Usuario_Autorizado(ByVal objetoParametro As Hashtable) As beUsuario
        Return New daUsuario().Validar_Usuario_Autorizado(objetoParametro)
    End Function
    Public Function getAppSetting(ByVal Nombre As String) As String
        Return New daUsuario().getAppSetting(Nombre)
    End Function
End Class
