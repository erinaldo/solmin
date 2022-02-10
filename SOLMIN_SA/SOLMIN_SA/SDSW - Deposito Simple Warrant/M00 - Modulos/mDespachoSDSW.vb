Imports RANSA.NEGO.slnSOLMIN_SDSW
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW.Reportes
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW.Procesos
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW.Reportes.Generador
Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO

Module mDespachoSDSW
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para Filtros -'
    '----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    Public Function mfdtListar_GuiasRANSA_SDSW(ByVal objFiltro As clsFiltros_ListarGuiasRansaDS) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsDespacho.fdtListar_GuiasRANSA(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function

    Public Function mfdtListar_GuiasREMISION_SDSW(ByVal objFiltro As clsFiltros_ListarGuiasRemisionDS) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsDespacho.fdtListar_GuiasRemision(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function

    Public Function mfdtListar_StockMercaderias_SDSW(ByVal objFiltro As clsFiltro_SDSWListarMercaderia) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsDespacho.fdtListar_StockMercaderias(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_StockMercaderiasPorAlmacen_SDSW(ByVal intOrdenServicio As Int64) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsDespacho.fdtListar_StockMercaderiasPorAlmacen(intOrdenServicio, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    ' Agregado para Almaceneras
    Public Function mfdtListar_AutorizacionesPorServicioContato_SDSW(ByVal intOrdenServicio As Int64, ByVal intContrato As Int64, ByVal strTipo As String) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsDespacho.fdtListar_AutorizacionPorServicioContrato(intOrdenServicio, intContrato, strTipo, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Public Function mfstrDefecto_ServicioDespacho_SDSW(ByVal strCompania As String, ByVal strDivision As String, ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        'Dim dtEntidad As DataTable = Nothing
        'Dim strMensajeError As String = ""
        'Dim blnResultado As Boolean = False
        '' Busco la relación de los Motivos de Traslado
        'dtEntidad = clsDespacho.fdtDefecto_ServicioDespacho(strCompania, strDivision, strMensajeError)

        'If strMensajeError <> "" Then
        '    MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Function
        'End If

        '' Evaluamos si trajo mas de una fila
        'If dtEntidad.Rows.Count > 0 Then
        '    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
        '    strDetalle = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
        '    blnResultado = True
        'Else
        '    strCodigo = "0"
        '    strDetalle = ""
        '    blnResultado = False
        '    MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        'dtEntidad.Dispose()
        'dtEntidad = Nothing
        'Return blnResultado
        strCodigo = "2"
        strDetalle = "Despacho"
        Return True
    End Function

    Public Function mfstrDefecto_TipoMovimientoDespacho_SDSW(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        dtEntidad = clsDespacho.fdtDefecto_TipoMovimientoDespacho(strMensajeError)

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
    Public Function mfblnDespacho_Mercaderia_SDSW(ByVal objMovimientoMercaderia As clsSDSWMovimientoMercaderia) As Boolean
        '--------------------------
        '-- Variables de Trabajo --
        '--------------------------
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim intNroGuiaRansa As Int64 = 0

        '----------------------------------
        '-- Generando Información Básica --
        '----------------------------------
        If Not mfblnObtener_SDSWNroGuiaRansa(2, 1, True, intNroGuiaRansa) Then
            ' Si se presentó algún error en la generación de la Guía de Ransa, se culmina con el proceso
            MessageBox.Show("Error generando el Nro de la Guía de Ransa.", "Error Nro. Ransa:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultado = False
        Else
            '--------------------------
            '-- Proceso de Inserción --
            '--------------------------
            Dim objDespacho As clsDespacho = New clsDespacho(objSeguridadBN.pUsuario)
            objDespacho.fblnDespacho_Mercaderia(strMensajeError, intNroGuiaRansa, objMovimientoMercaderia, GLOBAL_PCUSUARIO)
            '---------------------------
            '-- Visualizar el Reporte --
            '---------------------------
            If strMensajeError <> "" Or Not blnResultado Then
                MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim objFiltro As clsFiltros_ReporteGuiaDespacho = New clsFiltros_ReporteGuiaDespacho
                With objFiltro
                    .pintCodigoCliente_CCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                    .pstrRazonSocialCliente_TCMPCL = objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL
                    .pstrRazonSocialEmpresa = GLOBAL_EMRESA
                    .pintNroGuiaRansa_NGUIRN = intNroGuiaRansa
                End With
                Call mpObtenerGuiaDespachoSDSW(objFiltro)
            End If
        End If
        Return blnResultado
    End Function

    'Agregado para Almaceneras
    Public Function mfblnDespacho_Mercaderia_AutorizacionWarrant_SDSW(ByVal objMovimientoMercaderia As clsSDSWMovimientoMercaderia) As Boolean
        '--------------------------
        '-- Variables de Trabajo --
        '--------------------------
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim intNroGuiaRansa As Int64 = 0

        '----------------------------------
        '-- Generando Información Básica --
        '----------------------------------
        If Not mfblnObtener_SDSWNroGuiaRansa(2, 1, True, intNroGuiaRansa) Then
            ' Si se presentó algún error en la generación de la Guía de Ransa, se culmina con el proceso
            MessageBox.Show("Error generando el Nro de la Guía de Ransa.", "Error Nro. Ransa:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultado = False
        Else
            '--------------------------
            '-- Proceso de Inserción --
            '--------------------------
            Dim objDespacho As clsDespacho = New clsDespacho(objSeguridadBN.pUsuario)
            objDespacho.fblnDespacho_Mercaderia_AutorizacionWarrant(strMensajeError, intNroGuiaRansa, objMovimientoMercaderia, GLOBAL_PCUSUARIO)
        End If
        Return blnResultado
    End Function

    ' Agregado para Almaceneras

    Public Function mfblnDespacho_Mercaderia_Autorizacion_SDSW(ByVal objMovimientoMercaderia As clsSDSWMovimientoMercaderia) As Boolean
        '--------------------------
        '-- Variables de Trabajo --
        '--------------------------
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        Dim intNroGuiaRansa As Int64 = 0

        '----------------------------------
        '-- Generando Información Básica --
        '----------------------------------
        If Not mfblnObtener_SDSWNroGuiaRansa(2, 1, True, intNroGuiaRansa) Then
            ' Si se presentó algún error en la generación de la Guía de Ransa, se culmina con el proceso
            MessageBox.Show("Error generando el Nro de la Guía de Ransa.", "Error Nro. Ransa:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultado = False
        Else
            '--------------------------
            '-- Proceso de Inserción --
            '--------------------------
            Dim objDespacho As clsDespacho = New clsDespacho(objSeguridadBN.pUsuario)
            objDespacho.fblnDespacho_Mercaderia_Autorizacion(strMensajeError, intNroGuiaRansa, objMovimientoMercaderia, GLOBAL_PCUSUARIO)

            '---------------------------
            '-- Visualizar el Reporte --
            '---------------------------
            '    If strMensajeError <> "" Or Not blnResultado Then
            '        MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Else
            '        Dim objFiltro As clsFiltros_ReporteGuiaDespacho = New clsFiltros_ReporteGuiaDespacho
            '        With objFiltro
            '            .pintCodigoCliente_CCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
            '            .pstrRazonSocialCliente_TCMPCL = objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL
            '            .pstrRazonSocialEmpresa = GLOBAL_EMRESA
            '            .pintNroGuiaRansa_NGUIRN = intNroGuiaRansa
            '        End With

            '   Call mpObtenerGuiaDespacho(objFiltro)
            '    End If
        End If
        Return blnResultado
    End Function

    Public Function mfblnExiste_RubroTicketDespacho_SDSW(ByVal objMovimientoTicket As clsSDSWMovimientoTicket, _
                                               ByVal blnMsgSiNoExiste As Boolean) As Boolean
        Dim blnResultado As Boolean = False
        Dim strMensajeError As String = ""
        For Each objItemticket As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
            blnResultado = False
            With objMovimientoTicket
                blnResultado = clsDespacho.fblnExiste_TarifaRubro(strMensajeError, objMovimientoTicket, objItemticket)
            End With
            If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If blnResultado = False Then
                MessageBox.Show("El Codigo de Servicio " & objItemticket.pstrTipoServicio_CSRVNV & " no tiene tarifa " & vbNewLine & _
                                     "en el Sistema.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return blnResultado
            End If
        Next
        If blnResultado = True Then
            For Each objItemticket As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
                blnResultado = False
                With objMovimientoTicket
                    blnResultado = clsDespacho.fblnExiste_RubroIGV(strMensajeError, objItemticket)
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
    Public Function mfblnOrdenServicio_Ticket_Autorizacion_SDSW(ByVal objMovimientoTicket As clsSDSWMovimientoTicket) As Boolean
        Dim strMensajeError As String = ""
        'Dim blnResultado As Boolean = True

        Dim objDespacho As clsDespacho = New clsDespacho(objSeguridadBN.pUsuario)
        If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
            objDespacho.fblnOrdenDespacho_TicketW(strMensajeError, objMovimientoTicket)
        End If
        frmSDSWDespachoSDSA.refresca()

        If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
            Dim objParametroTicket As clsFiltros_ReporteTicket = New clsFiltros_ReporteTicket
            For Each objItemticket As clsSDSWItemTicket In objMovimientoTicket.plstItemticket
                With objParametroTicket
                    .pintNumControlTicket_NROTCK = frmSDSWDespachoSDSA.dgNroTicket.CurrentRow.Cells("ticket").Value
                End With
            Next
            Call mpObtenerTicketDespachoSDSW(objParametroTicket)
        End If
    End Function

End Module
