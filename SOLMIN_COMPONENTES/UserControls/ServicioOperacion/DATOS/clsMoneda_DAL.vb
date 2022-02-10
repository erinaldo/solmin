

Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsMoneda_DAL


    Public Function Lista_Moneda() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_LISTA_MONEDA", Nothing)
        Return dt
    End Function

  
End Class
