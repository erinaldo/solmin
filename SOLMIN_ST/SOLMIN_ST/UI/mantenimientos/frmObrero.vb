Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmObrero

#Region "Variables"
  Private gEnum_Mantenimiento As MANTENIMIENTO
  Private bolBuscar As Boolean
#End Region

#Region "Eventos"

  Private Sub frmObrero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
            bolBuscar = False
            Me.Cargar_Compania()

      Me.CargarCombo()
      Me.Buscar_Obrero()
      gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
      Me.btnGuardar.Enabled = False
      Me.btnCancelar.Enabled = False
            Me.btnEliminar.Enabled = False

    Catch : End Try

  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.Buscar_Obrero()
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
      If Validar() Then
        Me.Guardar_Obrero("A", "A")
      End If
    ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      Me.Guardar_Obrero("A", "A")
    ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
      Me.Estado_Controles(True, Panel1)
      Me.ctbCodigo.Enabled = False
      Me.btnGuardar.Text = "Guardar"
      Me.btnNuevo.Enabled = False
      Me.btnCancelar.Enabled = True
      Me.btnEliminar.Enabled = False
      Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
    End If
  End Sub

  Private Sub dtgObrero_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgObrero.CellClick
    
    End Sub

    Private Sub dtgObrero_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgObrero.CurrentCellChanged
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If Me.dtgObrero.Rows.Count > 0 Then
                Me.dtgObrero.CurrentRow.Selected = False
            End If
            HelpClass.MsgBox("Debe guardar el nuevo Obrero o cancelar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        btnGuardar.Text = "Modificar"
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        Seleccionar_Detalle_Obrero()
    End Sub

  Private Sub dtgObrero_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgObrero.DataBindingComplete
    Try
      If Me.dtgObrero.Rows.Count > 0 Then
                Me.dtgObrero.CurrentRow.Selected = True
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub dtgObrero_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgObrero.KeyUp
    If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) Then
      If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO OrElse Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
        If Me.dtgObrero.Rows.Count > 0 Then
          Me.dtgObrero.CurrentRow.Selected = False
        End If
        HelpClass.MsgBox("Debe guardar el nuevo Obrero o cancelar.", MsgBoxStyle.Exclamation)
        Exit Sub
      End If
      btnGuardar.Text = "Modificar"
      btnGuardar.Enabled = True
      btnEliminar.Enabled = True
      Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
      Seleccionar_Detalle_Obrero()
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.AccionCancelar()
    Me.Limpiar_Controles(Panel1)
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    If Me.ctbCodigo.Codigo <> "" Then
      If HelpClass.RspMsgBox("Desea eliminar este registro?") = MsgBoxResult.Yes Then
        Guardar_Obrero("I", "*")
        Buscar_Obrero()
        Limpiar_Controles(Panel1)
      End If
    End If
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
    btnNuevo.Enabled = False
    btnGuardar.Text = "Guardar"
    btnGuardar.Enabled = True
    btnCancelar.Enabled = True
    btnEliminar.Enabled = False
    Limpiar_Controles(Panel1)
    Estado_Controles(True, Panel1)
  End Sub

  Private Sub ctbCodigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctbCodigo.Leave
    Dim intCont As Integer
    Me.Limpiar_Controles(Panel1, 1)
    Me.txtNombre.Text = ctbCodigo.Descripcion
    If Me.ctbCodigo.Codigo = Nothing Then Exit Sub
    For intCont = 0 To Me.dtgObrero.Rows.Count - 1
      If CType(dtgObrero.Rows(intCont).Cells("COBRR").Value, Double) = Me.ctbCodigo.Codigo Then
        Me.ctbCodigo.Codigo = Me.dtgObrero.Rows(intCont).Cells("COBRR").Value
        Me.txtNombre.Text = Me.dtgObrero.Rows(intCont).Cells("TNMBOB").Value
        Me.txtCuentaSAP.Text = Me.dtgObrero.Rows(intCont).Cells("CMTCDS").Value
        If Me.dtgObrero.Rows(intCont).Cells("FINGCH").Value <> vbNullString Then
          Me.dtpFechaIngreso.Value = Me.dtgObrero.Rows(intCont).Cells("FINGCH").Value
        End If
        If Me.dtgObrero.Rows(intCont).Cells("FVNCCR").Value <> vbNullString Then
          Me.dtpFechaVencimiento.Value = Me.dtgObrero.Rows(intCont).Cells("FVNCCR").Value
        End If
        Me.cmbCategoria.SelectedValue = Me.dtgObrero.Rows(intCont).Cells("SCATEG").Value
      End If
    Next
  End Sub

  Private Sub txtNombreBusqueda_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombreBusqueda.KeyUp
    If e.KeyValue = 13 Then
      btnBuscar_Click(sender, e)
    End If
  End Sub

    'Private Sub txtCuentaSAP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaSAP.KeyPress
    '  If Not IsNumeric(e.KeyChar) Then
    '    e.Handled = True
    '  End If
    'End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Me.Reporte_Obreros()
  End Sub

    'Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If bolBuscar Then
    '        Me.Cargar_Division()
    '    End If
    'End Sub

    'Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If bolBuscar Then
    '        Me.Cargar_Planta()
    '    End If
    'End Sub

