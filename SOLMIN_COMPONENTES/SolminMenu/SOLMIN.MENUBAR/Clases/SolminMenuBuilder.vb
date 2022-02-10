Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Imports System
Imports System.Text
Imports System.IO 
Imports System.Reflection

Public Class SolminMenuBuilder

    Dim objSqlManager As New SqlManager 

    Public Function Listar_Menu_Aplicacion(ByVal pAplicacion As String) As DataTable

        Dim dtbResultados As New DataTable

        Try
            Dim objParam As New Parameter
            objParam.Add("PSMMCAPL", pAplicacion)
            dtbResultados = objSqlManager.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_MENU_X_APLICACION", objParam)
        Catch : End Try

        Return dtbResultados

    End Function

    Public Function Listar_Menu(ByVal pUsuario As String, ByVal pPadre As String, ByVal pAplicacion As String) As DataTable

        Dim dtbResultados As New DataTable

        Try
            Dim objParam As New Parameter
            objParam.Add("PSMMCUSR", pUsuario)
            objParam.Add("PSMMCMNU", pPadre)
            objParam.Add("PSMMCAPL", pAplicacion)
            dtbResultados = objSqlManager.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_MENU_X_USUARIO", objParam)
        Catch : End Try

        Return dtbResultados

    End Function


    Public Function Listar_Formularios_Favoritos(ByVal pUsuario As String) As DataTable

        Dim dtbResultados As New DataTable

        Try
            Dim objParam As New Parameter
            objParam.Add("PSMMCUSR", pUsuario)
            dtbResultados = objSqlManager.ExecuteDataTable("SP_SOLMIN_SS_LISTAR_OPCIONES_FAVORITAS", objParam)
        Catch : End Try

        Return dtbResultados

    End Function 

    Public Sub Registrar_Log_Usuario(ByVal pUsuario As String, ByVal pAplicacion As String, ByVal pFormulario As String)

        Try
            Dim objParam As New Parameter
            objParam.Add("PSMMCAPL", pAplicacion)
            objParam.Add("PSMMCUSR", pUsuario)
            objParam.Add("PSMMNPVB", pFormulario)
            objParam.Add("PSFCHCRT", TodayNumeric)
            objParam.Add("PSHRACRT", NowNumeric)
            objParam.Add("PSCUSCRT", pUsuario)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SS_REGISTRAR_LOG", objParam)
        Catch : End Try

    End Sub

    Public Function getAppSetting(ByVal Nombre As String) As String
        Return Configuration.ConfigurationSettings.AppSettings(Nombre).ToString().Trim
    End Function



    Public Shared Function TodayNumeric() As String
        Return Today.Year & "" & IIf(Today.Month < 10, "0" & Today.Month, Today.Month) & "" & IIf(Today.Day < 10, "0" & Today.Day, Today.Day)
    End Function

    Public Shared Function NowNumeric() As String
        Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & "" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & "" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
    End Function

End Class
