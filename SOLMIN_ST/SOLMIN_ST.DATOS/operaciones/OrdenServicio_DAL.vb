Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos


Namespace Operaciones

    Public Class OrdenServicio_DAL
        Private objSql As New SqlManager

        Public Function Listar_Ordenes_Servicio_x_Cliente(ByVal objParamList As List(Of String)) As List(Of OrdenServicioTransporte)

            Dim objDataTable As New DataTable
            Dim objGenericCollection As New List(Of OrdenServicioTransporte)
            Dim objParam As New Parameter



            objParam.Add("PSNORSRT", objParamList(0))
            objParam.Add("PNCCLNT", objParamList(1))
            objParam.Add("PSCCMPN", objParamList(2))
            objParam.Add("PSCDVSN", objParamList(3))
            objParam.Add("PNCPLNDV", objParamList(4))
            objParam.Add("PNCASE", 1)

            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(objParamList(2))

            objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_ORDENES_SERVICIO_V2", objParam)

            For Each objDataRow As DataRow In objDataTable.Rows
                Dim objDatos As New OrdenServicioTransporte
                objDatos.NORSRT = objDataRow("NORSRT").ToString.Trim
                objDatos.CCLNT = objDataRow("CCLNT").ToString.Trim
                objDatos.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                objDatos.QMRCDR = objDataRow("QMRCDR").ToString.Trim
                objDatos.TRFMRC = objDataRow("TRFMRC").ToString.Trim
                objDatos.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                objDatos.CLCLOR = objDataRow("CLCLOR").ToString.Trim
                objDatos.CLCLDS = objDataRow("CLCLDS").ToString.Trim

                objDatos.PNTORG = objDataRow("PNTORG").ToString.Trim
                objDatos.PNTDES = objDataRow("PNTDES").ToString.Trim
                objDatos.TIPSRV = objDataRow("TIPSRV").ToString.Trim
                objDatos.CODMER = objDataRow("CODMER").ToString.Trim
                objDatos.CUNDMD = objDataRow("CUNDMD").ToString.Trim
                objDatos.CTPUNV = objDataRow("CTPUNV").ToString.Trim
                'objDatos.NCTZCN = objDataRow("NCTZCN").ToString.Trim
                objDatos.CUBORI = objDataRow("CUBORI")
                objDatos.UBIGEO_O = objDataRow("UBIGEO_O").ToString.Trim
                objDatos.CUBDES = objDataRow("CUBDES")
                objDatos.UBIGEO_D = objDataRow("UBIGEO_D").ToString.Trim


                REM ECM-HUNDRED-INICIO
                objDatos.TDSCSP = objDataRow("TDSCSP").ToString.Trim
                objDatos.CCLNT_COD = objDataRow("CCLNT_COD").ToString.Trim
                ' objDatos.TDSCSP_FACT = objDataRow("TDSCSP_FACT").ToString.Trim
                'objDatos.CLIENT_FACT = objDataRow("CLIENT_FACT").ToString.Trim
                REM ECM-HUNDRED-FIN

                REM CAMPOS SALMON DEF-FASE 2 -INICIO
                objDatos.CTTRAN = objDataRow("CTTRAN").ToString().Trim()
                objDatos.CTIPCG = objDataRow("CTIPCG").ToString().Trim()
                'objDatos.CCLNFC = objDataRow("CCLNFC").ToString().Trim()
                'objDatos.COD_CEBEDP = objDataRow("CEBE_P").ToString().Trim()
                'objDatos.COD_CEBEDT = objDataRow("CEBE_T").ToString().Trim()
                REM CAMPOS SALMON DEF-FASE 2 -FIN

                'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
                'objDatos.PLANTA = objDataRow("PLANTA").ToString().Trim()
                'objDatos.PLANTA_FACT = objDataRow("PLANTA_FACT").ToString().Trim()
                'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

                'Codigo agregado por MREATEGUIP - Ajuste Moneda
                '----- Ini -----
                objDatos.MONCOBRO = objDataRow("MONCOBRO").ToString().Trim()
                objDatos.MONPAGO = objDataRow("MONPAGO").ToString().Trim()

             
                '----- Fin -----
                objDatos.COD_SNT_VJE = objDataRow("COD_SNT_VJE").ToString().Trim()

                objDatos.TARIFA_COBRO = objDataRow("TARIFA_COBRO").ToString().Trim()
                objDatos.TARIFA_PAGO = objDataRow("TARIFA_PAGO").ToString().Trim()

                objDatos.PARAM_COBRO = objDataRow("PARAM_COBRO").ToString().Trim()
                objDatos.PARAM_PAGO = objDataRow("PARAM_PAGO").ToString().Trim()

               

                objGenericCollection.Add(objDatos)
            Next
            Return objGenericCollection
        End Function

        Public Function Obtener_Orden_Servicio(ByVal objEntidad As OrdenServicioTransporte) As OrdenServicioTransporte

            Dim objDataTable As New DataTable
            Dim objParam As New Parameter

            Try

                objParam.Add("PSNORSRT", objEntidad.NORSRT)

                objDataTable = objSql.ExecuteDataTable("SP_SOLMIN_ST_OBTENER_ORDEN_SERVICIO", objParam)

                For Each objDataRow As DataRow In objDataTable.Rows
                    Dim objDatos As New OrdenServicioTransporte
                    objEntidad.NORSRT = objDataRow("NORSRT").ToString.Trim
                    objEntidad.CCLNT = objDataRow("CCLNT").ToString.Trim
                    objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                    objEntidad.QMRCDR = objDataRow("QMRCDR").ToString.Trim
                    objEntidad.TRFMRC = objDataRow("TRFMRC").ToString.Trim
                    objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                    objEntidad.CLCLOR = objDataRow("CLCLOR").ToString.Trim
                    objEntidad.CLCLDS = objDataRow("CLCLDS").ToString.Trim

                    objEntidad.CTPOSR = objDataRow("CTPOSR").ToString.Trim
                    objEntidad.CMRCDR = objDataRow("CMRCDR").ToString.Trim
                    objEntidad.CUNDMD = objDataRow("CUNDMD").ToString.Trim
                    objEntidad.QMRCDR = objDataRow("QMRCDR").ToString.Trim
                Next

            Catch ex As Exception
                objEntidad.NORSRT = 0
            End Try

            Return objEntidad

        End Function

        'Public Function GenerarOS(ByVal lobjEntidad As Hashtable) As Double
        '    Dim objDataTable As New DataTable
        '    Dim objParam As New Parameter
        '    Dim dblResultado As Double = 0

        '    Try
        '        objParam.Add("PNNCTZCN", lobjEntidad("PNNCTZCN"))
        '        objParam.Add("PNCCLNT", lobjEntidad("PNCCLNT"))
        '        objParam.Add("PSCCMPN", lobjEntidad("PSCCMPN"))
        '        objParam.Add("PSCDVSN", lobjEntidad("PSCDVSN"))
        '        objParam.Add("PNCPLNDV", lobjEntidad("PNCPLNDV"))
        '        objParam.Add("PNCCLNFC", lobjEntidad("PNCCLNFC"))
        '        objParam.Add("PSSSCGST", lobjEntidad("PSSSCGST"))
        '        objParam.Add("PNCCNCST", lobjEntidad("PNCCNCST"))
        '        objParam.Add("PNCCNCS1", lobjEntidad("PNCCNCS1"))
        '        objParam.Add("PSCUSCRT", lobjEntidad("PSCUSCRT"))
        '        objParam.Add("PNFCHCRT", lobjEntidad("PNFCHCRT"))
        '        objParam.Add("PNHRACRT", lobjEntidad("PNHRACRT"))
        '        objParam.Add("PSNTRMCR", lobjEntidad("PSNTRMCR"))
        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lobjEntidad("PSCCMPN"))
        '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_GENERAR_OS", objParam)

        '    Catch ex As Exception
        '        dblResultado = 1
        '    End Try
        '    Return dblResultado

        'End Function

        'Public Function Cerrar_OS(ByVal obeOrdenServicio As OrdenServicioTransporte) As Double
        '    Dim dblResultado = 0
        '    Try
        '        Dim objParam As New Parameter
        '        objParam.Add("PNNORSRT", obeOrdenServicio.NORSRT)
        '        objParam.Add("PSCULUSA", obeOrdenServicio.CULUSA)
        '        objParam.Add("PNFULTAC", obeOrdenServicio.FULTAC)
        '        objParam.Add("PNHULTAC", obeOrdenServicio.HULTAC)
        '        objParam.Add("PSNTRMNL", obeOrdenServicio.NTRMNL)
        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeOrdenServicio.CCMPN)

        '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_CERRAR_OS", objParam)
        '    Catch ex As Exception
        '        dblResultado = 1
        '    End Try
        '    Return dblResultado
        'End Function


        ''' <summary>
        ''' Método que genera el detalle de la cotizacion
        ''' </summary>
        ''' <param name="lobjEntidad"></param>
        ''' <returns></returns>
        ''' <remarks>
        ''' Create for: Hugo Pérez Ryan
        ''' Date:       21/02/2012
        ''' </remarks>
        'Public Function GenerarOSxDetalleCotizacion(ByVal lobjEntidad As Hashtable) As Double
        '    Dim objDataTable As New DataTable
        '    Dim objParam As New Parameter
        '    Dim dblResultado As Double = 0

        '    Try
        '        objParam.Add("PNNCTZCN", lobjEntidad("PNNCTZCN"))
        '        objParam.Add("PNCCLNT", lobjEntidad("PNCCLNT"))
        '        objParam.Add("PSCCMPN", lobjEntidad("PSCCMPN"))
        '        objParam.Add("PSCDVSN", lobjEntidad("PSCDVSN"))
        '        objParam.Add("PNCPLNDV", lobjEntidad("PNCPLNDV"))
        '        objParam.Add("PNCCLNFC", lobjEntidad("PNCCLNFC"))
        '        objParam.Add("PSSSCGST", lobjEntidad("PSSSCGST"))
        '        objParam.Add("PNCCNCST", lobjEntidad("PNCCNCST"))
        '        objParam.Add("PNCCNCS1", lobjEntidad("PNCCNCS1"))
        '        objParam.Add("PSCUSCRT", lobjEntidad("PSCUSCRT"))
        '        objParam.Add("PNFCHCRT", lobjEntidad("PNFCHCRT"))
        '        objParam.Add("PNHRACRT", lobjEntidad("PNHRACRT"))
        '        objParam.Add("PSNTRMCR", lobjEntidad("PSNTRMCR"))
        '        objParam.Add("PNCRRCT", lobjEntidad("PNCRRCT"))

        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(lobjEntidad("PSCCMPN"))
        '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_GENERAR_OS_X_DETALLE_COTIZACION", objParam)

        '    Catch ex As Exception
        '        dblResultado = 1
        '    End Try
        '    Return dblResultado
        'End Function

        ''' <summary>
        ''' Método que permite cerrar la OS de cada uno de los detalles
        ''' </summary>
        ''' <param name="obeOrdenServicio"></param>
        ''' <returns></returns>
        ''' <remarks>
        ''' Create for: Hugo Pérez Ryan
        ''' Date:       21/02/2012
        ''' </remarks>
        'Public Function CerrarOSxDetalleCotizacion(ByVal obeOrdenServicio As OrdenServicioTransporte) As Double
        '    Dim dblResultado = 0
        '    Try
        '        Dim objParam As New Parameter
        '        objParam.Add("PNNORSRT", obeOrdenServicio.NORSRT)
        '        objParam.Add("PSCULUSA", obeOrdenServicio.CULUSA)
        '        objParam.Add("PNFULTAC", obeOrdenServicio.FULTAC)
        '        objParam.Add("PNHULTAC", obeOrdenServicio.HULTAC)
        '        objParam.Add("PSNTRMNL", obeOrdenServicio.NTRMNL)
        '        objParam.Add("PNNCTZCN", obeOrdenServicio.NCTZCN)
        '        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeOrdenServicio.CCMPN)

        '        objSql.ExecuteNonQuery("SP_SOLMIN_ST_CERRAR_OS_X_DETALLE_COTIZACION", objParam)
        '    Catch ex As Exception
        '        dblResultado = 1
        '    End Try
        '    Return dblResultado
        'End Function

        Public Sub ActualizarEstadoOrdenServicio(ByVal obeOrdenServicio As OrdenServicioTransporte)
            Dim objParam As New Parameter
            objParam.Add("PNNCTZCN", obeOrdenServicio.NCTZCN)
            objParam.Add("PNNCRRCT", obeOrdenServicio.NCRRCT)
            objParam.Add("PSSESTOS", obeOrdenServicio.SESTOS)
            objParam.Add("PSCULUSA", obeOrdenServicio.CULUSA)
            objParam.Add("PSNTRMNL", obeOrdenServicio.NTRMNL)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeOrdenServicio.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_ACTUALIZAR_ESTADO_ORDEN_SERVICIO", objParam)
        End Sub

        Public Function VerificarConfiguracionOrdenServicio(ByVal obeOrdenServicio As OrdenServicioTransporte) As String
            Dim objParam As New Parameter
            objParam.Add("PNNCTZCN", obeOrdenServicio.NCTZCN)
            objParam.Add("PNCCLNT", obeOrdenServicio.CCLNT)
            objParam.Add("PSCCMPN", obeOrdenServicio.CCMPN)
            objParam.Add("PSCDVSN", obeOrdenServicio.CDVSN)
            objParam.Add("PNCPLNDV", obeOrdenServicio.CPLNDV)
            objParam.Add("PNCCNCST", obeOrdenServicio.CCNCST)
            objParam.Add("PNCCNCS1", obeOrdenServicio.CCNCS1)
            objParam.Add("PARAM_MSG", "", ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeOrdenServicio.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_VALIDA_ORDEN_SERVICIO_CENTRO_COSTO", objParam)
            Dim msgError() As String = ("" & objSql.ParameterCollection("PARAM_MSG")).ToString.Trim.Split("|")
            Dim msg As String = ""
            Dim ListVisitado As New Hashtable
            For Each Item As String In msgError
                If Item.Trim.Length > 0 Then
                    If Not ListVisitado.Contains(Item) Then
                        ListVisitado.Add(Item, Item)
                        msg = msg & Item & Chr(13)
                    End If
                End If
            Next
            msg = msg.Trim
            Return msg
        End Function

        ''' <summary>
        ''' Verificar Permiso Rversion Provision
        ''' </summary>
        ''' <param name="obeOrdenServicio"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function intTieneProvision(ByVal obeOrdenServicio As OrdenServicioTransporte) As Integer
            Dim objParam As New Parameter
            Dim retorno As Decimal = -1
            'Try
            objParam.Add("PSCCMPN", obeOrdenServicio.CCMPN)
            objParam.Add("PSCDVSN", obeOrdenServicio.CDVSN)
            objParam.Add("PNNOPRCN", obeOrdenServicio.NOPRCN)
            objParam.Add("PNNLQDCN", obeOrdenServicio.NLQDCN)
            objParam.Add("PSTIPO", obeOrdenServicio.TIPO)
            objParam.Add("PNPROVISION", 0, ParameterDirection.Output)
            objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeOrdenServicio.CCMPN)
            objSql.ExecuteNonQuery("SP_SOLMIN_ST_VERIFICA_EXISTENCIA_PROVISION", objParam)
            retorno = objSql.ParameterCollection("PNPROVISION")
            Return retorno
            'Catch ex As Exception
            '    Return -1
            'End Try
        End Function

        ''' <summary>
        ''' Lista de usuarios permitidos para revertir la provision
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function fdtUsuarioPermitidoRevertirProvision(ByVal strUsuario As String) As DataTable
            Dim lobjParams As New Parameter
            Dim lobjSql As New SqlManager
            Dim dt As New DataTable
            'Try
            lobjParams.Add("PSCCMPRN", strUsuario)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CT_USUARIO_PROVISION", lobjParams)
            'Catch ex As Exception
            '    Throw New Exception(ex.Message)
            '    Return New DataTable
            'End Try
            Return dt
        End Function


        Public Function Listar_operacion_Valorizada(ByVal obeOrdenServicio As OrdenServicioTransporte) As DataTable
            Dim lobjParams As New Parameter
            Dim lobjSql As New SqlManager
            Dim dt As New DataTable
            Dim msgvalidacion As String = ""
            lobjParams.Add("PSCCMPN", obeOrdenServicio.CCMPN)
            lobjParams.Add("PNNOPRCN", obeOrdenServicio.NOPRCN)
            lobjParams.Add("PNNGUITR", obeOrdenServicio.NGUITR)
            lobjParams.Add("PNNGUIRM", obeOrdenServicio.NGUIRM)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_LISTAR_OPERACION_VALORIZACION", lobjParams)
            Return dt
        End Function


        Public Function TieneAccesoAccionOperacionesValorizadas(ByVal obeOrdenServicio As OrdenServicioTransporte) As Boolean
            Dim lobjParams As New Parameter
            Dim lobjSql As New SqlManager
            Dim dt As New DataTable
            Dim ConAcceso As Boolean = False
            lobjParams.Add("PSCCMPN", obeOrdenServicio.CCMPN)
            lobjParams.Add("PSCULUSA", obeOrdenServicio.CULUSA)
            dt = lobjSql.ExecuteDataTable("SP_SOLMIN_ST_VALIDAR_ACCESO_MODIFICAR_OPERACION_VALORIZADA", lobjParams)
            If dt.Rows.Count > 0 Then
                ConAcceso = True
            End If
            Return ConAcceso
        End Function


    End Class

End Namespace