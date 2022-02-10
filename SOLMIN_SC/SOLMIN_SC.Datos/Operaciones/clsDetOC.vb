


Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Public Class clsDetOC
    Inherits Base_DAL(Of beOrdenCompra)
    Public Function Busca_Det_OC(ByVal pdblCli As Double, ByVal pstrOC As String) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PCNORCML", pstrOC)
        dt = lobjSql.ExecuteDataTable("SP_SOLSC_BUSCA_DET_OC", lobjParams)
        Return dt
    End Function

    Public Function Consulta_Item_Seguimiento_PreEmbarque(ByVal NORCML As String, ByVal CCLNT As Decimal, ByVal CCMPN As String, ByVal NORSCI As Decimal) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSNORCML", NORCML)
        lobjParams.Add("PNCCLNT", CCLNT)
        lobjParams.Add("PSCCMPN", CCMPN)
        lobjParams.Add("PNNORSCI", NORSCI)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_SC_SEGUIMIENTO_CONSULTAR_ITEM_PREEMBARCADOS", lobjParams)
        Return ds
    End Function

    Public Sub Actualiza_Item_OC_Partida(ByVal pdblCliente As Double, ByVal pstrOC As String, ByVal pdblItem As Double, ByVal pstrPartida As String, ByVal pstrSubItem As String)
        Dim lobjParams As New Parameter
        Dim oSqlMan As New SqlManager
        lobjParams.Add("PNCCLNT", pdblCliente)
        lobjParams.Add("PSNORCML", pstrOC)
        lobjParams.Add("PNNRITOC", pdblItem)
        lobjParams.Add("PSSBITOC", pstrSubItem)
        lobjParams.Add("PSCPTDAR", pstrPartida)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)
        oSqlMan.ExecuteNonQuery("SP_SOLSC_ACT_OC_ITEM_PARTIDA", lobjParams)

    End Sub


    Public Function Busca_Det_OC_ADICION_PARCIAL(ByVal pdblCli As Double, ByVal pstrOC As String, ByVal PNNRPARC As Decimal) As DataSet
        'Dim dt As DataTable
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCli)
        lobjParams.Add("PCNORCML", pstrOC)
        lobjParams.Add("PNNRPARC", PNNRPARC)
        ds = lobjSql.ExecuteDataSet("SP_SOLSC_BUSCA_DET_OC_ADICION_PARCIAL_V2", lobjParams)
        ds.Tables(0).TableName = "ITEM_ORDEN"
        ds.Tables(1).TableName = "ITEM_PREEMB"
        Return ds.Copy
    End Function

    Public Function LISTA_CANTIDADES_EMBARQUE_ADUANA(ByVal PNCCLNT As Decimal, ByVal PSNORCML As String, ByVal PNNRITOC As Decimal, ByVal PSSBITOC As String, ByVal PNNORSCI As Decimal, ByVal PNNRPEMB As Decimal) As DataTable

        Dim dt As New DataTable
        Dim dr As DataRow
        Dim lobjParams As New Parameter
        Dim oSqlMan As New SqlManager
        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PSNORCML", PSNORCML)
        lobjParams.Add("PNNRITOC", PNNRITOC)
        lobjParams.Add("PSSBITOC", PSSBITOC)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNNRPEMB", PNNRPEMB)

        lobjParams.Add("CANTIDAD_SOLICITADA", 0, ParameterDirection.Output)
        lobjParams.Add("TOTAL_PRE_EMBARQUE", 0, ParameterDirection.Output)
        lobjParams.Add("TOTAL_EMBARCADO", 0, ParameterDirection.Output)
        lobjParams.Add("CANTIDAD_ACTUAL_EMBARCADA", 0, ParameterDirection.Output)

        oSqlMan.ExecuteNonQuery("SP_SOLMIN_SC_LISTA_CANTIDADES_EMBARQUE_ADUANA", lobjParams)

        dt.Columns.Add("CANTIDAD_SOLICITADA")
        dt.Columns.Add("TOTAL_PRE_EMBARQUE")
        dt.Columns.Add("TOTAL_EMBARCADO")
        dt.Columns.Add("CANTIDAD_ACTUAL_EMBARCADA")

        dr = dt.NewRow
        dr("CANTIDAD_SOLICITADA") = oSqlMan.ParameterCollection("CANTIDAD_SOLICITADA")
        dr("TOTAL_PRE_EMBARQUE") = oSqlMan.ParameterCollection("TOTAL_PRE_EMBARQUE")
        dr("TOTAL_EMBARCADO") = oSqlMan.ParameterCollection("TOTAL_EMBARCADO")
        dr("CANTIDAD_ACTUAL_EMBARCADA") = oSqlMan.ParameterCollection("CANTIDAD_ACTUAL_EMBARCADA")
        dt.Rows.Add(dr)

        Return dt
    End Function


    Public Function SP_SOLMIN_SC_ACTUALIZAR_ITEM_EMBARQUE(ByVal PNCCLNT As Decimal, ByVal PNNORSCI As Decimal, ByVal PNNRPEMB As Decimal, ByVal PNQRLCSC As Decimal, ByVal PSNORCML As String, ByVal PNNRITOC As Decimal, ByVal PSSBITOC As String, ByVal PSNFCTCM As String, ByVal PNNMITFC As Decimal, ByVal PSCPTDAR As String, ByVal CANT_ANTERIOR As Decimal) As Integer

        Dim respuesta As Integer = 0

        Dim lobjParams As New Parameter
        Dim oSqlMan As New SqlManager

        lobjParams.Add("PNCCLNT", PNCCLNT)
        lobjParams.Add("PNNORSCI", PNNORSCI)
        lobjParams.Add("PNNRPEMB", PNNRPEMB)
        lobjParams.Add("PNQRLCSC", PNQRLCSC)
        lobjParams.Add("PSNORCML", PSNORCML)

        lobjParams.Add("PNNRITOC", PNNRITOC)
        lobjParams.Add("PSSBITOC", PSSBITOC)
        lobjParams.Add("PSNFCTCM", PSNFCTCM)
        lobjParams.Add("PNNMITFC", PNNMITFC)
        lobjParams.Add("PSCPTDAR", PSCPTDAR.Trim)
        lobjParams.Add("CANT_ANTERIOR", CANT_ANTERIOR)
        lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName)

        oSqlMan.ExecuteNonQuery("SP_SOLMIN_SC_ACTUALIZAR_ITEM_EMBARQUE", lobjParams)
        respuesta = 1

        Return respuesta
    End Function

    Public Function ListarOrdenDeCompra(ByVal obeOrdenDeCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim objParam As New Parameter
        Try

            objParam.Add("PSCCMPN", obeOrdenDeCompra.PSCCMPN)
            objParam.Add("PSCDVSN", obeOrdenDeCompra.PSCDVSN)
            objParam.Add("PNCPLNDV", obeOrdenDeCompra.PNCPLNDV)

            objParam.Add("PNCCLNT", obeOrdenDeCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenDeCompra.PSNORCML)
            objParam.Add("PSTPRVCL", obeOrdenDeCompra.PSTPRVCL)
            objParam.Add("PSTTINTC", obeOrdenDeCompra.PSTTINTC)
            objParam.Add("PNFORCMI", obeOrdenDeCompra.PNFORCMI)
            objParam.Add("PNFORCMF", obeOrdenDeCompra.PNFORCMF)
            objParam.Add("PNFMPDMI", obeOrdenDeCompra.PNFMPDMI)
            objParam.Add("PNFMPDMF", obeOrdenDeCompra.PNFMPDMF)
            objParam.Add("PSTNOMCOM", obeOrdenDeCompra.PSTNOMCOM)
            objParam.Add("PSTDITES", obeOrdenDeCompra.PSTDITES)
            objParam.Add("PSSTATOC", obeOrdenDeCompra.PSSTATOC)
            objParam.Add("PAGESIZE", obeOrdenDeCompra.PageSize)
            objParam.Add("PAGENUMBER", obeOrdenDeCompra.PageNumber)
            objParam.Add("PAGECOUNT", obeOrdenDeCompra.PageCount, ParameterDirection.Output)

            Return Listar("SP_SOLMIN_SC_ORDEN_DE_COMPRA_LIST", objParam)

        Catch ex As Exception
            Return New List(Of beOrdenCompra)
        End Try
        Return Nothing
    End Function
    Public Function ListarDetalleOrdenDeCompra(ByVal obeOrdenCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim objParam As New Parameter
        Dim lstResult As New List(Of beOrdenCompra)
        Try
            objParam.Add("PSCCMPN", obeOrdenCompra.PSCCMPN)
            objParam.Add("PSCDVSN", obeOrdenCompra.PSCDVSN)
            objParam.Add("PNCPLNDV", obeOrdenCompra.PNCPLNDV)
            objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)
            objParam.Add("PSNORCML", obeOrdenCompra.PSNORCML.Trim)
            objParam.Add("PSSTATOC", obeOrdenCompra.PSSTATOC)
            objParam.Add("PAGESIZE", obeOrdenCompra.PageSize)
            objParam.Add("PAGENUMBER", obeOrdenCompra.PageNumber)
            objParam.Add("PAGECOUNT", obeOrdenCompra.PageCount, ParameterDirection.Output)
            Return Listar("SP_SOLMIN_SC_DETALLE_ORDEN_DE_COMPRA_LIST", objParam)
           
        Catch ex As Exception
            Return New List(Of beOrdenCompra)
        End Try
    End Function

    <STAThread()> _
    Public Function finActualizarEstadoSeguimiento(ByVal olbeOrdenDeCompra As List(Of beOrdenCompra)) As Integer
        Try
            Dim objSql As New SqlManager
            For Each obeOc As beOrdenCompra In olbeOrdenDeCompra
                Dim objParam As New Parameter
                objParam.Add("PNCCLNT", obeOc.PNCCLNT)
                objParam.Add("PSNORCML", obeOc.PSNORCML)
                objParam.Add("PNNRITOC", obeOc.PNNRITOC)
                objParam.Add("PNNSEQIN", obeOc.PSFLGPEN)
                objParam.Add("PSUSUARIO", ConfigurationWizard.UserName)
                objParam.Add("PSNTRMNL", ConfigurationWizard.Server)
                objSql.TimeOutCommand = 4000
                objSql.ExecuteNonQuery("SP_SOLMIN_SC_ITEM_OC_ACTUALIZAR_ESTADO_SEGUIMIENTO", objParam)
            Next

            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function fdtIndicadorTiempoEntregaProveedor(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Dim objSqlManager As New SqlManager
        Dim dtResultado As DataTable = Nothing
        Dim objParametros As Parameter = New Parameter
        Dim strMensajeError As String = String.Empty

        With objParametros
            .Add("IN_CCMPN", obeOrdenCompra.PSCCMPN)
            .Add("IN_CDVSN", obeOrdenCompra.PSCDVSN)
            .Add("IN_CPLNDV", obeOrdenCompra.PNCPLNDV)
            .Add("IN_CCLNT", obeOrdenCompra.PNCCLNT)
            .Add("IN_NORCML", obeOrdenCompra.PSNORCML)
            .Add("IN_CPRVCL", obeOrdenCompra.PNCPRVCL)
            .Add("IN_TTINTC", obeOrdenCompra.PSTTINTC)
            .Add("IN_FORCMI", obeOrdenCompra.PNFORCMI)
            .Add("IN_FORCMF", obeOrdenCompra.PNFORCMF)
            .Add("IN_FMPDMI", obeOrdenCompra.PNFMPDMI)
            .Add("IN_FMPDMF", obeOrdenCompra.PNFMPDMF)
            .Add("IN_STATOC", obeOrdenCompra.PSSTATOC)
        End With
        Try

            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SC_SEGUIMIENTO_OC_X_PROVEEDOR", objParametros)
        Catch ex As Exception
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function
    Public Function fdtIndicadorTiempoEntregaProveedor_v2(ByVal obeOrdenCompra As beOrdenCompra) As DataTable
        Dim objSqlManager As New SqlManager
        Dim dtResultado As DataTable = Nothing
        Dim objParametros As Parameter = New Parameter
        Dim strMensajeError As String = String.Empty

        With objParametros
            .Add("IN_CCMPN", obeOrdenCompra.PSCCMPN)
            .Add("IN_CDVSN", obeOrdenCompra.PSCDVSN)
            .Add("IN_CPLNDV", obeOrdenCompra.PNCPLNDV)
            .Add("IN_CCLNT", obeOrdenCompra.PNCCLNT)
            .Add("IN_NORCML", obeOrdenCompra.PSNORCML)
            .Add("IN_CPRVCL", obeOrdenCompra.PNCPRVCL)
            .Add("IN_TTINTC", obeOrdenCompra.PSTTINTC)
            .Add("IN_FORCMI", obeOrdenCompra.PNFORCMI)
            .Add("IN_FORCMF", obeOrdenCompra.PNFORCMF)
            .Add("IN_FMPDMI", obeOrdenCompra.PNFMPDMI)
            .Add("IN_FMPDMF", obeOrdenCompra.PNFMPDMF)
            .Add("IN_STATOC", obeOrdenCompra.PSSTATOC)
        End With

        Try

            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SC_SEGUIMIENTO_OC_X_PROVEEDOR_MODELO2", objParametros)
        Catch ex As Exception
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function
    Public Function fdsReporteAnualSegOC(ByVal obeOrdenCompra As beOrdenCompra) As DataSet
        Dim objSqlManager As New SqlManager
        Dim dtResultado As DataTable = Nothing
        Dim objParametros As Parameter = New Parameter
        Dim strMensajeError As String = String.Empty

        With objParametros
            .Add("IN_CCMPN", obeOrdenCompra.PSCCMPN)
            .Add("IN_CDVSN", obeOrdenCompra.PSCDVSN)
            .Add("IN_CPLNDV", obeOrdenCompra.PNCPLNDV)
            .Add("IN_CCLNT", obeOrdenCompra.PNCCLNT)
            .Add("IN_TTINTC", obeOrdenCompra.PSTTINTC)
            .Add("IN_ANIO", obeOrdenCompra.PNANIO)
        End With
        Try

            Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SC_SEGUIMIENTO_OC_LOCAL_ANUAL", objParametros)
        Catch ex As Exception
            Return New DataSet
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function


    Public Function flstListaDetalleOrdenConSeguimientoLocal(ByVal obeOrdenCompra As beOrdenCompra) As List(Of beOrdenCompra)
        Dim objSqlManager As New SqlManager
        Dim dtResultado As DataTable = Nothing
        Dim objParam As Parameter = New Parameter
        Dim strMensajeError As String = String.Empty
        Try
            objParam.Add("PSCCMPN", obeOrdenCompra.PSCCMPN)
            objParam.Add("PSCDVSN", obeOrdenCompra.PSCDVSN)
            objParam.Add("PNCPLNDV", obeOrdenCompra.PNCPLNDV)
            objParam.Add("PNCCLNT", obeOrdenCompra.PNCCLNT)

            Return Listar("SP_SOLCT_LISTA_DETALLE_ORDEN_COMPRA_SEGUIMIENTO", objParam)
        Catch ex As Exception
            Return New List(Of beOrdenCompra)
        End Try
    End Function

    <STAThread()> _
    Public Function fintVerificarEstadoSegumientoOcLocal(ByVal obeOc As beOrdenCompra) As Integer
        Try
            Dim objSql As New SqlManager
            Dim intResultado As Integer = 0
            Dim objParam As New Parameter
            objParam.Add("PNCCLNT", obeOc.PNCCLNT)
            objParam.Add("PSNORCML", obeOc.PSNORCML)
            objParam.Add("PNNRITOC", obeOc.PNNRITOC)
            objParam.Add("PSUSUARIO", ConfigurationWizard.UserName)
            objParam.Add("PSNTRMNL", ConfigurationWizard.Server)
            objParam.Add("out_EXISTE", 0, ParameterDirection.Output)
            objSql.TimeOutCommand = 1000
            objSql.ExecuteNonQuery("SP_SOLMIN_SC_VERIFICAR_ESTADO_SEGUIMIENTO_OC", objParam)

            intResultado = objSql.ParameterCollection("out_EXISTE")
            Return intResultado
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As Entidad.beOrdenCompra)

    End Sub
End Class
