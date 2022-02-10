<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespachoSDS
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDespachoSDS))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.grpListadoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.dgMercaderias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.M_CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_MARCRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_UBICA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.dtStockPorAlmacen = New System.Data.DataTable()
        Me.DSTASEL = New System.Data.DataColumn()
        Me.DNORDSR = New System.Data.DataColumn()
        Me.DCTPALM = New System.Data.DataColumn()
        Me.DTALMC = New System.Data.DataColumn()
        Me.DCALMC = New System.Data.DataColumn()
        Me.DTCMPAL = New System.Data.DataColumn()
        Me.DCZNALM = New System.Data.DataColumn()
        Me.DTCMZNA = New System.Data.DataColumn()
        Me.DQSLMC2 = New System.Data.DataColumn()
        Me.DCUNCN7 = New System.Data.DataColumn()
        Me.DQSLMP2 = New System.Data.DataColumn()
        Me.DCUNPS7 = New System.Data.DataColumn()
        Me.DQDSVGN = New System.Data.DataColumn()
        Me.DQAUTCN = New System.Data.DataColumn()
        Me.DQAUTPS = New System.Data.DataColumn()
        Me.DSTPING = New System.Data.DataColumn()
        Me.DTOBSRV = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
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
        Me.SFUNDS2 = New System.Data.DataColumn()
        Me.SCTPDPS = New System.Data.DataColumn()
        Me.STOBSRV = New System.Data.DataColumn()
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip()
        Me.tssbAjuste = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssSeparador03 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel()
        Me.btnRealizarDespacho = New System.Windows.Forms.ToolStripButton()
        Me.tssSeparador02 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtFiltroMercaderia = New System.Windows.Forms.ToolStripTextBox()
        Me.lblFiltro = New System.Windows.Forms.ToolStripLabel()
        Me.tssSeparador01 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.hgOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaDespacharMercaderiaOS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaOcultar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.dgListaOrdenesServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.O_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_FEMORS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_CTPDP6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_QSLMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_QSLMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_QSLMV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_CUNVL5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dstOrdenServicio = New System.Data.DataSet()
        Me.dtOrdenServicio = New System.Data.DataTable()
        Me.ONORDSR = New System.Data.DataColumn()
        Me.ONCNTR = New System.Data.DataColumn()
        Me.ONCRCTC = New System.Data.DataColumn()
        Me.ONAUTR = New System.Data.DataColumn()
        Me.OFEMORS = New System.Data.DataColumn()
        Me.OCTPDP6 = New System.Data.DataColumn()
        Me.OQSLMC = New System.Data.DataColumn()
        Me.OCUNCN5 = New System.Data.DataColumn()
        Me.OQSLMP = New System.Data.DataColumn()
        Me.OCUNPS5 = New System.Data.DataColumn()
        Me.OQSLMV = New System.Data.DataColumn()
        Me.OCUNVL5 = New System.Data.DataColumn()
        Me.OFUNDS2 = New System.Data.DataColumn()
        Me.hgAlmacenPorOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.dgStockPorAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.D_STASEL = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.D_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TALMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TCMPAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPLNFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_CZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TCMZNA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_QSLMC2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_QAUTCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_CUNCN7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_QSLMP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_QAUTPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_CUNPS7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_QDSVGN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_STPING = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TOBSRV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaProcesarDespachar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaEliminarItem = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.dgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.S_CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CUNCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CUNPST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CUNVLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NORCCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NGUICL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NRUCLL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_STPING = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_TALMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_TCMPAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_TCMZNA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_QTRMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_QTRMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_QDSVGN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CTPDPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_TOBSRV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.grpLeyenda = New System.Windows.Forms.GroupBox()
        Me.lblDetalleOpcional = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblDetalleObligatorio = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblOpcional = New System.Windows.Forms.Label()
        Me.lblObligatorio = New System.Windows.Forms.Label()
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cbxPublicarWEB = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.lblPublicarWEB = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFamilia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaFamiliaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtGrupo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaGrupoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaInventario = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFechaInventario = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.lblFechaVencimiento = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFechaVencimiento = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.txtMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblMercadaeria = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.grpListadoMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpListadoMercaderia.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpListadoMercaderia.Panel.SuspendLayout()
        Me.grpListadoMercaderia.SuspendLayout()
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStockPorAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspListadoMercaderia.SuspendLayout()
        CType(Me.hgOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgOS.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgOS.Panel.SuspendLayout()
        Me.hgOS.SuspendLayout()
        CType(Me.dgListaOrdenesServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgAlmacenPorOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgAlmacenPorOS.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgAlmacenPorOS.Panel.SuspendLayout()
        Me.hgAlmacenPorOS.SuspendLayout()
        CType(Me.dgStockPorAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonPanel.Controls.Add(Me.grpListadoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.hgOS)
        Me.KryptonPanel.Controls.Add(Me.hgMercaderiaSeleccionada)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1785, 900)
        Me.KryptonPanel.TabIndex = 0
        '
        'grpListadoMercaderia
        '
        Me.grpListadoMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpListadoMercaderia.Location = New System.Drawing.Point(0, 168)
        Me.grpListadoMercaderia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpListadoMercaderia.Name = "grpListadoMercaderia"
        '
        'grpListadoMercaderia.Panel
        '
        Me.grpListadoMercaderia.Panel.Controls.Add(Me.dgMercaderias)
        Me.grpListadoMercaderia.Panel.Controls.Add(Me.tspListadoMercaderia)
        Me.grpListadoMercaderia.Size = New System.Drawing.Size(957, 463)
        Me.grpListadoMercaderia.TabIndex = 54
        '
        'dgMercaderias
        '
        Me.dgMercaderias.AllowUserToAddRows = False
        Me.dgMercaderias.AllowUserToDeleteRows = False
        Me.dgMercaderias.AllowUserToResizeColumns = False
        Me.dgMercaderias.AllowUserToResizeRows = False
        Me.dgMercaderias.AutoGenerateColumns = False
        Me.dgMercaderias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMercaderias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CMRCLR, Me.M_TMRCD2, Me.M_CMRCD, Me.M_SALDO, Me.M_SESTRG, Me.M_MARCRE, Me.M_CGRCLR, Me.M_CFMCLR, Me.M_UBICA1, Me.M_SITUAC})
        Me.dgMercaderias.DataMember = "dtMercaderia"
        Me.dgMercaderias.DataSource = Me.dstMercaderia
        Me.dgMercaderias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderias.Location = New System.Drawing.Point(0, 32)
        Me.dgMercaderias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgMercaderias.MultiSelect = False
        Me.dgMercaderias.Name = "dgMercaderias"
        Me.dgMercaderias.ReadOnly = True
        Me.dgMercaderias.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderias.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgMercaderias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderias.Size = New System.Drawing.Size(955, 429)
        Me.dgMercaderias.StandardTab = True
        Me.dgMercaderias.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderias.TabIndex = 23
        '
        'M_CMRCLR
        '
        Me.M_CMRCLR.DataPropertyName = "CMRCLR"
        Me.M_CMRCLR.HeaderText = "Mercadería"
        Me.M_CMRCLR.MinimumWidth = 60
        Me.M_CMRCLR.Name = "M_CMRCLR"
        Me.M_CMRCLR.ReadOnly = True
        '
        'M_TMRCD2
        '
        Me.M_TMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.M_TMRCD2.DataPropertyName = "TMRCD2"
        Me.M_TMRCD2.HeaderText = "Detalle"
        Me.M_TMRCD2.MinimumWidth = 150
        Me.M_TMRCD2.Name = "M_TMRCD2"
        Me.M_TMRCD2.ReadOnly = True
        '
        'M_CMRCD
        '
        Me.M_CMRCD.DataPropertyName = "CMRCD"
        Me.M_CMRCD.HeaderText = "Cód. RANSA"
        Me.M_CMRCD.Name = "M_CMRCD"
        Me.M_CMRCD.ReadOnly = True
        Me.M_CMRCD.Visible = False
        '
        'M_SALDO
        '
        Me.M_SALDO.DataPropertyName = "SALDO"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.M_SALDO.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_SALDO.HeaderText = "Saldo"
        Me.M_SALDO.MinimumWidth = 15
        Me.M_SALDO.Name = "M_SALDO"
        Me.M_SALDO.ReadOnly = True
        '
        'M_SESTRG
        '
        Me.M_SESTRG.DataPropertyName = "SESTRG"
        Me.M_SESTRG.HeaderText = "Situación"
        Me.M_SESTRG.MinimumWidth = 60
        Me.M_SESTRG.Name = "M_SESTRG"
        Me.M_SESTRG.ReadOnly = True
        Me.M_SESTRG.Visible = False
        '
        'M_MARCRE
        '
        Me.M_MARCRE.DataPropertyName = "MARCRE"
        Me.M_MARCRE.HeaderText = "CD"
        Me.M_MARCRE.MinimumWidth = 10
        Me.M_MARCRE.Name = "M_MARCRE"
        Me.M_MARCRE.ReadOnly = True
        '
        'M_CGRCLR
        '
        Me.M_CGRCLR.DataPropertyName = "TFMCLR"
        Me.M_CGRCLR.HeaderText = "Familia"
        Me.M_CGRCLR.MinimumWidth = 60
        Me.M_CGRCLR.Name = "M_CGRCLR"
        Me.M_CGRCLR.ReadOnly = True
        '
        'M_CFMCLR
        '
        Me.M_CFMCLR.DataPropertyName = "TGRCLR"
        Me.M_CFMCLR.HeaderText = "Grupo"
        Me.M_CFMCLR.MinimumWidth = 60
        Me.M_CFMCLR.Name = "M_CFMCLR"
        Me.M_CFMCLR.ReadOnly = True
        '
        'M_UBICA1
        '
        Me.M_UBICA1.DataPropertyName = "UBICA1"
        Me.M_UBICA1.HeaderText = "Ref. Ubicación"
        Me.M_UBICA1.MinimumWidth = 70
        Me.M_UBICA1.Name = "M_UBICA1"
        Me.M_UBICA1.ReadOnly = True
        '
        'M_SITUAC
        '
        Me.M_SITUAC.DataPropertyName = "SITUAC"
        Me.M_SITUAC.HeaderText = "Situación"
        Me.M_SITUAC.MinimumWidth = 60
        Me.M_SITUAC.Name = "M_SITUAC"
        Me.M_SITUAC.ReadOnly = True
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtMercaderia, Me.dtStockPorAlmacen, Me.dtMercaderiaSeleccionadas})
        '
        'dtMercaderia
        '
        Me.dtMercaderia.Columns.AddRange(New System.Data.DataColumn() {Me.MSTASEL, Me.MCFMCLR, Me.MCGRCLR, Me.MCMRCLR, Me.MTMRCD2, Me.MCMRCD, Me.MSALDO, Me.MSESTRG, Me.MSITUAC, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
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
        'DataColumn4
        '
        Me.DataColumn4.Caption = "UBICA1"
        Me.DataColumn4.ColumnName = "UBICA1"
        Me.DataColumn4.DefaultValue = ""
        '
        'dtStockPorAlmacen
        '
        Me.dtStockPorAlmacen.Columns.AddRange(New System.Data.DataColumn() {Me.DSTASEL, Me.DNORDSR, Me.DCTPALM, Me.DTALMC, Me.DCALMC, Me.DTCMPAL, Me.DCZNALM, Me.DTCMZNA, Me.DQSLMC2, Me.DCUNCN7, Me.DQSLMP2, Me.DCUNPS7, Me.DQDSVGN, Me.DQAUTCN, Me.DQAUTPS, Me.DSTPING, Me.DTOBSRV, Me.DataColumn5, Me.DataColumn6})
        Me.dtStockPorAlmacen.TableName = "dtStockPorAlmacen"
        '
        'DSTASEL
        '
        Me.DSTASEL.ColumnName = "STASEL"
        Me.DSTASEL.DataType = GetType(Integer)
        Me.DSTASEL.DefaultValue = 0
        '
        'DNORDSR
        '
        Me.DNORDSR.ColumnName = "NORDSR"
        Me.DNORDSR.DataType = GetType(Long)
        Me.DNORDSR.DefaultValue = CType(0, Long)
        '
        'DCTPALM
        '
        Me.DCTPALM.ColumnName = "CTPALM"
        '
        'DTALMC
        '
        Me.DTALMC.ColumnName = "TALMC"
        '
        'DCALMC
        '
        Me.DCALMC.ColumnName = "CALMC"
        '
        'DTCMPAL
        '
        Me.DTCMPAL.ColumnName = "TCMPAL"
        '
        'DCZNALM
        '
        Me.DCZNALM.ColumnName = "CZNALM"
        '
        'DTCMZNA
        '
        Me.DTCMZNA.ColumnName = "TCMZNA"
        '
        'DQSLMC2
        '
        Me.DQSLMC2.ColumnName = "QSLMC2"
        Me.DQSLMC2.DataType = GetType(Decimal)
        Me.DQSLMC2.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DCUNCN7
        '
        Me.DCUNCN7.ColumnName = "CUNCN7"
        '
        'DQSLMP2
        '
        Me.DQSLMP2.ColumnName = "QSLMP2"
        Me.DQSLMP2.DataType = GetType(Decimal)
        Me.DQSLMP2.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DCUNPS7
        '
        Me.DCUNPS7.ColumnName = "CUNPS7"
        '
        'DQDSVGN
        '
        Me.DQDSVGN.ColumnName = "QDSVGN"
        Me.DQDSVGN.DataType = GetType(Decimal)
        Me.DQDSVGN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DQAUTCN
        '
        Me.DQAUTCN.ColumnName = "QAUTCN"
        Me.DQAUTCN.DataType = GetType(Decimal)
        Me.DQAUTCN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DQAUTPS
        '
        Me.DQAUTPS.ColumnName = "QAUTPS"
        Me.DQAUTPS.DataType = GetType(Decimal)
        Me.DQAUTPS.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DSTPING
        '
        Me.DSTPING.ColumnName = "STPING"
        '
        'DTOBSRV
        '
        Me.DTOBSRV.ColumnName = "TOBSRV"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "CPLNFC"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "TPLNTA"
        '
        'dtMercaderiaSeleccionadas
        '
        Me.dtMercaderiaSeleccionadas.Columns.AddRange(New System.Data.DataColumn() {Me.SCMRCLR, Me.STMRCD2, Me.SCMRCD, Me.SNORDSR, Me.SNCNTR, Me.SNCRCTC, Me.SNAUTR, Me.SCUNCNT, Me.SCUNPST, Me.SCUNVLT, Me.SNORCCL, Me.SNGUICL, Me.SNRUCLL, Me.SSTPING, Me.SCTPALM, Me.STALMC, Me.SCALMC, Me.STCMPAL, Me.SCZNALM, Me.STCMZNA, Me.SQTRMC, Me.SQTRMP, Me.SQDSVGN, Me.SFUNDS2, Me.SCTPDPS, Me.STOBSRV})
        Me.dtMercaderiaSeleccionadas.TableName = "dtMercaderiaSeleccionadas"
        '
        'SCMRCLR
        '
        Me.SCMRCLR.ColumnName = "CMRCLR"
        '
        'STMRCD2
        '
        Me.STMRCD2.ColumnName = "TMRCD2"
        '
        'SCMRCD
        '
        Me.SCMRCD.ColumnName = "CMRCD"
        '
        'SNORDSR
        '
        Me.SNORDSR.ColumnName = "NORDSR"
        '
        'SNCNTR
        '
        Me.SNCNTR.ColumnName = "NCNTR"
        '
        'SNCRCTC
        '
        Me.SNCRCTC.ColumnName = "NCRCTC"
        '
        'SNAUTR
        '
        Me.SNAUTR.ColumnName = "NAUTR"
        '
        'SCUNCNT
        '
        Me.SCUNCNT.ColumnName = "CUNCNT"
        '
        'SCUNPST
        '
        Me.SCUNPST.ColumnName = "CUNPST"
        '
        'SCUNVLT
        '
        Me.SCUNVLT.ColumnName = "CUNVLT"
        '
        'SNORCCL
        '
        Me.SNORCCL.ColumnName = "NORCCL"
        '
        'SNGUICL
        '
        Me.SNGUICL.ColumnName = "NGUICL"
        '
        'SNRUCLL
        '
        Me.SNRUCLL.ColumnName = "NRUCLL"
        '
        'SSTPING
        '
        Me.SSTPING.ColumnName = "STPING"
        '
        'SCTPALM
        '
        Me.SCTPALM.ColumnName = "CTPALM"
        '
        'STALMC
        '
        Me.STALMC.ColumnName = "TALMC"
        '
        'SCALMC
        '
        Me.SCALMC.ColumnName = "CALMC"
        '
        'STCMPAL
        '
        Me.STCMPAL.ColumnName = "TCMPAL"
        '
        'SCZNALM
        '
        Me.SCZNALM.ColumnName = "CZNALM"
        '
        'STCMZNA
        '
        Me.STCMZNA.ColumnName = "TCMZNA"
        '
        'SQTRMC
        '
        Me.SQTRMC.ColumnName = "QTRMC"
        '
        'SQTRMP
        '
        Me.SQTRMP.ColumnName = "QTRMP"
        '
        'SQDSVGN
        '
        Me.SQDSVGN.ColumnName = "QDSVGN"
        '
        'SFUNDS2
        '
        Me.SFUNDS2.ColumnName = "FUNDS2"
        '
        'SCTPDPS
        '
        Me.SCTPDPS.ColumnName = "CTPDPS"
        '
        'STOBSRV
        '
        Me.STOBSRV.ColumnName = "TOBSRV"
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tspListadoMercaderia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssbAjuste, Me.tssSeparador03, Me.lblTitulo, Me.btnRealizarDespacho, Me.tssSeparador02, Me.txtFiltroMercaderia, Me.lblFiltro, Me.tssSeparador01, Me.ToolStripSeparator1})
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(955, 32)
        Me.tspListadoMercaderia.TabIndex = 1
        Me.tspListadoMercaderia.Text = "ToolStrip1"
        '
        'tssbAjuste
        '
        Me.tssbAjuste.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssbAjuste.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.tssbAjuste.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.tssbAjuste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssbAjuste.Name = "tssbAjuste"
        Me.tssbAjuste.Size = New System.Drawing.Size(110, 29)
        Me.tssbAjuste.Text = "Ajustes"
        Me.tssbAjuste.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(257, 30)
        Me.ToolStripMenuItem1.Text = "Ajuste Recepción (+)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(257, 30)
        Me.ToolStripMenuItem2.Text = "Ajuste Despacho (-)"
        '
        'tssSeparador03
        '
        Me.tssSeparador03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador03.Name = "tssSeparador03"
        Me.tssSeparador03.Size = New System.Drawing.Size(6, 32)
        Me.tssSeparador03.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Image = CType(resources.GetObject("lblTitulo.Image"), System.Drawing.Image)
        Me.lblTitulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(242, 29)
        Me.lblTitulo.Text = "Listado de Mercaderia"
        '
        'btnRealizarDespacho
        '
        Me.btnRealizarDespacho.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnRealizarDespacho.Image = CType(resources.GetObject("btnRealizarDespacho.Image"), System.Drawing.Image)
        Me.btnRealizarDespacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRealizarDespacho.Name = "btnRealizarDespacho"
        Me.btnRealizarDespacho.Size = New System.Drawing.Size(150, 29)
        Me.btnRealizarDespacho.Text = "Iniciar Proceso"
        '
        'tssSeparador02
        '
        Me.tssSeparador02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador02.Name = "tssSeparador02"
        Me.tssSeparador02.Size = New System.Drawing.Size(6, 32)
        '
        'txtFiltroMercaderia
        '
        Me.txtFiltroMercaderia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFiltroMercaderia.MaxLength = 30
        Me.txtFiltroMercaderia.Name = "txtFiltroMercaderia"
        Me.txtFiltroMercaderia.ReadOnly = True
        Me.txtFiltroMercaderia.Size = New System.Drawing.Size(223, 32)
        '
        'lblFiltro
        '
        Me.lblFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(65, 29)
        Me.lblFiltro.Text = "Filtro :"
        '
        'tssSeparador01
        '
        Me.tssSeparador01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador01.Name = "tssSeparador01"
        Me.tssSeparador01.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'hgOS
        '
        Me.hgOS.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaDespacharMercaderiaOS, Me.bsaOcultar})
        Me.hgOS.Dock = System.Windows.Forms.DockStyle.Right
        Me.hgOS.HeaderVisibleSecondary = False
        Me.hgOS.Location = New System.Drawing.Point(957, 168)
        Me.hgOS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.hgOS.Name = "hgOS"
        '
        'hgOS.Panel
        '
        Me.hgOS.Panel.Controls.Add(Me.dgListaOrdenesServicio)
        Me.hgOS.Panel.Controls.Add(Me.hgAlmacenPorOS)
        Me.hgOS.Size = New System.Drawing.Size(828, 463)
        Me.hgOS.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgOS.TabIndex = 53
        Me.hgOS.Text = "Orden de Servicios"
        Me.hgOS.ValuesPrimary.Description = ""
        Me.hgOS.ValuesPrimary.Heading = "Orden de Servicios"
        Me.hgOS.ValuesPrimary.Image = Nothing
        Me.hgOS.ValuesSecondary.Description = ""
        Me.hgOS.ValuesSecondary.Heading = "Description"
        Me.hgOS.ValuesSecondary.Image = Nothing
        Me.hgOS.Visible = False
        '
        'bsaDespacharMercaderiaOS
        '
        Me.bsaDespacharMercaderiaOS.ExtraText = ""
        Me.bsaDespacharMercaderiaOS.Image = CType(resources.GetObject("bsaDespacharMercaderiaOS.Image"), System.Drawing.Image)
        Me.bsaDespacharMercaderiaOS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaDespacharMercaderiaOS.Text = "Despachar Mercadería"
        Me.bsaDespacharMercaderiaOS.ToolTipImage = Nothing
        Me.bsaDespacharMercaderiaOS.UniqueName = "5033E7CFDAAA4BBF5033E7CFDAAA4BBF"
        '
        'bsaOcultar
        '
        Me.bsaOcultar.ExtraText = ""
        Me.bsaOcultar.Image = CType(resources.GetObject("bsaOcultar.Image"), System.Drawing.Image)
        Me.bsaOcultar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaOcultar.Text = "Ocultar"
        Me.bsaOcultar.ToolTipImage = Nothing
        Me.bsaOcultar.UniqueName = "45745F99952B495545745F99952B4955"
        '
        'dgListaOrdenesServicio
        '
        Me.dgListaOrdenesServicio.AllowUserToAddRows = False
        Me.dgListaOrdenesServicio.AllowUserToDeleteRows = False
        Me.dgListaOrdenesServicio.AllowUserToResizeColumns = False
        Me.dgListaOrdenesServicio.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgListaOrdenesServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgListaOrdenesServicio.AutoGenerateColumns = False
        Me.dgListaOrdenesServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgListaOrdenesServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.O_NORDSR, Me.O_NCNTR, Me.O_NCRCTC, Me.O_NAUTR, Me.O_FEMORS, Me.O_CTPDP6, Me.O_QSLMC, Me.O_CUNCN5, Me.O_QSLMP, Me.O_CUNPS5, Me.O_QSLMV, Me.O_CUNVL5, Me.O_FUNDS2})
        Me.dgListaOrdenesServicio.DataMember = "dtOrdenServicio"
        Me.dgListaOrdenesServicio.DataSource = Me.dstOrdenServicio
        Me.dgListaOrdenesServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListaOrdenesServicio.Location = New System.Drawing.Point(0, 0)
        Me.dgListaOrdenesServicio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgListaOrdenesServicio.MultiSelect = False
        Me.dgListaOrdenesServicio.Name = "dgListaOrdenesServicio"
        Me.dgListaOrdenesServicio.ReadOnly = True
        Me.dgListaOrdenesServicio.RowHeadersWidth = 20
        Me.dgListaOrdenesServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaOrdenesServicio.Size = New System.Drawing.Size(826, 201)
        Me.dgListaOrdenesServicio.StandardTab = True
        Me.dgListaOrdenesServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgListaOrdenesServicio.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgListaOrdenesServicio.TabIndex = 25
        '
        'O_NORDSR
        '
        Me.O_NORDSR.DataPropertyName = "NORDSR"
        Me.O_NORDSR.HeaderText = "Nro. O/S"
        Me.O_NORDSR.Name = "O_NORDSR"
        Me.O_NORDSR.ReadOnly = True
        Me.O_NORDSR.Width = 122
        '
        'O_NCNTR
        '
        Me.O_NCNTR.DataPropertyName = "NCNTR"
        Me.O_NCNTR.HeaderText = "Contrato"
        Me.O_NCNTR.Name = "O_NCNTR"
        Me.O_NCNTR.ReadOnly = True
        Me.O_NCNTR.Visible = False
        Me.O_NCNTR.Width = 76
        '
        'O_NCRCTC
        '
        Me.O_NCRCTC.DataPropertyName = "NCRCTC"
        Me.O_NCRCTC.HeaderText = "Corr."
        Me.O_NCRCTC.Name = "O_NCRCTC"
        Me.O_NCRCTC.ReadOnly = True
        Me.O_NCRCTC.Visible = False
        Me.O_NCRCTC.Width = 58
        '
        'O_NAUTR
        '
        Me.O_NAUTR.DataPropertyName = "NAUTR"
        Me.O_NAUTR.HeaderText = "Autorización"
        Me.O_NAUTR.Name = "O_NAUTR"
        Me.O_NAUTR.ReadOnly = True
        Me.O_NAUTR.Visible = False
        Me.O_NAUTR.Width = 94
        '
        'O_FEMORS
        '
        Me.O_FEMORS.DataPropertyName = "FEMORS"
        Me.O_FEMORS.HeaderText = "Fecha"
        Me.O_FEMORS.Name = "O_FEMORS"
        Me.O_FEMORS.ReadOnly = True
        Me.O_FEMORS.Width = 97
        '
        'O_CTPDP6
        '
        Me.O_CTPDP6.DataPropertyName = "CTPDP6"
        Me.O_CTPDP6.HeaderText = "Tipo Depósito"
        Me.O_CTPDP6.Name = "O_CTPDP6"
        Me.O_CTPDP6.ReadOnly = True
        Me.O_CTPDP6.Width = 165
        '
        'O_QSLMC
        '
        Me.O_QSLMC.DataPropertyName = "QSLMC"
        Me.O_QSLMC.HeaderText = "S. Cantidad"
        Me.O_QSLMC.Name = "O_QSLMC"
        Me.O_QSLMC.ReadOnly = True
        Me.O_QSLMC.Width = 142
        '
        'O_CUNCN5
        '
        Me.O_CUNCN5.DataPropertyName = "CUNCN5"
        Me.O_CUNCN5.HeaderText = "Unidad"
        Me.O_CUNCN5.Name = "O_CUNCN5"
        Me.O_CUNCN5.ReadOnly = True
        Me.O_CUNCN5.Width = 109
        '
        'O_QSLMP
        '
        Me.O_QSLMP.DataPropertyName = "QSLMP"
        Me.O_QSLMP.HeaderText = "S. Peso"
        Me.O_QSLMP.Name = "O_QSLMP"
        Me.O_QSLMP.ReadOnly = True
        Me.O_QSLMP.Width = 108
        '
        'O_CUNPS5
        '
        Me.O_CUNPS5.DataPropertyName = "CUNPS5"
        Me.O_CUNPS5.HeaderText = "Unidad"
        Me.O_CUNPS5.Name = "O_CUNPS5"
        Me.O_CUNPS5.ReadOnly = True
        Me.O_CUNPS5.Width = 109
        '
        'O_QSLMV
        '
        Me.O_QSLMV.DataPropertyName = "QSLMV"
        Me.O_QSLMV.HeaderText = "S. Valor"
        Me.O_QSLMV.Name = "O_QSLMV"
        Me.O_QSLMV.ReadOnly = True
        Me.O_QSLMV.Width = 111
        '
        'O_CUNVL5
        '
        Me.O_CUNVL5.DataPropertyName = "CUNVL5"
        Me.O_CUNVL5.HeaderText = "Unidad"
        Me.O_CUNVL5.Name = "O_CUNVL5"
        Me.O_CUNVL5.ReadOnly = True
        Me.O_CUNVL5.Width = 109
        '
        'O_FUNDS2
        '
        Me.O_FUNDS2.DataPropertyName = "FUNDS2"
        Me.O_FUNDS2.HeaderText = "Status"
        Me.O_FUNDS2.Name = "O_FUNDS2"
        Me.O_FUNDS2.ReadOnly = True
        Me.O_FUNDS2.Visible = False
        Me.O_FUNDS2.Width = 66
        '
        'dstOrdenServicio
        '
        Me.dstOrdenServicio.DataSetName = "NewDataSet"
        Me.dstOrdenServicio.Tables.AddRange(New System.Data.DataTable() {Me.dtOrdenServicio})
        '
        'dtOrdenServicio
        '
        Me.dtOrdenServicio.Columns.AddRange(New System.Data.DataColumn() {Me.ONORDSR, Me.ONCNTR, Me.ONCRCTC, Me.ONAUTR, Me.OFEMORS, Me.OCTPDP6, Me.OQSLMC, Me.OCUNCN5, Me.OQSLMP, Me.OCUNPS5, Me.OQSLMV, Me.OCUNVL5, Me.OFUNDS2})
        Me.dtOrdenServicio.TableName = "dtOrdenServicio"
        '
        'ONORDSR
        '
        Me.ONORDSR.ColumnName = "NORDSR"
        Me.ONORDSR.DataType = GetType(Integer)
        '
        'ONCNTR
        '
        Me.ONCNTR.ColumnName = "NCNTR"
        Me.ONCNTR.DataType = GetType(Integer)
        '
        'ONCRCTC
        '
        Me.ONCRCTC.ColumnName = "NCRCTC"
        Me.ONCRCTC.DataType = GetType(Integer)
        '
        'ONAUTR
        '
        Me.ONAUTR.ColumnName = "NAUTR"
        Me.ONAUTR.DataType = GetType(Integer)
        '
        'OFEMORS
        '
        Me.OFEMORS.ColumnName = "FEMORS"
        Me.OFEMORS.DataType = GetType(Date)
        '
        'OCTPDP6
        '
        Me.OCTPDP6.ColumnName = "CTPDP6"
        '
        'OQSLMC
        '
        Me.OQSLMC.ColumnName = "QSLMC"
        Me.OQSLMC.DataType = GetType(Decimal)
        '
        'OCUNCN5
        '
        Me.OCUNCN5.ColumnName = "CUNCN5"
        '
        'OQSLMP
        '
        Me.OQSLMP.ColumnName = "QSLMP"
        Me.OQSLMP.DataType = GetType(Decimal)
        '
        'OCUNPS5
        '
        Me.OCUNPS5.ColumnName = "CUNPS5"
        '
        'OQSLMV
        '
        Me.OQSLMV.ColumnName = "QSLMV"
        Me.OQSLMV.DataType = GetType(Decimal)
        '
        'OCUNVL5
        '
        Me.OCUNVL5.ColumnName = "CUNVL5"
        '
        'OFUNDS2
        '
        Me.OFUNDS2.ColumnName = "FUNDS2"
        '
        'hgAlmacenPorOS
        '
        Me.hgAlmacenPorOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgAlmacenPorOS.HeaderVisibleSecondary = False
        Me.hgAlmacenPorOS.Location = New System.Drawing.Point(0, 201)
        Me.hgAlmacenPorOS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.hgAlmacenPorOS.Name = "hgAlmacenPorOS"
        '
        'hgAlmacenPorOS.Panel
        '
        Me.hgAlmacenPorOS.Panel.Controls.Add(Me.dgStockPorAlmacen)
        Me.hgAlmacenPorOS.Size = New System.Drawing.Size(826, 222)
        Me.hgAlmacenPorOS.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.hgAlmacenPorOS.TabIndex = 29
        Me.hgAlmacenPorOS.Text = "Almacenes"
        Me.hgAlmacenPorOS.ValuesPrimary.Description = ""
        Me.hgAlmacenPorOS.ValuesPrimary.Heading = "Almacenes"
        Me.hgAlmacenPorOS.ValuesPrimary.Image = Nothing
        Me.hgAlmacenPorOS.ValuesSecondary.Description = ""
        Me.hgAlmacenPorOS.ValuesSecondary.Heading = "Almacén :"
        Me.hgAlmacenPorOS.ValuesSecondary.Image = Nothing
        '
        'dgStockPorAlmacen
        '
        Me.dgStockPorAlmacen.AllowUserToAddRows = False
        Me.dgStockPorAlmacen.AllowUserToDeleteRows = False
        Me.dgStockPorAlmacen.AllowUserToResizeColumns = False
        Me.dgStockPorAlmacen.AllowUserToResizeRows = False
        Me.dgStockPorAlmacen.AutoGenerateColumns = False
        Me.dgStockPorAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgStockPorAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D_STASEL, Me.D_NORDSR, Me.D_CTPALM, Me.D_TALMC, Me.D_CALMC, Me.D_TCMPAL, Me.CPLNFC, Me.TPLNTA, Me.D_CZNALM, Me.D_TCMZNA, Me.D_QSLMC2, Me.D_QAUTCN, Me.D_CUNCN7, Me.D_QSLMP2, Me.D_QAUTPS, Me.D_CUNPS7, Me.D_QDSVGN, Me.D_STPING, Me.D_TOBSRV})
        Me.dgStockPorAlmacen.DataMember = "dtStockPorAlmacen"
        Me.dgStockPorAlmacen.DataSource = Me.dstMercaderia
        Me.dgStockPorAlmacen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgStockPorAlmacen.Location = New System.Drawing.Point(0, 0)
        Me.dgStockPorAlmacen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgStockPorAlmacen.MultiSelect = False
        Me.dgStockPorAlmacen.Name = "dgStockPorAlmacen"
        Me.dgStockPorAlmacen.RowHeadersWidth = 20
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgStockPorAlmacen.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgStockPorAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgStockPorAlmacen.Size = New System.Drawing.Size(824, 192)
        Me.dgStockPorAlmacen.StandardTab = True
        Me.dgStockPorAlmacen.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgStockPorAlmacen.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgStockPorAlmacen.TabIndex = 27
        '
        'D_STASEL
        '
        Me.D_STASEL.DataPropertyName = "STASEL"
        Me.D_STASEL.FalseValue = "0"
        Me.D_STASEL.HeaderText = "Selec."
        Me.D_STASEL.Name = "D_STASEL"
        Me.D_STASEL.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.D_STASEL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.D_STASEL.TrueValue = "1"
        Me.D_STASEL.Visible = False
        Me.D_STASEL.Width = 66
        '
        'D_NORDSR
        '
        Me.D_NORDSR.DataPropertyName = "NORDSR"
        Me.D_NORDSR.HeaderText = "Orden Servicio"
        Me.D_NORDSR.MaxInputLength = 10
        Me.D_NORDSR.Name = "D_NORDSR"
        Me.D_NORDSR.ReadOnly = True
        Me.D_NORDSR.Visible = False
        Me.D_NORDSR.Width = 113
        '
        'D_CTPALM
        '
        Me.D_CTPALM.DataPropertyName = "CTPALM"
        Me.D_CTPALM.HeaderText = "Tipo"
        Me.D_CTPALM.MaxInputLength = 2
        Me.D_CTPALM.Name = "D_CTPALM"
        Me.D_CTPALM.ReadOnly = True
        Me.D_CTPALM.Width = 87
        '
        'D_TALMC
        '
        Me.D_TALMC.DataPropertyName = "TALMC"
        Me.D_TALMC.HeaderText = "Detalle"
        Me.D_TALMC.MaxInputLength = 50
        Me.D_TALMC.Name = "D_TALMC"
        Me.D_TALMC.ReadOnly = True
        Me.D_TALMC.Visible = False
        Me.D_TALMC.Width = 72
        '
        'D_CALMC
        '
        Me.D_CALMC.DataPropertyName = "CALMC"
        Me.D_CALMC.HeaderText = "Almacén"
        Me.D_CALMC.MaxInputLength = 2
        Me.D_CALMC.Name = "D_CALMC"
        Me.D_CALMC.ReadOnly = True
        Me.D_CALMC.Width = 120
        '
        'D_TCMPAL
        '
        Me.D_TCMPAL.DataPropertyName = "TCMPAL"
        Me.D_TCMPAL.HeaderText = "Detalle"
        Me.D_TCMPAL.MaxInputLength = 50
        Me.D_TCMPAL.Name = "D_TCMPAL"
        Me.D_TCMPAL.ReadOnly = True
        Me.D_TCMPAL.Visible = False
        Me.D_TCMPAL.Width = 72
        '
        'CPLNFC
        '
        Me.CPLNFC.DataPropertyName = "CPLNFC"
        Me.CPLNFC.HeaderText = "CPLNFC"
        Me.CPLNFC.Name = "CPLNFC"
        Me.CPLNFC.ReadOnly = True
        Me.CPLNFC.Visible = False
        Me.CPLNFC.Width = 80
        '
        'TPLNTA
        '
        Me.TPLNTA.DataPropertyName = "TPLNTA"
        Me.TPLNTA.HeaderText = "Planta"
        Me.TPLNTA.Name = "TPLNTA"
        Me.TPLNTA.ReadOnly = True
        '
        'D_CZNALM
        '
        Me.D_CZNALM.DataPropertyName = "CZNALM"
        Me.D_CZNALM.HeaderText = "Zona"
        Me.D_CZNALM.MaxInputLength = 2
        Me.D_CZNALM.Name = "D_CZNALM"
        Me.D_CZNALM.ReadOnly = True
        Me.D_CZNALM.Width = 92
        '
        'D_TCMZNA
        '
        Me.D_TCMZNA.DataPropertyName = "TCMZNA"
        Me.D_TCMZNA.HeaderText = "Detalle"
        Me.D_TCMZNA.Name = "D_TCMZNA"
        Me.D_TCMZNA.ReadOnly = True
        Me.D_TCMZNA.Visible = False
        Me.D_TCMZNA.Width = 72
        '
        'D_QSLMC2
        '
        Me.D_QSLMC2.DataPropertyName = "QSLMC2"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.D_QSLMC2.DefaultCellStyle = DataGridViewCellStyle4
        Me.D_QSLMC2.HeaderText = "S. Cant."
        Me.D_QSLMC2.MaxInputLength = 10
        Me.D_QSLMC2.Name = "D_QSLMC2"
        Me.D_QSLMC2.ReadOnly = True
        Me.D_QSLMC2.Width = 111
        '
        'D_QAUTCN
        '
        Me.D_QAUTCN.DataPropertyName = "QAUTCN"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.D_QAUTCN.DefaultCellStyle = DataGridViewCellStyle5
        Me.D_QAUTCN.HeaderText = "Cant."
        Me.D_QAUTCN.MaxInputLength = 10
        Me.D_QAUTCN.Name = "D_QAUTCN"
        Me.D_QAUTCN.Visible = False
        Me.D_QAUTCN.Width = 64
        '
        'D_CUNCN7
        '
        Me.D_CUNCN7.DataPropertyName = "CUNCN7"
        Me.D_CUNCN7.HeaderText = "Uni."
        Me.D_CUNCN7.MaxInputLength = 10
        Me.D_CUNCN7.Name = "D_CUNCN7"
        Me.D_CUNCN7.ReadOnly = True
        Me.D_CUNCN7.Width = 82
        '
        'D_QSLMP2
        '
        Me.D_QSLMP2.DataPropertyName = "QSLMP2"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.D_QSLMP2.DefaultCellStyle = DataGridViewCellStyle6
        Me.D_QSLMP2.HeaderText = "S. Peso"
        Me.D_QSLMP2.MaxInputLength = 10
        Me.D_QSLMP2.Name = "D_QSLMP2"
        Me.D_QSLMP2.ReadOnly = True
        Me.D_QSLMP2.Width = 108
        '
        'D_QAUTPS
        '
        Me.D_QAUTPS.DataPropertyName = "QAUTPS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.D_QAUTPS.DefaultCellStyle = DataGridViewCellStyle7
        Me.D_QAUTPS.HeaderText = "Peso"
        Me.D_QAUTPS.MaxInputLength = 10
        Me.D_QAUTPS.Name = "D_QAUTPS"
        Me.D_QAUTPS.Visible = False
        Me.D_QAUTPS.Width = 61
        '
        'D_CUNPS7
        '
        Me.D_CUNPS7.DataPropertyName = "CUNPS7"
        Me.D_CUNPS7.HeaderText = "Uni."
        Me.D_CUNPS7.MaxInputLength = 10
        Me.D_CUNPS7.Name = "D_CUNPS7"
        Me.D_CUNPS7.ReadOnly = True
        Me.D_CUNPS7.Width = 82
        '
        'D_QDSVGN
        '
        Me.D_QDSVGN.DataPropertyName = "QDSVGN"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = "0"
        Me.D_QDSVGN.DefaultCellStyle = DataGridViewCellStyle8
        Me.D_QDSVGN.HeaderText = "Vigencia"
        Me.D_QDSVGN.MaxInputLength = 2
        Me.D_QDSVGN.Name = "D_QDSVGN"
        Me.D_QDSVGN.Visible = False
        Me.D_QDSVGN.Width = 81
        '
        'D_STPING
        '
        Me.D_STPING.DataPropertyName = "STPING"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.D_STPING.DefaultCellStyle = DataGridViewCellStyle9
        Me.D_STPING.HeaderText = "Mov."
        Me.D_STPING.MaxInputLength = 1
        Me.D_STPING.Name = "D_STPING"
        Me.D_STPING.Visible = False
        Me.D_STPING.Width = 63
        '
        'D_TOBSRV
        '
        Me.D_TOBSRV.DataPropertyName = "TOBSRV"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.D_TOBSRV.DefaultCellStyle = DataGridViewCellStyle10
        Me.D_TOBSRV.HeaderText = "Obs."
        Me.D_TOBSRV.MaxInputLength = 25
        Me.D_TOBSRV.Name = "D_TOBSRV"
        Me.D_TOBSRV.Visible = False
        Me.D_TOBSRV.Width = 60
        '
        'hgMercaderiaSeleccionada
        '
        Me.hgMercaderiaSeleccionada.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaProcesarDespachar, Me.bsaEliminarItem})
        Me.hgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgMercaderiaSeleccionada.HeaderVisibleSecondary = False
        Me.hgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 631)
        Me.hgMercaderiaSeleccionada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.hgMercaderiaSeleccionada.Name = "hgMercaderiaSeleccionada"
        '
        'hgMercaderiaSeleccionada.Panel
        '
        Me.hgMercaderiaSeleccionada.Panel.Controls.Add(Me.dgMercaderiaSeleccionada)
        Me.hgMercaderiaSeleccionada.Size = New System.Drawing.Size(1785, 269)
        Me.hgMercaderiaSeleccionada.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgMercaderiaSeleccionada.TabIndex = 52
        Me.hgMercaderiaSeleccionada.Text = "Mercadería Seleccionada"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Heading = "Mercadería Seleccionada"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Image = Nothing
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Heading = "Description"
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Image = Nothing
        Me.hgMercaderiaSeleccionada.Visible = False
        '
        'bsaProcesarDespachar
        '
        Me.bsaProcesarDespachar.ExtraText = ""
        Me.bsaProcesarDespachar.Image = CType(resources.GetObject("bsaProcesarDespachar.Image"), System.Drawing.Image)
        Me.bsaProcesarDespachar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaProcesarDespachar.Text = "Procesar Despachar"
        Me.bsaProcesarDespachar.ToolTipImage = Nothing
        Me.bsaProcesarDespachar.UniqueName = "0F1839EC421141FD0F1839EC421141FD"
        '
        'bsaEliminarItem
        '
        Me.bsaEliminarItem.ExtraText = ""
        Me.bsaEliminarItem.Image = CType(resources.GetObject("bsaEliminarItem.Image"), System.Drawing.Image)
        Me.bsaEliminarItem.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaEliminarItem.Text = "Eliminar Item"
        Me.bsaEliminarItem.ToolTipImage = Nothing
        Me.bsaEliminarItem.UniqueName = "EAEDCE53E61A4335EAEDCE53E61A4335"
        '
        'dgMercaderiaSeleccionada
        '
        Me.dgMercaderiaSeleccionada.AllowUserToAddRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToDeleteRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeColumns = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeRows = False
        Me.dgMercaderiaSeleccionada.AutoGenerateColumns = False
        Me.dgMercaderiaSeleccionada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaSeleccionada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_CMRCLR, Me.S_TMRCD2, Me.S_CMRCD, Me.S_NORDSR, Me.S_NCNTR, Me.S_NCRCTC, Me.S_NAUTR, Me.S_CUNCNT, Me.S_CUNPST, Me.S_CUNVLT, Me.S_NORCCL, Me.S_NGUICL, Me.S_NRUCLL, Me.S_STPING, Me.S_CTPALM, Me.S_TALMC, Me.S_CALMC, Me.S_TCMPAL, Me.S_CZNALM, Me.S_TCMZNA, Me.S_QTRMC, Me.S_QTRMP, Me.S_QDSVGN, Me.S_FUNDS2, Me.S_CTPDPS, Me.S_TOBSRV})
        Me.dgMercaderiaSeleccionada.DataMember = "dtMercaderiaSeleccionadas"
        Me.dgMercaderiaSeleccionada.DataSource = Me.dstMercaderia
        Me.dgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderiaSeleccionada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgMercaderiaSeleccionada.MultiSelect = False
        Me.dgMercaderiaSeleccionada.Name = "dgMercaderiaSeleccionada"
        Me.dgMercaderiaSeleccionada.ReadOnly = True
        Me.dgMercaderiaSeleccionada.RowHeadersWidth = 20
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaSeleccionada.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgMercaderiaSeleccionada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaSeleccionada.Size = New System.Drawing.Size(1783, 229)
        Me.dgMercaderiaSeleccionada.StandardTab = True
        Me.dgMercaderiaSeleccionada.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderiaSeleccionada.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderiaSeleccionada.TabIndex = 24
        '
        'S_CMRCLR
        '
        Me.S_CMRCLR.DataPropertyName = "CMRCLR"
        Me.S_CMRCLR.HeaderText = "Mercadería"
        Me.S_CMRCLR.Name = "S_CMRCLR"
        Me.S_CMRCLR.ReadOnly = True
        Me.S_CMRCLR.Width = 139
        '
        'S_TMRCD2
        '
        Me.S_TMRCD2.DataPropertyName = "TMRCD2"
        Me.S_TMRCD2.HeaderText = "Detalle"
        Me.S_TMRCD2.Name = "S_TMRCD2"
        Me.S_TMRCD2.ReadOnly = True
        Me.S_TMRCD2.Width = 106
        '
        'S_CMRCD
        '
        Me.S_CMRCD.DataPropertyName = "CMRCD"
        Me.S_CMRCD.HeaderText = "Cód. Ransa"
        Me.S_CMRCD.Name = "S_CMRCD"
        Me.S_CMRCD.ReadOnly = True
        Me.S_CMRCD.Width = 141
        '
        'S_NORDSR
        '
        Me.S_NORDSR.DataPropertyName = "NORDSR"
        Me.S_NORDSR.HeaderText = "Orden Servicio"
        Me.S_NORDSR.Name = "S_NORDSR"
        Me.S_NORDSR.ReadOnly = True
        Me.S_NORDSR.Width = 168
        '
        'S_NCNTR
        '
        Me.S_NCNTR.DataPropertyName = "NCNTR"
        Me.S_NCNTR.HeaderText = "No. Contrato"
        Me.S_NCNTR.Name = "S_NCNTR"
        Me.S_NCNTR.ReadOnly = True
        Me.S_NCNTR.Width = 155
        '
        'S_NCRCTC
        '
        Me.S_NCRCTC.DataPropertyName = "NCRCTC"
        Me.S_NCRCTC.HeaderText = "Correlativo"
        Me.S_NCRCTC.Name = "S_NCRCTC"
        Me.S_NCRCTC.ReadOnly = True
        Me.S_NCRCTC.Width = 138
        '
        'S_NAUTR
        '
        Me.S_NAUTR.DataPropertyName = "NAUTR"
        Me.S_NAUTR.HeaderText = "No Autorización"
        Me.S_NAUTR.Name = "S_NAUTR"
        Me.S_NAUTR.ReadOnly = True
        Me.S_NAUTR.Width = 180
        '
        'S_CUNCNT
        '
        Me.S_CUNCNT.DataPropertyName = "CUNCNT"
        Me.S_CUNCNT.HeaderText = "U. Cantidad"
        Me.S_CUNCNT.Name = "S_CUNCNT"
        Me.S_CUNCNT.ReadOnly = True
        Me.S_CUNCNT.Width = 144
        '
        'S_CUNPST
        '
        Me.S_CUNPST.DataPropertyName = "CUNPST"
        Me.S_CUNPST.HeaderText = "U. Peso"
        Me.S_CUNPST.Name = "S_CUNPST"
        Me.S_CUNPST.ReadOnly = True
        Me.S_CUNPST.Width = 110
        '
        'S_CUNVLT
        '
        Me.S_CUNVLT.DataPropertyName = "CUNVLT"
        Me.S_CUNVLT.HeaderText = "U. Valor"
        Me.S_CUNVLT.Name = "S_CUNVLT"
        Me.S_CUNVLT.ReadOnly = True
        Me.S_CUNVLT.Width = 113
        '
        'S_NORCCL
        '
        Me.S_NORCCL.DataPropertyName = "NORCCL"
        Me.S_NORCCL.HeaderText = "No O/C"
        Me.S_NORCCL.Name = "S_NORCCL"
        Me.S_NORCCL.ReadOnly = True
        Me.S_NORCCL.Width = 113
        '
        'S_NGUICL
        '
        Me.S_NGUICL.DataPropertyName = "NGUICL"
        Me.S_NGUICL.HeaderText = "No Guía Cliente"
        Me.S_NGUICL.Name = "S_NGUICL"
        Me.S_NGUICL.ReadOnly = True
        Me.S_NGUICL.Width = 174
        '
        'S_NRUCLL
        '
        Me.S_NRUCLL.DataPropertyName = "NRUCLL"
        Me.S_NRUCLL.HeaderText = "No RUC Cliente"
        Me.S_NRUCLL.Name = "S_NRUCLL"
        Me.S_NRUCLL.ReadOnly = True
        Me.S_NRUCLL.Width = 173
        '
        'S_STPING
        '
        Me.S_STPING.DataPropertyName = "STPING"
        Me.S_STPING.HeaderText = "Tipo Mov."
        Me.S_STPING.Name = "S_STPING"
        Me.S_STPING.ReadOnly = True
        Me.S_STPING.Width = 132
        '
        'S_CTPALM
        '
        Me.S_CTPALM.DataPropertyName = "CTPALM"
        Me.S_CTPALM.HeaderText = "Tipo Almacén"
        Me.S_CTPALM.Name = "S_CTPALM"
        Me.S_CTPALM.ReadOnly = True
        Me.S_CTPALM.Width = 160
        '
        'S_TALMC
        '
        Me.S_TALMC.DataPropertyName = "TALMC"
        Me.S_TALMC.HeaderText = "Detalle"
        Me.S_TALMC.Name = "S_TALMC"
        Me.S_TALMC.ReadOnly = True
        Me.S_TALMC.Width = 106
        '
        'S_CALMC
        '
        Me.S_CALMC.DataPropertyName = "CALMC"
        Me.S_CALMC.HeaderText = "Almacén"
        Me.S_CALMC.Name = "S_CALMC"
        Me.S_CALMC.ReadOnly = True
        Me.S_CALMC.Width = 120
        '
        'S_TCMPAL
        '
        Me.S_TCMPAL.DataPropertyName = "TCMPAL"
        Me.S_TCMPAL.HeaderText = "Detalle"
        Me.S_TCMPAL.Name = "S_TCMPAL"
        Me.S_TCMPAL.ReadOnly = True
        Me.S_TCMPAL.Width = 106
        '
        'S_CZNALM
        '
        Me.S_CZNALM.DataPropertyName = "CZNALM"
        Me.S_CZNALM.HeaderText = "Zona"
        Me.S_CZNALM.Name = "S_CZNALM"
        Me.S_CZNALM.ReadOnly = True
        Me.S_CZNALM.Width = 92
        '
        'S_TCMZNA
        '
        Me.S_TCMZNA.DataPropertyName = "TCMZNA"
        Me.S_TCMZNA.HeaderText = "Detalle"
        Me.S_TCMZNA.Name = "S_TCMZNA"
        Me.S_TCMZNA.ReadOnly = True
        Me.S_TCMZNA.Width = 106
        '
        'S_QTRMC
        '
        Me.S_QTRMC.DataPropertyName = "QTRMC"
        Me.S_QTRMC.HeaderText = "Cantidad"
        Me.S_QTRMC.Name = "S_QTRMC"
        Me.S_QTRMC.ReadOnly = True
        Me.S_QTRMC.Width = 123
        '
        'S_QTRMP
        '
        Me.S_QTRMP.DataPropertyName = "QTRMP"
        Me.S_QTRMP.HeaderText = "Peso"
        Me.S_QTRMP.Name = "S_QTRMP"
        Me.S_QTRMP.ReadOnly = True
        Me.S_QTRMP.Width = 89
        '
        'S_QDSVGN
        '
        Me.S_QDSVGN.DataPropertyName = "QDSVGN"
        Me.S_QDSVGN.HeaderText = "No Días Vigencia"
        Me.S_QDSVGN.Name = "S_QDSVGN"
        Me.S_QDSVGN.ReadOnly = True
        Me.S_QDSVGN.Width = 186
        '
        'S_FUNDS2
        '
        Me.S_FUNDS2.DataPropertyName = "FUNDS2"
        Me.S_FUNDS2.HeaderText = "U. Despacho"
        Me.S_FUNDS2.Name = "S_FUNDS2"
        Me.S_FUNDS2.ReadOnly = True
        Me.S_FUNDS2.Width = 152
        '
        'S_CTPDPS
        '
        Me.S_CTPDPS.DataPropertyName = "CTPDPS"
        Me.S_CTPDPS.HeaderText = "Tipo Depósito"
        Me.S_CTPDPS.Name = "S_CTPDPS"
        Me.S_CTPDPS.ReadOnly = True
        Me.S_CTPDPS.Width = 165
        '
        'S_TOBSRV
        '
        Me.S_TOBSRV.DataPropertyName = "TOBSRV"
        Me.S_TOBSRV.HeaderText = "Observaciones"
        Me.S_TOBSRV.Name = "S_TOBSRV"
        Me.S_TOBSRV.ReadOnly = True
        Me.S_TOBSRV.Width = 168
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel13)
        Me.hgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.grpLeyenda)
        Me.hgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.hgFiltros.Panel.Controls.Add(Me.cbxPublicarWEB)
        Me.hgFiltros.Panel.Controls.Add(Me.lblPublicarWEB)
        Me.hgFiltros.Panel.Controls.Add(Me.txtFamilia)
        Me.hgFiltros.Panel.Controls.Add(Me.txtGrupo)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.hgFiltros.Panel.Controls.Add(Me.lblFechaInventario)
        Me.hgFiltros.Panel.Controls.Add(Me.txtFechaInventario)
        Me.hgFiltros.Panel.Controls.Add(Me.lblFechaVencimiento)
        Me.hgFiltros.Panel.Controls.Add(Me.txtFechaVencimiento)
        Me.hgFiltros.Panel.Controls.Add(Me.txtMercaderia)
        Me.hgFiltros.Panel.Controls.Add(Me.lblMercadaeria)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(1785, 168)
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
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(630, 19)
        Me.KryptonLabel13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(72, 29)
        Me.KryptonLabel13.TabIndex = 95
        Me.KryptonLabel13.Text = "Planta : "
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Planta : "
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(712, 14)
        Me.UcPLanta_Cmb011.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(225, 32)
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
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(231, 35)
        Me.UcPLanta_Cmb011.TabIndex = 94
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(130, 15)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(417, 30)
        Me.txtCliente.TabIndex = 3
        '
        'grpLeyenda
        '
        Me.grpLeyenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLeyenda.Controls.Add(Me.lblDetalleOpcional)
        Me.grpLeyenda.Controls.Add(Me.lblDetalleObligatorio)
        Me.grpLeyenda.Controls.Add(Me.lblOpcional)
        Me.grpLeyenda.Controls.Add(Me.lblObligatorio)
        Me.grpLeyenda.Location = New System.Drawing.Point(1388, 12)
        Me.grpLeyenda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpLeyenda.Name = "grpLeyenda"
        Me.grpLeyenda.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpLeyenda.Size = New System.Drawing.Size(165, 108)
        Me.grpLeyenda.TabIndex = 16
        Me.grpLeyenda.TabStop = False
        Me.grpLeyenda.Text = "Leyenda"
        Me.grpLeyenda.Visible = False
        '
        'lblDetalleOpcional
        '
        Me.lblDetalleOpcional.Location = New System.Drawing.Point(55, 68)
        Me.lblDetalleOpcional.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblDetalleOpcional.Name = "lblDetalleOpcional"
        Me.lblDetalleOpcional.Size = New System.Drawing.Size(86, 29)
        Me.lblDetalleOpcional.TabIndex = 20
        Me.lblDetalleOpcional.Text = "Opcional"
        Me.lblDetalleOpcional.Values.ExtraText = ""
        Me.lblDetalleOpcional.Values.Image = Nothing
        Me.lblDetalleOpcional.Values.Text = "Opcional"
        '
        'lblDetalleObligatorio
        '
        Me.lblDetalleObligatorio.Location = New System.Drawing.Point(55, 34)
        Me.lblDetalleObligatorio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblDetalleObligatorio.Name = "lblDetalleObligatorio"
        Me.lblDetalleObligatorio.Size = New System.Drawing.Size(106, 29)
        Me.lblDetalleObligatorio.TabIndex = 18
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
        Me.lblOpcional.Location = New System.Drawing.Point(18, 69)
        Me.lblOpcional.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpcional.Name = "lblOpcional"
        Me.lblOpcional.Size = New System.Drawing.Size(23, 22)
        Me.lblOpcional.TabIndex = 19
        Me.lblOpcional.Text = "   "
        '
        'lblObligatorio
        '
        Me.lblObligatorio.AutoSize = True
        Me.lblObligatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblObligatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblObligatorio.Location = New System.Drawing.Point(18, 34)
        Me.lblObligatorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObligatorio.Name = "lblObligatorio"
        Me.lblObligatorio.Size = New System.Drawing.Size(23, 22)
        Me.lblObligatorio.TabIndex = 17
        Me.lblObligatorio.Text = "   "
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(1277, 12)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(102, 106)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 21
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'cbxPublicarWEB
        '
        Me.cbxPublicarWEB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPublicarWEB.DropDownWidth = 82
        Me.cbxPublicarWEB.FormattingEnabled = False
        Me.cbxPublicarWEB.ItemHeight = 25
        Me.cbxPublicarWEB.Items.AddRange(New Object() {"", "SI", "NO"})
        Me.cbxPublicarWEB.Location = New System.Drawing.Point(1054, 8)
        Me.cbxPublicarWEB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxPublicarWEB.Name = "cbxPublicarWEB"
        Me.cbxPublicarWEB.Size = New System.Drawing.Size(123, 33)
        Me.cbxPublicarWEB.TabIndex = 15
        '
        'lblPublicarWEB
        '
        Me.lblPublicarWEB.Location = New System.Drawing.Point(983, 12)
        Me.lblPublicarWEB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblPublicarWEB.Name = "lblPublicarWEB"
        Me.lblPublicarWEB.Size = New System.Drawing.Size(59, 29)
        Me.lblPublicarWEB.TabIndex = 14
        Me.lblPublicarWEB.Text = "WEB : "
        Me.lblPublicarWEB.Values.ExtraText = ""
        Me.lblPublicarWEB.Values.Image = Nothing
        Me.lblPublicarWEB.Values.Text = "WEB : "
        '
        'txtFamilia
        '
        Me.txtFamilia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaFamiliaListar})
        Me.txtFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtFamilia, True)
        Me.txtFamilia.Location = New System.Drawing.Point(712, 52)
        Me.txtFamilia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(417, 30)
        Me.txtFamilia.TabIndex = 5
        '
        'bsaFamiliaListar
        '
        Me.bsaFamiliaListar.ExtraText = ""
        Me.bsaFamiliaListar.Image = Nothing
        Me.bsaFamiliaListar.Text = ""
        Me.bsaFamiliaListar.ToolTipImage = Nothing
        Me.bsaFamiliaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaFamiliaListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'txtGrupo
        '
        Me.txtGrupo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaGrupoListar})
        Me.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtGrupo, True)
        Me.txtGrupo.Location = New System.Drawing.Point(130, 91)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGrupo.MaxLength = 30
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(417, 30)
        Me.txtGrupo.TabIndex = 7
        '
        'bsaGrupoListar
        '
        Me.bsaGrupoListar.ExtraText = ""
        Me.bsaGrupoListar.Image = Nothing
        Me.bsaGrupoListar.Text = ""
        Me.bsaGrupoListar.ToolTipImage = Nothing
        Me.bsaGrupoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaGrupoListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 95)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(73, 29)
        Me.KryptonLabel6.TabIndex = 6
        Me.KryptonLabel6.Text = "Grupo : "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Grupo : "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(622, 58)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(79, 29)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Familia : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Familia : "
        '
        'lblFechaInventario
        '
        Me.lblFechaInventario.Location = New System.Drawing.Point(846, 95)
        Me.lblFechaInventario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblFechaInventario.Name = "lblFechaInventario"
        Me.lblFechaInventario.Size = New System.Drawing.Size(156, 29)
        Me.lblFechaInventario.TabIndex = 12
        Me.lblFechaInventario.Text = "Fecha Inventario : "
        Me.lblFechaInventario.Values.ExtraText = ""
        Me.lblFechaInventario.Values.Image = Nothing
        Me.lblFechaInventario.Values.Text = "Fecha Inventario : "
        '
        'txtFechaInventario
        '
        Me.txtFechaInventario.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaInventario.Location = New System.Drawing.Point(1007, 91)
        Me.txtFechaInventario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFechaInventario.Mask = "##/##/####"
        Me.txtFechaInventario.Name = "txtFechaInventario"
        Me.txtFechaInventario.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaInventario.Size = New System.Drawing.Size(123, 31)
        Me.txtFechaInventario.TabIndex = 13
        Me.txtFechaInventario.Text = "  /  /"
        '
        'lblFechaVencimiento
        '
        Me.lblFechaVencimiento.Location = New System.Drawing.Point(586, 94)
        Me.lblFechaVencimiento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblFechaVencimiento.Name = "lblFechaVencimiento"
        Me.lblFechaVencimiento.Size = New System.Drawing.Size(115, 29)
        Me.lblFechaVencimiento.TabIndex = 10
        Me.lblFechaVencimiento.Text = "Fecha Vcto. : "
        Me.lblFechaVencimiento.Values.ExtraText = ""
        Me.lblFechaVencimiento.Values.Image = Nothing
        Me.lblFechaVencimiento.Values.Text = "Fecha Vcto. : "
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(712, 91)
        Me.txtFechaVencimiento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFechaVencimiento.Mask = "##/##/####"
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(123, 31)
        Me.txtFechaVencimiento.TabIndex = 11
        Me.txtFechaVencimiento.Text = "  /  /"
        '
        'txtMercaderia
        '
        Me.txtMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtMercaderia, True)
        Me.txtMercaderia.Location = New System.Drawing.Point(130, 52)
        Me.txtMercaderia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMercaderia.Name = "txtMercaderia"
        Me.txtMercaderia.Size = New System.Drawing.Size(417, 30)
        Me.txtMercaderia.TabIndex = 9
        '
        'lblMercadaeria
        '
        Me.lblMercadaeria.Location = New System.Drawing.Point(12, 58)
        Me.lblMercadaeria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblMercadaeria.Name = "lblMercadaeria"
        Me.lblMercadaeria.Size = New System.Drawing.Size(113, 29)
        Me.lblMercadaeria.TabIndex = 8
        Me.lblMercadaeria.Text = "Mercadería : "
        Me.lblMercadaeria.Values.ExtraText = ""
        Me.lblMercadaeria.Values.Image = Nothing
        Me.lblMercadaeria.Values.Text = "Mercadería : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 19)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(78, 29)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(1306, 59)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(46, 46)
        Me.KryptonLabel5.TabIndex = 35
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'frmDespachoSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1785, 900)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmDespachoSDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despacho"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.grpListadoMercaderia.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpListadoMercaderia.Panel.ResumeLayout(False)
        Me.grpListadoMercaderia.Panel.PerformLayout()
        CType(Me.grpListadoMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpListadoMercaderia.ResumeLayout(False)
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStockPorAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspListadoMercaderia.ResumeLayout(False)
        Me.tspListadoMercaderia.PerformLayout()
        CType(Me.hgOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgOS.Panel.ResumeLayout(False)
        CType(Me.hgOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgOS.ResumeLayout(False)
        CType(Me.dgListaOrdenesServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgAlmacenPorOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgAlmacenPorOS.Panel.ResumeLayout(False)
        CType(Me.hgAlmacenPorOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgAlmacenPorOS.ResumeLayout(False)
        CType(Me.dgStockPorAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblMercadaeria As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaVencimiento As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFechaVencimiento As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents dstMercaderia As System.Data.DataSet
    Friend WithEvents dtMercaderia As System.Data.DataTable
    Friend WithEvents lblFechaInventario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFechaInventario As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFamilia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaFamiliaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtGrupo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaGrupoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPublicarWEB As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxPublicarWEB As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents MSTASEL As System.Data.DataColumn
    Friend WithEvents MCFMCLR As System.Data.DataColumn
    Friend WithEvents MCGRCLR As System.Data.DataColumn
    Friend WithEvents MCMRCLR As System.Data.DataColumn
    Friend WithEvents MTMRCD2 As System.Data.DataColumn
    Friend WithEvents MCMRCD As System.Data.DataColumn
    Friend WithEvents MSALDO As System.Data.DataColumn
    Friend WithEvents MSESTRG As System.Data.DataColumn
    Friend WithEvents MSITUAC As System.Data.DataColumn
    Friend WithEvents grpLeyenda As System.Windows.Forms.GroupBox
    Friend WithEvents lblDetalleObligatorio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOpcional As System.Windows.Forms.Label
    Friend WithEvents lblObligatorio As System.Windows.Forms.Label
    Friend WithEvents lblDetalleOpcional As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dstOrdenServicio As System.Data.DataSet
    Friend WithEvents dtOrdenServicio As System.Data.DataTable
    Friend WithEvents ONORDSR As System.Data.DataColumn
    Friend WithEvents ONCNTR As System.Data.DataColumn
    Friend WithEvents ONCRCTC As System.Data.DataColumn
    Friend WithEvents ONAUTR As System.Data.DataColumn
    Friend WithEvents OFEMORS As System.Data.DataColumn
    Friend WithEvents OCTPDP6 As System.Data.DataColumn
    Friend WithEvents OQSLMC As System.Data.DataColumn
    Friend WithEvents OCUNCN5 As System.Data.DataColumn
    Friend WithEvents OQSLMP As System.Data.DataColumn
    Friend WithEvents OCUNPS5 As System.Data.DataColumn
    Friend WithEvents OQSLMV As System.Data.DataColumn
    Friend WithEvents OCUNVL5 As System.Data.DataColumn
    Friend WithEvents OFUNDS2 As System.Data.DataColumn
    Friend WithEvents dtStockPorAlmacen As System.Data.DataTable
    Friend WithEvents DSTASEL As System.Data.DataColumn
    Friend WithEvents DNORDSR As System.Data.DataColumn
    Friend WithEvents DCTPALM As System.Data.DataColumn
    Friend WithEvents DTALMC As System.Data.DataColumn
    Friend WithEvents DCALMC As System.Data.DataColumn
    Friend WithEvents DTCMPAL As System.Data.DataColumn
    Friend WithEvents DCZNALM As System.Data.DataColumn
    Friend WithEvents DTCMZNA As System.Data.DataColumn
    Friend WithEvents DQSLMC2 As System.Data.DataColumn
    Friend WithEvents DCUNCN7 As System.Data.DataColumn
    Friend WithEvents DQSLMP2 As System.Data.DataColumn
    Friend WithEvents DCUNPS7 As System.Data.DataColumn
    Friend WithEvents DQDSVGN As System.Data.DataColumn
    Friend WithEvents DQAUTCN As System.Data.DataColumn
    Friend WithEvents DQAUTPS As System.Data.DataColumn
    Friend WithEvents DSTPING As System.Data.DataColumn
    Friend WithEvents DTOBSRV As System.Data.DataColumn
    Friend WithEvents hgAlmacenPorOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgStockPorAlmacen As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgListaOrdenesServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents O_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_NCRCTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_FEMORS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_CTPDP6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_QSLMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_QSLMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_QSLMV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_CUNVL5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_FUNDS2 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents SFUNDS2 As System.Data.DataColumn
    Friend WithEvents SCTPDPS As System.Data.DataColumn
    Friend WithEvents STOBSRV As System.Data.DataColumn
    Friend WithEvents hgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaProcesarDespachar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaDespacharMercaderiaOS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaOcultar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgMercaderias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents grpListadoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnRealizarDespacho As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtFiltroMercaderia As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblFiltro As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tssSeparador01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents S_CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NCRCTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CUNCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CUNPST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CUNVLT As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents S_QDSVGN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_FUNDS2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CTPDPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TOBSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsaEliminarItem As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents M_CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_MARCRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_UBICA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tssbAjuste As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssSeparador03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As RANSA.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents D_STASEL As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents D_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TCMPAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TCMZNA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QSLMC2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QAUTCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CUNCN7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QSLMP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QAUTPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CUNPS7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QDSVGN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_STPING As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TOBSRV As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
