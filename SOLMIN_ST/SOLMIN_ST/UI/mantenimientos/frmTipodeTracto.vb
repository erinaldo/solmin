Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports System.Data
Imports System.Collections.Generic
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmTipodeTracto
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private _CCMP As String = ""
    Public Property CCMP() As String
        Get
            Return _CCMP
        End Get
        Set(ByVal value As String)
            _CCMP = value
        End Set
    End Property
    Private Sub frmTipodeTracto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False

        Me.gwdDatos.AutoGenerateColumns = False
        Estado_Controles(False)
        Me.txtBuscar.Text = ""
        Me.Limpiar_Controles()

        Dim obj As New TipoDatoGeneral_BLL
        Dim lista As New List(Of TipoDatoGeneral)
        lista = obj.Lista_Tipo_Dato_General(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy, "STCFTR")
        Me.txtCodigoConfigVehiculo.DataSource = Nothing
        txtCodigoConfigVehiculo.DataSource = lista
        txtCodigoConfigVehiculo.ValueMember = "CODIGO_TIPO"
        txtCodigoConfigVehiculo.DisplayMember = "DESC_TIPO"

        Listar()
    End Sub

    Private Sub Listar()
        Dim objTipodeTracto As New TipodeTracto_BLL
        Dim objEntidad As New TipodeTracto

        objEntidad.TDETRA = Me.txtBuscar.Text.Trim
        objEntidad.CCMPN = CCMP
        Me.gwdDatos.DataSource = objTipodeTracto.Listar_TipodeTracto(objEntidad)
        Me.gwdDatos.AutoGenerateColumns = False
    End Sub

    Private Sub Buscar()

        Dim objTipodeTracto As New TipodeTracto_BLL
        Dim objEntidad As New TipodeTracto
        objEntidad.SESTRG = "A"
        objEntidad.TDETRA = Me.txtBuscar.Text.Trim()
        Me.gwdDatos.DataSource = objTipodeTracto.Busca_TipodeTracto(objEntidad)

        'Asignando las imagenes a las columnas
        For Each objFila As DataGridViewRow In Me.gwdDatos.Rows 
      objFila.Cells(4).Value = LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/tracto/" & objFila.Cells(0).Value.ToString.Trim & ".jpg")
        Next

    End Sub
 

    Private Function validarTipoTracto() As Integer
        If txtDescripTipoTracto.Text = "" Then
            MsgBox("Debe la descripción del tipo de tracto.", MsgBoxStyle.Exclamation)
            Return 0
        ElseIf txtCodigoConfigVehiculo Is Nothing Then
            MsgBox("Debe ingresar al configuración vehicular.", MsgBoxStyle.Exclamation)
            Return 0
        End If
        Return 1
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            If validarTipoTracto() = 1 Then
                Nuevo_Registro()
                AccionCancelar()
            End If

        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If txtCodigoTipoTracto.Text = "" Then
                HelpClass.MsgBox("Seleccionar un registro de la tabla")
            Else
                If validarTipoTracto() = 1 Then
                    Modificar_Registro()
                    AccionCancelar()
                End If
            End If

        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            Me.Estado_Controles(True)
            btnGuardar.Text = "Guardar"
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            btnEliminar.Enabled = False

            KryptonLabel6.Visible = True
            btnImagen.Visible = True

            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        End If

    End Sub

    Private Sub Modificar_Registro(Optional ByVal nombreImagen As String = "")
        Dim objEntidad As New TipodeTracto
        Dim objTipodeTracto As New TipodeTracto_BLL
        objEntidad.CTITRA = Me.txtCodigoTipoTracto.Text
        objEntidad.TDETRA = Me.txtDescripTipoTracto.Text
        objEntidad.TABDES = Me.txtDescripTipoTractoAbrev.Text
        objEntidad.TCNFVH = Me.txtCodigoConfigVehiculo.SelectedValue
        objEntidad.IMGTRA = txtCodigoTipoTracto.Text & ".jpg"
        objEntidad.SESTRG = "A"
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objTipodeTracto.Modificar_TipodeTracto(objEntidad)

        HelpClass.MsgBox("El registro se modificó satisfactoriamente")
        Limpiar_Controles()
        Estado_Controles(False)
        If objEntidad.CTITRA = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Listar()
        End If

    End Sub

    Private Sub Nuevo_Registro()
        Dim objEntidad As New TipodeTracto
        Dim objTipodeTracto As New TipodeTracto_BLL
        objEntidad.TDETRA = Me.txtDescripTipoTracto.Text
        objEntidad.TABDES = Me.txtDescripTipoTractoAbrev.Text
        objEntidad.TCNFVH = Me.txtCodigoConfigVehiculo.SelectedValue
        objEntidad.IMGTRA = ""
        objEntidad.SESTRG = "A"
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objTipodeTracto.Registrar_TipodeTracto(objEntidad)

        HelpClass.MsgBox("El registro se guardó satisfactoriamente")
        Limpiar_Controles()
        Estado_Controles(False)
        If objEntidad.CTITRA = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
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
    'Listar()

        KryptonLabel6.Visible = False
        btnImagen.Visible = False

    End Sub

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtCodigoTipoTracto.Enabled = lbool_Estado
        Me.txtDescripTipoTracto.Enabled = lbool_Estado
        Me.txtDescripTipoTractoAbrev.Enabled = lbool_Estado
        Me.txtCodigoConfigVehiculo.ComboBox.Enabled = lbool_Estado
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        AccionCancelar()
    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If txtCodigoTipoTracto.Text = "" Then
            HelpClass.MsgBox("Seleccione el registro a Eliminar")
        Else
            If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                Cambiar_Estado_TipodeTracto("*")
                AccionCancelar()
            End If
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

        KryptonLabel6.Visible = False
        btnImagen.Visible = False

    End Sub

    Private Sub Cambiar_Estado_TipodeTracto(ByVal lstr_Estado As String)

        Dim objEntidad As New TipodeTracto
        Dim objTipodeTracto As New TipodeTracto_BLL
        objEntidad.CTITRA = Me.txtCodigoTipoTracto.Text
        objEntidad.SESTRG = lstr_Estado
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objTipodeTracto.Cambiar_Estado_TipodeTracto(objEntidad)
        HelpClass.MsgBox("El registro se eliminó satisfactoriamente")
        Limpiar_Controles()
        Estado_Controles(False)
        If objEntidad.CTITRA = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Listar()
        End If

    End Sub

    Private Sub Limpiar_Controles()
        Me.txtCodigoTipoTracto.Text = ""
        Me.txtDescripTipoTracto.Text = ""
        Me.txtDescripTipoTractoAbrev.Text = ""
        'Me.txtCodigoConfigVehiculo.Text = ""

    End Sub
 
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
        Else
            Listar()
        End If
    End Sub
 
    Private Sub btnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagen.Click
        If Me.txtCodigoTipoTracto.Text <> "" Then
            Dim objfrmSA As New frmSubirArchivo("tracto", txtCodigoTipoTracto.Text)
            If objfrmSA.ShowDialog = Windows.Forms.DialogResult.OK Then
            End If
        End If
    End Sub

    Private Sub gwdDatos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellChanged
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

        If Me.gwdDatos.RowCount < 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
            MsgBox("Debe guardar el nuevo tipo de tracto o cancelarlo.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'Marcando el estado de Edicion
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        btnGuardar.Text = "Modificar"
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True

        Me.txtCodigoTipoTracto.Text = Me.gwdDatos.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtDescripTipoTracto.Text = Me.gwdDatos.Item(1, lint_indice).Value.ToString().Trim()
        Me.txtDescripTipoTractoAbrev.Text = Me.gwdDatos.Item(2, lint_indice).Value.ToString().Trim()
        Me.txtCodigoConfigVehiculo.SelectedValue = Me.gwdDatos.Item(3, lint_indice).Value.ToString().Trim()

        Try
            Me.ImagenTracto.Image = LoadImageFromUrl(My.Settings.ST_URL + "imagenes/solmin/tracto/" & Me.gwdDatos.Item(0, lint_indice).Value.ToString.Trim & ".jpg")
        Catch ex As Exception
        End Try

        Me.HeaderDatos.ValuesPrimary.Heading = "Información del tipo de tracto/ Descripción: " & txtDescripTipoTracto.Text.Trim

    End Sub

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = True
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
