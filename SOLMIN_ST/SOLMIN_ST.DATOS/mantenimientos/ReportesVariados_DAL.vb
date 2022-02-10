Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports Ransa.Utilitario

Namespace mantenimientos

  Public Class ReportesVariados_DAL
    Private objSql As New SqlManager

    Public Function Listado_Seguro_Flete(ByVal objcoleccion As Collection) As DataSet
      Dim objResultado As New DataSet
            'Try

            Dim objparam As New Parameter
            objparam.Add("PARAM_FECINI", objcoleccion(1).ToString())
            objparam.Add("PARAM_FECFIN", objcoleccion(2).ToString())
            objparam.Add("PARAM_CCMPN", objcoleccion(3).ToString())
            objparam.Add("PARAM_CDVSN", objcoleccion(4).ToString())
            objparam.Add("PARAM_CPLNDV", objcoleccion(5).ToString())
            objparam.Add("PARAM_CTRSPT", objcoleccion(6).ToString())
            objparam.Add("PARAM_CCLNT1", objcoleccion(7).ToString())

            Dim dt As New DataTable
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objcoleccion(3).ToString())
            dt = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_SEGURO_LA", objparam)
            dt.TableName = "REPORTE_SEGURO"

            For Each dr As DataRow In dt.Rows
                dr("FGUIRM") = HelpClass.CFecha_de_8_a_10(dr("FGUIRM").ToString.Trim)
            Next

            objResultado.Tables.Add(dt)
            'Catch ex As Exception
            '          MsgBox(ex.Message)
            '      End Try
            Return objResultado
    End Function

    Public Function ReporteMensual(ByVal objEntidad As ReporteMensualEntidad) As DataSet
      Dim objResultado As New DataSet
            'Try

            Dim objParam As New Parameter
            objParam.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam.Add("PARAM_CDVSN", objEntidad.CDVSN)
            objParam.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
            objParam.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objParam.Add("PARAM_FGUITR_INI", objEntidad.FGUITR_INI)
            objParam.Add("PARAM_FGUITR_FIN", objEntidad.FGUITR_FIN)
            objParam.Add("PARAM_CTRSPT", objEntidad.CTRSPT)
            objParam.Add("PARAM_NPLVHT", objEntidad.NPLVHT)

            'Declarando el Datatable de el reporte mensual
            Dim dtbReporteMensual As New DataTable
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objEntidad.CCMPN)
            dtbReporteMensual = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_MENSUAL", objParam)
            dtbReporteMensual.TableName = "ReporteMensual"

            Dim objParam2 As New Parameter
            objParam2.Add("PARAM_CCMPN", objEntidad.CCMPN)
            objParam2.Add("PARAM_CDVSN", objEntidad.CDVSN)
            objParam2.Add("PARAM_CPLNDV", objEntidad.CPLNDV)
            objParam2.Add("PARAM_CCLNT", objEntidad.CCLNT)
            objParam2.Add("PARAM_FGUITR_INI", objEntidad.FGUITR_INI)
            objParam2.Add("PARAM_FGUITR_FIN", objEntidad.FGUITR_FIN)

            Dim dtbEstadistica As New DataTable
            dtbEstadistica = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_MENSUAL_ESTADISTICA", objParam2)
            dtbEstadistica.TableName = "ESTADISTICA_REPORTE_MENSUAL"

            'Agregando la tabla al DataSet
            objResultado.Tables.Add(dtbReporteMensual)
            objResultado.Tables.Add(dtbEstadistica)

            'Catch ex As Exception

            '      End Try
            Return objResultado

    End Function

    Public Function Datos_Reporte_Guias_ABC(ByVal ht As Hashtable) As DataSet
            'Try
            Dim objData As New DataSet
            Dim objParametros As New Parameter
            objSql.TransactionController(TransactionType.Automatic)

            objParametros.Add("IN_CMPN", ht.Item("CMPN").ToString)
            objParametros.Add("IN_CDVSN", ht.Item("CDVSN").ToString)
            objParametros.Add("IN_CPLNDV", ht.Item("CPLNDV").ToString)
            objParametros.Add("IN_CCLNT", ht.Item("CCLNT").ToString)
            objParametros.Add("IN_FGUITR_I", CType(ht.Item("FGUITR_I").ToString, Integer))
            objParametros.Add("IN_FGUITR_F", CType(ht.Item("FGUITR_F").ToString, Integer))

            ' objData = objSql.ExecuteDataSet("SP_SOLMIN_TR_REPORTE_RGUIA", objParametros)

            Dim dt1 As New DataTable
            Dim dt2 As New DataTable
            Dim dt3 As New DataTable

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CMPN").ToString)

            dt1 = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_RGUIA_1", objParametros)
            'dt1 = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_RGUIA_1_PRD", objParametros)
            dt1.TableName = "dtResumenTotal"
            objData.Tables.Add(dt1)

            dt2 = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_RGUIA_2", objParametros)
            'dt2 = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_RGUIA_2_PRD", objParametros)
            dt2.TableName = "dtResumenServiciosClientes"
            objData.Tables.Add(dt2)

            dt3 = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_RGUIA_3", objParametros)
            'dt3 = objSql.ExecuteDataTable("SP_SOLMIN_TR_REPORTE_RGUIA_3_PRD", objParametros)
            dt3.TableName = "dtDetalleServiciosClientes"
            objData.Tables.Add(dt3)

            objSql = Nothing
            objParametros = Nothing

            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try
    End Function

        Public Function frptMovimientoOperaciones_v2(ByVal ht As Hashtable) As DataSet
            'Try
            Dim objData As New DataSet
            Dim objParametros As New Parameter
            'Tiempo de Respuesta de 5 minutos
            objSql.TiempoRespuesta = 18000
            objSql.TransactionController(TransactionType.Automatic)

            objParametros.Add("ISTR_CCMPN", ht.Item("CCMPN")) 'VARCHAR(2)
            objParametros.Add("ISTR_CDVSN", ht.Item("CDVSN")) 'VARCHAR(1)
            objParametros.Add("IINT_CPLNDV", ht.Item("CPLNDV")) 'NUMERIC(3, 0)
            objParametros.Add("IINT_STSTIP", ht.Item("STSTIP"))
            objParametros.Add("ISTR_FINCOP_IN", ht.Item("FINCOP_IN")) 'VARCHAR(8)
            objParametros.Add("ISTR_FINCOP_FI", ht.Item("FINCOP_FI")) 'VARCHAR(8)
            objParametros.Add("ISTR_CCLNTS", ht.Item("CCLNT")) 'VARCHAR(256)
            'objParametros.Add("ISTR_STATUS", ht.Item("STATUS")) 'VARCHAR(1)
            objParametros.Add("ISTR_ESTADO", ht.Item("ESTADO"))
            objParametros.Add("ISTR_CTRSPT", ht.Item("CTRSPT"))
            objParametros.Add("ISTR_NDCMFC", ht.Item("NDCMFC"))
            objParametros.Add("ISTR_NPRLQD", ht.Item("NPRLQD"))
            objParametros.Add("ISTR_NDCPRF", ht.Item("NDCPRF"))
            objParametros.Add("ISTR_NOPRCN", ht.Item("NOPRCN"))
            'objParametros.Add("ISTR_VARCON", ht.Item("VARCON"))
            objParametros.Add("IINT_CMEDTR", ht.Item("CMEDTR"))
            objParametros.Add("IINT_NDCORM", ht.Item("NDCORM"))
            objParametros.Add("IINT_NORINS", ht.Item("NORINS"))
            'objParametros.Add("IINT_STSTIP", ht.Item("STSTIP"))
            objParametros.Add("ISTR_TIPVJE", ht.Item("TIPVJE"))
            objParametros.Add("ISTR_NPLVHT", ht.Item("NPLVHT"))
            objParametros.Add("ISTR_SSINVJ", ht.Item("SSINVJ"))
            objParametros.Add("ISTR_REGION", ht.Item("PSREGION"))
            REM ECM-HUNDRED-INICIO
            objParametros.Add("ISTR_CCLNF", ht.Item("CCLNF")) 'VARCHAR(256)
            objParametros.Add("ISTR_FTRTSG", ht.Item("FTRTSG"))

           
            


            REM ECM-HUNDRED-FIN
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))

            objData = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPERACION_SALM_v2", objParametros)


            Return objData
          

        End Function


        Public Function calcularPesoAlmxGuiaTransporte(jsguias As String)

            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objSql.TransactionController(TransactionType.Automatic)
            objParametros.Add("PSLISTJSON", jsguias)
            REM ECM-HUNDRED-FIN
            'objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_CALCULAR_PESOGUIACLIENTE_X_GUIATRANSPORTE", objParametros)
            Return objData


        End Function





        Public Function frptMovimientoOperaciones_v3(ByVal ht As Hashtable) As DataSet
            'Try
            Dim objData As New DataSet
            Dim objParametros As New Parameter
            'Tiempo de Respuesta de 5 minutos
            objSql.TiempoRespuesta = 18000
            objSql.TransactionController(TransactionType.Automatic)

            objParametros.Add("ISTR_CCMPN", ht.Item("CCMPN")) 'VARCHAR(2)
            objParametros.Add("ISTR_CDVSN", ht.Item("CDVSN")) 'VARCHAR(1)
            objParametros.Add("IINT_CPLNDV", ht.Item("CPLNDV")) 'NUMERIC(3, 0)
            objParametros.Add("IINT_STSTIP", ht.Item("STSTIP"))
            objParametros.Add("ISTR_FINCOP_IN", ht.Item("FINCOP_IN")) 'VARCHAR(8)
            objParametros.Add("ISTR_FINCOP_FI", ht.Item("FINCOP_FI")) 'VARCHAR(8)
            objParametros.Add("ISTR_CCLNTS", ht.Item("CCLNT")) 'VARCHAR(256)

            objParametros.Add("ISTR_ESTADO", ht.Item("ESTADO"))
            objParametros.Add("ISTR_CTRSPT", ht.Item("CTRSPT"))

          

            objParametros.Add("IINT_CMEDTR", ht.Item("CMEDTR"))
          

            objParametros.Add("ISTR_TIPVJE", ht.Item("TIPVJE"))
            objParametros.Add("ISTR_NPLVHT", ht.Item("NPLVHT"))
            objParametros.Add("ISTR_SSINVJ", ht.Item("SSINVJ"))
            objParametros.Add("ISTR_REGION", ht.Item("PSREGION"))
            REM ECM-HUNDRED-INICIO
            objParametros.Add("ISTR_CCLNF", ht.Item("CCLNF")) 'VARCHAR(256)
            objParametros.Add("ISTR_FTRTSG", ht.Item("FTRTSG"))



            objParametros.Add("INSTR_TIPO", ht.Item("TIPO"))
            objParametros.Add("INSTR_VALOR_TIPO", ht.Item("VALOR_TIPO"))

            objParametros.Add("ISTR_ESTADO_VLRZ", ht.Item("ESTADO_VLRZ"))
            objParametros.Add("ISTR_ESTADO_COMB", ht.Item("ESTADO_COMB"))

            objParametros.Add("ISTR_CDUPSP", ht.Item("CDUPSP"))


            REM ECM-HUNDRED-FIN
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))


            objData = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPERACION_SALM_V3", objParametros)


            Return objData


        End Function



        Public Function frptMovimientoOperaciones(ByVal ht As Hashtable) As DataSet
            'Try
            Dim objData As New DataSet
            Dim objParametros As New Parameter
            'Tiempo de Respuesta de 5 minutos
            objSql.TiempoRespuesta = 18000
            objSql.TransactionController(TransactionType.Automatic)

            objParametros.Add("ISTR_CCMPN", ht.Item("CCMPN")) 'VARCHAR(2)
            objParametros.Add("ISTR_CDVSN", ht.Item("CDVSN")) 'VARCHAR(1)
            objParametros.Add("IINT_CPLNDV", ht.Item("CPLNDV")) 'NUMERIC(3, 0)
            objParametros.Add("ISTR_FINCOP_IN", ht.Item("FINCOP_IN")) 'VARCHAR(8)
            objParametros.Add("ISTR_FINCOP_FI", ht.Item("FINCOP_FI")) 'VARCHAR(8)
            objParametros.Add("ISTR_CCLNTS", ht.Item("CCLNT")) 'VARCHAR(256)

            objParametros.Add("ISTR_STATUS", ht.Item("STATUS")) 'VARCHAR(1)
            objParametros.Add("ISTR_ESTADO", ht.Item("ESTADO"))
            objParametros.Add("ISTR_CTRSPT", ht.Item("CTRSPT"))
            objParametros.Add("ISTR_NDCMFC", ht.Item("NDCMFC"))
            objParametros.Add("ISTR_NPRLQD", ht.Item("NPRLQD"))
            objParametros.Add("ISTR_NDCPRF", ht.Item("NDCPRF"))
            objParametros.Add("ISTR_NOPRCN", ht.Item("NOPRCN"))
            objParametros.Add("ISTR_VARCON", ht.Item("VARCON"))
            objParametros.Add("IINT_CMEDTR", ht.Item("CMEDTR"))
            objParametros.Add("IINT_NDCORM", ht.Item("NDCORM"))
            objParametros.Add("IINT_NORINS", ht.Item("NORINS"))

            objParametros.Add("IINT_STSTIP", ht.Item("STSTIP"))
            objParametros.Add("ISTR_TIPVJE", ht.Item("TIPVJE"))
            objParametros.Add("ISTR_NPLVHT", ht.Item("NPLVHT"))
            objParametros.Add("ISTR_SSINVJ", ht.Item("SSINVJ"))
            objParametros.Add("ISTR_REGION", ht.Item("PSREGION"))

            REM ECM-HUNDRED-INICIO
            objParametros.Add("ISTR_CCLNF", ht.Item("CCLNF")) 'VARCHAR(256)
            REM ECM-HUNDRED-FIN

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))

            'objData = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPERACION_LM_10", objParametros)
            objData = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPERACION_SALM", objParametros)


            Return objData
            'Catch ex As Exception
            '    Return Nothing
            'End Try

        End Function
    ''' <summary>
    ''' '
    ''' </summary>
    ''' <param name="ht"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReporteOperacionesPorGuiaTR(ByVal ht As Hashtable) As DataSet
            'Try
            Dim objData As New DataSet
            Dim objParametros As New Parameter
            Dim sumaTotalGuia As Double = 0.0
            Dim FleteItem As Double = 0.0
            Dim NumGuiaTmp As Double = 0.0
            Dim oListaOrdenCompra As New List(Of OrdenCompra)
            objSql.TransactionController(TransactionType.Automatic)

            objParametros.Add("iSTR_CCMPN", ht.Item("CCMPN")) 'VARCHAR(2)
            objParametros.Add("iSTR_CDVSN", ht.Item("CDVSN")) 'VARCHAR(1)
            objParametros.Add("iINT_CPLNDV", ht.Item("CPLNDV")) 'NUMERIC(3, 0)
            objParametros.Add("iSTR_FINCOP_IN", ht.Item("FINCOP_IN")) 'VARCHAR(8)
            objParametros.Add("iSTR_FINCOP_FI", ht.Item("FINCOP_FI")) 'VARCHAR(8)
            objParametros.Add("iSTR_CCLNTS", IIf(ht.Item("CCLNT") = "0", "", ht.Item("CCLNT"))) 'VARCHAR(256)
            objParametros.Add("iSTR_STATUS", ht.Item("STATUS")) 'VARCHAR(1)
            objParametros.Add("PSSORGMV", ht.Item("SORGMV")) 'VARCHAR(1)
            objParametros.Add("PSNORCML", ht.Item("NORCML")) 'VARCHAR(1)
            objParametros.Add("ISTR_CCLNTSF", IIf(ht.Item("CCLNTS_F") = "0", "", ht.Item("CCLNTS_F"))) 'VARCHAR(256)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))

            objData = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPERACIONES_GUIA_TRTMP4", objParametros)
            'objData = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPERACIONES_GUIA_TRTMP3_PRD", objParametros)
            'objData.Tables(0).Columns.Add("FleteItem", Type.GetType("System.Double"))
            objData.Tables(0).Columns.Add(New DataColumn("FLETEITEM", Type.GetType("System.Double")))
            'objData.Tables(0).Columns.Add("FleteItem", GetType(Double))

            For index As Integer = 0 To objData.Tables(0).Rows.Count - 1
                If (IsDBNull(objData.Tables(0).Rows(index).Item("TOTALGUIA")) = True) Then
                    objData.Tables(0).Rows(index).Item("FLETEITEM") = Convert.ToDouble(0)
                ElseIf (objData.Tables(0).Rows(index).Item("TOTALGUIA") = 0) Then
                    objData.Tables(0).Rows(index).Item("FLETEITEM") = Convert.ToDouble(0)
                Else
                    objData.Tables(0).Rows(index).Item("FLETEITEM") = (Math.Round((Convert.ToDouble(objData.Tables(0).Rows(index).Item("IMPPA")) * Convert.ToDouble(objData.Tables(0).Rows(index).Item("PRUNI"))) / Convert.ToDouble(objData.Tables(0).Rows(index).Item("TOTALGUIA")), 4))

                End If
            Next
            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try
    End Function


    Public Function ReporteOperacionesPorOrdeDeCompra(ByVal ht As Hashtable) As DataSet
            'Try
            Dim objData As New DataSet
            Dim objParametros As New Parameter
            objSql.TransactionController(TransactionType.Automatic)

            objParametros.Add("iSTR_CCMPN", ht.Item("CCMPN")) 'VARCHAR(2)
            objParametros.Add("iSTR_CDVSN", ht.Item("CDVSN")) 'VARCHAR(1)
            objParametros.Add("iINT_CPLNDV", ht.Item("CPLNDV")) 'NUMERIC(3, 0)
            objParametros.Add("iSTR_FINCOP_IN", ht.Item("FINCOP_IN")) 'VARCHAR(8)
            objParametros.Add("iSTR_FINCOP_FI", ht.Item("FINCOP_FI")) 'VARCHAR(8)
            objParametros.Add("iSTR_CCLNTS", IIf(ht.Item("CCLNT") = "0", "", ht.Item("CCLNT"))) 'VARCHAR(256)
            objParametros.Add("iSTR_STATUS", ht.Item("STATUS")) 'VARCHAR(1)
            objParametros.Add("PSSORGMV", ht.Item("SORGMV")) 'VARCHAR(1)
            objParametros.Add("PSNORCML", ht.Item("NORCML")) 'VARCHAR(1)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))

            objData = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPERACIONES_ORDEN_COMPRA", objParametros)
            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try
    End Function

    Public Function Reporte_Facturacion_Operaciones(ByVal objColeccion As List(Of String)) As DataSet
      Dim objResultado As New DataSet
            'Try
            Dim objParam As New Parameter

            objParam.Add("PARAM_CCMPN", objColeccion(0))
            objParam.Add("PARAM_CDVSN", objColeccion(1))
            objParam.Add("PARAM_CPLNDV", objColeccion(2))
            objParam.Add("PARAM_CCLNT", objColeccion(3))
            objParam.Add("PARAM_FINCOP_IN", objColeccion(4))
            objParam.Add("PARAM_FINCOP_FI", objColeccion(5))
            objParam.Add("PARAM_CTRSPT", objColeccion(6))
            objParam.Add("PARAM_ESTADO", objColeccion(7))
            objParam.Add("PARAM_OPCION", objColeccion(8))
            objParam.Add("PARAM_REGION", objColeccion(9))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objColeccion(0))

            objResultado = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPERACION_FACTURADA_1", objParam)

            'Catch ex As Exception
            '          MsgBox(ex.Message)
            '      End Try
            Return objResultado
    End Function

    'Public Function Reporte_Guia_Transportista(ByVal ht As Hashtable) As DataSet
    '    Try
    '        Dim objDs As New DataSet
    '        Dim objParametros As New Parameter
    '        objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
    '        objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
    '        objParametros.Add("PNCPLNDV", ht.Item("CPLNDV"))
    '        objParametros.Add("PNFECINI", ht.Item("FECINI"))
    '        objParametros.Add("PNFECFIN", ht.Item("FECFIN"))
    '        objParametros.Add("PNCTRSPT", ht.Item("CTRSPT"))
    '        objParametros.Add("PNNRUCTR", ht.Item("NRUCTR"))
    '        objParametros.Add("PSCTITRA", ht.Item("CTITRA"))

    '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
    '        objDs = objSql.ExecuteDataSet("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA", objParametros)
    '        objDs.Tables(0).TableName = "Guia_Transportista_Facturada"
    '        objDs.Tables(1).TableName = "Vales_x_Transportista_Facturada"
    '        objDs.Tables(2).TableName = "Notas_de_Debito_y_Credito"
    '        Return objDs
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function

    Public Function Reporte_Guia_Transportista_Facturada(ByVal ht As Hashtable) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
            objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
            objParametros.Add("PNCPLNDV", ht.Item("CPLNDV"))
            objParametros.Add("PNFECINI", ht.Item("FECINI"))
            objParametros.Add("PNFECFIN", ht.Item("FECFIN"))
            objParametros.Add("PNCTRSPT", ht.Item("CTRSPT")) 'Transportista
            objParametros.Add("PSCTITRA", ht.Item("CTITRA")) 'Tipo trasnporte
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_FACTURADA", objParametros)
            'objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_FACTURADA_PRD", objParametros)
            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try
        End Function

        Public Function Reporte_Guia_Transportista_Facturada_Distribucion(ByVal ht As Hashtable) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
            objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
            objParametros.Add("PNCPLNDV", ht.Item("CPLNDV"))
            objParametros.Add("PNFECINI", ht.Item("FECINI"))
            objParametros.Add("PNFECFIN", ht.Item("FECFIN"))
            objParametros.Add("PNCTRSPT", ht.Item("CTRSPT")) 'Transportista
            objParametros.Add("PSCTITRA", ht.Item("CTITRA")) 'Tipo trasnporte
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_FACTURADA_DISTRIBUCION", objParametros)
            'objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_FACTURADA_PRD", objParametros)
            Return objData
            'Catch ex As Exception
            '    Return Nothing
            'End Try
        End Function


    Public Function Reporte_Guia_Transportista_Anexo_3(ByVal ht As Hashtable) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
            objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
            objParametros.Add("PNCPLNDV", ht.Item("CPLNDV"))
            objParametros.Add("PNFECINI", ht.Item("FECINI"))
            objParametros.Add("PNFECFIN", ht.Item("FECFIN"))
            objParametros.Add("PNCTRSPT", ht.Item("CTRSPT"))
            objParametros.Add("PSCTITRA", ht.Item("CTITRA"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            'objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_ANEXO_3_PRD", objParametros)
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_ANEXO_3", objParametros)
            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try
        End Function

        Public Function Reporte_Guia_Transportista_Anexo_3_Distribucion(ByVal ht As Hashtable) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
            objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
            objParametros.Add("PNCPLNDV", ht.Item("CPLNDV"))
            objParametros.Add("PNFECINI", ht.Item("FECINI"))
            objParametros.Add("PNFECFIN", ht.Item("FECFIN"))
            objParametros.Add("PNCTRSPT", ht.Item("CTRSPT"))
            objParametros.Add("PSCTITRA", ht.Item("CTITRA"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            'objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_ANEXO_3_PRD", objParametros)
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_ANEXO_3_DISTRIBUCION", objParametros)
            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try
        End Function


    Public Function Reporte_Guia_Transportista_Anexo_31(ByVal ht As Hashtable) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
            objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
            objParametros.Add("PNCPLNDV", ht.Item("CPLNDV"))
            objParametros.Add("PNFECINI", ht.Item("FECINI"))
            objParametros.Add("PNFECFIN", ht.Item("FECFIN"))
            objParametros.Add("PNCTRSPT", ht.Item("CTRSPT"))
            objParametros.Add("PSCTITRA", ht.Item("CTITRA"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_ANEXO_31", objParametros)
            'objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_ANEXO_31_PRD", objParametros)
            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try
        End Function

        Public Function Reporte_Guia_Transportista_Anexo_31_Distribucion(ByVal ht As Hashtable) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
            objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
            objParametros.Add("PNCPLNDV", ht.Item("CPLNDV"))
            objParametros.Add("PNFECINI", ht.Item("FECINI"))
            objParametros.Add("PNFECFIN", ht.Item("FECFIN"))
            objParametros.Add("PNCTRSPT", ht.Item("CTRSPT"))
            objParametros.Add("PSCTITRA", ht.Item("CTITRA"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_ANEXO_31_DISTRIBUCION", objParametros)
            'objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_GUIA_TRANSPORTISTA_ANEXO_31_PRD", objParametros)
            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try
        End Function


    Public Function Reporte_Vales_x_Transportista_Facturada(ByVal ht As Hashtable) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
            objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
            objParametros.Add("PNCPLNDV", ht.Item("CPLNDV"))
            objParametros.Add("PNFECINI", ht.Item("FECINI"))
            objParametros.Add("PNFECFIN", ht.Item("FECFIN"))
            objParametros.Add("PNNRUCTR", ht.Item("NRUCTR"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VALES_X_TRANSPORTISTA_FACTURADA", objParametros)
            'objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VALES_X_TRANSPORTISTA_FACTURADA_PRD", objParametros)
            Return objData
            'Catch ex As Exception
            '  Return Nothing
            'End Try
        End Function

    Public Function Reporte_Vales_x_Transportista_Asignada(ByVal ht As Hashtable) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
            objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
            objParametros.Add("PNCPLNDV", ht.Item("CPLNDV"))
            objParametros.Add("PNFECINI", ht.Item("FECINI"))
            objParametros.Add("PNFECFIN", ht.Item("FECFIN"))
            objParametros.Add("PNNRUCTR", ht.Item("NRUCTR"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VALES_X_TRANSPORTISTA_ASIGNADA", objParametros)
            'objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_VALES_X_TRANSPORTISTA_ASIGNADA_PRD", objParametros)
            Return objData
            'Catch ex As Exception
            '  Return Nothing
            'End Try
        End Function

    Public Function Reporte_Notas_de_Credito_y_Debito(ByVal ht As Hashtable) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
            objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
            objParametros.Add("PNCPLNDV", ht.Item("CPLNDV"))
            objParametros.Add("PNFECINI", ht.Item("FECINI"))
            objParametros.Add("PNFECFIN", ht.Item("FECFIN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_NOTAS_DE_CREDITO_Y_DEBITO", objParametros)
            'objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_NOTAS_DE_CREDITO_Y_DEBITO_PRD", objParametros)
            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try
    End Function

    Public Function Lista_Region_Venta(ByVal strCCMPN As String) As DataTable
      Dim objData As New DataTable
      Dim objParametros As New Parameter
            'Try
            objParametros.Add("PSCCMPN", strCCMPN)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(strCCMPN)
            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTA_REGION_VENTA", objParametros)
            'Catch ex As Exception
            '          objData = New DataTable
            '      End Try
            Return objData
    End Function

    Public Function Reporte_Consistencia_Operaciones(ByVal objColeccion As List(Of String)) As DataTable
      Dim objResultado As New DataTable
            'Try
            Dim objParam As New Parameter

            objParam.Add("PSCCMPN", objColeccion(0))
            objParam.Add("PSCDVSN", objColeccion(1))
            objParam.Add("PNCPLNDV", objColeccion(2))
            If objColeccion(6) <> 0 Then
                objParam.Add("PNCTRSPT", objColeccion(6))
            End If
            If objColeccion(5) <> 0 Then
                objParam.Add("PNCCLNT", objColeccion(5))
            End If
            objParam.Add("PNFINCOP_IN", objColeccion(3))
            objParam.Add("PNFINCOP_FI", objColeccion(4))
            objParam.Add("PSESTADO", objColeccion(7))
            objParam.Add("PNOPCION", objColeccion(8))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objColeccion(0))

            If objColeccion(5) = 0 And objColeccion(6) = 0 Then
                objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_CONSISTENCIA_OPERACION_2", objParam) 'SP_SOLMIN_ST_REPORTE_CONSISTENCIA_OPERACION
                'objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_CONSISTENCIA_OPERACION_2_PRD", objParam)
            Else
                If objColeccion(5) <> 0 And objColeccion(6) <> 0 Then
                    objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_CONSISTENCIA_OPERACION_5", objParam)
                    'objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_CONSISTENCIA_OPERACION_5_PRD", objParam)
                Else
                    If objColeccion(6) <> 0 Then
                        objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_CONSISTENCIA_OPERACION_3", objParam)
                        'objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_CONSISTENCIA_OPERACION_3_PRD", objParam)
                    Else
                        objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_CONSISTENCIA_OPERACION_4", objParam)
                        'objResultado = objSql.ExecuteDataTable("SP_SOLMIN_ST_REPORTE_CONSISTENCIA_OPERACION_4_PRD", objParam)
                    End If
                End If
            End If

            For intContador As Int64 = 0 To objResultado.Rows.Count - 1

                Select Case objResultado.Rows(intContador).Item("ESTADO")
                    Case 0
                        If (objResultado.Rows(intContador).Item("PMRCMC") > 0) Then
                            If (objResultado.Rows(intContador).Item("PMRCMC") / 1000) >= (objResultado.Rows(intContador).Item("QCRUTV") * 0.7) Then
                                objResultado.Rows(intContador).Item("VLRFDT") = objResultado.Rows(intContador).Item("VLRFDT") * (objResultado.Rows(intContador).Item("PMRCMC") / 1000)
                            Else
                                objResultado.Rows(intContador).Item("VLRFDT") = objResultado.Rows(intContador).Item("VLRFDT") * (objResultado.Rows(intContador).Item("QCRUTV") * 0.7)
                            End If
                        Else
                            objResultado.Rows(intContador).Item("VLRFDT") = objResultado.Rows(intContador).Item("VLRFDT") * 0.7 * objResultado.Rows(intContador).Item("QCRUTV")
                        End If
                        If (objResultado.Rows(intContador).Item("CMNTRN_1") = 1) Then
                            objResultado.Rows(intContador).Item("IMPCOB") = objResultado.Rows(intContador).Item("IMPCOB") / objResultado.Rows(intContador).Item("ITPCMT")
                        End If
                        If (objResultado.Rows(intContador).Item("CMNTRN_2") = 1) Then
                            objResultado.Rows(intContador).Item("ASEGUR") = objResultado.Rows(intContador).Item("ASEGUR") / objResultado.Rows(intContador).Item("ITPCMT")
                        End If
                        If (objResultado.Rows(intContador).Item("CMNTRN_3") = 1) Then
                            objResultado.Rows(intContador).Item("SEGURI") = objResultado.Rows(intContador).Item("SEGURI") / objResultado.Rows(intContador).Item("ITPCMT")
                        End If
                End Select

            Next
            objResultado.Columns.Remove("ESTADO")
            objResultado.Columns.Remove("QCRUTV")
            objResultado.Columns.Remove("PMRCMC")
            objResultado.Columns.Remove("ITPCMT")
            objResultado.Columns.Remove("CMNTRN_1")
            objResultado.Columns.Remove("CMNTRN_2")
            objResultado.Columns.Remove("CMNTRN_3")

            'Catch ex As Exception
            '          MsgBox(ex.Message)
            '      End Try
            Return objResultado
    End Function

    Public Function Lista_Operaciones_Seguimiento_Administrativo(ByVal ht As Hashtable) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objSql.TransactionController(TransactionType.Automatic)
            objParametros.Add("PSCCMPN", ht.Item("CCMPN"))
            objParametros.Add("PSCDVSN", ht.Item("CDVSN"))
            objParametros.Add("PSCPLNDV", ht.Item("CPLNDV"))
            objParametros.Add("PNFECINI", ht.Item("FINCOP_IN"))
            objParametros.Add("PNFECFIN", ht.Item("FINCOP_FI"))
            objParametros.Add("PNCCLNT", ht.Item("CCLNT"))
            objParametros.Add("PNNGUITR", ht.Item("NGUITR"))
            objParametros.Add("PNNOPRCN", ht.Item("NOPRCN"))
            objParametros.Add("PNCMEDTR", ht.Item("CMEDTR"))
            objParametros.Add("PSESTADO", ht.Item("ESTADO"))
            objParametros.Add("PSCULUSA", ht.Item("CULUSA"))
            objParametros.Add("PESTADO_OPER", ht.Item("ESTADO_OPER"))
            objParametros.Add("PNVARCON", ht.Item("VARCON"))

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))

            objData = objSql.ExecuteDataTable("SP_SOLMIN_ST_SEGUIMIENTO_ADMINISTRATIVO_OPERACION_LA", objParametros)

            For Each dr As DataRow In objData.Rows
                dr("FINCOP") = HelpClass.CFecha_de_8_a_10(dr("FINCOP").ToString.Trim)
                dr("FDCPRF") = HelpClass.CFecha_de_8_a_10(dr("FDCPRF").ToString.Trim)
                dr("FGUITR") = HelpClass.CFecha_de_8_a_10(dr("FGUITR").ToString.Trim)
            Next

            Return objData
            'Catch ex As Exception
            '    Return Nothing
            'End Try

    End Function

    Public Function Lista_CorrelativoControl(ByVal strCadena As String) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objSql.TransactionController(TransactionType.Automatic)
            objParametros.Add("PSCCMPN", strCadena)
            objData = objSql.ExecuteDataTable("SP_SOLCT_CONTROL_NUMERACION", objParametros)
            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try

    End Function

    Public Function Lista_SeguimientoPorOperacion(ByVal nOperacion As Decimal) As DataTable
            'Try
            Dim objData As New DataTable
            Dim objParametros As New Parameter
            objSql.TransactionController(TransactionType.Automatic)
            objParametros.Add("PNNOPRCN", nOperacion)
            objData = objSql.ExecuteDataTable("SP_SOLST_LISTA_SEGUIMIENTO_POR_OPERACION", objParametros)
            Return objData
            'Catch ex As Exception
            '          Return Nothing
            '      End Try

    End Function
        Public Function Reporte_Refacturacion_X_Operaciones_NC(ByVal ht As Hashtable) As DataSet
            Dim dtbReporte As New DataSet
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", ht.Item("CCMPN"))
            objParam.Add("PSCDVSN", ht.Item("CDVSN"))
            objParam.Add("PSCPLNDV", ht.Item("CPLNDV"))
            objParam.Add("PNCCLNT", ht.Item("CCLNT"))
            objParam.Add("PNCTPDCF", ht.Item("CTPDCF"))
            objParam.Add("PNNDCMFC", ht.Item("NDCMFC"))
            objParam.Add("PNFECINI", ht.Item("FECINI"))
            objParam.Add("PNFECFIN", ht.Item("FECFIN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            dtbReporte = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_REFACTURACION_X_OPERACIONES_NC", objParam)
            'Catch ex As Exception
            'End Try
            Return dtbReporte
        End Function
        Public Function Reporte_Refacturacion_X_Operaciones_FC(ByVal ht As Hashtable) As DataSet
            Dim dtbReporte As New DataSet
            'Try
            Dim objParam As New Parameter
            objParam.Add("PSCCMPN", ht.Item("CCMPN"))
            objParam.Add("PSCDVSN", ht.Item("CDVSN"))
            objParam.Add("PSCPLNDV", ht.Item("CPLNDV"))
            objParam.Add("PNCCLNT", ht.Item("CCLNT"))
            objParam.Add("PNCTPDCF", ht.Item("CTPDCF"))
            objParam.Add("PNNDCMFC", ht.Item("NDCMFC"))
            objParam.Add("PNFECINI", ht.Item("FECINI"))
            objParam.Add("PNFECFIN", ht.Item("FECFIN"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            dtbReporte = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_REFACTURACION_X_OPERACIONES_FC", objParam)
            'Catch ex As Exception
            'End Try
            Return dtbReporte
        End Function

        Public Function frptSeguimientoOperaciones(ByVal ht As Hashtable) As DataSet
            'Try
            Dim objData As New DataSet
            Dim objParametros As New Parameter
            objSql.TransactionController(TransactionType.Automatic)

            objParametros.Add("ISTR_CCMPN", ht.Item("CCMPN")) 'VARCHAR(2)
            objParametros.Add("ISTR_CDVSN", ht.Item("CDVSN")) 'VARCHAR(1)
            objParametros.Add("IINT_CPLNDV", ht.Item("CPLNDV")) 'NUMERIC(3, 0)
            objParametros.Add("ISTR_FINCOP_IN", ht.Item("FINCOP_IN")) 'VARCHAR(8)
            objParametros.Add("ISTR_FINCOP_FI", ht.Item("FINCOP_FI")) 'VARCHAR(8)
            objParametros.Add("ISTR_CCLNTS", ht.Item("CCLNT")) 'VARCHAR(256)

            objParametros.Add("ISTR_STATUS", ht.Item("STATUS")) 'VARCHAR(1)
            objParametros.Add("ISTR_ESTADO", ht.Item("ESTADO"))
            objParametros.Add("ISTR_CTRSPT", ht.Item("CTRSPT"))
            objParametros.Add("ISTR_NDCMFC", ht.Item("NDCMFC"))
            objParametros.Add("ISTR_NPRLQD", ht.Item("NPRLQD"))
            objParametros.Add("ISTR_NDCPRF", ht.Item("NDCPRF"))
            objParametros.Add("ISTR_NOPRCN", ht.Item("NOPRCN"))
            objParametros.Add("ISTR_VARCON", ht.Item("VARCON"))
            objParametros.Add("IINT_CMEDTR", ht.Item("CMEDTR"))
            objParametros.Add("IINT_NDCORM", ht.Item("NDCORM"))
            objParametros.Add("IINT_NORINS", ht.Item("NORINS"))

            objParametros.Add("IINT_STSTIP", ht.Item("STSTIP"))
            objParametros.Add("ISTR_TIPVJE", ht.Item("TIPVJE"))
            objParametros.Add("ISTR_NPLVHT", ht.Item("NPLVHT"))
            objParametros.Add("ISTR_SSINVJ", ht.Item("SSINVJ"))
            objParametros.Add("ISTR_REGION", ht.Item("PSREGION"))
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(ht.Item("CCMPN"))
            objData = objSql.ExecuteDataSet("SP_SOLMIN_ST_REPORTE_OPERACION_SEGUIMIENTO", objParametros)
            Return objData
            'SP_SOLMIN_ST_REPORTE_OPERACION_SEGUIMIENTO
            'SP_SOLMIN_ST_REPORTE_OPERACION_LM_6
            'Catch ex As Exception
            '    Return Nothing
            'End Try

        End Function


  End Class

End Namespace
