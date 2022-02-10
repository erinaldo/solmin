<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObrero
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmObrero))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.dtgObrero = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.COBRR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TNMBOB = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TCATEG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.SCATEG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.SACTIN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FINGCH = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FVNCCR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CMTCDS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.ctbCodigo = New CodeTextBox.CodeTextBox
    Me.cmbCategoria = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.txtCuentaSAP = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker
    Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker
    Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Me.txtNombre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnNuevo = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEliminar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
    Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnImprimir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.cboPlanta = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Me.cboDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Me.cboCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtNombreBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
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
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.dtgObrero, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderDatos.Panel.SuspendLayout()
    Me.HeaderDatos.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelFiltros.Panel.SuspendLayout()
    Me.PanelFiltros.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.dtgObrero)
    Me.KryptonPanel.Controls.Add(Me.HeaderDatos)
    Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(957, 720)
    Me.KryptonPanel.TabIndex = 0
    '
    'dtgObrero
    '
    Me.dtgObrero.AllowUserToAddRows = False
    Me.dtgObrero.AllowUserToDeleteRows = False
    Me.dtgObrero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dtgObrero.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.dtgObrero.ColumnHeadersHeight = 30
    Me.dtgObrero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dtgObrero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COBRR, Me.TNMBOB, Me.TCATEG, Me.SCATEG, Me.SACTIN, Me.FINGCH, Me.FVNCCR, Me.CMTCDS, Me.CCMPN, Me.CDVSN, Me.CPLNDV})
    Me.dtgObrero.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgObrero.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.dtgObrero.Location = New System.Drawing.Point(0, 100)
    Me.dtgObrero.MultiSelect = False
    Me.dtgObrero.Name = "dtgObrero"
    Me.dtgObrero.ReadOnly = True
    Me.dtgObrero.RowHeadersWidth = 20
    Me.dtgObrero.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.dtgObrero.RowTemplate.Height = 20
    Me.dtgObrero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dtgObrero.Size = New System.Drawing.Size(957, 415)
    Me.dtgObrero.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgObrero.TabIndex = 2
    '
    'COBRR
    '
    Me.COBRR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COBRR.DataPropertyName = "COBRR"
    Me.COBRR.HeaderText = "Código"
    Me.COBRR.Name = "COBRR"
    Me.COBRR.ReadOnly = True
    Me.COBRR.Width = 74
    '
    'TNMBOB
    '
    Me.TNMBOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TNMBOB.DataPropertyName = "TNMBOB"
    Me.TNMBOB.HeaderText = "Nombre"
    Me.TNMBOB.Name = "TNMBOB"
    Me.TNMBOB.ReadOnly = True
    '
    'TCATEG
    '
    Me.TCATEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.TCATEG.DataPropertyName = "TCATEG"
    Me.TCATEG.HeaderText = "Categoria Chofer"
    Me.TCATEG.Name = "TCATEG"
    Me.TCATEG.ReadOnly = True
    Me.TCATEG.Width = 124
    '
    'SCATEG
    '
    Me.SCATEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.SCATEG.DataPropertyName = "SCATEG"
    Me.SCATEG.HeaderText = "SCATEG"
    Me.SCATEG.Name = "SCATEG"
    Me.SCATEG.ReadOnly = True
    Me.SCATEG.Visible = False
    '
    'SACTIN
    '
    Me.SACTIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.SACTIN.DataPropertyName = "SACTIN"
    Me.SACTIN.HeaderText = "SACTIN"
    Me.SACTIN.Name = "SACTIN"
    Me.SACTIN.ReadOnly = True
    Me.SACTIN.Visible = False
    '
    'FINGCH
    '
    Me.FINGCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.FINGCH.DataPropertyName = "FINGCH"
    Me.FINGCH.HeaderText = "Fecha de Ingreso "
    Me.FINGCH.Name = "FINGCH"
    Me.FINGCH.ReadOnly = True
    Me.FINGCH.Width = 127
    '
    'FVNCCR
    '
    Me.FVNCCR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.FVNCCR.DataPropertyName = "FVNCCR"
    Me.FVNCCR.HeaderText = "Fecha Vencimiento Contrato"
    Me.FVNCCR.Name = "FVNCCR"
    Me.FVNCCR.ReadOnly = True
    Me.FVNCCR.Width = 182
    '
    'CMTCDS
    '
    Me.CMTCDS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CMTCDS.DataPropertyName = "CMTCDS"
    Me.CMTCDS.HeaderText = "Matchcode SAP"
    Me.CMTCDS.Name = "CMTCDS"
    Me.CMTCDS.ReadOnly = True
    Me.CMTCDS.Width = 115
    '
    'CCMPN
    '
    Me.CCMPN.DataPropertyName = "CCMPN"
    Me.CCMPN.HeaderText = "Compañia"
    Me.CCMPN.Name = "CCMPN"
    Me.CCMPN.ReadOnly = True
    Me.CCMPN.Visible = False
    '
    'CDVSN
    '
    Me.CDVSN.DataPropertyName = "CDVSN"
    Me.CDVSN.HeaderText = "División"
    Me.CDVSN.Name = "CDVSN"
    Me.CDVSN.ReadOnly = True
    Me.CDVSN.Visible = False
    '
    'CPLNDV
    '
    Me.CPLNDV.DataPropertyName = "CPLNDV"
    Me.CPLNDV.HeaderText = "Planta"
    Me.CPLNDV.Name = "CPLNDV"
    Me.CPLNDV.ReadOnly = True
    Me.CPLNDV.Visible = False
    '
    'HeaderDatos
    '
    Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderDatos.HeaderVisibleSecondary = False
    Me.HeaderDatos.Location = New System.Drawing.Point(0, 515)
    Me.HeaderDatos.Name = "HeaderDatos"
    '
    'HeaderDatos.Panel
    '
    Me.HeaderDatos.Panel.Controls.Add(Me.Panel1)
    Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
    Me.HeaderDatos.Size = New System.Drawing.Size(957, 205)
    Me.HeaderDatos.TabIndex = 3
    Me.HeaderDatos.Text = "Información del Obrero"
    Me.HeaderDatos.ValuesPrimary.Description = ""
    Me.HeaderDatos.ValuesPrimary.Heading = "Información del Obrero"
    Me.HeaderDatos.ValuesPrimary.Image = Nothing
    Me.HeaderDatos.ValuesSecondary.Description = ""
    Me.HeaderDatos.ValuesSecondary.Heading = "Description"
    Me.HeaderDatos.ValuesSecondary.Image = Nothing
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.White
    Me.Panel1.Controls.Add(Me.ctbCodigo)
    Me.Panel1.Controls.Add(Me.cmbCategoria)
    Me.Panel1.Controls.Add(Me.txtCuentaSAP)
    Me.Panel1.Controls.Add(Me.dtpFechaVencimiento)
    Me.Panel1.Controls.Add(Me.dtpFechaIngreso)
    Me.Panel1.Controls.Add(Me.KryptonBorderEdge2)
    Me.Panel1.Controls.Add(Me.KryptonLabel1)
    Me.Panel1.Controls.Add(Me.KryptonBorderEdge1)
    Me.Panel1.Controls.Add(Me.txtNombre)
    Me.Panel1.Controls.Add(Me.KryptonLabel16)
    Me.Panel1.Controls.Add(Me.KryptonLabel5)
    Me.Panel1.Controls.Add(Me.KryptonLabel6)
    Me.Panel1.Controls.Add(Me.KryptonLabel12)
    Me.Panel1.Controls.Add(Me.KryptonLabel8)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 25)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(955, 158)
    Me.Panel1.TabIndex = 61
    '
    'ctbCodigo
    '
    Me.ctbCodigo.Codigo = ""
    Me.ctbCodigo.ControlHeight = 23
    Me.ctbCodigo.ControlImage = True
    Me.ctbCodigo.ControlReadOnly = False
    Me.ctbCodigo.Descripcion = ""
    Me.ctbCodigo.DisplayColumnVisible = True
    Me.ctbCodigo.DisplayMember = ""
    Me.ctbCodigo.Enabled = False
    Me.ctbCodigo.KeyColumnWidth = 100
    Me.ctbCodigo.KeyField = ""
    Me.ctbCodigo.KeySearch = True
    Me.ctbCodigo.Location = New System.Drawing.Point(60, 27)
    Me.ctbCodigo.Name = "ctbCodigo"
    Me.ctbCodigo.Size = New System.Drawing.Size(226, 23)
    Me.ctbCodigo.TabIndex = 0
    Me.ctbCodigo.Tag = ""
    Me.ctbCodigo.TextBackColor = System.Drawing.Color.Empty
    Me.ctbCodigo.TextForeColor = System.Drawing.Color.Empty
    Me.ctbCodigo.ValueColumnVisible = True
    Me.ctbCodigo.ValueColumnWidth = 600
    Me.ctbCodigo.ValueField = ""
    Me.ctbCodigo.ValueMember = ""
    Me.ctbCodigo.ValueSearch = True
    '
    'cmbCategoria
    '
    Me.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbCategoria.DropDownWidth = 156
    Me.cmbCategoria.Enabled = False
    Me.cmbCategoria.FormattingEnabled = False
    Me.cmbCategoria.ItemHeight = 13
    Me.cmbCategoria.Location = New System.Drawing.Point(425, 54)
    Me.cmbCategoria.Name = "cmbCategoria"
    Me.cmbCategoria.Size = New System.Drawing.Size(161, 21)
    Me.cmbCategoria.TabIndex = 3
    '
    'txtCuentaSAP
    '
    Me.txtCuentaSAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCuentaSAP.Enabled = False
    Me.txtCuentaSAP.Location = New System.Drawing.Point(425, 27)
    Me.txtCuentaSAP.MaxLength = 17
    Me.txtCuentaSAP.Name = "txtCuentaSAP"
    Me.txtCuentaSAP.Size = New System.Drawing.Size(161, 21)
    Me.txtCuentaSAP.TabIndex = 2
    '
    'dtpFechaVencimiento
    '
    Me.dtpFechaVencimiento.Enabled = False
    Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaVencimiento.Location = New System.Drawing.Point(757, 55)
    Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
    Me.dtpFechaVencimiento.Size = New System.Drawing.Size(92, 20)
    Me.dtpFechaVencimiento.TabIndex = 5
    '
    'dtpFechaIngreso
    '
    Me.dtpFechaIngreso.Enabled = False
    Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaIngreso.Location = New System.Drawing.Point(757, 27)
    Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
    Me.dtpFechaIngreso.Size = New System.Drawing.Size(92, 20)
    Me.dtpFechaIngreso.TabIndex = 4
    '
    'KryptonBorderEdge2
    '
    Me.KryptonBorderEdge2.Location = New System.Drawing.Point(602, 11)
    Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
    Me.KryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.KryptonBorderEdge2.Size = New System.Drawing.Size(1, 80)
    Me.KryptonBorderEdge2.TabIndex = 46
    Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(6, 32)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(49, 19)
    Me.KryptonLabel1.TabIndex = 1
    Me.KryptonLabel1.Text = "Código:"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Código:"
    '
    'KryptonBorderEdge1
    '
    Me.KryptonBorderEdge1.Location = New System.Drawing.Point(292, 11)
    Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
    Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 80)
    Me.KryptonBorderEdge1.TabIndex = 33
    Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
    '
    'txtNombre
    '
    Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtNombre.Enabled = False
    Me.txtNombre.Location = New System.Drawing.Point(60, 56)
    Me.txtNombre.MaxLength = 45
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(226, 21)
    Me.txtNombre.TabIndex = 1
    '
    'KryptonLabel16
    '
    Me.KryptonLabel16.Location = New System.Drawing.Point(296, 27)
    Me.KryptonLabel16.Name = "KryptonLabel16"
    Me.KryptonLabel16.Size = New System.Drawing.Size(130, 19)
    Me.KryptonLabel16.TabIndex = 25
    Me.KryptonLabel16.Text = "Cuenta Matchcode SAP:"
    Me.KryptonLabel16.Values.ExtraText = ""
    Me.KryptonLabel16.Values.Image = Nothing
    Me.KryptonLabel16.Values.Text = "Cuenta Matchcode SAP:"
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(296, 56)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(116, 19)
    Me.KryptonLabel5.TabIndex = 9
    Me.KryptonLabel5.Text = "Categoria del Chofer:"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Categoria del Chofer:"
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(605, 30)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(98, 19)
    Me.KryptonLabel6.TabIndex = 11
    Me.KryptonLabel6.Text = "Fecha de Ingreso:"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Fecha de Ingreso:"
    '
    'KryptonLabel12
    '
    Me.KryptonLabel12.Location = New System.Drawing.Point(605, 57)
    Me.KryptonLabel12.Name = "KryptonLabel12"
    Me.KryptonLabel12.Size = New System.Drawing.Size(154, 19)
    Me.KryptonLabel12.TabIndex = 17
    Me.KryptonLabel12.Text = "Fecha Vencimiento Contrato:"
    Me.KryptonLabel12.Values.ExtraText = ""
    Me.KryptonLabel12.Values.Image = Nothing
    Me.KryptonLabel12.Values.Text = "Fecha Vencimiento Contrato:"
    '
    'KryptonLabel8
    '
    Me.KryptonLabel8.Location = New System.Drawing.Point(6, 58)
    Me.KryptonLabel8.Name = "KryptonLabel8"
    Me.KryptonLabel8.Size = New System.Drawing.Size(54, 19)
    Me.KryptonLabel8.TabIndex = 15
    Me.KryptonLabel8.Text = "Nombre:"
    Me.KryptonLabel8.Values.ExtraText = ""
    Me.KryptonLabel8.Values.Image = Nothing
    Me.KryptonLabel8.Values.Text = "Nombre:"
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar, Me.ToolStripSeparator4})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(955, 25)
    Me.MenuBar.TabIndex = 0
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnNuevo
    '
    Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
    Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(60, 22)
    Me.btnNuevo.Text = "&Nuevo"
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
    Me.btnGuardar.Text = "&Guardar"
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
    Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
    Me.btnCancelar.Text = "&Cancelar"
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
    Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
    Me.btnEliminar.Text = "&Eliminar"
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
    '
    'PanelFiltros
    '
    Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnImprimir, Me.btnBuscar})
    Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
    Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.PanelFiltros.HeaderVisiblePrimary = False
    Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
    Me.PanelFiltros.Name = "PanelFiltros"
    '
    'PanelFiltros.Panel
    '
    Me.PanelFiltros.Panel.Controls.Add(Me.cboPlanta)
    Me.PanelFiltros.Panel.Controls.Add(Me.cboDivision)
    Me.PanelFiltros.Panel.Controls.Add(Me.cboCompania)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel4)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtNombreBusqueda)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
    Me.PanelFiltros.Size = New System.Drawing.Size(957, 100)
    Me.PanelFiltros.TabIndex = 1
    Me.PanelFiltros.ValuesPrimary.Description = ""
    Me.PanelFiltros.ValuesPrimary.Heading = ""
    Me.PanelFiltros.ValuesPrimary.Image = Nothing
    Me.PanelFiltros.ValuesSecondary.Description = ""
    Me.PanelFiltros.ValuesSecondary.Heading = "Lista de Obreros"
    Me.PanelFiltros.ValuesSecondary.Image = Nothing
    '
    'btnImprimir
    '
    Me.btnImprimir.ExtraText = ""
    Me.btnImprimir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnImprimir.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
    Me.btnImprimir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnImprimir.Text = "Imprimir"
    Me.btnImprimir.ToolTipBody = "Imprimir"
    Me.btnImprimir.ToolTipImage = Nothing
    Me.btnImprimir.UniqueName = "DF44F8FC66B148BCDF44F8FC66B148BC"
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
    'cboPlanta
    '
    Me.cboPlanta.BackColor = System.Drawing.Color.Transparent
    Me.cboPlanta.CodigoCompania = ""
    Me.cboPlanta.CodigoDivision = ""
    Me.cboPlanta.CPLNDV_ANTERIOR = Nothing
    Me.cboPlanta.DescripcionPlanta = ""
    Me.cboPlanta.ItemTodos = False
    Me.cboPlanta.Location = New System.Drawing.Point(662, 9)
    Me.cboPlanta.MinimumSize = New System.Drawing.Size(150, 21)
    Me.cboPlanta.Name = "cboPlanta"
    Me.cboPlanta.Planta = 0
    Me.cboPlanta.PlantaDefault = -1
    Me.cboPlanta.pRequerido = False
    Me.cboPlanta.Size = New System.Drawing.Size(213, 23)
    Me.cboPlanta.TabIndex = 60
    Me.cboPlanta.Usuario = ""
    '
    'cboDivision
    '
    Me.cboDivision.BackColor = System.Drawing.Color.Transparent
    Me.cboDivision.CDVSN_ANTERIOR = Nothing
    Me.cboDivision.Compania = ""
    Me.cboDivision.Division = Nothing
    Me.cboDivision.DivisionDefault = Nothing
    Me.cboDivision.DivisionDescripcion = Nothing
    Me.cboDivision.ItemTodos = False
    Me.cboDivision.Location = New System.Drawing.Point(376, 7)
    Me.cboDivision.MinimumSize = New System.Drawing.Size(150, 21)
    Me.cboDivision.Name = "cboDivision"
    Me.cboDivision.Size = New System.Drawing.Size(232, 23)
    Me.cboDivision.TabIndex = 59
    Me.cboDivision.Usuario = ""
    '
    'cboCompania
    '
    Me.cboCompania.BackColor = System.Drawing.SystemColors.Window
    Me.cboCompania.CCMPN_ANTERIOR = Nothing
    Me.cboCompania.CCMPN_CodigoCompania = Nothing
    Me.cboCompania.CCMPN_CompaniaDefault = Nothing
    Me.cboCompania.CCMPN_Descripcion = Nothing
    Me.cboCompania.Location = New System.Drawing.Point(70, 6)
    Me.cboCompania.MinimumSize = New System.Drawing.Size(150, 23)
    Me.cboCompania.Name = "cboCompania"
    Me.cboCompania.Size = New System.Drawing.Size(250, 23)
    Me.cboCompania.TabIndex = 58
    Me.cboCompania.Usuario = ""
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(614, 9)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(41, 19)
    Me.KryptonLabel2.TabIndex = 54
    Me.KryptonLabel2.Text = "Planta"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Planta"
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(330, 9)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(50, 19)
    Me.KryptonLabel4.TabIndex = 55
    Me.KryptonLabel4.Text = "División"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "División"
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(2, 9)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(61, 19)
    Me.KryptonLabel7.TabIndex = 53
    Me.KryptonLabel7.Text = "Compañía"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Compañía"
    '
    'txtNombreBusqueda
    '
    Me.txtNombreBusqueda.AcceptsReturn = True
    Me.txtNombreBusqueda.Location = New System.Drawing.Point(72, 35)
    Me.txtNombreBusqueda.MaxLength = 45
    Me.txtNombreBusqueda.Name = "txtNombreBusqueda"
    Me.txtNombreBusqueda.Size = New System.Drawing.Size(248, 21)
    Me.txtNombreBusqueda.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtNombreBusqueda.TabIndex = 51
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(2, 36)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(51, 19)
    Me.KryptonLabel3.TabIndex = 50
    Me.KryptonLabel3.Text = "Obrero :"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Obrero :"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "COBRR"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "TNMBOB"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "SCATEG"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Categoria Chofer"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "SACTIN"
    Me.DataGridViewTextBoxColumn4.HeaderText = "SACTIN"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    Me.DataGridViewTextBoxColumn4.Visible = False
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "FINGCH"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha de Ingreso "
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    Me.DataGridViewTextBoxColumn5.Visible = False
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "FVNCCR"
    Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha Vencimiento Contrato"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "CMTCDS"
    Me.DataGridViewTextBoxColumn7.HeaderText = "Matchcode SAP"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn8.DataPropertyName = "CMTCDS"
    Me.DataGridViewTextBoxColumn8.HeaderText = "Matchcode SAP"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.ReadOnly = True
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.DataPropertyName = "CCMPN"
    Me.DataGridViewTextBoxColumn9.HeaderText = "Compañia"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.Visible = False
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.DataPropertyName = "CDVSN"
    Me.DataGridViewTextBoxColumn10.HeaderText = "División"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    Me.DataGridViewTextBoxColumn10.Visible = False
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.DataPropertyName = "CPLNDV"
    Me.DataGridViewTextBoxColumn11.HeaderText = "Planta"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    Me.DataGridViewTextBoxColumn11.Visible = False
    '
    'frmObrero
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(957, 720)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmObrero"
    Me.Text = "Obrero"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.dtgObrero, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderDatos.Panel.ResumeLayout(False)
    Me.HeaderDatos.Panel.PerformLayout()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderDatos.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.Panel.ResumeLayout(False)
    Me.PanelFiltros.Panel.PerformLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.ResumeLayout(False)
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
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgObrero As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents txtNombre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombreBusqueda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCuentaSAP As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cmbCategoria As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents ctbCodigo As CodeTextBox.CodeTextBox
  Friend WithEvents btnImprimir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents COBRR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TNMBOB As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TCATEG As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SCATEG As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SACTIN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FINGCH As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FVNCCR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CMTCDS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents cboDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents cboCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
End Class
