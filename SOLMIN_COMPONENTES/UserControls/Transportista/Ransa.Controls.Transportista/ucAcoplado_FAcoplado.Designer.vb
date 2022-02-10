<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAcoplado_FAcoplado
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
    Me.txtMarcaModelo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.chkEnLaCadena = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.dgAcoplado = New Ransa.Controls.Transportista.ucAcoplado_DgF01
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.txtNPLCAC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.chkMientrasEscribe = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.lblNPLCAC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtTipoAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.lblMarcaModelo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblTipoAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.txtMarcaModelo)
    Me.KryptonPanel.Controls.Add(Me.chkEnLaCadena)
    Me.KryptonPanel.Controls.Add(Me.dgAcoplado)
    Me.KryptonPanel.Controls.Add(Me.btnSalir)
    Me.KryptonPanel.Controls.Add(Me.txtNPLCAC)
    Me.KryptonPanel.Controls.Add(Me.chkMientrasEscribe)
    Me.KryptonPanel.Controls.Add(Me.lblNPLCAC)
    Me.KryptonPanel.Controls.Add(Me.txtTipoAcoplado)
    Me.KryptonPanel.Controls.Add(Me.lblMarcaModelo)
    Me.KryptonPanel.Controls.Add(Me.lblTipoAcoplado)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(496, 377)
    Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel.TabIndex = 0
    '
    'txtMarcaModelo
    '
    Me.txtMarcaModelo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtMarcaModelo.CausesValidation = False
    Me.txtMarcaModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.TypeValidator.SetEnterTAB(Me.txtMarcaModelo, True)
    Me.txtMarcaModelo.Location = New System.Drawing.Point(89, 34)
    Me.txtMarcaModelo.Name = "txtMarcaModelo"
    Me.txtMarcaModelo.Size = New System.Drawing.Size(395, 21)
    Me.txtMarcaModelo.TabIndex = 4
    Me.TypeValidator.SetTypes(Me.txtMarcaModelo, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
    '
    'chkEnLaCadena
    '
    Me.chkEnLaCadena.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkEnLaCadena.Location = New System.Drawing.Point(89, 88)
    Me.chkEnLaCadena.Name = "chkEnLaCadena"
    Me.chkEnLaCadena.Size = New System.Drawing.Size(86, 19)
    Me.chkEnLaCadena.TabIndex = 7
    Me.chkEnLaCadena.TabStop = False
    Me.chkEnLaCadena.Text = "En la cadena"
    Me.chkEnLaCadena.Values.ExtraText = ""
    Me.chkEnLaCadena.Values.Image = Nothing
    Me.chkEnLaCadena.Values.Text = "En la cadena"
    '
    'dgAcoplado
    '
    Me.dgAcoplado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgAcoplado.BackColor = System.Drawing.Color.Transparent
    Me.dgAcoplado.Location = New System.Drawing.Point(0, 115)
    Me.dgAcoplado.Name = "dgAcoplado"
    Me.dgAcoplado.pNroRegPorPagina = 0
    Me.dgAcoplado.pPermitirSalirDoubleClick = False
    Me.dgAcoplado.Size = New System.Drawing.Size(496, 262)
    Me.dgAcoplado.TabIndex = 8
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
    'txtNPLCAC
    '
    Me.txtNPLCAC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtNPLCAC.CausesValidation = False
    Me.txtNPLCAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.TypeValidator.SetEnterTAB(Me.txtNPLCAC, True)
    Me.txtNPLCAC.Location = New System.Drawing.Point(89, 9)
    Me.txtNPLCAC.Name = "txtNPLCAC"
    Me.txtNPLCAC.Size = New System.Drawing.Size(395, 21)
    Me.txtNPLCAC.TabIndex = 2
    Me.TypeValidator.SetTypes(Me.txtNPLCAC, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
    '
    'chkMientrasEscribe
    '
    Me.chkMientrasEscribe.Checked = False
    Me.chkMientrasEscribe.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkMientrasEscribe.Location = New System.Drawing.Point(184, 88)
    Me.chkMientrasEscribe.Name = "chkMientrasEscribe"
    Me.chkMientrasEscribe.Size = New System.Drawing.Size(119, 19)
    Me.chkMientrasEscribe.TabIndex = 7
    Me.chkMientrasEscribe.TabStop = False
    Me.chkMientrasEscribe.Text = "Mientras se escribe"
    Me.chkMientrasEscribe.Values.ExtraText = ""
    Me.chkMientrasEscribe.Values.Image = Nothing
    Me.chkMientrasEscribe.Values.Text = "Mientras se escribe"
    '
    'lblNPLCAC
    '
    Me.lblNPLCAC.Location = New System.Drawing.Point(3, 12)
    Me.lblNPLCAC.Name = "lblNPLCAC"
    Me.lblNPLCAC.Size = New System.Drawing.Size(48, 16)
    Me.lblNPLCAC.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNPLCAC.TabIndex = 1
    Me.lblNPLCAC.Text = "PLACA : "
    Me.lblNPLCAC.Values.ExtraText = ""
    Me.lblNPLCAC.Values.Image = Nothing
    Me.lblNPLCAC.Values.Text = "PLACA : "
    '
    'txtTipoAcoplado
    '
    Me.txtTipoAcoplado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtTipoAcoplado.CausesValidation = False
    Me.txtTipoAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.TypeValidator.SetEnterTAB(Me.txtTipoAcoplado, True)
    Me.txtTipoAcoplado.Location = New System.Drawing.Point(89, 59)
    Me.txtTipoAcoplado.Name = "txtTipoAcoplado"
    Me.txtTipoAcoplado.Size = New System.Drawing.Size(395, 21)
    Me.txtTipoAcoplado.TabIndex = 6
    Me.TypeValidator.SetTypes(Me.txtTipoAcoplado, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
    '
    'lblMarcaModelo
    '
    Me.lblMarcaModelo.Location = New System.Drawing.Point(3, 37)
    Me.lblMarcaModelo.Name = "lblMarcaModelo"
    Me.lblMarcaModelo.Size = New System.Drawing.Size(57, 16)
    Me.lblMarcaModelo.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblMarcaModelo.TabIndex = 3
    Me.lblMarcaModelo.Text = "MODELO :"
    Me.lblMarcaModelo.Values.ExtraText = ""
    Me.lblMarcaModelo.Values.Image = Nothing
    Me.lblMarcaModelo.Values.Text = "MODELO :"
    '
    'lblTipoAcoplado
    '
    Me.lblTipoAcoplado.Location = New System.Drawing.Point(3, 62)
    Me.lblTipoAcoplado.Name = "lblTipoAcoplado"
    Me.lblTipoAcoplado.Size = New System.Drawing.Size(38, 16)
    Me.lblTipoAcoplado.StateCommon.ShortText.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
    Me.lblTipoAcoplado.TabIndex = 5
    Me.lblTipoAcoplado.Text = "TIPO : "
    Me.lblTipoAcoplado.Values.ExtraText = ""
    Me.lblTipoAcoplado.Values.Image = Nothing
    Me.lblTipoAcoplado.Values.Text = "TIPO : "
    '
    'ucAcoplado_FAcoplado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnSalir
    Me.ClientSize = New System.Drawing.Size(496, 377)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "ucAcoplado_FAcoplado"
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
    Private WithEvents txtNPLCAC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents chkMientrasEscribe As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Private WithEvents lblNPLCAC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtTipoAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblMarcaModelo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblTipoAcoplado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtMarcaModelo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents dgAcoplado As Ransa.Controls.Transportista.ucAcoplado_DgF01
    Private WithEvents chkEnLaCadena As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
