<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaSeguimientoPorFecha
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbReportado = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbNegocio = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.cmbIncPara = New System.Windows.Forms.ComboBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboEstado = New System.Windows.Forms.ComboBox
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.cmbPlanta = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.cmbArea = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCliente = New Ransa.Utilitario.ucCliente_Check
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCliente = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tss03 = New System.Windows.Forms.ToolStripSeparator
        Me.tss05 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.tsbGenerarReporte = New System.Windows.Forms.ToolStripButton
        Me.tsbExportar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbReportado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNegocio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPlanta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(623, 308)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel1.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(623, 308)
        Me.KryptonPanel1.TabIndex = 1
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
        Me.khgFiltros.Panel.Controls.Add(Me.cmbCliente)
        Me.khgFiltros.Size = New System.Drawing.Size(623, 297)
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cmbReportado)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel6)
        Me.GroupBox2.Controls.Add(Me.cmbNegocio)
        Me.GroupBox2.Controls.Add(Me.pcxEspera)
        Me.GroupBox2.Controls.Add(Me.cmbIncPara)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel5)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel3)
        Me.GroupBox2.Controls.Add(Me.cboEstado)
        Me.GroupBox2.Controls.Add(Me.dteFechaInicial)
        Me.GroupBox2.Controls.Add(Me.dteFechaFinal)
        Me.GroupBox2.Controls.Add(Me.cmbPlanta)
        Me.GroupBox2.Controls.Add(Me.cmbArea)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel1)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel2)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel4)
        Me.GroupBox2.Controls.Add(Me.lblFechaInicial)
        Me.GroupBox2.Controls.Add(Me.lblFechaFinal)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 189)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'cmbReportado
        '
        Me.cmbReportado.EditValue = ""
        Me.cmbReportado.Location = New System.Drawing.Point(19, 108)
        Me.cmbReportado.Name = "cmbReportado"
        Me.cmbReportado.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbReportado.Properties.Appearance.Options.UseBackColor = True
        Me.cmbReportado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbReportado.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbReportado.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbReportado.Properties.SelectAllItemCaption = "Todos"
        Me.cmbReportado.Size = New System.Drawing.Size(257, 22)
        Me.cmbReportado.TabIndex = 11
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(13, 92)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel6.TabIndex = 10
        Me.KryptonLabel6.Text = "Reportado por"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Reportado por"
        '
        'cmbNegocio
        '
        Me.cmbNegocio.EditValue = ""
        Me.cmbNegocio.Location = New System.Drawing.Point(19, 149)
        Me.cmbNegocio.Name = "cmbNegocio"
        Me.cmbNegocio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbNegocio.Properties.Appearance.Options.UseBackColor = True
        Me.cmbNegocio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNegocio.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbNegocio.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbNegocio.Properties.SelectAllItemCaption = "TODOS"
        Me.cmbNegocio.Size = New System.Drawing.Size(258, 22)
        Me.cmbNegocio.TabIndex = 15
        '
        'cmbIncPara
        '
        Me.cmbIncPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIncPara.FormattingEnabled = True
        Me.cmbIncPara.Location = New System.Drawing.Point(296, 111)
        Me.cmbIncPara.Name = "cmbIncPara"
        Me.cmbIncPara.Size = New System.Drawing.Size(271, 21)
        Me.cmbIncPara.TabIndex = 13
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(291, 94)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(92, 20)
        Me.KryptonLabel5.TabIndex = 12
        Me.KryptonLabel5.Text = "Incidencia Para"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Incidencia Para"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(15, 130)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(57, 20)
        Me.KryptonLabel3.TabIndex = 14
        Me.KryptonLabel3.Text = "Negocio"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Negocio"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(20, 70)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(257, 21)
        Me.cboEstado.TabIndex = 5
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.CalendarMonthBackground = System.Drawing.Color.White
        Me.dteFechaInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(296, 72)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(118, 20)
        Me.dteFechaInicial.TabIndex = 7
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(455, 72)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(112, 20)
        Me.dteFechaFinal.TabIndex = 9
        '
        'cmbPlanta
        '
        Me.cmbPlanta.EditValue = ""
        Me.cmbPlanta.Location = New System.Drawing.Point(296, 31)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPlanta.Properties.Appearance.Options.UseBackColor = True
        Me.cmbPlanta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPlanta.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbPlanta.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbPlanta.Properties.SelectAllItemCaption = "TODOS"
        Me.cmbPlanta.Size = New System.Drawing.Size(271, 22)
        Me.cmbPlanta.TabIndex = 3
        '
        'cmbArea
        '
        Me.cmbArea.EditValue = ""
        Me.cmbArea.Location = New System.Drawing.Point(19, 30)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbArea.Properties.Appearance.Options.UseBackColor = True
        Me.cmbArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbArea.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbArea.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbArea.Properties.SelectAllItemCaption = "TODOS"
        Me.cmbArea.Size = New System.Drawing.Size(257, 22)
        Me.cmbArea.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(291, 14)
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
        Me.KryptonLabel2.Location = New System.Drawing.Point(15, 14)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel2.TabIndex = 0
        Me.KryptonLabel2.Text = "Área"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Área"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(15, 53)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(47, 20)
        Me.KryptonLabel4.TabIndex = 4
        Me.KryptonLabel4.Text = "Estado"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Estado"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(291, 55)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(97, 20)
        Me.lblFechaInicial.TabIndex = 6
        Me.lblFechaInicial.Text = "Fecha Inc. Inicio"
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inc. Inicio"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(455, 55)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(93, 20)
        Me.lblFechaFinal.TabIndex = 8
        Me.lblFechaFinal.Text = "Fecha Inc. Final "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Inc. Final "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(17, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adicionales"
        '
        'txtCliente
        '
        Me.txtCliente.DataSource = Nothing
        Me.txtCliente.DispleyMember = ""
        Me.txtCliente.ListColumnas = Nothing
        Me.txtCliente.Location = New System.Drawing.Point(20, 36)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Obligatorio = False
        Me.txtCliente.Size = New System.Drawing.Size(547, 28)
        Me.txtCliente.TabIndex = 1
        Me.txtCliente.ValueMember = ""
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(15, 19)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(48, 20)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente"
        '
        'cmbCliente
        '
        Me.cmbCliente.EditValue = ""
        Me.cmbCliente.Location = New System.Drawing.Point(710, 159)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCliente.Properties.LookAndFeel.SkinName = "Blue"
        Me.cmbCliente.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbCliente.Size = New System.Drawing.Size(24, 20)
        Me.cmbCliente.TabIndex = 123
        Me.cmbCliente.Visible = False
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbCancelar, Me.tss03, Me.tsbGenerarReporte, Me.tss05, Me.tsbExportar, Me.ToolStripSeparator2})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(623, 25)
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
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.iconoEspera
        Me.pcxEspera.Location = New System.Drawing.Point(402, 134)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(53, 51)
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
        'tsbExportar
        '
        Me.tsbExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportar.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.excelicon
        Me.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportar.Name = "tsbExportar"
        Me.tsbExportar.Size = New System.Drawing.Size(70, 22)
        Me.tsbExportar.Text = "Exportar"
        '
        'frmConsultaSeguimientoPorFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 308)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConsultaSeguimientoPorFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Seguimiento Por Fecha"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbReportado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNegocio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPlanta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPlanta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cmbArea As DevExpress.XtraEditors.CheckedComboBoxEdit
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Utilitario.ucCliente_Check
    Friend WithEvents cmbCliente As DevExpress.XtraEditors.CheckedComboBoxEdit
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGenerarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents tsbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbIncPara As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbNegocio As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cmbReportado As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
End Class
