<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicInforRecOCAlmacen
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
        Me.components = New System.ComponentModel.Container()
        Dim BePlantaDeEntrega1 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim BePlantaDeEntrega2 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolicInforRecOCAlmacen))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.txtContenedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblContenedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dteFechaRecepcion = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTobs = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.gbEmbalaje = New System.Windows.Forms.GroupBox()
        Me.chkSi = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.chkNo = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.UcClienteTerceroOrigen = New Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01()
        Me.txtNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOrigen = New Ransa.Utilitario.ucAyuda()
        Me.lblTipoDoc = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTipoDoc = New Ransa.Utilitario.ucAyuda()
        Me.lblObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTipoMovimientoIng = New Ransa.Utilitario.ucAyuda()
        Me.txtEmbarque = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnAdjuntarEmbarque = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtManChoferes = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtMantCamiones = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaEmpresaTransporteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaUnidadListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblBrevete = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtBrevete = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaBreveteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.chkDesglose = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.lblTipoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnAgregarRecepcionItem = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaZonaAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblNroRUCCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaTipoAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.dgvOCRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.pNRITOC_NroItemOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pTMRCD2_MercaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pQCNREC_QtaRecibida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pCUNCN5_UnidadCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.gbEmbalaje.SuspendLayout()
        CType(Me.dgvOCRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContenedor
        '
        Me.txtContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContenedor.Location = New System.Drawing.Point(378, 325)
        Me.txtContenedor.MaxLength = 11
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.Size = New System.Drawing.Size(97, 22)
        Me.txtContenedor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContenedor.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtContenedor.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtContenedor.TabIndex = 18
        '
        'lblContenedor
        '
        Me.lblContenedor.Location = New System.Drawing.Point(300, 326)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(81, 20)
        Me.lblContenedor.TabIndex = 17
        Me.lblContenedor.Text = "Contenedor : "
        Me.lblContenedor.Values.ExtraText = ""
        Me.lblContenedor.Values.Image = Nothing
        Me.lblContenedor.Values.Text = "Contenedor : "
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dteFechaRecepcion)
        Me.KryptonPanel.Controls.Add(Me.lblFechaRecepcion)
        Me.KryptonPanel.Controls.Add(Me.txtTobs)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.gbEmbalaje)
        Me.KryptonPanel.Controls.Add(Me.UcClienteTerceroOrigen)
        Me.KryptonPanel.Controls.Add(Me.txtNroGuiaCliente)
        Me.KryptonPanel.Controls.Add(Me.lblOrigen)
        Me.KryptonPanel.Controls.Add(Me.txtOrigen)
        Me.KryptonPanel.Controls.Add(Me.lblTipoDoc)
        Me.KryptonPanel.Controls.Add(Me.txtTipoDoc)
        Me.KryptonPanel.Controls.Add(Me.lblObservaciones)
        Me.KryptonPanel.Controls.Add(Me.txtObservaciones)
        Me.KryptonPanel.Controls.Add(Me.txtTipoMovimientoIng)
        Me.KryptonPanel.Controls.Add(Me.txtEmbarque)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.txtManChoferes)
        Me.KryptonPanel.Controls.Add(Me.txtMantCamiones)
        Me.KryptonPanel.Controls.Add(Me.txtEmpresaTransporte)
        Me.KryptonPanel.Controls.Add(Me.lblUnidad)
        Me.KryptonPanel.Controls.Add(Me.txtUnidad)
        Me.KryptonPanel.Controls.Add(Me.lblEmpresaTransporte)
        Me.KryptonPanel.Controls.Add(Me.lblBrevete)
        Me.KryptonPanel.Controls.Add(Me.txtBrevete)
        Me.KryptonPanel.Controls.Add(Me.txtContenedor)
        Me.KryptonPanel.Controls.Add(Me.lblContenedor)
        Me.KryptonPanel.Controls.Add(Me.chkDesglose)
        Me.KryptonPanel.Controls.Add(Me.lblTipoRecepcion)
        Me.KryptonPanel.Controls.Add(Me.txtNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAgregarRecepcionItem)
        Me.KryptonPanel.Controls.Add(Me.txtZonaAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblNroRUCCliente)
        Me.KryptonPanel.Controls.Add(Me.lblNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.txtAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtTipoAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblNroGuiaCliente)
        Me.KryptonPanel.Controls.Add(Me.lblZonaAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblTipoAlmacen)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(511, 419)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'dteFechaRecepcion
        '
        Me.dteFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaRecepcion.Location = New System.Drawing.Point(85, 16)
        Me.dteFechaRecepcion.Name = "dteFechaRecepcion"
        Me.dteFechaRecepcion.Size = New System.Drawing.Size(136, 20)
        Me.dteFechaRecepcion.TabIndex = 1
        '
        'lblFechaRecepcion
        '
        Me.lblFechaRecepcion.Location = New System.Drawing.Point(12, 17)
        Me.lblFechaRecepcion.Name = "lblFechaRecepcion"
        Me.lblFechaRecepcion.Size = New System.Drawing.Size(74, 20)
        Me.lblFechaRecepcion.TabIndex = 99
        Me.lblFechaRecepcion.Text = "Fecha Rec. :"
        Me.lblFechaRecepcion.Values.ExtraText = ""
        Me.lblFechaRecepcion.Values.Image = Nothing
        Me.lblFechaRecepcion.Values.Text = "Fecha Rec. :"
        '
        'txtTobs
        '
        Me.txtTobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTobs.Location = New System.Drawing.Point(84, 247)
        Me.txtTobs.MaxLength = 60
        Me.txtTobs.Multiline = True
        Me.txtTobs.Name = "txtTobs"
        Me.txtTobs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTobs.Size = New System.Drawing.Size(389, 73)
        Me.txtTobs.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtTobs.TabIndex = 15
        Me.txtTobs.Visible = False
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(-1, 247)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(84, 20)
        Me.KryptonLabel2.TabIndex = 96
        Me.KryptonLabel2.Text = "Observación : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Observación : "
        Me.KryptonLabel2.Visible = False
        '
        'gbEmbalaje
        '
        Me.gbEmbalaje.BackColor = System.Drawing.Color.Transparent
        Me.gbEmbalaje.Controls.Add(Me.chkSi)
        Me.gbEmbalaje.Controls.Add(Me.chkNo)
        Me.gbEmbalaje.Location = New System.Drawing.Point(86, 351)
        Me.gbEmbalaje.Name = "gbEmbalaje"
        Me.gbEmbalaje.Size = New System.Drawing.Size(206, 39)
        Me.gbEmbalaje.TabIndex = 19
        Me.gbEmbalaje.TabStop = False
        Me.gbEmbalaje.Text = "Control de embalaje según O/C"
        '
        'chkSi
        '
        Me.chkSi.Location = New System.Drawing.Point(38, 16)
        Me.chkSi.Name = "chkSi"
        Me.chkSi.Size = New System.Drawing.Size(32, 20)
        Me.chkSi.TabIndex = 0
        Me.chkSi.Text = "Si"
        Me.chkSi.Values.ExtraText = ""
        Me.chkSi.Values.Image = Nothing
        Me.chkSi.Values.Text = "Si"
        '
        'chkNo
        '
        Me.chkNo.Checked = True
        Me.chkNo.Location = New System.Drawing.Point(126, 16)
        Me.chkNo.Name = "chkNo"
        Me.chkNo.Size = New System.Drawing.Size(39, 20)
        Me.chkNo.TabIndex = 1
        Me.chkNo.Text = "No"
        Me.chkNo.Values.ExtraText = ""
        Me.chkNo.Values.Image = Nothing
        Me.chkNo.Values.Text = "No"
        '
        'UcClienteTerceroOrigen
        '
        Me.UcClienteTerceroOrigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteTerceroOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcClienteTerceroOrigen.CodCliente = 0.0R
        Me.UcClienteTerceroOrigen.CodigoPlantaCliente = 0.0R
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
        Me.UcClienteTerceroOrigen.Location = New System.Drawing.Point(290, 37)
        Me.UcClienteTerceroOrigen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcClienteTerceroOrigen.MostrarRuc = False
        Me.UcClienteTerceroOrigen.Name = "UcClienteTerceroOrigen"
        Me.UcClienteTerceroOrigen.Ruc = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcClienteTerceroOrigen.Size = New System.Drawing.Size(184, 22)
        Me.UcClienteTerceroOrigen.TabIndex = 4
        Me.UcClienteTerceroOrigen.TipoRelacion = ""
        '
        'txtNroGuiaCliente
        '
        Me.txtNroGuiaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroGuiaCliente.Location = New System.Drawing.Point(290, 64)
        Me.txtNroGuiaCliente.MaxLength = 15
        Me.txtNroGuiaCliente.Name = "txtNroGuiaCliente"
        Me.txtNroGuiaCliente.Size = New System.Drawing.Size(184, 22)
        Me.txtNroGuiaCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroGuiaCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroGuiaCliente.TabIndex = 6
        Me.txtNroGuiaCliente.Text = "0"
        '
        'lblOrigen
        '
        Me.lblOrigen.Location = New System.Drawing.Point(29, 40)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(54, 20)
        Me.lblOrigen.TabIndex = 95
        Me.lblOrigen.Text = "Origen :"
        Me.lblOrigen.Values.ExtraText = ""
        Me.lblOrigen.Values.Image = Nothing
        Me.lblOrigen.Values.Text = "Origen :"
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.White
        Me.txtOrigen.DataSource = Nothing
        Me.txtOrigen.DispleyMember = ""
        Me.txtOrigen.Etiquetas_Form = Nothing
        Me.txtOrigen.ListColumnas = Nothing
        Me.txtOrigen.Location = New System.Drawing.Point(85, 40)
        Me.txtOrigen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Obligatorio = True
        Me.txtOrigen.PopupHeight = 0
        Me.txtOrigen.PopupWidth = 0
        Me.txtOrigen.Size = New System.Drawing.Size(140, 21)
        Me.txtOrigen.SizeFont = 0
        Me.txtOrigen.TabIndex = 3
        Me.txtOrigen.ValueMember = ""
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.Location = New System.Drawing.Point(16, 67)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(68, 20)
        Me.lblTipoDoc.TabIndex = 93
        Me.lblTipoDoc.Text = "Tipo Doc. : "
        Me.lblTipoDoc.Values.ExtraText = ""
        Me.lblTipoDoc.Values.Image = Nothing
        Me.lblTipoDoc.Values.Text = "Tipo Doc. : "
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.BackColor = System.Drawing.Color.White
        Me.txtTipoDoc.DataSource = Nothing
        Me.txtTipoDoc.DispleyMember = ""
        Me.txtTipoDoc.Etiquetas_Form = Nothing
        Me.txtTipoDoc.ListColumnas = Nothing
        Me.txtTipoDoc.Location = New System.Drawing.Point(85, 64)
        Me.txtTipoDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Obligatorio = True
        Me.txtTipoDoc.PopupHeight = 0
        Me.txtTipoDoc.PopupWidth = 0
        Me.txtTipoDoc.Size = New System.Drawing.Size(141, 21)
        Me.txtTipoDoc.SizeFont = 0
        Me.txtTipoDoc.TabIndex = 5
        Me.txtTipoDoc.ValueMember = ""
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(-3, 247)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(96, 20)
        Me.lblObservaciones.TabIndex = 91
        Me.lblObservaciones.Text = "Observaciones : "
        Me.lblObservaciones.Values.ExtraText = ""
        Me.lblObservaciones.Values.Image = Nothing
        Me.lblObservaciones.Values.Text = "Observaciones : "
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(84, 250)
        Me.txtObservaciones.MaxLength = 25
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(389, 72)
        Me.txtObservaciones.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtObservaciones.TabIndex = 13
        '
        'txtTipoMovimientoIng
        '
        Me.txtTipoMovimientoIng.BackColor = System.Drawing.Color.White
        Me.txtTipoMovimientoIng.DataSource = Nothing
        Me.txtTipoMovimientoIng.DispleyMember = ""
        Me.txtTipoMovimientoIng.Etiquetas_Form = Nothing
        Me.txtTipoMovimientoIng.ListColumnas = Nothing
        Me.txtTipoMovimientoIng.Location = New System.Drawing.Point(290, 13)
        Me.txtTipoMovimientoIng.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipoMovimientoIng.Name = "txtTipoMovimientoIng"
        Me.txtTipoMovimientoIng.Obligatorio = True
        Me.txtTipoMovimientoIng.PopupHeight = 0
        Me.txtTipoMovimientoIng.PopupWidth = 0
        Me.txtTipoMovimientoIng.Size = New System.Drawing.Size(184, 24)
        Me.txtTipoMovimientoIng.SizeFont = 0
        Me.txtTipoMovimientoIng.TabIndex = 2
        Me.txtTipoMovimientoIng.ValueMember = ""
        '
        'txtEmbarque
        '
        Me.txtEmbarque.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAdjuntarEmbarque})
        Me.txtEmbarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmbarque.Location = New System.Drawing.Point(290, 90)
        Me.txtEmbarque.MaxLength = 10
        Me.txtEmbarque.Name = "txtEmbarque"
        Me.txtEmbarque.Size = New System.Drawing.Size(184, 22)
        Me.txtEmbarque.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtEmbarque.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtEmbarque.TabIndex = 8
        Me.txtEmbarque.Text = "0"
        Me.txtEmbarque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdjuntarEmbarque
        '
        Me.btnAdjuntarEmbarque.ExtraText = ""
        Me.btnAdjuntarEmbarque.Image = Nothing
        Me.btnAdjuntarEmbarque.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnAdjuntarEmbarque.Text = ""
        Me.btnAdjuntarEmbarque.ToolTipImage = Nothing
        Me.btnAdjuntarEmbarque.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btnAdjuntarEmbarque.UniqueName = "38CFE4AA57A04E1038CFE4AA57A04E10"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(229, 90)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(69, 20)
        Me.KryptonLabel1.TabIndex = 7
        Me.KryptonLabel1.Text = "Embarque: "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Embarque: "
        '
        'txtManChoferes
        '
        Me.txtManChoferes.Location = New System.Drawing.Point(480, 214)
        Me.txtManChoferes.Name = "txtManChoferes"
        Me.txtManChoferes.Size = New System.Drawing.Size(22, 22)
        Me.txtManChoferes.TabIndex = 28
        Me.txtManChoferes.Tag = "Mantenimiento de Choferes"
        Me.txtManChoferes.Values.ExtraText = ""
        Me.txtManChoferes.Values.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
        Me.txtManChoferes.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.txtManChoferes.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.txtManChoferes.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.txtManChoferes.Values.Text = ""
        '
        'txtMantCamiones
        '
        Me.txtMantCamiones.Location = New System.Drawing.Point(226, 215)
        Me.txtMantCamiones.Name = "txtMantCamiones"
        Me.txtMantCamiones.Size = New System.Drawing.Size(22, 22)
        Me.txtMantCamiones.TabIndex = 0
        Me.txtMantCamiones.Tag = "Mantenimiento de Camiones"
        Me.txtMantCamiones.Values.ExtraText = ""
        Me.txtMantCamiones.Values.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
        Me.txtMantCamiones.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.txtMantCamiones.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.txtMantCamiones.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.txtMantCamiones.Values.Text = ""
        '
        'txtEmpresaTransporte
        '
        Me.txtEmpresaTransporte.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaEmpresaTransporteListar})
        Me.txtEmpresaTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresaTransporte.Location = New System.Drawing.Point(85, 192)
        Me.txtEmpresaTransporte.MaxLength = 30
        Me.txtEmpresaTransporte.Name = "txtEmpresaTransporte"
        Me.txtEmpresaTransporte.Size = New System.Drawing.Size(389, 22)
        Me.txtEmpresaTransporte.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmpresaTransporte.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtEmpresaTransporte.TabIndex = 12
        '
        'bsaEmpresaTransporteListar
        '
        Me.bsaEmpresaTransporteListar.ExtraText = ""
        Me.bsaEmpresaTransporteListar.Image = Nothing
        Me.bsaEmpresaTransporteListar.Text = ""
        Me.bsaEmpresaTransporteListar.ToolTipImage = Nothing
        Me.bsaEmpresaTransporteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaEmpresaTransporteListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(26, 218)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(56, 20)
        Me.lblUnidad.TabIndex = 19
        Me.lblUnidad.Text = "Unidad : "
        Me.lblUnidad.Values.ExtraText = ""
        Me.lblUnidad.Values.Image = Nothing
        Me.lblUnidad.Values.Text = "Unidad : "
        '
        'txtUnidad
        '
        Me.txtUnidad.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaUnidadListar})
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.Location = New System.Drawing.Point(85, 216)
        Me.txtUnidad.MaxLength = 6
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(137, 22)
        Me.txtUnidad.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtUnidad.TabIndex = 13
        '
        'bsaUnidadListar
        '
        Me.bsaUnidadListar.ExtraText = ""
        Me.bsaUnidadListar.Image = Nothing
        Me.bsaUnidadListar.Text = ""
        Me.bsaUnidadListar.ToolTipImage = Nothing
        Me.bsaUnidadListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaUnidadListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'lblEmpresaTransporte
        '
        Me.lblEmpresaTransporte.Location = New System.Drawing.Point(1, 193)
        Me.lblEmpresaTransporte.Name = "lblEmpresaTransporte"
        Me.lblEmpresaTransporte.Size = New System.Drawing.Size(88, 20)
        Me.lblEmpresaTransporte.TabIndex = 17
        Me.lblEmpresaTransporte.Text = "Transportista : "
        Me.lblEmpresaTransporte.Values.ExtraText = ""
        Me.lblEmpresaTransporte.Values.Image = Nothing
        Me.lblEmpresaTransporte.Values.Text = "Transportista : "
        '
        'lblBrevete
        '
        Me.lblBrevete.Location = New System.Drawing.Point(247, 218)
        Me.lblBrevete.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBrevete.Name = "lblBrevete"
        Me.lblBrevete.Size = New System.Drawing.Size(84, 20)
        Me.lblBrevete.TabIndex = 21
        Me.lblBrevete.Text = "Nro. Brevete : "
        Me.lblBrevete.Values.ExtraText = ""
        Me.lblBrevete.Values.Image = Nothing
        Me.lblBrevete.Values.Text = "Nro. Brevete : "
        '
        'txtBrevete
        '
        Me.txtBrevete.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaBreveteListar})
        Me.txtBrevete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBrevete.Location = New System.Drawing.Point(338, 216)
        Me.txtBrevete.MaxLength = 10
        Me.txtBrevete.Name = "txtBrevete"
        Me.txtBrevete.Size = New System.Drawing.Size(137, 22)
        Me.txtBrevete.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtBrevete.TabIndex = 14
        '
        'bsaBreveteListar
        '
        Me.bsaBreveteListar.ExtraText = ""
        Me.bsaBreveteListar.Image = Nothing
        Me.bsaBreveteListar.Text = ""
        Me.bsaBreveteListar.ToolTipImage = Nothing
        Me.bsaBreveteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaBreveteListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'chkDesglose
        '
        Me.chkDesglose.Checked = False
        Me.chkDesglose.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDesglose.Location = New System.Drawing.Point(86, 326)
        Me.chkDesglose.Name = "chkDesglose"
        Me.chkDesglose.Size = New System.Drawing.Size(73, 20)
        Me.chkDesglose.TabIndex = 16
        Me.chkDesglose.Text = "Desglose"
        Me.chkDesglose.Values.ExtraText = ""
        Me.chkDesglose.Values.Image = Nothing
        Me.chkDesglose.Values.Text = "Desglose"
        '
        'lblTipoRecepcion
        '
        Me.lblTipoRecepcion.Location = New System.Drawing.Point(227, 17)
        Me.lblTipoRecepcion.Name = "lblTipoRecepcion"
        Me.lblTipoRecepcion.Size = New System.Drawing.Size(66, 20)
        Me.lblTipoRecepcion.TabIndex = 15
        Me.lblTipoRecepcion.Text = "Tipo Rec. : "
        Me.lblTipoRecepcion.Values.ExtraText = ""
        Me.lblTipoRecepcion.Values.Image = Nothing
        Me.lblTipoRecepcion.Values.Text = "Tipo Rec. : "
        '
        'txtNroOrdenCompra
        '
        Me.txtNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOrdenCompra.Location = New System.Drawing.Point(85, 88)
        Me.txtNroOrdenCompra.MaxLength = 25
        Me.txtNroOrdenCompra.Name = "txtNroOrdenCompra"
        Me.txtNroOrdenCompra.ReadOnly = True
        Me.txtNroOrdenCompra.Size = New System.Drawing.Size(141, 22)
        Me.txtNroOrdenCompra.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroOrdenCompra.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroOrdenCompra.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroOrdenCompra.TabIndex = 7
        Me.txtNroOrdenCompra.TabStop = False
        Me.txtNroOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(401, 365)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 25)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnAgregarRecepcionItem
        '
        Me.btnAgregarRecepcionItem.Location = New System.Drawing.Point(315, 365)
        Me.btnAgregarRecepcionItem.Name = "btnAgregarRecepcionItem"
        Me.btnAgregarRecepcionItem.Size = New System.Drawing.Size(80, 25)
        Me.btnAgregarRecepcionItem.TabIndex = 20
        Me.btnAgregarRecepcionItem.Text = "&Aceptar"
        Me.btnAgregarRecepcionItem.Values.ExtraText = ""
        Me.btnAgregarRecepcionItem.Values.Image = CType(resources.GetObject("btnAgregarRecepcionItem.Values.Image"), System.Drawing.Image)
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregarRecepcionItem.Values.Text = "&Aceptar"
        '
        'txtZonaAlmacen
        '
        Me.txtZonaAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaZonaAlmacenListar})
        Me.txtZonaAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtZonaAlmacen.Location = New System.Drawing.Point(85, 167)
        Me.txtZonaAlmacen.MaxLength = 50
        Me.txtZonaAlmacen.Name = "txtZonaAlmacen"
        Me.txtZonaAlmacen.Size = New System.Drawing.Size(389, 22)
        Me.txtZonaAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtZonaAlmacen.TabIndex = 11
        '
        'bsaZonaAlmacenListar
        '
        Me.bsaZonaAlmacenListar.ExtraText = ""
        Me.bsaZonaAlmacenListar.Image = Nothing
        Me.bsaZonaAlmacenListar.Text = ""
        Me.bsaZonaAlmacenListar.ToolTipImage = Nothing
        Me.bsaZonaAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaZonaAlmacenListar.UniqueName = "F84D5E6A34EE4F36F84D5E6A34EE4F36"
        '
        'lblNroRUCCliente
        '
        Me.lblNroRUCCliente.Location = New System.Drawing.Point(247, 39)
        Me.lblNroRUCCliente.Name = "lblNroRUCCliente"
        Me.lblNroRUCCliente.Size = New System.Drawing.Size(48, 20)
        Me.lblNroRUCCliente.TabIndex = 5
        Me.lblNroRUCCliente.Text = "R.U.C. :"
        Me.lblNroRUCCliente.Values.ExtraText = ""
        Me.lblNroRUCCliente.Values.Image = Nothing
        Me.lblNroRUCCliente.Values.Text = "R.U.C. :"
        '
        'lblNroOrdenCompra
        '
        Me.lblNroOrdenCompra.Location = New System.Drawing.Point(19, 90)
        Me.lblNroOrdenCompra.Name = "lblNroOrdenCompra"
        Me.lblNroOrdenCompra.Size = New System.Drawing.Size(65, 20)
        Me.lblNroOrdenCompra.TabIndex = 1
        Me.lblNroOrdenCompra.Text = "Nro. O/C : "
        Me.lblNroOrdenCompra.Values.ExtraText = ""
        Me.lblNroOrdenCompra.Values.Image = Nothing
        Me.lblNroOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaAlmacenListar})
        Me.txtAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlmacen.Location = New System.Drawing.Point(86, 141)
        Me.txtAlmacen.MaxLength = 50
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Size = New System.Drawing.Size(389, 22)
        Me.txtAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlmacen.TabIndex = 10
        '
        'bsaAlmacenListar
        '
        Me.bsaAlmacenListar.ExtraText = ""
        Me.bsaAlmacenListar.Image = Nothing
        Me.bsaAlmacenListar.Text = ""
        Me.bsaAlmacenListar.ToolTipImage = Nothing
        Me.bsaAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaAlmacenListar.UniqueName = "9BC1C9592405475E9BC1C9592405475E"
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoAlmacenListar})
        Me.txtTipoAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(86, 116)
        Me.txtTipoAlmacen.MaxLength = 50
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(389, 22)
        Me.txtTipoAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoAlmacen.TabIndex = 9
        '
        'bsaTipoAlmacenListar
        '
        Me.bsaTipoAlmacenListar.ExtraText = ""
        Me.bsaTipoAlmacenListar.Image = Nothing
        Me.bsaTipoAlmacenListar.Text = ""
        Me.bsaTipoAlmacenListar.ToolTipImage = Nothing
        Me.bsaTipoAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoAlmacenListar.UniqueName = "A81EDC60E5B049C0A81EDC60E5B049C0"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(20, 145)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(64, 20)
        Me.lblAlmacen.TabIndex = 11
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'lblNroGuiaCliente
        '
        Me.lblNroGuiaCliente.Location = New System.Drawing.Point(255, 66)
        Me.lblNroGuiaCliente.Name = "lblNroGuiaCliente"
        Me.lblNroGuiaCliente.Size = New System.Drawing.Size(40, 20)
        Me.lblNroGuiaCliente.TabIndex = 3
        Me.lblNroGuiaCliente.Text = "Nor. : "
        Me.lblNroGuiaCliente.Values.ExtraText = ""
        Me.lblNroGuiaCliente.Values.Image = Nothing
        Me.lblNroGuiaCliente.Values.Text = "Nor. : "
        '
        'lblZonaAlmacen
        '
        Me.lblZonaAlmacen.Location = New System.Drawing.Point(38, 170)
        Me.lblZonaAlmacen.Name = "lblZonaAlmacen"
        Me.lblZonaAlmacen.Size = New System.Drawing.Size(44, 20)
        Me.lblZonaAlmacen.TabIndex = 13
        Me.lblZonaAlmacen.Text = "Zona : "
        Me.lblZonaAlmacen.Values.ExtraText = ""
        Me.lblZonaAlmacen.Values.Image = Nothing
        Me.lblZonaAlmacen.Values.Text = "Zona : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(41, 118)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(41, 20)
        Me.lblTipoAlmacen.TabIndex = 9
        Me.lblTipoAlmacen.Text = "Tipo : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo : "
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.ExtraText = ""
        Me.ButtonSpecAny1.Image = Nothing
        Me.ButtonSpecAny1.Text = ""
        Me.ButtonSpecAny1.ToolTipImage = Nothing
        Me.ButtonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecAny1.UniqueName = "A81EDC60E5B049C0A81EDC60E5B049C0"
        '
        'dgvOCRecepcion
        '
        Me.dgvOCRecepcion.AllowUserToAddRows = False
        Me.dgvOCRecepcion.AllowUserToDeleteRows = False
        Me.dgvOCRecepcion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pNRITOC_NroItemOC, Me.pTMRCD2_MercaDescripcion, Me.pQCNREC_QtaRecibida, Me.pCUNCN5_UnidadCantidad, Me.Column1})
        Me.dgvOCRecepcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOCRecepcion.Location = New System.Drawing.Point(0, 419)
        Me.dgvOCRecepcion.Name = "dgvOCRecepcion"
        Me.dgvOCRecepcion.ReadOnly = True
        Me.dgvOCRecepcion.Size = New System.Drawing.Size(511, 18)
        Me.dgvOCRecepcion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvOCRecepcion.TabIndex = 1
        Me.dgvOCRecepcion.Visible = False
        '
        'pNRITOC_NroItemOC
        '
        Me.pNRITOC_NroItemOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.pNRITOC_NroItemOC.DefaultCellStyle = DataGridViewCellStyle1
        Me.pNRITOC_NroItemOC.HeaderText = "Nro. Item O/C"
        Me.pNRITOC_NroItemOC.Name = "pNRITOC_NroItemOC"
        Me.pNRITOC_NroItemOC.ReadOnly = True
        Me.pNRITOC_NroItemOC.Width = 111
        '
        'pTMRCD2_MercaDescripcion
        '
        Me.pTMRCD2_MercaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.pTMRCD2_MercaDescripcion.DefaultCellStyle = DataGridViewCellStyle2
        Me.pTMRCD2_MercaDescripcion.HeaderText = "Descripción"
        Me.pTMRCD2_MercaDescripcion.Name = "pTMRCD2_MercaDescripcion"
        Me.pTMRCD2_MercaDescripcion.ReadOnly = True
        Me.pTMRCD2_MercaDescripcion.Width = 98
        '
        'pQCNREC_QtaRecibida
        '
        Me.pQCNREC_QtaRecibida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.pQCNREC_QtaRecibida.DefaultCellStyle = DataGridViewCellStyle3
        Me.pQCNREC_QtaRecibida.HeaderText = "Cant. Recibida"
        Me.pQCNREC_QtaRecibida.Name = "pQCNREC_QtaRecibida"
        Me.pQCNREC_QtaRecibida.ReadOnly = True
        Me.pQCNREC_QtaRecibida.Width = 112
        '
        'pCUNCN5_UnidadCantidad
        '
        Me.pCUNCN5_UnidadCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.pCUNCN5_UnidadCantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.pCUNCN5_UnidadCantidad.HeaderText = "Unidad"
        Me.pCUNCN5_UnidadCantidad.Name = "pCUNCN5_UnidadCantidad"
        Me.pCUNCN5_UnidadCantidad.ReadOnly = True
        Me.pCUNCN5_UnidadCantidad.Width = 74
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "..."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmSolicInforRecOCAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 437)
        Me.Controls.Add(Me.dgvOCRecepcion)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSolicInforRecOCAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.gbEmbalaje.ResumeLayout(False)
        Me.gbEmbalaje.PerformLayout()
        CType(Me.dgvOCRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    'Public Sub New()

    '    ' This call is required by the Windows Form Designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    'End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents txtContenedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents lblContenedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents chkDesglose As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblTipoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAgregarRecepcionItem As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaZonaAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblNroRUCCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaTipoAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroGuiaCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroGuiaCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtEmpresaTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaEmpresaTransporteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents lblUnidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaUnidadListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents lblEmpresaTransporte As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblBrevete As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtBrevete As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaBreveteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtManChoferes As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtMantCamiones As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtEmbarque As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnAdjuntarEmbarque As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtTipoMovimientoIng As Ransa.Utilitario.ucAyuda
    Private WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTipoDoc As Ransa.Utilitario.ucAyuda
    Private WithEvents lblObservaciones As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoDoc As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOrigen As Ransa.Utilitario.ucAyuda
    Friend WithEvents UcClienteTerceroOrigen As Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
    Friend WithEvents chkSi As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents chkNo As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents gbEmbalaje As System.Windows.Forms.GroupBox
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgvOCRecepcion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents pNRITOC_NroItemOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTMRCD2_MercaDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pQCNREC_QtaRecibida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pCUNCN5_UnidadCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTobs As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
