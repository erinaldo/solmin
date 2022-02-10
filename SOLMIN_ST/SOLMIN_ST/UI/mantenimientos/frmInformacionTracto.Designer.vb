<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformacionTracto
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformacionTracto))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.HeaderSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.txtNroRPM = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtNumPlacaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtFechaFabricacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigoTipoTracto = New CodeTextBox.CodeTextBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Me.txtNumEjes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtNumEmpadMTC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtNumChasis = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtSerieMotor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtMarcaModelo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtPesoTracto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtColorUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCarroceriaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtCapCargaUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Me.KryptonPanel.Size = New System.Drawing.Size(758, 252)
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
    Me.HeaderSolicitud.Size = New System.Drawing.Size(758, 252)
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
    Me.KryptonGroup1.Size = New System.Drawing.Size(756, 224)
    Me.KryptonGroup1.TabIndex = 9
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.White
    Me.Panel1.Controls.Add(Me.txtNroRPM)
    Me.Panel1.Controls.Add(Me.KryptonLabel4)
    Me.Panel1.Controls.Add(Me.txtNumPlacaUnidad)
    Me.Panel1.Controls.Add(Me.txtFechaFabricacion)
    Me.Panel1.Controls.Add(Me.KryptonLabel1)
    Me.Panel1.Controls.Add(Me.txtCodigoTipoTracto)
    Me.Panel1.Controls.Add(Me.KryptonLabel2)
    Me.Panel1.Controls.Add(Me.KryptonBorderEdge1)
    Me.Panel1.Controls.Add(Me.txtNumEjes)
    Me.Panel1.Controls.Add(Me.KryptonLabel17)
    Me.Panel1.Controls.Add(Me.KryptonLabel15)
    Me.Panel1.Controls.Add(Me.txtNumEmpadMTC)
    Me.Panel1.Controls.Add(Me.txtNumChasis)
    Me.Panel1.Controls.Add(Me.KryptonLabel16)
    Me.Panel1.Controls.Add(Me.txtSerieMotor)
    Me.Panel1.Controls.Add(Me.txtMarcaModelo)
    Me.Panel1.Controls.Add(Me.KryptonLabel5)
    Me.Panel1.Controls.Add(Me.KryptonLabel9)
    Me.Panel1.Controls.Add(Me.KryptonLabel6)
    Me.Panel1.Controls.Add(Me.txtPesoTracto)
    Me.Panel1.Controls.Add(Me.txtColorUnidad)
    Me.Panel1.Controls.Add(Me.KryptonLabel11)
    Me.Panel1.Controls.Add(Me.KryptonLabel10)
    Me.Panel1.Controls.Add(Me.KryptonLabel12)
    Me.Panel1.Controls.Add(Me.txtCarroceriaUnidad)
    Me.Panel1.Controls.Add(Me.txtCapCargaUnidad)
    Me.Panel1.Controls.Add(Me.KryptonLabel8)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(754, 222)
    Me.Panel1.TabIndex = 63
    '
    'txtNroRPM
    '
    Me.txtNroRPM.Enabled = False
    Me.txtNroRPM.Location = New System.Drawing.Point(503, 153)
    Me.txtNroRPM.MaxLength = 15
    Me.txtNroRPM.Name = "txtNroRPM"
    Me.txtNroRPM.Size = New System.Drawing.Size(240, 21)
    Me.txtNroRPM.TabIndex = 65
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(383, 159)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(73, 19)
    Me.KryptonLabel4.TabIndex = 64
    Me.KryptonLabel4.Text = "N° Telf. RPM"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "N° Telf. RPM"
    '
    'txtNumPlacaUnidad
    '
    Me.txtNumPlacaUnidad.Enabled = False
    Me.txtNumPlacaUnidad.Location = New System.Drawing.Point(131, 16)
    Me.txtNumPlacaUnidad.MaxLength = 6
    Me.txtNumPlacaUnidad.Name = "txtNumPlacaUnidad"
    Me.txtNumPlacaUnidad.Size = New System.Drawing.Size(223, 21)
    Me.txtNumPlacaUnidad.TabIndex = 1
    '
    'txtFechaFabricacion
    '
    Me.txtFechaFabricacion.Enabled = False
    Me.txtFechaFabricacion.Location = New System.Drawing.Point(131, 128)
    Me.txtFechaFabricacion.MaxLength = 4
    Me.txtFechaFabricacion.Name = "txtFechaFabricacion"
    Me.txtFechaFabricacion.Size = New System.Drawing.Size(223, 21)
    Me.txtFechaFabricacion.TabIndex = 5
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(11, 20)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(103, 19)
    Me.KryptonLabel1.TabIndex = 1
    Me.KryptonLabel1.Text = "Num Placa Unidad"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Num Placa Unidad"
    '
    'txtCodigoTipoTracto
    '
    Me.txtCodigoTipoTracto.Codigo = ""
    Me.txtCodigoTipoTracto.ControlHeight = 23
    Me.txtCodigoTipoTracto.ControlImage = True
    Me.txtCodigoTipoTracto.ControlReadOnly = True
    Me.txtCodigoTipoTracto.Descripcion = ""
    Me.txtCodigoTipoTracto.DisplayColumnVisible = True
    Me.txtCodigoTipoTracto.DisplayMember = ""
    Me.txtCodigoTipoTracto.Enabled = False
    Me.txtCodigoTipoTracto.KeyColumnWidth = 100
    Me.txtCodigoTipoTracto.KeyField = ""
    Me.txtCodigoTipoTracto.KeySearch = True
    Me.txtCodigoTipoTracto.Location = New System.Drawing.Point(503, 44)
    Me.txtCodigoTipoTracto.Name = "txtCodigoTipoTracto"
    Me.txtCodigoTipoTracto.Size = New System.Drawing.Size(240, 23)
    Me.txtCodigoTipoTracto.TabIndex = 9
    Me.txtCodigoTipoTracto.TextBackColor = System.Drawing.Color.Empty
    Me.txtCodigoTipoTracto.TextForeColor = System.Drawing.Color.Empty
    Me.txtCodigoTipoTracto.ValueColumnVisible = True
    Me.txtCodigoTipoTracto.ValueColumnWidth = 600
    Me.txtCodigoTipoTracto.ValueField = ""
    Me.txtCodigoTipoTracto.ValueMember = ""
    Me.txtCodigoTipoTracto.ValueSearch = True
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(11, 186)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(116, 19)
    Me.KryptonLabel2.TabIndex = 3
    Me.KryptonLabel2.Text = "Carrocería de Unidad"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Carrocería de Unidad"
    '
    'KryptonBorderEdge1
    '
    Me.KryptonBorderEdge1.Location = New System.Drawing.Point(371, 12)
    Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
    Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
    Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 190)
    Me.KryptonBorderEdge1.TabIndex = 33
    Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
    '
    'txtNumEjes
    '
    Me.txtNumEjes.Enabled = False
    Me.txtNumEjes.Location = New System.Drawing.Point(131, 44)
    Me.txtNumEjes.MaxLength = 2
    Me.txtNumEjes.Name = "txtNumEjes"
    Me.txtNumEjes.Size = New System.Drawing.Size(223, 21)
    Me.txtNumEjes.TabIndex = 2
    '
    'KryptonLabel17
    '
    Me.KryptonLabel17.Location = New System.Drawing.Point(383, 132)
    Me.KryptonLabel17.Name = "KryptonLabel17"
    Me.KryptonLabel17.Size = New System.Drawing.Size(78, 19)
    Me.KryptonLabel17.TabIndex = 27
    Me.KryptonLabel17.Text = "Número MTC"
    Me.KryptonLabel17.Values.ExtraText = ""
    Me.KryptonLabel17.Values.Image = Nothing
    Me.KryptonLabel17.Values.Text = "Número MTC"
    '
    'KryptonLabel15
    '
    Me.KryptonLabel15.Location = New System.Drawing.Point(383, 104)
    Me.KryptonLabel15.Name = "KryptonLabel15"
    Me.KryptonLabel15.Size = New System.Drawing.Size(84, 19)
    Me.KryptonLabel15.TabIndex = 5
    Me.KryptonLabel15.Text = "Marca/Modelo"
    Me.KryptonLabel15.Values.ExtraText = ""
    Me.KryptonLabel15.Values.Image = Nothing
    Me.KryptonLabel15.Values.Text = "Marca/Modelo"
    '
    'txtNumEmpadMTC
    '
    Me.txtNumEmpadMTC.Enabled = False
    Me.txtNumEmpadMTC.Location = New System.Drawing.Point(503, 128)
    Me.txtNumEmpadMTC.MaxLength = 15
    Me.txtNumEmpadMTC.Name = "txtNumEmpadMTC"
    Me.txtNumEmpadMTC.Size = New System.Drawing.Size(240, 21)
    Me.txtNumEmpadMTC.TabIndex = 12
    '
    'txtNumChasis
    '
    Me.txtNumChasis.Enabled = False
    Me.txtNumChasis.Location = New System.Drawing.Point(131, 72)
    Me.txtNumChasis.MaxLength = 30
    Me.txtNumChasis.Name = "txtNumChasis"
    Me.txtNumChasis.Size = New System.Drawing.Size(223, 21)
    Me.txtNumChasis.TabIndex = 3
    '
    'KryptonLabel16
    '
    Me.KryptonLabel16.Location = New System.Drawing.Point(11, 160)
    Me.KryptonLabel16.Name = "KryptonLabel16"
    Me.KryptonLabel16.Size = New System.Drawing.Size(104, 19)
    Me.KryptonLabel16.TabIndex = 25
    Me.KryptonLabel16.Text = "Color de la Unidad"
    Me.KryptonLabel16.Values.ExtraText = ""
    Me.KryptonLabel16.Values.Image = Nothing
    Me.KryptonLabel16.Values.Text = "Color de la Unidad"
    '
    'txtSerieMotor
    '
    Me.txtSerieMotor.Enabled = False
    Me.txtSerieMotor.Location = New System.Drawing.Point(131, 100)
    Me.txtSerieMotor.MaxLength = 30
    Me.txtSerieMotor.Name = "txtSerieMotor"
    Me.txtSerieMotor.Size = New System.Drawing.Size(223, 21)
    Me.txtSerieMotor.TabIndex = 4
    '
    'txtMarcaModelo
    '
    Me.txtMarcaModelo.Enabled = False
    Me.txtMarcaModelo.Location = New System.Drawing.Point(503, 100)
    Me.txtMarcaModelo.MaxLength = 40
    Me.txtMarcaModelo.Name = "txtMarcaModelo"
    Me.txtMarcaModelo.Size = New System.Drawing.Size(240, 21)
    Me.txtMarcaModelo.TabIndex = 11
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(11, 76)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(102, 19)
    Me.KryptonLabel5.TabIndex = 9
    Me.KryptonLabel5.Text = "Número de Chasis"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Número de Chasis"
    '
    'KryptonLabel9
    '
    Me.KryptonLabel9.Location = New System.Drawing.Point(383, 47)
    Me.KryptonLabel9.Name = "KryptonLabel9"
    Me.KryptonLabel9.Size = New System.Drawing.Size(106, 19)
    Me.KryptonLabel9.TabIndex = 23
    Me.KryptonLabel9.Text = "Código Tipo Tracto"
    Me.KryptonLabel9.Values.ExtraText = ""
    Me.KryptonLabel9.Values.Image = Nothing
    Me.KryptonLabel9.Values.Text = "Código Tipo Tracto"
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(11, 104)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(85, 19)
    Me.KryptonLabel6.TabIndex = 11
    Me.KryptonLabel6.Text = "Serie de Motor"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Serie de Motor"
    '
    'txtPesoTracto
    '
    Me.txtPesoTracto.Enabled = False
    Me.txtPesoTracto.Location = New System.Drawing.Point(503, 72)
    Me.txtPesoTracto.MaxLength = 7
    Me.txtPesoTracto.Name = "txtPesoTracto"
    Me.txtPesoTracto.Size = New System.Drawing.Size(240, 21)
    Me.txtPesoTracto.TabIndex = 10
    '
    'txtColorUnidad
    '
    Me.txtColorUnidad.Enabled = False
    Me.txtColorUnidad.Location = New System.Drawing.Point(131, 156)
    Me.txtColorUnidad.MaxLength = 25
    Me.txtColorUnidad.Name = "txtColorUnidad"
    Me.txtColorUnidad.Size = New System.Drawing.Size(223, 21)
    Me.txtColorUnidad.TabIndex = 6
    '
    'KryptonLabel11
    '
    Me.KryptonLabel11.Location = New System.Drawing.Point(383, 19)
    Me.KryptonLabel11.Name = "KryptonLabel11"
    Me.KryptonLabel11.Size = New System.Drawing.Size(110, 19)
    Me.KryptonLabel11.TabIndex = 19
    Me.KryptonLabel11.Text = "Capacidad de Carga"
    Me.KryptonLabel11.Values.ExtraText = ""
    Me.KryptonLabel11.Values.Image = Nothing
    Me.KryptonLabel11.Values.Text = "Capacidad de Carga"
    '
    'KryptonLabel10
    '
    Me.KryptonLabel10.Location = New System.Drawing.Point(383, 76)
    Me.KryptonLabel10.Name = "KryptonLabel10"
    Me.KryptonLabel10.Size = New System.Drawing.Size(84, 19)
    Me.KryptonLabel10.TabIndex = 13
    Me.KryptonLabel10.Text = "Peso de Tracto"
    Me.KryptonLabel10.Values.ExtraText = ""
    Me.KryptonLabel10.Values.Image = Nothing
    Me.KryptonLabel10.Values.Text = "Peso de Tracto"
    '
    'KryptonLabel12
    '
    Me.KryptonLabel12.Location = New System.Drawing.Point(11, 132)
    Me.KryptonLabel12.Name = "KryptonLabel12"
    Me.KryptonLabel12.Size = New System.Drawing.Size(106, 19)
    Me.KryptonLabel12.TabIndex = 17
    Me.KryptonLabel12.Text = "Año de Fabricación"
    Me.KryptonLabel12.Values.ExtraText = ""
    Me.KryptonLabel12.Values.Image = Nothing
    Me.KryptonLabel12.Values.Text = "Año de Fabricación"
    '
    'txtCarroceriaUnidad
    '
    Me.txtCarroceriaUnidad.Enabled = False
    Me.txtCarroceriaUnidad.Location = New System.Drawing.Point(131, 182)
    Me.txtCarroceriaUnidad.MaxLength = 10
    Me.txtCarroceriaUnidad.Name = "txtCarroceriaUnidad"
    Me.txtCarroceriaUnidad.Size = New System.Drawing.Size(223, 21)
    Me.txtCarroceriaUnidad.TabIndex = 7
    '
    'txtCapCargaUnidad
    '
    Me.txtCapCargaUnidad.Enabled = False
    Me.txtCapCargaUnidad.Location = New System.Drawing.Point(503, 16)
    Me.txtCapCargaUnidad.MaxLength = 8
    Me.txtCapCargaUnidad.Name = "txtCapCargaUnidad"
    Me.txtCapCargaUnidad.Size = New System.Drawing.Size(240, 21)
    Me.txtCapCargaUnidad.TabIndex = 8
    '
    'KryptonLabel8
    '
    Me.KryptonLabel8.Location = New System.Drawing.Point(11, 48)
    Me.KryptonLabel8.Name = "KryptonLabel8"
    Me.KryptonLabel8.Size = New System.Drawing.Size(89, 19)
    Me.KryptonLabel8.TabIndex = 15
    Me.KryptonLabel8.Text = "Número de Ejes"
    Me.KryptonLabel8.Values.ExtraText = ""
    Me.KryptonLabel8.Values.Image = Nothing
    Me.KryptonLabel8.Values.Text = "Número de Ejes"
    '
    'frmInformacionTracto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(758, 252)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmInformacionTracto"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Información de Tracto"
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

    Public Sub New(ByVal lp_NPLCUN As String)
        If lp_NPLCUN = "" Then Exit Sub

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        vNPLCUN = lp_NPLCUN.Trim
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNumPlacaUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtFechaFabricacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoTipoTracto As CodeTextBox.CodeTextBox
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
    Friend WithEvents HeaderSolicitud As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents txtNroRPM As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
