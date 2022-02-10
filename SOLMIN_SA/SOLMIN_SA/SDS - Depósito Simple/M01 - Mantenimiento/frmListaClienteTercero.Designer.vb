<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaClienteTercero
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
        'Dim BeProveedor1 As Ransa.TypeDef.Proveedor.beProveedor = New Ransa.TypeDef.Proveedor.beProveedor
        Dim BeProveedor1 As Ransa.Controls.Proveedor.beProveedor = New Ransa.Controls.Proveedor.beProveedor
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaClienteTercero))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.UcProveedor_DgCab1 = New Ransa.Controls.Proveedor.ucProveedor_DgCab
        Me.dgPlantaCliente = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminar_PLanta = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar_Planta = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar_Planta = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.ucpPlanta = New Ransa.Utilitario.UCPaginacion
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipo = New Ransa.Utilitario.ucAyuda
        Me.txtProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRuc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.btnEtiquetas = New System.Windows.Forms.ToolStripSplitButton
        Me.btnImprimirPosiciones = New System.Windows.Forms.ToolStripMenuItem
        Me.btnImprimirPasilloFila = New System.Windows.Forms.ToolStripMenuItem
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDRPCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUBGE2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UBIGEO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSMAILDS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgPlantaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(998, 663)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 103)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.UcProveedor_DgCab1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgPlantaCliente)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ucpPlanta)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(998, 560)
        Me.KryptonSplitContainer1.SplitterDistance = 285
        Me.KryptonSplitContainer1.TabIndex = 68
        '
        'UcProveedor_DgCab1
        '
        Me.UcProveedor_DgCab1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.UcProveedor_DgCab1.infoProveedor = BeProveedor1
        Me.UcProveedor_DgCab1.Location = New System.Drawing.Point(0, 0)
        Me.UcProveedor_DgCab1.Name = "UcProveedor_DgCab1"
        Me.UcProveedor_DgCab1.pMostrarBotonBuscar = False
        Me.UcProveedor_DgCab1.pMostrarTituloOpcion1 = False
        Me.UcProveedor_DgCab1.Size = New System.Drawing.Size(998, 285)
        Me.UcProveedor_DgCab1.TabIndex = 63
        '
        'dgPlantaCliente
        '
        Me.dgPlantaCliente.AllowUserToAddRows = False
        Me.dgPlantaCliente.AllowUserToDeleteRows = False
        Me.dgPlantaCliente.AllowUserToResizeColumns = False
        Me.dgPlantaCliente.AllowUserToResizeRows = False
        Me.dgPlantaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPlantaCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.TDRPCP, Me.CUBGE2, Me.UBIGEO, Me.DataGridViewTextBoxColumn13, Me.PSMAILDS})
        Me.dgPlantaCliente.DataMember = "dtRZSC30"
        Me.dgPlantaCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPlantaCliente.Location = New System.Drawing.Point(0, 25)
        Me.dgPlantaCliente.MultiSelect = False
        Me.dgPlantaCliente.Name = "dgPlantaCliente"
        Me.dgPlantaCliente.ReadOnly = True
        Me.dgPlantaCliente.RowHeadersWidth = 20
        Me.dgPlantaCliente.RowTemplate.ReadOnly = True
        Me.dgPlantaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgPlantaCliente.Size = New System.Drawing.Size(998, 220)
        Me.dgPlantaCliente.StandardTab = True
        Me.dgPlantaCliente.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgPlantaCliente.TabIndex = 68
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.btnEliminar_PLanta, Me.ToolStripSeparator8, Me.btnModificar_Planta, Me.ToolStripSeparator9, Me.btnAgregar_Planta, Me.ToolStripSeparator10})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(998, 25)
        Me.ToolStrip2.TabIndex = 67
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel3.Tag = "PLANTAS"
        Me.ToolStripLabel3.Text = "PLANTAS"
        '
        'btnEliminar_PLanta
        '
        Me.btnEliminar_PLanta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar_PLanta.Image = CType(resources.GetObject("btnEliminar_PLanta.Image"), System.Drawing.Image)
        Me.btnEliminar_PLanta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar_PLanta.Name = "btnEliminar_PLanta"
        Me.btnEliminar_PLanta.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar_PLanta.Text = "&Eliminar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar_Planta
        '
        Me.btnModificar_Planta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar_Planta.Image = CType(resources.GetObject("btnModificar_Planta.Image"), System.Drawing.Image)
        Me.btnModificar_Planta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar_Planta.Name = "btnModificar_Planta"
        Me.btnModificar_Planta.Size = New System.Drawing.Size(76, 22)
        Me.btnModificar_Planta.Text = "&Modificar"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar_Planta
        '
        Me.btnAgregar_Planta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar_Planta.Image = CType(resources.GetObject("btnAgregar_Planta.Image"), System.Drawing.Image)
        Me.btnAgregar_Planta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar_Planta.Name = "btnAgregar_Planta"
        Me.btnAgregar_Planta.Size = New System.Drawing.Size(68, 22)
        Me.btnAgregar_Planta.Text = "&Agregar"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ucpPlanta
        '
        Me.ucpPlanta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucpPlanta.Location = New System.Drawing.Point(0, 245)
        Me.ucpPlanta.Name = "ucpPlanta"
        Me.ucpPlanta.PageCount = 0
        Me.ucpPlanta.PageNumber = 1
        Me.ucpPlanta.PageSize = 20
        Me.ucpPlanta.Size = New System.Drawing.Size(998, 25)
        Me.ucpPlanta.TabIndex = 65
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.txtTipo)
        Me.khgFiltros.Panel.Controls.Add(Me.txtProveedor)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.txtRuc)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(998, 103)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 3
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaOcultarFiltros
        '
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.ToolTipImage = Nothing
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 38)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(38, 19)
        Me.KryptonLabel3.TabIndex = 83
        Me.KryptonLabel3.Text = "Tipo :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo :"
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.Color.White
        Me.txtTipo.DataSource = Nothing
        Me.txtTipo.DispleyMember = ""
        Me.txtTipo.Etiquetas_Form = Nothing
        Me.txtTipo.ListColumnas = Nothing
        Me.txtTipo.Location = New System.Drawing.Point(67, 36)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Obligatorio = True
        Me.txtTipo.PopupHeight = 0
        Me.txtTipo.PopupWidth = 0
        Me.txtTipo.Size = New System.Drawing.Size(278, 21)
        Me.txtTipo.TabIndex = 82
        Me.txtTipo.ValueMember = ""
        '
        'txtProveedor
        '
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.Location = New System.Drawing.Point(424, 11)
        Me.txtProveedor.MaxLength = 30
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(174, 21)
        Me.txtProveedor.TabIndex = 77
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(351, 11)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel2.TabIndex = 76
        Me.KryptonLabel2.Text = "Proveedor : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Proveedor : "
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(647, 11)
        Me.txtRuc.MaxLength = 12
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(155, 21)
        Me.txtRuc.TabIndex = 75
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(604, 13)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(37, 19)
        Me.KryptonLabel1.TabIndex = 74
        Me.KryptonLabel1.Text = "RUC : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "RUC : "
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(901, 3)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(84, 68)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 73
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(67, 11)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(278, 21)
        Me.txtCliente.TabIndex = 64
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(11, 13)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Cliente : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente : "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripLabel1.Tag = "POSICION"
        Me.ToolStripLabel1.Text = "POSICION MERCADERIA LISTADO"
        '
        'btnEtiquetas
        '
        Me.btnEtiquetas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEtiquetas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimirPosiciones, Me.btnImprimirPasilloFila})
        Me.btnEtiquetas.Image = Global.SOLMIN_SA.My.Resources.Resources.mime_resource
        Me.btnEtiquetas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEtiquetas.Name = "btnEtiquetas"
        Me.btnEtiquetas.Size = New System.Drawing.Size(83, 22)
        Me.btnEtiquetas.Text = "Etiquetas"
        '
        'btnImprimirPosiciones
        '
        Me.btnImprimirPosiciones.Name = "btnImprimirPosiciones"
        Me.btnImprimirPosiciones.Size = New System.Drawing.Size(186, 22)
        Me.btnImprimirPosiciones.Text = "Etiquetas de Posiciones"
        '
        'btnImprimirPasilloFila
        '
        Me.btnImprimirPasilloFila.Name = "btnImprimirPasilloFila"
        Me.btnImprimirPasilloFila.Size = New System.Drawing.Size(186, 22)
        Me.btnImprimirPasilloFila.Text = "Etiquetas  Pasillo/Fila"
        Me.btnImprimirPasilloFila.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsbImprimir
        '
        Me.tsbImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(62, 22)
        Me.tsbImprimir.Text = "&Imprimir"
        Me.tsbImprimir.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(63, 22)
        Me.tsbEliminar.Text = "&Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbModificar
        '
        Me.tsbModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbModificar.Image = CType(resources.GetObject("tsbModificar.Image"), System.Drawing.Image)
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(70, 22)
        Me.tsbModificar.Text = "&Modificar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAgregar.Image = CType(resources.GetObject("tsbAgregar.Image"), System.Drawing.Image)
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(64, 22)
        Me.tsbAgregar.Text = "&Agregar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PSTCMPCP"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre de la Planta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSDirCompleta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSTDRPCP"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TDRPCP"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PSTDRDST"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dirección Destinatario"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PSMAILDS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Mail Destinatario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 124
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
        'CUBGE2
        '
        Me.CUBGE2.DataPropertyName = "PNCUBGE2"
        Me.CUBGE2.HeaderText = "CUBGE2"
        Me.CUBGE2.Name = "CUBGE2"
        Me.CUBGE2.ReadOnly = True
        Me.CUBGE2.Visible = False
        Me.CUBGE2.Width = 78
        '
        'UBIGEO
        '
        Me.UBIGEO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UBIGEO.DataPropertyName = "PSUBIGEO"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.UBIGEO.DefaultCellStyle = DataGridViewCellStyle1
        Me.UBIGEO.HeaderText = "Ubigeo"
        Me.UBIGEO.Name = "UBIGEO"
        Me.UBIGEO.ReadOnly = True
        Me.UBIGEO.Width = 74
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
        Me.PSMAILDS.Width = 124
        '
        'frmListaClienteTercero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 663)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListaClienteTercero"
        Me.Text = "Terceros por Cliente"
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
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEtiquetas As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btnImprimirPosiciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnImprimirPasilloFila As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtRuc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ucpPlanta As Ransa.Utilitario.UCPaginacion
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar_PLanta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModificar_Planta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar_Planta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents dgPlantaCliente As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UcProveedor_DgCab1 As Ransa.Controls.Proveedor.ucProveedor_DgCab
    Friend WithEvents txtTipo As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDRPCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUBGE2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBIGEO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSMAILDS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
