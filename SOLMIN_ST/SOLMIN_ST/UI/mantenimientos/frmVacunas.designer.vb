<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVacunas
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCOVAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMVAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtObservacionesVacuna = New SOLMIN_ST.TextField
        Me.txtNombreVacuna = New SOLMIN_ST.TextField
        Me.txtCodigoVacuna = New SOLMIN_ST.TextField
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtFiltroVacuna = New SOLMIN_ST.TextField
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.HeaderDatos)
        Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(892, 720)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 52)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.gwdDatos)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(892, 445)
        Me.KryptonHeaderGroup1.TabIndex = 6
        Me.KryptonHeaderGroup1.Text = "Vacunas"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Vacunas"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCOVAC, Me.NOMVAC, Me.TOBS})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(890, 426)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 4
        '
        'NCOVAC
        '
        Me.NCOVAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCOVAC.DataPropertyName = "NCOVAC"
        Me.NCOVAC.HeaderText = "Código"
        Me.NCOVAC.Name = "NCOVAC"
        Me.NCOVAC.ReadOnly = True
        Me.NCOVAC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NCOVAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NCOVAC.Width = 50
        '
        'NOMVAC
        '
        Me.NOMVAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOMVAC.DataPropertyName = "NOMVAC"
        Me.NOMVAC.HeaderText = "Nombre"
        Me.NOMVAC.Name = "NOMVAC"
        Me.NOMVAC.ReadOnly = True
        Me.NOMVAC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NOMVAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NOMVAC.Width = 54
        '
        'TOBS
        '
        Me.TOBS.DataPropertyName = "TOBS"
        Me.TOBS.HeaderText = "Observaciones"
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ReadOnly = True
        Me.TOBS.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TOBS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'HeaderDatos
        '
        Me.HeaderDatos.AutoSize = True
        Me.HeaderDatos.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup3})
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 497)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.txtObservacionesVacuna)
        Me.HeaderDatos.Panel.Controls.Add(Me.txtNombreVacuna)
        Me.HeaderDatos.Panel.Controls.Add(Me.txtCodigoVacuna)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel3)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel14)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(892, 223)
        Me.HeaderDatos.TabIndex = 5
        Me.HeaderDatos.Text = "Vacunas"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Vacunas"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup3
        '
        Me.ButtonSpecHeaderGroup3.ExtraText = ""
        Me.ButtonSpecHeaderGroup3.Image = Nothing
        Me.ButtonSpecHeaderGroup3.Text = ""
        Me.ButtonSpecHeaderGroup3.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecHeaderGroup3.UniqueName = "97A22201E33B4A5197A22201E33B4A51"
        '
        'txtObservacionesVacuna
        '
        Me.txtObservacionesVacuna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacionesVacuna.Location = New System.Drawing.Point(127, 111)
        Me.txtObservacionesVacuna.MaxLength = 250
        Me.txtObservacionesVacuna.Multiline = True
        Me.txtObservacionesVacuna.Name = "txtObservacionesVacuna"
        Me.txtObservacionesVacuna.Size = New System.Drawing.Size(360, 70)
        Me.txtObservacionesVacuna.TabIndex = 52
        Me.txtObservacionesVacuna.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtNombreVacuna
        '
        Me.txtNombreVacuna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreVacuna.Location = New System.Drawing.Point(127, 87)
        Me.txtNombreVacuna.MaxLength = 100
        Me.txtNombreVacuna.Name = "txtNombreVacuna"
        Me.txtNombreVacuna.Size = New System.Drawing.Size(360, 19)
        Me.txtNombreVacuna.TabIndex = 51
        Me.txtNombreVacuna.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtCodigoVacuna
        '
        Me.txtCodigoVacuna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoVacuna.Location = New System.Drawing.Point(127, 63)
        Me.txtCodigoVacuna.Name = "txtCodigoVacuna"
        Me.txtCodigoVacuna.ReadOnly = True
        Me.txtCodigoVacuna.Size = New System.Drawing.Size(71, 19)
        Me.txtCodigoVacuna.TabIndex = 50
        Me.txtCodigoVacuna.Text = "0"
        Me.txtCodigoVacuna.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        Me.txtCodigoVacuna.Visible = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 115)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(86, 16)
        Me.KryptonLabel3.TabIndex = 48
        Me.KryptonLabel3.Text = "Observaciones"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Observaciones"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(10, 91)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(50, 16)
        Me.KryptonLabel2.TabIndex = 47
        Me.KryptonLabel2.Text = "Nombre"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nombre"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 67)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(46, 16)
        Me.KryptonLabel1.TabIndex = 46
        Me.KryptonLabel1.Text = "Código"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Código"
        Me.KryptonLabel1.Visible = False
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(11, 34)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(129, 18)
        Me.KryptonLabel14.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel14.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel14.TabIndex = 39
        Me.KryptonLabel14.Text = "Información General "
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Información General "
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(890, 29)
        Me.MenuBar.TabIndex = 1
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(65, 26)
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
        Me.btnGuardar.Size = New System.Drawing.Size(71, 26)
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
        Me.btnCancelar.Size = New System.Drawing.Size(75, 26)
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
        Me.btnEliminar.Size = New System.Drawing.Size(69, 26)
        Me.btnEliminar.Text = "Eliminar"
        '
        'PanelFiltros
        '
        Me.PanelFiltros.AutoSize = True
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnBuscar, Me.ButtonSpecHeaderGroup2})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisibleSecondary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.txtFiltroVacuna)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Size = New System.Drawing.Size(892, 52)
        Me.PanelFiltros.TabIndex = 3
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
        Me.btnBuscar.Image = Nothing
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipImage = Nothing
        Me.btnBuscar.UniqueName = "527DBA93D407419D527DBA93D407419D"
        '
        'ButtonSpecHeaderGroup2
        '
        Me.ButtonSpecHeaderGroup2.ExtraText = ""
        Me.ButtonSpecHeaderGroup2.Image = Nothing
        Me.ButtonSpecHeaderGroup2.Text = ""
        Me.ButtonSpecHeaderGroup2.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup2.UniqueName = "29405086412A4B2E29405086412A4B2E"
        '
        'txtFiltroVacuna
        '
        Me.txtFiltroVacuna.Location = New System.Drawing.Point(127, 6)
        Me.txtFiltroVacuna.MaxLength = 100
        Me.txtFiltroVacuna.Name = "txtFiltroVacuna"
        Me.txtFiltroVacuna.Size = New System.Drawing.Size(324, 19)
        Me.txtFiltroVacuna.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFiltroVacuna.TabIndex = 60
        Me.txtFiltroVacuna.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(17, 6)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(106, 16)
        Me.KryptonLabel5.TabIndex = 59
        Me.KryptonLabel5.Text = "Nombre de vacuna"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Nombre de vacuna"
        '
        'frmVacunas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 720)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmVacunas"
        Me.Text = "Vacunas"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
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
    Friend WithEvents txtFiltroVacuna As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtObservacionesVacuna As SOLMIN_ST.TextField
    Friend WithEvents txtNombreVacuna As SOLMIN_ST.TextField
    Friend WithEvents txtCodigoVacuna As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup3 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents NCOVAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMVAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
