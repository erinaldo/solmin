Imports RANSA.NEGO.slnSOLMIN_SDSW
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS
Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO

Public Class frmSDSWDespachoSDSA
    Private booStatus As Boolean = False
    Private blnRealizarDespacho As Boolean = False
    Private blnStatusNuevoAcoplado As Boolean = False
    Private intWidth As Integer = 0
    '-- Tipo de Movimiento
    Private strTipoMovimiento_STPING As String = ""
    Private strDetalleTipoMovimiento_TTPING As String = ""
    '-- Desglose
    Private strDesglose_CTPOCN As String = "N"
    '-- Contiene la información de la Cabecera
    Private objMovimientoMercaderia As clsSDSWMovimientoMercaderia
    Private objMovimientoTicket As clsSDSWMovimientoTicket
#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        'ANULAR
        'GENERAR
        'RESTAURAR
    End Enum
#End Region
#Region "Funciones"
    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean

        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.PROCESAR Then
            If txtCliente.Text = "" Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub pActualizarInformacion()
        If fblnValidaInformacion(eTipoValidacion.PROCESAR) Then
            Dim objAppConfig As cAppConfig = New cAppConfig
            booStatus = False
            '-- Cargamos las Mercaderías
            Dim objFiltro As clsFiltro_SDSWListarMercaderia = New clsFiltro_SDSWListarMercaderia
            With objFiltro
                Int64.TryParse("" & txtCliente.Tag, .pintCodigoCliente_CCLNT)
                'Int64.TryParse("" & me.txtAutorizacion.Text , .pi)
            End With
            blnRealizarDespacho = False
            '-- Dejamos los controles de mercaderías y los otros se ocultan
            'hgOS.Visible = False
            'hgMercaderiaSeleccionada.Visible = False
            'kpnuevo.Visible = False
            '-- Listamos la información de la mercaderías
            Me.dgAutorizaciones.DataSource = mfdtListar_SDSWAutorizacionSalida(objFiltro)

            '-- Se libera los procesos automáticos
            booStatus = True
            '-- Se habilita el botón para realizar una nueva Despacho
            'bsaRealizarDespacho.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            '-- Limpiamos la información de la cabecera
            objMovimientoMercaderia = Nothing
            objMovimientoTicket = Nothing
            'grpLeyenda.Visible = False
            txtCliente.Enabled = True
            'txtFamilia.Enabled = True
            'txtGrupo.Enabled = True
            bsaClienteListar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            'bsaFamiliaListar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            'bsaGrupoListar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            '   Call pOcultarInformacionCabecera(False)
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("RECSDS_ClienteNombre", txtCliente.Text)
            objAppConfig.SetValue("RECSDS_ClienteCodigo", txtCliente.Tag)
            objAppConfig = Nothing
            dtMercaderiaSeleccionadas.Rows.Clear()
            dtTicket.Rows.Clear()
            ' Procedemos a habilitar los controles para el registro de la recepción
            objMovimientoMercaderia = New clsSDSWMovimientoMercaderia
            objMovimientoTicket = New clsSDSWMovimientoTicket
        End If
    End Sub

