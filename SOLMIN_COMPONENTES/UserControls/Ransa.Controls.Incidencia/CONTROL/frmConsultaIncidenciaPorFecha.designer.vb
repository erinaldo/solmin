<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaIncidenciaPorFecha
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCliente = New Ransa.Utilitario.ucCliente_Check
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbReportado = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.cmbNegocio = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.cmbPlanta = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.cmbArea = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.cmbIncPara = New System.Windows.Forms.ComboBox
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tss03 = New System.Windows.Forms.ToolStripSeparator
        Me.tss05 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.tsbGenerarReporte = New System.Windows.Forms.ToolStripButton
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbReportado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNegocio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPlanta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(574, 318)
        Me.KryptonPanel.TabIndex = 0
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisiblePrimary = False
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 25)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.GroupBox2)
        Me.khgFiltros.Panel.Controls.Add(Me.GroupBox1)
        Me.khgFiltros.Size = New System.Drawing.Size(574, 328)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 66
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = "Cerrar"
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.ButtonSpecHeaderGroup1.UniqueName = "CDC27BFBCDA643B3CDC27BFBCDA643B3"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen)
        Me.GroupBox1.Controls.Add(Me.txtTipoAlmacen)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel9)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(13, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adicionales"
        '
        'txtCliente
        '
        Me.txtCliente.DataSource = Nothing
        Me.txtCliente.DispleyMember = ""
        Me.txtCliente.ListColumnas = Nothing
        Me.txtCliente.Location = New System.Drawing.Point(19, 35)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Obligatorio = False
        Me.txtCliente.Size = New System.Drawing.Size(515, 28)
        Me.txtCliente.TabIndex = 1
        Me.txtCliente.ValueMember = ""
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(273, 79)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = False
        Me.txtAlmacen.PopupHeight = 0
        Me.txtAlmacen.PopupWidth = 0
        Me.txtAlmacen.Size = New System.Drawing.Size(261, 26)
        Me.txtAlmacen.TabIndex = 5
        Me.txtAlmacen.ValueMember = ""
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(19, 79)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = False
        Me.txtTipoAlmacen.PopupHeight = 0
        Me.txtTipoAlmacen.PopupWidth = 0
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(246, 26)
        Me.txtTipoAlmacen.TabIndex = 3
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(14, 18)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(48, 20)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(269, 60)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(58, 20)
        Me.KryptonLabel9.TabIndex = 4
        Me.KryptonLabel9.Text = "Almacén"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Almacén"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 60)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(85, 20)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Tipo Almacén"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo Almacén"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cmbReportado)
        Me.GroupBox2.Controls.Add(Me.cmbNegocio)
        Me.GroupBox2.Controls.Add(Me.pcxEspera)
        Me.GroupBox2.Controls.Add(Me.cmbPlanta)
        Me.GroupBox2.Controls.Add(Me.cmbArea)
        Me.GroupBox2.Controls.Add(Me.cmbIncPara)
        Me.GroupBox2.Controls.Add(Me.dteFechaInicial)
        Me.GroupBox2.Controls.Add(Me.dteFechaFinal)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel1)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel2)
        Me.GroupBox2.Controls.Add(Me.lblFechaInicial)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel5)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel6)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel4)
        Me.GroupBox2.Controls.Add(Me.lblFechaFinal)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(548, 158)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'cmbReportado
        '
        Me.cmbReportado.EditValue = ""
        Me.cmbReportado.Location = New System.Drawing.Point(19, 77)
        Me.cmbReportado.Name = "cmbReportado"
        Me.cmbReportado.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbReportado.Properties.Appearance.Options.UseBackColor = True
        Me.cmbReportado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbReportado.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbReportado.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbReportado.Properties.SelectAllItemCaption = "Todos"
        Me.cmbReportado.Size = New System.Drawing.Size(220, 22)
        Me.cmbReportado.TabIndex = 5
        '
        'cmbNegocio
        '
        Me.cmbNegocio.EditValue = ""
        Me.cmbNegocio.Location = New System.Drawing.Point(19, 121)
        Me.cmbNegocio.Name = "cmbNegocio"
        Me.cmbNegocio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbNegocio.Properties.Appearance.Options.UseBackColor = True
        Me.cmbNegocio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNegocio.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbNegocio.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbNegocio.Properties.SelectAllItemCaption = "Todos"
        Me.cmbNegocio.Size = New System.Drawing.Size(220, 22)
        Me.cmbNegocio.TabIndex = 9
        '
        'cmbPlanta
        '
        Me.cmbPlanta.EditValue = ""
        Me.cmbPlanta.Location = New System.Drawing.Point(273, 32)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPlanta.Properties.Appearance.Options.UseBackColor = True
        Me.cmbPlanta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPlanta.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbPlanta.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbPlanta.Properties.SelectAllItemCaption = "Todos"
        Me.cmbPlanta.Size = New System.Drawing.Size(261, 22)
        Me.cmbPlanta.TabIndex = 3
        '
        'cmbArea
        '
        Me.cmbArea.EditValue = ""
        Me.cmbArea.Location = New System.Drawing.Point(19, 32)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbArea.Properties.Appearance.Options.UseBackColor = True
        Me.cmbArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbArea.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbArea.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbArea.Properties.SelectAllItemCaption = "Todos"
        Me.cmbArea.Size = New System.Drawing.Size(220, 22)
        Me.cmbArea.TabIndex = 1
        '
        'cmbIncPara
        '
        Me.cmbIncPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIncPara.FormattingEnabled = True
        Me.cmbIncPara.Location = New System.Drawing.Point(273, 78)
        Me.cmbIncPara.Name = "cmbIncPara"
        Me.cmbIncPara.Size = New System.Drawing.Size(261, 21)
        Me.cmbIncPara.TabIndex = 7
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.CalendarMonthBackground = System.Drawing.Color.White
        Me.dteFechaInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(273, 123)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(95, 20)
        Me.dteFechaInicial.TabIndex = 11
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(374, 125)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.dteFechaFinal.TabIndex = 13
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(268, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(44, 20)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Planta"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Planta"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(15, 15)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel2.TabIndex = 0
        Me.KryptonLabel2.Text = "Área"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Área"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(268, 105)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(97, 20)
        Me.lblFechaInicial.TabIndex = 10
        Me.lblFechaInicial.Text = "Fecha Inc. Inicio"
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inc. Inicio"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(269, 60)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel5.TabIndex = 6
        Me.KryptonLabel5.Text = "Inc. Para"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Inc. Para"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(14, 60)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel6.TabIndex = 4
        Me.KryptonLabel6.Text = "Reportado por"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Reportado por"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(14, 102)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(57, 20)
        Me.KryptonLabel4.TabIndex = 8
        Me.KryptonLabel4.Text = "Negocio"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Negocio"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(369, 105)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(93, 20)
        Me.lblFechaFinal.TabIndex = 12
        Me.lblFechaFinal.Text = "Fecha Inc. Final"
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Inc. Final"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbCancelar, Me.tss03, Me.tsbGenerarReporte, Me.tss05, Me.btnExportar, Me.ToolStripSeparator2})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(574, 25)
        Me.tsMenuOpciones.TabIndex = 65
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tss03
        '
        Me.tss03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss03.Name = "tss03"
        Me.tss03.Size = New System.Drawing.Size(6, 25)
        '
        'tss05
        '
        Me.tss05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss05.Name = "tss05"
        Me.tss05.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'bgwGifAnimado
        '
        '
        'BackgroundWorker1
        '
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.iconoEspera
        Me.pcxEspera.Location = New System.Drawing.Point(487, 102)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(55, 51)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcxEspera.TabIndex = 84
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.button_cancel
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(73, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'tsbGenerarReporte
        '
        Me.tsbGenerarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGenerarReporte.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.GenerarReporte
        Me.tsbGenerarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarReporte.Name = "tsbGenerarReporte"
        Me.tsbGenerarReporte.Size = New System.Drawing.Size(112, 22)
        Me.tsbGenerarReporte.Text = "Generar Reporte"
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.excelicon
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(70, 22)
        Me.btnExportar.Text = "Exportar"
        '
        'frmConsultaIncidenciaPorFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 318)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaIncidenciaPorFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta  Incidencias por Fecha"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbReportado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNegocio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPlanta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tss03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tss05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsbGenerarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    'Friend WithEvents cmbDivision As DevExpress.XtraEditors.CheckedComboBoxEdit
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As RANSA.Utilitario.ucCliente_Check
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
    Private WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    'Friend WithEvents cmbCliente As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    'Friend WithEvents cmbPlanta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbIncPara As System.Windows.Forms.ComboBox
    Friend WithEvents cmbArea As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cmbPlanta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cmbNegocio As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cmbReportado As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    'Friend WithEvents cmbNegocio As DevExpress.XtraEditors.CheckedComboBoxEdit
End Class
