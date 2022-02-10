Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad

Public Class clsImpInfEmbarcador
    Private objPortalDetalle As SOLMIN_SC.Entidad.bePortalDetalle

    Public Function Lista_Datos_T005(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("IN_NORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_YRC_EMBARQUE_Q01", lobjParams)
        Return dt
    End Function

    Public Function Lista_Datos_T007(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("IN_NORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_YRC_ITEM_OC_Q01", lobjParams)
        Return dt
    End Function

    Public Function Lista_Datos_T008(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_NORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_YRC_CHECKPOINT_Q01", lobjParams)
        Return dt
    End Function

    Public Function Lista_Datos_T013(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("IN_NORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_YRC_BITACORA_Q01", lobjParams)
        Return dt
    End Function

    Public Function Lista_Cambiar_Status_T002(ByVal pdblEmbarque As Double, ByVal pstrAlmacen As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("IN_NORSCI", pdblEmbarque)
        lobjParams.Add("IN_STREGI", pstrAlmacen)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_YRC_T002_CAMBIAR_STATUS_OC", lobjParams)
        Return dt
    End Function

    Public Function Lista_Datos_T006(ByVal pdblEmbarque As Double) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("IN_NORSCI", pdblEmbarque)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_SA_YRC_T006_SUSTENTO_COSTO", lobjParams)
        Return ds
    End Function

    Public Sub Agregar_Cambio_Status(ByVal pdblEmbarque As Double)
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_AGREGAR_CAMBIO_STATUS", lobjParams)
       
    End Sub

    Public Function Lista_Status_Envio_Embarcador(ByVal pdblEmbarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNORSCI", pdblEmbarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_STATUS_ENVIO_EMBARCADOR", lobjParams)
        Return dt
    End Function

    Public Function Lista_Datos_T002_Actualizar_Status(ByVal pdblCliente As Double, ByVal pstrOC As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("IN_CCLNT", pdblCliente)
        lobjParams.Add("IN_NORCML", pstrOC)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SA_YRC_ITEMS_X_OC_Q01", lobjParams)
        Return dt
    End Function
    Public Function Obtener_Informacion_T002_OC_RECIBIDO(ByVal pdblCliente As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("IN_CCLNT", pdblCliente)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DETALLE_OC_OL", lobjParams)
        Return dt
    End Function
    Public Function Obtener_Informacion_T002_OC_EMBARQUE(ByVal pdblCliente As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("IN_CCLNT", pdblCliente)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DETALLE_OC_OL_EMBARQUE", lobjParams)
        Return dt
    End Function
    Public Function Obtener_Informacion_T002_OC_ALMACEN(ByVal objPD As SOLMIN_SC.Entidad.bePortalDetalle) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCLNT", objPD.PSCLIENTE_SOL)
       
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_DETALLE_OC_OL_ALMACEN", lobjParams)
        Return dt
    End Function

End Class
