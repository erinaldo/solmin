Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsCtaCta_Venta
    Public Function Lista_CtaCte_Venta(ByVal pobjCuentaCorriente As CtaCte_Venta) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PNCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PNNDCCTC", pobjCuentaCorriente.NDCCTC)

    dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CTACTE_VENTAS_1", lobjParams)
        Return dt
    End Function
End Class
