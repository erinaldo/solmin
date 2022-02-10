Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF
Public Class daRegistroIventario

    Public Function ListarCabeceraERI(ByVal objbeCabeceraERI As beCabeceraERI) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Try
            objParam.Add("IN_CCMPN", objbeCabeceraERI.IN_CCMPN)
            objParam.Add("IN_CRGVTA ", objbeCabeceraERI.IN_CRGVTA)
            objParam.Add("IN_CPLNDV", objbeCabeceraERI.IN_CPLNDV)
            objParam.Add("IN_CCLNT", objbeCabeceraERI.IN_CCLNT)
            objParam.Add("IN_FECINVINI", objbeCabeceraERI.IN_FECINVINI)
            objParam.Add("IN_FECINVFIN", objbeCabeceraERI.IN_FECINVFIN)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_CAB_ERI", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs
    End Function

    Public Function ListarDetalleERI(ByVal objbeInventarioDetallERI As beInventarioDetallERI) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Try
            objParam.Add("IN_CCMPN", objbeInventarioDetallERI.IN_CCMPN)
            objParam.Add("IN_CRGVTA", objbeInventarioDetallERI.IN_CRGVTA)
            objParam.Add("IN_CPLNDV", objbeInventarioDetallERI.IN_CPLNDV)
            objParam.Add("IN_CCLNT", objbeInventarioDetallERI.IN_CCLNT)
            objParam.Add("IN_NROERI", objbeInventarioDetallERI.IN_NROERI)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_DET_ERI", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs
    End Function

    Public Function ListaInventarioXFecha(ByVal objbeInventarioxFecha As beInventarioxFecha) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Try
            objParam.Add("PSCCMPN", objbeInventarioxFecha.PSCCMPN)
            objParam.Add("PSCCVSN", objbeInventarioxFecha.PSCCVSN)
            objParam.Add("PNCPLNDV", objbeInventarioxFecha.PNCPLNDV)
            objParam.Add("PNCCLNT", objbeInventarioxFecha.PNCCLNT)
            objParam.Add("PSCTPDP6", objbeInventarioxFecha.PSCTPDP6)
            objParam.Add("PNFECINV", objbeInventarioxFecha.PNFECINV)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SDS_INVENTARIO_POR_PLANTA_FECHA", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs
    End Function

    Public Function ListaInventarioExportXFecha(ByVal objbeInventarioExcel As beInventarioExcel) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Try
            objParam.Add("IN_CCMPN", objbeInventarioExcel.PSCCMPN)
            objParam.Add("IN_CRGVTA", objbeInventarioExcel.PSCRGVTA)
            objParam.Add("IN_CPLNDV", objbeInventarioExcel.PNCPLNDV)
            objParam.Add("IN_CCLNT", objbeInventarioExcel.PNCCLNT)
            objParam.Add("IN_NROERI", objbeInventarioExcel.PNNROERI)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_ERI_EXPORTAR", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs
    End Function

    Public Function GenerarCabeceraERI(ByVal objbeCabEri As beCabERI) As DataSet

        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        Dim oDs As New DataSet
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("PSCCMPN", objbeCabEri.PSCCMPN)
        objParametros.Add("PSCRGVTA", objbeCabEri.PSCRGVTA)
        objParametros.Add("PNCPLNDV", objbeCabEri.PNCPLNDV)
        objParametros.Add("PNCCLNT", objbeCabEri.PNCCLNT)
        objParametros.Add("PNFECINV", objbeCabEri.PNFECINV)
        objParametros.Add("PSCUSERI", objbeCabEri.PSCUSERI)
        objParametros.Add("NTRMCR", objbeCabEri.PNTRMCR.Substring(0, 10))

        Try
            'objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ERI_CAB_INSERTAR", objParametros)
            oDs = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_ERI_CAB_INSERTAR", objParametros)
            Return oDs
        Catch ex As Exception
            Return Nothing
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
        '///////////////////////////////////////////////////////////////////////'
    End Function

    Public Function GenerarDetalleERI(ByVal objbeDetERI As beDetERI) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As Parameter = New Parameter
        Dim strMensajeError As String = ""
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParam.Add("PSCCMPN", objbeDetERI.PSCCMPN)
        objParam.Add("PSCRGVTA", objbeDetERI.PSCRGVTA)
        objParam.Add("PNCPLNDV", objbeDetERI.PNCPLNDV)
        objParam.Add("PNCCLNT", objbeDetERI.PNCCLNT)
        objParam.Add("PNNROERI", objbeDetERI.PNNROERI)
        objParam.Add("PNNORDSR", objbeDetERI.PNNORDSR)
        objParam.Add("PSCMRCLR", objbeDetERI.PSCMRCLR)
        objParam.Add("PNQSLMC", objbeDetERI.PNQSLMC)
        objParam.Add("PNQSLMP", objbeDetERI.PNQSLMP)
        objParam.Add("PSCUNCN5", objbeDetERI.PSCUNCN5)
        objParam.Add("PSCUNPS5", objbeDetERI.PSCUNPS5)
        objParam.Add("PSCUSERI", objbeDetERI.PSCUSERI)
        objParam.Add("PNTRMCR", objbeDetERI.PNTRMCR.Substring(0, 10))
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ERI_DET_INSERTAR", objParam)
            Return 1
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << GenerarDetalleERI >> de la clase << daRegistroIventario >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Return 0
        Finally
            objSqlManager = Nothing
            objParam = Nothing
        End Try
    End Function

    Public Function ActualizaEstadoCabERI(ByVal objbeActualizaEstadoCabERI As beActualizaEstadoCabERI) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As Parameter = New Parameter
        Dim strMensajeError As String = ""
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParam.Add("PSCCMPN", objbeActualizaEstadoCabERI.PSCCMPN)
        objParam.Add("PSCRGVTA", objbeActualizaEstadoCabERI.PSCRGVTA)
        objParam.Add("PNCPLNDV", objbeActualizaEstadoCabERI.PNCPLNDV)
        objParam.Add("PNCCLNT", objbeActualizaEstadoCabERI.PNCCLNT)
        objParam.Add("PNNROERI", objbeActualizaEstadoCabERI.PNNROERI)
        objParam.Add("PSCUSERI", objbeActualizaEstadoCabERI.PSCUSERI)
        objParam.Add("NTRMCR", objbeActualizaEstadoCabERI.NTRMCR.Substring(0, 10))
        objParam.Add("PSSTSERI", objbeActualizaEstadoCabERI.PSSTSERI)
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ERI_CAB_ACTUALIZAR_ESTADO", objParam)
            Return 1
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << ActualizaEstadoCabERI >> de la clase << daRegistroIventario >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Return 0
        Finally
            objSqlManager = Nothing
            objParam = Nothing
        End Try
    End Function

    Public Function ActualizaStockFisicoERI(ByVal objbeActualizaStockFisicoERI As beActualizaStockFisicoERI) As Integer
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParam As Parameter = New Parameter
        Dim strMensajeError As String = ""
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParam.Add("PSCCMPN", objbeActualizaStockFisicoERI.PSCCMPN)
        objParam.Add("PSCRGVTA", objbeActualizaStockFisicoERI.PSCRGVTA)
        objParam.Add("PNCPLNDV", objbeActualizaStockFisicoERI.PNCPLNDV)
        objParam.Add("PNCCLNT", objbeActualizaStockFisicoERI.PNCCLNT)
        objParam.Add("PNNROERI", objbeActualizaStockFisicoERI.PNNROERI)
        objParam.Add("PSCMRCLR", objbeActualizaStockFisicoERI.PSCMRCLR)
        objParam.Add("PNQSFMC", objbeActualizaStockFisicoERI.PNQSFMC)
        objParam.Add("PNQSFMP", objbeActualizaStockFisicoERI.PNQSFMP)
        objParam.Add("PSCUSERI", objbeActualizaStockFisicoERI.PSCUSERI)
        objParam.Add("NTRMCR", objbeActualizaStockFisicoERI.NTRMCR.Substring(0, 10))
        Try
            objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_ACTUALIZAR_STOCK_FISICO_ERI", objParam)
            Return 1
        Catch ex As Exception
            strMensajeError = "Error producido en la funcion : << ActualizaEstadoCabERI >> de la clase << daRegistroIventario >> " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
            Return 0
        Finally
            objSqlManager = Nothing
            objParam = Nothing
        End Try
    End Function

    Public Function ListarProductosxRegularizar(ByVal objbeProductoxRegularizar As beProductoxRegularizar) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        Try
            objParam.Add("PNCCLNT", objbeProductoxRegularizar.PNCCLNT)
            objParam.Add("PSCCMPN ", objbeProductoxRegularizar.PSCCMPN)
            objParam.Add("PSCRGVTA", objbeProductoxRegularizar.PSCRGVTA)
            objParam.Add("PNCPLNDV", objbeProductoxRegularizar.PNCPLNDV)
            objParam.Add("PNNROERI", objbeProductoxRegularizar.PNNROERI)
            objParam.Add("PSCTPDP6", objbeProductoxRegularizar.PSCTPDP6)
            oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_SDS_LISTA_ERI_PARA_AJUSTE_INVENTARIO", objParam)
        Catch ex As Exception
            oDs = Nothing
        End Try
        Return oDs
    End Function

    Public Function ListarDisponibilidadInventario(ByVal objbeProductoxRegularizar As beProductoxRegularizar) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("PSCCMPN", objbeProductoxRegularizar.PSCCMPN)
        objParam.Add("PSCCVSN ", objbeProductoxRegularizar.PSCCVSN)
        objParam.Add("PNCPLNDV", objbeProductoxRegularizar.PNCPLNDV)
        objParam.Add("PNCCLNT", objbeProductoxRegularizar.PNCCLNT)
        objParam.Add("PSCTPDP6", objbeProductoxRegularizar.PSCTPDP6)
        objParam.Add("PNFECINV", objbeProductoxRegularizar.PNFECINV)

        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SDS_DISPONIBLIDAD_INVENTARIO_POR_PLANTA_FECHA", objParam)
        'Catch ex As Exception
        '    oDs = Nothing
        'End Try
        Return oDs
    End Function

    Public Function ListarOcupabilidadAlmacen(ByVal objbeProductoxRegularizar As beProductoxRegularizar) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        'Try
        objParam.Add("PSCCMPN", objbeProductoxRegularizar.PSCCMPN)
        objParam.Add("PSCCVSN", objbeProductoxRegularizar.PSCCVSN)
        objParam.Add("PNCPLNDV", objbeProductoxRegularizar.PNCPLNDV)
        objParam.Add("PSCTPALM", objbeProductoxRegularizar.PSCTPALM)
        objParam.Add("PSCALMC", objbeProductoxRegularizar.PSCALMC)
        objParam.Add("PNFECINV", objbeProductoxRegularizar.PNFECINV)

        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SDS_OCUPABILIDAD_ALMACEN_POR_PLANTA_FECHA", objParam)
        'Catch ex As Exception
        '    oDs = Nothing
        'End Try
        Return oDs
    End Function

    Public Function EficienciadeRecepcionDespacho(ByVal objbeProductoxRegularizar As beProductoxRegularizar) As DataSet
        Dim oDs As New DataSet
        Dim objParam As New Parameter
        Dim objSql As New SqlManager
        objParam.Add("PSCCMPN", objbeProductoxRegularizar.PSCCMPN)
        objParam.Add("PNCCLNT", objbeProductoxRegularizar.PNCCLNT)
        objParam.Add("PSCDVSN", objbeProductoxRegularizar.PSCDVSN)
        objParam.Add("PSANIOMES", objbeProductoxRegularizar.PSANIOMES)
        oDs = objSql.ExecuteDataSet("SP_SOLMIN_SA_LISTA_REPORTE_EFICIENCIA", objParam)
        Return oDs
    End Function
End Class
