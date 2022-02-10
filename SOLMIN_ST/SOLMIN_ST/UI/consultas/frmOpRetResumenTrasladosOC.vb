Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmOpRetResumenTrasladosOC
  Private bolBuscar As Boolean
  Private dstreporteProcees As New DataSet
  Private htProcees As New Hashtable
    Private objLogicaReportesProcees As New ReportesVariados_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private strPlanta As String
    Private strPlantaDes As String

  Private Sub frmResumenTrasladosOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Alinear_Columnas_Grilla()
      Cargar_Combos()
      gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
      txtOrdeDeCompra.CharacterCasing = CharacterCasing.Upper

      chkFechaCarga.Checked = False
      txtOrdeDeCompra.Enabled = False
      ActivarRangoFecha(False)

      pbxProceso.Visible = False
            lblProceso.Visible = False

            ' Agregado por: Hugo Pérez Ryan
            ' Fecha:        03/03/2012
            ' Descripción:  Se está modificando para que la consulta 
            ' pueda ser utilizada para escoger una o más plantas
            'Cargar_Planta()
    Catch : End Try
  End Sub

  Private Sub ActivarRangoFecha(ByVal activar As Boolean)
    dtpFechaInicio.Enabled = activar
    dtpFechaFin.Enabled = activar
    txtOrdeDeCompra.Enabled = Not activar
  End Sub

  Private Sub Cargar_Combos()
        'cargarComboCompania()
        Cargar_Compania()
    CargarTraccion()
  End Sub

  Private Sub CargarTraccion()
    Dim oDt As New DataTable
    Dim oDr As DataRow
    oDt.Columns.Add("COD")
    oDt.Columns.Add("DES")

    oDr = oDt.NewRow

    oDr.Item(0) = "0"
    oDr.Item(1) = "Todos"

    oDt.Rows.Add(oDr)
    oDr = oDt.NewRow
    oDr.Item(0) = "1"
    oDr.Item(1) = "Traslado Normal"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "2"
    oDr.Item(1) = "Tracción Agencias"
    oDt.Rows.Add(oDr)
    Me.cmbTraccion.DataSource = oDt
    Me.cmbTraccion.ValueMember = "COD"
    Me.cmbTraccion.DisplayMember = "DES"

  End Sub

  Private Sub Alinear_Columnas_Grilla()
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

    'Private Sub cargarComboCompania()
    '  Dim objLogica As New NEGOCIO.Compania_BLL
    '  objLogica.Crea_Lista()
    '  With cboCia
    '    bolBuscar = False
    '    cboCia.DataSource = objLogica.Lista
    '    cboCia.ValueMember = "CCMPN"
    '    bolBuscar = True
    '    cboCia.DisplayMember = "TCMPCM"
    '    cboCia.SelectedIndex = 0
    '  End With
    'End Sub

    'Private Sub cargarComboDivision()
    '    Try
    '        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '        Dim objLogica As New NEGOCIO.Division_BLL
    '        objLogica.Crea_Lista()
    '        With cboDivision
    '            bolBuscar = False
    '            .DataSource = objLogica.Lista_Division(cboCia.SelectedValue.ToString.Trim)
    '            .ValueMember = "CDVSN"
    '            bolBuscar = True
    '            .DisplayMember = "TCMPDV"
    '            '.SelectedIndex = 0
    '        End With
    '        Me.cboDivision.SelectedValue = "T"
    '        If Me.cboDivision.SelectedIndex = -1 Then
    '            Me.cboDivision.SelectedIndex = 0
    '        End If
    '    Catch ex As Exception
    '        HelpClass.ErrorMsgBox()
    '    Finally
    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '    End Try
    'End Sub

    'Private Sub cargarComboPlanta()
    '  Try
    '    Dim objLogica As New NEGOCIO.Planta_BLL
    '    objLogica.Crea_Lista()
    '    With cboPlanta
    '      .DataSource = objLogica.Lista_Planta(cboCia.SelectedValue.ToString.Trim, cboDivision.SelectedValue.ToString.Trim)
    '      .ValueMember = "CPLNDV"
    '      .DisplayMember = "TPLNTA"
    '    End With
    '  Catch ex As Exception
    '    HelpClass.ErrorMsgBox()
    '  Finally
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '  End Try
    'End Sub

    'Private Sub cboCia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If bolBuscar Then
    '        cargarComboDivision()
    '    End If
    'End Sub

    'Private Sub cboDivision_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If bolBuscar Then
    '        cargarComboPlanta()
    '    End If
    'End Sub

  Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        '    MenuBar.Enabled = False



        Me.gwdDatos.DataSource = Nothing  'agregado
        If VerificarSiNoEligePlanta() = True Then  'agregado
            Try
                gwdDatos.DataSource = Nothing
                'ControlVisorVehiculo.ReportViewer.ReportSource = Nothing
                ControlVisorClienteGT.ReportViewer.ReportSource = Nothing
                ControlVisorClienteOC.ReportViewer.ReportSource = Nothing

                PrepararProceesWorked()
                bgwProceso.RunWorkerAsync()
            Catch ex As Exception
                HelpClass.ErrorMsgBox()
                Me.Cursor = Cursors.Default
                ClearMemory()
            End Try
            MenuBar.Enabled = False
            Me.Cursor = Cursors.Default

        End If 'agregado

      
        '    strPlanta = ""
        '    For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

        '        strPlanta += chkcbxPlanta.CheckedItems(i).Value

        '        If i < chkcbxPlanta.CheckedItems.Count - 1 Then
        '            strPlanta = String.Concat(strPlanta, ",")
        '        End If

        '    Next


        '    If strPlanta = "" Then
        '        'objcoleccion.Add("")
        '        HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)
        '        Me.Cursor = Cursors.Default



        '        Exit Sub

        '    End If

        'PrepararProceesWorked() 'Prepara el proceso asincrono
        'bgwProceso.RunWorkerAsync() 'Inicia el proceso asincrono
    End Sub

    'se creo esta funcion 23/03/2012
    Private Function VerificarSiNoEligePlanta() As Boolean
        Dim vretorno As Boolean = False

        Dim strCodPlanta As String = ""



        For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

            strCodPlanta += chkcbxPlanta.CheckedItems(i).Value

            If i < chkcbxPlanta.CheckedItems.Count - 1 Then
                strCodPlanta = String.Concat(strCodPlanta, ",")
            End If

        Next

        If strCodPlanta = "" Then
            HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)
            Me.Cursor = Cursors.Default

            vretorno = False
        Else
            vretorno = True

        End If
        Return vretorno

    End Function


  Private Sub VisualizarProcees(ByVal ver As Boolean)
    lblProceso.Visible = ver
    pbxProceso.Visible = ver
  End Sub

  Private Sub chkFechaCarga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaCarga.CheckedChanged
    If (chkFechaCarga.Checked = True) Then
      ActivarRangoFecha(True)
      txtOrdeDeCompra.Text = ""
    Else
      ActivarRangoFecha(False)
    End If
  End Sub

  Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
    'El poceso trabaja 
    e.Result = objLogicaReportesProcees.ReporteOperacionesPorGuiaTR(htProcees)

  End Sub

  Private Sub Mostrar_Reporte_Por_Guia_Transportista(ByVal dstreporte As DataSet)
    Dim objReporteTR As New rptMovOperacionesOrdenCompraTR()
    If (dstreporte Is Nothing) Then
      Me.ControlVisorClienteGT.ReportViewer.ReportSource = Nothing

      gwdDatos.DataSource = Nothing
      Exit Sub
    End If

    objReporteTR.SetDataSource(dstreporte.Tables(0))
    objReporteTR.Refresh()
    If (Me.ctlCliente.pCodigo = 0) Then
      objReporteTR.SetParameterValue("pCliente", "")
    Else
      objReporteTR.SetParameterValue("pCliente", Me.ctlCliente.pCodigo)
    End If
    If (Me.ctlClienteFacturado.pCodigo = 0) Then
      objReporteTR.SetParameterValue("pClienteFacturado", "")
    Else
      objReporteTR.SetParameterValue("pClienteFacturado", Me.ctlClienteFacturado.pCodigo)
    End If

    objReporteTR.SetParameterValue("pFechaOperacionInicial", Me.dtpFechaInicio.Text)
    objReporteTR.SetParameterValue("pFechaOperacionFinal", Me.dtpFechaFin.Text)
    If (chkFechaCarga.Checked = True) Then
      objReporteTR.SetParameterValue("pStatusFecha", "1")
    Else
      objReporteTR.SetParameterValue("pStatusFecha", "0")
    End If

    CType(objReporteTR.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objReporteTR.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = cmbCompania.CCMPN_Descripcion
        CType(objReporteTR.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = cmbDivision.DivisionDescripcion
        'CType(objReporteTR.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = cmbPlanta.DescripcionPlanta
        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        03/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas
        CType(objReporteTR.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = chkcbxPlanta.Text
    CType(objReporteTR.ReportDefinition.ReportObjects("lblTaccion"), TextObject).Text = Me.cmbTraccion.Text

    Me.ControlVisorClienteGT.ReportViewer.ReportSource = objReporteTR

  End Sub

  Private Sub Mostrar_Reporte_Por_Orden_Compra(ByVal dstreporte As DataSet)
    Dim objReporteOC As New rptMovOperacionesPorOrdenCompra()
    If (dstreporte Is Nothing) Then

      Me.ControlVisorClienteOC.ReportViewer.ReportSource = Nothing
      gwdDatos.DataSource = Nothing
      Exit Sub
    End If

    objReporteOC.SetDataSource(dstreporte.Tables(0))

    objReporteOC.Refresh()
    If (Me.ctlCliente.pCodigo = 0) Then
      objReporteOC.SetParameterValue("pCliente", "")
    Else
      objReporteOC.SetParameterValue("pCliente", Me.ctlCliente.pCodigo)
    End If
    If (Me.ctlClienteFacturado.pCodigo = 0) Then
      objReporteOC.SetParameterValue("pClienteFacturado", "")
    Else
      objReporteOC.SetParameterValue("pClienteFacturado", Me.ctlClienteFacturado.pCodigo)
    End If

    If (chkFechaCarga.Checked = True) Then
      objReporteOC.SetParameterValue("pStatusFecha", "1")
    Else
      objReporteOC.SetParameterValue("pStatusFecha", "0")
    End If

    objReporteOC.SetParameterValue("pFechaOperacionInicial", Me.dtpFechaInicio.Text)
    objReporteOC.SetParameterValue("pFechaOperacionFinal", Me.dtpFechaFin.Text)
    CType(objReporteOC.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objReporteOC.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = cmbCompania.CCMPN_Descripcion
        CType(objReporteOC.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = cmbDivision.DivisionDescripcion
        'CType(objReporteOC.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = cmbPlanta.DescripcionPlanta
        ' Agregado por: Hugo Pérez Ryan
        ' Fecha:        03/03/2012
        ' Descripción:  Se está modificando para que la consulta 
        ' pueda ser utilizada para escoger una o más plantas
        CType(objReporteOC.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = chkcbxPlanta.Text
    CType(objReporteOC.ReportDefinition.ReportObjects("lblTaccion"), TextObject).Text = Me.cmbTraccion.Text

    Me.ControlVisorClienteOC.ReportViewer.ReportSource = objReporteOC

  End Sub

  Private Sub DatosNoProcesados()
    Me.ControlVisorClienteGT.ReportViewer.ReportSource = Nothing
    Me.ControlVisorClienteOC.ReportViewer.ReportSource = Nothing
    gwdDatos.DataSource = Nothing
    pbxProceso.Visible = False
    lblProceso.Visible = True
    Me.Cursor = Cursors.Default
    MenuBar.Enabled = True
  End Sub

  Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
    Try
      Dim dstreporte As New DataSet

      dstreporte = CType(e.Result, DataSet)

      If (dstreporte Is Nothing) Then
        DatosNoProcesados()
        lblProceso.Text = "Finalizado..."
        Exit Sub
      End If

            dstreporte.Tables(0).TableName = "dtMovOperaciones"

      Mostrar_Reporte_Por_Guia_Transportista(dstreporte)
            Mostrar_Reporte_Por_Orden_Compra(dstreporte)
            Dim PFechaOC As Decimal = 0
            For x As Integer = 0 To dstreporte.Tables(0).Rows.Count - 1
                dstreporte.Tables(0).Rows(x)("FSLDCM") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FSLDCM").ToString)
                dstreporte.Tables(0).Rows(x)("FLLGCM") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FLLGCM").ToString)
                dstreporte.Tables(0).Rows(x)("FECOST") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FECOST").ToString)
                dstreporte.Tables(0).Rows(x)("FATNSR") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FATNSR").ToString)
                dstreporte.Tables(0).Rows(x)("FECFAC") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FECFAC").ToString)
                PFechaOC = Val(("" & dstreporte.Tables(0).Rows(x)("FORCML")).ToString.Trim)
                If PFechaOC < 0 OrElse (PFechaOC.ToString.Length > 0 AndAlso PFechaOC.ToString.Length < 8) Then
                    PFechaOC = 0
                End If
                ' dstreporte.Tables(0).Rows(x)("FORCML") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FORCML").ToString)
                dstreporte.Tables(0).Rows(x)("FORCML") = HelpClass.CFecha_de_8_a_10(PFechaOC)
            Next
            gwdDatos.DataSource = dstreporte.Tables(0)

      'Visualizar mensaje
      pbxProceso.Visible = False
      lblProceso.Visible = True
      lblProceso.Text = "Finalizado..."

    Catch ex As Exception
      DatosNoProcesados()
      lblProceso.Text = "Finalizado..."
      HelpClass.ErrorMsgBox()
      ClearMemory()
    End Try
    MenuBar.Enabled = True
    Me.Cursor = Cursors.Default

  End Sub
   

    Private Sub PrepararProceesWorked()
        'Se prepara las variables iniciales
        htProcees.Clear()
        lblProceso.Text = String.Empty

        If (txtOrdeDeCompra.Enabled) Then
            If (txtOrdeDeCompra.Text.Trim().Length = 0) Then
                MsgBox("Debe ingresar la Orden de Compra.", MsgBoxStyle.Exclamation)
                MenuBar.Enabled = True
                Exit Sub
            End If
        End If
        gwdDatos.DataSource = Nothing
        ControlVisorClienteGT.ReportViewer.ReportSource = Nothing
        ControlVisorClienteOC.ReportViewer.ReportSource = Nothing


        Me.Cursor = Cursors.WaitCursor
        TabControl1.SelectedIndex = 0
        gwdDatos.AutoGenerateColumns = False

        pbxProceso.Visible = True
        lblProceso.Visible = True
        lblProceso.Text = "Procesando..."


        htProcees.Add("CCMPN", cmbCompania.CCMPN_CodigoCompania)
        htProcees.Add("CDVSN", cmbDivision.Division)
        'htProcees.Add("CPLNDV", cmbPlanta.Planta)

        strPlanta = ""
        strPlantaDes = ""

        For i As Integer = 0 To chkcbxPlanta.CheckedItems.Count - 1

            strPlanta += chkcbxPlanta.CheckedItems(i).Value
            strPlantaDes += chkcbxPlanta.CheckedItems(i).Name


            If i < chkcbxPlanta.CheckedItems.Count - 1 Then
                strPlanta = String.Concat(strPlanta, ",")
                strPlantaDes = String.Concat(strPlantaDes, ",")
            End If

        Next



        htProcees.Add("CPLNDV", strPlanta)
        If ctlCliente.pCodigo.Equals("") Then
            htProcees.Add("CCLNT", 0)
        Else
            htProcees.Add("CCLNT", CInt(Me.ctlCliente.pCodigo))
        End If

        If ctlClienteFacturado.pCodigo.Equals("") Then
            htProcees.Add("CCLNTS_F", 0)
        Else
            htProcees.Add("CCLNTS_F", CInt(Me.ctlClienteFacturado.pCodigo))
        End If

        htProcees.Add("FINCOP_IN", Format(dtpFechaInicio.Value, "yyyyMMdd"))
        htProcees.Add("FINCOP_FI", Format(dtpFechaFin.Value, "yyyyMMdd"))
        htProcees.Add("STATUS", "")
        htProcees.Add("SORGMV", Me.cmbTraccion.SelectedValue)
        htProcees.Add("NORCML", txtOrdeDeCompra.Text.Trim)
    End Sub

#Region "Planta"
    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub
    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                Me.Limpiar()
                Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Try
            Me.cmbPlanta.Usuario = MainModule.USUARIO
            Me.cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            Me.cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            Me.cmbPlanta.PlantaDefault = 1
            If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
                'Me.cmbPlanta.pActualizar()
                Cargar_Planta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Limpiar()
        Me.gwdDatos.DataSource = Nothing
        ControlVisorClienteGT.ReportViewer.ReportSource = Nothing
        ControlVisorClienteOC.ReportViewer.ReportSource = Nothing
    End Sub

    Private Sub Cargar_Planta()

        chkcbxPlanta.Text = ""
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try

            If (Me.cmbCompania.CCMPN_CodigoCompania IsNot Nothing And Me.cmbDivision.Division IsNot Nothing) Then

                objPlanta.Crea_Lista()
                '
                objLisEntidad2 = objPlanta.Lista_Planta(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
                Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
                For Each objEntidad In objLisEntidad2
                    objLisEntidad.Add(objEntidad)
                Next
                chkcbxPlanta.DisplayMember = "TPLNTA"
                chkcbxPlanta.ValueMember = "CPLNDV"
                Me.chkcbxPlanta.DataSource = objLisEntidad

                For i As Integer = 0 To chkcbxPlanta.Items.Count - 1
                    If chkcbxPlanta.Items.Item(i).Value = "1" Then
                        chkcbxPlanta.SetItemChecked(i, True)
                    End If
                Next

                If chkcbxPlanta.Text = "" Then
                    chkcbxPlanta.SetItemChecked(0, True)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

    Private Sub btnExportarGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarGeneral.Click

        TabControl1.SelectedIndex = 0
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        'If (Me.gwdDatos.Rows.Count = 0) Then
        '  MsgBox("No existen datos a exportar.", MsgBoxStyle.Information)
        '  Exit Sub
        'End If
        'Dim objListDtg As New List(Of DataGridView)
        'objListDtg.Add(Me.gwdDatos)
        'HelpClass.ExportarExcel_HTML(objListDtg)

        Try
            If gwdDatos.Rows.Count <= 0 Then
                MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)

            'Envia los Parametros para la exportacion
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte de traslados por orden de compra"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte de traslados por orden de compra"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE DE TRASLADOS POR ORDEN DE COMPRA"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

            For Each dc As DataColumn In ODs.Tables(0).Columns
                Select Case dc.Caption
                    Case "SESTOP", "NPLVHT", "NPLCAC", "SINDRC", "NGUITR", "TCMPCL", _
           "TCMPCLFACTURADO", "ORIGEN", "DESTIN", "CTPUNV", "TCMTRT", "MONEDA", "MONEDAOC", "TDITES", "TPRVCL", "PLANTA_DESCRIPCION", "NGUIRM", "NORCM00001", "NMNFCR", "NMNFCR1", "NOPRCN", "FSLDCM", "FLLGCM", "NORCML"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

                    Case "CTRMNC", "CCLNT", "CCLNFC", "NUMERO", "NRITOC"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

                    Case "IMPPA", "TOTALGUIA", "QCNTIT", "IVUNIT", "IVTOIT", "PRUNI", "FLETEITEM"
                        dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

                End Select
            Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Catch ex As Exception
            MessageBox.Show(ex, "error")
        End Try

    End Sub

    Private Sub btnExportarContugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarContugas.Click

        Try

            If gwdDatos.Rows.Count = 0 Then
                Exit Sub
            End If

            Dim NPOI As New HelpClass_NPOI_ST

            NPOI = New Ransa.Utilitario.HelpClass_NPOI_ST

            If Me.gwdDatos.Rows.Count = 0 Then Exit Sub

            Dim ListaExcel As New DataTable
            ListaExcel = gwdDatos.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            'dtExcel.Columns.Add("PNNINCSI", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("Nro. Inc", HelpClass_NPOI_ST.keyDatoNumero)

            dtExcel.Columns.Add("NOPRCN").Caption = NPOI.FormatDato("Operación", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("NORCML").Caption = NPOI.FormatDato("Orden de Compra", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("FORCML").Caption = NPOI.FormatDato("Fecha puesta orden", HelpClass_NPOI_ST.keyDatoFecha)
            dtExcel.Columns.Add("TPRVCL").Caption = NPOI.FormatDato("Proveedor", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("CONTACTO").Caption = NPOI.FormatDato("Contacto (Proveedor)", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("FECOST").Caption = NPOI.FormatDato("Fecha de solicitud(Servicio)", HelpClass_NPOI_ST.keyDatoFecha)
            dtExcel.Columns.Add("TDITES").Caption = NPOI.FormatDato("Descripción del producto", HelpClass_NPOI_ST.keyDatoTexto)

            dtExcel.Columns.Add("NRITOC").Caption = NPOI.FormatDato("Item", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("QCNTIT").Caption = NPOI.FormatDato("Cantidad(Unidades)", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("PESO").Caption = NPOI.FormatDato("Peso(Kg)", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("TNMMDT").Caption = NPOI.FormatDato("Tipo de transporte", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("NMNFCR").Caption = NPOI.FormatDato("Guía transporte", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("NGUITR").Caption = NPOI.FormatDato("N° Guía de remisión", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("FATNSR").Caption = NPOI.FormatDato("Fecha de servicio", HelpClass_NPOI_ST.keyDatoFecha)
            dtExcel.Columns.Add("ORIGEN_UBIGEO").Caption = NPOI.FormatDato("Origen ubigeo", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("TDIROR").Caption = NPOI.FormatDato("Punto de recojo", HelpClass_NPOI_ST.keyDatoTexto)

            dtExcel.Columns.Add("DESTINO_UBIGEO").Caption = NPOI.FormatDato("Destino ubigeo", HelpClass_NPOI_ST.keyDatoFecha)
            dtExcel.Columns.Add("TDIRDS").Caption = NPOI.FormatDato("Punto de entrega", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("SOBREESTADIA").Caption = NPOI.FormatDato("Sobreestadía", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("MONTACARGAS").Caption = NPOI.FormatDato("Servicio de montacargas(origen-destino)", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("SERVICIO_PERSONAL").Caption = NPOI.FormatDato("Servicio de personal(carga y descarga)", HelpClass_NPOI_ST.keyDatoNumero)
            dtExcel.Columns.Add("FLLGCM").Caption = NPOI.FormatDato("Fecha de entrega", HelpClass_NPOI_ST.keyDatoFecha)  ''
            dtExcel.Columns.Add("TABTPD").Caption = NPOI.FormatDato("Tipo de Doc.", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("NDCMFC").Caption = NPOI.FormatDato("N° Factura", HelpClass_NPOI_ST.keyDatoTexto)
            dtExcel.Columns.Add("FECFAC").Caption = NPOI.FormatDato("Fecha Factura", HelpClass_NPOI_ST.keyDatoFecha)


            
            Dim ColName As String = ""
            For Each item As DataRow In ListaExcel.Rows
                dr = dtExcel.NewRow

                For Each Item1 As DataColumn In ListaExcel.Columns
                    ColName = Item1.ColumnName
                    If dtExcel.Columns(ColName) IsNot Nothing Then
                        dr(Item1.ColumnName) = item(Item1.ColumnName)
                    End If

                Next

                dtExcel.Rows.Add(dr)
            Next

            Dim ListaDatatable As New List(Of DataTable)
            dtExcel.TableName = "Resumen"
            ListaDatatable.Add(dtExcel.Copy)

            Dim ListaTitulos As New List(Of String)
            ListaTitulos.Add("RESUMEN DE TRASLADOS POR O/C")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.CCMPN_Descripcion)
            F.Add(1, "División:| " & cmbDivision.DivisionDescripcion)
            F.Add(2, "Planta:| " & strPlantaDes) 'cmbPlanta.DescripcionPlanta)

            oLisFiltro.Add(F)

            Dim ListColumnNFilas As New List(Of String)
            ListColumnNFilas.Add("NORCML")

            'Dim ListNameCombDuplicado As New List(Of String)
            'Dim CombCol As String = "NOPRCN:NOPRCN|NORCML:NOPRCN,NORCML"
            'CombCol = CombCol & "|TPRVCL:NORSCI,NORCML,TPRVCL|TPRSCN:NORSCI,NORCML,TPRSCN|TTINTC:NORSCI,NORCML,TTINTC|TCMPPS:NORSCI,TCMPPS"
            'CombCol = CombCol & "|TNMMDT:NORSCI,TNMMDT|NDOCEM:NORSCI,NDOCEM|TCMPVP:NORSCI,TCMPVP|PAI_ORIGEN:NORSCI,PAI_ORIGEN"
            'CombCol = CombCol & "|PAI_DESTINO:NORSCI,PAI_DESTINO|FAPREV:NORSCI,FAPREV|FAPRAR:NORSCI,FAPRAR|TNRODU:NORSCI,TNRODU|121_A_CHK:NORSCI,121_A_CHK"
            'CombCol = CombCol & "|123_A_CHK:NORSCI,123_A_CHK|ITTCAG:NORSCI,ITTCAG|SEGURO:NORSCI,SEGURO|124_A_CHK:NORSCI,124_A_CHK"
            'ListNameCombDuplicado.Add(CombCol)
            'TPRVCL

            NPOI.ExportExcelGeneralMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, Nothing)
            'NPOI.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, Nothing, 0, ListNameCombDuplicado)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class