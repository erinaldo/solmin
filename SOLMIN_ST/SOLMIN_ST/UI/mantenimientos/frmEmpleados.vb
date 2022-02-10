Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmEmpleados

#Region "Variables"
  Private dtPrincipal As New DataTable
  Private VistaDefault As Integer
  Private TotalPaginas As Integer
  Private PaginaActual As Integer
  Private ini As Integer = 0
  Private fin As Integer = 19
  Private suma As Integer = 0
  Private gEnum_Mantenimiento As MANTENIMIENTO
  Private bolBuscar As Boolean
#End Region

#Region "Métodos y Funciones"

  Private Sub num_paginas()
    cboPaginas.Items.Clear()
    VistaDefault = CType(ToolStripTextBox1.Text.Trim(), Integer)
    If dtPrincipal.Rows.Count Mod VistaDefault = 0 Then
      TotalPaginas = dtPrincipal.Rows.Count / VistaDefault
    Else
      Dim value As Double = dtPrincipal.Rows.Count / VistaDefault
      TotalPaginas = Math.Truncate(value) + 1
      ToolStripTextBox2.Text = TotalPaginas
    End If
    For i As Integer = 0 To TotalPaginas - 1
      cboPaginas.Items.Add(i + 1)
    Next
  End Sub

  Private Sub cambiar_pagina()
    ini = 0
    fin = 0
    If ToolStripTextBox3.Text = "1" Then
      fin = VistaDefault - 1
    Else
      ini = ((Convert.ToInt32(ToolStripTextBox3.Text.Trim()) - 1) * VistaDefault) - 1
      fin = ini + VistaDefault
    End If

    If fin > dtPrincipal.Rows.Count Then
      fin = dtPrincipal.Rows.Count - 1
    End If
  End Sub

  Private Sub paginar()

    Me.dtgEmpleado.DataSource = paginarDataDridView(dtPrincipal, ini, fin)

  End Sub

  Private Sub Cargar_Compania()
    Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
    objCompaniaBLL.Crea_Lista()
    Me.cboCompania.DataSource = objCompaniaBLL.Lista
    Me.cboCompania.ValueMember = "CCMPN"
        Me.cboCompania.DisplayMember = "TCMPCM"
        'cboCompania.SelectedValue = "EZ"
        'If cboCompania.SelectedIndex = -1 Then
        '    cboCompania.SelectedIndex = 0
        'End If
        'Me.cboCompania.SelectedIndex = 0

        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
  End Sub

  Private Sub Cargar_TipoEmpleado()
    Dim objTipoEmpleadoBLL As New NEGOCIO.Empleado_BLL
    Dim Dat As DataTable = New DataTable()
    Dat = objTipoEmpleadoBLL.Listar_TipoEmpleado(cboCompania.SelectedValue.ToString())
    Me.cboTipoEmpleado.DataSource = Dat
    Me.cboTipoEmpleado.ValueMember = "CTPOEM"
    Me.cboTipoEmpleado.DisplayMember = "TTPOEM"
    Me.cboTipoEmpleado.SelectedIndex = 0
  End Sub

  Private Sub Buscar_Empleado()
    Dim objLogica As New Empleado_BLL()
    Dim objEntidad As New Hashtable()
    Dim objTable As New DataTable
    Me.Cursor = Cursors.WaitCursor
    bolBuscar = False

    If IsNumeric(Me.txtNombreBusqueda.Text) And txtNombreBusqueda.Text.Trim.Length <= 10 Then
      objEntidad.Add("CEMPC", Me.txtNombreBusqueda.Text.Trim)
      objEntidad.Add("CCMPN1", Me.cboCompania.SelectedValue.ToString())
      objEntidad.Add("CTPOEM", Me.cboTipoEmpleado.SelectedValue.ToString())

    Else
      objEntidad.Add("CEMPC", 0)
      objEntidad.Add("CCMPN1", Me.cboCompania.SelectedValue.ToString())
      objEntidad.Add("CTPOEM", Me.cboTipoEmpleado.SelectedValue.ToString())

    End If
    Me.dtgEmpleado.DataSource = Nothing
    Me.dtgEmpleado.AutoGenerateColumns = False
    Try
      dtPrincipal = Nothing
      objTable = HelpClass.GetDataSetNative(objLogica.Lista_Empleados(objEntidad))
      dtgEmpleado.DataSource = objTable.Copy 'GetDataSetNative(objLogica.Lista_Empleados(objEntidad))
      dtPrincipal = objTable.Copy 'HelpClass.GetDataSetNative(objLogica.Lista_Empleados(objEntidad))


    Catch ex As Exception
      HelpClass.MsgBox(ex.Message)
      Me.Limpiar_Controles_Empleado()
      Me.AccionCancelar()
      Me.Cursor = Cursors.Default
    End Try
    If Me.dtgEmpleado.Rows.Count > 0 Then
    End If
    Me.Limpiar_Controles_Empleado()
    Me.AccionCancelar()
    Me.Cursor = Cursors.Default
    bolBuscar = True

    If dtPrincipal.Rows.Count > 0 Then
      num_paginas()
      cboPaginas.Text = "1"
      ' ToolStripTextBox1.Text = "20"
      ToolStripTextBox3.Text = "1"

      paginar()
    Else
      MessageBox.Show("No hay Datos Encontrados")
    End If
  End Sub

  Private Sub Modificar_Registro()
    Dim obj As New Empleado_BLL
    Dim objEntidad As New Empleado
    Me.Cursor = Cursors.WaitCursor

    objEntidad.CTPOEM = Me.cboTipoEmpleado.SelectedValue.ToString()
    objEntidad.CTPPTA = 251
    objEntidad.CEMPC = Me.txtCodEmpleado.Text.Trim
    objEntidad.TCMPEM = Me.txtDescripcion.Text.Trim
    objEntidad.TABREM = Me.txtAbre.Text.Trim
    objEntidad.TDRCEM = Me.txtDirecc.Text.Trim
    objEntidad.TLCLEM = Me.txtLocalidad.Text.Trim
    objEntidad.TDPTEM = Me.txtDpto.Text.Trim
    objEntidad.CCMPN1 = cboCompania.SelectedValue.ToString()
    objEntidad.CSCDSP = "251"
    objEntidad = obj.Modificar_Empleados(objEntidad)
    AccionCancelar()

  End Sub

  Private Sub Nuevo_Registro()
    Dim obj As New Empleado_BLL
    Dim objEntidad As New Empleado
    Me.Cursor = Cursors.WaitCursor

    objEntidad.CTPOEM = Me.cboTipoEmpleado.SelectedValue.ToString()
    objEntidad.CTPPTA = 251
    objEntidad.CEMPC = Me.txtCodEmpleado.Text.Trim
    objEntidad.TCMPEM = Me.txtDescripcion.Text.Trim
    objEntidad.TABREM = Me.txtAbre.Text.Trim
    objEntidad.TDRCEM = Me.txtDirecc.Text.Trim
    objEntidad.TLCLEM = Me.txtLocalidad.Text.Trim
    objEntidad.TDPTEM = Me.txtDpto.Text.Trim
    objEntidad.CCECOE = 117
    objEntidad.CCMPN1 = cboCompania.SelectedValue.ToString()
    objEntidad.CCLNT5 = 485
    objEntidad.CSCDSP = "251"
    objEntidad.PERNR = "00" & Me.txtCodEmpleado.Text.Trim
    objEntidad.CCENPL = 0
    objEntidad.TDSCTR = ""
    objEntidad.SESTRG = "A"
    objEntidad.CULUSA = MainModule.USUARIO
    objEntidad.FULTAC = HelpClass.TodayNumeric
    objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad = obj.Registrar_Empleados(objEntidad)
    AccionCancelar()

  End Sub

  Private Sub AccionCancelar()
    If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Or gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
      Estado_Controles_Empleado(False)
      If Me.dtgEmpleado.Rows.Count > 0 Then
        Me.dtgEmpleado.CurrentRow.Selected = False
      End If
    End If
    gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
    Me.btnNuevo.Enabled = True
    Me.btnGuardar.Enabled = False
    Me.btnCancelar.Enabled = False
    Me.btnEliminar.Enabled = False
  End Sub

  Private Sub Estado_Controles_Empleado(ByVal lbool_Estado As Boolean)
    txtDescripcion.Enabled = lbool_Estado
    txtAbre.Enabled = lbool_Estado
    txtDirecc.Enabled = lbool_Estado
    txtLocalidad.Enabled = lbool_Estado
    txtDpto.Enabled = lbool_Estado
    txtCodCompa.Enabled = False
    KryptonTextBox1.Enabled = lbool_Estado
    txtCodEmpleado.Enabled = lbool_Estado

  End Sub

  Private Sub Limpiar_Controles_Empleado()
    txtCod1.Text = ""
    txtCod2.Text = ""
    txtCod3.Text = ""
    txtDescripcion.Text = ""
    txtAbre.Text = ""
    txtDirecc.Text = ""
    txtLocalidad.Text = ""
    txtDpto.Text = ""
    txtCodCompa.Text = ""
    KryptonTextBox1.Text = ""
    txtCodEmpleado.Text = ""

  End Sub


