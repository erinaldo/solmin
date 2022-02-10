Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data

'****************************************************************************************************
'** Autor: Rafael Gamboa
'** Descripción: capa de presentación.
'****************************************************************************************************

Public Class frmVacunas
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Private Sub frmVacunas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        Limpiar_Controles()
        Estado_Controles(True)
        txtNombreVacuna.Focus()
        Listar()
    End Sub

    Private Function validarVacuna() As Integer
        If Me.txtNombreVacuna.Text = "" Then
            MsgBox("Debe ingresar una vacuna.", MsgBoxStyle.Exclamation)
            Return 0
        End If
        Return 1
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            If validarVacuna() = 1 Then
                Nuevo_Registro()
                AccionCancelar()
                txtNombreVacuna.Focus()
            End If

        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.txtCodigoVacuna.Text <> "" And validarVacuna() = 1 Then
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        AccionCancelar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
            If Me.txtCodigoVacuna.Text <> "" Then
                If Me.txtCodigoVacuna.Text <> "0" Then
                    Dim objEntidad As New Vacunas
                    Dim obj As New Vacunas_BLL
                    objEntidad.NCOVAC = Me.txtCodigoVacuna.Text
                    objEntidad.CULUSA = MainModule.USUARIO
                    objEntidad.FULTAC = HelpClass.TodayNumeric
                    objEntidad.HULTAC = HelpClass.NowNumeric
                    objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    objEntidad = obj.Eliminar_Vacunas(objEntidad)
                    If objEntidad.NCOVAC = 0 Then
                        HelpClass.ErrorMsgBox()
                        Exit Sub
                    End If
                End If
                Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                Listar()
                AccionCancelar()
            End If
        End If
    End Sub

    Private Sub Nuevo_Registro()
        'Procedimiento para registrar una nueva vacuna
        Dim objEntidad As New Vacunas
        Dim obj As New Vacunas_BLL

        objEntidad.NOMVAC = Me.txtNombreVacuna.Text
        objEntidad.TOBS = Me.txtObservacionesVacuna.Text
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = obj.Registrar_Vacunas(objEntidad)

        If objEntidad.NCOVAC = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Listar()
        End If
    End Sub

    Private Sub Modificar_Registro()
        'Procedimiento para modificar una vacuna
        Dim objEntidad As New Vacunas
        Dim obj As New Vacunas_BLL

        objEntidad.NCOVAC = Me.txtCodigoVacuna.Text
        objEntidad.NOMVAC = Me.txtNombreVacuna.Text
        objEntidad.TOBS = Me.txtObservacionesVacuna.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = obj.Modificar_Vacunas(objEntidad)

        If objEntidad.NCOVAC = 0 Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Listar()
        End If
    End Sub

    Private Sub Listar()
        Dim obj As New Vacunas_BLL
        Dim objEntidad As New Vacunas

        Me.gwdDatos.AutoGenerateColumns = False
        objEntidad.NOMVAC = Me.txtFiltroVacuna.Text
        objEntidad.CCMPN = CCMPN
        Me.gwdDatos.DataSource = obj.Listar_Vacunas(objEntidad)
    End Sub

    Private Sub Limpiar_Controles()
        txtCodigoVacuna.Text = "0"
        txtNombreVacuna.Text = ""
        txtObservacionesVacuna.Text = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de vacuna"
    End Sub

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtNombreVacuna.Enabled = lbool_Estado
        Me.txtObservacionesVacuna.Enabled = lbool_Estado
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

        'Marcando el estado de Edicion
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        btnGuardar.Text = "Modificar"
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True

        Limpiar_Controles()
        Me.txtCodigoVacuna.Text = Me.gwdDatos.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtNombreVacuna.Text = Me.gwdDatos.Item(1, lint_indice).Value.ToString().Trim()
        Me.txtObservacionesVacuna.Text = Me.gwdDatos.Item(2, lint_indice).Value.ToString().Trim()

        Me.HeaderDatos.ValuesPrimary.Heading = "Información de vacuna / Nombre : " & txtNombreVacuna.Text.Trim
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
        If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
        Else
            Listar()
        End If
    End Sub

    Private Sub txtFiltroVacuna_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroVacuna.KeyPress
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Information)
            e.Handled = True
        End If
    End Sub
End Class
