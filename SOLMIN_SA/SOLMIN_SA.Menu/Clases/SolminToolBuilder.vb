Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Imports System
Imports System.Text
Imports System.IO 
Imports System.Reflection

Public Class SolminToolBuilder

    Dim objSqlManager As New SqlManager

    Public Function Listar_Aplicacion_X_Usuario_Tool(ByVal IN_MMCAPL As String, ByVal IN_MMCUSR As String, ByVal IN_MMCMNU As String) As DataTable
        Dim odt As New DataTable()
        Try
            Dim objParam As New Parameter
            objParam.Add("IN_MMCUSR", IN_MMCUSR)
            objParam.Add("IN_MMCAPL", IN_MMCAPL)
            objParam.Add("IN_MMCMNU", IN_MMCMNU)
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_LISTAR_TOOL_X_APLICACION_USUARIO", objParam)
        Catch ex As Exception
        End Try
        Return odt
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
