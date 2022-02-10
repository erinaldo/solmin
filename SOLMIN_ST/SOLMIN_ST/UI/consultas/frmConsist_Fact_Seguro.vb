Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmConsist_Fact_Seguro
  Private objPlanta As New NEGOCIO.Planta_BLL
    'Private bolBuscar As Boolean = False
  Private _lstrPlanta As String = ""

  Private Sub frmConsistenciaFacturacionSeguro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
            'Me.cargarComboCompania()
            Cargar_Compania()

      Me.cargarComboTransportista()
      Me.gwdDatos.AutoGenerateColumns = False
      Me.gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    Catch : End Try
  End Sub

    'Private Sub cargarComboCompania()
    '  Try
    '    Dim objLogica As New NEGOCIO.Compania_BLL
    '    objLogica.Crea_Lista()
    '    bolBuscar = False
    '    cboCia.DataSource = objLogica.Lista
    '    cboCia.ValueMember = "CCMPN"
    '    cboCia.DisplayMember = "TCMPCM"
    '    cboCia.SelectedIndex = 0
    '    bolBuscar = True
    '    cboCia_SelectedIndexChanged(Nothing, Nothing)
    '  Catch ex As Exception
    '  End Try
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
    '            'cboDivision_SelectedIndexChanged(Nothing, Nothing)
    '        End If
    '    Catch ex As Exception
    '        HelpClass.ErrorMsgBox()

    '    End Try
    'End Sub

  Private Sub cargarComboPlanta()
    Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Try
            cboPlanta.Text = ""
            'If (bolBuscar = True And Me.cboCia.SelectedValue IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
            '  bolBuscar = False
            If (cmbCompania.CCMPN_CodigoCompania IsNot Nothing And cmbDivision.Division IsNot Nothing) Then
                objPlanta.Crea_Lista()
                objLisEntidad2 = objPlanta.Lista_Planta(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division)
                Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
                For Each objEntidad In objLisEntidad2
                    objLisEntidad.Add(objEntidad)
                Next
                Me.cboPlanta.DisplayMember = "TPLNTA"
                Me.cboPlanta.ValueMember = "CPLNDV"
                Me.cboPlanta.DataSource = objLisEntidad

                For i As Integer = 0 To cboPlanta.Items.Count - 1
                    If cboPlanta.Items.Item(i).Value = "1" Then
                        cboPlanta.SetItemChecked(i, True)
                    End If
                Next
                If cboPlanta.Text = "" Then
                    cboPlanta.SetItemChecked(0, True)
                End If
                'bolBuscar = True
                'CheckedComboBox1.SelectedIndex = 0
                cboPlanta_SelectedIndexChanged(Nothing, Nothing)
            End If
        Catch ex As Exception
        End Try
    'Try
    '    If (bolBuscar = True And Me.cboCia.SelectedValue IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
    '        Dim objLogica As New NEGOCIO.Planta_BLL
    '        bolBuscar = False
    '        objLogica.Crea_Lista()
    '        cboPlanta.DataSource = objLogica.Lista_Planta(cboCia.SelectedValue.ToString.Trim, cboDivision.SelectedValue.ToString.Trim)
    '        cboPlanta.ValueMember = "CPLNDV"
    '        cboPlanta.DisplayMember = "TPLNTA"
    '        cboPlanta.SelectedIndex = 0
    '        bolBuscar = True
    '        cboPlanta_SelectedIndexChanged(Nothing, Nothing)
    '    End If
    'Catch ex As Exception
    '    HelpClass.ErrorMsgBox()

    'End Try
  End Sub

  Private Sub cargarComboTransportista()
    Try
      Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
      'Dim objLogica As New Transportista_BLL
      'Dim objEntidad As New Transportista
      'objEntidad.NRUCTR = ""
      'objEntidad.CCMPN = Me.cboCia.SelectedValue
      'objEntidad.CDVSN = Me.cboDivision.SelectedValue
      'objEntidad.CPLNDV = Me.cboPlanta.SelectedValue

      Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
            'obeTransportista.pCCMPN_Compania = Me.cboCia.SelectedValue
            obeTransportista.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
      cboTransportista.pCargar(obeTransportista)

    Catch ex As Exception
      HelpClass.MsgBox(ex.Message)
    Finally
      Me.Cursor = System.Windows.Forms.Cursors.Default
    End Try
  End Sub

  Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
    Dim dstreporte As New DataSet
    dstreporte = Me.Datos_Reporte_Seguro_Flete
    If dstreporte Is Nothing Then
      Exit Sub
    End If
    If dstreporte.Tables.Count > 0 Then
      gwdDatos.DataSource = dstreporte.Tables(0)
    End If
  End Sub

  Private Function Datos_Reporte_Seguro_Flete() As DataSet
    Dim dst As New DataSet
    Dim objcoleccion As New Collection
    Dim objLogicaReportes As New ReportesVariados_BLL

    'Agregando Elementos
    objcoleccion.Add(HelpClass.CtypeDate(Me.dtpFechaInicio.Text))
    objcoleccion.Add(HelpClass.CtypeDate(Me.dtpFechaFin.Text))
        'objcoleccion.Add(Me.cboCia.SelectedValue)
        objcoleccion.Add(cmbCompania.CCMPN_CodigoCompania)
        'objcoleccion.Add(Me.cboDivision.SelectedValue)
        objcoleccion.Add(cmbDivision.Division)
    _lstrPlanta = ""
    For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
      _lstrPlanta += cboPlanta.CheckedItems(i).Value & ","
    Next

    If _lstrPlanta.Trim.Length > 0 Then
      _lstrPlanta = _lstrPlanta.Trim.Substring(0, _lstrPlanta.Trim.Length - 1)
    End If

    If _lstrPlanta = "" Then
      'objcoleccion.Add("")
      HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)
      Return dst
    Else
      objcoleccion.Add(_lstrPlanta)
    End If

    If Me.cboTransportista.pRucTransportista.Trim.Equals("") Then
      objcoleccion.Add(0)
    Else
      objcoleccion.Add(Me.cboTransportista.pCodigoRNS)
    End If

    If Me.ctlCliente.pCodigo = 0 Then
      objcoleccion.Add(0)
    Else
      objcoleccion.Add(Me.ctlCliente.pCodigo)
    End If

    dst = objLogicaReportes.Listado_Seguro_Flete(objcoleccion)
    Return dst

  End Function

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Generar_Reporte_Crystal()
  End Sub

    Private Sub Generar_Reporte_Crystal()
        Dim dstreporte As New DataSet
        dstreporte = Me.Datos_Reporte_Seguro_Flete()
        If dstreporte Is Nothing Then
            Exit Sub
        End If
        Try
            Dim objPrintForm = New PrintForm
            Dim objReporte As New rptReporteSeguro

            HelpClass.CrystalReportTextObject(objReporte, "lblFecha", "Del  " & Me.dtpFechaInicio.Text & "  al  " & Me.dtpFechaFin.Text)  'Estableciendo variables del reporte
            HelpClass.CrystalReportTextObject(objReporte, "lblTransportista", IIf(Me.cboTransportista.pRazonSocial.Trim.Equals(""), "TODOS", Me.cboTransportista.pRazonSocial))
            HelpClass.CrystalReportTextObject(objReporte, "lblFecha", "Desde " & Me.dtpFechaInicio.Text & "  -  Hasta  " & Me.dtpFechaFin.Text)
            'HelpClass.CrystalReportTextObject(objReporte, "lblCompania", Me.cboCia.Text)
            'HelpClass.CrystalReportTextObject(objReporte, "lblDivision", Me.cboDivision.Text)
            HelpClass.CrystalReportTextObject(objReporte, "lblCompania", cmbCompania.CCMPN_Descripcion)
            HelpClass.CrystalReportTextObject(objReporte, "lblDivision", cmbDivision.DivisionDescripcion)
            HelpClass.CrystalReportTextObject(objReporte, "lblPlanta", Me.cboPlanta.Text)

            objReporte.SetDataSource(dstreporte)

            objPrintForm.ShowForm(objReporte, Me)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            ClearMemory()
        End Try
    End Sub

  Private Sub btnExportarExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
    'Dim objListDtg As New List(Of DataGridView)
    'objListDtg.Add(Me.gwdDatos)
    'HelpClass.ExportarExcel_HTML(objListDtg)
    Try
      If gwdDatos.Rows.Count <= 0 Then
        MessageBox.Show("No hay datos para procesar", "Exportacón", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
      Dim ODs As New DataSet
      Dim objDt As New DataTable
      Dim loEncabezados As New Generic.List(Of Encabezados)
      'Envia los Parametros para la exportacion
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Consistencia factura Seguro"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Consistencia factura Seguro"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE CONSISTENCIA FACTURA SEGURO"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
      objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

      ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

      For Each dc As DataColumn In ODs.Tables(0).Columns
        Select Case dc.Caption
          Case "TCMTRT", "MONTO", "CLCLOR", "CLCLDS", "NPLCTR", "NPLCAC", "STPOUN", "PLANTA_DESCRIPCION", "NGUITR", "NGUIRM", "NLQDCN", "NOPRCN"
            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

        End Select
      Next
      HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
    Catch ex As Exception
      MessageBox.Show(ex, "Error:")
    End Try
  End Sub

    'Private Sub cboCia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If (bolBuscar = True) Then
    '        cargarComboDivision()
    '    End If
    'End Sub

    'Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If (bolBuscar = True) Then
    '        cargarComboPlanta()
    '    End If
    'End Sub

  Private Sub InicializarFormulario()
    Try
      gwdDatos.DataSource = Nothing
      ctlCliente.pClear()
      cboTransportista.pClear()
            'ctlCliente.CCMPN = cboCia.SelectedValue.ToString().Trim()
            ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
      cargarComboTransportista()
    Catch ex As Exception

    End Try

  End Sub

  Private Sub cboPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (bolBuscar = True) Then
        '  InicializarFormulario()
        'End If
        InicializarFormulario()
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
            'Me.cmbPlanta.Usuario = MainModule.USUARIO
            'Me.cmbPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            'Me.cmbPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            'Me.cmbPlanta.PlantaDefault = 1
            If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
                'Me.cmbPlanta.pActualizar()
                cargarComboPlanta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Limpiar()
        InicializarFormulario()
    End Sub



#End Region


End Class
