Imports RANSA.TYPEDEF.Cliente
Imports RANSA.Utilitario
Imports RANSA.TYPEDEF
Imports RANSA.NEGO

Public Class frmRecepcionOS

    Private Sub frmRecepcionOS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Validar_Usuario_Autoridado()
            CargarPlanta()
            CargarClientes()
            CargarControles()
            CargarDeposito()
            UCDataGridView.Alinear_Columnas_Grilla(Me.dtgMercaderia)
            olistMercaderia = New List(Of beMercaderia)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

     
    End Sub

    Private Sub btnAgregarMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoOS.Click

        Try
            Dim ofrmAgregar As New frmAgregarOS
            Dim obeMercaderia As New beMercaderia
            'CargarPlanta()
            With obeMercaderia
                .PNCCLNT = Me.txtCliente.pCodigo
                .PSCTPDP3 = objSeguridadBN.pstrTipoAlmacen
                If dtgMercaderia.CurrentRow IsNot Nothing And dtgMercaderia.Rows.Count > 0 Then
                    Dim lint_indice As Integer = Me.dtgMercaderia.CurrentCellAddress.Y
                    .PNNCNTR = Me.dtgMercaderia.Item("NCNTR", lint_indice).Value.ToString.Trim
                End If

            End With
            ofrmAgregar.beContrato = obeMercaderia
            If ofrmAgregar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ListaMercaderia()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private olistMercaderia As List(Of beMercaderia)


    Private Sub btnIniciarProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciarProceso.Click
        Try
            If dtgMercaderia.RowCount <= 0 Then Exit Sub
            Me.TabControl.SelectedTab = Me.TabMercaderiaIngresar
            Dim fSolicInforMovAlmacen As frmSolicInforRecAlmacen = New frmSolicInforRecAlmacen
            With fSolicInforMovAlmacen
                .pintPlanta = UcPLanta_Cmb011.Planta
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' INICIO
                    Dim obeMercaderia As New beMercaderia
                    With CType(Me.dtgMercaderia.CurrentRow.DataBoundItem, beMercaderia)
                        'obeMercaderia.PSTMRCD2 = dtgMercaderia.CurrentRow .DataBoundItem dtgMercaderia.CurrentRow.Cells("M_TMRCD2").Value.ToString.Trim
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
                        obeMercaderia.PSSTPING = fSolicInforMovAlmacen.pstrTipoRecepcion
                        obeMercaderia.PSCTPALM = fSolicInforMovAlmacen.pstrTipoAlmacen
                        obeMercaderia.PSTALMC = fSolicInforMovAlmacen.pstrDetalleAlmacen
                        obeMercaderia.PSCALMC = fSolicInforMovAlmacen.pstrAlmacen
                        obeMercaderia.PSTCMPAL = fSolicInforMovAlmacen.pstrDetalleTipoAlmacen
                        obeMercaderia.PSCZNALM = fSolicInforMovAlmacen.pstrZonaAlmacen
                        obeMercaderia.PSTCMZNA = fSolicInforMovAlmacen.pstrDetalleZonaAlmacen
                        obeMercaderia.PNQTRMC = fSolicInforMovAlmacen.pdecRecCantidad
                        obeMercaderia.PNQTRMP = fSolicInforMovAlmacen.pdecRecPeso
                        obeMercaderia.PSCCNTD = fSolicInforMovAlmacen.pstrContenedor
                        obeMercaderia.PSCTPOCN = IIf(fSolicInforMovAlmacen.pblnDesglose, "SI", "NO")
                        obeMercaderia.PSFUNDS2 = .PSFUNDS2
                        obeMercaderia.PSCTPDPS = .PSCTPDP6
                        obeMercaderia.PSTOBSRV = fSolicInforMovAlmacen.pstrRecObservacion
                    End With
                    olistMercaderia.Add(obeMercaderia)
                    Me.dgMercaderiaSeleccionada.AutoGenerateColumns = False
                    Me.dgMercaderiaSeleccionada.DataSource = Nothing
                    Me.dgMercaderiaSeleccionada.DataSource = olistMercaderia
                End If
                .Dispose()
                fSolicInforMovAlmacen = Nothing
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

     
    End Sub

    Private Sub btnProcesarRecepcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarRecepcion.Click
        Try
            ProcesarRecepcion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If Me.dtgMercaderia.CurrentCellAddress.Y = -1 Then Exit Sub
            Dim ofrmAgregar As New frmAgregarOS
            ofrmAgregar.beContrato = Me.dtgMercaderia.CurrentRow.DataBoundItem
            With ofrmAgregar.beContrato
                .PNCCLNT = Me.txtCliente.pCodigo
                .PSCTPDP3 = objSeguridadBN.pstrTipoAlmacen
            End With
            If ofrmAgregar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ListaMercaderia()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

   
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
        dtgMercaderia.AutoGenerateColumns = False
        Limpiar()
        Me.dtgMercaderia.DataSource = obrMercaderia.flistListarMercaderiaOS(obeMercaderia)
    End Sub
