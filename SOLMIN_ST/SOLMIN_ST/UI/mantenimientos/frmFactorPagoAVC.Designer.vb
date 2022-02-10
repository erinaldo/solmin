<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactorPagoAVC
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.dtgFactorPagoAVC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CTPMDT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TTPMDT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TCATEG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.IFCTPG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.SCATEG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnExportarExcel = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.txtClienteBusqueda = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.cmbCategoria = New System.Windows.Forms.ComboBox
    Me.cmbMedioTransporte = New System.Windows.Forms.ComboBox
    Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.txtFactorPago = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnNuevo = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEliminar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.dtgFactorPagoAVC, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderGroupFiltro.Panel.SuspendLayout()
    Me.HeaderGroupFiltro.SuspendLayout()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderDatos.Panel.SuspendLayout()
    Me.HeaderDatos.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.dtgFactorPagoAVC)
    Me.KryptonPanel.Controls.Add(Me.HeaderGroupFiltro)
    Me.KryptonPanel.Controls.Add(Me.HeaderDatos)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(1156, 832)
    Me.KryptonPanel.TabIndex = 0
    '
    'dtgFactorPagoAVC
    '
    Me.dtgFactorPagoAVC.AllowUserToAddRows = False
    Me.dtgFactorPagoAVC.AllowUserToDeleteRows = False
    Me.dtgFactorPagoAVC.AllowUserToOrderColumns = True
    Me.dtgFactorPagoAVC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
    Me.dtgFactorPagoAVC.ColumnHeadersHeight = 35
    Me.dtgFactorPagoAVC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCLNT, Me.CLIENTE, Me.CTPMDT, Me.TTPMDT, Me.TCATEG, Me.IFCTPG, Me.SCATEG})
    Me.dtgFactorPagoAVC.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgFactorPagoAVC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dtgFactorPagoAVC.Location = New System.Drawing.Point(0, 88)
    Me.dtgFactorPagoAVC.MultiSelect = False
    Me.dtgFactorPagoAVC.Name = "dtgFactorPagoAVC"
    Me.dtgFactorPagoAVC.ReadOnly = True
    Me.dtgFactorPagoAVC.RowTemplate.Height = 16
    Me.dtgFactorPagoAVC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dtgFactorPagoAVC.Size = New System.Drawing.Size(1156, 552)
    Me.dtgFactorPagoAVC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgFactorPagoAVC.TabIndex = 0
    '
    'CCLNT
    '
    Me.CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CCLNT.DataPropertyName = "CCLNT"
    Me.CCLNT.HeaderText = "CCLNT"
    Me.CCLNT.Name = "CCLNT"
    Me.CCLNT.ReadOnly = True
    Me.CCLNT.Visible = False
    Me.CCLNT.Width = 68
    '
    'CLIENTE
    '
    Me.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CLIENTE.DataPropertyName = "CLIENTE"
    Me.CLIENTE.HeaderText = "Cliente"
    Me.CLIENTE.Name = "CLIENTE"
    Me.CLIENTE.ReadOnly = True
    Me.CLIENTE.Visible = False
    Me.CLIENTE.Width = 72
    '
    'CTPMDT
    '
    Me.CTPMDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CTPMDT.DataPropertyName = "CTPMDT"
    Me.CTPMDT.HeaderText = "Código Medio " & Global.Microsoft.VisualBasic.ChrW(10) & " de Transporte"
    Me.CTPMDT.Name = "CTPMDT"
    Me.CTPMDT.ReadOnly = True
    Me.CTPMDT.Width = 113
    '
    'TTPMDT
    '
    Me.TTPMDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TTPMDT.DataPropertyName = "TTPMDT"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.TTPMDT.DefaultCellStyle = DataGridViewCellStyle1
    Me.TTPMDT.HeaderText = "Medio de Transporte"
    Me.TTPMDT.Name = "TTPMDT"
    Me.TTPMDT.ReadOnly = True
    '
    'TCATEG
    '
    Me.TCATEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TCATEG.DataPropertyName = "TCATEG"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.TCATEG.DefaultCellStyle = DataGridViewCellStyle2
    Me.TCATEG.HeaderText = "Categoria Chofer"
    Me.TCATEG.Name = "TCATEG"
    Me.TCATEG.ReadOnly = True
    '
    'IFCTPG
    '
    Me.IFCTPG.DataPropertyName = "IFCTPG"
    Me.IFCTPG.HeaderText = "Factor de pago"
    Me.IFCTPG.Name = "IFCTPG"
    Me.IFCTPG.ReadOnly = True
    '
    'SCATEG
    '
    Me.SCATEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.SCATEG.DataPropertyName = "SCATEG"
    Me.SCATEG.HeaderText = "SCATEG"
    Me.SCATEG.Name = "SCATEG"
    Me.SCATEG.ReadOnly = True
    Me.SCATEG.Visible = False
    Me.SCATEG.Width = 75
    '
    'HeaderGroupFiltro
    '
    Me.HeaderGroupFiltro.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnExportarExcel, Me.btnBuscar})
    Me.HeaderGroupFiltro.Dock = System.Windows.Forms.DockStyle.Top
    Me.HeaderGroupFiltro.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderGroupFiltro.Location = New System.Drawing.Point(0, 0)
    Me.HeaderGroupFiltro.Name = "HeaderGroupFiltro"
    '
    'HeaderGroupFiltro.Panel
    '
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtClienteBusqueda)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel18)
    Me.HeaderGroupFiltro.Size = New System.Drawing.Size(1156, 88)
    Me.HeaderGroupFiltro.TabIndex = 11
    Me.HeaderGroupFiltro.Text = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
    Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
    Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
    '
    'btnExportarExcel
    '
    Me.btnExportarExcel.ExtraText = ""
    Me.btnExportarExcel.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnExportarExcel.Image = Global.SOLMIN_ST.My.Resources.Resources.excel1
    Me.btnExportarExcel.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnExportarExcel.Text = "Exportar"
    Me.btnExportarExcel.ToolTipBody = "Exportar Excel"
    Me.btnExportarExcel.ToolTipImage = Nothing
    Me.btnExportarExcel.UniqueName = "DFF5FEE620A14875DFF5FEE620A14875"
    '
    'btnBuscar
    '
    Me.btnBuscar.ExtraText = ""
    Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
    Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.ToolTipImage = Nothing
    Me.btnBuscar.UniqueName = "D45E57CE184C4689D45E57CE184C4689"
    '
    'txtClienteBusqueda
    '
    Me.txtClienteBusqueda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.txtClienteBusqueda.BackColor = System.Drawing.Color.Transparent
    Me.txtClienteBusqueda.CCMPN = "EZ"
    Me.txtClienteBusqueda.Location = New System.Drawing.Point(82, 9)
    Me.txtClienteBusqueda.Name = "txtClienteBusqueda"
    Me.txtClienteBusqueda.pAccesoPorUsuario = False
    Me.txtClienteBusqueda.pRequerido = False
    Me.txtClienteBusqueda.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.txtClienteBusqueda.Size = New System.Drawing.Size(338, 21)
    Me.txtClienteBusqueda.TabIndex = 0
    '
    'KryptonLabel18
    '
    Me.KryptonLabel18.Location = New System.Drawing.Point(30, 10)
    Me.KryptonLabel18.Name = "KryptonLabel18"
    Me.KryptonLabel18.Size = New System.Drawing.Size(45, 19)
    Me.KryptonLabel18.TabIndex = 4
    Me.KryptonLabel18.Text = "Cliente"
    Me.KryptonLabel18.Values.ExtraText = ""
    Me.KryptonLabel18.Values.Image = Nothing
    Me.KryptonLabel18.Values.Text = "Cliente"
    '
    'HeaderDatos
    '
    Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderDatos.HeaderVisibleSecondary = False
    Me.HeaderDatos.Location = New System.Drawing.Point(0, 640)
    Me.HeaderDatos.Name = "HeaderDatos"
    '
    'HeaderDatos.Panel
    '
    Me.HeaderDatos.Panel.Controls.Add(Me.Panel1)
    Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
    Me.HeaderDatos.Size = New System.Drawing.Size(1156, 192)
    Me.HeaderDatos.TabIndex = 10
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
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Controls.Add(Me.KryptonLabel12)
    Me.Panel1.Controls.Add(Me.KryptonLabel6)
    Me.Panel1.Controls.Add(Me.KryptonLabel4)
    Me.Panel1.Controls.Add(Me.KryptonLabel3)
    Me.Panel1.Controls.Add(Me.KryptonLabel13)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 29)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1154, 141)
    Me.Panel1.TabIndex = 35
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.cmbCategoria)
    Me.Panel2.Controls.Add(Me.cmbMedioTransporte)
    Me.Panel2.Controls.Add(Me.txtCliente)
    Me.Panel2.Controls.Add(Me.txtFactorPago)
    Me.Panel2.Location = New System.Drawing.Point(118, 11)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(436, 119)
    Me.Panel2.TabIndex = 35
    '
    'cmbCategoria
    '
    Me.cmbCategoria.FormattingEnabled = True
    Me.cmbCategoria.Location = New System.Drawing.Point(17, 62)
    Me.cmbCategoria.Name = "cmbCategoria"
    Me.cmbCategoria.Size = New System.Drawing.Size(320, 21)
    Me.cmbCategoria.TabIndex = 2
    '
    'cmbMedioTransporte
    '
    Me.cmbMedioTransporte.FormattingEnabled = True
    Me.cmbMedioTransporte.Location = New System.Drawing.Point(17, 33)
    Me.cmbMedioTransporte.Name = "cmbMedioTransporte"
    Me.cmbMedioTransporte.Size = New System.Drawing.Size(320, 21)
    Me.cmbMedioTransporte.TabIndex = 0
    '
    'txtCliente
    '
    Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.txtCliente.BackColor = System.Drawing.Color.Transparent
    Me.txtCliente.CCMPN = "EZ"
    Me.txtCliente.Location = New System.Drawing.Point(16, 6)
    Me.txtCliente.Name = "txtCliente"
    Me.txtCliente.pAccesoPorUsuario = False
    Me.txtCliente.pRequerido = False
    Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.txtCliente.Size = New System.Drawing.Size(320, 21)
    Me.txtCliente.TabIndex = 1
    '
    'txtFactorPago
    '
    Me.txtFactorPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtFactorPago.Location = New System.Drawing.Point(17, 91)
    Me.txtFactorPago.MaxLength = 6
    Me.txtFactorPago.Name = "txtFactorPago"
    Me.txtFactorPago.Size = New System.Drawing.Size(95, 21)
    Me.txtFactorPago.TabIndex = 3
    Me.txtFactorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'KryptonLabel12
    '
    Me.KryptonLabel12.Location = New System.Drawing.Point(11, 49)
    Me.KryptonLabel12.Name = "KryptonLabel12"
    Me.KryptonLabel12.Size = New System.Drawing.Size(105, 19)
    Me.KryptonLabel12.TabIndex = 34
    Me.KryptonLabel12.Text = "Medio Transporte :"
    Me.KryptonLabel12.Values.ExtraText = ""
    Me.KryptonLabel12.Values.Image = Nothing
    Me.KryptonLabel12.Values.Text = "Medio Transporte :"
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(11, 105)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(88, 19)
    Me.KryptonLabel6.TabIndex = 3
    Me.KryptonLabel6.Text = "Factor de pago:"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Factor de pago:"
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(11, 78)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(101, 19)
    Me.KryptonLabel4.TabIndex = 3
    Me.KryptonLabel4.Text = "Categoria Chofer : "
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Categoria Chofer : "
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(11, 20)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(50, 19)
    Me.KryptonLabel3.TabIndex = 3
    Me.KryptonLabel3.Text = "Cliente :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Cliente :"
    '
    'KryptonLabel13
    '
    Me.KryptonLabel13.Location = New System.Drawing.Point(484, 187)
    Me.KryptonLabel13.Name = "KryptonLabel13"
    Me.KryptonLabel13.Size = New System.Drawing.Size(6, 2)
    Me.KryptonLabel13.TabIndex = 31
    Me.KryptonLabel13.Values.ExtraText = ""
    Me.KryptonLabel13.Values.Image = Nothing
    Me.KryptonLabel13.Values.Text = ""
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.ImageScalingSize = New System.Drawing.Size(22, 22)
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(1154, 29)
    Me.MenuBar.TabIndex = 0
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnNuevo
    '
    Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
    Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(66, 26)
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
    Me.btnCancelar.Size = New System.Drawing.Size(77, 26)
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
    Me.btnEliminar.Size = New System.Drawing.Size(74, 26)
    Me.btnEliminar.Text = "Eliminar"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "CCLNT"
    Me.DataGridViewTextBoxColumn1.HeaderText = "CCLNT"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Visible = False
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "CLIENTE"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Cliente"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    Me.DataGridViewTextBoxColumn2.Visible = False
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "CTPMDT"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Código Medio " & Global.Microsoft.VisualBasic.ChrW(10) & " Transporte"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "TTPMDT"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
    Me.DataGridViewTextBoxColumn4.HeaderText = "Medio de Transporte"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "TCATEG"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
    Me.DataGridViewTextBoxColumn5.HeaderText = "Categoria Chofer"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    Me.DataGridViewTextBoxColumn5.Visible = False
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "IFCTPG"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle5.Format = "N5"
    DataGridViewCellStyle5.NullValue = Nothing
    Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
    Me.DataGridViewTextBoxColumn6.HeaderText = "Factor de pago"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "SCATEG"
    Me.DataGridViewTextBoxColumn7.HeaderText = "SCATEG"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    Me.DataGridViewTextBoxColumn7.Visible = False
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn8.DataPropertyName = "SCATEG"
    Me.DataGridViewTextBoxColumn8.HeaderText = "SCATEG"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.Visible = False
    '
    'frmFactorPagoAVC
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1156, 832)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmFactorPagoAVC"
    Me.Text = "Factor de pago AVC "
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.dtgFactorPagoAVC, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
    Me.HeaderGroupFiltro.Panel.PerformLayout()
    CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupFiltro.ResumeLayout(False)
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderDatos.Panel.ResumeLayout(False)
    Me.HeaderDatos.Panel.PerformLayout()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderDatos.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtFactorPago As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents HeaderGroupFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnExportarExcel As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgFactorPagoAVC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtClienteBusqueda As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents cmbMedioTransporte As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPMDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TTPMDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCATEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IFCTPG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCATEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
