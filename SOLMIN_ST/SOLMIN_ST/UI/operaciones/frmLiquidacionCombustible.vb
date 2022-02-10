Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmLiquidacionCombustible
#Region "Atributos"
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private oDtEstado As DataTable
#End Region

#Region "Eventos"
    Private Sub frmLiquidacionCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
            Me.Cargar_Compania()
            Me.Cargar_Combos()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.dtgOperacion.Rows.Clear()
        Me.Lista_Operacion()
        If dtgOperacion.RowCount > 0 Then
            Me.Lista_Vales_Asignados()
        End If
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

#End Region

#Region "Métodos y Funciones"

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
        Me.ctbTransportista.Enabled = False
        Me.dtgOperacion.DataSource = Nothing
    End Sub

    Private Sub Cargar_Division()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            objDivision.Crea_Lista()
            Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
            Me.cboDivision.ValueMember = "CDVSN"
            Me.cboDivision.DisplayMember = "TCMPDV"
            If Me.cboCompania.SelectedValue = "EZ" Then
                Me.cboDivision.SelectedValue = "T"
            End If
            bolBuscar = True
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

                'CSR-HUNDRED-feature/151116_Combustibles-inicio

                Dim ListaPlantas As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
                ListaPlantas = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)

                Dim OPlanta As New ClaseGeneral

                OPlanta.CPLNDV = 0
                OPlanta.TPLNTA = "TODOS"
                ListaPlantas.Insert(0, OPlanta)
                'CSR-HUNDRED-feature/151116_Combustibles-fin


                Me.cboPlanta.DataSource = ListaPlantas
                Me.cboPlanta.ValueMember = "CPLNDV"
                Me.cboPlanta.DisplayMember = "TPLNTA"
                Me.cboPlanta.SelectedIndex = 0
                bolBuscar = True
                Me.Cargar_Combos()
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Compania()
        objCompaniaBLL.Crea_Lista()
        bolBuscar = False
        Me.cboCompania.DataSource = objCompaniaBLL.Lista
        Me.cboCompania.ValueMember = "CCMPN"
        Me.cboCompania.DisplayMember = "TCMPCM"
        cboCompania.SelectedValue = "EZ"
        bolBuscar = True
        If cboCompania.SelectedIndex = -1 Then
            cboCompania.SelectedIndex = 0
        End If
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cboCompania_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Lista_Operacion()
        Dim obj_Logica As New OperacionTransporte_BLL
        Dim objParametro As New Hashtable
        Dim intValorCon As Int32 = 0
        Dim rowData As DataRow
        Dim dwvrow As DataGridViewRow

        Try
            objParametro.Add("CCMPN", Me.cboCompania.SelectedValue.ToString)
            objParametro.Add("CDVSN", Me.cboDivision.SelectedValue.ToString)
            objParametro.Add("CPLNDV", CType(Me.cboPlanta.SelectedValue, Double))
            If Me.txtCliente.pCodigo = 0 Then
                objParametro.Add("CCLNT", 0)
            Else
                objParametro.Add("CCLNT", CType(Me.txtCliente.pCodigo, Integer))
            End If

            objParametro.Add("NRUCTR", ctbTransportista.pRucTransportista)
            objParametro.Add("NPLCTR", Me.txtTracto.Text.Trim)
            objParametro.Add("FECINI", HelpClass.CtypeDate(Me.dtpFecIni.Value))
            objParametro.Add("FECFIN", HelpClass.CtypeDate(Me.dtpFecFin.Value))

            If Me.txtOperacion.Text = "" Then
                objParametro.Add("NOPRCN", 0)
            Else
                objParametro.Add("NOPRCN", CType(Me.txtOperacion.Text, Integer))
            End If

            If Me.txtGuiaTransporte.Text = "" Then
                objParametro.Add("NGUIRM", 0)
            Else
                objParametro.Add("NGUIRM", CType(Me.txtGuiaTransporte.Text, Integer))
            End If

            Dim fila As Integer

            Me.dtgOperacion.AutoGenerateColumns = False
            For Each rowData In obj_Logica.Listar_Operaciones(objParametro).Rows
                dwvrow = New DataGridViewRow
                dwvrow.CreateCells(Me.dtgOperacion)

                Me.dtgOperacion.Rows.Add(dwvrow)

                'CSR-HUNDRED-feature/151116_Combustibles-INICIO
                fila = dtgOperacion.Rows.Count - 1

                dtgOperacion.Rows(fila).Cells("NOPRCN").Value = rowData.Item("NOPRCN")
                dtgOperacion.Rows(fila).Cells("FINCOP").Value = HelpClass.CFecha_de_8_a_10(rowData.Item("FINCOP").ToString.Trim)
                dtgOperacion.Rows(fila).Cells("NCSOTR").Value = rowData.Item("NCSOTR")
                dtgOperacion.Rows(fila).Cells("NPLCUN").Value = rowData.Item("NPLCUN")

                dtgOperacion.Rows(fila).Cells("TPLNTA").Value = rowData.Item("TPLNTA")
                dtgOperacion.Rows(fila).Cells("CPLNDV").Value = rowData.Item("CPLNDV")

                dtgOperacion.Rows(fila).Cells("CBRCNT").Value = rowData.Item("CBRCNT")
                dtgOperacion.Rows(fila).Cells("CTRSPT").Value = rowData.Item("CTRSPT")
                dtgOperacion.Rows(fila).Cells("CONDUCTOR").Value = rowData.Item("CONDUCTOR").ToString.Trim
                dtgOperacion.Rows(fila).Cells("NGUIRM").Value = rowData.Item("NGUIRM")
                dtgOperacion.Rows(fila).Cells("RUTA").Value = rowData.Item("RUTA")
                dtgOperacion.Rows(fila).Cells("FEMVLH").Value = HelpClass.CFecha_de_8_a_10(rowData.Item("FEMVLH").ToString.Trim)
                dtgOperacion.Rows(fila).Cells("PMRCMC").Value = rowData.Item("PMRCMC")
                dtgOperacion.Rows(fila).Cells("CTPOVJ").Value = rowData.Item("CTPOVJ").ToString.Trim
                dtgOperacion.Rows(fila).Cells("NRUCTR").Value = rowData.Item("NRUCTR").ToString.Trim
                dtgOperacion.Rows(fila).Cells("NMVJCS").Value = rowData.Item("NMVJCS").ToString.Trim

                'dwvrow.Cells(0).Value = rowData.Item("NOPRCN")
                'dwvrow.Cells(1).Value = HelpClass.CFecha_de_8_a_10(rowData.Item("FINCOP").ToString.Trim)
                'dwvrow.Cells(2).Value = rowData.Item("NCSOTR")
                'dwvrow.Cells(3).Value = rowData.Item("NPLCUN")
                'dwvrow.Cells(4).Value = rowData.Item("CBRCNT")
                'dwvrow.Cells(5).Value = rowData.Item("CTRSPT")
                'dwvrow.Cells(6).Value = rowData.Item("CONDUCTOR").ToString.Trim
                'dwvrow.Cells(7).Value = rowData.Item("NGUIRM")
                'dwvrow.Cells(8).Value = rowData.Item("RUTA")
                'dwvrow.Cells(9).Value = HelpClass.CFecha_de_8_a_10(rowData.Item("FEMVLH").ToString.Trim)
                'dwvrow.Cells(10).Value = rowData.Item("PMRCMC")
                'dwvrow.Cells(11).Value = rowData.Item("CTPOVJ").ToString.Trim
                'dwvrow.Cells(12).Value = rowData.Item("NRUCTR").ToString.Trim
                'dwvrow.Cells(13).Value = rowData.Item("NMVJCS").ToString.Trim
                'Me.dtgOperacion.Rows.Add(dwvrow)

                'CSR-HUNDRED-feature/151116_Combustibles-FIN
            Next
        Catch : End Try
    End Sub


    Private Sub Lista_Vales_Asignados()
        Dim obj_LogicaCombustible As New Combustible_BLL
        Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
        Dim objParametro As New Hashtable
        Dim dgvr As DataGridViewRow
        Try
            objParametro.Add("PNNOPRCN", Me.dtgOperacion.Item("NOPRCN", Me.dtgOperacion.CurrentCellAddress.Y).Value.ToString)
            Me.gwdAsigCombTracto.Rows.Clear()
            Me.gwdLiquiCombTracto.Rows.Clear()
            For Each obj_Combustible As Combustible In obj_LogicaCombustible.Listar_Vales_Asignados_x_Operacion(objParametro)
                dgvr = New DataGridViewRow
                dgvr.CreateCells(Me.gwdAsigCombTracto)
                dgvr.Cells(0).Value = obj_Combustible.NSLCMB
                dgvr.Cells(1).Value = HelpClass.CFecha_de_8_a_10(obj_Combustible.FSLCMB.ToString.Trim)
                dgvr.Cells(2).Value = obj_Combustible.CGRFO
                dgvr.Cells(3).Value = obj_Combustible.TGRFO
                dgvr.Cells(4).Value = obj_Combustible.CTPCMB
                dgvr.Cells(5).Value = obj_Combustible.NVLGRF
                dgvr.Cells(6).Value = obj_Combustible.NPRCN1
                dgvr.Cells(7).Value = obj_Combustible.NPRCN2
                dgvr.Cells(8).Value = obj_Combustible.NPRCN3
                dgvr.Cells(9).Value = HelpClass.CFecha_de_8_a_10(obj_Combustible.FCRCMB.ToString.Trim)
                dgvr.Cells(10).Value = obj_Combustible.QGLNCM
                dgvr.Cells(11).Value = obj_Combustible.CSTGLN
                dgvr.Cells(12).Value = obj_Combustible.SESSLC
                dgvr.Cells(13).Value = obj_Combustible.CCMPN
                dgvr.Cells(14).Value = obj_Combustible.CDVSN
                dgvr.Cells(15).Value = obj_Combustible.CPLNDV
                dgvr.Cells(16).Value = obj_Combustible.CTPOD1
                dgvr.Cells(17).Value = obj_Combustible.NDCCT1
                dgvr.Cells(18).Value = HelpClass.CFecha_de_8_a_10(obj_Combustible.FDCCT1.ToString.Trim)
                Me.gwdAsigCombTracto.Rows.Add(dgvr)
            Next

            For Each obj_LiquiCombustible As LiquidacionCombustible In obj_LogicaLiquidacion.Listar_Liquidacion_Combustible_x_Operacion(objParametro)
                dgvr = New DataGridViewRow
                dgvr.CreateCells(Me.gwdLiquiCombTracto)
                dgvr.Cells(0).Value = "Ver Detalle"
                dgvr.Cells(1).Value = obj_LiquiCombustible.NLQCMB
                dgvr.Cells(2).Value = HelpClass.CFecha_de_8_a_10(obj_LiquiCombustible.FLQDCN.ToString.Trim)
                dgvr.Cells(3).Value = obj_LiquiCombustible.CTPCMB
                'dgvr.Cells(4).Value = obj_LiquiCombustible.QGLNSA
                dgvr.Cells(4).Value = obj_LiquiCombustible.QTGLIN
                dgvr.Cells(5).Value = obj_LiquiCombustible.QGLNUT
                Me.gwdLiquiCombTracto.Rows.Add(dgvr)
            Next
        Catch : End Try
    End Sub


