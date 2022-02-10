Imports Ransa.Controls
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarRecepcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerarRecepcion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CUNVL3 = New System.Data.DataColumn()
        Me.CUNPS3 = New System.Data.DataColumn()
        Me.CUNCN3 = New System.Data.DataColumn()
        Me.CTPDP3 = New System.Data.DataColumn()
        Me.CTPPR1 = New System.Data.DataColumn()
        Me.TABDPS = New System.Data.DataColumn()
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
        Me.SNRITOC = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.dstContratos = New System.Data.DataSet()
        Me.dtContratos = New System.Data.DataTable()
        Me.NCNTR = New System.Data.DataColumn()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.grpListadoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.hgSerie_Ubicacion = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaGuardar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.tbAsignaSerieUbicacion = New System.Windows.Forms.TabControl()
        Me.TabPageLotes = New System.Windows.Forms.TabPage()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dtgLotes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.PSCRTLTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQINMC2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TabPageUbicacion = New System.Windows.Forms.TabPage()
        Me.TabPageSerie = New System.Windows.Forms.TabPage()
        Me.TabPageProyecto = New System.Windows.Forms.TabPage()
        Me.hgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaProcesarGuia = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaProcesarRecepcion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCancelarRecepcion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaEliminarItem = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.dgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.hgGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaAgregar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnOcultar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.dgvLotes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.N_CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CRTLTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_SF_FINGAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_SF_FPRDMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_SF_FVNLTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_QMRCSL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.chkEtiqueta = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtGuiaIngreso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblGuiaIngreso = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkServicio = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroGuia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblNroGuia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtZona = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblNroOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
        Me.OFUNCTL = New System.Data.DataColumn()
        Me.OQMRCD1 = New System.Data.DataColumn()
        Me.OQPSMR1 = New System.Data.DataColumn()
        Me.OQVLMR1 = New System.Data.DataColumn()
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
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
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcUbicaciones_Lista = New Ransa.Controls.ucUbicaciones_Dg()
        Me.UcSerie_Lista = New Ransa.Controls.Serie.ucSerie_Dg()
        Me.UcProyectos_Lista = New Ransa.CONTROL.ucProyecto()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.S_CTPOCN = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FILA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_QTRMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_LOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CUNCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_QTRMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CUNPST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.S_QDSVGN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CCNTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_CTPDPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_TOBSRV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_FMPDME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUNCTL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUBICAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCNTSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.grpListadoMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpListadoMercaderia.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpListadoMercaderia.Panel.SuspendLayout()
        Me.grpListadoMercaderia.SuspendLayout()
        CType(Me.hgSerie_Ubicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgSerie_Ubicacion.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgSerie_Ubicacion.Panel.SuspendLayout()
        Me.hgSerie_Ubicacion.SuspendLayout()
        Me.tbAsignaSerieUbicacion.SuspendLayout()
        Me.TabPageLotes.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dtgLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.TabPageUbicacion.SuspendLayout()
        Me.TabPageSerie.SuspendLayout()
        Me.TabPageProyecto.SuspendLayout()
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgMercaderiaSeleccionada.Panel.SuspendLayout()
        Me.hgMercaderiaSeleccionada.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGuiaRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGuiaRemision.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgGuiaRemision.Panel.SuspendLayout()
        Me.hgGuiaRemision.SuspendLayout()
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CUNVL3
        '
        Me.CUNVL3.ColumnName = "CUNVL3"
        '
        'CUNPS3
        '
        Me.CUNPS3.ColumnName = "CUNPS3"
        '
        'CUNCN3
        '
        Me.CUNCN3.ColumnName = "CUNCN3"
        '
        'CTPDP3
        '
        Me.CTPDP3.ColumnName = "CTPDP3"
        '
        'CTPPR1
        '
        Me.CTPPR1.ColumnName = "CTPPR1"
        '
        'TABDPS
        '
        Me.TABDPS.ColumnName = "TABDPS"
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
        Me.dtMercaderiaSeleccionadas.Columns.AddRange(New System.Data.DataColumn() {Me.SCMRCLR, Me.STMRCD2, Me.SCMRCD, Me.SNORDSR, Me.SNCNTR, Me.SNCRCTC, Me.SNAUTR, Me.SCUNCNT, Me.SCUNPST, Me.SCUNVLT, Me.SNORCCL, Me.SNGUICL, Me.SNRUCLL, Me.SSTPING, Me.SCTPALM, Me.STALMC, Me.SCALMC, Me.STCMPAL, Me.SCZNALM, Me.STCMZNA, Me.SQTRMC, Me.SQTRMP, Me.SQDSVGN, Me.SCCNTD, Me.SCTPOCN, Me.SFUNDS2, Me.SCTPDPS, Me.STOBSRV, Me.DataColumn4, Me.SNRITOC, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
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
        'SNRITOC
        '
        Me.SNRITOC.ColumnName = "NRITOC"
        Me.SNRITOC.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "LOTE"
        Me.DataColumn5.DataType = GetType(Long)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "FMPDME"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "FUNCTL"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "FUBICAC"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "SCNTSR"
        '
        'dstContratos
        '
        Me.dstContratos.DataSetName = "NewDataSet"
        Me.dstContratos.Tables.AddRange(New System.Data.DataTable() {Me.dtContratos})
        '
        'dtContratos
        '
        Me.dtContratos.Columns.AddRange(New System.Data.DataColumn() {Me.NCNTR, Me.CTPDP3, Me.TABDPS, Me.CTPPR1, Me.CUNCN3, Me.CUNPS3, Me.CUNVL3})
        Me.dtContratos.TableName = "dtContratos"
        '
        'NCNTR
        '
        Me.NCNTR.ColumnName = "NCNTR"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.grpListadoMercaderia)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1373, 746)
        Me.KryptonPanel.TabIndex = 1
        '
        'grpListadoMercaderia
        '
        Me.grpListadoMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpListadoMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.grpListadoMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.grpListadoMercaderia.Name = "grpListadoMercaderia"
        '
        'grpListadoMercaderia.Panel
        '
        Me.grpListadoMercaderia.Panel.Controls.Add(Me.hgSerie_Ubicacion)
        Me.grpListadoMercaderia.Panel.Controls.Add(Me.hgMercaderiaSeleccionada)
        Me.grpListadoMercaderia.Panel.Controls.Add(Me.hgFiltros)
        Me.grpListadoMercaderia.Size = New System.Drawing.Size(1373, 746)
        Me.grpListadoMercaderia.TabIndex = 53
        '
        'hgSerie_Ubicacion
        '
        Me.hgSerie_Ubicacion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaGuardar, Me.bsaCancelar})
        Me.hgSerie_Ubicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgSerie_Ubicacion.HeaderVisibleSecondary = False
        Me.hgSerie_Ubicacion.Location = New System.Drawing.Point(0, 412)
        Me.hgSerie_Ubicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.hgSerie_Ubicacion.Name = "hgSerie_Ubicacion"
        '
        'hgSerie_Ubicacion.Panel
        '
        Me.hgSerie_Ubicacion.Panel.Controls.Add(Me.tbAsignaSerieUbicacion)
        Me.hgSerie_Ubicacion.Size = New System.Drawing.Size(1371, 332)
        Me.hgSerie_Ubicacion.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.hgSerie_Ubicacion.TabIndex = 56
        Me.hgSerie_Ubicacion.Text = "Ingresar Series - Ubicación "
        Me.hgSerie_Ubicacion.ValuesPrimary.Description = ""
        Me.hgSerie_Ubicacion.ValuesPrimary.Heading = "Ingresar Series - Ubicación "
        Me.hgSerie_Ubicacion.ValuesPrimary.Image = Nothing
        Me.hgSerie_Ubicacion.ValuesSecondary.Description = ""
        Me.hgSerie_Ubicacion.ValuesSecondary.Heading = " "
        Me.hgSerie_Ubicacion.ValuesSecondary.Image = Nothing
        '
        'bsaGuardar
        '
        Me.bsaGuardar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.bsaGuardar.ExtraText = ""
        Me.bsaGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.bsaGuardar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaGuardar.Text = "Procesar Recep/Ubicación"
        Me.bsaGuardar.ToolTipImage = Nothing
        Me.bsaGuardar.UniqueName = "3B85062E1CDF415D3B85062E1CDF415D"
        '
        'bsaCancelar
        '
        Me.bsaCancelar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.bsaCancelar.ExtraText = ""
        Me.bsaCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.bsaCancelar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaCancelar.Text = "Cancelar Recep/Ubicación"
        Me.bsaCancelar.ToolTipImage = Nothing
        Me.bsaCancelar.UniqueName = "AC06B4049E844A33AC06B4049E844A33"
        '
        'tbAsignaSerieUbicacion
        '
        Me.tbAsignaSerieUbicacion.Controls.Add(Me.TabPageLotes)
        Me.tbAsignaSerieUbicacion.Controls.Add(Me.TabPageUbicacion)
        Me.tbAsignaSerieUbicacion.Controls.Add(Me.TabPageSerie)
        Me.tbAsignaSerieUbicacion.Controls.Add(Me.TabPageProyecto)
        Me.tbAsignaSerieUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbAsignaSerieUbicacion.Location = New System.Drawing.Point(0, 0)
        Me.tbAsignaSerieUbicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAsignaSerieUbicacion.Name = "tbAsignaSerieUbicacion"
        Me.tbAsignaSerieUbicacion.SelectedIndex = 0
        Me.tbAsignaSerieUbicacion.Size = New System.Drawing.Size(1369, 297)
        Me.tbAsignaSerieUbicacion.TabIndex = 56
        '
        'TabPageLotes
        '
        Me.TabPageLotes.Controls.Add(Me.KryptonPanel1)
        Me.TabPageLotes.Location = New System.Drawing.Point(4, 25)
        Me.TabPageLotes.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageLotes.Name = "TabPageLotes"
        Me.TabPageLotes.Size = New System.Drawing.Size(1361, 268)
        Me.TabPageLotes.TabIndex = 2
        Me.TabPageLotes.Text = "Lotes"
        Me.TabPageLotes.UseVisualStyleBackColor = True
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dtgLotes)
        Me.KryptonPanel1.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1361, 268)
        Me.KryptonPanel1.TabIndex = 0
        '
        'dtgLotes
        '
        Me.dtgLotes.AllowUserToAddRows = False
        Me.dtgLotes.AllowUserToDeleteRows = False
        Me.dtgLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSCRTLTE, Me.PNQINMC2, Me.Column1, Me.Column2, Me.Column3})
        Me.dtgLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgLotes.Location = New System.Drawing.Point(0, 27)
        Me.dtgLotes.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgLotes.Name = "dtgLotes"
        Me.dtgLotes.ReadOnly = True
        Me.dtgLotes.Size = New System.Drawing.Size(1361, 241)
        Me.dtgLotes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgLotes.TabIndex = 66
        '
        'PSCRTLTE
        '
        Me.PSCRTLTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSCRTLTE.HeaderText = "Lote"
        Me.PSCRTLTE.Name = "PSCRTLTE"
        Me.PSCRTLTE.ReadOnly = True
        '
        'PNQINMC2
        '
        Me.PNQINMC2.HeaderText = "Cantidad"
        Me.PNQINMC2.Name = "PNQINMC2"
        Me.PNQINMC2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Fecha Ingreso"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 133
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Fecha Producción"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 158
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Fecha Vencimiento"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 166
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregar, Me.tssSep_03, Me.ToolStripLabel1})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(1361, 27)
        Me.tsMenuOpciones.TabIndex = 23
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(87, 24)
        Me.btnAgregar.Text = "&Agregar"
        '
        'tssSep_03
        '
        Me.tssSep_03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_03.Name = "tssSep_03"
        Me.tssSep_03.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(96, 24)
        Me.ToolStripLabel1.Text = "Lista de lotes"
        '
        'TabPageUbicacion
        '
        Me.TabPageUbicacion.Controls.Add(Me.UcUbicaciones_Lista)
        Me.TabPageUbicacion.Location = New System.Drawing.Point(4, 25)
        Me.TabPageUbicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageUbicacion.Name = "TabPageUbicacion"
        Me.TabPageUbicacion.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageUbicacion.Size = New System.Drawing.Size(1361, 268)
        Me.TabPageUbicacion.TabIndex = 1
        Me.TabPageUbicacion.Text = "Ubicaciones"
        Me.TabPageUbicacion.UseVisualStyleBackColor = True
        '
        'TabPageSerie
        '
        Me.TabPageSerie.Controls.Add(Me.UcSerie_Lista)
        Me.TabPageSerie.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSerie.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageSerie.Name = "TabPageSerie"
        Me.TabPageSerie.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageSerie.Size = New System.Drawing.Size(1361, 268)
        Me.TabPageSerie.TabIndex = 0
        Me.TabPageSerie.Text = "Series"
        Me.TabPageSerie.UseVisualStyleBackColor = True
        '
        'TabPageProyecto
        '
        Me.TabPageProyecto.Controls.Add(Me.UcProyectos_Lista)
        Me.TabPageProyecto.Location = New System.Drawing.Point(4, 25)
        Me.TabPageProyecto.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPageProyecto.Name = "TabPageProyecto"
        Me.TabPageProyecto.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPageProyecto.Size = New System.Drawing.Size(1361, 268)
        Me.TabPageProyecto.TabIndex = 1
        Me.TabPageProyecto.Text = "Proyectos"
        Me.TabPageProyecto.UseVisualStyleBackColor = True
        '
        'hgMercaderiaSeleccionada
        '
        Me.hgMercaderiaSeleccionada.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaProcesarGuia, Me.bsaProcesarRecepcion, Me.bsaCancelarRecepcion})
        Me.hgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgMercaderiaSeleccionada.HeaderVisibleSecondary = False
        Me.hgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 123)
        Me.hgMercaderiaSeleccionada.Margin = New System.Windows.Forms.Padding(4)
        Me.hgMercaderiaSeleccionada.Name = "hgMercaderiaSeleccionada"
        '
        'hgMercaderiaSeleccionada.Panel
        '
        Me.hgMercaderiaSeleccionada.Panel.Controls.Add(Me.KryptonSplitContainer1)
        Me.hgMercaderiaSeleccionada.Size = New System.Drawing.Size(1371, 289)
        Me.hgMercaderiaSeleccionada.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgMercaderiaSeleccionada.TabIndex = 55
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Heading = ""
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Image = Nothing
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Heading = "Description"
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Image = Nothing
        '
        'bsaProcesarGuia
        '
        Me.bsaProcesarGuia.ExtraText = ""
        Me.bsaProcesarGuia.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.bsaProcesarGuia.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaProcesarGuia.Text = "Procesar Guía"
        Me.bsaProcesarGuia.ToolTipImage = Nothing
        Me.bsaProcesarGuia.UniqueName = "5C97341EF07340AE5C97341EF07340AE"
        Me.bsaProcesarGuia.Visible = False
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
        'bsaCancelarRecepcion
        '
        Me.bsaCancelarRecepcion.ExtraText = ""
        Me.bsaCancelarRecepcion.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.bsaCancelarRecepcion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaCancelarRecepcion.Text = "Cancelar Recepción"
        Me.bsaCancelarRecepcion.ToolTipImage = Nothing
        Me.bsaCancelarRecepcion.UniqueName = "980F58D336B54F90980F58D336B54F90"
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonHeaderGroup1)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.hgGuiaRemision)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1369, 254)
        Me.KryptonSplitContainer1.SplitterDistance = 878
        Me.KryptonSplitContainer1.TabIndex = 25
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaEliminarItem})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dgMercaderiaSeleccionada)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(878, 254)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 69
        Me.KryptonHeaderGroup1.Text = "Mercadería Seleccionada"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Mercadería Seleccionada"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'bsaEliminarItem
        '
        Me.bsaEliminarItem.ExtraText = ""
        Me.bsaEliminarItem.Image = Global.SOLMIN_SA.My.Resources.Resources.AnularItem
        Me.bsaEliminarItem.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaEliminarItem.Text = "Eliminar Item"
        Me.bsaEliminarItem.ToolTipImage = Nothing
        Me.bsaEliminarItem.UniqueName = "436771B1CAC7420C436771B1CAC7420C"
        '
        'dgMercaderiaSeleccionada
        '
        Me.dgMercaderiaSeleccionada.AllowUserToAddRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToDeleteRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeColumns = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeRows = False
        Me.dgMercaderiaSeleccionada.AutoGenerateColumns = False
        Me.dgMercaderiaSeleccionada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaSeleccionada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_CTPOCN, Me.FILA, Me.S_CMRCLR, Me.S_TMRCD2, Me.S_CMRCD, Me.S_NORDSR, Me.S_QTRMC, Me.S_LOTE, Me.S_CUNCNT, Me.S_QTRMP, Me.S_CUNPST, Me.S_NCNTR, Me.S_NCRCTC, Me.S_NAUTR, Me.S_CUNVLT, Me.S_NORCCL, Me.S_NGUICL, Me.S_NRUCLL, Me.S_STPING, Me.S_CTPALM, Me.S_TALMC, Me.S_CALMC, Me.S_TCMPAL, Me.S_CZNALM, Me.S_TCMZNA, Me.S_QDSVGN, Me.S_CCNTD, Me.S_FUNDS2, Me.S_CTPDPS, Me.S_TOBSRV, Me.S_NRITOC, Me.S_FMPDME, Me.FUNCTL, Me.FUBICAC, Me.SCNTSR})
        Me.dgMercaderiaSeleccionada.DataMember = "dtMercaderiaSeleccionadas"
        Me.dgMercaderiaSeleccionada.DataSource = Me.dstMercaderia
        Me.dgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderiaSeleccionada.Margin = New System.Windows.Forms.Padding(4)
        Me.dgMercaderiaSeleccionada.MultiSelect = False
        Me.dgMercaderiaSeleccionada.Name = "dgMercaderiaSeleccionada"
        Me.dgMercaderiaSeleccionada.ReadOnly = True
        Me.dgMercaderiaSeleccionada.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaSeleccionada.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMercaderiaSeleccionada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaSeleccionada.Size = New System.Drawing.Size(876, 219)
        Me.dgMercaderiaSeleccionada.StandardTab = True
        Me.dgMercaderiaSeleccionada.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderiaSeleccionada.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderiaSeleccionada.TabIndex = 24
        '
        'hgGuiaRemision
        '
        Me.hgGuiaRemision.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaAgregar, Me.btnOcultar})
        Me.hgGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgGuiaRemision.HeaderVisibleSecondary = False
        Me.hgGuiaRemision.Location = New System.Drawing.Point(0, 0)
        Me.hgGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.hgGuiaRemision.Name = "hgGuiaRemision"
        '
        'hgGuiaRemision.Panel
        '
        Me.hgGuiaRemision.Panel.Controls.Add(Me.dgvLotes)
        Me.hgGuiaRemision.Size = New System.Drawing.Size(486, 254)
        Me.hgGuiaRemision.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgGuiaRemision.TabIndex = 68
        Me.hgGuiaRemision.Text = "Lotes"
        Me.hgGuiaRemision.ValuesPrimary.Description = ""
        Me.hgGuiaRemision.ValuesPrimary.Heading = "Lotes"
        Me.hgGuiaRemision.ValuesPrimary.Image = Nothing
        Me.hgGuiaRemision.ValuesSecondary.Description = ""
        Me.hgGuiaRemision.ValuesSecondary.Heading = "Description"
        Me.hgGuiaRemision.ValuesSecondary.Image = Nothing
        '
        'bsaAgregar
        '
        Me.bsaAgregar.ExtraText = ""
        Me.bsaAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.application_add
        Me.bsaAgregar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaAgregar.Text = "Agregar"
        Me.bsaAgregar.ToolTipImage = Nothing
        Me.bsaAgregar.UniqueName = "E84D614FF9224F52E84D614FF9224F52"
        '
        'btnOcultar
        '
        Me.btnOcultar.ExtraText = ""
        Me.btnOcultar.Image = Nothing
        Me.btnOcultar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnOcultar.Text = "Ocultar"
        Me.btnOcultar.ToolTipImage = Nothing
        Me.btnOcultar.UniqueName = "3D460390D875430D3D460390D875430D"
        '
        'dgvLotes
        '
        Me.dgvLotes.AllowUserToAddRows = False
        Me.dgvLotes.AllowUserToDeleteRows = False
        Me.dgvLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.N_CANTIDAD, Me.S_CRTLTE, Me.S_SF_FINGAL, Me.S_SF_FPRDMR, Me.S_SF_FVNLTE, Me.N_QMRCSL})
        Me.dgvLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLotes.Location = New System.Drawing.Point(0, 0)
        Me.dgvLotes.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvLotes.Name = "dgvLotes"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLotes.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLotes.Size = New System.Drawing.Size(484, 219)
        Me.dgvLotes.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvLotes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvLotes.TabIndex = 67
        '
        'N_CANTIDAD
        '
        Me.N_CANTIDAD.DataPropertyName = "CANTIDAD"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.N_CANTIDAD.DefaultCellStyle = DataGridViewCellStyle2
        Me.N_CANTIDAD.HeaderText = "Cantidad Recibir"
        Me.N_CANTIDAD.Name = "N_CANTIDAD"
        '
        'S_CRTLTE
        '
        Me.S_CRTLTE.DataPropertyName = "CRTLTE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.S_CRTLTE.DefaultCellStyle = DataGridViewCellStyle3
        Me.S_CRTLTE.HeaderText = "Criterio de Lote"
        Me.S_CRTLTE.Name = "S_CRTLTE"
        Me.S_CRTLTE.ReadOnly = True
        '
        'S_SF_FINGAL
        '
        Me.S_SF_FINGAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.S_SF_FINGAL.DataPropertyName = "SF_FINGAL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.S_SF_FINGAL.DefaultCellStyle = DataGridViewCellStyle4
        Me.S_SF_FINGAL.HeaderText = "Fecha Ingreso"
        Me.S_SF_FINGAL.Name = "S_SF_FINGAL"
        Me.S_SF_FINGAL.ReadOnly = True
        Me.S_SF_FINGAL.Width = 133
        '
        'S_SF_FPRDMR
        '
        Me.S_SF_FPRDMR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.S_SF_FPRDMR.DataPropertyName = "SF_FPRDMR"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.S_SF_FPRDMR.DefaultCellStyle = DataGridViewCellStyle5
        Me.S_SF_FPRDMR.HeaderText = "Fecha Producción"
        Me.S_SF_FPRDMR.Name = "S_SF_FPRDMR"
        Me.S_SF_FPRDMR.ReadOnly = True
        Me.S_SF_FPRDMR.Width = 158
        '
        'S_SF_FVNLTE
        '
        Me.S_SF_FVNLTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.S_SF_FVNLTE.DataPropertyName = "SF_FVNLTE"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.S_SF_FVNLTE.DefaultCellStyle = DataGridViewCellStyle6
        Me.S_SF_FVNLTE.HeaderText = "Fecha Vencimiento"
        Me.S_SF_FVNLTE.Name = "S_SF_FVNLTE"
        Me.S_SF_FVNLTE.ReadOnly = True
        Me.S_SF_FVNLTE.Width = 166
        '
        'N_QMRCSL
        '
        Me.N_QMRCSL.DataPropertyName = "QMRCSL"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.N_QMRCSL.DefaultCellStyle = DataGridViewCellStyle7
        Me.N_QMRCSL.HeaderText = "Stock "
        Me.N_QMRCSL.Name = "N_QMRCSL"
        Me.N_QMRCSL.ReadOnly = True
        '
        'hgFiltros
        '
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Margin = New System.Windows.Forms.Padding(4)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.chkEtiqueta)
        Me.hgFiltros.Panel.Controls.Add(Me.txtGuiaIngreso)
        Me.hgFiltros.Panel.Controls.Add(Me.lblGuiaIngreso)
        Me.hgFiltros.Panel.Controls.Add(Me.chkServicio)
        Me.hgFiltros.Panel.Controls.Add(Me.txtProveedor)
        Me.hgFiltros.Panel.Controls.Add(Me.lblProveedor)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.txtNroGuia)
        Me.hgFiltros.Panel.Controls.Add(Me.lblNroGuia)
        Me.hgFiltros.Panel.Controls.Add(Me.txtZona)
        Me.hgFiltros.Panel.Controls.Add(Me.txtAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.txtTipoAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.txtNroOrdenCompra)
        Me.hgFiltros.Panel.Controls.Add(Me.lblNroOrdenCompra)
        Me.hgFiltros.Panel.Controls.Add(Me.lblAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblZonaAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.hgFiltros.Size = New System.Drawing.Size(1371, 123)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 53
        Me.hgFiltros.ValuesPrimary.Description = ""
        Me.hgFiltros.ValuesPrimary.Heading = ""
        Me.hgFiltros.ValuesPrimary.Image = Nothing
        Me.hgFiltros.ValuesSecondary.Description = ""
        Me.hgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.hgFiltros.ValuesSecondary.Image = Nothing
        '
        'chkEtiqueta
        '
        Me.chkEtiqueta.Checked = False
        Me.chkEtiqueta.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkEtiqueta.Location = New System.Drawing.Point(940, 81)
        Me.chkEtiqueta.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEtiqueta.Name = "chkEtiqueta"
        Me.chkEtiqueta.Size = New System.Drawing.Size(143, 24)
        Me.chkEtiqueta.TabIndex = 73
        Me.chkEtiqueta.Text = "Imprimir Etiqueta"
        Me.chkEtiqueta.Values.ExtraText = ""
        Me.chkEtiqueta.Values.Image = Nothing
        Me.chkEtiqueta.Values.Text = "Imprimir Etiqueta"
        '
        'txtGuiaIngreso
        '
        Me.txtGuiaIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuiaIngreso.Location = New System.Drawing.Point(553, 85)
        Me.txtGuiaIngreso.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuiaIngreso.MaxLength = 25
        Me.txtGuiaIngreso.Name = "txtGuiaIngreso"
        Me.txtGuiaIngreso.ReadOnly = True
        Me.txtGuiaIngreso.Size = New System.Drawing.Size(153, 26)
        Me.txtGuiaIngreso.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGuiaIngreso.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtGuiaIngreso.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtGuiaIngreso.TabIndex = 34
        Me.txtGuiaIngreso.TabStop = False
        Me.txtGuiaIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuiaIngreso
        '
        Me.lblGuiaIngreso.Location = New System.Drawing.Point(448, 86)
        Me.lblGuiaIngreso.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGuiaIngreso.Name = "lblGuiaIngreso"
        Me.lblGuiaIngreso.Size = New System.Drawing.Size(105, 24)
        Me.lblGuiaIngreso.TabIndex = 33
        Me.lblGuiaIngreso.Text = "Guía Ingreso :"
        Me.lblGuiaIngreso.Values.ExtraText = ""
        Me.lblGuiaIngreso.Values.Image = Nothing
        Me.lblGuiaIngreso.Values.Text = "Guía Ingreso :"
        '
        'chkServicio
        '
        Me.chkServicio.Checked = False
        Me.chkServicio.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkServicio.Location = New System.Drawing.Point(940, 49)
        Me.chkServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.chkServicio.Name = "chkServicio"
        Me.chkServicio.Size = New System.Drawing.Size(142, 24)
        Me.chkServicio.TabIndex = 32
        Me.chkServicio.Text = "Registrar Servicio"
        Me.chkServicio.Values.ExtraText = ""
        Me.chkServicio.Values.Image = Nothing
        Me.chkServicio.Values.Text = "Registrar Servicio"
        '
        'txtProveedor
        '
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.Location = New System.Drawing.Point(120, 85)
        Me.txtProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProveedor.MaxLength = 25
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(327, 26)
        Me.txtProveedor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProveedor.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtProveedor.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtProveedor.TabIndex = 31
        Me.txtProveedor.TabStop = False
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(7, 86)
        Me.lblProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(89, 24)
        Me.lblProveedor.TabIndex = 30
        Me.lblProveedor.Text = "Proveedor : "
        Me.lblProveedor.Values.ExtraText = ""
        Me.lblProveedor.Values.Image = Nothing
        Me.lblProveedor.Values.Text = "Proveedor : "
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(553, 48)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCliente.MaxLength = 25
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(320, 26)
        Me.txtCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtCliente.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtCliente.TabIndex = 29
        Me.txtCliente.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(448, 49)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 24)
        Me.lblCliente.TabIndex = 28
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'txtNroGuia
        '
        Me.txtNroGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroGuia.Location = New System.Drawing.Point(339, 48)
        Me.txtNroGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroGuia.MaxLength = 25
        Me.txtNroGuia.Name = "txtNroGuia"
        Me.txtNroGuia.ReadOnly = True
        Me.txtNroGuia.Size = New System.Drawing.Size(107, 26)
        Me.txtNroGuia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroGuia.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroGuia.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroGuia.TabIndex = 26
        Me.txtNroGuia.TabStop = False
        Me.txtNroGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNroGuia
        '
        Me.lblNroGuia.Location = New System.Drawing.Point(252, 49)
        Me.lblNroGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNroGuia.Name = "lblNroGuia"
        Me.lblNroGuia.Size = New System.Drawing.Size(84, 24)
        Me.lblNroGuia.TabIndex = 27
        Me.lblNroGuia.Text = "Nro. Guía : "
        Me.lblNroGuia.Values.ExtraText = ""
        Me.lblNroGuia.Values.Image = Nothing
        Me.lblNroGuia.Values.Text = "Nro. Guía : "
        '
        'txtZona
        '
        Me.txtZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtZona.Location = New System.Drawing.Point(940, 11)
        Me.txtZona.Margin = New System.Windows.Forms.Padding(4)
        Me.txtZona.MaxLength = 25
        Me.txtZona.Name = "txtZona"
        Me.txtZona.ReadOnly = True
        Me.txtZona.Size = New System.Drawing.Size(320, 26)
        Me.txtZona.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtZona.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtZona.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtZona.TabIndex = 25
        Me.txtZona.TabStop = False
        '
        'txtAlmacen
        '
        Me.txtAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlmacen.Location = New System.Drawing.Point(553, 11)
        Me.txtAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen.MaxLength = 25
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(320, 26)
        Me.txtAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlmacen.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtAlmacen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtAlmacen.TabIndex = 24
        Me.txtAlmacen.TabStop = False
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(119, 11)
        Me.txtTipoAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoAlmacen.MaxLength = 25
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.ReadOnly = True
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(327, 26)
        Me.txtTipoAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoAlmacen.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtTipoAlmacen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtTipoAlmacen.TabIndex = 23
        Me.txtTipoAlmacen.TabStop = False
        '
        'txtNroOrdenCompra
        '
        Me.txtNroOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroOrdenCompra.Location = New System.Drawing.Point(120, 48)
        Me.txtNroOrdenCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroOrdenCompra.MaxLength = 25
        Me.txtNroOrdenCompra.Name = "txtNroOrdenCompra"
        Me.txtNroOrdenCompra.ReadOnly = True
        Me.txtNroOrdenCompra.Size = New System.Drawing.Size(129, 26)
        Me.txtNroOrdenCompra.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroOrdenCompra.StateDisabled.Back.Color1 = System.Drawing.Color.PeachPuff
        Me.txtNroOrdenCompra.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroOrdenCompra.TabIndex = 1
        Me.txtNroOrdenCompra.TabStop = False
        Me.txtNroOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNroOrdenCompra
        '
        Me.lblNroOrdenCompra.Location = New System.Drawing.Point(7, 49)
        Me.lblNroOrdenCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNroOrdenCompra.Name = "lblNroOrdenCompra"
        Me.lblNroOrdenCompra.Size = New System.Drawing.Size(80, 24)
        Me.lblNroOrdenCompra.TabIndex = 15
        Me.lblNroOrdenCompra.Text = "Nro. O/C : "
        Me.lblNroOrdenCompra.Values.ExtraText = ""
        Me.lblNroOrdenCompra.Values.Image = Nothing
        Me.lblNroOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(448, 12)
        Me.lblAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(78, 24)
        Me.lblAlmacen.TabIndex = 18
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'lblZonaAlmacen
        '
        Me.lblZonaAlmacen.Location = New System.Drawing.Point(880, 12)
        Me.lblZonaAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblZonaAlmacen.Name = "lblZonaAlmacen"
        Me.lblZonaAlmacen.Size = New System.Drawing.Size(54, 24)
        Me.lblZonaAlmacen.TabIndex = 20
        Me.lblZonaAlmacen.Text = "Zona : "
        Me.lblZonaAlmacen.Values.ExtraText = ""
        Me.lblZonaAlmacen.Values.Image = Nothing
        Me.lblZonaAlmacen.Values.Text = "Zona : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(7, 12)
        Me.lblTipoAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(112, 24)
        Me.lblTipoAlmacen.TabIndex = 16
        Me.lblTipoAlmacen.Text = "Tipo Almacén : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo Almacén : "
        '
        'dstOrdenServicio
        '
        Me.dstOrdenServicio.DataSetName = "NewDataSet"
        Me.dstOrdenServicio.Tables.AddRange(New System.Data.DataTable() {Me.dtOrdenServicio})
        '
        'dtOrdenServicio
        '
        Me.dtOrdenServicio.Columns.AddRange(New System.Data.DataColumn() {Me.ONORDSR, Me.ONCNTR, Me.ONCRCTC, Me.ONAUTR, Me.OFEMORS, Me.OCTPDP6, Me.OQSLMC, Me.OCUNCN5, Me.OQSLMP, Me.OCUNPS5, Me.OQSLMV, Me.OCUNVL5, Me.OFUNDS2, Me.OFUNCTL, Me.OQMRCD1, Me.OQPSMR1, Me.OQVLMR1})
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
        'OFUNCTL
        '
        Me.OFUNCTL.ColumnName = "FUNCTL"
        '
        'OQMRCD1
        '
        Me.OQMRCD1.ColumnName = "QMRCD1"
        '
        'OQPSMR1
        '
        Me.OQPSMR1.ColumnName = "QPSMR1"
        '
        'OQVLMR1
        '
        Me.OQVLMR1.ColumnName = "QVLMR1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CMRCLR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mercadería"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TMRCD2"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CMRCD"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cód. Ransa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NORDSR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Orden Servicio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NCNTR"
        Me.DataGridViewTextBoxColumn5.HeaderText = "No. Contrato"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NCRCTC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Correlativo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 86
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NAUTR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "No Autorización"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 111
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CUNCNT"
        Me.DataGridViewTextBoxColumn8.HeaderText = "U. Cantidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 92
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CUNPST"
        Me.DataGridViewTextBoxColumn9.HeaderText = "U. Peso"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 74
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CUNVLT"
        Me.DataGridViewTextBoxColumn10.HeaderText = "U. Valor"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 74
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "NORCCL"
        Me.DataGridViewTextBoxColumn11.HeaderText = "No O/C"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 73
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NGUICL"
        Me.DataGridViewTextBoxColumn12.HeaderText = "No Guía Cliente"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 112
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NRUCLL"
        Me.DataGridViewTextBoxColumn13.HeaderText = "No RUC Cliente"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 111
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "STPING"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Tipo Mov."
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 84
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CTPALM"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tipo Almacén"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 101
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TALMC"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 69
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CALMC"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Almacén"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn17.Width = 77
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "TCMPAL"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn18.Width = 69
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CZNALM"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 61
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TCMZNA"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 69
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "QTRMC"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 78
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "QTRMP"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn22.Visible = False
        Me.DataGridViewTextBoxColumn22.Width = 60
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "QDSVGN"
        Me.DataGridViewTextBoxColumn23.HeaderText = "No Días Vigencia"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn23.Visible = False
        Me.DataGridViewTextBoxColumn23.Width = 120
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "CCNTD"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Contenedor"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn24.Visible = False
        Me.DataGridViewTextBoxColumn24.Width = 91
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "FUNDS2"
        Me.DataGridViewTextBoxColumn25.HeaderText = "U. Despacho"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn25.Visible = False
        Me.DataGridViewTextBoxColumn25.Width = 99
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "CTPDPS"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Tipo Depósito"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn26.Visible = False
        Me.DataGridViewTextBoxColumn26.Width = 102
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "TOBSRV"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn27.Visible = False
        Me.DataGridViewTextBoxColumn27.Width = 107
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "NORDSR"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Nro. O/S"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn28.Visible = False
        Me.DataGridViewTextBoxColumn28.Width = 79
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "NCNTR"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Contrato"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn29.Visible = False
        Me.DataGridViewTextBoxColumn29.Width = 76
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "NCRCTC"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Corr."
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn30.Visible = False
        Me.DataGridViewTextBoxColumn30.Width = 58
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "NAUTR"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Autorización"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn31.Visible = False
        Me.DataGridViewTextBoxColumn31.Width = 94
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "FEMORS"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn32.Width = 66
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "CTPDP6"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Tipo Depósito"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn33.Width = 102
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "QSLMC"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N4"
        DataGridViewCellStyle9.NullValue = "0.0000"
        Me.DataGridViewTextBoxColumn34.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn34.HeaderText = "S. Cantidad"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn34.Visible = False
        Me.DataGridViewTextBoxColumn34.Width = 91
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "CUNCN5"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Visible = False
        Me.DataGridViewTextBoxColumn35.Width = 70
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "QSLMP"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N4"
        DataGridViewCellStyle10.NullValue = "0.0000"
        Me.DataGridViewTextBoxColumn36.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn36.HeaderText = "S. Peso"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Visible = False
        Me.DataGridViewTextBoxColumn36.Width = 73
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "CUNPS5"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn37.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn37.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Visible = False
        Me.DataGridViewTextBoxColumn37.Width = 70
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "QSLMV"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N4"
        DataGridViewCellStyle12.NullValue = "0.0000"
        Me.DataGridViewTextBoxColumn38.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn38.HeaderText = "S. Valor"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Visible = False
        Me.DataGridViewTextBoxColumn38.Width = 73
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "CUNVL5"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn39.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn39.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "FUNDS2"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn40.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn40.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Visible = False
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "FUNCTL"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N4"
        DataGridViewCellStyle15.NullValue = "0.0000"
        Me.DataGridViewTextBoxColumn41.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn41.HeaderText = "U Despacho"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Visible = False
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "QMRCD1"
        Me.DataGridViewTextBoxColumn42.HeaderText = "QMRCD1"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Visible = False
        Me.DataGridViewTextBoxColumn42.Width = 82
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "QPSMR1"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N4"
        DataGridViewCellStyle16.NullValue = "0.0000"
        Me.DataGridViewTextBoxColumn43.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn43.HeaderText = "QPSMR1"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Visible = False
        Me.DataGridViewTextBoxColumn43.Width = 81
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "QVLMR1"
        Me.DataGridViewTextBoxColumn44.HeaderText = "QVLMR1"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        Me.DataGridViewTextBoxColumn44.Visible = False
        Me.DataGridViewTextBoxColumn44.Width = 80
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "NCNTR"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N4"
        DataGridViewCellStyle17.NullValue = "0.0000"
        Me.DataGridViewTextBoxColumn45.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn45.HeaderText = "Contrato"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Width = 76
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "CTPDP3"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Depósito"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Visible = False
        Me.DataGridViewTextBoxColumn46.Width = 78
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "TABDPS"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Depósito"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        Me.DataGridViewTextBoxColumn47.Visible = False
        Me.DataGridViewTextBoxColumn47.Width = 78
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "CTPPR1"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        Me.DataGridViewTextBoxColumn48.Visible = False
        Me.DataGridViewTextBoxColumn48.Width = 79
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "CUNCN3"
        Me.DataGridViewTextBoxColumn49.HeaderText = "Unidad Cantidad"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        Me.DataGridViewTextBoxColumn49.Visible = False
        Me.DataGridViewTextBoxColumn49.Width = 115
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "CUNPS3"
        Me.DataGridViewTextBoxColumn50.HeaderText = "Unidad Peso"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        Me.DataGridViewTextBoxColumn50.Visible = False
        Me.DataGridViewTextBoxColumn50.Width = 97
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "CUNVL3"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Unidad Valor"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Visible = False
        Me.DataGridViewTextBoxColumn51.Width = 97
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "CMRCLR"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Mercadería"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        Me.DataGridViewTextBoxColumn52.Width = 91
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "TMRCD2"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        Me.DataGridViewTextBoxColumn53.Width = 69
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "CMRCD"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Cód. Ransa"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        Me.DataGridViewTextBoxColumn54.Visible = False
        Me.DataGridViewTextBoxColumn54.Width = 92
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "CUNCNT"
        Me.DataGridViewTextBoxColumn55.HeaderText = "U. Cantidad"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        Me.DataGridViewTextBoxColumn55.Visible = False
        Me.DataGridViewTextBoxColumn55.Width = 92
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "CUNPST"
        Me.DataGridViewTextBoxColumn56.HeaderText = "U. Peso"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        Me.DataGridViewTextBoxColumn56.Visible = False
        Me.DataGridViewTextBoxColumn56.Width = 74
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "CUNVLT"
        Me.DataGridViewTextBoxColumn57.HeaderText = "U. Valor"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        Me.DataGridViewTextBoxColumn57.Visible = False
        Me.DataGridViewTextBoxColumn57.Width = 74
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "NORCCL"
        Me.DataGridViewTextBoxColumn58.HeaderText = "No O/C"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        Me.DataGridViewTextBoxColumn58.Visible = False
        Me.DataGridViewTextBoxColumn58.Width = 73
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "NGUICL"
        Me.DataGridViewTextBoxColumn59.HeaderText = "No Guía Cliente"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.ReadOnly = True
        Me.DataGridViewTextBoxColumn59.Visible = False
        Me.DataGridViewTextBoxColumn59.Width = 112
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "NRUCLL"
        Me.DataGridViewTextBoxColumn60.HeaderText = "No RUC Cliente"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.ReadOnly = True
        Me.DataGridViewTextBoxColumn60.Visible = False
        Me.DataGridViewTextBoxColumn60.Width = 111
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "STPING"
        Me.DataGridViewTextBoxColumn61.HeaderText = "Tipo Mov."
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        Me.DataGridViewTextBoxColumn61.Visible = False
        Me.DataGridViewTextBoxColumn61.Width = 84
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "CTPALM"
        Me.DataGridViewTextBoxColumn62.HeaderText = "Tipo Almacén"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.ReadOnly = True
        Me.DataGridViewTextBoxColumn62.Visible = False
        Me.DataGridViewTextBoxColumn62.Width = 101
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "TALMC"
        Me.DataGridViewTextBoxColumn63.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        Me.DataGridViewTextBoxColumn63.Visible = False
        Me.DataGridViewTextBoxColumn63.Width = 69
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "CALMC"
        Me.DataGridViewTextBoxColumn64.HeaderText = "Almacén"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        Me.DataGridViewTextBoxColumn64.Visible = False
        Me.DataGridViewTextBoxColumn64.Width = 77
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "TCMPAL"
        Me.DataGridViewTextBoxColumn65.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.ReadOnly = True
        Me.DataGridViewTextBoxColumn65.Visible = False
        Me.DataGridViewTextBoxColumn65.Width = 69
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "CZNALM"
        Me.DataGridViewTextBoxColumn66.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.ReadOnly = True
        Me.DataGridViewTextBoxColumn66.Visible = False
        Me.DataGridViewTextBoxColumn66.Width = 61
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "TCMZNA"
        Me.DataGridViewTextBoxColumn67.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.ReadOnly = True
        Me.DataGridViewTextBoxColumn67.Visible = False
        Me.DataGridViewTextBoxColumn67.Width = 69
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "QTRMC"
        Me.DataGridViewTextBoxColumn68.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        Me.DataGridViewTextBoxColumn68.ReadOnly = True
        Me.DataGridViewTextBoxColumn68.Visible = False
        Me.DataGridViewTextBoxColumn68.Width = 60
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "QTRMP"
        Me.DataGridViewTextBoxColumn69.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        Me.DataGridViewTextBoxColumn69.ReadOnly = True
        Me.DataGridViewTextBoxColumn69.Visible = False
        Me.DataGridViewTextBoxColumn69.Width = 60
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "CCNTD"
        Me.DataGridViewTextBoxColumn70.HeaderText = "Contenedor"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        Me.DataGridViewTextBoxColumn70.ReadOnly = True
        Me.DataGridViewTextBoxColumn70.Visible = False
        Me.DataGridViewTextBoxColumn70.Width = 91
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "TOBSRV"
        Me.DataGridViewTextBoxColumn71.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        Me.DataGridViewTextBoxColumn71.ReadOnly = True
        Me.DataGridViewTextBoxColumn71.Visible = False
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "TOBSRV"
        Me.DataGridViewTextBoxColumn72.HeaderText = "Observación"
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        Me.DataGridViewTextBoxColumn72.ReadOnly = True
        Me.DataGridViewTextBoxColumn72.Visible = False
        Me.DataGridViewTextBoxColumn72.Width = 96
        '
        'UcUbicaciones_Lista
        '
        Me.UcUbicaciones_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcUbicaciones_Lista.Enabled = False
        Me.UcUbicaciones_Lista.IndexMercaderia = 0
        Me.UcUbicaciones_Lista.Location = New System.Drawing.Point(4, 4)
        Me.UcUbicaciones_Lista.Lote = ""
        Me.UcUbicaciones_Lista.Margin = New System.Windows.Forms.Padding(5)
        Me.UcUbicaciones_Lista.ModoGrid = Ransa.Controls.eModoGrid.Ingreso
        Me.UcUbicaciones_Lista.Name = "UcUbicaciones_Lista"
        Me.UcUbicaciones_Lista.nLote = 0
        Me.UcUbicaciones_Lista.PanelSearch = False
        Me.UcUbicaciones_Lista.Size = New System.Drawing.Size(1353, 260)
        Me.UcUbicaciones_Lista.TabIndex = 0
        Me.UcUbicaciones_Lista.VisibleCaption = False
        '
        'UcSerie_Lista
        '
        Me.UcSerie_Lista.DespachoIsReadOnly = False
        Me.UcSerie_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcSerie_Lista.GridTipo = Ransa.Controls.Serie.eGridSerieTipo.IngresoSerie
        Me.UcSerie_Lista.Location = New System.Drawing.Point(4, 4)
        Me.UcSerie_Lista.Margin = New System.Windows.Forms.Padding(5)
        Me.UcSerie_Lista.Name = "UcSerie_Lista"
        Me.UcSerie_Lista.Size = New System.Drawing.Size(1353, 260)
        Me.UcSerie_Lista.TabIndex = 30
        '
        'UcProyectos_Lista
        '
        Me.UcProyectos_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcProyectos_Lista.EsDevolucion = False
        Me.UcProyectos_Lista.Location = New System.Drawing.Point(4, 4)
        Me.UcProyectos_Lista.Margin = New System.Windows.Forms.Padding(5)
        Me.UcProyectos_Lista.Name = "UcProyectos_Lista"
        Me.UcProyectos_Lista.Size = New System.Drawing.Size(1353, 260)
        Me.UcProyectos_Lista.TabIndex = 0
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "FILA"
        '
        'S_CTPOCN
        '
        Me.S_CTPOCN.DataPropertyName = "CTPOCN"
        Me.S_CTPOCN.FalseValue = "FALSE"
        Me.S_CTPOCN.HeaderText = "Desglosa"
        Me.S_CTPOCN.Name = "S_CTPOCN"
        Me.S_CTPOCN.ReadOnly = True
        Me.S_CTPOCN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.S_CTPOCN.TrueValue = "TRUE"
        Me.S_CTPOCN.Visible = False
        Me.S_CTPOCN.Width = 80
        '
        'FILA
        '
        Me.FILA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FILA.DataPropertyName = "FILA"
        Me.FILA.HeaderText = "F"
        Me.FILA.Name = "FILA"
        Me.FILA.ReadOnly = True
        Me.FILA.Width = 49
        '
        'S_CMRCLR
        '
        Me.S_CMRCLR.DataPropertyName = "CMRCLR"
        Me.S_CMRCLR.HeaderText = "Mercadería"
        Me.S_CMRCLR.Name = "S_CMRCLR"
        Me.S_CMRCLR.ReadOnly = True
        Me.S_CMRCLR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_CMRCLR.Width = 94
        '
        'S_TMRCD2
        '
        Me.S_TMRCD2.DataPropertyName = "TMRCD2"
        Me.S_TMRCD2.HeaderText = "Detalle"
        Me.S_TMRCD2.Name = "S_TMRCD2"
        Me.S_TMRCD2.ReadOnly = True
        Me.S_TMRCD2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_TMRCD2.Width = 67
        '
        'S_CMRCD
        '
        Me.S_CMRCD.DataPropertyName = "CMRCD"
        Me.S_CMRCD.HeaderText = "Cód. Ransa"
        Me.S_CMRCD.Name = "S_CMRCD"
        Me.S_CMRCD.ReadOnly = True
        Me.S_CMRCD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_CMRCD.Visible = False
        Me.S_CMRCD.Width = 92
        '
        'S_NORDSR
        '
        Me.S_NORDSR.DataPropertyName = "NORDSR"
        Me.S_NORDSR.HeaderText = "Orden Servicio"
        Me.S_NORDSR.Name = "S_NORDSR"
        Me.S_NORDSR.ReadOnly = True
        Me.S_NORDSR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_NORDSR.Width = 116
        '
        'S_QTRMC
        '
        Me.S_QTRMC.DataPropertyName = "QTRMC"
        Me.S_QTRMC.HeaderText = "Cantidad"
        Me.S_QTRMC.Name = "S_QTRMC"
        Me.S_QTRMC.ReadOnly = True
        Me.S_QTRMC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_QTRMC.Width = 79
        '
        'S_LOTE
        '
        Me.S_LOTE.DataPropertyName = "LOTE"
        Me.S_LOTE.HeaderText = "Pendiente Asig. Lote"
        Me.S_LOTE.Name = "S_LOTE"
        Me.S_LOTE.ReadOnly = True
        Me.S_LOTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_LOTE.Width = 153
        '
        'S_CUNCNT
        '
        Me.S_CUNCNT.DataPropertyName = "CUNCNT"
        Me.S_CUNCNT.HeaderText = "U. Cantidad"
        Me.S_CUNCNT.Name = "S_CUNCNT"
        Me.S_CUNCNT.ReadOnly = True
        Me.S_CUNCNT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_CUNCNT.Width = 96
        '
        'S_QTRMP
        '
        Me.S_QTRMP.DataPropertyName = "QTRMP"
        Me.S_QTRMP.HeaderText = "Peso"
        Me.S_QTRMP.Name = "S_QTRMP"
        Me.S_QTRMP.ReadOnly = True
        Me.S_QTRMP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_QTRMP.Width = 49
        '
        'S_CUNPST
        '
        Me.S_CUNPST.DataPropertyName = "CUNPST"
        Me.S_CUNPST.HeaderText = "U. Peso"
        Me.S_CUNPST.Name = "S_CUNPST"
        Me.S_CUNPST.ReadOnly = True
        Me.S_CUNPST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_CUNPST.Width = 66
        '
        'S_NCNTR
        '
        Me.S_NCNTR.DataPropertyName = "NCNTR"
        Me.S_NCNTR.HeaderText = "No. Contrato"
        Me.S_NCNTR.Name = "S_NCNTR"
        Me.S_NCNTR.ReadOnly = True
        Me.S_NCNTR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_NCNTR.Width = 104
        '
        'S_NCRCTC
        '
        Me.S_NCRCTC.DataPropertyName = "NCRCTC"
        Me.S_NCRCTC.HeaderText = "Correlativo"
        Me.S_NCRCTC.Name = "S_NCRCTC"
        Me.S_NCRCTC.ReadOnly = True
        Me.S_NCRCTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_NCRCTC.Width = 92
        '
        'S_NAUTR
        '
        Me.S_NAUTR.DataPropertyName = "NAUTR"
        Me.S_NAUTR.HeaderText = "No Autorización"
        Me.S_NAUTR.Name = "S_NAUTR"
        Me.S_NAUTR.ReadOnly = True
        Me.S_NAUTR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_NAUTR.Width = 127
        '
        'S_CUNVLT
        '
        Me.S_CUNVLT.DataPropertyName = "CUNVLT"
        Me.S_CUNVLT.HeaderText = "U. Valor"
        Me.S_CUNVLT.Name = "S_CUNVLT"
        Me.S_CUNVLT.ReadOnly = True
        Me.S_CUNVLT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_CUNVLT.Width = 70
        '
        'S_NORCCL
        '
        Me.S_NORCCL.DataPropertyName = "NORCCL"
        Me.S_NORCCL.HeaderText = "No O/C"
        Me.S_NORCCL.Name = "S_NORCCL"
        Me.S_NORCCL.ReadOnly = True
        Me.S_NORCCL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_NORCCL.Visible = False
        Me.S_NORCCL.Width = 69
        '
        'S_NGUICL
        '
        Me.S_NGUICL.DataPropertyName = "NGUICL"
        Me.S_NGUICL.HeaderText = "No Guía Cliente"
        Me.S_NGUICL.Name = "S_NGUICL"
        Me.S_NGUICL.ReadOnly = True
        Me.S_NGUICL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_NGUICL.Visible = False
        Me.S_NGUICL.Width = 123
        '
        'S_NRUCLL
        '
        Me.S_NRUCLL.DataPropertyName = "NRUCLL"
        Me.S_NRUCLL.HeaderText = "No RUC Cliente"
        Me.S_NRUCLL.Name = "S_NRUCLL"
        Me.S_NRUCLL.ReadOnly = True
        Me.S_NRUCLL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_NRUCLL.Visible = False
        Me.S_NRUCLL.Width = 121
        '
        'S_STPING
        '
        Me.S_STPING.DataPropertyName = "STPING"
        Me.S_STPING.HeaderText = "Tipo Mov."
        Me.S_STPING.Name = "S_STPING"
        Me.S_STPING.ReadOnly = True
        Me.S_STPING.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_STPING.Width = 85
        '
        'S_CTPALM
        '
        Me.S_CTPALM.DataPropertyName = "CTPALM"
        Me.S_CTPALM.HeaderText = "Tipo Almacén"
        Me.S_CTPALM.Name = "S_CTPALM"
        Me.S_CTPALM.ReadOnly = True
        Me.S_CTPALM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_CTPALM.Visible = False
        Me.S_CTPALM.Width = 111
        '
        'S_TALMC
        '
        Me.S_TALMC.DataPropertyName = "TALMC"
        Me.S_TALMC.HeaderText = "Detalle"
        Me.S_TALMC.Name = "S_TALMC"
        Me.S_TALMC.ReadOnly = True
        Me.S_TALMC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_TALMC.Visible = False
        Me.S_TALMC.Width = 67
        '
        'S_CALMC
        '
        Me.S_CALMC.DataPropertyName = "CALMC"
        Me.S_CALMC.HeaderText = "Almacén"
        Me.S_CALMC.Name = "S_CALMC"
        Me.S_CALMC.ReadOnly = True
        Me.S_CALMC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_CALMC.Visible = False
        Me.S_CALMC.Width = 77
        '
        'S_TCMPAL
        '
        Me.S_TCMPAL.DataPropertyName = "TCMPAL"
        Me.S_TCMPAL.HeaderText = "Detalle"
        Me.S_TCMPAL.Name = "S_TCMPAL"
        Me.S_TCMPAL.ReadOnly = True
        Me.S_TCMPAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_TCMPAL.Visible = False
        Me.S_TCMPAL.Width = 67
        '
        'S_CZNALM
        '
        Me.S_CZNALM.DataPropertyName = "CZNALM"
        Me.S_CZNALM.HeaderText = "Zona"
        Me.S_CZNALM.Name = "S_CZNALM"
        Me.S_CZNALM.ReadOnly = True
        Me.S_CZNALM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_CZNALM.Visible = False
        Me.S_CZNALM.Width = 53
        '
        'S_TCMZNA
        '
        Me.S_TCMZNA.DataPropertyName = "TCMZNA"
        Me.S_TCMZNA.HeaderText = "Detalle"
        Me.S_TCMZNA.Name = "S_TCMZNA"
        Me.S_TCMZNA.ReadOnly = True
        Me.S_TCMZNA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_TCMZNA.Visible = False
        Me.S_TCMZNA.Width = 67
        '
        'S_QDSVGN
        '
        Me.S_QDSVGN.DataPropertyName = "QDSVGN"
        Me.S_QDSVGN.HeaderText = "No Días Vigencia"
        Me.S_QDSVGN.Name = "S_QDSVGN"
        Me.S_QDSVGN.ReadOnly = True
        Me.S_QDSVGN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_QDSVGN.Width = 133
        '
        'S_CCNTD
        '
        Me.S_CCNTD.DataPropertyName = "CCNTD"
        Me.S_CCNTD.HeaderText = "Contenedor"
        Me.S_CCNTD.Name = "S_CCNTD"
        Me.S_CCNTD.ReadOnly = True
        Me.S_CCNTD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_CCNTD.Visible = False
        Me.S_CCNTD.Width = 97
        '
        'S_FUNDS2
        '
        Me.S_FUNDS2.DataPropertyName = "FUNDS2"
        Me.S_FUNDS2.HeaderText = "U. Despacho"
        Me.S_FUNDS2.Name = "S_FUNDS2"
        Me.S_FUNDS2.ReadOnly = True
        Me.S_FUNDS2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_FUNDS2.Width = 102
        '
        'S_CTPDPS
        '
        Me.S_CTPDPS.DataPropertyName = "CTPDPS"
        Me.S_CTPDPS.HeaderText = "Tipo Depósito"
        Me.S_CTPDPS.Name = "S_CTPDPS"
        Me.S_CTPDPS.ReadOnly = True
        Me.S_CTPDPS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_CTPDPS.Width = 114
        '
        'S_TOBSRV
        '
        Me.S_TOBSRV.DataPropertyName = "TOBSRV"
        Me.S_TOBSRV.HeaderText = "Observaciones"
        Me.S_TOBSRV.Name = "S_TOBSRV"
        Me.S_TOBSRV.ReadOnly = True
        Me.S_TOBSRV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_TOBSRV.Width = 115
        '
        'S_NRITOC
        '
        Me.S_NRITOC.DataPropertyName = "NRITOC"
        Me.S_NRITOC.HeaderText = "Nro Items"
        Me.S_NRITOC.Name = "S_NRITOC"
        Me.S_NRITOC.ReadOnly = True
        Me.S_NRITOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_NRITOC.Visible = False
        Me.S_NRITOC.Width = 84
        '
        'S_FMPDME
        '
        Me.S_FMPDME.DataPropertyName = "FMPDME"
        Me.S_FMPDME.HeaderText = "FMPDME"
        Me.S_FMPDME.Name = "S_FMPDME"
        Me.S_FMPDME.ReadOnly = True
        Me.S_FMPDME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.S_FMPDME.Visible = False
        Me.S_FMPDME.Width = 79
        '
        'FUNCTL
        '
        Me.FUNCTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FUNCTL.DataPropertyName = "FUNCTL"
        Me.FUNCTL.HeaderText = "Ctrl Lote"
        Me.FUNCTL.Name = "FUNCTL"
        Me.FUNCTL.ReadOnly = True
        Me.FUNCTL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FUNCTL.Width = 75
        '
        'FUBICAC
        '
        Me.FUBICAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FUBICAC.DataPropertyName = "FUBICAC"
        Me.FUBICAC.HeaderText = "Ctrl Ubicac."
        Me.FUBICAC.Name = "FUBICAC"
        Me.FUBICAC.ReadOnly = True
        Me.FUBICAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FUBICAC.Width = 94
        '
        'SCNTSR
        '
        Me.SCNTSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SCNTSR.DataPropertyName = "SCNTSR"
        Me.SCNTSR.HeaderText = "Ctrl Serie"
        Me.SCNTSR.Name = "SCNTSR"
        Me.SCNTSR.ReadOnly = True
        Me.SCNTSR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SCNTSR.Width = 79
        '
        'frmGenerarRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1373, 746)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGenerarRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Recepción"
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.grpListadoMercaderia.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpListadoMercaderia.Panel.ResumeLayout(False)
        CType(Me.grpListadoMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpListadoMercaderia.ResumeLayout(False)
        CType(Me.hgSerie_Ubicacion.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgSerie_Ubicacion.Panel.ResumeLayout(False)
        CType(Me.hgSerie_Ubicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgSerie_Ubicacion.ResumeLayout(False)
        Me.tbAsignaSerieUbicacion.ResumeLayout(False)
        Me.TabPageLotes.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.dtgLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.TabPageUbicacion.ResumeLayout(False)
        Me.TabPageSerie.ResumeLayout(False)
        Me.TabPageProyecto.ResumeLayout(False)
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.Panel.ResumeLayout(False)
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgGuiaRemision.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaRemision.Panel.ResumeLayout(False)
        CType(Me.hgGuiaRemision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaRemision.ResumeLayout(False)
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CUNVL3 As System.Data.DataColumn
    Friend WithEvents CUNPS3 As System.Data.DataColumn
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents CUNCN3 As System.Data.DataColumn
    Friend WithEvents CTPDP3 As System.Data.DataColumn
    Friend WithEvents CTPPR1 As System.Data.DataColumn
    Friend WithEvents TABDPS As System.Data.DataColumn
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
    Friend WithEvents NCNTR As System.Data.DataColumn
    Friend WithEvents dtContratos As System.Data.DataTable
    Friend WithEvents dstContratos As System.Data.DataSet
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents grpListadoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonGroup
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
    Friend WithEvents OFUNCTL As System.Data.DataColumn
    Friend WithEvents OQMRCD1 As System.Data.DataColumn
    Friend WithEvents OQPSMR1 As System.Data.DataColumn
    Friend WithEvents OQVLMR1 As System.Data.DataColumn
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
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtZona As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroGuia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents hgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaProcesarGuia As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaProcesarRecepcion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsaCancelarRecepcion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents SNRITOC As System.Data.DataColumn
    Friend WithEvents txtProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkServicio As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtGuiaIngreso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblGuiaIngreso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents chkEtiqueta As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dgvLotes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgSerie_Ubicacion As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaGuardar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents tbAsignaSerieUbicacion As System.Windows.Forms.TabControl
    Friend WithEvents TabPageLotes As System.Windows.Forms.TabPage
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dtgLotes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PSCRTLTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQINMC2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabPageUbicacion As System.Windows.Forms.TabPage
    Friend WithEvents UcUbicaciones_Lista As RANSA.Controls.ucUbicaciones_Dg
    Friend WithEvents TabPageSerie As System.Windows.Forms.TabPage
    Friend WithEvents UcSerie_Lista As RANSA.Controls.Serie.ucSerie_Dg
    Friend WithEvents TabPageProyecto As System.Windows.Forms.TabPage
    Friend WithEvents UcProyectos_Lista As RANSA.CONTROL.ucProyecto
    Friend WithEvents hgGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaAgregar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnOcultar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaEliminarItem As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents S_FUNCTL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N_CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CRTLTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_SF_FINGAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_SF_FPRDMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_SF_FVNLTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N_QMRCSL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents S_CTPOCN As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FILA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_QTRMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_LOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CUNCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_QTRMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CUNPST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NCRCTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents S_QDSVGN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CCNTD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_FUNDS2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CTPDPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TOBSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_FMPDME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUNCTL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUBICAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCNTSR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
