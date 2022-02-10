<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsistencia))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HGDetalles = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnConsistencia = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnImprimir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtgConsistencia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.UcCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.cmbMoneda = New System.Windows.Forms.ComboBox
        Me.cmbDivision = New System.Windows.Forms.ComboBox
        Me.lblmoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblArea = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnBuscar = New System.Windows.Forms.PictureBox
        Me.cmbPlanta = New System.Windows.Forms.ComboBox
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New System.Windows.Forms.ComboBox
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.HGTotales = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtMonto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblMonto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRegistro = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDetalle = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.HGDetalleFacturar = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnProcesarFact = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnExportar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtgConsistenciaFactura = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HGDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGDetalles.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGDetalles.Panel.SuspendLayout()
        Me.HGDetalles.SuspendLayout()
        CType(Me.dtgConsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGFiltro.Panel.SuspendLayout()
        Me.HGFiltro.SuspendLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGTotales.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGTotales.Panel.SuspendLayout()
        Me.HGTotales.SuspendLayout()
        CType(Me.HGDetalleFacturar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGDetalleFacturar.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGDetalleFacturar.Panel.SuspendLayout()
        Me.HGDetalleFacturar.SuspendLayout()
        CType(Me.dtgConsistenciaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HGDetalles)
        Me.KryptonPanel.Controls.Add(Me.HGFiltro)
        Me.KryptonPanel.Controls.Add(Me.HGTotales)
        Me.KryptonPanel.Controls.Add(Me.HGDetalleFacturar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1014, 651)
        Me.KryptonPanel.TabIndex = 0
        '
        'HGDetalles
        '
        Me.HGDetalles.AllowButtonSpecToolTips = True
        Me.HGDetalles.AutoSize = True
        Me.HGDetalles.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnConsistencia, Me.btnImprimir})
        Me.HGDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGDetalles.Location = New System.Drawing.Point(0, 99)
        Me.HGDetalles.Name = "HGDetalles"
        '
        'HGDetalles.Panel
        '
        Me.HGDetalles.Panel.Controls.Add(Me.dtgConsistencia)
        Me.HGDetalles.Size = New System.Drawing.Size(1014, 485)
        Me.HGDetalles.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGDetalles.TabIndex = 76
        Me.HGDetalles.Text = "Consistencia para Factura"
        Me.HGDetalles.ValuesPrimary.Description = ""
        Me.HGDetalles.ValuesPrimary.Heading = "Consistencia para Factura"
        Me.HGDetalles.ValuesPrimary.Image = Nothing
        Me.HGDetalles.ValuesSecondary.Description = ""
        Me.HGDetalles.ValuesSecondary.Heading = ""
        Me.HGDetalles.ValuesSecondary.Image = Nothing
        '
        'btnConsistencia
        '
        Me.btnConsistencia.ExtraText = ""
        Me.btnConsistencia.Image = Global.SOLMIN_CT.My.Resources.Resources.ark_selectall
        Me.btnConsistencia.Text = "Consistenciar"
        Me.btnConsistencia.ToolTipImage = Nothing
        Me.btnConsistencia.UniqueName = "CB2DED2BCCB84A24CB2DED2BCCB84A24"
        '
        'btnImprimir
        '
        Me.btnImprimir.ExtraText = ""
        Me.btnImprimir.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.btnImprimir.Text = "Exportar"
        Me.btnImprimir.ToolTipImage = Nothing
        Me.btnImprimir.UniqueName = "054D0EB343E24E9F054D0EB343E24E9F"
        '
        'dtgConsistencia
        '
        Me.dtgConsistencia.AllowUserToAddRows = False
        Me.dtgConsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgConsistencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgConsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsistencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgConsistencia.Location = New System.Drawing.Point(0, 0)
        Me.dtgConsistencia.Name = "dtgConsistencia"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.dtgConsistencia.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgConsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgConsistencia.Size = New System.Drawing.Size(1012, 447)
        Me.dtgConsistencia.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgConsistencia.TabIndex = 61
        '
        'HGFiltro
        '
        Me.HGFiltro.AutoSize = True
        Me.HGFiltro.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HGFiltro.Name = "HGFiltro"
        '
        'HGFiltro.Panel
        '
        Me.HGFiltro.Panel.Controls.Add(Me.UcCliente)
        Me.HGFiltro.Panel.Controls.Add(Me.dtpInicio)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel4)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel5)
        Me.HGFiltro.Panel.Controls.Add(Me.dtpFin)
        Me.HGFiltro.Panel.Controls.Add(Me.cmbMoneda)
        Me.HGFiltro.Panel.Controls.Add(Me.cmbDivision)
        Me.HGFiltro.Panel.Controls.Add(Me.lblmoneda)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HGFiltro.Panel.Controls.Add(Me.lblArea)
        Me.HGFiltro.Panel.Controls.Add(Me.btnBuscar)
        Me.HGFiltro.Panel.Controls.Add(Me.cmbPlanta)
        Me.HGFiltro.Panel.Controls.Add(Me.lblPlanta)
        Me.HGFiltro.Panel.Controls.Add(Me.cmbCompania)
        Me.HGFiltro.Panel.Controls.Add(Me.lblCompania)
        Me.HGFiltro.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.HGFiltro.Size = New System.Drawing.Size(1014, 99)
        Me.HGFiltro.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGFiltro.TabIndex = 75
        Me.HGFiltro.Text = "Filtros"
        Me.HGFiltro.ValuesPrimary.Description = ""
        Me.HGFiltro.ValuesPrimary.Heading = "Filtros"
        Me.HGFiltro.ValuesPrimary.Image = Nothing
        Me.HGFiltro.ValuesSecondary.Description = ""
        Me.HGFiltro.ValuesSecondary.Heading = ""
        Me.HGFiltro.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup1.UniqueName = "B7D8AF6EA43E42F3B7D8AF6EA43E42F3"
        '
        'UcCliente
        '
        Me.UcCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente.BackColor = System.Drawing.Color.Transparent
        Me.UcCliente.CCMPN = "EZ"
        Me.UcCliente.Location = New System.Drawing.Point(70, 41)
        Me.UcCliente.Name = "UcCliente"
        Me.UcCliente.pAccesoPorUsuario = False
        Me.UcCliente.pRequerido = True
        Me.UcCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente.Size = New System.Drawing.Size(265, 22)
        Me.UcCliente.TabIndex = 63
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(704, 42)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(85, 20)
        Me.dtpInicio.TabIndex = 59
        Me.dtpInicio.Value = New Date(2008, 1, 1, 9, 55, 0, 0)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(796, 46)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(21, 20)
        Me.KryptonLabel4.TabIndex = 62
        Me.KryptonLabel4.Text = "Al"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Al"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(633, 46)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel5.TabIndex = 61
        Me.KryptonLabel5.Text = "Fecha :  Del"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Fecha :  Del"
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(822, 42)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(84, 20)
        Me.dtpFin.TabIndex = 60
        '
        'cmbMoneda
        '
        Me.cmbMoneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(410, 40)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(202, 22)
        Me.cmbMoneda.TabIndex = 50
        '
        'cmbDivision
        '
        Me.cmbDivision.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDivision.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(410, 8)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(202, 22)
        Me.cmbDivision.TabIndex = 20
        '
        'lblmoneda
        '
        Me.lblmoneda.Location = New System.Drawing.Point(357, 46)
        Me.lblmoneda.Name = "lblmoneda"
        Me.lblmoneda.Size = New System.Drawing.Size(62, 20)
        Me.lblmoneda.TabIndex = 35
        Me.lblmoneda.Text = "Moneda :"
        Me.lblmoneda.Values.ExtraText = ""
        Me.lblmoneda.Values.Image = Nothing
        Me.lblmoneda.Values.Text = "Moneda :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 46)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel1.TabIndex = 34
        Me.KryptonLabel1.Text = "Cliente :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente :"
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(357, 14)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(42, 20)
        Me.lblArea.TabIndex = 32
        Me.lblArea.Text = "Área :"
        Me.lblArea.Values.ExtraText = ""
        Me.lblArea.Values.Image = Nothing
        Me.lblArea.Values.Text = "Área :"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(929, 11)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(54, 51)
        Me.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.TabStop = False
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlanta.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.Location = New System.Drawing.Point(704, 8)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(202, 22)
        Me.cmbPlanta.TabIndex = 30
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(633, 14)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(50, 20)
        Me.lblPlanta.TabIndex = 13
        Me.lblPlanta.Text = "Planta :"
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta :"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompania.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbCompania.FormattingEnabled = True
        Me.cmbCompania.Location = New System.Drawing.Point(70, 8)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(265, 22)
        Me.cmbCompania.TabIndex = 10
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(5, 14)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(72, 20)
        Me.lblCompania.TabIndex = 12
        Me.lblCompania.Text = "Compañia :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia :"
        '
        'HGTotales
        '
        Me.HGTotales.AutoSize = True
        Me.HGTotales.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup2})
        Me.HGTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HGTotales.Location = New System.Drawing.Point(0, 584)
        Me.HGTotales.Name = "HGTotales"
        '
        'HGTotales.Panel
        '
        Me.HGTotales.Panel.Controls.Add(Me.txtMonto)
        Me.HGTotales.Panel.Controls.Add(Me.lblMonto)
        Me.HGTotales.Panel.Controls.Add(Me.txtRegistro)
        Me.HGTotales.Panel.Controls.Add(Me.lblDetalle)
        Me.HGTotales.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.HGTotales.Size = New System.Drawing.Size(1014, 67)
        Me.HGTotales.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGTotales.TabIndex = 73
        Me.HGTotales.Text = "Totales"
        Me.HGTotales.ValuesPrimary.Description = ""
        Me.HGTotales.ValuesPrimary.Heading = "Totales"
        Me.HGTotales.ValuesPrimary.Image = Nothing
        Me.HGTotales.ValuesSecondary.Description = ""
        Me.HGTotales.ValuesSecondary.Heading = ""
        Me.HGTotales.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup2
        '
        Me.ButtonSpecHeaderGroup2.ExtraText = ""
        Me.ButtonSpecHeaderGroup2.Image = Nothing
        Me.ButtonSpecHeaderGroup2.Text = ""
        Me.ButtonSpecHeaderGroup2.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecHeaderGroup2.UniqueName = "B7D8AF6EA43E42F3B7D8AF6EA43E42F3"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(790, 11)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(100, 22)
        Me.txtMonto.TabIndex = 15
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(716, 14)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(81, 20)
        Me.lblMonto.TabIndex = 14
        Me.lblMonto.Text = "Monto Total:"
        Me.lblMonto.Values.ExtraText = ""
        Me.lblMonto.Values.Image = Nothing
        Me.lblMonto.Values.Text = "Monto Total:"
        '
        'txtRegistro
        '
        Me.txtRegistro.Location = New System.Drawing.Point(589, 11)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black
        Me.txtRegistro.ReadOnly = True
        Me.txtRegistro.Size = New System.Drawing.Size(121, 22)
        Me.txtRegistro.TabIndex = 13
        '
        'lblDetalle
        '
        Me.lblDetalle.Location = New System.Drawing.Point(462, 14)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(130, 20)
        Me.lblDetalle.TabIndex = 12
        Me.lblDetalle.Text = "Cantidad de registros:"
        Me.lblDetalle.Values.ExtraText = ""
        Me.lblDetalle.Values.Image = Nothing
        Me.lblDetalle.Values.Text = "Cantidad de registros:"
        '
        'HGDetalleFacturar
        '
        Me.HGDetalleFacturar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HGDetalleFacturar.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnProcesarFact, Me.btnProcesar, Me.btnExportar, Me.btnCancelar, Me.btnActualizar})
        Me.HGDetalleFacturar.Location = New System.Drawing.Point(0, 0)
        Me.HGDetalleFacturar.Name = "HGDetalleFacturar"
        '
        'HGDetalleFacturar.Panel
        '
        Me.HGDetalleFacturar.Panel.Controls.Add(Me.dtgConsistenciaFactura)
        Me.HGDetalleFacturar.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.HGDetalleFacturar.Size = New System.Drawing.Size(1014, 685)
        Me.HGDetalleFacturar.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGDetalleFacturar.TabIndex = 72
        Me.HGDetalleFacturar.Text = "Consistencia para Factura"
        Me.HGDetalleFacturar.ValuesPrimary.Description = ""
        Me.HGDetalleFacturar.ValuesPrimary.Heading = "Consistencia para Factura"
        Me.HGDetalleFacturar.ValuesPrimary.Image = Nothing
        Me.HGDetalleFacturar.ValuesSecondary.Description = ""
        Me.HGDetalleFacturar.ValuesSecondary.Heading = ""
        Me.HGDetalleFacturar.ValuesSecondary.Image = Nothing
        '
        'btnProcesarFact
        '
        Me.btnProcesarFact.ExtraText = ""
        Me.btnProcesarFact.Image = CType(resources.GetObject("btnProcesarFact.Image"), System.Drawing.Image)
        Me.btnProcesarFact.Text = "Facturar"
        Me.btnProcesarFact.ToolTipImage = Nothing
        Me.btnProcesarFact.UniqueName = "96D1AB316A3445B896D1AB316A3445B8"
        '
        'btnProcesar
        '
        Me.btnProcesar.ExtraText = ""
        Me.btnProcesar.Image = Global.SOLMIN_CT.My.Resources.Resources.db_comit
        Me.btnProcesar.Text = "Pre-Facturar"
        Me.btnProcesar.ToolTipImage = Nothing
        Me.btnProcesar.UniqueName = "020A0D9E6168461E020A0D9E6168461E"
        '
        'btnExportar
        '
        Me.btnExportar.ExtraText = ""
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.ToolTipImage = Nothing
        Me.btnExportar.UniqueName = "63F8E093A8E5408663F8E093A8E54086"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "5DA50E5577FB40E05DA50E5577FB40E0"
        '
        'btnActualizar
        '
        Me.btnActualizar.ExtraText = ""
        Me.btnActualizar.Image = Global.SOLMIN_CT.My.Resources.Resources.agt_reload
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.ToolTipImage = Nothing
        Me.btnActualizar.UniqueName = "91B6DA094403441191B6DA0944034411"
        '
        'dtgConsistenciaFactura
        '
        Me.dtgConsistenciaFactura.AllowUserToAddRows = False
        Me.dtgConsistenciaFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgConsistenciaFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgConsistenciaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsistenciaFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgConsistenciaFactura.Location = New System.Drawing.Point(5, 5)
        Me.dtgConsistenciaFactura.Name = "dtgConsistenciaFactura"
        Me.dtgConsistenciaFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgConsistenciaFactura.Size = New System.Drawing.Size(1002, 637)
        Me.dtgConsistenciaFactura.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgConsistenciaFactura.TabIndex = 62
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(708, 14)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(73, 16)
        Me.KryptonLabel2.TabIndex = 14
        Me.KryptonLabel2.Text = "Monto Total:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Monto Total:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(472, 14)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(121, 16)
        Me.KryptonLabel3.TabIndex = 12
        Me.KryptonLabel3.Text = "Cantidad de registros:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Cantidad de registros:"
        '
        'frmConsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 651)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmConsistencia"
        Me.Text = "Consistencia"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.HGDetalles.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalles.Panel.ResumeLayout(False)
        CType(Me.HGDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalles.ResumeLayout(False)
        CType(Me.dtgConsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.Panel.ResumeLayout(False)
        Me.HGFiltro.Panel.PerformLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.ResumeLayout(False)
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HGTotales.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGTotales.Panel.ResumeLayout(False)
        Me.HGTotales.Panel.PerformLayout()
        CType(Me.HGTotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGTotales.ResumeLayout(False)
        CType(Me.HGDetalleFacturar.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalleFacturar.Panel.ResumeLayout(False)
        CType(Me.HGDetalleFacturar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalleFacturar.ResumeLayout(False)
        CType(Me.dtgConsistenciaFactura, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents HGDetalleFacturar As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents HGTotales As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtMonto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblMonto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRegistro As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDetalle As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents HGDetalles As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnConsistencia As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnImprimir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents HGFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDivision As System.Windows.Forms.ComboBox
    Friend WithEvents lblmoneda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblArea As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCompania As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnExportar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnProcesarFact As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents UcCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents dtgConsistencia As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtgConsistenciaFactura As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
