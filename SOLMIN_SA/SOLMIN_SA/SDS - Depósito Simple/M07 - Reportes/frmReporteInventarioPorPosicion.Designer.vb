<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteInventarioPorPosicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteInventarioPorPosicion))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel3 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel4 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HGReporte = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExcel = New System.Windows.Forms.ToolStripSplitButton
        Me.Formato01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Formato02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tssSeparador_002 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGenerarReporte = New System.Windows.Forms.ToolStripButton
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtubicacion = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Utilitario.ucCliente_Check
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel3.SuspendLayout()
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel4.SuspendLayout()
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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(784, 662)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(784, 662)
        Me.KryptonPanel1.TabIndex = 1
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.KryptonPanel3)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(784, 662)
        Me.KryptonPanel2.TabIndex = 1
        '
        'KryptonPanel3
        '
        Me.KryptonPanel3.Controls.Add(Me.KryptonPanel4)
        Me.KryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel3.Name = "KryptonPanel3"
        Me.KryptonPanel3.Size = New System.Drawing.Size(784, 662)
        Me.KryptonPanel3.TabIndex = 1
        '
        'KryptonPanel4
        '
        Me.KryptonPanel4.Controls.Add(Me.HGReporte)
        Me.KryptonPanel4.Controls.Add(Me.tsReporte)
        Me.KryptonPanel4.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel4.Name = "KryptonPanel4"
        Me.KryptonPanel4.Size = New System.Drawing.Size(784, 662)
        Me.KryptonPanel4.TabIndex = 1
        '
        'HGReporte
        '
        Me.HGReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGReporte.HeaderVisiblePrimary = False
        Me.HGReporte.Location = New System.Drawing.Point(0, 170)
        Me.HGReporte.Name = "HGReporte"
        '
        'HGReporte.Panel
        '
        Me.HGReporte.Panel.Controls.Add(Me.pcxEspera)
        Me.HGReporte.Panel.Controls.Add(Me.crvReporte)
        Me.HGReporte.Size = New System.Drawing.Size(784, 492)
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
        Me.crvReporte.Size = New System.Drawing.Size(782, 487)
        Me.crvReporte.TabIndex = 55
        Me.crvReporte.ViewTimeSelectionFormula = ""
        Me.crvReporte.Visible = False
        '
        'tsReporte
        '
        Me.tsReporte.AccessibleDescription = "<"
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbExcel, Me.tssSeparador_002, Me.tsbGenerarReporte})
        Me.tsReporte.Location = New System.Drawing.Point(0, 145)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(784, 25)
        Me.tsReporte.TabIndex = 57
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbExcel
        '
        Me.tsbExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExcel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Formato01ToolStripMenuItem, Me.Formato02ToolStripMenuItem})
        Me.tsbExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExcel.Name = "tsbExcel"
        Me.tsbExcel.Size = New System.Drawing.Size(85, 22)
        Me.tsbExcel.Text = "Exportar "
        Me.tsbExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Formato01ToolStripMenuItem
        '
        Me.Formato01ToolStripMenuItem.Name = "Formato01ToolStripMenuItem"
        Me.Formato01ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Formato01ToolStripMenuItem.Text = "Formato 01"
        '
        'Formato02ToolStripMenuItem
        '
        Me.Formato02ToolStripMenuItem.Name = "Formato02ToolStripMenuItem"
        Me.Formato02ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Formato02ToolStripMenuItem.Text = "Formato 02"
        '
        'tssSeparador_002
        '
        Me.tssSeparador_002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_002.Name = "tssSeparador_002"
        Me.tssSeparador_002.Size = New System.Drawing.Size(6, 25)
        '
        'tsbGenerarReporte
        '
        Me.tsbGenerarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGenerarReporte.Image = Global.SOLMIN_SA.My.Resources.Resources.GenerarReporte
        Me.tsbGenerarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarReporte.Name = "tsbGenerarReporte"
        Me.tsbGenerarReporte.Size = New System.Drawing.Size(112, 22)
        Me.tsbGenerarReporte.Text = "Generar Reporte"
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.GroupBox1)
        Me.khgFiltros.Panel.Controls.Add(Me.txtTipoAlmacen)
        Me.khgFiltros.Panel.Controls.Add(Me.txtAlmacen)
        Me.khgFiltros.Panel.Controls.Add(Me.lblAlmacen)
        Me.khgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(784, 145)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtMercaderia)
        Me.GroupBox1.Controls.Add(Me.rbtubicacion)
        Me.GroupBox1.Location = New System.Drawing.Point(91, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 38)
        Me.GroupBox1.TabIndex = 141
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vista de reporte"
        '
        'rbtMercaderia
        '
        Me.rbtMercaderia.Location = New System.Drawing.Point(97, 13)
        Me.rbtMercaderia.Name = "rbtMercaderia"
        Me.rbtMercaderia.Size = New System.Drawing.Size(84, 20)
        Me.rbtMercaderia.TabIndex = 2
        Me.rbtMercaderia.Text = "Mercadería"
        Me.rbtMercaderia.Values.ExtraText = ""
        Me.rbtMercaderia.Values.Image = Nothing
        Me.rbtMercaderia.Values.Text = "Mercadería"
        '
        'rbtubicacion
        '
        Me.rbtubicacion.Checked = True
        Me.rbtubicacion.Location = New System.Drawing.Point(6, 13)
        Me.rbtubicacion.Name = "rbtubicacion"
        Me.rbtubicacion.Size = New System.Drawing.Size(76, 20)
        Me.rbtubicacion.TabIndex = 1
        Me.rbtubicacion.Text = "Ubicación"
        Me.rbtubicacion.Values.ExtraText = ""
        Me.rbtubicacion.Values.Image = Nothing
        Me.rbtubicacion.Values.Text = "Ubicación"
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(442, 13)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = False
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(270, 27)
        Me.txtTipoAlmacen.TabIndex = 98
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(92, 39)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = False
        Me.txtAlmacen.Size = New System.Drawing.Size(275, 28)
        Me.txtAlmacen.TabIndex = 99
        Me.txtAlmacen.ValueMember = ""
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(11, 40)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(64, 20)
        Me.lblAlmacen.TabIndex = 102
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(395, 14)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(41, 20)
        Me.lblTipoAlmacen.TabIndex = 101
        Me.lblTipoAlmacen.Text = "Tipo : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo : "
        '
        'txtCliente
        '
        Me.txtCliente.DataSource = Nothing
        Me.txtCliente.DispleyMember = ""
        Me.txtCliente.ListColumnas = Nothing
        Me.txtCliente.Location = New System.Drawing.Point(92, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Obligatorio = True
        Me.txtCliente.Size = New System.Drawing.Size(275, 24)
        Me.txtCliente.TabIndex = 0
        Me.txtCliente.ValueMember = ""
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(21, 17)
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
        'frmReporteInventarioPorPosicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 662)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmReporteInventarioPorPosicion"
        Me.Text = "Stock Por Posición"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel3.ResumeLayout(False)
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel4.ResumeLayout(False)
        Me.KryptonPanel4.PerformLayout()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel3 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel4 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents HGReporte As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tssSeparador_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsbGenerarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtCliente As Ransa.Utilitario.ucCliente_Check
    Friend WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtMercaderia As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtubicacion As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents tsbExcel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents Formato01ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Formato02ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
