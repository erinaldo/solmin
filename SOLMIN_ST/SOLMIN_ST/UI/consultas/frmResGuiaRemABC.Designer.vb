<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResGuiaRemABC
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HeaderGroupTabs = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ControlVisorVehiculo = New SOLMIN_ST.Control_Visor_Reporte
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Control_Visor_Reporte1 = New SOLMIN_ST.Control_Visor_Reporte
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Control_Visor_Reporte2 = New SOLMIN_ST.Control_Visor_Reporte
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnProcesarReporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.cmbPlantaDiv = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.cmbPlanta = New SOLMIN_ST.CheckComboBoxTest.CheckedComboBox
        Me.cmbDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.dtgReporte2 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.dtgReporte1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupTabs.Panel.SuspendLayout()
        Me.HeaderGroupTabs.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupFiltro.Panel.SuspendLayout()
        Me.HeaderGroupFiltro.SuspendLayout()
        CType(Me.dtgReporte2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgReporte1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HeaderGroupTabs)
        Me.KryptonPanel.Controls.Add(Me.HeaderGroupFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1070, 656)
        Me.KryptonPanel.TabIndex = 0
        '
        'HeaderGroupTabs
        '
        Me.HeaderGroupTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderGroupTabs.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupTabs.Location = New System.Drawing.Point(0, 103)
        Me.HeaderGroupTabs.Name = "HeaderGroupTabs"
        '
        'HeaderGroupTabs.Panel
        '
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.TabControl1)
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.Panel2)
        Me.HeaderGroupTabs.Size = New System.Drawing.Size(1070, 553)
        Me.HeaderGroupTabs.TabIndex = 3
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
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1068, 503)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ControlVisorVehiculo)
        Me.TabPage1.ImageIndex = 4
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1060, 477)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resumen General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ControlVisorVehiculo
        '
        Me.ControlVisorVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlVisorVehiculo.Location = New System.Drawing.Point(3, 3)
        Me.ControlVisorVehiculo.Name = "ControlVisorVehiculo"
        Me.ControlVisorVehiculo.Size = New System.Drawing.Size(1054, 471)
        Me.ControlVisorVehiculo.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Control_Visor_Reporte1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1060, 477)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resumen de Detalles Servicios por Cliente"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Control_Visor_Reporte1
        '
        Me.Control_Visor_Reporte1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Control_Visor_Reporte1.Location = New System.Drawing.Point(3, 3)
        Me.Control_Visor_Reporte1.Name = "Control_Visor_Reporte1"
        Me.Control_Visor_Reporte1.Size = New System.Drawing.Size(1054, 471)
        Me.Control_Visor_Reporte1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Control_Visor_Reporte2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1060, 477)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Resumen Servicios  Mixtos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Control_Visor_Reporte2
        '
        Me.Control_Visor_Reporte2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Control_Visor_Reporte2.Location = New System.Drawing.Point(3, 3)
        Me.Control_Visor_Reporte2.Name = "Control_Visor_Reporte2"
        Me.Control_Visor_Reporte2.Size = New System.Drawing.Size(1054, 471)
        Me.Control_Visor_Reporte2.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.MenuBar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1068, 25)
        Me.Panel2.TabIndex = 4
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesarReporte, Me.ToolStripSeparator1, Me.btnExportarExcel})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1068, 25)
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
        'btnExportarExcel
        '
        Me.btnExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarExcel.Image = Global.SOLMIN_ST.My.Resources.Resources.excelicon
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(98, 22)
        Me.btnExportarExcel.Text = "Exportar Excel"
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
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbPlantaDiv)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbPlanta)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbDivision)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbCompania)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtgReporte2)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtgReporte1)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel20)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel3)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaFin)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel4)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtCliente)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel19)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel5)
        Me.HeaderGroupFiltro.Size = New System.Drawing.Size(1070, 103)
        Me.HeaderGroupFiltro.TabIndex = 2
        Me.HeaderGroupFiltro.Text = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
        Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
        Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
        '
        'cmbPlantaDiv
        '
        Me.cmbPlantaDiv.BackColor = System.Drawing.Color.Transparent
        Me.cmbPlantaDiv.CodigoCompania = ""
        Me.cmbPlantaDiv.CodigoDivision = ""
        Me.cmbPlantaDiv.CPLNDV_ANTERIOR = Nothing
        Me.cmbPlantaDiv.DescripcionPlanta = ""
        Me.cmbPlantaDiv.ItemTodos = False
        Me.cmbPlantaDiv.Location = New System.Drawing.Point(726, 33)
        Me.cmbPlantaDiv.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbPlantaDiv.Name = "cmbPlantaDiv"
        Me.cmbPlantaDiv.Planta = 0
        Me.cmbPlantaDiv.PlantaDefault = -1
        Me.cmbPlantaDiv.pRequerido = False
        Me.cmbPlantaDiv.Size = New System.Drawing.Size(175, 23)
        Me.cmbPlantaDiv.TabIndex = 137
        Me.cmbPlantaDiv.Usuario = ""
        Me.cmbPlantaDiv.Visible = False
        '
        'cmbPlanta
        '
        Me.cmbPlanta.CheckOnClick = True
        Me.cmbPlanta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbPlanta.DropDownHeight = 1
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.IntegralHeight = False
        Me.cmbPlanta.Location = New System.Drawing.Point(726, 6)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(175, 21)
        Me.cmbPlanta.TabIndex = 136
        Me.cmbPlanta.ValueSeparator = ", "
        '
        'cmbDivision
        '
        Me.cmbDivision.BackColor = System.Drawing.Color.Transparent
        Me.cmbDivision.CDVSN_ANTERIOR = Nothing
        Me.cmbDivision.Compania = ""
        Me.cmbDivision.Division = Nothing
        Me.cmbDivision.DivisionDefault = Nothing
        Me.cmbDivision.DivisionDescripcion = Nothing
        Me.cmbDivision.ItemTodos = False
        Me.cmbDivision.Location = New System.Drawing.Point(433, 10)
        Me.cmbDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(211, 23)
        Me.cmbDivision.TabIndex = 134
        Me.cmbDivision.Usuario = ""
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Location = New System.Drawing.Point(110, 10)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(250, 23)
        Me.cmbCompania.TabIndex = 133
        Me.cmbCompania.Usuario = ""
        '
        'dtgReporte2
        '
        Me.dtgReporte2.AccessibleDescription = ""
        Me.dtgReporte2.AllowUserToAddRows = False
        Me.dtgReporte2.AllowUserToDeleteRows = False
        Me.dtgReporte2.AllowUserToResizeColumns = False
        Me.dtgReporte2.AllowUserToResizeRows = False
        Me.dtgReporte2.ColumnHeadersHeight = 20
        Me.dtgReporte2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgReporte2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgReporte2.Location = New System.Drawing.Point(301, 71)
        Me.dtgReporte2.MultiSelect = False
        Me.dtgReporte2.Name = "dtgReporte2"
        Me.dtgReporte2.ReadOnly = True
        Me.dtgReporte2.RowHeadersWidth = 20
        Me.dtgReporte2.RowTemplate.Height = 16
        Me.dtgReporte2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgReporte2.Size = New System.Drawing.Size(226, 179)
        Me.dtgReporte2.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgReporte2.TabIndex = 106
        Me.dtgReporte2.Tag = "Resumen de Detalles Servicios por Cliente"
        Me.dtgReporte2.Visible = False
        '
        'dtgReporte1
        '
        Me.dtgReporte1.AccessibleDescription = ""
        Me.dtgReporte1.AllowUserToAddRows = False
        Me.dtgReporte1.AllowUserToDeleteRows = False
        Me.dtgReporte1.AllowUserToResizeColumns = False
        Me.dtgReporte1.AllowUserToResizeRows = False
        Me.dtgReporte1.ColumnHeadersHeight = 20
        Me.dtgReporte1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgReporte1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgReporte1.Location = New System.Drawing.Point(635, 71)
        Me.dtgReporte1.MultiSelect = False
        Me.dtgReporte1.Name = "dtgReporte1"
        Me.dtgReporte1.ReadOnly = True
        Me.dtgReporte1.RowHeadersWidth = 20
        Me.dtgReporte1.RowTemplate.Height = 16
        Me.dtgReporte1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgReporte1.Size = New System.Drawing.Size(113, 179)
        Me.dtgReporte1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgReporte1.TabIndex = 6
        Me.dtgReporte1.Tag = "Resumen Servicios Mixtos"
        Me.dtgReporte1.Visible = False
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(433, 43)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaInicio.TabIndex = 5
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(377, 45)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(26, 17)
        Me.KryptonLabel20.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel20.TabIndex = 105
        Me.KryptonLabel20.Text = "Del"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Del"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(679, 13)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(41, 17)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 103
        Me.KryptonLabel3.Text = "Planta"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(551, 43)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(93, 21)
        Me.dtpFechaFin.TabIndex = 6
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(372, 13)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(49, 17)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 103
        Me.KryptonLabel1.Text = "División"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "División"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(525, 45)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(20, 17)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 105
        Me.KryptonLabel4.Text = "Al"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Al"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(110, 43)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(250, 21)
        Me.txtCliente.TabIndex = 3
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(11, 13)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(60, 17)
        Me.KryptonLabel19.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel19.TabIndex = 103
        Me.KryptonLabel19.Text = "Compañía"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Compañía"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(10, 45)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(98, 17)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 105
        Me.KryptonLabel5.Text = "Código de Cliente"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Código de Cliente"
        '
        'frmResGuiaRemABC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 656)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmResGuiaRemABC"
        Me.Text = "Resumen Mensual Guias ABC"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupTabs.Panel.ResumeLayout(False)
        Me.HeaderGroupTabs.Panel.PerformLayout()
        CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupTabs.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
        Me.HeaderGroupFiltro.Panel.PerformLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.ResumeLayout(False)
        CType(Me.dtgReporte2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgReporte1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents HeaderGroupTabs As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ControlVisorVehiculo As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Control_Visor_Reporte1 As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Control_Visor_Reporte2 As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents dtgReporte2 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtgReporte1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents cmbDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    ' Friend WithEvents cmbPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents cmbPlanta As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents cmbPlantaDiv As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
End Class
