<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoTracto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoTracto))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboTipo = New System.Windows.Forms.ComboBox
        Me.lblTipo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigoTipoTracto = New CodeTextBox.CodeTextBox
        Me.txtObsTractoTransportista = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNroRPM = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtNumPlacaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtFechaFabricacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtNumEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNumEmpadMTC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNumChasis = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtSerieMotor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtMarcaModelo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPesoTracto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtColorUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCarroceriaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCapCargaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
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
        Me.KryptonPanel.Size = New System.Drawing.Size(820, 273)
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
        Me.HeaderDatos.Size = New System.Drawing.Size(820, 273)
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
        Me.Panel1.Controls.Add(Me.txtCodigoTipoTracto)
        Me.Panel1.Controls.Add(Me.txtObsTractoTransportista)
        Me.Panel1.Controls.Add(Me.txtNroRPM)
        Me.Panel1.Controls.Add(Me.KryptonBorderEdge2)
        Me.Panel1.Controls.Add(Me.txtNumPlacaUnidad)
        Me.Panel1.Controls.Add(Me.txtFechaFabricacion)
        Me.Panel1.Controls.Add(Me.KryptonBorderEdge1)
        Me.Panel1.Controls.Add(Me.txtNumEjes)
        Me.Panel1.Controls.Add(Me.txtNumEmpadMTC)
        Me.Panel1.Controls.Add(Me.txtNumChasis)
        Me.Panel1.Controls.Add(Me.txtSerieMotor)
        Me.Panel1.Controls.Add(Me.txtMarcaModelo)
        Me.Panel1.Controls.Add(Me.txtPesoTracto)
        Me.Panel1.Controls.Add(Me.txtColorUnidad)
        Me.Panel1.Controls.Add(Me.txtCarroceriaUnidad)
        Me.Panel1.Controls.Add(Me.txtCapCargaUnidad)
        Me.Panel1.Controls.Add(Me.lblObservaciones)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.KryptonLabel16)
        Me.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.Panel1.Controls.Add(Me.KryptonLabel11)
        Me.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.KryptonLabel12)
        Me.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.KryptonLabel17)
        Me.Panel1.Controls.Add(Me.KryptonLabel15)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 219)
        Me.Panel1.TabIndex = 61
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(349, 159)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(153, 21)
        Me.cboTipo.TabIndex = 353
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(245, 160)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(34, 22)
        Me.lblTipo.TabIndex = 352
        Me.lblTipo.Text = "Tipo"
        Me.lblTipo.Values.ExtraText = ""
        Me.lblTipo.Values.Image = Nothing
        Me.lblTipo.Values.Text = "Tipo"
        '
        'txtCodigoTipoTracto
        '
        Me.txtCodigoTipoTracto.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCodigoTipoTracto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtCodigoTipoTracto.Codigo = ""
        Me.txtCodigoTipoTracto.ControlHeight = 23
        Me.txtCodigoTipoTracto.ControlImage = True
        Me.txtCodigoTipoTracto.ControlReadOnly = True
        Me.txtCodigoTipoTracto.Descripcion = ""
        Me.txtCodigoTipoTracto.DisplayColumnVisible = True
        Me.txtCodigoTipoTracto.DisplayMember = ""
        Me.txtCodigoTipoTracto.Enabled = False
        Me.txtCodigoTipoTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoTipoTracto.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoTipoTracto.KeyColumnWidth = 100
        Me.txtCodigoTipoTracto.KeyField = ""
        Me.txtCodigoTipoTracto.KeySearch = False
        Me.txtCodigoTipoTracto.Location = New System.Drawing.Point(350, 100)
        Me.txtCodigoTipoTracto.Name = "txtCodigoTipoTracto"
        Me.txtCodigoTipoTracto.Size = New System.Drawing.Size(153, 23)
        Me.txtCodigoTipoTracto.TabIndex = 351
        Me.txtCodigoTipoTracto.Tag = ""
        Me.txtCodigoTipoTracto.TextBackColor = System.Drawing.Color.White
        Me.txtCodigoTipoTracto.TextForeColor = System.Drawing.Color.Black
        Me.txtCodigoTipoTracto.ValueColumnVisible = True
        Me.txtCodigoTipoTracto.ValueColumnWidth = 600
        Me.txtCodigoTipoTracto.ValueField = ""
        Me.txtCodigoTipoTracto.ValueMember = ""
        Me.txtCodigoTipoTracto.ValueSearch = True
        '
        'txtObsTractoTransportista
        '
        Me.txtObsTractoTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObsTractoTransportista.Location = New System.Drawing.Point(516, 127)
        Me.txtObsTractoTransportista.MaxLength = 250
        Me.txtObsTractoTransportista.Multiline = True
        Me.txtObsTractoTransportista.Name = "txtObsTractoTransportista"
        Me.txtObsTractoTransportista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsTractoTransportista.Size = New System.Drawing.Size(291, 69)
        Me.txtObsTractoTransportista.TabIndex = 13
        Me.txtObsTractoTransportista.Visible = False
        '
        'txtNroRPM
        '
        Me.txtNroRPM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroRPM.Location = New System.Drawing.Point(610, 71)
        Me.txtNroRPM.MaxLength = 15
        Me.txtNroRPM.Name = "txtNroRPM"
        Me.txtNroRPM.Size = New System.Drawing.Size(159, 22)
        Me.txtNroRPM.TabIndex = 12
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(509, 11)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(1, 170)
        Me.KryptonBorderEdge2.TabIndex = 61
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'txtNumPlacaUnidad
        '
        Me.txtNumPlacaUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumPlacaUnidad.Location = New System.Drawing.Point(104, 15)
        Me.txtNumPlacaUnidad.MaxLength = 6
        Me.txtNumPlacaUnidad.Name = "txtNumPlacaUnidad"
        Me.txtNumPlacaUnidad.Size = New System.Drawing.Size(128, 22)
        Me.txtNumPlacaUnidad.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumPlacaUnidad.TabIndex = 0
        '
        'txtFechaFabricacion
        '
        Me.txtFechaFabricacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaFabricacion.Location = New System.Drawing.Point(104, 131)
        Me.txtFechaFabricacion.MaxLength = 4
        Me.txtFechaFabricacion.Name = "txtFechaFabricacion"
        Me.txtFechaFabricacion.Size = New System.Drawing.Size(128, 22)
        Me.txtFechaFabricacion.TabIndex = 4
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(238, 11)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 165)
        Me.KryptonBorderEdge1.TabIndex = 33
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'txtNumEjes
        '
        Me.txtNumEjes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumEjes.Location = New System.Drawing.Point(104, 43)
        Me.txtNumEjes.MaxLength = 2
        Me.txtNumEjes.Name = "txtNumEjes"
        Me.txtNumEjes.Size = New System.Drawing.Size(128, 22)
        Me.txtNumEjes.TabIndex = 1
        '
        'txtNumEmpadMTC
        '
        Me.txtNumEmpadMTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumEmpadMTC.Location = New System.Drawing.Point(610, 43)
        Me.txtNumEmpadMTC.MaxLength = 15
        Me.txtNumEmpadMTC.Name = "txtNumEmpadMTC"
        Me.txtNumEmpadMTC.Size = New System.Drawing.Size(159, 22)
        Me.txtNumEmpadMTC.TabIndex = 11
        '
        'txtNumChasis
        '
        Me.txtNumChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumChasis.Location = New System.Drawing.Point(104, 71)
        Me.txtNumChasis.MaxLength = 30
        Me.txtNumChasis.Name = "txtNumChasis"
        Me.txtNumChasis.Size = New System.Drawing.Size(128, 22)
        Me.txtNumChasis.TabIndex = 2
        '
        'txtSerieMotor
        '
        Me.txtSerieMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieMotor.Location = New System.Drawing.Point(104, 101)
        Me.txtSerieMotor.MaxLength = 30
        Me.txtSerieMotor.Name = "txtSerieMotor"
        Me.txtSerieMotor.Size = New System.Drawing.Size(128, 22)
        Me.txtSerieMotor.TabIndex = 3
        '
        'txtMarcaModelo
        '
        Me.txtMarcaModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaModelo.Location = New System.Drawing.Point(610, 15)
        Me.txtMarcaModelo.MaxLength = 40
        Me.txtMarcaModelo.Name = "txtMarcaModelo"
        Me.txtMarcaModelo.Size = New System.Drawing.Size(159, 22)
        Me.txtMarcaModelo.TabIndex = 10
        '
        'txtPesoTracto
        '
        Me.txtPesoTracto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoTracto.Location = New System.Drawing.Point(349, 131)
        Me.txtPesoTracto.MaxLength = 7
        Me.txtPesoTracto.Name = "txtPesoTracto"
        Me.txtPesoTracto.Size = New System.Drawing.Size(154, 22)
        Me.txtPesoTracto.TabIndex = 9
        '
        'txtColorUnidad
        '
        Me.txtColorUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColorUnidad.Location = New System.Drawing.Point(349, 15)
        Me.txtColorUnidad.MaxLength = 25
        Me.txtColorUnidad.Name = "txtColorUnidad"
        Me.txtColorUnidad.Size = New System.Drawing.Size(153, 22)
        Me.txtColorUnidad.TabIndex = 5
        '
        'txtCarroceriaUnidad
        '
        Me.txtCarroceriaUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarroceriaUnidad.Location = New System.Drawing.Point(350, 43)
        Me.txtCarroceriaUnidad.MaxLength = 10
        Me.txtCarroceriaUnidad.Name = "txtCarroceriaUnidad"
        Me.txtCarroceriaUnidad.Size = New System.Drawing.Size(153, 22)
        Me.txtCarroceriaUnidad.TabIndex = 6
        '
        'txtCapCargaUnidad
        '
        Me.txtCapCargaUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCapCargaUnidad.Location = New System.Drawing.Point(350, 71)
        Me.txtCapCargaUnidad.MaxLength = 8
        Me.txtCapCargaUnidad.Name = "txtCapCargaUnidad"
        Me.txtCapCargaUnidad.Size = New System.Drawing.Size(153, 22)
        Me.txtCapCargaUnidad.TabIndex = 7
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(512, 102)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(90, 22)
        Me.lblObservaciones.TabIndex = 65
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.Values.ExtraText = ""
        Me.lblObservaciones.Values.Image = Nothing
        Me.lblObservaciones.Values.Text = "Observaciones"
        Me.lblObservaciones.Visible = False
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(245, 44)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(109, 22)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Carrocería Unidad"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Carrocería Unidad"
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(245, 18)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(83, 22)
        Me.KryptonLabel16.TabIndex = 25
        Me.KryptonLabel16.Text = "Color Unidad"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Color Unidad"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(245, 102)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(72, 22)
        Me.KryptonLabel9.TabIndex = 23
        Me.KryptonLabel9.Text = "Tipo Tracto"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Tipo Tracto"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(245, 72)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(103, 22)
        Me.KryptonLabel11.TabIndex = 19
        Me.KryptonLabel11.Text = "Capacidad Carga"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Capacidad Carga"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(245, 132)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(74, 22)
        Me.KryptonLabel10.TabIndex = 13
        Me.KryptonLabel10.Text = "Peso Tracto"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Peso Tracto"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(6, 18)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(81, 22)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Placa Unidad"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Placa Unidad"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(6, 72)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(93, 22)
        Me.KryptonLabel5.TabIndex = 9
        Me.KryptonLabel5.Text = "Número Chasis"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Número Chasis"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(6, 102)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(75, 22)
        Me.KryptonLabel6.TabIndex = 11
        Me.KryptonLabel6.Text = "Serie Motor"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Serie Motor"
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(6, 132)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(98, 22)
        Me.KryptonLabel12.TabIndex = 17
        Me.KryptonLabel12.Text = "Año Fabricación"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Año Fabricación"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(6, 44)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(80, 22)
        Me.KryptonLabel8.TabIndex = 15
        Me.KryptonLabel8.Text = "Número Ejes"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Número Ejes"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(512, 72)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(79, 22)
        Me.KryptonLabel4.TabIndex = 62
        Me.KryptonLabel4.Text = "N° Telf. RPM"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "N° Telf. RPM"
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(512, 44)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(84, 22)
        Me.KryptonLabel17.TabIndex = 27
        Me.KryptonLabel17.Text = "Número MTC"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Número MTC"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(512, 18)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(91, 22)
        Me.KryptonLabel15.TabIndex = 5
        Me.KryptonLabel15.Text = "Marca/Modelo"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Marca/Modelo"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnModificar, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar, Me.ToolStripSeparator4, Me.btnSalir})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(818, 29)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 29)
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
        'btnModificar
        '
        Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(84, 26)
        Me.btnModificar.Text = "Modificar"
        '
        'frmNuevoTracto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 273)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmNuevoTracto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nuevo Tracto"
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
    Friend WithEvents txtNroRPM As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents txtNumPlacaUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtFechaFabricacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents txtNumEjes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNumEmpadMTC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNumChasis As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSerieMotor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMarcaModelo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoTracto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtColorUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCarroceriaUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCapCargaUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtObsTractoTransportista As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblObservaciones As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoTipoTracto As CodeTextBox.CodeTextBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
End Class
