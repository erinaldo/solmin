<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoAcoplado
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
    Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.CTIACP = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TDEACP = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TABDES = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TCNFVH = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn
    Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.txtCodigoConfiguracionVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.txtDescripTipoTractoAbrev = New SOLMIN_ST.TextField
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Me.HgImagen = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.ImagenTracto = New System.Windows.Forms.PictureBox
    Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtDescripcionTipoAcoplado = New SOLMIN_ST.TextField
    Me.txtCodigoTipoAcoplado = New SOLMIN_ST.TextField
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnNuevo = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEliminar = New System.Windows.Forms.ToolStripButton
    Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtFiltroTipoAcoplado = New SOLMIN_ST.TextField
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderDatos.Panel.SuspendLayout()
    Me.HeaderDatos.SuspendLayout()
    CType(Me.HgImagen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HgImagen.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HgImagen.Panel.SuspendLayout()
    Me.HgImagen.SuspendLayout()
    CType(Me.ImagenTracto, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MenuBar.SuspendLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelFiltros.Panel.SuspendLayout()
    Me.PanelFiltros.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.gwdDatos)
    Me.KryptonPanel.Controls.Add(Me.HeaderDatos)
    Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(892, 720)
    Me.KryptonPanel.TabIndex = 0
    '
    'gwdDatos
    '
    Me.gwdDatos.AllowUserToAddRows = False
    Me.gwdDatos.AllowUserToDeleteRows = False
    Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTIACP, Me.TDEACP, Me.TABDES, Me.TCNFVH, Me.Imagen})
    Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.gwdDatos.Location = New System.Drawing.Point(0, 70)
    Me.gwdDatos.MultiSelect = False
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatos.Size = New System.Drawing.Size(892, 382)
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 5
    '
    'CTIACP
    '
    Me.CTIACP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CTIACP.DataPropertyName = "CTIACP"
    Me.CTIACP.HeaderText = "Código"
    Me.CTIACP.Name = "CTIACP"
    Me.CTIACP.ReadOnly = True
    Me.CTIACP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.CTIACP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.CTIACP.Width = 55
    '
    'TDEACP
    '
    Me.TDEACP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.TDEACP.DataPropertyName = "TDEACP"
    Me.TDEACP.HeaderText = "Descripción"
    Me.TDEACP.Name = "TDEACP"
    Me.TDEACP.ReadOnly = True
    Me.TDEACP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.TDEACP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.TDEACP.Width = 77
    '
    'TABDES
    '
    Me.TABDES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.TABDES.DataPropertyName = "TABDES"
    Me.TABDES.HeaderText = "Tipo Tracto"
    Me.TABDES.Name = "TABDES"
    Me.TABDES.ReadOnly = True
    Me.TABDES.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.TABDES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.TABDES.Width = 66
    '
    'TCNFVH
    '
    Me.TCNFVH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.TCNFVH.DataPropertyName = "TCNFVH"
    Me.TCNFVH.HeaderText = "Código Vehículo"
    Me.TCNFVH.Name = "TCNFVH"
    Me.TCNFVH.Width = 112
    '
    'Imagen
    '
    Me.Imagen.DataPropertyName = "IMAGEN"
    Me.Imagen.HeaderText = "Imagen"
    Me.Imagen.Name = "Imagen"
    '
    'HeaderDatos
    '
    Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderDatos.HeaderVisibleSecondary = False
    Me.HeaderDatos.Location = New System.Drawing.Point(0, 452)
    Me.HeaderDatos.Name = "HeaderDatos"
    '
    'HeaderDatos.Panel
    '
    Me.HeaderDatos.Panel.Controls.Add(Me.txtCodigoConfiguracionVehiculo)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtDescripTipoTractoAbrev)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel3)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonBorderEdge1)
    Me.HeaderDatos.Panel.Controls.Add(Me.HgImagen)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonButton1)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel6)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtDescripcionTipoAcoplado)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtCodigoTipoAcoplado)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel4)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel2)
    Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
    Me.HeaderDatos.Size = New System.Drawing.Size(892, 268)
    Me.HeaderDatos.TabIndex = 3
    Me.HeaderDatos.Text = "Información a Registrar"
    Me.HeaderDatos.ValuesPrimary.Description = ""
    Me.HeaderDatos.ValuesPrimary.Heading = "Información a Registrar"
    Me.HeaderDatos.ValuesPrimary.Image = Nothing
    Me.HeaderDatos.ValuesSecondary.Description = ""
    Me.HeaderDatos.ValuesSecondary.Heading = "Description"
    Me.HeaderDatos.ValuesSecondary.Image = Nothing
    '
    'txtCodigoConfiguracionVehiculo
    '
    Me.txtCodigoConfiguracionVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.txtCodigoConfiguracionVehiculo.DropDownWidth = 224
    Me.txtCodigoConfiguracionVehiculo.FormattingEnabled = False
    Me.txtCodigoConfiguracionVehiculo.ItemHeight = 13
    Me.txtCodigoConfiguracionVehiculo.Items.AddRange(New Object() {"S1", "S2", "S3", "R3", "R2", "SE2", "SE3"})
    Me.txtCodigoConfiguracionVehiculo.Location = New System.Drawing.Point(100, 97)
    Me.txtCodigoConfiguracionVehiculo.Name = "txtCodigoConfiguracionVehiculo"
    Me.txtCodigoConfiguracionVehiculo.Size = New System.Drawing.Size(224, 21)
    Me.txtCodigoConfiguracionVehiculo.TabIndex = 62
    '
    'txtDescripTipoTractoAbrev
    '
    Me.txtDescripTipoTractoAbrev.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDescripTipoTractoAbrev.Location = New System.Drawing.Point(100, 66)
    Me.txtDescripTipoTractoAbrev.Name = "txtDescripTipoTractoAbrev"
    Me.txtDescripTipoTractoAbrev.Size = New System.Drawing.Size(224, 21)
    Me.txtDescripTipoTractoAbrev.TabIndex = 61
    Me.txtDescripTipoTractoAbrev.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(12, 66)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel3.TabIndex = 60
    Me.KryptonLabel3.Text = "Abreviatura"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Abreviatura"
    '
    'KryptonBorderEdge1
    '
    Me.KryptonBorderEdge1.Location = New System.Drawing.Point(350, 36)
    Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
    Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 140)
    Me.KryptonBorderEdge1.TabIndex = 59
    Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
    '
    'HgImagen
    '
    Me.HgImagen.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HgImagen.HeaderVisibleSecondary = False
    Me.HgImagen.Location = New System.Drawing.Point(382, 36)
    Me.HgImagen.Name = "HgImagen"
    '
    'HgImagen.Panel
    '
    Me.HgImagen.Panel.Controls.Add(Me.ImagenTracto)
    Me.HgImagen.Size = New System.Drawing.Size(272, 132)
    Me.HgImagen.TabIndex = 58
    Me.HgImagen.Text = "Imagen de Configuracion Vehicular"
    Me.HgImagen.ValuesPrimary.Description = ""
    Me.HgImagen.ValuesPrimary.Heading = "Imagen de Configuracion Vehicular"
    Me.HgImagen.ValuesPrimary.Image = Nothing
    Me.HgImagen.ValuesSecondary.Description = ""
    Me.HgImagen.ValuesSecondary.Heading = "Description"
    Me.HgImagen.ValuesSecondary.Image = Nothing
    '
    'ImagenTracto
    '
    Me.ImagenTracto.Location = New System.Drawing.Point(4, 4)
    Me.ImagenTracto.Name = "ImagenTracto"
    Me.ImagenTracto.Size = New System.Drawing.Size(260, 100)
    Me.ImagenTracto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.ImagenTracto.TabIndex = 0
    Me.ImagenTracto.TabStop = False
    '
    'KryptonButton1
    '
    Me.KryptonButton1.Location = New System.Drawing.Point(100, 127)
    Me.KryptonButton1.Name = "KryptonButton1"
    Me.KryptonButton1.Size = New System.Drawing.Size(88, 24)
    Me.KryptonButton1.TabIndex = 57
    Me.KryptonButton1.Text = "Escoja Imagen"
    Me.KryptonButton1.Values.ExtraText = ""
    Me.KryptonButton1.Values.Image = Nothing
    Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.KryptonButton1.Values.Text = "Escoja Imagen"
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(12, 128)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(48, 19)
    Me.KryptonLabel6.TabIndex = 54
    Me.KryptonLabel6.Text = "Imagen"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Imagen"
    '
    'txtDescripcionTipoAcoplado
    '
    Me.txtDescripcionTipoAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDescripcionTipoAcoplado.Location = New System.Drawing.Point(100, 36)
    Me.txtDescripcionTipoAcoplado.MaxLength = 250
    Me.txtDescripcionTipoAcoplado.Name = "txtDescripcionTipoAcoplado"
    Me.txtDescripcionTipoAcoplado.Size = New System.Drawing.Size(224, 21)
    Me.txtDescripcionTipoAcoplado.TabIndex = 10
    Me.txtDescripcionTipoAcoplado.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'txtCodigoTipoAcoplado
    '
    Me.txtCodigoTipoAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigoTipoAcoplado.Location = New System.Drawing.Point(12, 153)
    Me.txtCodigoTipoAcoplado.MaxLength = 6
    Me.txtCodigoTipoAcoplado.Name = "txtCodigoTipoAcoplado"
    Me.txtCodigoTipoAcoplado.ReadOnly = True
    Me.txtCodigoTipoAcoplado.Size = New System.Drawing.Size(40, 21)
    Me.txtCodigoTipoAcoplado.TabIndex = 50
    Me.txtCodigoTipoAcoplado.Text = "0"
    Me.txtCodigoTipoAcoplado.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    Me.txtCodigoTipoAcoplado.Visible = False
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(12, 97)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(93, 19)
    Me.KryptonLabel4.TabIndex = 46
    Me.KryptonLabel4.Text = "Código Vehículo"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Código Vehículo"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(12, 37)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel2.TabIndex = 46
    Me.KryptonLabel2.Text = "Descripción"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Descripción"
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(890, 25)
    Me.MenuBar.TabIndex = 1
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnNuevo
    '
    Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
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
    Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
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
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
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
    Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
    Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
    Me.btnEliminar.Text = "Eliminar"
    '
    'PanelFiltros
    '
    Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnBuscar})
    Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
    Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.PanelFiltros.HeaderVisiblePrimary = False
    Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
    Me.PanelFiltros.Name = "PanelFiltros"
    '
    'PanelFiltros.Panel
    '
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtFiltroTipoAcoplado)
    Me.PanelFiltros.Size = New System.Drawing.Size(892, 70)
    Me.PanelFiltros.TabIndex = 1
    Me.PanelFiltros.Text = "Filtro de Consulta"
    Me.PanelFiltros.ValuesPrimary.Description = ""
    Me.PanelFiltros.ValuesPrimary.Heading = "Filtro de Consulta"
    Me.PanelFiltros.ValuesPrimary.Image = Nothing
    Me.PanelFiltros.ValuesSecondary.Description = ""
    Me.PanelFiltros.ValuesSecondary.Heading = "Description"
    Me.PanelFiltros.ValuesSecondary.Image = Nothing
    '
    'btnBuscar
    '
    Me.btnBuscar.ExtraText = ""
    Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
    Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
    Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.ToolTipImage = Nothing
    Me.btnBuscar.UniqueName = "DE2BCA3918E14D91DE2BCA3918E14D91"
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(9, 10)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(83, 19)
    Me.KryptonLabel5.TabIndex = 58
    Me.KryptonLabel5.Text = "Tipo Acoplado"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Tipo Acoplado"
    '
    'txtFiltroTipoAcoplado
    '
    Me.txtFiltroTipoAcoplado.Location = New System.Drawing.Point(100, 9)
    Me.txtFiltroTipoAcoplado.MaxLength = 250
    Me.txtFiltroTipoAcoplado.Name = "txtFiltroTipoAcoplado"
    Me.txtFiltroTipoAcoplado.Size = New System.Drawing.Size(200, 21)
    Me.txtFiltroTipoAcoplado.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtFiltroTipoAcoplado.TabIndex = 5
    Me.txtFiltroTipoAcoplado.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "CTIACP"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "TDEACP"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "TABDES"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo Tracto"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "TCNFVH"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Código Vehículo"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'frmTipoAcoplado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(892, 720)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmTipoAcoplado"
    Me.Text = "Tipo de Acoplado"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderDatos.Panel.ResumeLayout(False)
    Me.HeaderDatos.Panel.PerformLayout()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderDatos.ResumeLayout(False)
    CType(Me.HgImagen.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HgImagen.Panel.ResumeLayout(False)
    CType(Me.HgImagen, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HgImagen.ResumeLayout(False)
    CType(Me.ImagenTracto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDescripcionTipoAcoplado As SOLMIN_ST.TextField
    Friend WithEvents txtCodigoTipoAcoplado As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFiltroTipoAcoplado As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents HgImagen As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ImagenTracto As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtDescripTipoTractoAbrev As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoConfiguracionVehiculo As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents CTIACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDEACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCNFVH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Imagen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
