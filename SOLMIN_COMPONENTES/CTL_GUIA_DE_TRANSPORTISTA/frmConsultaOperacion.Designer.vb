<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaOperacion
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
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.dtgListaMovimiento = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    CType(Me.dtgListaMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'dtgListaMovimiento
    '
    Me.dtgListaMovimiento.AllowUserToAddRows = False
    Me.dtgListaMovimiento.AllowUserToDeleteRows = False
    Me.dtgListaMovimiento.AllowUserToResizeColumns = False
    Me.dtgListaMovimiento.AllowUserToResizeRows = False
    Me.dtgListaMovimiento.ColumnHeadersHeight = 30
    Me.dtgListaMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dtgListaMovimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOPRCN, Me.TCMPCL})
    Me.dtgListaMovimiento.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.dtgListaMovimiento.Location = New System.Drawing.Point(0, 25)
    Me.dtgListaMovimiento.MultiSelect = False
    Me.dtgListaMovimiento.Name = "dtgListaMovimiento"
    Me.dtgListaMovimiento.ReadOnly = True
    Me.dtgListaMovimiento.RowHeadersVisible = False
    Me.dtgListaMovimiento.RowHeadersWidth = 30
    Me.dtgListaMovimiento.Size = New System.Drawing.Size(442, 192)
    Me.dtgListaMovimiento.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgListaMovimiento.TabIndex = 0
    '
    'NOPRCN
    '
    Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NOPRCN.DataPropertyName = "NOPRCN"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.NOPRCN.DefaultCellStyle = DataGridViewCellStyle3
    Me.NOPRCN.HeaderText = "Operación"
    Me.NOPRCN.Name = "NOPRCN"
    Me.NOPRCN.ReadOnly = True
    Me.NOPRCN.Width = 90
    '
    'TCMPCL
    '
    Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TCMPCL.DataPropertyName = "TCMPCL"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.TCMPCL.DefaultCellStyle = DataGridViewCellStyle4
    Me.TCMPCL.HeaderText = "Cliente"
    Me.TCMPCL.Name = "TCMPCL"
    Me.TCMPCL.ReadOnly = True
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnAceptar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(442, 25)
    Me.ToolStrip1.TabIndex = 1
    '
    'btnAceptar
    '
    Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAceptar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_ok
    Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
    Me.btnAceptar.Text = "Aceptar"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'frmConsultaOperacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(442, 217)
    Me.ControlBox = False
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.dtgListaMovimiento)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmConsultaOperacion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = " "
    CType(Me.dtgListaMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

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
  Friend WithEvents dtgListaMovimiento As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
End Class
