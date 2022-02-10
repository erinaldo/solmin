<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWRegimen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWRegimen))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtdua = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtanioaduana = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.lblregimen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtaduana = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaAduana = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lbladuana = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblaniodua = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbldua = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.rbAduanero = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbSimple = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtdua)
        Me.KryptonPanel.Controls.Add(Me.txtanioaduana)
        Me.KryptonPanel.Controls.Add(Me.lblregimen)
        Me.KryptonPanel.Controls.Add(Me.txtaduana)
        Me.KryptonPanel.Controls.Add(Me.lbladuana)
        Me.KryptonPanel.Controls.Add(Me.lblaniodua)
        Me.KryptonPanel.Controls.Add(Me.lbldua)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.rbAduanero)
        Me.KryptonPanel.Controls.Add(Me.rbSimple)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(295, 128)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'txtdua
        '
        Me.txtdua.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtdua.Location = New System.Drawing.Point(96, 43)
        Me.txtdua.Mask = "##########"
        Me.txtdua.Name = "txtdua"
        Me.txtdua.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtdua.Size = New System.Drawing.Size(70, 19)
        Me.txtdua.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdua.TabIndex = 2
        '
        'txtanioaduana
        '
        Me.txtanioaduana.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtanioaduana.Location = New System.Drawing.Point(229, 43)
        Me.txtanioaduana.Mask = "####"
        Me.txtanioaduana.Name = "txtanioaduana"
        Me.txtanioaduana.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtanioaduana.Size = New System.Drawing.Size(54, 19)
        Me.txtanioaduana.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtanioaduana.TabIndex = 3
        '
        'lblregimen
        '
        Me.lblregimen.Location = New System.Drawing.Point(33, 102)
        Me.lblregimen.Name = "lblregimen"
        Me.lblregimen.Size = New System.Drawing.Size(56, 16)
        Me.lblregimen.TabIndex = 99
        Me.lblregimen.Text = "Regimen"
        Me.lblregimen.Values.ExtraText = ""
        Me.lblregimen.Values.Image = Nothing
        Me.lblregimen.Values.Text = "Regimen"
        Me.lblregimen.Visible = False
        '
        'txtaduana
        '
        Me.txtaduana.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaAduana})
        Me.txtaduana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtaduana.Location = New System.Drawing.Point(96, 68)
        Me.txtaduana.MaxLength = 10
        Me.txtaduana.Name = "txtaduana"
        Me.txtaduana.Size = New System.Drawing.Size(186, 19)
        Me.txtaduana.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtaduana.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtaduana.TabIndex = 4
        '
        'bsaAduana
        '
        Me.bsaAduana.ExtraText = ""
        Me.bsaAduana.Image = Nothing
        Me.bsaAduana.Text = ""
        Me.bsaAduana.ToolTipImage = Nothing
        Me.bsaAduana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaAduana.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'lbladuana
        '
        Me.lbladuana.Location = New System.Drawing.Point(12, 71)
        Me.lbladuana.Name = "lbladuana"
        Me.lbladuana.Size = New System.Drawing.Size(68, 16)
        Me.lbladuana.TabIndex = 95
        Me.lbladuana.Text = "N° Aduana:"
        Me.lbladuana.Values.ExtraText = ""
        Me.lbladuana.Values.Image = Nothing
        Me.lbladuana.Values.Text = "N° Aduana:"
        '
        'lblaniodua
        '
        Me.lblaniodua.Location = New System.Drawing.Point(190, 43)
        Me.lblaniodua.Name = "lblaniodua"
        Me.lblaniodua.Size = New System.Drawing.Size(33, 16)
        Me.lblaniodua.TabIndex = 94
        Me.lblaniodua.Text = "Año:"
        Me.lblaniodua.Values.ExtraText = ""
        Me.lblaniodua.Values.Image = Nothing
        Me.lblaniodua.Values.Text = "Año:"
        '
        'lbldua
        '
        Me.lbldua.Location = New System.Drawing.Point(12, 46)
        Me.lbldua.Name = "lbldua"
        Me.lbldua.Size = New System.Drawing.Size(59, 16)
        Me.lbldua.TabIndex = 93
        Me.lbldua.Text = "N° D.U.A:"
        Me.lbldua.Values.ExtraText = ""
        Me.lbldua.Values.Image = Nothing
        Me.lbldua.Values.Text = "N° D.U.A:"
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(202, 93)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 25)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = CType(resources.GetObject("btnAceptar.Values.Image"), System.Drawing.Image)
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'rbAduanero
        '
        Me.rbAduanero.Location = New System.Drawing.Point(171, 12)
        Me.rbAduanero.Name = "rbAduanero"
        Me.rbAduanero.Size = New System.Drawing.Size(120, 16)
        Me.rbAduanero.TabIndex = 1
        Me.rbAduanero.Text = "Regimen Aduanero"
        Me.rbAduanero.Values.ExtraText = ""
        Me.rbAduanero.Values.Image = Nothing
        Me.rbAduanero.Values.Text = "Regimen Aduanero"
        '
        'rbSimple
        '
        Me.rbSimple.Location = New System.Drawing.Point(12, 12)
        Me.rbSimple.Name = "rbSimple"
        Me.rbSimple.Size = New System.Drawing.Size(105, 16)
        Me.rbSimple.TabIndex = 0
        Me.rbSimple.Text = "Regimen Simple"
        Me.rbSimple.Values.ExtraText = ""
        Me.rbSimple.Values.Image = Nothing
        Me.rbSimple.Values.Text = "Regimen Simple"
        '
        'frmRegimen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAceptar
        Me.ClientSize = New System.Drawing.Size(295, 128)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRegimen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regimen"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents rbSimple As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbAduanero As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents lblregimen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtaduana As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaAduana As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lbladuana As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblaniodua As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lbldua As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtdua As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txtanioaduana As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
End Class
