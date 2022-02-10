<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicioTransporte
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
    Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.Codigo_TipoServicioTrans = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Desc_Completa_TipoServTrans = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Abreviatura_Mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtBuscar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.txtDescripAbrevTipoServicioTrans = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtDescripCompTipoServTrans = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigoServicioTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnNuevo = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEliminar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonManager2 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel1.SuspendLayout()
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
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(742, 714)
    Me.KryptonPanel.TabIndex = 0
    '
    'KryptonPanel1
    '
    Me.KryptonPanel1.Controls.Add(Me.SplitContainer1)
    Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel1.Name = "KryptonPanel1"
    Me.KryptonPanel1.Size = New System.Drawing.Size(742, 714)
    Me.KryptonPanel1.TabIndex = 1
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
    Me.SplitContainer1.Size = New System.Drawing.Size(742, 714)
    Me.SplitContainer1.SplitterDistance = 473
    Me.SplitContainer1.TabIndex = 2
    '
    'PanelGrilla
    '
    Me.PanelGrilla.Controls.Add(Me.gwdDatos)
    Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelGrilla.Location = New System.Drawing.Point(0, 64)
    Me.PanelGrilla.Name = "PanelGrilla"
    Me.PanelGrilla.Size = New System.Drawing.Size(742, 409)
    Me.PanelGrilla.TabIndex = 1
    '
    'gwdDatos
    '
    Me.gwdDatos.AllowUserToAddRows = False
    Me.gwdDatos.AllowUserToOrderColumns = True
    Me.gwdDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gwdDatos.ColumnHeadersHeight = 30
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo_TipoServicioTrans, Me.Desc_Completa_TipoServTrans, Me.Abreviatura_Mercaderia})
    Me.gwdDatos.Location = New System.Drawing.Point(8, 8)
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.ReadOnly = True
    Me.gwdDatos.RowHeadersWidth = 20
    Me.gwdDatos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.0!)
    Me.gwdDatos.RowTemplate.Height = 20
    Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatos.Size = New System.Drawing.Size(726, 401)
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 0
    '
    'Codigo_TipoServicioTrans
    '
    Me.Codigo_TipoServicioTrans.DataPropertyName = "CTPOSR"
    Me.Codigo_TipoServicioTrans.HeaderText = "Codigo Tipo Servicio Trans"
    Me.Codigo_TipoServicioTrans.Name = "Codigo_TipoServicioTrans"
    Me.Codigo_TipoServicioTrans.ReadOnly = True
    Me.Codigo_TipoServicioTrans.Width = 150
    '
    'Desc_Completa_TipoServTrans
    '
    Me.Desc_Completa_TipoServTrans.DataPropertyName = "TCMTPS"
    Me.Desc_Completa_TipoServTrans.HeaderText = "Desc Completa Tipo Servicio Trans"
    Me.Desc_Completa_TipoServTrans.Name = "Desc_Completa_TipoServTrans"
    Me.Desc_Completa_TipoServTrans.ReadOnly = True
    Me.Desc_Completa_TipoServTrans.Width = 300
    '
    'Abreviatura_Mercaderia
    '
    Me.Abreviatura_Mercaderia.DataPropertyName = "TABTPS"
    Me.Abreviatura_Mercaderia.HeaderText = "Abrv"
    Me.Abreviatura_Mercaderia.Name = "Abreviatura_Mercaderia"
    Me.Abreviatura_Mercaderia.ReadOnly = True
    Me.Abreviatura_Mercaderia.Width = 200
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
    Me.PanelFiltros.Size = New System.Drawing.Size(742, 64)
    Me.PanelFiltros.TabIndex = 0
    Me.PanelFiltros.Text = "SERVICIOS DE TRANSPORTES"
    Me.PanelFiltros.ValuesPrimary.Description = ""
    Me.PanelFiltros.ValuesPrimary.Heading = "SERVICIOS DE TRANSPORTES"
    Me.PanelFiltros.ValuesPrimary.Image = Nothing
    Me.PanelFiltros.ValuesSecondary.Description = ""
    Me.PanelFiltros.ValuesSecondary.Heading = "Description"
    Me.PanelFiltros.ValuesSecondary.Image = Nothing
    '
    'btnBuscar
    '
    Me.btnBuscar.ExtraText = ""
    Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.ToolTipImage = Nothing
    Me.btnBuscar.UniqueName = "455A2C6E0BCD41CF455A2C6E0BCD41CF"
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(8, 12)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(49, 19)
    Me.KryptonLabel7.TabIndex = 4
    Me.KryptonLabel7.Text = "Servicio"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Servicio"
    '
    'txtBuscar
    '
    Me.txtBuscar.Location = New System.Drawing.Point(68, 8)
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
    Me.HeaderDatos.Panel.Controls.Add(Me.txtDescripAbrevTipoServicioTrans)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel3)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtDescripCompTipoServTrans)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel2)
    Me.HeaderDatos.Panel.Controls.Add(Me.txtCodigoServicioTransporte)
    Me.HeaderDatos.Panel.Controls.Add(Me.KryptonLabel1)
    Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
    Me.HeaderDatos.Size = New System.Drawing.Size(742, 237)
    Me.HeaderDatos.TabIndex = 0
    Me.HeaderDatos.Text = "Información de Mantenimiento"
    Me.HeaderDatos.ValuesPrimary.Description = ""
    Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
    Me.HeaderDatos.ValuesPrimary.Image = Nothing
    Me.HeaderDatos.ValuesSecondary.Description = ""
    Me.HeaderDatos.ValuesSecondary.Heading = "Description"
    Me.HeaderDatos.ValuesSecondary.Image = Nothing
    '
    'txtDescripAbrevTipoServicioTrans
    '
    Me.txtDescripAbrevTipoServicioTrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDescripAbrevTipoServicioTrans.Location = New System.Drawing.Point(112, 105)
    Me.txtDescripAbrevTipoServicioTrans.Name = "txtDescripAbrevTipoServicioTrans"
    Me.txtDescripAbrevTipoServicioTrans.Size = New System.Drawing.Size(202, 21)
    Me.txtDescripAbrevTipoServicioTrans.TabIndex = 6
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(8, 107)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel3.TabIndex = 5
    Me.KryptonLabel3.Text = "Abreviatura"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Abreviatura"
    '
    'txtDescripCompTipoServTrans
    '
    Me.txtDescripCompTipoServTrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDescripCompTipoServTrans.Location = New System.Drawing.Point(112, 70)
    Me.txtDescripCompTipoServTrans.Name = "txtDescripCompTipoServTrans"
    Me.txtDescripCompTipoServTrans.Size = New System.Drawing.Size(202, 21)
    Me.txtDescripCompTipoServTrans.TabIndex = 4
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(8, 73)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel2.TabIndex = 3
    Me.KryptonLabel2.Text = "Descripción"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Descripción"
    '
    'txtCodigoServicioTransporte
    '
    Me.txtCodigoServicioTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigoServicioTransporte.Location = New System.Drawing.Point(112, 36)
    Me.txtCodigoServicioTransporte.Name = "txtCodigoServicioTransporte"
    Me.txtCodigoServicioTransporte.Size = New System.Drawing.Size(202, 21)
    Me.txtCodigoServicioTransporte.TabIndex = 2
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(8, 40)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(104, 19)
    Me.KryptonLabel1.TabIndex = 1
    Me.KryptonLabel1.Text = "Código de Servicio"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Código de Servicio"
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
    'frmServicioTransporte
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(742, 714)
    Me.Controls.Add(Me.KryptonPanel1)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmServicioTransporte"
    Me.Text = "frmServicioTransporte"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel1.ResumeLayout(False)
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelGrilla As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtBuscar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtDescripAbrevTipoServicioTrans As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripCompTipoServTrans As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoServicioTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonManager2 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents Codigo_TipoServicioTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desc_Completa_TipoServTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Abreviatura_Mercaderia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
