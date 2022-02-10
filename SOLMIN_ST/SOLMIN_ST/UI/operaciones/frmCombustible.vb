Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmCombustible

#Region "Atributos"
  Private bolBuscar As Boolean
  Private objCompaniaBLL As New NEGOCIO.Compania_BLL
  Private objPlanta As New NEGOCIO.Planta_BLL
  Private objDivision As New NEGOCIO.Division_BLL
  Private objLista As New List(Of Combustible)
#End Region

#Region "Eventos"

  Private Sub frmCombustible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
      Me.Validar_Acceso_Opciones_Usuario()
      Me.Alinear_Columnas_Grilla()
      Me.Cargar_Compania()
      Me.Cargar_Combos()
      Me.Lista_Tracto_Asignacion_Combustible()
    Catch : End Try
  End Sub

  Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
    Try
      If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentRow.Selected = False Then Exit Sub
      Dim lint_Indice_C As Integer = Me.gwdDatos.CurrentCellAddress.Y
      Dim obj_Entidad As New Combustible
      Dim frm_AsignarCombustible As New frmAsignarCombustible
      With frm_AsignarCombustible
        obj_Entidad.CCMPN = Me.cboCompania.SelectedValue
        obj_Entidad.CDVSN = Me.cboDivision.SelectedValue
        obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
        obj_Entidad.CTRSPT = Me.gwdDatos.Item("CTRSPT_C", lint_Indice_C).Value
        obj_Entidad.NRUCTR = Me.gwdDatos.Item("NRUCTR_C", lint_Indice_C).Value
        obj_Entidad.NPLCUN = Me.gwdDatos.Item("NPLCUN_C", lint_Indice_C).Value
        obj_Entidad.CBRCNT = Me.gwdDatos.Item("CBRCNT_C", lint_Indice_C).Value
        .obj_Entidad_Combustible = obj_Entidad
        .Tag = 0
        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Me.gwdDatos.Item("QGNXCN_C", lint_Indice_C).Value += .cnt_Galones
        Me.gwdDatos.Item("COMTOT_C", lint_Indice_C).Value = Me.gwdDatos.Item("QGNXCN_C", lint_Indice_C).Value + Me.gwdDatos.Item("QGLNSA_C", lint_Indice_C).Value
        Me.Lista_Asignacion_Combustible_x_Tracto()
      End With
    Catch : End Try

  End Sub

  Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectedIndexChanged
    If bolBuscar Then
      Me.Cargar_Division()
    End If
  End Sub

  Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectedIndexChanged
    If bolBuscar Then
      Me.Cargar_Planta()
    End If
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.Lista_Tracto_Asignacion_Combustible()
  End Sub

  Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    If e.RowIndex < 0 Then Exit Sub
    Me.Lista_Asignacion_Combustible_x_Tracto()
  End Sub

  Private Sub gwdDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
    Select Case e.KeyCode
      Case Keys.Up, Keys.Down, Keys.Enter
        Me.Lista_Asignacion_Combustible_x_Tracto()
    End Select
  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Dim frm_frmOpRptCombustible As New frmOpRptCombustible
    Dim obj_Logica As New Combustible_BLL
    Dim objDs As New DataSet
    Dim objDt As New DataTable
    Dim objPrintForm As New PrintForm
    Dim objetoRep As New Object
    Dim objParametro As New Hashtable
    Dim lstrTipoReporte As String = ""
    Dim lstrMensaje As String = ""
    Try
      With frm_frmOpRptCombustible
        .CCMPN = Me.cboCompania.SelectedValue
        .CDVSN = Me.cboDivision.SelectedValue
        .CPLNDV = Me.cboPlanta.SelectedValue
        .NRUCTR = Me.ctbTransportista.pRucTransportista
        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        objParametro.Add("PSCCLNT", IIf(.CCLNT = 0, "", .CCLNT))
        objParametro.Add("PSNPLCUN", .NPLCUN)
        objParametro.Add("PNFECINI", .FECINI)
        objParametro.Add("PNFECFIN", .FECFIN)
        objParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue.ToString)
        objParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue.ToString)
        objParametro.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))
        objParametro.Add("STATUS", .Tag)

        Select Case .Tag
          Case 1
            Dim objCrep As New rptAsignacionCombustible
            objetoRep = objCrep
            objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Tractos_Asignacion_Combustible_RPT(objParametro))
            objDt.TableName = "RZTR75"
            lstrMensaje = "No tiene Asignaciones"
          Case 2
            If .rbtnCliente.Checked = True Then
              Dim objCrep1 As New rptLiquidacionCombustible_1
              objetoRep = objCrep1
            Else
              Dim objCrep2 As New rptLiquidacionCombustible
              objetoRep = objCrep2
            End If
            objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Tractos_Asignacion_Combustible_RPT(objParametro))
            objDt.TableName = "RZTR76"
            lstrMensaje = "No tiene Liquidaciones"
          Case 3
            Dim objCrep3 As New rptLiquidacionRendimiento
            objetoRep = objCrep3
            objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Tractos_Asignacion_Combustible_RPT(objParametro))
            objDt.TableName = "RZTR76"
            lstrMensaje = "No tiene Rendimientos"
        End Select
        If objDt.Rows.Count = 0 Then
          HelpClass.MsgBox(lstrMensaje, MessageBoxIcon.Information)
          Exit Sub
        End If
        objDs.Tables.Add(objDt.Copy)
        objetoRep.SetDataSource(objDs)
        If .Tag = 2 Then
          If .rbtnTracto.Checked = True Then
            lstrTipoReporte = "POR TRACTO"
          End If
          If .rbtnCliente.Checked = True Then
            lstrTipoReporte = "POR CLIENTE"
          End If
          CType(objetoRep.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = lstrTipoReporte
        End If
        CType(objetoRep.ReportDefinition.ReportObjects("lblFecIni"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECINI)
        CType(objetoRep.ReportDefinition.ReportObjects("lblFecFin"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECFIN)
        CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cboCompania.Text
        CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.cboDivision.Text
        CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cboPlanta.Text
        objPrintForm.ShowForm(objetoRep, Me)
      End With
    Catch : End Try

  End Sub

  Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    If Me.gwdDatos.RowCount > 0 Then Me.gwdDatos.CurrentRow.Selected = False
  End Sub

  Private Sub btnLiquidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiquidar.Click
    If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentRow.Selected = False OrElse Me.gwdDatos.CurrentRow.Cells("QGNXCN_C").Value = 0 Then Exit Sub
    'If Me.gwdDatos.CurrentRow.Cells("QGNXCN_C").Value = 0 Then Exit Sub
    Dim frm_Liquidar_Combustible As New frmLiquidarCombustible
    With frm_Liquidar_Combustible
      .txtCompania.Text = Me.cboCompania.Text
      .txtCompania.Tag = Me.cboCompania.SelectedValue
      .txtDivision.Text = Me.cboDivision.Text
      .txtDivision.Tag = Me.cboDivision.SelectedValue
      .txtPlanta.Text = Me.cboPlanta.Text
      .txtPlanta.Tag = Me.cboPlanta.SelectedValue
      .txtTracto.Text = Me.gwdDatos.CurrentRow.Cells("NPLCUN_C").Value
      .txtTracto.Tag = Me.gwdDatos.CurrentRow.Cells("NRUCTR_C").Value
      .txtGalonesSaldoAnterior.Text = Me.gwdDatos.Item("QGLNSA_C", Me.gwdDatos.CurrentCellAddress.Y).Value
      .Lista = Me.objLista
      If .ShowDialog = Windows.Forms.DialogResult.OK Then
        Me.gwdDatos.CurrentRow.Cells("QGNXCN_C").Value -= IIf(.txtGalonesAsignados.Text.Trim.Equals(""), 0, CType(.txtGalonesAsignados.Text.Trim, Double))
        Me.gwdDatos.CurrentRow.Cells("QGLNSA_C").Value = IIf(.txtGalonesTanque.Text.Equals(""), 0, CType(.txtGalonesTanque.Text, Double))
        Me.gwdDatos.CurrentRow.Cells("COMTOT_C").Value = Me.gwdDatos.CurrentRow.Cells("QGNXCN_C").Value + Me.gwdDatos.CurrentRow.Cells("QGLNSA_C").Value
      End If
      Me.Lista_Asignacion_Combustible_x_Tracto()
    End With
  End Sub

  Private Sub gwdLiquiCombTracto_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdLiquiCombTracto.CellClick
    If e.RowIndex < 0 Then Exit Sub
    If e.ColumnIndex = 0 Then
      Dim frm_DetalleLiquidacion As New frmDetalleLiquidacionCombustible
      With frm_DetalleLiquidacion
        .NLQCMB_1 = Me.gwdLiquiCombTracto.Item("NLQCMB_L", Me.gwdLiquiCombTracto.CurrentCellAddress.Y).Value
        .NPLCUN_1 = Me.gwdDatos.Item("NPLCUN_C", Me.gwdDatos.CurrentCellAddress.Y).Value
        .CCMPN_1 = Me.cboCompania.SelectedValue.ToString.Trim
        .CDVSN_1 = Me.cboDivision.SelectedValue.ToString.Trim
        .CPLNDV_1 = CType(Me.cboPlanta.SelectedValue, Double)
        .ShowDialog()
      End With
    End If
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    Try
      If Me.gwdAsigCombTracto.RowCount = 0 OrElse Me.gwdAsigCombTracto.CurrentRow.Selected = False Then Exit Sub
      Dim lint_Indice_A As Integer = Me.gwdAsigCombTracto.CurrentCellAddress.Y
      Dim obj_Entidad As New Combustible
      Dim frm_AsignarCombustible As New frmAsignarCombustible
      With frm_AsignarCombustible
        obj_Entidad.CCMPN = Me.cboCompania.SelectedValue
        obj_Entidad.CDVSN = Me.cboDivision.SelectedValue
        obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
        obj_Entidad.NVLGRF = Me.gwdAsigCombTracto.Item("NVLGRF_A", lint_Indice_A).Value
        obj_Entidad.FCRCMB_S = Me.gwdAsigCombTracto.Item("FCRCMB_A", lint_Indice_A).Value.ToString.Trim
        obj_Entidad.CGRFO = Me.gwdAsigCombTracto.Item("CGRFO_A", lint_Indice_A).Value
        obj_Entidad.CTPCMB = Me.gwdAsigCombTracto.Item("CTPCMB_A", lint_Indice_A).Value
        obj_Entidad.QGLNCM = Me.gwdAsigCombTracto.Item("QGLNCM_A", lint_Indice_A).Value
        obj_Entidad.CSTGLN = Me.gwdAsigCombTracto.Item("CSTGLN_A", lint_Indice_A).Value
        obj_Entidad.NPRCN1 = Me.gwdAsigCombTracto.Item("NPRCN1_A", lint_Indice_A).Value.ToString.Trim
        obj_Entidad.NPRCN2 = Me.gwdAsigCombTracto.Item("NPRCN2_A", lint_Indice_A).Value.ToString.Trim
        obj_Entidad.NPRCN3 = Me.gwdAsigCombTracto.Item("NPRCN3_A", lint_Indice_A).Value.ToString.Trim
        obj_Entidad.NSLCMB = Me.gwdAsigCombTracto.Item("NSLCMB_A", lint_Indice_A).Value
        obj_Entidad.CTPOD1 = Me.gwdAsigCombTracto.Item("CTPOD1_A", lint_Indice_A).Value
        obj_Entidad.NDCCT1 = Me.gwdAsigCombTracto.Item("NDCCT1_A", lint_Indice_A).Value
        obj_Entidad.FDCCT1_S = IIf(Me.gwdAsigCombTracto.Item("FDCCT1_A", lint_Indice_A).Value.ToString.Trim.Equals("00/00/0000"), Now.Date, Me.gwdAsigCombTracto.Item("FDCCT1_A", lint_Indice_A).Value)
        obj_Entidad.NPLCUN = Me.gwdDatos.Item("NPLCUN_C", Me.gwdDatos.CurrentCellAddress.Y).Value
        .obj_Entidad_Combustible = obj_Entidad
        .Tag = 1
        .btnProcesar.Visible = False
        .btnGuardar.Visible = True
        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim lint_Indice_C As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Me.gwdDatos.Item("QGNXCN_C", lint_Indice_C).Value -= CType(Me.gwdAsigCombTracto.Item("QGLNCM_A", lint_Indice_A).Value, Double)
        Me.gwdDatos.Item("QGNXCN_C", lint_Indice_C).Value += .cnt_Galones
        Me.gwdDatos.Item("COMTOT_C", lint_Indice_C).Value = Me.gwdDatos.Item("QGNXCN_C", lint_Indice_C).Value + Me.gwdDatos.Item("QGLNSA_C", lint_Indice_C).Value
        Me.Lista_Asignacion_Combustible_x_Tracto()
      End With
    Catch ex As Exception

    End Try

  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    Try
      If Me.gwdAsigCombTracto.RowCount = 0 OrElse Me.gwdAsigCombTracto.CurrentRow.Selected = False Then Exit Sub
      If MsgBox("Desea eliminar esta Asignación de Combustible", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
      Dim obj_Entidad As New Combustible
      Dim obj_Logica As New Combustible_BLL
      Dim lint_Indice_A As Integer = Me.gwdAsigCombTracto.CurrentCellAddress.Y
      obj_Entidad.NSLCMB = Me.gwdAsigCombTracto.Item("NSLCMB_A", lint_Indice_A).Value
      obj_Entidad.NRSCVL = Me.gwdAsigCombTracto.Item("NVLGRF_A", lint_Indice_A).Value
      obj_Entidad.CCMPN = Me.gwdAsigCombTracto.Item("CCMPN_A", lint_Indice_A).Value
      obj_Entidad.CDVSN = Me.gwdAsigCombTracto.Item("CDVSN_A", lint_Indice_A).Value
      obj_Entidad.CPLNDV = Me.gwdAsigCombTracto.Item("CPLNDV_A", lint_Indice_A).Value
      obj_Entidad.QGLNCM = CType(Me.gwdAsigCombTracto.Item("QGLNCM_A", lint_Indice_A).Value, Double)
      obj_Entidad.FULTAC = HelpClass.TodayNumeric
      obj_Entidad.HULTAC = HelpClass.NowNumeric
      obj_Entidad.CULUSA = MainModule.USUARIO
            obj_Entidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
      If obj_Logica.Eliminar_Asignacion_Combustible_Tracto(obj_Entidad).NSLCMB = 0 Then
        HelpClass.ErrorMsgBox()
        Exit Sub
      End If
      Dim lint_Indice_C As Integer = Me.gwdDatos.CurrentCellAddress.Y
      Me.gwdDatos.Item("QGNXCN_C", lint_Indice_C).Value -= CType(Me.gwdAsigCombTracto.Item("QGLNCM_A", lint_Indice_A).Value, Double)
      Me.gwdDatos.Item("COMTOT_C", lint_Indice_C).Value = Me.gwdDatos.Item("QGNXCN_C", lint_Indice_C).Value + Me.gwdDatos.Item("QGLNSA_C", lint_Indice_C).Value
      Me.Lista_Asignacion_Combustible_x_Tracto()
    Catch : End Try

  End Sub

  Private Sub txtPlaca_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlaca.KeyUp
    Select Case e.KeyCode
      Case Keys.Enter
        Me.Lista_Tracto_Asignacion_Combustible()
    End Select
  End Sub

#End Region

#Region "Métodos y Funciones"

  Private Sub Lista_Tracto_Asignacion_Combustible()
    Dim obj_Logica As New Combustible_BLL
    Dim objParametro As New Hashtable
    Try
      objParametro.Add("PSNRUCTR", Me.ctbTransportista.pRucTransportista)
      objParametro.Add("PSNPLCUN", Me.txtPlaca.Text.Trim)
      objParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue.ToString)
      objParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue.ToString)
      objParametro.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))

      Me.gwdDatos.DataSource = obj_Logica.Listar_Tractos_Asignacion_Combustible(objParametro)

      Me.gwdLiquiCombTracto.Rows.Clear()
      Me.gwdAsigCombTracto.Rows.Clear()
    Catch : End Try

  End Sub

  Private Sub Lista_Asignacion_Combustible_x_Tracto()
    Dim obj_LogicaCombustible As New Combustible_BLL
    Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
    Dim objParametro As New Hashtable
    Dim dgvr As DataGridViewRow
    Try
      objParametro.Add("PSNPLCUN", Me.gwdDatos.Item("NPLCUN_C", Me.gwdDatos.CurrentCellAddress.Y).Value.ToString)
      objParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue.ToString)
      objParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue.ToString)
      objParametro.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))
      objParametro.Add("PSSESSLC", "P")
      Me.objLista.Clear()
      Me.gwdAsigCombTracto.Rows.Clear()
      Me.gwdLiquiCombTracto.Rows.Clear()
      For Each obj_Combustible As Combustible In obj_LogicaCombustible.Listar_Asignacion_Combustible_x_Tractos(objParametro)
        dgvr = New DataGridViewRow
        dgvr.CreateCells(Me.gwdAsigCombTracto)
        dgvr.Cells(0).Value = obj_Combustible.NSLCMB
        dgvr.Cells(1).Value = obj_Combustible.FSLCMB_D
        dgvr.Cells(2).Value = obj_Combustible.CGRFO
        dgvr.Cells(3).Value = obj_Combustible.TGRFO
        dgvr.Cells(4).Value = obj_Combustible.CTPCMB
        dgvr.Cells(5).Value = obj_Combustible.NVLGRF
        dgvr.Cells(6).Value = obj_Combustible.NPRCN1
        dgvr.Cells(7).Value = obj_Combustible.NPRCN2
        dgvr.Cells(8).Value = obj_Combustible.NPRCN3
        dgvr.Cells(9).Value = obj_Combustible.FCRCMB_D
        dgvr.Cells(10).Value = obj_Combustible.QGLNCM
        dgvr.Cells(11).Value = obj_Combustible.CSTGLN
        dgvr.Cells(12).Value = obj_Combustible.SESSLC
        dgvr.Cells(13).Value = obj_Combustible.CCMPN
        dgvr.Cells(14).Value = obj_Combustible.CDVSN
        dgvr.Cells(15).Value = obj_Combustible.CPLNDV
        dgvr.Cells(16).Value = obj_Combustible.CTPOD1
        dgvr.Cells(17).Value = obj_Combustible.NDCCT1
        dgvr.Cells(18).Value = obj_Combustible.FDCCT1_S
        Me.gwdAsigCombTracto.Rows.Add(dgvr)
        Me.objLista.Add(obj_Combustible)
      Next

      For Each obj_LiquiCombustible As LiquidacionCombustible In obj_LogicaLiquidacion.Listar_Liquidacion_Combustible_x_Tractos(objParametro)
        dgvr = New DataGridViewRow
        dgvr.CreateCells(Me.gwdLiquiCombTracto)
        dgvr.Cells(0).Value = "Ver Detalle"
        dgvr.Cells(1).Value = obj_LiquiCombustible.NLQCMB
        dgvr.Cells(2).Value = obj_LiquiCombustible.FLQDCN_D
        dgvr.Cells(3).Value = obj_LiquiCombustible.CTPCMB
        dgvr.Cells(4).Value = obj_LiquiCombustible.QGLNSA
        dgvr.Cells(5).Value = obj_LiquiCombustible.QTGLIN
        dgvr.Cells(6).Value = obj_LiquiCombustible.QGLNUT
        Me.gwdLiquiCombTracto.Rows.Add(dgvr)
      Next
    Catch : End Try

  End Sub

  Private Sub Cargar_Compania()
    objCompaniaBLL.Crea_Lista()
    bolBuscar = False
    Me.cboCompania.DataSource = objCompaniaBLL.Lista
    Me.cboCompania.ValueMember = "CCMPN"
    bolBuscar = True
    Me.cboCompania.DisplayMember = "TCMPCM"
        'Me.cboCompania.SelectedIndex = 0
        Me.cboCompania.SelectedValue = "EZ"
        If cboCompania.SelectedIndex = -1 Then
            cboCompania.SelectedIndex = 0
        End If
        cboCompania_SelectedIndexChanged(Nothing, Nothing)
    End Sub

  Private Sub Cargar_Division()
    Try
      Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
      bolBuscar = False
      objDivision.Crea_Lista()
      Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
      Me.cboDivision.ValueMember = "CDVSN"
      bolBuscar = True
      Me.cboDivision.DisplayMember = "TCMPDV"
      If Me.cboCompania.SelectedValue = "EZ" Then
        Me.cboDivision.SelectedValue = "T"
      End If
      If Me.cboDivision.SelectedIndex = -1 Then
        Me.cboDivision.SelectedIndex = 0
      End If
      cboDivision_SelectedIndexChanged(Nothing, Nothing)
      Me.Cursor = System.Windows.Forms.Cursors.Default
    Catch ex As Exception
      Me.Cursor = System.Windows.Forms.Cursors.Default
      HelpClass.MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub Cargar_Planta()
    Try
      If bolBuscar Then
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        bolBuscar = False
        objPlanta.Crea_Lista()
        Me.cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
        Me.cboPlanta.ValueMember = "CPLNDV"
        bolBuscar = True
        Me.cboPlanta.DisplayMember = "TPLNTA"
        Me.cboPlanta.SelectedIndex = 0
        Me.Cargar_Combos()
        Me.Cursor = System.Windows.Forms.Cursors.Default
      End If
    Catch ex As Exception
      Me.Cursor = System.Windows.Forms.Cursors.Default
      HelpClass.MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub Cargar_Combos()
    Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    If Me.cboCompania.SelectedValue = "EZ" Then
      obeTransportista.pCCMPN_Compania = Me.cboCompania.SelectedValue
      obeTransportista.pNRUCTR_RucTransportista = "20100039207"
      Me.ctbTransportista.pCargar(obeTransportista)
    Else
      Me.ctbTransportista.pClear()
      obeTransportista.pCCMPN_Compania = Me.cboCompania.SelectedValue
      Me.ctbTransportista.pCargar(obeTransportista)
    End If
    Me.gwdDatos.DataSource = Nothing
  End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    Me.gwdAsigCombTracto.AutoGenerateColumns = False
    Me.gwdLiquiCombTracto.AutoGenerateColumns = False
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.gwdAsigCombTracto.ColumnCount - 1
      Me.gwdAsigCombTracto.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_contador As Integer = 0 To Me.gwdLiquiCombTracto.ColumnCount - 1
      Me.gwdLiquiCombTracto.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Validar_Acceso_Opciones_Usuario()
    Dim objParametro As New Hashtable
    Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
    Dim objEntidad As New ClaseGeneral

    objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
    objParametro.Add("MMCUSR", MainModule.USUARIO)
    objParametro.Add("MMNPVB", Me.Name.Trim)
    objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

    If objEntidad.STSCHG = "" Then
      Me.btnModificar.Visible = False
      Me.tsSeparador_3.Visible = False
    End If
    If objEntidad.STSELI = "" Then
      Me.btnEliminar.Visible = False
      Me.tsSeparador_3.Visible = False
    End If
    If objEntidad.STSOP1 = "" Then
      Me.btnAsignar.Visible = False
      Me.tsSeparador_2.Visible = False
    End If
    If objEntidad.STSOP2 = "" Then
      Me.btnLiquidar.Visible = False
      Me.tsSeparador_2.Visible = False
    End If

  End Sub

#End Region
End Class
