<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaRefactura
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.tabFactura = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblNumFact = New System.Windows.Forms.Label
        Me.lblTipoDoc = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtgDetalleFactura = New System.Windows.Forms.DataGridView
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dtgCabeceraFactura = New System.Windows.Forms.DataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.tsSep_05 = New System.Windows.Forms.ToolStripSeparator
        Me.tssSep_04 = New System.Windows.Forms.ToolStripSeparator
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.chkDescripcionManual = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.cmbPlantaFacturar = New System.Windows.Forms.ComboBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblError = New System.Windows.Forms.Label
        Me.dtpFechaFac = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbGiro = New System.Windows.Forms.ComboBox
        Me.txtTipoCambio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRegionVenta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPtoVenta = New System.Windows.Forms.ComboBox
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPlantaCliente = New System.Windows.Forms.ComboBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblArea = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.btnFacturar = New System.Windows.Forms.ToolStripButton
        Me.LbDatos_Adicional_Factura = New System.Windows.Forms.Label
        Me.LbDatos_Adicional_Factura_Ruc = New System.Windows.Forms.Label
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.tabFactura.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgCabeceraFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(998, 589)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.LbDatos_Adicional_Factura)
        Me.KryptonPanel1.Controls.Add(Me.tabFactura)
        Me.KryptonPanel1.Controls.Add(Me.GroupBox2)
        Me.KryptonPanel1.Controls.Add(Me.GroupBox1)
        Me.KryptonPanel1.Controls.Add(Me.PictureBox1)
        Me.KryptonPanel1.Controls.Add(Me.dtgCabeceraFactura)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 150)
        Me.KryptonPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(998, 439)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 91
        '
        'tabFactura
        '
        Me.tabFactura.Controls.Add(Me.TabPage1)
        Me.tabFactura.Location = New System.Drawing.Point(11, 234)
        Me.tabFactura.Name = "tabFactura"
        Me.tabFactura.SelectedIndex = 0
        Me.tabFactura.Size = New System.Drawing.Size(992, 355)
        Me.tabFactura.TabIndex = 75
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(984, 329)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.LbDatos_Adicional_Factura_Ruc)
        Me.GroupBox2.Controls.Add(Me.lblNumFact)
        Me.GroupBox2.Controls.Add(Me.lblTipoDoc)
        Me.GroupBox2.Location = New System.Drawing.Point(675, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 210)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        '
        'lblNumFact
        '
        Me.lblNumFact.AutoSize = True
        Me.lblNumFact.BackColor = System.Drawing.Color.White
        Me.lblNumFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFact.Location = New System.Drawing.Point(64, 145)
        Me.lblNumFact.Name = "lblNumFact"
        Me.lblNumFact.Size = New System.Drawing.Size(0, 29)
        Me.lblNumFact.TabIndex = 69
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.BackColor = System.Drawing.Color.White
        Me.lblTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDoc.Location = New System.Drawing.Point(37, 103)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(256, 29)
        Me.lblTipoDoc.TabIndex = 68
        Me.lblTipoDoc.Text = "FACTURA"
        Me.lblTipoDoc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtgDetalleFactura)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 111)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        '
        'dtgDetalleFactura
        '
        Me.dtgDetalleFactura.AllowUserToAddRows = False
        Me.dtgDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgDetalleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDetalleFactura.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalleFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dtgDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalleFactura.DefaultCellStyle = DataGridViewCellStyle14
        Me.dtgDetalleFactura.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgDetalleFactura.Location = New System.Drawing.Point(7, 274)
        Me.dtgDetalleFactura.Name = "dtgDetalleFactura"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDetalleFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dtgDetalleFactura.RowHeadersWidth = 20
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetalleFactura.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dtgDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDetalleFactura.Size = New System.Drawing.Size(985, 187)
        Me.dtgDetalleFactura.TabIndex = 63
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(6, 14)
        Me.txtCliente.Multiline = True
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(638, 90)
        Me.txtCliente.TabIndex = 2
        '
        'dtgCabeceraFactura
        '
        Me.dtgCabeceraFactura.AllowUserToAddRows = False
        Me.dtgCabeceraFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCabeceraFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgCabeceraFactura.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCabeceraFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dtgCabeceraFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCabeceraFactura.DefaultCellStyle = DataGridViewCellStyle10
        Me.dtgCabeceraFactura.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgCabeceraFactura.Location = New System.Drawing.Point(12, 257)
        Me.dtgCabeceraFactura.Name = "dtgCabeceraFactura"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCabeceraFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dtgCabeceraFactura.RowHeadersWidth = 20
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgCabeceraFactura.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dtgCabeceraFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgCabeceraFactura.Size = New System.Drawing.Size(992, 99)
        Me.dtgCabeceraFactura.TabIndex = 76
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSep_05, Me.btnCancelar, Me.tssSep_04, Me.btnFacturar, Me.tssSep_02})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 125)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(998, 25)
        Me.tsMenuOpciones.TabIndex = 90
        '
        'tsSep_05
        '
        Me.tsSep_05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep_05.Name = "tsSep_05"
        Me.tsSep_05.Size = New System.Drawing.Size(6, 25)
        '
        'tssSep_04
        '
        Me.tssSep_04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_04.Name = "tssSep_04"
        Me.tssSep_04.Size = New System.Drawing.Size(6, 25)
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.chkDescripcionManual)
        Me.KryptonPanel2.Controls.Add(Me.cmbPlantaFacturar)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel2.Controls.Add(Me.lblError)
        Me.KryptonPanel2.Controls.Add(Me.dtpFechaFac)
        Me.KryptonPanel2.Controls.Add(Me.lblFechaFactura)
        Me.KryptonPanel2.Controls.Add(Me.cmbGiro)
        Me.KryptonPanel2.Controls.Add(Me.txtTipoCambio)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel2.Controls.Add(Me.txtRegionVenta)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel2.Controls.Add(Me.cmbPtoVenta)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel2.Controls.Add(Me.cmbPlantaCliente)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel2.Controls.Add(Me.lblArea)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(998, 125)
        Me.KryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel2.TabIndex = 89
        '
        'chkDescripcionManual
        '
        Me.chkDescripcionManual.Checked = False
        Me.chkDescripcionManual.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkDescripcionManual.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDescripcionManual.Location = New System.Drawing.Point(7, 70)
        Me.chkDescripcionManual.Name = "chkDescripcionManual"
        Me.chkDescripcionManual.Size = New System.Drawing.Size(148, 20)
        Me.chkDescripcionManual.TabIndex = 92
        Me.chkDescripcionManual.Text = "Modificar Descripción :  "
        Me.chkDescripcionManual.Values.ExtraText = ""
        Me.chkDescripcionManual.Values.Image = Nothing
        Me.chkDescripcionManual.Values.Text = "Modificar Descripción :  "
        '
        'cmbPlantaFacturar
        '
        Me.cmbPlantaFacturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPlantaFacturar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlantaFacturar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlantaFacturar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbPlantaFacturar.FormattingEnabled = True
        Me.cmbPlantaFacturar.Location = New System.Drawing.Point(128, 17)
        Me.cmbPlantaFacturar.Name = "cmbPlantaFacturar"
        Me.cmbPlantaFacturar.Size = New System.Drawing.Size(302, 22)
        Me.cmbPlantaFacturar.TabIndex = 90
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(7, 19)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(107, 20)
        Me.KryptonLabel3.TabIndex = 91
        Me.KryptonLabel3.Text = "Planta a Facturar :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta a Facturar :"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.White
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(435, 92)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(261, 30)
        Me.lblError.TabIndex = 89
        Me.lblError.Text = "* No se puede generar la factura por " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " no existir tipo de cambio para la fecha "
        Me.lblError.Visible = False
        '
        'dtpFechaFac
        '
        Me.dtpFechaFac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFac.Location = New System.Drawing.Point(318, 71)
        Me.dtpFechaFac.Name = "dtpFechaFac"
        Me.dtpFechaFac.Size = New System.Drawing.Size(111, 20)
        Me.dtpFechaFac.TabIndex = 88
        Me.dtpFechaFac.Visible = False
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.Location = New System.Drawing.Point(216, 71)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(91, 20)
        Me.lblFechaFactura.TabIndex = 87
        Me.lblFechaFactura.Text = "Fecha Factura :"
        Me.lblFechaFactura.Values.ExtraText = ""
        Me.lblFechaFactura.Values.Image = Nothing
        Me.lblFechaFactura.Values.Text = "Fecha Factura :"
        Me.lblFechaFactura.Visible = False
        '
        'cmbGiro
        '
        Me.cmbGiro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbGiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGiro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGiro.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbGiro.FormattingEnabled = True
        Me.cmbGiro.Location = New System.Drawing.Point(128, 43)
        Me.cmbGiro.Name = "cmbGiro"
        Me.cmbGiro.Size = New System.Drawing.Size(302, 22)
        Me.cmbGiro.TabIndex = 76
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(752, 14)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(169, 22)
        Me.txtTipoCambio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoCambio.TabIndex = 85
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(438, 16)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel2.TabIndex = 84
        Me.KryptonLabel2.Text = "Región Venta :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Región Venta :"
        '
        'txtRegionVenta
        '
        Me.txtRegionVenta.Location = New System.Drawing.Point(533, 14)
        Me.txtRegionVenta.Name = "txtRegionVenta"
        Me.txtRegionVenta.ReadOnly = True
        Me.txtRegionVenta.Size = New System.Drawing.Size(112, 22)
        Me.txtRegionVenta.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRegionVenta.TabIndex = 83
        Me.txtRegionVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(651, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(103, 20)
        Me.KryptonLabel1.TabIndex = 82
        Me.KryptonLabel1.Text = "Tipo de Cambio :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tipo de Cambio :"
        '
        'cmbPtoVenta
        '
        Me.cmbPtoVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPtoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPtoVenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPtoVenta.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbPtoVenta.FormattingEnabled = True
        Me.cmbPtoVenta.Location = New System.Drawing.Point(533, 40)
        Me.cmbPtoVenta.Name = "cmbPtoVenta"
        Me.cmbPtoVenta.Size = New System.Drawing.Size(388, 22)
        Me.cmbPtoVenta.TabIndex = 81
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(438, 43)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel10.TabIndex = 80
        Me.KryptonLabel10.Text = "Pto. Venta :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Pto. Venta :"
        '
        'cmbPlantaCliente
        '
        Me.cmbPlantaCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPlantaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlantaCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlantaCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbPlantaCliente.FormattingEnabled = True
        Me.cmbPlantaCliente.Location = New System.Drawing.Point(533, 69)
        Me.cmbPlantaCliente.Name = "cmbPlantaCliente"
        Me.cmbPlantaCliente.Size = New System.Drawing.Size(388, 22)
        Me.cmbPlantaCliente.TabIndex = 79
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(438, 70)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel9.TabIndex = 78
        Me.KryptonLabel9.Text = "Planta Cliente :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Planta Cliente :"
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(7, 44)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(109, 20)
        Me.lblArea.TabIndex = 77
        Me.lblArea.Text = "Giro del Negocio :"
        Me.lblArea.Values.ExtraText = ""
        Me.lblArea.Values.Image = Nothing
        Me.lblArea.Values.Text = "Giro del Negocio :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SOLMIN_CT.My.Resources.Resources.LogoFactura2
        Me.PictureBox1.Location = New System.Drawing.Point(21, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnFacturar
        '
        Me.btnFacturar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnFacturar.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_billetes
        Me.btnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(70, 22)
        Me.btnFacturar.Text = "Facturar"
        '
        'LbDatos_Adicional_Factura
        '
        Me.LbDatos_Adicional_Factura.AutoSize = True
        Me.LbDatos_Adicional_Factura.BackColor = System.Drawing.Color.White
        Me.LbDatos_Adicional_Factura.ForeColor = System.Drawing.Color.Green
        Me.LbDatos_Adicional_Factura.Location = New System.Drawing.Point(415, 15)
        Me.LbDatos_Adicional_Factura.Name = "LbDatos_Adicional_Factura"
        Me.LbDatos_Adicional_Factura.Size = New System.Drawing.Size(126, 13)
        Me.LbDatos_Adicional_Factura.TabIndex = 78
        Me.LbDatos_Adicional_Factura.Text = "Datos_Adicional_Factura"
        '
        'LbDatos_Adicional_Factura_Ruc
        '
        Me.LbDatos_Adicional_Factura_Ruc.AutoSize = True
        Me.LbDatos_Adicional_Factura_Ruc.BackColor = System.Drawing.Color.White
        Me.LbDatos_Adicional_Factura_Ruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDatos_Adicional_Factura_Ruc.Location = New System.Drawing.Point(32, 63)
        Me.LbDatos_Adicional_Factura_Ruc.Name = "LbDatos_Adicional_Factura_Ruc"
        Me.LbDatos_Adicional_Factura_Ruc.Size = New System.Drawing.Size(246, 29)
        Me.LbDatos_Adicional_Factura_Ruc.TabIndex = 70
        Me.LbDatos_Adicional_Factura_Ruc.Text = "Numero_Datos_Ruc"
        '
        'frmVistaRefactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 589)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmVistaRefactura"
        Me.Text = "Refactura"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.tabFactura.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgCabeceraFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tabFactura As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumFact As System.Windows.Forms.Label
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgDetalleFactura As System.Windows.Forms.DataGridView
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtgCabeceraFactura As System.Windows.Forms.DataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSep_05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFacturar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents chkDescripcionManual As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cmbPlantaFacturar As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFactura As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbGiro As System.Windows.Forms.ComboBox
    Friend WithEvents txtTipoCambio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRegionVenta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPtoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPlantaCliente As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblArea As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents LbDatos_Adicional_Factura As System.Windows.Forms.Label
    Friend WithEvents LbDatos_Adicional_Factura_Ruc As System.Windows.Forms.Label
End Class
