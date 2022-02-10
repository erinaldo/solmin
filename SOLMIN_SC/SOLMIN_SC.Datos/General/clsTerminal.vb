Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsTerminal
    Public Function Lista_Terminal() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_TERMINAL", Nothing)
        Return dt
    End Function
End Class
