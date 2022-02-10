Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsRepRatioLandedCost
    Public Function dtRepListaSeguimiento(ByVal PSCCMPN As String, ByVal PNCCLNT As Double, ByVal PNFECINI As Double, ByVal PNFECFIN As Double, ByVal PSTPSRVA As String, ByVal NESTDO As Decimal) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNFECINI", PNFECINI)
        lobjParams.Add("PNFECFIN", PNFECFIN)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PNNESTDO", NESTDO)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REP_RATIO_LAND_COST", lobjParams)
        ds.Tables(0).TableName = "DTOPERACION"
        ds.Tables(1).TableName = "DTCHECKPOINT"
        ds.Tables(2).TableName = "DTORDENCOMPRA"
        ds.Tables(3).TableName = "DTCOSTOS"
        ds.Tables(4).TableName = "DTCONTENEDOR"
        Return ds.Copy
    End Function

End Class
