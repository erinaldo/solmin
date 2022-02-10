Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsPrioridad
    Public Function Lista_Prioridad() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_PRIORIDAD", Nothing)
        Return dt
    End Function
End Class
