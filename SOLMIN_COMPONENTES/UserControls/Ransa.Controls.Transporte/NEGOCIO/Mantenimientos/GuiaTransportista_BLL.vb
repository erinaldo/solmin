

Namespace mantenimientos
  Public Class GuiaTransportista_BLL

    Dim objDataAccessLayer As New GuiaTransportista_DAL

        Public Function Verificacion_Existencia_Operacion_Transporte(ByVal objEntidad As Operaciones.OperacionTransporte) As Operaciones.OperacionTransporte
            Return objDataAccessLayer.Verificacion_Existencia_Operacion_Transporte(objEntidad)
        End Function

    Public Function Obtener_Numero_Guia_Transporte(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Return objDataAccessLayer.Obtener_Numero_Guia_Transporte(objEntidad)
    End Function

    Public Function Obtener_Informacion_Orden_Servicio(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Return objDataAccessLayer.Obtener_Informacion_Orden_Servicio(objEntidad)
    End Function

    Public Function Listar_Guias_x_Transportista(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
      Try
        Return objDataAccessLayer.Listar_Guias_x_Transportista(objEntidad)
      Catch
        Return New List(Of GuiaTransportista)
      End Try
    End Function

    Public Function Listar_Guias_x_Transportista(ByVal objEntidad As Hashtable) As List(Of GuiaTransportista)
      Try
        Return objDataAccessLayer.Listar_Guias_x_Transportista(objEntidad)
      Catch
        Return New List(Of GuiaTransportista)
      End Try
    End Function

    Public Function Listar_Guias_x_Transportista_Proveedor(ByVal objEntidad As Hashtable) As List(Of GuiaTransportista)
      Try
        Return objDataAccessLayer.Listar_Guias_x_Transportista_Proveedor(objEntidad)
      Catch
        Return New List(Of GuiaTransportista)
      End Try
    End Function


    Public Function Listar_Guia_Transportista_Reparto(ByVal objetoParametro As Hashtable) As DataTable
      Try
        Return objDataAccessLayer.Listar_Guia_Transportista_Reparto(objetoParametro)
      Catch
        Return New DataTable
      End Try
    End Function

    Public Function Listar_Tractos_x_Planeamiento(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
      Try
        Return objDataAccessLayer.Listar_Tractos_x_Planeamiento(objEntidad)
      Catch
        Return New List(Of GuiaTransportista)
      End Try
    End Function

    Public Function Registrar_Guia_Transportista_Atugenerada(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Return objDataAccessLayer.Registrar_Guia_Transportista_Atugenerada(objEntidad)
    End Function

    Public Function Registrar_Guia_Transportista_Manual(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Return objDataAccessLayer.Registrar_Guia_Transportista_Manual(objEntidad)
    End Function

    Public Function Modificar_Guia_Transportista_Atugenerada(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Return objDataAccessLayer.Modificar_Guia_Transportista_Atugenerada(objEntidad)
    End Function

    Public Function Listar_Guia_Transportista(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
      Return objDataAccessLayer.Listar_Guia_Transportista(objetoParametro)
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

    Public Function Registrar_GuiasCliente_Manual(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Return objDataAccessLayer.Registrar_GuiasCliente_Manual(objEntidad)
    End Function

        Public Function Registrar_ManifiestoCarga(ByVal objEntidad As GuiaOCManifiestoCarga) As GuiaOCManifiestoCarga
            Return objDataAccessLayer.Registrar_ManifiestoCarga(objEntidad)
        End Function

    Public Function Registrar_GuiaTransportistaAdicional(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Return objDataAccessLayer.Registrar_GuiaTransportistaAdicional(objEntidad)
    End Function

        Public Function Agregar_Guia_Transportista_Adicional(ByVal objEntidad As Operaciones.Detalle_Solicitud_Transporte) As Operaciones.Detalle_Solicitud_Transporte
            Return objDataAccessLayer.Agregar_Guia_Transportista_Adicional(objEntidad)
        End Function

    Public Function Eliminar_GuiaTransportistaAdicional(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Return objDataAccessLayer.Eliminar_GuiaTransportistaAdicional(objEntidad)
    End Function

    Public Function Eliminar_GuiasCliente(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Return objDataAccessLayer.Eliminar_GuiasCliente(objEntidad)
    End Function

        Public Function Eliminar_ManifiestoCarga(ByVal objEntidad As GuiaOCManifiestoCarga) As GuiaOCManifiestoCarga
            Return objDataAccessLayer.Eliminar_ManifiestoCarga(objEntidad)
        End Function

        Public Function Eliminar_Orden_Compra(ByVal objEntidad As GuiaOCManifiestoCarga) As GuiaOCManifiestoCarga
            Return objDataAccessLayer.Eliminar_Orden_Compra(objEntidad)
        End Function

    Public Function Eliminar_Guia_Transportista(ByVal objEntidad As GuiaTransportista) As GuiaTransportista
      Return objDataAccessLayer.Eliminar_Guia_Transportista(objEntidad)
    End Function

        Public Function Listar_Ordenes_Compra_x_MC(ByVal objEntidad As GuiaOCManifiestoCarga) As List(Of GuiaOCManifiestoCarga)
            Return objDataAccessLayer.Listar_Ordenes_Compra_x_MC(objEntidad)
        End Function

    Public Function Listar_Guias_Anexas_Cliente(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
      Return objDataAccessLayer.Listar_Guias_Anexas_Cliente(objEntidad)
    End Function

    Public Function Listar_Guias_Anexas_Transportista(ByVal objEntidad As GuiaTransportista) As List(Of GuiaTransportista)
      Return objDataAccessLayer.Listar_Guias_Anexas_Transportista(objEntidad)
    End Function

        Public Function Listar_Solicitudes_Guia_Transportista(ByVal objetoParametro As Hashtable) As List(Of Operaciones.Detalle_Solicitud_Transporte)
            Return objDataAccessLayer.Listar_Solicitudes_Guia_Transportista(objetoParametro)
        End Function

    Public Function Listar_Guia_Remision_x_Operacion(ByVal objetoParametro As Hashtable) As List(Of GuiaTransportista)
      Return objDataAccessLayer.Listar_Guia_Remision_x_Operacion(objetoParametro)
    End Function

    Public Function Listar_Configuracion_Vehicular(ByVal strCompania As String) As List(Of ClaseGeneral)
      Return objDataAccessLayer.Listar_Configuracion_Vehicular(strCompania)
    End Function

    ' Liquidación de Fletes
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

    Public Function Registrar_LiquServGuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiq, ByRef sErrorMesage As String) As Boolean
      Return objDataAccessLayer.Registrar_LiquServGuiaRemisionLiqTransp(objEntidad, sErrorMesage)
    End Function

        'Public Function Registrar_LiquidacionGuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision, ByRef sErrorMesage As String) As Boolean
        '  Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista(objEntidad, sErrorMesage)
        'End Function
        Public Function Registrar_LiquidacionGuiaTransportista(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As Int32
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista(objEntidad)
        End Function
        Public Function Registrar_LiquidacionGuiaTransportista_Reparto(ByVal objEntidad As Operaciones.Repartos, ByRef sErrorMesage As String) As Boolean 'Int32
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista_Reparto(objEntidad, sErrorMesage)
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_ViajeConsolidado(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista_ViajeConsolidado(objEntidad, sErrorMesage)
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_ViajeConsolidado2(ByVal objEntidad As TransporteConsolidado) As Int32 'As Boolean
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista_ViajeConsolidado2(objEntidad)
        End Function

        Public Function Eliminar_GRemCargadasGTranspLiquidacion(ByVal oFiltro As TD_GRemServCargadasGTranspLiqPK, ByRef sErrorMensaje As String) As Boolean
            Return objDataAccessLayer.Eliminar_GRemCargadasGTranspLiquidacion(oFiltro, sErrorMensaje)
        End Function

        Public Function Eliminar_LiquServGuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_GRemLiquServCargadasGTranspLiqPK, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Eliminar_LiquServGuiaRemisionLiqTransp(objEntidad, sErrorMesage)
        End Function
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

        Public Function Modificar_GuiaRemisionLiqTransp(ByVal objEntidad As TD_Obj_InfGRemCargada, ByRef sErrorMensaje As String) As Boolean
            Return objDataAccessLayer.Modificar_GuiaRemisionLiqTransp(objEntidad, sErrorMensaje)
        End Function

        Public Function Listar_Consistencia_Bulto_x_Operacion(ByVal objEntidad As Operaciones.Solicitud_Transporte) As DataTable
            Return objDataAccessLayer.Listar_Consistencia_Bulto_x_Operacion(objEntidad)
        End Function

        Public Function Listar_Consistencia_Liquidacion_x_Orden_Servicio(ByVal objParametro As Hashtable) As List(Of Operaciones.Factura_Transporte)
            Return objDataAccessLayer.Listar_Consistencia_Liquidacion_x_Orden_Servicio(objParametro)
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Reparto(ByVal objParametro As Hashtable) As List(Of Operaciones.Factura_Transporte)
            Return objDataAccessLayer.Listar_Consistencia_Liquidacion_Servicio_Reparto(objParametro)
        End Function

        Public Function Listar_Consistencia_Liquidacion_Servicio_Multimodal(ByVal objParametro As Hashtable) As List(Of Operaciones.Factura_Transporte)
            Return objDataAccessLayer.Listar_Consistencia_Liquidacion_Servicio_Multimodal(objParametro)
        End Function

        Public Function Existe_Guia_Remision_Anexo_Guia_Cliente(ByVal objParametro As Hashtable) As Int32
            Return objDataAccessLayer.Existe_Guia_Remision_Anexo_Guia_Cliente(objParametro)
        End Function

        Public Function Listar_Liquidacion_Flete(ByVal objParametro As Hashtable) As List(Of Operaciones.LiquidacionOperacion)
            Return objDataAccessLayer.Listar_Liquidacion_Flete(objParametro)
        End Function

        Public Function Listar_Operacion_x_Liquidacion_Flete(ByVal objParametro As Hashtable) As List(Of ClaseGeneral)
            Return objDataAccessLayer.Listar_Operacion_x_Liquidacion_Flete(objParametro)
        End Function

        Public Function Liquidacion_Flete_Enviar_SAP(ByVal objParametro As Hashtable) As Int64
            Return objDataAccessLayer.Liquidacion_Flete_Enviar_SAP(objParametro)
        End Function

        Public Function Lista_Liquidacion_Flete_SAP(ByVal objParametro As Hashtable) As List(Of Operaciones.LiquidacionOperacion)
            Return objDataAccessLayer.Lista_Liquidacion_Flete_SAP(objParametro)
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

        Public Function Eliminar_Liquidacion_Flete_SAP(ByVal objLista As List(Of Operaciones.LiquidacionOperacion), ByVal objParam As Hashtable) As Hashtable
            Dim objParametro As New Hashtable
            Dim hasResultado As New Hashtable
            Try
                For Each objEntidad As Operaciones.LiquidacionOperacion In objLista
                    objParametro = New Hashtable
                    If objEntidad.NRFSAP <> 0 Then
                        objParametro.Add("NRFSAP", objEntidad.NRFSAP)
                        objParametro.Add("NCRROP", objEntidad.NCRRRT)
                        objParametro.Add("FCHANU", Format(CType(objEntidad.FCHCRT_S, Date), "yyyyMMdd"))
                        objParametro.Add("FSTTRS", "")
                        If Me.Anular_Liquidacion_Flete_SAP(objParametro) = "E" Then
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

        Public Function Listar_Consistencia_Liquidacion_Servicio_Consolidado(ByVal objParametro As Hashtable) As List(Of Operaciones.Factura_Transporte)
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

        Public Function Validar_GuiaTransportista_Reparto(ByVal objEntidad As Operaciones.Repartos, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Validar_GuiaTransportista_Reparto(objEntidad, sErrorMesage)
        End Function

        Public Function Registrar_LiquidacionGuiaTransportista_RepartoFlete(ByVal objEntidad As Operaciones.Repartos) As Int32
            Return objDataAccessLayer.Registrar_LiquidacionGuiaTransportista_RepartoFlete(objEntidad)
        End Function

        Public Function Validar_GuiaTransportista_ViajeConsolidado(ByVal objEntidad As TransporteConsolidado, ByRef sErrorMesage As String) As Boolean
            Return objDataAccessLayer.Validar_GuiaTransportista_ViajeConsolidado(objEntidad, sErrorMesage)
        End Function

        Public Function Validar_CodMaterial_SAP(ByVal objEntidad As TD_Obj_LiquidacionGuiaRemision) As String
            Return objDataAccessLayer.Validar_CodMaterial_SAP(objEntidad)
        End Function
    End Class
End Namespace