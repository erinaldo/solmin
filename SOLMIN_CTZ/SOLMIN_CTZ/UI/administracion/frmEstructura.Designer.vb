<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstructura
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Servicios", 6, 6)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstructura))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnExportarEstructura = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.tvwServicio = New System.Windows.Forms.TreeView
        Me.ctmServicio = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmAddServicioSel = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmAddRubroSel = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmUpdServicioSel = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmUpdRubroSel = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelServicioSel = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelRubroSel = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtgEstructura = New System.Windows.Forms.DataGridView
        Me.TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMRUB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMSER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonHeaderGroup8 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnExportarTarifa = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnGrabar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.TabServicio = New System.Windows.Forms.TabPage
        Me.txtServicio = New System.Windows.Forms.TextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbServicio = New System.Windows.Forms.ComboBox
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabRubro = New System.Windows.Forms.TabPage
        Me.txtRubro = New System.Windows.Forms.TextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dtgTarifaServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbCompania = New System.Windows.Forms.ComboBox
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbDivision = New System.Windows.Forms.ComboBox
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbEstado = New System.Windows.Forms.ComboBox
        Me.lblEstado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel5 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonPanel6 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ListView4 = New System.Windows.Forms.ListView
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonPanel7 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.ListView5 = New System.Windows.Forms.ListView
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ListView6 = New System.Windows.Forms.ListView
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonPanel8 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.KryptonPanel9 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.KryptonPanel10 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.PictureBox10 = New System.Windows.Forms.PictureBox
        Me.PictureBox11 = New System.Windows.Forms.PictureBox
        Me.PictureBox12 = New System.Windows.Forms.PictureBox
        Me.ListView7 = New System.Windows.Forms.ListView
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ListView8 = New System.Windows.Forms.ListView
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup4.Panel.SuspendLayout()
        Me.KryptonHeaderGroup4.SuspendLayout()
        Me.ctmServicio.SuspendLayout()
        CType(Me.dtgEstructura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup8.Panel.SuspendLayout()
        Me.KryptonHeaderGroup8.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabServicio.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabRubro.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgTarifaServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel7.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel8.SuspendLayout()
        CType(Me.KryptonPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel9.SuspendLayout()
        CType(Me.KryptonPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel10.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup4)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup8)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1004, 662)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup4
        '
        Me.KryptonHeaderGroup4.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup4.AutoSize = True
        Me.KryptonHeaderGroup4.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnExportarEstructura})
        Me.KryptonHeaderGroup4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup4.Location = New System.Drawing.Point(0, 66)
        Me.KryptonHeaderGroup4.Name = "KryptonHeaderGroup4"
        '
        'KryptonHeaderGroup4.Panel
        '
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.tvwServicio)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.dtgEstructura)
        Me.KryptonHeaderGroup4.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup4.Size = New System.Drawing.Size(1004, 325)
        Me.KryptonHeaderGroup4.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup4.TabIndex = 68
        Me.KryptonHeaderGroup4.Text = "Servicios"
        Me.KryptonHeaderGroup4.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup4.ValuesPrimary.Heading = "Servicios"
        Me.KryptonHeaderGroup4.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup4.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Image = Nothing
        '
        'btnExportarEstructura
        '
        Me.btnExportarEstructura.ExtraText = ""
        Me.btnExportarEstructura.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.btnExportarEstructura.Text = "Exportar"
        Me.btnExportarEstructura.ToolTipImage = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.btnExportarEstructura.UniqueName = "054D0EB343E24E9F054D0EB343E24E9F"
        '
        'tvwServicio
        '
        Me.tvwServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvwServicio.ContextMenuStrip = Me.ctmServicio
        Me.tvwServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvwServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwServicio.ImageIndex = 6
        Me.tvwServicio.ImageList = Me.ImageList1
        Me.tvwServicio.Location = New System.Drawing.Point(5, 5)
        Me.tvwServicio.Name = "tvwServicio"
        TreeNode1.ImageIndex = 6
        TreeNode1.Name = "Raiz"
        TreeNode1.SelectedImageIndex = 6
        TreeNode1.Text = "Servicios"
        Me.tvwServicio.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tvwServicio.SelectedImageIndex = 6
        Me.tvwServicio.ShowNodeToolTips = True
        Me.tvwServicio.Size = New System.Drawing.Size(992, 277)
        Me.tvwServicio.TabIndex = 8
        '
        'ctmServicio
        '
        Me.ctmServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ctmServicio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAddServicioSel, Me.tsmAddRubroSel, Me.tsmUpdServicioSel, Me.tsmUpdRubroSel, Me.tsmDelServicioSel, Me.tsmDelRubroSel})
        Me.ctmServicio.Name = "ctmOC"
        Me.ctmServicio.Size = New System.Drawing.Size(161, 136)
        '
        'tsmAddServicioSel
        '
        Me.tsmAddServicioSel.Name = "tsmAddServicioSel"
        Me.tsmAddServicioSel.Size = New System.Drawing.Size(160, 22)
        Me.tsmAddServicioSel.Text = "Agregar Servicios"
        '
        'tsmAddRubroSel
        '
        Me.tsmAddRubroSel.Name = "tsmAddRubroSel"
        Me.tsmAddRubroSel.Size = New System.Drawing.Size(160, 22)
        Me.tsmAddRubroSel.Text = "Agregar Rubros"
        '
        'tsmUpdServicioSel
        '
        Me.tsmUpdServicioSel.Name = "tsmUpdServicioSel"
        Me.tsmUpdServicioSel.Size = New System.Drawing.Size(160, 22)
        Me.tsmUpdServicioSel.Text = "Editar Servicio"
        '
        'tsmUpdRubroSel
        '
        Me.tsmUpdRubroSel.Name = "tsmUpdRubroSel"
        Me.tsmUpdRubroSel.Size = New System.Drawing.Size(160, 22)
        Me.tsmUpdRubroSel.Text = "Editar Rubro"
        '
        'tsmDelServicioSel
        '
        Me.tsmDelServicioSel.Name = "tsmDelServicioSel"
        Me.tsmDelServicioSel.Size = New System.Drawing.Size(160, 22)
        Me.tsmDelServicioSel.Text = "Quitar Servicio"
        '
        'tsmDelRubroSel
        '
        Me.tsmDelRubroSel.Name = "tsmDelRubroSel"
        Me.tsmDelRubroSel.Size = New System.Drawing.Size(160, 22)
        Me.tsmDelRubroSel.Text = "Quitar Rubro"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Vigente.ico")
        Me.ImageList1.Images.SetKeyName(1, "Vigente_Sel.ico")
        Me.ImageList1.Images.SetKeyName(2, "Anulado.ico")
        Me.ImageList1.Images.SetKeyName(3, "Anulado_Sel.ico")
        Me.ImageList1.Images.SetKeyName(4, "Cotizacion.ico")
        Me.ImageList1.Images.SetKeyName(5, "Cotizacion_Sel.ico")
        Me.ImageList1.Images.SetKeyName(6, "Parcial.ico")
        Me.ImageList1.Images.SetKeyName(7, "Vencido.ico")
        Me.ImageList1.Images.SetKeyName(8, "Vencido_Sel.ico")
        Me.ImageList1.Images.SetKeyName(9, "Grupo.ico")
        Me.ImageList1.Images.SetKeyName(10, "Grupo_Sel.ico")
        Me.ImageList1.Images.SetKeyName(11, "Servicio.ico")
        Me.ImageList1.Images.SetKeyName(12, "Servicio_Sel.ico")
        '
        'dtgEstructura
        '
        Me.dtgEstructura.AllowUserToAddRows = False
        Me.dtgEstructura.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgEstructura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgEstructura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEstructura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCMTRF, Me.NOMRUB, Me.NOMSER})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgEstructura.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgEstructura.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgEstructura.Location = New System.Drawing.Point(7, 175)
        Me.dtgEstructura.Name = "dtgEstructura"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgEstructura.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgEstructura.RowHeadersWidth = 15
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgEstructura.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgEstructura.Size = New System.Drawing.Size(996, 101)
        Me.dtgEstructura.TabIndex = 29
        Me.dtgEstructura.Visible = False
        '
        'TCMTRF
        '
        Me.TCMTRF.DataPropertyName = "TCMTRF"
        Me.TCMTRF.HeaderText = "RUBRO  DE VENTA"
        Me.TCMTRF.Name = "TCMTRF"
        '
        'NOMRUB
        '
        Me.NOMRUB.DataPropertyName = "NOMRUB"
        Me.NOMRUB.HeaderText = "RUBRO"
        Me.NOMRUB.Name = "NOMRUB"
        '
        'NOMSER
        '
        Me.NOMSER.DataPropertyName = "NOMSER"
        Me.NOMSER.HeaderText = "SERVICIO"
        Me.NOMSER.Name = "NOMSER"
        '
        'KryptonHeaderGroup8
        '
        Me.KryptonHeaderGroup8.AutoSize = True
        Me.KryptonHeaderGroup8.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnExportarTarifa, Me.btnGrabar, Me.btnCancelar, Me.ButtonSpecHeaderGroup1})
        Me.KryptonHeaderGroup8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonHeaderGroup8.Location = New System.Drawing.Point(0, 391)
        Me.KryptonHeaderGroup8.Name = "KryptonHeaderGroup8"
        '
        'KryptonHeaderGroup8.Panel
        '
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.TabControl3)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.TabControl2)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.TabControl1)
        Me.KryptonHeaderGroup8.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup8.Size = New System.Drawing.Size(1004, 271)
        Me.KryptonHeaderGroup8.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup8.TabIndex = 25
        Me.KryptonHeaderGroup8.Text = "Tarifas"
        Me.KryptonHeaderGroup8.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup8.ValuesPrimary.Heading = "Tarifas"
        Me.KryptonHeaderGroup8.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup8.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup8.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup8.ValuesSecondary.Image = Nothing
        '
        'btnExportarTarifa
        '
        Me.btnExportarTarifa.ExtraText = ""
        Me.btnExportarTarifa.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.btnExportarTarifa.Text = "Exportar"
        Me.btnExportarTarifa.ToolTipImage = Nothing
        Me.btnExportarTarifa.UniqueName = "572B5AA316BD42B6572B5AA316BD42B6"
        '
        'btnGrabar
        '
        Me.btnGrabar.ExtraText = ""
        Me.btnGrabar.Image = Global.SOLMIN_CT.My.Resources.Resources.save_all
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.ToolTipImage = Nothing
        Me.btnGrabar.UniqueName = "CF7960CD1C34494ACF7960CD1C34494A"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "0FF2B152F63845D60FF2B152F63845D6"
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecHeaderGroup1.UniqueName = "B7D8AF6EA43E42F3B7D8AF6EA43E42F3"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabServicio)
        Me.TabControl3.Location = New System.Drawing.Point(681, 5)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(314, 220)
        Me.TabControl3.TabIndex = 31
        '
        'TabServicio
        '
        Me.TabServicio.Controls.Add(Me.txtServicio)
        Me.TabServicio.Controls.Add(Me.KryptonLabel2)
        Me.TabServicio.Controls.Add(Me.KryptonLabel3)
        Me.TabServicio.Controls.Add(Me.cmbServicio)
        Me.TabServicio.Location = New System.Drawing.Point(4, 22)
        Me.TabServicio.Name = "TabServicio"
        Me.TabServicio.Padding = New System.Windows.Forms.Padding(3)
        Me.TabServicio.Size = New System.Drawing.Size(306, 194)
        Me.TabServicio.TabIndex = 0
        Me.TabServicio.Text = "Servicio"
        Me.TabServicio.UseVisualStyleBackColor = True
        '
        'txtServicio
        '
        Me.txtServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServicio.Location = New System.Drawing.Point(159, 34)
        Me.txtServicio.MaxLength = 250
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(308, 18)
        Me.txtServicio.TabIndex = 50
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(16, 36)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(134, 19)
        Me.KryptonLabel2.TabIndex = 55
        Me.KryptonLabel2.Text = "Descripción del Servicio :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Descripción del Servicio :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(16, 66)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(94, 19)
        Me.KryptonLabel3.TabIndex = 40
        Me.KryptonLabel3.Text = "Rubro de Venta :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Rubro de Venta :"
        '
        'cmbServicio
        '
        Me.cmbServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbServicio.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Location = New System.Drawing.Point(159, 60)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(308, 22)
        Me.cmbServicio.TabIndex = 54
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabRubro)
        Me.TabControl2.Location = New System.Drawing.Point(352, 5)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(296, 220)
        Me.TabControl2.TabIndex = 30
        '
        'TabRubro
        '
        Me.TabRubro.Controls.Add(Me.txtRubro)
        Me.TabRubro.Controls.Add(Me.KryptonLabel6)
        Me.TabRubro.Location = New System.Drawing.Point(4, 22)
        Me.TabRubro.Name = "TabRubro"
        Me.TabRubro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRubro.Size = New System.Drawing.Size(288, 194)
        Me.TabRubro.TabIndex = 0
        Me.TabRubro.Text = "Rubro"
        Me.TabRubro.UseVisualStyleBackColor = True
        '
        'txtRubro
        '
        Me.txtRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRubro.Location = New System.Drawing.Point(68, 36)
        Me.txtRubro.MaxLength = 250
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.Size = New System.Drawing.Size(351, 18)
        Me.txtRubro.TabIndex = 50
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(17, 38)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(46, 19)
        Me.KryptonLabel6.TabIndex = 40
        Me.KryptonLabel6.Text = "Rubro :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Rubro :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(5, 5)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(321, 220)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtgTarifaServicio)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(313, 194)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tarifas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtgTarifaServicio
        '
        Me.dtgTarifaServicio.AllowUserToAddRows = False
        Me.dtgTarifaServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTarifaServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgTarifaServicio.Location = New System.Drawing.Point(0, 0)
        Me.dtgTarifaServicio.Name = "dtgTarifaServicio"
        Me.dtgTarifaServicio.Size = New System.Drawing.Size(313, 194)
        Me.dtgTarifaServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgTarifaServicio.TabIndex = 29
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup3})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbEstado)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblEstado)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1004, 66)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 23
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup3
        '
        Me.ButtonSpecHeaderGroup3.ExtraText = ""
        Me.ButtonSpecHeaderGroup3.Image = Nothing
        Me.ButtonSpecHeaderGroup3.Text = ""
        Me.ButtonSpecHeaderGroup3.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecHeaderGroup3.UniqueName = "B7D8AF6EA43E42F3B7D8AF6EA43E42F3"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompania.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbCompania.FormattingEnabled = True
        Me.cmbCompania.Location = New System.Drawing.Point(98, 8)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(305, 22)
        Me.cmbCompania.TabIndex = 1
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(32, 14)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(66, 19)
        Me.lblCompania.TabIndex = 34
        Me.lblCompania.Text = "Compañia :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia :"
        '
        'cmbDivision
        '
        Me.cmbDivision.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDivision.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(507, 8)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(197, 22)
        Me.cmbDivision.TabIndex = 2
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(441, 14)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(55, 19)
        Me.lblDivision.TabIndex = 26
        Me.lblDivision.Text = "División :"
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "División :"
        '
        'cmbEstado
        '
        Me.cmbEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(811, 8)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(142, 22)
        Me.cmbEstado.TabIndex = 4
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(753, 14)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(49, 19)
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.Text = "Estado :"
        Me.lblEstado.Values.ExtraText = ""
        Me.lblEstado.Values.Image = Nothing
        Me.lblEstado.Values.Text = "Estado :"
        '
        'KryptonPanel5
        '
        Me.KryptonPanel5.AutoScroll = True
        Me.KryptonPanel5.Controls.Add(Me.PictureBox1)
        Me.KryptonPanel5.Controls.Add(Me.PictureBox2)
        Me.KryptonPanel5.Controls.Add(Me.PictureBox3)
        Me.KryptonPanel5.Controls.Add(Me.ListView1)
        Me.KryptonPanel5.Controls.Add(Me.ListView2)
        Me.KryptonPanel5.Controls.Add(Me.TextBox1)
        Me.KryptonPanel5.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel5.Location = New System.Drawing.Point(0, -196)
        Me.KryptonPanel5.Name = "KryptonPanel5"
        Me.KryptonPanel5.Size = New System.Drawing.Size(148, 302)
        Me.KryptonPanel5.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(239, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(232, 212)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(232, 84)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 54
        Me.PictureBox3.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(5, 161)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(218, 134)
        Me.ListView1.TabIndex = 52
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Código"
        Me.ColumnHeader9.Width = 50
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Rubros Seleccionados"
        Me.ColumnHeader10.Width = 140
        '
        'ListView2
        '
        Me.ListView2.CheckBoxes = True
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.Location = New System.Drawing.Point(5, 36)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(218, 123)
        Me.ListView2.TabIndex = 53
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Código"
        Me.ColumnHeader11.Width = 50
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Rubro"
        Me.ColumnHeader12.Width = 140
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(92, 12)
        Me.TextBox1.MaxLength = 250
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 18)
        Me.TextBox1.TabIndex = 51
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(4, 14)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(82, 19)
        Me.KryptonLabel4.TabIndex = 40
        Me.KryptonLabel4.Text = "Buscar Rubro :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Buscar Rubro :"
        '
        'KryptonPanel6
        '
        Me.KryptonPanel6.AutoScroll = True
        Me.KryptonPanel6.Controls.Add(Me.PictureBox4)
        Me.KryptonPanel6.Controls.Add(Me.PictureBox5)
        Me.KryptonPanel6.Controls.Add(Me.PictureBox6)
        Me.KryptonPanel6.Controls.Add(Me.ListView3)
        Me.KryptonPanel6.Controls.Add(Me.ListView4)
        Me.KryptonPanel6.Controls.Add(Me.TextBox2)
        Me.KryptonPanel6.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel6.Location = New System.Drawing.Point(0, -196)
        Me.KryptonPanel6.Name = "KryptonPanel6"
        Me.KryptonPanel6.Size = New System.Drawing.Size(148, 302)
        Me.KryptonPanel6.TabIndex = 33
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Location = New System.Drawing.Point(239, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 56
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Location = New System.Drawing.Point(232, 212)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 43)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 55
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Location = New System.Drawing.Point(232, 84)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(31, 43)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 54
        Me.PictureBox6.TabStop = False
        '
        'ListView3
        '
        Me.ListView3.CheckBoxes = True
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14})
        Me.ListView3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.Location = New System.Drawing.Point(5, 161)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(218, 134)
        Me.ListView3.TabIndex = 52
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Código"
        Me.ColumnHeader13.Width = 50
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Rubros Seleccionados"
        Me.ColumnHeader14.Width = 140
        '
        'ListView4
        '
        Me.ListView4.CheckBoxes = True
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16})
        Me.ListView4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView4.FullRowSelect = True
        Me.ListView4.Location = New System.Drawing.Point(5, 36)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(218, 123)
        Me.ListView4.TabIndex = 53
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Código"
        Me.ColumnHeader15.Width = 50
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Rubro"
        Me.ColumnHeader16.Width = 140
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(92, 12)
        Me.TextBox2.MaxLength = 250
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 18)
        Me.TextBox2.TabIndex = 51
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(4, 14)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(82, 19)
        Me.KryptonLabel5.TabIndex = 40
        Me.KryptonLabel5.Text = "Buscar Rubro :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Buscar Rubro :"
        '
        'KryptonPanel7
        '
        Me.KryptonPanel7.AutoScroll = True
        Me.KryptonPanel7.Controls.Add(Me.PictureBox7)
        Me.KryptonPanel7.Controls.Add(Me.PictureBox8)
        Me.KryptonPanel7.Controls.Add(Me.PictureBox9)
        Me.KryptonPanel7.Controls.Add(Me.ListView5)
        Me.KryptonPanel7.Controls.Add(Me.ListView6)
        Me.KryptonPanel7.Controls.Add(Me.TextBox3)
        Me.KryptonPanel7.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel7.Location = New System.Drawing.Point(0, -196)
        Me.KryptonPanel7.Name = "KryptonPanel7"
        Me.KryptonPanel7.Size = New System.Drawing.Size(148, 302)
        Me.KryptonPanel7.TabIndex = 33
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Location = New System.Drawing.Point(239, 6)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 56
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Location = New System.Drawing.Point(232, 212)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(31, 43)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 55
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.Location = New System.Drawing.Point(232, 84)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(31, 43)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 54
        Me.PictureBox9.TabStop = False
        '
        'ListView5
        '
        Me.ListView5.CheckBoxes = True
        Me.ListView5.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader18})
        Me.ListView5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView5.FullRowSelect = True
        Me.ListView5.Location = New System.Drawing.Point(5, 161)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(218, 134)
        Me.ListView5.TabIndex = 52
        Me.ListView5.UseCompatibleStateImageBehavior = False
        Me.ListView5.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Código"
        Me.ColumnHeader17.Width = 50
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Rubros Seleccionados"
        Me.ColumnHeader18.Width = 140
        '
        'ListView6
        '
        Me.ListView6.CheckBoxes = True
        Me.ListView6.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader20})
        Me.ListView6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView6.FullRowSelect = True
        Me.ListView6.Location = New System.Drawing.Point(5, 36)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(218, 123)
        Me.ListView6.TabIndex = 53
        Me.ListView6.UseCompatibleStateImageBehavior = False
        Me.ListView6.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Código"
        Me.ColumnHeader19.Width = 50
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Rubro"
        Me.ColumnHeader20.Width = 140
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(92, 12)
        Me.TextBox3.MaxLength = 250
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(141, 18)
        Me.TextBox3.TabIndex = 51
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(4, 14)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(82, 19)
        Me.KryptonLabel8.TabIndex = 40
        Me.KryptonLabel8.Text = "Buscar Rubro :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Buscar Rubro :"
        '
        'KryptonPanel8
        '
        Me.KryptonPanel8.AutoScroll = True
        Me.KryptonPanel8.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel8.Controls.Add(Me.TextBox4)
        Me.KryptonPanel8.Controls.Add(Me.Button1)
        Me.KryptonPanel8.Controls.Add(Me.Button2)
        Me.KryptonPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel8.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel8.Name = "KryptonPanel8"
        Me.KryptonPanel8.Size = New System.Drawing.Size(362, 74)
        Me.KryptonPanel8.TabIndex = 33
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(11, 16)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(46, 19)
        Me.KryptonLabel9.TabIndex = 40
        Me.KryptonLabel9.Text = "Rubro :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Rubro :"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(58, 14)
        Me.TextBox4.MaxLength = 250
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(285, 18)
        Me.TextBox4.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(77, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 22)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Grabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(199, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 22)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'KryptonPanel9
        '
        Me.KryptonPanel9.AutoScroll = True
        Me.KryptonPanel9.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel9.Controls.Add(Me.TextBox5)
        Me.KryptonPanel9.Controls.Add(Me.Button3)
        Me.KryptonPanel9.Controls.Add(Me.Button4)
        Me.KryptonPanel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel9.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel9.Name = "KryptonPanel9"
        Me.KryptonPanel9.Size = New System.Drawing.Size(362, 74)
        Me.KryptonPanel9.TabIndex = 33
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(11, 16)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(46, 19)
        Me.KryptonLabel10.TabIndex = 40
        Me.KryptonLabel10.Text = "Rubro :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Rubro :"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(58, 14)
        Me.TextBox5.MaxLength = 250
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(285, 18)
        Me.TextBox5.TabIndex = 50
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(77, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 22)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "Grabar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(199, 38)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 22)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'KryptonPanel10
        '
        Me.KryptonPanel10.AutoScroll = True
        Me.KryptonPanel10.Controls.Add(Me.PictureBox10)
        Me.KryptonPanel10.Controls.Add(Me.PictureBox11)
        Me.KryptonPanel10.Controls.Add(Me.PictureBox12)
        Me.KryptonPanel10.Controls.Add(Me.ListView7)
        Me.KryptonPanel10.Controls.Add(Me.ListView8)
        Me.KryptonPanel10.Controls.Add(Me.TextBox6)
        Me.KryptonPanel10.Controls.Add(Me.KryptonLabel11)
        Me.KryptonPanel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel10.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel10.Name = "KryptonPanel10"
        Me.KryptonPanel10.Size = New System.Drawing.Size(362, 302)
        Me.KryptonPanel10.TabIndex = 33
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Location = New System.Drawing.Point(239, 6)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 56
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Location = New System.Drawing.Point(232, 212)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(31, 43)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 55
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox12.Location = New System.Drawing.Point(232, 84)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(31, 43)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 54
        Me.PictureBox12.TabStop = False
        '
        'ListView7
        '
        Me.ListView7.CheckBoxes = True
        Me.ListView7.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader21, Me.ColumnHeader22})
        Me.ListView7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView7.FullRowSelect = True
        Me.ListView7.Location = New System.Drawing.Point(5, 161)
        Me.ListView7.Name = "ListView7"
        Me.ListView7.Size = New System.Drawing.Size(218, 134)
        Me.ListView7.TabIndex = 52
        Me.ListView7.UseCompatibleStateImageBehavior = False
        Me.ListView7.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Código"
        Me.ColumnHeader21.Width = 50
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Rubros Seleccionados"
        Me.ColumnHeader22.Width = 140
        '
        'ListView8
        '
        Me.ListView8.CheckBoxes = True
        Me.ListView8.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader23, Me.ColumnHeader24})
        Me.ListView8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView8.FullRowSelect = True
        Me.ListView8.Location = New System.Drawing.Point(5, 36)
        Me.ListView8.Name = "ListView8"
        Me.ListView8.Size = New System.Drawing.Size(218, 123)
        Me.ListView8.TabIndex = 53
        Me.ListView8.UseCompatibleStateImageBehavior = False
        Me.ListView8.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Código"
        Me.ColumnHeader23.Width = 50
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Rubro"
        Me.ColumnHeader24.Width = 140
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(92, 12)
        Me.TextBox6.MaxLength = 250
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(141, 18)
        Me.TextBox6.TabIndex = 51
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(4, 14)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(82, 19)
        Me.KryptonLabel11.TabIndex = 40
        Me.KryptonLabel11.Text = "Buscar Rubro :"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Buscar Rubro :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TCMTRF"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RUBRO  DE VENTA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMRUB"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RUBRO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NOMSER"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SERVICIO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmEstructura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 662)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmEstructura"
        Me.Text = "Arbol de Servicios"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.ResumeLayout(False)
        Me.ctmServicio.ResumeLayout(False)
        CType(Me.dtgEstructura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup8.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup8.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabServicio.ResumeLayout(False)
        Me.TabServicio.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabRubro.ResumeLayout(False)
        Me.TabRubro.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtgTarifaServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel5.ResumeLayout(False)
        Me.KryptonPanel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel6.ResumeLayout(False)
        Me.KryptonPanel6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel7.ResumeLayout(False)
        Me.KryptonPanel7.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel8.ResumeLayout(False)
        Me.KryptonPanel8.PerformLayout()
        CType(Me.KryptonPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel9.ResumeLayout(False)
        Me.KryptonPanel9.PerformLayout()
        CType(Me.KryptonPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel10.ResumeLayout(False)
        Me.KryptonPanel10.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup3 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cmbCompania As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbDivision As System.Windows.Forms.ComboBox
    Friend WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ctmServicio As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmAddServicioSel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAddRubroSel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelServicioSel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelRubroSel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonPanel5 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel6 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel7 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents ListView5 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView6 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel8 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents KryptonPanel9 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents tsmUpdRubroSel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmUpdServicioSel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonPanel10 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents ListView7 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView8 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup8 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonHeaderGroup4 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents tvwServicio As System.Windows.Forms.TreeView
    Friend WithEvents txtServicio As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbServicio As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRubro As System.Windows.Forms.TextBox
    Friend WithEvents btnExportarEstructura As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnExportarTarifa As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgEstructura As System.Windows.Forms.DataGridView
    Friend WithEvents TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMRUB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMSER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnGrabar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabServicio As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabRubro As System.Windows.Forms.TabPage
    Friend WithEvents dtgTarifaServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
