<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Me.rtexto = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'rtexto
        '
        Me.rtexto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rtexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtexto.Location = New System.Drawing.Point(0, 0)
        Me.rtexto.Name = "rtexto"
        Me.rtexto.ReadOnly = True
        Me.rtexto.Size = New System.Drawing.Size(891, 435)
        Me.rtexto.TabIndex = 0
        Me.rtexto.Text = ""
        '
        'frmTrama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 435)
        Me.Controls.Add(Me.rtexto)
        Me.Name = "frmTrama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Trama"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents rtexto As System.Windows.Forms.RichTextBox
End Class
