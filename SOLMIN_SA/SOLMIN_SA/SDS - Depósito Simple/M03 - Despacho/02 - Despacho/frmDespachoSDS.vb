Imports Ransa.Utilitario
'Imports Ransa.TYPEDEF.Cliente
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.NEGO.slnSOLMIN_SDS.DespachoSDS
Imports Ransa.NEGO
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Public Class frmDespachoSDS
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
    Private blnRealizarDespacho As Boolean = False
    Private blnStatusNuevoAcoplado As Boolean = False
    Private intWidth As Integer = 0
    '-- Tipo de Movimiento
    Private strTipoMovimiento_STPING As String = ""
    Private strDetalleTipoMovimiento_TTPING As String = ""
    '-- Desglose
    Private strDesglose_CTPOCN As String = "N"
    '-- Contiene la información de la Cabecera
    Private objMovimientoMercaderia As clsMovimientoMercaderia
    Private _TipoAjuste As String = ""
#End Region
#Region " Propiedades "

#End Region
#Region " Procedimientos y Funciones "
    Private Sub CargarPlanta()
        Dim obePlanta As New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        obePlanta.CCMPN_CodigoCompania = "EZ" 'RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        obePlanta.CDVSN_CodigoDivision = "R"
        UcPLanta_Cmb011.CodigoDivision = obePlanta.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obePlanta.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

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
            blnRealizarDespacho = False
            '-- Dejamos los controles de mercaderías y los otros se ocultan
            hgOS.Visible = False
            hgMercaderiaSeleccionada.Visible = False
            '-- Listamos la información de la mercaderías
            dgMercaderias.DataSource = mfdtListar_Mercaderias(objFiltro)
            '-- Se libera los procesos automáticos
            booStatus = True
            '-- Se habilita el botón para realizar una nueva Despacho
            btnRealizarDespacho.Visible = True
            tssSeparador01.Visible = True
            tssbAjuste.Visible = True

            txtFiltroMercaderia.ReadOnly = True
            '-- Limpiamos la información de la cabecera
            objMovimientoMercaderia = Nothing
            grpLeyenda.Visible = False
            Call pOcultarInformacionCabecera(False)
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("RECSDS_ClienteCodigo", txtCliente.pCodigo)
            objAppConfig = Nothing
        End If
    End Sub

    Private Sub pMercadería_KeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            'Case Keys.F2
            '    Call pGuardarMercadería()
            Case Keys.Escape
                Me.Close()
        End Select
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

    Private Sub pProcesarDespacho(ByVal blnCheckServicio As Boolean, ByRef resultadoEnvioInterfaz As String)
        If objMovimientoMercaderia.plstItemMovimientoMercaderia.Count <= 0 Then
            MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim intNroGuiaRansa As Int64 = 0

            If mfblnDespacho_Mercaderia(resultadoEnvioInterfaz, objMovimientoMercaderia, blnCheckServicio, intNroGuiaRansa) Then
                Dim objFiltro As New Reportes.clsFiltros_ReporteGuiaDespacho
                With objFiltro
                    .pintCodigoCliente_CCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                    .pstrRazonSocialCliente_TCMPCL = objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL
                    .pstrRazonSocialEmpresa = GLOBAL_EMRESA
                    .pintNroGuiaRansa_NGUIRN = intNroGuiaRansa
                End With
                pVisualizarGuiaRansa(objFiltro)
                Call pActualizarInformacion()
            End If

        End If
    End Sub


    Private Sub pVisualizarGuiaRansa(ByVal pobjFiltro As Reportes.clsFiltros_ReporteGuiaDespacho)
        Dim objFiltro As New Ransa.TYPEDEF.beDespacho
        Dim objDespacho As New Ransa.NEGO.brDespacho

        With objFiltro
            .PNCCLNT = pobjFiltro.pintCodigoCliente_CCLNT
            .PNNGUIRN = pobjFiltro.pintNroGuiaRansa_NGUIRN
        End With
        Dim dtResultado As DataTable = Nothing
        dtResultado = objDespacho.fdtReporteGuiaRansa(objFiltro)
        dtResultado.TableName = "dtInformacionGuiaDespacho"
        If dtResultado.Rows.Count > 0 Then
            Dim rdocGuiaRemision As New Ransa.NEGO.rptGuiaDespacho
            rdocGuiaRemision.SetDataSource(dtResultado)
            rdocGuiaRemision.Refresh()
            rdocGuiaRemision.SetParameterValue("pCliente", objFiltro.PNCCLNT)
            rdocGuiaRemision.SetParameterValue("pRazonSocialCliente", pobjFiltro.pstrRazonSocialEmpresa)
            rdocGuiaRemision.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rdocGuiaRemision.SetParameterValue("pNroGuiaRansa", objFiltro.PNNGUIRN)
            rdocGuiaRemision.SetParameterValue("pEmpresa", GLOBAL_EMRESA)
            rdocGuiaRemision.SetParameterValue("pProceso", objFiltro.PSCTPOAT)
            With frmVisorRPT
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill
                .pReportDocument = rdocGuiaRemision
                .ShowDialog()
            End With
        End If
    End Sub
    Private Sub btnAjustePositivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _TipoAjuste = "P"
        Call RealizarDespacho()
    End Sub

    Private Sub btnAjusteNegativo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        _TipoAjuste = "N"
        Call RealizarDespacho()
    End Sub
