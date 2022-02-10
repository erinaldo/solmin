Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.NEGO.slnSOLMIN_SDS
Imports RANSA.TYPEDEF
Imports RANSA.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Namespace slnSOLMIN_SDS.RecepcionSDS.Procesos
    Public Class clsRecepcion
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
        Public Shared Function fdtListar_ContratosVigentes(ByVal strCliente As String, ByVal strTipoDeposito As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_RECE_LSTCNT_01", strCliente, strTipoDeposito)
            dtResultado.TableName = "Contratos Vigentes"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Detalle de la Información -'
        '--------------------------------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento para Obtener Información  -'
        '-------------------------------------------'
        Public Shared Function fdtObtener_InfUltimoAlmacenSegunOS(ByVal strNroOS As String, ByVal strServicio As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_RECE_INFALM_01", strNroOS, strServicio)
            dtResultado.TableName = "Información de Almacén"
            Return dtResultado
        End Function

        Public Shared Function fdtObtener_InfUltimoAlmacenSegunCliente(ByVal intCliente As Int64, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_RECE_INFALM_02", intCliente)
            dtResultado.TableName = "Información de Almacén"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Obtener Información por Defecto -'
        '----------------------------------------------------'
        Public Shared Function fdtDefecto_ServicioRecepcion(ByVal strCompania As String, ByVal strDivision As String, ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_RECE_DEFREC_01", strCompania, strDivision)
            dtResultado.TableName = "Servicio de Recepcion"
            Return dtResultado
        End Function

        Public Shared Function fdtDefecto_TipoMovimientoRecepcion(ByRef strMensajeError As String) As DataTable
            Dim dtResultado As DataTable = Nothing
            dtResultado = fdtResultadoConsulta(strMensajeError, "SDS_RECE_DEFTMV_01")
            dtResultado.TableName = "Tipo de Recepción"
            Return dtResultado
        End Function

        '------------------------------------------------------------------------------------------------------------------'
        '- Procedimiento de Existencia -'
        '-------------------------------'

        '------------------------------------------------------------------------------------------------------------------'
        '- Gestión de la Información -'
        '-----------------------------'
        Public Function fblnRecepcion_Mercaderia(ByRef strMensajeError As String, ByVal intNroGuiaRansa_NGUIRN As Int64, _
                                                 ByVal objMovimientoMercaderia As clsMovimientoMercaderia, ByVal strPCUSER As String, ByRef msgMigracionCliente As String) As Boolean
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
                Call objSqlManager.ExecuteNonQuery("SP_SOLMIN_SA_SDS_ALMACEN_OBSERV_INS", objParametros)
                ' -------------------------------------------------'
                ' Segundo Paso - Recorremos los Item recepcionados '
                ' -------------------------------------------------'
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

                Dim daGeneral As New DATA.daGeneral

                ''Proyecto ABB
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
                'If daGeneral.fIntValidarEnvioABB(objMovimientoMercaderia.plstItemMovimientoMercaderia(0).pstrNroOrdenCompraCliente_NORCCL) = 0 And objMovimientoMercaderia.pintCodigoCliente_CCLNT = 11232 And objMovimientoMercaderia.plstItemMovimientoMercaderia(0).pstrTipoMovimiento_STPING <> "T" Then
                If ListaClnt.Contains(objMovimientoMercaderia.pintCodigoCliente_CCLNT.ToString.Trim) And objMovimientoMercaderia.plstItemMovimientoMercaderia(0).pstrTipoMovimiento_STPING <> "T" Then
                    fEnviarRecepcionABB(intNroGuiaRansa_NGUIRN, objMovimientoMercaderia.pintCodigoCliente_CCLNT, msgMigracionCliente)
                End If
            Catch ex As Exception
                strMensajeError = "Error producido en la funcion : << fblnRecepcion_Mercaderia >> de la clase << clsRecepcion >> " & vbNewLine & _
                                  "Tipo de Consulta : Llamada al Stored Procedure " & vbNewLine & _
                                  "Motivo del Error : " & ex.Message
                blnResultado = False
            Finally
                objSqlManager = Nothing
                objParametros = Nothing
            End Try
            Return blnResultado
        End Function

        Private Sub fEnviarRecepcionABB(ByVal pdecGuiaRansa As Decimal, ByVal pintCliente As Decimal, ByRef msgMigracionCliente As String)
            Try
                Dim obrRecepcion As New RANSA.NEGO.brMercaderia
                Dim obrDespacho As New RANSA.NEGO.brDespacho
                Dim obeDespacho As New RANSA.TYPEDEF.beDespacho
                Dim odtRecepcion As New DataTable
                obeDespacho.PNCCLNT = pintCliente
                obeDespacho.PNNGUIRN = pdecGuiaRansa
                odtRecepcion = obrDespacho.fdtListaParaExportarABBRecepcion(obeDespacho)

                'Dim oIntegracionABB As New WSABB.IntegracionABB.Integracion
                'Dim obeRecepcionABB As New WSABB.IntegracionABB.beRecepcion
                Dim oIntegracionABB As New RANSA.NEGO.ProxyRansa.WSABB.Integracion.IntegracionABB(pintCliente.ToString.Trim)
                Dim obeRecepcionABB As New RANSA.NEGO.ProxyRansa.WSABB.Integracion.beRecepcion


                With odtRecepcion.Rows(0)
                    obeRecepcionABB.vc_RansaInGuide = .Item("nguirn")
                    obeRecepcionABB.vc_PurchaseOrder = .Item("NORCCL")
                    obeRecepcionABB.dt_DeliveryGuideDate = RANSA.Utilitario.HelpClass.CNumero_a_Fecha(.Item("FRLZSR"))
                    obeRecepcionABB.vc_VehiclePlate = .Item("NPLCCM")
                    obeRecepcionABB.vc_TransportCarrierName = .Item("TCMPTR")
                    obeRecepcionABB.vc_TransportCarrierFiscalCode = .Item("NRUCT")
                    obeRecepcionABB.vc_Driver = ""
                    obeRecepcionABB.vc_DriversLicense = .Item("NBRVCH")
                    obeRecepcionABB.vc_DeliveryGuideComments = ""
                    obeRecepcionABB.vc_Usuario = strUsuarioSistema

                    'Dim olistDetalleRecepcion As New List(Of WSABB.IntegracionABB.beDetalleRecepcion)
                    Dim olistDetalleRecepcion As New List(Of RANSA.NEGO.ProxyRansa.WSABB.Integracion.beDetalleRecepcion)

                    'Dim obeDetalleRecepcion As WSABB.IntegracionABB.beDetalleRecepcion
                    Dim obeDetalleRecepcion As RANSA.NEGO.ProxyRansa.WSABB.Integracion.beDetalleRecepcion
                    For IntRow As Integer = 0 To odtRecepcion.Rows.Count - 1
                        'obeDetalleRecepcion = New WSABB.IntegracionABB.beDetalleRecepcion
                        obeDetalleRecepcion = New RANSA.NEGO.ProxyRansa.WSABB.Integracion.beDetalleRecepcion



                        With odtRecepcion.Rows(IntRow)
                            obeDetalleRecepcion.in_PurchaseOrder = .Item("NORCCL")
                            obeDetalleRecepcion.in_PurchaseOrderLine = .Item("NRITOC")
                            obeDetalleRecepcion.vc_SupplierCode = .Item("NRUCLL")
                            obeDetalleRecepcion.vc_SupplierFiscalCode = ""
                            obeDetalleRecepcion.vc_SupplierFiscalName = ""
                            obeDetalleRecepcion.vc_StockCode = .Item("CMRCLR")
                            obeDetalleRecepcion.vc_LineDescriptionLine1 = ""
                            obeDetalleRecepcion.vc_LineDescriptionLine2 = ""
                            obeDetalleRecepcion.vc_UnitMeasureCode = .Item("CUNCN5")
                            obeDetalleRecepcion.fl_QuantityReceived = .Item("QTRMC")
                            obeDetalleRecepcion.vc_MDFCode = ""

                            .Item("NGUICL") = .Item("NGUICL").ToString.Replace("-", "")
                            If Not IsNumeric(.Item("NGUICL")) Then
                                .Item("NGUICL") = "0"
                            End If
                            If .Item("NGUICL") > Int32.MaxValue Then
                                .Item("NGUICL") = 0
                            End If
                            obeDetalleRecepcion.in_SupplierDeliveryGuideNumber = Conversion.Int(.Item("NGUICL").ToString)
                            obeDetalleRecepcion.in_Embarque = .Item("NORSCI")
                            obeDetalleRecepcion.vc_Usuario = strUsuarioSistema

                        End With
                        olistDetalleRecepcion.Add(obeDetalleRecepcion)
                    Next
                    obeRecepcionABB.ListaDetalleRecepcion = olistDetalleRecepcion.ToArray()
                End With

                'Dim obeResultado As WSABB.IntegracionABB.beResultado
                Dim obeResultado As RANSA.NEGO.ProxyRansa.WSABB.Integracion.beResultado
                'RANSA.Utilitario.HelpClass.ServerRANSA01 Or NameDB = RANSA.Utilitario.HelpClass.ServerRANSAT01
                'Dim Liberia As String = ConfigurationWizard.Library()
                'If Liberia = RANSA.Utilitario.HelpClass.ServerRANSA01 And Liberia = RANSA.Utilitario.HelpClass.ServerRANSAT01 Then
                '    obeResultado = oIntegracionABB.Integracion_Insertar_Recepcion("DESARROLLO", obeRecepcionABB)
                'End If
                'If Liberia = RANSA.Utilitario.HelpClass.ServerRANSA Then
                '    obeResultado = oIntegracionABB.Integracion_Insertar_Recepcion("PRODUCCION", obeRecepcionABB)
                'End If
                obeResultado = oIntegracionABB.Integracion_Insertar_Recepcion(pintCliente.ToString.Trim, obeRecepcionABB)

                If obeResultado.Codigo = 1 Then
                    'Return ("Error : " & obeResultado.Codigo & Chr(10) & "Descripción :" & obeResultado.Mensaje)
                    Dim objDespacho As New brDespacho
                    Dim obeConfirmacion As New beDespacho

                    With obeConfirmacion
                        .PSCTPIS = "I"
                        .PNCCLNT = obeDespacho.PNCCLNT
                        .PNNGUIRN = obeDespacho.PNNGUIRN
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
                    If rpta = 0 Then
                        'Return "Error al Registrar Envio Interfaz"
                        msgMigracionCliente = "Cliente:" & pintCliente.ToString.Trim & " - Error al Registrar Envio Interfaz"
                    End If

                Else
                    msgMigracionCliente = "Cliente:" & pintCliente.ToString.Trim & " - Error al enviar ( " & obeResultado.Codigo & " )."
                End If


            Catch ex As Exception
                msgMigracionCliente = "Cliente:" & pintCliente.ToString.Trim & " - " & ex.Message
                'Return ex.Message
            End Try

        End Sub

#End Region


    End Class
End Namespace




