<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptDespachoMercaderiaUnid
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptDespachoMercaderiaUnid))
        Dim BePlanta5 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim BeCompania5 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.pcxEspera = New System.Windows.Forms.PictureBox()
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.tsReporte = New System.Windows.Forms.ToolStrip()
        Me.btnExportar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnModelo1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnModelo2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.tssSeparador_002 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEnviarCorreo = New System.Windows.Forms.ToolStripButton()
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtsubItem = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtItem = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerarReporte = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPlaca = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsReporte.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1321, 764)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 151)
        Me.KryptonHeaderGroup2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.pcxEspera)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.crvReporte)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.tsReporte)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1321, 613)
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.Text = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "...Reporte..."
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(739, 244)
        Me.pcxEspera.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 62
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'crvReporte
        '
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReporte.DisplayGroupTree = False
        Me.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReporte.Location = New System.Drawing.Point(0, 31)
        Me.crvReporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.SelectionFormula = ""
        Me.crvReporte.ShowCloseButton = False
        Me.crvReporte.ShowGotoPageButton = False
        Me.crvReporte.ShowGroupTreeButton = False
        Me.crvReporte.ShowRefreshButton = False
        Me.crvReporte.ShowTextSearchButton = False
        Me.crvReporte.Size = New System.Drawing.Size(1318, 531)
        Me.crvReporte.TabIndex = 0
        Me.crvReporte.ViewTimeSelectionFormula = ""
        Me.crvReporte.Visible = False
        '
        'tsReporte
        '
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExportar, Me.tsbExportarExcel, Me.tssSeparador_002, Me.tsbEnviarCorreo})
        Me.tsReporte.Location = New System.Drawing.Point(0, 0)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(1319, 27)
        Me.tsReporte.TabIndex = 61
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnModelo1, Me.btnModelo2})
        Me.btnExportar.Enabled = False
        Me.btnExportar.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(137, 24)
        Me.btnExportar.Text = "Exportar Excel"
        '
        'btnModelo1
        '
        Me.btnModelo1.Name = "btnModelo1"
        Me.btnModelo1.Size = New System.Drawing.Size(148, 26)
        Me.btnModelo1.Text = "Modelo1"
        '
        'btnModelo2
        '
        Me.btnModelo2.Name = "btnModelo2"
        Me.btnModelo2.Size = New System.Drawing.Size(148, 26)
        Me.btnModelo2.Text = "Modelo 2"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.Enabled = False
        Me.tsbExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(126, 24)
        Me.tsbExportarExcel.Text = "Exportar Excel"
        Me.tsbExportarExcel.Visible = False
        '
        'tssSeparador_002
        '
        Me.tssSeparador_002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_002.Name = "tssSeparador_002"
        Me.tssSeparador_002.Size = New System.Drawing.Size(6, 27)
        '
        'tsbEnviarCorreo
        '
        Me.tsbEnviarCorreo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEnviarCorreo.Enabled = False
        Me.tsbEnviarCorreo.Image = Global.SOLMIN_SA.My.Resources.Resources.tsbEnviarCorreo_Image
        Me.tsbEnviarCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEnviarCorreo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEnviarCorreo.Name = "tsbEnviarCorreo"
        Me.tsbEnviarCorreo.Size = New System.Drawing.Size(145, 24)
        Me.tsbEnviarCorreo.Text = "Enviar por Correo"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.AutoScroll = True
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFechaInicial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dteFechaInicial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnGenerarReporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFechaFinal)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dteFechaFinal)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblPlanta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtPlaca)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1321, 151)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Filtro"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtro"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Filtro"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup1.UniqueName = "39A89ED5508D4DB139A89ED5508D4DB1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtsubItem)
        Me.GroupBox1.Controls.Add(Me.rbtItem)
        Me.GroupBox1.Location = New System.Drawing.Point(603, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(175, 47)
        Me.GroupBox1.TabIndex = 140
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vista de reporte"
        '
        'rbtsubItem
        '
        Me.rbtsubItem.Location = New System.Drawing.Point(76, 16)
        Me.rbtsubItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtsubItem.Name = "rbtsubItem"
        Me.rbtsubItem.Size = New System.Drawing.Size(80, 24)
        Me.rbtsubItem.TabIndex = 2
        Me.rbtsubItem.Text = "SubItem"
        Me.rbtsubItem.Values.ExtraText = ""
        Me.rbtsubItem.Values.Image = Nothing
        Me.rbtsubItem.Values.Text = "SubItem"
        '
        'rbtItem
        '
        Me.rbtItem.Checked = True
        Me.rbtItem.Location = New System.Drawing.Point(8, 16)
        Me.rbtItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtItem.Name = "rbtItem"
        Me.rbtItem.Size = New System.Drawing.Size(54, 24)
        Me.rbtItem.TabIndex = 1
        Me.rbtItem.Text = "Item"
        Me.rbtItem.Values.ExtraText = ""
        Me.rbtItem.Values.Image = Nothing
        Me.rbtItem.Values.Text = "Item"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(11, 79)
        Me.lblFechaInicial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(134, 24)
        Me.lblFechaInicial.TabIndex = 18
        Me.lblFechaInicial.Text = "Fecha Despacho  : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Despacho  : "
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(160, 79)
        Me.dteFechaInicial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(135, 22)
        Me.dteFechaInicial.TabIndex = 5
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Location = New System.Drawing.Point(1017, 49)
        Me.btnGenerarReporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(187, 47)
        Me.btnGenerarReporte.TabIndex = 7
        Me.btnGenerarReporte.Text = " &Generar Reporte "
        Me.btnGenerarReporte.Values.ExtraText = ""
        Me.btnGenerarReporte.Values.Image = CType(resources.GetObject("btnGenerarReporte.Values.Image"), System.Drawing.Image)
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGenerarReporte.Values.Text = " &Generar Reporte "
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(304, 80)
        Me.lblFechaFinal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(50, 24)
        Me.lblFechaFinal.TabIndex = 20
        Me.lblFechaFinal.Text = "Hasta"
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Hasta"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(160, 46)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(339, 26)
        Me.txtCliente.TabIndex = 3
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Checked = False
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(363, 79)
        Me.dteFechaFinal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(135, 22)
        Me.dteFechaFinal.TabIndex = 6
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(11, 48)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 24)
        Me.lblCliente.TabIndex = 139
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(899, 17)
        Me.lblPlanta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(61, 24)
        Me.lblPlanta.TabIndex = 138
        Me.lblPlanta.Text = "Planta : "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta : "
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CodSedeSAP = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(969, 12)
        Me.UcPLanta_Cmb011.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta5.CCMPN_CodigoCompania = ""
        BePlanta5.CDSPSP_CodSedeSAP = Nothing
        BePlanta5.CDVSN_CodigoDivision = ""
        BePlanta5.CPLNDV_CodigoPlanta = 0.0R
        BePlanta5.Orden = -1
        BePlanta5.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta5
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0.0R
        Me.UcPLanta_Cmb011.PlantaDefault = -1.0R
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(325, 28)
        Me.UcPLanta_Cmb011.TabIndex = 2
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(508, 17)
        Me.lblDivision.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(73, 24)
        Me.lblDivision.TabIndex = 136
        Me.lblDivision.Text = "Division : "
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "Division : "
        '
        'UcDivision_Cmb011
        '
        Me.UcDivision_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcDivision_Cmb011.CDVSN_ANTERIOR = Nothing
        Me.UcDivision_Cmb011.Compania = ""
        Me.UcDivision_Cmb011.Division = Nothing
        Me.UcDivision_Cmb011.DivisionDefault = Nothing
        Me.UcDivision_Cmb011.DivisionDescripcion = Nothing
        Me.UcDivision_Cmb011.ItemTodos = False
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(603, 12)
        Me.UcDivision_Cmb011.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(292, 28)
        Me.UcDivision_Cmb011.TabIndex = 1
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(11, 16)
        Me.lblCompania.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(88, 24)
        Me.lblCompania.TabIndex = 134
        Me.lblCompania.Text = "Compañia : "
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia : "
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(160, 12)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania5.CCMPN_CodigoCompania = ""
        BeCompania5.Orden = -1
        BeCompania5.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania5
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(339, 28)
        Me.UcCompania_Cmb011.TabIndex = 0
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(508, 48)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 24)
        Me.KryptonLabel1.TabIndex = 39
        Me.KryptonLabel1.Text = "Placa : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Placa : "
        '
        'txtPlaca
        '
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Location = New System.Drawing.Point(603, 46)
        Me.txtPlaca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(292, 26)
        Me.txtPlaca.TabIndex = 4
        '
        'bgwGifAnimado
        '
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        '
        'frmRptDespachoMercaderiaUnid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 764)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRptDespachoMercaderiaUnid"
        Me.Text = "Despacho Mercadería por Unidad"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlaca As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCliente As RANSA.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As RANSA.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Private WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As RANSA.Controls.UbicacionPlanta.ucDivision_Cmb01
    Private WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As RANSA.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents btnGenerarReporte As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEnviarCorreo As System.Windows.Forms.ToolStripButton
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtsubItem As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtItem As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnModelo1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnModelo2 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
