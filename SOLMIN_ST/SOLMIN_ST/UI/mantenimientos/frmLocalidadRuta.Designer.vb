<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalidadRuta
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalidadRuta))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.CodigoLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DescLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.AbrevLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CUBGEL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.UBIGEO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnImprimir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtBuscar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.ctbUbigeo = New CodeTextBox.CodeTextBox
    Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtAbrevDesLocalidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtDesLocalidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderGroupFiltro.Panel.SuspendLayout()
    Me.HeaderGroupFiltro.SuspendLayout()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderDatos.Panel.SuspendLayout()
    Me.HeaderDatos.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.gwdDatos)
    Me.KryptonPanel.Controls.Add(Me.HeaderGroupFiltro)
    Me.KryptonPanel.Controls.Add(Me.HeaderDatos)
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
    Me.gwdDatos.AllowUserToOrderColumns = True
    Me.gwdDatos.ColumnHeadersHeight = 30
    Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoLocalidad, Me.DescLocalidad, Me.AbrevLocalidad, Me.CUBGEL, Me.UBIGEO})
    Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.gwdDatos.Location = New System.Drawing.Point(0, 88)
    Me.gwdDatos.MultiSelect = False
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.ReadOnly = True
    Me.gwdDatos.RowHeadersWidth = 20
    Me.gwdDatos.RowTemplate.Height = 16
    Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatos.Size = New System.Drawing.Size(892, 432)
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 7
    '
    'CodigoLocalidad
    '
    Me.CodigoLocalidad.DataPropertyName = "CLCLD"
    Me.CodigoLocalidad.HeaderText = "Código Localidad"
    Me.CodigoLocalidad.Name = "CodigoLocalidad"
    Me.CodigoLocalidad.ReadOnly = True
    '
    'DescLocalidad
    '
    Me.DescLocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DescLocalidad.DataPropertyName = "TCMLCL"
    Me.DescLocalidad.HeaderText = "Descripción Localidad"
    Me.DescLocalidad.Name = "DescLocalidad"
    Me.DescLocalidad.ReadOnly = True
    Me.DescLocalidad.Width = 148
    '
    'AbrevLocalidad
    '
    Me.AbrevLocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.AbrevLocalidad.DataPropertyName = "TABLCL"
    Me.AbrevLocalidad.HeaderText = "Abrev. Localidad"
    Me.AbrevLocalidad.Name = "AbrevLocalidad"
    Me.AbrevLocalidad.ReadOnly = True
    '
    'CUBGEL
    '
    Me.CUBGEL.DataPropertyName = "CUBGEL"
    Me.CUBGEL.HeaderText = "CUBGEL"
    Me.CUBGEL.Name = "CUBGEL"
    Me.CUBGEL.ReadOnly = True
    Me.CUBGEL.Visible = False
    '
    'UBIGEO
    '
    Me.UBIGEO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.UBIGEO.DataPropertyName = "UBIGEO"
    Me.UBIGEO.HeaderText = "Ubigeo"
    Me.UBIGEO.Name = "UBIGEO"
    Me.UBIGEO.ReadOnly = True
    Me.UBIGEO.Width = 74
    '
    'HeaderGroupFiltro
    '
    Me.HeaderGroupFiltro.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnImprimir, Me.btnBuscar})
    Me.HeaderGroupFiltro.Dock = System.Windows.Forms.DockStyle.Top
    Me.HeaderGroupFiltro.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderGroupFiltro.Location = New System.Drawing.Point(0, 0)
    Me.HeaderGroupFiltro.Name = "HeaderGroupFiltro"
    '
    'HeaderGroupFiltro.Panel
    '
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel19)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtBuscar)
    Me.HeaderGroupFiltro.Size = New System.Drawing.Size(892, 88)
    Me.HeaderGroupFiltro.TabIndex = 2
    Me.HeaderGroupFiltro.Text = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
    Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
    Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
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
    Me.btnImprimir.UniqueName = "DFF5FEE620A14875DFF5FEE620A14875"
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
    'KryptonLabel19
    '
    Me.KryptonLabel19.Location = New System.Drawing.Point(8, 13)
    Me.KryptonLabel19.Name = "KryptonLabel19"
    Me.KryptonLabel19.Size = New System.Drawing.Size(112, 17)
    Me.KryptonLabel19.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel19.TabIndex = 103
    Me.KryptonLabel19.Text = "Localidad de Ruta"
    Me.KryptonLabel19.Values.ExtraText = ""
    Me.KryptonLabel19.Values.Image = Nothing
    Me.KryptonLabel19.Values.Text = "Localidad de Ruta"
    '
    'txtBuscar
    '
    Me.txtBuscar.Location = New System.Drawing.Point(126, 11)
    Me.txtBuscar.MaxLength = 30
    Me.txtBuscar.Name = "txtBuscar"
    Me.txtBuscar.Size = New System.Drawing.Size(200, 21)
    Me.txtBuscar.TabIndex = 2
    '
    'HeaderDatos
    '
    Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderDatos.HeaderVisibleSecondary = False
    Me.HeaderDatos.Location = New System.Drawing.Point(0, 520)
    Me.HeaderDatos.Name = "HeaderDatos"
    '
    'HeaderDatos.Panel
    '
    Me.HeaderDatos.Panel.Controls.Add(Me.Panel1)
    Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
    Me.HeaderDatos.Size = New System.Drawing.Size(892, 200)
    Me.HeaderDatos.TabIndex = 4
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
    Me.Panel1.Controls.Add(Me.ctbUbigeo)
    Me.Panel1.Controls.Add(Me.lblCodigo)
    Me.Panel1.Controls.Add(Me.KryptonLabel1)
    Me.Panel1.Controls.Add(Me.txtCodigo)
    Me.Panel1.Controls.Add(Me.txtAbrevDesLocalidad)
    Me.Panel1.Controls.Add(Me.txtDesLocalidad)
    Me.Panel1.Controls.Add(Me.KryptonLabel3)
    Me.Panel1.Controls.Add(Me.KryptonLabel2)
    Me.Panel1.Controls.Add(Me.KryptonLabel13)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 29)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(890, 149)
    Me.Panel1.TabIndex = 35
    '
    'ctbUbigeo
    '
    Me.ctbUbigeo.BackColor = System.Drawing.SystemColors.Control
    Me.ctbUbigeo.Codigo = ""
    Me.ctbUbigeo.ControlHeight = 23
    Me.ctbUbigeo.ControlImage = True
    Me.ctbUbigeo.ControlReadOnly = False
    Me.ctbUbigeo.Descripcion = ""
    Me.ctbUbigeo.DisplayColumnVisible = True
    Me.ctbUbigeo.DisplayMember = ""
    Me.ctbUbigeo.KeyColumnWidth = 100
    Me.ctbUbigeo.KeyField = ""
    Me.ctbUbigeo.KeySearch = True
    Me.ctbUbigeo.Location = New System.Drawing.Point(110, 85)
    Me.ctbUbigeo.Name = "ctbUbigeo"
    Me.ctbUbigeo.Size = New System.Drawing.Size(200, 23)
    Me.ctbUbigeo.TabIndex = 32
    Me.ctbUbigeo.Tag = ""
    Me.ctbUbigeo.TextBackColor = System.Drawing.Color.Empty
    Me.ctbUbigeo.TextForeColor = System.Drawing.Color.Empty
    Me.ctbUbigeo.ValueColumnVisible = True
    Me.ctbUbigeo.ValueColumnWidth = 600
    Me.ctbUbigeo.ValueField = ""
    Me.ctbUbigeo.ValueMember = ""
    Me.ctbUbigeo.ValueSearch = True
    '
    'lblCodigo
    '
    Me.lblCodigo.Location = New System.Drawing.Point(381, 19)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(47, 19)
    Me.lblCodigo.TabIndex = 1
    Me.lblCodigo.Text = "Codigo"
    Me.lblCodigo.Values.ExtraText = ""
    Me.lblCodigo.Values.Image = Nothing
    Me.lblCodigo.Values.Text = "Codigo"
    Me.lblCodigo.Visible = False
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(18, 19)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel1.TabIndex = 1
    Me.KryptonLabel1.Text = "Descripción"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Descripción"
    '
    'txtCodigo
    '
    Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigo.Location = New System.Drawing.Point(433, 18)
    Me.txtCodigo.MaxLength = 6
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(57, 21)
    Me.txtCodigo.TabIndex = 2
    Me.txtCodigo.Visible = False
    '
    'txtAbrevDesLocalidad
    '
    Me.txtAbrevDesLocalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtAbrevDesLocalidad.Location = New System.Drawing.Point(110, 50)
    Me.txtAbrevDesLocalidad.MaxLength = 30
    Me.txtAbrevDesLocalidad.Name = "txtAbrevDesLocalidad"
    Me.txtAbrevDesLocalidad.Size = New System.Drawing.Size(200, 21)
    Me.txtAbrevDesLocalidad.TabIndex = 2
    '
    'txtDesLocalidad
    '
    Me.txtDesLocalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDesLocalidad.Location = New System.Drawing.Point(110, 18)
    Me.txtDesLocalidad.MaxLength = 30
    Me.txtDesLocalidad.Name = "txtDesLocalidad"
    Me.txtDesLocalidad.Size = New System.Drawing.Size(200, 21)
    Me.txtDesLocalidad.TabIndex = 0
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(18, 85)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(47, 19)
    Me.KryptonLabel3.TabIndex = 3
    Me.KryptonLabel3.Text = "Ubigeo"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Ubigeo"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(18, 53)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel2.TabIndex = 3
    Me.KryptonLabel2.Text = "Abreviatura"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Abreviatura"
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
    Me.MenuBar.Size = New System.Drawing.Size(890, 29)
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
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "CLCLD"
    Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoLocalidad"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Visible = False
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "TABLCL"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Abrev. Localidad"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMLCL"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción Localidad"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'frmLocalidadRuta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(892, 720)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmLocalidadRuta"
    Me.Text = "Localidades de Ruta"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
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
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDesLocalidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtBuscar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAbrevDesLocalidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ctbUbigeo As CodeTextBox.CodeTextBox
    Friend WithEvents CodigoLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbrevLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUBGEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBIGEO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
