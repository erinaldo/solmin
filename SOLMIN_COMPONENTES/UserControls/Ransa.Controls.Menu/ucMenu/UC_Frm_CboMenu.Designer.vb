<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Frm_CboMenu
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Frm_CboMenu))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
    Me.dgvMenu = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.PSMMCAPL_CodApl = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.PSMMCMNU_CodMnu = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.PSMMTMNU_DesMnu = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.btnBuscar = New System.Windows.Forms.ToolStripButton
    Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonManager2 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonManager3 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel1.SuspendLayout()
    CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel2.SuspendLayout()
    CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonGroup1.Panel.SuspendLayout()
    Me.KryptonGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(503, 403)
    Me.KryptonPanel.TabIndex = 0
    '
    'KryptonPanel1
    '
    Me.KryptonPanel1.Controls.Add(Me.KryptonPanel2)
    Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel1.Name = "KryptonPanel1"
    Me.KryptonPanel1.Size = New System.Drawing.Size(503, 403)
    Me.KryptonPanel1.TabIndex = 1
    '
    'KryptonPanel2
    '
    Me.KryptonPanel2.Controls.Add(Me.UcPaginacion)
    Me.KryptonPanel2.Controls.Add(Me.dgvMenu)
    Me.KryptonPanel2.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel2.Controls.Add(Me.KryptonGroup1)
    Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel2.Name = "KryptonPanel2"
    Me.KryptonPanel2.Size = New System.Drawing.Size(503, 403)
    Me.KryptonPanel2.TabIndex = 2
    '
    'UcPaginacion
    '
    Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.UcPaginacion.Location = New System.Drawing.Point(0, 378)
    Me.UcPaginacion.Name = "UcPaginacion"
    Me.UcPaginacion.PageCount = 0
    Me.UcPaginacion.PageNumber = 1
    Me.UcPaginacion.PageSize = 20
    Me.UcPaginacion.Size = New System.Drawing.Size(503, 25)
    Me.UcPaginacion.TabIndex = 45
    '
    'dgvMenu
    '
    Me.dgvMenu.AllowUserToAddRows = False
    Me.dgvMenu.AllowUserToDeleteRows = False
    Me.dgvMenu.AllowUserToResizeColumns = False
    Me.dgvMenu.AllowUserToResizeRows = False
    Me.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.dgvMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSMMCAPL_CodApl, Me.PSMMCMNU_CodMnu, Me.PSMMTMNU_DesMnu})
    Me.dgvMenu.DataMember = "dtCliente"
    Me.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgvMenu.Location = New System.Drawing.Point(0, 122)
    Me.dgvMenu.MultiSelect = False
    Me.dgvMenu.Name = "dgvMenu"
    Me.dgvMenu.ReadOnly = True
    Me.dgvMenu.RowHeadersWidth = 20
    Me.dgvMenu.RowTemplate.ReadOnly = True
    Me.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvMenu.Size = New System.Drawing.Size(503, 281)
    Me.dgvMenu.StandardTab = True
    Me.dgvMenu.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dgvMenu.TabIndex = 43
    '
    'PSMMCAPL_CodApl
    '
    Me.PSMMCAPL_CodApl.DataPropertyName = "PSMMCAPL"
    Me.PSMMCAPL_CodApl.HeaderText = "PSMMCAPL"
    Me.PSMMCAPL_CodApl.Name = "PSMMCAPL_CodApl"
    Me.PSMMCAPL_CodApl.ReadOnly = True
    Me.PSMMCAPL_CodApl.Visible = False
    Me.PSMMCAPL_CodApl.Width = 93
    '
    'PSMMCMNU_CodMnu
    '
    Me.PSMMCMNU_CodMnu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.PSMMCMNU_CodMnu.DataPropertyName = "PSMMCMNU"
    Me.PSMMCMNU_CodMnu.HeaderText = "Codigo"
    Me.PSMMCMNU_CodMnu.MinimumWidth = 100
    Me.PSMMCMNU_CodMnu.Name = "PSMMCMNU_CodMnu"
    Me.PSMMCMNU_CodMnu.ReadOnly = True
    '
    'PSMMTMNU_DesMnu
    '
    Me.PSMMTMNU_DesMnu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.PSMMTMNU_DesMnu.DataPropertyName = "PSMMTMNU"
    Me.PSMMTMNU_DesMnu.HeaderText = "Descripción"
    Me.PSMMTMNU_DesMnu.MinimumWidth = 400
    Me.PSMMTMNU_DesMnu.Name = "PSMMTMNU_DesMnu"
    Me.PSMMTMNU_DesMnu.ReadOnly = True
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btnBuscar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 97)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(503, 25)
    Me.ToolStrip1.TabIndex = 41
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(38, 22)
    Me.ToolStripLabel1.Text = "Menú"
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
    'KryptonGroup1
    '
    Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonGroup1.Name = "KryptonGroup1"
    '
    'KryptonGroup1.Panel
    '
    Me.KryptonGroup1.Panel.Controls.Add(Me.btnSalir)
    Me.KryptonGroup1.Panel.Controls.Add(Me.txtCodigo)
    Me.KryptonGroup1.Panel.Controls.Add(Me.lblCodigo)
    Me.KryptonGroup1.Panel.Controls.Add(Me.lblDescripcion)
    Me.KryptonGroup1.Panel.Controls.Add(Me.txtDescripcion)
    Me.KryptonGroup1.Size = New System.Drawing.Size(503, 97)
    Me.KryptonGroup1.TabIndex = 2
    '
    'btnSalir
    '
    Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnSalir.Location = New System.Drawing.Point(420, 12)
    Me.btnSalir.Name = "btnSalir"
    Me.btnSalir.Size = New System.Drawing.Size(59, 25)
    Me.btnSalir.TabIndex = 91
    Me.btnSalir.Text = "&Cerrar"
    Me.btnSalir.Values.ExtraText = ""
    Me.btnSalir.Values.Image = Nothing
    Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnSalir.Values.Text = "&Cerrar"
    '
    'txtCodigo
    '
    Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtCodigo.CausesValidation = False
    Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigo.Location = New System.Drawing.Point(130, 12)
    Me.txtCodigo.MaxLength = 2
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(54, 21)
    Me.txtCodigo.TabIndex = 0
    '
    'lblCodigo
    '
    Me.lblCodigo.Location = New System.Drawing.Point(14, 17)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(64, 16)
    Me.lblCodigo.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo.TabIndex = 83
    Me.lblCodigo.Text = "CODIGO : "
    Me.lblCodigo.Values.ExtraText = ""
    Me.lblCodigo.Values.Image = Nothing
    Me.lblCodigo.Values.Text = "CODIGO : "
    '
    'lblDescripcion
    '
    Me.lblDescripcion.Location = New System.Drawing.Point(14, 53)
    Me.lblDescripcion.Name = "lblDescripcion"
    Me.lblDescripcion.Size = New System.Drawing.Size(98, 16)
    Me.lblDescripcion.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblDescripcion.TabIndex = 85
    Me.lblDescripcion.Text = "DESCRIPCIÓN : "
    Me.lblDescripcion.Values.ExtraText = ""
    Me.lblDescripcion.Values.Image = Nothing
    Me.lblDescripcion.Values.Text = "DESCRIPCIÓN : "
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtDescripcion.CausesValidation = False
    Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDescripcion.Location = New System.Drawing.Point(130, 53)
    Me.txtDescripcion.MaxLength = 25
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(349, 21)
    Me.txtDescripcion.TabIndex = 1
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "TABAA"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción Abrev."
    Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "PNCAGNAD"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
    Me.DataGridViewTextBoxColumn1.MinimumWidth = 150
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSTCMAA"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
    Me.DataGridViewTextBoxColumn2.MinimumWidth = 250
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "PNCCLNT"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Cliente"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.Visible = False
    Me.DataGridViewTextBoxColumn4.Width = 72
    '
    'UC_Frm_CboMenu
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(503, 403)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "UC_Frm_CboMenu"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Búsqueda de Menú"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel1.ResumeLayout(False)
    CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel2.ResumeLayout(False)
    Me.KryptonPanel2.PerformLayout()
    CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonGroup1.Panel.ResumeLayout(False)
    Me.KryptonGroup1.Panel.PerformLayout()
    CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonGroup1.ResumeLayout(False)
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
  Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
  Private WithEvents dgvMenu As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
  Private WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
  Private WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Private WithEvents lblCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Private WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Private WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
  Friend WithEvents KryptonManager2 As ComponentFactory.Krypton.Toolkit.KryptonManager
  Friend WithEvents KryptonManager3 As ComponentFactory.Krypton.Toolkit.KryptonManager
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PSMMCAPL_CodApl As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PSMMCMNU_CodMnu As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PSMMTMNU_DesMnu As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
