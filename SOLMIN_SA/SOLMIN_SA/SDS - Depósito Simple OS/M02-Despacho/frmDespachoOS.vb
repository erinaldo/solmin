Imports RANSA.TYPEDEF.Cliente
Imports RANSA.Utilitario
Imports RANSA.TYPEDEF
Imports RANSA.NEGO

Public Class frmDespachoOS


    Private intWidth As Integer = 0
    Private olistMercaderia As List(Of beMercaderia)

    Private Sub frmRecepcionOS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Validar_Usuario_Autoridado()
        CargarClientes()
        CargarControles()
        CargarDeposito()
        UCDataGridView.Alinear_Columnas_Grilla(Me.dgMercaderia)
        olistMercaderia = New List(Of beMercaderia)
        intWidth = hgOS.Width

        Me.Contenedor1.Panel2Collapsed = True
        Me.Contenedor2.Panel2Collapsed = True
    End Sub

    Private Sub CargarDeposito()
        Dim obrTipoDeDeposito As New brTipoDeDeposito
        cmbDeposito.DataSource = obrTipoDeDeposito.ListarTipoDeDeposito()
        cmbDeposito.DisplayMember = "PSTABDPS"
        cmbDeposito.ValueMember = "PSCTPDPS"
        cmbDeposito.SelectedValue = "1"
    End Sub

    Private Sub btnProcesarDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarDespacho.Click
        ProcesarDespacho()
    End Sub

#Region "Metodos"

    Private Sub CargarClientes()
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RecepcionOC_CodigoCliente", GetType(System.String)), intTemp)
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
        objAppConfig = Nothing
    End Sub

    Private Sub ListaMercaderia()
        Dim obrMercaderia As New brMercaderia
        Dim obeMercaderia As New beMercaderia
        With obeMercaderia
            .PNCCLNT = txtCliente.pCodigo
            'If Not Me.txtFamilia.Resultado Is Nothing Then
            '    .PSCFMLA = CType(Me.txtFamilia.Resultado, beMercaderia).PSCFMLA
            'End If
            'If Not Me.txtGrupo.Resultado Is Nothing Then
            '    .PSCGRPO = CType(Me.txtGrupo.Resultado, beMercaderia).PSCGRPO
            'End If

            .PSCTPDP6 = cmbDeposito.SelectedValue

            If Not Me.txtMarca.Resultado Is Nothing Then
                .PNCMRCA = CType(Me.txtMarca.Resultado, beMercaderia).PNCMRCA
            End If
            If IsNumeric(txtMercaderia.Text) Then
                .PNNORDSR = Val(txtMercaderia.Text)
            Else
                .PSTCMPMR = txtMercaderia.Text
            End If

        End With
        dgMercaderia.AutoGenerateColumns = False
        Limpiar()
        Me.dgMercaderia.DataSource = obrMercaderia.flistListarMercaderiaOS(obeMercaderia)
    End Sub

