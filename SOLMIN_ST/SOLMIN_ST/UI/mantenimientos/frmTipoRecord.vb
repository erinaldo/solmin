'****************************************************************************************************
'** Autor: Juan De Dios
'** Fecha de Creación: 09/09/2009  
'** Descripción: capa de presentación.
'****************************************************************************************************
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data

Public Class frmTipoRecord
  Private gEnum_Mantenimiento As MANTENIMIENTO

  Private Sub frmTipoRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        'gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        'Me.btnNuevo.Enabled = False
        'Me.btnGuardar.Text = "Guardar"
        'Me.btnGuardar.Enabled = True
        'Me.btnCancelar.Enabled = True
        'Me.btnEliminar.Enabled = False
        'Me.Limpiar_Controles()
        'Me.Estado_Controles(True)
        'Me.Listar()
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
        '    If Me.txtDescripcionTipoRecord.Text <> "" Then
        '        Me.Nuevo_Registro()
        '        Me.AccionCancelar()
        '    End If
        'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
        '    If txtCodigoTipoRecord.Text <> "" Then
        '        Me.Modificar_Registro()
        '        Me.AccionCancelar()
        '    End If
        'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
        '    Me.Estado_Controles(True)
        '    btnGuardar.Text = "Guardar"
        '    btnNuevo.Enabled = False
        '    btnCancelar.Enabled = True
        '    btnEliminar.Enabled = False
        '    Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        'End If
  End Sub

  Private Sub AccionCancelar()
        'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        'Me.Limpiar_Controles()
        'Me.Estado_Controles(False)
        'If Me.gwdDatos.Rows.Count > 0 Then
        '    Me.gwdDatos.CurrentRow.Selected = False
        'End If
        'Me.btnNuevo.Enabled = True
        'Me.btnGuardar.Enabled = False
        'Me.btnCancelar.Enabled = False
        'Me.btnEliminar.Enabled = False
    End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Me.AccionCancelar()
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        'If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
        '  If Me.txtCodigoTipoRecord.Text <> "" Then

        '    Dim objEntidad As New TipoRecord
        '    Dim obj As New TipoRecord_BLL
        '    objEntidad.STPRCD = Me.txtCodigoTipoRecord.Text.Trim
        '    objEntidad.CULUSA = "RORTIZP" 'MainModule.USUARIO
        '    objEntidad.FULTAC = HelpClass.TodayNumeric
        '    objEntidad.HULTAC = HelpClass.NowNumeric
        '    objEntidad.NTRMNL = HelpClass.NombreMaquina
        '            ' objEntidad = obj.Eliminar_Tipo_Record(objEntidad)
        '    If objEntidad.STPRCD = "0" Then
        '      HelpClass.ErrorMsgBox()
        '      Exit Sub
        '    End If
        '    Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        '    Me.Listar()
        '    Me.AccionCancelar()
        '  End If
        'End If
  End Sub

  Private Sub Nuevo_Registro()
        'Dim objEntidad As New TipoRecord
        'Dim obj As New TipoRecord_BLL
        'objEntidad.STPRCD = Me.txtCodigoTipoRecord.Text.Trim
        'objEntidad.TTPRCD = Me.txtDescripcionTipoRecord.Text.Trim
        'objEntidad.CUSCRT = "RORTIZP" 'MainModule.USUARIO
        'objEntidad.FCHCRT = HelpClass.TodayNumeric
        'objEntidad.HRACRT = HelpClass.NowNumeric
        'objEntidad.NTRMCR = HelpClass.NombreMaquina
        '' objEntidad = obj.Registrar_Tipo_Record(objEntidad)
        'If objEntidad.STPRCD = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'ElseIf objEntidad.STPRCD = "-1" Then
        '    HelpClass.MsgBox("Este código ya existe")
        'Else
        '    Me.Listar()
        'End If
  End Sub

    Private Sub Modificar_Registro()
        'Dim objEntidad As New TipoRecord
        'Dim obj As New TipoRecord_BLL
        'objEntidad.STPRCD = Me.txtCodigoTipoRecord.Text
        'objEntidad.TTPRCD = Me.txtDescripcionTipoRecord.Text
        'objEntidad.CULUSA = MainModule.USUARIO
        'objEntidad.FULTAC = HelpClass.TodayNumeric
        'objEntidad.HULTAC = HelpClass.NowNumeric
        'objEntidad.NTRMNL = HelpClass.NombreMaquina
        ''objEntidad = obj.Modificar_Tipo_Record(objEntidad)
        'If objEntidad.STPRCD = "0" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        '    Me.Listar()
        'End If
    End Sub

  Private Sub Listar()
        'Dim obj As New TipoRecord_BLL
        'Dim objEntidad As New TipoRecord
        ' Me.gwdDatos.DataSource = obj.Listar_Tipo_Record(objEntidad)
  End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim obj As New TipoRecord_BLL
        Dim objEntidad As New TipoRecord
        objEntidad.TTPRCD = Me.txtFiltroTipoRecord.Text.Trim
        '  Me.gwdDatos.DataSource = obj.Listar_Tipo_Record(objEntidad)
        Me.Limpiar_Controles()
    End Sub

  Private Sub Limpiar_Controles()
        'Me.txtCodigoTipoRecord.Text = ""
        'Me.txtDescripcionTipoRecord.Text = ""
        'Me.HeaderDatos.ValuesPrimary.Heading = "Información de Tipo Record / Nombre : "
  End Sub

  Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        'Me.txtDescripcionTipoRecord.Enabled = lbool_Estado
        'Me.txtCodigoTipoRecord.Enabled = lbool_Estado
  End Sub

  Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        If e.RowIndex < 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
            MsgBox("Debe guardar la nueva vacuna o cancelarla.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        Me.btnGuardar.Text = "Modificar"
        Me.btnGuardar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.Limpiar_Controles()
        Me.txtCodigoTipoRecord.Text = Me.gwdDatos.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtDescripcionTipoRecord.Text = Me.gwdDatos.Item(1, lint_indice).Value.ToString().Trim()
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Tipo Record / Nombre : " & Me.txtDescripcionTipoRecord.Text.Trim
  End Sub

  Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        'Try
        '    If Me.gwdDatos.Rows.Count > 0 Then
        '        Me.gwdDatos.CurrentRow.Selected = False
        '    End If
        'Catch ex As Exception
        'End Try
  End Sub
End Class