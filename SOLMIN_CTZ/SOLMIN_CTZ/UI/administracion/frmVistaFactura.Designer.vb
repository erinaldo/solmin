<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaFactura
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnImprimirfactura = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelarImpr = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.tabFactura = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblNumFact = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dtgDetalleFactura = New System.Windows.Forms.DataGridView
        Me.dtgCabeceraFactura = New System.Windows.Forms.DataGridView
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnGenerar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbPlantaFacturar = New System.Windows.Forms.ComboBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblError = New System.Windows.Forms.Label
        Me.dtpFechaFac = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbGiro = New System.Windows.Forms.ComboBox
        Me.txtDivision = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTipoCambio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRegionVenta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPtoVenta = New System.Windows.Forms.ComboBox
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPlantaCliente = New System.Windows.Forms.ComboBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblArea = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.tabFactura.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgCabeceraFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1006, 694)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnImprimirfactura, Me.btnCancelarImpr})
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 163)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.tabFactura)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.GroupBox2)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.PictureBox1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dtgDetalleFactura)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dtgCabeceraFactura)
        Me.KryptonHeaderGroup2.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1006, 531)
        Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 85
        Me.KryptonHeaderGroup2.Text = "Factura"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Factura"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Global.SOLMIN_CT.My.Resources.Resources.ark_selectall
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'btnImprimirfactura
        '
        Me.btnImprimirfactura.ExtraText = ""
        Me.btnImprimirfactura.Image = Global.SOLMIN_CT.My.Resources.Resources.printer11
        Me.btnImprimirfactura.Text = "Imprimir"
        Me.btnImprimirfactura.ToolTipImage = Nothing
        Me.btnImprimirfactura.UniqueName = "0117C19070B8474B0117C19070B8474B"
        Me.btnImprimirfactura.Visible = False
        '
        'btnCancelarImpr
        '
        Me.btnCancelarImpr.ExtraText = ""
        Me.btnCancelarImpr.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.btnCancelarImpr.Text = "Cancelar"
        Me.btnCancelarImpr.ToolTipImage = Nothing
        Me.btnCancelarImpr.UniqueName = "4E01EB15DAF548A04E01EB15DAF548A0"
        Me.btnCancelarImpr.Visible = False
        '
        'tabFactura
        '
        Me.tabFactura.Controls.Add(Me.TabPage1)
        Me.tabFactura.Location = New System.Drawing.Point(6, 236)
        Me.tabFactura.Name = "tabFactura"
        Me.tabFactura.SelectedIndex = 0
        Me.tabFactura.Size = New System.Drawing.Size(992, 337)
        Me.tabFactura.TabIndex = 73
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(984, 311)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.lblNumFact)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(675, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 210)
        Me.GroupBox2.TabIndex = 72
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 29)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "R.U.C.: 20100039207"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SOLMIN_CT.My.Resources.Resources.LogoFactura
        Me.PictureBox1.Location = New System.Drawing.Point(11, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(622, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 111)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
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
        'dtgDetalleFactura
        '
        Me.dtgDetalleFactura.AllowUserToAddRows = False
        Me.dtgDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgDetalleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDetalleFactura.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalleFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dtgDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalleFactura.DefaultCellStyle = DataGridViewCellStyle10
        Me.dtgDetalleFactura.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgDetalleFactura.Location = New System.Drawing.Point(13, 371)
        Me.dtgDetalleFactura.Name = "dtgDetalleFactura"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDetalleFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dtgDetalleFactura.RowHeadersWidth = 20
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetalleFactura.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dtgDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDetalleFactura.Size = New System.Drawing.Size(985, 187)
        Me.dtgDetalleFactura.TabIndex = 62
        '
        'dtgCabeceraFactura
        '
        Me.dtgCabeceraFactura.AllowUserToAddRows = False
        Me.dtgCabeceraFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCabeceraFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgCabeceraFactura.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCabeceraFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dtgCabeceraFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCabeceraFactura.DefaultCellStyle = DataGridViewCellStyle14
        Me.dtgCabeceraFactura.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dtgCabeceraFactura.Location = New System.Drawing.Point(6, 266)
        Me.dtgCabeceraFactura.Name = "dtgCabeceraFactura"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCabeceraFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dtgCabeceraFactura.RowHeadersWidth = 20
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgCabeceraFactura.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dtgCabeceraFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgCabeceraFactura.Size = New System.Drawing.Size(992, 99)
        Me.dtgCabeceraFactura.TabIndex = 63
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnGenerar, Me.btnSalir})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbPlantaFacturar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblError)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaFac)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFechaFactura)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbGiro)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTipoCambio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtRegionVenta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbPtoVenta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbPlantaCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblArea)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1006, 163)
        Me.KryptonHeaderGroup1.StateDisabled.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 84
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnGenerar
        '
        Me.btnGenerar.ExtraText = ""
        Me.btnGenerar.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_billetes
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.ToolTipImage = Nothing
        Me.btnGenerar.UniqueName = "56B8AC41D362424156B8AC41D3624241"
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "EEE9F0D9A4C04492EEE9F0D9A4C04492"
        '
        'cmbPlantaFacturar
        '
        Me.cmbPlantaFacturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPlantaFacturar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlantaFacturar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlantaFacturar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbPlantaFacturar.FormattingEnabled = True
        Me.cmbPlantaFacturar.Location = New System.Drawing.Point(119, 34)
        Me.cmbPlantaFacturar.Name = "cmbPlantaFacturar"
        Me.cmbPlantaFacturar.Size = New System.Drawing.Size(293, 22)
        Me.cmbPlantaFacturar.TabIndex = 73
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(17, 36)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(99, 19)
        Me.KryptonLabel3.TabIndex = 74
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
        Me.lblError.Location = New System.Drawing.Point(435, 90)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(261, 30)
        Me.lblError.TabIndex = 72
        Me.lblError.Text = "* No se puede generar la factura por " & Global.Microsoft.VisualBasic.ChrW(10) & " no existir tipo de cambio para la fecha "
        Me.lblError.Visible = False
        '
        'dtpFechaFac
        '
        Me.dtpFechaFac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFac.Location = New System.Drawing.Point(119, 88)
        Me.dtpFechaFac.Name = "dtpFechaFac"
        Me.dtpFechaFac.Size = New System.Drawing.Size(111, 20)
        Me.dtpFechaFac.TabIndex = 70
        Me.dtpFechaFac.Visible = False
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.Location = New System.Drawing.Point(17, 88)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(84, 19)
        Me.lblFechaFactura.TabIndex = 69
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
        Me.cmbGiro.Location = New System.Drawing.Point(540, 35)
        Me.cmbGiro.Name = "cmbGiro"
        Me.cmbGiro.Size = New System.Drawing.Size(293, 22)
        Me.cmbGiro.TabIndex = 20
        '
        'txtDivision
        '
        Me.txtDivision.Location = New System.Drawing.Point(119, 8)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.ReadOnly = True
        Me.txtDivision.Size = New System.Drawing.Size(293, 21)
        Me.txtDivision.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDivision.TabIndex = 68
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(759, 6)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(140, 21)
        Me.txtTipoCambio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoCambio.TabIndex = 67
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(438, 10)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(83, 19)
        Me.KryptonLabel2.TabIndex = 66
        Me.KryptonLabel2.Text = "Region Venta :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Region Venta :"
        '
        'txtRegionVenta
        '
        Me.txtRegionVenta.Location = New System.Drawing.Point(540, 8)
        Me.txtRegionVenta.Name = "txtRegionVenta"
        Me.txtRegionVenta.ReadOnly = True
        Me.txtRegionVenta.Size = New System.Drawing.Size(112, 21)
        Me.txtRegionVenta.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRegionVenta.TabIndex = 65
        Me.txtRegionVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(658, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(95, 19)
        Me.KryptonLabel1.TabIndex = 63
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
        Me.cmbPtoVenta.Location = New System.Drawing.Point(119, 61)
        Me.cmbPtoVenta.Name = "cmbPtoVenta"
        Me.cmbPtoVenta.Size = New System.Drawing.Size(293, 22)
        Me.cmbPtoVenta.TabIndex = 62
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(17, 62)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel10.TabIndex = 61
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
        Me.cmbPlantaCliente.Location = New System.Drawing.Point(540, 63)
        Me.cmbPlantaCliente.Name = "cmbPlantaCliente"
        Me.cmbPlantaCliente.Size = New System.Drawing.Size(293, 22)
        Me.cmbPlantaCliente.TabIndex = 60
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(438, 67)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(84, 19)
        Me.KryptonLabel9.TabIndex = 59
        Me.KryptonLabel9.Text = "Planta Cliente :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Planta Cliente :"
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(438, 40)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(101, 19)
        Me.lblArea.TabIndex = 32
        Me.lblArea.Text = "Giro del Negocio :"
        Me.lblArea.Values.ExtraText = ""
        Me.lblArea.Values.Image = Nothing
        Me.lblArea.Values.Text = "Giro del Negocio :"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(17, 10)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(55, 19)
        Me.lblCompania.TabIndex = 12
        Me.lblCompania.Text = "División :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "División :"
        '
        'frmVistaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 694)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.Name = "frmVistaFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vista Previa Factura"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        Me.tabFactura.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgCabeceraFactura, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cmbGiro As System.Windows.Forms.ComboBox
    Friend WithEvents lblArea As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnImprimirfactura As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgDetalleFactura As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cmbPlantaCliente As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnGenerar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgCabeceraFactura As System.Windows.Forms.DataGridView
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPtoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelarImpr As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents tabFactura As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblNumFact As System.Windows.Forms.Label
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRegionVenta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTipoCambio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDivision As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblFechaFactura As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaFac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents cmbPlantaFacturar As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
