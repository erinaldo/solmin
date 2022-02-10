<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiTabla
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tablas", 1, 1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMultiTabla))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.tvwTabla = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtgDetalle = New System.Windows.Forms.DataGridView
        Me.KryptonHeaderGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFilDes = New System.Windows.Forms.TextBox
        Me.txtFilCod = New System.Windows.Forms.TextBox
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnNuevo = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnGrabar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblTrans = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDes = New System.Windows.Forms.TextBox
        Me.txtCod = New System.Windows.Forms.TextBox
        Me.cmbTrans = New System.Windows.Forms.ComboBox
        Me.oDs = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        CType(Me.dtgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup4.Panel.SuspendLayout()
        Me.KryptonHeaderGroup4.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.oDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonHeaderGroup2)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup3)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup4)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(993, 699)
        Me.KryptonSplitContainer1.SplitterDistance = 414
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.tvwTabla)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(414, 699)
        Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 5
        Me.KryptonHeaderGroup2.Text = "Tablas"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Tablas"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'tvwTabla
        '
        Me.tvwTabla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvwTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwTabla.ImageIndex = 1
        Me.tvwTabla.ImageList = Me.ImageList1
        Me.tvwTabla.Location = New System.Drawing.Point(0, 0)
        Me.tvwTabla.Name = "tvwTabla"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "Raiz"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Tablas"
        Me.tvwTabla.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tvwTabla.SelectedImageIndex = 2
        Me.tvwTabla.Size = New System.Drawing.Size(412, 677)
        Me.tvwTabla.TabIndex = 5
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Tips.ico")
        Me.ImageList1.Images.SetKeyName(1, "Maestro.ico")
        Me.ImageList1.Images.SetKeyName(2, "File.ico")
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(0, 88)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.dtgDetalle)
        Me.KryptonHeaderGroup3.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(574, 455)
        Me.KryptonHeaderGroup3.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup3.TabIndex = 12
        Me.KryptonHeaderGroup3.Text = "Detalles de Tabla"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Detalles de Tabla"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'dtgDetalle
        '
        Me.dtgDetalle.AllowUserToAddRows = False
        Me.dtgDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dtgDetalle.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDetalle.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgDetalle.Location = New System.Drawing.Point(5, 5)
        Me.dtgDetalle.MultiSelect = False
        Me.dtgDetalle.Name = "dtgDetalle"
        Me.dtgDetalle.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgDetalle.RowHeadersWidth = 20
        Me.dtgDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgDetalle.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetalle.RowTemplate.ReadOnly = True
        Me.dtgDetalle.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDetalle.Size = New System.Drawing.Size(562, 423)
        Me.dtgDetalle.TabIndex = 12
        '
        'KryptonHeaderGroup4
        '
        Me.KryptonHeaderGroup4.AutoSize = True
        Me.KryptonHeaderGroup4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.KryptonHeaderGroup4.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup4.Name = "KryptonHeaderGroup4"
        '
        'KryptonHeaderGroup4.Panel
        '
        Me.KryptonHeaderGroup4.Panel.AutoScroll = True
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.txtFilDes)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.txtFilCod)
        Me.KryptonHeaderGroup4.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup4.Size = New System.Drawing.Size(574, 88)
        Me.KryptonHeaderGroup4.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup4.TabIndex = 7
        Me.KryptonHeaderGroup4.Text = "Filtros"
        Me.KryptonHeaderGroup4.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup4.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup4.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup4.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(8, 37)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(74, 19)
        Me.KryptonLabel2.TabIndex = 17
        Me.KryptonLabel2.Text = "Descripción :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Descripción :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(8, 13)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel1.TabIndex = 16
        Me.KryptonLabel1.Text = "Código :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Código :"
        '
        'txtFilDes
        '
        Me.txtFilDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFilDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFilDes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilDes.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtFilDes.Location = New System.Drawing.Point(92, 38)
        Me.txtFilDes.Name = "txtFilDes"
        Me.txtFilDes.Size = New System.Drawing.Size(391, 20)
        Me.txtFilDes.TabIndex = 15
        '
        'txtFilCod
        '
        Me.txtFilCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFilCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFilCod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilCod.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtFilCod.Location = New System.Drawing.Point(92, 12)
        Me.txtFilCod.Name = "txtFilCod"
        Me.txtFilCod.Size = New System.Drawing.Size(104, 20)
        Me.txtFilCod.TabIndex = 14
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnNuevo})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 543)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.AutoScroll = True
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnGrabar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblTrans)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDes)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCod)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbTrans)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(574, 156)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 10
        Me.KryptonHeaderGroup1.Text = "Información del Detalle"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Información del Detalle"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        Me.KryptonHeaderGroup1.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.ExtraText = ""
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.ToolTipImage = Nothing
        Me.btnNuevo.UniqueName = "15BF4F968FB6455B15BF4F968FB6455B"
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(293, 92)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(73, 25)
        Me.btnGrabar.TabIndex = 19
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.Values.ExtraText = ""
        Me.btnGrabar.Values.Image = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGrabar.Values.Text = "Grabar"
        '
        'lblTrans
        '
        Me.lblTrans.Location = New System.Drawing.Point(8, 67)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(121, 19)
        Me.lblTrans.TabIndex = 18
        Me.lblTrans.Text = "Medio de Transporte :"
        Me.lblTrans.Values.ExtraText = ""
        Me.lblTrans.Values.Image = Nothing
        Me.lblTrans.Values.Text = "Medio de Transporte :"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(8, 38)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(74, 19)
        Me.KryptonLabel4.TabIndex = 17
        Me.KryptonLabel4.Text = "Descripción :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Descripción :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(8, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel3.TabIndex = 16
        Me.KryptonLabel3.Text = "Código :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Código :"
        '
        'txtDes
        '
        Me.txtDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDes.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtDes.Location = New System.Drawing.Point(133, 38)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(362, 20)
        Me.txtDes.TabIndex = 15
        '
        'txtCod
        '
        Me.txtCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCod.Enabled = False
        Me.txtCod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtCod.Location = New System.Drawing.Point(133, 12)
        Me.txtCod.MaxLength = 6
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(82, 20)
        Me.txtCod.TabIndex = 14
        '
        'cmbTrans
        '
        Me.cmbTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrans.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrans.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbTrans.FormattingEnabled = True
        Me.cmbTrans.Location = New System.Drawing.Point(133, 64)
        Me.cmbTrans.Name = "cmbTrans"
        Me.cmbTrans.Size = New System.Drawing.Size(135, 22)
        Me.cmbTrans.TabIndex = 10
        '
        'oDs
        '
        Me.oDs.DataSetName = "NewDataSet"
        Me.oDs.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2, Me.DataTable3})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.DataTable1.TableName = "oDtAgente"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "Código"
        Me.DataColumn1.ColumnName = "CAGNCR"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Agente Embarcador"
        Me.DataColumn2.ColumnName = "TNMAGC"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "País"
        Me.DataColumn3.ColumnName = "CPAIS"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Estado"
        Me.DataColumn4.ColumnName = "SESTRG"
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
        Me.DataTable2.TableName = "oDtVapor"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Código"
        Me.DataColumn5.ColumnName = "CVPRCN"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "Vapor"
        Me.DataColumn6.ColumnName = "TCMPVP"
        '
        'DataColumn7
        '
        Me.DataColumn7.Caption = "Transporte"
        Me.DataColumn7.ColumnName = "TIPNAV"
        '
        'DataColumn8
        '
        Me.DataColumn8.Caption = "Estado"
        Me.DataColumn8.ColumnName = "SESTRG"
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.DataTable3.TableName = "oDtCiaTran"
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "Código"
        Me.DataColumn9.ColumnName = "CCIANV"
        '
        'DataColumn10
        '
        Me.DataColumn10.Caption = "Cia. Transportes"
        Me.DataColumn10.ColumnName = "TNMCIN"
        '
        'DataColumn11
        '
        Me.DataColumn11.Caption = "País"
        Me.DataColumn11.ColumnName = "CPAIS"
        '
        'DataColumn12
        '
        Me.DataColumn12.Caption = "Transporte"
        Me.DataColumn12.ColumnName = "SMETRA"
        '
        'DataColumn13
        '
        Me.DataColumn13.Caption = "Estado"
        Me.DataColumn13.ColumnName = "SESTRG"
        '
        'frmMultiTabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 699)
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Name = "frmMultiTabla"
        Me.Text = "Mantenimiento de Tablas"
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        CType(Me.dtgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup4.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.oDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents tvwTabla As System.Windows.Forms.TreeView
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cmbTrans As System.Windows.Forms.ComboBox
    Friend WithEvents txtDes As System.Windows.Forms.TextBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents oDs As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup4 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtFilDes As System.Windows.Forms.TextBox
    Friend WithEvents txtFilCod As System.Windows.Forms.TextBox
    Friend WithEvents dtgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTrans As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnGrabar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
