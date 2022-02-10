<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductoPedido
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
        Dim BePlantaDeEntrega1 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega2 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega3 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega4 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductoPedido))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.txtReferenciaPedido2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtReferenciaPedido1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dtpFechaDespacho = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.UcPlantaDeEntrega_TxtF011 = New Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
        Me.rbtPropio = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.UcClienteTercero_xtF011 = New Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
        Me.rbtTercero = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.lblPlantaTercero = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblClienteTercero = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOrdenDeCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtFactura = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOrdenDecompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblReferenciaPedido = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(516, 316)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtReferenciaPedido2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtReferenciaPedido1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.dtpFechaDespacho)
        Me.KryptonGroup1.Panel.Controls.Add(Me.GroupBox2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtOrdenDeCompra)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtFactura)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtObservaciones)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnCancelar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnGuardar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblObservaciones)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblOrdenDecompra)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.lblReferenciaPedido)
        Me.KryptonGroup1.Size = New System.Drawing.Size(516, 316)
        Me.KryptonGroup1.TabIndex = 0
        '
        'txtReferenciaPedido2
        '
        Me.txtReferenciaPedido2.Location = New System.Drawing.Point(240, 164)
        Me.txtReferenciaPedido2.MaxLength = 15
        Me.txtReferenciaPedido2.Name = "txtReferenciaPedido2"
        Me.txtReferenciaPedido2.Size = New System.Drawing.Size(232, 22)
        Me.txtReferenciaPedido2.TabIndex = 4
        '
        'txtReferenciaPedido1
        '
        Me.txtReferenciaPedido1.Location = New System.Drawing.Point(202, 164)
        Me.txtReferenciaPedido1.MaxLength = 5
        Me.txtReferenciaPedido1.Name = "txtReferenciaPedido1"
        Me.txtReferenciaPedido1.Size = New System.Drawing.Size(33, 22)
        Me.txtReferenciaPedido1.TabIndex = 3
        Me.txtReferenciaPedido1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFechaDespacho
        '
        Me.dtpFechaDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDespacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDespacho.Location = New System.Drawing.Point(202, 89)
        Me.dtpFechaDespacho.Name = "dtpFechaDespacho"
        Me.dtpFechaDespacho.Size = New System.Drawing.Size(89, 20)
        Me.dtpFechaDespacho.TabIndex = 0
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 72)
        Me.GroupBox2.TabIndex = 43
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
        BePlantaDeEntrega1.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PSCPLNAF = Nothing
        BePlantaDeEntrega1.PSCPRPCL = Nothing
        BePlantaDeEntrega1.PSSTPORL = Nothing
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
        BePlantaDeEntrega2.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PSCPLNAF = Nothing
        BePlantaDeEntrega2.PSCPRPCL = Nothing
        BePlantaDeEntrega2.PSSTPORL = Nothing
        BePlantaDeEntrega2.PSTCMPPL = ""
        BePlantaDeEntrega2.PSTDRCPL = ""
        BePlantaDeEntrega2.PSTDRPRC = ""
        BePlantaDeEntrega2.PSTPRVCL = ""
        BePlantaDeEntrega2.TIPOCLIENTE = True
        Me.UcPlantaDeEntrega_TxtF011.ItemActual = BePlantaDeEntrega2
        Me.UcPlantaDeEntrega_TxtF011.Lectura = False
        Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(190, 43)
        Me.UcPlantaDeEntrega_TxtF011.Name = "UcPlantaDeEntrega_TxtF011"
        Me.UcPlantaDeEntrega_TxtF011.Size = New System.Drawing.Size(272, 22)
        Me.UcPlantaDeEntrega_TxtF011.TabIndex = 1
        Me.UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = True
        '
        'rbtPropio
        '
        Me.rbtPropio.Checked = True
        Me.rbtPropio.Location = New System.Drawing.Point(17, 17)
        Me.rbtPropio.Name = "rbtPropio"
        Me.rbtPropio.Size = New System.Drawing.Size(58, 20)
        Me.rbtPropio.TabIndex = 38
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
        BePlantaDeEntrega3.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PSCPLNAF = Nothing
        BePlantaDeEntrega3.PSCPRPCL = Nothing
        BePlantaDeEntrega3.PSSTPORL = Nothing
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
        BePlantaDeEntrega4.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PSCPLNAF = Nothing
        BePlantaDeEntrega4.PSCPRPCL = Nothing
        BePlantaDeEntrega4.PSSTPORL = Nothing
        BePlantaDeEntrega4.PSTCMPPL = ""
        BePlantaDeEntrega4.PSTDRCPL = ""
        BePlantaDeEntrega4.PSTDRPRC = ""
        BePlantaDeEntrega4.PSTPRVCL = ""
        BePlantaDeEntrega4.TIPOCLIENTE = True
        Me.UcClienteTercero_xtF011.ItemActual = BePlantaDeEntrega4
        Me.UcClienteTercero_xtF011.Location = New System.Drawing.Point(190, 17)
        Me.UcClienteTercero_xtF011.MostrarRuc = False
        Me.UcClienteTercero_xtF011.Name = "UcClienteTercero_xtF011"
        Me.UcClienteTercero_xtF011.Ruc = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcClienteTercero_xtF011.Size = New System.Drawing.Size(272, 22)
        Me.UcClienteTercero_xtF011.TabIndex = 0
        Me.UcClienteTercero_xtF011.TipoRelacion = ""
        '
        'rbtTercero
        '
        Me.rbtTercero.Location = New System.Drawing.Point(17, 39)
        Me.rbtTercero.Name = "rbtTercero"
        Me.rbtTercero.Size = New System.Drawing.Size(63, 20)
        Me.rbtTercero.TabIndex = 39
        Me.rbtTercero.Text = "Tercero"
        Me.rbtTercero.Values.ExtraText = ""
        Me.rbtTercero.Values.Image = Nothing
        Me.rbtTercero.Values.Text = "Tercero"
        '
        'lblPlantaTercero
        '
        Me.lblPlantaTercero.Location = New System.Drawing.Point(83, 41)
        Me.lblPlantaTercero.Name = "lblPlantaTercero"
        Me.lblPlantaTercero.Size = New System.Drawing.Size(109, 20)
        Me.lblPlantaTercero.TabIndex = 1
        Me.lblPlantaTercero.Text = "Planta de entrega: "
        Me.lblPlantaTercero.Values.ExtraText = ""
        Me.lblPlantaTercero.Values.Image = Nothing
        Me.lblPlantaTercero.Values.Text = "Planta de entrega: "
        '
        'lblClienteTercero
        '
        Me.lblClienteTercero.Location = New System.Drawing.Point(83, 18)
        Me.lblClienteTercero.Name = "lblClienteTercero"
        Me.lblClienteTercero.Size = New System.Drawing.Size(95, 20)
        Me.lblClienteTercero.TabIndex = 1
        Me.lblClienteTercero.Text = "Cliente Tercero: "
        Me.lblClienteTercero.Values.ExtraText = ""
        Me.lblClienteTercero.Values.Image = Nothing
        Me.lblClienteTercero.Values.Text = "Cliente Tercero: "
        '
        'txtOrdenDeCompra
        '
        Me.txtOrdenDeCompra.Location = New System.Drawing.Point(202, 139)
        Me.txtOrdenDeCompra.MaxLength = 25
        Me.txtOrdenDeCompra.Name = "txtOrdenDeCompra"
        Me.txtOrdenDeCompra.Size = New System.Drawing.Size(270, 22)
        Me.txtOrdenDeCompra.TabIndex = 2
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(202, 112)
        Me.txtFactura.MaxLength = 10
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(270, 22)
        Me.txtFactura.TabIndex = 1
        Me.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(202, 191)
        Me.txtObservaciones.MaxLength = 40
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(272, 37)
        Me.txtObservaciones.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(415, 237)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 51)
        Me.btnCancelar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnCancelar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnCancelar.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.TabIndex = 7
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
        Me.btnGuardar.Location = New System.Drawing.Point(349, 237)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 51)
        Me.btnGuardar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnGuardar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnGuardar.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.Values.ExtraText = ""
        Me.btnGuardar.Values.Image = CType(resources.GetObject("btnGuardar.Values.Image"), System.Drawing.Image)
        Me.btnGuardar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuardar.Values.Text = "&Guardar"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(29, 191)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(96, 20)
        Me.lblObservaciones.TabIndex = 11
        Me.lblObservaciones.Text = "Observaciones :"
        Me.lblObservaciones.Values.ExtraText = ""
        Me.lblObservaciones.Values.Image = Nothing
        Me.lblObservaciones.Values.Text = "Observaciones :"
        '
        'lblOrdenDecompra
        '
        Me.lblOrdenDecompra.Location = New System.Drawing.Point(29, 141)
        Me.lblOrdenDecompra.Name = "lblOrdenDecompra"
        Me.lblOrdenDecompra.Size = New System.Drawing.Size(111, 20)
        Me.lblOrdenDecompra.TabIndex = 14
        Me.lblOrdenDecompra.Text = "Orden de Compra:"
        Me.lblOrdenDecompra.Values.ExtraText = ""
        Me.lblOrdenDecompra.Values.Image = Nothing
        Me.lblOrdenDecompra.Values.Text = "Orden de Compra:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(29, 90)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(101, 20)
        Me.KryptonLabel2.TabIndex = 14
        Me.KryptonLabel2.Text = "Fecha despacho:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha despacho:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(29, 114)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel1.TabIndex = 14
        Me.KryptonLabel1.Text = "Factura:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Factura:"
        '
        'lblReferenciaPedido
        '
        Me.lblReferenciaPedido.Location = New System.Drawing.Point(29, 166)
        Me.lblReferenciaPedido.Name = "lblReferenciaPedido"
        Me.lblReferenciaPedido.Size = New System.Drawing.Size(109, 20)
        Me.lblReferenciaPedido.TabIndex = 14
        Me.lblReferenciaPedido.Text = "Referencia pedido"
        Me.lblReferenciaPedido.Values.ExtraText = ""
        Me.lblReferenciaPedido.Values.Image = Nothing
        Me.lblReferenciaPedido.Values.Text = "Referencia pedido"
        '
        'frmProductoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductoPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Pedido de Despacho "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblReferenciaPedido As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblObservaciones As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UcPlantaDeEntrega_TxtF011 As Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
    Friend WithEvents rbtPropio As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents UcClienteTercero_xtF011 As Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
    Friend WithEvents rbtTercero As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents lblPlantaTercero As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblClienteTercero As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaDespacho As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFactura As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOrdenDeCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblOrdenDecompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtReferenciaPedido2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtReferenciaPedido1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
