Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Namespace mantenimientos
    Public Class GuiaTransportista_BLL

        Dim objDataAccessLayer As New GuiaTransportista_DAL

        Public Function Verificacion_Existencia_Operacion_Transporte(ByVal objEntidad As OperacionTransporte) As OperacionTransporte
            Return objDataAccessLayer.Verificacion_Existencia_Operacion_Transporte(objEntidad)
        End Function

        Public Function Obtener_Numero_Guia_Transporte(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Obtener_Numero_Guia_Transporte(objEntidad)
        End Function

        Public Function Obtener_Informacion_Orden_Servicio(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Obtener_Informacion_Orden_Servicio(objEntidad)
        End Function

        Public Function Listar_Guias_x_Transportista(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            'Try
            Return objDataAccessLayer.Listar_Guias_x_Transportista(objEntidad)
            'Catch
            '    Return New List(Of GuiaTransportista)
            'End Try
        End Function

        Public Function Listar_Guias_x_Transportista(ByVal objEntidad As Hashtable) As List(Of GuiaTransportista)
            'Try
            Return objDataAccessLayer.Listar_Guias_x_Transportista(objEntidad)
            'Catch
            '    Return New List(Of GuiaTransportista)
            'End Try
        End Function

        Public Function Listar_Guias_x_Transportista_Proveedor(ByVal objEntidad As Hashtable) As List(Of GuiaTransportista)
            'Try
            Return objDataAccessLayer.Listar_Guias_x_Transportista_Proveedor(objEntidad)
            'Catch
            '    Return New List(Of GuiaTransportista)
            'End Try
        End Function


        Public Function Listar_Guia_Transportista_Reparto(ByVal objetoParametro As Hashtable) As DataTable
            'Try
            Return objDataAccessLayer.Listar_Guia_Transportista_Reparto(objetoParametro)
            'Catch
            '    Return New DataTable
            'End Try
        End Function

        Public Function Listar_Tractos_x_Planeamiento(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            'Try
            Return objDataAccessLayer.Listar_Tractos_x_Planeamiento(objEntidad)
            'Catch
            '    Return New List(Of GuiaTransportista)
            'End Try
        End Function

        Private Function FormatoHora(ByVal texto As String) As String 
            If texto = "" Then
                texto = "0000"
            End If
            texto = (texto.Replace(":", "") & "00").PadLeft(6, "0")
            Return texto
        End Function

        Public Function Registrar_Guia_Transportista_Atugenerada(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            objEntidad.HRAINI = FormatoHora(objEntidad.HRAINI)
            Return objDataAccessLayer.Registrar_Guia_Transportista_Atugenerada(objEntidad)
        End Function

        Public Function Registrar_Guia_Transportista_Manual(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            objEntidad.HRAINI = FormatoHora(objEntidad.HRAINI)
            Return objDataAccessLayer.Registrar_Guia_Transportista_Manual(objEntidad)
        End Function

        Public Function Modificar_Guia_Transportista_Atugenerada(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            objEntidad.HRAINI = FormatoHora(objEntidad.HRAINI)
            Return objDataAccessLayer.Modificar_Guia_Transportista_Atugenerada(objEntidad)
        End Function

        Public Function Registrar_Guia_Transportista_General(ByVal objEntidad As GuiaTransportista, ByRef msgError As String) As GuiaTransportista
            objEntidad.HRAINI = FormatoHora(objEntidad.HRAINI)
            Return objDataAccessLayer.Registrar_Guia_Transportista_General(objEntidad, msgError)
        End Function

        Public Sub Modificar_Guia_Transportista_General(ByVal objEntidad As GuiaTransportista)
            objEntidad.HRAINI = FormatoHora(objEntidad.HRAINI)
            objDataAccessLayer.Modificar_Guia_Transportista_General(objEntidad)
        End Sub

        Public Function Listar_Guia_Transportista(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Return objDataAccessLayer.Listar_Guia_Transportista(objetoParametro)
        End Function

        Public Function Listar_Guias_General(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Return objDataAccessLayer.Listar_Guias_General(objetoParametro)
        End Function

        Public Function Listar_Viaje_Consolidado(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Return objDataAccessLayer.Listar_Viaje_Consolidado(objetoParametro)
        End Function

        Public Function Listar_Moneda(ByVal strCompania As String) As DataTable
            Return objDataAccessLayer.Listar_Moneda(strCompania)
        End Function

        Public Function Obtener_Codigo_Transportista(ByVal lstr_RUC As String, ByVal strCompania As String) As Double
            Return objDataAccessLayer.Obtener_Codigo_Transportista(lstr_RUC, strCompania)
        End Function

        Public Function Obtener_RUC_Transportista(ByVal lstr_Codigo As Double, ByVal strCompania As String) As String
            Return objDataAccessLayer.Obtener_RUC_Transportista(lstr_Codigo, strCompania)
        End Function

        Public Function Obtener_Guia_Transportista_RPT(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Obtener_Guia_Transportista_RPT(objEntidad)
        End Function

        Public Function Registrar_GuiasCliente_Automatico(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Registrar_GuiasCliente_Automatico(objEntidad)
        End Function

    

        'Public Function Registrar_GuiasCliente_Automatico_Origen(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
        '    Return objDataAccessLayer.Registrar_GuiasCliente_Automatico_Origen(objEntidad)
        'End Function
        Public Sub Registrar_GuiasCliente_Automatico_Origen(ByVal objEntidad As GuiaTransportista)
            objDataAccessLayer.Registrar_GuiasCliente_Automatico_Origen(objEntidad)
        End Sub


        Public Function Registrar_GuiasCliente_Manual(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Registrar_GuiasCliente_Manual(objEntidad)
        End Function
        Public Function Registrar_GuiasCliente_Manual_Salm(ByVal objEntidad As GuiaTransportista) As String
            Return objDataAccessLayer.Registrar_GuiasCliente_Manual_Salm(objEntidad)
        End Function

        Public Function Registrar_ManifiestoCarga(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As ENTIDADES.GuiaOCManifiestoCarga
            Return objDataAccessLayer.Registrar_ManifiestoCarga(objEntidad)
        End Function

        Public Function Registrar_GuiaTransportistaAdicional(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Registrar_GuiaTransportistaAdicional(objEntidad)
        End Function

        Public Function Agregar_Guia_Transportista_Adicional(ByVal objEntidad As Detalle_Solicitud_Transporte) As Detalle_Solicitud_Transporte
            Return objDataAccessLayer.Agregar_Guia_Transportista_Adicional(objEntidad)
        End Function

        Public Function Eliminar_GuiaTransportistaAdicional(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Eliminar_GuiaTransportistaAdicional(objEntidad)
        End Function

        Public Function Eliminar_GuiasCliente(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Eliminar_GuiasCliente(objEntidad)
        End Function

        Public Function Eliminar_ManifiestoCarga(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As ENTIDADES.GuiaOCManifiestoCarga
            Return objDataAccessLayer.Eliminar_ManifiestoCarga(objEntidad)
        End Function

        Public Function Eliminar_Orden_Compra(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As ENTIDADES.GuiaOCManifiestoCarga
            Return objDataAccessLayer.Eliminar_Orden_Compra(objEntidad)
        End Function

        'Public Function Eliminar_Guia_Transportista(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
        '    Return objDataAccessLayer.Eliminar_Guia_Transportista(objEntidad)
        'End Function
        Public Sub Eliminar_Guia_Transportista(ByVal objEntidad As GuiaTransportista)
            objDataAccessLayer.Eliminar_Guia_Transportista(objEntidad)
        End Sub

        Public Sub Listar_Guias_X_GuiaTransportista(ByVal objEntidad As GuiaTransportista, ByRef listGRCliente As List(Of GuiaTransportista), ByRef listGTAnexo As List(Of GuiaTransportista), ByRef listOC As List(Of ENTIDADES.GuiaOCManifiestoCarga), ByRef dtPesoGT As DataTable)
            objDataAccessLayer.Listar_Guias_X_GuiaTransportista(objEntidad, listGRCliente, listGTAnexo, listOC, dtPesoGT)
        End Sub

        Public Function Listar_Ordenes_Compra_x_MC(ByVal objEntidad As ENTIDADES.GuiaOCManifiestoCarga) As List(Of ENTIDADES.GuiaOCManifiestoCarga)
            Return objDataAccessLayer.Listar_Ordenes_Compra_x_MC(objEntidad)
        End Function

        Public Function Listar_Guias_Anexas_Cliente(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            Return objDataAccessLayer.Listar_Guias_Anexas_Cliente(objEntidad)
        End Function

        Public Function Listar_Guias_Anexas_Transportista(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            Return objDataAccessLayer.Listar_Guias_Anexas_Transportista(objEntidad)
        End Function

        Public Function Listar_Solicitudes_Guia_Transportista(ByVal objetoParametro As Hashtable) As List(Of Detalle_Solicitud_Transporte)
            Return objDataAccessLayer.Listar_Solicitudes_Guia_Transportista(objetoParametro)
        End Function

        Public Function Listar_Guia_Remision_x_Operacion(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Return objDataAccessLayer.Listar_Guia_Remision_x_Operacion(objetoParametro)
        End Function

        Public Function Listar_Configuracion_Vehicular(ByVal strCompania As String) As List(Of ClaseGeneral)
            Return objDataAccessLayer.Listar_Configuracion_Vehicular(strCompania)
        End Function

        ' Liquidaci�n de Fletes
        Public Function Listar_GRemPendientesGTranspLiquidacion(ByVal oFiltro As TD_GuiaTransportistaPK) As List(Of TD_Obj_GuiaRemisionGTransp)
            Return objDataAccessLayer.Listar_GRemPendientesGTranspLiquidacion(oFiltro)
        End Function

        Public Function Listar_GRemCargadasGTranspLiquidacion(ByVal objEntidad As TD_GRemCargadasGTranspLiqPK) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Return objDataAccessLayer.Listar_GRemCargadasGTranspLiquidacion(objEntidad)
        End Function

        Public Function Listar_GRemCargadasGTranspLiquidacion(ByVal objEntidad As Hashtable) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Return objDataAccessLayer.Listar_GRemCargadasGTranspLiquidacion(objEntidad)
        End Function

        Public Function Listar_GRemCargadasGTranspLiquidacion_Reparto(ByVal objEntidad As TD_GRemCargadasGTranspLiqPK) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Return objDataAccessLayer.Listar_GRemCargadasGTranspLiquidacion_Reparto(objEntidad)
        End Function

        Public Function Listar_GRemCargadasGTranspLiquidacion_Multimodal(ByVal objEntidad As TD_GRemCargadasGTranspLiqPK) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Return objDataAccessLayer.Listar_GRemCargadasGTranspLiquidacion_Multimodal(objEntidad)
        End Function


        Public Function Listar_GRemHijasCargadasGTranspLiquidacion(ByVal objEntidad As TD_GRemHijasCargadasGTranspLiqPK) As List(Of TD_Obj_GRemHijasCargadasGTranspLiq)
            Return objDataAccessLayer.Listar_GRemHijasCargadasGTranspLiquidacion(objEntidad)
        End Function
        Public Function Listar_GRemServCargadasGTranspLiquidacion(ByVal objEntidad As TD_GRemServCargadasGTranspLiqPK) As List(Of TD_Obj_GRemServCargadasGTranspLiq)
            Return objDataAccessLayer.Listar_GRemServCargadasGTranspLiquidacion(objEntidad)
        End Function
        Public Function Listar_Estado_Operacion_Guia(pNOPRN As Decimal, pGuiaRem As Decimal) As DataTable
            Return objDataAccessLayer.Listar_Estado_Operacion_Guia(pNOPRN, pGuiaRem)
        End Function
        Public Function Listar_GRemServCargadasGTranspLiquidacion_Refactura(ByVal objEntidad As TD_GRemServCargadasGTranspLiqPK) As List(Of TD_Obj_GRemServCargadasGTranspLiq)
            Return objDataAccessLayer.Listar_GRemServCargadasGTranspLiquidacion_Refactura(objEntidad)
        End Function

        Public Function Listar_ServiciosPorDefectoPorCliente(ByVal objEntidad As TD_Qry_ServiciosFijosPorCliente) As DataTable
            Return objDataAccessLayer.Listar_ServiciosPorDefectoPorCliente(objEntidad)
        End Function

        Public Function Registrar_GuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_InfGRemCargada, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Registrar_GuiaRemisionLiqTransp(objEntidad, sErrorMesage)
        End Function

        'Public Function Registrar_GuiaRemisionLiqTransp_Reparto(ByVal objEntidad As TD_Obj_InfGRemCargada, ByRef sErrorMesage As String) As Boolean
        '  Return objDataAccessLayer.Registrar_GuiaRemisionLiqTransp_Reparto(objEntidad, sErrorMesage)
        'End Function

        Public Sub Registrar_LiquServGuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiq)
            objDataAccessLayer.Registrar_LiquServGuiaRemisionLiqTransp(objEntidad)
        End Sub

        'Public Function Registrar_LiquidacionGuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String) As Boolean
        '  Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista(objEntidad, sErrorMesage)
        'End Function
        Public Function Registrar_LiquidacionGuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As Int32
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista(objEntidad)
        End Function
        Public Function Registrar_LiquidacionGuiaTransportista_Reparto(ByVal objEntidad As Repartos, ByRef sErrorMesage As String) As Boolean 'Int32
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista_Reparto(objEntidad, sErrorMesage)
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_ViajeConsolidado(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista_ViajeConsolidado(objEntidad, sErrorMesage)
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_ViajeConsolidado2(ByVal objEntidad As TransporteConsolidado) As String 'As Boolean
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista_ViajeConsolidado2(objEntidad)
        End Function

        Public Function Eliminar_GRemCargadasGTranspLiquidacion(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK) As String
            Return objDataAccessLayer.Eliminar_GRemCargadasGTranspLiquidacion(oFiltro)
        End Function

        Public Sub Eliminar_LiquServGuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiqPK)
            objDataAccessLayer.Eliminar_LiquServGuiaRemisionLiqTransp(objEntidad)
        End Sub
        Public Function Eliminar_LiquServGuiaRemisionLiqTransp_Refactura(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiqPK, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Eliminar_LiquServGuiaRemisionLiqTransp_Refactura(objEntidad, sErrorMesage)
        End Function

        Public Function Agregar_GRemServCargadasGTranspLiq(ByVal objEntidad As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Agregar_GRemServCargadasGTranspLiq(objEntidad, sErrorMesage)
        End Function
        Public Function Agregar_GRemServCargadasGTranspLiq_Refactura(ByVal objEntidad As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Agregar_GRemServCargadasGTranspLiq_ReFactura(objEntidad, sErrorMesage)
        End Function

        Public Function Obtener_Guia_Remision(ByVal objEntidad As TD_GRemServCargadasGTranspLiqPK) As TD_Obj_InfGRemCargada
            Return objDataAccessLayer.Obtener_Guia_Remision(objEntidad)
        End Function

        Public Function Get_Guia_Remision(ByVal objEntidad As TD_GRemServCargadasGTranspLiqPK) As TD_Obj_InfGRemCargada
            Return objDataAccessLayer.Get_Guia_Remision(objEntidad)
        End Function

        '

        Public Function Modificar_GuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_InfGRemCargada, ByRef sErrorMensaje As String) As Boolean
            Return objDataAccessLayer.Modificar_GuiaRemisionLiqTransp(objEntidad, sErrorMensaje)
        End Function

        Public Function Listar_Consistencia_Bulto_x_Operacion(ByVal objEntidad As Solicitud_Transporte) As DataTable
            Return objDataAccessLayer.Listar_Consistencia_Bulto_x_Operacion(objEntidad)
        End Function

        Public Function Listar_Consistencia_Liquidacion_x_Orden_Servicio(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Return objDataAccessLayer.Listar_Consistencia_Liquidacion_x_Orden_Servicio(objParametro)
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Reparto(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Return objDataAccessLayer.Listar_Consistencia_Liquidacion_Servicio_Reparto(objParametro)
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Multimodal(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Return objDataAccessLayer.Listar_Consistencia_Liquidacion_Servicio_Multimodal(objParametro)
        End Function

        Public Function Existe_Guia_Remision_Anexo_Guia_Cliente(ByVal objParametro As Hashtable) As Int32
            Return objDataAccessLayer.Existe_Guia_Remision_Anexo_Guia_Cliente(objParametro)
        End Function

        Public Function Listar_Liquidacion_Flete(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Return objDataAccessLayer.Listar_Liquidacion_Flete(objParametro)
        End Function

        Public Function Listar_Operacion_x_Liquidacion_Flete(ByVal objParametro As Hashtable) As List(Of ClaseGeneral)
            Return objDataAccessLayer.Listar_Operacion_x_Liquidacion_Flete(objParametro)
        End Function

        Public Function Liquidacion_Flete_Enviar_SAP(ByVal objParametro As Hashtable) As Int64
            Return objDataAccessLayer.Liquidacion_Flete_Enviar_SAP(objParametro)
        End Function

        Public Function Lista_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Return objDataAccessLayer.Lista_Liquidacion_Flete_SAP(objParametro)
        End Function

        Public Function Procesar_Anulacion_CO_Tarifa_Interna(ByVal nroCO As Decimal, ByVal compania As String, ByVal TipoPeriodoAnulacion As String) As String
            Return objDataAccessLayer.Procesar_Anulacion_CO_Tarifa_Interna(nroCO, compania, TipoPeriodoAnulacion)
        End Function

        Public Function olisListarResponsables(ByVal PNCCLNT As Decimal, ByVal PSTIPPROC As String) As List(Of beDestinatario)
            Dim oEnvioEmailNotificacion As New DATOS.EnvioEmailNotificacion()
            Return oEnvioEmailNotificacion.DESTINATARIO_ENVIO_EMAIL_X_TIPO_PROCESO(PNCCLNT, PSTIPPROC)
        End Function

        Public Function Verificar_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As Int32
            Return objDataAccessLayer.Verificar_Liquidacion_Flete_SAP(objParametro)
        End Function

        Public Function Anular_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As String
            Return objDataAccessLayer.Anular_Liquidacion_Flete_SAP(objParametro)
        End Function

        Public Function Anular_Liquidacion_Flete_Propio(ByVal objParametro As Hashtable) As Int32
            Return objDataAccessLayer.Anular_Liquidacion_Flete_Propio(objParametro)
        End Function

        Public Function Eliminar_Liquidacion_Flete_SAP(ByVal objLista As List(Of LiquidacionOperacion), ByVal objParam As Hashtable) As Hashtable
            Dim objParametro As New Hashtable
            Dim hasResultado As New Hashtable
            Dim resultElimina As String = ""
            Dim error_ejecucion As String = ""
            Try
                For Each objEntidad As LiquidacionOperacion In objLista
                    objParametro = New Hashtable
                    If objEntidad.NRFSAP <> 0 Then
                        objParametro.Add("NRFSAP", objEntidad.NRFSAP)
                        objParametro.Add("NCRROP", objEntidad.NCRRRT)
                        objParametro.Add("FCHANU", Format(CType(objEntidad.FCHCRT_S, Date), "yyyyMMdd"))
                        objParametro.Add("FSTTRS", "")
                        resultElimina = Me.Anular_Liquidacion_Flete_SAP(objParametro)

                        If resultElimina <> "E" Then

                            Dim dt As New DataTable
                            Dim oParam As New Hashtable
                            oParam.Add("PSCCMPN", objParam("PSCCMPN"))
                            oParam.Add("PSCDVSN", objParam("PSCDVSN"))
                            oParam.Add("PNNLQDCN", objParam("PNNLQDCN"))
                            oParam.Add("PNNRFSAP", objEntidad.NRFSAP)
                            oParam.Add("PNNCRRLT", objEntidad.NCRRRT)
                            dt = Me.Listar_Liquidacion_Flete_SAP_info(oParam)

                            If dt.Rows.Count = 1 Then
                                Dim TSTERS As String = ("" & dt.Rows(0)("TSTERS")).ToString.Trim.ToUpper
                                If TSTERS = "EL PEDIDO " & objEntidad.NRFSAP & " SE ANULO CORRECTAMENTE" Then
                                    resultElimina = "E"
                                    'Me.Actualizar_Liquidacion_Flete_SAP_info(oParam)
                                    'dt = New DataTable
                                    'dt = Me.Listar_Liquidacion_Flete_SAP_info(oParam)
                                    'If dt.Rows.Count = 1 Then
                                    '    resultElimina = ("" & dt.Rows(0)("FSTTRS")).ToString.Trim
                                    'End If
                                End If
                            End If
                        End If
                        '  If Me.Anular_Liquidacion_Flete_SAP(objParametro) = "E" Then
                        'If resultElimina = "E" OrElse resultElimina = "EL PEDIDO " & objEntidad.NRFSAP & " SE ANULO CORRECTAMENTE" Then
                        If resultElimina = "E" Then
                            objParametro = New Hashtable
                            objParametro.Add("PSCCMPN", objParam("PSCCMPN"))
                            objParametro.Add("PSCDVSN", objParam("PSCDVSN"))
                            objParametro.Add("PNNLQDCN", objParam("PNNLQDCN"))
                            objParametro.Add("PNNRFSAP", objEntidad.NRFSAP)
                            objParametro.Add("PNNCRRLT", objEntidad.NCRRRT)
                            objDataAccessLayer.Eliminar_Liquidacion_Flete_SAP(objParametro)
                        End If
                    End If
                Next

                objParametro = New Hashtable
                objParametro.Add("PSCCMPN", objParam("PSCCMPN"))
                objParametro.Add("PSCDVSN", objParam("PSCDVSN"))
                objParametro.Add("PNNLQDCN", objParam("PNNLQDCN"))
                objParametro.Add("PSCULUSA", objParam("PSCULUSA"))
                objParametro.Add("PNFULTAC", objParam("PNFULTAC"))
                objParametro.Add("PNHULTAC", objParam("PNHULTAC"))
                objParametro.Add("PSNTRMNL", objParam("PSNTRMNL"))

                hasResultado = objDataAccessLayer.Actualizar_Liquidacion_Flete_SAP(objParametro)

            Catch ex As Exception
                hasResultado.Add("INTRESULT", 0)
                hasResultado.Add("STRRESULT", "")
            End Try
            Return hasResultado
        End Function
        '-ACD
        Public Function Lista_Bultos_x_Dia(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Lista_Bultos_x_Dia(objParametro)
        End Function

        Public Function Auditoria(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Auditoria(objEntidad)
        End Function

        Public Function Lista_Guia_Salida_Zona_GR(ByVal objEntidad As GuiaTransportista) As DataTable
            Return objDataAccessLayer.Lista_Guia_Salida_Zona_GR(objEntidad)
        End Function

        Public Function Lista_Movimiento_Bulto_Zona_GP(ByVal objEntidad As GuiaTransportista) As DataTable
            Return objDataAccessLayer.Lista_Movimiento_Bulto_Zona_GP(objEntidad)
        End Function

        Public Function Importar_Bulto_Guia_Remision(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Importar_Bulto_Guia_Remision(objEntidad)
        End Function

        Public Function Eliminar_Guia_Remision_Actualizacion(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Eliminar_Guia_Remision_Actualizacion(objEntidad)
        End Function

        Public Function Actualizar_Datos_Liquidacion_Flete_SAP(ByVal objParam As Hashtable) As Int16
            Return objDataAccessLayer.Actualizar_Datos_Liquidacion_Flete_SAP(objParam)
        End Function

        Public Function Listar_Pasajeros_x_Programacion(ByVal objEntidad As Hashtable) As List(Of Viaje_Ruta)
            Return objDataAccessLayer.Listar_Pasajeros_x_Programacion(objEntidad)
        End Function

        Public Function Listar_Pasajeros_Guia_Transporte(ByVal objEntidad As Hashtable) As List(Of Viaje_Ruta)
            Return objDataAccessLayer.Listar_Pasajeros_Guia_Transporte(objEntidad)
        End Function

        Public Function Registrar_Pasajero_Automatico(ByVal objEntidad As Viaje_Ruta) As Viaje_Ruta
            Return objDataAccessLayer.Registrar_Pasajero_Automatico(objEntidad)
        End Function

        Public Function Eliminar_Pasajero_Guia_Transporte(ByVal objEntidad As Viaje_Ruta) As Viaje_Ruta
            Return objDataAccessLayer.Eliminar_Pasajero_Guia_Transporte(objEntidad)
        End Function

        Public Function Listar_Guia_Transportista_Mercaderia(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Return objDataAccessLayer.Listar_Guia_Transportista_Mercaderia(objetoParametro)
        End Function

        Public Function Listar_Guia_Transportista_Pasajero(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Return objDataAccessLayer.Listar_Guia_Transportista_Pasajero(objetoParametro)
        End Function

        Public Function Listar_Operaciones_Liquidacion_Correo(ByVal objetoParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Operaciones_Liquidacion_Correo(objetoParametro)
        End Function

        Public Function Actualizar_Operaciones_Solicitudes(ByVal objetoHash As Hashtable) As Int16
            Return objDataAccessLayer.Actualizar_Operaciones_Guia_Transporte(objetoHash)
        End Function

        Public Function Listar_Operaciones_Guia_Transporte(ByVal objetoHash As Hashtable, ByRef intTipoViaje As Int16) As DataTable
            Return objDataAccessLayer.Listar_Operaciones_Guia_Transporte(objetoHash, intTipoViaje)
        End Function

        Public Function Validar_Operacion_Guia_Remision(ByVal objetoHash As Hashtable, ByRef intCMRCDR As Integer, ByRef strTCMRCD As String) As Int16
            Return objDataAccessLayer.Validar_Operacion_Guia_Remision(objetoHash, intCMRCDR, strTCMRCD)
        End Function
        Public Function Actualizar_Guia_Numero_Imagen(ByVal objetoHash As Hashtable) As Boolean
            Return objDataAccessLayer.Actualizar_Guia_Numero_Imagen(objetoHash)
        End Function
        Public Function Eliminar_Correlativo_Imagen(ByVal objetoHash As Hashtable) As Boolean
            Return objDataAccessLayer.Eliminar_Correlativo_Imagen(objetoHash)
        End Function

        Public Function Lista_Guia_Transporte_Consolidado(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Return objDataAccessLayer.Lista_Guia_Transporte_Consolidado(objetoParametro)
        End Function

        Public Function Listar_GRemCargadasGTranspLiquidacion_Consolidado(ByVal objEntidad As TransporteConsolidado) As List(Of TD_Obj_GRemCargadasGTranspLiq)
            Return objDataAccessLayer.Listar_GRemCargadasGTranspLiquidacion_Consolidado(objEntidad)
        End Function

        Public Function Eliminar_GRemCargadasGTranspLiquidacion_Consolidado(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMensaje As String) As Boolean
            Return objDataAccessLayer.Eliminar_GRemCargadasGTranspLiquidacion_Consolidado(objEntidad, sErrorMensaje)
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Consolidado(ByVal objParametro As Hashtable) As List(Of Factura_Transporte)
            Return objDataAccessLayer.Listar_Consistencia_Liquidacion_Servicio_Consolidado(objParametro)
        End Function

        Public Function Listar_Operaciones_X_Servicios_Importes(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Operaciones_X_Servicios_Importes(objParametro)
        End Function

        Public Function Actualizar_Operaciones_X_Servicios_Importes(ByVal objParametro As Hashtable) As Int32
            Return objDataAccessLayer.Actualizar_Operaciones_X_Servicios_Importes(objParametro)
        End Function

        Public Function Eliminar_Guia_Transportista_Reparto(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Eliminar_Guia_Transportista_Reparto(objEntidad)
        End Function

        Public Function Listar_Ruta_Optima_Reparto(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
            Return objDataAccessLayer.Listar_Ruta_Optima_Reparto(objEntidad)
        End Function

        Public Function Validar_GuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Validar_GuiaTransportista(objEntidad, sErrorMesage)
        End Function

        Public Function Validar_GuiaTransportista_Reparto(ByVal objEntidad As Repartos, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Validar_GuiaTransportista_Reparto(objEntidad, sErrorMesage)
        End Function

        Public Function Validar_GuiaTransportista_Reparto_ProVarios(ByVal objEntidad As Repartos, ByRef sErrorMesage As String, ByRef sErrorAlerta As String, ByRef msgAlertaValorRefer As String) As Boolean
            Return objDataAccessLayer.Validar_GuiaTransportista_Reparto_ProVarios(objEntidad, sErrorMesage, sErrorAlerta, msgAlertaValorRefer)
        End Function

        Public Sub Validar_Generacion_Reparto_Asiento_TarifaInterna(ByVal compania As String, ByVal nroReparto As String, ByRef sErrorMesage As String)
            objDataAccessLayer.Validar_Generacion_Reparto_Asiento_TarifaInterna(compania, nroReparto, sErrorMesage)
        End Sub

        Public Function Procesar_Generacion_Reparto_Asiento_TarifaInterna(ByVal objEntidad As Repartos, ByRef msgTarifaInterna As String) As Boolean
            Return objDataAccessLayer.Procesar_Generacion_Reparto_Asiento_TarifaInterna(objEntidad, msgTarifaInterna)
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_RepartoFlete(ByVal objEntidad As Repartos) As Int32
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista_RepartoFlete(objEntidad)
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_RepartoFlete_Prov_Varios(ByVal objEntidad As Repartos) As Int32
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista_RepartoFlete_Prov_Varios(objEntidad)
        End Function


        Public Function Validar_GuiaTransportista_ViajeConsolidado(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String, ByRef sErrorMesageAlerta As String) As Boolean
            Return objDataAccessLayer.Validar_GuiaTransportista_ViajeConsolidado(objEntidad, sErrorMesage, sErrorMesageAlerta)
        End Function

        Public Sub Validar_Generacion_Consolidado_AsientoCO_TarifaInterna(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String)
            objDataAccessLayer.Validar_Generacion_Consolidado_AsientoCO_TarifaInterna(objEntidad, sErrorMesage)
        End Sub

        Public Sub Procesar_Generacion_Consolidado_AsientoCO_TarifaInterna(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String)
            objDataAccessLayer.Procesar_Generacion_Consolidado_AsientoCO_TarifaInterna(objEntidad, sErrorMesage)
        End Sub

        Public Function Validar_CodMaterial_SAP_Alquiler(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As String
            Return objDataAccessLayer.Validar_CodMaterial_SAP_Alquiler(objEntidad)
        End Function

        Public Function Validar_CodMaterial_SAP(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As String
            Return objDataAccessLayer.Validar_CodMaterial_SAP(objEntidad)
        End Function

        Public Function Validar_CodMaterial_SAP_Prov_varios(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As String
            Return objDataAccessLayer.Validar_CodMaterial_SAP_Prov_varios(objEntidad)
        End Function

        Public Sub Validar_Asiento_CO_Tarifa_Interna(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String)
            objDataAccessLayer.Validar_Asiento_CO_Tarifa_Interna(objEntidad, sErrorMesage)
        End Sub

        Public Function Procesar_Asiento_CO_Tarifa_Interna(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef msgTarifaInterna As String) As String
            Return objDataAccessLayer.Procesar_Asiento_CO_Tarifa_Interna(objEntidad, msgTarifaInterna)
        End Function

        Public Function Listar_Liquidacion_Flete_SAP_info(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Liquidacion_Flete_SAP_info(objParametro)
        End Function

        Public Sub Actualizar_Liquidacion_Flete_SAP_info(ByVal objParametro As Hashtable)
            objDataAccessLayer.Actualizar_Liquidacion_Flete_SAP_info(objParametro)
        End Sub

        Public Function Registrar_LiquServGuiaRemisionLiqTranspAdi(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiq, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Registrar_LiquServGuiaRemisionLiqTranspAdi(objEntidad, sErrorMesage)
        End Function

        Public Sub Agregar_GRemServProCargadasGTranspLiq(ByVal objEntidad As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByRef NCRRGU As Decimal)
            objDataAccessLayer.Agregar_GRemServProCargadasGTranspLiq(objEntidad, NCRRGU)
        End Sub
        Public Function Validar_GuiaTransportista_ProvVarios(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String, ByRef sErrorMesageAlerta As String) As Boolean
            Return objDataAccessLayer.Validar_GuiaTransportista_ProvVarios(objEntidad, sErrorMesage, sErrorMesageAlerta)
        End Function
        Public Function Validar_GuiaTransportista_ProvAlquiler(ByVal CCMPN As String, ByVal IN_NRALQT As Decimal, ByVal IN_TIPO As Decimal, ByVal IN_MMCUSR As String, ByVal IN_NTRMNL As String, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Validar_GuiaTransportista_ProvAlquiler(CCMPN, IN_NRALQT, IN_TIPO, IN_MMCUSR, IN_NTRMNL, sErrorMesage)
        End Function

        Public Function Registrar_LiquidacionGuiaTransportistaProvVarios(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef msgError As String) As Int32
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportistaProvVarios(objEntidad, msgError)
        End Function
        Public Function Listar_Servicio_Guia_ProvVarios(ByVal CCMPN As String, ByVal NOPRCN As Decimal, ByVal NGUITR As Decimal) As DataTable
            Return objDataAccessLayer.Listar_Servicio_Guia_ProvVarios(CCMPN, NOPRCN, NGUITR)
        End Function
        Public Function Listar_Servicio_Guia_Prov_Validacion(ByVal CCMPN As String, ByVal NOPRCN As Decimal, ByVal NGUITR As Decimal) As DataSet
            Return objDataAccessLayer.Listar_Servicio_Guia_Prov_Validacion(CCMPN, NOPRCN, NGUITR)
        End Function
        Public Function Listar_Servicio_Guia_Reparto_Prov_Validacion(ByVal pCCMPN As String, ByVal IN_CDVSN As String, ByVal IN_NMOPRP As Decimal) As DataSet
            Return objDataAccessLayer.Listar_Servicio_Guia_Reparto_Prov_Validacion(pCCMPN, IN_CDVSN, IN_NMOPRP)
        End Function


        Public Function Listar_GRemServCargadasGTranspLiqVal(ByVal objEntidad As TD_GRemServCargadasGTranspLiqPK) As DataTable
            Return objDataAccessLayer.Listar_GRemServCargadasGTranspLiqVal(objEntidad)
        End Function

        Public Function Listar_GRemServCargadasGTranspRepartoLiqVal(ByVal CCMPN As String, ByVal CDVSN As String, ByVal IN_NMOPRP As Decimal) As DataTable
            Return objDataAccessLayer.Listar_GRemServCargadasGTranspRepartoLiqVal(CCMPN, CDVSN, IN_NMOPRP)
        End Function

        Public Function Listar_Asiento_CO_X_Operacion(ByVal nroOperacion As Decimal, ByVal nroGuia As Decimal, ByVal compania As String) As List(Of ENTIDADES.Consultas.AsientoCO)
            Return objDataAccessLayer.Listar_Asiento_CO_X_Operacion(nroOperacion, nroGuia, compania)
        End Function

        Public Function ObtenerNumeroCO(ByVal numero As Decimal, ByRef NumeroSAP As Decimal, ByVal compania As String) As Boolean
            Return objDataAccessLayer.ObtenerNumeroCO(numero, NumeroSAP, compania)
        End Function

        Public Function Listar_NumerosCO(ByVal parametros As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_NumerosCO(parametros)
        End Function

        Public Function Listar_AsientoDetalle_CO(ByVal nroTarifa As Decimal, ByVal compania As String) As List(Of ENTIDADES.Consultas.DetalleAsientoCO)
            Return objDataAccessLayer.Listar_AsientoDetalle_CO(nroTarifa, compania)
        End Function

        Public Function Listar_Liquidacion_Flete_Prov_Varios(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Return objDataAccessLayer.Listar_Liquidacion_Flete_Prov_Varios(objParametro)
        End Function

        Public Sub Anular_Liquidacion_Flete_Propio_Prov_Varios(ByVal objParametro As Hashtable)
            objDataAccessLayer.Anular_Liquidacion_Flete_Propio_Prov_Varios(objParametro)
        End Sub

        Public Function Eliminar_Liquidacion_Flete_SAP_Prov_Varios(ByVal objLista As List(Of LiquidacionOperacion), ByVal objParam As Hashtable, ByVal PeriodoAnulacion As String) As Hashtable
            Dim objParametro As New Hashtable
            Dim hasResultado As New Hashtable
            Dim resultElimina As String = ""
            'Try
            For Each objEntidad As LiquidacionOperacion In objLista
                objParametro = New Hashtable
                If objEntidad.NRFSAP <> 0 Then
                    objParametro.Add("NRFSAP", objEntidad.NRFSAP)
                    objParametro.Add("NCRROP", objEntidad.NCRRRT)
                    If PeriodoAnulacion = "02" Then

                        objParametro.Add("FCHANU", objEntidad.FechaActual)
                    Else
                        objParametro.Add("FCHANU", Format(CType(objEntidad.FCHCRT_S, Date), "yyyyMMdd"))
                    End If

                    '   objParametro.Add("FSTTRS", "")
                    objParametro.Add("STERSP", "")

                    resultElimina = Me.Anular_Liquidacion_Flete_SAP(objParametro)

                    'If resultElimina <> "E" Then

                    Dim dt As New DataTable
                    Dim oParam As New Hashtable
                    oParam.Add("PSCCMPN", objParam("PSCCMPN"))
                    oParam.Add("PSCDVSN", objParam("PSCDVSN"))
                    oParam.Add("PNNLQDCN", objParam("PNNLQDCN"))
                    oParam.Add("PNNRFSAP", objEntidad.NRFSAP)
                    oParam.Add("PNNCRRLT", objEntidad.NCRRRT)
                    dt = Me.Listar_Liquidacion_Flete_SAP_info(oParam)

                    If dt.Rows.Count = 1 Then
                        'Dim TSTERS As String = ("" & dt.Rows(0)("TSTERS")).ToString.Trim.ToUpper
                        'If TSTERS = "EL PEDIDO " & objEntidad.NRFSAP & " SE ANULO CORRECTAMENTE" Then
                        '    resultElimina = "E"
                        'End If 
                        resultElimina = ("" & dt.Rows(0)("STERSP")).ToString.Trim.ToUpper

                    End If
                    'End If

                    If resultElimina = "S" Then
                        objParametro = New Hashtable
                        objParametro.Add("PSCCMPN", objParam("PSCCMPN"))
                        objParametro.Add("PSCDVSN", objParam("PSCDVSN"))
                        objParametro.Add("PNNLQDCN", objParam("PNNLQDCN"))
                        objParametro.Add("PNNRFSAP", objEntidad.NRFSAP)
                        objParametro.Add("PNNCRRLT", objEntidad.NCRRRT)
                        objDataAccessLayer.Eliminar_Liquidacion_Flete_SAP(objParametro)
                    End If
                End If
            Next

            objParametro = New Hashtable
            objParametro.Add("PSCCMPN", objParam("PSCCMPN"))
            objParametro.Add("PSCDVSN", objParam("PSCDVSN"))
            objParametro.Add("PNNLQDCN", objParam("PNNLQDCN"))
            objParametro.Add("PSCULUSA", objParam("PSCULUSA"))
            objParametro.Add("PNFULTAC", objParam("PNFULTAC"))
            objParametro.Add("PNHULTAC", objParam("PNHULTAC"))
            objParametro.Add("PSNTRMNL", objParam("PSNTRMNL"))

            hasResultado = objDataAccessLayer.Actualizar_Liquidacion_Flete_SAP_Prov_Varios(objParametro)

            '===========CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
            '  freversion_provision_sap(objParametro)
            '===========CSR-HUNDRED-ESTIMACION-INGRESO-INICIO

            'Catch ex As Exception
            '    hasResultado.Add("INTRESULT", 0)
            '    hasResultado.Add("STRRESULT", ex.Message)
            'End Try
            Return hasResultado
        End Function

        Public Sub freversion_provision_sap(ByVal objParametro As Hashtable)
            'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
            Dim odt As DataTable

            odt = objDataAccessLayer.Estimacion_Ingreso_Revertir_ST(objParametro)

           
            If odt.Rows.Count > 0 Then

                Dim IdEstimacion As Double, AnioContaSap As Double, FechaDocCtaCte As Double
                Dim NroDocEstimacionSap As String, CodSociedadSap As String, NumDocElectronico As String

                Dim dt_url_servicio As New DataTable
                Dim oda_url_servicio As New NEGOCIO.UrlServicios_BLL
                dt_url_servicio = oda_url_servicio.Listar_Url_Servicio("SDESTSAPSALM", "", "", 0)
                Dim url_ws_servicio As String = ""
                If dt_url_servicio.Rows.Count > 0 Then
                    url_ws_servicio = ("" & dt_url_servicio.Rows(0)("URL")).ToString.Trim
                End If



                For index As Integer = 0 To odt.Rows.Count - 1
                    IdEstimacion = odt.Rows(index).Item("IDESTM")
                    NroDocEstimacionSap = odt.Rows(index).Item("NDESAP").ToString.Trim
                    CodSociedadSap = odt.Rows(index).Item("CSCDSP").ToString.Trim
                    AnioContaSap = odt.Rows(index).Item("ACNTSP")
                    NumDocElectronico = odt.Rows(index).Item("NDCCTE").ToString.Trim
                    FechaDocCtaCte = odt.Rows(index).Item("FDCFCC").ToString.Trim
                    'INI-ECM-ActualizacionTarifario[RF001]-160516
                    Dim wssalmon As New ws_reversion_Ingreso.ws_salmon
                    wssalmon.Url = url_ws_servicio
                    wssalmon.ws_reversion_ingreso(IdEstimacion, CodSociedadSap, NroDocEstimacionSap, AnioContaSap, NumDocElectronico, FechaDocCtaCte)
                    'FIN-ECM-ActualizacionTarifario[RF001]-160516
                Next
            End If
            'CSR-HUNDRED-ESTIMACION-INGRESO-FIN
        End Sub

        Public Function Lista_Servicio_X_Liquidacion_Flete(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Return objDataAccessLayer.Lista_Servicio_X_Liquidacion_Flete(objParametro)
        End Function

        Public Function Listar_Liquidaciones_Flete_X_Liquidacion(ByVal objParametro As Hashtable) As List(Of LiquidacionOperacion)
            Return objDataAccessLayer.Listar_Liquidaciones_Flete_X_Liquidacion(objParametro)
        End Function

        Public Function Listar_Datos_Operacion_Flete(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Datos_Operacion_Flete(objParametro)
        End Function

        Public Function Actualizar_Datos_Liquidacion_Flete_SAP_Prov_Varios(ByVal objParam As Hashtable) As Int16
            Return objDataAccessLayer.Actualizar_Datos_Liquidacion_Flete_SAP_Prov_varios(objParam)
        End Function

        Public Function Listar_servicios_liquidacion_servicios_sap(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_servicios_liquidacion_servicios_sap(objParametro)
        End Function
        Public Function Listar_servicios_liquidacion_sap_validacion(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_servicios_liquidacion_sap_validacion(objParametro)
        End Function
        Public Function Listar_Datos_Guia_Cargada(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Datos_Guia_Cargada(objParametro)
        End Function


        ' JMC   
        Public Function Validar_Diferencia(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByVal IN_NMOPRP As Decimal) As DataTable
            Return objDataAccessLayer.Validar_Diferencia(objEntidad, IN_NMOPRP)
        End Function

        Public Sub ACTUALIZAR_STATUS_ENVIO_APROBACION(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByVal NLBFLT As Decimal, ByVal IN_NMOPRP As Decimal)
            objDataAccessLayer.ACTUALIZAR_STATUS_ENVIO_APROBACION(objEntidad, NLBFLT, IN_NMOPRP)
        End Sub


        Public Sub ACTUALIZAR_STATUS_SEGUIMIENTO_APROBACION(ByVal obeAprobacionMargen As beAprobacionMargen)
            objDataAccessLayer.ACTUALIZAR_STATUS_SEGUIMIENTO_APROBACION(obeAprobacionMargen)
        End Sub


        'Mostrar Actualizacion Servici
        Public Function LISTAR_SERVICIOS_HISTORIAL_ACUTALIZACION(ByVal pCCMPN As String, ByVal NOPRCN As Decimal, ByVal NGUITR As Decimal, ByVal NCRRGU As Decimal) As DataTable
            Return objDataAccessLayer.LISTAR_SERVICIOS_HISTORIAL_ACUTALIZACION(pCCMPN, NOPRCN, NGUITR, NCRRGU)
        End Function

        Public Function lISTAR_SERVICIO_OPERACION_VALIDACION_LOG(ByVal pCCMPN As String, ByVal NOPRCN As Decimal, ByVal NGUITR As Decimal, ByVal NCRRGU As Decimal) As DataTable
            Return objDataAccessLayer.lISTAR_SERVICIO_OPERACION_VALIDACION_LOG(pCCMPN, NOPRCN, NGUITR, NCRRGU)
        End Function
        'Grabar LOG.
        Public Sub Grabar_Log_Servicio(ByVal objEntidad As TD_Obj_GRemAgregarServCargadasGTranspLiq, ByVal Obsr As String, ByVal Tipo As String)
            objDataAccessLayer.Grabar_Log_Servicio(objEntidad, Obsr, Tipo)
        End Sub

        'Public Sub APROBAR_MARGEN_X_OPERACION(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByVal PNNMOPRP As Decimal, ByVal PSFLGSTA As String)
        '    objDataAccessLayer.APROBAR_MARGEN_X_OPERACION(objEntidad, PNNMOPRP, PSFLGSTA)
        'End Sub

        'validar ususario 
        'Public Function VALIDAR_USUSARIO_APROBADOR(ByVal pCCMPN As String, ByVal pUsuario As String, Optional ByVal PSTIPO As String = "") As Boolean
        '    Return objDataAccessLayer.VALIDAR_USUSARIO_APROBADOR(pCCMPN, pUsuario, PSTIPO)
        'End Function

        'validar ususario combo box
        'Public Function LISTAR_ACCESO_DESTINO_APROBACION(ByVal pCCMPN As String, ByVal pUsuario As String) As DataTable
        '    Return objDataAccessLayer.LISTAR_ACCESO_DESTINO_APROBACION(pCCMPN, pUsuario)
        'End Function


        'nivel de aporbacion 
        Public Function LISTAR_AREA_RESPONSABLE_MARGEN(ByVal pCCMPN As String, ByVal pMargen As Decimal) As DataTable
            Return objDataAccessLayer.LISTAR_AREA_RESPONSABLE_MARGEN(pCCMPN, pMargen)
        End Function

        'carga _ ususario tipo 
        Public Function LISTAR_NIVELES_APROBACION(ByVal pCCMPN As String) As DataTable
            Return objDataAccessLayer.LISTAR_NIVELES_APROBACION(pCCMPN)
        End Function

        Public Function Listar_Seguimiento_Operacion_Margen(ByVal pCCMPN As String, ByVal NOPRCN As Decimal) As DataTable
            Return objDataAccessLayer.Listar_Seguimiento_Operacion_Margen(pCCMPN, NOPRCN)
        End Function

        Public Function Listar_Datos_Guia_Operacion(ByVal objParametro As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Datos_Guia_Operacion(objParametro)
        End Function

        Public Function ListaServiciosConsolidados(ByVal numConsolidado As Decimal, ByVal compania As String, ByVal division As String) As DataTable
            Return objDataAccessLayer.ListaServiciosConsolidados(numConsolidado, compania, division)
        End Function

        Public Function validarGeneracionDeOperacion(ByVal objParametro As Hashtable) As String
            Return objDataAccessLayer.validarGeneracionDeOperacion(objParametro)
        End Function

        Public Sub EnviarTarifaInternaSAP(ByVal pNCRDCO As String, ByVal pCCMPN As String)
            objDataAccessLayer.EnviarTarifaInternaSAP(pNCRDCO, pCCMPN)
        End Sub


        Public Sub RegistraEnvioRespuestaSwMilpo(ByVal objetoParametro As Hashtable)
            objDataAccessLayer.RegistraEnvioRespuestaSwMilpo(objetoParametro)
        End Sub

        Public Function Cargar_Envio_Despacho(ByVal PNCTRMNC As String, ByVal PNNGUITR As String, ByVal CCMPN As String) As DataSet
            Return objDataAccessLayer.Cargar_Envio_Despacho(PNCTRMNC, PNNGUITR, CCMPN)
        End Function

        Public Function OBTENER_INFO_GUIA_ENVIO_CLIENTE(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
            Return objDataAccessLayer.OBTENER_INFO_GUIA_ENVIO_CLIENTE(objetoParametro)
        End Function


        Public Function Lista_Acceso_Usuario_Periodo_Anulacion(ByVal IN_CCMPRN As String, ByVal PSCCMPN As String) As DataTable
            Return objDataAccessLayer.Lista_Acceso_Usuario_Periodo_Anulacion(IN_CCMPRN, PSCCMPN)
        End Function
        Public Function Obtener_Informacion_OS(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
            Return objDataAccessLayer.Obtener_Informacion_OS(objEntidad)
        End Function


        Public Function Get_Guia_Transportista(ByVal objetoParametro As Hashtable) As GuiaTransportista
            Return objDataAccessLayer.Get_Guia_Transportista(objetoParametro)
        End Function


        Public Function Validar_Margen_Operacion(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As DataSet
            Return objDataAccessLayer.Validar_Margen_Operacion(objEntidad)
        End Function

        Public Sub Enviar_Aprobar_Operacion(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision)
            objDataAccessLayer.Enviar_Aprobar_Operacion(objEntidad)
        End Sub

        Public Function Listar_Operacion_Pendiente_Aprobacion_MRG(ByVal objetoParametro As TD_Obj_LiquidacionGuiaRemision) As DataTable
            Return objDataAccessLayer.Listar_Operacion_Pendiente_Aprobacion_MRG(objetoParametro)
        End Function

        Public Function Listar_ServicioXViaje(ByVal objetoParametro As TD_obj_ListarServicioXViaje) As DataTable
            Return objDataAccessLayer.Listar_ServicioXViaje(objetoParametro)
        End Function
        'Public Function Actualizar_Status_Seguiniento_Aprobacion(ByVal objetoParametro As TD_obj_ActualizarStatusSeguinientoAprobacion) As Integer
        '    Return objDataAccessLayer.Actualizar_Status_Seguiniento_Aprobacion(objetoParametro)
        'End Function

        Public Function Listar_datos_Guia_por_Liquidar(ByVal objetoParametro As Hashtable) As GuiaTransportista
            Return objDataAccessLayer.Listar_datos_Guia_por_Liquidar(objetoParametro)
        End Function

        Public Sub Cancelar_Envio_Aprobacion_Viaje(ByVal objEntidad As TD_obj_ActualizarStatusSeguinientoAprobacion)
            objDataAccessLayer.Cancelar_Envio_Aprobacion_Viaje(objEntidad)
        End Sub

        Public Sub Aceptar_Envio_Aprobacion_Viaje(ByVal objEntidad As TD_obj_ActualizarStatusSeguinientoAprobacion)
            objDataAccessLayer.Aceptar_Envio_Aprobacion_Viaje(objEntidad)
        End Sub

        Public Function Obtener_Informacion_Recurso_Guia_Transporte(pCCMPN As String, pNoprcn As Decimal, pNCSOTR As Decimal, pNCRRSR As Decimal) As GuiaTransportista
            Return objDataAccessLayer.Obtener_Informacion_Recurso_Guia_Transporte(pCCMPN, pNoprcn, pNCSOTR, pNCRRSR)
        End Function


        'nuevo
        Public Function Lista_Historial_Liquidacion(ByVal objetoParametro As TD_obj_Historial_Liquidacion) As DataTable
            Return objDataAccessLayer.Lista_Historial_Liquidacion(objetoParametro)
        End Function

        Public Function Lista_Detalle_Liquidacion(ByVal objetoParametro As TD_obj_Detalle_Liquidacion) As DataTable
            Return objDataAccessLayer.Lista_Detalle_Liquidacion(objetoParametro)
        End Function
        Public Function Es_Operacion_Servicio_Flete(pCCMPN As String, pNOPRCN As Decimal) As Boolean
            Return objDataAccessLayer.Es_Operacion_Servicio_Flete(pCCMPN, pNOPRCN)
        End Function


        Public Function Listar_Peso_Neto_Guia_Transporte_Por_Almacen(ByVal objEntidad As GuiaTransportista, ByRef pesoGT As Decimal) As DataTable

            Return objDataAccessLayer.Listar_Peso_Neto_Guia_Transporte_Por_Almacen(objEntidad, pesoGT)

        End Function

        Public Function Actualizar_Peso_Neto_Guia_Transporte_Por_Almacen(ByVal objEntidad As GuiaTransportista) As DataTable

            Return objDataAccessLayer.Actualizar_Peso_Neto_Guia_Transporte_Por_Almacen(objEntidad)

        End Function

        Public Function Actualizar_Peso_Neto_Guia_Transporte_Anexas_Por_Almacen(ByVal objEntidad As GuiaTransportista) As DataTable

            Return objDataAccessLayer.Actualizar_Peso_Neto_Guia_Transporte_Anexas_Por_Almacen(objEntidad)

        End Function

       

    End Class
End Namespace
