Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.NEGO.slnSOLMIN_SDS.DespachoSDS
Imports Ransa.NEGO.slnSOLMIN_SDS.DespachoSDS.Reportes
Imports Ransa.NEGO.slnSOLMIN_SDS.DespachoSDS.Procesos
Imports Ransa.Controls.ServicioOperacion
Imports Ransa.Controls.Servicios
Imports Ransa.TYPEDEF.Servicios
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Module mDespachoSDS
    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para Filtros -'
    '----------------------------------------------------'

    '------------------------------------------------------------------------------------------------------------------'
    '- Procedimiento de Listar Información para DataGrid -'
    '-----------------------------------------------------'
    Public Function mfdtListar_GuiasRANSA(ByVal objFiltro As clsFiltros_ListarGuiasRansaDS) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsDespacho.fdtListar_GuiasRANSA(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function

    Public Function mfdtListar_GuiasREMISION(ByVal objFiltro As clsFiltros_ListarGuiasRemisionDS) As DataTable
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtEntidad = clsDespacho.fdtListar_GuiasRemision(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtEntidad
    End Function

    Public Function mfdtListar_StockMercaderias(ByVal objFiltro As clsFiltro_ListarMercaderia) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsDespacho.fdtListar_StockMercaderias(objFiltro, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return dtResultado
    End Function

    Public Function mfdtListar_StockMercaderiasPorAlmacen(ByVal intOrdenServicio As Int64) As DataTable
        Dim dtResultado As DataTable = Nothing
        Dim strMensajeError As String = ""
        dtResultado = clsDespacho.fdtListar_StockMercaderiasPorAlmacen(intOrdenServicio, strMensajeError)
        If strMensajeError <> "" Then MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'CSR- HUNDRED-feature/240616_RevisionProcesoDespachos - INICIO
        Dim dtCloned As DataTable = dtResultado.Clone()
        dtCloned.Columns(15).DataType = GetType(Decimal)
        For Each row As DataRow In dtResultado.Rows
            dtCloned.ImportRow(row)
        Next
        'CSR- HUNDRED-feature/240616_RevisionProcesoDespachos - FIN

        Return dtCloned
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
    Public Function mfstrDefecto_ServicioDespacho(ByVal strCompania As String, ByVal strDivision As String, ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
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

    Public Function mfstrDefecto_TipoMovimientoDespacho(ByRef strCodigo As String, ByRef strDetalle As String) As Boolean
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
    Public Function mfblnDespacho_Mercaderia(ByRef resultadoEnvioInterfaz As String, ByRef objMovimientoMercaderia As clsMovimientoMercaderia, ByVal blnCheckServicio As Boolean, Optional ByRef intNroGuiaRansa As Int64 = 0) As Boolean
        '--------------------------
        '-- Variables de Trabajo --
        '--------------------------
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        '----------------------------------
        '-- Generando Información Básica --
        '----------------------------------
        If Not mfblnObtener_NroGuiaRansa(IIf(objMovimientoMercaderia.pintServicio_CSRVC = 910, 1, 2), 1, True, intNroGuiaRansa) Then
            ' Si se presentó algún error en la generación de la Guía de Ransa, se culmina con el proceso
            MessageBox.Show("Error generando el Nro de la Guía de Ransa.", "Error Nro. Ransa:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultado = False
        Else
            '--------------------------
            '-- Proceso de Inserción --
            '--------------------------
            Dim objDespacho As clsDespacho = New clsDespacho(objSeguridadBN.pUsuario)

            objDespacho.fblnDespacho_Mercaderia(resultadoEnvioInterfaz, strMensajeError, intNroGuiaRansa, objMovimientoMercaderia, objSeguridadBN.pstrPCName)
            '---------------------------
            '-- Visualizar el Reporte --
            '---------------------------
            If strMensajeError <> "" Or Not blnResultado Then
                MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            Else
                'Dim objFiltro As clsFiltros_ReporteGuiaDespacho = New clsFiltros_ReporteGuiaDespacho
                'With objFiltro
                '    .pintCodigoCliente_CCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                '    .pstrRazonSocialCliente_TCMPCL = objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL
                '    .pstrRazonSocialEmpresa = GLOBAL_EMRESA
                '    .pintNroGuiaRansa_NGUIRN = intNroGuiaRansa
                'End With
                ' Call pVisualizarGuiaRansa(objFiltro)
                If blnCheckServicio Then
                    ' Registro de Servicio
                    Dim oServicio As New Servicio_BE
                    With oServicio
                        .CCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
                        .CDVSN = objSeguridadBN.pDivision
                        .NOPRCN = 0
                        .CCLNFC = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                        .CCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                        .NRTFSV = 0
                        .QATNAN = 0
                        .TIPO = "N"
                        .FOPRCN = 0
                        .FECINI = 0
                        .FECFIN = 0
                        .STIPPR = "D"
                        .CSRVC = 2
                        .STPODP = objSeguridadBN.pstrTipoAlmacen
                        .TIPOALM = objSeguridadBN.pstrTipoAlmacen
                        .PSUSUARIO = objSeguridadBN.pUsuario
                        .NGUIRN = intNroGuiaRansa
                    End With
                    Dim frm As New UcFrmServicioAgregarSA_DS
                    frm.oServicio = oServicio
                    frm.Text = Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    End If

                End If
            End If
        End If
        Return blnResultado
    End Function



End Module
