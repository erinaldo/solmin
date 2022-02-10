<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoCapacitacionConductor
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigoCapacitacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNombreCapacitacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Codigo_Capacitacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Capacitacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtBuscar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(892, 720)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(58, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(890, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "ToolStrip1"
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
        Me.btnGuardar.Size = New System.Drawing.Size(66, 22)
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
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(63, 22)
        Me.btnEliminar.Text = "Eliminar"
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
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel14)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel20)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel21)
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel22)
        Me.HeaderDatos.Panel.Controls.Add(Me.txtCodigoCapacitacion)
        Me.HeaderDatos.Panel.Controls.Add(Me.txtNombreCapacitacion)
        Me.HeaderDatos.Panel.Controls.Add(Me.txtObservaciones)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(892, 303)
        Me.HeaderDatos.TabIndex = 0
        Me.HeaderDatos.Text = "Información de capacitación del conductor"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de capacitación del conductor"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(8, 36)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(129, 18)
        Me.KryptonLabel14.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel14.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel14.TabIndex = 40
        Me.KryptonLabel14.Text = "Información General "
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Información General "
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(8, 108)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(86, 16)
        Me.KryptonLabel20.TabIndex = 23
        Me.KryptonLabel20.Text = "Observaciones"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Observaciones"
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(8, 84)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(175, 16)
        Me.KryptonLabel21.TabIndex = 22
        Me.KryptonLabel21.Text = "Nombre de Tipo de Capacitación"
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "Nombre de Tipo de Capacitación"
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(8, 64)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(130, 16)
        Me.KryptonLabel22.TabIndex = 21
        Me.KryptonLabel22.Text = "Codigo de Capacitación"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Codigo de Capacitación"
        Me.KryptonLabel22.Visible = False
        '
        'txtCodigoCapacitacion
        '
        Me.txtCodigoCapacitacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCapacitacion.Location = New System.Drawing.Point(184, 56)
        Me.txtCodigoCapacitacion.Name = "txtCodigoCapacitacion"
        Me.txtCodigoCapacitacion.Size = New System.Drawing.Size(219, 19)
        Me.txtCodigoCapacitacion.TabIndex = 2
        Me.txtCodigoCapacitacion.Visible = False
        '
        'txtNombreCapacitacion
        '
        Me.txtNombreCapacitacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCapacitacion.Location = New System.Drawing.Point(184, 82)
        Me.txtNombreCapacitacion.MaxLength = 100
        Me.txtNombreCapacitacion.Name = "txtNombreCapacitacion"
        Me.txtNombreCapacitacion.Size = New System.Drawing.Size(219, 19)
        Me.txtNombreCapacitacion.TabIndex = 3
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(184, 106)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(219, 19)
        Me.txtObservaciones.TabIndex = 4
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.gwdDatos)
        Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 68)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(892, 345)
        Me.PanelGrilla.TabIndex = 1
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo_Capacitacion, Me.Nombre_Capacitacion, Me.Observacion})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(892, 345)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 1
        '
        'Codigo_Capacitacion
        '
        Me.Codigo_Capacitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Codigo_Capacitacion.DataPropertyName = "NCOCPT"
        Me.Codigo_Capacitacion.HeaderText = "Código"
        Me.Codigo_Capacitacion.Name = "Codigo_Capacitacion"
        Me.Codigo_Capacitacion.ReadOnly = True
        Me.Codigo_Capacitacion.Width = 69
        '
        'Nombre_Capacitacion
        '
        Me.Nombre_Capacitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre_Capacitacion.DataPropertyName = "NOMCPT"
        Me.Nombre_Capacitacion.HeaderText = "Nombre"
        Me.Nombre_Capacitacion.Name = "Nombre_Capacitacion"
        Me.Nombre_Capacitacion.ReadOnly = True
        Me.Nombre_Capacitacion.Width = 73
        '
        'Observacion
        '
        Me.Observacion.DataPropertyName = "TOBS"
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(212, 17)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(178, 19)
        Me.txtBuscar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar.TabIndex = 0
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(22, 21)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(187, 19)
        Me.KryptonLabel7.TabIndex = 4
        Me.KryptonLabel7.Text = "Tipo de Capacitación del Conductor"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Tipo de Capacitación del Conductor"
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
        Me.PanelFiltros.Size = New System.Drawing.Size(892, 68)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.Text = "Filtros de Consulta"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "Filtros de Consulta"
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
        Me.btnBuscar.UniqueName = "F64EF3A39CCD4E59F64EF3A39CCD4E59"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(892, 720)
        Me.SplitContainer1.SplitterDistance = 413
        Me.SplitContainer1.TabIndex = 2
        '
        'KryptonManager1
        '
        Me.KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'frmTipoCapacitacionConductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 720)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmTipoCapacitacionConductor"
        Me.Text = "Tipo de Capacitación del Conductor"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
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
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents PanelGrilla As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtBuscar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoCapacitacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNombreCapacitacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Codigo_Capacitacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Capacitacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