#End Region

#Region "Metodos y Funciones"

  Private Function Validar() As Double
    Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)
    If Me.ctbCodigo.Codigo = vbNullString Then
      strError += "* Código del Obrero" & Chr(13)
    End If
    If Me.txtNombre.Text.Trim = vbNullString Then
      strError += "* Nombre del Obrero" & Chr(13)
    End If
    If Me.cmbCategoria.SelectedValue = vbNullString Then
      strError += "* Categoria Chofer" & Chr(13)
    End If
    If Me.txtCuentaSAP.Text.Trim = vbNullString Then
      strError += "* Cuenta SAP" & Chr(13)
    End If
    If strError.Trim.Length > 17 Then
      HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
      Return False
    Else
      Return True
    End If
  End Function

  Private Sub Buscar_Obrero()
    Dim objLogica As New Obrero_BLL()
    Dim objEntidad As New Hashtable()
    Me.Cursor = Cursors.WaitCursor

    If IsNumeric(Me.txtNombreBusqueda.Text) And txtNombreBusqueda.Text.Trim.Length <= 10 Then
      objEntidad.Add("COBRR", Me.txtNombreBusqueda.Text.Trim)
      objEntidad.Add("TNMBOB", " ")
            'objEntidad.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            'objEntidad.Add("PSCDVSN", Me.cboDivision.SelectedValue)
            '      objEntidad.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))

            objEntidad.Add("PSCCMPN", Me.cboCompania.CCMPN_CodigoCompania)
            objEntidad.Add("PSCDVSN", Me.cboDivision.Division)
            objEntidad.Add("PNCPLNDV", CType(Me.cboPlanta.Planta, Double))
    Else
      objEntidad.Add("COBRR", 0)
      objEntidad.Add("TNMBOB", Me.txtNombreBusqueda.Text.Trim)
            'objEntidad.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            'objEntidad.Add("PSCDVSN", Me.cboDivision.SelectedValue)
            '      objEntidad.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))


            objEntidad.Add("PSCCMPN", Me.cboCompania.CCMPN_CodigoCompania)
            objEntidad.Add("PSCDVSN", Me.cboDivision.Division)
            objEntidad.Add("PNCPLNDV", CType(Me.cboPlanta.Planta, Double))
    End If
    Me.dtgObrero.DataSource = Nothing
    Me.dtgObrero.AutoGenerateColumns = False
    Try
      dtgObrero.DataSource = HelpClass.GetDataSetNative(objLogica.Lista_Obreros(objEntidad))
    Catch ex As Exception
      HelpClass.MsgBox(ex.Message)
      Me.Limpiar_Controles(Panel1)
      Me.AccionCancelar()
      Me.Cursor = Cursors.Default
    End Try
    If Me.dtgObrero.Rows.Count > 0 Then
      Me.Seleccionar_Detalle_Obrero()
    End If
    Me.Limpiar_Controles(Panel1)
    Me.AccionCancelar()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Seleccionar_Detalle_Obrero()
    Me.Cursor = Cursors.WaitCursor
        If Me.dtgObrero.Rows.Count = 0 OrElse Me.dtgObrero.CurrentCellAddress.Y < 0 Then Exit Sub
    If Not dtgObrero.CurrentRow.Selected Then
      Me.Cursor = Cursors.Default
      Exit Sub
    End If
    Me.ctbCodigo.Limpiar()
    Me.ctbCodigo.Codigo = Me.dtgObrero.SelectedRows(0).Cells("COBRR").Value
    Me.txtNombre.Text = Me.dtgObrero.SelectedRows(0).Cells("TNMBOB").Value
    Me.txtCuentaSAP.Text = Me.dtgObrero.SelectedRows(0).Cells("CMTCDS").Value
    If Me.dtgObrero.SelectedRows(0).Cells("FINGCH").Value <> vbNullString Then
      Me.dtpFechaIngreso.Value = Me.dtgObrero.SelectedRows(0).Cells("FINGCH").Value
    End If
    If Me.dtgObrero.SelectedRows(0).Cells("FVNCCR").Value <> vbNullString Then
      Me.dtpFechaVencimiento.Value = Me.dtgObrero.SelectedRows(0).Cells("FVNCCR").Value
    End If
    Me.cmbCategoria.SelectedValue = Me.dtgObrero.SelectedRows(0).Cells("SCATEG").Value
    Me.HeaderDatos.ValuesPrimary.Heading = "Información del Obrero / " & Me.dtgObrero.SelectedRows(0).Cells("TNMBOB").Value
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Guardar_Obrero(ByVal strEstado As String, ByVal strEstado2 As String)
    Dim objEntidad As New Obrero
    Dim objLogical As New Obrero_BLL
    Try
      objEntidad.COBRR = Me.ctbCodigo.Codigo
      objEntidad.TNMBOB = Me.txtNombre.Text
      objEntidad.SCATEG = Me.cmbCategoria.SelectedValue
      objEntidad.FINGCH = HelpClass.CtypeDate(Me.dtpFechaIngreso.Value)
      objEntidad.FVNCCR = HelpClass.CtypeDate(Me.dtpFechaVencimiento.Value)
      objEntidad.CULUSA = MainModule.USUARIO
      objEntidad.FULTAC = HelpClass.TodayNumeric
      objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
      objEntidad.SACTIN = strEstado
      objEntidad.SESTRG = strEstado2
      objEntidad.CMTCDS = Me.txtCuentaSAP.Text
            'objEntidad.CCMPN = Me.cboCompania.SelectedValue
            'objEntidad.CDVSN = Me.cboDivision.SelectedValue
            'objEntidad.CPLNDV = CType(Me.cboPlanta.SelectedValue, Double)

            objEntidad.CCMPN = Me.cboCompania.CCMPN_CodigoCompania
            objEntidad.CDVSN = Me.cboDivision.Division
            objEntidad.CPLNDV = CType(Me.cboPlanta.Planta, Double)

      objLogical.Guardar_Obrero(objEntidad)
      Me.AccionCancelar()
      Me.Buscar_Obrero()
      HelpClass.MsgBox("Se realizó la operación satisfactoriamente")
    Catch ex As Exception
      HelpClass.ErrorMsgBox()
    End Try

  End Sub

  Private Sub CargarCombo()
    Cargar_Categoria_Conductor()
    Cargar_Obrero_Empleado()
  End Sub

  Private Sub Cargar_Categoria_Conductor()
    Dim objlogica As New Categoria_Chofer_BLL
    Me.cmbCategoria.DataSource = objlogica.Listar_Categoria_Chofer
    Me.cmbCategoria.DisplayMember = "TCATEG"
    Me.cmbCategoria.ValueMember = "SCATEG"
  End Sub

  Private Sub Cargar_Obrero_Empleado()
    Dim objlogica As New Obrero_BLL
    Try
      With ctbCodigo
        .DataSource = HelpClass.GetDataSetNative(objlogica.Lista_Obrero_Empleado_RANSA)
        .KeyField = "PERNR"
        .ValueField = "TCMPEM"
        .DataBind()
      End With
    Catch ex As Exception
    End Try
  End Sub

  Private Sub AccionCancelar()
    If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
      Estado_Controles(False, Panel1)
      If Me.dtgObrero.Rows.Count > 0 Then
        Me.dtgObrero.CurrentRow.Selected = False
      End If
    End If
    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    Me.btnNuevo.Enabled = True
    Me.btnGuardar.Enabled = False
    Me.btnCancelar.Enabled = False
    Me.btnEliminar.Enabled = False
  End Sub

  Private Sub Estado_Controles(ByVal lbool_estado As Boolean, ByVal Contenedor As Object)
    Dim X As Control
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or MANTENIMIENTO.NUEVO Or MANTENIMIENTO.MODIFICAR Then
      For Each X In Contenedor.Controls
        X.Enabled = lbool_estado
      Next
    End If
  End Sub

  Public Sub Limpiar_Controles(ByVal Contenedor As Object, Optional ByVal intTipo As Integer = 0)
    If Me.dtgObrero.Rows.Count > 0 Then
      Me.dtgObrero.CurrentRow.Selected = False
    End If
    Me.HeaderDatos.ValuesPrimary.Heading = "Información del Obrero"
    Dim X As Control
    If intTipo = 0 Then
      Me.ctbCodigo.Limpiar()
      For Each X In Contenedor.Controls
        If TypeOf X Is TextBox Then CType(X, TextBox).Clear()
        If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Clear()
        If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonComboBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonComboBox).SelectedIndex = -1
        If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
        If TypeOf X Is CheckBox Then CType(X, CheckBox).Checked = False
        If TypeOf X Is RadioButton Then CType(X, RadioButton).Checked = False
      Next
    Else
      For Each X In Contenedor.Controls
        If TypeOf X Is TextBox Then CType(X, TextBox).Clear()
        If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Clear()
        If TypeOf X Is ComponentFactory.Krypton.Toolkit.KryptonComboBox Then CType(X, ComponentFactory.Krypton.Toolkit.KryptonComboBox).SelectedIndex = -1
        If TypeOf X Is DateTimePicker Then CType(X, DateTimePicker).Value = Now
        If TypeOf X Is CheckBox Then CType(X, CheckBox).Checked = False
        If TypeOf X Is RadioButton Then CType(X, RadioButton).Checked = False
      Next
    End If

  End Sub

  Private Sub Reporte_Obreros()

    Dim objEntidad As New Hashtable
    Dim oDt As DataTable
    Dim oDs As New DataSet

    If IsNumeric(Me.txtNombreBusqueda.Text) And txtNombreBusqueda.Text.Trim.Length <= 10 Then
      objEntidad.Add("COBRR", Me.txtNombreBusqueda.Text.Trim)
            objEntidad.Add("TNMBOB", " ")

            objEntidad.Add("PSCCMPN", Me.cboCompania.CCMPN_CodigoCompania)
            objEntidad.Add("PSCDVSN", Me.cboDivision.Division)
            objEntidad.Add("PNCPLNDV", CType(Me.cboPlanta.Planta, Double))


            'objEntidad.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            'objEntidad.Add("PSCDVSN", Me.cboDivision.SelectedValue)
            'objEntidad.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))
    Else
      objEntidad.Add("COBRR", 0)
            objEntidad.Add("TNMBOB", Me.txtNombreBusqueda.Text.Trim)
            objEntidad.Add("PSCCMPN", Me.cboCompania.CCMPN_CodigoCompania)
            objEntidad.Add("PSCDVSN", Me.cboDivision.Division)
            objEntidad.Add("PNCPLNDV", CType(Me.cboPlanta.Planta, Double))

            'objEntidad.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            'objEntidad.Add("PSCDVSN", Me.cboDivision.SelectedValue)
            'objEntidad.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))
    End If

    Me.Cursor = Cursors.WaitCursor
    Dim objPrintForm As New PrintForm
    Dim objReporte As New rptObreros ' pendiente
    Dim objLogical As New Obrero_BLL
    oDt = HelpClass.GetDataSetNative(objLogical.Lista_Obreros(objEntidad))
    If oDt.Rows.Count = 0 Then
      Me.Cursor = Cursors.Default
      Exit Sub
    End If
    oDt.TableName = "OBRERO"
    oDs.Tables.Add(oDt.Copy)
    objReporte.SetDataSource(oDs)
    CType(objReporte.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cboCompania.Text
    CType(objReporte.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.cboDivision.Text
    CType(objReporte.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cboPlanta.Text
    objPrintForm.ShowForm(objReporte, Me)
    Me.Cursor = Cursors.Default
  End Sub

    Private Sub Cargar_Compania()
        cboCompania.Usuario = MainModule.USUARIO
        'cboCompania.CCMPN_CompaniaDefault = "EZ"
        cboCompania.pActualizar()
        cboCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        'Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
        'objCompaniaBLL.Crea_Lista()
        'bolBuscar = False
        'Me.cboCompania.DataSource = objCompaniaBLL.Lista
        'Me.cboCompania.ValueMember = "CCMPN"
        'bolBuscar = True
        'Me.cboCompania.DisplayMember = "TCMPCM"
        '    Me.cboCompania.SelectedIndex = 0
        '    cboCompania_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    'Private Sub Cargar_Division()
    '  Dim objDivision As New NEGOCIO.Division_BLL
    '  Try
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    bolBuscar = False
    '    objDivision.Crea_Lista()
    '    Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
    '    Me.cboDivision.ValueMember = "CDVSN"
    '    bolBuscar = True
    '    Me.cboDivision.DisplayMember = "TCMPDV"
    '          Me.cboDivision.SelectedIndex = 0
    '          cboDivision_SelectedIndexChanged(Nothing, Nothing)
    '          Me.Cursor = System.Windows.Forms.Cursors.Default
    '  Catch ex As Exception
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '  End Try
    'End Sub

    'Private Sub Cargar_Planta()
    '  Dim objPlanta As New NEGOCIO.Planta_BLL
    '  Try
    '    If bolBuscar Then
    '      Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '      bolBuscar = False
    '      objPlanta.Crea_Lista()
    '      Me.cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
    '      Me.cboPlanta.ValueMember = "CPLNDV"
    '      bolBuscar = True
    '      Me.cboPlanta.DisplayMember = "TPLNTA"
    '      Me.cboPlanta.SelectedValue = "1"
    '      Me.Cursor = System.Windows.Forms.Cursors.Default
    '    End If
    '  Catch ex As Exception
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '    HelpClass.MsgBox(ex.Message)
    '  End Try
    'End Sub

#End Region

    Private Sub cboCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cboCompania.Seleccionar
        Try

            cboDivision.Usuario = MainModule.USUARIO
            cboDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cboDivision.DivisionDefault = "T"
            cboDivision.pActualizar()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cboDivision.Seleccionar
        cboPlanta.Usuario = MainModule.USUARIO
        cboPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        cboPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        cboPlanta.pActualizar()
    End Sub
End Class
