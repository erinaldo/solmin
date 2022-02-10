Imports RANSA.TYPEDEF.Reportes
Imports Db2Manager.RansaData.iSeries.DataObjects


Public Class daReporteAT

#Region "Reportes AT"

    ''' <summary>
    ''' Lista para reporte de ingreso por Almacen
    ''' </summary>
    ''' <param name="obeFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fdstIngresoPorAlmacen(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        'Try
        objParametros.Add("IN_CCLNT", obeFiltro.PSCCLNT)
        objParametros.Add("IN_CCMPN", obeFiltro.PSCCMPN)
        objParametros.Add("IN_CDVSN", obeFiltro.PSCDVSN)
        objParametros.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
        objParametros.Add("IN_CREFFW", obeFiltro.PSCREFFW)
        objParametros.Add("IN_FECINI", obeFiltro.PNFECINI)
        objParametros.Add("IN_FECFIN", obeFiltro.PNFECFIN)
        objParametros.Add("IN_TUBRFR", obeFiltro.PSTUBRFR)
        objParametros.Add("IN_STPING", obeFiltro.PSSTPING)
        Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SAT_REPORTE_INGRESO_POR_ALMACEN", objParametros)
        'Catch ex As Exception
        '    Return New DataSet
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
    End Function

    Public Function fdstIngresoPorAlmacen_x_lote_x_solicitante(ByVal obeFiltro As beFiltrosDespachoPorAlmacen, Optional ByVal solicitante As String = "", Optional ByVal lote As String = "") As DataSet
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        Try
            objParametros.Add("IN_CCLNT", obeFiltro.PNCCLNT)
            objParametros.Add("IN_CCMPN", obeFiltro.PSCCMPN)
            objParametros.Add("IN_CDVSN", obeFiltro.PSCDVSN)
            objParametros.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
            objParametros.Add("IN_CREFFW", obeFiltro.PSCREFFW)
            objParametros.Add("IN_FECINI", obeFiltro.PNFECINI)
            objParametros.Add("IN_FECFIN", obeFiltro.PNFECFIN)
            objParametros.Add("IN_TUBRFR", obeFiltro.PSTUBRFR)
            objParametros.Add("IN_STPING", obeFiltro.PSSTPING)
            objParametros.Add("IN_REFDO1", solicitante)
            objParametros.Add("IN_TCMAEM", lote)
            Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SAT_REPORTE_INGRESO_ALMACEN_X_LOT_SOLIC", objParametros)
        Catch ex As Exception
            Return New DataSet
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Public Function fdstDespachoPorAlmacen(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        'Try
        objParametros.Add("IN_CCLNT", obeFiltro.PSCCLNT)
        objParametros.Add("IN_CCMPN", obeFiltro.PSCCMPN)
        objParametros.Add("IN_CDVSN", obeFiltro.PSCDVSN)
        objParametros.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
        objParametros.Add("IN_CREFFW", obeFiltro.PSCREFFW)
        objParametros.Add("IN_FECINI", obeFiltro.PNFECINI)
        objParametros.Add("IN_FECFIN", obeFiltro.PNFECFIN)
        objParametros.Add("IN_TUBRFR", obeFiltro.PSTUBRFR)
        objParametros.Add("IN_STPING", obeFiltro.PSSTPING)
        Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SAT_REPORTE_DESPACHO_POR_ALMACEN", objParametros)
        'Catch ex As Exception
        '    Return New DataSet
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
    End Function


    '------------------------'
    '-- Inventario Almacen --'
    '------------------------'
    Public Function frptInventarioAlmacen(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Dim dtTemp As DataTable = Nothing
        Dim dsTemp As New DataSet
        Dim objSqlManager As SqlManager = New SqlManager()
        Dim objParamProcedure As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParamProcedure.Add("IN_CCLNT", obeFiltro.PSCCLNT)
        objParamProcedure.Add("IN_CCMPN", obeFiltro.PSCCMPN)
        objParamProcedure.Add("IN_CDVSN", obeFiltro.PSCDVSN)
        objParamProcedure.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
        objParamProcedure.Add("IN_FINVE", obeFiltro.PNFPROCE)
        objParamProcedure.Add("IN_TUBRFR", obeFiltro.PSTUBRFR)
        objParamProcedure.Add("IN_STPING", obeFiltro.PSSTPING)
        objParamProcedure.Add("IN_SSNCRG", obeFiltro.PSSSNCRG)
        'CSR-HUNDRED-071016-MATERIALES-PELIGROSOS-INICIO
        objParamProcedure.Add("IN_TIPMAT", obeFiltro.PSTIPMAT)
        objParamProcedure.Add("IN_CMATPE", obeFiltro.PSCMATPE)
        'CSR-HUNDRED-071016-MATERIALES-PELIGROSOS-FIN
        'Try
        'dtTemp = objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_BULTO_INVENTARIO_UBICACION", objParamProcedure)
        dsTemp = objSqlManager.ExecuteDataSet("SP_SOLMIN_SAT_BULTO_INVENTARIO_UBICACION_DIM", objParamProcedure)

        For Each ITEM As DataRow In dsTemp.Tables(0).Rows
            ITEM("FINGAL") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(ITEM("FINGAL"))
            ITEM("HORIDE") = RANSA.Utilitario.HelpClass.HoraNum_a_Hora(ITEM("HORIDE"))
            ITEM("FFACPR") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(ITEM("FFACPR"))

        Next
       

        Return dsTemp
    End Function



    'CSR-HUNDRED-INICIO

    Public Function ObtenerBultoInventarioXPedido(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
        Dim dtTemp As DataTable = Nothing
        Dim objSqlManager As SqlManager = New SqlManager()
        Dim objParamProcedure As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParamProcedure.Add("IN_CCLNT", obeFiltro.PSCCLNT)
        objParamProcedure.Add("IN_CCMPN", obeFiltro.PSCCMPN)
        objParamProcedure.Add("IN_CDVSN", obeFiltro.PSCDVSN)
        objParamProcedure.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
        objParamProcedure.Add("IN_FPROCE", obeFiltro.PNFPROCE)
        objParamProcedure.Add("IN_TUBRFR", obeFiltro.PSTUBRFR)
        objParamProcedure.Add("IN_STPING", obeFiltro.PSSTPING)
        objParamProcedure.Add("IN_SSNCRG", obeFiltro.PSSSNCRG)
        Try
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_BULTO_INVENTARIO_BULTOS_X_PEDIDO", objParamProcedure)
        Catch ex As Exception
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParamProcedure = Nothing
        End Try

    End Function
    'CSR-HUNDRED-FIN


    Public Function fdstGuiaSalidaMercaderia(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("IN_CCLNT", obeFiltro.PNCCLNT)
        objParametros.Add("IN_CCMPN", obeFiltro.PSCCMPN)
        objParametros.Add("IN_CDVSN", obeFiltro.PSCDVSN)
        objParametros.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
        objParametros.Add("IN_FECHA_INI", obeFiltro.PNFECINI)
        objParametros.Add("IN_FECHA_FIN", obeFiltro.PNFECFIN)
        objParametros.Add("IN_NPLCUN", obeFiltro.PSNPLCUN)

        Dim ds As New DataSet
        ds = objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_LISTAR_GUIA_SALIDA_MERCADERIA", objParametros)
        For Each item As DataRow In ds.Tables(0).Rows
            item("FSLDAL") = RANSA.Utilitario.HelpClass.FechaNum_a_Fecha(item("FSLDAL"))
        Next

        'Try
        Return ds
        'Catch ex As Exception
        '    Return New DataSet
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
    End Function



    Public Function fdstReporteIngresos(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        Try
            objParametros.Add("IN_CCLNT", obeFiltro.PNCCLNT)
            objParametros.Add("IN_CCMPN", obeFiltro.PSCCMPN)
            objParametros.Add("IN_CDVSN", obeFiltro.PSCDVSN)
            objParametros.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
            objParametros.Add("IN_CREFFW", obeFiltro.PSCREFFW)
            objParametros.Add("IN_FECINI", obeFiltro.PNFECINI)
            objParametros.Add("IN_FECFIN", obeFiltro.PNFECFIN)
            objParametros.Add("IN_STPING", obeFiltro.PSSTPING)
            Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SAT_REPORTE_INGRESO_POR_LOTE", objParametros)
        Catch ex As Exception
            Return New DataSet
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Public Function fdstListaDeLotesDeAlmacen(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        Try
            objParametros.Add("IN_CCLNT", obeFiltro.PNCCLNT)
            objParametros.Add("IN_CCMPN", obeFiltro.PSCCMPN)
            objParametros.Add("IN_CDVSN", obeFiltro.PSCDVSN)
            objParametros.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
            objParametros.Add("IN_CREFFW", obeFiltro.PSCREFFW)
            objParametros.Add("IN_FECINI", obeFiltro.PNFECINI)
            objParametros.Add("IN_FECFIN", obeFiltro.PNFECFIN)
            objParametros.Add("IN_STPING", obeFiltro.PSSTPING)
            objParametros.Add("IN_NORCML", obeFiltro.PSNORCML)
            objParametros.Add("IN_TLUGEN", obeFiltro.PSTLUGEN)
            Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_SAT_LISTA_INGRESO_POR_LOTE", objParametros)
        Catch ex As Exception
            Return New DataSet
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function

    Public Function fdstReporteMovimientoValorizado(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        Try

            objParametros.Add("IN_CCMPN", obeFiltro.PSCCMPN)
            objParametros.Add("IN_CDVSN", obeFiltro.PSCDVSN)
            objParametros.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
            objParametros.Add("IN_CCLNT", obeFiltro.PNCCLNT)
            objParametros.Add("IN_FMOVI", obeFiltro.PNFECINI)
            objParametros.Add("IN_FMOVF", obeFiltro.PNFECFIN)
            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_MOVIMIENTO_VALORIZADO", objParametros)
        Catch ex As Exception
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function



    Public Function fdstReporteIngDesPorEmbarque(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        Try

            objParametros.Add("IN_CCMPN", obeFiltro.PSCCMPN)
            objParametros.Add("IN_CDVSN", obeFiltro.PSCDVSN)
            objParametros.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
            objParametros.Add("IN_CCLNT", obeFiltro.PNCCLNT)
            objParametros.Add("IN_TIPO", obeFiltro.PNTIPO)
            objParametros.Add("IN_FMOVI", obeFiltro.PNFECINI)
            objParametros.Add("IN_FMOVF", obeFiltro.PNFECFIN)
            objParametros.Add("IN_NORCML", obeFiltro.PSNORCML)
            objParametros.Add("IN_NRITOC", obeFiltro.PNNRITOC)

            Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_CONSULTA_ING_DES_POR_EMBARQUE", objParametros)
        Catch ex As Exception
            Return New DataTable
        Finally
            objSqlManager = Nothing
            objParametros = Nothing
        End Try
    End Function
    Public Function fdtListarSalidaUnidades(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataSet
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParametros.Add("IN_CCLNT", obeFiltro.PSCCLNT)
        objParametros.Add("IN_CCMPN", obeFiltro.PSCCMPN)
        objParametros.Add("IN_CDVSN", obeFiltro.PSCDVSN)
        objParametros.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
        objParametros.Add("IN_FECHA_INI", obeFiltro.PNFECINI)
        objParametros.Add("IN_FECHA_FIN", obeFiltro.PNFECFIN)
        objParametros.Add("IN_NPLCUN", obeFiltro.PSNPLCUN)
        'Try
        Return objSqlManager.ExecuteDataSet("SP_SOLMIN_SA_LISTAR_SALIDA_DE_UNIDADES", objParametros)
        'Catch ex As Exception
        '    Return New DataSet
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
    End Function

#End Region

    '#Region "Reportes DS"

    '#End Region

    '#Region "Reportes DA"

    '#End Region
#Region "Modelo Perenco"
    Public Function frptInventarioAlmacenModeloPerenco(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
        Dim dtTemp As DataTable = Nothing
        Dim dt As New DataTable
        Dim objSqlManager As SqlManager = New SqlManager()
        Dim objParamProcedure As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        objParamProcedure.Add("IN_CCLNT", obeFiltro.PSCCLNT)
        objParamProcedure.Add("IN_CCMPN", obeFiltro.PSCCMPN)
        objParamProcedure.Add("IN_CDVSN", obeFiltro.PSCDVSN)
        objParamProcedure.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
        objParamProcedure.Add("IN_FINVE", obeFiltro.PNFPROCE)
        objParamProcedure.Add("IN_TUBRFR", obeFiltro.PSTUBRFR)
        objParamProcedure.Add("IN_STPING", obeFiltro.PSSTPING)
        objParamProcedure.Add("IN_SSNCRG", obeFiltro.PSSSNCRG)
        dt = objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_BULTO_INVENTARIO_UBICACION_PERENCO", objParamProcedure)
        For Each item As DataRow In dt.Rows
            item("HORIDE") = Ransa.Utilitario.HelpClass.HoraNum_a_Hora_Cadena(item("HORIDE"))
        Next

        'Try
        '    Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SAT_BULTO_INVENTARIO_UBICACION_PERENCO", objParamProcedure)
        'Catch ex As Exception
        '    Return New DataTable
        'Finally
        '    objSqlManager = Nothing
        '    objParamProcedure = Nothing
        'End Try
        Return dt
    End Function
    Public Function fdtDespachoPorAlmacenModeloPerenco(ByVal obeFiltro As beFiltrosDespachoPorAlmacen) As DataTable
        Dim objSqlManager As SqlManager = New SqlManager
        Dim objParametros As Parameter = New Parameter
        objSqlManager.TransactionController(TransactionType.Automatic)
        ' Ingresamos los parametros del Procedure
        'Try
        objParametros.Add("IN_CCLNT", obeFiltro.PSCCLNT)
        objParametros.Add("IN_CCMPN", obeFiltro.PSCCMPN)
        objParametros.Add("IN_CDVSN", obeFiltro.PSCDVSN)
        objParametros.Add("IN_CPLNDV", obeFiltro.PNCPLNDV)
        objParametros.Add("IN_CREFFW", obeFiltro.PSCREFFW)
        objParametros.Add("IN_FECINI", obeFiltro.PNFECINI)
        objParametros.Add("IN_FECFIN", obeFiltro.PNFECFIN)
        objParametros.Add("IN_TUBRFR", obeFiltro.PSTUBRFR)
        objParametros.Add("IN_STPING", obeFiltro.PSSTPING)
        Return objSqlManager.ExecuteDataTable("SP_SOLMIN_SA_SAT_REPORTE_DESPACHO_POR_ALMACEN_MODELO_PERENCO", objParametros)
        'Catch ex As Exception
        '    Return New DataTable
        'Finally
        '    objSqlManager = Nothing
        '    objParametros = Nothing
        'End Try
    End Function

#End Region
End Class


