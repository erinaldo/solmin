<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapaGps
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
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(944, 526)
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Global.SOLMIN_ST.My.Resources.Resources.agt_web
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'frmMapaGps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 526)
        Me.Controls.Add(Me.KryptonHeaderGroup2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMapaGps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Google Maps"
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
End Class
