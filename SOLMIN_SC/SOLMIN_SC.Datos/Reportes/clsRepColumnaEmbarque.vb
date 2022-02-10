Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsRepColumnaEmbarque
    Public Function Listar_Resumen_Mensual_Embarque(ByVal obeResumenMensual As beResumenMensual) As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim ods As New DataSet
        lobjParams.Add("PNCCLNT", obeResumenMensual.PNCCLNT)
        lobjParams.Add("PNFECHAINI", obeResumenMensual.PNFECHA_INI)
        lobjParams.Add("PNFECHAFIN", obeResumenMensual.PNFECHA_FIN)
        lobjParams.Add("PSESTADO", obeResumenMensual.PSESTADO)
        lobjParams.Add("PSLISTREGIMEN", obeResumenMensual.PSLISTREGIMEN)
        lobjParams.Add("PNNORSCI", obeResumenMensual.PNNORSCI)
        lobjParams.Add("PNPNNMOS", obeResumenMensual.PNPNNMOS)
        lobjParams.Add("PNCPRVCL", obeResumenMensual.PNCPRVCL)
    lobjParams.Add("PSNORCML", obeResumenMensual.PSNORCML)
    lobjParams.Add("PSTPSRVA", obeResumenMensual.PSTPSRVA)

        ods = lobjSql.ExecuteDataSet("SP_SOLSC_RESUMEN_MENSUAL_EMBARQUE_ADUANAS", lobjParams)
        ods.Tables(0).TableName = "DT_RESUMEN"
        ods.Tables(1).TableName = "DT_DOCUMENTOS"
        ods.Tables(2).TableName = "DT_CHK_EMB"
        ods.Tables(3).TableName = "DT_CHK_CARGA_INTER"
        ods.Tables(4).TableName = "DT_COSTOS_EMB"
        ods.Tables(5).TableName = "DT_ITEM_EMB"
        ods.Tables(6).TableName = "DT_COSTOS_EMB_ITEM"

        Return ods
    End Function
End Class
