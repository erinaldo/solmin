Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.NEGO.slnSOLMIN_SDSW
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDSW.Reportes.Generador
Imports RANSA.NEGO.slnSOLMIN_R02.FiltrosWrrt
Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
'Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS.Procesos

Public Class frmSDSWIngOServicio
#Region " Atributos "
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
    Private rptTemp As ReportDocument
    'Reporte Genera Ticket
    Private strMensajeError As String
    Private strCompania As String
    Private objMovimientoTicket As clsSDSWMovimientoTicket
    Dim Estado(2) As String
#End Region

#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        ANULAR
        'GENERAR
        'RESTAURAR
    End Enum
#End Region
#Region " Procedimientos y Funciones "
    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.PROCESAR Then
            If txtCliente.Text = "" Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
        Else
            Dim objFiltros_AnularTicket As clsFiltros_SDSWAnularTicket = New clsFiltros_SDSWAnularTicket
            With objFiltros_AnularTicket
                .intNumTicket_NRTOCK = dgTicket.CurrentRow.Cells("NROTCK1").Value
            End With

            If dgTicket.RowCount <= 0 Then strMensajeError &= "No existen Ticket para Anular. " & vbNewLine
            ' Validamos los valores 
            With dgTicket
                Select Case eValidacion
                    Case eTipoValidacion.ANULAR
                        If .CurrentRow.Cells("SESTRG1").Value = "*" Then strMensajeError &= "Ticket ya se encuentra Anulado. " & vbNewLine
                        If .CurrentRow.Cells("SESDCMD1").Value = "F" Or .CurrentRow.Cells("SESDCMD1").Value = "R" Then _
                                                 strMensajeError &= "Ticket no se puede anular porque se encuentra Facturado y/o Pendiente por Facturar" & vbNewLine

                End Select
            End With
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function
    Private Function fblnValidaTicketCerrar(ByVal eValidacion As eTipoValidacion) As Boolean
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
    Private Sub bsaCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        If mfblnSalirOpcion() Then
            Me.Close()
        End If
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
            lblcodcliente.Text = txtCliente.Tag
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        txtCliente.Tag = ""
    End Sub
    Private Sub txtCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        If txtCliente.Text = "" Then
            txtCliente.Tag = ""
        Else
            If txtCliente.Text <> "" And "" & txtCliente.Tag = "" Then
                Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
                lblcodcliente.Text = txtCliente.Tag
                If txtCliente.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If fblnValidaInformacion(eTipoValidacion.PROCESAR) Then
            Dim objAppConfig As cAppConfig = New cAppConfig
            booStatus = False
            '-- Cargamos las Ordenes de Servicio
            Dim objFiltro As RANSA.NEGO.slnSOLMIN_R02.FiltrosWrrt = New RANSA.NEGO.slnSOLMIN_R02.FiltrosWrrt()

            With objFiltro
                Int64.TryParse("" & txtCliente.Tag, .pintCodigoCliente_CCLNT)
                .pstrNORDSR = txtNroOrdServicio.Text
                .pstrSESTRG = Estado(Me.cmbEstado.Items.IndexOf(Me.cmbEstado.Text))
            End With
            blnRealizarDespacho = False
            '-- Dejamos los controles de mercaderías y los otros se ocultan
            dgOrdenServicio.DataSource = mfdtListar_SDSWOrdenes_Servicio(objFiltro)
            '-- Se libera los procesos automáticos
            booStatus = True
            '-- Se habilita el botón para realizar una nueva Despacho
            '-- Limpiamos la información de la cabecera
            objMovimientoTicket = Nothing
            Call pOcultarInformacionCabecera(False)
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("RECSDS_ClienteNombre", txtCliente.Text)
            objAppConfig.SetValue("RECSDS_ClienteCodigo", txtCliente.Tag)
            objAppConfig = Nothing
            objMovimientoTicket = New clsSDSWMovimientoTicket
            bsngrabar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            bsaEliminarServicio.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End If
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub pOcultarInformacionCabecera(ByVal blnStatus As Boolean)
        If blnStatus Then
            'hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
            'hgOS.Width = 25
            'bsaOcultar.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
            'bsaOcultar.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.FixedRight
            'bsaOcultar.Text = "Visualizar"
        Else
            'hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
            'hgOS.Width = intWidth
            'bsaOcultar.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
            'bsaOcultar.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
            'bsaOcultar.Text = "Ocultar"
        End If
    End Sub

    Private Sub dgOrdenServicio_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOrdenServicio.CurrentCellChanged
        If Not dgOrdenServicio.CurrentRow Is Nothing Then
            dgTicket.DataSource = mfdtListar_SDSWOrdenesServicioPorTicket(dgOrdenServicio.CurrentRow.Cells("M_NORDSR").Value)
        Else
            dgTicket.DataSource = Nothing
            VisorReportesCrystal.Visible = False
        End If
    End Sub
    Private Sub bsaClienteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaClienteListar.Click

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
        lblcodcliente.Text = txtCliente.Tag
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub pProcesarRecepcion()
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If objMovimientoTicket.plstItemticket.Count <= 0 Then
            MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            mfblnOrdenServicio_Ticket_SDSW(objMovimientoTicket)
        End If
        Cursor = System.Windows.Forms.Cursors.Arrow
        dgTicket.DataSource = mfdtListar_SDSWOrdenesServicioPorTicket(Me.dgOrdenServicio.CurrentRow.Cells("M_NORDSR").Value)
        dtTicket.Rows.Clear()
        objMovimientoTicket = Nothing
        objMovimientoTicket = New clsSDSWMovimientoTicket
    End Sub
    Private Sub bsngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsngrabar.Click
        ' Procedemos con el procesamiento de la información
        Dim fObservacionTicket As frmSDSWObservacionTicket = New frmSDSWObservacionTicket
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
                Call pProcesarRecepcion()
            End If
            .Dispose()
            fObservacionTicket = Nothing
        End With
    End Sub
    Private Sub pInicioVistaPrevia()
        pcxEspera.Top = (hgVisorPrevia.Width / 2) - (pcxEspera.Width / 2)
        pcxEspera.Left = (hgVisorPrevia.Height / 2) - (pcxEspera.Height / 2)
        pcxEspera.Visible = True
        'bsaVistaPreviaGS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        ' bsaVistaPreviaT.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        VisorReportesCrystal.Visible = False
        bgwGifAnimado.RunWorkerAsync()
    End Sub
    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        'bsaVistaPreviaGS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        'bsaVistaPreviaGR.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        If Not dgTicket.CurrentRow.Cells("SESTRG1").Value = "*" Then
            VisorReportesCrystal.ReportSource = rptTemp
            VisorReportesCrystal.Visible = True
        Else
            VisorReportesCrystal.Visible = False
            MessageBox.Show("No se muestra Ticket esta Anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub pVisualizarTicket()
        If dgTicket.RowCount = 0 Then Exit Sub
        Dim objReporte As clsReportesTicket = New clsReportesTicket(objSeguridadBN.pUsuario)
        Dim objParametroTicket As clsFiltros_ReporteTicket = New clsFiltros_ReporteTicket
        ' Filtros
        With objParametroTicket
            Int64.TryParse(dgTicket.CurrentRow.Cells("NROTCK1").Value, .pintNumControlTicket_NROTCK)
        End With
        rptTemp = objReporte.frptTicket_Recepcion_Despacho(objParametroTicket, strMensajeError)
    End Sub
    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pVisualizarTicket()
    End Sub
    Private Sub bsagenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsagenerar.Click
        If dgvticket.RowCount > 0 Then
            If dgOrdenServicio.CurrentRow.Cells("M_NORDSR").Value.ToString.Trim <> dgvticket.CurrentRow.Cells("NORDSR").Value.ToString.Trim Then
                MessageBox.Show("No se puede cambiar de Orden Grabe Ticket", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim fSolicInforticket As frmSDSWTicketRecAlmacen = New frmSDSWTicketRecAlmacen
        With fSolicInforticket
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' INICIO
                Dim rwTemp As DataRow = dtTicket.NewRow
                With rwTemp
                    'Campos de Ticket
                    rwTemp.Item("NORDSR") = Me.dgOrdenServicio.CurrentRow.Cells("M_NORDSR").Value
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
                    Int64.TryParse(("" & dgOrdenServicio.CurrentRow.Cells("M_NORDSR").Value).ToString.Trim, .pintOrdenServicio_NORDSR)
                    .pstrTipoServicio_CSRVNV = fSolicInforticket.pstrTipoServicio
                    .pintHoraInicio_HORAINI = fSolicInforticket.pintHoraInicio
                    .pintHoraFin_HORAFIN = fSolicInforticket.pintHorafinal
                    Date.TryParse(fSolicInforticket.pstrFecha, .pdteFechaAtencion_FATNSR)
                    Decimal.TryParse(fSolicInforticket.pdecHoraCalculada, .pdecHoraCalculada_NHRCAL)
                    Decimal.TryParse(fSolicInforticket.pdecHoraFacturada, .pdecHoraFacturada_NHRFAC)
                    .pstrObservacion_OBSER = fSolicInforticket.pstrobser
                End With
                objMovimientoTicket.AddItemTicket(objTemp)
                bsngrabar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                bsaEliminarServicio.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            End If
            .Dispose()
            fSolicInforticket = Nothing
        End With
    End Sub
    Private Sub listar_ticket()
        If dgTicket.RowCount = 0 Or dgTicket.CurrentRow Is Nothing Then
            dgTicket.DataSource = New DataTable
            Exit Sub
        End If
        dgTicket.DataSource = mfdtListar_SDSWOrdenesServicioPorTicket(Me.dgOrdenServicio.CurrentRow.Cells("M_NORDSR").Value)
    End Sub
    Private Sub pProceso_AnularTicket()
        'Agregado para Alamacenras
        ' Si elige NO entonces salimos del proceso
        If Not MessageBox.Show(" ¿ Desea realizar el Proceso de Anulación de Ticket ? ", "Anulación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Exit Sub
        If fblnValidaInformacion(eTipoValidacion.ANULAR) Then
            Dim objFiltros_AnularTicket As clsFiltros_SDSWAnularTicket = New clsFiltros_SDSWAnularTicket
            With objFiltros_AnularTicket
                .intNumTicket_NRTOCK = dgTicket.CurrentRow.Cells("NROTCK1").Value.ToString.Trim
            End With
            If mfblnProceso_AnularTicket(objFiltros_AnularTicket) Then
                booStatus = False
                '-- Eliminamos el registro seleccionado
                dgTicket.Rows.Remove(dgTicket.CurrentRow)
                '-- Actualizamos la información 
                Call listar_ticket()
                booStatus = True
            End If
        End If
    End Sub
    'Agregado para Almaceneras
    Private Sub pProceso_CerrarTicket()
        'Si elige No entonces salimos del proceso
        If Not MessageBox.Show(" ¿ Desea Cerrar el Registro ? ", "Cerrar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Exit Sub
        If fblnValidaTicketCerrar(eTipoValidacion.PROCESAR) Then
            Dim objFiltros_CerrarTicket As clsFiltros_SDSWAnularTicket = New clsFiltros_SDSWAnularTicket
            With objFiltros_CerrarTicket
                .intNumTicket_NRTOCK = dgTicket.CurrentRow.Cells("NROTCK1").Value.ToString.Trim
                .intNumOrden_NORDSR = dgOrdenServicio.CurrentRow.Cells("M_NORDSR").Value.ToString.Trim
            End With
            If mfblnProceso_CerrarTicket(objFiltros_CerrarTicket) Then
                booStatus = False
                '-- Eliminamos el registro seleccionado
                dgTicket.Rows.Remove(dgTicket.CurrentRow)
                '-- Actualizamos la información 
                Call listar_ticket()
                booStatus = True
            End If
        End If
    End Sub

    Private Sub bsaEliminarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEliminarServicio.Click
        Dim objTemp As clsSDSWItemTicket = New clsSDSWItemTicket
        objMovimientoTicket.DeleteIndexTicket(dgvticket.CurrentRow.Index, objTemp)
        dgvticket.Rows.Remove(dgvticket.CurrentRow)
    End Sub
    Private Sub bsaanular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaanular.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call pProceso_AnularTicket()
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub bsaVistaPreviaT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaVistaPreviaT.Click


        Call pInicioVistaPrevia()
    End Sub
    Private Sub bsaCerrarTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarTicket.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call pProceso_CerrarTicket()
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub frmIngOServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        '-- Recuperamos los ultimos valores seleccionados
        txtCliente.Text = objAppConfig.GetValue("RECSDS_ClienteNombre", GetType(System.String)).ToString.ToUpper
        txtCliente.Tag = objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)).ToString.ToUpper
        lblcodcliente.Text = objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)).ToString.ToUpper
        objAppConfig = Nothing

        cmbEstado.Items.Add("Activo") : Estado(0) = "A"
        cmbEstado.Items.Add("Cerrado") : Estado(1) = "C"

    End Sub
#End Region
End Class
