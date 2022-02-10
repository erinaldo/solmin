Imports System.Data
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class DbBridge

    Public objSql As New SqlManager

    Public Function GetTable(ByVal Stored As String, ByVal Parametros As List(Of KeyValuePair(Of String, String))) As DataTable

        Dim ldtb_Datos As New DataTable

        If Parametros Is Nothing Then
            ldtb_Datos = objSql.ExecuteDataTable(Stored, Nothing)
        Else
            Dim param As New Parameter
            For Each lstr_parametro As KeyValuePair(Of String, String) In Parametros
                param.Add(lstr_parametro.Key, lstr_parametro.Value)
            Next
            ldtb_Datos = objSql.ExecuteDataTable(Stored, param)
        End If

        Return ldtb_Datos

    End Function

    Public Function GetTable(ByVal Query As String) As DataTable
        Return objSql.ExecuteDataTable(Query)
    End Function
End Class