#End Region
#Region " Métodos "
    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        If mfblnSalirOpcion() Then
            Me.Close()
        End If
    End Sub

    Private Sub bsaEliminarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaEliminarItem.Click
        If dgMercaderiaSeleccionada.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        dgMercaderiaSeleccionada.Rows.Remove(dgMercaderiaSeleccionada.CurrentRow)
    End Sub

    Private Sub bsaDespacharMercaderiaOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaDespacharMercaderiaOS.Click
        If dgStockPorAlmacen.RowCount <= 0 Then Exit Sub

        Dim decQta As Decimal = dgStockPorAlmacen.CurrentRow.Cells("D_QSLMC2").Value
        Dim decPeso As Decimal = dgStockPorAlmacen.CurrentRow.Cells("D_QSLMP2").Value
        Dim status As String = dgListaOrdenesServicio.CurrentRow.Cells("O_FUNDS2").Value
        Dim decPlanta As Decimal = dgStockPorAlmacen.CurrentRow.Cells("CPLNFC").Value
        Dim strPlanta As String = dgStockPorAlmacen.CurrentRow.Cells("TPLNTA").Value.ToString.Trim
        'validando las cantidades de acuerdo al ajuste seleccionado
        If _TipoAjuste <> "" Then

            If decQta = 0 And decPeso = 0 Then
                MsgBox("La Cantidad y el Peso están correctas", MsgBoxStyle.Critical, "Aviso")
                Exit Sub
            End If

            If _TipoAjuste = "N" Then
                If status = "C" Then
                    If decPeso = 0 Then
                        MsgBox("La información del Peso está correcta", MsgBoxStyle.Critical, "Aviso")
                        Exit Sub
                    End If
                    If decPeso < 0 Then
                        MsgBox("No puede realizar un ajuste negativo a una cantidad negativa", MsgBoxStyle.Critical, "Aviso")
                        Exit Sub
                    End If
                Else
                    If decQta = 0 Then
                        MsgBox("La información de la Cantidad está correcta", MsgBoxStyle.Critical, "Aviso")
                        Exit Sub
                    End If
                    If decQta < 0 Then
                        MsgBox("No puede realizar un ajuste negativo a una cantidad negativa", MsgBoxStyle.Critical, "Aviso")
                        Exit Sub
                    End If
                End If
            End If

            Dim ofrmDlgAjustes As frmDlgAjustes = New frmDlgAjustes(_TipoAjuste, decQta, decPeso, status, txtCliente.pCodigo)
            With ofrmDlgAjustes
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' INICIO
                    If ofrmDlgAjustes.pdecRecCantidad >= 0 Then
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
                            rwTemp.Item("NORCCL") = 0
                            rwTemp.Item("NGUICL") = 0
                            rwTemp.Item("NRUCLL") = 0
                            rwTemp.Item("STPING") = ofrmDlgAjustes.pstrTipoDespacho
                            rwTemp.Item("CTPALM") = dgStockPorAlmacen.CurrentRow.Cells("D_CTPALM").Value
                            rwTemp.Item("TALMC") = dgStockPorAlmacen.CurrentRow.Cells("D_TALMC").Value
                            rwTemp.Item("CALMC") = dgStockPorAlmacen.CurrentRow.Cells("D_CALMC").Value
                            rwTemp.Item("TCMPAL") = dgStockPorAlmacen.CurrentRow.Cells("D_TCMPAL").Value
                            rwTemp.Item("CZNALM") = dgStockPorAlmacen.CurrentRow.Cells("D_CZNALM").Value
                            rwTemp.Item("TCMZNA") = dgStockPorAlmacen.CurrentRow.Cells("D_TCMZNA").Value
                            rwTemp.Item("QTRMC") = ofrmDlgAjustes.pdecRecCantidad
                            rwTemp.Item("QTRMP") = ofrmDlgAjustes.pdecRecPeso
                            rwTemp.Item("QDSVGN") = 0
                            rwTemp.Item("FUNDS2") = dgListaOrdenesServicio.CurrentRow.Cells("O_FUNDS2").Value
                            rwTemp.Item("CTPDPS") = dgListaOrdenesServicio.CurrentRow.Cells("O_CTPDP6").Value
                            rwTemp.Item("TOBSRV") = ofrmDlgAjustes.pstrRecObservacion
                        End With
                        dtMercaderiaSeleccionadas.Rows.Add(rwTemp)
                        dgMercaderias.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
                    End If
                End If
            End With

        Else
            If decPlanta = UcPLanta_Cmb011.Planta Then
                Dim fSolicInforMovAlmacen As frmSolicInforDesAlmacen = New frmSolicInforDesAlmacen(decQta, decPeso, txtCliente.pCodigo)
                With fSolicInforMovAlmacen

                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        ' INICIO
                        If fSolicInforMovAlmacen.pdecRecCantidad >= 0 Then
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
                                rwTemp.Item("STPING") = fSolicInforMovAlmacen.pstrTipoDespacho
                                rwTemp.Item("CTPALM") = dgStockPorAlmacen.CurrentRow.Cells("D_CTPALM").Value
                                rwTemp.Item("TALMC") = dgStockPorAlmacen.CurrentRow.Cells("D_TALMC").Value
                                rwTemp.Item("CALMC") = dgStockPorAlmacen.CurrentRow.Cells("D_CALMC").Value
                                rwTemp.Item("TCMPAL") = dgStockPorAlmacen.CurrentRow.Cells("D_TCMPAL").Value
                                rwTemp.Item("CZNALM") = dgStockPorAlmacen.CurrentRow.Cells("D_CZNALM").Value
                                rwTemp.Item("TCMZNA") = dgStockPorAlmacen.CurrentRow.Cells("D_TCMZNA").Value
                                rwTemp.Item("QTRMC") = fSolicInforMovAlmacen.pdecRecCantidad
                                rwTemp.Item("QTRMP") = fSolicInforMovAlmacen.pdecRecPeso
                                rwTemp.Item("QDSVGN") = fSolicInforMovAlmacen.pintNroVigencia
                                rwTemp.Item("FUNDS2") = dgListaOrdenesServicio.CurrentRow.Cells("O_FUNDS2").Value
                                rwTemp.Item("CTPDPS") = dgListaOrdenesServicio.CurrentRow.Cells("O_CTPDP6").Value
                                rwTemp.Item("TOBSRV") = fSolicInforMovAlmacen.pstrRecObservacion
                            End With
                            dtMercaderiaSeleccionadas.Rows.Add(rwTemp)
                            dgMercaderias.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
                        End If
                    End If
                End With
            Else
                MessageBox.Show("Ud. no tiene autorización para realizar ingresos en la Planta " & strPlanta, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub bsaFamiliaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaFamiliaListar.Click
        Call mfblnBuscar_SDSFamilia(txtCliente.pCodigo, txtFamilia.Tag, txtFamilia.Text)
    End Sub

    Private Sub bsaGrupoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaGrupoListar.Click
        Call mfblnBuscar_SDSGrupo(txtCliente.pCodigo, txtFamilia.Tag, txtGrupo.Tag, txtGrupo.Text)
    End Sub

    Private Sub bsaProcesarDespachar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaProcesarDespachar.Click
        If dgMercaderiaSeleccionada.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '<[AHM]>
        GLOBAL_COMPANIA = "EZ"
        Dim mensaje = ""
        If (Not (New brBulto).ValidarLimiteCredito(GLOBAL_COMPANIA, txtCliente.pCodigo, mensaje)) Then
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '</[AHM]>

        If _TipoAjuste = "" Then
            Dim fIniciarMovAlmacen As frmIniciarMovAlmacen = New frmIniciarMovAlmacen
            With fIniciarMovAlmacen
                .pintCodigoCliente = txtCliente.pCodigo
                .pstrRazonSocialCliente = txtCliente.pRazonSocial
                ' modificar luego
                .pintServicio = 2
                .pstrAdicinarInfTitulo = "Despacho"
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
                            .PNQTRMC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMC").Value
                            .pdecPeso_QTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                            .PNQTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                            .pstrUnidadCantidad_CUNCNT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNCNT").Value).ToString.Trim
                            .pstrUnidadPeso_CUNPST = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNPST").Value).ToString.Trim
                            .pstrUnidadValorTransaccion_CUNVLT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNVLT").Value).ToString.Trim

                            .pstrTipoMovimiento_STPING = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_STPING").Value).ToString.Trim
                            .pintNroDiasVigencia_QDSVGN = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QDSVGN").Value

                            .pstrSatusUnidadDespacho_FUNDS2 = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_FUNDS2").Value).ToString.Trim
                            .pstrTipoDeposito_CTPDPS = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CTPDPS").Value).ToString.Trim
                            .pstrObservaciones_TOBSRV = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_TOBSRV").Value).ToString.Trim
                        End With
                        objMovimientoMercaderia.AddItemMovimientoMercaderia(objTemp)
                        iCont += 1
                    End While
                    ' Procedemos con el procesamiento de la información
                    Dim resultadoEnvioInterfaz As String = ""
                    Call pProcesarDespacho(.pCheckServicio, resultadoEnvioInterfaz)
                    If resultadoEnvioInterfaz <> "" Then
                        MessageBox.Show(resultadoEnvioInterfaz, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
                .Dispose()
                fIniciarMovAlmacen = Nothing
            End With
        ElseIf _TipoAjuste = "P" Then

            objMovimientoMercaderia.pintServicio_CSRVC = 910
            objMovimientoMercaderia.pintCodigoCliente_CCLNT = txtCliente.pCodigo
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
                    .PNQTRMC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMC").Value
                    .pdecPeso_QTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                    .PNQTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                    .pstrUnidadCantidad_CUNCNT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNCNT").Value).ToString.Trim
                    .pstrUnidadPeso_CUNPST = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNPST").Value).ToString.Trim
                    .pstrUnidadValorTransaccion_CUNVLT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNVLT").Value).ToString.Trim

                    .pstrTipoMovimiento_STPING = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_STPING").Value).ToString.Trim
                    .pintNroDiasVigencia_QDSVGN = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QDSVGN").Value

                    .pstrSatusUnidadDespacho_FUNDS2 = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_FUNDS2").Value).ToString.Trim
                    .pstrTipoDeposito_CTPDPS = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CTPDPS").Value).ToString.Trim
                    .pstrObservaciones_TOBSRV = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_TOBSRV").Value).ToString.Trim
                End With
                objMovimientoMercaderia.AddItemMovimientoMercaderia(objTemp)
                iCont += 1
            End While
            ' Procedemos con el procesamiento de la información
            Dim resultadoEnvioInterfaz As String = ""
            Call pProcesarDespacho(False, resultadoEnvioInterfaz)
            If resultadoEnvioInterfaz <> "" Then
                MessageBox.Show(resultadoEnvioInterfaz, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        ElseIf _TipoAjuste = "N" Then
            ' Obtenemos la información de la cabecera registrada
            objMovimientoMercaderia.pintServicio_CSRVC = 911
            objMovimientoMercaderia.pintCodigoCliente_CCLNT = txtCliente.pCodigo
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
                    .PNQTRMC = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMC").Value
                    .pdecPeso_QTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                    .PNQTRMP = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QTRMP").Value
                    .pstrUnidadCantidad_CUNCNT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNCNT").Value).ToString.Trim
                    .pstrUnidadPeso_CUNPST = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNPST").Value).ToString.Trim
                    .pstrUnidadValorTransaccion_CUNVLT = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CUNVLT").Value).ToString.Trim

                    .pstrTipoMovimiento_STPING = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_STPING").Value).ToString.Trim
                    .pintNroDiasVigencia_QDSVGN = dgMercaderiaSeleccionada.Rows(iCont).Cells("S_QDSVGN").Value

                    .pstrSatusUnidadDespacho_FUNDS2 = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_FUNDS2").Value).ToString.Trim
                    .pstrTipoDeposito_CTPDPS = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_CTPDPS").Value).ToString.Trim
                    .pstrObservaciones_TOBSRV = ("" & dgMercaderiaSeleccionada.Rows(iCont).Cells("S_TOBSRV").Value).ToString.Trim
                End With
                objMovimientoMercaderia.AddItemMovimientoMercaderia(objTemp)
                iCont += 1
            End While
            ' Procedemos con el procesamiento de la información
            Dim resultadoEnvioInterfaz As String = ""
            Call pProcesarDespacho(False, resultadoEnvioInterfaz)
            If resultadoEnvioInterfaz <> "" Then
                MessageBox.Show(resultadoEnvioInterfaz, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
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

    Private Sub btnRealizarDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarDespacho.Click
        _TipoAjuste = ""
        bsaDespacharMercaderiaOS.Text = "Despachar Mercadería"
        Call RealizarDespacho()
    End Sub

    Private Sub dgMercaderias_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMercaderias.CurrentCellChanged
        Dim obrDespacho As New brDespacho
        If blnRealizarDespacho Then
            dgListaOrdenesServicio.DataSource = mfdtListar_OrdenesServicioPorMercaderia(txtCliente.pCodigo, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
            If dgListaOrdenesServicio.RowCount > 0 Then
                '-- Obtenemos el Stock de la Mercadería según Almacén
                dgStockPorAlmacen.DataSource = obrDespacho.fdtListaStockMercaderiasPorAlmacen("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value)
                'mfdtListar_StockMercaderiasPorAlmacen("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value)
                If dgStockPorAlmacen.RowCount > 0 Then
                    bsaDespacharMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                Else
                    bsaDespacharMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                End If
            Else
                dgStockPorAlmacen.DataSource = Nothing
                bsaDespacharMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
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

    Private Sub dgListaOrdenesServicio_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgListaOrdenesServicio.CurrentCellChanged
        '-- Obtenemos el Stock de la Mercadería según Almacén
        Dim obrDespacho As New brDespacho
        If Not dgListaOrdenesServicio.CurrentRow Is Nothing Then
            Dim intNroOrdenServicio As Int64
            Int64.TryParse("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value, intNroOrdenServicio)
            dgStockPorAlmacen.DataSource = obrDespacho.fdtListaStockMercaderiasPorAlmacen(intNroOrdenServicio)
            'dgStockPorAlmacen.DataSource = mfdtListar_StockMercaderiasPorAlmacen(intNroOrdenServicio)
            If dgStockPorAlmacen.RowCount > 0 Then
                bsaDespacharMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            Else
                bsaDespacharMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            End If
        End If
    End Sub

    Private Sub frmDespachoSDS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        '-- Visualizando los controles de mercaderías
        hgOS.Visible = False
        hgMercaderiaSeleccionada.Visible = False
        '-- Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        CargarPlanta()
        intWidth = hgOS.Width
        objAppConfig = Nothing
    End Sub

    Private Sub hgOS_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles hgOS.Resize
        hgAlmacenPorOS.Height = Me.hgOS.Height / 2
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

    Private Sub txtFiltroMercaderia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroMercaderia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFiltroMercaderia.Text.Trim <> "" Then
                Dim iCont As Int32 = 0
                Dim sTemp As String = txtFiltroMercaderia.Text.ToUpper.Trim
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
    Private Sub RealizarDespacho()
        Dim obrDespacho As New brDespacho
        If txtCliente.pCodigo = 0 Then Exit Sub
        If dgMercaderias.RowCount <= 0 Then Exit Sub

        ' Procedemos a habilitar los controles para el registro de la recepción
        objMovimientoMercaderia = New clsMovimientoMercaderia
        dtMercaderiaSeleccionadas.Rows.Clear()

        hgOS.Visible = True
        hgMercaderiaSeleccionada.Visible = True
        btnRealizarDespacho.Visible = False
        tssSeparador01.Visible = False
        tssSeparador02.Visible = False
        tssbAjuste.Visible = False
        txtFiltroMercaderia.ReadOnly = False
        blnRealizarDespacho = True
        dgListaOrdenesServicio.DataSource = mfdtListar_OrdenesServicioPorMercaderia(txtCliente.pCodigo, dgMercaderias.CurrentRow.Cells("M_CMRCLR").Value)
        If dgListaOrdenesServicio.RowCount > 0 Then
            '-- Obtenemos el Stock de la Mercadería según Almacén
            'dgStockPorAlmacen.DataSource = mfdtListar_StockMercaderiasPorAlmacen("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value)
            dgStockPorAlmacen.DataSource = obrDespacho.fdtListaStockMercaderiasPorAlmacen("" & dgListaOrdenesServicio.CurrentRow.Cells("O_NORDSR").Value)

            If dgStockPorAlmacen.RowCount > 0 Then
                bsaDespacharMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            Else
                bsaDespacharMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            End If
        Else
            dgStockPorAlmacen.DataSource = Nothing
            bsaDespacharMercaderiaOS.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End If
        grpLeyenda.Visible = True
    End Sub

#End Region

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        _TipoAjuste = "N"
        bsaDespacharMercaderiaOS.Text = "Ajuste Despacho (-)"
        Call RealizarDespacho()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        _TipoAjuste = "P"
        bsaDespacharMercaderiaOS.Text = "Ajuste Recepción (+)"
        Call RealizarDespacho()
    End Sub

End Class