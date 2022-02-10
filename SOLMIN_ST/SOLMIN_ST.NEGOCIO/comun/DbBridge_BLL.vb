Imports SOLMIN_ST.DATOS

Public Class DbBridge_BLL

    Private DbBridge_DAL As New DbBridge

    Public Function GetTable(ByVal Stored As String, ByVal Parametros As List(Of KeyValuePair(Of String, String))) As DataTable
        Return DbBridge_DAL.GetTable(Stored, Parametros)
    End Function

    Public Function GetTable(ByVal Query As String) As DataTable
        Return DbBridge_DAL.GetTable(Query)
    End Function

End Class
