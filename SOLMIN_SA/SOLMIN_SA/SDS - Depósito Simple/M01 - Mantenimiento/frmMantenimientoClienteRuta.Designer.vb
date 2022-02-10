<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoClienteRuta
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
        Dim BePlantaDeEntrega1 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega2 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega3 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega4 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoClienteRuta))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtLongitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtLatitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNumCorrelativo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.UcPlantaDeEntrega_TxtF011 = New Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
        Me.rbtPropio = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.UcClienteTercero_xtF011 = New Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
        Me.rbtTercero = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.lblPlantaTercero = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblClienteTercero = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(524, 386)
        Me.KryptonPanel.TabIndex = 1
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.GroupBox3)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtLongitud)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtLatitud)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtNumCorrelativo)
        Me.KryptonGroup1.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.GroupBox2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnCancelar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnGuardar)
        Me.KryptonGroup1.Size = New System.Drawing.Size(524, 386)
        Me.KryptonGroup1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dtpHoraInicio)
        Me.GroupBox3.Controls.Add(Me.KryptonLabel3)
        Me.GroupBox3.Controls.Add(Me.dtpHoraFin)
        Me.GroupBox3.Controls.Add(Me.KryptonLabel4)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(475, 72)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Planta de entrega"
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicio.Location = New System.Drawing.Point(193, 11)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.Size = New System.Drawing.Size(111, 20)
        Me.dtpHoraInicio.TabIndex = 1
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(108, 11)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(70, 19)
        Me.KryptonLabel3.TabIndex = 0
        Me.KryptonLabel3.Text = "Hora Inicio :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Hora Inicio :"
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFin.Location = New System.Drawing.Point(193, 41)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.Size = New System.Drawing.Size(111, 20)
        Me.dtpHoraFin.TabIndex = 3
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(120, 42)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel4.TabIndex = 2
        Me.KryptonLabel4.Text = "Hora Fin:"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Hora Fin:"
        '
        'txtLongitud
        '
        Me.txtLongitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLongitud.Location = New System.Drawing.Point(208, 266)
        Me.txtLongitud.MaxLength = 100
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(210, 21)
        Me.txtLongitud.TabIndex = 8
        Me.txtLongitud.Text = "0"
        Me.txtLongitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLatitud
        '
        Me.txtLatitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLatitud.Location = New System.Drawing.Point(208, 237)
        Me.txtLatitud.MaxLength = 100
        Me.txtLatitud.Name = "txtLatitud"
        Me.txtLatitud.Size = New System.Drawing.Size(210, 21)
        Me.txtLatitud.TabIndex = 6
        Me.txtLatitud.Text = "0"
        Me.txtLatitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(429, 231)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(64, 57)
        Me.KryptonButton1.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonButton1.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.KryptonButton1.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonButton1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonButton1.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonButton1.TabIndex = 9
        Me.KryptonButton1.TabStop = False
        Me.KryptonButton1.Text = "Posicion"
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Global.SOLMIN_SA.My.Resources.Resources.Ruta
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Posicion"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(132, 270)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel7.TabIndex = 7
        Me.KryptonLabel7.Text = "Longitud:"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Longitud:"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(142, 237)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel6.TabIndex = 5
        Me.KryptonLabel6.Text = "Latitud :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Latitud :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(74, 209)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(115, 19)
        Me.KryptonLabel5.TabIndex = 3
        Me.KryptonLabel5.Text = "Numero Correlativo :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Numero Correlativo :"
        '
        'txtNumCorrelativo
        '
        Me.txtNumCorrelativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumCorrelativo.Location = New System.Drawing.Point(208, 209)
        Me.txtNumCorrelativo.MaxLength = 2
        Me.txtNumCorrelativo.Name = "txtNumCorrelativo"
        Me.txtNumCorrelativo.Size = New System.Drawing.Size(80, 21)
        Me.txtNumCorrelativo.TabIndex = 4
        Me.txtNumCorrelativo.Text = "0"
        Me.txtNumCorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 43)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(190, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(272, 21)
        Me.txtCliente.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(121, 13)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.UcPlantaDeEntrega_TxtF011)
        Me.GroupBox2.Controls.Add(Me.rbtPropio)
        Me.GroupBox2.Controls.Add(Me.UcClienteTercero_xtF011)
        Me.GroupBox2.Controls.Add(Me.rbtTercero)
        Me.GroupBox2.Controls.Add(Me.lblPlantaTercero)
        Me.GroupBox2.Controls.Add(Me.lblClienteTercero)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Planta de entrega"
        '
        'UcPlantaDeEntrega_TxtF011
        '
        Me.UcPlantaDeEntrega_TxtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcPlantaDeEntrega_TxtF011.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcPlantaDeEntrega_TxtF011.CodCliente = 0
        Me.UcPlantaDeEntrega_TxtF011.CodClienteTercero = 0
        Me.UcPlantaDeEntrega_TxtF011.CodigoPlantaCliente = 0
        BePlantaDeEntrega1.PageCount = 0
        BePlantaDeEntrega1.PageNumber = 0
        BePlantaDeEntrega1.PageSize = 0
        BePlantaDeEntrega1.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PSTCMPPL = ""
        BePlantaDeEntrega1.PSTDRCPL = ""
        BePlantaDeEntrega1.PSTDRPRC = ""
        BePlantaDeEntrega1.PSTPRVCL = ""
        BePlantaDeEntrega1.TIPOCLIENTE = True
        Me.UcPlantaDeEntrega_TxtF011.InfPlantaDeEntrega = BePlantaDeEntrega1
        BePlantaDeEntrega2.PageCount = 0
        BePlantaDeEntrega2.PageNumber = 0
        BePlantaDeEntrega2.PageSize = 0
        BePlantaDeEntrega2.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PSTCMPPL = ""
        BePlantaDeEntrega2.PSTDRCPL = ""
        BePlantaDeEntrega2.PSTDRPRC = ""
        BePlantaDeEntrega2.PSTPRVCL = ""
        BePlantaDeEntrega2.TIPOCLIENTE = True
        Me.UcPlantaDeEntrega_TxtF011.ItemActual = BePlantaDeEntrega2
        Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(190, 43)
        Me.UcPlantaDeEntrega_TxtF011.Name = "UcPlantaDeEntrega_TxtF011"
        Me.UcPlantaDeEntrega_TxtF011.Size = New System.Drawing.Size(272, 21)
        Me.UcPlantaDeEntrega_TxtF011.TabIndex = 5
        Me.UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = True
        '
        'rbtPropio
        '
        Me.rbtPropio.Checked = True
        Me.rbtPropio.Location = New System.Drawing.Point(17, 18)
        Me.rbtPropio.Name = "rbtPropio"
        Me.rbtPropio.Size = New System.Drawing.Size(55, 19)
        Me.rbtPropio.TabIndex = 0
        Me.rbtPropio.Text = "Propio"
        Me.rbtPropio.Values.ExtraText = ""
        Me.rbtPropio.Values.Image = Nothing
        Me.rbtPropio.Values.Text = "Propio"
        '
        'UcClienteTercero_xtF011
        '
        Me.UcClienteTercero_xtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteTercero_xtF011.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcClienteTercero_xtF011.CodCliente = 0
        Me.UcClienteTercero_xtF011.CodigoPlantaCliente = 0
        BePlantaDeEntrega3.PageCount = 0
        BePlantaDeEntrega3.PageNumber = 0
        BePlantaDeEntrega3.PageSize = 0
        BePlantaDeEntrega3.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PSTCMPPL = ""
        BePlantaDeEntrega3.PSTDRCPL = ""
        BePlantaDeEntrega3.PSTDRPRC = ""
        BePlantaDeEntrega3.PSTPRVCL = ""
        BePlantaDeEntrega3.TIPOCLIENTE = True
        Me.UcClienteTercero_xtF011.InfPlantaDeEntrega = BePlantaDeEntrega3
        BePlantaDeEntrega4.PageCount = 0
        BePlantaDeEntrega4.PageNumber = 0
        BePlantaDeEntrega4.PageSize = 0
        BePlantaDeEntrega4.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PSTCMPPL = ""
        BePlantaDeEntrega4.PSTDRCPL = ""
        BePlantaDeEntrega4.PSTDRPRC = ""
        BePlantaDeEntrega4.PSTPRVCL = ""
        BePlantaDeEntrega4.TIPOCLIENTE = True
        Me.UcClienteTercero_xtF011.ItemActual = BePlantaDeEntrega4
        Me.UcClienteTercero_xtF011.Location = New System.Drawing.Point(190, 17)
        Me.UcClienteTercero_xtF011.Name = "UcClienteTercero_xtF011"
        Me.UcClienteTercero_xtF011.Size = New System.Drawing.Size(272, 21)
        Me.UcClienteTercero_xtF011.TabIndex = 2
        '
        'rbtTercero
        '
        Me.rbtTercero.Location = New System.Drawing.Point(17, 40)
        Me.rbtTercero.Name = "rbtTercero"
        Me.rbtTercero.Size = New System.Drawing.Size(60, 19)
        Me.rbtTercero.TabIndex = 3
        Me.rbtTercero.Text = "Tercero"
        Me.rbtTercero.Values.ExtraText = ""
        Me.rbtTercero.Values.Image = Nothing
        Me.rbtTercero.Values.Text = "Tercero"
        '
        'lblPlantaTercero
        '
        Me.lblPlantaTercero.Location = New System.Drawing.Point(83, 41)
        Me.lblPlantaTercero.Name = "lblPlantaTercero"
        Me.lblPlantaTercero.Size = New System.Drawing.Size(101, 19)
        Me.lblPlantaTercero.TabIndex = 4
        Me.lblPlantaTercero.Text = "Planta de entrega: "
        Me.lblPlantaTercero.Values.ExtraText = ""
        Me.lblPlantaTercero.Values.Image = Nothing
        Me.lblPlantaTercero.Values.Text = "Planta de entrega: "
        '
        'lblClienteTercero
        '
        Me.lblClienteTercero.Location = New System.Drawing.Point(83, 18)
        Me.lblClienteTercero.Name = "lblClienteTercero"
        Me.lblClienteTercero.Size = New System.Drawing.Size(88, 19)
        Me.lblClienteTercero.TabIndex = 1
        Me.lblClienteTercero.Text = "Cliente Tercero: "
        Me.lblClienteTercero.Values.ExtraText = ""
        Me.lblClienteTercero.Values.Image = Nothing
        Me.lblClienteTercero.Values.Text = "Cliente Tercero: "
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(299, 313)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 51)
        Me.btnCancelar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnCancelar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnCancelar.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(211, 313)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 51)
        Me.btnGuardar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnGuardar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnGuardar.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.Values.ExtraText = ""
        Me.btnGuardar.Values.Image = CType(resources.GetObject("btnGuardar.Values.Image"), System.Drawing.Image)
        Me.btnGuardar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuardar.Values.Text = "&Guardar"
        '
        'frmMantenimientoClienteRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 386)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(532, 420)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(532, 420)
        Me.Name = "frmMantenimientoClienteRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Cliente por Zona"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UcPlantaDeEntrega_TxtF011 As Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
    Friend WithEvents rbtPropio As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents UcClienteTercero_xtF011 As Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
    Friend WithEvents rbtTercero As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents lblPlantaTercero As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblClienteTercero As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumCorrelativo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtLongitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLatitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