#End Region

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        Try
            If Me.dtgOperacion.RowCount = 0 OrElse Me.dtgOperacion.CurrentRow.Selected = False Then Exit Sub
            Dim lint_Indice_C As Integer = Me.dtgOperacion.CurrentCellAddress.Y
            Dim obj_Entidad As New Combustible
            Dim frm_AsignacionLiquidacionCombustible As New frmAsignacionLiquidacionCombustible
            With frm_AsignacionLiquidacionCombustible
                .txtCompania.Text = Me.cboCompania.Text
                .txtCompania.Tag = Me.cboCompania.SelectedValue
                .txtDivision.Text = Me.cboDivision.Text
                .txtDivision.Tag = Me.cboDivision.SelectedValue

                'CSR-HUNDRED-feature/151116_Combustibles-INICIO
                '.txtPlanta.Text = Me.cboPlanta.Text
                '.txtPlanta.Tag = Me.cboPlanta.SelectedValue
                .txtPlanta.Text = Me.dtgOperacion.Item("TPLNTA", lint_Indice_C).Value
                .txtPlanta.Tag = Me.dtgOperacion.Item("CPLNDV", lint_Indice_C).Value.ToString.Trim
                'CSR-HUNDRED-feature/151116_Combustibles-FIN

                .txtTracto.Text = Me.dtgOperacion.Item("NPLCUN", lint_Indice_C).Value
                .txtTracto.Tag = Me.dtgOperacion.Item("NRUCTR", lint_Indice_C).Value

                obj_Entidad.CCMPN = Me.cboCompania.SelectedValue
                obj_Entidad.CDVSN = Me.cboDivision.SelectedValue
                obj_Entidad.CPLNDV = Me.cboPlanta.SelectedValue
                obj_Entidad.CTRSPT = Me.dtgOperacion.Item("CTRSPT", lint_Indice_C).Value
                obj_Entidad.NRUCTR = Me.dtgOperacion.Item("NRUCTR", lint_Indice_C).Value
                obj_Entidad.NPLCUN = Me.dtgOperacion.Item("NPLCUN", lint_Indice_C).Value
                obj_Entidad.CBRCNT = Me.dtgOperacion.Item("CBRCNT", lint_Indice_C).Value
                obj_Entidad.NOPRCN = Me.dtgOperacion.Item("NOPRCN", lint_Indice_C).Value
                obj_Entidad.NPLCUN = Me.dtgOperacion.Item("NPLCUN", lint_Indice_C).Value
                obj_Entidad.NMVJCS = Me.dtgOperacion.Item("NMVJCS", lint_Indice_C).Value
                obj_Entidad.CPLNDV = Me.dtgOperacion.Item("CPLNDV", lint_Indice_C).Value.ToString.Trim 'CSR-HUNDRED-feature/151116_Combustibles
                'obj_Entidad.QKMREC = Me.dtgOperacion.Item("QKMREC", lint_Indice_C).Value


                '.txtGalonesSaldoAnterior.Text = Me.dtgOperacion.Item("QGLNSA", Me.dtgOperacion.CurrentCellAddress.Y).Value
                .obj_Entidad_Combustible = obj_Entidad
                .Tag = 0
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Me.Lista_Vales_Asignados()
            End With
        Catch ex As Exception
        End Try

    End Sub

    Private Sub dtgOperacion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOperacion.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Me.Lista_Vales_Asignados()

    End Sub

    Private Sub dtgOperacion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgOperacion.KeyUp
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Enter
                Me.Lista_Vales_Asignados()
        End Select
    End Sub

    Private Sub btnImportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarExcel.Click
        Dim ofrmImportarValeLiqCombDeExcel As New frmImportarValeLiqCombDeExcel
        If ofrmImportarValeLiqCombDeExcel.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

    End Sub

    Private Sub txtOperacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOperacion.KeyPress, txtGuiaTransporte.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back)
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

End Class
