Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsBanco
    Public Function Lista_Banco() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_BANCOS", Nothing)
        Return dt
    End Function
End Class
