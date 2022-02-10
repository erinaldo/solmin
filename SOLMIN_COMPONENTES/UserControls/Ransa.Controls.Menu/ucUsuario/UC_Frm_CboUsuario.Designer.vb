<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Frm_CboUsuario
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Frm_CboUsuario))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
    Me.dgvUsuario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.btnBuscar = New System.Windows.Forms.ToolStripButton
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.PSMMCUSR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.PSMMNUSR = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.UcPaginacion)
    Me.KryptonPanel.Controls.Add(Me.dgvUsuario)
    Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(410, 383)
    Me.KryptonPanel.TabIndex = 0
    '
    'UcPaginacion
    '
    Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.UcPaginacion.Location = New System.Drawing.Point(0, 358)
    Me.UcPaginacion.Name = "UcPaginacion"
    Me.UcPaginacion.PageCount = 0
    Me.UcPaginacion.PageNumber = 1
    Me.UcPaginacion.PageSize = 20
    Me.UcPaginacion.Size = New System.Drawing.Size(410, 25)
    Me.UcPaginacion.TabIndex = 47
    '
    'dgvUsuario
    '
    Me.dgvUsuario.AllowUserToAddRows = False
    Me.dgvUsuario.AllowUserToDeleteRows = False
    Me.dgvUsuario.AllowUserToResizeColumns = False
    Me.dgvUsuario.AllowUserToResizeRows = False
    Me.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.dgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSMMCUSR, Me.PSMMNUSR})
    Me.dgvUsuario.DataMember = "dtCliente"
    Me.dgvUsuario.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgvUsuario.Location = New System.Drawing.Point(0, 116)
    Me.dgvUsuario.MultiSelect = False
    Me.dgvUsuario.Name = "dgvUsuario"
    Me.dgvUsuario.ReadOnly = True
    Me.dgvUsuario.RowHeadersWidth = 20
    Me.dgvUsuario.RowTemplate.ReadOnly = True
    Me.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvUsuario.Size = New System.Drawing.Size(410, 267)
    Me.dgvUsuario.StandardTab = True
    Me.dgvUsuario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dgvUsuario.TabIndex = 46
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btnBuscar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 91)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(410, 25)
    Me.ToolStrip1.TabIndex = 42
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 22)
    Me.ToolStripLabel1.Text = "Detalle :"
    '
    'btnBuscar
    '
    Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
    Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
    Me.btnBuscar.Text = "Buscar"
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
    Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnSalir)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCodigo)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDescripcion)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCodigo)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDescripcion)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(410, 91)
    Me.KryptonHeaderGroup1.TabIndex = 0
    Me.KryptonHeaderGroup1.Text = "Heading"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'btnSalir
    '
    Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnSalir.Location = New System.Drawing.Point(334, 11)
    Me.btnSalir.Name = "btnSalir"
    Me.btnSalir.Size = New System.Drawing.Size(59, 25)
    Me.btnSalir.TabIndex = 97
    Me.btnSalir.Text = "&Cerrar"
    Me.btnSalir.Values.ExtraText = ""
    Me.btnSalir.Values.Image = Nothing
    Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnSalir.Values.Text = "&Cerrar"
    '
    'lblCodigo
    '
    Me.lblCodigo.Location = New System.Drawing.Point(15, 20)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(70, 16)
    Me.lblCodigo.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo.TabIndex = 93
    Me.lblCodigo.Text = "USUARIO : "
    Me.lblCodigo.Values.ExtraText = ""
    Me.lblCodigo.Values.Image = Nothing
    Me.lblCodigo.Values.Text = "USUARIO : "
    '
    'lblDescripcion
    '
    Me.lblDescripcion.Location = New System.Drawing.Point(15, 52)
    Me.lblDescripcion.Name = "lblDescripcion"
    Me.lblDescripcion.Size = New System.Drawing.Size(68, 16)
    Me.lblDescripcion.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblDescripcion.TabIndex = 95
    Me.lblDescripcion.Text = "NOMBRE :"
    Me.lblDescripcion.Values.ExtraText = ""
    Me.lblDescripcion.Values.Image = Nothing
    Me.lblDescripcion.Values.Text = "NOMBRE :"
    '
    'txtCodigo
    '
    Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtCodigo.CausesValidation = False
    Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigo.Location = New System.Drawing.Point(131, 20)
    Me.txtCodigo.MaxLength = 10
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(87, 21)
    Me.txtCodigo.TabIndex = 0
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtDescripcion.CausesValidation = False
    Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDescripcion.Location = New System.Drawing.Point(131, 52)
    Me.txtDescripcion.MaxLength = 25
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(262, 21)
    Me.txtDescripcion.TabIndex = 1
    '
    'PSMMCUSR
    '
    Me.PSMMCUSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.PSMMCUSR.DataPropertyName = "PSMMCUSR"
    Me.PSMMCUSR.HeaderText = "Código"
    Me.PSMMCUSR.MinimumWidth = 100
    Me.PSMMCUSR.Name = "PSMMCUSR"
    Me.PSMMCUSR.ReadOnly = True
    '
    'PSMMNUSR
    '
    Me.PSMMNUSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.PSMMNUSR.DataPropertyName = "PSMMNUSR"
    Me.PSMMNUSR.HeaderText = "Descripción"
    Me.PSMMNUSR.MinimumWidth = 400
    Me.PSMMNUSR.Name = "PSMMNUSR"
    Me.PSMMNUSR.ReadOnly = True
    '
    'UC_Frm_CboUsuario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(410, 383)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "UC_Frm_CboUsuario"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Búsqueda Usuario"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup1.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.ResumeLayout(False)
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
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Private WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
  Private WithEvents lblCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Private WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
  Private WithEvents dgvUsuario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Private WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Private WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents PSMMCUSR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PSMMNUSR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
