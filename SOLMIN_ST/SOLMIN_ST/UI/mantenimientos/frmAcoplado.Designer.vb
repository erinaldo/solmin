<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcoplado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcoplado))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtLongitudAcoplado = New Ransa.Utilitario.UCtxtSoloDecimales
        Me.txtAltoAcoplado = New Ransa.Utilitario.UCtxtSoloDecimales
        Me.txtAnchoAcoplado = New Ransa.Utilitario.UCtxtSoloDecimales
        Me.cboTipoAcoplado = New CodeTextBox.CodeTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPlacaAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCapacidadCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtConfiguracionEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroChasis = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNumeroMTC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPesoTara = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMarcaVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCLRUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QPSTRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NEJSUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCPCRU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSRCHU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QLNGAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QANCAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QALTAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTIACP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDEACP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRGMT2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCNFG2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMRCVH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtFiltroPlacaAcoplado = New SOLMIN_ST.TextField
        Me.txtColorUnidad = New SOLMIN_ST.TextField
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrilla.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelGrilla)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelFiltros)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.HeaderDatos)
        Me.SplitContainer1.Size = New System.Drawing.Size(892, 720)
        Me.SplitContainer1.SplitterDistance = 406
        Me.SplitContainer1.TabIndex = 0
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.gwdDatos)
        Me.PanelGrilla.Controls.Add(Me.UcPaginacion1)
        Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 92)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(892, 314)
        Me.PanelGrilla.TabIndex = 1
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPLCAC, Me.TCLRUN, Me.QPSTRA, Me.NEJSUN, Me.NCPCRU, Me.NSRCHU, Me.QLNGAC, Me.QANCAC, Me.QALTAC, Me.CTIACP, Me.TDEACP, Me.NRGMT2, Me.TCNFG2, Me.TMRCVH, Me.CCMPN})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidth = 20
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.gwdDatos.RowTemplate.Height = 20
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(892, 289)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 2
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 289)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(892, 25)
        Me.UcPaginacion1.TabIndex = 1
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnBuscar})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtFiltroPlacaAcoplado)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.PanelFiltros.Size = New System.Drawing.Size(892, 92)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.Text = "ACOPLADOS"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "ACOPLADOS"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnBuscar
        '
        Me.btnBuscar.ExtraText = ""
        Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipImage = Nothing
        Me.btnBuscar.UniqueName = "D7B255E604FE46F2D7B255E604FE46F2"
        '
        'cmbCompania
        '
        Me.cmbCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.DropDownWidth = 156
        Me.cmbCompania.FormattingEnabled = False
        Me.cmbCompania.ItemHeight = 15
        Me.cmbCompania.Location = New System.Drawing.Point(162, 9)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(238, 23)
        Me.cmbCompania.TabIndex = 68
        Me.cmbCompania.TabStop = False
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(11, 10)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(66, 22)
        Me.lblCompania.TabIndex = 67
        Me.lblCompania.Text = "Compañía"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañía"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(11, 36)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(111, 22)
        Me.KryptonLabel6.TabIndex = 60
        Me.KryptonLabel6.Text = "Placa de Acoplado"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Placa de Acoplado"
        '
        'HeaderDatos
        '
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 0)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.Panel1)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(892, 310)
        Me.HeaderDatos.TabIndex = 0
        Me.HeaderDatos.Text = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtLongitudAcoplado)
        Me.Panel1.Controls.Add(Me.txtAltoAcoplado)
        Me.Panel1.Controls.Add(Me.txtAnchoAcoplado)
        Me.Panel1.Controls.Add(Me.cboTipoAcoplado)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.txtColorUnidad)
        Me.Panel1.Controls.Add(Me.txtPlacaAcoplado)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.KryptonBorderEdge1)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.KryptonLabel13)
        Me.Panel1.Controls.Add(Me.txtCapacidadCarga)
        Me.Panel1.Controls.Add(Me.txtConfiguracionEjes)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.KryptonLabel14)
        Me.Panel1.Controls.Add(Me.txtNroChasis)
        Me.Panel1.Controls.Add(Me.txtNumeroMTC)
        Me.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.Panel1.Controls.Add(Me.KryptonLabel15)
        Me.Panel1.Controls.Add(Me.txtPesoTara)
        Me.Panel1.Controls.Add(Me.KryptonLabel16)
        Me.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.Panel1.Controls.Add(Me.txtNroEjes)
        Me.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.Panel1.Controls.Add(Me.txtMarcaVehiculo)
        Me.Panel1.Controls.Add(Me.KryptonLabel11)
        Me.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(890, 258)
        Me.Panel1.TabIndex = 35
        '
        'txtLongitudAcoplado
        '
        Me.txtLongitudAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtLongitudAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.txtLongitudAcoplado.Location = New System.Drawing.Point(150, 195)
        Me.txtLongitudAcoplado.Name = "txtLongitudAcoplado"
        Me.txtLongitudAcoplado.NumerosDecimales = 2
        Me.txtLongitudAcoplado.NumerosEnteros = 5
        Me.txtLongitudAcoplado.Obligatorio = False
        Me.txtLongitudAcoplado.Size = New System.Drawing.Size(188, 22)
        Me.txtLongitudAcoplado.TabIndex = 37
        '
        'txtAltoAcoplado
        '
        Me.txtAltoAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtAltoAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.txtAltoAcoplado.Location = New System.Drawing.Point(529, 43)
        Me.txtAltoAcoplado.Name = "txtAltoAcoplado"
        Me.txtAltoAcoplado.NumerosDecimales = 2
        Me.txtAltoAcoplado.NumerosEnteros = 5
        Me.txtAltoAcoplado.Obligatorio = False
        Me.txtAltoAcoplado.Size = New System.Drawing.Size(188, 22)
        Me.txtAltoAcoplado.TabIndex = 36
        '
        'txtAnchoAcoplado
        '
        Me.txtAnchoAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtAnchoAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.txtAnchoAcoplado.Location = New System.Drawing.Point(529, 15)
        Me.txtAnchoAcoplado.Name = "txtAnchoAcoplado"
        Me.txtAnchoAcoplado.NumerosDecimales = 2
        Me.txtAnchoAcoplado.NumerosEnteros = 5
        Me.txtAnchoAcoplado.Obligatorio = False
        Me.txtAnchoAcoplado.Size = New System.Drawing.Size(188, 22)
        Me.txtAnchoAcoplado.TabIndex = 35
        '
        'cboTipoAcoplado
        '
        Me.cboTipoAcoplado.Codigo = ""
        Me.cboTipoAcoplado.ControlHeight = 23
        Me.cboTipoAcoplado.ControlImage = True
        Me.cboTipoAcoplado.ControlReadOnly = True
        Me.cboTipoAcoplado.Descripcion = ""
        Me.cboTipoAcoplado.DisplayColumnVisible = True
        Me.cboTipoAcoplado.DisplayMember = ""
        Me.cboTipoAcoplado.KeyColumnWidth = 100
        Me.cboTipoAcoplado.KeyField = ""
        Me.cboTipoAcoplado.KeySearch = True
        Me.cboTipoAcoplado.Location = New System.Drawing.Point(529, 74)
        Me.cboTipoAcoplado.Name = "cboTipoAcoplado"
        Me.cboTipoAcoplado.Size = New System.Drawing.Size(188, 23)
        Me.cboTipoAcoplado.TabIndex = 20
        Me.cboTipoAcoplado.TextBackColor = System.Drawing.Color.Empty
        Me.cboTipoAcoplado.TextForeColor = System.Drawing.Color.Empty
        Me.cboTipoAcoplado.ValueColumnVisible = True
        Me.cboTipoAcoplado.ValueColumnWidth = 600
        Me.cboTipoAcoplado.ValueField = ""
        Me.cboTipoAcoplado.ValueMember = ""
        Me.cboTipoAcoplado.ValueSearch = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(16, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(94, 22)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Placa Acoplado"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Placa Acoplado"
        '
        'txtPlacaAcoplado
        '
        Me.txtPlacaAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaAcoplado.Location = New System.Drawing.Point(150, 15)
        Me.txtPlacaAcoplado.MaxLength = 6
        Me.txtPlacaAcoplado.Name = "txtPlacaAcoplado"
        Me.txtPlacaAcoplado.Size = New System.Drawing.Size(188, 22)
        Me.txtPlacaAcoplado.TabIndex = 2
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(394, 165)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(112, 22)
        Me.KryptonLabel4.TabIndex = 34
        Me.KryptonLabel4.Text = "Marca de Vehículo"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Marca de Vehículo"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(16, 46)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(98, 22)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Color de unidad"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Color de unidad"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(386, 11)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 210)
        Me.KryptonBorderEdge1.TabIndex = 33
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(16, 135)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(118, 22)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Text = "Capacidad de carga"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Capacidad de carga"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(538, 187)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(6, 4)
        Me.KryptonLabel13.TabIndex = 31
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = ""
        '
        'txtCapacidadCarga
        '
        Me.txtCapacidadCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCapacidadCarga.Location = New System.Drawing.Point(150, 134)
        Me.txtCapacidadCarga.MaxLength = 8
        Me.txtCapacidadCarga.Name = "txtCapacidadCarga"
        Me.txtCapacidadCarga.Size = New System.Drawing.Size(188, 22)
        Me.txtCapacidadCarga.TabIndex = 10
        '
        'txtConfiguracionEjes
        '
        Me.txtConfiguracionEjes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfiguracionEjes.Location = New System.Drawing.Point(529, 136)
        Me.txtConfiguracionEjes.MaxLength = 3
        Me.txtConfiguracionEjes.Name = "txtConfiguracionEjes"
        Me.txtConfiguracionEjes.Size = New System.Drawing.Size(188, 22)
        Me.txtConfiguracionEjes.TabIndex = 24
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(16, 165)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(110, 22)
        Me.KryptonLabel5.TabIndex = 9
        Me.KryptonLabel5.Text = "Número de Chasis"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Número de Chasis"
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(394, 135)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(111, 22)
        Me.KryptonLabel14.TabIndex = 29
        Me.KryptonLabel14.Text = "Configuracion Ejes"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Configuracion Ejes"
        '
        'txtNroChasis
        '
        Me.txtNroChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroChasis.Location = New System.Drawing.Point(150, 164)
        Me.txtNroChasis.MaxLength = 30
        Me.txtNroChasis.Name = "txtNroChasis"
        Me.txtNroChasis.Size = New System.Drawing.Size(188, 22)
        Me.txtNroChasis.TabIndex = 12
        '
        'txtNumeroMTC
        '
        Me.txtNumeroMTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroMTC.Location = New System.Drawing.Point(529, 107)
        Me.txtNumeroMTC.MaxLength = 15
        Me.txtNumeroMTC.Name = "txtNumeroMTC"
        Me.txtNumeroMTC.Size = New System.Drawing.Size(188, 22)
        Me.txtNumeroMTC.TabIndex = 22
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(16, 74)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(80, 22)
        Me.KryptonLabel7.TabIndex = 13
        Me.KryptonLabel7.Text = "Peso de Tara"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Peso de Tara"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(394, 106)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(101, 22)
        Me.KryptonLabel15.TabIndex = 27
        Me.KryptonLabel15.Text = "Numero de MTC"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Numero de MTC"
        '
        'txtPesoTara
        '
        Me.txtPesoTara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoTara.Location = New System.Drawing.Point(150, 73)
        Me.txtPesoTara.MaxLength = 7
        Me.txtPesoTara.Name = "txtPesoTara"
        Me.txtPesoTara.Size = New System.Drawing.Size(188, 22)
        Me.txtPesoTara.TabIndex = 6
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(394, 74)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(107, 22)
        Me.KryptonLabel16.TabIndex = 25
        Me.KryptonLabel16.Text = "Tipo de Acoplado"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Tipo de Acoplado"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(16, 106)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(97, 22)
        Me.KryptonLabel8.TabIndex = 15
        Me.KryptonLabel8.Text = "Numero de Ejes"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Numero de Ejes"
        '
        'txtNroEjes
        '
        Me.txtNroEjes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroEjes.Location = New System.Drawing.Point(150, 105)
        Me.txtNroEjes.MaxLength = 2
        Me.txtNroEjes.Name = "txtNroEjes"
        Me.txtNroEjes.Size = New System.Drawing.Size(188, 22)
        Me.txtNroEjes.TabIndex = 8
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(394, 46)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(88, 22)
        Me.KryptonLabel9.TabIndex = 23
        Me.KryptonLabel9.Text = "Alto Acoplado"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Alto Acoplado"
        '
        'txtMarcaVehiculo
        '
        Me.txtMarcaVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaVehiculo.Location = New System.Drawing.Point(529, 166)
        Me.txtMarcaVehiculo.MaxLength = 30
        Me.txtMarcaVehiculo.Name = "txtMarcaVehiculo"
        Me.txtMarcaVehiculo.Size = New System.Drawing.Size(188, 22)
        Me.txtMarcaVehiculo.TabIndex = 26
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(16, 195)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(115, 22)
        Me.KryptonLabel11.TabIndex = 19
        Me.KryptonLabel11.Text = "Longitud Acoplado"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Longitud Acoplado"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(394, 16)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(101, 22)
        Me.KryptonLabel10.TabIndex = 21
        Me.KryptonLabel10.Text = "Ancho Acoplado"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Ancho Acoplado"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnModificar, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(890, 29)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(68, 26)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 26)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(84, 26)
        Me.btnModificar.Text = "Modificar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(79, 26)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(76, 26)
        Me.btnEliminar.Text = "Eliminar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NPLCAC"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Placa Acoplado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 118
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TCLRUN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Color Unidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 106
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "QPSTRA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Peso de Tara"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 102
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NEJSUN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Número de Ejes"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 119
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NCPCRU"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Capacidad de Carga"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 142
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NSRCHU"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Número de Chasis"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 133
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QLNGAC"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Longitud Acoplado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 138
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "QANCAC"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ancho Acoplado"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QALTAC"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Alto  Acoplado"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 115
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CTIACP"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tipo Acoplado"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 139
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "NRGMT2"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Número MTC"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn11.Width = 114
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TCNFG2"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Configuración ejes"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 108
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TMRCVH"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Marca vehículo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 135
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TMRCVH"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Marca vehículo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 117
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn15.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'NPLCAC
        '
        Me.NPLCAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCAC.DataPropertyName = "NPLCAC"
        Me.NPLCAC.HeaderText = "Placa Acoplado"
        Me.NPLCAC.Name = "NPLCAC"
        Me.NPLCAC.ReadOnly = True
        Me.NPLCAC.Width = 118
        '
        'TCLRUN
        '
        Me.TCLRUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCLRUN.DataPropertyName = "TCLRUN"
        Me.TCLRUN.HeaderText = "Color Unidad"
        Me.TCLRUN.Name = "TCLRUN"
        Me.TCLRUN.ReadOnly = True
        Me.TCLRUN.Width = 106
        '
        'QPSTRA
        '
        Me.QPSTRA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QPSTRA.DataPropertyName = "QPSTRA"
        Me.QPSTRA.HeaderText = "Peso de Tara"
        Me.QPSTRA.Name = "QPSTRA"
        Me.QPSTRA.ReadOnly = True
        Me.QPSTRA.Width = 102
        '
        'NEJSUN
        '
        Me.NEJSUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NEJSUN.DataPropertyName = "NEJSUN"
        Me.NEJSUN.HeaderText = "Número de Ejes"
        Me.NEJSUN.Name = "NEJSUN"
        Me.NEJSUN.ReadOnly = True
        Me.NEJSUN.Width = 119
        '
        'NCPCRU
        '
        Me.NCPCRU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCPCRU.DataPropertyName = "NCPCRU"
        Me.NCPCRU.HeaderText = "Capacidad de Carga"
        Me.NCPCRU.Name = "NCPCRU"
        Me.NCPCRU.ReadOnly = True
        Me.NCPCRU.Width = 142
        '
        'NSRCHU
        '
        Me.NSRCHU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NSRCHU.DataPropertyName = "NSRCHU"
        Me.NSRCHU.HeaderText = "Número de Chasis"
        Me.NSRCHU.Name = "NSRCHU"
        Me.NSRCHU.ReadOnly = True
        Me.NSRCHU.Width = 133
        '
        'QLNGAC
        '
        Me.QLNGAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QLNGAC.DataPropertyName = "QLNGAC"
        Me.QLNGAC.HeaderText = "Longitud Acoplado"
        Me.QLNGAC.Name = "QLNGAC"
        Me.QLNGAC.ReadOnly = True
        Me.QLNGAC.Width = 138
        '
        'QANCAC
        '
        Me.QANCAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QANCAC.DataPropertyName = "QANCAC"
        Me.QANCAC.HeaderText = "Ancho Acoplado"
        Me.QANCAC.Name = "QANCAC"
        Me.QANCAC.ReadOnly = True
        Me.QANCAC.Width = 125
        '
        'QALTAC
        '
        Me.QALTAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QALTAC.DataPropertyName = "QALTAC"
        Me.QALTAC.HeaderText = "Alto  Acoplado"
        Me.QALTAC.Name = "QALTAC"
        Me.QALTAC.ReadOnly = True
        Me.QALTAC.Width = 115
        '
        'CTIACP
        '
        Me.CTIACP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTIACP.DataPropertyName = "CTIACP"
        Me.CTIACP.HeaderText = "Cod Tipo Acoplado"
        Me.CTIACP.Name = "CTIACP"
        Me.CTIACP.ReadOnly = True
        Me.CTIACP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTIACP.Visible = False
        Me.CTIACP.Width = 139
        '
        'TDEACP
        '
        Me.TDEACP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDEACP.DataPropertyName = "TDEACP"
        Me.TDEACP.HeaderText = "Tipo Acoplado"
        Me.TDEACP.Name = "TDEACP"
        Me.TDEACP.ReadOnly = True
        Me.TDEACP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TDEACP.Width = 114
        '
        'NRGMT2
        '
        Me.NRGMT2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRGMT2.DataPropertyName = "NRGMT2"
        Me.NRGMT2.HeaderText = "Número MTC"
        Me.NRGMT2.Name = "NRGMT2"
        Me.NRGMT2.ReadOnly = True
        Me.NRGMT2.Width = 108
        '
        'TCNFG2
        '
        Me.TCNFG2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCNFG2.DataPropertyName = "TCNFG2"
        Me.TCNFG2.HeaderText = "Configuración ejes"
        Me.TCNFG2.Name = "TCNFG2"
        Me.TCNFG2.ReadOnly = True
        Me.TCNFG2.Width = 135
        '
        'TMRCVH
        '
        Me.TMRCVH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCVH.DataPropertyName = "TMRCVH"
        Me.TMRCVH.HeaderText = "Marca vehículo"
        Me.TMRCVH.Name = "TMRCVH"
        Me.TMRCVH.ReadOnly = True
        Me.TMRCVH.Width = 117
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'txtFiltroPlacaAcoplado
        '
        Me.txtFiltroPlacaAcoplado.Location = New System.Drawing.Point(162, 35)
        Me.txtFiltroPlacaAcoplado.MaxLength = 6
        Me.txtFiltroPlacaAcoplado.Name = "txtFiltroPlacaAcoplado"
        Me.txtFiltroPlacaAcoplado.Size = New System.Drawing.Size(236, 22)
        Me.txtFiltroPlacaAcoplado.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFiltroPlacaAcoplado.TabIndex = 1
        Me.txtFiltroPlacaAcoplado.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtColorUnidad
        '
        Me.txtColorUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColorUnidad.Location = New System.Drawing.Point(150, 45)
        Me.txtColorUnidad.MaxLength = 25
        Me.txtColorUnidad.Name = "txtColorUnidad"
        Me.txtColorUnidad.Size = New System.Drawing.Size(188, 22)
        Me.txtColorUnidad.TabIndex = 4
        Me.txtColorUnidad.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'frmAcoplado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 720)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmAcoplado"
        Me.Text = "Acoplados"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrilla.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents PanelGrilla As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPlacaAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroEjes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoTara As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroChasis As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCapacidadCarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtConfiguracionEjes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNumeroMTC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMarcaVehiculo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtColorUnidad As SOLMIN_ST.TextField
    Friend WithEvents cboTipoAcoplado As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFiltroPlacaAcoplado As SOLMIN_ST.TextField
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtAnchoAcoplado As Ransa.Utilitario.UCtxtSoloDecimales
    Friend WithEvents txtAltoAcoplado As Ransa.Utilitario.UCtxtSoloDecimales
    Friend WithEvents txtLongitudAcoplado As Ransa.Utilitario.UCtxtSoloDecimales
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCLRUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPSTRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEJSUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCPCRU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSRCHU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QLNGAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QANCAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QALTAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTIACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDEACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRGMT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCNFG2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCVH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
End Class
