<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWPreFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWPreFactura))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaGrabar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaSeleccionar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaNoSeleccionar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgvPreFactura = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.NROTCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORDSRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPOATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CSRVNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NHRFACDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FATNSRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstprefactura = New System.Data.DataSet
        Me.dtdatos = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.lblcodrubro = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoServicioListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblinicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblHasta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFechaFin = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtFechaInicio = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblcodcliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaClienteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.dgvPreFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstprefactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(892, 480)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaGrabar, Me.bsaSeleccionar, Me.bsaNoSeleccionar})
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 129)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dgvPreFactura)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(892, 351)
        Me.KryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.Text = "Lista"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Lista"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'bsaGrabar
        '
        Me.bsaGrabar.ExtraText = ""
        Me.bsaGrabar.Image = CType(resources.GetObject("bsaGrabar.Image"), System.Drawing.Image)
        Me.bsaGrabar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaGrabar.Text = "Grabar"
        Me.bsaGrabar.ToolTipImage = Nothing
        Me.bsaGrabar.UniqueName = "CF6057B11B7F4D67CF6057B11B7F4D67"
        '
        'bsaSeleccionar
        '
        Me.bsaSeleccionar.ExtraText = ""
        Me.bsaSeleccionar.Image = CType(resources.GetObject("bsaSeleccionar.Image"), System.Drawing.Image)
        Me.bsaSeleccionar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaSeleccionar.Text = "Marcar"
        Me.bsaSeleccionar.ToolTipImage = Nothing
        Me.bsaSeleccionar.UniqueName = "8B50CCB547964B378B50CCB547964B37"
        '
        'bsaNoSeleccionar
        '
        Me.bsaNoSeleccionar.ExtraText = ""
        Me.bsaNoSeleccionar.Image = CType(resources.GetObject("bsaNoSeleccionar.Image"), System.Drawing.Image)
        Me.bsaNoSeleccionar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaNoSeleccionar.Text = "Desmarcar"
        Me.bsaNoSeleccionar.ToolTipImage = Nothing
        Me.bsaNoSeleccionar.UniqueName = "DB5EE711250E48A3DB5EE711250E48A3"
        '
        'dgvPreFactura
        '
        Me.dgvPreFactura.AllowUserToAddRows = False
        Me.dgvPreFactura.AllowUserToDeleteRows = False
        Me.dgvPreFactura.AllowUserToResizeColumns = False
        Me.dgvPreFactura.AllowUserToResizeRows = False
        Me.dgvPreFactura.AutoGenerateColumns = False
        Me.dgvPreFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPreFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.NROTCKDataGridViewTextBoxColumn, Me.NORDSRDataGridViewTextBoxColumn, Me.CTPOATDataGridViewTextBoxColumn, Me.CSRVNVDataGridViewTextBoxColumn, Me.TCMTRFDataGridViewTextBoxColumn, Me.NHRFACDataGridViewTextBoxColumn, Me.FATNSRDataGridViewTextBoxColumn, Me.CALMCDataGridViewTextBoxColumn})
        Me.dgvPreFactura.DataMember = "dtdatos"
        Me.dgvPreFactura.DataSource = Me.dstprefactura
        Me.dgvPreFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPreFactura.Location = New System.Drawing.Point(0, 0)
        Me.dgvPreFactura.Name = "dgvPreFactura"
        Me.dgvPreFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPreFactura.Size = New System.Drawing.Size(890, 318)
        Me.dgvPreFactura.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvPreFactura.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvPreFactura.TabIndex = 0
        '
        'CHK
        '
        Me.CHK.FalseValue = "-"
        Me.CHK.HeaderText = "Chk"
        Me.CHK.Name = "CHK"
        Me.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CHK.TrueValue = "X"
        Me.CHK.Width = 56
        '
        'NROTCKDataGridViewTextBoxColumn
        '
        Me.NROTCKDataGridViewTextBoxColumn.DataPropertyName = "NROTCK"
        Me.NROTCKDataGridViewTextBoxColumn.HeaderText = "N° Ticket"
        Me.NROTCKDataGridViewTextBoxColumn.Name = "NROTCKDataGridViewTextBoxColumn"
        Me.NROTCKDataGridViewTextBoxColumn.Width = 80
        '
        'NORDSRDataGridViewTextBoxColumn
        '
        Me.NORDSRDataGridViewTextBoxColumn.DataPropertyName = "NORDSR"
        Me.NORDSRDataGridViewTextBoxColumn.HeaderText = "N° Orden"
        Me.NORDSRDataGridViewTextBoxColumn.Name = "NORDSRDataGridViewTextBoxColumn"
        Me.NORDSRDataGridViewTextBoxColumn.Width = 84
        '
        'CTPOATDataGridViewTextBoxColumn
        '
        Me.CTPOATDataGridViewTextBoxColumn.DataPropertyName = "CTPOAT"
        Me.CTPOATDataGridViewTextBoxColumn.HeaderText = "Tipo I/S"
        Me.CTPOATDataGridViewTextBoxColumn.Name = "CTPOATDataGridViewTextBoxColumn"
        Me.CTPOATDataGridViewTextBoxColumn.Width = 74
        '
        'CSRVNVDataGridViewTextBoxColumn
        '
        Me.CSRVNVDataGridViewTextBoxColumn.DataPropertyName = "CSRVNV"
        Me.CSRVNVDataGridViewTextBoxColumn.HeaderText = "Cod Servicio"
        Me.CSRVNVDataGridViewTextBoxColumn.Name = "CSRVNVDataGridViewTextBoxColumn"
        Me.CSRVNVDataGridViewTextBoxColumn.Width = 99
        '
        'TCMTRFDataGridViewTextBoxColumn
        '
        Me.TCMTRFDataGridViewTextBoxColumn.DataPropertyName = "TCMTRF"
        Me.TCMTRFDataGridViewTextBoxColumn.HeaderText = "Descripción del Servicio"
        Me.TCMTRFDataGridViewTextBoxColumn.Name = "TCMTRFDataGridViewTextBoxColumn"
        Me.TCMTRFDataGridViewTextBoxColumn.Width = 157
        '
        'NHRFACDataGridViewTextBoxColumn
        '
        Me.NHRFACDataGridViewTextBoxColumn.DataPropertyName = "NHRFAC"
        Me.NHRFACDataGridViewTextBoxColumn.HeaderText = "Horas"
        Me.NHRFACDataGridViewTextBoxColumn.Name = "NHRFACDataGridViewTextBoxColumn"
        Me.NHRFACDataGridViewTextBoxColumn.Width = 66
        '
        'FATNSRDataGridViewTextBoxColumn
        '
        Me.FATNSRDataGridViewTextBoxColumn.DataPropertyName = "FATNSR"
        Me.FATNSRDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FATNSRDataGridViewTextBoxColumn.Name = "FATNSRDataGridViewTextBoxColumn"
        Me.FATNSRDataGridViewTextBoxColumn.Width = 66
        '
        'CALMCDataGridViewTextBoxColumn
        '
        Me.CALMCDataGridViewTextBoxColumn.DataPropertyName = "CALMC"
        Me.CALMCDataGridViewTextBoxColumn.HeaderText = "Almacen"
        Me.CALMCDataGridViewTextBoxColumn.Name = "CALMCDataGridViewTextBoxColumn"
        Me.CALMCDataGridViewTextBoxColumn.Visible = False
        Me.CALMCDataGridViewTextBoxColumn.Width = 77
        '
        'dstprefactura
        '
        Me.dstprefactura.DataSetName = "dstprefactura"
        Me.dstprefactura.Tables.AddRange(New System.Data.DataTable() {Me.dtdatos})
        '
        'dtdatos
        '
        Me.dtdatos.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
        Me.dtdatos.TableName = "dtdatos"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "NROTCK"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "NORDSR"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CTPOAT"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "TCMTRF"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "NHRFAC"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CSRVNV"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "FATNSR"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "CALMC"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblcodrubro)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTipoServicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblinicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblHasta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFechaFin)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFechaInicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnActualizar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblcodcliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(892, 129)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.StateCommon.HeaderSecondary.Content.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Consulta"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Consulta"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'lblcodrubro
        '
        Me.lblcodrubro.Location = New System.Drawing.Point(67, 49)
        Me.lblcodrubro.Name = "lblcodrubro"
        Me.lblcodrubro.Size = New System.Drawing.Size(16, 19)
        Me.lblcodrubro.TabIndex = 83
        Me.lblcodrubro.Text = "0"
        Me.lblcodrubro.Values.ExtraText = ""
        Me.lblcodrubro.Values.Image = Nothing
        Me.lblcodrubro.Values.Text = "0"
        '
        'txtTipoServicio
        '
        Me.txtTipoServicio.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoServicioListar})
        Me.txtTipoServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoServicio.Location = New System.Drawing.Point(115, 47)
        Me.txtTipoServicio.MaxLength = 50
        Me.txtTipoServicio.Name = "txtTipoServicio"
        Me.txtTipoServicio.Size = New System.Drawing.Size(232, 21)
        Me.txtTipoServicio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoServicio.TabIndex = 82
        '
        'bsaTipoServicioListar
        '
        Me.bsaTipoServicioListar.ExtraText = ""
        Me.bsaTipoServicioListar.Image = Nothing
        Me.bsaTipoServicioListar.Text = ""
        Me.bsaTipoServicioListar.ToolTipImage = Nothing
        Me.bsaTipoServicioListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoServicioListar.UniqueName = "A81EDC60E5B049C0A81EDC60E5B049C0"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 49)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(54, 19)
        Me.KryptonLabel2.TabIndex = 53
        Me.KryptonLabel2.Text = "Servicio : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Servicio : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.KryptonLabel12)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(683, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(111, 66)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leyenda"
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(36, 42)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel12.TabIndex = 20
        Me.KryptonLabel12.Text = "Opcional"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Opcional"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(36, 18)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel13.TabIndex = 18
        Me.KryptonLabel13.Text = "Obligatorio"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Obligatorio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "   "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "   "
        '
        'lblinicio
        '
        Me.lblinicio.Location = New System.Drawing.Point(33, 76)
        Me.lblinicio.Name = "lblinicio"
        Me.lblinicio.Size = New System.Drawing.Size(26, 19)
        Me.lblinicio.TabIndex = 50
        Me.lblinicio.Text = "De:"
        Me.lblinicio.Values.ExtraText = ""
        Me.lblinicio.Values.Image = Nothing
        Me.lblinicio.Values.Text = "De:"
        '
        'lblHasta
        '
        Me.lblHasta.Location = New System.Drawing.Point(203, 77)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(41, 19)
        Me.lblHasta.TabIndex = 48
        Me.lblHasta.Text = "Hasta:"
        Me.lblHasta.Values.ExtraText = ""
        Me.lblHasta.Values.Image = Nothing
        Me.lblHasta.Values.Text = "Hasta:"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaFin.Location = New System.Drawing.Point(252, 74)
        Me.txtFechaFin.Mask = "##/##/####"
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaFin.Size = New System.Drawing.Size(95, 21)
        Me.txtFechaFin.TabIndex = 49
        Me.txtFechaFin.Text = "  /  /"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaInicio.Location = New System.Drawing.Point(115, 75)
        Me.txtFechaInicio.Mask = "##/##/####"
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaInicio.Size = New System.Drawing.Size(82, 21)
        Me.txtFechaInicio.TabIndex = 47
        Me.txtFechaInicio.Text = "  /  /"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(811, 21)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 72)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 46
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'lblcodcliente
        '
        Me.lblcodcliente.Location = New System.Drawing.Point(67, 20)
        Me.lblcodcliente.Name = "lblcodcliente"
        Me.lblcodcliente.Size = New System.Drawing.Size(16, 19)
        Me.lblcodcliente.TabIndex = 45
        Me.lblcodcliente.Text = "0"
        Me.lblcodcliente.Values.ExtraText = ""
        Me.lblcodcliente.Values.Image = Nothing
        Me.lblcodcliente.Values.Text = "0"
        '
        'txtCliente
        '
        Me.txtCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaClienteListar})
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(115, 20)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(232, 21)
        Me.txtCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.TabIndex = 44
        '
        'bsaClienteListar
        '
        Me.bsaClienteListar.ExtraText = ""
        Me.bsaClienteListar.Image = Nothing
        Me.bsaClienteListar.Text = ""
        Me.bsaClienteListar.ToolTipImage = Nothing
        Me.bsaClienteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaClienteListar.UniqueName = "AAA4BECF6E674984AAA4BECF6E674984"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(10, 20)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 43
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'frmsawPreFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 480)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmsawPreFactura"
        Me.Text = "Pre - Factura"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.dgvPreFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstprefactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtdatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lblcodcliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaClienteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgvPreFactura As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dstprefactura As System.Data.DataSet
    Friend WithEvents lblinicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblHasta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFechaFin As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txtFechaInicio As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents dtdatos As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents bsaGrabar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaTipoServicioListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblcodrubro As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bsaSeleccionar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaNoSeleccionar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NROTCKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORDSRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPOATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSRVNVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NHRFACDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FATNSRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
