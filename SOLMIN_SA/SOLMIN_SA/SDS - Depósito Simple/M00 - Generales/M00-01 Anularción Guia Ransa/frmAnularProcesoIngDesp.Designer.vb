<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnularProcesoIngDesp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnularProcesoIngDesp))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dtgGuiasRansa = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.GS_FASGTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_DTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NBRVCH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_STPMOV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.tsbRevertir = New System.Windows.Forms.ToolStripButton
        Me.btnAnularItems = New System.Windows.Forms.ToolStripButton
        Me.tss02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAnular = New System.Windows.Forms.ToolStripButton
        Me.tss01 = New System.Windows.Forms.ToolStripSeparator
        Me.dtgMovimientos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNNORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNSLCSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDESMER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQTRMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCUNCN6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQTRMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCUNPS6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNORCCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroOS = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.txtNroGuiaRANSA = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroGuiaRansa = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dtgGuiasRansa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspListadoMercaderia.SuspendLayout()
        CType(Me.dtgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(974, 566)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 110)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dtgGuiasRansa)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.tspListadoMercaderia)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dtgMovimientos)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(974, 456)
        Me.KryptonSplitContainer1.SplitterDistance = 228
        Me.KryptonSplitContainer1.TabIndex = 61
        '
        'dtgGuiasRansa
        '
        Me.dtgGuiasRansa.AllowUserToAddRows = False
        Me.dtgGuiasRansa.AllowUserToDeleteRows = False
        Me.dtgGuiasRansa.AllowUserToResizeColumns = False
        Me.dtgGuiasRansa.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dtgGuiasRansa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgGuiasRansa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgGuiasRansa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GS_FASGTR, Me.GS_NGUIRN, Me.GS_CTPOAT, Me.GS_DTPOAT, Me.GS_NPLCCM, Me.GS_NBRVCH, Me.GS_STPMOV, Me.GS_CTPALM, Me.GS_SESTRG, Me.GS_SITUAC})
        Me.dtgGuiasRansa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgGuiasRansa.Location = New System.Drawing.Point(0, 25)
        Me.dtgGuiasRansa.MultiSelect = False
        Me.dtgGuiasRansa.Name = "dtgGuiasRansa"
        Me.dtgGuiasRansa.ReadOnly = True
        Me.dtgGuiasRansa.RowHeadersWidth = 20
        Me.dtgGuiasRansa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgGuiasRansa.Size = New System.Drawing.Size(974, 203)
        Me.dtgGuiasRansa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgGuiasRansa.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgGuiasRansa.TabIndex = 18
        '
        'GS_FASGTR
        '
        Me.GS_FASGTR.DataPropertyName = "FechaAsignacion"
        Me.GS_FASGTR.HeaderText = "Fecha"
        Me.GS_FASGTR.Name = "GS_FASGTR"
        Me.GS_FASGTR.ReadOnly = True
        Me.GS_FASGTR.Width = 67
        '
        'GS_NGUIRN
        '
        Me.GS_NGUIRN.DataPropertyName = "PNNGUIRN"
        Me.GS_NGUIRN.HeaderText = "Nro. Guía Ransa"
        Me.GS_NGUIRN.Name = "GS_NGUIRN"
        Me.GS_NGUIRN.ReadOnly = True
        Me.GS_NGUIRN.Width = 120
        '
        'GS_CTPOAT
        '
        Me.GS_CTPOAT.DataPropertyName = "PSCTPOAT"
        Me.GS_CTPOAT.HeaderText = "Proceso"
        Me.GS_CTPOAT.Name = "GS_CTPOAT"
        Me.GS_CTPOAT.ReadOnly = True
        Me.GS_CTPOAT.Visible = False
        Me.GS_CTPOAT.Width = 78
        '
        'GS_DTPOAT
        '
        Me.GS_DTPOAT.DataPropertyName = "PSDTPOAT"
        Me.GS_DTPOAT.HeaderText = "Proceso"
        Me.GS_DTPOAT.Name = "GS_DTPOAT"
        Me.GS_DTPOAT.ReadOnly = True
        Me.GS_DTPOAT.Width = 78
        '
        'GS_NPLCCM
        '
        Me.GS_NPLCCM.DataPropertyName = "PSNPLCCM"
        Me.GS_NPLCCM.HeaderText = "Unidad"
        Me.GS_NPLCCM.Name = "GS_NPLCCM"
        Me.GS_NPLCCM.ReadOnly = True
        Me.GS_NPLCCM.Visible = False
        Me.GS_NPLCCM.Width = 74
        '
        'GS_NBRVCH
        '
        Me.GS_NBRVCH.DataPropertyName = "PSNBRVCH"
        Me.GS_NBRVCH.HeaderText = "Brevete"
        Me.GS_NBRVCH.Name = "GS_NBRVCH"
        Me.GS_NBRVCH.ReadOnly = True
        Me.GS_NBRVCH.Visible = False
        Me.GS_NBRVCH.Width = 75
        '
        'GS_STPMOV
        '
        Me.GS_STPMOV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GS_STPMOV.DataPropertyName = "PSSTPMOV"
        Me.GS_STPMOV.HeaderText = "Movimiento"
        Me.GS_STPMOV.Name = "GS_STPMOV"
        Me.GS_STPMOV.ReadOnly = True
        '
        'GS_CTPALM
        '
        Me.GS_CTPALM.DataPropertyName = "PSCTPALM"
        Me.GS_CTPALM.HeaderText = "Tipo Almacén"
        Me.GS_CTPALM.Name = "GS_CTPALM"
        Me.GS_CTPALM.ReadOnly = True
        Me.GS_CTPALM.Width = 110
        '
        'GS_SESTRG
        '
        Me.GS_SESTRG.DataPropertyName = "PSSESTRG"
        Me.GS_SESTRG.HeaderText = "Código Situación"
        Me.GS_SESTRG.Name = "GS_SESTRG"
        Me.GS_SESTRG.ReadOnly = True
        Me.GS_SESTRG.Visible = False
        Me.GS_SESTRG.Width = 127
        '
        'GS_SITUAC
        '
        Me.GS_SITUAC.DataPropertyName = "PSSITUAC"
        Me.GS_SITUAC.HeaderText = "Situación"
        Me.GS_SITUAC.Name = "GS_SITUAC"
        Me.GS_SITUAC.ReadOnly = True
        Me.GS_SITUAC.Width = 85
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTitulo, Me.tsbRevertir, Me.btnAnularItems, Me.tss02, Me.btnAnular, Me.tss01})
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(974, 25)
        Me.tspListadoMercaderia.TabIndex = 61
        Me.tspListadoMercaderia.Text = "Anular Items"
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Image = CType(resources.GetObject("lblTitulo.Image"), System.Drawing.Image)
        Me.lblTitulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(120, 22)
        Me.lblTitulo.Text = "Listado de Guías"
        '
        'tsbRevertir
        '
        Me.tsbRevertir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbRevertir.Image = Global.SOLMIN_SA.My.Resources.Resources.Revertir
        Me.tsbRevertir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRevertir.Name = "tsbRevertir"
        Me.tsbRevertir.Size = New System.Drawing.Size(67, 22)
        Me.tsbRevertir.Text = "Revertir"
        '
        'btnAnularItems
        '
        Me.btnAnularItems.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAnularItems.Image = Global.SOLMIN_SA.My.Resources.Resources.AnularItem
        Me.btnAnularItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnularItems.Name = "btnAnularItems"
        Me.btnAnularItems.Size = New System.Drawing.Size(94, 22)
        Me.btnAnularItems.Text = "Anular Items"
        Me.btnAnularItems.Visible = False
        '
        'tss02
        '
        Me.tss02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss02.Name = "tss02"
        Me.tss02.Size = New System.Drawing.Size(6, 25)
        '
        'btnAnular
        '
        Me.btnAnular.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAnular.Image = Global.SOLMIN_SA.My.Resources.Resources.AnularItem
        Me.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(62, 22)
        Me.btnAnular.Text = "Anular"
        '
        'tss01
        '
        Me.tss01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss01.Name = "tss01"
        Me.tss01.Size = New System.Drawing.Size(6, 25)
        '
        'dtgMovimientos
        '
        Me.dtgMovimientos.AllowUserToAddRows = False
        Me.dtgMovimientos.AllowUserToDeleteRows = False
        Me.dtgMovimientos.AllowUserToResizeColumns = False
        Me.dtgMovimientos.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        Me.dtgMovimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNNORDSR, Me.PNNSLCSR, Me.CMRCLR, Me.PSDESMER, Me.PNQTRMC, Me.PSCUNCN6, Me.PNQTRMP, Me.PSCUNPS6, Me.PSNORCCL, Me.PNNRITOC})
        Me.dtgMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgMovimientos.Location = New System.Drawing.Point(0, 25)
        Me.dtgMovimientos.MultiSelect = False
        Me.dtgMovimientos.Name = "dtgMovimientos"
        Me.dtgMovimientos.RowHeadersWidth = 20
        Me.dtgMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgMovimientos.Size = New System.Drawing.Size(974, 198)
        Me.dtgMovimientos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgMovimientos.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgMovimientos.TabIndex = 62
        '
        'PNNORDSR
        '
        Me.PNNORDSR.DataPropertyName = "PNNORDSR"
        Me.PNNORDSR.HeaderText = "Orden de Servicio"
        Me.PNNORDSR.Name = "PNNORDSR"
        Me.PNNORDSR.Width = 129
        '
        'PNNSLCSR
        '
        Me.PNNSLCSR.DataPropertyName = "PNNSLCSR"
        Me.PNNSLCSR.HeaderText = "Nr. Solicitud Servicio"
        Me.PNNSLCSR.Name = "PNNSLCSR"
        Me.PNNSLCSR.Width = 145
        '
        'CMRCLR
        '
        Me.CMRCLR.DataPropertyName = "PSCMRCLR"
        Me.CMRCLR.HeaderText = "Cod. Mercadería"
        Me.CMRCLR.Name = "CMRCLR"
        Me.CMRCLR.Width = 123
        '
        'PSDESMER
        '
        Me.PSDESMER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSDESMER.DataPropertyName = "PSDESMER"
        Me.PSDESMER.HeaderText = "Mercadería"
        Me.PSDESMER.Name = "PSDESMER"
        '
        'PNQTRMC
        '
        Me.PNQTRMC.DataPropertyName = "PNQTRMC"
        Me.PNQTRMC.HeaderText = "Cantidad"
        Me.PNQTRMC.Name = "PNQTRMC"
        Me.PNQTRMC.Width = 84
        '
        'PSCUNCN6
        '
        Me.PSCUNCN6.DataPropertyName = "PSCUNCN6"
        Me.PSCUNCN6.HeaderText = "Unidad"
        Me.PSCUNCN6.Name = "PSCUNCN6"
        Me.PSCUNCN6.Width = 74
        '
        'PNQTRMP
        '
        Me.PNQTRMP.DataPropertyName = "PNQTRMP"
        Me.PNQTRMP.HeaderText = "Peso"
        Me.PNQTRMP.Name = "PNQTRMP"
        Me.PNQTRMP.Width = 61
        '
        'PSCUNPS6
        '
        Me.PSCUNPS6.DataPropertyName = "PSCUNPS6"
        Me.PSCUNPS6.HeaderText = "Unidad"
        Me.PSCUNPS6.Name = "PSCUNPS6"
        Me.PSCUNPS6.Width = 74
        '
        'PSNORCCL
        '
        Me.PSNORCCL.DataPropertyName = "PSNORCCL"
        Me.PSNORCCL.HeaderText = "Orden de Compra"
        Me.PSNORCCL.Name = "PSNORCCL"
        Me.PSNORCCL.Width = 131
        '
        'PNNRITOC
        '
        Me.PNNRITOC.DataPropertyName = "PNNRITOC"
        Me.PNNRITOC.HeaderText = "Nr. Item"
        Me.PNNRITOC.Name = "PNNRITOC"
        Me.PNNRITOC.Width = 79
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(974, 25)
        Me.ToolStrip1.TabIndex = 61
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripLabel1.Text = "Detalle"
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroOS)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroGuiaRANSA)
        Me.khgFiltros.Panel.Controls.Add(Me.lblNroGuiaRansa)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Size = New System.Drawing.Size(974, 110)
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
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(464, 17)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(67, 20)
        Me.KryptonLabel6.TabIndex = 25
        Me.KryptonLabel6.Text = "Fecha De :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Fecha De :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(635, 17)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(25, 20)
        Me.KryptonLabel5.TabIndex = 26
        Me.KryptonLabel5.Text = "A :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "A :"
        '
        'txtNroOS
        '
        Me.txtNroOS.Location = New System.Drawing.Point(299, 44)
        Me.txtNroOS.Name = "txtNroOS"
        Me.txtNroOS.Size = New System.Drawing.Size(130, 22)
        Me.txtNroOS.TabIndex = 24
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(234, 44)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(59, 20)
        Me.KryptonLabel2.TabIndex = 23
        Me.KryptonLabel2.Text = "Nro. OS : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nro. OS : "
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(663, 17)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(101, 20)
        Me.dtpFechaFinal.TabIndex = 21
        Me.dtpFechaFinal.Value = New Date(2008, 12, 18, 0, 0, 0, 0)
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(535, 17)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaInicial.TabIndex = 19
        Me.dtpFechaInicial.Value = New Date(2008, 12, 18, 0, 0, 0, 0)
        '
        'txtNroGuiaRANSA
        '
        Me.txtNroGuiaRANSA.Location = New System.Drawing.Point(98, 44)
        Me.txtNroGuiaRANSA.Name = "txtNroGuiaRANSA"
        Me.txtNroGuiaRANSA.Size = New System.Drawing.Size(130, 22)
        Me.txtNroGuiaRANSA.TabIndex = 17
        '
        'lblNroGuiaRansa
        '
        Me.lblNroGuiaRansa.Location = New System.Drawing.Point(1, 46)
        Me.lblNroGuiaRansa.Name = "lblNroGuiaRansa"
        Me.lblNroGuiaRansa.Size = New System.Drawing.Size(104, 20)
        Me.lblNroGuiaRansa.TabIndex = 16
        Me.lblNroGuiaRansa.Text = "Nro. Guía Ransa : "
        Me.lblNroGuiaRansa.Values.ExtraText = ""
        Me.lblNroGuiaRansa.Values.Image = Nothing
        Me.lblNroGuiaRansa.Values.Text = "Nro. Guía Ransa : "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(98, 16)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(331, 22)
        Me.txtCliente.TabIndex = 2
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(893, 5)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 63)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(47, 13)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'frmAnularProcesoIngDesp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 566)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmAnularProcesoIngDesp"
        Me.Text = "Anulacion de Ing. - Desp."
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dtgGuiasRansa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspListadoMercaderia.ResumeLayout(False)
        Me.tspListadoMercaderia.PerformLayout()
        CType(Me.dtgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNroGuiaRANSA As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuiaRansa As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgGuiasRansa As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tss02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAnularItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtgMovimientos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtNroOS As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PNNORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNSLCSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESMER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQTRMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCUNCN6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQTRMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCUNPS6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNORCCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_FASGTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_DTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NBRVCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_STPMOV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsbRevertir As System.Windows.Forms.ToolStripButton
End Class
