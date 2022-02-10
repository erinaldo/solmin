<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMercaderiaTransportes
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
    Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtBuscar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.txtCodigoGrupoMerc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtDescripAbrevMerc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtDescripCompMerc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnNuevo = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEliminar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.Codigo_Mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Desc_Completa_Mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Abreviatura_Mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Cod_0Grupo_Mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn
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
    Me.KryptonPanel.Size = New System.Drawing.Size(742, 524)
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
    Me.SplitContainer1.Size = New System.Drawing.Size(742, 524)
    Me.SplitContainer1.SplitterDistance = 373
    Me.SplitContainer1.TabIndex = 2
    '
    'PanelGrilla
    '
    Me.PanelGrilla.Controls.Add(Me.gwdDatos)
    Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelGrilla.Location = New System.Drawing.Point(0, 65)
    Me.PanelGrilla.Name = "PanelGrilla"
    Me.PanelGrilla.Size = New System.Drawing.Size(742, 308)
    Me.PanelGrilla.TabIndex = 1
    '
    'gwdDatos
    '
    Me.gwdDatos.AllowUserToAddRows = False
    Me.gwdDatos.AllowUserToOrderColumns = True
    Me.gwdDatos.ColumnHeadersHeight = 30
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo_Mercaderia, Me.Desc_Completa_Mercaderia, Me.Abreviatura_Mercaderia, Me.Cod_0Grupo_Mercaderia})
    Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.ReadOnly = True
    Me.gwdDatos.RowHeadersWidth = 20
    Me.gwdDatos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.0!)
    Me.gwdDatos.RowTemplate.Height = 20
    Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatos.Size = New System.Drawing.Size(742, 308)
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 0
    '
    'PanelFiltros
    '
    Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnBuscar})
    Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
    Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.PanelFiltros.HeaderVisibleSecondary = False
    Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
    Me.PanelFiltros.Name = "PanelFiltros"
    '
    'PanelFiltros.Panel
    '
    Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
    Me.PanelFiltros.Panel.Controls.Add(Me.txtBuscar)
    Me.PanelFiltros.Size = New System.Drawing.Size(742, 65)
    Me.PanelFiltros.TabIndex = 0
    Me.PanelFiltros.Text = "MERCADERIAS"
    Me.PanelFiltros.ValuesPrimary.Description = ""
    Me.PanelFiltros.ValuesPrimary.Heading = "MERCADERIAS"
    Me.PanelFiltros.ValuesPrimary.Image = Nothing
    Me.PanelFiltros.ValuesSecondary.Description = ""
    Me.PanelFiltros.ValuesSecondary.Heading = "Description"
    Me.PanelFiltros.ValuesSecondary.Image = Nothing
    '
    'btnBuscar
    '
    Me.btnBuscar.ExtraText = ""
    Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
    Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.ToolTipImage = Nothing
    Me.btnBuscar.UniqueName = "0C6E48225EF8481C0C6E48225EF8481C"
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(4, 12)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(66, 19)
    Me.KryptonLabel7.TabIndex = 4
    Me.KryptonLabel7.Text = "Mercadería"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Mercadería"
    '
    'txtBuscar
    '
    Me.txtBuscar.Location = New System.Drawing.Point(72, 8)
    Me.txtBuscar.Name = "txtBuscar"
    Me.txtBuscar.Size = New System.Drawing.Size(400, 21)
    Me.txtBuscar.TabIndex = 3
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
    Me.HeaderDatos.Panel.Controls.Add(Me.txtCodigoGrupoMerc)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel4)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtDescripAbrevMerc)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel3)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtDescripCompMerc)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel2)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtCodigoMercaderia)
    Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
    Me.HeaderDatos.Size = New System.Drawing.Size(742, 147)
    Me.HeaderDatos.TabIndex = 0
    Me.HeaderDatos.Text = "Información de Mantenimiento"
    Me.HeaderDatos.ValuesPrimary.Description = ""
    Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
    Me.HeaderDatos.ValuesPrimary.Image = Nothing
    Me.HeaderDatos.ValuesSecondary.Description = ""
    Me.HeaderDatos.ValuesSecondary.Heading = "Description"
    Me.HeaderDatos.ValuesSecondary.Image = Nothing
    '
    'txtCodigoGrupoMerc
    '
    Me.txtCodigoGrupoMerc.Location = New System.Drawing.Point(84, 86)
    Me.txtCodigoGrupoMerc.Name = "txtCodigoGrupoMerc"
    Me.txtCodigoGrupoMerc.Size = New System.Drawing.Size(202, 21)
    Me.txtCodigoGrupoMerc.TabIndex = 8
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(12, 88)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(42, 19)
    Me.KryptonLabel4.TabIndex = 7
    Me.KryptonLabel4.Text = "Grupo"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Grupo"
    '
    'txtDescripAbrevMerc
    '
    Me.txtDescripAbrevMerc.Location = New System.Drawing.Point(84, 61)
    Me.txtDescripAbrevMerc.Name = "txtDescripAbrevMerc"
    Me.txtDescripAbrevMerc.Size = New System.Drawing.Size(202, 21)
    Me.txtDescripAbrevMerc.TabIndex = 6
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(8, 64)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel3.TabIndex = 5
    Me.KryptonLabel3.Text = "Abreviatura"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Abreviatura"
    '
    'txtDescripCompMerc
    '
    Me.txtDescripCompMerc.Location = New System.Drawing.Point(84, 36)
    Me.txtDescripCompMerc.Name = "txtDescripCompMerc"
    Me.txtDescripCompMerc.Size = New System.Drawing.Size(202, 21)
    Me.txtDescripCompMerc.TabIndex = 4
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(8, 40)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel2.TabIndex = 3
    Me.KryptonLabel2.Text = "Descripción"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Descripción"
    '
    'txtCodigoMercaderia
    '
    Me.txtCodigoMercaderia.Location = New System.Drawing.Point(28, 160)
    Me.txtCodigoMercaderia.Name = "txtCodigoMercaderia"
    Me.txtCodigoMercaderia.Size = New System.Drawing.Size(104, 21)
    Me.txtCodigoMercaderia.TabIndex = 2
    Me.txtCodigoMercaderia.Text = "KryptonTextBox1"
    Me.txtCodigoMercaderia.Visible = False
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(740, 25)
    Me.MenuBar.TabIndex = 0
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
    'Codigo_Mercaderia
    '
    Me.Codigo_Mercaderia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.Codigo_Mercaderia.DataPropertyName = "CMRCDR"
    Me.Codigo_Mercaderia.HeaderText = "Codigo Mercaderia"
    Me.Codigo_Mercaderia.Name = "Codigo_Mercaderia"
    Me.Codigo_Mercaderia.ReadOnly = True
    Me.Codigo_Mercaderia.Width = 134
    '
    'Desc_Completa_Mercaderia
    '
    Me.Desc_Completa_Mercaderia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.Desc_Completa_Mercaderia.DataPropertyName = "TCMRCD"
    Me.Desc_Completa_Mercaderia.HeaderText = "Desc Completa Mercaderia"
    Me.Desc_Completa_Mercaderia.Name = "Desc_Completa_Mercaderia"
    Me.Desc_Completa_Mercaderia.ReadOnly = True
    '
    'Abreviatura_Mercaderia
    '
    Me.Abreviatura_Mercaderia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.Abreviatura_Mercaderia.DataPropertyName = "TAMRCD"
    Me.Abreviatura_Mercaderia.HeaderText = "Abrv"
    Me.Abreviatura_Mercaderia.Name = "Abreviatura_Mercaderia"
    Me.Abreviatura_Mercaderia.ReadOnly = True
    Me.Abreviatura_Mercaderia.Width = 59
    '
    'Cod_0Grupo_Mercaderia
    '
    Me.Cod_0Grupo_Mercaderia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.Cod_0Grupo_Mercaderia.DataPropertyName = "CGRMRC"
    Me.Cod_0Grupo_Mercaderia.HeaderText = "Cod Grupo Mercaderia"
    Me.Cod_0Grupo_Mercaderia.Name = "Cod_0Grupo_Mercaderia"
    Me.Cod_0Grupo_Mercaderia.ReadOnly = True
    Me.Cod_0Grupo_Mercaderia.Width = 153
    '
    'frmMercaderiaTransportes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(742, 524)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmMercaderiaTransportes"
    Me.Text = "frmMercaderiaTransportes"
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
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtBuscar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtCodigoGrupoMerc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripAbrevMerc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripCompMerc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
  Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents Codigo_Mercaderia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Desc_Completa_Mercaderia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Abreviatura_Mercaderia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Cod_0Grupo_Mercaderia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
