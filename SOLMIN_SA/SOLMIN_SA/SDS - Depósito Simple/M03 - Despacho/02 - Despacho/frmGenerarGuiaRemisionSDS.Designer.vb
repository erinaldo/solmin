<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarGuiaRemisionSDS
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
        Dim BePlantaDeEntrega11 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim BePlantaDeEntrega12 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim BePlantaDeEntrega13 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim BePlantaDeEntrega14 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim BePlantaDeEntrega15 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim BePlantaDeEntrega16 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim BePlantaDeEntrega17 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim BePlantaDeEntrega18 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim BePlantaDeEntrega19 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Dim BePlantaDeEntrega20 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.btnPegar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCopiar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNroGuiaInterna = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroGuiaInterna = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.lblMotivoDespacho = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtObsOtrosMotivos = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTipoDoc = New Ransa.Utilitario.ucAyuda()
        Me.txtMotivoTraslado = New Ransa.Utilitario.ucAyuda()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.chkAutoGenerar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCodCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNroFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.txtNroFactura = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.dtpFechaTraslado = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaTraslado = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaEmision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.grpEmpresaTransporte = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabGlosa = New System.Windows.Forms.TabPage()
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TabObservacion = New System.Windows.Forms.TabPage()
        Me.dtgObservacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TOBSGS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMantCamiones = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtManChoferes = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtNumeroContenedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSigla = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMedioSugerido = New RANSA.CONTROL.UcMedioTransporte()
        Me.txtEmpresaTransporte2doTramo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaEmpresaTransporte2doTramoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblTransporte2doTramo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkDosTramos = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtNroBrevete = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaNroBreveteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtPlacaAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaPlacaAcopladoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblNroBrevete = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPlacaAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEmpresaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaEmpresaTransporteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtPlacaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaPlacaUnidadListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblPlacaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.grpPuntos = New System.Windows.Forms.GroupBox()
        Me.UcPlantaDeEntregaPropioDestino = New Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01()
        Me.rbtClienteTercero = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtPlantaCliente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPlantaDeEntregaDestino = New Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01()
        Me.UcClienteTerceroDestino = New Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcClienteTerceroOrigen = New Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01()
        Me.UcPlantaDeEntregaOrigen = New Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01()
        Me.lblPlantaOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblClienteOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.cboTipoGR = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpEmpresaTransporte.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabGlosa.SuspendLayout()
        Me.TabObservacion.SuspendLayout()
        CType(Me.dtgObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPuntos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1341, 661)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnPegar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnCopiar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnCancelar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnAceptar)
        Me.KryptonGroup1.Panel.Controls.Add(Me.GroupBox2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.grpEmpresaTransporte)
        Me.KryptonGroup1.Panel.Controls.Add(Me.grpPuntos)
        Me.KryptonGroup1.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonGroup1.Size = New System.Drawing.Size(1341, 661)
        Me.KryptonGroup1.TabIndex = 0
        '
        'btnPegar
        '
        Me.btnPegar.Location = New System.Drawing.Point(524, 619)
        Me.btnPegar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPegar.Name = "btnPegar"
        Me.btnPegar.Size = New System.Drawing.Size(120, 31)
        Me.btnPegar.TabIndex = 8
        Me.btnPegar.Text = "Pegar"
        Me.btnPegar.Values.ExtraText = ""
        Me.btnPegar.Values.Image = Nothing
        Me.btnPegar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnPegar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnPegar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnPegar.Values.Text = "Pegar"
        Me.btnPegar.Visible = False
        '
        'btnCopiar
        '
        Me.btnCopiar.Location = New System.Drawing.Point(396, 619)
        Me.btnCopiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(120, 31)
        Me.btnCopiar.TabIndex = 7
        Me.btnCopiar.Text = "Copiar"
        Me.btnCopiar.Values.ExtraText = ""
        Me.btnCopiar.Values.Image = Nothing
        Me.btnCopiar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCopiar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCopiar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCopiar.Values.Text = "Copiar"
        Me.btnCopiar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(779, 619)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 31)
        Me.btnCancelar.TabIndex = 6
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
        Me.btnAceptar.Location = New System.Drawing.Point(651, 619)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 31)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "&Aceptar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cboTipoGR)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel14)
        Me.GroupBox2.Controls.Add(Me.lblNroGuiaInterna)
        Me.GroupBox2.Controls.Add(Me.txtNroGuiaInterna)
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
        Me.GroupBox2.Location = New System.Drawing.Point(15, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1303, 180)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lblNroGuiaInterna
        '
        Me.lblNroGuiaInterna.Location = New System.Drawing.Point(13, 21)
        Me.lblNroGuiaInterna.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNroGuiaInterna.Name = "lblNroGuiaInterna"
        Me.lblNroGuiaInterna.Size = New System.Drawing.Size(133, 24)
        Me.lblNroGuiaInterna.TabIndex = 0
        Me.lblNroGuiaInterna.Text = "Nro de G. de Sal. : "
        Me.lblNroGuiaInterna.Values.ExtraText = ""
        Me.lblNroGuiaInterna.Values.Image = Nothing
        Me.lblNroGuiaInterna.Values.Text = "Nro de G. de Sal. : "
        '
        'txtNroGuiaInterna
        '
        Me.TypeValidator.SetEnterTAB(Me.txtNroGuiaInterna, True)
        Me.txtNroGuiaInterna.Location = New System.Drawing.Point(167, 18)
        Me.txtNroGuiaInterna.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNroGuiaInterna.MaxLength = 10
        Me.txtNroGuiaInterna.Name = "txtNroGuiaInterna"
        Me.txtNroGuiaInterna.ReadOnly = True
        Me.txtNroGuiaInterna.Size = New System.Drawing.Size(219, 26)
        Me.txtNroGuiaInterna.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNroGuiaInterna.TabIndex = 1
        Me.txtNroGuiaInterna.TabStop = False
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(1123, 50)
        Me.dtpFechaEmision.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaEmision.TabIndex = 7
        '
        'lblMotivoDespacho
        '
        Me.lblMotivoDespacho.Location = New System.Drawing.Point(9, 116)
        Me.lblMotivoDespacho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMotivoDespacho.Name = "lblMotivoDespacho"
        Me.lblMotivoDespacho.Size = New System.Drawing.Size(139, 24)
        Me.lblMotivoDespacho.TabIndex = 16
        Me.lblMotivoDespacho.Text = "Motivo Despacho :"
        Me.lblMotivoDespacho.Values.ExtraText = ""
        Me.lblMotivoDespacho.Values.Image = Nothing
        Me.lblMotivoDespacho.Values.Text = "Motivo Despacho :"
        '
        'txtObsOtrosMotivos
        '
        Me.txtObsOtrosMotivos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObsOtrosMotivos.Location = New System.Drawing.Point(167, 139)
        Me.txtObsOtrosMotivos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObsOtrosMotivos.MaxLength = 30
        Me.txtObsOtrosMotivos.Name = "txtObsOtrosMotivos"
        Me.txtObsOtrosMotivos.ReadOnly = True
        Me.txtObsOtrosMotivos.Size = New System.Drawing.Size(472, 26)
        Me.txtObsOtrosMotivos.TabIndex = 18
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoDoc.DataSource = Nothing
        Me.txtTipoDoc.DispleyMember = ""
        Me.txtTipoDoc.Etiquetas_Form = Nothing
        Me.txtTipoDoc.ListColumnas = Nothing
        Me.txtTipoDoc.Location = New System.Drawing.Point(167, 80)
        Me.txtTipoDoc.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Obligatorio = False
        Me.txtTipoDoc.PopupHeight = 0
        Me.txtTipoDoc.PopupWidth = 0
        Me.txtTipoDoc.Size = New System.Drawing.Size(173, 26)
        Me.txtTipoDoc.SizeFont = 0
        Me.txtTipoDoc.TabIndex = 9
        Me.txtTipoDoc.ValueMember = ""
        '
        'txtMotivoTraslado
        '
        Me.txtMotivoTraslado.BackColor = System.Drawing.Color.Transparent
        Me.txtMotivoTraslado.DataSource = Nothing
        Me.txtMotivoTraslado.DispleyMember = ""
        Me.txtMotivoTraslado.Etiquetas_Form = Nothing
        Me.txtMotivoTraslado.ListColumnas = Nothing
        Me.txtMotivoTraslado.Location = New System.Drawing.Point(167, 110)
        Me.txtMotivoTraslado.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtMotivoTraslado.Name = "txtMotivoTraslado"
        Me.txtMotivoTraslado.Obligatorio = True
        Me.txtMotivoTraslado.PopupHeight = 0
        Me.txtMotivoTraslado.PopupWidth = 0
        Me.txtMotivoTraslado.Size = New System.Drawing.Size(472, 26)
        Me.txtMotivoTraslado.SizeFont = 0
        Me.txtMotivoTraslado.TabIndex = 17
        Me.txtMotivoTraslado.ValueMember = ""
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = ""
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(167, 52)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(472, 26)
        Me.txtCliente.TabIndex = 3
        '
        'chkAutoGenerar
        '
        Me.chkAutoGenerar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoGenerar.Location = New System.Drawing.Point(640, 50)
        Me.chkAutoGenerar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAutoGenerar.Name = "chkAutoGenerar"
        Me.chkAutoGenerar.Size = New System.Drawing.Size(151, 24)
        Me.chkAutoGenerar.TabIndex = 4
        Me.chkAutoGenerar.Text = "N° Guía Remisión :"
        Me.chkAutoGenerar.Values.ExtraText = ""
        Me.chkAutoGenerar.Values.Image = Nothing
        Me.chkAutoGenerar.Values.Text = "N° Guía Remisión :"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(63, 81)
        Me.KryptonLabel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(84, 24)
        Me.KryptonLabel8.TabIndex = 8
        Me.KryptonLabel8.Text = "Tipo Doc. :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Tipo Doc. :"
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.Location = New System.Drawing.Point(705, 78)
        Me.lblFechaFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(93, 24)
        Me.lblFechaFactura.TabIndex = 12
        Me.lblFechaFactura.Text = "Fecha Doc. : "
        Me.lblFechaFactura.Values.ExtraText = ""
        Me.lblFechaFactura.Values.Image = Nothing
        Me.lblFechaFactura.Values.Text = "Fecha Doc. : "
        '
        'lblCodCliente
        '
        Me.lblCodCliente.Location = New System.Drawing.Point(80, 52)
        Me.lblCodCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCodCliente.Name = "lblCodCliente"
        Me.lblCodCliente.Size = New System.Drawing.Size(66, 24)
        Me.lblCodCliente.TabIndex = 2
        Me.lblCodCliente.Text = "Cliente : "
        Me.lblCodCliente.Values.ExtraText = ""
        Me.lblCodCliente.Values.Image = Nothing
        Me.lblCodCliente.Values.Text = "Cliente : "
        '
        'lblNroFactura
        '
        Me.lblNroFactura.Location = New System.Drawing.Point(365, 81)
        Me.lblNroFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNroFactura.Name = "lblNroFactura"
        Me.lblNroFactura.Size = New System.Drawing.Size(71, 24)
        Me.lblNroFactura.TabIndex = 10
        Me.lblNroFactura.Text = "N° Doc. : "
        Me.lblNroFactura.Values.ExtraText = ""
        Me.lblNroFactura.Values.Image = Nothing
        Me.lblNroFactura.Values.Text = "N° Doc. : "
        '
        'txtNroGuiaRemision
        '
        Me.txtNroGuiaRemision.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtNroGuiaRemision.Location = New System.Drawing.Point(808, 48)
        Me.txtNroGuiaRemision.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNroGuiaRemision.Mask = "###-#######"
        Me.txtNroGuiaRemision.Name = "txtNroGuiaRemision"
        Me.txtNroGuiaRemision.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNroGuiaRemision.Size = New System.Drawing.Size(173, 26)
        Me.txtNroGuiaRemision.TabIndex = 5
        Me.txtNroGuiaRemision.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtNroFactura
        '
        Me.txtNroFactura.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtNroFactura.Location = New System.Drawing.Point(465, 80)
        Me.txtNroFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNroFactura.Mask = "###-#######"
        Me.txtNroFactura.Name = "txtNroFactura"
        Me.txtNroFactura.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNroFactura.Size = New System.Drawing.Size(173, 26)
        Me.txtNroFactura.TabIndex = 11
        Me.txtNroFactura.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'dtpFechaTraslado
        '
        Me.dtpFechaTraslado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaTraslado.Location = New System.Drawing.Point(1123, 79)
        Me.dtpFechaTraslado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaTraslado.Name = "dtpFechaTraslado"
        Me.dtpFechaTraslado.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaTraslado.TabIndex = 15
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(817, 78)
        Me.dtpFechaFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaFactura.TabIndex = 13
        '
        'lblFechaTraslado
        '
        Me.lblFechaTraslado.Location = New System.Drawing.Point(999, 81)
        Me.lblFechaTraslado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblFechaTraslado.Name = "lblFechaTraslado"
        Me.lblFechaTraslado.Size = New System.Drawing.Size(120, 24)
        Me.lblFechaTraslado.TabIndex = 14
        Me.lblFechaTraslado.Text = "Fecha Traslado :"
        Me.lblFechaTraslado.Values.ExtraText = ""
        Me.lblFechaTraslado.Values.Image = Nothing
        Me.lblFechaTraslado.Values.Text = "Fecha Traslado :"
        '
        'lblFechaEmision
        '
        Me.lblFechaEmision.Location = New System.Drawing.Point(1061, 52)
        Me.lblFechaEmision.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblFechaEmision.Name = "lblFechaEmision"
        Me.lblFechaEmision.Size = New System.Drawing.Size(58, 24)
        Me.lblFechaEmision.TabIndex = 6
        Me.lblFechaEmision.Text = "Fecha :"
        Me.lblFechaEmision.Values.ExtraText = ""
        Me.lblFechaEmision.Values.Image = Nothing
        Me.lblFechaEmision.Values.Text = "Fecha :"
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
        Me.grpEmpresaTransporte.Location = New System.Drawing.Point(15, 330)
        Me.grpEmpresaTransporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpEmpresaTransporte.Name = "grpEmpresaTransporte"
        Me.grpEmpresaTransporte.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpEmpresaTransporte.Size = New System.Drawing.Size(1303, 282)
        Me.grpEmpresaTransporte.TabIndex = 4
        Me.grpEmpresaTransporte.TabStop = False
        Me.grpEmpresaTransporte.Text = "Información del Transporte"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabGlosa)
        Me.TabControl1.Controls.Add(Me.TabObservacion)
        Me.TabControl1.Location = New System.Drawing.Point(27, 129)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1263, 144)
        Me.TabControl1.TabIndex = 21
        '
        'TabGlosa
        '
        Me.TabGlosa.Controls.Add(Me.txtObservaciones)
        Me.TabGlosa.Location = New System.Drawing.Point(4, 25)
        Me.TabGlosa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabGlosa.Name = "TabGlosa"
        Me.TabGlosa.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabGlosa.Size = New System.Drawing.Size(1255, 115)
        Me.TabGlosa.TabIndex = 0
        Me.TabGlosa.Text = "Glosa"
        Me.TabGlosa.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Location = New System.Drawing.Point(4, 4)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservaciones.MaxLength = 90
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(1247, 107)
        Me.txtObservaciones.TabIndex = 13
        '
        'TabObservacion
        '
        Me.TabObservacion.Controls.Add(Me.dtgObservacion)
        Me.TabObservacion.Location = New System.Drawing.Point(4, 25)
        Me.TabObservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabObservacion.Name = "TabObservacion"
        Me.TabObservacion.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabObservacion.Size = New System.Drawing.Size(1255, 115)
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
        Me.dtgObservacion.Location = New System.Drawing.Point(4, 4)
        Me.dtgObservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgObservacion.Name = "dtgObservacion"
        Me.dtgObservacion.RowHeadersWidth = 15
        Me.dtgObservacion.Size = New System.Drawing.Size(1247, 107)
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
        'txtMantCamiones
        '
        Me.txtMantCamiones.Location = New System.Drawing.Point(336, 50)
        Me.txtMantCamiones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMantCamiones.Name = "txtMantCamiones"
        Me.txtMantCamiones.Size = New System.Drawing.Size(27, 31)
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
        Me.txtManChoferes.Location = New System.Drawing.Point(631, 50)
        Me.txtManChoferes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtManChoferes.Name = "txtManChoferes"
        Me.txtManChoferes.Size = New System.Drawing.Size(28, 31)
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
        Me.txtNumeroContenedor.Location = New System.Drawing.Point(1163, 95)
        Me.txtNumeroContenedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumeroContenedor.MaxLength = 7
        Me.txtNumeroContenedor.Name = "txtNumeroContenedor"
        Me.txtNumeroContenedor.Size = New System.Drawing.Size(132, 26)
        Me.txtNumeroContenedor.TabIndex = 20
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(999, 95)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(160, 24)
        Me.KryptonLabel4.TabIndex = 19
        Me.KryptonLabel4.Text = "Número Contenedor : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Número Contenedor : "
        '
        'txtSigla
        '
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSigla.Location = New System.Drawing.Point(812, 95)
        Me.txtSigla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSigla.MaxLength = 4
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(179, 26)
        Me.txtSigla.TabIndex = 18
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(659, 97)
        Me.KryptonLabel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(137, 24)
        Me.KryptonLabel7.TabIndex = 17
        Me.KryptonLabel7.Text = "Sigla Contenedor : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Sigla Contenedor : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(0, 22)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(141, 24)
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
        Me.txtMedioSugerido.Location = New System.Drawing.Point(167, 18)
        Me.txtMedioSugerido.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtMedioSugerido.Name = "txtMedioSugerido"
        Me.txtMedioSugerido.objResult = Nothing
        Me.txtMedioSugerido.Size = New System.Drawing.Size(472, 31)
        Me.txtMedioSugerido.TabIndex = 1
        '
        'txtEmpresaTransporte2doTramo
        '
        Me.txtEmpresaTransporte2doTramo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaEmpresaTransporte2doTramoListar})
        Me.txtEmpresaTransporte2doTramo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresaTransporte2doTramo.Enabled = False
        Me.txtEmpresaTransporte2doTramo.Location = New System.Drawing.Point(164, 97)
        Me.txtEmpresaTransporte2doTramo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmpresaTransporte2doTramo.MaxLength = 50
        Me.txtEmpresaTransporte2doTramo.Name = "txtEmpresaTransporte2doTramo"
        Me.txtEmpresaTransporte2doTramo.Size = New System.Drawing.Size(472, 26)
        Me.txtEmpresaTransporte2doTramo.TabIndex = 16
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
        Me.lblTransporte2doTramo.Location = New System.Drawing.Point(16, 105)
        Me.lblTransporte2doTramo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTransporte2doTramo.Name = "lblTransporte2doTramo"
        Me.lblTransporte2doTramo.Size = New System.Drawing.Size(130, 24)
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
        Me.chkDosTramos.Location = New System.Drawing.Point(13, 82)
        Me.chkDosTramos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkDosTramos.Name = "chkDosTramos"
        Me.chkDosTramos.Size = New System.Drawing.Size(105, 24)
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
        Me.txtNroBrevete.Location = New System.Drawing.Point(455, 53)
        Me.txtNroBrevete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNroBrevete.MaxLength = 15
        Me.txtNroBrevete.Name = "txtNroBrevete"
        Me.txtNroBrevete.Size = New System.Drawing.Size(169, 26)
        Me.txtNroBrevete.TabIndex = 8
        Me.txtNroBrevete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtPlacaAcoplado.Location = New System.Drawing.Point(812, 53)
        Me.txtPlacaAcoplado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPlacaAcoplado.MaxLength = 6
        Me.txtPlacaAcoplado.Name = "txtPlacaAcoplado"
        Me.txtPlacaAcoplado.Size = New System.Drawing.Size(173, 26)
        Me.txtPlacaAcoplado.TabIndex = 11
        Me.txtPlacaAcoplado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lblNroBrevete.Location = New System.Drawing.Point(381, 54)
        Me.lblNroBrevete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNroBrevete.Name = "lblNroBrevete"
        Me.lblNroBrevete.Size = New System.Drawing.Size(70, 24)
        Me.lblNroBrevete.TabIndex = 7
        Me.lblNroBrevete.Text = "Brevete : "
        Me.lblNroBrevete.Values.ExtraText = ""
        Me.lblNroBrevete.Values.Image = Nothing
        Me.lblNroBrevete.Values.Text = "Brevete : "
        '
        'lblPlacaAcoplado
        '
        Me.lblPlacaAcoplado.Location = New System.Drawing.Point(688, 53)
        Me.lblPlacaAcoplado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPlacaAcoplado.Name = "lblPlacaAcoplado"
        Me.lblPlacaAcoplado.Size = New System.Drawing.Size(106, 24)
        Me.lblPlacaAcoplado.TabIndex = 10
        Me.lblPlacaAcoplado.Text = "N° Acoplado : "
        Me.lblPlacaAcoplado.Values.ExtraText = ""
        Me.lblPlacaAcoplado.Values.Image = Nothing
        Me.lblPlacaAcoplado.Values.Text = "N° Acoplado : "
        '
        'lblEmpresaTransporte
        '
        Me.lblEmpresaTransporte.Location = New System.Drawing.Point(665, 21)
        Me.lblEmpresaTransporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblEmpresaTransporte.Name = "lblEmpresaTransporte"
        Me.lblEmpresaTransporte.Size = New System.Drawing.Size(130, 24)
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
        Me.txtEmpresaTransporte.Location = New System.Drawing.Point(812, 22)
        Me.txtEmpresaTransporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmpresaTransporte.MaxLength = 50
        Me.txtEmpresaTransporte.Name = "txtEmpresaTransporte"
        Me.txtEmpresaTransporte.Size = New System.Drawing.Size(472, 26)
        Me.txtEmpresaTransporte.TabIndex = 3
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
        Me.txtPlacaUnidad.Location = New System.Drawing.Point(165, 50)
        Me.txtPlacaUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPlacaUnidad.MaxLength = 6
        Me.txtPlacaUnidad.Name = "txtPlacaUnidad"
        Me.txtPlacaUnidad.Size = New System.Drawing.Size(173, 26)
        Me.txtPlacaUnidad.TabIndex = 5
        Me.txtPlacaUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lblPlacaUnidad.Location = New System.Drawing.Point(55, 50)
        Me.lblPlacaUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPlacaUnidad.Name = "lblPlacaUnidad"
        Me.lblPlacaUnidad.Size = New System.Drawing.Size(90, 24)
        Me.lblPlacaUnidad.TabIndex = 4
        Me.lblPlacaUnidad.Text = "N° Unidad : "
        Me.lblPlacaUnidad.Values.ExtraText = ""
        Me.lblPlacaUnidad.Values.Image = Nothing
        Me.lblPlacaUnidad.Values.Text = "N° Unidad : "
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
        Me.grpPuntos.Location = New System.Drawing.Point(12, 247)
        Me.grpPuntos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPuntos.Name = "grpPuntos"
        Me.grpPuntos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPuntos.Size = New System.Drawing.Size(1303, 76)
        Me.grpPuntos.TabIndex = 3
        Me.grpPuntos.TabStop = False
        Me.grpPuntos.Text = "Destino"
        '
        'UcPlantaDeEntregaPropioDestino
        '
        Me.UcPlantaDeEntregaPropioDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcPlantaDeEntregaPropioDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcPlantaDeEntregaPropioDestino.CodCliente = 0.0R
        Me.UcPlantaDeEntregaPropioDestino.CodClienteTercero = 0.0R
        Me.UcPlantaDeEntregaPropioDestino.CodigoPlantaCliente = 0.0R
        BePlantaDeEntrega11.PageCount = 0
        BePlantaDeEntrega11.PageNumber = 0
        BePlantaDeEntrega11.PageSize = 0
        BePlantaDeEntrega11.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega11.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega11.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega11.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega11.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega11.PNCUBGEO = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega11.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega11.PSCPLNAF = Nothing
        BePlantaDeEntrega11.PSCPRPCL = Nothing
        BePlantaDeEntrega11.PSSTPORL = Nothing
        BePlantaDeEntrega11.PSTCMPPL = ""
        BePlantaDeEntrega11.PSTDRCPL = ""
        BePlantaDeEntrega11.PSTDRPRC = ""
        BePlantaDeEntrega11.PSTPRVCL = ""
        BePlantaDeEntrega11.PSUBIGEO = ""
        BePlantaDeEntrega11.TIPOCLIENTE = True
        Me.UcPlantaDeEntregaPropioDestino.InfPlantaDeEntrega = BePlantaDeEntrega11
        BePlantaDeEntrega12.PageCount = 0
        BePlantaDeEntrega12.PageNumber = 0
        BePlantaDeEntrega12.PageSize = 0
        BePlantaDeEntrega12.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega12.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega12.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega12.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega12.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega12.PNCUBGEO = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega12.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega12.PSCPLNAF = Nothing
        BePlantaDeEntrega12.PSCPRPCL = Nothing
        BePlantaDeEntrega12.PSSTPORL = Nothing
        BePlantaDeEntrega12.PSTCMPPL = ""
        BePlantaDeEntrega12.PSTDRCPL = ""
        BePlantaDeEntrega12.PSTDRPRC = ""
        BePlantaDeEntrega12.PSTPRVCL = ""
        BePlantaDeEntrega12.PSUBIGEO = ""
        BePlantaDeEntrega12.TIPOCLIENTE = True
        Me.UcPlantaDeEntregaPropioDestino.ItemActual = BePlantaDeEntrega12
        Me.UcPlantaDeEntregaPropioDestino.Lectura = False
        Me.UcPlantaDeEntregaPropioDestino.Location = New System.Drawing.Point(169, 14)
        Me.UcPlantaDeEntregaPropioDestino.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcPlantaDeEntregaPropioDestino.Name = "UcPlantaDeEntregaPropioDestino"
        Me.UcPlantaDeEntregaPropioDestino.Size = New System.Drawing.Size(472, 26)
        Me.UcPlantaDeEntregaPropioDestino.TabIndex = 2
        Me.UcPlantaDeEntregaPropioDestino.TipoPlantaDeEntrega = True
        '
        'rbtClienteTercero
        '
        Me.rbtClienteTercero.Checked = True
        Me.rbtClienteTercero.Location = New System.Drawing.Point(16, 43)
        Me.rbtClienteTercero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtClienteTercero.Name = "rbtClienteTercero"
        Me.rbtClienteTercero.Size = New System.Drawing.Size(78, 24)
        Me.rbtClienteTercero.TabIndex = 3
        Me.rbtClienteTercero.Text = "Cliente : "
        Me.rbtClienteTercero.Values.ExtraText = ""
        Me.rbtClienteTercero.Values.Image = Nothing
        Me.rbtClienteTercero.Values.Text = "Cliente : "
        '
        'rbtPlantaCliente
        '
        Me.rbtPlantaCliente.Checked = True
        Me.rbtPlantaCliente.Location = New System.Drawing.Point(16, 16)
        Me.rbtPlantaCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtPlantaCliente.Name = "rbtPlantaCliente"
        Me.rbtPlantaCliente.Size = New System.Drawing.Size(77, 24)
        Me.rbtPlantaCliente.TabIndex = 1
        Me.rbtPlantaCliente.Text = "Planta  : "
        Me.rbtPlantaCliente.Values.ExtraText = ""
        Me.rbtPlantaCliente.Values.Image = Nothing
        Me.rbtPlantaCliente.Values.Text = "Planta  : "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(740, 43)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(61, 24)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Text = "Planta : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta : "
        '
        'UcPlantaDeEntregaDestino
        '
        Me.UcPlantaDeEntregaDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcPlantaDeEntregaDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcPlantaDeEntregaDestino.CodCliente = 0.0R
        Me.UcPlantaDeEntregaDestino.CodClienteTercero = 0.0R
        Me.UcPlantaDeEntregaDestino.CodigoPlantaCliente = 0.0R
        Me.UcPlantaDeEntregaDestino.Enabled = False
        BePlantaDeEntrega13.PageCount = 0
        BePlantaDeEntrega13.PageNumber = 0
        BePlantaDeEntrega13.PageSize = 0
        BePlantaDeEntrega13.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega13.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega13.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega13.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega13.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega13.PNCUBGEO = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega13.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega13.PSCPLNAF = Nothing
        BePlantaDeEntrega13.PSCPRPCL = Nothing
        BePlantaDeEntrega13.PSSTPORL = Nothing
        BePlantaDeEntrega13.PSTCMPPL = ""
        BePlantaDeEntrega13.PSTDRCPL = ""
        BePlantaDeEntrega13.PSTDRPRC = ""
        BePlantaDeEntrega13.PSTPRVCL = ""
        BePlantaDeEntrega13.PSUBIGEO = ""
        BePlantaDeEntrega13.TIPOCLIENTE = True
        Me.UcPlantaDeEntregaDestino.InfPlantaDeEntrega = BePlantaDeEntrega13
        BePlantaDeEntrega14.PageCount = 0
        BePlantaDeEntrega14.PageNumber = 0
        BePlantaDeEntrega14.PageSize = 0
        BePlantaDeEntrega14.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega14.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega14.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega14.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega14.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega14.PNCUBGEO = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega14.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega14.PSCPLNAF = Nothing
        BePlantaDeEntrega14.PSCPRPCL = Nothing
        BePlantaDeEntrega14.PSSTPORL = Nothing
        BePlantaDeEntrega14.PSTCMPPL = ""
        BePlantaDeEntrega14.PSTDRCPL = ""
        BePlantaDeEntrega14.PSTDRPRC = ""
        BePlantaDeEntrega14.PSTPRVCL = ""
        BePlantaDeEntrega14.PSUBIGEO = ""
        BePlantaDeEntrega14.TIPOCLIENTE = True
        Me.UcPlantaDeEntregaDestino.ItemActual = BePlantaDeEntrega14
        Me.UcPlantaDeEntregaDestino.Lectura = False
        Me.UcPlantaDeEntregaDestino.Location = New System.Drawing.Point(811, 44)
        Me.UcPlantaDeEntregaDestino.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcPlantaDeEntregaDestino.Name = "UcPlantaDeEntregaDestino"
        Me.UcPlantaDeEntregaDestino.Size = New System.Drawing.Size(472, 26)
        Me.UcPlantaDeEntregaDestino.TabIndex = 5
        Me.UcPlantaDeEntregaDestino.TipoPlantaDeEntrega = True
        '
        'UcClienteTerceroDestino
        '
        Me.UcClienteTerceroDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteTerceroDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcClienteTerceroDestino.CodCliente = 0.0R
        Me.UcClienteTerceroDestino.CodigoPlantaCliente = 0.0R
        Me.UcClienteTerceroDestino.Enabled = False
        BePlantaDeEntrega15.PageCount = 0
        BePlantaDeEntrega15.PageNumber = 0
        BePlantaDeEntrega15.PageSize = 0
        BePlantaDeEntrega15.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega15.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega15.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega15.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega15.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega15.PNCUBGEO = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega15.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega15.PSCPLNAF = Nothing
        BePlantaDeEntrega15.PSCPRPCL = Nothing
        BePlantaDeEntrega15.PSSTPORL = Nothing
        BePlantaDeEntrega15.PSTCMPPL = ""
        BePlantaDeEntrega15.PSTDRCPL = ""
        BePlantaDeEntrega15.PSTDRPRC = ""
        BePlantaDeEntrega15.PSTPRVCL = ""
        BePlantaDeEntrega15.PSUBIGEO = ""
        BePlantaDeEntrega15.TIPOCLIENTE = True
        Me.UcClienteTerceroDestino.InfPlantaDeEntrega = BePlantaDeEntrega15
        BePlantaDeEntrega16.PageCount = 0
        BePlantaDeEntrega16.PageNumber = 0
        BePlantaDeEntrega16.PageSize = 0
        BePlantaDeEntrega16.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega16.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega16.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega16.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega16.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega16.PNCUBGEO = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega16.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega16.PSCPLNAF = Nothing
        BePlantaDeEntrega16.PSCPRPCL = Nothing
        BePlantaDeEntrega16.PSSTPORL = Nothing
        BePlantaDeEntrega16.PSTCMPPL = ""
        BePlantaDeEntrega16.PSTDRCPL = ""
        BePlantaDeEntrega16.PSTDRPRC = ""
        BePlantaDeEntrega16.PSTPRVCL = ""
        BePlantaDeEntrega16.PSUBIGEO = ""
        BePlantaDeEntrega16.TIPOCLIENTE = True
        Me.UcClienteTerceroDestino.ItemActual = BePlantaDeEntrega16
        Me.UcClienteTerceroDestino.Location = New System.Drawing.Point(169, 43)
        Me.UcClienteTerceroDestino.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcClienteTerceroDestino.MostrarRuc = False
        Me.UcClienteTerceroDestino.Name = "UcClienteTerceroDestino"
        Me.UcClienteTerceroDestino.Ruc = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcClienteTerceroDestino.Size = New System.Drawing.Size(472, 26)
        Me.UcClienteTerceroDestino.TabIndex = 4
        Me.UcClienteTerceroDestino.TipoRelacion = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.UcClienteTerceroOrigen)
        Me.GroupBox1.Controls.Add(Me.UcPlantaDeEntregaOrigen)
        Me.GroupBox1.Controls.Add(Me.lblPlantaOrigen)
        Me.GroupBox1.Controls.Add(Me.lblClienteOrigen)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 186)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1303, 60)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origen "
        '
        'UcClienteTerceroOrigen
        '
        Me.UcClienteTerceroOrigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteTerceroOrigen.BackColor = System.Drawing.Color.Transparent
        Me.UcClienteTerceroOrigen.CodCliente = 0.0R
        Me.UcClienteTerceroOrigen.CodigoPlantaCliente = 0.0R
        BePlantaDeEntrega17.PageCount = 0
        BePlantaDeEntrega17.PageNumber = 0
        BePlantaDeEntrega17.PageSize = 0
        BePlantaDeEntrega17.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega17.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega17.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega17.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega17.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega17.PNCUBGEO = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega17.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega17.PSCPLNAF = Nothing
        BePlantaDeEntrega17.PSCPRPCL = Nothing
        BePlantaDeEntrega17.PSSTPORL = Nothing
        BePlantaDeEntrega17.PSTCMPPL = ""
        BePlantaDeEntrega17.PSTDRCPL = ""
        BePlantaDeEntrega17.PSTDRPRC = ""
        BePlantaDeEntrega17.PSTPRVCL = ""
        BePlantaDeEntrega17.PSUBIGEO = ""
        BePlantaDeEntrega17.TIPOCLIENTE = True
        Me.UcClienteTerceroOrigen.InfPlantaDeEntrega = BePlantaDeEntrega17
        BePlantaDeEntrega18.PageCount = 0
        BePlantaDeEntrega18.PageNumber = 0
        BePlantaDeEntrega18.PageSize = 0
        BePlantaDeEntrega18.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega18.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega18.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega18.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega18.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega18.PNCUBGEO = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega18.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega18.PSCPLNAF = Nothing
        BePlantaDeEntrega18.PSCPRPCL = Nothing
        BePlantaDeEntrega18.PSSTPORL = Nothing
        BePlantaDeEntrega18.PSTCMPPL = ""
        BePlantaDeEntrega18.PSTDRCPL = ""
        BePlantaDeEntrega18.PSTDRPRC = ""
        BePlantaDeEntrega18.PSTPRVCL = ""
        BePlantaDeEntrega18.PSUBIGEO = ""
        BePlantaDeEntrega18.TIPOCLIENTE = True
        Me.UcClienteTerceroOrigen.ItemActual = BePlantaDeEntrega18
        Me.UcClienteTerceroOrigen.Location = New System.Drawing.Point(168, 25)
        Me.UcClienteTerceroOrigen.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcClienteTerceroOrigen.MostrarRuc = False
        Me.UcClienteTerceroOrigen.Name = "UcClienteTerceroOrigen"
        Me.UcClienteTerceroOrigen.Ruc = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcClienteTerceroOrigen.Size = New System.Drawing.Size(472, 26)
        Me.UcClienteTerceroOrigen.TabIndex = 3
        Me.UcClienteTerceroOrigen.TipoRelacion = ""
        '
        'UcPlantaDeEntregaOrigen
        '
        Me.UcPlantaDeEntregaOrigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcPlantaDeEntregaOrigen.BackColor = System.Drawing.Color.Transparent
        Me.UcPlantaDeEntregaOrigen.CodCliente = 0.0R
        Me.UcPlantaDeEntregaOrigen.CodClienteTercero = 0.0R
        Me.UcPlantaDeEntregaOrigen.CodigoPlantaCliente = 0.0R
        BePlantaDeEntrega19.PageCount = 0
        BePlantaDeEntrega19.PageNumber = 0
        BePlantaDeEntrega19.PageSize = 0
        BePlantaDeEntrega19.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega19.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega19.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega19.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega19.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega19.PNCUBGEO = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega19.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega19.PSCPLNAF = Nothing
        BePlantaDeEntrega19.PSCPRPCL = Nothing
        BePlantaDeEntrega19.PSSTPORL = Nothing
        BePlantaDeEntrega19.PSTCMPPL = ""
        BePlantaDeEntrega19.PSTDRCPL = ""
        BePlantaDeEntrega19.PSTDRPRC = ""
        BePlantaDeEntrega19.PSTPRVCL = ""
        BePlantaDeEntrega19.PSUBIGEO = ""
        BePlantaDeEntrega19.TIPOCLIENTE = True
        Me.UcPlantaDeEntregaOrigen.InfPlantaDeEntrega = BePlantaDeEntrega19
        BePlantaDeEntrega20.PageCount = 0
        BePlantaDeEntrega20.PageNumber = 0
        BePlantaDeEntrega20.PageSize = 0
        BePlantaDeEntrega20.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega20.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega20.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega20.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega20.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega20.PNCUBGEO = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega20.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega20.PSCPLNAF = Nothing
        BePlantaDeEntrega20.PSCPRPCL = Nothing
        BePlantaDeEntrega20.PSSTPORL = Nothing
        BePlantaDeEntrega20.PSTCMPPL = ""
        BePlantaDeEntrega20.PSTDRCPL = ""
        BePlantaDeEntrega20.PSTDRPRC = ""
        BePlantaDeEntrega20.PSTPRVCL = ""
        BePlantaDeEntrega20.PSUBIGEO = ""
        BePlantaDeEntrega20.TIPOCLIENTE = True
        Me.UcPlantaDeEntregaOrigen.ItemActual = BePlantaDeEntrega20
        Me.UcPlantaDeEntregaOrigen.Lectura = False
        Me.UcPlantaDeEntregaOrigen.Location = New System.Drawing.Point(168, 23)
        Me.UcPlantaDeEntregaOrigen.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcPlantaDeEntregaOrigen.Name = "UcPlantaDeEntregaOrigen"
        Me.UcPlantaDeEntregaOrigen.Size = New System.Drawing.Size(469, 26)
        Me.UcPlantaDeEntregaOrigen.TabIndex = 0
        Me.UcPlantaDeEntregaOrigen.TipoPlantaDeEntrega = False
        '
        'lblPlantaOrigen
        '
        Me.lblPlantaOrigen.Location = New System.Drawing.Point(11, 23)
        Me.lblPlantaOrigen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPlantaOrigen.Name = "lblPlantaOrigen"
        Me.lblPlantaOrigen.Size = New System.Drawing.Size(133, 24)
        Me.lblPlantaOrigen.TabIndex = 1
        Me.lblPlantaOrigen.Text = "Planta de Origen : "
        Me.lblPlantaOrigen.Values.ExtraText = ""
        Me.lblPlantaOrigen.Values.Image = Nothing
        Me.lblPlantaOrigen.Values.Text = "Planta de Origen : "
        '
        'lblClienteOrigen
        '
        Me.lblClienteOrigen.Location = New System.Drawing.Point(28, 21)
        Me.lblClienteOrigen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblClienteOrigen.Name = "lblClienteOrigen"
        Me.lblClienteOrigen.Size = New System.Drawing.Size(117, 24)
        Me.lblClienteOrigen.TabIndex = 2
        Me.lblClienteOrigen.Text = "Cliente Origen : "
        Me.lblClienteOrigen.Values.ExtraText = ""
        Me.lblClienteOrigen.Values.Image = Nothing
        Me.lblClienteOrigen.Values.Text = "Cliente Origen : "
        '
        'cboTipoGR
        '
        Me.cboTipoGR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoGR.FormattingEnabled = True
        Me.cboTipoGR.ItemHeight = 16
        Me.cboTipoGR.Location = New System.Drawing.Point(809, 16)
        Me.cboTipoGR.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTipoGR.Name = "cboTipoGR"
        Me.cboTipoGR.Size = New System.Drawing.Size(172, 24)
        Me.cboTipoGR.TabIndex = 20
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(695, 16)
        Me.KryptonLabel14.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(84, 24)
        Me.KryptonLabel14.TabIndex = 19
        Me.KryptonLabel14.Text = "Tipo Guía : "
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Tipo Guía : "
        '
        'frmGenerarGuiaRemisionSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 661)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenerarGuiaRemisionSDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Guía de Remisión"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpEmpresaTransporte.ResumeLayout(False)
        Me.grpEmpresaTransporte.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabGlosa.ResumeLayout(False)
        Me.TabGlosa.PerformLayout()
        Me.TabObservacion.ResumeLayout(False)
        CType(Me.dtgObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPuntos.ResumeLayout(False)
        Me.grpPuntos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtManChoferes As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtMantCamiones As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNroGuiaInterna As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuiaInterna As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcClienteTerceroOrigen As Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
    Friend WithEvents UcPlantaDeEntregaOrigen As Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnPegar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCopiar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabGlosa As System.Windows.Forms.TabPage
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TabObservacion As System.Windows.Forms.TabPage
    Friend WithEvents dtgObservacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TOBSGS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboTipoGR As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
