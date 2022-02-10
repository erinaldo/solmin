Imports RANSA.NEGO.slnSOLMIN_SDSW
Imports RANSA.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports RANSA.NEGO.slnSOLMIN_SDSW_FILTRO
Public Class frmSDSWRecepcionSDS
#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        'Agregado para Almaceneras
        ANULAR
        'GENERAR
        'RESTAURAR
    End Enum
#End Region

#Region " Atributos "
    Private booStatus As Boolean = False
    Private blnRealizarRecepcion As Boolean = False
    Private blnStatusNuevoAcoplado As Boolean = False
    Private intWidth As Integer = 0
    '-- Tipo de Movimiento
    Private strTipoMovimiento_STPING As String = ""
    Private strDetalleTipoMovimiento_TTPING As String = ""
    '-- Desglose
    Private strDesglose_CTPOCN As String = "N"
    '-- Tipo Almacen
    Private strTipoAlmacen_CTPALM As String = ""
    Private strDetalleTipoAlmacen_TALMC As String = ""
    Private strAlmacen_CALMC As String = ""
    Private strDetalleAlmacen_TCMPAL As String = ""
    '-- Persiana
    Private strPersiana As String = ""
    '-- Contiene la información de la Cabecera
    Private objMovimientoMercaderia As clsSDSWMovimientoMercaderia
    Private objMovimientoTicket As clsSDSWMovimientoTicket
#End Region

#Region " Propiedades "

#End Region

