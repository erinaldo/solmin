<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAplicacion
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
        Me.gwdAplicacion_Datos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Codigo_Aplica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Aplica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtAplicacion_Buscar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnAplicacion_Buscar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtAplicacion_Codigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtAplicacion_Nombre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnAplicacion_Nuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAplicacion_Guardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAplicacion_Cancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAplicacion_Eliminar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrilla.SuspendLayout()
        CType(Me.gwdAplicacion_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonPanel.Size = New System.Drawing.Size(600, 500)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(600, 500)
        Me.SplitContainer1.SplitterDistance = 357
        Me.SplitContainer1.TabIndex = 3
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.gwdAplicacion_Datos)
        Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 68)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(600, 289)
        Me.PanelGrilla.TabIndex = 1
        '
        'gwdAplicacion_Datos
        '
        Me.gwdAplicacion_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gwdAplicacion_Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.gwdAplicacion_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gwdAplicacion_Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo_Aplica, Me.Nombre_Aplica})
        Me.gwdAplicacion_Datos.Location = New System.Drawing.Point(8, 8)
        Me.gwdAplicacion_Datos.Name = "gwdAplicacion_Datos"
        Me.gwdAplicacion_Datos.ReadOnly = True
        Me.gwdAplicacion_Datos.Size = New System.Drawing.Size(580, 278)
        Me.gwdAplicacion_Datos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdAplicacion_Datos.TabIndex = 0
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
        Me.Nombre_Aplica.Width = 250
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
        Me.PanelFiltros.Panel.Controls.Add(Me.txtAplicacion_Buscar)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.PanelFiltros.Panel.Controls.Add(Me.btnAplicacion_Buscar)
        Me.PanelFiltros.Size = New System.Drawing.Size(600, 68)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.Text = "Filtros de Consulta"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "Filtros de Consulta"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = "Description"
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'txtAplicacion_Buscar
        '
        Me.txtAplicacion_Buscar.Location = New System.Drawing.Point(167, 13)
        Me.txtAplicacion_Buscar.MaxLength = 30
        Me.txtAplicacion_Buscar.Name = "txtAplicacion_Buscar"
        Me.txtAplicacion_Buscar.Size = New System.Drawing.Size(214, 19)
        Me.txtAplicacion_Buscar.TabIndex = 30
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(15, 14)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(146, 16)
        Me.KryptonLabel6.TabIndex = 2
        Me.KryptonLabel6.Text = "Ingrese Nombre Aplicacion"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Ingrese Nombre Aplicacion"
        '
        'btnAplicacion_Buscar
        '
        Me.btnAplicacion_Buscar.Location = New System.Drawing.Point(394, 9)
        Me.btnAplicacion_Buscar.Name = "btnAplicacion_Buscar"
        Me.btnAplicacion_Buscar.Size = New System.Drawing.Size(65, 29)
        Me.btnAplicacion_Buscar.TabIndex = 40
        Me.btnAplicacion_Buscar.Text = "Buscar"
        Me.btnAplicacion_Buscar.Values.ExtraText = ""
        Me.btnAplicacion_Buscar.Values.Image = Nothing
        Me.btnAplicacion_Buscar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAplicacion_Buscar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAplicacion_Buscar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAplicacion_Buscar.Values.Text = "Buscar"
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
        Me.HeaderDatos.Panel.Controls.Add(Me.txtAplicacion_Codigo)
        Me.HeaderDatos.Panel.Controls.Add(Me.txtAplicacion_Nombre)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(600, 139)
        Me.HeaderDatos.TabIndex = 0
        Me.HeaderDatos.Text = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'txtAplicacion_Codigo
        '
        Me.txtAplicacion_Codigo.Location = New System.Drawing.Point(136, 41)
        Me.txtAplicacion_Codigo.MaxLength = 2
        Me.txtAplicacion_Codigo.Name = "txtAplicacion_Codigo"
        Me.txtAplicacion_Codigo.Size = New System.Drawing.Size(100, 19)
        Me.txtAplicacion_Codigo.TabIndex = 10
        '
        'txtAplicacion_Nombre
        '
        Me.txtAplicacion_Nombre.Location = New System.Drawing.Point(136, 71)
        Me.txtAplicacion_Nombre.MaxLength = 25
        Me.txtAplicacion_Nombre.Name = "txtAplicacion_Nombre"
        Me.txtAplicacion_Nombre.Size = New System.Drawing.Size(218, 19)
        Me.txtAplicacion_Nombre.TabIndex = 20
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(8, 72)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(121, 16)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Nombre de Aplicacion"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nombre de Aplicacion"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 45)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(117, 16)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Codigo de Aplicacion"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Codigo de Aplicacion"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAplicacion_Nuevo, Me.ToolStripSeparator1, Me.btnAplicacion_Guardar, Me.ToolStripSeparator2, Me.btnAplicacion_Cancelar, Me.ToolStripSeparator3, Me.btnAplicacion_Eliminar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(598, 25)
        Me.MenuBar.TabIndex = 50
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnAplicacion_Nuevo
        '
        Me.btnAplicacion_Nuevo.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.db
        Me.btnAplicacion_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAplicacion_Nuevo.Name = "btnAplicacion_Nuevo"
        Me.btnAplicacion_Nuevo.Size = New System.Drawing.Size(59, 22)
        Me.btnAplicacion_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAplicacion_Guardar
        '
        Me.btnAplicacion_Guardar.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.db_add
        Me.btnAplicacion_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAplicacion_Guardar.Name = "btnAplicacion_Guardar"
        Me.btnAplicacion_Guardar.Size = New System.Drawing.Size(65, 22)
        Me.btnAplicacion_Guardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnAplicacion_Cancelar
        '
        Me.btnAplicacion_Cancelar.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.button_cancel
        Me.btnAplicacion_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAplicacion_Cancelar.Name = "btnAplicacion_Cancelar"
        Me.btnAplicacion_Cancelar.Size = New System.Drawing.Size(69, 22)
        Me.btnAplicacion_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnAplicacion_Eliminar
        '
        Me.btnAplicacion_Eliminar.Image = Global.SOLMIN.MENUBAR.My.Resources.Resources.db_remove
        Me.btnAplicacion_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAplicacion_Eliminar.Name = "btnAplicacion_Eliminar"
        Me.btnAplicacion_Eliminar.Size = New System.Drawing.Size(63, 22)
        Me.btnAplicacion_Eliminar.Text = "Eliminar"
        '
        'FrmAplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAplicacion"
        Me.Text = "Aplicaciones"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrilla.ResumeLayout(False)
        CType(Me.gwdAplicacion_Datos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gwdAplicacion_Datos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnAplicacion_Buscar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAplicacion_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAplicacion_Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAplicacion_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAplicacion_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtAplicacion_Buscar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAplicacion_Nombre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAplicacion_Codigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Codigo_Aplica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Aplica As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
