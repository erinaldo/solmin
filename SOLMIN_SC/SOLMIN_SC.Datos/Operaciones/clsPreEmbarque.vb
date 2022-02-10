Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsPreEmbarque
    Public Function Busca_Nro_Parcial(ByVal pdblCli As Double, ByVal pstrOC As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PCNORCML", pstrOC)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_BUSCA_NRO_PARCIAL", lobjParams)
        Return dt
    End Function

    Public Function Mantenimiento_PreEmbarque(ByVal PSCCMPN As String, ByVal pstrTipo As String, ByVal pdblCliente As Double, ByVal pstrOC As String, ByVal pdblPreEmb As Double, ByVal pdblItem As Double, ByVal pstrSubItem As String, ByVal pdblParcial As Double, ByVal pdblCant As Double, ByVal pstrEstado As String, ByVal PSCDVSN As String, ByVal PNCPLNDV As Decimal) As Decimal
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSTIPO", pstrTipo)
        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSNORCML", pstrOC)
        lobjParams.Add("PNNRPEMB", pdblPreEmb, ParameterDirection.Output)
        lobjParams.Add("PNNRITOC", pdblItem)
        lobjParams.Add("PSSBITOC", pstrSubItem)
        lobjParams.Add("PNNRPARC", pdblParcial)
        lobjParams.Add("PNQRLCSC", pdblCant)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PSSESTRG", pstrEstado)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNCPLNDV", PNCPLNDV)

        lobjSql.ExecuteNonQuery("SP_SOLSC_MANT_PREEMBARQUE", lobjParams)
        pdblPreEmb = lobjSql.ParameterCollection("PNNRPEMB")
        Return pdblPreEmb

    End Function

    Public Function Lista_PreEmbarque(ByVal pdblCli As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCli)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_PREEMBARQUE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Detalle_PreEmbarque(ByVal pdblCli As Double, ByVal pstrOC As String, ByVal pdblParcial As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PCNORCML", pstrOC)
        lobjParams.Add("PNNRPARC", pdblParcial)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_DETALLE_PREEMBARQUE", lobjParams)
        Return dt
    End Function

    Public Sub Elimina_PreEmbarque(ByVal NRPEMB As Decimal, ByVal CCLNT As Decimal)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRPEMB", NRPEMB)
        lobjParams.Add("PNCCLNT", CCLNT)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ELIMINA_PREEMBARQUE", lobjParams)
    End Sub

    Public Function Total_Item_PreEmbarque(ByVal pdblCli As Double, ByVal pstrOC As String, ByVal pdblParcial As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PCNORCML", pstrOC)
        lobjParams.Add("PNNRPARC", pdblParcial)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_TOTAL_ITEM_PREEMBARQUE", lobjParams)
        Return dt
    End Function

    Public Function Total_Item_OC(ByVal pdblCli As Double, ByVal pstrOC As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PCNORCML", pstrOC)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_TOTAL_ITEM_OC", lobjParams)
        Return dt
    End Function


    Public Function Crear_Embarque(ByVal PSCCMPN As String, ByVal PSCDVSN As String, ByVal pdblCliente As Double, ByVal PSTPSRVA As String, ByVal PNCPLNDV As Decimal) As DataTable
        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager
        Dim dt As DataTable
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PSCDVSN", PSCDVSN)
        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSTPSRVA", PSTPSRVA)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNCPLNDV", PNCPLNDV)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_CREAR_EMBARQUE", lobjParams)
        Return dt
    End Function

    Public Sub Embarcar_PreEmbarque(ByVal pdblEmbarque As Double, ByVal pdblCliente As Double, ByVal pstrOC As String, ByVal pdblParcial As Double, ByVal pdblItem As Double, ByVal pdblPreembarque As Double, ByVal pdblCantidad As Double, ByVal pstrSubItem As String)

        Dim lobjParams As New Parameter
        Dim lobjSql As New SqlManager

        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PSNORCML", pstrOC)
        lobjParams.Add("PNNRPARC", pdblParcial)
        lobjParams.Add("PNNRITOC", pdblItem)
        lobjParams.Add("PSSBITOC", pstrSubItem)
        lobjParams.Add("PNNRPEMB", pdblPreembarque)
        lobjParams.Add("PNQRLCSC", pdblCantidad)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_EMBARCAR_PREEMBARQUE", lobjParams)
      
    End Sub

    Public Sub Act_Datos_Embarque(ByVal pdblEmbarque As Double, ByVal pdblCliente As Double, ByVal pstrOC As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PNNORSCI", pdblEmbarque)
        lobjParams.Add("PSNORCML", pstrOC)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_EMBARQUE_PREEMBARQUE", lobjParams)
      
    End Sub


    Public Function Lista_Observacion_PreEmbarque(ByVal dblPreembarque As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRPEMB", dblPreembarque)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_OBSERVACION_PREEMBARQUE", lobjParams)
        Return dt
    End Function

    Public Sub Eliminar_Observaciones(ByVal pdblPreembarque As Double)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRPEMB", pdblPreembarque)
        lobjSql.ExecuteNonQuery("SP_SOLSC_BORRAR_PREEMB_OBS", lobjParams)
       
    End Sub

    Public Sub Eliminar_Observacion(ByVal pdblNroItem As Double, ByVal pdblPreembarque As Double)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRITEM", pdblNroItem)
        lobjParams.Add("PNNRPEMB", pdblPreembarque)
        lobjSql.ExecuteNonQuery("SP_SOLSC_BORRAR_PREEMB_OBS2", lobjParams)
      
    End Sub


    Public Sub Actualiza_Observaciones(ByVal pdblPreembarque As Double, ByVal pdblFecha As Double, ByVal pstrObs As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRPEMB", pdblPreembarque)
        lobjParams.Add("PNTFCOBS", pdblFecha)
        lobjParams.Add("PSTOBS", pstrObs)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_PREEMB_OBS", lobjParams)
       
    End Sub

    Public Sub Modificar_Observacion(ByVal pdblPreembarque As Double, ByVal pdblNroItem As Double, ByVal pdblFecha As Double, ByVal pstrObs As String)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRPEMB", pdblPreembarque)
        lobjParams.Add("PNNRITEM", pdblNroItem)
        lobjParams.Add("PNTFCOBS", pdblFecha)
        lobjParams.Add("PSTOBS", pstrObs)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_MOD_PREEMB_OBS", lobjParams)
       
    End Sub
    Public Function Listar_Observacion(ByVal pdblPreembarque As Double, ByVal pdblNroItem As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNNRPEMB", pdblPreembarque)
        lobjParams.Add("PNNRITEM", pdblNroItem)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_SEL_PREEMB_OBS", lobjParams)
        Return dt

    End Function

  
    Public Function Listar_Seguimiento_Internacional_ba1(ByVal pstrTipo As String, ByVal pdblCli As Double, ByVal pstrProv As String, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double, ByVal pstrOC As String, ByVal pstrMTrans As String, ByVal pstrPais As String, ByVal pstrRef As String, ByVal pstrSeguimiento As String, ByVal pstrEmbarque As String, ByVal pstrEstado_Embarcado As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSTIPO", pstrTipo)
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PSCPRVCL", pstrProv)
        lobjParams.Add("PNFCINI", pdblFecIni)
        lobjParams.Add("PNFFIN", pdblFecFin)
        lobjParams.Add("PSNORCML", pstrOC)
        lobjParams.Add("PSCMEDTR", pstrMTrans)
        lobjParams.Add("PSCPAIS", pstrPais)
        lobjParams.Add("PSNREFCL", pstrRef)
        lobjParams.Add("PSSEGUI", pstrSeguimiento)
        lobjParams.Add("PSNORSCI", pstrEmbarque)
        lobjParams.Add("PSSESTRG", pstrEstado_Embarcado)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_SEGUIMIENTO_INTERNACIONAL_ba1", lobjParams)
        Return dt

    End Function

    Public Function Listar_Seguimiento_Internacional_x_OrdenCompra_Parcial(ByVal obeFiltro As beSeguimientoCargaFiltro) As DataSet
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", obeFiltro.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeFiltro.PSCDVSN)

        lobjParams.Add("PNCCLNT", obeFiltro.PNCCLNT)
        lobjParams.Add("PSCPRVCL", obeFiltro.PSCPRVCL)
        lobjParams.Add("PNFCINI", obeFiltro.PNFECINI)
        lobjParams.Add("PNFFIN", obeFiltro.PNFECFIN)
        lobjParams.Add("PSNORCML", obeFiltro.PSNORCML)
        lobjParams.Add("PSCMEDTR", obeFiltro.PSCMEDTR)
        lobjParams.Add("PSCPAIS", obeFiltro.PSCPAIS)
        lobjParams.Add("PSNREFCL", obeFiltro.PSNREFCL)
        lobjParams.Add("PNCPLNDV", obeFiltro.PNCPLNDV)

        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_SEGUIMIENTO_INTERNACIONAL_BA1_REVISION", lobjParams)
        ds.Tables(0).TableName = "dtPreEmbarque"
        ds.Tables(1).TableName = "dtChkPreEmbarque"
        ds.Tables(2).TableName = "dtObsPreEmbarque"
        ds.Tables(3).TableName = "dtDatosAdicionPreEmbarque"
        Return ds.Copy

    End Function



    Public Function Listar_Seguimiento_Internacional_Rpt_OC_Items(ByVal obeFiltro As beSeguimientoCargaFiltro) As DataSet

        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obeFiltro.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeFiltro.PSCDVSN)
        lobjParams.Add("PNCCLNT", obeFiltro.PNCCLNT)
        lobjParams.Add("PSCPRVCL", obeFiltro.PSCPRVCL)
        lobjParams.Add("PNFCINI", obeFiltro.PNFECINI)
        lobjParams.Add("PNFFIN", obeFiltro.PNFECFIN)
        lobjParams.Add("PSNORCML", obeFiltro.PSNORCML)
        lobjParams.Add("PSCMEDTR", obeFiltro.PSCMEDTR)
        lobjParams.Add("PSCPAIS", obeFiltro.PSCPAIS)
        lobjParams.Add("PSNREFCL", obeFiltro.PSNREFCL)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_LISTA_DATOS_RPT_ITEM_SEGUIMIENTO_INTERNACIONAL", lobjParams)
        ds.Tables(0).TableName = "dtPreEmbarque"
        ds.Tables(1).TableName = "dtChkPreEmbarque"
        ds.Tables(2).TableName = "dtObsPreEmbarque"
        Return ds.Copy

    End Function

    Public Function Lista_Checkpoint_Item_OC_X_Cliente(ByVal PNCCLNT As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", PNCCLNT)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_ITEM_OC_X_CLIENTE", lobjParams)
        Return dt
    End Function


    Public Sub Act_Cantidad_Item_Ajuste(ByVal CCLNT As Decimal, ByVal NRPEMB As Decimal, ByVal NORCML As String, ByVal NRITOC As Decimal, ByVal SBITOC As String, ByVal QRLCSC As Decimal)
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", CCLNT)
        lobjParams.Add("PNNRPEMB", NRPEMB)
        lobjParams.Add("PSNORCML", NORCML)
        lobjParams.Add("PNNRITOC", NRITOC)
        lobjParams.Add("PSSBITOC", SBITOC)
        lobjParams.Add("PNQRLCSC", QRLCSC)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjParams.Add("PNFECHA", Format(Now, "yyyyMMdd"))
        lobjParams.Add("PNHORA", Format(Now, "HHmmss"))
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACT_PREEMBARQUE_CANTIDAD_ITEM_AJUSTE", lobjParams)
    End Sub






    Public Function Listar_FechasEntrega_PreEmbarque(ByVal oCargaInternacional As SOLMIN_SC.Entidad.OrdenCompra_BE) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", oCargaInternacional.PNCCLNT)
        lobjParams.Add("PSNORCML", oCargaInternacional.PSNORCML)
        lobjParams.Add("PNNRITOC", oCargaInternacional.PNNRITOC)
        lobjParams.Add("PNNRPEMB", oCargaInternacional.PNNRPEMB)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_FECHAENTREGA_PREEMBARQUE", lobjParams)
        Return dt
    End Function
  
    Public Function Agregar_FechasEntrega_PreEmbarque(ByVal oCargaInternacional As SOLMIN_SC.Entidad.OrdenCompra_BE) As Integer
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim retorno As Int32 = 0
        lobjParams.Add("PNCCLNT", oCargaInternacional.PNCCLNT)
        lobjParams.Add("PSNORCML", oCargaInternacional.PSNORCML)
        lobjParams.Add("PNNRITOC", oCargaInternacional.PNNRITOC)
        lobjParams.Add("PNNRPEMB", oCargaInternacional.PNNRPEMB)
        lobjParams.Add("PNFECENT", oCargaInternacional.PNFECENT)
        lobjParams.Add("PNFINGAL", oCargaInternacional.PNFINGAL)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_AGREGAR_FECHAENTREGA_PREEMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function

    Public Function ListarItemsXOrdenCompraParcial(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PSCCMPN", obeOrdenPreEmbarcarda.PSCCMPN)
        lobjParams.Add("PNCCLNT", obeOrdenPreEmbarcarda.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenPreEmbarcarda.PSNORCML)
        lobjParams.Add("PNNRPARC", obeOrdenPreEmbarcarda.PNNRPARC)
        lobjParams.Add("PSCDVSN", obeOrdenPreEmbarcarda.PSCDVSN)
        lobjParams.Add("PNCPLNDV", obeOrdenPreEmbarcarda.PNCPLNDV)

        odt = lobjSql.ExecuteDataTable("SP_SOLSC_ITEMS_X_ORDEN_COMPRA_PARCIAL", lobjParams)
        Return odt
    End Function

    Public Function ListarItemsXOrdenCompraParcial_x_Item(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PNCCLNT", obeOrdenPreEmbarcarda.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenPreEmbarcarda.PSNORCML)
        lobjParams.Add("PNNRITOC", obeOrdenPreEmbarcarda.PNNRITOC)
        lobjParams.Add("PNNRPARC", obeOrdenPreEmbarcarda.PNNRPARC)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_ITEMS_X_ORDEN_COMPRA_PARCIAL_X_ITEM", lobjParams)
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
    Public Function Lista_Obs_OC_Parcial(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PSCCMPN", obeOrdenPreEmbarcarda.PSCCMPN)
        lobjParams.Add("PNCCLNT", obeOrdenPreEmbarcarda.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenPreEmbarcarda.PSNORCML)
        lobjParams.Add("PNNRPARC", obeOrdenPreEmbarcarda.PNNRPARC)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_OBS_X_OC_PARCIAL", lobjParams)
        Return odt
    End Function

    Public Function Lista_Checkpoint_OC_Parcial(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", obeOrdenPreEmbarcarda.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeOrdenPreEmbarcarda.PSCDVSN)
        lobjParams.Add("PNCCLNT", obeOrdenPreEmbarcarda.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenPreEmbarcarda.PSNORCML)
        lobjParams.Add("PNNRPARC", obeOrdenPreEmbarcarda.PNNRPARC)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_OC_X_CLIENTE_PARCIAL", lobjParams)
        Return dt
    End Function

    Public Function Lista_Checkpoint_OC_Parcial_Item(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeOrdenPreEmbarcarda.PNCCLNT)
        lobjParams.Add("PSNORCML", obeOrdenPreEmbarcarda.PSNORCML)
        lobjParams.Add("PNNRPARC", obeOrdenPreEmbarcarda.PNNRPARC)
        lobjParams.Add("PNNRITOC", obeOrdenPreEmbarcarda.PNNRITOC)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_OC_X_CLIENTE_PARCIAL_NRITOC", lobjParams)
        Return dt
    End Function


    Public Function Lista_Checkpoint_Item_OC_X_Cliente_PreEmbarque(ByVal pdblCli As Double, ByVal PNNRPEMB As Decimal) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PNNRPEMB", PNNRPEMB)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_LISTA_CHECKPOINT_ITEM_OC_X_CLIENTE_X_PREEMBARQUE", lobjParams)
        Return dt
    End Function

    Public Function Lista_Observacion_OrdenCompra_PreEmbarque(ByVal obeOrdenPreEmbarcarda As beOrdenPreEmbarcadaFiltro) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PSCCMPN", obeOrdenPreEmbarcarda.PSCCMPN)
        lobjParams.Add("PNCCLNT", obeOrdenPreEmbarcarda.PNCCLNT)
        odt = lobjSql.ExecuteDataTable("SP_SOLSC_OBSERVACIONES_ORDEN_COMPRA_PREEMBARQUE", lobjParams)
        Return odt
    End Function

    Public Function Actualizar_Datos_X_Preembarque(ByVal obePreEmbarque_BE As bePreEmbarque) As Int32
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNRPEMB", obePreEmbarque_BE.PNNRPEMB)
        lobjParams.Add("PNCAGNCR", obePreEmbarque_BE.PNCAGNCR)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLSC_ACTUALIZAR_DATOS_PREEMBARQUE", lobjParams)
        retorno = 1
        Return retorno
    End Function
    Public Function Obtener_Dato_PreEmbarque(ByVal PNCCLNT As Decimal, ByVal PNNRPEMB As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNRPEMB", PNNRPEMB)
        odt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_OBTENER_DATO_PREEMBARQUE", lobjParams)
        Return odt
    End Function

    Public Function Obtener_Dato_OC_Parcial(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRPARC As Decimal) As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSNORCML", PSNORCML)
        lobjParams.Add("PNNRPARC", PNNRPARC)
        odt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_OBTENER_DATO_OC_PARCIAL", lobjParams)
        Return odt
    End Function



    Public Function Validar_Nro_Parcial_CargaInternacional(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRPARC_NUEVO As Decimal) As String
        Dim msgValidacion As String = ""
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSNORCML", PSNORCML)
        lobjParams.Add("PNNRPARC_NUEVO", PNNRPARC_NUEVO)
        odt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_VALIDAR_NRO_PARCIAL_CARGA_INTERNACIONAL", lobjParams)
        If odt.Rows.Count > 0 Then
            msgValidacion = ("" & odt.Rows(0)("MSGIMP"))
        End If
        Return msgValidacion
    End Function

    Public Function Validar_Nro_Parcial_CargaInternacional_Item(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITOC As Decimal, ByVal PSSBITOC As String, ByVal PNNRPARC_NUEVO As Decimal) As String
        Dim msgValidacion As String = ""
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PSCCMPN", PSCCMPN)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSNORCML", PSNORCML)
        lobjParams.Add("PNNRITOC", PNNRITOC)
        lobjParams.Add("PSSBITOC", PSSBITOC)
        lobjParams.Add("PNNRPARC_NUEVO", PNNRPARC_NUEVO)
        odt = lobjSql.ExecuteDataTable("SP_SOLMIN_SC_VALIDAR_NRO_PARCIAL_CARGA_INTERNACIONAL_ITEM", lobjParams)
        If odt.Rows.Count > 0 Then
            msgValidacion = ("" & odt.Rows(0)("MSGIMP"))
        End If
        Return msgValidacion
    End Function



    Public Function Actualizar_Nro_Parcial_CargaInternacional(ByVal PNNRPEMB As Decimal, ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITOC As Decimal, ByVal PSSBITOC As String, ByVal PNNRPARC_INI As String, ByVal PNNRPARC_NUEVO As Decimal) As String
        Dim retorno As Int32 = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        Dim odt As New DataTable
        lobjParams.Add("PNNRPEMB", PNNRPEMB)
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSNORCML", PSNORCML)
        lobjParams.Add("PNNRITOC", PNNRITOC)
        lobjParams.Add("PSSBITOC", PSSBITOC)
        lobjParams.Add("PNNRPARC_INI", PNNRPARC_INI)
        lobjParams.Add("PNNRPARC_NUEVO", PNNRPARC_NUEVO)
        lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName)
        lobjSql.ExecuteNonQuery("SP_SOLMIN_SC_ACTUALIZAR_NRO_PARCIAL_CARGA_INTERNACIONAL", lobjParams)
        retorno = 1
        Return retorno
    End Function


End Class