#Region " Procedimientos y Funciones "
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
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim objFiltro As clsFiltro_SDSWListarMercaderia = New clsFiltro_SDSWListarMercaderia
            With objFiltro
                Int64.TryParse("" & txtCliente.Tag, .pintCodigoCliente_CCLNT)
                .pstrCodigoFamilia_CFMCLR = "" & txtFamilia.Tag
                .pstrCodigoGrupo_CGRCLR = "" & txtGrupo.Tag
                '.pstrCodigoMercaderia_CMRCLR = txtMercaderia.Text
                'Date.TryParse(txtFechaVencimiento.Text, .pdteFechaVencimiento_FVNCMR)
                'Date.TryParse(txtFechaInventario.Text, .pdteFechaInventario_FINVRN)
                'If cbxPublicarWEB.Text <> "" And cbxPublicarWEB.Text = "SI" Then _
                ' .pblnStatusPublicacionWEB_FPUWEB = True
                ' If cbxPublicarWEB.Text <> "" And cbxPublicarWEB.Text = "NO" Then _
                ' .pblnStatusPublicacionWEB_FPUWEB = False
            End With

            blnRealizarRecepcion = False
            dgMercaderias.DataSource = mfdtListar_SDSWMercaderias(objFiltro)

            '-- Se libera los procesos automáticos
            booStatus = True
            Cursor = System.Windows.Forms.Cursors.Arrow
            '-- Se habilita el botón para realizar una nueva recepcion
            bsaRealizarRecepcion.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            '-- Limpiamos la información de la cabecera
            objMovimientoMercaderia = Nothing
            hgOS.Visible = False
            'hgMercaderiaSeleccionada.Visible = False
            kpnuevo.Visible = False
            hgOS.Visible = False
            txtCliente.Enabled = True
            txtFamilia.Enabled = True
            txtGrupo.Enabled = True
            lblRegimen.Text = ""

            bsaClienteListar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            bsaFamiliaListar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            bsaGrupoListar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True

            Call pPersiana("I")
            grpLeyenda.Visible = False
            Call pOcultarInformacionCabecera(False)
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("RECSDS_ClienteNombre", txtCliente.Text)
            objAppConfig.SetValue("RECSDS_ClienteCodigo", txtCliente.Tag)
            objAppConfig = Nothing
        End If
    End Sub

    Private Sub pActualizaTicket()
        objMovimientoTicket = Nothing
        dtTicket.Rows.Clear()
        objMovimientoTicket = New clsSDSWMovimientoTicket
    End Sub

    Private Sub pAdministrarMercaderia()
        If txtCliente.Text <> "" Then
            Dim fMercaderiaSDS As frmMercaderiaSDS = New frmMercaderiaSDS
            With fMercaderiaSDS
                .pintCodigoCliente_CCLNT = txtCliente.Tag
                .pstrRazonSocial_TCMPCL = txtCliente.Text
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Call pActualizarInformacion()
                End If
            End With
        End If
    End Sub
    'Agregado para Almaceneras
    Private Sub pAdministrarImpresion()
        'If txtCliente.Text <> "" Then
        Dim fImpresionOS As frmSDSWImpresionOS = New frmSDSWImpresionOS
        With fImpresionOS
            '    .pintCodigoCliente_CCLNT = txtCliente.Tag
            '    .pstrRazonSocial_TCMPCL = txtCliente.Text
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Call pActualizarInformacion()
            End If
        End With
        'End If

    End Sub

    'Agregado para Almaceneras
    Private Sub pAdministrarMercaderiaW()
        '  If txtCliente.Text <> "" Then
        Dim fMercaderiaSDSW As frmSDSWMercaderia = New frmSDSWMercaderia
        With fMercaderiaSDSW
            .pintCodigoCliente_CCLNT = txtCliente.Tag
            .pstrRazonSocial_TCMPCL = txtCliente.Text
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Call pActualizarInformacion()
            End If
        End With
        'End If
    End Sub
    Private Sub pConsulta()
        'If txtCliente.Text <> "" Then
        '    Dim fConsulta As frmConsulta = New frmConsulta
        '    With fConsulta
        '        .pintCodigoCliente_CCLNT = txtCliente.Tag
        '        .pstrRazonSocial_TCMPCL = txtCliente.Text
        '        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        '            Call pActualizarInformacion()
        '        End If
        '    End With
        'End If
        frmCuadreOS.Show()

    End Sub
    Private Sub pCerrarCrearOS()
        ' Ponemos la persiana lista para realizar la recepción
        Call pPersiana("I")
        ' Limpiamos los controles
        dgContratosVigentes.DataSource = Nothing
        txtCantidad.Clear()
        txtUnidadCantidad.Clear()
        txtPeso.Clear()
        txtUnidadPeso.Clear()
        txtValor.Clear()
        txtUnidadValor.Clear()
        cbxControlLote.Checked = False
        bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub

    Private Sub pMercadería_KeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            'Case Keys.F2
            '    Call pGuardarMercadería()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub pModificarMercaderia()
        If txtCliente.Text <> "" Then
            If dgMercaderias.RowCount > 0 Then
                Dim fMercaderiaSDS As frmMercaderiaSDS = New frmMercaderiaSDS
                Dim strFamilia As String = ""
                Dim strGrupo As String = ""
                Dim strTemp As String = ""
                With fMercaderiaSDS
                    '-- Cliente
                    .pintCodigoCliente_CCLNT = "" & txtCliente.Tag
                    .pstrRazonSocial_TCMPCL = txtCliente.Text
                    '-- Hallando detalle de Familia
                    strFamilia = dgMercaderias.CurrentRow.Cells("M_CFMCLR").Value.ToString.Trim
                    .pstrCodigoFamilia_CFMCLR = strFamilia
                    mfblnObtenerDetalle_SDSWFamilia("" & txtCliente.Tag, strFamilia, strTemp)
                    .pstrDescripcionFamilia_TFMCLR = strTemp
                    '-- Hallando detalle de Grupo
                    strGrupo = dgMercaderias.CurrentRow.Cells("M_CGRCLR").Value.ToString.Trim
                    .pstrCodigoGrupo_CGRCLR = strGrupo
                    mfblnObtenerDetalle_SDSWGrupo("" & txtCliente.Tag, strFamilia, strGrupo, strTemp)
                    .pstrDescripcionGrupo_TGRCLR = strTemp
                    '-- Asignación de Mercaderia
                    .pstrCodigoMercaderia_CMRCLR = dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value.ToString.Trim
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Call pActualizarInformacion()
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub pOcultarInformacionCabecera(ByVal blnStatus As Boolean)
        If blnStatus Then
            hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
            hgOS.Width = 25
            'bsaOcultar.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
            'bsaOcultar.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.FixedRight
            'bsaOcultar.Text = "Visualizar"
        Else
            hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
            hgOS.Width = intWidth
            'bsaOcultar.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
            'bsaOcultar.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
            'bsaOcultar.Text = "Ocultar"
        End If
    End Sub

    Private Sub pPersiana(Optional ByVal strPersianaActual As String = "")
        If strPersianaActual <> "" Then strPersiana = strPersianaActual
        Select Case strPersiana
            Case "I" ' Ingreso de Mercadería
                hgParametrosCrearOS.Height = 20
                hgParametrosCrearOS.Enabled = False
            Case "C" ' Crear O/S
                hgParametrosCrearOS.Enabled = True
                'hgParametrosCrearOS.Height = hgMercaderia.Height - 20
                hgParametrosCrearOS.Height = 257
        End Select
    End Sub

    Private Sub pProcesarRecepcion()
        If objMovimientoMercaderia.plstItemMovimientoMercaderia.Count <= 0 Then
            MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf objMovimientoTicket.plstItemticket.Count > 0 Then
            MessageBox.Show("No se puede generar, Primero grabe el ticket", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            If mfblnRecepcion_Mercaderia_SDSW(objMovimientoMercaderia) Then Call pActualizarInformacion()
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub
    Private Sub pProcesarTicket()
        If objMovimientoTicket.plstItemticket.Count <= 0 Then
            MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            mfblnRecepcion_Ticket_SDSW(objMovimientoTicket)
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
        dtTicket.Rows.Clear()
        objMovimientoTicket = Nothing
        objMovimientoTicket = New clsSDSWMovimientoTicket
    End Sub
    'Agregado para Almaceneras
    Private Sub pProceso_AnularOrdenServicio()
        'Agregado para Almaceneras
        ' Si elige NO entonces salimos del proceso
        If Not mfblnPreguntas(enumPregVarios.ORDEN_AnularOrden) Then Exit Sub
        If fblnValidaInformacion_AnularOS(eTipoValidacion.ANULAR) Then
            Dim objInformacionOrdenServicio As clsSDSWInformacionOrdenServicio = New clsSDSWInformacionOrdenServicio
            With objInformacionOrdenServicio
                Int64.TryParse("" & txtCliente.Tag, .pintCliente_CCLNT)
                .pintOrdenServicio_NORDSR = dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value.ToString.Trim
            End With
            'Busca si existe operaciones para la O/S
            If mfblnExiste_SDSWOrdenOperacion(Compania_Usuario, Division_Usuario, objInformacionOrdenServicio, False) = False Then
                mfblnAnular_SDSWOrdenServicio(objInformacionOrdenServicio)
                booStatus = False
                '-- Eliminamos el registro seleccionado
                dgListaOrdenesServicio.Rows.Remove(dgListaOrdenesServicio.CurrentRow)
                '-- Listamos las O/S
                dgListaOrdenesServicio.DataSource = mfdtListar_SDSWOrdenesServicioPorMercaderiaW(txtCliente.Tag, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
                booStatus = True
            End If
        End If
    End Sub
    'Agregado  para Almacenera
    Private Function fblnValidaInformacion_AnularOS(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.PROCESAR Then
            If txtCliente.Text = "" Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
        Else
            'Verifica si existe Mercaderia Agregada
            If dgMercaderiaSeleccionada.RowCount > 0 Then
                If dgMercaderiaSeleccionada.CurrentRow.Cells("S_NORDSR").Value.ToString.Trim = dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value.ToString.Trim Then
                    strMensajeError &= "No puede anular O/S primero grabe datos de Mercaderia" & vbNewLine
                End If
            End If
            'Verifica si existen agregado
            If dgticket.RowCount > 0 Then
                If dgticket.CurrentRow.Cells("NORDSR").Value.ToString.Trim = dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value.ToString.Trim Then
                    strMensajeError &= "No puede anular O/S primero grabe datos de Ticket" & vbNewLine
                End If
            End If
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Function pProcesarCrearOS() As Boolean
        Dim blnResultado As Boolean = True
        If Not fblnValidarInfNuevaOS() Then
            blnResultado = False
        Else
            Dim objNuevaOrdenServicio As clsSDSWCrearOrdenServicio = New clsSDSWCrearOrdenServicio
            With objNuevaOrdenServicio
                Int64.TryParse("" & txtCliente.Tag, .pintCodigoCliente_CCLNT)
                .pstrCodigoMercaderia_CMRCLR = dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value.ToString.Trim
                .pintNroContrato_NCNTR = dgContratosVigentes.CurrentRow.Cells("M_NCNTR").Value
                .pstrTipoDeposito_CTPDP3 = dgContratosVigentes.CurrentRow.Cells("M_CTPDP3").Value
                .pstrProducto_CTPPR1 = dgContratosVigentes.CurrentRow.Cells("M_CTPPR1").Value
                Decimal.TryParse(txtCantidad.Text, .pdecCantidadDeclarada_QMRCD)
                .pstrUnidadCantidad_CUNCND = txtUnidadCantidad.Text
                Decimal.TryParse(txtPeso.Text, .pdecPesoDeclarado_QPSMR)
                .pstrUnidadPeso_CUNPS0 = txtUnidadPeso.Text
                Decimal.TryParse(txtValor.Text, .pdecValorDeclarado_QVLMR)
                .pstrUnidadValor_CUNVLR = txtUnidadValor.Text
                .pstrControlLotes_FUNCTL = "N"
                If cbxControlLote.Checked = True Then .pstrControlLotes_FUNCTL = "S"
                .pstrUnidadDespacho_FUNDS = IIf(Me.cbxUnidadDespacho.Text = "CANTIDAD", "C", "P")
            End With
            blnResultado = mfblnCrear_SDSWOrdenServicio(objNuevaOrdenServicio)
            objNuevaOrdenServicio = Nothing
            If blnResultado Then Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Crear)
        End If
        Return blnResultado
    End Function


    Private Function fblnValidarInfNuevaOS() As Boolean
        Dim strResultado As String = ""
        Dim blnResultado As Boolean = True
        Dim decTemp As Decimal
        Decimal.TryParse(txtCantidad.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar una Cantidad mayor o igual a cero. " & vbNewLine
        If txtUnidadCantidad.Text = "" Then strResultado &= "No ha seleccionado una Unidad para la información de las Cantidades. " & vbNewLine
        Decimal.TryParse(txtPeso.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar un Peso mayor o igual a cero. " & vbNewLine
        If txtUnidadPeso.Text = "" Then strResultado &= "No ha seleccionado una Unidad para la información de los Pesos. " & vbNewLine
        Decimal.TryParse(txtValor.Text, decTemp)
        If decTemp < 0 Then strResultado &= "Debe ingresar un Valor mayor o igual a cero. " & vbNewLine
        If txtUnidadValor.Text = "" Then strResultado &= "No ha seleccionado una Unidad para la información del Valor. " & vbNewLine
        If cbxControlLote.Text = "" Then strResultado &= "No ha seleccionado la Unidad de Despacho . " & vbNewLine
        If strResultado <> "" Then
            MessageBox.Show(strResultado, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blnResultado = False
        End If
        Return blnResultado
    End Function
#End Region

#Region " Métodos "

    Private Sub bsaClienteListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaClienteListar.Click

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_ClienteSDSW(txtCliente.Tag, txtCliente.Text, "")
        lblcodcliente.Text = txtCliente.Tag
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub bsaFamiliaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaFamiliaListar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_SDSWFamilia(txtCliente.Tag, txtFamilia.Tag, txtFamilia.Text)
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub bsaGrupoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaGrupoListar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_SDSWGrupo(txtCliente.Tag, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click



        Call pActualizarInformacion()
    End Sub
    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        If mfblnSalirOpcion() Then
            Me.Close()
        End If
    End Sub

    Private Sub dgContratosVigentes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If dgContratosVigentes.CurrentRow Is Nothing Then Exit Sub
        txtUnidadCantidad.Text = dgContratosVigentes.CurrentRow.Cells("M_CUNCN3").Value
        txtUnidadCantidad.Tag = txtUnidadCantidad.Text
        txtUnidadPeso.Text = dgContratosVigentes.CurrentRow.Cells("M_CUNPS3").Value
        txtUnidadPeso.Tag = txtUnidadPeso.Text
        txtUnidadValor.Text = dgContratosVigentes.CurrentRow.Cells("M_CUNVL3").Value
        txtUnidadValor.Tag = txtUnidadPeso.Text
    End Sub
    Private Sub btnProcesarCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarCrearOS.Click

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If pProcesarCrearOS() Then
            Call pCerrarCrearOS()
            If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
                dgListaOrdenesServicio.DataSource = mfdtListar_SDSWOrdenesServicioPorMercaderiaW(txtCliente.Tag, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
            Else
                dgListaOrdenesServicio.DataSource = mfdtListar_SDSWOrdenesServicioPorMercaderia(txtCliente.Tag, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
            End If
            If dgListaOrdenesServicio.RowCount > 0 Then
                bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            Else
                bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            End If
        End If
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub frmRecepcionSDS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        Dim intCliente As Int64
        '-- Recuperamos los ultimos valores seleccionados
        txtCliente.Text = objAppConfig.GetValue("RECSDS_ClienteNombre", GetType(System.String)).ToString.ToUpper
        txtCliente.Tag = objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)).ToString.ToUpper
        lblcodcliente.Text = objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)).ToString.ToUpper
        intWidth = hgOS.Width
        objAppConfig = Nothing
        ' Obtengo los últimos almacenes para este cliente
        Int64.TryParse("" & txtCliente.Tag, intCliente)
        'Agregado para Almaceneras
        lblRegimen.Visible = False

        If Compania_Usuario <> "AM" And Compania_Usuario <> "LZ" Then bsaCerrarOrden.Visible = False
        Call mfblnObtener_InfUltimoAlmacenSegunCliente_SDSW(intCliente, strTipoAlmacen_CTPALM, strDetalleTipoAlmacen_TALMC, strAlmacen_CALMC, strDetalleAlmacen_TCMPAL)
        ' Obtengo el Tipo de Movimiento por defecto
        Call mfstrDefecto_TipoMovimientoRecepcion_SDSW(strTipoMovimiento_STPING, strDetalleTipoMovimiento_TTPING)
        kpnuevo.Visible = False

    End Sub
    Private Sub bsaListarUnidadCantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadCantidad.Text, "C")
        Cursor = System.Windows.Forms.Cursors.Arrow
        txtUnidadCantidad.Tag = txtUnidadCantidad.Text
    End Sub

    Private Sub bsaListarUnidadPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadPeso.Text, "P")
        Cursor = System.Windows.Forms.Cursors.Arrow
        txtUnidadPeso.Tag = txtUnidadPeso.Text
    End Sub
    Private Sub frmRecepcionSDS_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Call pPersiana()
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
        dgMercaderias.DataSource = Nothing
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

    Private Sub txtFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSWFamilia(txtCliente.Tag, txtFamilia.Tag, txtFamilia.Text)
        Else
            Call pMercadería_KeyDown(e)
        End If
    End Sub

    Private Sub txtFamilia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFamilia.TextChanged
        txtFamilia.Tag = ""
    End Sub

    Private Sub txtFamilia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFamilia.Validating
        If txtFamilia.Text = "" Then
            txtFamilia.Tag = ""
            Exit Sub
        Else
            If txtFamilia.Text <> "" And "" & txtFamilia.Tag = "" Then
                Call mfblnBuscar_SDSWFamilia(txtCliente.Tag, txtFamilia.Tag, txtFamilia.Text)
                If txtFamilia.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGrupo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_SDSWGrupo(txtCliente.Tag, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
            Cursor = System.Windows.Forms.Cursors.Arrow
        Else
            Call pMercadería_KeyDown(e)
        End If
    End Sub

    Private Sub txtGrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrupo.TextChanged
        txtGrupo.Tag = ""
    End Sub

    Private Sub txtGrupo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGrupo.Validating
        If txtGrupo.Text = "" Then
            txtGrupo.Tag = ""
            Exit Sub
        Else
            If txtGrupo.Text <> "" And "" & txtGrupo.Tag = "" Then
                Call mfblnBuscar_SDSWGrupo(txtCliente.Tag, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
                If txtGrupo.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    Private Sub txtUnidadCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadCantidad.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadCantidad.Text, "C")
            txtUnidadCantidad.Tag = txtUnidadCantidad.Text
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub txtUnidadCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidadCantidad.TextChanged
        txtUnidadCantidad.Tag = ""
    End Sub

    Private Sub txtUnidadCantidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidadCantidad.Validating
        If txtUnidadCantidad.Text = "" Then
            txtUnidadCantidad.Tag = ""
        Else
            If txtUnidadCantidad.Text <> "" And "" & txtUnidadCantidad.Tag = "" Then
                Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadCantidad.Text, "C")
                txtUnidadCantidad.Tag = txtUnidadCantidad.Text
                If txtUnidadCantidad.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtUnidadPeso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadPeso.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadPeso.Text, "P")
            txtUnidadPeso.Tag = txtUnidadPeso.Text
            Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub txtUnidadPeso_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnidadPeso.TextChanged
        txtUnidadPeso.Tag = ""
    End Sub

    Private Sub txtUnidadPeso_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidadPeso.Validating
        If txtUnidadPeso.Text = "" Then
            txtUnidadPeso.Tag = ""
        Else
            If txtUnidadPeso.Text <> "" And "" & txtUnidadPeso.Tag = "" Then
                Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadPeso.Text, "P")
                txtUnidadPeso.Tag = txtUnidadPeso.Text
                If txtUnidadPeso.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Public Sub refresca()
        'Agregado para almaceneras
        Dim strTicket As String = ""
        If mfblnBuscar_Ticket1SDSW(dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value, strTicket) Then
            dgNroTicket.Rows.Clear()
            dgNroTicket.Rows.Add()
            dgNroTicket.Rows(0).Cells(0).Value = strTicket
        End If
    End Sub

    Private Sub dgListaOrdenesServicio_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Call N_Orden()
    End Sub
    'Agregado para Alamceneras
    Public Sub N_Orden()
        'If Not dgListaOrdenesServicio.CurrentRow Is Nothing Then
        '    Dim intNroOrdenServicio As Int64
        '    Int64.TryParse("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value, intNroOrdenServicio)
        '    dgnorden.DataSource = mfdtListar_Norden(intNroOrdenServicio)
        '    If dgnorden.RowCount > 0 Then
        '        bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        '    Else
        '        bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        '    End If
        'End If
    End Sub
    Private Sub bsaRealizarRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaRealizarRecepcion.Click


        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If "" & txtCliente.Tag = "" Then Exit Sub
        If dgMercaderias.RowCount <= 0 Then Exit Sub

        ' Procedemos a habilitar los controles para el registro de la recepción
        objMovimientoMercaderia = New clsSDSWMovimientoMercaderia
        objMovimientoTicket = New clsSDSWMovimientoTicket
        dtMercaderiaSeleccionadas.Rows.Clear()
        dtTicket.Rows.Clear()
        hgOS.Visible = True
        hgMercaderiaSeleccionada.Visible = True
        kpnuevo.Visible = True
        Call pPersiana("I")
        bsaRealizarRecepcion.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        blnRealizarRecepcion = True
        'Agregado para Almaceneras
        If Compania_Usuario = "LZ" Or Compania_Usuario = "AM" Then
            Dim fSolicTipoRegimen As frmSDSWRegimen = New frmSDSWRegimen
            With fSolicTipoRegimen
                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    objMovimientoMercaderia.pintCADNA = fSolicTipoRegimen.txtaduana.Tag
                    objMovimientoMercaderia.pintNANDCL = fSolicTipoRegimen.txtanioaduana.Text
                    objMovimientoMercaderia.pintNPDUA = fSolicTipoRegimen.txtdua.Text
                    objMovimientoMercaderia.pstrCRGMN = fSolicTipoRegimen.lblregimen.Text
                    If fSolicTipoRegimen.lblregimen.Text = "A" Then
                        lblRegimen.Text = "Regimen Aduanero"
                    Else
                        lblRegimen.Text = "Regimen Simple"
                    End If
                    lblRegimen.Visible = True
                End If
                .Dispose()
                fSolicTipoRegimen = Nothing
            End With
        End If

        'Agregado para Almaceneras
        If Compania_Usuario = "LZ" Or Compania_Usuario = "AM" Then
            dgListaOrdenesServicio.DataSource = mfdtListar_SDSWOrdenesServicioPorMercaderiaW(txtCliente.Tag, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
        Else
            dgListaOrdenesServicio.DataSource = mfdtListar_SDSWOrdenesServicioPorMercaderia(txtCliente.Tag, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
        End If
        If dgListaOrdenesServicio.RowCount > 0 Then
            bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            bsaAgregaTicket.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            bsaAnularOrden.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        Else
            bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            bsaAgregaTicket.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            bsaAnularOrden.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End If
        If Compania_Usuario <> "AM" And Compania_Usuario <> "LZ" Then grpLeyenda.Visible = True

        bsaProcesarRecepcion.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        bsaProcesar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        bsaEliminarMercaderia.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        bsaBorrarTicket.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub bsaMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaMercaderia.Click


        If Compania_Usuario = "AM" Or Compania_Usuario = "LZ" Then
            Call pAdministrarMercaderiaW()
        Else
            Call pAdministrarMercaderia()
        End If
    End Sub

    Private Sub bsaAgregaMercaderiaOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAgregaMercaderiaOS.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If dgListaOrdenesServicio.RowCount <= 0 Then Exit Sub
        If dgMercaderiaSeleccionada.RowCount > 0 Then

            For Each objItemMovimientoMercaderia As clsSDSWItemMovimientoMercaderia In objMovimientoMercaderia.plstItemMovimientoMercaderia
                If objItemMovimientoMercaderia.pintOrdenServicio_NORDSR = dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value Then
                    MessageBox.Show("No se puede agregar la misma mercaderia para una misma Orden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Exit Sub
                End If
            Next
        End If

        Dim fSolicInforMovAlmacen As frmSDSWSolicInforRecAlmacen = New frmSDSWSolicInforRecAlmacen

        If objMovimientoMercaderia.pstrCRGMN = "A" Then
            fSolicInforMovAlmacen.txtserie.Enabled = True

        Else
            fSolicInforMovAlmacen.txtserie.Enabled = False
        End If

        fSolicInforMovAlmacen.txtRecCantidad.Text = dgListaOrdenesServicio.CurrentRow.Cells("QMRCD1").Value

        If txtCliente.Tag = "12060" Then
            Dim Datos As DataTable
            Datos = mfblnBusca_OrdenAmcor(dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value)
            If Datos.Rows.Count > 0 Then
                fSolicInforMovAlmacen.txtTipoAlmacen.Text = Datos.Rows(0).Item(0).ToString()

                Call mfblnBuscar_TipoAlmacenSDSW(fSolicInforMovAlmacen.txtTipoAlmacen.Tag, fSolicInforMovAlmacen.txtTipoAlmacen.Text)

                fSolicInforMovAlmacen.txtAlmacen.Text = Datos.Rows(0).Item(1).ToString()

                Call mfblnBuscar_AlmacenSDSW("" & fSolicInforMovAlmacen.txtTipoAlmacen.Tag, fSolicInforMovAlmacen.txtAlmacen.Tag, fSolicInforMovAlmacen.txtAlmacen.Text)

                fSolicInforMovAlmacen.txtZonaAlmacen.Text = Datos.Rows(0).Item(2).ToString()

                Call mfblnBuscar_ZonasAlmacenSDSW("" & fSolicInforMovAlmacen.txtTipoAlmacen.Tag, "" & fSolicInforMovAlmacen.txtAlmacen.Tag, fSolicInforMovAlmacen.txtZonaAlmacen.Tag, fSolicInforMovAlmacen.txtZonaAlmacen.Text)
            End If           
        End If

        Cursor = System.Windows.Forms.Cursors.Arrow
        With fSolicInforMovAlmacen
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' INICIO
                Dim rwTemp As DataRow = dtMercaderiaSeleccionadas.NewRow
                With rwTemp
                    rwTemp.Item("CMRCLR") = dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value
                    rwTemp.Item("TMRCD2") = dgMercaderias.CurrentRow.Cells("M_TMRCD2").Value
                    rwTemp.Item("CMRCD") = dgMercaderias.CurrentRow.Cells("M_CMRCD").Value
                    rwTemp.Item("NORDSR") = dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value
                    rwTemp.Item("NCNTR") = dgListaOrdenesServicio.CurrentRow.Cells("O_NCNTR").Value
                    rwTemp.Item("NCRCTC") = dgListaOrdenesServicio.CurrentRow.Cells("O_NCRCTC").Value
                    rwTemp.Item("NAUTR") = dgListaOrdenesServicio.CurrentRow.Cells("O_NAUTR").Value
                    rwTemp.Item("CUNCNT") = dgListaOrdenesServicio.CurrentRow.Cells("O_CUNCN5").Value
                    rwTemp.Item("CUNPST") = dgListaOrdenesServicio.CurrentRow.Cells("O_CUNPS5").Value
                    rwTemp.Item("CUNVLT") = dgListaOrdenesServicio.CurrentRow.Cells("O_CUNVL5").Value
                    rwTemp.Item("NORCCL") = fSolicInforMovAlmacen.pstrNroOrdenCompra
                    rwTemp.Item("NGUICL") = fSolicInforMovAlmacen.pstrNroGuiaCliente
                    rwTemp.Item("NRUCLL") = fSolicInforMovAlmacen.pstrNroRUCCliente
                    rwTemp.Item("STPING") = fSolicInforMovAlmacen.pstrTipoRecepcion
                    rwTemp.Item("CTPALM") = fSolicInforMovAlmacen.pstrTipoAlmacen
                    rwTemp.Item("TALMC") = fSolicInforMovAlmacen.pstrDetalleAlmacen
                    rwTemp.Item("CALMC") = fSolicInforMovAlmacen.pstrAlmacen
                    rwTemp.Item("TCMPAL") = fSolicInforMovAlmacen.pstrDetalleTipoAlmacen
                    rwTemp.Item("CZNALM") = fSolicInforMovAlmacen.pstrZonaAlmacen
                    rwTemp.Item("TCMZNA") = fSolicInforMovAlmacen.pstrDetalleZonaAlmacen
                    rwTemp.Item("QTRMC") = fSolicInforMovAlmacen.pdecRecCantidad
                    rwTemp.Item("QTRMP") = fSolicInforMovAlmacen.pdecRecPeso
                    'rwTemp.Item("QDSVGN")=
                    rwTemp.Item("CCNTD") = fSolicInforMovAlmacen.pstrContenedor
                    rwTemp.Item("CTPOCN") = IIf(fSolicInforMovAlmacen.pblnDesglose, "SI", "NO")
                    rwTemp.Item("FUNDS2") = dgListaOrdenesServicio.CurrentRow.Cells("O_FUNDS2").Value
                    rwTemp.Item("CTPDPS") = dgListaOrdenesServicio.CurrentRow.Cells("O_CTPDP6").Value
                    rwTemp.Item("TOBSRV") = fSolicInforMovAlmacen.pstrRecObservacion
                    rwTemp.Item("NSERIE") = fSolicInforMovAlmacen.pstrSerie
                    ' rwTemp.Item("CCMPN") = Compania_Usuario
                End With
                dtMercaderiaSeleccionadas.Rows.Add(rwTemp)

                Dim objTemp As clsSDSWItemMovimientoMercaderia = New clsSDSWItemMovimientoMercaderia
                With objTemp
                    Int64.TryParse(("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value).ToString.Trim, .pintOrdenServicio_NORDSR)
                    Int64.TryParse(("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NCNTR").Value).ToString.Trim, .pintNroContrato_NCNTR)
                    Int64.TryParse(("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NCRCTC").Value).ToString.Trim, .pintNroCorrDetalleContrato_NCRCTC)
                    Int64.TryParse(("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NAUTR").Value).ToString.Trim, .pintNroAutorizacion_NAUTR)
                    .pstrCodigoMercaderia_CMRCLR = ("" & dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value).ToString.Trim
                    .pstrCodigoRANSA_CMRCD = ("" & dgMercaderias.CurrentRow.Cells("M_CMRCD").Value).ToString.Trim

                    .pstrNroOrdenCompraCliente_NORCCL = fSolicInforMovAlmacen.pstrNroOrdenCompra
                    .pstrNroGuiaCliente_NGUICL = fSolicInforMovAlmacen.pstrNroGuiaCliente
                    .pstrNroRUCCliente_NRUCLL = fSolicInforMovAlmacen.pstrNroRUCCliente

                    .pstrTipoAlmacen_CTPALM = fSolicInforMovAlmacen.pstrTipoAlmacen
                    .pstrAlmacen_CALMC = fSolicInforMovAlmacen.pstrAlmacen
                    .pstrZonaAlmacen_CZNALM = fSolicInforMovAlmacen.pstrZonaAlmacen

                    Decimal.TryParse(fSolicInforMovAlmacen.pdecRecCantidad, .pdecCantidad_QTRMC)
                    Decimal.TryParse(fSolicInforMovAlmacen.pdecRecPeso, .pdecPeso_QTRMP)
                    .pstrUnidadCantidad_CUNCNT = ("" & dgListaOrdenesServicio.CurrentRow.Cells("O_CUNCN5").Value).ToString.Trim
                    .pstrUnidadPeso_CUNPST = ("" & dgListaOrdenesServicio.CurrentRow.Cells("O_CUNPS5").Value).ToString.Trim
                    .pstrUnidadValorTransaccion_CUNVLT = ("" & dgListaOrdenesServicio.CurrentRow.Cells("O_CUNVL5").Value).ToString.Trim

                    .pblnDesglose_CTPOCN = fSolicInforMovAlmacen.pblnDesglose
                    .pstrContenedor_CCNTD = fSolicInforMovAlmacen.pstrContenedor
                    .pstrTipoMovimiento_STPING = fSolicInforMovAlmacen.pstrTipoRecepcion

                    .pstrSatusUnidadDespacho_FUNDS2 = ("" & dgListaOrdenesServicio.CurrentRow.Cells("O_FUNDS2").Value).ToString.Trim
                    .pstrTipoDeposito_CTPDPS = ("" & dgListaOrdenesServicio.CurrentRow.Cells("O_CTPDP6").Value).ToString.Trim
                    .pstrObservaciones_TOBSRV = fSolicInforMovAlmacen.pstrRecObservacion
                    .pstrCaracteristicas_TOBSRL = fSolicInforMovAlmacen.pstrRecCaracteristicas
                    Date.TryParse(fSolicInforMovAlmacen.pstrRecFechaIngreso, .pdteFechaIngreso_FRLZSR)

                    Date.TryParse(fSolicInforMovAlmacen.pstrRecFechaSalida, .pdteFechaSalida_FCNTSL)
                    .pintSerie_NSRIE = fSolicInforMovAlmacen.pstrSerie

                End With
                objMovimientoMercaderia.AddItemMovimientoMercaderia(objTemp)
                dgMercaderias.CurrentRow.DefaultCellStyle.BackColor = Color.LightSeaGreen

                'Deshabilita los botones del cliente hasta que grabe el proceso de recepcion
                txtCliente.Enabled = False
                txtFamilia.Enabled = False
                txtGrupo.Enabled = False
                bsaClienteListar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                bsaFamiliaListar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                bsaGrupoListar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                bsaProcesarRecepcion.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                bsaEliminarMercaderia.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            End If
            .Dispose()
            fSolicInforMovAlmacen = Nothing
        End With
    End Sub
    Private Sub bsaCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCrearOS.Click


        'If "" & txtCliente.Tag = "" Then Exit Sub
        '' Obtenemos los contratos vigentes del cliente
        'dgContratosVigentes.DataSource = mfdtListar_ContratosVigentes(txtCliente.Tag)
        '' Si no tuviese contratos vigentes, mostramos el mensaje de que no existe información
        'If dgContratosVigentes.RowCount <= 0 Then
        '    Call mpMsjeVarios(enumMsjVarios.DATA_NoExisteInformacion)
        'Else
        '    ' Inicializamos las persinas
        '    Call pPersiana("C")
        '    bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        '    bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        'End If

        If "" & txtCliente.Tag = "" Then Exit Sub
        ' Obtenemos los contratos vigentes del cliente
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        dgContratosVigentes.DataSource = mfdtListar_ContratosVigentes_SDSW(txtCliente.Tag)
        Cursor = System.Windows.Forms.Cursors.Arrow
        ' Si no tuviese contratos vigentes, mostramos el mensaje de que no existe información
        If dgContratosVigentes.RowCount <= 0 Then
            Call mpMsjeVarios(enumMsjVarios.DATA_NoExisteInformacion)
        Else
            ' Inicializamos las persinas
            Call pPersiana("C")
            bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End If

    End Sub

    'Private Sub bsaOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaOcultar.Click
    '    'If hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top Then
    '    '    Call pOcultarInformacionCabecera(True)
    '    'Else
    '    '    Call pOcultarInformacionCabecera(False)
    '    'End If
    'End Sub

    Private Sub bsaCerrarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarOrden.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If mfblnPreguntas(enumPregVarios.PROCESO_Cerrar) Then
            Dim blnResultado As Boolean = True
            Dim objOrdenServicio As clsSDSWMovimientoMercaderia = New clsSDSWMovimientoMercaderia
            With objOrdenServicio
                Int64.TryParse("" & txtCliente.Tag, .pintCodigoCliente_CCLNT)
                .pintOrdenServicio_NORDEN = dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value
            End With
            blnResultado = mfblnCerrar_SDSWOrdenServicio(objOrdenServicio)
            objOrdenServicio = Nothing
            If blnResultado Then Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Cerrar)
            dgListaOrdenesServicio.DataSource = mfdtListar_SDSWOrdenesServicioPorMercaderiaW(txtCliente.Tag, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
        End If
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub bsaAgregaTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAgregaTicket.Click

        'Agregado para Almaceneras
        If dgListaOrdenesServicio.RowCount <= 0 Then Exit Sub

        If dgticket.RowCount > 0 Then
            If dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value.ToString.Trim <> dgticket.CurrentRow.Cells("NORDSR").Value.ToString.Trim Then
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
                    rwTemp.Item("NORDSR") = dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value
                    rwTemp.Item("CSRVNV") = fSolicInforticket.pstrTipoServicio
                    rwTemp.Item("HORAINI") = fSolicInforticket.pintHoraInicio
                    rwTemp.Item("HORAFIN") = fSolicInforticket.pintHorafinal
                    rwTemp.Item("FATNSR") = fSolicInforticket.pstrFecha
                    rwTemp.Item("NHRCAL") = fSolicInforticket.pdecHoraCalculada
                    rwTemp.Item("NHRFAC") = fSolicInforticket.pdecHoraFacturada
                    rwTemp.Item("OBSER") = fSolicInforticket.pstrobser

                    'rwTemp.Item("NCRRLT") = fSolicInforticket.pintCorrelativo
                    'Campos del mercaderias seleccionadas
                End With
                dtTicket.Rows.Add(rwTemp)

                Dim objTemp As clsSDSWItemTicket = New clsSDSWItemTicket
                With objTemp
                    Int64.TryParse(("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value).ToString.Trim, .pintOrdenServicio_NORDSR)
                    .pstrTipoServicio_CSRVNV = fSolicInforticket.pstrTipoServicio
                    .pintHoraInicio_HORAINI = fSolicInforticket.pintHoraInicio
                    .pintHoraFin_HORAFIN = fSolicInforticket.pintHorafinal
                    Date.TryParse(fSolicInforticket.pstrFecha, .pdteFechaAtencion_FATNSR)
                    Decimal.TryParse(fSolicInforticket.pdecHoraCalculada, .pdecHoraCalculada_NHRCAL)
                    Decimal.TryParse(fSolicInforticket.pdecHoraFacturada, .pdecHoraFacturada_NHRFAC)
                    .pstrObservacion_OBSER = fSolicInforticket.pstrobser
                End With
                objMovimientoTicket.AddItemTicket(objTemp)
                dgListaOrdenesServicio.CurrentRow.DefaultCellStyle.BackColor = Color.LightSeaGreen
                bsaProcesar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                bsaBorrarTicket.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            End If

            .Dispose()
            fSolicInforticket = Nothing

        End With
    End Sub

    Private Sub dgMercaderias_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMercaderias.CurrentCellChanged
        If blnRealizarRecepcion Then
            If bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False Then Call pCerrarCrearOS()
            'Agregado para Almaceneras
            If Compania_Usuario = "LZ" Or Compania_Usuario = "AM" Then
                dgListaOrdenesServicio.DataSource = mfdtListar_SDSWOrdenesServicioPorMercaderiaW(IIf(txtCliente.Tag = "", 0, txtCliente.Tag), dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
            Else
                dgListaOrdenesServicio.DataSource = mfdtListar_SDSWOrdenesServicioPorMercaderia(txtCliente.Tag, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
            End If
            If dgListaOrdenesServicio.RowCount > 0 Then
                'dgnorden.DataSource = mfdtListar_Norden(dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value)
                bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                bsaAgregaTicket.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                bsaAnularOrden.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            Else
                bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                bsaAgregaTicket.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                bsaAnularOrden.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            End If
        End If
    End Sub
    Private Sub bsaProcesarRecepcion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsaProcesarRecepcion.Click


        Dim fIniciarMovAlmacen As frmIniciarMovAlmacen = New frmIniciarMovAlmacen
        With fIniciarMovAlmacen

            .pintCodigoCliente = txtCliente.Tag
            .pstrRazonSocialCliente = txtCliente.Text
            ' modificar luego
            .pintServicio = 2
            .pstrAdicinarInfTitulo = "Despacho"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Obtenemos la información de la cabecera registrada
                objMovimientoMercaderia.pintCodigoCliente_CCLNT = .pobjInformacionIngresada.pintCodigoCliente_CCLNT
                objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL = .pobjInformacionIngresada.pstrRazonSocialCliente_TCMPCL
                objMovimientoMercaderia.pstrRazonSocialEmpTransporte_TCMPTR = .pobjInformacionIngresada.pstrRazonSocialEmpTransporte_TCMPTR
                objMovimientoMercaderia.pstrMarcaUnidad_TMRCCM = .pobjInformacionIngresada.pstrMarcaUnidad_TMRCCM
                objMovimientoMercaderia.pstrNroBrevete_NBRVCH = .pobjInformacionIngresada.pstrNroBrevete_NBRVCH
                objMovimientoMercaderia.pstrObservaciones_TOBSER = .pobjInformacionIngresada.pstrObservaciones_TOBSER
                objMovimientoMercaderia.pstrCompania_CCMPN = Compania_Usuario

                ' Procedemos con el procesamiento de la información
                Call pProcesarRecepcion()
            End If
            .Dispose()
            fIniciarMovAlmacen = Nothing
        End With
    End Sub

    Private Sub bsaBorrarTicket_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsaBorrarTicket.Click

        Dim objTemp As clsSDSWItemTicket = New clsSDSWItemTicket
        objMovimientoTicket.DeleteIndexTicket(dgticket.CurrentRow.Index, objTemp)
        dgticket.Rows.Remove(dgticket.CurrentRow)
    End Sub

    Private Sub bsaEliminarMercaderia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsaEliminarMercaderia.Click
        Dim objTemp As clsSDSWItemMovimientoMercaderia = New clsSDSWItemMovimientoMercaderia
        objMovimientoMercaderia.DeleteIndexMercaderia(dgMercaderiaSeleccionada.CurrentRow.Index, objTemp)
        dgMercaderiaSeleccionada.Rows.Remove(dgMercaderiaSeleccionada.CurrentRow)
    End Sub

    Private Sub bsaProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesar.Click



        ' Procedemos con el procesamiento de la información
        Dim fObservacionTicket As frmSDSWObservacionTicket = New frmSDSWObservacionTicket
        fObservacionTicket.cbxTipo.Text = "I"
        fObservacionTicket.cbxTipo.Visible = False
        fObservacionTicket.lbltipo.Visible = False
        If mfblnExiste_RubroTicket_SDSW(Compania_Usuario, Division_Usuario, txtCliente.Tag, objMovimientoTicket, True) Then
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
        End If

    End Sub

    Private Sub btnCancelarCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarCrearOS.Click
        Call pCerrarCrearOS()
    End Sub

    Private Sub bsaListarUnidadCantidad_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaListarUnidadCantidad.Click

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadCantidad.Text, "C")
        txtUnidadCantidad.Tag = txtUnidadCantidad.Text
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub bsaListarUnidadPeso_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaListarUnidadPeso.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call mfblnBuscar_UnidadMedidaSDSW(txtUnidadPeso.Text, "P")
        txtUnidadPeso.Tag = txtUnidadPeso.Text
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub bsaConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaConsulta.Click
        'Call pConsulta()
        'FrmPrueba.Show()
        With frmRepInventario
            .Show()
        End With
    End Sub
    Private Sub dgContratosVigentes_CurrentCellChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgContratosVigentes.CurrentCellChanged
        If dgContratosVigentes.CurrentRow Is Nothing Then Exit Sub
        txtUnidadCantidad.Text = dgContratosVigentes.CurrentRow.Cells("M_CUNCN3").Value
        txtUnidadCantidad.Tag = txtUnidadCantidad.Text
        txtUnidadPeso.Text = dgContratosVigentes.CurrentRow.Cells("M_CUNPS3").Value
        txtUnidadPeso.Tag = txtUnidadPeso.Text
        txtUnidadValor.Text = dgContratosVigentes.CurrentRow.Cells("M_CUNVL3").Value
        txtUnidadValor.Tag = txtUnidadPeso.Text
    End Sub

    Private Sub bsaAnularOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAnularOrden.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call pProceso_AnularOrdenServicio()
        Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
    Private Sub bsaImpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaImpresion.Click

        Call pAdministrarImpresion()
    End Sub

#End Region

    Private Sub bsaBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaBuscar.Click

        With frmSDSWBuscaOS
            .Show()
            .flag = "R"
        End With
    End Sub
    Private Sub bsaEditarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEditarOS.Click
        If dgListaOrdenesServicio.RowCount > 0 Then
            With frmSDSWEditaOS
                .Show()
                .txtCantidad.Text = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_QSLMC").Value
                .txtPeso.Text = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_QSLMP").Value
                .txtUnidadCantidad.Text = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_CUNCN5").Value
                .txtUnidadPeso.Text = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_CUNPS5").Value
                .Orden = Me.dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value
            End With
        End If
    End Sub

    Private Sub dgMercaderias_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderias.CellContentClick

    End Sub
End Class