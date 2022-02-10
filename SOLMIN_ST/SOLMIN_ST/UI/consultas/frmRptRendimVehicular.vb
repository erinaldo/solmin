Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario


Public Class frmRptRendimVehicular

  Private bolBuscar As Boolean = False
  Private objCompaniaBLL As New NEGOCIO.Compania_BLL
  Private objDivision As New NEGOCIO.Division_BLL
  Private objPlanta As New NEGOCIO.Planta_BLL
  Private _lstrTipoCuenta As String
    Private objLista As New List(Of String)

    Private dstreporte As New DataTable

    Private objLisEntidad As New List(Of CentroCosto)
    Private match_RegionVEnta As New Predicate(Of CentroCosto)(AddressOf Busca_RegionVEnta)
    Private ValorRegion As Integer

    Public Function Busca_RegionVEnta(ByVal RolOpcionBE As CentroCosto) As Boolean
        If (RolOpcionBE.IDCORRELATIVO = ValorRegion) Then
            Return True
        Else
            Return False
        End If
    End Function


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

    'oDr = oDt.NewRow
    'oDr.Item(0) = "A"
    'oDr.Item(1) = "ANULADO"
    'oDt.Rows.Add(oDr)

    'Me.cmbEstado.DataSource = oDt
    'Me.cmbEstado.ValueMember = "COD"
    'Me.cmbEstado.DisplayMember = "DES"

  End Sub

    Private Sub cargarComboRegionVenta()

        Dim objLogica As New NEGOCIO.mantenimiento.CentroCosto_BLL
        cboRegionVenta.Text = ""
        Try
            If (cmbCompania.CCMPN_CodigoCompania IsNot Nothing And cmbDivision.Division IsNot Nothing) Then
                Dim OnjEntidadParam As New CentroCosto
                OnjEntidadParam.CCMPN = cmbCompania.CCMPN_CodigoCompania
                objLisEntidad = objLogica.Listar_RegionVenta(OnjEntidadParam)
                Me.cboRegionVenta.DisplayMember = "TCRVTA"
                Me.cboRegionVenta.ValueMember = "IDCORRELATIVO" '"TCRVTA"
                Me.cboRegionVenta.DataSource = objLisEntidad
                'For i As Integer = 0 To Me.cboRegionVenta.Items.Count - 1
                '    If cboRegionVenta.Items.Item(i).Value = "1" Then
                '        cboRegionVenta.SetItemChecked(i, True)
                '    End If
                'Next
            End If

        Catch ex As Exception
        End Try

    End Sub

  Private Sub frmResMMOperFacturac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bolBuscar = False
        Me.Cargar_Compania()
        Me.InicializarFormulario()
        Me.CargarEstado()
        ' Cargar_Planta()
        'SE AGREGO
        Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        'cmbEstado.SelectedIndex = 0
        'obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
        obeTracto.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
        Me.txtTransportista.pCargar(obeTracto)
        gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'ctlCliente.CCMPN = Me.cmbCompania.SelectedValue.ToString().Trim()
        ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
        pbxProceso.Visible = False
        lblProceso.Visible = False
        Me.cargarComboRegionVenta()

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
  '  Dim objDivision As New NEGOCIO.Division_BLL
  '  Try
  '    If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
  '      bolBuscar = False
  '      objDivision.Crea_Lista()
  '      cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
  '      cmbDivision.ValueMember = "CDVSN"
  '      cmbDivision.DisplayMember = "TCMPDV"
  '      'cmbDivision.SelectedIndex = 0
  '      bolBuscar = True
  '      Me.cmbDivision.SelectedValue = "T"
  '      If Me.cmbDivision.SelectedIndex = -1 Then
  '        Me.cmbDivision.SelectedIndex = 0
  '      End If
  '    End If
  '  Catch ex As Exception
  '    HelpClass.MsgBox(ex.Message)
  '  End Try
  'End Sub

  'Private Sub Cargar_Planta()
  '  Me.cmbPlanta.Usuario = MainModule.USUARIO
  '  Me.cmbPlanta.CodigoCompania = Me.cmbCompania.SelectedValue
  '  Me.cmbPlanta.CodigoDivision = Me.cmbDivision.SelectedValue
  '  Me.cmbPlanta.PlantaDefault = 1
  '  Me.cmbPlanta.pActualizar()
  'Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
  'Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
  'Try
  '  If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then
  '    bolBuscar = False
  '    objPlanta.Crea_Lista()
  '    objLisEntidad2 = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
  '    Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
  '    For Each objEntidad In objLisEntidad2
  '      objLisEntidad.Add(objEntidad)
  '    Next
  '    CheckedComboBox1.DisplayMember = "TPLNTA"
  '    CheckedComboBox1.ValueMember = "CPLNDV"
  '    Me.CheckedComboBox1.DataSource = objLisEntidad

  '    For i As Integer = 0 To CheckedComboBox1.Items.Count - 1
  '      If CheckedComboBox1.Items.Item(i).Value = "1" Then
  '        CheckedComboBox1.SetItemChecked(i, True)
  '      End If
  '    Next
  '    If objLisEntidad.Count > 0 Then
  '      _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
  '    Else
  '      _lstrTipoCuenta = ""
  '    End If

  '    bolBuscar = True
  '    'CheckedComboBox1.SelectedIndex = 0
  '    CheckedComboBox1_SelectedIndexChanged(Nothing, Nothing)
  '  End If
  'Catch ex As Exception
  'End Try
  'End Sub

  Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click

        'Dim objEntidad As New List(Of String)
        'Dim objReporte As New Reportes_BLL

        ''objEntidad.Add(Me.cmbCompania.SelectedValue)
        ''objEntidad.Add(Me.cmbDivision.SelectedValue)
        'objEntidad.Add(cmbCompania.CCMPN_CodigoCompania)
        'objEntidad.Add(Me.cmbDivision.Division)
        '    'objEntidad.Add(Me.cmbPlanta.p)
        '    objEntidad.Add(Me.cmbPlanta_inv.Planta)
        'objEntidad.Add(Me.ctlCliente.pCodigo)
        'objEntidad.Add(Me.txtTransportista.pCodigoRNS)
        'objEntidad.Add(HelpClass.CtypeDate(Me.dtpFechaInicio.Value))
        'objEntidad.Add(HelpClass.CtypeDate(Me.dtpFechaFin.Value))
        'objEntidad.Add(Me.txtPlaca.Text)

        'Dim dtb As New DataTable
        'dtb = objReporte.Reporte_Rendimiento_Vehicular(objEntidad)

        'Dim objReporteCR As New rptRendimientoVehicular
        'objReporteCR.SetDataSource(dtb)

        ''Estableciendo las variables finales
        'HelpClass.CrystalReportTextObject(objReporteCR, "lblUsuario", MainModule.USUARIO)
        'HelpClass.CrystalReportTextObject(objReporteCR, "lblCompania", Me.cmbCompania.CCMPN_Descripcion)
        'HelpClass.CrystalReportTextObject(objReporteCR, "lblDivision", Me.cmbDivision.DivisionDescripcion)
        '    HelpClass.CrystalReportTextObject(objReporteCR, "lblPlanta", Me.cmbPlanta_inv.DescripcionPlanta)
        'HelpClass.CrystalReportTextObject(objReporteCR, "lblFecha", "Del " & Me.dtpFechaInicio.Value.ToShortDateString & " al " & Me.dtpFechaFin.Value.ToShortDateString)

        'Me.gwdDatos.DataSource = dtb
        'Me.CrystalReportViewer1.ShowPageNavigateButtons = True
        'Me.CrystalReportViewer1.DisplayToolbar = True
        '    Me.CrystalReportViewer1.ReportSource = objReporteCR


        ''MODIFICADO
        Me.gwdDatos.DataSource = Nothing  'agregado
        If VerificarSiNoEligePlanta() = True Then  'agregado
            Try
                gwdDatos.DataSource = Nothing
                'ControlVisorVehiculo.ReportViewer.ReportSource = Nothing
                CrystalReportViewer1.ReportViewer.ReportSource = Nothing
                PrepararProceesWorked()
                bgwProceso.RunWorkerAsync()
            Catch ex As Exception
                HelpClass.ErrorMsgBox()
                Me.Cursor = Cursors.Default
                ClearMemory()
            End Try
            MenuBar.Enabled = True
            Me.Cursor = Cursors.Default

        End If 'agregado


    End Sub

    'se creo esta funcion 23/03/2012
    Private Function VerificarSiNoEligePlanta() As Boolean
        Dim vretorno As Boolean = False

        Dim strCodPlanta As String = ""



        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1

            strCodPlanta += cmbPlanta.CheckedItems(i).Value

            If i < cmbPlanta.CheckedItems.Count - 1 Then
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

  'Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '    If bolBuscar = True Then
  '        Cargar_Division()
  '    End If
  'End Sub

  'Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '    If bolBuscar Then
  '        Cargar_Planta()
  '    End If
  'End Sub

  'Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) HANDLES cmbPlanta.
  '  If bolBuscar = True Then
  '    InicializarFormulario()
  '  End If
  'End Sub

  Private Sub CargarTransportista()
    txtTransportista.pClear()
    Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    'obeTracto.pCCMPN_Compania = Me.cmbCompania.SelectedValue
    obeTracto.pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania
    Me.txtTransportista.pCargar(obeTracto)
  End Sub

    Private Sub InicializarFormulario()

        'Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.ReportViewer.ReportSource = Nothing
        gwdDatos.DataSource = Nothing
        ' ControlVisorVehiculo.ReportViewer.ReportSource = Nothing
        ' CrystalReportViewer1.ReportViewer.ReportSource = Nothing
        ctlCliente.pClear()
        txtTransportista.pClear()
        'ctlCliente.CCMPN = Me.cmbCompania.SelectedValue.ToString().Trim()
        ctlCliente.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        CargarTransportista()
        Me.gwdDatos.AutoGenerateColumns = False
        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

  Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
    TabControl1.SelectedIndex = 0
    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
    'If (Me.gwdDatos.Rows.Count = 0) Then
    '  MsgBox("No existen datos a exportar.", MsgBoxStyle.Information)
    '  Exit Sub
    'End If

    Try
      If gwdDatos.Rows.Count <= 0 Then
        MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
      Dim ODs As New DataSet
      Dim objDt As New DataTable
      Dim loEncabezados As New Generic.List(Of Encabezados)

      'Envia los Parametros para la exportacion
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Reporte Rendimiento Vehicular"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Reporte Rendimiento Vehicular"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "REPORTE RENDIMIENTO VEHICULAR"))
      loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
      objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

      ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

      For Each dc As DataColumn In ODs.Tables(0).Columns
        Select Case dc.Caption
          Case "NPLCTR", "TUNDVH", "PLANTA_DESCRIPCION"
            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)

          Case "PORENT"
            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_INTEGER)


          Case "ISRVGU", "ISRVGU_A", "RENDIM", "IMPPET", "IMPAVC", "IMPGST"
            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D4)

        End Select
      Next
      HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
    Catch ex As Exception
    End Try
        

  End Sub

  Private Sub PrepararProceesWorked()
    objLista.Clear()
    MenuBar.Enabled = False
    Me.Cursor = Cursors.WaitCursor
    TabControl1.SelectedIndex = 0
    pbxProceso.Visible = True
    lblProceso.Visible = True
    lblProceso.Text = "Procesando..."
        ''''''''''''
        'objLista.Add(Me.cmbCompania.SelectedValue)
        'objLista.Add(Me.cmbDivision.SelectedValue)
        objLista.Add(cmbCompania.CCMPN_CodigoCompania)
        objLista.Add(Me.cmbDivision.Division)
        Dim strCodPlanta As String = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1
            strCodPlanta += cmbPlanta.CheckedItems(i).Value & ","
        Next
        If strCodPlanta = "" Then
            For i As Integer = 0 To cmbPlanta.Items.Count - 1
                strCodPlanta += cmbPlanta.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        objLista.Add(strCodPlanta)
        If ctlCliente.pCodigo = 0 Then
            objLista.Add(0)
        Else
            objLista.Add(Me.ctlCliente.pCodigo.ToString())
        End If
        If txtTransportista.pRucTransportista = "" Then
            objLista.Add(0)
        Else
            objLista.Add(txtTransportista.pCodigoRNS)
        End If
        objLista.Add(HelpClass.CtypeDate(Me.dtpFechaInicio.Value))
        objLista.Add(HelpClass.CtypeDate(Me.dtpFechaFin.Value))
        objLista.Add(txtPlaca.Text.Trim)

        Dim strCodRegion As String = ""
        For i As Integer = 0 To cboRegionVenta.CheckedItems.Count - 1
            ValorRegion = cboRegionVenta.CheckedItems(i).Value
            strCodRegion += objLisEntidad.FindAll(match_RegionVEnta)(0).CRGVTA & ","
        Next
        
        If strCodRegion.Trim.Length > 0 Then
            strCodRegion = strCodRegion.Trim.Substring(0, strCodRegion.Trim.Length - 1)
        End If
        objLista.Add(strCodRegion)

        'objLista.Add(cmbEstado.SelectedValue)
        'If Me.rbnFechaOperacion.Checked = True Then
        '    objLista.Add(0)
        'Else
        '    objLista.Add(1)
        'End If
        'objLista.Add(Me.cboRegionVenta.SelectedValue)
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
            Me.cmbPlanta_inv.Usuario = MainModule.USUARIO
            Me.cmbPlanta_inv.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            Me.cmbPlanta_inv.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            Me.cmbPlanta_inv.PlantaDefault = 1
            If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
                'Me.cmbPlanta_inv.pActualizar()
                Cargar_Planta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
  Private Sub Limpiar()
    InicializarFormulario()
  End Sub

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



