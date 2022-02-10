<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaletizado
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
        Dim BePlanta2 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim BeCompania2 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsReporte = New System.Windows.Forms.ToolStrip()
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.btnAdjuntar = New System.Windows.Forms.ToolStripButton()
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.txtPaletizado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtClient = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.txtBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblBulto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvPaletizado = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NROPLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRPLTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FELPLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NSEQIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANT_BULTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_IMG_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion()
        Me.kdgvBultos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.COD_BULTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_UNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_CANT_BULTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_IMG_B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdjuntoBulto = New System.Windows.Forms.ToolStripButton()
        Me.tsReporte.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvPaletizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kdgvBultos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsReporte
        '
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.tsbExportarExcel, Me.btnAdjuntar})
        Me.tsReporte.Location = New System.Drawing.Point(0, 140)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(1299, 27)
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
        Me.tsbExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(107, 24)
        Me.tsbExportarExcel.Text = "Exportar F1"
        '
        'btnAdjuntar
        '
        Me.btnAdjuntar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdjuntar.Image = Global.SOLMIN_SA.My.Resources.Resources.images__2_
        Me.btnAdjuntar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdjuntar.Name = "btnAdjuntar"
        Me.btnAdjuntar.Size = New System.Drawing.Size(90, 24)
        Me.btnAdjuntar.Text = "Adjuntar"
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup2})
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup2.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtPaletizado)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtClient)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblFechaInicial)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dteFechaInicial)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dteFechaFinal)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtBulto)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblBulto)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblPlanta)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblDivision)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.KryptonHeaderGroup2.Panel.MinimumSize = New System.Drawing.Size(0, 148)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1299, 140)
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
        'txtPaletizado
        '
        Me.txtPaletizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaletizado.Location = New System.Drawing.Point(139, 76)
        Me.txtPaletizado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaletizado.MaxLength = 25
        Me.txtPaletizado.Name = "txtPaletizado"
        Me.txtPaletizado.Size = New System.Drawing.Size(187, 26)
        Me.txtPaletizado.TabIndex = 21
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(334, 76)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(55, 24)
        Me.KryptonLabel1.TabIndex = 20
        Me.KryptonLabel1.Text = "Bulto : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Bulto : "
        '
        'txtClient
        '
        Me.txtClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClient.BackColor = System.Drawing.Color.Transparent
        Me.txtClient.CCMPN = "EZ"
        Me.txtClient.Location = New System.Drawing.Point(139, 42)
        Me.txtClient.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.pAccesoPorUsuario = True
        Me.txtClient.pCDDRSP_CodClienteSAP = ""
        Me.txtClient.pRequerido = True
        Me.txtClient.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClient.pVisualizaNegocio = False
        Me.txtClient.Size = New System.Drawing.Size(295, 26)
        Me.txtClient.TabIndex = 19
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(461, 44)
        Me.lblFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(133, 24)
        Me.lblFechaInicial.TabIndex = 15
        Me.lblFechaInicial.Text = "Fecha Paletizado :"
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Paletizado :"
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Checked = False
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(621, 46)
        Me.dteFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(115, 22)
        Me.dteFechaInicial.TabIndex = 16
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Checked = False
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(745, 46)
        Me.dteFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(135, 22)
        Me.dteFechaFinal.TabIndex = 18
        '
        'txtBulto
        '
        Me.txtBulto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBulto.Location = New System.Drawing.Point(408, 77)
        Me.txtBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBulto.MaxLength = 25
        Me.txtBulto.Name = "txtBulto"
        Me.txtBulto.Size = New System.Drawing.Size(176, 26)
        Me.txtBulto.TabIndex = 14
        '
        'lblBulto
        '
        Me.lblBulto.Location = New System.Drawing.Point(15, 76)
        Me.lblBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.lblBulto.Name = "lblBulto"
        Me.lblBulto.Size = New System.Drawing.Size(89, 24)
        Me.lblBulto.TabIndex = 13
        Me.lblBulto.Text = "Paletizado : "
        Me.lblBulto.Values.ExtraText = ""
        Me.lblBulto.Values.Image = Nothing
        Me.lblBulto.Values.Text = "Paletizado : "
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(15, 44)
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
        Me.lblPlanta.Location = New System.Drawing.Point(819, 8)
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(899, 4)
        Me.UcPLanta_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta2.CCMPN_CodigoCompania = ""
        BePlanta2.CDSPSP_CodSedeSAP = Nothing
        BePlanta2.CDVSN_CodigoDivision = ""
        BePlanta2.CPLNDV_CodigoPlanta = 0.0R
        BePlanta2.Orden = -1
        BePlanta2.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta2
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0.0R
        Me.UcPLanta_Cmb011.PlantaDefault = -1.0R
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(208, 28)
        Me.UcPLanta_Cmb011.TabIndex = 6
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(461, 8)
        Me.lblDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(73, 24)
        Me.lblDivision.TabIndex = 3
        Me.lblDivision.Text = "Division : "
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "Division : "
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(554, 4)
        Me.UcDivision_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(239, 28)
        Me.UcDivision_Cmb011.TabIndex = 4
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(13, 8)
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
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(139, 4)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania2.CCMPN_CodigoCompania = ""
        BeCompania2.Orden = -1
        BeCompania2.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania2
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(295, 28)
        Me.UcCompania_Cmb011.TabIndex = 2
        Me.UcCompania_Cmb011.Usuario = ""
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 102
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TUBRFR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ubicación"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 89
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TIPO_ALMACEN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo de Almacén"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 126
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ALMACEN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Almacén"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 83
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ZONA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 63
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FREFFW"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 67
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CREFFW"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 64
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QREFFW"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 84
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TIPBTO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tipo de Bulto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 107
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn11.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 61
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TUNPSO"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn12.HeaderText = "Unidad Peso"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 102
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn13.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 83
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TUNVOL"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Unidad Vol."
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 96
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TPRVCL"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 90
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
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "TCITCL"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Cod. Cliente"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 101
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TCITPR"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Cod. Item Prov"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Descripción del Item"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 144
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn25.HeaderText = "Cant. Item"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 91
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "QPEPQT"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn26.HeaderText = "Peso Item"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 88
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 167)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvPaletizado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcPaginacion1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.kdgvBultos)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1299, 410)
        Me.SplitContainer1.SplitterDistance = 208
        Me.SplitContainer1.TabIndex = 73
        '
        'dgvPaletizado
        '
        Me.dgvPaletizado.AllowUserToAddRows = False
        Me.dgvPaletizado.AllowUserToDeleteRows = False
        Me.dgvPaletizado.AllowUserToResizeColumns = False
        Me.dgvPaletizado.AllowUserToResizeRows = False
        Me.dgvPaletizado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPaletizado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CPLNDV, Me.CDVSN, Me.CCMPN, Me.CCLNT, Me.NROPLT, Me.NRPLTS, Me.FELPLT, Me.NSEQIN, Me.NMRGIM_S, Me.CANT_BULTOS, Me.NMRGIM_IMG_S, Me.Column1})
        Me.dgvPaletizado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPaletizado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPaletizado.Location = New System.Drawing.Point(0, 0)
        Me.dgvPaletizado.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPaletizado.Name = "dgvPaletizado"
        Me.dgvPaletizado.ReadOnly = True
        Me.dgvPaletizado.RowHeadersWidth = 20
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPaletizado.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvPaletizado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPaletizado.Size = New System.Drawing.Size(1299, 177)
        Me.dgvPaletizado.StandardTab = True
        Me.dgvPaletizado.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvPaletizado.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvPaletizado.TabIndex = 77
        '
        'CPLNDV
        '
        Me.CPLNDV.DataPropertyName = "CPLNDV"
        Me.CPLNDV.HeaderText = "CPLNDV"
        Me.CPLNDV.Name = "CPLNDV"
        Me.CPLNDV.ReadOnly = True
        Me.CPLNDV.Visible = False
        Me.CPLNDV.Width = 97
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "Column2"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        Me.CDVSN.Width = 101
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
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        Me.CCLNT.Width = 86
        '
        'NROPLT
        '
        Me.NROPLT.DataPropertyName = "NROPLT"
        Me.NROPLT.HeaderText = "Id Pallet"
        Me.NROPLT.Name = "NROPLT"
        Me.NROPLT.ReadOnly = True
        Me.NROPLT.Width = 95
        '
        'NRPLTS
        '
        Me.NRPLTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRPLTS.DataPropertyName = "NRPLTS"
        Me.NRPLTS.HeaderText = "Nro Paletizado"
        Me.NRPLTS.Name = "NRPLTS"
        Me.NRPLTS.ReadOnly = True
        Me.NRPLTS.Width = 140
        '
        'FELPLT
        '
        Me.FELPLT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FELPLT.DataPropertyName = "FELPLT"
        Me.FELPLT.HeaderText = "Fecha Paletizado"
        Me.FELPLT.Name = "FELPLT"
        Me.FELPLT.ReadOnly = True
        Me.FELPLT.Width = 153
        '
        'NSEQIN
        '
        Me.NSEQIN.DataPropertyName = "NSEQIN"
        Me.NSEQIN.HeaderText = "NSEQIN"
        Me.NSEQIN.Name = "NSEQIN"
        Me.NSEQIN.ReadOnly = True
        Me.NSEQIN.Visible = False
        Me.NSEQIN.Width = 95
        '
        'NMRGIM_S
        '
        Me.NMRGIM_S.DataPropertyName = "NMRGIM"
        Me.NMRGIM_S.HeaderText = "NMRGIM"
        Me.NMRGIM_S.Name = "NMRGIM_S"
        Me.NMRGIM_S.ReadOnly = True
        Me.NMRGIM_S.Visible = False
        Me.NMRGIM_S.Width = 102
        '
        'CANT_BULTOS
        '
        Me.CANT_BULTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANT_BULTOS.DataPropertyName = "CANT_BULTOS"
        Me.CANT_BULTOS.HeaderText = "Cant. Bultos"
        Me.CANT_BULTOS.Name = "CANT_BULTOS"
        Me.CANT_BULTOS.ReadOnly = True
        Me.CANT_BULTOS.Width = 120
        '
        'NMRGIM_IMG_S
        '
        Me.NMRGIM_IMG_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRGIM_IMG_S.DataPropertyName = "ADJUNTOS"
        Me.NMRGIM_IMG_S.HeaderText = "Adjuntos"
        Me.NMRGIM_IMG_S.Name = "NMRGIM_IMG_S"
        Me.NMRGIM_IMG_S.ReadOnly = True
        Me.NMRGIM_IMG_S.Width = 101
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 177)
        Me.UcPaginacion1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(1299, 31)
        Me.UcPaginacion1.TabIndex = 76
        '
        'kdgvBultos
        '
        Me.kdgvBultos.AllowUserToAddRows = False
        Me.kdgvBultos.AllowUserToDeleteRows = False
        Me.kdgvBultos.AllowUserToResizeColumns = False
        Me.kdgvBultos.AllowUserToResizeRows = False
        Me.kdgvBultos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.kdgvBultos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD_BULTO, Me.TIPO_UNIDAD, Me.D_CANT_BULTOS, Me.NMRGIM_B, Me.NMRGIM_IMG_B, Me.Column2})
        Me.kdgvBultos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kdgvBultos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.kdgvBultos.Location = New System.Drawing.Point(0, 27)
        Me.kdgvBultos.Margin = New System.Windows.Forms.Padding(4)
        Me.kdgvBultos.Name = "kdgvBultos"
        Me.kdgvBultos.ReadOnly = True
        Me.kdgvBultos.RowHeadersWidth = 20
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kdgvBultos.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.kdgvBultos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.kdgvBultos.Size = New System.Drawing.Size(1299, 171)
        Me.kdgvBultos.StandardTab = True
        Me.kdgvBultos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.kdgvBultos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kdgvBultos.TabIndex = 78
        '
        'COD_BULTO
        '
        Me.COD_BULTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_BULTO.DataPropertyName = "COD_BULTO"
        Me.COD_BULTO.HeaderText = "Bulto"
        Me.COD_BULTO.Name = "COD_BULTO"
        Me.COD_BULTO.ReadOnly = True
        Me.COD_BULTO.Width = 77
        '
        'TIPO_UNIDAD
        '
        Me.TIPO_UNIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_UNIDAD.DataPropertyName = "TIPO_UNIDAD"
        Me.TIPO_UNIDAD.HeaderText = "Tipo Unidad"
        Me.TIPO_UNIDAD.Name = "TIPO_UNIDAD"
        Me.TIPO_UNIDAD.ReadOnly = True
        Me.TIPO_UNIDAD.Width = 124
        '
        'D_CANT_BULTOS
        '
        Me.D_CANT_BULTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.D_CANT_BULTOS.DataPropertyName = "CANT_BULTOS"
        Me.D_CANT_BULTOS.HeaderText = "Cant. Bultos"
        Me.D_CANT_BULTOS.Name = "D_CANT_BULTOS"
        Me.D_CANT_BULTOS.ReadOnly = True
        Me.D_CANT_BULTOS.Width = 120
        '
        'NMRGIM_B
        '
        Me.NMRGIM_B.DataPropertyName = "NMRGIM"
        Me.NMRGIM_B.HeaderText = "NMRGIM"
        Me.NMRGIM_B.Name = "NMRGIM_B"
        Me.NMRGIM_B.ReadOnly = True
        Me.NMRGIM_B.Visible = False
        Me.NMRGIM_B.Width = 102
        '
        'NMRGIM_IMG_B
        '
        Me.NMRGIM_IMG_B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRGIM_IMG_B.DataPropertyName = "NMRGIM_IMG"
        Me.NMRGIM_IMG_B.HeaderText = "Doc Adjunto"
        Me.NMRGIM_IMG_B.Name = "NMRGIM_IMG_B"
        Me.NMRGIM_IMG_B.ReadOnly = True
        Me.NMRGIM_IMG_B.Width = 126
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdjuntoBulto})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1299, 27)
        Me.ToolStrip1.TabIndex = 77
        '
        'btnAdjuntoBulto
        '
        Me.btnAdjuntoBulto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdjuntoBulto.Image = Global.SOLMIN_SA.My.Resources.Resources.images__2_
        Me.btnAdjuntoBulto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdjuntoBulto.Name = "btnAdjuntoBulto"
        Me.btnAdjuntoBulto.Size = New System.Drawing.Size(90, 24)
        Me.btnAdjuntoBulto.Text = "Adjuntar"
        '
        'frmPaletizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 577)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tsReporte)
        Me.Controls.Add(Me.KryptonHeaderGroup2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPaletizado"
        Me.Text = "Paletizado"
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvPaletizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kdgvBultos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblBulto As ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Friend WithEvents txtClient As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents txtPaletizado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvPaletizado As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
    Friend WithEvents btnAdjuntar As System.Windows.Forms.ToolStripButton
    Friend WithEvents kdgvBultos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdjuntoBulto As System.Windows.Forms.ToolStripButton
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROPLT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRPLTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FELPLT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSEQIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANT_BULTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_IMG_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_BULTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_UNIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CANT_BULTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_B As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_IMG_B As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
