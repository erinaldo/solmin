Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsDespacho
    Public Function Lista_Despacho() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DESPACHO", Nothing)
        Return dt
    End Function
End Class
