<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarVehiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarVehiculo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbPlanta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cmbDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ctbVehiculo = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
        Me.ctbTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01
        Me.ctbEvento = New CodeTextBox.CodeTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCLRUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMRCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_CTPCRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_TCMCRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLACP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ubicación = New System.Windows.Forms.DataGridViewImageColumn
        Me.Seguimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GPSLAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GPSLON = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECGPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HORGPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCOEVT = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrilla.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnBuscar, Me.ButtonSpecHeaderGroup1})
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
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbVehiculo)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbTransportista)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbEvento)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblVehiculo)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Size = New System.Drawing.Size(1033, 96)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = ""
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
        Me.btnBuscar.Text = "Busqueda"
        Me.btnBuscar.ToolTipImage = Nothing
        Me.btnBuscar.UniqueName = "F673E9D145974133F673E9D145974133"
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.ButtonSpecHeaderGroup1.Image = Global.SOLMIN_ST.My.Resources.Resources.agt_web
        Me.ButtonSpecHeaderGroup1.Text = "Seguimiento de Flota (Google Earth)"
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.UniqueName = "E2D9CC3EA14C4D37E2D9CC3EA14C4D37"
        Me.ButtonSpecHeaderGroup1.Visible = False
        '
        'cmbPlanta
        '
        Me.cmbPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.DropDownWidth = 156
        Me.cmbPlanta.FormattingEnabled = False
        Me.cmbPlanta.ItemHeight = 13
        Me.cmbPlanta.Location = New System.Drawing.Point(710, 7)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(258, 21)
        Me.cmbPlanta.TabIndex = 23
        Me.cmbPlanta.TabStop = False
        '
        'cmbDivision
        '
        Me.cmbDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.DropDownWidth = 156
        Me.cmbDivision.FormattingEnabled = False
        Me.cmbDivision.ItemHeight = 13
        Me.cmbDivision.Location = New System.Drawing.Point(418, 7)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(216, 21)
        Me.cmbDivision.TabIndex = 21
        Me.cmbDivision.TabStop = False
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(655, 12)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(49, 16)
        Me.lblPlanta.TabIndex = 22
        Me.lblPlanta.Text = "Planta :"
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(343, 13)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(56, 16)
        Me.KryptonLabel5.TabIndex = 20
        Me.KryptonLabel5.Text = "División :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "División :"
        '
        'cmbCompania
        '
        Me.cmbCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.DropDownWidth = 248
        Me.cmbCompania.FormattingEnabled = False
        Me.cmbCompania.ItemHeight = 13
        Me.cmbCompania.Location = New System.Drawing.Point(87, 7)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(242, 21)
        Me.cmbCompania.TabIndex = 18
        Me.cmbCompania.TabStop = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(62, 16)
        Me.KryptonLabel3.TabIndex = 19
        Me.KryptonLabel3.Text = "Compañía"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Compañía"
        '
        'ctbVehiculo
        '
        Me.ctbVehiculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbVehiculo.BackColor = System.Drawing.Color.Transparent
        Me.ctbVehiculo.Location = New System.Drawing.Point(418, 34)
        Me.ctbVehiculo.Name = "ctbVehiculo"
        Me.ctbVehiculo.pRequerido = False
        Me.ctbVehiculo.Size = New System.Drawing.Size(216, 19)
        Me.ctbVehiculo.TabIndex = 9
        '
        'ctbTransportista
        '
        Me.ctbTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbTransportista.BackColor = System.Drawing.Color.Transparent
        Me.ctbTransportista.Location = New System.Drawing.Point(87, 35)
        Me.ctbTransportista.Name = "ctbTransportista"
        Me.ctbTransportista.pNroRegPorPaginas = 0
        Me.ctbTransportista.pRequerido = False
        Me.ctbTransportista.Size = New System.Drawing.Size(242, 19)
        Me.ctbTransportista.TabIndex = 8
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
        Me.ctbEvento.Location = New System.Drawing.Point(710, 34)
        Me.ctbEvento.Name = "ctbEvento"
        Me.ctbEvento.Size = New System.Drawing.Size(258, 23)
        Me.ctbEvento.TabIndex = 7
        Me.ctbEvento.TextBackColor = System.Drawing.Color.Empty
        Me.ctbEvento.TextForeColor = System.Drawing.Color.Empty
        Me.ctbEvento.ValueColumnVisible = True
        Me.ctbEvento.ValueColumnWidth = 600
        Me.ctbEvento.ValueField = ""
        Me.ctbEvento.ValueMember = ""
        Me.ctbEvento.ValueSearch = True
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(655, 37)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(51, 16)
        Me.KryptonLabel2.TabIndex = 6
        Me.KryptonLabel2.Text = "Eventos"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Eventos"
        '
        'lblVehiculo
        '
        Me.lblVehiculo.Location = New System.Drawing.Point(343, 38)
        Me.lblVehiculo.Name = "lblVehiculo"
        Me.lblVehiculo.Size = New System.Drawing.Size(54, 16)
        Me.lblVehiculo.TabIndex = 2
        Me.lblVehiculo.Text = "Vehículo"
        Me.lblVehiculo.Values.ExtraText = ""
        Me.lblVehiculo.Values.Image = Nothing
        Me.lblVehiculo.Values.Text = "Vehículo"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 37)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(88, 16)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Cia. Transporte"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cia. Transporte"
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.gwdDatos)
        Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 96)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.PanelGrilla.Size = New System.Drawing.Size(1033, 580)
        Me.PanelGrilla.TabIndex = 1
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToResizeColumns = False
        Me.gwdDatos.AllowUserToResizeRows = False
        Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRUCTR, Me.NPLCUN, Me.TCLRUN, Me.TMRCTR, Me.V_CTPCRA, Me.V_TCMCRA, Me.NPLACP, Me.CBRCNT, Me.Ubicación, Me.Seguimiento, Me.GPSLAT, Me.GPSLON, Me.FECGPS, Me.HORGPS, Me.NCOEVT})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersVisible = False
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(1033, 580)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 0
        Me.gwdDatos.TabStop = False
        '
        'NRUCTR
        '
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "RUC"
        Me.NRUCTR.MaxInputLength = 20
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Visible = False
        '
        'NPLCUN
        '
        Me.NPLCUN.DataPropertyName = "NPLCUN"
        Me.NPLCUN.HeaderText = "N° de Placa"
        Me.NPLCUN.MaxInputLength = 10
        Me.NPLCUN.Name = "NPLCUN"
        Me.NPLCUN.ReadOnly = True
        '
        'TCLRUN
        '
        Me.TCLRUN.DataPropertyName = "TCLRUN"
        Me.TCLRUN.HeaderText = "Color"
        Me.TCLRUN.MaxInputLength = 40
        Me.TCLRUN.Name = "TCLRUN"
        Me.TCLRUN.ReadOnly = True
        '
        'TMRCTR
        '
        Me.TMRCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCTR.DataPropertyName = "TMRCTR"
        Me.TMRCTR.HeaderText = "Modelo"
        Me.TMRCTR.MaxInputLength = 60
        Me.TMRCTR.Name = "TMRCTR"
        Me.TMRCTR.ReadOnly = True
        Me.TMRCTR.Width = 71
        '
        'V_CTPCRA
        '
        Me.V_CTPCRA.DataPropertyName = "CTPCRA"
        Me.V_CTPCRA.HeaderText = "Cod. Tipo Carroceria"
        Me.V_CTPCRA.MaxInputLength = 6
        Me.V_CTPCRA.Name = "V_CTPCRA"
        Me.V_CTPCRA.ReadOnly = True
        Me.V_CTPCRA.Visible = False
        '
        'V_TCMCRA
        '
        Me.V_TCMCRA.DataPropertyName = "TCMCRA"
        Me.V_TCMCRA.HeaderText = "Tipo Carroceria"
        Me.V_TCMCRA.MaxInputLength = 50
        Me.V_TCMCRA.Name = "V_TCMCRA"
        Me.V_TCMCRA.ReadOnly = True
        '
        'NPLACP
        '
        Me.NPLACP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLACP.DataPropertyName = "NPLACP"
        Me.NPLACP.HeaderText = "Acoplado"
        Me.NPLACP.MaxInputLength = 10
        Me.NPLACP.Name = "NPLACP"
        Me.NPLACP.ReadOnly = True
        Me.NPLACP.Width = 81
        '
        'CBRCNT
        '
        Me.CBRCNT.DataPropertyName = "CBRCNT"
        Me.CBRCNT.HeaderText = "Conductor"
        Me.CBRCNT.MaxInputLength = 80
        Me.CBRCNT.Name = "CBRCNT"
        Me.CBRCNT.ReadOnly = True
        '
        'Ubicación
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "System.Drawing.Bitmap"
        Me.Ubicación.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ubicación.HeaderText = "Ubicación GPS"
        Me.Ubicación.Name = "Ubicación"
        Me.Ubicación.ReadOnly = True
        '
        'Seguimiento
        '
        Me.Seguimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Seguimiento.DataPropertyName = "SEGUIMIENTO"
        Me.Seguimiento.HeaderText = "Seguimiento del Vehículo"
        Me.Seguimiento.Name = "Seguimiento"
        Me.Seguimiento.ReadOnly = True
        Me.Seguimiento.Width = 157
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
        '
        'FECGPS
        '
        Me.FECGPS.DataPropertyName = "FECGPS"
        Me.FECGPS.HeaderText = "Fecha GPS"
        Me.FECGPS.Name = "FECGPS"
        Me.FECGPS.ReadOnly = True
        Me.FECGPS.Visible = False
        '
        'HORGPS
        '
        Me.HORGPS.DataPropertyName = "HORGPS"
        Me.HORGPS.HeaderText = "Hora GPS"
        Me.HORGPS.Name = "HORGPS"
        Me.HORGPS.ReadOnly = True
        Me.HORGPS.Visible = False
        '
        'NCOEVT
        '
        Me.NCOEVT.HeaderText = "Evento"
        Me.NCOEVT.Name = "NCOEVT"
        Me.NCOEVT.ReadOnly = True
        Me.NCOEVT.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "N° de Placa"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 103
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCLRUN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 40
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 103
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TMRCTR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 60
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CTPCRA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cod. Tipo Carroceria"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TCMCRA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tipo Carroceria"
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 50
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 104
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NPLACP"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Acoplado"
        Me.DataGridViewTextBoxColumn7.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn8.MaxInputLength = 80
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 103
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SEGUIMIENTO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Seguimiento del Vehículo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "GPSLAT"
        DataGridViewCellStyle4.NullValue = "0"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn10.HeaderText = "Latitud"
        Me.DataGridViewTextBoxColumn10.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "GPSLON"
        DataGridViewCellStyle5.NullValue = "0"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn11.HeaderText = "Longitud"
        Me.DataGridViewTextBoxColumn11.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FECGPS"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fecha GPS"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "HORGPS"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Hora GPS"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Evento"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'frmConsultarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 676)
        Me.Controls.Add(Me.PanelGrilla)
        Me.Controls.Add(Me.PanelFiltros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConsultarVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Vehículos"
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrilla.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ctbEvento As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCLRUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents V_CTPCRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents V_TCMCRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubicación As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Seguimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPSLAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPSLON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECGPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORGPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCOEVT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ctbVehiculo As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents ctbTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents cmbCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
