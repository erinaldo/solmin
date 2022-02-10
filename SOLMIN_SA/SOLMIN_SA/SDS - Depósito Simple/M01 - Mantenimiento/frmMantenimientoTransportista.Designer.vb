<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoTransportista
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtDesCompleto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDesAbreviado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_TPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDireccion2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDireccion1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtContacto2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtContacto1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtfax = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtfono2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtfono1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNRegIndustrial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtRegMercantil = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCargo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtLE = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRuc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.lbl_CPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_NRUCPR = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(472, 441)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.txtDesCompleto)
        Me.KryptonPanel1.Controls.Add(Me.txtDesAbreviado)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.lbl_TPRVCL)
        Me.KryptonPanel1.Controls.Add(Me.GroupBox2)
        Me.KryptonPanel1.Controls.Add(Me.txtNRegIndustrial)
        Me.KryptonPanel1.Controls.Add(Me.txtRegMercantil)
        Me.KryptonPanel1.Controls.Add(Me.txtCargo)
        Me.KryptonPanel1.Controls.Add(Me.txtLE)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel12)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.txtRuc)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.txtCliente)
        Me.KryptonPanel1.Controls.Add(Me.lbl_CPRVCL)
        Me.KryptonPanel1.Controls.Add(Me.txtCodigo)
        Me.KryptonPanel1.Controls.Add(Me.lbl_NRUCPR)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm
        Me.KryptonPanel1.Size = New System.Drawing.Size(472, 416)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 61
        '
        'txtDesCompleto
        '
        Me.txtDesCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesCompleto.Location = New System.Drawing.Point(100, 59)
        Me.txtDesCompleto.MaxLength = 30
        Me.txtDesCompleto.Name = "txtDesCompleto"
        Me.txtDesCompleto.Size = New System.Drawing.Size(353, 19)
        Me.txtDesCompleto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesCompleto.TabIndex = 70
        '
        'txtDesAbreviado
        '
        Me.txtDesAbreviado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesAbreviado.Location = New System.Drawing.Point(100, 84)
        Me.txtDesAbreviado.MaxLength = 10
        Me.txtDesAbreviado.Name = "txtDesAbreviado"
        Me.txtDesAbreviado.Size = New System.Drawing.Size(166, 19)
        Me.txtDesAbreviado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtDesAbreviado.TabIndex = 80
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 87)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(93, 16)
        Me.KryptonLabel2.TabIndex = 95
        Me.KryptonLabel2.Text = "Desc Abreviado: "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Desc Abreviado: "
        '
        'lbl_TPRVCL
        '
        Me.lbl_TPRVCL.Location = New System.Drawing.Point(12, 62)
        Me.lbl_TPRVCL.Name = "lbl_TPRVCL"
        Me.lbl_TPRVCL.Size = New System.Drawing.Size(94, 16)
        Me.lbl_TPRVCL.TabIndex = 92
        Me.lbl_TPRVCL.Text = "Desc. Completa: "
        Me.lbl_TPRVCL.Values.ExtraText = ""
        Me.lbl_TPRVCL.Values.Image = Nothing
        Me.lbl_TPRVCL.Values.Text = "Desc. Completa: "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtDireccion2)
        Me.GroupBox2.Controls.Add(Me.txtDireccion1)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel3)
        Me.GroupBox2.Controls.Add(Me.txtContacto2)
        Me.GroupBox2.Controls.Add(Me.txtContacto1)
        Me.GroupBox2.Controls.Add(Me.txtfax)
        Me.GroupBox2.Controls.Add(Me.txtfono2)
        Me.GroupBox2.Controls.Add(Me.txtfono1)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel11)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel10)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel9)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel8)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 179)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Referencia"
        '
        'txtDireccion2
        '
        Me.txtDireccion2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion2.Location = New System.Drawing.Point(82, 41)
        Me.txtDireccion2.MaxLength = 30
        Me.txtDireccion2.Name = "txtDireccion2"
        Me.txtDireccion2.Size = New System.Drawing.Size(359, 19)
        Me.txtDireccion2.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtDireccion2.TabIndex = 150
        '
        'txtDireccion1
        '
        Me.txtDireccion1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion1.Location = New System.Drawing.Point(82, 16)
        Me.txtDireccion1.MaxLength = 30
        Me.txtDireccion1.Name = "txtDireccion1"
        Me.txtDireccion1.Size = New System.Drawing.Size(359, 19)
        Me.txtDireccion1.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtDireccion1.TabIndex = 140
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(6, 19)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(64, 16)
        Me.KryptonLabel3.TabIndex = 98
        Me.KryptonLabel3.Text = "Dirección : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Dirección : "
        '
        'txtContacto2
        '
        Me.txtContacto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContacto2.Location = New System.Drawing.Point(80, 147)
        Me.txtContacto2.MaxLength = 30
        Me.txtContacto2.Name = "txtContacto2"
        Me.txtContacto2.Size = New System.Drawing.Size(361, 19)
        Me.txtContacto2.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtContacto2.TabIndex = 200
        '
        'txtContacto1
        '
        Me.txtContacto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContacto1.Location = New System.Drawing.Point(82, 122)
        Me.txtContacto1.MaxLength = 30
        Me.txtContacto1.Name = "txtContacto1"
        Me.txtContacto1.Size = New System.Drawing.Size(359, 19)
        Me.txtContacto1.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtContacto1.TabIndex = 190
        '
        'txtfax
        '
        Me.txtfax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfax.Location = New System.Drawing.Point(82, 97)
        Me.txtfax.MaxLength = 15
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(135, 19)
        Me.txtfax.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtfax.TabIndex = 180
        '
        'txtfono2
        '
        Me.txtfono2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfono2.Location = New System.Drawing.Point(311, 69)
        Me.txtfono2.MaxLength = 15
        Me.txtfono2.Name = "txtfono2"
        Me.txtfono2.Size = New System.Drawing.Size(130, 19)
        Me.txtfono2.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtfono2.TabIndex = 170
        '
        'txtfono1
        '
        Me.txtfono1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfono1.Location = New System.Drawing.Point(82, 69)
        Me.txtfono1.MaxLength = 15
        Me.txtfono1.Name = "txtfono1"
        Me.txtfono1.Size = New System.Drawing.Size(135, 19)
        Me.txtfono1.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtfono1.TabIndex = 160
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(6, 150)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(68, 16)
        Me.KryptonLabel11.TabIndex = 92
        Me.KryptonLabel11.Text = "Contacto 2: "
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Contacto 2: "
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(6, 125)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(68, 16)
        Me.KryptonLabel10.TabIndex = 91
        Me.KryptonLabel10.Text = "Contacto 1: "
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Contacto 1: "
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(6, 97)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(32, 16)
        Me.KryptonLabel9.TabIndex = 90
        Me.KryptonLabel9.Text = "Fax: "
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Fax: "
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(238, 72)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(67, 16)
        Me.KryptonLabel8.TabIndex = 89
        Me.KryptonLabel8.Text = "Teléfono 2: "
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Teléfono 2: "
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(6, 69)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(67, 16)
        Me.KryptonLabel7.TabIndex = 88
        Me.KryptonLabel7.Text = "Teléfono 1: "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Teléfono 1: "
        '
        'txtNRegIndustrial
        '
        Me.txtNRegIndustrial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNRegIndustrial.Location = New System.Drawing.Point(100, 190)
        Me.txtNRegIndustrial.MaxLength = 12
        Me.txtNRegIndustrial.Name = "txtNRegIndustrial"
        Me.txtNRegIndustrial.Size = New System.Drawing.Size(124, 19)
        Me.txtNRegIndustrial.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtNRegIndustrial.TabIndex = 120
        '
        'txtRegMercantil
        '
        Me.txtRegMercantil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRegMercantil.Location = New System.Drawing.Point(341, 190)
        Me.txtRegMercantil.MaxLength = 12
        Me.txtRegMercantil.Name = "txtRegMercantil"
        Me.txtRegMercantil.Size = New System.Drawing.Size(112, 19)
        Me.txtRegMercantil.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtRegMercantil.TabIndex = 130
        '
        'txtCargo
        '
        Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargo.Location = New System.Drawing.Point(100, 134)
        Me.txtCargo.MaxLength = 30
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(353, 19)
        Me.txtCargo.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtCargo.TabIndex = 100
        '
        'txtLE
        '
        Me.txtLE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLE.Location = New System.Drawing.Point(100, 159)
        Me.txtLE.MaxLength = 8
        Me.txtLE.Name = "txtLE"
        Me.txtLE.Size = New System.Drawing.Size(166, 19)
        Me.txtLE.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtLE.TabIndex = 110
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(12, 137)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(44, 16)
        Me.KryptonLabel12.TabIndex = 81
        Me.KryptonLabel12.Text = "Cargo: "
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Cargo: "
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 190)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(68, 29)
        Me.KryptonLabel6.TabIndex = 75
        Me.KryptonLabel6.Text = "N° Registro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Industrial: "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "N° Registro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Industrial: "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(258, 190)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(68, 29)
        Me.KryptonLabel5.TabIndex = 74
        Me.KryptonLabel5.Text = "N° Registro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mercantil: "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "N° Registro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mercantil: "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 165)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(36, 16)
        Me.KryptonLabel4.TabIndex = 73
        Me.KryptonLabel4.Text = "DNI : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "DNI : "
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.Location = New System.Drawing.Point(100, 34)
        Me.txtRuc.MaxLength = 15
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(166, 19)
        Me.txtRuc.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtRuc.TabIndex = 60
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 112)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(52, 16)
        Me.KryptonLabel1.TabIndex = 66
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(100, 109)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.Size = New System.Drawing.Size(353, 19)
        Me.txtCliente.TabIndex = 90
        '
        'lbl_CPRVCL
        '
        Me.lbl_CPRVCL.Location = New System.Drawing.Point(12, 12)
        Me.lbl_CPRVCL.Name = "lbl_CPRVCL"
        Me.lbl_CPRVCL.Size = New System.Drawing.Size(82, 16)
        Me.lbl_CPRVCL.TabIndex = 32
        Me.lbl_CPRVCL.Text = "Transportista :"
        Me.lbl_CPRVCL.Values.ExtraText = ""
        Me.lbl_CPRVCL.Values.Image = Nothing
        Me.lbl_CPRVCL.Values.Text = "Transportista :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(100, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(109, 19)
        Me.txtCodigo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCodigo.TabIndex = 59
        '
        'lbl_NRUCPR
        '
        Me.lbl_NRUCPR.Location = New System.Drawing.Point(12, 37)
        Me.lbl_NRUCPR.Name = "lbl_NRUCPR"
        Me.lbl_NRUCPR.Size = New System.Drawing.Size(65, 16)
        Me.lbl_NRUCPR.TabIndex = 38
        Me.lbl_NRUCPR.Text = "Nro. RUC :"
        Me.lbl_NRUCPR.Values.ExtraText = ""
        Me.lbl_NRUCPR.Values.Image = Nothing
        Me.lbl_NRUCPR.Values.Text = "Nro. RUC :"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnGuardar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(472, 25)
        Me.tsMenuOpciones.TabIndex = 60
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripLabel1.Tag = ""
        Me.ToolStripLabel1.Text = "Datos Transportista"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(65, 22)
        Me.btnGuardar.Text = "&Guardar"
        '
        'frmMantenimientoTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 441)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 468)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 468)
        Me.Name = "frmMantenimientoTransportista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento Transportista"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents lbl_CPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_NRUCPR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtRuc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As RANSA.Controls.Cliente.ucCliente_TxtF01
    Private WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNRegIndustrial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtRegMercantil As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtCargo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtLE As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtDesCompleto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtDesAbreviado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lbl_TPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents txtDireccion2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtDireccion1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtContacto2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtContacto1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtfax As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtfono2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtfono1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
