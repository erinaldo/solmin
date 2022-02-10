Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsRepEntregaEmbAlm
    Public Function dtRepEntregaEmbAlm(ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPORTE_EMBARQUE_ALMACEN", lobjParams)
        Return dt
    End Function
End Class
