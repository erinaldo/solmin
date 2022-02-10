<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDPosiciones
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
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.dgDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nordsr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.qsletq = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tmrcd2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgDetalle)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeader1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(540, 252)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny1})
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(540, 31)
        Me.KryptonHeader1.TabIndex = 1
        Me.KryptonHeader1.Text = "KryptonHeader1"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "KryptonHeader1"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.ExtraText = ""
        Me.ButtonSpecAny1.Image = Nothing
        Me.ButtonSpecAny1.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.ButtonSpecAny1.Text = "Aceptar"
        Me.ButtonSpecAny1.ToolTipImage = Nothing
        Me.ButtonSpecAny1.UniqueName = "9DD94C88303F4BAD9DD94C88303F4BAD"
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.AllowUserToDeleteRows = False
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cliente, Me.nordsr, Me.qsletq, Me.tmrcd2})
        Me.dgDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetalle.Location = New System.Drawing.Point(0, 31)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.ReadOnly = True
        Me.dgDetalle.Size = New System.Drawing.Size(540, 221)
        Me.dgDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgDetalle.TabIndex = 0
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "CCLNT"
        Me.Cliente.HeaderText = "Cod. Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'nordsr
        '
        Me.nordsr.DataPropertyName = "NORDSR"
        Me.nordsr.HeaderText = "Orden"
        Me.nordsr.Name = "nordsr"
        Me.nordsr.ReadOnly = True
        Me.nordsr.Width = 80
        '
        'qsletq
        '
        Me.qsletq.DataPropertyName = "QSLETQ"
        Me.qsletq.HeaderText = "Cantidad"
        Me.qsletq.Name = "qsletq"
        Me.qsletq.ReadOnly = True
        Me.qsletq.Width = 80
        '
        'tmrcd2
        '
        Me.tmrcd2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tmrcd2.DataPropertyName = "TMRCD2"
        Me.tmrcd2.HeaderText = "Descripcion Producto"
        Me.tmrcd2.Name = "tmrcd2"
        Me.tmrcd2.ReadOnly = True
        '
        'frmDPosiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDPosiciones"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nordsr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qsletq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmrcd2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
