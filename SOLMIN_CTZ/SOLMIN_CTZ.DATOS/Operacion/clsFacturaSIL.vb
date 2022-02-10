Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Public Class clsFacturaSIL

    Public Function Lista_Facturacion_SIL(ByVal pobjFacturaSIL As FacturaSIL) As DataTable

        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFacturaSIL.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjFacturaSIL.PSCDVSN)
        lobjParams.Add("PNCCLNT", pobjFacturaSIL.CCLNT)
        lobjParams.Add("FE_INI", pobjFacturaSIL.F_INICIO)
        lobjParams.Add("FE_FIN", pobjFacturaSIL.F_FINAL)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_FACTURACION_SIL", lobjParams)
        Return dt
    End Function
    Public Function Lista_Facturacion_SIL_Detalle(ByVal pobjFacturaSIL As FacturaSIL) As DataTable

        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", pobjFacturaSIL.PSCCMPN)
        lobjParams.Add("PSCDVSN", pobjFacturaSIL.PSCDVSN)
        lobjParams.Add("PNNOPRCN", pobjFacturaSIL.NOPRCN)
        dt = lobjSql.ExecuteDataTable("SP_SOLCT_LISTA_FACTURACION_SIL_DETALLE", lobjParams)
        Return dt
    End Function

End Class
