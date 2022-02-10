Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsNoLaborable
    Public Function dtNoLaborables(ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNFECINI", pdblFecIni)
        lobjParams.Add("PNFECFIN", pdblFecFin)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_NOLABORABLE", lobjParams)
        Return dt
    End Function
End Class
