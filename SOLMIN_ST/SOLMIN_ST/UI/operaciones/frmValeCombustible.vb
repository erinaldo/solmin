Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmValeCombustible


    'Private gEnum_Mantenimiento As MANTENIMIENTO
    'Private bolBuscar As Boolean
    'Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    'Private objPlanta As New NEGOCIO.Planta_BLL
    'Private objDivision As New NEGOCIO.Division_BLL
    'Private _CLCLOR As Double = 0
    'Private _CLCLDS As Double = 0
    'Private bolEstado As Boolean
    Private gEnum_Mantenimiento As Mantenimiento_opc = Mantenimiento_opc.Neutral
#Region "Eventos"
    'Private Sub frmValeCombustible_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '  Me.Listar()
    '  End Sub
    Enum Mantenimiento_opc
        Nuevo
        Modificar
        Neutral
    End Enum
    Private Sub HabilitarOpc(ByVal opc As Mantenimiento_opc)
        'btnModificar
        Select Case opc
            Case Mantenimiento_opc.Neutral
                btnImprimir_1.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Visible = False
                btnGuardar.Enabled = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = True
                btnImprimir.Enabled = True
                btnAsignarCombustible.Enabled = True
                KryptonButton1.Enabled = False

                Estado_Controles(False)

            Case Mantenimiento_opc.Modificar
                btnImprimir_1.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = True
                btnGuardar.Enabled = True
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                btnImprimir.Enabled = False
                btnAsignarCombustible.Enabled = False
                KryptonButton1.Enabled = True


                'Estado_Controles(True)
            Case Mantenimiento_opc.Nuevo
                btnImprimir_1.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                btnBuscar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = True
                btnGuardar.Enabled = True
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                btnImprimir.Enabled = False
                btnAsignarCombustible.Enabled = False
                KryptonButton1.Enabled = True


                'Estado_Controles(True)
        End Select
    End Sub


  Private Sub frmValeCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
            'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            txtCodigo.Enabled = False
            gEnum_Mantenimiento = Mantenimiento_opc.Neutral
            HabilitarOpc(Mantenimiento_opc.Neutral)
            gwdDatos.AutoGenerateColumns = False
            Alinear_Columnas_Grilla()
            Validar_Acceso_Opciones_Usuario()
            Cargar_Compania()
            CargaEstado()
            'Me.btnGuardar.Enabled = False
            'Me.btnCancelar.Enabled = False
            'Me.btnEliminar.Enabled = False
            Llenar_Combo()
            '        Me.Llenar_Combo()
            'Me.cboEstado.SelectedIndex = 1
            TipoPedido()
            cboEstado.SelectedValue = "P"

            txtGalonesSolicitado.Tag = "4-3"
            txtGalonesSolicitado.MaxLength = 8
            RemoveHandler txtGalonesSolicitado.KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            AddHandler txtGalonesSolicitado.KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TipoPedido()
        'cboTipoPedido
        Dim dtTipoPed As New DataTable
        dtTipoPed.Columns.Add("DISPLAY")
        dtTipoPed.Columns.Add("VALUE")

        Dim dr As DataRow

        dr = dtTipoPed.NewRow
        dr("DISPLAY") = "Ninguno"
        dr("VALUE") = 0
        dtTipoPed.Rows.Add(dr)

        dr = dtTipoPed.NewRow
        dr("DISPLAY") = "Operación"
        dr("VALUE") = 1
        dtTipoPed.Rows.Add(dr)

        'dr = dtTipoPed.NewRow
        'dr("DISPLAY") = "Orden Servicio"
        'dr("VALUE") = 2
        'dtTipoPed.Rows.Add(dr)

        cboTipoPedido.DataSource = dtTipoPed
        cboTipoPedido.DisplayMember = "DISPLAY"
        cboTipoPedido.ValueMember = "VALUE"
        cboTipoPedido.SelectedValue = "0"
    End Sub

    Private Sub CargaEstado()
        '
        'TODOS()
        'PENDIENTE()
        'ASIGNADO()
        'LIQUIDADO()
        '  cboEstado()
        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("DISPLAY")
        dtEstado.Columns.Add("VALUE")
        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("DISPLAY") = "TODOS"
        dr("VALUE") = "T"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "PENDIENTE"
        dr("VALUE") = "P"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "ASIGNADO"
        dr("VALUE") = "A"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "LIQUIDADO"
        dr("VALUE") = "L"
        dtEstado.Rows.Add(dr)

        cboEstado.DataSource = dtEstado
        cboEstado.DisplayMember = "DISPLAY"
        cboEstado.ValueMember = "VALUE"
    End Sub

    'Private Sub ctbTracto_Texto_KeyEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    Try
    '        If Me.ctbTracto_1.pNroPlacaUnidad.Trim.Equals("") Then
    '            Me.cmbConductor_1.pClear()
    '            Exit Sub
    '        End If
    '        Dim obj_Entidad As New TransportistaTracto
    '        Dim obj_Logica As New TransportistaTracto_BLL
    '        obj_Entidad.NPLCUN = Me.ctbTracto_1.pNroPlacaUnidad
    '        obj_Entidad.CCMPN = cboCompania.SelectedValue.ToString().Trim()
    '        obj_Entidad = obj_Logica.Obtener_Informacion_Tracto(obj_Entidad)
    '        If obj_Entidad.CBRCNT.Trim = "" Then Me.cmbConductor_1.pClear()
    '        Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
    '        obeConductor.pCCMPN_Compania = cboCompania.SelectedValue
    '        obeConductor.pNRUCTR_RucTransportista = ctbTransportista_1.pRucTransportista.Trim
    '        obeConductor.pCBRCNT_Brevete = obj_Entidad.CBRCNT.Trim
    '        Me.cmbConductor_1.pCargar(obeConductor)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Try
    '        If bolBuscar Then
    '            Me.Cargar_Division()
    '            Me.Cargar_Combo_Conductor(1)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If bolBuscar Then
    '            Me.Cargar_Planta()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            gEnum_Mantenimiento = Mantenimiento_opc.Neutral
            HabilitarOpc(Mantenimiento_opc.Neutral)
            Listar()
            'Me.AccionCancelar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
   
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try
            'gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            'Me.btnNuevo.Enabled = False
            'Me.btnGuardar.Text = "Guardar"
            'Me.btnGuardar.Enabled = True
            'Me.btnCancelar.Enabled = True
            'Me.btnEliminar.Enabled = False
            gEnum_Mantenimiento = Mantenimiento_opc.Nuevo
            HabilitarOpc(Mantenimiento_opc.Nuevo)
            Limpiar_Controles()
            txtVale.Enabled = False
            dtpFecha.Enabled = True
            ctbCentroCosto.Enabled = True
            ctbTipoCombustible.Enabled = True
            txtGalonesSolicitado.Enabled = True
            txtGalonesAsignados.Enabled = False
            'txtCodigo.Enabled = True
            btnBuscarOpcion.Enabled = True
            'ctbTransportista_1.Enabled = True
            'ctbTracto_1.Enabled = True
            'cmbConductor_1.Enabled = True

            KryptonButton1.Enabled = True
            txtObservacion.Enabled = True
            txtOperacion.Enabled = False
            cboTipoPedido.Enabled = True
            txtCodigo.Text = ""
            cboTipoPedido.SelectedValue = 0
            cboTipoPedido_SelectionChangeCommitted(cboTipoPedido, Nothing)
            'Me.ChkOrdenServicio.Checked = True
            'ChkOrdenServicio.Enabled = True
            'ChkOperacion.Enabled = True
            txtOrdenServicio.Enabled = False
            txtNroLiquidacion.Enabled = False
            dtpFechaLiquidacion.Enabled = False
            'Me.Limpiar_Controles(panel_Mantenimiento)
            'Me.Estado_Controles(True, panel_Mantenimiento)
            Dim objLogica As New ValeCombustible_BLL
            Me.txtVale.Text = objLogica.Obtener_Numerador_Vale_Combustible
            Me.dtpFecha.Value = Date.Today
            'Me.ctbCentroCosto.Codigo = "117"
            Me.ctbTipoCombustible.Codigo = "D2"
            'Me.ChkOrdenServicio.Checked = True
            'Me.txtOperacion.Enabled = True
            'Me.txtOrdenServicio.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try
            'If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            '    If Validar() Then
            '        Me.Guardar_Vale_Combustible()
            '    End If
            'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            '    If Validar() Then
            '        Me.Modificar_Vale_Combustible()
            '    End If
            'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            '    If Me.gwdDatos.Item("SSVLCM", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Equals("P") Then
            '        Me.Estado_Controles(True, panel_Mantenimiento)
            '        Me.btnGuardar.Text = "Guardar"
            '        Me.btnNuevo.Enabled = False
            '        Me.btnCancelar.Enabled = True
            '        Me.btnEliminar.Enabled = False
            '        Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            '        If Me.ChkOperacion.Checked = False And Me.ChkOrdenServicio.Checked = False Then
            '            Me.txtCodigo.Enabled = False
            '            Me.btnBuscarOpcion.Enabled = False
            '        End If
            '    Else
            '        HelpClass.MsgBox("El Vale de Combustible esta Asignado y/o Liquidado, no se puede Modificar", MessageBoxIcon.Information)
            '    End If
            'End If
            Select Case gEnum_Mantenimiento
                Case Mantenimiento_opc.Modificar
                    If Validar() Then
                        Me.Modificar_Vale_Combustible()
                    End If
                Case Mantenimiento_opc.Nuevo
                    If Validar() Then
                        Me.Guardar_Vale_Combustible()
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If Me.gwdDatos.Item("SSVLCM", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Equals("P") Then
                'Me.Estado_Controles(True, panel_Mantenimiento)
                'Me.btnGuardar.Text = "Guardar"
                'Me.btnNuevo.Enabled = False
                'Me.btnCancelar.Enabled = True
                'Me.btnEliminar.Enabled = False
                'Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR

                txtVale.Enabled = False
                dtpFecha.Enabled = True
                ctbCentroCosto.Enabled = True
                ctbTipoCombustible.Enabled = True
                txtGalonesSolicitado.Enabled = True
                txtGalonesAsignados.Enabled = False
                'ChkOrdenServicio.Enabled = True
                'ChkOperacion.Enabled = True
                'txtCodigo.Enabled = True
                'btnBuscarOpcion.Enabled = True
                'ctbTransportista_1.Enabled = True
                'ctbTracto_1.Enabled = True
                'cmbConductor_1.Enabled = True
                txtObservacion.Enabled = True
                txtOperacion.Enabled = False
                txtOrdenServicio.Enabled = False
                txtNroLiquidacion.Enabled = False
                dtpFechaLiquidacion.Enabled = False
                'ChkOperacion.Enabled = True
                'ChkOrdenServicio.Enabled = True
                cboTipoPedido.Enabled = True
                'Me.txtCodigo.Enabled = False


                If cboTipoPedido.SelectedValue = 0 Then
                    btnBuscarOpcion.Enabled = False
                    'txtCodigo.Enabled = False
                    'ctbTransportista_1.Enabled = True
                    'ctbTracto_1.Enabled = True
                    'cmbConductor_1.Enabled = True

                    KryptonButton1.Enabled = True
                ElseIf cboTipoPedido.SelectedValue = 1 Then
                    btnBuscarOpcion.Enabled = True
                    'txtCodigo.Text = ""
                    'txtCodigo.Enabled = False
                    'ctbTransportista_1.pClear()
                    'ctbTracto_1.pClear()
                    'cmbConductor_1.pClear()
                    'ctbTransportista_1.Enabled = False
                    'ctbTracto_1.Enabled = False
                    'cmbConductor_1.Enabled = False
                    KryptonButton1.Enabled = False
                ElseIf cboTipoPedido.SelectedValue = 2 Then
                    btnBuscarOpcion.Enabled = True
                    'txtCodigo.Text = ""
                    'txtCodigo.Enabled = False
                End If
                'lkll()
                'If .Cells("NOPRCN").Value = 0 AndAlso .Cells("NORSRT").Value = 0 Then
                '    cboTipoPedido.SelectedValue = 0
                '    Me.txtCodigo.Text = ""
                'ElseIf .Cells("NOPRCN").Value <> 0 Then
                '    cboTipoPedido.SelectedValue = 1
                '    Me.txtCodigo.Text = .Cells("NOPRCN").Value
                'ElseIf .Cells("NORSRT").Value <> 0 Then
                '    cboTipoPedido.SelectedValue = 2
                '    Me.txtCodigo.Text = .Cells("NORSRT").Value
                'End If

                'If cboTipoPedido.SelectedValue = 0 Then
                '    btnBuscarOpcion.Enabled = False
                'ElseIf cboTipoPedido.SelectedValue = 1 OrElse cboTipoPedido.SelectedValue = 2 Then
                '    btnBuscarOpcion.Enabled = True
                'End If
                ' HabilitarOpcionTipoPedido(gwdDatos.CurrentRow.Cells("NOPRCN").Value, gwdDatos.CurrentRow.Cells("NORSRT").Value)
                'btnBuscarOpcion.Enabled = True
                'If Me.ChkOperacion.Checked = False And Me.ChkOrdenServicio.Checked = False Then
                '    'Me.txtCodigo.Enabled = False
                '    Me.btnBuscarOpcion.Enabled = False
                'End If
                gEnum_Mantenimiento = Mantenimiento_opc.Modificar
                HabilitarOpc(Mantenimiento_opc.Modificar)
            Else
                MessageBox.Show("No se puede Modificar.El Vale de Combustible está asignado y/o Liquidado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            Limpiar_Controles()
            Me.Detalle_Vale_Combustible()
            gEnum_Mantenimiento = Mantenimiento_opc.Neutral
            HabilitarOpc(Mantenimiento_opc.Neutral)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

        'Try
        '    If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
        '        Me.Estado_Controles(False, panel_Mantenimiento)
        '        If Me.gwdDatos.Rows.Count > 0 Then
        '            Me.gwdDatos.CurrentCell = Me.gwdDatos.Item(0, Me.txtVale.Tag)
        '            Me.gwdDatos.Rows(Me.txtVale.Tag).Selected = True
        '        End If
        '        gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        '        Me.btnGuardar.Enabled = True
        '        Me.btnEliminar.Enabled = True
        '        Me.btnNuevo.Enabled = True
        '        Me.btnCancelar.Enabled = False
        '        Me.btnGuardar.Text = "Modificar"
        '        Me.Detalle_Vale_Combustible()
        '    Else
        '        Me.AccionCancelar()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
      
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If Me.txtVale.Text <> "" Then
                If gwdDatos.Item("SSVLCM", gwdDatos.CurrentCellAddress.Y).Value.ToString.Equals("P") Then
                    'If HelpClass.RspMsgBox("Desea eliminar este registro?") = MsgBoxResult.Yes Then
                    If MessageBox.Show("Desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Me.Eliminar_Vale_Combustible()
                    End If
                Else
                    MessageBox.Show("No se puede Eliminar. El Vale de Combustible está Asignado y/o Liquidado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    'Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    '    Try
    '        If e.RowIndex < 0 Then Exit Sub
    '        Me.Cancelar_Accion_Grilla()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
    '  If Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    '  Select Case e.KeyCode
    '    Case Keys.Up, Keys.Down, Keys.Enter
    '      Me.Cancelar_Accion_Grilla()
    '  End Select
    'End Sub

    'Private Sub txtGalonesSolicitados_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGalonesSolicitados.KeyPress
    '      If HelpClass.SoloNumero(CShort(Asc(e.KeyChar))) = 0 Then
    '          e.Handled = True
    '      Else
    '          If 1 <= InStr(sender.Text, ".", CompareMethod.Binary) Then
    '              If e.KeyChar = "." Then
    '                  e.Handled = True
    '              End If
    '          End If
    '      End If
    '  End Sub

    ' Try
    'Dim colName As String = dtgObservaciones.Columns(dtgObservaciones.CurrentCell.ColumnIndex).Name
    'Dim Texto As New TextBox
    '        Select Case colName
    '            Case "OBSERV"
    '                Texto = CType(e.Control, TextBox)
    '                Texto.Text = Texto.Text.Trim
    '                Texto.MaxLength = 250
    '        End Select

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    '     RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
    ' AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpClass.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub



    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y = -1 Then Exit Sub
            Dim objPrintForm As New PrintForm
            Dim objReporte As New rptValeCombustible
            objReporte.SetParameterValue("pFecha", Me.dtpFecha.Value.Date)
            objReporte.SetParameterValue("pNroVale", Me.txtVale.Text)
            objReporte.SetParameterValue("pTipoCombustible", Me.ctbTipoCombustible.Descripcion)
            'objReporte.SetParameterValue("pPlacaTracto", Me.ctbTracto_1.pNroPlacaUnidad)
            'objReporte.SetParameterValue("pConductor", Me.cmbConductor_1.pNombreChofer) 'Me.ctbConductor_1.Descripcion)
            objReporte.SetParameterValue("pPlacaTracto", KryptonTextBox4.Tag)
            objReporte.SetParameterValue("pConductor", KryptonTextBox5.Text) 'Me.ctbConductor_1.Descripcion)

            objReporte.SetParameterValue("pGalonesCombustible", CType(Me.txtGalonesSolicitado.Text, Double))
            objReporte.SetParameterValue("pRuta", Me.gwdDatos.Item("RUTA", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString.Trim)
            objPrintForm.ShowForm(objReporte, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

    'Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    '      'Try
    '      If Me.gwdDatos.RowCount > 0 Then
    '          Me.gwdDatos.CurrentRow.Selected = False
    '      End If
    '      'Catch : End Try
    'End Sub

    'Private Sub ctbCentroCosto_Texto_KeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '  Me.ctbCentroCosto.Texto.BackColor = Color.White
    '  Me.ctbTipoCombustible.Texto.BackColor = Color.White
    '  Me.ctbTransportista_1.BackColor = Color.White
    '  Me.ctbTracto_1.BackColor = Color.White
    'End Sub

    'Private Sub ctbTransportista_1_InformationChanged()
    '  Me.ctbTracto_1.pClearAll()
    '  Me.cmbConductor_1.pClearAll() ' Me.ctbConductor_1.Limpiar()
    '  Me.Cargar_Combo_Vehiculo(2)
    '  Me.Cargar_Combo_Conductor(2)
    'End Sub

    'Private Sub ctbTransportista_InformationChanged()
    '  Me.ctbTracto.pClearAll()
    '  Me.cmbConductor.pClearAll() ' Me.ctbConductor.Limpiar()
    '  Me.Cargar_Combo_Vehiculo(1)
    '  Me.Cargar_Combo_Conductor(1)
    'End Sub

    'Private Sub ctbTransportista_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Try
    '        If Me.ctbTransportista.pRucTransportista.Trim.Equals("") Then
    '            Me.Cargar_Combo_Vehiculo(1)
    '            Me.cmbConductor.pClearAll() ' ctbConductor..DataSource = Nothing
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub ctbTransportista_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If Me.ctbTransportista_1.pRucTransportista.Trim.Equals("") Then
    '            Me.Cargar_Combo_Vehiculo(2)
    '            Me.cmbConductor_1.pClearAll() 'Me.ctbConductor_1.DataSource = Nothing
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub btnImprimir_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir_1.Click
        Try
            Dim frmOpcionFiltroValeCombustible As New frmOpRptValeCombustible
            With frmOpcionFiltroValeCombustible
                '.CCMPN = Me.cboCompania.SelectedValue
                '.rbtPendiente.Tag = Me.cboCompania.Text
                '.CDVSN = Me.cboDivision.SelectedValue
                '.rbtAsignados.Tag = Me.cboDivision.Text
                '.CPLNDV = Me.cboPlanta.SelectedValue
                '.rbtLiquidado.Tag = Me.cboPlanta.Text
                .CCMPN = cmbCompania.CCMPN_CodigoCompania
                '.rbtPendiente.Tag = Me.cboCompania.Text
                .rbtPendiente.Tag = cmbCompania.CCMPN_Descripcion
                '.CDVSN = Me.cboDivision.SelectedValue
                .CDVSN = cmbDivision.Division
                .rbtAsignados.Tag = cmbDivision.DivisionDescripcion
                .CPLNDV = cmbPlanta.Planta
                .rbtLiquidado.Tag = cmbPlanta.DescripcionPlanta
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    'Private Sub btnBuscarOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOpcion.Click
    '    Try
    '        If Me.ChkOrdenServicio.Checked = True Then
    '            Dim objFormBuscarOrdenServicio As New frmBuscarOrdenServicio
    '            With objFormBuscarOrdenServicio
    '                gintEstado = 100
    '                .WindowState = FormWindowState.Normal
    '                .FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
    '                .StartPosition = FormStartPosition.CenterScreen
    '                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '                Me.txtCodigo.Text = .objOrdenServicioTransporteBE.NORSRT
    '                'Me._CLCLOR = .objOrdenServicioTransporteBE.CLCLOR
    '                'Me._CLCLDS = .objOrdenServicioTransporteBE.CLCLDS
    '                '.CCMPN = cboCompania.SelectedValue.ToString().Trim()
    '                .CCMPN = cmbCompania.CCMPN_CodigoCompania
    '            End With
    '        Else
    '            Dim BuscarOperacion As New frmBuscarOperacion
    '            With BuscarOperacion
    '                '.CCMPN = Me.cboCompania.SelectedValue
    '                '.CDVSN = Me.cboDivision.SelectedValue
    '                '.CPLNDV = Me.cboPlanta.SelectedValue
    '                .CCMPN = cmbCompania.CCMPN_CodigoCompania
    '                .CDVSN = cmbDivision.Division
    '                .CPLNDV = cmbPlanta.Planta
    '                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
    '                    txtCodigo.Text = .NOPRCN_1
    '                End If
    '            End With
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub


    Private Sub btnBuscarOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOpcion.Click
        Try
            Dim tipo As Int32 = cboTipoPedido.SelectedValue
            Select Case tipo
                Case 1 'operacion
                    Dim BuscarOperacion As New frmBuscarOperacion
                    With BuscarOperacion
                        '.CCMPN = Me.cboCompania.SelectedValue
                        '.CDVSN = Me.cboDivision.SelectedValue
                        '.CPLNDV = Me.cboPlanta.SelectedValue
                        .CCMPN = cmbCompania.CCMPN_CodigoCompania
                        .CDVSN = cmbDivision.Division
                        .CPLNDV = cmbPlanta.Planta
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then


                            'mNRUCTR = Me.gwdDatos.Item("NRUCTR", lint_Indice).Value.ToString
                            'mCBRCNT = Me.gwdDatos.Item("CBRCNT", lint_Indice).Value.ToString
                            'mCTRSPT = Me.gwdDatos.Item("CTRSPT", lint_Indice).Value.ToString
                            'mNPLCTR = Me.gwdDatos.Item("NPLCTR", lint_Indice).Value.ToString


                            txtCodigo.Text = .NOPRCN_1
                            'Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
                            'obeTransportista.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
                            'Me.ctbTransportista_1.pCargar(obeTransportista)
                            'obeTransportista.pNRUCTR_RucTransportista = .NRUCTR_1.Trim
                            'Me.ctbTransportista_1.pCargar(obeTransportista)
                            'ctbTransportista_1_ExitFocusWithOutData_InformationChanged()

                            KryptonTextBox3.Tag = .NRUCTR_1
                            KryptonTextBox3.Text = .NRUCTR_1







                            'Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
                            'obeTracto.pCCMPN_Compania = ctbTransportista_1.pCompania
                            'obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
                            'obeTracto.pCDVSN_Division = cmbDivision.Division
                            'obeTracto.pCPLNDV_Planta = cmbPlanta.Planta
                            'obeTracto.pNRUCTR_RucTransportista = ctbTransportista_1.pRucTransportista.Trim
                            'obeTracto.pNPLCUN_NroPlacaUnidad = .NPLCTR_1.Trim
                            'ctbTracto_1.pCargar(obeTracto)
                            KryptonTextBox4.Tag = .NPLCTR_1
                            KryptonTextBox4.Text = .NPLCTR_1


                            'Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
                            'obeConductor.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
                            'obeConductor.pNRUCTR_RucTransportista = ctbTransportista_1.pRucTransportista.Trim
                            'obeConductor.pCBRCNT_Brevete = .CBRCNT_1
                            'Me.cmbConductor_1.pCargar(obeConductor)

                            KryptonTextBox5.Tag = .CBRCNT_1
                            KryptonTextBox5.Text = .CBRCNT_1

                        End If
                    End With
                Case 2 'orden servicio
                    Dim objFormBuscarOrdenServicio As New frmBuscarOrdenServicio
                    With objFormBuscarOrdenServicio
                        gintEstado = 100
                        .WindowState = FormWindowState.Normal
                        .FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
                        .StartPosition = FormStartPosition.CenterScreen
                        .CCMPN = cmbCompania.CCMPN_CodigoCompania
                        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                        Me.txtCodigo.Text = .objOrdenServicioTransporteBE.NORSRT
                        'Me._CLCLOR = .objOrdenServicioTransporteBE.CLCLOR
                        'Me._CLCLDS = .objOrdenServicioTransporteBE.CLCLDS
                        '.CCMPN = cboCompania.SelectedValue.ToString().Trim()
                        '.CCMPN = cmbCompania.CCMPN_CodigoCompania
                    End With
            End Select
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


  Private Sub btnAsignarCombustible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarCombustible.Click
    Try
            'If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
            If Me.gwdDatos.CurrentRow Is Nothing Then Exit Sub
      Dim _indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
      If Me.gwdDatos.Item("SSVLCM", _indice).Value <> "P" Then
        HelpClass.MsgBox("Vale Combustible está Asignado Y/O Liquidado", MessageBoxIcon.Information)
        Exit Sub
      End If
      Dim obj_Entidad As New Combustible
      Dim frm_AsignarCombustible As New frmAsignarCombustible
      With frm_AsignarCombustible
                'obj_Entidad.CCMPN = Me.cboCompania.SelectedValue
                'obj_Entidad.CDVSN = Me.cboDivision.SelectedValue
                'obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
                obj_Entidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
                obj_Entidad.CDVSN = cmbDivision.Division
                obj_Entidad.CPLNDV = cmbPlanta.Planta
        obj_Entidad.CTRSPT = Me.gwdDatos.Item("CTRSPT", _indice).Value
        obj_Entidad.NRUCTR = Me.gwdDatos.Item("NRUCTR", _indice).Value
        obj_Entidad.NRUCTR = Me.gwdDatos.Item("NRUCTR", _indice).Value
        obj_Entidad.NPLCUN = Me.gwdDatos.Item("NPLVEH", _indice).Value
        obj_Entidad.CBRCNT = Me.gwdDatos.Item("CBRCNT", _indice).Value
        .obj_Entidad_Combustible = obj_Entidad
        .Tag = 0
        .txtValeCombustible.Enabled = False
        .btnBuscarVale.Enabled = False
        .chkValidarVale.Enabled = False
        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        'Me.gwdDatos.Item("SSVLCM", _indice).Value = "A"
        Me.Listar()
                'Me.AccionCancelar()
      End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

    'Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
    '  If e.KeyChar = "." Then
    '    e.Handled = True
    '    Exit Sub
    '  End If
    '  If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    'End Sub

    'Private Sub ChkOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkOperacion.CheckedChanged

    '    Try
    '        If bolEstado And ChkOrdenServicio.Checked Then
    '            'bolEstado = False
    '            ChkOrdenServicio.Checked = False
    '        End If
    '        'bolEstado = True
    '        Me.txtCodigo.ReadOnly = False
    '        If Me.ChkOrdenServicio.Checked = True Then
    '            Me.txtCodigo.Text = ""
    '            Me.txtCodigo.ReadOnly = True
    '        Else
    '            Me.txtCodigo.Text = IIf(Me.txtOperacion.Text.Trim.Equals("0"), "", Me.txtOperacion.Text.Trim)
    '        End If
    '        If Me.txtGalonesSolicitados.Enabled = False Then Exit Sub
    '        If Me.ChkOperacion.Checked = True OrElse Me.ChkOrdenServicio.Checked = True Then
    '            Me.txtCodigo.Enabled = bolEstado
    '            Me.btnBuscarOpcion.Enabled = bolEstado
    '        Else
    '            Me.txtCodigo.Enabled = Not bolEstado
    '            Me.btnBuscarOpcion.Enabled = Not bolEstado
    '            Me.txtCodigo.Text = ""
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub ChkOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Try
    '        If ChkOperacion.Checked = True Then
    '            ChkOrdenServicio.Checked = False
    '            Me.txtCodigo.Text = ""
    '        End If
    '        'If bolEstado And ChkOrdenServicio.Checked Then
    '        '    'bolEstado = False
    '        '    ChkOrdenServicio.Checked = False
    '        'End If
    '        ''bolEstado = True
    '        'Me.txtCodigo.ReadOnly = False
    '        'If Me.ChkOrdenServicio.Checked = True Then
    '        '    Me.txtCodigo.Text = ""
    '        '    Me.txtCodigo.ReadOnly = True
    '        'Else
    '        '    txtCodigo.Text = IIf(Me.txtOperacion.Text.Trim.Equals("0"), "", Me.txtOperacion.Text.Trim)
    '        'End If
    '        'If Me.txtGalonesSolicitados.Enabled = False Then Exit Sub
    '        'If Me.ChkOperacion.Checked = True OrElse Me.ChkOrdenServicio.Checked = True Then
    '        '    Me.txtCodigo.Enabled = bolEstado
    '        '    Me.btnBuscarOpcion.Enabled = bolEstado
    '        'Else
    '        '    Me.txtCodigo.Enabled = Not bolEstado
    '        '    Me.btnBuscarOpcion.Enabled = Not bolEstado
    '        '    Me.txtCodigo.Text = ""
    '        'End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub


    'Private Sub ChkOrdenServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        'If bolEstado And Me.ChkOperacion.Checked Then
    '        '    bolEstado = False
    '        '    Me.ChkOperacion.Checked = False
    '        'End If
    '        'bolEstado = True
    '        'Me.txtCodigo.ReadOnly = False
    '        'If Me.ChkOrdenServicio.Checked = True Then
    '        '    Me.txtCodigo.Text = ""
    '        '    Me.txtCodigo.ReadOnly = True
    '        'Else
    '        '    Me.txtCodigo.Text = IIf(Me.txtOperacion.Text.Trim.Equals("0"), "", Me.txtOperacion.Text.Trim)
    '        'End If
    '        'If Me.txtGalonesSolicitados.Enabled = False Then Exit Sub
    '        'If Me.ChkOperacion.Checked = True OrElse Me.ChkOrdenServicio.Checked = True Then
    '        '    Me.txtCodigo.Enabled = bolEstado
    '        '    Me.btnBuscarOpcion.Enabled = bolEstado
    '        'Else
    '        '    Me.txtCodigo.Enabled = Not bolEstado
    '        '    Me.btnBuscarOpcion.Enabled = Not bolEstado
    '        '    Me.txtCodigo.Text = ""
    '        'End If

    '        ChkOperacion()
    '        If ChkOrdenServicio.Checked = False And ChkOperacion.Checked = False Then
    '            Me.btnBuscarOpcion.Enabled = False
    '            Me.txtCodigo.Text = ""
    '        End If
    '        If ChkOrdenServicio.Checked = True Then
    '            ChkOperacion.Checked = False
    '            Me.txtCodigo.Text = ""
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub ChkOrdenServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkOrdenServicio.CheckedChanged
    '    Try
    '        If bolEstado And Me.ChkOperacion.Checked Then
    '            bolEstado = False
    '            Me.ChkOperacion.Checked = False
    '        End If
    '        bolEstado = True
    '        Me.txtCodigo.ReadOnly = False
    '        If Me.ChkOrdenServicio.Checked = True Then
    '            Me.txtCodigo.Text = ""
    '            Me.txtCodigo.ReadOnly = True
    '        Else
    '            Me.txtCodigo.Text = IIf(Me.txtOperacion.Text.Trim.Equals("0"), "", Me.txtOperacion.Text.Trim)
    '        End If
    '        If Me.txtGalonesSolicitados.Enabled = False Then Exit Sub
    '        If Me.ChkOperacion.Checked = True OrElse Me.ChkOrdenServicio.Checked = True Then
    '            Me.txtCodigo.Enabled = bolEstado
    '            Me.btnBuscarOpcion.Enabled = bolEstado
    '        Else
    '            Me.txtCodigo.Enabled = Not bolEstado
    '            Me.btnBuscarOpcion.Enabled = Not bolEstado
    '            Me.txtCodigo.Text = ""
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

#End Region

#Region "Métodos"

    'Private Sub Cargar_Compania()
    '  objCompaniaBLL.Crea_Lista()
    '  bolBuscar = False
    '  Me.cboCompania.DataSource = objCompaniaBLL.Lista
    '      Me.cboCompania.ValueMember = "CCMPN"
    '      Me.cboCompania.DisplayMember = "TCMPCM"
    '      'cboCompania.SelectedValue = "EZ"
    '      bolBuscar = True
    '      'If cboCompania.SelectedIndex = -1 Then
    '      '    cboCompania.SelectedIndex = 0
    '      'End If
    '      Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    '      cboCompania_SelectedIndexChanged(Nothing, Nothing)
    'End Sub

    'Private Sub Cargar_Division()
    '    'Try
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    bolBuscar = False
    '    objDivision.Crea_Lista()
    '    Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
    '    Me.cboDivision.ValueMember = "CDVSN"
    '    Me.cboDivision.DisplayMember = "TCMPDV"
    '    Me.cboDivision.SelectedValue = "T"
    '    bolBuscar = True
    '    If Me.cboDivision.SelectedIndex = -1 Then
    '        Me.cboDivision.SelectedIndex = 0
    '    End If
    '    cboDivision_SelectedIndexChanged(Nothing, Nothing)
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '    'Catch ex As Exception
    '    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '    '    HelpClass.MsgBox(ex.Message)
    '    'End Try
    'End Sub

    Private Sub Cargar_Compania()
        Try
            cmbCompania.Usuario = MainModule.USUARIO
            cmbCompania.pActualizar()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted

        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                cmbDivision.DivisionDefault = "T"
            End If
            cmbDivision.pActualizar()
            cmbDivision_Seleccionar(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            Me.cmbPlanta.Usuario = MainModule.USUARIO
            Me.cmbPlanta.CodigoCompania = cmbDivision.Compania
            Me.cmbPlanta.CodigoDivision = cmbDivision.Division
            Me.cmbPlanta.PlantaDefault = 1
            Me.cmbPlanta.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    'Private Sub Cargar_Planta()
    '      'Try
    '      If bolBuscar Then
    '          'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '          bolBuscar = False
    '          objPlanta.Crea_Lista()
    '          Me.cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
    '          Me.cboPlanta.ValueMember = "CPLNDV"
    '          Me.cboPlanta.DisplayMember = "TPLNTA"
    '          Me.cboPlanta.SelectedIndex = 0
    '          bolBuscar = True
    '          Me.Llenar_Combo()
    '          'Me.Cursor = System.Windows.Forms.Cursors.Default
    '      End If
    '      'Catch ex As Exception
    '      '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '      '        HelpClass.MsgBox(ex.Message)
    '      '    End Try
    'End Sub

  Private Sub Validar_Acceso_Opciones_Usuario()
    Dim objParametro As New Hashtable
    Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
    Dim objEntidad As New ClaseGeneral

    objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
    objParametro.Add("MMCUSR", MainModule.USUARIO)
    objParametro.Add("MMNPVB", Me.Name.Trim)
    objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

    If objEntidad.STSADI = "" Then
      Me.btnNuevo.Visible = False
      Me.Separator1.Visible = False
    End If
    If objEntidad.STSCHG = "" Then
      Me.btnGuardar.Visible = False
      Me.Separator2.Visible = False
    End If
    If objEntidad.STSADI = "" And objEntidad.STSCHG = "" Then
      Me.btnCancelar.Visible = False
      Me.Separator3.Visible = False
    End If
    If objEntidad.STSELI = "" Then
      Me.btnEliminar.Visible = False
      Me.Separator3.Visible = False
    End If
    If objEntidad.STSOP1 = "" Then
      Me.btnImprimir.Visible = False
      Me.Separator4.Visible = False
    End If
    If objEntidad.STSOP2 = "" Then
      Me.btnAsignarCombustible.Visible = False
      Me.Separator5.Visible = False
    End If

  End Sub

    'Private Sub Cancelar_Accion_Grilla()
    '  Select Case Me.gEnum_Mantenimiento
    '    Case MANTENIMIENTO.NUEVO
    '      If Me.gwdDatos.Rows.Count > 0 Then
    '        Me.gwdDatos.CurrentCell = Nothing
    '      End If
    '      HelpClass.MsgBox("Debe guardar o cancelar la Operación.", MsgBoxStyle.Exclamation)
    '      Exit Sub
    '    Case MANTENIMIENTO.EDITAR
    '      HelpClass.MsgBox("Debe guardar o cancelar la Operación.", MsgBoxStyle.Exclamation)
    '      Me.gwdDatos.CurrentCell = Me.gwdDatos.Item(0, Me.txtVale.Tag)
    '      Me.gwdDatos.Rows(Me.txtVale.Tag).Selected = True
    '      Exit Sub
    '  End Select
    '  Me.btnGuardar.Text = "Modificar"
    '  Me.btnGuardar.Enabled = True
    '  Me.btnEliminar.Enabled = True
    '  Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    '  Me.Detalle_Vale_Combustible()
    'End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    For lint_Contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Llenar_Combo()
    Dim obj_Logica_TipoCombustible As New TipoCombustible_BLL
    Dim objNegociosCentroCosto As New NEGOCIO.mantenimiento.CentroCosto_BLL
    Dim obj_logica_Conductor As New Detalle_Solicitud_Transporte_BLL
    Dim objEntidad_CentroCosto As New ENTIDADES.mantenimientos.CentroCosto
    Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        'Try
        'objEntidad_CentroCosto.CCMPN = Me.cboCompania.SelectedValue.ToString.Trim
        objEntidad_CentroCosto.CCMPN = cmbCompania.CCMPN_CodigoCompania
        'If Me.cboCompania.SelectedValue = "EZ" Then
        'If cmbCompania.CCMPN_CodigoCompania = "EZ" Then
        '    'obeTransportista.pCCMPN_Compania = Me.cboCompania.SelectedValue
        '    obeTransportista.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
        '    Me.ctbTransportista_1.pCargar(obeTransportista)
        '    obeTransportista.pNRUCTR_RucTransportista = "20100039207"
        '    Me.ctbTransportista.pCargar(obeTransportista)
        '    'Me.ctbTransportista_InformationChanged()
        '    ctbTransportista_ExitFocusWithOutData_InformationChanged()
        'Else
        '    Me.ctbTransportista.pClear()
        '    Me.ctbTransportista_1.pClear()
        '    obeTransportista = New Ransa.TypeDef.Transportista.TD_TransportistaPK
        '    'obeTransportista.pCCMPN_Compania = Me.cboCompania.SelectedValue
        '    obeTransportista.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
        '    Me.ctbTransportista.pCargar(obeTransportista)
        '    Me.ctbTransportista_1.pCargar(obeTransportista)
        '    'Me.ctbTransportista_InformationChanged()
        '    ctbTransportista_ExitFocusWithOutData_InformationChanged()

        'End If

        If cmbCompania.CCMPN_CodigoCompania = "EZ" Then
            Me.ctbTransportista.pClear()
            'Me.ctbTransportista_1.pClear()
            obeTransportista.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            'Me.ctbTransportista_1.pCargar(obeTransportista)
            obeTransportista.pNRUCTR_RucTransportista = "20100039207"
            Me.ctbTransportista.pCargar(obeTransportista)
            ctbTransportista_ExitFocusWithOutData_InformationChanged()
            ctbTransportista.Enabled = False


            obeTransportista = New Ransa.TypeDef.Transportista.TD_TransportistaPK
            obeTransportista.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            'Me.ctbTransportista_1.pCargar(obeTransportista)
            ctbTransportista_ExitFocusWithOutData_InformationChanged()

        Else
            Me.ctbTransportista.pClear()
            'Me.ctbTransportista_1.pClear()
            obeTransportista = New Ransa.TypeDef.Transportista.TD_TransportistaPK
            obeTransportista.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            Me.ctbTransportista.pCargar(obeTransportista)
            'Me.ctbTransportista_1.pCargar(obeTransportista)
            ctbTransportista_ExitFocusWithOutData_InformationChanged()

        End If

        With Me.ctbTipoCombustible
            .DataSource = HelpClass.GetDataSetNative(obj_Logica_TipoCombustible.Listar_TipoCombustible)
            .KeyField = "CTPCMB"
            .ValueField = "TDSCMB"
            .DataBind()
        End With

        With ctbCentroCosto
            .DataSource = HelpClass.GetDataSetNative(objNegociosCentroCosto.Listar_Centro_Costo(objEntidad_CentroCosto))
            .KeyField = "CCNTCS"
            .ValueField = "TCNTCS"
            .DataBind()
        End With
        'Catch : End Try
        'Me.gwdDatos.DataSource = Nothing
  End Sub

    'Private Sub Cargar_Combo_Vehiculo(ByVal Estado As Integer)
    '  Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
    '      'obeTracto.pCCMPN_Compania = Me.cboCompania.SelectedValue
    '      'obeTracto.pCDVSN_Division = Me.cboDivision.SelectedValue
    '      'obeTracto.pCPLNDV_Planta = Me.cboPlanta.SelectedValue
    '      obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    '      obeTracto.pCDVSN_Division = cmbDivision.Division
    '      obeTracto.pCPLNDV_Planta = cmbPlanta.Planta
    '  Select Case Estado
    '    Case 1
    '      obeTracto.pNRUCTR_RucTransportista = Me.ctbTransportista.pRucTransportista
    '      Me.ctbTracto.pCargar(obeTracto)
    '    Case 2
    '      obeTracto.pNRUCTR_RucTransportista = Me.ctbTransportista_1.pRucTransportista
    '      Me.ctbTracto_1.pCargar(obeTracto)
    '  End Select

    'End Sub

    'Private Sub Cargar_Combo_Conductor(ByVal Estado As Integer)
    '  Dim obj_logica As New Detalle_Solicitud_Transporte_BLL
    '      'Try
    '      Select Case Estado
    '          Case 1
    '              Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
    '              'obeConductor.pCCMPN_Compania = cboCompania.SelectedValue
    '              obeConductor.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    '              obeConductor.pNRUCTR_RucTransportista = ctbTransportista.pRucTransportista.Trim
    '              Me.cmbConductor.pCargar(obeConductor)
    '          Case 2
    '              Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
    '              obeConductor.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    '              obeConductor.pNRUCTR_RucTransportista = ctbTransportista_1.pRucTransportista.Trim
    '              Me.cmbConductor_1.pCargar(obeConductor)
    '      End Select
    '      'Catch : End Try
    'End Sub

    'Private Function Asignar_Valor() As String

    '  Dim cadena As String = ""

    '  If Me.cboEstado.SelectedIndex = 0 Then
    '    cadena = ""
    '  ElseIf Me.cboEstado.SelectedIndex = 1 Then
    '    cadena = "P"
    '  ElseIf Me.cboEstado.SelectedIndex = 2 Then
    '    cadena = "A"
    '  ElseIf Me.cboEstado.SelectedIndex = 3 Then
    '    cadena = "L"
    '  End If
    '  Return cadena
    'End Function

    Private Sub Listar()
        Limpiar_Controles()
        gwdDatos.DataSource = Nothing
        Dim obrValeCombustible As New ValeCombustible_BLL
        Dim obeValeCombustible As New ValeCombustible
        With obeValeCombustible
            '.CCMPN = Me.cboCompania.SelectedValue
            '.CDVSN = Me.cboDivision.SelectedValue
            '.CPLNDV = Me.cboPlanta.SelectedValue
            .CCMPN = cmbCompania.CCMPN_CodigoCompania
            .CDVSN = cmbDivision.Division
            .CPLNDV = cmbPlanta.Planta
            .CTRSPT = ctbTransportista.pCodigoRNS
            .NPLVEH = ctbTracto.pNroPlacaUnidad
            .CBRCNT = cmbConductor.pBrevete   ' Me.ctbConductor.Codigo
            '.SSVLCM = Me.Asignar_Valor
            If cboEstado.SelectedValue = "T" Then
                .SSVLCM = ""
            Else
                .SSVLCM = cboEstado.SelectedValue
            End If
            .FECINI = dtpFechaInicio.Value.ToString("yyyyMMdd")
            .FECFIN = dtpFechaFin.Value.ToString("yyyyMMdd")
        End With
        Me.gwdDatos.DataSource = obrValeCombustible.Listar_Vale_Combustible(obeValeCombustible)
        If gwdDatos.Rows.Count = 0 Then
            Limpiar_Controles()
        End If
    End Sub

    'Private Sub Estado_Controles(ByVal lbool_estado As Boolean, ByVal Contenedor As Object)
    '  Dim X As Control
    '  If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or MANTENIMIENTO.NUEVO Or MANTENIMIENTO.MODIFICAR Then
    '    For Each X In Contenedor.Controls
    '      If Not (TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonLabel) Then
    '        X.Enabled = lbool_estado
    '      End If
    '    Next
    '  End If
    '  Me.txtVale.Enabled = False
    '  Me.txtGalonesAsignados.Enabled = False
    '  Me.txtNroLiquidacion.Enabled = False
    '  Me.dtpFechaLiquidacion.Enabled = False
    '  Me.txtOrdenServicio.Enabled = False
    '  Me.txtOperacion.Enabled = False
    'End Sub



    Private Sub Estado_Controles(ByVal lbool_estado As Boolean)
        'Me.txtVale.Enabled = lbool_estado
        'Me.txtGalonesAsignados.Enabled = lbool_estado
        'Me.txtNroLiquidacion.Enabled = lbool_estado
        'Me.dtpFechaLiquidacion.Enabled = lbool_estado
        'Me.txtOrdenServicio.Enabled = lbool_estado
        'Me.txtOperacion.Enabled = lbool_estado
        txtVale.Enabled = False
        dtpFecha.Enabled = lbool_estado
        ctbCentroCosto.Enabled = lbool_estado
        ctbTipoCombustible.Enabled = lbool_estado
        txtGalonesSolicitado.Enabled = lbool_estado
        txtGalonesAsignados.Enabled = False
        'ChkOrdenServicio.Enabled = lbool_estado
        'ChkOperacion.Enabled = lbool_estado
        cboTipoPedido.Enabled = lbool_estado
        'txtCodigo.Enabled = lbool_estado
        'txtCodigo.Enabled = False
        btnBuscarOpcion.Enabled = lbool_estado
        'ctbTransportista_1.Enabled = lbool_estado
        'ctbTracto_1.Enabled = lbool_estado
        'cmbConductor_1.Enabled = lbool_estado
        txtObservacion.Enabled = lbool_estado
        txtOperacion.Enabled = False
        txtOrdenServicio.Enabled = False
        txtNroLiquidacion.Enabled = False
        dtpFechaLiquidacion.Enabled = False
    End Sub

    Public Sub Limpiar_Controles()
        '(ByVal Contenedor As Object)
        'If Me.gwdDatos.Rows.Count > 0 Then
        '  Me.gwdDatos.CurrentCell = Nothing
        'End If
        'Dim X As Control
        'For Each X In Contenedor.Controls
        '  If TypeOf X Is CodeTextBox.CodeTextBox Then CType(X, CodeTextBox.CodeTextBox).Limpiar()
        '  If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Clear()
        '  If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonComboBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonComboBox).SelectedIndex = -1
        'Next
        'ctbTransportista_1.pClear()
        'ctbTracto_1.pClear()
        'Me.txtCodigo.Text = ""
        'Me.ChkOrdenServicio.Checked = False
        'Me.ChkOperacion.Checked = False
        txtVale.Clear()
        dtpFecha.Value = Now
        ctbCentroCosto.Limpiar()
        ctbTipoCombustible.Limpiar()
        txtGalonesSolicitado.Clear()
        txtGalonesAsignados.Clear()
        'ChkOrdenServicio.Checked = False
        'ChkOperacion.Checked = False
        cboTipoPedido.SelectedValue = 0
        txtCodigo.Clear()
        'ctbTransportista_1.pClear()
        'ctbTracto_1.pClear()
        'cmbConductor_1.pClear()
        KryptonTextBox3.Tag = 0
        KryptonTextBox3.Text = ""

        KryptonTextBox4.Tag = ""
        KryptonTextBox4.Text = ""

        KryptonTextBox5.Tag = ""
        KryptonTextBox5.Text = ""


        txtObservacion.Clear()
        txtOperacion.Clear()
        txtOrdenServicio.Clear()
        txtNroLiquidacion.Clear()
        dtpFechaLiquidacion.Clear()
    End Sub

    Private Function Validar() As Double
        Dim strError As String = ""
        If Me.ctbCentroCosto.NoHayCodigo Then
            strError += "* Centro Costo" & Chr(13)
        End If
        If Me.ctbTipoCombustible.NoHayCodigo Then
            strError += "* Tipo combustible" & Chr(13)
        End If
        If Me.txtGalonesSolicitado.Text.Trim = vbNullString Then
            strError += "* Galones solicitados" & Chr(13)
        End If
        If Val("" & KryptonTextBox3.Tag) = 0 Then
            strError += "* Transportista" & Chr(13)
        End If
        If ("" & KryptonTextBox4.Tag).ToString.Trim.Length = 0 Then
            strError += "* Tracto" & Chr(13)
        End If

        'If Me.ctbTransportista_1.pRucTransportista.Trim.Equals("") Then
        '    strError += "* Transportista" & Chr(13)
        'End If
        'If Me.ctbTracto_1.pNroPlacaUnidad.Trim.Equals("") Then
        '    strError += "* Tracto" & Chr(13)
        'End If

        'If Me.ctbConductor_1.NoHayCodigo Then
        '  strError += "* CONDUCTOR" & Chr(13)
        'End If
        'If Me.txtCodigo.Text.Trim.Equals("") Then
        '  strError += "* TIPO PEDIDO VALE" & Chr(13)
        'End If
        'If Me.ChkOperacion.Checked = True OrElse Me.ChkOrdenServicio.Checked = True Then
        '    If Me.txtCodigo.Text.Trim.Equals("") Then
        '        strError += "* TIPO PEDIDO VALE" & Chr(13)
        '    End If
        'End If
        If cboTipoPedido.SelectedValue = 1 OrElse cboTipoPedido.SelectedValue = 2 Then
            If Me.txtCodigo.Text.Trim.Equals("") Then
                strError += "* Tipo pedido vale" & Chr(13)
            End If
        End If
        strError = strError.Trim
        If strError.Trim.Length > 0 Then
            MessageBox.Show("Debe ingresar: " & Chr(13) & strError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    'Private Sub AccionCancelar()
    '  gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '  Me.Estado_Controles(False, panel_Mantenimiento)
    '  Me.Limpiar_Controles(panel_Mantenimiento)
    '  If Me.gwdDatos.Rows.Count > 0 Then
    '    Me.gwdDatos.CurrentCell = Nothing
    '  End If
    '  Me.btnGuardar.Text = "Guardar"
    '  Me.btnGuardar.Enabled = False
    '  Me.btnEliminar.Enabled = False
    '  Me.btnNuevo.Enabled = True
    '  Me.btnCancelar.Enabled = False
    '  Me._CLCLOR = 0
    '  Me._CLCLDS = 0
    'End Sub

  Private Sub Guardar_Vale_Combustible()
    Dim obrValeCombustible As New ValeCombustible_BLL
    Dim obeValeCombustible As New ValeCombustible
        'Try
        'With obeValeCombustible
        'obeValeCombustible.FECSLC = HelpClass.CDate_a_Numero8Digitos(Me.dtpFecha.Value)
        obeValeCombustible.FECSLC = dtpFecha.Value.ToString("yyyyMMdd")
        obeValeCombustible.CCNTCS = ctbCentroCosto.Codigo
        obeValeCombustible.CTPCMB = ctbTipoCombustible.Codigo
        obeValeCombustible.QGLNSL = CType(txtGalonesSolicitado.Text.Trim, Double)
        '.CCMPN = Me.cboCompania.SelectedValue
        '.CDVSN = Me.cboDivision.SelectedValue
        '.CPLNDV = Me.cboPlanta.SelectedValue
        obeValeCombustible.CCMPN = cmbCompania.CCMPN_CodigoCompania.Trim
        obeValeCombustible.CDVSN = cmbDivision.Division.Trim
        obeValeCombustible.CPLNDV = cmbPlanta.Planta
        'obeValeCombustible.NRUCTR = ctbTransportista_1.pRucTransportista.Trim
        'obeValeCombustible.NPLVEH = ctbTracto_1.pNroPlacaUnidad.Trim
        'obeValeCombustible.CBRCNT = cmbConductor_1.pBrevete.Trim  ' Me.ctbConductor_1.Codigo

        obeValeCombustible.NRUCTR = KryptonTextBox3.Tag
        obeValeCombustible.NPLVEH = KryptonTextBox4.Tag
        obeValeCombustible.CBRCNT = KryptonTextBox5.Tag

        'If ChkOperacion.Checked = False And ChkOrdenServicio.Checked = False Then
        '    obeValeCombustible.NOPRCN = 0
        '    obeValeCombustible.NORSRT = 0
        '    obeValeCombustible.CLCLOR = 0
        '    obeValeCombustible.CLCLDS = 0
        'ElseIf ChkOperacion.Checked = True Then
        '    obeValeCombustible.NOPRCN = IIf(txtCodigo.Text.Trim.Equals(""), 0, txtCodigo.Text.Trim)
        'Else
        '    obeValeCombustible.NORSRT = IIf(txtCodigo.Text.Trim.Equals(""), 0, txtCodigo.Text.Trim)
        '    'obeValeCombustible.CLCLOR = Me._CLCLOR
        '    'obeValeCombustible.CLCLDS = Me._CLCLDS
        'End If

        If cboTipoPedido.SelectedValue = 0 Then
            obeValeCombustible.NOPRCN = 0
            obeValeCombustible.NORSRT = 0
            obeValeCombustible.CLCLOR = 0
            obeValeCombustible.CLCLDS = 0
        ElseIf cboTipoPedido.SelectedValue = 1 Then
            obeValeCombustible.NOPRCN = IIf(txtCodigo.Text.Trim.Equals(""), 0, txtCodigo.Text.Trim)
        ElseIf cboTipoPedido.SelectedValue = 2 Then
            obeValeCombustible.NORSRT = IIf(txtCodigo.Text.Trim.Equals(""), 0, txtCodigo.Text.Trim)
            'obeValeCombustible.CLCLOR = Me._CLCLOR
            'obeValeCombustible.CLCLDS = Me._CLCLDS
        End If
        obeValeCombustible.TOBSCR = Me.txtObservacion.Text.Trim
        obeValeCombustible.FCHCRT = HelpClass.TodayNumeric
        obeValeCombustible.HRACRT = HelpClass.NowNumeric
        obeValeCombustible.USRCRT = MainModule.USUARIO
        obeValeCombustible.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        'End With

        Dim dtValesTracto As New DataTable
        dtValesTracto = obrValeCombustible.Listar_Vale_Combustible_Pendientes_X_Tracto(obeValeCombustible)
        If dtValesTracto.Rows.Count > 0 Then
            If MessageBox.Show("La unidad " & KryptonTextBox4.Tag & " tiene " & dtValesTracto.Rows.Count & " vale(s) " & Chr(13) & " aún Pendientes/Asignados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning) Then
                Exit Sub
            End If
        End If

        Dim reg As Decimal = obrValeCombustible.Registrar_Vale_Combustible(obeValeCombustible).NRSCVL
        Select Case reg
            Case -1
                ' HelpClass.MsgBox("No existe la Orden de Servicio", MessageBoxIcon.Information)
                MessageBox.Show("No existe la orden de Servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case -2
                'HelpClass.MsgBox("No existe la Operación", MessageBoxIcon.Information)
                MessageBox.Show("No existe la operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case Else
                MessageBox.Show("Se registró satisfactoriamente el vale Número : " & reg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                gEnum_Mantenimiento = Mantenimiento_opc.Neutral
                HabilitarOpc(Mantenimiento_opc.Neutral)
                Listar()
                'Me.AccionCancelar()
        End Select
        'Select Case obrValeCombustible.Registrar_Vale_Combustible(obeValeCombustible).NRSCVL
        '    Case -1
        '        HelpClass.MsgBox("No existe la Orden de Servicio", MessageBoxIcon.Information)
        '        Exit Sub
        '    Case -2
        '        HelpClass.MsgBox("No existe la Operación", MessageBoxIcon.Information)
        '        Exit Sub
        '    Case 0
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        'End Select
        'HelpClass.MsgBox("Se Registró Satisfactoriamente")
        'Me.Listar()
        'Me.AccionCancelar()
        'Catch : End Try

  End Sub

  Private Sub Modificar_Vale_Combustible()
    Dim obrValeCombustible As New ValeCombustible_BLL
    Dim obeValeCombustible As New ValeCombustible
        'Try
        With obeValeCombustible
            .NRSCVL = CType(txtVale.Text, Double)
            .FECSLC = HelpClass.CDate_a_Numero8Digitos(dtpFecha.Value)
            .CCNTCS = ctbCentroCosto.Codigo
            .CTPCMB = ctbTipoCombustible.Codigo
            .QGLNSL = CType(txtGalonesSolicitado.Text.Trim, Double)
            '.NRUCTR = ctbTransportista_1.pRucTransportista.Trim
            '.NPLVEH = ctbTracto_1.pNroPlacaUnidad.Trim
            '.CBRCNT = cmbConductor_1.pBrevete.Trim  ' Me.ctbConductor_1.Codigo

            .NRUCTR = KryptonTextBox3.Tag
            .NPLVEH = KryptonTextBox4.Tag
            .CBRCNT = KryptonTextBox5.Tag

            'If ChkOperacion.Checked = False And ChkOrdenServicio.Checked = False Then
            '    .NOPRCN = 0
            '    .NORSRT = 0
            '    .CLCLOR = 0
            '    .CLCLDS = 0
            'ElseIf ChkOperacion.Checked = True Then
            '    .NOPRCN = IIf(txtCodigo.Text.Trim.Equals(""), 0, txtCodigo.Text.Trim)
            'Else
            '    .NORSRT = IIf(txtCodigo.Text.Trim.Equals(""), 0, txtCodigo.Text.Trim)
            '    '.CLCLOR = Me._CLCLOR
            '    '.CLCLDS = Me._CLCLDS
            'End If
            If cboTipoPedido.SelectedValue = 0 Then
                obeValeCombustible.NOPRCN = 0
                obeValeCombustible.NORSRT = 0
                obeValeCombustible.CLCLOR = 0
                obeValeCombustible.CLCLDS = 0
            ElseIf cboTipoPedido.SelectedValue = 1 Then
                obeValeCombustible.NOPRCN = IIf(txtCodigo.Text.Trim.Equals(""), 0, txtCodigo.Text.Trim)
            ElseIf cboTipoPedido.SelectedValue = 2 Then
                obeValeCombustible.NORSRT = IIf(txtCodigo.Text.Trim.Equals(""), 0, txtCodigo.Text.Trim)
                'obeValeCombustible.CLCLOR = Me._CLCLOR
                'obeValeCombustible.CLCLDS = Me._CLCLDS
            End If
            .TOBSCR = txtObservacion.Text.Trim
            .FULTAC = HelpClass.TodayNumeric
            .HULTAC = HelpClass.NowNumeric
            .CULUSA = MainModule.USUARIO
            .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            .CCMPN = ("" & gwdDatos.CurrentRow.Cells("CCMPN").Value).ToString.Trim
        End With
        Dim rtpa As Decimal = obrValeCombustible.Modificar_Vale_Combustible(obeValeCombustible).NRSCVL
        Select Case rtpa
            Case -1
                'HelpClass.MsgBox("No existe la Orden de Servicio", MessageBoxIcon.Information)
                MessageBox.Show("No existe la Orden de Servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Case -2
                'HelpClass.MsgBox("No existe la Operación", MessageBoxIcon.Information)
                MessageBox.Show("No existe la Operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Case Else
                'HelpClass.ErrorMsgBox()
                'Exit Sub
                MessageBox.Show("Registro  actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
                Me.gEnum_Mantenimiento = Mantenimiento_opc.Neutral
                HabilitarOpc(Mantenimiento_opc.Neutral)
                Me.Listar()
                'Me.AccionCancelar()
        End Select
        'HelpClass.MsgBox("Registro  Actualizado")
        'MessageBox.Show("No existe la Operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        'Me.Listar()
        'Me.AccionCancelar()
        'Catch : End Try
    End Sub

  Private Sub Eliminar_Vale_Combustible()
    Dim obrValeCombustible As New ValeCombustible_BLL
    Dim obeValeCombustible As New ValeCombustible
        'Try
        With obeValeCombustible
            .NRSCVL = CType(Me.txtVale.Text, Double)
            .FULTAC = HelpClass.TodayNumeric
            .HULTAC = HelpClass.NowNumeric
            .CULUSA = MainModule.USUARIO
            .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        End With
        obeValeCombustible.NRSCVL = obrValeCombustible.Eliminar_Vale_Combustible(obeValeCombustible).NRSCVL
        If obeValeCombustible.NRSCVL = -1 Then
            MessageBox.Show("No se puede Eliminar, el Vale Combustible está Asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.gEnum_Mantenimiento = Mantenimiento_opc.Neutral
            HabilitarOpc(Mantenimiento_opc.Neutral)
            Me.Listar()
            'Me.AccionCancelar()

        End If

        'If obeValeCombustible.NRSCVL = 0 Then
        '    HelpClass.ErrorMsgBox()
        'ElseIf obeValeCombustible.NRSCVL = -1 Then
        '    HelpClass.MsgBox("No se puede Eliminar, el Vale Combustible está Asignado")
        'Else
        '    Me.Listar()
        '    Me.AccionCancelar()
        'End If
        'Catch : End Try
    End Sub

    'Private Sub HabilitarOpcionTipoPedido(ByVal NOPRCN As Decimal, ByVal NORSRT As Decimal)
    '    Me.txtCodigo.Text = ""
    '    If NOPRCN = 0 AndAlso NORSRT = 0 Then
    '        cboTipoPedido.SelectedValue = 0
    '        btnBuscarOpcion.Enabled = False
    '        cboTipoPedido.Enabled = True
    '    ElseIf NOPRCN <> 0 Then
    '        cboTipoPedido.SelectedValue = 1
    '        Me.txtCodigo.Text = NOPRCN
    '        btnBuscarOpcion.Enabled = True
    '        cboTipoPedido.Enabled = True
    '    ElseIf NORSRT <> 0 Then
    '        cboTipoPedido.SelectedValue = 2
    '        Me.txtCodigo.Text = NORSRT
    '        btnBuscarOpcion.Enabled = True
    '        cboTipoPedido.Enabled = True
    '    End If
    '    If gEnum_Mantenimiento = Mantenimiento_opc.Neutral Then
    '        cboTipoPedido.Enabled = False
    '        txtCodigo.Enabled = False
    '        btnBuscarOpcion.Enabled = False
    '    End If
    'End Sub

    Private Sub Detalle_Vale_Combustible()
        If Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        KryptonTextBox3.Tag = 0
        KryptonTextBox3.Text = ""


        KryptonTextBox4.Tag = ""
        KryptonTextBox4.Text = ""

        KryptonTextBox5.Tag = 0
        KryptonTextBox5.Text = ""

        'Me.Cursor = Cursors.WaitCursor
        'Me.cmbConductor_1.pClear() 'Me.ctbConductor_1.Limpiar()
        Me.txtCodigo.Text = ""
        With Me.gwdDatos.CurrentRow
            If .Cells("NOPRCN").Value = 0 AndAlso .Cells("NORSRT").Value = 0 Then
                cboTipoPedido.SelectedValue = 0
                txtCodigo.Text = ""
            ElseIf .Cells("NOPRCN").Value <> 0 Then
                cboTipoPedido.SelectedValue = 1
                txtCodigo.Text = .Cells("NOPRCN").Value
            ElseIf .Cells("NORSRT").Value <> 0 Then
                cboTipoPedido.SelectedValue = 2
                txtCodigo.Text = .Cells("NORSRT").Value
            End If
            'HabilitarOpcionTipoPedido(.Cells("NOPRCN").Value, .Cells("NORSRT").Value)
            Me.txtVale.Text = .Cells("NRSCVL").Value
            Me.dtpFecha.Value = .Cells("FECSLC_S").Value
            Me.txtVale.Tag = gwdDatos.CurrentRow.Index
            Me.ctbCentroCosto.Codigo = .Cells("CCNTCS").Value
            Me.ctbTipoCombustible.Codigo = .Cells("CTPCMB").Value
            Me.txtGalonesSolicitado.Text = .Cells("QGLNSL").Value
            'Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
            ''obeTransportista.pCCMPN_Compania = Me.cboCompania.SelectedValue
            'obeTransportista.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            'obeTransportista.pNRUCTR_RucTransportista = .Cells("NRUCTR").Value
            'ctbTransportista_1.pCargar(obeTransportista)
            'Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK


            KryptonTextBox3.Tag = .Cells("NRUCTR").Value
            KryptonTextBox3.Text = .Cells("NRUCTR").Value & " - " & .Cells("TCMTRT").Value


            'obeTracto.pCCMPN_Compania = Me.cboCompania.SelectedValue
            'obeTracto.pCDVSN_Division = Me.cboDivision.SelectedValue
            'obeTracto.pCPLNDV_Planta = Me.cboPlanta.SelectedValue
            'obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            'obeTracto.pCDVSN_Division = cmbDivision.Division
            'obeTracto.pCPLNDV_Planta = cmbPlanta.Planta
            'obeTracto.pNRUCTR_RucTransportista = ctbTransportista_1.pRucTransportista
            'obeTracto.pNPLCUN_NroPlacaUnidad = .Cells("NPLVEH").Value
            'Me.ctbTracto_1.pCargar(obeTracto)

            KryptonTextBox4.Tag = .Cells("NPLVEH").Value
            KryptonTextBox4.Text = .Cells("NPLVEH").Value


            'Me.Cargar_Combo_Conductor(2)

            'Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
            'obeConductor.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            'obeConductor.pNRUCTR_RucTransportista = ctbTransportista_1.pRucTransportista.Trim
            'Me.cmbConductor_1.pCargar(obeConductor)
            'Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
            'obeConductor.pCCMPN_Compania = cboCompania.SelectedValue
            'obeConductor.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            'obeConductor.pNRUCTR_RucTransportista = ctbTransportista_1.pRucTransportista.Trim
            'obeConductor.pCBRCNT_Brevete = .Cells("CBRCNT").Value
            'Me.cmbConductor_1.pCargar(obeConductor)

            KryptonTextBox5.Tag = .Cells("CBRCNT").Value
            KryptonTextBox5.Text = .Cells("CBRCNT").Value & " - " & .Cells("CBRCND").Value


            Me.txtNroLiquidacion.Text = .Cells("NLQCMB").Value
            Me.dtpFechaLiquidacion.Text = .Cells("FLQDCN_S").Value
            Me.txtGalonesAsignados.Text = .Cells("QGLNVL").Value
            Me.txtOperacion.Text = .Cells("NOPRCN").Value
            Me.txtOrdenServicio.Text = .Cells("NORSRT").Value
            Me.txtObservacion.Text = .Cells("TOBSCR").Value
            'Me.txtCodigo.Text = ""
            'If .Cells("NOPRCN").Value = 0 AndAlso .Cells("NORSRT").Value = 0 Then
            '    Me.ChkOperacion.Checked = False
            '    Me.ChkOrdenServicio.Checked = False
            'ElseIf .Cells("NOPRCN").Value <> 0 Then
            '    Me.ChkOperacion.Checked = True
            '    Me.txtCodigo.Text = .Cells("NOPRCN").Value
            'ElseIf .Cells("NORSRT").Value <> 0 Then
            '    Me.ChkOrdenServicio.Checked = True
            'End If


        End With
        'Me.Cursor = Cursors.Default
    End Sub

#End Region

    Private Sub ctbTransportista_ExitFocusWithOutData_InformationChanged() Handles ctbTransportista.ExitFocusWithOutData, ctbTransportista.InformationChanged
        Try
            'cmbConductor.pClear()
            'Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
            'obeConductor.pCCMPN_Compania = cboCompania.SelectedValue
            'obeConductor.pNRUCTR_RucTransportista = ctbTransportista.pRucTransportista.Trim
            'Me.cmbConductor.pCargar(obeConductor)

            ctbTracto.pClear()
            'Me.cboAcoplado.pClear()
            cmbConductor.pClear()
            'Me.cmbSegundoConductor.pClear()
            Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
            'obeTracto.pCCMPN_Compania = cboCompania.SelectedValue
            'obeTracto.pCDVSN_Division = cboDivision.SelectedValue
            'obeTracto.pCPLNDV_Planta = cboPlanta.SelectedValue
            obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            obeTracto.pCDVSN_Division = cmbDivision.Division
            obeTracto.pCPLNDV_Planta = cmbPlanta.Planta
            obeTracto.pNRUCTR_RucTransportista = ctbTransportista.pRucTransportista
            ctbTracto.pCargar(obeTracto)
            Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK


            Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
            'obeConductor.pCCMPN_Compania = cboCompania.SelectedValue
            obeConductor.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
            obeConductor.pCBRCNT_Brevete = ""
            obeConductor.pNRUCTR_RucTransportista = ctbTransportista.pRucTransportista
            cmbConductor.pCargar(obeConductor)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    'Private Sub ctbTransportista_1_ExitFocusWithOutData_InformationChanged() Handles ctbTransportista.ExitFocusWithOutData, ctbTransportista.InformationChanged
    '  cmbConductor_1.pClear()
    '  Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
    '  obeConductor.pCCMPN_Compania = cboCompania.SelectedValue
    '  obeConductor.pNRUCTR_RucTransportista = ctbTransportista.pRucTransportista.Trim
    '  Me.cmbConductor_1.pCargar(obeConductor)
    'End Sub
    'Private Sub ctbTransportista_1_ExitFocusWithOutData_InformationChanged()
    '    Try
    '        'cmbConductor_1.pClear()
    '        'Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
    '        'obeConductor.pCCMPN_Compania = cboCompania.SelectedValue
    '        'obeConductor.pNRUCTR_RucTransportista = ctbTransportista.pRucTransportista.Trim
    '        'Me.cmbConductor_1.pCargar(obeConductor)
    '        'ctbTracto_1()
    '        'cmbConductor_1()
    '        ctbTracto_1.pClear()
    '        'Me.cboAcoplado.pClear()
    '        cmbConductor_1.pClear()
    '        'Me.cmbSegundoConductor.pClear()
    '        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
    '        'obeTracto.pCCMPN_Compania = cboCompania.SelectedValue
    '        'obeTracto.pCDVSN_Division = cboDivision.SelectedValue
    '        'obeTracto.pCPLNDV_Planta = cboPlanta.SelectedValue
    '        obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    '        obeTracto.pCDVSN_Division = cmbDivision.Division
    '        obeTracto.pCPLNDV_Planta = cmbPlanta.Planta
    '        obeTracto.pNRUCTR_RucTransportista = ctbTransportista_1.pRucTransportista
    '        ctbTracto_1.pCargar(obeTracto)
    '        Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK


    '        Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
    '        'obeConductor.pCCMPN_Compania = cboCompania.SelectedValue
    '        obeConductor.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    '        obeConductor.pCBRCNT_Brevete = ""
    '        obeConductor.pNRUCTR_RucTransportista = ctbTransportista_1.pRucTransportista
    '        cmbConductor_1.pCargar(obeConductor)

    '        'obeAcoplado.pCCMPN_Compania = _CCMPN
    '        'obeAcoplado.pCDVSN_Division = _CDVSN
    '        'obeAcoplado.pCPLNDV_Planta = _CPLNDV
    '        'obeAcoplado.pNRUCTR_RucTransportista = Me.cboTransportista.pRucTransportista
    '        'Me.cboAcoplado.pCargar(obeAcoplado)
    '        'Me.Cargar_Combo_Acoplado_Conductor()
    '        'Me.hgReasignarRecurso.ValuesSecondary.Heading = "   "
    '        'If Me.lintMedioTransporte = 4 Then
    '        '    strResultado = Validar_Proveedor_Homologado()
    '        '    'Me.hgReasignarRecurso.ValuesSecondary.Heading = IIf(strResultado.Trim <> "", "Advertencia : " & strResultado, "   ")
    '        'End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub


    'Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    'Private objPlanta As New NEGOCIO.Planta_BLL
    'Private objDivision As New NEGOCIO.Division_BLL

    'Private Sub Cargar_Combo_Acoplado_Conductor(Optional ByVal strConductor As String = "", Optional ByVal strSegundoConductor As String = "")
    '    Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
    '    obeConductor.pCCMPN_Compania = cboCompania.SelectedValue
    '    obeConductor.pCBRCNT_Brevete = strConductor
    '    obeConductor.pNRUCTR_RucTransportista = ctbTransportista_1.pRucTransportista
    '    cmbConductor_1.pCargar(obeConductor)
    '    'obeConductor.pCBRCNT_Brevete = strSegundoConductor
    '    'Me.cmbSegundoConductor.pCargar(obeConductor)
    'End Sub

  
  
    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            Limpiar_Controles()
            gEnum_Mantenimiento = Mantenimiento_opc.Neutral
            HabilitarOpc(Mantenimiento_opc.Neutral)
            Detalle_Vale_Combustible()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub cboTipoPedido_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoPedido.SelectionChangeCommitted
        Try
            If cboTipoPedido.SelectedValue = 0 Then
                btnBuscarOpcion.Enabled = False
                txtCodigo.Text = ""
                'txtCodigo.Enabled = False
                'ctbTransportista_1.Enabled = True
                'ctbTracto_1.Enabled = True
                'cmbConductor_1.Enabled = True
                KryptonButton1.Enabled = True
            ElseIf cboTipoPedido.SelectedValue = 1 Then
                btnBuscarOpcion.Enabled = True
                txtCodigo.Text = ""
                'txtCodigo.Enabled = False
                'ctbTransportista_1.pClear()
                'ctbTracto_1.pClear()
                'cmbConductor_1.pClear()
                'ctbTransportista_1.Enabled = False
                'ctbTracto_1.Enabled = False
                'cmbConductor_1.Enabled = False

                KryptonTextBox3.Tag = 0
                KryptonTextBox3.Text = ""

                KryptonTextBox4.Tag = ""
                KryptonTextBox4.Text = ""

                KryptonTextBox5.Tag = ""
                KryptonTextBox5.Text = ""

                KryptonButton1.Enabled = True

            ElseIf cboTipoPedido.SelectedValue = 2 Then
                btnBuscarOpcion.Enabled = True
                txtCodigo.Text = ""
                'txtCodigo.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'If .Cells("NOPRCN").Value = 0 AndAlso .Cells("NORSRT").Value = 0 Then
        '    cboTipoPedido.SelectedValue = 0
        'ElseIf .Cells("NOPRCN").Value <> 0 Then
        '    cboTipoPedido.SelectedValue = 1
        '    Me.txtCodigo.Text = .Cells("NOPRCN").Value
        'ElseIf .Cells("NORSRT").Value <> 0 Then
        '    cboTipoPedido.SelectedValue = 2
        '    Me.txtCodigo.Text = .Cells("NORSRT").Value
        'End If
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Try
            Dim ofrmAsignarUnidad As New frmAsignarUnidad
            ofrmAsignarUnidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
            ofrmAsignarUnidad.CDVSN = cmbDivision.Division
            ofrmAsignarUnidad.CPLNDV = cmbPlanta.Planta

            If KryptonTextBox4.Tag IsNot Nothing Then
                ofrmAsignarUnidad.PLACA_TRACTO = KryptonTextBox4.Tag
            End If
            If KryptonTextBox5.Tag IsNot Nothing Then
                ofrmAsignarUnidad.BREVTE_CONDUCTOR = KryptonTextBox5.Tag
            End If

            If ofrmAsignarUnidad.ShowDialog = Windows.Forms.DialogResult.OK Then
                KryptonTextBox3.Tag = ofrmAsignarUnidad.RUC_TRANS
                KryptonTextBox3.Text = ofrmAsignarUnidad.RUC_TRANS & " - " & ofrmAsignarUnidad.DES_TRANS

                KryptonTextBox4.Tag = ofrmAsignarUnidad.PLACA_TRACTO
                KryptonTextBox4.Text = ofrmAsignarUnidad.PLACA_TRACTO & " - " & ofrmAsignarUnidad.DESC_TRACTO

                KryptonTextBox5.Tag = ofrmAsignarUnidad.BREVTE_CONDUCTOR
                KryptonTextBox5.Text = ofrmAsignarUnidad.BREVTE_CONDUCTOR & " - " & ofrmAsignarUnidad.DESC_CONDUCTOR



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
  
End Class
