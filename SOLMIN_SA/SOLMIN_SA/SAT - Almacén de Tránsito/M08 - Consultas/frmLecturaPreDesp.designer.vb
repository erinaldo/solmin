<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecturaPreDesp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BePlanta1 As RANSA.Controls.UbicacionPlanta.Planta.bePlanta = New RANSA.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim BeCompania1 As RANSA.Controls.UbicacionPlanta.Compania.beCompania = New RANSA.Controls.UbicacionPlanta.Compania.beCompania()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgBulto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.tsReporte = New System.Windows.Forms.ToolStrip()
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.btnAdjuntar = New System.Windows.Forms.ToolStripButton()
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.txtNroPreDespacho = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtClient = New RANSA.Controls.Cliente.ucCliente_TxtF01()
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtBulto = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtPredespacho = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New RANSA.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcDivision_Cmb011 = New RANSA.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCompania_Cmb011 = New RANSA.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.dgPreDespacho = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
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
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_NRO_PRESDPACHO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USU_LECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FINI_LECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HINI_LECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FFIN_LECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HFIN_LECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PEND_LECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_IMG_S = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.NRO_PRESDPACHO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPREDESPACHO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRPLTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NROPLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ULEPRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_LECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H_LECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLAG_LECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_BL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_PD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_PAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_IMG_SPD = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.NMRGIM_IMG_SPAL = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.NMRGIM_IMG_SBL = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsReporte.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPreDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgBulto
        '
        Me.dgBulto.AllowUserToAddRows = False
        Me.dgBulto.AllowUserToDeleteRows = False
        Me.dgBulto.AllowUserToResizeColumns = False
        Me.dgBulto.AllowUserToResizeRows = False
        Me.dgBulto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgBulto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRO_PRESDPACHO, Me.FPREDESPACHO, Me.NRPLTS, Me.NROPLT, Me.CREFFW, Me.TIPO, Me.ULEPRD, Me.F_LECT, Me.H_LECT, Me.FLAG_LECT, Me.NMRGIM_BL, Me.NMRGIM_PD, Me.NMRGIM_PAL, Me.NMRGIM_IMG_SPD, Me.NMRGIM_IMG_SPAL, Me.NMRGIM_IMG_SBL, Me.CCLNT, Me.CCMPN, Me.CDVSN})
        Me.dgBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBulto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgBulto.Location = New System.Drawing.Point(0, 197)
        Me.dgBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.dgBulto.Name = "dgBulto"
        Me.dgBulto.ReadOnly = True
        Me.dgBulto.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBulto.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgBulto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgBulto.Size = New System.Drawing.Size(1525, 261)
        Me.dgBulto.StandardTab = True
        Me.dgBulto.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgBulto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgBulto.TabIndex = 73
        Me.dgBulto.Visible = False
        '
        'tsReporte
        '
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbExportarExcel, Me.btnAdjuntar})
        Me.tsReporte.Location = New System.Drawing.Point(0, 170)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(1525, 27)
        Me.tsReporte.TabIndex = 72
        '
        'tsbBuscar
        '
        Me.tsbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbBuscar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(76, 24)
        Me.tsbBuscar.Text = "Buscar"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.Enabled = False
        Me.tsbExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(126, 24)
        Me.tsbExportarExcel.Text = "Exportar Excel"
        '
        'btnAdjuntar
        '
        Me.btnAdjuntar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdjuntar.Image = Global.SOLMIN_SA.My.Resources.Resources.images__2_
        Me.btnAdjuntar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdjuntar.Name = "btnAdjuntar"
        Me.btnAdjuntar.Size = New System.Drawing.Size(90, 24)
        Me.btnAdjuntar.Text = "Adjuntar"
        Me.btnAdjuntar.Visible = False
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.AutoSize = True
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup2})
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup2.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtNroPreDespacho)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtClient)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblFechaInicial)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dteFechaInicial)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblFechaFinal)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dteFechaFinal)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblPlanta)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblDivision)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.KryptonHeaderGroup2.Panel.MinimumSize = New System.Drawing.Size(0, 148)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1525, 170)
        Me.KryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 71
        Me.KryptonHeaderGroup2.Text = "Filtro"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Filtro"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Filtros"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup2
        '
        Me.ButtonSpecHeaderGroup2.ExtraText = ""
        Me.ButtonSpecHeaderGroup2.Image = Nothing
        Me.ButtonSpecHeaderGroup2.Text = ""
        Me.ButtonSpecHeaderGroup2.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup2.UniqueName = "9ABE9B56D407481F9ABE9B56D407481F"
        '
        'txtNroPreDespacho
        '
        Me.txtNroPreDespacho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroPreDespacho.Location = New System.Drawing.Point(181, 108)
        Me.txtNroPreDespacho.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroPreDespacho.MaxLength = 10
        Me.txtNroPreDespacho.Name = "txtNroPreDespacho"
        Me.txtNroPreDespacho.Size = New System.Drawing.Size(222, 26)
        Me.txtNroPreDespacho.TabIndex = 21
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(27, 110)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(115, 24)
        Me.KryptonLabel1.TabIndex = 20
        Me.KryptonLabel1.Text = "Pre-Despacho : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Pre-Despacho : "
        '
        'txtClient
        '
        Me.txtClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClient.BackColor = System.Drawing.Color.Transparent
        Me.txtClient.CCMPN = "EZ"
        Me.txtClient.Location = New System.Drawing.Point(181, 42)
        Me.txtClient.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.pAccesoPorUsuario = True
        Me.txtClient.pCDDRSP_CodClienteSAP = ""
        Me.txtClient.pRequerido = True
        Me.txtClient.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClient.pVisualizaNegocio = False
        Me.txtClient.Size = New System.Drawing.Size(356, 26)
        Me.txtClient.TabIndex = 19
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(12, 75)
        Me.lblFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(130, 24)
        Me.lblFechaInicial.TabIndex = 15
        Me.lblFechaInicial.Text = "F. Pre-Despacho :"
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "F. Pre-Despacho :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtBulto)
        Me.GroupBox1.Controls.Add(Me.rbtPredespacho)
        Me.GroupBox1.Location = New System.Drawing.Point(567, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(373, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vista"
        '
        'rbtBulto
        '
        Me.rbtBulto.Location = New System.Drawing.Point(181, 20)
        Me.rbtBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtBulto.Name = "rbtBulto"
        Me.rbtBulto.Size = New System.Drawing.Size(59, 24)
        Me.rbtBulto.TabIndex = 0
        Me.rbtBulto.Text = "Bulto"
        Me.rbtBulto.Values.ExtraText = ""
        Me.rbtBulto.Values.Image = Nothing
        Me.rbtBulto.Values.Text = "Bulto"
        '
        'rbtPredespacho
        '
        Me.rbtPredespacho.Checked = True
        Me.rbtPredespacho.Location = New System.Drawing.Point(28, 20)
        Me.rbtPredespacho.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtPredespacho.Name = "rbtPredespacho"
        Me.rbtPredespacho.Size = New System.Drawing.Size(117, 24)
        Me.rbtPredespacho.TabIndex = 1
        Me.rbtPredespacho.Text = "Pre Despacho"
        Me.rbtPredespacho.Values.ExtraText = ""
        Me.rbtPredespacho.Values.Image = Nothing
        Me.rbtPredespacho.Values.Text = "Pre Despacho"
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Checked = False
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(181, 77)
        Me.dteFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(115, 22)
        Me.dteFechaInicial.TabIndex = 16
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(326, 75)
        Me.lblFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(48, 24)
        Me.lblFechaFinal.TabIndex = 17
        Me.lblFechaFinal.Text = "hasta"
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "hasta"
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Checked = False
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(411, 77)
        Me.dteFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(135, 22)
        Me.dteFechaFinal.TabIndex = 18
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(76, 42)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 24)
        Me.lblCliente.TabIndex = 7
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(1014, 14)
        Me.lblPlanta.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(61, 24)
        Me.lblPlanta.TabIndex = 5
        Me.lblPlanta.Text = "Planta : "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta : "
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CodSedeSAP = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(1093, 10)
        Me.UcPLanta_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDSPSP_CodSedeSAP = Nothing
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0.0R
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta1
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0.0R
        Me.UcPLanta_Cmb011.PlantaDefault = -1.0R
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(275, 28)
        Me.UcPLanta_Cmb011.TabIndex = 6
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(599, 14)
        Me.lblDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(73, 24)
        Me.lblDivision.TabIndex = 3
        Me.lblDivision.Text = "División : "
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "División : "
        '
        'UcDivision_Cmb011
        '
        Me.UcDivision_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcDivision_Cmb011.CDVSN_ANTERIOR = Nothing
        Me.UcDivision_Cmb011.Compania = ""
        Me.UcDivision_Cmb011.Division = Nothing
        Me.UcDivision_Cmb011.DivisionDefault = Nothing
        Me.UcDivision_Cmb011.DivisionDescripcion = Nothing
        Me.UcDivision_Cmb011.ItemTodos = False
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(681, 10)
        Me.UcDivision_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(299, 28)
        Me.UcDivision_Cmb011.TabIndex = 4
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(54, 14)
        Me.lblCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(88, 24)
        Me.lblCompania.TabIndex = 1
        Me.lblCompania.Text = "Compañia : "
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia : "
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(181, 10)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(346, 28)
        Me.UcCompania_Cmb011.TabIndex = 2
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'dgPreDespacho
        '
        Me.dgPreDespacho.AllowUserToAddRows = False
        Me.dgPreDespacho.AllowUserToDeleteRows = False
        Me.dgPreDespacho.AllowUserToResizeColumns = False
        Me.dgPreDespacho.AllowUserToResizeRows = False
        Me.dgPreDespacho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPreDespacho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.P_NRO_PRESDPACHO, Me.DataGridViewTextBoxColumn28, Me.USU_LECT, Me.FINI_LECT, Me.HINI_LECT, Me.FFIN_LECT, Me.HFIN_LECT, Me.PEND_LECT, Me.NMRGIM, Me.NMRGIM_IMG_S})
        Me.dgPreDespacho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPreDespacho.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgPreDespacho.Location = New System.Drawing.Point(0, 197)
        Me.dgPreDespacho.Margin = New System.Windows.Forms.Padding(4)
        Me.dgPreDespacho.Name = "dgPreDespacho"
        Me.dgPreDespacho.ReadOnly = True
        Me.dgPreDespacho.RowHeadersWidth = 20
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPreDespacho.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgPreDespacho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgPreDespacho.Size = New System.Drawing.Size(1525, 261)
        Me.dgPreDespacho.StandardTab = True
        Me.dgPreDespacho.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgPreDespacho.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgPreDespacho.TabIndex = 74
        Me.dgPreDespacho.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 73
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TUBRFR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ubicación"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TIPO_ALMACEN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo de Almacén"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ALMACEN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Almacén"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ZONA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FREFFW"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CREFFW"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QREFFW"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TIPBTO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tipo de Bulto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 107
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn11.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TUNPSO"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn12.HeaderText = "Unidad Peso"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 102
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn13.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 83
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TUNVOL"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Unidad Vol."
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 96
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TPRVCL"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NGRPRV"
        Me.DataGridViewTextBoxColumn16.HeaderText = "N° Guía Prov."
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 107
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "QAROCP"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Area Ocupada"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 111
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "NORCML"
        Me.DataGridViewTextBoxColumn18.HeaderText = "N° O/C"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 75
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TTINTC"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Término Internacional Carga"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 186
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DSREFE"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 91
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "NRITOC"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 60
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "TCITCL"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Cod. Cliente"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TCITPR"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Cod. Item Prov"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Descripción del Item"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn25.HeaderText = "Cant. Item"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 91
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "QPEPQT"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn26.HeaderText = "Peso Item"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 88
        '
        'P_NRO_PRESDPACHO
        '
        Me.P_NRO_PRESDPACHO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.P_NRO_PRESDPACHO.DataPropertyName = "NRO_PRESDPACHO"
        Me.P_NRO_PRESDPACHO.HeaderText = "PreDespacho"
        Me.P_NRO_PRESDPACHO.Name = "P_NRO_PRESDPACHO"
        Me.P_NRO_PRESDPACHO.ReadOnly = True
        Me.P_NRO_PRESDPACHO.Width = 129
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "FPREDESPACHO"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Fecha PreDespacho"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 171
        '
        'USU_LECT
        '
        Me.USU_LECT.DataPropertyName = "USU_LECT"
        Me.USU_LECT.HeaderText = "Usuario Lectura"
        Me.USU_LECT.Name = "USU_LECT"
        Me.USU_LECT.ReadOnly = True
        Me.USU_LECT.Width = 144
        '
        'FINI_LECT
        '
        Me.FINI_LECT.DataPropertyName = "FINI_LECT"
        Me.FINI_LECT.HeaderText = "Fecha Ini. Lect"
        Me.FINI_LECT.Name = "FINI_LECT"
        Me.FINI_LECT.ReadOnly = True
        Me.FINI_LECT.Width = 134
        '
        'HINI_LECT
        '
        Me.HINI_LECT.DataPropertyName = "HINI_LECT"
        Me.HINI_LECT.HeaderText = "Hora Ini Lect"
        Me.HINI_LECT.Name = "HINI_LECT"
        Me.HINI_LECT.ReadOnly = True
        Me.HINI_LECT.Width = 126
        '
        'FFIN_LECT
        '
        Me.FFIN_LECT.DataPropertyName = "FFIN_LECT"
        Me.FFIN_LECT.HeaderText = "Fecha Fin Lect."
        Me.FFIN_LECT.Name = "FFIN_LECT"
        Me.FFIN_LECT.ReadOnly = True
        Me.FFIN_LECT.Width = 137
        '
        'HFIN_LECT
        '
        Me.HFIN_LECT.DataPropertyName = "HFIN_LECT"
        Me.HFIN_LECT.HeaderText = "Hora Fin Lect."
        Me.HFIN_LECT.Name = "HFIN_LECT"
        Me.HFIN_LECT.ReadOnly = True
        Me.HFIN_LECT.Width = 132
        '
        'PEND_LECT
        '
        Me.PEND_LECT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PEND_LECT.DataPropertyName = "PEND_LECT"
        Me.PEND_LECT.HeaderText = "Pendiente Lectura"
        Me.PEND_LECT.Name = "PEND_LECT"
        Me.PEND_LECT.ReadOnly = True
        Me.PEND_LECT.Visible = False
        Me.PEND_LECT.Width = 159
        '
        'NMRGIM
        '
        Me.NMRGIM.DataPropertyName = "NMRGIM"
        Me.NMRGIM.HeaderText = "NMRGIM"
        Me.NMRGIM.Name = "NMRGIM"
        Me.NMRGIM.ReadOnly = True
        Me.NMRGIM.Visible = False
        Me.NMRGIM.Width = 102
        '
        'NMRGIM_IMG_S
        '
        Me.NMRGIM_IMG_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRGIM_IMG_S.DataPropertyName = "NMRGIM_IMG_S"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NMRGIM_IMG_S.DefaultCellStyle = DataGridViewCellStyle5
        Me.NMRGIM_IMG_S.HeaderText = "Adjunto Pre-Desp"
        Me.NMRGIM_IMG_S.Name = "NMRGIM_IMG_S"
        Me.NMRGIM_IMG_S.ReadOnly = True
        Me.NMRGIM_IMG_S.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NMRGIM_IMG_S.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NMRGIM_IMG_S.Width = 160
        '
        'NRO_PRESDPACHO
        '
        Me.NRO_PRESDPACHO.DataPropertyName = "NRO_PRESDPACHO"
        Me.NRO_PRESDPACHO.HeaderText = "PreDespacho"
        Me.NRO_PRESDPACHO.Name = "NRO_PRESDPACHO"
        Me.NRO_PRESDPACHO.ReadOnly = True
        Me.NRO_PRESDPACHO.Width = 129
        '
        'FPREDESPACHO
        '
        Me.FPREDESPACHO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FPREDESPACHO.DataPropertyName = "FPREDESPACHO"
        Me.FPREDESPACHO.HeaderText = "Fecha PreDespacho"
        Me.FPREDESPACHO.Name = "FPREDESPACHO"
        Me.FPREDESPACHO.ReadOnly = True
        Me.FPREDESPACHO.Width = 171
        '
        'NRPLTS
        '
        Me.NRPLTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRPLTS.DataPropertyName = "NRPLTS"
        Me.NRPLTS.HeaderText = "Paletizado"
        Me.NRPLTS.Name = "NRPLTS"
        Me.NRPLTS.ReadOnly = True
        Me.NRPLTS.Width = 111
        '
        'NROPLT
        '
        Me.NROPLT.DataPropertyName = "NROPLT"
        Me.NROPLT.HeaderText = "NROPLT"
        Me.NROPLT.Name = "NROPLT"
        Me.NROPLT.ReadOnly = True
        Me.NROPLT.Visible = False
        Me.NROPLT.Width = 95
        '
        'CREFFW
        '
        Me.CREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CREFFW.DataPropertyName = "CREFFW"
        Me.CREFFW.HeaderText = "Bulto"
        Me.CREFFW.Name = "CREFFW"
        Me.CREFFW.ReadOnly = True
        Me.CREFFW.Width = 77
        '
        'TIPO
        '
        Me.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO.DataPropertyName = "TIPO"
        Me.TIPO.HeaderText = "Tipo"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        Me.TIPO.Width = 72
        '
        'ULEPRD
        '
        Me.ULEPRD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ULEPRD.DataPropertyName = "USU_LECT"
        Me.ULEPRD.HeaderText = "Usuario Lectura"
        Me.ULEPRD.Name = "ULEPRD"
        Me.ULEPRD.ReadOnly = True
        Me.ULEPRD.Width = 144
        '
        'F_LECT
        '
        Me.F_LECT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.F_LECT.DataPropertyName = "F_LECT"
        Me.F_LECT.HeaderText = "Fecha Ini. Lectura"
        Me.F_LECT.Name = "F_LECT"
        Me.F_LECT.ReadOnly = True
        Me.F_LECT.Width = 155
        '
        'H_LECT
        '
        Me.H_LECT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.H_LECT.DataPropertyName = "H_LECT"
        Me.H_LECT.HeaderText = "Hora Ini Lect"
        Me.H_LECT.Name = "H_LECT"
        Me.H_LECT.ReadOnly = True
        Me.H_LECT.Width = 126
        '
        'FLAG_LECT
        '
        Me.FLAG_LECT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLAG_LECT.DataPropertyName = "FLAG_LECT"
        Me.FLAG_LECT.HeaderText = "Lectura"
        Me.FLAG_LECT.Name = "FLAG_LECT"
        Me.FLAG_LECT.ReadOnly = True
        Me.FLAG_LECT.Width = 90
        '
        'NMRGIM_BL
        '
        Me.NMRGIM_BL.DataPropertyName = "NMRGIM_BL"
        Me.NMRGIM_BL.HeaderText = "NMRGIM_BL"
        Me.NMRGIM_BL.Name = "NMRGIM_BL"
        Me.NMRGIM_BL.ReadOnly = True
        Me.NMRGIM_BL.Visible = False
        Me.NMRGIM_BL.Width = 124
        '
        'NMRGIM_PD
        '
        Me.NMRGIM_PD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRGIM_PD.DataPropertyName = "NMRGIM_PD"
        Me.NMRGIM_PD.HeaderText = "NMRGIM_PD"
        Me.NMRGIM_PD.Name = "NMRGIM_PD"
        Me.NMRGIM_PD.ReadOnly = True
        Me.NMRGIM_PD.Visible = False
        Me.NMRGIM_PD.Width = 127
        '
        'NMRGIM_PAL
        '
        Me.NMRGIM_PAL.DataPropertyName = "NMRGIM_PAL"
        Me.NMRGIM_PAL.HeaderText = "NMRGIM_PAL"
        Me.NMRGIM_PAL.Name = "NMRGIM_PAL"
        Me.NMRGIM_PAL.ReadOnly = True
        Me.NMRGIM_PAL.Visible = False
        Me.NMRGIM_PAL.Width = 132
        '
        'NMRGIM_IMG_SPD
        '
        Me.NMRGIM_IMG_SPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRGIM_IMG_SPD.DataPropertyName = "NMRGIM_IMG_SPD"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NMRGIM_IMG_SPD.DefaultCellStyle = DataGridViewCellStyle1
        Me.NMRGIM_IMG_SPD.HeaderText = "Adj. Pre-Despacho"
        Me.NMRGIM_IMG_SPD.Name = "NMRGIM_IMG_SPD"
        Me.NMRGIM_IMG_SPD.ReadOnly = True
        Me.NMRGIM_IMG_SPD.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NMRGIM_IMG_SPD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NMRGIM_IMG_SPD.Width = 165
        '
        'NMRGIM_IMG_SPAL
        '
        Me.NMRGIM_IMG_SPAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRGIM_IMG_SPAL.DataPropertyName = "NMRGIM_IMG_SPAL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NMRGIM_IMG_SPAL.DefaultCellStyle = DataGridViewCellStyle2
        Me.NMRGIM_IMG_SPAL.HeaderText = "Adj. Pallet"
        Me.NMRGIM_IMG_SPAL.Name = "NMRGIM_IMG_SPAL"
        Me.NMRGIM_IMG_SPAL.ReadOnly = True
        Me.NMRGIM_IMG_SPAL.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NMRGIM_IMG_SPAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NMRGIM_IMG_SPAL.Width = 108
        '
        'NMRGIM_IMG_SBL
        '
        Me.NMRGIM_IMG_SBL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRGIM_IMG_SBL.DataPropertyName = "NMRGIM_IMG_SBL"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NMRGIM_IMG_SBL.DefaultCellStyle = DataGridViewCellStyle3
        Me.NMRGIM_IMG_SBL.HeaderText = "Adjunto Bulto"
        Me.NMRGIM_IMG_SBL.Name = "NMRGIM_IMG_SBL"
        Me.NMRGIM_IMG_SBL.ReadOnly = True
        Me.NMRGIM_IMG_SBL.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NMRGIM_IMG_SBL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NMRGIM_IMG_SBL.Width = 134
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        Me.CCLNT.Width = 86
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        Me.CCMPN.Width = 92
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        Me.CDVSN.Width = 90
        '
        'frmLecturaPreDesp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1525, 458)
        Me.Controls.Add(Me.dgPreDespacho)
        Me.Controls.Add(Me.dgBulto)
        Me.Controls.Add(Me.tsReporte)
        Me.Controls.Add(Me.KryptonHeaderGroup2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLecturaPreDesp"
        Me.Text = "Pre Despacho"
        CType(Me.dgBulto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgPreDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgBulto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtBulto As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtPredespacho As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Private WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Private WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
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
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents dgPreDespacho As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtClient As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents txtNroPreDespacho As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnAdjuntar As System.Windows.Forms.ToolStripButton
    Friend WithEvents NRO_PRESDPACHO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPREDESPACHO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRPLTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROPLT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ULEPRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_LECT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents H_LECT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLAG_LECT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_BL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_PD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_PAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_IMG_SPD As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents NMRGIM_IMG_SPAL As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents NMRGIM_IMG_SBL As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_NRO_PRESDPACHO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USU_LECT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINI_LECT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HINI_LECT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FFIN_LECT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HFIN_LECT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PEND_LECT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_IMG_S As System.Windows.Forms.DataGridViewLinkColumn
End Class
