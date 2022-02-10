<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTransportista_FTransportista
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
        Me.chkEnLaCadena = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.dgTransportista = New Ransa.Controls.Transportista.ucTransportista_DgF01
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtNRUCTR = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.chkMientrasEscribe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblNRUCTR = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodRNS = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblRazonSocial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCodRNS = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRazonSocial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtRazonSocial)
        Me.KryptonPanel.Controls.Add(Me.chkEnLaCadena)
        Me.KryptonPanel.Controls.Add(Me.dgTransportista)
        Me.KryptonPanel.Controls.Add(Me.btnSalir)
        Me.KryptonPanel.Controls.Add(Me.txtNRUCTR)
        Me.KryptonPanel.Controls.Add(Me.chkMientrasEscribe)
        Me.KryptonPanel.Controls.Add(Me.lblNRUCTR)
        Me.KryptonPanel.Controls.Add(Me.txtCodRNS)
        Me.KryptonPanel.Controls.Add(Me.lblRazonSocial)
        Me.KryptonPanel.Controls.Add(Me.lblCodRNS)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(496, 377)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'chkEnLaCadena
        '
        Me.chkEnLaCadena.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnLaCadena.Location = New System.Drawing.Point(89, 88)
        Me.chkEnLaCadena.Name = "chkEnLaCadena"
        Me.chkEnLaCadena.Size = New System.Drawing.Size(89, 16)
        Me.chkEnLaCadena.TabIndex = 7
        Me.chkEnLaCadena.TabStop = False
        Me.chkEnLaCadena.Text = "En la cadena"
        Me.chkEnLaCadena.Values.ExtraText = ""
        Me.chkEnLaCadena.Values.Image = Nothing
        Me.chkEnLaCadena.Values.Text = "En la cadena"
        '
        'dgTransportista
        '
        Me.dgTransportista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTransportista.BackColor = System.Drawing.Color.Transparent
        Me.dgTransportista.Location = New System.Drawing.Point(0, 115)
        Me.dgTransportista.Name = "dgTransportista"
        Me.dgTransportista.pPermitirSalirDoubleClick = False
        Me.dgTransportista.Size = New System.Drawing.Size(496, 262)
        Me.dgTransportista.TabIndex = 8
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
        'txtNRUCTR
        '
        Me.txtNRUCTR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNRUCTR.CausesValidation = False
        Me.txtNRUCTR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNRUCTR, True)
        Me.txtNRUCTR.Location = New System.Drawing.Point(89, 9)
        Me.txtNRUCTR.Name = "txtNRUCTR"
        Me.txtNRUCTR.Size = New System.Drawing.Size(395, 19)
        Me.txtNRUCTR.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtNRUCTR, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'chkMientrasEscribe
        '
        Me.chkMientrasEscribe.Checked = False
        Me.chkMientrasEscribe.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMientrasEscribe.Location = New System.Drawing.Point(184, 88)
        Me.chkMientrasEscribe.Name = "chkMientrasEscribe"
        Me.chkMientrasEscribe.Size = New System.Drawing.Size(121, 16)
        Me.chkMientrasEscribe.TabIndex = 7
        Me.chkMientrasEscribe.TabStop = False
        Me.chkMientrasEscribe.Text = "Mientras se escribe"
        Me.chkMientrasEscribe.Values.ExtraText = ""
        Me.chkMientrasEscribe.Values.Image = Nothing
        Me.chkMientrasEscribe.Values.Text = "Mientras se escribe"
        '
        'lblNRUCTR
        '
        Me.lblNRUCTR.Location = New System.Drawing.Point(3, 12)
        Me.lblNRUCTR.Name = "lblNRUCTR"
        Me.lblNRUCTR.Size = New System.Drawing.Size(44, 16)
        Me.lblNRUCTR.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRUCTR.TabIndex = 1
        Me.lblNRUCTR.Text = "R.U.C. : "
        Me.lblNRUCTR.Values.ExtraText = ""
        Me.lblNRUCTR.Values.Image = Nothing
        Me.lblNRUCTR.Values.Text = "R.U.C. : "
        '
        'txtCodRNS
        '
        Me.txtCodRNS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodRNS.CausesValidation = False
        Me.txtCodRNS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCodRNS, True)
        Me.txtCodRNS.Location = New System.Drawing.Point(89, 59)
        Me.txtCodRNS.Name = "txtCodRNS"
        Me.txtCodRNS.Size = New System.Drawing.Size(395, 19)
        Me.txtCodRNS.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtCodRNS, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.Location = New System.Drawing.Point(3, 37)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(87, 16)
        Me.lblRazonSocial.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRazonSocial.TabIndex = 3
        Me.lblRazonSocial.Text = "RAZÓN SOCIAL : "
        Me.lblRazonSocial.Values.ExtraText = ""
        Me.lblRazonSocial.Values.Image = Nothing
        Me.lblRazonSocial.Values.Text = "RAZÓN SOCIAL : "
        '
        'lblCodRNS
        '
        Me.lblCodRNS.Location = New System.Drawing.Point(3, 62)
        Me.lblCodRNS.Name = "lblCodRNS"
        Me.lblCodRNS.Size = New System.Drawing.Size(76, 16)
        Me.lblCodRNS.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCodRNS.TabIndex = 5
        Me.lblCodRNS.Text = "CÓDIGO RNS : "
        Me.lblCodRNS.Values.ExtraText = ""
        Me.lblCodRNS.Values.Image = Nothing
        Me.lblCodRNS.Values.Text = "CÓDIGO RNS : "
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRazonSocial.CausesValidation = False
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtRazonSocial, True)
        Me.txtRazonSocial.Location = New System.Drawing.Point(89, 34)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(395, 19)
        Me.txtRazonSocial.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtRazonSocial, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'ucTransportista_FTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(496, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "ucTransportista_FTransportista"
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
    Private WithEvents txtNRUCTR As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents chkMientrasEscribe As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents lblNRUCTR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCodRNS As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblRazonSocial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblCodRNS As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtRazonSocial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents dgTransportista As Ransa.Controls.Transportista.ucTransportista_DgF01
    Private WithEvents chkEnLaCadena As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
