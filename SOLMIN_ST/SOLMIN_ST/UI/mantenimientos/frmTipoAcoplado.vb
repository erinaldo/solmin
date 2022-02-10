Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

'****************************************************************************************************
'** Autor: Rafael Gamboa
'** Descripción: capa de presentación.
'****************************************************************************************************

Public Class frmTipoAcoplado

    Private gEnum_Mantenimiento As MANTENIMIENTO

    Private Sub frmTipoAcoplado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Pone el flag en neutral
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False

        'Limpia los controles
        Me.Limpiar_Controles()
        Estado_Controles(False)

        Me.txtCodigoConfiguracionVehiculo.DataSource = Nothing
        Dim obj As New TipoDatoGeneral_BLL
        Dim lista As New List(Of TipoDatoGeneral)
        lista = obj.Lista_Tipo_Dato_General(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy, "STCFAC")
        txtCodigoConfiguracionVehiculo.DataSource = lista
        txtCodigoConfiguracionVehiculo.ValueMember = "CODIGO_TIPO"
        txtCodigoConfiguracionVehiculo.DisplayMember = "DESC_TIPO"

        Listar()
    End Sub

    Private Sub Listar()

        Dim objTipoAcoplado As New TipoAcoplado_BLL
        Dim objEntidad As New TipoAcoplado

        objEntidad.TDEACP = txtFiltroTipoAcoplado.Text.Trim
        Me.gwdDatos.AutoGenerateColumns = False
        Me.gwdDatos.DataSource = objTipoAcoplado.Listar_Tipo_Acoplado(objEntidad)
        Me.gwdDatos.AutoGenerateColumns = False

      

    End Sub

    Private Sub Limpiar_Controles()
        txtCodigoTipoAcoplado.Text = 0
        'txtCodigoConfiguracionVehiculo.Text = ""
        Me.txtDescripTipoTractoAbrev.Text = ""
        txtDescripcionTipoAcoplado.Text = "" 
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Tipo de Acoplado."

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        Limpiar_Controles()
        Estado_Controles(True)
        txtDescripcionTipoAcoplado.Focus()
    'Listar()
    End Sub

    Public Function validarTipoAcoplado() As Integer
        If txtDescripcionTipoAcoplado.Text = "" Then
            MsgBox("Debe ingresar la descripción del tipo de acoplado.", MsgBoxStyle.Exclamation)
            Return 0
        ElseIf Me.txtCodigoConfiguracionVehiculo.SelectedValue Is Nothing Then
            MsgBox("Debe ingresar la configuración de vehículo", MsgBoxStyle.Exclamation)
            Return 0
        End If
        Return 1
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            If validarTipoAcoplado() = 1 Then
                'codigo autogenerado en el procedure
                Nuevo_Registro()
                AccionCancelar()
            End If

        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If validarTipoAcoplado() = 1 Then
                Modificar_Registro()
                AccionCancelar()
            End If

        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then 'pulso el boton 'modificar'
            Me.Estado_Controles(True)
            btnGuardar.Text = "Guardar"
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            btnEliminar.Enabled = False
            'prepara para la sgte accion del btnGuardar (guardar en BD)
            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        End If
    End Sub

    Private Sub AccionCancelar()
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        Limpiar_Controles()
        Estado_Controles(False)
        If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentRow.Selected = False
        End If
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
        KryptonButton1.Enabled = False
        ImagenTracto.Image = Nothing
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        AccionCancelar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.txtCodigoTipoAcoplado.Text <> "" Then
            If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then

                If Me.txtCodigoTipoAcoplado.Text <> "0" Then
                    Dim objEntidad As New TipoAcoplado
                    Dim objTipoAcoplado As New TipoAcoplado_BLL

                    objEntidad.CTIACP = Me.txtCodigoTipoAcoplado.Text
                    objEntidad.CULUSA = MainModule.USUARIO
                    objEntidad.FULTAC = HelpClass.TodayNumeric
                    objEntidad.HULTAC = HelpClass.NowNumeric
                    objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    objEntidad = objTipoAcoplado.Eliminar_Tipo_Acoplado(objEntidad)
                    If objEntidad.CTIACP = 0 Then
                        HelpClass.ErrorMsgBox()
                        Exit Sub
                    End If
                End If
                Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                Listar()
                AccionCancelar()
            End If
        Else
            MsgBox("Seleccione un registro.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Nuevo_Registro()
        'Procedimiento para registrar una nuevo tipo de acoplado
        Dim objEntidad As New TipoAcoplado
        Dim objTipoAcoplado As New TipoAcoplado_BLL
        objEntidad.CTIACP = 0
        objEntidad.TDEACP = Me.txtDescripcionTipoAcoplado.Text
        objEntidad.TABDES = Me.txtDescripTipoTractoAbrev.Text
        objEntidad.TCNFVH = Me.txtCodigoConfiguracionVehiculo.SelectedValue
        objEntidad.IMGACP = "" 'Me.Imagen.Text
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objTipoAcoplado.Registrar_Tipo_Acoplado(objEntidad)

        If objEntidad.CTIACP = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Listar()
        End If
    End Sub

    Private Sub Modificar_Registro()
        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New TipoAcoplado
        Dim objTipoAcoplado As New TipoAcoplado_BLL

        objEntidad.CTIACP = Me.txtCodigoTipoAcoplado.Text
        objEntidad.TDEACP = Me.txtDescripcionTipoAcoplado.Text
        objEntidad.TABDES = Me.txtDescripTipoTractoAbrev.Text
        objEntidad.TCNFVH = txtCodigoConfiguracionVehiculo.SelectedValue
        objEntidad.IMGACP = ""
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objTipoAcoplado.Modificar_Tipo_Acoplado(objEntidad)

        If objEntidad.CTIACP = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Listar()
        End If
    End Sub

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtCodigoConfiguracionVehiculo.ComboBox.Enabled = lbool_Estado
        Me.txtDescripcionTipoAcoplado.Enabled = lbool_Estado
        Me.txtDescripTipoTractoAbrev.Enabled = lbool_Estado
        Me.KryptonButton1.Enabled = lbool_Estado
    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        
    End Sub

    Private Sub gwdDatos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellChanged
        If Me.gwdDatos.RowCount < 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
            MsgBox("Debe guardar el nuevo tipo de acoplado o cancelarlo.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'Marcando el estado de Edicion
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        btnGuardar.Text = "Modificar"
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True

        Limpiar_Controles()
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

        Me.txtCodigoTipoAcoplado.Text = Me.gwdDatos.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtDescripcionTipoAcoplado.Text = Me.gwdDatos.Item(1, lint_indice).Value.ToString().Trim()
        Me.txtDescripTipoTractoAbrev.Text = Me.gwdDatos.Item(2, lint_indice).Value.ToString().Trim()
        Me.ImagenTracto.Image = LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/acoplado/" & Me.gwdDatos.Item(0, lint_indice).Value.ToString.Trim & ".jpg")

        Me.txtCodigoConfiguracionVehiculo.SelectedIndex = 0
        Me.txtCodigoConfiguracionVehiculo.SelectedValue = Me.gwdDatos.Item(3, lint_indice).Value
     

        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Tipo de Acoplado/ Nombre : " & txtDescripcionTipoAcoplado.Text.Trim
    End Sub

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
        Else
            Listar()
        End If
    End Sub
  
    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        If Me.txtCodigoTipoAcoplado.Text <> "" Then
            Dim objformLoad As New frmUploadImagen
            objformLoad.ShowForm("acoplado", txtCodigoTipoAcoplado.Text & ".jpg", Me)
        End If
    End Sub

    Private Sub txtFiltroTipoAcoplado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroTipoAcoplado.KeyPress
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
            e.Handled = True
        End If
    End Sub

End Class
