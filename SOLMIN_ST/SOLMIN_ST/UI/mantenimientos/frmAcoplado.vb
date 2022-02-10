Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data

Public Class frmAcoplado

    Private gEnum_Mantenimiento As MANTENIMIENTO
    'Private bolBuscar As Boolean = False

    Private Sub frmAcoplado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
          
            'btnGuardar.Enabled = False
            'btnCancelar.Enabled = False
            'btnEliminar.Enabled = False
            'Limpia los controles
            Cargar_Compania()
            CargarComboTipoAcoplado()
            Me.Limpiar_Controles()
            'Estado_Controles(False)
            Me.gwdDatos.AutoGenerateColumns = False
            'Listar()
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
             
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
        'Pone el flag en neutral 
    End Sub

    'Public Sub Inicializar()
    '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '    'btnGuardar.Enabled = False
    '    'btnCancelar.Enabled = False
    '    'btnEliminar.Enabled = False

    '    'Limpia los controles
    '    Me.Limpiar_Controles()
    '    Estado_Controles(False)
    '    Me.gwdDatos.AutoGenerateColumns = False
    '    Listar()
    '    CargarComboTipoAcoplado()
    'End Sub

    Sub CargarComboTipoAcoplado()
        'Try
        Dim objTipoAcoplado As New TipoAcoplado_BLL
        Dim objEntidad As New TipoAcoplado
        Dim dt As New DataTable
        dt = objTipoAcoplado.Listar_Tipo_Acoplado_Seleccion(Me.cmbCompania.SelectedValue)
        'cboTipoAcoplado.DataSource = HelpClass.GetDataSetNative(objTipoAcoplado.Listar_Tipo_Acoplado(objEntidad))
        cboTipoAcoplado.DataSource = dt
        cboTipoAcoplado.ValueField = "TDEACP"
        cboTipoAcoplado.KeyField = "CTIACP"
        cboTipoAcoplado.DataBind()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Listar()
        Dim objAcoplado As New Acoplado_BLL
        Dim objEntidad As New Acoplado
        Dim dt As New DataTable
        objEntidad.NPLCAC = Me.txtFiltroPlacaAcoplado.Text
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.PAGESIZE = UcPaginacion1.PageSize
        objEntidad.PAGENUMBER = UcPaginacion1.PageNumber
        Dim TotalPag As Decimal = 0
        dt = objAcoplado.Listar_AcopladoPaginado(objEntidad, TotalPag)
        Limpiar_Controles()
        Me.gwdDatos.DataSource = dt
        If gwdDatos.Rows.Count Then
            UcPaginacion1.PageCount = TotalPag
        End If
        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        EstadoBoton(gEnum_Mantenimiento)
    End Sub

    Private Sub Limpiar_Controles()
        txtColorUnidad.Text = ""
        txtAltoAcoplado.txtDecimales.Text = ""
        txtAnchoAcoplado.txtDecimales.Text = ""
        txtPlacaAcoplado.Text = ""
        txtConfiguracionEjes.Text = ""
        txtMarcaVehiculo.Text = ""
        txtLongitudAcoplado.txtDecimales.Text = ""
        txtCapacidadCarga.Text = ""
        txtNroChasis.Text = ""
        txtNroEjes.Text = ""
        txtNumeroMTC.Text = ""
        txtPesoTara.Text = ""
        cboTipoAcoplado.Limpiar()
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de acoplado"
    End Sub

    'Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
    '    Me.txtPlacaAcoplado.Enabled = lbool_Estado
    '    If Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
    '        Me.txtPlacaAcoplado.Enabled = Not lbool_Estado
    '    End If
    '    Me.txtAltoAcoplado.Enabled = lbool_Estado
    '    Me.txtAnchoAcoplado.Enabled = lbool_Estado
    '    Me.txtColorUnidad.Enabled = lbool_Estado
    '    Me.txtConfiguracionEjes.Enabled = lbool_Estado
    '    Me.txtMarcaVehiculo.Enabled = lbool_Estado
    '    Me.txtLongitudAcoplado.Enabled = lbool_Estado
    '    Me.txtCapacidadCarga.Enabled = lbool_Estado
    '    Me.txtNroChasis.Enabled = lbool_Estado
    '    Me.txtNroEjes.Enabled = lbool_Estado
    '    Me.txtNumeroMTC.Enabled = lbool_Estado
    '    Me.txtPesoTara.Enabled = lbool_Estado
    '    Me.cboTipoAcoplado.Enabled = lbool_Estado
    'End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        'btnNuevo.Enabled = False
        'btnGuardar.Text = "Guardar"
        'btnGuardar.Enabled = True
        'btnCancelar.Enabled = True
        'btnEliminar.Enabled = False
        'Limpiar_Controles()
        'Estado_Controles(True)
        'txtPlacaAcoplado.Focus()
        'CargarComboTipoAcoplado()
        'Listar()



        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            EstadoBoton(gEnum_Mantenimiento)
            Limpiar_Controles()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function validarAcoplado() As Integer
        If txtPlacaAcoplado.Text = "" Then
            MsgBox("Debe ingresar la placa del acoplado.", MsgBoxStyle.Exclamation)
            Return 0
        ElseIf cboTipoAcoplado.Codigo = "" Then
            MsgBox("Debe seleccionar el tipo de acoplado.", MsgBoxStyle.Exclamation)
            Return 0
        End If

        Return 1
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                If validarAcoplado() = 1 Then
                    Nuevo_Registro()
                    'Estado_Botones_Ultimo()
                    'AccionCancelar()
                End If

            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If validarAcoplado() = 1 Then
                    Modificar_Registro()
                    'Estado_Botones_Ultimo()
                    'AccionCancelar()
                End If
                'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
                '    'Me.Estado_Controles(True)
                '    'btnGuardar.Text = "Guardar"
                '    'btnNuevo.Enabled = False
                '    'btnCancelar.Enabled = True
                '    'btnEliminar.Enabled = False
                '    Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    'Private Sub AccionCancelar()
    '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '    Limpiar_Controles()
    '    Estado_Controles(False)
    '    'If Me.gwdDatos.Rows.Count > 0 Then
    '    '    Me.gwdDatos.CurrentRow.Selected = False
    '    'End If
    '    'btnNuevo.Enabled = True
    '    'btnGuardar.Enabled = False
    '    'btnCancelar.Enabled = False
    '    'btnEliminar.Enabled = False
    'End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'AccionCancelar()
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)
            'Estado_Controles(False)
            gwdDatos_SelectionChanged(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            If Me.txtPlacaAcoplado.Text <> "" And Me.txtPlacaAcoplado.Text <> "0" Then
                Dim objEntidad As New Acoplado
                Dim objTransAc As New TransportistaAcoplado_BLL
                Dim tieneDetalles As Boolean = False
                objEntidad.NPLCAC = txtPlacaAcoplado.Text
                objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                tieneDetalles = objTransAc.Listar_Transportista_x_Acoplado(objEntidad).Count > 0

                If tieneDetalles Then
                    If MsgBox("Este acoplado está asignado a un tranportista. Confirma que desea eliminarlo?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                        Eliminar_Registro()
                        'Estado_Botones_Ultimo()
                        'AccionCancelar()
                    End If
                Else
                    If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                        Eliminar_Registro()
                        'Estado_Botones_Ultimo()
                        'AccionCancelar()
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub Nuevo_Registro()
        'Procedimiento para registrar una nuevo acoplado
        Dim objEntidad As New Acoplado
        Dim objTipoAcoplado As New Acoplado_BLL

        Dim PesoTara As String = Me.txtPesoTara.Text.Trim

        objEntidad.NPLCAC = Me.txtPlacaAcoplado.Text.Trim
        objEntidad.TCLRUN = Me.txtColorUnidad.Text.Trim
        If PesoTara <> "" AndAlso IsNumeric(PesoTara) Then
      objEntidad.QPSTRA = Math.Round(Convert.ToDecimal(PesoTara), 0)
        Else
            objEntidad.QPSTRA = 0
        End If
        objEntidad.NEJSUN = IIf(Me.txtNroEjes.Text.Trim = "", "0", Me.txtNroEjes.Text.Trim)
        objEntidad.NCPCRU = IIf(Me.txtCapacidadCarga.Text.Trim = "", "0", Me.txtCapacidadCarga.Text.Trim)
        objEntidad.NSRCHU = Me.txtNroChasis.Text.Trim
        objEntidad.QLNGAC = IIf(Me.txtLongitudAcoplado.txtDecimales.Text.Trim = "", "0", Me.txtLongitudAcoplado.txtDecimales.Text.Trim)
        objEntidad.QANCAC = IIf(Me.txtAnchoAcoplado.txtDecimales.Text.Trim = "", "0", Me.txtAnchoAcoplado.txtDecimales.Text.Trim)
        objEntidad.QALTAC = IIf(Me.txtAltoAcoplado.txtDecimales.Text.Trim = "", "0", Me.txtAltoAcoplado.txtDecimales.Text.Trim)
        objEntidad.CTIACP = cboTipoAcoplado.Codigo
        objEntidad.NRGMT2 = Me.txtNumeroMTC.Text.Trim
        objEntidad.TCNFG2 = Me.txtConfiguracionEjes.Text.Trim
        objEntidad.TMRCVH = Me.txtMarcaVehiculo.Text.Trim
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue

        Dim v_NPLCAC As String = objEntidad.NPLCAC
        objEntidad = objTipoAcoplado.Registrar_Acoplado(objEntidad)

        If objEntidad.NPLCAC = "-1" Then ' -1 : El acoplado existe en la tabla
            objEntidad.NPLCAC = v_NPLCAC
            objEntidad.CULUSA = objEntidad.CUSCRT
            objEntidad.FULTAC = objEntidad.FCHCRT
            objEntidad.HULTAC = objEntidad.HRACRT
            objEntidad = objTipoAcoplado.Modificar_Acoplado(objEntidad)
        End If

        'Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        'EstadoBoton(gEnum_Mantenimiento)
        Listar()

        'If objEntidad.NPLCAC = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        '    Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        '    Listar()
        'End If
    End Sub

    Private Sub Modificar_Registro()
        'Procedimiento para modificar una nueva solicitud de transporte
        Dim objEntidad As New Acoplado
        Dim objAcoplado As New Acoplado_BLL

        objEntidad.NPLCAC = Me.txtPlacaAcoplado.Text.Trim
        objEntidad.TCLRUN = Me.txtColorUnidad.Text.Trim
        objEntidad.QPSTRA = IIf(Me.txtPesoTara.Text.Trim = "", "0", Me.txtPesoTara.Text.Trim)
        objEntidad.NEJSUN = IIf(Me.txtNroEjes.Text.Trim = "", 0, Me.txtNroEjes.Text.Trim)
        objEntidad.NCPCRU = IIf(Me.txtCapacidadCarga.Text.Trim = "", 0, Me.txtCapacidadCarga.Text.Trim)
        objEntidad.NSRCHU = Me.txtNroChasis.Text.Trim
        objEntidad.QLNGAC = IIf(Me.txtLongitudAcoplado.txtDecimales.Text.Trim = "", 0, Me.txtLongitudAcoplado.txtDecimales.Text.Trim)
        objEntidad.QANCAC = IIf(Me.txtAnchoAcoplado.txtDecimales.Text.Trim = "", 0, Me.txtAnchoAcoplado.txtDecimales.Text.Trim)
        objEntidad.QALTAC = IIf(Me.txtAltoAcoplado.txtDecimales.Text.Trim = "", 0, Me.txtAltoAcoplado.txtDecimales.Text.Trim)
        objEntidad.CTIACP = cboTipoAcoplado.Codigo
        objEntidad.NRGMT2 = Me.txtNumeroMTC.Text.Trim
        objEntidad.TCNFG2 = Me.txtConfiguracionEjes.Text.Trim
        objEntidad.TMRCVH = Me.txtMarcaVehiculo.Text.Trim
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        objEntidad = objAcoplado.Modificar_Acoplado(objEntidad)



        'Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        'EstadoBoton(gEnum_Mantenimiento)

        Listar()
        'If objEntidad.NPLCAC = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        '    Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        '    Listar()
        'End If

    End Sub

    Private Sub Eliminar_Registro()
        Dim objEntidad As New Acoplado
        Dim obj As New Acoplado_BLL

        objEntidad.NPLCAC = Me.txtPlacaAcoplado.Text.Trim
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        objEntidad = obj.Eliminar_Acoplado(objEntidad)
        'Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        'EstadoBoton(gEnum_Mantenimiento)
        Listar()
        'If objEntidad.NPLCAC = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        '    Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        '    Listar()
        'End If

    End Sub

    'Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick

    'End Sub

    'Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
    '    If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    '    Select Case e.KeyCode
    '        Case Keys.Enter, Keys.Up, Keys.Down
    '            Me.Asignar_Datos()
    '    End Select
    'End Sub

    'Private Sub Asignar_Datos()
    '    Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
    '    'If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '    '    If Me.gwdDatos.Rows.Count > 0 Then
    '    '        Me.gwdDatos.CurrentRow.Selected = False
    '    '    End If
    '    '    MsgBox("Debe guardar el nuevo acoplado o cancelarlo.", MsgBoxStyle.Exclamation)
    '    '    Exit Sub
    '    'End If
    '    'Marcando el estado de Edicion
    '    'Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    '    'btnGuardar.Text = "Modificar"
    '    'btnGuardar.Enabled = True
    '    'btnEliminar.Enabled = True
    '    Limpiar_Controles()
    '    Me.txtPlacaAcoplado.Text = Me.gwdDatos.Item("NPLCAC", lint_Indice).Value.ToString().Trim()
    '    Me.txtColorUnidad.Text = Me.gwdDatos.Item("TCLRUN", lint_Indice).Value.ToString().Trim()
    '    Me.txtPesoTara.Text = Me.gwdDatos.Item("QPSTRA", lint_Indice).Value.ToString().Trim()
    '    Me.txtNroEjes.Text = Me.gwdDatos.Item("NEJSUN", lint_Indice).Value.ToString().Trim()
    '    Me.txtCapacidadCarga.Text = Me.gwdDatos.Item("NCPCRU", lint_Indice).Value.ToString().Trim()
    '    Me.txtNroChasis.Text = Me.gwdDatos.Item("NSRCHU", lint_Indice).Value.ToString().Trim()
    '    Me.txtLongitudAcoplado.txtDecimales.Text = Me.gwdDatos.Item("QLNGAC", lint_Indice).Value.ToString().Trim()
    '    Me.txtAnchoAcoplado.txtDecimales.Text = Me.gwdDatos.Item("QANCAC", lint_Indice).Value.ToString().Trim()
    '    Me.txtAltoAcoplado.txtDecimales.Text = Me.gwdDatos.Item("QALTAC", lint_Indice).Value.ToString().Trim()
    '    Me.cboTipoAcoplado.Codigo = Me.gwdDatos.Item("CTIACP", lint_Indice).Value.ToString().Trim()
    '    Me.txtNumeroMTC.Text = Me.gwdDatos.Item("NRGMT2", lint_Indice).Value.ToString().Trim()
    '    Me.txtConfiguracionEjes.Text = Me.gwdDatos.Item("TCNFG2", lint_Indice).Value.ToString().Trim()
    '    Me.txtMarcaVehiculo.Text = Me.gwdDatos.Item("TMRCVH", lint_Indice).Value.ToString().Trim()
    '    Me.HeaderDatos.ValuesPrimary.Heading = "Información de Acoplado / Placa: " & txtPlacaAcoplado.Text.Trim
    'End Sub

    'Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    '    Try
    '        If Me.gwdDatos.Rows.Count > 0 Then
    '            Me.gwdDatos.CurrentRow.Selected = True
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
        '    MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
        'Else
        '    Listar()
        'End If
        Try
            Listar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub txtFiltroPlacaAcoplado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroPlacaAcoplado.KeyPress
    '    If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '        MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
    '        e.Handled = True
    '    End If

    'End Sub

    'Private Sub txtPesoTara_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacidadCarga.KeyPress, txtNroEjes.KeyPress, txtLongitudAcoplado.KeyPress, txtAnchoAcoplado.KeyPress, txtAltoAcoplado.KeyPress

    '    'NumerosyDecimal(txtPesoTara, e)

    '    Select Case Asc(e.KeyChar)
    '        Case 48 To 57
    '        Case 8, 13
    '        Case Else : e.Handled = True
    '    End Select
    'End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    'Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
    '    If bolBuscar Then
    '        '  Me.btnBuscar_Click(Nothing, Nothing)
    '        InicializarFormulario()
    '    End If

    'End Sub
    'Private Sub InicializarFormulario()
    '    Me.Limpiar_Controles()
    '    gwdDatos.DataSource = Nothing
    '    Estado_Controles(False)
    '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '    btnGuardar.Enabled = False
    '    btnCancelar.Enabled = False
    '    btnEliminar.Enabled = False
    '    CargarComboTipoAcoplado()

    'End Sub
#Region "COMPAÑIA "

    Private Sub Cargar_Compania()
        Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
        objCompaniaBLL.Crea_Lista()
        'bolBuscar = False
        cmbCompania.DataSource = objCompaniaBLL.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
        'bolBuscar = True

        ' cmbCompania.SelectedIndex = 0
        'cmbCompania.SelectedValue = "EZ"
        'If cmbCompania.SelectedIndex = -1 Then
        '    cmbCompania.SelectedIndex = 0
        'End If

        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

#End Region

   

    'Private Sub gwdDatos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellChanged
    '    If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    '    Me.Asignar_Datos()
    'End Sub

    'Private Sub Estado_Botones_Ultimo()
    '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '    Estado_Controles(False)
    '    btnNuevo.Enabled = True
    '    btnCancelar.Enabled = False
    'End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            EstadoBoton(gEnum_Mantenimiento)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)

            Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
            Limpiar_Controles()
            Me.txtPlacaAcoplado.Text = Me.gwdDatos.Item("NPLCAC", lint_Indice).Value.ToString().Trim()
            Me.txtColorUnidad.Text = Me.gwdDatos.Item("TCLRUN", lint_Indice).Value.ToString().Trim()
            Me.txtPesoTara.Text = Me.gwdDatos.Item("QPSTRA", lint_Indice).Value.ToString().Trim()
            Me.txtNroEjes.Text = Me.gwdDatos.Item("NEJSUN", lint_Indice).Value.ToString().Trim()
            Me.txtCapacidadCarga.Text = Me.gwdDatos.Item("NCPCRU", lint_Indice).Value.ToString().Trim()
            Me.txtNroChasis.Text = Me.gwdDatos.Item("NSRCHU", lint_Indice).Value.ToString().Trim()
            Me.txtLongitudAcoplado.txtDecimales.Text = Me.gwdDatos.Item("QLNGAC", lint_Indice).Value.ToString().Trim()
            Me.txtAnchoAcoplado.txtDecimales.Text = Me.gwdDatos.Item("QANCAC", lint_Indice).Value.ToString().Trim()
            Me.txtAltoAcoplado.txtDecimales.Text = Me.gwdDatos.Item("QALTAC", lint_Indice).Value.ToString().Trim()
            Me.cboTipoAcoplado.Codigo = Me.gwdDatos.Item("CTIACP", lint_Indice).Value.ToString().Trim()
            Me.txtNumeroMTC.Text = Me.gwdDatos.Item("NRGMT2", lint_Indice).Value.ToString().Trim()
            Me.txtConfiguracionEjes.Text = Me.gwdDatos.Item("TCNFG2", lint_Indice).Value.ToString().Trim()
            Me.txtMarcaVehiculo.Text = Me.gwdDatos.Item("TMRCVH", lint_Indice).Value.ToString().Trim()
            Me.HeaderDatos.ValuesPrimary.Heading = "Información de Acoplado / Placa: " & txtPlacaAcoplado.Text.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcPaginacion1_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        Try
            Listar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub EstadoBoton(ByVal op As MANTENIMIENTO)

        Dim lbool_estado As Boolean = False
        Select Case op
            Case MANTENIMIENTO.NEUTRAL

                btnNuevo.Enabled = True
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                btnModificar.Enabled = True
                btnEliminar.Enabled = True

                lbool_estado = False

            Case MANTENIMIENTO.EDITAR

                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnModificar.Enabled = False
                btnEliminar.Enabled = False

                lbool_estado = True

            Case MANTENIMIENTO.NUEVO
                btnNuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnModificar.Enabled = False
                btnEliminar.Enabled = False

                lbool_estado = True
        End Select


        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            Me.txtPlacaAcoplado.Enabled = True
        Else
            Me.txtPlacaAcoplado.Enabled = False
        End If
        Me.txtAltoAcoplado.Enabled = lbool_estado
        Me.txtAnchoAcoplado.Enabled = lbool_estado
        Me.txtColorUnidad.Enabled = lbool_estado
        Me.txtConfiguracionEjes.Enabled = lbool_estado
        Me.txtMarcaVehiculo.Enabled = lbool_estado
        Me.txtLongitudAcoplado.Enabled = lbool_estado
        Me.txtCapacidadCarga.Enabled = lbool_estado
        Me.txtNroChasis.Enabled = lbool_estado
        Me.txtNroEjes.Enabled = lbool_estado
        Me.txtNumeroMTC.Enabled = lbool_estado
        Me.txtPesoTara.Enabled = lbool_estado
        Me.cboTipoAcoplado.Enabled = lbool_estado

    End Sub
End Class
