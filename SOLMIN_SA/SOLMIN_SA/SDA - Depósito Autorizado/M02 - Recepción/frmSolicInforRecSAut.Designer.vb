<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicInforRecSAut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolicInforRecSAut))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.grpInfOS = New System.Windows.Forms.GroupBox
        Me.txtEquipoManipuleo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaEquipoManipuleo = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblEquipoManipuleo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtContenedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblContenedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkDesglose = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.lblNroGuiaCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoRecepcionListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtNroRUCCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblTipoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtRecObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtRecPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroRUCCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRecCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaZonaAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpSerie = New System.Windows.Forms.GroupBox
        Me.lblRecepcionado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblUnidadBulto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPesoBrutoRecepcionada = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPesoNetoRecepcionada = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCantidadRecepcionada = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPesoBrutoDeclarado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPesoNetoDeclarado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCantidadDeclarada = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDetalleMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCodigoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtSerie = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblPesoNeto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDeclarado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblPesoBruto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCantidadBultos = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDetalleMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblSerie = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblObservacionSerie = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtObservacionSerie = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCantidadSerie = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPesoSerie = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblPeso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAgregarRecepcionItem = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpInfOS.SuspendLayout()
        Me.grpSerie.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.grpInfOS)
        Me.KryptonPanel.Controls.Add(Me.grpSerie)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAgregarRecepcionItem)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(689, 494)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'grpInfOS
        '
        Me.grpInfOS.BackColor = System.Drawing.Color.Transparent
        Me.grpInfOS.Controls.Add(Me.txtEquipoManipuleo)
        Me.grpInfOS.Controls.Add(Me.lblEquipoManipuleo)
        Me.grpInfOS.Controls.Add(Me.txtNroOrdenCompra)
        Me.grpInfOS.Controls.Add(Me.txtNroGuiaCliente)
        Me.grpInfOS.Controls.Add(Me.txtContenedor)
        Me.grpInfOS.Controls.Add(Me.lblTipoAlmacen)
        Me.grpInfOS.Controls.Add(Me.lblContenedor)
        Me.grpInfOS.Controls.Add(Me.lblZonaAlmacen)
        Me.grpInfOS.Controls.Add(Me.chkDesglose)
        Me.grpInfOS.Controls.Add(Me.lblNroGuiaCliente)
        Me.grpInfOS.Controls.Add(Me.txtTipoRecepcion)
        Me.grpInfOS.Controls.Add(Me.txtNroRUCCliente)
        Me.grpInfOS.Controls.Add(Me.lblTipoRecepcion)
        Me.grpInfOS.Controls.Add(Me.lblAlmacen)
        Me.grpInfOS.Controls.Add(Me.KryptonLabel7)
        Me.grpInfOS.Controls.Add(Me.txtTipoAlmacen)
        Me.grpInfOS.Controls.Add(Me.txtRecObservacion)
        Me.grpInfOS.Controls.Add(Me.txtAlmacen)
        Me.grpInfOS.Controls.Add(Me.txtRecPeso)
        Me.grpInfOS.Controls.Add(Me.lblNroOrdenCompra)
        Me.grpInfOS.Controls.Add(Me.KryptonLabel2)
        Me.grpInfOS.Controls.Add(Me.lblNroRUCCliente)
        Me.grpInfOS.Controls.Add(Me.txtRecCantidad)
        Me.grpInfOS.Controls.Add(Me.txtZonaAlmacen)
        Me.grpInfOS.Controls.Add(Me.KryptonLabel4)
        Me.grpInfOS.Location = New System.Drawing.Point(10, 12)
        Me.grpInfOS.Name = "grpInfOS"
        Me.grpInfOS.Size = New System.Drawing.Size(670, 153)
        Me.grpInfOS.TabIndex = 0
        Me.grpInfOS.TabStop = False
        '
        'txtEquipoManipuleo
        '
        Me.txtEquipoManipuleo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaEquipoManipuleo})
        Me.txtEquipoManipuleo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtEquipoManipuleo, True)
        Me.txtEquipoManipuleo.Location = New System.Drawing.Point(441, 94)
        Me.txtEquipoManipuleo.MaxLength = 50
        Me.txtEquipoManipuleo.Name = "txtEquipoManipuleo"
        Me.txtEquipoManipuleo.Size = New System.Drawing.Size(220, 19)
        Me.txtEquipoManipuleo.TabIndex = 20
        Me.TypeValidator.SetTypes(Me.txtEquipoManipuleo, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaEquipoManipuleo
        '
        Me.bsaEquipoManipuleo.ExtraText = ""
        Me.bsaEquipoManipuleo.Image = Nothing
        Me.bsaEquipoManipuleo.Text = ""
        Me.bsaEquipoManipuleo.ToolTipImage = Nothing
        Me.bsaEquipoManipuleo.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaEquipoManipuleo.UniqueName = "F84D5E6A34EE4F36F84D5E6A34EE4F36"
        '
        'lblEquipoManipuleo
        '
        Me.lblEquipoManipuleo.Location = New System.Drawing.Point(340, 97)
        Me.lblEquipoManipuleo.Name = "lblEquipoManipuleo"
        Me.lblEquipoManipuleo.Size = New System.Drawing.Size(95, 16)
        Me.lblEquipoManipuleo.TabIndex = 19
        Me.lblEquipoManipuleo.Text = "Equ. Manipuleo : "
        Me.lblEquipoManipuleo.Values.ExtraText = ""
        Me.lblEquipoManipuleo.Values.Image = Nothing
        Me.lblEquipoManipuleo.Values.Text = "Equ. Manipuleo : "
        '
        'txtNroOrdenCompra
        '
        Me.txtNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroOrdenCompra, True)
        Me.txtNroOrdenCompra.Location = New System.Drawing.Point(80, 19)
        Me.txtNroOrdenCompra.MaxLength = 25
        Me.txtNroOrdenCompra.Name = "txtNroOrdenCompra"
        Me.txtNroOrdenCompra.Size = New System.Drawing.Size(97, 19)
        Me.txtNroOrdenCompra.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroOrdenCompra.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroOrdenCompra.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtNroOrdenCompra, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtNroGuiaCliente
        '
        Me.txtNroGuiaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroGuiaCliente, True)
        Me.txtNroGuiaCliente.Location = New System.Drawing.Point(250, 19)
        Me.txtNroGuiaCliente.MaxLength = 30
        Me.txtNroGuiaCliente.Name = "txtNroGuiaCliente"
        Me.txtNroGuiaCliente.Size = New System.Drawing.Size(84, 19)
        Me.txtNroGuiaCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroGuiaCliente.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtNroGuiaCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtContenedor
        '
        Me.txtContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtContenedor, True)
        Me.txtContenedor.Location = New System.Drawing.Point(265, 119)
        Me.txtContenedor.MaxLength = 6
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.Size = New System.Drawing.Size(69, 19)
        Me.txtContenedor.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtContenedor.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtContenedor.TabIndex = 23
        Me.TypeValidator.SetTypes(Me.txtContenedor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(13, 47)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(38, 16)
        Me.lblTipoAlmacen.TabIndex = 7
        Me.lblTipoAlmacen.Text = "Tipo : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo : "
        '
        'lblContenedor
        '
        Me.lblContenedor.Location = New System.Drawing.Point(183, 122)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(76, 16)
        Me.lblContenedor.TabIndex = 22
        Me.lblContenedor.Text = "Contenedor : "
        Me.lblContenedor.Values.ExtraText = ""
        Me.lblContenedor.Values.Image = Nothing
        Me.lblContenedor.Values.Text = "Contenedor : "
        '
        'lblZonaAlmacen
        '
        Me.lblZonaAlmacen.Location = New System.Drawing.Point(13, 72)
        Me.lblZonaAlmacen.Name = "lblZonaAlmacen"
        Me.lblZonaAlmacen.Size = New System.Drawing.Size(42, 16)
        Me.lblZonaAlmacen.TabIndex = 11
        Me.lblZonaAlmacen.Text = "Zona : "
        Me.lblZonaAlmacen.Values.ExtraText = ""
        Me.lblZonaAlmacen.Values.Image = Nothing
        Me.lblZonaAlmacen.Values.Text = "Zona : "
        '
        'chkDesglose
        '
        Me.chkDesglose.Checked = False
        Me.chkDesglose.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDesglose.Location = New System.Drawing.Point(80, 122)
        Me.chkDesglose.Name = "chkDesglose"
        Me.chkDesglose.Size = New System.Drawing.Size(70, 16)
        Me.chkDesglose.TabIndex = 21
        Me.chkDesglose.Text = "Desglose"
        Me.chkDesglose.Values.ExtraText = ""
        Me.chkDesglose.Values.Image = Nothing
        Me.chkDesglose.Values.Text = "Desglose"
        '
        'lblNroGuiaCliente
        '
        Me.lblNroGuiaCliente.Location = New System.Drawing.Point(183, 22)
        Me.lblNroGuiaCliente.Name = "lblNroGuiaCliente"
        Me.lblNroGuiaCliente.Size = New System.Drawing.Size(61, 16)
        Me.lblNroGuiaCliente.TabIndex = 3
        Me.lblNroGuiaCliente.Text = "No. Guía : "
        Me.lblNroGuiaCliente.Values.ExtraText = ""
        Me.lblNroGuiaCliente.Values.Image = Nothing
        Me.lblNroGuiaCliente.Values.Text = "No. Guía : "
        '
        'txtTipoRecepcion
        '
        Me.txtTipoRecepcion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoRecepcionListar})
        Me.txtTipoRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtTipoRecepcion, True)
        Me.txtTipoRecepcion.Location = New System.Drawing.Point(407, 69)
        Me.txtTipoRecepcion.MaxLength = 50
        Me.txtTipoRecepcion.Name = "txtTipoRecepcion"
        Me.txtTipoRecepcion.Size = New System.Drawing.Size(254, 19)
        Me.txtTipoRecepcion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoRecepcion.TabIndex = 14
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
        'txtNroRUCCliente
        '
        Me.txtNroRUCCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroRUCCliente, True)
        Me.txtNroRUCCliente.Location = New System.Drawing.Point(407, 19)
        Me.txtNroRUCCliente.MaxLength = 30
        Me.txtNroRUCCliente.Name = "txtNroRUCCliente"
        Me.txtNroRUCCliente.Size = New System.Drawing.Size(97, 19)
        Me.txtNroRUCCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroRUCCliente.TabIndex = 6
        Me.txtNroRUCCliente.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtNroRUCCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblTipoRecepcion
        '
        Me.lblTipoRecepcion.Location = New System.Drawing.Point(340, 72)
        Me.lblTipoRecepcion.Name = "lblTipoRecepcion"
        Me.lblTipoRecepcion.Size = New System.Drawing.Size(65, 16)
        Me.lblTipoRecepcion.TabIndex = 13
        Me.lblTipoRecepcion.Text = "Tipo Rec. : "
        Me.lblTipoRecepcion.Values.ExtraText = ""
        Me.lblTipoRecepcion.Values.Image = Nothing
        Me.lblTipoRecepcion.Values.Text = "Tipo Rec. : "
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(340, 47)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(60, 16)
        Me.lblAlmacen.TabIndex = 9
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(340, 122)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(56, 16)
        Me.KryptonLabel7.TabIndex = 24
        Me.KryptonLabel7.Text = "Observ. : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Observ. : "
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoAlmacenListar})
        Me.txtTipoAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtTipoAlmacen, True)
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(80, 44)
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
        'txtRecObservacion
        '
        Me.txtRecObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtRecObservacion, True)
        Me.txtRecObservacion.Location = New System.Drawing.Point(407, 119)
        Me.txtRecObservacion.MaxLength = 25
        Me.txtRecObservacion.Name = "txtRecObservacion"
        Me.txtRecObservacion.Size = New System.Drawing.Size(254, 19)
        Me.txtRecObservacion.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtRecObservacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtRecObservacion.TabIndex = 25
        Me.TypeValidator.SetTypes(Me.txtRecObservacion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaAlmacenListar})
        Me.txtAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtAlmacen, True)
        Me.txtAlmacen.Location = New System.Drawing.Point(407, 44)
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
        'txtRecPeso
        '
        Me.TypeValidator.SetDecimales(Me.txtRecPeso, 2)
        Me.txtRecPeso.Location = New System.Drawing.Point(237, 94)
        Me.txtRecPeso.Name = "txtRecPeso"
        Me.txtRecPeso.Size = New System.Drawing.Size(97, 19)
        Me.txtRecPeso.TabIndex = 18
        Me.txtRecPeso.Text = "0.00"
        Me.txtRecPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtRecPeso, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblNroOrdenCompra
        '
        Me.lblNroOrdenCompra.Location = New System.Drawing.Point(13, 22)
        Me.lblNroOrdenCompra.Name = "lblNroOrdenCompra"
        Me.lblNroOrdenCompra.Size = New System.Drawing.Size(61, 16)
        Me.lblNroOrdenCompra.TabIndex = 1
        Me.lblNroOrdenCompra.Text = "Nro. O/C : "
        Me.lblNroOrdenCompra.Values.ExtraText = ""
        Me.lblNroOrdenCompra.Values.Image = Nothing
        Me.lblNroOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(183, 97)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(42, 16)
        Me.KryptonLabel2.TabIndex = 17
        Me.KryptonLabel2.Text = "Peso : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Peso : "
        '
        'lblNroRUCCliente
        '
        Me.lblNroRUCCliente.Location = New System.Drawing.Point(340, 22)
        Me.lblNroRUCCliente.Name = "lblNroRUCCliente"
        Me.lblNroRUCCliente.Size = New System.Drawing.Size(50, 16)
        Me.lblNroRUCCliente.TabIndex = 5
        Me.lblNroRUCCliente.Text = "R.U.C. :"
        Me.lblNroRUCCliente.Values.ExtraText = ""
        Me.lblNroRUCCliente.Values.Image = Nothing
        Me.lblNroRUCCliente.Values.Text = "R.U.C. :"
        '
        'txtRecCantidad
        '
        Me.TypeValidator.SetDecimales(Me.txtRecCantidad, 2)
        Me.txtRecCantidad.Location = New System.Drawing.Point(80, 94)
        Me.txtRecCantidad.Name = "txtRecCantidad"
        Me.txtRecCantidad.Size = New System.Drawing.Size(97, 19)
        Me.txtRecCantidad.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecCantidad.TabIndex = 16
        Me.txtRecCantidad.Text = "0.00"
        Me.txtRecCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtRecCantidad, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtZonaAlmacen
        '
        Me.txtZonaAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaZonaAlmacenListar})
        Me.txtZonaAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtZonaAlmacen, True)
        Me.txtZonaAlmacen.Location = New System.Drawing.Point(80, 69)
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
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(13, 97)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(62, 16)
        Me.KryptonLabel4.TabIndex = 15
        Me.KryptonLabel4.Text = "Cantidad : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cantidad : "
        '
        'grpSerie
        '
        Me.grpSerie.BackColor = System.Drawing.Color.Transparent
        Me.grpSerie.Controls.Add(Me.lblRecepcionado)
        Me.grpSerie.Controls.Add(Me.lblUnidadBulto)
        Me.grpSerie.Controls.Add(Me.txtPesoBrutoRecepcionada)
        Me.grpSerie.Controls.Add(Me.txtPesoNetoRecepcionada)
        Me.grpSerie.Controls.Add(Me.txtCantidadRecepcionada)
        Me.grpSerie.Controls.Add(Me.txtPesoBrutoDeclarado)
        Me.grpSerie.Controls.Add(Me.txtPesoNetoDeclarado)
        Me.grpSerie.Controls.Add(Me.txtCantidadDeclarada)
        Me.grpSerie.Controls.Add(Me.txtDetalleMercaderia)
        Me.grpSerie.Controls.Add(Me.txtMercaderia)
        Me.grpSerie.Controls.Add(Me.txtCodigoMercaderia)
        Me.grpSerie.Controls.Add(Me.txtSerie)
        Me.grpSerie.Controls.Add(Me.lblPesoNeto)
        Me.grpSerie.Controls.Add(Me.lblDeclarado)
        Me.grpSerie.Controls.Add(Me.lblPesoBruto)
        Me.grpSerie.Controls.Add(Me.lblCantidadBultos)
        Me.grpSerie.Controls.Add(Me.lblDetalleMercaderia)
        Me.grpSerie.Controls.Add(Me.lblMercaderia)
        Me.grpSerie.Controls.Add(Me.lblSerie)
        Me.grpSerie.Controls.Add(Me.lblObservacionSerie)
        Me.grpSerie.Controls.Add(Me.lblCantidad)
        Me.grpSerie.Controls.Add(Me.txtObservacionSerie)
        Me.grpSerie.Controls.Add(Me.txtCantidadSerie)
        Me.grpSerie.Controls.Add(Me.txtPesoSerie)
        Me.grpSerie.Controls.Add(Me.lblPeso)
        Me.grpSerie.Location = New System.Drawing.Point(10, 171)
        Me.grpSerie.Name = "grpSerie"
        Me.grpSerie.Size = New System.Drawing.Size(670, 273)
        Me.grpSerie.TabIndex = 26
        Me.grpSerie.TabStop = False
        '
        'lblRecepcionado
        '
        Me.lblRecepcionado.Location = New System.Drawing.Point(420, 88)
        Me.lblRecepcionado.Name = "lblRecepcionado"
        Me.lblRecepcionado.Size = New System.Drawing.Size(83, 16)
        Me.lblRecepcionado.TabIndex = 35
        Me.lblRecepcionado.Text = "Recepcionado"
        Me.lblRecepcionado.Values.ExtraText = ""
        Me.lblRecepcionado.Values.Image = Nothing
        Me.lblRecepcionado.Values.Text = "Recepcionado"
        '
        'lblUnidadBulto
        '
        Me.lblUnidadBulto.Location = New System.Drawing.Point(360, 107)
        Me.lblUnidadBulto.Name = "lblUnidadBulto"
        Me.lblUnidadBulto.Size = New System.Drawing.Size(13, 16)
        Me.lblUnidadBulto.TabIndex = 38
        Me.lblUnidadBulto.Text = "."
        Me.lblUnidadBulto.Values.ExtraText = ""
        Me.lblUnidadBulto.Values.Image = Nothing
        Me.lblUnidadBulto.Values.Text = "."
        '
        'txtPesoBrutoRecepcionada
        '
        Me.TypeValidator.SetDecimales(Me.txtPesoBrutoRecepcionada, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtPesoBrutoRecepcionada, True)
        Me.txtPesoBrutoRecepcionada.Location = New System.Drawing.Point(410, 148)
        Me.txtPesoBrutoRecepcionada.Name = "txtPesoBrutoRecepcionada"
        Me.txtPesoBrutoRecepcionada.ReadOnly = True
        Me.txtPesoBrutoRecepcionada.Size = New System.Drawing.Size(100, 19)
        Me.txtPesoBrutoRecepcionada.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPesoBrutoRecepcionada.TabIndex = 45
        Me.txtPesoBrutoRecepcionada.TabStop = False
        Me.txtPesoBrutoRecepcionada.Text = "0.00"
        Me.txtPesoBrutoRecepcionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPesoBrutoRecepcionada, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtPesoNetoRecepcionada
        '
        Me.TypeValidator.SetDecimales(Me.txtPesoNetoRecepcionada, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtPesoNetoRecepcionada, True)
        Me.txtPesoNetoRecepcionada.Location = New System.Drawing.Point(410, 126)
        Me.txtPesoNetoRecepcionada.Name = "txtPesoNetoRecepcionada"
        Me.txtPesoNetoRecepcionada.ReadOnly = True
        Me.txtPesoNetoRecepcionada.Size = New System.Drawing.Size(100, 19)
        Me.txtPesoNetoRecepcionada.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPesoNetoRecepcionada.TabIndex = 42
        Me.txtPesoNetoRecepcionada.TabStop = False
        Me.txtPesoNetoRecepcionada.Text = "0.00"
        Me.txtPesoNetoRecepcionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPesoNetoRecepcionada, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtCantidadRecepcionada
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidadRecepcionada, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadRecepcionada, True)
        Me.txtCantidadRecepcionada.Location = New System.Drawing.Point(410, 104)
        Me.txtCantidadRecepcionada.Name = "txtCantidadRecepcionada"
        Me.txtCantidadRecepcionada.ReadOnly = True
        Me.txtCantidadRecepcionada.Size = New System.Drawing.Size(100, 19)
        Me.txtCantidadRecepcionada.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCantidadRecepcionada.TabIndex = 39
        Me.txtCantidadRecepcionada.TabStop = False
        Me.txtCantidadRecepcionada.Text = "0.00"
        Me.txtCantidadRecepcionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadRecepcionada, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtPesoBrutoDeclarado
        '
        Me.TypeValidator.SetDecimales(Me.txtPesoBrutoDeclarado, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtPesoBrutoDeclarado, True)
        Me.txtPesoBrutoDeclarado.Location = New System.Drawing.Point(254, 148)
        Me.txtPesoBrutoDeclarado.Name = "txtPesoBrutoDeclarado"
        Me.txtPesoBrutoDeclarado.ReadOnly = True
        Me.txtPesoBrutoDeclarado.Size = New System.Drawing.Size(100, 19)
        Me.txtPesoBrutoDeclarado.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPesoBrutoDeclarado.TabIndex = 44
        Me.txtPesoBrutoDeclarado.TabStop = False
        Me.txtPesoBrutoDeclarado.Text = "0.00"
        Me.txtPesoBrutoDeclarado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPesoBrutoDeclarado, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtPesoNetoDeclarado
        '
        Me.TypeValidator.SetDecimales(Me.txtPesoNetoDeclarado, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtPesoNetoDeclarado, True)
        Me.txtPesoNetoDeclarado.Location = New System.Drawing.Point(254, 126)
        Me.txtPesoNetoDeclarado.Name = "txtPesoNetoDeclarado"
        Me.txtPesoNetoDeclarado.ReadOnly = True
        Me.txtPesoNetoDeclarado.Size = New System.Drawing.Size(100, 19)
        Me.txtPesoNetoDeclarado.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPesoNetoDeclarado.TabIndex = 41
        Me.txtPesoNetoDeclarado.TabStop = False
        Me.txtPesoNetoDeclarado.Text = "0.00"
        Me.txtPesoNetoDeclarado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPesoNetoDeclarado, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtCantidadDeclarada
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidadDeclarada, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadDeclarada, True)
        Me.txtCantidadDeclarada.Location = New System.Drawing.Point(254, 104)
        Me.txtCantidadDeclarada.Name = "txtCantidadDeclarada"
        Me.txtCantidadDeclarada.ReadOnly = True
        Me.txtCantidadDeclarada.Size = New System.Drawing.Size(100, 19)
        Me.txtCantidadDeclarada.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCantidadDeclarada.TabIndex = 37
        Me.txtCantidadDeclarada.TabStop = False
        Me.txtCantidadDeclarada.Text = "0.00"
        Me.txtCantidadDeclarada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadDeclarada, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtDetalleMercaderia
        '
        Me.txtDetalleMercaderia.Location = New System.Drawing.Point(81, 66)
        Me.txtDetalleMercaderia.Name = "txtDetalleMercaderia"
        Me.txtDetalleMercaderia.ReadOnly = True
        Me.txtDetalleMercaderia.Size = New System.Drawing.Size(580, 19)
        Me.txtDetalleMercaderia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDetalleMercaderia.TabIndex = 33
        Me.txtDetalleMercaderia.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtDetalleMercaderia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtMercaderia
        '
        Me.txtMercaderia.Location = New System.Drawing.Point(180, 41)
        Me.txtMercaderia.Name = "txtMercaderia"
        Me.txtMercaderia.ReadOnly = True
        Me.txtMercaderia.Size = New System.Drawing.Size(481, 19)
        Me.txtMercaderia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMercaderia.TabIndex = 31
        Me.txtMercaderia.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtMercaderia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtCodigoMercaderia
        '
        Me.txtCodigoMercaderia.Location = New System.Drawing.Point(81, 41)
        Me.txtCodigoMercaderia.Name = "txtCodigoMercaderia"
        Me.txtCodigoMercaderia.ReadOnly = True
        Me.txtCodigoMercaderia.Size = New System.Drawing.Size(100, 19)
        Me.txtCodigoMercaderia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCodigoMercaderia.TabIndex = 30
        Me.txtCodigoMercaderia.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtCodigoMercaderia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(81, 16)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(100, 19)
        Me.txtSerie.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSerie.TabIndex = 28
        Me.txtSerie.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtSerie, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblPesoNeto
        '
        Me.lblPesoNeto.Location = New System.Drawing.Point(118, 129)
        Me.lblPesoNeto.Name = "lblPesoNeto"
        Me.lblPesoNeto.Size = New System.Drawing.Size(110, 16)
        Me.lblPesoNeto.TabIndex = 40
        Me.lblPesoNeto.Text = "Peso Neto ( Kilos ) : "
        Me.lblPesoNeto.Values.ExtraText = ""
        Me.lblPesoNeto.Values.Image = Nothing
        Me.lblPesoNeto.Values.Text = "Peso Neto ( Kilos ) : "
        '
        'lblDeclarado
        '
        Me.lblDeclarado.Location = New System.Drawing.Point(274, 88)
        Me.lblDeclarado.Name = "lblDeclarado"
        Me.lblDeclarado.Size = New System.Drawing.Size(62, 16)
        Me.lblDeclarado.TabIndex = 34
        Me.lblDeclarado.Text = "Declarado"
        Me.lblDeclarado.Values.ExtraText = ""
        Me.lblDeclarado.Values.Image = Nothing
        Me.lblDeclarado.Values.Text = "Declarado"
        '
        'lblPesoBruto
        '
        Me.lblPesoBruto.Location = New System.Drawing.Point(118, 151)
        Me.lblPesoBruto.Name = "lblPesoBruto"
        Me.lblPesoBruto.Size = New System.Drawing.Size(113, 16)
        Me.lblPesoBruto.TabIndex = 43
        Me.lblPesoBruto.Text = "Peso Bruto ( Kilos ) : "
        Me.lblPesoBruto.Values.ExtraText = ""
        Me.lblPesoBruto.Values.Image = Nothing
        Me.lblPesoBruto.Values.Text = "Peso Bruto ( Kilos ) : "
        '
        'lblCantidadBultos
        '
        Me.lblCantidadBultos.Location = New System.Drawing.Point(118, 107)
        Me.lblCantidadBultos.Name = "lblCantidadBultos"
        Me.lblCantidadBultos.Size = New System.Drawing.Size(112, 16)
        Me.lblCantidadBultos.TabIndex = 36
        Me.lblCantidadBultos.Text = "Cantidad de Bultos : "
        Me.lblCantidadBultos.Values.ExtraText = ""
        Me.lblCantidadBultos.Values.Image = Nothing
        Me.lblCantidadBultos.Values.Text = "Cantidad de Bultos : "
        '
        'lblDetalleMercaderia
        '
        Me.lblDetalleMercaderia.Location = New System.Drawing.Point(6, 69)
        Me.lblDetalleMercaderia.Name = "lblDetalleMercaderia"
        Me.lblDetalleMercaderia.Size = New System.Drawing.Size(52, 16)
        Me.lblDetalleMercaderia.TabIndex = 32
        Me.lblDetalleMercaderia.Text = "Detalle : "
        Me.lblDetalleMercaderia.Values.ExtraText = ""
        Me.lblDetalleMercaderia.Values.Image = Nothing
        Me.lblDetalleMercaderia.Values.Text = "Detalle : "
        '
        'lblMercaderia
        '
        Me.lblMercaderia.Location = New System.Drawing.Point(6, 44)
        Me.lblMercaderia.Name = "lblMercaderia"
        Me.lblMercaderia.Size = New System.Drawing.Size(73, 16)
        Me.lblMercaderia.TabIndex = 29
        Me.lblMercaderia.Text = "Mercadería : "
        Me.lblMercaderia.Values.ExtraText = ""
        Me.lblMercaderia.Values.Image = Nothing
        Me.lblMercaderia.Values.Text = "Mercadería : "
        '
        'lblSerie
        '
        Me.lblSerie.Location = New System.Drawing.Point(6, 19)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(43, 16)
        Me.lblSerie.TabIndex = 27
        Me.lblSerie.Text = "Serie : "
        Me.lblSerie.Values.ExtraText = ""
        Me.lblSerie.Values.Image = Nothing
        Me.lblSerie.Values.Text = "Serie : "
        '
        'lblObservacionSerie
        '
        Me.lblObservacionSerie.Location = New System.Drawing.Point(13, 238)
        Me.lblObservacionSerie.Name = "lblObservacionSerie"
        Me.lblObservacionSerie.Size = New System.Drawing.Size(56, 16)
        Me.lblObservacionSerie.TabIndex = 50
        Me.lblObservacionSerie.Text = "Observ. : "
        Me.lblObservacionSerie.Values.ExtraText = ""
        Me.lblObservacionSerie.Values.Image = Nothing
        Me.lblObservacionSerie.Values.Text = "Observ. : "
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(14, 188)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(62, 16)
        Me.lblCantidad.TabIndex = 46
        Me.lblCantidad.Text = "Cantidad : "
        Me.lblCantidad.Values.ExtraText = ""
        Me.lblCantidad.Values.Image = Nothing
        Me.lblCantidad.Values.Text = "Cantidad : "
        '
        'txtObservacionSerie
        '
        Me.txtObservacionSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtObservacionSerie, True)
        Me.txtObservacionSerie.Location = New System.Drawing.Point(81, 235)
        Me.txtObservacionSerie.MaxLength = 180
        Me.txtObservacionSerie.Name = "txtObservacionSerie"
        Me.txtObservacionSerie.Size = New System.Drawing.Size(580, 19)
        Me.txtObservacionSerie.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtObservacionSerie.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtObservacionSerie.TabIndex = 51
        Me.TypeValidator.SetTypes(Me.txtObservacionSerie, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtCantidadSerie
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidadSerie, 2)
        Me.txtCantidadSerie.Location = New System.Drawing.Point(81, 185)
        Me.txtCantidadSerie.Name = "txtCantidadSerie"
        Me.txtCantidadSerie.Size = New System.Drawing.Size(97, 19)
        Me.txtCantidadSerie.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadSerie.TabIndex = 47
        Me.txtCantidadSerie.Text = "0.00"
        Me.txtCantidadSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadSerie, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtPesoSerie
        '
        Me.TypeValidator.SetDecimales(Me.txtPesoSerie, 2)
        Me.txtPesoSerie.Location = New System.Drawing.Point(81, 210)
        Me.txtPesoSerie.Name = "txtPesoSerie"
        Me.txtPesoSerie.Size = New System.Drawing.Size(97, 19)
        Me.txtPesoSerie.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPesoSerie.TabIndex = 49
        Me.txtPesoSerie.Text = "0.00"
        Me.txtPesoSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPesoSerie, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblPeso
        '
        Me.lblPeso.Location = New System.Drawing.Point(14, 213)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(42, 16)
        Me.lblPeso.TabIndex = 48
        Me.lblPeso.Text = "Peso : "
        Me.lblPeso.Values.ExtraText = ""
        Me.lblPeso.Values.Image = Nothing
        Me.lblPeso.Values.Text = "Peso : "
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(600, 457)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 25)
        Me.btnCancelar.TabIndex = 53
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
        Me.btnAgregarRecepcionItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarRecepcionItem.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAgregarRecepcionItem.Location = New System.Drawing.Point(514, 457)
        Me.btnAgregarRecepcionItem.Name = "btnAgregarRecepcionItem"
        Me.btnAgregarRecepcionItem.Size = New System.Drawing.Size(80, 25)
        Me.btnAgregarRecepcionItem.TabIndex = 52
        Me.btnAgregarRecepcionItem.Text = "Agregar"
        Me.btnAgregarRecepcionItem.Values.ExtraText = ""
        Me.btnAgregarRecepcionItem.Values.Image = CType(resources.GetObject("btnAgregarRecepcionItem.Values.Image"), System.Drawing.Image)
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregarRecepcionItem.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregarRecepcionItem.Values.Text = "Agregar"
        '
        'frmSolicInforRecSAut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAgregarRecepcionItem
        Me.ClientSize = New System.Drawing.Size(689, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSolicInforRecSAut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.grpInfOS.ResumeLayout(False)
        Me.grpInfOS.PerformLayout()
        Me.grpSerie.ResumeLayout(False)
        Me.grpSerie.PerformLayout()
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
    Friend WithEvents txtPesoSerie As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPeso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCantidadSerie As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblObservacionSerie As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObservacionSerie As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents grpSerie As System.Windows.Forms.GroupBox
    Friend WithEvents txtDetalleMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtSerie As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPesoNeto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDeclarado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPesoBruto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCantidadBultos As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDetalleMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSerie As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoBrutoDeclarado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPesoNetoDeclarado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadDeclarada As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblRecepcionado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUnidadBulto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoBrutoRecepcionada As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPesoNetoRecepcionada As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadRecepcionada As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents grpInfOS As System.Windows.Forms.GroupBox
    Friend WithEvents txtEquipoManipuleo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaEquipoManipuleo As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblEquipoManipuleo As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
