<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucConductorTransportista_FConductor
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
        Me.txtConductor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.chkEnLaCadena = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCBRCNT = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.chkMientrasEscribe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblCBRCNT = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtStatusRecurso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblConductor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblStatusRecurso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.dgConductor = New Ransa.Controls.Transportista.ucConductorTransportista_DgF01
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgConductor)
        Me.KryptonPanel.Controls.Add(Me.txtConductor)
        Me.KryptonPanel.Controls.Add(Me.chkEnLaCadena)
        Me.KryptonPanel.Controls.Add(Me.btnSalir)
        Me.KryptonPanel.Controls.Add(Me.txtCBRCNT)
        Me.KryptonPanel.Controls.Add(Me.chkMientrasEscribe)
        Me.KryptonPanel.Controls.Add(Me.lblCBRCNT)
        Me.KryptonPanel.Controls.Add(Me.txtStatusRecurso)
        Me.KryptonPanel.Controls.Add(Me.lblConductor)
        Me.KryptonPanel.Controls.Add(Me.lblStatusRecurso)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(496, 377)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'txtConductor
        '
        Me.txtConductor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConductor.CausesValidation = False
        Me.txtConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtConductor, True)
        Me.txtConductor.Location = New System.Drawing.Point(89, 34)
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Size = New System.Drawing.Size(395, 22)
        Me.txtConductor.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtConductor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'chkEnLaCadena
        '
        Me.chkEnLaCadena.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnLaCadena.Location = New System.Drawing.Point(89, 88)
        Me.chkEnLaCadena.Name = "chkEnLaCadena"
        Me.chkEnLaCadena.Size = New System.Drawing.Size(92, 20)
        Me.chkEnLaCadena.TabIndex = 7
        Me.chkEnLaCadena.TabStop = False
        Me.chkEnLaCadena.Text = "En la cadena"
        Me.chkEnLaCadena.Values.ExtraText = ""
        Me.chkEnLaCadena.Values.Image = Nothing
        Me.chkEnLaCadena.Values.Text = "En la cadena"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(425, 84)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(59, 25)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "&Cerrar"
        Me.btnSalir.Values.ExtraText = ""
        Me.btnSalir.Values.Image = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSalir.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSalir.Values.Text = "&Cerrar"
        '
        'txtCBRCNT
        '
        Me.txtCBRCNT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCBRCNT.CausesValidation = False
        Me.txtCBRCNT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCBRCNT, True)
        Me.txtCBRCNT.Location = New System.Drawing.Point(89, 9)
        Me.txtCBRCNT.Name = "txtCBRCNT"
        Me.txtCBRCNT.Size = New System.Drawing.Size(395, 22)
        Me.txtCBRCNT.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtCBRCNT, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'chkMientrasEscribe
        '
        Me.chkMientrasEscribe.Checked = False
        Me.chkMientrasEscribe.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMientrasEscribe.Location = New System.Drawing.Point(184, 88)
        Me.chkMientrasEscribe.Name = "chkMientrasEscribe"
        Me.chkMientrasEscribe.Size = New System.Drawing.Size(128, 20)
        Me.chkMientrasEscribe.TabIndex = 7
        Me.chkMientrasEscribe.TabStop = False
        Me.chkMientrasEscribe.Text = "Mientras se escribe"
        Me.chkMientrasEscribe.Values.ExtraText = ""
        Me.chkMientrasEscribe.Values.Image = Nothing
        Me.chkMientrasEscribe.Values.Text = "Mientras se escribe"
        '
        'lblCBRCNT
        '
        Me.lblCBRCNT.Location = New System.Drawing.Point(3, 12)
        Me.lblCBRCNT.Name = "lblCBRCNT"
        Me.lblCBRCNT.Size = New System.Drawing.Size(60, 16)
        Me.lblCBRCNT.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCBRCNT.TabIndex = 1
        Me.lblCBRCNT.Text = "BREVETE : "
        Me.lblCBRCNT.Values.ExtraText = ""
        Me.lblCBRCNT.Values.Image = Nothing
        Me.lblCBRCNT.Values.Text = "BREVETE : "
        '
        'txtStatusRecurso
        '
        Me.txtStatusRecurso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatusRecurso.CausesValidation = False
        Me.txtStatusRecurso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtStatusRecurso, True)
        Me.txtStatusRecurso.Location = New System.Drawing.Point(89, 59)
        Me.txtStatusRecurso.Name = "txtStatusRecurso"
        Me.txtStatusRecurso.Size = New System.Drawing.Size(395, 22)
        Me.txtStatusRecurso.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtStatusRecurso, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblConductor
        '
        Me.lblConductor.Location = New System.Drawing.Point(3, 37)
        Me.lblConductor.Name = "lblConductor"
        Me.lblConductor.Size = New System.Drawing.Size(76, 16)
        Me.lblConductor.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblConductor.TabIndex = 3
        Me.lblConductor.Text = "CONDUCTOR :"
        Me.lblConductor.Values.ExtraText = ""
        Me.lblConductor.Values.Image = Nothing
        Me.lblConductor.Values.Text = "CONDUCTOR :"
        '
        'lblStatusRecurso
        '
        Me.lblStatusRecurso.Location = New System.Drawing.Point(3, 62)
        Me.lblStatusRecurso.Name = "lblStatusRecurso"
        Me.lblStatusRecurso.Size = New System.Drawing.Size(81, 16)
        Me.lblStatusRecurso.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblStatusRecurso.TabIndex = 5
        Me.lblStatusRecurso.Text = "&Propio / &Tercero"
        Me.lblStatusRecurso.Values.ExtraText = ""
        Me.lblStatusRecurso.Values.Image = Nothing
        Me.lblStatusRecurso.Values.Text = "&Propio / &Tercero"
        '
        'dgConductor
        '
        Me.dgConductor.BackColor = System.Drawing.Color.Transparent
        Me.dgConductor.Location = New System.Drawing.Point(0, 117)
        Me.dgConductor.Name = "dgConductor"
        Me.dgConductor.pNroRegPorPagina = 0
        Me.dgConductor.pPermitirSalirDoubleClick = False
        Me.dgConductor.Size = New System.Drawing.Size(496, 260)
        Me.dgConductor.TabIndex = 10
        '
        'ucConductorTransportista_FConductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(496, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "ucConductorTransportista_FConductor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar:"
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
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents txtCBRCNT As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents chkMientrasEscribe As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents lblCBRCNT As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtStatusRecurso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblConductor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblStatusRecurso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtConductor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents chkEnLaCadena As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dgConductor As Ransa.Controls.Transportista.ucConductorTransportista_DgF01
End Class
