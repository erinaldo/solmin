<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenEjecutivoMensual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumenEjecutivoMensual))
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HGDetalle = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnReporte = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.pbxBuscar = New System.Windows.Forms.PictureBox
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.cmbProceso = New SOLMIN_SC.CheckComboBoxTest.CheckedComboBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.rbAnual = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbfecha = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbMensual = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.GbMesAnio = New System.Windows.Forms.GroupBox
        Me.gbFecha = New System.Windows.Forms.GroupBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFin_SC = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtFechaIni_SC = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaIni = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dbMes_SC = New System.Windows.Forms.ComboBox
        Me.ndAnio = New System.Windows.Forms.NumericUpDown
        Me.lblMes = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dbMes = New System.Windows.Forms.ComboBox
        Me.UcCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HGDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGDetalle.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGDetalle.Panel.SuspendLayout()
        Me.HGDetalle.SuspendLayout()
        CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGFiltro.Panel.SuspendLayout()
        Me.HGFiltro.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.GbMesAnio.SuspendLayout()
        Me.gbFecha.SuspendLayout()
        CType(Me.ndAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HGDetalle)
        Me.KryptonPanel.Controls.Add(Me.HGFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1028, 448)
        Me.KryptonPanel.TabIndex = 0
        '
        'HGDetalle
        '
        Me.HGDetalle.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnReporte})
        Me.HGDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGDetalle.HeaderVisibleSecondary = False
        Me.HGDetalle.Location = New System.Drawing.Point(0, 140)
        Me.HGDetalle.Name = "HGDetalle"
        '
        'HGDetalle.Panel
        '
        Me.HGDetalle.Panel.Controls.Add(Me.pbxBuscar)
        Me.HGDetalle.Panel.Controls.Add(Me.ReportViewer)
        Me.HGDetalle.Size = New System.Drawing.Size(1028, 308)
        Me.HGDetalle.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGDetalle.TabIndex = 2
        Me.HGDetalle.Text = "Resultados"
        Me.HGDetalle.ValuesPrimary.Description = ""
        Me.HGDetalle.ValuesPrimary.Heading = "Resultados"
        Me.HGDetalle.ValuesPrimary.Image = Nothing
        Me.HGDetalle.ValuesSecondary.Description = ""
        Me.HGDetalle.ValuesSecondary.Heading = "Description"
        Me.HGDetalle.ValuesSecondary.Image = Nothing
        '
        'btnReporte
        '
        Me.btnReporte.ExtraText = ""
        Me.btnReporte.Image = Global.SOLMIN_SC.My.Resources.Resources.button_ok
        Me.btnReporte.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.ToolTipImage = Nothing
        Me.btnReporte.UniqueName = "E00F1F88311147C4E00F1F88311147C4"
        '
        'pbxBuscar
        '
        Me.pbxBuscar.BackColor = System.Drawing.Color.White
        Me.pbxBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxBuscar.Enabled = False
        Me.pbxBuscar.Image = CType(resources.GetObject("pbxBuscar.Image"), System.Drawing.Image)
        Me.pbxBuscar.ImageLocation = ""
        Me.pbxBuscar.InitialImage = Nothing
        Me.pbxBuscar.Location = New System.Drawing.Point(0, 0)
        Me.pbxBuscar.Name = "pbxBuscar"
        Me.pbxBuscar.Size = New System.Drawing.Size(1026, 273)
        Me.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxBuscar.TabIndex = 15
        Me.pbxBuscar.TabStop = False
        Me.pbxBuscar.Visible = False
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportViewer.DisplayGroupTree = False
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.EnableDrillDown = False
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.SelectionFormula = ""
        Me.ReportViewer.ShowGroupTreeButton = False
        Me.ReportViewer.Size = New System.Drawing.Size(1026, 273)
        Me.ReportViewer.TabIndex = 18
        Me.ReportViewer.ViewTimeSelectionFormula = ""
        '
        'HGFiltro
        '
        Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGFiltro.HeaderVisibleSecondary = False
        Me.HGFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HGFiltro.Name = "HGFiltro"
        '
        'HGFiltro.Panel
        '
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonPanel1)
        Me.HGFiltro.Panel.Controls.Add(Me.lblCompania)
        Me.HGFiltro.Size = New System.Drawing.Size(1028, 140)
        Me.HGFiltro.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGFiltro.TabIndex = 1
        Me.HGFiltro.Text = "Opciones de Filtro"
        Me.HGFiltro.ValuesPrimary.Description = ""
        Me.HGFiltro.ValuesPrimary.Heading = "Opciones de Filtro"
        Me.HGFiltro.ValuesPrimary.Image = Nothing
        Me.HGFiltro.ValuesSecondary.Description = ""
        Me.HGFiltro.ValuesSecondary.Heading = "Description"
        Me.HGFiltro.ValuesSecondary.Image = Nothing
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.UcPLanta_Cmb011)
        Me.KryptonPanel1.Controls.Add(Me.cmbProceso)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.rbAnual)
        Me.KryptonPanel1.Controls.Add(Me.rbfecha)
        Me.KryptonPanel1.Controls.Add(Me.rbMensual)
        Me.KryptonPanel1.Controls.Add(Me.GbMesAnio)
        Me.KryptonPanel1.Controls.Add(Me.UcCompania)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.UcCliente)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1026, 121)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 38
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(88, 42)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta1
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(215, 23)
        Me.UcPLanta_Cmb011.TabIndex = 138
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'cmbProceso
        '
        Me.cmbProceso.CheckOnClick = True
        Me.cmbProceso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbProceso.DropDownHeight = 1
        Me.cmbProceso.FormattingEnabled = True
        Me.cmbProceso.IntegralHeight = False
        Me.cmbProceso.Location = New System.Drawing.Point(88, 42)
        Me.cmbProceso.Name = "cmbProceso"
        Me.cmbProceso.Size = New System.Drawing.Size(215, 21)
        Me.cmbProceso.TabIndex = 12
        Me.cmbProceso.ValueSeparator = ", "
        Me.cmbProceso.Visible = False
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(19, 42)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(47, 19)
        Me.KryptonLabel2.TabIndex = 137
        Me.KryptonLabel2.Text = "Planta :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Planta :"
        '
        'rbAnual
        '
        Me.rbAnual.Location = New System.Drawing.Point(674, 12)
        Me.rbAnual.Name = "rbAnual"
        Me.rbAnual.Size = New System.Drawing.Size(51, 19)
        Me.rbAnual.TabIndex = 133
        Me.rbAnual.Text = "Anual"
        Me.rbAnual.Values.ExtraText = ""
        Me.rbAnual.Values.Image = Nothing
        Me.rbAnual.Values.Text = "Anual"
        '
        'rbfecha
        '
        Me.rbfecha.Location = New System.Drawing.Point(801, 12)
        Me.rbfecha.Name = "rbfecha"
        Me.rbfecha.Size = New System.Drawing.Size(51, 19)
        Me.rbfecha.TabIndex = 135
        Me.rbfecha.Text = "Fecha"
        Me.rbfecha.Values.ExtraText = ""
        Me.rbfecha.Values.Image = Nothing
        Me.rbfecha.Values.Text = "Fecha"
        '
        'rbMensual
        '
        Me.rbMensual.Checked = True
        Me.rbMensual.Location = New System.Drawing.Point(731, 12)
        Me.rbMensual.Name = "rbMensual"
        Me.rbMensual.Size = New System.Drawing.Size(64, 19)
        Me.rbMensual.TabIndex = 134
        Me.rbMensual.Text = "Mensual"
        Me.rbMensual.Values.ExtraText = ""
        Me.rbMensual.Values.Image = Nothing
        Me.rbMensual.Values.Text = "Mensual"
        '
        'GbMesAnio
        '
        Me.GbMesAnio.BackColor = System.Drawing.Color.Transparent
        Me.GbMesAnio.Controls.Add(Me.gbFecha)
        Me.GbMesAnio.Controls.Add(Me.KryptonLabel9)
        Me.GbMesAnio.Controls.Add(Me.KryptonLabel6)
        Me.GbMesAnio.Controls.Add(Me.dbMes_SC)
        Me.GbMesAnio.Controls.Add(Me.ndAnio)
        Me.GbMesAnio.Controls.Add(Me.lblMes)
        Me.GbMesAnio.Controls.Add(Me.dbMes)
        Me.GbMesAnio.Location = New System.Drawing.Point(674, 37)
        Me.GbMesAnio.Name = "GbMesAnio"
        Me.GbMesAnio.Size = New System.Drawing.Size(365, 74)
        Me.GbMesAnio.TabIndex = 132
        Me.GbMesAnio.TabStop = False
        '
        'gbFecha
        '
        Me.gbFecha.BackColor = System.Drawing.Color.Transparent
        Me.gbFecha.Controls.Add(Me.KryptonLabel7)
        Me.gbFecha.Controls.Add(Me.dtpFechaFin_SC)
        Me.gbFecha.Controls.Add(Me.KryptonLabel8)
        Me.gbFecha.Controls.Add(Me.dtFechaIni_SC)
        Me.gbFecha.Controls.Add(Me.KryptonLabel5)
        Me.gbFecha.Controls.Add(Me.KryptonLabel3)
        Me.gbFecha.Controls.Add(Me.lblFechaIni)
        Me.gbFecha.Controls.Add(Me.dtpFechaFin)
        Me.gbFecha.Controls.Add(Me.lblFechaFin)
        Me.gbFecha.Controls.Add(Me.dtFechaIni)
        Me.gbFecha.Location = New System.Drawing.Point(0, 0)
        Me.gbFecha.Name = "gbFecha"
        Me.gbFecha.Size = New System.Drawing.Size(365, 74)
        Me.gbFecha.TabIndex = 137
        Me.gbFecha.TabStop = False
        Me.gbFecha.Visible = False
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(95, 47)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(37, 19)
        Me.KryptonLabel7.TabIndex = 141
        Me.KryptonLabel7.Text = "Inicio"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Inicio"
        '
        'dtpFechaFin_SC
        '
        Me.dtpFechaFin_SC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin_SC.Location = New System.Drawing.Point(264, 45)
        Me.dtpFechaFin_SC.Name = "dtpFechaFin_SC"
        Me.dtpFechaFin_SC.Size = New System.Drawing.Size(90, 20)
        Me.dtpFechaFin_SC.TabIndex = 144
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(237, 47)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(25, 19)
        Me.KryptonLabel8.TabIndex = 142
        Me.KryptonLabel8.Text = "Fin"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Fin"
        '
        'dtFechaIni_SC
        '
        Me.dtFechaIni_SC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIni_SC.Location = New System.Drawing.Point(136, 46)
        Me.dtFechaIni_SC.Name = "dtFechaIni_SC"
        Me.dtFechaIni_SC.Size = New System.Drawing.Size(90, 20)
        Me.dtFechaIni_SC.TabIndex = 143
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(6, 46)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(84, 19)
        Me.KryptonLabel5.TabIndex = 140
        Me.KryptonLabel5.Text = "F. Facturación :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "F. Facturación :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(6, 16)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(82, 19)
        Me.KryptonLabel3.TabIndex = 139
        Me.KryptonLabel3.Text = "F. Operación  :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "F. Operación  :"
        '
        'lblFechaIni
        '
        Me.lblFechaIni.Location = New System.Drawing.Point(95, 17)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(37, 19)
        Me.lblFechaIni.TabIndex = 126
        Me.lblFechaIni.Text = "Inicio"
        Me.lblFechaIni.Values.ExtraText = ""
        Me.lblFechaIni.Values.Image = Nothing
        Me.lblFechaIni.Values.Text = "Inicio"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(264, 15)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(90, 20)
        Me.dtpFechaFin.TabIndex = 136
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(237, 17)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(25, 19)
        Me.lblFechaFin.TabIndex = 128
        Me.lblFechaFin.Text = "Fin"
        Me.lblFechaFin.Values.ExtraText = ""
        Me.lblFechaFin.Values.Image = Nothing
        Me.lblFechaFin.Values.Text = "Fin"
        '
        'dtFechaIni
        '
        Me.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIni.Location = New System.Drawing.Point(136, 16)
        Me.dtFechaIni.Name = "dtFechaIni"
        Me.dtFechaIni.Size = New System.Drawing.Size(90, 20)
        Me.dtFechaIni.TabIndex = 130
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(132, 45)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(92, 19)
        Me.KryptonLabel9.TabIndex = 139
        Me.KryptonLabel9.Text = "Mes Facturación"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Mes Facturación"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(6, 15)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(31, 19)
        Me.KryptonLabel6.TabIndex = 126
        Me.KryptonLabel6.Text = "Año "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Año "
        '
        'dbMes_SC
        '
        Me.dbMes_SC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dbMes_SC.FormattingEnabled = True
        Me.dbMes_SC.Location = New System.Drawing.Point(230, 43)
        Me.dbMes_SC.Name = "dbMes_SC"
        Me.dbMes_SC.Size = New System.Drawing.Size(113, 21)
        Me.dbMes_SC.TabIndex = 140
        '
        'ndAnio
        '
        Me.ndAnio.Location = New System.Drawing.Point(43, 13)
        Me.ndAnio.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.ndAnio.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.ndAnio.Name = "ndAnio"
        Me.ndAnio.ReadOnly = True
        Me.ndAnio.Size = New System.Drawing.Size(53, 20)
        Me.ndAnio.TabIndex = 127
        Me.ndAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ndAnio.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'lblMes
        '
        Me.lblMes.Location = New System.Drawing.Point(132, 15)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(86, 19)
        Me.lblMes.TabIndex = 128
        Me.lblMes.Text = "Mes Operación"
        Me.lblMes.Values.ExtraText = ""
        Me.lblMes.Values.Image = Nothing
        Me.lblMes.Values.Text = "Mes Operación"
        '
        'dbMes
        '
        Me.dbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dbMes.FormattingEnabled = True
        Me.dbMes.Location = New System.Drawing.Point(230, 13)
        Me.dbMes.Name = "dbMes"
        Me.dbMes.Size = New System.Drawing.Size(113, 21)
        Me.dbMes.TabIndex = 129
        '
        'UcCompania
        '
        Me.UcCompania.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania.CCMPN_ANTERIOR = Nothing
        Me.UcCompania.CCMPN_CodigoCompania = Nothing
        Me.UcCompania.CCMPN_CompaniaDefault = "EZ"
        Me.UcCompania.CCMPN_Descripcion = Nothing
        Me.UcCompania.Habilitar = True
        Me.UcCompania.Location = New System.Drawing.Point(88, 12)
        Me.UcCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania.Name = "UcCompania"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania.oBeCompania = BeCompania1
        Me.UcCompania.Size = New System.Drawing.Size(244, 23)
        Me.UcCompania.TabIndex = 131
        Me.UcCompania.Usuario = ""
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(19, 82)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel4.TabIndex = 70
        Me.KryptonLabel4.Text = "Cliente :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente :"
        '
        'UcCliente
        '
        Me.UcCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente.BackColor = System.Drawing.Color.Transparent
        Me.UcCliente.CCMPN = "EZ"
        Me.UcCliente.Location = New System.Drawing.Point(88, 79)
        Me.UcCliente.Name = "UcCliente"
        Me.UcCliente.pAccesoPorUsuario = False
        Me.UcCliente.pRequerido = False
        Me.UcCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente.Size = New System.Drawing.Size(371, 21)
        Me.UcCliente.TabIndex = 69
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(19, 12)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(66, 19)
        Me.KryptonLabel1.TabIndex = 35
        Me.KryptonLabel1.Text = "Compañia :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañia :"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(16, 42)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(66, 19)
        Me.lblCompania.TabIndex = 35
        Me.lblCompania.Text = "Compañia :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia :"
        '
        'frmResumenEjecutivoMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 448)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmResumenEjecutivoMensual"
        Me.Text = "Resumen Ejecutivo"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HGDetalle.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalle.Panel.ResumeLayout(False)
        CType(Me.HGDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGDetalle.ResumeLayout(False)
        CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.Panel.ResumeLayout(False)
        Me.HGFiltro.Panel.PerformLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.GbMesAnio.ResumeLayout(False)
        Me.GbMesAnio.PerformLayout()
        Me.gbFecha.ResumeLayout(False)
        Me.gbFecha.PerformLayout()
        CType(Me.ndAnio, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents HGFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents HGDetalle As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnReporte As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dbMes As System.Windows.Forms.ComboBox
    Friend WithEvents lblMes As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ndAnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pbxBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents GbMesAnio As System.Windows.Forms.GroupBox
    Friend WithEvents rbfecha As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbAnual As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbMensual As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents gbFecha As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaIni As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbProceso As CheckComboBoxTest.CheckedComboBox
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaFin_SC As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtFechaIni_SC As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dbMes_SC As System.Windows.Forms.ComboBox
End Class
