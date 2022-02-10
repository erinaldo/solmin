<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoAcoplado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoAcoplado))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboTipo = New System.Windows.Forms.ComboBox
        Me.lblTipo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.cboTipoAcoplado = New CodeTextBox.CodeTextBox
        Me.txtObsAcopladoTransportista = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtAnchoAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPlacaAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCapacidadCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtConfiguracionEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroChasis = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNumeroMTC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtColorUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPesoTara = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAltoAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNroEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtMarcaVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtLongitudAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HeaderDatos)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(884, 261)
        Me.KryptonPanel.TabIndex = 0
        '
        'HeaderDatos
        '
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 0)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.Panel1)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(884, 261)
        Me.HeaderDatos.TabIndex = 1
        Me.HeaderDatos.Text = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cboTipo)
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.KryptonBorderEdge2)
        Me.Panel1.Controls.Add(Me.cboTipoAcoplado)
        Me.Panel1.Controls.Add(Me.txtObsAcopladoTransportista)
        Me.Panel1.Controls.Add(Me.txtAnchoAcoplado)
        Me.Panel1.Controls.Add(Me.txtPlacaAcoplado)
        Me.Panel1.Controls.Add(Me.lblObservaciones)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.KryptonBorderEdge1)
        Me.Panel1.Controls.Add(Me.KryptonLabel13)
        Me.Panel1.Controls.Add(Me.txtCapacidadCarga)
        Me.Panel1.Controls.Add(Me.txtConfiguracionEjes)
        Me.Panel1.Controls.Add(Me.KryptonLabel14)
        Me.Panel1.Controls.Add(Me.txtNroChasis)
        Me.Panel1.Controls.Add(Me.txtNumeroMTC)
        Me.Panel1.Controls.Add(Me.KryptonLabel15)
        Me.Panel1.Controls.Add(Me.txtColorUnidad)
        Me.Panel1.Controls.Add(Me.txtPesoTara)
        Me.Panel1.Controls.Add(Me.KryptonLabel16)
        Me.Panel1.Controls.Add(Me.txtAltoAcoplado)
        Me.Panel1.Controls.Add(Me.txtNroEjes)
        Me.Panel1.Controls.Add(Me.txtMarcaVehiculo)
        Me.Panel1.Controls.Add(Me.txtLongitudAcoplado)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.Panel1.Controls.Add(Me.KryptonLabel11)
        Me.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 207)
        Me.Panel1.TabIndex = 35
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(373, 162)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(146, 21)
        Me.cboTipo.TabIndex = 355
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(248, 161)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(34, 22)
        Me.lblTipo.TabIndex = 354
        Me.lblTipo.Text = "Tipo"
        Me.lblTipo.Values.ExtraText = ""
        Me.lblTipo.Values.Image = Nothing
        Me.lblTipo.Values.Text = "Tipo"
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(529, 10)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(1, 170)
        Me.KryptonBorderEdge2.TabIndex = 36
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'cboTipoAcoplado
        '
        Me.cboTipoAcoplado.Codigo = ""
        Me.cboTipoAcoplado.ControlHeight = 23
        Me.cboTipoAcoplado.ControlImage = True
        Me.cboTipoAcoplado.ControlReadOnly = False
        Me.cboTipoAcoplado.Descripcion = ""
        Me.cboTipoAcoplado.DisplayColumnVisible = True
        Me.cboTipoAcoplado.DisplayMember = ""
        Me.cboTipoAcoplado.KeyColumnWidth = 100
        Me.cboTipoAcoplado.KeyField = ""
        Me.cboTipoAcoplado.KeySearch = True
        Me.cboTipoAcoplado.Location = New System.Drawing.Point(373, 131)
        Me.cboTipoAcoplado.Name = "cboTipoAcoplado"
        Me.cboTipoAcoplado.Size = New System.Drawing.Size(146, 23)
        Me.cboTipoAcoplado.TabIndex = 9
        Me.cboTipoAcoplado.TextBackColor = System.Drawing.Color.Empty
        Me.cboTipoAcoplado.TextForeColor = System.Drawing.Color.Empty
        Me.cboTipoAcoplado.ValueColumnVisible = True
        Me.cboTipoAcoplado.ValueColumnWidth = 600
        Me.cboTipoAcoplado.ValueField = ""
        Me.cboTipoAcoplado.ValueMember = ""
        Me.cboTipoAcoplado.ValueSearch = True
        '
        'txtObsAcopladoTransportista
        '
        Me.txtObsAcopladoTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObsAcopladoTransportista.Location = New System.Drawing.Point(540, 126)
        Me.txtObsAcopladoTransportista.MaxLength = 250
        Me.txtObsAcopladoTransportista.Multiline = True
        Me.txtObsAcopladoTransportista.Name = "txtObsAcopladoTransportista"
        Me.txtObsAcopladoTransportista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsAcopladoTransportista.Size = New System.Drawing.Size(274, 70)
        Me.txtObsAcopladoTransportista.TabIndex = 13
        Me.txtObsAcopladoTransportista.Visible = False
        '
        'txtAnchoAcoplado
        '
        Me.txtAnchoAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAnchoAcoplado.Location = New System.Drawing.Point(373, 72)
        Me.txtAnchoAcoplado.MaxLength = 7
        Me.txtAnchoAcoplado.Name = "txtAnchoAcoplado"
        Me.txtAnchoAcoplado.Size = New System.Drawing.Size(146, 22)
        Me.txtAnchoAcoplado.TabIndex = 7
        '
        'txtPlacaAcoplado
        '
        Me.txtPlacaAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaAcoplado.Location = New System.Drawing.Point(112, 14)
        Me.txtPlacaAcoplado.MaxLength = 6
        Me.txtPlacaAcoplado.Name = "txtPlacaAcoplado"
        Me.txtPlacaAcoplado.Size = New System.Drawing.Size(115, 22)
        Me.txtPlacaAcoplado.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPlacaAcoplado.TabIndex = 0
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(540, 102)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(90, 22)
        Me.lblObservaciones.TabIndex = 34
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.Values.ExtraText = ""
        Me.lblObservaciones.Values.Image = Nothing
        Me.lblObservaciones.Values.Text = "Observaciones"
        Me.lblObservaciones.Visible = False
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(540, 15)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(98, 22)
        Me.KryptonLabel4.TabIndex = 34
        Me.KryptonLabel4.Text = "Marca / Modelo"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Marca / Modelo"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(241, 11)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 170)
        Me.KryptonBorderEdge1.TabIndex = 33
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(509, 187)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(6, 4)
        Me.KryptonLabel13.TabIndex = 14
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = ""
        '
        'txtCapacidadCarga
        '
        Me.txtCapacidadCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCapacidadCarga.Location = New System.Drawing.Point(112, 101)
        Me.txtCapacidadCarga.MaxLength = 8
        Me.txtCapacidadCarga.Name = "txtCapacidadCarga"
        Me.txtCapacidadCarga.Size = New System.Drawing.Size(115, 22)
        Me.txtCapacidadCarga.TabIndex = 3
        '
        'txtConfiguracionEjes
        '
        Me.txtConfiguracionEjes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfiguracionEjes.Location = New System.Drawing.Point(651, 72)
        Me.txtConfiguracionEjes.MaxLength = 3
        Me.txtConfiguracionEjes.Name = "txtConfiguracionEjes"
        Me.txtConfiguracionEjes.Size = New System.Drawing.Size(163, 22)
        Me.txtConfiguracionEjes.TabIndex = 12
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(540, 73)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(111, 22)
        Me.KryptonLabel14.TabIndex = 29
        Me.KryptonLabel14.Text = "Configuración Ejes"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Configuración Ejes"
        '
        'txtNroChasis
        '
        Me.txtNroChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroChasis.Location = New System.Drawing.Point(112, 72)
        Me.txtNroChasis.MaxLength = 30
        Me.txtNroChasis.Name = "txtNroChasis"
        Me.txtNroChasis.Size = New System.Drawing.Size(115, 22)
        Me.txtNroChasis.TabIndex = 2
        '
        'txtNumeroMTC
        '
        Me.txtNumeroMTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroMTC.Location = New System.Drawing.Point(651, 44)
        Me.txtNumeroMTC.MaxLength = 15
        Me.txtNumeroMTC.Name = "txtNumeroMTC"
        Me.txtNumeroMTC.Size = New System.Drawing.Size(163, 22)
        Me.txtNumeroMTC.TabIndex = 11
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(540, 45)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(101, 22)
        Me.KryptonLabel15.TabIndex = 27
        Me.KryptonLabel15.Text = "Numero de MTC"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Numero de MTC"
        '
        'txtColorUnidad
        '
        Me.txtColorUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColorUnidad.Location = New System.Drawing.Point(373, 14)
        Me.txtColorUnidad.MaxLength = 7
        Me.txtColorUnidad.Name = "txtColorUnidad"
        Me.txtColorUnidad.Size = New System.Drawing.Size(146, 22)
        Me.txtColorUnidad.TabIndex = 5
        '
        'txtPesoTara
        '
        Me.txtPesoTara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoTara.Location = New System.Drawing.Point(112, 132)
        Me.txtPesoTara.MaxLength = 7
        Me.txtPesoTara.Name = "txtPesoTara"
        Me.txtPesoTara.Size = New System.Drawing.Size(115, 22)
        Me.txtPesoTara.TabIndex = 4
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(248, 133)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(90, 22)
        Me.KryptonLabel16.TabIndex = 25
        Me.KryptonLabel16.Text = "Tipo Acoplado"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Tipo Acoplado"
        '
        'txtAltoAcoplado
        '
        Me.txtAltoAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAltoAcoplado.Location = New System.Drawing.Point(373, 101)
        Me.txtAltoAcoplado.MaxLength = 7
        Me.txtAltoAcoplado.Name = "txtAltoAcoplado"
        Me.txtAltoAcoplado.Size = New System.Drawing.Size(146, 22)
        Me.txtAltoAcoplado.TabIndex = 8
        '
        'txtNroEjes
        '
        Me.txtNroEjes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroEjes.Location = New System.Drawing.Point(112, 44)
        Me.txtNroEjes.MaxLength = 2
        Me.txtNroEjes.Name = "txtNroEjes"
        Me.txtNroEjes.Size = New System.Drawing.Size(115, 22)
        Me.txtNroEjes.TabIndex = 1
        '
        'txtMarcaVehiculo
        '
        Me.txtMarcaVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaVehiculo.Location = New System.Drawing.Point(651, 14)
        Me.txtMarcaVehiculo.MaxLength = 30
        Me.txtMarcaVehiculo.Name = "txtMarcaVehiculo"
        Me.txtMarcaVehiculo.Size = New System.Drawing.Size(163, 22)
        Me.txtMarcaVehiculo.TabIndex = 10
        '
        'txtLongitudAcoplado
        '
        Me.txtLongitudAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLongitudAcoplado.Location = New System.Drawing.Point(373, 44)
        Me.txtLongitudAcoplado.MaxLength = 7
        Me.txtLongitudAcoplado.Name = "txtLongitudAcoplado"
        Me.txtLongitudAcoplado.Size = New System.Drawing.Size(146, 22)
        Me.txtLongitudAcoplado.TabIndex = 6
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(248, 15)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(83, 22)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Color Unidad"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Color Unidad"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(248, 102)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(88, 22)
        Me.KryptonLabel9.TabIndex = 23
        Me.KryptonLabel9.Text = "Alto Acoplado"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Alto Acoplado"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(248, 45)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(115, 22)
        Me.KryptonLabel11.TabIndex = 19
        Me.KryptonLabel11.Text = "Longitud Acoplado"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Longitud Acoplado"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(248, 73)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(101, 22)
        Me.KryptonLabel10.TabIndex = 21
        Me.KryptonLabel10.Text = "Ancho Acoplado"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Ancho Acoplado"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(94, 22)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Placa Acoplado"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Placa Acoplado"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(5, 102)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(103, 22)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Text = "Capacidad Carga"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Capacidad Carga"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(5, 73)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(93, 22)
        Me.KryptonLabel5.TabIndex = 9
        Me.KryptonLabel5.Text = "Numero Chasis"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Numero Chasis"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(5, 133)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(63, 22)
        Me.KryptonLabel7.TabIndex = 13
        Me.KryptonLabel7.Text = "Peso Tara"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Peso Tara"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(5, 45)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(80, 22)
        Me.KryptonLabel8.TabIndex = 15
        Me.KryptonLabel8.Text = "Numero Ejes"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Numero Ejes"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnModificar, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar, Me.btnSalir})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(882, 29)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(68, 26)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(84, 26)
        Me.btnModificar.Text = "Modificar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 26)
        Me.btnGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(79, 26)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(76, 26)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(55, 26)
        Me.btnSalir.Text = "Salir"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'frmNuevoAcoplado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 261)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmNuevoAcoplado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nuevo  Acoplado"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager



    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAnchoAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlacaAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCapacidadCarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtConfiguracionEjes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroChasis As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNumeroMTC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoTara As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAltoAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroEjes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMarcaVehiculo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtLongitudAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtColorUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtObsAcopladoTransportista As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblObservaciones As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cboTipoAcoplado As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
End Class
