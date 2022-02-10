<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionFactura
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
        Dim BePlanta1 As Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta = New Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcionFactura))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.panelOpcion = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.groupElegir = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.gpbMoneda = New System.Windows.Forms.GroupBox
        Me.rbtnDolares = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtnSoles = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.gpbTipoDocumento = New System.Windows.Forms.GroupBox
        Me.rbtnFactura = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtnPreFactura = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.txtOrganizacionVenta = New System.Windows.Forms.TextBox
        Me.txtPreFactura = New System.Windows.Forms.TextBox
        Me.txtOperacion = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtNIT = New System.Windows.Forms.TextBox
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.cboTipoFactura = New System.Windows.Forms.ComboBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbPlanta = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkFechaServicio = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.dtpFechaServicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaFactura = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOrgVenta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboZonaFacturacion = New CodeTextBox.CodeTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblPreFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblNIT = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDireccion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.Separador = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        CType(Me.panelOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOpcion.SuspendLayout()
        CType(Me.groupElegir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupElegir.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupElegir.Panel.SuspendLayout()
        Me.groupElegir.SuspendLayout()
        Me.gpbMoneda.SuspendLayout()
        Me.gpbTipoDocumento.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelOpcion
        '
        Me.panelOpcion.Controls.Add(Me.groupElegir)
        Me.panelOpcion.Controls.Add(Me.MenuBar)
        Me.panelOpcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOpcion.Location = New System.Drawing.Point(0, 0)
        Me.panelOpcion.Name = "panelOpcion"
        Me.panelOpcion.Size = New System.Drawing.Size(468, 390)
        Me.panelOpcion.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelOpcion.TabIndex = 2
        '
        'groupElegir
        '
        Me.groupElegir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupElegir.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.groupElegir.Location = New System.Drawing.Point(0, 25)
        Me.groupElegir.Name = "groupElegir"
        Me.groupElegir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'groupElegir.Panel
        '
        Me.groupElegir.Panel.Controls.Add(Me.gpbMoneda)
        Me.groupElegir.Panel.Controls.Add(Me.gpbTipoDocumento)
        Me.groupElegir.Panel.Controls.Add(Me.txtOrganizacionVenta)
        Me.groupElegir.Panel.Controls.Add(Me.txtPreFactura)
        Me.groupElegir.Panel.Controls.Add(Me.txtOperacion)
        Me.groupElegir.Panel.Controls.Add(Me.txtDireccion)
        Me.groupElegir.Panel.Controls.Add(Me.txtNIT)
        Me.groupElegir.Panel.Controls.Add(Me.txtCliente)
        Me.groupElegir.Panel.Controls.Add(Me.cboTipoFactura)
        Me.groupElegir.Panel.Controls.Add(Me.KryptonLabel1)
        Me.groupElegir.Panel.Controls.Add(Me.cmbPlanta)
        Me.groupElegir.Panel.Controls.Add(Me.KryptonLabel6)
        Me.groupElegir.Panel.Controls.Add(Me.chkFechaServicio)
        Me.groupElegir.Panel.Controls.Add(Me.dtpFechaServicio)
        Me.groupElegir.Panel.Controls.Add(Me.dtpFechaFactura)
        Me.groupElegir.Panel.Controls.Add(Me.lblFechaFactura)
        Me.groupElegir.Panel.Controls.Add(Me.lblOrgVenta)
        Me.groupElegir.Panel.Controls.Add(Me.cboZonaFacturacion)
        Me.groupElegir.Panel.Controls.Add(Me.KryptonLabel3)
        Me.groupElegir.Panel.Controls.Add(Me.lblPreFactura)
        Me.groupElegir.Panel.Controls.Add(Me.lblOperacion)
        Me.groupElegir.Panel.Controls.Add(Me.lblNIT)
        Me.groupElegir.Panel.Controls.Add(Me.lblDireccion)
        Me.groupElegir.Panel.Controls.Add(Me.lblCliente)
        Me.groupElegir.Panel.Controls.Add(Me.btnCerrar)
        Me.groupElegir.Size = New System.Drawing.Size(468, 365)
        Me.groupElegir.TabIndex = 426
        '
        'gpbMoneda
        '
        Me.gpbMoneda.BackColor = System.Drawing.Color.Transparent
        Me.gpbMoneda.Controls.Add(Me.rbtnDolares)
        Me.gpbMoneda.Controls.Add(Me.rbtnSoles)
        Me.gpbMoneda.Enabled = False
        Me.gpbMoneda.Location = New System.Drawing.Point(304, 295)
        Me.gpbMoneda.Name = "gpbMoneda"
        Me.gpbMoneda.Size = New System.Drawing.Size(144, 50)
        Me.gpbMoneda.TabIndex = 81
        Me.gpbMoneda.TabStop = False
        Me.gpbMoneda.Text = "Moneda"
        '
        'rbtnDolares
        '
        Me.rbtnDolares.Location = New System.Drawing.Point(70, 20)
        Me.rbtnDolares.Name = "rbtnDolares"
        Me.rbtnDolares.Size = New System.Drawing.Size(65, 22)
        Me.rbtnDolares.TabIndex = 2
        Me.rbtnDolares.Text = "Dólares"
        Me.rbtnDolares.Values.ExtraText = ""
        Me.rbtnDolares.Values.Image = Nothing
        Me.rbtnDolares.Values.Text = "Dólares"
        '
        'rbtnSoles
        '
        Me.rbtnSoles.Checked = True
        Me.rbtnSoles.Location = New System.Drawing.Point(8, 20)
        Me.rbtnSoles.Name = "rbtnSoles"
        Me.rbtnSoles.Size = New System.Drawing.Size(52, 22)
        Me.rbtnSoles.TabIndex = 1
        Me.rbtnSoles.Text = "Soles"
        Me.rbtnSoles.Values.ExtraText = ""
        Me.rbtnSoles.Values.Image = Nothing
        Me.rbtnSoles.Values.Text = "Soles"
        '
        'gpbTipoDocumento
        '
        Me.gpbTipoDocumento.BackColor = System.Drawing.Color.Transparent
        Me.gpbTipoDocumento.Controls.Add(Me.rbtnFactura)
        Me.gpbTipoDocumento.Controls.Add(Me.rbtnPreFactura)
        Me.gpbTipoDocumento.Location = New System.Drawing.Point(121, 295)
        Me.gpbTipoDocumento.Name = "gpbTipoDocumento"
        Me.gpbTipoDocumento.Size = New System.Drawing.Size(178, 50)
        Me.gpbTipoDocumento.TabIndex = 80
        Me.gpbTipoDocumento.TabStop = False
        Me.gpbTipoDocumento.Text = "Operación"
        '
        'rbtnFactura
        '
        Me.rbtnFactura.Location = New System.Drawing.Point(93, 19)
        Me.rbtnFactura.Name = "rbtnFactura"
        Me.rbtnFactura.Size = New System.Drawing.Size(86, 22)
        Me.rbtnFactura.TabIndex = 1
        Me.rbtnFactura.Text = "Facturación"
        Me.rbtnFactura.Values.ExtraText = ""
        Me.rbtnFactura.Values.Image = Nothing
        Me.rbtnFactura.Values.Text = "Facturación"
        '
        'rbtnPreFactura
        '
        Me.rbtnPreFactura.Checked = True
        Me.rbtnPreFactura.Location = New System.Drawing.Point(6, 19)
        Me.rbtnPreFactura.Name = "rbtnPreFactura"
        Me.rbtnPreFactura.Size = New System.Drawing.Size(86, 22)
        Me.rbtnPreFactura.TabIndex = 0
        Me.rbtnPreFactura.Text = "Pre-Factura"
        Me.rbtnPreFactura.Values.ExtraText = ""
        Me.rbtnPreFactura.Values.Image = Nothing
        Me.rbtnPreFactura.Values.Text = "Pre-Factura"
        '
        'txtOrganizacionVenta
        '
        Me.txtOrganizacionVenta.Enabled = False
        Me.txtOrganizacionVenta.Location = New System.Drawing.Point(120, 155)
        Me.txtOrganizacionVenta.Name = "txtOrganizacionVenta"
        Me.txtOrganizacionVenta.Size = New System.Drawing.Size(230, 20)
        Me.txtOrganizacionVenta.TabIndex = 79
        '
        'txtPreFactura
        '
        Me.txtPreFactura.Enabled = False
        Me.txtPreFactura.Location = New System.Drawing.Point(120, 126)
        Me.txtPreFactura.Name = "txtPreFactura"
        Me.txtPreFactura.Size = New System.Drawing.Size(105, 20)
        Me.txtPreFactura.TabIndex = 78
        '
        'txtOperacion
        '
        Me.txtOperacion.Enabled = False
        Me.txtOperacion.Location = New System.Drawing.Point(120, 95)
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.Size = New System.Drawing.Size(328, 20)
        Me.txtOperacion.TabIndex = 77
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(120, 65)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(328, 20)
        Me.txtDireccion.TabIndex = 76
        '
        'txtNIT
        '
        Me.txtNIT.Enabled = False
        Me.txtNIT.Location = New System.Drawing.Point(120, 35)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Size = New System.Drawing.Size(105, 20)
        Me.txtNIT.TabIndex = 75
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(120, 7)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(328, 20)
        Me.txtCliente.TabIndex = 74
        '
        'cboTipoFactura
        '
        Me.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoFactura.FormattingEnabled = True
        Me.cboTipoFactura.Location = New System.Drawing.Point(120, 239)
        Me.cboTipoFactura.Name = "cboTipoFactura"
        Me.cboTipoFactura.Size = New System.Drawing.Size(230, 21)
        Me.cboTipoFactura.TabIndex = 73
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 240)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(80, 20)
        Me.KryptonLabel1.TabIndex = 72
        Me.KryptonLabel1.Text = "Tipo Factura:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tipo Factura:"
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.Transparent
        Me.cmbPlanta.CodigoCompania = ""
        Me.cmbPlanta.CodigoDivision = ""
        Me.cmbPlanta.CPLNDV_ANTERIOR = Nothing
        Me.cmbPlanta.DescripcionPlanta = ""
        Me.cmbPlanta.ItemTodos = False
        Me.cmbPlanta.Location = New System.Drawing.Point(120, 181)
        Me.cmbPlanta.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbPlanta.Name = "cmbPlanta"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.cmbPlanta.obePlanta = BePlanta1
        Me.cmbPlanta.pHabilitado = True
        Me.cmbPlanta.Planta = 0
        Me.cmbPlanta.PlantaDefault = -1
        Me.cmbPlanta.pRequerido = False
        Me.cmbPlanta.Size = New System.Drawing.Size(230, 23)
        Me.cmbPlanta.TabIndex = 71
        Me.cmbPlanta.Usuario = ""
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(4, 185)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(104, 20)
        Me.KryptonLabel6.TabIndex = 70
        Me.KryptonLabel6.Text = "Planta a Facturar:"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Planta a Facturar:"
        '
        'chkFechaServicio
        '
        Me.chkFechaServicio.Checked = False
        Me.chkFechaServicio.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkFechaServicio.Location = New System.Drawing.Point(235, 271)
        Me.chkFechaServicio.Name = "chkFechaServicio"
        Me.chkFechaServicio.Size = New System.Drawing.Size(101, 20)
        Me.chkFechaServicio.TabIndex = 69
        Me.chkFechaServicio.Text = "Fecha Servicio"
        Me.chkFechaServicio.Values.ExtraText = ""
        Me.chkFechaServicio.Values.Image = Nothing
        Me.chkFechaServicio.Values.Text = "Fecha Servicio"
        Me.chkFechaServicio.Visible = False
        '
        'dtpFechaServicio
        '
        Me.dtpFechaServicio.Enabled = False
        Me.dtpFechaServicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaServicio.Location = New System.Drawing.Point(358, 270)
        Me.dtpFechaServicio.Name = "dtpFechaServicio"
        Me.dtpFechaServicio.Size = New System.Drawing.Size(90, 20)
        Me.dtpFechaServicio.TabIndex = 68
        Me.dtpFechaServicio.Visible = False
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(120, 270)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(95, 20)
        Me.dtpFechaFactura.TabIndex = 27
        Me.dtpFechaFactura.Visible = False
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.Location = New System.Drawing.Point(4, 271)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(108, 20)
        Me.lblFechaFactura.TabIndex = 26
        Me.lblFechaFactura.Text = "Fecha Facturación"
        Me.lblFechaFactura.Values.ExtraText = ""
        Me.lblFechaFactura.Values.Image = Nothing
        Me.lblFechaFactura.Values.Text = "Fecha Facturación"
        Me.lblFechaFactura.Visible = False
        '
        'lblOrgVenta
        '
        Me.lblOrgVenta.Location = New System.Drawing.Point(4, 156)
        Me.lblOrgVenta.Name = "lblOrgVenta"
        Me.lblOrgVenta.Size = New System.Drawing.Size(120, 20)
        Me.lblOrgVenta.TabIndex = 24
        Me.lblOrgVenta.Text = "Organización Venta:"
        Me.lblOrgVenta.Values.ExtraText = ""
        Me.lblOrgVenta.Values.Image = Nothing
        Me.lblOrgVenta.Values.Text = "Organización Venta:"
        '
        'cboZonaFacturacion
        '
        Me.cboZonaFacturacion.BackColor = System.Drawing.Color.White
        Me.cboZonaFacturacion.Codigo = ""
        Me.cboZonaFacturacion.ControlHeight = 23
        Me.cboZonaFacturacion.ControlImage = True
        Me.cboZonaFacturacion.ControlReadOnly = False
        Me.cboZonaFacturacion.Descripcion = ""
        Me.cboZonaFacturacion.DisplayColumnVisible = True
        Me.cboZonaFacturacion.DisplayMember = ""
        Me.cboZonaFacturacion.KeyColumnWidth = 100
        Me.cboZonaFacturacion.KeyField = ""
        Me.cboZonaFacturacion.KeySearch = True
        Me.cboZonaFacturacion.Location = New System.Drawing.Point(120, 208)
        Me.cboZonaFacturacion.Name = "cboZonaFacturacion"
        Me.cboZonaFacturacion.Size = New System.Drawing.Size(230, 23)
        Me.cboZonaFacturacion.TabIndex = 23
        Me.cboZonaFacturacion.TextBackColor = System.Drawing.Color.Empty
        Me.cboZonaFacturacion.TextForeColor = System.Drawing.Color.Empty
        Me.cboZonaFacturacion.ValueColumnVisible = True
        Me.cboZonaFacturacion.ValueColumnWidth = 600
        Me.cboZonaFacturacion.ValueField = ""
        Me.cboZonaFacturacion.ValueMember = ""
        Me.cboZonaFacturacion.ValueSearch = True
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(4, 212)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(98, 20)
        Me.KryptonLabel3.TabIndex = 22
        Me.KryptonLabel3.Text = "Zona a Facturar:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Zona a Facturar:"
        '
        'lblPreFactura
        '
        Me.lblPreFactura.Location = New System.Drawing.Point(4, 127)
        Me.lblPreFactura.Name = "lblPreFactura"
        Me.lblPreFactura.Size = New System.Drawing.Size(100, 20)
        Me.lblPreFactura.TabIndex = 19
        Me.lblPreFactura.Text = "N° Pre - Factura:"
        Me.lblPreFactura.Values.ExtraText = ""
        Me.lblPreFactura.Values.Image = Nothing
        Me.lblPreFactura.Values.Text = "N° Pre - Factura:"
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(4, 96)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(87, 20)
        Me.lblOperacion.TabIndex = 18
        Me.lblOperacion.Text = "N° Operación:"
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación:"
        '
        'lblNIT
        '
        Me.lblNIT.Location = New System.Drawing.Point(4, 36)
        Me.lblNIT.Name = "lblNIT"
        Me.lblNIT.Size = New System.Drawing.Size(60, 20)
        Me.lblNIT.TabIndex = 15
        Me.lblNIT.Text = "N°  N I T:"
        Me.lblNIT.Values.ExtraText = ""
        Me.lblNIT.Values.Image = Nothing
        Me.lblNIT.Values.Text = "N°  N I T:"
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(4, 66)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(64, 20)
        Me.lblDireccion.TabIndex = 13
        Me.lblDireccion.Text = "Dirección:"
        Me.lblDireccion.Values.ExtraText = ""
        Me.lblDireccion.Values.Image = Nothing
        Me.lblDireccion.Values.Text = "Dirección:"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(4, 8)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(51, 20)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente:"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente:"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(40, -32)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(8, 25)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "."
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "."
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separador, Me.btnAceptar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(468, 25)
        Me.MenuBar.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'Separador
        '
        Me.Separador.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separador.Name = "Separador"
        Me.Separador.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmOpcionFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelOpcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOpcionFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " FACTURACIÓN"
        CType(Me.panelOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOpcion.ResumeLayout(False)
        Me.panelOpcion.PerformLayout()
        CType(Me.groupElegir.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupElegir.Panel.ResumeLayout(False)
        Me.groupElegir.Panel.PerformLayout()
        CType(Me.groupElegir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupElegir.ResumeLayout(False)
        Me.gpbMoneda.ResumeLayout(False)
        Me.gpbMoneda.PerformLayout()
        Me.gpbTipoDocumento.ResumeLayout(False)
        Me.gpbTipoDocumento.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
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
    Friend WithEvents panelOpcion As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents groupElegir As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblNIT As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDireccion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPreFactura As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboZonaFacturacion As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOrgVenta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaFactura As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFechaServicio As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dtpFechaServicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtNIT As System.Windows.Forms.TextBox
    Friend WithEvents txtOrganizacionVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtPreFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtOperacion As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents gpbMoneda As System.Windows.Forms.GroupBox
    Friend WithEvents gpbTipoDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnDolares As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnSoles As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnFactura As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnPreFactura As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
End Class
