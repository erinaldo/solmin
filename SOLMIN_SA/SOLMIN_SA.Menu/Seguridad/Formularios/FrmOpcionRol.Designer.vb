<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpcionRol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpcionRol))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gwdOpcionRol_Datos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Codigo_Rol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Rol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnOpcionRol_Guardar = New System.Windows.Forms.ToolStripButton
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOpcionRol_Buscar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnOpcionRol_Buscar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnOpcionRol_Nuevo = New System.Windows.Forms.ToolStripButton
        Me.btnOpcionRol_Cancelar = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.tvwOpcionRol_Acceso = New System.Windows.Forms.TreeView
        Me.CboOpcionRol_Usuario = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnOpcionRol_Eliminar = New System.Windows.Forms.ToolStripButton
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.ImageFormularios = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrilla.SuspendLayout()
        CType(Me.gwdOpcionRol_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.gwdOpcionRol_Datos)
        Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 68)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(592, 158)
        Me.PanelGrilla.TabIndex = 1
        '
        'gwdOpcionRol_Datos
        '
        Me.gwdOpcionRol_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gwdOpcionRol_Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.gwdOpcionRol_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gwdOpcionRol_Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo_Rol, Me.Nombre_Rol})
        Me.gwdOpcionRol_Datos.Location = New System.Drawing.Point(8, 8)
        Me.gwdOpcionRol_Datos.Name = "gwdOpcionRol_Datos"
        Me.gwdOpcionRol_Datos.ReadOnly = True
        Me.gwdOpcionRol_Datos.Size = New System.Drawing.Size(572, 147)
        Me.gwdOpcionRol_Datos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdOpcionRol_Datos.TabIndex = 100
        '
        'Codigo_Rol
        '
        Me.Codigo_Rol.DataPropertyName = "NCOROL"
        Me.Codigo_Rol.HeaderText = "Codigo Rol"
        Me.Codigo_Rol.Name = "Codigo_Rol"
        Me.Codigo_Rol.ReadOnly = True
        '
        'Nombre_Rol
        '
        Me.Nombre_Rol.DataPropertyName = "TOBS"
        Me.Nombre_Rol.HeaderText = "Nombre Rol"
        Me.Nombre_Rol.Name = "Nombre_Rol"
        Me.Nombre_Rol.ReadOnly = True
        Me.Nombre_Rol.Width = 250
        '
        'btnOpcionRol_Guardar
        '
        Me.btnOpcionRol_Guardar.Image = Global.SOLMIN_SA.Menu.My.Resources.Resources.db_add
        Me.btnOpcionRol_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpcionRol_Guardar.Name = "btnOpcionRol_Guardar"
        Me.btnOpcionRol_Guardar.Size = New System.Drawing.Size(65, 22)
        Me.btnOpcionRol_Guardar.Text = "Guardar"
        '
        'PanelFiltros
        '
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisibleSecondary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtOpcionRol_Buscar)
        Me.PanelFiltros.Panel.Controls.Add(Me.btnOpcionRol_Buscar)
        Me.PanelFiltros.Size = New System.Drawing.Size(592, 68)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.Text = "Filtros de Consulta"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "Filtros de Consulta"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = "Description"
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(4, 12)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(27, 16)
        Me.KryptonLabel5.TabIndex = 36
        Me.KryptonLabel5.Text = "Rol"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Rol"
        '
        'txtOpcionRol_Buscar
        '
        Me.txtOpcionRol_Buscar.Location = New System.Drawing.Point(40, 8)
        Me.txtOpcionRol_Buscar.MaxLength = 30
        Me.txtOpcionRol_Buscar.Name = "txtOpcionRol_Buscar"
        Me.txtOpcionRol_Buscar.Size = New System.Drawing.Size(323, 19)
        Me.txtOpcionRol_Buscar.TabIndex = 60
        '
        'btnOpcionRol_Buscar
        '
        Me.btnOpcionRol_Buscar.Location = New System.Drawing.Point(368, 4)
        Me.btnOpcionRol_Buscar.Name = "btnOpcionRol_Buscar"
        Me.btnOpcionRol_Buscar.Size = New System.Drawing.Size(65, 29)
        Me.btnOpcionRol_Buscar.TabIndex = 70
        Me.btnOpcionRol_Buscar.Text = "Buscar"
        Me.btnOpcionRol_Buscar.Values.ExtraText = ""
        Me.btnOpcionRol_Buscar.Values.Image = Nothing
        Me.btnOpcionRol_Buscar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnOpcionRol_Buscar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnOpcionRol_Buscar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnOpcionRol_Buscar.Values.Text = "Buscar"
        '
        'btnOpcionRol_Nuevo
        '
        Me.btnOpcionRol_Nuevo.Image = Global.SOLMIN_SA.Menu.My.Resources.Resources.db
        Me.btnOpcionRol_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpcionRol_Nuevo.Name = "btnOpcionRol_Nuevo"
        Me.btnOpcionRol_Nuevo.Size = New System.Drawing.Size(59, 22)
        Me.btnOpcionRol_Nuevo.Text = "Nuevo"
        '
        'btnOpcionRol_Cancelar
        '
        Me.btnOpcionRol_Cancelar.Image = Global.SOLMIN_SA.Menu.My.Resources.Resources.button_cancel
        Me.btnOpcionRol_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpcionRol_Cancelar.Name = "btnOpcionRol_Cancelar"
        Me.btnOpcionRol_Cancelar.Size = New System.Drawing.Size(69, 22)
        Me.btnOpcionRol_Cancelar.Text = "Cancelar"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(592, 466)
        Me.SplitContainer1.SplitterDistance = 226
        Me.SplitContainer1.TabIndex = 3
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
        Me.HeaderDatos.Panel.Controls.Add(Me.tvwOpcionRol_Acceso)
        Me.HeaderDatos.Panel.Controls.Add(Me.CboOpcionRol_Usuario)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel3)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(592, 236)
        Me.HeaderDatos.TabIndex = 0
        Me.HeaderDatos.Text = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'tvwOpcionRol_Acceso
        '
        Me.tvwOpcionRol_Acceso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvwOpcionRol_Acceso.CheckBoxes = True
        Me.tvwOpcionRol_Acceso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwOpcionRol_Acceso.Location = New System.Drawing.Point(8, 56)
        Me.tvwOpcionRol_Acceso.Name = "tvwOpcionRol_Acceso"
        Me.tvwOpcionRol_Acceso.Size = New System.Drawing.Size(571, 148)
        Me.tvwOpcionRol_Acceso.TabIndex = 81
        '
        'CboOpcionRol_Usuario
        '
        Me.CboOpcionRol_Usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CboOpcionRol_Usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboOpcionRol_Usuario.DropDownWidth = 217
        Me.CboOpcionRol_Usuario.Enabled = False
        Me.CboOpcionRol_Usuario.FormattingEnabled = False
        Me.CboOpcionRol_Usuario.ItemHeight = 13
        Me.CboOpcionRol_Usuario.Location = New System.Drawing.Point(32, 32)
        Me.CboOpcionRol_Usuario.MaxLength = 30
        Me.CboOpcionRol_Usuario.Name = "CboOpcionRol_Usuario"
        Me.CboOpcionRol_Usuario.Size = New System.Drawing.Size(180, 21)
        Me.CboOpcionRol_Usuario.TabIndex = 40
        Me.CboOpcionRol_Usuario.Tag = "HOLA"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(4, 36)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(27, 16)
        Me.KryptonLabel3.TabIndex = 36
        Me.KryptonLabel3.Text = "Rol"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Rol"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpcionRol_Nuevo, Me.ToolStripSeparator1, Me.btnOpcionRol_Guardar, Me.ToolStripSeparator2, Me.btnOpcionRol_Cancelar, Me.ToolStripSeparator3, Me.btnOpcionRol_Eliminar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(590, 25)
        Me.MenuBar.TabIndex = 80
        Me.MenuBar.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnOpcionRol_Eliminar
        '
        Me.btnOpcionRol_Eliminar.Image = Global.SOLMIN_SA.Menu.My.Resources.Resources.db_remove
        Me.btnOpcionRol_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpcionRol_Eliminar.Name = "btnOpcionRol_Eliminar"
        Me.btnOpcionRol_Eliminar.Size = New System.Drawing.Size(63, 22)
        Me.btnOpcionRol_Eliminar.Text = "Eliminar"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.SplitContainer1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(592, 466)
        Me.KryptonPanel.TabIndex = 2
        '
        'ImageFormularios
        '
        Me.ImageFormularios.ImageStream = CType(resources.GetObject("ImageFormularios.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageFormularios.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageFormularios.Images.SetKeyName(0, "Modulo.jpg")
        Me.ImageFormularios.Images.SetKeyName(1, "SubModulo.jpg")
        Me.ImageFormularios.Images.SetKeyName(2, "Formulario.jpg")
        '
        'FrmOpcionRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 466)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmOpcionRol"
        Me.Text = "Opciones por Rol"
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrilla.ResumeLayout(False)
        CType(Me.gwdOpcionRol_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents PanelGrilla As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents gwdOpcionRol_Datos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnOpcionRol_Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOpcionRol_Buscar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnOpcionRol_Buscar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnOpcionRol_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOpcionRol_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnOpcionRol_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents CboOpcionRol_Usuario As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents tvwOpcionRol_Acceso As System.Windows.Forms.TreeView
    Friend WithEvents ImageFormularios As System.Windows.Forms.ImageList
    Friend WithEvents Codigo_Rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Rol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
