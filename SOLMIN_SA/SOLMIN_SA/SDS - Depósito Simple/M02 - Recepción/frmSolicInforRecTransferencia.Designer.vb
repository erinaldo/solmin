<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicInforRecTransferencia
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolicInforRecTransferencia))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.txtNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtContenedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtEmbarque = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnAdjuntarEmbarque = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroRUCCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkDesglose = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblContenedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblBrevete = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoMovimientoIng = New Ransa.Utilitario.ucAyuda
        Me.txtTipoDoc = New Ransa.Utilitario.ucAyuda
        Me.lblTipoDoc = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOrigen = New Ransa.Utilitario.ucAyuda
        Me.lblOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcClienteTerceroOrigen = New Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
        Me.gbEmbalaje = New System.Windows.Forms.GroupBox
        Me.chkSi = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.chkNo = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaRecepcion = New System.Windows.Forms.DateTimePicker
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtEmpresaTransporte = New Ransa.Utilitario.ucAyuda
        Me.txtUnidad = New Ransa.Utilitario.ucAyuda
        Me.txtBrevete = New Ransa.Utilitario.ucAyuda
        Me.txtZonaAlmacen = New Ransa.Utilitario.ucAyuda
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.Container1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dtgMovimientos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNNORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNSLCSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDESMER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQTRMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCUNCN6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQTRMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCUNPS6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNORCCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.tss03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.tss01 = New System.Windows.Forms.ToolStripSeparator
        Me.tbAsignaSerieUbicacion = New System.Windows.Forms.TabControl
        Me.TabPageUbicacion = New System.Windows.Forms.TabPage
        Me.UcUbicaciones_Lista = New Ransa.Controls.ucUbicaciones_Dg
        Me.TabPageSerie = New System.Windows.Forms.TabPage
        Me.UcSerie_Lista = New Ransa.Controls.Serie.ucSerie_Dg
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbCancelarProcesar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbProcesar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.gbEmbalaje.SuspendLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.Container1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Container1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Container1.Panel1.SuspendLayout()
        CType(Me.Container1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Container1.Panel2.SuspendLayout()
        Me.Container1.SuspendLayout()
        CType(Me.dtgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspListadoMercaderia.SuspendLayout()
        Me.tbAsignaSerieUbicacion.SuspendLayout()
        Me.TabPageUbicacion.SuspendLayout()
        Me.TabPageSerie.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNroOrdenCompra
        '
        Me.txtNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroOrdenCompra, True)
        Me.txtNroOrdenCompra.Location = New System.Drawing.Point(541, 43)
        Me.txtNroOrdenCompra.MaxLength = 25
        Me.txtNroOrdenCompra.Name = "txtNroOrdenCompra"
        Me.txtNroOrdenCompra.Size = New System.Drawing.Size(154, 22)
        Me.txtNroOrdenCompra.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroOrdenCompra.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroOrdenCompra.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroOrdenCompra.TabIndex = 6
        Me.txtNroOrdenCompra.TabStop = False
        Me.txtNroOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TypeValidator.SetTypes(Me.txtNroOrdenCompra, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtContenedor
        '
        Me.txtContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtContenedor, True)
        Me.txtContenedor.Location = New System.Drawing.Point(780, 98)
        Me.txtContenedor.MaxLength = 11
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.Size = New System.Drawing.Size(154, 22)
        Me.txtContenedor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContenedor.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtContenedor.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtContenedor.TabIndex = 16
        Me.TypeValidator.SetTypes(Me.txtContenedor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtEmbarque
        '
        Me.txtEmbarque.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAdjuntarEmbarque})
        Me.txtEmbarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtEmbarque, True)
        Me.txtEmbarque.Location = New System.Drawing.Point(780, 45)
        Me.txtEmbarque.MaxLength = 10
        Me.txtEmbarque.Name = "txtEmbarque"
        Me.txtEmbarque.Size = New System.Drawing.Size(154, 22)
        Me.txtEmbarque.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtEmbarque.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtEmbarque.TabIndex = 7
        Me.txtEmbarque.Text = "0"
        Me.txtEmbarque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TypeValidator.SetTypes(Me.txtEmbarque, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
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
        'txtNroGuiaCliente
        '
        Me.txtNroGuiaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroGuiaCliente, True)
        Me.txtNroGuiaCliente.Location = New System.Drawing.Point(313, 43)
        Me.txtNroGuiaCliente.MaxLength = 15
        Me.txtNroGuiaCliente.Name = "txtNroGuiaCliente"
        Me.txtNroGuiaCliente.Size = New System.Drawing.Size(154, 22)
        Me.txtNroGuiaCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroGuiaCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroGuiaCliente.TabIndex = 5
        Me.txtNroGuiaCliente.Text = "0"
        Me.txtNroGuiaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TypeValidator.SetTypes(Me.txtNroGuiaCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(89, 130)
        Me.txtObservaciones.MaxLength = 60
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(366, 62)
        Me.txtObservaciones.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtObservaciones.TabIndex = 17
        Me.TypeValidator.SetTypes(Me.txtObservaciones, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
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
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(45, 72)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(41, 20)
        Me.lblTipoAlmacen.TabIndex = 9
        Me.lblTipoAlmacen.Text = "Tipo : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo : "
        '
        'lblZonaAlmacen
        '
        Me.lblZonaAlmacen.Location = New System.Drawing.Point(492, 70)
        Me.lblZonaAlmacen.Name = "lblZonaAlmacen"
        Me.lblZonaAlmacen.Size = New System.Drawing.Size(44, 20)
        Me.lblZonaAlmacen.TabIndex = 13
        Me.lblZonaAlmacen.Text = "Zona : "
        Me.lblZonaAlmacen.Values.ExtraText = ""
        Me.lblZonaAlmacen.Values.Image = Nothing
        Me.lblZonaAlmacen.Values.Text = "Zona : "
        '
        'lblNroGuiaCliente
        '
        Me.lblNroGuiaCliente.Location = New System.Drawing.Point(270, 45)
        Me.lblNroGuiaCliente.Name = "lblNroGuiaCliente"
        Me.lblNroGuiaCliente.Size = New System.Drawing.Size(40, 20)
        Me.lblNroGuiaCliente.TabIndex = 3
        Me.lblNroGuiaCliente.Text = "Nor. : "
        Me.lblNroGuiaCliente.Values.ExtraText = ""
        Me.lblNroGuiaCliente.Values.Image = Nothing
        Me.lblNroGuiaCliente.Values.Text = "Nor. : "
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(246, 73)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(64, 20)
        Me.lblAlmacen.TabIndex = 11
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'lblNroOrdenCompra
        '
        Me.lblNroOrdenCompra.Location = New System.Drawing.Point(471, 45)
        Me.lblNroOrdenCompra.Name = "lblNroOrdenCompra"
        Me.lblNroOrdenCompra.Size = New System.Drawing.Size(65, 20)
        Me.lblNroOrdenCompra.TabIndex = 1
        Me.lblNroOrdenCompra.Text = "Nro. O/C : "
        Me.lblNroOrdenCompra.Values.ExtraText = ""
        Me.lblNroOrdenCompra.Values.Image = Nothing
        Me.lblNroOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'lblNroRUCCliente
        '
        Me.lblNroRUCCliente.Location = New System.Drawing.Point(736, 16)
        Me.lblNroRUCCliente.Name = "lblNroRUCCliente"
        Me.lblNroRUCCliente.Size = New System.Drawing.Size(48, 20)
        Me.lblNroRUCCliente.TabIndex = 5
        Me.lblNroRUCCliente.Text = "R.U.C. :"
        Me.lblNroRUCCliente.Values.ExtraText = ""
        Me.lblNroRUCCliente.Values.Image = Nothing
        Me.lblNroRUCCliente.Values.Text = "R.U.C. :"
        '
        'lblTipoRecepcion
        '
        Me.lblTipoRecepcion.Location = New System.Drawing.Point(244, 16)
        Me.lblTipoRecepcion.Name = "lblTipoRecepcion"
        Me.lblTipoRecepcion.Size = New System.Drawing.Size(66, 20)
        Me.lblTipoRecepcion.TabIndex = 15
        Me.lblTipoRecepcion.Text = "Tipo Rec. : "
        Me.lblTipoRecepcion.Values.ExtraText = ""
        Me.lblTipoRecepcion.Values.Image = Nothing
        Me.lblTipoRecepcion.Values.Text = "Tipo Rec. : "
        '
        'chkDesglose
        '
        Me.chkDesglose.Checked = False
        Me.chkDesglose.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDesglose.Location = New System.Drawing.Point(713, 73)
        Me.chkDesglose.Name = "chkDesglose"
        Me.chkDesglose.Size = New System.Drawing.Size(73, 20)
        Me.chkDesglose.TabIndex = 11
        Me.chkDesglose.Text = "Desglose"
        Me.chkDesglose.Values.ExtraText = ""
        Me.chkDesglose.Values.Image = Nothing
        Me.chkDesglose.Values.Text = "Desglose"
        '
        'lblContenedor
        '
        Me.lblContenedor.Location = New System.Drawing.Point(703, 100)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(81, 20)
        Me.lblContenedor.TabIndex = 15
        Me.lblContenedor.Text = "Contenedor : "
        Me.lblContenedor.Values.ExtraText = ""
        Me.lblContenedor.Values.Image = Nothing
        Me.lblContenedor.Values.Text = "Contenedor : "
        '
        'lblBrevete
        '
        Me.lblBrevete.Location = New System.Drawing.Point(484, 103)
        Me.lblBrevete.Name = "lblBrevete"
        Me.lblBrevete.Size = New System.Drawing.Size(57, 20)
        Me.lblBrevete.TabIndex = 21
        Me.lblBrevete.Text = "Brevete : "
        Me.lblBrevete.Values.ExtraText = ""
        Me.lblBrevete.Values.Image = Nothing
        Me.lblBrevete.Values.Text = "Brevete : "
        '
        'lblEmpresaTransporte
        '
        Me.lblEmpresaTransporte.Location = New System.Drawing.Point(-2, 103)
        Me.lblEmpresaTransporte.Name = "lblEmpresaTransporte"
        Me.lblEmpresaTransporte.Size = New System.Drawing.Size(88, 20)
        Me.lblEmpresaTransporte.TabIndex = 17
        Me.lblEmpresaTransporte.Text = "Transportista : "
        Me.lblEmpresaTransporte.Values.ExtraText = ""
        Me.lblEmpresaTransporte.Values.Image = Nothing
        Me.lblEmpresaTransporte.Values.Text = "Transportista : "
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(254, 103)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(56, 20)
        Me.lblUnidad.TabIndex = 19
        Me.lblUnidad.Text = "Unidad : "
        Me.lblUnidad.Values.ExtraText = ""
        Me.lblUnidad.Values.Image = Nothing
        Me.lblUnidad.Values.Text = "Unidad : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(712, 47)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel1.TabIndex = 7
        Me.KryptonLabel1.Text = "Embarque : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Embarque : "
        '
        'txtTipoMovimientoIng
        '
        Me.txtTipoMovimientoIng.BackColor = System.Drawing.Color.White
        Me.txtTipoMovimientoIng.DataSource = Nothing
        Me.txtTipoMovimientoIng.DispleyMember = ""
        Me.txtTipoMovimientoIng.Enabled = False
        Me.txtTipoMovimientoIng.ListColumnas = Nothing
        Me.txtTipoMovimientoIng.Location = New System.Drawing.Point(313, 12)
        Me.txtTipoMovimientoIng.Name = "txtTipoMovimientoIng"
        Me.txtTipoMovimientoIng.Obligatorio = True
        Me.txtTipoMovimientoIng.Size = New System.Drawing.Size(154, 24)
        Me.txtTipoMovimientoIng.TabIndex = 1
        Me.txtTipoMovimientoIng.ValueMember = ""
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.BackColor = System.Drawing.Color.White
        Me.txtTipoDoc.DataSource = Nothing
        Me.txtTipoDoc.DispleyMember = ""
        Me.txtTipoDoc.Enabled = False
        Me.txtTipoDoc.ListColumnas = Nothing
        Me.txtTipoDoc.Location = New System.Drawing.Point(89, 44)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Obligatorio = True
        Me.txtTipoDoc.Size = New System.Drawing.Size(157, 23)
        Me.txtTipoDoc.TabIndex = 4
        Me.txtTipoDoc.ValueMember = ""
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.Location = New System.Drawing.Point(18, 45)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(68, 20)
        Me.lblTipoDoc.TabIndex = 93
        Me.lblTipoDoc.Text = "Tipo Doc. : "
        Me.lblTipoDoc.Values.ExtraText = ""
        Me.lblTipoDoc.Values.Image = Nothing
        Me.lblTipoDoc.Values.Text = "Tipo Doc. : "
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.White
        Me.txtOrigen.DataSource = Nothing
        Me.txtOrigen.DispleyMember = ""
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.ListColumnas = Nothing
        Me.txtOrigen.Location = New System.Drawing.Point(541, 12)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Obligatorio = True
        Me.txtOrigen.Size = New System.Drawing.Size(154, 27)
        Me.txtOrigen.TabIndex = 2
        Me.txtOrigen.ValueMember = ""
        '
        'lblOrigen
        '
        Me.lblOrigen.Location = New System.Drawing.Point(482, 16)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(54, 20)
        Me.lblOrigen.TabIndex = 95
        Me.lblOrigen.Text = "Origen :"
        Me.lblOrigen.Values.ExtraText = ""
        Me.lblOrigen.Values.Image = Nothing
        Me.lblOrigen.Values.Text = "Origen :"
        '
        'UcClienteTerceroOrigen
        '
        Me.UcClienteTerceroOrigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteTerceroOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.UcClienteTerceroOrigen.Location = New System.Drawing.Point(780, 12)
        Me.UcClienteTerceroOrigen.MostrarRuc = False
        Me.UcClienteTerceroOrigen.Name = "UcClienteTerceroOrigen"
        Me.UcClienteTerceroOrigen.Ruc = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcClienteTerceroOrigen.Size = New System.Drawing.Size(154, 22)
        Me.UcClienteTerceroOrigen.TabIndex = 3
        Me.UcClienteTerceroOrigen.TipoRelacion = ""
        '
        'gbEmbalaje
        '
        Me.gbEmbalaje.BackColor = System.Drawing.Color.Transparent
        Me.gbEmbalaje.Controls.Add(Me.chkSi)
        Me.gbEmbalaje.Controls.Add(Me.chkNo)
        Me.gbEmbalaje.Location = New System.Drawing.Point(471, 130)
        Me.gbEmbalaje.Name = "gbEmbalaje"
        Me.gbEmbalaje.Size = New System.Drawing.Size(206, 39)
        Me.gbEmbalaje.TabIndex = 18
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
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(2, 130)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(84, 20)
        Me.KryptonLabel2.TabIndex = 96
        Me.KryptonLabel2.Text = "Observación : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Observación : "
        '
        'lblFechaRecepcion
        '
        Me.lblFechaRecepcion.Location = New System.Drawing.Point(12, 16)
        Me.lblFechaRecepcion.Name = "lblFechaRecepcion"
        Me.lblFechaRecepcion.Size = New System.Drawing.Size(74, 20)
        Me.lblFechaRecepcion.TabIndex = 99
        Me.lblFechaRecepcion.Text = "Fecha Rec. :"
        Me.lblFechaRecepcion.Values.ExtraText = ""
        Me.lblFechaRecepcion.Values.Image = Nothing
        Me.lblFechaRecepcion.Values.Text = "Fecha Rec. :"
        '
        'dteFechaRecepcion
        '
        Me.dteFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaRecepcion.Location = New System.Drawing.Point(91, 16)
        Me.dteFechaRecepcion.Name = "dteFechaRecepcion"
        Me.dteFechaRecepcion.Size = New System.Drawing.Size(92, 20)
        Me.dteFechaRecepcion.TabIndex = 0
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(89, 73)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = True
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(157, 23)
        Me.txtTipoAlmacen.TabIndex = 8
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(313, 73)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = True
        Me.txtAlmacen.Size = New System.Drawing.Size(154, 23)
        Me.txtAlmacen.TabIndex = 9
        Me.txtAlmacen.ValueMember = ""
        '
        'txtEmpresaTransporte
        '
        Me.txtEmpresaTransporte.BackColor = System.Drawing.Color.White
        Me.txtEmpresaTransporte.DataSource = Nothing
        Me.txtEmpresaTransporte.DispleyMember = ""
        Me.txtEmpresaTransporte.ListColumnas = Nothing
        Me.txtEmpresaTransporte.Location = New System.Drawing.Point(89, 100)
        Me.txtEmpresaTransporte.Name = "txtEmpresaTransporte"
        Me.txtEmpresaTransporte.Obligatorio = True
        Me.txtEmpresaTransporte.Size = New System.Drawing.Size(157, 23)
        Me.txtEmpresaTransporte.TabIndex = 12
        Me.txtEmpresaTransporte.ValueMember = ""
        '
        'txtUnidad
        '
        Me.txtUnidad.BackColor = System.Drawing.Color.White
        Me.txtUnidad.DataSource = Nothing
        Me.txtUnidad.DispleyMember = ""
        Me.txtUnidad.ListColumnas = Nothing
        Me.txtUnidad.Location = New System.Drawing.Point(313, 100)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Obligatorio = False
        Me.txtUnidad.Size = New System.Drawing.Size(154, 23)
        Me.txtUnidad.TabIndex = 13
        Me.txtUnidad.ValueMember = ""
        '
        'txtBrevete
        '
        Me.txtBrevete.BackColor = System.Drawing.Color.White
        Me.txtBrevete.DataSource = Nothing
        Me.txtBrevete.DispleyMember = ""
        Me.txtBrevete.ListColumnas = Nothing
        Me.txtBrevete.Location = New System.Drawing.Point(541, 103)
        Me.txtBrevete.Name = "txtBrevete"
        Me.txtBrevete.Obligatorio = False
        Me.txtBrevete.Size = New System.Drawing.Size(157, 23)
        Me.txtBrevete.TabIndex = 14
        Me.txtBrevete.ValueMember = ""
        '
        'txtZonaAlmacen
        '
        Me.txtZonaAlmacen.BackColor = System.Drawing.Color.White
        Me.txtZonaAlmacen.DataSource = Nothing
        Me.txtZonaAlmacen.DispleyMember = ""
        Me.txtZonaAlmacen.ListColumnas = Nothing
        Me.txtZonaAlmacen.Location = New System.Drawing.Point(541, 73)
        Me.txtZonaAlmacen.Name = "txtZonaAlmacen"
        Me.txtZonaAlmacen.Obligatorio = True
        Me.txtZonaAlmacen.Size = New System.Drawing.Size(157, 23)
        Me.txtZonaAlmacen.TabIndex = 10
        Me.txtZonaAlmacen.ValueMember = ""
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtZonaAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtBrevete)
        Me.KryptonPanel.Controls.Add(Me.txtUnidad)
        Me.KryptonPanel.Controls.Add(Me.txtEmpresaTransporte)
        Me.KryptonPanel.Controls.Add(Me.txtAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtTipoAlmacen)
        Me.KryptonPanel.Controls.Add(Me.dteFechaRecepcion)
        Me.KryptonPanel.Controls.Add(Me.lblFechaRecepcion)
        Me.KryptonPanel.Controls.Add(Me.txtObservaciones)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.gbEmbalaje)
        Me.KryptonPanel.Controls.Add(Me.UcClienteTerceroOrigen)
        Me.KryptonPanel.Controls.Add(Me.txtNroGuiaCliente)
        Me.KryptonPanel.Controls.Add(Me.lblOrigen)
        Me.KryptonPanel.Controls.Add(Me.txtOrigen)
        Me.KryptonPanel.Controls.Add(Me.lblTipoDoc)
        Me.KryptonPanel.Controls.Add(Me.txtTipoDoc)
        Me.KryptonPanel.Controls.Add(Me.txtTipoMovimientoIng)
        Me.KryptonPanel.Controls.Add(Me.txtEmbarque)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.lblUnidad)
        Me.KryptonPanel.Controls.Add(Me.lblEmpresaTransporte)
        Me.KryptonPanel.Controls.Add(Me.lblBrevete)
        Me.KryptonPanel.Controls.Add(Me.txtContenedor)
        Me.KryptonPanel.Controls.Add(Me.lblContenedor)
        Me.KryptonPanel.Controls.Add(Me.chkDesglose)
        Me.KryptonPanel.Controls.Add(Me.lblTipoRecepcion)
        Me.KryptonPanel.Controls.Add(Me.txtNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.lblNroRUCCliente)
        Me.KryptonPanel.Controls.Add(Me.lblNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.lblAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblNroGuiaCliente)
        Me.KryptonPanel.Controls.Add(Me.lblZonaAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblTipoAlmacen)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(950, 203)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'Container1
        '
        Me.Container1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Container1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Container1.Location = New System.Drawing.Point(0, 0)
        Me.Container1.Name = "Container1"
        Me.Container1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Container1.Panel1
        '
        Me.Container1.Panel1.Controls.Add(Me.dtgMovimientos)
        Me.Container1.Panel1.Controls.Add(Me.tspListadoMercaderia)
        Me.Container1.Panel1.Controls.Add(Me.KryptonPanel)
        '
        'Container1.Panel2
        '
        Me.Container1.Panel2.Controls.Add(Me.tbAsignaSerieUbicacion)
        Me.Container1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Container1.Size = New System.Drawing.Size(950, 602)
        Me.Container1.SplitterDistance = 372
        Me.Container1.TabIndex = 102
        '
        'dtgMovimientos
        '
        Me.dtgMovimientos.AllowUserToAddRows = False
        Me.dtgMovimientos.AllowUserToDeleteRows = False
        Me.dtgMovimientos.AllowUserToResizeColumns = False
        Me.dtgMovimientos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dtgMovimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNNORDSR, Me.PNNSLCSR, Me.CMRCLR, Me.PSDESMER, Me.PNQTRMC, Me.PSCUNCN6, Me.PNQTRMP, Me.PSCUNPS6, Me.PSNORCCL, Me.PNNRITOC})
        Me.dtgMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgMovimientos.Location = New System.Drawing.Point(0, 228)
        Me.dtgMovimientos.MultiSelect = False
        Me.dtgMovimientos.Name = "dtgMovimientos"
        Me.dtgMovimientos.ReadOnly = True
        Me.dtgMovimientos.RowHeadersWidth = 20
        Me.dtgMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgMovimientos.Size = New System.Drawing.Size(950, 144)
        Me.dtgMovimientos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgMovimientos.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgMovimientos.TabIndex = 21
        '
        'PNNORDSR
        '
        Me.PNNORDSR.DataPropertyName = "PNNORDSR"
        Me.PNNORDSR.HeaderText = "Orden de Servicio"
        Me.PNNORDSR.Name = "PNNORDSR"
        Me.PNNORDSR.ReadOnly = True
        Me.PNNORDSR.Width = 129
        '
        'PNNSLCSR
        '
        Me.PNNSLCSR.DataPropertyName = "PNNSLCSR"
        Me.PNNSLCSR.HeaderText = "Nr. Solicitud Servicio"
        Me.PNNSLCSR.Name = "PNNSLCSR"
        Me.PNNSLCSR.ReadOnly = True
        Me.PNNSLCSR.Width = 145
        '
        'CMRCLR
        '
        Me.CMRCLR.DataPropertyName = "PSCMRCLR"
        Me.CMRCLR.HeaderText = "Cod. Mercadería"
        Me.CMRCLR.Name = "CMRCLR"
        Me.CMRCLR.ReadOnly = True
        Me.CMRCLR.Width = 123
        '
        'PSDESMER
        '
        Me.PSDESMER.DataPropertyName = "PSDESMER"
        Me.PSDESMER.HeaderText = "Mercadería"
        Me.PSDESMER.Name = "PSDESMER"
        Me.PSDESMER.ReadOnly = True
        Me.PSDESMER.Width = 95
        '
        'PNQTRMC
        '
        Me.PNQTRMC.DataPropertyName = "PNQTRMC"
        Me.PNQTRMC.HeaderText = "Cantidad"
        Me.PNQTRMC.Name = "PNQTRMC"
        Me.PNQTRMC.ReadOnly = True
        Me.PNQTRMC.Width = 84
        '
        'PSCUNCN6
        '
        Me.PSCUNCN6.DataPropertyName = "PSCUNCN6"
        Me.PSCUNCN6.HeaderText = "Unidad"
        Me.PSCUNCN6.Name = "PSCUNCN6"
        Me.PSCUNCN6.ReadOnly = True
        Me.PSCUNCN6.Width = 74
        '
        'PNQTRMP
        '
        Me.PNQTRMP.DataPropertyName = "PNQTRMP"
        Me.PNQTRMP.HeaderText = "Peso"
        Me.PNQTRMP.Name = "PNQTRMP"
        Me.PNQTRMP.ReadOnly = True
        Me.PNQTRMP.Width = 61
        '
        'PSCUNPS6
        '
        Me.PSCUNPS6.DataPropertyName = "PSCUNPS6"
        Me.PSCUNPS6.HeaderText = "Unidad"
        Me.PSCUNPS6.Name = "PSCUNPS6"
        Me.PSCUNPS6.ReadOnly = True
        Me.PSCUNPS6.Width = 74
        '
        'PSNORCCL
        '
        Me.PSNORCCL.DataPropertyName = "PSNORCCL"
        Me.PSNORCCL.HeaderText = "Orden de Compra"
        Me.PSNORCCL.Name = "PSNORCCL"
        Me.PSNORCCL.ReadOnly = True
        Me.PSNORCCL.Width = 131
        '
        'PNNRITOC
        '
        Me.PNNRITOC.DataPropertyName = "PNNRITOC"
        Me.PNNRITOC.HeaderText = "Nr. Item"
        Me.PNNRITOC.Name = "PNNRITOC"
        Me.PNNRITOC.ReadOnly = True
        Me.PNNRITOC.Width = 79
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCancelar, Me.tss03, Me.btnAceptar, Me.tss01})
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 203)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(950, 25)
        Me.tspListadoMercaderia.TabIndex = 63
        Me.tspListadoMercaderia.Text = "Anular Items"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.Cancelar
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'tss03
        '
        Me.tss03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss03.Name = "tss03"
        Me.tss03.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_SA.My.Resources.Resources.ProcesarRecepcion
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(130, 22)
        Me.btnAceptar.Text = "Procesar Recepción"
        '
        'tss01
        '
        Me.tss01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss01.Name = "tss01"
        Me.tss01.Size = New System.Drawing.Size(6, 25)
        '
        'tbAsignaSerieUbicacion
        '
        Me.tbAsignaSerieUbicacion.Controls.Add(Me.TabPageUbicacion)
        Me.tbAsignaSerieUbicacion.Controls.Add(Me.TabPageSerie)
        Me.tbAsignaSerieUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbAsignaSerieUbicacion.Location = New System.Drawing.Point(0, 25)
        Me.tbAsignaSerieUbicacion.Name = "tbAsignaSerieUbicacion"
        Me.tbAsignaSerieUbicacion.SelectedIndex = 0
        Me.tbAsignaSerieUbicacion.Size = New System.Drawing.Size(950, 200)
        Me.tbAsignaSerieUbicacion.TabIndex = 101
        '
        'TabPageUbicacion
        '
        Me.TabPageUbicacion.Controls.Add(Me.UcUbicaciones_Lista)
        Me.TabPageUbicacion.Location = New System.Drawing.Point(4, 22)
        Me.TabPageUbicacion.Name = "TabPageUbicacion"
        Me.TabPageUbicacion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUbicacion.Size = New System.Drawing.Size(942, 174)
        Me.TabPageUbicacion.TabIndex = 1
        Me.TabPageUbicacion.Text = "Ubicaciones"
        Me.TabPageUbicacion.UseVisualStyleBackColor = True
        '
        'UcUbicaciones_Lista
        '
        Me.UcUbicaciones_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcUbicaciones_Lista.Location = New System.Drawing.Point(3, 3)
        Me.UcUbicaciones_Lista.ModoGrid = Ransa.Controls.eModoGrid.Ingreso
        Me.UcUbicaciones_Lista.Name = "UcUbicaciones_Lista"
        Me.UcUbicaciones_Lista.PanelSearch = False
        Me.UcUbicaciones_Lista.Size = New System.Drawing.Size(936, 168)
        Me.UcUbicaciones_Lista.TabIndex = 0
        Me.UcUbicaciones_Lista.VisibleCaption = False
        '
        'TabPageSerie
        '
        Me.TabPageSerie.Controls.Add(Me.UcSerie_Lista)
        Me.TabPageSerie.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSerie.Name = "TabPageSerie"
        Me.TabPageSerie.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSerie.Size = New System.Drawing.Size(942, 174)
        Me.TabPageSerie.TabIndex = 0
        Me.TabPageSerie.Text = "Series"
        Me.TabPageSerie.UseVisualStyleBackColor = True
        '
        'UcSerie_Lista
        '
        Me.UcSerie_Lista.DespachoIsReadOnly = False
        Me.UcSerie_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcSerie_Lista.GridTipo = Ransa.Controls.Serie.eGridSerieTipo.IngresoSerie
        Me.UcSerie_Lista.Location = New System.Drawing.Point(3, 3)
        Me.UcSerie_Lista.Name = "UcSerie_Lista"
        Me.UcSerie_Lista.Size = New System.Drawing.Size(936, 168)
        Me.UcSerie_Lista.TabIndex = 30
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCancelarProcesar, Me.ToolStripSeparator5, Me.tsbProcesar, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(950, 25)
        Me.ToolStrip1.TabIndex = 102
        Me.ToolStrip1.Text = "Anular Items"
        '
        'tsbCancelarProcesar
        '
        Me.tsbCancelarProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelarProcesar.Image = Global.SOLMIN_SA.My.Resources.Resources.Cancelar
        Me.tsbCancelarProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelarProcesar.Name = "tsbCancelarProcesar"
        Me.tsbCancelarProcesar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelarProcesar.Text = "Cancelar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbProcesar
        '
        Me.tsbProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbProcesar.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.tsbProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProcesar.Name = "tsbProcesar"
        Me.tsbProcesar.Size = New System.Drawing.Size(174, 22)
        Me.tsbProcesar.Text = "Procesar Ubicaciones/Series"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.SOLMIN_SA.My.Resources.Resources.Cancelar
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = Global.SOLMIN_SA.My.Resources.Resources.Agregar
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripButton2.Text = "Aceptar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackgroundImage = CType(resources.GetObject("ToolStripButton3.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripButton3.CheckOnClick = True
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripButton3.Text = "Marcar Todos"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.Image = Global.SOLMIN_SA.My.Resources.Resources.Cancelar
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton4.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton5.Image = Global.SOLMIN_SA.My.Resources.Resources.Agregar
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripButton5.Text = "Aceptar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.BackgroundImage = CType(resources.GetObject("ToolStripButton6.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripButton6.CheckOnClick = True
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripButton6.Text = "Marcar Todos"
        '
        'frmSolicInforRecTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 602)
        Me.Controls.Add(Me.Container1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSolicInforRecTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información"
        Me.gbEmbalaje.ResumeLayout(False)
        Me.gbEmbalaje.PerformLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.Container1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Container1.Panel1.ResumeLayout(False)
        Me.Container1.Panel1.PerformLayout()
        CType(Me.Container1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Container1.Panel2.ResumeLayout(False)
        Me.Container1.Panel2.PerformLayout()
        CType(Me.Container1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Container1.ResumeLayout(False)
        CType(Me.dtgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspListadoMercaderia.ResumeLayout(False)
        Me.tspListadoMercaderia.PerformLayout()
        Me.tbAsignaSerieUbicacion.ResumeLayout(False)
        Me.TabPageUbicacion.ResumeLayout(False)
        Me.TabPageSerie.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroGuiaCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNroRUCCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkDesglose As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblContenedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblBrevete As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblEmpresaTransporte As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblUnidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnAdjuntarEmbarque As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtTipoMovimientoIng As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtTipoDoc As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblTipoDoc As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOrigen As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcClienteTerceroOrigen As Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
    Friend WithEvents gbEmbalaje As System.Windows.Forms.GroupBox
    Friend WithEvents chkSi As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents chkNo As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtEmpresaTransporte As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtUnidad As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtBrevete As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtZonaAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroGuiaCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtEmbarque As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtContenedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Container1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dtgMovimientos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PNNORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNSLCSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESMER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQTRMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCUNCN6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQTRMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCUNPS6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNORCCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbAsignaSerieUbicacion As System.Windows.Forms.TabControl
    Friend WithEvents TabPageUbicacion As System.Windows.Forms.TabPage
    Friend WithEvents UcUbicaciones_Lista As Ransa.Controls.ucUbicaciones_Dg
    Friend WithEvents TabPageSerie As System.Windows.Forms.TabPage
    Friend WithEvents UcSerie_Lista As RANSA.Controls.Serie.ucSerie_Dg
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCancelarProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
End Class
