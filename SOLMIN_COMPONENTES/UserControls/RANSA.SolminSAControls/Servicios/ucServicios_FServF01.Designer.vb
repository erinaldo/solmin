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
        Me.dgBultos = New RANSA.SolminControls.ucServicios_Waybill_DgF01
        Me.dgServicios = New RANSA.SolminControls.ucServicios_DgF02
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.grpCabOperacion = New System.Windows.Forms.GroupBox
        Me.dteFechaOperacion = New System.Windows.Forms.DateTimePicker
        Me.lblProceso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoProceso = New RANSA.SolminControls.ucTipoAyuda_CmbF01
        Me.lblClienteFact = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtClienteFacturar = New RANSA.SolminControls.ucCliente_TxtF01
        Me.lblNroOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblContenedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblSerieContenedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigoContenedor = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtSerieContenedor = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCantidadAtendida = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaServicioListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonTextBox4 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.UcServicios_DgF021 = New RANSA.SolminControls.ucServicios_DgF02
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.grpCabOperacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgBultos)
        Me.KryptonPanel.Controls.Add(Me.dgServicios)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnGuardar)
        Me.KryptonPanel.Controls.Add(Me.grpCabOperacion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(695, 568)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgBultos
        '
        Me.dgBultos.BackColor = System.Drawing.Color.Transparent
        Me.dgBultos.BackGround = System.Drawing.Color.White
        Me.dgBultos.Location = New System.Drawing.Point(12, 303)
        Me.dgBultos.Name = "dgBultos"
        Me.dgBultos.pCCLNT_CodigoCliente = CType(0, Long)
        Me.dgBultos.Size = New System.Drawing.Size(667, 203)
        Me.dgBultos.TabIndex = 15
        '
        'dgServicios
        '
        Me.dgServicios.BackColor = System.Drawing.Color.Transparent
        Me.dgServicios.BackGround = System.Drawing.Color.White
        Me.dgServicios.Location = New System.Drawing.Point(12, 113)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.Size = New System.Drawing.Size(667, 184)
        Me.dgServicios.TabIndex = 14
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(589, 522)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnGuardar.Location = New System.Drawing.Point(482, 522)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 25)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Values.ExtraText = ""
        Me.btnGuardar.Values.Image = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuardar.Values.Text = "Guardar"
        '
        'grpCabOperacion
        '
        Me.grpCabOperacion.BackColor = System.Drawing.Color.Transparent
        Me.grpCabOperacion.Controls.Add(Me.dteFechaOperacion)
        Me.grpCabOperacion.Controls.Add(Me.lblProceso)
        Me.grpCabOperacion.Controls.Add(Me.txtTipoProceso)
        Me.grpCabOperacion.Controls.Add(Me.lblClienteFact)
        Me.grpCabOperacion.Controls.Add(Me.txtClienteFacturar)
        Me.grpCabOperacion.Controls.Add(Me.lblNroOperacion)
        Me.grpCabOperacion.Controls.Add(Me.lblFechaOperacion)
        Me.grpCabOperacion.Controls.Add(Me.lblContenedor)
        Me.grpCabOperacion.Controls.Add(Me.txtNroOperacion)
        Me.grpCabOperacion.Controls.Add(Me.lblSerieContenedor)
        Me.grpCabOperacion.Controls.Add(Me.txtCodigoContenedor)
        Me.grpCabOperacion.Controls.Add(Me.txtSerieContenedor)
        Me.grpCabOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCabOperacion.Location = New System.Drawing.Point(12, 12)
        Me.grpCabOperacion.Name = "grpCabOperacion"
        Me.grpCabOperacion.Size = New System.Drawing.Size(667, 95)
        Me.grpCabOperacion.TabIndex = 1
        Me.grpCabOperacion.TabStop = False
        Me.grpCabOperacion.Text = "OPERACION"
        '
        'dteFechaOperacion
        '
        Me.dteFechaOperacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaOperacion.Location = New System.Drawing.Point(416, 15)
        Me.dteFechaOperacion.Name = "dteFechaOperacion"
        Me.dteFechaOperacion.Size = New System.Drawing.Size(107, 20)
        Me.dteFechaOperacion.TabIndex = 5
        '
        'lblProceso
        '
        Me.lblProceso.Location = New System.Drawing.Point(6, 69)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(58, 16)
        Me.lblProceso.TabIndex = 8
        Me.lblProceso.Text = "Proceso : "
        Me.lblProceso.Values.ExtraText = ""
        Me.lblProceso.Values.Image = Nothing
        Me.lblProceso.Values.Text = "Proceso : "
        '
        'txtTipoProceso
        '
        Me.txtTipoProceso.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoProceso.Location = New System.Drawing.Point(118, 66)
        Me.txtTipoProceso.Name = "txtTipoProceso"
        Me.txtTipoProceso.pCategoria = "TIPROC"
        Me.txtTipoProceso.pIsRequired = True
        Me.txtTipoProceso.Size = New System.Drawing.Size(210, 21)
        Me.txtTipoProceso.TabIndex = 9
        '
        'lblClienteFact
        '
        Me.lblClienteFact.Location = New System.Drawing.Point(6, 44)
        Me.lblClienteFact.Name = "lblClienteFact"
        Me.lblClienteFact.Size = New System.Drawing.Size(106, 16)
        Me.lblClienteFact.TabIndex = 6
        Me.lblClienteFact.Text = "Cliente a Facturar :"
        Me.lblClienteFact.Values.ExtraText = ""
        Me.lblClienteFact.Values.Image = Nothing
        Me.lblClienteFact.Values.Text = "Cliente a Facturar :"
        '
        'txtClienteFacturar
        '
        Me.txtClienteFacturar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteFacturar.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteFacturar.Location = New System.Drawing.Point(118, 41)
        Me.txtClienteFacturar.Name = "txtClienteFacturar"
        Me.txtClienteFacturar.pIsRequired = True
        Me.txtClienteFacturar.Size = New System.Drawing.Size(531, 19)
        Me.txtClienteFacturar.TabIndex = 7
        '
        'lblNroOperacion
        '
        Me.lblNroOperacion.Location = New System.Drawing.Point(6, 19)
        Me.lblNroOperacion.Name = "lblNroOperacion"
        Me.lblNroOperacion.Size = New System.Drawing.Size(109, 16)
        Me.lblNroOperacion.TabIndex = 2
        Me.lblNroOperacion.Text = "Nro. de Operación : "
        Me.lblNroOperacion.UseMnemonic = False
        Me.lblNroOperacion.Values.ExtraText = ""
        Me.lblNroOperacion.Values.Image = Nothing
        Me.lblNroOperacion.Values.Text = "Nro. de Operación : "
        '
        'lblFechaOperacion
        '
        Me.lblFechaOperacion.Location = New System.Drawing.Point(334, 19)
        Me.lblFechaOperacion.Name = "lblFechaOperacion"
        Me.lblFechaOperacion.Size = New System.Drawing.Size(48, 16)
        Me.lblFechaOperacion.TabIndex = 4
        Me.lblFechaOperacion.Text = "Fecha : "
        Me.lblFechaOperacion.Values.ExtraText = ""
        Me.lblFechaOperacion.Values.Image = Nothing
        Me.lblFechaOperacion.Values.Text = "Fecha : "
        '
        'lblContenedor
        '
        Me.lblContenedor.Location = New System.Drawing.Point(334, 69)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(76, 16)
        Me.lblContenedor.TabIndex = 10
        Me.lblContenedor.Text = "Contenedor : "
        Me.lblContenedor.Values.ExtraText = ""
        Me.lblContenedor.Values.Image = Nothing
        Me.lblContenedor.Values.Text = "Contenedor : "
        '
        'txtNroOperacion
        '
        Me.txtNroOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOperacion.Enabled = False
        Me.txtNroOperacion.Location = New System.Drawing.Point(118, 16)
        Me.txtNroOperacion.Name = "txtNroOperacion"
        Me.txtNroOperacion.ReadOnly = True
        Me.txtNroOperacion.Size = New System.Drawing.Size(210, 19)
        Me.txtNroOperacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroOperacion.TabIndex = 3
        Me.TypeValidator.SetTypes(Me.txtNroOperacion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblSerieContenedor
        '
        Me.lblSerieContenedor.Location = New System.Drawing.Point(511, 69)
        Me.lblSerieContenedor.Name = "lblSerieContenedor"
        Me.lblSerieContenedor.Size = New System.Drawing.Size(43, 16)
        Me.lblSerieContenedor.TabIndex = 12
        Me.lblSerieContenedor.Text = "Serie : "
        Me.lblSerieContenedor.Values.ExtraText = ""
        Me.lblSerieContenedor.Values.Image = Nothing
        Me.lblSerieContenedor.Values.Text = "Serie : "
        '
        'txtCodigoContenedor
        '
        Me.txtCodigoContenedor.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtCodigoContenedor.Location = New System.Drawing.Point(416, 66)
        Me.txtCodigoContenedor.Mask = "AAAA"
        Me.txtCodigoContenedor.Name = "txtCodigoContenedor"
        Me.txtCodigoContenedor.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCodigoContenedor.Size = New System.Drawing.Size(89, 19)
        Me.txtCodigoContenedor.TabIndex = 11
        '
        'txtSerieContenedor
        '
        Me.txtSerieContenedor.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtSerieContenedor.Location = New System.Drawing.Point(560, 66)
        Me.txtSerieContenedor.Mask = "#######"
        Me.txtSerieContenedor.Name = "txtSerieContenedor"
        Me.txtSerieContenedor.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtSerieContenedor.Size = New System.Drawing.Size(89, 19)
        Me.txtSerieContenedor.TabIndex = 13
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.KryptonTextBox1, True)
        Me.KryptonTextBox1.Location = New System.Drawing.Point(717, 82)
        Me.KryptonTextBox1.MaxLength = 35
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(89, 19)
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
        Me.KryptonTextBox2.Size = New System.Drawing.Size(110, 19)
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
        Me.txtCantidadAtendida.Size = New System.Drawing.Size(110, 19)
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
        Me.KryptonTextBox3.Size = New System.Drawing.Size(314, 19)
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
        Me.txtServicio.Size = New System.Drawing.Size(314, 19)
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
        Me.KryptonTextBox4.Size = New System.Drawing.Size(89, 19)
        Me.KryptonTextBox4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KryptonTextBox4.TabIndex = 53
        Me.KryptonTextBox4.Text = "0.00"
        Me.KryptonTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.KryptonTextBox4, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'UcServicios_DgF021
        '
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
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(695, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
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
    Private WithEvents txtSerieContenedor As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents txtCodigoContenedor As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents dgServicios As RANSA.SolminControls.ucServicios_DgF02
    Private WithEvents dgBultos As RANSA.SolminControls.ucServicios_Waybill_DgF01
    Private WithEvents lblClienteFact As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtClienteFacturar As RANSA.SolminControls.ucCliente_TxtF01
    Private WithEvents lblProceso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtTipoProceso As RANSA.SolminControls.ucTipoAyuda_CmbF01
    Private WithEvents UcServicios_DgF021 As RANSA.SolminControls.ucServicios_DgF02
End Class
