Imports RANSA.TYPEDEF.Reportes
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daReporteDS

#Region "Reportes DS"


    ''' <summary>
    ''' Reporte de entrega de almacen Por OC
    ''' </summary>
    ''' <param name="pdblCodCli"></param>
    ''' <param name="pdblFecIni"></param>
    ''' <param name="pdblFecFin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function dtRepEntregaEmbAlmOC(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCodCli)
        lobjParams.Add("PNFECINI", pdblFecIni)
        lobjParams.Add("PNFECFIN", pdblFecFin)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SA_SDS_REPORTE_ENTREGA_ALMACEN_OC", lobjParams)
        Return dt
    End Function

    ''' <summary>
    ''' Reporte de entrega de almacen Por Item
    ''' </summary>
    ''' <param name="pdblCodCli"></param>
    ''' <param name="pdblFecIni"></param>
    ''' <param name="pdblFecFin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function dtRepEntregaEmbAlmItem(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PNCCLNT", pdblCodCli)
        lobjParams.Add("PNFECINI", pdblFecIni)
        lobjParams.Add("PNFECFIN", pdblFecFin)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SA_SDS_REPORTE_ENTREGA_ALMACEN_ITEM", lobjParams)
        Return dt
    End Function

    Public Function dsRepRotacionProducto(ByVal pdblCodCli As Double, ByVal pdblFecIni As Double, ByVal pdblFecFin As Double) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCodCli)
        lobjParams.Add("PNFECINI", pdblFecIni)
        lobjParams.Add("PNFECFIN", pdblFecFin)
        ds = lobjSql.ExecuteDataSet(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SA_SDS_REPORTE_ROTACION_PRODUCTO", lobjParams)
        Return ds

    End Function

    Public Function dsReporteAnualRotacion(ByVal pdblCodCli As Double, ByVal anio As Double) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", pdblCodCli)
        lobjParams.Add("PNFECINI", anio)
        ds = lobjSql.ExecuteDataSet(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SDS_REPORTE_ROTACION_ANUAL", lobjParams)
        Return ds
    End Function
    ''' <summary>
    ''' Reporte de stcok por fecha
    ''' </summary>
    ''' <param name="obeFiltros"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function dtRepStockPorFecha(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", obeFiltros.PSCCMPN)
        lobjParams.Add("PSCDVSN", obeFiltros.PSCDVSN)
        lobjParams.Add("PNCCLNT", obeFiltros.PNCCLNT)
        lobjParams.Add("PNFECINI", obeFiltros.PNFECINI)
        lobjParams.Add("PNFECFIN", obeFiltros.PNFECFIN)
        lobjParams.Add("PNCANDIA", obeFiltros.PNCANDIA)
        lobjParams.Add("PSUSUARIO", obeFiltros.PSUSUARIO)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SA_REPORTE_STOCK_POR_FECHA", lobjParams)
        Return dt
    End Function
    ''' <summary>
    ''' Reporte de Relacion de Partes x Fecha
    ''' </summary>
    ''' <param name="obeFiltros"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function dtRepPartesPorFecha(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataSet
        Dim ds As DataSet
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("IN_CCMPN", obeFiltros.PSCCMPN)
        lobjParams.Add("IN_CCLNT", obeFiltros.PNCCLNT)
        lobjParams.Add("IN_STPODP", obeFiltros.PSSTPODP)
        lobjParams.Add("IN_FRLZSR", obeFiltros.PNFRLZSR)
        lobjParams.Add("IN_NPRTIN", obeFiltros.PNNPRTIN)
        ds = lobjSql.ExecuteDataSet(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SA_SDS_LISTA_RELACION_PARTE_X_FECHA", lobjParams)
        Return ds
    End Function

    Public Function dtRepDetalleNroParte(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_CCLNT", obeFiltros.PNCCLNT)
        lobjParams.Add("IN_NPRTIN", obeFiltros.PNNPRTIN)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SA_SDS_DETALLE_NRO_PARTE", lobjParams)
        Return dt
    End Function

    ''' <summary>
    '''  Listado del Stock de Productos a una determinada fecha
    ''' </summary>
    ''' <param name="obeFiltros"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtRepInventarioPorFecha(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeFiltros.PSCCLNT)
        lobjParams.Add("PSCTPDP6", obeFiltros.PSCTPDP6)
        lobjParams.Add("PNFECINV", obeFiltros.PNFECINV)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SDS_INVENTARIO_POR_FECHA", lobjParams)
        Return dt
    End Function

    ''' <summary>
    '''  Listado del Stock de Productos  
    ''' </summary>
    ''' <param name="obeFiltros"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdtRepInventarioSDS(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", obeFiltros.PSCCLNT)
        lobjParams.Add("PSCTPDP6", obeFiltros.PSCTPDP6)
        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SDS_INVENTARIO_v2", lobjParams)
        Return dt
    End Function

    Public Function fdtRepStockProductoXUbicacion(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        'Try
        With lobjParams
            .Add("IN_CCLNT", obeFiltros.PSCCLNT)
            .Add("IN_CTPDP6", obeFiltros.PSCTPDP6)
            .Add("IN_CTPALM", obeFiltros.PSCTPALM)
            .Add("IN_CALMC", obeFiltros.PSCALMC)
            .Add("IN_CZNALM", obeFiltros.PSCZNALM)
        End With

        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SDS_STOCK_PRODUCTO_X_UBICACION", lobjParams)
        'Catch ex As Exception
        '    dt = New DataTable
        'End Try

        Return dt
    End Function

    Public Shared Function fdtInventarioPorPosicion(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataSet
        'Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        'Try
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PNCCLNT", obeFiltros.PSCCLNT)
            .Add("IN_CTPDP6", obeFiltros.PSCTPDP6)
            .Add("PSCTPALM", obeFiltros.PSCTPALM)
            .Add("PSCALMC", obeFiltros.PSCALMC)
            '.Add("PSCZNALM", obeFiltros.PSCZNALM)
            '.Add("PNORDENACION", TD_Filtro.pORDENACION)
        End With


        'oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_INVENTARIO_X_POSICION", objParam)
        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_INVENTARIO_X_POSICION_X_ZONA", objParametros)

        'oResultado.TableAdd(ds.Tables(0).Copy)
        'Catch ex As Exception
        '    ds = New DataSet
        'End Try
        ds.WriteXml("d:\tempo.xml")
        Return ds
    End Function


    Public Shared Function fdtBodyEmail(ByVal ccmpn As String, ByVal cdvsn As String, ByVal cplndv As Double, ByVal cclnt As Double, ByVal creffw As String, ByVal nseqin As Integer) As DataTable
        Dim dt As DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter

        lobjParams.Add("PSCCMPN", ccmpn)
        lobjParams.Add("PSCDVSN", cdvsn)
        lobjParams.Add("PNCPLNDV", cplndv)
        lobjParams.Add("PNCCLNT", cclnt)
        lobjParams.Add("PSCREFFW", creffw)
        lobjParams.Add("PNNSEQIN", nseqin)

        dt = lobjSql.ExecuteDataTable(ConfigurationWizard.Library.ToString.Trim & ".SP_SOLMIN_SA_SAT_BULTO_EMAIL_BODYB", lobjParams)
        Return dt
    End Function


    Public Function fdtInventarioPorLotePorPosicion(ByVal obeFiltros As beFiltrosDespachoPorAlmacen) As DataSet
        'Dim oResultado As TD_Rpt_Resultado = New TD_Rpt_Resultado
        Dim ds As New DataSet
        Dim lobjSql As New SqlManager
        'Try
        Dim objParametros As Parameter = New Parameter
        ' Ingresamos los parametros del Procedure
        With objParametros
            .Add("PNCCLNT", obeFiltros.PSCCLNT)
            .Add("IN_CTPDP6", obeFiltros.PSCTPDP6)
            .Add("PSCTPALM", obeFiltros.PSCTPALM)
            .Add("PSCALMC", obeFiltros.PSCALMC)
        End With

        ds = lobjSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_INVENTARIO_X_LOTE_POSICION", objParametros)
        'oResultado.TableAdd(ds.Tables(0).Copy)
        'Catch ex As Exception
        '    ds = New DataSet
        'End Try
        Return ds
    End Function


#End Region

 

End Class



