<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptResumenMensualSolicitud
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HeaderGroupTabs = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabCliente = New System.Windows.Forms.TabPage
        Me.ControlVisorCliente = New SOLMIN_ST.Control_Visor_Reporte
        Me.TabTransportista = New System.Windows.Forms.TabPage
        Me.ctbTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01
        Me.ControlVisorTransportista = New SOLMIN_ST.Control_Visor_Reporte
        Me.TabVehiculo = New System.Windows.Forms.TabPage
        Me.ctbTracto = New Ransa.Controls.Transportista.ucTracto_TxtF01
        Me.ControlVisorVehiculo = New SOLMIN_ST.Control_Visor_Reporte
        Me.TabAcoplado = New System.Windows.Forms.TabPage
        Me.ctbAcoplado = New Ransa.Controls.Transportista.ucAcoplado_TxtF01
        Me.ControlVisorAcoplado = New SOLMIN_ST.Control_Visor_Reporte
        Me.TabConductor = New System.Windows.Forms.TabPage
        Me.ctbConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01
        Me.ControlVisorConductor = New SOLMIN_ST.Control_Visor_Reporte
        Me.TabFecha = New System.Windows.Forms.TabPage
        Me.ControlVisorFecha = New SOLMIN_ST.Control_Visor_Reporte
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnProcesarReporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.chkcbxPlanta = New SOLMIN_ST.CheckComboBoxTest.CheckedComboBox
        Me.cmbPlanta = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.cmbDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GrpReporte = New System.Windows.Forms.GroupBox
        Me.chkFecha = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.chkCliente = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.chkAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.chkTransportista = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.chkConductor = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.chkVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.dtgReporte = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupTabs.Panel.SuspendLayout()
        Me.HeaderGroupTabs.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabCliente.SuspendLayout()
        Me.TabTransportista.SuspendLayout()
        Me.TabVehiculo.SuspendLayout()
        Me.TabAcoplado.SuspendLayout()
        Me.TabConductor.SuspendLayout()
        Me.TabFecha.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupFiltro.Panel.SuspendLayout()
        Me.HeaderGroupFiltro.SuspendLayout()
        Me.GrpReporte.SuspendLayout()
        CType(Me.dtgReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HeaderGroupTabs)
        Me.KryptonPanel.Controls.Add(Me.HeaderGroupFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1085, 660)
        Me.KryptonPanel.TabIndex = 0
        '
        'HeaderGroupTabs
        '
        Me.HeaderGroupTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderGroupTabs.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupTabs.Location = New System.Drawing.Point(0, 140)
        Me.HeaderGroupTabs.Name = "HeaderGroupTabs"
        '
        'HeaderGroupTabs.Panel
        '
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.TabControl1)
        Me.HeaderGroupTabs.Panel.Controls.Add(Me.Panel2)
        Me.HeaderGroupTabs.Size = New System.Drawing.Size(1085, 520)
        Me.HeaderGroupTabs.TabIndex = 4
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
        Me.TabControl1.Controls.Add(Me.TabCliente)
        Me.TabControl1.Controls.Add(Me.TabTransportista)
        Me.TabControl1.Controls.Add(Me.TabVehiculo)
        Me.TabControl1.Controls.Add(Me.TabAcoplado)
        Me.TabControl1.Controls.Add(Me.TabConductor)
        Me.TabControl1.Controls.Add(Me.TabFecha)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1083, 470)
        Me.TabControl1.TabIndex = 1
        '
        'TabCliente
        '
        Me.TabCliente.Controls.Add(Me.ControlVisorCliente)
        Me.TabCliente.Location = New System.Drawing.Point(4, 22)
        Me.TabCliente.Name = "TabCliente"
        Me.TabCliente.Size = New System.Drawing.Size(1075, 444)
        Me.TabCliente.TabIndex = 4
        Me.TabCliente.Text = "Cliente"
        Me.TabCliente.UseVisualStyleBackColor = True
        '
        'ControlVisorCliente
        '
        Me.ControlVisorCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlVisorCliente.Location = New System.Drawing.Point(0, 0)
        Me.ControlVisorCliente.Name = "ControlVisorCliente"
        Me.ControlVisorCliente.Size = New System.Drawing.Size(1075, 444)
        Me.ControlVisorCliente.TabIndex = 3
        '
        'TabTransportista
        '
        Me.TabTransportista.Controls.Add(Me.ctbTransportista)
        Me.TabTransportista.Controls.Add(Me.ControlVisorTransportista)
        Me.TabTransportista.Location = New System.Drawing.Point(4, 22)
        Me.TabTransportista.Name = "TabTransportista"
        Me.TabTransportista.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTransportista.Size = New System.Drawing.Size(1075, 444)
        Me.TabTransportista.TabIndex = 2
        Me.TabTransportista.Text = "Transportista"
        Me.TabTransportista.UseVisualStyleBackColor = True
        '
        'ctbTransportista
        '
        Me.ctbTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbTransportista.BackColor = System.Drawing.Color.Transparent
        Me.ctbTransportista.Location = New System.Drawing.Point(320, 7)
        Me.ctbTransportista.Name = "ctbTransportista"
        Me.ctbTransportista.pNroRegPorPaginas = 0
        Me.ctbTransportista.pRequerido = False
        Me.ctbTransportista.Size = New System.Drawing.Size(258, 21)
        Me.ctbTransportista.TabIndex = 3
        '
        'ControlVisorTransportista
        '
        Me.ControlVisorTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlVisorTransportista.Location = New System.Drawing.Point(3, 3)
        Me.ControlVisorTransportista.Name = "ControlVisorTransportista"
        Me.ControlVisorTransportista.Size = New System.Drawing.Size(1069, 438)
        Me.ControlVisorTransportista.TabIndex = 3
        '
        'TabVehiculo
        '
        Me.TabVehiculo.Controls.Add(Me.ctbTracto)
        Me.TabVehiculo.Controls.Add(Me.ControlVisorVehiculo)
        Me.TabVehiculo.ImageIndex = 4
        Me.TabVehiculo.Location = New System.Drawing.Point(4, 22)
        Me.TabVehiculo.Name = "TabVehiculo"
        Me.TabVehiculo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVehiculo.Size = New System.Drawing.Size(1075, 444)
        Me.TabVehiculo.TabIndex = 0
        Me.TabVehiculo.Text = "Vehículo"
        Me.TabVehiculo.UseVisualStyleBackColor = True
        '
        'ctbTracto
        '
        Me.ctbTracto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbTracto.BackColor = System.Drawing.Color.Transparent
        Me.ctbTracto.Location = New System.Drawing.Point(322, 7)
        Me.ctbTracto.Name = "ctbTracto"
        Me.ctbTracto.pNroRegPorPaginas = 0
        Me.ctbTracto.pRequerido = False
        Me.ctbTracto.Size = New System.Drawing.Size(258, 21)
        Me.ctbTracto.TabIndex = 1
        '
        'ControlVisorVehiculo
        '
        Me.ControlVisorVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlVisorVehiculo.Location = New System.Drawing.Point(3, 3)
        Me.ControlVisorVehiculo.Name = "ControlVisorVehiculo"
        Me.ControlVisorVehiculo.Size = New System.Drawing.Size(1069, 438)
        Me.ControlVisorVehiculo.TabIndex = 3
        '
        'TabAcoplado
        '
        Me.TabAcoplado.Controls.Add(Me.ctbAcoplado)
        Me.TabAcoplado.Controls.Add(Me.ControlVisorAcoplado)
        Me.TabAcoplado.Location = New System.Drawing.Point(4, 22)
        Me.TabAcoplado.Name = "TabAcoplado"
        Me.TabAcoplado.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAcoplado.Size = New System.Drawing.Size(1075, 444)
        Me.TabAcoplado.TabIndex = 3
        Me.TabAcoplado.Text = "Acoplado"
        Me.TabAcoplado.UseVisualStyleBackColor = True
        '
        'ctbAcoplado
        '
        Me.ctbAcoplado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbAcoplado.BackColor = System.Drawing.Color.Transparent
        Me.ctbAcoplado.Location = New System.Drawing.Point(324, 7)
        Me.ctbAcoplado.Name = "ctbAcoplado"
        Me.ctbAcoplado.pRequerido = False
        Me.ctbAcoplado.Size = New System.Drawing.Size(258, 21)
        Me.ctbAcoplado.TabIndex = 4
        '
        'ControlVisorAcoplado
        '
        Me.ControlVisorAcoplado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlVisorAcoplado.Location = New System.Drawing.Point(3, 3)
        Me.ControlVisorAcoplado.Name = "ControlVisorAcoplado"
        Me.ControlVisorAcoplado.Size = New System.Drawing.Size(1069, 438)
        Me.ControlVisorAcoplado.TabIndex = 3
        '
        'TabConductor
        '
        Me.TabConductor.Controls.Add(Me.ctbConductor)
        Me.TabConductor.Controls.Add(Me.ControlVisorConductor)
        Me.TabConductor.Location = New System.Drawing.Point(4, 22)
        Me.TabConductor.Name = "TabConductor"
        Me.TabConductor.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConductor.Size = New System.Drawing.Size(1075, 444)
        Me.TabConductor.TabIndex = 1
        Me.TabConductor.Text = "Conductor"
        Me.TabConductor.UseVisualStyleBackColor = True
        '
        'ctbConductor
        '
        Me.ctbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbConductor.BackColor = System.Drawing.Color.Transparent
        Me.ctbConductor.Location = New System.Drawing.Point(323, 7)
        Me.ctbConductor.Name = "ctbConductor"
        Me.ctbConductor.pRequerido = False
        Me.ctbConductor.Size = New System.Drawing.Size(258, 21)
        Me.ctbConductor.TabIndex = 2
        '
        'ControlVisorConductor
        '
        Me.ControlVisorConductor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlVisorConductor.Location = New System.Drawing.Point(3, 3)
        Me.ControlVisorConductor.Name = "ControlVisorConductor"
        Me.ControlVisorConductor.Size = New System.Drawing.Size(1069, 438)
        Me.ControlVisorConductor.TabIndex = 3
        '
        'TabFecha
        '
        Me.TabFecha.Controls.Add(Me.ControlVisorFecha)
        Me.TabFecha.Location = New System.Drawing.Point(4, 22)
        Me.TabFecha.Name = "TabFecha"
        Me.TabFecha.Size = New System.Drawing.Size(1075, 444)
        Me.TabFecha.TabIndex = 5
        Me.TabFecha.Text = "Fecha"
        Me.TabFecha.UseVisualStyleBackColor = True
        '
        'ControlVisorFecha
        '
        Me.ControlVisorFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlVisorFecha.Location = New System.Drawing.Point(0, 0)
        Me.ControlVisorFecha.Name = "ControlVisorFecha"
        Me.ControlVisorFecha.Size = New System.Drawing.Size(1075, 444)
        Me.ControlVisorFecha.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.MenuBar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1083, 25)
        Me.Panel2.TabIndex = 4
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesarReporte, Me.ToolStripSeparator1, Me.btnExportarExcel})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1083, 25)
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
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.chkcbxPlanta)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbPlanta)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbDivision)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbCompania)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.lblPlanta)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.lblCompania)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel7)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.GrpReporte)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtgReporte)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaFin)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel4)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtCliente)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel5)
        Me.HeaderGroupFiltro.Size = New System.Drawing.Size(1085, 140)
        Me.HeaderGroupFiltro.TabIndex = 3
        Me.HeaderGroupFiltro.Text = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
        Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
        Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
        '
        'chkcbxPlanta
        '
        Me.chkcbxPlanta.CheckOnClick = True
        Me.chkcbxPlanta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.chkcbxPlanta.DropDownHeight = 1
        Me.chkcbxPlanta.FormattingEnabled = True
        Me.chkcbxPlanta.IntegralHeight = False
        Me.chkcbxPlanta.Location = New System.Drawing.Point(700, 11)
        Me.chkcbxPlanta.Name = "chkcbxPlanta"
        Me.chkcbxPlanta.Size = New System.Drawing.Size(185, 21)
        Me.chkcbxPlanta.TabIndex = 141
        Me.chkcbxPlanta.ValueSeparator = ", "
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.Transparent
        Me.cmbPlanta.CodigoCompania = ""
        Me.cmbPlanta.CodigoDivision = ""
        Me.cmbPlanta.CPLNDV_ANTERIOR = Nothing
        Me.cmbPlanta.DescripcionPlanta = ""
        Me.cmbPlanta.ItemTodos = False
        Me.cmbPlanta.Location = New System.Drawing.Point(700, 65)
        Me.cmbPlanta.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Planta = 0
        Me.cmbPlanta.PlantaDefault = -1
        Me.cmbPlanta.pRequerido = False
        Me.cmbPlanta.Size = New System.Drawing.Size(185, 23)
        Me.cmbPlanta.TabIndex = 140
        Me.cmbPlanta.Usuario = ""
        Me.cmbPlanta.Visible = False
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
        Me.cmbDivision.Location = New System.Drawing.Point(403, 9)
        Me.cmbDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(216, 23)
        Me.cmbDivision.TabIndex = 139
        Me.cmbDivision.Usuario = ""
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Location = New System.Drawing.Point(85, 9)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(247, 23)
        Me.cmbCompania.TabIndex = 138
        Me.cmbCompania.Usuario = ""
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(645, 11)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(41, 19)
        Me.lblPlanta.TabIndex = 137
        Me.lblPlanta.Text = "Planta"
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(4, 11)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(61, 19)
        Me.lblCompania.TabIndex = 135
        Me.lblCompania.Text = "Compañia"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(338, 11)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel7.TabIndex = 136
        Me.KryptonLabel7.Text = "División"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "División"
        '
        'GrpReporte
        '
        Me.GrpReporte.BackColor = System.Drawing.Color.White
        Me.GrpReporte.Controls.Add(Me.chkFecha)
        Me.GrpReporte.Controls.Add(Me.chkCliente)
        Me.GrpReporte.Controls.Add(Me.chkAcoplado)
        Me.GrpReporte.Controls.Add(Me.chkTransportista)
        Me.GrpReporte.Controls.Add(Me.chkConductor)
        Me.GrpReporte.Controls.Add(Me.chkVehiculo)
        Me.GrpReporte.Location = New System.Drawing.Point(87, 67)
        Me.GrpReporte.Name = "GrpReporte"
        Me.GrpReporte.Size = New System.Drawing.Size(465, 38)
        Me.GrpReporte.TabIndex = 107
        Me.GrpReporte.TabStop = False
        Me.GrpReporte.Text = "Reporte"
        '
        'chkFecha
        '
        Me.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFecha.Location = New System.Drawing.Point(404, 16)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(52, 19)
        Me.chkFecha.TabIndex = 110
        Me.chkFecha.Text = "Fecha"
        Me.chkFecha.Values.ExtraText = ""
        Me.chkFecha.Values.Image = Nothing
        Me.chkFecha.Values.Text = "Fecha"
        '
        'chkCliente
        '
        Me.chkCliente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCliente.Location = New System.Drawing.Point(9, 16)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(58, 19)
        Me.chkCliente.TabIndex = 109
        Me.chkCliente.Text = "Cliente"
        Me.chkCliente.Values.ExtraText = ""
        Me.chkCliente.Values.Image = Nothing
        Me.chkCliente.Values.Text = "Cliente"
        '
        'chkAcoplado
        '
        Me.chkAcoplado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAcoplado.Location = New System.Drawing.Point(245, 16)
        Me.chkAcoplado.Name = "chkAcoplado"
        Me.chkAcoplado.Size = New System.Drawing.Size(71, 19)
        Me.chkAcoplado.TabIndex = 108
        Me.chkAcoplado.Text = "Acoplado"
        Me.chkAcoplado.Values.ExtraText = ""
        Me.chkAcoplado.Values.Image = Nothing
        Me.chkAcoplado.Values.Text = "Acoplado"
        '
        'chkTransportista
        '
        Me.chkTransportista.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTransportista.Location = New System.Drawing.Point(75, 16)
        Me.chkTransportista.Name = "chkTransportista"
        Me.chkTransportista.Size = New System.Drawing.Size(88, 19)
        Me.chkTransportista.TabIndex = 108
        Me.chkTransportista.Text = "Transportista"
        Me.chkTransportista.Values.ExtraText = ""
        Me.chkTransportista.Values.Image = Nothing
        Me.chkTransportista.Values.Text = "Transportista"
        '
        'chkConductor
        '
        Me.chkConductor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConductor.Location = New System.Drawing.Point(322, 16)
        Me.chkConductor.Name = "chkConductor"
        Me.chkConductor.Size = New System.Drawing.Size(76, 19)
        Me.chkConductor.TabIndex = 108
        Me.chkConductor.Text = "Conductor"
        Me.chkConductor.Values.ExtraText = ""
        Me.chkConductor.Values.Image = Nothing
        Me.chkConductor.Values.Text = "Conductor"
        '
        'chkVehiculo
        '
        Me.chkVehiculo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVehiculo.Location = New System.Drawing.Point(171, 16)
        Me.chkVehiculo.Name = "chkVehiculo"
        Me.chkVehiculo.Size = New System.Drawing.Size(66, 19)
        Me.chkVehiculo.TabIndex = 108
        Me.chkVehiculo.Text = "Vehículo"
        Me.chkVehiculo.Values.ExtraText = ""
        Me.chkVehiculo.Values.Image = Nothing
        Me.chkVehiculo.Values.Text = "Vehículo"
        '
        'dtgReporte
        '
        Me.dtgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgReporte.Location = New System.Drawing.Point(569, 97)
        Me.dtgReporte.Name = "dtgReporte"
        Me.dtgReporte.Size = New System.Drawing.Size(316, 84)
        Me.dtgReporte.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgReporte.TabIndex = 106
        Me.dtgReporte.Visible = False
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(403, 39)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaInicio.TabIndex = 5
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(535, 39)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaFin.TabIndex = 6
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(341, 41)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(40, 17)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 103
        Me.KryptonLabel2.Text = "Fecha"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(503, 41)
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
        Me.txtCliente.Location = New System.Drawing.Point(85, 39)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(247, 21)
        Me.txtCliente.TabIndex = 3
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.KryptonLabel5.Location = New System.Drawing.Point(4, 41)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(44, 17)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 105
        Me.KryptonLabel5.Text = "Cliente"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Cliente"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NPLCUN"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "Vehículo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NCSOTR"
        Me.DataGridViewTextBoxColumn2.HeaderText = "N° Solicitud"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FASGTR"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Solicitud"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NOPRCN"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "N° Operación"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CCLNT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'frmRptResumenMensualSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 660)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmRptResumenMensualSolicitud"
        Me.Text = "Resumen Mensual Solicitudes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupTabs.Panel.ResumeLayout(False)
        Me.HeaderGroupTabs.Panel.PerformLayout()
        CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupTabs.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabCliente.ResumeLayout(False)
        Me.TabTransportista.ResumeLayout(False)
        Me.TabVehiculo.ResumeLayout(False)
        Me.TabAcoplado.ResumeLayout(False)
        Me.TabConductor.ResumeLayout(False)
        Me.TabFecha.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
        Me.HeaderGroupFiltro.Panel.PerformLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.ResumeLayout(False)
        Me.GrpReporte.ResumeLayout(False)
        Me.GrpReporte.PerformLayout()
        CType(Me.dtgReporte, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents HeaderGroupTabs As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabVehiculo As System.Windows.Forms.TabPage
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabConductor As System.Windows.Forms.TabPage
    Friend WithEvents TabAcoplado As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabTransportista As System.Windows.Forms.TabPage
    Friend WithEvents ControlVisorVehiculo As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents ControlVisorConductor As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents ControlVisorTransportista As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents ControlVisorAcoplado As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents dtgReporte As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GrpReporte As System.Windows.Forms.GroupBox
    Friend WithEvents chkAcoplado As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkTransportista As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkConductor As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkVehiculo As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents TabCliente As System.Windows.Forms.TabPage
    Friend WithEvents TabFecha As System.Windows.Forms.TabPage
    Friend WithEvents chkCliente As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents ControlVisorCliente As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents ControlVisorFecha As SOLMIN_ST.Control_Visor_Reporte
    Friend WithEvents chkFecha As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents ctbTracto As Ransa.Controls.Transportista.ucTracto_TxtF01
    Friend WithEvents ctbAcoplado As Ransa.Controls.Transportista.ucAcoplado_TxtF01
    Friend WithEvents ctbConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
    Friend WithEvents ctbTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents cmbPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents cmbDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkcbxPlanta As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox
End Class
