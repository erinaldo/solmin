<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTipoDocumento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTipoDocumento))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.stcVertical = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.lbTipoDocumento = New System.Windows.Forms.ListBox
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.mskRangoFin = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.mskRangoIni = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.mskCantidad = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.stcVertical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stcVertical.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stcVertical.Panel1.SuspendLayout()
        CType(Me.stcVertical.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stcVertical.Panel2.SuspendLayout()
        Me.stcVertical.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.stcVertical)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(674, 440)
        Me.KryptonPanel.TabIndex = 0
        '
        'stcVertical
        '
        Me.stcVertical.Cursor = System.Windows.Forms.Cursors.Default
        Me.stcVertical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stcVertical.Location = New System.Drawing.Point(0, 0)
        Me.stcVertical.Name = "stcVertical"
        Me.stcVertical.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'stcVertical.Panel1
        '
        Me.stcVertical.Panel1.Controls.Add(Me.KryptonHeaderGroup3)
        Me.stcVertical.Panel1.Controls.Add(Me.KryptonHeaderGroup1)
        '
        'stcVertical.Panel2
        '
        Me.stcVertical.Panel2.Controls.Add(Me.KryptonHeaderGroup2)
        Me.stcVertical.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.stcVertical.Size = New System.Drawing.Size(674, 440)
        Me.stcVertical.SplitterDistance = 224
        Me.stcVertical.TabIndex = 2
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup3.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(0, 91)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(674, 133)
        Me.KryptonHeaderGroup3.TabIndex = 3
        Me.KryptonHeaderGroup3.Text = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup2})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.ListBox1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(674, 91)
        Me.KryptonHeaderGroup1.TabIndex = 2
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup2
        '
        Me.ButtonSpecHeaderGroup2.ExtraText = ""
        Me.ButtonSpecHeaderGroup2.Image = Nothing
        Me.ButtonSpecHeaderGroup2.Text = ""
        Me.ButtonSpecHeaderGroup2.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup2.UniqueName = "87A460CF9D2848DF87A460CF9D2848DF"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(23, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(177, 56)
        Me.ListBox1.TabIndex = 1
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.AutoSize = True
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.mskRangoFin)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.mskRangoIni)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.mskCantidad)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lbTipoDocumento)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.btnAceptar)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(674, 211)
        Me.KryptonHeaderGroup2.TabIndex = 3
        Me.KryptonHeaderGroup2.Text = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecHeaderGroup1.UniqueName = "774F78FB949F4E1E774F78FB949F4E1E"
        '
        'lbTipoDocumento
        '
        Me.lbTipoDocumento.FormattingEnabled = True
        Me.lbTipoDocumento.Location = New System.Drawing.Point(27, 28)
        Me.lbTipoDocumento.Name = "lbTipoDocumento"
        Me.lbTipoDocumento.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbTipoDocumento.Size = New System.Drawing.Size(177, 43)
        Me.lbTipoDocumento.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(266, 21)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'mskRangoFin
        '
        Me.mskRangoFin.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.mskRangoFin.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mskRangoFin.Location = New System.Drawing.Point(280, 93)
        Me.mskRangoFin.Mask = "99999999"
        Me.mskRangoFin.Name = "mskRangoFin"
        Me.mskRangoFin.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.mskRangoFin.RejectInputOnFirstFailure = True
        Me.mskRangoFin.Size = New System.Drawing.Size(54, 21)
        Me.mskRangoFin.TabIndex = 75
        Me.mskRangoFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskRangoFin.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskRangoIni
        '
        Me.mskRangoIni.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.mskRangoIni.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mskRangoIni.Location = New System.Drawing.Point(338, 66)
        Me.mskRangoIni.Mask = "99999999"
        Me.mskRangoIni.Name = "mskRangoIni"
        Me.mskRangoIni.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.mskRangoIni.RejectInputOnFirstFailure = True
        Me.mskRangoIni.Size = New System.Drawing.Size(54, 21)
        Me.mskRangoIni.TabIndex = 74
        Me.mskRangoIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskRangoIni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskCantidad
        '
        Me.mskCantidad.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.mskCantidad.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mskCantidad.Location = New System.Drawing.Point(280, 66)
        Me.mskCantidad.Mask = "99999999"
        Me.mskCantidad.Name = "mskCantidad"
        Me.mskCantidad.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.mskCantidad.RejectInputOnFirstFailure = True
        Me.mskCantidad.Size = New System.Drawing.Size(54, 21)
        Me.mskCantidad.TabIndex = 73
        Me.mskCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mskCantidad.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'dlgTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTipoDocumento"
        Me.Text = "Documentos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.stcVertical.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stcVertical.Panel1.ResumeLayout(False)
        Me.stcVertical.Panel1.PerformLayout()
        CType(Me.stcVertical.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stcVertical.Panel2.ResumeLayout(False)
        Me.stcVertical.Panel2.PerformLayout()
        CType(Me.stcVertical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stcVertical.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
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
    Friend WithEvents stcVertical As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lbTipoDocumento As System.Windows.Forms.ListBox
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents mskRangoFin As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents mskRangoIni As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents mskCantidad As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
End Class
