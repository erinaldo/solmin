Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects


Public Class daDespachoMasivo
    Private objSql As New SqlManager

    Public Function ListarStockMercaderiaClienteAlmacen(ByVal PNCCLNT As Decimal, ByVal PSCFMCLR As String, ByVal PSCGRCLR As String, ByVal PSCTPALM As String, ByVal PSCALMC As String, ByVal PSCZNALM As String) As DataTable

        Dim oDt As New DataTable
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", PNCCLNT)
        objParam.Add("PSCFMCLR", PSCFMCLR)
        objParam.Add("PSCGRCLR", PSCGRCLR)
        objParam.Add("PSCTPALM", PSCTPALM)
        objParam.Add("PSCALMC", PSCALMC)
        objParam.Add("PSCZNALM", PSCZNALM)

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTAR_STOCK_X_MERCADERIA_CLIENTE_ALMACEN", objParam)

        Return oDt

    End Function

    Public Function ValidarAlmacenConfigAlmacenCliente(ByVal PSCTPALM As String, ByVal PSCALMC As String, ByVal PSCZNALM As String) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter

        objParam.Add("PSCTPALM", PSCTPALM)
        objParam.Add("PSCALMC", PSCALMC)
        objParam.Add("PSCZNALM", PSCZNALM)

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_VALIDAR_ALMACEN_CONFIG_ALMACEN_CLIENTE", objParam)

        Return oDt
    End Function

    Public Function ValidarGrupoFamilia(ByVal PNCCLNT As Decimal, ByVal PSCFMCLR As String, ByVal PSCGRCLR As String) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", PNCCLNT)
        objParam.Add("PSCFMCLR", PSCFMCLR)
        objParam.Add("PSCGRCLR", PSCGRCLR)

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_VALIDAR_GRUPO_FAMILIA", objParam)

        Return oDt
    End Function

    Public Function ListarAlmacenValidacionCarga() As DataTable
        Dim oDt As New DataTable

        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTAR_ALMACEN_VALIDACION_CARGA", Nothing)

        Return oDt
    End Function


    Public Function ListarGrupoFamiliaValidacionCarga(ByVal PNCCLNT As Decimal) As DataTable
        Dim oDt As New DataTable
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", PNCCLNT)
        oDt = objSql.ExecuteDataTable("SP_SOLMIN_SA_LISTAR_GRUPO_FAMILIA_VALIDACION_CARGA", objParam)

        Return oDt
    End Function


    Public Function ActualizarRelacionadoOS(ByVal PNNORDSR As Decimal) As Boolean
        Dim result As Boolean = False
        Dim objParam As New Parameter

        objParam.Add("PNNORDSR", PNNORDSR)
        objSql.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZAR_RELACIONADO_OS", objParam)
        result = True

        Return result

    End Function

    Public Function ListarTablaVCalidacionCarga(ByVal PNCCLNT As Decimal) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter

        objParam.Add("PNCCLNT", PNCCLNT)
        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTAR_TABLA_VALIDACION_CARGA", objParam)

        Return oDs
    End Function

End Class
