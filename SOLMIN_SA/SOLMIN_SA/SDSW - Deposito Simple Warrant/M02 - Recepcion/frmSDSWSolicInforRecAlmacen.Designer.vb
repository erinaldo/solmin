<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWSolicInforRecAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWSolicInforRecAlmacen))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtserie = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.lblFechaIngresoItem = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCaracteristicas = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.chkCaracteristicas = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtContenedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblContenedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkDesglose = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtTipoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoRecepcionListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblTipoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRecObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtRecPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRecCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAgregarRecepcionItem = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaZonaAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblNroRUCCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroRUCCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtpfechafinal)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.txtserie)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.dtpfecha)
        Me.KryptonPanel.Controls.Add(Me.lblFechaIngresoItem)
        Me.KryptonPanel.Controls.Add(Me.txtCaracteristicas)
        Me.KryptonPanel.Controls.Add(Me.chkCaracteristicas)
        Me.KryptonPanel.Controls.Add(Me.txtContenedor)
        Me.KryptonPanel.Controls.Add(Me.lblContenedor)
        Me.KryptonPanel.Controls.Add(Me.chkDesglose)
        Me.KryptonPanel.Controls.Add(Me.txtTipoRecepcion)
        Me.KryptonPanel.Controls.Add(Me.lblTipoRecepcion)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.txtRecObservacion)
        Me.KryptonPanel.Controls.Add(Me.txtRecPeso)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.txtRecCantidad)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.txtNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAgregarRecepcionItem)
        Me.KryptonPanel.Controls.Add(Me.txtZonaAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblNroRUCCliente)
        Me.KryptonPanel.Controls.Add(Me.lblNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.txtAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtTipoAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtNroRUCCliente)
        Me.KryptonPanel.Controls.Add(Me.lblNroGuiaCliente)
        Me.KryptonPanel.Controls.Add(Me.lblZonaAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblTipoAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtNroGuiaCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(337, 310)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafinal.Location = New System.Drawing.Point(247, 63)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(84, 20)
        Me.dtpfechafinal.TabIndex = 85
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(180, 66)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(70, 16)
        Me.KryptonLabel3.TabIndex = 84
        Me.KryptonLabel3.Text = "Fec. Salida:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Fec. Salida:"
        '
        'txtserie
        '
        Me.txtserie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtserie, True)
        Me.txtserie.Location = New System.Drawing.Point(77, 263)
        Me.txtserie.MaxLength = 6
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(70, 19)
        Me.txtserie.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtserie.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtserie.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtserie.TabIndex = 83
        Me.txtserie.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtserie, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(1, 266)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(59, 16)
        Me.KryptonLabel1.TabIndex = 82
        Me.KryptonLabel1.Text = "N° Serie : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "N° Serie : "
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(77, 62)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(84, 20)
        Me.dtpfecha.TabIndex = 81
        '
        'lblFechaIngresoItem
        '
        Me.lblFechaIngresoItem.Location = New System.Drawing.Point(3, 63)
        Me.lblFechaIngresoItem.Name = "lblFechaIngresoItem"
        Me.lblFechaIngresoItem.Size = New System.Drawing.Size(76, 16)
        Me.lblFechaIngresoItem.TabIndex = 79
        Me.lblFechaIngresoItem.Text = "Fec. Ingreso:"
        Me.lblFechaIngresoItem.Values.ExtraText = ""
        Me.lblFechaIngresoItem.Values.Image = Nothing
        Me.lblFechaIngresoItem.Values.Text = "Fec. Ingreso:"
        '
        'txtCaracteristicas
        '
        Me.txtCaracteristicas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCaracteristicas.Location = New System.Drawing.Point(5, 310)
        Me.txtCaracteristicas.MaxLength = 180
        Me.txtCaracteristicas.Multiline = True
        Me.txtCaracteristicas.Name = "txtCaracteristicas"
        Me.txtCaracteristicas.Size = New System.Drawing.Size(326, 73)
        Me.txtCaracteristicas.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCaracteristicas.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtCaracteristicas.StateNormal.Back.Color1 = System.Drawing.Color.Transparent
        Me.txtCaracteristicas.TabIndex = 25
        Me.TypeValidator.SetTypes(Me.txtCaracteristicas, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'chkCaracteristicas
        '
        Me.chkCaracteristicas.Checked = False
        Me.chkCaracteristicas.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkCaracteristicas.Location = New System.Drawing.Point(5, 288)
        Me.chkCaracteristicas.Name = "chkCaracteristicas"
        Me.chkCaracteristicas.Size = New System.Drawing.Size(98, 16)
        Me.chkCaracteristicas.TabIndex = 78
        Me.chkCaracteristicas.Text = "Caracteristicas"
        Me.chkCaracteristicas.Values.ExtraText = ""
        Me.chkCaracteristicas.Values.Image = Nothing
        Me.chkCaracteristicas.Values.Text = "Caracteristicas"
        Me.chkCaracteristicas.Visible = False
        '
        'txtContenedor
        '
        Me.txtContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtContenedor, True)
        Me.txtContenedor.Location = New System.Drawing.Point(234, 213)
        Me.txtContenedor.MaxLength = 11
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.Size = New System.Drawing.Size(97, 19)
        Me.txtContenedor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContenedor.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtContenedor.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtContenedor.TabIndex = 21
        Me.TypeValidator.SetTypes(Me.txtContenedor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblContenedor
        '
        Me.lblContenedor.Location = New System.Drawing.Point(161, 216)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(76, 16)
        Me.lblContenedor.TabIndex = 20
        Me.lblContenedor.Text = "Contenedor : "
        Me.lblContenedor.Values.ExtraText = ""
        Me.lblContenedor.Values.Image = Nothing
        Me.lblContenedor.Values.Text = "Contenedor : "
        '
        'chkDesglose
        '
        Me.chkDesglose.Checked = False
        Me.chkDesglose.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDesglose.Location = New System.Drawing.Point(77, 216)
        Me.chkDesglose.Name = "chkDesglose"
        Me.chkDesglose.Size = New System.Drawing.Size(70, 16)
        Me.chkDesglose.TabIndex = 19
        Me.chkDesglose.Text = "Desglose"
        Me.chkDesglose.Values.ExtraText = ""
        Me.chkDesglose.Values.Image = Nothing
        Me.chkDesglose.Values.Text = "Desglose"
        '
        'txtTipoRecepcion
        '
        Me.txtTipoRecepcion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoRecepcionListar})
        Me.txtTipoRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtTipoRecepcion, True)
        Me.txtTipoRecepcion.Location = New System.Drawing.Point(77, 188)
        Me.txtTipoRecepcion.MaxLength = 50
        Me.txtTipoRecepcion.Name = "txtTipoRecepcion"
        Me.txtTipoRecepcion.Size = New System.Drawing.Size(254, 19)
        Me.txtTipoRecepcion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoRecepcion.TabIndex = 18
        Me.TypeValidator.SetTypes(Me.txtTipoRecepcion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaTipoRecepcionListar
        '
        Me.bsaTipoRecepcionListar.ExtraText = ""
        Me.bsaTipoRecepcionListar.Image = Nothing
        Me.bsaTipoRecepcionListar.Text = ""
        Me.bsaTipoRecepcionListar.ToolTipImage = Nothing
        Me.bsaTipoRecepcionListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoRecepcionListar.UniqueName = "F84D5E6A34EE4F36F84D5E6A34EE4F36"
        '
        'lblTipoRecepcion
        '
        Me.lblTipoRecepcion.Location = New System.Drawing.Point(1, 191)
        Me.lblTipoRecepcion.Name = "lblTipoRecepcion"
        Me.lblTipoRecepcion.Size = New System.Drawing.Size(65, 16)
        Me.lblTipoRecepcion.TabIndex = 17
        Me.lblTipoRecepcion.Text = "Tipo Rec. : "
        Me.lblTipoRecepcion.Values.ExtraText = ""
        Me.lblTipoRecepcion.Values.Image = Nothing
        Me.lblTipoRecepcion.Values.Text = "Tipo Rec. : "
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(3, 241)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(56, 16)
        Me.KryptonLabel7.TabIndex = 22
        Me.KryptonLabel7.Text = "Observ. : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Observ. : "
        '
        'txtRecObservacion
        '
        Me.txtRecObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtRecObservacion, True)
        Me.txtRecObservacion.Location = New System.Drawing.Point(77, 238)
        Me.txtRecObservacion.MaxLength = 25
        Me.txtRecObservacion.Name = "txtRecObservacion"
        Me.txtRecObservacion.Size = New System.Drawing.Size(254, 19)
        Me.txtRecObservacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecObservacion.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtRecObservacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtRecObservacion.TabIndex = 23
        Me.TypeValidator.SetTypes(Me.txtRecObservacion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtRecPeso
        '
        Me.TypeValidator.SetDecimales(Me.txtRecPeso, 2)
        Me.txtRecPeso.Location = New System.Drawing.Point(234, 163)
        Me.txtRecPeso.Name = "txtRecPeso"
        Me.txtRecPeso.Size = New System.Drawing.Size(97, 19)
        Me.txtRecPeso.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecPeso.TabIndex = 16
        Me.txtRecPeso.Text = "0.00"
        Me.txtRecPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtRecPeso, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(186, 166)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(42, 16)
        Me.KryptonLabel2.TabIndex = 15
        Me.KryptonLabel2.Text = "Peso : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Peso : "
        '
        'txtRecCantidad
        '
        Me.TypeValidator.SetDecimales(Me.txtRecCantidad, 2)
        Me.txtRecCantidad.Location = New System.Drawing.Point(77, 163)
        Me.txtRecCantidad.Name = "txtRecCantidad"
        Me.txtRecCantidad.Size = New System.Drawing.Size(97, 19)
        Me.txtRecCantidad.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecCantidad.TabIndex = 14
        Me.txtRecCantidad.Text = "0.00"
        Me.txtRecCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtRecCantidad, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(2, 166)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(62, 16)
        Me.KryptonLabel4.TabIndex = 13
        Me.KryptonLabel4.Text = "Cantidad : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cantidad : "
        '
        'txtNroOrdenCompra
        '
        Me.txtNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroOrdenCompra, True)
        Me.txtNroOrdenCompra.Location = New System.Drawing.Point(77, 12)
        Me.txtNroOrdenCompra.MaxLength = 25
        Me.txtNroOrdenCompra.Name = "txtNroOrdenCompra"
        Me.txtNroOrdenCompra.Size = New System.Drawing.Size(97, 19)
        Me.txtNroOrdenCompra.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroOrdenCompra.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroOrdenCompra.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroOrdenCompra.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtNroOrdenCompra, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(248, 279)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 25)
        Me.btnCancelar.TabIndex = 77
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnAgregarRecepcionItem
        '
        Me.btnAgregarRecepcionItem.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAgregarRecepcionItem.Location = New System.Drawing.Point(161, 279)
        Me.btnAgregarRecepcionItem.Name = "btnAgregarRecepcionItem"
        Me.btnAgregarRecepcionItem.Size = New System.Drawing.Size(80, 25)
        Me.btnAgregarRecepcionItem.TabIndex = 76
        Me.btnAgregarRecepcionItem.Text = "Agregar"
        Me.btnAgregarRecepcionItem.Values.ExtraText = ""
        Me.btnAgregarRecepcionItem.Values.Image = CType(resources.GetObject("btnAgregarRecepcionItem.Values.Image"), System.Drawing.Image)
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregarRecepcionItem.Values.Text = "Agregar"
        '
        'txtZonaAlmacen
        '
        Me.txtZonaAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaZonaAlmacenListar})
        Me.txtZonaAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtZonaAlmacen, True)
        Me.txtZonaAlmacen.Location = New System.Drawing.Point(77, 138)
        Me.txtZonaAlmacen.MaxLength = 50
        Me.txtZonaAlmacen.Name = "txtZonaAlmacen"
        Me.txtZonaAlmacen.Size = New System.Drawing.Size(254, 19)
        Me.txtZonaAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtZonaAlmacen.TabIndex = 12
        Me.TypeValidator.SetTypes(Me.txtZonaAlmacen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
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
        Me.lblNroRUCCliente.Location = New System.Drawing.Point(3, 40)
        Me.lblNroRUCCliente.Name = "lblNroRUCCliente"
        Me.lblNroRUCCliente.Size = New System.Drawing.Size(50, 16)
        Me.lblNroRUCCliente.TabIndex = 5
        Me.lblNroRUCCliente.Text = "R.U.C. :"
        Me.lblNroRUCCliente.Values.ExtraText = ""
        Me.lblNroRUCCliente.Values.Image = Nothing
        Me.lblNroRUCCliente.Values.Text = "R.U.C. :"
        '
        'lblNroOrdenCompra
        '
        Me.lblNroOrdenCompra.Location = New System.Drawing.Point(3, 15)
        Me.lblNroOrdenCompra.Name = "lblNroOrdenCompra"
        Me.lblNroOrdenCompra.Size = New System.Drawing.Size(61, 16)
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
        Me.TypeValidator.SetEnterTAB(Me.txtAlmacen, True)
        Me.txtAlmacen.Location = New System.Drawing.Point(77, 113)
        Me.txtAlmacen.MaxLength = 50
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Size = New System.Drawing.Size(254, 19)
        Me.txtAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlmacen.TabIndex = 10
        Me.TypeValidator.SetTypes(Me.txtAlmacen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
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
        Me.TypeValidator.SetEnterTAB(Me.txtTipoAlmacen, True)
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(77, 88)
        Me.txtTipoAlmacen.MaxLength = 50
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(254, 19)
        Me.txtTipoAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoAlmacen.TabIndex = 8
        Me.TypeValidator.SetTypes(Me.txtTipoAlmacen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
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
        Me.lblAlmacen.Location = New System.Drawing.Point(3, 116)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(60, 16)
        Me.lblAlmacen.TabIndex = 9
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'txtNroRUCCliente
        '
        Me.txtNroRUCCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroRUCCliente, True)
        Me.txtNroRUCCliente.Location = New System.Drawing.Point(77, 37)
        Me.txtNroRUCCliente.MaxLength = 30
        Me.txtNroRUCCliente.Name = "txtNroRUCCliente"
        Me.txtNroRUCCliente.Size = New System.Drawing.Size(97, 19)
        Me.txtNroRUCCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroRUCCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroRUCCliente.TabIndex = 6
        Me.txtNroRUCCliente.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtNroRUCCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblNroGuiaCliente
        '
        Me.lblNroGuiaCliente.Location = New System.Drawing.Point(180, 15)
        Me.lblNroGuiaCliente.Name = "lblNroGuiaCliente"
        Me.lblNroGuiaCliente.Size = New System.Drawing.Size(61, 16)
        Me.lblNroGuiaCliente.TabIndex = 3
        Me.lblNroGuiaCliente.Text = "No. Guía : "
        Me.lblNroGuiaCliente.Values.ExtraText = ""
        Me.lblNroGuiaCliente.Values.Image = Nothing
        Me.lblNroGuiaCliente.Values.Text = "No. Guía : "
        '
        'lblZonaAlmacen
        '
        Me.lblZonaAlmacen.Location = New System.Drawing.Point(3, 141)
        Me.lblZonaAlmacen.Name = "lblZonaAlmacen"
        Me.lblZonaAlmacen.Size = New System.Drawing.Size(42, 16)
        Me.lblZonaAlmacen.TabIndex = 11
        Me.lblZonaAlmacen.Text = "Zona : "
        Me.lblZonaAlmacen.Values.ExtraText = ""
        Me.lblZonaAlmacen.Values.Image = Nothing
        Me.lblZonaAlmacen.Values.Text = "Zona : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(3, 91)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(38, 16)
        Me.lblTipoAlmacen.TabIndex = 7
        Me.lblTipoAlmacen.Text = "Tipo : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo : "
        '
        'txtNroGuiaCliente
        '
        Me.txtNroGuiaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroGuiaCliente, True)
        Me.txtNroGuiaCliente.Location = New System.Drawing.Point(248, 11)
        Me.txtNroGuiaCliente.MaxLength = 30
        Me.txtNroGuiaCliente.Name = "txtNroGuiaCliente"
        Me.txtNroGuiaCliente.Size = New System.Drawing.Size(84, 19)
        Me.txtNroGuiaCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroGuiaCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroGuiaCliente.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtNroGuiaCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'frmSolicInforRecAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAgregarRecepcionItem
        Me.ClientSize = New System.Drawing.Size(337, 310)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSolicInforRecAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtContenedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblContenedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkDesglose As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtTipoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaTipoRecepcionListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblTipoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRecObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtRecPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRecCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Friend WithEvents txtNroRUCCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuiaCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroGuiaCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkCaracteristicas As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtCaracteristicas As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblFechaIngresoItem As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtserie As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpfechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
