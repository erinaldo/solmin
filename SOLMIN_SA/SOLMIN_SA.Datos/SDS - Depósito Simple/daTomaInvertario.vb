Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daTomaInvertario

    Public Function ProcesarTomaInvertario(ByVal CCLNT As String) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Try
            objParam.Add("IN_CCLNT", CCLNT)
            oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_PROCESAR_TOMA_INVENTARIO", objParam)
        Catch ex As Exception
            oDt = Nothing
        End Try
        Return oDt
    End Function

    Public Function InicializarInvertario(ByVal CCLNT As String) As Integer
        Dim intResultado As Integer
        Dim objParam As New Parameter
        Dim objSqlManager As New SqlManager
        Try
            objParam.Add("IN_CCLNT", CCLNT)
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_INICIALIZAR_INVENTARIO", objParam)
            intResultado = 1
        Catch ex As Exception
            intResultado = -1
        End Try
        Return intResultado
    End Function

End Class
