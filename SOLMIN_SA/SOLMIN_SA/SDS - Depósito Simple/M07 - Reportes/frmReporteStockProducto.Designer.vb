<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteStockProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteStockProducto))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HGReporte = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripDropDownButton
        Me.Formato01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Formato02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tssSeparador_002 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador_001 = New System.Windows.Forms.ToolStripSeparator
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtCliente = New Ransa.Utilitario.ucCliente_Check
        Me.dtpFechaInv = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.HGReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGReporte.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGReporte.Panel.SuspendLayout()
        Me.HGReporte.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsReporte.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1156, 637)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.HGReporte)
        Me.KryptonPanel1.Controls.Add(Me.tsReporte)
        Me.KryptonPanel1.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1156, 637)
        Me.KryptonPanel1.TabIndex = 1
        '
        'HGReporte
        '
        Me.HGReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGReporte.HeaderVisiblePrimary = False
        Me.HGReporte.Location = New System.Drawing.Point(0, 103)
        Me.HGReporte.Name = "HGReporte"
        '
        'HGReporte.Panel
        '
        Me.HGReporte.Panel.Controls.Add(Me.pcxEspera)
        Me.HGReporte.Panel.Controls.Add(Me.crvReporte)
        Me.HGReporte.Size = New System.Drawing.Size(1156, 534)
        Me.HGReporte.TabIndex = 58
        Me.HGReporte.Text = "Heading"
        Me.HGReporte.ValuesPrimary.Description = ""
        Me.HGReporte.ValuesPrimary.Heading = "Heading"
        Me.HGReporte.ValuesPrimary.Image = CType(resources.GetObject("HGReporte.ValuesPrimary.Image"), System.Drawing.Image)
        Me.HGReporte.ValuesSecondary.Description = ""
        Me.HGReporte.ValuesSecondary.Heading = ""
        Me.HGReporte.ValuesSecondary.Image = Nothing
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(575, 163)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 56
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'crvReporte
        '
        Me.crvReporte.AccessibleDescription = "<"
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crvReporte.DisplayGroupTree = False
        Me.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReporte.Location = New System.Drawing.Point(0, 0)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.SelectionFormula = ""
        Me.crvReporte.ShowCloseButton = False
        Me.crvReporte.ShowGotoPageButton = False
        Me.crvReporte.ShowGroupTreeButton = False
        Me.crvReporte.ShowRefreshButton = False
        Me.crvReporte.ShowTextSearchButton = False
        Me.crvReporte.Size = New System.Drawing.Size(1154, 529)
        Me.crvReporte.TabIndex = 55
        Me.crvReporte.ViewTimeSelectionFormula = ""
        Me.crvReporte.Visible = False
        '
        'tsReporte
        '
        Me.tsReporte.AccessibleDescription = "<"
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarExcel, Me.tssSeparador_002, Me.tsbBuscar, Me.tssSeparador_001})
        Me.tsReporte.Location = New System.Drawing.Point(0, 78)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(1156, 25)
        Me.tsReporte.TabIndex = 57
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Formato01ToolStripMenuItem, Me.Formato02ToolStripMenuItem})
        Me.tsbExportarExcel.Enabled = False
        Me.tsbExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(108, 22)
        Me.tsbExportarExcel.Text = "Exportar Excel"
        '
        'Formato01ToolStripMenuItem
        '
        Me.Formato01ToolStripMenuItem.Name = "Formato01ToolStripMenuItem"
        Me.Formato01ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.Formato01ToolStripMenuItem.Text = "Formato 01"
        '
        'Formato02ToolStripMenuItem
        '
        Me.Formato02ToolStripMenuItem.Name = "Formato02ToolStripMenuItem"
        Me.Formato02ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.Formato02ToolStripMenuItem.Text = "Formato 02"
        '
        'tssSeparador_002
        '
        Me.tssSeparador_002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_002.Name = "tssSeparador_002"
        Me.tssSeparador_002.Size = New System.Drawing.Size(6, 25)
        '
        'tsbBuscar
        '
        Me.tsbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(118, 22)
        Me.tsbBuscar.Text = " &Generar Reporte "
        '
        'tssSeparador_001
        '
        Me.tssSeparador_001.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_001.Name = "tssSeparador_001"
        Me.tssSeparador_001.Size = New System.Drawing.Size(6, 25)
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaInv)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(1156, 78)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 56
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaOcultarFiltros
        '
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.ToolTipImage = Nothing
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'txtCliente
        '
        Me.txtCliente.DataSource = Nothing
        Me.txtCliente.DispleyMember = ""
        Me.txtCliente.ListColumnas = Nothing
        Me.txtCliente.Location = New System.Drawing.Point(78, 14)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Obligatorio = False
        Me.txtCliente.Size = New System.Drawing.Size(394, 24)
        Me.txtCliente.TabIndex = 71
        Me.txtCliente.ValueMember = ""
        '
        'dtpFechaInv
        '
        Me.dtpFechaInv.Checked = False
        Me.dtpFechaInv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInv.Location = New System.Drawing.Point(607, 16)
        Me.dtpFechaInv.Name = "dtpFechaInv"
        Me.dtpFechaInv.ShowCheckBox = True
        Me.dtpFechaInv.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaInv.TabIndex = 68
        Me.dtpFechaInv.Value = New Date(2008, 12, 18, 0, 0, 0, 0)
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(739, 25)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(10, 20)
        Me.KryptonLabel1.TabIndex = 67
        Me.KryptonLabel1.Text = "                                                    "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "                                                    "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(495, 16)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(106, 20)
        Me.lblFechaInicial.TabIndex = 67
        Me.lblFechaInicial.Text = "Fecha Inventario : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inventario : "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(18, 16)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Cliente : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente : "
        '
        'bgwGifAnimado
        '
        '
        'frmReporteStockProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 637)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmReporteStockProducto"
        Me.Text = "Stock de Productos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.HGReporte.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGReporte.Panel.ResumeLayout(False)
        Me.HGReporte.Panel.PerformLayout()
        CType(Me.HGReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGReporte.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents HGReporte As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tssSeparador_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaInv As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_001 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Formato01ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Formato02ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Utilitario.ucCliente_Check
End Class
