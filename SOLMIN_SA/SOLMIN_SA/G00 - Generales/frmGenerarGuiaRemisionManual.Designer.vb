<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarGuiaRemisionManual
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim BePlantaDeEntrega1 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega2 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega3 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega4 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega5 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega6 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega7 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega8 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega9 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega10 As Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TYPEDEF.PlantaDeEntrega.bePlantaDeEntrega
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgDetalleGuia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CSRECL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNGU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQPSGU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCUNPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTOBDGS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BeGuiaRemisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAceptar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.tssAgregar = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtOrdenDeCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbTipoPedido = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.txtNumeroPedido = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkRecojo = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker
        Me.lblMotivoDespacho = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtObsOtrosMotivos = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTipoDoc = New Ransa.Utilitario.ucAyuda
        Me.txtMotivoTraslado = New Ransa.Utilitario.ucAyuda
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.chkAutoGenerar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCodCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtNroFactura = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.dtpFechaTraslado = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaFactura = New System.Windows.Forms.DateTimePicker
        Me.lblFechaTraslado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaEmision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblPlantaOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblClienteOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcClienteTerceroOrigen = New Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
        Me.UcPlantaDeEntregaOrigen = New Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
        Me.grpPuntos = New System.Windows.Forms.GroupBox
        Me.UcPlantaDeEntregaPropioDestino = New Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
        Me.rbtClienteTercero = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtPlantaCliente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPlantaDeEntregaDestino = New Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
        Me.UcClienteTerceroDestino = New Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
        Me.grpEmpresaTransporte = New System.Windows.Forms.GroupBox
        Me.txtMantCamiones = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtManChoferes = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtNumeroContenedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtSigla = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMedioSugerido = New Ransa.CONTROL.UcMedioTransporte
        Me.txtEmpresaTransporte2doTramo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaEmpresaTransporte2doTramoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblTransporte2doTramo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkDosTramos = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtNroBrevete = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaNroBreveteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtPlacaAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaPlacaAcopladoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblNroBrevete = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblPlacaAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaEmpresaTransporteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtPlacaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaPlacaUnidadListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblPlacaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabGlosa = New System.Windows.Forms.TabPage
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.TabObservacion = New System.Windows.Forms.TabPage
        Me.dtgObservacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.TOBSGS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgDetalleGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeGuiaRemisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpPuntos.SuspendLayout()
        Me.grpEmpresaTransporte.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabGlosa.SuspendLayout()
        Me.TabObservacion.SuspendLayout()
        CType(Me.dtgObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgDetalleGuia)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1023, 680)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgDetalleGuia
        '
        Me.dtgDetalleGuia.AllowUserToAddRows = False
        Me.dtgDetalleGuia.AutoGenerateColumns = False
        Me.dtgDetalleGuia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetalleGuia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CMRCLR, Me.TDITEM, Me.CSRECL, Me.QCNGU, Me.CUNCN, Me.PNQPSGU, Me.PSCUNPS, Me.PSTOBDGS})
        Me.dtgDetalleGuia.DataSource = Me.BeGuiaRemisionBindingSource
        Me.dtgDetalleGuia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDetalleGuia.Location = New System.Drawing.Point(0, 540)
        Me.dtgDetalleGuia.Name = "dtgDetalleGuia"
        Me.dtgDetalleGuia.Size = New System.Drawing.Size(1023, 140)
        Me.dtgDetalleGuia.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgDetalleGuia.StateDisabled.Background.Color1 = System.Drawing.Color.White
        Me.dtgDetalleGuia.StateDisabled.Background.Color2 = System.Drawing.Color.White
        Me.dtgDetalleGuia.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgDetalleGuia.TabIndex = 2
        '
        'CMRCLR
        '
        Me.CMRCLR.DataPropertyName = "PSCMRCLR"
        Me.CMRCLR.HeaderText = "Cod. Mercadería"
        Me.CMRCLR.MaxInputLength = 30
        Me.CMRCLR.Name = "CMRCLR"
        '
        'TDITEM
        '
        Me.TDITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TDITEM.DataPropertyName = "PSTDITEM"
        Me.TDITEM.HeaderText = "Mercadería"
        Me.TDITEM.MaxInputLength = 60
        Me.TDITEM.MinimumWidth = 300
        Me.TDITEM.Name = "TDITEM"
        '
        'CSRECL
        '
        Me.CSRECL.DataPropertyName = "PSCSRECL"
        Me.CSRECL.HeaderText = "Nro. Serie"
        Me.CSRECL.MaxInputLength = 20
        Me.CSRECL.Name = "CSRECL"
        '
        'QCNGU
        '
        Me.QCNGU.DataPropertyName = "PNQCNGU"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QCNGU.DefaultCellStyle = DataGridViewCellStyle1
        Me.QCNGU.HeaderText = "Cantidad"
        Me.QCNGU.MaxInputLength = 15
        Me.QCNGU.Name = "QCNGU"
        '
        'CUNCN
        '
        Me.CUNCN.DataPropertyName = "PSCUNCN"
        Me.CUNCN.HeaderText = "Unidad"
        Me.CUNCN.MaxInputLength = 3
        Me.CUNCN.Name = "CUNCN"
        '
        'PNQPSGU
        '
        Me.PNQPSGU.DataPropertyName = "PNQPSGU"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PNQPSGU.DefaultCellStyle = DataGridViewCellStyle2
        Me.PNQPSGU.HeaderText = "Peso"
        Me.PNQPSGU.MaxInputLength = 15
        Me.PNQPSGU.Name = "PNQPSGU"
        '
        'PSCUNPS
        '
        Me.PSCUNPS.DataPropertyName = "PSCUNPS"
        Me.PSCUNPS.HeaderText = "Unidad Peso"
        Me.PSCUNPS.MaxInputLength = 3
        Me.PSCUNPS.Name = "PSCUNPS"
        '
        'PSTOBDGS
        '
        Me.PSTOBDGS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTOBDGS.DataPropertyName = "PSTOBDGS"
        Me.PSTOBDGS.HeaderText = "Observación"
        Me.PSTOBDGS.MaxInputLength = 60
        Me.PSTOBDGS.MinimumWidth = 200
        Me.PSTOBDGS.Name = "PSTOBDGS"
        Me.PSTOBDGS.Width = 200
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator3, Me.tsbCancelar, Me.ToolStripSeparator2, Me.tsbAceptar, Me.ToolStripSeparator4, Me.btnAgregar, Me.tssAgregar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 515)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(1023, 25)
        Me.tsMenuOpciones.TabIndex = 1
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(141, 22)
        Me.ToolStripLabel1.Tag = "POSICION"
        Me.ToolStripLabel1.Text = "Detalle -  Guía remisión"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "&Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAceptar
        '
        Me.tsbAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAceptar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_ok
        Me.tsbAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAceptar.Name = "tsbAceptar"
        Me.tsbAceptar.Size = New System.Drawing.Size(68, 22)
        Me.tsbAceptar.Text = "&Aceptar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.db_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(96, 22)
        Me.btnAgregar.Text = "Agregar Item"
        '
        'tssAgregar
        '
        Me.tssAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssAgregar.Name = "tssAgregar"
        Me.tssAgregar.Size = New System.Drawing.Size(6, 25)
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.GroupBox3)
        Me.KryptonGroup1.Panel.Controls.Add(Me.GroupBox2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.grpPuntos)
        Me.KryptonGroup1.Panel.Controls.Add(Me.grpEmpresaTransporte)
        Me.KryptonGroup1.Size = New System.Drawing.Size(1023, 515)
        Me.KryptonGroup1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtOrdenDeCompra)
        Me.GroupBox3.Controls.Add(Me.KryptonLabel6)
        Me.GroupBox3.Controls.Add(Me.cmbTipoPedido)
        Me.GroupBox3.Controls.Add(Me.txtNumeroPedido)
        Me.GroupBox3.Controls.Add(Me.KryptonLabel5)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 451)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(977, 49)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pedido"
        '
        'txtOrdenDeCompra
        '
        Me.txtOrdenDeCompra.CausesValidation = False
        Me.txtOrdenDeCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdenDeCompra.Location = New System.Drawing.Point(350, 17)
        Me.txtOrdenDeCompra.MaxLength = 30
        Me.txtOrdenDeCompra.Name = "txtOrdenDeCompra"
        Me.txtOrdenDeCompra.Size = New System.Drawing.Size(173, 22)
        Me.txtOrdenDeCompra.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtOrdenDeCompra.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOrdenDeCompra.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenDeCompra.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtOrdenDeCompra, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(241, 19)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(115, 20)
        Me.KryptonLabel6.TabIndex = 3
        Me.KryptonLabel6.Text = "Orden de Compra :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Orden de Compra :"
        '
        'cmbTipoPedido
        '
        Me.cmbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPedido.DropDownWidth = 121
        Me.cmbTipoPedido.FormattingEnabled = False
        Me.cmbTipoPedido.ItemHeight = 15
        Me.cmbTipoPedido.Location = New System.Drawing.Point(103, 17)
        Me.cmbTipoPedido.Name = "cmbTipoPedido"
        Me.cmbTipoPedido.Size = New System.Drawing.Size(39, 23)
        'Me.cmbTipoPedido.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.cmbTipoPedido.TabIndex = 1
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.CausesValidation = False
        Me.txtNumeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedido.Location = New System.Drawing.Point(150, 17)
        Me.txtNumeroPedido.MaxLength = 15
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.ReadOnly = True
        Me.txtNumeroPedido.Size = New System.Drawing.Size(82, 22)
        Me.txtNumeroPedido.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtNumeroPedido.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumeroPedido.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPedido.TabIndex = 2
        Me.txtNumeroPedido.Text = "0"
        Me.txtNumeroPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtNumeroPedido, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(1, 19)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(99, 20)
        Me.KryptonLabel5.TabIndex = 0
        Me.KryptonLabel5.Text = "N° Ref.  Pedido :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "N° Ref.  Pedido :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.chkRecojo)
        Me.GroupBox2.Controls.Add(Me.dtpFechaEmision)
        Me.GroupBox2.Controls.Add(Me.lblMotivoDespacho)
        Me.GroupBox2.Controls.Add(Me.txtObsOtrosMotivos)
        Me.GroupBox2.Controls.Add(Me.txtTipoDoc)
        Me.GroupBox2.Controls.Add(Me.txtMotivoTraslado)
        Me.GroupBox2.Controls.Add(Me.txtCliente)
        Me.GroupBox2.Controls.Add(Me.chkAutoGenerar)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel8)
        Me.GroupBox2.Controls.Add(Me.lblFechaFactura)
        Me.GroupBox2.Controls.Add(Me.lblCodCliente)
        Me.GroupBox2.Controls.Add(Me.lblNroFactura)
        Me.GroupBox2.Controls.Add(Me.txtNroGuiaRemision)
        Me.GroupBox2.Controls.Add(Me.txtNroFactura)
        Me.GroupBox2.Controls.Add(Me.dtpFechaTraslado)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFactura)
        Me.GroupBox2.Controls.Add(Me.lblFechaTraslado)
        Me.GroupBox2.Controls.Add(Me.lblFechaEmision)
        Me.GroupBox2.Location = New System.Drawing.Point(11, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(977, 116)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'chkRecojo
        '
        Me.chkRecojo.Checked = False
        Me.chkRecojo.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkRecojo.Location = New System.Drawing.Point(484, 75)
        Me.chkRecojo.Name = "chkRecojo"
        Me.chkRecojo.Size = New System.Drawing.Size(75, 20)
        Me.chkRecojo.TabIndex = 17
        Me.chkRecojo.Text = "Es Recojo"
        Me.chkRecojo.Values.ExtraText = ""
        Me.chkRecojo.Values.Image = Nothing
        Me.chkRecojo.Values.Text = "Es Recojo"
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(825, 17)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(130, 20)
        Me.dtpFechaEmision.TabIndex = 5
        '
        'lblMotivoDespacho
        '
        Me.lblMotivoDespacho.Location = New System.Drawing.Point(1, 72)
        Me.lblMotivoDespacho.Name = "lblMotivoDespacho"
        Me.lblMotivoDespacho.Size = New System.Drawing.Size(113, 20)
        Me.lblMotivoDespacho.TabIndex = 14
        Me.lblMotivoDespacho.Text = "Motivo Despacho :"
        Me.lblMotivoDespacho.Values.ExtraText = ""
        Me.lblMotivoDespacho.Values.Image = Nothing
        Me.lblMotivoDespacho.Values.Text = "Motivo Despacho :"
        '
        'txtObsOtrosMotivos
        '
        Me.txtObsOtrosMotivos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObsOtrosMotivos.Location = New System.Drawing.Point(117, 92)
        Me.txtObsOtrosMotivos.MaxLength = 30
        Me.txtObsOtrosMotivos.Name = "txtObsOtrosMotivos"
        Me.txtObsOtrosMotivos.ReadOnly = True
        Me.txtObsOtrosMotivos.Size = New System.Drawing.Size(354, 22)
        Me.txtObsOtrosMotivos.TabIndex = 16
        Me.TypeValidator.SetTypes(Me.txtObsOtrosMotivos, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoDoc.DataSource = Nothing
        Me.txtTipoDoc.DispleyMember = ""
        Me.txtTipoDoc.ListColumnas = Nothing
        Me.txtTipoDoc.Location = New System.Drawing.Point(116, 41)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Obligatorio = False
        Me.txtTipoDoc.Size = New System.Drawing.Size(130, 21)
        Me.txtTipoDoc.TabIndex = 7
        Me.txtTipoDoc.ValueMember = ""
        '
        'txtMotivoTraslado
        '
        Me.txtMotivoTraslado.BackColor = System.Drawing.Color.Transparent
        Me.txtMotivoTraslado.DataSource = Nothing
        Me.txtMotivoTraslado.DispleyMember = ""
        Me.txtMotivoTraslado.ListColumnas = Nothing
        Me.txtMotivoTraslado.Location = New System.Drawing.Point(117, 68)
        Me.txtMotivoTraslado.Name = "txtMotivoTraslado"
        Me.txtMotivoTraslado.Obligatorio = True
        Me.txtMotivoTraslado.Size = New System.Drawing.Size(354, 21)
        Me.txtMotivoTraslado.TabIndex = 15
        Me.txtMotivoTraslado.ValueMember = ""
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(116, 18)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(354, 22)
        Me.txtCliente.TabIndex = 1
        '
        'chkAutoGenerar
        '
        Me.chkAutoGenerar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoGenerar.Location = New System.Drawing.Point(472, 18)
        Me.chkAutoGenerar.Name = "chkAutoGenerar"
        Me.chkAutoGenerar.Size = New System.Drawing.Size(125, 20)
        Me.chkAutoGenerar.TabIndex = 2
        Me.chkAutoGenerar.Text = "N° Guía Remisión :"
        Me.chkAutoGenerar.Values.ExtraText = ""
        Me.chkAutoGenerar.Values.Image = Nothing
        Me.chkAutoGenerar.Values.Text = "N° Guía Remisión :"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(46, 44)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(68, 20)
        Me.KryptonLabel8.TabIndex = 6
        Me.KryptonLabel8.Text = "Tipo Doc. :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Tipo Doc. :"
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.Location = New System.Drawing.Point(518, 40)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(76, 20)
        Me.lblFechaFactura.TabIndex = 10
        Me.lblFechaFactura.Text = "Fecha Doc. : "
        Me.lblFechaFactura.Values.ExtraText = ""
        Me.lblFechaFactura.Values.Image = Nothing
        Me.lblFechaFactura.Values.Text = "Fecha Doc. : "
        '
        'lblCodCliente
        '
        Me.lblCodCliente.Location = New System.Drawing.Point(60, 20)
        Me.lblCodCliente.Name = "lblCodCliente"
        Me.lblCodCliente.Size = New System.Drawing.Size(54, 20)
        Me.lblCodCliente.TabIndex = 0
        Me.lblCodCliente.Text = "Cliente : "
        Me.lblCodCliente.Values.ExtraText = ""
        Me.lblCodCliente.Values.Image = Nothing
        Me.lblCodCliente.Values.Text = "Cliente : "
        '
        'lblNroFactura
        '
        Me.lblNroFactura.Location = New System.Drawing.Point(265, 42)
        Me.lblNroFactura.Name = "lblNroFactura"
        Me.lblNroFactura.Size = New System.Drawing.Size(58, 20)
        Me.lblNroFactura.TabIndex = 8
        Me.lblNroFactura.Text = "N° Doc. : "
        Me.lblNroFactura.Values.ExtraText = ""
        Me.lblNroFactura.Values.Image = Nothing
        Me.lblNroFactura.Values.Text = "N° Doc. : "
        '
        'txtNroGuiaRemision
        '
        Me.txtNroGuiaRemision.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtNroGuiaRemision.Location = New System.Drawing.Point(599, 16)
        Me.txtNroGuiaRemision.Mask = "###-#######"
        Me.txtNroGuiaRemision.Name = "txtNroGuiaRemision"
        Me.txtNroGuiaRemision.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNroGuiaRemision.Size = New System.Drawing.Size(130, 22)
        Me.txtNroGuiaRemision.TabIndex = 3
        Me.txtNroGuiaRemision.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtNroFactura
        '
        Me.txtNroFactura.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtNroFactura.Location = New System.Drawing.Point(340, 41)
        Me.txtNroFactura.Mask = "###-#######"
        Me.txtNroFactura.Name = "txtNroFactura"
        Me.txtNroFactura.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNroFactura.Size = New System.Drawing.Size(130, 22)
        Me.txtNroFactura.TabIndex = 9
        Me.txtNroFactura.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'dtpFechaTraslado
        '
        Me.dtpFechaTraslado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaTraslado.Location = New System.Drawing.Point(825, 40)
        Me.dtpFechaTraslado.Name = "dtpFechaTraslado"
        Me.dtpFechaTraslado.Size = New System.Drawing.Size(130, 20)
        Me.dtpFechaTraslado.TabIndex = 13
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(599, 39)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(130, 20)
        Me.dtpFechaFactura.TabIndex = 11
        '
        'lblFechaTraslado
        '
        Me.lblFechaTraslado.Location = New System.Drawing.Point(729, 42)
        Me.lblFechaTraslado.Name = "lblFechaTraslado"
        Me.lblFechaTraslado.Size = New System.Drawing.Size(98, 20)
        Me.lblFechaTraslado.TabIndex = 12
        Me.lblFechaTraslado.Text = "Fecha Traslado : "
        Me.lblFechaTraslado.Values.ExtraText = ""
        Me.lblFechaTraslado.Values.Image = Nothing
        Me.lblFechaTraslado.Values.Text = "Fecha Traslado : "
        '
        'lblFechaEmision
        '
        Me.lblFechaEmision.Location = New System.Drawing.Point(774, 18)
        Me.lblFechaEmision.Name = "lblFechaEmision"
        Me.lblFechaEmision.Size = New System.Drawing.Size(48, 20)
        Me.lblFechaEmision.TabIndex = 4
        Me.lblFechaEmision.Text = "Fecha : "
        Me.lblFechaEmision.Values.ExtraText = ""
        Me.lblFechaEmision.Values.Image = Nothing
        Me.lblFechaEmision.Values.Text = "Fecha : "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblPlantaOrigen)
        Me.GroupBox1.Controls.Add(Me.lblClienteOrigen)
        Me.GroupBox1.Controls.Add(Me.UcClienteTerceroOrigen)
        Me.GroupBox1.Controls.Add(Me.UcPlantaDeEntregaOrigen)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(977, 43)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origen "
        '
        'lblPlantaOrigen
        '
        Me.lblPlantaOrigen.Location = New System.Drawing.Point(3, 16)
        Me.lblPlantaOrigen.Name = "lblPlantaOrigen"
        Me.lblPlantaOrigen.Size = New System.Drawing.Size(108, 20)
        Me.lblPlantaOrigen.TabIndex = 3
        Me.lblPlantaOrigen.Text = "Planta de Origen : "
        Me.lblPlantaOrigen.Values.ExtraText = ""
        Me.lblPlantaOrigen.Values.Image = Nothing
        Me.lblPlantaOrigen.Values.Text = "Planta de Origen : "
        '
        'lblClienteOrigen
        '
        Me.lblClienteOrigen.Location = New System.Drawing.Point(18, 18)
        Me.lblClienteOrigen.Name = "lblClienteOrigen"
        Me.lblClienteOrigen.Size = New System.Drawing.Size(95, 20)
        Me.lblClienteOrigen.TabIndex = 0
        Me.lblClienteOrigen.Text = "Cliente Origen : "
        Me.lblClienteOrigen.Values.ExtraText = ""
        Me.lblClienteOrigen.Values.Image = Nothing
        Me.lblClienteOrigen.Values.Text = "Cliente Origen : "
        '
        'UcClienteTerceroOrigen
        '
        Me.UcClienteTerceroOrigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteTerceroOrigen.BackColor = System.Drawing.Color.Transparent
        Me.UcClienteTerceroOrigen.CodCliente = 0
        Me.UcClienteTerceroOrigen.CodigoPlantaCliente = 0
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
        Me.UcClienteTerceroOrigen.InfPlantaDeEntrega = BePlantaDeEntrega1
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
        Me.UcClienteTerceroOrigen.ItemActual = BePlantaDeEntrega2
        Me.UcClienteTerceroOrigen.Location = New System.Drawing.Point(118, 17)
        Me.UcClienteTerceroOrigen.MostrarRuc = False
        Me.UcClienteTerceroOrigen.Name = "UcClienteTerceroOrigen"
        Me.UcClienteTerceroOrigen.Ruc = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcClienteTerceroOrigen.Size = New System.Drawing.Size(354, 22)
        Me.UcClienteTerceroOrigen.TabIndex = 1
        Me.UcClienteTerceroOrigen.TipoRelacion = ""
        '
        'UcPlantaDeEntregaOrigen
        '
        Me.UcPlantaDeEntregaOrigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcPlantaDeEntregaOrigen.BackColor = System.Drawing.Color.Transparent
        Me.UcPlantaDeEntregaOrigen.CodCliente = 0
        Me.UcPlantaDeEntregaOrigen.CodClienteTercero = 0
        Me.UcPlantaDeEntregaOrigen.CodigoPlantaCliente = 0
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
        Me.UcPlantaDeEntregaOrigen.InfPlantaDeEntrega = BePlantaDeEntrega3
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
        Me.UcPlantaDeEntregaOrigen.ItemActual = BePlantaDeEntrega4
        Me.UcPlantaDeEntregaOrigen.Lectura = False
        Me.UcPlantaDeEntregaOrigen.Location = New System.Drawing.Point(117, 17)
        Me.UcPlantaDeEntregaOrigen.Name = "UcPlantaDeEntregaOrigen"
        Me.UcPlantaDeEntregaOrigen.Size = New System.Drawing.Size(352, 22)
        Me.UcPlantaDeEntregaOrigen.TabIndex = 1
        Me.UcPlantaDeEntregaOrigen.TipoPlantaDeEntrega = False
        '
        'grpPuntos
        '
        Me.grpPuntos.BackColor = System.Drawing.Color.Transparent
        Me.grpPuntos.Controls.Add(Me.UcPlantaDeEntregaPropioDestino)
        Me.grpPuntos.Controls.Add(Me.rbtClienteTercero)
        Me.grpPuntos.Controls.Add(Me.rbtPlantaCliente)
        Me.grpPuntos.Controls.Add(Me.KryptonLabel3)
        Me.grpPuntos.Controls.Add(Me.UcPlantaDeEntregaDestino)
        Me.grpPuntos.Controls.Add(Me.UcClienteTerceroDestino)
        Me.grpPuntos.Location = New System.Drawing.Point(9, 158)
        Me.grpPuntos.Name = "grpPuntos"
        Me.grpPuntos.Size = New System.Drawing.Size(977, 62)
        Me.grpPuntos.TabIndex = 2
        Me.grpPuntos.TabStop = False
        Me.grpPuntos.Text = "Destino"
        '
        'UcPlantaDeEntregaPropioDestino
        '
        Me.UcPlantaDeEntregaPropioDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcPlantaDeEntregaPropioDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcPlantaDeEntregaPropioDestino.CodCliente = 0
        Me.UcPlantaDeEntregaPropioDestino.CodClienteTercero = 0
        Me.UcPlantaDeEntregaPropioDestino.CodigoPlantaCliente = 0
        BePlantaDeEntrega5.PageCount = 0
        BePlantaDeEntrega5.PageNumber = 0
        BePlantaDeEntrega5.PageSize = 0
        BePlantaDeEntrega5.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega5.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega5.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega5.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega5.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega5.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega5.PSCPLNAF = Nothing
        BePlantaDeEntrega5.PSCPRPCL = Nothing
        BePlantaDeEntrega5.PSSTPORL = Nothing
        BePlantaDeEntrega5.PSTCMPPL = ""
        BePlantaDeEntrega5.PSTDRCPL = ""
        BePlantaDeEntrega5.PSTDRPRC = ""
        BePlantaDeEntrega5.PSTPRVCL = ""
        BePlantaDeEntrega5.TIPOCLIENTE = True
        Me.UcPlantaDeEntregaPropioDestino.InfPlantaDeEntrega = BePlantaDeEntrega5
        BePlantaDeEntrega6.PageCount = 0
        BePlantaDeEntrega6.PageNumber = 0
        BePlantaDeEntrega6.PageSize = 0
        BePlantaDeEntrega6.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega6.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega6.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega6.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega6.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega6.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega6.PSCPLNAF = Nothing
        BePlantaDeEntrega6.PSCPRPCL = Nothing
        BePlantaDeEntrega6.PSSTPORL = Nothing
        BePlantaDeEntrega6.PSTCMPPL = ""
        BePlantaDeEntrega6.PSTDRCPL = ""
        BePlantaDeEntrega6.PSTDRPRC = ""
        BePlantaDeEntrega6.PSTPRVCL = ""
        BePlantaDeEntrega6.TIPOCLIENTE = True
        Me.UcPlantaDeEntregaPropioDestino.ItemActual = BePlantaDeEntrega6
        Me.UcPlantaDeEntregaPropioDestino.Lectura = False
        Me.UcPlantaDeEntregaPropioDestino.Location = New System.Drawing.Point(119, 13)
        Me.UcPlantaDeEntregaPropioDestino.Name = "UcPlantaDeEntregaPropioDestino"
        Me.UcPlantaDeEntregaPropioDestino.Size = New System.Drawing.Size(354, 22)
        Me.UcPlantaDeEntregaPropioDestino.TabIndex = 1
        Me.UcPlantaDeEntregaPropioDestino.TipoPlantaDeEntrega = True
        '
        'rbtClienteTercero
        '
        Me.rbtClienteTercero.Checked = True
        Me.rbtClienteTercero.Location = New System.Drawing.Point(12, 35)
        Me.rbtClienteTercero.Name = "rbtClienteTercero"
        Me.rbtClienteTercero.Size = New System.Drawing.Size(66, 20)
        Me.rbtClienteTercero.TabIndex = 2
        Me.rbtClienteTercero.Text = "Cliente : "
        Me.rbtClienteTercero.Values.ExtraText = ""
        Me.rbtClienteTercero.Values.Image = Nothing
        Me.rbtClienteTercero.Values.Text = "Cliente : "
        '
        'rbtPlantaCliente
        '
        Me.rbtPlantaCliente.Checked = True
        Me.rbtPlantaCliente.Location = New System.Drawing.Point(12, 13)
        Me.rbtPlantaCliente.Name = "rbtPlantaCliente"
        Me.rbtPlantaCliente.Size = New System.Drawing.Size(66, 20)
        Me.rbtPlantaCliente.TabIndex = 0
        Me.rbtPlantaCliente.Text = "Planta  : "
        Me.rbtPlantaCliente.Values.ExtraText = ""
        Me.rbtPlantaCliente.Values.Image = Nothing
        Me.rbtPlantaCliente.Values.Text = "Planta  : "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(556, 35)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Planta : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta : "
        '
        'UcPlantaDeEntregaDestino
        '
        Me.UcPlantaDeEntregaDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcPlantaDeEntregaDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcPlantaDeEntregaDestino.CodCliente = 0
        Me.UcPlantaDeEntregaDestino.CodClienteTercero = 0
        Me.UcPlantaDeEntregaDestino.CodigoPlantaCliente = 0
        Me.UcPlantaDeEntregaDestino.Enabled = False
        BePlantaDeEntrega7.PageCount = 0
        BePlantaDeEntrega7.PageNumber = 0
        BePlantaDeEntrega7.PageSize = 0
        BePlantaDeEntrega7.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega7.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega7.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega7.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega7.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega7.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega7.PSCPLNAF = Nothing
        BePlantaDeEntrega7.PSCPRPCL = Nothing
        BePlantaDeEntrega7.PSSTPORL = Nothing
        BePlantaDeEntrega7.PSTCMPPL = ""
        BePlantaDeEntrega7.PSTDRCPL = ""
        BePlantaDeEntrega7.PSTDRPRC = ""
        BePlantaDeEntrega7.PSTPRVCL = ""
        BePlantaDeEntrega7.TIPOCLIENTE = True
        Me.UcPlantaDeEntregaDestino.InfPlantaDeEntrega = BePlantaDeEntrega7
        BePlantaDeEntrega8.PageCount = 0
        BePlantaDeEntrega8.PageNumber = 0
        BePlantaDeEntrega8.PageSize = 0
        BePlantaDeEntrega8.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega8.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega8.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega8.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega8.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega8.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega8.PSCPLNAF = Nothing
        BePlantaDeEntrega8.PSCPRPCL = Nothing
        BePlantaDeEntrega8.PSSTPORL = Nothing
        BePlantaDeEntrega8.PSTCMPPL = ""
        BePlantaDeEntrega8.PSTDRCPL = ""
        BePlantaDeEntrega8.PSTDRPRC = ""
        BePlantaDeEntrega8.PSTPRVCL = ""
        BePlantaDeEntrega8.TIPOCLIENTE = True
        Me.UcPlantaDeEntregaDestino.ItemActual = BePlantaDeEntrega8
        Me.UcPlantaDeEntregaDestino.Lectura = False
        Me.UcPlantaDeEntregaDestino.Location = New System.Drawing.Point(608, 35)
        Me.UcPlantaDeEntregaDestino.Name = "UcPlantaDeEntregaDestino"
        Me.UcPlantaDeEntregaDestino.Size = New System.Drawing.Size(354, 22)
        Me.UcPlantaDeEntregaDestino.TabIndex = 5
        Me.UcPlantaDeEntregaDestino.TipoPlantaDeEntrega = True
        '
        'UcClienteTerceroDestino
        '
        Me.UcClienteTerceroDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteTerceroDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcClienteTerceroDestino.CodCliente = 0
        Me.UcClienteTerceroDestino.CodigoPlantaCliente = 0
        Me.UcClienteTerceroDestino.Enabled = False
        BePlantaDeEntrega9.PageCount = 0
        BePlantaDeEntrega9.PageNumber = 0
        BePlantaDeEntrega9.PageSize = 0
        BePlantaDeEntrega9.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega9.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega9.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega9.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega9.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega9.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega9.PSCPLNAF = Nothing
        BePlantaDeEntrega9.PSCPRPCL = Nothing
        BePlantaDeEntrega9.PSSTPORL = Nothing
        BePlantaDeEntrega9.PSTCMPPL = ""
        BePlantaDeEntrega9.PSTDRCPL = ""
        BePlantaDeEntrega9.PSTDRPRC = ""
        BePlantaDeEntrega9.PSTPRVCL = ""
        BePlantaDeEntrega9.TIPOCLIENTE = True
        Me.UcClienteTerceroDestino.InfPlantaDeEntrega = BePlantaDeEntrega9
        BePlantaDeEntrega10.PageCount = 0
        BePlantaDeEntrega10.PageNumber = 0
        BePlantaDeEntrega10.PageSize = 0
        BePlantaDeEntrega10.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega10.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega10.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega10.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega10.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega10.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega10.PSCPLNAF = Nothing
        BePlantaDeEntrega10.PSCPRPCL = Nothing
        BePlantaDeEntrega10.PSSTPORL = Nothing
        BePlantaDeEntrega10.PSTCMPPL = ""
        BePlantaDeEntrega10.PSTDRCPL = ""
        BePlantaDeEntrega10.PSTDRPRC = ""
        BePlantaDeEntrega10.PSTPRVCL = ""
        BePlantaDeEntrega10.TIPOCLIENTE = True
        Me.UcClienteTerceroDestino.ItemActual = BePlantaDeEntrega10
        Me.UcClienteTerceroDestino.Location = New System.Drawing.Point(119, 37)
        Me.UcClienteTerceroDestino.MostrarRuc = False
        Me.UcClienteTerceroDestino.Name = "UcClienteTerceroDestino"
        Me.UcClienteTerceroDestino.Ruc = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcClienteTerceroDestino.Size = New System.Drawing.Size(354, 22)
        Me.UcClienteTerceroDestino.TabIndex = 3
        Me.UcClienteTerceroDestino.TipoRelacion = ""
        '
        'grpEmpresaTransporte
        '
        Me.grpEmpresaTransporte.BackColor = System.Drawing.Color.Transparent
        Me.grpEmpresaTransporte.Controls.Add(Me.TabControl1)
        Me.grpEmpresaTransporte.Controls.Add(Me.txtMantCamiones)
        Me.grpEmpresaTransporte.Controls.Add(Me.txtManChoferes)
        Me.grpEmpresaTransporte.Controls.Add(Me.txtNumeroContenedor)
        Me.grpEmpresaTransporte.Controls.Add(Me.KryptonLabel4)
        Me.grpEmpresaTransporte.Controls.Add(Me.txtSigla)
        Me.grpEmpresaTransporte.Controls.Add(Me.KryptonLabel7)
        Me.grpEmpresaTransporte.Controls.Add(Me.KryptonLabel2)
        Me.grpEmpresaTransporte.Controls.Add(Me.txtMedioSugerido)
        Me.grpEmpresaTransporte.Controls.Add(Me.txtEmpresaTransporte2doTramo)
        Me.grpEmpresaTransporte.Controls.Add(Me.lblTransporte2doTramo)
        Me.grpEmpresaTransporte.Controls.Add(Me.chkDosTramos)
        Me.grpEmpresaTransporte.Controls.Add(Me.txtNroBrevete)
        Me.grpEmpresaTransporte.Controls.Add(Me.txtPlacaAcoplado)
        Me.grpEmpresaTransporte.Controls.Add(Me.lblNroBrevete)
        Me.grpEmpresaTransporte.Controls.Add(Me.lblPlacaAcoplado)
        Me.grpEmpresaTransporte.Controls.Add(Me.lblEmpresaTransporte)
        Me.grpEmpresaTransporte.Controls.Add(Me.txtEmpresaTransporte)
        Me.grpEmpresaTransporte.Controls.Add(Me.txtPlacaUnidad)
        Me.grpEmpresaTransporte.Controls.Add(Me.lblPlacaUnidad)
        Me.grpEmpresaTransporte.Location = New System.Drawing.Point(11, 222)
        Me.grpEmpresaTransporte.Name = "grpEmpresaTransporte"
        Me.grpEmpresaTransporte.Size = New System.Drawing.Size(977, 227)
        Me.grpEmpresaTransporte.TabIndex = 3
        Me.grpEmpresaTransporte.TabStop = False
        Me.grpEmpresaTransporte.Text = "Información del Transporte"
        '
        'txtMantCamiones
        '
        Me.txtMantCamiones.Location = New System.Drawing.Point(252, 38)
        Me.txtMantCamiones.Name = "txtMantCamiones"
        Me.txtMantCamiones.Size = New System.Drawing.Size(20, 25)
        Me.txtMantCamiones.TabIndex = 6
        Me.txtMantCamiones.Tag = "Mantenimiento de Camiones"
        Me.txtMantCamiones.Text = "..."
        Me.txtMantCamiones.Values.ExtraText = ""
        Me.txtMantCamiones.Values.Image = Nothing
        Me.txtMantCamiones.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.txtMantCamiones.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.txtMantCamiones.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.txtMantCamiones.Values.Text = "..."
        '
        'txtManChoferes
        '
        Me.txtManChoferes.Location = New System.Drawing.Point(473, 38)
        Me.txtManChoferes.Name = "txtManChoferes"
        Me.txtManChoferes.Size = New System.Drawing.Size(21, 25)
        Me.txtManChoferes.TabIndex = 9
        Me.txtManChoferes.Tag = "Mantenimiento de Choferes"
        Me.txtManChoferes.Text = "..."
        Me.txtManChoferes.Values.ExtraText = ""
        Me.txtManChoferes.Values.Image = Nothing
        Me.txtManChoferes.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.txtManChoferes.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.txtManChoferes.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.txtManChoferes.Values.Text = "..."
        '
        'txtNumeroContenedor
        '
        Me.txtNumeroContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroContenedor.Location = New System.Drawing.Point(835, 89)
        Me.txtNumeroContenedor.MaxLength = 7
        Me.txtNumeroContenedor.Name = "txtNumeroContenedor"
        Me.txtNumeroContenedor.Size = New System.Drawing.Size(130, 22)
        Me.txtNumeroContenedor.TabIndex = 20
        Me.TypeValidator.SetTypes(Me.txtNumeroContenedor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(715, 89)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(130, 20)
        Me.KryptonLabel4.TabIndex = 19
        Me.KryptonLabel4.Text = "Número Contenedor : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Número Contenedor : "
        '
        'txtSigla
        '
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSigla.Location = New System.Drawing.Point(611, 89)
        Me.txtSigla.MaxLength = 4
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(98, 22)
        Me.txtSigla.TabIndex = 18
        Me.TypeValidator.SetTypes(Me.txtSigla, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(506, 89)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(111, 20)
        Me.KryptonLabel7.TabIndex = 17
        Me.KryptonLabel7.Text = "Sigla Contenedor : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Sigla Contenedor : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(0, 17)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(114, 20)
        Me.KryptonLabel2.TabIndex = 0
        Me.KryptonLabel2.Text = "Medio Transporte :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Medio Transporte :"
        '
        'txtMedioSugerido
        '
        Me.txtMedioSugerido.BackColor = System.Drawing.Color.Transparent
        Me.txtMedioSugerido.DataMember = "PNCMEDTR"
        Me.txtMedioSugerido.DataSource = Nothing
        Me.txtMedioSugerido.DataValue = "PSTNMMDT"
        Me.txtMedioSugerido.Location = New System.Drawing.Point(117, 14)
        Me.txtMedioSugerido.Name = "txtMedioSugerido"
        Me.txtMedioSugerido.objResult = Nothing
        Me.txtMedioSugerido.Size = New System.Drawing.Size(354, 25)
        Me.txtMedioSugerido.TabIndex = 1
        '
        'txtEmpresaTransporte2doTramo
        '
        Me.txtEmpresaTransporte2doTramo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaEmpresaTransporte2doTramoListar})
        Me.txtEmpresaTransporte2doTramo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresaTransporte2doTramo.Enabled = False
        Me.txtEmpresaTransporte2doTramo.Location = New System.Drawing.Point(117, 87)
        Me.txtEmpresaTransporte2doTramo.MaxLength = 50
        Me.txtEmpresaTransporte2doTramo.Name = "txtEmpresaTransporte2doTramo"
        Me.txtEmpresaTransporte2doTramo.Size = New System.Drawing.Size(354, 22)
        Me.txtEmpresaTransporte2doTramo.TabIndex = 16
        Me.TypeValidator.SetTypes(Me.txtEmpresaTransporte2doTramo, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaEmpresaTransporte2doTramoListar
        '
        Me.bsaEmpresaTransporte2doTramoListar.ExtraText = ""
        Me.bsaEmpresaTransporte2doTramoListar.Image = Nothing
        Me.bsaEmpresaTransporte2doTramoListar.Text = ""
        Me.bsaEmpresaTransporte2doTramoListar.ToolTipImage = Nothing
        Me.bsaEmpresaTransporte2doTramoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaEmpresaTransporte2doTramoListar.UniqueName = "28CB6CC66AC3488128CB6CC66AC34881"
        '
        'lblTransporte2doTramo
        '
        Me.lblTransporte2doTramo.Location = New System.Drawing.Point(10, 91)
        Me.lblTransporte2doTramo.Name = "lblTransporte2doTramo"
        Me.lblTransporte2doTramo.Size = New System.Drawing.Size(106, 20)
        Me.lblTransporte2doTramo.TabIndex = 15
        Me.lblTransporte2doTramo.Text = "Emp. Transporte : "
        Me.lblTransporte2doTramo.Values.ExtraText = ""
        Me.lblTransporte2doTramo.Values.Image = Nothing
        Me.lblTransporte2doTramo.Values.Text = "Emp. Transporte : "
        '
        'chkDosTramos
        '
        Me.chkDosTramos.Checked = False
        Me.chkDosTramos.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDosTramos.Location = New System.Drawing.Point(16, 68)
        Me.chkDosTramos.Name = "chkDosTramos"
        Me.chkDosTramos.Size = New System.Drawing.Size(88, 20)
        Me.chkDosTramos.TabIndex = 14
        Me.chkDosTramos.Text = "Dos Tramos"
        Me.chkDosTramos.Values.ExtraText = ""
        Me.chkDosTramos.Values.Image = Nothing
        Me.chkDosTramos.Values.Text = "Dos Tramos"
        '
        'txtNroBrevete
        '
        Me.txtNroBrevete.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaNroBreveteListar})
        Me.txtNroBrevete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroBrevete.Location = New System.Drawing.Point(341, 40)
        Me.txtNroBrevete.MaxLength = 15
        Me.txtNroBrevete.Name = "txtNroBrevete"
        Me.txtNroBrevete.Size = New System.Drawing.Size(127, 22)
        Me.txtNroBrevete.TabIndex = 8
        Me.txtNroBrevete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtNroBrevete, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaNroBreveteListar
        '
        Me.bsaNroBreveteListar.ExtraText = ""
        Me.bsaNroBreveteListar.Image = Nothing
        Me.bsaNroBreveteListar.Text = ""
        Me.bsaNroBreveteListar.ToolTipImage = Nothing
        Me.bsaNroBreveteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaNroBreveteListar.UniqueName = "44C51AFD6D96488444C51AFD6D964884"
        '
        'txtPlacaAcoplado
        '
        Me.txtPlacaAcoplado.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaPlacaAcopladoListar})
        Me.txtPlacaAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaAcoplado.Location = New System.Drawing.Point(610, 40)
        Me.txtPlacaAcoplado.MaxLength = 6
        Me.txtPlacaAcoplado.Name = "txtPlacaAcoplado"
        Me.txtPlacaAcoplado.Size = New System.Drawing.Size(130, 22)
        Me.txtPlacaAcoplado.TabIndex = 11
        Me.txtPlacaAcoplado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPlacaAcoplado, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaPlacaAcopladoListar
        '
        Me.bsaPlacaAcopladoListar.ExtraText = ""
        Me.bsaPlacaAcopladoListar.Image = Nothing
        Me.bsaPlacaAcopladoListar.Text = ""
        Me.bsaPlacaAcopladoListar.ToolTipImage = Nothing
        Me.bsaPlacaAcopladoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaPlacaAcopladoListar.UniqueName = "E9C1DD4A5DF84294E9C1DD4A5DF84294"
        '
        'lblNroBrevete
        '
        Me.lblNroBrevete.Location = New System.Drawing.Point(286, 41)
        Me.lblNroBrevete.Name = "lblNroBrevete"
        Me.lblNroBrevete.Size = New System.Drawing.Size(57, 20)
        Me.lblNroBrevete.TabIndex = 7
        Me.lblNroBrevete.Text = "Brevete : "
        Me.lblNroBrevete.Values.ExtraText = ""
        Me.lblNroBrevete.Values.Image = Nothing
        Me.lblNroBrevete.Values.Text = "Brevete : "
        '
        'lblPlacaAcoplado
        '
        Me.lblPlacaAcoplado.Location = New System.Drawing.Point(522, 41)
        Me.lblPlacaAcoplado.Name = "lblPlacaAcoplado"
        Me.lblPlacaAcoplado.Size = New System.Drawing.Size(86, 20)
        Me.lblPlacaAcoplado.TabIndex = 10
        Me.lblPlacaAcoplado.Text = "N° Acoplado : "
        Me.lblPlacaAcoplado.Values.ExtraText = ""
        Me.lblPlacaAcoplado.Values.Image = Nothing
        Me.lblPlacaAcoplado.Values.Text = "N° Acoplado : "
        '
        'lblEmpresaTransporte
        '
        Me.lblEmpresaTransporte.Location = New System.Drawing.Point(503, 15)
        Me.lblEmpresaTransporte.Name = "lblEmpresaTransporte"
        Me.lblEmpresaTransporte.Size = New System.Drawing.Size(106, 20)
        Me.lblEmpresaTransporte.TabIndex = 2
        Me.lblEmpresaTransporte.Text = "Emp. Transporte : "
        Me.lblEmpresaTransporte.Values.ExtraText = ""
        Me.lblEmpresaTransporte.Values.Image = Nothing
        Me.lblEmpresaTransporte.Values.Text = "Emp. Transporte : "
        '
        'txtEmpresaTransporte
        '
        Me.txtEmpresaTransporte.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaEmpresaTransporteListar})
        Me.txtEmpresaTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresaTransporte.Location = New System.Drawing.Point(609, 15)
        Me.txtEmpresaTransporte.MaxLength = 50
        Me.txtEmpresaTransporte.Name = "txtEmpresaTransporte"
        Me.txtEmpresaTransporte.Size = New System.Drawing.Size(354, 22)
        Me.txtEmpresaTransporte.TabIndex = 3
        Me.TypeValidator.SetTypes(Me.txtEmpresaTransporte, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaEmpresaTransporteListar
        '
        Me.bsaEmpresaTransporteListar.ExtraText = ""
        Me.bsaEmpresaTransporteListar.Image = Nothing
        Me.bsaEmpresaTransporteListar.Text = ""
        Me.bsaEmpresaTransporteListar.ToolTipImage = Nothing
        Me.bsaEmpresaTransporteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaEmpresaTransporteListar.UniqueName = "28CB6CC66AC3488128CB6CC66AC34881"
        '
        'txtPlacaUnidad
        '
        Me.txtPlacaUnidad.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaPlacaUnidadListar})
        Me.txtPlacaUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaUnidad.Location = New System.Drawing.Point(116, 40)
        Me.txtPlacaUnidad.MaxLength = 6
        Me.txtPlacaUnidad.Name = "txtPlacaUnidad"
        Me.txtPlacaUnidad.Size = New System.Drawing.Size(130, 22)
        Me.txtPlacaUnidad.TabIndex = 5
        Me.txtPlacaUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPlacaUnidad, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaPlacaUnidadListar
        '
        Me.bsaPlacaUnidadListar.ExtraText = ""
        Me.bsaPlacaUnidadListar.Image = Nothing
        Me.bsaPlacaUnidadListar.Text = ""
        Me.bsaPlacaUnidadListar.ToolTipImage = Nothing
        Me.bsaPlacaUnidadListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaPlacaUnidadListar.UniqueName = "3AC1E99EB74F44CD3AC1E99EB74F44CD"
        '
        'lblPlacaUnidad
        '
        Me.lblPlacaUnidad.Location = New System.Drawing.Point(41, 42)
        Me.lblPlacaUnidad.Name = "lblPlacaUnidad"
        Me.lblPlacaUnidad.Size = New System.Drawing.Size(73, 20)
        Me.lblPlacaUnidad.TabIndex = 4
        Me.lblPlacaUnidad.Text = "N° Unidad : "
        Me.lblPlacaUnidad.Values.ExtraText = ""
        Me.lblPlacaUnidad.Values.Image = Nothing
        Me.lblPlacaUnidad.Values.Text = "N° Unidad : "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabGlosa)
        Me.TabControl1.Controls.Add(Me.TabObservacion)
        Me.TabControl1.Location = New System.Drawing.Point(17, 115)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(947, 108)
        Me.TabControl1.TabIndex = 22
        '
        'TabGlosa
        '
        Me.TabGlosa.Controls.Add(Me.txtObservaciones)
        Me.TabGlosa.Location = New System.Drawing.Point(4, 22)
        Me.TabGlosa.Name = "TabGlosa"
        Me.TabGlosa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGlosa.Size = New System.Drawing.Size(939, 82)
        Me.TabGlosa.TabIndex = 0
        Me.TabGlosa.Text = "Glosa"
        Me.TabGlosa.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Location = New System.Drawing.Point(3, 3)
        Me.txtObservaciones.MaxLength = 90
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(933, 76)
        Me.txtObservaciones.TabIndex = 13
        Me.TypeValidator.SetTypes(Me.txtObservaciones, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'TabObservacion
        '
        Me.TabObservacion.Controls.Add(Me.dtgObservacion)
        Me.TabObservacion.Location = New System.Drawing.Point(4, 22)
        Me.TabObservacion.Name = "TabObservacion"
        Me.TabObservacion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabObservacion.Size = New System.Drawing.Size(939, 82)
        Me.TabObservacion.TabIndex = 1
        Me.TabObservacion.Text = "Observación"
        Me.TabObservacion.UseVisualStyleBackColor = True
        '
        'dtgObservacion
        '
        Me.dtgObservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgObservacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TOBSGS})
        Me.dtgObservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgObservacion.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.dtgObservacion.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlRibbon
        Me.dtgObservacion.Location = New System.Drawing.Point(3, 3)
        Me.dtgObservacion.Name = "dtgObservacion"
        Me.dtgObservacion.RowHeadersWidth = 15
        Me.dtgObservacion.Size = New System.Drawing.Size(933, 76)
        Me.dtgObservacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlRibbon
        Me.dtgObservacion.StateDisabled.Background.Color1 = System.Drawing.Color.White
        Me.dtgObservacion.StateDisabled.Background.Color2 = System.Drawing.Color.White
        Me.dtgObservacion.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgObservacion.TabIndex = 27
        '
        'TOBSGS
        '
        Me.TOBSGS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBSGS.DataPropertyName = "PSTOBSGS"
        Me.TOBSGS.HeaderText = "Observación"
        Me.TOBSGS.MaxInputLength = 60
        Me.TOBSGS.MinimumWidth = 200
        Me.TOBSGS.Name = "TOBSGS"
        '
        'frmGenerarGuiaRemisionManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 680)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmGenerarGuiaRemisionManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Guía de Remisión"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgDetalleGuia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeGuiaRemisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpPuntos.ResumeLayout(False)
        Me.grpPuntos.PerformLayout()
        Me.grpEmpresaTransporte.ResumeLayout(False)
        Me.grpEmpresaTransporte.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabGlosa.ResumeLayout(False)
        Me.TabGlosa.PerformLayout()
        Me.TabObservacion.ResumeLayout(False)
        CType(Me.dtgObservacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grpPuntos As System.Windows.Forms.GroupBox
    Friend WithEvents grpEmpresaTransporte As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMedioSugerido As Ransa.CONTROL.UcMedioTransporte
    Friend WithEvents txtEmpresaTransporte2doTramo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaEmpresaTransporte2doTramoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblTransporte2doTramo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkDosTramos As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtNroBrevete As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaNroBreveteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtPlacaAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaPlacaAcopladoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblNroBrevete As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPlacaAcoplado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblEmpresaTransporte As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmpresaTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaEmpresaTransporteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtPlacaUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaPlacaUnidadListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblPlacaUnidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPlantaDeEntregaDestino As Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
    Friend WithEvents UcClienteTerceroDestino As Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlantaOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblClienteOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcClienteTerceroOrigen As Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
    Friend WithEvents UcPlantaDeEntregaOrigen As Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
    Friend WithEvents rbtClienteTercero As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtPlantaCliente As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPlantaDeEntregaPropioDestino As Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
    Friend WithEvents txtNumeroContenedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSigla As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTipoDoc As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMotivoTraslado As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblFechaTraslado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaTraslado As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFactura As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroFactura As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents lblNroFactura As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObsOtrosMotivos As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblMotivoDespacho As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCodCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblFechaEmision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkAutoGenerar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents dtgDetalleGuia As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkRecojo As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents BeGuiaRemisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssAgregar As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTipoPedido As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNumeroPedido As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtOrdenDeCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtManChoferes As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtMantCamiones As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSRECL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNGU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQPSGU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCUNPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTOBDGS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabGlosa As System.Windows.Forms.TabPage
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TabObservacion As System.Windows.Forms.TabPage
    Friend WithEvents dtgObservacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TOBSGS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
