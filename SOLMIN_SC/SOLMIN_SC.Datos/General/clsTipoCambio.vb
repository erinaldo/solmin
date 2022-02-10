Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsTipoCambio

    Public Function Lista_TipoCambio(ByVal pdblFecha As Double) As Decimal
        Dim strTipoCambio As Decimal
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNFCMBO", pdblFecha)
        strTipoCambio = lobjSql.ExecuteScalar("SP_SOLSC_LISTA_TIPOCAMBIO_X_FECHA", lobjParams)
        Return strTipoCambio
    End Function
End Class
