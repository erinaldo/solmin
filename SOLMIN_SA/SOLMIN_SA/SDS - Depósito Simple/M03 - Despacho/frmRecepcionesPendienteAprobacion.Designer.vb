<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionesPendienteAprobacion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecepcionesPendienteAprobacion))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dtgGuiasRansa = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.GS_FASGTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_DTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NBRVCH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_STPING = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.btnImportarPedido = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.dtgDetalleGuiaRansa = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRFRPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNRCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Actualizar = New System.Windows.Forms.DataGridViewImageColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroGuiaRANSA = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroGuiaRansa = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New RANSA.Controls.Cliente.ucCliente_TxtF01
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
        CType(Me.dtgDetalleGuiaRansa, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonPanel.Size = New System.Drawing.Size(846, 566)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 106)
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
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dtgDetalleGuiaRansa)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(846, 460)
        Me.KryptonSplitContainer1.SplitterDistance = 233
        Me.KryptonSplitContainer1.TabIndex = 61
        '
        'dtgGuiasRansa
        '
        Me.dtgGuiasRansa.AllowUserToAddRows = False
        Me.dtgGuiasRansa.AllowUserToDeleteRows = False
        Me.dtgGuiasRansa.AllowUserToResizeColumns = False
        Me.dtgGuiasRansa.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon
        Me.dtgGuiasRansa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgGuiasRansa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgGuiasRansa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GS_FASGTR, Me.GS_NGUIRN, Me.GS_CTPOAT, Me.GS_DTPOAT, Me.GS_CTPALM, Me.GS_CALMC, Me.GS_NPLCCM, Me.GS_NBRVCH, Me.GS_STPING, Me.GS_SESTRG, Me.GS_SITUAC})
        Me.dtgGuiasRansa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgGuiasRansa.Location = New System.Drawing.Point(0, 25)
        Me.dtgGuiasRansa.MultiSelect = False
        Me.dtgGuiasRansa.Name = "dtgGuiasRansa"
        Me.dtgGuiasRansa.ReadOnly = True
        Me.dtgGuiasRansa.RowHeadersWidth = 20
        Me.dtgGuiasRansa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgGuiasRansa.Size = New System.Drawing.Size(846, 208)
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
        Me.GS_FASGTR.Width = 66
        '
        'GS_NGUIRN
        '
        Me.GS_NGUIRN.DataPropertyName = "PNNGUIRN"
        Me.GS_NGUIRN.HeaderText = "Nro. Guía Ransa"
        Me.GS_NGUIRN.Name = "GS_NGUIRN"
        Me.GS_NGUIRN.ReadOnly = True
        Me.GS_NGUIRN.Width = 119
        '
        'GS_CTPOAT
        '
        Me.GS_CTPOAT.DataPropertyName = "PSCTPOAT"
        Me.GS_CTPOAT.HeaderText = "Proceso"
        Me.GS_CTPOAT.Name = "GS_CTPOAT"
        Me.GS_CTPOAT.ReadOnly = True
        Me.GS_CTPOAT.Visible = False
        Me.GS_CTPOAT.Width = 76
        '
        'GS_DTPOAT
        '
        Me.GS_DTPOAT.DataPropertyName = "PSDTPOAT"
        Me.GS_DTPOAT.HeaderText = "Proceso"
        Me.GS_DTPOAT.Name = "GS_DTPOAT"
        Me.GS_DTPOAT.ReadOnly = True
        Me.GS_DTPOAT.Width = 76
        '
        'GS_CTPALM
        '
        Me.GS_CTPALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GS_CTPALM.DataPropertyName = "PSCTPALM"
        Me.GS_CTPALM.HeaderText = "Tipo Almacén"
        Me.GS_CTPALM.Name = "GS_CTPALM"
        Me.GS_CTPALM.ReadOnly = True
        '
        'GS_CALMC
        '
        Me.GS_CALMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GS_CALMC.DataPropertyName = "PSCALMC"
        Me.GS_CALMC.HeaderText = "Almacén"
        Me.GS_CALMC.Name = "GS_CALMC"
        Me.GS_CALMC.ReadOnly = True
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
        Me.GS_NBRVCH.Width = 74
        '
        'GS_STPING
        '
        Me.GS_STPING.DataPropertyName = "PSSTPING"
        Me.GS_STPING.HeaderText = "Movimiento"
        Me.GS_STPING.Name = "GS_STPING"
        Me.GS_STPING.ReadOnly = True
        Me.GS_STPING.Width = 97
        '
        'GS_SESTRG
        '
        Me.GS_SESTRG.DataPropertyName = "PSSESTRG"
        Me.GS_SESTRG.HeaderText = "Código Situación"
        Me.GS_SESTRG.Name = "GS_SESTRG"
        Me.GS_SESTRG.ReadOnly = True
        Me.GS_SESTRG.Visible = False
        Me.GS_SESTRG.Width = 125
        '
        'GS_SITUAC
        '
        Me.GS_SITUAC.DataPropertyName = "PSSITUAC"
        Me.GS_SITUAC.HeaderText = "Situación"
        Me.GS_SITUAC.Name = "GS_SITUAC"
        Me.GS_SITUAC.ReadOnly = True
        Me.GS_SITUAC.Width = 84
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTitulo, Me.btnImportarPedido, Me.ToolStripSeparator2})
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(846, 25)
        Me.tspListadoMercaderia.TabIndex = 61
        Me.tspListadoMercaderia.Text = "ToolStrip1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Image = CType(resources.GetObject("lblTitulo.Image"), System.Drawing.Image)
        Me.lblTitulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(187, 22)
        Me.lblTitulo.Text = "Listado de Guías Pendientes"
        '
        'btnImportarPedido
        '
        Me.btnImportarPedido.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImportarPedido.Image = CType(resources.GetObject("btnImportarPedido.Image"), System.Drawing.Image)
        Me.btnImportarPedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImportarPedido.Name = "btnImportarPedido"
        Me.btnImportarPedido.Size = New System.Drawing.Size(110, 22)
        Me.btnImportarPedido.Text = "Importar Pedido"
        Me.btnImportarPedido.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator2.Visible = False
        '
        'dtgDetalleGuiaRansa
        '
        Me.dtgDetalleGuiaRansa.AllowUserToAddRows = False
        Me.dtgDetalleGuiaRansa.AllowUserToDeleteRows = False
        Me.dtgDetalleGuiaRansa.AllowUserToResizeColumns = False
        Me.dtgDetalleGuiaRansa.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon
        Me.dtgDetalleGuiaRansa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgDetalleGuiaRansa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgDetalleGuiaRansa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORCML, Me.NRITOC, Me.TDITES, Me.NRFRPD, Me.QCNTIT, Me.QCNRCP, Me.Actualizar})
        Me.dtgDetalleGuiaRansa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDetalleGuiaRansa.Location = New System.Drawing.Point(0, 25)
        Me.dtgDetalleGuiaRansa.MultiSelect = False
        Me.dtgDetalleGuiaRansa.Name = "dtgDetalleGuiaRansa"
        Me.dtgDetalleGuiaRansa.ReadOnly = True
        Me.dtgDetalleGuiaRansa.RowHeadersWidth = 20
        Me.dtgDetalleGuiaRansa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDetalleGuiaRansa.Size = New System.Drawing.Size(846, 197)
        Me.dtgDetalleGuiaRansa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgDetalleGuiaRansa.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgDetalleGuiaRansa.TabIndex = 18
        '
        'NORCML
        '
        Me.NORCML.HeaderText = "Orden de Compra"
        Me.NORCML.Name = "NORCML"
        Me.NORCML.ReadOnly = True
        Me.NORCML.Width = 128
        '
        'NRITOC
        '
        Me.NRITOC.HeaderText = "Nr. Item"
        Me.NRITOC.Name = "NRITOC"
        Me.NRITOC.ReadOnly = True
        Me.NRITOC.Width = 76
        '
        'TDITES
        '
        Me.TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TDITES.HeaderText = "Descripción"
        Me.TDITES.Name = "TDITES"
        Me.TDITES.ReadOnly = True
        '
        'NRFRPD
        '
        Me.NRFRPD.HeaderText = "Nr. Ref. Pedido"
        Me.NRFRPD.Name = "NRFRPD"
        Me.NRFRPD.ReadOnly = True
        Me.NRFRPD.Width = 113
        '
        'QCNTIT
        '
        Me.QCNTIT.HeaderText = "Cantidad Solicitada"
        Me.QCNTIT.Name = "QCNTIT"
        Me.QCNTIT.ReadOnly = True
        Me.QCNTIT.Width = 136
        '
        'QCNRCP
        '
        Me.QCNRCP.HeaderText = "Cant. Item Recepcionado"
        Me.QCNRCP.Name = "QCNRCP"
        Me.QCNRCP.ReadOnly = True
        Me.QCNRCP.Width = 164
        '
        'Actualizar
        '
        Me.Actualizar.HeaderText = "Actualizar"
        Me.Actualizar.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.ReadOnly = True
        Me.Actualizar.Width = 67
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(846, 25)
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton1.Text = "Guardar"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator3.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripButton2.Text = "Actualizar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroGuiaRANSA)
        Me.khgFiltros.Panel.Controls.Add(Me.lblNroGuiaRansa)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Size = New System.Drawing.Size(846, 106)
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
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(633, 15)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.ShowCheckBox = True
        Me.dtpFechaFinal.Size = New System.Drawing.Size(101, 20)
        Me.dtpFechaFinal.TabIndex = 21
        Me.dtpFechaFinal.Value = New Date(2008, 12, 18, 0, 0, 0, 0)
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(445, 16)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.ShowCheckBox = True
        Me.dtpFechaInicial.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaInicial.TabIndex = 19
        Me.dtpFechaInicial.Value = New Date(2008, 12, 18, 0, 0, 0, 0)
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(550, 18)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(71, 19)
        Me.lblFechaFinal.TabIndex = 20
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(369, 18)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(74, 19)
        Me.lblFechaInicial.TabIndex = 18
        Me.lblFechaInicial.Text = "Fecha Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inicio : "
        '
        'txtNroGuiaRANSA
        '
        Me.txtNroGuiaRANSA.Location = New System.Drawing.Point(97, 46)
        Me.txtNroGuiaRANSA.Name = "txtNroGuiaRANSA"
        Me.txtNroGuiaRANSA.Size = New System.Drawing.Size(130, 21)
        Me.txtNroGuiaRANSA.TabIndex = 17
        '
        'lblNroGuiaRansa
        '
        Me.lblNroGuiaRansa.Location = New System.Drawing.Point(1, 46)
        Me.lblNroGuiaRansa.Name = "lblNroGuiaRansa"
        Me.lblNroGuiaRansa.Size = New System.Drawing.Size(96, 19)
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
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(98, 19)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(265, 21)
        Me.txtCliente.TabIndex = 2
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(765, 2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 72)
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
        Me.KryptonLabel1.Location = New System.Drawing.Point(47, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'frmRecepcionesPendienteAprobacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 566)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmRecepcionesPendienteAprobacion"
        Me.Text = "Recepciones Pendiente  Aprobación"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
        CType(Me.dtgDetalleGuiaRansa, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroGuiaRANSA As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuiaRansa As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgGuiasRansa As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnImportarPedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtgDetalleGuiaRansa As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRFRPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Actualizar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GS_FASGTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_DTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NBRVCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_STPING As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
