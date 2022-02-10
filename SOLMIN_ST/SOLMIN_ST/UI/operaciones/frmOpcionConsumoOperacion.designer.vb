<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionConsumoOperacion
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgConOpe = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.Separador = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOTALS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMPTTL = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgConOpe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgConOpe)
        Me.KryptonPanel.Controls.Add(Me.MenuBar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(295, 229)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgConOpe
        '
        Me.dtgConOpe.AllowUserToAddRows = False
        Me.dtgConOpe.AllowUserToDeleteRows = False
        Me.dtgConOpe.AllowUserToOrderColumns = True
        Me.dtgConOpe.ColumnHeadersHeight = 30
        Me.dtgConOpe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgConOpe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPLCUN, Me.TOTALS, Me.IMPTTL})
        Me.dtgConOpe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgConOpe.Location = New System.Drawing.Point(0, 25)
        Me.dtgConOpe.Name = "dtgConOpe"
        Me.dtgConOpe.RowHeadersVisible = False
        Me.dtgConOpe.RowHeadersWidth = 40
        Me.dtgConOpe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgConOpe.Size = New System.Drawing.Size(295, 204)
        Me.dtgConOpe.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgConOpe.TabIndex = 8
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separador, Me.btnAceptar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(295, 25)
        Me.MenuBar.TabIndex = 7
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'Separador
        '
        Me.Separador.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separador.Name = "Separador"
        Me.Separador.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro. Placa de la Unidad"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TOTALS"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Importe Soles"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 106
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IMPTTL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Importe Soles"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 106
        '
        'NPLCUN
        '
        Me.NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NPLCUN.DataPropertyName = "NPLCUN"
        Me.NPLCUN.HeaderText = "Nro. Placa de la Unidad"
        Me.NPLCUN.Name = "NPLCUN"
        Me.NPLCUN.ReadOnly = True
        '
        'TOTALS
        '
        Me.TOTALS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOTALS.DataPropertyName = "TOTALS"
        Me.TOTALS.HeaderText = "Importe Soles"
        Me.TOTALS.Name = "TOTALS"
        Me.TOTALS.ReadOnly = True
        Me.TOTALS.Visible = False
        Me.TOTALS.Width = 106
        '
        'IMPTTL
        '
        Me.IMPTTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPTTL.DataPropertyName = "IMPTTL"
        Me.IMPTTL.HeaderText = "Importe Soles"
        Me.IMPTTL.Name = "IMPTTL"
        Me.IMPTTL.ReadOnly = True
        Me.IMPTTL.Visible = False
        Me.IMPTTL.Width = 106
        '
        'frmOpcionConsumoOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 229)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOpcionConsumoOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Placa de Unidad"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgConOpe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtgConOpe As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPTTL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
