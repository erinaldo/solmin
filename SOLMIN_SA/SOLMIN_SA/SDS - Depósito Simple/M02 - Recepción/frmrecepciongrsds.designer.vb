<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrecepciongrsds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrecepciongrsds))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.scrContainer_001 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion()
        Me.dgGR = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.M_NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_FGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_MOTTRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_TNMMDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_TCMPTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NPLACP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NBRVCH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.lblGuiaRemision = New System.Windows.Forms.ToolStripLabel()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tbcDetalle = New System.Windows.Forms.TabControl()
        Me.tbpDetalleItem = New System.Windows.Forms.TabPage()
        Me.dgItGr = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblItemGR = New System.Windows.Forms.ToolStripLabel()
        Me.btnMarcarItems = New System.Windows.Forms.ToolStripButton()
        Me.lblDescripcion = New System.Windows.Forms.ToolStripLabel()
        Me.txtDescripcion = New System.Windows.Forms.ToolStripTextBox()
        Me.btnGenerarRecepcion = New System.Windows.Forms.ToolStripButton()
        Me.tbpMovimiento = New System.Windows.Forms.TabPage()
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
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.txtGuiaSalida = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.chkfecha = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.GrpBoxFechas = New System.Windows.Forms.GroupBox()
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.STOBSRV = New System.Data.DataColumn()
        Me.SCTPDPS = New System.Data.DataColumn()
        Me.SFUNDS2 = New System.Data.DataColumn()
        Me.SCTPOCN = New System.Data.DataColumn()
        Me.SCCNTD = New System.Data.DataColumn()
        Me.SQDSVGN = New System.Data.DataColumn()
        Me.SQTRMP = New System.Data.DataColumn()
        Me.SQTRMC = New System.Data.DataColumn()
        Me.STCMZNA = New System.Data.DataColumn()
        Me.SCZNALM = New System.Data.DataColumn()
        Me.STCMPAL = New System.Data.DataColumn()
        Me.SCALMC = New System.Data.DataColumn()
        Me.STALMC = New System.Data.DataColumn()
        Me.SCTPALM = New System.Data.DataColumn()
        Me.SSTPING = New System.Data.DataColumn()
        Me.SNRUCLL = New System.Data.DataColumn()
        Me.SNGUICL = New System.Data.DataColumn()
        Me.SNORCCL = New System.Data.DataColumn()
        Me.SCUNVLT = New System.Data.DataColumn()
        Me.SCUNPST = New System.Data.DataColumn()
        Me.SCUNCNT = New System.Data.DataColumn()
        Me.SNAUTR = New System.Data.DataColumn()
        Me.SNCRCTC = New System.Data.DataColumn()
        Me.SNCNTR = New System.Data.DataColumn()
        Me.SNORDSR = New System.Data.DataColumn()
        Me.SCMRCD = New System.Data.DataColumn()
        Me.STMRCD2 = New System.Data.DataColumn()
        Me.SCMRCLR = New System.Data.DataColumn()
        Me.dtMercaderiaSeleccionadas = New System.Data.DataTable()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.MSITUAC = New System.Data.DataColumn()
        Me.MSESTRG = New System.Data.DataColumn()
        Me.MSALDO = New System.Data.DataColumn()
        Me.MCMRCD = New System.Data.DataColumn()
        Me.MTMRCD2 = New System.Data.DataColumn()
        Me.MCMRCLR = New System.Data.DataColumn()
        Me.MCGRCLR = New System.Data.DataColumn()
        Me.MCFMCLR = New System.Data.DataColumn()
        Me.MSTASEL = New System.Data.DataColumn()
        Me.dtMercaderia = New System.Data.DataTable()
        Me.dstMercaderia = New System.Data.DataSet()
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
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NROGR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NRITGR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_TCITCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CODPAQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CANT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_TDAITM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_QPEPQT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_VOLUMEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.M_NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_QCNGU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_QCNPEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_QCNREC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_PESOREC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_IMCMR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.M_IMNORS = New System.Windows.Forms.DataGridViewImageColumn()
        Me.M_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CUNVL5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_FCHCRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CTPDPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMRCLR_RZOL11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANT_OS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUBICAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.scrContainer_001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrContainer_001.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scrContainer_001.Panel1.SuspendLayout()
        CType(Me.scrContainer_001.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scrContainer_001.Panel2.SuspendLayout()
        Me.scrContainer_001.SuspendLayout()
        CType(Me.dgGR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.tbcDetalle.SuspendLayout()
        Me.tbpDetalleItem.SuspendLayout()
        CType(Me.dgItGr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.tbpMovimiento.SuspendLayout()
        CType(Me.dgvMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.GrpBoxFechas.SuspendLayout()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonPanel.Size = New System.Drawing.Size(1652, 785)
        Me.KryptonPanel.TabIndex = 0
        '
        'scrContainer_001
        '
        Me.scrContainer_001.Cursor = System.Windows.Forms.Cursors.Default
        Me.scrContainer_001.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scrContainer_001.Location = New System.Drawing.Point(0, 144)
        Me.scrContainer_001.Margin = New System.Windows.Forms.Padding(4)
        Me.scrContainer_001.Name = "scrContainer_001"
        Me.scrContainer_001.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scrContainer_001.Panel1
        '
        Me.scrContainer_001.Panel1.Controls.Add(Me.UcPaginacion1)
        Me.scrContainer_001.Panel1.Controls.Add(Me.dgGR)
        Me.scrContainer_001.Panel1.Controls.Add(Me.tsMenuOpciones)
        '
        'scrContainer_001.Panel2
        '
        Me.scrContainer_001.Panel2.Controls.Add(Me.tbcDetalle)
        Me.scrContainer_001.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile
        Me.scrContainer_001.Size = New System.Drawing.Size(1652, 641)
        Me.scrContainer_001.SplitterDistance = 267
        Me.scrContainer_001.StateTracking.Back.Color1 = System.Drawing.Color.White
        Me.scrContainer_001.TabIndex = 1
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 236)
        Me.UcPaginacion1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(1652, 31)
        Me.UcPaginacion1.TabIndex = 68
        Me.UcPaginacion1.Visible = False
        '
        'dgGR
        '
        Me.dgGR.AllowUserToAddRows = False
        Me.dgGR.AllowUserToDeleteRows = False
        Me.dgGR.AllowUserToResizeRows = False
        Me.dgGR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgGR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NGUIRM, Me.M_CCLNT, Me.M_CCMPN, Me.M_CDVSN, Me.M_CPLNDV, Me.M_FGUIRM, Me.M_MOTTRA, Me.M_TNMMDT, Me.M_SITUAC, Me.M_TCMPTR, Me.M_NPLCCM, Me.M_NPLACP, Me.M_NBRVCH, Me.COL})
        Me.dgGR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGR.Location = New System.Drawing.Point(0, 27)
        Me.dgGR.Margin = New System.Windows.Forms.Padding(4)
        Me.dgGR.MultiSelect = False
        Me.dgGR.Name = "dgGR"
        Me.dgGR.ReadOnly = True
        Me.dgGR.RowHeadersWidth = 20
        Me.dgGR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGR.Size = New System.Drawing.Size(1652, 240)
        Me.dgGR.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGR.TabIndex = 67
        '
        'M_NGUIRM
        '
        Me.M_NGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NGUIRM.DataPropertyName = "NGUIRM"
        Me.M_NGUIRM.HeaderText = "Nro. Guía Remisión"
        Me.M_NGUIRM.Name = "M_NGUIRM"
        Me.M_NGUIRM.ReadOnly = True
        Me.M_NGUIRM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_NGUIRM.Width = 146
        '
        'M_CCLNT
        '
        Me.M_CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CCLNT.DataPropertyName = "CCLNT"
        Me.M_CCLNT.HeaderText = "Codigo Cliente"
        Me.M_CCLNT.Name = "M_CCLNT"
        Me.M_CCLNT.ReadOnly = True
        Me.M_CCLNT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_CCLNT.Visible = False
        '
        'M_CCMPN
        '
        Me.M_CCMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CCMPN.DataPropertyName = "CCMPN"
        Me.M_CCMPN.HeaderText = "Compañia"
        Me.M_CCMPN.Name = "M_CCMPN"
        Me.M_CCMPN.ReadOnly = True
        Me.M_CCMPN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_CCMPN.Visible = False
        '
        'M_CDVSN
        '
        Me.M_CDVSN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CDVSN.DataPropertyName = "CDVSN"
        Me.M_CDVSN.HeaderText = "Division"
        Me.M_CDVSN.Name = "M_CDVSN"
        Me.M_CDVSN.ReadOnly = True
        Me.M_CDVSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_CDVSN.Visible = False
        '
        'M_CPLNDV
        '
        Me.M_CPLNDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CPLNDV.DataPropertyName = "CPLNDV"
        Me.M_CPLNDV.HeaderText = "Planta"
        Me.M_CPLNDV.Name = "M_CPLNDV"
        Me.M_CPLNDV.ReadOnly = True
        Me.M_CPLNDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_CPLNDV.Visible = False
        '
        'M_FGUIRM
        '
        Me.M_FGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FGUIRM.DataPropertyName = "FGUIRM"
        Me.M_FGUIRM.HeaderText = "Fecha G. Remisión"
        Me.M_FGUIRM.Name = "M_FGUIRM"
        Me.M_FGUIRM.ReadOnly = True
        Me.M_FGUIRM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_FGUIRM.Width = 139
        '
        'M_MOTTRA
        '
        Me.M_MOTTRA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_MOTTRA.DataPropertyName = "MOTTRA"
        Me.M_MOTTRA.HeaderText = "Motivo Traslado"
        Me.M_MOTTRA.Name = "M_MOTTRA"
        Me.M_MOTTRA.ReadOnly = True
        Me.M_MOTTRA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_MOTTRA.Width = 126
        '
        'M_TNMMDT
        '
        Me.M_TNMMDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TNMMDT.DataPropertyName = "TNMMDT"
        Me.M_TNMMDT.HeaderText = "Medio de Envío"
        Me.M_TNMMDT.Name = "M_TNMMDT"
        Me.M_TNMMDT.ReadOnly = True
        Me.M_TNMMDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_TNMMDT.Width = 123
        '
        'M_SITUAC
        '
        Me.M_SITUAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_SITUAC.DataPropertyName = "SITUAC"
        Me.M_SITUAC.HeaderText = "Situación"
        Me.M_SITUAC.Name = "M_SITUAC"
        Me.M_SITUAC.ReadOnly = True
        Me.M_SITUAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_SITUAC.Width = 80
        '
        'M_TCMPTR
        '
        Me.M_TCMPTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TCMPTR.DataPropertyName = "TCMPTR"
        Me.M_TCMPTR.HeaderText = "Transportista"
        Me.M_TCMPTR.Name = "M_TCMPTR"
        Me.M_TCMPTR.ReadOnly = True
        Me.M_TCMPTR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_TCMPTR.Width = 104
        '
        'M_NPLCCM
        '
        Me.M_NPLCCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NPLCCM.DataPropertyName = "NPLCCM"
        Me.M_NPLCCM.HeaderText = "Tracto"
        Me.M_NPLCCM.Name = "M_NPLCCM"
        Me.M_NPLCCM.ReadOnly = True
        Me.M_NPLCCM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_NPLCCM.Width = 60
        '
        'M_NPLACP
        '
        Me.M_NPLACP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NPLACP.DataPropertyName = "NPLACP"
        Me.M_NPLACP.HeaderText = "Acoplado"
        Me.M_NPLACP.Name = "M_NPLACP"
        Me.M_NPLACP.ReadOnly = True
        Me.M_NPLACP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_NPLACP.Width = 84
        '
        'M_NBRVCH
        '
        Me.M_NBRVCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NBRVCH.DataPropertyName = "NBRVCH"
        Me.M_NBRVCH.HeaderText = " Brevete"
        Me.M_NBRVCH.Name = "M_NBRVCH"
        Me.M_NBRVCH.ReadOnly = True
        Me.M_NBRVCH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_NBRVCH.Width = 73
        '
        'COL
        '
        Me.COL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.COL.HeaderText = ""
        Me.COL.Name = "COL"
        Me.COL.ReadOnly = True
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblGuiaRemision, Me.btnBuscar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(1652, 27)
        Me.tsMenuOpciones.TabIndex = 66
        '
        'lblGuiaRemision
        '
        Me.lblGuiaRemision.BackColor = System.Drawing.Color.Transparent
        Me.lblGuiaRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblGuiaRemision.Name = "lblGuiaRemision"
        Me.lblGuiaRemision.Size = New System.Drawing.Size(150, 24)
        Me.lblGuiaRemision.Tag = "GUÍA DE REMISIÓN"
        Me.lblGuiaRemision.Text = "GUÍA DE REMISIÓN"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'tbcDetalle
        '
        Me.tbcDetalle.Controls.Add(Me.tbpDetalleItem)
        Me.tbcDetalle.Controls.Add(Me.tbpMovimiento)
        Me.tbcDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcDetalle.Location = New System.Drawing.Point(0, 0)
        Me.tbcDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcDetalle.Name = "tbcDetalle"
        Me.tbcDetalle.SelectedIndex = 0
        Me.tbcDetalle.Size = New System.Drawing.Size(1652, 369)
        Me.tbcDetalle.TabIndex = 0
        '
        'tbpDetalleItem
        '
        Me.tbpDetalleItem.Controls.Add(Me.dgItGr)
        Me.tbpDetalleItem.Controls.Add(Me.ToolStrip1)
        Me.tbpDetalleItem.Location = New System.Drawing.Point(4, 25)
        Me.tbpDetalleItem.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpDetalleItem.Name = "tbpDetalleItem"
        Me.tbpDetalleItem.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpDetalleItem.Size = New System.Drawing.Size(1644, 340)
        Me.tbpDetalleItem.TabIndex = 0
        Me.tbpDetalleItem.Text = "Detalle Ítem"
        Me.tbpDetalleItem.UseVisualStyleBackColor = True
        '
        'dgItGr
        '
        Me.dgItGr.AllowUserToAddRows = False
        Me.dgItGr.AllowUserToDeleteRows = False
        Me.dgItGr.AllowUserToResizeRows = False
        Me.dgItGr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgItGr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgItGr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CHK, Me.M_NORCML, Me.M_CMRCLR, Me.M_TMRCD2, Me.M_QCNGU, Me.M_TUNDIT, Me.M_QCNPEN, Me.M_QCNREC, Me.M_PESOREC, Me.M_IMCMR, Me.M_IMNORS, Me.M_CMRCD, Me.M_NORDSR, Me.M_CUNCN5, Me.M_CUNPS5, Me.M_CUNVL5, Me.M_FUNDS2, Me.M_NCNTR, Me.M_NCRCTC, Me.M_NAUTR, Me.M_FCHCRT, Me.M_CTPDPS, Me.CMRCLR_RZOL11, Me.TPRVCL, Me.CPRVCL, Me.CANT_OS, Me.FUBICAC, Me.COL2})
        Me.dgItGr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItGr.Location = New System.Drawing.Point(4, 31)
        Me.dgItGr.Margin = New System.Windows.Forms.Padding(4)
        Me.dgItGr.MultiSelect = False
        Me.dgItGr.Name = "dgItGr"
        Me.dgItGr.RowHeadersWidth = 20
        Me.dgItGr.Size = New System.Drawing.Size(1636, 305)
        Me.dgItGr.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgItGr.TabIndex = 68
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblItemGR, Me.btnMarcarItems, Me.lblDescripcion, Me.txtDescripcion, Me.btnGenerarRecepcion})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1636, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblItemGR
        '
        Me.lblItemGR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblItemGR.Name = "lblItemGR"
        Me.lblItemGR.Size = New System.Drawing.Size(64, 24)
        Me.lblItemGR.Text = "ITEM(s)"
        '
        'btnMarcarItems
        '
        Me.btnMarcarItems.BackgroundImage = CType(resources.GetObject("btnMarcarItems.BackgroundImage"), System.Drawing.Image)
        Me.btnMarcarItems.CheckOnClick = True
        Me.btnMarcarItems.Image = CType(resources.GetObject("btnMarcarItems.Image"), System.Drawing.Image)
        Me.btnMarcarItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarcarItems.Name = "btnMarcarItems"
        Me.btnMarcarItems.Size = New System.Drawing.Size(127, 24)
        Me.btnMarcarItems.Text = " &Marcar Todos"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(87, 24)
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(199, 27)
        Me.txtDescripcion.Visible = False
        '
        'btnGenerarRecepcion
        '
        Me.btnGenerarRecepcion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGenerarRecepcion.Image = CType(resources.GetObject("btnGenerarRecepcion.Image"), System.Drawing.Image)
        Me.btnGenerarRecepcion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerarRecepcion.Name = "btnGenerarRecepcion"
        Me.btnGenerarRecepcion.Size = New System.Drawing.Size(158, 24)
        Me.btnGenerarRecepcion.Text = "&Generar Recepción"
        '
        'tbpMovimiento
        '
        Me.tbpMovimiento.Controls.Add(Me.dgvMovimiento)
        Me.tbpMovimiento.Location = New System.Drawing.Point(4, 25)
        Me.tbpMovimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpMovimiento.Name = "tbpMovimiento"
        Me.tbpMovimiento.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpMovimiento.Size = New System.Drawing.Size(1644, 340)
        Me.tbpMovimiento.TabIndex = 1
        Me.tbpMovimiento.Text = "Movimientos"
        Me.tbpMovimiento.UseVisualStyleBackColor = True
        '
        'dgvMovimiento
        '
        Me.dgvMovimiento.AllowUserToAddRows = False
        Me.dgvMovimiento.AllowUserToDeleteRows = False
        Me.dgvMovimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TABTRF, Me.NGUIRN, Me.FECHA, Me.TIPORI, Me.NGUICL, Me.TIPOALMACEN, Me.ALMACEN, Me.ZONA, Me.TOBSRV, Me.TOTAL_ITEM, Me.MOVIMIENTO_DETALLE})
        Me.dgvMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimiento.Location = New System.Drawing.Point(4, 4)
        Me.dgvMovimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMovimiento.Name = "dgvMovimiento"
        Me.dgvMovimiento.ReadOnly = True
        Me.dgvMovimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimiento.Size = New System.Drawing.Size(1636, 332)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FECHA.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TOTAL_ITEM.DefaultCellStyle = DataGridViewCellStyle4
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
        Me.hgFiltros.Panel.Controls.Add(Me.txtGuiaSalida)
        Me.hgFiltros.Panel.Controls.Add(Me.chkfecha)
        Me.hgFiltros.Panel.Controls.Add(Me.txtGuiaRemision)
        Me.hgFiltros.Panel.Controls.Add(Me.GrpBoxFechas)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.hgFiltros.Panel.Controls.Add(Me.lblOrdenCompra)
        Me.hgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Size = New System.Drawing.Size(1652, 144)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 1
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
        'txtGuiaSalida
        '
        Me.txtGuiaSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtGuiaSalida, True)
        Me.txtGuiaSalida.Location = New System.Drawing.Point(1316, 9)
        Me.txtGuiaSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuiaSalida.MaxLength = 100
        Me.txtGuiaSalida.Name = "txtGuiaSalida"
        Me.txtGuiaSalida.Size = New System.Drawing.Size(209, 26)
        Me.txtGuiaSalida.TabIndex = 11
        Me.txtGuiaSalida.Visible = False
        '
        'chkfecha
        '
        Me.chkfecha.Checked = False
        Me.chkfecha.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkfecha.Location = New System.Drawing.Point(409, 44)
        Me.chkfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.chkfecha.Name = "chkfecha"
        Me.chkfecha.Size = New System.Drawing.Size(166, 24)
        Me.chkfecha.TabIndex = 12
        Me.chkfecha.Text = "Fecha Guía Remisión"
        Me.chkfecha.Values.ExtraText = ""
        Me.chkfecha.Values.Image = Nothing
        Me.chkfecha.Values.Text = "Fecha Guía Remisión"
        '
        'txtGuiaRemision
        '
        Me.txtGuiaRemision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtGuiaRemision, True)
        Me.txtGuiaRemision.Location = New System.Drawing.Point(157, 80)
        Me.txtGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuiaRemision.MaxLength = 100
        Me.txtGuiaRemision.Name = "txtGuiaRemision"
        Me.txtGuiaRemision.Size = New System.Drawing.Size(229, 26)
        Me.txtGuiaRemision.TabIndex = 9
        '
        'GrpBoxFechas
        '
        Me.GrpBoxFechas.BackColor = System.Drawing.SystemColors.Window
        Me.GrpBoxFechas.Controls.Add(Me.dteFechaFinal)
        Me.GrpBoxFechas.Controls.Add(Me.dteFechaInicial)
        Me.GrpBoxFechas.Controls.Add(Me.lblFechaFinal)
        Me.GrpBoxFechas.Controls.Add(Me.lblFechaInicial)
        Me.GrpBoxFechas.Enabled = False
        Me.GrpBoxFechas.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GrpBoxFechas.Location = New System.Drawing.Point(409, 55)
        Me.GrpBoxFechas.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpBoxFechas.Name = "GrpBoxFechas"
        Me.GrpBoxFechas.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpBoxFechas.Size = New System.Drawing.Size(486, 51)
        Me.GrpBoxFechas.TabIndex = 13
        Me.GrpBoxFechas.TabStop = False
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Enabled = False
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(347, 18)
        Me.dteFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(115, 22)
        Me.dteFechaFinal.TabIndex = 3
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Enabled = False
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(115, 18)
        Me.dteFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(113, 22)
        Me.dteFechaInicial.TabIndex = 1
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Enabled = False
        Me.lblFechaFinal.Location = New System.Drawing.Point(242, 18)
        Me.lblFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(94, 24)
        Me.lblFechaFinal.TabIndex = 2
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Enabled = False
        Me.lblFechaInicial.Location = New System.Drawing.Point(8, 18)
        Me.lblFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(99, 24)
        Me.lblFechaInicial.TabIndex = 0
        Me.lblFechaInicial.Text = "Fecha Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inicio : "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(15, 78)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(117, 24)
        Me.KryptonLabel4.TabIndex = 8
        Me.KryptonLabel4.Text = "Guía Remisión :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Guía Remisión :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(771, 9)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(61, 24)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Planta : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(409, 16)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(73, 24)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Text = "División : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "División : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(15, 18)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(88, 24)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Compañía : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañía : "
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(1557, 26)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(79, 73)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 40
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        Me.btnActualizar.Visible = False
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Location = New System.Drawing.Point(1204, 11)
        Me.lblOrdenCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(95, 24)
        Me.lblOrdenCompra.TabIndex = 10
        Me.lblOrdenCompra.Text = "Guía Salida :"
        Me.lblOrdenCompra.Values.ExtraText = ""
        Me.lblOrdenCompra.Values.Image = Nothing
        Me.lblOrdenCompra.Values.Text = "Guía Salida :"
        Me.lblOrdenCompra.Visible = False
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(15, 50)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 24)
        Me.lblCliente.TabIndex = 6
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(157, 12)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(229, 28)
        Me.UcCompania_Cmb011.TabIndex = 1
        Me.UcCompania_Cmb011.Usuario = ""
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(521, 12)
        Me.UcDivision_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(209, 28)
        Me.UcDivision_Cmb011.TabIndex = 3
        Me.UcDivision_Cmb011.Usuario = ""
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(846, 9)
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
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(251, 26)
        Me.UcPLanta_Cmb011.TabIndex = 5
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(157, 48)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(229, 26)
        Me.txtCliente.TabIndex = 7
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "MARCRE"
        Me.DataColumn4.DefaultValue = ""
        '
        'STOBSRV
        '
        Me.STOBSRV.ColumnName = "TOBSRV"
        Me.STOBSRV.DefaultValue = ""
        '
        'SCTPDPS
        '
        Me.SCTPDPS.ColumnName = "CTPDPS"
        Me.SCTPDPS.DefaultValue = ""
        '
        'SFUNDS2
        '
        Me.SFUNDS2.ColumnName = "FUNDS2"
        Me.SFUNDS2.DefaultValue = ""
        '
        'SCTPOCN
        '
        Me.SCTPOCN.ColumnName = "CTPOCN"
        Me.SCTPOCN.DefaultValue = ""
        '
        'SCCNTD
        '
        Me.SCCNTD.ColumnName = "CCNTD"
        Me.SCCNTD.DefaultValue = ""
        '
        'SQDSVGN
        '
        Me.SQDSVGN.ColumnName = "QDSVGN"
        Me.SQDSVGN.DataType = GetType(Decimal)
        Me.SQDSVGN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'SQTRMP
        '
        Me.SQTRMP.ColumnName = "QTRMP"
        Me.SQTRMP.DataType = GetType(Decimal)
        Me.SQTRMP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'SQTRMC
        '
        Me.SQTRMC.ColumnName = "QTRMC"
        Me.SQTRMC.DataType = GetType(Decimal)
        Me.SQTRMC.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'STCMZNA
        '
        Me.STCMZNA.ColumnName = "TCMZNA"
        Me.STCMZNA.DefaultValue = ""
        '
        'SCZNALM
        '
        Me.SCZNALM.ColumnName = "CZNALM"
        Me.SCZNALM.DefaultValue = ""
        '
        'STCMPAL
        '
        Me.STCMPAL.ColumnName = "TCMPAL"
        Me.STCMPAL.DefaultValue = ""
        '
        'SCALMC
        '
        Me.SCALMC.ColumnName = "CALMC"
        Me.SCALMC.DefaultValue = ""
        '
        'STALMC
        '
        Me.STALMC.ColumnName = "TALMC"
        Me.STALMC.DefaultValue = ""
        '
        'SCTPALM
        '
        Me.SCTPALM.ColumnName = "CTPALM"
        Me.SCTPALM.DefaultValue = ""
        '
        'SSTPING
        '
        Me.SSTPING.ColumnName = "STPING"
        Me.SSTPING.DefaultValue = ""
        '
        'SNRUCLL
        '
        Me.SNRUCLL.ColumnName = "NRUCLL"
        Me.SNRUCLL.DefaultValue = ""
        '
        'SNGUICL
        '
        Me.SNGUICL.ColumnName = "NGUICL"
        Me.SNGUICL.DefaultValue = ""
        '
        'SNORCCL
        '
        Me.SNORCCL.ColumnName = "NORCCL"
        Me.SNORCCL.DefaultValue = ""
        '
        'SCUNVLT
        '
        Me.SCUNVLT.ColumnName = "CUNVLT"
        Me.SCUNVLT.DefaultValue = ""
        '
        'SCUNPST
        '
        Me.SCUNPST.ColumnName = "CUNPST"
        Me.SCUNPST.DefaultValue = ""
        '
        'SCUNCNT
        '
        Me.SCUNCNT.ColumnName = "CUNCNT"
        '
        'SNAUTR
        '
        Me.SNAUTR.ColumnName = "NAUTR"
        Me.SNAUTR.DataType = GetType(Long)
        Me.SNAUTR.DefaultValue = CType(0, Long)
        '
        'SNCRCTC
        '
        Me.SNCRCTC.ColumnName = "NCRCTC"
        Me.SNCRCTC.DataType = GetType(Long)
        Me.SNCRCTC.DefaultValue = CType(0, Long)
        '
        'SNCNTR
        '
        Me.SNCNTR.ColumnName = "NCNTR"
        Me.SNCNTR.DataType = GetType(Long)
        Me.SNCNTR.DefaultValue = CType(0, Long)
        '
        'SNORDSR
        '
        Me.SNORDSR.ColumnName = "NORDSR"
        Me.SNORDSR.DataType = GetType(Long)
        Me.SNORDSR.DefaultValue = CType(0, Long)
        '
        'SCMRCD
        '
        Me.SCMRCD.ColumnName = "CMRCD"
        Me.SCMRCD.DefaultValue = ""
        '
        'STMRCD2
        '
        Me.STMRCD2.ColumnName = "TMRCD2"
        Me.STMRCD2.DefaultValue = ""
        '
        'SCMRCLR
        '
        Me.SCMRCLR.ColumnName = "CMRCLR"
        Me.SCMRCLR.DefaultValue = ""
        '
        'dtMercaderiaSeleccionadas
        '
        Me.dtMercaderiaSeleccionadas.Columns.AddRange(New System.Data.DataColumn() {Me.SCMRCLR, Me.STMRCD2, Me.SCMRCD, Me.SNORDSR, Me.SNCNTR, Me.SNCRCTC, Me.SNAUTR, Me.SCUNCNT, Me.SCUNPST, Me.SCUNVLT, Me.SNORCCL, Me.SNGUICL, Me.SNRUCLL, Me.SSTPING, Me.SCTPALM, Me.STALMC, Me.SCALMC, Me.STCMPAL, Me.SCZNALM, Me.STCMZNA, Me.SQTRMC, Me.SQTRMP, Me.SQDSVGN, Me.SCCNTD, Me.SCTPOCN, Me.SFUNDS2, Me.SCTPDPS, Me.STOBSRV, Me.DataColumn4})
        Me.dtMercaderiaSeleccionadas.TableName = "dtMercaderiaSeleccionadas"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "MARCRE"
        Me.DataColumn3.DefaultValue = ""
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "TFMCLR"
        Me.DataColumn2.DefaultValue = ""
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "TGRCLR"
        Me.DataColumn1.DefaultValue = ""
        '
        'MSITUAC
        '
        Me.MSITUAC.ColumnName = "SITUAC"
        '
        'MSESTRG
        '
        Me.MSESTRG.ColumnName = "SESTRG"
        '
        'MSALDO
        '
        Me.MSALDO.ColumnName = "SALDO"
        Me.MSALDO.DataType = GetType(Decimal)
        '
        'MCMRCD
        '
        Me.MCMRCD.ColumnName = "CMRCD"
        '
        'MTMRCD2
        '
        Me.MTMRCD2.ColumnName = "TMRCD2"
        '
        'MCMRCLR
        '
        Me.MCMRCLR.ColumnName = "CMRCLR"
        '
        'MCGRCLR
        '
        Me.MCGRCLR.ColumnName = "CGRCLR"
        '
        'MCFMCLR
        '
        Me.MCFMCLR.ColumnName = "CFMCLR"
        '
        'MSTASEL
        '
        Me.MSTASEL.ColumnName = "STASEL"
        Me.MSTASEL.DataType = GetType(Short)
        '
        'dtMercaderia
        '
        Me.dtMercaderia.Columns.AddRange(New System.Data.DataColumn() {Me.MSTASEL, Me.MCFMCLR, Me.MCGRCLR, Me.MCMRCLR, Me.MTMRCD2, Me.MCMRCD, Me.MSALDO, Me.MSESTRG, Me.MSITUAC, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.dtMercaderia.TableName = "dtMercaderia"
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtMercaderia, Me.dtMercaderiaSeleccionadas})
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PSNGUIRM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro. Guía Remisión"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 138
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSFGUIRM_S"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha G. Remisión"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 133
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSSMTGRM"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código MotivoTraslado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 160
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PSMOTTRA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Motivo Traslado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PSSESTRG"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Código Situación"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 127
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PSTNMMDT"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.HeaderText = "Medio de Envio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 118
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PSSITUAC"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn7.HeaderText = "Situación"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 85
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PNNRGUSA"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PNNRGUSA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 98
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PSNPLCCM"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn9.HeaderText = "Transportista"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 104
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PSNPLACP"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 64
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PSNBRVCH"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Acoplado"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 87
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PSCREFFW"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Brevete"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 75
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TPLNTA"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn13.HeaderText = "Nro. O/C"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NOPREC"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nro. Ítem"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "INGSDA"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cód. Paquete"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "CREFFW"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FECDOC"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn17.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CZNALM"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn18.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "NSEQIN"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn20.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PSTUNVOL"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 55
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PSTLUGEN"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Lugar Entrega"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        Me.DataGridViewTextBoxColumn22.Width = 109
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "PNNGRPRV"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Guia Proveedor"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        Me.DataGridViewTextBoxColumn23.Width = 117
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "PSMARRET"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn24.HeaderText = "Custodia Retención"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        Me.DataGridViewTextBoxColumn24.Width = 139
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "PNNRSITEM"
        Me.DataGridViewTextBoxColumn25.HeaderText = "NRSITEM"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        Me.DataGridViewTextBoxColumn25.Width = 85
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "PSCMRCD"
        Me.DataGridViewTextBoxColumn26.HeaderText = "CMRCD"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        Me.DataGridViewTextBoxColumn26.Width = 78
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "PSNORDSR"
        Me.DataGridViewTextBoxColumn27.HeaderText = "NORDSR"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        Me.DataGridViewTextBoxColumn27.Width = 82
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "PSNCNTR"
        Me.DataGridViewTextBoxColumn28.HeaderText = "M_NCNTR"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        Me.DataGridViewTextBoxColumn28.Width = 92
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "PSNCRCTC"
        Me.DataGridViewTextBoxColumn29.HeaderText = "M_NCRCTC"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        Me.DataGridViewTextBoxColumn29.Width = 98
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "PSNAUTR"
        Me.DataGridViewTextBoxColumn30.HeaderText = "M_NAUTR"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        Me.DataGridViewTextBoxColumn30.Width = 91
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "PSCTPDPS"
        Me.DataGridViewTextBoxColumn31.HeaderText = "M_CTPDPS"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 95
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "PSFUNDS2"
        Me.DataGridViewTextBoxColumn32.HeaderText = "M_FUNDS2"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 95
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "PSCUNCN5"
        Me.DataGridViewTextBoxColumn33.HeaderText = "M_CUNCN5"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "PSCUNPS5"
        Me.DataGridViewTextBoxColumn34.HeaderText = "M_CUNPS5"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 96
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "PSCUNVL5"
        Me.DataGridViewTextBoxColumn35.HeaderText = "M_CUNVL5"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 96
        '
        'M_NROGR
        '
        Me.M_NROGR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NROGR.DataPropertyName = "NROGR"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle14.Format = "N5"
        Me.M_NROGR.DefaultCellStyle = DataGridViewCellStyle14
        Me.M_NROGR.HeaderText = "Nro. G/R"
        Me.M_NROGR.MaxInputLength = 10
        Me.M_NROGR.Name = "M_NROGR"
        '
        'M_NRITGR
        '
        Me.M_NRITGR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NRITGR.DataPropertyName = "M_NRITGR"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle15.Format = "N5"
        Me.M_NRITGR.DefaultCellStyle = DataGridViewCellStyle15
        Me.M_NRITGR.HeaderText = "Nro. Ítem"
        Me.M_NRITGR.MaxInputLength = 10
        Me.M_NRITGR.Name = "M_NRITGR"
        '
        'M_TCITCL
        '
        Me.M_TCITCL.HeaderText = "Cód Cliente"
        Me.M_TCITCL.Name = "M_TCITCL"
        Me.M_TCITCL.Visible = False
        '
        'M_CODPAQ
        '
        Me.M_CODPAQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CODPAQ.DataPropertyName = "CODPAQ"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle16.Format = "N5"
        Me.M_CODPAQ.DefaultCellStyle = DataGridViewCellStyle16
        Me.M_CODPAQ.HeaderText = "Cód Paquete"
        Me.M_CODPAQ.MaxInputLength = 10
        Me.M_CODPAQ.Name = "M_CODPAQ"
        '
        'M_DESC
        '
        Me.M_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_DESC.DataPropertyName = "DESC"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle17.Format = "N5"
        Me.M_DESC.DefaultCellStyle = DataGridViewCellStyle17
        Me.M_DESC.HeaderText = "Descripción"
        Me.M_DESC.MaxInputLength = 10
        Me.M_DESC.Name = "M_DESC"
        '
        'M_CANT
        '
        Me.M_CANT.DataPropertyName = "CANT"
        Me.M_CANT.HeaderText = "Cantidad"
        Me.M_CANT.Name = "M_CANT"
        '
        'M_TDAITM
        '
        Me.M_TDAITM.HeaderText = "Observaciones"
        Me.M_TDAITM.Name = "M_TDAITM"
        Me.M_TDAITM.Visible = False
        '
        'M_QPEPQT
        '
        Me.M_QPEPQT.DataPropertyName = "QPEPQT"
        Me.M_QPEPQT.HeaderText = "Peso"
        Me.M_QPEPQT.Name = "M_QPEPQT"
        '
        'M_VOLUMEN
        '
        Me.M_VOLUMEN.DataPropertyName = "VOLUMEN"
        Me.M_VOLUMEN.HeaderText = "Volumen"
        Me.M_VOLUMEN.Name = "M_VOLUMEN"
        '
        'M_CHK
        '
        Me.M_CHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CHK.HeaderText = "CHK"
        Me.M_CHK.Name = "M_CHK"
        Me.M_CHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.M_CHK.Width = 48
        '
        'M_NORCML
        '
        Me.M_NORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NORCML.DataPropertyName = "NORCML"
        Me.M_NORCML.HeaderText = "Nro Orden Compra"
        Me.M_NORCML.Name = "M_NORCML"
        Me.M_NORCML.ReadOnly = True
        Me.M_NORCML.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_NORCML.Width = 146
        '
        'M_CMRCLR
        '
        Me.M_CMRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CMRCLR.DataPropertyName = "CMRCLR"
        Me.M_CMRCLR.HeaderText = "Cód Merc Cliente"
        Me.M_CMRCLR.Name = "M_CMRCLR"
        Me.M_CMRCLR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_CMRCLR.Width = 133
        '
        'M_TMRCD2
        '
        Me.M_TMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TMRCD2.DataPropertyName = "TMRCD2"
        Me.M_TMRCD2.HeaderText = "Descripción Mercadería"
        Me.M_TMRCD2.Name = "M_TMRCD2"
        Me.M_TMRCD2.ReadOnly = True
        Me.M_TMRCD2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_TMRCD2.Width = 176
        '
        'M_QCNGU
        '
        Me.M_QCNGU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNGU.DataPropertyName = "QCNGU"
        Me.M_QCNGU.HeaderText = "Cantidad"
        Me.M_QCNGU.Name = "M_QCNGU"
        Me.M_QCNGU.ReadOnly = True
        Me.M_QCNGU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_QCNGU.Width = 79
        '
        'M_TUNDIT
        '
        Me.M_TUNDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TUNDIT.DataPropertyName = "TUNDIT"
        Me.M_TUNDIT.HeaderText = "Unidad"
        Me.M_TUNDIT.Name = "M_TUNDIT"
        Me.M_TUNDIT.ReadOnly = True
        Me.M_TUNDIT.Width = 90
        '
        'M_QCNPEN
        '
        Me.M_QCNPEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNPEN.DataPropertyName = "QCNPEN"
        Me.M_QCNPEN.HeaderText = "Cantidad Pendiente"
        Me.M_QCNPEN.Name = "M_QCNPEN"
        Me.M_QCNPEN.ReadOnly = True
        Me.M_QCNPEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_QCNPEN.Width = 148
        '
        'M_QCNREC
        '
        Me.M_QCNREC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNREC.DataPropertyName = "QCNREC"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.M_QCNREC.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_QCNREC.HeaderText = "Cantidad Recibida"
        Me.M_QCNREC.Name = "M_QCNREC"
        Me.M_QCNREC.ReadOnly = True
        Me.M_QCNREC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_QCNREC.Width = 141
        '
        'M_PESOREC
        '
        Me.M_PESOREC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.M_PESOREC.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_PESOREC.HeaderText = "Peso Recibido"
        Me.M_PESOREC.Name = "M_PESOREC"
        Me.M_PESOREC.ReadOnly = True
        Me.M_PESOREC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_PESOREC.Width = 112
        '
        'M_IMCMR
        '
        Me.M_IMCMR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IMCMR.DataPropertyName = "IMCMR"
        Me.M_IMCMR.HeaderText = "Mercadería"
        Me.M_IMCMR.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.M_IMCMR.Name = "M_IMCMR"
        Me.M_IMCMR.ReadOnly = True
        Me.M_IMCMR.Width = 94
        '
        'M_IMNORS
        '
        Me.M_IMNORS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IMNORS.DataPropertyName = "IMNORS"
        Me.M_IMNORS.HeaderText = "O/S"
        Me.M_IMNORS.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.M_IMNORS.Name = "M_IMNORS"
        Me.M_IMNORS.ReadOnly = True
        Me.M_IMNORS.Width = 44
        '
        'M_CMRCD
        '
        Me.M_CMRCD.DataPropertyName = "CMRCD"
        Me.M_CMRCD.HeaderText = "Cód. RANSA "
        Me.M_CMRCD.Name = "M_CMRCD"
        Me.M_CMRCD.ReadOnly = True
        Me.M_CMRCD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_CMRCD.Visible = False
        '
        'M_NORDSR
        '
        Me.M_NORDSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NORDSR.DataPropertyName = "NORDSR"
        Me.M_NORDSR.HeaderText = "Nro O / S"
        Me.M_NORDSR.Name = "M_NORDSR"
        Me.M_NORDSR.ReadOnly = True
        Me.M_NORDSR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_NORDSR.Width = 81
        '
        'M_CUNCN5
        '
        Me.M_CUNCN5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CUNCN5.DataPropertyName = "CUNCN5"
        Me.M_CUNCN5.HeaderText = "U. Cantidad O/S"
        Me.M_CUNCN5.Name = "M_CUNCN5"
        Me.M_CUNCN5.ReadOnly = True
        Me.M_CUNCN5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_CUNCN5.Width = 125
        '
        'M_CUNPS5
        '
        Me.M_CUNPS5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CUNPS5.DataPropertyName = "CUNPS5"
        Me.M_CUNPS5.HeaderText = "U. Peso O/S"
        Me.M_CUNPS5.Name = "M_CUNPS5"
        Me.M_CUNPS5.ReadOnly = True
        Me.M_CUNPS5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_CUNPS5.Width = 95
        '
        'M_CUNVL5
        '
        Me.M_CUNVL5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CUNVL5.DataPropertyName = "CUNVL5"
        Me.M_CUNVL5.HeaderText = "U. Volumen O/S"
        Me.M_CUNVL5.Name = "M_CUNVL5"
        Me.M_CUNVL5.ReadOnly = True
        Me.M_CUNVL5.Width = 146
        '
        'M_FUNDS2
        '
        Me.M_FUNDS2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FUNDS2.DataPropertyName = "FUNDS2"
        Me.M_FUNDS2.HeaderText = "U. Despacho O/S"
        Me.M_FUNDS2.Name = "M_FUNDS2"
        Me.M_FUNDS2.ReadOnly = True
        Me.M_FUNDS2.Width = 154
        '
        'M_NCNTR
        '
        Me.M_NCNTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NCNTR.DataPropertyName = "NCNTR"
        Me.M_NCNTR.HeaderText = "Num. Contrato"
        Me.M_NCNTR.Name = "M_NCNTR"
        Me.M_NCNTR.ReadOnly = True
        Me.M_NCNTR.Width = 139
        '
        'M_NCRCTC
        '
        Me.M_NCRCTC.DataPropertyName = "NCRCTC"
        Me.M_NCRCTC.HeaderText = "Num. Corr. Contrato"
        Me.M_NCRCTC.Name = "M_NCRCTC"
        Me.M_NCRCTC.ReadOnly = True
        Me.M_NCRCTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_NCRCTC.Visible = False
        '
        'M_NAUTR
        '
        Me.M_NAUTR.DataPropertyName = "NAUTR"
        Me.M_NAUTR.HeaderText = "Num. Aut. Contrato"
        Me.M_NAUTR.Name = "M_NAUTR"
        Me.M_NAUTR.ReadOnly = True
        Me.M_NAUTR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_NAUTR.Visible = False
        '
        'M_FCHCRT
        '
        Me.M_FCHCRT.DataPropertyName = "FCHCRT"
        Me.M_FCHCRT.HeaderText = "Fecha de Entrega"
        Me.M_FCHCRT.Name = "M_FCHCRT"
        Me.M_FCHCRT.ReadOnly = True
        Me.M_FCHCRT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_FCHCRT.Visible = False
        '
        'M_CTPDPS
        '
        Me.M_CTPDPS.DataPropertyName = "CTPDPS"
        Me.M_CTPDPS.HeaderText = "Tipo Despacho"
        Me.M_CTPDPS.Name = "M_CTPDPS"
        Me.M_CTPDPS.ReadOnly = True
        Me.M_CTPDPS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.M_CTPDPS.Visible = False
        '
        'CMRCLR_RZOL11
        '
        Me.CMRCLR_RZOL11.DataPropertyName = "CMRCLR_RZOL11"
        Me.CMRCLR_RZOL11.HeaderText = "CMRCLR_RZOL11"
        Me.CMRCLR_RZOL11.Name = "CMRCLR_RZOL11"
        Me.CMRCLR_RZOL11.ReadOnly = True
        Me.CMRCLR_RZOL11.Visible = False
        '
        'TPRVCL
        '
        Me.TPRVCL.DataPropertyName = "TPRVCL"
        Me.TPRVCL.HeaderText = "TPRVCL"
        Me.TPRVCL.Name = "TPRVCL"
        Me.TPRVCL.ReadOnly = True
        Me.TPRVCL.Visible = False
        '
        'CPRVCL
        '
        Me.CPRVCL.DataPropertyName = "CPRVCL"
        Me.CPRVCL.HeaderText = "CPRVCL"
        Me.CPRVCL.Name = "CPRVCL"
        Me.CPRVCL.ReadOnly = True
        Me.CPRVCL.Visible = False
        '
        'CANT_OS
        '
        Me.CANT_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANT_OS.DataPropertyName = "CANT_OS"
        Me.CANT_OS.HeaderText = "O/S x SKU"
        Me.CANT_OS.Name = "CANT_OS"
        Me.CANT_OS.ReadOnly = True
        Me.CANT_OS.Width = 109
        '
        'FUBICAC
        '
        Me.FUBICAC.DataPropertyName = "FUBICAC"
        Me.FUBICAC.HeaderText = "FUBICAC"
        Me.FUBICAC.Name = "FUBICAC"
        Me.FUBICAC.ReadOnly = True
        Me.FUBICAC.Visible = False
        '
        'COL2
        '
        Me.COL2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.COL2.HeaderText = " "
        Me.COL2.Name = "COL2"
        Me.COL2.ReadOnly = True
        '
        'frmrecepciongrsds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1652, 785)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmrecepciongrsds"
        Me.Tag = ""
        Me.Text = "Recepción de Guias de Remisión"
        CType(Me.KryptonPanel,System.ComponentModel.ISupportInitialize).EndInit
        Me.KryptonPanel.ResumeLayout(false)
        Me.KryptonPanel.PerformLayout
        CType(Me.scrContainer_001.Panel1,System.ComponentModel.ISupportInitialize).EndInit
        Me.scrContainer_001.Panel1.ResumeLayout(false)
        Me.scrContainer_001.Panel1.PerformLayout
        CType(Me.scrContainer_001.Panel2,System.ComponentModel.ISupportInitialize).EndInit
        Me.scrContainer_001.Panel2.ResumeLayout(false)
        CType(Me.scrContainer_001,System.ComponentModel.ISupportInitialize).EndInit
        Me.scrContainer_001.ResumeLayout(false)
        CType(Me.dgGR,System.ComponentModel.ISupportInitialize).EndInit
        Me.tsMenuOpciones.ResumeLayout(false)
        Me.tsMenuOpciones.PerformLayout
        Me.tbcDetalle.ResumeLayout(false)
        Me.tbpDetalleItem.ResumeLayout(false)
        Me.tbpDetalleItem.PerformLayout
        CType(Me.dgItGr,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.tbpMovimiento.ResumeLayout(false)
        CType(Me.dgvMovimiento,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.hgFiltros.Panel,System.ComponentModel.ISupportInitialize).EndInit
        Me.hgFiltros.Panel.ResumeLayout(false)
        Me.hgFiltros.Panel.PerformLayout
        CType(Me.hgFiltros,System.ComponentModel.ISupportInitialize).EndInit
        Me.hgFiltros.ResumeLayout(false)
        Me.GrpBoxFechas.ResumeLayout(false)
        Me.GrpBoxFechas.PerformLayout
        CType(Me.dtMercaderiaSeleccionadas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dtMercaderia,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dstMercaderia,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub



    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents scrContainer_001 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents lblOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents bsaStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GrpBoxFechas As System.Windows.Forms.GroupBox
    Private WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkfecha As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
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
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents lblGuiaRemision As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dgGR As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tbcDetalle As System.Windows.Forms.TabControl
    Friend WithEvents tbpDetalleItem As System.Windows.Forms.TabPage
    Friend WithEvents tbpMovimiento As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblItemGR As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblDescripcion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtDescripcion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnGenerarRecepcion As System.Windows.Forms.ToolStripButton
    Friend WithEvents M_NROGR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRITGR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCITCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CODPAQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CANT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDAITM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QPEPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents M_TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_VOLUMEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMarcarItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents STOBSRV As System.Data.DataColumn
    Friend WithEvents SCTPDPS As System.Data.DataColumn
    Friend WithEvents SFUNDS2 As System.Data.DataColumn
    Friend WithEvents SCTPOCN As System.Data.DataColumn
    Friend WithEvents SCCNTD As System.Data.DataColumn
    Friend WithEvents SQDSVGN As System.Data.DataColumn
    Friend WithEvents SQTRMP As System.Data.DataColumn
    Friend WithEvents SQTRMC As System.Data.DataColumn
    Friend WithEvents STCMZNA As System.Data.DataColumn
    Friend WithEvents SCZNALM As System.Data.DataColumn
    Friend WithEvents STCMPAL As System.Data.DataColumn
    Friend WithEvents SCALMC As System.Data.DataColumn
    Friend WithEvents STALMC As System.Data.DataColumn
    Friend WithEvents SCTPALM As System.Data.DataColumn
    Friend WithEvents SSTPING As System.Data.DataColumn
    Friend WithEvents SNRUCLL As System.Data.DataColumn
    Friend WithEvents SNGUICL As System.Data.DataColumn
    Friend WithEvents SNORCCL As System.Data.DataColumn
    Friend WithEvents SCUNVLT As System.Data.DataColumn
    Friend WithEvents SCUNPST As System.Data.DataColumn
    Friend WithEvents SCUNCNT As System.Data.DataColumn
    Friend WithEvents SNAUTR As System.Data.DataColumn
    Friend WithEvents SNCRCTC As System.Data.DataColumn
    Friend WithEvents SNCNTR As System.Data.DataColumn
    Friend WithEvents SNORDSR As System.Data.DataColumn
    Friend WithEvents SCMRCD As System.Data.DataColumn
    Friend WithEvents STMRCD2 As System.Data.DataColumn
    Friend WithEvents SCMRCLR As System.Data.DataColumn
    Friend WithEvents dtMercaderiaSeleccionadas As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents MSITUAC As System.Data.DataColumn
    Friend WithEvents MSESTRG As System.Data.DataColumn
    Friend WithEvents MSALDO As System.Data.DataColumn
    Friend WithEvents MCMRCD As System.Data.DataColumn
    Friend WithEvents MTMRCD2 As System.Data.DataColumn
    Friend WithEvents MCMRCLR As System.Data.DataColumn
    Friend WithEvents MCGRCLR As System.Data.DataColumn
    Friend WithEvents MCFMCLR As System.Data.DataColumn
    Friend WithEvents MSTASEL As System.Data.DataColumn
    Friend WithEvents dtMercaderia As System.Data.DataTable
    Friend WithEvents dstMercaderia As System.Data.DataSet
    Friend WithEvents dgItGr As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
    Friend WithEvents txtGuiaSalida As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents M_NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_MOTTRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TNMMDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCMPTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NPLACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NBRVCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents M_NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNGU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNPEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNREC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_PESOREC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IMCMR As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents M_IMNORS As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents M_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNVL5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FUNDS2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NCRCTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FCHCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPDPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCLR_RZOL11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANT_OS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUBICAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
