<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarSeguimientoGPS
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarSeguimientoGPS))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.HeaderGroupTabs = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPage2 = New System.Windows.Forms.TabPage
    Me.HeaderBrowser = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.gwdDatosGPS = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
    Me.btnMaximizarMapa = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.ButtonSpecAny2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnProcesarReporte = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCerrarPantalla = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnPantallaAncha = New System.Windows.Forms.ToolStripButton
    Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.rdConsultaTractoInvividual = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rdConsultaSeguimientoFlota = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
    Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
    Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtPlaca = New SOLMIN_ST.TextField
    Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtUsuarioWap = New CodeTextBox.CodeTextBox
    Me.cboRolWap = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderGroupTabs.Panel.SuspendLayout()
    Me.HeaderGroupTabs.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    CType(Me.HeaderBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderBrowser.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderBrowser.SuspendLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    CType(Me.gwdDatosGPS, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel2.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderGroupFiltro.Panel.SuspendLayout()
    Me.HeaderGroupFiltro.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.HeaderGroupTabs)
    Me.KryptonPanel.Controls.Add(Me.HeaderGroupFiltro)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(1047, 581)
    Me.KryptonPanel.TabIndex = 0
    '
    'HeaderGroupTabs
    '
    Me.HeaderGroupTabs.Dock = System.Windows.Forms.DockStyle.Fill
    Me.HeaderGroupTabs.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderGroupTabs.Location = New System.Drawing.Point(0, 130)
    Me.HeaderGroupTabs.Name = "HeaderGroupTabs"
    '
    'HeaderGroupTabs.Panel
    '
    Me.HeaderGroupTabs.Panel.Controls.Add(Me.TabControl1)
    Me.HeaderGroupTabs.Panel.Controls.Add(Me.Panel2)
    Me.HeaderGroupTabs.Size = New System.Drawing.Size(1047, 451)
    Me.HeaderGroupTabs.TabIndex = 2
    Me.HeaderGroupTabs.Text = "Resultados"
    Me.HeaderGroupTabs.ValuesPrimary.Description = ""
    Me.HeaderGroupTabs.ValuesPrimary.Heading = "Resultados"
    Me.HeaderGroupTabs.ValuesPrimary.Image = Nothing
    Me.HeaderGroupTabs.ValuesSecondary.Description = ""
    Me.HeaderGroupTabs.ValuesSecondary.Heading = ""
    Me.HeaderGroupTabs.ValuesSecondary.Image = Nothing
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1045, 401)
    Me.TabControl1.TabIndex = 1
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.HeaderBrowser)
    Me.TabPage2.Controls.Add(Me.KryptonHeaderGroup1)
    Me.TabPage2.Controls.Add(Me.KryptonHeader1)
    Me.TabPage2.ImageIndex = 3
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(1037, 375)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Seguimiento GPS"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'HeaderBrowser
    '
    Me.HeaderBrowser.Dock = System.Windows.Forms.DockStyle.Fill
    Me.HeaderBrowser.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderBrowser.HeaderVisibleSecondary = False
    Me.HeaderBrowser.Location = New System.Drawing.Point(515, 31)
    Me.HeaderBrowser.Name = "HeaderBrowser"
    Me.HeaderBrowser.Size = New System.Drawing.Size(519, 341)
    Me.HeaderBrowser.TabIndex = 11
    Me.HeaderBrowser.Text = "Localizacion Global"
    Me.HeaderBrowser.ValuesPrimary.Description = ""
    Me.HeaderBrowser.ValuesPrimary.Heading = "Localizacion Global"
    Me.HeaderBrowser.ValuesPrimary.Image = Nothing
    Me.HeaderBrowser.ValuesSecondary.Description = ""
    Me.HeaderBrowser.ValuesSecondary.Heading = "Description"
    Me.HeaderBrowser.ValuesSecondary.Image = Nothing
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Left
    Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(3, 31)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.gwdDatosGPS)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(512, 341)
    Me.KryptonHeaderGroup1.TabIndex = 12
    Me.KryptonHeaderGroup1.Text = "Localizacion Global"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Localizacion Global"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'gwdDatosGPS
    '
    Me.gwdDatosGPS.ColumnHeadersHeight = 20
    Me.gwdDatosGPS.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwdDatosGPS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.gwdDatosGPS.Location = New System.Drawing.Point(0, 0)
    Me.gwdDatosGPS.Name = "gwdDatosGPS"
    Me.gwdDatosGPS.RowHeadersWidth = 20
    Me.gwdDatosGPS.RowTemplate.Height = 16
    Me.gwdDatosGPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatosGPS.Size = New System.Drawing.Size(510, 319)
    Me.gwdDatosGPS.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatosGPS.TabIndex = 10
    '
    'KryptonHeader1
    '
    Me.KryptonHeader1.AutoSize = False
    Me.KryptonHeader1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnMaximizarMapa, Me.ButtonSpecAny1, Me.ButtonSpecAny2})
    Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.KryptonHeader1.Location = New System.Drawing.Point(3, 3)
    Me.KryptonHeader1.Name = "KryptonHeader1"
    Me.KryptonHeader1.Size = New System.Drawing.Size(1031, 28)
    Me.KryptonHeader1.TabIndex = 9
    Me.KryptonHeader1.Text = "Listado de Posiciones GPS Reportadas"
    Me.KryptonHeader1.Values.Description = ""
    Me.KryptonHeader1.Values.Heading = "Listado de Posiciones GPS Reportadas"
    Me.KryptonHeader1.Values.Image = Nothing
    '
    'btnMaximizarMapa
    '
    Me.btnMaximizarMapa.ExtraText = ""
    Me.btnMaximizarMapa.Image = Global.SOLMIN_ST.My.Resources.Resources.agt_web
    Me.btnMaximizarMapa.Text = ""
    Me.btnMaximizarMapa.ToolTipImage = Nothing
    Me.btnMaximizarMapa.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMax
    Me.btnMaximizarMapa.UniqueName = "03D9794B69F24ABE03D9794B69F24ABE"
    Me.btnMaximizarMapa.Visible = False
    '
    'ButtonSpecAny1
    '
    Me.ButtonSpecAny1.ExtraText = ""
    Me.ButtonSpecAny1.Image = Global.SOLMIN_ST.My.Resources.Resources.agt_web
    Me.ButtonSpecAny1.Text = "Ruta Google Earth"
    Me.ButtonSpecAny1.ToolTipImage = Nothing
    Me.ButtonSpecAny1.UniqueName = "647A484864E04A06647A484864E04A06"
    '
    'ButtonSpecAny2
    '
    Me.ButtonSpecAny2.ExtraText = ""
    Me.ButtonSpecAny2.Image = Global.SOLMIN_ST.My.Resources.Resources.agt_web
    Me.ButtonSpecAny2.Text = "Ruta Google Maps"
    Me.ButtonSpecAny2.ToolTipImage = Nothing
    Me.ButtonSpecAny2.UniqueName = "BBCEDBA2CA544667BBCEDBA2CA544667"
    '
    'Panel2
    '
    Me.Panel2.AutoSize = True
    Me.Panel2.Controls.Add(Me.MenuBar)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(1045, 25)
    Me.Panel2.TabIndex = 4
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesarReporte, Me.ToolStripSeparator1, Me.btnCerrarPantalla, Me.ToolStripSeparator2, Me.btnPantallaAncha})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(1045, 25)
    Me.MenuBar.TabIndex = 2
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnProcesarReporte
    '
    Me.btnProcesarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnProcesarReporte.Image = Global.SOLMIN_ST.My.Resources.Resources.search
    Me.btnProcesarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnProcesarReporte.Name = "btnProcesarReporte"
    Me.btnProcesarReporte.Size = New System.Drawing.Size(61, 22)
    Me.btnProcesarReporte.Text = "Buscar"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnCerrarPantalla
    '
    Me.btnCerrarPantalla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCerrarPantalla.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCerrarPantalla.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCerrarPantalla.Name = "btnCerrarPantalla"
    Me.btnCerrarPantalla.Size = New System.Drawing.Size(102, 22)
    Me.btnCerrarPantalla.Text = "Cerrar Pantalla"
    Me.btnCerrarPantalla.Visible = False
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    Me.ToolStripSeparator2.Visible = False
    '
    'btnPantallaAncha
    '
    Me.btnPantallaAncha.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnPantallaAncha.Image = Global.SOLMIN_ST.My.Resources.Resources.window_fullscreen
    Me.btnPantallaAncha.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnPantallaAncha.Name = "btnPantallaAncha"
    Me.btnPantallaAncha.Size = New System.Drawing.Size(78, 22)
    Me.btnPantallaAncha.Text = "Maximizar"
    '
    'HeaderGroupFiltro
    '
    Me.HeaderGroupFiltro.Dock = System.Windows.Forms.DockStyle.Top
    Me.HeaderGroupFiltro.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderGroupFiltro.Location = New System.Drawing.Point(0, 0)
    Me.HeaderGroupFiltro.Name = "HeaderGroupFiltro"
    '
    'HeaderGroupFiltro.Panel
    '
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.GroupBox1)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaInicio)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaFin)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel20)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtPlaca)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel19)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtUsuarioWap)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboRolWap)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel18)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel17)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel21)
    Me.HeaderGroupFiltro.Size = New System.Drawing.Size(1047, 130)
    Me.HeaderGroupFiltro.TabIndex = 1
    Me.HeaderGroupFiltro.Text = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
    Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
    Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
    '
    'rdConsultaTractoInvividual
    '
    Me.rdConsultaTractoInvividual.Checked = True
    Me.rdConsultaTractoInvividual.Location = New System.Drawing.Point(10, 20)
    Me.rdConsultaTractoInvividual.Name = "rdConsultaTractoInvividual"
    Me.rdConsultaTractoInvividual.Size = New System.Drawing.Size(137, 19)
    Me.rdConsultaTractoInvividual.TabIndex = 111
    Me.rdConsultaTractoInvividual.Text = "Seguimiento Individual"
    Me.rdConsultaTractoInvividual.Values.ExtraText = ""
    Me.rdConsultaTractoInvividual.Values.Image = Nothing
    Me.rdConsultaTractoInvividual.Values.Text = "Seguimiento Individual"
    '
    'rdConsultaSeguimientoFlota
    '
    Me.rdConsultaSeguimientoFlota.Location = New System.Drawing.Point(165, 20)
    Me.rdConsultaSeguimientoFlota.Name = "rdConsultaSeguimientoFlota"
    Me.rdConsultaSeguimientoFlota.Size = New System.Drawing.Size(148, 19)
    Me.rdConsultaSeguimientoFlota.TabIndex = 110
    Me.rdConsultaSeguimientoFlota.Text = "Seguimiento Flota Propia"
    Me.rdConsultaSeguimientoFlota.Values.ExtraText = ""
    Me.rdConsultaSeguimientoFlota.Values.Image = Nothing
    Me.rdConsultaSeguimientoFlota.Values.Text = "Seguimiento Flota Propia"
    '
    'dtpFechaInicio
    '
    Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio.Location = New System.Drawing.Point(565, 55)
    Me.dtpFechaInicio.Name = "dtpFechaInicio"
    Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
    Me.dtpFechaInicio.TabIndex = 106
    '
    'KryptonLabel21
    '
    Me.KryptonLabel21.Location = New System.Drawing.Point(648, 56)
    Me.KryptonLabel21.Name = "KryptonLabel21"
    Me.KryptonLabel21.Size = New System.Drawing.Size(20, 19)
    Me.KryptonLabel21.TabIndex = 109
    Me.KryptonLabel21.Text = "Al"
    Me.KryptonLabel21.Values.ExtraText = ""
    Me.KryptonLabel21.Values.Image = Nothing
    Me.KryptonLabel21.Values.Text = "Al"
    '
    'dtpFechaFin
    '
    Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFin.Location = New System.Drawing.Point(668, 55)
    Me.dtpFechaFin.Name = "dtpFechaFin"
    Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
    Me.dtpFechaFin.TabIndex = 107
    '
    'KryptonLabel20
    '
    Me.KryptonLabel20.Location = New System.Drawing.Point(457, 57)
    Me.KryptonLabel20.Name = "KryptonLabel20"
    Me.KryptonLabel20.Size = New System.Drawing.Size(95, 17)
    Me.KryptonLabel20.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel20.TabIndex = 105
    Me.KryptonLabel20.Text = "Fecha Registro"
    Me.KryptonLabel20.Values.ExtraText = ""
    Me.KryptonLabel20.Values.Image = Nothing
    Me.KryptonLabel20.Values.Text = "Fecha Registro"
    '
    'txtPlaca
    '
    Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtPlaca.Location = New System.Drawing.Point(105, 18)
    Me.txtPlaca.MaxLength = 6
    Me.txtPlaca.Name = "txtPlaca"
    Me.txtPlaca.Size = New System.Drawing.Size(100, 21)
    Me.txtPlaca.TabIndex = 104
    Me.txtPlaca.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'KryptonLabel19
    '
    Me.KryptonLabel19.Location = New System.Drawing.Point(15, 20)
    Me.KryptonLabel19.Name = "KryptonLabel19"
    Me.KryptonLabel19.Size = New System.Drawing.Size(80, 17)
    Me.KryptonLabel19.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel19.TabIndex = 103
    Me.KryptonLabel19.Text = "Placa Tracto"
    Me.KryptonLabel19.Values.ExtraText = ""
    Me.KryptonLabel19.Values.Image = Nothing
    Me.KryptonLabel19.Values.Text = "Placa Tracto"
    '
    'txtUsuarioWap
    '
    Me.txtUsuarioWap.Codigo = ""
    Me.txtUsuarioWap.ControlHeight = 23
    Me.txtUsuarioWap.ControlImage = True
    Me.txtUsuarioWap.ControlReadOnly = False
    Me.txtUsuarioWap.Descripcion = ""
    Me.txtUsuarioWap.DisplayColumnVisible = True
    Me.txtUsuarioWap.DisplayMember = ""
    Me.txtUsuarioWap.KeyColumnWidth = 100
    Me.txtUsuarioWap.KeyField = ""
    Me.txtUsuarioWap.KeySearch = True
    Me.txtUsuarioWap.Location = New System.Drawing.Point(565, 17)
    Me.txtUsuarioWap.Name = "txtUsuarioWap"
    Me.txtUsuarioWap.Size = New System.Drawing.Size(190, 23)
    Me.txtUsuarioWap.TabIndex = 102
    Me.txtUsuarioWap.TextBackColor = System.Drawing.Color.Empty
    Me.txtUsuarioWap.TextForeColor = System.Drawing.Color.Empty
    Me.txtUsuarioWap.ValueColumnVisible = True
    Me.txtUsuarioWap.ValueColumnWidth = 600
    Me.txtUsuarioWap.ValueField = ""
    Me.txtUsuarioWap.ValueMember = ""
    Me.txtUsuarioWap.ValueSearch = True
    Me.txtUsuarioWap.Visible = False
    '
    'cboRolWap
    '
    Me.cboRolWap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboRolWap.DropDownWidth = 121
    Me.cboRolWap.FormattingEnabled = False
    Me.cboRolWap.ItemHeight = 13
    Me.cboRolWap.Location = New System.Drawing.Point(285, 18)
    Me.cboRolWap.Name = "cboRolWap"
    Me.cboRolWap.Size = New System.Drawing.Size(145, 21)
    Me.cboRolWap.TabIndex = 101
    Me.cboRolWap.Visible = False
    '
    'KryptonLabel18
    '
    Me.KryptonLabel18.Location = New System.Drawing.Point(455, 20)
    Me.KryptonLabel18.Name = "KryptonLabel18"
    Me.KryptonLabel18.Size = New System.Drawing.Size(54, 17)
    Me.KryptonLabel18.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel18.TabIndex = 100
    Me.KryptonLabel18.Text = "Usuario"
    Me.KryptonLabel18.Values.ExtraText = ""
    Me.KryptonLabel18.Values.Image = Nothing
    Me.KryptonLabel18.Values.Text = "Usuario"
    Me.KryptonLabel18.Visible = False
    '
    'KryptonLabel17
    '
    Me.KryptonLabel17.Location = New System.Drawing.Point(220, 20)
    Me.KryptonLabel17.Name = "KryptonLabel17"
    Me.KryptonLabel17.Size = New System.Drawing.Size(58, 17)
    Me.KryptonLabel17.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel17.TabIndex = 99
    Me.KryptonLabel17.Text = "Rol Wap"
    Me.KryptonLabel17.Values.ExtraText = ""
    Me.KryptonLabel17.Values.Image = Nothing
    Me.KryptonLabel17.Values.Text = "Rol Wap"
    Me.KryptonLabel17.Visible = False
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.SystemColors.Menu
    Me.GroupBox1.Controls.Add(Me.rdConsultaTractoInvividual)
    Me.GroupBox1.Controls.Add(Me.rdConsultaSeguimientoFlota)
    Me.GroupBox1.Location = New System.Drawing.Point(100, 49)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(330, 46)
    Me.GroupBox1.TabIndex = 112
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Seguimiento"
    '
    'frmConsultarSeguimientoGPS
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1047, 581)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmConsultarSeguimientoGPS"
    Me.Text = "Consultas Seguimiento GPS"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupTabs.Panel.ResumeLayout(False)
    Me.HeaderGroupTabs.Panel.PerformLayout()
    CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupTabs.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    CType(Me.HeaderBrowser.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.HeaderBrowser, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderBrowser.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.ResumeLayout(False)
    CType(Me.gwdDatosGPS, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
    Me.HeaderGroupFiltro.Panel.PerformLayout()
    CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupFiltro.ResumeLayout(False)
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
    Friend WithEvents HeaderGroupFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlaca As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUsuarioWap As CodeTextBox.CodeTextBox
    Friend WithEvents cboRolWap As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents HeaderGroupTabs As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnMaximizarMapa As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ButtonSpecAny2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCerrarPantalla As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPantallaAncha As System.Windows.Forms.ToolStripButton
    Friend WithEvents HeaderBrowser As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents gwdDatosGPS As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents rdConsultaTractoInvividual As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents rdConsultaSeguimientoFlota As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
