<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimiento
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
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.frmVentana = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.dtgListaMovimiento = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NRGUSA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FSLDAL = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.frmVentana, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.frmVentana.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.frmVentana.Panel.SuspendLayout()
    Me.frmVentana.SuspendLayout()
    CType(Me.dtgListaMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'frmVentana
    '
    Me.frmVentana.Dock = System.Windows.Forms.DockStyle.Fill
    Me.frmVentana.Location = New System.Drawing.Point(0, 0)
    Me.frmVentana.Name = "frmVentana"
    '
    'frmVentana.Panel
    '
    Me.frmVentana.Panel.Controls.Add(Me.dtgListaMovimiento)
    Me.frmVentana.Size = New System.Drawing.Size(442, 142)
    Me.frmVentana.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.frmVentana.TabIndex = 13
    Me.frmVentana.Text = "Lista de Movimientos Zonas"
    Me.frmVentana.ValuesPrimary.Description = ""
    Me.frmVentana.ValuesPrimary.Heading = "Lista de Movimientos Zonas"
    Me.frmVentana.ValuesPrimary.Image = Nothing
    Me.frmVentana.ValuesSecondary.Description = ""
    Me.frmVentana.ValuesSecondary.Heading = ""
    Me.frmVentana.ValuesSecondary.Image = Nothing
    '
    'dtgListaMovimiento
    '
    Me.dtgListaMovimiento.AllowUserToAddRows = False
    Me.dtgListaMovimiento.AllowUserToDeleteRows = False
    Me.dtgListaMovimiento.AllowUserToResizeColumns = False
    Me.dtgListaMovimiento.AllowUserToResizeRows = False
    Me.dtgListaMovimiento.ColumnHeadersHeight = 20
    Me.dtgListaMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dtgListaMovimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM, Me.NRGUSA, Me.FSLDAL})
    Me.dtgListaMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgListaMovimiento.Location = New System.Drawing.Point(0, 0)
    Me.dtgListaMovimiento.MultiSelect = False
    Me.dtgListaMovimiento.Name = "dtgListaMovimiento"
    Me.dtgListaMovimiento.ReadOnly = True
    Me.dtgListaMovimiento.RowHeadersVisible = False
    Me.dtgListaMovimiento.RowHeadersWidth = 30
    Me.dtgListaMovimiento.Size = New System.Drawing.Size(440, 117)
    Me.dtgListaMovimiento.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgListaMovimiento.TabIndex = 0
    '
    'ITEM
    '
    Me.ITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ITEM.DataPropertyName = "ITEM"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.ITEM.DefaultCellStyle = DataGridViewCellStyle1
    Me.ITEM.HeaderText = "Item"
    Me.ITEM.Name = "ITEM"
    Me.ITEM.ReadOnly = True
    Me.ITEM.Width = 58
    '
    'NRGUSA
    '
    Me.NRGUSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NRGUSA.DataPropertyName = "NRGUSA"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.NRGUSA.DefaultCellStyle = DataGridViewCellStyle2
    Me.NRGUSA.HeaderText = "Guía de Salida"
    Me.NRGUSA.Name = "NRGUSA"
    Me.NRGUSA.ReadOnly = True
    Me.NRGUSA.Width = 110
    '
    'FSLDAL
    '
    Me.FSLDAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.FSLDAL.DataPropertyName = "FSLDAL"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.FSLDAL.DefaultCellStyle = DataGridViewCellStyle3
    Me.FSLDAL.HeaderText = "Fecha y Hora"
    Me.FSLDAL.Name = "FSLDAL"
    Me.FSLDAL.ReadOnly = True
    '
    'frmMovimiento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(442, 142)
    Me.ControlBox = False
    Me.Controls.Add(Me.frmVentana)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmMovimiento"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = " "
    CType(Me.frmVentana.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.frmVentana.Panel.ResumeLayout(False)
    CType(Me.frmVentana, System.ComponentModel.ISupportInitialize).EndInit()
    Me.frmVentana.ResumeLayout(False)
    CType(Me.dtgListaMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents frmVentana As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents dtgListaMovimiento As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NRGUSA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FSLDAL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
