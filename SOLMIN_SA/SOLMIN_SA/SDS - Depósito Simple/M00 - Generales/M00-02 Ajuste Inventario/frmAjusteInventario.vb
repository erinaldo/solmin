'Imports Ransa.TYPEDEF.Cliente
Imports Ransa.Utilitario
Imports Ransa.TYPEDEF
Imports Ransa.NEGO
Imports Ransa.NEGO.slnSOLMIN_SDS
Imports Ransa.NEGO.slnSOLMIN_SDS.DespachoSDS
Imports Ransa.TYPEDEF.slnSOLMIN_SDS_SIMPLE

Public Class frmAjusteInventario

    Private intWidth As Integer = 0
    Private olistMercaderia As List(Of beMercaderia)
    Private _TipoAjuste As String = ""
    Private objMovimientoMercaderia As clsMovimientoMercaderia

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
            .PSCTPDP6 = cmbDeposito.SelectedValue
            If IsNumeric(txtMercaderia.Text) Then
                .PNNORDSR = Val(txtMercaderia.Text)
            Else
                .PSTCMPMR = txtMercaderia.Text
            End If

        End With
        dgMercaderia.AutoGenerateColumns = False
        Limpiar()
        Me.dgMercaderia.DataSource = obrMercaderia.flistListarMercaderiaOSNew(obeMercaderia)
        'intWidth = hgOS.Width

        'Me.Contenedor1.Panel2Collapsed = True
        'Me.Contenedor2.Panel2Collapsed = True
        btnCancelar.PerformClick()
    End Sub

