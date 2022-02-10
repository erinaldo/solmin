Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsTipoCarga
    Public Function Lista_Tipo_Carga() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_TIPO_CARGA", Nothing)
        Return dt
    End Function
End Class
