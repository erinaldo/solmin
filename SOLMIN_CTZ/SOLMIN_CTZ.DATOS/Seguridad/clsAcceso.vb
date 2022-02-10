Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data.Common
Imports System.Data

Public Class clsAcceso
    Public Function Verifica_Archivo() As Boolean
        Return ConfigurationWizard.ConnectionFileExists()
    End Function

    Public Function Valida_Acceso(ByVal pstrUser As String, ByVal pstrPass As String) As Boolean
        Try
            'Verifica que el usuario tenga permiso para conectarse al AS-400
            Dim objDBase_iSeries As New SqlManager
            Dim ConnStr As String

            'Verificando el tipo de origen de datos,escoge el servidor
            ' a controlar la autentificación
            ConnStr = Configuration.ConfigurationSettings.AppSettings("DataBase").ToString()

            'reemplazando en la cadena, el usuario y password
            ConnStr = ConnStr.Replace("$USER", pstrUser)
            ConnStr = ConnStr.Replace("$PASS", pstrPass)

            'Estableciendo la autentificacion
            Dim cnx As Data.IDbConnection
            cnx = DirectCast(objDBase_iSeries.IConectar(ConnStr), IDbConnection)
            cnx.Open()
            cnx.Close()

            'Guardando cadena de conexión en archivo
            ConfigurationWizard.WriteConfigFile(ConnStr)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub Destruir()
        'Elimina todos los objetos creados en memoria
        ConfigurationWizard.DeleteConfig()
    End Sub
End Class
