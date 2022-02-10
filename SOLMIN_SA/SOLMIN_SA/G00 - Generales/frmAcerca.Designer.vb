<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcerca
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcerca))
		Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
		Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox
		Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
		Me.LabelCompanyName = New ComponentFactory.Krypton.Toolkit.KryptonLabel
		Me.LabelCopyright = New ComponentFactory.Krypton.Toolkit.KryptonLabel
		Me.LabelVersion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
		Me.LabelProductName = New ComponentFactory.Krypton.Toolkit.KryptonLabel
		Me.KryptonSplitContainer3 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
		Me.TextBoxDescription = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
		Me.OKButton = New ComponentFactory.Krypton.Toolkit.KryptonButton
		Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
		CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.KryptonPanel.SuspendLayout()
		CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.KryptonSplitContainer1.Panel1.SuspendLayout()
		CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.KryptonSplitContainer1.Panel2.SuspendLayout()
		Me.KryptonSplitContainer1.SuspendLayout()
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.KryptonSplitContainer2.Panel1.SuspendLayout()
		CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.KryptonSplitContainer2.Panel2.SuspendLayout()
		Me.KryptonSplitContainer2.SuspendLayout()
		CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.KryptonSplitContainer3.Panel1.SuspendLayout()
		CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.KryptonSplitContainer3.Panel2.SuspendLayout()
		Me.KryptonSplitContainer3.SuspendLayout()
		Me.SuspendLayout()
		'
		'KryptonPanel
		'
		Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
		Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
		Me.KryptonPanel.Name = "KryptonPanel"
		Me.KryptonPanel.Size = New System.Drawing.Size(431, 277)
		Me.KryptonPanel.TabIndex = 0
		'
		'KryptonSplitContainer1
		'
		Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
		Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
		'
		'KryptonSplitContainer1.Panel1
		'
		Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.LogoPictureBox)
		'
		'KryptonSplitContainer1.Panel2
		'
		Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonSplitContainer2)
		Me.KryptonSplitContainer1.Size = New System.Drawing.Size(431, 277)
		Me.KryptonSplitContainer1.SplitterDistance = 170
		Me.KryptonSplitContainer1.TabIndex = 0
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
		Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LogoPictureBox.ErrorImage = Nothing
		Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
		Me.LogoPictureBox.InitialImage = Nothing
		Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(170, 277)
		Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.LogoPictureBox.TabIndex = 0
		Me.LogoPictureBox.TabStop = False
		'
		'KryptonSplitContainer2
		'
		Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
		Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 0)
		Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
		Me.KryptonSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'KryptonSplitContainer2.Panel1
		'
		Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.LabelCompanyName)
		Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.LabelCopyright)
		Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.LabelVersion)
		Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.LabelProductName)
		'
		'KryptonSplitContainer2.Panel2
		'
		Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.KryptonSplitContainer3)
		Me.KryptonSplitContainer2.Size = New System.Drawing.Size(256, 277)
		Me.KryptonSplitContainer2.SplitterDistance = 105
		Me.KryptonSplitContainer2.TabIndex = 0
		'
		'LabelCompanyName
		'
		Me.LabelCompanyName.Location = New System.Drawing.Point(3, 78)
		Me.LabelCompanyName.Name = "LabelCompanyName"
		Me.LabelCompanyName.Size = New System.Drawing.Size(130, 16)
		Me.LabelCompanyName.TabIndex = 3
		Me.LabelCompanyName.Text = "Nombre de la compañía"
		Me.LabelCompanyName.Values.ExtraText = ""
		Me.LabelCompanyName.Values.Image = Nothing
		Me.LabelCompanyName.Values.Text = "Nombre de la compañía"
		'
		'LabelCopyright
		'
		Me.LabelCopyright.Location = New System.Drawing.Point(3, 56)
		Me.LabelCopyright.Name = "LabelCopyright"
		Me.LabelCopyright.Size = New System.Drawing.Size(59, 16)
		Me.LabelCopyright.TabIndex = 2
		Me.LabelCopyright.Text = "Copyright"
		Me.LabelCopyright.Values.ExtraText = ""
		Me.LabelCopyright.Values.Image = Nothing
		Me.LabelCopyright.Values.Text = "Copyright"
		'
		'LabelVersion
		'
		Me.LabelVersion.Location = New System.Drawing.Point(3, 34)
		Me.LabelVersion.Name = "LabelVersion"
		Me.LabelVersion.Size = New System.Drawing.Size(49, 16)
		Me.LabelVersion.TabIndex = 1
		Me.LabelVersion.Text = "Versión"
		Me.LabelVersion.Values.ExtraText = ""
		Me.LabelVersion.Values.Image = Nothing
		Me.LabelVersion.Values.Text = "Versión"
		'
		'LabelProductName
		'
		Me.LabelProductName.Location = New System.Drawing.Point(3, 12)
		Me.LabelProductName.Name = "LabelProductName"
		Me.LabelProductName.Size = New System.Drawing.Size(116, 16)
		Me.LabelProductName.TabIndex = 0
		Me.LabelProductName.Text = "Nombre del producto"
		Me.LabelProductName.Values.ExtraText = ""
		Me.LabelProductName.Values.Image = Nothing
		Me.LabelProductName.Values.Text = "Nombre del producto"
		'
		'KryptonSplitContainer3
		'
		Me.KryptonSplitContainer3.Cursor = System.Windows.Forms.Cursors.Default
		Me.KryptonSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.KryptonSplitContainer3.Location = New System.Drawing.Point(0, 0)
		Me.KryptonSplitContainer3.Name = "KryptonSplitContainer3"
		Me.KryptonSplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'KryptonSplitContainer3.Panel1
		'
		Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.TextBoxDescription)
		'
		'KryptonSplitContainer3.Panel2
		'
		Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.OKButton)
		Me.KryptonSplitContainer3.Size = New System.Drawing.Size(256, 167)
		Me.KryptonSplitContainer3.SplitterDistance = 129
		Me.KryptonSplitContainer3.TabIndex = 0
		'
		'TextBoxDescription
		'
		Me.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextBoxDescription.Location = New System.Drawing.Point(0, 0)
		Me.TextBoxDescription.Multiline = True
		Me.TextBoxDescription.Name = "TextBoxDescription"
		Me.TextBoxDescription.ReadOnly = True
		Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBoxDescription.Size = New System.Drawing.Size(256, 129)
		Me.TextBoxDescription.TabIndex = 0
		Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
		'
		'OKButton
		'
		Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.OKButton.Location = New System.Drawing.Point(163, 3)
		Me.OKButton.Name = "OKButton"
		Me.OKButton.Size = New System.Drawing.Size(90, 25)
		Me.OKButton.TabIndex = 0
		Me.OKButton.Text = "Aceptar"
		Me.OKButton.Values.ExtraText = ""
		Me.OKButton.Values.Image = Nothing
		Me.OKButton.Values.ImageStates.ImageCheckedNormal = Nothing
		Me.OKButton.Values.ImageStates.ImageCheckedPressed = Nothing
		Me.OKButton.Values.ImageStates.ImageCheckedTracking = Nothing
		Me.OKButton.Values.Text = "Aceptar"
		'
		'frmAcerca
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.OKButton
		Me.ClientSize = New System.Drawing.Size(431, 277)
		Me.ControlBox = False
		Me.Controls.Add(Me.KryptonPanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "frmAcerca"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Acerca de:"
		CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
		Me.KryptonPanel.ResumeLayout(False)
		CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
		CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.KryptonSplitContainer1.ResumeLayout(False)
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.KryptonSplitContainer2.Panel1.ResumeLayout(False)
		Me.KryptonSplitContainer2.Panel1.PerformLayout()
		CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.KryptonSplitContainer2.Panel2.ResumeLayout(False)
		CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.KryptonSplitContainer2.ResumeLayout(False)
		CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.KryptonSplitContainer3.Panel1.ResumeLayout(False)
		Me.KryptonSplitContainer3.Panel1.PerformLayout()
		CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.KryptonSplitContainer3.Panel2.ResumeLayout(False)
		CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.KryptonSplitContainer3.ResumeLayout(False)
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
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonSplitContainer3 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents OKButton As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TextBoxDescription As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LabelProductName As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents LabelVersion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents LabelCopyright As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents LabelCompanyName As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
End Class
