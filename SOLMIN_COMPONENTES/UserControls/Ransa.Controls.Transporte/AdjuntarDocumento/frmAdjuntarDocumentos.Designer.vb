<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdjuntarDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdjuntarDocumentos))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.FileStorage1 = New StorageFileManager.FileStorage
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.FileStorage1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(647, 394)
        Me.KryptonPanel.TabIndex = 0
        '
        'FileStorage1
        '
        Me.FileStorage1.CCLNT = ""
        Me.FileStorage1.CCMPN = ""
        Me.FileStorage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileStorage1.ImageListNumbers = CType(resources.GetObject("FileStorage1.ImageListNumbers"), System.Collections.Generic.List(Of String))
        Me.FileStorage1.Location = New System.Drawing.Point(0, 0)
        Me.FileStorage1.ModeEdition = True
        Me.FileStorage1.Name = "FileStorage1"
        Me.FileStorage1.NMRGIM = ""
        Me.FileStorage1.Size = New System.Drawing.Size(647, 394)
        Me.FileStorage1.SystemName = ""
        Me.FileStorage1.TabIndex = 0
        Me.FileStorage1.TableName = ""
        Me.FileStorage1.UserName = ""
        '
        'frmAdjuntarDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 394)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmAdjuntarDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
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
    'Friend WithEvents FileStorage1 As StorageFileManager.FileStorage
End Class
