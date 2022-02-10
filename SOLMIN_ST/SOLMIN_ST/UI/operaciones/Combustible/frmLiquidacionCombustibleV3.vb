Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Threading
Imports System.Reflection
Imports System.ComponentModel
Imports Ransa.Utilitario




Public Class frmLiquidacionCombustibleV3
#Region "Atributos"
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL

 


#End Region

#Region "Eventos"
    Private Sub frmLiquidacionCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gwdLiquiCombTracto.AutoGenerateColumns = False
            dtgLiquidacion.AutoGenerateColumns = False
            dtgVales.AutoGenerateColumns = False
            dtgUreaAsignado.AutoGenerateColumns = False
            dtpFecIni.Value = Now.AddMonths(-1)
            Me.Cargar_Compania()
            TabAsignacionCombustible_SelectedIndexChanged(TabAsignacionCombustible, Nothing)
            chk.Checked = True
            chk_CheckedChanged(chk, Nothing)
            cargarComboEstado()
            'ESTADO
            'G : GENERADO
            'P : PRE-CERRADO
            'C : CERRADO
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub CargaEstados()

    '    Me.cboPlanta.DataSource = ListaPlantas
    '    Me.cboPlanta.ValueMember = "CPLNDV"
    '    Me.cboPlanta.DisplayMember = "TPLNTA"
    '    Me.cboPlanta.SelectedIndex = 0

    'End Sub

    Private Function DevuelveEstadoSeleccionadas() As String
        Dim strCodigo As String
        strCodigo = ""
        For i As Integer = 0 To cboEstado.CheckedItems.Count - 1
            If cboEstado.CheckedItems(i).Value = "T" Then
                strCodigo = "T"
                Exit For
            Else
                strCodigo &= cboEstado.CheckedItems(i).Value & ","
            End If
        Next
        If strCodigo <> "T" Then
            strCodigo = strCodigo.Trim.Substring(0, strCodigo.Trim.Length - 1)
        End If

        Return strCodigo

    End Function

    Private Sub cargarComboEstado()

        Dim oclsGeneral As New TipoDatoGeneral_BLL
        Dim oListbeGeneral As New List(Of TipoDatoGeneral)
        oListbeGeneral = oclsGeneral.Lista_Tipo_Dato_General(Me.cboCompania.SelectedValue.ToString, "STELQC")
        Dim oDt As New DataTable
        Dim oDr As DataRow
        oDt.Columns.Add("COD")
        oDt.Columns.Add("DES")
        For Each item As TipoDatoGeneral In oListbeGeneral
            oDr = oDt.NewRow
            oDr.Item("COD") = item.CODIGO_TIPO
            oDr.Item("DES") = item.DESC_TIPO
            oDt.Rows.Add(oDr)
        Next
        oDr = oDt.NewRow
        oDr.Item("COD") = "T"
        oDr.Item("DES") = "Todos"
        oDt.Rows.InsertAt(oDr, 0)


        With Me.cboEstado
            .DataSource = oDt
            .ValueMember = "COD"
            .DisplayMember = "DES"
        End With

        For i As Integer = 0 To cboEstado.Items.Count - 1
            If cboEstado.Items(i).Value = "P" Or cboEstado.Items(i).Value = "G" Then
                cboEstado.SetItemChecked(i, True)
            End If
        Next


    End Sub



   

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Lista_Liquidacion_combustible()
            Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectedIndexChanged
        If bolBuscar Then
            Me.Cargar_Division()
        End If
    End Sub



#End Region

