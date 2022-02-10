Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmResGuiaRemABC
    Private bolBuscar As Boolean = False
  Private objPlanta As New NEGOCIO.Planta_BLL
  Private dtPrincipal_1 As DataTable
    Dim strPlanta As String = ""
    Private Sub frmResGuiaRemABC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'cargarComboCompania()
            Cargar_Compania()
            dtgReporte1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            CargarTipoReporte()
            CrearColumnaReporte1()
            CrearColumnaReporte2()
            'Cargar_Planta()
        Catch : End Try

    End Sub

    Private Sub CargarTipoReporte()
        Dim oDt As New DataTable

        oDt.Columns.Add("COD")
        oDt.Columns.Add("DES")

        Dim oDr As DataRow = oDt.NewRow
        oDr.Item(0) = "T"
        oDr.Item(1) = "Todos"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "R"
        oDr.Item(1) = "Resumen total"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "C"
        oDr.Item(1) = "Resumen de Servicios por cliente"
        oDt.Rows.Add(oDr)

        oDr = oDt.NewRow
        oDr.Item(0) = "D"
        oDr.Item(1) = "Resumen de Servicios Mixtos"
        oDt.Rows.Add(oDr)

    End Sub

    
    'Private Sub cargarComboCompania()
    '    Try
    '        Dim objLogica As New NEGOCIO.Compania_BLL
    '        bolBuscar = False
    '        objLogica.Crea_Lista()
    '        cboCia.DataSource = objLogica.Lista
    '        cboCia.ValueMember = "CCMPN"
    '        cboCia.DisplayMember = "TCMPCM"
    '        cboCia.SelectedIndex = 0
    '        bolBuscar = True
    '        cboCia_SelectedIndexChanged(Nothing, Nothing)
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub cargarComboDivision()
    '    Try
    '        If (bolBuscar = True And Me.cboCia.SelectedValue IsNot Nothing) Then
    '            Dim objLogica As New NEGOCIO.Division_BLL
    '            bolBuscar = False
    '            objLogica.Crea_Lista()
    '            cboDivision.DataSource = objLogica.Lista_Division(cboCia.SelectedValue.ToString.Trim)
    '            cboDivision.ValueMember = "CDVSN"
    '            cboDivision.DisplayMember = "TCMPDV"
    '            'cboDivision.SelectedIndex = 0
    '            bolBuscar = True
    '            Me.cboDivision.SelectedValue = "T"
    '            If Me.cboDivision.SelectedIndex = -1 Then
    '                Me.cboDivision.SelectedIndex = 0
    '            End If
    '        End If
    '    Catch ex As Exception
    '        HelpClass.ErrorMsgBox()

    '    End Try
    'End Sub

    'Private Sub cargarComboPlanta()
    '    Try
    '        If (bolBuscar = True And Me.cboCia.SelectedValue IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
    '            Dim objLogica As New NEGOCIO.Planta_BLL
    '            bolBuscar = False
    '            objLogica.Crea_Lista()
    '            cboPlanta.DataSource = objLogica.Lista_Planta(cboCia.SelectedValue.ToString.Trim, cboDivision.SelectedValue.ToString.Trim)
    '            cboPlanta.ValueMember = "CPLNDV"
    '            cboPlanta.DisplayMember = "TPLNTA"
    '            bolBuscar = True
    '            cboPlanta.SelectedIndex = 0
    '            cboPlanta_SelectedIndexChanged(Nothing, Nothing)
    '        End If
    '    Catch ex As Exception
    '        HelpClass.ErrorMsgBox()

    '    End Try

    'End Sub

   
    'Private Sub cboCia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If bolBuscar = True Then
    '        cargarComboDivision()
    '    End If
    'End Sub

    'Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If bolBuscar = True Then
    '        cargarComboPlanta()
    '    End If
    'End Sub

    'Private Sub cboPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If bolBuscar = True Then
    '        InicializarFormulario()
    '    End If
    'End Sub
   
    Private Sub InicializarFormulario()
        txtCliente.pClear()
        LimpiarReportes()
        'txtCliente.CCMPN = Me.cboCia.SelectedValue.ToString().Trim()
        txtCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
        LimpiarReportes()
    End Sub
    
    Private Sub btnProcesarReporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        '  LimpiarReportes()
        ' Generar_Reporte_Crystal()
   
        strPlanta = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1

            strPlanta += cmbPlanta.CheckedItems(i).Value

            If i < cmbPlanta.CheckedItems.Count - 1 Then
                strPlanta = String.Concat(strPlanta, ",")
            End If

        Next

        Try

            If strPlanta = "" Then
                'objcoleccion.Add("")
                HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)
                Me.Cursor = Cursors.Default
                ControlVisorVehiculo.Ocultar_Imagen()
                Control_Visor_Reporte1.Ocultar_Imagen()
                Control_Visor_Reporte2.Ocultar_Imagen()


                Exit Sub

            End If
            Generar_Reporte_Crystal()
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try


    End Sub
    Private Sub LimpiarReportes()
        ControlVisorVehiculo.ReportViewer.ReportSource = Nothing
        Control_Visor_Reporte1.ReportViewer.ReportSource = Nothing
        Control_Visor_Reporte2.ReportViewer.ReportSource = Nothing
    End Sub
    Private Function Datos_Reporte_Guias_ABC() As DataSet
        Try
            Dim objLogica As New ReportesVariados_BLL
            Dim ht As New Hashtable

            'ht.Add("CMPN", Me.cboCia.SelectedValue)
            'ht.Add("CDVSN", Me.cboDivision.SelectedValue)
            'ht.Add("CPLNDV", Me.cboPlanta.SelectedValue)
            ht.Add("CMPN", cmbCompania.CCMPN_CodigoCompania)
            ht.Add("CDVSN", Me.cmbDivision.Division)
            ht.Add("CPLNDV", strPlanta) 'cambio este
            ht.Add("CCLNT", Me.txtCliente.pCodigo)
            ht.Add("FGUITR_I", HelpClass.CtypeDate(Me.dtpFechaInicio.Text))
            ht.Add("FGUITR_F", HelpClass.CtypeDate(Me.dtpFechaFin.Text))

            Dim objData As New DataSet
            objData = objLogica.Datos_Reporte_Guias_ABC(ht)

            Return objData
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Generar_Reporte_Crystal()
    End Sub

    Private Sub Generar_Reporte_Crystal()
        ControlVisorVehiculo.Muestra_Imagen()
        Control_Visor_Reporte1.Muestra_Imagen()
        Control_Visor_Reporte2.Muestra_Imagen()
        Try
            Dim dst As New DataSet
            dst = Datos_Reporte_Guias_ABC()
            dst.Tables(0).TableName = "dtResumenTotal"
            dst.Tables(1).TableName = "dtResumenServiciosClientes"
            dst.Tables(2).TableName = "dtDetalleServiciosClientes"

            ' Si todo esta Ok... cargamos el reporte de los movimientos de operaciones
            Dim rptReporte As New rptResumenGuiasABC
            Dim rptReporte1 As New rptResumenTotalGeneralGuiasABC
            Dim rptReporte2 As New rptResumenServiciosClientesABC
            rptReporte.Subreports.Item("rptResumenTotal").SetDataSource(dst.Tables(0))
            rptReporte.Subreports.Item("rptResumenTotal_Grafico").SetDataSource(dst.Tables(0))

            rptReporte1.SetDataSource(dst.Tables(2))
            rptReporte2.SetDataSource(dst.Tables(1))

            rptReporte.Refresh()

            ControlVisorVehiculo.ReportViewer.ReportSource = rptReporte
            Control_Visor_Reporte1.ReportViewer.ReportSource = rptReporte2
            Control_Visor_Reporte2.ReportViewer.ReportSource = rptReporte1

            dtgReporte1.DataSource = dst.Tables(1)
      dtgReporte2.DataSource = dst.Tables(2)

        Catch ex As Exception
        End Try
        ControlVisorVehiculo.Ocultar_Imagen()
        Control_Visor_Reporte1.Ocultar_Imagen()
        Control_Visor_Reporte2.Ocultar_Imagen()

    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click

    'Dim objListDtg As New List(Of DataGridView)
    'objListDtg.Add(Me.dtgReporte1)
    'objListDtg.Add(Me.dtgReporte2)
    'HelpClass.ExportarExcel_OLEDB(objListDtg, ",", False)

    Try
      Select Case TabControl1.SelectedIndex

        Case 1 'Resumen Detalle Servicios Cliente 

          If dtgReporte1.Rows.Count <= 0 Then
            MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
          End If
          Dim ODs As New DataSet
          Dim objDt As New DataTable
          Dim loEncabezados As New Generic.List(Of Encabezados)

          'Envia los Parametros para la exportacion
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Mensual Guías ABC"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Resumen Detalle Servicios Cliente"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE MENSUAL GUÍAS ABC"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
          objDt = CType(Me.dtgReporte1.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

          ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgReporte1, objDt))

          For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
              Case "SRPTRM", "TCMPCL", "NPLVHT", "MES"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

              Case "NSERV", "CCLNT"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

              Case "PBRTOR", "QKLMRC"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

            End Select
          Next
          HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Case 2 'Resumen Servicios Cliente

          If dtgReporte2.Rows.Count <= 0 Then
            MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
          End If
          Dim ODs As New DataSet
          Dim objDt As New DataTable
          Dim loEncabezados As New Generic.List(Of Encabezados)

          'Envia los Parametros para la exportacion
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Mensual Guías ABC"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Resumen Servicios Cliente"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE MENSUAL GUÍAS ABC"))
          loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
          objDt = CType(Me.dtgReporte2.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

          ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.dtgReporte2, objDt))

          For Each dc As DataColumn In ODs.Tables(0).Columns
            Select Case dc.Caption
              Case "SRPTRM", "TCMPCL", "NPLVHT", "MES"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

              Case "NSERV", "CCLNT"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

              Case "PBRTOR", "QKLMRC"
                dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

            End Select
          Next
          HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

      End Select

    Catch ex As Exception

    End Try

    End Sub

    Private Sub CrearColumnaReporte1()
        dtgReporte1.Columns.Clear()
        Dim Columna As DataGridViewTextBoxColumn

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Mes"
        Columna.DataPropertyName = "MES"
        dtgReporte1.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Cliente"
        Columna.DataPropertyName = "CCLNT"
        Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgReporte1.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Razón Social"
        Columna.DataPropertyName = "TCMPCL"
        Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgReporte1.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Tipo"
        Columna.DataPropertyName = "SRPTRM"
        dtgReporte1.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Servicios"
        Columna.DataPropertyName = "NSERV"
        Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgReporte1.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Peso"
        Columna.DataPropertyName = "PBRTOR"
        dtgReporte1.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Kilometro"
        Columna.DataPropertyName = "QKLMRC"
        dtgReporte1.Columns.Add(Columna)

        dtgReporte1.AutoGenerateColumns = False
    End Sub

    Private Sub CrearColumnaReporte2()
        dtgReporte2.Columns.Clear()
        Dim Columna As DataGridViewTextBoxColumn

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Mes"
        Columna.DataPropertyName = "MES"
        dtgReporte2.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Cliente"
        Columna.DataPropertyName = "CCLNT"
        Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgReporte2.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Razón Social"
        Columna.DataPropertyName = "TCMPCL"
        Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgReporte2.Columns.Add(Columna)


        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Placa"
        Columna.DataPropertyName = "NPLVHT"
        Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgReporte2.Columns.Add(Columna)


        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Tipo"
        Columna.DataPropertyName = "SRPTRM"
        dtgReporte2.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Servicios"
        Columna.DataPropertyName = "NSERV"
        Columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgReporte2.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Peso"
        Columna.DataPropertyName = "PBRTOR"
        dtgReporte2.Columns.Add(Columna)

        Columna = New DataGridViewTextBoxColumn
        Columna.HeaderText = "Kilometro"
        Columna.DataPropertyName = "QKLMRC"
        dtgReporte2.Columns.Add(Columna)

        dtgReporte2.AutoGenerateColumns = False
    End Sub

