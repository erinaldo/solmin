Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class clsMoneda
    Public Function Lista_Moneda() As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager

        dt = lobjSql.ExecuteDataTable("SP_SOLSC_MONEDA", Nothing)
        Return dt
    End Function

    Public Function Lista_Tipo_Cambio(ByVal pdblTipoMoneda As Double, ByVal psFechaCambio As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCMNDA1", pdblTipoMoneda)
        lobjParams.Add("PNFCMBO", psFechaCambio)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_TIPO_CAMBIO", lobjParams)
        Return dt
    End Function
End Class
