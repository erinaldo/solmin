<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpcionUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpcionUsuario))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Codigo_Aplica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Aplica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codigo_Menu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Menu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codigo_Formulario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Formulario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Clase_VB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codigo_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtBuscar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnConsulta = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.treeViewSesion = New System.Windows.Forms.TreeView
        Me.CboUsuario = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.ImageFormularios = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrilla.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelGrilla.Controls.Add(Me.gwdDatos)
        Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 52)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(592, 195)
        Me.PanelGrilla.TabIndex = 1
        '
        'gwdDatos
        '
        Me.gwdDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo_Aplica, Me.Nombre_Aplica, Me.Codigo_Menu, Me.Nombre_Menu, Me.Codigo_Formulario, Me.Nombre_Formulario, Me.Clase_VB, Me.Codigo_Usuario, Me.Nombre_Usuario})
        Me.gwdDatos.Location = New System.Drawing.Point(8, 8)
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.Size = New System.Drawing.Size(572, 184)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 100
        '
        'Codigo_Aplica
        '
        Me.Codigo_Aplica.DataPropertyName = "MMCAPL"
        Me.Codigo_Aplica.HeaderText = "Codigo Aplica"
        Me.Codigo_Aplica.Name = "Codigo_Aplica"
        Me.Codigo_Aplica.ReadOnly = True
        Me.Codigo_Aplica.Visible = False
        Me.Codigo_Aplica.Width = 80
        '
        'Nombre_Aplica
        '
        Me.Nombre_Aplica.DataPropertyName = "MMDAPL"
        Me.Nombre_Aplica.HeaderText = "Nombre Aplicacion"
        Me.Nombre_Aplica.Name = "Nombre_Aplica"
        Me.Nombre_Aplica.ReadOnly = True
        Me.Nombre_Aplica.Visible = False
        Me.Nombre_Aplica.Width = 165
        '
        'Codigo_Menu
        '
        Me.Codigo_Menu.DataPropertyName = "MMCMNU"
        Me.Codigo_Menu.HeaderText = "Codigo Menu"
        Me.Codigo_Menu.Name = "Codigo_Menu"
        Me.Codigo_Menu.ReadOnly = True
        Me.Codigo_Menu.Visible = False
        Me.Codigo_Menu.Width = 80
        '
        'Nombre_Menu
        '
        Me.Nombre_Menu.DataPropertyName = "MMTMNU"
        Me.Nombre_Menu.HeaderText = "Nombre Menu"
        Me.Nombre_Menu.Name = "Nombre_Menu"
        Me.Nombre_Menu.ReadOnly = True
        Me.Nombre_Menu.Visible = False
        Me.Nombre_Menu.Width = 250
        '
        'Codigo_Formulario
        '
        Me.Codigo_Formulario.DataPropertyName = "MMCOPC"
        Me.Codigo_Formulario.HeaderText = "Codigo Opcion"
        Me.Codigo_Formulario.Name = "Codigo_Formulario"
        Me.Codigo_Formulario.ReadOnly = True
        Me.Codigo_Formulario.Visible = False
        Me.Codigo_Formulario.Width = 90
        '
        'Nombre_Formulario
        '
        Me.Nombre_Formulario.DataPropertyName = "MMDOPC"
        Me.Nombre_Formulario.HeaderText = "Nombre Formulario"
        Me.Nombre_Formulario.Name = "Nombre_Formulario"
        Me.Nombre_Formulario.ReadOnly = True
        Me.Nombre_Formulario.Visible = False
        Me.Nombre_Formulario.Width = 180
        '
        'Clase_VB
        '
        Me.Clase_VB.DataPropertyName = "MMNPVB"
        Me.Clase_VB.HeaderText = "Clase VB"
        Me.Clase_VB.Name = "Clase_VB"
        Me.Clase_VB.ReadOnly = True
        Me.Clase_VB.Visible = False
        Me.Clase_VB.Width = 180
        '
        'Codigo_Usuario
        '
        Me.Codigo_Usuario.DataPropertyName = "MMCUSR"
        Me.Codigo_Usuario.HeaderText = "Codigo Usuario"
        Me.Codigo_Usuario.Name = "Codigo_Usuario"
        Me.Codigo_Usuario.ReadOnly = True
        '
        'Nombre_Usuario
        '
        Me.Nombre_Usuario.DataPropertyName = "MMNUSR"
        Me.Nombre_Usuario.HeaderText = "Nombre Usuario"
        Me.Nombre_Usuario.Name = "Nombre_Usuario"
        Me.Nombre_Usuario.ReadOnly = True
        Me.Nombre_Usuario.Width = 250
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.db_add
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(65, 22)
        Me.btnGuardar.Text = "Guardar"
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
        Me.PanelFiltros.Panel.Controls.Add(Me.txtBuscar)
        Me.PanelFiltros.Panel.Controls.Add(Me.btnConsulta)
        Me.PanelFiltros.Size = New System.Drawing.Size(592, 52)
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
        Me.KryptonLabel5.Location = New System.Drawing.Point(8, 12)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(49, 16)
        Me.KryptonLabel5.TabIndex = 36
        Me.KryptonLabel5.Text = "Usuario"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Usuario"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(64, 8)
        Me.txtBuscar.MaxLength = 30
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(307, 19)
        Me.txtBuscar.TabIndex = 60
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(380, 4)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(65, 24)
        Me.btnConsulta.TabIndex = 70
        Me.btnConsulta.Text = "Buscar"
        Me.btnConsulta.Values.ExtraText = ""
        Me.btnConsulta.Values.Image = Nothing
        Me.btnConsulta.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnConsulta.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnConsulta.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnConsulta.Values.Text = "Buscar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.db
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(59, 22)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 22)
        Me.btnCancelar.Text = "Cancelar"
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
        Me.SplitContainer1.SplitterDistance = 247
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
        Me.HeaderDatos.Panel.Controls.Add(Me.treeViewSesion)
        Me.HeaderDatos.Panel.Controls.Add(Me.CboUsuario)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(592, 215)
        Me.HeaderDatos.TabIndex = 0
        Me.HeaderDatos.Text = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'treeViewSesion
        '
        Me.treeViewSesion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.treeViewSesion.CheckBoxes = True
        Me.treeViewSesion.Location = New System.Drawing.Point(8, 32)
        Me.treeViewSesion.Name = "treeViewSesion"
        Me.treeViewSesion.Size = New System.Drawing.Size(575, 156)
        Me.treeViewSesion.TabIndex = 81
        '
        'CboUsuario
        '
        Me.CboUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CboUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboUsuario.DropDownWidth = 217
        Me.CboUsuario.Enabled = False
        Me.CboUsuario.FormattingEnabled = False
        Me.CboUsuario.ItemHeight = 13
        Me.CboUsuario.Location = New System.Drawing.Point(544, 32)
        Me.CboUsuario.MaxLength = 30
        Me.CboUsuario.Name = "CboUsuario"
        Me.CboUsuario.Size = New System.Drawing.Size(40, 21)
        Me.CboUsuario.TabIndex = 40
        Me.CboUsuario.Tag = "HOLA"
        Me.CboUsuario.Visible = False
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(590, 25)
        Me.MenuBar.TabIndex = 80
        Me.MenuBar.Text = "ToolStrip1"
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
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(63, 22)
        Me.btnEliminar.Text = "Eliminar"
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
        'FrmOpcionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 466)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmOpcionUsuario"
        Me.Text = "Opciones por Usuario"
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrilla.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtBuscar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnConsulta As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents CboUsuario As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents treeViewSesion As System.Windows.Forms.TreeView
    Friend WithEvents ImageFormularios As System.Windows.Forms.ImageList
    Friend WithEvents Codigo_Aplica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Aplica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo_Menu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Menu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo_Formulario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Formulario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clase_VB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo_Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
