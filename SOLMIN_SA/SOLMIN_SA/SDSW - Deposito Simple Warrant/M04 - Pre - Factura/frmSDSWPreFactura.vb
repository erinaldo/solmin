Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Imports RANSA.NEGO.slnSOLMIN_SDSW
Public Class frmSDSWPreFactura
#Region "Atributos"
    Private booStatus As Boolean = False
    Private objMovimientoTicket As clsSDSWMovimientoTicket
#End Region
#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        'ANULAR
        'GENERAR
        'RESTAURAR
    End Enum
#End Region
#Region "Procedimientos y Funciones"
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

    Private Sub Actualiza()
        If fblnValidaInformacion(eTipoValidacion.PROCESAR) Then
            Dim objAppConfig As cAppConfig = New cAppConfig
            booStatus = False

            Dim objFiltro As clsFiltro_SDSWListaPreFactura = New clsFiltro_SDSWListaPreFactura
            With objFiltro
                Int64.TryParse("" & txtCliente.Tag, .pintCodigoCliente_CCLNT)
                Date.TryParse(Me.txtFechaInicio.Text, .pdteFechaISolicitud_FATNSR)
                Date.TryParse(txtFechaFin.Text, .pdteFechaFSolicitud_FATNSR)
                .strCodigoServicio_CSVRNV = "" & txtTipoServicio.Tag

            End With

            dgvPreFactura.DataSource = mfdtListar_SDSWPreFactura(objFiltro, Compania_Usuario, Division_Usuario)
        End If
    End Sub

    Private Sub pProcesarPreFractura()

        If mfblnExiste_RubroTicket_SDSW(Compania_Usuario, Division_Usuario, txtCliente.Tag, objMovimientoTicket, True) Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            objMovimientoTicket.pintCodigoCliente_CCLNT = txtCliente.Tag
            mfblnPreFactura_Ticket_SDSW(objMovimientoTicket, Compania_Usuario, Division_Usuario)

            Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Guardar)
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If

        objMovimientoTicket = Nothing
        objMovimientoTicket = New clsSDSWMovimientoTicket

        Call Actualiza()
    End Sub
#End Region

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call Actualiza()
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub bsaClienteListar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsaClienteListar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
        lblcodcliente.Text = txtCliente.Tag
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub bsaTipoServicioListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoServicioListar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_ServicioSDSW(txtTipoServicio.Tag, txtTipoServicio.Text, Compania_Usuario, Division_Usuario)
        lblcodrubro.Text = txtTipoServicio.Tag
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
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
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
                lblcodcliente.Text = txtCliente.Tag
                Cursor = System.Windows.Forms.Cursors.Arrow
                If txtCliente.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtTipoServicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoServicio.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_ServicioSDSW(txtTipoServicio.Tag, txtTipoServicio.Text, Compania_Usuario, Division_Usuario)
            lblcodrubro.Text = txtTipoServicio.Tag
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub txtTipoServicio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoServicio.TextChanged
        txtTipoServicio.Tag = ""
    End Sub
    Private Sub txtTipoServicio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoServicio.Validating
        If txtTipoServicio.Text = "" Then
            txtTipoServicio.Tag = ""
        Else
            If txtTipoServicio.Text <> "" And "" & txtTipoServicio.Tag = "" Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Call mfblnBuscar_ServicioSDSW(txtTipoServicio.Tag, txtTipoServicio.Text, Compania_Usuario, Division_Usuario)
                lblcodrubro.Text = txtTipoServicio.Tag
                Cursor = System.Windows.Forms.Cursors.Arrow
                If txtTipoServicio.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub bsaGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaGrabar.Click



        txtCliente.Focus()
        If txtTipoServicio.Text = "" Then
            MessageBox.Show("Debe seleccionar un Tipo de Servicio", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            If mfblnPreguntas(enumPregVarios.PROCESO_Guardar) Then

                objMovimientoTicket = Nothing
                objMovimientoTicket = New clsSDSWMovimientoTicket
                Dim I As Integer
                Dim Sumar As Decimal
                Dim Rubro As String
                Sumar = 0
                Rubro = txtTipoServicio.Tag

                For I = 0 To dgvPreFactura.RowCount - 1
                    If dgvPreFactura.Item(0, I).Value = "X" Then

                        Dim objTemp As clsSDSWItemTicket = New clsSDSWItemTicket
                        With objTemp
                            .pintNumControlTicket_NROTCK = dgvPreFactura.Item(1, I).Value
                            .pintOrdenServicio_NORDSR = dgvPreFactura.Item(2, I).Value
                            .pstrTipoServicio_CSRVNV = dgvPreFactura.Item(4, I).Value
                            .pstrRubroServicio_TCMTRF = dgvPreFactura.Item(5, I).Value
                            .pdecHoraFacturada_NHRFAC = dgvPreFactura.Item(6, I).Value
                            .pstrAlmacen_CALMCM = dgvPreFactura.Item(8, I).Value
                        End With
                        objMovimientoTicket.AddItemTicket(objTemp)

                        ' Sumar = Sumar + dgvPreFactura.Item(6, I).Value
                    End If
                Next

                objMovimientoTicket.pintCodigoRubro_CSRVNV = Rubro
                'objMovimientoTicket.pdecHoraFacturada_NHRFAC = Sumar

                Call pProcesarPreFractura()
            End If
        End If

    End Sub

    Private Sub frmPreFactura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        '-- Recuperamos los ultimos valores seleccionados
        txtCliente.Text = objAppConfig.GetValue("RECSDS_ClienteNombre", GetType(System.String)).ToString.ToUpper
        txtCliente.Tag = objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)).ToString.ToUpper
        lblcodcliente.Text = objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)).ToString.ToUpper
        objAppConfig = Nothing

    End Sub

    Private Sub bsaSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaSeleccionar.Click
        Dim I As Integer
        For I = 0 To dgvPreFactura.RowCount - 1
            dgvPreFactura.Item(0, I).Value = "X"
        Next

    End Sub

    Private Sub bsaNoSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaNoSeleccionar.Click
        Dim I As Integer
        For I = 0 To dgvPreFactura.RowCount - 1
            dgvPreFactura.Item(0, I).Value = "-"
        Next
    End Sub
End Class
