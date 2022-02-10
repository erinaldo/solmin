<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotizaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCotizaciones))
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Contenedor1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.HGPanelCotizaciones = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.ctlCliente = New CodeTextBox.CodeTextBox
        Me.dtpFechaFinalizacion = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.txtNroContrato = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtContacto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ctlCompania = New CodeTextBox.CodeTextBox
        Me.ctlPlanta = New CodeTextBox.CodeTextBox
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel34 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel31 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.BarraCotización = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.txtNroCotizacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cboEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroCotizacionConsulta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ctlClienteConsulta = New CodeTextBox.CodeTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.HeaderConsulta = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.dtgCotizacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PopupMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.HGDetalleServicio = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtgTarifasServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ctlClienteTarifario = New CodeTextBox.CodeTextBox
        Me.ctlServiciosTarifarios = New CodeTextBox.CodeTextBox
        Me.cboDivisionTarifas = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge5 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.txtObservacionesServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.CodeTextBox8 = New CodeTextBox.CodeTextBox
        Me.CodeTextBox11 = New CodeTextBox.CodeTextBox
        Me.CodeTextBox13 = New CodeTextBox.CodeTextBox
        Me.CodeTextBox14 = New CodeTextBox.CodeTextBox
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTope = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.cboFiltroNegocio = New System.Windows.Forms.ToolStripComboBox
        Me.HGCotizaciones = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.dtgDetalleServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtgBitacora = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRecordatorio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dtpRecordatorio = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.HGTarifas = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.btnNuevaCotizacion = New System.Windows.Forms.ToolStripButton
        Me.btnGuardarCotizacion = New System.Windows.Forms.ToolStripButton
        Me.btnEliminarCotizacion = New System.Windows.Forms.ToolStripButton
        Me.btnCancelarCotizacion = New System.Windows.Forms.ToolStripButton
        Me.btnOpcionCotizacion = New System.Windows.Forms.ToolStripSplitButton
        Me.btnAceptarCotizacion = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnRechazarCotizacion = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnImprimirContrato = New System.Windows.Forms.ToolStripButton
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.btnImprimir = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.AceptarCotizaciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.RechazarCotizaciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ImprimirCotizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnNuevoServicio = New System.Windows.Forms.ToolStripButton
        Me.btnGuardarServicio = New System.Windows.Forms.ToolStripButton
        Me.btnEliminarServicio = New System.Windows.Forms.ToolStripButton
        Me.btnCancelarServicio = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton
        Me.btnRegistrarComentarioServicio = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnEliminarComentarioServicio = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnImprimirDetalleServicio = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        CType(Me.Contenedor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contenedor1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor1.Panel1.SuspendLayout()
        CType(Me.Contenedor1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor1.Panel2.SuspendLayout()
        Me.Contenedor1.SuspendLayout()
        CType(Me.HGPanelCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGPanelCotizaciones.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGPanelCotizaciones.Panel.SuspendLayout()
        Me.HGPanelCotizaciones.SuspendLayout()
        Me.BarraCotización.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dtgCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupMenu.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.HGDetalleServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGDetalleServicio.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGDetalleServicio.Panel.SuspendLayout()
        Me.HGDetalleServicio.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        CType(Me.dtgTarifasServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.dtgDetalleServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dtgBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonManager1
        '
        Me.KryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'Contenedor1
        '
        Me.Contenedor1.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlStandalone
        Me.Contenedor1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Contenedor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor1.IsSplitterFixed = True
        Me.Contenedor1.Location = New System.Drawing.Point(0, 0)
        Me.Contenedor1.Name = "Contenedor1"
        Me.Contenedor1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Contenedor1.Panel1
        '
        Me.Contenedor1.Panel1.Controls.Add(Me.HGPanelCotizaciones)
        Me.Contenedor1.Panel1.Controls.Add(Me.KryptonPanel1)
        Me.Contenedor1.Panel1.Controls.Add(Me.HeaderConsulta)
        Me.Contenedor1.Panel1.Controls.Add(Me.dtgCotizacion)
        Me.Contenedor1.Panel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuInner
        '
        'Contenedor1.Panel2
        '
        Me.Contenedor1.Panel2.Controls.Add(Me.KryptonSplitContainer1)
        Me.Contenedor1.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlStandalone
        Me.Contenedor1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.Contenedor1.Size = New System.Drawing.Size(1028, 631)
        Me.Contenedor1.SplitterDistance = 285
        Me.Contenedor1.TabIndex = 2
        '
        'HGPanelCotizaciones
        '
        Me.HGPanelCotizaciones.AutoSize = True
        Me.HGPanelCotizaciones.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.HGPanelCotizaciones.Collapsed = True
        Me.HGPanelCotizaciones.Dock = System.Windows.Forms.DockStyle.Right
        Me.HGPanelCotizaciones.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone
        Me.HGPanelCotizaciones.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonForm
        Me.HGPanelCotizaciones.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.HGPanelCotizaciones.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.HGPanelCotizaciones.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HGPanelCotizaciones.HeaderVisibleSecondary = False
        Me.HGPanelCotizaciones.Location = New System.Drawing.Point(1002, 76)
        Me.HGPanelCotizaciones.Name = "HGPanelCotizaciones"
        '
        'HGPanelCotizaciones.Panel
        '
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.ctlCliente)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.dtpFechaFinalizacion)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.txtNroContrato)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.txtObservaciones)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.txtContacto)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.ctlCompania)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.ctlPlanta)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonBorderEdge1)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonLabel34)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonLabel32)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonLabel17)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonLabel31)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.BarraCotización)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.txtNroCotizacion)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonLabel16)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonLabel18)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonLabel19)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonLabel14)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonLabel21)
        Me.HGPanelCotizaciones.Panel.Controls.Add(Me.KryptonLabel20)
        Me.HGPanelCotizaciones.Size = New System.Drawing.Size(26, 209)
        Me.HGPanelCotizaciones.TabIndex = 40
        Me.HGPanelCotizaciones.Text = "Registro de Cotización"
        Me.HGPanelCotizaciones.ValuesPrimary.Description = ""
        Me.HGPanelCotizaciones.ValuesPrimary.Heading = "Registro de Cotización"
        Me.HGPanelCotizaciones.ValuesPrimary.Image = Global.Solmin.My.Resources.Resources.effect
        Me.HGPanelCotizaciones.ValuesSecondary.Description = ""
        Me.HGPanelCotizaciones.ValuesSecondary.Heading = "Description"
        Me.HGPanelCotizaciones.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowRight
        Me.ButtonSpecHeaderGroup1.UniqueName = "F33DD85356484E65F33DD85356484E65"
        '
        'ctlCliente
        '
        Me.ctlCliente.Codigo = ""
        Me.ctlCliente.ControlHeight = 23
        Me.ctlCliente.ControlImage = True
        Me.ctlCliente.ControlReadOnly = False
        Me.ctlCliente.Descripcion = ""
        Me.ctlCliente.DisplayColumnVisible = True
        Me.ctlCliente.DisplayMember = ""
        Me.ctlCliente.KeyColumnWidth = 100
        Me.ctlCliente.KeyField = ""
        Me.ctlCliente.KeySearch = True
        Me.ctlCliente.Location = New System.Drawing.Point(96, 148)
        Me.ctlCliente.Name = "ctlCliente"
        Me.ctlCliente.Size = New System.Drawing.Size(196, 23)
        Me.ctlCliente.TabIndex = 44
        Me.ctlCliente.TextBackColor = System.Drawing.Color.Empty
        Me.ctlCliente.TextForeColor = System.Drawing.Color.Empty
        Me.ctlCliente.ValueColumnVisible = True
        Me.ctlCliente.ValueColumnWidth = 600
        Me.ctlCliente.ValueField = ""
        Me.ctlCliente.ValueMember = ""
        Me.ctlCliente.ValueSearch = True
        '
        'dtpFechaFinalizacion
        '
        Me.dtpFechaFinalizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinalizacion.Location = New System.Drawing.Point(452, 60)
        Me.dtpFechaFinalizacion.Name = "dtpFechaFinalizacion"
        Me.dtpFechaFinalizacion.Size = New System.Drawing.Size(96, 21)
        Me.dtpFechaFinalizacion.TabIndex = 43
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(452, 36)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(96, 21)
        Me.dtpFechaInicio.TabIndex = 42
        '
        'txtNroContrato
        '
        Me.txtNroContrato.Location = New System.Drawing.Point(96, 68)
        Me.txtNroContrato.Name = "txtNroContrato"
        Me.txtNroContrato.Size = New System.Drawing.Size(192, 19)
        Me.txtNroContrato.TabIndex = 41
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(308, 104)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(260, 96)
        Me.txtObservaciones.TabIndex = 37
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(96, 176)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(196, 19)
        Me.txtContacto.TabIndex = 38
        '
        'ctlCompania
        '
        Me.ctlCompania.Codigo = ""
        Me.ctlCompania.ControlHeight = 23
        Me.ctlCompania.ControlImage = True
        Me.ctlCompania.ControlReadOnly = False
        Me.ctlCompania.Descripcion = ""
        Me.ctlCompania.DisplayColumnVisible = True
        Me.ctlCompania.DisplayMember = ""
        Me.ctlCompania.KeyColumnWidth = 100
        Me.ctlCompania.KeyField = ""
        Me.ctlCompania.KeySearch = True
        Me.ctlCompania.Location = New System.Drawing.Point(96, 92)
        Me.ctlCompania.Name = "ctlCompania"
        Me.ctlCompania.Size = New System.Drawing.Size(196, 23)
        Me.ctlCompania.TabIndex = 10
        Me.ctlCompania.TextBackColor = System.Drawing.Color.Empty
        Me.ctlCompania.TextForeColor = System.Drawing.Color.Empty
        Me.ctlCompania.ValueColumnVisible = True
        Me.ctlCompania.ValueColumnWidth = 600
        Me.ctlCompania.ValueField = ""
        Me.ctlCompania.ValueMember = ""
        Me.ctlCompania.ValueSearch = True
        '
        'ctlPlanta
        '
        Me.ctlPlanta.Codigo = ""
        Me.ctlPlanta.ControlHeight = 23
        Me.ctlPlanta.ControlImage = True
        Me.ctlPlanta.ControlReadOnly = False
        Me.ctlPlanta.Descripcion = ""
        Me.ctlPlanta.DisplayColumnVisible = True
        Me.ctlPlanta.DisplayMember = ""
        Me.ctlPlanta.KeyColumnWidth = 100
        Me.ctlPlanta.KeyField = ""
        Me.ctlPlanta.KeySearch = True
        Me.ctlPlanta.Location = New System.Drawing.Point(96, 120)
        Me.ctlPlanta.Name = "ctlPlanta"
        Me.ctlPlanta.Size = New System.Drawing.Size(196, 23)
        Me.ctlPlanta.TabIndex = 11
        Me.ctlPlanta.TextBackColor = System.Drawing.Color.Empty
        Me.ctlPlanta.TextForeColor = System.Drawing.Color.Empty
        Me.ctlPlanta.ValueColumnVisible = True
        Me.ctlPlanta.ValueColumnWidth = 600
        Me.ctlPlanta.ValueField = ""
        Me.ctlPlanta.ValueMember = ""
        Me.ctlPlanta.ValueSearch = True
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(300, 40)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 160)
        Me.KryptonBorderEdge1.TabIndex = 35
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'KryptonLabel34
        '
        Me.KryptonLabel34.Location = New System.Drawing.Point(560, 168)
        Me.KryptonLabel34.Name = "KryptonLabel34"
        Me.KryptonLabel34.Size = New System.Drawing.Size(10, 16)
        Me.KryptonLabel34.TabIndex = 34
        Me.KryptonLabel34.Text = " "
        Me.KryptonLabel34.Values.ExtraText = ""
        Me.KryptonLabel34.Values.Image = Nothing
        Me.KryptonLabel34.Values.Text = " "
        '
        'KryptonLabel32
        '
        Me.KryptonLabel32.Location = New System.Drawing.Point(304, 88)
        Me.KryptonLabel32.Name = "KryptonLabel32"
        Me.KryptonLabel32.Size = New System.Drawing.Size(86, 16)
        Me.KryptonLabel32.TabIndex = 33
        Me.KryptonLabel32.Text = "Observaciones"
        Me.KryptonLabel32.Values.ExtraText = ""
        Me.KryptonLabel32.Values.Image = Nothing
        Me.KryptonLabel32.Values.Text = "Observaciones"
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(8, 180)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(56, 16)
        Me.KryptonLabel17.TabIndex = 29
        Me.KryptonLabel17.Text = "Contacto"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Contacto"
        '
        'KryptonLabel31
        '
        Me.KryptonLabel31.Location = New System.Drawing.Point(4, 152)
        Me.KryptonLabel31.Name = "KryptonLabel31"
        Me.KryptonLabel31.Size = New System.Drawing.Size(85, 16)
        Me.KryptonLabel31.TabIndex = 28
        Me.KryptonLabel31.Text = "Codigo Cliente"
        Me.KryptonLabel31.Values.ExtraText = ""
        Me.KryptonLabel31.Values.Image = Nothing
        Me.KryptonLabel31.Values.Text = "Codigo Cliente"
        '
        'BarraCotización
        '
        Me.BarraCotización.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BarraCotización.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarraCotización.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.BarraCotización.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaCotizacion, Me.ToolStripSeparator1, Me.btnGuardarCotizacion, Me.ToolStripSeparator2, Me.btnEliminarCotizacion, Me.ToolStripSeparator4, Me.btnCancelarCotizacion, Me.ToolStripSeparator6, Me.btnOpcionCotizacion, Me.ToolStripSeparator3, Me.btnImprimirContrato})
        Me.BarraCotización.Location = New System.Drawing.Point(0, 0)
        Me.BarraCotización.Name = "BarraCotización"
        Me.BarraCotización.Size = New System.Drawing.Size(148, 29)
        Me.BarraCotización.TabIndex = 4
        Me.BarraCotización.Text = "ToolStrip2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'txtNroCotizacion
        '
        Me.txtNroCotizacion.AcceptsReturn = True
        Me.txtNroCotizacion.AcceptsTab = True
        Me.txtNroCotizacion.Enabled = False
        Me.txtNroCotizacion.Location = New System.Drawing.Point(96, 40)
        Me.txtNroCotizacion.Name = "txtNroCotizacion"
        Me.txtNroCotizacion.Size = New System.Drawing.Size(192, 19)
        Me.txtNroCotizacion.TabIndex = 19
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(4, 68)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(96, 19)
        Me.KryptonLabel16.TabIndex = 5
        Me.KryptonLabel16.Text = "Número Contrato"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Número Contrato"
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(4, 96)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(97, 19)
        Me.KryptonLabel18.TabIndex = 20
        Me.KryptonLabel18.Text = "Codigo Compañía"
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Codigo Compañía"
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(4, 124)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(79, 19)
        Me.KryptonLabel19.TabIndex = 21
        Me.KryptonLabel19.Text = "Código Planta"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Código Planta"
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(4, 40)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(98, 19)
        Me.KryptonLabel14.TabIndex = 4
        Me.KryptonLabel14.Text = "Nro de Cotizacion"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Nro de Cotizacion"
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(304, 64)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(116, 19)
        Me.KryptonLabel21.TabIndex = 23
        Me.KryptonLabel21.Text = "Fecha de Finalización"
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "Fecha de Finalización"
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(304, 40)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(148, 19)
        Me.KryptonLabel20.TabIndex = 22
        Me.KryptonLabel20.Text = "Fecha de Inicio de Contrato"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Fecha de Inicio de Contrato"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.cboEstado)
        Me.KryptonPanel1.Controls.Add(Me.dtpHasta)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.dtpDesde)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.txtNroCotizacionConsulta)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel1.Controls.Add(Me.ctlClienteConsulta)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 26)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone
        Me.KryptonPanel1.Size = New System.Drawing.Size(1028, 50)
        Me.KryptonPanel1.TabIndex = 39
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.DropDownWidth = 104
        Me.cboEstado.FormattingEnabled = False
        Me.cboEstado.ItemHeight = 13
        Me.cboEstado.Items.AddRange(New Object() {"--- Escoja Elemento ---", "Pendientes", "Aceptadas", "Generadas"})
        Me.cboEstado.Location = New System.Drawing.Point(544, 24)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(104, 21)
        Me.cboEstado.TabIndex = 39
        '
        'dtpHasta
        '
        Me.dtpHasta.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Checked = False
        Me.dtpHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpHasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(900, 24)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(96, 21)
        Me.dtpHasta.TabIndex = 36
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 0)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(135, 17)
        Me.KryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 21
        Me.KryptonLabel1.Text = "Parámetros de Búsqueda"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Parámetros de Búsqueda"
        '
        'dtpDesde
        '
        Me.dtpDesde.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Checked = False
        Me.dtpDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpDesde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(728, 24)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(96, 21)
        Me.dtpDesde.TabIndex = 35
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(852, 28)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(43, 16)
        Me.KryptonLabel7.TabIndex = 34
        Me.KryptonLabel7.Text = " Hasta"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = " Hasta"
        '
        'txtNroCotizacionConsulta
        '
        Me.txtNroCotizacionConsulta.Location = New System.Drawing.Point(72, 24)
        Me.txtNroCotizacionConsulta.Name = "txtNroCotizacionConsulta"
        Me.txtNroCotizacionConsulta.Size = New System.Drawing.Size(124, 19)
        Me.txtNroCotizacionConsulta.TabIndex = 38
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(12, 28)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(61, 19)
        Me.KryptonLabel8.TabIndex = 37
        Me.KryptonLabel8.Text = "Cotización"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Cotización"
        '
        'ctlClienteConsulta
        '
        Me.ctlClienteConsulta.Codigo = ""
        Me.ctlClienteConsulta.ControlHeight = 23
        Me.ctlClienteConsulta.ControlImage = True
        Me.ctlClienteConsulta.ControlReadOnly = False
        Me.ctlClienteConsulta.Descripcion = ""
        Me.ctlClienteConsulta.DisplayColumnVisible = True
        Me.ctlClienteConsulta.DisplayMember = ""
        Me.ctlClienteConsulta.KeyColumnWidth = 100
        Me.ctlClienteConsulta.KeyField = ""
        Me.ctlClienteConsulta.KeySearch = True
        Me.ctlClienteConsulta.Location = New System.Drawing.Point(296, 24)
        Me.ctlClienteConsulta.Name = "ctlClienteConsulta"
        Me.ctlClienteConsulta.Size = New System.Drawing.Size(176, 23)
        Me.ctlClienteConsulta.TabIndex = 23
        Me.ctlClienteConsulta.TextBackColor = System.Drawing.Color.Empty
        Me.ctlClienteConsulta.TextForeColor = System.Drawing.Color.Empty
        Me.ctlClienteConsulta.ValueColumnVisible = True
        Me.ctlClienteConsulta.ValueColumnWidth = 600
        Me.ctlClienteConsulta.ValueField = ""
        Me.ctlClienteConsulta.ValueMember = ""
        Me.ctlClienteConsulta.ValueSearch = True
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(252, 28)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel2.TabIndex = 22
        Me.KryptonLabel2.Text = "Cliente"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Cliente"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(676, 28)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(45, 19)
        Me.KryptonLabel6.TabIndex = 32
        Me.KryptonLabel6.Text = " Desde"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = " Desde"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(500, 28)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel3.TabIndex = 24
        Me.KryptonLabel3.Text = "Estado"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Estado"
        '
        'HeaderConsulta
        '
        Me.HeaderConsulta.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnBuscar, Me.btnImprimir})
        Me.HeaderConsulta.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderConsulta.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderConsulta.Location = New System.Drawing.Point(0, 0)
        Me.HeaderConsulta.Name = "HeaderConsulta"
        Me.HeaderConsulta.Size = New System.Drawing.Size(1028, 26)
        Me.HeaderConsulta.TabIndex = 0
        Me.HeaderConsulta.Text = "Consulta de Cotizaciones"
        Me.HeaderConsulta.Values.Description = ""
        Me.HeaderConsulta.Values.Heading = "Consulta de Cotizaciones"
        Me.HeaderConsulta.Values.Image = Global.Solmin.My.Resources.Resources.irc_server
        '
        'dtgCotizacion
        '
        Me.dtgCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCotizacion.ContextMenuStrip = Me.PopupMenu
        Me.dtgCotizacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgCotizacion.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.dtgCotizacion.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuInner
        Me.dtgCotizacion.Location = New System.Drawing.Point(8, 84)
        Me.dtgCotizacion.Name = "dtgCotizacion"
        Me.dtgCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCotizacion.Size = New System.Drawing.Size(984, 196)
        Me.dtgCotizacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuInner
        Me.dtgCotizacion.TabIndex = 3
        '
        'PopupMenu
        '
        Me.PopupMenu.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.PopupMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarCotizaciónToolStripMenuItem1, Me.ToolStripMenuItem3, Me.RechazarCotizaciónToolStripMenuItem1, Me.ToolStripMenuItem4, Me.ImprimirCotizaciónToolStripMenuItem})
        Me.PopupMenu.Name = "PopupMenu"
        Me.PopupMenu.Size = New System.Drawing.Size(183, 82)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(179, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(179, 6)
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.IsSplitterFixed = True
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.HGDetalleServicio)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.ToolStrip3)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.HGCotizaciones)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dtgDetalleServicio)
        Me.KryptonSplitContainer1.Panel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabCustom3
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.txtRecordatorio)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dtpRecordatorio)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonLabel9)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonLabel4)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.HGTarifas)
        Me.KryptonSplitContainer1.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabCustom3
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1028, 341)
        Me.KryptonSplitContainer1.SplitterDistance = 563
        Me.KryptonSplitContainer1.TabIndex = 0
        '
        'HGDetalleServicio
        '
        Me.HGDetalleServicio.AutoSize = True
        Me.HGDetalleServicio.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup2})
        Me.HGDetalleServicio.Dock = System.Windows.Forms.DockStyle.Right
        Me.HGDetalleServicio.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.HGDetalleServicio.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HGDetalleServicio.HeaderVisibleSecondary = False
        Me.HGDetalleServicio.Location = New System.Drawing.Point(3, 51)
        Me.HGDetalleServicio.Name = "HGDetalleServicio"
        '
        'HGDetalleServicio.Panel
        '
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonHeaderGroup3)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonBorderEdge2)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.txtObservacionesServicio)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonTextBox2)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonTextBox1)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.CodeTextBox8)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.CodeTextBox11)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.CodeTextBox13)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.CodeTextBox14)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonLabel24)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonLabel25)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonLabel26)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonLabel27)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonLabel28)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonLabel29)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.KryptonLabel30)
        Me.HGDetalleServicio.Panel.Controls.Add(Me.lblTope)
        Me.HGDetalleServicio.Size = New System.Drawing.Size(560, 290)
        Me.HGDetalleServicio.TabIndex = 5
        Me.HGDetalleServicio.Text = "Información de Servicios"
        Me.HGDetalleServicio.ValuesPrimary.Description = ""
        Me.HGDetalleServicio.ValuesPrimary.Heading = "Información de Servicios"
        Me.HGDetalleServicio.ValuesPrimary.Image = Global.Solmin.My.Resources.Resources.ark_selectall
        Me.HGDetalleServicio.ValuesSecondary.Description = ""
        Me.HGDetalleServicio.ValuesSecondary.Heading = "Description"
        Me.HGDetalleServicio.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup2
        '
        Me.ButtonSpecHeaderGroup2.ExtraText = ""
        Me.ButtonSpecHeaderGroup2.Image = Nothing
        Me.ButtonSpecHeaderGroup2.Text = ""
        Me.ButtonSpecHeaderGroup2.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
        Me.ButtonSpecHeaderGroup2.UniqueName = "92432E96A10C433492432E96A10C4334"
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonHeaderGroup3.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup3.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(0, 132)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.dtgTarifasServicio)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.ctlClienteTarifario)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.ctlServiciosTarifarios)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.cboDivisionTarifas)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.KryptonBorderEdge5)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.KryptonLabel13)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(531, 156)
        Me.KryptonHeaderGroup3.TabIndex = 58
        Me.KryptonHeaderGroup3.Text = "Tarifas establecidas por Servicio"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Tarifas establecidas por Servicio"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = Global.Solmin.My.Resources.Resources.irc_server
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'dtgTarifasServicio
        '
        Me.dtgTarifasServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTarifasServicio.Location = New System.Drawing.Point(164, 8)
        Me.dtgTarifasServicio.Name = "dtgTarifasServicio"
        Me.dtgTarifasServicio.Size = New System.Drawing.Size(356, 116)
        Me.dtgTarifasServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgTarifasServicio.TabIndex = 61
        '
        'ctlClienteTarifario
        '
        Me.ctlClienteTarifario.Codigo = ""
        Me.ctlClienteTarifario.ControlHeight = 23
        Me.ctlClienteTarifario.ControlImage = True
        Me.ctlClienteTarifario.ControlReadOnly = False
        Me.ctlClienteTarifario.Descripcion = ""
        Me.ctlClienteTarifario.DisplayColumnVisible = True
        Me.ctlClienteTarifario.DisplayMember = ""
        Me.ctlClienteTarifario.KeyColumnWidth = 100
        Me.ctlClienteTarifario.KeyField = ""
        Me.ctlClienteTarifario.KeySearch = True
        Me.ctlClienteTarifario.Location = New System.Drawing.Point(8, 60)
        Me.ctlClienteTarifario.Name = "ctlClienteTarifario"
        Me.ctlClienteTarifario.Size = New System.Drawing.Size(140, 23)
        Me.ctlClienteTarifario.TabIndex = 17
        Me.ctlClienteTarifario.TextBackColor = System.Drawing.Color.Empty
        Me.ctlClienteTarifario.TextForeColor = System.Drawing.Color.Empty
        Me.ctlClienteTarifario.ValueColumnVisible = True
        Me.ctlClienteTarifario.ValueColumnWidth = 600
        Me.ctlClienteTarifario.ValueField = ""
        Me.ctlClienteTarifario.ValueMember = ""
        Me.ctlClienteTarifario.ValueSearch = True
        '
        'ctlServiciosTarifarios
        '
        Me.ctlServiciosTarifarios.Codigo = ""
        Me.ctlServiciosTarifarios.ControlHeight = 23
        Me.ctlServiciosTarifarios.ControlImage = True
        Me.ctlServiciosTarifarios.ControlReadOnly = False
        Me.ctlServiciosTarifarios.Descripcion = ""
        Me.ctlServiciosTarifarios.DisplayColumnVisible = True
        Me.ctlServiciosTarifarios.DisplayMember = ""
        Me.ctlServiciosTarifarios.KeyColumnWidth = 100
        Me.ctlServiciosTarifarios.KeyField = ""
        Me.ctlServiciosTarifarios.KeySearch = True
        Me.ctlServiciosTarifarios.Location = New System.Drawing.Point(8, 100)
        Me.ctlServiciosTarifarios.Name = "ctlServiciosTarifarios"
        Me.ctlServiciosTarifarios.Size = New System.Drawing.Size(140, 23)
        Me.ctlServiciosTarifarios.TabIndex = 10
        Me.ctlServiciosTarifarios.TextBackColor = System.Drawing.Color.Empty
        Me.ctlServiciosTarifarios.TextForeColor = System.Drawing.Color.Empty
        Me.ctlServiciosTarifarios.ValueColumnVisible = True
        Me.ctlServiciosTarifarios.ValueColumnWidth = 600
        Me.ctlServiciosTarifarios.ValueField = ""
        Me.ctlServiciosTarifarios.ValueMember = ""
        Me.ctlServiciosTarifarios.ValueSearch = True
        '
        'cboDivisionTarifas
        '
        Me.cboDivisionTarifas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisionTarifas.DropDownWidth = 200
        Me.cboDivisionTarifas.FormattingEnabled = False
        Me.cboDivisionTarifas.ItemHeight = 13
        Me.cboDivisionTarifas.Items.AddRange(New Object() {"--- Escoja Elemento ---", "SIL", "ALMACEN", "TRANSPORTES"})
        Me.cboDivisionTarifas.Location = New System.Drawing.Point(8, 20)
        Me.cboDivisionTarifas.Name = "cboDivisionTarifas"
        Me.cboDivisionTarifas.Size = New System.Drawing.Size(140, 21)
        Me.cboDivisionTarifas.TabIndex = 9
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(4, 4)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(49, 19)
        Me.KryptonLabel10.TabIndex = 2
        Me.KryptonLabel10.Text = "División"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "División"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(4, 84)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(49, 19)
        Me.KryptonLabel11.TabIndex = 3
        Me.KryptonLabel11.Text = "Servicio"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Servicio"
        '
        'KryptonBorderEdge5
        '
        Me.KryptonBorderEdge5.Location = New System.Drawing.Point(156, 12)
        Me.KryptonBorderEdge5.Name = "KryptonBorderEdge5"
        Me.KryptonBorderEdge5.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge5.Size = New System.Drawing.Size(1, 110)
        Me.KryptonBorderEdge5.TabIndex = 19
        Me.KryptonBorderEdge5.Text = "KryptonBorderEdge5"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(4, 44)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel13.TabIndex = 5
        Me.KryptonLabel13.Text = "Cliente"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Cliente"
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(276, 4)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(1, 120)
        Me.KryptonBorderEdge2.TabIndex = 57
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'txtObservacionesServicio
        '
        Me.txtObservacionesServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacionesServicio.Location = New System.Drawing.Point(284, 56)
        Me.txtObservacionesServicio.Multiline = True
        Me.txtObservacionesServicio.Name = "txtObservacionesServicio"
        Me.txtObservacionesServicio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionesServicio.Size = New System.Drawing.Size(240, 72)
        Me.txtObservacionesServicio.TabIndex = 56
        '
        'KryptonTextBox2
        '
        Me.KryptonTextBox2.Location = New System.Drawing.Point(336, 4)
        Me.KryptonTextBox2.Name = "KryptonTextBox2"
        Me.KryptonTextBox2.Size = New System.Drawing.Size(124, 19)
        Me.KryptonTextBox2.TabIndex = 55
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.Location = New System.Drawing.Point(72, 80)
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.KryptonTextBox1.Size = New System.Drawing.Size(196, 20)
        Me.KryptonTextBox1.TabIndex = 54
        '
        'CodeTextBox8
        '
        Me.CodeTextBox8.Codigo = ""
        Me.CodeTextBox8.ControlHeight = 23
        Me.CodeTextBox8.ControlImage = True
        Me.CodeTextBox8.ControlReadOnly = False
        Me.CodeTextBox8.Descripcion = ""
        Me.CodeTextBox8.DisplayColumnVisible = True
        Me.CodeTextBox8.DisplayMember = ""
        Me.CodeTextBox8.KeyColumnWidth = 100
        Me.CodeTextBox8.KeyField = ""
        Me.CodeTextBox8.KeySearch = True
        Me.CodeTextBox8.Location = New System.Drawing.Point(72, 104)
        Me.CodeTextBox8.Name = "CodeTextBox8"
        Me.CodeTextBox8.Size = New System.Drawing.Size(196, 23)
        Me.CodeTextBox8.TabIndex = 47
        Me.CodeTextBox8.TextBackColor = System.Drawing.Color.Empty
        Me.CodeTextBox8.TextForeColor = System.Drawing.Color.Empty
        Me.CodeTextBox8.ValueColumnVisible = True
        Me.CodeTextBox8.ValueColumnWidth = 600
        Me.CodeTextBox8.ValueField = ""
        Me.CodeTextBox8.ValueMember = ""
        Me.CodeTextBox8.ValueSearch = True
        '
        'CodeTextBox11
        '
        Me.CodeTextBox11.Codigo = ""
        Me.CodeTextBox11.ControlHeight = 23
        Me.CodeTextBox11.ControlImage = True
        Me.CodeTextBox11.ControlReadOnly = False
        Me.CodeTextBox11.Descripcion = ""
        Me.CodeTextBox11.DisplayColumnVisible = True
        Me.CodeTextBox11.DisplayMember = ""
        Me.CodeTextBox11.KeyColumnWidth = 100
        Me.CodeTextBox11.KeyField = ""
        Me.CodeTextBox11.KeySearch = True
        Me.CodeTextBox11.Location = New System.Drawing.Point(72, 56)
        Me.CodeTextBox11.Name = "CodeTextBox11"
        Me.CodeTextBox11.Size = New System.Drawing.Size(196, 23)
        Me.CodeTextBox11.TabIndex = 44
        Me.CodeTextBox11.TextBackColor = System.Drawing.Color.Empty
        Me.CodeTextBox11.TextForeColor = System.Drawing.Color.Empty
        Me.CodeTextBox11.ValueColumnVisible = True
        Me.CodeTextBox11.ValueColumnWidth = 600
        Me.CodeTextBox11.ValueField = ""
        Me.CodeTextBox11.ValueMember = ""
        Me.CodeTextBox11.ValueSearch = True
        '
        'CodeTextBox13
        '
        Me.CodeTextBox13.Codigo = ""
        Me.CodeTextBox13.ControlHeight = 23
        Me.CodeTextBox13.ControlImage = True
        Me.CodeTextBox13.ControlReadOnly = False
        Me.CodeTextBox13.Descripcion = ""
        Me.CodeTextBox13.DisplayColumnVisible = True
        Me.CodeTextBox13.DisplayMember = ""
        Me.CodeTextBox13.KeyColumnWidth = 100
        Me.CodeTextBox13.KeyField = ""
        Me.CodeTextBox13.KeySearch = True
        Me.CodeTextBox13.Location = New System.Drawing.Point(72, 32)
        Me.CodeTextBox13.Name = "CodeTextBox13"
        Me.CodeTextBox13.Size = New System.Drawing.Size(196, 23)
        Me.CodeTextBox13.TabIndex = 42
        Me.CodeTextBox13.TextBackColor = System.Drawing.Color.Empty
        Me.CodeTextBox13.TextForeColor = System.Drawing.Color.Empty
        Me.CodeTextBox13.ValueColumnVisible = True
        Me.CodeTextBox13.ValueColumnWidth = 600
        Me.CodeTextBox13.ValueField = ""
        Me.CodeTextBox13.ValueMember = ""
        Me.CodeTextBox13.ValueSearch = True
        '
        'CodeTextBox14
        '
        Me.CodeTextBox14.Codigo = ""
        Me.CodeTextBox14.ControlHeight = 23
        Me.CodeTextBox14.ControlImage = True
        Me.CodeTextBox14.ControlReadOnly = False
        Me.CodeTextBox14.Descripcion = ""
        Me.CodeTextBox14.DisplayColumnVisible = True
        Me.CodeTextBox14.DisplayMember = ""
        Me.CodeTextBox14.KeyColumnWidth = 100
        Me.CodeTextBox14.KeyField = ""
        Me.CodeTextBox14.KeySearch = True
        Me.CodeTextBox14.Location = New System.Drawing.Point(72, 8)
        Me.CodeTextBox14.Name = "CodeTextBox14"
        Me.CodeTextBox14.Size = New System.Drawing.Size(196, 23)
        Me.CodeTextBox14.TabIndex = 41
        Me.CodeTextBox14.TextBackColor = System.Drawing.Color.Empty
        Me.CodeTextBox14.TextForeColor = System.Drawing.Color.Empty
        Me.CodeTextBox14.ValueColumnVisible = True
        Me.CodeTextBox14.ValueColumnWidth = 600
        Me.CodeTextBox14.ValueField = ""
        Me.CodeTextBox14.ValueMember = ""
        Me.CodeTextBox14.ValueSearch = True
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(4, 108)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel24.TabIndex = 53
        Me.KryptonLabel24.Text = "Moneda"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Moneda"
        '
        'KryptonLabel25
        '
        Me.KryptonLabel25.Location = New System.Drawing.Point(288, 8)
        Me.KryptonLabel25.Name = "KryptonLabel25"
        Me.KryptonLabel25.Size = New System.Drawing.Size(40, 19)
        Me.KryptonLabel25.TabIndex = 52
        Me.KryptonLabel25.Text = "Precio"
        Me.KryptonLabel25.Values.ExtraText = ""
        Me.KryptonLabel25.Values.Image = Nothing
        Me.KryptonLabel25.Values.Text = "Precio"
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(4, 84)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(54, 19)
        Me.KryptonLabel26.TabIndex = 51
        Me.KryptonLabel26.Text = "Cantidad"
        Me.KryptonLabel26.Values.ExtraText = ""
        Me.KryptonLabel26.Values.Image = Nothing
        Me.KryptonLabel26.Values.Text = "Cantidad"
        '
        'KryptonLabel27
        '
        Me.KryptonLabel27.Location = New System.Drawing.Point(4, 60)
        Me.KryptonLabel27.Name = "KryptonLabel27"
        Me.KryptonLabel27.Size = New System.Drawing.Size(69, 19)
        Me.KryptonLabel27.TabIndex = 50
        Me.KryptonLabel27.Text = "Und Medida"
        Me.KryptonLabel27.Values.ExtraText = ""
        Me.KryptonLabel27.Values.Image = Nothing
        Me.KryptonLabel27.Values.Text = "Und Medida"
        '
        'KryptonLabel28
        '
        Me.KryptonLabel28.Location = New System.Drawing.Point(284, 36)
        Me.KryptonLabel28.Name = "KryptonLabel28"
        Me.KryptonLabel28.Size = New System.Drawing.Size(82, 19)
        Me.KryptonLabel28.TabIndex = 49
        Me.KryptonLabel28.Text = "Observaciones"
        Me.KryptonLabel28.Values.ExtraText = ""
        Me.KryptonLabel28.Values.Image = Nothing
        Me.KryptonLabel28.Values.Text = "Observaciones"
        '
        'KryptonLabel29
        '
        Me.KryptonLabel29.Location = New System.Drawing.Point(4, 36)
        Me.KryptonLabel29.Name = "KryptonLabel29"
        Me.KryptonLabel29.Size = New System.Drawing.Size(49, 19)
        Me.KryptonLabel29.TabIndex = 48
        Me.KryptonLabel29.Text = "Servicio"
        Me.KryptonLabel29.Values.ExtraText = ""
        Me.KryptonLabel29.Values.Image = Nothing
        Me.KryptonLabel29.Values.Text = "Servicio"
        '
        'KryptonLabel30
        '
        Me.KryptonLabel30.Location = New System.Drawing.Point(4, 12)
        Me.KryptonLabel30.Name = "KryptonLabel30"
        Me.KryptonLabel30.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel30.TabIndex = 40
        Me.KryptonLabel30.Text = "Tarifario"
        Me.KryptonLabel30.Values.ExtraText = ""
        Me.KryptonLabel30.Values.Image = Nothing
        Me.KryptonLabel30.Values.Text = "Tarifario"
        '
        'lblTope
        '
        Me.lblTope.Location = New System.Drawing.Point(488, 32)
        Me.lblTope.Name = "lblTope"
        Me.lblTope.Size = New System.Drawing.Size(41, 19)
        Me.lblTope.StateNormal.ShortText.Color1 = System.Drawing.Color.Red
        Me.lblTope.StateNormal.ShortText.Color2 = System.Drawing.Color.Red
        Me.lblTope.TabIndex = 0
        Me.lblTope.Text = "00000"
        Me.lblTope.Values.ExtraText = ""
        Me.lblTope.Values.Image = Nothing
        Me.lblTope.Values.Text = "00000"
        Me.lblTope.Visible = False
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoServicio, Me.ToolStripSeparator7, Me.btnGuardarServicio, Me.ToolStripSeparator8, Me.btnEliminarServicio, Me.ToolStripSeparator9, Me.btnCancelarServicio, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.cboFiltroNegocio, Me.ToolStripButton13})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 22)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(563, 29)
        Me.ToolStrip3.TabIndex = 4
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(47, 26)
        Me.ToolStripLabel1.Text = "Negocio"
        '
        'cboFiltroNegocio
        '
        Me.cboFiltroNegocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltroNegocio.Items.AddRange(New Object() {"--- Escoja Elemento ---", "SIL", "ALMACEN", "TRANSPORTES"})
        Me.cboFiltroNegocio.Name = "cboFiltroNegocio"
        Me.cboFiltroNegocio.Size = New System.Drawing.Size(121, 29)
        '
        'HGCotizaciones
        '
        Me.HGCotizaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGCotizaciones.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HGCotizaciones.Location = New System.Drawing.Point(0, 0)
        Me.HGCotizaciones.Name = "HGCotizaciones"
        Me.HGCotizaciones.Size = New System.Drawing.Size(563, 22)
        Me.HGCotizaciones.TabIndex = 0
        Me.HGCotizaciones.Text = "Detalle de Cotizacion"
        Me.HGCotizaciones.Values.Description = ""
        Me.HGCotizaciones.Values.Heading = "Detalle de Cotizacion"
        Me.HGCotizaciones.Values.Image = Global.Solmin.My.Resources.Resources.irc_server
        '
        'dtgDetalleServicio
        '
        Me.dtgDetalleServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDetalleServicio.Location = New System.Drawing.Point(12, 60)
        Me.dtgDetalleServicio.Name = "dtgDetalleServicio"
        Me.dtgDetalleServicio.Size = New System.Drawing.Size(512, 272)
        Me.dtgDetalleServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgDetalleServicio.TabIndex = 62
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnRegistrarComentarioServicio, Me.btnEliminarComentarioServicio, Me.btnImprimirDetalleServicio})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonHeaderGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabCustom3
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 132)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtgBitacora)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel15)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(460, 209)
        Me.KryptonHeaderGroup1.TabIndex = 15
        Me.KryptonHeaderGroup1.Text = "Bitácoras Registradas"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Bitácoras Registradas"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Global.Solmin.My.Resources.Resources.irc_server
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'dtgBitacora
        '
        Me.dtgBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBitacora.Location = New System.Drawing.Point(8, 8)
        Me.dtgBitacora.Name = "dtgBitacora"
        Me.dtgBitacora.Size = New System.Drawing.Size(440, 164)
        Me.dtgBitacora.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgBitacora.TabIndex = 2
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(512, 244)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(10, 19)
        Me.KryptonLabel15.TabIndex = 1
        Me.KryptonLabel15.Text = "   "
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "   "
        '
        'txtRecordatorio
        '
        Me.txtRecordatorio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecordatorio.Location = New System.Drawing.Point(88, 28)
        Me.txtRecordatorio.MaxLength = 250
        Me.txtRecordatorio.Multiline = True
        Me.txtRecordatorio.Name = "txtRecordatorio"
        Me.txtRecordatorio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecordatorio.Size = New System.Drawing.Size(364, 72)
        Me.txtRecordatorio.TabIndex = 57
        '
        'dtpRecordatorio
        '
        Me.dtpRecordatorio.Checked = False
        Me.dtpRecordatorio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRecordatorio.Location = New System.Drawing.Point(88, 104)
        Me.dtpRecordatorio.Name = "dtpRecordatorio"
        Me.dtpRecordatorio.ShowCheckBox = True
        Me.dtpRecordatorio.Size = New System.Drawing.Size(100, 21)
        Me.dtpRecordatorio.TabIndex = 44
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(8, 108)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(74, 19)
        Me.KryptonLabel9.TabIndex = 2
        Me.KryptonLabel9.Text = "Recordatorio"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Recordatorio"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(4, 28)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(82, 19)
        Me.KryptonLabel4.TabIndex = 0
        Me.KryptonLabel4.Text = "Observaciones"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Observaciones"
        '
        'HGTarifas
        '
        Me.HGTarifas.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGTarifas.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HGTarifas.Location = New System.Drawing.Point(0, 0)
        Me.HGTarifas.Name = "HGTarifas"
        Me.HGTarifas.Size = New System.Drawing.Size(460, 22)
        Me.HGTarifas.TabIndex = 0
        Me.HGTarifas.Text = "Bitácora de Cotización"
        Me.HGTarifas.Values.Description = ""
        Me.HGTarifas.Values.Heading = "Bitácora de Cotización"
        Me.HGTarifas.Values.Image = Global.Solmin.My.Resources.Resources.irc_server
        '
        'btnNuevaCotizacion
        '
        Me.btnNuevaCotizacion.Image = Global.Solmin.My.Resources.Resources.db_add
        Me.btnNuevaCotizacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevaCotizacion.Name = "btnNuevaCotizacion"
        Me.btnNuevaCotizacion.Size = New System.Drawing.Size(65, 26)
        Me.btnNuevaCotizacion.Text = "Nuevo"
        '
        'btnGuardarCotizacion
        '
        Me.btnGuardarCotizacion.Image = Global.Solmin.My.Resources.Resources.db_comit
        Me.btnGuardarCotizacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardarCotizacion.Name = "btnGuardarCotizacion"
        Me.btnGuardarCotizacion.Size = New System.Drawing.Size(71, 26)
        Me.btnGuardarCotizacion.Text = "Guardar"
        '
        'btnEliminarCotizacion
        '
        Me.btnEliminarCotizacion.Image = Global.Solmin.My.Resources.Resources.db_remove
        Me.btnEliminarCotizacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarCotizacion.Name = "btnEliminarCotizacion"
        Me.btnEliminarCotizacion.Size = New System.Drawing.Size(69, 26)
        Me.btnEliminarCotizacion.Text = "Eliminar"
        '
        'btnCancelarCotizacion
        '
        Me.btnCancelarCotizacion.Image = Global.Solmin.My.Resources.Resources.button_cancel
        Me.btnCancelarCotizacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarCotizacion.Name = "btnCancelarCotizacion"
        Me.btnCancelarCotizacion.Size = New System.Drawing.Size(75, 26)
        Me.btnCancelarCotizacion.Text = "Cancelar"
        '
        'btnOpcionCotizacion
        '
        Me.btnOpcionCotizacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptarCotizacion, Me.ToolStripMenuItem1, Me.btnRechazarCotizacion, Me.ToolStripMenuItem2})
        Me.btnOpcionCotizacion.Image = Global.Solmin.My.Resources.Resources.display
        Me.btnOpcionCotizacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpcionCotizacion.Name = "btnOpcionCotizacion"
        Me.btnOpcionCotizacion.Size = New System.Drawing.Size(105, 26)
        Me.btnOpcionCotizacion.Text = "Operaciones"
        '
        'btnAceptarCotizacion
        '
        Me.btnAceptarCotizacion.Image = Global.Solmin.My.Resources.Resources.button_ok
        Me.btnAceptarCotizacion.Name = "btnAceptarCotizacion"
        Me.btnAceptarCotizacion.Size = New System.Drawing.Size(181, 28)
        Me.btnAceptarCotizacion.Text = "Aceptar Cotización"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'btnRechazarCotizacion
        '
        Me.btnRechazarCotizacion.Image = Global.Solmin.My.Resources.Resources.button_cancel
        Me.btnRechazarCotizacion.Name = "btnRechazarCotizacion"
        Me.btnRechazarCotizacion.Size = New System.Drawing.Size(181, 28)
        Me.btnRechazarCotizacion.Text = "Rechazar Cotización"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(178, 6)
        '
        'btnImprimirContrato
        '
        Me.btnImprimirContrato.Image = Global.Solmin.My.Resources.Resources.printer1
        Me.btnImprimirContrato.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirContrato.Name = "btnImprimirContrato"
        Me.btnImprimirContrato.Size = New System.Drawing.Size(111, 26)
        Me.btnImprimirContrato.Text = "Imprimir Contrato"
        '
        'btnBuscar
        '
        Me.btnBuscar.ExtraText = ""
        Me.btnBuscar.Image = Global.Solmin.My.Resources.Resources.search
        Me.btnBuscar.Text = "Procesar Consulta"
        Me.btnBuscar.ToolTipBody = "Procesar Consulta :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Realiza una búsqueda en el sistema de las cotizaciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que " & _
            "coindidan con el criterio de filtrado ingresado por el" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "usuario."
        Me.btnBuscar.ToolTipImage = Global.Solmin.My.Resources.Resources.search
        Me.btnBuscar.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.btnBuscar.UniqueName = "64D8A5E06C0D41C464D8A5E06C0D41C4"
        '
        'btnImprimir
        '
        Me.btnImprimir.ExtraText = ""
        Me.btnImprimir.Image = Global.Solmin.My.Resources.Resources.printer2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTipImage = Nothing
        Me.btnImprimir.UniqueName = "84B028861FA348D284B028861FA348D2"
        '
        'AceptarCotizaciónToolStripMenuItem1
        '
        Me.AceptarCotizaciónToolStripMenuItem1.Image = Global.Solmin.My.Resources.Resources.ok
        Me.AceptarCotizaciónToolStripMenuItem1.Name = "AceptarCotizaciónToolStripMenuItem1"
        Me.AceptarCotizaciónToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.AceptarCotizaciónToolStripMenuItem1.Text = "Aceptar Cotización"
        '
        'RechazarCotizaciónToolStripMenuItem1
        '
        Me.RechazarCotizaciónToolStripMenuItem1.Image = Global.Solmin.My.Resources.Resources.button_cancel
        Me.RechazarCotizaciónToolStripMenuItem1.Name = "RechazarCotizaciónToolStripMenuItem1"
        Me.RechazarCotizaciónToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.RechazarCotizaciónToolStripMenuItem1.Text = "Rechazar Cotización"
        '
        'ImprimirCotizaciónToolStripMenuItem
        '
        Me.ImprimirCotizaciónToolStripMenuItem.Image = Global.Solmin.My.Resources.Resources.printer2
        Me.ImprimirCotizaciónToolStripMenuItem.Name = "ImprimirCotizaciónToolStripMenuItem"
        Me.ImprimirCotizaciónToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ImprimirCotizaciónToolStripMenuItem.Text = "Imprimir Cotización"
        '
        'btnNuevoServicio
        '
        Me.btnNuevoServicio.Image = Global.Solmin.My.Resources.Resources.db_add
        Me.btnNuevoServicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoServicio.Name = "btnNuevoServicio"
        Me.btnNuevoServicio.Size = New System.Drawing.Size(65, 26)
        Me.btnNuevoServicio.Text = "Nuevo"
        '
        'btnGuardarServicio
        '
        Me.btnGuardarServicio.Image = Global.Solmin.My.Resources.Resources.db_comit
        Me.btnGuardarServicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardarServicio.Name = "btnGuardarServicio"
        Me.btnGuardarServicio.Size = New System.Drawing.Size(71, 26)
        Me.btnGuardarServicio.Text = "Guardar"
        '
        'btnEliminarServicio
        '
        Me.btnEliminarServicio.Image = Global.Solmin.My.Resources.Resources.db_remove
        Me.btnEliminarServicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarServicio.Name = "btnEliminarServicio"
        Me.btnEliminarServicio.Size = New System.Drawing.Size(69, 26)
        Me.btnEliminarServicio.Text = "Eliminar"
        '
        'btnCancelarServicio
        '
        Me.btnCancelarServicio.Image = Global.Solmin.My.Resources.Resources.button_cancel
        Me.btnCancelarServicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarServicio.Name = "btnCancelarServicio"
        Me.btnCancelarServicio.Size = New System.Drawing.Size(75, 26)
        Me.btnCancelarServicio.Text = "Cancelar"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.Image = Global.Solmin.My.Resources.Resources.printer1
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(68, 26)
        Me.ToolStripButton13.Text = "Imprimir"
        '
        'btnRegistrarComentarioServicio
        '
        Me.btnRegistrarComentarioServicio.ExtraText = ""
        Me.btnRegistrarComentarioServicio.Image = Global.Solmin.My.Resources.Resources.db_comit1
        Me.btnRegistrarComentarioServicio.Text = "Registrar"
        Me.btnRegistrarComentarioServicio.ToolTipImage = Nothing
        Me.btnRegistrarComentarioServicio.UniqueName = "A0F7EAA6AFCA4DA8A0F7EAA6AFCA4DA8"
        '
        'btnEliminarComentarioServicio
        '
        Me.btnEliminarComentarioServicio.ExtraText = ""
        Me.btnEliminarComentarioServicio.Image = Global.Solmin.My.Resources.Resources.db_remove1
        Me.btnEliminarComentarioServicio.Text = "Eliminar"
        Me.btnEliminarComentarioServicio.ToolTipImage = Nothing
        Me.btnEliminarComentarioServicio.UniqueName = "2D6C7D1F927C4CDC2D6C7D1F927C4CDC"
        '
        'btnImprimirDetalleServicio
        '
        Me.btnImprimirDetalleServicio.ExtraText = ""
        Me.btnImprimirDetalleServicio.Image = Global.Solmin.My.Resources.Resources.printer2
        Me.btnImprimirDetalleServicio.Text = "Imprimir"
        Me.btnImprimirDetalleServicio.ToolTipBody = "Imprimir Comentarios de los Servicios de Cotización"
        Me.btnImprimirDetalleServicio.ToolTipImage = Nothing
        Me.btnImprimirDetalleServicio.UniqueName = "6212A63BCADB47716212A63BCADB4771"
        '
        'frmCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 631)
        Me.Controls.Add(Me.Contenedor1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCotizaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Contratos"
        CType(Me.Contenedor1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor1.Panel1.ResumeLayout(False)
        Me.Contenedor1.Panel1.PerformLayout()
        CType(Me.Contenedor1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor1.Panel2.ResumeLayout(False)
        CType(Me.Contenedor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor1.ResumeLayout(False)
        CType(Me.HGPanelCotizaciones.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGPanelCotizaciones.Panel.ResumeLayout(False)
        Me.HGPanelCotizaciones.Panel.PerformLayout()
        CType(Me.HGPanelCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGPanelCotizaciones.ResumeLayout(False)
        Me.BarraCotización.ResumeLayout(False)
        Me.BarraCotización.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.dtgCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupMenu.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.HGDetalleServicio.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalleServicio.Panel.ResumeLayout(False)
        Me.HGDetalleServicio.Panel.PerformLayout()
        CType(Me.HGDetalleServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalleServicio.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup3.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        CType(Me.dtgTarifasServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.dtgDetalleServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dtgBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents Contenedor1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents HeaderConsulta As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnImprimir As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents HGCotizaciones As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents HGTarifas As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboDivisionTarifas As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents ctlServiciosTarifarios As CodeTextBox.CodeTextBox
    Friend WithEvents dtgCotizacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ctlClienteTarifario As CodeTextBox.CodeTextBox
    Friend WithEvents PopupMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AceptarCotizaciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RechazarCotizaciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirCotizaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge5 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroCotizacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ctlPlanta As CodeTextBox.CodeTextBox
    Friend WithEvents ctlCompania As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroCotizacionConsulta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents ctlClienteConsulta As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents HGPanelCotizaciones As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents BarraCotización As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevaCotizacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardarCotizacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelarCotizacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnOpcionCotizacion As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btnAceptarCotizacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRechazarCotizacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimirContrato As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel34 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel31 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents HGDetalleServicio As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents CodeTextBox8 As CodeTextBox.CodeTextBox
    Friend WithEvents CodeTextBox11 As CodeTextBox.CodeTextBox
    Friend WithEvents CodeTextBox13 As CodeTextBox.CodeTextBox
    Friend WithEvents CodeTextBox14 As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTope As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevoServicio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardarServicio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminarServicio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelarServicio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboFiltroNegocio As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cboEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnEliminarCotizacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtContacto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroContrato As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents dtpFechaFinalizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ctlCliente As CodeTextBox.CodeTextBox
    Friend WithEvents txtObservacionesServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonTextBox2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtRecordatorio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents dtpRecordatorio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnRegistrarComentarioServicio As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnEliminarComentarioServicio As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnImprimirDetalleServicio As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgTarifasServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtgBitacora As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtgDetalleServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
