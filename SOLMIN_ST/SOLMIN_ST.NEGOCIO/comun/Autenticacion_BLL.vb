Imports SOLMIN_ST.DATOS

Public Class Autenticacion_BLL

    Public objDAL As New Autenticacion_DAL

    Public Function isAuthenticated(ByVal CadenaConexion As String) As Boolean
        Return objDAL.isAuthenticated(CadenaConexion)
    End Function

    Public Function WriteConnectionFile(ByVal CadenaConexion As String) As Boolean
        Return objDAL.WriteConfigFile(CadenaConexion)
    End Function

    Public Shared Function GetUserName() As String
        Dim objDAL1 As New Autenticacion_DAL
        Return objDAL1.GetUserName
    End Function

    Public Shared Function getReplacedConnectionString(ByVal key As String) As String
        Dim objDAL1 As New Autenticacion_DAL
        Return objDAL1.getReplacedConnectionString(key)
    End Function

End Class
