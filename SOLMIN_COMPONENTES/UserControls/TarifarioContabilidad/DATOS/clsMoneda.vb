Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsMoneda
    Public Function Lista_Moneda() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_MONEDA", Nothing)
        Return dt
    End Function
End Class
