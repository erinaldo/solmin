<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionOperacionGuia
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgOperacionCM = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.dtgOperacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NKMRCR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PMRCMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IGSTOP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnEliminar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cboCosto = New System.Windows.Forms.ComboBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFecha = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.rbnOperacion = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbnGuia = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCUN1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NKMRCR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PMRCMC1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IGSTOP1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgOperacionCM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgOperacionCM)
        Me.KryptonPanel.Controls.Add(Me.dtgOperacion)
        Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(591, 366)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgOperacionCM
        '
        Me.dtgOperacionCM.AllowUserToAddRows = False
        Me.dtgOperacionCM.AllowUserToDeleteRows = False
        Me.dtgOperacionCM.AllowUserToOrderColumns = True
        Me.dtgOperacionCM.ColumnHeadersHeight = 30
        Me.dtgOperacionCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgOperacionCM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPLCUN1, Me.NOPRCN1, Me.NKMRCR1, Me.PMRCMC1, Me.IGSTOP1})
        Me.dtgOperacionCM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOperacionCM.Location = New System.Drawing.Point(0, 138)
        Me.dtgOperacionCM.Name = "dtgOperacionCM"
        Me.dtgOperacionCM.RowHeadersVisible = False
        Me.dtgOperacionCM.RowHeadersWidth = 30
        Me.dtgOperacionCM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgOperacionCM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgOperacionCM.Size = New System.Drawing.Size(591, 228)
        Me.dtgOperacionCM.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOperacionCM.TabIndex = 431
        Me.dtgOperacionCM.Visible = False
        '
        'dtgOperacion
        '
        Me.dtgOperacion.AllowUserToAddRows = False
        Me.dtgOperacion.AllowUserToDeleteRows = False
        Me.dtgOperacion.AllowUserToOrderColumns = True
        Me.dtgOperacion.ColumnHeadersHeight = 30
        Me.dtgOperacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgOperacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPLCUN, Me.NOPRCN, Me.NKMRCR, Me.PMRCMC, Me.IGSTOP})
        Me.dtgOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOperacion.Location = New System.Drawing.Point(0, 138)
        Me.dtgOperacion.Name = "dtgOperacion"
        Me.dtgOperacion.RowHeadersVisible = False
        Me.dtgOperacion.RowHeadersWidth = 30
        Me.dtgOperacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgOperacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgOperacion.Size = New System.Drawing.Size(591, 228)
        Me.dtgOperacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOperacion.TabIndex = 430
        Me.dtgOperacion.Visible = False
        '
        'NPLCUN
        '
        Me.NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN.DataPropertyName = "NPLCUN"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.NPLCUN.DefaultCellStyle = DataGridViewCellStyle4
        Me.NPLCUN.HeaderText = "Unidades"
        Me.NPLCUN.Name = "NPLCUN"
        Me.NPLCUN.ReadOnly = True
        Me.NPLCUN.Width = 85
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 90
        '
        'NKMRCR
        '
        Me.NKMRCR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NKMRCR.DataPropertyName = "NKMRCR"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NKMRCR.DefaultCellStyle = DataGridViewCellStyle5
        Me.NKMRCR.HeaderText = "KM. Recorridos"
        Me.NKMRCR.Name = "NKMRCR"
        Me.NKMRCR.ReadOnly = True
        Me.NKMRCR.Width = 113
        '
        'PMRCMC
        '
        Me.PMRCMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PMRCMC.DataPropertyName = "PMRCMC"
        Me.PMRCMC.HeaderText = "Peso de Mercadería"
        Me.PMRCMC.Name = "PMRCMC"
        Me.PMRCMC.ReadOnly = True
        Me.PMRCMC.Width = 136
        '
        'IGSTOP
        '
        Me.IGSTOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IGSTOP.DataPropertyName = "IGSTOP"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.IGSTOP.DefaultCellStyle = DataGridViewCellStyle6
        Me.IGSTOP.HeaderText = "Importe Total - Soles"
        Me.IGSTOP.Name = "IGSTOP"
        Me.IGSTOP.ReadOnly = True
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnEliminar, Me.btnBuscar, Me.btnAceptar, Me.btnSalir})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.cboCosto)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblFecha)
        Me.PanelFiltros.Panel.Controls.Add(Me.rbnOperacion)
        Me.PanelFiltros.Panel.Controls.Add(Me.rbnGuia)
        Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaFin)
        Me.PanelFiltros.Size = New System.Drawing.Size(591, 138)
        Me.PanelFiltros.TabIndex = 429
        Me.PanelFiltros.Text = "INFORMACIÓN DE JUNTA"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "INFORMACIÓN DE JUNTA"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnEliminar
        '
        Me.btnEliminar.ExtraText = ""
        Me.btnEliminar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnEliminar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.ToolTipImage = Nothing
        Me.btnEliminar.UniqueName = "BED11A4918524F13BED11A4918524F13"
        '
        'btnBuscar
        '
        Me.btnBuscar.ExtraText = ""
        Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipImage = Nothing
        Me.btnBuscar.UniqueName = "0792D57CAD694F760792D57CAD694F76"
        '
        'btnAceptar
        '
        Me.btnAceptar.ExtraText = ""
        Me.btnAceptar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnAceptar.Text = "Guardar"
        Me.btnAceptar.ToolTipImage = Nothing
        Me.btnAceptar.UniqueName = "C49AE56CFD9D4BE2C49AE56CFD9D4BE2"
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "C77D8122AF8A4DC8C77D8122AF8A4DC8"
        Me.btnSalir.Visible = False
        '
        'cboCosto
        '
        Me.cboCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCosto.FormattingEnabled = True
        Me.cboCosto.Location = New System.Drawing.Point(150, 72)
        Me.cboCosto.Name = "cboCosto"
        Me.cboCosto.Size = New System.Drawing.Size(121, 21)
        Me.cboCosto.TabIndex = 442
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 72)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(133, 19)
        Me.KryptonLabel1.TabIndex = 441
        Me.KryptonLabel1.Text = "Distribución Costos por :  "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Distribución Costos por :  "
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(11, 13)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(45, 19)
        Me.lblFecha.TabIndex = 440
        Me.lblFecha.Text = "Fecha : "
        Me.lblFecha.Values.ExtraText = ""
        Me.lblFecha.Values.Image = Nothing
        Me.lblFecha.Values.Text = "Fecha : "
        '
        'rbnOperacion
        '
        Me.rbnOperacion.Checked = True
        Me.rbnOperacion.Location = New System.Drawing.Point(153, 13)
        Me.rbnOperacion.Name = "rbnOperacion"
        Me.rbnOperacion.Size = New System.Drawing.Size(74, 19)
        Me.rbnOperacion.TabIndex = 438
        Me.rbnOperacion.Text = "Operación"
        Me.rbnOperacion.Values.ExtraText = ""
        Me.rbnOperacion.Values.Image = Nothing
        Me.rbnOperacion.Values.Text = "Operación"
        '
        'rbnGuia
        '
        Me.rbnGuia.Location = New System.Drawing.Point(288, 13)
        Me.rbnGuia.Name = "rbnGuia"
        Me.rbnGuia.Size = New System.Drawing.Size(81, 19)
        Me.rbnGuia.TabIndex = 439
        Me.rbnGuia.Text = "Guía Transp"
        Me.rbnGuia.Values.ExtraText = ""
        Me.rbnGuia.Values.Image = Nothing
        Me.rbnGuia.Values.Text = "Guía Transp"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(151, 37)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaInicio.TabIndex = 435
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(250, 40)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(20, 17)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 437
        Me.KryptonLabel4.Text = "Al"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Al"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(285, 37)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaFin.TabIndex = 436
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NPLCUN"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.HeaderText = "Unidades"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NKMRCR"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn3.HeaderText = "KM. Recorridos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PMRCMC"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Peso de Mercadería"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IGSTOP"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn5.HeaderText = "Importe Total - Soles"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NPLCUN"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unidades"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NKMRCR"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn8.HeaderText = "KM. Recorridos"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PMRCMC"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Peso de Mercadería"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IGSTOP"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn10.HeaderText = "Importe Total - Soles"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'NPLCUN1
        '
        Me.NPLCUN1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN1.DataPropertyName = "NPLCUN"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.NPLCUN1.DefaultCellStyle = DataGridViewCellStyle1
        Me.NPLCUN1.HeaderText = "Unidades"
        Me.NPLCUN1.Name = "NPLCUN1"
        Me.NPLCUN1.ReadOnly = True
        Me.NPLCUN1.Width = 85
        '
        'NOPRCN1
        '
        Me.NOPRCN1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN1.DataPropertyName = "NOPRCN"
        Me.NOPRCN1.HeaderText = "Operación"
        Me.NOPRCN1.Name = "NOPRCN1"
        Me.NOPRCN1.ReadOnly = True
        Me.NOPRCN1.Width = 90
        '
        'NKMRCR1
        '
        Me.NKMRCR1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NKMRCR1.DataPropertyName = "NKMRCR"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NKMRCR1.DefaultCellStyle = DataGridViewCellStyle2
        Me.NKMRCR1.HeaderText = "KM. Recorridos"
        Me.NKMRCR1.Name = "NKMRCR1"
        Me.NKMRCR1.ReadOnly = True
        Me.NKMRCR1.Width = 113
        '
        'PMRCMC1
        '
        Me.PMRCMC1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PMRCMC1.DataPropertyName = "PMRCMC"
        Me.PMRCMC1.HeaderText = "Peso de Mercadería"
        Me.PMRCMC1.Name = "PMRCMC1"
        Me.PMRCMC1.ReadOnly = True
        Me.PMRCMC1.Width = 136
        '
        'IGSTOP1
        '
        Me.IGSTOP1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IGSTOP1.DataPropertyName = "IGSTOP"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.IGSTOP1.DefaultCellStyle = DataGridViewCellStyle3
        Me.IGSTOP1.HeaderText = "Importe Total - Soles"
        Me.IGSTOP1.Name = "IGSTOP1"
        Me.IGSTOP1.ReadOnly = True
        '
        'frmOpcionOperacionGuia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 366)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOpcionOperacionGuia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opción Fecha Operación - Guía Transp."
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.dtgOperacionCM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
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
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents rbnOperacion As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbnGuia As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtgOperacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnEliminar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NKMRCR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMRCMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGSTOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgOperacionCM As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents lblFecha As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboCosto As System.Windows.Forms.ComboBox
    Friend WithEvents NPLCUN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NKMRCR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMRCMC1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGSTOP1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
