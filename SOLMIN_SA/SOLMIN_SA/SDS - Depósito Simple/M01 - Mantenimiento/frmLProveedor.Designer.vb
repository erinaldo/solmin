<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLProveedor
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
        Me.components = New System.ComponentModel.Container()
        Dim BeProveedor1 As Ransa.Controls.Proveedor.beProveedor = New Ransa.Controls.Proveedor.beProveedor()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLProveedor))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.UcProveedor_DgGeneral = New Ransa.Controls.Proveedor.ucProveedor_DgGeneral()
        Me.dgPlantaCliente = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDRPCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSMAILDS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbEliminarPlanta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbModificarPlanta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAgregarPlanta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ucpPlanta = New Ransa.Utilitario.UCPaginacion()
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtRUC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lblServicio = New System.Windows.Forms.ToolStripLabel()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbxPlanta = New System.Windows.Forms.ToolStripComboBox()
        Me.lblPlanta = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgPlantaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.ucpPlanta)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1207, 738)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 117)
        Me.KryptonSplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.UcProveedor_DgGeneral)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgPlantaCliente)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1207, 590)
        Me.KryptonSplitContainer1.SplitterDistance = 310
        Me.KryptonSplitContainer1.TabIndex = 29
        '
        'UcProveedor_DgGeneral
        '
        Me.UcProveedor_DgGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        BeProveedor1.CREACION = ""
        BeProveedor1.PageCount = 0
        BeProveedor1.PageNumber = 0
        BeProveedor1.PageSize = 0
        BeProveedor1.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BeProveedor1.PNCPAIS = New Decimal(New Integer() {0, 0, 0, 0})
        BeProveedor1.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BeProveedor1.PNFCHCRT = New Decimal(New Integer() {0, 0, 0, 0})
        BeProveedor1.PNFULTAC = New Decimal(New Integer() {0, 0, 0, 0})
        BeProveedor1.PNHRACRT = New Decimal(New Integer() {0, 0, 0, 0})
        BeProveedor1.PNHULTAC = New Decimal(New Integer() {0, 0, 0, 0})
        BeProveedor1.PNNDSDMP = New Decimal(New Integer() {0, 0, 0, 0})
        BeProveedor1.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BeProveedor1.PNUPDATE_IDENT = New Decimal(New Integer() {0, 0, 0, 0})
        BeProveedor1.PSBUSQUEDA = ""
        BeProveedor1.PSCPRPCL = ""
        BeProveedor1.PSCPRVCLSTR = ""
        BeProveedor1.PSCULUSA = ""
        BeProveedor1.PSCUSCRT = ""
        BeProveedor1.PSDIRCOMPLETO = ""
        BeProveedor1.PSNOMCOMPLETO = ""
        BeProveedor1.PSNRUCPRSTR = ""
        BeProveedor1.PSSESTRG = ""
        BeProveedor1.PSSTPORL = ""
        BeProveedor1.PSTDRPRC = ""
        BeProveedor1.PSTEMAI2 = ""
        BeProveedor1.PSTEMAI3 = ""
        BeProveedor1.PSTLFNO1 = ""
        BeProveedor1.PSTLFNO2 = ""
        BeProveedor1.PSTNACPR = ""
        BeProveedor1.PSTNROFX = ""
        BeProveedor1.PSTPRCL1 = ""
        BeProveedor1.PSTPRSCN = ""
        BeProveedor1.PSTPRVCL = ""
        BeProveedor1.RELACION = ""
        Me.UcProveedor_DgGeneral.infoProveedor = BeProveedor1
        Me.UcProveedor_DgGeneral.Location = New System.Drawing.Point(0, 0)
        Me.UcProveedor_DgGeneral.Margin = New System.Windows.Forms.Padding(5)
        Me.UcProveedor_DgGeneral.Name = "UcProveedor_DgGeneral"
        Me.UcProveedor_DgGeneral.Size = New System.Drawing.Size(1207, 310)
        Me.UcProveedor_DgGeneral.TabIndex = 30
        '
        'dgPlantaCliente
        '
        Me.dgPlantaCliente.AllowUserToAddRows = False
        Me.dgPlantaCliente.AllowUserToDeleteRows = False
        Me.dgPlantaCliente.AllowUserToResizeColumns = False
        Me.dgPlantaCliente.AllowUserToResizeRows = False
        Me.dgPlantaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPlantaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPlantaCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.TDRPCP, Me.DataGridViewTextBoxColumn13, Me.PSMAILDS})
        Me.dgPlantaCliente.DataMember = "dtRZSC30"
        Me.dgPlantaCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPlantaCliente.Location = New System.Drawing.Point(0, 27)
        Me.dgPlantaCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.dgPlantaCliente.MultiSelect = False
        Me.dgPlantaCliente.Name = "dgPlantaCliente"
        Me.dgPlantaCliente.ReadOnly = True
        Me.dgPlantaCliente.RowHeadersWidth = 20
        Me.dgPlantaCliente.RowTemplate.ReadOnly = True
        Me.dgPlantaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgPlantaCliente.Size = New System.Drawing.Size(1207, 248)
        Me.dgPlantaCliente.StandardTab = True
        Me.dgPlantaCliente.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgPlantaCliente.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgPlantaCliente.TabIndex = 29
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PSTCMPCP"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nombre de la Planta"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PSDirCompleta"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'TDRPCP
        '
        Me.TDRPCP.DataPropertyName = "PSTDRPCP"
        Me.TDRPCP.HeaderText = "TDRPCP"
        Me.TDRPCP.Name = "TDRPCP"
        Me.TDRPCP.ReadOnly = True
        Me.TDRPCP.Visible = False
        Me.TDRPCP.Width = 75
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PSTDRDST"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Dirección Destinatario"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'PSMAILDS
        '
        Me.PSMAILDS.DataPropertyName = "PSMAILDS"
        Me.PSMAILDS.HeaderText = "Mail Destinatario"
        Me.PSMAILDS.Name = "PSMAILDS"
        Me.PSMAILDS.ReadOnly = True
        Me.PSMAILDS.Width = 156
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tsbEliminarPlanta, Me.ToolStripSeparator1, Me.tsbModificarPlanta, Me.ToolStripSeparator5, Me.tsbAgregarPlanta, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1207, 27)
        Me.ToolStrip1.TabIndex = 26
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(78, 24)
        Me.ToolStripLabel2.Tag = "PLANTAS"
        Me.ToolStripLabel2.Text = "PLANTAS"
        '
        'tsbEliminarPlanta
        '
        Me.tsbEliminarPlanta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminarPlanta.Image = CType(resources.GetObject("tsbEliminarPlanta.Image"), System.Drawing.Image)
        Me.tsbEliminarPlanta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminarPlanta.Name = "tsbEliminarPlanta"
        Me.tsbEliminarPlanta.Size = New System.Drawing.Size(87, 24)
        Me.tsbEliminarPlanta.Text = "&Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tsbModificarPlanta
        '
        Me.tsbModificarPlanta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbModificarPlanta.Image = CType(resources.GetObject("tsbModificarPlanta.Image"), System.Drawing.Image)
        Me.tsbModificarPlanta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificarPlanta.Name = "tsbModificarPlanta"
        Me.tsbModificarPlanta.Size = New System.Drawing.Size(97, 24)
        Me.tsbModificarPlanta.Text = "&Modificar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'tsbAgregarPlanta
        '
        Me.tsbAgregarPlanta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAgregarPlanta.Image = CType(resources.GetObject("tsbAgregarPlanta.Image"), System.Drawing.Image)
        Me.tsbAgregarPlanta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarPlanta.Name = "tsbAgregarPlanta"
        Me.tsbAgregarPlanta.Size = New System.Drawing.Size(87, 24)
        Me.tsbAgregarPlanta.Text = "&Agregar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'ucpPlanta
        '
        Me.ucpPlanta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucpPlanta.Location = New System.Drawing.Point(0, 707)
        Me.ucpPlanta.Margin = New System.Windows.Forms.Padding(5)
        Me.ucpPlanta.Name = "ucpPlanta"
        Me.ucpPlanta.PageCount = 0
        Me.ucpPlanta.PageNumber = 1
        Me.ucpPlanta.PageSize = 20
        Me.ucpPlanta.Size = New System.Drawing.Size(1207, 31)
        Me.ucpPlanta.TabIndex = 28
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaStatusOcultarFiltros, Me.bsaCerrarVentana})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Margin = New System.Windows.Forms.Padding(4)
        Me.hgFiltros.MaximumSize = New System.Drawing.Size(0, 117)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.txtDescripcion)
        Me.hgFiltros.Panel.Controls.Add(Me.txtRUC)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.hgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(1207, 117)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 2
        Me.hgFiltros.Text = "Filtros"
        Me.hgFiltros.ValuesPrimary.Description = ""
        Me.hgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.hgFiltros.ValuesPrimary.Image = Nothing
        Me.hgFiltros.ValuesSecondary.Description = ""
        Me.hgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.hgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaStatusOcultarFiltros
        '
        Me.bsaStatusOcultarFiltros.ExtraText = ""
        Me.bsaStatusOcultarFiltros.Image = Nothing
        Me.bsaStatusOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaStatusOcultarFiltros.Text = "Ocultar"
        Me.bsaStatusOcultarFiltros.ToolTipImage = Nothing
        Me.bsaStatusOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaStatusOcultarFiltros.UniqueName = "035391BBFC7044C3035391BBFC7044C3"
        '
        'bsaCerrarVentana
        '
        Me.bsaCerrarVentana.ExtraText = ""
        Me.bsaCerrarVentana.Image = Nothing
        Me.bsaCerrarVentana.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrarVentana.Text = "Cerrar"
        Me.bsaCerrarVentana.ToolTipImage = Nothing
        Me.bsaCerrarVentana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrarVentana.UniqueName = "EC0877FED5AD46CBEC0877FED5AD46CB"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(380, 23)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(471, 26)
        Me.txtDescripcion.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtDescripcion.TabIndex = 41
        '
        'txtRUC
        '
        Me.txtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUC.Location = New System.Drawing.Point(80, 23)
        Me.txtRUC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRUC.MaxLength = 15
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(171, 26)
        Me.txtRUC.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtRUC.TabIndex = 40
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(277, 23)
        Me.lblTipoAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(99, 24)
        Me.lblTipoAlmacen.TabIndex = 42
        Me.lblTipoAlmacen.Text = "Descripción :"
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Descripción :"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(1100, 4)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(91, 70)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(16, 26)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(59, 24)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "R.U.C. :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "R.U.C. :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(1063, -1)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(41, 116)
        Me.KryptonLabel5.TabIndex = 39
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'lblServicio
        '
        Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(73, 22)
        Me.lblServicio.Tag = "SERVICIOS"
        Me.lblServicio.Text = "SERVICIOS"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "&Eliminar"
        '
        'tssSep_03
        '
        Me.tssSep_03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_03.Name = "tssSep_03"
        Me.tssSep_03.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(76, 22)
        Me.btnModificar.Text = "&Modificar"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(68, 22)
        Me.btnAgregar.Text = "&Agregar"
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'cbxPlanta
        '
        Me.cbxPlanta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cbxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPlanta.Name = "cbxPlanta"
        Me.cbxPlanta.Size = New System.Drawing.Size(150, 28)
        '
        'lblPlanta
        '
        Me.lblPlanta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblPlanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(55, 22)
        Me.lblPlanta.Text = "Planta : "
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PSTIPO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 58
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSALMACEN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 79
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSCPSLL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pasillo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 69
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PSCCLMN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Columna"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 82
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PSCPSCN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Posición"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 79
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PSCLIENTE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 72
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PSFAMILIA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Familia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 72
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PSGRUPO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 69
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PSMERCADERIA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mercaderia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 93
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PSNCRPRD"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Prioridad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 83
        '
        'frmLProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 738)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLProveedor"
        Me.Text = "Terceros"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgPlantaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
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
    Friend WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblServicio As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbxPlanta As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblPlanta As System.Windows.Forms.ToolStripLabel
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
    Friend WithEvents ucpPlanta As Ransa.Utilitario.UCPaginacion
    Friend WithEvents txtRUC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents dgPlantaCliente As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbEliminarPlanta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbModificarPlanta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAgregarPlanta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDRPCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSMAILDS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UcProveedor_DgGeneral As Ransa.Controls.Proveedor.ucProveedor_DgGeneral
End Class
