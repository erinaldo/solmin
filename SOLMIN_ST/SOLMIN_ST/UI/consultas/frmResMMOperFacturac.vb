Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.Utilitario

Public Class frmResMMOperFacturac
    'Private bolBuscar As Boolean = False
  Private objCompaniaBLL As New NEGOCIO.Compania_BLL
  Private objDivision As New NEGOCIO.Division_BLL
  Private objPlanta As New NEGOCIO.Planta_BLL
  Private _lstrTipoCuenta As String
    Private objLista As New List(Of String)
    Dim strPlanta As String = ""

  Private Sub CargarEstado()
    Dim oDt As New DataTable
    Dim oDr As DataRow
    oDt.Columns.Add("COD")
    oDt.Columns.Add("DES")

    oDr = oDt.NewRow
    oDr.Item(0) = "T"
    oDr.Item(1) = "TODOS"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "P"
    oDr.Item(1) = "PENDIENTE"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "F"
    oDr.Item(1) = "FACTURADO"
    oDt.Rows.Add(oDr)


    oDr = oDt.NewRow
    oDr.Item(0) = "A"
    oDr.Item(1) = "ANULADO"
    oDt.Rows.Add(oDr)

    Me.cmbEstado.DataSource = oDt
    Me.cmbEstado.ValueMember = "COD"
    Me.cmbEstado.DisplayMember = "DES"

  End Sub

  Private Sub Cargar_Region_Venta()
    Try
      Dim objLogica As New ReportesVariados_BLL
            'Me.cboRegionVenta.DataSource = objLogica.Lista_Region_Venta(Me.cmbCompania.SelectedValue)
            Me.cboRegionVenta.DataSource = objLogica.Lista_Region_Venta(Me.cmbCompania.CCMPN_CodigoCompania)
      Me.cboRegionVenta.ValueMember = "CODIGO"
      Me.cboRegionVenta.DisplayMember = "REGION"
      Me.cboRegionVenta.SelectedValue = "0"
    Catch ex As Exception
    End Try
  End Sub

  Private Sub frmResMMOperFacturac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'bolBuscar = False
    Cargar_Compania()
    CargarEstado()
    'SE AGREGO
    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    cmbEstado.SelectedIndex = 0
        'obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        obeTracto.pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania
    Me.txtTransportista.pCargar(obeTracto)
    gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'ctlCliente.CCMPN = Me.cmbCompania.SelectedValue.ToString().Trim()
        ctlCliente.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        gwdDatos.AutoGenerateColumns = False

    pbxProceso.Visible = False
        lblProceso.Visible = False
        Cargar_Planta()
  End Sub

    'Private Sub Cargar_Compania()
    '  Try
    '    bolBuscar = False
    '    objCompaniaBLL.Crea_Lista()
    '    cmbCompania.DataSource = objCompaniaBLL.Lista
    '    cmbCompania.ValueMember = "CCMPN"
    '    cmbCompania.DisplayMember = "TCMPCM"
    '    cmbCompania.SelectedIndex = 0
    '    bolBuscar = True
    '    cmbCompania_SelectedIndexChanged(Nothing, Nothing)
    '  Catch ex As Exception
    '  End Try
    'End Sub

    'Private Sub Cargar_Division()
    '    Dim objDivision As New NEGOCIO.Division_BLL
    '    Try
    '        If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
    '            bolBuscar = False
    '            objDivision.Crea_Lista()
    '            cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
    '            cmbDivision.ValueMember = "CDVSN"
    '            cmbDivision.DisplayMember = "TCMPDV"
    '            'cmbDivision.SelectedIndex = 0
    '            bolBuscar = True
    '            Me.cmbDivision.SelectedValue = "T"
    '            If Me.cmbDivision.SelectedIndex = -1 Then
    '                Me.cmbDivision.SelectedIndex = 0
    '            End If
    '        End If
    '    Catch ex As Exception
    '        HelpClass.MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub Cargar_Planta()

        CheckedComboBox1.Text = ""
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try
            'If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then
            'If (bolBuscar = True And Me.cmbCompania.CCMPN_CodigoCompania IsNot Nothing And Me.cmbDivision.Division IsNot Nothing) Then
            '    bolBuscar = False
            'bolBuscar = True And 
            If (Me.cmbCompania.CCMPN_CodigoCompania IsNot Nothing And Me.cmbDivision.Division IsNot Nothing) Then
                'bolBuscar = False
                objPlanta.Crea_Lista()
                'objLisEntidad2 = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                objLisEntidad2 = objPlanta.Lista_Planta(Me.cmbCompania.CCMPN_CodigoCompania, Me.cmbDivision.Division)
                Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
                For Each objEntidad In objLisEntidad2
                    objLisEntidad.Add(objEntidad)
                Next
                CheckedComboBox1.DisplayMember = "TPLNTA"
                CheckedComboBox1.ValueMember = "CPLNDV"
                Me.CheckedComboBox1.DataSource = objLisEntidad

                For i As Integer = 0 To CheckedComboBox1.Items.Count - 1
                    If CheckedComboBox1.Items.Item(i).Value = "1" Then
                        CheckedComboBox1.SetItemChecked(i, True)
                    End If
                Next
                If CheckedComboBox1.Text = "" Then
                    CheckedComboBox1.SetItemChecked(0, True)
                End If
                If objLisEntidad.Count > 0 Then
                    _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
                Else
                    _lstrTipoCuenta = ""
                End If

                'bolBuscar = True
                'CheckedComboBox1.SelectedIndex = 0
                'CheckedComboBox1_SelectedIndexChanged(Nothing, Nothing)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click

        'gwdDatos.DataSource = Nothing
        'ControlVisorVehiculo.ReportViewer.ReportSource = Nothing
        'Control_Visor_ReporteGrafico.ReportViewer.ReportSource = Nothing
        ''ControlVisorOrdenServicios.ReportViewer.ReportSource = Nothing

        'Me.Cursor = Cursors.WaitCursor
        'ControlVisorVehiculo.Muestra_Imagen()
        'Control_Visor_ReporteGrafico.Muestra_Imagen()
        ''ControlVisorOrdenServicios.Muestra_Imagen()

        '' Agregado por: Hugo Pérez Ryan
        '' Fecha:        01/03/2012
        '' Descripción:  Se está modificando para que la consulta 
        '' pueda ser utilizada para escoger una o más plantas
        'strPlanta = ""
        'For i As Integer = 0 To CheckedComboBox1.CheckedItems.Count - 1

        '    strPlanta += CheckedComboBox1.CheckedItems(i).Value

        '    If i < CheckedComboBox1.CheckedItems.Count - 1 Then
        '        strPlanta = String.Concat(strPlanta, ",")
        '    End If

        'Next
        'Try
        '    'Generar_Reporte_Crystal_222()
        'Catch ex As Exception
        '    HelpClass.ErrorMsgBox()
        '    Me.Cursor = Cursors.Default
        '    ClearMemory()
        'End Try
        'ControlVisorVehiculo.Ocultar_Imagen()
        'Control_Visor_ReporteGrafico.Ocultar_Imagen()
        ''ControlVisorOrdenServicios.Ocultar_Imagen()
        'Me.Cursor = Cursors.Default




        ''''
        Try
            gwdDatos.DataSource = Nothing
            ControlVisorVehiculo.ReportViewer.ReportSource = Nothing
            Control_Visor_ReporteGrafico.ReportViewer.ReportSource = Nothing
            PrepararProceesWorked()
            bgwProceso.RunWorkerAsync()
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            Me.Cursor = Cursors.Default
            ClearMemory()
        End Try
        MenuBar.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If bolBuscar = True Then
    '        Cargar_Division()
    '        Cargar_Region_Venta()
    '    End If
    'End Sub
    'Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If bolBuscar Then
    '        Cargar_Planta()
    '    End If
    'End Sub
    'Private Sub CheckedComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedComboBox1.SelectedIndexChanged
    '  If bolBuscar = True Then
    '    InicializarFormulario()
    '  End If
    'End Sub

  Private Sub CargarTransportista()
    txtTransportista.pClear()
    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        'obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
    Me.txtTransportista.pCargar(obeTracto)
  End Sub

  Private Sub InicializarFormulario()
    gwdDatos.DataSource = Nothing
    ControlVisorVehiculo.ReportViewer.ReportSource = Nothing
    Control_Visor_ReporteGrafico.ReportViewer.ReportSource = Nothing
    ctlCliente.pClear()
    txtTransportista.pClear()
        'ctlCliente.CCMPN = Me.cmbCompania.SelectedValue.ToString().Trim()
        ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
    CargarTransportista()
  End Sub


  'Private Function Datos_Reporte_Facturacion_Operaciones() As DataSet
  '  Dim objLista As New List(Of String)
  '  Dim objLogica As New ReportesVariados_BLL
  '  Dim dstReporte As New DataSet

  '  objLista.Add(Me.cmbCompania.SelectedValue)
  '  objLista.Add(Me.cmbDivision.SelectedValue)

  '  Dim strDescripcionPlanta As String = ""

  '  For i As Integer = 0 To CheckedComboBox1.CheckedItems.Count - 1
  '    strDescripcionPlanta += CheckedComboBox1.CheckedItems(i).Value & ","
  '  Next

  '  If strDescripcionPlanta.Trim.Length > 0 Then
  '    strDescripcionPlanta = strDescripcionPlanta.Trim.Substring(0, strDescripcionPlanta.Trim.Length - 1)
  '  End If
  '  If strDescripcionPlanta = "" Then
  '    objLista.Add("")
  '  Else
  '    objLista.Add(strDescripcionPlanta)
  '  End If

  '  If ctlCliente.pCodigo = 0 Then
  '    objLista.Add("0")
  '  Else
  '    objLista.Add(Me.ctlCliente.pCodigo.ToString())
  '  End If
  '  objLista.Add(HelpClass.CtypeDate(Me.dtpFechaInicio.Value))
  '  objLista.Add(HelpClass.CtypeDate(Me.dtpFechaFin.Value))

  '  If txtTransportista.pRucTransportista = "" Then 'ojo david
  '    objLista.Add("")
  '  Else
  '    objLista.Add(txtTransportista.pCodigoRNS)
  '  End If
  '  objLista.Add(cmbEstado.SelectedValue)
  '  dstReporte = objLogica.Reporte_Facturacion_Operaciones(objLista)

  '  Return dstReporte

  'End Function

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    If Not gwdDatos Is Nothing Then
      If gwdDatos.RowCount > 0 Then

        ControlVisorVehiculo.ReportViewer.PrintReport()
      End If
    End If
  End Sub

  Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
    'TabControl1.SelectedIndex = 0
    'System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
    'If (Me.gwdDatos.Rows.Count = 0) Then
    '  MsgBox("No existen datos a exportar.", MsgBoxStyle.Information)
    '  Exit Sub
    'End If
    'Dim objListDtg As New List(Of DataGridView)
    'objListDtg.Add(Me.gwdDatos)
    'HelpClass.ExportarExcel_HTML(objListDtg)

    Try
      gwdDatos.Columns(35).HeaderText = "Moneda a Cobrar"
      gwdDatos.Columns(35).HeaderText = "Moneda a Pagar"

      If gwdDatos.Rows.Count <= 0 Then
        MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
      Dim ODs As New DataSet
      Dim objDt As New DataTable
      Dim loEncabezados As New Generic.List(Of Encabezados)

      'Envia los Parametros para la exportacion
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Mensual de Operaciones Facturación "))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Mensual de Operaciones Facturación"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE MENSUAL DE OPERACIONES FACTURACIÓN"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
      objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

      ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

      For Each dc As DataColumn In ODs.Tables(0).Columns
        Select Case dc.Caption
          Case "SESTOP", "CCLNT", "CCLNFC", "FDCPRF", "HRACRT", "NGUITR", "NGUIRM", _
          "SGUIFC", "CLCLOR", "CLCLDS", "NPLVHT", "CBRCNT", "TNMCH2", "TCMTRT", "CPLNDV", "ESTADO", "MNDCO", _
          "MNDPA", "TCRVTA", "NDCMFC", "NDCPRF", "NOPRCN", "NOPRCN1", "NPLNMT", "NORINS"
            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

          Case "TRFSRC", "CTPDCF", "NLQDCN", "NRFSAP", "NENMRS", "FDCCTC"
            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)

          Case "GASTOS", "GASTOAVC", "IMPCO", "IMPPA"
            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)

        End Select
      Next
      HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
    Catch ex As Exception
      MessageBox.Show(ex, "ERROR:")
    End Try

  End Sub

    Private Sub Generar_Reporte_Crystal()
        'Dim dstreporte As New DataSet
        'dstreporte = Me.Datos_Reporte_Listado_Tarifa()
        'gwdDatos.DataSource = dstreporte.Tables(0)
        'If dstreporte Is Nothing Then
        '    Me.ControlVisorOrdenServicios.ReportViewer.ReportSource = Nothing
        '    Exit Sub
        'End If
        'Try
        '    Dim strCliente As String = ""
        '    Dim objReporte = New ReporteListadoTarifasxOrdenServicio
        '    'HelpClass.CrystalReportTextObject(objReporte, "lblCompania", Me.cboCia.Text.Trim)
        '    'HelpClass.CrystalReportTextObject(objReporte, "lblDivision", Me.cboDivision.Text.Trim)
        '    'HelpClass.CrystalReportTextObject(objReporte, "lblPlanta", Me.cboPlanta.Text.Trim)

        '    HelpClass.CrystalReportTextObject(objReporte, "lblCompania", cmbCompania.CCMPN_Descripcion)
        '    HelpClass.CrystalReportTextObject(objReporte, "lblDivision", cmbDivision.DivisionDescripcion)
        '    ' HelpClass.CrystalReportTextObject(objReporte, "lblPlanta", cmbPlanta.DescripcionPlanta)

        '    ' Agregado por: Hugo Pérez Ryan
        '    ' Fecha:        01/03/2012
        '    ' Descripción:  Se está modificando para que la consulta 
        '    ' pueda ser utilizada para escoger una o más plantas
        '    HelpClass.CrystalReportTextObject(objReporte, "lblPlanta", chkcbxPlanta.Text)

        '    HelpClass.CrystalReportTextObject(objReporte, "lblEstado", Me.cboEstado.Text)
        '    objReporte.SetDataSource(dstreporte)
        '    Me.ControlVisorOrdenServicios.ReportViewer.ReportSource = objReporte
        'Catch ex As Exception
        '    HelpClass.ErrorMsgBox()
        '    ClearMemory()
        'End Try
    End Sub





  Private Sub Generar_Reporte_Detalle(ByVal dstreporte As DataSet)
    Dim objReporte As ReportClass
    objReporte = New rptOperacionesFacturadas

    HelpClass.CrystalReportTextObject(objReporte, "lblTransportista", IIf(txtTransportista.pRucTransportista = "", "TODOS", Me.txtTransportista.pRazonSocial)) 'ojo david
    HelpClass.CrystalReportTextObject(objReporte, "lblFecha", "Desde " & Me.dtpFechaInicio.Text & "  -  Hasta  " & Me.dtpFechaFin.Text)
        HelpClass.CrystalReportTextObject(objReporte, "lblCompania", Me.cmbCompania.CCMPN_Descripcion)
        HelpClass.CrystalReportTextObject(objReporte, "lblDivision", Me.cmbDivision.DivisionDescripcion)

    Dim strDescripcionPlanta As String = ""
    For i As Integer = 0 To CheckedComboBox1.CheckedItems.Count - 1
      strDescripcionPlanta += CheckedComboBox1.CheckedItems(i).Name & ","
    Next
    If strDescripcionPlanta.Trim.Length > 0 Then
      strDescripcionPlanta = strDescripcionPlanta.Trim.Substring(0, strDescripcionPlanta.Trim.Length - 1)
    End If
    If strDescripcionPlanta = "" Then
      HelpClass.CrystalReportTextObject(objReporte, "lblPlanta", "TODOS")
    Else
      HelpClass.CrystalReportTextObject(objReporte, "lblPlanta", strDescripcionPlanta)
    End If

    If ctlCliente.pCodigo = 0 Then
      HelpClass.CrystalReportTextObject(objReporte, "lblcliente", "TODOS")
    Else
      HelpClass.CrystalReportTextObject(objReporte, "lblcliente", ctlCliente.pCodigo)
    End If
    HelpClass.CrystalReportTextObject(objReporte, "lblEstadoOperacion", Me.cmbEstado.Text)


    objReporte.SetDataSource(dstreporte)
    ControlVisorVehiculo.ReportViewer.ReportSource = objReporte


  End Sub

  Private Sub Generar_Reporte_Resumen(ByVal dstreporte As DataSet)

    Dim objReporte As ReportClass
    objReporte = New rptResumenOperacionesGrafico
    Dim objSet As New DataSet
    Dim dw As New DataView(dstreporte.Tables(0))
    Dim TDT As New DataTable
    Dim TDT_1 As New DataTable
    TDT = dw.ToTable(True, "NOPRCN", "ESTADO")
    TDT.TableName = "RESUMEN"
    objSet.Tables.Add(TDT)
    HelpClass.CrystalReportTextObject(objReporte, "lblTransportista", IIf(txtTransportista.pRucTransportista = "", "TODOS", Me.txtTransportista.pRazonSocial)) 'ojo david
    HelpClass.CrystalReportTextObject(objReporte, "lblFecha", "Desde " & Me.dtpFechaInicio.Text & "  -  Hasta  " & Me.dtpFechaFin.Text)
        HelpClass.CrystalReportTextObject(objReporte, "lblCompania", Me.cmbCompania.CCMPN_Descripcion)
        HelpClass.CrystalReportTextObject(objReporte, "lblDivision", Me.cmbDivision.DivisionDescripcion)

    Dim strDescripcionPlanta As String = ""

    For i As Integer = 0 To CheckedComboBox1.CheckedItems.Count - 1
      strDescripcionPlanta += CheckedComboBox1.CheckedItems(i).Name & ","
    Next
    If strDescripcionPlanta.Trim.Length > 0 Then
      strDescripcionPlanta = strDescripcionPlanta.Trim.Substring(0, strDescripcionPlanta.Trim.Length - 1)
    End If
    If strDescripcionPlanta = "" Then
      HelpClass.CrystalReportTextObject(objReporte, "lblPlanta", "TODOS")
    Else
      HelpClass.CrystalReportTextObject(objReporte, "lblPlanta", strDescripcionPlanta)
    End If

    If ctlCliente.pCodigo = 0 Then
      HelpClass.CrystalReportTextObject(objReporte, "lblcliente", "TODOS")
    Else
      HelpClass.CrystalReportTextObject(objReporte, "lblcliente", ctlCliente.pCodigo)
    End If
    HelpClass.CrystalReportTextObject(objReporte, "lblEstadoOperacion", Me.cmbEstado.Text)

    objReporte.SetDataSource(objSet)
    Control_Visor_ReporteGrafico.ReportViewer.ReportSource = objReporte

  End Sub

  Private Sub PrepararProceesWorked()
    objLista.Clear()
    MenuBar.Enabled = False
    Me.Cursor = Cursors.WaitCursor
    TabControl1.SelectedIndex = 0
    pbxProceso.Visible = True
    lblProceso.Visible = True
    lblProceso.Text = "Procesando..."
        'objLista.Add(Me.cmbCompania.SelectedValue)
        'objLista.Add(Me.cmbDivision.SelectedValue)
        objLista.Add(cmbCompania.CCMPN_CodigoCompania)
        objLista.Add(Me.cmbDivision.Division)
    Dim strCodPlanta As String = ""
    For i As Integer = 0 To CheckedComboBox1.CheckedItems.Count - 1
      strCodPlanta += CheckedComboBox1.CheckedItems(i).Value & ","
    Next
    If strCodPlanta = "" Then
      For i As Integer = 0 To CheckedComboBox1.Items.Count - 1
        strCodPlanta += CheckedComboBox1.Items(i).Value & ","
      Next
    End If
    If strCodPlanta.Trim.Length > 0 Then
      strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If

        If strCodPlanta = "" Then
            'objcoleccion.Add("")
            HelpClass.MsgBox("Elija una Planta", MessageBoxIcon.Information)
            Me.Cursor = Cursors.Default
            ControlVisorVehiculo.Ocultar_Imagen()
            Control_Visor_ReporteGrafico.Ocultar_Imagen()


            Exit Sub

        End If

    objLista.Add(strCodPlanta)
    If ctlCliente.pCodigo = 0 Then
      objLista.Add("")
    Else
      objLista.Add(Me.ctlCliente.pCodigo.ToString())
    End If
    objLista.Add(HelpClass.CtypeDate(Me.dtpFechaInicio.Value))
    objLista.Add(HelpClass.CtypeDate(Me.dtpFechaFin.Value))
    If txtTransportista.pRucTransportista = "" Then
      objLista.Add("")
    Else
      objLista.Add(txtTransportista.pCodigoRNS)
    End If
    objLista.Add(cmbEstado.SelectedValue)
    If Me.rbnFechaOperacion.Checked = True Then
      objLista.Add(0)
    Else
      objLista.Add(1)
    End If
    objLista.Add(Me.cboRegionVenta.SelectedValue)
  End Sub

  Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
    Dim objLogica As New ReportesVariados_BLL
    e.Result = objLogica.Reporte_Facturacion_Operaciones(objLista)
  End Sub

  Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
    Dim dstreporte As New DataSet
    dstreporte = CType(e.Result, DataSet)
    If dstreporte Is Nothing Then
      ControlVisorVehiculo.ReportViewer.ReportSource = Nothing
      Control_Visor_ReporteGrafico.ReportViewer.ReportSource = Nothing
      Exit Sub
    End If
    If dstreporte.Tables.Count > 0 Then
      dstreporte.Tables(0).TableName = "ReporteOperacionesFacturadas"
      For x As Integer = 0 To dstreporte.Tables(0).Rows.Count - 1
        dstreporte.Tables(0).Rows(x)("FINCOP") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FINCOP").ToString)
        dstreporte.Tables(0).Rows(x)("FTRMOP") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FTRMOP").ToString)
        dstreporte.Tables(0).Rows(x)("FDCPRF") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FDCPRF").ToString)
        dstreporte.Tables(0).Rows(x)("FGUITR") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FGUITR").ToString)
        dstreporte.Tables(0).Rows(x)("FGUIRM") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FGUIRM").ToString)
        dstreporte.Tables(0).Rows(x)("FCHCRR") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FCHCRR").ToString)
        dstreporte.Tables(0).Rows(x)("FCHCRT") = HelpClass.CFecha_de_8_a_10(dstreporte.Tables(0).Rows(x)("FCHCRT").ToString)

      Next

    End If
    Try
      Generar_Reporte_Resumen(dstreporte)
      Generar_Reporte_Detalle(dstreporte)
      gwdDatos.DataSource = dstreporte.Tables(0)
      Me.Cursor = Cursors.Default
      'Visualizar mensaje
      pbxProceso.Visible = False
      lblProceso.Visible = True
      lblProceso.Text = "Finalizado..."
    Catch ex As Exception
      HelpClass.ErrorMsgBox()
      lblProceso.Text = "Finalizado..."
      ClearMemory()
    Finally
      MenuBar.Enabled = True
    End Try
  End Sub

  'Private Sub ActivarRangoFecha(ByVal activar As Boolean)
  '  dtpFechaInicio.Enabled = activar
  '  dtpFechaFin.Enabled = activar
  'End Sub

  'Private Sub chkFechaCarga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If (chkFechaCarga.Checked = True) Then
  '    ActivarRangoFecha(True)
  '  Else
  '    ActivarRangoFecha(False)
  '  End If
  'End Sub


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
                Cargar_Region_Venta()
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
                Cargar_Planta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Limpiar()
        'gwdDatos.DataSource = Nothing
        'ControlVisorVehiculo.ReportViewer.ReportSource = Nothing
        'Control_Visor_ReporteGrafico.ReportViewer.ReportSource = Nothing
        InicializarFormulario()
    End Sub



#End Region


    Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick

    End Sub
End Class