#Region "Métodos y Funciones"

    Private Sub Lista_Liquidacion_combustible()

        Dim lis_estado As String = ""
        If chk.Checked = False Then
            If txtVehiculo.Text.Trim = "" And Val(txtLiquidacion.Text.Trim) = 0 Then
                MessageBox.Show("Ingrese vehículo o Nro Liquidación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            lis_estado = "T"
        Else
            lis_estado = DevuelveEstadoSeleccionadas()
        End If

        Dim obj_LogicaCombustible As New Combustible_BLL
        Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
        Dim objParametro As New Hashtable
        objParametro.Add("PNNLQCMB", Val(txtLiquidacion.Text.Trim))
        objParametro.Add("CCMPN", Me.cboCompania.SelectedValue.ToString)
        objParametro.Add("CDVSN", Me.cboDivision.SelectedValue.ToString)
        objParametro.Add("CPLNDV", 0)
        objParametro.Add("FECINI", HelpClass.CtypeDate(Me.dtpFecIni.Value))
        objParametro.Add("FECFIN", HelpClass.CtypeDate(Me.dtpFecFin.Value))
        objParametro.Add("NPLCUN", Me.txtVehiculo.Text.Trim)
        objParametro.Add("SESTRG", lis_estado)
        Dim dtresult As New DataTable
        dtresult = obj_LogicaLiquidacion.Listar_Liquidacion_Combustible_V2(objParametro)

        dtgLiquidacion.DataSource = Nothing
        dtgVales.DataSource = Nothing
        gwdLiquiCombTracto.DataSource = dtresult


    End Sub

   
    Private Sub Cargar_Division()
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



    Private Sub Lista_Vales_Asignados()
        Dim obj_LogicaCombustible As New Combustible_BLL

        Dim objParametro As New Hashtable
        Dim pCompania As String = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
        Dim pNroLiq As String = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
        objParametro.Add("PSCCMPN", pCompania)
        objParametro.Add("PNNLQCMB", pNroLiq)
        Dim dt As New DataTable
        dt = obj_LogicaCombustible.Listar_Vales_Asignados_x_Liquidacion(objParametro)
        dtgVales.DataSource = dt

    End Sub

    Private Sub Lista_Urea_Asignado()
        Dim oUrea_BLL As New SOLMIN_ST.NEGOCIO.Urea_BLL
        Dim objParametro As New Hashtable
        Dim oUrea As New SOLMIN_ST.ENTIDADES.Urea
        oUrea.CCMPN = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
        oUrea.NLQCMB = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
        Dim dt As New DataTable
        dt = oUrea_BLL.Listar_Urea_Asignado_x_Liquidacion(oUrea)
        dtgUreaAsignado.DataSource = dt

    End Sub

#End Region

    Private Sub btnImportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click

        Try

            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Liquidaciones"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Liquidaciones"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Liquidaciones Combustible"))
            'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.gwdLiquiCombTracto.DataSource, DataTable).Copy
            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(gwdLiquiCombTracto, objDt))
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim ofrmAgregarLiquidaciones As New frmAgregarLiquidaciones
            ofrmAgregarLiquidaciones.ccmpn = cboCompania.SelectedValue.ToString()
            ofrmAgregarLiquidaciones.dvsn = cboDivision.SelectedValue.ToString()
            ofrmAgregarLiquidaciones.ShowDialog()
            If ofrmAgregarLiquidaciones.pDialog = True Then
                Lista_Liquidacion_combustible()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    'Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    '    Dim frm_frmOpRptCombustible As New frmOpRptCombustible
    '    Dim obj_Logica As New Combustible_BLL
    '    Dim objDs As New DataSet
    '    Dim objDt As New DataTable
    '    Dim objPrintForm As New PrintForm
    '    Dim objetoRep As New Object
    '    Dim objParametro As New Hashtable
    '    Dim lstrTipoReporte As String = ""
    '    Dim lstrMensaje As String = ""
    '    Try
    '        With frm_frmOpRptCombustible
    '            .CCMPN = Me.cboCompania.SelectedValue
    '            .CDVSN = Me.cboDivision.SelectedValue
    '            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
    '            objParametro.Add("PSCCLNT", IIf(.CCLNT = 0, "", .CCLNT))
    '            objParametro.Add("PSNPLCUN", .NPLCUN)
    '            objParametro.Add("PNFECINI", .FECINI)
    '            objParametro.Add("PNFECFIN", .FECFIN)
    '            objParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue.ToString)
    '            objParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue.ToString)
    '            objParametro.Add("PNCPLNDV", 0)
    '            objParametro.Add("STATUS", .Tag)

    '            Select Case .Tag
    '                Case 1
    '                    Dim objCrep As New rptAsignacionCombustible
    '                    objetoRep = objCrep
    '                    objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Tractos_Asignacion_Combustible_RPT(objParametro))
    '                    objDt.TableName = "RZTR75"
    '                    lstrMensaje = "No tiene Asignaciones"
    '                Case 2
    '                    If .rbtnCliente.Checked = True Then
    '                        Dim objCrep1 As New rptLiquidacionCombustible_1
    '                        objetoRep = objCrep1
    '                    Else
    '                        Dim objCrep2 As New rptLiquidacionCombustible
    '                        objetoRep = objCrep2
    '                    End If
    '                    objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Tractos_Asignacion_Combustible_RPT(objParametro))
    '                    objDt.TableName = "RZTR76"
    '                    lstrMensaje = "No tiene Liquidaciones"
    '                Case 3
    '                    Dim objCrep3 As New rptLiquidacionRendimiento
    '                    objetoRep = objCrep3
    '                    objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Tractos_Asignacion_Combustible_RPT(objParametro))
    '                    objDt.TableName = "RZTR76"
    '                    lstrMensaje = "No tiene Rendimientos"
    '            End Select
    '            If objDt.Rows.Count = 0 Then
    '                HelpClass.MsgBox(lstrMensaje, MessageBoxIcon.Information)
    '                Exit Sub
    '            End If
    '            objDs.Tables.Add(objDt.Copy)
    '            objetoRep.SetDataSource(objDs)
    '            If .Tag = 2 Then
    '                If .rbtnTracto.Checked = True Then
    '                    lstrTipoReporte = "POR TRACTO"
    '                End If
    '                If .rbtnCliente.Checked = True Then
    '                    lstrTipoReporte = "POR CLIENTE"
    '                End If
    '                CType(objetoRep.ReportDefinition.ReportObjects("lblTipoReporte"), TextObject).Text = lstrTipoReporte
    '            End If
    '            CType(objetoRep.ReportDefinition.ReportObjects("lblFecIni"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECINI)
    '            CType(objetoRep.ReportDefinition.ReportObjects("lblFecFin"), TextObject).Text = HelpClass.CNumero_a_Fecha(.FECFIN)
    '            CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
    '            CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cboCompania.Text
    '            CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.cboDivision.Text
    '            CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = ""
    '            objPrintForm.ShowForm(objetoRep, Me)
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try




    'End Sub

    


   




    'Private Sub Listar_Imagenes(ByVal PNNLQCMB As Integer)
    '    Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
    '    Dim OBJPARAMETRO As New Hashtable
    '    Dim band As Boolean = False
    '    Dim dgvr As DataGridViewRow
    '    OBJPARAMETRO.Add("PNNLQCMB", PNNLQCMB)

    '    Dim c As Integer = 0


    '    For Each obj_LiquiCombustible As LiquidacionCombustible In obj_LogicaLiquidacion.Listar_Imagenes_x_Liquidacion(OBJPARAMETRO)
    '        c = 1
    '        dgvr = New DataGridViewRow
    '        dgvr.CreateCells(Me.gwdImagenes)
    '        dgvr.Cells(1).Value = obj_LiquiCombustible.NLQCMB
    '        dgvr.Cells(2).Value = obj_LiquiCombustible.RUTA
    '        dgvr.Cells(3).Value = obj_LiquiCombustible.IMG
    '        dgvr.Cells(4).Value = obj_LiquiCombustible.EXT
    '        Me.gwdImagenes.Rows.Add(dgvr)
    '    Next

    '    If c = 0 Then Me.gwdImagenes.Rows.Clear()




    'End Sub


    'Private Sub gwdImagenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gwdImagenes.CellClick
    '    Try
    '        If e.ColumnIndex = 6 And e.RowIndex >= 0 Then


    '            Dim frmImagen As frmImagen

    '            Dim ruta As String
    '            Dim ext As String
    '            Dim img As String

    '            Dim arriba As Integer
    '            Dim izquierda As Integer

    '            ruta = "D:\AppWeb\Control_Liq_Combustible\Control_Liq_Combustible" & gwdImagenes.Rows(e.RowIndex).Cells(2).Value
    '            img = gwdImagenes.Rows(e.RowIndex).Cells(3).Value
    '            ext = gwdImagenes.Rows(e.RowIndex).Cells(4).Value

    '            ruta = ruta & img & ext

    '            arriba = Me.Top
    '            izquierda = Me.Left

    '            frmImagen = New frmImagen(ruta)

    '            For Each frm As Form In My.Application.OpenForms
    '                If UCase(frm.Name) = UCase(frmImagen.Name) Then
    '                    MessageBox.Show("El formulario se encuentra abierto")
    '                    Exit Sub
    '                End If
    '            Next frm

    '            frmImagen.Show()
    '            frmImagen.BringToFront()
    '            frmImagen.WindowState = FormWindowState.Normal

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub



    'Private Sub btnCargarVales_Click(sender As Object, e As EventArgs) Handles btnCargarVales.Click

    '    If gwdLiquiCombTracto.CurrentRow Is Nothing Then
    '        Exit Sub
    '    End If

    '    Try
    '        Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
    '        'If CodEstado = "C" Or CodEstado = "P" Then
    '        If CodEstado = "C" Then
    '            'MessageBox.Show("No puede agregar . Liquidación Pre-Cerrada o Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            MessageBox.Show("No puede agregar . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        Dim PNNLQCMB As Decimal = 0
    '        Dim CCMPN As String
    '        Dim CDVSN As String
    '        Dim NPLCUN As String
    '        PNNLQCMB = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value ' CType(gwdLiquiCombTracto.Rows(gwdLiquiCombTracto.CurrentRow.Index).Cells(2).Value, Integer)
    '        CCMPN = Me.cboCompania.SelectedValue.ToString
    '        CDVSN = Me.cboDivision.SelectedValue.ToString
    '        NPLCUN = gwdLiquiCombTracto.CurrentRow.Cells("NPLCUN2").Value
    '        Dim frmVale As New frmRegValeCombustible(PNNLQCMB, CCMPN, CDVSN, 0, 0)
    '        frmVale.pAccion = frmRegValeCombustible.Accion.Nuevo
    '        frmVale.ShowDialog()
    '        If frmVale.pDialogOK = True Then
    '            Me.Lista_Vales_Asignados()

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    'Private Sub btnActualizarImp_Click(sender As Object, e As EventArgs) Handles btnActualizarImp.Click
    '    If gwdLiquiCombTracto.CurrentRow Is Nothing Then
    '        Exit Sub
    '    End If
    '    Try
    '        Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim

    '        If CodEstado = "C" Then
    '            MessageBox.Show("No puede actualizar . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        Dim ofrmCargaVales As New frmCargaVales
    '        ofrmCargaVales.pNLQCMB = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
    '        ofrmCargaVales.pCCMPN = cboCompania.SelectedValue
    '        ofrmCargaVales.ShowDialog()
    '        Lista_Vales_Asignados()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub



    Private Sub ListarValesCombustible()

        Dim pNroLiq As Decimal = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
        Dim pCCMPN As String = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value

        Dim obj_LogicaCombustible As New Combustible_BLL
        Dim objParametro As New Hashtable
        objParametro.Add("PSCCMPN", pCCMPN)
        objParametro.Add("PNNLQCMB", pNroLiq)
        Dim dt As New DataTable
        dt = obj_LogicaCombustible.Listar_Vales_Asignados_x_Liquidacion(objParametro)
        dtgVales.DataSource = dt
    End Sub

    Private Sub ListarOperacionesLiqCombustible()

        Dim pNroLiq As Decimal = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
        Dim pCCMPN As String = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value

        Dim obj_LogicaCombustible As New Combustible_BLL
        Dim objParametro As New Hashtable
        objParametro.Add("PSCCMPN", pCCMPN)
        objParametro.Add("PNNLQCMB", pNroLiq)
        Dim dt As New DataTable
        dt = obj_LogicaCombustible.Listar_Operaciones_Asignados_x_Liquidacion(objParametro)
        dtgLiquidacion.DataSource = dt

    End Sub


    'Private Sub btnCargaOperacion_Click(sender As Object, e As EventArgs) Handles btnCargaOperacion.Click

    '    If gwdLiquiCombTracto.CurrentRow Is Nothing Then
    '        Exit Sub
    '    End If
    '    Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
    '    If CodEstado = "C" Then

    '        MessageBox.Show("No puede agregar . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If


    '    Dim pNroLiq As Decimal = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
    '    Dim pCCMPN As String = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
    '    Dim pCDVSN As String = gwdLiquiCombTracto.CurrentRow.Cells("CDVSN").Value
    '    Dim pTracto As String = gwdLiquiCombTracto.CurrentRow.Cells("NPLCUN2").Value


    '    Try
    '        Dim OfrmListarOpAsig As New frmListarOpAsig
    '        OfrmListarOpAsig.pPlaca = pTracto
    '        OfrmListarOpAsig.pCCMPN = pCCMPN
    '        OfrmListarOpAsig.pCDVSN = pCDVSN
    '        OfrmListarOpAsig.pNroLiqComb = pNroLiq

    '        OfrmListarOpAsig.ShowDialog()
    '        If OfrmListarOpAsig.pDialog = True Then
    '            ListarOperacionesLiqCombustible()
    '        End If


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try



    'End Sub


    'Private Sub txtLiquidacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLiquidacion.KeyPress
    '    If Char.IsNumber(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub



    'Private Sub btnPreCerrar_Click(sender As Object, e As EventArgs)
    '    If gwdLiquiCombTracto.CurrentRow Is Nothing Then
    '        Exit Sub
    '    End If
    '    Try
    '        Dim objParametro As New Hashtable
    '        Dim obj_LogicaCombustible As New Combustible_BLL
    '        Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL

    '        Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
    '        If CodEstado = "P" Then
    '            MessageBox.Show("La liquidación ya se encuentra Pre-Cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If
    '        If CodEstado = "C" Then
    '            MessageBox.Show("No puede Pre-Cerrar . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If


    '        Dim ofrmCerrarLiqCombustible As New frmCerrarLiqCombustible
    '        ofrmCerrarLiqCombustible.pCCMPN = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
    '        ofrmCerrarLiqCombustible.pNLQCMB = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
    '        ofrmCerrarLiqCombustible.pTipoCierre = frmCerrarLiqCombustible.TipoCierre.PreCierre
    '        ofrmCerrarLiqCombustible.ShowDialog()
    '        If ofrmCerrarLiqCombustible.pDialog = True Then
    '            gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value = "P"
    '            gwdLiquiCombTracto.CurrentRow.Cells("ESTADO").Value = "PRE-CERRADO"
    '            ListarOperacionesLiqCombustible()
    '            'Lista_Liquidacion_combustible()
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub



   


 

    Private Sub gwdLiquiCombTracto_SelectionChanged(sender As Object, e As EventArgs) Handles gwdLiquiCombTracto.SelectionChanged
        Try

            If gwdLiquiCombTracto.CurrentRow Is Nothing Then
                Exit Sub
            End If
            ListarOperacionesLiqCombustible()
            Lista_Vales_Asignados()
            Lista_Urea_Asignado()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

  

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If gwdLiquiCombTracto.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim CodEstado As String = gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value
            If CodEstado = "C" Then
                'If CodEstado = "P" Or CodEstado = "C" Then
                'MessageBox.Show("No puede eliminar. Liquidación Pre-Cerrada/Cerrada", "SOLMIN ST", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("No puede eliminar. Liquidación Cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If dtgLiquidacion.Rows.Count > 0 Then
                MessageBox.Show("No puede eliminar. Tiene operaciones asignadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If dtgVales.Rows.Count > 0 Then
                MessageBox.Show("No puede eliminar. Tiene vales asignadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            If MessageBox.Show("Está seguro de eliminar la liquidación?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            Dim objParam As New Hashtable
            Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
            Dim pNroLiq As Decimal = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
            Dim pCCMPN As String = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
            objParam.Add("PNNLQCMB", pNroLiq)
            objParam.Add("PSCCMPN", pCCMPN)
            objParam.Add("PSCULUSA", MainModule.USUARIO)
            objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)

            Dim msg As String = obj_LogicaLiquidacion.Eliminar_Liquidacion_Combustible(objParam)
            If msg <> "" Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Liquidación eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Lista_Liquidacion_combustible()
            End If
            '
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

   

    Private Sub TabAsignacionCombustible_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabAsignacionCombustible.SelectedIndexChanged
        Dim ColName As String = ""
        ColName = TabAsignacionCombustible.SelectedTab.Name
        Select Case ColName
            Case "tabAsigOP"

                btnasignavalemasivo.Visible = False
                btnEliminarReg.Visible = True
                btnEditar.Visible = False
                'btnActualizarImp.Visible = False
                btnAsignar.Visible = True

            Case "tabAsigVale"

                btnasignavalemasivo.Visible = True
                btnEliminarReg.Visible = True
                btnEditar.Visible = True
                'btnActualizarImp.Visible = True
                btnAsignar.Visible = True

            Case "tabAsigUrea"

                btnasignavalemasivo.Visible = False
                btnEliminarReg.Visible = True
                btnEditar.Visible = True
                'btnActualizarImp.Visible = True
                btnAsignar.Visible = True

        End Select
    End Sub

    Private Sub btnEliminarReg_Click(sender As Object, e As EventArgs) Handles btnEliminarReg.Click
        If gwdLiquiCombTracto.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Try
            Dim ColName As String = ""
            ColName = TabAsignacionCombustible.SelectedTab.Name
            Select Case ColName
                Case "tabAsigOP"

                    If dtgLiquidacion.CurrentRow Is Nothing Then
                        Exit Sub
                    End If


                    Dim CodEstado As String = gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value
                    If CodEstado = "C" Then
                        'If CodEstado = "P" Or CodEstado = "C" Then
                        'MessageBox.Show("No puede eliminar. Liquidación Pre-Cerrada/Cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MessageBox.Show("No puede eliminar. Liquidación Cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If MessageBox.Show("Está seguro de eliminar la op. ?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If


                    Dim objOperacion As New LiquidacionCombustible
                    Dim obj_LiquidacionCombustible_Logica As New LiquidacionCombustible_BLL
                    objOperacion.NLQCMB = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
                    objOperacion.NOPRCN = dtgLiquidacion.CurrentRow.Cells("NOPRCN").Value
                    objOperacion.CULUSA = MainModule.USUARIO
                    objOperacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    obj_LiquidacionCombustible_Logica.Eliminar_Detalle_Liquidacion_Combustible(objOperacion)
                    ListarOperacionesLiqCombustible()

                Case "tabAsigVale"



                    If dtgVales.CurrentRow Is Nothing Then
                        Exit Sub
                    End If

                    Dim CodEstado As String = gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value
                    If CodEstado = "C" Then
                        'If CodEstado = "P" Or CodEstado = "C" Then
                        'MessageBox.Show("No puede eliminar. Liquidación Pre-Cerrada/Cerrada", "SOLMIN ST", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MessageBox.Show("No puede eliminar. Liquidación Cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If


                    If MessageBox.Show("Está seguro de eliminar el vale ?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    'gwdLiquiCombTracto

                    Dim obrValeCombustible As New ValeCombustible_BLL
                    Dim obeValeCombustible As New ValeCombustible
                    Dim msg As String = ""
                    With obeValeCombustible
                        .NLQCMB = dtgVales.CurrentRow.Cells("NLQCMB_V").Value
                        .CCMPN = dtgVales.CurrentRow.Cells("CCMPN_V").Value
                        .NRITEM = dtgVales.CurrentRow.Cells("NRITEM").Value
                        .CULUSA = MainModule.USUARIO
                        .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    End With
                    msg = obrValeCombustible.Eliminar_Vale_Liquidacion_Combustible(obeValeCombustible)
                    If msg <> "" Then
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Lista_Vales_Asignados()
                    End If


                Case "tabAsigUrea"


                    If dtgUreaAsignado.CurrentRow Is Nothing Then
                        Exit Sub
                    End If

                    Dim CodEstado As String = gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value
                    If CodEstado = "C" Then
                        MessageBox.Show("No puede eliminar. Liquidación Cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If


                    If MessageBox.Show("Está seguro de eliminar el vale ?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    Dim oUrea_BLL As New SOLMIN_ST.NEGOCIO.Urea_BLL
                    Dim oUrea As New SOLMIN_ST.ENTIDADES.Urea
                    Dim msg As String = ""
                    With oUrea
                        .NLQCMB = dtgUreaAsignado.CurrentRow.Cells("NLQCMB_U").Value
                        .CCMPN = dtgUreaAsignado.CurrentRow.Cells("CCMPN_U").Value
                        .NRITEM = dtgUreaAsignado.CurrentRow.Cells("NRITEM_U").Value
                        .CULUSA = MainModule.USUARIO
                        .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    End With
                    msg = oUrea_BLL.Eliminar_Urea_Liquidacion_Asignado(oUrea)
                    If msg <> "" Then
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Lista_Urea_Asignado()
                    End If


            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click

        Dim ofrmAdDocCombustible As New frmAdDocCombustible
        'Try
        '    If gwdLiquiCombTracto.CurrentRow Is Nothing Then
        '        Exit Sub
        '    End If


        '    Dim ofrmAdDocCombustible As New frmAdDocCombustible
        '    With ofrmAdDocCombustible
        '        .pTABLE_NAME = "RZTR76"
        '        .pUSER_NAME = MainModule.USUARIO
        '        .pCCMPN = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
        '        .pSCDVSN = gwdLiquiCombTracto.CurrentRow.Cells("CDVSN").Value
        '        .pNCPLNDV = 0
        '        .pNCCLNT = 0
        '        .pNMRGIM = gwdLiquiCombTracto.CurrentRow.Cells("NMRGIM").Value
        '        .pNLQCMB = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
        '        .ShowDialog()

        '    End With
        '    If ofrmAdDocCombustible.pDialog = True Then
        '        Lista_Liquidacion_combustible()
        '    End If


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        Try
            If gwdLiquiCombTracto.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
            ofrmCargaAdjuntos.pNroImagen = gwdLiquiCombTracto.CurrentRow.Cells("NMRGIM").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZTR76
            ofrmCargaAdjuntos.pAsignarCargaMotivo("RZTR76", "01")
            Dim CodCompania As String = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
            Dim NroLiqComb As String = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZTR76(CodCompania, NroLiqComb)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then
                gwdLiquiCombTracto.CurrentRow.Cells("NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    gwdLiquiCombTracto.CurrentRow.Cells("NMRGIM_IMG").Value = "X"
                Else
                    gwdLiquiCombTracto.CurrentRow.Cells("NMRGIM_IMG").Value = ""
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

  

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If gwdLiquiCombTracto.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Try
            Dim ColName As String = ""
            ColName = TabAsignacionCombustible.SelectedTab.Name
            Select Case ColName
                Case "tabAsigUrea"

                    Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                    If CodEstado = "C" Then
                        MessageBox.Show("No puede agregar . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    If dtgUreaAsignado.CurrentRow Is Nothing Then
                        Exit Sub
                    End If

                    Dim PNNLQCMB As Decimal = dtgUreaAsignado.CurrentRow.Cells("NLQCMB_U").Value
                    Dim pNRITEM As Decimal = dtgUreaAsignado.CurrentRow.Cells("NRITEM_U").Value
                    Dim CCMPN As String = dtgUreaAsignado.CurrentRow.Cells("CCMPN_U").Value


                    Dim ofrmUrea As New frmRegUrea(PNNLQCMB, CCMPN, pNRITEM)
                    ofrmUrea.pAccion = frmRegUrea.Accion.Editar
                    ofrmUrea.ShowDialog()
                    If ofrmUrea.pDialogOK = True Then
                        Lista_Urea_Asignado()
                    End If


                Case "tabAsigVale"

                    Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                    If CodEstado = "C" Then
                        MessageBox.Show("No puede editar . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    If dtgVales.CurrentRow Is Nothing Then
                        Exit Sub
                    End If


                    Dim PNNLQCMB As Decimal = dtgVales.CurrentRow.Cells("NLQCMB_V").Value
                    Dim pNRITEM As Decimal = dtgVales.CurrentRow.Cells("NRITEM").Value
                    Dim CCMPN As String = dtgVales.CurrentRow.Cells("CCMPN_V").Value
                    Dim CDVSN As String = Me.cboDivision.SelectedValue.ToString


                    Dim frmVale As New frmRegValeCombustible(PNNLQCMB, CCMPN, CDVSN, pNRITEM)
                    frmVale.pAccion = frmRegValeCombustible.Accion.Editar
                    frmVale.pCodEstadoLiq = CodEstado
                    frmVale.ShowDialog()
                    If frmVale.pDialogOK = True Then
                        Me.Lista_Vales_Asignados()

                    End If

            End Select

          

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 

 
    Private Sub gwdLiquiCombTracto_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gwdLiquiCombTracto.CellContentDoubleClick
        Try
            If gwdLiquiCombTracto.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ColName As String = gwdLiquiCombTracto.Columns(e.ColumnIndex).Name
            If ColName = "NLQCMB" Then

                Dim ofrmAgregarLiquidaciones As New frmAgregarLiquidaciones
                ofrmAgregarLiquidaciones.ccmpn = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value  'cboCompania.SelectedValue.ToString()
                ofrmAgregarLiquidaciones.dvsn = gwdLiquiCombTracto.CurrentRow.Cells("CDVSN").Value ' cboDivision.SelectedValue.ToString()
                ofrmAgregarLiquidaciones.pEstado = gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value
                ofrmAgregarLiquidaciones.pPlaca = gwdLiquiCombTracto.CurrentRow.Cells("NPLCUN2").Value
                ofrmAgregarLiquidaciones.NroLiqComb = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
                frmAgregarLiquidaciones.btnRegis.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                ofrmAgregarLiquidaciones.ShowDialog()
                If ofrmAgregarLiquidaciones.pDialog = True Then
                    Me.Lista_Liquidacion_combustible()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub btnAnularPrecierre_Click(sender As Object, e As EventArgs)
    '    Try

    '        If gwdLiquiCombTracto.CurrentRow Is Nothing Then
    '            Exit Sub
    '        End If

    '        Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
    '        If CodEstado = "C" Then
    '            MessageBox.Show("No puede anular . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If
    '        If CodEstado = "G" Then
    '            MessageBox.Show("No puede anular . Liquidación aún no Pre-Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        If MessageBox.Show("Está seguro de eliminar ?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
    '            Exit Sub
    '        End If

    '        Dim oLiquidacionCombustible_BLL As New LiquidacionCombustible_BLL
    '        Dim objParam As New Hashtable
    '        Dim pNroLiqC As Decimal = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
    '        Dim pCompania As String = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
    '        objParam.Add("PNNLQCMB", pNroLiqC)
    '        objParam.Add("PSCCMPN", pCompania)
    '        objParam.Add("PSCULUSA", MainModule.USUARIO)
    '        objParam.Add("PSNTRMNL", HelpClass.NombreMaquina())

    '        Dim msg As String = ""
    '        msg = oLiquidacionCombustible_BLL.Anular_Pre_Cierre_Liquidacion_Combustible(objParam)
    '        If msg <> "" Then
    '            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Else
    '            MessageBox.Show("Pre-Cierre anulado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value = "G"
    '            gwdLiquiCombTracto.CurrentRow.Cells("ESTADO").Value = "GENERADO"
    '            ListarOperacionesLiqCombustible()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles chk.CheckedChanged

        dtpFecFin.Enabled = chk.Checked
        dtpFecIni.Enabled = chk.Checked

    End Sub

    'Private Sub btnEditLiq_Click(sender As Object, e As EventArgs)
    '    Try
    '        If gwdLiquiCombTracto.CurrentRow Is Nothing Then
    '            Exit Sub
    '        End If
    '        Dim ofrmAgregarLiquidaciones As New frmAgregarLiquidaciones
    '        Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
    '        ofrmAgregarLiquidaciones.ccmpn = cboCompania.SelectedValue.ToString()
    '        ofrmAgregarLiquidaciones.dvsn = cboDivision.SelectedValue.ToString()
    '        ofrmAgregarLiquidaciones.NroLiqComb = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
    '        ofrmAgregarLiquidaciones.pEstado = CodEstado
    '        ofrmAgregarLiquidaciones.ShowDialog()
    '        If ofrmAgregarLiquidaciones.pDialog = True Then
    '            Lista_Liquidacion_combustible()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

   
    Private Sub btnCerrarLiquidacion_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        If gwdLiquiCombTracto.CurrentRow Is Nothing Then
            Exit Sub
        End If
        Try
            Dim objParametro As New Hashtable
            Dim obj_LogicaCombustible As New Combustible_BLL
            Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL

            If gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value = "C" Then
                MessageBox.Show("La liquidación ya se encuentra cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim TipoLiq As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("CTLQCB").Value).ToString.Trim

            If TipoLiq = "01" Then
                If dtgLiquidacion.Rows.Count = 0 Then
                    MessageBox.Show("Sin asignación de viajes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            If dtgVales.Rows.Count = 0 Then
                MessageBox.Show("Sin asignación de Vales.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim ofrmCerrarLiqCombustible As New frmCerrarLiqCombustible
            ofrmCerrarLiqCombustible.pCCMPN = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
            ofrmCerrarLiqCombustible.pNLQCMB = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
            ofrmCerrarLiqCombustible.pNLQCMB = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value


            ofrmCerrarLiqCombustible.ShowDialog()
            If ofrmCerrarLiqCombustible.pDialog = True Then
                gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value = "C"
                gwdLiquiCombTracto.CurrentRow.Cells("ESTADO").Value = "CERRADO"
                ListarOperacionesLiqCombustible()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnAsigCarga_Click(sender As Object, e As EventArgs) Handles btnAsigCarga.Click
        Try
            If gwdLiquiCombTracto.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim pNroLiq As Decimal = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
            Dim pCCMPN As String = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
            Dim pCDVSN As String = gwdLiquiCombTracto.CurrentRow.Cells("CDVSN").Value
            Dim pTracto As String = gwdLiquiCombTracto.CurrentRow.Cells("NPLCUN2").Value

            Dim ColName As String = ""
            ColName = TabAsignacionCombustible.SelectedTab.Name
            Select Case ColName
                Case "tabAsigOP"


                    Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                    If CodEstado = "C" Then

                        MessageBox.Show("No puede agregar . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If


                    Dim OfrmListarOpAsig As New frmListarOpAsig
                    OfrmListarOpAsig.pPlaca = pTracto
                    OfrmListarOpAsig.pCCMPN = pCCMPN
                    OfrmListarOpAsig.pCDVSN = pCDVSN
                    OfrmListarOpAsig.pNroLiqComb = pNroLiq

                    OfrmListarOpAsig.ShowDialog()
                    If OfrmListarOpAsig.pDialog = True Then
                        ListarOperacionesLiqCombustible()
                    End If





                Case "tabAsigVale"

                    If gwdLiquiCombTracto.CurrentRow Is Nothing Then
                        Exit Sub
                    End If

                    Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                    If CodEstado = "C" Then
                        MessageBox.Show("No puede agregar . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    Dim frmVale As New frmRegValeCombustible(pNroLiq, pCCMPN, pCDVSN, 0)
                    frmVale.pAccion = frmRegValeCombustible.Accion.Nuevo
                    frmVale.ShowDialog()
                    If frmVale.pDialogOK = True Then
                        Me.Lista_Vales_Asignados()

                    End If


                Case "tabAsigUrea"

                    If gwdLiquiCombTracto.CurrentRow Is Nothing Then
                        Exit Sub
                    End If

                    Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                    If CodEstado = "C" Then
                        MessageBox.Show("No puede agregar . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    Dim ofrmUrea As New frmRegUrea(pNroLiq, pCCMPN, 0)
                    ofrmUrea.pAccion = frmRegUrea.Accion.Nuevo
                    ofrmUrea.ShowDialog()
                    If ofrmUrea.pDialogOK = True Then
                        Lista_Urea_Asignado()
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

 
    Private Sub btnasignavalemasivo_Click(sender As Object, e As EventArgs) Handles btnasignavalemasivo.Click
        Try
            If gwdLiquiCombTracto.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim pNroLiq As Decimal = gwdLiquiCombTracto.CurrentRow.Cells("NLQCMB").Value
            Dim pCCMPN As String = gwdLiquiCombTracto.CurrentRow.Cells("CCMPN").Value
            Dim pCDVSN As String = gwdLiquiCombTracto.CurrentRow.Cells("CDVSN").Value
            Dim pTracto As String = gwdLiquiCombTracto.CurrentRow.Cells("NPLCUN2").Value

            Dim ColName As String = ""
            ColName = TabAsignacionCombustible.SelectedTab.Name
            Select Case ColName
                
                Case "tabAsigVale"

                    If gwdLiquiCombTracto.CurrentRow Is Nothing Then
                        Exit Sub
                    End If

                    Dim CodEstado As String = ("" & gwdLiquiCombTracto.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                    If CodEstado = "C" Then
                        MessageBox.Show("No puede agregar . Liquidación Cerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    Dim ofrmCargaMasivaVale As New frmCargaMasivaVale
                    ofrmCargaMasivaVale.pAsignarValeLiq = True
                    ofrmCargaMasivaVale.pCCMPN = pCCMPN
                    ofrmCargaMasivaVale.pCDVSN = pCDVSN
                    ofrmCargaMasivaVale.pNumLiq = pNroLiq
                    ofrmCargaMasivaVale.PlacaLiq = pTracto
                    ofrmCargaMasivaVale.ShowDialog()
                    If ofrmCargaMasivaVale.pDialog = True Then
                        Me.Lista_Vales_Asignados()
                    End If


              
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
