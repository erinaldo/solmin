Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Imports RANSA.NEGO.slnSOLMIN_SDSW
Namespace slnSOLMIN_SDS.DespachoSDSW.Procesos
    Public Class clsDespacho
        Inherits clsBasicClassSDSW
#Region " Atributos "
        Private strUsuarioSistema As String
#End Region
#Region " Propiedades "

#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para Filtros -'
        '----------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Listar Información para DataGrid -'
        '-----------------------------------------------------'
        Public Shared Function fdtListar_GuiasRANSA(ByVal objFiltro As clsFiltros_ListarGuiasRansaDS, ByRef strMensajeError As String) As DataTable
            Dim dtEntidad As DataTable = Nothing
            ' Busco la relación de los Motivos de Traslado
            With objFiltro
                dtEntidad = fdtSDSWResultadoConsulta(strMensajeError, "SDS_DESP_GUIRNS_01", .pintCodigoCliente_CCLNT.ToString, .pstrNroGuiaRANSA_NGUIRN, _
                                                 .pstrTipoAlmacen_CTPALM, .pstrAlmacen_CALMC, .pstrFechaInicial_FNum_FASGTR, .pstrFechaFinal_FNum_FASGTR)
            End With
            Return dtEntidad
        End Function

        Public Shared Function fdtListar_GuiasRemision(ByVal objFiltro As clsFiltros_ListarGuiasRemisionDS, ByRef strMensajeError As String) As DataTable
            Dim dtEntidad As DataTable = Nothing
            ' Busco la relación de los Motivos de Traslado
            With objFiltro
                dtEntidad = fdtSDSWResultadoConsulta(strMensajeError, "SDS_DESP_GUIARM_01", .pintCodigoCliente_CCLNT.ToString, .pstrNroGuiaRemision_NGUIRM, _
                                                 .pstrFechaInicial_FNum_FGUIRM, .pstrFechaFinal_FNum_FGUIRM)
            End With
            Return dtEntidad
        End Function

        Public Shared Function fdtListar_StockMercaderias(ByVal objFiltro As clsFiltro_SDSWListarMercaderia, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_DESP_LSTMER_01", objFiltro.pintCodigoCliente_CCLNT, objFiltro.pstrCodigoFamilia_CFMCLR, _
                                               objFiltro.pstrCodigoGrupo_CGRCLR, objFiltro.pstrCodigoMercaderia_CMRCLR, objFiltro.pintFechaVencimiento_FVNCMR, _
                                               objFiltro.pintFechaInventario_FINVRN, objFiltro.pstrStatusPublicacionWEB_FPUWEB)
            dtResultado.TableName = "Lista de Mercadería"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_StockMercaderiasPorAlmacen(ByVal intOrdenServicio As Int64, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_DESP_LSTSXA_01", intOrdenServicio)
            dtResultado.TableName = "Lista Stock de Mercadería por Almacén"
            Return dtResultado
        End Function

        ' Agregado para Almaceneras
        Public Shared Function fdtListar_AutorizacionPorServicioContrato(ByVal intOrdenServicio As Int64, ByVal intContrato As Int64, ByVal strTipo As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_DESP_LSTAXS_01", intOrdenServicio, intContrato, strTipo)
            'dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_GENE_LSTAUS_01", intOrdenServicio, intContrato, strTipo)
            dtResultado.TableName = "Lista Autorizaciones por Servicio Contrato"
            Return dtResultado
        End Function
        'Agregado para Almaceneras
        Public Shared Function fblnExiste_TarifaRubro(ByRef strMensajeError As String, ByVal objmovimientoticket As clsSDSWMovimientoTicket, ByVal objITEMticket As clsSDSWItemTicket) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDSW_GENE_RUBRO_TARIFA_02", objmovimientoticket.pintCodigoCliente_CCLNT, objITEMticket.pstrTipoServicio_CSRVNV)
        End Function
        'Agregado para Almaceneras
        Public Shared Function fblnExiste_RubroIGV(ByRef strMensajeError As String, ByVal objITEMticket As clsSDSWItemTicket) As Boolean
            Return fblnSDSWExisteInformacion(strMensajeError, "SDSW_GENE_IGV_RUBRO_01", objITEMticket.pstrTipoServicio_CSRVNV)
        End Function


        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Detalle de la Información -'
        '--------------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'


        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Información por Defecto -'
        '----------------------------------------------------'
        'Public Shared Function fdtDefecto_ServicioDespacho(ByVal strCompania As String, ByVal strDivision As String, ByRef strMensajeError As String) As DataTable
        '    Dim dtResultado As DataTable = Nothing
        '    dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_RECE_DEFREC_01", strCompania, strDivision)
        '    dtResultado.TableName = "Servicio de Despacho"
        '    Return dtResultado
        'End Function

        Public Shared Function fdtDefecto_TipoMovimientoDespacho(ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDS_DESP_DEFTMV_01")
            dtResultado.TableName = "Tipo de Despacho"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
        Public Function fblnDespacho_Mercaderia(ByRef strMensajeError As String, ByVal intNroGuiaRansa_NGUIRN As Int64, _
                                                 ByVal objMovimientoMercaderia As clsSDSWMovimientoMercaderia, ByVal strPCUSER As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim strTemp1, strTemp2, strTemp3 As String
            Try
                ' ---------------------------------------------------------'
                ' Primer Paso - Ingresar las Observaciones de la Recepción '
                ' ---------------------------------------------------------'
                ' Separando las observaciones en las Tres (3) cadenas respectivas
                Select Case objMovimientoMercaderia.pstrObservaciones_TOBSER.Length
                    Case Is > 120
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
                        strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60, 60)
                        strTemp3 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(120)
                    Case Is > 60
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
                        strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60)
                        strTemp3 = ""
                    Case Else
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER
                        strTemp2 = ""
                        strTemp3 = ""
                End Select

                objParametros = New Parameter
                With objParametros
                    .Add("IN_TPODOC", objMovimientoMercaderia.pintServicio_CSRVC)
                    .Add("IN_NGUIIS", intNroGuiaRansa_NGUIRN)
                    .Add("IN_TOBSG1", strTemp1)
                    .Add("IN_TOBSG2", strTemp2)
                    .Add("IN_TOBSG3", strTemp3)
                    .Add("IN_NTRMNL", strPCUSER)
                    .Add("IN_USUARI", strUsuarioSistema)
                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_OBSERV_INS", objParametros)
                ' -------------------------------------------------'
                ' Segundo Paso - Recorremos los Item recepcionados '
                ' -------------------------------------------------'
                For Each objItemMovimientoMercaderia As clsSDSWItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_CCLNT", objMovimientoMercaderia.pintCodigoCliente_CCLNT)
                        .Add("IN_NORDSR", objItemMovimientoMercaderia.pintOrdenServicio_NORDSR)
                        .Add("IN_NCNTR", objItemMovimientoMercaderia.pintNroContrato_NCNTR)
                        '.Add("IN_NAUTR", objItemMovimientoMercaderia.pintNroAutorizacion_NAUTR)
                        .Add("IN_NCRCTC", objItemMovimientoMercaderia.pintNroCorrDetalleContrato_NCRCTC)
                        .Add("IN_QDSVGN", objItemMovimientoMercaderia.pintNroDiasVigencia_QDSVGN)
                        .Add("IN_FTRMN", (Now.AddDays(objItemMovimientoMercaderia.pintNroDiasVigencia_QDSVGN - 1)).ToString("yyyyMMdd"))
                        .Add("IN_CCMPN", objMovimientoMercaderia.pstrCompania_CCMPN)
                        .Add("IN_CDVSN", objMovimientoMercaderia.pstrDivision_CDVSN)
                        .Add("IN_CSRVC", objMovimientoMercaderia.pintServicio_CSRVC)
                        .Add("IN_CTRSP", objMovimientoMercaderia.pintEmpresaTransporte_CTRSP)
                        .Add("IN_NPLCCM", objMovimientoMercaderia.pstrNroPlacaCamion_NPLCCM)
                        .Add("IN_NBRVCH", objMovimientoMercaderia.pstrNroBrevete_NBRVCH)
                        .Add("IN_CTPALM", objItemMovimientoMercaderia.pstrTipoAlmacen_CTPALM)
                        .Add("IN_CALMC", objItemMovimientoMercaderia.pstrAlmacen_CALMC)
                        .Add("IN_CZNALM", objItemMovimientoMercaderia.pstrZonaAlmacen_CZNALM)
                        .Add("IN_NGUIRN", intNroGuiaRansa_NGUIRN)
                        .Add("IN_QTRMC", objItemMovimientoMercaderia.pdecCantidad_QTRMC)
                        .Add("IN_QTRMP", objItemMovimientoMercaderia.pdecPeso_QTRMP)
                        .Add("IN_CUNCN6", objItemMovimientoMercaderia.pstrUnidadCantidad_CUNCNT)
                        .Add("IN_CUNPS6", objItemMovimientoMercaderia.pstrUnidadPeso_CUNPST)
                        .Add("IN_CUNVL6", objItemMovimientoMercaderia.pstrUnidadValorTransaccion_CUNVLT)
                        .Add("IN_STPODP", objItemMovimientoMercaderia.pstrTipoDeposito_CTPDPS)
                        .Add("IN_TOBSRV", objItemMovimientoMercaderia.pstrObservaciones_TOBSRV)
                        .Add("IN_NGUICL", objItemMovimientoMercaderia.pstrNroGuiaCliente_NGUICL)
                        .Add("IN_NORCCL", objItemMovimientoMercaderia.pstrNroOrdenCompraCliente_NORCCL)
                        .Add("IN_NRUCLL", objItemMovimientoMercaderia.pstrNroRUCCliente_NRUCLL)
                        .Add("IN_FUNDS3", objItemMovimientoMercaderia.pstrSatusUnidadDespacho_FUNDS2)
                        .Add("IN_STPING", objItemMovimientoMercaderia.pstrTipoMovimiento_STPING)
                        .Add("IN_NTRMNL", strPCUSER)
                        .Add("IN_USUARI", strUsuarioSistema)
                    End With
                Next
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_SAL", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnDespacho_Mercaderia >> de la clase << clsDespacho >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Public Function fblnDespacho_Mercaderia_Autorizacion(ByRef strMensajeError As String, ByVal intNroGuiaRansa_NGUIRN As Int64, _
                                                ByVal objMovimientoMercaderia As clsSDSWMovimientoMercaderia, ByVal strPCUSER As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim strTemp1, strTemp2, strTemp3 As String
            Try
                ' ---------------------------------------------------------'
                ' Primer Paso - Ingresar las Observaciones de la Recepción '
                ' ---------------------------------------------------------'
                ' Separando las observaciones en las Tres (3) cadenas respectivas
                Select Case objMovimientoMercaderia.pstrObservaciones_TOBSER.Length
                    Case Is > 120
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
                        strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60, 60)
                        strTemp3 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(120)
                    Case Is > 60
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
                        strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60)
                        strTemp3 = ""
                    Case Else
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER
                        strTemp2 = ""
                        strTemp3 = ""
                End Select

                objParametros = New Parameter
                With objParametros
                    .Add("IN_TPODOC", objMovimientoMercaderia.pintServicio_CSRVC)
                    .Add("IN_NGUIIS", intNroGuiaRansa_NGUIRN)
                    .Add("IN_TOBSG1", strTemp1)
                    .Add("IN_TOBSG2", strTemp2)
                    .Add("IN_TOBSG3", strTemp3)
                    .Add("IN_NTRMNL", strPCUSER)
                    .Add("IN_USUARI", strUsuarioSistema)
                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_OBSERV_INS", objParametros)
                '-------------------------------------------------'
                'Segundo Paso - Recorremos los Item recepcionados '
                '-------------------------------------------------'
                For Each objItemMovimientoMercaderia As clsSDSWItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_CCLNT", objMovimientoMercaderia.pintCodigoCliente_CCLNT)
                        .Add("IN_NORDSR", objItemMovimientoMercaderia.pintOrdenServicio_NORDSR)
                        .Add("IN_NCNTR", objItemMovimientoMercaderia.pintNroContrato_NCNTR)

                        .Add("IN_NCRCTC", objItemMovimientoMercaderia.pintNroCorrDetalleContrato_NCRCTC)
                        .Add("IN_QDSVGN", objItemMovimientoMercaderia.pintNroDiasVigencia_QDSVGN)
                        .Add("IN_FTRMN", (Now.AddDays(objItemMovimientoMercaderia.pintNroDiasVigencia_QDSVGN - 1)).ToString("yyyyMMdd"))
                        .Add("IN_CCMPN", objMovimientoMercaderia.pstrCompania_CCMPN)
                        .Add("IN_CDVSN", objMovimientoMercaderia.pstrDivision_CDVSN)
                        .Add("IN_CSRVC", objMovimientoMercaderia.pintServicio_CSRVC)
                        .Add("IN_CTRSP", objMovimientoMercaderia.pintEmpresaTransporte_CTRSP)
                        .Add("IN_NPLCCM", objMovimientoMercaderia.pstrNroPlacaCamion_NPLCCM)
                        .Add("IN_NBRVCH", objMovimientoMercaderia.pstrNroBrevete_NBRVCH)
                        .Add("IN_CTPALM", objItemMovimientoMercaderia.pstrTipoAlmacen_CTPALM)
                        .Add("IN_CALMC", objItemMovimientoMercaderia.pstrAlmacen_CALMC)
                        .Add("IN_CZNALM", objItemMovimientoMercaderia.pstrZonaAlmacen_CZNALM)
                        .Add("IN_NGUIRN", intNroGuiaRansa_NGUIRN)

                        .Add("IN_QTRMC", objItemMovimientoMercaderia.pdecCantidad_QTRMC)
                        .Add("IN_QTRMP", objItemMovimientoMercaderia.pdecPeso_QTRMP)

                        .Add("IN_CUNCN6", objItemMovimientoMercaderia.pstrUnidadCantidad_CUNCNT)
                        .Add("IN_CUNPS6", objItemMovimientoMercaderia.pstrUnidadPeso_CUNPST)
                        .Add("IN_CUNVL6", objItemMovimientoMercaderia.pstrUnidadValorTransaccion_CUNVLT)

                        .Add("IN_STPODP", objItemMovimientoMercaderia.pstrTipoDeposito_CTPDPS)
                        .Add("IN_TOBSRV", objItemMovimientoMercaderia.pstrObservaciones_TOBSRV)
                        .Add("IN_NGUICL", objItemMovimientoMercaderia.pstrNroGuiaCliente_NGUICL)
                        .Add("IN_NORCCL", objItemMovimientoMercaderia.pstrNroOrdenCompraCliente_NORCCL)
                        .Add("IN_NRUCLL", objItemMovimientoMercaderia.pstrNroRUCCliente_NRUCLL)

                        .Add("IN_FUNDS3", objItemMovimientoMercaderia.pstrSatusUnidadDespacho_FUNDS2)
                        .Add("IN_STPING", objItemMovimientoMercaderia.pstrTipoMovimiento_STPING)
                        .Add("IN_NTRMNL", strPCUSER)
                        .Add("IN_USUARI", strUsuarioSistema)

                        .Add("IN_CDPRDC", objItemMovimientoMercaderia.pstrCodigoRANSA_CMRCD)
                        .Add("IN_NAUTR", objItemMovimientoMercaderia.pintNroAutorizacion_NAUTR)

                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_SAL_AUT", objParametros)
                Next


            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnDespacho_Mercaderia_Autorizacion >> de la clase << clsDespacho >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function
        'Agregado para Almaceneras

        Public Function fblnDespacho_Mercaderia_AutorizacionWarrant(ByRef strMensajeError As String, ByVal intNroGuiaRansa_NGUIRN As Int64, _
                                                ByVal objMovimientoMercaderia As clsSDSWMovimientoMercaderia, ByVal strPCUSER As String) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim objParametros As Parameter
            Dim blnResultado As Boolean = True
            objSqlManager.TransactionController(TransactionType.Automatic)
            Dim strTemp1, strTemp2, strTemp3 As String
            Try
                ' ---------------------------------------------------------'
                ' Primer Paso - Ingresar las Observaciones de la Recepción '
                ' ---------------------------------------------------------'
                ' Separando las observaciones en las Tres (3) cadenas respectivas

                Select Case objMovimientoMercaderia.pstrObservaciones_TOBSER.Length
                    Case Is > 120
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
                        strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60, 60)
                        strTemp3 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(120)
                    Case Is > 60
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(0, 60)
                        strTemp2 = objMovimientoMercaderia.pstrObservaciones_TOBSER.Substring(60)
                        strTemp3 = ""
                    Case Else
                        strTemp1 = objMovimientoMercaderia.pstrObservaciones_TOBSER
                        strTemp2 = ""
                        strTemp3 = ""
                End Select

                objParametros = New Parameter
                With objParametros
                    .Add("IN_TPODOC", objMovimientoMercaderia.pintServicio_CSRVC)
                    .Add("IN_NGUIIS", intNroGuiaRansa_NGUIRN)
                    .Add("IN_TOBSG1", strTemp1)
                    .Add("IN_TOBSG2", strTemp2)
                    .Add("IN_TOBSG3", strTemp3)
                    .Add("IN_NTRMNL", strPCUSER)
                    .Add("IN_USUARI", strUsuarioSistema)
                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_OBSERV_INS", objParametros)
                '-------------------------------------------------'
                'Segundo Paso - Recorremos los Item recepcionados '
                '-------------------------------------------------'
                For Each objItemMovimientoMercaderia As clsSDSWItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_CCLNT", objMovimientoMercaderia.pintCodigoCliente_CCLNT)
                        .Add("IN_NORDSR", objItemMovimientoMercaderia.pintOrdenServicio_NORDSR)
                        .Add("IN_NCNTR", objItemMovimientoMercaderia.pintNroContrato_NCNTR)

                        '.Add("IN_NCRCTC", objItemMovimientoMercaderia.pintNroCorrDetalleContrato_NCRCTC)
                        '.Add("IN_QDSVGN", objItemMovimientoMercaderia.pintNroDiasVigencia_QDSVGN)
                        '.Add("IN_FTRMN", (Now.AddDays(objItemMovimientoMercaderia.pintNroDiasVigencia_QDSVGN - 1)).ToString("yyyyMMdd"))
                        .Add("IN_CCMPN", objMovimientoMercaderia.pstrCompania_CCMPN)
                        .Add("IN_CDVSN", objMovimientoMercaderia.pstrDivision_CDVSN)
                        .Add("IN_CSRVC", objMovimientoMercaderia.pintServicio_CSRVC)
                        .Add("IN_CTRSP", objMovimientoMercaderia.pintEmpresaTransporte_CTRSP)
                        .Add("IN_NPLCCM", objMovimientoMercaderia.pstrNroPlacaCamion_NPLCCM)
                        .Add("IN_NBRVCH", objMovimientoMercaderia.pstrNroBrevete_NBRVCH)
                        '.Add("IN_CTPALM", objItemMovimientoMercaderia.pstrTipoAlmacen_CTPALM)
                        '.Add("IN_CALMC", objItemMovimientoMercaderia.pstrAlmacen_CALMC)
                        '.Add("IN_CZNALM", objItemMovimientoMercaderia.pstrZonaAlmacen_CZNALM)
                        .Add("IN_NGUIRN", intNroGuiaRansa_NGUIRN)

                        .Add("IN_QTRMC", objItemMovimientoMercaderia.pdecCantidad_QTRMC)
                        .Add("IN_QTRMP", objItemMovimientoMercaderia.pdecPeso_QTRMP)

                        '.Add("IN_CUNCN6", objItemMovimientoMercaderia.pstrUnidadCantidad_CUNCNT)
                        '.Add("IN_CUNPS6", objItemMovimientoMercaderia.pstrUnidadPeso_CUNPST)
                        '.Add("IN_CUNVL6", objItemMovimientoMercaderia.pstrUnidadValorTransaccion_CUNVLT)

                        .Add("IN_STPODP", objItemMovimientoMercaderia.pstrTipoDeposito_CTPDPS)
                        .Add("IN_TOBSRV", objItemMovimientoMercaderia.pstrObservaciones_TOBSRV)
                        .Add("IN_NGUICL", objItemMovimientoMercaderia.pstrNroGuiaCliente_NGUICL)
                        .Add("IN_NORCCL", objItemMovimientoMercaderia.pstrNroOrdenCompraCliente_NORCCL)
                        .Add("IN_NRUCLL", objItemMovimientoMercaderia.pstrNroRUCCliente_NRUCLL)

                        .Add("IN_FUNDS3", objItemMovimientoMercaderia.pstrSatusUnidadDespacho_FUNDS2)
                        .Add("IN_STPING", objItemMovimientoMercaderia.pstrTipoMovimiento_STPING)
                        .Add("IN_NTRMNL", strPCUSER)
                        .Add("IN_USUARI", strUsuarioSistema)

                        .Add("IN_CDPRDC", objItemMovimientoMercaderia.pstrCodigoRANSA_CMRCD)
                        .Add("IN_NAUTR", objItemMovimientoMercaderia.pintNroAutorizacion_NAUTR)

                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_SAL_AUT", objParametros)
                Next

            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnDespacho_Mercaderia_Autorizacion1 >> de la clase << clsDespacho >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        'End Function

        Public Shared Function fblnActualizar_SaldoDespacho(ByRef strMensajeError As String, ByVal Orden As String, _
                                                     ByVal Terminal As String, ByVal Usuario As String) As Boolean

            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try
                objParametros = New Parameter
                With objParametros
                    .Add("IN_NORDSR", Orden)
                    .Add("IN_USUARIO", Usuario)
                    .Add("IN_NTRMNL", Terminal)

                End With
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ACTUALIZAR_SALDO", objParametros)
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnActualizar_SaldoDespacho >> de la clase << clsDespacho >> " & vbNewLine & _
                                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado

        End Function
        Public Function fblnOrdenDespacho_TicketW(ByRef strMensajeError As String, _
                                                     ByVal objMovimientoTicket As clsSDSWMovimientoTicket) As Boolean
            Dim objSqlManager As SqlManager = New SqlManager
            Dim blnResultado As Boolean = True
            Dim objParametros As Parameter
            objSqlManager.TransactionController(TransactionType.Automatic)
            Try
                'Agregamos los cabecera de ticket 
                For Each objticket As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_NORDSR", objticket.pintOrdenServicio_NORDSR)
                        .Add("IN_CTPOAT", objMovimientoTicket.pstrZonaAlmacen_CTPOAT)
                        .Add("IN_CTPALM", objMovimientoTicket.pstrTipoAlmacen_CTPALM)
                        .Add("IN_CALMC", objMovimientoTicket.pstrAlmacen_CALMC)
                        .Add("IN_CZNALM", objMovimientoTicket.pstrZonaAlmacen_CZNALM)
                        .Add("IN_USUARI", strUsuarioSistema)
                        .Add("IN_OBSER", objMovimientoTicket.pstrObservacion_OBSER)
                        .Add("IN_FATNSR", objticket.pintFecha_FATNSR)
                    End With
                Next

                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_TICKET_CABECERA", objParametros)

                'Agregamos detalle de ticket 
                For Each objItemticket As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
                    objParametros = New Parameter
                    With objParametros
                        .Add("IN_NORDSR", objItemticket.pintOrdenServicio_NORDSR)
                        .Add("IN_USUARI", strUsuarioSistema)
                        .Add("IN_CSRVNV", objItemticket.pstrTipoServicio_CSRVNV)
                        .Add("IN_HORAINI", objItemticket.pintHoraInicio_HORAINI.Replace(":", ""))
                        .Add("IN_HORAFIN", objItemticket.pintHoraFin_HORAFIN.Replace(":", ""))
                        .Add("IN_NHRCAL", objItemticket.pdecHoraCalculada_NHRCAL)
                        .Add("IN_NHRFAC", objItemticket.pdecHoraFacturada_NHRFAC)
                        .Add("IN_OBSER", objItemticket.pstrObservacion_OBSER)
                        .Add("IN_FATNSR", objItemticket.pintFecha_FATNSR)
                    End With
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SDSW_ALMACEN_TICKET_DETALLE", objParametros)

                Next

            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnOrdenDespacho_TicketW >> de la clase << clsDespachoSDS >> " & vbNewLine & _
                                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                                  "Motivo del Error : " & ex.Message
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

#End Region
    End Class
End Namespace

