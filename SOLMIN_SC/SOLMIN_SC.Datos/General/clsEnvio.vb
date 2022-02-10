Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsEnvio
    Public Function Lista_Forma_Envio() As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_TIPO_ENVIO", Nothing)
        Return dt
    End Function
End Class
