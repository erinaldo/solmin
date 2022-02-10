<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOrdenCompra_MOC
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
        Me.cmbMoneda = New RANSA.SolminControls.ucMoneda_CmbF01
        Me.cmbMedioEmbarque = New RANSA.SolminControls.ucTipoAyuda_CmbF01
        Me.cmbTermItern = New RANSA.SolminControls.ucTipoAyuda_CmbF01
        Me.txtFechaSolicitud = New System.Windows.Forms.DateTimePicker
        Me.txtFechaOrdenCompra = New System.Windows.Forms.DateTimePicker
        Me.txtProveedor = New RANSA.SolminControls.ucProveedor_TxtF01
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtRegionEmbarque = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblRegionEmbarque = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTotalCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCostoTotal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCostoTotal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblMedioEmbarque = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTotalImpuesto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblTotalCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTotalImpuesto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtComprador = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblComprador = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDestinoFinal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDestinoFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtEmpresaFacturar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblEmpresaFacturar = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNotaProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTerminoInternacional = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCentroCosto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCentroCosto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAreaSolicitante = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblAreaSolicitante = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cmbMoneda)
        Me.KryptonPanel.Controls.Add(Me.cmbMedioEmbarque)
        Me.KryptonPanel.Controls.Add(Me.cmbTermItern)
        Me.KryptonPanel.Controls.Add(Me.txtFechaSolicitud)
        Me.KryptonPanel.Controls.Add(Me.txtFechaOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.txtProveedor)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.txtRegionEmbarque)
        Me.KryptonPanel.Controls.Add(Me.lblRegionEmbarque)
        Me.KryptonPanel.Controls.Add(Me.txtTotalCompra)
        Me.KryptonPanel.Controls.Add(Me.lblCostoTotal)
        Me.KryptonPanel.Controls.Add(Me.txtCostoTotal)
        Me.KryptonPanel.Controls.Add(Me.lblMedioEmbarque)
        Me.KryptonPanel.Controls.Add(Me.txtTotalImpuesto)
        Me.KryptonPanel.Controls.Add(Me.lblTotalCompra)
        Me.KryptonPanel.Controls.Add(Me.lblTotalImpuesto)
        Me.KryptonPanel.Controls.Add(Me.txtComprador)
        Me.KryptonPanel.Controls.Add(Me.lblComprador)
        Me.KryptonPanel.Controls.Add(Me.txtDestinoFinal)
        Me.KryptonPanel.Controls.Add(Me.lblDestinoFinal)
        Me.KryptonPanel.Controls.Add(Me.txtEmpresaFacturar)
        Me.KryptonPanel.Controls.Add(Me.txtObservaciones)
        Me.KryptonPanel.Controls.Add(Me.lblEmpresaFacturar)
        Me.KryptonPanel.Controls.Add(Me.lblNotaProveedor)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.lblTerminoInternacional)
        Me.KryptonPanel.Controls.Add(Me.txtCentroCosto)
        Me.KryptonPanel.Controls.Add(Me.lblCentroCosto)
        Me.KryptonPanel.Controls.Add(Me.lblMoneda)
        Me.KryptonPanel.Controls.Add(Me.txtNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.lblNroOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.lblFechaOrdenCompra)
        Me.KryptonPanel.Controls.Add(Me.lblProveedor)
        Me.KryptonPanel.Controls.Add(Me.txtDescripcion)
        Me.KryptonPanel.Controls.Add(Me.lblDescripcion)
        Me.KryptonPanel.Controls.Add(Me.txtAreaSolicitante)
        Me.KryptonPanel.Controls.Add(Me.lblAreaSolicitante)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(732, 315)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'cmbMoneda
        '
        Me.cmbMoneda.Location = New System.Drawing.Point(121, 112)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.pIsRequired = True
        Me.cmbMoneda.Size = New System.Drawing.Size(225, 21)
        Me.cmbMoneda.TabIndex = 16
        '
        'cmbMedioEmbarque
        '
        Me.cmbMedioEmbarque.BackColor = System.Drawing.Color.Transparent
        Me.cmbMedioEmbarque.Location = New System.Drawing.Point(121, 162)
        Me.cmbMedioEmbarque.Name = "cmbMedioEmbarque"
        Me.cmbMedioEmbarque.pCategoria = "CMEDTR"
        Me.cmbMedioEmbarque.pIsRequired = True
        Me.cmbMedioEmbarque.Size = New System.Drawing.Size(225, 21)
        Me.cmbMedioEmbarque.TabIndex = 26
        '
        'cmbTermItern
        '
        Me.cmbTermItern.BackColor = System.Drawing.Color.Transparent
        Me.cmbTermItern.Location = New System.Drawing.Point(487, 87)
        Me.cmbTermItern.Name = "cmbTermItern"
        Me.cmbTermItern.pCategoria = "TERINT"
        Me.cmbTermItern.pIsRequired = True
        Me.cmbTermItern.Size = New System.Drawing.Size(225, 21)
        Me.cmbTermItern.TabIndex = 14
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.Checked = False
        Me.txtFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(613, 12)
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.ShowCheckBox = True
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(99, 20)
        Me.txtFechaSolicitud.TabIndex = 6
        '
        'txtFechaOrdenCompra
        '
        Me.txtFechaOrdenCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaOrdenCompra.Location = New System.Drawing.Point(446, 12)
        Me.txtFechaOrdenCompra.Name = "txtFechaOrdenCompra"
        Me.txtFechaOrdenCompra.Size = New System.Drawing.Size(86, 20)
        Me.txtFechaOrdenCompra.TabIndex = 4
        '
        'txtProveedor
        '
        Me.txtProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtProveedor.BackColor = System.Drawing.Color.Transparent
        Me.txtProveedor.Location = New System.Drawing.Point(121, 62)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.pIsRequired = True
        Me.txtProveedor.Size = New System.Drawing.Size(591, 19)
        Me.txtProveedor.TabIndex = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(622, 276)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 38
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(526, 276)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 37
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'txtRegionEmbarque
        '
        Me.txtRegionEmbarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtRegionEmbarque, True)
        Me.txtRegionEmbarque.Location = New System.Drawing.Point(674, 137)
        Me.txtRegionEmbarque.MaxLength = 2
        Me.txtRegionEmbarque.Name = "txtRegionEmbarque"
        Me.txtRegionEmbarque.Size = New System.Drawing.Size(38, 19)
        Me.txtRegionEmbarque.TabIndex = 24
        Me.TypeValidator.SetTypes(Me.txtRegionEmbarque, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblRegionEmbarque
        '
        Me.lblRegionEmbarque.Location = New System.Drawing.Point(560, 140)
        Me.lblRegionEmbarque.Name = "lblRegionEmbarque"
        Me.lblRegionEmbarque.Size = New System.Drawing.Size(108, 16)
        Me.lblRegionEmbarque.TabIndex = 23
        Me.lblRegionEmbarque.Text = "Región Embarque : "
        Me.lblRegionEmbarque.Values.ExtraText = ""
        Me.lblRegionEmbarque.Values.Image = Nothing
        Me.lblRegionEmbarque.Values.Text = "Región Embarque : "
        '
        'txtTotalCompra
        '
        Me.TypeValidator.SetDecimales(Me.txtTotalCompra, 2)
        Me.txtTotalCompra.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtTotalCompra, True)
        Me.txtTotalCompra.Location = New System.Drawing.Point(619, 237)
        Me.txtTotalCompra.MaxLength = 20
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.ReadOnly = True
        Me.txtTotalCompra.Size = New System.Drawing.Size(93, 19)
        Me.txtTotalCompra.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtTotalCompra.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalCompra.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtTotalCompra.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompra.TabIndex = 36
        Me.txtTotalCompra.Text = "0.00"
        Me.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtTotalCompra, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCostoTotal
        '
        Me.lblCostoTotal.Location = New System.Drawing.Point(13, 240)
        Me.lblCostoTotal.Name = "lblCostoTotal"
        Me.lblCostoTotal.Size = New System.Drawing.Size(74, 16)
        Me.lblCostoTotal.TabIndex = 31
        Me.lblCostoTotal.Text = "Costo Total : "
        Me.lblCostoTotal.Values.ExtraText = ""
        Me.lblCostoTotal.Values.Image = Nothing
        Me.lblCostoTotal.Values.Text = "Costo Total : "
        '
        'txtCostoTotal
        '
        Me.TypeValidator.SetDecimales(Me.txtCostoTotal, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtCostoTotal, True)
        Me.txtCostoTotal.Location = New System.Drawing.Point(121, 237)
        Me.txtCostoTotal.MaxLength = 10
        Me.txtCostoTotal.Name = "txtCostoTotal"
        Me.txtCostoTotal.Size = New System.Drawing.Size(93, 19)
        Me.txtCostoTotal.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCostoTotal.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtCostoTotal.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTotal.TabIndex = 32
        Me.txtCostoTotal.Text = "0.00"
        Me.txtCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCostoTotal, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblMedioEmbarque
        '
        Me.lblMedioEmbarque.Location = New System.Drawing.Point(11, 165)
        Me.lblMedioEmbarque.Name = "lblMedioEmbarque"
        Me.lblMedioEmbarque.Size = New System.Drawing.Size(103, 16)
        Me.lblMedioEmbarque.TabIndex = 25
        Me.lblMedioEmbarque.Text = "Medio Embarque : "
        Me.lblMedioEmbarque.Values.ExtraText = ""
        Me.lblMedioEmbarque.Values.Image = Nothing
        Me.lblMedioEmbarque.Values.Text = "Medio Embarque : "
        '
        'txtTotalImpuesto
        '
        Me.TypeValidator.SetDecimales(Me.txtTotalImpuesto, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtTotalImpuesto, True)
        Me.txtTotalImpuesto.Location = New System.Drawing.Point(365, 237)
        Me.txtTotalImpuesto.MaxLength = 10
        Me.txtTotalImpuesto.Name = "txtTotalImpuesto"
        Me.txtTotalImpuesto.Size = New System.Drawing.Size(93, 19)
        Me.txtTotalImpuesto.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalImpuesto.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtTotalImpuesto.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalImpuesto.TabIndex = 34
        Me.txtTotalImpuesto.Text = "0.00"
        Me.txtTotalImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtTotalImpuesto, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblTotalCompra
        '
        Me.lblTotalCompra.Location = New System.Drawing.Point(511, 240)
        Me.lblTotalCompra.Name = "lblTotalCompra"
        Me.lblTotalCompra.Size = New System.Drawing.Size(85, 16)
        Me.lblTotalCompra.TabIndex = 35
        Me.lblTotalCompra.Text = "Total Compra : "
        Me.lblTotalCompra.Values.ExtraText = ""
        Me.lblTotalCompra.Values.Image = Nothing
        Me.lblTotalCompra.Values.Text = "Total Compra : "
        '
        'lblTotalImpuesto
        '
        Me.lblTotalImpuesto.Location = New System.Drawing.Point(255, 240)
        Me.lblTotalImpuesto.Name = "lblTotalImpuesto"
        Me.lblTotalImpuesto.Size = New System.Drawing.Size(91, 16)
        Me.lblTotalImpuesto.TabIndex = 33
        Me.lblTotalImpuesto.Text = "Total Impuesto : "
        Me.lblTotalImpuesto.Values.ExtraText = ""
        Me.lblTotalImpuesto.Values.Image = Nothing
        Me.lblTotalImpuesto.Values.Text = "Total Impuesto : "
        '
        'txtComprador
        '
        Me.txtComprador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtComprador, True)
        Me.txtComprador.Location = New System.Drawing.Point(121, 137)
        Me.txtComprador.MaxLength = 30
        Me.txtComprador.Name = "txtComprador"
        Me.txtComprador.Size = New System.Drawing.Size(225, 19)
        Me.txtComprador.TabIndex = 20
        Me.TypeValidator.SetTypes(Me.txtComprador, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblComprador
        '
        Me.lblComprador.Location = New System.Drawing.Point(13, 140)
        Me.lblComprador.Name = "lblComprador"
        Me.lblComprador.Size = New System.Drawing.Size(73, 16)
        Me.lblComprador.TabIndex = 19
        Me.lblComprador.Text = "Comprador : "
        Me.lblComprador.Values.ExtraText = ""
        Me.lblComprador.Values.Image = Nothing
        Me.lblComprador.Values.Text = "Comprador : "
        '
        'txtDestinoFinal
        '
        Me.txtDestinoFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtDestinoFinal, True)
        Me.txtDestinoFinal.Location = New System.Drawing.Point(487, 162)
        Me.txtDestinoFinal.MaxLength = 24
        Me.txtDestinoFinal.Name = "txtDestinoFinal"
        Me.txtDestinoFinal.Size = New System.Drawing.Size(225, 19)
        Me.txtDestinoFinal.TabIndex = 28
        Me.TypeValidator.SetTypes(Me.txtDestinoFinal, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblDestinoFinal
        '
        Me.lblDestinoFinal.Location = New System.Drawing.Point(365, 165)
        Me.lblDestinoFinal.Name = "lblDestinoFinal"
        Me.lblDestinoFinal.Size = New System.Drawing.Size(82, 16)
        Me.lblDestinoFinal.TabIndex = 27
        Me.lblDestinoFinal.Text = "Destino Final : "
        Me.lblDestinoFinal.Values.ExtraText = ""
        Me.lblDestinoFinal.Values.Image = Nothing
        Me.lblDestinoFinal.Values.Text = "Destino Final : "
        '
        'txtEmpresaFacturar
        '
        Me.txtEmpresaFacturar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtEmpresaFacturar, True)
        Me.txtEmpresaFacturar.Location = New System.Drawing.Point(487, 112)
        Me.txtEmpresaFacturar.MaxLength = 50
        Me.txtEmpresaFacturar.Name = "txtEmpresaFacturar"
        Me.txtEmpresaFacturar.Size = New System.Drawing.Size(225, 19)
        Me.txtEmpresaFacturar.TabIndex = 18
        Me.TypeValidator.SetTypes(Me.txtEmpresaFacturar, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(121, 187)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(591, 44)
        Me.txtObservaciones.TabIndex = 30
        Me.TypeValidator.SetTypes(Me.txtObservaciones, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblEmpresaFacturar
        '
        Me.lblEmpresaFacturar.Location = New System.Drawing.Point(365, 115)
        Me.lblEmpresaFacturar.Name = "lblEmpresaFacturar"
        Me.lblEmpresaFacturar.Size = New System.Drawing.Size(107, 16)
        Me.lblEmpresaFacturar.TabIndex = 17
        Me.lblEmpresaFacturar.Text = "Empresa Facturar : "
        Me.lblEmpresaFacturar.Values.ExtraText = ""
        Me.lblEmpresaFacturar.Values.Image = Nothing
        Me.lblEmpresaFacturar.Values.Text = "Empresa Facturar : "
        '
        'lblNotaProveedor
        '
        Me.lblNotaProveedor.Location = New System.Drawing.Point(13, 190)
        Me.lblNotaProveedor.Name = "lblNotaProveedor"
        Me.lblNotaProveedor.Size = New System.Drawing.Size(92, 16)
        Me.lblNotaProveedor.TabIndex = 29
        Me.lblNotaProveedor.Text = "Observaciones : "
        Me.lblNotaProveedor.Values.ExtraText = ""
        Me.lblNotaProveedor.Values.Image = Nothing
        Me.lblNotaProveedor.Values.Text = "Observaciones : "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(538, 15)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(69, 16)
        Me.KryptonLabel4.TabIndex = 5
        Me.KryptonLabel4.Text = "F.Solicitud :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "F.Solicitud :"
        '
        'lblTerminoInternacional
        '
        Me.lblTerminoInternacional.Location = New System.Drawing.Point(365, 90)
        Me.lblTerminoInternacional.Name = "lblTerminoInternacional"
        Me.lblTerminoInternacional.Size = New System.Drawing.Size(114, 16)
        Me.lblTerminoInternacional.TabIndex = 13
        Me.lblTerminoInternacional.Text = "Térm. Internacional : "
        Me.lblTerminoInternacional.Values.ExtraText = ""
        Me.lblTerminoInternacional.Values.Image = Nothing
        Me.lblTerminoInternacional.Values.Text = "Térm. Internacional : "
        '
        'txtCentroCosto
        '
        Me.txtCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCentroCosto, True)
        Me.txtCentroCosto.Location = New System.Drawing.Point(487, 137)
        Me.txtCentroCosto.MaxLength = 6
        Me.txtCentroCosto.Name = "txtCentroCosto"
        Me.txtCentroCosto.Size = New System.Drawing.Size(70, 19)
        Me.txtCentroCosto.TabIndex = 22
        Me.TypeValidator.SetTypes(Me.txtCentroCosto, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblCentroCosto
        '
        Me.lblCentroCosto.Location = New System.Drawing.Point(365, 140)
        Me.lblCentroCosto.Name = "lblCentroCosto"
        Me.lblCentroCosto.Size = New System.Drawing.Size(83, 16)
        Me.lblCentroCosto.TabIndex = 21
        Me.lblCentroCosto.Text = "Centro Costo :"
        Me.lblCentroCosto.Values.ExtraText = ""
        Me.lblCentroCosto.Values.Image = Nothing
        Me.lblCentroCosto.Values.Text = "Centro Costo :"
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(13, 115)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(57, 16)
        Me.lblMoneda.TabIndex = 15
        Me.lblMoneda.Text = "Moneda : "
        Me.lblMoneda.Values.ExtraText = ""
        Me.lblMoneda.Values.Image = Nothing
        Me.lblMoneda.Values.Text = "Moneda : "
        '
        'txtNroOrdenCompra
        '
        Me.txtNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroOrdenCompra, True)
        Me.txtNroOrdenCompra.Location = New System.Drawing.Point(121, 12)
        Me.txtNroOrdenCompra.MaxLength = 35
        Me.txtNroOrdenCompra.Name = "txtNroOrdenCompra"
        Me.txtNroOrdenCompra.Size = New System.Drawing.Size(225, 19)
        Me.txtNroOrdenCompra.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtNroOrdenCompra.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroOrdenCompra.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroOrdenCompra.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrdenCompra.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtNroOrdenCompra, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblNroOrdenCompra
        '
        Me.lblNroOrdenCompra.Location = New System.Drawing.Point(13, 15)
        Me.lblNroOrdenCompra.Name = "lblNroOrdenCompra"
        Me.lblNroOrdenCompra.Size = New System.Drawing.Size(61, 16)
        Me.lblNroOrdenCompra.TabIndex = 1
        Me.lblNroOrdenCompra.Text = "Nro. O/C : "
        Me.lblNroOrdenCompra.Values.ExtraText = ""
        Me.lblNroOrdenCompra.Values.Image = Nothing
        Me.lblNroOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'lblFechaOrdenCompra
        '
        Me.lblFechaOrdenCompra.Location = New System.Drawing.Point(365, 15)
        Me.lblFechaOrdenCompra.Name = "lblFechaOrdenCompra"
        Me.lblFechaOrdenCompra.Size = New System.Drawing.Size(71, 16)
        Me.lblFechaOrdenCompra.TabIndex = 3
        Me.lblFechaOrdenCompra.Text = "Fecha O/C :"
        Me.lblFechaOrdenCompra.Values.ExtraText = ""
        Me.lblFechaOrdenCompra.Values.Image = Nothing
        Me.lblFechaOrdenCompra.Values.Text = "Fecha O/C :"
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(13, 65)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(69, 16)
        Me.lblProveedor.TabIndex = 9
        Me.lblProveedor.Text = "Proveedor : "
        Me.lblProveedor.Values.ExtraText = ""
        Me.lblProveedor.Values.Image = Nothing
        Me.lblProveedor.Values.Text = "Proveedor : "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtDescripcion, True)
        Me.txtDescripcion.Location = New System.Drawing.Point(121, 37)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(591, 19)
        Me.txtDescripcion.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtDescripcion.TabIndex = 8
        Me.TypeValidator.SetTypes(Me.txtDescripcion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(13, 40)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(76, 16)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.Text = "Descripción : "
        Me.lblDescripcion.Values.ExtraText = ""
        Me.lblDescripcion.Values.Image = Nothing
        Me.lblDescripcion.Values.Text = "Descripción : "
        '
        'txtAreaSolicitante
        '
        Me.txtAreaSolicitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtAreaSolicitante, True)
        Me.txtAreaSolicitante.Location = New System.Drawing.Point(121, 87)
        Me.txtAreaSolicitante.MaxLength = 30
        Me.txtAreaSolicitante.Name = "txtAreaSolicitante"
        Me.txtAreaSolicitante.Size = New System.Drawing.Size(225, 19)
        Me.txtAreaSolicitante.TabIndex = 12
        Me.TypeValidator.SetTypes(Me.txtAreaSolicitante, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblAreaSolicitante
        '
        Me.lblAreaSolicitante.Location = New System.Drawing.Point(13, 90)
        Me.lblAreaSolicitante.Name = "lblAreaSolicitante"
        Me.lblAreaSolicitante.Size = New System.Drawing.Size(71, 16)
        Me.lblAreaSolicitante.TabIndex = 11
        Me.lblAreaSolicitante.Text = "Área Solic. :"
        Me.lblAreaSolicitante.Values.ExtraText = ""
        Me.lblAreaSolicitante.Values.Image = Nothing
        Me.lblAreaSolicitante.Values.Text = "Área Solic. :"
        '
        'ucOrdenCompra_MOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ucOrdenCompra_MOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Compra"
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
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtRegionEmbarque As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblRegionEmbarque As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTotalCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCostoTotal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCostoTotal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblMedioEmbarque As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTotalImpuesto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTotalCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTotalImpuesto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtComprador As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblComprador As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDestinoFinal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDestinoFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmpresaFacturar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblEmpresaFacturar As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblNotaProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTerminoInternacional As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCentroCosto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCentroCosto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMoneda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAreaSolicitante As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblAreaSolicitante As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtProveedor As RANSA.SolminControls.ucProveedor_TxtF01
    Friend WithEvents txtFechaSolicitud As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaOrdenCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbMedioEmbarque As RANSA.SolminControls.ucTipoAyuda_CmbF01
    Friend WithEvents cmbTermItern As RANSA.SolminControls.ucTipoAyuda_CmbF01
    Friend WithEvents cmbMoneda As RANSA.SolminControls.ucMoneda_CmbF01
End Class
