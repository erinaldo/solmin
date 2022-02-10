Imports Ransa.Utilitario
Imports System.Windows.Forms
'Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class ucCotizacion
    Enum MANTENIMIENTO_OPC
        NEUTRAL = 0
        NUEVO = 1
        EDITAR = 2
        'ELIMINAR = 3
        'MODIFICAR = 4
    End Enum
    '"TabPage1"
    ' "TabPage2"
    'Private bolBuscar As Boolean
    'Private objCompaniaBLL As New Compania_BLL
    'Private objPlanta As New Planta_BLL
    'Private objDivision As New Division_BLL
    'Private lstrTipoCuenta As String = ""
    'Private lstrCuentaSap As String = ""
    'Private lindice As Integer = 0
    'Private objMoneda As New Moneda_BLL
    'Dim objPlantaFacturacion As New PlantaFacturacion_BLL
    'Private gEnum_Mantenimiento As MANTENIMIENTO
    Private Enum_Mantenimiento As MANTENIMIENTO_OPC
    'Dim lbooEstado As Boolean = True  ' Estado modificacion del mantenimiento
    Private objEntidadAcceso As mantenimientos.ClaseGeneral
    Private bs As New BindingSource
    'Private strCompania As String = ""
    Private tabSeleccionado As String = ""
    'Private _pUsuario As String = ConfigurationWizard.UserName
    Private _pUsuario As String = ""
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property
    Private _pSystem_Prefix As String = ""
    Public Property pSystem_Prefix() As String
        Get
            Return _pSystem_Prefix
        End Get
        Set(ByVal value As String)
            _pSystem_Prefix = value
        End Set
    End Property
    Private _pNameFormulario As String = ""
    Public Property pNameFormulario() As String
        Get
            Return _pNameFormulario
        End Get
        Set(ByVal value As String)
            _pNameFormulario = value
        End Set
    End Property

 

    Private Sub CargaEstado()
        Dim dtEstado As New DataTable
        Dim dr As DataRow
        dtEstado.Columns.Add("DISPLAY")
        dtEstado.Columns.Add("VALUE")
        dr = dtEstado.NewRow
        dr("DISPLAY") = "TODOS"
        dr("VALUE") = "T"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "PENDIENTE"
        dr("VALUE") = "P"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "CERRADO"
        dr("VALUE") = "G"
        dtEstado.Rows.Add(dr)
        cmbEstado.DataSource = dtEstado
        cmbEstado.DisplayMember = "DISPLAY"
        cmbEstado.ValueMember = "VALUE"


        cmbEstado.SelectedValue = "G"
    End Sub




    '"TabPage1"
    ' "TabPage2"

    Private Sub HabilitarOpcion(ByVal opc As MANTENIMIENTO_OPC)
        Dim tabSelec As String = TabcCotizacion.SelectedTab.Name
        Select Case tabSelec
            Case "TabPage1"
                Select Case opc
                    Case MANTENIMIENTO_OPC.NEUTRAL
                        btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnNuevo.Enabled = True
                        'btnModificar.Enabled = True
                        btnGuardar.Visible = False
                        btnGuardar.Enabled = False
                        btnCancelar.Enabled = False
                        'btnEliminar.Enabled = True
                        btnImprimir.Enabled = True
                        btnCopiarCotizacion.Enabled = True
                        btnGenerarOSDetalleCotizacion.Enabled = False

                        Estado_Controles(False)

                        Dim estadoCot As String = ""
                        If dtgCotizacion.Rows.Count > 0 Then
                            estadoCot = ("" & dtgCotizacion.CurrentRow.Cells("SESTCT").Value).ToString.Trim
                            btnModificar.Enabled = estadoCot.Equals("P")
                            btnEliminar.Enabled = estadoCot.Equals("P")
                        Else
                            estadoCot = cmbEstado.SelectedValue
                            btnModificar.Enabled = estadoCot.Equals("P")
                            btnEliminar.Enabled = estadoCot.Equals("P")
                        End If
                        'btnGuardar.Enabled = dtgCotizacion.Item("SESTCT", dtgCotizacion.CurrentCellAddress.Y).Value.ToString.Trim.Equals("P")
                        'btnEliminar.Enabled = dtgCotizacion.Item("SESTCT", dtgCotizacion.CurrentCellAddress.Y).Value.ToString.Trim.Equals("P")
                        'Me.gEnum_Mantenimiento = mantenimiento.MODIFICAR
                    Case MANTENIMIENTO_OPC.EDITAR
                        btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnGuardar.Visible = True
                        btnGuardar.Enabled = True
                        btnCancelar.Enabled = True
                        btnEliminar.Enabled = False
                        btnImprimir.Enabled = False
                        btnCopiarCotizacion.Enabled = False
                        btnGenerarOSDetalleCotizacion.Enabled = False

                        Estado_Controles(True)
                    Case MANTENIMIENTO_OPC.NUEVO
                        btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnGuardar.Visible = True
                        btnGuardar.Enabled = True
                        btnCancelar.Enabled = True
                        btnEliminar.Enabled = False
                        btnImprimir.Enabled = False
                        btnCopiarCotizacion.Enabled = False
                        btnGenerarOSDetalleCotizacion.Enabled = False

                        Estado_Controles(True)
                End Select
            Case "TabPage2"

                Select Case opc
                    Case MANTENIMIENTO_OPC.NEUTRAL
                        btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = True
                        btnGuardar.Visible = False
                        btnGuardar.Enabled = False
                        btnCancelar.Enabled = False
                        btnEliminar.Enabled = True
                        btnImprimir.Enabled = True
                        btnCopiarCotizacion.Enabled = True
                        btnGenerarOSDetalleCotizacion.Enabled = True

                        Dim estadoCot As String = ""
                        If dtgCotizacion.Rows.Count > 0 Then
                            estadoCot = ("" & dtgCotizacion.CurrentRow.Cells("SESTCT").Value).ToString.Trim
                            btnModificar.Enabled = estadoCot.Equals("P")
                            btnEliminar.Enabled = estadoCot.Equals("P")
                        Else
                            estadoCot = cmbEstado.SelectedValue
                            btnModificar.Enabled = estadoCot.Equals("P")
                            btnEliminar.Enabled = estadoCot.Equals("P")
                        End If

                        Estado_Controles(False)
                    Case MANTENIMIENTO_OPC.EDITAR
                        btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = True
                        btnGuardar.Visible = False
                        btnGuardar.Enabled = False
                        btnCancelar.Enabled = False
                        btnEliminar.Enabled = True
                        btnImprimir.Enabled = False
                        btnCopiarCotizacion.Enabled = False
                        btnGenerarOSDetalleCotizacion.Enabled = True

                        Estado_Controles(False)

                    Case MANTENIMIENTO_OPC.NUEVO
                        btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = True
                        btnGuardar.Visible = False
                        btnGuardar.Enabled = False
                        btnCancelar.Enabled = False
                        btnEliminar.Enabled = True
                        btnImprimir.Enabled = False
                        btnCopiarCotizacion.Enabled = False
                        btnGenerarOSDetalleCotizacion.Enabled = True

                        Estado_Controles(False)
                End Select

        End Select

    End Sub

    Sub pInicializar()
        Try
            tabSeleccionado = TabcCotizacion.SelectedTab.Name
            CargaEstado()
            Me.dtgCotizacion.DataSource = Nothing
            dtgDetalleCotizacion.DataSource = Nothing
            dtgCotizacion.AutoGenerateColumns = False
            Me.dtgDetalleCotizacion.AutoGenerateColumns = False
            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
            Me.Alinear_Columnas_Grilla()
            Me.Cargar_Compania()

            'Me.CargarControles()
            'Me.CargarControles()
            ' Me.cmbEstado.SelectedIndex = 2
            Me.Validar_Usuario_Autoridado()
            'Me.btnGenerarOSDetalleCotizacion.Enabled = False
            'Me.btnAgregarDetalleCotizacion.Enabled = False
            Me.txtCliente.pUsuario = _pUsuario 'USUARIO
            Me.txtClienteFiltro.CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            Me.txtCliente.CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            Me.Limpiar_Control()
            'Me.Estado_Controles(False)
            Me.HeaderDatos.ValuesPrimary.Heading = ""
            'Me.Estado_Controles(False)
            Me.HeaderDatos.ValuesPrimary.Heading = ""
            'Me.dtgCotizacion.DataSource = Nothing
            Me.CargarCombos()
      
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub CargarControles()
    'Me.txtCliente.pClear()
    'Me.txtClienteFiltro.pClear()
    'Me.txtClienteFiltro.pUsuario = USUARIO
    'Me.txtCliente.pUsuario = _pUsuario 'USUARIO
    'Me.txtClienteFiltro.CCMPN = Me.cboCompania.CCMPN_CodigoCompania
    'Me.txtCliente.CCMPN = Me.cboCompania.CCMPN_CodigoCompania
    'Me.btnNuevo.Enabled = True
    'Me.btnGuardar.Enabled = False
    'Me.btnCancelar.Enabled = False
    'Me.btnEliminar.Enabled = False
    'Me.btnAceptar.Enabled = False
    'Me.gEnum_Mantenimiento = mantenimiento.NEUTRAL
    'Me.Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
    'HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
    'Me.Limpiar_Controles(Me.PanelMantenimiento)
    'Me.Limpiar_Control()
    'Me.Estado_Controles(False, PanelMantenimiento)
    'Me.Estado_Controles(False)
    'Me.HeaderDatos.ValuesPrimary.Heading = ""
    'Me.dtgDetalleCotizacion.DataSource = Nothing
    'Me.dtgCotizacion.DataSource = Nothing
    'Me.dtgCotizacion.Enabled = True
    'Me.CargarCombos()
    'End Sub

    'Private Sub HabilitarDesabilitarCombosEmpresa(ByVal comboCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox, ByVal comboDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox, ByVal comboPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox, ByVal estado As Boolean)
    '    comboCompania.Enabled = estado
    '    comboDivision.Enabled = estado
    '    comboPlanta.Enabled = estado
    'End Sub

    Private Sub Mantenimiento_Detalle_Cotizacion(Optional ByVal bolModificar As Double = False)
        If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim objfrmDetalleCotizacion As New frmDetalleCotizacion
        'If Existe_Ventana(frmDetalleCotizacion.Name) Then Exit Sub
        If Existe_Ventana(objfrmDetalleCotizacion.Name) Then Exit Sub
        With objfrmDetalleCotizacion
            .HeaderDatos.ValuesPrimary.Heading = "Número de cotización :" & Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value & " -  " & " / Cliente :" & Me.txtCliente.pRazonSocial
            .mNCTZCN = Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value
            .mCCLNT = Me.dtgCotizacion.CurrentRow.Cells("CCLNT").Value
            .mESTADO = Me.dtgCotizacion.CurrentRow.Cells("SESTCT").Value
            .mFVGCTZ = Me.dtgCotizacion.CurrentRow.Cells("FVGCTZ").Value
            .mCCMPN = Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value
            .mCDVSN = Me.dtgCotizacion.CurrentRow.Cells("CDVSN").Value
            .objEntidadAcceso = objEntidadAcceso
            .mSESTCT = Me.dtgCotizacion.CurrentRow.Cells("SESTCT").Value
            .pUsuario = _pUsuario
            If bolModificar Then
                If Me.dtgDetalleCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
                .HeaderDatos.ValuesPrimary.Heading = "Número de cotización :" & Me.dtgDetalleCotizacion.CurrentRow.Cells("NCTZCN_DET").Value & " -  " & Me.dtgDetalleCotizacion.CurrentRow.Cells("NCRRCT").Value & " / Cliente :" & Me.txtCliente.pRazonSocial
                .obeDetalleCotizacion.NCRRCT = dtgDetalleCotizacion.CurrentRow.Cells("NCRRCT").Value
                .obeDetalleCotizacion.CMRCDR = dtgDetalleCotizacion.CurrentRow.Cells("CMRCDR").Value
                .obeDetalleCotizacion.CUNDMD = dtgDetalleCotizacion.CurrentRow.Cells("CUNDMD").Value
                .obeDetalleCotizacion.CFRMPG = dtgDetalleCotizacion.CurrentRow.Cells("CFRMPG").Value
                .obeDetalleCotizacion.SSGRCT = dtgDetalleCotizacion.CurrentRow.Cells("SSGRCT").Value
                .obeDetalleCotizacion.CCMPSG = dtgDetalleCotizacion.CurrentRow.Cells("CCMPSG").Value
                .obeDetalleCotizacion.NPLSGC = dtgDetalleCotizacion.CurrentRow.Cells("NPLSGC").Value
                .obeDetalleCotizacion.QPRCS1 = dtgDetalleCotizacion.CurrentRow.Cells("QPRCS1").Value
                .obeDetalleCotizacion.QMRCDR = dtgDetalleCotizacion.CurrentRow.Cells("QMRCDR").Value
                .obeDetalleCotizacion.PMRCDR = dtgDetalleCotizacion.CurrentRow.Cells("PMRCDR").Value
                .obeDetalleCotizacion.VMRCDR = dtgDetalleCotizacion.CurrentRow.Cells("VMRCDR").Value
                .obeDetalleCotizacion.LMRCDR = dtgDetalleCotizacion.CurrentRow.Cells("LMRCDR").Value
                .obeDetalleCotizacion.TRFMRC = dtgDetalleCotizacion.CurrentRow.Cells("TRFMRC").Value
                .obeDetalleCotizacion.CTPOSR = dtgDetalleCotizacion.CurrentRow.Cells("CTPOSR").Value
                .obeDetalleCotizacion.CTPSBS = dtgDetalleCotizacion.CurrentRow.Cells("CTPSBS").Value
                .obeDetalleCotizacion.CTPUNV = dtgDetalleCotizacion.CurrentRow.Cells("CTPUNV").Value
                .obeDetalleCotizacion.CFRAPG = dtgDetalleCotizacion.CurrentRow.Cells("CFRAPG").Value
                .obeDetalleCotizacion.SESTOS = dtgDetalleCotizacion.CurrentRow.Cells("SESTOS").Value
            End If
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
                HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
                'If dtgCotizacion.CurrentCellAddress.Y < 0 OrElse Not dtgCotizacion.CurrentRow.Selected Then Exit Sub
                'ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
                ListaDetalleCotizacion()
            End If
        End With

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            'Me.Cursor = Cursors.WaitCursor
            'If Me.gEnum_Mantenimiento = mantenimiento.NUEVO Or Me.gEnum_Mantenimiento = mantenimiento.EDITAR Then
            '    'HelpClassST.MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
            '    MessageBox.Show("Debe guardar el registro actual o cancelarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    'Me.Cursor = Cursors.Default
            '    Exit Sub
            'End If
            'btnNuevo.Enabled = True
            'btnGuardar.Enabled = False
            'btnCancelar.Enabled = False
            'btnEliminar.Enabled = False
            'btnAceptar.Enabled = False
            dtgCotizacion.DataSource = Nothing
            dtgDetalleCotizacion.DataSource = Nothing
            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
            Limpiar_Control()
            'Estado_Controles(False)
            'Limpiar_Controles(Me.PanelMantenimiento)
            ListaCotizaciones()
            'Me.Cursor = Cursors.Default
        Catch ex As Exception
            'Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub InicializarFormulario(ByVal bolCargarControles As Boolean)
    '  Me.txtCliente.pClear()
    '  Me.dtgDetalleCotizacion.DataSource = Nothing
    '  Me.dtgCotizacion.DataSource = Nothing
    '  Me.dtgCotizacion.Enabled = True
    '  Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '  Me.Limpiar_Controles(Me.PanelMantenimiento)
    '  Me.btnNuevo.Enabled = True
    '  Me.btnGuardar.Enabled = False
    '  Me.btnCancelar.Enabled = False
    '  Me.btnEliminar.Enabled = False
    '  Me.btnAceptar.Enabled = False
    '  Me.Estado_Controles(False, PanelMantenimiento)
    '  Me.HeaderDatos.ValuesPrimary.Heading = ""
    'End Sub

    'Private Sub dtgCotizacion_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCotizacion.SelectionChanged
    '  Try
    '    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '      lbooEstado = False
    '    End If
    '    If lbooEstado Then DetalleCotizacion()
    '  Catch ex As Exception

    '  End Try

    'End Sub

    '"TabPage1"
    ' "TabPage2"

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim TabSel As String = TabcCotizacion.SelectedTab.Name
            Select Case TabSel
                Case "TabPage1"
                    If dtgCotizacion.CurrentRow Is Nothing Then
                        Exit Sub
                    End If
                    Enum_Mantenimiento = MANTENIMIENTO_OPC.EDITAR
                    HabilitarOpcion(MANTENIMIENTO_OPC.EDITAR)
                    'Estado_Controles(True)
                Case "TabPage2"
                    Mantenimiento_Detalle_Cotizacion(True)
            End Select

            '    Me.Estado_Controles(True, PanelMantenimiento, 0)
            '    btnGuardar.Text = "Guardar"
            '    btnNuevo.Enabled = False
            '    btnCancelar.Enabled = True
            '    btnEliminar.Enabled = False
            '    Me.dtgCotizacion.Enabled = False
            '    Me.gEnum_Mantenimiento = mantenimiento.EDITAR
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim TabSel As String = TabcCotizacion.SelectedTab.Name
            Select Case TabSel
                Case "TabPage1"
                    Select Case Enum_Mantenimiento
                        Case MANTENIMIENTO_OPC.EDITAR
                            If Validar() Then
                                Modificar_Cotizacion()
                            End If
                        Case MANTENIMIENTO_OPC.NUEVO
                            If Validar() Then
                                Guardar_Cotizacion()
                            End If
                    End Select
                    'If Me.gEnum_Mantenimiento = mantenimiento.NUEVO Then
                    '    If Validar() Then
                    '        Guardar_Cotizacion()
                    '    End If
                    'ElseIf Me.gEnum_Mantenimiento = mantenimiento.EDITAR Then
                    '    If Validar() Then
                    '        Modificar_Cotizacion()
                    '    End If
                    'ElseIf Me.gEnum_Mantenimiento = mantenimiento.MODIFICAR Then
                    '    Me.Estado_Controles(True, PanelMantenimiento, 0)
                    '    btnGuardar.Text = "Guardar"
                    '    btnNuevo.Enabled = False
                    '    btnCancelar.Enabled = True
                    '    btnEliminar.Enabled = False
                    '    Me.dtgCotizacion.Enabled = False
                    '    Me.gEnum_Mantenimiento = mantenimiento.EDITAR
                    'End If
                    'Case "TabPage2"
                    '    Mantenimiento_Detalle_Cotizacion(True)
            End Select

            'Select Case Me.TabcCotizacion.SelectedIndex
            '    Case 0
            '        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            '            If Validar() Then
            '                Guardar_DetalleCotizacion()
            '            End If
            '        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            '            If Validar() Then
            '                Modificar_Cotizacion()
            '            End If
            '        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            '            Me.Estado_Controles(True, PanelMantenimiento, 0)
            '            btnGuardar.Text = "Guardar"
            '            btnNuevo.Enabled = False
            '            btnCancelar.Enabled = True
            '            btnEliminar.Enabled = False
            '            Me.dtgCotizacion.Enabled = False
            '            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            '        End If
            '    Case 1
            '        Mantenimiento_Detalle_Cotizacion(True)
            'End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            'AccionCancelar()
            'Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            'HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
            Me.Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
            Limpiar_Control()
            AsignarDatosCotizacion()
            ListaDetalleCotizacion()
            'If dtgCotizacion.CurrentRow IsNot Nothing Then
            'ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
            'ListaDetalleCotizacion()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim TabSel As String = TabcCotizacion.SelectedTab.Name
            Select Case TabSel
                Case "TabPage1"
                    If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
                    'If HelpClassST.RspMsgBox("¿Desea eliminar la cotización N° " & Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value & " ?") = MsgBoxResult.Yes Then
                    If MessageBox.Show("¿Desea eliminar la cotización N° " & Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Eliminar_Cotizacion()
                        'Limpiar_Controles(PanelMantenimiento)
                        'Limpiar_Control()
                    End If
                Case "TabPage2"
                    If Me.dtgDetalleCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
                    'If HelpClassST.RspMsgBox("¿Desea eliminar el detalle de la cotización " & Me.dtgDetalleCotizacion.CurrentRow.Cells("NCTZCN_DET").Value & " - " & dtgDetalleCotizacion.CurrentRow.Cells("NCRRCT").Value & "?") = MsgBoxResult.Yes Then
                    If MessageBox.Show("¿Desea eliminar el detalle de la cotización " & Me.dtgDetalleCotizacion.CurrentRow.Cells("NCTZCN_DET").Value & " - " & dtgDetalleCotizacion.CurrentRow.Cells("NCRRCT").Value & "?", "Aviso", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                        Eliminar_Detalle_Cotizacion()
                    End If
            End Select
            'Select Case TabcCotizacion.SelectedIndex
            '    Case 0
            '        If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
            '        'If HelpClassST.RspMsgBox("¿Desea eliminar la cotización N° " & Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value & " ?") = MsgBoxResult.Yes Then
            '        If MessageBox.Show("¿Desea eliminar la cotización N° " & Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value & " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            '            Eliminar()
            '            Limpiar_Controles(PanelMantenimiento)
            '        End If
            '    Case 1
            '        If Me.dtgDetalleCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
            '        'If HelpClassST.RspMsgBox("¿Desea eliminar el detalle de la cotización " & Me.dtgDetalleCotizacion.CurrentRow.Cells("NCTZCN_DET").Value & " - " & dtgDetalleCotizacion.CurrentRow.Cells("NCRRCT").Value & "?") = MsgBoxResult.Yes Then
            '        If MessageBox.Show("¿Desea eliminar el detalle de la cotización " & Me.dtgDetalleCotizacion.CurrentRow.Cells("NCTZCN_DET").Value & " - " & dtgDetalleCotizacion.CurrentRow.Cells("NCRRCT").Value & "?", "Aviso", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            '            Eliminar_Detalle_Cotizacion()
            '        End If
            'End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Eliminar_Detalle_Cotizacion()
        If Me.dtgDetalleCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim oblDetalleCotizacion As New DetalleCotizacion_BLL
        Dim obeDetalleCotizacion As New Detalle_Cotizacion
        With Me.dtgDetalleCotizacion.CurrentRow
            obeDetalleCotizacion.NCTZCN = .Cells("NCTZCN").Value
            obeDetalleCotizacion.NCRRCT = .Cells("NCRRCT").Value
            obeDetalleCotizacion.CCMPN = Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value
        End With
        Dim dblResultado As Double
        dblResultado = oblDetalleCotizacion.Eliminar(obeDetalleCotizacion)
        If dblResultado = 0 Then
            'If dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
            'ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
            ListaDetalleCotizacion()
        ElseIf (dblResultado = -1) Then
            'HelpClassST.MsgBox("Mercadería Tiene Asociado Servicios, por favor verifique")
            MessageBox.Show("Mercadería Tiene Asociado Servicios, por favor verifique", "Aviso", MessageBoxButtons.OK)
            'Else
            '    'HelpClassST.ErrorMsgBox()
            '    MessageBox.Show("La operación no pudo completarse.Ha ocurrido un error", "Aviso", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            Dim TabSeleccionado As String = TabcCotizacion.SelectedTab.Name
            Select Case TabSeleccionado
                Case "TabPage1"
                    'Nuevo()
                    'gEnum_Mantenimiento = mantenimiento.NUEVO
                    dtgDetalleCotizacion.DataSource = Nothing
                    Enum_Mantenimiento = MANTENIMIENTO_OPC.NUEVO
                    HabilitarOpcion(MANTENIMIENTO_OPC.NUEVO)
                    'btnNuevo.Enabled = False
                    'btnGuardar.Text = "Guardar"
                    'btnGuardar.Enabled = True
                    'btnCancelar.Enabled = True
                    'btnEliminar.Enabled = False
                    'Limpiar_Controles(Me.PanelMantenimiento)
                    Limpiar_Control()
                    'Estado_Controles(True)
                    'Me.cmbTipoCobro.SelectedIndex = 0
                    Me.cmbTipoCobro.SelectedValue = "R"
                    Me.txtPlantaFacturacion.Codigo = Me.cboPlanta.Planta
                    Me.chkServicioAfecto.Checked = True

                    'Estado_Controles(True, PanelMantenimiento)
                    'If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
                    'Me.dtgCotizacion.CurrentRow.Selected = False
                    'Me.dtgCotizacion.CurrentCell = Nothing
                    'Me.dtgCotizacion.Enabled = IIf(Me.dtgCotizacion.RowCount = 0, True, False)
                Case "TabPage2"
                    'EnviaParametros()
                    'Try
                    'If HelpClass.RspMsgBox("¿Desea Ingresar Detalle de cotización?") = MsgBoxResult.Yes Then
                    If dtgCotizacion.CurrentRow Is Nothing Then
                        Exit Sub
                    End If
                    Dim objfrmDetalleCotizacion As New frmDetalleCotizacion
                    With objfrmDetalleCotizacion
                        .HeaderDatos.ValuesPrimary.Heading = "Número de cotización: " & Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value & " -  " & " / Cliente: " & Me.txtCliente.pRazonSocial
                        .mNCTZCN = Convert.ToDouble(dtgCotizacion.CurrentRow.Cells("NCTZCN").Value) 'olbeCotizacion.Item(0).NCTZCN
                        .mCCLNT = Convert.ToDouble(dtgCotizacion.CurrentRow.Cells("CCLNT").Value) 'olbeCotizacion.Item(0).CCLNT
                        .mESTADO = dtgCotizacion.CurrentRow.Cells("SESTCT").Value 'olbeCotizacion.Item(0).SESTCT
                        .mFVGCTZ = dtgCotizacion.CurrentRow.Cells("FVGCTZ").Value 'olbeCotizacion.Item(0).FVGCTZ
                        .mCCMPN = dtgCotizacion.CurrentRow.Cells("CCMPN").Value  'olbeCotizacion.Item(0).CCMPN
                        .mCDVSN = dtgCotizacion.CurrentRow.Cells("CDVSN").Value  'olbeCotizacion.Item(0).CDVSN
                        .mSESTCT = dtgCotizacion.CurrentRow.Cells("SESTCT").Value  'olbeCotizacion.Item(0).SESTCT
                        .pUsuario = _pUsuario
                        .objEntidadAcceso = objEntidadAcceso
                        .ShowDialog()
                        Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
                        HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
                        'ListaDetalleCotizacion(Convert.ToDouble(dtgCotizacion.CurrentRow.Cells("NCTZCN").Value), dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
                        ListaDetalleCotizacion()

                        'If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        '    Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
                        '    HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
                        '    'ListaDetalleCotizacion(Convert.ToDouble(dtgCotizacion.CurrentRow.Cells("NCTZCN").Value), dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
                        '    ListaDetalleCotizacion()
                        'End If
                    End With
            End Select

            'Select Case TabcCotizacion.SelectedIndex
            '    Case 0
            '        Nuevo()
            '        Me.dtgCotizacion.Enabled = IIf(Me.dtgCotizacion.RowCount = 0, True, False)
            '    Case 1
            '        '  If dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
            '        '  If Me.dtgCotizacion.CurrentRow.Cells("SESTCT").Value.ToString.Trim.Equals("G") Then
            '        '    HelpClass.MsgBox("La cotización  N° " & Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value & " está cerrada; " & Chr(13) & "No se puede crear Detalle de cotización", MessageBoxIcon.Information)
            '        '    Exit Sub
            '        'End If

            '        'Mantenimiento_Detalle_Cotizacion()
            '        EnviaParametros()
            'End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub Nuevo()
    '    'gEnum_Mantenimiento = mantenimiento.NUEVO
    '    Enum_Mantenimiento = MANTENIMIENTO_OPC.NUEVO
    '    'btnNuevo.Enabled = False
    '    'btnGuardar.Text = "Guardar"
    '    'btnGuardar.Enabled = True
    '    'btnCancelar.Enabled = True
    '    'btnEliminar.Enabled = False
    '    'Limpiar_Controles(Me.PanelMantenimiento)
    '    Limpiar_Control()
    '    Me.cmbTipoCobro.SelectedIndex = 0
    '    Me.txtPlantaFacturacion.Codigo = Me.cboPlanta.Planta
    '    Me.chkServicioAfecto.Checked = True
    '    'Estado_Controles(True, PanelMantenimiento)
    '    Estado_Controles(True)
    '    If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
    '    Me.dtgCotizacion.CurrentRow.Selected = False
    '    Me.dtgCotizacion.CurrentCell = Nothing
    'End Sub

    'Private Sub dtgCotizacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCotizacion.CellClick
    '    Try
    '        If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
    '        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '            If Me.dtgCotizacion.Rows.Count > 0 Then
    '                lbooEstado = False
    '            End If
    '            'HelpClassST.MsgBox("Debe guardar o cancelar.", MsgBoxStyle.Exclamation)
    '            MessageBox.Show("Debe guardar o cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If
    '        btnGuardar.Text = "Modificar"
    '        btnGuardar.Enabled = dtgCotizacion.Item("SESTCT", dtgCotizacion.CurrentCellAddress.Y).Value.ToString.Trim.Equals("P")
    '        btnEliminar.Enabled = dtgCotizacion.Item("SESTCT", dtgCotizacion.CurrentCellAddress.Y).Value.ToString.Trim.Equals("P")
    '        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    '        Limpiar_Controles(Me.PanelMantenimiento)
    '        Me.DetalleCotizacion()
    '        lbooEstado = True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub




    'Private Sub dtgCotizacion_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCotizacion.CurrentCellChanged
    '  Try
    '    If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
    '    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '      If Me.dtgCotizacion.Rows.Count > 0 Then
    '        lbooEstado = False
    '      End If
    '      HelpClass.MsgBox("Debe guardar o cancelar.", MsgBoxStyle.Exclamation)
    '      Exit Sub
    '    End If

    '    btnGuardar.Text = "Modificar"
    '    btnGuardar.Enabled = dtgCotizacion.CurrentRow.Cells("SESTCT").Value.ToString.Trim.Equals("P")
    '    btnEliminar.Enabled = dtgCotizacion.CurrentRow.Cells("SESTCT").Value.ToString.Trim.Equals("P")
    '    Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    '    Limpiar_Controles(Me.PanelMantenimiento)
    '    Me.DetalleCotizacion()
    '    lbooEstado = True
    '    Me.Cursor = Cursors.Default
    '  Catch ex As Exception
    '    Me.Cursor = Cursors.Default
    '  End Try
    'End Sub

    'Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    '  Try
    '    If Me.btnAceptar.Text.Trim.Equals("Aceptar") Then
    '      Aceptar()
    '    Else
    '      CerrarOS()
    '    End If
    '  Catch ex As Exception

    '  End Try

    'End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            'Imprimir()
            If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If
            'If Not Me.dtgCotizacion.Rows(Me.dtgCotizacion.CurrentCellAddress.Y).Selected Then Exit Sub
            Dim objParametro As New Hashtable
            Dim oDt As DataTable
            Dim oDs As New DataSet
            'Me.Cursor = Cursors.WaitCursor
            Dim objPrintForm As New PrintForm
            Dim objReporte As New rptCotizacion
            Dim objLogical As New Cotizacion_BLL
            objParametro.Add("NCTZCN", Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value)
            objParametro.Add("CCMPN", Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
            oDt = HelpClassST.GetDataSetNative(objLogical.Reporte_Cotizacion(objParametro))
            oDt.TableName = "COTIZACION"
            oDs.Tables.Add(oDt.Copy)
            HelpClassST.CrystalReportTextObject(objReporte, "lblCompania", Me.cboCompania.CCMPN_Descripcion)
            HelpClassST.CrystalReportTextObject(objReporte, "lblDivision", Me.cboDivision.DivisionDescripcion)
            HelpClassST.CrystalReportTextObject(objReporte, "lblPlanta", Me.cboPlanta.DescripcionPlanta)
            HelpClassST.CrystalReportTextObject(objReporte, "lblUsuario", _pUsuario)
            Dim strCotizacion As String = IIf(Me.rbnTrasladoOrdinario.Checked = True, "ORDINARIO", "MULTIMODAL")
            HelpClassST.CrystalReportTextObject(objReporte, "lblCotizacion", strCotizacion)
            objReporte.SetDataSource(oDs)
            objPrintForm.ShowForm(objReporte, Me)
            'Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged
        Me.dtpFechaInicio.Enabled = Me.ckbRangoFechas.Checked
        Me.dtpFechaFin.Enabled = Me.ckbRangoFechas.Checked

    End Sub

    Private Sub dtgDetalleCotizacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDetalleCotizacion.CellContentClick
        Try
            Dim intIndice As Int32 = 0
            If dtgDetalleCotizacion.Columns(e.ColumnIndex).Name = "btnServicioCotizacion" Then
                'Agregado por: Hugo Pérez Ryan
                'Fecha:        01/03/2012
                'Descripción:  Cada vez que se quiera agregar servicios a un OS cerrada aparecera em siguiente mensaje
                If dtgDetalleCotizacion.CurrentRow.Cells("SESTOS").Value.ToString.Equals("C") Then
                    MsgBox("No se puede agregar servicios. La OS está cerrada", MsgBoxStyle.Information)
                    Exit Sub
                End If
                'Me.Cursor = Cursors.WaitCursor
                intIndice = Me.dtgDetalleCotizacion.CurrentCellAddress.Y
                If intIndice < 0 Then Exit Sub
                Dim objfrmRegistroRutaContratos As New frmRegistroRutaContratos()
                'If Existe_Ventana(frmRegistroRutaContratos.Name) Then Exit Sub
                If Existe_Ventana(objfrmRegistroRutaContratos.Name) Then Exit Sub

                With objfrmRegistroRutaContratos
                    .mNCTZCN = Me.dtgDetalleCotizacion.Item("NCTZCN_DET", intIndice).Value
                    .mCCLNT = Me.txtCliente.pCodigo
                    .mQMRCDR = Me.dtgDetalleCotizacion.Item("QMRCDR", intIndice).Value
                    .mPMRCDR = Me.dtgDetalleCotizacion.Item("PMRCDR", intIndice).Value
                    .mCMRCDR = Me.dtgDetalleCotizacion.Item("CMRCDR", intIndice).Value
                    .mCTPOSR = Me.dtgDetalleCotizacion.Item("CTPOSR", intIndice).Value
                    .mCTPSBS = Me.dtgDetalleCotizacion.Item("CTPSBS", intIndice).Value
                    .mNCRRCT = Me.dtgDetalleCotizacion.Item("NCRRCT", intIndice).Value
                    .mCCMPN = Me.cboCompania.CCMPN_CodigoCompania
                    .mCDVSN = Me.cboDivision.Division
                    .mSESTCT = Me.dtgCotizacion.Item("SESTCT", Me.dtgCotizacion.CurrentCellAddress.Y).Value
                    .pUsuario = _pUsuario
                    .HeaderDatos.Visible = Me.HeaderDatos.Visible
                    .objEntidadAcceso = objEntidadAcceso
                    .ShowDialog()
                End With
                'Me.Cursor = Cursors.Default

            End If
        Catch ex As Exception
            'Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgDetalleCotizacion_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgDetalleCotizacion.SelectionChanged
        Try
            '  Me.btnAceptar.Enabled = IIf(dtgDetalleCotizacion.CurrentRow.Cells("SESTOS").Value.ToString.Equals("C"), False, True)
            'If dtgDetalleCotizacion.RowCount = 0 Then
            '    Me.btnGenerarOSDetalleCotizacion.Enabled = False
            'Else
            '    Me.btnGenerarOSDetalleCotizacion.Enabled = True
            'End If
            'If dtgDetalleCotizacion.CurrentRow IsNot Nothing Then
            '    If dtgDetalleCotizacion.CurrentRow.Cells("NORSRT").Value = 0 Then
            '        Me.btnGenerarOSDetalleCotizacion.Text = "Generar OS"
            '        Me.btnGenerarOSDetalleCotizacion.ToolTipText = "Genera Orden de Servicio por detalle"
            '    Else
            '        Me.btnGenerarOSDetalleCotizacion.Text = "Cerrar OS Detalle"
            '        Me.btnGenerarOSDetalleCotizacion.ToolTipText = "Cerrar Orden de Servicio por detalle"
            '    End If
            '    Me.btnGenerarOSDetalleCotizacion.Enabled = IIf(dtgDetalleCotizacion.CurrentRow.Cells("SESTOS").Value.ToString.Equals("C"), False, True)
            'End If
            HabilitarOpcionGenerarOS()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub HabilitarOpcionGenerarOS()
        If dtgDetalleCotizacion.RowCount = 0 Then
            Me.btnGenerarOSDetalleCotizacion.Enabled = False
        Else
            Me.btnGenerarOSDetalleCotizacion.Enabled = True
        End If
        If dtgDetalleCotizacion.CurrentRow IsNot Nothing Then
            If dtgDetalleCotizacion.CurrentRow.Cells("NORSRT").Value = 0 Then
                Me.btnGenerarOSDetalleCotizacion.Text = "Generar OS"
                Me.btnGenerarOSDetalleCotizacion.ToolTipText = "Genera Orden de Servicio por detalle"
            Else
                Me.btnGenerarOSDetalleCotizacion.Text = "Cerrar OS Detalle"
                Me.btnGenerarOSDetalleCotizacion.ToolTipText = "Cerrar Orden de Servicio por detalle"
            End If
            Me.btnGenerarOSDetalleCotizacion.Enabled = IIf(dtgDetalleCotizacion.CurrentRow.Cells("SESTOS").Value.ToString.Equals("C"), False, True)
        End If

    End Sub


    'Private Sub dtgDetalleCotizacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDetalleCotizacion.CellClick
    '    Try
    '        If dtgDetalleCotizacion.CurrentRow.Cells("SESTOS").Value.ToString.Equals("C") Then Exit Sub
    '        If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub

    '        'btnGuardar.Text = "Modificar"
    '        'btnGuardar.Enabled = dtgCotizacion.CurrentRow.Cells("SESTCT").Value.ToString.Trim.Equals("P")
    '        'btnEliminar.Enabled = dtgCotizacion.CurrentRow.Cells("SESTCT").Value.ToString.Trim.Equals("P")
    '        'Me.gEnum_Mantenimiento = mantenimiento.MODIFICAR

    '        If dtgDetalleCotizacion.CurrentRow.Cells("NORSRT").Value = 0 Then
    '            'Agregado por: Hugo Pérez Ryan
    '            'Fecha: 21/02/2012
    '            'Renombra al botón para ejecutar determinada acción
    '            Me.btnGenerarOSDetalleCotizacion.Text = "Generar OS"
    '            Me.btnGenerarOSDetalleCotizacion.ToolTipText = "Genera Orden de Servicio por detalle"

    '        Else
    '            'Agregado por: Hugo Pérez Ryan
    '            'Fecha: 21/02/2012
    '            'Renombra al botón para ejecutar determinada acción
    '            Me.btnGenerarOSDetalleCotizacion.Text = "Cerrar OS Detalle"
    '            Me.btnGenerarOSDetalleCotizacion.ToolTipText = "Cerrar Orden de Servicio por detalle"
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub TabcCotizacion_Deselecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabcCotizacion.Deselecting
    '    Try
    '        'If btnGuardar.Enabled And btnGuardar.Text = "Guardar" Then
    '        '    'HelpClassST.MsgBox("Debe guardar el registro actual o cancelarlo")
    '        '    MessageBox.Show("Debe guardar el registro actual o cancelarlo", "Aviso", MessageBoxButtons.OK)
    '        '    e.Cancel = True
    '        'End If

    '        'If Me.TabcCotizacion.SelectedTab.Name = "TabPage1" And dtgCotizacion.RowCount > 0 Then
    '        '    Me.btnAgregarDetalleCotizacion.Enabled = True
    '        'Else
    '        '    Me.btnAgregarDetalleCotizacion.Enabled = False
    '        'End If

    '        If dtgDetalleCotizacion.RowCount = 0 Then
    '            Me.btnGenerarOSDetalleCotizacion.Enabled = False
    '        Else
    '            Me.btnGenerarOSDetalleCotizacion.Enabled = True
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub Cargar_Compania()
        'Try
        cboCompania.Usuario = _pUsuario
        'cboCompania.CCMPN_CompaniaDefault = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        cboCompania.pActualizar()
        cboCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub cboCompania_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania) Handles cboCompania.SelectionChangeCommitted
        Try
            'If (cboCompania.CCMPN_ANTERIOR <> cboCompania.CCMPN_CodigoCompania) Then
            Me.cboDivision.Usuario = _pUsuario
            Me.cboDivision.Compania = obeCompania.CCMPN_CodigoCompania
            Me.cboDivision.DivisionDefault = "T"
            'Me.cboCompania.CCMPN_ANTERIOR = cboCompania.CCMPN_CodigoCompania
            Me.cboDivision.pActualizar()
            cboDivision_Seleccionar(Nothing)
            'Me.cboCompania.CCMPN_ANTERIOR = cboCompania.CCMPN_CodigoCompania
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboDivision_Seleccionar(ByVal obeDivision As Ransa.TypeDef.UbicacionPlanta.Division.beDivision) Handles cboDivision.SelectionChangeCommitted
        Try
            'If (cboCompania.CCMPN_ANTERIOR <> cboCompania.CCMPN_CodigoCompania) OrElse (cboDivision.CDVSN_ANTERIOR <> cboDivision.Division) Then
            Me.cboPlanta.Usuario = _pUsuario
            'Me.cboPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            'Me.cboPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            Me.cboPlanta.CodigoCompania = cboDivision.Compania
            Me.cboPlanta.CodigoDivision = cboDivision.Division
            Me.cboPlanta.PlantaDefault = 1
            'Me.cboDivision.CDVSN_ANTERIOR = Me.cboDivision.Division
            Me.cboPlanta.pActualizar()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    'Private Sub cboPlanta_Seleccionar(ByVal obeDivision As Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta) Handles cboPlanta.SelectionChangeCommitted
    '    Try
    '        lbooEstado = False
    '        Me.CargarControles()
    '        lbooEstado = True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    ''' <summary>
    ''' Evento del botón agregar detalle de cotización
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    '''  Creado Por: Hugo Pérez Ryan
    '''  Fecha: 17/02/2012
    ''' </remarks>
    ''' 
    'Private Sub btnAgregarDetalleCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDetalleCotizacion.Click
    '    If Me.dtgCotizacion.CurrentRow.Cells("SESTCT").Value.ToString.Trim.Equals("G") Then
    '        HelpClassST.MsgBox("La cotización  N° " & Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value & " está cerrada; " & Chr(13) & "No se puede crear Detalle de cotización", MessageBoxIcon.Information)
    '        Exit Sub

    '    Else
    '        EnviaParametros()
    '    End If


    'End Sub

    ''' <summary>
    ''' Evento que permite generar una OS por detalle de la cotización
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' Creado Por: Hugo Pérez Ryan
    '''  Fecha: 20/02/2012
    ''' </remarks>
    Private Sub btnGenerarOSDetalleCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarOSDetalleCotizacion.Click
        Try
            If Me.btnGenerarOSDetalleCotizacion.Text = "Generar OS" Then
                GenerarOSxDetalleCotizacion()
            Else
                CerrarOSxDetalleCotizacion()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub





    Private Sub Alinear_Columnas_Grilla()

        Me.dtgCotizacion.AutoGenerateColumns = False
        Me.dtgDetalleCotizacion.AutoGenerateColumns = False
        For lint_contador As Integer = 0 To Me.dtgCotizacion.ColumnCount - 1
            Me.dtgCotizacion.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        For lint_contador As Integer = 0 To Me.dtgDetalleCotizacion.ColumnCount - 1
            Me.dtgDetalleCotizacion.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub



    Private Sub CargarCombos()
        Dim objPlantaFacturacion As New PlantaFacturacion_BLL
        Dim objMoneda As New Moneda_BLL
        With Me.txtPlantaFacturacion
            .DataSource = objPlantaFacturacion.Listar_Planta_Facturacion_Combo(Me.cboCompania.CCMPN_CodigoCompania)
            .KeyField = "CZNFCC"
            .ValueField = "TZNFCC"
            .DataBind()
        End With
        With Me.cmbMoneda
            .DataSource = objMoneda.Listar_Monedas_Combo(Me.cboCompania.CCMPN_CodigoCompania)
            .KeyField = "CMNDA1"
            .ValueField = "TMNDA"
            .DataBind()
        End With
        Dim oDt As New DataTable
        Dim oDr As DataRow
        oDt.Columns.Add("COD")
        oDt.Columns.Add("DES")
        oDr = oDt.NewRow

        'oDr.Item(0) = "R"
        'oDr.Item(1) = "REMITENTE"
        oDr.Item("COD") = "R"
        oDr.Item("DES") = "REMITENTE"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item("COD") = "D"
        oDr.Item("DES") = "DESTINATARIO"
        oDt.Rows.Add(oDr)

        With Me.cmbTipoCobro
            .DataSource = oDt
            .ValueMember = "COD"
            .DisplayMember = "DES"
        End With
        'Me.cmbTipoCobro.SelectedValue = -1
        Me.cmbTipoCobro.SelectedValue = "R"
    End Sub

    Private Sub ListaCotizaciones()
        'Me.Cursor = Cursors.WaitCursor
        dtgCotizacion.DataSource = Nothing
        dtgDetalleCotizacion.DataSource = Nothing
        Dim objEntidad As New Hashtable
        Dim strEstado As String = ""
        Dim objLogical As New Cotizacion_BLL
        'dtgCotizacion.AutoGenerateColumns = False
        'Select Case Me.cmbEstado.Text
        '    Case "PENDIENTE"
        '        strEstado = "P"
        '    Case "CERRADO"
        '        strEstado = "G"
        '    Case "TODOS"
        '        strEstado = " "
        'End Select

        Select Case Me.cmbEstado.SelectedValue
            Case "P"
                strEstado = "P"
            Case "G"
                strEstado = "G"
            Case "T"
                strEstado = " "
        End Select
        objEntidad.Add("CCMPN", Me.cboCompania.CCMPN_CodigoCompania)
        objEntidad.Add("CDVSN", Me.cboDivision.Division)
        objEntidad.Add("CPLNDV", Me.cboPlanta.Planta)
        objEntidad.Add("SESTCT", strEstado)
        If Me.ckbRangoFechas.Checked Then
            'objEntidad.Add("FECINI", HelpClassST.CDate_a_Numero8Digitos(Me.dtpFechaInicio.Value))
            'objEntidad.Add("FECFIN", HelpClassST.CDate_a_Numero8Digitos(Me.dtpFechaFin.Value))
            objEntidad.Add("FECINI", Me.dtpFechaInicio.Value.ToString("yyyyMMdd"))
            objEntidad.Add("FECFIN", Me.dtpFechaFin.Value.ToString("yyyyMMdd"))
        Else
            objEntidad.Add("FECINI", 0)
            objEntidad.Add("FECFIN", 0)
        End If
        objEntidad.Add("CCLNT", Me.txtClienteFiltro.pCodigo)
        bs.DataSource = HelpClassST.GetDataSetNative(objLogical.Listar_Cotizaciones(objEntidad))
        Me.dtgCotizacion.DataSource = bs
        If Me.dtgCotizacion.Rows.Count = 0 Then
            dtgDetalleCotizacion.DataSource = Nothing
            Limpiar_Control()
        End If
        'Me.dtgCotizacion.DataSource = objLogical.Listar_Cotizaciones(objEntidad) 'bs
        'Me.Limpiar_Controles(Me.PanelMantenimiento)
        'If Me.dtgCotizacion.RowCount > 0 Then
        'If bs.Count > 0 Then
        '    'btnAceptar.Enabled = True
        '    Me.btnGenerarOSDetalleCotizacion.Enabled = True
        '    'Me.btnAgregarDetalleCotizacion.Enabled = True

        'Else
        '    'btnAceptar.Enabled = False
        '    Me.btnGenerarOSDetalleCotizacion.Enabled = False
        '    'Me.btnAgregarDetalleCotizacion.Enabled = False
        'End If
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub AsignarDatosCotizacion()
        If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
        'Me.Cursor = Cursors.WaitCursor
        With dtgCotizacion.CurrentRow
            Me.HeaderDatos.ValuesPrimary.Heading = "Número de cotización :" & .Cells("NCTZCN").Value & " / Cliente :" & .Cells("CLIENTE").Value
            Me.cmbMoneda.Codigo = .Cells("CMNDA").Value
            Me.txtNroContrato.Text = .Cells("NCNTRT").Value
            Me.txtCliente.pCargar(.Cells("CCLNT").Value)
            Me.dtpFecCotizacion.Value = .Cells("FCTZCN").Value
            Me.dtpFechaVigencia.Value = .Cells("FVGCTZ").Value
            Me.txtContacto.Text = .Cells("TCNCLC").Value
            Me.txtPlantaFacturacion.Codigo = .Cells("CPLNFC").Value
            Me.chkFleteZonaPrimaria.Checked = .Cells("SFLZNP").Value.ToString.Equals("X")
            Me.chkServicioAfecto.Checked = .Cells("SFSANF").Value.ToString.Equals("1")
            If .Cells("SCBRMD").Value.ToString.Equals("R") = True Then
                'Me.cmbTipoCobro.SelectedIndex = 0
                Me.cmbTipoCobro.SelectedValue = "R"
            Else
                'Me.cmbTipoCobro.SelectedIndex = 1
                Me.cmbTipoCobro.SelectedValue = "D"
            End If
            'strCompania = dtgCotizacion.CurrentRow.Cells("CCMPN").Value
            If .Cells("SCTZTR").Value.ToString.Trim.Equals("O") Then
                Me.rbnTrasladoOrdinario.Checked = True
                Me.rbnTrasladoMulti.Checked = False
            Else
                Me.rbnTrasladoMulti.Checked = True
                Me.rbnTrasladoOrdinario.Checked = False
            End If
        End With
    End Sub

    'Private Sub DetalleCotizacion()
    'Try
    'If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
    ''Me.Cursor = Cursors.WaitCursor
    'With dtgCotizacion.CurrentRow
    '    Me.HeaderDatos.ValuesPrimary.Heading = "Número de cotización :" & .Cells("NCTZCN").Value & " / Cliente :" & .Cells("CLIENTE").Value
    '    Me.cmbMoneda.Codigo = .Cells("CMNDA").Value
    '    Me.txtNroContrato.Text = .Cells("NCNTRT").Value
    '    Me.txtCliente.pCargar(.Cells("CCLNT").Value)
    '    Me.dtpFecCotizacion.Value = .Cells("FCTZCN").Value
    '    Me.dtpFechaVigencia.Value = .Cells("FVGCTZ").Value
    '    Me.txtContacto.Text = .Cells("TCNCLC").Value
    '    Me.txtPlantaFacturacion.Codigo = .Cells("CPLNFC").Value
    '    Me.chkFleteZonaPrimaria.Checked = .Cells("SFLZNP").Value.ToString.Equals("X")
    '    Me.chkServicioAfecto.Checked = .Cells("SFSANF").Value.ToString.Equals("1")
    '    If .Cells("SCBRMD").Value.ToString.Equals("R") = True Then
    '        'Me.cmbTipoCobro.SelectedIndex = 0
    '        Me.cmbTipoCobro.SelectedValue = "R"
    '    Else
    '        'Me.cmbTipoCobro.SelectedIndex = 1
    '        Me.cmbTipoCobro.SelectedValue = "D"
    '    End If

    '    strCompania = dtgCotizacion.CurrentRow.Cells("CCMPN").Value

    '    If .Cells("SCTZTR").Value.ToString.Trim.Equals("O") Then
    '        Me.rbnTrasladoOrdinario.Checked = True
    '        Me.rbnTrasladoMulti.Checked = False
    '    Else
    '        Me.rbnTrasladoMulti.Checked = True
    '        Me.rbnTrasladoOrdinario.Checked = False
    '    End If

    'End With
    'If dtgCotizacion.CurrentCellAddress.Y < 0 Then Me.Cursor = Cursors.Default : Exit Sub
    'AsignarDatosCotizacion()
    'ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
    'If Me.dtgDetalleCotizacion.RowCount = 0 Then Me.Cursor = Cursors.Default : Exit Sub
    'With dtgDetalleCotizacion.CurrentRow
    '    If .Cells("NORSRT").Value = 0 Then
    '        Me.btnGenerarOSDetalleCotizacion.Text = "Generar OS"
    '        Me.btnGenerarOSDetalleCotizacion.ToolTipText = "Generar Orden de Servicio"
    '    Else
    '        Me.btnGenerarOSDetalleCotizacion.Text = "Cerrar OS Detalle"
    '        Me.btnGenerarOSDetalleCotizacion.ToolTipText = "Cerrar Orden de Servicio"
    '    End If
    'End With
    'Me.Cursor = Cursors.Default
    'Catch ex As Exception
    '    'HelpClassST.MsgBox(ex.Message, MessageBoxIcon.Information)
    '    MessageBox.Show(ex.Message.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Me.Cursor = Cursors.Default
    'End Try

    'End Sub

    'Private Sub ListaDetalleCotizacion(ByVal dblNrCotizacion As Double, ByVal strCompania As String)
    '    Dim objEntidad As New Hashtable
    '    Dim objNegocio As New DetalleCotizacion_BLL
    '    Dim lstDetCotizacion As New List(Of Detalle_Cotizacion)
    '    objEntidad.Add("NCTZCN", dblNrCotizacion)
    '    objEntidad.Add("CCMPN", strCompania)
    '    'Me.dtgDetalleCotizacion.AutoGenerateColumns = False
    '    dtgDetalleCotizacion.DataSource = Nothing
    '    lstDetCotizacion = objNegocio.ListaDetalleCotizacion(objEntidad)
    '    Me.dtgDetalleCotizacion.DataSource = objNegocio.ListaDetalleCotizacion(objEntidad)
    '    If dtgDetalleCotizacion.Rows.Count = 0 Then
    '        HabilitarOpcionGenerarOS()
    '    End If
    '    'Me.dtgDetalleCotizacion.Refresh()
    'End Sub

    Private Sub ListaDetalleCotizacion()
        dtgDetalleCotizacion.DataSource = Nothing
        Dim pNCTZCN As Double = 0
        Dim pCCMPN As String = ""
        If dtgCotizacion.CurrentRow Is Nothing Then
            Exit Sub
        End If
        'Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value
        pNCTZCN = Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value
        pCCMPN = Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value
        Dim objEntidad As New Hashtable
        Dim objNegocio As New DetalleCotizacion_BLL
        Dim lstDetCotizacion As New List(Of Detalle_Cotizacion)
        objEntidad.Add("NCTZCN", pNCTZCN)
        objEntidad.Add("CCMPN", pCCMPN)
        'Me.dtgDetalleCotizacion.AutoGenerateColumns = False
        lstDetCotizacion = objNegocio.ListaDetalleCotizacion(objEntidad)
        Me.dtgDetalleCotizacion.DataSource = objNegocio.ListaDetalleCotizacion(objEntidad)
        If dtgDetalleCotizacion.Rows.Count = 0 Then
            HabilitarOpcionGenerarOS()
        End If
        'Me.dtgDetalleCotizacion.Refresh()
    End Sub

    'Private Sub Estado_Controles(ByVal lbool_estado As Boolean, ByVal Contenedor As Object, Optional ByVal intEstado As Integer = 0)
    '    Dim X As Control
    '    If intEstado = 0 Then
    '        If Me.gEnum_Mantenimiento = mantenimiento.EDITAR Or mantenimiento.NUEVO Or mantenimiento.MODIFICAR Then
    '            For Each X In Contenedor.Controls
    '                If Not (TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonLabel) Then
    '                    X.Enabled = lbool_estado
    '                End If
    '            Next
    '        End If
    '    End If

    'End Sub

    Private Sub Estado_Controles(ByVal lbool_estado As Boolean)
        txtCliente.Enabled = lbool_estado
        txtNroContrato.Enabled = lbool_estado
        cmbMoneda.Enabled = lbool_estado
        dtpFecCotizacion.Enabled = lbool_estado
        dtpFechaVigencia.Enabled = lbool_estado
        txtContacto.Enabled = lbool_estado
        GroupBox1.Enabled = lbool_estado
        txtPlantaFacturacion.Enabled = lbool_estado
        cmbTipoCobro.Enabled = lbool_estado
        chkServicioAfecto.Enabled = lbool_estado
        chkFleteZonaPrimaria.Enabled = lbool_estado
    End Sub


    'Private Sub Limpiar_Controles(ByVal Contenedor As Object, Optional ByVal intTipo As Integer = 0)
    '    Dim X As Control
    '    Try
    '        If intTipo = 0 Then
    '            For Each X In Contenedor.Controls
    '                If TypeOf X Is CodeTextBox.CodeTextBox Then CType(X, CodeTextBox.CodeTextBox).Limpiar()
    '                If TypeOf X Is TextBox Then CType(X, TextBox).Clear()
    '                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Clear()
    '                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonComboBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonComboBox).SelectedIndex = -1
    '                If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
    '                If TypeOf X Is CheckBox Then CType(X, CheckBox).Checked = False
    '                If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonCheckBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonCheckBox).Checked = False
    '                If TypeOf X Is RadioButton Then CType(X, RadioButton).Checked = False
    '                If TypeOf X Is ComboBox Then CType(X, ComboBox).SelectedIndex = -1
    '                If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
    '                If TypeOf X Is Ransa.Controls.Cliente.ucCliente_TxtF01 Then CType(X, Ransa.Controls.Cliente.ucCliente_TxtF01).pClear()
    '            Next
    '        End If
    '        Me.dtgDetalleCotizacion.DataSource = Nothing
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub Limpiar_Control()
        txtCliente.pClear()
        txtNroContrato.Clear()
        cmbMoneda.Limpiar()
        dtpFecCotizacion.Value = Now
        dtpFechaVigencia.Value = Now
        txtContacto.Clear()
        txtPlantaFacturacion.Limpiar()
        'cmbTipoCobro.SelectedIndex = -1
        cmbTipoCobro.SelectedValue = "R"
        chkServicioAfecto.Checked = False
        chkFleteZonaPrimaria.Checked = False
    End Sub


    Private Sub Guardar_Cotizacion()
        Dim objEntidad As New Cotizacion
        Dim objNegocios As New Cotizacion_BLL

        With objEntidad
            .CCLNT = txtCliente.pCodigo
            .CMNDA = Me.cmbMoneda.Codigo
            '.FCTZCN = HelpClassST.CtypeDate(Me.dtpFecCotizacion.Value)
            '.FVGCTZ = HelpClassST.CtypeDate(Me.dtpFechaVigencia.Value)
            .FCTZCN = Me.dtpFecCotizacion.Value.ToString("yyyyMMdd")
            .FVGCTZ = Me.dtpFechaVigencia.Value.ToString("yyyyMMdd")
            .TCNCLC = Me.txtContacto.Text
            .CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            .CDVSN = Me.cboDivision.Division
            .CPLNDV = Me.cboPlanta.Planta
            .NCNTRT = Me.txtNroContrato.Text
            '.SCTZTR = IIf(Me.chkCotizacionTarifario.Checked, "X", "")
            .SCTZTR = IIf(Me.rbnTrasladoOrdinario.Checked, "O", "M")
            .FULTAC = HelpClassST.TodayNumeric
            .HULTAC = HelpClassST.NowNumeric
            .CULUSA = _pUsuario
            .NTRMNL = HelpClassST.NombreMaquina
            .CUSCRT = _pUsuario
            .FCHCRT = HelpClassST.TodayNumeric
            .HRACRT = HelpClassST.NowNumeric
            .NTRMCR = HelpClassST.NombreMaquina
            .CPLNFC = Me.txtPlantaFacturacion.Codigo
            .SFLZNP = IIf(Me.chkFleteZonaPrimaria.Checked = True, "X", " ")
            .SFSANF = IIf(Me.chkServicioAfecto.Checked = True, "1", "3")
            '.SCBRMD = IIf(Me.cmbTipoCobro.SelectedIndex = 0, "R", "D")
            .SCBRMD = Me.cmbTipoCobro.SelectedValue
        End With
        Dim olbeCotizacion As List(Of Cotizacion)
        olbeCotizacion = objNegocios.Guardar_Cotizacion(objEntidad)
        If olbeCotizacion.Count > 0 Then
            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
            Me.ListaCotizaciones()
            'Me.AccionCancelar()
            If Me.dtgCotizacion.RowCount > 0 Then
                Me.dtgCotizacion.CurrentCell = Me.dtgCotizacion.Item(0, dtgCotizacion.RowCount - 1)
                Me.dtgCotizacion.Rows(dtgCotizacion.RowCount - 1).Selected = True
                Limpiar_Control()
                AsignarDatosCotizacion()
            End If
            'If HelpClassST.RspMsgBox("¿Desea Ingresar Detalle de cotización?") = MsgBoxResult.Yes Then
            If MessageBox.Show("¿Desea Ingresar Detalle de cotización?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim objfrmDetalleCotizacion As New frmDetalleCotizacion
                With objfrmDetalleCotizacion
                    .mNCTZCN = olbeCotizacion.Item(0).NCTZCN
                    .mCCLNT = olbeCotizacion.Item(0).CCLNT
                    .mESTADO = olbeCotizacion.Item(0).SESTCT
                    .mFVGCTZ = olbeCotizacion.Item(0).FVGCTZ
                    .mCCMPN = olbeCotizacion.Item(0).CCMPN
                    .mCDVSN = olbeCotizacion.Item(0).CDVSN
                    .mSESTCT = olbeCotizacion.Item(0).SESTCT
                    .objEntidadAcceso = objEntidadAcceso
                    .pUsuario = _pUsuario
                    .ShowDialog()
                    'If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    '    'ListaDetalleCotizacion(olbeCotizacion.Item(0).NCTZCN, olbeCotizacion.Item(0).CCMPN)
                    '    ListaDetalleCotizacion()
                    'End If
                    ListaDetalleCotizacion()

                    'If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    '    'ListaDetalleCotizacion(olbeCotizacion.Item(0).NCTZCN, olbeCotizacion.Item(0).CCMPN)
                    '    ListaDetalleCotizacion()
                    'End If
                End With
            End If

            'Else
            '    'HelpClassST.ErrorMsgBox()
            '    MessageBox.Show("La operación no pudo completarse.Ha ocurrido un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Modificar_Cotizacion()
        Dim objEntidad As New Cotizacion
        Dim objNegocios As New Cotizacion_BLL

        With objEntidad
            .CCMPN = Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value
            .NCTZCN = Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value
            .CCLNT = txtCliente.pCodigo
            .CMNDA = Me.cmbMoneda.Codigo
            '.FCTZCN = HelpClassST.CtypeDate(Me.dtpFecCotizacion.Value)
            '.FVGCTZ = HelpClassST.CtypeDate(Me.dtpFechaVigencia.Value)
            .FCTZCN = Me.dtpFecCotizacion.Value.ToString("yyyyMMdd")
            .FVGCTZ = Me.dtpFechaVigencia.Value.ToString("yyyyMMdd")
            .TCNCLC = Me.txtContacto.Text
            .NCNTRT = Me.txtNroContrato.Text
            '.SCTZTR = IIf(Me.chkCotizacionTarifario.Checked, "X", "")
            .SCTZTR = IIf(Me.rbnTrasladoOrdinario.Checked, "O", "M")
            .FULTAC = HelpClassST.TodayNumeric
            .HULTAC = HelpClassST.NowNumeric
            .CULUSA = _pUsuario
            .NTRMNL = HelpClassST.NombreMaquina
            .CUSCRT = _pUsuario
            .FCHCRT = HelpClassST.TodayNumeric
            .HRACRT = HelpClassST.NowNumeric
            .NTRMCR = HelpClassST.NombreMaquina
            .CPLNFC = Me.txtPlantaFacturacion.Codigo
            .SFLZNP = IIf(Me.chkFleteZonaPrimaria.Checked = True, "X", " ")
            .SFSANF = IIf(Me.chkServicioAfecto.Checked = True, "1", "3")
            '.SCBRMD = IIf(Me.cmbTipoCobro.SelectedIndex = 0, "R", "D")
            .SCBRMD = Me.cmbTipoCobro.SelectedValue
        End With

        Dim respuesta As Double
        respuesta = objNegocios.Modificar_Cotizacion(objEntidad)
        Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
        HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
        Me.ListaCotizaciones()
        'If respuesta.ToString.Trim.Equals("0") Then
        'If respuesta.ToString.Trim.Equals("1") Then
        '    Me.ListaCotizaciones()
        'Me.AccionCancelar()
        'Else
        '    '  HelpClassST.ErrorMsgBox()
        '    MessageBox.Show("La operación no pudo completarse.Ha ocurrido un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub

    Private Function Validar() As Boolean

        Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)

        If Me.cboCompania.CCMPN_CodigoCompania.ToString = vbNullString Then
            strError += "* Compañía" & Chr(13)
        End If
        If Me.cboPlanta.Planta.ToString = vbNullString Then
            strError += "* Planta" & Chr(13)
        End If
        If Me.cboDivision.Division.ToString = vbNullString Then
            strError += "* División" & Chr(13)
        End If
        If Me.txtCliente.pCodigo.ToString.Equals("0") = True Then
            strError += "* Cliente " & Chr(13)
        End If
        If Me.cmbMoneda.NoHayCodigo = True Then
            strError += "* Moneda" & Chr(13)
        End If
        If Me.dtpFecCotizacion.Value < Today.Date Then
            strError += "* Fecha de la Cotización no puede ser menor a la fecha actual" & Chr(13)
        End If
        If Me.dtpFechaVigencia.Value < Today.Date Then
            strError += "* Fecha de Vigencia de la Cotización no puede ser menor a la fecha actual" & Chr(13)
        End If
        If Me.txtPlantaFacturacion.NoHayCodigo Then
            strError += "* Planta Facturación" & Chr(13)
        End If
        If Me.cmbTipoCobro.SelectedValue = Nothing Then
            strError += "* Tipo de cobro" & Chr(13)
        End If
        If strError.Trim.Length > 18 Then
            ' HelpClassST.MsgBox(strError, MessageBoxIcon.Warning)
            MessageBox.Show(strError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    'Private Sub EstadoGeneradoOS(ByVal bolEstado As Boolean)
    '    btnNuevo.Visible = bolEstado
    '    Separator1.Visible = bolEstado
    '    btnGuardar.Visible = bolEstado
    '    Separator2.Visible = bolEstado
    '    btnCancelar.Visible = bolEstado
    '    Separator3.Visible = bolEstado
    '    btnEliminar.Visible = bolEstado
    '    Separator4.Visible = bolEstado
    'End Sub

    'Private Sub AccionCancelar()
    '    If gEnum_Mantenimiento = mantenimiento.EDITAR Or gEnum_Mantenimiento = mantenimiento.EDITAR Or gEnum_Mantenimiento = mantenimiento.NUEVO Then
    '        Estado_Controles(False, PanelMantenimiento)
    '    End If
    '    gEnum_Mantenimiento = mantenimiento.NEUTRAL
    '    btnNuevo.Enabled = True
    '    btnCancelar.Enabled = False
    '    Me.dtgCotizacion.Enabled = True
    '    If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then
    '        btnGuardar.Enabled = False
    '        btnEliminar.Enabled = False
    '    Else
    '        btnGuardar.Text = "Modificar"
    '        btnGuardar.Enabled = dtgCotizacion.Item("SESTCT", dtgCotizacion.CurrentCellAddress.Y).Value.ToString.Trim.Equals("P")
    '        btnEliminar.Enabled = dtgCotizacion.Item("SESTCT", dtgCotizacion.CurrentCellAddress.Y).Value.ToString.Trim.Equals("P")
    '        Me.gEnum_Mantenimiento = mantenimiento.MODIFICAR
    '    End If
    'End Sub

    'Private Sub Aceptar()
    '    Dim objNegocios As New ServicioMercaderia_BLL()
    '    Dim lobjEntidad As New ServicioMercaderia
    '    lobjEntidad.NCTZCN = dtgCotizacion.SelectedRows(0).Cells("NCTZCN").Value()
    '    lobjEntidad.CCMPN = dtgCotizacion.SelectedRows(0).Cells("CCMPN").Value()
    '    If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
    '    Dim dblCantidad As Integer = objNegocios.Cantidad_Detalle_Cotizacion(lobjEntidad)
    '    If dblCantidad > 0 Then
    '        Dim objEntidad As New Operaciones.OrdenServicioTransporte
    '        objEntidad.NCTZCN = Me.dtgCotizacion.SelectedRows(0).Cells("NCTZCN").Value
    '        objEntidad.CCMPN = Me.dtgCotizacion.SelectedRows(0).Cells("CCMPN").Value
    '        objEntidad.CDVSN = Me.dtgCotizacion.SelectedRows(0).Cells("CDVSN").Value
    '        objEntidad.CPLNDV = Me.dtgCotizacion.SelectedRows(0).Cells("CPLNDV").Value
    '        objEntidad.CCLNT = Me.dtgCotizacion.SelectedRows(0).Cells("CCLNT").Value
    '        Dim objfrmGenerarOS As New frmGenerarOS(objEntidad)
    '        If objfrmGenerarOS.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
    '            HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
    '            Me.ListaCotizaciones()
    '        End If
    '        'ElseIf dblCantidad = -1 Then
    '        '    'HelpClassST.ErrorMsgBox()
    '        '    MessageBox.Show("La operación no pudo completarse .Ha ocurrido un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Else
    '        '   HelpClassST.MsgBox("No puede Generar orden de servicio, " & Chr(10) & " porque uno o más mercaderías no tienen servicio de cotización")
    '        MessageBox.Show("No puede Generar orden de servicio, " & Chr(10) & " porque uno o más mercaderías no tienen servicio de cotización", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If
    'End Sub

    'Private Sub Imprimir()
    '    If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then
    '        Exit Sub
    '    End If
    '    If Not Me.dtgCotizacion.Rows(Me.dtgCotizacion.CurrentCellAddress.Y).Selected Then Exit Sub
    '    Dim objParametro As New Hashtable
    '    Dim oDt As DataTable
    '    Dim oDs As New DataSet

    '    'Me.Cursor = Cursors.WaitCursor
    '    Dim objPrintForm As New PrintForm
    '    Dim objReporte As New rptCotizacion
    '    Dim objLogical As New Cotizacion_BLL
    '    objParametro.Add("NCTZCN", Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value)
    '    objParametro.Add("CCMPN", Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
    '    oDt = HelpClassST.GetDataSetNative(objLogical.Reporte_Cotizacion(objParametro))
    '    oDt.TableName = "COTIZACION"
    '    oDs.Tables.Add(oDt.Copy)
    '    HelpClassST.CrystalReportTextObject(objReporte, "lblCompania", Me.cboCompania.CCMPN_Descripcion)
    '    HelpClassST.CrystalReportTextObject(objReporte, "lblDivision", Me.cboDivision.DivisionDescripcion)
    '    HelpClassST.CrystalReportTextObject(objReporte, "lblPlanta", Me.cboPlanta.DescripcionPlanta)
    '    HelpClassST.CrystalReportTextObject(objReporte, "lblUsuario", _pUsuario)
    '    Dim strCotizacion As String = IIf(Me.rbnTrasladoOrdinario.Checked = True, "ORDINARIO", "MULTIMODAL")
    '    HelpClassST.CrystalReportTextObject(objReporte, "lblCotizacion", strCotizacion)
    '    objReporte.SetDataSource(oDs)
    '    objPrintForm.ShowForm(objReporte, Me)
    '    'Me.Cursor = Cursors.Default
    'End Sub

    Private Sub Eliminar_Cotizacion()
        Dim objEntidad As New Cotizacion
        Dim objNegocios As New Cotizacion_BLL
        With objEntidad
            .NCTZCN = Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value
            .CCMPN = Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value
            .FULTAC = HelpClassST.TodayNumeric
            .HULTAC = HelpClassST.NowNumeric
            .CULUSA = _pUsuario
            .NTRMNL = HelpClassST.NombreMaquina
        End With
        Dim respuesta As Double
        respuesta = objNegocios.Eliminar(objEntidad)
        Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
        HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
        ListaCotizaciones()
        'Me.AccionCancelar()
        'If respuesta.ToString.Trim.Equals("1") Then
        '    'If respuesta.ToString.Trim.Equals("0") Then
        '    Me.ListaCotizaciones()
        '    Me.AccionCancelar()
        'Else
        '    ' HelpClassST.ErrorMsgBox()
        '    MessageBox.Show("La operación no pudo completarse .Ha ocurrido un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub

    Private Function Existe_Ventana(ByVal pstrForm As String) As Boolean
        Dim intCont As Integer

        For intCont = 0 To Me.ParentForm.MdiChildren.Length - 1
            If Me.ParentForm.MdiChildren(intCont).Name.Trim = pstrForm.Trim Then
                Me.ParentForm.MdiChildren(intCont).WindowState = FormWindowState.Maximized
                Me.ParentForm.MdiChildren(intCont).Show()
                Return True
            End If
        Next intCont
        Return False
    End Function

    Private Sub Validar_Usuario_Autoridado()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
        objEntidadAcceso = New mantenimientos.ClaseGeneral
        'objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCAPL", _pSystem_Prefix)
        objParametro.Add("MMCUSR", _pUsuario)
        objParametro.Add("MMNPVB", _pNameFormulario)
        'objParametro.Add("CCMPN", Me.cmbCompania.SelectedValue)

        objEntidadAcceso = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidadAcceso.STSADI = "" Then
            Me.btnNuevo.Visible = False
            Me.Separator1.Visible = False
        End If
        If objEntidadAcceso.STSCHG = "" Then
            Me.btnGuardar.Visible = False
            Me.Separator2.Visible = False
        End If
        If objEntidadAcceso.STSELI = "" Then
            Me.btnEliminar.Visible = False
            Me.Separator4.Visible = False
        End If
        If objEntidadAcceso.STSADI = "" And objEntidadAcceso.STSCHG = "" Then
            Me.btnCancelar.Visible = False
            Me.Separator3.Visible = False
        End If
        If objEntidadAcceso.STSOP1 = "" Then
            ' btnAceptar.Visible = False
            'btnAgregarDetalleCotizacion.Visible = False

        End If
        If objEntidadAcceso.STSOP2 = "" Then
            Me.Separator5.Visible = False
            Me.btnCopiarCotizacion.Visible = False
        End If
    End Sub

    Private Sub CerrarOS()
        'Try
        Dim oblOrdenServico As New Operaciones.OrdenServicio_BLL
        Dim obeOrdenServico As New Operaciones.OrdenServicioTransporte
        If Me.dtgDetalleCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
        With dtgDetalleCotizacion.CurrentRow
            obeOrdenServico.NORSRT = .Cells("NORSRT").Value
            obeOrdenServico.FULTAC = HelpClassST.TodayNumeric
            obeOrdenServico.HULTAC = HelpClassST.NowNumeric
            obeOrdenServico.CULUSA = _pUsuario
            obeOrdenServico.NTRMNL = HelpClassST.NombreMaquina
            obeOrdenServico.CCMPN = dtgCotizacion.CurrentRow.Cells("CCMPN").Value
        End With
        ' If oblOrdenServico.Cerrar_OS(obeOrdenServico) = 0 Then
        Dim rpta As Double = 0
        rpta = oblOrdenServico.Cerrar_OS(obeOrdenServico)
        'If dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
        'ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
        ListaDetalleCotizacion()
        'If oblOrdenServico.Cerrar_OS(obeOrdenServico) = 1 Then
        '    If dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
        '    ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
        '    'Else
        '    '    ' HelpClassST.ErrorMsgBox()
        '    '    MessageBox.Show("La operación no pudo completarse .Ha ocurrido un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        'Catch
        'End Try
    End Sub

    Private Sub btnCopiarCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarCotizacion.Click
        Try
            If Me.dtgCotizacion.RowCount = 0 OrElse Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
            If MessageBox.Show("¿Desea realizar el Proceso?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = MsgBoxResult.Cancel Then Exit Sub
            Dim objEntidad As New Cotizacion
            Dim objNegocios As New Cotizacion_BLL
            With objEntidad
                .NCTZCN = Me.dtgCotizacion.Item("NCTZCN", Me.dtgCotizacion.CurrentCellAddress.Y).Value
                .CCMPN = Me.dtgCotizacion.Item("CCMPN", Me.dtgCotizacion.CurrentCellAddress.Y).Value
                .FULTAC = HelpClassST.TodayNumeric
                .HULTAC = HelpClassST.NowNumeric
                .CULUSA = _pUsuario
                .NTRMNL = HelpClassST.NombreMaquina
            End With
            Dim respuesta As Int32
            respuesta = objNegocios.Copiar_Cotizacion(objEntidad)
            MessageBox.Show("Se guardó satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
            Me.ListaCotizaciones()
            'Me.AccionCancelar()

            'If respuesta = 1 Then
            '    'HelpClassST.MsgBox("Se guardo satisfactoriamente", MessageBoxIcon.Information)
            '    MessageBox.Show("Se guardo satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.ListaCotizaciones()
            '    Me.AccionCancelar()
            '    'Else
            '    '    MessageBox.Show("La operación no pudo completarse .Ha ocurrido un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' Método que envía los parámetros solicitados por el botón agregar detalle de la cotización
    ''' </summary>
    ''' <remarks> Creado Por: Hugo Pérez Ryan
    '''           Fecha: 17/02/2012
    ''' </remarks>
    'Private Sub EnviaParametros()
    '    'Try
    '    'If HelpClass.RspMsgBox("¿Desea Ingresar Detalle de cotización?") = MsgBoxResult.Yes Then
    '    Dim objfrmDetalleCotizacion As New frmDetalleCotizacion
    '    With objfrmDetalleCotizacion
    '        .HeaderDatos.ValuesPrimary.Heading = "Número de cotización: " & Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value & " -  " & " / Cliente: " & Me.txtCliente.pRazonSocial
    '        .mNCTZCN = Convert.ToDouble(dtgCotizacion.CurrentRow.Cells("NCTZCN").Value) 'olbeCotizacion.Item(0).NCTZCN
    '        .mCCLNT = Convert.ToDouble(dtgCotizacion.CurrentRow.Cells("CCLNT").Value) 'olbeCotizacion.Item(0).CCLNT
    '        .mESTADO = dtgCotizacion.CurrentRow.Cells("SESTCT").Value 'olbeCotizacion.Item(0).SESTCT
    '        .mFVGCTZ = dtgCotizacion.CurrentRow.Cells("FVGCTZ").Value 'olbeCotizacion.Item(0).FVGCTZ
    '        .mCCMPN = dtgCotizacion.CurrentRow.Cells("CCMPN").Value  'olbeCotizacion.Item(0).CCMPN
    '        .mCDVSN = dtgCotizacion.CurrentRow.Cells("CDVSN").Value  'olbeCotizacion.Item(0).CDVSN
    '        .mSESTCT = dtgCotizacion.CurrentRow.Cells("SESTCT").Value  'olbeCotizacion.Item(0).SESTCT
    '        .pUsuario = _pUsuario
    '        .objEntidadAcceso = objEntidadAcceso
    '        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
    '            ListaDetalleCotizacion(Convert.ToDouble(dtgCotizacion.CurrentRow.Cells("NCTZCN").Value), dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
    '        End If
    '    End With
    '    'End If
    '    'Catch ex As Exception
    '    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    'End Try
    'End Sub

    ''' <summary>
    '''  Método que permite agregar detalle a las orden de cotización pendientes
    ''' </summary>
    ''' <remarks>
    ''' Creado Por: Hugo Pérez Ryan
    '''      Fecha: 18/02/2012
    ''' </remarks>
    Private Sub GenerarOSxDetalleCotizacion()
        If dtgDetalleCotizacion.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim objNegocios As New ServicioMercaderia_BLL()
        Dim lobjEntidad As New ServicioMercaderia
        lobjEntidad.NCTZCN = dtgDetalleCotizacion.SelectedRows(0).Cells("NCTZCN_DET").Value()
        lobjEntidad.CCMPN = dtgCotizacion.SelectedRows(0).Cells("CCMPN").Value()
        lobjEntidad.NCRRCT = dtgDetalleCotizacion.SelectedRows(0).Cells("NCRRCT").Value()
        If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
        Dim dblCantidad As Integer = objNegocios.Detectar_Servicio(lobjEntidad)
        If dblCantidad > 0 Then
            Dim objEntidad As New Operaciones.OrdenServicioTransporte
            objEntidad.NCTZCN = Me.dtgCotizacion.SelectedRows(0).Cells("NCTZCN").Value
            objEntidad.CCMPN = Me.dtgCotizacion.SelectedRows(0).Cells("CCMPN").Value
            objEntidad.CDVSN = Me.dtgCotizacion.SelectedRows(0).Cells("CDVSN").Value
            objEntidad.CPLNDV = Me.dtgCotizacion.SelectedRows(0).Cells("CPLNDV").Value
            objEntidad.CCLNT = Me.dtgCotizacion.SelectedRows(0).Cells("CCLNT").Value
            objEntidad.NCRRCT = Me.dtgDetalleCotizacion.SelectedRows(0).Cells("NCRRCT").Value()
            Dim objfrmGenerarOS As New frmGenerarOS(objEntidad)
            objfrmGenerarOS.pUsuario = _pUsuario
            If objfrmGenerarOS.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Me.DetalleCotizacion()
                'AsignarDatosCotizacion()
                'ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
                'ListaDetalleCotizacion()
                'Me.ListaCotizaciones()
                Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
                HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
                ListaCotizaciones()
                btnGenerarOSDetalleCotizacion.Text = "Cerrar OS Detalle"
            End If
            'ElseIf dblCantidad = -1 Then
            '    '  HelpClassST.ErrorMsgBox()
            '    MessageBox.Show("La operación no pudo completarse .Ha ocurrido un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            '  HelpClassST.MsgBox("No puede Generar Orden de Servicio, " & Chr(10) & " porque uno o más mercaderías no tienen servicio de cotización", MessageBoxIcon.Information)
            MessageBox.Show("No puede Generar Orden de Servicio, " & Chr(10) & " , uno o más mercaderías no tienen servicio de cotización", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    ''' <summary>
    '''  Método que permite cerrar la OS por detalle de cotización
    ''' </summary>
    ''' <remarks>
    ''' Creado Por: Hugo Pérez Ryan
    '''      Fecha: 21/02/2012
    ''' </remarks>
    Private Sub CerrarOSxDetalleCotizacion()
        'Try
        Dim rpta As Double = 0
        Dim oblOrdenServico As New Operaciones.OrdenServicio_BLL
        Dim obeOrdenServico As New Operaciones.OrdenServicioTransporte
        If Me.dtgDetalleCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
        With dtgDetalleCotizacion.CurrentRow
            obeOrdenServico.NORSRT = .Cells("NORSRT").Value
            obeOrdenServico.FULTAC = HelpClassST.TodayNumeric
            obeOrdenServico.HULTAC = HelpClassST.NowNumeric
            obeOrdenServico.CULUSA = _pUsuario
            obeOrdenServico.NTRMNL = HelpClassST.NombreMaquina
            obeOrdenServico.CCMPN = dtgCotizacion.CurrentRow.Cells("CCMPN").Value
            obeOrdenServico.NCTZCN = dtgDetalleCotizacion.CurrentRow.Cells("NCTZCN_DET").Value

        End With
        rpta = oblOrdenServico.Cerrar_OSxDetalleCotizacion(obeOrdenServico)
        'If oblOrdenServico.Cerrar_OSxDetalleCotizacion(obeOrdenServico) = 0 Then
        '    If dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
        '    ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
        'Else
        '    'HelpClassST.ErrorMsgBox()
        '    MessageBox.Show("La operación no pudo completarse .Ha ocurrido un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        'If dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub

        'ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
        ListaDetalleCotizacion()
        'Catch
        'End Try
    End Sub
 

    'Private Sub dtgCotizacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCotizacion.SelectionChanged
    '    Try
    '        If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
    '        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '            If Me.dtgCotizacion.Rows.Count > 0 Then
    '                lbooEstado = False
    '            End If
    '            'HelpClassST.MsgBox("Debe guardar o cancelar.", MsgBoxStyle.Exclamation)
    '            MessageBox.Show("Debe guardar o cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If
    '        btnGuardar.Text = "Modificar"
    '        btnGuardar.Enabled = dtgCotizacion.Item("SESTCT", dtgCotizacion.CurrentCellAddress.Y).Value.ToString.Trim.Equals("P")
    '        btnEliminar.Enabled = dtgCotizacion.Item("SESTCT", dtgCotizacion.CurrentCellAddress.Y).Value.ToString.Trim.Equals("P")
    '        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    '        Limpiar_Controles(Me.PanelMantenimiento)
    '        Me.DetalleCotizacion()
    '        lbooEstado = True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub dtgCotizacion_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCotizacion.SelectionChanged
        Try
            If Me.dtgCotizacion.CurrentCellAddress.Y < 0 Then Exit Sub
            'If Me.gEnum_Mantenimiento = mantenimiento.NUEVO OrElse Me.gEnum_Mantenimiento = mantenimiento.EDITAR Then
            '    'If Me.dtgCotizacion.Rows.Count > 0 Then
            '    '    lbooEstado = False
            '    'End If
            '    'HelpClassST.MsgBox("Debe guardar o cancelar.", MsgBoxStyle.Exclamation)
            '    MessageBox.Show("Debe guardar o cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If
            'btnGuardar.Text = "Modificar"
            'btnGuardar.Enabled = dtgCotizacion.Item("SESTCT", dtgCotizacion.CurrentCellAddress.Y).Value.ToString.Trim.Equals("P")
            'btnEliminar.Enabled = dtgCotizacion.Item("SESTCT", dtgCotizacion.CurrentCellAddress.Y).Value.ToString.Trim.Equals("P")
            'Me.gEnum_Mantenimiento = mantenimiento.MODIFICAR
            'Limpiar_Controles(Me.PanelMantenimiento)
            Me.Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
            Limpiar_Control()
            'Me.DetalleCotizacion()
            AsignarDatosCotizacion()
            'Dim ccmpn As String = ""
            'Dim nctzcn As String = ""
            'If dtgCotizacion.CurrentRow IsNot Nothing Then
            '    nctzcn = Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value
            '    ccmpn = Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value
            'End If
            'ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
            ListaDetalleCotizacion()
            'ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
            'lbooEstado = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TabcCotizacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabcCotizacion.SelectedIndexChanged
        Try

            If Me.Enum_Mantenimiento = MANTENIMIENTO_OPC.NUEVO OrElse Me.Enum_Mantenimiento = MANTENIMIENTO_OPC.EDITAR Then
                If TabcCotizacion.SelectedTab.Name <> tabSeleccionado Then
                    TabcCotizacion.SelectTab(tabSeleccionado)
                    MessageBox.Show("Guarde o cancele la acción", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'TabcCotizacion.SelectedTab.Name = tabSeleccionado
                End If
                Exit Sub
            End If
            tabSeleccionado = TabcCotizacion.SelectedTab.Name
            'Me.Enum_Mantenimiento = MANTENIMIENTO_OPC.NEUTRAL
            'HabilitarOpcion(MANTENIMIENTO_OPC.NEUTRAL)
            'Limpiar_Control()
            ''Me.DetalleCotizacion()
            'AsignarDatosCotizacion()
            'ListaDetalleCotizacion(Me.dtgCotizacion.CurrentRow.Cells("NCTZCN").Value, Me.dtgCotizacion.CurrentRow.Cells("CCMPN").Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class


