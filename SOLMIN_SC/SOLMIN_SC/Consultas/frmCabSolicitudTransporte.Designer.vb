<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCabSolicitudTransporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCabSolicitudTransporte))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.TabSolicitudFlete = New System.Windows.Forms.TabControl
        Me.tbInformacionGeneral = New System.Windows.Forms.TabPage
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFinCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtFechaInicioCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtsFechaSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDireccionLocalidadEntrega = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtLocalidadDestino = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDireccionLocalidadCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtLocalidadOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtMedioTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTipoSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtMercaderias = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCantidadMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtUnidadMedida = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTipoServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTipoVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCentroCostoCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCantidadSolicitada = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtHoraEntrega = New System.Windows.Forms.MaskedTextBox
        Me.txtHoraCarga = New System.Windows.Forms.MaskedTextBox
        Me.KryptonBorderEdge4 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel37 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel31 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabSolicitudFlete.SuspendLayout()
        Me.tbInformacionGeneral.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.TabSolicitudFlete)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(879, 403)
        Me.KryptonPanel.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(879, 25)
        Me.ToolStrip1.TabIndex = 204
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TabSolicitudFlete
        '
        Me.TabSolicitudFlete.Controls.Add(Me.tbInformacionGeneral)
        Me.TabSolicitudFlete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabSolicitudFlete.Location = New System.Drawing.Point(0, 25)
        Me.TabSolicitudFlete.Name = "TabSolicitudFlete"
        Me.TabSolicitudFlete.SelectedIndex = 0
        Me.TabSolicitudFlete.Size = New System.Drawing.Size(879, 378)
        Me.TabSolicitudFlete.TabIndex = 205
        '
        'tbInformacionGeneral
        '
        Me.tbInformacionGeneral.Controls.Add(Me.KryptonHeaderGroup1)
        Me.tbInformacionGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tbInformacionGeneral.Name = "tbInformacionGeneral"
        Me.tbInformacionGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tbInformacionGeneral.Size = New System.Drawing.Size(871, 352)
        Me.tbInformacionGeneral.TabIndex = 0
        Me.tbInformacionGeneral.Text = "Información"
        Me.tbInformacionGeneral.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtOrdenServicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel15)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNroSolicitud)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFinCarga)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFechaInicioCarga)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtsFechaSolicitud)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDireccionLocalidadEntrega)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtLocalidadDestino)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDireccionLocalidadCarga)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtLocalidadOrigen)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtMedioTransporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTipoSolicitud)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtMercaderias)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCantidadMercaderia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtUnidadMedida)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTipoServicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTipoVehiculo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCentroCostoCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCantidadSolicitada)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtObservaciones)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel25)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtHoraEntrega)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtHoraCarga)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel13)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel37)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel22)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel16)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel30)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel31)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel20)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel23)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel12)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(865, 346)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Información de Solicitud de Flete"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'txtOrdenServicio
        '
        Me.txtOrdenServicio.AcceptsReturn = True
        Me.txtOrdenServicio.Location = New System.Drawing.Point(282, 9)
        Me.txtOrdenServicio.Name = "txtOrdenServicio"
        Me.txtOrdenServicio.Size = New System.Drawing.Size(117, 21)
        Me.txtOrdenServicio.TabIndex = 247
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(178, 11)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(86, 19)
        Me.KryptonLabel15.TabIndex = 246
        Me.KryptonLabel15.Text = "Orden Servicio:"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Orden Servicio:"
        '
        'txtNroSolicitud
        '
        Me.txtNroSolicitud.AcceptsReturn = True
        Me.txtNroSolicitud.Location = New System.Drawing.Point(101, 9)
        Me.txtNroSolicitud.Name = "txtNroSolicitud"
        Me.txtNroSolicitud.Size = New System.Drawing.Size(71, 21)
        Me.txtNroSolicitud.TabIndex = 245
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(6, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(78, 19)
        Me.KryptonLabel1.TabIndex = 244
        Me.KryptonLabel1.Text = "Nro Solicitud:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Nro Solicitud:"
        '
        'txtFinCarga
        '
        Me.txtFinCarga.Location = New System.Drawing.Point(534, 145)
        Me.txtFinCarga.Name = "txtFinCarga"
        Me.txtFinCarga.Size = New System.Drawing.Size(84, 21)
        Me.txtFinCarga.TabIndex = 243
        '
        'txtFechaInicioCarga
        '
        Me.txtFechaInicioCarga.Location = New System.Drawing.Point(534, 62)
        Me.txtFechaInicioCarga.Name = "txtFechaInicioCarga"
        Me.txtFechaInicioCarga.Size = New System.Drawing.Size(84, 21)
        Me.txtFechaInicioCarga.TabIndex = 242
        '
        'txtsFechaSolicitud
        '
        Me.txtsFechaSolicitud.Location = New System.Drawing.Point(316, 145)
        Me.txtsFechaSolicitud.Name = "txtsFechaSolicitud"
        Me.txtsFechaSolicitud.Size = New System.Drawing.Size(84, 21)
        Me.txtsFechaSolicitud.TabIndex = 241
        '
        'txtDireccionLocalidadEntrega
        '
        Me.txtDireccionLocalidadEntrega.Location = New System.Drawing.Point(534, 174)
        Me.txtDireccionLocalidadEntrega.Name = "txtDireccionLocalidadEntrega"
        Me.txtDireccionLocalidadEntrega.Size = New System.Drawing.Size(296, 21)
        Me.txtDireccionLocalidadEntrega.TabIndex = 240
        '
        'txtLocalidadDestino
        '
        Me.txtLocalidadDestino.AcceptsReturn = True
        Me.txtLocalidadDestino.Location = New System.Drawing.Point(534, 119)
        Me.txtLocalidadDestino.Name = "txtLocalidadDestino"
        Me.txtLocalidadDestino.Size = New System.Drawing.Size(296, 21)
        Me.txtLocalidadDestino.TabIndex = 239
        '
        'txtDireccionLocalidadCarga
        '
        Me.txtDireccionLocalidadCarga.Location = New System.Drawing.Point(534, 88)
        Me.txtDireccionLocalidadCarga.Name = "txtDireccionLocalidadCarga"
        Me.txtDireccionLocalidadCarga.Size = New System.Drawing.Size(296, 21)
        Me.txtDireccionLocalidadCarga.TabIndex = 238
        '
        'txtLocalidadOrigen
        '
        Me.txtLocalidadOrigen.Location = New System.Drawing.Point(534, 37)
        Me.txtLocalidadOrigen.Name = "txtLocalidadOrigen"
        Me.txtLocalidadOrigen.Size = New System.Drawing.Size(296, 21)
        Me.txtLocalidadOrigen.TabIndex = 237
        '
        'txtMedioTransporte
        '
        Me.txtMedioTransporte.Location = New System.Drawing.Point(694, 9)
        Me.txtMedioTransporte.Name = "txtMedioTransporte"
        Me.txtMedioTransporte.Size = New System.Drawing.Size(135, 21)
        Me.txtMedioTransporte.TabIndex = 236
        '
        'txtTipoSolicitud
        '
        Me.txtTipoSolicitud.Location = New System.Drawing.Point(530, 9)
        Me.txtTipoSolicitud.Name = "txtTipoSolicitud"
        Me.txtTipoSolicitud.Size = New System.Drawing.Size(71, 21)
        Me.txtTipoSolicitud.TabIndex = 235
        '
        'txtMercaderias
        '
        Me.txtMercaderias.Location = New System.Drawing.Point(101, 174)
        Me.txtMercaderias.Name = "txtMercaderias"
        Me.txtMercaderias.Size = New System.Drawing.Size(296, 21)
        Me.txtMercaderias.TabIndex = 234
        '
        'txtCantidadMercaderia
        '
        Me.txtCantidadMercaderia.AcceptsReturn = True
        Me.txtCantidadMercaderia.Location = New System.Drawing.Point(101, 147)
        Me.txtCantidadMercaderia.Name = "txtCantidadMercaderia"
        Me.txtCantidadMercaderia.Size = New System.Drawing.Size(101, 21)
        Me.txtCantidadMercaderia.TabIndex = 233
        '
        'txtUnidadMedida
        '
        Me.txtUnidadMedida.Location = New System.Drawing.Point(101, 119)
        Me.txtUnidadMedida.Name = "txtUnidadMedida"
        Me.txtUnidadMedida.Size = New System.Drawing.Size(296, 21)
        Me.txtUnidadMedida.TabIndex = 232
        '
        'txtTipoServicio
        '
        Me.txtTipoServicio.Location = New System.Drawing.Point(101, 88)
        Me.txtTipoServicio.Name = "txtTipoServicio"
        Me.txtTipoServicio.Size = New System.Drawing.Size(296, 21)
        Me.txtTipoServicio.TabIndex = 231
        '
        'txtTipoVehiculo
        '
        Me.txtTipoVehiculo.Location = New System.Drawing.Point(101, 63)
        Me.txtTipoVehiculo.Name = "txtTipoVehiculo"
        Me.txtTipoVehiculo.Size = New System.Drawing.Size(296, 21)
        Me.txtTipoVehiculo.TabIndex = 230
        '
        'txtCentroCostoCliente
        '
        Me.txtCentroCostoCliente.AcceptsReturn = True
        Me.txtCentroCostoCliente.Location = New System.Drawing.Point(283, 35)
        Me.txtCentroCostoCliente.Name = "txtCentroCostoCliente"
        Me.txtCentroCostoCliente.Size = New System.Drawing.Size(117, 21)
        Me.txtCentroCostoCliente.TabIndex = 229
        '
        'txtCantidadSolicitada
        '
        Me.txtCantidadSolicitada.AcceptsReturn = True
        Me.txtCantidadSolicitada.Location = New System.Drawing.Point(101, 35)
        Me.txtCantidadSolicitada.Name = "txtCantidadSolicitada"
        Me.txtCantidadSolicitada.Size = New System.Drawing.Size(71, 21)
        Me.txtCantidadSolicitada.TabIndex = 228
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(101, 208)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(729, 76)
        Me.txtObservaciones.TabIndex = 199
        '
        'KryptonLabel25
        '
        Me.KryptonLabel25.Location = New System.Drawing.Point(2, 229)
        Me.KryptonLabel25.Name = "KryptonLabel25"
        Me.KryptonLabel25.Size = New System.Drawing.Size(81, 18)
        Me.KryptonLabel25.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel25.TabIndex = 201
        Me.KryptonLabel25.Text = "Observación"
        Me.KryptonLabel25.Values.ExtraText = ""
        Me.KryptonLabel25.Values.Image = Nothing
        Me.KryptonLabel25.Values.Text = "Observación"
        '
        'txtHoraEntrega
        '
        Me.txtHoraEntrega.Location = New System.Drawing.Point(717, 146)
        Me.txtHoraEntrega.Mask = "00:00:00"
        Me.txtHoraEntrega.Name = "txtHoraEntrega"
        Me.txtHoraEntrega.Size = New System.Drawing.Size(48, 20)
        Me.txtHoraEntrega.TabIndex = 197
        '
        'txtHoraCarga
        '
        Me.txtHoraCarga.Location = New System.Drawing.Point(717, 64)
        Me.txtHoraCarga.Mask = "00:00:00"
        Me.txtHoraCarga.Name = "txtHoraCarga"
        Me.txtHoraCarga.Size = New System.Drawing.Size(48, 20)
        Me.txtHoraCarga.TabIndex = 191
        '
        'KryptonBorderEdge4
        '
        Me.KryptonBorderEdge4.Location = New System.Drawing.Point(406, 9)
        Me.KryptonBorderEdge4.Name = "KryptonBorderEdge4"
        Me.KryptonBorderEdge4.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge4.Size = New System.Drawing.Size(1, 185)
        Me.KryptonBorderEdge4.TabIndex = 213
        Me.KryptonBorderEdge4.Text = "KryptonBorderEdge4"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(711, 116)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(6, 2)
        Me.KryptonLabel13.TabIndex = 193
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(640, 66)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel2.TabIndex = 190
        Me.KryptonLabel2.Text = "Hora Carga"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Hora Carga"
        '
        'KryptonLabel37
        '
        Me.KryptonLabel37.Location = New System.Drawing.Point(1197, 225)
        Me.KryptonLabel37.Name = "KryptonLabel37"
        Me.KryptonLabel37.Size = New System.Drawing.Size(90, 19)
        Me.KryptonLabel37.TabIndex = 72
        Me.KryptonLabel37.Text = "CODIGO_TABLA"
        Me.KryptonLabel37.Values.ExtraText = ""
        Me.KryptonLabel37.Values.Image = Nothing
        Me.KryptonLabel37.Values.Text = "CODIGO_TABLA"
        Me.KryptonLabel37.Visible = False
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(5, 37)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(82, 19)
        Me.KryptonLabel14.TabIndex = 216
        Me.KryptonLabel14.Text = "Cant. Vehículo"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Cant. Vehículo"
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(5, 120)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(87, 19)
        Me.KryptonLabel22.TabIndex = 188
        Me.KryptonLabel22.Text = "Unidad Medida"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Unidad Medida"
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(413, 11)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(78, 19)
        Me.KryptonLabel16.TabIndex = 214
        Me.KryptonLabel16.Text = "Tipo Solicitud"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Tipo Solicitud"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(5, 174)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(66, 19)
        Me.KryptonLabel3.TabIndex = 215
        Me.KryptonLabel3.Text = "Mercadería "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Mercadería "
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(5, 64)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(78, 19)
        Me.KryptonLabel10.TabIndex = 181
        Me.KryptonLabel10.Text = "Tipo Vehículo"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Tipo Vehículo"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(5, 147)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(95, 19)
        Me.KryptonLabel11.TabIndex = 211
        Me.KryptonLabel11.Text = "Cant. Mercadería"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Cant. Mercadería"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(225, 146)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(85, 19)
        Me.KryptonLabel4.TabIndex = 210
        Me.KryptonLabel4.Text = "Fecha Solicitud"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha Solicitud"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(5, 92)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(74, 19)
        Me.KryptonLabel9.TabIndex = 212
        Me.KryptonLabel9.Text = "Tipo Servicio"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Tipo Servicio"
        '
        'KryptonLabel30
        '
        Me.KryptonLabel30.Location = New System.Drawing.Point(607, 11)
        Me.KryptonLabel30.Name = "KryptonLabel30"
        Me.KryptonLabel30.Size = New System.Drawing.Size(81, 19)
        Me.KryptonLabel30.TabIndex = 226
        Me.KryptonLabel30.Text = "Medio Transp."
        Me.KryptonLabel30.Values.ExtraText = ""
        Me.KryptonLabel30.Values.Image = Nothing
        Me.KryptonLabel30.Values.Text = "Medio Transp."
        '
        'KryptonLabel31
        '
        Me.KryptonLabel31.Location = New System.Drawing.Point(176, 35)
        Me.KryptonLabel31.Name = "KryptonLabel31"
        Me.KryptonLabel31.Size = New System.Drawing.Size(100, 19)
        Me.KryptonLabel31.TabIndex = 227
        Me.KryptonLabel31.Text = "Referencia Cliente"
        Me.KryptonLabel31.Values.ExtraText = ""
        Me.KryptonLabel31.Values.Image = Nothing
        Me.KryptonLabel31.Values.Text = "Referencia Cliente"
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(635, 151)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel20.TabIndex = 196
        Me.KryptonLabel20.Text = "Hora Entrega"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Hora Entrega"
        '
        'KryptonLabel23
        '
        Me.KryptonLabel23.Location = New System.Drawing.Point(413, 147)
        Me.KryptonLabel23.Name = "KryptonLabel23"
        Me.KryptonLabel23.Size = New System.Drawing.Size(80, 19)
        Me.KryptonLabel23.TabIndex = 219
        Me.KryptonLabel23.Text = "Fecha Entrega"
        Me.KryptonLabel23.Values.ExtraText = ""
        Me.KryptonLabel23.Values.Image = Nothing
        Me.KryptonLabel23.Values.Text = "Fecha Entrega"
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(413, 64)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(71, 19)
        Me.KryptonLabel12.TabIndex = 218
        Me.KryptonLabel12.Text = "Fecha Carga"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Fecha Carga"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(413, 174)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(114, 19)
        Me.KryptonLabel8.TabIndex = 206
        Me.KryptonLabel8.Text = "Dirección de Entrega"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Dirección de Entrega"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(413, 120)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(99, 19)
        Me.KryptonLabel7.TabIndex = 205
        Me.KryptonLabel7.Text = "Localidad Entrega"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Localidad Entrega"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(413, 92)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(105, 19)
        Me.KryptonLabel6.TabIndex = 204
        Me.KryptonLabel6.Text = "Dirección de Carga"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Dirección de Carga"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(413, 37)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(90, 19)
        Me.KryptonLabel5.TabIndex = 203
        Me.KryptonLabel5.Text = "Localidad Carga"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Localidad Carga"
        '
        'btnCerrar
        '
        Me.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrar.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(58, 22)
        Me.btnCerrar.Text = "Cerrar"
        '
        'frmCabSolicitudTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 403)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmCabSolicitudTransporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Información Solicitud"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabSolicitudFlete.ResumeLayout(False)
        Me.tbInformacionGeneral.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents TabSolicitudFlete As System.Windows.Forms.TabControl
    Friend WithEvents tbInformacionGeneral As System.Windows.Forms.TabPage
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroSolicitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFinCarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtFechaInicioCarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtsFechaSolicitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDireccionLocalidadEntrega As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLocalidadDestino As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDireccionLocalidadCarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLocalidadOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMedioTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTipoSolicitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMercaderias As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUnidadMedida As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTipoServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTipoVehiculo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCentroCostoCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadSolicitada As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtHoraEntrega As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtHoraCarga As System.Windows.Forms.MaskedTextBox
    Friend WithEvents KryptonBorderEdge4 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel37 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel31 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
End Class
