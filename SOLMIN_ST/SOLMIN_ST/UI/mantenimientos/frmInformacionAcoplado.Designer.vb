<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformacionAcoplado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformacionAcoplado))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HeaderSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtAnchoAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cboTipoAcoplado = New CodeTextBox.CodeTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtColorUnidad = New SOLMIN_ST.TextField
        Me.txtPlacaAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCapacidadCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtConfiguracionEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroChasis = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNumeroMTC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPesoTara = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAltoAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNroEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMarcaVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtLongitudAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HeaderSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderSolicitud.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderSolicitud.Panel.SuspendLayout()
        Me.HeaderSolicitud.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HeaderSolicitud)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(679, 220)
        Me.KryptonPanel.TabIndex = 0
        '
        'HeaderSolicitud
        '
        Me.HeaderSolicitud.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnSalir})
        Me.HeaderSolicitud.CollapseTarget = ComponentFactory.Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToBoth
        Me.HeaderSolicitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderSolicitud.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderSolicitud.HeaderVisibleSecondary = False
        Me.HeaderSolicitud.Location = New System.Drawing.Point(0, 0)
        Me.HeaderSolicitud.Name = "HeaderSolicitud"
        '
        'HeaderSolicitud.Panel
        '
        Me.HeaderSolicitud.Panel.Controls.Add(Me.KryptonGroup1)
        Me.HeaderSolicitud.Size = New System.Drawing.Size(679, 220)
        Me.HeaderSolicitud.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form
        Me.HeaderSolicitud.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.HeaderSolicitud.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.HeaderSolicitud.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.HeaderSolicitud.TabIndex = 107
        Me.HeaderSolicitud.ValuesPrimary.Description = ""
        Me.HeaderSolicitud.ValuesPrimary.Heading = ""
        Me.HeaderSolicitud.ValuesPrimary.Image = Nothing
        Me.HeaderSolicitud.ValuesSecondary.Description = ""
        Me.HeaderSolicitud.ValuesSecondary.Heading = ""
        Me.HeaderSolicitud.ValuesSecondary.Image = Nothing
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipBody = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "27D941CF936C4FCB27D941CF936C4FCB"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.Panel1)
        Me.KryptonGroup1.Size = New System.Drawing.Size(677, 193)
        Me.KryptonGroup1.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtAnchoAcoplado)
        Me.Panel1.Controls.Add(Me.cboTipoAcoplado)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.txtColorUnidad)
        Me.Panel1.Controls.Add(Me.txtPlacaAcoplado)
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.KryptonBorderEdge1)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.KryptonLabel13)
        Me.Panel1.Controls.Add(Me.txtCapacidadCarga)
        Me.Panel1.Controls.Add(Me.txtConfiguracionEjes)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.KryptonLabel14)
        Me.Panel1.Controls.Add(Me.txtNroChasis)
        Me.Panel1.Controls.Add(Me.txtNumeroMTC)
        Me.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.Panel1.Controls.Add(Me.KryptonLabel15)
        Me.Panel1.Controls.Add(Me.txtPesoTara)
        Me.Panel1.Controls.Add(Me.KryptonLabel16)
        Me.Panel1.Controls.Add(Me.KryptonLabel8)
        Me.Panel1.Controls.Add(Me.txtAltoAcoplado)
        Me.Panel1.Controls.Add(Me.txtNroEjes)
        Me.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.Panel1.Controls.Add(Me.txtMarcaVehiculo)
        Me.Panel1.Controls.Add(Me.KryptonLabel11)
        Me.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.Panel1.Controls.Add(Me.txtLongitudAcoplado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 191)
        Me.Panel1.TabIndex = 37
        '
        'txtAnchoAcoplado
        '
        Me.txtAnchoAcoplado.Enabled = False
        Me.txtAnchoAcoplado.Location = New System.Drawing.Point(444, 15)
        Me.txtAnchoAcoplado.MaxLength = 7
        Me.txtAnchoAcoplado.Name = "txtAnchoAcoplado"
        Me.txtAnchoAcoplado.Size = New System.Drawing.Size(188, 19)
        Me.txtAnchoAcoplado.TabIndex = 9
        '
        'cboTipoAcoplado
        '
        Me.cboTipoAcoplado.Codigo = ""
        Me.cboTipoAcoplado.ControlHeight = 23
        Me.cboTipoAcoplado.ControlImage = True
        Me.cboTipoAcoplado.ControlReadOnly = True
        Me.cboTipoAcoplado.Descripcion = ""
        Me.cboTipoAcoplado.DisplayColumnVisible = True
        Me.cboTipoAcoplado.DisplayMember = ""
        Me.cboTipoAcoplado.Enabled = False
        Me.cboTipoAcoplado.KeyColumnWidth = 100
        Me.cboTipoAcoplado.KeyField = ""
        Me.cboTipoAcoplado.KeySearch = True
        Me.cboTipoAcoplado.Location = New System.Drawing.Point(444, 62)
        Me.cboTipoAcoplado.Name = "cboTipoAcoplado"
        Me.cboTipoAcoplado.Size = New System.Drawing.Size(188, 23)
        Me.cboTipoAcoplado.TabIndex = 11
        Me.cboTipoAcoplado.TextBackColor = System.Drawing.Color.Empty
        Me.cboTipoAcoplado.TextForeColor = System.Drawing.Color.Empty
        Me.cboTipoAcoplado.ValueColumnVisible = True
        Me.cboTipoAcoplado.ValueColumnWidth = 600
        Me.cboTipoAcoplado.ValueField = ""
        Me.cboTipoAcoplado.ValueMember = ""
        Me.cboTipoAcoplado.ValueSearch = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(16, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(89, 16)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Placa Acoplado"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Placa Acoplado"
        '
        'txtColorUnidad
        '
        Me.txtColorUnidad.Enabled = False
        Me.txtColorUnidad.Location = New System.Drawing.Point(128, 39)
        Me.txtColorUnidad.MaxLength = 25
        Me.txtColorUnidad.Name = "txtColorUnidad"
        Me.txtColorUnidad.Size = New System.Drawing.Size(188, 19)
        Me.txtColorUnidad.TabIndex = 3
        Me.txtColorUnidad.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtPlacaAcoplado
        '
        Me.txtPlacaAcoplado.Enabled = False
        Me.txtPlacaAcoplado.Location = New System.Drawing.Point(128, 15)
        Me.txtPlacaAcoplado.MaxLength = 6
        Me.txtPlacaAcoplado.Name = "txtPlacaAcoplado"
        Me.txtPlacaAcoplado.Size = New System.Drawing.Size(188, 19)
        Me.txtPlacaAcoplado.TabIndex = 2
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(340, 138)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(104, 16)
        Me.KryptonLabel4.TabIndex = 34
        Me.KryptonLabel4.Text = "Marca de Vehículo"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Marca de Vehículo"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(16, 40)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(90, 16)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Text = "Color de unidad"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Color de unidad"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(332, 11)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 180)
        Me.KryptonBorderEdge1.TabIndex = 33
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(16, 115)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(111, 16)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Text = "Capacidad de carga"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Capacidad de carga"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(484, 187)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(6, 2)
        Me.KryptonLabel13.TabIndex = 31
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = ""
        '
        'txtCapacidadCarga
        '
        Me.txtCapacidadCarga.Enabled = False
        Me.txtCapacidadCarga.Location = New System.Drawing.Point(128, 114)
        Me.txtCapacidadCarga.MaxLength = 8
        Me.txtCapacidadCarga.Name = "txtCapacidadCarga"
        Me.txtCapacidadCarga.Size = New System.Drawing.Size(188, 19)
        Me.txtCapacidadCarga.TabIndex = 6
        '
        'txtConfiguracionEjes
        '
        Me.txtConfiguracionEjes.Enabled = False
        Me.txtConfiguracionEjes.Location = New System.Drawing.Point(444, 114)
        Me.txtConfiguracionEjes.MaxLength = 3
        Me.txtConfiguracionEjes.Name = "txtConfiguracionEjes"
        Me.txtConfiguracionEjes.Size = New System.Drawing.Size(188, 19)
        Me.txtConfiguracionEjes.TabIndex = 13
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(16, 138)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(104, 16)
        Me.KryptonLabel5.TabIndex = 9
        Me.KryptonLabel5.Text = "Numero de Chasis"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Numero de Chasis"
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(340, 115)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(105, 16)
        Me.KryptonLabel14.TabIndex = 29
        Me.KryptonLabel14.Text = "Configuracion Ejes"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Configuracion Ejes"
        '
        'txtNroChasis
        '
        Me.txtNroChasis.Enabled = False
        Me.txtNroChasis.Location = New System.Drawing.Point(128, 137)
        Me.txtNroChasis.MaxLength = 30
        Me.txtNroChasis.Name = "txtNroChasis"
        Me.txtNroChasis.Size = New System.Drawing.Size(188, 19)
        Me.txtNroChasis.TabIndex = 7
        '
        'txtNumeroMTC
        '
        Me.txtNumeroMTC.Enabled = False
        Me.txtNumeroMTC.Location = New System.Drawing.Point(444, 90)
        Me.txtNumeroMTC.MaxLength = 15
        Me.txtNumeroMTC.Name = "txtNumeroMTC"
        Me.txtNumeroMTC.Size = New System.Drawing.Size(188, 19)
        Me.txtNumeroMTC.TabIndex = 12
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(16, 64)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(78, 16)
        Me.KryptonLabel7.TabIndex = 13
        Me.KryptonLabel7.Text = "Peso de Tara"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Peso de Tara"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(340, 91)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(94, 16)
        Me.KryptonLabel15.TabIndex = 27
        Me.KryptonLabel15.Text = "Numero de MTC"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Numero de MTC"
        '
        'txtPesoTara
        '
        Me.txtPesoTara.Enabled = False
        Me.txtPesoTara.Location = New System.Drawing.Point(128, 63)
        Me.txtPesoTara.MaxLength = 7
        Me.txtPesoTara.Name = "txtPesoTara"
        Me.txtPesoTara.Size = New System.Drawing.Size(188, 19)
        Me.txtPesoTara.TabIndex = 4
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(340, 64)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(98, 16)
        Me.KryptonLabel16.TabIndex = 25
        Me.KryptonLabel16.Text = "Tipo de Acoplado"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Tipo de Acoplado"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(16, 91)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(91, 16)
        Me.KryptonLabel8.TabIndex = 15
        Me.KryptonLabel8.Text = "Numero de Ejes"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Numero de Ejes"
        '
        'txtAltoAcoplado
        '
        Me.txtAltoAcoplado.Enabled = False
        Me.txtAltoAcoplado.Location = New System.Drawing.Point(444, 39)
        Me.txtAltoAcoplado.MaxLength = 7
        Me.txtAltoAcoplado.Name = "txtAltoAcoplado"
        Me.txtAltoAcoplado.Size = New System.Drawing.Size(188, 19)
        Me.txtAltoAcoplado.TabIndex = 10
        '
        'txtNroEjes
        '
        Me.txtNroEjes.Enabled = False
        Me.txtNroEjes.Location = New System.Drawing.Point(128, 90)
        Me.txtNroEjes.MaxLength = 2
        Me.txtNroEjes.Name = "txtNroEjes"
        Me.txtNroEjes.Size = New System.Drawing.Size(188, 19)
        Me.txtNroEjes.TabIndex = 5
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(340, 40)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(80, 16)
        Me.KryptonLabel9.TabIndex = 23
        Me.KryptonLabel9.Text = "Alto Acoplado"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Alto Acoplado"
        '
        'txtMarcaVehiculo
        '
        Me.txtMarcaVehiculo.Enabled = False
        Me.txtMarcaVehiculo.Location = New System.Drawing.Point(444, 137)
        Me.txtMarcaVehiculo.MaxLength = 30
        Me.txtMarcaVehiculo.Name = "txtMarcaVehiculo"
        Me.txtMarcaVehiculo.Size = New System.Drawing.Size(188, 19)
        Me.txtMarcaVehiculo.TabIndex = 14
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(16, 162)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(104, 16)
        Me.KryptonLabel11.TabIndex = 19
        Me.KryptonLabel11.Text = "Longitud Acoplado"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Longitud Acoplado"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(340, 16)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(93, 16)
        Me.KryptonLabel10.TabIndex = 21
        Me.KryptonLabel10.Text = "Ancho Acoplado"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Ancho Acoplado"
        '
        'txtLongitudAcoplado
        '
        Me.txtLongitudAcoplado.Enabled = False
        Me.txtLongitudAcoplado.Location = New System.Drawing.Point(128, 161)
        Me.txtLongitudAcoplado.MaxLength = 7
        Me.txtLongitudAcoplado.Name = "txtLongitudAcoplado"
        Me.txtLongitudAcoplado.Size = New System.Drawing.Size(188, 19)
        Me.txtLongitudAcoplado.TabIndex = 8
        '
        'frmInformacionAcoplado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInformacionAcoplado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Información de Acoplado"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HeaderSolicitud.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderSolicitud.Panel.ResumeLayout(False)
        CType(Me.HeaderSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderSolicitud.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New(ByVal lp_NPLCAC As String)
        If lp_NPLCAC = "" Then Exit Sub
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        vNPLCAC = lp_NPLCAC.Trim
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAnchoAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cboTipoAcoplado As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtColorUnidad As SOLMIN_ST.TextField
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
    Friend WithEvents HeaderSolicitud As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
End Class
