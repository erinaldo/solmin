<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoOperacionTransporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoOperacionTransporte))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnRegistroWAP = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSeguimientoFlota = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnImprimir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbPlanta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cmbDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ctbVehiculo = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
        Me.ctbTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01
        Me.ctbEvento = New CodeTextBox.CodeTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.RUCTransportista = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Placa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Conductor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Acoplado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoCarroceria = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ubicación = New System.Windows.Forms.DataGridViewImageColumn
        Me.FECGPS = New System.Windows.Forms.DataGridViewLinkColumn
        Me.HORGPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Seguimiento = New System.Windows.Forms.DataGridViewLinkColumn
        Me.GPSLAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GPSLON = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodTipoCarroceria = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCOACC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtpFechaUbicacion = New System.Windows.Forms.DateTimePicker
        Me.TabOperacion = New System.Windows.Forms.TabControl
        Me.tabInformacion = New System.Windows.Forms.TabPage
        Me.cmbConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01
        Me.cboVehiculos = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
        Me.cboTipoVehiculo = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboAcoplados = New Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tabBitacora = New System.Windows.Forms.TabPage
        Me.dgwBitacoraVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.Separator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.Separator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.Separator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAsignarGFH = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.lblFecha = New System.Windows.Forms.ToolStripLabel
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
        Me.NMRCRL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRITEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECSEG_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMCND = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDSDES = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrilla.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabOperacion.SuspendLayout()
        Me.tabInformacion.SuspendLayout()
        Me.tabBitacora.SuspendLayout()
        CType(Me.dgwBitacoraVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnRegistroWAP, Me.btnSeguimientoFlota, Me.btnImprimir, Me.btnBuscar})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbPlanta)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbDivision)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblPlanta)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel8)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbVehiculo)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbTransportista)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbEvento)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblVehiculo)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Size = New System.Drawing.Size(1019, 105)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = ""
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnRegistroWAP
        '
        Me.btnRegistroWAP.ExtraText = ""
        Me.btnRegistroWAP.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnRegistroWAP.Image = Global.SOLMIN_ST.My.Resources.Resources.cell_layout
        Me.btnRegistroWAP.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnRegistroWAP.Text = "Ver Registro WAP"
        Me.btnRegistroWAP.ToolTipImage = Nothing
        Me.btnRegistroWAP.UniqueName = "44C180E65060499144C180E650604991"
        '
        'btnSeguimientoFlota
        '
        Me.btnSeguimientoFlota.ExtraText = ""
        Me.btnSeguimientoFlota.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSeguimientoFlota.Image = Global.SOLMIN_ST.My.Resources.Resources.agt_web
        Me.btnSeguimientoFlota.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnSeguimientoFlota.Text = "Seguimiento de Flota (Google Earth)"
        Me.btnSeguimientoFlota.ToolTipImage = Nothing
        Me.btnSeguimientoFlota.UniqueName = "74059C40874A445B74059C40874A445B"
        '
        'btnImprimir
        '
        Me.btnImprimir.ExtraText = ""
        Me.btnImprimir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnImprimir.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
        Me.btnImprimir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTipImage = Nothing
        Me.btnImprimir.UniqueName = "01A160FE10A04B3901A160FE10A04B39"
        '
        'btnBuscar
        '
        Me.btnBuscar.ExtraText = ""
        Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipImage = Nothing
        Me.btnBuscar.UniqueName = "F673E9D145974133F673E9D145974133"
        '
        'cmbPlanta
        '
        Me.cmbPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.DropDownWidth = 156
        Me.cmbPlanta.FormattingEnabled = False
        Me.cmbPlanta.ItemHeight = 13
        Me.cmbPlanta.Location = New System.Drawing.Point(715, 9)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(237, 21)
        Me.cmbPlanta.TabIndex = 111
        Me.cmbPlanta.TabStop = False
        '
        'cmbDivision
        '
        Me.cmbDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.DropDownWidth = 156
        Me.cmbDivision.FormattingEnabled = False
        Me.cmbDivision.ItemHeight = 13
        Me.cmbDivision.Location = New System.Drawing.Point(450, 9)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(199, 21)
        Me.cmbDivision.TabIndex = 109
        Me.cmbDivision.TabStop = False
        '
        'lblPlanta
        '
        Me.lblPlanta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlanta.Location = New System.Drawing.Point(655, 10)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(41, 19)
        Me.lblPlanta.TabIndex = 110
        Me.lblPlanta.Text = "Planta"
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel8.Location = New System.Drawing.Point(390, 10)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel8.TabIndex = 108
        Me.KryptonLabel8.Text = "División"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "División"
        '
        'cmbCompania
        '
        Me.cmbCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.DropDownWidth = 156
        Me.cmbCompania.FormattingEnabled = False
        Me.cmbCompania.ItemHeight = 13
        Me.cmbCompania.Location = New System.Drawing.Point(115, 9)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(258, 21)
        Me.cmbCompania.TabIndex = 107
        Me.cmbCompania.TabStop = False
        '
        'lblCompania
        '
        Me.lblCompania.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompania.Location = New System.Drawing.Point(13, 10)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(61, 19)
        Me.lblCompania.TabIndex = 106
        Me.lblCompania.Text = "Compañía"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañía"
        '
        'ctbVehiculo
        '
        Me.ctbVehiculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbVehiculo.BackColor = System.Drawing.Color.Transparent
        Me.ctbVehiculo.Location = New System.Drawing.Point(450, 41)
        Me.ctbVehiculo.Name = "ctbVehiculo"
        Me.ctbVehiculo.pRequerido = False
        Me.ctbVehiculo.Size = New System.Drawing.Size(199, 21)
        Me.ctbVehiculo.TabIndex = 104
        '
        'ctbTransportista
        '
        Me.ctbTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbTransportista.BackColor = System.Drawing.Color.Transparent
        Me.ctbTransportista.Location = New System.Drawing.Point(115, 41)
        Me.ctbTransportista.Name = "ctbTransportista"
        Me.ctbTransportista.pNroRegPorPaginas = 0
        Me.ctbTransportista.pRequerido = False
        Me.ctbTransportista.Size = New System.Drawing.Size(258, 21)
        Me.ctbTransportista.TabIndex = 103
        '
        'ctbEvento
        '
        Me.ctbEvento.Codigo = ""
        Me.ctbEvento.ControlHeight = 23
        Me.ctbEvento.ControlImage = True
        Me.ctbEvento.ControlReadOnly = False
        Me.ctbEvento.Descripcion = ""
        Me.ctbEvento.DisplayColumnVisible = True
        Me.ctbEvento.DisplayMember = ""
        Me.ctbEvento.KeyColumnWidth = 100
        Me.ctbEvento.KeyField = ""
        Me.ctbEvento.KeySearch = True
        Me.ctbEvento.Location = New System.Drawing.Point(715, 40)
        Me.ctbEvento.Name = "ctbEvento"
        Me.ctbEvento.Size = New System.Drawing.Size(237, 23)
        Me.ctbEvento.TabIndex = 102
        Me.ctbEvento.TextBackColor = System.Drawing.Color.Empty
        Me.ctbEvento.TextForeColor = System.Drawing.Color.Empty
        Me.ctbEvento.ValueColumnVisible = True
        Me.ctbEvento.ValueColumnWidth = 600
        Me.ctbEvento.ValueField = ""
        Me.ctbEvento.ValueMember = ""
        Me.ctbEvento.ValueSearch = True
        Me.ctbEvento.Visible = False
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(655, 42)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(49, 19)
        Me.KryptonLabel7.TabIndex = 101
        Me.KryptonLabel7.Text = "Eventos"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Eventos"
        Me.KryptonLabel7.Visible = False
        '
        'lblVehiculo
        '
        Me.lblVehiculo.Location = New System.Drawing.Point(390, 42)
        Me.lblVehiculo.Name = "lblVehiculo"
        Me.lblVehiculo.Size = New System.Drawing.Size(53, 19)
        Me.lblVehiculo.TabIndex = 2
        Me.lblVehiculo.Text = "Vehículo"
        Me.lblVehiculo.Values.ExtraText = ""
        Me.lblVehiculo.Values.Image = Nothing
        Me.lblVehiculo.Values.Text = "Vehículo"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 42)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(75, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Transportista"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Transportista"
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.SplitContainer1)
        Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 105)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.PanelGrilla.Size = New System.Drawing.Size(1019, 617)
        Me.PanelGrilla.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gwdDatos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtpFechaUbicacion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabOperacion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MenuBar)
        Me.SplitContainer1.Size = New System.Drawing.Size(1019, 617)
        Me.SplitContainer1.SplitterDistance = 345
        Me.SplitContainer1.TabIndex = 114
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToResizeColumns = False
        Me.gwdDatos.AllowUserToResizeRows = False
        Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RUCTransportista, Me.Placa, Me.Color, Me.Modelo, Me.Conductor, Me.Acoplado, Me.TipoCarroceria, Me.Ubicación, Me.FECGPS, Me.HORGPS, Me.Seguimiento, Me.GPSLAT, Me.GPSLON, Me.CodTipoCarroceria, Me.CodCliente, Me.Cliente, Me.NCOACC, Me.CBRCNT})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersVisible = False
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(1019, 345)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 0
        Me.gwdDatos.TabStop = False
        '
        'RUCTransportista
        '
        Me.RUCTransportista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RUCTransportista.DataPropertyName = "NRUCTR"
        Me.RUCTransportista.HeaderText = "RUC"
        Me.RUCTransportista.MaxInputLength = 20
        Me.RUCTransportista.Name = "RUCTransportista"
        Me.RUCTransportista.ReadOnly = True
        Me.RUCTransportista.Visible = False
        Me.RUCTransportista.Width = 58
        '
        'Placa
        '
        Me.Placa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Placa.DataPropertyName = "NPLCUN"
        Me.Placa.HeaderText = "N° de Placa"
        Me.Placa.MaxInputLength = 10
        Me.Placa.Name = "Placa"
        Me.Placa.ReadOnly = True
        Me.Placa.Width = 93
        '
        'Color
        '
        Me.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Color.DataPropertyName = "TCLRUN"
        Me.Color.HeaderText = "Color"
        Me.Color.MaxInputLength = 40
        Me.Color.Name = "Color"
        Me.Color.ReadOnly = True
        Me.Color.Width = 64
        '
        'Modelo
        '
        Me.Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Modelo.DataPropertyName = "TMRCTR"
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.MaxInputLength = 60
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 76
        '
        'Conductor
        '
        Me.Conductor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Conductor.DataPropertyName = "CBRCND"
        Me.Conductor.HeaderText = "Brevete"
        Me.Conductor.MaxInputLength = 80
        Me.Conductor.Name = "Conductor"
        Me.Conductor.ReadOnly = True
        Me.Conductor.Width = 74
        '
        'Acoplado
        '
        Me.Acoplado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Acoplado.DataPropertyName = "NPLACP"
        Me.Acoplado.HeaderText = "Acoplado"
        Me.Acoplado.MaxInputLength = 10
        Me.Acoplado.Name = "Acoplado"
        Me.Acoplado.ReadOnly = True
        Me.Acoplado.Width = 85
        '
        'TipoCarroceria
        '
        Me.TipoCarroceria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TipoCarroceria.DataPropertyName = "TCMCRA"
        Me.TipoCarroceria.HeaderText = "Tipo Carrocería"
        Me.TipoCarroceria.Name = "TipoCarroceria"
        Me.TipoCarroceria.ReadOnly = True
        Me.TipoCarroceria.Width = 113
        '
        'Ubicación
        '
        Me.Ubicación.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "System.Drawing.Bitmap"
        Me.Ubicación.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ubicación.HeaderText = "Ubicación GPS"
        Me.Ubicación.Name = "Ubicación"
        Me.Ubicación.ReadOnly = True
        Me.Ubicación.Visible = False
        Me.Ubicación.Width = 91
        '
        'FECGPS
        '
        Me.FECGPS.ActiveLinkColor = System.Drawing.Color.Teal
        Me.FECGPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECGPS.DataPropertyName = "FECGPS"
        Me.FECGPS.HeaderText = "Fecha y Hora GPS"
        Me.FECGPS.LinkColor = System.Drawing.Color.Green
        Me.FECGPS.Name = "FECGPS"
        Me.FECGPS.ReadOnly = True
        Me.FECGPS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FECGPS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FECGPS.ToolTipText = "Hacer click para ver Localización de vehiculo en Google Maps"
        Me.FECGPS.VisitedLinkColor = System.Drawing.Color.Teal
        Me.FECGPS.Width = 125
        '
        'HORGPS
        '
        Me.HORGPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HORGPS.DataPropertyName = "HORGPS"
        Me.HORGPS.HeaderText = "Hora GPS"
        Me.HORGPS.Name = "HORGPS"
        Me.HORGPS.ReadOnly = True
        Me.HORGPS.Visible = False
        Me.HORGPS.Width = 84
        '
        'Seguimiento
        '
        Me.Seguimiento.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Seguimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Seguimiento.DataPropertyName = "SEGUIMIENTO"
        Me.Seguimiento.HeaderText = "Seguimiento del Vehículo"
        Me.Seguimiento.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Seguimiento.Name = "Seguimiento"
        Me.Seguimiento.ReadOnly = True
        Me.Seguimiento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seguimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Seguimiento.ToolTipText = "Hacer click para ver seguimiento WAP"
        Me.Seguimiento.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Seguimiento.Width = 168
        '
        'GPSLAT
        '
        Me.GPSLAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GPSLAT.DataPropertyName = "GPSLAT"
        DataGridViewCellStyle2.NullValue = "0"
        Me.GPSLAT.DefaultCellStyle = DataGridViewCellStyle2
        Me.GPSLAT.HeaderText = "Latitud"
        Me.GPSLAT.MaxInputLength = 100
        Me.GPSLAT.Name = "GPSLAT"
        Me.GPSLAT.ReadOnly = True
        Me.GPSLAT.Visible = False
        Me.GPSLAT.Width = 72
        '
        'GPSLON
        '
        Me.GPSLON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GPSLON.DataPropertyName = "GPSLON"
        DataGridViewCellStyle3.NullValue = "0"
        Me.GPSLON.DefaultCellStyle = DataGridViewCellStyle3
        Me.GPSLON.HeaderText = "Longitud"
        Me.GPSLON.MaxInputLength = 100
        Me.GPSLON.Name = "GPSLON"
        Me.GPSLON.ReadOnly = True
        Me.GPSLON.Visible = False
        Me.GPSLON.Width = 83
        '
        'CodTipoCarroceria
        '
        Me.CodTipoCarroceria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodTipoCarroceria.DataPropertyName = "CTPCRA"
        Me.CodTipoCarroceria.HeaderText = "CTPCRA"
        Me.CodTipoCarroceria.Name = "CodTipoCarroceria"
        Me.CodTipoCarroceria.ReadOnly = True
        Me.CodTipoCarroceria.Visible = False
        Me.CodTipoCarroceria.Width = 75
        '
        'CodCliente
        '
        Me.CodCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodCliente.DataPropertyName = "CCLNT"
        Me.CodCliente.HeaderText = "CodCliente"
        Me.CodCliente.Name = "CodCliente"
        Me.CodCliente.ReadOnly = True
        Me.CodCliente.Visible = False
        Me.CodCliente.Width = 93
        '
        'Cliente
        '
        Me.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cliente.DataPropertyName = "TCMPCL"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 72
        '
        'NCOACC
        '
        Me.NCOACC.HeaderText = "Acción"
        Me.NCOACC.Name = "NCOACC"
        Me.NCOACC.ReadOnly = True
        Me.NCOACC.Visible = False
        Me.NCOACC.Width = 70
        '
        'CBRCNT
        '
        Me.CBRCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CBRCNT.DataPropertyName = "CBRCNT"
        Me.CBRCNT.HeaderText = "Conductor"
        Me.CBRCNT.Name = "CBRCNT"
        Me.CBRCNT.ReadOnly = True
        Me.CBRCNT.Width = 250
        '
        'dtpFechaUbicacion
        '
        Me.dtpFechaUbicacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaUbicacion.Location = New System.Drawing.Point(414, 2)
        Me.dtpFechaUbicacion.Name = "dtpFechaUbicacion"
        Me.dtpFechaUbicacion.Size = New System.Drawing.Size(90, 20)
        Me.dtpFechaUbicacion.TabIndex = 116
        '
        'TabOperacion
        '
        Me.TabOperacion.Controls.Add(Me.tabInformacion)
        Me.TabOperacion.Controls.Add(Me.tabBitacora)
        Me.TabOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabOperacion.Location = New System.Drawing.Point(0, 25)
        Me.TabOperacion.Name = "TabOperacion"
        Me.TabOperacion.SelectedIndex = 0
        Me.TabOperacion.Size = New System.Drawing.Size(1019, 243)
        Me.TabOperacion.TabIndex = 114
        '
        'tabInformacion
        '
        Me.tabInformacion.Controls.Add(Me.cmbConductor)
        Me.tabInformacion.Controls.Add(Me.cboVehiculos)
        Me.tabInformacion.Controls.Add(Me.cboTipoVehiculo)
        Me.tabInformacion.Controls.Add(Me.KryptonLabel3)
        Me.tabInformacion.Controls.Add(Me.cboAcoplados)
        Me.tabInformacion.Controls.Add(Me.KryptonLabel4)
        Me.tabInformacion.Controls.Add(Me.txtCliente)
        Me.tabInformacion.Controls.Add(Me.KryptonLabel2)
        Me.tabInformacion.Controls.Add(Me.KryptonLabel6)
        Me.tabInformacion.Controls.Add(Me.KryptonLabel5)
        Me.tabInformacion.Location = New System.Drawing.Point(4, 22)
        Me.tabInformacion.Name = "tabInformacion"
        Me.tabInformacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInformacion.Size = New System.Drawing.Size(1011, 217)
        Me.tabInformacion.TabIndex = 1
        Me.tabInformacion.Text = "Información"
        Me.tabInformacion.UseVisualStyleBackColor = True
        '
        'cmbConductor
        '
        Me.cmbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbConductor.Location = New System.Drawing.Point(114, 90)
        Me.cmbConductor.Name = "cmbConductor"
        Me.cmbConductor.pRequerido = False
        Me.cmbConductor.Size = New System.Drawing.Size(251, 21)
        Me.cmbConductor.TabIndex = 156
        '
        'cboVehiculos
        '
        Me.cboVehiculos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboVehiculos.BackColor = System.Drawing.Color.Transparent
        Me.cboVehiculos.Location = New System.Drawing.Point(114, 18)
        Me.cboVehiculos.Name = "cboVehiculos"
        Me.cboVehiculos.pRequerido = False
        Me.cboVehiculos.Size = New System.Drawing.Size(252, 21)
        Me.cboVehiculos.TabIndex = 114
        '
        'cboTipoVehiculo
        '
        Me.cboTipoVehiculo.BackColor = System.Drawing.Color.Transparent
        Me.cboTipoVehiculo.DataSource = Nothing
        Me.cboTipoVehiculo.DispleyMember = ""
        Me.cboTipoVehiculo.ListColumnas = Nothing
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(114, 125)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Obligatorio = False
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(252, 21)
        Me.cboTipoVehiculo.TabIndex = 118
        Me.cboTipoVehiculo.ValueMember = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(16, 55)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(58, 19)
        Me.KryptonLabel3.TabIndex = 109
        Me.KryptonLabel3.Text = "Acoplado"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Acoplado"
        '
        'cboAcoplados
        '
        Me.cboAcoplados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboAcoplados.BackColor = System.Drawing.Color.Transparent
        Me.cboAcoplados.Location = New System.Drawing.Point(114, 54)
        Me.cboAcoplados.Name = "cboAcoplados"
        Me.cboAcoplados.pRequerido = False
        Me.cboAcoplados.Size = New System.Drawing.Size(251, 21)
        Me.cboAcoplados.TabIndex = 117
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(16, 127)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(86, 19)
        Me.KryptonLabel4.TabIndex = 111
        Me.KryptonLabel4.Text = "Tipo Carrocería"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Tipo Carrocería"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(115, 162)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(250, 21)
        Me.txtCliente.TabIndex = 113
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(16, 19)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(42, 19)
        Me.KryptonLabel2.TabIndex = 108
        Me.KryptonLabel2.Text = "Tracto"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Tracto"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(16, 163)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(45, 19)
        Me.KryptonLabel6.TabIndex = 112
        Me.KryptonLabel6.Text = "Cliente"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Cliente"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(16, 91)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(63, 19)
        Me.KryptonLabel5.TabIndex = 110
        Me.KryptonLabel5.Text = "Conductor"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Conductor"
        '
        'tabBitacora
        '
        Me.tabBitacora.Controls.Add(Me.dgwBitacoraVehiculo)
        Me.tabBitacora.Location = New System.Drawing.Point(4, 22)
        Me.tabBitacora.Name = "tabBitacora"
        Me.tabBitacora.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBitacora.Size = New System.Drawing.Size(1011, 217)
        Me.tabBitacora.TabIndex = 2
        Me.tabBitacora.Text = "Bitácora"
        Me.tabBitacora.UseVisualStyleBackColor = True
        '
        'dgwBitacoraVehiculo
        '
        Me.dgwBitacoraVehiculo.AllowUserToAddRows = False
        Me.dgwBitacoraVehiculo.AllowUserToDeleteRows = False
        Me.dgwBitacoraVehiculo.AllowUserToResizeColumns = False
        Me.dgwBitacoraVehiculo.AllowUserToResizeRows = False
        Me.dgwBitacoraVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgwBitacoraVehiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgwBitacoraVehiculo.ColumnHeadersHeight = 30
        Me.dgwBitacoraVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgwBitacoraVehiculo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NMRCRL, Me.NRITEM, Me.FECSEG_S, Me.NPLCUN, Me.NPLCAC, Me.TCMCND, Me.TDSDES})
        Me.dgwBitacoraVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwBitacoraVehiculo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgwBitacoraVehiculo.Location = New System.Drawing.Point(3, 3)
        Me.dgwBitacoraVehiculo.MultiSelect = False
        Me.dgwBitacoraVehiculo.Name = "dgwBitacoraVehiculo"
        Me.dgwBitacoraVehiculo.ReadOnly = True
        Me.dgwBitacoraVehiculo.RowHeadersVisible = False
        Me.dgwBitacoraVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwBitacoraVehiculo.Size = New System.Drawing.Size(1005, 211)
        Me.dgwBitacoraVehiculo.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgwBitacoraVehiculo.TabIndex = 3
        Me.dgwBitacoraVehiculo.TabStop = False
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.Separator1, Me.btnGuardar, Me.Separator2, Me.btnCancelar, Me.Separator3, Me.btnEliminar, Me.Separator4, Me.btnAsignarGFH, Me.ToolStripSeparator1, Me.lblFecha})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1019, 25)
        Me.MenuBar.TabIndex = 157
        Me.MenuBar.TabStop = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(60, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'Separator3
        '
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'Separator4
        '
        Me.Separator4.Name = "Separator4"
        Me.Separator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnAsignarGFH
        '
        Me.btnAsignarGFH.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAsignarGFH.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAsignarGFH.Name = "btnAsignarGFH"
        Me.btnAsignarGFH.Size = New System.Drawing.Size(91, 22)
        Me.btnAsignarGFH.Text = "Asignar GFH"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblFecha
        '
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 22)
        Me.lblFecha.Text = "Fecha"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "N° de Placa"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCLRUN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 40
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TMRCTR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 60
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 80
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NPLACP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Acoplado"
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TCMCRA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tipo Carrocería"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SEGUIMIENTO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Seguimiento del Vehículo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "GPSLAT"
        DataGridViewCellStyle7.NullValue = "0"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn9.HeaderText = "Latitud"
        Me.DataGridViewTextBoxColumn9.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "GPSLON"
        DataGridViewCellStyle8.NullValue = "0"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn10.HeaderText = "Longitud"
        Me.DataGridViewTextBoxColumn10.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FECGPS"
        DataGridViewCellStyle9.NullValue = "0"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha GPS"
        Me.DataGridViewTextBoxColumn11.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "HORGPS"
        DataGridViewCellStyle10.NullValue = "0"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn12.HeaderText = "Hora GPS"
        Me.DataGridViewTextBoxColumn12.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CTPCRA"
        Me.DataGridViewTextBoxColumn13.HeaderText = "CTPCRA"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn14.HeaderText = "CodCliente"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NRITEM"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn16.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn16.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NPLCUN"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn17.HeaderText = "N° Placa Tracto"
        Me.DataGridViewTextBoxColumn17.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "NPLCAC"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn18.HeaderText = "N° Placa Acoplado"
        Me.DataGridViewTextBoxColumn18.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TOBS"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn19.HeaderText = "Condición"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TOBGFH"
        Me.DataGridViewTextBoxColumn20.HeaderText = "GFH"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "TDSDES"
        Me.DataGridViewTextBoxColumn21.HeaderText = "GFH"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'NMRCRL
        '
        Me.NMRCRL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRCRL.DataPropertyName = "NMRCRL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NMRCRL.DefaultCellStyle = DataGridViewCellStyle4
        Me.NMRCRL.HeaderText = "NMRCRL"
        Me.NMRCRL.MaxInputLength = 20
        Me.NMRCRL.Name = "NMRCRL"
        Me.NMRCRL.ReadOnly = True
        Me.NMRCRL.Visible = False
        Me.NMRCRL.Width = 80
        '
        'NRITEM
        '
        Me.NRITEM.DataPropertyName = "NRITEM"
        Me.NRITEM.HeaderText = "Item"
        Me.NRITEM.Name = "NRITEM"
        Me.NRITEM.ReadOnly = True
        Me.NRITEM.Width = 58
        '
        'FECSEG_S
        '
        Me.FECSEG_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECSEG_S.DataPropertyName = "FECSEG_S"
        Me.FECSEG_S.HeaderText = "Fecha"
        Me.FECSEG_S.Name = "FECSEG_S"
        Me.FECSEG_S.ReadOnly = True
        Me.FECSEG_S.Width = 66
        '
        'NPLCUN
        '
        Me.NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN.DataPropertyName = "NPLCUN"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NPLCUN.DefaultCellStyle = DataGridViewCellStyle5
        Me.NPLCUN.HeaderText = "N° Placa Tracto"
        Me.NPLCUN.MaxInputLength = 10
        Me.NPLCUN.Name = "NPLCUN"
        Me.NPLCUN.ReadOnly = True
        Me.NPLCUN.Width = 111
        '
        'NPLCAC
        '
        Me.NPLCAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCAC.DataPropertyName = "NPLCAC"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NPLCAC.DefaultCellStyle = DataGridViewCellStyle6
        Me.NPLCAC.HeaderText = "N° Placa Acoplado"
        Me.NPLCAC.Name = "NPLCAC"
        Me.NPLCAC.ReadOnly = True
        Me.NPLCAC.Width = 129
        '
        'TCMCND
        '
        Me.TCMCND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCMCND.DataPropertyName = "TCMCND"
        Me.TCMCND.HeaderText = "Condición"
        Me.TCMCND.Name = "TCMCND"
        Me.TCMCND.ReadOnly = True
        '
        'TDSDES
        '
        Me.TDSDES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TDSDES.DataPropertyName = "TDSDES"
        Me.TDSDES.HeaderText = "GFH"
        Me.TDSDES.Name = "TDSDES"
        Me.TDSDES.ReadOnly = True
        '
        'frmMantenimientoOperacionTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1019, 722)
        Me.Controls.Add(Me.PanelGrilla)
        Me.Controls.Add(Me.PanelFiltros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMantenimientoOperacionTransporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Operación Transporte"
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrilla.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabOperacion.ResumeLayout(False)
        Me.tabInformacion.ResumeLayout(False)
        Me.tabInformacion.PerformLayout()
        Me.tabBitacora.ResumeLayout(False)
        CType(Me.dgwBitacoraVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblVehiculo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelGrilla As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnRegistroWAP As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
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
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctbEvento As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnImprimir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnSeguimientoFlota As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ctbTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents ctbVehiculo As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents cmbPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabOperacion As System.Windows.Forms.TabControl
    Friend WithEvents tabInformacion As System.Windows.Forms.TabPage
    Friend WithEvents cboAcoplados As Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
    Friend WithEvents cboVehiculos As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents cboTipoCarroceria As CodeTextBox.CodeTextBox
    Friend WithEvents cboConductores As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tabBitacora As System.Windows.Forms.TabPage
    Friend WithEvents dgwBitacoraVehiculo As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtpFechaUbicacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboTipoVehiculo As Ransa.Utilitario.ucAyuda
    Friend WithEvents cmbConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
    Friend WithEvents RUCTransportista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Placa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Conductor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Acoplado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCarroceria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubicación As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents FECGPS As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents HORGPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seguimiento As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents GPSLAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPSLON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodTipoCarroceria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCOACC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAsignarGFH As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblFecha As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NMRCRL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECSEG_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMCND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDSDES As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
