<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionSDA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecepcionSDA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgDetalleOSSerie = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaRecepcionSeries = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgSeries = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.R_NSRIE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_NORDSRS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_NORDFS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_TCMPMR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_TMRCSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_QBLTS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_CCLTPB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_PNTKL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_PBRKL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_PNTKLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_PBRKLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_NRGDES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstMercaderia = New System.Data.DataSet
        Me.dtSeleccion = New System.Data.DataTable
        Me.STCMPMR = New System.Data.DataColumn
        Me.SNORDSR = New System.Data.DataColumn
        Me.SNORCCL = New System.Data.DataColumn
        Me.SNGUICL = New System.Data.DataColumn
        Me.SNRUCLL = New System.Data.DataColumn
        Me.SSTPING = New System.Data.DataColumn
        Me.SCTPALM = New System.Data.DataColumn
        Me.STALMC = New System.Data.DataColumn
        Me.SCALMC = New System.Data.DataColumn
        Me.STCMPAL = New System.Data.DataColumn
        Me.SCZNALM = New System.Data.DataColumn
        Me.STCMZNA = New System.Data.DataColumn
        Me.SQTRMC = New System.Data.DataColumn
        Me.SQTRMP = New System.Data.DataColumn
        Me.SCCNTD = New System.Data.DataColumn
        Me.SCTPOCN = New System.Data.DataColumn
        Me.SFUNDS3 = New System.Data.DataColumn
        Me.STOBSRV = New System.Data.DataColumn
        Me.SNPDDPR = New System.Data.DataColumn
        Me.SNSRIE = New System.Data.DataColumn
        Me.SQTRMC_NSRIE = New System.Data.DataColumn
        Me.SQTRMP_NSRIE = New System.Data.DataColumn
        Me.STOBSG = New System.Data.DataColumn
        Me.SNSLCSR = New System.Data.DataColumn
        Me.SSINLBS = New System.Data.DataColumn
        Me.SCEQMNS = New System.Data.DataColumn
        Me.STCMEQM = New System.Data.DataColumn
        Me.dtOrdenesServicios = New System.Data.DataTable
        Me.MNORDSR = New System.Data.DataColumn
        Me.MNCNTR = New System.Data.DataColumn
        Me.MNCRCTC = New System.Data.DataColumn
        Me.MNAUTR = New System.Data.DataColumn
        Me.MCMRCD = New System.Data.DataColumn
        Me.MTCMPMR = New System.Data.DataColumn
        Me.MFEMORS = New System.Data.DataColumn
        Me.MFUNDS2 = New System.Data.DataColumn
        Me.MSTUNE1 = New System.Data.DataColumn
        Me.MNPDDPR = New System.Data.DataColumn
        Me.MQSLMC = New System.Data.DataColumn
        Me.MCUNCN5 = New System.Data.DataColumn
        Me.MQSLMP = New System.Data.DataColumn
        Me.MCUNPS5 = New System.Data.DataColumn
        Me.MQSLMV = New System.Data.DataColumn
        Me.MCUNVL5 = New System.Data.DataColumn
        Me.dtDetalleOS = New System.Data.DataTable
        Me.MNSLCSR = New System.Data.DataColumn
        Me.MNGUICL = New System.Data.DataColumn
        Me.MNPLCCM = New System.Data.DataColumn
        Me.MCTPALM = New System.Data.DataColumn
        Me.MTALMC = New System.Data.DataColumn
        Me.MCALMC = New System.Data.DataColumn
        Me.MTCMPAL = New System.Data.DataColumn
        Me.MFRLZSR = New System.Data.DataColumn
        Me.MFUNDS3 = New System.Data.DataColumn
        Me.MSINLBS = New System.Data.DataColumn
        Me.MQSLMC1 = New System.Data.DataColumn
        Me.MCUNCN6 = New System.Data.DataColumn
        Me.MQSLMP1 = New System.Data.DataColumn
        Me.MCUNPS6 = New System.Data.DataColumn
        Me.MCTPOCN = New System.Data.DataColumn
        Me.dtSeries = New System.Data.DataTable
        Me.RNSRIE = New System.Data.DataColumn
        Me.RNORDSRS = New System.Data.DataColumn
        Me.RNORDFS = New System.Data.DataColumn
        Me.RCMRCD = New System.Data.DataColumn
        Me.RTCMPMR = New System.Data.DataColumn
        Me.RTMRCSR = New System.Data.DataColumn
        Me.RQBLTS = New System.Data.DataColumn
        Me.RCCLTPB = New System.Data.DataColumn
        Me.RPNTKL = New System.Data.DataColumn
        Me.RPBRKL = New System.Data.DataColumn
        Me.RQBLTSR = New System.Data.DataColumn
        Me.RPNTKLR = New System.Data.DataColumn
        Me.RPBRKLR = New System.Data.DataColumn
        Me.RNRGDES = New System.Data.DataColumn
        Me.hgDetalleOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaRecepcionar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgDetalleOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NSLCSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NGUICL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCMPAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FRLZSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FUNDS3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SINLBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QSLMC1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNCN6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QSLMP1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNPS6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CTPOCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaRealizarRecepcion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgOrdenesServicios = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCMPMR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FEMORS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_STUNE1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NPDDPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QSLMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QSLMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QSLMV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNVL5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaProcesarRecepcion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.S_TCMPMR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NSLCSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NORCCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NGUICL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NRUCLL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_STPING = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TCMPAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TCMZNA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_QTRMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_QTRMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CCNTD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CTPOCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_FUNDS3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TOBSRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NPDDPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NSRIE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_QTRMC_NSRIE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_QTRMP_NSRIE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TOBSG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_SINLBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CEQMNS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TCMEQM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.txtOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpLeyenda = New System.Windows.Forms.GroupBox
        Me.lblDetalleOpcional = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDetalleObligatorio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOpcional = New System.Windows.Forms.Label
        Me.lblObligatorio = New System.Windows.Forms.Label
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgDetalleOSSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgDetalleOSSerie.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgDetalleOSSerie.Panel.SuspendLayout()
        Me.hgDetalleOSSerie.SuspendLayout()
        CType(Me.dgSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdenesServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDetalleOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgDetalleOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgDetalleOS.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgDetalleOS.Panel.SuspendLayout()
        Me.hgDetalleOS.SuspendLayout()
        CType(Me.dgDetalleOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgOrdenServicio.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgOrdenServicio.Panel.SuspendLayout()
        Me.hgOrdenServicio.SuspendLayout()
        CType(Me.dgOrdenesServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgMercaderiaSeleccionada.Panel.SuspendLayout()
        Me.hgMercaderiaSeleccionada.SuspendLayout()
        CType(Me.dgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.grpLeyenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgDetalleOSSerie)
        Me.KryptonPanel.Controls.Add(Me.hgDetalleOS)
        Me.KryptonPanel.Controls.Add(Me.hgOrdenServicio)
        Me.KryptonPanel.Controls.Add(Me.hgMercaderiaSeleccionada)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(986, 585)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgDetalleOSSerie
        '
        Me.hgDetalleOSSerie.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaRecepcionSeries})
        Me.hgDetalleOSSerie.Cursor = System.Windows.Forms.Cursors.Default
        Me.hgDetalleOSSerie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgDetalleOSSerie.HeaderVisibleSecondary = False
        Me.hgDetalleOSSerie.Location = New System.Drawing.Point(470, 242)
        Me.hgDetalleOSSerie.Name = "hgDetalleOSSerie"
        '
        'hgDetalleOSSerie.Panel
        '
        Me.hgDetalleOSSerie.Panel.Controls.Add(Me.dgSeries)
        Me.hgDetalleOSSerie.Size = New System.Drawing.Size(516, 117)
        Me.hgDetalleOSSerie.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgDetalleOSSerie.TabIndex = 58
        Me.hgDetalleOSSerie.Text = "Detalle de las Series de la O/C"
        Me.hgDetalleOSSerie.ValuesPrimary.Description = ""
        Me.hgDetalleOSSerie.ValuesPrimary.Heading = "Detalle de las Series de la O/C"
        Me.hgDetalleOSSerie.ValuesPrimary.Image = CType(resources.GetObject("hgDetalleOSSerie.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgDetalleOSSerie.ValuesSecondary.Description = ""
        Me.hgDetalleOSSerie.ValuesSecondary.Heading = "Description"
        Me.hgDetalleOSSerie.ValuesSecondary.Image = Nothing
        '
        'bsaRecepcionSeries
        '
        Me.bsaRecepcionSeries.ExtraText = ""
        Me.bsaRecepcionSeries.Image = CType(resources.GetObject("bsaRecepcionSeries.Image"), System.Drawing.Image)
        Me.bsaRecepcionSeries.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaRecepcionSeries.Text = "Recepcionar Series"
        Me.bsaRecepcionSeries.ToolTipImage = Nothing
        Me.bsaRecepcionSeries.UniqueName = "27930AEB8762475527930AEB87624755"
        '
        'dgSeries
        '
        Me.dgSeries.AllowUserToAddRows = False
        Me.dgSeries.AllowUserToDeleteRows = False
        Me.dgSeries.AllowUserToResizeColumns = False
        Me.dgSeries.AllowUserToResizeRows = False
        Me.dgSeries.AutoGenerateColumns = False
        Me.dgSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgSeries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.R_NSRIE, Me.R_NORDSRS, Me.R_NORDFS, Me.R_CMRCD, Me.R_TCMPMR, Me.R_TMRCSR, Me.R_QBLTS, Me.R_CCLTPB, Me.R_PNTKL, Me.R_PBRKL, Me.R_QBLTSR, Me.R_PNTKLR, Me.R_PBRKLR, Me.R_NRGDES})
        Me.dgSeries.DataMember = "dtSeries"
        Me.dgSeries.DataSource = Me.dstMercaderia
        Me.dgSeries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSeries.Location = New System.Drawing.Point(0, 0)
        Me.dgSeries.MultiSelect = False
        Me.dgSeries.Name = "dgSeries"
        Me.dgSeries.ReadOnly = True
        Me.dgSeries.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgSeries.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSeries.Size = New System.Drawing.Size(514, 87)
        Me.dgSeries.StandardTab = True
        Me.dgSeries.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgSeries.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgSeries.TabIndex = 24
        '
        'R_NSRIE
        '
        Me.R_NSRIE.DataPropertyName = "NSRIE"
        Me.R_NSRIE.HeaderText = "Serie"
        Me.R_NSRIE.Name = "R_NSRIE"
        Me.R_NSRIE.ReadOnly = True
        Me.R_NSRIE.Width = 61
        '
        'R_NORDSRS
        '
        Me.R_NORDSRS.DataPropertyName = "NORDSRS"
        Me.R_NORDSRS.HeaderText = "O/S Serie I"
        Me.R_NORDSRS.Name = "R_NORDSRS"
        Me.R_NORDSRS.ReadOnly = True
        Me.R_NORDSRS.Visible = False
        Me.R_NORDSRS.Width = 89
        '
        'R_NORDFS
        '
        Me.R_NORDFS.DataPropertyName = "NORDFS"
        Me.R_NORDFS.HeaderText = "O/S Serie F"
        Me.R_NORDFS.Name = "R_NORDFS"
        Me.R_NORDFS.ReadOnly = True
        Me.R_NORDFS.Width = 92
        '
        'R_CMRCD
        '
        Me.R_CMRCD.DataPropertyName = "CMRCD"
        Me.R_CMRCD.HeaderText = "Mercadería"
        Me.R_CMRCD.Name = "R_CMRCD"
        Me.R_CMRCD.ReadOnly = True
        Me.R_CMRCD.Visible = False
        Me.R_CMRCD.Width = 91
        '
        'R_TCMPMR
        '
        Me.R_TCMPMR.DataPropertyName = "TCMPMR"
        Me.R_TCMPMR.HeaderText = "Mercadería"
        Me.R_TCMPMR.Name = "R_TCMPMR"
        Me.R_TCMPMR.ReadOnly = True
        Me.R_TCMPMR.Width = 93
        '
        'R_TMRCSR
        '
        Me.R_TMRCSR.DataPropertyName = "TMRCSR"
        Me.R_TMRCSR.HeaderText = "Detalle"
        Me.R_TMRCSR.Name = "R_TMRCSR"
        Me.R_TMRCSR.ReadOnly = True
        Me.R_TMRCSR.Width = 72
        '
        'R_QBLTS
        '
        Me.R_QBLTS.DataPropertyName = "QBLTS"
        Me.R_QBLTS.HeaderText = "Cant. Declarada"
        Me.R_QBLTS.Name = "R_QBLTS"
        Me.R_QBLTS.ReadOnly = True
        Me.R_QBLTS.Visible = False
        Me.R_QBLTS.Width = 113
        '
        'R_CCLTPB
        '
        Me.R_CCLTPB.DataPropertyName = "CCLTPB"
        Me.R_CCLTPB.HeaderText = "Unidad"
        Me.R_CCLTPB.Name = "R_CCLTPB"
        Me.R_CCLTPB.ReadOnly = True
        Me.R_CCLTPB.Visible = False
        Me.R_CCLTPB.Width = 70
        '
        'R_PNTKL
        '
        Me.R_PNTKL.DataPropertyName = "PNTKL"
        Me.R_PNTKL.HeaderText = "Peso Neto Declarada"
        Me.R_PNTKL.Name = "R_PNTKL"
        Me.R_PNTKL.ReadOnly = True
        Me.R_PNTKL.Visible = False
        Me.R_PNTKL.Width = 138
        '
        'R_PBRKL
        '
        Me.R_PBRKL.DataPropertyName = "PBRKL"
        Me.R_PBRKL.HeaderText = "Peso Bruto Declarada"
        Me.R_PBRKL.Name = "R_PBRKL"
        Me.R_PBRKL.ReadOnly = True
        Me.R_PBRKL.Visible = False
        Me.R_PBRKL.Width = 140
        '
        'R_QBLTSR
        '
        Me.R_QBLTSR.DataPropertyName = "QBLTSR"
        Me.R_QBLTSR.HeaderText = "Cant. Recep."
        Me.R_QBLTSR.Name = "R_QBLTSR"
        Me.R_QBLTSR.ReadOnly = True
        '
        'R_PNTKLR
        '
        Me.R_PNTKLR.DataPropertyName = "PNTKLR"
        Me.R_PNTKLR.HeaderText = "Peso (N) Recep."
        Me.R_PNTKLR.Name = "R_PNTKLR"
        Me.R_PNTKLR.ReadOnly = True
        Me.R_PNTKLR.Visible = False
        Me.R_PNTKLR.Width = 115
        '
        'R_PBRKLR
        '
        Me.R_PBRKLR.DataPropertyName = "PBRKLR"
        Me.R_PBRKLR.HeaderText = "Peso (B) Recep."
        Me.R_PBRKLR.Name = "R_PBRKLR"
        Me.R_PBRKLR.ReadOnly = True
        Me.R_PBRKLR.Width = 113
        '
        'R_NRGDES
        '
        Me.R_NRGDES.DataPropertyName = "NRGDES"
        Me.R_NRGDES.HeaderText = "Registros"
        Me.R_NRGDES.Name = "R_NRGDES"
        Me.R_NRGDES.ReadOnly = True
        Me.R_NRGDES.Visible = False
        Me.R_NRGDES.Width = 80
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtSeleccion, Me.dtOrdenesServicios, Me.dtDetalleOS, Me.dtSeries})
        '
        'dtSeleccion
        '
        Me.dtSeleccion.Columns.AddRange(New System.Data.DataColumn() {Me.STCMPMR, Me.SNORDSR, Me.SNORCCL, Me.SNGUICL, Me.SNRUCLL, Me.SSTPING, Me.SCTPALM, Me.STALMC, Me.SCALMC, Me.STCMPAL, Me.SCZNALM, Me.STCMZNA, Me.SQTRMC, Me.SQTRMP, Me.SCCNTD, Me.SCTPOCN, Me.SFUNDS3, Me.STOBSRV, Me.SNPDDPR, Me.SNSRIE, Me.SQTRMC_NSRIE, Me.SQTRMP_NSRIE, Me.STOBSG, Me.SNSLCSR, Me.SSINLBS, Me.SCEQMNS, Me.STCMEQM})
        Me.dtSeleccion.TableName = "dtSeleccion"
        '
        'STCMPMR
        '
        Me.STCMPMR.ColumnName = "TCMPMR"
        Me.STCMPMR.DefaultValue = ""
        '
        'SNORDSR
        '
        Me.SNORDSR.ColumnName = "NORDSR"
        Me.SNORDSR.DataType = GetType(Long)
        Me.SNORDSR.DefaultValue = CType(0, Long)
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
        'SFUNDS3
        '
        Me.SFUNDS3.ColumnName = "FUNDS3"
        Me.SFUNDS3.DefaultValue = ""
        '
        'STOBSRV
        '
        Me.STOBSRV.ColumnName = "TOBSRV"
        Me.STOBSRV.DefaultValue = ""
        '
        'SNPDDPR
        '
        Me.SNPDDPR.ColumnName = "NPDDPR"
        Me.SNPDDPR.DataType = GetType(Long)
        Me.SNPDDPR.DefaultValue = CType(0, Long)
        '
        'SNSRIE
        '
        Me.SNSRIE.ColumnName = "NSRIE"
        Me.SNSRIE.DataType = GetType(Integer)
        Me.SNSRIE.DefaultValue = 0
        '
        'SQTRMC_NSRIE
        '
        Me.SQTRMC_NSRIE.ColumnName = "QTRMC_NSRIE"
        Me.SQTRMC_NSRIE.DataType = GetType(Decimal)
        Me.SQTRMC_NSRIE.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'SQTRMP_NSRIE
        '
        Me.SQTRMP_NSRIE.ColumnName = "QTRMP_NSRIE"
        Me.SQTRMP_NSRIE.DataType = GetType(Decimal)
        Me.SQTRMP_NSRIE.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'STOBSG
        '
        Me.STOBSG.ColumnName = "TOBSG"
        Me.STOBSG.DefaultValue = ""
        '
        'SNSLCSR
        '
        Me.SNSLCSR.ColumnName = "NSLCSR"
        Me.SNSLCSR.DataType = GetType(Integer)
        Me.SNSLCSR.DefaultValue = 0
        '
        'SSINLBS
        '
        Me.SSINLBS.ColumnName = "SINLBS"
        Me.SSINLBS.DefaultValue = ""
        '
        'SCEQMNS
        '
        Me.SCEQMNS.ColumnName = "CEQMNS"
        Me.SCEQMNS.DefaultValue = ""
        '
        'STCMEQM
        '
        Me.STCMEQM.ColumnName = "TCMEQM"
        Me.STCMEQM.DefaultValue = ""
        '
        'dtOrdenesServicios
        '
        Me.dtOrdenesServicios.Columns.AddRange(New System.Data.DataColumn() {Me.MNORDSR, Me.MNCNTR, Me.MNCRCTC, Me.MNAUTR, Me.MCMRCD, Me.MTCMPMR, Me.MFEMORS, Me.MFUNDS2, Me.MSTUNE1, Me.MNPDDPR, Me.MQSLMC, Me.MCUNCN5, Me.MQSLMP, Me.MCUNPS5, Me.MQSLMV, Me.MCUNVL5})
        Me.dtOrdenesServicios.TableName = "dtOrdenesServicios"
        '
        'MNORDSR
        '
        Me.MNORDSR.ColumnName = "NORDSR"
        Me.MNORDSR.DataType = GetType(Long)
        Me.MNORDSR.DefaultValue = CType(0, Long)
        '
        'MNCNTR
        '
        Me.MNCNTR.ColumnName = "NCNTR"
        Me.MNCNTR.DataType = GetType(Long)
        Me.MNCNTR.DefaultValue = CType(0, Long)
        '
        'MNCRCTC
        '
        Me.MNCRCTC.ColumnName = "NCRCTC"
        Me.MNCRCTC.DataType = GetType(Long)
        Me.MNCRCTC.DefaultValue = CType(0, Long)
        '
        'MNAUTR
        '
        Me.MNAUTR.ColumnName = "NAUTR"
        Me.MNAUTR.DataType = GetType(Long)
        Me.MNAUTR.DefaultValue = CType(0, Long)
        '
        'MCMRCD
        '
        Me.MCMRCD.ColumnName = "CMRCD"
        '
        'MTCMPMR
        '
        Me.MTCMPMR.ColumnName = "TCMPMR"
        '
        'MFEMORS
        '
        Me.MFEMORS.ColumnName = "FEMORS"
        Me.MFEMORS.DataType = GetType(Date)
        '
        'MFUNDS2
        '
        Me.MFUNDS2.ColumnName = "FUNDS2"
        '
        'MSTUNE1
        '
        Me.MSTUNE1.ColumnName = "STUNE1"
        '
        'MNPDDPR
        '
        Me.MNPDDPR.ColumnName = "NPDDPR"
        Me.MNPDDPR.DataType = GetType(Long)
        Me.MNPDDPR.DefaultValue = CType(0, Long)
        '
        'MQSLMC
        '
        Me.MQSLMC.ColumnName = "QSLMC"
        Me.MQSLMC.DataType = GetType(Decimal)
        Me.MQSLMC.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'MCUNCN5
        '
        Me.MCUNCN5.ColumnName = "CUNCN5"
        '
        'MQSLMP
        '
        Me.MQSLMP.ColumnName = "QSLMP"
        Me.MQSLMP.DataType = GetType(Decimal)
        Me.MQSLMP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'MCUNPS5
        '
        Me.MCUNPS5.ColumnName = "CUNPS5"
        '
        'MQSLMV
        '
        Me.MQSLMV.ColumnName = "QSLMV"
        Me.MQSLMV.DataType = GetType(Decimal)
        Me.MQSLMV.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'MCUNVL5
        '
        Me.MCUNVL5.ColumnName = "CUNVL5"
        '
        'dtDetalleOS
        '
        Me.dtDetalleOS.Columns.AddRange(New System.Data.DataColumn() {Me.MNSLCSR, Me.MNGUICL, Me.MNPLCCM, Me.MCTPALM, Me.MTALMC, Me.MCALMC, Me.MTCMPAL, Me.MFRLZSR, Me.MFUNDS3, Me.MSINLBS, Me.MQSLMC1, Me.MCUNCN6, Me.MQSLMP1, Me.MCUNPS6, Me.MCTPOCN})
        Me.dtDetalleOS.TableName = "dtDetalleOS"
        '
        'MNSLCSR
        '
        Me.MNSLCSR.ColumnName = "NSLCSR"
        Me.MNSLCSR.DataType = GetType(Long)
        Me.MNSLCSR.DefaultValue = CType(0, Long)
        '
        'MNGUICL
        '
        Me.MNGUICL.ColumnName = "NGUICL"
        Me.MNGUICL.DefaultValue = ""
        '
        'MNPLCCM
        '
        Me.MNPLCCM.ColumnName = "NPLCCM"
        Me.MNPLCCM.DefaultValue = ""
        '
        'MCTPALM
        '
        Me.MCTPALM.ColumnName = "CTPALM"
        Me.MCTPALM.DefaultValue = ""
        '
        'MTALMC
        '
        Me.MTALMC.ColumnName = "TALMC"
        Me.MTALMC.DefaultValue = ""
        '
        'MCALMC
        '
        Me.MCALMC.ColumnName = "CALMC"
        Me.MCALMC.DefaultValue = ""
        '
        'MTCMPAL
        '
        Me.MTCMPAL.ColumnName = "TCMPAL"
        Me.MTCMPAL.DefaultValue = ""
        '
        'MFRLZSR
        '
        Me.MFRLZSR.ColumnName = "FRLZSR"
        Me.MFRLZSR.DataType = GetType(Date)
        '
        'MFUNDS3
        '
        Me.MFUNDS3.ColumnName = "FUNDS3"
        '
        'MSINLBS
        '
        Me.MSINLBS.ColumnName = "SINLBS"
        '
        'MQSLMC1
        '
        Me.MQSLMC1.ColumnName = "QSLMC1"
        Me.MQSLMC1.DataType = GetType(Decimal)
        Me.MQSLMC1.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'MCUNCN6
        '
        Me.MCUNCN6.ColumnName = "CUNCN6"
        '
        'MQSLMP1
        '
        Me.MQSLMP1.ColumnName = "QSLMP1"
        Me.MQSLMP1.DataType = GetType(Decimal)
        Me.MQSLMP1.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'MCUNPS6
        '
        Me.MCUNPS6.ColumnName = "CUNPS6"
        '
        'MCTPOCN
        '
        Me.MCTPOCN.ColumnName = "CTPOCN"
        '
        'dtSeries
        '
        Me.dtSeries.Columns.AddRange(New System.Data.DataColumn() {Me.RNSRIE, Me.RNORDSRS, Me.RNORDFS, Me.RCMRCD, Me.RTCMPMR, Me.RTMRCSR, Me.RQBLTS, Me.RCCLTPB, Me.RPNTKL, Me.RPBRKL, Me.RQBLTSR, Me.RPNTKLR, Me.RPBRKLR, Me.RNRGDES})
        Me.dtSeries.TableName = "dtSeries"
        '
        'RNSRIE
        '
        Me.RNSRIE.ColumnName = "NSRIE"
        Me.RNSRIE.DataType = GetType(Integer)
        Me.RNSRIE.DefaultValue = 0
        '
        'RNORDSRS
        '
        Me.RNORDSRS.ColumnName = "NORDSRS"
        Me.RNORDSRS.DataType = GetType(Long)
        Me.RNORDSRS.DefaultValue = CType(0, Long)
        '
        'RNORDFS
        '
        Me.RNORDFS.ColumnName = "NORDFS"
        Me.RNORDFS.DataType = GetType(Long)
        Me.RNORDFS.DefaultValue = CType(0, Long)
        '
        'RCMRCD
        '
        Me.RCMRCD.ColumnName = "CMRCD"
        Me.RCMRCD.DefaultValue = ""
        '
        'RTCMPMR
        '
        Me.RTCMPMR.ColumnName = "TCMPMR"
        Me.RTCMPMR.DefaultValue = ""
        '
        'RTMRCSR
        '
        Me.RTMRCSR.ColumnName = "TMRCSR"
        Me.RTMRCSR.DefaultValue = ""
        '
        'RQBLTS
        '
        Me.RQBLTS.ColumnName = "QBLTS"
        Me.RQBLTS.DataType = GetType(Decimal)
        Me.RQBLTS.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'RCCLTPB
        '
        Me.RCCLTPB.ColumnName = "CCLTPB"
        Me.RCCLTPB.DefaultValue = ""
        '
        'RPNTKL
        '
        Me.RPNTKL.ColumnName = "PNTKL"
        Me.RPNTKL.DataType = GetType(Decimal)
        Me.RPNTKL.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'RPBRKL
        '
        Me.RPBRKL.ColumnName = "PBRKL"
        Me.RPBRKL.DataType = GetType(Decimal)
        Me.RPBRKL.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'RQBLTSR
        '
        Me.RQBLTSR.ColumnName = "QBLTSR"
        Me.RQBLTSR.DataType = GetType(Decimal)
        Me.RQBLTSR.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'RPNTKLR
        '
        Me.RPNTKLR.ColumnName = "PNTKLR"
        Me.RPNTKLR.DataType = GetType(Decimal)
        Me.RPNTKLR.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'RPBRKLR
        '
        Me.RPBRKLR.ColumnName = "PBRKLR"
        Me.RPBRKLR.DataType = GetType(Decimal)
        Me.RPBRKLR.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'RNRGDES
        '
        Me.RNRGDES.ColumnName = "NRGDES"
        Me.RNRGDES.DataType = GetType(Long)
        Me.RNRGDES.DefaultValue = CType(0, Long)
        '
        'hgDetalleOS
        '
        Me.hgDetalleOS.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaRecepcionar})
        Me.hgDetalleOS.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgDetalleOS.HeaderVisibleSecondary = False
        Me.hgDetalleOS.Location = New System.Drawing.Point(470, 125)
        Me.hgDetalleOS.Name = "hgDetalleOS"
        '
        'hgDetalleOS.Panel
        '
        Me.hgDetalleOS.Panel.Controls.Add(Me.dgDetalleOrdenServicio)
        Me.hgDetalleOS.Size = New System.Drawing.Size(516, 117)
        Me.hgDetalleOS.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgDetalleOS.TabIndex = 57
        Me.hgDetalleOS.Text = "Detalle de la O/S"
        Me.hgDetalleOS.ValuesPrimary.Description = ""
        Me.hgDetalleOS.ValuesPrimary.Heading = "Detalle de la O/S"
        Me.hgDetalleOS.ValuesPrimary.Image = CType(resources.GetObject("hgDetalleOS.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgDetalleOS.ValuesSecondary.Description = ""
        Me.hgDetalleOS.ValuesSecondary.Heading = "Description"
        Me.hgDetalleOS.ValuesSecondary.Image = Nothing
        '
        'bsaRecepcionar
        '
        Me.bsaRecepcionar.ExtraText = ""
        Me.bsaRecepcionar.Image = CType(resources.GetObject("bsaRecepcionar.Image"), System.Drawing.Image)
        Me.bsaRecepcionar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaRecepcionar.Text = "Recepcionar"
        Me.bsaRecepcionar.ToolTipImage = Nothing
        Me.bsaRecepcionar.UniqueName = "27930AEB8762475527930AEB87624755"
        '
        'dgDetalleOrdenServicio
        '
        Me.dgDetalleOrdenServicio.AllowUserToAddRows = False
        Me.dgDetalleOrdenServicio.AllowUserToDeleteRows = False
        Me.dgDetalleOrdenServicio.AllowUserToResizeColumns = False
        Me.dgDetalleOrdenServicio.AllowUserToResizeRows = False
        Me.dgDetalleOrdenServicio.AutoGenerateColumns = False
        Me.dgDetalleOrdenServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDetalleOrdenServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NSLCSR, Me.M_NGUICL, Me.M_NPLCCM, Me.M_CTPALM, Me.M_TALMC, Me.M_CALMC, Me.M_TCMPAL, Me.M_FRLZSR, Me.M_FUNDS3, Me.M_SINLBS, Me.M_QSLMC1, Me.M_CUNCN6, Me.M_QSLMP1, Me.M_CUNPS6, Me.M_CTPOCN})
        Me.dgDetalleOrdenServicio.DataMember = "dtDetalleOS"
        Me.dgDetalleOrdenServicio.DataSource = Me.dstMercaderia
        Me.dgDetalleOrdenServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetalleOrdenServicio.Location = New System.Drawing.Point(0, 0)
        Me.dgDetalleOrdenServicio.MultiSelect = False
        Me.dgDetalleOrdenServicio.Name = "dgDetalleOrdenServicio"
        Me.dgDetalleOrdenServicio.ReadOnly = True
        Me.dgDetalleOrdenServicio.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDetalleOrdenServicio.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDetalleOrdenServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetalleOrdenServicio.Size = New System.Drawing.Size(514, 87)
        Me.dgDetalleOrdenServicio.StandardTab = True
        Me.dgDetalleOrdenServicio.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgDetalleOrdenServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgDetalleOrdenServicio.TabIndex = 24
        '
        'M_NSLCSR
        '
        Me.M_NSLCSR.DataPropertyName = "NSLCSR"
        Me.M_NSLCSR.HeaderText = "Nro. Solic."
        Me.M_NSLCSR.Name = "M_NSLCSR"
        Me.M_NSLCSR.ReadOnly = True
        Me.M_NSLCSR.Width = 88
        '
        'M_NGUICL
        '
        Me.M_NGUICL.DataPropertyName = "NGUICL"
        Me.M_NGUICL.HeaderText = "Referencia"
        Me.M_NGUICL.Name = "M_NGUICL"
        Me.M_NGUICL.ReadOnly = True
        Me.M_NGUICL.Width = 90
        '
        'M_NPLCCM
        '
        Me.M_NPLCCM.DataPropertyName = "NPLCCM"
        Me.M_NPLCCM.HeaderText = "Placa"
        Me.M_NPLCCM.Name = "M_NPLCCM"
        Me.M_NPLCCM.ReadOnly = True
        Me.M_NPLCCM.Visible = False
        Me.M_NPLCCM.Width = 63
        '
        'M_CTPALM
        '
        Me.M_CTPALM.DataPropertyName = "CTPALM"
        Me.M_CTPALM.HeaderText = "Tipo Almacén"
        Me.M_CTPALM.Name = "M_CTPALM"
        Me.M_CTPALM.ReadOnly = True
        Me.M_CTPALM.Visible = False
        Me.M_CTPALM.Width = 101
        '
        'M_TALMC
        '
        Me.M_TALMC.DataPropertyName = "TALMC"
        Me.M_TALMC.HeaderText = "Tipo Almacén"
        Me.M_TALMC.Name = "M_TALMC"
        Me.M_TALMC.ReadOnly = True
        Me.M_TALMC.Width = 104
        '
        'M_CALMC
        '
        Me.M_CALMC.DataPropertyName = "CALMC"
        Me.M_CALMC.HeaderText = "Almacén"
        Me.M_CALMC.Name = "M_CALMC"
        Me.M_CALMC.ReadOnly = True
        Me.M_CALMC.Visible = False
        Me.M_CALMC.Width = 77
        '
        'M_TCMPAL
        '
        Me.M_TCMPAL.DataPropertyName = "TCMPAL"
        Me.M_TCMPAL.HeaderText = "Almacén"
        Me.M_TCMPAL.Name = "M_TCMPAL"
        Me.M_TCMPAL.ReadOnly = True
        Me.M_TCMPAL.Width = 79
        '
        'M_FRLZSR
        '
        Me.M_FRLZSR.DataPropertyName = "FRLZSR"
        Me.M_FRLZSR.HeaderText = "Fecha O/S"
        Me.M_FRLZSR.Name = "M_FRLZSR"
        Me.M_FRLZSR.ReadOnly = True
        Me.M_FRLZSR.Width = 88
        '
        'M_FUNDS3
        '
        Me.M_FUNDS3.DataPropertyName = "FUNDS3"
        Me.M_FUNDS3.HeaderText = "Unidad Dep."
        Me.M_FUNDS3.Name = "M_FUNDS3"
        Me.M_FUNDS3.ReadOnly = True
        Me.M_FUNDS3.Visible = False
        Me.M_FUNDS3.Width = 96
        '
        'M_SINLBS
        '
        Me.M_SINLBS.DataPropertyName = "SINLBS"
        Me.M_SINLBS.HeaderText = "Liberación"
        Me.M_SINLBS.Name = "M_SINLBS"
        Me.M_SINLBS.ReadOnly = True
        Me.M_SINLBS.Visible = False
        Me.M_SINLBS.Width = 85
        '
        'M_QSLMC1
        '
        Me.M_QSLMC1.DataPropertyName = "QSLMC1"
        Me.M_QSLMC1.HeaderText = "Cantidad"
        Me.M_QSLMC1.Name = "M_QSLMC1"
        Me.M_QSLMC1.ReadOnly = True
        Me.M_QSLMC1.Width = 83
        '
        'M_CUNCN6
        '
        Me.M_CUNCN6.DataPropertyName = "CUNCN6"
        Me.M_CUNCN6.HeaderText = "Unidad"
        Me.M_CUNCN6.Name = "M_CUNCN6"
        Me.M_CUNCN6.ReadOnly = True
        Me.M_CUNCN6.Width = 74
        '
        'M_QSLMP1
        '
        Me.M_QSLMP1.DataPropertyName = "QSLMP1"
        Me.M_QSLMP1.HeaderText = "Peso"
        Me.M_QSLMP1.Name = "M_QSLMP1"
        Me.M_QSLMP1.ReadOnly = True
        Me.M_QSLMP1.Width = 60
        '
        'M_CUNPS6
        '
        Me.M_CUNPS6.DataPropertyName = "CUNPS6"
        Me.M_CUNPS6.HeaderText = "Unidad"
        Me.M_CUNPS6.Name = "M_CUNPS6"
        Me.M_CUNPS6.ReadOnly = True
        Me.M_CUNPS6.Width = 74
        '
        'M_CTPOCN
        '
        Me.M_CTPOCN.DataPropertyName = "CTPOCN"
        Me.M_CTPOCN.HeaderText = "Desglose"
        Me.M_CTPOCN.Name = "M_CTPOCN"
        Me.M_CTPOCN.ReadOnly = True
        Me.M_CTPOCN.Width = 83
        '
        'hgOrdenServicio
        '
        Me.hgOrdenServicio.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaRealizarRecepcion})
        Me.hgOrdenServicio.Dock = System.Windows.Forms.DockStyle.Left
        Me.hgOrdenServicio.HeaderVisibleSecondary = False
        Me.hgOrdenServicio.Location = New System.Drawing.Point(0, 125)
        Me.hgOrdenServicio.Name = "hgOrdenServicio"
        '
        'hgOrdenServicio.Panel
        '
        Me.hgOrdenServicio.Panel.Controls.Add(Me.dgOrdenesServicios)
        Me.hgOrdenServicio.Size = New System.Drawing.Size(470, 234)
        Me.hgOrdenServicio.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgOrdenServicio.TabIndex = 56
        Me.hgOrdenServicio.Text = "Listado de Mercaderías"
        Me.hgOrdenServicio.ValuesPrimary.Description = ""
        Me.hgOrdenServicio.ValuesPrimary.Heading = "Listado de Mercaderías"
        Me.hgOrdenServicio.ValuesPrimary.Image = CType(resources.GetObject("hgOrdenServicio.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgOrdenServicio.ValuesSecondary.Description = ""
        Me.hgOrdenServicio.ValuesSecondary.Heading = "Description"
        Me.hgOrdenServicio.ValuesSecondary.Image = Nothing
        '
        'bsaRealizarRecepcion
        '
        Me.bsaRealizarRecepcion.ExtraText = ""
        Me.bsaRealizarRecepcion.Image = CType(resources.GetObject("bsaRealizarRecepcion.Image"), System.Drawing.Image)
        Me.bsaRealizarRecepcion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaRealizarRecepcion.Text = "Realizar Recepción"
        Me.bsaRealizarRecepcion.ToolTipImage = Nothing
        Me.bsaRealizarRecepcion.UniqueName = "2C43A835365A43AC2C43A835365A43AC"
        '
        'dgOrdenesServicios
        '
        Me.dgOrdenesServicios.AllowUserToAddRows = False
        Me.dgOrdenesServicios.AllowUserToDeleteRows = False
        Me.dgOrdenesServicios.AllowUserToResizeColumns = False
        Me.dgOrdenesServicios.AllowUserToResizeRows = False
        Me.dgOrdenesServicios.AutoGenerateColumns = False
        Me.dgOrdenesServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgOrdenesServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NORDSR, Me.M_NCNTR, Me.M_NCRCTC, Me.M_NAUTR, Me.M_CMRCD, Me.M_TCMPMR, Me.M_FEMORS, Me.M_FUNDS2, Me.M_STUNE1, Me.M_NPDDPR, Me.M_QSLMC, Me.M_CUNCN5, Me.M_QSLMP, Me.M_CUNPS5, Me.M_QSLMV, Me.M_CUNVL5})
        Me.dgOrdenesServicios.DataMember = "dtOrdenesServicios"
        Me.dgOrdenesServicios.DataSource = Me.dstMercaderia
        Me.dgOrdenesServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrdenesServicios.Location = New System.Drawing.Point(0, 0)
        Me.dgOrdenesServicios.MultiSelect = False
        Me.dgOrdenesServicios.Name = "dgOrdenesServicios"
        Me.dgOrdenesServicios.ReadOnly = True
        Me.dgOrdenesServicios.RowHeadersWidth = 20
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgOrdenesServicios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgOrdenesServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOrdenesServicios.Size = New System.Drawing.Size(468, 204)
        Me.dgOrdenesServicios.StandardTab = True
        Me.dgOrdenesServicios.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgOrdenesServicios.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgOrdenesServicios.TabIndex = 23
        '
        'M_NORDSR
        '
        Me.M_NORDSR.DataPropertyName = "NORDSR"
        Me.M_NORDSR.HeaderText = "Nro. O/S"
        Me.M_NORDSR.Name = "M_NORDSR"
        Me.M_NORDSR.ReadOnly = True
        Me.M_NORDSR.Width = 80
        '
        'M_NCNTR
        '
        Me.M_NCNTR.DataPropertyName = "NCNTR"
        Me.M_NCNTR.HeaderText = "Nro. Contrato"
        Me.M_NCNTR.Name = "M_NCNTR"
        Me.M_NCNTR.ReadOnly = True
        Me.M_NCNTR.Visible = False
        Me.M_NCNTR.Width = 99
        '
        'M_NCRCTC
        '
        Me.M_NCRCTC.DataPropertyName = "NCRCTC"
        Me.M_NCRCTC.HeaderText = "Corr."
        Me.M_NCRCTC.Name = "M_NCRCTC"
        Me.M_NCRCTC.ReadOnly = True
        Me.M_NCRCTC.Visible = False
        Me.M_NCRCTC.Width = 58
        '
        'M_NAUTR
        '
        Me.M_NAUTR.DataPropertyName = "NAUTR"
        Me.M_NAUTR.HeaderText = "Nro. Autorización"
        Me.M_NAUTR.Name = "M_NAUTR"
        Me.M_NAUTR.ReadOnly = True
        Me.M_NAUTR.Visible = False
        Me.M_NAUTR.Width = 117
        '
        'M_CMRCD
        '
        Me.M_CMRCD.DataPropertyName = "CMRCD"
        Me.M_CMRCD.HeaderText = "Mercadería"
        Me.M_CMRCD.Name = "M_CMRCD"
        Me.M_CMRCD.ReadOnly = True
        Me.M_CMRCD.Visible = False
        Me.M_CMRCD.Width = 91
        '
        'M_TCMPMR
        '
        Me.M_TCMPMR.DataPropertyName = "TCMPMR"
        Me.M_TCMPMR.HeaderText = "Mercadería"
        Me.M_TCMPMR.Name = "M_TCMPMR"
        Me.M_TCMPMR.ReadOnly = True
        Me.M_TCMPMR.Width = 93
        '
        'M_FEMORS
        '
        Me.M_FEMORS.DataPropertyName = "FEMORS"
        Me.M_FEMORS.HeaderText = "Fecha Emisión"
        Me.M_FEMORS.Name = "M_FEMORS"
        Me.M_FEMORS.ReadOnly = True
        Me.M_FEMORS.Visible = False
        Me.M_FEMORS.Width = 105
        '
        'M_FUNDS2
        '
        Me.M_FUNDS2.DataPropertyName = "FUNDS2"
        Me.M_FUNDS2.HeaderText = "Unidad Depósito"
        Me.M_FUNDS2.Name = "M_FUNDS2"
        Me.M_FUNDS2.ReadOnly = True
        Me.M_FUNDS2.Visible = False
        Me.M_FUNDS2.Width = 115
        '
        'M_STUNE1
        '
        Me.M_STUNE1.DataPropertyName = "STUNE1"
        Me.M_STUNE1.HeaderText = "Tipo Empaque"
        Me.M_STUNE1.Name = "M_STUNE1"
        Me.M_STUNE1.ReadOnly = True
        Me.M_STUNE1.Visible = False
        Me.M_STUNE1.Width = 105
        '
        'M_NPDDPR
        '
        Me.M_NPDDPR.DataPropertyName = "NPDDPR"
        Me.M_NPDDPR.HeaderText = "Nro. Dep. Ransa"
        Me.M_NPDDPR.Name = "M_NPDDPR"
        Me.M_NPDDPR.ReadOnly = True
        Me.M_NPDDPR.Width = 119
        '
        'M_QSLMC
        '
        Me.M_QSLMC.DataPropertyName = "QSLMC"
        Me.M_QSLMC.HeaderText = "Cantidad"
        Me.M_QSLMC.Name = "M_QSLMC"
        Me.M_QSLMC.ReadOnly = True
        Me.M_QSLMC.Width = 83
        '
        'M_CUNCN5
        '
        Me.M_CUNCN5.DataPropertyName = "CUNCN5"
        Me.M_CUNCN5.HeaderText = "Unidad"
        Me.M_CUNCN5.Name = "M_CUNCN5"
        Me.M_CUNCN5.ReadOnly = True
        Me.M_CUNCN5.Width = 74
        '
        'M_QSLMP
        '
        Me.M_QSLMP.DataPropertyName = "QSLMP"
        Me.M_QSLMP.HeaderText = "Peso"
        Me.M_QSLMP.Name = "M_QSLMP"
        Me.M_QSLMP.ReadOnly = True
        Me.M_QSLMP.Width = 60
        '
        'M_CUNPS5
        '
        Me.M_CUNPS5.DataPropertyName = "CUNPS5"
        Me.M_CUNPS5.HeaderText = "Unidad"
        Me.M_CUNPS5.Name = "M_CUNPS5"
        Me.M_CUNPS5.ReadOnly = True
        Me.M_CUNPS5.Width = 74
        '
        'M_QSLMV
        '
        Me.M_QSLMV.DataPropertyName = "QSLMV"
        Me.M_QSLMV.HeaderText = "Valor"
        Me.M_QSLMV.Name = "M_QSLMV"
        Me.M_QSLMV.ReadOnly = True
        Me.M_QSLMV.Visible = False
        Me.M_QSLMV.Width = 60
        '
        'M_CUNVL5
        '
        Me.M_CUNVL5.DataPropertyName = "CUNVL5"
        Me.M_CUNVL5.HeaderText = "Unidad"
        Me.M_CUNVL5.Name = "M_CUNVL5"
        Me.M_CUNVL5.ReadOnly = True
        Me.M_CUNVL5.Visible = False
        Me.M_CUNVL5.Width = 70
        '
        'hgMercaderiaSeleccionada
        '
        Me.hgMercaderiaSeleccionada.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaProcesarRecepcion})
        Me.hgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgMercaderiaSeleccionada.HeaderVisibleSecondary = False
        Me.hgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 359)
        Me.hgMercaderiaSeleccionada.Name = "hgMercaderiaSeleccionada"
        '
        'hgMercaderiaSeleccionada.Panel
        '
        Me.hgMercaderiaSeleccionada.Panel.Controls.Add(Me.dgMercaderiaSeleccionada)
        Me.hgMercaderiaSeleccionada.Size = New System.Drawing.Size(986, 226)
        Me.hgMercaderiaSeleccionada.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgMercaderiaSeleccionada.TabIndex = 51
        Me.hgMercaderiaSeleccionada.Text = "Mercadería Seleccionada"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Heading = "Mercadería Seleccionada"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Image = CType(resources.GetObject("hgMercaderiaSeleccionada.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Heading = "Description"
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Image = Nothing
        Me.hgMercaderiaSeleccionada.Visible = False
        '
        'bsaProcesarRecepcion
        '
        Me.bsaProcesarRecepcion.ExtraText = ""
        Me.bsaProcesarRecepcion.Image = CType(resources.GetObject("bsaProcesarRecepcion.Image"), System.Drawing.Image)
        Me.bsaProcesarRecepcion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaProcesarRecepcion.Text = "Procesar Recepción"
        Me.bsaProcesarRecepcion.ToolTipImage = Nothing
        Me.bsaProcesarRecepcion.UniqueName = "0F1839EC421141FD0F1839EC421141FD"
        '
        'dgMercaderiaSeleccionada
        '
        Me.dgMercaderiaSeleccionada.AllowUserToAddRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToDeleteRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeColumns = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeRows = False
        Me.dgMercaderiaSeleccionada.AutoGenerateColumns = False
        Me.dgMercaderiaSeleccionada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaSeleccionada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_TCMPMR, Me.S_NORDSR, Me.S_NSLCSR, Me.S_NORCCL, Me.S_NGUICL, Me.S_NRUCLL, Me.S_STPING, Me.S_CTPALM, Me.S_TALMC, Me.S_CALMC, Me.S_TCMPAL, Me.S_CZNALM, Me.S_TCMZNA, Me.S_QTRMC, Me.S_QTRMP, Me.S_CCNTD, Me.S_CTPOCN, Me.S_FUNDS3, Me.S_TOBSRV, Me.S_NPDDPR, Me.S_NSRIE, Me.S_QTRMC_NSRIE, Me.S_QTRMP_NSRIE, Me.S_TOBSG, Me.S_SINLBS, Me.S_CEQMNS, Me.S_TCMEQM})
        Me.dgMercaderiaSeleccionada.DataMember = "dtSeleccion"
        Me.dgMercaderiaSeleccionada.DataSource = Me.dstMercaderia
        Me.dgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderiaSeleccionada.MultiSelect = False
        Me.dgMercaderiaSeleccionada.Name = "dgMercaderiaSeleccionada"
        Me.dgMercaderiaSeleccionada.ReadOnly = True
        Me.dgMercaderiaSeleccionada.RowHeadersWidth = 20
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaSeleccionada.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgMercaderiaSeleccionada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaSeleccionada.Size = New System.Drawing.Size(984, 196)
        Me.dgMercaderiaSeleccionada.StandardTab = True
        Me.dgMercaderiaSeleccionada.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderiaSeleccionada.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderiaSeleccionada.TabIndex = 24
        '
        'S_TCMPMR
        '
        Me.S_TCMPMR.DataPropertyName = "TCMPMR"
        Me.S_TCMPMR.HeaderText = "Mercadería"
        Me.S_TCMPMR.Name = "S_TCMPMR"
        Me.S_TCMPMR.ReadOnly = True
        Me.S_TCMPMR.Width = 93
        '
        'S_NORDSR
        '
        Me.S_NORDSR.DataPropertyName = "NORDSR"
        Me.S_NORDSR.HeaderText = "Nro. O/S"
        Me.S_NORDSR.Name = "S_NORDSR"
        Me.S_NORDSR.ReadOnly = True
        Me.S_NORDSR.Width = 80
        '
        'S_NSLCSR
        '
        Me.S_NSLCSR.DataPropertyName = "NSLCSR"
        Me.S_NSLCSR.HeaderText = "Nro. Solic."
        Me.S_NSLCSR.Name = "S_NSLCSR"
        Me.S_NSLCSR.ReadOnly = True
        Me.S_NSLCSR.Width = 88
        '
        'S_NORCCL
        '
        Me.S_NORCCL.DataPropertyName = "NORCCL"
        Me.S_NORCCL.HeaderText = "Nro. O/C"
        Me.S_NORCCL.Name = "S_NORCCL"
        Me.S_NORCCL.ReadOnly = True
        Me.S_NORCCL.Width = 81
        '
        'S_NGUICL
        '
        Me.S_NGUICL.DataPropertyName = "NGUICL"
        Me.S_NGUICL.HeaderText = "Nro. Guía"
        Me.S_NGUICL.Name = "S_NGUICL"
        Me.S_NGUICL.ReadOnly = True
        Me.S_NGUICL.Width = 85
        '
        'S_NRUCLL
        '
        Me.S_NRUCLL.DataPropertyName = "NRUCLL"
        Me.S_NRUCLL.HeaderText = "Nro. RUC"
        Me.S_NRUCLL.Name = "S_NRUCLL"
        Me.S_NRUCLL.ReadOnly = True
        Me.S_NRUCLL.Width = 83
        '
        'S_STPING
        '
        Me.S_STPING.DataPropertyName = "STPING"
        Me.S_STPING.HeaderText = "Tipo Mov."
        Me.S_STPING.Name = "S_STPING"
        Me.S_STPING.ReadOnly = True
        Me.S_STPING.Width = 86
        '
        'S_CTPALM
        '
        Me.S_CTPALM.DataPropertyName = "CTPALM"
        Me.S_CTPALM.HeaderText = "Tipo Almacén"
        Me.S_CTPALM.Name = "S_CTPALM"
        Me.S_CTPALM.ReadOnly = True
        Me.S_CTPALM.Visible = False
        Me.S_CTPALM.Width = 101
        '
        'S_TALMC
        '
        Me.S_TALMC.DataPropertyName = "TALMC"
        Me.S_TALMC.HeaderText = "Tipo Almacén"
        Me.S_TALMC.Name = "S_TALMC"
        Me.S_TALMC.ReadOnly = True
        Me.S_TALMC.Width = 104
        '
        'S_CALMC
        '
        Me.S_CALMC.DataPropertyName = "CALMC"
        Me.S_CALMC.HeaderText = "Almacén"
        Me.S_CALMC.Name = "S_CALMC"
        Me.S_CALMC.ReadOnly = True
        Me.S_CALMC.Visible = False
        Me.S_CALMC.Width = 77
        '
        'S_TCMPAL
        '
        Me.S_TCMPAL.DataPropertyName = "TCMPAL"
        Me.S_TCMPAL.HeaderText = "Almacén"
        Me.S_TCMPAL.Name = "S_TCMPAL"
        Me.S_TCMPAL.ReadOnly = True
        Me.S_TCMPAL.Width = 79
        '
        'S_CZNALM
        '
        Me.S_CZNALM.DataPropertyName = "CZNALM"
        Me.S_CZNALM.HeaderText = "Zona"
        Me.S_CZNALM.Name = "S_CZNALM"
        Me.S_CZNALM.ReadOnly = True
        Me.S_CZNALM.Visible = False
        Me.S_CZNALM.Width = 61
        '
        'S_TCMZNA
        '
        Me.S_TCMZNA.DataPropertyName = "TCMZNA"
        Me.S_TCMZNA.HeaderText = "Zona"
        Me.S_TCMZNA.Name = "S_TCMZNA"
        Me.S_TCMZNA.ReadOnly = True
        Me.S_TCMZNA.Width = 62
        '
        'S_QTRMC
        '
        Me.S_QTRMC.DataPropertyName = "QTRMC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.S_QTRMC.DefaultCellStyle = DataGridViewCellStyle4
        Me.S_QTRMC.HeaderText = "Cantidad"
        Me.S_QTRMC.Name = "S_QTRMC"
        Me.S_QTRMC.ReadOnly = True
        Me.S_QTRMC.Width = 83
        '
        'S_QTRMP
        '
        Me.S_QTRMP.DataPropertyName = "QTRMP"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.S_QTRMP.DefaultCellStyle = DataGridViewCellStyle5
        Me.S_QTRMP.HeaderText = "Peso"
        Me.S_QTRMP.Name = "S_QTRMP"
        Me.S_QTRMP.ReadOnly = True
        Me.S_QTRMP.Width = 60
        '
        'S_CCNTD
        '
        Me.S_CCNTD.DataPropertyName = "CCNTD"
        Me.S_CCNTD.HeaderText = "Contenedor"
        Me.S_CCNTD.Name = "S_CCNTD"
        Me.S_CCNTD.ReadOnly = True
        Me.S_CCNTD.Visible = False
        Me.S_CCNTD.Width = 91
        '
        'S_CTPOCN
        '
        Me.S_CTPOCN.DataPropertyName = "CTPOCN"
        Me.S_CTPOCN.HeaderText = "Desglose"
        Me.S_CTPOCN.Name = "S_CTPOCN"
        Me.S_CTPOCN.ReadOnly = True
        Me.S_CTPOCN.Width = 83
        '
        'S_FUNDS3
        '
        Me.S_FUNDS3.DataPropertyName = "FUNDS3"
        Me.S_FUNDS3.HeaderText = "Unid. Dep."
        Me.S_FUNDS3.Name = "S_FUNDS3"
        Me.S_FUNDS3.ReadOnly = True
        Me.S_FUNDS3.Visible = False
        Me.S_FUNDS3.Width = 87
        '
        'S_TOBSRV
        '
        Me.S_TOBSRV.DataPropertyName = "TOBSRV"
        Me.S_TOBSRV.HeaderText = "Observación"
        Me.S_TOBSRV.Name = "S_TOBSRV"
        Me.S_TOBSRV.ReadOnly = True
        '
        'S_NPDDPR
        '
        Me.S_NPDDPR.DataPropertyName = "NPDDPR"
        Me.S_NPDDPR.HeaderText = "Nro. Dep. Ransa"
        Me.S_NPDDPR.Name = "S_NPDDPR"
        Me.S_NPDDPR.ReadOnly = True
        Me.S_NPDDPR.Width = 119
        '
        'S_NSRIE
        '
        Me.S_NSRIE.DataPropertyName = "NSRIE"
        Me.S_NSRIE.HeaderText = "Serie"
        Me.S_NSRIE.Name = "S_NSRIE"
        Me.S_NSRIE.ReadOnly = True
        Me.S_NSRIE.Width = 61
        '
        'S_QTRMC_NSRIE
        '
        Me.S_QTRMC_NSRIE.DataPropertyName = "QTRMC_NSRIE"
        Me.S_QTRMC_NSRIE.HeaderText = "Cant. Serie"
        Me.S_QTRMC_NSRIE.Name = "S_QTRMC_NSRIE"
        Me.S_QTRMC_NSRIE.ReadOnly = True
        Me.S_QTRMC_NSRIE.Width = 91
        '
        'S_QTRMP_NSRIE
        '
        Me.S_QTRMP_NSRIE.DataPropertyName = "QTRMP_NSRIE"
        Me.S_QTRMP_NSRIE.HeaderText = "Peso Serie"
        Me.S_QTRMP_NSRIE.Name = "S_QTRMP_NSRIE"
        Me.S_QTRMP_NSRIE.ReadOnly = True
        Me.S_QTRMP_NSRIE.Width = 88
        '
        'S_TOBSG
        '
        Me.S_TOBSG.DataPropertyName = "TOBSG"
        Me.S_TOBSG.HeaderText = "Observación"
        Me.S_TOBSG.Name = "S_TOBSG"
        Me.S_TOBSG.ReadOnly = True
        Me.S_TOBSG.Visible = False
        Me.S_TOBSG.Width = 96
        '
        'S_SINLBS
        '
        Me.S_SINLBS.DataPropertyName = "SINLBS"
        Me.S_SINLBS.HeaderText = "Liberación"
        Me.S_SINLBS.Name = "S_SINLBS"
        Me.S_SINLBS.ReadOnly = True
        Me.S_SINLBS.Visible = False
        Me.S_SINLBS.Width = 85
        '
        'S_CEQMNS
        '
        Me.S_CEQMNS.DataPropertyName = "CEQMNS"
        Me.S_CEQMNS.HeaderText = "Equ. Manipuleo"
        Me.S_CEQMNS.Name = "S_CEQMNS"
        Me.S_CEQMNS.ReadOnly = True
        Me.S_CEQMNS.Visible = False
        Me.S_CEQMNS.Width = 110
        '
        'S_TCMEQM
        '
        Me.S_TCMEQM.DataPropertyName = "TCMEQM"
        Me.S_TCMEQM.HeaderText = "Equ. Manipuleo"
        Me.S_TCMEQM.Name = "S_TCMEQM"
        Me.S_TCMEQM.ReadOnly = True
        Me.S_TCMEQM.Width = 118
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.txtOrdenServicio)
        Me.hgFiltros.Panel.Controls.Add(Me.lblOrdenServicio)
        Me.hgFiltros.Panel.Controls.Add(Me.grpLeyenda)
        Me.hgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(986, 125)
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
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(86, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.Size = New System.Drawing.Size(278, 21)
        Me.txtCliente.TabIndex = 3
        '
        'txtOrdenServicio
        '
        Me.txtOrdenServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtOrdenServicio, True)
        Me.txtOrdenServicio.Location = New System.Drawing.Point(86, 38)
        Me.txtOrdenServicio.Name = "txtOrdenServicio"
        Me.txtOrdenServicio.Size = New System.Drawing.Size(278, 21)
        Me.txtOrdenServicio.TabIndex = 5
        Me.TypeValidator.SetTypes(Me.txtOrdenServicio, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblOrdenServicio
        '
        Me.lblOrdenServicio.Location = New System.Drawing.Point(7, 41)
        Me.lblOrdenServicio.Name = "lblOrdenServicio"
        Me.lblOrdenServicio.Size = New System.Drawing.Size(74, 19)
        Me.lblOrdenServicio.TabIndex = 4
        Me.lblOrdenServicio.Text = "Nro. O/S (s) : "
        Me.lblOrdenServicio.Values.ExtraText = ""
        Me.lblOrdenServicio.Values.Image = Nothing
        Me.lblOrdenServicio.Values.Text = "Nro. O/S (s) : "
        '
        'grpLeyenda
        '
        Me.grpLeyenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLeyenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLeyenda.Controls.Add(Me.lblDetalleOpcional)
        Me.grpLeyenda.Controls.Add(Me.lblDetalleObligatorio)
        Me.grpLeyenda.Controls.Add(Me.lblOpcional)
        Me.grpLeyenda.Controls.Add(Me.lblObligatorio)
        Me.grpLeyenda.Location = New System.Drawing.Point(789, 12)
        Me.grpLeyenda.Name = "grpLeyenda"
        Me.grpLeyenda.Size = New System.Drawing.Size(110, 70)
        Me.grpLeyenda.TabIndex = 6
        Me.grpLeyenda.TabStop = False
        Me.grpLeyenda.Text = "Leyenda"
        Me.grpLeyenda.Visible = False
        '
        'lblDetalleOpcional
        '
        Me.lblDetalleOpcional.Location = New System.Drawing.Point(37, 44)
        Me.lblDetalleOpcional.Name = "lblDetalleOpcional"
        Me.lblDetalleOpcional.Size = New System.Drawing.Size(55, 19)
        Me.lblDetalleOpcional.TabIndex = 10
        Me.lblDetalleOpcional.Text = "Opcional"
        Me.lblDetalleOpcional.Values.ExtraText = ""
        Me.lblDetalleOpcional.Values.Image = Nothing
        Me.lblDetalleOpcional.Values.Text = "Opcional"
        '
        'lblDetalleObligatorio
        '
        Me.lblDetalleObligatorio.Location = New System.Drawing.Point(37, 22)
        Me.lblDetalleObligatorio.Name = "lblDetalleObligatorio"
        Me.lblDetalleObligatorio.Size = New System.Drawing.Size(67, 19)
        Me.lblDetalleObligatorio.TabIndex = 8
        Me.lblDetalleObligatorio.Text = "Obligatorio"
        Me.lblDetalleObligatorio.Values.ExtraText = ""
        Me.lblDetalleObligatorio.Values.Image = Nothing
        Me.lblDetalleObligatorio.Values.Text = "Obligatorio"
        '
        'lblOpcional
        '
        Me.lblOpcional.AutoSize = True
        Me.lblOpcional.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOpcional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOpcional.Location = New System.Drawing.Point(12, 45)
        Me.lblOpcional.Name = "lblOpcional"
        Me.lblOpcional.Size = New System.Drawing.Size(18, 15)
        Me.lblOpcional.TabIndex = 9
        Me.lblOpcional.Text = "   "
        '
        'lblObligatorio
        '
        Me.lblObligatorio.AutoSize = True
        Me.lblObligatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblObligatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblObligatorio.Location = New System.Drawing.Point(12, 22)
        Me.lblObligatorio.Name = "lblObligatorio"
        Me.lblObligatorio.Size = New System.Drawing.Size(18, 15)
        Me.lblObligatorio.TabIndex = 7
        Me.lblObligatorio.Text = "   "
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(905, 13)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 69)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 11
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
        Me.KryptonLabel1.Location = New System.Drawing.Point(7, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(797, 63)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 30)
        Me.KryptonLabel5.TabIndex = 35
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'frmRecepcionSDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 585)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecepcionSDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepción"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.hgDetalleOSSerie.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgDetalleOSSerie.Panel.ResumeLayout(False)
        CType(Me.hgDetalleOSSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgDetalleOSSerie.ResumeLayout(False)
        CType(Me.dgSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdenesServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDetalleOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgDetalleOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgDetalleOS.Panel.ResumeLayout(False)
        CType(Me.hgDetalleOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgDetalleOS.ResumeLayout(False)
        CType(Me.dgDetalleOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgOrdenServicio.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgOrdenServicio.Panel.ResumeLayout(False)
        CType(Me.hgOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgOrdenServicio.ResumeLayout(False)
        CType(Me.dgOrdenesServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.Panel.ResumeLayout(False)
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.ResumeLayout(False)
        CType(Me.dgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
        Me.grpLeyenda.ResumeLayout(False)
        Me.grpLeyenda.PerformLayout()
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
    Friend WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dstMercaderia As System.Data.DataSet
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents grpLeyenda As System.Windows.Forms.GroupBox
    Friend WithEvents lblDetalleObligatorio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOpcional As System.Windows.Forms.Label
    Friend WithEvents lblObligatorio As System.Windows.Forms.Label
    Friend WithEvents lblDetalleOpcional As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents hgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaProcesarRecepcion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtSeleccion As System.Data.DataTable
    Friend WithEvents STCMPMR As System.Data.DataColumn
    Friend WithEvents SNORDSR As System.Data.DataColumn
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
    Friend WithEvents SCCNTD As System.Data.DataColumn
    Friend WithEvents SCTPOCN As System.Data.DataColumn
    Friend WithEvents SFUNDS3 As System.Data.DataColumn
    Friend WithEvents STOBSRV As System.Data.DataColumn
    Friend WithEvents NORDSRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSLCSRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUICLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCCMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSRVCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPMRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TALMCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNPS6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNVL6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUNDS3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtOrdenesServicios As System.Data.DataTable
    Friend WithEvents dtDetalleOS As System.Data.DataTable
    Friend WithEvents MNORDSR As System.Data.DataColumn
    Friend WithEvents MNCNTR As System.Data.DataColumn
    Friend WithEvents MNCRCTC As System.Data.DataColumn
    Friend WithEvents MNAUTR As System.Data.DataColumn
    Friend WithEvents MCMRCD As System.Data.DataColumn
    Friend WithEvents MTCMPMR As System.Data.DataColumn
    Friend WithEvents MFEMORS As System.Data.DataColumn
    Friend WithEvents MNSLCSR As System.Data.DataColumn
    Friend WithEvents MNGUICL As System.Data.DataColumn
    Friend WithEvents MNPLCCM As System.Data.DataColumn
    Friend WithEvents MCTPALM As System.Data.DataColumn
    Friend WithEvents MTALMC As System.Data.DataColumn
    Friend WithEvents MCALMC As System.Data.DataColumn
    Friend WithEvents MTCMPAL As System.Data.DataColumn
    Friend WithEvents txtOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents hgDetalleOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaRecepcionar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgDetalleOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaRealizarRecepcion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgOrdenesServicios As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgDetalleOSSerie As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaRecepcionSeries As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgSeries As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents MFUNDS2 As System.Data.DataColumn
    Friend WithEvents MSTUNE1 As System.Data.DataColumn
    Friend WithEvents MNPDDPR As System.Data.DataColumn
    Friend WithEvents MQSLMC As System.Data.DataColumn
    Friend WithEvents MCUNCN5 As System.Data.DataColumn
    Friend WithEvents MQSLMP As System.Data.DataColumn
    Friend WithEvents MCUNPS5 As System.Data.DataColumn
    Friend WithEvents MQSLMV As System.Data.DataColumn
    Friend WithEvents MCUNVL5 As System.Data.DataColumn
    Friend WithEvents MFRLZSR As System.Data.DataColumn
    Friend WithEvents MFUNDS3 As System.Data.DataColumn
    Friend WithEvents MSINLBS As System.Data.DataColumn
    Friend WithEvents MQSLMC1 As System.Data.DataColumn
    Friend WithEvents MCUNCN6 As System.Data.DataColumn
    Friend WithEvents MQSLMP1 As System.Data.DataColumn
    Friend WithEvents MCUNPS6 As System.Data.DataColumn
    Friend WithEvents MCTPOCN As System.Data.DataColumn
    Friend WithEvents M_NSLCSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGUICL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCMPAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FRLZSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FUNDS3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SINLBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QSLMC1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNCN6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QSLMP1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNPS6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPOCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtSeries As System.Data.DataTable
    Friend WithEvents RNSRIE As System.Data.DataColumn
    Friend WithEvents RNORDSRS As System.Data.DataColumn
    Friend WithEvents RNORDFS As System.Data.DataColumn
    Friend WithEvents RCMRCD As System.Data.DataColumn
    Friend WithEvents RTCMPMR As System.Data.DataColumn
    Friend WithEvents SNPDDPR As System.Data.DataColumn
    Friend WithEvents SNSRIE As System.Data.DataColumn
    Friend WithEvents SQTRMC_NSRIE As System.Data.DataColumn
    Friend WithEvents SQTRMP_NSRIE As System.Data.DataColumn
    Friend WithEvents STOBSG As System.Data.DataColumn
    Friend WithEvents RTMRCSR As System.Data.DataColumn
    Friend WithEvents RQBLTS As System.Data.DataColumn
    Friend WithEvents RCCLTPB As System.Data.DataColumn
    Friend WithEvents RPNTKL As System.Data.DataColumn
    Friend WithEvents RPBRKL As System.Data.DataColumn
    Friend WithEvents RQBLTSR As System.Data.DataColumn
    Friend WithEvents RPNTKLR As System.Data.DataColumn
    Friend WithEvents RPBRKLR As System.Data.DataColumn
    Friend WithEvents SNSLCSR As System.Data.DataColumn
    Friend WithEvents SSINLBS As System.Data.DataColumn
    Friend WithEvents M_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NCRCTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCMPMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FEMORS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FUNDS2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_STUNE1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NPDDPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QSLMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QSLMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QSLMV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNVL5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCEQMNS As System.Data.DataColumn
    Friend WithEvents STCMEQM As System.Data.DataColumn
    Friend WithEvents S_TCMPMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NSLCSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NORCCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NGUICL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NRUCLL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_STPING As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TCMPAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TCMZNA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_QTRMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_QTRMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CCNTD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CTPOCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_FUNDS3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TOBSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NPDDPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NSRIE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_QTRMC_NSRIE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_QTRMP_NSRIE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TOBSG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_SINLBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CEQMNS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TCMEQM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents R_NSRIE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_NORDSRS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_NORDFS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_TCMPMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_TMRCSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_QBLTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_CCLTPB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_PNTKL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_PBRKL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_QBLTSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_PNTKLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_PBRKLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_NRGDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RNRGDES As System.Data.DataColumn
End Class
