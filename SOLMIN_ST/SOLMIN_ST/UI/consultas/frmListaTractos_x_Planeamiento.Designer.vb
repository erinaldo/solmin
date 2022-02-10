<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaTractos_x_Planeamiento
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.NPLNMT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NPLCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CBRCND = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'panel
    '
    Me.panel.Controls.Add(Me.MenuBar)
    Me.panel.Controls.Add(Me.gwdDatos)
    Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel.Location = New System.Drawing.Point(0, 0)
    Me.panel.Name = "panel"
    Me.panel.Size = New System.Drawing.Size(744, 276)
    Me.panel.TabIndex = 0
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btnCancelar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(744, 25)
    Me.MenuBar.TabIndex = 1
    Me.MenuBar.Text = "ToolStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(174, 22)
    Me.ToolStripLabel1.Text = "  Lista de Tractos por Planeamiento"
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(69, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'gwdDatos
    '
    Me.gwdDatos.AllowUserToAddRows = False
    Me.gwdDatos.AllowUserToDeleteRows = False
    Me.gwdDatos.AllowUserToOrderColumns = True
    Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.gwdDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
    Me.gwdDatos.ColumnHeadersHeight = 30
    Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPLNMT, Me.NRUCTR, Me.NPLCTR, Me.NPLCAC, Me.CBRCNT, Me.CBRCND, Me.RUTA})
    Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.gwdDatos.Location = New System.Drawing.Point(0, 24)
    Me.gwdDatos.MultiSelect = False
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.ReadOnly = True
    Me.gwdDatos.RowHeadersVisible = False
    Me.gwdDatos.RowHeadersWidth = 20
    Me.gwdDatos.RowTemplate.Height = 16
    Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatos.Size = New System.Drawing.Size(744, 252)
    Me.gwdDatos.StandardTab = True
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 0
    Me.gwdDatos.TabStop = False
    '
    'NPLNMT
    '
    Me.NPLNMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NPLNMT.DataPropertyName = "NPLNMT"
    Me.NPLNMT.HeaderText = "N° Planeamiento"
    Me.NPLNMT.MaxInputLength = 150
    Me.NPLNMT.Name = "NPLNMT"
    Me.NPLNMT.ReadOnly = True
    Me.NPLNMT.Visible = False
    Me.NPLNMT.Width = 115
    '
    'NRUCTR
    '
    Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NRUCTR.DataPropertyName = "NRUCTR"
    Me.NRUCTR.HeaderText = "RUC Transportista"
    Me.NRUCTR.Name = "NRUCTR"
    Me.NRUCTR.ReadOnly = True
    Me.NRUCTR.Width = 123
    '
    'NPLCTR
    '
    Me.NPLCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NPLCTR.DataPropertyName = "NPLCTR"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.NPLCTR.DefaultCellStyle = DataGridViewCellStyle1
    Me.NPLCTR.HeaderText = "Placa Tracto"
    Me.NPLCTR.Name = "NPLCTR"
    Me.NPLCTR.ReadOnly = True
    Me.NPLCTR.Width = 97
    '
    'NPLCAC
    '
    Me.NPLCAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NPLCAC.DataPropertyName = "NPLCAC"
    Me.NPLCAC.HeaderText = "Placa Acoplado"
    Me.NPLCAC.Name = "NPLCAC"
    Me.NPLCAC.ReadOnly = True
    Me.NPLCAC.Width = 111
    '
    'CBRCNT
    '
    Me.CBRCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CBRCNT.DataPropertyName = "CBRCNT"
    DataGridViewCellStyle2.Format = "N0"
    DataGridViewCellStyle2.NullValue = "0"
    Me.CBRCNT.DefaultCellStyle = DataGridViewCellStyle2
    Me.CBRCNT.HeaderText = "Brevete Conductor"
    Me.CBRCNT.Name = "CBRCNT"
    Me.CBRCNT.ReadOnly = True
    Me.CBRCNT.Width = 125
    '
    'CBRCND
    '
    Me.CBRCND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.CBRCND.DataPropertyName = "CBRCND"
    Me.CBRCND.HeaderText = "Conductor"
    Me.CBRCND.Name = "CBRCND"
    Me.CBRCND.ReadOnly = True
    '
    'RUTA
    '
    Me.RUTA.DataPropertyName = "RUTA"
    Me.RUTA.HeaderText = "Ruta"
    Me.RUTA.Name = "RUTA"
    Me.RUTA.ReadOnly = True
    Me.RUTA.Visible = False
    '
    'frmListaTractos_x_Planeamiento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(744, 276)
    Me.ControlBox = False
    Me.Controls.Add(Me.panel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximumSize = New System.Drawing.Size(750, 300)
    Me.MinimumSize = New System.Drawing.Size(750, 300)
    Me.Name = "frmListaTractos_x_Planeamiento"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = " "
    CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel.ResumeLayout(False)
    Me.panel.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents NPLNMT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NPLCTR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CBRCND As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
