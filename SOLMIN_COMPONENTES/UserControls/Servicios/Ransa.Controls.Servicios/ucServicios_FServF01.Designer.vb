<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucServicios_FServF01
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
        Me.grpCabOperacion = New System.Windows.Forms.GroupBox
        Me.txtSerieContenedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCodigoContenedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblFechaServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.lblfechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblContenedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnGrabar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.cbxPlanta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaOperacion = New System.Windows.Forms.DateTimePicker
        Me.lblProceso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblClienteFact = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblSerieContenedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCantidadAtendida = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaServicioListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonTextBox4 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dgMercaderias = New Ransa.Controls.Servicios.ucServicios_Mercaderia_DgF01
        Me.dgBultos = New Ransa.Controls.Servicios.ucServicios_Waybill_DgF01
        Me.dgServicios = New Ransa.Controls.Servicios.ucServicios_DgF02
        Me.txtTipoProceso = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
        Me.txtClienteFacturar = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.UcServicios_DgF021 = New Ransa.Controls.Servicios.ucServicios_DgF02
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpCabOperacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgMercaderias)
        Me.KryptonPanel.Controls.Add(Me.dgBultos)
        Me.KryptonPanel.Controls.Add(Me.dgServicios)
        Me.KryptonPanel.Controls.Add(Me.grpCabOperacion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(834, 541)
        Me.KryptonPanel.TabIndex = 0
        '
        'grpCabOperacion
        '
        Me.grpCabOperacion.BackColor = System.Drawing.Color.Transparent
        Me.grpCabOperacion.Controls.Add(Me.txtSerieContenedor)
        Me.grpCabOperacion.Controls.Add(Me.txtCodigoContenedor)
        Me.grpCabOperacion.Controls.Add(Me.lblFechaServicio)
        Me.grpCabOperacion.Controls.Add(Me.dtpFechaFinal)
        Me.grpCabOperacion.Controls.Add(Me.lblFechaFinal)
        Me.grpCabOperacion.Controls.Add(Me.dtpFechaInicial)
        Me.grpCabOperacion.Controls.Add(Me.lblfechaInicial)
        Me.grpCabOperacion.Controls.Add(Me.lblContenedor)
        Me.grpCabOperacion.Controls.Add(Me.btnGrabar)
        Me.grpCabOperacion.Controls.Add(Me.cbxPlanta)
        Me.grpCabOperacion.Controls.Add(Me.btnCerrar)
        Me.grpCabOperacion.Controls.Add(Me.lblPlanta)
        Me.grpCabOperacion.Controls.Add(Me.dteFechaOperacion)
        Me.grpCabOperacion.Controls.Add(Me.lblProceso)
        Me.grpCabOperacion.Controls.Add(Me.txtTipoProceso)
        Me.grpCabOperacion.Controls.Add(Me.lblClienteFact)
        Me.grpCabOperacion.Controls.Add(Me.txtClienteFacturar)
        Me.grpCabOperacion.Controls.Add(Me.lblNroOperacion)
        Me.grpCabOperacion.Controls.Add(Me.lblFechaOperacion)
        Me.grpCabOperacion.Controls.Add(Me.txtNroOperacion)
        Me.grpCabOperacion.Controls.Add(Me.lblSerieContenedor)
        Me.grpCabOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCabOperacion.Location = New System.Drawing.Point(12, 12)
        Me.grpCabOperacion.Name = "grpCabOperacion"
        Me.grpCabOperacion.Size = New System.Drawing.Size(810, 120)
        Me.grpCabOperacion.TabIndex = 1
        Me.grpCabOperacion.TabStop = False
        Me.grpCabOperacion.Text = "OPERACION"
        '
        'txtSerieContenedor
        '
        Me.txtSerieContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtSerieContenedor, True)
        Me.txtSerieContenedor.Location = New System.Drawing.Point(257, 66)
        Me.txtSerieContenedor.MaxLength = 7
        Me.txtSerieContenedor.Name = "txtSerieContenedor"
        Me.txtSerieContenedor.Size = New System.Drawing.Size(84, 21)
        Me.txtSerieContenedor.TabIndex = 23
        Me.TypeValidator.SetTypes(Me.txtSerieContenedor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtCodigoContenedor
        '
        Me.txtCodigoContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCodigoContenedor, True)
        Me.txtCodigoContenedor.Location = New System.Drawing.Point(118, 66)
        Me.txtCodigoContenedor.MaxLength = 4
        Me.txtCodigoContenedor.Name = "txtCodigoContenedor"
        Me.txtCodigoContenedor.Size = New System.Drawing.Size(84, 21)
        Me.txtCodigoContenedor.TabIndex = 13
        Me.TypeValidator.SetTypes(Me.txtCodigoContenedor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblFechaServicio
        '
        Me.lblFechaServicio.Location = New System.Drawing.Point(349, 69)
        Me.lblFechaServicio.Name = "lblFechaServicio"
        Me.lblFechaServicio.Size = New System.Drawing.Size(159, 19)
        Me.lblFechaServicio.TabIndex = 16
        Me.lblFechaServicio.Text = "Rango del Fecha del Servicio :"
        Me.lblFechaServicio.Values.ExtraText = ""
        Me.lblFechaServicio.Values.Image = Nothing
        Me.lblFechaServicio.Values.Text = "Rango del Fecha del Servicio :"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(565, 91)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaFinal.TabIndex = 20
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(513, 95)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(39, 19)
        Me.lblFechaFinal.TabIndex = 19
        Me.lblFechaFinal.Text = "Final :"
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Final :"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(565, 65)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaInicial.TabIndex = 18
        '
        'lblfechaInicial
        '
        Me.lblfechaInicial.Location = New System.Drawing.Point(513, 69)
        Me.lblfechaInicial.Name = "lblfechaInicial"
        Me.lblfechaInicial.Size = New System.Drawing.Size(43, 19)
        Me.lblfechaInicial.TabIndex = 17
        Me.lblfechaInicial.Text = "Inicio : "
        Me.lblfechaInicial.Values.ExtraText = ""
        Me.lblfechaInicial.Values.Image = Nothing
        Me.lblfechaInicial.Values.Text = "Inicio : "
        '
        'lblContenedor
        '
        Me.lblContenedor.Location = New System.Drawing.Point(6, 69)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(100, 19)
        Me.lblContenedor.TabIndex = 12
        Me.lblContenedor.Text = "Nro. Contenedor : "
        Me.lblContenedor.Values.ExtraText = ""
        Me.lblContenedor.Values.Image = Nothing
        Me.lblContenedor.Values.Text = "Nro. Contenedor : "
        '
        'btnGrabar
        '
        Me.btnGrabar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnGrabar.Location = New System.Drawing.Point(703, 16)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(90, 40)
        Me.btnGrabar.TabIndex = 21
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.Values.ExtraText = ""
        Me.btnGrabar.Values.Image = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGrabar.Values.Text = "&Grabar"
        '
        'cbxPlanta
        '
        Me.cbxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPlanta.DropDownWidth = 165
        Me.cbxPlanta.FormattingEnabled = False
        Me.cbxPlanta.ItemHeight = 13
        Me.cbxPlanta.Location = New System.Drawing.Point(499, 39)
        Me.cbxPlanta.Name = "cbxPlanta"
        Me.cbxPlanta.Size = New System.Drawing.Size(165, 21)
        Me.cbxPlanta.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.cbxPlanta.TabIndex = 11
        Me.cbxPlanta.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(703, 62)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(90, 40)
        Me.btnCerrar.TabIndex = 22
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "&Cerrar"
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(435, 42)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(47, 19)
        Me.lblPlanta.TabIndex = 10
        Me.lblPlanta.Text = "Planta : "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta : "
        Me.lblPlanta.Visible = False
        '
        'dteFechaOperacion
        '
        Me.dteFechaOperacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaOperacion.Location = New System.Drawing.Point(330, 16)
        Me.dteFechaOperacion.Name = "dteFechaOperacion"
        Me.dteFechaOperacion.Size = New System.Drawing.Size(99, 20)
        Me.dteFechaOperacion.TabIndex = 5
        '
        'lblProceso
        '
        Me.lblProceso.Location = New System.Drawing.Point(435, 19)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(55, 19)
        Me.lblProceso.TabIndex = 6
        Me.lblProceso.Text = "Proceso : "
        Me.lblProceso.Values.ExtraText = ""
        Me.lblProceso.Values.Image = Nothing
        Me.lblProceso.Values.Text = "Proceso : "
        '
        'lblClienteFact
        '
        Me.lblClienteFact.Location = New System.Drawing.Point(6, 44)
        Me.lblClienteFact.Name = "lblClienteFact"
        Me.lblClienteFact.Size = New System.Drawing.Size(103, 19)
        Me.lblClienteFact.TabIndex = 8
        Me.lblClienteFact.Text = "Cliente a Facturar :"
        Me.lblClienteFact.Values.ExtraText = ""
        Me.lblClienteFact.Values.Image = Nothing
        Me.lblClienteFact.Values.Text = "Cliente a Facturar :"
        '
        'lblNroOperacion
        '
        Me.lblNroOperacion.Location = New System.Drawing.Point(6, 19)
        Me.lblNroOperacion.Name = "lblNroOperacion"
        Me.lblNroOperacion.Size = New System.Drawing.Size(92, 19)
        Me.lblNroOperacion.TabIndex = 2
        Me.lblNroOperacion.Text = "Nro. Operación : "
        Me.lblNroOperacion.UseMnemonic = False
        Me.lblNroOperacion.Values.ExtraText = ""
        Me.lblNroOperacion.Values.Image = Nothing
        Me.lblNroOperacion.Values.Text = "Nro. Operación : "
        '
        'lblFechaOperacion
        '
        Me.lblFechaOperacion.Location = New System.Drawing.Point(276, 19)
        Me.lblFechaOperacion.Name = "lblFechaOperacion"
        Me.lblFechaOperacion.Size = New System.Drawing.Size(45, 19)
        Me.lblFechaOperacion.TabIndex = 4
        Me.lblFechaOperacion.Text = "Fecha : "
        Me.lblFechaOperacion.Values.ExtraText = ""
        Me.lblFechaOperacion.Values.Image = Nothing
        Me.lblFechaOperacion.Values.Text = "Fecha : "
        '
        'txtNroOperacion
        '
        Me.txtNroOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOperacion.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtNroOperacion, True)
        Me.txtNroOperacion.Location = New System.Drawing.Point(118, 16)
        Me.txtNroOperacion.Name = "txtNroOperacion"
        Me.txtNroOperacion.ReadOnly = True
        Me.txtNroOperacion.Size = New System.Drawing.Size(152, 21)
        Me.txtNroOperacion.StateCommon.Back.Color1 = System.Drawing.Color.PaleGoldenrod
        Me.txtNroOperacion.TabIndex = 3
        Me.TypeValidator.SetTypes(Me.txtNroOperacion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblSerieContenedor
        '
        Me.lblSerieContenedor.Location = New System.Drawing.Point(208, 69)
        Me.lblSerieContenedor.Name = "lblSerieContenedor"
        Me.lblSerieContenedor.Size = New System.Drawing.Size(40, 19)
        Me.lblSerieContenedor.TabIndex = 14
        Me.lblSerieContenedor.Text = "Serie : "
        Me.lblSerieContenedor.Values.ExtraText = ""
        Me.lblSerieContenedor.Values.Image = Nothing
        Me.lblSerieContenedor.Values.Text = "Serie : "
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.KryptonTextBox1, True)
        Me.KryptonTextBox1.Location = New System.Drawing.Point(717, 82)
        Me.KryptonTextBox1.MaxLength = 35
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(89, 21)
        Me.KryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KryptonTextBox1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KryptonTextBox1.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.KryptonTextBox1.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonTextBox1.TabIndex = 49
        Me.TypeValidator.SetTypes(Me.KryptonTextBox1, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'KryptonTextBox2
        '
        Me.KryptonTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.KryptonTextBox2, True)
        Me.KryptonTextBox2.Location = New System.Drawing.Point(514, 110)
        Me.KryptonTextBox2.MaxLength = 35
        Me.KryptonTextBox2.Name = "KryptonTextBox2"
        Me.KryptonTextBox2.Size = New System.Drawing.Size(110, 21)
        Me.KryptonTextBox2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KryptonTextBox2.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KryptonTextBox2.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.KryptonTextBox2.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonTextBox2.TabIndex = 51
        Me.TypeValidator.SetTypes(Me.KryptonTextBox2, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtCantidadAtendida
        '
        Me.txtCantidadAtendida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidadAtendida.Location = New System.Drawing.Point(495, 82)
        Me.txtCantidadAtendida.Name = "txtCantidadAtendida"
        Me.txtCantidadAtendida.Size = New System.Drawing.Size(110, 21)
        Me.txtCantidadAtendida.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadAtendida.TabIndex = 33
        Me.txtCantidadAtendida.Text = "0.00"
        Me.txtCantidadAtendida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadAtendida, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'KryptonTextBox3
        '
        Me.KryptonTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.KryptonTextBox3, True)
        Me.KryptonTextBox3.Location = New System.Drawing.Point(130, 110)
        Me.KryptonTextBox3.MaxLength = 35
        Me.KryptonTextBox3.Name = "KryptonTextBox3"
        Me.KryptonTextBox3.Size = New System.Drawing.Size(314, 21)
        Me.KryptonTextBox3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KryptonTextBox3.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KryptonTextBox3.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.KryptonTextBox3.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonTextBox3.TabIndex = 49
        Me.TypeValidator.SetTypes(Me.KryptonTextBox3, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtServicio
        '
        Me.txtServicio.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaServicioListar})
        Me.txtServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtServicio.Location = New System.Drawing.Point(93, 82)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(314, 21)
        Me.txtServicio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtServicio.TabIndex = 16
        Me.TypeValidator.SetTypes(Me.txtServicio, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaServicioListar
        '
        Me.bsaServicioListar.ExtraText = ""
        Me.bsaServicioListar.Image = Nothing
        Me.bsaServicioListar.Text = ""
        Me.bsaServicioListar.ToolTipImage = Nothing
        Me.bsaServicioListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaServicioListar.UniqueName = "0DFF9C822F2C4B430DFF9C822F2C4B43"
        '
        'KryptonTextBox4
        '
        Me.KryptonTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.KryptonTextBox4.Location = New System.Drawing.Point(717, 110)
        Me.KryptonTextBox4.Name = "KryptonTextBox4"
        Me.KryptonTextBox4.Size = New System.Drawing.Size(89, 21)
        Me.KryptonTextBox4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KryptonTextBox4.TabIndex = 53
        Me.KryptonTextBox4.Text = "0.00"
        Me.KryptonTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.KryptonTextBox4, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'dgMercaderias
        '
        Me.dgMercaderias.AskForConfirmation = True
        Me.dgMercaderias.BackColor = System.Drawing.Color.Transparent
        Me.dgMercaderias.BackGround = System.Drawing.Color.Empty
        Me.dgMercaderias.Location = New System.Drawing.Point(424, 328)
        Me.dgMercaderias.Name = "dgMercaderias"
        Me.dgMercaderias.OnlineRegistration = False
        Me.dgMercaderias.Size = New System.Drawing.Size(398, 203)
        Me.dgMercaderias.TabIndex = 25
        '
        'dgBultos
        '
        Me.dgBultos.AskForConfirmation = True
        Me.dgBultos.BackColor = System.Drawing.Color.Transparent
        Me.dgBultos.BackGround = System.Drawing.Color.White
        Me.dgBultos.Location = New System.Drawing.Point(12, 328)
        Me.dgBultos.Name = "dgBultos"
        Me.dgBultos.OnlineRegistration = False
        Me.dgBultos.Size = New System.Drawing.Size(406, 203)
        Me.dgBultos.TabIndex = 24
        '
        'dgServicios
        '
        Me.dgServicios.AskForConfirmation = True
        Me.dgServicios.BackColor = System.Drawing.Color.Transparent
        Me.dgServicios.BackGround = System.Drawing.Color.White
        Me.dgServicios.Location = New System.Drawing.Point(12, 138)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.Size = New System.Drawing.Size(810, 184)
        Me.dgServicios.TabIndex = 23
        '
        'txtTipoProceso
        '
        Me.txtTipoProceso.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoProceso.Location = New System.Drawing.Point(499, 16)
        Me.txtTipoProceso.Name = "txtTipoProceso"
        Me.txtTipoProceso.pCategoria = "TIPROC"
        Me.txtTipoProceso.pIsRequired = False
        Me.txtTipoProceso.Size = New System.Drawing.Size(165, 21)
        Me.txtTipoProceso.TabIndex = 7
        '
        'txtClienteFacturar
        '
        Me.txtClienteFacturar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteFacturar.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteFacturar.CCMPN = "EZ"
        Me.txtClienteFacturar.Location = New System.Drawing.Point(118, 41)
        Me.txtClienteFacturar.Name = "txtClienteFacturar"
        Me.txtClienteFacturar.pAccesoPorUsuario = False
        Me.txtClienteFacturar.pRequerido = False
        Me.txtClienteFacturar.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClienteFacturar.Size = New System.Drawing.Size(311, 21)
        Me.txtClienteFacturar.TabIndex = 9
        '
        'UcServicios_DgF021
        '
        Me.UcServicios_DgF021.AskForConfirmation = True
        Me.UcServicios_DgF021.BackColor = System.Drawing.Color.Transparent
        Me.UcServicios_DgF021.BackGround = System.Drawing.Color.White
        Me.UcServicios_DgF021.Location = New System.Drawing.Point(12, 113)
        Me.UcServicios_DgF021.Name = "UcServicios_DgF021"
        Me.UcServicios_DgF021.Size = New System.Drawing.Size(624, 184)
        Me.UcServicios_DgF021.TabIndex = 14
        '
        'ucServicios_FServF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(834, 541)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ucServicios_FServF01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicio"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.grpCabOperacion.ResumeLayout(False)
        Me.grpCabOperacion.PerformLayout()
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
    Friend WithEvents bsaServicioListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonTextBox2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadAtendida As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonTextBox3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonTextBox4 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents dteFechaOperacion As System.Windows.Forms.DateTimePicker
    Private WithEvents lblContenedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents grpCabOperacion As System.Windows.Forms.GroupBox
    Private WithEvents txtNroOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblNroOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblFechaOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblSerieContenedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents dgServicios As Ransa.Controls.Servicios.ucServicios_DgF02
    Private WithEvents dgBultos As Ransa.Controls.Servicios.ucServicios_Waybill_DgF01
    Private WithEvents lblClienteFact As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtClienteFacturar As RANSA.Controls.cliente.ucCliente_TxtF01
    Private WithEvents lblProceso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtTipoProceso As RANSA.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Private WithEvents UcServicios_DgF021 As Ransa.Controls.Servicios.ucServicios_DgF02
    Private WithEvents btnGrabar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dgMercaderias As Ransa.Controls.Servicios.ucServicios_Mercaderia_DgF01
    Friend WithEvents cbxPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Private WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Private WithEvents lblfechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblFechaServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoContenedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtSerieContenedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
