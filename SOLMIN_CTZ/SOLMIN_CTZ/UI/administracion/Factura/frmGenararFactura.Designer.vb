<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenararFactura
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.LbDatos_Adicional_Factura = New System.Windows.Forms.Label
        Me.tabFactura = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblNumFact = New System.Windows.Forms.Label
        Me.LbDatos_Adicional_Factura_Ruc = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtgDetalleFactura = New System.Windows.Forms.DataGridView
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dtgCabeceraFactura = New System.Windows.Forms.DataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.tsSep_05 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_04 = New System.Windows.Forms.ToolStripSeparator
        Me.btnFacturar = New System.Windows.Forms.ToolStripButton
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
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.tabFactura.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgCabeceraFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
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
        Me.KryptonPanel.Size = New System.Drawing.Size(1006, 750)
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
        Me.KryptonPanel1.Size = New System.Drawing.Size(1006, 600)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 88
        '
        'LbDatos_Adicional_Factura
        '
        Me.LbDatos_Adicional_Factura.AutoSize = True
        Me.LbDatos_Adicional_Factura.BackColor = System.Drawing.Color.White
        Me.LbDatos_Adicional_Factura.ForeColor = System.Drawing.Color.Green
        Me.LbDatos_Adicional_Factura.Location = New System.Drawing.Point(415, 15)
        Me.LbDatos_Adicional_Factura.Name = "LbDatos_Adicional_Factura"
        Me.LbDatos_Adicional_Factura.Size = New System.Drawing.Size(126, 13)
        Me.LbDatos_Adicional_Factura.TabIndex = 80
        Me.LbDatos_Adicional_Factura.Text = "Datos_Adicional_Factura"
        '
        'tabFactura
        '
        Me.tabFactura.Controls.Add(Me.TabPage1)
        Me.tabFactura.Location = New System.Drawing.Point(11, 226)
        Me.tabFactura.Name = "tabFactura"
        Me.tabFactura.SelectedIndex = 0
        Me.tabFactura.Size = New System.Drawing.Size(992, 377)
        Me.tabFactura.TabIndex = 75
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(984, 351)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.lblNumFact)
        Me.GroupBox2.Controls.Add(Me.LbDatos_Adicional_Factura_Ruc)
        Me.GroupBox2.Controls.Add(Me.Label2)
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
        'LbDatos_Adicional_Factura_Ruc
        '
        Me.LbDatos_Adicional_Factura_Ruc.AutoSize = True
        Me.LbDatos_Adicional_Factura_Ruc.BackColor = System.Drawing.Color.White
        Me.LbDatos_Adicional_Factura_Ruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDatos_Adicional_Factura_Ruc.Location = New System.Drawing.Point(32, 63)
        Me.LbDatos_Adicional_Factura_Ruc.Name = "LbDatos_Adicional_Factura_Ruc"
        Me.LbDatos_Adicional_Factura_Ruc.Size = New System.Drawing.Size(246, 29)
        Me.LbDatos_Adicional_Factura_Ruc.TabIndex = 67
        Me.LbDatos_Adicional_Factura_Ruc.Text = "Numero_Datos_Ruc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 29)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "FACTURA"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalleFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalleFactura.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgDetalleFactura.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgDetalleFactura.Location = New System.Drawing.Point(7, 274)
        Me.dtgDetalleFactura.Name = "dtgDetalleFactura"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDetalleFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgDetalleFactura.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetalleFactura.RowsDefaultCellStyle = DataGridViewCellStyle4
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SOLMIN_CT.My.Resources.Resources.LogoFactura4
        Me.PictureBox1.Location = New System.Drawing.Point(21, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'dtgCabeceraFactura
        '
        Me.dtgCabeceraFactura.AllowUserToAddRows = False
        Me.dtgCabeceraFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCabeceraFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgCabeceraFactura.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCabeceraFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgCabeceraFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCabeceraFactura.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgCabeceraFactura.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgCabeceraFactura.Location = New System.Drawing.Point(12, 257)
        Me.dtgCabeceraFactura.Name = "dtgCabeceraFactura"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCabeceraFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgCabeceraFactura.RowHeadersWidth = 20
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgCabeceraFactura.RowsDefaultCellStyle = DataGridViewCellStyle8
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
        Me.tsMenuOpciones.Size = New System.Drawing.Size(1006, 25)
        Me.tsMenuOpciones.TabIndex = 87
        '
        'tsSep_05
        '
        Me.tsSep_05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep_05.Name = "tsSep_05"
        Me.tsSep_05.Size = New System.Drawing.Size(6, 25)
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
        'tssSep_04
        '
        Me.tssSep_04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_04.Name = "tssSep_04"
        Me.tssSep_04.Size = New System.Drawing.Size(6, 25)
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
        Me.KryptonPanel2.Size = New System.Drawing.Size(1006, 125)
        Me.KryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel2.TabIndex = 86
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
        Me.lblError.Text = "* No se puede generar la factura por " & Global.Microsoft.VisualBasic.ChrW(10) & " no existir tipo de cambio para la fecha "
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
        Me.KryptonLabel2.Text = "Region Venta :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Region Venta :"
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
        'frmGenararFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 750)
        Me.Controls.Add(Me.KryptonPanel)
        Me.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.Name = "frmGenararFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generar  Factura"
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgCabeceraFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumFact As System.Windows.Forms.Label
    Friend WithEvents LbDatos_Adicional_Factura_Ruc As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSep_05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFacturar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tabFactura As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dtgCabeceraFactura As System.Windows.Forms.DataGridView
    Friend WithEvents dtgDetalleFactura As System.Windows.Forms.DataGridView
    Friend WithEvents chkDescripcionManual As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents LbDatos_Adicional_Factura As System.Windows.Forms.Label
End Class
