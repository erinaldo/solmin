<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTracto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTracto))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtBuscar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroRPM = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNumPlacaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNumEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNumEmpadMTC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigoTipoTracto = New CodeTextBox.CodeTextBox
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMarcaModelo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtFechaFabricacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPesoTracto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNumChasis = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCapCargaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtSerieMotor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCarroceriaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtColorUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dgvHistorial = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
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
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeroPlacaUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumEjes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumChasis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumSerieMotor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaFabricacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColorUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarroceriaUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CapacidadCargaUnd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTipoTracto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDETRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PesoTractor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaModelo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumEmpadronamientoMTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NTERPM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECINI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECFIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCND = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMCMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1099, 774)
        Me.SplitContainer1.SplitterDistance = 490
        Me.SplitContainer1.TabIndex = 1
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.gwdDatos)
        Me.PanelGrilla.Controls.Add(Me.UcPaginacion1)
        Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 100)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(1099, 390)
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
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroPlacaUnidad, Me.NumEjes, Me.NumChasis, Me.NumSerieMotor, Me.FechaFabricacion, Me.ColorUnidad, Me.CarroceriaUnidad, Me.CapacidadCargaUnd, Me.CodigoTipoTracto, Me.TDETRA, Me.PesoTractor, Me.MarcaModelo, Me.NumEmpadronamientoMTC, Me.NTERPM, Me.CCMPN})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidth = 20
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.RowTemplate.Height = 20
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(1099, 365)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 2
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 365)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(1099, 25)
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
        Me.PanelFiltros.Panel.Controls.Add(Me.txtBuscar)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.PanelFiltros.Size = New System.Drawing.Size(1099, 100)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.Text = "TRACTOS"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "TRACTOS"
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
        Me.btnBuscar.UniqueName = "1C2A7D5FDF6E451A1C2A7D5FDF6E451A"
        '
        'cmbCompania
        '
        Me.cmbCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.DropDownWidth = 156
        Me.cmbCompania.FormattingEnabled = False
        Me.cmbCompania.ItemHeight = 15
        Me.cmbCompania.Location = New System.Drawing.Point(95, 9)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(238, 23)
        Me.cmbCompania.TabIndex = 66
        Me.cmbCompania.TabStop = False
        '
        'lblCompania
        '
        Me.lblCompania.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompania.Location = New System.Drawing.Point(16, 10)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(66, 22)
        Me.lblCompania.TabIndex = 65
        Me.lblCompania.Text = "Compañía"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañía"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(96, 39)
        Me.txtBuscar.MaxLength = 6
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(237, 22)
        Me.txtBuscar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar.TabIndex = 1
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(16, 40)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(45, 22)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Tracto"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tracto"
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
        Me.HeaderDatos.Size = New System.Drawing.Size(1099, 280)
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
        Me.Panel1.Controls.Add(Me.KryptonSplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 230)
        Me.Panel1.TabIndex = 61
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
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonBorderEdge2)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtNroRPM)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtNumPlacaUnidad)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtNumEjes)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtNumEmpadMTC)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel17)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtCodigoTipoTracto)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel15)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtMarcaModelo)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtFechaFabricacion)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtPesoTracto)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonBorderEdge1)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtNumChasis)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel16)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel11)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtCapCargaUnidad)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtSerieMotor)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel12)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtCarroceriaUnidad)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.txtColorUnidad)
        Me.KryptonSplitContainer1.Panel1.StateCommon.Color1 = System.Drawing.Color.White
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgvHistorial)
        Me.KryptonSplitContainer1.Panel2.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1097, 230)
        Me.KryptonSplitContainer1.SplitterDistance = 795
        Me.KryptonSplitContainer1.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.KryptonSplitContainer1.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.KryptonSplitContainer1.TabIndex = 64
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(722, 13)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(1, 180)
        Me.KryptonBorderEdge2.TabIndex = 64
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(9, 13)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(112, 22)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Num Placa Unidad"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Num Placa Unidad"
        '
        'txtNroRPM
        '
        Me.txtNroRPM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroRPM.Location = New System.Drawing.Point(433, 148)
        Me.txtNroRPM.MaxLength = 15
        Me.txtNroRPM.Name = "txtNroRPM"
        Me.txtNroRPM.Size = New System.Drawing.Size(283, 22)
        Me.txtNroRPM.TabIndex = 63
        '
        'txtNumPlacaUnidad
        '
        Me.txtNumPlacaUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumPlacaUnidad.Location = New System.Drawing.Point(151, 13)
        Me.txtNumPlacaUnidad.MaxLength = 6
        Me.txtNumPlacaUnidad.Name = "txtNumPlacaUnidad"
        Me.txtNumPlacaUnidad.Size = New System.Drawing.Size(128, 22)
        Me.txtNumPlacaUnidad.TabIndex = 5
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(300, 145)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(79, 22)
        Me.KryptonLabel4.TabIndex = 62
        Me.KryptonLabel4.Text = "N° Telf. RPM"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "N° Telf. RPM"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(9, 38)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(97, 22)
        Me.KryptonLabel8.TabIndex = 15
        Me.KryptonLabel8.Text = "Número de Ejes"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Número de Ejes"
        '
        'txtNumEjes
        '
        Me.txtNumEjes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumEjes.Location = New System.Drawing.Point(151, 38)
        Me.txtNumEjes.MaxLength = 2
        Me.txtNumEjes.Name = "txtNumEjes"
        Me.txtNumEjes.Size = New System.Drawing.Size(128, 22)
        Me.txtNumEjes.TabIndex = 10
        '
        'txtNumEmpadMTC
        '
        Me.txtNumEmpadMTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumEmpadMTC.Location = New System.Drawing.Point(433, 121)
        Me.txtNumEmpadMTC.MaxLength = 15
        Me.txtNumEmpadMTC.Name = "txtNumEmpadMTC"
        Me.txtNumEmpadMTC.Size = New System.Drawing.Size(283, 22)
        Me.txtNumEmpadMTC.TabIndex = 60
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(300, 121)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(84, 22)
        Me.KryptonLabel17.TabIndex = 27
        Me.KryptonLabel17.Text = "Número MTC"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Número MTC"
        '
        'txtCodigoTipoTracto
        '
        Me.txtCodigoTipoTracto.Codigo = ""
        Me.txtCodigoTipoTracto.ControlHeight = 23
        Me.txtCodigoTipoTracto.ControlImage = True
        Me.txtCodigoTipoTracto.ControlReadOnly = True
        Me.txtCodigoTipoTracto.Descripcion = ""
        Me.txtCodigoTipoTracto.DisplayColumnVisible = True
        Me.txtCodigoTipoTracto.DisplayMember = ""
        Me.txtCodigoTipoTracto.KeyColumnWidth = 100
        Me.txtCodigoTipoTracto.KeyField = ""
        Me.txtCodigoTipoTracto.KeySearch = True
        Me.txtCodigoTipoTracto.Location = New System.Drawing.Point(434, 40)
        Me.txtCodigoTipoTracto.Name = "txtCodigoTipoTracto"
        Me.txtCodigoTipoTracto.Size = New System.Drawing.Size(282, 23)
        Me.txtCodigoTipoTracto.TabIndex = 45
        Me.txtCodigoTipoTracto.TextBackColor = System.Drawing.Color.Empty
        Me.txtCodigoTipoTracto.TextForeColor = System.Drawing.Color.Empty
        Me.txtCodigoTipoTracto.ValueColumnVisible = True
        Me.txtCodigoTipoTracto.ValueColumnWidth = 600
        Me.txtCodigoTipoTracto.ValueField = ""
        Me.txtCodigoTipoTracto.ValueMember = ""
        Me.txtCodigoTipoTracto.ValueSearch = True
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(298, 94)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(91, 22)
        Me.KryptonLabel15.TabIndex = 5
        Me.KryptonLabel15.Text = "Marca/Modelo"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Marca/Modelo"
        '
        'txtMarcaModelo
        '
        Me.txtMarcaModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaModelo.Location = New System.Drawing.Point(433, 94)
        Me.txtMarcaModelo.MaxLength = 40
        Me.txtMarcaModelo.Name = "txtMarcaModelo"
        Me.txtMarcaModelo.Size = New System.Drawing.Size(283, 22)
        Me.txtMarcaModelo.TabIndex = 55
        '
        'txtFechaFabricacion
        '
        Me.txtFechaFabricacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaFabricacion.Location = New System.Drawing.Point(151, 119)
        Me.txtFechaFabricacion.MaxLength = 4
        Me.txtFechaFabricacion.Name = "txtFechaFabricacion"
        Me.txtFechaFabricacion.Size = New System.Drawing.Size(128, 22)
        Me.txtFechaFabricacion.TabIndex = 25
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(9, 165)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(67, 38)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Carrocería " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Unidad"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Carrocería " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Unidad"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(9, 65)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(110, 22)
        Me.KryptonLabel5.TabIndex = 9
        Me.KryptonLabel5.Text = "Número de Chasis"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Número de Chasis"
        '
        'txtPesoTracto
        '
        Me.txtPesoTracto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoTracto.Location = New System.Drawing.Point(433, 69)
        Me.txtPesoTracto.MaxLength = 7
        Me.txtPesoTracto.Name = "txtPesoTracto"
        Me.txtPesoTracto.Size = New System.Drawing.Size(160, 22)
        Me.txtPesoTracto.TabIndex = 50
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(284, 13)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 180)
        Me.KryptonBorderEdge1.TabIndex = 33
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(300, 65)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(91, 22)
        Me.KryptonLabel10.TabIndex = 13
        Me.KryptonLabel10.Text = "Peso de Tracto"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Peso de Tracto"
        '
        'txtNumChasis
        '
        Me.txtNumChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumChasis.Location = New System.Drawing.Point(151, 65)
        Me.txtNumChasis.MaxLength = 30
        Me.txtNumChasis.Name = "txtNumChasis"
        Me.txtNumChasis.Size = New System.Drawing.Size(128, 22)
        Me.txtNumChasis.TabIndex = 15
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(300, 38)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(72, 22)
        Me.KryptonLabel9.TabIndex = 23
        Me.KryptonLabel9.Text = "Tipo Tracto"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Tipo Tracto"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(9, 94)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(92, 22)
        Me.KryptonLabel6.TabIndex = 11
        Me.KryptonLabel6.Text = "Serie de Motor"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Serie de Motor"
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(9, 145)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(112, 22)
        Me.KryptonLabel16.TabIndex = 25
        Me.KryptonLabel16.Text = "Color de la Unidad"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Color de la Unidad"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(298, 13)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(120, 22)
        Me.KryptonLabel11.TabIndex = 19
        Me.KryptonLabel11.Text = "Capacidad de Carga"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Capacidad de Carga"
        '
        'txtCapCargaUnidad
        '
        Me.txtCapCargaUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCapCargaUnidad.Location = New System.Drawing.Point(434, 13)
        Me.txtCapCargaUnidad.MaxLength = 8
        Me.txtCapCargaUnidad.Name = "txtCapCargaUnidad"
        Me.txtCapCargaUnidad.Size = New System.Drawing.Size(159, 22)
        Me.txtCapCargaUnidad.TabIndex = 40
        '
        'txtSerieMotor
        '
        Me.txtSerieMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieMotor.Location = New System.Drawing.Point(151, 92)
        Me.txtSerieMotor.MaxLength = 30
        Me.txtSerieMotor.Name = "txtSerieMotor"
        Me.txtSerieMotor.Size = New System.Drawing.Size(128, 22)
        Me.txtSerieMotor.TabIndex = 20
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(9, 121)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(115, 22)
        Me.KryptonLabel12.TabIndex = 17
        Me.KryptonLabel12.Text = "Año de Fabricación"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Año de Fabricación"
        '
        'txtCarroceriaUnidad
        '
        Me.txtCarroceriaUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarroceriaUnidad.Location = New System.Drawing.Point(151, 172)
        Me.txtCarroceriaUnidad.MaxLength = 10
        Me.txtCarroceriaUnidad.Name = "txtCarroceriaUnidad"
        Me.txtCarroceriaUnidad.Size = New System.Drawing.Size(128, 22)
        Me.txtCarroceriaUnidad.TabIndex = 35
        '
        'txtColorUnidad
        '
        Me.txtColorUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColorUnidad.Location = New System.Drawing.Point(151, 145)
        Me.txtColorUnidad.MaxLength = 25
        Me.txtColorUnidad.Name = "txtColorUnidad"
        Me.txtColorUnidad.Size = New System.Drawing.Size(128, 22)
        Me.txtColorUnidad.TabIndex = 30
        '
        'dgvHistorial
        '
        Me.dgvHistorial.AllowUserToAddRows = False
        Me.dgvHistorial.AllowUserToDeleteRows = False
        Me.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRUCTR, Me.TCMTRT, Me.FECINI, Me.FECFIN, Me.CBRCND, Me.TNMCMC, Me.SESTCM, Me.SESTRG})
        Me.dgvHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistorial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvHistorial.Location = New System.Drawing.Point(0, 0)
        Me.dgvHistorial.MultiSelect = False
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.ReadOnly = True
        Me.dgvHistorial.RowHeadersWidth = 20
        Me.dgvHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvHistorial.RowTemplate.Height = 20
        Me.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorial.Size = New System.Drawing.Size(297, 230)
        Me.dgvHistorial.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvHistorial.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvHistorial.TabIndex = 1
        Me.dgvHistorial.Visible = False
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnModificar, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar, Me.ToolStripSeparator4, Me.ToolStripLabel1})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1097, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel1.Text = "Historial"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Num de Placa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 110
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NEJSUN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Num Ejes"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 86
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NSRCHU"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Num Chasis"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NSRMTU"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Num Serie Motor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 127
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FFBRUN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Fabricacion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 131
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TCLRUN"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Color Unidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 106
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TCRRUN"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Carroceria Unidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 131
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NCPCRU"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Capacidad Carga Und"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 151
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CTITRA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Codigo Tipo Tracto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 138
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "QPSOTR"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Peso Tractor"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 112
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TMRCTR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Marca / Modelo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 101
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NRGMT1"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Num Empadronamiento MTC"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 121
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NTERPM"
        Me.DataGridViewTextBoxColumn13.HeaderText = "N° Telf. RPM"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 193
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TDETRA"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Tipo de Tracto"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 103
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn15.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn16.HeaderText = "RUC Trans."
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 93
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "TCMTRT"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Transportista"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 104
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "FECINI"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Fecha Inicio"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 99
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "FECFIN"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Fecha Fin"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 86
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CBRCND"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Brevete Conductor"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 135
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "SESTCM"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Estado Camión"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 93
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Estado Registro"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 116
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Estado Registro"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 117
        '
        'NumeroPlacaUnidad
        '
        Me.NumeroPlacaUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroPlacaUnidad.DataPropertyName = "NPLCUN"
        Me.NumeroPlacaUnidad.HeaderText = "Num de Placa"
        Me.NumeroPlacaUnidad.Name = "NumeroPlacaUnidad"
        Me.NumeroPlacaUnidad.ReadOnly = True
        Me.NumeroPlacaUnidad.Width = 110
        '
        'NumEjes
        '
        Me.NumEjes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumEjes.DataPropertyName = "NEJSUN"
        Me.NumEjes.HeaderText = "Num Ejes"
        Me.NumEjes.Name = "NumEjes"
        Me.NumEjes.ReadOnly = True
        Me.NumEjes.Width = 86
        '
        'NumChasis
        '
        Me.NumChasis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumChasis.DataPropertyName = "NSRCHU"
        Me.NumChasis.HeaderText = "Num Chasis"
        Me.NumChasis.Name = "NumChasis"
        Me.NumChasis.ReadOnly = True
        '
        'NumSerieMotor
        '
        Me.NumSerieMotor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumSerieMotor.DataPropertyName = "NSRMTU"
        Me.NumSerieMotor.HeaderText = "Num Serie Motor"
        Me.NumSerieMotor.Name = "NumSerieMotor"
        Me.NumSerieMotor.ReadOnly = True
        Me.NumSerieMotor.Width = 127
        '
        'FechaFabricacion
        '
        Me.FechaFabricacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaFabricacion.DataPropertyName = "FFBRUN"
        Me.FechaFabricacion.HeaderText = "Fecha Fabricación"
        Me.FechaFabricacion.Name = "FechaFabricacion"
        Me.FechaFabricacion.ReadOnly = True
        Me.FechaFabricacion.Width = 131
        '
        'ColorUnidad
        '
        Me.ColorUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColorUnidad.DataPropertyName = "TCLRUN"
        Me.ColorUnidad.HeaderText = "Color Unidad"
        Me.ColorUnidad.Name = "ColorUnidad"
        Me.ColorUnidad.ReadOnly = True
        Me.ColorUnidad.Width = 106
        '
        'CarroceriaUnidad
        '
        Me.CarroceriaUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CarroceriaUnidad.DataPropertyName = "TCRRUN"
        Me.CarroceriaUnidad.HeaderText = "Carrocería Unidad"
        Me.CarroceriaUnidad.Name = "CarroceriaUnidad"
        Me.CarroceriaUnidad.ReadOnly = True
        Me.CarroceriaUnidad.Width = 131
        '
        'CapacidadCargaUnd
        '
        Me.CapacidadCargaUnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CapacidadCargaUnd.DataPropertyName = "NCPCRU"
        Me.CapacidadCargaUnd.HeaderText = "Capacidad Carga Und"
        Me.CapacidadCargaUnd.Name = "CapacidadCargaUnd"
        Me.CapacidadCargaUnd.ReadOnly = True
        Me.CapacidadCargaUnd.Width = 151
        '
        'CodigoTipoTracto
        '
        Me.CodigoTipoTracto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodigoTipoTracto.DataPropertyName = "CTITRA"
        Me.CodigoTipoTracto.HeaderText = "Código Tipo Tracto"
        Me.CodigoTipoTracto.Name = "CodigoTipoTracto"
        Me.CodigoTipoTracto.ReadOnly = True
        Me.CodigoTipoTracto.Visible = False
        Me.CodigoTipoTracto.Width = 138
        '
        'TDETRA
        '
        Me.TDETRA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDETRA.DataPropertyName = "TDETRA"
        Me.TDETRA.HeaderText = "Tipo de Tracto"
        Me.TDETRA.Name = "TDETRA"
        Me.TDETRA.ReadOnly = True
        Me.TDETRA.Width = 112
        '
        'PesoTractor
        '
        Me.PesoTractor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PesoTractor.DataPropertyName = "QPSOTR"
        Me.PesoTractor.HeaderText = "Peso Tractor"
        Me.PesoTractor.Name = "PesoTractor"
        Me.PesoTractor.ReadOnly = True
        Me.PesoTractor.Width = 101
        '
        'MarcaModelo
        '
        Me.MarcaModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MarcaModelo.DataPropertyName = "TMRCTR"
        Me.MarcaModelo.HeaderText = "Marca / Modelo"
        Me.MarcaModelo.Name = "MarcaModelo"
        Me.MarcaModelo.ReadOnly = True
        Me.MarcaModelo.Width = 121
        '
        'NumEmpadronamientoMTC
        '
        Me.NumEmpadronamientoMTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumEmpadronamientoMTC.DataPropertyName = "NRGMT1"
        Me.NumEmpadronamientoMTC.HeaderText = "Num Empadronamiento MTC"
        Me.NumEmpadronamientoMTC.Name = "NumEmpadronamientoMTC"
        Me.NumEmpadronamientoMTC.ReadOnly = True
        Me.NumEmpadronamientoMTC.Width = 193
        '
        'NTERPM
        '
        Me.NTERPM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NTERPM.DataPropertyName = "NTERPM"
        Me.NTERPM.HeaderText = "N° Telf. RPM"
        Me.NTERPM.Name = "NTERPM"
        Me.NTERPM.ReadOnly = True
        Me.NTERPM.Width = 103
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'NRUCTR
        '
        Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "RUC Trans."
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Width = 93
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Transportista"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Width = 104
        '
        'FECINI
        '
        Me.FECINI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECINI.DataPropertyName = "FECINI"
        Me.FECINI.HeaderText = "Fecha Inicio"
        Me.FECINI.Name = "FECINI"
        Me.FECINI.ReadOnly = True
        Me.FECINI.Width = 99
        '
        'FECFIN
        '
        Me.FECFIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECFIN.DataPropertyName = "FECFIN"
        Me.FECFIN.HeaderText = "Fecha Fin"
        Me.FECFIN.Name = "FECFIN"
        Me.FECFIN.ReadOnly = True
        Me.FECFIN.Width = 86
        '
        'CBRCND
        '
        Me.CBRCND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CBRCND.DataPropertyName = "CBRCND"
        Me.CBRCND.HeaderText = "Brevete Conductor"
        Me.CBRCND.Name = "CBRCND"
        Me.CBRCND.ReadOnly = True
        Me.CBRCND.Width = 135
        '
        'TNMCMC
        '
        Me.TNMCMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TNMCMC.DataPropertyName = "TNMCMC"
        Me.TNMCMC.HeaderText = "Conductor"
        Me.TNMCMC.Name = "TNMCMC"
        Me.TNMCMC.ReadOnly = True
        Me.TNMCMC.Width = 93
        '
        'SESTCM
        '
        Me.SESTCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SESTCM.DataPropertyName = "SESTCM"
        Me.SESTCM.HeaderText = "Estado Camión"
        Me.SESTCM.Name = "SESTCM"
        Me.SESTCM.ReadOnly = True
        Me.SESTCM.Width = 116
        '
        'SESTRG
        '
        Me.SESTRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SESTRG.DataPropertyName = "SESTRG"
        Me.SESTRG.HeaderText = "Estado Registro"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.Width = 117
        '
        'frmTracto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 774)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTracto"
        Me.Text = "Tracto"
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
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelGrilla As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNumEmpadMTC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMarcaModelo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoTracto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCapCargaUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCarroceriaUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtColorUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSerieMotor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNumChasis As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNumEjes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNumPlacaUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtBuscar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtCodigoTipoTracto As CodeTextBox.CodeTextBox
    Friend WithEvents txtFechaFabricacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtNroRPM As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dgvHistorial As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECINI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMCMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents NumeroPlacaUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumEjes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumChasis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumSerieMotor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFabricacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarroceriaUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadCargaUnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTipoTracto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDETRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PesoTractor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaModelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumEmpadronamientoMTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTERPM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
