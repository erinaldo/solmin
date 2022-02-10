<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaReFactura
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
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnImprimirfactura = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelarImpr = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.tabFactura = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTipoDocumento = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNumFact = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dtgDetalleFactura = New System.Windows.Forms.DataGridView
        Me.dtgCabeceraFactura = New System.Windows.Forms.DataGridView
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnGenerar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtTipoCambio = New System.Windows.Forms.TextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPtoVenta = New System.Windows.Forms.ComboBox
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPlantaCliente = New System.Windows.Forms.ComboBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDivision = New System.Windows.Forms.TextBox
        Me.cmbGiro = New System.Windows.Forms.ComboBox
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
        Me.KryptonPanel.Size = New System.Drawing.Size(1008, 694)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnImprimirfactura, Me.btnCancelarImpr})
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 95)
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
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1008, 599)
        Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 85
        Me.KryptonHeaderGroup2.Text = "Factura"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Factura"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.ark_selectall
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'btnImprimirfactura
        '
        Me.btnImprimirfactura.ExtraText = ""
        Me.btnImprimirfactura.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.printer2
        Me.btnImprimirfactura.Text = "Imprimir"
        Me.btnImprimirfactura.ToolTipImage = Nothing
        Me.btnImprimirfactura.UniqueName = "0117C19070B8474B0117C19070B8474B"
        Me.btnImprimirfactura.Visible = False
        '
        'btnCancelarImpr
        '
        Me.btnCancelarImpr.ExtraText = ""
        Me.btnCancelarImpr.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_cancel
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
        Me.GroupBox2.Controls.Add(Me.lblTipoDocumento)
        Me.GroupBox2.Controls.Add(Me.lblNumFact)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(675, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 210)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.Location = New System.Drawing.Point(40, 100)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.ReadOnly = True
        Me.lblTipoDocumento.Size = New System.Drawing.Size(250, 35)
        Me.lblTipoDocumento.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.lblTipoDocumento.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.lblTipoDocumento.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.lblTipoDocumento.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipoDocumento.TabIndex = 70
        Me.lblTipoDocumento.Text = "FACTURA"
        Me.lblTipoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.LogoFactura
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
        Me.dtgDetalleFactura.Location = New System.Drawing.Point(13, 371)
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
        Me.dtgDetalleFactura.TabIndex = 62
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
        Me.dtgCabeceraFactura.Location = New System.Drawing.Point(6, 266)
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
        Me.dtgCabeceraFactura.TabIndex = 63
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnGenerar, Me.btnSalir})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTipoCambio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbPtoVenta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbPlantaCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbGiro)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblArea)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1008, 95)
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
        Me.btnGenerar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_ok1
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.ToolTipImage = Nothing
        Me.btnGenerar.UniqueName = "56B8AC41D362424156B8AC41D3624241"
        Me.btnGenerar.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources._exit
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "EEE9F0D9A4C04492EEE9F0D9A4C04492"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTipoCambio.Location = New System.Drawing.Point(375, 8)
        Me.txtTipoCambio.MaxLength = 15
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(67, 18)
        Me.txtTipoCambio.TabIndex = 64
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(279, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(103, 20)
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
        Me.cmbPtoVenta.Location = New System.Drawing.Point(113, 31)
        Me.cmbPtoVenta.Name = "cmbPtoVenta"
        Me.cmbPtoVenta.Size = New System.Drawing.Size(329, 22)
        Me.cmbPtoVenta.TabIndex = 62
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(8, 33)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(73, 20)
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
        Me.cmbPlantaCliente.Location = New System.Drawing.Point(575, 31)
        Me.cmbPlantaCliente.Name = "cmbPlantaCliente"
        Me.cmbPlantaCliente.Size = New System.Drawing.Size(406, 22)
        Me.cmbPlantaCliente.TabIndex = 60
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(468, 33)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel9.TabIndex = 59
        Me.KryptonLabel9.Text = "Planta Cliente :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Planta Cliente :"
        '
        'txtDivision
        '
        Me.txtDivision.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivision.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtDivision.Location = New System.Drawing.Point(113, 8)
        Me.txtDivision.MaxLength = 15
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.ReadOnly = True
        Me.txtDivision.Size = New System.Drawing.Size(160, 18)
        Me.txtDivision.TabIndex = 57
        Me.txtDivision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbGiro
        '
        Me.cmbGiro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbGiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGiro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGiro.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbGiro.FormattingEnabled = True
        Me.cmbGiro.Location = New System.Drawing.Point(575, 6)
        Me.cmbGiro.Name = "cmbGiro"
        Me.cmbGiro.Size = New System.Drawing.Size(242, 22)
        Me.cmbGiro.TabIndex = 20
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(468, 8)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(109, 20)
        Me.lblArea.TabIndex = 32
        Me.lblArea.Text = "Giro del Negocio :"
        Me.lblArea.Values.ExtraText = ""
        Me.lblArea.Values.Image = Nothing
        Me.lblArea.Values.Text = "Giro del Negocio :"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(8, 8)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(60, 20)
        Me.lblCompania.TabIndex = 12
        Me.lblCompania.Text = "División :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "División :"
        '
        'frmVistaReFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 694)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.Name = "frmVistaReFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vista Previa Factura"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
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
    Friend WithEvents txtDivision As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnImprimirfactura As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cmbPlantaCliente As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnGenerar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPtoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelarImpr As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tabFactura As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumFact As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents dtgDetalleFactura As System.Windows.Forms.DataGridView
    Friend WithEvents dtgCabeceraFactura As System.Windows.Forms.DataGridView
    Friend WithEvents lblTipoDocumento As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
