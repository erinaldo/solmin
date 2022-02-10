Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports System.Data
Imports System.Collections.Generic

Public Class frmTracto
    Private gEnum_Mantenimiento As MANTENIMIENTO
    'Private bolBuscar As Boolean = False

    Private Sub frmTracto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            'btnGuardar.Enabled = False
            'btnCancelar.Enabled = False
            'btnEliminar.Enabled = False
            Cargar_Compania()
            Limpiar_Textos()
            'Estado_Controles(False)
            gwdDatos.AutoGenerateColumns = False
            gwdDatos.DataSource = Nothing
            Cargar_ComboTipoTracto()
            dgvHistorial.AutoGenerateColumns = False
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)


            'Me.Limpiar_Textos()
            'Estado_Controles(False)
            'btnGuardar.Enabled = False
            'btnCancelar.Enabled = False
            'btnEliminar.Enabled = False
            'Cargar_ComboTipoTracto()
            'Me.gwdDatos.DataSource = Nothing

            'InicializarFormulario()

            'Listar_Vehiculos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        
  End Sub

    Private Sub Limpiar_Textos()
        Me.txtCodigoTipoTracto.Limpiar()
        Me.txtCapCargaUnidad.Text = ""
        Me.txtCarroceriaUnidad.Text = ""
        Me.txtColorUnidad.Text = ""
        Me.txtFechaFabricacion.Text = ""
        Me.txtMarcaModelo.Text = ""
        Me.txtNumChasis.Text = ""
        Me.txtNumEjes.Text = ""
        Me.txtNumEmpadMTC.Text = ""
        Me.txtNumPlacaUnidad.Text = ""
        Me.txtPesoTracto.Text = ""
        Me.txtSerieMotor.Text = ""
        Me.txtNroRPM.Text = ""
        Me.HeaderDatos.ValuesPrimary.Heading = ""
    End Sub

    'Private Sub Estado_Controles(ByVal lbool_estado As Boolean)
    '    Me.txtNumPlacaUnidad.Enabled = lbool_estado
    '    'If Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
    '    '    Me.txtNumPlacaUnidad.Enabled = Not lbool_estado
    '    'End If
    '    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
    '        Me.txtNumPlacaUnidad.Enabled = True
    '    Else
    '        Me.txtNumPlacaUnidad.Enabled = False
    '    End If
    '    Me.txtCodigoTipoTracto.Enabled = lbool_estado
    '    Me.txtCapCargaUnidad.Enabled = lbool_estado
    '    Me.txtCarroceriaUnidad.Enabled = lbool_estado
    '    Me.txtColorUnidad.Enabled = lbool_estado
    '    Me.txtFechaFabricacion.Enabled = lbool_estado
    '    Me.txtMarcaModelo.Enabled = lbool_estado
    '    Me.txtNumChasis.Enabled = lbool_estado
    '    Me.txtNumEjes.Enabled = lbool_estado
    '    Me.txtNumEmpadMTC.Enabled = lbool_estado
    '    Me.txtPesoTracto.Enabled = lbool_estado
    '    Me.txtSerieMotor.Enabled = lbool_estado
    '    Me.txtNroRPM.Enabled = lbool_estado
    'End Sub

    Private Sub Cargar_ComboTipoTracto()
        'Try
        Dim objTipoTracto As New TipodeTracto_BLL
        Dim objEntidad As New TipodeTracto
        objEntidad.TDETRA = ""
        objEntidad.CCMPN = cmbCompania.SelectedValue.ToString().Trim()
        Dim dtTipoTracto As New DataTable
        dtTipoTracto = objTipoTracto.Listar_TipodeTracto_seleccion(objEntidad.CCMPN)
        With Me.txtCodigoTipoTracto
            '.DataSource = HelpClass.GetDataSetNative(objTipoTracto.Listar_TipodeTracto(objEntidad))
            .DataSource = dtTipoTracto
            .KeyField = "CTITRA"
            .ValueField = "TDETRA"
            .DataBind()
        End With
        'Listar_TipodeTracto_seleccion
        'Catch ex As Exception
        'End Try
    End Sub

    Public Sub Registrar()
        Dim objEntidad As New Tracto
        Dim objTracto As New Tracto_BLL

        objEntidad.NPLCUN = Me.txtNumPlacaUnidad.Text.Trim
        objEntidad.NEJSUN = IIf(Me.txtNumEjes.Text = "", 0, Me.txtNumEjes.Text)
        objEntidad.NSRCHU = Me.txtNumChasis.Text.Trim
        objEntidad.NSRMTU = Me.txtSerieMotor.Text.Trim
        objEntidad.FFBRUN = IIf(Me.txtFechaFabricacion.Text.Trim = "", 0, Me.txtFechaFabricacion.Text.Trim)
        objEntidad.TCLRUN = Me.txtColorUnidad.Text
        objEntidad.TCRRUN = Me.txtCarroceriaUnidad.Text.Trim
        objEntidad.NCPCRU = IIf(Me.txtCapCargaUnidad.Text.Trim = "", 0, Me.txtCapCargaUnidad.Text.Trim)
        objEntidad.CTITRA = IIf(Me.txtCodigoTipoTracto.Codigo = "", 0, Me.txtCodigoTipoTracto.Codigo)
        objEntidad.QPSOTR = IIf(Me.txtPesoTracto.Text.Trim = "", 0, Me.txtPesoTracto.Text.Trim)
        objEntidad.TMRCTR = Me.txtMarcaModelo.Text.Trim
        objEntidad.NRGMT1 = Me.txtNumEmpadMTC.Text.Trim
        objEntidad.NTERPM = Me.txtNroRPM.Text.Trim
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = cmbCompania.SelectedValue

        Dim v_NPLCUN As String = objEntidad.NPLCUN
        objEntidad = objTracto.Registrar_Tracto(objEntidad)

        If objEntidad.NPLCUN = "-1" Then ' -1 : El tracto existe en la tabla
            objEntidad.NPLCUN = v_NPLCUN
            objEntidad.CULUSA = objEntidad.CUSCRT
            objEntidad.FULTAC = objEntidad.FCHCRT
            objEntidad.HULTAC = objEntidad.HRACRT
            objEntidad.NTRMNL = objEntidad.NTRMCR
            objEntidad = objTracto.Modificar_Tracto(objEntidad)
        End If
        'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        ''Estado_Controles(gEnum_Mantenimiento)
        'EstadoBoton(gEnum_Mantenimiento)
        Listar_Vehiculos()
        'If objEntidad.NPLCUN = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        '    Listar_Vehiculos()
        'End If

    End Sub

    Public Sub Modificar()
        Dim objEntidad As New Tracto
    Dim objTracto As New Tracto_BLL


        objEntidad.NPLCUN = Me.txtNumPlacaUnidad.Text.Trim
        objEntidad.NEJSUN = IIf(Me.txtNumEjes.Text.Trim = "", 0, Me.txtNumEjes.Text.Trim)
        objEntidad.NSRCHU = Me.txtNumChasis.Text.Trim
        objEntidad.NSRMTU = Me.txtSerieMotor.Text.Trim
        objEntidad.FFBRUN = IIf(Me.txtFechaFabricacion.Text.Trim = "", 0, Me.txtFechaFabricacion.Text.Trim)
        objEntidad.TCLRUN = Me.txtColorUnidad.Text.Trim
        objEntidad.TCRRUN = Me.txtCarroceriaUnidad.Text.Trim
        objEntidad.NCPCRU = IIf(Me.txtCapCargaUnidad.Text.Trim = "", 0, Me.txtCapCargaUnidad.Text.Trim)
    objEntidad.CTITRA = Me.txtCodigoTipoTracto.Codigo
        objEntidad.QPSOTR = IIf(Me.txtPesoTracto.Text.Trim = "", 0, Me.txtPesoTracto.Text.Trim)
        objEntidad.TMRCTR = Me.txtMarcaModelo.Text.Trim
        objEntidad.NRGMT1 = Me.txtNumEmpadMTC.Text.Trim
        objEntidad.NTERPM = Me.txtNroRPM.Text.Trim
    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

    objEntidad = objTracto.Modificar_Tracto(objEntidad)
        'Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL

        ''Estado_Controles(gEnum_Mantenimiento)
        'EstadoBoton(gEnum_Mantenimiento)

        Listar_Vehiculos()




        'If objEntidad.NPLCUN = "0" Then
        '  HelpClass.ErrorMsgBox()
        '  Exit Sub
        '    Else
        '        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        '        Listar_Vehiculos()
        'End If

  End Sub

    Public Sub Eliminar()
        Dim objEntidad As New Tracto
        Dim objTracto As New Tracto_BLL

        objEntidad.NPLCUN = Me.txtNumPlacaUnidad.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        objEntidad = objTracto.Eliminar_Tracto(objEntidad)

        'Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL

        ''Estado_Controles(False)
        'EstadoBoton(gEnum_Mantenimiento)
        Listar_Vehiculos()

        'If objEntidad.NPLCUN = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        '    Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        '    Listar_Vehiculos()
        'End If

    End Sub

    Public Sub Listar_Vehiculos()
        Dim objTracto As New Tracto_BLL
        Dim objEntidad As New Tracto
        objEntidad.NPLCUN = Me.txtBuscar.Text.Trim
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.PAGESIZE = UcPaginacion1.PageSize
        objEntidad.PAGENUMBER = UcPaginacion1.PageNumber
        Dim dt As New DataTable
        Dim TotalPag As Decimal = 0
        dt = objTracto.Buscar_Tracto_Paginado(objEntidad, TotalPag)
        'Me.gwdDatos.DataSource = HelpClass.GetDataSetNative(objTracto.Busca_Tracto(objEntidad))
        Me.gwdDatos.DataSource = dt
        If gwdDatos.Rows.Count Then
            UcPaginacion1.PageCount = TotalPag
        End If

        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        'Estado_Controles(False)
        EstadoBoton(gEnum_Mantenimiento)

        '
        'Public Function Buscar_Tracto_Paginado(ByVal objEntidad As Tracto, ByRef TotalPaginas As Decimal) As List(Of Tracto)

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            'If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            '    MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
            'Else
            '    Listar_Vehiculos()
            'End If
            Listar_Vehiculos()
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
            Me.txtNumPlacaUnidad.Enabled = True
        Else
            Me.txtNumPlacaUnidad.Enabled = False
        End If
        Me.txtCodigoTipoTracto.Enabled = lbool_estado
        Me.txtCapCargaUnidad.Enabled = lbool_estado
        Me.txtCarroceriaUnidad.Enabled = lbool_estado
        Me.txtColorUnidad.Enabled = lbool_estado
        Me.txtFechaFabricacion.Enabled = lbool_estado
        Me.txtMarcaModelo.Enabled = lbool_estado
        Me.txtNumChasis.Enabled = lbool_estado
        Me.txtNumEjes.Enabled = lbool_estado
        Me.txtNumEmpadMTC.Enabled = lbool_estado
        Me.txtPesoTracto.Enabled = lbool_estado
        Me.txtSerieMotor.Enabled = lbool_estado
        Me.txtNroRPM.Enabled = lbool_estado


    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            EstadoBoton(gEnum_Mantenimiento)
            'btnNuevo.Enabled = False
            'btnGuardar.Text = "Guardar"
            'btnGuardar.Enabled = True
            'btnCancelar.Enabled = True
            'btnEliminar.Enabled = False
            Limpiar_Textos()
            'Estado_Controles(True)
            'Cargar_ComboTipoTracto()
            'Listar_Vehiculos()
            dgvHistorial.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

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

    Private Function validarTracto() As Integer
        If txtNumPlacaUnidad.Text = "" Then
            MsgBox("Ingrese la placa.", MsgBoxStyle.Exclamation)
            Return 0
        ElseIf txtCodigoTipoTracto.Codigo = "" Then
            MsgBox("Debe seleccionar el tipo de tracto.", MsgBoxStyle.Exclamation)
            Return 0
        End If
        Return 1
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                If validarTracto() = 1 Then
                    Registrar()
                    'AccionCancelar()
                    'Estado_Botones_Ultimo()
                End If

            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If validarTracto() = 1 Then
                    Modificar()
                    'Estado_Botones_Ultimo()
                    'AccionCancelar()
                End If
                'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then 'Or Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL Then
                '    btnGuardar.Text = "Guardar"
                '    Me.Estado_Controles(True)
                '    btnNuevo.Enabled = False
                '    btnCancelar.Enabled = True
                '    btnEliminar.Enabled = False
                '    Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub AccionCancelar()

    '    If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
    '        Limpiar_Textos()
    '        Estado_Controles(False)
    '        'If Me.gwdDatos.Rows.Count > 0 Then
    '        '    Me.gwdDatos.CurrentRow.Selected = False
    '        'End If
    '    ElseIf gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '        Estado_Controles(False)
    '        'If Me.gwdDatos.Rows.Count > 0 Then
    '        '    Me.gwdDatos.CurrentRow.Selected = False
    '        'End If
    '    End If

    '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '    EstadoBoton(gEnum_Mantenimiento)
    '    Estado_Controles(False)
    '    gwdDatos_SelectionChanged(Nothing, Nothing)
    '    'btnNuevo.Enabled = True
    '    'btnGuardar.Enabled = False
    '    'btnCancelar.Enabled = False
    '    'btnEliminar.Enabled = False

    '    gwdDatos_SelectionChanged(Nothing, Nothing)
    'End Sub

    'Private Sub Estado_Botones_Ultimo()
    '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '    btnNuevo.Enabled = True
    '    ' btnGuardar.Enabled = False
    '    btnCancelar.Enabled = False
    '    ' btnEliminar.Enabled = False
    '    Estado_Controles(False)
    'End Sub
    'Private Sub Listar_Detalles()

    'End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            If Me.txtNumPlacaUnidad.Text <> "" Then
                Dim objEntidad As New Tracto
                Dim objTranspoTracto As New TransportistaTracto_BLL
                Dim tieneDetalles As Boolean = False
                objEntidad.NPLCUN = txtNumPlacaUnidad.Text.Trim
                objEntidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                tieneDetalles = objTranspoTracto.Listar_Transportista_x_Tracto(objEntidad).Count > 0

                If tieneDetalles Then
                    If MsgBox("Este tracto esta asignado a un tranportista. Confirma que desea eliminarlo?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                        Eliminar()
                        'Estado_Botones_Ultimo()
                        'AccionCancelar()
                        'Limpiar_Textos()
                        'dgvHistorial.DataSource = Nothing
                    End If
                Else
                    If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                        Eliminar()
                        'Estado_Botones_Ultimo()
                        'AccionCancelar()
                        'Limpiar_Textos()
                        'dgvHistorial.DataSource = Nothing
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        Try
            'If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            '    MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Information)
            '    e.Handled = True
            'Else
            '    If (Asc(e.KeyChar) = 13) Then
            '        Listar_Vehiculos()
            '    End If

            'End If
            If (Asc(e.KeyChar) = 13) Then
                Listar_Vehiculos()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub gwdDatos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellChanged
    '    Try
    '        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

    '        If Me.gwdDatos.RowCount < 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
    '            Exit Sub
    '        End If

    '        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
    '            If Me.gwdDatos.Rows.Count > 0 Then
    '                Me.gwdDatos.CurrentRow.Selected = True
    '            End If
    '            MsgBox("Debe guardar el nuevo tracto o cancelarlo.", MsgBoxStyle.Exclamation)
    '            Exit Sub
    '        End If

    '        'Marcando el estado de Edición
    '        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    '        btnGuardar.Text = "Modificar"
    '        btnGuardar.Enabled = True
    '        btnEliminar.Enabled = True

    '        Limpiar_Textos()

    '        Dim olbeEntidad As New List(Of Tracto)
    '        Dim obeEntidad As New Tracto
    '        Dim objTracto As New Tracto_BLL
    '        obeEntidad.NPLCUN = gwdDatos.CurrentRow.Cells("NumeroPlacaUnidad").Value
    '        obeEntidad.CCMPN = Me.cmbCompania.SelectedValue
    '        olbeEntidad = objTracto.Obtener_Tracto(obeEntidad)
    '        If olbeEntidad.Count = 0 Then Exit Sub
    '        Me.txtNumPlacaUnidad.Text = olbeEntidad.Item(0).NPLCUN
    '        Me.txtNumEjes.Text = olbeEntidad.Item(0).NEJSUN
    '        Me.txtNumChasis.Text = olbeEntidad.Item(0).NSRCHU
    '        Me.txtSerieMotor.Text = olbeEntidad.Item(0).NSRMTU
    '        Me.txtFechaFabricacion.Text = olbeEntidad.Item(0).FFBRUN
    '        Me.txtColorUnidad.Text = olbeEntidad.Item(0).TCLRUN
    '        Me.txtCarroceriaUnidad.Text = olbeEntidad.Item(0).TCRRUN
    '        Me.txtCapCargaUnidad.Text = olbeEntidad.Item(0).NCPCRU
    '        If olbeEntidad.Item(0).CTITRA.Trim.Equals("") Then
    '            Me.txtCodigoTipoTracto.Limpiar()
    '        Else
    '            Me.txtCodigoTipoTracto.Codigo = olbeEntidad.Item(0).CTITRA
    '        End If
    '        Me.txtPesoTracto.Text = olbeEntidad.Item(0).QPSOTR
    '        Me.txtMarcaModelo.Text = olbeEntidad.Item(0).TMRCTR
    '        Me.txtNumEmpadMTC.Text = olbeEntidad.Item(0).NRGMT1
    '        Me.txtNroRPM.Text = olbeEntidad.Item(0).NTERPM

    '        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Tracto / Placa: " & olbeEntidad.Item(0).NPLCUN

    '        Listar_Transportista_X_Vehiculo()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    '    Try
    '        If Me.gwdDatos.Rows.Count > 0 Then
    '            Me.gwdDatos.CurrentRow.Selected = True
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub txtNumEjes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumEjes.KeyPress, txtFechaFabricacion.KeyPress, txtCapCargaUnidad.KeyPress, txtPesoTracto.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case Else : e.Handled = True
        End Select
    End Sub

    'Private Sub btnConsultaVehicular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.gwdDatos.CurrentCellAddress.Y < 0 Then
    '        Exit Sub
    '    End If
    'End Sub

    'Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
    '    If bolBuscar Then
    '        '  Me.btnBuscar_Click(Nothing, Nothing)
    '        InicializarFormulario()
    '    End If
    'End Sub
    'Private Sub InicializarFormulario()
    '    Me.Limpiar_Textos()

    '    Estado_Controles(False)
    '    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    '    EstadoBoton(gEnum_Mantenimiento)
    '    'btnGuardar.Enabled = False
    '    'btnCancelar.Enabled = False
    '    'btnEliminar.Enabled = False
    '    Cargar_ComboTipoTracto()
    '    Me.gwdDatos.DataSource = Nothing

    'End Sub

    Private Sub Listar_Transportista_X_Vehiculo()
        Dim oTransportistaTracto_BL As New TransportistaTracto_BLL
        Dim oListTransportistaTracto As New List(Of TransportistaTracto)
        Dim oTransportistaTracto As New TransportistaTracto
        oTransportistaTracto.CCMPN = Me.cmbCompania.SelectedValue
        oTransportistaTracto.NPLCUN = gwdDatos.CurrentRow.Cells("NumeroPlacaUnidad").Value
        oListTransportistaTracto = oTransportistaTracto_BL.Listar_Transportista_X_Vehiculo(oTransportistaTracto)
        dgvHistorial.DataSource = oListTransportistaTracto
    End Sub
