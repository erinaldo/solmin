<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarNrGuia
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarNrGuia))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnGrabar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.cboTipoGR = New System.Windows.Forms.ComboBox()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cboTipoGR)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonPanel.Controls.Add(Me.txtNroGuiaRemision)
        Me.KryptonPanel.Controls.Add(Me.btnGrabar)
        Me.KryptonPanel.Controls.Add(Me.btnCerrar)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(478, 171)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(13, 13)
        Me.KryptonLabel14.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(84, 24)
        Me.KryptonLabel14.TabIndex = 40
        Me.KryptonLabel14.Text = "Tipo Guía : "
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Tipo Guía : "
        '
        'txtNroGuiaRemision
        '
        Me.txtNroGuiaRemision.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtNroGuiaRemision.Location = New System.Drawing.Point(119, 48)
        Me.txtNroGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroGuiaRemision.Mask = "###-#######"
        Me.txtNroGuiaRemision.Name = "txtNroGuiaRemision"
        Me.txtNroGuiaRemision.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNroGuiaRemision.Size = New System.Drawing.Size(248, 26)
        Me.txtNroGuiaRemision.TabIndex = 38
        Me.txtNroGuiaRemision.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btnGrabar
        '
        Me.btnGrabar.AutoSize = True
        Me.btnGrabar.Location = New System.Drawing.Point(119, 89)
        Me.btnGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(131, 34)
        Me.btnGrabar.TabIndex = 36
        Me.btnGrabar.Text = "    Grabar"
        Me.btnGrabar.Values.ExtraText = ""
        Me.btnGrabar.Values.Image = CType(resources.GetObject("btnGrabar.Values.Image"), System.Drawing.Image)
        Me.btnGrabar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGrabar.Values.Text = "    Grabar"
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSize = True
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(247, 89)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(124, 34)
        Me.btnCerrar.TabIndex = 37
        Me.btnCerrar.Text = "    Cerrar"
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = CType(resources.GetObject("btnCerrar.Values.Image"), System.Drawing.Image)
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "    Cerrar"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(20, 51)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(84, 24)
        Me.KryptonLabel1.TabIndex = 34
        Me.KryptonLabel1.Text = "Nro. Guía :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Nro. Guía :"
        '
        'cboTipoGR
        '
        Me.cboTipoGR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoGR.FormattingEnabled = True
        Me.cboTipoGR.ItemHeight = 16
        Me.cboTipoGR.Location = New System.Drawing.Point(119, 13)
        Me.cboTipoGR.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTipoGR.Name = "cboTipoGR"
        Me.cboTipoGR.Size = New System.Drawing.Size(248, 24)
        Me.cboTipoGR.TabIndex = 41
        '
        'frmCambiarNrGuia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 171)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambiarNrGuia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Nr. Guía Remisión"
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
    Friend WithEvents btnGrabar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTipoGR As System.Windows.Forms.ComboBox
End Class
