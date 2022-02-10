<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarPedido
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
        Dim BePlantaDeEntrega9 As RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega10 As RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega11 As RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega12 As RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New RANSA.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportarPedido))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.dgItemPedido = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.UcPlantaDeEntrega_TxtF011 = New RANSA.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
        Me.UcClienteTercero_xtF011 = New RANSA.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
        Me.lblPlantaTercero = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblClienteTercero = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFactura = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtReferenciaPedido = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtOrdenDeCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblOrdenDecompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMotivoSalida = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNumeroPedido = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblItemOC = New System.Windows.Forms.ToolStripLabel
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnImportar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.vc_OrderNumberLine = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_StockCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vc_LineDescriptionLine1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNCN6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fl_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CONOS = New System.Windows.Forms.DataGridViewImageColumn
        Me.vc_CentroCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.in_OrderLine = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        CType(Me.dgItemPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(631, 553)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup2.Location = New System.Drawing.Point(0, 25)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.dgItemPedido)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonGroup2.Size = New System.Drawing.Size(631, 528)
        Me.KryptonGroup2.TabIndex = 78
        '
        'dgItemPedido
        '
        Me.dgItemPedido.AllowUserToAddRows = False
        Me.dgItemPedido.AllowUserToDeleteRows = False
        Me.dgItemPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgItemPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vc_OrderNumberLine, Me.vc_StockCode, Me.vc_LineDescriptionLine1, Me.CUNCN6, Me.fl_Quantity, Me.NORDSR, Me.CONOS, Me.vc_CentroCosto, Me.in_OrderLine})
        Me.dgItemPedido.DataMember = "dtItemOC"
        Me.dgItemPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemPedido.Location = New System.Drawing.Point(0, 238)
        Me.dgItemPedido.MultiSelect = False
        Me.dgItemPedido.Name = "dgItemPedido"
        Me.dgItemPedido.RowHeadersWidth = 20
        Me.dgItemPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgItemPedido.Size = New System.Drawing.Size(629, 288)
        Me.dgItemPedido.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgItemPedido.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcPlantaDeEntrega_TxtF011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcClienteTercero_xtF011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblPlantaTercero)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblClienteTercero)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFactura)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtReferenciaPedido)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtOrdenDeCompra)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblOrdenDecompra)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtMotivoSalida)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFecha)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel13)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNumeroPedido)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(629, 238)
        Me.KryptonHeaderGroup1.TabIndex = 89
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'UcPlantaDeEntrega_TxtF011
        '
        Me.UcPlantaDeEntrega_TxtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcPlantaDeEntrega_TxtF011.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcPlantaDeEntrega_TxtF011.CodCliente = 0
        Me.UcPlantaDeEntrega_TxtF011.CodClienteTercero = 0
        Me.UcPlantaDeEntrega_TxtF011.CodigoPlantaCliente = 0
        Me.UcPlantaDeEntrega_TxtF011.Enabled = False
        BePlantaDeEntrega9.PageCount = 0
        BePlantaDeEntrega9.PageNumber = 0
        BePlantaDeEntrega9.PageSize = 0
        BePlantaDeEntrega9.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega9.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega9.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega9.PSTCMPPL = ""
        BePlantaDeEntrega9.PSTDRCPL = ""
        BePlantaDeEntrega9.PSTDRPRC = ""
        BePlantaDeEntrega9.PSTPRVCL = ""
        BePlantaDeEntrega9.TIPOCLIENTE = True
        Me.UcPlantaDeEntrega_TxtF011.InfPlantaDeEntrega = BePlantaDeEntrega9
        BePlantaDeEntrega10.PageCount = 0
        BePlantaDeEntrega10.PageNumber = 0
        BePlantaDeEntrega10.PageSize = 0
        BePlantaDeEntrega10.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega10.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega10.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega10.PSTCMPPL = ""
        BePlantaDeEntrega10.PSTDRCPL = ""
        BePlantaDeEntrega10.PSTDRPRC = ""
        BePlantaDeEntrega10.PSTPRVCL = ""
        BePlantaDeEntrega10.TIPOCLIENTE = True
        Me.UcPlantaDeEntrega_TxtF011.ItemActual = BePlantaDeEntrega10
        Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(141, 196)
        Me.UcPlantaDeEntrega_TxtF011.Name = "UcPlantaDeEntrega_TxtF011"
        Me.UcPlantaDeEntrega_TxtF011.Size = New System.Drawing.Size(318, 21)
        Me.UcPlantaDeEntrega_TxtF011.TabIndex = 132
        Me.UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = True
        '
        'UcClienteTercero_xtF011
        '
        Me.UcClienteTercero_xtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteTercero_xtF011.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcClienteTercero_xtF011.CodCliente = 0
        Me.UcClienteTercero_xtF011.CodigoPlantaCliente = 0
        Me.UcClienteTercero_xtF011.Enabled = False
        BePlantaDeEntrega11.PageCount = 0
        BePlantaDeEntrega11.PageNumber = 0
        BePlantaDeEntrega11.PageSize = 0
        BePlantaDeEntrega11.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega11.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega11.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega11.PSTCMPPL = ""
        BePlantaDeEntrega11.PSTDRCPL = ""
        BePlantaDeEntrega11.PSTDRPRC = ""
        BePlantaDeEntrega11.PSTPRVCL = ""
        BePlantaDeEntrega11.TIPOCLIENTE = True
        Me.UcClienteTercero_xtF011.InfPlantaDeEntrega = BePlantaDeEntrega11
        BePlantaDeEntrega12.PageCount = 0
        BePlantaDeEntrega12.PageNumber = 0
        BePlantaDeEntrega12.PageSize = 0
        BePlantaDeEntrega12.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega12.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega12.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega12.PSTCMPPL = ""
        BePlantaDeEntrega12.PSTDRCPL = ""
        BePlantaDeEntrega12.PSTDRPRC = ""
        BePlantaDeEntrega12.PSTPRVCL = ""
        BePlantaDeEntrega12.TIPOCLIENTE = True
        Me.UcClienteTercero_xtF011.ItemActual = BePlantaDeEntrega12
        Me.UcClienteTercero_xtF011.Location = New System.Drawing.Point(141, 170)
        Me.UcClienteTercero_xtF011.Name = "UcClienteTercero_xtF011"
        Me.UcClienteTercero_xtF011.Size = New System.Drawing.Size(318, 21)
        Me.UcClienteTercero_xtF011.TabIndex = 131

        '
        'lblPlantaTercero
        '
        Me.lblPlantaTercero.Location = New System.Drawing.Point(19, 194)
        Me.lblPlantaTercero.Name = "lblPlantaTercero"
        Me.lblPlantaTercero.Size = New System.Drawing.Size(101, 19)
        Me.lblPlantaTercero.TabIndex = 133
        Me.lblPlantaTercero.Text = "Planta de entrega: "
        Me.lblPlantaTercero.Values.ExtraText = ""
        Me.lblPlantaTercero.Values.Image = Nothing
        Me.lblPlantaTercero.Values.Text = "Planta de entrega: "
        '
        'lblClienteTercero
        '
        Me.lblClienteTercero.Location = New System.Drawing.Point(19, 169)
        Me.lblClienteTercero.Name = "lblClienteTercero"
        Me.lblClienteTercero.Size = New System.Drawing.Size(88, 19)
        Me.lblClienteTercero.TabIndex = 134
        Me.lblClienteTercero.Text = "Cliente Tercero: "
        Me.lblClienteTercero.Values.ExtraText = ""
        Me.lblClienteTercero.Values.Image = Nothing
        Me.lblClienteTercero.Values.Text = "Cliente Tercero: "
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(141, 92)
        Me.txtFactura.MaxLength = 10
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(317, 21)
        Me.txtFactura.TabIndex = 6
        Me.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(19, 94)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(49, 19)
        Me.KryptonLabel2.TabIndex = 130
        Me.KryptonLabel2.Text = "Factura:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Factura:"
        '
        'txtReferenciaPedido
        '
        Me.txtReferenciaPedido.CausesValidation = False
        Me.txtReferenciaPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenciaPedido.Location = New System.Drawing.Point(141, 12)
        Me.txtReferenciaPedido.MaxLength = 15
        Me.txtReferenciaPedido.Name = "txtReferenciaPedido"
        Me.txtReferenciaPedido.Size = New System.Drawing.Size(30, 21)
        Me.txtReferenciaPedido.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtReferenciaPedido.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReferenciaPedido.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciaPedido.TabIndex = 0
        '
        'txtOrdenDeCompra
        '
        Me.txtOrdenDeCompra.Location = New System.Drawing.Point(141, 65)
        Me.txtOrdenDeCompra.MaxLength = 10
        Me.txtOrdenDeCompra.Name = "txtOrdenDeCompra"
        Me.txtOrdenDeCompra.Size = New System.Drawing.Size(318, 21)
        Me.txtOrdenDeCompra.TabIndex = 5
        '
        'lblOrdenDecompra
        '
        Me.lblOrdenDecompra.Location = New System.Drawing.Point(19, 67)
        Me.lblOrdenDecompra.Name = "lblOrdenDecompra"
        Me.lblOrdenDecompra.Size = New System.Drawing.Size(103, 19)
        Me.lblOrdenDecompra.TabIndex = 28
        Me.lblOrdenDecompra.Text = "Orden de Compra:"
        Me.lblOrdenDecompra.Values.ExtraText = ""
        Me.lblOrdenDecompra.Values.Image = Nothing
        Me.lblOrdenDecompra.Values.Text = "Orden de Compra:"
        '
        'txtMotivoSalida
        '
        Me.txtMotivoSalida.Location = New System.Drawing.Point(141, 119)
        Me.txtMotivoSalida.MaxLength = 40
        Me.txtMotivoSalida.Multiline = True
        Me.txtMotivoSalida.Name = "txtMotivoSalida"
        Me.txtMotivoSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoSalida.Size = New System.Drawing.Size(318, 45)
        Me.txtMotivoSalida.TabIndex = 7
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(19, 39)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(89, 19)
        Me.KryptonLabel7.TabIndex = 120
        Me.KryptonLabel7.Text = "Fecha de Orden"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Fecha de Orden"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(141, 39)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(19, 14)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(116, 19)
        Me.KryptonLabel1.TabIndex = 119
        Me.KryptonLabel1.Text = "N° Referencia Pedido"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "N° Referencia Pedido"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(19, 119)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(94, 19)
        Me.KryptonLabel13.TabIndex = 122
        Me.KryptonLabel13.Text = "Motivo de Salida"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Motivo de Salida"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.CausesValidation = False
        Me.txtNumeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedido.Location = New System.Drawing.Point(178, 12)
        Me.txtNumeroPedido.MaxLength = 15
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Size = New System.Drawing.Size(280, 21)
        Me.txtNumeroPedido.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtNumeroPedido.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumeroPedido.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPedido.TabIndex = 1
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(5, 28)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        Me.KryptonGroup1.Size = New System.Drawing.Size(150, 150)
        Me.KryptonGroup1.TabIndex = 77
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblItemOC, Me.btnSalir, Me.tssSep_02, Me.btnGuardar, Me.tssSep_03, Me.btnImportar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(631, 25)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'lblItemOC
        '
        Me.lblItemOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemOC.Name = "lblItemOC"
        Me.lblItemOC.Size = New System.Drawing.Size(83, 22)
        Me.lblItemOC.Text = "Datos Pedido"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(58, 22)
        Me.btnSalir.Text = "&Cerrar"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "&Guardar"
        '
        'tssSep_03
        '
        Me.tssSep_03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_03.Name = "tssSep_03"
        Me.tssSep_03.Size = New System.Drawing.Size(6, 25)
        '
        'btnImportar
        '
        Me.btnImportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImportar.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.btnImportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(71, 22)
        Me.btnImportar.Text = "Importar"
        '
        'vc_OrderNumberLine
        '
        Me.vc_OrderNumberLine.DataPropertyName = "vc_OrderNumberLine"
        Me.vc_OrderNumberLine.HeaderText = "Nro Item"
        Me.vc_OrderNumberLine.Name = "vc_OrderNumberLine"
        Me.vc_OrderNumberLine.ReadOnly = True
        '
        'vc_StockCode
        '
        Me.vc_StockCode.DataPropertyName = "vc_StockCode"
        Me.vc_StockCode.HeaderText = "Mercadería"
        Me.vc_StockCode.Name = "vc_StockCode"
        Me.vc_StockCode.ReadOnly = True
        '
        'vc_LineDescriptionLine1
        '
        Me.vc_LineDescriptionLine1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.vc_LineDescriptionLine1.DataPropertyName = "vc_LineDescriptionLine1"
        Me.vc_LineDescriptionLine1.HeaderText = "Descripción"
        Me.vc_LineDescriptionLine1.Name = "vc_LineDescriptionLine1"
        Me.vc_LineDescriptionLine1.ReadOnly = True
        Me.vc_LineDescriptionLine1.Width = 96
        '
        'CUNCN6
        '
        Me.CUNCN6.DataPropertyName = "CUNCN6"
        Me.CUNCN6.HeaderText = "Unidad Medida"
        Me.CUNCN6.Name = "CUNCN6"
        '
        'fl_Quantity
        '
        Me.fl_Quantity.DataPropertyName = "fl_Quantity"
        Me.fl_Quantity.HeaderText = "Cantidad"
        Me.fl_Quantity.Name = "fl_Quantity"
        Me.fl_Quantity.ReadOnly = True
        '
        'NORDSR
        '
        Me.NORDSR.DataPropertyName = "NORDSR"
        Me.NORDSR.HeaderText = "NORDSR"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.Visible = False
        '
        'CONOS
        '
        Me.CONOS.HeaderText = "OS"
        Me.CONOS.Image = Global.SOLMIN_SA.My.Resources.Resources.button_ok
        Me.CONOS.Name = "CONOS"
        '
        'vc_CentroCosto
        '
        Me.vc_CentroCosto.DataPropertyName = "vc_CentroCosto"
        Me.vc_CentroCosto.HeaderText = "vc_CentroCosto"
        Me.vc_CentroCosto.Name = "vc_CentroCosto"
        Me.vc_CentroCosto.Visible = False
        '
        'in_OrderLine
        '
        Me.in_OrderLine.HeaderText = "in_OrderLine"
        Me.in_OrderLine.Name = "in_OrderLine"
        '
        'frmImportarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 553)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportarPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importar Pedido"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        CType(Me.dgItemPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
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
    Private WithEvents lblItemOC As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtMotivoSalida As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNumeroPedido As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnImportar As System.Windows.Forms.ToolStripButton
    Private WithEvents dgItemPedido As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtOrdenDeCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblOrdenDecompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtReferenciaPedido As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtFactura As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPlantaDeEntrega_TxtF011 As Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
    Friend WithEvents UcClienteTercero_xtF011 As Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
    Friend WithEvents lblPlantaTercero As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblClienteTercero As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents vc_OrderNumberLine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_StockCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vc_LineDescriptionLine1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fl_Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONOS As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents vc_CentroCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents in_OrderLine As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
