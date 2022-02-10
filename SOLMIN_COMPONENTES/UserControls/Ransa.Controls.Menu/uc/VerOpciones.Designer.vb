<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerOpciones
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerOpciones))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.dgvOpcion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.MMCAPL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MMCMNU = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MMCOPC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MMDOPC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.btnBuscar = New System.Windows.Forms.ToolStripButton
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.lblCodigo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.txtCodigo = New Ransa.Utilitario.UCtxtSoloDecimales
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.dgvOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.dgvOpcion)
    Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(451, 382)
    Me.KryptonPanel.TabIndex = 0
    '
    'dgvOpcion
    '
    Me.dgvOpcion.AllowUserToAddRows = False
    Me.dgvOpcion.AllowUserToDeleteRows = False
    Me.dgvOpcion.AllowUserToResizeColumns = False
    Me.dgvOpcion.AllowUserToResizeRows = False
    Me.dgvOpcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.dgvOpcion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.dgvOpcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgvOpcion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MMCAPL, Me.MMCMNU, Me.MMCOPC, Me.MMDOPC})
    Me.dgvOpcion.DataMember = "dtCliente"
    Me.dgvOpcion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgvOpcion.Location = New System.Drawing.Point(0, 120)
    Me.dgvOpcion.MultiSelect = False
    Me.dgvOpcion.Name = "dgvOpcion"
    Me.dgvOpcion.ReadOnly = True
    Me.dgvOpcion.RowHeadersWidth = 20
    Me.dgvOpcion.RowTemplate.ReadOnly = True
    Me.dgvOpcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvOpcion.Size = New System.Drawing.Size(451, 262)
    Me.dgvOpcion.StandardTab = True
    Me.dgvOpcion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dgvOpcion.TabIndex = 44
    '
    'MMCAPL
    '
    Me.MMCAPL.DataPropertyName = "MMCAPL"
    Me.MMCAPL.HeaderText = "MMCAPL"
    Me.MMCAPL.Name = "MMCAPL"
    Me.MMCAPL.ReadOnly = True
    Me.MMCAPL.Visible = False
    Me.MMCAPL.Width = 81
    '
    'MMCMNU
    '
    Me.MMCMNU.DataPropertyName = "MMCMNU"
    Me.MMCMNU.HeaderText = "MMCMNU"
    Me.MMCMNU.Name = "MMCMNU"
    Me.MMCMNU.ReadOnly = True
    Me.MMCMNU.Visible = False
    Me.MMCMNU.Width = 89
    '
    'MMCOPC
    '
    Me.MMCOPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.MMCOPC.DataPropertyName = "MMCOPC"
    Me.MMCOPC.HeaderText = "Codigo"
    Me.MMCOPC.MinimumWidth = 80
    Me.MMCOPC.Name = "MMCOPC"
    Me.MMCOPC.ReadOnly = True
    Me.MMCOPC.Width = 80
    '
    'MMDOPC
    '
    Me.MMDOPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.MMDOPC.DataPropertyName = "MMDOPC"
    Me.MMDOPC.HeaderText = "Descripción"
    Me.MMDOPC.MinimumWidth = 350
    Me.MMDOPC.Name = "MMDOPC"
    Me.MMDOPC.ReadOnly = True
    Me.MMDOPC.Width = 350
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btnBuscar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 95)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(451, 25)
    Me.ToolStrip1.TabIndex = 42
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(60, 22)
    Me.ToolStripLabel1.Text = "Opciones"
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
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCodigo)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnSalir)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCodigo)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDescripcion)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDescripcion)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(451, 95)
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
    Me.btnSalir.Location = New System.Drawing.Point(379, 43)
    Me.btnSalir.Name = "btnSalir"
    Me.btnSalir.Size = New System.Drawing.Size(59, 25)
    Me.btnSalir.TabIndex = 96
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
    Me.lblCodigo.Location = New System.Drawing.Point(11, 20)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(64, 16)
    Me.lblCodigo.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo.TabIndex = 92
    Me.lblCodigo.Text = "CODIGO : "
    Me.lblCodigo.Values.ExtraText = ""
    Me.lblCodigo.Values.Image = Nothing
    Me.lblCodigo.Values.Text = "CODIGO : "
    '
    'lblDescripcion
    '
    Me.lblDescripcion.Location = New System.Drawing.Point(11, 52)
    Me.lblDescripcion.Name = "lblDescripcion"
    Me.lblDescripcion.Size = New System.Drawing.Size(98, 16)
    Me.lblDescripcion.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblDescripcion.TabIndex = 94
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
    Me.txtDescripcion.Location = New System.Drawing.Point(115, 47)
    Me.txtDescripcion.MaxLength = 25
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(240, 21)
    Me.txtDescripcion.TabIndex = 95
    '
    'txtCodigo
    '
    Me.txtCodigo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.txtCodigo.BackColor = System.Drawing.Color.Transparent
    Me.txtCodigo.Location = New System.Drawing.Point(115, 19)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.NumerosDecimales = 0
    Me.txtCodigo.NumerosEnteros = 2
    Me.txtCodigo.Size = New System.Drawing.Size(58, 22)
    Me.txtCodigo.TabIndex = 97
    '
    'FrmVerOpciones
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(451, 382)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmVerOpciones"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Opciones"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    CType(Me.dgvOpcion, System.ComponentModel.ISupportInitialize).EndInit()
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
  Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
  Private WithEvents dgvOpcion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Private WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
  Private WithEvents lblCodigo As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Private WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Private WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents MMCAPL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMCMNU As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMCOPC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMDOPC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents txtCodigo As Ransa.Utilitario.UCtxtSoloDecimales
End Class
