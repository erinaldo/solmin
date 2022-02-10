Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
'Imports SOLMIN_ST.HelpClass
Imports System.Data


Public Class frmOperacionMultiModal

#Region "Atributos"
    Private oSeguridad As Seguridad = New SOLMIN_ST.NEGOCIO.Seguridad(USUARIO)
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private _estado As Integer = 0
    Private objFormBuscarOrdenServicio As frmBuscarOrdenServicio
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private bolBuscar As Boolean = False
    Private Codigo As String = ""
    Private intAccion As Int16 = 0
    Private controlInformacion As New Control_InformacionSolicitud
    Private _TipoOperacion As Int16 = 0
    Private _CTPOVJ As String = "M"
#End Region

#Region "Eventos"

    Private Sub frmOperacionMultiModal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Me.Validar_Acceso_Opciones_Usuario()
            Me.btnGuardar.Enabled = False
            Me.btnCancelar.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.btnSeguimiento.Visible = False
            Me.btnImprimirSeguimiento.Visible = False
            Me.ckbRangoFechas.Checked = False
            Me.gwdDatos.AutoGenerateColumns = False
            Me.gwdSolicitud.AutoGenerateColumns = False
            Me.Estado_Controles(False)
            Me.ddlEstado.SelectedIndex = 0
            Me.ddlEstado.SelectedIndex = 1
            gintEstado = 0
            Me.Cargar_Compania()
            Me.txtClienteFiltro.pUsuario = USUARIO
            Me.txtClienteFiltro.CCMPN = Me.cmbCompania.SelectedValue
            Me.txtClienteMnto.pUsuario = USUARIO
            Me.txtClienteMnto.CCMPN = Me.cmbCompania.SelectedValue
            Me.PanelInformacionSolicitud.Controls.Add(controlInformacion)
            Me.controlInformacion.Dock = DockStyle.Fill
            Me.controlInformacion.TabSolicitudFlete.TabPages.RemoveAt(1)
            Separator7.Visible = False
            Separator9.Visible = False
            Me.tbMultimodal_SelectedIndexChanged(Nothing, Nothing)
        Catch : End Try
    End Sub

    Private Sub tbMultimodal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMultimodal.SelectedIndexChanged
        Select Case Me.tbMultimodal.SelectedIndex
            Case 0
                If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then Exit Sub
                intAccion = 0
                Me.Estado_Accion()
                If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCell Is Nothing Then
                    Me.btnGuardar.Text = "Guardar"
                    Me.btnGuardar.Enabled = False
                    Me.btnEliminar.Enabled = False
                End If
            Case 1
                If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                    Me.tbMultimodal.SelectedIndex = 0
                    Exit Sub
                End If
                intAccion = 1
                Me.Estado_Accion()
                Me.btnGuardar.Text = "Modificar"
                Me.btnGuardar.Enabled = True
                Me.btnEliminar.Enabled = True
            Case 2
                If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                    Me.tbMultimodal.SelectedIndex = 0
                    Exit Sub
                End If
                intAccion = 2

                Me.Estado_Accion()
                Me.btnEliminar.Enabled = True
                Me.btnEliminar.Visible = True
                Me.btnSeguimiento.Visible = False
                Me.btnImprimirSeguimiento.Visible = False
        End Select
    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        Try
            If bolBuscar = True Then
                Cargar_Division()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        Try
            If bolBuscar = True Then
                Cargar_Planta()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        If bolBuscar = True Then
            'Me.Listar()
        End If
    End Sub

    Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged
        Me.dtpFechaInicio.Enabled = ckbRangoFechas.Checked
        Me.dtpFechaFin.Enabled = ckbRangoFechas.Checked
    End Sub

    Private Sub txtNroOperacionMM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroOperacionMM.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub txtNroOperacionMM_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroOperacionMM.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.btnProcesarConsulta_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Listar()
        Me.AccionCancelar()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        btnNuevo.Enabled = False
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEliminar.Enabled = False
        Limpiar_Controles()
        Estado_Controles(True)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Select Case intAccion
            Case 0
                If validar_inputs() = True Then Exit Sub
                If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                    Me.Nuevo_Registro()
                    'btnProcesarConsulta_Click(Nothing, Nothing)
                    '  Me.AccionCancelar()
                    Me.gwdDatos.CurrentCell = Me.gwdDatos.Item(0, 0)
                    Me.gwdDatos.Rows(Me.txtNroRutas.Tag).Selected = True
                    Me.Cargar_Datos_Grilla()
                    Me.btnGuardar.Text = "Modificar"
                    Me.btnGuardar.Enabled = True
                    Me.btnEliminar.Enabled = True
                    Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR

                ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                    If Int32.Parse(Me.txtNroRutas.Text) < Me.gwdSolicitud.RowCount Then
                        HelpClass.MsgBox("Nuevo Nro. Rutas menor al Asignado", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    Me.Modificar_Registro()
                    Me.AccionCancelar()
                ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
                    Me.Estado_Controles(True)
                    Me.btnGuardar.Text = "Guardar"
                    Me.btnNuevo.Enabled = False
                    Me.btnCancelar.Enabled = True
                    Me.btnEliminar.Enabled = False
                    Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
                    If Me.gwdDatos.Item("C_SESTOP", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString = "P" Then Me.txtClienteMnto.Enabled = False
                End If
            Case 1
                If Me.gwdSolicitud.RowCount = 0 OrElse Me.gwdSolicitud.CurrentCellAddress.Y < 0 Then Exit Sub
                If Me.gwdSolicitud.Item("D_SESSLC", Me.gwdSolicitud.CurrentCellAddress.Y).Value = "C" Then
                    HelpClass.MsgBox("La Solicitud se encuentra Cerrada", MessageBoxIcon.Information)
                    Exit Sub
                End If
                Me.panelMultimodal.Visible = False
                Me.PanelFiltros.Enabled = False
                Me.gwdDatos.Enabled = False
                Me._TipoOperacion = 1
                controlInformacion.CCMPN = Me.cmbCompania.SelectedValue
                controlInformacion.pCDVSN = Me.cmbDivision.SelectedValue
                controlInformacion.pCPLNDV = Me.cmbPlanta.SelectedValue
                controlInformacion.NCSOTR_1 = Me.gwdSolicitud.Item("D_NCSOTR", Me.gwdSolicitud.CurrentCellAddress.Y).Value
                controlInformacion.TipoOperacion = Me._TipoOperacion
                controlInformacion.OPCION = 0
                controlInformacion.Actualizar_Datos()
                Me.ActivarEstado_Solicitud(True)
                Me.controlInformacion.dtpFechaSolicitud.Enabled = False
                If Me.gwdSolicitud.Item("D_CANTOP", Me.gwdSolicitud.CurrentCellAddress.Y).Value > 0 Then
                    Me.ActivarEstado_Solicitud(False)
                    Me.controlInformacion.txtCantidadSolicitada.Enabled = True
                    Me.controlInformacion.ctlTipoVehiculo.Enabled = True
                End If
                Me.controlInformacion.txtCliente.Enabled = False
                Me.btnCancelarSolicitud.Text = " Salir"
                Me.panelSolicitudMM.Visible = True
        End Select

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            Me.Estado_Controles(False)
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentCell = Me.gwdDatos.Item(0, Me.txtNroRutas.Tag)
                Me.gwdDatos.Rows(Me.txtNroRutas.Tag).Selected = True
            End If
            gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
            Me.btnGuardar.Enabled = True
            Me.btnEliminar.Enabled = True
            Me.btnNuevo.Enabled = True
            Me.btnCancelar.Enabled = False
            Me.btnGuardar.Text = "Modificar"
            Me.Cargar_Datos_Grilla()
        Else
            Me.AccionCancelar()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Select Case intAccion
            Case 0
                If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
                If Me.gwdDatos.Item("C_SESTOP", Me.gwdDatos.CurrentCellAddress.Y).Value <> "A" Then
                    HelpClass.MsgBox("No se puede eliminar Operación Multimodal en Proceso y/o Cerrada", MessageBoxIcon.Information)
                    Exit Sub
                End If
                If MsgBox("Desea eliminar esta Solicitud de Transporte", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                Me.Eliminar_Operacion_Multimodal("*")
            Case 1
                If Me.gwdSolicitud.RowCount = 0 OrElse Me.gwdSolicitud.CurrentCellAddress.Y < 0 Then Exit Sub
                If Me.gwdSolicitud.Item("D_CANTOP", Me.gwdSolicitud.CurrentCellAddress.Y).Value <> 0 Then
                    HelpClass.MsgBox("La solicitud tiene asignada N° de Operacion")
                    Exit Sub
                End If
                If MsgBox("Desea eliminar esta Solicitud de Transporte", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
                Me.Eliminar_Solicitud("*")
            Case 2

                If (Me.dtgRecursosAsignados.Rows.Count = 0) OrElse Me.dtgRecursosAsignados.CurrentCellAddress.Y < 0 Then Exit Sub
                If Me.dtgRecursosAsignados.Item("NGUITR", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value <> 0 Then
                    HelpClass.MsgBox("Tiene asignada Guía de Transporte", MessageBoxIcon.Information)
                    Exit Sub
                End If
                Try
                    Dim objLogica As New Solicitud_Transporte_BLL
                    Dim objEntidad As New Solicitud_Transporte
                    objEntidad.NCSOTR = Me.dtgRecursosAsignados.Item("NCSOTR", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
                    objEntidad.NCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
                    objEntidad.CULUSA = MainModule.USUARIO
                    objEntidad.FULTAC = HelpClass.TodayNumeric
                    objEntidad.HULTAC = HelpClass.NowNumeric
                    objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
                    Dim lstrList As List(Of String) = objLogica.Anulacion_Operacion_Transporte_Multimodal(objEntidad)
                    HelpClass.MsgBox(lstrList(0), MessageBoxIcon.Information)
                    If lstrList(1).Trim = "1" Or lstrList(1).Trim = "7" Then
                        Me.Cargar_Detalle_Solicitud()
                        Me.Lista_Unidades_Asignadas(Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value)
                        If lstrList(1).Trim = "7" Then
                            Me.gwdDatos.Item("C_SESTOP", Me.gwdDatos.CurrentCellAddress.Y).Value = "A"
                        End If
                    End If
                Catch ex As Exception
                End Try
        End Select
    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        Select Case Me.gEnum_Mantenimiento
            Case MANTENIMIENTO.NUEVO
                If Me.gwdDatos.Rows.Count > 0 Then
                    Me.gwdDatos.CurrentCell = Nothing
                End If
                HelpClass.MsgBox("Debe guardar o cancelar la Operación.", MsgBoxStyle.Exclamation)
                Exit Sub
            Case MANTENIMIENTO.EDITAR
                HelpClass.MsgBox("Debe guardar o cancelar la Operación.", MsgBoxStyle.Exclamation)
                Me.gwdDatos.CurrentCell = Me.gwdDatos.Item(0, Me.txtNroRutas.Tag)
                Me.gwdDatos.Rows(Me.txtNroRutas.Tag).Selected = True
                Exit Sub
        End Select
        Me.btnGuardar.Text = "Modificar"
        Me.btnGuardar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        Me.Cargar_Datos_Grilla()
        Me.Cargar_Detalle_Solicitud()
        Me.Lista_Unidades_Asignadas(Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value)
    End Sub

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentCell = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Up, Keys.Down
                Me.gwdDatos_CellClick(Nothing, Nothing)
        End Select
    End Sub

    Private Sub gwdSolicitud_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdSolicitud.CellContentDoubleClick
        If Me.gwdSolicitud.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
        Select Case Me.gwdSolicitud.Columns(e.ColumnIndex).Name
            Case "D_DETASIG"
                Dim frmAsignacionUnidades As New frmInformacionSolicitud(Me.gwdSolicitud.Item("D_NCSOTR", e.RowIndex).Value)
                With frmAsignacionUnidades
                    .TipoOperacion = 3
                    .Cliente = Me.txtClienteMnto.pCodigo
                    .CCMPN = Me.cmbCompania.SelectedValue
                    .CDVSN = Me.cmbDivision.SelectedValue
                    .CPLNDV = Me.cmbPlanta.SelectedValue
                    .NORSRT = Me.gwdSolicitud.Item("D_NORSRT", e.RowIndex).Value
                    .QSLCIT = Me.gwdSolicitud.Item("D_QSLCIT", e.RowIndex).Value
                    .LocalidadOrigen = Me.gwdSolicitud.Item("D_CLCLOR_C", e.RowIndex).Value
                    .LocalidadDestino = Me.gwdSolicitud.Item("D_CLCLDS_C", e.RowIndex).Value
                    .DireccionOrigen = Me.gwdSolicitud.Item("D_TDRCOR", e.RowIndex).Value
                    .DireccionDestino = Me.gwdSolicitud.Item("D_TDRENT", e.RowIndex).Value
                    .CantidadMercaderia = IIf(Me.gwdSolicitud.Item("D_QMRCDR", e.RowIndex).Value.ToString.Trim.Equals(""), 0, Me.gwdSolicitud.Item("D_QMRCDR", e.RowIndex).Value)
                    .UnidadMedida = Me.gwdSolicitud.Item("D_CUNDMD_C", e.RowIndex).Value
                    .FechaSolicitud = Me.gwdSolicitud.Item("D_FECOST", e.RowIndex).Value
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.Listar()
                    End If
                End With
        End Select
    End Sub

    Private Sub btnAsignarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarSolicitud.Click
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        If Int32.Parse(Me.txtNroRutas.Text) <= Me.gwdSolicitud.RowCount Then
            HelpClass.MsgBox("Nro Solicitud asignada igual al Nro Rutas", MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.panelMultimodal.Visible = False
        Me.PanelFiltros.Enabled = False
        Me.gwdDatos.Enabled = False
        Me.btnCancelarSolicitud.Text = " Cancelar"
        Me._TipoOperacion = 2
        controlInformacion.CCMPN = Me.cmbCompania.SelectedValue
        controlInformacion.pCDVSN = Me.cmbDivision.SelectedValue
        controlInformacion.pCPLNDV = Me.cmbPlanta.SelectedValue
        controlInformacion.TipoOperacion = Me._TipoOperacion
        controlInformacion.OPCION = 0
        Me.Limpiar_Controles_Solicitud()
        Me.ActivarEstado_Solicitud(True)
        controlInformacion.txtCliente.pCargar(Me.gwdDatos.Item("C_CCLNT", Me.gwdDatos.CurrentCellAddress.Y).Value)
        Me.controlInformacion.txtCliente.Enabled = False
        Me.panelSolicitudMM.Visible = True
    End Sub

    Private Sub btnImprimirSeguimiento_click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimirSeguimiento.Click

        Try
            If (Me.gwdDatos.Rows.Count <= 0) Then Exit Sub
            If (Me.gwdDatos.SelectedRows.Count <= 0) Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim ListaParametros As New List(Of String)
            Dim lstr_FecIni As String = ""
            Dim lstr_FecFin As String = ""
            If Me.ckbRangoFechas.Checked = True Then
                lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
                lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
            End If
            ListaParametros.Add(Me.gwdDatos.CurrentRow.Cells("C_NMOPMM").Value)
            If txtClienteFiltro.pCodigo <> 0 Then
                ListaParametros.Add(txtClienteFiltro.pCodigo)
            Else
                ListaParametros.Add("")
            End If
            ListaParametros.Add(Asignar_Valor)
            ListaParametros.Add(lstr_FecIni)
            ListaParametros.Add(lstr_FecFin)
            ListaParametros.Add(Me.cmbCompania.SelectedValue)
            ListaParametros.Add(Me.cmbDivision.SelectedValue)
            ListaParametros.Add(Me.cmbPlanta.SelectedValue)
            ListaParametros.Add("SEG")
            Imprimir2(ListaParametros)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnImprimirMultimodal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirMultimodal.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ListaParametros As New List(Of String)
            Dim lstr_FecIni As String = ""
            Dim lstr_FecFin As String = ""
            If Me.ckbRangoFechas.Checked = True Then
                lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
                lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
            End If
            ListaParametros.Add(Me.txtNroOperacionMM.Text)
            If txtClienteFiltro.pCodigo <> 0 Then
                ListaParametros.Add(txtClienteFiltro.pCodigo)
            Else
                ListaParametros.Add("")
            End If
            ListaParametros.Add(Asignar_Valor)
            ListaParametros.Add(lstr_FecIni)
            ListaParametros.Add(lstr_FecFin)
            ListaParametros.Add(Me.cmbCompania.SelectedValue)
            ListaParametros.Add(Me.cmbDivision.SelectedValue)
            ListaParametros.Add(Me.cmbPlanta.SelectedValue)
            ListaParametros.Add("")
            Imprimir2(ListaParametros)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnAsignarUnidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarUnidad.Click
        Dim intIndice As Int32 = Me.gwdSolicitud.CurrentCellAddress.Y
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdSolicitud.CurrentCellAddress.Y < 0 Then Exit Sub
        If Me.gwdSolicitud.RowCount = 0 OrElse intIndice < 0 Then Exit Sub
        If Me.gwdSolicitud.CurrentRow.Selected = False Then Exit Sub
        If Me.gwdSolicitud.Item("D_QSLCIT", intIndice).Value = Me.gwdSolicitud.Item("D_QATNAN", intIndice).Value Then
            HelpClass.MsgBox("Unidades Asignadas Completas", MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            'Dim frm_frmAsignacionManual As New frmAsignacionManual(False)
            Dim frm_frmAsignacionManual As New frmAsignacionManual()
            With frm_frmAsignacionManual
                .obj_Entidad.NCSOTR = Me.gwdSolicitud.Item("D_NCSOTR", intIndice).Value
                .obj_Entidad.NCRRSR = 1
                .obj_Entidad.NORSRT = Me.gwdSolicitud.Item("D_NORSRT", intIndice).Value
                .obj_Entidad.CCLNT = Me.txtClienteMnto.pCodigo
                .obj_Entidad.CCMPN = Me.cmbCompania.SelectedValue
                .obj_Entidad.CDVSN = Me.cmbDivision.SelectedValue
                .obj_Entidad.CPLNDV = Me.cmbPlanta.SelectedValue
                .CCMPN = .obj_Entidad.CCMPN
                .CDVSN = .obj_Entidad.CDVSN
                .CPLNDV = .obj_Entidad.CPLNDV
                .obj_Entidad.CTPOVJ = Me._CTPOVJ
                .MedioTransporte = Me.gwdSolicitud.Item("CMEDTR", intIndice).Value
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                HelpClass.MsgBox("Se Asignó Satisfactoriamente")
                Me.Lista_Unidades_Asignadas(Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value)
                Me.Cargar_Detalle_Solicitud()
                Me.gwdDatos.Item("C_SESTOP", Me.gwdDatos.CurrentCellAddress.Y).Value = "P"
            End With
        Catch : End Try
    End Sub

    Private Sub dtgRecursosAsignados_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgRecursosAsignados.CellContentClick
        Try
            If Me.dtgRecursosAsignados.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
            If Me.dtgRecursosAsignados.CurrentRow.Selected = False Then Exit Sub
            Select Case Me.dtgRecursosAsignados.Columns(e.ColumnIndex).Name
                Case "SEGUIMIENTO"
                    Dim NPLCUN As String = dtgRecursosAsignados.Item("NPLCUN", dtgRecursosAsignados.CurrentCellAddress.Y).Value.ToString.Trim()
                    Dim strExiste As String = Me.dtgRecursosAsignados.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Trim()
                    If strExiste = vbNullString Then Exit Sub
                    Dim f As New frmRegistroWAP(NPLCUN)
                    f.CCMPN = Me.cmbCompania.SelectedValue
                    f.ShowForm(Me)
            End Select
        Catch : End Try
    End Sub

    Private Sub dtgRecursosAsignados_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgRecursosAsignados.CellContentDoubleClick
        Try
            If Me.dtgRecursosAsignados.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
            If Me.dtgRecursosAsignados.CurrentRow.Selected = False Then Exit Sub
            Dim hash As New Hashtable()
            hash("CCMPN") = Me.cmbCompania.SelectedValue.ToString()
            Select Case Me.dtgRecursosAsignados.Columns(e.ColumnIndex).Name
                Case "UBICACION"
                    If Me.dtgRecursosAsignados.Item("GPSLON", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value.ToString <> "" Then
                        Dim objGpsBrowser As New frmMapa
                        With objGpsBrowser
                            .Latitud = Me.dtgRecursosAsignados.Item("GPSLAT", e.RowIndex).Value
                            .Longitud = Me.dtgRecursosAsignados.Item("GPSLON", e.RowIndex).Value
                            .Fecha = Me.dtgRecursosAsignados.Item("FECGPS", e.RowIndex).Value
                            .Hora = Me.dtgRecursosAsignados.Item("HORGPS", e.RowIndex).Value.ToString.Trim
                            .WindowState = FormWindowState.Maximized
                            .ShowForm(.Latitud, .Longitud, Me)
                        End With
                    End If
                Case "MODIFICAR"
                    Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
                    Dim obj_Entidad As New Detalle_Solicitud_Transporte
                    Dim obj_LogicaDetalleSolcitud As New Detalle_Solicitud_Transporte_BLL
                    Dim lstr_Estado As String = ""
                    obj_Entidad.NCSOTR = Me.dtgRecursosAsignados.Item(2, lint_indice).Value
                    obj_Entidad.NCRRSR = Me.dtgRecursosAsignados.Item(3, lint_indice).Value
                    obj_Entidad.NPLNJT = Me.dtgRecursosAsignados.Item(4, lint_indice).Value
                    obj_Entidad.NCRRPL = Me.dtgRecursosAsignados.Item(5, lint_indice).Value
                    obj_Entidad = obj_LogicaDetalleSolcitud.Validar_Existencias_PAG(obj_Entidad)
                    If obj_Entidad.NGUITR <> "0" Then
                        lstr_Estado += Chr(13) + " GUIA TRANSPORTISTA         :" + obj_Entidad.NGUITR
                        If obj_Entidad.NCTAVC <> "0" Then lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 1         :" + obj_Entidad.NCTAVC
                        If obj_Entidad.NCSLPE <> "0" Then lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 1 :" + obj_Entidad.NCSLPE
                        If obj_Entidad.NCTAV2 <> "0" Then lstr_Estado += Chr(13) + " AVC CONDUCTOR N° 2         :" + obj_Entidad.NCTAV2
                        If obj_Entidad.NCSLP2 <> "0" Then lstr_Estado += Chr(13) + " P. EFECTIVO CONDUCTOR N° 2 :" + obj_Entidad.NCSLP2
                        lstr_Estado = "NO SE PUEDE MODIFICAR POR QUE TIENE ASIGNADO : " + Chr(13) + lstr_Estado
                        HelpClass.MsgBox(lstr_Estado)
                        Exit Sub
                    End If
                    obj_Entidad.NRUCTR = Me.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
                    obj_Entidad.NPLCUN = Me.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value
                    obj_Entidad.NPLCAC = Me.dtgRecursosAsignados.Item("NPLCAC", lint_indice).Value
                    obj_Entidad.CBRCNT = Me.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value
                    obj_Entidad.CBRCN2 = Me.dtgRecursosAsignados.Item("CBRCN2", lint_indice).Value
                    Dim frmReasignarRecurso As New frmReasignarRecurso
                    frmReasignarRecurso.IsMdiContainer = True
                    With frmReasignarRecurso
                        ._obj_Entidad = obj_Entidad
                        .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                        .CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
                        .CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
                        If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
                        Me.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value = .ctbTracto.pNroPlacaUnidad
                        Me.dtgRecursosAsignados.Item("NPLCAC", lint_indice).Value = .ctbAcoplado.pNroAcoplado
                        Me.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value = .cmbConductor.pBrevete
                        Me.dtgRecursosAsignados.Item("CBRCND", lint_indice).Value = .cmbConductor.pNombreChofer
                        Me.dtgRecursosAsignados.Item("CBRCN2", lint_indice).Value = .cmbSegundoConductor.pBrevete
                    End With
                Case "NPLCUN"
                    Informacion_Detallada_Transportista(1, Me.dtgRecursosAsignados.Item(e.ColumnIndex, e.RowIndex).Value, hash)
                Case "NPLCAC"
                    Informacion_Detallada_Transportista(2, Me.dtgRecursosAsignados.Item(e.ColumnIndex, e.RowIndex).Value, hash)
                Case "CBRCNT"
                    Informacion_Detallada_Transportista(3, Me.dtgRecursosAsignados.Item(e.ColumnIndex, e.RowIndex).Value, hash)
            End Select
        Catch : End Try
    End Sub

    Private Sub btnGuiaTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuiaTransporte.Click
        Dim lint_indice As Integer = Me.dtgRecursosAsignados.CurrentCellAddress.Y
        '
        If Me.dtgRecursosAsignados.RowCount = 0 OrElse lint_indice < 0 Then Exit Sub
        If Me.dtgRecursosAsignados.CurrentRow.Selected = False Then Exit Sub
        If Me.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value = 0 Then
            HelpClass.MsgBox("No tiene una Operación asignada")
            Exit Sub
        End If
        If Me.dtgRecursosAsignados.Item("NGUITR", lint_indice).Value <> 0 Then
            HelpClass.MsgBox("Ya tiene asignada una Guía de Transporte")
            Exit Sub
        End If

        Dim frm_GuiaTransportista As New frmGuiaTransportista

        'Dim ObjetoServicio_Entidad_Guia As New GuiaTransportista
        'Dim objEntidadSolicitud As New Solicitud_Transporte
        'Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        'objEntidadSolicitud.NCSOTR = Me.dtgRecursosAsignados.Item("NCSOTR_1", lint_indice).Value
        'objEntidadSolicitud.CCMPN = Me.cmbCompania.SelectedValue.ToString.Trim
        'objEntidadSolicitud = objSolicitudTransporte.Obtener_Solicitud_Transporte(objEntidadSolicitud)

        'With ObjetoServicio_Entidad_Guia
        '    .CLCLOR = objEntidadSolicitud.CLCLOR
        '    .CLCLDS = objEntidadSolicitud.CLCLDS
        '    .TDIROR = objEntidadSolicitud.TDRCOR
        '    .TDIRDS = objEntidadSolicitud.TDRENT
        '    .QMRCMC = objEntidadSolicitud.QMRCDR
        '    .CUNDMD = objEntidadSolicitud.CUNDMD
        '    .NRUCTR = Me.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
        '    .NPLCTR = Me.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value
        '    .NPLCAC = Me.dtgRecursosAsignados.Item("NPLCAC", lint_indice).Value
        '    .CBRCNT = Me.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value
        '    .CBRCND = Me.dtgRecursosAsignados.Item("CBRCND", lint_indice).Value
        '    .CMEDTR = objEntidadSolicitud.CMEDTR
        '    .NMOPMM = Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value
        '    .CTPOVJ = Me._CTPOVJ

        '    Dim obj_Logica_Guia As New GuiaTransportista_BLL
        '    Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
        '    obj_Entidad_Guia_Transporte.NOPRCN = Me.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value
        '    obj_Entidad_Guia_Transporte.CCMPN = Me.cmbCompania.SelectedValue
        '    obj_Entidad_Guia_Transporte.NPLCTR = .NPLCTR
        '    obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)

        '    .CMNFLT = obj_Entidad_Guia_Transporte.CMNFLT
        '    .QKMREC = obj_Entidad_Guia_Transporte.QKMREC
        '    .TNMBRM = obj_Entidad_Guia_Transporte.TNMBRM
        '    .TDRCRM = obj_Entidad_Guia_Transporte.TDRCRM
        '    .TPDCIR = obj_Entidad_Guia_Transporte.TPDCIR
        '    .NRUCRM = obj_Entidad_Guia_Transporte.NRUCRM
        '    .TNMBCN = obj_Entidad_Guia_Transporte.TNMBCN
        '    .TDRCNS = .TDIRDS
        '    .TPDCIC = obj_Entidad_Guia_Transporte.TPDCIR
        '    .NRUCCN = obj_Entidad_Guia_Transporte.NRUCCN
        '    .TCNFVH = obj_Entidad_Guia_Transporte.TCNFVH
        '    .CCLNT = obj_Entidad_Guia_Transporte.CCLNT
        '    .CCMPN = Me.cmbCompania.SelectedValue
        '    .CDVSN = Me.cmbDivision.SelectedValue
        '    .CPLNDV = Me.cmbPlanta.SelectedValue
        'End With

        With frm_GuiaTransportista
            .IsMdiContainer = True
            .AutoSize = True
            Dim Comp_Guia As New CTL_GUIA_DE_TRANSPORTISTA.frmGuiaTransportista

            With Comp_Guia
                .ESTADO = False
                .Dock = DockStyle.Fill
                .Tag = 0
                '---------------------------------------
                .pCOMPANIA = Me.cmbCompania.SelectedValue.ToString.Trim
                .pDIVISION = Me.cmbDivision.SelectedValue
                .pPLANTA = Me.cmbPlanta.SelectedValue

                .pNOPRCN = Me.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value
                .pUSUARIO = MainModule.USUARIO
                '.Guia_Transporte = ObjetoServicio_Entidad_Guia
                '.MedioTransporte = ObjetoServicio_Entidad_Guia.CMEDTR
                .TipoViaje = Me._CTPOVJ
                '.objTable = Operacion_Guia_Transporte()
                .pNMVJCS = Me._CTPOVJ
                .pNMOPMM = Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value
                .pNCSOTR = Me.dtgRecursosAsignados.Item("NCSOTR_1", lint_indice).Value
                .pNCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR_1", lint_indice).Value
                '---------------------------------------
                .ChargeForm()
            End With
            .txtNombreFormulario.Text = "  NUEVA GUIA DE TRANSPORTE "
            .panelGuia.Controls.Add(Comp_Guia)
            .ShowDialog()

            'If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
            '    If Comp_Guia.Guia_Transporte.NGUIRM <> -1 Then
            '        Dim NCOREG As String = ""
            '        Dim obeSeguimientoGPS As New ENTIDADES.SeguimientoGPS
            '        obeSeguimientoGPS.NPLCTR = Me.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value
            '        obeSeguimientoGPS.NCSOTR = HelpClass.ObjectToDecimal(Me.dtgRecursosAsignados.Item("NCSOTR_1", lint_indice).Value)
            '        obeSeguimientoGPS.CCMPN = Me.cmbCompania.SelectedValue
            '        obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(Me.dtgRecursosAsignados.Item("NCRRSR", lint_indice).Value)
            '        obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(Me.dtgRecursosAsignados.Item("NGSGWP", lint_indice).Value)
            '        obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(Me.dtgRecursosAsignados.Item("NCOREG", lint_indice).Value)
            '        Dim ofrmGPSWAP As New frmGPSWAP()
            '        ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
            '        ofrmGPSWAP.Estado = 1
            '        ofrmGPSWAP.ShowDialog(Me)
            '        Lista_Unidades_Asignadas(Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value)
            '    End If
            'End If


        End With

        '================================================================================
        'Dim frm_frmServicioAlmacen As New frmServicioAlmacen
        'frm_frmServicioAlmacen.IsMdiContainer = True
        'Try
        '    With frm_frmServicioAlmacen
        '        .Tag = Me.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
        '        ._NOPRCN = Me.dtgRecursosAsignados.Item("NOPRCN", lint_indice).Value
        '        ._NCSOTR = Me.dtgRecursosAsignados.Item("NCSOTR_1", lint_indice).Value
        '        ._NCRRSR = Me.dtgRecursosAsignados.Item("NCRRSR", lint_indice).Value
        '        ._NPLNJT = Me.dtgRecursosAsignados.Item("NPLNJT", lint_indice).Value
        '        ._NCRRPL = Me.dtgRecursosAsignados.Item("NCRRPL", lint_indice).Value
        '        ._CCMPN = Me.cmbCompania.SelectedValue

        '        Dim objEntidadSolicitud As New Solicitud_Transporte
        '        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        '        objEntidadSolicitud.NCSOTR = Me.dtgRecursosAsignados.Item("NCSOTR_1", lint_indice).Value
        '        objEntidadSolicitud.CCMPN = Me.cmbCompania.SelectedValue.ToString.Trim
        '        objEntidadSolicitud = objSolicitudTransporte.Obtener_Solicitud_Transporte(objEntidadSolicitud)
        '        .txtFechaSolicitud.Text = HelpClass.CNumero_a_Fecha(objEntidadSolicitud.FECOST)
        '        .txtFechaAsignacion.Text = Me.dtgRecursosAsignados.Item("FASGTR", lint_indice).Value
        '        .ObjetoServicio_Entidad_Guia.CLCLOR = objEntidadSolicitud.CLCLOR
        '        .ObjetoServicio_Entidad_Guia.CLCLDS = objEntidadSolicitud.CLCLDS
        '        .ObjetoServicio_Entidad_Guia.TDIROR = objEntidadSolicitud.TDRCOR
        '        .ObjetoServicio_Entidad_Guia.TDIRDS = objEntidadSolicitud.TDRENT
        '        .ObjetoServicio_Entidad_Guia.QMRCMC = objEntidadSolicitud.QMRCDR
        '        .ObjetoServicio_Entidad_Guia.CUNDMD = objEntidadSolicitud.CUNDMD
        '        .ObjetoServicio_Entidad_Guia.NRUCTR = Me.dtgRecursosAsignados.Item("NRUCTR", lint_indice).Value
        '        .ObjetoServicio_Entidad_Guia.NPLCTR = Me.dtgRecursosAsignados.Item("NPLCUN", lint_indice).Value
        '        .ObjetoServicio_Entidad_Guia.NPLCAC = Me.dtgRecursosAsignados.Item("NPLCAC", lint_indice).Value
        '        .ObjetoServicio_Entidad_Guia.CBRCNT = Me.dtgRecursosAsignados.Item("CBRCNT", lint_indice).Value
        '        .ObjetoServicio_Entidad_Guia.CBRCND = Me.dtgRecursosAsignados.Item("CBRCND", lint_indice).Value

        '        Dim obj_Logica_Guia As New GuiaTransportista_BLL
        '        Dim obj_Entidad_Guia_Transporte As New GuiaTransportista
        '        obj_Entidad_Guia_Transporte.NOPRCN = ._NOPRCN
        '        obj_Entidad_Guia_Transporte.CCMPN = Me.cmbCompania.SelectedValue
        '        obj_Entidad_Guia_Transporte.NPLCTR = .ObjetoServicio_Entidad_Guia.NPLCTR?
        '        obj_Entidad_Guia_Transporte = obj_Logica_Guia.Obtener_Informacion_Orden_Servicio(obj_Entidad_Guia_Transporte)

        '        .ObjetoServicio_Entidad_Guia.CMNFLT = obj_Entidad_Guia_Transporte.CMNFLT
        '        .ObjetoServicio_Entidad_Guia.QKMREC = obj_Entidad_Guia_Transporte.QKMREC
        '        .ObjetoServicio_Entidad_Guia.TNMBRM = obj_Entidad_Guia_Transporte.TNMBRM?
        '        .ObjetoServicio_Entidad_Guia.TDRCRM = obj_Entidad_Guia_Transporte.TDRCRM
        '        .ObjetoServicio_Entidad_Guia.TPDCIR = obj_Entidad_Guia_Transporte.TPDCIR
        '        .ObjetoServicio_Entidad_Guia.NRUCRM = obj_Entidad_Guia_Transporte.NRUCRM
        '        .ObjetoServicio_Entidad_Guia.TNMBCN = obj_Entidad_Guia_Transporte.TNMBCN
        '        .ObjetoServicio_Entidad_Guia.TDRCNS = .ObjetoServicio_Entidad_Guia.TDIRDS
        '        .ObjetoServicio_Entidad_Guia.TPDCIC = obj_Entidad_Guia_Transporte.TPDCIR
        '        .ObjetoServicio_Entidad_Guia.NRUCCN = obj_Entidad_Guia_Transporte.NRUCCN
        '        .ObjetoServicio_Entidad_Guia.TCNFVH = obj_Entidad_Guia_Transporte.TCNFVH
        '        .ObjetoServicio_Entidad_Guia.CCLNT = obj_Entidad_Guia_Transporte.CCLNT
        '        .ObjetoServicio_Entidad_Guia.CCMPN = Me.cmbCompania.SelectedValue
        '        .ObjetoServicio_Entidad_Guia.CDVSN = Me.cmbDivision.SelectedValue
        '        .ObjetoServicio_Entidad_Guia.CPLNDV = Me.cmbPlanta.SelectedValue

        '================================================================================
        '    End With
        'Catch : End Try
    End Sub

    Private Sub btnCancelarSolicitud_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelarSolicitud.Click
        Me.panelSolicitudMM.Visible = False
        Me.panelMultimodal.Visible = True
        Me.PanelFiltros.Enabled = True
        Me.gwdDatos.Enabled = True
    End Sub

    Private Sub btnGuardarSolicitud_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardarSolicitud.Click
        Select Case _TipoOperacion
            Case 0, 1
                If Not Me.Validar_Input_Solicitud Then
                    'If Me.gwdSolicitud.Item("D_QSLCIT", Me.gwdSolicitud.CurrentCellAddress.Y).Value > CType(Me.controlInformacion.txtCantidadSolicitada.Text, Int32) And Me.gwdSolicitud.Item("D_CANTOP", Me.gwdSolicitud.CurrentCellAddress.Y).Value > 0 Then
                    '  HelpClass.MsgBox("Cantidad de Unidades Solicitadas menor a la nueva Cantidad Asignada", MessageBoxIcon.Information)
                    '  Exit Sub
                    'End If
                    Me.Modificar_Registro_Solicitud()
                End If
            Case 2, 4
                If Not Me.Validar_Input_Solicitud Then
                    Me.Nuevo_Registro_Solicitud()
                End If
        End Select
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        '----------------------------------------------------------------------
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 OrElse Me.gwdSolicitud.RowCount = 0 OrElse Me.dtgRecursosAsignados.RowCount = 0 Then Exit Sub
        Dim objOperacionMultimodal As New Multimodal_BLL
        Dim objDs As New DataSet
        Dim paramMultimodal As New Hashtable
        paramMultimodal.Add("NMOPMM", Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value)
        paramMultimodal.Add("CCMPN", cmbCompania.SelectedValue)
        paramMultimodal.Add("CDVSN", cmbDivision.SelectedValue)
        paramMultimodal.Add("CPLNDV", cmbPlanta.SelectedValue)
        objDs = objOperacionMultimodal.Listar_Reporte_Bulto(paramMultimodal)
        '-----------------------------------------------------
        If objDs.Tables.Count = 0 OrElse objDs Is Nothing Then Exit Sub

        Dim ListDt As New List(Of DataTable)
        Dim odtReporte As New DataTable
        Dim odtRepResumen As New DataTable
        odtReporte = objDs.Tables(0).Copy
        odtRepResumen = objDs.Tables(1).Copy
        odtReporte.TableName = "BULTO"
        odtRepResumen.TableName = "RESUMEN"

        '---------Se cambia el nombre de la Cabecera----------
        odtReporte.Columns(0).ColumnName = "NRO SOLICITUD"
        odtReporte.Columns(1).ColumnName = "ORDEN SERVICIO"
        odtReporte.Columns(2).ColumnName = "MEDIO TRANSPORTE"
        odtReporte.Columns(3).ColumnName = "CÓDIGO"
        odtReporte.Columns(4).ColumnName = "CLIENTE"
        odtReporte.Columns(5).ColumnName = "RUC"
        odtReporte.Columns(6).ColumnName = "DIRECCIÓN"
        odtReporte.Columns(7).ColumnName = "OBSERVACION"
        odtReporte.Columns(8).ColumnName = "RUTA"
        odtReporte.Columns(9).ColumnName = "NRO OPERACIÓN"
        odtReporte.Columns(10).ColumnName = "GUIA TRANSPORTE"
        odtReporte.Columns(11).ColumnName = "GUIA REMISIÓN"
        odtReporte.Columns(12).ColumnName = "FECHA SALIDA"
        odtReporte.Columns(13).ColumnName = "FECHA LLEGADA"
        odtReporte.Columns(14).ColumnName = "BULTO"
        odtReporte.Columns(15).ColumnName = "ORDEN DE COMPRA"
        odtReporte.Columns(16).ColumnName = "DESCRIPCIÓN ITEM"
        odtReporte.Columns(17).ColumnName = "CANTIDAD"
        odtReporte.Columns(18).ColumnName = "TIPO"
        odtReporte.Columns(19).ColumnName = "PESO"
        odtReporte.Columns(20).ColumnName = "UNID. PESO"
        odtReporte.Columns(21).ColumnName = "VOLUMEN"
        odtReporte.Columns(22).ColumnName = "UNID. VOLUMEN"
        odtReporte.Columns(23).ColumnName = "MEDIO SUGERIDO"
        odtReporte.Columns(24).ColumnName = "MEDIO CONFIRMADO"
        odtReporte.Columns(25).ColumnName = "CUENTA DE IMPUTACIÓN"
        odtReporte.Columns(26).ColumnName = "MONTO ASIGNADO"
        '------------------------------------------------------
        'Dim filaNueva As DataRow
        'For i As Integer = 0 To 25
        '    filaNueva = odtReporte.NewRow()
        '    For j As Integer = 0 To odtReporte.Columns.Count - 1
        '        filaNueva(j) = "Dato :" & i & " - " & j
        '    Next
        '    odtReporte.Rows.Add(filaNueva)
        '    If i = 4 Or i = 2 Or i = 7 Then
        '        filaNueva = odtReporte.NewRow()
        '        For j As Integer = 0 To odtReporte.Columns.Count - 1
        '            filaNueva(j) = "Dato :" & i & " - " & j
        '        Next
        '        odtReporte.Rows.Add(filaNueva)
        '    End If
        '    If i = 4 Or i = 7 Then
        '        filaNueva = odtReporte.NewRow()
        '        For j As Integer = 0 To odtReporte.Columns.Count - 1
        '            filaNueva(j) = "Dato :" & i & " - " & j
        '        Next
        '        odtReporte.Rows.Add(filaNueva)
        '    End If
        '    If i = 14 Then
        '        For h As Integer = 0 To 5
        '            filaNueva = odtReporte.NewRow()
        '            For j As Integer = 0 To odtReporte.Columns.Count - 1
        '                filaNueva(j) = "Dato :" & i & " - " & j
        '            Next
        '            odtReporte.Rows.Add(filaNueva)
        '        Next
        '    End If
        '    If i = 18 Then
        '        filaNueva = odtReporte.NewRow()
        '        For j As Integer = 0 To odtReporte.Columns.Count - 1
        '            filaNueva(j) = "Dato :" & i & " - " & j
        '        Next
        '        odtReporte.Rows.Add(filaNueva)
        '    End If
        'Next
        'Luego de obtener el datatable hacer los quiebres
        Dim itemp As Integer = 0
        Dim iCambia As Boolean = True
        For i As Integer = 0 To odtReporte.Rows.Count - 1
            If iCambia = True Then
                itemp = i - 1
            End If
            If i > 0 Then
                If odtReporte.Rows(i).Item("NRO OPERACIÓN") = odtReporte.Rows(itemp).Item("NRO OPERACIÓN") Then
                    odtReporte.Rows(i).Item("NRO OPERACIÓN") = ""
                    odtReporte.Rows(i).Item("NRO SOLICITUD") = ""
                    odtReporte.Rows(i).Item("ORDEN SERVICIO") = ""
                    odtReporte.Rows(i).Item("MEDIO TRANSPORTE") = ""
                    odtReporte.Rows(i).Item("CÓDIGO") = ""
                    odtReporte.Rows(i).Item("CLIENTE") = ""
                    odtReporte.Rows(i).Item("RUC") = ""
                    odtReporte.Rows(i).Item("DIRECCIÓN") = ""
                    odtReporte.Rows(i).Item("OBSERVACION") = ""
                    odtReporte.Rows(i).Item("RUTA") = ""

                    'ADICIONALMENTE PODEMOS SUMAR LOS i's + 1 CON LOS itemp PARA AL FINAL CREAR EL ROW TOTAL
                    iCambia = False
                Else
                    iCambia = True
                End If
            End If
        Next
        '---------Filtro Cabecera--------------
        Dim Hashfiltro As New Hashtable
        Hashfiltro.Add("COMPAÑIA", cmbCompania.Text)
        Hashfiltro.Add("DIVISION", cmbDivision.Text)
        Hashfiltro.Add("PLANTA", cmbPlanta.Text)

        ListDt.Add(odtReporte)
        ListDt.Add(odtRepResumen)
        Ransa.Utilitario.HelpClass.ExportExcel(ListDt, odtReporte.TableName.ToString, Hashfiltro)
        odtReporte.Dispose()
        odtReporte.Clear()
        ListDt.Clear()

    End Sub

#End Region

#Region "Metodos y Funciones"

    Private Sub Cargar_Compania()
        Try
            objCompaniaBLL.Crea_Lista()
            bolBuscar = False
            cmbCompania.DataSource = objCompaniaBLL.Lista
            cmbCompania.ValueMember = "CCMPN"
            cmbCompania.DisplayMember = "TCMPCM"
            bolBuscar = True
            'cmbCompania.SelectedValue = "EZ"
            ''cmbCompania.SelectedIndex = 0
            'If cmbCompania.SelectedIndex = -1 Then
            '    cmbCompania.SelectedIndex = 0
            'End If

            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            cmbCompania_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cargar_Division()
        Try
            If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
                objDivision.Crea_Lista()
                bolBuscar = False
                cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
                cmbDivision.ValueMember = "CDVSN"
                bolBuscar = True
                cmbDivision.DisplayMember = "TCMPDV"
                Me.cmbDivision.SelectedValue = "T"
                If Me.cmbDivision.SelectedIndex = -1 Then
                    Me.cmbDivision.SelectedIndex = 0
                End If
                cmbDivision_SelectedIndexChanged(Nothing, Nothing)
            End If

        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Planta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try
            If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then

                bolBuscar = False
                objPlanta.Crea_Lista()
                objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                cmbPlanta.DataSource = objLisEntidad
                cmbPlanta.ValueMember = "CPLNDV"
                cmbPlanta.DisplayMember = "TPLNTA"
                bolBuscar = True
                Me.cmbPlanta.SelectedIndex = 0
                cmbPlanta_SelectedIndexChanged(Nothing, Nothing)
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Estado_Accion()
        Me.btnNuevo.Visible = IIf(intAccion = 0, True, False)
        Me.btnGuardar.Visible = IIf(intAccion = 0, True, IIf(intAccion = 1, True, False))
        Me.btnCancelar.Visible = IIf(intAccion = 0, True, False)
        Me.btnEliminar.Visible = IIf(intAccion = 0, True, IIf(intAccion = 1, True, False))
        Me.btnExportarExcel.Visible = IIf(intAccion = 0, True, False)
        Me.btnReporteBulto.Visible = IIf(intAccion = 0, True, False)
        Me.btnAsignarSolicitud.Visible = IIf(intAccion = 1, True, False)
        Me.btnAsignarUnidad.Visible = IIf(intAccion = 1, True, False)
        Me.btnGuiaTransporte.Visible = IIf(intAccion = 2, True, False)
        Me.btnSeguimiento.Visible = IIf(intAccion = 2, True, False)
        Me.btnImprimirSeguimiento.Visible = IIf(intAccion = 2, True, False)

        Me.Separator10.Visible = IIf(intAccion = 0, True, False)

        Me.Separator1.Visible = IIf(intAccion = 0, True, False)
        Me.Separator2.Visible = IIf(intAccion = 0, True, IIf(intAccion = 1, True, False))
        Me.Separator3.Visible = IIf(intAccion = 0, True, False)
        Me.Separator4.Visible = IIf(intAccion = 0, True, IIf(intAccion = 1, True, False))
        Me.Separator5.Visible = IIf(intAccion = 1 OrElse intAccion = 2, True, False)

        Me.Separator7.Visible = False
        Me.Separator9.Visible = False


    End Sub

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtClienteMnto.Enabled = lbool_Estado
        Me.txtNroRutas.Enabled = lbool_Estado
        Me.txtObservaciones.Enabled = lbool_Estado
    End Sub

    Private Sub Limpiar_Controles()
        If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentCell = Nothing
        End If
        Me.txtClienteMnto.pClear()
        Me.dtpFechaMultimodal.Value = Date.Today
        Me.txtNroRutas.Clear()
        Me.txtObservaciones.Clear()
    End Sub

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
        End If
        If objEntidad.STSADI = "" And objEntidad.STSCHG = "" Then
            Me.btnCancelar.Visible = False
            Me.Separator3.Visible = False
        End If
        If objEntidad.STSELI = "" Then
            Me.btnEliminar.Visible = False
            Me.Separator4.Visible = False
        End If
    End Sub

    Private Function Asignar_Valor() As String
        Dim cadena As String = ""
        If Me.ddlEstado.SelectedIndex = 0 Then
            cadena = ""
        ElseIf Me.ddlEstado.SelectedIndex = 1 Then
            cadena = "A"
        ElseIf Me.ddlEstado.SelectedIndex = 2 Then
            cadena = "C"
        End If
        Return cadena
    End Function

    Private Sub Listar()
        Dim objOperacionMultimodal As New Multimodal_BLL

        Dim objParamList As New List(Of String)
        Dim lstr_FecIni As String = ""
        Dim lstr_FecFin As String = ""
        If Me.ckbRangoFechas.Checked = True Then
            lstr_FecIni = HelpClass.CtypeDate(Me.dtpFechaInicio.Value)
            lstr_FecFin = HelpClass.CtypeDate(Me.dtpFechaFin.Value)
        End If
        objParamList.Add(Me.txtNroOperacionMM.Text)
        If txtClienteFiltro.pCodigo <> 0 Then
            objParamList.Add(txtClienteFiltro.pCodigo)
        Else
            objParamList.Add("")
        End If
        objParamList.Add(Asignar_Valor)
        objParamList.Add(lstr_FecIni)
        objParamList.Add(lstr_FecFin)
        'nuevo Compania division y planta
        objParamList.Add(Me.cmbCompania.SelectedValue)
        objParamList.Add(Me.cmbDivision.SelectedValue)
        objParamList.Add(Me.cmbPlanta.SelectedValue)
        Me.gwdDatos.DataSource = objOperacionMultimodal.Listar_Operaciones_Multimodal(objParamList)
        'Me.Limpiar_Controles()
        Me.AccionCancelar()
    End Sub

    Private Sub AccionCancelar()
        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        Me.Limpiar_Controles()
        Me.Estado_Controles(False)
        If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentCell = Nothing
        End If
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnNuevo.Enabled = True
        Me.gwdSolicitud.DataSource = Nothing
        Me.dtgRecursosAsignados.Rows.Clear()
    End Sub

    Private Function validar_inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If txtClienteMnto.pCodigo = 0 Then
                lstr_validacion = "* CODIGO DE CLIENTE " & Chr(13)
            End If
        End If
        If txtNroRutas.Text = "" Then
            lstr_validacion += "* NUMERO DE RUTAS" & Chr(13)
        End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    Private Sub Cargar_Datos_Grilla()
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        If Me.gwdDatos.RowCount = 0 OrElse lint_indice < 0 Then Exit Sub
        If Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
        Dim objEntidad As New Multimodal
        Dim objOperacionMultimodal As New Multimodal_BLL
        objEntidad.CCLNT = Me.gwdDatos.Item("C_CCLNT", lint_indice).Value.ToString().Trim()
        txtClienteMnto.pCargar(objEntidad.CCLNT)
        Me.txtNroRutas.Text = Me.gwdDatos.Item("C_NRORTA", lint_indice).Value.ToString().Trim()
        Me.txtObservaciones.Text = Me.gwdDatos.Item("C_TOBRCP", lint_indice).Value.ToString().Trim()
        Codigo = Me.gwdDatos.Item("C_NMOPMM", lint_indice).Value.ToString().Trim()
        Me.dtpFechaMultimodal.Text = Me.gwdDatos.Item("C_FCOPMM_S", lint_indice).Value.ToString().Trim()
        Me.txtNroRutas.Tag = Me.gwdDatos.CurrentRow.Index
    End Sub

    Private Sub Cargar_Detalle_Solicitud()
        Dim objEntidad As New Multimodal
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        objEntidad.NMOPMM = Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString().Trim()
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue.ToString.Trim
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue.ToString.Trim
        objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
        Me.gwdSolicitud.DataSource = objSolicitudTransporte.Listar_Solicitudes_Transporte_Multimodal(objEntidad)
    End Sub

    Private Sub Nuevo_Registro()
        Dim objOperacionMultimodal As New Multimodal_BLL
        Dim objEntidad As New Multimodal
        Try
            objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            objEntidad.NMOPMM = 0
            objEntidad.FCOPMM = HelpClass.CtypeDate(Me.dtpFechaMultimodal.Value)
            objEntidad.TOBRCP = txtObservaciones.Text
            objEntidad.CCLNT = txtClienteMnto.pCodigo
            objEntidad.NRORTA = txtNroRutas.Text.Trim()
            objEntidad.CDVSN = Me.cmbDivision.SelectedValue
            objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
            objEntidad.SESTOP = "A"
            objEntidad.SESTRG = "A"
            objEntidad.CUSCRT = MainModule.USUARIO
            objEntidad.FCHCRT = HelpClass.TodayNumeric
            objEntidad.HRACRT = HelpClass.NowNumeric
            objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad = objOperacionMultimodal.Registrar_Operaciones_Multimodal(objEntidad)
            If objEntidad.NMOPMM = 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                Me.txtNroOperacionMM.Text = objEntidad.NMOPMM
                HelpClass.MsgBox("Se Registró Satisfactoriamente")
            End If
            Me.Listar()
            '   Me.AccionCancelar()
        Catch : End Try
    End Sub

    Private Sub Modificar_Registro()
        Dim objOperacionMultimodal As New Multimodal_BLL
        Dim objEntidad As New Multimodal
        Try
            objEntidad.NMOPMM = Codigo
            objEntidad.CCLNT = txtClienteMnto.pCodigo
            objEntidad.FCOPMM = HelpClass.CtypeDate(Me.dtpFechaMultimodal.Value)
            objEntidad.NRORTA = Me.txtNroRutas.Text
            objEntidad.TOBRCP = Me.txtObservaciones.Text
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CCMPN = Me.cmbCompania.SelectedValue.ToString.Trim
            objEntidad = objOperacionMultimodal.Modificar_Operacion_Multimodal(objEntidad)
            If objEntidad.NMOPMM = 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Modificó Satisfactoriamente")
            End If
            Me.Listar()
            Me.AccionCancelar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Eliminar_Operacion_Multimodal(ByVal lstr_Estado As String)
        Dim objOperacionMultimodal As New Multimodal_BLL
        Dim objEntidad As New Multimodal
        Try
            objEntidad.NMOPMM = Codigo
            objEntidad.SESTRG = lstr_Estado
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            objEntidad = objOperacionMultimodal.Eliminar_Operacion_Multimodal(objEntidad)
            If objEntidad.NMOPMM = 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
            End If
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Me.Listar()
            Me.AccionCancelar()
        Catch ex As Exception
        End Try
    End Sub

    Private Function Obtener_Itinerario() As String
        Dim strResultado As String = ""
        For intContador As Integer = 1 To Me.gwdSolicitud.RowCount
            strResultado = strResultado & IIf(intContador.Equals(1), Me.gwdSolicitud.Rows(intContador - 1).Cells("D_CLCLOR").Value.ToString.Trim, "")
            strResultado = strResultado & " - " & Me.gwdSolicitud.Rows(intContador - 1).Cells("D_CLCLDS").Value.ToString.Trim
        Next
        Return strResultado
    End Function
    '---------------------------------------------
    Private Sub Eliminar_Solicitud(ByVal lstr_Estado As String)
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Try
            objEntidad.NCSOTR = Me.gwdSolicitud.Item("D_NCSOTR", Me.gwdSolicitud.CurrentCellAddress.Y).Value
            objEntidad.SESTRG = lstr_Estado
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            objEntidad.CDVSN = Me.cmbDivision.SelectedValue
            objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
            objEntidad = objSolicitudTransporte.Cambiar_Estado_Solicitud_Transporte(objEntidad)
            If objEntidad.NCSOTR = "0" Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Eliminó Satisfactoriamente")
                Me.Cargar_Detalle_Solicitud()
            End If
        Catch : End Try
    End Sub

    Private Sub Imprimir2(ByVal ListaParametros As List(Of String))
        Dim objOperacionMultimodal As New Multimodal_BLL
        Dim objCrep As New rptOperacionMultimodal
        Dim objDs As New DataSet
        Dim objPrintForm As New PrintForm
        objDs = objOperacionMultimodal.Listar_Reporte_Operacion_Multimodal(ListaParametros)
        If objDs.Tables.Count = 0 Then Exit Sub
        objDs.Tables(0).TableName = "OpMultimodal"
        objDs.Tables(1).TableName = "RZST071"
        HelpClass.CrystalReportTextObject(objCrep, "lblEstado", Me.ddlEstado.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblCompania", Me.cmbCompania.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblDivision", Me.cmbDivision.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblPlanta", Me.cmbPlanta.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblUsuario", USUARIO)
        If Me.ckbRangoFechas.Checked Then
            HelpClass.CrystalReportTextObject(objCrep, "lblFiltro", Me.dtpFechaInicio.Value.ToShortDateString & " AL  " & Me.dtpFechaFin.Value.ToShortDateString)
        End If
        objCrep.SetDataSource(objDs)
        objPrintForm.ShowForm(objCrep, Me)
    End Sub

    Public Sub Lista_Unidades_Asignadas(ByVal NroOpeMultimodal As Int64)
        Dim strTemporal As String = ""
        Dim dwvrow As DataGridViewRow
        Dim objEntidad As New Multimodal
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        objEntidad.NMOPMM = NroOpeMultimodal
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        Me.dtgRecursosAsignados.Rows.Clear()
        For Each obj_Entidad As ClaseGeneral In objSolicitudTransporte.Lista_Unidad_Asignada_Multimodal(objEntidad)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtgRecursosAsignados)
            If strTemporal = obj_Entidad.NCSOTR Then
                dwvrow.Cells(0).Value = ""
            Else
                dwvrow.Cells(0).Value = obj_Entidad.NCSOTR
                strTemporal = obj_Entidad.NCSOTR
            End If
            dwvrow.Cells(1).Value = obj_Entidad.NCRRSR
            dwvrow.Cells(2).Value = obj_Entidad.NPLNJT
            dwvrow.Cells(3).Value = obj_Entidad.NCRRPL
            dwvrow.Cells(4).Value = obj_Entidad.NRUCTR
            dwvrow.Cells(5).Value = obj_Entidad.TCMTRT
            dwvrow.Cells(6).Value = obj_Entidad.NPLCUN
            dwvrow.Cells(7).Value = obj_Entidad.NPLCAC
            dwvrow.Cells(8).Value = obj_Entidad.CBRCND
            dwvrow.Cells(9).Value = obj_Entidad.CBRCNT
            dwvrow.Cells(10).Value = obj_Entidad.CBRCN2
            dwvrow.Cells(11).Value = obj_Entidad.FASGTR
            dwvrow.Cells(12).Value = obj_Entidad.HASGTR
            dwvrow.Cells(13).Value = obj_Entidad.FATALM
            dwvrow.Cells(14).Value = obj_Entidad.HATALM
            dwvrow.Cells(15).Value = obj_Entidad.FSLALM
            dwvrow.Cells(16).Value = obj_Entidad.HSLALM
            dwvrow.Cells(17).Value = obj_Entidad.NGUITR
            dwvrow.Cells(18).Value = obj_Entidad.NOPRCN
            dwvrow.Cells(19).Value = obj_Entidad.NORINSS
            dwvrow.Cells(20).Value = obj_Entidad.NPLNMT
            dwvrow.Cells(21).Value = obj_Entidad.SESPLN
            dwvrow.Cells(22).Value = obj_Entidad.GPSLAT
            dwvrow.Cells(23).Value = obj_Entidad.GPSLON
            dwvrow.Cells(24).Value = obj_Entidad.FECGPS
            dwvrow.Cells(25).Value = obj_Entidad.HORGPS
            dwvrow.Cells(26).Value = obj_Entidad.SEGUIMIENTO
            If obj_Entidad.HORGPS <> "00:00:00" Then
                dwvrow.Cells(27).Value = My.Resources.button_ok1
            Else
                dwvrow.Cells(27).Value = My.Resources.Nada_1
            End If
            dwvrow.Cells(28).Value = ImagenLista.Images.Item(0)
            dwvrow.Cells(29).Value = obj_Entidad.NCOREG
            dwvrow.Cells(30).Value = obj_Entidad.NGSGWP
            dwvrow.Cells(31).Value = obj_Entidad.NCSOTR
            Me.dtgRecursosAsignados.Rows.Add(dwvrow)
        Next
    End Sub

    Private Sub ActivarEstado_Solicitud(ByVal lbool_Estado As Boolean)
        Select Case _TipoOperacion
            Case 0
                controlInformacion.txtCantidadSolicitada.Enabled = lbool_Estado
                controlInformacion.ctlTipoVehiculo.Enabled = lbool_Estado
                controlInformacion.txtOrdenServicio.Enabled = lbool_Estado
                controlInformacion.btnBuscaOrdenServicio.Enabled = lbool_Estado
                controlInformacion.txtObservaciones.Enabled = lbool_Estado
                controlInformacion.txtDireccionLocalidadCarga.Enabled = lbool_Estado
                controlInformacion.txtDireccionLocalidadEntrega.Enabled = lbool_Estado
            Case Else
                controlInformacion.txtCliente.Enabled = lbool_Estado
                controlInformacion.txtDireccionLocalidadCarga.Enabled = lbool_Estado
                controlInformacion.txtDireccionLocalidadEntrega.Enabled = lbool_Estado
                controlInformacion.txtCantidadSolicitada.Enabled = lbool_Estado
                controlInformacion.txtTipoServicio.Enabled = lbool_Estado
                controlInformacion.ctlTipoVehiculo.Enabled = lbool_Estado
                controlInformacion.ctbMercaderias.Enabled = lbool_Estado
                'controlInformacion.txtUnidadMedida.Enabled = lbool_Estado
                controlInformacion.txtCantidadMercaderia.Enabled = lbool_Estado
                controlInformacion.dtpFechaSolicitud.Enabled = lbool_Estado
                controlInformacion.dtpFechaInicioCarga.Enabled = lbool_Estado
                controlInformacion.dtpFinCarga.Enabled = lbool_Estado
                controlInformacion.txtObservaciones.Enabled = lbool_Estado
                controlInformacion.txtHoraCarga.Enabled = lbool_Estado
                controlInformacion.txtHoraEntrega.Enabled = lbool_Estado
                controlInformacion.txtOrdenServicio.Enabled = lbool_Estado
                controlInformacion.btnBuscaOrdenServicio.Enabled = lbool_Estado
                controlInformacion.btnLimpiarOS.Enabled = lbool_Estado
                controlInformacion.cmbTipoSolicitud.Enabled = lbool_Estado
                controlInformacion.cboMedioTransporte.Enabled = lbool_Estado
        End Select
    End Sub

    Private Sub Nuevo_Registro_Solicitud()
        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL

        'Try
        objEntidad.NCSOTR = "0"
        objEntidad.CCLNT = controlInformacion.txtCliente.pCodigo
        objEntidad.CMRCDR = controlInformacion.ctbMercaderias.Codigo
        objEntidad.FECOST = HelpClass.TodayNumeric
        objEntidad.HRAOTR = HelpClass.NowNumeric
        objEntidad.NORSRT = IIf(controlInformacion.txtOrdenServicio.Text = "", 0, controlInformacion.txtOrdenServicio.Text)
        objEntidad.FECOST = HelpClass.CtypeDate(controlInformacion.dtpFechaSolicitud.Value)
        'objEntidad.CLCLOR = controlInformacion.ctlLocalidadOrigen.Codigo
        objEntidad.CLCLOR = Val("" & controlInformacion.txt_localidad_origen.Tag)
        objEntidad.TDRCOR = controlInformacion.txtDireccionLocalidadCarga.Text
        'objEntidad.CLCLDS = controlInformacion.ctlLocalidadDestino.Codigo
        objEntidad.CLCLDS = Val("" & controlInformacion.txt_localidad_destino.Tag)
        objEntidad.TDRENT = controlInformacion.txtDireccionLocalidadEntrega.Text
        'objEntidad.CUNDMD = controlInformacion.txtUnidadMedida.Codigo
        objEntidad.CUNDMD = controlInformacion.txtUnidadMed.Text.Trim
        objEntidad.QSLCIT = IIf(controlInformacion.txtCantidadSolicitada.Text = "", "0", controlInformacion.txtCantidadSolicitada.Text)
        objEntidad.QATNAN = "0"
        objEntidad.FINCRG = HelpClass.CtypeDate(controlInformacion.dtpFechaInicioCarga.Value)
        objEntidad.HINCIN = HelpClass.CompletarCadena(controlInformacion.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.FENTCL = HelpClass.CtypeDate(controlInformacion.dtpFinCarga.Value)
        objEntidad.HRAENT = HelpClass.CompletarCadena(controlInformacion.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
        objEntidad.QMRCDR = IIf(controlInformacion.txtCantidadMercaderia.Text = "", "0", controlInformacion.txtCantidadMercaderia.Text)
        objEntidad.SESTRG = "A"
        objEntidad.CTPOSR = controlInformacion.txtTipoServicio.Codigo
        objEntidad.CUNDVH = controlInformacion.ctlTipoVehiculo.Codigo
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.TOBS = controlInformacion.txtObservaciones.Text
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
        objEntidad.SFCRTV = controlInformacion.cmbTipoSolicitud.SelectedValue
        objEntidad.NMOPMM = Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value
        objEntidad.NMOPRP = 0
        objEntidad.CMEDTR = controlInformacion.cboMedioTransporte.SelectedValue
        objEntidad.CCTCSC = controlInformacion.txtCentroCostoCliente.Text.Trim
        objEntidad.TRFRN = controlInformacion.txtUsuarioSolicitante.Text.Trim
        objEntidad.CTPOVJ = Me._CTPOVJ
        objEntidad.SPRSTR = "N"
        objEntidad.CTTRAN = CType(controlInformacion.ucNivelServ.Resultado, ENTIDADES.consultas.AtributosOI).Codigo
        objEntidad.CTIPCG = CType(controlInformacion.ucTipoCarga.Resultado, ENTIDADES.consultas.AtributosOI).Codigo

        Dim msgReg As String = ""
        objEntidad = objSolicitudTransporte.Registrar_Solicitud_Transporte(objEntidad, msgReg)
        If msgReg.Length > 0 Then
            MessageBox.Show(msgReg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        HelpClass.MsgBox("Se Registró Satisfactoriamente")
        Me.gwdDatos.Item("C_ITINERA", Me.gwdDatos.CurrentCellAddress.Y).Value = Me.Obtener_Itinerario
        Me.Cargar_Detalle_Solicitud()
        Me.btnCancelarSolicitud_Click(Nothing, Nothing)

        '    If objEntidad.NCSOTR = "0" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        '    Else
        '        HelpClass.MsgBox("Se Registró Satisfactoriamente")
        '        Me.gwdDatos.Item("C_ITINERA", Me.gwdDatos.CurrentCellAddress.Y).Value = Me.Obtener_Itinerario
        '        Me.Cargar_Detalle_Solicitud()
        '        Me.btnCancelarSolicitud_Click(Nothing, Nothing)
        '    End If
        'Catch : End Try

    End Sub

    Private Sub Modificar_Registro_Solicitud()
        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New Solicitud_Transporte
        Dim objSolicitudTransporte As New Solicitud_Transporte_BLL
        Try
            objEntidad.NCSOTR = controlInformacion.Codigo.Text
            objEntidad.NORSRT = IIf(controlInformacion.txtOrdenServicio.Text = "", 0, controlInformacion.txtOrdenServicio.Text)
            objEntidad.CCLNT = controlInformacion.txtCliente.pCodigo
            objEntidad.CMRCDR = controlInformacion.ctbMercaderias.Codigo
            objEntidad.FECOST = HelpClass.TodayNumeric
            objEntidad.HRAOTR = HelpClass.NowNumeric
            objEntidad.FECOST = HelpClass.CtypeDate(controlInformacion.dtpFechaSolicitud.Value)
            'objEntidad.CLCLOR = controlInformacion.ctlLocalidadOrigen.Codigo
            objEntidad.CLCLOR = Val("" & controlInformacion.txt_localidad_origen.Tag)
            objEntidad.TDRCOR = controlInformacion.txtDireccionLocalidadCarga.Text
            'objEntidad.CLCLDS = controlInformacion.ctlLocalidadDestino.Codigo
            objEntidad.CLCLDS = Val("" & controlInformacion.txt_localidad_destino.Tag)
            objEntidad.TDRENT = controlInformacion.txtDireccionLocalidadEntrega.Text
            'objEntidad.CUNDMD = controlInformacion.txtUnidadMedida.Codigo
            objEntidad.CUNDMD = controlInformacion.txtUnidadMed.Text.Trim
            objEntidad.QSLCIT = IIf(controlInformacion.txtCantidadSolicitada.Text = "", "0", controlInformacion.txtCantidadSolicitada.Text)
            objEntidad.QATNAN = "0"
            objEntidad.FINCRG = HelpClass.CtypeDate(controlInformacion.dtpFechaInicioCarga.Value)
            objEntidad.HINCIN = HelpClass.CompletarCadena(controlInformacion.txtHoraCarga.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
            objEntidad.FENTCL = HelpClass.CtypeDate(controlInformacion.dtpFinCarga.Value)
            objEntidad.HRAENT = HelpClass.CompletarCadena(controlInformacion.txtHoraEntrega.Text.Replace(":", "").Trim, 6, "0", HorizontalAlignment.Right)
            objEntidad.QMRCDR = IIf(controlInformacion.txtCantidadMercaderia.Text = "", "0", controlInformacion.txtCantidadMercaderia.Text)
            objEntidad.CTPOSR = controlInformacion.txtTipoServicio.Codigo
            objEntidad.CUNDVH = controlInformacion.ctlTipoVehiculo.Codigo
            objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            objEntidad.CDVSN = Me.cmbDivision.SelectedValue
            objEntidad.CPLNDV = Me.cmbPlanta.SelectedValue
            objEntidad.SFCRTV = controlInformacion.cmbTipoSolicitud.SelectedValue
            objEntidad.TOBS = controlInformacion.txtObservaciones.Text
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CMEDTR = controlInformacion.cboMedioTransporte.SelectedValue
            objEntidad.CCTCSC = controlInformacion.txtCentroCostoCliente.Text.Trim
            objEntidad.TRFRN = controlInformacion.txtUsuarioSolicitante.Text.Trim
            objEntidad.SPRSTR = "N"
            objEntidad.CTTRAN = CType(ControlInformacion.ucNivelServ.Resultado, ENTIDADES.consultas.AtributosOI).Codigo
            objEntidad.CTIPCG = CType(ControlInformacion.ucTipoCarga.Resultado, ENTIDADES.consultas.AtributosOI).Codigo

            objEntidad = objSolicitudTransporte.Modificar_Solicitud_Transporte(objEntidad)
            If objEntidad.NCSOTR = "0" Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            Else
                HelpClass.MsgBox("Se Modificó Satisfactoriamente")
                Me.Cargar_Detalle_Solicitud()
                Me.btnCancelarSolicitud_Click(Nothing, Nothing)
            End If
        Catch : End Try
    End Sub

    Private Sub Limpiar_Controles_Solicitud()
        controlInformacion.dtpFechaSolicitud.Value = Date.Now.Date
        'controlInformacion.ctlLocalidadOrigen.Limpiar()
        controlInformacion.txt_localidad_origen.Tag = "0"
        controlInformacion.txt_localidad_origen.Text = ""
        controlInformacion.txtDireccionLocalidadCarga.Text = ""
        'controlInformacion.ctlLocalidadDestino.Limpiar()
        controlInformacion.txt_localidad_destino.Tag = "0"
        controlInformacion.txt_localidad_destino.Text = ""
        controlInformacion.txtDireccionLocalidadEntrega.Text = ""
        controlInformacion.txtCantidadSolicitada.Text = ""
        controlInformacion.txtTipoServicio.Limpiar()
        controlInformacion.ctlTipoVehiculo.Limpiar()
        controlInformacion.ctbMercaderias.Limpiar()
        'controlInformacion.txtUnidadMedida.Limpiar()
        controlInformacion.txtUnidadMed.Text = ""
        controlInformacion.txtCantidadMercaderia.Text = ""
        controlInformacion.txtObservaciones.Text = ""
        controlInformacion.txtHoraCarga.Text = "00:00:00"
        controlInformacion.txtHoraEntrega.Text = "00:00:00"
        controlInformacion.dtpFechaInicioCarga.Value = Date.Now.Date
        controlInformacion.dtpFinCarga.Value = Date.Now.Date
        controlInformacion.txtFechaSolicitud.Text = ""
        controlInformacion.txtFechaEntrega.Text = ""
        controlInformacion.txtFechaCarga.Text = ""
        controlInformacion.txtOrdenServicio.Text = ""
        controlInformacion.cboMedioTransporte.SelectedValue = 4
        controlInformacion.txtUsuarioSolicitante.Text = ""
    End Sub

    Private Function Validar_Input_Solicitud() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If Val("" & controlInformacion.txt_localidad_origen.Tag) = 0 Then
            'If controlInformacion.ctlLocalidadOrigen.NoHayCodigo = True Then
            lstr_validacion += "* LOCALIDAD DE CARGA " & Chr(13)
        End If
        If controlInformacion.txtDireccionLocalidadCarga.Text = "" Then
            lstr_validacion += "* DIRECCION DE LOCALIDAD DE CARGA " & Chr(13)
        End If
        If controlInformacion.ctbMercaderias.NoHayCodigo = True Then
            lstr_validacion += "* MERCADERIA DE TRANSLADO " & Chr(13)
        End If
        'If controlInformacion.ctlLocalidadDestino.NoHayCodigo = True Then
        If Val("" & controlInformacion.txt_localidad_destino.Tag) Then
            lstr_validacion += "* LOCALIDAD DE ENTREGA" & Chr(13)
        End If
        If controlInformacion.txtDireccionLocalidadEntrega.Text = "" Then
            lstr_validacion += "* DIRECCION DE LOCALIDAD DE ENTREGA" & Chr(13)
        End If
        If controlInformacion.txtOrdenServicio.Text = "" Then
            lstr_validacion += "* ORDEN DE SERVICIO" & Chr(13)
        End If
        If controlInformacion.txtCantidadSolicitada.Text = "" Or IsNumeric(controlInformacion.txtCantidadSolicitada.Text) = False Then
            lstr_validacion += "* CANTIDAD DE VEHICULOS" & Chr(13)
        End If
        If controlInformacion.txtTipoServicio.NoHayCodigo = True Then
            lstr_validacion += "* TIPO DE SERVICIO" & Chr(13)
        End If
        If controlInformacion.ctlTipoVehiculo.NoHayCodigo = True Then
            lstr_validacion += "* TIPO DE VEHICULO" & Chr(13)
        End If
        'If controlInformacion.txtUnidadMedida.NoHayCodigo = True Then
        If controlInformacion.txtUnidadMed.Text.Trim = "" Then
            lstr_validacion += "* UNIDAD DE MEDIDA DE MERCADERIA" & Chr(13)
        End If
        If HelpClass.CtypeDate(controlInformacion.dtpFechaSolicitud.Value) > HelpClass.CtypeDate(controlInformacion.dtpFinCarga.Value) Then
            lstr_validacion += "* FECHA SOLICITUD MAYOR A FECHA DE ENTREGA" & Chr(13)
        End If
        If HelpClass.CFecha_a_Numero8Digitos(controlInformacion.dtpFechaInicioCarga.Value.ToShortDateString) > HelpClass.CFecha_a_Numero8Digitos(controlInformacion.dtpFinCarga.Value.ToShortDateString) Then
            lstr_validacion += "* FECHA DE CARGA MAYOR A FECHA DE ENTREGA" & Chr(13)
        End If
        If controlInformacion.txtUsuarioSolicitante.Text.Trim = "" Then
            lstr_validacion += "* USUARIO SOLICITANTE" & Chr(13)
        End If

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    Private Sub btnSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguimiento.Click
        Try
            Dim vNPLCUN As String = ""
            Dim NCOREG As String = ""
            Dim NCSOTR As Decimal = 0
            Dim obeSeguimientoGPS As New SeguimientoGPS
            If (dtgRecursosAsignados.Rows.Count <= 0) Then Exit Sub
            vNPLCUN = HelpClass.ObjectToString(dtgRecursosAsignados.CurrentRow.Cells("NPLCUN").Value)
            NCSOTR = HelpClass.ObjectToDecimal(dtgRecursosAsignados.CurrentRow.Cells("NCSOTR_1").Value)
            obeSeguimientoGPS.NPLCTR = vNPLCUN
            obeSeguimientoGPS.NCSOTR = NCSOTR
            obeSeguimientoGPS.CCMPN = Me.cmbCompania.SelectedValue
            obeSeguimientoGPS.NCRRSR = HelpClass.ObjectToDecimal(dtgRecursosAsignados.CurrentRow.Cells("NCRRSR").Value)
            obeSeguimientoGPS.NGSGWP = HelpClass.ObjectToString(dtgRecursosAsignados.CurrentRow.Cells("NGSGWP").Value)
            obeSeguimientoGPS.NCOREG = HelpClass.ObjectToDecimal(dtgRecursosAsignados.CurrentRow.Cells("NCOREG").Value)
            Dim ofrmGPSWAP As New frmGPSWAP()
            ofrmGPSWAP.oInfoSeguimientoGPS = obeSeguimientoGPS
            ofrmGPSWAP.ShowDialog(Me)
            Me.Lista_Unidades_Asignadas(Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value)
        Catch : End Try

    End Sub

    Private Sub btnReporteBulto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReporteBulto.Click
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 OrElse Me.gwdSolicitud.RowCount = 0 OrElse Me.dtgRecursosAsignados.RowCount = 0 Then Exit Sub
        Dim objOperacionMultimodal As New Multimodal_BLL
        Dim objCrep As New rptMultimodal_Lista_Bulto
        Dim objPrintForm As New PrintForm
        Dim objDs As New DataSet
        Dim paramMultimodal As New Hashtable
        paramMultimodal.Add("NMOPMM", Me.gwdDatos.Item("C_NMOPMM", Me.gwdDatos.CurrentCellAddress.Y).Value)
        paramMultimodal.Add("CCMPN", Me.cmbCompania.SelectedValue)
        paramMultimodal.Add("CDVSN", Me.cmbDivision.SelectedValue)
        paramMultimodal.Add("CPLNDV", Me.cmbPlanta.SelectedValue)
        objDs = objOperacionMultimodal.Listar_Reporte_Bulto(paramMultimodal)
        If objDs.Tables.Count = 0 Then Exit Sub
        objDs.Tables(0).TableName = "BULTO"
        objDs.Tables(1).TableName = "RESUMEN"
        HelpClass.CrystalReportTextObject(objCrep, "lblCompania", Me.cmbCompania.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblDivision", Me.cmbDivision.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblPlanta", Me.cmbPlanta.Text)
        HelpClass.CrystalReportTextObject(objCrep, "lblUsuario", USUARIO)
        objCrep.SetDataSource(objDs)
        objPrintForm.ShowForm(objCrep, Me)
    End Sub

    Private Function Operacion_Guia_Transporte() As DataTable
        Dim objRow As DataRow
        Dim objTable As New DataTable
        objTable.Columns.Add("TCMPCL", Type.GetType("System.String"))
        objTable.Columns.Add("NOPRCN", Type.GetType("System.Int64"))
        objTable.Columns.Add("CCMPN", Type.GetType("System.String"))
        objRow = objTable.NewRow
        objRow("TCMPCL") = Me.gwdDatos.Item("C_TCMPCL", Me.gwdDatos.CurrentCellAddress.Y).Value
        objRow("NOPRCN") = Me.dtgRecursosAsignados.Item("NOPRCN", Me.dtgRecursosAsignados.CurrentCellAddress.Y).Value
        objRow("CCMPN") = Me.cmbCompania.SelectedValue
        objTable.Rows.Add(objRow)

        Return objTable
    End Function

#End Region

End Class
