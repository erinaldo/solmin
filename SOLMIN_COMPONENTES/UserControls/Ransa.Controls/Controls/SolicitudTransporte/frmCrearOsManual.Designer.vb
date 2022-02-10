<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearOsManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearOsManual))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.HeaderGroupDealleCcotizacion = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtCantidadMercaderia = New System.Windows.Forms.TextBox
        Me.txtLocalidadDestino = New CodeTextBox.CodeTextBox
        Me.txtLocalidadOrigen = New CodeTextBox.CodeTextBox
        Me.txtMonedaLiquidacionTransportista = New CodeTextBox.CodeTextBox
        Me.txtUnidadServicioAdicional = New CodeTextBox.CodeTextBox
        Me.txtServicioCotizacion = New CodeTextBox.CodeTextBox
        Me.txtImportePagarTransportista = New System.Windows.Forms.TextBox
        Me.KryptonLabel56 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDistancia = New System.Windows.Forms.TextBox
        Me.txtMonedaLiquidacion = New CodeTextBox.CodeTextBox
        Me.KryptonLabel46 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblLocalidadDestino = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblLocalidadOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCostoPorTonelada = New System.Windows.Forms.TextBox
        Me.KryptonLabel48 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel52 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDistanciaKM = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTarifaServicio = New System.Windows.Forms.TextBox
        Me.lblDetraccion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge3 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonBorderEdge5 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtCiaSeguro = New CodeTextBox.CodeTextBox
        Me.txtSeguroCotizacion = New CodeTextBox.CodeTextBox
        Me.txtUnidadVehicular = New CodeTextBox.CodeTextBox
        Me.txtTipoSubServicio = New CodeTextBox.CodeTextBox
        Me.txtTipoServicio = New CodeTextBox.CodeTextBox
        Me.CodeTextBox2 = New CodeTextBox.CodeTextBox
        Me.txtUnidadMedida = New CodeTextBox.CodeTextBox
        Me.txtParametroPagar = New CodeTextBox.CodeTextBox
        Me.txtParametroFacturacion = New CodeTextBox.CodeTextBox
        Me.txtMercaderia = New CodeTextBox.CodeTextBox
        Me.CodeTextBox1 = New CodeTextBox.CodeTextBox
        Me.txtPesoMercaderia = New System.Windows.Forms.TextBox
        Me.txtPolizaSeguro = New System.Windows.Forms.TextBox
        Me.txtRecargoSeguro = New System.Windows.Forms.NumericUpDown
        Me.KryptonLabel36 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel37 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel38 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel39 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel33 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel35 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtReferenciaMercaderia = New System.Windows.Forms.TextBox
        Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtVolumenMercaderia = New System.Windows.Forms.TextBox
        Me.txtValorMercaderia = New System.Windows.Forms.TextBox
        Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.HeaderGroupCotizacion = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnNuevoCotizacion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnGuardarCotizacion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelarCotizacion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.btnBuscarCotizacion = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonBorderEdge6 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNrCotizacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge7 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbTipoCobro = New System.Windows.Forms.ComboBox
        Me.txtContacto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroContrato = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPlantaFacturacion = New CodeTextBox.CodeTextBox
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbMoneda = New CodeTextBox.CodeTextBox
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.HeaderGroupDealleCcotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupDealleCcotizacion.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupDealleCcotizacion.Panel.SuspendLayout()
        Me.HeaderGroupDealleCcotizacion.SuspendLayout()
        Me.txtTipoServicio.SuspendLayout()
        Me.txtMercaderia.SuspendLayout()
        CType(Me.txtRecargoSeguro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupCotizacion.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupCotizacion.Panel.SuspendLayout()
        Me.HeaderGroupCotizacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(782, 701)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnCerrar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.HeaderGroupDealleCcotizacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.HeaderGroupCotizacion)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(782, 701)
        Me.KryptonHeaderGroup1.TabIndex = 391
        Me.KryptonHeaderGroup1.Text = "Generar Cotización y Orden de Servico"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Generar Cotización y Orden de Servico"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnCerrar
        '
        Me.btnCerrar.ExtraText = ""
        Me.btnCerrar.Image = My.Resources.Resources._exit
        Me.btnCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnCerrar.Text = "Salir"
        Me.btnCerrar.ToolTipImage = Nothing
        Me.btnCerrar.UniqueName = "1ADBD474CC2B48D51ADBD474CC2B48D5"
        '
        'HeaderGroupDealleCcotizacion
        '
        Me.HeaderGroupDealleCcotizacion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnGuardar, Me.btnCancelar})
        Me.HeaderGroupDealleCcotizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderGroupDealleCcotizacion.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupDealleCcotizacion.Location = New System.Drawing.Point(0, 192)
        Me.HeaderGroupDealleCcotizacion.Name = "HeaderGroupDealleCcotizacion"
        '
        'HeaderGroupDealleCcotizacion.Panel
        '
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtCantidadMercaderia)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtLocalidadDestino)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtLocalidadOrigen)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtMonedaLiquidacionTransportista)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtUnidadServicioAdicional)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtServicioCotizacion)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtImportePagarTransportista)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel56)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtDistancia)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtMonedaLiquidacion)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel46)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.lblLocalidadDestino)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.lblLocalidadOrigen)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtCostoPorTonelada)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel48)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel52)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.lblDistanciaKM)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtTarifaServicio)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.lblDetraccion)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel13)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonBorderEdge3)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonBorderEdge5)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtCiaSeguro)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtSeguroCotizacion)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtUnidadVehicular)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtTipoSubServicio)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtTipoServicio)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtUnidadMedida)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtParametroPagar)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtParametroFacturacion)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtMercaderia)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtPesoMercaderia)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtPolizaSeguro)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtRecargoSeguro)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel36)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel37)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel38)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel39)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel32)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel33)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel35)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtReferenciaMercaderia)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel29)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel19)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel20)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel21)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel5)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel7)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel9)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel11)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel26)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel27)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonLabel28)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtVolumenMercaderia)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.txtValorMercaderia)
        Me.HeaderGroupDealleCcotizacion.Panel.Controls.Add(Me.KryptonBorderEdge2)
        Me.HeaderGroupDealleCcotizacion.Size = New System.Drawing.Size(780, 476)
        Me.HeaderGroupDealleCcotizacion.TabIndex = 0
        Me.HeaderGroupDealleCcotizacion.Text = "Detalle Cotización"
        Me.HeaderGroupDealleCcotizacion.ValuesPrimary.Description = ""
        Me.HeaderGroupDealleCcotizacion.ValuesPrimary.Heading = "Detalle Cotización"
        Me.HeaderGroupDealleCcotizacion.ValuesPrimary.Image = Nothing
        Me.HeaderGroupDealleCcotizacion.ValuesSecondary.Description = ""
        Me.HeaderGroupDealleCcotizacion.ValuesSecondary.Heading = ""
        Me.HeaderGroupDealleCcotizacion.ValuesSecondary.Image = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ExtraText = ""
        Me.btnGuardar.Image = My.Resources.Resources.db_add
        Me.btnGuardar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ToolTipImage = Nothing
        Me.btnGuardar.UniqueName = "5C29C1D0974441715C29C1D097444171"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = My.Resources.Resources._stop
        Me.btnCancelar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "857073FC0F424018857073FC0F424018"
        '
        'txtCantidadMercaderia
        '
        Me.txtCantidadMercaderia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadMercaderia.Location = New System.Drawing.Point(145, 53)
        Me.txtCantidadMercaderia.MaxLength = 8
        Me.txtCantidadMercaderia.Name = "txtCantidadMercaderia"
        Me.txtCantidadMercaderia.Size = New System.Drawing.Size(63, 21)
        Me.txtCantidadMercaderia.TabIndex = 1
        Me.txtCantidadMercaderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLocalidadDestino
        '
        Me.txtLocalidadDestino.BackColor = System.Drawing.Color.White
        Me.txtLocalidadDestino.Codigo = ""
        Me.txtLocalidadDestino.ControlHeight = 23
        Me.txtLocalidadDestino.ControlImage = True
        Me.txtLocalidadDestino.ControlReadOnly = False
        Me.txtLocalidadDestino.Descripcion = ""
        Me.txtLocalidadDestino.DisplayColumnVisible = True
        Me.txtLocalidadDestino.DisplayMember = ""
        Me.txtLocalidadDestino.KeyColumnWidth = 100
        Me.txtLocalidadDestino.KeyField = ""
        Me.txtLocalidadDestino.KeySearch = True
        Me.txtLocalidadDestino.Location = New System.Drawing.Point(148, 389)
        Me.txtLocalidadDestino.Name = "txtLocalidadDestino"
        Me.txtLocalidadDestino.Size = New System.Drawing.Size(223, 23)
        Me.txtLocalidadDestino.TabIndex = 34
        Me.txtLocalidadDestino.TextBackColor = System.Drawing.Color.Empty
        Me.txtLocalidadDestino.TextForeColor = System.Drawing.Color.Empty
        Me.txtLocalidadDestino.ValueColumnVisible = True
        Me.txtLocalidadDestino.ValueColumnWidth = 600
        Me.txtLocalidadDestino.ValueField = ""
        Me.txtLocalidadDestino.ValueMember = ""
        Me.txtLocalidadDestino.ValueSearch = True
        '
        'txtLocalidadOrigen
        '
        Me.txtLocalidadOrigen.BackColor = System.Drawing.Color.White
        Me.txtLocalidadOrigen.Codigo = ""
        Me.txtLocalidadOrigen.ControlHeight = 23
        Me.txtLocalidadOrigen.ControlImage = True
        Me.txtLocalidadOrigen.ControlReadOnly = False
        Me.txtLocalidadOrigen.Descripcion = ""
        Me.txtLocalidadOrigen.DisplayColumnVisible = True
        Me.txtLocalidadOrigen.DisplayMember = ""
        Me.txtLocalidadOrigen.KeyColumnWidth = 100
        Me.txtLocalidadOrigen.KeyField = ""
        Me.txtLocalidadOrigen.KeySearch = True
        Me.txtLocalidadOrigen.Location = New System.Drawing.Point(148, 365)
        Me.txtLocalidadOrigen.Name = "txtLocalidadOrigen"
        Me.txtLocalidadOrigen.Size = New System.Drawing.Size(223, 23)
        Me.txtLocalidadOrigen.TabIndex = 33
        Me.txtLocalidadOrigen.TextBackColor = System.Drawing.Color.Empty
        Me.txtLocalidadOrigen.TextForeColor = System.Drawing.Color.Empty
        Me.txtLocalidadOrigen.ValueColumnVisible = True
        Me.txtLocalidadOrigen.ValueColumnWidth = 600
        Me.txtLocalidadOrigen.ValueField = ""
        Me.txtLocalidadOrigen.ValueMember = ""
        Me.txtLocalidadOrigen.ValueSearch = True
        '
        'txtMonedaLiquidacionTransportista
        '
        Me.txtMonedaLiquidacionTransportista.BackColor = System.Drawing.Color.White
        Me.txtMonedaLiquidacionTransportista.Codigo = ""
        Me.txtMonedaLiquidacionTransportista.ControlHeight = 23
        Me.txtMonedaLiquidacionTransportista.ControlImage = True
        Me.txtMonedaLiquidacionTransportista.ControlReadOnly = False
        Me.txtMonedaLiquidacionTransportista.Descripcion = ""
        Me.txtMonedaLiquidacionTransportista.DisplayColumnVisible = True
        Me.txtMonedaLiquidacionTransportista.DisplayMember = ""
        Me.txtMonedaLiquidacionTransportista.KeyColumnWidth = 100
        Me.txtMonedaLiquidacionTransportista.KeyField = ""
        Me.txtMonedaLiquidacionTransportista.KeySearch = True
        Me.txtMonedaLiquidacionTransportista.Location = New System.Drawing.Point(213, 186)
        Me.txtMonedaLiquidacionTransportista.Name = "txtMonedaLiquidacionTransportista"
        Me.txtMonedaLiquidacionTransportista.Size = New System.Drawing.Size(150, 23)
        Me.txtMonedaLiquidacionTransportista.TabIndex = 19
        Me.txtMonedaLiquidacionTransportista.TextBackColor = System.Drawing.Color.Empty
        Me.txtMonedaLiquidacionTransportista.TextForeColor = System.Drawing.Color.Empty
        Me.txtMonedaLiquidacionTransportista.ValueColumnVisible = True
        Me.txtMonedaLiquidacionTransportista.ValueColumnWidth = 600
        Me.txtMonedaLiquidacionTransportista.ValueField = ""
        Me.txtMonedaLiquidacionTransportista.ValueMember = ""
        Me.txtMonedaLiquidacionTransportista.ValueSearch = True
        '
        'txtUnidadServicioAdicional
        '
        Me.txtUnidadServicioAdicional.BackColor = System.Drawing.Color.White
        Me.txtUnidadServicioAdicional.Codigo = ""
        Me.txtUnidadServicioAdicional.ControlHeight = 23
        Me.txtUnidadServicioAdicional.ControlImage = True
        Me.txtUnidadServicioAdicional.ControlReadOnly = False
        Me.txtUnidadServicioAdicional.Descripcion = ""
        Me.txtUnidadServicioAdicional.DisplayColumnVisible = True
        Me.txtUnidadServicioAdicional.DisplayMember = ""
        Me.txtUnidadServicioAdicional.KeyColumnWidth = 100
        Me.txtUnidadServicioAdicional.KeyField = ""
        Me.txtUnidadServicioAdicional.KeySearch = True
        Me.txtUnidadServicioAdicional.Location = New System.Drawing.Point(148, 340)
        Me.txtUnidadServicioAdicional.Name = "txtUnidadServicioAdicional"
        Me.txtUnidadServicioAdicional.Size = New System.Drawing.Size(223, 23)
        Me.txtUnidadServicioAdicional.TabIndex = 32
        Me.txtUnidadServicioAdicional.TextBackColor = System.Drawing.Color.Empty
        Me.txtUnidadServicioAdicional.TextForeColor = System.Drawing.Color.Empty
        Me.txtUnidadServicioAdicional.ValueColumnVisible = True
        Me.txtUnidadServicioAdicional.ValueColumnWidth = 600
        Me.txtUnidadServicioAdicional.ValueField = ""
        Me.txtUnidadServicioAdicional.ValueMember = ""
        Me.txtUnidadServicioAdicional.ValueSearch = True
        '
        'txtServicioCotizacion
        '
        Me.txtServicioCotizacion.BackColor = System.Drawing.Color.White
        Me.txtServicioCotizacion.Codigo = ""
        Me.txtServicioCotizacion.ControlHeight = 23
        Me.txtServicioCotizacion.ControlImage = True
        Me.txtServicioCotizacion.ControlReadOnly = False
        Me.txtServicioCotizacion.Descripcion = ""
        Me.txtServicioCotizacion.DisplayColumnVisible = True
        Me.txtServicioCotizacion.DisplayMember = ""
        Me.txtServicioCotizacion.KeyColumnWidth = 100
        Me.txtServicioCotizacion.KeyField = ""
        Me.txtServicioCotizacion.KeySearch = True
        Me.txtServicioCotizacion.Location = New System.Drawing.Point(148, 315)
        Me.txtServicioCotizacion.Name = "txtServicioCotizacion"
        Me.txtServicioCotizacion.Size = New System.Drawing.Size(223, 23)
        Me.txtServicioCotizacion.TabIndex = 31
        Me.txtServicioCotizacion.TextBackColor = System.Drawing.Color.Empty
        Me.txtServicioCotizacion.TextForeColor = System.Drawing.Color.Empty
        Me.txtServicioCotizacion.ValueColumnVisible = True
        Me.txtServicioCotizacion.ValueColumnWidth = 600
        Me.txtServicioCotizacion.ValueField = ""
        Me.txtServicioCotizacion.ValueMember = ""
        Me.txtServicioCotizacion.ValueSearch = True
        '
        'txtImportePagarTransportista
        '
        Me.txtImportePagarTransportista.Location = New System.Drawing.Point(145, 183)
        Me.txtImportePagarTransportista.MaxLength = 15
        Me.txtImportePagarTransportista.Name = "txtImportePagarTransportista"
        Me.txtImportePagarTransportista.Size = New System.Drawing.Size(63, 20)
        Me.txtImportePagarTransportista.TabIndex = 18
        Me.txtImportePagarTransportista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel56
        '
        Me.KryptonLabel56.Location = New System.Drawing.Point(18, 190)
        Me.KryptonLabel56.Name = "KryptonLabel56"
        Me.KryptonLabel56.Size = New System.Drawing.Size(93, 19)
        Me.KryptonLabel56.TabIndex = 508
        Me.KryptonLabel56.Text = "Imp. Liquidación"
        Me.KryptonLabel56.Values.ExtraText = ""
        Me.KryptonLabel56.Values.Image = Nothing
        Me.KryptonLabel56.Values.Text = "Imp. Liquidación"
        '
        'txtDistancia
        '
        Me.txtDistancia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDistancia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistancia.Location = New System.Drawing.Point(148, 413)
        Me.txtDistancia.MaxLength = 9
        Me.txtDistancia.Name = "txtDistancia"
        Me.txtDistancia.Size = New System.Drawing.Size(223, 21)
        Me.txtDistancia.TabIndex = 35
        Me.txtDistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonedaLiquidacion
        '
        Me.txtMonedaLiquidacion.BackColor = System.Drawing.Color.White
        Me.txtMonedaLiquidacion.Codigo = ""
        Me.txtMonedaLiquidacion.ControlHeight = 23
        Me.txtMonedaLiquidacion.ControlImage = True
        Me.txtMonedaLiquidacion.ControlReadOnly = False
        Me.txtMonedaLiquidacion.Descripcion = ""
        Me.txtMonedaLiquidacion.DisplayColumnVisible = True
        Me.txtMonedaLiquidacion.DisplayMember = ""
        Me.txtMonedaLiquidacion.KeyColumnWidth = 100
        Me.txtMonedaLiquidacion.KeyField = ""
        Me.txtMonedaLiquidacion.KeySearch = True
        Me.txtMonedaLiquidacion.Location = New System.Drawing.Point(213, 160)
        Me.txtMonedaLiquidacion.Name = "txtMonedaLiquidacion"
        Me.txtMonedaLiquidacion.Size = New System.Drawing.Size(150, 23)
        Me.txtMonedaLiquidacion.TabIndex = 17
        Me.txtMonedaLiquidacion.TextBackColor = System.Drawing.Color.Empty
        Me.txtMonedaLiquidacion.TextForeColor = System.Drawing.Color.Empty
        Me.txtMonedaLiquidacion.ValueColumnVisible = True
        Me.txtMonedaLiquidacion.ValueColumnWidth = 600
        Me.txtMonedaLiquidacion.ValueField = ""
        Me.txtMonedaLiquidacion.ValueMember = ""
        Me.txtMonedaLiquidacion.ValueSearch = True
        '
        'KryptonLabel46
        '
        Me.KryptonLabel46.Location = New System.Drawing.Point(18, 319)
        Me.KryptonLabel46.Name = "KryptonLabel46"
        Me.KryptonLabel46.Size = New System.Drawing.Size(89, 19)
        Me.KryptonLabel46.TabIndex = 503
        Me.KryptonLabel46.Text = "Serv. Cotización"
        Me.KryptonLabel46.Values.ExtraText = ""
        Me.KryptonLabel46.Values.Image = Nothing
        Me.KryptonLabel46.Values.Text = "Serv. Cotización"
        '
        'lblLocalidadDestino
        '
        Me.lblLocalidadDestino.Location = New System.Drawing.Point(18, 393)
        Me.lblLocalidadDestino.Name = "lblLocalidadDestino"
        Me.lblLocalidadDestino.Size = New System.Drawing.Size(81, 19)
        Me.lblLocalidadDestino.TabIndex = 506
        Me.lblLocalidadDestino.Text = "Punto Destino"
        Me.lblLocalidadDestino.Values.ExtraText = ""
        Me.lblLocalidadDestino.Values.Image = Nothing
        Me.lblLocalidadDestino.Values.Text = "Punto Destino"
        '
        'lblLocalidadOrigen
        '
        Me.lblLocalidadOrigen.Location = New System.Drawing.Point(18, 369)
        Me.lblLocalidadOrigen.Name = "lblLocalidadOrigen"
        Me.lblLocalidadOrigen.Size = New System.Drawing.Size(77, 19)
        Me.lblLocalidadOrigen.TabIndex = 505
        Me.lblLocalidadOrigen.Text = "Punto Origen"
        Me.lblLocalidadOrigen.Values.ExtraText = ""
        Me.lblLocalidadOrigen.Values.Image = Nothing
        Me.lblLocalidadOrigen.Values.Text = "Punto Origen"
        '
        'txtCostoPorTonelada
        '
        Me.txtCostoPorTonelada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCostoPorTonelada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoPorTonelada.Location = New System.Drawing.Point(536, 215)
        Me.txtCostoPorTonelada.MaxLength = 15
        Me.txtCostoPorTonelada.Name = "txtCostoPorTonelada"
        Me.txtCostoPorTonelada.Size = New System.Drawing.Size(223, 21)
        Me.txtCostoPorTonelada.TabIndex = 30
        Me.txtCostoPorTonelada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel48
        '
        Me.KryptonLabel48.Location = New System.Drawing.Point(18, 344)
        Me.KryptonLabel48.Name = "KryptonLabel48"
        Me.KryptonLabel48.Size = New System.Drawing.Size(88, 19)
        Me.KryptonLabel48.TabIndex = 504
        Me.KryptonLabel48.Text = "Unid. Serv. Adic"
        Me.KryptonLabel48.Values.ExtraText = ""
        Me.KryptonLabel48.Values.Image = Nothing
        Me.KryptonLabel48.Values.Text = "Unid. Serv. Adic"
        '
        'KryptonLabel52
        '
        Me.KryptonLabel52.Location = New System.Drawing.Point(18, 165)
        Me.KryptonLabel52.Name = "KryptonLabel52"
        Me.KryptonLabel52.Size = New System.Drawing.Size(79, 19)
        Me.KryptonLabel52.TabIndex = 507
        Me.KryptonLabel52.Text = "Imp. de Tarifa"
        Me.KryptonLabel52.Values.ExtraText = ""
        Me.KryptonLabel52.Values.Image = Nothing
        Me.KryptonLabel52.Values.Text = "Imp. de Tarifa"
        '
        'lblDistanciaKM
        '
        Me.lblDistanciaKM.Location = New System.Drawing.Point(18, 417)
        Me.lblDistanciaKM.Name = "lblDistanciaKM"
        Me.lblDistanciaKM.Size = New System.Drawing.Size(81, 19)
        Me.lblDistanciaKM.TabIndex = 501
        Me.lblDistanciaKM.Text = "Distancia (km)"
        Me.lblDistanciaKM.Values.ExtraText = ""
        Me.lblDistanciaKM.Values.Image = Nothing
        Me.lblDistanciaKM.Values.Text = "Distancia (km)"
        '
        'txtTarifaServicio
        '
        Me.txtTarifaServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTarifaServicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarifaServicio.Location = New System.Drawing.Point(145, 157)
        Me.txtTarifaServicio.MaxLength = 15
        Me.txtTarifaServicio.Name = "txtTarifaServicio"
        Me.txtTarifaServicio.Size = New System.Drawing.Size(63, 21)
        Me.txtTarifaServicio.TabIndex = 16
        Me.txtTarifaServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDetraccion
        '
        Me.lblDetraccion.Location = New System.Drawing.Point(410, 215)
        Me.lblDetraccion.Name = "lblDetraccion"
        Me.lblDetraccion.Size = New System.Drawing.Size(64, 19)
        Me.lblDetraccion.TabIndex = 502
        Me.lblDetraccion.Text = "Detracción"
        Me.lblDetraccion.Values.ExtraText = ""
        Me.lblDetraccion.Values.Image = Nothing
        Me.lblDetraccion.Values.Text = "Detracción"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(14, 5)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(75, 18)
        Me.KryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel2.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 487
        Me.KryptonLabel2.Text = "Mercadería"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Mercadería"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(14, 289)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(137, 18)
        Me.KryptonLabel13.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel13.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel13.TabIndex = 489
        Me.KryptonLabel13.Text = "Servicio de cotización"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Servicio de cotización"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(393, 5)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(109, 18)
        Me.KryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 488
        Me.KryptonLabel1.Text = "Unidad Vehicular"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Unidad Vehicular"
        '
        'KryptonBorderEdge3
        '
        Me.KryptonBorderEdge3.Location = New System.Drawing.Point(16, 298)
        Me.KryptonBorderEdge3.Name = "KryptonBorderEdge3"
        Me.KryptonBorderEdge3.Size = New System.Drawing.Size(740, 1)
        Me.KryptonBorderEdge3.TabIndex = 486
        Me.KryptonBorderEdge3.Text = "KryptonBorderEdge3"
        '
        'KryptonBorderEdge5
        '
        Me.KryptonBorderEdge5.Location = New System.Drawing.Point(387, 15)
        Me.KryptonBorderEdge5.Name = "KryptonBorderEdge5"
        Me.KryptonBorderEdge5.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge5.Size = New System.Drawing.Size(1, 240)
        Me.KryptonBorderEdge5.TabIndex = 485
        Me.KryptonBorderEdge5.Text = "KryptonBorderEdge5"
        '
        'txtCiaSeguro
        '
        Me.txtCiaSeguro.Codigo = ""
        Me.txtCiaSeguro.ControlHeight = 23
        Me.txtCiaSeguro.ControlImage = True
        Me.txtCiaSeguro.ControlReadOnly = False
        Me.txtCiaSeguro.Descripcion = ""
        Me.txtCiaSeguro.DisplayColumnVisible = True
        Me.txtCiaSeguro.DisplayMember = ""
        Me.txtCiaSeguro.KeyColumnWidth = 100
        Me.txtCiaSeguro.KeyField = ""
        Me.txtCiaSeguro.KeySearch = True
        Me.txtCiaSeguro.Location = New System.Drawing.Point(536, 138)
        Me.txtCiaSeguro.Name = "txtCiaSeguro"
        Me.txtCiaSeguro.Size = New System.Drawing.Size(223, 23)
        Me.txtCiaSeguro.TabIndex = 27
        Me.txtCiaSeguro.TextBackColor = System.Drawing.Color.Empty
        Me.txtCiaSeguro.TextForeColor = System.Drawing.Color.Empty
        Me.txtCiaSeguro.ValueColumnVisible = True
        Me.txtCiaSeguro.ValueColumnWidth = 600
        Me.txtCiaSeguro.ValueField = ""
        Me.txtCiaSeguro.ValueMember = ""
        Me.txtCiaSeguro.ValueSearch = True
        '
        'txtSeguroCotizacion
        '
        Me.txtSeguroCotizacion.BackColor = System.Drawing.Color.White
        Me.txtSeguroCotizacion.Codigo = ""
        Me.txtSeguroCotizacion.ControlHeight = 23
        Me.txtSeguroCotizacion.ControlImage = True
        Me.txtSeguroCotizacion.ControlReadOnly = False
        Me.txtSeguroCotizacion.Descripcion = ""
        Me.txtSeguroCotizacion.DisplayColumnVisible = True
        Me.txtSeguroCotizacion.DisplayMember = ""
        Me.txtSeguroCotizacion.KeyColumnWidth = 100
        Me.txtSeguroCotizacion.KeyField = ""
        Me.txtSeguroCotizacion.KeySearch = True
        Me.txtSeguroCotizacion.Location = New System.Drawing.Point(536, 111)
        Me.txtSeguroCotizacion.Name = "txtSeguroCotizacion"
        Me.txtSeguroCotizacion.Size = New System.Drawing.Size(223, 23)
        Me.txtSeguroCotizacion.TabIndex = 26
        Me.txtSeguroCotizacion.TextBackColor = System.Drawing.Color.Empty
        Me.txtSeguroCotizacion.TextForeColor = System.Drawing.Color.Empty
        Me.txtSeguroCotizacion.ValueColumnVisible = True
        Me.txtSeguroCotizacion.ValueColumnWidth = 600
        Me.txtSeguroCotizacion.ValueField = ""
        Me.txtSeguroCotizacion.ValueMember = ""
        Me.txtSeguroCotizacion.ValueSearch = True
        '
        'txtUnidadVehicular
        '
        Me.txtUnidadVehicular.BackColor = System.Drawing.Color.White
        Me.txtUnidadVehicular.Codigo = ""
        Me.txtUnidadVehicular.ControlHeight = 23
        Me.txtUnidadVehicular.ControlImage = True
        Me.txtUnidadVehicular.ControlReadOnly = False
        Me.txtUnidadVehicular.Descripcion = ""
        Me.txtUnidadVehicular.DisplayColumnVisible = True
        Me.txtUnidadVehicular.DisplayMember = ""
        Me.txtUnidadVehicular.KeyColumnWidth = 100
        Me.txtUnidadVehicular.KeyField = ""
        Me.txtUnidadVehicular.KeySearch = True
        Me.txtUnidadVehicular.Location = New System.Drawing.Point(536, 30)
        Me.txtUnidadVehicular.Name = "txtUnidadVehicular"
        Me.txtUnidadVehicular.Size = New System.Drawing.Size(223, 23)
        Me.txtUnidadVehicular.TabIndex = 23
        Me.txtUnidadVehicular.TextBackColor = System.Drawing.Color.Empty
        Me.txtUnidadVehicular.TextForeColor = System.Drawing.Color.Empty
        Me.txtUnidadVehicular.ValueColumnVisible = True
        Me.txtUnidadVehicular.ValueColumnWidth = 600
        Me.txtUnidadVehicular.ValueField = ""
        Me.txtUnidadVehicular.ValueMember = ""
        Me.txtUnidadVehicular.ValueSearch = True
        '
        'txtTipoSubServicio
        '
        Me.txtTipoSubServicio.BackColor = System.Drawing.Color.White
        Me.txtTipoSubServicio.Codigo = ""
        Me.txtTipoSubServicio.ControlHeight = 23
        Me.txtTipoSubServicio.ControlImage = True
        Me.txtTipoSubServicio.ControlReadOnly = False
        Me.txtTipoSubServicio.Descripcion = ""
        Me.txtTipoSubServicio.DisplayColumnVisible = True
        Me.txtTipoSubServicio.DisplayMember = ""
        Me.txtTipoSubServicio.KeyColumnWidth = 100
        Me.txtTipoSubServicio.KeyField = ""
        Me.txtTipoSubServicio.KeySearch = True
        Me.txtTipoSubServicio.Location = New System.Drawing.Point(144, 265)
        Me.txtTipoSubServicio.Name = "txtTipoSubServicio"
        Me.txtTipoSubServicio.Size = New System.Drawing.Size(223, 23)
        Me.txtTipoSubServicio.TabIndex = 22
        Me.txtTipoSubServicio.TextBackColor = System.Drawing.Color.Empty
        Me.txtTipoSubServicio.TextForeColor = System.Drawing.Color.Empty
        Me.txtTipoSubServicio.ValueColumnVisible = True
        Me.txtTipoSubServicio.ValueColumnWidth = 600
        Me.txtTipoSubServicio.ValueField = ""
        Me.txtTipoSubServicio.ValueMember = ""
        Me.txtTipoSubServicio.ValueSearch = True
        '
        'txtTipoServicio
        '
        Me.txtTipoServicio.BackColor = System.Drawing.Color.White
        Me.txtTipoServicio.Codigo = ""
        Me.txtTipoServicio.ControlHeight = 23
        Me.txtTipoServicio.ControlImage = True
        Me.txtTipoServicio.ControlReadOnly = False
        Me.txtTipoServicio.Controls.Add(Me.CodeTextBox2)
        Me.txtTipoServicio.Descripcion = ""
        Me.txtTipoServicio.DisplayColumnVisible = True
        Me.txtTipoServicio.DisplayMember = ""
        Me.txtTipoServicio.KeyColumnWidth = 100
        Me.txtTipoServicio.KeyField = ""
        Me.txtTipoServicio.KeySearch = True
        Me.txtTipoServicio.Location = New System.Drawing.Point(144, 237)
        Me.txtTipoServicio.Name = "txtTipoServicio"
        Me.txtTipoServicio.Size = New System.Drawing.Size(223, 23)
        Me.txtTipoServicio.TabIndex = 21
        Me.txtTipoServicio.TextBackColor = System.Drawing.Color.Empty
        Me.txtTipoServicio.TextForeColor = System.Drawing.Color.Empty
        Me.txtTipoServicio.ValueColumnVisible = True
        Me.txtTipoServicio.ValueColumnWidth = 600
        Me.txtTipoServicio.ValueField = ""
        Me.txtTipoServicio.ValueMember = ""
        Me.txtTipoServicio.ValueSearch = True
        '
        'CodeTextBox2
        '
        Me.CodeTextBox2.Codigo = ""
        Me.CodeTextBox2.ControlHeight = 23
        Me.CodeTextBox2.ControlImage = True
        Me.CodeTextBox2.ControlReadOnly = False
        Me.CodeTextBox2.Descripcion = ""
        Me.CodeTextBox2.DisplayColumnVisible = True
        Me.CodeTextBox2.DisplayMember = ""
        Me.CodeTextBox2.KeyColumnWidth = 100
        Me.CodeTextBox2.KeyField = ""
        Me.CodeTextBox2.KeySearch = True
        Me.CodeTextBox2.Location = New System.Drawing.Point(0, 28)
        Me.CodeTextBox2.Name = "CodeTextBox2"
        Me.CodeTextBox2.Size = New System.Drawing.Size(140, 23)
        Me.CodeTextBox2.TabIndex = 0
        Me.CodeTextBox2.TextBackColor = System.Drawing.Color.Empty
        Me.CodeTextBox2.TextForeColor = System.Drawing.Color.Empty
        Me.CodeTextBox2.ValueColumnVisible = True
        Me.CodeTextBox2.ValueColumnWidth = 600
        Me.CodeTextBox2.ValueField = ""
        Me.CodeTextBox2.ValueMember = ""
        Me.CodeTextBox2.ValueSearch = True
        '
        'txtUnidadMedida
        '
        Me.txtUnidadMedida.BackColor = System.Drawing.Color.White
        Me.txtUnidadMedida.Codigo = ""
        Me.txtUnidadMedida.ControlHeight = 23
        Me.txtUnidadMedida.ControlImage = True
        Me.txtUnidadMedida.ControlReadOnly = False
        Me.txtUnidadMedida.Descripcion = ""
        Me.txtUnidadMedida.DisplayColumnVisible = True
        Me.txtUnidadMedida.DisplayMember = ""
        Me.txtUnidadMedida.KeyColumnWidth = 100
        Me.txtUnidadMedida.KeyField = ""
        Me.txtUnidadMedida.KeySearch = True
        Me.txtUnidadMedida.Location = New System.Drawing.Point(213, 53)
        Me.txtUnidadMedida.Name = "txtUnidadMedida"
        Me.txtUnidadMedida.Size = New System.Drawing.Size(153, 23)
        Me.txtUnidadMedida.TabIndex = 2
        Me.txtUnidadMedida.TextBackColor = System.Drawing.Color.Empty
        Me.txtUnidadMedida.TextForeColor = System.Drawing.Color.Empty
        Me.txtUnidadMedida.ValueColumnVisible = True
        Me.txtUnidadMedida.ValueColumnWidth = 600
        Me.txtUnidadMedida.ValueField = ""
        Me.txtUnidadMedida.ValueMember = ""
        Me.txtUnidadMedida.ValueSearch = True
        '
        'txtParametroPagar
        '
        Me.txtParametroPagar.BackColor = System.Drawing.Color.White
        Me.txtParametroPagar.Codigo = ""
        Me.txtParametroPagar.ControlHeight = 23
        Me.txtParametroPagar.ControlImage = True
        Me.txtParametroPagar.ControlReadOnly = False
        Me.txtParametroPagar.Descripcion = ""
        Me.txtParametroPagar.DisplayColumnVisible = True
        Me.txtParametroPagar.DisplayMember = ""
        Me.txtParametroPagar.KeyColumnWidth = 100
        Me.txtParametroPagar.KeyField = ""
        Me.txtParametroPagar.KeySearch = True
        Me.txtParametroPagar.Location = New System.Drawing.Point(536, 84)
        Me.txtParametroPagar.Name = "txtParametroPagar"
        Me.txtParametroPagar.Size = New System.Drawing.Size(223, 23)
        Me.txtParametroPagar.TabIndex = 25
        Me.txtParametroPagar.TextBackColor = System.Drawing.Color.Empty
        Me.txtParametroPagar.TextForeColor = System.Drawing.Color.Empty
        Me.txtParametroPagar.ValueColumnVisible = True
        Me.txtParametroPagar.ValueColumnWidth = 600
        Me.txtParametroPagar.ValueField = ""
        Me.txtParametroPagar.ValueMember = ""
        Me.txtParametroPagar.ValueSearch = True
        '
        'txtParametroFacturacion
        '
        Me.txtParametroFacturacion.BackColor = System.Drawing.Color.White
        Me.txtParametroFacturacion.Codigo = ""
        Me.txtParametroFacturacion.ControlHeight = 23
        Me.txtParametroFacturacion.ControlImage = True
        Me.txtParametroFacturacion.ControlReadOnly = False
        Me.txtParametroFacturacion.Descripcion = ""
        Me.txtParametroFacturacion.DisplayColumnVisible = True
        Me.txtParametroFacturacion.DisplayMember = ""
        Me.txtParametroFacturacion.KeyColumnWidth = 100
        Me.txtParametroFacturacion.KeyField = ""
        Me.txtParametroFacturacion.KeySearch = True
        Me.txtParametroFacturacion.Location = New System.Drawing.Point(536, 57)
        Me.txtParametroFacturacion.Name = "txtParametroFacturacion"
        Me.txtParametroFacturacion.Size = New System.Drawing.Size(223, 23)
        Me.txtParametroFacturacion.TabIndex = 24
        Me.txtParametroFacturacion.TextBackColor = System.Drawing.Color.Empty
        Me.txtParametroFacturacion.TextForeColor = System.Drawing.Color.Empty
        Me.txtParametroFacturacion.ValueColumnVisible = True
        Me.txtParametroFacturacion.ValueColumnWidth = 600
        Me.txtParametroFacturacion.ValueField = ""
        Me.txtParametroFacturacion.ValueMember = ""
        Me.txtParametroFacturacion.ValueSearch = True
        '
        'txtMercaderia
        '
        Me.txtMercaderia.BackColor = System.Drawing.Color.White
        Me.txtMercaderia.Codigo = ""
        Me.txtMercaderia.ControlHeight = 23
        Me.txtMercaderia.ControlImage = True
        Me.txtMercaderia.ControlReadOnly = False
        Me.txtMercaderia.Controls.Add(Me.CodeTextBox1)
        Me.txtMercaderia.Descripcion = ""
        Me.txtMercaderia.DisplayColumnVisible = True
        Me.txtMercaderia.DisplayMember = ""
        Me.txtMercaderia.KeyColumnWidth = 100
        Me.txtMercaderia.KeyField = ""
        Me.txtMercaderia.KeySearch = True
        Me.txtMercaderia.Location = New System.Drawing.Point(145, 25)
        Me.txtMercaderia.Name = "txtMercaderia"
        Me.txtMercaderia.Size = New System.Drawing.Size(223, 23)
        Me.txtMercaderia.TabIndex = 0
        Me.txtMercaderia.TextBackColor = System.Drawing.Color.Empty
        Me.txtMercaderia.TextForeColor = System.Drawing.Color.Empty
        Me.txtMercaderia.ValueColumnVisible = True
        Me.txtMercaderia.ValueColumnWidth = 600
        Me.txtMercaderia.ValueField = ""
        Me.txtMercaderia.ValueMember = ""
        Me.txtMercaderia.ValueSearch = True
        '
        'CodeTextBox1
        '
        Me.CodeTextBox1.Codigo = ""
        Me.CodeTextBox1.ControlHeight = 23
        Me.CodeTextBox1.ControlImage = True
        Me.CodeTextBox1.ControlReadOnly = False
        Me.CodeTextBox1.Descripcion = ""
        Me.CodeTextBox1.DisplayColumnVisible = True
        Me.CodeTextBox1.DisplayMember = ""
        Me.CodeTextBox1.KeyColumnWidth = 100
        Me.CodeTextBox1.KeyField = ""
        Me.CodeTextBox1.KeySearch = True
        Me.CodeTextBox1.Location = New System.Drawing.Point(0, 28)
        Me.CodeTextBox1.Name = "CodeTextBox1"
        Me.CodeTextBox1.Size = New System.Drawing.Size(156, 23)
        Me.CodeTextBox1.TabIndex = 0
        Me.CodeTextBox1.TextBackColor = System.Drawing.Color.Empty
        Me.CodeTextBox1.TextForeColor = System.Drawing.Color.Empty
        Me.CodeTextBox1.ValueColumnVisible = True
        Me.CodeTextBox1.ValueColumnWidth = 600
        Me.CodeTextBox1.ValueField = ""
        Me.CodeTextBox1.ValueMember = ""
        Me.CodeTextBox1.ValueSearch = True
        '
        'txtPesoMercaderia
        '
        Me.txtPesoMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoMercaderia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoMercaderia.Location = New System.Drawing.Point(145, 79)
        Me.txtPesoMercaderia.MaxLength = 8
        Me.txtPesoMercaderia.Name = "txtPesoMercaderia"
        Me.txtPesoMercaderia.Size = New System.Drawing.Size(63, 21)
        Me.txtPesoMercaderia.TabIndex = 3
        Me.txtPesoMercaderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPolizaSeguro
        '
        Me.txtPolizaSeguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPolizaSeguro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPolizaSeguro.Location = New System.Drawing.Point(536, 165)
        Me.txtPolizaSeguro.MaxLength = 10
        Me.txtPolizaSeguro.Name = "txtPolizaSeguro"
        Me.txtPolizaSeguro.Size = New System.Drawing.Size(223, 21)
        Me.txtPolizaSeguro.TabIndex = 28
        '
        'txtRecargoSeguro
        '
        Me.txtRecargoSeguro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargoSeguro.Location = New System.Drawing.Point(536, 190)
        Me.txtRecargoSeguro.Name = "txtRecargoSeguro"
        Me.txtRecargoSeguro.Size = New System.Drawing.Size(223, 21)
        Me.txtRecargoSeguro.TabIndex = 29
        Me.txtRecargoSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel36
        '
        Me.KryptonLabel36.Location = New System.Drawing.Point(410, 140)
        Me.KryptonLabel36.Name = "KryptonLabel36"
        Me.KryptonLabel36.Size = New System.Drawing.Size(96, 17)
        Me.KryptonLabel36.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel36.TabIndex = 483
        Me.KryptonLabel36.Text = "Compañía Seguro"
        Me.KryptonLabel36.Values.ExtraText = ""
        Me.KryptonLabel36.Values.Image = Nothing
        Me.KryptonLabel36.Values.Text = "Compañía Seguro"
        '
        'KryptonLabel37
        '
        Me.KryptonLabel37.Location = New System.Drawing.Point(410, 190)
        Me.KryptonLabel37.Name = "KryptonLabel37"
        Me.KryptonLabel37.Size = New System.Drawing.Size(87, 17)
        Me.KryptonLabel37.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel37.TabIndex = 482
        Me.KryptonLabel37.Text = "Recargo Seguro"
        Me.KryptonLabel37.Values.ExtraText = ""
        Me.KryptonLabel37.Values.Image = Nothing
        Me.KryptonLabel37.Values.Text = "Recargo Seguro"
        '
        'KryptonLabel38
        '
        Me.KryptonLabel38.Location = New System.Drawing.Point(410, 116)
        Me.KryptonLabel38.Name = "KryptonLabel38"
        Me.KryptonLabel38.Size = New System.Drawing.Size(84, 17)
        Me.KryptonLabel38.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel38.TabIndex = 481
        Me.KryptonLabel38.Text = "Seg. Cotización"
        Me.KryptonLabel38.Values.ExtraText = ""
        Me.KryptonLabel38.Values.Image = Nothing
        Me.KryptonLabel38.Values.Text = "Seg. Cotización"
        '
        'KryptonLabel39
        '
        Me.KryptonLabel39.Location = New System.Drawing.Point(410, 165)
        Me.KryptonLabel39.Name = "KryptonLabel39"
        Me.KryptonLabel39.Size = New System.Drawing.Size(75, 17)
        Me.KryptonLabel39.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel39.TabIndex = 480
        Me.KryptonLabel39.Text = "Poliza Seguro"
        Me.KryptonLabel39.Values.ExtraText = ""
        Me.KryptonLabel39.Values.Image = Nothing
        Me.KryptonLabel39.Values.Text = "Poliza Seguro"
        '
        'KryptonLabel32
        '
        Me.KryptonLabel32.Location = New System.Drawing.Point(18, 215)
        Me.KryptonLabel32.Name = "KryptonLabel32"
        Me.KryptonLabel32.Size = New System.Drawing.Size(88, 17)
        Me.KryptonLabel32.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel32.TabIndex = 479
        Me.KryptonLabel32.Text = "Referencia Merc"
        Me.KryptonLabel32.Values.ExtraText = ""
        Me.KryptonLabel32.Values.Image = Nothing
        Me.KryptonLabel32.Values.Text = "Referencia Merc"
        '
        'KryptonLabel33
        '
        Me.KryptonLabel33.Location = New System.Drawing.Point(410, 36)
        Me.KryptonLabel33.Name = "KryptonLabel33"
        Me.KryptonLabel33.Size = New System.Drawing.Size(92, 17)
        Me.KryptonLabel33.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel33.TabIndex = 478
        Me.KryptonLabel33.Text = "Unidad Vehicular"
        Me.KryptonLabel33.Values.ExtraText = ""
        Me.KryptonLabel33.Values.Image = Nothing
        Me.KryptonLabel33.Values.Text = "Unidad Vehicular"
        '
        'KryptonLabel35
        '
        Me.KryptonLabel35.Location = New System.Drawing.Point(18, 266)
        Me.KryptonLabel35.Name = "KryptonLabel35"
        Me.KryptonLabel35.Size = New System.Drawing.Size(69, 17)
        Me.KryptonLabel35.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel35.TabIndex = 477
        Me.KryptonLabel35.Text = "Sub Servicio"
        Me.KryptonLabel35.Values.ExtraText = ""
        Me.KryptonLabel35.Values.Image = Nothing
        Me.KryptonLabel35.Values.Text = "Sub Servicio"
        '
        'txtReferenciaMercaderia
        '
        Me.txtReferenciaMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenciaMercaderia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciaMercaderia.Location = New System.Drawing.Point(145, 211)
        Me.txtReferenciaMercaderia.MaxLength = 40
        Me.txtReferenciaMercaderia.Name = "txtReferenciaMercaderia"
        Me.txtReferenciaMercaderia.Size = New System.Drawing.Size(222, 21)
        Me.txtReferenciaMercaderia.TabIndex = 20
        '
        'KryptonLabel29
        '
        Me.KryptonLabel29.Location = New System.Drawing.Point(18, 243)
        Me.KryptonLabel29.Name = "KryptonLabel29"
        Me.KryptonLabel29.Size = New System.Drawing.Size(47, 17)
        Me.KryptonLabel29.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel29.TabIndex = 476
        Me.KryptonLabel29.Text = "Servicio"
        Me.KryptonLabel29.Values.ExtraText = ""
        Me.KryptonLabel29.Values.Image = Nothing
        Me.KryptonLabel29.Values.Text = "Servicio"
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(213, 133)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(26, 19)
        Me.KryptonLabel19.TabIndex = 7
        Me.KryptonLabel19.Text = "m3"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "m3"
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(213, 111)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(48, 19)
        Me.KryptonLabel20.TabIndex = 5
        Me.KryptonLabel20.Text = "Dólares"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Dólares"
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(213, 84)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(31, 19)
        Me.KryptonLabel21.TabIndex = 3
        Me.KryptonLabel21.Text = "Kgs."
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "Kgs."
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(18, 137)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(52, 17)
        Me.KryptonLabel5.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel5.TabIndex = 475
        Me.KryptonLabel5.Text = "Volumen"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Volumen"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(18, 111)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(65, 17)
        Me.KryptonLabel7.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel7.TabIndex = 474
        Me.KryptonLabel7.Text = "Valor Merc."
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Valor Merc."
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(18, 84)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(75, 17)
        Me.KryptonLabel9.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel9.TabIndex = 473
        Me.KryptonLabel9.Text = "Peso Mercad."
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Peso Mercad."
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(18, 58)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(66, 17)
        Me.KryptonLabel11.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel11.TabIndex = 472
        Me.KryptonLabel11.Text = "Cant. Merc."
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Cant. Merc."
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(410, 90)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(75, 17)
        Me.KryptonLabel26.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel26.TabIndex = 471
        Me.KryptonLabel26.Text = "Parám. Pagar"
        Me.KryptonLabel26.Values.ExtraText = ""
        Me.KryptonLabel26.Values.Image = Nothing
        Me.KryptonLabel26.Values.Text = "Parám. Pagar"
        '
        'KryptonLabel27
        '
        Me.KryptonLabel27.Location = New System.Drawing.Point(410, 62)
        Me.KryptonLabel27.Name = "KryptonLabel27"
        Me.KryptonLabel27.Size = New System.Drawing.Size(71, 17)
        Me.KryptonLabel27.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel27.TabIndex = 470
        Me.KryptonLabel27.Text = "Param. Fact."
        Me.KryptonLabel27.Values.ExtraText = ""
        Me.KryptonLabel27.Values.Image = Nothing
        Me.KryptonLabel27.Values.Text = "Param. Fact."
        '
        'KryptonLabel28
        '
        Me.KryptonLabel28.Location = New System.Drawing.Point(18, 34)
        Me.KryptonLabel28.Name = "KryptonLabel28"
        Me.KryptonLabel28.Size = New System.Drawing.Size(63, 17)
        Me.KryptonLabel28.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.KryptonLabel28.TabIndex = 469
        Me.KryptonLabel28.Text = "Mercadería"
        Me.KryptonLabel28.Values.ExtraText = ""
        Me.KryptonLabel28.Values.Image = Nothing
        Me.KryptonLabel28.Values.Text = "Mercadería"
        '
        'txtVolumenMercaderia
        '
        Me.txtVolumenMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVolumenMercaderia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolumenMercaderia.Location = New System.Drawing.Point(145, 131)
        Me.txtVolumenMercaderia.MaxLength = 8
        Me.txtVolumenMercaderia.Name = "txtVolumenMercaderia"
        Me.txtVolumenMercaderia.Size = New System.Drawing.Size(63, 21)
        Me.txtVolumenMercaderia.TabIndex = 5
        Me.txtVolumenMercaderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorMercaderia
        '
        Me.txtValorMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorMercaderia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorMercaderia.Location = New System.Drawing.Point(145, 105)
        Me.txtValorMercaderia.MaxLength = 8
        Me.txtValorMercaderia.Name = "txtValorMercaderia"
        Me.txtValorMercaderia.Size = New System.Drawing.Size(63, 21)
        Me.txtValorMercaderia.TabIndex = 4
        Me.txtValorMercaderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.AutoSize = False
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(90, 15)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(660, 1)
        Me.KryptonBorderEdge2.TabIndex = 449
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'HeaderGroupCotizacion
        '
        Me.HeaderGroupCotizacion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnNuevoCotizacion, Me.btnGuardarCotizacion, Me.btnCancelarCotizacion})
        Me.HeaderGroupCotizacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderGroupCotizacion.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupCotizacion.Location = New System.Drawing.Point(0, 0)
        Me.HeaderGroupCotizacion.Name = "HeaderGroupCotizacion"
        '
        'HeaderGroupCotizacion.Panel
        '
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.txtCliente)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.btnBuscarCotizacion)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonBorderEdge6)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonLabel4)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.txtNrCotizacion)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonLabel6)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonBorderEdge7)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonLabel10)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonLabel3)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.cmbTipoCobro)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.txtContacto)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonLabel23)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.txtNroContrato)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonLabel24)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.txtPlantaFacturacion)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonLabel8)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonLabel14)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.cmbMoneda)
        Me.HeaderGroupCotizacion.Panel.Controls.Add(Me.KryptonLabel22)
        Me.HeaderGroupCotizacion.Size = New System.Drawing.Size(780, 192)
        Me.HeaderGroupCotizacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.HeaderGroupCotizacion.TabIndex = 391
        Me.HeaderGroupCotizacion.Text = "Cotización"
        Me.HeaderGroupCotizacion.ValuesPrimary.Description = ""
        Me.HeaderGroupCotizacion.ValuesPrimary.Heading = "Cotización"
        Me.HeaderGroupCotizacion.ValuesPrimary.Image = Nothing
        Me.HeaderGroupCotizacion.ValuesSecondary.Description = ""
        Me.HeaderGroupCotizacion.ValuesSecondary.Heading = ""
        Me.HeaderGroupCotizacion.ValuesSecondary.Image = Nothing
        '
        'btnNuevoCotizacion
        '
        Me.btnNuevoCotizacion.ExtraText = ""
        Me.btnNuevoCotizacion.Image = My.Resources.button_ok
        Me.btnNuevoCotizacion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnNuevoCotizacion.Text = "Nuevo"
        Me.btnNuevoCotizacion.ToolTipImage = Nothing
        Me.btnNuevoCotizacion.UniqueName = "A663E168D1E849E8A663E168D1E849E8"
        '
        'btnGuardarCotizacion
        '
        Me.btnGuardarCotizacion.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.btnGuardarCotizacion.ExtraText = ""
        Me.btnGuardarCotizacion.Image = My.Resources.Resources.db_add
        Me.btnGuardarCotizacion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnGuardarCotizacion.Text = "Guardar"
        Me.btnGuardarCotizacion.ToolTipImage = Nothing
        Me.btnGuardarCotizacion.UniqueName = "4CF93B3E33D54CE34CF93B3E33D54CE3"
        '
        'btnCancelarCotizacion
        '
        Me.btnCancelarCotizacion.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.btnCancelarCotizacion.ExtraText = ""
        Me.btnCancelarCotizacion.Image = My.Resources.Resources._stop
        Me.btnCancelarCotizacion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnCancelarCotizacion.Text = "Cancelar"
        Me.btnCancelarCotizacion.ToolTipImage = Nothing
        Me.btnCancelarCotizacion.UniqueName = "9322B1E9E64E44159322B1E9E64E4415"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(144, 26)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.Size = New System.Drawing.Size(223, 21)
        Me.txtCliente.TabIndex = 425
        '
        'btnBuscarCotizacion
        '
        Me.btnBuscarCotizacion.Location = New System.Drawing.Point(330, 50)
        Me.btnBuscarCotizacion.Name = "btnBuscarCotizacion"
        Me.btnBuscarCotizacion.OverrideDefault.Back.Image = My.Resources.Resources.search
        Me.btnBuscarCotizacion.Size = New System.Drawing.Size(34, 23)
        Me.btnBuscarCotizacion.StateDisabled.Back.Image = My.Resources.Resources.search
        Me.btnBuscarCotizacion.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnBuscarCotizacion.StateNormal.Back.Image = My.Resources.Resources.search
        Me.btnBuscarCotizacion.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnBuscarCotizacion.StatePressed.Back.Image = My.Resources.Resources.search
        Me.btnBuscarCotizacion.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnBuscarCotizacion.StateTracking.Back.Image = My.Resources.Resources.search
        Me.btnBuscarCotizacion.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnBuscarCotizacion.TabIndex = 424
        Me.btnBuscarCotizacion.Values.ExtraText = ""
        Me.btnBuscarCotizacion.Values.Image = Nothing
        Me.btnBuscarCotizacion.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBuscarCotizacion.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBuscarCotizacion.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBuscarCotizacion.Values.Text = ""
        '
        'KryptonBorderEdge6
        '
        Me.KryptonBorderEdge6.Location = New System.Drawing.Point(387, 16)
        Me.KryptonBorderEdge6.Name = "KryptonBorderEdge6"
        Me.KryptonBorderEdge6.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge6.Size = New System.Drawing.Size(1, 130)
        Me.KryptonBorderEdge6.TabIndex = 423
        Me.KryptonBorderEdge6.Text = "KryptonBorderEdge6"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(393, 5)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(120, 18)
        Me.KryptonLabel4.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel4.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 164
        Me.KryptonLabel4.Text = "Detalle Cotización."
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Detalle Cotización."
        '
        'txtNrCotizacion
        '
        Me.txtNrCotizacion.Location = New System.Drawing.Point(145, 51)
        Me.txtNrCotizacion.MaxLength = 15
        Me.txtNrCotizacion.Name = "txtNrCotizacion"
        Me.txtNrCotizacion.Size = New System.Drawing.Size(183, 21)
        Me.txtNrCotizacion.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNrCotizacion.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtNrCotizacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNrCotizacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNrCotizacion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNrCotizacion.TabIndex = 0
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(14, 5)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(76, 18)
        Me.KryptonLabel6.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel6.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 164
        Me.KryptonLabel6.Text = "Cotización."
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Cotización."
        '
        'KryptonBorderEdge7
        '
        Me.KryptonBorderEdge7.AutoSize = False
        Me.KryptonBorderEdge7.Location = New System.Drawing.Point(90, 15)
        Me.KryptonBorderEdge7.Name = "KryptonBorderEdge7"
        Me.KryptonBorderEdge7.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge7.Size = New System.Drawing.Size(660, 1)
        Me.KryptonBorderEdge7.TabIndex = 161
        Me.KryptonBorderEdge7.Text = "KryptonBorderEdge2"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(395, 53)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(107, 19)
        Me.KryptonLabel10.TabIndex = 163
        Me.KryptonLabel10.Text = "Planta Facturación :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Planta Facturación :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(395, 75)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(89, 19)
        Me.KryptonLabel3.TabIndex = 162
        Me.KryptonLabel3.Text = "Tipo de cobro  :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo de cobro  :"
        '
        'cmbTipoCobro
        '
        Me.cmbTipoCobro.BackColor = System.Drawing.Color.White
        Me.cmbTipoCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCobro.Enabled = False
        Me.cmbTipoCobro.FormattingEnabled = True
        Me.cmbTipoCobro.Location = New System.Drawing.Point(525, 75)
        Me.cmbTipoCobro.Name = "cmbTipoCobro"
        Me.cmbTipoCobro.Size = New System.Drawing.Size(219, 21)
        Me.cmbTipoCobro.TabIndex = 5
        '
        'txtContacto
        '
        Me.txtContacto.Enabled = False
        Me.txtContacto.Location = New System.Drawing.Point(144, 127)
        Me.txtContacto.MaxLength = 40
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(220, 21)
        Me.txtContacto.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtContacto.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtContacto.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.TabIndex = 3
        '
        'KryptonLabel23
        '
        Me.KryptonLabel23.Location = New System.Drawing.Point(18, 77)
        Me.KryptonLabel23.Name = "KryptonLabel23"
        Me.KryptonLabel23.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel23.TabIndex = 156
        Me.KryptonLabel23.Text = "Moneda :"
        Me.KryptonLabel23.Values.ExtraText = ""
        Me.KryptonLabel23.Values.Image = Nothing
        Me.KryptonLabel23.Values.Text = "Moneda :"
        '
        'txtNroContrato
        '
        Me.txtNroContrato.Enabled = False
        Me.txtNroContrato.Location = New System.Drawing.Point(144, 103)
        Me.txtNroContrato.MaxLength = 15
        Me.txtNroContrato.Name = "txtNroContrato"
        Me.txtNroContrato.Size = New System.Drawing.Size(220, 21)
        Me.txtNroContrato.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtNroContrato.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNroContrato.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroContrato.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroContrato.TabIndex = 2
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(18, 125)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(96, 19)
        Me.KryptonLabel24.TabIndex = 158
        Me.KryptonLabel24.Text = "Contacto Cliente:"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Contacto Cliente:"
        '
        'txtPlantaFacturacion
        '
        Me.txtPlantaFacturacion.BackColor = System.Drawing.Color.White
        Me.txtPlantaFacturacion.Codigo = ""
        Me.txtPlantaFacturacion.ControlHeight = 23
        Me.txtPlantaFacturacion.ControlImage = True
        Me.txtPlantaFacturacion.ControlReadOnly = False
        Me.txtPlantaFacturacion.Descripcion = ""
        Me.txtPlantaFacturacion.DisplayColumnVisible = True
        Me.txtPlantaFacturacion.DisplayMember = ""
        Me.txtPlantaFacturacion.Enabled = False
        Me.txtPlantaFacturacion.KeyColumnWidth = 100
        Me.txtPlantaFacturacion.KeyField = ""
        Me.txtPlantaFacturacion.KeySearch = True
        Me.txtPlantaFacturacion.Location = New System.Drawing.Point(525, 46)
        Me.txtPlantaFacturacion.Name = "txtPlantaFacturacion"
        Me.txtPlantaFacturacion.Size = New System.Drawing.Size(219, 23)
        Me.txtPlantaFacturacion.TabIndex = 4
        Me.txtPlantaFacturacion.TextBackColor = System.Drawing.Color.White
        Me.txtPlantaFacturacion.TextForeColor = System.Drawing.Color.Empty
        Me.txtPlantaFacturacion.ValueColumnVisible = True
        Me.txtPlantaFacturacion.ValueColumnWidth = 600
        Me.txtPlantaFacturacion.ValueField = ""
        Me.txtPlantaFacturacion.ValueMember = ""
        Me.txtPlantaFacturacion.ValueSearch = True
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(18, 29)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(53, 19)
        Me.KryptonLabel8.TabIndex = 157
        Me.KryptonLabel8.Text = "Cliente  :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Cliente  :"
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(18, 53)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(84, 19)
        Me.KryptonLabel14.TabIndex = 157
        Me.KryptonLabel14.Text = "N° Cotización :"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "N° Cotización :"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbMoneda.Codigo = ""
        Me.cmbMoneda.ControlHeight = 23
        Me.cmbMoneda.ControlImage = True
        Me.cmbMoneda.ControlReadOnly = False
        Me.cmbMoneda.Descripcion = ""
        Me.cmbMoneda.DisplayColumnVisible = True
        Me.cmbMoneda.DisplayMember = ""
        Me.cmbMoneda.Enabled = False
        Me.cmbMoneda.KeyColumnWidth = 100
        Me.cmbMoneda.KeyField = ""
        Me.cmbMoneda.KeySearch = True
        Me.cmbMoneda.Location = New System.Drawing.Point(144, 75)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(220, 23)
        Me.cmbMoneda.TabIndex = 1
        Me.cmbMoneda.TextBackColor = System.Drawing.Color.White
        Me.cmbMoneda.TextForeColor = System.Drawing.Color.Black
        Me.cmbMoneda.ValueColumnVisible = True
        Me.cmbMoneda.ValueColumnWidth = 600
        Me.cmbMoneda.ValueField = ""
        Me.cmbMoneda.ValueMember = ""
        Me.cmbMoneda.ValueSearch = True
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(18, 101)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(73, 19)
        Me.KryptonLabel22.TabIndex = 157
        Me.KryptonLabel22.Text = "N° Contrato:"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "N° Contrato:"
        '
        'frmCrearOsManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 701)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(790, 735)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(790, 735)
        Me.Name = "frmCrearOsManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generar Orden de Servicio"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.HeaderGroupDealleCcotizacion.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupDealleCcotizacion.Panel.ResumeLayout(False)
        Me.HeaderGroupDealleCcotizacion.Panel.PerformLayout()
        CType(Me.HeaderGroupDealleCcotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupDealleCcotizacion.ResumeLayout(False)
        Me.txtTipoServicio.ResumeLayout(False)
        Me.txtMercaderia.ResumeLayout(False)
        Me.txtMercaderia.PerformLayout()
        CType(Me.txtRecargoSeguro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderGroupCotizacion.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupCotizacion.Panel.ResumeLayout(False)
        Me.HeaderGroupCotizacion.Panel.PerformLayout()
        CType(Me.HeaderGroupCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupCotizacion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents HeaderGroupDealleCcotizacion As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtLocalidadDestino As CodeTextBox.CodeTextBox
    Friend WithEvents txtLocalidadOrigen As CodeTextBox.CodeTextBox
    Friend WithEvents txtMonedaLiquidacionTransportista As CodeTextBox.CodeTextBox
    Friend WithEvents txtUnidadServicioAdicional As CodeTextBox.CodeTextBox
    Friend WithEvents txtServicioCotizacion As CodeTextBox.CodeTextBox
    Friend WithEvents txtImportePagarTransportista As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel56 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDistancia As System.Windows.Forms.TextBox
    Friend WithEvents txtMonedaLiquidacion As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel46 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblLocalidadDestino As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblLocalidadOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCostoPorTonelada As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel48 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel52 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDistanciaKM As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTarifaServicio As System.Windows.Forms.TextBox
    Friend WithEvents lblDetraccion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge3 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge5 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents txtCiaSeguro As CodeTextBox.CodeTextBox
    Friend WithEvents txtSeguroCotizacion As CodeTextBox.CodeTextBox
    Friend WithEvents txtUnidadVehicular As CodeTextBox.CodeTextBox
    Friend WithEvents txtTipoSubServicio As CodeTextBox.CodeTextBox
    Friend WithEvents txtTipoServicio As CodeTextBox.CodeTextBox
    Friend WithEvents CodeTextBox2 As CodeTextBox.CodeTextBox
    Friend WithEvents txtUnidadMedida As CodeTextBox.CodeTextBox
    Friend WithEvents txtParametroPagar As CodeTextBox.CodeTextBox
    Friend WithEvents txtParametroFacturacion As CodeTextBox.CodeTextBox
    Friend WithEvents txtMercaderia As CodeTextBox.CodeTextBox
    Friend WithEvents CodeTextBox1 As CodeTextBox.CodeTextBox
    Friend WithEvents txtPesoMercaderia As System.Windows.Forms.TextBox
    Friend WithEvents txtPolizaSeguro As System.Windows.Forms.TextBox
    Friend WithEvents txtRecargoSeguro As System.Windows.Forms.NumericUpDown
    Friend WithEvents KryptonLabel36 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel37 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel38 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel39 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel33 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel35 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtReferenciaMercaderia As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtVolumenMercaderia As System.Windows.Forms.TextBox
    Friend WithEvents txtValorMercaderia As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadMercaderia As System.Windows.Forms.TextBox
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents HeaderGroupCotizacion As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnNuevoCotizacion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnGuardarCotizacion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelarCotizacion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonBorderEdge6 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNrCotizacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge7 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipoCobro As System.Windows.Forms.ComboBox
    Friend WithEvents txtContacto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroContrato As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlantaFacturacion As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbMoneda As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnBuscarCotizacion As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
