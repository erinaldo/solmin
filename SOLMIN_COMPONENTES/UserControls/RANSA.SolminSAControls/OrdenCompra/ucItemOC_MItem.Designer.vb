<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucItemOC_MItem
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
        Me.cbxUnidadMedida = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.txtFechaReqPlanta = New System.Windows.Forms.DateTimePicker
        Me.txtFechaEstEntrega = New System.Windows.Forms.DateTimePicker
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblFechaReqPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaEstEntrega = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroItemOCProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroItemOCProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtToleranciaMin = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblToleranciaMin = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtToleranciaMax = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblToleranciaMax = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroItemOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroItemOC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtLugarEntrega = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblLugarEntrega = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtLugarOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblLugarOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtImporteTotal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblImporteTotal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtImporteUnitario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblImporteUnitario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblUnidadMedida = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCantidadItem = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCantidadItem = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcionItemIN = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDescripcionItemIN = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcionItemES = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblDescripcionItemES = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroItemOCCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroItemOCCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cbxUnidadMedida)
        Me.KryptonPanel.Controls.Add(Me.txtFechaReqPlanta)
        Me.KryptonPanel.Controls.Add(Me.txtFechaEstEntrega)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.lblFechaReqPlanta)
        Me.KryptonPanel.Controls.Add(Me.lblFechaEstEntrega)
        Me.KryptonPanel.Controls.Add(Me.txtNroItemOCProveedor)
        Me.KryptonPanel.Controls.Add(Me.lblNroItemOCProveedor)
        Me.KryptonPanel.Controls.Add(Me.txtToleranciaMin)
        Me.KryptonPanel.Controls.Add(Me.lblToleranciaMin)
        Me.KryptonPanel.Controls.Add(Me.txtToleranciaMax)
        Me.KryptonPanel.Controls.Add(Me.lblToleranciaMax)
        Me.KryptonPanel.Controls.Add(Me.lblNroItemOC)
        Me.KryptonPanel.Controls.Add(Me.txtNroItemOC)
        Me.KryptonPanel.Controls.Add(Me.txtLugarEntrega)
        Me.KryptonPanel.Controls.Add(Me.lblLugarEntrega)
        Me.KryptonPanel.Controls.Add(Me.txtLugarOrigen)
        Me.KryptonPanel.Controls.Add(Me.lblLugarOrigen)
        Me.KryptonPanel.Controls.Add(Me.txtImporteTotal)
        Me.KryptonPanel.Controls.Add(Me.lblImporteTotal)
        Me.KryptonPanel.Controls.Add(Me.txtImporteUnitario)
        Me.KryptonPanel.Controls.Add(Me.lblImporteUnitario)
        Me.KryptonPanel.Controls.Add(Me.lblUnidadMedida)
        Me.KryptonPanel.Controls.Add(Me.txtCantidadItem)
        Me.KryptonPanel.Controls.Add(Me.lblCantidadItem)
        Me.KryptonPanel.Controls.Add(Me.txtDescripcionItemIN)
        Me.KryptonPanel.Controls.Add(Me.lblDescripcionItemIN)
        Me.KryptonPanel.Controls.Add(Me.txtDescripcionItemES)
        Me.KryptonPanel.Controls.Add(Me.lblDescripcionItemES)
        Me.KryptonPanel.Controls.Add(Me.txtNroItemOCCliente)
        Me.KryptonPanel.Controls.Add(Me.lblNroItemOCCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(681, 306)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'cbxUnidadMedida
        '
        Me.cbxUnidadMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxUnidadMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxUnidadMedida.DropDownWidth = 173
        Me.cbxUnidadMedida.FormattingEnabled = False
        Me.cbxUnidadMedida.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.cbxUnidadMedida.ItemHeight = 13
        Me.cbxUnidadMedida.Location = New System.Drawing.Point(356, 84)
        Me.cbxUnidadMedida.MaxLength = 10
        Me.cbxUnidadMedida.Name = "cbxUnidadMedida"
        Me.cbxUnidadMedida.Size = New System.Drawing.Size(173, 21)
        Me.cbxUnidadMedida.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbxUnidadMedida.TabIndex = 14
        '
        'txtFechaReqPlanta
        '
        Me.txtFechaReqPlanta.Checked = False
        Me.txtFechaReqPlanta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaReqPlanta.Location = New System.Drawing.Point(135, 179)
        Me.txtFechaReqPlanta.Name = "txtFechaReqPlanta"
        Me.txtFechaReqPlanta.ShowCheckBox = True
        Me.txtFechaReqPlanta.Size = New System.Drawing.Size(103, 20)
        Me.txtFechaReqPlanta.TabIndex = 26
        '
        'txtFechaEstEntrega
        '
        Me.txtFechaEstEntrega.Checked = False
        Me.txtFechaEstEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaEstEntrega.Location = New System.Drawing.Point(135, 157)
        Me.txtFechaEstEntrega.Name = "txtFechaEstEntrega"
        Me.txtFechaEstEntrega.ShowCheckBox = True
        Me.txtFechaEstEntrega.Size = New System.Drawing.Size(103, 20)
        Me.txtFechaEstEntrega.TabIndex = 24
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(582, 261)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 32
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
        Me.btnAceptar.Location = New System.Drawing.Point(486, 261)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 31
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'lblFechaReqPlanta
        '
        Me.lblFechaReqPlanta.Location = New System.Drawing.Point(12, 183)
        Me.lblFechaReqPlanta.Name = "lblFechaReqPlanta"
        Me.lblFechaReqPlanta.Size = New System.Drawing.Size(110, 16)
        Me.lblFechaReqPlanta.TabIndex = 25
        Me.lblFechaReqPlanta.Text = "Fecha Req. Planta : "
        Me.lblFechaReqPlanta.Values.ExtraText = ""
        Me.lblFechaReqPlanta.Values.Image = Nothing
        Me.lblFechaReqPlanta.Values.Text = "Fecha Req. Planta : "
        '
        'lblFechaEstEntrega
        '
        Me.lblFechaEstEntrega.Location = New System.Drawing.Point(12, 161)
        Me.lblFechaEstEntrega.Name = "lblFechaEstEntrega"
        Me.lblFechaEstEntrega.Size = New System.Drawing.Size(113, 16)
        Me.lblFechaEstEntrega.TabIndex = 23
        Me.lblFechaEstEntrega.Text = "Fecha Est. Entrega : "
        Me.lblFechaEstEntrega.Values.ExtraText = ""
        Me.lblFechaEstEntrega.Values.Image = Nothing
        Me.lblFechaEstEntrega.Values.Text = "Fecha Est. Entrega : "
        '
        'txtNroItemOCProveedor
        '
        Me.txtNroItemOCProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroItemOCProveedor, True)
        Me.txtNroItemOCProveedor.Location = New System.Drawing.Point(588, 9)
        Me.txtNroItemOCProveedor.MaxLength = 20
        Me.txtNroItemOCProveedor.Name = "txtNroItemOCProveedor"
        Me.txtNroItemOCProveedor.Size = New System.Drawing.Size(84, 19)
        Me.txtNroItemOCProveedor.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtNroItemOCProveedor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblNroItemOCProveedor
        '
        Me.lblNroItemOCProveedor.Location = New System.Drawing.Point(458, 12)
        Me.lblNroItemOCProveedor.Name = "lblNroItemOCProveedor"
        Me.lblNroItemOCProveedor.Size = New System.Drawing.Size(124, 16)
        Me.lblNroItemOCProveedor.TabIndex = 5
        Me.lblNroItemOCProveedor.Text = "Cód. Item  Proveedor : "
        Me.lblNroItemOCProveedor.Values.ExtraText = ""
        Me.lblNroItemOCProveedor.Values.Image = Nothing
        Me.lblNroItemOCProveedor.Values.Text = "Cód. Item  Proveedor : "
        '
        'txtToleranciaMin
        '
        Me.TypeValidator.SetDecimales(Me.txtToleranciaMin, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtToleranciaMin, True)
        Me.txtToleranciaMin.Location = New System.Drawing.Point(356, 134)
        Me.txtToleranciaMin.MaxLength = 4
        Me.txtToleranciaMin.Name = "txtToleranciaMin"
        Me.txtToleranciaMin.Size = New System.Drawing.Size(84, 19)
        Me.txtToleranciaMin.TabIndex = 22
        Me.txtToleranciaMin.Text = "0.00"
        Me.txtToleranciaMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtToleranciaMin, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblToleranciaMin
        '
        Me.lblToleranciaMin.Location = New System.Drawing.Point(233, 137)
        Me.lblToleranciaMin.Name = "lblToleranciaMin"
        Me.lblToleranciaMin.Size = New System.Drawing.Size(109, 16)
        Me.lblToleranciaMin.TabIndex = 21
        Me.lblToleranciaMin.Text = "Tolerancia Mínima : "
        Me.lblToleranciaMin.Values.ExtraText = ""
        Me.lblToleranciaMin.Values.Image = Nothing
        Me.lblToleranciaMin.Values.Text = "Tolerancia Mínima : "
        '
        'txtToleranciaMax
        '
        Me.TypeValidator.SetDecimales(Me.txtToleranciaMax, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtToleranciaMax, True)
        Me.txtToleranciaMax.Location = New System.Drawing.Point(135, 134)
        Me.txtToleranciaMax.MaxLength = 4
        Me.txtToleranciaMax.Name = "txtToleranciaMax"
        Me.txtToleranciaMax.Size = New System.Drawing.Size(84, 19)
        Me.txtToleranciaMax.TabIndex = 20
        Me.txtToleranciaMax.Text = "0.00"
        Me.txtToleranciaMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtToleranciaMax, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblToleranciaMax
        '
        Me.lblToleranciaMax.Location = New System.Drawing.Point(12, 137)
        Me.lblToleranciaMax.Name = "lblToleranciaMax"
        Me.lblToleranciaMax.Size = New System.Drawing.Size(112, 16)
        Me.lblToleranciaMax.TabIndex = 19
        Me.lblToleranciaMax.Text = "Tolerancia Máxima : "
        Me.lblToleranciaMax.Values.ExtraText = ""
        Me.lblToleranciaMax.Values.Image = Nothing
        Me.lblToleranciaMax.Values.Text = "Tolerancia Máxima : "
        '
        'lblNroItemOC
        '
        Me.lblNroItemOC.Location = New System.Drawing.Point(12, 12)
        Me.lblNroItemOC.Name = "lblNroItemOC"
        Me.lblNroItemOC.Size = New System.Drawing.Size(86, 16)
        Me.lblNroItemOC.TabIndex = 1
        Me.lblNroItemOC.Text = "Nro. Item O/C : "
        Me.lblNroItemOC.Values.ExtraText = ""
        Me.lblNroItemOC.Values.Image = Nothing
        Me.lblNroItemOC.Values.Text = "Nro. Item O/C : "
        '
        'txtNroItemOC
        '
        Me.txtNroItemOC.CausesValidation = False
        Me.txtNroItemOC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroItemOC.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtNroItemOC, True)
        Me.txtNroItemOC.Location = New System.Drawing.Point(135, 9)
        Me.txtNroItemOC.MaxLength = 3
        Me.txtNroItemOC.Name = "txtNroItemOC"
        Me.txtNroItemOC.Size = New System.Drawing.Size(84, 19)
        Me.txtNroItemOC.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroItemOC.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroItemOC.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroItemOC.TabIndex = 2
        Me.txtNroItemOC.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtNroItemOC, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtLugarEntrega
        '
        Me.txtLugarEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtLugarEntrega, True)
        Me.txtLugarEntrega.Location = New System.Drawing.Point(135, 225)
        Me.txtLugarEntrega.MaxLength = 50
        Me.txtLugarEntrega.Name = "txtLugarEntrega"
        Me.txtLugarEntrega.Size = New System.Drawing.Size(537, 19)
        Me.txtLugarEntrega.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLugarEntrega.TabIndex = 30
        Me.TypeValidator.SetTypes(Me.txtLugarEntrega, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblLugarEntrega
        '
        Me.lblLugarEntrega.Location = New System.Drawing.Point(12, 228)
        Me.lblLugarEntrega.Name = "lblLugarEntrega"
        Me.lblLugarEntrega.Size = New System.Drawing.Size(104, 16)
        Me.lblLugarEntrega.TabIndex = 29
        Me.lblLugarEntrega.Text = "Lugar de Entrega : "
        Me.lblLugarEntrega.Values.ExtraText = ""
        Me.lblLugarEntrega.Values.Image = Nothing
        Me.lblLugarEntrega.Values.Text = "Lugar de Entrega : "
        '
        'txtLugarOrigen
        '
        Me.txtLugarOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtLugarOrigen, True)
        Me.txtLugarOrigen.Location = New System.Drawing.Point(135, 202)
        Me.txtLugarOrigen.MaxLength = 50
        Me.txtLugarOrigen.Name = "txtLugarOrigen"
        Me.txtLugarOrigen.Size = New System.Drawing.Size(537, 19)
        Me.txtLugarOrigen.TabIndex = 28
        Me.TypeValidator.SetTypes(Me.txtLugarOrigen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblLugarOrigen
        '
        Me.lblLugarOrigen.Location = New System.Drawing.Point(12, 205)
        Me.lblLugarOrigen.Name = "lblLugarOrigen"
        Me.lblLugarOrigen.Size = New System.Drawing.Size(98, 16)
        Me.lblLugarOrigen.TabIndex = 27
        Me.lblLugarOrigen.Text = "Lugar de Origen : "
        Me.lblLugarOrigen.Values.ExtraText = ""
        Me.lblLugarOrigen.Values.Image = Nothing
        Me.lblLugarOrigen.Values.Text = "Lugar de Origen : "
        '
        'txtImporteTotal
        '
        Me.TypeValidator.SetDecimales(Me.txtImporteTotal, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtImporteTotal, True)
        Me.txtImporteTotal.Location = New System.Drawing.Point(356, 109)
        Me.txtImporteTotal.MaxLength = 10
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.Size = New System.Drawing.Size(84, 19)
        Me.txtImporteTotal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtImporteTotal.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtImporteTotal.TabIndex = 18
        Me.txtImporteTotal.Text = "0.00"
        Me.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtImporteTotal, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.Location = New System.Drawing.Point(233, 112)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(83, 16)
        Me.lblImporteTotal.TabIndex = 17
        Me.lblImporteTotal.Text = "Importe Total : "
        Me.lblImporteTotal.Values.ExtraText = ""
        Me.lblImporteTotal.Values.Image = Nothing
        Me.lblImporteTotal.Values.Text = "Importe Total : "
        '
        'txtImporteUnitario
        '
        Me.TypeValidator.SetDecimales(Me.txtImporteUnitario, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtImporteUnitario, True)
        Me.txtImporteUnitario.Location = New System.Drawing.Point(135, 109)
        Me.txtImporteUnitario.MaxLength = 7
        Me.txtImporteUnitario.Name = "txtImporteUnitario"
        Me.txtImporteUnitario.Size = New System.Drawing.Size(84, 19)
        Me.txtImporteUnitario.TabIndex = 16
        Me.txtImporteUnitario.Text = "0.00"
        Me.txtImporteUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtImporteUnitario, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblImporteUnitario
        '
        Me.lblImporteUnitario.Location = New System.Drawing.Point(12, 112)
        Me.lblImporteUnitario.Name = "lblImporteUnitario"
        Me.lblImporteUnitario.Size = New System.Drawing.Size(97, 16)
        Me.lblImporteUnitario.TabIndex = 15
        Me.lblImporteUnitario.Text = "Importe Unitario : "
        Me.lblImporteUnitario.Values.ExtraText = ""
        Me.lblImporteUnitario.Values.Image = Nothing
        Me.lblImporteUnitario.Values.Text = "Importe Unitario : "
        '
        'lblUnidadMedida
        '
        Me.lblUnidadMedida.Location = New System.Drawing.Point(233, 87)
        Me.lblUnidadMedida.Name = "lblUnidadMedida"
        Me.lblUnidadMedida.Size = New System.Drawing.Size(108, 16)
        Me.lblUnidadMedida.TabIndex = 13
        Me.lblUnidadMedida.Text = "Unidad de Medida : "
        Me.lblUnidadMedida.Values.ExtraText = ""
        Me.lblUnidadMedida.Values.Image = Nothing
        Me.lblUnidadMedida.Values.Text = "Unidad de Medida : "
        '
        'txtCantidadItem
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidadItem, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadItem, True)
        Me.txtCantidadItem.Location = New System.Drawing.Point(135, 84)
        Me.txtCantidadItem.MaxLength = 9
        Me.txtCantidadItem.Name = "txtCantidadItem"
        Me.txtCantidadItem.Size = New System.Drawing.Size(84, 19)
        Me.txtCantidadItem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadItem.TabIndex = 12
        Me.txtCantidadItem.Text = "0.00"
        Me.txtCantidadItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadItem, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCantidadItem
        '
        Me.lblCantidadItem.Location = New System.Drawing.Point(12, 87)
        Me.lblCantidadItem.Name = "lblCantidadItem"
        Me.lblCantidadItem.Size = New System.Drawing.Size(62, 16)
        Me.lblCantidadItem.TabIndex = 11
        Me.lblCantidadItem.Text = "Cantidad : "
        Me.lblCantidadItem.Values.ExtraText = ""
        Me.lblCantidadItem.Values.Image = Nothing
        Me.lblCantidadItem.Values.Text = "Cantidad : "
        '
        'txtDescripcionItemIN
        '
        Me.txtDescripcionItemIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtDescripcionItemIN, True)
        Me.txtDescripcionItemIN.Location = New System.Drawing.Point(135, 59)
        Me.txtDescripcionItemIN.MaxLength = 100
        Me.txtDescripcionItemIN.Name = "txtDescripcionItemIN"
        Me.txtDescripcionItemIN.Size = New System.Drawing.Size(537, 19)
        Me.txtDescripcionItemIN.TabIndex = 10
        Me.TypeValidator.SetTypes(Me.txtDescripcionItemIN, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblDescripcionItemIN
        '
        Me.lblDescripcionItemIN.Location = New System.Drawing.Point(12, 62)
        Me.lblDescripcionItemIN.Name = "lblDescripcionItemIN"
        Me.lblDescripcionItemIN.Size = New System.Drawing.Size(109, 16)
        Me.lblDescripcionItemIN.TabIndex = 9
        Me.lblDescripcionItemIN.Text = "Descripción Inglés : "
        Me.lblDescripcionItemIN.Values.ExtraText = ""
        Me.lblDescripcionItemIN.Values.Image = Nothing
        Me.lblDescripcionItemIN.Values.Text = "Descripción Inglés : "
        '
        'txtDescripcionItemES
        '
        Me.txtDescripcionItemES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtDescripcionItemES, True)
        Me.txtDescripcionItemES.Location = New System.Drawing.Point(135, 34)
        Me.txtDescripcionItemES.MaxLength = 100
        Me.txtDescripcionItemES.Name = "txtDescripcionItemES"
        Me.txtDescripcionItemES.Size = New System.Drawing.Size(537, 19)
        Me.txtDescripcionItemES.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescripcionItemES.TabIndex = 8
        Me.TypeValidator.SetTypes(Me.txtDescripcionItemES, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblDescripcionItemES
        '
        Me.lblDescripcionItemES.Location = New System.Drawing.Point(12, 37)
        Me.lblDescripcionItemES.Name = "lblDescripcionItemES"
        Me.lblDescripcionItemES.Size = New System.Drawing.Size(120, 16)
        Me.lblDescripcionItemES.TabIndex = 7
        Me.lblDescripcionItemES.Text = "Descripción Español : "
        Me.lblDescripcionItemES.Values.ExtraText = ""
        Me.lblDescripcionItemES.Values.Image = Nothing
        Me.lblDescripcionItemES.Values.Text = "Descripción Español : "
        '
        'txtNroItemOCCliente
        '
        Me.txtNroItemOCCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroItemOCCliente, True)
        Me.txtNroItemOCCliente.Location = New System.Drawing.Point(356, 9)
        Me.txtNroItemOCCliente.MaxLength = 20
        Me.txtNroItemOCCliente.Name = "txtNroItemOCCliente"
        Me.txtNroItemOCCliente.Size = New System.Drawing.Size(84, 19)
        Me.txtNroItemOCCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroItemOCCliente.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtNroItemOCCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblNroItemOCCliente
        '
        Me.lblNroItemOCCliente.Location = New System.Drawing.Point(233, 12)
        Me.lblNroItemOCCliente.Name = "lblNroItemOCCliente"
        Me.lblNroItemOCCliente.Size = New System.Drawing.Size(104, 16)
        Me.lblNroItemOCCliente.TabIndex = 3
        Me.lblNroItemOCCliente.Text = "Cód. Item Cliente : "
        Me.lblNroItemOCCliente.Values.ExtraText = ""
        Me.lblNroItemOCCliente.Values.Image = Nothing
        Me.lblNroItemOCCliente.Values.Text = "Cód. Item Cliente : "
        '
        'ucItemOC_MItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(681, 306)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ucItemOC_MItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item"
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
    Private WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents txtFechaReqPlanta As System.Windows.Forms.DateTimePicker
    Private WithEvents txtFechaEstEntrega As System.Windows.Forms.DateTimePicker
    Private WithEvents lblFechaReqPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblFechaEstEntrega As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNroItemOCProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblNroItemOCProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtToleranciaMin As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblToleranciaMin As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtToleranciaMax As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblToleranciaMax As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblNroItemOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNroItemOC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtLugarEntrega As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblLugarEntrega As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtLugarOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblLugarOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtImporteTotal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblImporteTotal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtImporteUnitario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblImporteUnitario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblUnidadMedida As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtCantidadItem As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblCantidadItem As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDescripcionItemIN As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblDescripcionItemIN As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDescripcionItemES As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblDescripcionItemES As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNroItemOCCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblNroItemOCCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents cbxUnidadMedida As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
