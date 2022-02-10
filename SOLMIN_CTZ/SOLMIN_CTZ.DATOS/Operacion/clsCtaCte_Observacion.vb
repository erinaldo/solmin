Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades

Public Class clsCtaCte_Observacion
    Public Function Lista_CtaCte_Observacion(ByVal pobjCuentaCorriente As CtaCte_Observacion) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjCuentaCorriente.PSCCMPN)
        lobjParams.Add("PNCTPODC", pobjCuentaCorriente.CTPODC)
        lobjParams.Add("PNNDCCTC", pobjCuentaCorriente.NDCCTC)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_CTACTE_OBSERVACION", lobjParams)
        Return dt
    End Function
End Class
