<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionOcSDS
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecepcionOcSDS))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.scrContainer_001 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dgOrdenCompra = New Ransa.Controls.OrdenCompra.ucOrdenCompra_DgF01()
        Me.tbcDetalles = New System.Windows.Forms.TabControl()
        Me.tbpDetalle = New System.Windows.Forms.TabPage()
        Me.dgItemsOC = New Ransa.Controls.OrdenCompra.ucItemOC_DgF01()
        Me.tbpMovimiento_DS = New System.Windows.Forms.TabPage()
        Me.dgvMovimiento = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TABTRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPORI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUICL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOBSRV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOVIMIENTO_DETALLE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tbpMovimientosOC = New System.Windows.Forms.TabPage()
        Me.dgMovimientoItemOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NSEQIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_IMBULTO = New System.Windows.Forms.DataGridViewImageColumn()
        Me.M_CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.lblWaybill = New System.Windows.Forms.ToolStripLabel()
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.cmbPrioridad = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01()
        Me.lblPrioridad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.lblSituacionOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbSituacionOC = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01()
        Me.txtProveedor = New Ransa.Controls.Proveedor.ucProveedor_TxtF01()
        Me.cmbTermInter = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01()
        Me.btnCambiarCliente = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaDescripcionLimpiar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblTerminoInternacional = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.txtFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.lblOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaOrdenCompraLimpiar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dstMercaderia = New System.Data.DataSet()
        Me.dtMercaderia = New System.Data.DataTable()
        Me.MSTASEL = New System.Data.DataColumn()
        Me.MCFMCLR = New System.Data.DataColumn()
        Me.MCGRCLR = New System.Data.DataColumn()
        Me.MCMRCLR = New System.Data.DataColumn()
        Me.MTMRCD2 = New System.Data.DataColumn()
        Me.MCMRCD = New System.Data.DataColumn()
        Me.MSALDO = New System.Data.DataColumn()
        Me.MSESTRG = New System.Data.DataColumn()
        Me.MSITUAC = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.dtMercaderiaSeleccionadas = New System.Data.DataTable()
        Me.SCMRCLR = New System.Data.DataColumn()
        Me.STMRCD2 = New System.Data.DataColumn()
        Me.SCMRCD = New System.Data.DataColumn()
        Me.SNORDSR = New System.Data.DataColumn()
        Me.SNCNTR = New System.Data.DataColumn()
        Me.SNCRCTC = New System.Data.DataColumn()
        Me.SNAUTR = New System.Data.DataColumn()
        Me.SCUNCNT = New System.Data.DataColumn()
        Me.SCUNPST = New System.Data.DataColumn()
        Me.SCUNVLT = New System.Data.DataColumn()
        Me.SNORCCL = New System.Data.DataColumn()
        Me.SNGUICL = New System.Data.DataColumn()
        Me.SNRUCLL = New System.Data.DataColumn()
        Me.SSTPING = New System.Data.DataColumn()
        Me.SCTPALM = New System.Data.DataColumn()
        Me.STALMC = New System.Data.DataColumn()
        Me.SCALMC = New System.Data.DataColumn()
        Me.STCMPAL = New System.Data.DataColumn()
        Me.SCZNALM = New System.Data.DataColumn()
        Me.STCMZNA = New System.Data.DataColumn()
        Me.SQTRMC = New System.Data.DataColumn()
        Me.SQTRMP = New System.Data.DataColumn()
        Me.SQDSVGN = New System.Data.DataColumn()
        Me.SCCNTD = New System.Data.DataColumn()
        Me.SCTPOCN = New System.Data.DataColumn()
        Me.SFUNDS2 = New System.Data.DataColumn()
        Me.SCTPDPS = New System.Data.DataColumn()
        Me.STOBSRV = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.dstOrdenCompra = New System.Data.DataSet()
        Me.dtMovimientoItemOC = New System.Data.DataTable()
        Me.CREFFW = New System.Data.DataColumn()
        Me.INGSDA = New System.Data.DataColumn()
        Me.FECDOC = New System.Data.DataColumn()
        Me.NRGUSA = New System.Data.DataColumn()
        Me.QBLTSR = New System.Data.DataColumn()
        Me.NGUIRM = New System.Data.DataColumn()
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.scrContainer_001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrContainer_001.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scrContainer_001.Panel1.SuspendLayout()
        CType(Me.scrContainer_001.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scrContainer_001.Panel2.SuspendLayout()
        Me.scrContainer_001.SuspendLayout()
        Me.tbcDetalles.SuspendLayout()
        Me.tbpDetalle.SuspendLayout()
        Me.tbpMovimiento_DS.SuspendLayout()
        CType(Me.dgvMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpMovimientosOC.SuspendLayout()
        CType(Me.dgMovimientoItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMovimientoItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.scrContainer_001)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(986, 627)
        Me.KryptonPanel.TabIndex = 0
        '
        'scrContainer_001
        '
        Me.scrContainer_001.Cursor = System.Windows.Forms.Cursors.Default
        Me.scrContainer_001.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scrContainer_001.Location = New System.Drawing.Point(0, 150)
        Me.scrContainer_001.Name = "scrContainer_001"
        Me.scrContainer_001.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scrContainer_001.Panel1
        '
        Me.scrContainer_001.Panel1.Controls.Add(Me.dgOrdenCompra)
        '
        'scrContainer_001.Panel2
        '
        Me.scrContainer_001.Panel2.Controls.Add(Me.tbcDetalles)
        Me.scrContainer_001.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile
        Me.scrContainer_001.Size = New System.Drawing.Size(986, 477)
        Me.scrContainer_001.SplitterDistance = 215
        Me.scrContainer_001.TabIndex = 1
        '
        'dgOrdenCompra
        '
        Me.dgOrdenCompra.Agregar = True
        Me.dgOrdenCompra.BackColor = System.Drawing.Color.Transparent
        Me.dgOrdenCompra.Buscar = False
        Me.dgOrdenCompra.CambiarDeCliente = True
        Me.dgOrdenCompra.CodCliente = 0
        Me.dgOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrdenCompra.Eliminar = True
        Me.dgOrdenCompra.isDepositoSimple = False
        Me.dgOrdenCompra.Location = New System.Drawing.Point(0, 0)
        Me.dgOrdenCompra.Modificar = True
        Me.dgOrdenCompra.Name = "dgOrdenCompra"
        Me.dgOrdenCompra.pCCLNT_CodigoCliente = CType(0, Long)
        Me.dgOrdenCompra.pCCMPN_CodCompania = ""
        Me.dgOrdenCompra.pMostrarSegAlmacen = True
        Me.dgOrdenCompra.pMostrarSegCarga = True
        Me.dgOrdenCompra.pREGPAG_NroRegPorPagina = 20
        Me.dgOrdenCompra.RecepcionInterfazSap = False
        Me.dgOrdenCompra.Size = New System.Drawing.Size(986, 215)
        Me.dgOrdenCompra.TabIndex = 21
        Me.dgOrdenCompra.Traslado = True
        '
        'tbcDetalles
        '
        Me.tbcDetalles.Controls.Add(Me.tbpDetalle)
        Me.tbcDetalles.Controls.Add(Me.tbpMovimiento_DS)
        Me.tbcDetalles.Controls.Add(Me.tbpMovimientosOC)
        Me.tbcDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcDetalles.Location = New System.Drawing.Point(0, 0)
        Me.tbcDetalles.Name = "tbcDetalles"
        Me.tbcDetalles.SelectedIndex = 0
        Me.tbcDetalles.Size = New System.Drawing.Size(986, 257)
        Me.tbcDetalles.TabIndex = 1
        '
        'tbpDetalle
        '
        Me.tbpDetalle.Controls.Add(Me.dgItemsOC)
        Me.tbpDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tbpDetalle.Name = "tbpDetalle"
        Me.tbpDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDetalle.Size = New System.Drawing.Size(978, 231)
        Me.tbpDetalle.TabIndex = 0
        Me.tbpDetalle.Text = "Detalle Item"
        Me.tbpDetalle.UseVisualStyleBackColor = True
        '
        'dgItemsOC
        '
        Me.dgItemsOC.Agregar = False
        Me.dgItemsOC.BackColor = System.Drawing.Color.Transparent
        Me.dgItemsOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemsOC.Eliminar = False
        Me.dgItemsOC.Location = New System.Drawing.Point(3, 3)
        Me.dgItemsOC.Modificar = False
        Me.dgItemsOC.Name = "dgItemsOC"
        Me.dgItemsOC.pCCMPN_CodCompania = ""
        Me.dgItemsOC.pEstado = ""
        Me.dgItemsOC.pMostrarGenerar = Ransa.Controls.OrdenCompra.eGenerarTipo.GenerarRecepcion
        Me.dgItemsOC.pMostrarGenerarRecojo = False
        Me.dgItemsOC.pMostrarSegAlmacen = True
        Me.dgItemsOC.pMostrarSegCarga = True
        Me.dgItemsOC.Size = New System.Drawing.Size(972, 225)
        Me.dgItemsOC.TabIndex = 23
        '
        'tbpMovimiento_DS
        '
        Me.tbpMovimiento_DS.Controls.Add(Me.dgvMovimiento)
        Me.tbpMovimiento_DS.Location = New System.Drawing.Point(4, 22)
        Me.tbpMovimiento_DS.Name = "tbpMovimiento_DS"
        Me.tbpMovimiento_DS.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMovimiento_DS.Size = New System.Drawing.Size(978, 231)
        Me.tbpMovimiento_DS.TabIndex = 1
        Me.tbpMovimiento_DS.Text = "Movimientos"
        Me.tbpMovimiento_DS.UseVisualStyleBackColor = True
        '
        'dgvMovimiento
        '
        Me.dgvMovimiento.AllowUserToAddRows = False
        Me.dgvMovimiento.AllowUserToDeleteRows = False
        Me.dgvMovimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TABTRF, Me.NGUIRN, Me.FECHA, Me.TIPORI, Me.NGUICL, Me.TIPOALMACEN, Me.ALMACEN, Me.ZONA, Me.TOBSRV, Me.TOTAL_ITEM, Me.MOVIMIENTO_DETALLE})
        Me.dgvMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimiento.Location = New System.Drawing.Point(3, 3)
        Me.dgvMovimiento.Name = "dgvMovimiento"
        Me.dgvMovimiento.ReadOnly = True
        Me.dgvMovimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimiento.Size = New System.Drawing.Size(972, 225)
        Me.dgvMovimiento.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvMovimiento.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvMovimiento.TabIndex = 31
        '
        'TABTRF
        '
        Me.TABTRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TABTRF.DataPropertyName = "TABTRF"
        Me.TABTRF.HeaderText = "Tipo Movimiento"
        Me.TABTRF.Name = "TABTRF"
        Me.TABTRF.ReadOnly = True
        Me.TABTRF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TABTRF.Width = 109
        '
        'NGUIRN
        '
        Me.NGUIRN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUIRN.DataPropertyName = "NGUIRN"
        Me.NGUIRN.HeaderText = "Nro Guía Ransa"
        Me.NGUIRN.Name = "NGUIRN"
        Me.NGUIRN.ReadOnly = True
        Me.NGUIRN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NGUIRN.Width = 98
        '
        'FECHA
        '
        Me.FECHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECHA.DataPropertyName = "FECHA"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FECHA.DefaultCellStyle = DataGridViewCellStyle1
        Me.FECHA.HeaderText = "Fecha Solicitud"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Width = 116
        '
        'TIPORI
        '
        Me.TIPORI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPORI.DataPropertyName = "TIPORI"
        Me.TIPORI.HeaderText = "Doc. Origen"
        Me.TIPORI.Name = "TIPORI"
        Me.TIPORI.ReadOnly = True
        Me.TIPORI.Width = 99
        '
        'NGUICL
        '
        Me.NGUICL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUICL.DataPropertyName = "NGUICL"
        Me.NGUICL.HeaderText = "Nro. Doc. Origen"
        Me.NGUICL.Name = "NGUICL"
        Me.NGUICL.ReadOnly = True
        Me.NGUICL.Width = 125
        '
        'TIPOALMACEN
        '
        Me.TIPOALMACEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPOALMACEN.DataPropertyName = "TIPOALMACEN"
        Me.TIPOALMACEN.HeaderText = "Tipo Almacen"
        Me.TIPOALMACEN.Name = "TIPOALMACEN"
        Me.TIPOALMACEN.ReadOnly = True
        Me.TIPOALMACEN.Width = 110
        '
        'ALMACEN
        '
        Me.ALMACEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ALMACEN.DataPropertyName = "ALMACEN"
        Me.ALMACEN.HeaderText = "Almacen"
        Me.ALMACEN.Name = "ALMACEN"
        Me.ALMACEN.ReadOnly = True
        Me.ALMACEN.Width = 83
        '
        'ZONA
        '
        Me.ZONA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ZONA.DataPropertyName = "ZONA"
        Me.ZONA.HeaderText = "Zona"
        Me.ZONA.Name = "ZONA"
        Me.ZONA.ReadOnly = True
        Me.ZONA.Width = 63
        '
        'TOBSRV
        '
        Me.TOBSRV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBSRV.DataPropertyName = "TOBSRV"
        Me.TOBSRV.HeaderText = "Observación"
        Me.TOBSRV.Name = "TOBSRV"
        Me.TOBSRV.ReadOnly = True
        Me.TOBSRV.Width = 102
        '
        'TOTAL_ITEM
        '
        Me.TOTAL_ITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOTAL_ITEM.DataPropertyName = "TOTAL_ITEM"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TOTAL_ITEM.DefaultCellStyle = DataGridViewCellStyle2
        Me.TOTAL_ITEM.HeaderText = "Total Item"
        Me.TOTAL_ITEM.Name = "TOTAL_ITEM"
        Me.TOTAL_ITEM.ReadOnly = True
        Me.TOTAL_ITEM.Width = 89
        '
        'MOVIMIENTO_DETALLE
        '
        Me.MOVIMIENTO_DETALLE.HeaderText = "Movimiento"
        Me.MOVIMIENTO_DETALLE.Image = Global.SOLMIN_SA.My.Resources.Resources.text_block
        Me.MOVIMIENTO_DETALLE.Name = "MOVIMIENTO_DETALLE"
        Me.MOVIMIENTO_DETALLE.ReadOnly = True
        '
        'tbpMovimientosOC
        '
        Me.tbpMovimientosOC.Controls.Add(Me.dgMovimientoItemOC)
        Me.tbpMovimientosOC.Controls.Add(Me.tsMenuOpciones)
        Me.tbpMovimientosOC.Location = New System.Drawing.Point(4, 22)
        Me.tbpMovimientosOC.Name = "tbpMovimientosOC"
        Me.tbpMovimientosOC.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMovimientosOC.Size = New System.Drawing.Size(978, 231)
        Me.tbpMovimientosOC.TabIndex = 2
        Me.tbpMovimientosOC.Text = "Movimientos O/C"
        Me.tbpMovimientosOC.UseVisualStyleBackColor = True
        '
        'dgMovimientoItemOC
        '
        Me.dgMovimientoItemOC.AllowUserToAddRows = False
        Me.dgMovimientoItemOC.AllowUserToDeleteRows = False
        Me.dgMovimientoItemOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TPLNTA, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.M_CREFFW, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.M_NSEQIN, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.M_IMBULTO, Me.M_CPLNDV})
        Me.dgMovimientoItemOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMovimientoItemOC.Location = New System.Drawing.Point(3, 28)
        Me.dgMovimientoItemOC.Name = "dgMovimientoItemOC"
        Me.dgMovimientoItemOC.ReadOnly = True
        Me.dgMovimientoItemOC.Size = New System.Drawing.Size(972, 200)
        Me.dgMovimientoItemOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMovimientoItemOC.TabIndex = 26
        '
        'TPLNTA
        '
        Me.TPLNTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TPLNTA.DataPropertyName = "TPLNTA"
        Me.TPLNTA.HeaderText = "Planta"
        Me.TPLNTA.Name = "TPLNTA"
        Me.TPLNTA.ReadOnly = True
        Me.TPLNTA.Width = 69
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOPREC"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No. Bulto Parcial"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "INGSDA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mov. Ing."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'M_CREFFW
        '
        Me.M_CREFFW.DataPropertyName = "CREFFW"
        Me.M_CREFFW.HeaderText = "Bulto"
        Me.M_CREFFW.Name = "M_CREFFW"
        Me.M_CREFFW.ReadOnly = True
        Me.M_CREFFW.Width = 105
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FECDOC"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Mov."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CZNALM"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Zona  Almacen"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'M_NSEQIN
        '
        Me.M_NSEQIN.DataPropertyName = "NSEQIN"
        Me.M_NSEQIN.HeaderText = "M_NSEQIN"
        Me.M_NSEQIN.Name = "M_NSEQIN"
        Me.M_NSEQIN.ReadOnly = True
        Me.M_NSEQIN.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TIPBTO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unid."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn9.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TUNPSO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Unid." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & "Peso"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 55
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn11.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TUNVOL"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Unid." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & "Volumen"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 55
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NRGUSA"
        Me.DataGridViewTextBoxColumn13.HeaderText = "No. Guia (P)/(S)"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 220
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NORAGN"
        Me.DataGridViewTextBoxColumn14.HeaderText = "N° O/S Agencia"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn15.HeaderText = "No. Guia Remisión"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "DSREFE"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CREFFW1"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "INGSDA1"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Mov. Sal."
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 70
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "FECDOC1"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Fecha Mov."
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 80
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "NRGUSA1"
        Me.DataGridViewTextBoxColumn20.HeaderText = "No. Guia (P)/(S)"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "QBLTSR1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn21.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 80
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "NGUIRM1"
        Me.DataGridViewTextBoxColumn22.HeaderText = "No. Guia Remision"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 120
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "STPDES1"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Tipo de Transporte"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 150
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "FLGCNL1"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Estado de Entrega"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "FCNFCL1"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Fecha de Confirmación"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "HCNFCL1"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Hora Confirmación"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "TOBSEN1"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Observación de Entrega"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'M_IMBULTO
        '
        Me.M_IMBULTO.HeaderText = "Items"
        Me.M_IMBULTO.Image = Global.SOLMIN_SA.My.Resources.Resources.text_block
        Me.M_IMBULTO.Name = "M_IMBULTO"
        Me.M_IMBULTO.ReadOnly = True
        Me.M_IMBULTO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.M_IMBULTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.M_IMBULTO.Width = 40
        '
        'M_CPLNDV
        '
        Me.M_CPLNDV.HeaderText = "CPLNDV"
        Me.M_CPLNDV.Name = "M_CPLNDV"
        Me.M_CPLNDV.ReadOnly = True
        Me.M_CPLNDV.Visible = False
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblWaybill})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(3, 3)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(972, 25)
        Me.tsMenuOpciones.TabIndex = 25
        '
        'lblWaybill
        '
        Me.lblWaybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaybill.Name = "lblWaybill"
        Me.lblWaybill.Size = New System.Drawing.Size(56, 22)
        Me.lblWaybill.Tag = "Movimiento O/C"
        Me.lblWaybill.Text = "BULTOS"
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaStatusOcultarFiltros, Me.bsaCerrarVentana})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.cmbPrioridad)
        Me.hgFiltros.Panel.Controls.Add(Me.lblPrioridad)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.lblSituacionOC)
        Me.hgFiltros.Panel.Controls.Add(Me.cmbSituacionOC)
        Me.hgFiltros.Panel.Controls.Add(Me.txtProveedor)
        Me.hgFiltros.Panel.Controls.Add(Me.cmbTermInter)
        Me.hgFiltros.Panel.Controls.Add(Me.btnCambiarCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.lblDescripcion)
        Me.hgFiltros.Panel.Controls.Add(Me.txtDescripcion)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTerminoInternacional)
        Me.hgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.hgFiltros.Panel.Controls.Add(Me.txtFechaFinal)
        Me.hgFiltros.Panel.Controls.Add(Me.txtFechaInicial)
        Me.hgFiltros.Panel.Controls.Add(Me.lblOrdenCompra)
        Me.hgFiltros.Panel.Controls.Add(Me.lblFechaFinal)
        Me.hgFiltros.Panel.Controls.Add(Me.lblFechaInicial)
        Me.hgFiltros.Panel.Controls.Add(Me.txtOrdenCompra)
        Me.hgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.lblProveedor)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(986, 150)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 0
        Me.hgFiltros.Text = "Filtros"
        Me.hgFiltros.ValuesPrimary.Description = ""
        Me.hgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.hgFiltros.ValuesPrimary.Image = Nothing
        Me.hgFiltros.ValuesSecondary.Description = ""
        Me.hgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.hgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaStatusOcultarFiltros
        '
        Me.bsaStatusOcultarFiltros.ExtraText = ""
        Me.bsaStatusOcultarFiltros.Image = Nothing
        Me.bsaStatusOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaStatusOcultarFiltros.Text = "Ocultar"
        Me.bsaStatusOcultarFiltros.ToolTipImage = Nothing
        Me.bsaStatusOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaStatusOcultarFiltros.UniqueName = "035391BBFC7044C3035391BBFC7044C3"
        '
        'bsaCerrarVentana
        '
        Me.bsaCerrarVentana.ExtraText = ""
        Me.bsaCerrarVentana.Image = Nothing
        Me.bsaCerrarVentana.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrarVentana.Text = "Cerrar"
        Me.bsaCerrarVentana.ToolTipImage = Nothing
        Me.bsaCerrarVentana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrarVentana.UniqueName = "EC0877FED5AD46CBEC0877FED5AD46CB"
        '
        'cmbPrioridad
        '
        Me.cmbPrioridad.BackColor = System.Drawing.Color.Transparent
        Me.cmbPrioridad.Location = New System.Drawing.Point(74, 87)
        Me.cmbPrioridad.Name = "cmbPrioridad"
        Me.cmbPrioridad.pCategoria = "NTPDES"
        Me.cmbPrioridad.pIsRequired = False
        Me.cmbPrioridad.Size = New System.Drawing.Size(262, 21)
        Me.cmbPrioridad.TabIndex = 8
        '
        'lblPrioridad
        '
        Me.lblPrioridad.Location = New System.Drawing.Point(7, 92)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(66, 20)
        Me.lblPrioridad.TabIndex = 7
        Me.lblPrioridad.Text = "Prioridad : "
        Me.lblPrioridad.Values.ExtraText = ""
        Me.lblPrioridad.Values.Image = Nothing
        Me.lblPrioridad.Values.Text = "Prioridad : "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(74, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(262, 22)
        Me.txtCliente.TabIndex = 2
        '
        'lblSituacionOC
        '
        Me.lblSituacionOC.Location = New System.Drawing.Point(344, 92)
        Me.lblSituacionOC.Name = "lblSituacionOC"
        Me.lblSituacionOC.Size = New System.Drawing.Size(67, 20)
        Me.lblSituacionOC.TabIndex = 17
        Me.lblSituacionOC.Text = "Situación :"
        Me.lblSituacionOC.Values.ExtraText = ""
        Me.lblSituacionOC.Values.Image = Nothing
        Me.lblSituacionOC.Values.Text = "Situación :"
        '
        'cmbSituacionOC
        '
        Me.cmbSituacionOC.BackColor = System.Drawing.Color.Transparent
        Me.cmbSituacionOC.Location = New System.Drawing.Point(427, 87)
        Me.cmbSituacionOC.Name = "cmbSituacionOC"
        Me.cmbSituacionOC.pCategoria = "SITUOC"
        Me.cmbSituacionOC.pIsRequired = False
        Me.cmbSituacionOC.Size = New System.Drawing.Size(243, 21)
        Me.cmbSituacionOC.TabIndex = 18
        '
        'txtProveedor
        '
        Me.txtProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtProveedor.BackColor = System.Drawing.Color.Transparent
        Me.txtProveedor.Location = New System.Drawing.Point(74, 63)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.pCodigo = CType(0, Long)
        Me.txtProveedor.pMostarBtnNewProv = False
        Me.txtProveedor.pRequerido = False
        Me.txtProveedor.Size = New System.Drawing.Size(262, 22)
        Me.txtProveedor.TabIndex = 6
        '
        'cmbTermInter
        '
        Me.cmbTermInter.BackColor = System.Drawing.Color.Transparent
        Me.cmbTermInter.Location = New System.Drawing.Point(427, 38)
        Me.cmbTermInter.Name = "cmbTermInter"
        Me.cmbTermInter.pCategoria = "TERINT"
        Me.cmbTermInter.pIsRequired = False
        Me.cmbTermInter.Size = New System.Drawing.Size(243, 21)
        Me.cmbTermInter.TabIndex = 12
        '
        'btnCambiarCliente
        '
        Me.btnCambiarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCambiarCliente.Location = New System.Drawing.Point(905, 13)
        Me.btnCambiarCliente.Name = "btnCambiarCliente"
        Me.btnCambiarCliente.Size = New System.Drawing.Size(68, 69)
        Me.btnCambiarCliente.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCambiarCliente.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnCambiarCliente.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCambiarCliente.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnCambiarCliente.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCambiarCliente.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCambiarCliente.TabIndex = 20
        Me.btnCambiarCliente.Text = "&Cambiar"
        Me.btnCambiarCliente.Values.ExtraText = "Cliente"
        Me.btnCambiarCliente.Values.Image = CType(resources.GetObject("btnCambiarCliente.Values.Image"), System.Drawing.Image)
        Me.btnCambiarCliente.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCambiarCliente.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCambiarCliente.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCambiarCliente.Values.Text = "&Cambiar"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(344, 16)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 20)
        Me.lblDescripcion.TabIndex = 9
        Me.lblDescripcion.Text = "Descripción : "
        Me.lblDescripcion.Values.ExtraText = ""
        Me.lblDescripcion.Values.Image = Nothing
        Me.lblDescripcion.Values.Text = "Descripción : "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaDescripcionLimpiar})
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(427, 13)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(243, 22)
        Me.txtDescripcion.TabIndex = 10
        '
        'bsaDescripcionLimpiar
        '
        Me.bsaDescripcionLimpiar.ExtraText = ""
        Me.bsaDescripcionLimpiar.Image = Nothing
        Me.bsaDescripcionLimpiar.Text = ""
        Me.bsaDescripcionLimpiar.ToolTipImage = Nothing
        Me.bsaDescripcionLimpiar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaDescripcionLimpiar.UniqueName = "DD3C34848EF94820DD3C34848EF94820"
        '
        'lblTerminoInternacional
        '
        Me.lblTerminoInternacional.Location = New System.Drawing.Point(344, 41)
        Me.lblTerminoInternacional.Name = "lblTerminoInternacional"
        Me.lblTerminoInternacional.Size = New System.Drawing.Size(75, 20)
        Me.lblTerminoInternacional.TabIndex = 11
        Me.lblTerminoInternacional.Text = "Térm. Inter.:"
        Me.lblTerminoInternacional.Values.ExtraText = ""
        Me.lblTerminoInternacional.Values.Image = Nothing
        Me.lblTerminoInternacional.Values.Text = "Térm. Inter.:"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(831, 12)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 69)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 19
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaFinal.Location = New System.Drawing.Point(597, 63)
        Me.txtFechaFinal.Mask = "00/00/0000"
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaFinal.Size = New System.Drawing.Size(73, 22)
        Me.txtFechaFinal.TabIndex = 16
        Me.txtFechaFinal.Text = "  /  /"
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaInicial.Location = New System.Drawing.Point(427, 63)
        Me.txtFechaInicial.Mask = "00/00/0000"
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaInicial.Size = New System.Drawing.Size(73, 22)
        Me.txtFechaInicial.TabIndex = 14
        Me.txtFechaInicial.Text = "  /  /"
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Location = New System.Drawing.Point(7, 41)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(65, 20)
        Me.lblOrdenCompra.TabIndex = 3
        Me.lblOrdenCompra.Text = "Nro. O/C : "
        Me.lblOrdenCompra.Values.ExtraText = ""
        Me.lblOrdenCompra.Values.Image = Nothing
        Me.lblOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(515, 65)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(77, 20)
        Me.lblFechaFinal.TabIndex = 15
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(344, 66)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(81, 20)
        Me.lblFechaInicial.TabIndex = 13
        Me.lblFechaInicial.Text = "Fecha Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inicio : "
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaOrdenCompraLimpiar})
        Me.txtOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdenCompra.Location = New System.Drawing.Point(74, 38)
        Me.txtOrdenCompra.MaxLength = 100
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(262, 22)
        Me.txtOrdenCompra.TabIndex = 4
        '
        'bsaOrdenCompraLimpiar
        '
        Me.bsaOrdenCompraLimpiar.ExtraText = ""
        Me.bsaOrdenCompraLimpiar.Image = Nothing
        Me.bsaOrdenCompraLimpiar.Text = ""
        Me.bsaOrdenCompraLimpiar.ToolTipImage = Nothing
        Me.bsaOrdenCompraLimpiar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaOrdenCompraLimpiar.UniqueName = "DD3C34848EF94820DD3C34848EF94820"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(7, 16)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(54, 20)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(7, 66)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(73, 20)
        Me.lblProveedor.TabIndex = 5
        Me.lblProveedor.Text = "Proveedor : "
        Me.lblProveedor.Values.ExtraText = ""
        Me.lblProveedor.Values.Image = Nothing
        Me.lblProveedor.Values.Text = "Proveedor : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(797, -1)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 118)
        Me.KryptonLabel5.TabIndex = 39
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtMercaderia, Me.dtMercaderiaSeleccionadas})
        '
        'dtMercaderia
        '
        Me.dtMercaderia.Columns.AddRange(New System.Data.DataColumn() {Me.MSTASEL, Me.MCFMCLR, Me.MCGRCLR, Me.MCMRCLR, Me.MTMRCD2, Me.MCMRCD, Me.MSALDO, Me.MSESTRG, Me.MSITUAC, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.dtMercaderia.TableName = "dtMercaderia"
        '
        'MSTASEL
        '
        Me.MSTASEL.ColumnName = "STASEL"
        Me.MSTASEL.DataType = GetType(Short)
        '
        'MCFMCLR
        '
        Me.MCFMCLR.ColumnName = "CFMCLR"
        '
        'MCGRCLR
        '
        Me.MCGRCLR.ColumnName = "CGRCLR"
        '
        'MCMRCLR
        '
        Me.MCMRCLR.ColumnName = "CMRCLR"
        '
        'MTMRCD2
        '
        Me.MTMRCD2.ColumnName = "TMRCD2"
        '
        'MCMRCD
        '
        Me.MCMRCD.ColumnName = "CMRCD"
        '
        'MSALDO
        '
        Me.MSALDO.ColumnName = "SALDO"
        Me.MSALDO.DataType = GetType(Decimal)
        '
        'MSESTRG
        '
        Me.MSESTRG.ColumnName = "SESTRG"
        '
        'MSITUAC
        '
        Me.MSITUAC.ColumnName = "SITUAC"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "TGRCLR"
        Me.DataColumn1.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "TFMCLR"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "MARCRE"
        Me.DataColumn3.DefaultValue = ""
        '
        'dtMercaderiaSeleccionadas
        '
        Me.dtMercaderiaSeleccionadas.Columns.AddRange(New System.Data.DataColumn() {Me.SCMRCLR, Me.STMRCD2, Me.SCMRCD, Me.SNORDSR, Me.SNCNTR, Me.SNCRCTC, Me.SNAUTR, Me.SCUNCNT, Me.SCUNPST, Me.SCUNVLT, Me.SNORCCL, Me.SNGUICL, Me.SNRUCLL, Me.SSTPING, Me.SCTPALM, Me.STALMC, Me.SCALMC, Me.STCMPAL, Me.SCZNALM, Me.STCMZNA, Me.SQTRMC, Me.SQTRMP, Me.SQDSVGN, Me.SCCNTD, Me.SCTPOCN, Me.SFUNDS2, Me.SCTPDPS, Me.STOBSRV, Me.DataColumn4})
        Me.dtMercaderiaSeleccionadas.TableName = "dtMercaderiaSeleccionadas"
        '
        'SCMRCLR
        '
        Me.SCMRCLR.ColumnName = "CMRCLR"
        Me.SCMRCLR.DefaultValue = ""
        '
        'STMRCD2
        '
        Me.STMRCD2.ColumnName = "TMRCD2"
        Me.STMRCD2.DefaultValue = ""
        '
        'SCMRCD
        '
        Me.SCMRCD.ColumnName = "CMRCD"
        Me.SCMRCD.DefaultValue = ""
        '
        'SNORDSR
        '
        Me.SNORDSR.ColumnName = "NORDSR"
        Me.SNORDSR.DataType = GetType(Long)
        Me.SNORDSR.DefaultValue = CType(0, Long)
        '
        'SNCNTR
        '
        Me.SNCNTR.ColumnName = "NCNTR"
        Me.SNCNTR.DataType = GetType(Long)
        Me.SNCNTR.DefaultValue = CType(0, Long)
        '
        'SNCRCTC
        '
        Me.SNCRCTC.ColumnName = "NCRCTC"
        Me.SNCRCTC.DataType = GetType(Long)
        Me.SNCRCTC.DefaultValue = CType(0, Long)
        '
        'SNAUTR
        '
        Me.SNAUTR.ColumnName = "NAUTR"
        Me.SNAUTR.DataType = GetType(Long)
        Me.SNAUTR.DefaultValue = CType(0, Long)
        '
        'SCUNCNT
        '
        Me.SCUNCNT.ColumnName = "CUNCNT"
        '
        'SCUNPST
        '
        Me.SCUNPST.ColumnName = "CUNPST"
        Me.SCUNPST.DefaultValue = ""
        '
        'SCUNVLT
        '
        Me.SCUNVLT.ColumnName = "CUNVLT"
        Me.SCUNVLT.DefaultValue = ""
        '
        'SNORCCL
        '
        Me.SNORCCL.ColumnName = "NORCCL"
        Me.SNORCCL.DefaultValue = ""
        '
        'SNGUICL
        '
        Me.SNGUICL.ColumnName = "NGUICL"
        Me.SNGUICL.DefaultValue = ""
        '
        'SNRUCLL
        '
        Me.SNRUCLL.ColumnName = "NRUCLL"
        Me.SNRUCLL.DefaultValue = ""
        '
        'SSTPING
        '
        Me.SSTPING.ColumnName = "STPING"
        Me.SSTPING.DefaultValue = ""
        '
        'SCTPALM
        '
        Me.SCTPALM.ColumnName = "CTPALM"
        Me.SCTPALM.DefaultValue = ""
        '
        'STALMC
        '
        Me.STALMC.ColumnName = "TALMC"
        Me.STALMC.DefaultValue = ""
        '
        'SCALMC
        '
        Me.SCALMC.ColumnName = "CALMC"
        Me.SCALMC.DefaultValue = ""
        '
        'STCMPAL
        '
        Me.STCMPAL.ColumnName = "TCMPAL"
        Me.STCMPAL.DefaultValue = ""
        '
        'SCZNALM
        '
        Me.SCZNALM.ColumnName = "CZNALM"
        Me.SCZNALM.DefaultValue = ""
        '
        'STCMZNA
        '
        Me.STCMZNA.ColumnName = "TCMZNA"
        Me.STCMZNA.DefaultValue = ""
        '
        'SQTRMC
        '
        Me.SQTRMC.ColumnName = "QTRMC"
        Me.SQTRMC.DataType = GetType(Decimal)
        Me.SQTRMC.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'SQTRMP
        '
        Me.SQTRMP.ColumnName = "QTRMP"
        Me.SQTRMP.DataType = GetType(Decimal)
        Me.SQTRMP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'SQDSVGN
        '
        Me.SQDSVGN.ColumnName = "QDSVGN"
        Me.SQDSVGN.DataType = GetType(Decimal)
        Me.SQDSVGN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'SCCNTD
        '
        Me.SCCNTD.ColumnName = "CCNTD"
        Me.SCCNTD.DefaultValue = ""
        '
        'SCTPOCN
        '
        Me.SCTPOCN.ColumnName = "CTPOCN"
        Me.SCTPOCN.DefaultValue = ""
        '
        'SFUNDS2
        '
        Me.SFUNDS2.ColumnName = "FUNDS2"
        Me.SFUNDS2.DefaultValue = ""
        '
        'SCTPDPS
        '
        Me.SCTPDPS.ColumnName = "CTPDPS"
        Me.SCTPDPS.DefaultValue = ""
        '
        'STOBSRV
        '
        Me.STOBSRV.ColumnName = "TOBSRV"
        Me.STOBSRV.DefaultValue = ""
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "MARCRE"
        Me.DataColumn4.DefaultValue = ""
        '
        'dstOrdenCompra
        '
        Me.dstOrdenCompra.DataSetName = "dstOrdenCompra"
        Me.dstOrdenCompra.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dstOrdenCompra.Tables.AddRange(New System.Data.DataTable() {Me.dtMovimientoItemOC})
        '
        'dtMovimientoItemOC
        '
        Me.dtMovimientoItemOC.Columns.AddRange(New System.Data.DataColumn() {Me.CREFFW, Me.INGSDA, Me.FECDOC, Me.NRGUSA, Me.QBLTSR, Me.NGUIRM})
        Me.dtMovimientoItemOC.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dtMovimientoItemOC.TableName = "dtMovimientoItemOC"
        '
        'CREFFW
        '
        Me.CREFFW.ColumnName = "CREFFW"
        '
        'INGSDA
        '
        Me.INGSDA.ColumnName = "INGSDA"
        '
        'FECDOC
        '
        Me.FECDOC.ColumnName = "FECDOC"
        Me.FECDOC.DataType = GetType(Date)
        '
        'NRGUSA
        '
        Me.NRGUSA.ColumnName = "NRGUSA"
        '
        'QBLTSR
        '
        Me.QBLTSR.ColumnName = "QBLTSR"
        Me.QBLTSR.DataType = GetType(Decimal)
        '
        'NGUIRM
        '
        Me.NGUIRM.ColumnName = "NGUIRM"
        '
        'frmRecepcionOcSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 627)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmRecepcionOcSDS"
        Me.Text = "Recepción de Orden de Compras"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.scrContainer_001.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scrContainer_001.Panel1.ResumeLayout(False)
        CType(Me.scrContainer_001.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scrContainer_001.Panel2.ResumeLayout(False)
        CType(Me.scrContainer_001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scrContainer_001.ResumeLayout(False)
        Me.tbcDetalles.ResumeLayout(False)
        Me.tbpDetalle.ResumeLayout(False)
        Me.tbpMovimiento_DS.ResumeLayout(False)
        CType(Me.dgvMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpMovimientosOC.ResumeLayout(False)
        Me.tbpMovimientosOC.PerformLayout()
        CType(Me.dgMovimientoItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMovimientoItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnCambiarCliente As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents lblProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents scrContainer_001 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents txtFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents bsaStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents dstOrdenCompra As System.Data.DataSet
    Private WithEvents lblTerminoInternacional As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents bsaOrdenCompraLimpiar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents bsaDescripcionLimpiar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents dtMovimientoItemOC As System.Data.DataTable
    Private WithEvents CREFFW As System.Data.DataColumn
    Private WithEvents INGSDA As System.Data.DataColumn
    Private WithEvents FECDOC As System.Data.DataColumn
    Private WithEvents NRGUSA As System.Data.DataColumn
    Private WithEvents QBLTSR As System.Data.DataColumn
    Private WithEvents NGUIRM As System.Data.DataColumn
    Friend WithEvents dgOrdenCompra As Ransa.Controls.OrdenCompra.ucOrdenCompra_DgF01
    Friend WithEvents txtProveedor As Ransa.Controls.Proveedor.ucProveedor_TxtF01
    Friend WithEvents cmbTermInter As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Private WithEvents lblSituacionOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbSituacionOC As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents cmbPrioridad As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Friend WithEvents lblPrioridad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dstMercaderia As System.Data.DataSet
    Friend WithEvents dtMercaderia As System.Data.DataTable
    Friend WithEvents MSTASEL As System.Data.DataColumn
    Friend WithEvents MCFMCLR As System.Data.DataColumn
    Friend WithEvents MCGRCLR As System.Data.DataColumn
    Friend WithEvents MCMRCLR As System.Data.DataColumn
    Friend WithEvents MTMRCD2 As System.Data.DataColumn
    Friend WithEvents MCMRCD As System.Data.DataColumn
    Friend WithEvents MSALDO As System.Data.DataColumn
    Friend WithEvents MSESTRG As System.Data.DataColumn
    Friend WithEvents MSITUAC As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents dtMercaderiaSeleccionadas As System.Data.DataTable
    Friend WithEvents SCMRCLR As System.Data.DataColumn
    Friend WithEvents STMRCD2 As System.Data.DataColumn
    Friend WithEvents SCMRCD As System.Data.DataColumn
    Friend WithEvents SNORDSR As System.Data.DataColumn
    Friend WithEvents SNCNTR As System.Data.DataColumn
    Friend WithEvents SNCRCTC As System.Data.DataColumn
    Friend WithEvents SNAUTR As System.Data.DataColumn
    Friend WithEvents SCUNCNT As System.Data.DataColumn
    Friend WithEvents SCUNPST As System.Data.DataColumn
    Friend WithEvents SCUNVLT As System.Data.DataColumn
    Friend WithEvents SNORCCL As System.Data.DataColumn
    Friend WithEvents SNGUICL As System.Data.DataColumn
    Friend WithEvents SNRUCLL As System.Data.DataColumn
    Friend WithEvents SSTPING As System.Data.DataColumn
    Friend WithEvents SCTPALM As System.Data.DataColumn
    Friend WithEvents STALMC As System.Data.DataColumn
    Friend WithEvents SCALMC As System.Data.DataColumn
    Friend WithEvents STCMPAL As System.Data.DataColumn
    Friend WithEvents SCZNALM As System.Data.DataColumn
    Friend WithEvents STCMZNA As System.Data.DataColumn
    Friend WithEvents SQTRMC As System.Data.DataColumn
    Friend WithEvents SQTRMP As System.Data.DataColumn
    Friend WithEvents SQDSVGN As System.Data.DataColumn
    Friend WithEvents SCCNTD As System.Data.DataColumn
    Friend WithEvents SCTPOCN As System.Data.DataColumn
    Friend WithEvents SFUNDS2 As System.Data.DataColumn
    Friend WithEvents SCTPDPS As System.Data.DataColumn
    Friend WithEvents STOBSRV As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents tbcDetalles As System.Windows.Forms.TabControl
    Friend WithEvents tbpDetalle As System.Windows.Forms.TabPage
    Friend WithEvents tbpMovimiento_DS As System.Windows.Forms.TabPage
    Friend WithEvents dgItemsOC As RANSA.Controls.OrdenCompra.ucItemOC_DgF01
    Friend WithEvents tbpMovimientosOC As System.Windows.Forms.TabPage
    Friend WithEvents dgvMovimiento As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TABTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPORI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUICL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZONA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOVIMIENTO_DETALLE As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgMovimientoItemOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblWaybill As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NSEQIN As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IMBULTO As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents M_CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
