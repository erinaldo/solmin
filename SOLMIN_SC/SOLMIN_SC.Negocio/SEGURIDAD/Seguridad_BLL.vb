Imports SOLMIN_sc.DATOS
Imports System.Data
Imports SOLMIN_sc.Entidad

Public Class Seguridad_BLL

    Dim objDao As New Seguridad_DAL

    Public Function IsValid(ByVal ConnStr As String) As Boolean
        Return objDao.IsValid(ConnStr)
    End Function

    Public Function Obtener_Datos_Usuario(ByVal lstr_usuario As String) As DataTable
        Return objDao.Obtener_Datos_Usuarios(lstr_usuario)
    End Function

    Public Function Validar_Acceso_Opciones_Usuario(ByVal objetoParametro As Hashtable) As Acceso_BE
        Dim oAccesoDAL As New Acceso_DAL
        Return oAccesoDAL.Validar_Acceso_Opciones_Usuario(objetoParametro)
    End Function

    Public Function getAppSetting(ByVal Nombre As String) As String
        Dim oAccesoDAL As New Acceso_DAL
        Return oAccesoDAL.getAppSetting(Nombre)
    End Function
End Class
