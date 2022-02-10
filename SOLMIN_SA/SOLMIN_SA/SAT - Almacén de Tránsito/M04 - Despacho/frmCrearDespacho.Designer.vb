<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearDespacho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearDespacho))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.grpParametros = New System.Windows.Forms.GroupBox
        'Me.UcTicket = New Ransa.CONTROL.UcMedioTransporte
        Me.dteFechaSalida = New System.Windows.Forms.DateTimePicker
        Me.lblMotivoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtObservacion01 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtObservacion02 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblObservacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPesoTicket = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblPlacaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblPesoTicket = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPlacaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaPlacaUnidadListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaEmpresaTransporteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtNroBrevete = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaNroBreveteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblNroTicketBalanza = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPlacaAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaPlacaAcopladoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNroBrevete = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroTicketBalanza = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaNroTicketBalanzaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtMotivoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtSentidoCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblFechaSalida = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDespachoRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblPlacaAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblSentidoCarga = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDespachoRemision = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaDespachoRemisionListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.chkRegistrarServicio = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.btnGrabar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.grpParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(545, 273)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.grpParametros)
        Me.KryptonPanel1.Controls.Add(Me.chkRegistrarServicio)
        Me.KryptonPanel1.Controls.Add(Me.btnGrabar)
        Me.KryptonPanel1.Controls.Add(Me.btnCerrar)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(545, 273)
        Me.KryptonPanel1.TabIndex = 1
        '
        'grpParametros
        '
        Me.grpParametros.BackColor = System.Drawing.Color.Transparent
        'Me.grpParametros.Controls.Add(Me.UcTicket)
        Me.grpParametros.Controls.Add(Me.dteFechaSalida)
        Me.grpParametros.Controls.Add(Me.lblMotivoRecepcion)
        Me.grpParametros.Controls.Add(Me.txtObservacion01)
        Me.grpParametros.Controls.Add(Me.txtObservacion02)
        Me.grpParametros.Controls.Add(Me.lblObservacion)
        Me.grpParametros.Controls.Add(Me.txtPesoTicket)
        Me.grpParametros.Controls.Add(Me.lblPlacaUnidad)
        Me.grpParametros.Controls.Add(Me.lblPesoTicket)
        Me.grpParametros.Controls.Add(Me.txtPlacaUnidad)
        Me.grpParametros.Controls.Add(Me.txtEmpresaTransporte)
        Me.grpParametros.Controls.Add(Me.txtNroBrevete)
        Me.grpParametros.Controls.Add(Me.lblNroTicketBalanza)
        Me.grpParametros.Controls.Add(Me.txtPlacaAcoplado)
        Me.grpParametros.Controls.Add(Me.lblEmpresaTransporte)
        Me.grpParametros.Controls.Add(Me.lblNroBrevete)
        Me.grpParametros.Controls.Add(Me.txtNroTicketBalanza)
        Me.grpParametros.Controls.Add(Me.txtMotivoRecepcion)
        Me.grpParametros.Controls.Add(Me.txtSentidoCarga)
        Me.grpParametros.Controls.Add(Me.lblFechaSalida)
        Me.grpParametros.Controls.Add(Me.lblDespachoRemision)
        Me.grpParametros.Controls.Add(Me.lblPlacaAcoplado)
        Me.grpParametros.Controls.Add(Me.lblSentidoCarga)
        Me.grpParametros.Controls.Add(Me.txtDespachoRemision)
        Me.grpParametros.Location = New System.Drawing.Point(12, 12)
        Me.grpParametros.Name = "grpParametros"
        Me.grpParametros.Size = New System.Drawing.Size(521, 213)
        Me.grpParametros.TabIndex = 0
        Me.grpParametros.TabStop = False
        Me.grpParametros.Text = "Parámetros"
        '
        'UcTicket
        '
        'Me.UcTicket.BackColor = System.Drawing.Color.Transparent
        ''Me.UcTicket.Columnas = Nothing
        'Me.UcTicket.DataMember = "PSNTCKPS"
        'Me.UcTicket.DataSource = Nothing
        'Me.UcTicket.DataValue = "PSNPLCCM"
        'Me.UcTicket.Location = New System.Drawing.Point(378, 185)
        'Me.UcTicket.Name = "UcTicket"
        ''Me.UcTicket.NewProperty = Nothing
        'Me.UcTicket.objResult = Nothing
        'Me.UcTicket.Size = New System.Drawing.Size(104, 21)
        'Me.UcTicket.TabIndex = 26
        'Me.UcTicket.TiTuloDeBusqueda = "Placa Unidad"
        '
        'dteFechaSalida
        '
        Me.dteFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaSalida.Location = New System.Drawing.Point(407, 15)
        Me.dteFechaSalida.Name = "dteFechaSalida"
        Me.dteFechaSalida.Size = New System.Drawing.Size(104, 20)
        Me.dteFechaSalida.TabIndex = 4
        '
        'lblMotivoRecepcion
        '
        Me.lblMotivoRecepcion.Location = New System.Drawing.Point(6, 19)
        Me.lblMotivoRecepcion.Name = "lblMotivoRecepcion"
        Me.lblMotivoRecepcion.Size = New System.Drawing.Size(106, 19)
        Me.lblMotivoRecepcion.TabIndex = 1
        Me.lblMotivoRecepcion.Text = "Motivo Recepción : "
        Me.lblMotivoRecepcion.Values.ExtraText = ""
        Me.lblMotivoRecepcion.Values.Image = Nothing
        Me.lblMotivoRecepcion.Values.Text = "Motivo Recepción : "
        '
        'txtObservacion01
        '
        Me.txtObservacion01.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion01.Location = New System.Drawing.Point(126, 91)
        Me.txtObservacion01.MaxLength = 60
        Me.txtObservacion01.Name = "txtObservacion01"
        Me.txtObservacion01.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtObservacion01.Size = New System.Drawing.Size(385, 21)
        Me.txtObservacion01.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtObservacion01.TabIndex = 14
        Me.TypeValidator.SetTypes(Me.txtObservacion01, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtObservacion02
        '
        Me.txtObservacion02.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion02.Location = New System.Drawing.Point(126, 110)
        Me.txtObservacion02.MaxLength = 60
        Me.txtObservacion02.Name = "txtObservacion02"
        Me.txtObservacion02.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtObservacion02.Size = New System.Drawing.Size(385, 21)
        Me.txtObservacion02.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtObservacion02.TabIndex = 15
        Me.TypeValidator.SetTypes(Me.txtObservacion02, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblObservacion
        '
        Me.lblObservacion.Location = New System.Drawing.Point(6, 94)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(89, 19)
        Me.lblObservacion.TabIndex = 13
        Me.lblObservacion.Text = "Observaciones : "
        Me.lblObservacion.Values.ExtraText = ""
        Me.lblObservacion.Values.Image = Nothing
        Me.lblObservacion.Values.Text = "Observaciones : "
        '
        'txtPesoTicket
        '
        Me.TypeValidator.SetDecimales(Me.txtPesoTicket, 2)
        Me.txtPesoTicket.Enabled = False
        Me.txtPesoTicket.Location = New System.Drawing.Point(407, 66)
        Me.txtPesoTicket.Name = "txtPesoTicket"
        Me.txtPesoTicket.ReadOnly = True
        Me.txtPesoTicket.Size = New System.Drawing.Size(104, 21)
        Me.txtPesoTicket.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPesoTicket.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtPesoTicket.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoTicket.TabIndex = 12
        Me.txtPesoTicket.Text = "0.00"
        Me.txtPesoTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPesoTicket, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblPlacaUnidad
        '
        Me.lblPlacaUnidad.Location = New System.Drawing.Point(6, 163)
        Me.lblPlacaUnidad.Name = "lblPlacaUnidad"
        Me.lblPlacaUnidad.Size = New System.Drawing.Size(81, 19)
        Me.lblPlacaUnidad.TabIndex = 17
        Me.lblPlacaUnidad.Text = "Placa Unidad : "
        Me.lblPlacaUnidad.Values.ExtraText = ""
        Me.lblPlacaUnidad.Values.Image = Nothing
        Me.lblPlacaUnidad.Values.Text = "Placa Unidad : "
        '
        'lblPesoTicket
        '
        Me.lblPesoTicket.Location = New System.Drawing.Point(310, 69)
        Me.lblPesoTicket.Name = "lblPesoTicket"
        Me.lblPesoTicket.Size = New System.Drawing.Size(72, 19)
        Me.lblPesoTicket.TabIndex = 11
        Me.lblPesoTicket.Text = "Peso Ticket : "
        Me.lblPesoTicket.Values.ExtraText = ""
        Me.lblPesoTicket.Values.Image = Nothing
        Me.lblPesoTicket.Values.Text = "Peso Ticket : "
        '
        'txtPlacaUnidad
        '
        Me.txtPlacaUnidad.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaPlacaUnidadListar})
        Me.txtPlacaUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtPlacaUnidad, True)
        Me.txtPlacaUnidad.Location = New System.Drawing.Point(126, 160)
        Me.txtPlacaUnidad.MaxLength = 6
        Me.txtPlacaUnidad.Name = "txtPlacaUnidad"
        Me.txtPlacaUnidad.Size = New System.Drawing.Size(104, 21)
        Me.txtPlacaUnidad.TabIndex = 18
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
        'txtEmpresaTransporte
        '
        Me.txtEmpresaTransporte.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaEmpresaTransporteListar})
        Me.txtEmpresaTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtEmpresaTransporte, True)
        Me.txtEmpresaTransporte.Location = New System.Drawing.Point(126, 135)
        Me.txtEmpresaTransporte.MaxLength = 50
        Me.txtEmpresaTransporte.Name = "txtEmpresaTransporte"
        Me.txtEmpresaTransporte.Size = New System.Drawing.Size(356, 21)
        Me.txtEmpresaTransporte.TabIndex = 16
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
        'txtNroBrevete
        '
        Me.txtNroBrevete.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaNroBreveteListar})
        Me.txtNroBrevete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroBrevete, True)
        Me.txtNroBrevete.Location = New System.Drawing.Point(378, 160)
        Me.txtNroBrevete.MaxLength = 15
        Me.txtNroBrevete.Name = "txtNroBrevete"
        Me.txtNroBrevete.Size = New System.Drawing.Size(104, 21)
        Me.txtNroBrevete.TabIndex = 20
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
        'lblNroTicketBalanza
        '
        Me.lblNroTicketBalanza.Location = New System.Drawing.Point(310, 44)
        Me.lblNroTicketBalanza.Name = "lblNroTicketBalanza"
        Me.lblNroTicketBalanza.Size = New System.Drawing.Size(89, 19)
        Me.lblNroTicketBalanza.TabIndex = 7
        Me.lblNroTicketBalanza.Text = "No. Ticket Blza : "
        Me.lblNroTicketBalanza.Values.ExtraText = ""
        Me.lblNroTicketBalanza.Values.Image = Nothing
        Me.lblNroTicketBalanza.Values.Text = "No. Ticket Blza : "
        '
        'txtPlacaAcoplado
        '
        Me.txtPlacaAcoplado.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaPlacaAcopladoListar})
        Me.txtPlacaAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtPlacaAcoplado, True)
        Me.txtPlacaAcoplado.Location = New System.Drawing.Point(126, 185)
        Me.txtPlacaAcoplado.MaxLength = 6
        Me.txtPlacaAcoplado.Name = "txtPlacaAcoplado"
        Me.txtPlacaAcoplado.Size = New System.Drawing.Size(104, 21)
        Me.txtPlacaAcoplado.TabIndex = 22
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
        'lblEmpresaTransporte
        '
        Me.lblEmpresaTransporte.Location = New System.Drawing.Point(6, 138)
        Me.lblEmpresaTransporte.Name = "lblEmpresaTransporte"
        Me.lblEmpresaTransporte.Size = New System.Drawing.Size(115, 19)
        Me.lblEmpresaTransporte.TabIndex = 15
        Me.lblEmpresaTransporte.Text = "Empresa Transporte : "
        Me.lblEmpresaTransporte.Values.ExtraText = ""
        Me.lblEmpresaTransporte.Values.Image = Nothing
        Me.lblEmpresaTransporte.Values.Text = "Empresa Transporte : "
        '
        'lblNroBrevete
        '
        Me.lblNroBrevete.Location = New System.Drawing.Point(281, 163)
        Me.lblNroBrevete.Name = "lblNroBrevete"
        Me.lblNroBrevete.Size = New System.Drawing.Size(90, 19)
        Me.lblNroBrevete.TabIndex = 19
        Me.lblNroBrevete.Text = "No. de Brevete : "
        Me.lblNroBrevete.Values.ExtraText = ""
        Me.lblNroBrevete.Values.Image = Nothing
        Me.lblNroBrevete.Values.Text = "No. de Brevete : "
        '
        'txtNroTicketBalanza
        '
        Me.txtNroTicketBalanza.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaNroTicketBalanzaListar})
        Me.TypeValidator.SetEnterTAB(Me.txtNroTicketBalanza, True)
        Me.txtNroTicketBalanza.Location = New System.Drawing.Point(407, 41)
        Me.txtNroTicketBalanza.Name = "txtNroTicketBalanza"
        Me.txtNroTicketBalanza.Size = New System.Drawing.Size(104, 21)
        Me.txtNroTicketBalanza.TabIndex = 8
        Me.txtNroTicketBalanza.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtNroTicketBalanza, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'bsaNroTicketBalanzaListar
        '
        Me.bsaNroTicketBalanzaListar.ExtraText = ""
        Me.bsaNroTicketBalanzaListar.Image = Nothing
        Me.bsaNroTicketBalanzaListar.Text = ""
        Me.bsaNroTicketBalanzaListar.ToolTipImage = Nothing
        Me.bsaNroTicketBalanzaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaNroTicketBalanzaListar.UniqueName = "B785BFB33EA84AF5B785BFB33EA84AF5"
        '
        'txtMotivoRecepcion
        '
        Me.txtMotivoRecepcion.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtMotivoRecepcion, True)
        Me.txtMotivoRecepcion.Location = New System.Drawing.Point(126, 16)
        Me.txtMotivoRecepcion.MaxLength = 50
        Me.txtMotivoRecepcion.Name = "txtMotivoRecepcion"
        Me.txtMotivoRecepcion.ReadOnly = True
        Me.txtMotivoRecepcion.Size = New System.Drawing.Size(177, 21)
        Me.txtMotivoRecepcion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMotivoRecepcion.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMotivoRecepcion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtMotivoRecepcion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoRecepcion.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtMotivoRecepcion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'txtSentidoCarga
        '
        Me.txtSentidoCarga.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtSentidoCarga, True)
        Me.txtSentidoCarga.Location = New System.Drawing.Point(126, 41)
        Me.txtSentidoCarga.MaxLength = 50
        Me.txtSentidoCarga.Name = "txtSentidoCarga"
        Me.txtSentidoCarga.ReadOnly = True
        Me.txtSentidoCarga.Size = New System.Drawing.Size(177, 21)
        Me.txtSentidoCarga.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSentidoCarga.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSentidoCarga.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtSentidoCarga.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSentidoCarga.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtSentidoCarga, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.Location = New System.Drawing.Point(310, 19)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(77, 19)
        Me.lblFechaSalida.TabIndex = 3
        Me.lblFechaSalida.Text = "Fecha Salida :"
        Me.lblFechaSalida.Values.ExtraText = ""
        Me.lblFechaSalida.Values.Image = Nothing
        Me.lblFechaSalida.Values.Text = "Fecha Salida :"
        '
        'lblDespachoRemision
        '
        Me.lblDespachoRemision.Location = New System.Drawing.Point(6, 69)
        Me.lblDespachoRemision.Name = "lblDespachoRemision"
        Me.lblDespachoRemision.Size = New System.Drawing.Size(114, 19)
        Me.lblDespachoRemision.TabIndex = 9
        Me.lblDespachoRemision.Text = "Despacho Remisión : "
        Me.lblDespachoRemision.Values.ExtraText = ""
        Me.lblDespachoRemision.Values.Image = Nothing
        Me.lblDespachoRemision.Values.Text = "Despacho Remisión : "
        '
        'lblPlacaAcoplado
        '
        Me.lblPlacaAcoplado.Location = New System.Drawing.Point(6, 188)
        Me.lblPlacaAcoplado.Name = "lblPlacaAcoplado"
        Me.lblPlacaAcoplado.Size = New System.Drawing.Size(92, 19)
        Me.lblPlacaAcoplado.TabIndex = 21
        Me.lblPlacaAcoplado.Text = "Placa Acoplado : "
        Me.lblPlacaAcoplado.Values.ExtraText = ""
        Me.lblPlacaAcoplado.Values.Image = Nothing
        Me.lblPlacaAcoplado.Values.Text = "Placa Acoplado : "
        '
        'lblSentidoCarga
        '
        Me.lblSentidoCarga.Location = New System.Drawing.Point(6, 44)
        Me.lblSentidoCarga.Name = "lblSentidoCarga"
        Me.lblSentidoCarga.Size = New System.Drawing.Size(102, 19)
        Me.lblSentidoCarga.TabIndex = 5
        Me.lblSentidoCarga.Text = "Sentido de Carga : "
        Me.lblSentidoCarga.Values.ExtraText = ""
        Me.lblSentidoCarga.Values.Image = Nothing
        Me.lblSentidoCarga.Values.Text = "Sentido de Carga : "
        '
        'txtDespachoRemision
        '
        Me.txtDespachoRemision.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaDespachoRemisionListar})
        Me.txtDespachoRemision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtDespachoRemision, True)
        Me.txtDespachoRemision.Location = New System.Drawing.Point(126, 66)
        Me.txtDespachoRemision.MaxLength = 17
        Me.txtDespachoRemision.Name = "txtDespachoRemision"
        Me.txtDespachoRemision.Size = New System.Drawing.Size(177, 21)
        Me.txtDespachoRemision.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDespachoRemision.TabIndex = 10
        Me.TypeValidator.SetTypes(Me.txtDespachoRemision, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaDespachoRemisionListar
        '
        Me.bsaDespachoRemisionListar.ExtraText = ""
        Me.bsaDespachoRemisionListar.Image = Nothing
        Me.bsaDespachoRemisionListar.Text = ""
        Me.bsaDespachoRemisionListar.ToolTipImage = Nothing
        Me.bsaDespachoRemisionListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaDespachoRemisionListar.UniqueName = "D7711983F292423BD7711983F292423B"
        '
        'chkRegistrarServicio
        '
        Me.chkRegistrarServicio.Checked = False
        Me.chkRegistrarServicio.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkRegistrarServicio.Location = New System.Drawing.Point(18, 231)
        Me.chkRegistrarServicio.Name = "chkRegistrarServicio"
        Me.chkRegistrarServicio.Size = New System.Drawing.Size(114, 19)
        Me.chkRegistrarServicio.TabIndex = 23
        Me.chkRegistrarServicio.Text = "Registrar Servicios"
        Me.chkRegistrarServicio.Values.ExtraText = ""
        Me.chkRegistrarServicio.Values.Image = Nothing
        Me.chkRegistrarServicio.Values.Text = "Registrar Servicios"
        '
        'btnGrabar
        '
        Me.btnGrabar.AutoSize = True
        Me.btnGrabar.Location = New System.Drawing.Point(347, 231)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(90, 28)
        Me.btnGrabar.TabIndex = 24
        Me.btnGrabar.Text = "    Grabar"
        Me.btnGrabar.Values.ExtraText = ""
        Me.btnGrabar.Values.Image = CType(resources.GetObject("btnGrabar.Values.Image"), System.Drawing.Image)
        Me.btnGrabar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGrabar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGrabar.Values.Text = "    Grabar"
        '
        'btnCerrar
        '
        Me.btnCerrar.AutoSize = True
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(443, 231)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(90, 28)
        Me.btnCerrar.TabIndex = 25
        Me.btnCerrar.Text = "    Cerrar"
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = CType(resources.GetObject("btnCerrar.Values.Image"), System.Drawing.Image)
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "    Cerrar"
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 273)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCrearDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DESPACHO"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.grpParametros.ResumeLayout(False)
        Me.grpParametros.PerformLayout()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnGrabar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtDespachoRemision As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDespachoRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroTicketBalanza As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroTicketBalanza As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlacaUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtObservacion01 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblObservacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPlacaUnidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEmpresaTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblEmpresaTransporte As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSentidoCarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblSentidoCarga As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMotivoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblMotivoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaSalida As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroBrevete As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroBrevete As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlacaAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPlacaAcoplado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bsaNroTicketBalanzaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaDespachoRemisionListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaEmpresaTransporteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaPlacaUnidadListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaNroBreveteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaPlacaAcopladoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtPesoTicket As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPesoTicket As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObservacion02 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents grpParametros As System.Windows.Forms.GroupBox
    Friend WithEvents chkRegistrarServicio As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dteFechaSalida As System.Windows.Forms.DateTimePicker
    'Friend WithEvents UcTicket As Ransa.CONTROL.UcMedioTransporte
End Class
