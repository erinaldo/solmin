Imports RANSA.NEGO.slnSOLMIN_SDSW
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDSW
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDSW.Reportes
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDSW.Procesos
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW.Reportes.Generador

'Imports RANSA.NEGO.slnSOLMIN_SDS

Module mRecepcionSDSW
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para Filtros -'
    '----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    Public Function mfdtListar_ContratosVigentes_SDSW(ByVal strCliente As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        If Compania_Usuario = "LZ" Or Compania_Usuario = "AM" Then
            dtResultado = clsRecepcion.fdtListar_ContratosVigentesW(strCliente, strMensajeError)
        Else
            dtResultado = clsRecepcion.fdtListar_SDSWContratosVigentes(strCliente, strMensajeError)
        End If
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Detalle de la Información -'
    '--------------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento para Obtener Información  -'
    '-------------------------------------------'
    Public Function mfblnObtener_InfUltimoAlmacenSegunOS_SDSW(ByVal strNroOS As String, ByVal strServicio As String, _
                                                         ByRef TipoAlmacen As String, ByRef DescripcionTipoAlmacen As String, _
                                                         ByRef Almacen As String, ByRef DescripcionAlmacen As String) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim dtEntidad As DataTable = clsRecepcion.fdtObtener_SDSWInfUltimoAlmacenSegunOS(strNroOS, strServicio, strMensajeError)

        If strMensajeError <> "" Then
            DescripcionTipoAlmacen = ""
            TipoAlmacen = ""
            DescripcionAlmacen = ""
            Almacen = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                DescripcionTipoAlmacen = dtEntidad.Rows(0).Item("TALMC").ToString.Trim
                TipoAlmacen = dtEntidad.Rows(0).Item("CTPALM").ToString.Trim
                DescripcionAlmacen = dtEntidad.Rows(0).Item("TCMPAL").ToString.Trim
                Almacen = dtEntidad.Rows(0).Item("CALMC").ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                DescripcionTipoAlmacen = ""
                TipoAlmacen = ""
                DescripcionAlmacen = ""
                Almacen = ""
                blnResultado = False
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnObtener_InfUltimoAlmacenSegunCliente_SDSW(ByVal intCliente As Int64, ByRef TipoAlmacen As String, ByRef DescripcionTipoAlmacen As String, _
                                                              ByRef Almacen As String, ByRef DescripcionAlmacen As String) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim dtEntidad As DataTable = clsRecepcion.fdtObtener_SDSWInfUltimoAlmacenSegunCliente(intCliente, strMensajeError)

        If strMensajeError <> "" Then
            DescripcionTipoAlmacen = ""
            TipoAlmacen = ""
            DescripcionAlmacen = ""
            Almacen = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Obtener:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                DescripcionTipoAlmacen = dtEntidad.Rows(0).Item("TALMC").ToString.Trim
                TipoAlmacen = dtEntidad.Rows(0).Item("CTPALM").ToString.Trim
                DescripcionAlmacen = dtEntidad.Rows(0).Item("TCMPAL").ToString.Trim
                Almacen = dtEntidad.Rows(0).Item("CALMC").ToString.Trim
                ' Marcamos como exitoso el proceso
                blnResultado = True
            Else
                DescripcionTipoAlmacen = ""
                TipoAlmacen = ""
                DescripcionAlmacen = ""
                Almacen = ""
                blnResultado = False
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Obtener Información por Defecto -'
    '----------------------------------------------------'
    Public Function mfstrDefecto_ServicioRecepcion_SDSW(ByVal strCompania As String, ByVal strDivision As String, ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        ' Busco la relación de los Motivos de Traslado
        dtEntidad = clsRecepcion.fdtDefecto_SDSWServicioRecepcion(strCompania, strDivision, strMensajeError)

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        ' Evaluamos si trajo mas de una fila
        If dtEntidad.Rows.Count > 0 Then
            strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
            strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
            blnResultado = True
        Else
            strCodigo = "0"
            strDetalle = ""
            blnResultado = False
            MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfstrDefecto_TipoMovimientoRecepcion_SDSW(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsRecepcion.fdtDefecto_SDSWTipoMovimientoRecepcion(strMensajeError)

        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        ' Evaluamos si trajo mas de una fila
        If dtEntidad.Rows.Count > 0 Then
            strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
            strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
            blnResultado = True
        Else
            strCodigo = ""
            strDetalle = ""
            blnResultado = False
            MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Existencia -'
    '-------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Gestión de la Información -'
    '-----------------------------'
    Public Function mfblnRecepcion_Mercaderia_SDSW(ByVal objMovimientoMercaderia As clsSDSWMovimientoMercaderia) As Boolean
        '--------------------------
        '-- Variables de Trabajo --
        '--------------------------
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim intNroGuiaRansa As Int64 = 0

        '----------------------------------
        '-- Generando Información Básica --
        '----------------------------------
        If Not mfblnObtener_SDSWNroGuiaRansa(1, 1, True, intNroGuiaRansa) Then
            ' Si se presentó algún error en la generación de la Guía de Ransa, se culmina con el proceso
            MessageBox.Show("Error generando el Nro de la Guía de Ransa.", "Error Nro. Ransa:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultado = False
        Else
            '--------------------------
            '-- Proceso de Inserción --
            '--------------------------
            Dim objRecepcion As clsRecepcion = New clsRecepcion(objSeguridadBN.pUsuario)
            If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
                objRecepcion.fblnRecepcion_SDSWMercaderia(strMensajeError, intNroGuiaRansa, objMovimientoMercaderia, GLOBAL_PCUSUARIO)
            Else
                objRecepcion.fblnRecepcion_SDSMercaderia(strMensajeError, intNroGuiaRansa, objMovimientoMercaderia, GLOBAL_PCUSUARIO)
            End If

            '---------------------------
            '-- Visualizar el Reporte --
            '---------------------------
            If strMensajeError <> "" Or Not blnResultado Then
                MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Agregado para Almaceneras 
                ' Visualiza Guia
                If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
                    Dim objFiltro As Reportes.clsFiltros_SDSWReporteGuiaRecepcion = New Reportes.clsFiltros_SDSWReporteGuiaRecepcion
                    With objFiltro
                        .pintCodigoCliente_CCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                        .pstrRazonSocialCliente_TCMPCL = objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL
                        .pstrRazonSocialEmpresa = IIf(Compania_Usuario = "AM", "ALMACENERA DEL PERU", "COMPANIA ALMACENERA")
                        .pintNroGuiaRansa_NGUIRN = intNroGuiaRansa
                    End With
                    Call mpObtenerGuiaRecepcionSDSW(objFiltro)

                Else
                    'Dim objFiltro As clsFiltros_ReporteGuiaRecepcion = New clsFiltros_ReporteGuiaRecepcion
                    'With objFiltro
                    '    .pintCodigoCliente_CCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                    '    .pstrRazonSocialCliente_TCMPCL = objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL
                    '    .pstrRazonSocialEmpresa = GLOBAL_EMRESA
                    '    .pintNroGuiaRansa_NGUIRN = intNroGuiaRansa
                    'End With
                    'Call mReporteRecepcionSDSW.mpObtenerGuiaRecepcionSDSW(objFiltro)
                End If
            End If
        End If
        Return blnResultado
    End Function
    Public Function mfblnExiste_RubroTicket_SDSW(ByVal Compania As String, ByVal Division As String, _
                                            ByVal cliente As String, ByVal objMovimientoTicket As clsSDSWMovimientoTicket, _
                                            ByVal blnMsgSiNoExiste As Boolean) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        'Verifica si el Cliente tiene Tarifa
        For Each objItemticket As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
            blnResultado = False
            With objMovimientoTicket
                blnResultado = clsRecepcion.fblnExiste_SDSWTarifaRubro(strMensajeError, Compania, Division, cliente, objItemticket)
            End With
            If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If blnResultado = False Then
                MessageBox.Show("El Codigo de Servicio " & objItemticket.pstrTipoServicio_CSRVNV & " no tiene tarifa " & vbNewLine & _
                                     "en el Sistema.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return blnResultado
            End If
        Next
        'Verifica si existe IGV para el Rubro
        If blnResultado = True Then
            For Each objItemticket As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
                blnResultado = False
                With objMovimientoTicket
                    blnResultado = clsRecepcion.fblnExiste_SDSWRubroIGV(strMensajeError, Compania, Division, objItemticket)
                End With
                If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If blnResultado = False Then
                    MessageBox.Show("El Codigo de Servicio " & objItemticket.pstrTipoServicio_CSRVNV & " no tiene igv " & vbNewLine & _
                                         "en el Sistema.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return blnResultado
                End If
            Next
        End If

        If blnResultado = True Then
            Return blnResultado
        End If

    End Function

    Public Function mfblnRecepcion_Ticket_SDSW(ByVal objMovimientoTicket As clsSDSWMovimientoTicket) As Boolean
        Dim strMensajeError As String = ""
        'Dim blnResultado As Boolean = True

        Dim objRecepcion As clsRecepcion = New clsRecepcion(objSeguridadBN.pUsuario)
        If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
            objRecepcion.fblnOrdenIngreso_SDSWTicket(strMensajeError, objMovimientoTicket)
        End If
        frmSDSWRecepcionSDS.refresca()

        If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
            Dim objParametroTicket As clsFiltros_ReporteTicket = New clsFiltros_ReporteTicket
            For Each objItemticket As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
                With objParametroTicket
                    .pstrCompania = Compania_Usuario
                    ' .pintOrdenServicio_NORDSR = objItemticket.pintOrdenServicio_NORDSR
                    .pintNumControlTicket_NROTCK = frmSDSWRecepcionSDS.dgNroTicket.CurrentRow.Cells("ticket").Value
                End With
            Next
            Call mpObtenerTicketRecepcionW(objParametroTicket)
        End If
    End Function
    'Agregado para Almaceneras
    Public Function mfblnOrdenServicio_Ticket_SDSW(ByVal objMovimientoTicket As clsSDSWMovimientoTicket) As Boolean
        Dim strMensajeError As String = ""
        'Dim blnResultado As Boolean = True
        Dim objRecepcion As clsRecepcion = New clsRecepcion(objSeguridadBN.pUsuario)
        If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
            objRecepcion.fblnOrdenIngreso_SDSWTicket(strMensajeError, objMovimientoTicket)
        End If
    End Function
    'Agregado para Almaceneras
    Public Function mfblnPreFactura_Ticket_SDSW(ByVal objMovimientoTicket As clsSDSWMovimientoTicket, ByVal Compania As String, ByVal Division As String) As Boolean
        Dim strMensajeError As String = ""
        'Dim blnResultado As Boolean = True

        Dim objRecepcion As clsRecepcion = New clsRecepcion(objSeguridadBN.pUsuario)
        If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
            objRecepcion.fblnPreFactura_SDSWTicket(strMensajeError, objMovimientoTicket, Compania, Division)
        End If
    End Function
End Module
