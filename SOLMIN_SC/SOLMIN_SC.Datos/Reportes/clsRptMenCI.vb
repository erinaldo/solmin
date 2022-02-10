Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsRptMenCI
    Public Function dtRepMenCI(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSTPSRVA As String, ByVal PNNESTDO As Decimal, ByVal PSESTADO_EMB As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNNESTDO", PNNESTDO)
        lobjParams.Add("PSESTADO_EMB", PSESTADO_EMB)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_REPMENCI_AJUSTE", lobjParams)
        Return dt
    End Function
End Class
