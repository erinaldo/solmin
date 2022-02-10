<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintPreview))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton
        Me.btnSig = New System.Windows.Forms.ToolStripButton
        Me.btnAtras = New System.Windows.Forms.ToolStripButton
        Me.PrintPreviewControl = New System.Windows.Forms.PrintPreviewControl
        Me.ComboBoxZoom = New System.Windows.Forms.ToolStripComboBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.PrintPreviewControl)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(705, 454)
        Me.KryptonPanel.TabIndex = 0
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimir, Me.btnAtras, Me.btnSig, Me.ComboBoxZoom})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(705, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.SOLMIN_SA.My.Resources.Resources.ico_impresora
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(69, 22)
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnSig
        '
        Me.btnSig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSig.Image = CType(resources.GetObject("btnSig.Image"), System.Drawing.Image)
        Me.btnSig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(27, 22)
        Me.btnSig.Text = ">>"
        Me.btnSig.ToolTipText = ">>"
        '
        'btnAtras
        '
        Me.btnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAtras.Image = CType(resources.GetObject("btnAtras.Image"), System.Drawing.Image)
        Me.btnAtras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(27, 22)
        Me.btnAtras.Text = "<<"
        '
        'PrintPreviewControl
        '
        Me.PrintPreviewControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl.Location = New System.Drawing.Point(0, 25)
        Me.PrintPreviewControl.Name = "PrintPreviewControl"
        Me.PrintPreviewControl.Size = New System.Drawing.Size(705, 429)
        Me.PrintPreviewControl.TabIndex = 2
        '
        'ComboBoxZoom
        '
        Me.ComboBoxZoom.AutoCompleteCustomSource.AddRange(New String() {"50", "75", "100", "150"})
        Me.ComboBoxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxZoom.Name = "ComboBoxZoom"
        Me.ComboBoxZoom.Size = New System.Drawing.Size(121, 25)
        '
        'frmPrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 454)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmPrintPreview"
        Me.Text = "PrintPreview"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSig As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAtras As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintPreviewControl As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents ComboBoxZoom As System.Windows.Forms.ToolStripComboBox
End Class
