<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuiaTransportePasajero
  Inherits System.Windows.Forms.UserControl

  'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuiaTransportePasajero))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonRadioButton3 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.KryptonRadioButton4 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.panelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonHeaderCabecera = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtPlanta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNroOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.panelInformacion = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.TabMantenimiento = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.HGGuiaRemisionAsignada = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.panelRemisionAdicional = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dtgGuiasSeleccionadas = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.SELECCIONA = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.NMBPER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPRGVJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FSLDRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HSLDRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRRRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRRIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuBar_1 = New System.Windows.Forms.ToolStrip()
        Me.lblNumeroGuias = New System.Windows.Forms.ToolStripLabel()
        Me.btnAsignarPasajero = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnQuitarElemento = New System.Windows.Forms.ToolStripButton()
        Me.KryptonHeaderDetalle = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtUnidadMed = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtMonFlete = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtOrdenEmbarcador = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtpFecGuiaETA = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecGuiaETD = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel46 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnConfigTracto = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtConductor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTracto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTransportista = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.checkGenerar = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtNroPlaneamiento = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.grpBoxConsignatario = New System.Windows.Forms.GroupBox()
        Me.UcCNomConsignatario = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.txtNomConsignatario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel33 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDirConsignatario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroDocConsignatario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel31 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.rbtnRUCConsignatario = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtnDNIConsignatario = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.chkCliente = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.grpBoxRemitente = New System.Windows.Forms.GroupBox()
        Me.UcCNomRemitente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.KryptonLabel37 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel36 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel35 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDirRemitente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.rbtnRUCRemit = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtnDNIRemit = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.txtNroDocRemitente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel34 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtObservación = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonGroup9 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.rbtnIdaVuelta = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtnIda = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.chkMercPeligrosa = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonGroup8 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.rbtnDestinatario = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtnRemitente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.chkMercPerecible = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.cboMonedaValorPatr = New CodeTextBox.CodeTextBox()
        Me.txtPesoBruto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtPesoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtCostoTramo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtVolumenRemision = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtValorPatrimonio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtKmPorRecorrer = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel38 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboDestinoUbigeo = New CodeTextBox.CodeTextBox()
        Me.cboOrigenUbigeo = New CodeTextBox.CodeTextBox()
        Me.txtLugar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroHojaGuia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.dtpFecGuia = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecIniTrans = New System.Windows.Forms.DateTimePicker()
        Me.cboLugarDestino = New CodeTextBox.CodeTextBox()
        Me.cboLugarOrigen = New CodeTextBox.CodeTextBox()
        Me.txtGalsDiesel = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtCantMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtGalsGasolina = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtDirDestino = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtDirOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNroRemision = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsSeparador_4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.KryptonBorderEdge5 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.txtConfigTracto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel50 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel48 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel49 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel39 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.panelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFiltros.SuspendLayout()
        CType(Me.KryptonHeaderCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderCabecera.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderCabecera.Panel.SuspendLayout()
        Me.KryptonHeaderCabecera.SuspendLayout()
        CType(Me.panelInformacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInformacion.SuspendLayout()
        Me.TabMantenimiento.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        CType(Me.HGGuiaRemisionAsignada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGGuiaRemisionAsignada.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGGuiaRemisionAsignada.Panel.SuspendLayout()
        Me.HGGuiaRemisionAsignada.SuspendLayout()
        CType(Me.panelRemisionAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRemisionAdicional.SuspendLayout()
        CType(Me.dtgGuiasSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar_1.SuspendLayout()
        CType(Me.KryptonHeaderDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderDetalle.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderDetalle.Panel.SuspendLayout()
        Me.KryptonHeaderDetalle.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpBoxConsignatario.SuspendLayout()
        CType(Me.KryptonGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup4.Panel.SuspendLayout()
        Me.KryptonGroup4.SuspendLayout()
        Me.grpBoxRemitente.SuspendLayout()
        CType(Me.KryptonGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup3.Panel.SuspendLayout()
        Me.KryptonGroup3.SuspendLayout()
        CType(Me.KryptonGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup9.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup9.Panel.SuspendLayout()
        Me.KryptonGroup9.SuspendLayout()
        CType(Me.KryptonGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup8.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup8.Panel.SuspendLayout()
        Me.KryptonGroup8.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonRadioButton3
        '
        Me.KryptonRadioButton3.Location = New System.Drawing.Point(83, 4)
        Me.KryptonRadioButton3.Name = "KryptonRadioButton3"
        Me.KryptonRadioButton3.Size = New System.Drawing.Size(83, 19)
        Me.KryptonRadioButton3.TabIndex = 141
        Me.KryptonRadioButton3.Text = "Destinatario"
        Me.KryptonRadioButton3.Values.ExtraText = ""
        Me.KryptonRadioButton3.Values.Image = Nothing
        Me.KryptonRadioButton3.Values.Text = "Destinatario"
        '
        'KryptonRadioButton4
        '
        Me.KryptonRadioButton4.Location = New System.Drawing.Point(3, 4)
        Me.KryptonRadioButton4.Name = "KryptonRadioButton4"
        Me.KryptonRadioButton4.Size = New System.Drawing.Size(74, 19)
        Me.KryptonRadioButton4.TabIndex = 142
        Me.KryptonRadioButton4.Text = "Remitente"
        Me.KryptonRadioButton4.Values.ExtraText = ""
        Me.KryptonRadioButton4.Values.Image = Nothing
        Me.KryptonRadioButton4.Values.Text = "Remitente"
        '
        'panelFiltros
        '
        Me.panelFiltros.Controls.Add(Me.KryptonHeaderCabecera)
        Me.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.panelFiltros.Margin = New System.Windows.Forms.Padding(4)
        Me.panelFiltros.Name = "panelFiltros"
        Me.panelFiltros.Size = New System.Drawing.Size(1432, 49)
        Me.panelFiltros.TabIndex = 2
        '
        'KryptonHeaderCabecera
        '
        Me.KryptonHeaderCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderCabecera.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderCabecera.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderCabecera.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderCabecera.Name = "KryptonHeaderCabecera"
        Me.KryptonHeaderCabecera.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'KryptonHeaderCabecera.Panel
        '
        Me.KryptonHeaderCabecera.Panel.Controls.Add(Me.txtPlanta)
        Me.KryptonHeaderCabecera.Panel.Controls.Add(Me.txtNroOperacion)
        Me.KryptonHeaderCabecera.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonHeaderCabecera.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderCabecera.Size = New System.Drawing.Size(1432, 49)
        Me.KryptonHeaderCabecera.TabIndex = 0
        Me.KryptonHeaderCabecera.ValuesPrimary.Description = ""
        Me.KryptonHeaderCabecera.ValuesPrimary.Heading = ""
        Me.KryptonHeaderCabecera.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderCabecera.ValuesSecondary.Description = ""
        Me.KryptonHeaderCabecera.ValuesSecondary.Heading = ""
        Me.KryptonHeaderCabecera.ValuesSecondary.Image = Nothing
        '
        'txtPlanta
        '
        Me.txtPlanta.Enabled = False
        Me.txtPlanta.Location = New System.Drawing.Point(75, 6)
        Me.txtPlanta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlanta.MaxLength = 10
        Me.txtPlanta.Name = "txtPlanta"
        Me.txtPlanta.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtPlanta.Size = New System.Drawing.Size(181, 26)
        Me.txtPlanta.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPlanta.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPlanta.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtPlanta.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.txtPlanta.TabIndex = 8
        Me.txtPlanta.Tag = ""
        '
        'txtNroOperacion
        '
        Me.txtNroOperacion.Enabled = False
        Me.txtNroOperacion.Location = New System.Drawing.Point(379, 6)
        Me.txtNroOperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroOperacion.MaxLength = 10
        Me.txtNroOperacion.Name = "txtNroOperacion"
        Me.txtNroOperacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtNroOperacion.Size = New System.Drawing.Size(107, 26)
        Me.txtNroOperacion.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNroOperacion.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNroOperacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNroOperacion.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.txtNroOperacion.TabIndex = 7
        Me.txtNroOperacion.Tag = ""
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(13, 6)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(54, 24)
        Me.KryptonLabel6.TabIndex = 4
        Me.KryptonLabel6.Text = "Planta"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Planta"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(267, 6)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(104, 24)
        Me.KryptonLabel3.TabIndex = 6
        Me.KryptonLabel3.Text = "N° Operación"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "N° Operación"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(465, 39)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(100, 24)
        Me.KryptonLabel2.TabIndex = 27
        Me.KryptonLabel2.Text = "Transportista"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Transportista"
        '
        'panelInformacion
        '
        Me.panelInformacion.Controls.Add(Me.TabMantenimiento)
        Me.panelInformacion.Controls.Add(Me.KryptonHeaderDetalle)
        Me.panelInformacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelInformacion.Location = New System.Drawing.Point(0, 49)
        Me.panelInformacion.Margin = New System.Windows.Forms.Padding(4)
        Me.panelInformacion.Name = "panelInformacion"
        Me.panelInformacion.Size = New System.Drawing.Size(1432, 849)
        Me.panelInformacion.TabIndex = 3
        '
        'TabMantenimiento
        '
        Me.TabMantenimiento.Controls.Add(Me.TabPage1)
        Me.TabMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMantenimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMantenimiento.Location = New System.Drawing.Point(0, 473)
        Me.TabMantenimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.TabMantenimiento.Name = "TabMantenimiento"
        Me.TabMantenimiento.SelectedIndex = 0
        Me.TabMantenimiento.Size = New System.Drawing.Size(1432, 376)
        Me.TabMantenimiento.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.KryptonHeaderGroup3)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1424, 346)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Pasajeros Asignados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup3.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup3.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup3.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(4, 4)
        Me.KryptonHeaderGroup3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.HGGuiaRemisionAsignada)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(1416, 338)
        Me.KryptonHeaderGroup3.TabIndex = 1
        Me.KryptonHeaderGroup3.Text = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'HGGuiaRemisionAsignada
        '
        Me.HGGuiaRemisionAsignada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGGuiaRemisionAsignada.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HGGuiaRemisionAsignada.HeaderVisibleSecondary = False
        Me.HGGuiaRemisionAsignada.Location = New System.Drawing.Point(0, 0)
        Me.HGGuiaRemisionAsignada.Margin = New System.Windows.Forms.Padding(4)
        Me.HGGuiaRemisionAsignada.Name = "HGGuiaRemisionAsignada"
        Me.HGGuiaRemisionAsignada.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'HGGuiaRemisionAsignada.Panel
        '
        Me.HGGuiaRemisionAsignada.Panel.Controls.Add(Me.panelRemisionAdicional)
        Me.HGGuiaRemisionAsignada.Panel.Controls.Add(Me.MenuBar_1)
        Me.HGGuiaRemisionAsignada.Size = New System.Drawing.Size(1414, 336)
        Me.HGGuiaRemisionAsignada.TabIndex = 1
        Me.HGGuiaRemisionAsignada.ValuesPrimary.Description = ""
        Me.HGGuiaRemisionAsignada.ValuesPrimary.Heading = ""
        Me.HGGuiaRemisionAsignada.ValuesPrimary.Image = Nothing
        Me.HGGuiaRemisionAsignada.ValuesSecondary.Description = ""
        Me.HGGuiaRemisionAsignada.ValuesSecondary.Heading = "Description"
        Me.HGGuiaRemisionAsignada.ValuesSecondary.Image = Nothing
        '
        'panelRemisionAdicional
        '
        Me.panelRemisionAdicional.Controls.Add(Me.dtgGuiasSeleccionadas)
        Me.panelRemisionAdicional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelRemisionAdicional.Location = New System.Drawing.Point(0, 27)
        Me.panelRemisionAdicional.Margin = New System.Windows.Forms.Padding(4)
        Me.panelRemisionAdicional.Name = "panelRemisionAdicional"
        Me.panelRemisionAdicional.Size = New System.Drawing.Size(1412, 304)
        Me.panelRemisionAdicional.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelRemisionAdicional.TabIndex = 2
        '
        'dtgGuiasSeleccionadas
        '
        Me.dtgGuiasSeleccionadas.AllowUserToAddRows = False
        Me.dtgGuiasSeleccionadas.AllowUserToDeleteRows = False
        Me.dtgGuiasSeleccionadas.AllowUserToResizeColumns = False
        Me.dtgGuiasSeleccionadas.AllowUserToResizeRows = False
        Me.dtgGuiasSeleccionadas.ColumnHeadersHeight = 30
        Me.dtgGuiasSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgGuiasSeleccionadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SELECCIONA, Me.NMBPER, Me.NPRGVJ, Me.RUTA, Me.FSLDRT, Me.HSLDRT, Me.NGUIRM, Me.NCRRRT, Me.NCRRIN})
        Me.dtgGuiasSeleccionadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgGuiasSeleccionadas.Location = New System.Drawing.Point(0, 0)
        Me.dtgGuiasSeleccionadas.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgGuiasSeleccionadas.Name = "dtgGuiasSeleccionadas"
        Me.dtgGuiasSeleccionadas.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dtgGuiasSeleccionadas.RowHeadersVisible = False
        Me.dtgGuiasSeleccionadas.RowHeadersWidth = 20
        Me.dtgGuiasSeleccionadas.Size = New System.Drawing.Size(1412, 304)
        Me.dtgGuiasSeleccionadas.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgGuiasSeleccionadas.TabIndex = 0
        '
        'SELECCIONA
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.SELECCIONA.DefaultCellStyle = DataGridViewCellStyle1
        Me.SELECCIONA.FalseValue = Nothing
        Me.SELECCIONA.HeaderText = ""
        Me.SELECCIONA.IndeterminateValue = Nothing
        Me.SELECCIONA.Name = "SELECCIONA"
        Me.SELECCIONA.TrueValue = Nothing
        Me.SELECCIONA.Width = 25
        '
        'NMBPER
        '
        Me.NMBPER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NMBPER.DataPropertyName = "NMBPER"
        Me.NMBPER.HeaderText = "Pasajero"
        Me.NMBPER.Name = "NMBPER"
        '
        'NPRGVJ
        '
        Me.NPRGVJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPRGVJ.DataPropertyName = "NPRGVJ"
        Me.NPRGVJ.HeaderText = "N° Programación Viaje"
        Me.NPRGVJ.Name = "NPRGVJ"
        Me.NPRGVJ.Width = 193
        '
        'RUTA
        '
        Me.RUTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RUTA.DataPropertyName = "RUTA"
        Me.RUTA.HeaderText = "Ruta"
        Me.RUTA.Name = "RUTA"
        '
        'FSLDRT
        '
        Me.FSLDRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FSLDRT.DataPropertyName = "FSLDRT"
        Me.FSLDRT.HeaderText = "Fecha Viaje"
        Me.FSLDRT.Name = "FSLDRT"
        Me.FSLDRT.Width = 117
        '
        'HSLDRT
        '
        Me.HSLDRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HSLDRT.DataPropertyName = "HSLDRT"
        Me.HSLDRT.HeaderText = "Hora Viaje"
        Me.HSLDRT.Name = "HSLDRT"
        Me.HSLDRT.Width = 112
        '
        'NGUIRM
        '
        Me.NGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUIRM.DataPropertyName = "NGUIRM"
        Me.NGUIRM.HeaderText = "Guía Transportista"
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.Visible = False
        Me.NGUIRM.Width = 161
        '
        'NCRRRT
        '
        Me.NCRRRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRRT.DataPropertyName = "NCRRRT"
        Me.NCRRRT.HeaderText = "Correlativo Ruta"
        Me.NCRRRT.Name = "NCRRRT"
        Me.NCRRRT.Visible = False
        Me.NCRRRT.Width = 149
        '
        'NCRRIN
        '
        Me.NCRRIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRIN.DataPropertyName = "NCRRIN"
        Me.NCRRIN.HeaderText = "Correlativo Ingreso"
        Me.NCRRIN.Name = "NCRRIN"
        Me.NCRRIN.Visible = False
        Me.NCRRIN.Width = 168
        '
        'MenuBar_1
        '
        Me.MenuBar_1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar_1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar_1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar_1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblNumeroGuias, Me.btnAsignarPasajero, Me.ToolStripSeparator1, Me.btnQuitarElemento})
        Me.MenuBar_1.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar_1.Name = "MenuBar_1"
        Me.MenuBar_1.Size = New System.Drawing.Size(1412, 27)
        Me.MenuBar_1.TabIndex = 0
        Me.MenuBar_1.Text = "ToolStrip2"
        '
        'lblNumeroGuias
        '
        Me.lblNumeroGuias.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblNumeroGuias.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroGuias.Name = "lblNumeroGuias"
        Me.lblNumeroGuias.Size = New System.Drawing.Size(212, 24)
        Me.lblNumeroGuias.Text = "Total Pasajeros Asignados : 0"
        '
        'btnAsignarPasajero
        '
        Me.btnAsignarPasajero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignarPasajero.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.images__2_
        Me.btnAsignarPasajero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAsignarPasajero.Name = "btnAsignarPasajero"
        Me.btnAsignarPasajero.Size = New System.Drawing.Size(152, 24)
        Me.btnAsignarPasajero.Text = "Asignar Pasajeros"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnQuitarElemento
        '
        Me.btnQuitarElemento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarElemento.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_cancel
        Me.btnQuitarElemento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuitarElemento.Name = "btnQuitarElemento"
        Me.btnQuitarElemento.Size = New System.Drawing.Size(90, 24)
        Me.btnQuitarElemento.Text = " Eliminar"
        '
        'KryptonHeaderDetalle
        '
        Me.KryptonHeaderDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderDetalle.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderDetalle.HeaderVisiblePrimary = False
        Me.KryptonHeaderDetalle.HeaderVisibleSecondary = False
        Me.KryptonHeaderDetalle.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderDetalle.Name = "KryptonHeaderDetalle"
        Me.KryptonHeaderDetalle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'KryptonHeaderDetalle.Panel
        '
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtUnidadMed)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtMonFlete)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtOrdenEmbarcador)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.GroupBox4)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.btnConfigTracto)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtConductor)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtAcoplado)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtTracto)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtTransportista)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.checkGenerar)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtNroPlaneamiento)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.grpBoxConsignatario)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.grpBoxRemitente)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtObservación)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonGroup9)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.chkMercPeligrosa)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonGroup8)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.chkMercPerecible)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.cboMonedaValorPatr)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtPesoBruto)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtPesoMercaderia)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtCostoTramo)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtVolumenRemision)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtValorPatrimonio)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtKmPorRecorrer)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel18)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel23)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel29)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel38)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.cboDestinoUbigeo)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.cboOrigenUbigeo)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtLugar)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtNroHojaGuia)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.dtpFecGuia)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.dtpFecIniTrans)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.cboLugarDestino)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.cboLugarOrigen)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtGalsDiesel)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtCantMercaderia)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtGalsGasolina)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtDirDestino)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtDirOrigen)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtNroRemision)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel16)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.MenuBar)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonBorderEdge1)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonBorderEdge5)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.txtConfigTracto)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel17)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel30)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel19)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel21)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel22)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel24)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel25)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel26)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel15)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel50)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel27)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel12)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel13)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.lblGuiaRemision)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel48)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel49)
        Me.KryptonHeaderDetalle.Panel.Controls.Add(Me.KryptonLabel39)
        Me.KryptonHeaderDetalle.Size = New System.Drawing.Size(1432, 473)
        Me.KryptonHeaderDetalle.TabIndex = 0
        Me.KryptonHeaderDetalle.Text = "Información de Guías de Transporte"
        Me.KryptonHeaderDetalle.ValuesPrimary.Description = ""
        Me.KryptonHeaderDetalle.ValuesPrimary.Heading = "Información de Guías de Transporte"
        Me.KryptonHeaderDetalle.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderDetalle.ValuesSecondary.Description = ""
        Me.KryptonHeaderDetalle.ValuesSecondary.Heading = ""
        Me.KryptonHeaderDetalle.ValuesSecondary.Image = Nothing
        '
        'txtUnidadMed
        '
        Me.txtUnidadMed.Enabled = False
        Me.txtUnidadMed.Location = New System.Drawing.Point(244, 423)
        Me.txtUnidadMed.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidadMed.Name = "txtUnidadMed"
        Me.txtUnidadMed.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtUnidadMed.Size = New System.Drawing.Size(209, 26)
        Me.txtUnidadMed.TabIndex = 75
        '
        'txtMonFlete
        '
        Me.txtMonFlete.Enabled = False
        Me.txtMonFlete.Location = New System.Drawing.Point(604, 216)
        Me.txtMonFlete.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMonFlete.Name = "txtMonFlete"
        Me.txtMonFlete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtMonFlete.Size = New System.Drawing.Size(312, 26)
        Me.txtMonFlete.TabIndex = 74
        '
        'txtOrdenEmbarcador
        '
        Me.txtOrdenEmbarcador.Location = New System.Drawing.Point(605, 250)
        Me.txtOrdenEmbarcador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrdenEmbarcador.MaxLength = 25
        Me.txtOrdenEmbarcador.Name = "txtOrdenEmbarcador"
        Me.txtOrdenEmbarcador.Size = New System.Drawing.Size(313, 26)
        Me.txtOrdenEmbarcador.TabIndex = 69
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.dtpFecGuiaETA)
        Me.GroupBox4.Controls.Add(Me.dtpFecGuiaETD)
        Me.GroupBox4.Controls.Add(Me.KryptonLabel46)
        Me.GroupBox4.Controls.Add(Me.KryptonLabel20)
        Me.GroupBox4.Location = New System.Drawing.Point(60, 105)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(393, 68)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fecha Estimada"
        '
        'dtpFecGuiaETA
        '
        Me.dtpFecGuiaETA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecGuiaETA.Location = New System.Drawing.Point(259, 31)
        Me.dtpFecGuiaETA.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecGuiaETA.Name = "dtpFecGuiaETA"
        Me.dtpFecGuiaETA.ShowCheckBox = True
        Me.dtpFecGuiaETA.Size = New System.Drawing.Size(127, 22)
        Me.dtpFecGuiaETA.TabIndex = 3
        Me.dtpFecGuiaETA.Tag = ""
        Me.dtpFecGuiaETA.Value = New Date(2011, 6, 11, 0, 0, 0, 0)
        '
        'dtpFecGuiaETD
        '
        Me.dtpFecGuiaETD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecGuiaETD.Location = New System.Drawing.Point(76, 31)
        Me.dtpFecGuiaETD.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecGuiaETD.Name = "dtpFecGuiaETD"
        Me.dtpFecGuiaETD.Size = New System.Drawing.Size(116, 22)
        Me.dtpFecGuiaETD.TabIndex = 1
        Me.dtpFecGuiaETD.Tag = ""
        Me.dtpFecGuiaETD.Value = New Date(2011, 6, 11, 0, 0, 0, 0)
        '
        'KryptonLabel46
        '
        Me.KryptonLabel46.Location = New System.Drawing.Point(195, 31)
        Me.KryptonLabel46.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel46.Name = "KryptonLabel46"
        Me.KryptonLabel46.Size = New System.Drawing.Size(65, 24)
        Me.KryptonLabel46.TabIndex = 2
        Me.KryptonLabel46.Text = "Llegada"
        Me.KryptonLabel46.Values.ExtraText = ""
        Me.KryptonLabel46.Values.Image = Nothing
        Me.KryptonLabel46.Values.Text = "Llegada"
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(12, 31)
        Me.KryptonLabel20.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(52, 24)
        Me.KryptonLabel20.TabIndex = 0
        Me.KryptonLabel20.Text = "Salida"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Salida"
        '
        'btnConfigTracto
        '
        Me.btnConfigTracto.Location = New System.Drawing.Point(804, 143)
        Me.btnConfigTracto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfigTracto.Name = "btnConfigTracto"
        Me.btnConfigTracto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.btnConfigTracto.Size = New System.Drawing.Size(33, 27)
        Me.btnConfigTracto.TabIndex = 35
        Me.btnConfigTracto.Values.ExtraText = ""
        Me.btnConfigTracto.Values.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.cell_layout
        Me.btnConfigTracto.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnConfigTracto.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnConfigTracto.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnConfigTracto.Values.Text = ""
        '
        'txtConductor
        '
        Me.txtConductor.Enabled = False
        Me.txtConductor.Location = New System.Drawing.Point(605, 181)
        Me.txtConductor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtConductor.Size = New System.Drawing.Size(313, 26)
        Me.txtConductor.TabIndex = 37
        '
        'txtAcoplado
        '
        Me.txtAcoplado.Enabled = False
        Me.txtAcoplado.Location = New System.Drawing.Point(605, 110)
        Me.txtAcoplado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAcoplado.Name = "txtAcoplado"
        Me.txtAcoplado.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtAcoplado.Size = New System.Drawing.Size(313, 26)
        Me.txtAcoplado.TabIndex = 32
        '
        'txtTracto
        '
        Me.txtTracto.Enabled = False
        Me.txtTracto.Location = New System.Drawing.Point(605, 74)
        Me.txtTracto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTracto.Name = "txtTracto"
        Me.txtTracto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtTracto.Size = New System.Drawing.Size(313, 26)
        Me.txtTracto.TabIndex = 30
        '
        'txtTransportista
        '
        Me.txtTransportista.Enabled = False
        Me.txtTransportista.Location = New System.Drawing.Point(605, 38)
        Me.txtTransportista.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransportista.Name = "txtTransportista"
        Me.txtTransportista.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtTransportista.Size = New System.Drawing.Size(313, 26)
        Me.txtTransportista.TabIndex = 28
        '
        'checkGenerar
        '
        Me.checkGenerar.Checked = False
        Me.checkGenerar.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.checkGenerar.Location = New System.Drawing.Point(264, 39)
        Me.checkGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.checkGenerar.Name = "checkGenerar"
        Me.checkGenerar.Size = New System.Drawing.Size(184, 24)
        Me.checkGenerar.TabIndex = 3
        Me.checkGenerar.Text = "Generación Automatica"
        Me.checkGenerar.Values.ExtraText = ""
        Me.checkGenerar.Values.Image = Nothing
        Me.checkGenerar.Values.Text = "Generación Automatica"
        '
        'txtNroPlaneamiento
        '
        Me.txtNroPlaneamiento.Enabled = False
        Me.txtNroPlaneamiento.Location = New System.Drawing.Point(13, 105)
        Me.txtNroPlaneamiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroPlaneamiento.MaxLength = 10
        Me.txtNroPlaneamiento.Name = "txtNroPlaneamiento"
        Me.txtNroPlaneamiento.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtNroPlaneamiento.Size = New System.Drawing.Size(20, 26)
        Me.txtNroPlaneamiento.TabIndex = 43
        Me.txtNroPlaneamiento.Tag = ""
        Me.txtNroPlaneamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNroPlaneamiento.Visible = False
        '
        'grpBoxConsignatario
        '
        Me.grpBoxConsignatario.BackColor = System.Drawing.Color.White
        Me.grpBoxConsignatario.Controls.Add(Me.UcCNomConsignatario)
        Me.grpBoxConsignatario.Controls.Add(Me.txtNomConsignatario)
        Me.grpBoxConsignatario.Controls.Add(Me.KryptonLabel33)
        Me.grpBoxConsignatario.Controls.Add(Me.txtDirConsignatario)
        Me.grpBoxConsignatario.Controls.Add(Me.KryptonLabel32)
        Me.grpBoxConsignatario.Controls.Add(Me.txtNroDocConsignatario)
        Me.grpBoxConsignatario.Controls.Add(Me.KryptonLabel31)
        Me.grpBoxConsignatario.Controls.Add(Me.KryptonLabel28)
        Me.grpBoxConsignatario.Controls.Add(Me.KryptonGroup4)
        Me.grpBoxConsignatario.Controls.Add(Me.chkCliente)
        Me.grpBoxConsignatario.Location = New System.Drawing.Point(937, 231)
        Me.grpBoxConsignatario.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBoxConsignatario.Name = "grpBoxConsignatario"
        Me.grpBoxConsignatario.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBoxConsignatario.Size = New System.Drawing.Size(481, 127)
        Me.grpBoxConsignatario.TabIndex = 66
        Me.grpBoxConsignatario.TabStop = False
        Me.grpBoxConsignatario.Text = "Consignatario"
        '
        'UcCNomConsignatario
        '
        Me.UcCNomConsignatario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCNomConsignatario.BackColor = System.Drawing.Color.Transparent
        Me.UcCNomConsignatario.CCMPN = "EZ"
        Me.UcCNomConsignatario.Location = New System.Drawing.Point(105, 22)
        Me.UcCNomConsignatario.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCNomConsignatario.Name = "UcCNomConsignatario"
        Me.UcCNomConsignatario.pAccesoPorUsuario = False
        Me.UcCNomConsignatario.pCDDRSP_CodClienteSAP = ""
        Me.UcCNomConsignatario.pRequerido = False
        Me.UcCNomConsignatario.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCNomConsignatario.pVisualizaNegocio = False
        Me.UcCNomConsignatario.Size = New System.Drawing.Size(368, 26)
        Me.UcCNomConsignatario.TabIndex = 2
        '
        'txtNomConsignatario
        '
        Me.txtNomConsignatario.Location = New System.Drawing.Point(105, 22)
        Me.txtNomConsignatario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomConsignatario.MaxLength = 40
        Me.txtNomConsignatario.Name = "txtNomConsignatario"
        Me.txtNomConsignatario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtNomConsignatario.Size = New System.Drawing.Size(368, 26)
        Me.txtNomConsignatario.TabIndex = 1
        Me.txtNomConsignatario.Tag = "220"
        Me.txtNomConsignatario.Visible = False
        '
        'KryptonLabel33
        '
        Me.KryptonLabel33.Location = New System.Drawing.Point(3, 23)
        Me.KryptonLabel33.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel33.Name = "KryptonLabel33"
        Me.KryptonLabel33.Size = New System.Drawing.Size(68, 24)
        Me.KryptonLabel33.TabIndex = 1
        Me.KryptonLabel33.Text = "Nombre"
        Me.KryptonLabel33.Values.ExtraText = ""
        Me.KryptonLabel33.Values.Image = Nothing
        Me.KryptonLabel33.Values.Text = "Nombre"
        '
        'txtDirConsignatario
        '
        Me.txtDirConsignatario.Location = New System.Drawing.Point(105, 55)
        Me.txtDirConsignatario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirConsignatario.MaxLength = 40
        Me.txtDirConsignatario.Name = "txtDirConsignatario"
        Me.txtDirConsignatario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtDirConsignatario.Size = New System.Drawing.Size(368, 26)
        Me.txtDirConsignatario.TabIndex = 4
        Me.txtDirConsignatario.Tag = "225"
        '
        'KryptonLabel32
        '
        Me.KryptonLabel32.Location = New System.Drawing.Point(3, 55)
        Me.KryptonLabel32.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel32.Name = "KryptonLabel32"
        Me.KryptonLabel32.Size = New System.Drawing.Size(75, 24)
        Me.KryptonLabel32.TabIndex = 3
        Me.KryptonLabel32.Text = "Dirección"
        Me.KryptonLabel32.Values.ExtraText = ""
        Me.KryptonLabel32.Values.Image = Nothing
        Me.KryptonLabel32.Values.Text = "Dirección"
        '
        'txtNroDocConsignatario
        '
        Me.txtNroDocConsignatario.Location = New System.Drawing.Point(367, 87)
        Me.txtNroDocConsignatario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroDocConsignatario.MaxLength = 11
        Me.txtNroDocConsignatario.Name = "txtNroDocConsignatario"
        Me.txtNroDocConsignatario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtNroDocConsignatario.Size = New System.Drawing.Size(107, 26)
        Me.txtNroDocConsignatario.TabIndex = 7
        Me.txtNroDocConsignatario.Tag = "240"
        '
        'KryptonLabel31
        '
        Me.KryptonLabel31.Location = New System.Drawing.Point(255, 89)
        Me.KryptonLabel31.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel31.Name = "KryptonLabel31"
        Me.KryptonLabel31.Size = New System.Drawing.Size(113, 24)
        Me.KryptonLabel31.TabIndex = 6
        Me.KryptonLabel31.Text = "N° Documento"
        Me.KryptonLabel31.Values.ExtraText = ""
        Me.KryptonLabel31.Values.Image = Nothing
        Me.KryptonLabel31.Values.Text = "N° Documento"
        '
        'KryptonLabel28
        '
        Me.KryptonLabel28.Location = New System.Drawing.Point(3, 89)
        Me.KryptonLabel28.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel28.Name = "KryptonLabel28"
        Me.KryptonLabel28.Size = New System.Drawing.Size(98, 24)
        Me.KryptonLabel28.TabIndex = 5
        Me.KryptonLabel28.Text = "Tipo Docum."
        Me.KryptonLabel28.Values.ExtraText = ""
        Me.KryptonLabel28.Values.Image = Nothing
        Me.KryptonLabel28.Values.Text = "Tipo Docum."
        '
        'KryptonGroup4
        '
        Me.KryptonGroup4.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.KryptonGroup4.Location = New System.Drawing.Point(105, 86)
        Me.KryptonGroup4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonGroup4.Name = "KryptonGroup4"
        Me.KryptonGroup4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'KryptonGroup4.Panel
        '
        Me.KryptonGroup4.Panel.Controls.Add(Me.rbtnRUCConsignatario)
        Me.KryptonGroup4.Panel.Controls.Add(Me.rbtnDNIConsignatario)
        Me.KryptonGroup4.Size = New System.Drawing.Size(147, 31)
        Me.KryptonGroup4.TabIndex = 5
        '
        'rbtnRUCConsignatario
        '
        Me.rbtnRUCConsignatario.Checked = True
        Me.rbtnRUCConsignatario.Location = New System.Drawing.Point(71, 1)
        Me.rbtnRUCConsignatario.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnRUCConsignatario.Name = "rbtnRUCConsignatario"
        Me.rbtnRUCConsignatario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.rbtnRUCConsignatario.Size = New System.Drawing.Size(60, 24)
        Me.rbtnRUCConsignatario.TabIndex = 1
        Me.rbtnRUCConsignatario.TabStop = False
        Me.rbtnRUCConsignatario.Tag = ""
        Me.rbtnRUCConsignatario.Text = "R.U.C"
        Me.rbtnRUCConsignatario.Values.ExtraText = ""
        Me.rbtnRUCConsignatario.Values.Image = Nothing
        Me.rbtnRUCConsignatario.Values.Text = "R.U.C"
        '
        'rbtnDNIConsignatario
        '
        Me.rbtnDNIConsignatario.Location = New System.Drawing.Point(1, 1)
        Me.rbtnDNIConsignatario.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnDNIConsignatario.Name = "rbtnDNIConsignatario"
        Me.rbtnDNIConsignatario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.rbtnDNIConsignatario.Size = New System.Drawing.Size(57, 24)
        Me.rbtnDNIConsignatario.TabIndex = 0
        Me.rbtnDNIConsignatario.TabStop = False
        Me.rbtnDNIConsignatario.Tag = ""
        Me.rbtnDNIConsignatario.Text = "D.N.I"
        Me.rbtnDNIConsignatario.Values.ExtraText = ""
        Me.rbtnDNIConsignatario.Values.Image = Nothing
        Me.rbtnDNIConsignatario.Values.Text = "D.N.I"
        '
        'chkCliente
        '
        Me.chkCliente.Checked = False
        Me.chkCliente.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkCliente.Location = New System.Drawing.Point(100, 1)
        Me.chkCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(19, 13)
        Me.chkCliente.TabIndex = 0
        Me.chkCliente.Values.ExtraText = ""
        Me.chkCliente.Values.Image = Nothing
        Me.chkCliente.Values.Text = ""
        '
        'grpBoxRemitente
        '
        Me.grpBoxRemitente.BackColor = System.Drawing.Color.White
        Me.grpBoxRemitente.Controls.Add(Me.UcCNomRemitente)
        Me.grpBoxRemitente.Controls.Add(Me.KryptonLabel37)
        Me.grpBoxRemitente.Controls.Add(Me.KryptonLabel36)
        Me.grpBoxRemitente.Controls.Add(Me.KryptonLabel35)
        Me.grpBoxRemitente.Controls.Add(Me.txtDirRemitente)
        Me.grpBoxRemitente.Controls.Add(Me.KryptonGroup3)
        Me.grpBoxRemitente.Controls.Add(Me.txtNroDocRemitente)
        Me.grpBoxRemitente.Controls.Add(Me.KryptonLabel34)
        Me.grpBoxRemitente.Location = New System.Drawing.Point(937, 101)
        Me.grpBoxRemitente.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBoxRemitente.Name = "grpBoxRemitente"
        Me.grpBoxRemitente.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBoxRemitente.Size = New System.Drawing.Size(481, 127)
        Me.grpBoxRemitente.TabIndex = 65
        Me.grpBoxRemitente.TabStop = False
        Me.grpBoxRemitente.Text = "Remitente"
        '
        'UcCNomRemitente
        '
        Me.UcCNomRemitente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCNomRemitente.BackColor = System.Drawing.Color.Transparent
        Me.UcCNomRemitente.CCMPN = "EZ"
        Me.UcCNomRemitente.Location = New System.Drawing.Point(105, 27)
        Me.UcCNomRemitente.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCNomRemitente.Name = "UcCNomRemitente"
        Me.UcCNomRemitente.pAccesoPorUsuario = False
        Me.UcCNomRemitente.pCDDRSP_CodClienteSAP = ""
        Me.UcCNomRemitente.pRequerido = False
        Me.UcCNomRemitente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCNomRemitente.pVisualizaNegocio = False
        Me.UcCNomRemitente.Size = New System.Drawing.Size(368, 26)
        Me.UcCNomRemitente.TabIndex = 1
        '
        'KryptonLabel37
        '
        Me.KryptonLabel37.Location = New System.Drawing.Point(3, 28)
        Me.KryptonLabel37.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel37.Name = "KryptonLabel37"
        Me.KryptonLabel37.Size = New System.Drawing.Size(68, 24)
        Me.KryptonLabel37.TabIndex = 0
        Me.KryptonLabel37.Text = "Nombre"
        Me.KryptonLabel37.Values.ExtraText = ""
        Me.KryptonLabel37.Values.Image = Nothing
        Me.KryptonLabel37.Values.Text = "Nombre"
        '
        'KryptonLabel36
        '
        Me.KryptonLabel36.Location = New System.Drawing.Point(3, 60)
        Me.KryptonLabel36.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel36.Name = "KryptonLabel36"
        Me.KryptonLabel36.Size = New System.Drawing.Size(75, 24)
        Me.KryptonLabel36.TabIndex = 2
        Me.KryptonLabel36.Text = "Dirección"
        Me.KryptonLabel36.Values.ExtraText = ""
        Me.KryptonLabel36.Values.Image = Nothing
        Me.KryptonLabel36.Values.Text = "Dirección"
        '
        'KryptonLabel35
        '
        Me.KryptonLabel35.Location = New System.Drawing.Point(3, 95)
        Me.KryptonLabel35.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel35.Name = "KryptonLabel35"
        Me.KryptonLabel35.Size = New System.Drawing.Size(98, 24)
        Me.KryptonLabel35.TabIndex = 4
        Me.KryptonLabel35.Text = "Tipo Docum."
        Me.KryptonLabel35.Values.ExtraText = ""
        Me.KryptonLabel35.Values.Image = Nothing
        Me.KryptonLabel35.Values.Text = "Tipo Docum."
        '
        'txtDirRemitente
        '
        Me.txtDirRemitente.Location = New System.Drawing.Point(105, 57)
        Me.txtDirRemitente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirRemitente.MaxLength = 40
        Me.txtDirRemitente.Name = "txtDirRemitente"
        Me.txtDirRemitente.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtDirRemitente.Size = New System.Drawing.Size(368, 26)
        Me.txtDirRemitente.TabIndex = 3
        Me.txtDirRemitente.Tag = "225"
        '
        'KryptonGroup3
        '
        Me.KryptonGroup3.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.KryptonGroup3.Location = New System.Drawing.Point(105, 89)
        Me.KryptonGroup3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonGroup3.Name = "KryptonGroup3"
        Me.KryptonGroup3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'KryptonGroup3.Panel
        '
        Me.KryptonGroup3.Panel.Controls.Add(Me.rbtnRUCRemit)
        Me.KryptonGroup3.Panel.Controls.Add(Me.rbtnDNIRemit)
        Me.KryptonGroup3.Size = New System.Drawing.Size(147, 31)
        Me.KryptonGroup3.TabIndex = 5
        '
        'rbtnRUCRemit
        '
        Me.rbtnRUCRemit.Checked = True
        Me.rbtnRUCRemit.Location = New System.Drawing.Point(71, 1)
        Me.rbtnRUCRemit.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnRUCRemit.Name = "rbtnRUCRemit"
        Me.rbtnRUCRemit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.rbtnRUCRemit.Size = New System.Drawing.Size(60, 24)
        Me.rbtnRUCRemit.TabIndex = 1
        Me.rbtnRUCRemit.TabStop = False
        Me.rbtnRUCRemit.Tag = "235"
        Me.rbtnRUCRemit.Text = "R.U.C"
        Me.rbtnRUCRemit.Values.ExtraText = ""
        Me.rbtnRUCRemit.Values.Image = Nothing
        Me.rbtnRUCRemit.Values.Text = "R.U.C"
        '
        'rbtnDNIRemit
        '
        Me.rbtnDNIRemit.Location = New System.Drawing.Point(1, 1)
        Me.rbtnDNIRemit.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnDNIRemit.Name = "rbtnDNIRemit"
        Me.rbtnDNIRemit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.rbtnDNIRemit.Size = New System.Drawing.Size(57, 24)
        Me.rbtnDNIRemit.TabIndex = 0
        Me.rbtnDNIRemit.TabStop = False
        Me.rbtnDNIRemit.Tag = "230"
        Me.rbtnDNIRemit.Text = "D.N.I"
        Me.rbtnDNIRemit.Values.ExtraText = ""
        Me.rbtnDNIRemit.Values.Image = Nothing
        Me.rbtnDNIRemit.Values.Text = "D.N.I"
        '
        'txtNroDocRemitente
        '
        Me.txtNroDocRemitente.Location = New System.Drawing.Point(367, 94)
        Me.txtNroDocRemitente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroDocRemitente.MaxLength = 11
        Me.txtNroDocRemitente.Name = "txtNroDocRemitente"
        Me.txtNroDocRemitente.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtNroDocRemitente.Size = New System.Drawing.Size(107, 26)
        Me.txtNroDocRemitente.TabIndex = 6
        Me.txtNroDocRemitente.Tag = "240"
        '
        'KryptonLabel34
        '
        Me.KryptonLabel34.Location = New System.Drawing.Point(255, 94)
        Me.KryptonLabel34.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel34.Name = "KryptonLabel34"
        Me.KryptonLabel34.Size = New System.Drawing.Size(113, 24)
        Me.KryptonLabel34.TabIndex = 5
        Me.KryptonLabel34.Text = "N° Documento"
        Me.KryptonLabel34.Values.ExtraText = ""
        Me.KryptonLabel34.Values.Image = Nothing
        Me.KryptonLabel34.Values.Text = "N° Documento"
        '
        'txtObservación
        '
        Me.txtObservación.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservación.Location = New System.Drawing.Point(939, 384)
        Me.txtObservación.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservación.Multiline = True
        Me.txtObservación.Name = "txtObservación"
        Me.txtObservación.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtObservación.Size = New System.Drawing.Size(481, 79)
        Me.txtObservación.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.txtObservación.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.txtObservación.TabIndex = 68
        '
        'KryptonGroup9
        '
        Me.KryptonGroup9.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.KryptonGroup9.Location = New System.Drawing.Point(1000, 36)
        Me.KryptonGroup9.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonGroup9.Name = "KryptonGroup9"
        Me.KryptonGroup9.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'KryptonGroup9.Panel
        '
        Me.KryptonGroup9.Panel.Controls.Add(Me.rbtnIdaVuelta)
        Me.KryptonGroup9.Panel.Controls.Add(Me.rbtnIda)
        Me.KryptonGroup9.Size = New System.Drawing.Size(120, 63)
        Me.KryptonGroup9.TabIndex = 50
        '
        'rbtnIdaVuelta
        '
        Me.rbtnIdaVuelta.Location = New System.Drawing.Point(8, 31)
        Me.rbtnIdaVuelta.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnIdaVuelta.Name = "rbtnIdaVuelta"
        Me.rbtnIdaVuelta.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.rbtnIdaVuelta.Size = New System.Drawing.Size(64, 24)
        Me.rbtnIdaVuelta.TabIndex = 1
        Me.rbtnIdaVuelta.TabStop = False
        Me.rbtnIdaVuelta.Tag = ""
        Me.rbtnIdaVuelta.Text = "Salida"
        Me.rbtnIdaVuelta.Values.ExtraText = ""
        Me.rbtnIdaVuelta.Values.Image = Nothing
        Me.rbtnIdaVuelta.Values.Text = "Salida"
        '
        'rbtnIda
        '
        Me.rbtnIda.Checked = True
        Me.rbtnIda.Location = New System.Drawing.Point(8, 2)
        Me.rbtnIda.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnIda.Name = "rbtnIda"
        Me.rbtnIda.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.rbtnIda.Size = New System.Drawing.Size(75, 24)
        Me.rbtnIda.TabIndex = 0
        Me.rbtnIda.TabStop = False
        Me.rbtnIda.Tag = ""
        Me.rbtnIda.Text = "Ingreso"
        Me.rbtnIda.Values.ExtraText = ""
        Me.rbtnIda.Values.Image = Nothing
        Me.rbtnIda.Values.Text = "Ingreso"
        '
        'chkMercPeligrosa
        '
        Me.chkMercPeligrosa.Checked = False
        Me.chkMercPeligrosa.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMercPeligrosa.Location = New System.Drawing.Point(785, 286)
        Me.chkMercPeligrosa.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMercPeligrosa.Name = "chkMercPeligrosa"
        Me.chkMercPeligrosa.Size = New System.Drawing.Size(129, 24)
        Me.chkMercPeligrosa.TabIndex = 45
        Me.chkMercPeligrosa.Tag = ""
        Me.chkMercPeligrosa.Text = "Merc. Peligrosa"
        Me.chkMercPeligrosa.Values.ExtraText = ""
        Me.chkMercPeligrosa.Values.Image = Nothing
        Me.chkMercPeligrosa.Values.Text = "Merc. Peligrosa"
        '
        'KryptonGroup8
        '
        Me.KryptonGroup8.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.KryptonGroup8.Location = New System.Drawing.Point(1220, 36)
        Me.KryptonGroup8.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonGroup8.Name = "KryptonGroup8"
        Me.KryptonGroup8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'KryptonGroup8.Panel
        '
        Me.KryptonGroup8.Panel.Controls.Add(Me.rbtnDestinatario)
        Me.KryptonGroup8.Panel.Controls.Add(Me.rbtnRemitente)
        Me.KryptonGroup8.Size = New System.Drawing.Size(133, 63)
        Me.KryptonGroup8.TabIndex = 46
        '
        'rbtnDestinatario
        '
        Me.rbtnDestinatario.Location = New System.Drawing.Point(9, 31)
        Me.rbtnDestinatario.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnDestinatario.Name = "rbtnDestinatario"
        Me.rbtnDestinatario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.rbtnDestinatario.Size = New System.Drawing.Size(106, 24)
        Me.rbtnDestinatario.TabIndex = 1
        Me.rbtnDestinatario.TabStop = False
        Me.rbtnDestinatario.Tag = ""
        Me.rbtnDestinatario.Text = "Destinatario"
        Me.rbtnDestinatario.Values.ExtraText = ""
        Me.rbtnDestinatario.Values.Image = Nothing
        Me.rbtnDestinatario.Values.Text = "Destinatario"
        '
        'rbtnRemitente
        '
        Me.rbtnRemitente.Checked = True
        Me.rbtnRemitente.Location = New System.Drawing.Point(9, 2)
        Me.rbtnRemitente.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnRemitente.Name = "rbtnRemitente"
        Me.rbtnRemitente.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.rbtnRemitente.Size = New System.Drawing.Size(93, 24)
        Me.rbtnRemitente.TabIndex = 0
        Me.rbtnRemitente.TabStop = False
        Me.rbtnRemitente.Tag = ""
        Me.rbtnRemitente.Text = "Remitente"
        Me.rbtnRemitente.Values.ExtraText = ""
        Me.rbtnRemitente.Values.Image = Nothing
        Me.rbtnRemitente.Values.Text = "Remitente"
        '
        'chkMercPerecible
        '
        Me.chkMercPerecible.Checked = False
        Me.chkMercPerecible.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMercPerecible.Location = New System.Drawing.Point(607, 286)
        Me.chkMercPerecible.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMercPerecible.Name = "chkMercPerecible"
        Me.chkMercPerecible.Size = New System.Drawing.Size(128, 24)
        Me.chkMercPerecible.TabIndex = 44
        Me.chkMercPerecible.Tag = ""
        Me.chkMercPerecible.Text = "Merc. Perecible"
        Me.chkMercPerecible.Values.ExtraText = ""
        Me.chkMercPerecible.Values.Image = Nothing
        Me.chkMercPerecible.Values.Text = "Merc. Perecible"
        '
        'cboMonedaValorPatr
        '
        Me.cboMonedaValorPatr.BackColor = System.Drawing.Color.White
        Me.cboMonedaValorPatr.Codigo = ""
        Me.cboMonedaValorPatr.ControlHeight = 23
        Me.cboMonedaValorPatr.ControlImage = True
        Me.cboMonedaValorPatr.ControlReadOnly = False
        Me.cboMonedaValorPatr.Descripcion = ""
        Me.cboMonedaValorPatr.DisplayColumnVisible = True
        Me.cboMonedaValorPatr.DisplayMember = ""
        Me.cboMonedaValorPatr.KeyColumnWidth = 100
        Me.cboMonedaValorPatr.KeyField = ""
        Me.cboMonedaValorPatr.KeySearch = True
        Me.cboMonedaValorPatr.Location = New System.Drawing.Point(13, 135)
        Me.cboMonedaValorPatr.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMonedaValorPatr.Name = "cboMonedaValorPatr"
        Me.cboMonedaValorPatr.Size = New System.Drawing.Size(33, 23)
        Me.cboMonedaValorPatr.TabIndex = 42
        Me.cboMonedaValorPatr.Tag = ""
        Me.cboMonedaValorPatr.TextBackColor = System.Drawing.Color.Empty
        Me.cboMonedaValorPatr.TextForeColor = System.Drawing.Color.Empty
        Me.cboMonedaValorPatr.ValueColumnVisible = True
        Me.cboMonedaValorPatr.ValueColumnWidth = 600
        Me.cboMonedaValorPatr.ValueField = ""
        Me.cboMonedaValorPatr.ValueMember = ""
        Me.cboMonedaValorPatr.ValueSearch = True
        Me.cboMonedaValorPatr.Visible = False
        '
        'txtPesoBruto
        '
        Me.txtPesoBruto.Location = New System.Drawing.Point(817, 422)
        Me.txtPesoBruto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesoBruto.MaxLength = 10
        Me.txtPesoBruto.Name = "txtPesoBruto"
        Me.txtPesoBruto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtPesoBruto.Size = New System.Drawing.Size(103, 26)
        Me.txtPesoBruto.TabIndex = 61
        Me.txtPesoBruto.Tag = ""
        Me.txtPesoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPesoMercaderia
        '
        Me.txtPesoMercaderia.Location = New System.Drawing.Point(604, 422)
        Me.txtPesoMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesoMercaderia.MaxLength = 8
        Me.txtPesoMercaderia.Name = "txtPesoMercaderia"
        Me.txtPesoMercaderia.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtPesoMercaderia.Size = New System.Drawing.Size(103, 26)
        Me.txtPesoMercaderia.TabIndex = 59
        Me.txtPesoMercaderia.Tag = ""
        Me.txtPesoMercaderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostoTramo
        '
        Me.txtCostoTramo.Location = New System.Drawing.Point(817, 388)
        Me.txtCostoTramo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostoTramo.MaxLength = 10
        Me.txtCostoTramo.Name = "txtCostoTramo"
        Me.txtCostoTramo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtCostoTramo.Size = New System.Drawing.Size(103, 26)
        Me.txtCostoTramo.TabIndex = 57
        Me.txtCostoTramo.Tag = ""
        Me.txtCostoTramo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVolumenRemision
        '
        Me.txtVolumenRemision.Location = New System.Drawing.Point(605, 319)
        Me.txtVolumenRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolumenRemision.MaxLength = 5
        Me.txtVolumenRemision.Name = "txtVolumenRemision"
        Me.txtVolumenRemision.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtVolumenRemision.Size = New System.Drawing.Size(103, 26)
        Me.txtVolumenRemision.TabIndex = 47
        Me.txtVolumenRemision.Tag = ""
        Me.txtVolumenRemision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorPatrimonio
        '
        Me.txtValorPatrimonio.Location = New System.Drawing.Point(33, 105)
        Me.txtValorPatrimonio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorPatrimonio.MaxLength = 10
        Me.txtValorPatrimonio.Name = "txtValorPatrimonio"
        Me.txtValorPatrimonio.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtValorPatrimonio.Size = New System.Drawing.Size(20, 26)
        Me.txtValorPatrimonio.TabIndex = 41
        Me.txtValorPatrimonio.Tag = ""
        Me.txtValorPatrimonio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorPatrimonio.Visible = False
        '
        'txtKmPorRecorrer
        '
        Me.txtKmPorRecorrer.Location = New System.Drawing.Point(605, 388)
        Me.txtKmPorRecorrer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKmPorRecorrer.MaxLength = 9
        Me.txtKmPorRecorrer.Name = "txtKmPorRecorrer"
        Me.txtKmPorRecorrer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtKmPorRecorrer.Size = New System.Drawing.Size(103, 26)
        Me.txtKmPorRecorrer.TabIndex = 55
        Me.txtKmPorRecorrer.Tag = ""
        Me.txtKmPorRecorrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(937, 39)
        Me.KryptonLabel18.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(54, 24)
        Me.KryptonLabel18.TabIndex = 63
        Me.KryptonLabel18.Text = "Factor"
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Factor"
        '
        'KryptonLabel23
        '
        Me.KryptonLabel23.Location = New System.Drawing.Point(1147, 39)
        Me.KryptonLabel23.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel23.Name = "KryptonLabel23"
        Me.KryptonLabel23.Size = New System.Drawing.Size(67, 24)
        Me.KryptonLabel23.TabIndex = 64
        Me.KryptonLabel23.Text = "A Cargo"
        Me.KryptonLabel23.Values.ExtraText = ""
        Me.KryptonLabel23.Values.Image = Nothing
        Me.KryptonLabel23.Values.Text = "A Cargo"
        '
        'KryptonLabel29
        '
        Me.KryptonLabel29.Location = New System.Drawing.Point(713, 423)
        Me.KryptonLabel29.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel29.Name = "KryptonLabel29"
        Me.KryptonLabel29.Size = New System.Drawing.Size(85, 24)
        Me.KryptonLabel29.TabIndex = 60
        Me.KryptonLabel29.Text = "Peso Bruto"
        Me.KryptonLabel29.Values.ExtraText = ""
        Me.KryptonLabel29.Values.Image = Nothing
        Me.KryptonLabel29.Values.Text = "Peso Bruto"
        '
        'KryptonLabel38
        '
        Me.KryptonLabel38.Location = New System.Drawing.Point(713, 389)
        Me.KryptonLabel38.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel38.Name = "KryptonLabel38"
        Me.KryptonLabel38.Size = New System.Drawing.Size(99, 24)
        Me.KryptonLabel38.TabIndex = 56
        Me.KryptonLabel38.Text = "Costo Tramo"
        Me.KryptonLabel38.Values.ExtraText = ""
        Me.KryptonLabel38.Values.Image = Nothing
        Me.KryptonLabel38.Values.Text = "Costo Tramo"
        '
        'cboDestinoUbigeo
        '
        Me.cboDestinoUbigeo.BackColor = System.Drawing.Color.White
        Me.cboDestinoUbigeo.Codigo = ""
        Me.cboDestinoUbigeo.ControlHeight = 23
        Me.cboDestinoUbigeo.ControlImage = True
        Me.cboDestinoUbigeo.ControlReadOnly = False
        Me.cboDestinoUbigeo.Descripcion = ""
        Me.cboDestinoUbigeo.DisplayColumnVisible = True
        Me.cboDestinoUbigeo.DisplayMember = ""
        Me.cboDestinoUbigeo.KeyColumnWidth = 100
        Me.cboDestinoUbigeo.KeyField = ""
        Me.cboDestinoUbigeo.KeySearch = True
        Me.cboDestinoUbigeo.Location = New System.Drawing.Point(136, 386)
        Me.cboDestinoUbigeo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDestinoUbigeo.Name = "cboDestinoUbigeo"
        Me.cboDestinoUbigeo.Size = New System.Drawing.Size(317, 23)
        Me.cboDestinoUbigeo.TabIndex = 22
        Me.cboDestinoUbigeo.Tag = ""
        Me.cboDestinoUbigeo.TextBackColor = System.Drawing.Color.Empty
        Me.cboDestinoUbigeo.TextForeColor = System.Drawing.Color.Empty
        Me.cboDestinoUbigeo.ValueColumnVisible = True
        Me.cboDestinoUbigeo.ValueColumnWidth = 600
        Me.cboDestinoUbigeo.ValueField = ""
        Me.cboDestinoUbigeo.ValueMember = ""
        Me.cboDestinoUbigeo.ValueSearch = True
        '
        'cboOrigenUbigeo
        '
        Me.cboOrigenUbigeo.BackColor = System.Drawing.Color.White
        Me.cboOrigenUbigeo.Codigo = ""
        Me.cboOrigenUbigeo.ControlHeight = 23
        Me.cboOrigenUbigeo.ControlImage = True
        Me.cboOrigenUbigeo.ControlReadOnly = False
        Me.cboOrigenUbigeo.Descripcion = ""
        Me.cboOrigenUbigeo.DisplayColumnVisible = True
        Me.cboOrigenUbigeo.DisplayMember = ""
        Me.cboOrigenUbigeo.KeyColumnWidth = 100
        Me.cboOrigenUbigeo.KeyField = ""
        Me.cboOrigenUbigeo.KeySearch = True
        Me.cboOrigenUbigeo.Location = New System.Drawing.Point(136, 283)
        Me.cboOrigenUbigeo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboOrigenUbigeo.Name = "cboOrigenUbigeo"
        Me.cboOrigenUbigeo.Size = New System.Drawing.Size(317, 23)
        Me.cboOrigenUbigeo.TabIndex = 16
        Me.cboOrigenUbigeo.Tag = ""
        Me.cboOrigenUbigeo.TextBackColor = System.Drawing.Color.Empty
        Me.cboOrigenUbigeo.TextForeColor = System.Drawing.Color.Empty
        Me.cboOrigenUbigeo.ValueColumnVisible = True
        Me.cboOrigenUbigeo.ValueColumnWidth = 600
        Me.cboOrigenUbigeo.ValueField = ""
        Me.cboOrigenUbigeo.ValueMember = ""
        Me.cboOrigenUbigeo.ValueSearch = True
        '
        'txtLugar
        '
        Me.txtLugar.Enabled = False
        Me.txtLugar.Location = New System.Drawing.Point(304, 76)
        Me.txtLugar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtLugar.Size = New System.Drawing.Size(149, 19)
        Me.txtLugar.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugar.TabIndex = 7
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(256, 75)
        Me.KryptonLabel8.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(50, 24)
        Me.KryptonLabel8.TabIndex = 6
        Me.KryptonLabel8.Text = "Lugar"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Lugar"
        '
        'txtNroHojaGuia
        '
        Me.txtNroHojaGuia.Location = New System.Drawing.Point(833, 319)
        Me.txtNroHojaGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroHojaGuia.MaxLength = 8
        Me.txtNroHojaGuia.Name = "txtNroHojaGuia"
        Me.txtNroHojaGuia.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtNroHojaGuia.Size = New System.Drawing.Size(87, 26)
        Me.txtNroHojaGuia.TabIndex = 49
        Me.txtNroHojaGuia.Tag = ""
        Me.txtNroHojaGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecGuia
        '
        Me.dtpFecGuia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecGuia.Location = New System.Drawing.Point(136, 74)
        Me.dtpFecGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecGuia.Name = "dtpFecGuia"
        Me.dtpFecGuia.Size = New System.Drawing.Size(116, 22)
        Me.dtpFecGuia.TabIndex = 5
        Me.dtpFecGuia.Tag = ""
        Me.dtpFecGuia.Value = New Date(2009, 11, 18, 0, 0, 0, 0)
        '
        'dtpFecIniTrans
        '
        Me.dtpFecIniTrans.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIniTrans.Location = New System.Drawing.Point(136, 181)
        Me.dtpFecIniTrans.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecIniTrans.Name = "dtpFecIniTrans"
        Me.dtpFecIniTrans.Size = New System.Drawing.Size(112, 22)
        Me.dtpFecIniTrans.TabIndex = 10
        Me.dtpFecIniTrans.Tag = ""
        '
        'cboLugarDestino
        '
        Me.cboLugarDestino.BackColor = System.Drawing.Color.White
        Me.cboLugarDestino.Codigo = ""
        Me.cboLugarDestino.ControlHeight = 23
        Me.cboLugarDestino.ControlImage = True
        Me.cboLugarDestino.ControlReadOnly = False
        Me.cboLugarDestino.Descripcion = ""
        Me.cboLugarDestino.DisplayColumnVisible = True
        Me.cboLugarDestino.DisplayMember = ""
        Me.cboLugarDestino.Enabled = False
        Me.cboLugarDestino.KeyColumnWidth = 100
        Me.cboLugarDestino.KeyField = ""
        Me.cboLugarDestino.KeySearch = True
        Me.cboLugarDestino.Location = New System.Drawing.Point(136, 318)
        Me.cboLugarDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.cboLugarDestino.Name = "cboLugarDestino"
        Me.cboLugarDestino.Size = New System.Drawing.Size(317, 23)
        Me.cboLugarDestino.TabIndex = 18
        Me.cboLugarDestino.Tag = ""
        Me.cboLugarDestino.TextBackColor = System.Drawing.Color.Empty
        Me.cboLugarDestino.TextForeColor = System.Drawing.Color.Empty
        Me.cboLugarDestino.ValueColumnVisible = True
        Me.cboLugarDestino.ValueColumnWidth = 600
        Me.cboLugarDestino.ValueField = ""
        Me.cboLugarDestino.ValueMember = ""
        Me.cboLugarDestino.ValueSearch = True
        '
        'cboLugarOrigen
        '
        Me.cboLugarOrigen.BackColor = System.Drawing.Color.White
        Me.cboLugarOrigen.Codigo = ""
        Me.cboLugarOrigen.ControlHeight = 23
        Me.cboLugarOrigen.ControlImage = True
        Me.cboLugarOrigen.ControlReadOnly = False
        Me.cboLugarOrigen.Descripcion = ""
        Me.cboLugarOrigen.DisplayColumnVisible = True
        Me.cboLugarOrigen.DisplayMember = ""
        Me.cboLugarOrigen.Enabled = False
        Me.cboLugarOrigen.KeyColumnWidth = 100
        Me.cboLugarOrigen.KeyField = ""
        Me.cboLugarOrigen.KeySearch = True
        Me.cboLugarOrigen.Location = New System.Drawing.Point(136, 214)
        Me.cboLugarOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.cboLugarOrigen.Name = "cboLugarOrigen"
        Me.cboLugarOrigen.Size = New System.Drawing.Size(317, 23)
        Me.cboLugarOrigen.TabIndex = 12
        Me.cboLugarOrigen.Tag = ""
        Me.cboLugarOrigen.TextBackColor = System.Drawing.Color.Empty
        Me.cboLugarOrigen.TextForeColor = System.Drawing.Color.Empty
        Me.cboLugarOrigen.ValueColumnVisible = True
        Me.cboLugarOrigen.ValueColumnWidth = 600
        Me.cboLugarOrigen.ValueField = ""
        Me.cboLugarOrigen.ValueMember = ""
        Me.cboLugarOrigen.ValueSearch = True
        '
        'txtGalsDiesel
        '
        Me.txtGalsDiesel.Location = New System.Drawing.Point(817, 353)
        Me.txtGalsDiesel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGalsDiesel.MaxLength = 6
        Me.txtGalsDiesel.Name = "txtGalsDiesel"
        Me.txtGalsDiesel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtGalsDiesel.Size = New System.Drawing.Size(103, 26)
        Me.txtGalsDiesel.TabIndex = 53
        Me.txtGalsDiesel.Tag = ""
        Me.txtGalsDiesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantMercaderia
        '
        Me.txtCantMercaderia.Location = New System.Drawing.Point(136, 422)
        Me.txtCantMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantMercaderia.MaxLength = 8
        Me.txtCantMercaderia.Name = "txtCantMercaderia"
        Me.txtCantMercaderia.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtCantMercaderia.Size = New System.Drawing.Size(100, 26)
        Me.txtCantMercaderia.TabIndex = 24
        Me.txtCantMercaderia.Tag = ""
        Me.txtCantMercaderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGalsGasolina
        '
        Me.txtGalsGasolina.Location = New System.Drawing.Point(605, 353)
        Me.txtGalsGasolina.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGalsGasolina.MaxLength = 6
        Me.txtGalsGasolina.Name = "txtGalsGasolina"
        Me.txtGalsGasolina.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtGalsGasolina.Size = New System.Drawing.Size(103, 26)
        Me.txtGalsGasolina.TabIndex = 51
        Me.txtGalsGasolina.Tag = ""
        Me.txtGalsGasolina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDirDestino
        '
        Me.txtDirDestino.Location = New System.Drawing.Point(136, 353)
        Me.txtDirDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirDestino.MaxLength = 50
        Me.txtDirDestino.Name = "txtDirDestino"
        Me.txtDirDestino.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtDirDestino.Size = New System.Drawing.Size(317, 26)
        Me.txtDirDestino.TabIndex = 20
        Me.txtDirDestino.Tag = ""
        '
        'txtDirOrigen
        '
        Me.txtDirOrigen.Location = New System.Drawing.Point(136, 250)
        Me.txtDirOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirOrigen.MaxLength = 50
        Me.txtDirOrigen.Name = "txtDirOrigen"
        Me.txtDirOrigen.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtDirOrigen.Size = New System.Drawing.Size(317, 26)
        Me.txtDirOrigen.TabIndex = 14
        Me.txtDirOrigen.Tag = ""
        '
        'txtNroRemision
        '
        Me.txtNroRemision.Location = New System.Drawing.Point(136, 38)
        Me.txtNroRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroRemision.MaxLength = 12
        Me.txtNroRemision.Name = "txtNroRemision"
        Me.txtNroRemision.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtNroRemision.Size = New System.Drawing.Size(117, 26)
        Me.txtNroRemision.TabIndex = 2
        Me.txtNroRemision.Tag = ""
        Me.txtNroRemision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(7, 182)
        Me.KryptonLabel16.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(113, 24)
        Me.KryptonLabel16.TabIndex = 9
        Me.KryptonLabel16.Text = "Fecha Traslado"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Fecha Traslado"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.tsSeparador_4, Me.btnImprimir})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1430, 27)
        Me.MenuBar.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 24)
        Me.btnGuardar.Text = "Guardar"
        '
        'tsSeparador_4
        '
        Me.tsSeparador_4.Name = "tsSeparador_4"
        Me.tsSeparador_4.Size = New System.Drawing.Size(6, 27)
        Me.tsSeparador_4.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.printer2
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(89, 24)
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Visible = False
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(925, 32)
        Me.KryptonBorderEdge1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 431)
        Me.KryptonBorderEdge1.TabIndex = 62
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'KryptonBorderEdge5
        '
        Me.KryptonBorderEdge5.Location = New System.Drawing.Point(460, 32)
        Me.KryptonBorderEdge5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonBorderEdge5.Name = "KryptonBorderEdge5"
        Me.KryptonBorderEdge5.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.KryptonBorderEdge5.Size = New System.Drawing.Size(1, 431)
        Me.KryptonBorderEdge5.TabIndex = 26
        Me.KryptonBorderEdge5.Text = "KryptonBorderEdge5"
        '
        'txtConfigTracto
        '
        Me.txtConfigTracto.Location = New System.Drawing.Point(605, 144)
        Me.txtConfigTracto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfigTracto.Name = "txtConfigTracto"
        Me.txtConfigTracto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtConfigTracto.ReadOnly = True
        Me.txtConfigTracto.Size = New System.Drawing.Size(195, 26)
        Me.txtConfigTracto.TabIndex = 34
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(939, 363)
        Me.KryptonLabel10.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(172, 24)
        Me.KryptonLabel10.TabIndex = 67
        Me.KryptonLabel10.Text = "Descripción Mercadería"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Descripción Mercadería"
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(713, 354)
        Me.KryptonLabel17.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(89, 24)
        Me.KryptonLabel17.TabIndex = 52
        Me.KryptonLabel17.Text = "Gals. Diesel"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Gals. Diesel"
        '
        'KryptonLabel30
        '
        Me.KryptonLabel30.Location = New System.Drawing.Point(465, 111)
        Me.KryptonLabel30.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel30.Name = "KryptonLabel30"
        Me.KryptonLabel30.Size = New System.Drawing.Size(116, 24)
        Me.KryptonLabel30.TabIndex = 31
        Me.KryptonLabel30.Text = "Placa Acoplado"
        Me.KryptonLabel30.Values.ExtraText = ""
        Me.KryptonLabel30.Values.Image = Nothing
        Me.KryptonLabel30.Values.Text = "Placa Acoplado"
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(465, 389)
        Me.KryptonLabel19.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(107, 24)
        Me.KryptonLabel19.TabIndex = 54
        Me.KryptonLabel19.Text = "Km x Recorrer"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Km x Recorrer"
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(465, 320)
        Me.KryptonLabel21.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(139, 24)
        Me.KryptonLabel21.TabIndex = 46
        Me.KryptonLabel21.Text = "Volumen Remisión"
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "Volumen Remisión"
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(465, 217)
        Me.KryptonLabel22.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(105, 24)
        Me.KryptonLabel22.TabIndex = 38
        Me.KryptonLabel22.Text = "Moneda Flete"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Moneda Flete"
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(465, 182)
        Me.KryptonLabel24.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(139, 24)
        Me.KryptonLabel24.TabIndex = 36
        Me.KryptonLabel24.Text = "Brevete Conductor"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Brevete Conductor"
        '
        'KryptonLabel25
        '
        Me.KryptonLabel25.Location = New System.Drawing.Point(465, 75)
        Me.KryptonLabel25.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel25.Name = "KryptonLabel25"
        Me.KryptonLabel25.Size = New System.Drawing.Size(94, 24)
        Me.KryptonLabel25.TabIndex = 29
        Me.KryptonLabel25.Text = "Placa Tracto"
        Me.KryptonLabel25.Values.ExtraText = ""
        Me.KryptonLabel25.Values.Image = Nothing
        Me.KryptonLabel25.Values.Text = "Placa Tracto"
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(465, 423)
        Me.KryptonLabel26.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(82, 24)
        Me.KryptonLabel26.TabIndex = 58
        Me.KryptonLabel26.Text = "Peso Neto"
        Me.KryptonLabel26.Values.ExtraText = ""
        Me.KryptonLabel26.Values.Image = Nothing
        Me.KryptonLabel26.Values.Text = "Peso Neto"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(465, 354)
        Me.KryptonLabel15.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(106, 24)
        Me.KryptonLabel15.TabIndex = 50
        Me.KryptonLabel15.Text = "Gals. Gasolina"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Gals. Gasolina"
        '
        'KryptonLabel50
        '
        Me.KryptonLabel50.Location = New System.Drawing.Point(465, 145)
        Me.KryptonLabel50.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel50.Name = "KryptonLabel50"
        Me.KryptonLabel50.Size = New System.Drawing.Size(127, 24)
        Me.KryptonLabel50.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel50.StateCommon.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel50.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel50.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel50.TabIndex = 33
        Me.KryptonLabel50.Text = "Config. Vehícular"
        Me.KryptonLabel50.Values.ExtraText = ""
        Me.KryptonLabel50.Values.Image = Nothing
        Me.KryptonLabel50.Values.Text = "Config. Vehícular"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(5, 389)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(118, 24)
        Me.KryptonLabel4.TabIndex = 21
        Me.KryptonLabel4.Text = "Destino Ubigeo"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Destino Ubigeo"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(5, 286)
        Me.KryptonLabel7.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(112, 24)
        Me.KryptonLabel7.TabIndex = 15
        Me.KryptonLabel7.Text = "Origen Ubigeo"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Origen Ubigeo"
        '
        'KryptonLabel27
        '
        Me.KryptonLabel27.Location = New System.Drawing.Point(713, 320)
        Me.KryptonLabel27.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel27.Name = "KryptonLabel27"
        Me.KryptonLabel27.Size = New System.Drawing.Size(122, 24)
        Me.KryptonLabel27.TabIndex = 48
        Me.KryptonLabel27.Text = "N° Hoja Carguío"
        Me.KryptonLabel27.Values.ExtraText = ""
        Me.KryptonLabel27.Values.Image = Nothing
        Me.KryptonLabel27.Values.Text = "N° Hoja Carguío"
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(7, 320)
        Me.KryptonLabel14.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(128, 24)
        Me.KryptonLabel14.TabIndex = 17
        Me.KryptonLabel14.Text = "Lugar de Destino"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Lugar de Destino"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(7, 423)
        Me.KryptonLabel11.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(127, 24)
        Me.KryptonLabel11.TabIndex = 23
        Me.KryptonLabel11.Text = "Cant. Mercadería"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Cant. Mercadería"
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(5, 251)
        Me.KryptonLabel12.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(126, 24)
        Me.KryptonLabel12.TabIndex = 13
        Me.KryptonLabel12.Text = "Dirección Origen"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Dirección Origen"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(7, 217)
        Me.KryptonLabel13.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(122, 24)
        Me.KryptonLabel13.TabIndex = 11
        Me.KryptonLabel13.Text = "Lugar de Origen"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Lugar de Origen"
        '
        'lblGuiaRemision
        '
        Me.lblGuiaRemision.Location = New System.Drawing.Point(7, 39)
        Me.lblGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGuiaRemision.Name = "lblGuiaRemision"
        Me.lblGuiaRemision.Size = New System.Drawing.Size(125, 24)
        Me.lblGuiaRemision.TabIndex = 1
        Me.lblGuiaRemision.Text = "N° G. Transporte"
        Me.lblGuiaRemision.Values.ExtraText = ""
        Me.lblGuiaRemision.Values.Image = Nothing
        Me.lblGuiaRemision.Values.Text = "N° G. Transporte"
        '
        'KryptonLabel48
        '
        Me.KryptonLabel48.Location = New System.Drawing.Point(7, 75)
        Me.KryptonLabel48.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel48.Name = "KryptonLabel48"
        Me.KryptonLabel48.Size = New System.Drawing.Size(127, 24)
        Me.KryptonLabel48.TabIndex = 4
        Me.KryptonLabel48.Text = "Fecha Guía Trans"
        Me.KryptonLabel48.Values.ExtraText = ""
        Me.KryptonLabel48.Values.Image = Nothing
        Me.KryptonLabel48.Values.Text = "Fecha Guía Trans"
        '
        'KryptonLabel49
        '
        Me.KryptonLabel49.Location = New System.Drawing.Point(7, 354)
        Me.KryptonLabel49.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel49.Name = "KryptonLabel49"
        Me.KryptonLabel49.Size = New System.Drawing.Size(132, 24)
        Me.KryptonLabel49.TabIndex = 19
        Me.KryptonLabel49.Text = "Dirección Destino"
        Me.KryptonLabel49.Values.ExtraText = ""
        Me.KryptonLabel49.Values.Image = Nothing
        Me.KryptonLabel49.Values.Text = "Dirección Destino"
        '
        'KryptonLabel39
        '
        Me.KryptonLabel39.Location = New System.Drawing.Point(465, 251)
        Me.KryptonLabel39.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel39.Name = "KryptonLabel39"
        Me.KryptonLabel39.Size = New System.Drawing.Size(137, 24)
        Me.KryptonLabel39.TabIndex = 40
        Me.KryptonLabel39.Text = "Refer. Embarcador"
        Me.KryptonLabel39.Values.ExtraText = ""
        Me.KryptonLabel39.Values.Image = Nothing
        Me.KryptonLabel39.Values.Text = "Refer. Embarcador"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Guia Remision"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NRGUCL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Guia Remision Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FCGUCL_S"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Guia Remision"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cod. Cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NMNFCR"
        Me.DataGridViewTextBoxColumn6.HeaderText = "N° G. Transportista"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NGUICL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Guia Remision Cliente"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NORCMC"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Orden de Compra"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Guia Remision"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NGUIAD"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Guía Remisión Anexada"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FGUIRM"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha Guia Remisión"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn12.HeaderText = "N° Guía Remisión"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Nombre Cliente"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Cod. Cliente"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "FGUIRM_S"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Fecha Guía Remisión"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Guia Transportista"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NGUIAD"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Guía Transporte Adicional"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "FGUIRM"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Fecha Guia Transporte Adicional"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'frmGuiaTransportePasajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panelInformacion)
        Me.Controls.Add(Me.panelFiltros)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1432, 898)
        Me.MinimumSize = New System.Drawing.Size(1432, 898)
        Me.Name = "frmGuiaTransportePasajero"
        Me.Size = New System.Drawing.Size(1432, 898)
        CType(Me.panelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFiltros.ResumeLayout(False)
        CType(Me.KryptonHeaderCabecera.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderCabecera.Panel.ResumeLayout(False)
        Me.KryptonHeaderCabecera.Panel.PerformLayout()
        CType(Me.KryptonHeaderCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderCabecera.ResumeLayout(False)
        CType(Me.panelInformacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInformacion.ResumeLayout(False)
        Me.TabMantenimiento.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        CType(Me.HGGuiaRemisionAsignada.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGGuiaRemisionAsignada.Panel.ResumeLayout(False)
        Me.HGGuiaRemisionAsignada.Panel.PerformLayout()
        CType(Me.HGGuiaRemisionAsignada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGGuiaRemisionAsignada.ResumeLayout(False)
        CType(Me.panelRemisionAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRemisionAdicional.ResumeLayout(False)
        CType(Me.dtgGuiasSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar_1.ResumeLayout(False)
        Me.MenuBar_1.PerformLayout()
        CType(Me.KryptonHeaderDetalle.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderDetalle.Panel.ResumeLayout(False)
        Me.KryptonHeaderDetalle.Panel.PerformLayout()
        CType(Me.KryptonHeaderDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderDetalle.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpBoxConsignatario.ResumeLayout(False)
        Me.grpBoxConsignatario.PerformLayout()
        CType(Me.KryptonGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup4.Panel.ResumeLayout(False)
        Me.KryptonGroup4.Panel.PerformLayout()
        CType(Me.KryptonGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup4.ResumeLayout(False)
        Me.grpBoxRemitente.ResumeLayout(False)
        Me.grpBoxRemitente.PerformLayout()
        CType(Me.KryptonGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup3.Panel.ResumeLayout(False)
        Me.KryptonGroup3.Panel.PerformLayout()
        CType(Me.KryptonGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup3.ResumeLayout(False)
        CType(Me.KryptonGroup9.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup9.Panel.ResumeLayout(False)
        Me.KryptonGroup9.Panel.PerformLayout()
        CType(Me.KryptonGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup9.ResumeLayout(False)
        CType(Me.KryptonGroup8.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup8.Panel.ResumeLayout(False)
        Me.KryptonGroup8.Panel.PerformLayout()
        CType(Me.KryptonGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup8.ResumeLayout(False)
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonRadioButton3 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonRadioButton4 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents panelFiltros As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonHeaderCabecera As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtNroOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents panelInformacion As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonHeaderDetalle As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge5 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents tsSeparador_4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabMantenimiento As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboDestinoUbigeo As CodeTextBox.CodeTextBox
    Friend WithEvents cboOrigenUbigeo As CodeTextBox.CodeTextBox
    Friend WithEvents txtLugar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroHojaGuia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFecGuia As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecIniTrans As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboLugarDestino As CodeTextBox.CodeTextBox
    Friend WithEvents cboLugarOrigen As CodeTextBox.CodeTextBox
    Friend WithEvents txtGalsDiesel As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtGalsGasolina As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDirDestino As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDirOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroRemision As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroPlaneamiento As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel48 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel49 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup9 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents rbtnIdaVuelta As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnIda As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents chkMercPeligrosa As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonGroup8 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents rbtnDestinatario As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnRemitente As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents chkMercPerecible As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboMonedaValorPatr As CodeTextBox.CodeTextBox
    Friend WithEvents txtPesoBruto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPesoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCostoTramo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtVolumenRemision As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtValorPatrimonio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtKmPorRecorrer As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel39 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel38 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObservación As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents grpBoxConsignatario As System.Windows.Forms.GroupBox
    Friend WithEvents txtNomConsignatario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel33 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDirConsignatario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroDocConsignatario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel31 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup4 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents rbtnRUCConsignatario As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnDNIConsignatario As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents grpBoxRemitente As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel37 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel36 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel35 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDirRemitente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonGroup3 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents rbtnRUCRemit As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnDNIRemit As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents txtNroDocRemitente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel34 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checkGenerar As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtTransportista As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTracto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtConductor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents HGGuiaRemisionAsignada As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents panelRemisionAdicional As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents MenuBar_1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnQuitarElemento As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtgGuiasSeleccionadas As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtConfigTracto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel50 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnConfigTracto As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents UcCNomConsignatario As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents UcCNomRemitente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents chkCliente As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblNumeroGuias As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecGuiaETA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecGuiaETD As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel46 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnAsignarPasajero As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtOrdenEmbarcador As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents SELECCIONA As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents NMBPER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPRGVJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSLDRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HSLDRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPlanta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMonFlete As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUnidadMed As ComponentFactory.Krypton.Toolkit.KryptonTextBox

End Class
