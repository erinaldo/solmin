Imports Ransa.NEGO
Imports Ransa.TYPEDEF
'Imports Ransa.TYPEDEF.Cliente
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.NEGO.slnSOLMIN_SDS.RecepcionSDS
Imports Ransa.Utilitario
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Public Class frmRecepcionSDS
#Region " Tipo de Datos "
    Enum eTipoValidacion
        PROCESAR
        'ANULAR
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
    Private objMovimientoMercaderia As clsMovimientoMercaderia
#End Region
#Region " Propiedades "

#End Region
#Region " Procedimientos y Funciones "
    Private Function fblnValidaInformacion(ByVal eValidacion As eTipoValidacion) As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If eValidacion = eTipoValidacion.PROCESAR Then
            If txtCliente.pCodigo = 0 Then strMensajeError &= "No han seleccionado el cliente. " & vbNewLine
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
            Dim objFiltro As clsFiltro_ListarMercaderia = New clsFiltro_ListarMercaderia
            With objFiltro
                .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                .pstrCodigoFamilia_CFMCLR = "" & txtFamilia.Tag
                .pstrCodigoGrupo_CGRCLR = "" & txtGrupo.Tag
                .pstrCodigoMercaderia_CMRCLR = txtMercaderia.Text
                Date.TryParse(txtFechaVencimiento.Text, .pdteFechaVencimiento_FVNCMR)
                Date.TryParse(txtFechaInventario.Text, .pdteFechaInventario_FINVRN)
                If cbxPublicarWEB.Text <> "" And cbxPublicarWEB.Text = "SI" Then _
                    .pblnStatusPublicacionWEB_FPUWEB = True
                If cbxPublicarWEB.Text <> "" And cbxPublicarWEB.Text = "NO" Then _
                    .pblnStatusPublicacionWEB_FPUWEB = False
            End With
            blnRealizarRecepcion = False
            dgMercaderias.DataSource = mfdtListar_Mercaderias(objFiltro)
            '-- Se libera los procesos automáticos
            booStatus = True
            '-- Se habilita el botón para realizar una nueva recepcion
            btnRealizarRecepcion.Visible = True
            txtBuscarMercaderia.ReadOnly = True
            '-- Limpiamos la información de la cabecera
            objMovimientoMercaderia = Nothing
            hgOS.Visible = False
            hgMercaderiaSeleccionada.Visible = False
            Call pPersiana("I")
            grpLeyenda.Visible = False
            Call pOcultarInformacionCabecera(False)
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("RECSDS_ClienteCodigo", txtCliente.pCodigo)
            objAppConfig = Nothing
        End If
    End Sub

    Private Sub pAdministrarMercaderia()
        If txtCliente.pCodigo <> 0 Then
            Dim fMercaderiaSDS As frmMercaderiaSDS = New frmMercaderiaSDS
            With fMercaderiaSDS
                .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                .pstrRazonSocial_TCMPCL = txtCliente.pRazonSocial
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Call pActualizarInformacion()
                End If
            End With
        End If
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
        bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub

    Private Sub pCerrarModificarOS()
        ' Ponemos la persiana lista para realizar la recepción
        Call pPersiana("I")
        ' Limpiamos los controles      
        bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
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
        If txtCliente.pCodigo <> 0 Then
            If dgMercaderias.RowCount > 0 Then
                Dim fMercaderiaSDS As frmMercaderiaSDS = New frmMercaderiaSDS
                Dim strFamilia As String = ""
                Dim strGrupo As String = ""
                Dim strTemp As String = ""
                With fMercaderiaSDS
                    '-- Cliente
                    .pintCodigoCliente_CCLNT = txtCliente.pCodigo
                    .pstrRazonSocial_TCMPCL = txtCliente.pRazonSocial
                    '-- Hallando detalle de Familia
                    strFamilia = dgMercaderias.CurrentRow.Cells("M_CFMCLR").Value.ToString.Trim
                    .pstrCodigoFamilia_CFMCLR = strFamilia
                    mfblnObtenerDetalle_SDSFamilia(txtCliente.pCodigo, strFamilia, strTemp)
                    .pstrDescripcionFamilia_TFMCLR = strTemp
                    '-- Hallando detalle de Grupo
                    strGrupo = dgMercaderias.CurrentRow.Cells("M_CGRCLR").Value.ToString.Trim
                    .pstrCodigoGrupo_CGRCLR = strGrupo
                    mfblnObtenerDetalle_SDSGrupo(txtCliente.pCodigo, strFamilia, strGrupo, strTemp)
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
            bsaOcultar.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
            bsaOcultar.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.FixedRight
            bsaOcultar.Text = "Visualizar"
        Else
            hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
            hgOS.Width = intWidth
            bsaOcultar.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
            bsaOcultar.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
            bsaOcultar.Text = "Ocultar"
        End If
    End Sub

    Private Sub pPersiana(Optional ByVal strPersianaActual As String = "")
        If strPersianaActual <> "" Then strPersiana = strPersianaActual
        Select Case strPersiana
            Case "I" ' Ingreso de Mercadería
                hgParametrosCrearOS.Dock = DockStyle.Bottom
                hgParametrosCrearOS.Height = 20
                hgParametrosModificarOS.Visible = False
                dgListaOrdenesServicio.Visible = True
                dgListaOrdenesServicio.Dock = DockStyle.Fill
            Case "C" ' Crear O/S                
                dgListaOrdenesServicio.Visible = False
                hgParametrosModificarOS.Visible = False
                hgParametrosCrearOS.Visible = True
                hgParametrosCrearOS.Dock = DockStyle.Fill
            Case "M" ' Modificar O/S               
                hgParametrosCrearOS.Dock = DockStyle.Bottom
                hgParametrosCrearOS.Height = 20
                dgListaOrdenesServicio.Visible = False
                hgParametrosModificarOS.Visible = True
                hgParametrosModificarOS.Dock = DockStyle.Fill
        End Select
    End Sub

    Private Sub pProcesarRecepcion(ByVal blnCheckServicio As Boolean, ByRef msgMigracionCliente As String)

        If objMovimientoMercaderia.plstItemMovimientoMercaderia.Count <= 0 Then
            MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim intNroGuiaRansa As Int64 = 0
            If mfblnRecepcion_Mercaderia(objMovimientoMercaderia, blnCheckServicio, intNroGuiaRansa, msgMigracionCliente) Then
                Dim objFiltro As New beDespacho
                With objFiltro
                    .PNCCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                    .PNNGUIRN = intNroGuiaRansa
                    .pRazonSocial = objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL
                End With
                mReporteIngSalRansa(objFiltro)
                Call pActualizarInformacion()

            End If

        End If
    End Sub

    'Private Sub pVisualizarGuiaRansa(ByVal pobjFiltro As slnSOLMIN_SDS.DespachoSDS.Reportes.clsFiltros_ReporteGuiaDespacho)
    '    Dim objFiltro As New Ransa.TypeDef.beDespacho
    '    Dim objDespacho As New Ransa.NEGO.brDespacho

    '    With objFiltro
    '        .PNCCLNT = pobjFiltro.pintCodigoCliente_CCLNT
    '        .PNNGUIRN = pobjFiltro.pintNroGuiaRansa_NGUIRN
    '    End With
    '    Dim dtResultado As DataTable = Nothing
    '    dtResultado = objDespacho.fdtReporteGuiaRansa(objFiltro)
    '    dtResultado.TableName = "dtInformacionGuiaDespacho"
    '    If dtResultado.Rows.Count > 0 Then
    '        Dim rdocGuiaRemision As New RANSA.NEGO.rptGuiaRecepcion
    '        rdocGuiaRemision.SetDataSource(dtResultado)
    '        rdocGuiaRemision.Refresh()
    '        rdocGuiaRemision.SetParameterValue("pCliente", objFiltro.PNCCLNT)
    '        rdocGuiaRemision.SetParameterValue("pRazonSocialCliente", pobjFiltro.pstrRazonSocialEmpresa)
    '        rdocGuiaRemision.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
    '        rdocGuiaRemision.SetParameterValue("pNroGuiaRansa", objFiltro.PNNGUIRN)
    '        rdocGuiaRemision.SetParameterValue("pEmpresa", GLOBAL_EMRESA)
    '        With frmVisorRPT
    '            .WindowState = FormWindowState.Maximized
    '            .Dock = DockStyle.Fill
    '            .pReportDocument = rdocGuiaRemision
    '            .ShowDialog()
    '        End With
    '    End If
    'End Sub

    Private Function pProcesarCrearOS() As Boolean
        Dim blnResultado As Boolean = True
        If Not fblnValidarInfNuevaOS() Then
            blnResultado = False
        Else
            Dim objNuevaOrdenServicio As clsCrearOrdenServicio = New clsCrearOrdenServicio
            With objNuevaOrdenServicio
                .pintCodigoCliente_CCLNT = txtCliente.pCodigo
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
                .pstrUnidadDespacho_FUNDS = cbxUnidadDespacho.Text
            End With
            blnResultado = mfblnCrearOrdenServicio(objNuevaOrdenServicio)
            objNuevaOrdenServicio = Nothing
            If blnResultado Then Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Crear)
        End If
        Return blnResultado
    End Function

    Private Sub pProcesarActualizarOS()
        Dim blnResultado As Boolean = True
        Dim objNuevaOrdenServicio As clsCrearOrdenServicio = New clsCrearOrdenServicio
        With objNuevaOrdenServicio
            .pintOrdenServicio_NORDSR = dgListaOrdenesServicio.Item(0, dgListaOrdenesServicio.CurrentCellAddress.Y).Value
            .pintCodigoCliente_CCLNT = txtCliente.pCodigo
            Decimal.TryParse(txtCantidad_M.Text, .pdecCantidadDeclarada_QMRCD)
            Decimal.TryParse(txtPeso_M.Text, .pdecPesoDeclarado_QPSMR)
            Decimal.TryParse(txtValor_M.Text, .pdecValorDeclarado_QVLMR)
        End With
        blnResultado = mfblnActualizarOrdenServicio(objNuevaOrdenServicio)
        objNuevaOrdenServicio = Nothing
        If blnResultado Then Call mpMsjeVarios(enumMsjVarios.PROCESO_OK_Modificar)

    End Sub

    Private Sub pProcesarCargarInformación()
        Dim lint_Indice As Int32 = Me.dgListaOrdenesServicio.CurrentCellAddress.Y
        'O_NORDSR
        'Me.lblOrdenServicio.Text = Me.dgListaOrdenesServicio.Item(0, lint_Indice).Value
        Me.lblOrdenServicio.Text = Me.dgListaOrdenesServicio.Item("O_NORDSR", lint_Indice).Value
        'Me.txtCantidad_M.Text = Me.dgListaOrdenesServicio.Item(14, lint_Indice).Value
        Me.txtCantidad_M.Text = Me.dgListaOrdenesServicio.Item("O_QMRCD1", lint_Indice).Value
        'Me.txtPeso_M.Text = Me.dgListaOrdenesServicio.Item(15, lint_Indice).Value
        Me.txtPeso_M.Text = Me.dgListaOrdenesServicio.Item("O_QPSMR1", lint_Indice).Value
        'Me.txtValor_M.Text = Me.dgListaOrdenesServicio.Item(16, lint_Indice).Value
        Me.txtValor_M.Text = Me.dgListaOrdenesServicio.Item("O_QVLMR1", lint_Indice).Value
        'Me.txtUnidadCantidad_M.Text = Me.dgListaOrdenesServicio.Item(7, lint_Indice).Value
        Me.txtUnidadCantidad_M.Text = Me.dgListaOrdenesServicio.Item("O_CUNCN5", lint_Indice).Value
        'Me.txtUnidadPeso_M.Text = Me.dgListaOrdenesServicio.Item(9, lint_Indice).Value
        Me.txtUnidadPeso_M.Text = Me.dgListaOrdenesServicio.Item("O_CUNPS5", lint_Indice).Value
        'Me.txtUnidadValor_M.Text = Me.dgListaOrdenesServicio.Item(11, lint_Indice).Value
        Me.txtUnidadValor_M.Text = Me.dgListaOrdenesServicio.Item("O_CUNVL5", lint_Indice).Value
        'Me.cbxControlDespacho_M.SelectedIndex = IIf(Me.dgListaOrdenesServicio.Item(12, lint_Indice).Value = "C", 0, 1)
        Me.cbxControlDespacho_M.SelectedIndex = IIf(Me.dgListaOrdenesServicio.Item("O_FUNDS2", lint_Indice).Value = "C", 0, 1)
        'Me.cbxControlLote_M.Checked = IIf(Me.dgListaOrdenesServicio.Item(13, lint_Indice).Value = "S", True, False)
        Me.cbxControlLote_M.Checked = IIf(Me.dgListaOrdenesServicio.Item("O_FUNCTL", lint_Indice).Value = "S", True, False)
    End Sub

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

    Private Sub CargarPlanta()
        Dim obePlanta As New Ransa.Controls.UbicacionPlanta.Planta.bePlanta

        obePlanta.CCMPN_CodigoCompania = "EZ" 'RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        obePlanta.CDVSN_CodigoDivision = "R"
        UcPLanta_Cmb011.CodigoDivision = obePlanta.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obePlanta.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub
