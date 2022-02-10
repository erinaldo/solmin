<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarCheckpoint
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carga Internacional", 2, 0)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Aduanero", 2, 0)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CheckPoints", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarCheckpoint))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel4 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgCheckpoint = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CHK_COLUMNA = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IMSESTRG = New System.Windows.Forms.DataGridViewImageColumn
        Me.KryptonHeaderGroup8 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtgExportarExcel = New System.Windows.Forms.DataGridView
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnExportar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnNuevo = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnGrabar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chbEstadoCheckpoint = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cmbCheckpoint = New System.Windows.Forms.ComboBox
        Me.cmbTipoCheckpoint = New System.Windows.Forms.ComboBox
        Me.chbEstadoSeguimiento = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtNomSeguimiento = New System.Windows.Forms.TextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.KryptonPanel3 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.tvwCheckPoint = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.cmbTipoCheck = New System.Windows.Forms.ComboBox
        Me.lblTipoCheck = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnCheck = New System.Windows.Forms.ToolStripButton
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.tsbExportar = New System.Windows.Forms.ToolStripButton
        Me.tsbGuardarOrdenCheck = New System.Windows.Forms.ToolStripButton
        Me.tsbEliminarCheck = New System.Windows.Forms.ToolStripButton
        Me.tsbModificarCheck = New System.Windows.Forms.ToolStripButton
        Me.tsbAgregarCheck = New System.Windows.Forms.ToolStripButton
        Me.btnCopiarPerfil = New System.Windows.Forms.ToolStripButton
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEMB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHECPOINT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCOLUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPRESENTACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel4.SuspendLayout()
        CType(Me.dtgCheckpoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup8.Panel.SuspendLayout()
        Me.KryptonHeaderGroup8.SuspendLayout()
        CType(Me.dtgExportarExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel4)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1035, 464)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel4
        '
        Me.KryptonPanel4.Controls.Add(Me.dtgCheckpoint)
        Me.KryptonPanel4.Controls.Add(Me.KryptonHeaderGroup8)
        Me.KryptonPanel4.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel4.Location = New System.Drawing.Point(0, 116)
        Me.KryptonPanel4.Name = "KryptonPanel4"
        Me.KryptonPanel4.Size = New System.Drawing.Size(1035, 348)
        Me.KryptonPanel4.TabIndex = 36
        '
        'dtgCheckpoint
        '
        Me.dtgCheckpoint.AllowUserToAddRows = False
        Me.dtgCheckpoint.AllowUserToDeleteRows = False
        Me.dtgCheckpoint.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK_COLUMNA, Me.CODIGO, Me.CEMB, Me.TIPO, Me.CHECPOINT, Me.SESTRG, Me.TCOLUM, Me.SESTRG2, Me.NPRESENTACION, Me.IMSESTRG, Me.CCMPN, Me.CDVSN, Me.CCLNT})
        Me.dtgCheckpoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgCheckpoint.Location = New System.Drawing.Point(0, 0)
        Me.dtgCheckpoint.Name = "dtgCheckpoint"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgCheckpoint.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgCheckpoint.Size = New System.Drawing.Size(1035, 348)
        Me.dtgCheckpoint.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgCheckpoint.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgCheckpoint.TabIndex = 37
        '
        'CHK_COLUMNA
        '
        Me.CHK_COLUMNA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CHK_COLUMNA.HeaderText = "Check"
        Me.CHK_COLUMNA.Name = "CHK_COLUMNA"
        Me.CHK_COLUMNA.Width = 50
        '
        'IMSESTRG
        '
        Me.IMSESTRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMSESTRG.HeaderText = "Mostrar en el Seguimiento"
        Me.IMSESTRG.Name = "IMSESTRG"
        Me.IMSESTRG.ReadOnly = True
        Me.IMSESTRG.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IMSESTRG.Width = 156
        '
        'KryptonHeaderGroup8
        '
        Me.KryptonHeaderGroup8.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup8.Location = New System.Drawing.Point(22, 781)
        Me.KryptonHeaderGroup8.Name = "KryptonHeaderGroup8"
        '
        'KryptonHeaderGroup8.Panel
        '
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.dtgExportarExcel)
        Me.KryptonHeaderGroup8.Size = New System.Drawing.Size(10, 96)
        Me.KryptonHeaderGroup8.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup8.TabIndex = 33
        Me.KryptonHeaderGroup8.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup8.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup8.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup8.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup8.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup8.ValuesSecondary.Image = Nothing
        '
        'dtgExportarExcel
        '
        Me.dtgExportarExcel.AllowUserToAddRows = False
        Me.dtgExportarExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgExportarExcel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgExportarExcel.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgExportarExcel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgExportarExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgExportarExcel.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgExportarExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgExportarExcel.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgExportarExcel.Location = New System.Drawing.Point(0, 0)
        Me.dtgExportarExcel.MultiSelect = False
        Me.dtgExportarExcel.Name = "dtgExportarExcel"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgExportarExcel.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgExportarExcel.RowHeadersWidth = 20
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgExportarExcel.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgExportarExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgExportarExcel.Size = New System.Drawing.Size(8, 88)
        Me.dtgExportarExcel.TabIndex = 36
        Me.dtgExportarExcel.Visible = False
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnExportar, Me.btnNuevo, Me.btnGrabar})
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(41, 781)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(10, 95)
        Me.KryptonHeaderGroup2.StateDisabled.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 31
        Me.KryptonHeaderGroup2.Text = "Información del Checkpoint"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Información del Checkpoint"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        Me.KryptonHeaderGroup2.Visible = False
        '
        'btnExportar
        '
        Me.btnExportar.ExtraText = ""
        Me.btnExportar.Image = Nothing
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.ToolTipImage = Nothing
        Me.btnExportar.UniqueName = "1F41AC02C7A642D91F41AC02C7A642D9"
        '
        'btnNuevo
        '
        Me.btnNuevo.ExtraText = ""
        Me.btnNuevo.Image = Nothing
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.ToolTipBody = "Nuevo"
        Me.btnNuevo.ToolTipImage = Nothing
        Me.btnNuevo.UniqueName = "A22AD620869D4D47A22AD620869D4D47"
        '
        'btnGrabar
        '
        Me.btnGrabar.ExtraText = ""
        Me.btnGrabar.Image = Nothing
        Me.btnGrabar.Text = "Guardar"
        Me.btnGrabar.ToolTipBody = "Guardar"
        Me.btnGrabar.ToolTipImage = Nothing
        Me.btnGrabar.UniqueName = "E9BD51C926404F6DE9BD51C926404F6D"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.TabControl1)
        Me.KryptonPanel1.Location = New System.Drawing.Point(11, 3)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1100, 41)
        Me.KryptonPanel1.TabIndex = 0
        Me.KryptonPanel1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1100, 41)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.KryptonPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1092, 15)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Información del Checkpoint"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.GroupBox3)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel2.Location = New System.Drawing.Point(3, 3)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(1086, 9)
        Me.KryptonPanel2.TabIndex = 90
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chbEstadoCheckpoint)
        Me.GroupBox3.Controls.Add(Me.cmbCheckpoint)
        Me.GroupBox3.Controls.Add(Me.cmbTipoCheckpoint)
        Me.GroupBox3.Controls.Add(Me.chbEstadoSeguimiento)
        Me.GroupBox3.Controls.Add(Me.txtNomSeguimiento)
        Me.GroupBox3.Controls.Add(Me.KryptonLabel3)
        Me.GroupBox3.Controls.Add(Me.KryptonLabel10)
        Me.GroupBox3.Controls.Add(Me.KryptonLabel11)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox3.Location = New System.Drawing.Point(14, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(957, 165)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Checkpoint"
        '
        'chbEstadoCheckpoint
        '
        Me.chbEstadoCheckpoint.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chbEstadoCheckpoint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbEstadoCheckpoint.Location = New System.Drawing.Point(219, 101)
        Me.chbEstadoCheckpoint.Name = "chbEstadoCheckpoint"
        Me.chbEstadoCheckpoint.Size = New System.Drawing.Size(210, 20)
        Me.chbEstadoCheckpoint.TabIndex = 95
        Me.chbEstadoCheckpoint.Text = "Checkpoint Activo para el Cliente : "
        Me.chbEstadoCheckpoint.Values.ExtraText = ""
        Me.chbEstadoCheckpoint.Values.Image = Nothing
        Me.chbEstadoCheckpoint.Values.Text = "Checkpoint Activo para el Cliente : "
        '
        'cmbCheckpoint
        '
        Me.cmbCheckpoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCheckpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCheckpoint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCheckpoint.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbCheckpoint.FormattingEnabled = True
        Me.cmbCheckpoint.Location = New System.Drawing.Point(165, 49)
        Me.cmbCheckpoint.Name = "cmbCheckpoint"
        Me.cmbCheckpoint.Size = New System.Drawing.Size(446, 22)
        Me.cmbCheckpoint.TabIndex = 92
        '
        'cmbTipoCheckpoint
        '
        Me.cmbTipoCheckpoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTipoCheckpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCheckpoint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCheckpoint.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbTipoCheckpoint.FormattingEnabled = True
        Me.cmbTipoCheckpoint.Location = New System.Drawing.Point(165, 21)
        Me.cmbTipoCheckpoint.Name = "cmbTipoCheckpoint"
        Me.cmbTipoCheckpoint.Size = New System.Drawing.Size(167, 22)
        Me.cmbTipoCheckpoint.TabIndex = 91
        '
        'chbEstadoSeguimiento
        '
        Me.chbEstadoSeguimiento.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chbEstadoSeguimiento.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbEstadoSeguimiento.Location = New System.Drawing.Point(21, 101)
        Me.chbEstadoSeguimiento.Name = "chbEstadoSeguimiento"
        Me.chbEstadoSeguimiento.Size = New System.Drawing.Size(174, 20)
        Me.chbEstadoSeguimiento.TabIndex = 94
        Me.chbEstadoSeguimiento.Text = "Mostrar en el Seguimiento :             "
        Me.chbEstadoSeguimiento.Values.ExtraText = ""
        Me.chbEstadoSeguimiento.Values.Image = Nothing
        Me.chbEstadoSeguimiento.Values.Text = "Mostrar en el Seguimiento :             "
        '
        'txtNomSeguimiento
        '
        Me.txtNomSeguimiento.AcceptsReturn = True
        Me.txtNomSeguimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomSeguimiento.Location = New System.Drawing.Point(165, 77)
        Me.txtNomSeguimiento.MaxLength = 60
        Me.txtNomSeguimiento.Name = "txtNomSeguimiento"
        Me.txtNomSeguimiento.Size = New System.Drawing.Size(446, 18)
        Me.txtNomSeguimiento.TabIndex = 93
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(21, 73)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(159, 20)
        Me.KryptonLabel3.TabIndex = 87
        Me.KryptonLabel3.Text = "Nombre en el seguimiento:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Nombre en el seguimiento:"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(21, 50)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(78, 20)
        Me.KryptonLabel10.TabIndex = 32
        Me.KryptonLabel10.Text = "Checkpoint :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Checkpoint :"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(21, 27)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(119, 20)
        Me.KryptonLabel11.TabIndex = 31
        Me.KryptonLabel11.Text = "Tipo de Checkpoint:"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Tipo de Checkpoint:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.KryptonPanel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1092, 15)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista Checkpoint"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'KryptonPanel3
        '
        Me.KryptonPanel3.Controls.Add(Me.tvwCheckPoint)
        Me.KryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel3.Name = "KryptonPanel3"
        Me.KryptonPanel3.Size = New System.Drawing.Size(1092, 15)
        Me.KryptonPanel3.TabIndex = 23
        '
        'tvwCheckPoint
        '
        Me.tvwCheckPoint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvwCheckPoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwCheckPoint.ImageIndex = 1
        Me.tvwCheckPoint.ImageList = Me.ImageList1
        Me.tvwCheckPoint.Location = New System.Drawing.Point(0, 0)
        Me.tvwCheckPoint.Name = "tvwCheckPoint"
        TreeNode1.ImageIndex = 2
        TreeNode1.Name = "CI"
        TreeNode1.SelectedImageIndex = 0
        TreeNode1.Tag = "E"
        TreeNode1.Text = "Carga Internacional"
        TreeNode1.ToolTipText = "Reporte Estadístico Mensual de Carga Internacional"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "AD"
        TreeNode2.SelectedImageIndex = 0
        TreeNode2.Tag = "A"
        TreeNode2.Text = "Aduanero"
        TreeNode2.ToolTipText = "Reporte Estadístico Mensual de Seguimiento Aduanero"
        TreeNode3.ImageIndex = 3
        TreeNode3.Name = "Raiz"
        TreeNode3.SelectedImageIndex = 3
        TreeNode3.Text = "CheckPoints"
        Me.tvwCheckPoint.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.tvwCheckPoint.SelectedImageIndex = 2
        Me.tvwCheckPoint.Size = New System.Drawing.Size(1092, 15)
        Me.tvwCheckPoint.TabIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Tips.ico")
        Me.ImageList1.Images.SetKeyName(1, "Error.ico")
        Me.ImageList1.Images.SetKeyName(2, "Tipo.ico")
        Me.ImageList1.Images.SetKeyName(3, "Maestro.ico")
        Me.ImageList1.Images.SetKeyName(4, "Activo.ico")
        Me.ImageList1.Images.SetKeyName(5, "Inactivo.ico")
        Me.ImageList1.Images.SetKeyName(6, "Parcial.ico")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCheck, Me.ToolStripLabel2, Me.tsbBuscar, Me.ToolStripSeparator1, Me.tsbExportar, Me.ToolStripSeparator2, Me.tsbGuardarOrdenCheck, Me.ToolStripSeparator3, Me.tsbEliminarCheck, Me.ToolStripSeparator6, Me.tsbModificarCheck, Me.ToolStripSeparator5, Me.tsbAgregarCheck, Me.btnCopiarPerfil})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 91)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1035, 25)
        Me.ToolStrip1.TabIndex = 35
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripLabel2.Tag = "CheckPoint"
        Me.ToolStripLabel2.Text = "CheckPoint"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator3.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.AutoScroll = True
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel24)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbTipoCheck)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblTipoCheck)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1035, 91)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 34
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbCliente.CCMPN = "EZ"
        Me.cmbCliente.Location = New System.Drawing.Point(85, 39)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.pAccesoPorUsuario = False
        Me.cmbCliente.pRequerido = False
        Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.cmbCliente.Size = New System.Drawing.Size(299, 22)
        Me.cmbCliente.TabIndex = 44
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(406, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel1.TabIndex = 58
        Me.KryptonLabel1.Text = "División:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "División:"
        '
        'cmbDivision
        '
        Me.cmbDivision.BackColor = System.Drawing.Color.Transparent
        Me.cmbDivision.CDVSN_ANTERIOR = Nothing
        Me.cmbDivision.Compania = ""
        Me.cmbDivision.Division = Nothing
        Me.cmbDivision.DivisionDefault = Nothing
        Me.cmbDivision.DivisionDescripcion = Nothing
        Me.cmbDivision.ItemTodos = False
        Me.cmbDivision.Location = New System.Drawing.Point(468, 8)
        Me.cmbDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.pHabilitado = True
        Me.cmbDivision.pRequerido = False
        Me.cmbDivision.Size = New System.Drawing.Size(265, 23)
        Me.cmbDivision.TabIndex = 57
        Me.cmbDivision.Usuario = ""
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(11, 11)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(69, 20)
        Me.KryptonLabel24.TabIndex = 56
        Me.KryptonLabel24.Text = "Compañía:"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Compañía:"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Habilitar = True
        Me.cmbCompania.Location = New System.Drawing.Point(85, 8)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(299, 32)
        Me.cmbCompania.TabIndex = 55
        Me.cmbCompania.Usuario = ""
        '
        'cmbTipoCheck
        '
        Me.cmbTipoCheck.BackColor = System.Drawing.Color.White
        Me.cmbTipoCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCheck.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCheck.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbTipoCheck.FormattingEnabled = True
        Me.cmbTipoCheck.Location = New System.Drawing.Point(468, 38)
        Me.cmbTipoCheck.Name = "cmbTipoCheck"
        Me.cmbTipoCheck.Size = New System.Drawing.Size(265, 22)
        Me.cmbTipoCheck.TabIndex = 25
        '
        'lblTipoCheck
        '
        Me.lblTipoCheck.Location = New System.Drawing.Point(406, 41)
        Me.lblTipoCheck.Name = "lblTipoCheck"
        Me.lblTipoCheck.Size = New System.Drawing.Size(37, 20)
        Me.lblTipoCheck.TabIndex = 33
        Me.lblTipoCheck.Text = "Tipo:"
        Me.lblTipoCheck.Values.ExtraText = ""
        Me.lblTipoCheck.Values.Image = Nothing
        Me.lblTipoCheck.Values.Text = "Tipo:"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(11, 40)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(54, 20)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente :"
        '
        'btnCheck
        '
        Me.btnCheck.Image = Global.SOLMIN_SC.My.Resources.Resources.btnNoMarcarItems
        Me.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(96, 22)
        Me.btnCheck.Text = "Check Todos"
        '
        'tsbBuscar
        '
        Me.tsbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(62, 22)
        Me.tsbBuscar.Text = "Buscar"
        '
        'tsbExportar
        '
        Me.tsbExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportar.Image = Global.SOLMIN_SC.My.Resources.Resources.excelicon
        Me.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportar.Name = "tsbExportar"
        Me.tsbExportar.Size = New System.Drawing.Size(70, 22)
        Me.tsbExportar.Text = "&Exportar"
        '
        'tsbGuardarOrdenCheck
        '
        Me.tsbGuardarOrdenCheck.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardarOrdenCheck.Image = Global.SOLMIN_SC.My.Resources.Resources.fileexport
        Me.tsbGuardarOrdenCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardarOrdenCheck.Name = "tsbGuardarOrdenCheck"
        Me.tsbGuardarOrdenCheck.Size = New System.Drawing.Size(105, 22)
        Me.tsbGuardarOrdenCheck.Text = "&Guardar Orden"
        '
        'tsbEliminarCheck
        '
        Me.tsbEliminarCheck.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminarCheck.Image = Global.SOLMIN_SC.My.Resources.Resources.db_remove
        Me.tsbEliminarCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminarCheck.Name = "tsbEliminarCheck"
        Me.tsbEliminarCheck.Size = New System.Drawing.Size(70, 22)
        Me.tsbEliminarCheck.Text = "&Eliminar"
        '
        'tsbModificarCheck
        '
        Me.tsbModificarCheck.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbModificarCheck.Image = CType(resources.GetObject("tsbModificarCheck.Image"), System.Drawing.Image)
        Me.tsbModificarCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificarCheck.Name = "tsbModificarCheck"
        Me.tsbModificarCheck.Size = New System.Drawing.Size(78, 22)
        Me.tsbModificarCheck.Text = "&Modificar"
        '
        'tsbAgregarCheck
        '
        Me.tsbAgregarCheck.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAgregarCheck.Image = Global.SOLMIN_SC.My.Resources.Resources.db_add
        Me.tsbAgregarCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarCheck.Name = "tsbAgregarCheck"
        Me.tsbAgregarCheck.Size = New System.Drawing.Size(69, 22)
        Me.tsbAgregarCheck.Text = "&Agregar"
        '
        'btnCopiarPerfil
        '
        Me.btnCopiarPerfil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCopiarPerfil.Image = Global.SOLMIN_SC.My.Resources.Resources.observaciones
        Me.btnCopiarPerfil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopiarPerfil.Name = "btnCopiarPerfil"
        Me.btnCopiarPerfil.Size = New System.Drawing.Size(92, 22)
        Me.btnCopiarPerfil.Text = "Copiar Perfil"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 56
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "CEMB"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 49
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 41
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Checkpoints"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 83
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estado Checkpoint"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 116
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre en el Seguimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 506
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Mostrar en el Seguimiento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 156
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "N° Presentación"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 102
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = " CCLNT"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'CODIGO
        '
        Me.CODIGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        Me.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CODIGO.Width = 56
        '
        'CEMB
        '
        Me.CEMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CEMB.HeaderText = "CEMB"
        Me.CEMB.Name = "CEMB"
        Me.CEMB.ReadOnly = True
        Me.CEMB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CEMB.Visible = False
        Me.CEMB.Width = 49
        '
        'TIPO
        '
        Me.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO.HeaderText = "Tipo"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TIPO.Width = 41
        '
        'CHECPOINT
        '
        Me.CHECPOINT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CHECPOINT.HeaderText = "Checkpoints"
        Me.CHECPOINT.Name = "CHECPOINT"
        Me.CHECPOINT.ReadOnly = True
        Me.CHECPOINT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CHECPOINT.Width = 83
        '
        'SESTRG
        '
        Me.SESTRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTRG.HeaderText = "Estado Checkpoint"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SESTRG.Visible = False
        Me.SESTRG.Width = 116
        '
        'TCOLUM
        '
        Me.TCOLUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCOLUM.HeaderText = "Nombre en el Seguimiento"
        Me.TCOLUM.Name = "TCOLUM"
        Me.TCOLUM.ReadOnly = True
        Me.TCOLUM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SESTRG2
        '
        Me.SESTRG2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTRG2.HeaderText = "Mostrar en el Seguimiento"
        Me.SESTRG2.Name = "SESTRG2"
        Me.SESTRG2.ReadOnly = True
        Me.SESTRG2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SESTRG2.Visible = False
        Me.SESTRG2.Width = 156
        '
        'NPRESENTACION
        '
        Me.NPRESENTACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPRESENTACION.HeaderText = "N° Presentación"
        Me.NPRESENTACION.Name = "NPRESENTACION"
        Me.NPRESENTACION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NPRESENTACION.Width = 102
        '
        'CCMPN
        '
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CCMPN.Visible = False
        '
        'CDVSN
        '
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CDVSN.Visible = False
        '
        'CCLNT
        '
        Me.CCLNT.HeaderText = " CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        '
        'frmAsignarCheckpoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 464)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmAsignarCheckpoint"
        Me.Text = "Asignar Checkpoint por Cliente"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel4.ResumeLayout(False)
        CType(Me.dtgCheckpoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup8.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup8.ResumeLayout(False)
        CType(Me.dtgExportarExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel3.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents btnNuevo As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnGrabar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnExportar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGuardarOrdenCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminarCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbModificarCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAgregarCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents cmbTipoCheck As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCheck As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup8 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dtgExportarExcel As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chbEstadoCheckpoint As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cmbCheckpoint As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoCheckpoint As System.Windows.Forms.ComboBox
    Friend WithEvents chbEstadoSeguimiento As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtNomSeguimiento As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents KryptonPanel3 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents tvwCheckPoint As System.Windows.Forms.TreeView
    Friend WithEvents KryptonPanel4 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dtgCheckpoint As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopiarPerfil As System.Windows.Forms.ToolStripButton
    Friend WithEvents CHK_COLUMNA As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEMB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHECPOINT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCOLUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPRESENTACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMSESTRG As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
End Class
