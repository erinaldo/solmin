<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteDestino
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
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.grpMensajeInformativo = New System.Windows.Forms.GroupBox
        Me.lblMensajeOCCM2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMensajeOCCM1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMensajeOCSM2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMensajeOCSM1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpMensajeInformativo.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtCliente)
        Me.KryptonPanel.Controls.Add(Me.grpMensajeInformativo)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.lblCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(432, 174)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(66, 12)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pUsuario = ""
        Me.txtCliente.Size = New System.Drawing.Size(355, 19)
        Me.txtCliente.TabIndex = 1
        '
        'grpMensajeInformativo
        '
        Me.grpMensajeInformativo.BackColor = System.Drawing.Color.Transparent
        Me.grpMensajeInformativo.Controls.Add(Me.lblMensajeOCCM2)
        Me.grpMensajeInformativo.Controls.Add(Me.lblMensajeOCCM1)
        Me.grpMensajeInformativo.Controls.Add(Me.lblMensajeOCSM2)
        Me.grpMensajeInformativo.Controls.Add(Me.lblMensajeOCSM1)
        Me.grpMensajeInformativo.Location = New System.Drawing.Point(8, 75)
        Me.grpMensajeInformativo.Name = "grpMensajeInformativo"
        Me.grpMensajeInformativo.Size = New System.Drawing.Size(412, 87)
        Me.grpMensajeInformativo.TabIndex = 4
        Me.grpMensajeInformativo.TabStop = False
        '
        'lblMensajeOCCM2
        '
        Me.lblMensajeOCCM2.Location = New System.Drawing.Point(23, 64)
        Me.lblMensajeOCCM2.Name = "lblMensajeOCCM2"
        Me.lblMensajeOCCM2.Size = New System.Drawing.Size(268, 16)
        Me.lblMensajeOCCM2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMensajeOCCM2.TabIndex = 8
        Me.lblMensajeOCCM2.Text = "registrada con el Código del Cliente proporcionado."
        Me.lblMensajeOCCM2.Values.ExtraText = ""
        Me.lblMensajeOCCM2.Values.Image = Nothing
        Me.lblMensajeOCCM2.Values.Text = "registrada con el Código del Cliente proporcionado."
        '
        'lblMensajeOCCM1
        '
        Me.lblMensajeOCCM1.Location = New System.Drawing.Point(4, 51)
        Me.lblMensajeOCCM1.Name = "lblMensajeOCCM1"
        Me.lblMensajeOCCM1.Size = New System.Drawing.Size(377, 16)
        Me.lblMensajeOCCM1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMensajeOCCM1.TabIndex = 7
        Me.lblMensajeOCCM1.Text = "(**)  Si la O/C posee movimiento, se procede a copiar toda la información "
        Me.lblMensajeOCCM1.Values.ExtraText = ""
        Me.lblMensajeOCCM1.Values.Image = Nothing
        Me.lblMensajeOCCM1.Values.Text = "(**)  Si la O/C posee movimiento, se procede a copiar toda la información "
        '
        'lblMensajeOCSM2
        '
        Me.lblMensajeOCSM2.Location = New System.Drawing.Point(23, 29)
        Me.lblMensajeOCSM2.Name = "lblMensajeOCSM2"
        Me.lblMensajeOCSM2.Size = New System.Drawing.Size(155, 16)
        Me.lblMensajeOCSM2.StateCommon.ShortText.Color1 = System.Drawing.Color.Green
        Me.lblMensajeOCSM2.TabIndex = 6
        Me.lblMensajeOCSM2.Text = "con el Codigo proporcionado"
        Me.lblMensajeOCSM2.Values.ExtraText = ""
        Me.lblMensajeOCSM2.Values.Image = Nothing
        Me.lblMensajeOCSM2.Values.Text = "con el Codigo proporcionado"
        '
        'lblMensajeOCSM1
        '
        Me.lblMensajeOCSM1.Location = New System.Drawing.Point(4, 16)
        Me.lblMensajeOCSM1.Name = "lblMensajeOCSM1"
        Me.lblMensajeOCSM1.Size = New System.Drawing.Size(409, 16)
        Me.lblMensajeOCSM1.StateCommon.ShortText.Color1 = System.Drawing.Color.Green
        Me.lblMensajeOCSM1.TabIndex = 5
        Me.lblMensajeOCSM1.Text = "(*)  Si la O/C no posee movimiento, se procede a cambiar  el Código del Cliente"
        Me.lblMensajeOCSM1.Values.ExtraText = ""
        Me.lblMensajeOCSM1.Values.Image = Nothing
        Me.lblMensajeOCSM1.Values.Text = "(*)  Si la O/C no posee movimiento, se procede a cambiar  el Código del Cliente"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(331, 44)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(235, 44)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(8, 15)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 16)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'frmClienteDestino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(432, 174)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmClienteDestino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Cliente Destino"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.grpMensajeInformativo.ResumeLayout(False)
        Me.grpMensajeInformativo.PerformLayout()
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
    Friend WithEvents lblMensajeOCCM2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMensajeOCCM1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMensajeOCSM2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMensajeOCSM1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Private WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents grpMensajeInformativo As System.Windows.Forms.GroupBox
End Class