#End Region


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        ListaMercaderia()
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


        'oListColum = New Hashtable
        'oColumnas = New DataGridViewTextBoxColumn
        'oColumnas.Name = "CMRCA"
        'oColumnas.DataPropertyName = "PNCMRCA"
        'oColumnas.HeaderText = "Código "
        'oListColum.Add(1, oColumnas)
        'oColumnas = New DataGridViewTextBoxColumn
        'oColumnas.Name = "TCMMRC"
        'oColumnas.DataPropertyName = "PSTCMMRC"
        'oColumnas.HeaderText = "Descripción "
        'oListColum.Add(2, oColumnas)
        'Me.txtMarca.ListColumnas = oListColum
        'Me.txtMarca.Cargas()
        'Me.txtMarca.DispleyMember = "PSTCMMRC"
        'Me.txtMarca.ValueMember = "PNCMRCA"


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
        objMovimientoMercaderia = New clsMovimientoMercaderia
        If dgMercaderiaSeleccionada.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '<[AHM]>
        GLOBAL_COMPANIA = "EZ"
        Dim mensaje = ""
        'If (Not (New brBulto).ValidarLimiteCredito(GLOBAL_COMPANIA, txtCliente.pCodigo, mensaje)) Then
        '    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        '</[AHM]>

        If _TipoAjuste = "P" Then
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
            Call pProcesarDespacho(False)
            btnActualizar.PerformClick()
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
            Call pProcesarDespacho(False)
            btnActualizar.PerformClick()
        End If

    End Sub

    Private Sub txtMarca_Consultar(ByVal strData As String, ByRef objData As Object)
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
        Dim status As String = dgMercaderia.CurrentRow.Cells("FUNDS2").Value
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
                    Dim obeMercaderia As New beMercaderia
                    ' If ofrmDlgAjustes.pdecRecCantidad > 0 Then
                    With CType(Me.dgMercaderia.CurrentRow.DataBoundItem, beMercaderia)
                        obeMercaderia.PSCMRCD = .PSCMRCD
                        obeMercaderia.PSCMRCLR = .PSCMRCLR
                        obeMercaderia.PNNORDSR = .PNNORDSR
                        obeMercaderia.PNNCNTR = .PNNCNTR
                        obeMercaderia.PNNCRCTC = .PNNCRCTC
                        obeMercaderia.PNNAUTR = .PNNAUTR
                        obeMercaderia.PSCUNCNT = .PSCUNCN5
                        obeMercaderia.PSCUNPST = .PSCUNPS5
                        obeMercaderia.pSCUNVLT = .PSCUNVL5
                        obeMercaderia.PSNORCCL = 0
                        obeMercaderia.PSNGUICL = 0
                        obeMercaderia.PSNRUCLL = 0
                        obeMercaderia.PSSTPING = ofrmDlgAjustes.pstrTipoDespacho
                        obeMercaderia.PSCTPALM = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCTPALM
                        obeMercaderia.PSTALMC = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSTALMC
                        obeMercaderia.PSCALMC = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCALMC
                        obeMercaderia.PSTCMPAL = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSTCMPAL
                        obeMercaderia.PSCZNALM = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSCZNALM
                        obeMercaderia.PSTCMZNA = CType(dtgKardex.CurrentRow.DataBoundItem, beMercaderia).PSTCMZNA
                        obeMercaderia.PNQTRMC = ofrmDlgAjustes.pdecRecCantidad
                        obeMercaderia.PNQTRMP = ofrmDlgAjustes.pdecRecPeso
                        obeMercaderia.PNQDSVGN = 0
                        obeMercaderia.PSFUNDS2 = .PSFUNDS2
                        obeMercaderia.PSCTPOCN = False
                        obeMercaderia.PSCTPDPS = .PSCTPDP6
                        obeMercaderia.PSTOBSRV = ofrmDlgAjustes.pstrRecObservacion
                    End With

                    'End If
                    olistMercaderia.Add(obeMercaderia)
                    Me.dgMercaderiaSeleccionada.AutoGenerateColumns = False
                    Me.dgMercaderiaSeleccionada.DataSource = Nothing
                    Me.dgMercaderiaSeleccionada.DataSource = olistMercaderia
                End If
            End With
        End If

    End Sub


    Private _heightUpDown As Int32
    Private _heightDownUp As Int32
    Private _widthLeftRight As Int32

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
        ' btnRealizarDespacho.Enabled = True
        btnCancelar.Enabled = False
        Me.Contenedor1.Panel2Collapsed = True
        Me.Contenedor2.Panel2Collapsed = True
        'Me.btnAjustePositivo.Enabled = True
        'Me.btnAjusteNegativo.Enabled = True
        Me.btnAjustePositivo.Visible = True
        Me.btnAjusteNegativo.Visible = True
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

    Private Sub btnAjustePositivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAjustePositivo.Click
        _TipoAjuste = "P"
        bsaDespacharMercaderiaOS.Text = "Ajuste Despacho (+)"
        Call RealizarDespacho()
    End Sub

    Private Sub btnAjusteNegativo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAjusteNegativo.Click
        _TipoAjuste = "N"
        bsaDespacharMercaderiaOS.Text = "Ajuste Despacho (-)"
        Call RealizarDespacho()
    End Sub
    Private Sub RealizarDespacho()
        If txtCliente.pCodigo = 0 Then Exit Sub
        If dgMercaderia.RowCount <= 0 Then Exit Sub
        pOcultarInformacionCabecera()
        ' btnRealizarDespacho.Enabled = False
        'btnAjusteNegativo.Enabled = False
        ' btnAjustePositivo.Enabled = False
        btnAjusteNegativo.Visible = False
        btnAjustePositivo.Visible = False
        btnCancelar.Enabled = True
        Me.Contenedor1.Panel2Collapsed = False
        Me.Contenedor2.Panel2Collapsed = False
        pOcultarInformacionCabecera()
    End Sub
    Private Sub pProcesarDespacho(ByVal blnCheckServicio As Boolean)
        If objMovimientoMercaderia.plstItemMovimientoMercaderia.Count <= 0 Then
            MessageBox.Show("No se ha agregado Item.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim intNroGuiaRansa As Int64 = 0
            Dim resultadoEnvioInterfaz As String = ""
            If mfblnDespacho_Mercaderia(resultadoEnvioInterfaz, objMovimientoMercaderia, blnCheckServicio, intNroGuiaRansa) Then
                Dim objFiltro As New slnSOLMIN_SDS.DespachoSDS.Reportes.clsFiltros_ReporteGuiaDespacho
                With objFiltro
                    .pintCodigoCliente_CCLNT = objMovimientoMercaderia.pintCodigoCliente_CCLNT
                    .pstrRazonSocialCliente_TCMPCL = objMovimientoMercaderia.pstrRazonSocialCliente_TCMPCL
                    .pstrRazonSocialEmpresa = GLOBAL_EMRESA
                    .pintNroGuiaRansa_NGUIRN = intNroGuiaRansa
                End With
                pVisualizarGuiaRansa(objFiltro)
                'Call pActualizarInformacion()
            End If

        End If
    End Sub
    Private Sub pVisualizarGuiaRansa(ByVal pobjFiltro As slnSOLMIN_SDS.DespachoSDS.Reportes.clsFiltros_ReporteGuiaDespacho)
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

    Private Sub bsaOcultarFiltros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaOcultarFiltros.Click

    End Sub
End Class