#End Region

#Region "Eventos"

  Public Shared Function paginarDataDridView(ByVal dtPaginar As DataTable, ByVal inicial As Integer, ByVal final As Integer)
    Dim dtnew As New DataTable
    dtnew = dtPaginar.Clone
    For i As Integer = inicial To final
      dtnew.ImportRow(dtPaginar.Rows(i))
    Next
    Return dtnew
  End Function

  Private Sub frmEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      bolBuscar = False
      Me.Cargar_Compania()
      Me.btnGuardar.Enabled = False
      Me.btnCancelar.Enabled = False
      Me.btnEliminar.Enabled = False
      Cargar_TipoEmpleado()
    Catch : End Try
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
    Else
      Buscar_Empleado()
    End If
  End Sub

  Private Sub dtgEmpleado_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgEmpleado.CellClick

    If e.RowIndex < 0 Or Me.dtgEmpleado.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If

    Dim lint_indice As Integer = Me.dtgEmpleado.CurrentCellAddress.Y

    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      If Me.dtgEmpleado.Rows.Count > 0 Then
        Me.dtgEmpleado.CurrentRow.Selected = False
      End If
      MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
      Exit Sub
    End If

    Me.txtCod1.Text = Me.dtgEmpleado.Item(0, lint_indice).Value.ToString().Trim()
    Me.txtCod2.Text = Me.dtgEmpleado.Item(1, lint_indice).Value.ToString().Trim()
    Me.txtCod3.Text = Me.dtgEmpleado.Item(2, lint_indice).Value.ToString().Trim()
    Me.txtDescripcion.Text = Me.dtgEmpleado.Item(3, lint_indice).Value.ToString().Trim()
    Me.txtAbre.Text = Me.dtgEmpleado.Item(4, lint_indice).Value.ToString().Trim()
    Me.txtDirecc.Text = Me.dtgEmpleado.Item(5, lint_indice).Value.ToString().Trim()
    Me.txtLocalidad.Text = Me.dtgEmpleado.Item(6, lint_indice).Value.ToString().Trim()
    Me.txtDpto.Text = Me.dtgEmpleado.Item(7, lint_indice).Value.ToString().Trim()
    Me.txtCodCompa.Text = Me.dtgEmpleado.Item(9, lint_indice).Value.ToString().Trim()
    Me.KryptonTextBox1.Text = Me.dtgEmpleado.Item(11, lint_indice).Value.ToString().Trim()
    Me.txtCodEmpleado.Text = Me.dtgEmpleado.Item(2, lint_indice).Value.ToString().Trim()
    Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
    btnGuardar.Text = "Modificar"
    btnGuardar.Enabled = True
    btnEliminar.Enabled = True
    'Me.Estado_Controles_Empleado(True)
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    AccionCancelar()
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
      Nuevo_Registro()
      gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
      Buscar_Empleado()
    ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
      If txtDescripcion.Text = "" Then
        HelpClass.MsgBox("Seleccionar un registro de la tabla")
      Else
        Modificar_Registro()
        'gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        Buscar_Empleado()
      End If
    ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
      btnGuardar.Text = "Guardar"
      'controles habilitados para cancelar en cualkier momento la modificacion en caliente
      btnNuevo.Enabled = False
      btnCancelar.Enabled = True
      btnEliminar.Enabled = False
      Estado_Controles_Empleado(True)
      txtCodEmpleado.Enabled = False
      'prepara para la sgte accion del btnGuardar (guardar en BD)
      Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
    End If

  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
    btnNuevo.Enabled = False
    btnGuardar.Text = "Guardar"
    btnGuardar.Enabled = True
    btnCancelar.Enabled = True
    btnEliminar.Enabled = False
    Limpiar_Controles_Empleado()
    Estado_Controles_Empleado(True)
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    If txtDescripcion.Text = "" Then
      HelpClass.MsgBox("Seleccione el registro a Eliminar")
    Else
      Cambiar_Estado_Empleado("*")
      Limpiar_Controles_Empleado()
      Estado_Controles_Empleado(False)
      Buscar_Empleado()
    End If
  End Sub

  Private Sub Cambiar_Estado_Empleado(ByVal lstr_Estado As String)
    Dim obj As New Empleado_BLL
    Dim objEntidad As New Empleado
    objEntidad.CTPOEM = Me.txtCod1.Text.Trim
    objEntidad.CTPPTA = Me.txtCod2.Text.Trim
    objEntidad.CEMPC = Me.txtCod3.Text.Trim
    objEntidad.SESTRG = "*"
    obj.Cambiar_Estado_ServicioTransporte(objEntidad)

  End Sub

  Private Sub txtNombreBusqueda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreBusqueda.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
  End Sub

  Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectedIndexChanged

    If bolBuscar Then
      Buscar_Empleado()
    End If

  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Dim objLogica As New Empleado_BLL()
    Dim objEntidad As New Hashtable()
    Me.Cursor = Cursors.WaitCursor
    Dim oDt As DataTable
    Dim oDs As New DataSet
    Dim objReporte As New rptListaEmpleados
    Dim objPrintForm As New PrintForm
    bolBuscar = False

    If IsNumeric(Me.txtNombreBusqueda.Text) And txtNombreBusqueda.Text.Trim.Length <= 10 Then
      objEntidad.Add("CEMPC", Me.txtNombreBusqueda.Text.Trim)
      objEntidad.Add("CCMPN1", Me.cboCompania.SelectedValue.ToString())
      objEntidad.Add("CTPOEM", Me.cboTipoEmpleado.SelectedValue.ToString())
    Else
      objEntidad.Add("CEMPC", 0)
      objEntidad.Add("CCMPN1", Me.cboCompania.SelectedValue.ToString())
      objEntidad.Add("CTPOEM", Me.cboTipoEmpleado.SelectedValue.ToString())

    End If
    Try
      oDt = HelpClass.GetDataSetNative(objLogica.Lista_Empleados(objEntidad))
      If oDt.Rows.Count = 0 Then
        Me.Cursor = Cursors.Default
        Exit Sub
      End If
      oDt.TableName = "dtsEmpleado"
      oDs.Tables.Add(oDt.Copy)
      objReporte.SetDataSource(oDs)
      CType(objReporte.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
      CType(objReporte.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cboCompania.Text
      CType(objReporte.ReportDefinition.ReportObjects("lblTipoEmpleado"), TextObject).Text = Me.cboTipoEmpleado.Text

      objPrintForm.ShowForm(objReporte, Me)
      Me.Cursor = Cursors.Default

    Catch : End Try

  End Sub

  Private Sub dtgEmpleado_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgEmpleado.KeyUp

    If dtgEmpleado.CurrentCellAddress.Y < 0 Then Exit Sub
    Select Case e.KeyCode
      Case Keys.Enter, Keys.Up, Keys.Down

        Dim lint_indice As Integer = Me.dtgEmpleado.CurrentCellAddress.Y

        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
          If Me.dtgEmpleado.Rows.Count > 0 Then
            Me.dtgEmpleado.CurrentRow.Selected = False
          End If
          MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
          Exit Sub
        End If

        Me.txtCod1.Text = Me.dtgEmpleado.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtCod2.Text = Me.dtgEmpleado.Item(1, lint_indice).Value.ToString().Trim()
        Me.txtCod3.Text = Me.dtgEmpleado.Item(2, lint_indice).Value.ToString().Trim()
        Me.txtDescripcion.Text = Me.dtgEmpleado.Item(3, lint_indice).Value.ToString().Trim()
        Me.txtAbre.Text = Me.dtgEmpleado.Item(4, lint_indice).Value.ToString().Trim()
        Me.txtDirecc.Text = Me.dtgEmpleado.Item(5, lint_indice).Value.ToString().Trim()
        Me.txtLocalidad.Text = Me.dtgEmpleado.Item(6, lint_indice).Value.ToString().Trim()
        Me.txtDpto.Text = Me.dtgEmpleado.Item(7, lint_indice).Value.ToString().Trim()
        Me.txtCodCompa.Text = Me.dtgEmpleado.Item(9, lint_indice).Value.ToString().Trim()
        Me.KryptonTextBox1.Text = Me.dtgEmpleado.Item(11, lint_indice).Value.ToString().Trim()
        Me.txtCodEmpleado.Text = Me.dtgEmpleado.Item(2, lint_indice).Value.ToString().Trim()
        Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
        btnGuardar.Text = "Modificar"
        btnGuardar.Enabled = True
        btnEliminar.Enabled = True
    End Select

  End Sub

  Private Sub cboTipoEmpleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoEmpleado.SelectedIndexChanged
    If bolBuscar Then
      Buscar_Empleado()
    End If
  End Sub

  Private Sub txtNombreBusqueda_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombreBusqueda.KeyUp
    If (e.KeyCode = Keys.Enter) Then
      Buscar_Empleado()
    End If
  End Sub

  Private Sub txtCodEmpleado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEmpleado.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
  End Sub

  Private Sub dtgEmpleado_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgEmpleado.DataBindingComplete
    If Me.dtgEmpleado.Rows.Count > 0 And Me.dtgEmpleado.CurrentCellAddress.Y > -1 Then
      Me.dtgEmpleado.CurrentRow.Selected = False
    End If
  End Sub

  Private Sub cboPaginas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaginas.SelectedIndexChanged
    cambiar_pagina()
    paginar()

  End Sub

  Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    Try
      ini = 0
      fin = 0
      ToolStripTextBox3.Text = "1"
      If ToolStripTextBox3.Text = "1" Then
        fin = VistaDefault - 1
        paginar()

      End If
    Catch : End Try

  End Sub

  Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
    Try
      ini = 0
      fin = 0
      suma = Convert.ToInt32(ToolStripTextBox3.Text.Trim())
      If ToolStripTextBox3.Text.Trim() > "1" Then
        suma = suma - 1
        If (suma = 1) Then
          ToolStripTextBox3.Text = "1"
          fin = VistaDefault - 1
          paginar()
        Else
          ToolStripTextBox3.Text = Convert.ToString(suma)
          ini = ((Convert.ToInt32(ToolStripTextBox3.Text.Trim()) - 1) * VistaDefault) - 1
          fin = ini + VistaDefault
          If fin > dtPrincipal.Rows.Count Then
            fin = dtPrincipal.Rows.Count - 1
          End If
          paginar()

        End If
      End If

    Catch : End Try

  End Sub

  Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
    Try
      ini = 0
      fin = 0
      suma = 0
      suma = Convert.ToInt32(ToolStripTextBox3.Text.Trim())
      If ((TotalPaginas > 0) And (Convert.ToInt32(ToolStripTextBox3.Text.Trim()) < TotalPaginas)) Then
        suma = suma + 1

        If (suma = TotalPaginas) Then
          ToolStripTextBox3.Text = TotalPaginas
          ini = ((Convert.ToInt32(ToolStripTextBox3.Text.Trim()) - 1) * VistaDefault) - 1
          fin = dtPrincipal.Rows.Count - 1
          If fin > dtPrincipal.Rows.Count Then
            fin = dtPrincipal.Rows.Count - 1
          End If
          paginar()
        Else
          ToolStripTextBox3.Text = Convert.ToString(suma)
          ini = ((Convert.ToInt32(ToolStripTextBox3.Text.Trim()) - 1) * VistaDefault) - 1
          fin = ini + VistaDefault
          If fin > dtPrincipal.Rows.Count Then
            fin = dtPrincipal.Rows.Count - 1
          End If
          paginar()

        End If

      End If
    Catch ex As Exception

    End Try

  End Sub

  Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
    Try
      If ((TotalPaginas > 0) And (Convert.ToInt32(ToolStripTextBox3.Text.Trim()) < TotalPaginas)) Then
        ini = 0
        fin = 0
        ToolStripTextBox3.Text = TotalPaginas
        ini = ((Convert.ToInt32(ToolStripTextBox3.Text.Trim()) - 1) * VistaDefault) - 1
        fin = dtPrincipal.Rows.Count - 1
        If fin > dtPrincipal.Rows.Count Then
          fin = dtPrincipal.Rows.Count - 1
        End If
        paginar()
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub ToolStripTextBox3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown
    If e.KeyCode = Keys.Enter Then
      If (ToolStripTextBox3.Text > "0") Then
        cambiar_pagina()
        paginar()
      End If
    End If
  End Sub

  Private Sub ToolStripTextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStripTextBox3.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
  End Sub

  Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
    If e.KeyCode = Keys.Enter Then
      If (ToolStripTextBox1.Text > "0") Then

        If dtPrincipal.Rows.Count > 0 Then
          num_paginas()
          cboPaginas.Text = "1"
          ' ToolStripTextBox1.Text = "20"
          ToolStripTextBox3.Text = "1"
          paginar()
        End If

      Else
        'If (ToolStripTextBox1.Text.Trim() = "0") Then
        '    ToolStripTextBox1.Text = "20"
        '    num_paginas()
        '    paginar()
        'End If

      End If
    End If
  End Sub

  Private Sub ToolStripTextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStripTextBox1.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
  End Sub

#End Region

End Class
