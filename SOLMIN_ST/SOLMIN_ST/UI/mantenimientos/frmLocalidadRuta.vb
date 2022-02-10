Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

'****************************************************************************************************
'** Autor: Rafael Gamboa
'** Descripción: capa de presentación.
'****************************************************************************************************

Public Class frmLocalidadRuta

#Region "Eventos"

    Private Sub frmLocalidadesRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Pone el flag en neutral
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
        gwdDatos.AutoGenerateColumns = False
        Estado_Controles(False)
        Cargar_Ubigeo()
        Listar_LocalidadRutas()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Listar_LocalidadRutas()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            If Me.txtDesLocalidad.Text.Trim = "" Then
                MsgBox("Ingrese la descripción de la localidad.", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                Registrar_LocalidadRuta()
                Estado_Botones_Ultimo()
                'AccionCancelar()
            End If
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.txtCodigo.Text.Trim = "" Then
                MsgBox("Seleccione un registro.", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                Modificar_LocalidadRuta()
                Estado_Botones_Ultimo()
                'AccionCancelar()
            End If
            'pulso el boton 'modificar'
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            Me.Estado_Controles(True)
            btnGuardar.Text = "Guardar"
            'controles habilitados para cancelar en cualkier momento la modificacion en caliente
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            btnEliminar.Enabled = False
            'prepara para la sgte accion del btnGuardar (guardar en BD)
            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.gwdDatos.Rows.Count > 0 Then
            If Me.txtCodigo.Text <> "" Then
                If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                    Eliminar_LocalidadRuta()
                    Estado_Botones_Ultimo()
                End If
            Else
                MsgBox("Seleccione un registro.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        Limpiar_Controles()
        Estado_Controles(True)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        AccionCancelar()
    End Sub
#End Region

#Region "Metodos"

    Private Sub Cargar_Ubigeo()
        Dim obj_Logica_Localidad As New NEGOCIO.mantenimientos.LocalidadRuta_BLL
        With Me.ctbUbigeo
            .DataSource = obj_Logica_Localidad.Listar_Ubigeo("EZ") 'CType(MainModule.gobj_TablasGeneralesdelSistema("UBIGEO"), DataTable).Copy()
            .KeyField = "UBIGEO"
            .ValueField = "DESCRIPCION"
            .DataBind()
        End With
    End Sub

    Private Sub Eliminar_LocalidadRuta()
        Dim objLogica As New LocalidadRuta_BLL
        Dim objEntidad As New LocalidadRuta
        objEntidad.CLCLD = txtCodigo.Text.Trim
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objLogica.Eliminar_LocalidadRuta(objEntidad)
        If objEntidad.CLCLD = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Listar_LocalidadRutas()
        End If
    End Sub

    Private Sub AccionCancelar()
        If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            Limpiar_Controles()
            Estado_Controles(False)
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
        ElseIf gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            Estado_Controles(False)
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
        ElseIf gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            Limpiar_Controles()
        End If
        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        If Me.gwdDatos.Rows.Count > 0 Then
            Me.gwdDatos.CurrentRow.Selected = False
        End If
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False

    End Sub

    Private Sub Modificar_LocalidadRuta()
        Dim objLogica As New LocalidadRuta_BLL
        Dim objEntidad As New LocalidadRuta
        objEntidad.CLCLD = txtCodigo.Text
        objEntidad.TCMLCL = txtDesLocalidad.Text.ToUpper
        objEntidad.TABLCL = txtAbrevDesLocalidad.Text.ToUpper
        If Me.ctbUbigeo.Codigo <> Nothing Then
            objEntidad.CUBGEL = Me.ctbUbigeo.Codigo
        End If
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objLogica.Modificar_LocalidadRuta(objEntidad)
        If objEntidad.CLCLD = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Listar_LocalidadRutas()
        End If
    End Sub

    Private Sub Registrar_LocalidadRuta()
        Dim objLogica As New LocalidadRuta_BLL
        Dim objEntidad As New LocalidadRuta
        objEntidad.CLCLD = ""
        objEntidad.TCMLCL = txtDesLocalidad.Text.ToUpper
        objEntidad.TABLCL = txtAbrevDesLocalidad.Text.ToUpper
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        If Me.ctbUbigeo.Codigo <> Nothing Then
            objEntidad.CUBGEL = Me.ctbUbigeo.Codigo
        End If
        objEntidad = objLogica.Registrar_LocalidadRuta(objEntidad)
        If objEntidad.CLCLD = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            Listar_LocalidadRutas()
        End If
    End Sub

    Private Sub Estado_Controles(ByVal lbool As Boolean)
        txtCodigo.Enabled = lbool
        txtDesLocalidad.Enabled = lbool
        txtAbrevDesLocalidad.Enabled = lbool
        ctbUbigeo.Enabled = lbool
    End Sub

    Private Sub Listar_LocalidadRutas()
        Dim objLogica As New LocalidadRuta_BLL
        Dim objEntidad As New LocalidadRuta
        objEntidad.TCMLCL = txtBuscar.Text.ToUpper.Trim
        Me.gwdDatos.AutoGenerateColumns = False
        gwdDatos.DataSource = HelpClass.GetDataSetNative(objLogica.Listar_LocalidadRuta(objEntidad))
        
    End Sub

    Private Sub Limpiar_Controles()
        txtCodigo.Text = ""
        txtDesLocalidad.Text = ""
        txtAbrevDesLocalidad.Text = ""
        ctbUbigeo.Limpiar()
    End Sub
#End Region

#Region "Variables"
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Dim _indiceGrilla As Integer = 0
#End Region

 
    Private Sub txtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            Listar_LocalidadRutas()
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Imprimir_Lista_Localidad_Ruta()
    End Sub

    Private Sub Imprimir_Lista_Localidad_Ruta()
        If Me.gwdDatos.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim objParametro As New Hashtable
        Dim oDt As DataTable
        Dim oDs As New DataSet

        Me.Cursor = Cursors.WaitCursor

        Dim objPrintForm As New PrintForm
        Dim objReporte As New rptReporteLocalidadRuta

        Dim objLogica As New LocalidadRuta_BLL
        Dim objEntidad As New LocalidadRuta
        objEntidad.TCMLCL = txtBuscar.Text.ToUpper.Trim
        Me.gwdDatos.AutoGenerateColumns = False
        oDt = HelpClass.GetDataSetNative(objLogica.Listar_LocalidadRuta(objEntidad))
        oDt.TableName = "LocalidadRuta"
        oDs.Tables.Add(oDt.Copy)
        objReporte.SetDataSource(oDs)
        objPrintForm.ShowForm(objReporte, Me)
       
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub gwdDatos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.CurrentCellChanged
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub

        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = False
            End If
            MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'Marcando el estado de Edición
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        btnGuardar.Text = "Modificar"
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        Limpiar_Controles()
        'AccionCancelar()
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        _indiceGrilla = lint_indice
        txtDesLocalidad.Text = Me.gwdDatos.Item("DescLocalidad", lint_indice).Value.ToString().Trim()
        txtAbrevDesLocalidad.Text = Me.gwdDatos.Item("AbrevLocalidad", lint_indice).Value.ToString().Trim()
        txtCodigo.Text = Me.gwdDatos.Item("CodigoLocalidad", lint_indice).Value.ToString().Trim()
        Me.ctbUbigeo.Codigo = Me.gwdDatos.Item("CUBGEL", lint_indice).Value
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Localidad: " & txtDesLocalidad.Text
    End Sub

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Estado_Botones_Ultimo()
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        btnNuevo.Enabled = True
        btnCancelar.Enabled = False
        Estado_Controles(False)
    End Sub
End Class
