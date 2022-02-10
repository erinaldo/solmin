<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreDespachoPltz
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.kdgv_list_inventario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdicionar = New System.Windows.Forms.ToolStripButton()
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion()
        Me.kdtgvDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFecha = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblfiltroCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtBulto = New System.Windows.Forms.TextBox()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbPaletizado = New System.Windows.Forms.RadioButton()
        Me.rbBulto = New System.Windows.Forms.RadioButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager()
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.btnPreDespacho = New System.Windows.Forms.ToolStripButton()
        Me.btnQuitar = New System.Windows.Forms.ToolStripButton()
        Me.lblPlantaNombre = New System.Windows.Forms.ToolStripLabel()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.kdgvListPreDespacho = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.P_TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_IDPALETIZADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_COD_BULTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_TIPO_UNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_CANT_BULTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_FECHA_BULTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_NSEQIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHK = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.COD_TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPALETIZADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_BULTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_UNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANT_BULTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NSEQIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_BULTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_COD_BULTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TIPO_UNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_CANT_BULTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarTodo = New System.Windows.Forms.ToolStripButton()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.kdgv_list_inventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.kdtgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.kdgvListPreDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1209, 733)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.SplitContainer1)
        Me.KryptonGroup2.Panel.Controls.Add(Me.Panel1)
        Me.KryptonGroup2.Size = New System.Drawing.Size(1209, 733)
        Me.KryptonGroup2.TabIndex = 110
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 99)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.kdgvListPreDespacho)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsMenuOpciones)
        Me.SplitContainer1.Size = New System.Drawing.Size(1207, 632)
        Me.SplitContainer1.SplitterDistance = 639
        Me.SplitContainer1.TabIndex = 114
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.kdgv_list_inventario)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.UcPaginacion1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.kdtgvDetalle)
        Me.SplitContainer2.Size = New System.Drawing.Size(639, 632)
        Me.SplitContainer2.SplitterDistance = 393
        Me.SplitContainer2.TabIndex = 0
        '
        'kdgv_list_inventario
        '
        Me.kdgv_list_inventario.AllowUserToAddRows = False
        Me.kdgv_list_inventario.AllowUserToResizeRows = False
        Me.kdgv_list_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.kdgv_list_inventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.COD_TIPO, Me.TIPO, Me.CCLNT, Me.IDPALETIZADO, Me.COD_BULTO, Me.TIPO_UNIDAD, Me.CANT_BULTOS, Me.NSEQIN, Me.FECHA_BULTO, Me.Column6})
        Me.kdgv_list_inventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kdgv_list_inventario.Location = New System.Drawing.Point(0, 27)
        Me.kdgv_list_inventario.Margin = New System.Windows.Forms.Padding(4)
        Me.kdgv_list_inventario.MultiSelect = False
        Me.kdgv_list_inventario.Name = "kdgv_list_inventario"
        Me.kdgv_list_inventario.RowHeadersWidth = 20
        Me.kdgv_list_inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.kdgv_list_inventario.Size = New System.Drawing.Size(639, 335)
        Me.kdgv_list_inventario.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.kdgv_list_inventario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kdgv_list_inventario.TabIndex = 123
        Me.kdgv_list_inventario.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnAdicionar, Me.lblPlantaNombre})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(639, 27)
        Me.ToolStrip1.TabIndex = 122
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdicionar.Image = Global.Ransa.Controls.WayBill.My.Resources.Resources.edit_add
        Me.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(97, 24)
        Me.btnAdicionar.Text = "Adicionar"
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 362)
        Me.UcPaginacion1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(639, 31)
        Me.UcPaginacion1.TabIndex = 120
        '
        'kdtgvDetalle
        '
        Me.kdtgvDetalle.AllowUserToAddRows = False
        Me.kdtgvDetalle.AllowUserToResizeRows = False
        Me.kdtgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.kdtgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D_COD_BULTO, Me.D_TIPO_UNIDAD, Me.D_CANT_BULTOS, Me.DataGridViewTextBoxColumn14})
        Me.kdtgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kdtgvDetalle.Location = New System.Drawing.Point(0, 0)
        Me.kdtgvDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.kdtgvDetalle.MultiSelect = False
        Me.kdtgvDetalle.Name = "kdtgvDetalle"
        Me.kdtgvDetalle.ReadOnly = True
        Me.kdtgvDetalle.RowHeadersWidth = 20
        Me.kdtgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.kdtgvDetalle.Size = New System.Drawing.Size(639, 235)
        Me.kdtgvDetalle.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.kdtgvDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kdtgvDetalle.TabIndex = 116
        Me.kdtgvDetalle.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.lblfiltroCodigo)
        Me.Panel1.Controls.Add(Me.txtBulto)
        Me.Panel1.Controls.Add(Me.dtpFin)
        Me.Panel1.Controls.Add(Me.dtpInicio)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 99)
        Me.Panel1.TabIndex = 13
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(25, 30)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(48, 24)
        Me.KryptonLabel1.TabIndex = 15
        Me.KryptonLabel1.Text = "Vista: "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Vista: "
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(456, 5)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(54, 24)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.Text = "Fecha: "
        Me.lblFecha.Values.ExtraText = ""
        Me.lblFecha.Values.Image = Nothing
        Me.lblFecha.Values.Text = "Fecha: "
        '
        'lblfiltroCodigo
        '
        Me.lblfiltroCodigo.Location = New System.Drawing.Point(25, 62)
        Me.lblfiltroCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblfiltroCodigo.Name = "lblfiltroCodigo"
        Me.lblfiltroCodigo.Size = New System.Drawing.Size(50, 24)
        Me.lblfiltroCodigo.TabIndex = 12
        Me.lblfiltroCodigo.Text = "Bulto: "
        Me.lblfiltroCodigo.Values.ExtraText = ""
        Me.lblfiltroCodigo.Values.Image = Nothing
        Me.lblfiltroCodigo.Values.Text = "Bulto: "
        '
        'txtBulto
        '
        Me.txtBulto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBulto.Location = New System.Drawing.Point(134, 64)
        Me.txtBulto.MaxLength = 20
        Me.txtBulto.Name = "txtBulto"
        Me.txtBulto.Size = New System.Drawing.Size(275, 22)
        Me.txtBulto.TabIndex = 8
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(601, 34)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(118, 22)
        Me.dtpFin.TabIndex = 3
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(459, 34)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(118, 22)
        Me.dtpInicio.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbPaletizado)
        Me.GroupBox1.Controls.Add(Me.rbBulto)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 49)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rbPaletizado
        '
        Me.rbPaletizado.AutoSize = True
        Me.rbPaletizado.Location = New System.Drawing.Point(124, 20)
        Me.rbPaletizado.Name = "rbPaletizado"
        Me.rbPaletizado.Size = New System.Drawing.Size(95, 21)
        Me.rbPaletizado.TabIndex = 2
        Me.rbPaletizado.Text = "Paletizado"
        Me.rbPaletizado.UseVisualStyleBackColor = True
        '
        'rbBulto
        '
        Me.rbBulto.AutoSize = True
        Me.rbBulto.Checked = True
        Me.rbBulto.Location = New System.Drawing.Point(19, 21)
        Me.rbBulto.Name = "rbBulto"
        Me.rbBulto.Size = New System.Drawing.Size(61, 21)
        Me.rbBulto.TabIndex = 1
        Me.rbBulto.TabStop = True
        Me.rbBulto.Text = "Bulto"
        Me.rbBulto.UseVisualStyleBackColor = True
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.miniToolStrip.Location = New System.Drawing.Point(0, 1)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(372, 27)
        Me.miniToolStrip.TabIndex = 111
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPreDespacho, Me.btnQuitar, Me.btnQuitarTodo})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(564, 27)
        Me.tsMenuOpciones.TabIndex = 117
        '
        'btnPreDespacho
        '
        Me.btnPreDespacho.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPreDespacho.Image = Global.Ransa.Controls.WayBill.My.Resources.Resources.inventario
        Me.btnPreDespacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreDespacho.Name = "btnPreDespacho"
        Me.btnPreDespacho.Size = New System.Drawing.Size(126, 24)
        Me.btnPreDespacho.Text = "Pre-Despacho"
        '
        'btnQuitar
        '
        Me.btnQuitar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnQuitar.Image = Global.Ransa.Controls.WayBill.My.Resources.Resources.button_cancel
        Me.btnQuitar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(74, 24)
        Me.btnQuitar.Text = "Quitar"
        '
        'lblPlantaNombre
        '
        Me.lblPlantaNombre.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlantaNombre.Name = "lblPlantaNombre"
        Me.lblPlantaNombre.Size = New System.Drawing.Size(60, 24)
        Me.lblPlantaNombre.Text = "Planta"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.Ransa.Controls.WayBill.My.Resources.Resources.search1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'kdgvListPreDespacho
        '
        Me.kdgvListPreDespacho.AllowUserToAddRows = False
        Me.kdgvListPreDespacho.AllowUserToResizeRows = False
        Me.kdgvListPreDespacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.kdgvListPreDespacho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.P_TIPO, Me.P_CCLNT, Me.P_IDPALETIZADO, Me.P_COD_BULTO, Me.P_TIPO_UNIDAD, Me.P_CANT_BULTOS, Me.P_FECHA_BULTO, Me.P_NSEQIN, Me.DataGridViewTextBoxColumn10})
        Me.kdgvListPreDespacho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kdgvListPreDespacho.Location = New System.Drawing.Point(0, 27)
        Me.kdgvListPreDespacho.Margin = New System.Windows.Forms.Padding(4)
        Me.kdgvListPreDespacho.MultiSelect = False
        Me.kdgvListPreDespacho.Name = "kdgvListPreDespacho"
        Me.kdgvListPreDespacho.ReadOnly = True
        Me.kdgvListPreDespacho.RowHeadersWidth = 20
        Me.kdgvListPreDespacho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.kdgvListPreDespacho.Size = New System.Drawing.Size(564, 605)
        Me.kdgvListPreDespacho.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.kdgvListPreDespacho.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kdgvListPreDespacho.TabIndex = 118
        Me.kdgvListPreDespacho.TabStop = False
        '
        'P_TIPO
        '
        Me.P_TIPO.DataPropertyName = "TIPO"
        Me.P_TIPO.HeaderText = "Tipo"
        Me.P_TIPO.Name = "P_TIPO"
        Me.P_TIPO.ReadOnly = True
        '
        'P_CCLNT
        '
        Me.P_CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.P_CCLNT.DataPropertyName = "CCLNT"
        Me.P_CCLNT.HeaderText = "CCLNT"
        Me.P_CCLNT.Name = "P_CCLNT"
        Me.P_CCLNT.ReadOnly = True
        Me.P_CCLNT.Visible = False
        Me.P_CCLNT.Width = 86
        '
        'P_IDPALETIZADO
        '
        Me.P_IDPALETIZADO.DataPropertyName = "IDPALETIZADO"
        Me.P_IDPALETIZADO.HeaderText = "IDPALETIZADO"
        Me.P_IDPALETIZADO.Name = "P_IDPALETIZADO"
        Me.P_IDPALETIZADO.ReadOnly = True
        Me.P_IDPALETIZADO.Visible = False
        '
        'P_COD_BULTO
        '
        Me.P_COD_BULTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.P_COD_BULTO.DataPropertyName = "COD_BULTO"
        Me.P_COD_BULTO.HeaderText = "Código"
        Me.P_COD_BULTO.Name = "P_COD_BULTO"
        Me.P_COD_BULTO.ReadOnly = True
        Me.P_COD_BULTO.Width = 91
        '
        'P_TIPO_UNIDAD
        '
        Me.P_TIPO_UNIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.P_TIPO_UNIDAD.DataPropertyName = "TIPO_UNIDAD"
        Me.P_TIPO_UNIDAD.HeaderText = "Tipo Bulto"
        Me.P_TIPO_UNIDAD.Name = "P_TIPO_UNIDAD"
        Me.P_TIPO_UNIDAD.ReadOnly = True
        Me.P_TIPO_UNIDAD.Width = 111
        '
        'P_CANT_BULTOS
        '
        Me.P_CANT_BULTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.P_CANT_BULTOS.DataPropertyName = "CANT_BULTOS"
        Me.P_CANT_BULTOS.HeaderText = "Cantidad"
        Me.P_CANT_BULTOS.Name = "P_CANT_BULTOS"
        Me.P_CANT_BULTOS.ReadOnly = True
        Me.P_CANT_BULTOS.Width = 102
        '
        'P_FECHA_BULTO
        '
        Me.P_FECHA_BULTO.DataPropertyName = "FECHA_BULTO"
        Me.P_FECHA_BULTO.HeaderText = "F. Recep/Pltz"
        Me.P_FECHA_BULTO.Name = "P_FECHA_BULTO"
        Me.P_FECHA_BULTO.ReadOnly = True
        '
        'P_NSEQIN
        '
        Me.P_NSEQIN.DataPropertyName = "NSEQIN"
        Me.P_NSEQIN.HeaderText = "NSEQIN"
        Me.P_NSEQIN.Name = "P_NSEQIN"
        Me.P_NSEQIN.ReadOnly = True
        Me.P_NSEQIN.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = ""
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'CHK
        '
        Me.CHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = False
        Me.CHK.DefaultCellStyle = DataGridViewCellStyle2
        Me.CHK.FalseValue = Nothing
        Me.CHK.HeaderText = "Chk"
        Me.CHK.IndeterminateValue = Nothing
        Me.CHK.Name = "CHK"
        Me.CHK.TrueValue = Nothing
        Me.CHK.Width = 43
        '
        'COD_TIPO
        '
        Me.COD_TIPO.DataPropertyName = "COD_TIPO"
        Me.COD_TIPO.HeaderText = "COD_TIPO"
        Me.COD_TIPO.Name = "COD_TIPO"
        Me.COD_TIPO.ReadOnly = True
        Me.COD_TIPO.Visible = False
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "TIPO"
        Me.TIPO.HeaderText = "Tipo"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        '
        'CCLNT
        '
        Me.CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        Me.CCLNT.Width = 86
        '
        'IDPALETIZADO
        '
        Me.IDPALETIZADO.DataPropertyName = "IDPALETIZADO"
        Me.IDPALETIZADO.HeaderText = "IDPALETIZADO"
        Me.IDPALETIZADO.Name = "IDPALETIZADO"
        Me.IDPALETIZADO.ReadOnly = True
        Me.IDPALETIZADO.Visible = False
        '
        'COD_BULTO
        '
        Me.COD_BULTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_BULTO.DataPropertyName = "COD_BULTO"
        Me.COD_BULTO.HeaderText = "Código"
        Me.COD_BULTO.Name = "COD_BULTO"
        Me.COD_BULTO.ReadOnly = True
        Me.COD_BULTO.Width = 91
        '
        'TIPO_UNIDAD
        '
        Me.TIPO_UNIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_UNIDAD.DataPropertyName = "TIPO_UNIDAD"
        Me.TIPO_UNIDAD.HeaderText = "Tipo Bulto"
        Me.TIPO_UNIDAD.Name = "TIPO_UNIDAD"
        Me.TIPO_UNIDAD.ReadOnly = True
        Me.TIPO_UNIDAD.Width = 111
        '
        'CANT_BULTOS
        '
        Me.CANT_BULTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANT_BULTOS.DataPropertyName = "CANT_BULTOS"
        Me.CANT_BULTOS.HeaderText = "Cantidad"
        Me.CANT_BULTOS.Name = "CANT_BULTOS"
        Me.CANT_BULTOS.ReadOnly = True
        Me.CANT_BULTOS.Width = 102
        '
        'NSEQIN
        '
        Me.NSEQIN.DataPropertyName = "NSEQIN"
        Me.NSEQIN.HeaderText = "NSEQIN"
        Me.NSEQIN.Name = "NSEQIN"
        Me.NSEQIN.ReadOnly = True
        Me.NSEQIN.Visible = False
        '
        'FECHA_BULTO
        '
        Me.FECHA_BULTO.DataPropertyName = "FECHA_BULTO"
        Me.FECHA_BULTO.HeaderText = "F. Recep/Pltz"
        Me.FECHA_BULTO.Name = "FECHA_BULTO"
        Me.FECHA_BULTO.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        '
        'D_COD_BULTO
        '
        Me.D_COD_BULTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.D_COD_BULTO.DataPropertyName = "COD_BULTO"
        Me.D_COD_BULTO.HeaderText = "Código"
        Me.D_COD_BULTO.Name = "D_COD_BULTO"
        Me.D_COD_BULTO.ReadOnly = True
        Me.D_COD_BULTO.Width = 91
        '
        'D_TIPO_UNIDAD
        '
        Me.D_TIPO_UNIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.D_TIPO_UNIDAD.DataPropertyName = "TIPO_UNIDAD"
        Me.D_TIPO_UNIDAD.HeaderText = "Tipo Bulto"
        Me.D_TIPO_UNIDAD.Name = "D_TIPO_UNIDAD"
        Me.D_TIPO_UNIDAD.ReadOnly = True
        Me.D_TIPO_UNIDAD.Width = 111
        '
        'D_CANT_BULTOS
        '
        Me.D_CANT_BULTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.D_CANT_BULTOS.DataPropertyName = "CANT_BULTOS"
        Me.D_CANT_BULTOS.HeaderText = "Cantidad"
        Me.D_CANT_BULTOS.Name = "D_CANT_BULTOS"
        Me.D_CANT_BULTOS.ReadOnly = True
        Me.D_CANT_BULTOS.Width = 102
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.HeaderText = ""
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'btnQuitarTodo
        '
        Me.btnQuitarTodo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnQuitarTodo.Image = Global.Ransa.Controls.WayBill.My.Resources.Resources.button_cancel
        Me.btnQuitarTodo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuitarTodo.Name = "btnQuitarTodo"
        Me.btnQuitarTodo.Size = New System.Drawing.Size(112, 24)
        Me.btnQuitarTodo.Text = "Quitar Todo"
        '
        'frmPreDespachoPltz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 733)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPreDespachoPltz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generar PreDespacho"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.kdgv_list_inventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.kdtgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.kdgvListPreDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPaletizado As System.Windows.Forms.RadioButton
    Friend WithEvents rbBulto As System.Windows.Forms.RadioButton
    Friend WithEvents txtBulto As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdicionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
    Private WithEvents kdtgvDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents miniToolStrip As System.Windows.Forms.ToolStrip
    Private WithEvents kdgv_list_inventario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents lblFecha As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblfiltroCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblPlantaNombre As System.Windows.Forms.ToolStripLabel
    Private WithEvents kdgvListPreDespacho As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPreDespacho As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnQuitar As System.Windows.Forms.ToolStripButton
    Friend WithEvents P_TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_IDPALETIZADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_COD_BULTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_TIPO_UNIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_CANT_BULTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_FECHA_BULTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_NSEQIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHK As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents COD_TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPALETIZADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_BULTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_UNIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANT_BULTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSEQIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_BULTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_COD_BULTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TIPO_UNIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CANT_BULTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnQuitarTodo As System.Windows.Forms.ToolStripButton
End Class