#End Region


    Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
        Dim objLogica As New Reportes_BLL
        e.Result = objLogica.Reporte_Rendimiento_Vehicular(objLista)
    End Sub

    Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted

        dstreporte = CType(e.Result, DataTable)
        If dstreporte Is Nothing Then
            CrystalReportViewer1.ReportViewer.ReportSource = Nothing
            ' Control_Visor_ReporteGrafico.ReportViewer.ReportSource = Nothing
            Exit Sub
        End If

        'If dstreporte.TableName.Count > 0 Then
        dstreporte.TableName = "ReporteRendimientoVehicular"
        'End If
        Try
            Generar_Reporte_Rendimiento_Vehicular(dstreporte)
            'Generar_Reporte_Detalle(dstreporte)
            gwdDatos.DataSource = dstreporte
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


    Private Sub Generar_Reporte_Rendimiento_Vehicular(ByVal dstreporte As DataTable)

        Dim objReporte As ReportClass
        objReporte = New rptRendimientoVehicular



        'Dim objEntidad As New List(Of String)
        'Dim objReporte As New Reportes_BLL

        ''objEntidad.Add(Me.cmbCompania.SelectedValue)
        ''objEntidad.Add(Me.cmbDivision.SelectedValue)
        'objEntidad.Add(cmbCompania.CCMPN_CodigoCompania)
        'objEntidad.Add(Me.cmbDivision.Division)
        '    'objEntidad.Add(Me.cmbPlanta.p)
        '    objEntidad.Add(Me.cmbPlanta_inv.Planta)
        'objEntidad.Add(Me.ctlCliente.pCodigo)
        'objEntidad.Add(Me.txtTransportista.pCodigoRNS)
        'objEntidad.Add(HelpClass.CtypeDate(Me.dtpFechaInicio.Value))
        'objEntidad.Add(HelpClass.CtypeDate(Me.dtpFechaFin.Value))
        'objEntidad.Add(Me.txtPlaca.Text)

        'Dim dtb As New DataTable
        'dtb = objReporte.Reporte_Rendimiento_Vehicular(objEntidad)

        Dim objReporteCR As New rptRendimientoVehicular
        objReporteCR.SetDataSource(dstreporte)

        ''Estableciendo las variables finales
        HelpClass.CrystalReportTextObject(objReporteCR, "lblUsuario", MainModule.USUARIO)
        HelpClass.CrystalReportTextObject(objReporteCR, "lblCompania", Me.cmbCompania.CCMPN_Descripcion)
        HelpClass.CrystalReportTextObject(objReporteCR, "lblDivision", Me.cmbDivision.DivisionDescripcion)
        HelpClass.CrystalReportTextObject(objReporteCR, "lblPlanta", Me.cmbPlanta_inv.DescripcionPlanta)
        HelpClass.CrystalReportTextObject(objReporteCR, "lblFecha", "Del " & Me.dtpFechaInicio.Value.ToShortDateString & " al " & Me.dtpFechaFin.Value.ToShortDateString)

        'Me.gwdDatos.DataSource = dtb
        'CrystalReportViewer1.ShowPageNavigateButtons = True
        'CrystalReportViewer1.DisplayToolbar = True
        'CrystalReportViewer1.ReportSource = objReporteCR
        CrystalReportViewer1.ReportViewer.ReportSource = objReporteCR
    End Sub


    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        If Me.gwdDatos.Columns(e.ColumnIndex).Name = "DETALLE" Then
            Dim ObjParametro As New List(Of String)
            For Each Item As String In Me.objLista
                ObjParametro.Add(Item)
            Next
            ObjParametro(7) = Me.gwdDatos.Item("NPLCTR", e.RowIndex).Value
            Dim objOperacionVehiculo As New frmOperacionVehiculo
            With objOperacionVehiculo
                .Parametros = ObjParametro
                .WindowState = FormWindowState.Normal
                .ShowDialog(Me)
            End With
        End If
    End Sub

    Private Sub cboRegionVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
