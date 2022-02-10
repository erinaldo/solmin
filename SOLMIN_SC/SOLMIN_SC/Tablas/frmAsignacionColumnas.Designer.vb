<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacionColumnas
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Embarques", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Columnas", 2, 0)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tablas", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode2})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignacionColumnas))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup8 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnActualizarEmbarque = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtgAsigColumna = New System.Windows.Forms.DataGridView
        Me.dtgSegAduaneroXLS = New System.Windows.Forms.DataGridView
        Me.KryptonHeaderGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnCIUpd = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCIDel = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.tvwEmbarque = New System.Windows.Forms.TreeView
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.tvwCheckPoint = New System.Windows.Forms.TreeView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ArribaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbTipoReporte = New System.Windows.Forms.ComboBox
        Me.lblEstado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.btnBuscar = New System.Windows.Forms.PictureBox
        Me.KryptonHeaderGroup17 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnOCCrear = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnOCEmbarcar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnOCCancel = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtParcial = New System.Windows.Forms.TextBox
        Me.lblParcial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnQuitarOC = New System.Windows.Forms.PictureBox
        Me.btnAddOC = New System.Windows.Forms.PictureBox
        Me.txtFilOC = New System.Windows.Forms.TextBox
        Me.lblOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lsvOrdenCompraEmb = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.colPar = New System.Windows.Forms.ColumnHeader
        Me.lsvOrdenCompra = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.pnlOC = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnGrabarOC = New System.Windows.Forms.Button
        Me.lblFecOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMonOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDestinoOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblPrioOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTransOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblIncotermOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblReqOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDesOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtReqOC = New System.Windows.Forms.TextBox
        Me.txtDesOC = New System.Windows.Forms.TextBox
        Me.btnCancelarOC = New System.Windows.Forms.Button
        Me.cmbProveedorOC = New System.Windows.Forms.ComboBox
        Me.txtDestinoOC = New System.Windows.Forms.TextBox
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox
        Me.cmbMonOC = New System.Windows.Forms.ComboBox
        Me.dtpFecOC = New System.Windows.Forms.DateTimePicker
        Me.cmbPrioOC = New System.Windows.Forms.ComboBox
        Me.cmbIncotermOC = New System.Windows.Forms.ComboBox
        Me.cmbTransOC = New System.Windows.Forms.ComboBox
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup8.Panel.SuspendLayout()
        Me.KryptonHeaderGroup8.SuspendLayout()
        CType(Me.dtgAsigColumna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgSegAduaneroXLS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup4.Panel.SuspendLayout()
        Me.KryptonHeaderGroup4.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup17.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup17.Panel.SuspendLayout()
        Me.KryptonHeaderGroup17.SuspendLayout()
        CType(Me.btnQuitarOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOC.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup8)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1231, 676)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup8
        '
        Me.KryptonHeaderGroup8.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup8.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnActualizarEmbarque})
        Me.KryptonHeaderGroup8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup8.Location = New System.Drawing.Point(0, 64)
        Me.KryptonHeaderGroup8.Name = "KryptonHeaderGroup8"
        '
        'KryptonHeaderGroup8.Panel
        '
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.dtgAsigColumna)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.dtgSegAduaneroXLS)
        Me.KryptonHeaderGroup8.Panel.Controls.Add(Me.KryptonHeaderGroup4)
        Me.KryptonHeaderGroup8.Size = New System.Drawing.Size(1231, 352)
        Me.KryptonHeaderGroup8.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup8.TabIndex = 35
        Me.KryptonHeaderGroup8.Text = "Asignacion Columnas"
        Me.KryptonHeaderGroup8.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup8.ValuesPrimary.Heading = "Asignacion Columnas"
        Me.KryptonHeaderGroup8.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup8.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup8.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup8.ValuesSecondary.Image = Nothing
        '
        'btnActualizarEmbarque
        '
        Me.btnActualizarEmbarque.ExtraText = ""
        Me.btnActualizarEmbarque.Image = Nothing
        Me.btnActualizarEmbarque.Text = "Actualizar   |"
        Me.btnActualizarEmbarque.ToolTipBody = "Actualizar "
        Me.btnActualizarEmbarque.ToolTipImage = Nothing
        Me.btnActualizarEmbarque.UniqueName = "D5A0250DC96C41B2D5A0250DC96C41B2"
        '
        'dtgAsigColumna
        '
        Me.dtgAsigColumna.AllowUserToAddRows = False
        Me.dtgAsigColumna.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgAsigColumna.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgAsigColumna.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgAsigColumna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgAsigColumna.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgAsigColumna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgAsigColumna.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgAsigColumna.Location = New System.Drawing.Point(0, 0)
        Me.dtgAsigColumna.Name = "dtgAsigColumna"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgAsigColumna.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgAsigColumna.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgAsigColumna.Size = New System.Drawing.Size(1229, 321)
        Me.dtgAsigColumna.TabIndex = 24
        '
        'dtgSegAduaneroXLS
        '
        Me.dtgSegAduaneroXLS.AllowUserToAddRows = False
        Me.dtgSegAduaneroXLS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgSegAduaneroXLS.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgSegAduaneroXLS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgSegAduaneroXLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgSegAduaneroXLS.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgSegAduaneroXLS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgSegAduaneroXLS.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgSegAduaneroXLS.Location = New System.Drawing.Point(0, 0)
        Me.dtgSegAduaneroXLS.Name = "dtgSegAduaneroXLS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSegAduaneroXLS.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSegAduaneroXLS.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgSegAduaneroXLS.Size = New System.Drawing.Size(1229, 321)
        Me.dtgSegAduaneroXLS.TabIndex = 25
        Me.dtgSegAduaneroXLS.Visible = False
        '
        'KryptonHeaderGroup4
        '
        Me.KryptonHeaderGroup4.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnCIUpd, Me.btnCIDel})
        Me.KryptonHeaderGroup4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup4.Name = "KryptonHeaderGroup4"
        '
        'KryptonHeaderGroup4.Panel
        '
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.tvwEmbarque)
        Me.KryptonHeaderGroup4.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup4.Size = New System.Drawing.Size(1229, 321)
        Me.KryptonHeaderGroup4.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup4.TabIndex = 32
        Me.KryptonHeaderGroup4.Text = "Seguimiento Aduanero"
        Me.KryptonHeaderGroup4.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup4.ValuesPrimary.Heading = "Seguimiento Aduanero"
        Me.KryptonHeaderGroup4.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup4.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Image = Nothing
        Me.KryptonHeaderGroup4.Visible = False
        '
        'btnCIUpd
        '
        Me.btnCIUpd.ExtraText = ""
        Me.btnCIUpd.Image = Nothing
        Me.btnCIUpd.Text = "Actualizar"
        Me.btnCIUpd.ToolTipImage = Nothing
        Me.btnCIUpd.UniqueName = "5E64B4125996400D5E64B4125996400D"
        '
        'btnCIDel
        '
        Me.btnCIDel.ExtraText = ""
        Me.btnCIDel.Image = Nothing
        Me.btnCIDel.Text = "Eliminar"
        Me.btnCIDel.ToolTipImage = Nothing
        Me.btnCIDel.UniqueName = "3B8C7EF947AF44FB3B8C7EF947AF44FB"
        Me.btnCIDel.Visible = False
        '
        'tvwEmbarque
        '
        Me.tvwEmbarque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvwEmbarque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvwEmbarque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwEmbarque.Location = New System.Drawing.Point(5, 5)
        Me.tvwEmbarque.Name = "tvwEmbarque"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "Raiz"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Embarques"
        Me.tvwEmbarque.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tvwEmbarque.Size = New System.Drawing.Size(1217, 280)
        Me.tvwEmbarque.TabIndex = 8
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup2.AutoSize = True
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 416)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1231, 260)
        Me.KryptonHeaderGroup2.StateDisabled.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 36
        Me.KryptonHeaderGroup2.Text = "Cambiar Ubicacion Columnas"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Cambiar Ubicacion Columnas"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.tvwCheckPoint)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1229, 238)
        Me.KryptonPanel1.TabIndex = 0
        '
        'tvwCheckPoint
        '
        Me.tvwCheckPoint.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tvwCheckPoint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvwCheckPoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwCheckPoint.ImageIndex = 0
        Me.tvwCheckPoint.ImageList = Me.ImageList1
        Me.tvwCheckPoint.Location = New System.Drawing.Point(0, 0)
        Me.tvwCheckPoint.Name = "tvwCheckPoint"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "CI"
        TreeNode2.SelectedImageIndex = 0
        TreeNode2.Tag = "E"
        TreeNode2.Text = "Columnas"
        TreeNode2.ToolTipText = "Reporte Estadístico Mensual de Carga Internacional"
        TreeNode3.ImageIndex = 3
        TreeNode3.Name = "Raiz"
        TreeNode3.SelectedImageIndex = 3
        TreeNode3.Text = "Tablas"
        Me.tvwCheckPoint.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.tvwCheckPoint.SelectedImageIndex = 0
        Me.tvwCheckPoint.Size = New System.Drawing.Size(1229, 238)
        Me.tvwCheckPoint.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArribaToolStripMenuItem, Me.AbajoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(105, 48)
        '
        'ArribaToolStripMenuItem
        '
        Me.ArribaToolStripMenuItem.Name = "ArribaToolStripMenuItem"
        Me.ArribaToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.ArribaToolStripMenuItem.Text = "Arriba"
        '
        'AbajoToolStripMenuItem
        '
        Me.AbajoToolStripMenuItem.Name = "AbajoToolStripMenuItem"
        Me.AbajoToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.AbajoToolStripMenuItem.Text = "Abajo"
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
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbTipoReporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblEstado)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnBuscar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonHeaderGroup17)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1231, 64)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 8
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
        'cmbTipoReporte
        '
        Me.cmbTipoReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoReporte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoReporte.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbTipoReporte.FormattingEnabled = True
        Me.cmbTipoReporte.Location = New System.Drawing.Point(545, 8)
        Me.cmbTipoReporte.Name = "cmbTipoReporte"
        Me.cmbTipoReporte.Size = New System.Drawing.Size(303, 22)
        Me.cmbTipoReporte.TabIndex = 41
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(487, 11)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(55, 19)
        Me.lblEstado.TabIndex = 40
        Me.lblEstado.Text = "Reporte :"
        Me.lblEstado.Values.ExtraText = ""
        Me.lblEstado.Values.Image = Nothing
        Me.lblEstado.Values.Text = "Reporte :"
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbCliente.CCMPN = "EZ"
        Me.cmbCliente.Location = New System.Drawing.Point(199, 8)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.cmbCliente.Size = New System.Drawing.Size(256, 21)
        Me.cmbCliente.TabIndex = 39
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(885, 2)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.TabStop = False
        '
        'KryptonHeaderGroup17
        '
        Me.KryptonHeaderGroup17.AutoSize = True
        Me.KryptonHeaderGroup17.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnOCCrear, Me.btnOCEmbarcar, Me.btnOCCancel})
        Me.KryptonHeaderGroup17.Collapsed = True
        Me.KryptonHeaderGroup17.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate
        Me.KryptonHeaderGroup17.Location = New System.Drawing.Point(246, 8)
        Me.KryptonHeaderGroup17.Name = "KryptonHeaderGroup17"
        '
        'KryptonHeaderGroup17.Panel
        '
        Me.KryptonHeaderGroup17.Panel.Controls.Add(Me.txtParcial)
        Me.KryptonHeaderGroup17.Panel.Controls.Add(Me.lblParcial)
        Me.KryptonHeaderGroup17.Panel.Controls.Add(Me.btnQuitarOC)
        Me.KryptonHeaderGroup17.Panel.Controls.Add(Me.btnAddOC)
        Me.KryptonHeaderGroup17.Panel.Controls.Add(Me.txtFilOC)
        Me.KryptonHeaderGroup17.Panel.Controls.Add(Me.lblOC)
        Me.KryptonHeaderGroup17.Panel.Controls.Add(Me.lsvOrdenCompraEmb)
        Me.KryptonHeaderGroup17.Panel.Controls.Add(Me.lsvOrdenCompra)
        Me.KryptonHeaderGroup17.Panel.Controls.Add(Me.pnlOC)
        Me.KryptonHeaderGroup17.Size = New System.Drawing.Size(106, 18)
        Me.KryptonHeaderGroup17.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup17.TabIndex = 38
        Me.KryptonHeaderGroup17.Text = "Orden de Compra"
        Me.KryptonHeaderGroup17.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup17.ValuesPrimary.Heading = "Orden de Compra"
        Me.KryptonHeaderGroup17.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup17.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup17.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup17.ValuesSecondary.Image = Nothing
        Me.KryptonHeaderGroup17.Visible = False
        '
        'btnOCCrear
        '
        Me.btnOCCrear.ExtraText = ""
        Me.btnOCCrear.Image = Nothing
        Me.btnOCCrear.Text = "Crear OC"
        Me.btnOCCrear.ToolTipImage = Nothing
        Me.btnOCCrear.UniqueName = "56F469F1D12D4CF156F469F1D12D4CF1"
        Me.btnOCCrear.Visible = False
        '
        'btnOCEmbarcar
        '
        Me.btnOCEmbarcar.ExtraText = ""
        Me.btnOCEmbarcar.Image = Nothing
        Me.btnOCEmbarcar.Text = "Embarcar"
        Me.btnOCEmbarcar.ToolTipImage = Nothing
        Me.btnOCEmbarcar.UniqueName = "76C59D0EC7E64DED76C59D0EC7E64DED"
        Me.btnOCEmbarcar.Visible = False
        '
        'btnOCCancel
        '
        Me.btnOCCancel.ExtraText = ""
        Me.btnOCCancel.Image = Nothing
        Me.btnOCCancel.Text = "Cancelar"
        Me.btnOCCancel.ToolTipImage = Nothing
        Me.btnOCCancel.UniqueName = "99D70FAB749545E399D70FAB749545E3"
        Me.btnOCCancel.Visible = False
        '
        'txtParcial
        '
        Me.txtParcial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtParcial.Location = New System.Drawing.Point(319, 8)
        Me.txtParcial.Name = "txtParcial"
        Me.txtParcial.Size = New System.Drawing.Size(52, 20)
        Me.txtParcial.TabIndex = 33
        '
        'lblParcial
        '
        Me.lblParcial.Location = New System.Drawing.Point(268, 8)
        Me.lblParcial.Name = "lblParcial"
        Me.lblParcial.Size = New System.Drawing.Size(48, 19)
        Me.lblParcial.TabIndex = 32
        Me.lblParcial.Text = "Parcial :"
        Me.lblParcial.Values.ExtraText = ""
        Me.lblParcial.Values.Image = Nothing
        Me.lblParcial.Values.Text = "Parcial :"
        '
        'btnQuitarOC
        '
        Me.btnQuitarOC.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarOC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarOC.Image = CType(resources.GetObject("btnQuitarOC.Image"), System.Drawing.Image)
        Me.btnQuitarOC.Location = New System.Drawing.Point(325, 212)
        Me.btnQuitarOC.Name = "btnQuitarOC"
        Me.btnQuitarOC.Size = New System.Drawing.Size(48, 48)
        Me.btnQuitarOC.TabIndex = 30
        Me.btnQuitarOC.TabStop = False
        '
        'btnAddOC
        '
        Me.btnAddOC.BackColor = System.Drawing.Color.Transparent
        Me.btnAddOC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddOC.Image = CType(resources.GetObject("btnAddOC.Image"), System.Drawing.Image)
        Me.btnAddOC.Location = New System.Drawing.Point(325, 84)
        Me.btnAddOC.Name = "btnAddOC"
        Me.btnAddOC.Size = New System.Drawing.Size(48, 48)
        Me.btnAddOC.TabIndex = 29
        Me.btnAddOC.TabStop = False
        '
        'txtFilOC
        '
        Me.txtFilOC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFilOC.Location = New System.Drawing.Point(109, 8)
        Me.txtFilOC.Name = "txtFilOC"
        Me.txtFilOC.Size = New System.Drawing.Size(135, 20)
        Me.txtFilOC.TabIndex = 7
        '
        'lblOC
        '
        Me.lblOC.Location = New System.Drawing.Point(5, 8)
        Me.lblOC.Name = "lblOC"
        Me.lblOC.Size = New System.Drawing.Size(106, 19)
        Me.lblOC.TabIndex = 2
        Me.lblOC.Text = "Orden de Compra :"
        Me.lblOC.Values.ExtraText = ""
        Me.lblOC.Values.Image = Nothing
        Me.lblOC.Values.Text = "Orden de Compra :"
        '
        'lsvOrdenCompraEmb
        '
        Me.lsvOrdenCompraEmb.CheckBoxes = True
        Me.lsvOrdenCompraEmb.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.colPar})
        Me.lsvOrdenCompraEmb.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvOrdenCompraEmb.FullRowSelect = True
        Me.lsvOrdenCompraEmb.Location = New System.Drawing.Point(3, 163)
        Me.lsvOrdenCompraEmb.Name = "lsvOrdenCompraEmb"
        Me.lsvOrdenCompraEmb.Size = New System.Drawing.Size(316, 134)
        Me.lsvOrdenCompraEmb.TabIndex = 8
        Me.lsvOrdenCompraEmb.UseCompatibleStateImageBehavior = False
        Me.lsvOrdenCompraEmb.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "O/C"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 150
        '
        'colPar
        '
        Me.colPar.Text = "Parcial"
        Me.colPar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPar.Width = 50
        '
        'lsvOrdenCompra
        '
        Me.lsvOrdenCompra.CheckBoxes = True
        Me.lsvOrdenCompra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lsvOrdenCompra.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvOrdenCompra.FullRowSelect = True
        Me.lsvOrdenCompra.Location = New System.Drawing.Point(3, 38)
        Me.lsvOrdenCompra.Name = "lsvOrdenCompra"
        Me.lsvOrdenCompra.Size = New System.Drawing.Size(316, 123)
        Me.lsvOrdenCompra.TabIndex = 28
        Me.lsvOrdenCompra.UseCompatibleStateImageBehavior = False
        Me.lsvOrdenCompra.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "O/C"
        Me.ColumnHeader2.Width = 150
        '
        'pnlOC
        '
        Me.pnlOC.AutoScroll = True
        Me.pnlOC.Controls.Add(Me.btnGrabarOC)
        Me.pnlOC.Controls.Add(Me.lblFecOC)
        Me.pnlOC.Controls.Add(Me.lblMonOC)
        Me.pnlOC.Controls.Add(Me.lblDestinoOC)
        Me.pnlOC.Controls.Add(Me.lblPrioOC)
        Me.pnlOC.Controls.Add(Me.lblTransOC)
        Me.pnlOC.Controls.Add(Me.lblIncotermOC)
        Me.pnlOC.Controls.Add(Me.lblReqOC)
        Me.pnlOC.Controls.Add(Me.lblDesOC)
        Me.pnlOC.Controls.Add(Me.KryptonLabel1)
        Me.pnlOC.Controls.Add(Me.KryptonLabel2)
        Me.pnlOC.Controls.Add(Me.txtReqOC)
        Me.pnlOC.Controls.Add(Me.txtDesOC)
        Me.pnlOC.Controls.Add(Me.btnCancelarOC)
        Me.pnlOC.Controls.Add(Me.cmbProveedorOC)
        Me.pnlOC.Controls.Add(Me.txtDestinoOC)
        Me.pnlOC.Controls.Add(Me.txtOrdenCompra)
        Me.pnlOC.Controls.Add(Me.cmbMonOC)
        Me.pnlOC.Controls.Add(Me.dtpFecOC)
        Me.pnlOC.Controls.Add(Me.cmbPrioOC)
        Me.pnlOC.Controls.Add(Me.cmbIncotermOC)
        Me.pnlOC.Controls.Add(Me.cmbTransOC)
        Me.pnlOC.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlOC.Location = New System.Drawing.Point(0, -162)
        Me.pnlOC.Name = "pnlOC"
        Me.pnlOC.Size = New System.Drawing.Size(148, 262)
        Me.pnlOC.TabIndex = 31
        Me.pnlOC.Visible = False
        '
        'btnGrabarOC
        '
        Me.btnGrabarOC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrabarOC.Location = New System.Drawing.Point(464, 102)
        Me.btnGrabarOC.Name = "btnGrabarOC"
        Me.btnGrabarOC.Size = New System.Drawing.Size(66, 58)
        Me.btnGrabarOC.TabIndex = 50
        Me.btnGrabarOC.Text = "Grabar"
        Me.btnGrabarOC.UseVisualStyleBackColor = True
        '
        'lblFecOC
        '
        Me.lblFecOC.Location = New System.Drawing.Point(225, 17)
        Me.lblFecOC.Name = "lblFecOC"
        Me.lblFecOC.Size = New System.Drawing.Size(68, 19)
        Me.lblFecOC.TabIndex = 49
        Me.lblFecOC.Text = "Fecha O/C :"
        Me.lblFecOC.Values.ExtraText = ""
        Me.lblFecOC.Values.Image = Nothing
        Me.lblFecOC.Values.Text = "Fecha O/C :"
        '
        'lblMonOC
        '
        Me.lblMonOC.Location = New System.Drawing.Point(6, 213)
        Me.lblMonOC.Name = "lblMonOC"
        Me.lblMonOC.Size = New System.Drawing.Size(57, 19)
        Me.lblMonOC.TabIndex = 48
        Me.lblMonOC.Text = "Moneda :"
        Me.lblMonOC.Values.ExtraText = ""
        Me.lblMonOC.Values.Image = Nothing
        Me.lblMonOC.Values.Text = "Moneda :"
        '
        'lblDestinoOC
        '
        Me.lblDestinoOC.Location = New System.Drawing.Point(6, 188)
        Me.lblDestinoOC.Name = "lblDestinoOC"
        Me.lblDestinoOC.Size = New System.Drawing.Size(54, 19)
        Me.lblDestinoOC.TabIndex = 47
        Me.lblDestinoOC.Text = "Destino :"
        Me.lblDestinoOC.Values.ExtraText = ""
        Me.lblDestinoOC.Values.Image = Nothing
        Me.lblDestinoOC.Values.Text = "Destino :"
        '
        'lblPrioOC
        '
        Me.lblPrioOC.Location = New System.Drawing.Point(5, 164)
        Me.lblPrioOC.Name = "lblPrioOC"
        Me.lblPrioOC.Size = New System.Drawing.Size(61, 19)
        Me.lblPrioOC.TabIndex = 46
        Me.lblPrioOC.Text = "Prioridad :"
        Me.lblPrioOC.Values.ExtraText = ""
        Me.lblPrioOC.Values.Image = Nothing
        Me.lblPrioOC.Values.Text = "Prioridad :"
        '
        'lblTransOC
        '
        Me.lblTransOC.Location = New System.Drawing.Point(5, 139)
        Me.lblTransOC.Name = "lblTransOC"
        Me.lblTransOC.Size = New System.Drawing.Size(102, 19)
        Me.lblTransOC.TabIndex = 45
        Me.lblTransOC.Text = "Medio Embarque :"
        Me.lblTransOC.Values.ExtraText = ""
        Me.lblTransOC.Values.Image = Nothing
        Me.lblTransOC.Values.Text = "Medio Embarque :"
        '
        'lblIncotermOC
        '
        Me.lblIncotermOC.Location = New System.Drawing.Point(5, 114)
        Me.lblIncotermOC.Name = "lblIncotermOC"
        Me.lblIncotermOC.Size = New System.Drawing.Size(60, 19)
        Me.lblIncotermOC.TabIndex = 44
        Me.lblIncotermOC.Text = "Incoterm :"
        Me.lblIncotermOC.Values.ExtraText = ""
        Me.lblIncotermOC.Values.Image = Nothing
        Me.lblIncotermOC.Values.Text = "Incoterm :"
        '
        'lblReqOC
        '
        Me.lblReqOC.Location = New System.Drawing.Point(5, 89)
        Me.lblReqOC.Name = "lblReqOC"
        Me.lblReqOC.Size = New System.Drawing.Size(105, 19)
        Me.lblReqOC.TabIndex = 43
        Me.lblReqOC.Text = "N° Requerimiento :"
        Me.lblReqOC.Values.ExtraText = ""
        Me.lblReqOC.Values.Image = Nothing
        Me.lblReqOC.Values.Text = "N° Requerimiento :"
        '
        'lblDesOC
        '
        Me.lblDesOC.Location = New System.Drawing.Point(5, 67)
        Me.lblDesOC.Name = "lblDesOC"
        Me.lblDesOC.Size = New System.Drawing.Size(74, 19)
        Me.lblDesOC.TabIndex = 42
        Me.lblDesOC.Text = "Descripción :"
        Me.lblDesOC.Values.ExtraText = ""
        Me.lblDesOC.Values.Image = Nothing
        Me.lblDesOC.Values.Text = "Descripción :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(6, 17)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(106, 19)
        Me.KryptonLabel1.TabIndex = 41
        Me.KryptonLabel1.Text = "N° Orden Compra :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "N° Orden Compra :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(6, 42)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel2.TabIndex = 40
        Me.KryptonLabel2.Text = "Proveedor :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Proveedor :"
        '
        'txtReqOC
        '
        Me.txtReqOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReqOC.Location = New System.Drawing.Point(116, 87)
        Me.txtReqOC.MaxLength = 15
        Me.txtReqOC.Name = "txtReqOC"
        Me.txtReqOC.Size = New System.Drawing.Size(128, 18)
        Me.txtReqOC.TabIndex = 39
        '
        'txtDesOC
        '
        Me.txtDesOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesOC.Location = New System.Drawing.Point(116, 63)
        Me.txtDesOC.MaxLength = 50
        Me.txtDesOC.Name = "txtDesOC"
        Me.txtDesOC.Size = New System.Drawing.Size(266, 18)
        Me.txtDesOC.TabIndex = 37
        Me.txtDesOC.Text = "Orden de Compra Generada Automáticamente"
        '
        'btnCancelarOC
        '
        Me.btnCancelarOC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarOC.Location = New System.Drawing.Point(246, 235)
        Me.btnCancelarOC.Name = "btnCancelarOC"
        Me.btnCancelarOC.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelarOC.TabIndex = 1
        Me.btnCancelarOC.Text = "Cancelar"
        Me.btnCancelarOC.UseVisualStyleBackColor = True
        '
        'cmbProveedorOC
        '
        Me.cmbProveedorOC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbProveedorOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedorOC.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedorOC.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbProveedorOC.FormattingEnabled = True
        Me.cmbProveedorOC.Location = New System.Drawing.Point(116, 37)
        Me.cmbProveedorOC.Name = "cmbProveedorOC"
        Me.cmbProveedorOC.Size = New System.Drawing.Size(266, 19)
        Me.cmbProveedorOC.TabIndex = 8
        '
        'txtDestinoOC
        '
        Me.txtDestinoOC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDestinoOC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDestinoOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestinoOC.Location = New System.Drawing.Point(116, 186)
        Me.txtDestinoOC.MaxLength = 24
        Me.txtDestinoOC.Name = "txtDestinoOC"
        Me.txtDestinoOC.Size = New System.Drawing.Size(130, 18)
        Me.txtDestinoOC.TabIndex = 35
        Me.txtDestinoOC.Text = "CALLAO"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompra.Location = New System.Drawing.Point(116, 13)
        Me.txtOrdenCompra.MaxLength = 35
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(100, 18)
        Me.txtOrdenCompra.TabIndex = 23
        '
        'cmbMonOC
        '
        Me.cmbMonOC.BackColor = System.Drawing.Color.White
        Me.cmbMonOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonOC.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonOC.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbMonOC.FormattingEnabled = True
        Me.cmbMonOC.Location = New System.Drawing.Point(116, 210)
        Me.cmbMonOC.Name = "cmbMonOC"
        Me.cmbMonOC.Size = New System.Drawing.Size(131, 19)
        Me.cmbMonOC.TabIndex = 33
        '
        'dtpFecOC
        '
        Me.dtpFecOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecOC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecOC.Location = New System.Drawing.Point(302, 13)
        Me.dtpFecOC.Name = "dtpFecOC"
        Me.dtpFecOC.Size = New System.Drawing.Size(80, 18)
        Me.dtpFecOC.TabIndex = 26
        '
        'cmbPrioOC
        '
        Me.cmbPrioOC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPrioOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrioOC.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrioOC.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbPrioOC.FormattingEnabled = True
        Me.cmbPrioOC.Location = New System.Drawing.Point(116, 161)
        Me.cmbPrioOC.Name = "cmbPrioOC"
        Me.cmbPrioOC.Size = New System.Drawing.Size(130, 19)
        Me.cmbPrioOC.TabIndex = 31
        '
        'cmbIncotermOC
        '
        Me.cmbIncotermOC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbIncotermOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIncotermOC.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIncotermOC.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbIncotermOC.FormattingEnabled = True
        Me.cmbIncotermOC.Location = New System.Drawing.Point(116, 111)
        Me.cmbIncotermOC.Name = "cmbIncotermOC"
        Me.cmbIncotermOC.Size = New System.Drawing.Size(128, 19)
        Me.cmbIncotermOC.TabIndex = 23
        '
        'cmbTransOC
        '
        Me.cmbTransOC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTransOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransOC.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTransOC.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbTransOC.FormattingEnabled = True
        Me.cmbTransOC.Location = New System.Drawing.Point(116, 136)
        Me.cmbTransOC.Name = "cmbTransOC"
        Me.cmbTransOC.Size = New System.Drawing.Size(129, 19)
        Me.cmbTransOC.TabIndex = 29
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(135, 12)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 19)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente :"
        '
        'frmAsignacionColumnas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 676)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmAsignacionColumnas"
        Me.Text = "frmAsignacionColumnas"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup8.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup8.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup8.ResumeLayout(False)
        CType(Me.dtgAsigColumna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgSegAduaneroXLS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup17.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup17.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup17.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup17.ResumeLayout(False)
        CType(Me.btnQuitarOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOC.ResumeLayout(False)
        Me.pnlOC.PerformLayout()
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup3 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents btnBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonHeaderGroup17 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnOCCrear As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnOCEmbarcar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnOCCancel As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtParcial As System.Windows.Forms.TextBox
    Friend WithEvents lblParcial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnQuitarOC As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddOC As System.Windows.Forms.PictureBox
    Friend WithEvents txtFilOC As System.Windows.Forms.TextBox
    Friend WithEvents lblOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lsvOrdenCompraEmb As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPar As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvOrdenCompra As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlOC As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnGrabarOC As System.Windows.Forms.Button
    Friend WithEvents lblFecOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMonOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDestinoOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPrioOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTransOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblIncotermOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblReqOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDesOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtReqOC As System.Windows.Forms.TextBox
    Friend WithEvents txtDesOC As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelarOC As System.Windows.Forms.Button
    Friend WithEvents cmbProveedorOC As System.Windows.Forms.ComboBox
    Friend WithEvents txtDestinoOC As System.Windows.Forms.TextBox
    Friend WithEvents txtOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents cmbMonOC As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecOC As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPrioOC As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIncotermOC As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTransOC As System.Windows.Forms.ComboBox
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup8 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnActualizarEmbarque As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgAsigColumna As System.Windows.Forms.DataGridView
    Friend WithEvents dtgSegAduaneroXLS As System.Windows.Forms.DataGridView
    Friend WithEvents KryptonHeaderGroup4 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnCIUpd As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCIDel As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents tvwEmbarque As System.Windows.Forms.TreeView
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents tvwCheckPoint As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmbTipoReporte As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ArribaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
