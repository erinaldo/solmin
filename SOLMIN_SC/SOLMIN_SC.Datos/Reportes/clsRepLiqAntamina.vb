Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsRepLiqAntamina
    Public Function dtRepLiqAntamina(ByVal PSCCMPN As String, ByVal PNNUMOS As Double, ByVal PSTPSRVA As String) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNNUMOS", PNNUMOS)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_REPLIQANT_2", lobjParams)
        Return ds
    End Function

    Public Function dtLista_Factura(ByVal PNORSCI As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNORSCI", PNORSCI)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_FACT", lobjParams)

        Return dt
    End Function
End Class