#End Region


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        ListaMercaderia()
    End Sub

    Private Sub CargarControles()

        Dim obePlanta As New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        obePlanta.CCMPN_CodigoCompania = "EZ" 'RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        obePlanta.CDVSN_CodigoDivision = "R"
        UcPLanta_Cmb011.CodigoDivision = obePlanta.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obePlanta.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CFMLA"
        oColumnas.DataPropertyName = "PSCFMLA"
        oColumnas.HeaderText = "Código "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPFM"
        oColumnas.DataPropertyName = "PSTCMPFM"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)
        Dim obrMercaderia As New brMercaderia
        Dim obeFiltro As New beMercaderia
        'Me.txtFamilia.DataSource = obrMercaderia.ListaFamiliaDeMercaderia(obeFiltro)
        'Me.txtFamilia.ListColumnas = oListColum
        'Me.txtFamilia.Cargas()
        'Me.txtFamilia.DispleyMember = "PSTCMPFM"
        'Me.txtFamilia.ValueMember = "PSCFMLA"


        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CMRCA"
        oColumnas.DataPropertyName = "PNCMRCA"
        oColumnas.HeaderText = "Código "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMMRC"
        oColumnas.DataPropertyName = "PSTCMMRC"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)
        Me.txtMarca.ListColumnas = oListColum
        Me.txtMarca.Cargas()
        Me.txtMarca.DispleyMember = "PSTCMMRC"
        Me.txtMarca.ValueMember = "PNCMRCA"


    End Sub

    Private Sub txtFamilia_CambioDeTexto(ByVal objData As Object)
        'Dim oListColum As New Hashtable
        'Dim oColumnas As New DataGridViewTextBoxColumn
        'oColumnas.Name = "CGRPO"
        'oColumnas.DataPropertyName = "PSCGRPO"
        'oColumnas.HeaderText = "Código "
        'oListColum.Add(1, oColumnas)
        'oColumnas = New DataGridViewTextBoxColumn
        'oColumnas.Name = "TCMPGR"
        'oColumnas.DataPropertyName = "PSTCMPGR"
        'oColumnas.HeaderText = "Descripción "
        'oListColum.Add(2, oColumnas)
        'If Not objData Is Nothing Then
        '    Dim obrMercaderia As New brMercaderia
        '    Me.txtGrupo.DataSource = obrMercaderia.ListaGrupoDeMercaderia(objData)
        'Else
        '    Me.txtGrupo.DataSource = Nothing
        'End If
        'Me.txtGrupo.ListColumnas = oListColum
        'Me.txtGrupo.Cargas()
        'Me.txtGrupo.Limpiar()
        'Me.txtGrupo.DispleyMember = "PSTCMPGR"
        'Me.txtGrupo.ValueMember = "PSCGRPO"
    End Sub

    Private Sub btnEliminarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarItem.Click
        If Me.dgMercaderiaSeleccionada.CurrentCellAddress.Y = -1 Then Exit Sub
        olistMercaderia.Remove(Me.dgMercaderiaSeleccionada.CurrentRow.DataBoundItem)
        Me.dgMercaderiaSeleccionada.DataSource = Nothing
        Me.dgMercaderiaSeleccionada.DataSource = olistMercaderia
    End Sub

    Private Sub ProcesarDespacho()
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

        Dim fIniciarMovAlmacen As frmIniciarMovAlmacen = New frmIniciarMovAlmacen
        With fIniciarMovAlmacen
            .pintCodigoCliente = txtCliente.pCodigo
            .pstrRazonSocialCliente = txtCliente.pRazonSocial
            ' modificar luego
            .pintServicio = 2
            .pstrAdicinarInfTitulo = "Despacho"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim obeDespacho As New beDespacho
                ' Obtenemos la información de la cabecera registrada
                olistMercaderia.Item(0).PNNANOCM = .pobjInformacionIngresada.pintAnioUnidad_NANOCM
                olistMercaderia.Item(0).PNCCLNT = .pobjInformacionIngresada.pintCodigoCliente_CCLNT
                olistMercaderia.Item(0).PNCTRSP = .pobjInformacionIngresada.pintEmpresaTransporte_CTRSP
                olistMercaderia.Item(0).PNNLELCH = .pobjInformacionIngresada.pintNroDocIdentidadChofer_NLELCH
                olistMercaderia.Item(0).PNNRUCT = .pobjInformacionIngresada.pintNroRUCEmpTransporte_NRUCT
                olistMercaderia.Item(0).PNCSRVC = .pobjInformacionIngresada.pintServicio_CSRVC
                olistMercaderia.Item(0).PSTNMBCH = .pobjInformacionIngresada.pstrChofer_TNMBCH
                olistMercaderia.Item(0).PSCCMPN = .pobjInformacionIngresada.pstrCompania_CCMPN
                olistMercaderia.Item(0).PSCDVSN = .pobjInformacionIngresada.pstrDivision_CDVSN
                olistMercaderia.Item(0).PSTMRCCM = .pobjInformacionIngresada.pstrMarcaUnidad_TMRCCM
                olistMercaderia.Item(0).PSNBRVCH = .pobjInformacionIngresada.pstrNroBrevete_NBRVCH
                olistMercaderia.Item(0).PSNPLCCM = .pobjInformacionIngresada.pstrNroPlacaCamion_NPLCCM
                olistMercaderia.Item(0).PSTOBSER = .pobjInformacionIngresada.pstrObservaciones_TOBSER
                olistMercaderia.Item(0).PSTCMPCL = .pobjInformacionIngresada.pstrRazonSocialCliente_TCMPCL
                olistMercaderia.Item(0).PSTCMPTR = .pobjInformacionIngresada.pstrRazonSocialEmpTransporte_TCMPTR
                olistMercaderia.Item(0).GenerarServicio = .pCheckServicio
                olistMercaderia.Item(0).PSUSUARIO = objSeguridadBN.pUsuario
                olistMercaderia.Item(0).PNFRLZSR = HelpClass.CDate_a_Numero8Digitos(.pobjInformacionIngresada.pstrFechaRealizacion_FRLZSR)
            Else
                Exit Sub
            End If
        End With
        Dim obrMercaderia As New brMercaderia
        olistMercaderia.Item(0).PNNGUIRN = obrMercaderia.fintDespachoMercaderia(olistMercaderia)
        If olistMercaderia.Item(0).PNNGUIRN = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        Dim objFiltro As New beDespacho
        With objFiltro
            .PNCCLNT = olistMercaderia.Item(0).PNCCLNT
            .PNNGUIRN = olistMercaderia.Item(0).PNNGUIRN
            .pRazonSocial = olistMercaderia.Item(0).PSTCMPCL
        End With
        mReporteIngSalRansa(objFiltro)

        If olistMercaderia.Item(0).GenerarServicio Then
            ' Registro de Servicio
            Dim oServicio As New RANSA.Controls.ServicioOperacion.Servicio_BE
            With oServicio
                .CCMPN = objSeguridadBN.pCompania
                .CDVSN = objSeguridadBN.pDivision
                .NOPRCN = 0
                .CCLNFC = olistMercaderia.Item(0).PNCCLNT
                .CCLNT = olistMercaderia.Item(0).PNCCLNT
                .NRTFSV = 0
                .QATNAN = 0
                .TIPO = "N"
                .FOPRCN = 0
                .FECINI = 0
                .FECFIN = 0
                .STIPPR = "D"
                .STPODP = objSeguridadBN.pstrTipoAlmacen
                .TIPOALM = objSeguridadBN.pstrTipoAlmacen
                .PSUSUARIO = objSeguridadBN.pUsuario
                .CSRVC = 2
                .NGUIRN = olistMercaderia.Item(0).PNNGUIRN
            End With
            Dim frm As New RANSA.Controls.ServicioOperacion.UcFrmServicioAgregarSA_DS
            frm.oServicio = oServicio
            frm.Text = RANSA.Controls.ServicioOperacion.Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            End If
        End If
        olistMercaderia = New List(Of beMercaderia)
        Me.dgMercaderiaSeleccionada.DataSource = Nothing
        dtgMercaderia_SelectionChanged(Nothing, Nothing)
        Me.Contenedor1.Panel2Collapsed = True
        btnRealizarDespacho.Enabled = True
        btnCancelar_Click(Nothing, Nothing)
    End Sub

    Private Sub txtMarca_Consultar(ByVal strData As String, ByRef objData As Object) Handles txtMarca.Consultar
        Dim obrMercaderia As New brMercaderia
        Dim obemercaderia As New beMercaderia
        With obemercaderia
            .PNCMRCA = Val(strData)
            .PSTCMMRC = strData.ToUpper
            .PageSize = 20
            .PageNumber = 1
        End With
        objData = obrMercaderia.ListaMarca(obemercaderia)
    End Sub

    Private Sub CargarDetalleOS(ByVal obeMercaderia As beMercaderia)
        Limpiar()
        Dim obrMercaderia As New brMercaderia
        Me.dtgKardex.DataSource = obrMercaderia.ListaKardex(obeMercaderia)
    End Sub

    Private Sub Limpiar()
        dtgKardex.AutoGenerateColumns = False
        dtgKardex.DataSource = Nothing
    End Sub

    Private Sub dtgMercaderia_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgMercaderia.SelectionChanged
        If Me.dgMercaderia.CurrentCellAddress.Y = -1 Then
            Limpiar()
            Exit Sub
        End If
        CargarDetalleOS(Me.dgMercaderia.CurrentRow.DataBoundItem)
    End Sub
 
    Private Sub Validar_Usuario_Autoridado()
        'Dim objParametro As New Hashtable
        'Dim objLogica As New brUsuario
        'Dim objEntidad As New beUsuario

        'objParametro.Add("MMCAPL", objLogica.getAppSetting("System_prefix"))
        'objParametro.Add("MMCUSR", objSeguridadBN.pUsuario)
        'objParametro.Add("MMNPVB", Me.Name.Trim)
        'objEntidad = objLogica.Validar_Usuario_Autorizado(objParametro)
        'If objEntidad.STSOP1 = "" Then
        '    btnSerie.Visible = False
        '    tss03.Visible = False
        'Else
        '    btnSerie.Visible = True
        '    tss03.Visible = True
        'End If
    End Sub


    Private Sub bsaDespacharMercaderiaOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaDespacharMercaderiaOS.Click
        If dgMercaderia.CurrentCellAddress.Y = -1 OrElse Me.dtgKardex.CurrentCellAddress.Y = -1 Then Exit Sub

        Dim decQta As Decimal = CType(Me.dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PNQSLMC2
        Dim decPeso As Decimal = CType(Me.dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PNQSLMP2
        Dim decPlanta As Decimal = Convert.ToDecimal(CType(Me.dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PNTDSDES)
        Dim strPlanta As String = CType(Me.dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSTPLNTA
        If decPlanta = UcPLanta_Cmb011.Planta Then
            Dim fSolicInforMovAlmacen As frmSolicInforDesAlmacen = New frmSolicInforDesAlmacen(decQta, decPeso, Me.txtCliente.pCodigo)
            With fSolicInforMovAlmacen
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' INICIO
                    Dim obeMercaderia As New beMercaderia
                    If fSolicInforMovAlmacen.pdecRecCantidad > 0 Then
                        With CType(Me.dgMercaderia.CurrentRow.DataBoundItem, beMercaderia)
                            obeMercaderia.PSCMRCD = .PSCMRCD
                            obeMercaderia.PNNORDSR = .PNNORDSR
                            obeMercaderia.PNNCNTR = .PNNCNTR
                            obeMercaderia.PNNCRCTC = .PNNCRCTC
                            obeMercaderia.PNNAUTR = .PNNAUTR
                            obeMercaderia.PSCUNCNT = .PSCUNCN5
                            obeMercaderia.PSCUNPST = .PSCUNPS5
                            obeMercaderia.pSCUNVLT = .PSCUNVL5
                            obeMercaderia.PSNORCCL = fSolicInforMovAlmacen.pstrNroOrdenCompra
                            obeMercaderia.PSNGUICL = fSolicInforMovAlmacen.pstrNroGuiaCliente
                            obeMercaderia.PSNRUCLL = fSolicInforMovAlmacen.pstrNroRUCCliente
                            obeMercaderia.PSSTPING = fSolicInforMovAlmacen.pstrTipoDespacho
                            obeMercaderia.PSCTPALM = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCTPALM
                            obeMercaderia.PSTALMC = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSTALMC
                            obeMercaderia.PSCALMC = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCALMC
                            obeMercaderia.PSTCMPAL = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSTCMPAL
                            obeMercaderia.PSCZNALM = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCZNALM
                            obeMercaderia.PSTCMZNA = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSTCMZNA
                            obeMercaderia.PNQTRMC = fSolicInforMovAlmacen.pdecRecCantidad
                            obeMercaderia.PNQTRMP = fSolicInforMovAlmacen.pdecRecPeso
                            obeMercaderia.PNQDSVGN = fSolicInforMovAlmacen.pintNroVigencia
                            obeMercaderia.PSFUNDS2 = .PSFUNDS2
                            obeMercaderia.PSCTPDPS = .PSCTPDP6
                            obeMercaderia.PSCTPOCN = False
                            obeMercaderia.PSTOBSRV = fSolicInforMovAlmacen.pstrRecObservacion

                            'CSR-HUNDRED-AJUSTEDESPACHO-210716-INICIO 
                            obeMercaderia.PNQSLMC2 = fSolicInforMovAlmacen.pdecRecCantidad
                            obeMercaderia.PNQSLMP2 = fSolicInforMovAlmacen.pdecRecPeso
                            'CSR-HUNDRED-AJUSTEDESPACHO-210716-FIN

                        End With

                    End If
                    olistMercaderia.Add(obeMercaderia)
                    Me.dgMercaderiaSeleccionada.AutoGenerateColumns = False
                    Me.dgMercaderiaSeleccionada.DataSource = Nothing
                    Me.dgMercaderiaSeleccionada.DataSource = olistMercaderia
                End If
                .Dispose()
                fSolicInforMovAlmacen = Nothing
            End With
        Else
            MessageBox.Show("Ud. no tiene autorización para realizar ingresos en la Planta " & strPlanta, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private _heightUpDown As Int32
    Private _heightDownUp As Int32
    Private _widthLeftRight As Int32

    Private Sub btnRealizarDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarDespacho.Click
        If txtCliente.pCodigo = 0 Then Exit Sub
        If dgMercaderia.RowCount <= 0 Then Exit Sub
        pOcultarInformacionCabecera()
        btnRealizarDespacho.Enabled = False
        btnCancelar.Enabled = True
        Me.Contenedor1.Panel2Collapsed = False
        Me.Contenedor2.Panel2Collapsed = False
        pOcultarInformacionCabecera()
    End Sub

    Private Sub bsaOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaOcultar.Click
        Call pOcultarInformacionCabecera()
    End Sub

    Private Sub pOcultarInformacionCabecera()
    
        'Suspend layout changes until all splitter properties have been updated
        Contenedor2.SuspendLayout()
        ' Is the left header group currently expanded?
        If Contenedor2.FixedPanel = FixedPanel.None Then
            bsaOcultar.Image = bsaOcultar.Image
            bsaOcultar.Text = "  Reducir"
            Contenedor2.FixedPanel = FixedPanel.Panel2
            Contenedor2.IsSplitterFixed = True
            ' Remember the current height of the header group
            ' We have not changed the orientation of the header yet, so the width of 
            ' the splitter panel is going to be the height of the collapsed header group
            Dim newWidth As Integer = hgOS.PreferredSize.Width
            ' Make the header group fixed just as the new height
            Contenedor2.Panel2MinSize = 20
            Contenedor2.SplitterDistance = Me.Width - 25
            ' Change header to be vertical and button to near edge
            hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
            hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right

        Else

            bsaOcultar.Image = bsaOcultar.Image
            bsaOcultar.Text = "  Ampliar"
            ' Make the bottom panel not-fixed in size anymore
            Contenedor2.FixedPanel = FixedPanel.None
            Contenedor2.IsSplitterFixed = False
            ' Put back the minimise size to the original
            Contenedor2.Panel2MinSize = 25
            ' Calculate the correct splitter we want to put back
            Contenedor2.SplitterDistance = hgFiltros.Width - 600
            ' Change header to be horizontal and button to far edge
            hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
            hgOS.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
            'hgOS.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top

        End If
        Contenedor2.ResumeLayout()
    End Sub


    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub
 
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        btnRealizarDespacho.Enabled = True
        btnCancelar.Enabled = False
        Me.Contenedor1.Panel2Collapsed = True
        Me.Contenedor2.Panel2Collapsed = True
        olistMercaderia = New List(Of beMercaderia)
        Me.dgMercaderiaSeleccionada.DataSource = Nothing
    End Sub
 
    Private Sub txtMercaderia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMercaderia.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then
                ListaMercaderia()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
