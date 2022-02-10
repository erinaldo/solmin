Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class frmLandedCost
    Private odtResumenxZona As New DataTable
    Private odtResumenxZonaDetalle As New DataTable
    Private Sub frmLandedCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'cboTipoOperacion.SelectedValue = "IM"
            'cboTipoOperacion.Enabled = False
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

            dtpFecIni.Value = dtpFecIni.Value.AddMonths(-1)

            CargarFiltrosDatos()

            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName

            kdgvResumenZona.AutoGenerateColumns = False
            kdgvZonaDetalle.AutoGenerateColumns = False

            Dim oclsIncoterm As New clsIncoterm
            Dim oListIcoterm As New List(Of beIncoterm)
            oListIcoterm = oclsIncoterm.Lista_Incoterm_RatioLanded()

            cboPO.DataSource = oListIcoterm
            cboPO.ValueMember = "PSCODIGO"
            cboPO.DisplayMember = "PSDESCRIPCION"
            cboPO.SelectedValue = "FOB"

            VisorRep.DisplayGroupTree = True
            VisorRep.DisplayStatusBar = True
            VisorRep.DisplayToolbar = True
            'TipoOperacion()

            TabControlResumen_SelectedIndexChanged(TabControlResumen, Nothing)

          
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub CargarFiltrosDatos()
        Dim oclsEstado As New clsEstado
        Dim dtTipoOperacion As New DataTable
        dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
        Dim dr As DataRow
        dr = dtTipoOperacion.NewRow
        dr("COD") = "T"
        dr("TEX") = "TODOS"
        dtTipoOperacion.Rows.InsertAt(dr, 0)
        cboTipoOperacion.DataSource = dtTipoOperacion
        cboTipoOperacion.DisplayMember = "TEX"
        cboTipoOperacion.ValueMember = "COD"
        cboTipoOperacion.SelectedValue = "IM"
        cboTipoOperacion.Enabled = False


        Dim dtCheckPoint As New DataTable
        dtCheckPoint.Columns.Add("VALUE")
        dtCheckPoint.Columns.Add("DISPLAY")
        Dim drCheck As DataRow
        drCheck = dtCheckPoint.NewRow
        drCheck("VALUE") = "124"
        drCheck("DISPLAY") = "FECHA ENTREGA ALMACEN"
        dtCheckPoint.Rows.Add(drCheck)

        For Each Item As DataRow In dtCheckPoint.Rows
            Item("DISPLAY") = Item("VALUE") & "-" & Item("DISPLAY")
        Next

        cboCheckPoint.DataSource = dtCheckPoint
        cboCheckPoint.ValueMember = "VALUE"
        cboCheckPoint.DisplayMember = "DISPLAY"
        cboCheckPoint.SelectedValue = "124"
        cboCheckPoint.Enabled = False

    End Sub

  Private Sub TabControlResumen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlResumen.SelectedIndexChanged
    Dim nombreTab As String = ObtenerNombreTabSeleccionado()
    Select Case nombreTab
      Case "TabResumenZona"
        btnExportar.Visible = True
      Case "TabResumenZonaDetalle"
        btnExportar.Visible = True
      Case Else
        btnExportar.Visible = False
    End Select
  End Sub
    Private Function ObtenerNombreTabSeleccionado() As String
        Dim nombreTab As String = TabControlResumen.SelectedTab.Name.Trim
        Return nombreTab
    End Function


    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub

    Private Function GetCompania() As String
        Return cmbCompania.CCMPN_CodigoCompania
    End Function
    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpClass.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function


    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
            VisorRep.ReportSource = Nothing
            kdgvResumenZona.DataSource = Nothing
            kdgvZonaDetalle.DataSource = Nothing
            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
        End If
    End Sub


  Private Sub KryptonHeaderGroup1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles KryptonHeaderGroup1.Paint

  End Sub


  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Try
      Dim nombreTab As String = ObtenerNombreTabSeleccionado()
      Dim MdataColumna As String = ""
            Dim NPOI_SC As New HelpClass_NPOI_SC
      Dim NameColumna As String = ""
      Select Case nombreTab
        Case "TabResumenZona"
          Dim dtResumenZonaExportar As New DataTable

          dtResumenZonaExportar.Columns.Add("CODIGO_ZONA")
                    MdataColumna = NPOI_SC.FormatDato("Código Zona", NPOI_SC.keyDatoTexto)
          dtResumenZonaExportar.Columns("CODIGO_ZONA").Caption = MdataColumna

          dtResumenZonaExportar.Columns.Add("ZONA")
                    MdataColumna = NPOI_SC.FormatDato("Zona", NPOI_SC.keyDatoTexto)
          dtResumenZonaExportar.Columns("ZONA").Caption = MdataColumna

          dtResumenZonaExportar.Columns.Add("COSTO")
                    MdataColumna = NPOI_SC.FormatDato("Costo", NPOI_SC.keyDatoTexto)
          dtResumenZonaExportar.Columns("COSTO").Caption = MdataColumna

          dtResumenZonaExportar.Columns.Add("QMARITIMO")
                    MdataColumna = NPOI_SC.FormatDato("MARITIMO|Monto", NPOI_SC.keyDatoNumero)
          dtResumenZonaExportar.Columns("QMARITIMO").Caption = MdataColumna

          dtResumenZonaExportar.Columns.Add("MARITIMO")
                    MdataColumna = NPOI_SC.FormatDato("MARITIMO|%", NPOI_SC.keyDatoNumero)
          dtResumenZonaExportar.Columns("MARITIMO").Caption = MdataColumna

          dtResumenZonaExportar.Columns.Add("QAEREO")
                    MdataColumna = NPOI_SC.FormatDato("AEREO|Monto", NPOI_SC.keyDatoNumero)
          dtResumenZonaExportar.Columns("QAEREO").Caption = MdataColumna

          dtResumenZonaExportar.Columns.Add("AEREO")
                    MdataColumna = NPOI_SC.FormatDato("AEREO|%", NPOI_SC.keyDatoNumero)
          dtResumenZonaExportar.Columns("AEREO").Caption = MdataColumna

          dtResumenZonaExportar.Columns.Add("QTERRESTRE")
                    MdataColumna = NPOI_SC.FormatDato("TERRESTRE|Monto", NPOI_SC.keyDatoNumero)
          dtResumenZonaExportar.Columns("QTERRESTRE").Caption = MdataColumna

          dtResumenZonaExportar.Columns.Add("TERRESTRE")
                    MdataColumna = NPOI_SC.FormatDato("TERRESTRE|%", NPOI_SC.keyDatoNumero)
          dtResumenZonaExportar.Columns("TERRESTRE").Caption = MdataColumna

          Dim dr As DataRow
          For Each drDatos As DataRow In odtResumenxZona.Rows
            dr = dtResumenZonaExportar.NewRow
            For Each dcColumna As DataColumn In dtResumenZonaExportar.Columns
              NameColumna = dcColumna.ColumnName
              dr(NameColumna) = drDatos(NameColumna)
            Next
            dtResumenZonaExportar.Rows.Add(dr)
          Next
                    'Dim oLisParametros As New SortedList
                    'oLisParametros(1) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
                    'oLisParametros(2) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
                    'oLisParametros(3) = "Hora:|" & Now.ToString("hh:mm:ss")
                    '          HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtResumenZonaExportar, "RESUMEN POR ZONA", Nothing, oLisParametros)
                    Dim ListaDatatable As New List(Of DataTable)
                    ListaDatatable.Add(dtResumenZonaExportar.Copy)

                    Dim LisFiltros As New List(Of SortedList)
                    Dim itemSortedList As SortedList

                    itemSortedList = New SortedList
                    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
                    itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
                    itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
                    LisFiltros.Add(itemSortedList)

                    Dim ListTitulo As New List(Of String)
                    ListTitulo.Add("RESUMEN POR ZONA")
                    NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)

        Case "TabResumenZonaDetalle"
          Dim dtResumenZonaDetalleExportar As New DataTable
          dtResumenZonaDetalleExportar.Columns.Add("CODIGO_ZONA")
                    MdataColumna = NPOI_SC.FormatDato("Código Zona", NPOI_SC.keyDatoTexto)
          dtResumenZonaDetalleExportar.Columns("CODIGO_ZONA").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("ZONA")
                    MdataColumna = NPOI_SC.FormatDato("Zona", NPOI_SC.keyDatoTexto)
          dtResumenZonaDetalleExportar.Columns("ZONA").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("CODIGO_PAIS")
                    MdataColumna = NPOI_SC.FormatDato("Código País", NPOI_SC.keyDatoTexto)
          dtResumenZonaDetalleExportar.Columns("CODIGO_PAIS").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("PAIS")
                    MdataColumna = NPOI_SC.FormatDato("Descripción País", NPOI_SC.keyDatoTexto)
          dtResumenZonaDetalleExportar.Columns("PAIS").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("CODIGO_PUERTO")
                    MdataColumna = NPOI_SC.FormatDato("Código Puerto", NPOI_SC.keyDatoTexto)
          dtResumenZonaDetalleExportar.Columns("CODIGO_PUERTO").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("PUERTO")
                    MdataColumna = NPOI_SC.FormatDato("Descripción Puerto", NPOI_SC.keyDatoTexto)
          dtResumenZonaDetalleExportar.Columns("PUERTO").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("COSTO")
                    MdataColumna = NPOI_SC.FormatDato("Costo", NPOI_SC.keyDatoTexto)
          dtResumenZonaDetalleExportar.Columns("COSTO").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("QMARITIMO")
                    MdataColumna = NPOI_SC.FormatDato("MARITIMO|Monto", NPOI_SC.keyDatoNumero)
          dtResumenZonaDetalleExportar.Columns("QMARITIMO").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("MARITIMO")
                    MdataColumna = NPOI_SC.FormatDato("MARITIMO|%", NPOI_SC.keyDatoNumero)
          dtResumenZonaDetalleExportar.Columns("MARITIMO").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("QAEREO")
                    MdataColumna = NPOI_SC.FormatDato("AEREO|Monto", NPOI_SC.keyDatoNumero)
          dtResumenZonaDetalleExportar.Columns("QAEREO").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("AEREO")
                    MdataColumna = NPOI_SC.FormatDato("AEREO|%", NPOI_SC.keyDatoNumero)
          dtResumenZonaDetalleExportar.Columns("AEREO").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("QTERRESTRE")
                    MdataColumna = NPOI_SC.FormatDato("TERRESTRE|Monto", NPOI_SC.keyDatoNumero)
          dtResumenZonaDetalleExportar.Columns("QTERRESTRE").Caption = MdataColumna

          dtResumenZonaDetalleExportar.Columns.Add("TERRESTRE")
                    MdataColumna = NPOI_SC.FormatDato("TERRESTRE|%", NPOI_SC.keyDatoNumero)
          dtResumenZonaDetalleExportar.Columns("TERRESTRE").Caption = MdataColumna

          Dim dr As DataRow
          For Each drDatos As DataRow In odtResumenxZonaDetalle.Rows
            dr = dtResumenZonaDetalleExportar.NewRow
            For Each dcColumna As DataColumn In dtResumenZonaDetalleExportar.Columns
              NameColumna = dcColumna.ColumnName
              dr(NameColumna) = drDatos(NameColumna)
            Next
            dtResumenZonaDetalleExportar.Rows.Add(dr)
          Next
                    'Dim oLisParametros As New SortedList
                    'oLisParametros(1) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
                    'oLisParametros(2) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
                    'oLisParametros(3) = "Hora:|" & Now.ToString("hh:mm:ss")
                    '          HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtResumenZonaDetalleExportar, "RESUMEN POR ZONA - DETALLE", Nothing, oLisParametros)

                    Dim ListaDatatable As New List(Of DataTable)
                    ListaDatatable.Add(dtResumenZonaDetalleExportar.Copy)

                    Dim LisFiltros As New List(Of SortedList)
                    Dim itemSortedList As SortedList

                    itemSortedList = New SortedList
                    itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
                    itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
                    itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
                    LisFiltros.Add(itemSortedList)

                    Dim ListTitulo As New List(Of String)
                    ListTitulo.Add("RESUMEN POR ZONA - DETALLE")
                    NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)

      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Caption", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    If (cmbCliente.pCodigo = 0) Then
      MessageBox.Show("Debe seleccionar el cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    Dim CCMPN As String = ""
    Me.Cursor = Cursors.WaitCursor
    Try
      CCMPN = GetCompania()
      odtResumenxZona.Rows.Clear()
      odtResumenxZonaDetalle.Rows.Clear()
      Dim dblFecIni, dblFecFin As Double
      dblFecIni = Format(Me.dtpFecIni.Value, "yyyyMMdd")
      dblFecFin = Format(Me.dtpFecFin.Value, "yyyyMMdd")
      Dim TipoOperacion As String = cboTipoOperacion.SelectedValue
      If TipoOperacion = "0" Then
        TipoOperacion = ""
      End If
      Dim obrLandedCost As New clsRepRatioLandedCost
      Dim orptlandedCost As New rptRatioLandCostResumen
      Dim objDtRegimen As New DataTable
      Dim lstrPeriodo As String
            Dim PSICOTERM As String = cboPO.SelectedValue
            Dim NESTDO As Decimal = cboCheckPoint.SelectedValue
      lstrPeriodo = "Entrega Almacén Desde " & Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & " al " & Format(Me.dtpFecFin.Value, "dd/MM/yyyy")
      Select Case PSICOTERM
        Case "FOB"
          obrLandedCost.pICOTERM_BASE = clsRepRatioLandedCost.ICOTERM_BASE.ICOTERM_BASE_FOB
        Case "EXW"
          obrLandedCost.pICOTERM_BASE = clsRepRatioLandedCost.ICOTERM_BASE.ICOTERM_BASE_EXW
        Case "CIF"
          obrLandedCost.pICOTERM_BASE = clsRepRatioLandedCost.ICOTERM_BASE.ICOTERM_BASE_CIF
      End Select
            obrLandedCost.dtRepListaSeguimiento(CCMPN, Me.cmbCliente.pCodigo, dblFecIni, dblFecFin, TipoOperacion, NESTDO)

      obrLandedCost.lobjDtRep.TableName = "dtRepMenSA"

      CType(orptlandedCost.ReportDefinition.ReportObjects("txtPeriodo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = lstrPeriodo
      CType(orptlandedCost.ReportDefinition.ReportObjects("txtTCMPCL"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = cmbCliente.pRazonSocial
      CType(orptlandedCost.ReportDefinition.ReportObjects("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = HelpUtil.UserName


      orptlandedCost.SetDataSource(obrLandedCost.lobjDtRep.Copy)

      odtResumenxZona = obrLandedCost.odtCuadroCostosXZona.Copy
      orptlandedCost.Subreports.Item("rptSubCuadroCostosXZona").SetDataSource(obrLandedCost.odtCuadroCostosXZona.Copy)
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZona").ReportDefinition.ReportObjects("txtICOTERM"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = PSICOTERM
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZona").ReportDefinition.ReportObjects("TXTEXW"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTEXW
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZona").ReportDefinition.ReportObjects("TXTFOB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTFOB
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZona").ReportDefinition.ReportObjects("TXTCIF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTCIF
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZona").ReportDefinition.ReportObjects("TXTINLAD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTINLAD
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZona").ReportDefinition.ReportObjects("TXTGFOB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTGFOB
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZona").ReportDefinition.ReportObjects("TXTFLETE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTFLETE
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZona").ReportDefinition.ReportObjects("TXTDUTIES"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTDUTIES
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZona").ReportDefinition.ReportObjects("TXTCOSTOSAD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTCOSTOS_ADICIONAL


      odtResumenxZonaDetalle = obrLandedCost.odtCuadroCostosXPuerto.Copy
      orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").SetDataSource(obrLandedCost.odtCuadroCostosXPuerto.Copy)
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").ReportDefinition.ReportObjects("txtICOTERM"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = PSICOTERM
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").ReportDefinition.ReportObjects("txtICOTERM"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = PSICOTERM
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").ReportDefinition.ReportObjects("TXTEXW"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTEXW
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").ReportDefinition.ReportObjects("TXTFOB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTFOB
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").ReportDefinition.ReportObjects("TXTCIF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTCIF
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").ReportDefinition.ReportObjects("TXTINLAD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTINLAD
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").ReportDefinition.ReportObjects("TXTGFOB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTGFOB
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").ReportDefinition.ReportObjects("TXTFLETE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTFLETE
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").ReportDefinition.ReportObjects("TXTDUTIES"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTDUTIES
      CType(orptlandedCost.Subreports.Item("rptSubCuadroCostosXZonaDetalle").ReportDefinition.ReportObjects("TXTCOSTOSAD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = obrLandedCost.obeTotCostosRatio.PNTOT_ITTCOSTOS_ADICIONAL

      kdgvResumenZona.DataSource = odtResumenxZona
      kdgvZonaDetalle.DataSource = odtResumenxZonaDetalle

      VisorRep.ReportSource = orptlandedCost

      Me.Cursor = Cursors.Default
    Catch ex As Exception
      Me.Cursor = Cursors.Default
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class