#End Region
#Region " Métodos "
    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        If mfblnSalirOpcion() Then
            Me.Close()
        End If
    End Sub

    Private Sub bsaCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCrearOS.Click
        If txtCliente.pCodigo = 0 Then Exit Sub
        ' Obtenemos los contratos vigentes del cliente
        Dim dtTemp As DataTable = mfdtListar_ContratosVigentes(txtCliente.pCodigo, objSeguridadBN.pstrTipoAlmacen)
        ' Si no tuviese contratos vigentes, mostramos el mensaje de que no existe información
        If dtTemp.Rows.Count <= 0 Then
            Call mpMsjeVarios(enumMsjVarios.DATA_NoExisteInformacion)
        Else
            ' Inicializamos las persinas
            Call pPersiana("C")
            dgContratosVigentes.DataSource = dtTemp
            bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End If
    End Sub

    Private Sub bsaModificarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaModificarOS.Click
        If txtCliente.pCodigo = 0 Then Exit Sub
        ' Inicializamos las persinas
        Call pPersiana("M")
        bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        Me.pProcesarCargarInformación()
    End Sub

    Private Sub bsaFamiliaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaFamiliaListar.Click
        Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
    End Sub

    Private Sub bsaGrupoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaGrupoListar.Click
        Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
    End Sub

    Private Sub bsaListarUnidadCantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaListarUnidadCantidad.Click
        Call mfblnBuscar_UnidadMedida(txtUnidadCantidad.Text, "C")
        txtUnidadCantidad.Tag = txtUnidadCantidad.Text
    End Sub

    Private Sub bsaListarUnidadPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaListarUnidadPeso.Click
        Call mfblnBuscar_UnidadMedida(txtUnidadPeso.Text, "P")
        txtUnidadPeso.Tag = txtUnidadPeso.Text
    End Sub

    Private Sub bsaOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaOcultar.Click
        If hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top Then
            Call pOcultarInformacionCabecera(True)
        Else
            Call pOcultarInformacionCabecera(False)
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Call pActualizarInformacion()
    End Sub

    Private Sub bsaAgregaMercaderiaOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaAgregaMercaderiaOS.Click
        If dgListaOrdenesServicio.RowCount <= 0 Then Exit Sub
        Dim fSolicInforMovAlmacen As frmSolicInforRecAlmacen = New frmSolicInforRecAlmacen
        With fSolicInforMovAlmacen
            .pintCliente = Me.txtCliente.pCodigo
            .pintPlanta = Me.UcPLanta_Cmb011.Planta
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' INICIO
                Dim rwTemp As DataRow = dtMercaderiaSeleccionadas.NewRow
                With rwTemp
                    rwTemp.Item("CMRCLR") = ("" & dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value).ToString.Trim
                    rwTemp.Item("TMRCD2") = ("" & dgMercaderias.CurrentRow.Cells("M_TMRCD2").Value).ToString.Trim
                    rwTemp.Item("CMRCD") = ("" & dgMercaderias.CurrentRow.Cells("M_CMRCD").Value).ToString.Trim
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
                    ' rwTemp.Item("QDSVGN")= 
                    rwTemp.Item("CCNTD") = fSolicInforMovAlmacen.pstrContenedor
                    rwTemp.Item("CTPOCN") = fSolicInforMovAlmacen.pblnDesglose
                    rwTemp.Item("FUNDS2") = dgListaOrdenesServicio.CurrentRow.Cells("O_FUNDS2").Value
                    rwTemp.Item("CTPDPS") = dgListaOrdenesServicio.CurrentRow.Cells("O_CTPDP6").Value
                    rwTemp.Item("TOBSRV") = fSolicInforMovAlmacen.pstrRecObservacion

                End With
                dtMercaderiaSeleccionadas.Rows.Add(rwTemp)
                dgMercaderias.CurrentRow.DefaultCellStyle.BackColor = Color.LightSeaGreen
            End If
            .Dispose()
            fSolicInforMovAlmacen = Nothing
        End With
    End Sub

    Private Sub bsaEliminarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEliminarItem.Click
        If dgMercaderiaSeleccionada.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        dgMercaderiaSeleccionada.Rows.Remove(dgMercaderiaSeleccionada.CurrentRow)
    End Sub

    Private Sub bsaProcesarGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesarGuia.Click
        If dgListaOrdenesServicio.RowCount <= 0 Then Exit Sub
        Dim fSolicInRecepcionGuia As frmRecepcionGuia = New frmRecepcionGuia
        With fSolicInRecepcionGuia
            .txtCliente.Text = txtCliente.pCodigo.ToString
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                For lint_Contador As Integer = 0 To .dgMercaderiaGuia.RowCount - 1
                    If fSolicInRecepcionGuia.dgMercaderiaGuia.Item(0, lint_Contador).Value = True Then
                        Dim rwTemp As DataRow = dtMercaderiaSeleccionadas.NewRow
                        With rwTemp

                            rwTemp.Item("CMRCLR") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(2, lint_Contador).Value
                            rwTemp.Item("TMRCD2") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(3, lint_Contador).Value
                            rwTemp.Item("TOBSRV") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(4, lint_Contador).Value
                            rwTemp.Item("NORDSR") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(11, lint_Contador).Value
                            rwTemp.Item("NCNTR") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(13, lint_Contador).Value
                            rwTemp.Item("NCRCTC") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(14, lint_Contador).Value
                            rwTemp.Item("NAUTR") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(15, lint_Contador).Value
                            rwTemp.Item("CUNCNT") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(6, lint_Contador).Value
                            rwTemp.Item("CUNPST") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(8, lint_Contador).Value
                            rwTemp.Item("CUNVLT") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(10, lint_Contador).Value
                            rwTemp.Item("NORCCL") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(12, lint_Contador).Value
                            rwTemp.Item("NGUICL") = fSolicInRecepcionGuia.int_GuiaRemision
                            rwTemp.Item("STPING") = fSolicInRecepcionGuia.pstrTipoRecepcion
                            rwTemp.Item("CTPALM") = fSolicInRecepcionGuia.pstrTipoAlmacen
                            rwTemp.Item("TALMC") = fSolicInRecepcionGuia.pstrDetalleTipoAlmacen
                            rwTemp.Item("CALMC") = fSolicInRecepcionGuia.pstrAlmacen
                            rwTemp.Item("TCMPAL") = fSolicInRecepcionGuia.pstrDetalleAlmacen
                            rwTemp.Item("CZNALM") = fSolicInRecepcionGuia.pstrZonaAlmacen
                            rwTemp.Item("TCMZNA") = fSolicInRecepcionGuia.pstrDetalleZonaAlmacen
                            rwTemp.Item("QTRMC") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(5, lint_Contador).Value
                            rwTemp.Item("QTRMP") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(7, lint_Contador).Value
                            rwTemp.Item("CCNTD") = ""
                            rwTemp.Item("CTPOCN") = "NO"
                            rwTemp.Item("FUNDS2") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(16, lint_Contador).Value
                            rwTemp.Item("CMRCD") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(17, lint_Contador).Value
                            rwTemp.Item("NRUCLL") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(18, lint_Contador).Value
                            rwTemp.Item("CTPDPS") = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(19, lint_Contador).Value

                        End With
                        dtMercaderiaSeleccionadas.Rows.Add(rwTemp)
                        Dim objTemp As clsItemMovimientoMercaderia = New clsItemMovimientoMercaderia
                        With objTemp
                            Int64.TryParse(("" & fSolicInRecepcionGuia.dgMercaderiaGuia.Item(11, lint_Contador).Value).ToString.Trim, .pintOrdenServicio_NORDSR)
                            Int64.TryParse(("" & fSolicInRecepcionGuia.dgMercaderiaGuia.Item(13, lint_Contador).Value).ToString.Trim, .pintNroContrato_NCNTR)
                            Int64.TryParse(("" & fSolicInRecepcionGuia.dgMercaderiaGuia.Item(14, lint_Contador).Value).ToString.Trim, .pintNroCorrDetalleContrato_NCRCTC)
                            Int64.TryParse(("" & fSolicInRecepcionGuia.dgMercaderiaGuia.Item(15, lint_Contador).Value).ToString.Trim, .pintNroAutorizacion_NAUTR)
                            .pstrCodigoMercaderia_CMRCLR = ("" & fSolicInRecepcionGuia.dgMercaderiaGuia.Item(2, lint_Contador).Value).ToString.Trim
                            .pstrCodigoRANSA_CMRCD = ("" & fSolicInRecepcionGuia.dgMercaderiaGuia.Item(17, lint_Contador).Value).ToString.Trim

                            .pstrNroOrdenCompraCliente_NORCCL = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(12, lint_Contador).Value
                            .pstrNroGuiaCliente_NGUICL = fSolicInRecepcionGuia.int_GuiaRemision
                            .pstrNroRUCCliente_NRUCLL = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(18, lint_Contador).Value

                            .pstrTipoAlmacen_CTPALM = fSolicInRecepcionGuia.pstrTipoAlmacen
                            .pstrAlmacen_CALMC = fSolicInRecepcionGuia.pstrAlmacen
                            .pstrZonaAlmacen_CZNALM = fSolicInRecepcionGuia.pstrZonaAlmacen

                            Decimal.TryParse(fSolicInRecepcionGuia.dgMercaderiaGuia.Item(5, lint_Contador).Value, .pdecCantidad_QTRMC)
                            Decimal.TryParse(fSolicInRecepcionGuia.dgMercaderiaGuia.Item(7, lint_Contador).Value, .pdecPeso_QTRMP)
                            .pstrUnidadCantidad_CUNCNT = ("" & fSolicInRecepcionGuia.dgMercaderiaGuia.Item(6, lint_Contador).Value).ToString.Trim
                            .pstrUnidadPeso_CUNPST = ("" & fSolicInRecepcionGuia.dgMercaderiaGuia.Item(8, lint_Contador).Value).ToString.Trim
                            .pstrUnidadValorTransaccion_CUNVLT = ("" & fSolicInRecepcionGuia.dgMercaderiaGuia.Item(10, lint_Contador).Value).ToString.Trim

                            .pblnDesglose_CTPOCN = False
                            .pstrContenedor_CCNTD = ""
                            .pstrTipoMovimiento_STPING = fSolicInRecepcionGuia.pstrTipoRecepcion

                            .pstrSatusUnidadDespacho_FUNDS2 = ("" & fSolicInRecepcionGuia.dgMercaderiaGuia.Item(16, lint_Contador).Value).ToString.Trim
                            .pstrTipoDeposito_CTPDPS = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(19, lint_Contador).Value
                            .pstrObservaciones_TOBSRV = fSolicInRecepcionGuia.dgMercaderiaGuia.Item(4, lint_Contador).Value
                        End With
                        objMovimientoMercaderia.AddItemMovimientoMercaderia(objTemp)
                        dgMercaderias.CurrentRow.DefaultCellStyle.BackColor = Color.LightSeaGreen
                    End If
                Next
            End If
            .Dispose()
            fSolicInRecepcionGuia = Nothing
        End With
    End Sub

    Private Sub btnActualizarModificarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarModificarOS.Click
        Me.pProcesarActualizarOS()

        hgOS.Visible = True
        hgMercaderiaSeleccionada.Visible = True
        Call pPersiana("I")

        bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub

    Private Sub btnCancelarCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarCrearOS.Click
        Call pCerrarCrearOS()
    End Sub

    Private Sub btnCancelarModificarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarModificarOS.Click
        Call pCerrarModificarOS()
    End Sub

    Private Sub btnMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMercaderia.Click
        Call pAdministrarMercaderia()
    End Sub

    Private Sub btnProcesarCrearOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarCrearOS.Click
        If pProcesarCrearOS() Then
            Call pCerrarCrearOS()
            dgListaOrdenesServicio.DataSource = mfdtListar_OrdenesServicioPorMercaderia(txtCliente.pCodigo, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
            If dgListaOrdenesServicio.RowCount > 0 Then
                bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            Else
                bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            End If
            bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            bsaModificarOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        End If
    End Sub

    Private Sub btnRealizarRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarRecepcion.Click
        If txtCliente.pCodigo = 0 Then Exit Sub
        If dgMercaderias.RowCount <= 0 Then Exit Sub

        ' Procedemos a habilitar los controles para el registro de la recepción
        objMovimientoMercaderia = New clsMovimientoMercaderia
        objMovimientoMercaderia.pintCodigoCliente_CCLNT = txtCliente.pCodigo
        objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL = txtCliente.pRazonSocial
        objMovimientoMercaderia.pstrCompania_CCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        objMovimientoMercaderia.pstrDivision_CDVSN = "R"

        dtMercaderiaSeleccionadas.Rows.Clear()

        hgOS.Visible = True
        hgMercaderiaSeleccionada.Visible = True
        Call pPersiana("I")
        btnRealizarRecepcion.Visible = False
        txtBuscarMercaderia.ReadOnly = False
        blnRealizarRecepcion = True
        dgListaOrdenesServicio.DataSource = mfdtListar_OrdenesServicioPorMercaderia(txtCliente.pCodigo, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
        If dgListaOrdenesServicio.RowCount > 0 Then
            bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        Else
            bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End If
        grpLeyenda.Visible = True
    End Sub

    Private Sub dgListaOrdenesServicio_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgListaOrdenesServicio.CellClick
        If e.RowIndex < 0 Or Me.dgListaOrdenesServicio.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        If hgParametrosModificarOS.Enabled = False Then
            Exit Sub
        End If
        Me.pProcesarCargarInformación()
    End Sub

    Private Sub bsaProcesarRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesarRecepcion.Click

        '==============Validar que el cliente tenga contrato
        Dim obrGeneral As New brGeneral
        Dim obeGeneral As New beGeneral
        Dim strError As String = String.Empty
        With obeGeneral
            .PSCCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            .PNCCLNT = Me.txtCliente.pCodigo
        End With
        If Not obrGeneral.fbolValidarClienteContrato(obeGeneral, strError) Then
            HelpClass.MsgBox(strError)
            Exit Sub
        End If
        '=============Validacion contrato==========================


        If dgMercaderiaSeleccionada.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim fIniciarMovAlmacen As frmIniciarMovAlmacen = New frmIniciarMovAlmacen
        With fIniciarMovAlmacen
            .pintCodigoCliente = txtCliente.pCodigo
            .pstrRazonSocialCliente = txtCliente.pRazonSocial
            ' modificar luego
            .pintServicio = 1
            .pstrAdicinarInfTitulo = "Recepcion"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Obtenemos la información de la cabecera registrada
                objMovimientoMercaderia.pintAnioUnidad_NANOCM = .pobjInformacionIngresada.pintAnioUnidad_NANOCM
                objMovimientoMercaderia.pintCodigoCliente_CCLNT = .pobjInformacionIngresada.pintCodigoCliente_CCLNT
                objMovimientoMercaderia.pintEmpresaTransporte_CTRSP = .pobjInformacionIngresada.pintEmpresaTransporte_CTRSP
                objMovimientoMercaderia.pintNroDocIdentidadChofer_NLELCH = .pobjInformacionIngresada.pintNroDocIdentidadChofer_NLELCH
                objMovimientoMercaderia.pintNroRUCEmpTransporte_NRUCT = .pobjInformacionIngresada.pintNroRUCEmpTransporte_NRUCT
                objMovimientoMercaderia.pintServicio_CSRVC = .pobjInformacionIngresada.pintServicio_CSRVC
                objMovimientoMercaderia.pstrChofer_TNMBCH = .pobjInformacionIngresada.pstrChofer_TNMBCH
                objMovimientoMercaderia.pstrCompania_CCMPN = .pobjInformacionIngresada.pstrCompania_CCMPN
                objMovimientoMercaderia.pstrDivision_CDVSN = .pobjInformacionIngresada.pstrDivision_CDVSN
                objMovimientoMercaderia.pstrMarcaUnidad_TMRCCM = .pobjInformacionIngresada.pstrMarcaUnidad_TMRCCM
                objMovimientoMercaderia.pstrNroBrevete_NBRVCH = .pobjInformacionIngresada.pstrNroBrevete_NBRVCH
                objMovimientoMercaderia.pstrNroPlacaCamion_NPLCCM = .pobjInformacionIngresada.pstrNroPlacaCamion_NPLCCM
                objMovimientoMercaderia.pstrObservaciones_TOBSER = .pobjInformacionIngresada.pstrObservaciones_TOBSER
                objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL = .pobjInformacionIngresada.pstrRazonSocialCliente_TCMPCL
                objMovimientoMercaderia.pstrRazonSocialEmpTransporte_TCMPTR = .pobjInformacionIngresada.pstrRazonSocialEmpTransporte_TCMPTR
                objMovimientoMercaderia.pintFechaRealizacion_FRLZSR = HelpClass.CDate_a_Numero8Digitos(.pobjInformacionIngresada.pstrFechaRealizacion_FRLZSR)
                ' Recuperamos la información ingresada en el datatable a la Lista de Clases
                Dim iCont As Integer = 0
                While iCont < dgMercaderiaSeleccionada.RowCount

                    Dim objTemp As clsItemMovimientoMercaderia = New clsItemMovimientoMercaderia
                    With objTemp
                        .pintOrdenServicio_NORDSR = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NORDSR").Value
                        .pintNroContrato_NCNTR = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NCNTR").Value
                        .pintNroCorrDetalleContrato_NCRCTC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NCRCTC").Value
                        .pintNroAutorizacion_NAUTR = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NAUTR").Value
                        .pstrCodigoMercaderia_CMRCLR = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CMRCLR").Value).ToString.Trim
                        .pstrCodigoRANSA_CMRCD = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CMRCD").Value

                        .pstrNroOrdenCompraCliente_NORCCL = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CMRCD").Value).ToString.Trim
                        .pstrNroGuiaCliente_NGUICL = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NGUICL").Value).ToString.Trim
                        .pstrNroRUCCliente_NRUCLL = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_NRUCLL").Value).ToString.Trim

                        .pstrTipoAlmacen_CTPALM = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CTPALM").Value).ToString.Trim
                        .pstrAlmacen_CALMC = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CALMC").Value).ToString.Trim
                        .pstrZonaAlmacen_CZNALM = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CZNALM").Value).ToString.Trim

                        .pdecCantidad_QTRMC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMC").Value
                        .pdecPeso_QTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                        .pstrUnidadCantidad_CUNCNT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNCNT").Value).ToString.Trim
                        .pstrUnidadPeso_CUNPST = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNPST").Value).ToString.Trim
                        .pstrUnidadValorTransaccion_CUNVLT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNVLT").Value).ToString.Trim

                        .pblnDesglose_CTPOCN = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CTPOCN").Value
                        .pstrContenedor_CCNTD = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CCNTD").Value).ToString.Trim
                        .pstrTipoMovimiento_STPING = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_STPING").Value).ToString.Trim

                        .pstrSatusUnidadDespacho_FUNDS2 = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_FUNDS2").Value).ToString.Trim
                        .pstrTipoDeposito_CTPDPS = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CTPDPS").Value).ToString.Trim
                        .pstrObservaciones_TOBSRV = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_TOBSRV").Value).ToString.Trim
                    End With
                    objMovimientoMercaderia.AddItemMovimientoMercaderia(objTemp)

                    iCont += 1
                End While
                ' Procedemos con el procesamiento de la información
                Dim msgMigracionCliente As String = ""
                Call pProcesarRecepcion(.pCheckServicio, msgMigracionCliente)
                If msgMigracionCliente <> "" Then ' resultado de migracion del cliente
                    MessageBox.Show(msgMigracionCliente, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            .Dispose()
            fIniciarMovAlmacen = Nothing
        End With



        '==========================prueba


    End Sub



    Private Sub dgContratosVigentes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgContratosVigentes.CurrentCellChanged
        If dgContratosVigentes.CurrentRow Is Nothing Then Exit Sub
        txtUnidadCantidad.Text = "" & dgContratosVigentes.CurrentRow.Cells("M_CUNCN3").Value
        txtUnidadCantidad.Tag = "" & txtUnidadCantidad.Text
        txtUnidadPeso.Text = "" & dgContratosVigentes.CurrentRow.Cells("M_CUNPS3").Value
        txtUnidadPeso.Tag = "" & txtUnidadPeso.Text
        txtUnidadValor.Text = "" & dgContratosVigentes.CurrentRow.Cells("M_CUNVL3").Value
        txtUnidadValor.Tag = "" & txtUnidadPeso.Text
    End Sub

    Private Sub dgMercaderias_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMercaderias.CurrentCellChanged
        If dgMercaderias.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        If blnRealizarRecepcion Then
            If bsaCrearOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False Then Call pCerrarCrearOS()
            dgListaOrdenesServicio.DataSource = mfdtListar_OrdenesServicioPorMercaderia(txtCliente.pCodigo, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
            If dgListaOrdenesServicio.RowCount > 0 Then
                bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            Else
                bsaAgregaMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            End If
        End If
    End Sub

    Private Sub dgMercaderiaSeleccionada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgMercaderiaSeleccionada.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgMercaderiaSeleccionada.RowCount <= 0 Then
                MessageBox.Show("No existe información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            dgMercaderiaSeleccionada.Rows.Remove(dgMercaderiaSeleccionada.CurrentRow)
        End If
    End Sub

    Private Sub frmRecepcionSDS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        '-- Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)

        CargarPlanta()

        intWidth = hgOS.Width
        objAppConfig = Nothing
        ' Obtengo los últimos almacenes para este cliente
        Call mfblnObtener_InfUltimoAlmacenSegunCliente(txtCliente.pCodigo, strTipoAlmacen_CTPALM, strDetalleTipoAlmacen_TALMC, strAlmacen_CALMC, strDetalleAlmacen_TCMPAL)
        ' Obtengo el Tipo de Movimiento por defecto
        Call mfstrDefecto_TipoMovimientoRecepcion(strTipoMovimiento_STPING, strDetalleTipoMovimiento_TTPING)
    End Sub

    Private Sub frmRecepcionSDS_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Call pPersiana()
    End Sub

    Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        dgMercaderias.DataSource = Nothing
    End Sub

    Private Sub txtFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
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
                Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
                If txtFamilia.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtBuscarMercaderia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMercaderia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtBuscarMercaderia.Text.Trim <> "" Then
                Dim iCont As Int32 = 0
                Dim sTemp As String = txtBuscarMercaderia.Text.ToUpper.Trim
                While iCont < dgMercaderias.RowCount
                    If ("" & dgMercaderias.Rows(iCont).Cells("M_CMRCLR").Value).ToString.ToUpper.Trim = sTemp Then
                        dgMercaderias.CurrentCell = dgMercaderias.Rows(iCont).Cells("M_CMRCLR")
                        Exit While
                    End If
                    iCont += 1
                End While
            End If
        End If
    End Sub

    Private Sub txtGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGrupo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
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
                Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
                If txtGrupo.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtUnidadCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadCantidad.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_UnidadMedida(txtUnidadCantidad.Text, "C")
            txtUnidadCantidad.Tag = txtUnidadCantidad.Text
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
                Call mfblnBuscar_UnidadMedida(txtUnidadCantidad.Text, "C")
                txtUnidadCantidad.Tag = txtUnidadCantidad.Text
                If txtUnidadCantidad.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub txtUnidadPeso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidadPeso.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_UnidadMedida(txtUnidadPeso.Text, "P")
            txtUnidadPeso.Tag = txtUnidadPeso.Text
        End If
    End Sub

    Private Sub txtUnidadPeso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidadPeso.TextChanged
        txtUnidadPeso.Tag = ""
    End Sub

    Private Sub txtUnidadPeso_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUnidadPeso.Validating
        If txtUnidadPeso.Text = "" Then
            txtUnidadPeso.Tag = ""
        Else
            If txtUnidadPeso.Text <> "" And "" & txtUnidadPeso.Tag = "" Then
                Call mfblnBuscar_UnidadMedida(txtUnidadPeso.Text, "P")
                txtUnidadPeso.Tag = txtUnidadPeso.Text
                If txtUnidadPeso.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
#End Region

    Private Sub tsbTransferencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbTransferencias.Click
        If txtCliente.pCodigo = 0 Then Exit Sub
        Dim ofrmSolicInforRecTransferencia As New frmSolicInforRecTransferencia
        ofrmSolicInforRecTransferencia.pintCCLNT = Me.txtCliente.pCodigo
        ofrmSolicInforRecTransferencia.pintServicio_CSRVC = 1
        ofrmSolicInforRecTransferencia.pstrRazonSocialCliente = Me.txtCliente.pRazonSocial
        ofrmSolicInforRecTransferencia.pstrCCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        ofrmSolicInforRecTransferencia.pstrCDVSN = "R"
        ofrmSolicInforRecTransferencia.pintCCLNT = Me.txtCliente.pCodigo
        If ofrmSolicInforRecTransferencia.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Call pActualizarInformacion()
        End If
    End Sub

    'Private Sub UcPLanta_Cmb011_Seleccionar(ByVal obePlanta As Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta) Handles UcPLanta_Cmb011.Seleccionar

    'End Sub
End Class