#End Region

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        pActualizarInformacion()

    End Sub

    Private Sub bsaProcesarRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesarRecepcion.Click
        'mfdtListar_AutorizacionSalida
        If dgticket.RowCount > 0 Then
            If dgAutorizaciones.CurrentRow.Cells("A_NORSRA").Value.ToString.Trim <> dgticket.CurrentRow.Cells("NORDSR").Value.ToString.Trim Then
                MessageBox.Show("No se puede cambiar de Orden Procesar Información", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        'If mfblnExiste_RubroTicket(Compania_Usuario, Division_Usuario, txtCliente.Tag, objMovimientoTicket, True) Then
        Dim fIniciarMovAlmacen As frmIniciarMovAlmacen = New frmIniciarMovAlmacen
        With fIniciarMovAlmacen
            'Agregado para Almaceneras
            .pintCodigoCliente = txtCliente.Tag
            .pstrRazonSocialCliente = txtCliente.Text
            ' modificar luego
            .pintServicio = 2
            .pstrAdicinarInfTitulo = "Despacho"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Obtenemos la información de la cabecera registrada
                ' objMovimientoMercaderia = .pobjInformacionIngresada
                ' Agregado para Almaceneras 
                objMovimientoMercaderia.pintCodigoCliente_CCLNT = .pobjInformacionIngresada.pintCodigoCliente_CCLNT
                objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL = .pobjInformacionIngresada.pstrRazonSocialCliente_TCMPCL
                objMovimientoMercaderia.pstrRazonSocialEmpTransporte_TCMPTR = .pobjInformacionIngresada.pstrRazonSocialEmpTransporte_TCMPTR
                objMovimientoMercaderia.pstrMarcaUnidad_TMRCCM = .pobjInformacionIngresada.pstrMarcaUnidad_TMRCCM
                objMovimientoMercaderia.pstrNroBrevete_NBRVCH = .pobjInformacionIngresada.pstrNroBrevete_NBRVCH
                objMovimientoMercaderia.pstrObservaciones_TOBSER = .pobjInformacionIngresada.pstrObservaciones_TOBSER
                objMovimientoMercaderia.pstrCompania_CCMPN = Compania_Usuario
                ' Procedemos con el procesamiento de la información
                Call pProcesarDespacho()
            End If
            .Dispose()
            fIniciarMovAlmacen = Nothing
        End With
        ' End If
    End Sub

    Private Sub bsaAgregarMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAgregarMercaderia.Click

        If Me.dgAutorizaciones.RowCount <= 0 Then Exit Sub
        Dim fSolicInforMovAlmacen As frmSDSWSolicInforDesAlmacen = New frmSDSWSolicInforDesAlmacen
        fSolicInforMovAlmacen.txtDesCantidad.Text = dgAutorizaciones.CurrentRow.Cells("A_QAUTCN").Value
        fSolicInforMovAlmacen.txtProducto.Tag = dgAutorizaciones.CurrentRow.Cells("CMRCD").Value
        If fSolicInforMovAlmacen.txtProducto.Tag = "" Then
            Exit Sub
        Else
            Call mfblnBuscar_SDSWProducto(fSolicInforMovAlmacen.txtProducto.Tag, fSolicInforMovAlmacen.txtProducto.Text)
        End If

        With fSolicInforMovAlmacen
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                'Busca Producto
                ' INICIO
                If dgAutorizaciones.CurrentRow.Cells("FUNDS2_A").Value = "C" Then
                    If fSolicInforMovAlmacen.pdecRecCantidad > Me.dgAutorizaciones.CurrentRow.Cells("A_QAUTCN").Value - Me.dgAutorizaciones.CurrentRow.Cells("A_QTTDSC").Value Then
                        MessageBox.Show("La Cantidad es mayor que la Autorizada", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If fSolicInforMovAlmacen.pdecRecCantidad > Me.dgAutorizaciones.CurrentRow.Cells("QSLMC").Value Then
                        MessageBox.Show("Cantidad de Transaccion > Saldo de Orden", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    If fSolicInforMovAlmacen.pdecRecPeso > Me.dgAutorizaciones.CurrentRow.Cells("A_QAUTPS").Value - Me.dgAutorizaciones.CurrentRow.Cells("A_QTTDSP").Value Then
                        MessageBox.Show("El Peso es mayor que el Autorizado", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If fSolicInforMovAlmacen.pdecRecPeso > Me.dgAutorizaciones.CurrentRow.Cells("QSLMP").Value Then
                        MessageBox.Show("Peso de Transaccion > Saldo de Orden", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If

                Dim rwTemp As DataRow = dtMercaderiaSeleccionadas.NewRow
                With rwTemp

                    rwTemp.Item("TMRCD2") = fSolicInforMovAlmacen.pstrDescripcion
                    rwTemp.Item("CMRCD") = dgAutorizaciones.CurrentRow.Cells("CMRCD").Value
                    rwTemp.Item("NORDSR") = dgAutorizaciones.CurrentRow.Cells("A_NORSRA").Value
                    rwTemp.Item("NCNTR") = dgAutorizaciones.CurrentRow.Cells("O_NCNTR").Value
                    rwTemp.Item("NAUTR") = dgAutorizaciones.CurrentRow.Cells("A_NAUTR").Value
                    rwTemp.Item("NORCCL") = fSolicInforMovAlmacen.pstrNroOrdenCompra
                    rwTemp.Item("NGUICL") = fSolicInforMovAlmacen.pstrNroGuiaCliente
                    rwTemp.Item("NRUCLL") = fSolicInforMovAlmacen.pstrNroRUCCliente
                    rwTemp.Item("STPING") = fSolicInforMovAlmacen.pstrTipoDespacho
                    rwTemp.Item("QTRMC") = fSolicInforMovAlmacen.pdecRecCantidad
                    rwTemp.Item("QTRMP") = fSolicInforMovAlmacen.pdecRecPeso
                    rwTemp.Item("FUNDS2") = dgAutorizaciones.CurrentRow.Cells("FUNDS2_A").Value
                    rwTemp.Item("TOBSRV") = fSolicInforMovAlmacen.pstrRecObservacion

                    'rwTemp.Item("CMRCLR") = dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value
                    'rwTemp.Item("NCRCTC") = dgListaOrdenesServicio.CurrentRow.Cells("O_NCRCTC").Value
                    'rwTemp.Item("CUNCNT") = dgListaOrdenesServicio.CurrentRow.Cells("O_CUNCN5").Value
                    'rwTemp.Item("CUNPST") = dgListaOrdenesServicio.CurrentRow.Cells("O_CUNPS5").Value
                    'rwTemp.Item("CUNVLT") = dgListaOrdenesServicio.CurrentRow.Cells("O_CUNVL5").Value
                    'rwTemp.Item("CTPALM") = dgStockPorAlmacen.CurrentRow.Cells("D_CTPALM").Value
                    'rwTemp.Item("CALMC") = dgStockPorAlmacen.CurrentRow.Cells("D_CALMC").Value
                    'rwTemp.Item("CZNALM") = dgStockPorAlmacen.CurrentRow.Cells("D_CZNALM").Value
                    'rwTemp.Item("CTPDPS") = dgListaOrdenesServicio.CurrentRow.Cells("O_CTPDP6").Value
                End With
                dtMercaderiaSeleccionadas.Rows.Add(rwTemp)
                'End If
                'End With

                Dim objTemp As clsSDSWItemMovimientoMercaderia = New clsSDSWItemMovimientoMercaderia
                With objTemp

                    '  Int64.TryParse(("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NCNTR").Value).ToString.Trim, .pintNroContrato_NCNTR)
                    '  Int64.TryParse(("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NCRCTC").Value).ToString.Trim, .pintNroCorrDetalleContrato_NCRCTC)
                    '.pstrCodigoMercaderia_CMRCLR = ("" & dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value).ToString.Trim
                    ' .pstrCodigoRANSA_CMRCD = ("" & dgMercaderias.CurrentRow.Cells("M_CMRCD").Value).ToString.Trim
                    '.pstrTipoAlmacen_CTPALM = ("" & dgStockPorAlmacen.CurrentRow.Cells("D_CTPALM").Value).ToString.Trim
                    ' .pstrAlmacen_CALMC = ("" & dgStockPorAlmacen.CurrentRow.Cells("D_CALMC").Value).ToString.Trim
                    ' onaAlmacen_CZNALM = ("" & dgStockPorAlmacen.CurrentRow.Cells("D_CZNALM").Value).ToString.Trim

                    '.pstrUnidadCantidad_CUNCNT = ("" & dgAutorizaciones.CurrentRow.Cells("O_CUNCN5").Value).ToString.Trim
                    '.pstrUnidadPeso_CUNPST = ("" & dgAutorizaciones.CurrentRow.Cells("O_CUNPS5").Value).ToString.Trim
                    '.pstrUnidadValorTransaccion_CUNVLT = ("" & dgAutorizaciones.CurrentRow.Cells("O_CUNVL5").Value).ToString.Trim


                    Int64.TryParse(("" & dgAutorizaciones.CurrentRow.Cells("A_NORSRA").Value).ToString.Trim, .pintOrdenServicio_NORDSR)

                    Int64.TryParse(("" & dgAutorizaciones.CurrentRow.Cells("A_NAUTR").Value).ToString.Trim, .pintNroAutorizacion_NAUTR)

                    .pstrNroOrdenCompraCliente_NORCCL = fSolicInforMovAlmacen.pstrNroOrdenCompra
                    .pstrNroGuiaCliente_NGUICL = fSolicInforMovAlmacen.pstrNroGuiaCliente
                    .pstrNroRUCCliente_NRUCLL = fSolicInforMovAlmacen.pstrNroRUCCliente
                    Decimal.TryParse(fSolicInforMovAlmacen.pdecRecCantidad, .pdecCantidad_QTRMC)
                    Decimal.TryParse(fSolicInforMovAlmacen.pdecRecPeso, .pdecPeso_QTRMP)
                    .pstrTipoMovimiento_STPING = fSolicInforMovAlmacen.pstrTipoDespacho
                    Int32.TryParse(fSolicInforMovAlmacen.pintNroVigencia, .pintNroDiasVigencia_QDSVGN)
                    .pstrSatusUnidadDespacho_FUNDS2 = ("" & dgAutorizaciones.CurrentRow.Cells("FUNDS2_A").Value).ToString.Trim
                    .pstrTipoDeposito_CTPDPS = 1
                    .pstrObservaciones_TOBSRV = fSolicInforMovAlmacen.pstrRecObservacion

                End With
                objMovimientoMercaderia.AddItemMovimientoMercaderia(objTemp)
                'dgMercaderias.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen

                bsaProcesarRecepcion.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                bsaEliminarMercaderia.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                'Deshabilita los botones de busqueda del cliente, se habilitarn hasta que procese el despacho
            End If
            .Dispose()
            fSolicInforMovAlmacen = Nothing
        End With
    End Sub

    Private Sub bsaAgregarTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAgregarTicket.Click

        'Agregado para Almaceneras
        If dgAutorizaciones.RowCount <= 0 Then Exit Sub

        If dgticket.RowCount > 0 Then
            If dgAutorizaciones.CurrentRow.Cells("A_NORSRA").Value.ToString.Trim <> dgticket.CurrentRow.Cells("NORDSR").Value.ToString.Trim Then
                MessageBox.Show("No se puede cambiar de Orden Grabe Ticket", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim fSolicInforticket As frmSDSWTicketDesAlmacen = New frmSDSWTicketDesAlmacen
        With fSolicInforticket
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' INICIO
                Dim rwTemp As DataRow = dtTicket.NewRow
                With rwTemp
                    'Campos de Ticket
                    rwTemp.Item("NORDSR") = dgAutorizaciones.CurrentRow.Cells("A_NORSRA").Value
                    rwTemp.Item("CSRVNV") = fSolicInforticket.pstrTipoServicio
                    rwTemp.Item("HORAINI") = fSolicInforticket.pintHoraInicio
                    rwTemp.Item("HORAFIN") = fSolicInforticket.pintHorafinal
                    rwTemp.Item("FATNSR") = fSolicInforticket.pstrFecha
                    rwTemp.Item("NHRCAL") = fSolicInforticket.pdecHoraCalculada
                    rwTemp.Item("NHRFAC") = fSolicInforticket.pdecHoraFacturada
                    rwTemp.Item("OBSER") = fSolicInforticket.pstrobser

                    'Campos del mercaderias seleccionadas
                End With
                dtTicket.Rows.Add(rwTemp)

                Dim objTemp As clsSDSWItemTicket = New clsSDSWItemTicket
                With objTemp
                    Int64.TryParse(("" & dgAutorizaciones.CurrentRow.Cells("A_NORSRA").Value).ToString.Trim, .pintOrdenServicio_NORDSR)
                    .pstrTipoServicio_CSRVNV = fSolicInforticket.pstrTipoServicio
                    .pintHoraInicio_HORAINI = fSolicInforticket.pintHoraInicio
                    .pintHoraFin_HORAFIN = fSolicInforticket.pintHorafinal
                    Date.TryParse(fSolicInforticket.pstrFecha, .pdteFechaAtencion_FATNSR)
                    Decimal.TryParse(fSolicInforticket.pdecHoraCalculada, .pdecHoraCalculada_NHRCAL)
                    Decimal.TryParse(fSolicInforticket.pdecHoraFacturada, .pdecHoraFacturada_NHRFAC)
                    .pstrObservacion_OBSER = fSolicInforticket.pstrobser

                End With
                objMovimientoTicket.AddItemTicket(objTemp)
                dgAutorizaciones.CurrentRow.DefaultCellStyle.BackColor = Color.LightSeaGreen
                Me.bsaProcesarTicket.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                Me.bsaBorrarTicket.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            End If
            .Dispose()
            fSolicInforticket = Nothing
        End With
    End Sub

    Private Sub bsaBorrarTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaBorrarTicket.Click
        Dim objTemp As clsSDSWItemTicket = New clsSDSWItemTicket
        objMovimientoTicket.DeleteIndexTicket(dgticket.CurrentRow.Index, objTemp)
        dgticket.Rows.Remove(dgticket.CurrentRow)
    End Sub

    Private Sub bsaProcesarTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesarTicket.Click

        ' Procedemos con el procesamiento de la información
        Dim fObservacionTicket As frmSDSWObservacionTicket = New frmSDSWObservacionTicket
        fObservacionTicket.cbxTipo.Text = "D"
        fObservacionTicket.cbxTipo.Visible = False
        fObservacionTicket.lbltipo.Visible = False
        With fObservacionTicket

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Obtenemos la información de la cabecera registrada
                objMovimientoTicket.pstrObservacion_OBSER = fObservacionTicket.pstrObservacion
                objMovimientoTicket.pstrTipoAlmacen_CTPALM = fObservacionTicket.pstrTipoAlmacen
                objMovimientoTicket.pstrAlmacen_CALMC = fObservacionTicket.pstrAlmacen
                objMovimientoTicket.pstrZonaAlmacen_CZNALM = fObservacionTicket.pstrZonaAlmacen
                objMovimientoTicket.pstrZonaAlmacen_CTPOAT = fObservacionTicket.pstrTipo
                objMovimientoTicket.pintCodigoCliente_CCLNT = txtCliente.Tag
                ' Procedemos con el procesamiento de la información
                Call pProcesarTicket()
            End If
            .Dispose()
            fObservacionTicket = Nothing
        End With
    End Sub
    'Agregado para Almaceneras
    Private Sub pProcesarTicket()
        If objMovimientoTicket.plstItemticket.Count <= 0 Then
            MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            mfblnOrdenServicio_Ticket_Autorizacion_SDSW(objMovimientoTicket)
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
        dtTicket.Rows.Clear()
        objMovimientoTicket = Nothing
        objMovimientoTicket = New clsSDSWMovimientoTicket
    End Sub
    Public Sub refresca()
        Dim strTicket As String = ""
        If mfblnBuscar_Ticket1SDSW(dgAutorizaciones.CurrentRow.Cells("A_NORSRA").Value, strTicket) Then
            dgNroTicket.Rows.Clear()
            dgNroTicket.Rows.Add()
            dgNroTicket.Rows(0).Cells(0).Value = strTicket
        End If
    End Sub
    Private Sub pProcesarDespacho()
        If objMovimientoMercaderia.plstItemMovimientoMercaderia.Count <= 0 Then
            MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf objMovimientoTicket.plstItemticket.Count > 0 Then
            MessageBox.Show("No se puede generar, grabe el ticket", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Agregado para Almaceneras
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            If mfblnDespacho_Mercaderia_AutorizacionWarrant_SDSW(objMovimientoMercaderia) Then Call pActualizarInformacion()
            MessageBox.Show("Datos Registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub bsaEliminarMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEliminarMercaderia.Click
        Dim objTemp As clsSDSWItemMovimientoMercaderia = New clsSDSWItemMovimientoMercaderia
        objMovimientoMercaderia.DeleteIndexMercaderia(dgMercaderiaSeleccionada.CurrentRow.Index, objTemp)
        dgMercaderiaSeleccionada.Rows.Remove(dgMercaderiaSeleccionada.CurrentRow)
    End Sub

    Private Sub bsaClienteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaClienteListar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
        '        lblcodcliente.Text = txtCliente.Tag
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
            'lblcodcliente.Text = txtCliente.Tag
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        txtCliente.Tag = ""
        '   dgMercaderias.DataSource = Nothing
    End Sub

    Private Sub txtCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        If txtCliente.Text = "" Then
            txtCliente.Tag = ""
        Else
            If txtCliente.Text <> "" And "" & txtCliente.Tag = "" Then
                Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
                If txtCliente.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

End Class
