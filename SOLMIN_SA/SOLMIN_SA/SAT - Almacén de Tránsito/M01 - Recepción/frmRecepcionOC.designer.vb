<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionOC
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BePlanta2 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim BeCompania2 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecepcionOC))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.scrContainer_001 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dgOrdenCompra = New Ransa.Controls.OrdenCompra.ucOrdenCompra_DgF01()
        Me.tbcDetalles = New System.Windows.Forms.TabControl()
        Me.tbpDetalle = New System.Windows.Forms.TabPage()
        Me.dgItemsOC = New Ransa.Controls.OrdenCompra.ucItemOC_DgF01()
        Me.tbpMovimientos = New System.Windows.Forms.TabPage()
        Me.dgMovimientoItemOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NOPREC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_INGSDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_FECDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NSEQIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPBTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QPSOBL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QVLBTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUNVOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NRGUSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NORAGN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DSREFE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CREFFW1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_INGSDA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_FECDOC1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NRGUSA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_QBLTSR1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NGUIRM1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUIRS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STPDES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLGCNL1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCNFCL1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HCNFCL1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOBSEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_IMBULTO = New System.Windows.Forms.DataGridViewImageColumn()
        Me.M_CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.lblWaybill = New System.Windows.Forms.ToolStripLabel()
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
        Me.tbpObservaciones = New System.Windows.Forms.TabPage()
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
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
        Me.tbpMovimientos.SuspendLayout()
        CType(Me.dgMovimientoItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.tbpMovimiento_DS.SuspendLayout()
        CType(Me.dgvMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpObservaciones.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
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
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1315, 799)
        Me.KryptonPanel.TabIndex = 0
        '
        'scrContainer_001
        '
        Me.scrContainer_001.Cursor = System.Windows.Forms.Cursors.Default
        Me.scrContainer_001.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scrContainer_001.Location = New System.Drawing.Point(0, 203)
        Me.scrContainer_001.Margin = New System.Windows.Forms.Padding(4)
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
        Me.scrContainer_001.Size = New System.Drawing.Size(1315, 596)
        Me.scrContainer_001.SplitterDistance = 281
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
        Me.dgOrdenCompra.Margin = New System.Windows.Forms.Padding(5)
        Me.dgOrdenCompra.Modificar = True
        Me.dgOrdenCompra.Name = "dgOrdenCompra"
        Me.dgOrdenCompra.pCCLNT_CodigoCliente = CType(0, Long)
        Me.dgOrdenCompra.pCCMPN_CodCompania = ""
        Me.dgOrdenCompra.pMostrarSegAlmacen = True
        Me.dgOrdenCompra.pMostrarSegCarga = True
        Me.dgOrdenCompra.pREGPAG_NroRegPorPagina = 20
        Me.dgOrdenCompra.RecepcionInterfazSap = False
        Me.dgOrdenCompra.Size = New System.Drawing.Size(1315, 281)
        Me.dgOrdenCompra.TabIndex = 0
        Me.dgOrdenCompra.Traslado = True
        '
        'tbcDetalles
        '
        Me.tbcDetalles.Controls.Add(Me.tbpDetalle)
        Me.tbcDetalles.Controls.Add(Me.tbpMovimientos)
        Me.tbcDetalles.Controls.Add(Me.tbpMovimiento_DS)
        Me.tbcDetalles.Controls.Add(Me.tbpObservaciones)
        Me.tbcDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcDetalles.Location = New System.Drawing.Point(0, 0)
        Me.tbcDetalles.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcDetalles.Name = "tbcDetalles"
        Me.tbcDetalles.SelectedIndex = 0
        Me.tbcDetalles.Size = New System.Drawing.Size(1315, 310)
        Me.tbcDetalles.TabIndex = 0
        '
        'tbpDetalle
        '
        Me.tbpDetalle.Controls.Add(Me.dgItemsOC)
        Me.tbpDetalle.Location = New System.Drawing.Point(4, 25)
        Me.tbpDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpDetalle.Name = "tbpDetalle"
        Me.tbpDetalle.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpDetalle.Size = New System.Drawing.Size(1307, 281)
        Me.tbpDetalle.TabIndex = 0
        Me.tbpDetalle.Text = "Detalle Item"
        Me.tbpDetalle.UseVisualStyleBackColor = True
        '
        'dgItemsOC
        '
        Me.dgItemsOC.Agregar = True
        Me.dgItemsOC.BackColor = System.Drawing.Color.Transparent
        Me.dgItemsOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemsOC.Eliminar = True
        Me.dgItemsOC.Location = New System.Drawing.Point(4, 4)
        Me.dgItemsOC.Margin = New System.Windows.Forms.Padding(5)
        Me.dgItemsOC.Modificar = True
        Me.dgItemsOC.Name = "dgItemsOC"
        Me.dgItemsOC.pCCMPN_CodCompania = ""
        Me.dgItemsOC.pEstado = ""
        Me.dgItemsOC.pMostrarGenerar = Ransa.Controls.OrdenCompra.eGenerarTipo.GenerarBulto
        Me.dgItemsOC.pMostrarGenerarRecojo = True
        Me.dgItemsOC.pMostrarSegAlmacen = True
        Me.dgItemsOC.pMostrarSegCarga = True
        Me.dgItemsOC.Size = New System.Drawing.Size(1299, 273)
        Me.dgItemsOC.TabIndex = 0
        '
        'tbpMovimientos
        '
        Me.tbpMovimientos.Controls.Add(Me.dgMovimientoItemOC)
        Me.tbpMovimientos.Controls.Add(Me.tsMenuOpciones)
        Me.tbpMovimientos.Location = New System.Drawing.Point(4, 25)
        Me.tbpMovimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpMovimientos.Name = "tbpMovimientos"
        Me.tbpMovimientos.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpMovimientos.Size = New System.Drawing.Size(1307, 209)
        Me.tbpMovimientos.TabIndex = 1
        Me.tbpMovimientos.Text = "Movimiento O/C"
        Me.tbpMovimientos.UseVisualStyleBackColor = True
        '
        'dgMovimientoItemOC
        '
        Me.dgMovimientoItemOC.AllowUserToAddRows = False
        Me.dgMovimientoItemOC.AllowUserToDeleteRows = False
        Me.dgMovimientoItemOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMovimientoItemOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TPLNTA, Me.M_NOPREC, Me.M_INGSDA, Me.M_CREFFW, Me.M_FECDOC, Me.M_CZNALM, Me.M_NSEQIN, Me.M_QBLTSR, Me.TIPBTO, Me.QPSOBL, Me.TUNPSO, Me.QVLBTO, Me.TUNVOL, Me.M_NRGUSA, Me.NORAGN, Me.M_NGUIRM, Me.DSREFE, Me.M_CREFFW1, Me.M_INGSDA1, Me.M_FECDOC1, Me.M_NRGUSA1, Me.M_QBLTSR1, Me.M_NGUIRM1, Me.NGUIRS, Me.STPDES, Me.FLGCNL1, Me.FCNFCL1, Me.HCNFCL1, Me.TOBSEN, Me.M_IMBULTO, Me.M_CPLNDV})
        Me.dgMovimientoItemOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMovimientoItemOC.Location = New System.Drawing.Point(4, 29)
        Me.dgMovimientoItemOC.Margin = New System.Windows.Forms.Padding(4)
        Me.dgMovimientoItemOC.Name = "dgMovimientoItemOC"
        Me.dgMovimientoItemOC.ReadOnly = True
        Me.dgMovimientoItemOC.Size = New System.Drawing.Size(1299, 176)
        Me.dgMovimientoItemOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMovimientoItemOC.TabIndex = 3
        '
        'TPLNTA
        '
        Me.TPLNTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TPLNTA.DataPropertyName = "TPLNTA"
        Me.TPLNTA.HeaderText = "Planta"
        Me.TPLNTA.Name = "TPLNTA"
        Me.TPLNTA.ReadOnly = True
        Me.TPLNTA.Width = 83
        '
        'M_NOPREC
        '
        Me.M_NOPREC.DataPropertyName = "NOPREC"
        Me.M_NOPREC.HeaderText = "No. Bulto Parcial"
        Me.M_NOPREC.Name = "M_NOPREC"
        Me.M_NOPREC.ReadOnly = True
        '
        'M_INGSDA
        '
        Me.M_INGSDA.DataPropertyName = "INGSDA"
        Me.M_INGSDA.HeaderText = "Mov. Ing."
        Me.M_INGSDA.Name = "M_INGSDA"
        Me.M_INGSDA.ReadOnly = True
        Me.M_INGSDA.Width = 70
        '
        'M_CREFFW
        '
        Me.M_CREFFW.DataPropertyName = "CREFFW"
        Me.M_CREFFW.HeaderText = "Bulto"
        Me.M_CREFFW.Name = "M_CREFFW"
        Me.M_CREFFW.ReadOnly = True
        Me.M_CREFFW.Width = 105
        '
        'M_FECDOC
        '
        Me.M_FECDOC.DataPropertyName = "FECDOC"
        Me.M_FECDOC.HeaderText = "Fecha Mov."
        Me.M_FECDOC.Name = "M_FECDOC"
        Me.M_FECDOC.ReadOnly = True
        Me.M_FECDOC.Width = 80
        '
        'M_CZNALM
        '
        Me.M_CZNALM.DataPropertyName = "CZNALM"
        Me.M_CZNALM.HeaderText = "Zona  Almacen"
        Me.M_CZNALM.Name = "M_CZNALM"
        Me.M_CZNALM.ReadOnly = True
        '
        'M_NSEQIN
        '
        Me.M_NSEQIN.DataPropertyName = "NSEQIN"
        Me.M_NSEQIN.HeaderText = "M_NSEQIN"
        Me.M_NSEQIN.Name = "M_NSEQIN"
        Me.M_NSEQIN.ReadOnly = True
        Me.M_NSEQIN.Visible = False
        '
        'M_QBLTSR
        '
        Me.M_QBLTSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.M_QBLTSR.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.M_QBLTSR.DefaultCellStyle = DataGridViewCellStyle7
        Me.M_QBLTSR.HeaderText = "Cantidad"
        Me.M_QBLTSR.Name = "M_QBLTSR"
        Me.M_QBLTSR.ReadOnly = True
        Me.M_QBLTSR.Width = 80
        '
        'TIPBTO
        '
        Me.TIPBTO.DataPropertyName = "TIPBTO"
        Me.TIPBTO.HeaderText = "Unid."
        Me.TIPBTO.Name = "TIPBTO"
        Me.TIPBTO.ReadOnly = True
        '
        'QPSOBL
        '
        Me.QPSOBL.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.QPSOBL.DefaultCellStyle = DataGridViewCellStyle8
        Me.QPSOBL.HeaderText = "Peso"
        Me.QPSOBL.Name = "QPSOBL"
        Me.QPSOBL.ReadOnly = True
        '
        'TUNPSO
        '
        Me.TUNPSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TUNPSO.DataPropertyName = "TUNPSO"
        Me.TUNPSO.HeaderText = "Unid." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & "Peso"
        Me.TUNPSO.Name = "TUNPSO"
        Me.TUNPSO.ReadOnly = True
        Me.TUNPSO.Width = 55
        '
        'QVLBTO
        '
        Me.QVLBTO.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.QVLBTO.DefaultCellStyle = DataGridViewCellStyle9
        Me.QVLBTO.HeaderText = "Volumen"
        Me.QVLBTO.Name = "QVLBTO"
        Me.QVLBTO.ReadOnly = True
        '
        'TUNVOL
        '
        Me.TUNVOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TUNVOL.DataPropertyName = "TUNVOL"
        Me.TUNVOL.HeaderText = "Unid." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & "Volumen"
        Me.TUNVOL.Name = "TUNVOL"
        Me.TUNVOL.ReadOnly = True
        Me.TUNVOL.Width = 55
        '
        'M_NRGUSA
        '
        Me.M_NRGUSA.DataPropertyName = "NRGUSA"
        Me.M_NRGUSA.HeaderText = "No. Guia (P)/(S)"
        Me.M_NRGUSA.Name = "M_NRGUSA"
        Me.M_NRGUSA.ReadOnly = True
        Me.M_NRGUSA.Width = 220
        '
        'NORAGN
        '
        Me.NORAGN.DataPropertyName = "NORAGN"
        Me.NORAGN.HeaderText = "N° O/S Agencia"
        Me.NORAGN.Name = "NORAGN"
        Me.NORAGN.ReadOnly = True
        '
        'M_NGUIRM
        '
        Me.M_NGUIRM.DataPropertyName = "NGUIRM"
        Me.M_NGUIRM.HeaderText = "No. Guia Remisión"
        Me.M_NGUIRM.Name = "M_NGUIRM"
        Me.M_NGUIRM.ReadOnly = True
        Me.M_NGUIRM.Visible = False
        '
        'DSREFE
        '
        Me.DSREFE.DataPropertyName = "DSREFE"
        Me.DSREFE.HeaderText = "Referencia"
        Me.DSREFE.Name = "DSREFE"
        Me.DSREFE.ReadOnly = True
        '
        'M_CREFFW1
        '
        Me.M_CREFFW1.DataPropertyName = "CREFFW1"
        Me.M_CREFFW1.HeaderText = "Bulto"
        Me.M_CREFFW1.Name = "M_CREFFW1"
        Me.M_CREFFW1.ReadOnly = True
        Me.M_CREFFW1.Visible = False
        '
        'M_INGSDA1
        '
        Me.M_INGSDA1.DataPropertyName = "INGSDA1"
        Me.M_INGSDA1.HeaderText = "Mov. Sal."
        Me.M_INGSDA1.Name = "M_INGSDA1"
        Me.M_INGSDA1.ReadOnly = True
        Me.M_INGSDA1.Width = 70
        '
        'M_FECDOC1
        '
        Me.M_FECDOC1.DataPropertyName = "FECDOC1"
        Me.M_FECDOC1.HeaderText = "Fecha Mov."
        Me.M_FECDOC1.Name = "M_FECDOC1"
        Me.M_FECDOC1.ReadOnly = True
        Me.M_FECDOC1.Width = 80
        '
        'M_NRGUSA1
        '
        Me.M_NRGUSA1.DataPropertyName = "NRGUSA1"
        Me.M_NRGUSA1.HeaderText = "No. Guia (P)/(S)"
        Me.M_NRGUSA1.Name = "M_NRGUSA1"
        Me.M_NRGUSA1.ReadOnly = True
        Me.M_NRGUSA1.Width = 125
        '
        'M_QBLTSR1
        '
        Me.M_QBLTSR1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.M_QBLTSR1.DataPropertyName = "QBLTSR1"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.M_QBLTSR1.DefaultCellStyle = DataGridViewCellStyle10
        Me.M_QBLTSR1.HeaderText = "Cantidad"
        Me.M_QBLTSR1.Name = "M_QBLTSR1"
        Me.M_QBLTSR1.ReadOnly = True
        Me.M_QBLTSR1.Width = 80
        '
        'M_NGUIRM1
        '
        Me.M_NGUIRM1.DataPropertyName = "NGUIRM1"
        Me.M_NGUIRM1.HeaderText = "NGUIRM1"
        Me.M_NGUIRM1.Name = "M_NGUIRM1"
        Me.M_NGUIRM1.ReadOnly = True
        Me.M_NGUIRM1.Visible = False
        Me.M_NGUIRM1.Width = 120
        '
        'NGUIRS
        '
        Me.NGUIRS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUIRS.DataPropertyName = "NGUIRS1"
        Me.NGUIRS.HeaderText = "Guía Remisión Txt"
        Me.NGUIRS.Name = "NGUIRS"
        Me.NGUIRS.ReadOnly = True
        Me.NGUIRS.Width = 130
        '
        'STPDES
        '
        Me.STPDES.DataPropertyName = "STPDES1"
        Me.STPDES.HeaderText = "Tipo de Transporte"
        Me.STPDES.Name = "STPDES"
        Me.STPDES.ReadOnly = True
        Me.STPDES.Width = 150
        '
        'FLGCNL1
        '
        Me.FLGCNL1.DataPropertyName = "FLGCNL1"
        Me.FLGCNL1.HeaderText = "Estado de Entrega"
        Me.FLGCNL1.Name = "FLGCNL1"
        Me.FLGCNL1.ReadOnly = True
        '
        'FCNFCL1
        '
        Me.FCNFCL1.DataPropertyName = "FCNFCL1"
        Me.FCNFCL1.HeaderText = "Fecha de Confirmación"
        Me.FCNFCL1.Name = "FCNFCL1"
        Me.FCNFCL1.ReadOnly = True
        '
        'HCNFCL1
        '
        Me.HCNFCL1.DataPropertyName = "HCNFCL1"
        Me.HCNFCL1.HeaderText = "Hora Confirmación"
        Me.HCNFCL1.Name = "HCNFCL1"
        Me.HCNFCL1.ReadOnly = True
        '
        'TOBSEN
        '
        Me.TOBSEN.DataPropertyName = "TOBSEN1"
        Me.TOBSEN.HeaderText = "Observación de Entrega"
        Me.TOBSEN.Name = "TOBSEN"
        Me.TOBSEN.ReadOnly = True
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
        Me.M_CPLNDV.DataPropertyName = "CPLNDV"
        Me.M_CPLNDV.HeaderText = "M_CPLNDV"
        Me.M_CPLNDV.Name = "M_CPLNDV"
        Me.M_CPLNDV.ReadOnly = True
        Me.M_CPLNDV.Visible = False
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblWaybill})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(4, 4)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(1299, 25)
        Me.tsMenuOpciones.TabIndex = 24
        '
        'lblWaybill
        '
        Me.lblWaybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaybill.Name = "lblWaybill"
        Me.lblWaybill.Size = New System.Drawing.Size(70, 22)
        Me.lblWaybill.Tag = "Movimiento O/C"
        Me.lblWaybill.Text = "BULTOS"
        '
        'tbpMovimiento_DS
        '
        Me.tbpMovimiento_DS.Controls.Add(Me.dgvMovimiento)
        Me.tbpMovimiento_DS.Location = New System.Drawing.Point(4, 25)
        Me.tbpMovimiento_DS.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpMovimiento_DS.Name = "tbpMovimiento_DS"
        Me.tbpMovimiento_DS.Size = New System.Drawing.Size(1307, 209)
        Me.tbpMovimiento_DS.TabIndex = 3
        Me.tbpMovimiento_DS.Text = "Movimientos"
        Me.tbpMovimiento_DS.UseVisualStyleBackColor = True
        '
        'dgvMovimiento
        '
        Me.dgvMovimiento.AllowUserToAddRows = False
        Me.dgvMovimiento.AllowUserToDeleteRows = False
        Me.dgvMovimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TABTRF, Me.NGUIRN, Me.FECHA, Me.TIPORI, Me.NGUICL, Me.TIPOALMACEN, Me.ALMACEN, Me.ZONA, Me.TOBSRV, Me.TOTAL_ITEM, Me.MOVIMIENTO_DETALLE})
        Me.dgvMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimiento.Location = New System.Drawing.Point(0, 0)
        Me.dgvMovimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMovimiento.Name = "dgvMovimiento"
        Me.dgvMovimiento.ReadOnly = True
        Me.dgvMovimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimiento.Size = New System.Drawing.Size(1307, 209)
        Me.dgvMovimiento.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvMovimiento.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvMovimiento.TabIndex = 32
        '
        'TABTRF
        '
        Me.TABTRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TABTRF.DataPropertyName = "TABTRF"
        Me.TABTRF.HeaderText = "Tipo Movimiento"
        Me.TABTRF.Name = "TABTRF"
        Me.TABTRF.ReadOnly = True
        Me.TABTRF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TABTRF.Width = 133
        '
        'NGUIRN
        '
        Me.NGUIRN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUIRN.DataPropertyName = "NGUIRN"
        Me.NGUIRN.HeaderText = "Nro Guía Ransa"
        Me.NGUIRN.Name = "NGUIRN"
        Me.NGUIRN.ReadOnly = True
        Me.NGUIRN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NGUIRN.Width = 121
        '
        'FECHA
        '
        Me.FECHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECHA.DataPropertyName = "FECHA"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FECHA.DefaultCellStyle = DataGridViewCellStyle11
        Me.FECHA.HeaderText = "Fecha Solicitud"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Width = 142
        '
        'TIPORI
        '
        Me.TIPORI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPORI.DataPropertyName = "TIPORI"
        Me.TIPORI.HeaderText = "Doc. Origen"
        Me.TIPORI.Name = "TIPORI"
        Me.TIPORI.ReadOnly = True
        Me.TIPORI.Width = 121
        '
        'NGUICL
        '
        Me.NGUICL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUICL.DataPropertyName = "NGUICL"
        Me.NGUICL.HeaderText = "Nro. Doc. Origen"
        Me.NGUICL.Name = "NGUICL"
        Me.NGUICL.ReadOnly = True
        Me.NGUICL.Width = 153
        '
        'TIPOALMACEN
        '
        Me.TIPOALMACEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPOALMACEN.DataPropertyName = "TIPOALMACEN"
        Me.TIPOALMACEN.HeaderText = "Tipo Almacen"
        Me.TIPOALMACEN.Name = "TIPOALMACEN"
        Me.TIPOALMACEN.ReadOnly = True
        Me.TIPOALMACEN.Width = 134
        '
        'ALMACEN
        '
        Me.ALMACEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ALMACEN.DataPropertyName = "ALMACEN"
        Me.ALMACEN.HeaderText = "Almacen"
        Me.ALMACEN.Name = "ALMACEN"
        Me.ALMACEN.ReadOnly = True
        '
        'ZONA
        '
        Me.ZONA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ZONA.DataPropertyName = "ZONA"
        Me.ZONA.HeaderText = "Zona"
        Me.ZONA.Name = "ZONA"
        Me.ZONA.ReadOnly = True
        Me.ZONA.Width = 76
        '
        'TOBSRV
        '
        Me.TOBSRV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBSRV.DataPropertyName = "TOBSRV"
        Me.TOBSRV.HeaderText = "Observación"
        Me.TOBSRV.Name = "TOBSRV"
        Me.TOBSRV.ReadOnly = True
        Me.TOBSRV.Width = 124
        '
        'TOTAL_ITEM
        '
        Me.TOTAL_ITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOTAL_ITEM.DataPropertyName = "TOTAL_ITEM"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TOTAL_ITEM.DefaultCellStyle = DataGridViewCellStyle12
        Me.TOTAL_ITEM.HeaderText = "Total Item"
        Me.TOTAL_ITEM.Name = "TOTAL_ITEM"
        Me.TOTAL_ITEM.ReadOnly = True
        Me.TOTAL_ITEM.Width = 109
        '
        'MOVIMIENTO_DETALLE
        '
        Me.MOVIMIENTO_DETALLE.HeaderText = "Movimiento"
        Me.MOVIMIENTO_DETALLE.Image = Global.SOLMIN_SA.My.Resources.Resources.text_block
        Me.MOVIMIENTO_DETALLE.Name = "MOVIMIENTO_DETALLE"
        Me.MOVIMIENTO_DETALLE.ReadOnly = True
        '
        'tbpObservaciones
        '
        Me.tbpObservaciones.Controls.Add(Me.txtObservacion)
        Me.tbpObservaciones.Location = New System.Drawing.Point(4, 25)
        Me.tbpObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpObservaciones.Name = "tbpObservaciones"
        Me.tbpObservaciones.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpObservaciones.Size = New System.Drawing.Size(1307, 209)
        Me.tbpObservaciones.TabIndex = 2
        Me.tbpObservaciones.Text = "Observaciones O/C"
        Me.tbpObservaciones.UseVisualStyleBackColor = True
        '
        'txtObservacion
        '
        Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypeValidator.SetEnterTAB(Me.txtObservacion, True)
        Me.txtObservacion.Location = New System.Drawing.Point(4, 4)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ReadOnly = True
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(1299, 201)
        Me.txtObservacion.TabIndex = 26
        Me.txtObservacion.TabStop = False
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaStatusOcultarFiltros, Me.bsaCerrarVentana})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Margin = New System.Windows.Forms.Padding(4)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
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
        Me.hgFiltros.Size = New System.Drawing.Size(1315, 203)
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
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(904, 10)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(61, 24)
        Me.KryptonLabel3.TabIndex = 13
        Me.KryptonLabel3.Text = "Planta : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(480, 9)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(73, 24)
        Me.KryptonLabel2.TabIndex = 56
        Me.KryptonLabel2.Text = "Division : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Division : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(-1, 10)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(88, 24)
        Me.KryptonLabel1.TabIndex = 55
        Me.KryptonLabel1.Text = "Compañia : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañia : "
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(975, 10)
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
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(240, 28)
        Me.UcPLanta_Cmb011.TabIndex = 14
        Me.UcPLanta_Cmb011.Usuario = ""
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(567, 5)
        Me.UcDivision_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(324, 28)
        Me.UcDivision_Cmb011.TabIndex = 12
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(100, 5)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania2.CCMPN_CodigoCompania = ""
        BeCompania2.Orden = -1
        BeCompania2.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania2
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(349, 31)
        Me.UcCompania_Cmb011.TabIndex = 11
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'cmbPrioridad
        '
        Me.cmbPrioridad.BackColor = System.Drawing.Color.Transparent
        Me.cmbPrioridad.Location = New System.Drawing.Point(100, 132)
        Me.cmbPrioridad.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbPrioridad.Name = "cmbPrioridad"
        Me.cmbPrioridad.pCategoria = "NTPDES"
        Me.cmbPrioridad.pIsRequired = False
        Me.cmbPrioridad.Size = New System.Drawing.Size(349, 28)
        Me.cmbPrioridad.TabIndex = 8
        '
        'lblPrioridad
        '
        Me.lblPrioridad.Location = New System.Drawing.Point(7, 132)
        Me.lblPrioridad.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(81, 24)
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
        Me.txtCliente.Location = New System.Drawing.Point(100, 41)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(349, 26)
        Me.txtCliente.TabIndex = 15
        '
        'lblSituacionOC
        '
        Me.lblSituacionOC.Location = New System.Drawing.Point(471, 130)
        Me.lblSituacionOC.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSituacionOC.Name = "lblSituacionOC"
        Me.lblSituacionOC.Size = New System.Drawing.Size(82, 24)
        Me.lblSituacionOC.TabIndex = 17
        Me.lblSituacionOC.Text = "Situación :"
        Me.lblSituacionOC.Values.ExtraText = ""
        Me.lblSituacionOC.Values.Image = Nothing
        Me.lblSituacionOC.Values.Text = "Situación :"
        '
        'cmbSituacionOC
        '
        Me.cmbSituacionOC.BackColor = System.Drawing.Color.Transparent
        Me.cmbSituacionOC.Location = New System.Drawing.Point(567, 132)
        Me.cmbSituacionOC.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbSituacionOC.Name = "cmbSituacionOC"
        Me.cmbSituacionOC.pCategoria = "SITUOC"
        Me.cmbSituacionOC.pIsRequired = False
        Me.cmbSituacionOC.Size = New System.Drawing.Size(324, 28)
        Me.cmbSituacionOC.TabIndex = 23
        '
        'txtProveedor
        '
        Me.txtProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtProveedor.BackColor = System.Drawing.Color.Transparent
        Me.txtProveedor.Location = New System.Drawing.Point(100, 102)
        Me.txtProveedor.Margin = New System.Windows.Forms.Padding(5)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.pCodigo = CType(0, Long)
        Me.txtProveedor.pMostarBtnNewProv = False
        Me.txtProveedor.pRequerido = False
        Me.txtProveedor.Size = New System.Drawing.Size(349, 26)
        Me.txtProveedor.TabIndex = 19
        '
        'cmbTermInter
        '
        Me.cmbTermInter.BackColor = System.Drawing.Color.Transparent
        Me.cmbTermInter.Location = New System.Drawing.Point(567, 71)
        Me.cmbTermInter.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbTermInter.Name = "cmbTermInter"
        Me.cmbTermInter.pCategoria = "TERINT"
        Me.cmbTermInter.pIsRequired = False
        Me.cmbTermInter.Size = New System.Drawing.Size(324, 26)
        Me.cmbTermInter.TabIndex = 18
        '
        'btnCambiarCliente
        '
        Me.btnCambiarCliente.Location = New System.Drawing.Point(1206, 70)
        Me.btnCambiarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCambiarCliente.Name = "btnCambiarCliente"
        Me.btnCambiarCliente.Size = New System.Drawing.Size(91, 85)
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
        Me.lblDescripcion.Location = New System.Drawing.Point(453, 43)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(99, 24)
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
        Me.TypeValidator.SetEnterTAB(Me.txtDescripcion, True)
        Me.txtDescripcion.Location = New System.Drawing.Point(567, 41)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(324, 26)
        Me.txtDescripcion.TabIndex = 16
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
        Me.lblTerminoInternacional.Location = New System.Drawing.Point(460, 74)
        Me.lblTerminoInternacional.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTerminoInternacional.Name = "lblTerminoInternacional"
        Me.lblTerminoInternacional.Size = New System.Drawing.Size(92, 24)
        Me.lblTerminoInternacional.TabIndex = 11
        Me.lblTerminoInternacional.Text = "Térm. Inter.:"
        Me.lblTerminoInternacional.Values.ExtraText = ""
        Me.lblTerminoInternacional.Values.Image = Nothing
        Me.lblTerminoInternacional.Values.Text = "Térm. Inter.:"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(1108, 69)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(91, 85)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 24
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
        Me.txtFechaFinal.Location = New System.Drawing.Point(793, 102)
        Me.txtFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaFinal.Mask = "00/00/0000"
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaFinal.Size = New System.Drawing.Size(97, 26)
        Me.txtFechaFinal.TabIndex = 22
        Me.txtFechaFinal.Text = "  /  /"
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaInicial.Location = New System.Drawing.Point(567, 102)
        Me.txtFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaInicial.Mask = "00/00/0000"
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaInicial.Size = New System.Drawing.Size(97, 26)
        Me.txtFechaInicial.TabIndex = 20
        Me.txtFechaInicial.Text = "  /  /"
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Location = New System.Drawing.Point(8, 75)
        Me.lblOrdenCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(80, 24)
        Me.lblOrdenCompra.TabIndex = 3
        Me.lblOrdenCompra.Text = "Nro. O/C : "
        Me.lblOrdenCompra.Values.ExtraText = ""
        Me.lblOrdenCompra.Values.Image = Nothing
        Me.lblOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(684, 105)
        Me.lblFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(94, 24)
        Me.lblFechaFinal.TabIndex = 21
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(452, 105)
        Me.lblFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(99, 24)
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
        Me.TypeValidator.SetEnterTAB(Me.txtOrdenCompra, True)
        Me.txtOrdenCompra.Location = New System.Drawing.Point(100, 71)
        Me.txtOrdenCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrdenCompra.MaxLength = 100
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(349, 26)
        Me.txtOrdenCompra.TabIndex = 17
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
        Me.lblCliente.Location = New System.Drawing.Point(23, 44)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 24)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(-3, 106)
        Me.lblProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(89, 24)
        Me.lblProveedor.TabIndex = 5
        Me.lblProveedor.Text = "Proveedor : "
        Me.lblProveedor.Values.ExtraText = ""
        Me.lblProveedor.Values.Image = Nothing
        Me.lblProveedor.Values.Text = "Proveedor : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(1025, 71)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(41, 94)
        Me.KryptonLabel5.TabIndex = 39
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
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
        'frmRecepcionOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 799)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRecepcionOC"
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
        Me.tbpMovimientos.ResumeLayout(False)
        Me.tbpMovimientos.PerformLayout()
        CType(Me.dgMovimientoItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.tbpMovimiento_DS.ResumeLayout(False)
        CType(Me.dgvMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpObservaciones.ResumeLayout(False)
        Me.tbpObservaciones.PerformLayout()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
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
    Friend WithEvents dgOrdenCompra As RANSA.Controls.OrdenCompra.ucOrdenCompra_DgF01
    Friend WithEvents txtProveedor As RANSA.Controls.Proveedor.ucProveedor_TxtF01
    Friend WithEvents cmbTermInter As RANSA.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Private WithEvents lblSituacionOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbSituacionOC As RANSA.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents cmbPrioridad As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Friend WithEvents lblPrioridad As ComponentFactory.Krypton.Toolkit.KryptonLabel

    Friend WithEvents tbcDetalles As System.Windows.Forms.TabControl
    Friend WithEvents tbpDetalle As System.Windows.Forms.TabPage
    Friend WithEvents tbpMovimientos As System.Windows.Forms.TabPage
    Friend WithEvents tbpObservaciones As System.Windows.Forms.TabPage
    Friend WithEvents dgItemsOC As Ransa.Controls.OrdenCompra.ucItemOC_DgF01
    Private WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents dgMovimientoItemOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblWaybill As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tbpMovimiento_DS As System.Windows.Forms.TabPage
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
    Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NOPREC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_INGSDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FECDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NSEQIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QBLTSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPSOBL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QVLBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNVOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRGUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORAGN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DSREFE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CREFFW1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_INGSDA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FECDOC1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRGUSA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QBLTSR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGUIRM1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLGCNL1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCNFCL1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HCNFCL1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IMBULTO As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents M_CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
