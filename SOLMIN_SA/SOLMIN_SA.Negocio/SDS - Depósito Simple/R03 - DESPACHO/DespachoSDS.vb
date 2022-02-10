Imports RANSA.TYPEDEF
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Namespace slnSOLMIN_SDS.DespachoSDS.Procesos
    Public Class clsDespacho
        Inherits clsBasicClass
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
                dtEntidad = fdtResultadoConsulta(strMensajeError, "SDS_DESP_GUIRNS_01", .pintCodigoCliente_CCLNT.ToString, .pstrNroGuiaRANSA_NGUIRN, _
                                                 .pstrTipoAlmacen_CTPALM, .pstrAlmacen_CALMC, .pstrFechaInicial_FNum_FASGTR, .pstrFechaFinal_FNum_FASGTR)
            End With
            Return dtEntidad
        End Function

        Public Shared Function fdtListar_GuiasRemision(ByVal objFiltro As clsFiltros_ListarGuiasRemisionDS, ByRef strMensajeError As String) As DataTable
            Dim dtEntidad As DataTable = Nothing
            ' Busco la relación de los Motivos de Traslado
            With objFiltro
                dtEntidad = fdtResultadoConsulta(strMensajeError, "SDS_DESP_GUIARM_01", .pintCodigoCliente_CCLNT.ToString, .pstrNroGuiaRANSA_NGUIRN)
            End With
            Return dtEntidad
        End Function

        Public Shared Function fdtListar_StockMercaderias(ByVal objFiltro As clsFiltro_ListarMercaderia, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_DESP_LSTMER_01", objFiltro.pintCodigoCliente_CCLNT, objFiltro.pstrCodigoFamilia_CFMCLR, _
                                               objFiltro.pstrCodigoGrupo_CGRCLR, objFiltro.pstrCodigoMercaderia_CMRCLR, objFiltro.pintFechaVencimiento_FVNCMR, _
                                               objFiltro.pintFechaInventario_FINVRN, objFiltro.pstrStatusPublicacionWEB_FPUWEB)
            dtResultado.TableName = "Lista de Mercadería"
            Return dtResultado
        End Function

        Public Shared Function fdtListar_StockMercaderiasPorAlmacen(ByVal intOrdenServicio As Int64, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_DESP_LSTSXA_01", intOrdenServicio)
            dtResultado.TableName = "Lista Stock de Mercadería por Almacén"
            Return dtResultado
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
        '    dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_RECE_DEFREC_01", strCompania, strDivision)
        '    dtResultado.TableName = "Servicio de Despacho"
        '    Return dtResultado
        'End Function

        Public Shared Function fdtDefecto_TipoMovimientoDespacho(ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_DESP_DEFTMV_01")
            dtResultado.TableName = "Tipo de Despacho"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
        Public Function fblnDespacho_Mercaderia(ByRef resultadoEnvioInterfaz As String, ByRef strMensajeError As String, ByVal intNroGuiaRansa_NGUIRN As Int64, _
                                                 ByVal objMovimientoMercaderia As clsMovimientoMercaderia, ByVal strPCUSER As String) As Boolean
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

                If objMovimientoMercaderia.pintServicio_CSRVC.ToString.Length < 3 Then
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
                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_OBSERV_INS", objParametros)
                End If
                ' -------------------------------------------------'
                ' Segundo Paso - Recorremos los Item recepcionados '
                ' -------------------------------------------------'

                'verificamos si es para ingreso = 910 o despacho=911 
                If objMovimientoMercaderia.pintServicio_CSRVC = 910 Then
                    For Each objItemMovimientoMercaderia As clsItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                        objParametros = New Parameter
                        With objParametros
                            .Add("IN_CCLNT", objMovimientoMercaderia.pintCodigoCliente_CCLNT)
                            .Add("IN_NORDSR", objItemMovimientoMercaderia.pintOrdenServicio_NORDSR)
                            .Add("IN_NCNTR", objItemMovimientoMercaderia.pintNroContrato_NCNTR)
                            .Add("IN_NAUTR", objItemMovimientoMercaderia.pintNroAutorizacion_NAUTR)
                            .Add("IN_NCRCTC", objItemMovimientoMercaderia.pintNroCorrDetalleContrato_NCRCTC)
                            .Add("IN_NRITOC", objItemMovimientoMercaderia.pintNroItemOC_NRITOC)
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
                            .Add("IN_CTPOCN", objItemMovimientoMercaderia.pstrDesglose_CTPOCN)
                            .Add("IN_TOBSRV", objItemMovimientoMercaderia.pstrObservaciones_TOBSRV)
                            .Add("IN_NGUICL", objItemMovimientoMercaderia.pstrNroGuiaCliente_NGUICL)
                            .Add("IN_NORCCL", objItemMovimientoMercaderia.pstrNroOrdenCompraCliente_NORCCL)
                            .Add("IN_NRUCLL", objItemMovimientoMercaderia.pstrNroRUCCliente_NRUCLL)
                            .Add("IN_CCNTD", objItemMovimientoMercaderia.pstrContenedor_CCNTD)

                            .Add("IN_FUNDS3", objItemMovimientoMercaderia.pstrSatusUnidadDespacho_FUNDS2)
                            .Add("IN_STPING", objItemMovimientoMercaderia.pstrTipoMovimiento_STPING)
                            .Add("IN_NSLCRF", objItemMovimientoMercaderia.pdecNumSolicitudDeReferencia_NSLCRF)

                            .Add("IN_TIPORG", objMovimientoMercaderia.pstrTipoOrigen_TIPORG.Trim)
                            .Add("IN_TIPORI", objMovimientoMercaderia.pstrTipoDocumentoOrigen_TIPORI.Trim)
                            .Add("IN_CPRVCL", objMovimientoMercaderia.pstrCodigoProveedor_CPRVCL.Trim)
                            .Add("IN_SCNEMB", objMovimientoMercaderia.pstrControlEmbalaje_SCNEMB)
                            .Add("IN_FRLZSR", objMovimientoMercaderia.pintFechaRealizacion_FRLZSR)
                            .Add("IN_NTRMNL", strPCUSER)
                            .Add("IN_USUARI", strUsuarioSistema)
                            .Add("OU_NSLCSR", 0, ParameterDirection.Output)
                        End With
                        Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_INS", objParametros)
                        objItemMovimientoMercaderia.pintNrSolicitudServicio_NSLCSR = objSqlManager.ParameterCollection("OU_NSLCSR")

                        If objItemMovimientoMercaderia.pbolEsOutotec Then
                            If Not objItemMovimientoMercaderia.oListaProyecto Is Nothing Then
                                For Each obeProyecto As beProyecto In objItemMovimientoMercaderia.oListaProyecto
                                    objParametros = New Parameter
                                    With objParametros
                                        .Add("IN_CCLNT", objMovimientoMercaderia.pintCodigoCliente_CCLNT)
                                        .Add("IN_NORCML", objItemMovimientoMercaderia.pstrNroOrdenCompraCliente_NORCCL)
                                        .Add("IN_NRITOC", objItemMovimientoMercaderia.pintNroItemOC_NRITOC)
                                        .Add("IN_NRFRPD", obeProyecto.PSNRFRPD)
                                        .Add("IN_NORDSR", objItemMovimientoMercaderia.pintOrdenServicio_NORDSR)
                                        .Add("IN_NSLCSR", objItemMovimientoMercaderia.pintNrSolicitudServicio_NSLCSR)
                                        .Add("IN_CSRVC", objMovimientoMercaderia.pintServicio_CSRVC)
                                        .Add("IN_QCNRCP", obeProyecto.PNQCNTIT2)
                                        .Add("IN_TIPDEV", objItemMovimientoMercaderia.pstrTipoMovimiento_STPING)
                                        .Add("IN_USUARIO", strUsuarioSistema)
                                        .Add("IN_NTRMNL", strPCUSER)
                                    End With
                                    Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_PROYECTOS_REGISTRAR_INGRESO", objParametros)
                                Next
                            End If
                        End If
                    Next
                Else
                    For Each objItemMovimientoMercaderia As clsItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
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

                            'ALMACEN 
                            .Add("IN_CTPALM", objItemMovimientoMercaderia.pstrTipoAlmacen_CTPALM)
                            .Add("IN_CALMC", objItemMovimientoMercaderia.pstrAlmacen_CALMC)
                            .Add("IN_CZNALM", objItemMovimientoMercaderia.pstrZonaAlmacen_CZNALM)

                            .Add("IN_NGUIRN", intNroGuiaRansa_NGUIRN)

                            'CANTIDAD TOTAL POR MOVIMIENTO
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

                            .Add("IN_CDPEPL", objItemMovimientoMercaderia.CodPedidoPlanta_CDPEPL)
                            .Add("IN_CDREGP", objItemMovimientoMercaderia.NrItemPedidoPLanta_CDREGP)

                            .Add("IN_USUARI", strUsuarioSistema)

                            'VARIABLES PARA INGRESAR EN VARIOS ALMACEES
                            .Add("IN_CORREL", objItemMovimientoMercaderia.intCorrelativo)
                            .Add("IN_CANT", objItemMovimientoMercaderia.PNQTRMC)
                            .Add("IN_PESO", objItemMovimientoMercaderia.PNQTRMP)
                            .Add("IN_TIPORG", objItemMovimientoMercaderia.PSTIPORG.Trim)
                            .Add("IN_TIPORI", objItemMovimientoMercaderia.PSTIPORI.Trim)
                            .Add("IN_CPRVCL", objItemMovimientoMercaderia.pstrCodigoProveedor_CPRVCL.Trim)
                            .Add("IN_FRLZSR", objMovimientoMercaderia.pintFechaRealizacion_FRLZSR)
                            .Add("O_NSLCSR", 0, ParameterDirection.Output)
                        End With
                        Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_SAL", objParametros)
                        objItemMovimientoMercaderia.pintNroSolicitudSalida_NSLCSS = objSqlManager.ParameterCollection("O_NSLCSR")
                        If objItemMovimientoMercaderia.pbolEsOutotec Then
                            objParametros = New Parameter
                            With objParametros
                                .Add("IN_CCLNT", objMovimientoMercaderia.pintCodigoCliente_CCLNT)
                                .Add("IN_NORCML", objItemMovimientoMercaderia.pstrNroOrdenCompraCliente_NORCCL)
                                .Add("IN_NRITOC", objItemMovimientoMercaderia.pintNroItemOC_NRITOC)
                                .Add("IN_NRFRPD", objItemMovimientoMercaderia.pstrNrRefPedido_NRFRPD)
                                .Add("IN_NORDSR", objItemMovimientoMercaderia.pintOrdenServicio_NORDSR)
                                .Add("IN_NSLCSR", objItemMovimientoMercaderia.pintNroSolicitudSalida_NSLCSS)
                                .Add("IN_CSRVC", objMovimientoMercaderia.pintServicio_CSRVC)
                                .Add("IN_QCNDPC", objItemMovimientoMercaderia.PNQTRMC)
                                .Add("IN_USUARIO", strUsuarioSistema)
                                .Add("IN_NTRMNL", strPCUSER)
                            End With
                            Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_PROYECTOS_REGISTRAR_DESPACHO", objParametros)
                        End If

                    Next
                End If

                Dim ListaClnt As New Hashtable
                Dim obeClnt As New beGeneral
                Dim obrGeneral As New brGeneral
                obeClnt.PSCODVAR = "CLTABB"
                obeClnt.PSCCMPRN = ""
                Dim listaCliente As New List(Of beGeneral)
                listaCliente = obrGeneral.ListaTablaAyuda(obeClnt)
                For Each beGen As beGeneral In listaCliente
                    ListaClnt.Add(beGen.PSCCMPRN.Trim, beGen.PSCCMPRN.Trim)
                Next

                'If objMovimientoMercaderia.pintCodigoCliente_CCLNT = 11232 And objMovimientoMercaderia.plstItemMovimientoMercaderia(0).pstrTipoMovimiento_STPING <> "T" Then
                '    strMensajeError = fEnviarDespachoABB(resultadoEnvioInterfaz, intNroGuiaRansa_NGUIRN, objMovimientoMercaderia.pintCodigoCliente_CCLNT)
                'End If
                If ListaClnt.Contains(objMovimientoMercaderia.pintCodigoCliente_CCLNT.ToString.Trim) And objMovimientoMercaderia.plstItemMovimientoMercaderia(0).pstrTipoMovimiento_STPING <> "T" Then
                    fEnviarDespachoABB(resultadoEnvioInterfaz, intNroGuiaRansa_NGUIRN, objMovimientoMercaderia.pintCodigoCliente_CCLNT)
                End If

            Catch ex As Exception
                'strMensajeError = "Error producido en la funcion : << fblnDespacho_Mercaderia >> de la clase << clsDespacho >> " & vbNewLine & _
                '                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                '                  "Motivo del Error : " & ex.Message
                strMensajeError = ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        '
        Private Sub fEnviarDespachoABB(ByRef resultadoEnvioInterfaz As String, ByVal pdecGuiaRansa As Decimal, ByVal pintCliente As Integer)
            Dim mensajeEnvio As String = ""
            Try
                Dim obrDespacho As New RANSA.NEGO.brDespacho
                Dim obeDespachoFiltro As New RANSA.TYPEDEF.beDespacho
                Dim olbeDespacho As New List(Of RANSA.TYPEDEF.beDespacho)
                obeDespachoFiltro.PNCCLNT = pintCliente
                obeDespachoFiltro.PNNGUIRN = pdecGuiaRansa
                olbeDespacho = obrDespacho.ListaParaExportarABB(obeDespachoFiltro)
                If olbeDespacho.Count > 0 Then
                    'Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
                    'Dim obeDespachoABB As New WSABB.IntegracionABB.beDespacho
                    Dim oIntegracionABB As New RANSA.NEGO.ProxyRansa.WSABB.Integracion.IntegracionABB(pintCliente.ToString.Trim)
                    Dim obeDespachoABB As New RANSA.NEGO.ProxyRansa.WSABB.Integracion.beDespacho

                    With obeDespachoABB
                        .vc_RansaOutGuide = obeDespachoFiltro.PNNGUIRN
                        .dt_ReferralGuideDate = Date.Parse(RANSA.Utilitario.HelpClass.CNumero_a_Fecha(olbeDespacho.Item(0).PNFRLZSR.ToString))
                        .vc_TransferReason = ""
                        .vc_HomeName = olbeDespacho.Item(0).PSTCMPCL
                        .vc_HomeAddress = olbeDespacho.Item(0).PSTDRCOR
                        .vc_CustomerCodeDeliver = olbeDespacho.Item(0).PSCPRPCL.Trim
                        .vc_CustomerFiscalCodeDeliver = olbeDespacho.Item(0).PSNRUCPR
                        .vc_CustomerAddressDeliverLine1 = olbeDespacho.Item(0).PSTDRPCP
                        .vc_CustomerAddressDeliverLine2 = olbeDespacho.Item(0).PSTDRDST
                        .vc_CustomerAddressLine3 = ""
                        .vc_CustomerFiscalName = olbeDespacho.Item(0).PSTPRVCL
                        .vc_VehiclePlate = olbeDespacho.Item(0).PSNPLCCM
                        .vc_TransportCarrierName = olbeDespacho.Item(0).PSTCMPTR
                        .vc_TransportCarrierFiscalCode = olbeDespacho.Item(0).PNNRUCT
                        .vc_TransportCarrierAddress = olbeDespacho.Item(0).PSTDRCTR
                        .vc_Driver = "" & olbeDespacho.Item(0).PSTNMBCH & ""
                        .vc_DriversLicense = "" & olbeDespacho.Item(0).PSNBRVCH & ""
                        .vc_ReferralGuideComments = ""
                        .vc_Usuario = strUsuarioSistema
                        .vc_OrderNumber = olbeDespacho.Item(0).PSNRFRPD
                        .vc_OrderType = olbeDespacho.Item(0).PSNRFTPD
                    End With
                    'Dim obelistDetalleDespachoABB As New List(Of WSABB.IntegracionABB.beDetalleDespacho)
                    Dim obelistDetalleDespachoABB As New List(Of RANSA.NEGO.ProxyRansa.WSABB.Integracion.beDetalleDespacho)
                    For Each obeDespacho As beDespacho In olbeDespacho
                        'Dim obeDetalleDespachoABB As New WSABB.IntegracionABB.beDetalleDespacho
                        Dim obeDetalleDespachoABB As New RANSA.NEGO.ProxyRansa.WSABB.Integracion.beDetalleDespacho

                        With obeDetalleDespachoABB
                            .vc_OrderNumber = obeDespacho.PSNRFRPD
                            .vc_OrderType = obeDespacho.PSNRFTPD
                            .in_OrderLine = Val(obeDespacho.PSNLTECL)
                            .vc_StockCode = obeDespacho.PSCMRCLR
                            If obeDespacho.PSDEMERCA.Trim.Length > 50 Then
                                .vc_LineDescriptionLine1 = obeDespacho.PSDEMERCA.Trim.Substring(0, 50)
                                .vc_LineDescriptionLine2 = obeDespacho.PSDEMERCA
                            Else
                                .vc_LineDescriptionLine1 = obeDespacho.PSDEMERCA.Trim
                                .vc_LineDescriptionLine2 = ""
                            End If
                            .vc_UnitMeasure = obeDespacho.PSCUNCN6  'UNIDA DE MEDIDA
                            .fl_Quantity = obeDespacho.PNQTRMC
                            .vc_Usuario = strUsuarioSistema
                            .vc_ReferenceGuide = obeDespacho.PSGUIA
                        End With

                        'Dim obelistSerie As New List(Of WSABB.IntegracionABB.beSerie)
                        Dim obelistSerie As New List(Of RANSA.NEGO.ProxyRansa.WSABB.Integracion.beSerie)
                        Dim intCorrelativo As Integer = 0

                        Dim olBeSerie As New List(Of RANSA.TYPEDEF.beDespacho)
                        olBeSerie = obrDespacho.ListaSerieExportarABB(obeDespacho)
                        For Each obeSeri As RANSA.TYPEDEF.beDespacho In olBeSerie
                            'Dim obeSerie As New WSABB.IntegracionABB.beSerie
                            Dim obeSerie As New RANSA.NEGO.ProxyRansa.WSABB.Integracion.beSerie
                            intCorrelativo = intCorrelativo + 1
                            With obeSerie
                                '==========Cabecera Despacho
                                .in_IdSerie = intCorrelativo.ToString
                                '.in_ReferralGuideLine(", intEstado_D.ToString)")
                                '.in_ReferralGuideNumber(", intEstado_C.ToString)")
                                .vc_StockCode = obeSeri.PSCMRCLR
                                .vc_NumeroSerie = obeSeri.PSCSRECL
                            End With
                            obelistSerie.Add(obeSerie)
                        Next

                        obeDetalleDespachoABB.listSerie = obelistSerie.ToArray()
                        obelistDetalleDespachoABB.Add(obeDetalleDespachoABB)
                    Next
                    obeDespachoABB.listDetalleDespacho = obelistDetalleDespachoABB.ToArray()

                    'Dim obeResultado As WSABB.IntegracionABB.beResultado
                    Dim obeResultado As RANSA.NEGO.ProxyRansa.WSABB.Integracion.beResultado

                    ' Dim BdConexionCliente As String = ""
                    'Dim server As String = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.Server()
                    'If server = RANSA.Utilitario.HelpClass.ServerRANSA01 Or server = RANSA.Utilitario.HelpClass.ServerRANSAT01 Then
                    'BdConexionCliente = "DESARROLLO"
                    '  End If
                    'If server = RANSA.Utilitario.HelpClass.ServerRANSA Then
                    'BdConexionCliente = "PRODUCCION"
                    ' End If
                    obeResultado = oIntegracionABB.Integracion_Insertar_Despacho(pintCliente, obeDespachoABB)
                    'obeResultado = oIntegracionABB.Integracion_Insertar_Despacho("PRODUCCION", obeDespachoABB)
                    If obeResultado.Codigo = 1 Then
                        Dim objDespacho As New brDespacho
                        Dim obeConfirmacion As New beDespacho

                        With obeConfirmacion
                            .PSCTPIS = "S"
                            .PNCCLNT = obeDespachoFiltro.PNCCLNT
                            .PNNGUIRN = obeDespachoFiltro.PNNGUIRN
                            '.PNFRLZSR = oDtCab.Rows(0).Item("FRLZSR")
                            .PSSTPODP = "1"
                            .PNNPRTIN = 0
                            .PSSTRNSM = "X"
                            .PNFTRNSM = Convert.ToDecimal(RANSA.Utilitario.HelpClass.CtypeDate(DateTime.Today))
                            .PNHTRNSM = Convert.ToDecimal(RANSA.Utilitario.HelpClass.NowNumeric())
                            .PSCUSCRT = strUsuarioSistema
                            .PNFCHCRT = Convert.ToDecimal(RANSA.Utilitario.HelpClass.CtypeDate(DateTime.Today))
                            .PNHRACRT = Convert.ToDecimal(RANSA.Utilitario.HelpClass.NowNumeric())
                            .PSCULUSA = strUsuarioSistema
                            .PNFULTAC = Convert.ToDecimal(RANSA.Utilitario.HelpClass.CtypeDate(DateTime.Today))
                            .PNHULTAC = Convert.ToDecimal(RANSA.Utilitario.HelpClass.NowNumeric())
                        End With

                        Dim rpta As Integer = 1
                        rpta = objDespacho.fintRegistrarEnvioInterfaz(obeConfirmacion)
                        'If rpta = 0 Then
                        '    Return "Error al Registrar Envio Interfaz"
                        'End If
                        'Return "Error : " & obeResultado.Codigo & Chr(10) & "Descripción :" & obeResultado.Mensaje
                    Else
                        If obeResultado IsNot Nothing Then
                            resultadoEnvioInterfaz = "Cliente:" & pintCliente.ToString.Trim & "- Error envío Interfaz Despacho " & Chr(13) & obeResultado.Mensaje
                        Else
                            resultadoEnvioInterfaz = "Cliente:" & pintCliente.ToString.Trim & "- Error envío Interfaz Despacho"
                        End If
                    End If
                Else
                    resultadoEnvioInterfaz = "Cliente:" & pintCliente.ToString.Trim & "- Guía no enviada , sin datos de envío"
                End If

            Catch ex As Exception
                'Return ex.Message
                resultadoEnvioInterfaz = "Cliente:" & pintCliente.ToString.Trim & " - ex.Message"
            End Try



        End Sub



#End Region
    End Class
End Namespace

