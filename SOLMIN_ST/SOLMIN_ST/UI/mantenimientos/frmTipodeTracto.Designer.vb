<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipodeTracto
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
    Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.Codigo_TipodeTracto = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Descripcion_TipodeTracto = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DescripAbrevTipodeTracto = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CodConfigVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.txtCodigoConfigVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Me.HgImagen = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.ImagenTracto = New System.Windows.Forms.PictureBox
    Me.btnImagen = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtDescripTipoTractoAbrev = New SOLMIN_ST.TextField
    Me.txtDescripTipoTracto = New SOLMIN_ST.TextField
    Me.txtCodigoTipoTracto = New SOLMIN_ST.TextField
    Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnNuevo = New System.Windows.Forms.ToolStripButton
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.btnEliminar = New System.Windows.Forms.ToolStripButton
    Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtBuscar = New SOLMIN_ST.TextField
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
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
    CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelGrilla.SuspendLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelFiltros.Panel.SuspendLayout()
    Me.PanelFiltros.SuspendLayout()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.SuspendLayout()
    '
    'gwdDatos
    '
    Me.gwdDatos.AllowUserToAddRows = False
    Me.gwdDatos.ColumnHeadersHeight = 30
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo_TipodeTracto, Me.Descripcion_TipodeTracto, Me.DescripAbrevTipodeTracto, Me.CodConfigVehiculo, Me.Imagen})
    Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.ReadOnly = True
    Me.gwdDatos.RowTemplate.Height = 90
    Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatos.Size = New System.Drawing.Size(918, 302)
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 0
    '
    'Codigo_TipodeTracto
    '
    Me.Codigo_TipodeTracto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.Codigo_TipodeTracto.DataPropertyName = "CTITRA"
    Me.Codigo_TipodeTracto.HeaderText = "Codigo"
    Me.Codigo_TipodeTracto.Name = "Codigo_TipodeTracto"
    Me.Codigo_TipodeTracto.ReadOnly = True
    Me.Codigo_TipodeTracto.Width = 74
    '
    'Descripcion_TipodeTracto
    '
    Me.Descripcion_TipodeTracto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.Descripcion_TipodeTracto.DataPropertyName = "TDETRA"
    Me.Descripcion_TipodeTracto.HeaderText = "Descrip Tipo Tracto"
    Me.Descripcion_TipodeTracto.Name = "Descripcion_TipodeTracto"
    Me.Descripcion_TipodeTracto.ReadOnly = True
    Me.Descripcion_TipodeTracto.Width = 133
    '
    'DescripAbrevTipodeTracto
    '
    Me.DescripAbrevTipodeTracto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DescripAbrevTipodeTracto.DataPropertyName = "TABDES"
    Me.DescripAbrevTipodeTracto.HeaderText = "Descrip Abrev Tipode Tracto"
    Me.DescripAbrevTipodeTracto.Name = "DescripAbrevTipodeTracto"
    Me.DescripAbrevTipodeTracto.ReadOnly = True
    Me.DescripAbrevTipodeTracto.Width = 178
    '
    'CodConfigVehiculo
    '
    Me.CodConfigVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CodConfigVehiculo.DataPropertyName = "TCNFVH"
    Me.CodConfigVehiculo.HeaderText = "Cod Config Vehiculo"
    Me.CodConfigVehiculo.Name = "CodConfigVehiculo"
    Me.CodConfigVehiculo.ReadOnly = True
    Me.CodConfigVehiculo.Width = 143
    '
    'Imagen
    '
    Me.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.Imagen.DataPropertyName = "IMAGEN"
    Me.Imagen.HeaderText = "Imagen"
    Me.Imagen.Name = "Imagen"
    Me.Imagen.ReadOnly = True
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
    '
    'HeaderDatos
    '
    Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderDatos.HeaderVisibleSecondary = False
    Me.HeaderDatos.Location = New System.Drawing.Point(0, 0)
    Me.HeaderDatos.Name = "HeaderDatos"
    '
    'HeaderDatos.Panel
    '
    Me.HeaderDatos.Panel.Controls.Add(Me.txtCodigoConfigVehiculo)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonBorderEdge1)
    Me.HeaderDatos.Panel.Controls.Add(Me.HgImagen)
    Me.HeaderDatos.Panel.Controls.Add(Me.btnImagen)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel6)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtDescripTipoTractoAbrev)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtDescripTipoTracto)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtCodigoTipoTracto)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel13)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel4)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel3)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel2)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel1)
    Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
    Me.HeaderDatos.Size = New System.Drawing.Size(918, 268)
    Me.HeaderDatos.TabIndex = 0
    Me.HeaderDatos.Text = "Información de Mantenimiento"
    Me.HeaderDatos.ValuesPrimary.Description = ""
    Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
    Me.HeaderDatos.ValuesPrimary.Image = Nothing
    Me.HeaderDatos.ValuesSecondary.Description = ""
    Me.HeaderDatos.ValuesSecondary.Heading = "Description"
    Me.HeaderDatos.ValuesSecondary.Image = Nothing
    '
    'txtCodigoConfigVehiculo
    '
    Me.txtCodigoConfigVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.txtCodigoConfigVehiculo.DropDownWidth = 224
    Me.txtCodigoConfigVehiculo.FormattingEnabled = False
    Me.txtCodigoConfigVehiculo.ItemHeight = 13
    Me.txtCodigoConfigVehiculo.Items.AddRange(New Object() {"C2", "C3", "T2", "T3"})
    Me.txtCodigoConfigVehiculo.Location = New System.Drawing.Point(103, 100)
    Me.txtCodigoConfigVehiculo.Name = "txtCodigoConfigVehiculo"
    Me.txtCodigoConfigVehiculo.Size = New System.Drawing.Size(224, 21)
    Me.txtCodigoConfigVehiculo.TabIndex = 51
    '
    'KryptonBorderEdge1
    '
    Me.KryptonBorderEdge1.Location = New System.Drawing.Point(355, 40)
    Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
    Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 155)
    Me.KryptonBorderEdge1.TabIndex = 50
    Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
    '
    'HgImagen
    '
    Me.HgImagen.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HgImagen.HeaderVisibleSecondary = False
    Me.HgImagen.Location = New System.Drawing.Point(387, 42)
    Me.HgImagen.Name = "HgImagen"
    '
    'HgImagen.Panel
    '
    Me.HgImagen.Panel.Controls.Add(Me.ImagenTracto)
    Me.HgImagen.Size = New System.Drawing.Size(272, 132)
    Me.HgImagen.TabIndex = 49
    Me.HgImagen.Text = "Imagen de Configuración Vehicular"
    Me.HgImagen.ValuesPrimary.Description = ""
    Me.HgImagen.ValuesPrimary.Heading = "Imagen de Configuración Vehicular"
    Me.HgImagen.ValuesPrimary.Image = Nothing
    Me.HgImagen.ValuesSecondary.Description = ""
    Me.HgImagen.ValuesSecondary.Heading = "Description"
    Me.HgImagen.ValuesSecondary.Image = Nothing
    '
    'ImagenTracto
    '
    Me.ImagenTracto.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ImagenTracto.Location = New System.Drawing.Point(0, 0)
    Me.ImagenTracto.Name = "ImagenTracto"
    Me.ImagenTracto.Size = New System.Drawing.Size(270, 110)
    Me.ImagenTracto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.ImagenTracto.TabIndex = 0
    Me.ImagenTracto.TabStop = False
    '
    'btnImagen
    '
    Me.btnImagen.Location = New System.Drawing.Point(103, 130)
    Me.btnImagen.Name = "btnImagen"
    Me.btnImagen.Size = New System.Drawing.Size(88, 24)
    Me.btnImagen.TabIndex = 48
    Me.btnImagen.Text = "Escoja Imagen"
    Me.btnImagen.Values.ExtraText = ""
    Me.btnImagen.Values.Image = Nothing
    Me.btnImagen.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnImagen.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnImagen.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnImagen.Values.Text = "Escoja Imagen"
    Me.btnImagen.Visible = False
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(9, 134)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(48, 19)
    Me.KryptonLabel6.TabIndex = 46
    Me.KryptonLabel6.Text = "Imagen"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Imagen"
    Me.KryptonLabel6.Visible = False
    '
    'txtDescripTipoTractoAbrev
    '
    Me.txtDescripTipoTractoAbrev.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDescripTipoTractoAbrev.Location = New System.Drawing.Point(103, 71)
    Me.txtDescripTipoTractoAbrev.MaxLength = 50
    Me.txtDescripTipoTractoAbrev.Name = "txtDescripTipoTractoAbrev"
    Me.txtDescripTipoTractoAbrev.Size = New System.Drawing.Size(224, 21)
    Me.txtDescripTipoTractoAbrev.TabIndex = 44
    Me.txtDescripTipoTractoAbrev.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'txtDescripTipoTracto
    '
    Me.txtDescripTipoTracto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDescripTipoTracto.Location = New System.Drawing.Point(103, 42)
    Me.txtDescripTipoTracto.MaxLength = 250
    Me.txtDescripTipoTracto.Name = "txtDescripTipoTracto"
    Me.txtDescripTipoTracto.Size = New System.Drawing.Size(224, 21)
    Me.txtDescripTipoTracto.TabIndex = 43
    Me.txtDescripTipoTracto.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'txtCodigoTipoTracto
    '
    Me.txtCodigoTipoTracto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigoTipoTracto.Location = New System.Drawing.Point(103, 165)
    Me.txtCodigoTipoTracto.Name = "txtCodigoTipoTracto"
    Me.txtCodigoTipoTracto.Size = New System.Drawing.Size(224, 21)
    Me.txtCodigoTipoTracto.TabIndex = 42
    Me.txtCodigoTipoTracto.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    Me.txtCodigoTipoTracto.Visible = False
    '
    'KryptonLabel13
    '
    Me.KryptonLabel13.Location = New System.Drawing.Point(579, 108)
    Me.KryptonLabel13.Name = "KryptonLabel13"
    Me.KryptonLabel13.Size = New System.Drawing.Size(6, 2)
    Me.KryptonLabel13.TabIndex = 31
    Me.KryptonLabel13.Values.ExtraText = ""
    Me.KryptonLabel13.Values.Image = Nothing
    Me.KryptonLabel13.Values.Text = ""
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(9, 104)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(86, 19)
    Me.KryptonLabel4.TabIndex = 7
    Me.KryptonLabel4.Text = "Conf. Vehicular"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Conf. Vehicular"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(9, 75)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel3.TabIndex = 5
    Me.KryptonLabel3.Text = "Abreviatura"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Abreviatura"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(9, 46)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel2.TabIndex = 3
    Me.KryptonLabel2.Text = "Descripción"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Descripción"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(9, 169)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(47, 19)
    Me.KryptonLabel1.TabIndex = 1
    Me.KryptonLabel1.Text = "Código "
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Código "
    Me.KryptonLabel1.Visible = False
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.ImageScalingSize = New System.Drawing.Size(22, 22)
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(916, 29)
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
    'btnGuardar
    '
    Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
    Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(75, 26)
    Me.btnGuardar.Text = "Guardar"
    '
    'btnCancelar
    '
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(77, 26)
    Me.btnCancelar.Text = "Cancelar"
    '
    'btnEliminar
    '
    Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
    Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(74, 26)
    Me.btnEliminar.Text = "Eliminar"
    '
    'PanelGrilla
    '
    Me.PanelGrilla.Controls.Add(Me.gwdDatos)
    Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelGrilla.Location = New System.Drawing.Point(0, 70)
    Me.PanelGrilla.Name = "PanelGrilla"
    Me.PanelGrilla.Size = New System.Drawing.Size(918, 302)
    Me.PanelGrilla.TabIndex = 1
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
    Me.PanelFiltros.Panel.Controls.Add(Me.txtBuscar)
    Me.PanelFiltros.Size = New System.Drawing.Size(918, 70)
    Me.PanelFiltros.TabIndex = 0
    Me.PanelFiltros.ValuesPrimary.Description = ""
    Me.PanelFiltros.ValuesPrimary.Heading = ""
    Me.PanelFiltros.ValuesPrimary.Image = Nothing
    Me.PanelFiltros.ValuesSecondary.Description = " "
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
    Me.btnBuscar.UniqueName = "FE1DCFE088AE475FFE1DCFE088AE475F"
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(10, 11)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(82, 19)
    Me.KryptonLabel5.TabIndex = 45
    Me.KryptonLabel5.Text = "Tipo de Tracto"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Tipo de Tracto"
    '
    'txtBuscar
    '
    Me.txtBuscar.Location = New System.Drawing.Point(101, 10)
    Me.txtBuscar.Name = "txtBuscar"
    Me.txtBuscar.Size = New System.Drawing.Size(200, 21)
    Me.txtBuscar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtBuscar.TabIndex = 44
    Me.txtBuscar.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.PanelGrilla)
    Me.SplitContainer1.Panel1.Controls.Add(Me.PanelFiltros)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.HeaderDatos)
    Me.SplitContainer1.Size = New System.Drawing.Size(918, 644)
    Me.SplitContainer1.SplitterDistance = 372
    Me.SplitContainer1.TabIndex = 2
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.DefaultExt = "*.jpg,*.jpeg,*.gif,*.png"
    Me.OpenFileDialog1.Title = "Escoja Imagen de Tracto"
    '
    'frmTipodeTracto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(918, 644)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Name = "frmTipodeTracto"
    Me.Text = "Tipo de Tracto"
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
    CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelGrilla.ResumeLayout(False)
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.Panel.ResumeLayout(False)
    Me.PanelFiltros.Panel.PerformLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtDescripTipoTractoAbrev As SOLMIN_ST.TextField
    Friend WithEvents txtDescripTipoTracto As SOLMIN_ST.TextField
    Friend WithEvents txtCodigoTipoTracto As SOLMIN_ST.TextField
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelGrilla As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtBuscar As SOLMIN_ST.TextField
    Friend WithEvents btnImagen As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HgImagen As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ImagenTracto As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents txtCodigoConfigVehiculo As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents Codigo_TipodeTracto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion_TipodeTracto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripAbrevTipodeTracto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodConfigVehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Imagen As System.Windows.Forms.DataGridViewImageColumn
End Class
