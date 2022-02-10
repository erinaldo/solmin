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
        Me.components = New System.ComponentModel.Container()
        Dim BePlanta2 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcionFactura))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.panelOpcion = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.groupElegir = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.cmbPlanta = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.ucAprobador = New Ransa.Utilitario.ucAyuda()
        Me.gpbMoneda = New System.Windows.Forms.GroupBox()
        Me.rbtnDolares = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtnSoles = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.gpbTipoDocumento = New System.Windows.Forms.GroupBox()
        Me.rbtnFactura = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtnPreFactura = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.txtOrganizacionVenta = New System.Windows.Forms.TextBox()
        Me.txtPreFactura = New System.Windows.Forms.TextBox()
        Me.txtOperacion = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.cboTipoFactura = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblOrgVenta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboZonaFacturacion = New CodeTextBox.CodeTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPreFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Separador = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
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
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'panelOpcion
        '
        Me.panelOpcion.Controls.Add(Me.groupElegir)
        Me.panelOpcion.Controls.Add(Me.MenuBar)
        Me.panelOpcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOpcion.Location = New System.Drawing.Point(0, 0)
        Me.panelOpcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelOpcion.Name = "panelOpcion"
        Me.panelOpcion.Size = New System.Drawing.Size(624, 447)
        Me.panelOpcion.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelOpcion.TabIndex = 2
        '
        'groupElegir
        '
        Me.groupElegir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupElegir.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.groupElegir.Location = New System.Drawing.Point(0, 27)
        Me.groupElegir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupElegir.Name = "groupElegir"
        Me.groupElegir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'groupElegir.Panel
        '
        Me.groupElegir.Panel.Controls.Add(Me.cmbPlanta)
        Me.groupElegir.Panel.Controls.Add(Me.ucAprobador)
        Me.groupElegir.Panel.Controls.Add(Me.gpbMoneda)
        Me.groupElegir.Panel.Controls.Add(Me.gpbTipoDocumento)
        Me.groupElegir.Panel.Controls.Add(Me.txtOrganizacionVenta)
        Me.groupElegir.Panel.Controls.Add(Me.txtPreFactura)
        Me.groupElegir.Panel.Controls.Add(Me.txtOperacion)
        Me.groupElegir.Panel.Controls.Add(Me.txtCliente)
        Me.groupElegir.Panel.Controls.Add(Me.cboTipoFactura)
        Me.groupElegir.Panel.Controls.Add(Me.KryptonLabel1)
        Me.groupElegir.Panel.Controls.Add(Me.KryptonLabel2)
        Me.groupElegir.Panel.Controls.Add(Me.lblOrgVenta)
        Me.groupElegir.Panel.Controls.Add(Me.cboZonaFacturacion)
        Me.groupElegir.Panel.Controls.Add(Me.KryptonLabel3)
        Me.groupElegir.Panel.Controls.Add(Me.lblPreFactura)
        Me.groupElegir.Panel.Controls.Add(Me.lblOperacion)
        Me.groupElegir.Panel.Controls.Add(Me.lblCliente)
        Me.groupElegir.Panel.Controls.Add(Me.btnCerrar)
        Me.groupElegir.Panel.Controls.Add(Me.KryptonLabel6)
        Me.groupElegir.Size = New System.Drawing.Size(624, 420)
        Me.groupElegir.TabIndex = 426
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.Transparent
        Me.cmbPlanta.CodigoCompania = ""
        Me.cmbPlanta.CodigoDivision = ""
        Me.cmbPlanta.CodSedeSAP = ""
        Me.cmbPlanta.CPLNDV_ANTERIOR = Nothing
        Me.cmbPlanta.DescripcionPlanta = ""
        Me.cmbPlanta.ItemTodos = False
        Me.cmbPlanta.Location = New System.Drawing.Point(160, 151)
        Me.cmbPlanta.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmbPlanta.MinimumSize = New System.Drawing.Size(200, 26)
        Me.cmbPlanta.Name = "cmbPlanta"
        BePlanta2.CCMPN_CodigoCompania = ""
        BePlanta2.CDSPSP_CodSedeSAP = Nothing
        BePlanta2.CDVSN_CodigoDivision = ""
        BePlanta2.CPLNDV_CodigoPlanta = 0.0R
        BePlanta2.Orden = -1
        BePlanta2.TPLNTA_DescripcionPlanta = ""
        Me.cmbPlanta.obePlanta = BePlanta2
        Me.cmbPlanta.pHabilitado = True
        Me.cmbPlanta.Planta = 0.0R
        Me.cmbPlanta.PlantaDefault = -1.0R
        Me.cmbPlanta.pRequerido = False
        Me.cmbPlanta.Size = New System.Drawing.Size(307, 28)
        Me.cmbPlanta.TabIndex = 71
        Me.cmbPlanta.Usuario = ""
        '
        'ucAprobador
        '
        Me.ucAprobador.BackColor = System.Drawing.Color.Transparent
        Me.ucAprobador.DataSource = Nothing
        Me.ucAprobador.DispleyMember = ""
        Me.ucAprobador.Etiquetas_Form = Nothing
        Me.ucAprobador.ListColumnas = Nothing
        Me.ucAprobador.Location = New System.Drawing.Point(160, 255)
        Me.ucAprobador.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucAprobador.Name = "ucAprobador"
        Me.ucAprobador.Obligatorio = False
        Me.ucAprobador.PopupHeight = 0
        Me.ucAprobador.PopupWidth = 0
        Me.ucAprobador.Size = New System.Drawing.Size(408, 34)
        Me.ucAprobador.SizeFont = 0
        Me.ucAprobador.TabIndex = 82
        Me.ucAprobador.ValueMember = ""
        '
        'gpbMoneda
        '
        Me.gpbMoneda.BackColor = System.Drawing.Color.Transparent
        Me.gpbMoneda.Controls.Add(Me.rbtnDolares)
        Me.gpbMoneda.Controls.Add(Me.rbtnSoles)
        Me.gpbMoneda.Enabled = False
        Me.gpbMoneda.Location = New System.Drawing.Point(393, 289)
        Me.gpbMoneda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbMoneda.Name = "gpbMoneda"
        Me.gpbMoneda.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbMoneda.Size = New System.Drawing.Size(192, 62)
        Me.gpbMoneda.TabIndex = 81
        Me.gpbMoneda.TabStop = False
        Me.gpbMoneda.Text = "Moneda"
        '
        'rbtnDolares
        '
        Me.rbtnDolares.Location = New System.Drawing.Point(93, 25)
        Me.rbtnDolares.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnDolares.Name = "rbtnDolares"
        Me.rbtnDolares.Size = New System.Drawing.Size(79, 26)
        Me.rbtnDolares.TabIndex = 2
        Me.rbtnDolares.Text = "Dólares"
        Me.rbtnDolares.Values.ExtraText = ""
        Me.rbtnDolares.Values.Image = Nothing
        Me.rbtnDolares.Values.Text = "Dólares"
        '
        'rbtnSoles
        '
        Me.rbtnSoles.Checked = True
        Me.rbtnSoles.Location = New System.Drawing.Point(11, 25)
        Me.rbtnSoles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnSoles.Name = "rbtnSoles"
        Me.rbtnSoles.Size = New System.Drawing.Size(63, 26)
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
        Me.gpbTipoDocumento.Location = New System.Drawing.Point(149, 289)
        Me.gpbTipoDocumento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbTipoDocumento.Name = "gpbTipoDocumento"
        Me.gpbTipoDocumento.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbTipoDocumento.Size = New System.Drawing.Size(237, 62)
        Me.gpbTipoDocumento.TabIndex = 80
        Me.gpbTipoDocumento.TabStop = False
        Me.gpbTipoDocumento.Text = "Operación"
        '
        'rbtnFactura
        '
        Me.rbtnFactura.Location = New System.Drawing.Point(124, 23)
        Me.rbtnFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnFactura.Name = "rbtnFactura"
        Me.rbtnFactura.Size = New System.Drawing.Size(106, 26)
        Me.rbtnFactura.TabIndex = 1
        Me.rbtnFactura.Text = "Facturación"
        Me.rbtnFactura.Values.ExtraText = ""
        Me.rbtnFactura.Values.Image = Nothing
        Me.rbtnFactura.Values.Text = "Facturación"
        '
        'rbtnPreFactura
        '
        Me.rbtnPreFactura.Checked = True
        Me.rbtnPreFactura.Location = New System.Drawing.Point(8, 23)
        Me.rbtnPreFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnPreFactura.Name = "rbtnPreFactura"
        Me.rbtnPreFactura.Size = New System.Drawing.Size(106, 26)
        Me.rbtnPreFactura.TabIndex = 0
        Me.rbtnPreFactura.Text = "Pre-Factura"
        Me.rbtnPreFactura.Values.ExtraText = ""
        Me.rbtnPreFactura.Values.Image = Nothing
        Me.rbtnPreFactura.Values.Text = "Pre-Factura"
        '
        'txtOrganizacionVenta
        '
        Me.txtOrganizacionVenta.Enabled = False
        Me.txtOrganizacionVenta.Location = New System.Drawing.Point(160, 119)
        Me.txtOrganizacionVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOrganizacionVenta.Name = "txtOrganizacionVenta"
        Me.txtOrganizacionVenta.Size = New System.Drawing.Size(305, 22)
        Me.txtOrganizacionVenta.TabIndex = 79
        '
        'txtPreFactura
        '
        Me.txtPreFactura.Enabled = False
        Me.txtPreFactura.Location = New System.Drawing.Point(160, 83)
        Me.txtPreFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPreFactura.Name = "txtPreFactura"
        Me.txtPreFactura.Size = New System.Drawing.Size(139, 22)
        Me.txtPreFactura.TabIndex = 78
        '
        'txtOperacion
        '
        Me.txtOperacion.Enabled = False
        Me.txtOperacion.Location = New System.Drawing.Point(160, 45)
        Me.txtOperacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.Size = New System.Drawing.Size(436, 22)
        Me.txtOperacion.TabIndex = 77
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(160, 9)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(436, 22)
        Me.txtCliente.TabIndex = 74
        '
        'cboTipoFactura
        '
        Me.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoFactura.FormattingEnabled = True
        Me.cboTipoFactura.Location = New System.Drawing.Point(160, 222)
        Me.cboTipoFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTipoFactura.Name = "cboTipoFactura"
        Me.cboTipoFactura.Size = New System.Drawing.Size(305, 24)
        Me.cboTipoFactura.TabIndex = 73
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 223)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(99, 26)
        Me.KryptonLabel1.TabIndex = 72
        Me.KryptonLabel1.Text = "Tipo Factura:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tipo Factura:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(5, 258)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(91, 26)
        Me.KryptonLabel2.TabIndex = 26
        Me.KryptonLabel2.Text = "Aprobación"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Aprobación"
        '
        'lblOrgVenta
        '
        Me.lblOrgVenta.Location = New System.Drawing.Point(5, 120)
        Me.lblOrgVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblOrgVenta.Name = "lblOrgVenta"
        Me.lblOrgVenta.Size = New System.Drawing.Size(130, 26)
        Me.lblOrgVenta.TabIndex = 24
        Me.lblOrgVenta.Text = "Negocio / Sector:"
        Me.lblOrgVenta.Values.ExtraText = ""
        Me.lblOrgVenta.Values.Image = Nothing
        Me.lblOrgVenta.Values.Text = "Negocio / Sector:"
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
        Me.cboZonaFacturacion.Location = New System.Drawing.Point(160, 184)
        Me.cboZonaFacturacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboZonaFacturacion.Name = "cboZonaFacturacion"
        Me.cboZonaFacturacion.Size = New System.Drawing.Size(307, 23)
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
        Me.KryptonLabel3.Location = New System.Drawing.Point(5, 189)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(121, 26)
        Me.KryptonLabel3.TabIndex = 22
        Me.KryptonLabel3.Text = "Zona a Facturar:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Zona a Facturar:"
        '
        'lblPreFactura
        '
        Me.lblPreFactura.Location = New System.Drawing.Point(5, 84)
        Me.lblPreFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPreFactura.Name = "lblPreFactura"
        Me.lblPreFactura.Size = New System.Drawing.Size(123, 26)
        Me.lblPreFactura.TabIndex = 19
        Me.lblPreFactura.Text = "N° Pre - Factura:"
        Me.lblPreFactura.Values.ExtraText = ""
        Me.lblPreFactura.Values.Image = Nothing
        Me.lblPreFactura.Values.Text = "N° Pre - Factura:"
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(5, 46)
        Me.lblOperacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(107, 26)
        Me.lblOperacion.TabIndex = 18
        Me.lblOperacion.Text = "N° Operación:"
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "N° Operación:"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(5, 10)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(62, 26)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente:"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente:"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(53, -39)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(11, 31)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "."
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "."
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(5, 156)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(149, 26)
        Me.KryptonLabel6.TabIndex = 70
        Me.KryptonLabel6.Text = "Planta Fact/Pre Fact:"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Planta Fact/Pre Fact:"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separador, Me.btnAceptar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(624, 27)
        Me.MenuBar.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'Separador
        '
        Me.Separador.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separador.Name = "Separador"
        Me.Separador.Size = New System.Drawing.Size(6, 27)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 24)
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmOpcionFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelOpcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPreFactura As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboZonaFacturacion As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOrgVenta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtOrganizacionVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtPreFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtOperacion As System.Windows.Forms.TextBox
    Friend WithEvents gpbMoneda As System.Windows.Forms.GroupBox
    Friend WithEvents gpbTipoDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnDolares As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnSoles As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnFactura As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnPreFactura As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents ucAprobador As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
