Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data

Public Class Autenticacion_DAL

    Public objSql As New SqlManager
 
    Public Function isAuthenticated(ByVal CadedaConexion As String) As Boolean
        Return objSql.Probar_Conexion(CadedaConexion)
    End Function

    Public Function WriteConfigFile(ByVal CadenaConexion As String) As Boolean
        Dim lbool_cadena As Boolean = False
        Try
            ConfigurationWizard.WriteConfigFile(CadenaConexion)
            lbool_cadena = True
        Catch ex As Exception
            lbool_cadena = False
        End Try
        Return lbool_cadena
    End Function

    Public Function GetUserName() As String
        Return ConfigurationWizard.UserName
    End Function

    Public Function getReplacedConnectionString(ByVal Key As String) As String
        Dim cadcon As String = Configuration.ConfigurationSettings.AppSettings(Key).ToString()
        cadcon = cadcon.Replace("$USER", ConfigurationWizard.UserName)
        cadcon = cadcon.Replace("$PASS", ConfigurationWizard.Password)
        Return cadcon
    End Function

    Public Shared Function GetLibrary(ByVal CCMPN As String) As String
        Dim lstr_libreria As String = ""
        Dim dtb As New DataTable
        dtb = New DbBridge().GetTable("SP_SOLMIN_ST_LISTAR_LIBRERIAS_AS400", Nothing)
        For i As Integer = 0 To dtb.Rows.Count - 1
            If dtb.Rows(i).Item("CCMPN").ToString = CCMPN Then
                lstr_libreria = dtb.Rows(i).Item("CCLBR").ToString
                Exit For
            End If
        Next
        Return lstr_libreria
    End Function

End Class
