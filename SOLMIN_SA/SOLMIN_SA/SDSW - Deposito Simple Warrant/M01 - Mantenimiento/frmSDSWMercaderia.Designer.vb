<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWMercaderia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWMercaderia))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.lblcodproducto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtproducto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaproducto = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblcodfamilia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtfamilia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsafamilia = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnProcesa = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblcodcliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblMensajeMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaClienteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(538, 175)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblcodproducto)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtproducto)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblcodfamilia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtfamilia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnCancelar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnProcesa)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblcodcliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.PictureBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblMensajeMercaderia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(538, 175)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 37
        Me.KryptonHeaderGroup1.Text = "Mercaderia"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Mercaderia"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'lblcodproducto
        '
        Me.lblcodproducto.Location = New System.Drawing.Point(72, 72)
        Me.lblcodproducto.Name = "lblcodproducto"
        Me.lblcodproducto.Size = New System.Drawing.Size(14, 16)
        Me.lblcodproducto.StateCommon.ShortText.Color1 = System.Drawing.Color.MidnightBlue
        Me.lblcodproducto.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodproducto.TabIndex = 150
        Me.lblcodproducto.Text = "-"
        Me.lblcodproducto.Values.ExtraText = ""
        Me.lblcodproducto.Values.Image = Nothing
        Me.lblcodproducto.Values.Text = "-"
        '
        'txtproducto
        '
        Me.txtproducto.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaproducto})
        Me.txtproducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtproducto.Location = New System.Drawing.Point(159, 70)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(226, 21)
        Me.txtproducto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtproducto.TabIndex = 149
        '
        'bsaproducto
        '
        Me.bsaproducto.ExtraText = ""
        Me.bsaproducto.Image = Nothing
        Me.bsaproducto.Text = ""
        Me.bsaproducto.ToolTipImage = Nothing
        Me.bsaproducto.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaproducto.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'lblcodfamilia
        '
        Me.lblcodfamilia.Location = New System.Drawing.Point(87, 42)
        Me.lblcodfamilia.Name = "lblcodfamilia"
        Me.lblcodfamilia.Size = New System.Drawing.Size(14, 16)
        Me.lblcodfamilia.StateCommon.ShortText.Color1 = System.Drawing.Color.MidnightBlue
        Me.lblcodfamilia.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodfamilia.TabIndex = 148
        Me.lblcodfamilia.Text = "-"
        Me.lblcodfamilia.Values.ExtraText = ""
        Me.lblcodfamilia.Values.Image = Nothing
        Me.lblcodfamilia.Values.Text = "-"
        '
        'txtfamilia
        '
        Me.txtfamilia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsafamilia})
        Me.txtfamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfamilia.Location = New System.Drawing.Point(159, 42)
        Me.txtfamilia.MaxLength = 50
        Me.txtfamilia.Name = "txtfamilia"
        Me.txtfamilia.Size = New System.Drawing.Size(226, 21)
        Me.txtfamilia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtfamilia.TabIndex = 147
        '
        'bsafamilia
        '
        Me.bsafamilia.ExtraText = ""
        Me.bsafamilia.Image = Nothing
        Me.bsafamilia.Text = ""
        Me.bsafamilia.ToolTipImage = Nothing
        Me.bsafamilia.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsafamilia.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(265, 115)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 25)
        Me.btnCancelar.TabIndex = 146
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnProcesa
        '
        Me.btnProcesa.Location = New System.Drawing.Point(159, 115)
        Me.btnProcesa.Name = "btnProcesa"
        Me.btnProcesa.Size = New System.Drawing.Size(100, 25)
        Me.btnProcesa.TabIndex = 145
        Me.btnProcesa.Text = "Aceptar"
        Me.btnProcesa.Values.ExtraText = ""
        Me.btnProcesa.Values.Image = CType(resources.GetObject("btnProcesa.Values.Image"), System.Drawing.Image)
        Me.btnProcesa.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesa.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesa.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesa.Values.Text = "Aceptar"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(14, 70)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(61, 19)
        Me.KryptonLabel3.TabIndex = 144
        Me.KryptonLabel3.Text = "Producto : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Producto : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(14, 42)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(51, 19)
        Me.KryptonLabel1.TabIndex = 142
        Me.KryptonLabel1.Text = "Familia : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Familia : "
        '
        'lblcodcliente
        '
        Me.lblcodcliente.Location = New System.Drawing.Point(86, 21)
        Me.lblcodcliente.Name = "lblcodcliente"
        Me.lblcodcliente.Size = New System.Drawing.Size(14, 16)
        Me.lblcodcliente.StateCommon.ShortText.Color1 = System.Drawing.Color.MidnightBlue
        Me.lblcodcliente.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodcliente.TabIndex = 133
        Me.lblcodcliente.Text = "-"
        Me.lblcodcliente.Values.ExtraText = ""
        Me.lblcodcliente.Values.Image = Nothing
        Me.lblcodcliente.Values.Text = "-"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(406, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 131
        Me.PictureBox1.TabStop = False
        '
        'lblMensajeMercaderia
        '
        Me.lblMensajeMercaderia.Location = New System.Drawing.Point(159, 95)
        Me.lblMensajeMercaderia.Name = "lblMensajeMercaderia"
        Me.lblMensajeMercaderia.Size = New System.Drawing.Size(12, 14)
        Me.lblMensajeMercaderia.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMensajeMercaderia.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeMercaderia.TabIndex = 37
        Me.lblMensajeMercaderia.Text = "."
        Me.lblMensajeMercaderia.Values.ExtraText = ""
        Me.lblMensajeMercaderia.Values.Image = Nothing
        Me.lblMensajeMercaderia.Values.Text = "."
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(14, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(60, 16)
        Me.lblCliente.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.TabIndex = 27
        Me.lblCliente.Text = "CLIENTE"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "CLIENTE"
        '
        'txtCliente
        '
        Me.txtCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaClienteListar})
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(159, 17)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(226, 21)
        Me.txtCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.TabIndex = 29
        '
        'bsaClienteListar
        '
        Me.bsaClienteListar.ExtraText = ""
        Me.bsaClienteListar.Image = Nothing
        Me.bsaClienteListar.Text = ""
        Me.bsaClienteListar.ToolTipImage = Nothing
        Me.bsaClienteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaClienteListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'frmSDSWMercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 175)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSDSWMercaderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StateCommon.Back.Color1 = System.Drawing.Color.White
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaClienteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lblMensajeMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcodcliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnProcesa As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtfamilia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsafamilia As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblcodfamilia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblcodproducto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtproducto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaproducto As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
End Class
