Imports RANSA.TYPEDEF
Imports RANSA.DATA.DespachoSAT
Imports System.Data
Imports Newtonsoft
Imports RestSharp
Imports Newtonsoft.Json.Serialization
Public Class br_Rest_Remision_Pacasmayo

    Public Function Enviar_Guia_Remision_Electronica_Pacasmayo_Rest(pCCLNT As Decimal, pNGUIRM As Decimal, pNGUIRS As String, pGrupo_Envio As String, get_SoloTrama As Boolean, ByRef Trama As String, ByRef CodRespuestaEmision As String) As String
        Dim odaGuiaRemision As New daGuiasRemision
        Dim dt_envio_gr As New DataTable
        Dim obeGuiaRemision As New beGuiaRemision
        obeGuiaRemision.PNCCLNT = pCCLNT
        obeGuiaRemision.PSNGUIRM = pNGUIRM
        obeGuiaRemision.PSNGUIRS = pNGUIRS
        Dim msg_validacion As String = ""
        Dim url_servicio As String = ""
        Dim usu_servicio As String = ""
        Dim psw_servicio As String = ""
        Dim ejecutar_envio As Boolean = True

        Try

            Dim dt_url As New DataTable
            dt_url = odaGuiaRemision.Listar_Url_Envio_Guia(obeGuiaRemision.PNCCLNT, pGrupo_Envio, "EMIS_GR")

            If dt_url.Rows.Count = 0 Then
                msg_validacion = "Url no configurada." & Chr(13)
            Else
                url_servicio = ("" & dt_url.Rows(0)("URL")).ToString.Trim
                usu_servicio = ("" & dt_url.Rows(0)("USUARIO")).ToString.Trim
                psw_servicio = ("" & dt_url.Rows(0)("USUARIO_PWS")).ToString.Trim

            End If
            If url_servicio = "" Then
                msg_validacion = msg_validacion & " Datos url/usurio/pws incompleto" & Chr(13)
            End If

            Dim ds_Datos_GR As New DataSet
            Dim dt_cab As New DataTable
            Dim dt_det As New DataTable

            ds_Datos_GR = odaGuiaRemision.Listar_Datos_GuiaTransito_Pacasmayo(pCCLNT, pNGUIRM, pNGUIRS)
            dt_cab = ds_Datos_GR.Tables(0).Copy
            dt_det = ds_Datos_GR.Tables(1).Copy

            If dt_cab.Rows.Count = 0 Then
                msg_validacion = msg_validacion & " Datos de cabecera no encontrado." & Chr(13)
            End If
            If dt_det.Rows.Count = 0 Then
                msg_validacion = msg_validacion & " Datos de detalle no encontrado." & Chr(13)
            End If

            If msg_validacion.Length > 0 Then
                msg_validacion = "GUIA: " & pNGUIRS & Chr(10) & msg_validacion
            End If

            Dim gr_cab_pacasmayo As New GR_JSON_PACASMAYO
            If msg_validacion = "" Then
                gr_cab_pacasmayo.indicador_serie = dt_cab.Rows(0).Item("TIPO")
                gr_cab_pacasmayo.numero_guia = dt_cab.Rows(0).Item("NGUIRS_F_AUTOMATICO")
                gr_cab_pacasmayo.fecha_contabilizacion = dt_cab.Rows(0).Item("FECHA_GR")
                gr_cab_pacasmayo.direccion_cliente = dt_cab.Rows(0).Item("DIRECC_CLIENTE")
                gr_cab_pacasmayo.fecha_inicio_traslado = dt_cab.Rows(0).Item("FECHA_TRASL")
                gr_cab_pacasmayo.ubigeo_partida = dt_cab.Rows(0).Item("UBIGEO_O")
                gr_cab_pacasmayo.direccion_punto_origen = dt_cab.Rows(0).Item("DIREC_O")
                gr_cab_pacasmayo.ubigeo_llegada = dt_cab.Rows(0).Item("UBIGEO_D")
                gr_cab_pacasmayo.direccion_punto_llegada = dt_cab.Rows(0).Item("DIREC_D")
                gr_cab_pacasmayo.ruc_transportista = dt_cab.Rows(0).Item("RUC_TRANSP")
                gr_cab_pacasmayo.ruc_cliente = dt_cab.Rows(0).Item("RUC_CLIENTE")
                gr_cab_pacasmayo.razon_social_transportista = dt_cab.Rows(0).Item("RSOCIAL_TRANSP")
                gr_cab_pacasmayo.brevete_chofer = dt_cab.Rows(0).Item("COND_BREVETE")
                gr_cab_pacasmayo.nombre_chofer = dt_cab.Rows(0).Item("COND_NOMBRE")
                gr_cab_pacasmayo.placa_vehicular = dt_cab.Rows(0).Item("VEH_PLACA")
                gr_cab_pacasmayo.placa_acoplado = dt_cab.Rows(0).Item("ACOP_PLACA")
                gr_cab_pacasmayo.placa_mtc = dt_cab.Rows(0).Item("VEH_MTC")
                gr_cab_pacasmayo.marca_vehicular = dt_cab.Rows(0).Item("VEH_MARCA")
                gr_cab_pacasmayo.peso_total = dt_cab.Rows(0).Item("PESO_GR")
                gr_cab_pacasmayo.observaciones = dt_cab.Rows(0).Item("OBS_GR")
                gr_cab_pacasmayo.motivo_traslado = dt_cab.Rows(0).Item("MOT_TRAS")
                gr_cab_pacasmayo.descripcion_motivo = dt_cab.Rows(0).Item("MOT_DESC")
                gr_cab_pacasmayo.modalidad_traslado = dt_cab.Rows(0).Item("MOD_TRANSP")
                gr_cab_pacasmayo.correo = dt_cab.Rows(0).Item("CORREO_EMISOR")
                gr_cab_pacasmayo.cantidad_bulto = dt_cab.Rows(0).Item("CANT_BULTOS_GR")
              
                Dim gr_list_det_pacasmayo As New List(Of lista_materiales)
                Dim gr_det_pacasmayo As lista_materiales
                For Each item As DataRow In dt_det.Rows
                    gr_det_pacasmayo = New lista_materiales

                    gr_det_pacasmayo.numero_documento_compra = item("NRO_OC")
                    gr_det_pacasmayo.posicion = item("NRO_ITEM")
                    gr_det_pacasmayo.descripcion_compra = item("DESC_OC")
                    gr_det_pacasmayo.descripcion_proveedor = item("DESC_PROV")
                    gr_det_pacasmayo.numero_bulto = item("NRO_BULTO")
                    gr_det_pacasmayo.descripcion_bulto = item("DESC_BULTO")
                    gr_det_pacasmayo.unidad_medida = item("UM_ITEM")
                    gr_det_pacasmayo.cantidad_entrega = item("CANT_ENTREGA")
                    gr_det_pacasmayo.cantidad_guia = item("CANT_BULTOS") ' cantidad bultos
                    gr_det_pacasmayo.guia_proveedor = item("NRO_GPROV")
                    gr_det_pacasmayo.numero_material = item("COD_MATERIAL")
                    gr_det_pacasmayo.descripcion_material = item("DESC_ITEM")
                    gr_det_pacasmayo.condicion = item("COND_IQBF")
                    gr_det_pacasmayo.clase_material = item("CLASE_MATERIAL")
                    gr_det_pacasmayo.numero_articulo_europeo = item("COD_SUNAT_UN")
                    gr_det_pacasmayo.peso_bulto = item("PESO_BULTO")
                    gr_det_pacasmayo.peso_item = item("PESO_ITEM")
                    gr_list_det_pacasmayo.Add(gr_det_pacasmayo)
                Next

                

                gr_cab_pacasmayo.lista_materiales = gr_list_det_pacasmayo

                Dim jsonData As String = Newtonsoft.Json.JsonConvert.SerializeObject(gr_cab_pacasmayo, Json.Formatting.Indented)


                Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(jsonData)
                jsonData = System.Text.Encoding.UTF8.GetString(bytes)


 


                Trama = jsonData
                If get_SoloTrama = False Then


                    Dim cod_respuesta As String = ""
                    Dim msg_respuesta As String = ""

                    'Dim api_rest As New API_REST
                    'Dim orespuesta As New Object
                    'Try
                    '    orespuesta = api_rest.Post(url_servicio, jsonData, usu_servicio, psw_servicio)
                    '    If orespuesta IsNot Nothing Then
                    '        cod_respuesta = orespuesta.Item("resultado").ToString.Trim
                    '        msg_respuesta = orespuesta.Item("mensaje_error").ToString.Trim

                    '        If cod_respuesta <> "1" Then
                    '            msg_validacion = msg_validacion & " Cod. Respuesta:" & cod_respuesta & Chr(13)
                    '            msg_validacion = msg_validacion & " Respuesta:" & msg_respuesta
                    '        End If
                    '    Else
                    '        'cod_respuesta = "E_RANSA"
                    '        cod_respuesta = "0"
                    '        msg_respuesta = "Sin respuesta servicio"
                    '        msg_validacion = "Sin respuesta servicio"
                    '    End If
                    'Catch ex As Exception
                    '    cod_respuesta = "0"
                    '    msg_respuesta = (msg_respuesta & Chr(10) & ex.Message).Trim
                    '    msg_validacion = (msg_respuesta & Chr(10) & ex.Message).Trim
                    'End Try

                    Dim respuestaWS As String = ""
                    Dim oProxyFileDOCAWS As New ProxyFileDOCAWS.WsFileManager
                    respuestaWS = oProxyFileDOCAWS.SendPostPacasmayoGuiaElectronica(url_servicio, jsonData, usu_servicio, psw_servicio)
                    cod_respuesta = respuestaWS.Split("|")(0).Trim
                    msg_respuesta = respuestaWS.Split("|")(1).Trim
                    If cod_respuesta <> "1" Then
                        msg_validacion = msg_respuesta
                    End If



                    If cod_respuesta = "1" Then
                        CodRespuestaEmision = "S"
                    Else
                        CodRespuestaEmision = "E"
                    End If
                    Dim usu_reg As String = RANSA.NEGO.slnSOLMIN.clsSeguridad.Usuario
                    odaGuiaRemision.fintActualizarEstadoEnvioGuias(obeGuiaRemision, cod_respuesta, msg_respuesta, usu_reg, "EMISION_GR")

                End If

            End If

        Catch ex As Exception
            msg_validacion = (msg_validacion & Chr(10) & ex.Message).Trim
        End Try

        Return msg_validacion.Trim

    End Function


    Public Function Anular_Guia_Remision_Electronica_Pacasmayo_Rest(pCCLNT As Decimal, pNGUIRM As Decimal, pNGUIRS As String, pGrupo_Envio As String, get_SoloTrama As Boolean, ByRef Trama As String, ByRef Respuesta As String) As String
        Dim odaGuiaRemision As New daGuiasRemision
        Dim dt_envio_gr As New DataTable
        Dim obeGuiaRemision As New beGuiaRemision
        obeGuiaRemision.PNCCLNT = pCCLNT
        obeGuiaRemision.PSNGUIRM = pNGUIRM
        obeGuiaRemision.PSNGUIRS = pNGUIRS
        Dim msg_validacion As String = ""
        Dim url_servicio As String = ""
        Dim usu_servicio As String = ""
        Dim psw_servicio As String = ""
        Dim ejecutar_envio As Boolean = True

        Try

            Dim dt_url As New DataTable
            dt_url = odaGuiaRemision.Listar_Url_Envio_Guia(obeGuiaRemision.PNCCLNT, pGrupo_Envio, "ANUL_GR")

            If dt_url.Rows.Count = 0 Then
                msg_validacion = "Url no configurada." & Chr(13)
            Else
                url_servicio = ("" & dt_url.Rows(0)("URL")).ToString.Trim
                usu_servicio = ("" & dt_url.Rows(0)("USUARIO")).ToString.Trim
                psw_servicio = ("" & dt_url.Rows(0)("USUARIO_PWS")).ToString.Trim

            End If
            If url_servicio = "" Then
                msg_validacion = msg_validacion & " Datos url/usurio/pws incompleto" & Chr(13)
            End If


            Dim dt_cab As New DataTable

            If msg_validacion = "" Then



                dt_cab = odaGuiaRemision.Listar_GuiaTransito_Pacasmayo_Anulacion(pCCLNT, pNGUIRM, pNGUIRS)


                If dt_cab.Rows.Count = 0 Then
                    msg_validacion = msg_validacion & " Datos de cabecera no encontrado." & Chr(13)
                End If
                If msg_validacion.Length > 0 Then
                    msg_validacion = "GUIA: " & pNGUIRS & Chr(10) & msg_validacion
                End If

                Dim gr_cab_pacasmayo As New anulacion_guia_remision
                If msg_validacion = "" Then
                    gr_cab_pacasmayo.numero_guia = dt_cab.Rows(0).Item("NGUIRS")
                    gr_cab_pacasmayo.tipo_documento = dt_cab.Rows(0).Item("COD_DOC")
                    gr_cab_pacasmayo.ruc_empresa_emisora = dt_cab.Rows(0).Item("RUC_EMISORA")
                    gr_cab_pacasmayo.motivo = dt_cab.Rows(0).Item("MOTIVO")

                    Dim jsonData As String = Newtonsoft.Json.JsonConvert.SerializeObject(gr_cab_pacasmayo, Json.Formatting.Indented)

                    Trama = jsonData
                    If get_SoloTrama = False Then


                        Dim cod_respuesta As String = ""
                        Dim msg_respuesta As String = ""


                        'Dim orespuesta As New Object
                        'Dim api_rest As New API_REST
                        'Try
                        '    orespuesta = api_rest.Post(url_servicio, jsonData, usu_servicio, psw_servicio)
                        '    If orespuesta IsNot Nothing Then
                        '        cod_respuesta = orespuesta.Item("resultado").ToString.Trim
                        '        msg_respuesta = orespuesta.Item("mensaje_error").ToString.Trim

                        '        If cod_respuesta <> "1" Then
                        '            msg_validacion = msg_validacion & " Cod. Respuesta:" & cod_respuesta & Chr(13)
                        '            msg_validacion = msg_validacion & " Respuesta:" & msg_respuesta
                        '        End If
                        '    Else
                        '        'cod_respuesta = "E_RANSA"
                        '        cod_respuesta = "0"
                        '        msg_respuesta = "Sin respuesta servicio"
                        '        msg_validacion = "Sin respuesta servicio"
                        '    End If
                        'Catch ex As Exception
                        '    msg_respuesta = (msg_respuesta & Chr(10) & ex.Message).Trim
                        '    cod_respuesta = "0"
                        'End Try

                        Dim respuestaWS As String = ""
                        Dim oProxyFileDOCAWS As New ProxyFileDOCAWS.WsFileManager
                        respuestaWS = oProxyFileDOCAWS.SendPostPacasmayoGuiaElectronica(url_servicio, jsonData, usu_servicio, psw_servicio)
                        cod_respuesta = respuestaWS.Split("|")(0)
                        msg_respuesta = respuestaWS.Split("|")(1)
                        If cod_respuesta <> "1" Then
                            msg_validacion = msg_respuesta
                        End If


                        If cod_respuesta = "1" Then
                            Respuesta = "S"
                        Else
                            Respuesta = "E"
                        End If
                        Dim usu_reg As String = RANSA.NEGO.slnSOLMIN.clsSeguridad.Usuario
                        odaGuiaRemision.fintActualizarEstadoEnvioGuias(obeGuiaRemision, cod_respuesta, msg_respuesta, usu_reg, "ANULACION_GR")

                    End If

                End If

            End If

        Catch ex As Exception
            msg_validacion = (msg_validacion & Chr(10) & ex.Message).Trim
        End Try

        Return msg_validacion.Trim

    End Function


End Class
