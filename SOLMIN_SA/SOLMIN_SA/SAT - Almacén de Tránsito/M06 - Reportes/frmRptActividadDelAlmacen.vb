Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.TYPEDEF.OrdenCompra
'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes
Imports Ransa.TYPEDEF
Imports RANSA.Utilitario

Public Class frmRptActividadDelAlmacen

    Private strReporteseleccionado As String = ""
    Private _widthLeftRight As Int32
    Private objTemp As TipoDato_ResultaReporte
    Private strDetalleReporte As String = ""
    Public Lista As List(Of beCliente)
    Public objCliente As beCliente
    Private a As Boolean
    Private b As Boolean
    Private c As Boolean
    Private d As Boolean

    Private Sub frmRptActividadDelAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        '-- Crear status por control con F4
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados
        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RepRecepcionPorAlmacenClienteCodigo", GetType(System.String)), intTemp)

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        'txtCliente.pCargar(ClientePK)
        CargarCliente()
        CargarUbicacion()
        'tsbAmpliar.Image = pbxAmpliar.Image
        dteFechaInicial.Value = Now
        dteFechaInicial.Checked = False
        dteFechaFinal.Value = Now
        dteFechaFinal.Checked = False

        objAppConfig = Nothing
    End Sub

    Private Sub CargarCliente()
        'Dim obrcliente As New RANSA.DAO.Cliente.cCliente
        'Dim obeCliente As New RANSA.TYPEDEF.Cliente.TD_Qry_Cliente_L01
        Dim obrcliente As New Ransa.Controls.Cliente.cCliente
        Dim obeCliente As New Ransa.Controls.Cliente.TD_Qry_Cliente_L01

        Dim oDtCliente As New DataTable

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With obeCliente
            '.pCCLNT_Cliente = 0
            .pNROPAG_NroPagina = 1
            .pREGPAG_NroRegPorPagina = 1000
            .pUsuario = objSeguridadBN.pUsuario
            .pCCMPN_CodigoCompania = RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        End With
        oDtCliente = obrcliente.Listar(obeCliente, "S", 1000, 0)

        Lista = New List(Of beCliente)

        For Each dr As DataRow In oDtCliente.Rows
            objCliente = New beCliente
            objCliente.Codigo = dr("CCLNT")
            If dr("TMTVBJ").ToString.Trim = "" Then
                objCliente.Descripcion = String.Format("{0}", dr("TCMPCL").ToString.Trim)
            Else
                objCliente.Descripcion = String.Format("{0}-{1}", dr("TCMPCL").ToString.Trim, dr("TMTVBJ").ToString.Trim)
            End If

            objCliente.RUC = dr("NRUC")
            objCliente.Estado = 0
            Lista.Add(objCliente)
        Next

        Dim oListColum As New Hashtable

        Dim oColumnas1 As New DataGridViewCheckBoxColumn
        oColumnas1.Name = "CHK"
        oColumnas1.DataPropertyName = "CHK"
        oColumnas1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas1.HeaderText = "Check"
        oColumnas1.ReadOnly = False
        oColumnas1.Visible = True
        oListColum.Add(1, oColumnas1)

        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "Codigo"
        oColumnas.DataPropertyName = "Codigo"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.HeaderText = "Código"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Descripcion"
        oColumnas.DataPropertyName = "Descripcion"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(3, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "RUC"
        oColumnas.DataPropertyName = "RUC"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.HeaderText = "RUC"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(4, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Estado"
        oColumnas.DataPropertyName = "Estado"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oColumnas.HeaderText = "Estado"
        oColumnas.Visible = False
        oColumnas.ReadOnly = True
        oListColum.Add(5, oColumnas)

        Me.txtCliente2.DataSource = Lista
        Me.txtCliente2.ListColumnas = oListColum
        Me.txtCliente2.Cargas()
        Me.txtCliente2.DispleyMember = "Descripcion"
        Me.txtCliente2.ValueMember = "Codigo"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        'If txtCliente.pCodigo = 0 Then strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine

        If txtCliente2.Resultado IsNot Nothing Then

            Dim Estado As String = txtCliente2.Resultado.GetType().ToString

            If Estado = "Ransa.Utilitario.beCliente" Then
                Dim ListaS As String
                ListaS = CType(txtCliente2.Resultado, beCliente).Codigo
                If ListaS Is Nothing Then
                    tsbExportarExcel.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                End If
            Else
                Dim ListaS As New List(Of String)
                ListaS = CType(txtCliente2.Resultado, List(Of String))

                If ListaS Is Nothing Then
                    tsbExportarExcel.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                Else
                    If ListaS.Count = 0 Then
                        tsbExportarExcel.Enabled = False
                        strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                    End If
                End If

            End If
        Else
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine

        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado

    End Function

    'Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
    '   Call pGenerarReporte()
    'End Sub
    'Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
    'pcxEspera.Visible = False
    'btnGenerarReporte.Enabled = True
    'tsbExportarExcel.Enabled = True
    'tsbEnviarCorreo.Enabled = True
    'crvReporte.Visible = True
    'crvReporte.ReportSource = objTemp.pReporte
    'End Sub
    Sub pGenerarReporte()
        Dim objAppConfig As cAppConfig = New cAppConfig

        Call pReporteActividadAlmacen()
        strDetalleReporte = "Actividad de Almacén"

        objAppConfig.ConfigType = 1
        'objAppConfig.SetValue("RepRecepcionPorAlmacenClienteCodigo", txtCliente.pCodigo)
        objAppConfig = Nothing
    End Sub

    Private Sub pReporteActividadAlmacen()
        If txtCliente2.Resultado IsNot Nothing Then
            Dim objFiltro As clsFiltros_ActividadAlmacen = New clsFiltros_ActividadAlmacen
            Dim oDtExcel As New DataTable
            Dim dstTemp As DataSet = Nothing
            ' Filtros
            Dim Est As String = txtCliente2.Resultado.GetType.ToString
            With objFiltro
                '.pintCodigoCliente_CCLNT = txtCliente.pCodigo
                If Est = "Ransa.Utilitario.beCliente" Then
                    .pstrCodigoCliente_CCLNT = CType(txtCliente2.Resultado, beCliente).Codigo
                Else
                    .pstrCodigoCliente_CCLNT = ListaCodigoClientes()
                End If

                .pdteFechaInicio_FINIPR = dteFechaInicial.Value
                .pdteFechaFin_FFINPR = dteFechaFinal.Value
                If txtUbicacionReferencial.Resultado IsNot Nothing Then
                    .pstrUbicacionReferencial_TUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
                Else
                    .pstrUbicacionReferencial_TUBRFR = ""
                End If
                '.pstrBulto_CREFFW = 
                '.pstrRazonSocial_TCMPCL = txtCliente.pRazonSocial
                .pstrCompania_CCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .pstrDivision_CDVSN = UcDivision_Cmb011.Division
                .pdecPLanta = UcPLanta_Cmb011.Planta
                .pstrBulto_CREFFW = txtCodigoRecepcion.Text


                .pstrTipoMovimiento_STPING = "" & txtTipoMovimiento.Tag
            End With
            ' Visualizamos la información en el visor
            dstTemp = mfrptGeneradorReportes(objFiltro)
            Dim objTemp2 As New TipoDato_ResultaReporte
            objTemp2.add_Tables(dstTemp)
            objTemp = objTemp2
            If rbtOrdenDeCompra.Checked Then
                oDtExcel = EliminarRepetido(dstTemp.Tables(0))
                dgActividadOC.AutoGenerateColumns = False
                dgActividadOC.DataSource = oDtExcel
                ' ExportarExcelOC(oDtExcel, "G", Nothing)

                VisualizarGrilla("OC")
            ElseIf rbtItem.Checked Then
                oDtExcel = EliminarRepetidoItems(dstTemp.Tables(0))
                dgActividadItem.AutoGenerateColumns = False
                dgActividadItem.DataSource = oDtExcel
                'ExportarExcelItem(oDtExcel, "G", Nothing)
                VisualizarGrilla("IT")
            Else
                oDtExcel = dstTemp.Tables(0)
                dgActividadSubItem.AutoGenerateColumns = False
                dgActividadSubItem.DataSource = oDtExcel
                'dstTemp = obrReporteAT.fdstIngresoPorAlmacen(obeFiltro)
                'objTemp2.add_Tables(dstTemp)
                'objTemp = objTemp2
                ''oDtExcel = ReturnTableFormatedIngresoEgreso(dstTemp.Tables(0), "")
                'ExportarExcelSubItem(dstTemp.Tables(0), "G", Nothing)
                VisualizarGrilla("SU")
            End If
        End If
    End Sub

    Private Sub VisualizarGrilla(ByVal Vista As String)
        If Vista = "OC" Then
            dgActividadOC.Visible = True
            dgActividadItem.Visible = False
            dgActividadSubItem.Visible = False
        ElseIf Vista = "IT" Then
            dgActividadOC.Visible = False
            dgActividadItem.Visible = True
            dgActividadSubItem.Visible = False
        ElseIf Vista = "SU" Then
            dgActividadOC.Visible = False
            dgActividadItem.Visible = False
            dgActividadSubItem.Visible = True
        End If
    End Sub

    Private Function EliminarRepetido(ByVal dtTemp As DataTable) As DataTable
        dtTemp.Select("", "CREFFW ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) And dtTemp.Rows(i).Item("CCLNT").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CCLNT").ToString.Trim) Then
                dtTemp.Rows.RemoveAt(i)
            End If
        Next
        Return dtTemp
    End Function

    Private Function EliminarRepetidoItems(ByVal dtTemp As DataTable) As DataTable
        dtTemp.Select("", "CREFFW ,CIDPAQ  ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) And dtTemp.Rows(i).Item("CIDPAQ").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CIDPAQ").ToString.Trim) Then
                dtTemp.Rows.RemoveAt(i)
            End If
        Next
        Return dtTemp
    End Function

    Private Function ListaCodigoClientes() As String
        Dim strCadDocumentos As String = ""
        Dim ListaS As New List(Of String)
        Dim Est As String = txtCliente2.Resultado.GetType.ToString
        ListaS = CType(txtCliente2.Resultado, List(Of String))
        For Each i As String In ListaS
            strCadDocumentos += i & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub bsaTipoMovimientoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoMovimientoListar.Click
        Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
    End Sub


    Private Sub txtTipoMovimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoMovimiento.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
        End If
    End Sub

    Private Sub txtTipoMovimiento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoMovimiento.TextChanged
        txtTipoMovimiento.Tag = ""
    End Sub

    Private Sub txtTipoMovimiento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoMovimiento.Validating
        If txtTipoMovimiento.Text = "" Then
            txtTipoMovimiento.Tag = ""
        Else
            If txtTipoMovimiento.Text <> "" And "" & txtTipoMovimiento.Tag = "" Then
                Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
                If txtTipoMovimiento.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub


    Private Function ReturnTableFormatedIngresoEgreso(ByVal tabla As DataTable, ByVal llave As String) As DataTable
        Return Nothing
    End Function

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Call mpEnviarEMail(objTemp, strDetalleReporte, "Informe : " + strDetalleReporte)
    End Sub

    Private Sub tsbExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dlgSavePDF As SaveFileDialog = New SaveFileDialog
        dlgSavePDF.Filter = "Adobe Acrobat PDF (*.pdf)|*.pdf"
        dlgSavePDF.CheckPathExists = True
        If dlgSavePDF.ShowDialog = Windows.Forms.DialogResult.OK Then
            objTemp.pReporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dlgSavePDF.FileName)
        End If
        dlgSavePDF.Dispose()
        dlgSavePDF = Nothing
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            Dim oDtExcel As New DataTable
            If rbtOrdenDeCompra.Checked Then
                oDtExcel = EliminarRepetido(objTemp.Tables(0).Copy)
                oDtExcel.Columns.Add("FREFFW1", Type.GetType("System.String"))
                oDtExcel.Columns.Add("FSLFFW1", Type.GetType("System.String"))
                For i As Integer = 0 To oDtExcel.Rows.Count - 1
                    If oDtExcel.Rows(i).Item("FREFFW").ToString.Trim <> "" Then
                        oDtExcel.Rows(i).Item("FREFFW1") = oDtExcel.Rows(i).Item("FREFFW").ToString.Substring(0, 10)
                    End If
                    'oDtExcel.AcceptChanges()
                    If oDtExcel.Rows(i).Item("FSLFFW").ToString.Trim <> "" Then
                        oDtExcel.Rows(i).Item("FSLFFW1") = oDtExcel.Rows(i).Item("FSLFFW").ToString.Substring(0, 10)
                    End If
                    oDtExcel.AcceptChanges()
                Next
                oDtExcel.Columns.Remove("FREFFW")
                oDtExcel.Columns.Remove("FSLFFW")
                oDtExcel.Columns("FREFFW1").SetOrdinal("21")
                oDtExcel.Columns("FSLFFW1").SetOrdinal("23")
                ExportarExcelOC(oDtExcel)
            ElseIf rbtItem.Checked Then
                oDtExcel = EliminarRepetidoItems(objTemp.Tables(0).Copy)
                oDtExcel.Columns.Add("FREFFW1", Type.GetType("System.String"))
                oDtExcel.Columns.Add("FSLFFW1", Type.GetType("System.String"))
                For i As Integer = 0 To oDtExcel.Rows.Count - 1
                    If oDtExcel.Rows(i).Item("FREFFW").ToString.Trim <> "" Then
                        oDtExcel.Rows(i).Item("FREFFW1") = oDtExcel.Rows(i).Item("FREFFW").ToString.Substring(0, 10)
                    End If
                    'oDtExcel.AcceptChanges()
                    If oDtExcel.Rows(i).Item("FSLFFW").ToString.Trim <> "" Then
                        oDtExcel.Rows(i).Item("FSLFFW1") = oDtExcel.Rows(i).Item("FSLFFW").ToString.Substring(0, 10)
                    End If
                    oDtExcel.AcceptChanges()
                Next
                oDtExcel.Columns.Remove("FREFFW")
                oDtExcel.Columns.Remove("FSLFFW")
                oDtExcel.Columns("FREFFW1").SetOrdinal("21")
                oDtExcel.Columns("FSLFFW1").SetOrdinal("23")
                ExportarExcelItem(oDtExcel)
            Else
                oDtExcel = objTemp.Tables(0).Copy
                oDtExcel.Columns.Add("FREFFW1", Type.GetType("System.String"))
                oDtExcel.Columns.Add("FSLFFW1", Type.GetType("System.String"))
                For i As Integer = 0 To oDtExcel.Rows.Count - 1
                    If oDtExcel.Rows(i).Item("FREFFW").ToString.Trim <> "" Then
                        oDtExcel.Rows(i).Item("FREFFW1") = oDtExcel.Rows(i).Item("FREFFW").ToString.Substring(0, 10)
                    End If
                    'oDtExcel.AcceptChanges()
                    If oDtExcel.Rows(i).Item("FSLFFW").ToString.Trim <> "" Then
                        oDtExcel.Rows(i).Item("FSLFFW1") = oDtExcel.Rows(i).Item("FSLFFW").ToString.Substring(0, 10)
                    End If
                    oDtExcel.AcceptChanges()
                Next
                oDtExcel.Columns.Remove("FREFFW")
                oDtExcel.Columns.Remove("FSLFFW")
                oDtExcel.Columns("FREFFW1").SetOrdinal("21")
                oDtExcel.Columns("FSLFFW1").SetOrdinal("23")
                ExportarExcelSubItem(oDtExcel)
            End If

        Catch : End Try
    End Sub

    Private Sub ExportarExcelOC(ByVal oDtExcel As DataTable)
        Try
            Dim oDt As New DataTable
            oDt = oDtExcel.Copy

            Dim NPOI As New HelpClass_NPOI_SA
            Dim oDtResumen As New DataTable
            Dim oDtAct As New DataTable
            Dim oDs As New DataSet
            'Eliminado
            oDtExcel.Columns.Remove("CIDPAQ")
            oDtExcel.Columns.Remove("NRITOC")
            oDtExcel.Columns.Remove("TCITCL")
            oDtExcel.Columns.Remove("TDITES")
            oDtExcel.Columns.Remove("QBLTSR")
            oDtExcel.Columns.Remove("QPEPQT")
            oDtExcel.Columns.Remove("TUNDCN")
            oDtExcel.Columns.Remove("SBITOC")
            oDtExcel.Columns.Remove("TCITCL1")
            oDtExcel.Columns.Remove("TDITES1")
            oDtExcel.Columns.Remove("QCNRCP")
            oDtExcel.Columns.Remove("QCNTIT")
            oDtExcel.Columns.Remove("TUNDIT")
            oDtExcel.Columns.Remove("QCNPEN")

            Dim oDtv1 As DataView = New DataView(oDt)
            Dim oDtv2 As DataView = New DataView(oDt)
            Dim oDt1 As New DataTable
            Dim oDt2 As New DataTable
            Dim oDtFiltro As New DataTable
            Dim oDr As DataRow

            oDt1 = oDtv1.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
            oDt2 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")

            oDtResumen.Columns.Add("TCMPCL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("TIPO_ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ACTIVIDAD ALMACÉN | CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ACTIVIDAD ALMACÉN | PESO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ACTIVIDAD ALMACÉN | VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)

            For i As Integer = 0 To oDt2.Rows.Count - 1
                oDtFiltro = SelectDataTable(oDt1, "CCLNT = '" + oDt2.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt2.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt2.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt2.Rows(i).Item("ZONA") + "' ")
                oDr = oDtResumen.NewRow()
                oDr("TCMPCL1") = oDt2.Rows(i).Item("TCMPCL")
                oDr("TIPO_ALMACEN1") = oDt2.Rows(i).Item("TIPO_ALMACEN")
                oDr("ALMACEN1") = oDt2.Rows(i).Item("ALMACEN")
                oDr("ZONA") = oDt2.Rows(i).Item("ZONA")
                oDr("QREFFW") = SumarDataTable(oDtFiltro, "QREFFW")
                oDr("QPSOBL") = SumarDataTable(oDtFiltro, "QPSOBL")
                oDr("QVLBTO") = SumarDataTable(oDtFiltro, "QVLBTO")
                oDtResumen.Rows.Add(oDr)
            Next

            oDtAct.Columns.Add("CCLNT", Type.GetType("System.String")).Caption = NPOI.FormatDato("CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TCMPCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TIPO_ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("CREFFW", Type.GetType("System.String")).Caption = NPOI.FormatDato("BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("NORCML", Type.GetType("System.String")).Caption = NPOI.FormatDato("N° O/C", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("CPRVCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TPRVCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("DETALLE PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("NGRPRV", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUÍA DE PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("FREFFW1", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA INGRESO", HelpClass_NPOI_SA.keyDatoFecha)
            oDtAct.Columns.Add("NGUIRM", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUIA REMISIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("FSLFFW1", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA SALIDA", HelpClass_NPOI_SA.keyDatoFecha)
            oDtAct.Columns.Add("TTINTC", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO MERCADERÍA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANTIDAD BULTOS", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TIPBTO", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO BULTO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TUNPSO", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TUNVOL", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD ", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TNOMCOM", Type.GetType("System.String")).Caption = NPOI.FormatDato("COMPRADOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TUBRFR", Type.GetType("System.String")).Caption = NPOI.FormatDato("UBICACIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TLUGEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("LUGAR DE ENTREGA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("ESTCAR", Type.GetType("System.String")).Caption = NPOI.FormatDato("ESTADO CARGA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TIMALM", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("TIEMPO ALMACÉN", HelpClass_NPOI_SA.keyDatoNumero)

            For Each oDrs As DataRow In oDt.Rows
                oDtAct.ImportRow(oDrs)
            Next

            oDtAct.TableName = "ActividadPorAlmacen"
            oDtResumen.TableName = "Resumen"


            Dim oListDtReport As New List(Of DataTable)
            Dim strlTitulo2 As New List(Of String)
            oListDtReport.Add(oDtAct)
            oListDtReport.Add(oDtResumen)
            strlTitulo2.Add("ACTIVIDAD POR ALMACEN")
            strlTitulo2.Add("RESUMEN ACTIVIDAD POR ALMACEN")
            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            itemSortedList = New SortedList
            'itemSortedList.Add(itemSortedList.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo, "TODOS", ListaCodigoClientes))
            itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList.Add(itemSortedList.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList)

            Dim itemSortedList2 As SortedList
            itemSortedList2 = New SortedList
            'itemSortedList2.Add(itemSortedList2.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo, "TODOS", ListaCodigoClientes))
            itemSortedList2.Add(itemSortedList2.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList2.Add(itemSortedList2.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList2)

            Dim ListFilDupl As New List(Of String)
            Dim CombCol As String = "TCMPCL1:TCMPCL1/1"
            CombCol = CombCol & "|TIPO_ALMACEN1:TCMPCL1,TIPO_ALMACEN1/1"
            CombCol = CombCol & "|ALMACEN1:TCMPCL1,TIPO_ALMACEN1,ALMACEN1/1"
            ListFilDupl.Add("")
            ListFilDupl.Add(CombCol)

            'HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
            NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, ListFilDupl)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ExportarExcelItem(ByVal oDtExcel As DataTable)
        Try
            Dim NPOI As New HelpClass_NPOI_SA
            Dim oDtResumen As New DataTable
            Dim oDtAct As New DataTable
            Dim oDs As New DataSet
            'Eliminado
            oDtExcel.Columns.Remove("CIDPAQ")
            'oDtExcel.Columns.Remove("NRITOC")
            'oDtExcel.Columns.Remove("TCITCL")
            'oDtExcel.Columns.Remove("TDITES")
            'oDtExcel.Columns.Remove("QBLTSR")
            'oDtExcel.Columns.Remove("QPEPQT")
            'oDtExcel.Columns.Remove("TUNDCN")
            oDtExcel.Columns.Remove("SBITOC")
            oDtExcel.Columns.Remove("TCITCL1")
            oDtExcel.Columns.Remove("TDITES1")
            oDtExcel.Columns.Remove("QCNRCP")
            oDtExcel.Columns.Remove("QCNTIT")
            oDtExcel.Columns.Remove("TUNDIT")
            oDtExcel.Columns.Remove("QCNPEN")

            Dim oDtv1 As DataView = New DataView(oDtExcel)
            Dim oDtv2 As DataView = New DataView(oDtExcel)
            Dim oDt1 As New DataTable
            Dim oDt2 As New DataTable
            Dim oDtFiltro As New DataTable
            Dim oDr As DataRow

            oDt1 = oDtv1.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
            oDt2 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")

            oDtResumen.Columns.Add("TCMPCL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("TIPO_ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ACTIVIDAD ALMACÉN | CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ACTIVIDAD ALMACÉN | PESO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ACTIVIDAD ALMACÉN | VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)

            For i As Integer = 0 To oDt2.Rows.Count - 1
                oDtFiltro = SelectDataTable(oDt1, "CCLNT = '" + oDt2.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt2.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt2.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt2.Rows(i).Item("ZONA") + "' ")
                oDr = oDtResumen.NewRow()
                oDr("TCMPCL1") = oDt2.Rows(i).Item("TCMPCL")
                oDr("TIPO_ALMACEN1") = oDt2.Rows(i).Item("TIPO_ALMACEN")
                oDr("ALMACEN1") = oDt2.Rows(i).Item("ALMACEN")
                oDr("ZONA") = oDt2.Rows(i).Item("ZONA")
                oDr("QREFFW") = SumarDataTable(oDtFiltro, "QREFFW")
                oDr("QPSOBL") = SumarDataTable(oDtFiltro, "QPSOBL")
                oDr("QVLBTO") = SumarDataTable(oDtFiltro, "QVLBTO")
                oDtResumen.Rows.Add(oDr)
            Next

            oDtAct.Columns.Add("CCLNT", Type.GetType("System.String")).Caption = NPOI.FormatDato("CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TCMPCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TIPO_ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("CREFFW", Type.GetType("System.String")).Caption = NPOI.FormatDato("BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("NORCML", Type.GetType("System.String")).Caption = NPOI.FormatDato("N° O/C", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("NRITOC", Type.GetType("System.String")).Caption = NPOI.FormatDato("ITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TCITCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TDITES", Type.GetType("System.String")).Caption = NPOI.FormatDato("DESCRIPCION DEL ITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QBLTSR", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANT. ITEM", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("QPEPQT", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO ITEM", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TUNDCN", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("CPRVCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TPRVCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("DETALLE PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("NGRPRV", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUÍA DE PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("FREFFW1", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA INGRESO", HelpClass_NPOI_SA.keyDatoFecha)
            oDtAct.Columns.Add("NGUIRM", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUIA REMISIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("FSLFFW1", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA SALIDA", HelpClass_NPOI_SA.keyDatoFecha)
            oDtAct.Columns.Add("TTINTC", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO MERCADERÍA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANTIDAD BULTOS", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TIPBTO", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO BULTO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TUNPSO", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TUNVOL", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD ", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TNOMCOM", Type.GetType("System.String")).Caption = NPOI.FormatDato("COMPRADOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TUBRFR", Type.GetType("System.String")).Caption = NPOI.FormatDato("UBICACIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TLUGEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("LUGAR DE ENTREGA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("ESTCAR", Type.GetType("System.String")).Caption = NPOI.FormatDato("ESTADO CARGA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TIMALM", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("TIEMPO ALMACÉN", HelpClass_NPOI_SA.keyDatoNumero)

            For Each oDrs As DataRow In oDtExcel.Rows
                oDtAct.ImportRow(oDrs)
            Next

            oDtAct.TableName = "ActividadPorAlmacen"
            oDtResumen.TableName = "Resumen"


            Dim oListDtReport As New List(Of DataTable)
            Dim strlTitulo2 As New List(Of String)
            oListDtReport.Add(oDtAct)
            oListDtReport.Add(oDtResumen)
            strlTitulo2.Add("ACTIVIDAD POR ALMACEN")
            strlTitulo2.Add("RESUMEN ACTIVIDAD POR ALMACEN")
            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            itemSortedList = New SortedList
            'itemSortedList.Add(itemSortedList.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo, "TODOS", ListaCodigoClientes))
            itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList.Add(itemSortedList.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList)

            Dim itemSortedList2 As SortedList
            itemSortedList2 = New SortedList
            'itemSortedList2.Add(itemSortedList2.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo, "TODOS", ListaCodigoClientes))
            itemSortedList2.Add(itemSortedList2.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList2.Add(itemSortedList2.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList2)

            Dim ListFilDupl As New List(Of String)
            Dim CombCol As String = "TCMPCL1:TCMPCL1/1"
            CombCol = CombCol & "|TIPO_ALMACEN1:TCMPCL1,TIPO_ALMACEN1/1"
            CombCol = CombCol & "|ALMACEN1:TCMPCL1,TIPO_ALMACEN1,ALMACEN1/1"
            ListFilDupl.Add("")
            ListFilDupl.Add(CombCol)

            'HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
            NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, ListFilDupl)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExportarExcelSubItem(ByVal oDtExcel As DataTable)
        Try
            Dim NPOI As New HelpClass_NPOI_SA
            Dim oDtResumen As New DataTable
            Dim oDtAct As New DataTable
            Dim oDs As New DataSet
            'Eliminado
            oDtExcel.Columns.Remove("CIDPAQ")
            'oDtExcel.Columns.Remove("NRITOC")
            'oDtExcel.Columns.Remove("TCITCL")
            'oDtExcel.Columns.Remove("TDITES")
            'oDtExcel.Columns.Remove("QBLTSR")
            'oDtExcel.Columns.Remove("QPEPQT")
            'oDtExcel.Columns.Remove("TUNDCN")
            'oDtExcel.Columns.Remove("SBITOC")
            'oDtExcel.Columns.Remove("TCITCL1")
            'oDtExcel.Columns.Remove("TDITES1")
            'oDtExcel.Columns.Remove("QCNRCP")
            'oDtExcel.Columns.Remove("QCNTIT")
            'oDtExcel.Columns.Remove("TUNDIT")
            'oDtExcel.Columns.Remove("QCNPEN")

            Dim oDtv1 As DataView = New DataView(oDtExcel)
            Dim oDtv2 As DataView = New DataView(oDtExcel)
            Dim oDt1 As New DataTable
            Dim oDt2 As New DataTable
            Dim oDtFiltro As New DataTable
            Dim oDr As DataRow

            oDt1 = oDtv1.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
            oDt2 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")

            oDtResumen.Columns.Add("TCMPCL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("TIPO_ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtResumen.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ACTIVIDAD ALMACÉN | CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ACTIVIDAD ALMACÉN | PESO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtResumen.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ACTIVIDAD ALMACÉN | VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)

            For i As Integer = 0 To oDt2.Rows.Count - 1
                oDtFiltro = SelectDataTable(oDt1, "CCLNT = '" + oDt2.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt2.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt2.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt2.Rows(i).Item("ZONA") + "' ")
                oDr = oDtResumen.NewRow()
                oDr("TCMPCL1") = oDt2.Rows(i).Item("TCMPCL")
                oDr("TIPO_ALMACEN1") = oDt2.Rows(i).Item("TIPO_ALMACEN")
                oDr("ALMACEN1") = oDt2.Rows(i).Item("ALMACEN")
                oDr("ZONA") = oDt2.Rows(i).Item("ZONA")
                oDr("QREFFW") = SumarDataTable(oDtFiltro, "QREFFW")
                oDr("QPSOBL") = SumarDataTable(oDtFiltro, "QPSOBL")
                oDr("QVLBTO") = SumarDataTable(oDtFiltro, "QVLBTO")
                oDtResumen.Rows.Add(oDr)
            Next

            oDtAct.Columns.Add("CCLNT", Type.GetType("System.String")).Caption = NPOI.FormatDato("CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TCMPCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TIPO_ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("ALMACEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("CREFFW", Type.GetType("System.String")).Caption = NPOI.FormatDato("BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("NORCML", Type.GetType("System.String")).Caption = NPOI.FormatDato("N° O/C", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("NRITOC", Type.GetType("System.String")).Caption = NPOI.FormatDato("ITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TCITCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TDITES", Type.GetType("System.String")).Caption = NPOI.FormatDato("DESCRIPCION DEL ITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QBLTSR", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANT. ITEM", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("QPEPQT", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO ITEM", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TUNDCN", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("SBITOC", Type.GetType("System.String")).Caption = NPOI.FormatDato("SUBITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TCITCL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. SUBITEM", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TDITES1", Type.GetType("System.String")).Caption = NPOI.FormatDato("DESCRIPCION", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QCNRCP", Type.GetType("System.String")).Caption = NPOI.FormatDato("CANTIDAD ", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("CPRVCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("COD. PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TPRVCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("DETALLE PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("NGRPRV", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUÍA DE PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("FREFFW1", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA INGRESO", HelpClass_NPOI_SA.keyDatoFecha)
            oDtAct.Columns.Add("NGUIRM", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUIA REMISIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("FSLFFW1", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA SALIDA", HelpClass_NPOI_SA.keyDatoFecha)
            oDtAct.Columns.Add("TTINTC", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO MERCADERÍA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QCNTIT", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANT. SOLICITADA", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TUNDIT", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QCNPEN", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANT. PENDIENTE", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("CANTIDAD BULTOS", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TIPBTO", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO BULTO", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO BULTO", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TUNPSO", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)
            oDtAct.Columns.Add("TUNVOL", Type.GetType("System.String")).Caption = NPOI.FormatDato("UNIDAD ", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TNOMCOM", Type.GetType("System.String")).Caption = NPOI.FormatDato("COMPRADOR", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TUBRFR", Type.GetType("System.String")).Caption = NPOI.FormatDato("UBICACIÓN", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TLUGEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("LUGAR DE ENTREGA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("ESTCAR", Type.GetType("System.String")).Caption = NPOI.FormatDato("ESTADO CARGA", HelpClass_NPOI_SA.keyDatoTexto)
            oDtAct.Columns.Add("TIMALM", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("TIEMPO ALMACÉN", HelpClass_NPOI_SA.keyDatoNumero)

            For Each oDrs As DataRow In oDtExcel.Rows
                oDtAct.ImportRow(oDrs)
            Next

            oDtAct.TableName = "ActividadPorAlmacen"
            oDtResumen.TableName = "Resumen"


            Dim oListDtReport As New List(Of DataTable)
            Dim strlTitulo2 As New List(Of String)
            oListDtReport.Add(oDtAct)
            oListDtReport.Add(oDtResumen)
            strlTitulo2.Add("ACTIVIDAD POR ALMACEN")
            strlTitulo2.Add("RESUMEN ACTIVIDAD POR ALMACEN")
            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            itemSortedList = New SortedList
            'itemSortedList.Add(itemSortedList.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo, "TODOS", ListaCodigoClientes))
            itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList.Add(itemSortedList.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList)

            Dim itemSortedList2 As SortedList
            itemSortedList2 = New SortedList
            'itemSortedList2.Add(itemSortedList2.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo, "TODOS", ListaCodigoClientes))
            itemSortedList2.Add(itemSortedList2.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
            If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
            End If
            If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| TODOS ")
            Else
                itemSortedList2.Add(itemSortedList2.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
            End If
            itemSortedList2.Add(itemSortedList2.Count, "Fechas  de :| " & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
            LisFiltros.Add(itemSortedList2)

            Dim ListFilDupl As New List(Of String)
            Dim CombCol As String = "TCMPCL1:TCMPCL1/1"
            CombCol = CombCol & "|TIPO_ALMACEN1:TCMPCL1,TIPO_ALMACEN1/1"
            CombCol = CombCol & "|ALMACEN1:TCMPCL1,TIPO_ALMACEN1,ALMACEN1/1"
            ListFilDupl.Add("")
            ListFilDupl.Add(CombCol)

            'HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
            NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, ListFilDupl)
        Catch ex As Exception

        End Try
    End Sub

    Private Function SumarDataTable(ByVal oDt As DataTable, ByVal strNombreColumna As String) As Decimal
        Dim decSuma As Decimal = 0
        For index As Integer = 0 To oDt.Rows.Count - 1
            decSuma = decSuma + oDt.Rows(index).Item(strNombreColumna)
        Next
        Return decSuma
    End Function

    Private Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String) As DataTable
        Dim rows As DataRow()
        Dim dtNew As DataTable

        dtNew = dt.Clone()
        rows = dt.Select(filter)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next

        Return dtNew
    End Function

    Private Sub ExportarExcel(ByVal oDtExcel As DataTable)
        Dim oDt As New DataTable
        Dim oDs As New DataSet
        oDt = oDtExcel.Copy

        oDt.Columns("CREFFW").ColumnName = "BULTO"
        oDt.Columns("NORCML").ColumnName = "O/C"
        oDt.Columns("NRITOC").ColumnName = "ITEM"
        oDt.Columns("TCITCL").ColumnName = "COD. CLIENTE"
        oDt.Columns("TDITES").ColumnName = "DETALLE ITEM"
        oDt.Columns("CPRVCL").ColumnName = "COD. PROVEEDOR"
        oDt.Columns("TPRVCL").ColumnName = "DETALLE. PROVEEDOR"
        oDt.Columns("NGRPRV").ColumnName = "GUÍA DE PROVEEDOR"
        oDt.Columns("FREFFW").ColumnName = "FECHA INGRESO"
        oDt.Columns("NGUIRM").ColumnName = "GUÍA DE REMISIÓN"
        oDt.Columns("FSLFFW").ColumnName = "FECHA SALIDA"
        oDt.Columns("TTINTC").ColumnName = "TIPO MERCADERIA"
        oDt.Columns("QCNTIT").ColumnName = "CANTIDAD SOLICITADA"
        oDt.Columns("TUNDIT").ColumnName = "UNID "
        oDt.Columns("QCNPEN").ColumnName = "CANTIDAD PENDIENTE"
        oDt.Columns("QREFFW").ColumnName = "CANTIDAD BULTOS"
        oDt.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDt.Columns("TUNPSO").ColumnName = "UNID  "
        oDt.Columns("QVLBTO").ColumnName = "VOLUMEN"
        oDt.Columns("TUNVOL").ColumnName = " UNID "
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR ENTREGA "
        oDt.Columns("ESTCAR").ColumnName = "ESTADO CARGA"
        oDt.Columns("TIMALM").ColumnName = "TIEMPO ALMACEN"
        oDs.Tables.Add(oDt)

        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Fechas  de:\n" & dteFechaInicial.Value.Date & " hasta " & dteFechaFinal.Value.Date)
        HelpClass.ExportExcelConTitulos(oDs, Me.Text, strlTitulo)
    End Sub

    Private Sub CargarUbicacion()
        Try
            If txtCliente2.Resultado IsNot Nothing Then
                Dim oListColum As New Hashtable
                Dim oColumnas As New DataGridViewTextBoxColumn
                Dim objNegocio As New brUbicacionesXCliente
                Dim strCliente As String = ""
                Dim Est As String = txtCliente2.Resultado.GetType.ToString
                If Est = "Ransa.Utilitario.beCliente" Then
                    strCliente = CType(txtCliente2.Resultado, beCliente).Codigo
                Else
                    strCliente = ListaCodigoClientes()
                End If

                oListColum = New Hashtable


                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "PNCCLNT"
                oColumnas.DataPropertyName = "PNCCLNT"
                oColumnas.HeaderText = "Cod. Cliente"
                oColumnas.Visible = True
                oListColum.Add(1, oColumnas)

                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "PSTCMPCL"
                oColumnas.DataPropertyName = "PSTCMPCL"
                oColumnas.HeaderText = "Cliente "
                oColumnas.Visible = True
                oListColum.Add(2, oColumnas)

                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "PSTUBRFR_1"
                oColumnas.DataPropertyName = "PSTUBRFR"
                oColumnas.HeaderText = "Ubicación"
                oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                oListColum.Add(3, oColumnas)

                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "PSTUBRFR"
                oColumnas.DataPropertyName = "PSTUBRFR"
                oColumnas.HeaderText = "Ubicación "
                oColumnas.Visible = False
                oListColum.Add(4, oColumnas)


                txtUbicacionReferencial.DataSource = objNegocio.folistUbicacionXCliente(strCliente)
                txtUbicacionReferencial.ListColumnas = oListColum
                txtUbicacionReferencial.Cargas()
                txtUbicacionReferencial.Limpiar()
                txtUbicacionReferencial.ValueMember = "PSTUBRFR"
                txtUbicacionReferencial.DispleyMember = "PSTUBRFR"
            Else
                txtUbicacionReferencial.DataSource = Nothing
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCliente_InformationChanged()
        CargarUbicacion()
    End Sub


    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        If fblnValidaInformacion() Then
            tsbEnviarCorreo.Enabled = False
            tsbExportarExcel.Enabled = False
            tsbBuscar.Enabled = False
            a = dteFechaInicial.Checked
            b = dteFechaFinal.Checked
            'pListarReporteGrilla()
            pReporteActividadAlmacen()
            HabilitarBotones(True)
        End If
    End Sub

    Private Sub HabilitarBotones(ByVal Habilitar As Boolean)
        tsbBuscar.Enabled = Habilitar
        tsbExportarExcel.Enabled = Habilitar
        tsbImprimir.Enabled = Habilitar
    End Sub

    Private Sub pReporteActividadPorAlmacenOC()
        Dim dstTemp As New DataSet
        Dim oDtRpt As New DataTable
        Dim rptTemp As New ReportDocument
        oDtRpt = EliminarRepetido(objTemp.Tables(0))
        dstTemp.Tables.Add(oDtRpt.Copy)
        dstTemp.Tables.Add(objTemp.Tables(1).Copy)
        If dstTemp.Tables.Count > 0 Then
            rptTemp = New rptActividadAlmacenOC
            rptTemp.SetDataSource(dstTemp)
            rptTemp.Refresh()
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rptTemp.SetParameterValue("pFechaInicio", dteFechaInicial.Value)
            rptTemp.SetParameterValue("pFechaFinal", dteFechaFinal.Value)
        End If

        Dim frmPrintForm As New PrintForm
        frmPrintForm.MaximizeBox = True
        frmPrintForm.ShowForm(rptTemp, Me)
    End Sub

    Private Sub pReporteActividadPorAlmacenItem()
        Dim dstTemp As New DataSet
        Dim oDtRpt As New DataTable
        Dim rptTemp As New ReportDocument
        oDtRpt = EliminarRepetidoItems(objTemp.Tables(0))
        dstTemp.Tables.Add(oDtRpt.Copy)
        dstTemp.Tables.Add(objTemp.Tables(1).Copy)
        If dstTemp.Tables.Count > 0 Then
            rptTemp = New rptActividadAlmacenItem
            rptTemp.SetDataSource(dstTemp)
            rptTemp.Refresh()
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rptTemp.SetParameterValue("pFechaInicio", dteFechaInicial.Value)
            rptTemp.SetParameterValue("pFechaFinal", dteFechaFinal.Value)
        End If

        Dim frmPrintForm As New PrintForm
        frmPrintForm.MaximizeBox = True
        frmPrintForm.ShowForm(rptTemp, Me)
    End Sub

    Private Sub pReporteActividadPorAlmacenSubItem()
        Dim dstTemp As New DataSet
        Dim rptTemp As New ReportDocument
        dstTemp.Tables.Add(objTemp.Tables(0).Copy)
        dstTemp.Tables.Add(objTemp.Tables(1).Copy)
        If dstTemp.Tables.Count > 0 Then
            rptTemp = New rptActividadAlmacenSubItem
            rptTemp.SetDataSource(dstTemp)
            rptTemp.Refresh()
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            rptTemp.SetParameterValue("pFechaInicio", dteFechaInicial.Value)
            rptTemp.SetParameterValue("pFechaFinal", dteFechaFinal.Value)
        End If

        Dim frmPrintForm As New PrintForm
        frmPrintForm.MaximizeBox = True
        frmPrintForm.ShowForm(rptTemp, Me)
    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        If rbtOrdenDeCompra.Checked Then
            pReporteActividadPorAlmacenOC()
        ElseIf rbtItem.Checked Then
            pReporteActividadPorAlmacenItem()
        Else
            pReporteActividadPorAlmacenSubItem()
        End If
    End Sub

    Private Sub rbtOrdenDeCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtOrdenDeCompra.CheckedChanged
        If rbtOrdenDeCompra.Checked = True Then
            VisualizarGrilla("OC")
            pReporteActividadAlmacen()
            HabilitarBotones(True)
        End If
    End Sub

    Private Sub rbtItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtItem.CheckedChanged
        If rbtItem.Checked = True Then
            VisualizarGrilla("IT")
            pReporteActividadAlmacen()
        End If
    End Sub

    Private Sub rbtSubitem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSubitem.CheckedChanged
        If rbtSubitem.Checked = True Then
            VisualizarGrilla("SU")
            pReporteActividadAlmacen()
            HabilitarBotones(True)
        End If
    End Sub

    Private Sub txtCliente2_CambioDeTexto(ByVal objData As Object) Handles txtCliente2.CambioDeTexto
        CargarUbicacion()
    End Sub
End Class

