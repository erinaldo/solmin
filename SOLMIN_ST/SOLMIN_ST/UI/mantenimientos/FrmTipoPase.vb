'*********************************************************************'
'** Autor: Juan De Dios Leon                                        **'
'** Fecha de Creación: 09/09/2009                                   **'
'** Descripción: CAPA DE UI.                                        **'
'*********************************************************************'
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports System.Collections.Generic

Public Class FrmTipoPase
  Private gEnum_Mantenimiento As MANTENIMIENTO

  Private Sub FrmTipoPase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.Limpiar_Controles()
        Me.Estado_Controles(False)
        Me.gwdDatos.AutoGenerateColumns = False
        Me.Listar()
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEliminar.Enabled = False
        Me.Limpiar_Controles()
        Me.Estado_Controles(True)
        Me.Listar()
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            If Me.txtNombre.Text <> "" Then
                Me.Nuevo_Registro()
                Me.AccionCancelar()
            End If
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.txtCodigo.Text <> "" Then
                Me.Modificar_Registro()
                Me.AccionCancelar()
            End If
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
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
        Me.Limpiar_Controles()
        Me.Estado_Controles(False)
        If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentRow.Selected = False
        End If
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnEliminar.Enabled = False
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.AccionCancelar()
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
            If Me.txtCodigo.Text <> "" Then
                Dim objEntidad As New TipoPaseConductor
                Dim obj As New TipoPaseConductor_BLL
                objEntidad.NCOPSE = Me.txtCodigo.Text.Trim
                objEntidad.CULUSA = MainModule.USUARIO
                objEntidad.FULTAC = HelpClass.TodayNumeric
                objEntidad.HULTAC = HelpClass.NowNumeric
                objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                objEntidad = obj.Elimina_Tipo_Pases(objEntidad)
                If objEntidad.NCOPSE = 0 Then
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                End If
                Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                Me.Listar()
                Me.AccionCancelar()
            End If
        End If
  End Sub

  Private Sub Nuevo_Registro()
        Dim objEntidad As New TipoPaseConductor
        Dim obj As New TipoPaseConductor_BLL

        objEntidad.NOMPSE = Me.txtNombre.Text.Trim
        objEntidad.TOBS = Me.txtObservacion.Text.Trim
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = obj.Registra_Tipo_Pases(objEntidad)

        If objEntidad.NCOPSE = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.Listar()
        End If
  End Sub

  Private Sub Modificar_Registro()
        Dim objEntidad As New TipoPaseConductor
        Dim obj As New TipoPaseConductor_BLL
        objEntidad.NCOPSE = Me.txtCodigo.Text
        objEntidad.NOMPSE = Me.txtNombre.Text
        objEntidad.TOBS = Me.txtObservacion.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = obj.Modifica_Tipo_Pases(objEntidad)
        If objEntidad.NCOPSE = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.Listar()
        End If
  End Sub

  Private Sub Listar()
        Dim obj As New TipoPaseConductor_BLL
        Dim objEntidad As New TipoPaseConductor

        Me.gwdDatos.AutoGenerateColumns = False
        objEntidad.NOMPSE = txtBuscar.Text.Trim
        Me.gwdDatos.DataSource = obj.Lista_Tipo_Pases(objEntidad)
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim obj As New TipoPaseConductor_BLL
        Dim objEntidad As New TipoPaseConductor
        objEntidad.NOMPSE = Me.txtBuscar.Text.Trim
        Me.gwdDatos.DataSource = obj.Lista_Tipo_Pases(objEntidad)
    End Sub

  Private Sub Limpiar_Controles()
        Me.txtCodigo.Text = "0"
        Me.txtNombre.Text = ""
        Me.txtObservacion.Text = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Tipo Pase / Nombre : "
    End Sub

  Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtCodigo.Enabled = lbool_Estado
        Me.txtNombre.Enabled = lbool_Estado
        Me.txtObservacion.Enabled = lbool_Estado
  End Sub
  
  Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

        If e.RowIndex < 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
            MsgBox("Debe guardar el nuevo tipo de pase o cancelarlo.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        Me.btnGuardar.Text = "Modificar"
        Me.btnGuardar.Enabled = True
        Me.btnEliminar.Enabled = True

        Me.Limpiar_Controles()
        Me.txtCodigo.Text = Me.gwdDatos.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtNombre.Text = Me.gwdDatos.Item(1, lint_indice).Value.ToString().Trim()
        Me.txtObservacion.Text = Me.gwdDatos.Item(2, lint_indice).Value.ToString().Trim()
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Tipo Pase / Nombre : " & Me.txtNombre.Text.Trim
    End Sub

  Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
        Catch ex As Exception
        End Try
  End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
            e.Handled = True
        End If
    End Sub
End Class