#End Region
 
    Private Sub CargarPlanta()
        'Ransa.Controls.
        'Dim obePlanta As New Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta
        Dim obePlanta As New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        obePlanta.CCMPN_CodigoCompania = "EZ" 'RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        obePlanta.CDVSN_CodigoDivision = "R"
        UcPLanta_Cmb011.CodigoDivision = obePlanta.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obePlanta.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub CargarDeposito()
        Dim obrTipoDeDeposito As New brTipoDeDeposito
        cmbDeposito.DataSource = obrTipoDeDeposito.ListarTipoDeDeposito()
        cmbDeposito.DisplayMember = "PSTABDPS"
        cmbDeposito.ValueMember = "PSCTPDPS"
        cmbDeposito.SelectedValue = "1"
    End Sub

    Private Sub CargarControles()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CFMLA"
        oColumnas.DataPropertyName = "PSCFMLA"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPFM"
        oColumnas.DataPropertyName = "PSTCMPFM"
        oColumnas.HeaderText = "Descripción "
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
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMMRC"
        oColumnas.DataPropertyName = "PSTCMMRC"
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)
        'Me.UcAyudaConectado1.DataSource = obrMercaderia.ListaMarca(obeFiltro)
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

        Try
            If Me.dgMercaderiaSeleccionada.CurrentCellAddress.Y = -1 Then Exit Sub
            olistMercaderia.Remove(Me.dgMercaderiaSeleccionada.CurrentRow.DataBoundItem)
            Me.dgMercaderiaSeleccionada.DataSource = Nothing
            Me.dgMercaderiaSeleccionada.DataSource = olistMercaderia
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub


    Private Sub ProcesarRecepcion()
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
            Dim obrMercaderia As New brMercaderia
            olistMercaderia.Item(0).PNNGUIRN = obrMercaderia.fintRecepcionMercaderia(olistMercaderia)
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
            'Dim rdocGuiaRemision As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            'Dim dsResultado As DataSet = Nothing
            'dsResultado = obrMercaderia.fdsObtenerGuiaRecepcion(olistMercaderia.Item(0))

            'If Not dsResultado Is Nothing Then
            '    dsResultado.Tables(0).TableName = "dtInformacionGuiaRecepcion"
            '    rdocGuiaRemision = New rptGuiaRecepcion
            '    rdocGuiaRemision.SetDataSource(dsResultado)
            '    rdocGuiaRemision.Refresh()
            '    rdocGuiaRemision.SetParameterValue("pCliente", olistMercaderia.Item(0).PNCCLNT)
            '    rdocGuiaRemision.SetParameterValue("pRazonSocialCliente", olistMercaderia.Item(0).PSTCMPCL)
            '    rdocGuiaRemision.SetParameterValue("pUsuario", olistMercaderia.Item(0).PSUSUARIO)
            '    rdocGuiaRemision.SetParameterValue("pNroGuiaRansa", olistMercaderia.Item(0).PNNGUIRN)
            '    rdocGuiaRemision.SetParameterValue("pEmpresa", olistMercaderia.Item(0).PSTCMPCL)
            '    With frmVisorRPT
            '        .WindowState = FormWindowState.Maximized
            '        .Dock = DockStyle.Fill
            '        .pReportDocument = rdocGuiaRemision
            '        .ShowDialog()
            '    End With
            'End If

            'Return rdocGuiaRemision
            If olistMercaderia.Item(0).GenerarServicio Then
                ' Registro de Servicio
                Dim oServicio As New Ransa.Controls.ServicioOperacion.Servicio_BE
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
                    .STIPPR = "R"
                    .STPODP = objSeguridadBN.pstrTipoAlmacen
                    .TIPOALM = objSeguridadBN.pstrTipoAlmacen
                    .PSUSUARIO = objSeguridadBN.pUsuario
                    .CSRVC = 1
                    .NGUIRN = olistMercaderia.Item(0).PNNGUIRN
                End With
                Dim frm As New Ransa.Controls.ServicioOperacion.UcFrmServicioAgregarSA_DS
                frm.oServicio = oServicio
                frm.Text = Ransa.Controls.ServicioOperacion.Comun.Mensaje("MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN")
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                End If
            End If
            .Dispose()
            fIniciarMovAlmacen = Nothing
        End With
        olistMercaderia = New List(Of beMercaderia)
        Me.dgMercaderiaSeleccionada.DataSource = Nothing
        dtgMercaderia_SelectionChanged(Nothing, Nothing)
    End Sub

    Private Sub txtMarca_Consultar(ByVal strData As String, ByRef objData As Object) Handles txtMarca.Consultar

        Try
            Dim obrMercaderia As New brMercaderia
            Dim obemercaderia As New beMercaderia
            With obemercaderia
                .PNCMRCA = Val(strData)
                .PSTCMMRC = strData.ToUpper
                .PageSize = 20
                .PageNumber = 1
            End With
            objData = obrMercaderia.ListaMarca(obemercaderia)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub


    Private Sub CargarDetalleOS(ByVal obeMercaderia As beMercaderia)
        Limpiar()
        UcPaginacion.PageNumber = 1
        Dim obrMercaderia As New brMercaderia
        Me.dtgKardex.DataSource = obrMercaderia.ListaKardex(obeMercaderia)
        Dim obrInventarioMercaderia As New blInventarioMercaderia()
        Dim oDs As DataSet
        oDs = obrInventarioMercaderia.ListarInventarioMercaderiaxSerie(obeMercaderia)
        If Not oDs Is Nothing AndAlso oDs.Tables.Count > 0 Then
            dgMercaderiaGuiaDet.DataSource = oDs.Tables(0)
        End If
        ListarSolicitudServicioxCliente(obeMercaderia)
    End Sub

    Private Sub Limpiar()
        dgMercaderiaGuiaDet.AutoGenerateColumns = False
        dtgMovimientos.AutoGenerateColumns = False
        dtgKardex.AutoGenerateColumns = False
        dgMercaderiaGuiaDet.DataSource = Nothing
        dtgKardex.DataSource = Nothing
        Me.dtgMovimientos.DataSource = Nothing
    End Sub

    Private Sub ListarSolicitudServicioxCliente(ByVal obeMercaderia As beMercaderia)
        'Try
        Dim oblInventarioMercaderia As New blInventarioMercaderia()
        obeMercaderia.PageSize = UcPaginacion.PageSize
        obeMercaderia.PageNumber = UcPaginacion.PageNumber
        Me.dtgMovimientos.DataSource = oblInventarioMercaderia.Lista_Solicitud_Servicio_por_Cliente(obeMercaderia)
        If TryCast(dtgMovimientos.DataSource, List(Of beMercaderia)).Count > 0 Then
            UcPaginacion.PageCount = TryCast(dtgMovimientos.DataSource, List(Of beMercaderia)).Item(0).PageCount
        End If
        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            If Me.dtgMercaderia.CurrentCellAddress.Y = -1 Then Exit Sub
            ListarSolicitudServicioxCliente(Me.dtgMercaderia.CurrentRow.DataBoundItem)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgMercaderia_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgMercaderia.SelectionChanged
        Try
            If Me.dtgMercaderia.CurrentCellAddress.Y = -1 Then
                Limpiar()
                Exit Sub
            End If
            Me.TabControl.SelectedTab = Me.tabMovimientos
            CargarDetalleOS(Me.dtgMercaderia.CurrentRow.DataBoundItem)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged

        Select Case Me.TabControl.SelectedIndex
            Case 0
                btnProcesarRecepcion.Visible = True
                btnEliminarItem.Visible = True
                tss05.Visible = True
                tss06.Visible = True
            Case Else
                btnProcesarRecepcion.Visible = False
                btnEliminarItem.Visible = False
                tss05.Visible = False
                tss06.Visible = False
        End Select
    End Sub

    Private Sub Validar_Usuario_Autoridado()
        Dim objParametro As New Hashtable
        Dim objLogica As New brUsuario
        Dim objEntidad As New beUsuario

        objParametro.Add("MMCAPL", objLogica.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", objSeguridadBN.pUsuario)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Usuario_Autorizado(objParametro)
        If objEntidad.STSOP1 = "" Then
            btnSerie.Visible = False
            tss03.Visible = False
        Else
            btnSerie.Visible = True
            tss03.Visible = True
        End If
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
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


    Private Sub tsbTransferencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbTransferencias.Click
        Try
            If txtCliente.pCodigo = 0 Then Exit Sub
            Dim ofrmSolicInforRecTransferencia As New frmSolicInforRecTransferencia
            ofrmSolicInforRecTransferencia.pintCCLNT = Me.txtCliente.pCodigo
            ofrmSolicInforRecTransferencia.pintServicio_CSRVC = 1
            ofrmSolicInforRecTransferencia.pstrRazonSocialCliente = Me.txtCliente.pRazonSocial
            ofrmSolicInforRecTransferencia.pstrCCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
            ofrmSolicInforRecTransferencia.pstrCDVSN = "R"
            ofrmSolicInforRecTransferencia.pintCCLNT = Me.txtCliente.pCodigo
            If ofrmSolicInforRecTransferencia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Call ListaMercaderia()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        Try
            ListaMercaderia()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