#Region "COMPAÑIA "

    Private Sub Cargar_Compania()
        Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
        objCompaniaBLL.Crea_Lista()
        'bolBuscar = False
        cmbCompania.DataSource = objCompaniaBLL.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
        'bolBuscar = True

        'cmbCompania.SelectedIndex = 0
        'cmbCompania.SelectedValue = "EZ"
        'If cmbCompania.SelectedIndex = -1 Then
        '    cmbCompania.SelectedIndex = 0
        'End If

        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub

#End Region


    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            'Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            EstadoBoton(gEnum_Mantenimiento)

            'Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

            'If Me.gwdDatos.RowCount < 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            '    Exit Sub
            'End If

            'If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            '    'If Me.gwdDatos.Rows.Count > 0 Then
            '    '    Me.gwdDatos.CurrentRow.Selected = True
            '    'End If
            '    MsgBox("Debe guardar el nuevo tracto o cancelarlo.", MsgBoxStyle.Exclamation)
            '    Exit Sub
            'End If

            'Marcando el estado de Edición
            'Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
            'btnGuardar.Text = "Modificar"
            'btnGuardar.Enabled = True
            'btnEliminar.Enabled = True

            Limpiar_Textos()

            'Dim olbeEntidad As New List(Of Tracto)
            'Dim obeEntidad As New Tracto
            'Dim objTracto As New Tracto_BLL
            'obeEntidad.NPLCUN = gwdDatos.CurrentRow.Cells("NumeroPlacaUnidad").Value
            'obeEntidad.CCMPN = Me.cmbCompania.SelectedValue
            'olbeEntidad = objTracto.Obtener_Tracto(obeEntidad)
            'If olbeEntidad.Count = 0 Then Exit Sub
            'Me.txtNumPlacaUnidad.Text = olbeEntidad.Item(0).NPLCUN
            Me.txtNumPlacaUnidad.Text = gwdDatos.CurrentRow.Cells("NumeroPlacaUnidad").Value.ToString.Trim
            'Me.txtNumEjes.Text = olbeEntidad.Item(0).NEJSUN
            Me.txtNumEjes.Text = gwdDatos.CurrentRow.Cells("NumEjes").Value
            'Me.txtNumChasis.Text = olbeEntidad.Item(0).NSRCHU
            Me.txtNumChasis.Text = ("" & gwdDatos.CurrentRow.Cells("NumChasis").Value).ToString.Trim
            'Me.txtSerieMotor.Text = olbeEntidad.Item(0).NSRMTU
            Me.txtSerieMotor.Text = gwdDatos.CurrentRow.Cells("NumSerieMotor").Value.ToString.Trim
            'Me.txtFechaFabricacion.Text = olbeEntidad.Item(0).FFBRUN
            Me.txtFechaFabricacion.Text = gwdDatos.CurrentRow.Cells("FechaFabricacion").Value
            'Me.txtColorUnidad.Text = olbeEntidad.Item(0).TCLRUN
            Me.txtColorUnidad.Text = ("" & gwdDatos.CurrentRow.Cells("ColorUnidad").Value).ToString.Trim
            'Me.txtCarroceriaUnidad.Text = olbeEntidad.Item(0).TCRRUN
            Me.txtCarroceriaUnidad.Text = ("" & gwdDatos.CurrentRow.Cells("CarroceriaUnidad").Value).ToString.Trim
            'Me.txtCapCargaUnidad.Text = olbeEntidad.Item(0).NCPCRU
            Me.txtCapCargaUnidad.Text = gwdDatos.CurrentRow.Cells("CapacidadCargaUnd").Value
            'If olbeEntidad.Item(0).CTITRA.Trim.Equals("") Then
            '    Me.txtCodigoTipoTracto.Limpiar()
            'Else
            '    Me.txtCodigoTipoTracto.Codigo = olbeEntidad.Item(0).CTITRA
            'End If
            If ("" & gwdDatos.CurrentRow.Cells("CodigoTipoTracto").Value).ToString.Trim <> "" Then
                Me.txtCodigoTipoTracto.Codigo = ("" & gwdDatos.CurrentRow.Cells("CodigoTipoTracto").Value).ToString.Trim
            Else
                Me.txtCodigoTipoTracto.Limpiar()
            End If
            'TDETRA
            'CodigoTipoTracto
            'Me.txtPesoTracto.Text = olbeEntidad.Item(0).QPSOTR
            Me.txtPesoTracto.Text = gwdDatos.CurrentRow.Cells("PesoTractor").Value
            'Me.txtMarcaModelo.Text = olbeEntidad.Item(0).TMRCTR
            Me.txtMarcaModelo.Text = ("" & gwdDatos.CurrentRow.Cells("MarcaModelo").Value).ToString.Trim
            'Me.txtNumEmpadMTC.Text = olbeEntidad.Item(0).NRGMT1
            Me.txtNumEmpadMTC.Text = ("" & gwdDatos.CurrentRow.Cells("NumEmpadronamientoMTC").Value).ToString.Trim
            'Me.txtNroRPM.Text = olbeEntidad.Item(0).NTERPM
            Me.txtNroRPM.Text = gwdDatos.CurrentRow.Cells("NTERPM").Value

            'Estado_Controles(False)
            'EstadoBoton(MANTENIMIENTO.NEUTRAL)

            Me.HeaderDatos.ValuesPrimary.Heading = "Información de Tracto / Placa: " & Me.txtNumPlacaUnidad.Text

            Listar_Transportista_X_Vehiculo()
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            EstadoBoton(gEnum_Mantenimiento)
            'Estado_Controles(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub cmbCompania_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectionChangeCommitted
    '    Try
    '        InicializarFormulario()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub UcPaginacion1_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
        Try
            Listar_Vehiculos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