#Region "Planta"
    '' metodo recien ingresado (09-03-2012)
    Private Sub Cargar_Planta()

        cmbPlanta.Text = ""
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
                cmbPlanta.DisplayMember = "TPLNTA"
                cmbPlanta.ValueMember = "CPLNDV"
                Me.cmbPlanta.DataSource = objLisEntidad

                For i As Integer = 0 To cmbPlanta.Items.Count - 1
                    If cmbPlanta.Items.Item(i).Value = "1" Then
                        cmbPlanta.SetItemChecked(i, True)
                    End If
                Next
                If cmbPlanta.Text = "" Then
                    cmbPlanta.SetItemChecked(0, True)
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub




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
        'Try
        '    Me.cmbPlanta.Usuario = MainModule.USUARIO
        '    Me.cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        '    Me.cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        '    Me.cmbPlanta.PlantaDefault = 1
        '    If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
        '        Me.cmbPlanta.pActualizar()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try


        Try
            Me.cmbPlantaDiv.Usuario = MainModule.USUARIO
            Me.cmbPlantaDiv.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            Me.cmbPlantaDiv.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            Me.cmbPlantaDiv.PlantaDefault = 1
            If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
                ' Me.cmbPlantaDiv.pActualizar()
                Cargar_Planta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub Limpiar()
       InicializarFormulario
    End Sub



#End Region



    
End Class


