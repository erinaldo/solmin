Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsRegionVenta
    Public Function Lista_RegionVenta() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSMMCUSR", ConfigurationWizard.UserName)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_REGION_VENTA_CTACTE", lobjParams)
        Return dt
    End Function
  

End Class