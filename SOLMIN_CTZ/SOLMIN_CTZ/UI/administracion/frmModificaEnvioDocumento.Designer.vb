<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificaEnvioDocumento
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lblImporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.lblNroCobranza = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNombreNro = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.txtCliente = New System.Windows.Forms.MaskedTextBox
        Me.txtCobrador = New System.Windows.Forms.MaskedTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblEstados = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblEstadoCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblEstadoCobrador = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNumero = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(328, 286)
        Me.KryptonPanel.TabIndex = 0
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(109, 100)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(62, 19)
        Me.lblImporte.TabIndex = 6
        Me.lblImporte.Text = "lblImporte"
        Me.lblImporte.Values.ExtraText = ""
        Me.lblImporte.Values.Image = Nothing
        Me.lblImporte.Values.Text = "lblImporte"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.ToolStrip2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblNroCobranza)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblNombreNro)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblImporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblNumero)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblTipo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(328, 286)
        Me.KryptonHeaderGroup1.TabIndex = 11
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Seguimiento"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'lblNroCobranza
        '
        Me.lblNroCobranza.Location = New System.Drawing.Point(109, 122)
        Me.lblNroCobranza.Name = "lblNroCobranza"
        Me.lblNroCobranza.Size = New System.Drawing.Size(77, 19)
        Me.lblNroCobranza.TabIndex = 15
        Me.lblNroCobranza.Text = "NroCobranza"
        Me.lblNroCobranza.Values.ExtraText = ""
        Me.lblNroCobranza.Values.Image = Nothing
        Me.lblNroCobranza.Values.Text = "NroCobranza"
        '
        'lblNombreNro
        '
        Me.lblNombreNro.Location = New System.Drawing.Point(21, 122)
        Me.lblNombreNro.Name = "lblNombreNro"
        Me.lblNombreNro.Size = New System.Drawing.Size(85, 19)
        Me.lblNombreNro.TabIndex = 14
        Me.lblNombreNro.Text = "Nro Cobranza : "
        Me.lblNombreNro.Values.ExtraText = ""
        Me.lblNombreNro.Values.Image = Nothing
        Me.lblNombreNro.Values.Text = "Nro Cobranza : "
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(18, 163)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtCobrador)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblEstados)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblEstadoCliente)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblEstadoCobrador)
        Me.KryptonGroup1.Size = New System.Drawing.Size(270, 92)
        Me.KryptonGroup1.TabIndex = 13
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(181, 57)
        Me.txtCliente.Mask = "00/00/0000"
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(72, 20)
        Me.txtCliente.TabIndex = 19
        Me.txtCliente.ValidatingType = GetType(Date)
        '
        'txtCobrador
        '
        Me.txtCobrador.Location = New System.Drawing.Point(181, 31)
        Me.txtCobrador.Mask = "00/00/0000"
        Me.txtCobrador.Name = "txtCobrador"
        Me.txtCobrador.Size = New System.Drawing.Size(72, 20)
        Me.txtCobrador.TabIndex = 18
        Me.txtCobrador.ValidatingType = GetType(Date)
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(181, 9)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(43, 16)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 17
        Me.KryptonLabel2.Text = "Fecha"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha"
        '
        'lblEstados
        '
        Me.lblEstados.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1
        Me.lblEstados.Location = New System.Drawing.Point(3, 9)
        Me.lblEstados.Name = "lblEstados"
        Me.lblEstados.Size = New System.Drawing.Size(53, 16)
        Me.lblEstados.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstados.TabIndex = 7
        Me.lblEstados.Text = "Estados"
        Me.lblEstados.Values.ExtraText = ""
        Me.lblEstados.Values.Image = Nothing
        Me.lblEstados.Values.Text = "Estados"
        '
        'lblEstadoCliente
        '
        Me.lblEstadoCliente.Location = New System.Drawing.Point(3, 56)
        Me.lblEstadoCliente.Name = "lblEstadoCliente"
        Me.lblEstadoCliente.Size = New System.Drawing.Size(60, 19)
        Me.lblEstadoCliente.TabIndex = 12
        Me.lblEstadoCliente.Text = "En Cliente"
        Me.lblEstadoCliente.Values.ExtraText = ""
        Me.lblEstadoCliente.Values.Image = Nothing
        Me.lblEstadoCliente.Values.Text = "En Cliente"
        '
        'lblEstadoCobrador
        '
        Me.lblEstadoCobrador.Location = New System.Drawing.Point(3, 30)
        Me.lblEstadoCobrador.Name = "lblEstadoCobrador"
        Me.lblEstadoCobrador.Size = New System.Drawing.Size(73, 19)
        Me.lblEstadoCobrador.TabIndex = 10
        Me.lblEstadoCobrador.Text = "En Cobrador"
        Me.lblEstadoCobrador.Values.ExtraText = ""
        Me.lblEstadoCobrador.Values.Image = Nothing
        Me.lblEstadoCobrador.Values.Text = "En Cobrador"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(21, 100)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel4.TabIndex = 5
        Me.KryptonLabel4.Text = "Importe : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Importe : "
        '
        'lblNumero
        '
        Me.lblNumero.Location = New System.Drawing.Point(109, 79)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(63, 19)
        Me.lblNumero.TabIndex = 4
        Me.lblNumero.Text = "lblNumero"
        Me.lblNumero.Values.ExtraText = ""
        Me.lblNumero.Values.Image = Nothing
        Me.lblNumero.Values.Text = "lblNumero"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(21, 79)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel5.TabIndex = 1
        Me.KryptonLabel5.Text = "Número : "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Número : "
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(109, 58)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(44, 19)
        Me.lblTipo.TabIndex = 3
        Me.lblTipo.Text = "lblTipo"
        Me.lblTipo.Values.ExtraText = ""
        Me.lblTipo.Values.Image = Nothing
        Me.lblTipo.Values.Text = "lblTipo"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(21, 58)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(38, 19)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Tipo : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo : "
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(109, 37)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(57, 19)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "lblCliente"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "lblCliente"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(21, 37)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(328, 286)
        Me.KryptonPanel1.TabIndex = 10
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnAceptar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(326, 25)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(49, 22)
        Me.btnCancelar.Text = "Salir"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmModificaEnvioDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 286)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModificaEnvioDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Envio Documento"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Friend WithEvents lblImporte As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lblNroCobranza As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNombreNro As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblEstados As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblEstadoCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblEstadoCobrador As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNumero As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtCliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCobrador As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
End Class
