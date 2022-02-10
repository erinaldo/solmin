<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoLicenciaConducir
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
        Me.NCLICO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCATLI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCATLI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtClaseTipoCategoria = New SOLMIN_ST.TextField
        Me.txtCategoriaLicenciaConducir = New SOLMIN_ST.TextField
        Me.txtCodigoTipoLicencia = New SOLMIN_ST.TextField
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtFiltroLicenciaConducir = New SOLMIN_ST.TextField
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
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
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCLICO, Me.CCATLI, Me.TCATLI})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 68)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(892, 355)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 5
        '
        'NCLICO
        '
        Me.NCLICO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCLICO.DataPropertyName = "NCLICO"
        Me.NCLICO.HeaderText = "Código"
        Me.NCLICO.Name = "NCLICO"
        Me.NCLICO.ReadOnly = True
        Me.NCLICO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NCLICO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NCLICO.Width = 50
        '
        'CCATLI
        '
        Me.CCATLI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCATLI.DataPropertyName = "CCATLI"
        Me.CCATLI.HeaderText = "Categoría"
        Me.CCATLI.Name = "CCATLI"
        Me.CCATLI.ReadOnly = True
        Me.CCATLI.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CCATLI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CCATLI.Width = 64
        '
        'TCATLI
        '
        Me.TCATLI.DataPropertyName = "TCATLI"
        Me.TCATLI.HeaderText = "Tipo Categoría"
        Me.TCATLI.Name = "TCATLI"
        Me.TCATLI.ReadOnly = True
        Me.TCATLI.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TCATLI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'HeaderDatos
        '
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 423)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel14)
        Me.HeaderDatos.Panel.Controls.Add(Me.txtClaseTipoCategoria)
        Me.HeaderDatos.Panel.Controls.Add(Me.txtCategoriaLicenciaConducir)
        Me.HeaderDatos.Panel.Controls.Add(Me.txtCodigoTipoLicencia)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel3)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(892, 297)
        Me.HeaderDatos.TabIndex = 4
        Me.HeaderDatos.Text = " "
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = " "
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(12, 42)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(129, 18)
        Me.KryptonLabel14.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel14.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel14.TabIndex = 53
        Me.KryptonLabel14.Text = "Información General "
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Información General "
        '
        'txtClaseTipoCategoria
        '
        Me.txtClaseTipoCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClaseTipoCategoria.Location = New System.Drawing.Point(100, 117)
        Me.txtClaseTipoCategoria.MaxLength = 50
        Me.txtClaseTipoCategoria.Name = "txtClaseTipoCategoria"
        Me.txtClaseTipoCategoria.Size = New System.Drawing.Size(180, 19)
        Me.txtClaseTipoCategoria.TabIndex = 52
        Me.txtClaseTipoCategoria.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtCategoriaLicenciaConducir
        '
        Me.txtCategoriaLicenciaConducir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategoriaLicenciaConducir.Location = New System.Drawing.Point(100, 93)
        Me.txtCategoriaLicenciaConducir.MaxLength = 50
        Me.txtCategoriaLicenciaConducir.Name = "txtCategoriaLicenciaConducir"
        Me.txtCategoriaLicenciaConducir.Size = New System.Drawing.Size(180, 19)
        Me.txtCategoriaLicenciaConducir.TabIndex = 51
        Me.txtCategoriaLicenciaConducir.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtCodigoTipoLicencia
        '
        Me.txtCodigoTipoLicencia.Location = New System.Drawing.Point(100, 69)
        Me.txtCodigoTipoLicencia.Name = "txtCodigoTipoLicencia"
        Me.txtCodigoTipoLicencia.ReadOnly = True
        Me.txtCodigoTipoLicencia.Size = New System.Drawing.Size(180, 19)
        Me.txtCodigoTipoLicencia.TabIndex = 50
        Me.txtCodigoTipoLicencia.Text = "0"
        Me.txtCodigoTipoLicencia.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        Me.txtCodigoTipoLicencia.Visible = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(16, 118)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(84, 16)
        Me.KryptonLabel3.TabIndex = 48
        Me.KryptonLabel3.Text = "Tipo Categoría"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo Categoría"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(15, 94)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(59, 16)
        Me.KryptonLabel2.TabIndex = 47
        Me.KryptonLabel2.Text = "Categoría"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Categoría"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(16, 70)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(46, 16)
        Me.KryptonLabel1.TabIndex = 46
        Me.KryptonLabel1.Text = "Código"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Código"
        Me.KryptonLabel1.Visible = False
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
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnBuscar})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisibleSecondary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.txtFiltroLicenciaConducir)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Size = New System.Drawing.Size(892, 68)
        Me.PanelFiltros.TabIndex = 2
        Me.PanelFiltros.Text = "TIPOS DE LICENCIA DE CONDUCIR"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "TIPOS DE LICENCIA DE CONDUCIR"
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
        Me.btnBuscar.UniqueName = "7DBCAD7B527244827DBCAD7B52724482"
        '
        'txtFiltroLicenciaConducir
        '
        Me.txtFiltroLicenciaConducir.Location = New System.Drawing.Point(132, 12)
        Me.txtFiltroLicenciaConducir.MaxLength = 50
        Me.txtFiltroLicenciaConducir.Name = "txtFiltroLicenciaConducir"
        Me.txtFiltroLicenciaConducir.Size = New System.Drawing.Size(324, 19)
        Me.txtFiltroLicenciaConducir.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFiltroLicenciaConducir.TabIndex = 60
        Me.txtFiltroLicenciaConducir.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(10, 12)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(116, 16)
        Me.KryptonLabel5.TabIndex = 59
        Me.KryptonLabel5.Text = "Licencia de Conducir"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Licencia de Conducir"
        '
        'frmTipoLicenciaConducir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 720)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmTipoLicenciaConducir"
        Me.Text = "Tipo de Licencia de Conducir"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
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
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtClaseTipoCategoria As SOLMIN_ST.TextField
    Friend WithEvents txtCategoriaLicenciaConducir As SOLMIN_ST.TextField
    Friend WithEvents txtCodigoTipoLicencia As SOLMIN_ST.TextField
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFiltroLicenciaConducir As SOLMIN_ST.TextField
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NCLICO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCATLI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCATLI As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
