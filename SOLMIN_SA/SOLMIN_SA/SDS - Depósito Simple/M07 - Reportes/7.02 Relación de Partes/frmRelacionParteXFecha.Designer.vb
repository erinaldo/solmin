<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelacionParteXFecha
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.TabDetalle = New System.Windows.Forms.TabControl
        Me.tabIngreso = New System.Windows.Forms.TabPage
        Me.dgIngreso = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NPRTIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STPODP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoMov = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cclnt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tcmpcl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Detalle = New System.Windows.Forms.DataGridViewImageColumn
        Me.tabSalida = New System.Windows.Forms.TabPage
        Me.dgSalida = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NPRTIN2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STPODP2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoMov2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cclnt2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tcmpcl2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cantidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Detalle2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador_002 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGenerarReporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbDeposito = New System.Windows.Forms.ComboBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.txtNroParte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFecha = New System.Windows.Forms.DateTimePicker
        Me.lblFecha = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.tabIngreso.SuspendLayout()
        CType(Me.dgIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSalida.SuspendLayout()
        CType(Me.dgSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsReporte.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.TabDetalle)
        Me.KryptonPanel.Controls.Add(Me.tsReporte)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(826, 487)
        Me.KryptonPanel.TabIndex = 0
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.tabIngreso)
        Me.TabDetalle.Controls.Add(Me.tabSalida)
        Me.TabDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDetalle.Location = New System.Drawing.Point(0, 152)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.SelectedIndex = 0
        Me.TabDetalle.Size = New System.Drawing.Size(826, 335)
        Me.TabDetalle.TabIndex = 77
        '
        'tabIngreso
        '
        Me.tabIngreso.Controls.Add(Me.dgIngreso)
        Me.tabIngreso.Location = New System.Drawing.Point(4, 22)
        Me.tabIngreso.Name = "tabIngreso"
        Me.tabIngreso.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIngreso.Size = New System.Drawing.Size(818, 309)
        Me.tabIngreso.TabIndex = 0
        Me.tabIngreso.Text = "Ingreso"
        Me.tabIngreso.UseVisualStyleBackColor = True
        '
        'dgIngreso
        '
        Me.dgIngreso.AllowUserToAddRows = False
        Me.dgIngreso.AllowUserToDeleteRows = False
        Me.dgIngreso.AllowUserToResizeColumns = False
        Me.dgIngreso.AllowUserToResizeRows = False
        Me.dgIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgIngreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPRTIN, Me.STPODP, Me.TipoMov, Me.cclnt, Me.tcmpcl, Me.cantidad, Me.Detalle})
        Me.dgIngreso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgIngreso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgIngreso.Location = New System.Drawing.Point(3, 3)
        Me.dgIngreso.MultiSelect = False
        Me.dgIngreso.Name = "dgIngreso"
        Me.dgIngreso.ReadOnly = True
        Me.dgIngreso.RowHeadersWidth = 20
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgIngreso.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgIngreso.Size = New System.Drawing.Size(812, 303)
        Me.dgIngreso.StandardTab = True
        Me.dgIngreso.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgIngreso.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgIngreso.TabIndex = 67
        '
        'NPRTIN
        '
        Me.NPRTIN.DataPropertyName = "PNNPRTIN"
        Me.NPRTIN.HeaderText = "Nro. Parte"
        Me.NPRTIN.Name = "NPRTIN"
        Me.NPRTIN.ReadOnly = True
        Me.NPRTIN.Width = 89
        '
        'STPODP
        '
        Me.STPODP.DataPropertyName = "PSSTPODP"
        Me.STPODP.HeaderText = "Depósito"
        Me.STPODP.Name = "STPODP"
        Me.STPODP.ReadOnly = True
        Me.STPODP.Visible = False
        Me.STPODP.Width = 83
        '
        'TipoMov
        '
        Me.TipoMov.DataPropertyName = "PSCSRVC"
        Me.TipoMov.HeaderText = "Tipo"
        Me.TipoMov.Name = "TipoMov"
        Me.TipoMov.ReadOnly = True
        Me.TipoMov.Visible = False
        Me.TipoMov.Width = 60
        '
        'cclnt
        '
        Me.cclnt.DataPropertyName = "PNCCLNT"
        Me.cclnt.HeaderText = "Cod. Cliente"
        Me.cclnt.Name = "cclnt"
        Me.cclnt.ReadOnly = True
        Me.cclnt.Visible = False
        Me.cclnt.Width = 101
        '
        'tcmpcl
        '
        Me.tcmpcl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tcmpcl.DataPropertyName = "PSTCMPCL"
        Me.tcmpcl.HeaderText = "Cliente"
        Me.tcmpcl.Name = "tcmpcl"
        Me.tcmpcl.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "PNNPRTIN2"
        Me.cantidad.HeaderText = "# Guías"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 75
        '
        'Detalle
        '
        Me.Detalle.HeaderText = "..."
        Me.Detalle.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
        Me.Detalle.Name = "Detalle"
        Me.Detalle.ReadOnly = True
        Me.Detalle.Width = 26
        '
        'tabSalida
        '
        Me.tabSalida.Controls.Add(Me.dgSalida)
        Me.tabSalida.Location = New System.Drawing.Point(4, 22)
        Me.tabSalida.Name = "tabSalida"
        Me.tabSalida.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSalida.Size = New System.Drawing.Size(818, 309)
        Me.tabSalida.TabIndex = 1
        Me.tabSalida.Text = "Salida"
        Me.tabSalida.UseVisualStyleBackColor = True
        '
        'dgSalida
        '
        Me.dgSalida.AllowUserToAddRows = False
        Me.dgSalida.AllowUserToDeleteRows = False
        Me.dgSalida.AllowUserToResizeColumns = False
        Me.dgSalida.AllowUserToResizeRows = False
        Me.dgSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPRTIN2, Me.STPODP2, Me.TipoMov2, Me.cclnt2, Me.tcmpcl2, Me.cantidad2, Me.Detalle2})
        Me.dgSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSalida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgSalida.Location = New System.Drawing.Point(3, 3)
        Me.dgSalida.MultiSelect = False
        Me.dgSalida.Name = "dgSalida"
        Me.dgSalida.ReadOnly = True
        Me.dgSalida.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgSalida.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSalida.Size = New System.Drawing.Size(812, 303)
        Me.dgSalida.StandardTab = True
        Me.dgSalida.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgSalida.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgSalida.TabIndex = 68
        '
        'NPRTIN2
        '
        Me.NPRTIN2.DataPropertyName = "PNNPRTIN"
        Me.NPRTIN2.HeaderText = "Nro. Parte"
        Me.NPRTIN2.Name = "NPRTIN2"
        Me.NPRTIN2.ReadOnly = True
        Me.NPRTIN2.Width = 89
        '
        'STPODP2
        '
        Me.STPODP2.DataPropertyName = "PSSTPODP"
        Me.STPODP2.HeaderText = "Depósito"
        Me.STPODP2.Name = "STPODP2"
        Me.STPODP2.ReadOnly = True
        Me.STPODP2.Visible = False
        Me.STPODP2.Width = 83
        '
        'TipoMov2
        '
        Me.TipoMov2.DataPropertyName = "PSCSRVC"
        Me.TipoMov2.HeaderText = "Tipo"
        Me.TipoMov2.Name = "TipoMov2"
        Me.TipoMov2.ReadOnly = True
        Me.TipoMov2.Visible = False
        Me.TipoMov2.Width = 60
        '
        'cclnt2
        '
        Me.cclnt2.DataPropertyName = "PNCCLNT"
        Me.cclnt2.HeaderText = "Cod. Cliente"
        Me.cclnt2.Name = "cclnt2"
        Me.cclnt2.ReadOnly = True
        Me.cclnt2.Visible = False
        Me.cclnt2.Width = 101
        '
        'tcmpcl2
        '
        Me.tcmpcl2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tcmpcl2.DataPropertyName = "PSTCMPCL"
        Me.tcmpcl2.HeaderText = "Cliente"
        Me.tcmpcl2.Name = "tcmpcl2"
        Me.tcmpcl2.ReadOnly = True
        '
        'cantidad2
        '
        Me.cantidad2.DataPropertyName = "PNNPRTIN2"
        Me.cantidad2.HeaderText = "# Guías"
        Me.cantidad2.Name = "cantidad2"
        Me.cantidad2.ReadOnly = True
        Me.cantidad2.Width = 75
        '
        'Detalle2
        '
        Me.Detalle2.HeaderText = "..."
        Me.Detalle2.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
        Me.Detalle2.Name = "Detalle2"
        Me.Detalle2.ReadOnly = True
        Me.Detalle2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Detalle2.Width = 45
        '
        'tsReporte
        '
        Me.tsReporte.AccessibleDescription = "<"
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarExcel, Me.tssSeparador_002, Me.tsbImprimir, Me.ToolStripSeparator1, Me.tsbGenerarReporte, Me.ToolStripSeparator2})
        Me.tsReporte.Location = New System.Drawing.Point(0, 126)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(826, 26)
        Me.tsReporte.TabIndex = 58
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.Enabled = False
        Me.tsbExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(102, 23)
        Me.tsbExportarExcel.Text = "Exportar Excel"
        '
        'tssSeparador_002
        '
        Me.tssSeparador_002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_002.Name = "tssSeparador_002"
        Me.tssSeparador_002.Size = New System.Drawing.Size(6, 26)
        '
        'tsbImprimir
        '
        Me.tsbImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbImprimir.Enabled = False
        Me.tsbImprimir.Image = Global.SOLMIN_SA.My.Resources.Resources.ico_impresora
        Me.tsbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(134, 23)
        Me.tsbImprimir.Text = "Imprimir Certificado"
        Me.tsbImprimir.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'tsbGenerarReporte
        '
        Me.tsbGenerarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGenerarReporte.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.tsbGenerarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarReporte.Name = "tsbGenerarReporte"
        Me.tsbGenerarReporte.Size = New System.Drawing.Size(62, 23)
        Me.tsbGenerarReporte.Text = "Buscar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.cmbDeposito)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroParte)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFecha)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFecha)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(826, 126)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 57
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaOcultarFiltros
        '
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.ToolTipImage = Nothing
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'cmbDeposito
        '
        Me.cmbDeposito.FormattingEnabled = True
        Me.cmbDeposito.Location = New System.Drawing.Point(447, 11)
        Me.cmbDeposito.Name = "cmbDeposito"
        Me.cmbDeposito.Size = New System.Drawing.Size(252, 21)
        Me.cmbDeposito.TabIndex = 75
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(33, 41)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel3.TabIndex = 74
        Me.KryptonLabel3.Text = "Cliente : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Cliente : "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(87, 39)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(252, 22)
        Me.txtCliente.TabIndex = 73
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(87, 11)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(252, 31)
        Me.UcCompania_Cmb011.TabIndex = 72
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'txtNroParte
        '
        Me.txtNroParte.Location = New System.Drawing.Point(87, 65)
        Me.txtNroParte.Name = "txtNroParte"
        Me.txtNroParte.Size = New System.Drawing.Size(252, 22)
        Me.txtNroParte.TabIndex = 71
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(15, 63)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel2.TabIndex = 70
        Me.KryptonLabel2.Text = "Nro. Parte : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nro. Parte : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(367, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel1.TabIndex = 69
        Me.KryptonLabel1.Text = "Déposito : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Déposito : "
        '
        'dteFecha
        '
        Me.dteFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFecha.Location = New System.Drawing.Point(447, 37)
        Me.dteFecha.Name = "dteFecha"
        Me.dteFecha.Size = New System.Drawing.Size(94, 20)
        Me.dteFecha.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(367, 39)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 20)
        Me.lblFecha.TabIndex = 65
        Me.lblFecha.Text = "Fecha : "
        Me.lblFecha.Values.ExtraText = ""
        Me.lblFecha.Values.Image = Nothing
        Me.lblFecha.Values.Text = "Fecha : "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(15, 15)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Compañía : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañía : "
        '
        'frmRelacionParteXFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 487)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmRelacionParteXFecha"
        Me.Text = "Relación de Partes por Fecha"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.TabDetalle.ResumeLayout(False)
        Me.tabIngreso.ResumeLayout(False)
        CType(Me.dgIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSalida.ResumeLayout(False)
        CType(Me.dgSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtNroParte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents cmbDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabDetalle As System.Windows.Forms.TabControl
    Friend WithEvents tabIngreso As System.Windows.Forms.TabPage
    Friend WithEvents dgIngreso As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tabSalida As System.Windows.Forms.TabPage
    Friend WithEvents dgSalida As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGenerarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NPRTIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPODP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cclnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tcmpcl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detalle As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NPRTIN2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPODP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoMov2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cclnt2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tcmpcl2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detalle2 As System.Windows.Forms.DataGridViewImageColumn
End Class
