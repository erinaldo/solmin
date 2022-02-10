<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantPartidaArancelaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantPartidaArancelaria))
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgPartida = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CPTDAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDEPTD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRARAN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsCabecera = New System.Windows.Forms.ToolStrip
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.TabTransportista = New System.Windows.Forms.TabControl
        Me.TabDatosTransportista = New System.Windows.Forms.TabPage
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtPorcentaje = New Ransa.Utilitario.clsTextBoxNumero
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCodigoMante = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.cboPaginas = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDescripcionFiltro = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dtgPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCabecera.SuspendLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.TabTransportista.SuspendLayout()
        Me.TabDatosTransportista.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(998, 720)
        Me.KryptonPanel2.TabIndex = 4
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dtgPartida)
        Me.KryptonPanel1.Controls.Add(Me.tsCabecera)
        Me.KryptonPanel1.Controls.Add(Me.UcPaginacion)
        Me.KryptonPanel1.Controls.Add(Me.HeaderDatos)
        Me.KryptonPanel1.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(998, 720)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 1
        '
        'dtgPartida
        '
        Me.dtgPartida.AllowUserToAddRows = False
        Me.dtgPartida.AllowUserToDeleteRows = False
        Me.dtgPartida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgPartida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgPartida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CPTDAR, Me.TDEPTD, Me.PRARAN})
        Me.dtgPartida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgPartida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgPartida.Location = New System.Drawing.Point(0, 83)
        Me.dtgPartida.MultiSelect = False
        Me.dtgPartida.Name = "dtgPartida"
        Me.dtgPartida.ReadOnly = True
        Me.dtgPartida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgPartida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPartida.Size = New System.Drawing.Size(998, 363)
        Me.dtgPartida.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgPartida.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgPartida.TabIndex = 72
        '
        'CPTDAR
        '
        Me.CPTDAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPTDAR.DataPropertyName = "CPTDAR"
        Me.CPTDAR.HeaderText = "Código"
        Me.CPTDAR.MinimumWidth = 100
        Me.CPTDAR.Name = "CPTDAR"
        Me.CPTDAR.ReadOnly = True
        '
        'TDEPTD
        '
        Me.TDEPTD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDEPTD.DataPropertyName = "TDEPTD"
        Me.TDEPTD.FillWeight = 300.0!
        Me.TDEPTD.HeaderText = "Descripción de la Partida"
        Me.TDEPTD.MaxInputLength = 50
        Me.TDEPTD.MinimumWidth = 800
        Me.TDEPTD.Name = "TDEPTD"
        Me.TDEPTD.ReadOnly = True
        Me.TDEPTD.Width = 800
        '
        'PRARAN
        '
        Me.PRARAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PRARAN.DataPropertyName = "PRARAN"
        Me.PRARAN.FillWeight = 50.0!
        Me.PRARAN.HeaderText = "Porcentaje de Arancel"
        Me.PRARAN.MinimumWidth = 150
        Me.PRARAN.Name = "PRARAN"
        Me.PRARAN.ReadOnly = True
        '
        'tsCabecera
        '
        Me.tsCabecera.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar})
        Me.tsCabecera.Location = New System.Drawing.Point(0, 58)
        Me.tsCabecera.Name = "tsCabecera"
        Me.tsCabecera.Size = New System.Drawing.Size(998, 25)
        Me.tsCabecera.TabIndex = 71
        Me.tsCabecera.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.SOLMIN_SC.My.Resources.Resources.excelicon
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(70, 22)
        Me.btnExportar.Text = "Exportar"
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 446)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 15
        Me.UcPaginacion.Size = New System.Drawing.Size(998, 25)
        Me.UcPaginacion.TabIndex = 68
        '
        'HeaderDatos
        '
        Me.HeaderDatos.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 471)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.TabTransportista)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(998, 249)
        Me.HeaderDatos.TabIndex = 3
        Me.HeaderDatos.Text = "Información General de la Partida Arancelaria"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información General de la Partida Arancelaria"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.UniqueName = "891F91AE0D1B4285891F91AE0D1B4285"
        '
        'TabTransportista
        '
        Me.TabTransportista.Controls.Add(Me.TabDatosTransportista)
        Me.TabTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabTransportista.ImageList = Me.ImageList1
        Me.TabTransportista.Location = New System.Drawing.Point(0, 25)
        Me.TabTransportista.Name = "TabTransportista"
        Me.TabTransportista.SelectedIndex = 0
        Me.TabTransportista.Size = New System.Drawing.Size(996, 202)
        Me.TabTransportista.TabIndex = 2
        '
        'TabDatosTransportista
        '
        Me.TabDatosTransportista.Controls.Add(Me.KryptonHeaderGroup1)
        Me.TabDatosTransportista.ImageIndex = 3
        Me.TabDatosTransportista.Location = New System.Drawing.Point(4, 23)
        Me.TabDatosTransportista.Name = "TabDatosTransportista"
        Me.TabDatosTransportista.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDatosTransportista.Size = New System.Drawing.Size(988, 175)
        Me.TabDatosTransportista.TabIndex = 0
        Me.TabDatosTransportista.Text = "Datos Partida Arancelaria"
        Me.TabDatosTransportista.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtPorcentaje)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDescripcion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCodigoMante)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(982, 169)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(121, 114)
        Me.txtPorcentaje.MaxLength = 16
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.NUMDECIMALES = 2
        Me.txtPorcentaje.NUMENTEROS = 3
        Me.txtPorcentaje.Size = New System.Drawing.Size(125, 20)
        Me.txtPorcentaje.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(121, 56)
        Me.txtDescripcion.MaxLength = 200
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(319, 41)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigoMante
        '
        Me.txtCodigoMante.Location = New System.Drawing.Point(121, 12)
        Me.txtCodigoMante.MaxLength = 20
        Me.txtCodigoMante.Name = "txtCodigoMante"
        Me.txtCodigoMante.Size = New System.Drawing.Size(147, 21)
        Me.txtCodigoMante.TabIndex = 0
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(12, 115)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(103, 19)
        Me.KryptonLabel9.TabIndex = 8
        Me.KryptonLabel9.Text = "Porcentaje Arancel"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Porcentaje Arancel"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 65)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(68, 19)
        Me.KryptonLabel4.TabIndex = 2
        Me.KryptonLabel4.Text = "Descripción"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Descripción"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(85, 19)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Código Partida"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Código Partida"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add_user.png")
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar, Me.cboPaginas, Me.ToolStripLabel1})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(996, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_SC.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(60, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN_SC.My.Resources.Resources.agt_action_success
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_SC.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SOLMIN_SC.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'cboPaginas
        '
        Me.cboPaginas.Name = "cboPaginas"
        Me.cboPaginas.Size = New System.Drawing.Size(121, 25)
        Me.cboPaginas.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel1.Text = "Paginas"
        Me.ToolStripLabel1.Visible = False
        '
        'PanelFiltros
        '
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtCodBusqueda)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtDescripcionFiltro)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Size = New System.Drawing.Size(998, 58)
        Me.PanelFiltros.TabIndex = 1
        Me.PanelFiltros.Text = "Filtro de Consulta"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "Filtro de Consulta"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(33, 15)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(47, 19)
        Me.KryptonLabel2.TabIndex = 62
        Me.KryptonLabel2.Text = "Código"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Código"
        '
        'txtCodBusqueda
        '
        Me.txtCodBusqueda.Location = New System.Drawing.Point(86, 15)
        Me.txtCodBusqueda.MaxLength = 20
        Me.txtCodBusqueda.Name = "txtCodBusqueda"
        Me.txtCodBusqueda.Size = New System.Drawing.Size(190, 21)
        Me.txtCodBusqueda.TabIndex = 0
        '
        'txtDescripcionFiltro
        '
        Me.txtDescripcionFiltro.Location = New System.Drawing.Point(381, 15)
        Me.txtDescripcionFiltro.MaxLength = 50
        Me.txtDescripcionFiltro.Name = "txtDescripcionFiltro"
        Me.txtDescripcionFiltro.Size = New System.Drawing.Size(248, 21)
        Me.txtDescripcionFiltro.TabIndex = 2
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(307, 15)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(68, 19)
        Me.KryptonLabel5.TabIndex = 58
        Me.KryptonLabel5.Text = "Descripción"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Descripción"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(998, 720)
        Me.KryptonPanel.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CTRSPT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn2.FillWeight = 300.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 50
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 500
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMTRT"
        Me.DataGridViewTextBoxColumn3.FillWeight = 300.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Razón social"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "SESTAC"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Estado Asignación"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ST18str"
        Me.DataGridViewTextBoxColumn7.HeaderText = ""
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn42.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Visible = False
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "FCHCRT"
        Me.DataGridViewTextBoxColumn45.HeaderText = "FCHCRT"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Brevete Conductor"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Brevete"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "TNMCMC"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn43.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Visible = False
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "FECINI"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Fec. Ini. Asignación"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NOMCHOFER"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Nombre Conductor"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "FCHCRT"
        Me.DataGridViewTextBoxColumn29.HeaderText = "FCHCRT"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FECINI"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Fec. Ini. Asignación"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TABTRT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción Abrev."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TLFTRP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "FCHCRT"
        Me.DataGridViewTextBoxColumn40.HeaderText = "FCHCRT"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TDRCTR"
        Me.DataGridViewTextBoxColumn6.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn41.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Visible = False
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "SESTCH"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Estado Asignación"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn28.FillWeight = 180.0!
        Me.DataGridViewTextBoxColumn28.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "FECINI"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Fec. Ini. Asignación"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn30.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "FECFIN"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Fec. Fin Asignación"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "NEJSUN"
        Me.DataGridViewTextBoxColumn24.FillWeight = 180.0!
        Me.DataGridViewTextBoxColumn24.HeaderText = "Ejes"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NEJSUN"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Ejes"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Vehículo"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Visible = False
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "TAPMAC"
        Me.DataGridViewTextBoxColumn34.HeaderText = "A Materno"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ruc"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "SESTCM"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Estado Asignación"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "TAPPAC"
        Me.DataGridViewTextBoxColumn33.HeaderText = "A Paterno"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FECFIN"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Fec. Fin Asignación"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "FECFIN"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Fec. Fin Asignación"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TMRCVH"
        Me.DataGridViewTextBoxColumn23.FillWeight = 180.0!
        Me.DataGridViewTextBoxColumn23.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NPLACP"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Placa Acoplado"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Placa Vehículo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn46.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TMRCTR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn21.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "FCHCRT"
        Me.DataGridViewTextBoxColumn20.HeaderText = "FCHCRT"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "NPLCAC"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ST18tot"
        Me.DataGridViewTextBoxColumn8.HeaderText = ""
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'frmMantPartidaArancelaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 720)
        Me.Controls.Add(Me.KryptonPanel2)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmMantPartidaArancelaria"
        Me.Text = "Partidas Arancelarias"
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.dtgPartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCabecera.ResumeLayout(False)
        Me.tsCabecera.PerformLayout()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        Me.TabTransportista.ResumeLayout(False)
        Me.TabDatosTransportista.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents TabTransportista As System.Windows.Forms.TabControl
    Friend WithEvents TabDatosTransportista As System.Windows.Forms.TabPage
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigoMante As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboPaginas As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodBusqueda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDescripcionFiltro As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtPorcentaje As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents tsCabecera As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtgPartida As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CPTDAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDEPTD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRARAN As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
