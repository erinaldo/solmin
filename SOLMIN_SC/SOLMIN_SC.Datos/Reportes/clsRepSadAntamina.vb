Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsRepSadAntamina
  Public Function dtRepSadAntamina(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSTPSRVA As String) As DataTable
    Dim dt As DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSCCMPN", PSCCMPN)
    lobjParams.Add("PNCCLNT", PNCCLNT)
    lobjParams.Add("PNFECINI", PNFECINI)
    lobjParams.Add("PNFECFIN", PNFECFIN)
    lobjParams.Add("PSTPSRVA", PSTPSRVA)
    dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPSADANT", lobjParams)
    Return dt
  End Function
End Class
