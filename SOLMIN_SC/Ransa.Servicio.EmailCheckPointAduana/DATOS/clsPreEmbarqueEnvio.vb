Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class clsPreEmbarqueEnvio
    Public Function Listar_Datos_Adicionales_Envios_CHK_PreEmb(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PNCCLNT", obeOrdenPreEmbarcarda.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenPreEmbarcarda.PSNORCML)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_DATOS_ADICIONALES_ENVIO_EMAIL_CHK_PRE_EMB", lobjParams)
        Return odt
    End Function
    Public Function ListarItemsXOrdenCompraParcial_Datos_Envios_CHK_PreEmb(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PSCCMPN", obeOrdenPreEmbarcarda.PSCCMPN)
        lobjParams.Add("PNCCLNT", obeOrdenPreEmbarcarda.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenPreEmbarcarda.PSNORCML)
        lobjParams.Add("PNNRPARC", obeOrdenPreEmbarcarda.PNNRPARC)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_ITEMS_X_ORDEN_COMPRA_PARCIAL_DATOS_ENVIO_EMAIL", lobjParams)
        Return odt
    End Function
    Public Function ListarCheckPointXOrdenCompraParcial(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PSCCMPN", obeOrdenPreEmbarcarda.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeOrdenPreEmbarcarda.PSCDVSN)
        lobjParams.Add("PNCCLNT", obeOrdenPreEmbarcarda.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenPreEmbarcarda.PSNORCML)
        lobjParams.Add("PNNRPARC", obeOrdenPreEmbarcarda.PNNRPARC)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_CHECKPOINT_X_ITEMS_X_ORDEN_COMPRA_PARCIAL", lobjParams)
        Return odt
    End Function
End Class
