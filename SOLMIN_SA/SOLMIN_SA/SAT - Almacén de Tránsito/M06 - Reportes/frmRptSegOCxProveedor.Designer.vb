<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptSegOCxProveedor
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptSegOCxProveedor))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.tsbExportarPDF = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador_001 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador_002 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEnviarCorreo = New System.Windows.Forms.ToolStripButton
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.lblSituacionOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbSituacionOC = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
        Me.cmbTermInter = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
        Me.lblTerminoInternacional = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpFechaCompProv = New System.Windows.Forms.GroupBox
        Me.lblFechaInicialComp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaCompInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinalComp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaCompFinal = New System.Windows.Forms.DateTimePicker
        Me.grpFechaRegOC = New System.Windows.Forms.GroupBox
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.txtProveedor = New Ransa.Controls.Proveedor.ucProveedor_TxtF01
        Me.lblOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnGenerarReporte = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.tsbAmpliar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
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
        Me.grpFechaCompProv.SuspendLayout()
        Me.grpFechaRegOC.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1024, 630)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 162)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.pcxEspera)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.crvReporte)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.tsReporte)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1024, 468)
        Me.KryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.Text = "Reporte"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Reporte"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "...Reporte..."
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(581, 182)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 50
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'crvReporte
        '
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crvReporte.DisplayGroupTree = False
        Me.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReporte.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.crvReporte.Location = New System.Drawing.Point(0, 39)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.SelectionFormula = ""
        Me.crvReporte.ShowCloseButton = False
        Me.crvReporte.ShowGotoPageButton = False
        Me.crvReporte.ShowGroupTreeButton = False
        Me.crvReporte.ShowRefreshButton = False
        Me.crvReporte.ShowTextSearchButton = False
        Me.crvReporte.Size = New System.Drawing.Size(1022, 407)
        Me.crvReporte.TabIndex = 0
        Me.crvReporte.TabStop = False
        Me.crvReporte.ViewTimeSelectionFormula = ""
        Me.crvReporte.Visible = False
        '
        'tsReporte
        '
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarPDF, Me.tssSeparador_001, Me.tsbExportarExcel, Me.tssSeparador_002, Me.tsbEnviarCorreo})
        Me.tsReporte.Location = New System.Drawing.Point(0, 0)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(1022, 39)
        Me.tsReporte.TabIndex = 49
        '
        'tsbExportarPDF
        '
        Me.tsbExportarPDF.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarPDF.Enabled = False
        Me.tsbExportarPDF.Image = CType(resources.GetObject("tsbExportarPDF.Image"), System.Drawing.Image)
        Me.tsbExportarPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarPDF.Name = "tsbExportarPDF"
        Me.tsbExportarPDF.Size = New System.Drawing.Size(117, 36)
        Me.tsbExportarPDF.Text = "Exportar a PDT"
        '
        'tssSeparador_001
        '
        Me.tssSeparador_001.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_001.Name = "tssSeparador_001"
        Me.tssSeparador_001.Size = New System.Drawing.Size(6, 39)
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.Enabled = False
        Me.tsbExportarExcel.Image = CType(resources.GetObject("tsbExportarExcel.Image"), System.Drawing.Image)
        Me.tsbExportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(114, 36)
        Me.tsbExportarExcel.Text = "Exportar Excel"
        '
        'tssSeparador_002
        '
        Me.tssSeparador_002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_002.Name = "tssSeparador_002"
        Me.tssSeparador_002.Size = New System.Drawing.Size(6, 39)
        '
        'tsbEnviarCorreo
        '
        Me.tsbEnviarCorreo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEnviarCorreo.Enabled = False
        Me.tsbEnviarCorreo.Image = CType(resources.GetObject("tsbEnviarCorreo.Image"), System.Drawing.Image)
        Me.tsbEnviarCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEnviarCorreo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEnviarCorreo.Name = "tsbEnviarCorreo"
        Me.tsbEnviarCorreo.Size = New System.Drawing.Size(133, 36)
        Me.tsbEnviarCorreo.Text = "Enviar por Correo"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblSituacionOC)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbSituacionOC)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbTermInter)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblTerminoInternacional)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.grpFechaCompProv)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.grpFechaRegOC)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtProveedor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblOrdenCompra)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtOrdenCompra)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblProveedor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnGenerarReporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblPlanta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1024, 162)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup1.UniqueName = "6AE04AD0C4584EA26AE04AD0C4584EA2"
        '
        'lblSituacionOC
        '
        Me.lblSituacionOC.Location = New System.Drawing.Point(15, 73)
        Me.lblSituacionOC.Name = "lblSituacionOC"
        Me.lblSituacionOC.Size = New System.Drawing.Size(46, 19)
        Me.lblSituacionOC.TabIndex = 71
        Me.lblSituacionOC.Text = "Status :"
        Me.lblSituacionOC.Values.ExtraText = ""
        Me.lblSituacionOC.Values.Image = Nothing
        Me.lblSituacionOC.Values.Text = "Status :"
        '
        'cmbSituacionOC
        '
        Me.cmbSituacionOC.BackColor = System.Drawing.Color.Transparent
        Me.cmbSituacionOC.Location = New System.Drawing.Point(79, 71)
        Me.cmbSituacionOC.Name = "cmbSituacionOC"
        Me.cmbSituacionOC.pCategoria = "SITUOC"
        Me.cmbSituacionOC.pIsRequired = False
        Me.cmbSituacionOC.Size = New System.Drawing.Size(264, 21)
        Me.cmbSituacionOC.TabIndex = 6
        '
        'cmbTermInter
        '
        Me.cmbTermInter.BackColor = System.Drawing.Color.Transparent
        Me.cmbTermInter.Location = New System.Drawing.Point(420, 69)
        Me.cmbTermInter.Name = "cmbTermInter"
        Me.cmbTermInter.pCategoria = "TERINT"
        Me.cmbTermInter.pIsRequired = False
        Me.cmbTermInter.Size = New System.Drawing.Size(239, 21)
        Me.cmbTermInter.TabIndex = 7
        '
        'lblTerminoInternacional
        '
        Me.lblTerminoInternacional.Location = New System.Drawing.Point(349, 71)
        Me.lblTerminoInternacional.Name = "lblTerminoInternacional"
        Me.lblTerminoInternacional.Size = New System.Drawing.Size(69, 19)
        Me.lblTerminoInternacional.TabIndex = 73
        Me.lblTerminoInternacional.Text = "Térm. Inter.:"
        Me.lblTerminoInternacional.Values.ExtraText = ""
        Me.lblTerminoInternacional.Values.Image = Nothing
        Me.lblTerminoInternacional.Values.Text = "Térm. Inter.:"
        '
        'grpFechaCompProv
        '
        Me.grpFechaCompProv.BackColor = System.Drawing.Color.Transparent
        Me.grpFechaCompProv.Controls.Add(Me.lblFechaInicialComp)
        Me.grpFechaCompProv.Controls.Add(Me.dteFechaCompInicial)
        Me.grpFechaCompProv.Controls.Add(Me.lblFechaFinalComp)
        Me.grpFechaCompProv.Controls.Add(Me.dteFechaCompFinal)
        Me.grpFechaCompProv.Location = New System.Drawing.Point(360, 98)
        Me.grpFechaCompProv.Name = "grpFechaCompProv"
        Me.grpFechaCompProv.Size = New System.Drawing.Size(329, 40)
        Me.grpFechaCompProv.TabIndex = 70
        Me.grpFechaCompProv.TabStop = False
        Me.grpFechaCompProv.Text = "Fecha Comprometida Entrega"
        '
        'lblFechaInicialComp
        '
        Me.lblFechaInicialComp.Location = New System.Drawing.Point(13, 19)
        Me.lblFechaInicialComp.Name = "lblFechaInicialComp"
        Me.lblFechaInicialComp.Size = New System.Drawing.Size(43, 19)
        Me.lblFechaInicialComp.TabIndex = 23
        Me.lblFechaInicialComp.Text = "Inicio : "
        Me.lblFechaInicialComp.Values.ExtraText = ""
        Me.lblFechaInicialComp.Values.Image = Nothing
        Me.lblFechaInicialComp.Values.Text = "Inicio : "
        '
        'dteFechaCompInicial
        '
        Me.dteFechaCompInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaCompInicial.Location = New System.Drawing.Point(62, 15)
        Me.dteFechaCompInicial.Name = "dteFechaCompInicial"
        Me.dteFechaCompInicial.ShowCheckBox = True
        Me.dteFechaCompInicial.Size = New System.Drawing.Size(102, 20)
        Me.dteFechaCompInicial.TabIndex = 0
        '
        'lblFechaFinalComp
        '
        Me.lblFechaFinalComp.Location = New System.Drawing.Point(174, 19)
        Me.lblFechaFinalComp.Name = "lblFechaFinalComp"
        Me.lblFechaFinalComp.Size = New System.Drawing.Size(39, 19)
        Me.lblFechaFinalComp.TabIndex = 25
        Me.lblFechaFinalComp.Text = "Final : "
        Me.lblFechaFinalComp.Values.ExtraText = ""
        Me.lblFechaFinalComp.Values.Image = Nothing
        Me.lblFechaFinalComp.Values.Text = "Final : "
        '
        'dteFechaCompFinal
        '
        Me.dteFechaCompFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaCompFinal.Location = New System.Drawing.Point(221, 15)
        Me.dteFechaCompFinal.Name = "dteFechaCompFinal"
        Me.dteFechaCompFinal.ShowCheckBox = True
        Me.dteFechaCompFinal.Size = New System.Drawing.Size(102, 20)
        Me.dteFechaCompFinal.TabIndex = 1
        '
        'grpFechaRegOC
        '
        Me.grpFechaRegOC.BackColor = System.Drawing.Color.Transparent
        Me.grpFechaRegOC.Controls.Add(Me.lblFechaInicial)
        Me.grpFechaRegOC.Controls.Add(Me.dteFechaInicial)
        Me.grpFechaRegOC.Controls.Add(Me.lblFechaFinal)
        Me.grpFechaRegOC.Controls.Add(Me.dteFechaFinal)
        Me.grpFechaRegOC.Location = New System.Drawing.Point(15, 98)
        Me.grpFechaRegOC.Name = "grpFechaRegOC"
        Me.grpFechaRegOC.Size = New System.Drawing.Size(329, 40)
        Me.grpFechaRegOC.TabIndex = 69
        Me.grpFechaRegOC.TabStop = False
        Me.grpFechaRegOC.Text = "Fecha Reg. Orden de Compra"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(13, 19)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(43, 19)
        Me.lblFechaInicial.TabIndex = 18
        Me.lblFechaInicial.Text = "Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Inicio : "
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Checked = False
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(62, 15)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.ShowCheckBox = True
        Me.dteFechaInicial.Size = New System.Drawing.Size(102, 20)
        Me.dteFechaInicial.TabIndex = 0
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(174, 19)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(39, 19)
        Me.lblFechaFinal.TabIndex = 20
        Me.lblFechaFinal.Text = "Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Final : "
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Checked = False
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(221, 15)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.ShowCheckBox = True
        Me.dteFechaFinal.Size = New System.Drawing.Size(102, 20)
        Me.dteFechaFinal.TabIndex = 1
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(79, 41)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(264, 21)
        Me.txtCliente.TabIndex = 3
        '
        'txtProveedor
        '
        Me.txtProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtProveedor.BackColor = System.Drawing.Color.Transparent
        Me.txtProveedor.Location = New System.Drawing.Point(747, 41)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.pCodigo = CType(0, Long)
        Me.txtProveedor.pMostarBtnNewProv = False
        Me.txtProveedor.pRequerido = False
        Me.txtProveedor.Size = New System.Drawing.Size(248, 21)
        Me.txtProveedor.TabIndex = 5
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Location = New System.Drawing.Point(349, 43)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(60, 19)
        Me.lblOrdenCompra.TabIndex = 65
        Me.lblOrdenCompra.Text = "Nro. O/C : "
        Me.lblOrdenCompra.Values.ExtraText = ""
        Me.lblOrdenCompra.Values.Image = Nothing
        Me.lblOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdenCompra.Location = New System.Drawing.Point(420, 41)
        Me.txtOrdenCompra.MaxLength = 100
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(239, 21)
        Me.txtOrdenCompra.TabIndex = 4
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(674, 43)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(67, 19)
        Me.lblProveedor.TabIndex = 67
        Me.lblProveedor.Text = "Proveedor : "
        Me.lblProveedor.Values.ExtraText = ""
        Me.lblProveedor.Values.Image = Nothing
        Me.lblProveedor.Values.Text = "Proveedor : "
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(11, 43)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 19)
        Me.lblCliente.TabIndex = 63
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarReporte.Location = New System.Drawing.Point(870, 73)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(125, 36)
        Me.btnGenerarReporte.TabIndex = 8
        Me.btnGenerarReporte.Text = " &Generar Reporte "
        Me.btnGenerarReporte.Values.ExtraText = ""
        Me.btnGenerarReporte.Values.Image = CType(resources.GetObject("btnGenerarReporte.Values.Image"), System.Drawing.Image)
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGenerarReporte.Values.Text = " &Generar Reporte "
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(674, 13)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(47, 19)
        Me.lblPlanta.TabIndex = 61
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
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(747, 9)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(248, 23)
        Me.UcPLanta_Cmb011.TabIndex = 2
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(349, 13)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(55, 19)
        Me.lblDivision.TabIndex = 59
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(420, 9)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(239, 23)
        Me.UcDivision_Cmb011.TabIndex = 1
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(11, 13)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(66, 19)
        Me.lblCompania.TabIndex = 57
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
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(79, 9)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(264, 23)
        Me.UcCompania_Cmb011.TabIndex = 0
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'tsbAmpliar
        '
        Me.tsbAmpliar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAmpliar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAmpliar.Image = CType(resources.GetObject("tsbAmpliar.Image"), System.Drawing.Image)
        Me.tsbAmpliar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAmpliar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAmpliar.Name = "tsbAmpliar"
        Me.tsbAmpliar.Size = New System.Drawing.Size(23, 36)
        Me.tsbAmpliar.Text = "Ampliar"
        Me.tsbAmpliar.ToolTipText = "Amplir el Área del Reporte"
        '
        'bgwGifAnimado
        '
        '
        'frmRptSegOCxProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 630)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmRptSegOCxProveedor"
        Me.Text = "Seguimiento O/C por Proveedor"
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
        Me.grpFechaCompProv.ResumeLayout(False)
        Me.grpFechaCompProv.PerformLayout()
        Me.grpFechaRegOC.ResumeLayout(False)
        Me.grpFechaRegOC.PerformLayout()
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
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Private WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Private WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents btnGenerarReporte As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarPDF As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_001 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEnviarCorreo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAmpliar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtCliente As RANSA.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents txtProveedor As RANSA.Controls.Proveedor.ucProveedor_TxtF01
    Private WithEvents lblOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpFechaCompProv As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaInicialComp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaCompInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinalComp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaCompFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpFechaRegOC As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Private WithEvents lblSituacionOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbSituacionOC As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Friend WithEvents cmbTermInter As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Private WithEvents lblTerminoInternacional As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
End Class
