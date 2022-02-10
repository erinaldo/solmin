Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsZona
    Public Function Lista_Zona() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_ZONA", Nothing)
        Return dt
    End Function
End Class
