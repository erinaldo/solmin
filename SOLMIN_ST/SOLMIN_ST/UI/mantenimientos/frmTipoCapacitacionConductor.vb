Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports System.Data
Imports System.Collections.Generic

'****************************************************************************************************
'** Autor: Rafael Gamboa
'** Descripción: capa de presentación.
'****************************************************************************************************

Public Class frmTipoCapacitacionConductor
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private DataViewTipoCapacitacionConductor As New Data.DataView

    Private Sub frmTipoCapacitacionConductor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Pone el flag en neutral
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False

        Me.Limpiar_Controles()
        Estado_Controles(False)
        Me.gwdDatos.AutoGenerateColumns = False
        Listar()
    End Sub

    Private Sub Listar()
        Dim objTipoCapacitacionConductor As New TipoCapacitacionConductor_BLL
        Dim objEntidad As New TipoCapacitacionConductor
        Me.gwdDatos.AutoGenerateColumns = False
        objEntidad.NOMCPT = Me.txtBuscar.Text
        Me.gwdDatos.DataSource = objTipoCapacitacionConductor.Listar_TipoCapacitacionConductor(objEntidad)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            If Me.txtNombreCapacitacion.Text <> "" Then
                Nuevo_Registro()
                AccionCancelar()
                txtNombreCapacitacion.Focus()
            End If

        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.txtCodigoCapacitacion.Text <> "" Then
                Modificar_Registro()
                AccionCancelar()
            End If

        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then 'pulso el boton 'modificar'
            Me.Estado_Controles(True)
            btnGuardar.Text = "Guardar"
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            btnEliminar.Enabled = False
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
    End Sub

    Private Sub Modificar_Registro()
        Dim objEntidad As New TipoCapacitacionConductor
        Dim objTransportista As New TipoCapacitacionConductor_BLL
        objEntidad.NCOCPT = Me.txtCodigoCapacitacion.Text
        objEntidad.NOMCPT = Me.txtNombreCapacitacion.Text
        objEntidad.TOBS = Me.txtObservaciones.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objTransportista.Modificar_TipoCapacitacionConductor(objEntidad)

        If objEntidad.NCOCPT = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Listar()
        End If
    End Sub

    Private Sub Nuevo_Registro()
        Dim objEntidad As New TipoCapacitacionConductor
        Dim objTipoCapacitacionConductor As New TipoCapacitacionConductor_BLL

        objEntidad.NOMCPT = Me.txtNombreCapacitacion.Text
        objEntidad.TOBS = Me.txtObservaciones.Text
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objTipoCapacitacionConductor.Registrar_TipoCapacitacionConductor(objEntidad)

        If objEntidad.NCOCPT = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Listar()
        End If
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
        txtNombreCapacitacion.Focus()
        Listar()
    End Sub

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtCodigoCapacitacion.Enabled = lbool_Estado
        Me.txtNombreCapacitacion.Enabled = lbool_Estado
        Me.txtObservaciones.Enabled = lbool_Estado
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        accionCancelar()
    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        If e.RowIndex < 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
            MsgBox("Debe guardar el nuevo tipo de capacitación o cancelarlo.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'Marcando el estado de Edicion
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        btnGuardar.Text = "Modificar"
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True

        Limpiar_Controles()

        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Me.txtCodigoCapacitacion.Text = Me.gwdDatos.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtNombreCapacitacion.Text = Me.gwdDatos.Item(1, lint_indice).Value.ToString().Trim()
        Me.txtObservaciones.Text = Me.gwdDatos.Item(2, lint_indice).Value.ToString().Trim()

        Me.HeaderDatos.ValuesPrimary.Heading = "Información de capacitación del conductor / Nombre : " & txtNombreCapacitacion.Text
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.txtCodigoCapacitacion.Text <> "" Then
            If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                Eliminar_TipoCapacitacionConductor()
                AccionCancelar()
            End If
        Else
            MsgBox("Seleccione un registro.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Eliminar_TipoCapacitacionConductor()
        Dim objEntidad As New TipoCapacitacionConductor
        Dim objTipoCapacitacionConductor As New TipoCapacitacionConductor_BLL
        objEntidad.NCOCPT = Me.txtCodigoCapacitacion.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objTipoCapacitacionConductor.Eliminar_TipoCapacitacionConductor(objEntidad)
        If objEntidad.NCOCPT = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Listar()
        End If
    End Sub

    Private Sub Limpiar_Controles()
        Me.txtCodigoCapacitacion.Text = ""
        Me.txtNombreCapacitacion.Text = ""
        Me.txtObservaciones.Text = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de capacitación del conductor"
    End Sub

    Private Sub union(ByVal estado As Boolean)
        Limpiar_Controles()
        Estado_Controles(estado)
    End Sub

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
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

    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
            e.Handled = True
        End If
    End Sub
End Class