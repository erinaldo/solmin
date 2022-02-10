Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsVapor
    Public Function Lista_Vapor() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_VAPOR", Nothing)
        Return dt
    End Function
End Class
