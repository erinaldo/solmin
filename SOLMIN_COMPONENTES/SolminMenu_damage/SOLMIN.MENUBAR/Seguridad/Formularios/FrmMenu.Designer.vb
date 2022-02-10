<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.Codigo_Aplica = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Nombre_Aplica = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Codigo_Menu = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Nombre_Menu = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.txtBuscar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.btnConsulta = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.CboAplica = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.txtDescripOpcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnNuevo = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEliminar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelGrilla.SuspendLayout()
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PanelFiltros.Panel.SuspendLayout()
    Me.PanelFiltros.SuspendLayout()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderDatos.Panel.SuspendLayout()
    Me.HeaderDatos.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.SplitContainer1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(592, 466)
    Me.KryptonPanel.TabIndex = 0
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
    Me.SplitContainer1.SplitterDistance = 333
    Me.SplitContainer1.TabIndex = 3
    '
    'PanelGrilla
    '
    Me.PanelGrilla.Controls.Add(Me.gwdDatos)
    Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelGrilla.Location = New System.Drawing.Point(0, 68)
    Me.PanelGrilla.Name = "PanelGrilla"
    Me.PanelGrilla.Size = New System.Drawing.Size(592, 265)
    Me.PanelGrilla.TabIndex = 1
    '
    'gwdDatos
    '
    Me.gwdDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
    Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo_Aplica, Me.Nombre_Aplica, Me.Codigo_Menu, Me.Nombre_Menu})
    Me.gwdDatos.Location = New System.Drawing.Point(8, 8)
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.ReadOnly = True
    Me.gwdDatos.Size = New System.Drawing.Size(572, 254)
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 0
    '
    'Codigo_Aplica
    '
    Me.Codigo_Aplica.DataPropertyName = "MMCAPL"
    Me.Codigo_Aplica.HeaderText = "Codigo Aplica"
    Me.Codigo_Aplica.Name = "Codigo_Aplica"
    Me.Codigo_Aplica.ReadOnly = True
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
    Me.Codigo_Menu.Width = 80
    '
    'Nombre_Menu
    '
    Me.Nombre_Menu.DataPropertyName = "MMTMNU"
    Me.Nombre_Menu.HeaderText = "Nombre Menu"
    Me.Nombre_Menu.Name = "Nombre_Menu"
    Me.Nombre_Menu.ReadOnly = True
    Me.Nombre_Menu.Width = 250
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
    Me.PanelFiltros.Panel.Controls.Add(Me.txtBuscar)
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel6)
    Me.PanelFiltros.Panel.Controls.Add(Me.btnConsulta)
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
    'txtBuscar
    '
    Me.txtBuscar.Location = New System.Drawing.Point(167, 13)
    Me.txtBuscar.MaxLength = 30
    Me.txtBuscar.Name = "txtBuscar"
    Me.txtBuscar.Size = New System.Drawing.Size(214, 19)
    Me.txtBuscar.TabIndex = 30
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(8, 14)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(157, 16)
    Me.KryptonLabel6.TabIndex = 2
    Me.KryptonLabel6.Text = "Ingrese Codigo de Aplicacion"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Ingrese Codigo de Aplicacion"
    '
    'btnConsulta
    '
    Me.btnConsulta.Location = New System.Drawing.Point(394, 9)
    Me.btnConsulta.Name = "btnConsulta"
    Me.btnConsulta.Size = New System.Drawing.Size(65, 29)
    Me.btnConsulta.TabIndex = 40
    Me.btnConsulta.Text = "Buscar"
    Me.btnConsulta.Values.ExtraText = ""
    Me.btnConsulta.Values.Image = Nothing
    Me.btnConsulta.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnConsulta.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnConsulta.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnConsulta.Values.Text = "Buscar"
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
    Me.HeaderDatos.Panel.Controls.Add(Me.CboAplica)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtDescripOpcion)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel2)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel1)
    Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
    Me.HeaderDatos.Size = New System.Drawing.Size(592, 129)
    Me.HeaderDatos.TabIndex = 0
    Me.HeaderDatos.Text = "Información de Mantenimiento"
    Me.HeaderDatos.ValuesPrimary.Description = ""
    Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
    Me.HeaderDatos.ValuesPrimary.Image = Nothing
    Me.HeaderDatos.ValuesSecondary.Description = ""
    Me.HeaderDatos.ValuesSecondary.Heading = "Description"
    Me.HeaderDatos.ValuesSecondary.Image = Nothing
    '
    'CboAplica
    '
    Me.CboAplica.DropDownWidth = 217
    Me.CboAplica.FormattingEnabled = False
    Me.CboAplica.ItemHeight = 13
    Me.CboAplica.Location = New System.Drawing.Point(136, 32)
    Me.CboAplica.Name = "CboAplica"
    Me.CboAplica.Size = New System.Drawing.Size(165, 21)
    Me.CboAplica.TabIndex = 10
    Me.CboAplica.Tag = "HOLA"
    '
    'txtDescripOpcion
    '
    Me.txtDescripOpcion.Location = New System.Drawing.Point(136, 60)
    Me.txtDescripOpcion.MaxLength = 25
    Me.txtDescripOpcion.Name = "txtDescripOpcion"
    Me.txtDescripOpcion.Size = New System.Drawing.Size(218, 19)
    Me.txtDescripOpcion.TabIndex = 20
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(30, 61)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(100, 16)
    Me.KryptonLabel2.TabIndex = 3
    Me.KryptonLabel2.Text = "Nombre del Menu"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Nombre del Menu"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(8, 34)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(121, 16)
    Me.KryptonLabel1.TabIndex = 1
    Me.KryptonLabel1.Text = "Nombre de Aplicacion"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Nombre de Aplicacion"
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(590, 25)
    Me.MenuBar.TabIndex = 50
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnNuevo
    '
    Me.btnNuevo.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.db
    Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(59, 22)
    Me.btnNuevo.Text = "Nuevo"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnGuardar
    '
    Me.btnGuardar.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.db_add
    Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(65, 22)
    Me.btnGuardar.Text = "Guardar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'btnCancelar
    '
    Me.btnCancelar.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(69, 22)
    Me.btnCancelar.Text = "Cancelar"
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
    'FrmMenu
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(592, 466)
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "FrmMenu"
    Me.Text = "Menu de Sistemas"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.ResumeLayout(False)
    CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelGrilla.ResumeLayout(False)
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.Panel.ResumeLayout(False)
    Me.PanelFiltros.Panel.PerformLayout()
    CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PanelFiltros.ResumeLayout(False)
    CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderDatos.Panel.ResumeLayout(False)
    Me.HeaderDatos.Panel.PerformLayout()
    CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderDatos.ResumeLayout(False)
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelGrilla As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnConsulta As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtBuscar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripOpcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents CboAplica As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents Codigo_Aplica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Aplica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo_Menu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Menu As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
