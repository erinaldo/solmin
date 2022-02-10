<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoPorProyecto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientoPorProyecto))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgConsulta = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.norcml = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tprvcl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nritoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORAGN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tdites = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.norsci = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPVP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UNIMED = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGRPRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nguirm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLACP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tdsdes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMBCH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.origen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FEMVLH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCHFTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.destino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBORM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip
        Me.tssExportarExcel = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.gbFechas = New System.Windows.Forms.GroupBox
        Me.rbtIngreso = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtDespacho = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.txtNrItem = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNrItem = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOc = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOrdenDeCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnGenerarReporte = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblt2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspListadoMercaderia.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.gbFechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgConsulta)
        Me.KryptonPanel.Controls.Add(Me.pcxEspera)
        Me.KryptonPanel.Controls.Add(Me.tspListadoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(984, 650)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgConsulta
        '
        Me.dgConsulta.AllowUserToAddRows = False
        Me.dgConsulta.AllowUserToDeleteRows = False
        Me.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.norcml, Me.tprvcl, Me.nritoc, Me.NORAGN, Me.tdites, Me.norsci, Me.Mode, Me.TCMPVP, Me.Qty, Me.UNIMED, Me.PESO, Me.NGRPRV, Me.nguirm, Me.NPLCCM, Me.NPLACP, Me.tdsdes, Me.TNMBCH, Me.origen, Me.FEMVLH, Me.FCHFTR, Me.destino, Me.TOBORM})
        Me.dgConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgConsulta.Location = New System.Drawing.Point(0, 201)
        Me.dgConsulta.MultiSelect = False
        Me.dgConsulta.Name = "dgConsulta"
        Me.dgConsulta.ReadOnly = True
        Me.dgConsulta.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgConsulta.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConsulta.Size = New System.Drawing.Size(984, 449)
        Me.dgConsulta.StandardTab = True
        Me.dgConsulta.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgConsulta.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgConsulta.TabIndex = 81
        '
        'norcml
        '
        Me.norcml.DataPropertyName = "norcml"
        Me.norcml.HeaderText = "P.O. #"
        Me.norcml.Name = "norcml"
        Me.norcml.ReadOnly = True
        Me.norcml.Width = 63
        '
        'tprvcl
        '
        Me.tprvcl.DataPropertyName = "tprvcl"
        Me.tprvcl.HeaderText = "Vendor"
        Me.tprvcl.Name = "tprvcl"
        Me.tprvcl.ReadOnly = True
        Me.tprvcl.Width = 70
        '
        'nritoc
        '
        Me.nritoc.DataPropertyName = "nritoc"
        Me.nritoc.HeaderText = "P.O. Line Item"
        Me.nritoc.Name = "nritoc"
        Me.nritoc.ReadOnly = True
        Me.nritoc.Width = 77
        '
        'NORAGN
        '
        Me.NORAGN.DataPropertyName = "NORAGN"
        Me.NORAGN.HeaderText = "Ransa Ref #"
        Me.NORAGN.Name = "NORAGN"
        Me.NORAGN.ReadOnly = True
        Me.NORAGN.Width = 83
        '
        'tdites
        '
        Me.tdites.DataPropertyName = "tdites"
        Me.tdites.HeaderText = "Description (Brief)"
        Me.tdites.Name = "tdites"
        Me.tdites.ReadOnly = True
        Me.tdites.Width = 110
        '
        'norsci
        '
        Me.norsci.DataPropertyName = "norsci"
        Me.norsci.HeaderText = "norsci"
        Me.norsci.Name = "norsci"
        Me.norsci.ReadOnly = True
        Me.norsci.Visible = False
        Me.norsci.Width = 67
        '
        'Mode
        '
        Me.Mode.DataPropertyName = "Mode"
        Me.Mode.HeaderText = "Mode"
        Me.Mode.Name = "Mode"
        Me.Mode.ReadOnly = True
        Me.Mode.Width = 63
        '
        'TCMPVP
        '
        Me.TCMPVP.DataPropertyName = "TCMPVP"
        Me.TCMPVP.HeaderText = "Vessel"
        Me.TCMPVP.Name = "TCMPVP"
        Me.TCMPVP.ReadOnly = True
        Me.TCMPVP.Width = 67
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Width = 52
        '
        'UNIMED
        '
        Me.UNIMED.DataPropertyName = "UNIMED"
        Me.UNIMED.HeaderText = "Package"
        Me.UNIMED.Name = "UNIMED"
        Me.UNIMED.ReadOnly = True
        Me.UNIMED.Width = 79
        '
        'PESO
        '
        Me.PESO.DataPropertyName = "PESO"
        Me.PESO.HeaderText = "Weight (kgs)"
        Me.PESO.Name = "PESO"
        Me.PESO.ReadOnly = True
        Me.PESO.Width = 89
        '
        'NGRPRV
        '
        Me.NGRPRV.DataPropertyName = "NGRPRV"
        Me.NGRPRV.HeaderText = "Vendor AWB /Note Dispatch # or / Ransa Agencias"
        Me.NGRPRV.Name = "NGRPRV"
        Me.NGRPRV.ReadOnly = True
        Me.NGRPRV.Width = 133
        '
        'nguirm
        '
        Me.nguirm.DataPropertyName = "nguirm"
        Me.nguirm.HeaderText = "Note Dispatch AWB Yanacocha"
        Me.nguirm.Name = "nguirm"
        Me.nguirm.ReadOnly = True
        Me.nguirm.Width = 110
        '
        'NPLCCM
        '
        Me.NPLCCM.DataPropertyName = "NPLCCM"
        Me.NPLCCM.HeaderText = "Plate"
        Me.NPLCCM.Name = "NPLCCM"
        Me.NPLCCM.ReadOnly = True
        Me.NPLCCM.Width = 60
        '
        'NPLACP
        '
        Me.NPLACP.DataPropertyName = "NPLACP"
        Me.NPLACP.HeaderText = "Bed Plate"
        Me.NPLACP.Name = "NPLACP"
        Me.NPLACP.ReadOnly = True
        Me.NPLACP.Width = 76
        '
        'tdsdes
        '
        Me.tdsdes.DataPropertyName = "tdsdes"
        Me.tdsdes.HeaderText = "Type Vehicle"
        Me.tdsdes.Name = "tdsdes"
        Me.tdsdes.ReadOnly = True
        Me.tdsdes.Width = 91
        '
        'TNMBCH
        '
        Me.TNMBCH.DataPropertyName = "TNMBCH"
        Me.TNMBCH.HeaderText = "Driver"
        Me.TNMBCH.Name = "TNMBCH"
        Me.TNMBCH.ReadOnly = True
        Me.TNMBCH.Width = 64
        '
        'origen
        '
        Me.origen.DataPropertyName = "origen"
        Me.origen.HeaderText = "Origin Location"
        Me.origen.Name = "origen"
        Me.origen.ReadOnly = True
        Me.origen.Width = 99
        '
        'FEMVLH
        '
        Me.FEMVLH.DataPropertyName = "FEMVLH"
        Me.FEMVLH.HeaderText = "Departure Date"
        Me.FEMVLH.Name = "FEMVLH"
        Me.FEMVLH.ReadOnly = True
        Me.FEMVLH.Width = 101
        '
        'FCHFTR
        '
        Me.FCHFTR.DataPropertyName = "FCHFTR"
        Me.FCHFTR.HeaderText = "Arrival Date Site"
        Me.FCHFTR.Name = "FCHFTR"
        Me.FCHFTR.ReadOnly = True
        Me.FCHFTR.Width = 74
        '
        'destino
        '
        Me.destino.DataPropertyName = "destino"
        Me.destino.HeaderText = "Final  Destination"
        Me.destino.Name = "destino"
        Me.destino.ReadOnly = True
        Me.destino.Width = 108
        '
        'TOBORM
        '
        Me.TOBORM.DataPropertyName = "TOBORM"
        Me.TOBORM.HeaderText = "Remarks"
        Me.TOBORM.Name = "TOBORM"
        Me.TOBORM.ReadOnly = True
        Me.TOBORM.Width = 78
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(506, 368)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 82
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssExportarExcel, Me.btnExportarExcel})
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 176)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(984, 25)
        Me.tspListadoMercaderia.TabIndex = 80
        Me.tspListadoMercaderia.Text = "ToolStrip1"
        '
        'tssExportarExcel
        '
        Me.tssExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssExportarExcel.Name = "tssExportarExcel"
        Me.tssExportarExcel.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(95, 22)
        Me.btnExportarExcel.Text = "Exportar Excel"
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaFin)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.khgFiltros.Panel.Controls.Add(Me.gbFechas)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNrItem)
        Me.khgFiltros.Panel.Controls.Add(Me.lblNrItem)
        Me.khgFiltros.Panel.Controls.Add(Me.lblOc)
        Me.khgFiltros.Panel.Controls.Add(Me.txtOrdenDeCompra)
        Me.khgFiltros.Panel.Controls.Add(Me.btnGenerarReporte)
        Me.khgFiltros.Panel.Controls.Add(Me.lblPlanta)
        Me.khgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.lblDivision)
        Me.khgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCompania)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.lblt2)
        Me.khgFiltros.Panel.Controls.Add(Me.lbl1)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(984, 176)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 3
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaOcultarFiltros
        '
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.ToolTipImage = Nothing
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(869, 52)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.ShowCheckBox = True
        Me.dtpFechaFin.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaFin.TabIndex = 153
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(722, 52)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.ShowCheckBox = True
        Me.dtpFechaInicio.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaInicio.TabIndex = 152
        '
        'gbFechas
        '
        Me.gbFechas.BackColor = System.Drawing.Color.Transparent
        Me.gbFechas.Controls.Add(Me.rbtIngreso)
        Me.gbFechas.Controls.Add(Me.rbtDespacho)
        Me.gbFechas.Location = New System.Drawing.Point(447, 36)
        Me.gbFechas.Name = "gbFechas"
        Me.gbFechas.Size = New System.Drawing.Size(226, 41)
        Me.gbFechas.TabIndex = 151
        Me.gbFechas.TabStop = False
        Me.gbFechas.Text = "Busqueda por"
        '
        'rbtIngreso
        '
        Me.rbtIngreso.Location = New System.Drawing.Point(18, 16)
        Me.rbtIngreso.Name = "rbtIngreso"
        Me.rbtIngreso.Size = New System.Drawing.Size(94, 16)
        Me.rbtIngreso.TabIndex = 0
        Me.rbtIngreso.Text = "Fecha Ingreso"
        Me.rbtIngreso.Values.ExtraText = ""
        Me.rbtIngreso.Values.Image = Nothing
        Me.rbtIngreso.Values.Text = "Fecha Ingreso"
        '
        'rbtDespacho
        '
        Me.rbtDespacho.Checked = True
        Me.rbtDespacho.Location = New System.Drawing.Point(120, 15)
        Me.rbtDespacho.Name = "rbtDespacho"
        Me.rbtDespacho.Size = New System.Drawing.Size(108, 16)
        Me.rbtDespacho.TabIndex = 1
        Me.rbtDespacho.Text = "Fecha Despacho"
        Me.rbtDespacho.Values.ExtraText = ""
        Me.rbtDespacho.Values.Image = Nothing
        Me.rbtDespacho.Values.Text = "Fecha Despacho"
        '
        'txtNrItem
        '
        Me.txtNrItem.Location = New System.Drawing.Point(291, 81)
        Me.txtNrItem.MaxLength = 6
        Me.txtNrItem.Name = "txtNrItem"
        Me.txtNrItem.Size = New System.Drawing.Size(75, 19)
        Me.txtNrItem.TabIndex = 7
        Me.TypeValidator.SetTypes(Me.txtNrItem, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblNrItem
        '
        Me.lblNrItem.Location = New System.Drawing.Point(218, 81)
        Me.lblNrItem.Name = "lblNrItem"
        Me.lblNrItem.Size = New System.Drawing.Size(59, 16)
        Me.lblNrItem.TabIndex = 148
        Me.lblNrItem.Text = "Nr.  Item :"
        Me.lblNrItem.Values.ExtraText = ""
        Me.lblNrItem.Values.Image = Nothing
        Me.lblNrItem.Values.Text = "Nr.  Item :"
        '
        'lblOc
        '
        Me.lblOc.Location = New System.Drawing.Point(2, 83)
        Me.lblOc.Name = "lblOc"
        Me.lblOc.Size = New System.Drawing.Size(107, 16)
        Me.lblOc.TabIndex = 147
        Me.lblOc.Text = "Orden de Compra :"
        Me.lblOc.Values.ExtraText = ""
        Me.lblOc.Values.Image = Nothing
        Me.lblOc.Values.Text = "Orden de Compra :"
        '
        'txtOrdenDeCompra
        '
        Me.txtOrdenDeCompra.Location = New System.Drawing.Point(112, 81)
        Me.txtOrdenDeCompra.MaxLength = 35
        Me.txtOrdenDeCompra.Name = "txtOrdenDeCompra"
        Me.txtOrdenDeCompra.Size = New System.Drawing.Size(100, 19)
        Me.txtOrdenDeCompra.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtOrdenDeCompra, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarReporte.Location = New System.Drawing.Point(846, 93)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(125, 40)
        Me.btnGenerarReporte.TabIndex = 8
        Me.btnGenerarReporte.Text = " &Generar Reporte "
        Me.btnGenerarReporte.Values.ExtraText = ""
        Me.btnGenerarReporte.Values.Image = CType(resources.GetObject("btnGenerarReporte.Values.Image"), System.Drawing.Image)
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGenerarReporte.Values.Text = " &Generar Reporte "
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(677, 18)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(49, 16)
        Me.lblPlanta.TabIndex = 144
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
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(730, 14)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(244, 23)
        Me.UcPLanta_Cmb011.TabIndex = 2
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(386, 18)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(56, 16)
        Me.lblDivision.TabIndex = 143
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(452, 14)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(219, 23)
        Me.UcDivision_Cmb011.TabIndex = 1
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(42, 18)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(68, 16)
        Me.lblCompania.TabIndex = 142
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
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(112, 14)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(254, 23)
        Me.UcCompania_Cmb011.TabIndex = 0
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(90, -136)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(77, 16)
        Me.KryptonLabel2.TabIndex = 95
        Me.KryptonLabel2.Text = "Fecha Inicio :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha Inicio :"
        '
        'lblt2
        '
        Me.lblt2.Location = New System.Drawing.Point(830, 53)
        Me.lblt2.Name = "lblt2"
        Me.lblt2.Size = New System.Drawing.Size(38, 16)
        Me.lblt2.TabIndex = 86
        Me.lblt2.Text = "hasta"
        Me.lblt2.Values.ExtraText = ""
        Me.lblt2.Values.Image = Nothing
        Me.lblt2.Values.Text = "hasta"
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(691, 53)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(31, 16)
        Me.lbl1.TabIndex = 85
        Me.lbl1.Text = "De :"
        Me.lbl1.Values.ExtraText = ""
        Me.lbl1.Values.Image = Nothing
        Me.lbl1.Values.Text = "De :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(401, 145)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(6, 2)
        Me.KryptonLabel1.TabIndex = 74
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = ""
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(112, 51)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(254, 19)
        Me.txtCliente.TabIndex = 3
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(58, 55)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(52, 16)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Cliente : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente : "
        '
        'bgwGifAnimado
        '
        '
        'frmMovimientoPorProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 650)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmMovimientoPorProyecto"
        Me.Text = "Movimientos por proyecto(CONGA)"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspListadoMercaderia.ResumeLayout(False)
        Me.tspListadoMercaderia.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        Me.gbFechas.ResumeLayout(False)
        Me.gbFechas.PerformLayout()
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
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblt2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lbl1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents rbtIngreso As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtDespacho As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents dgConsulta As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents tssExportarExcel As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As RANSA.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Private WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As RANSA.Controls.UbicacionPlanta.ucDivision_Cmb01
    Private WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As RANSA.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents btnGenerarReporte As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNrItem As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNrItem As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOc As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOrdenDeCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents gbFechas As System.Windows.Forms.GroupBox
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents norcml As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tprvcl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nritoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORAGN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tdites As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents norsci As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPVP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIMED As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGRPRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nguirm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tdsdes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMBCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FEMVLH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCHFTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBORM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
End Class
