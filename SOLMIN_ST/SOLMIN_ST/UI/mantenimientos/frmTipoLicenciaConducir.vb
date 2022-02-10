Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data

'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 16/07/2009 
'** Descripción: capa de presentación.
'****************************************************************************************************

Public Class frmTipoLicenciaConducir
    Private gEnum_Mantenimiento As MANTENIMIENTO

    Private Sub frmTipoLicenciaConducir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Pone el flag en neutral
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False

        'Limpia los controles
        Me.Limpiar_Controles()
        Estado_Controles(False)
        Me.gwdDatos.AutoGenerateColumns = False
        Listar()
    End Sub

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtCategoriaLicenciaConducir.Enabled = lbool_Estado
        Me.txtClaseTipoCategoria.Enabled = lbool_Estado
    End Sub

    Private Sub Limpiar_Controles()
        txtCodigoTipoLicencia.Text = 0
        txtCategoriaLicenciaConducir.Text = ""
        txtClaseTipoCategoria.Text = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Tipo de Licencia de Conducir."
    End Sub

    Private Sub Listar()
        Dim objTipoLicenciaConducir As New TipoLicenciaConducir_BLL
        Dim objEntidad As New TipoLicenciaConducir

        Me.gwdDatos.AutoGenerateColumns = False
        objEntidad.CCATLI = Me.txtFiltroLicenciaConducir.Text
        Me.gwdDatos.DataSource = objTipoLicenciaConducir.Listar_Tipo_Licencia_Conducir(objEntidad)
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
        txtCategoriaLicenciaConducir.Focus()
        Listar()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            If Me.txtCategoriaLicenciaConducir.Text <> "" Then
                'codigo autogenerado en el procedure
                Nuevo_Registro()
                AccionCancelar()
                txtCategoriaLicenciaConducir.Focus()
            End If
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.txtCodigoTipoLicencia.Text <> "" Then
                Modificar_Registro()
                AccionCancelar()
            End If
            'pulso el boton 'modificar'
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        AccionCancelar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.txtCodigoTipoLicencia.Text <> "" Then
            If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                If Me.txtCodigoTipoLicencia.Text <> "0" Then
                    Dim objEntidad As New TipoLicenciaConducir
                    Dim obj As New TipoLicenciaConducir_BLL

                    objEntidad.NCLICO = Me.txtCodigoTipoLicencia.Text
                    objEntidad.CULUSA = MainModule.USUARIO
                    objEntidad.FULTAC = HelpClass.TodayNumeric
                    objEntidad.HULTAC = HelpClass.NowNumeric
                    objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    objEntidad = obj.Eliminar_Tipo_Licencia_Conducir(objEntidad)
                    If objEntidad.NCLICO = 0 Then
                        HelpClass.ErrorMsgBox()
                        Exit Sub
                    End If
                End If
                Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                Listar()
                Limpiar_Controles()
                Me.Estado_Controles(False)
                AccionCancelar()
            End If
        Else
            MsgBox("Seleccione un registro.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Nuevo_Registro()
        'Procedimiento para registrar una nuevo tipo de licencia de conducir
        Dim objEntidad As New TipoLicenciaConducir
        Dim objTipoAcoplado As New TipoLicenciaConducir_BLL

        objEntidad.CCATLI = Me.txtCategoriaLicenciaConducir.Text
        objEntidad.TCATLI = Me.txtClaseTipoCategoria.Text
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objTipoAcoplado.Registrar_Tipo_Licencia_Conducir(objEntidad)

        If objEntidad.NCLICO = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Listar()
        End If
    End Sub

    Private Sub Modificar_Registro()
        'Procedimiento para registrar una nueva solicitud de transporte
        Dim objEntidad As New TipoLicenciaConducir
        Dim objTipoAcoplado As New TipoLicenciaConducir_BLL

        objEntidad.NCLICO = Me.txtCodigoTipoLicencia.Text
        objEntidad.CCATLI = Me.txtCategoriaLicenciaConducir.Text
        objEntidad.TCATLI = Me.txtClaseTipoCategoria.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objTipoAcoplado.Modificar_Tipo_Licencia_Conducir(objEntidad)

        If objEntidad.NCLICO = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If

        Listar()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
        Else
            Listar()
        End If
    End Sub

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        If e.RowIndex < 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
            MsgBox("Debe guardar el nuevo tipo de licencia o cancelarlo.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'Marcando el estado de Edicion
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        btnGuardar.Text = "Modificar"
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True

        Limpiar_Controles()
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Me.txtCodigoTipoLicencia.Text = Me.gwdDatos.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtCategoriaLicenciaConducir.Text = Me.gwdDatos.Item(1, lint_indice).Value.ToString().Trim()
        Me.txtClaseTipoCategoria.Text = Me.gwdDatos.Item(2, lint_indice).Value.ToString().Trim()

        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Tipo de Licencia de Conducir: " & txtCategoriaLicenciaConducir.Text.Trim
    End Sub

    Private Sub txtFiltroLicenciaConducir_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroLicenciaConducir.KeyPress
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Information)
            e.Handled = True
        End If
    End Sub

End Class
