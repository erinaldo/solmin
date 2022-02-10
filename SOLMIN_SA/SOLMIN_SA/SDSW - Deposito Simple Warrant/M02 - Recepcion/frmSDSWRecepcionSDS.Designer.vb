<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWRecepcionSDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWRecepcionSDS))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaMercaderia = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaRealizarRecepcion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaConsulta = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaImpresion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgMercaderias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstMercaderia = New System.Data.DataSet
        Me.dtMercaderia = New System.Data.DataTable
        Me.MSTASEL = New System.Data.DataColumn
        Me.MCFMCLR = New System.Data.DataColumn
        Me.MCGRCLR = New System.Data.DataColumn
        Me.MCMRCLR = New System.Data.DataColumn
        Me.MTMRCD2 = New System.Data.DataColumn
        Me.MCMRCD = New System.Data.DataColumn
        Me.MSALDO = New System.Data.DataColumn
        Me.MSESTRG = New System.Data.DataColumn
        Me.MSITUAC = New System.Data.DataColumn
        Me.dtMercaderiaSeleccionadas = New System.Data.DataTable
        Me.SCMRCLR = New System.Data.DataColumn
        Me.STMRCD2 = New System.Data.DataColumn
        Me.SCMRCD = New System.Data.DataColumn
        Me.SNORDSR = New System.Data.DataColumn
        Me.SNCNTR = New System.Data.DataColumn
        Me.SNCRCTC = New System.Data.DataColumn
        Me.SNAUTR = New System.Data.DataColumn
        Me.SCUNCNT = New System.Data.DataColumn
        Me.SCUNPST = New System.Data.DataColumn
        Me.SCUNVLT = New System.Data.DataColumn
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
        Me.SQDSVGN = New System.Data.DataColumn
        Me.SCCNTD = New System.Data.DataColumn
        Me.SCTPOCN = New System.Data.DataColumn
        Me.SFUNDS2 = New System.Data.DataColumn
        Me.SCTPDPS = New System.Data.DataColumn
        Me.STOBSRV = New System.Data.DataColumn
        Me.STOBSRL = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.dgnorden = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.hgOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaCrearOS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaEditarOS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrarOrden = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaAnularOrden = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaAgregaMercaderiaOS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaAgregaTicket = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgListaOrdenesServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.O_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QMRCD1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QPSMR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_FEMORS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_CTPDP6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_QSLMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_QSLMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_QSLMV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_CUNVL5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstOrdenServicio = New System.Data.DataSet
        Me.dtOrdenServicio = New System.Data.DataTable
        Me.ONORDSR = New System.Data.DataColumn
        Me.ONCNTR = New System.Data.DataColumn
        Me.ONCRCTC = New System.Data.DataColumn
        Me.ONAUTR = New System.Data.DataColumn
        Me.OFEMORS = New System.Data.DataColumn
        Me.OCTPDP6 = New System.Data.DataColumn
        Me.OQSLMC = New System.Data.DataColumn
        Me.OCUNCN5 = New System.Data.DataColumn
        Me.OQSLMP = New System.Data.DataColumn
        Me.OCUNPS5 = New System.Data.DataColumn
        Me.OQSLMV = New System.Data.DataColumn
        Me.OCUNVL5 = New System.Data.DataColumn
        Me.OFUNDS2 = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.hgParametrosCrearOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.cbxUnidadDespacho = New System.Windows.Forms.ComboBox
        Me.lblUnidadDespacho = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelarCrearOS = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnProcesarCrearOS = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.cbxControlLote = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtValor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblValor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUnidadValor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblUnidadValor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblPeso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUnidadPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaListarUnidadPeso = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblUnidadPeso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUnidadCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaListarUnidadCantidad = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblUnidadCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgContratosVigentes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CTPDP3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TABDPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CTPPR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNCN3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNPS3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNVL3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstContratos = New System.Data.DataSet
        Me.dtContratos = New System.Data.DataTable
        Me.NCNTR = New System.Data.DataColumn
        Me.CTPDP3 = New System.Data.DataColumn
        Me.TABDPS = New System.Data.DataColumn
        Me.CTPPR1 = New System.Data.DataColumn
        Me.CUNCN3 = New System.Data.DataColumn
        Me.CUNPS3 = New System.Data.DataColumn
        Me.CUNVL3 = New System.Data.DataColumn
        Me.kpnuevo = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaProcesarRecepcion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaEliminarMercaderia = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgNroTicket = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Ticket = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.S_CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CUNCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CUNPST = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CUNVLT = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.S_QDSVGN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CCNTD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CTPOCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CTPDPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TOBSRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSERIE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaProcesar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaBorrarTicket = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgticket = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSLCSRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NROTCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRLTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CSRVNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FENVSLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FAUTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FATNSRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HORAINIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HORAFINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTRSPTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NDCMFCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NHRCALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NHRFACDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OBSERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstTicket = New System.Data.DataSet
        Me.dtTicket = New System.Data.DataTable
        Me.TNORDSR = New System.Data.DataColumn
        Me.TNSLCSR = New System.Data.DataColumn
        Me.TNROTCK = New System.Data.DataColumn
        Me.TNCRRLT = New System.Data.DataColumn
        Me.TCSRVNV = New System.Data.DataColumn
        Me.TFENVSL = New System.Data.DataColumn
        Me.TFAUTR = New System.Data.DataColumn
        Me.TFATNSR = New System.Data.DataColumn
        Me.THORAINI = New System.Data.DataColumn
        Me.THORAFIN = New System.Data.DataColumn
        Me.TCTRSPT = New System.Data.DataColumn
        Me.TOBSER = New System.Data.DataColumn
        Me.TNDCMFC = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.lblTipo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblRegimen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblcodcliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpLeyenda = New System.Windows.Forms.GroupBox
        Me.lblDetalleOpcional = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDetalleObligatorio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOpcional = New System.Windows.Forms.Label
        Me.lblObligatorio = New System.Windows.Forms.Label
        Me.cbxPublicarWEB = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblPublicarWEB = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFamilia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaFamiliaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtGrupo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaGrupoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInventario = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFechaInventario = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.lblFechaVencimiento = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFechaVencimiento = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblMercadaeria = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaClienteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ButtonSpecAny2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonTextBox3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox4 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox5 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ButtonSpecAny3 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonTextBox6 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ButtonSpecAny4 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonDataGridView1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonCheckBox1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonDataGridView2 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaProcesarTicket = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderia.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgMercaderia.Panel.SuspendLayout()
        Me.hgMercaderia.SuspendLayout()
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgnorden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgOS.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgOS.Panel.SuspendLayout()
        Me.hgOS.SuspendLayout()
        CType(Me.dgListaOrdenesServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgParametrosCrearOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgParametrosCrearOS.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgParametrosCrearOS.Panel.SuspendLayout()
        Me.hgParametrosCrearOS.SuspendLayout()
        CType(Me.dgContratosVigentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kpnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kpnuevo.SuspendLayout()
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgMercaderiaSeleccionada.Panel.SuspendLayout()
        Me.hgMercaderiaSeleccionada.SuspendLayout()
        CType(Me.dgNroTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dgticket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpLeyenda.SuspendLayout()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.KryptonDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgMercaderia)
        Me.KryptonPanel.Controls.Add(Me.hgOS)
        Me.KryptonPanel.Controls.Add(Me.kpnuevo)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(964, 626)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgMercaderia
        '
        Me.hgMercaderia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaMercaderia, Me.bsaRealizarRecepcion, Me.bsaConsulta, Me.bsaImpresion})
        Me.hgMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgMercaderia.HeaderVisibleSecondary = False
        Me.hgMercaderia.Location = New System.Drawing.Point(0, 115)
        Me.hgMercaderia.Name = "hgMercaderia"
        '
        'hgMercaderia.Panel
        '
        Me.hgMercaderia.Panel.Controls.Add(Me.dgMercaderias)
        Me.hgMercaderia.Panel.Controls.Add(Me.dgnorden)
        Me.hgMercaderia.Size = New System.Drawing.Size(469, 201)
        Me.hgMercaderia.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgMercaderia.TabIndex = 54
        Me.hgMercaderia.Text = "Listado de Mercaderías"
        Me.hgMercaderia.ValuesPrimary.Description = ""
        Me.hgMercaderia.ValuesPrimary.Heading = "Listado de Mercaderías"
        Me.hgMercaderia.ValuesPrimary.Image = CType(resources.GetObject("hgMercaderia.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgMercaderia.ValuesSecondary.Description = ""
        Me.hgMercaderia.ValuesSecondary.Heading = "Description"
        Me.hgMercaderia.ValuesSecondary.Image = Nothing
        '
        'bsaMercaderia
        '
        Me.bsaMercaderia.ExtraText = ""
        Me.bsaMercaderia.Image = CType(resources.GetObject("bsaMercaderia.Image"), System.Drawing.Image)
        Me.bsaMercaderia.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaMercaderia.Text = "Mercadería"
        Me.bsaMercaderia.ToolTipImage = Nothing
        Me.bsaMercaderia.UniqueName = "3C1CA2F359C943983C1CA2F359C94398"
        '
        'bsaRealizarRecepcion
        '
        Me.bsaRealizarRecepcion.ExtraText = ""
        Me.bsaRealizarRecepcion.Image = CType(resources.GetObject("bsaRealizarRecepcion.Image"), System.Drawing.Image)
        Me.bsaRealizarRecepcion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaRealizarRecepcion.Text = "Realizar Recepción"
        Me.bsaRealizarRecepcion.ToolTipImage = Nothing
        Me.bsaRealizarRecepcion.UniqueName = "E32F168AB9E044FBE32F168AB9E044FB"
        '
        'bsaConsulta
        '
        Me.bsaConsulta.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[True]
        Me.bsaConsulta.ExtraText = ""
        Me.bsaConsulta.Image = CType(resources.GetObject("bsaConsulta.Image"), System.Drawing.Image)
        Me.bsaConsulta.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaConsulta.Text = "Consulta"
        Me.bsaConsulta.ToolTipImage = Nothing
        Me.bsaConsulta.UniqueName = "508D7EDACFE34B34508D7EDACFE34B34"
        '
        'bsaImpresion
        '
        Me.bsaImpresion.ExtraText = ""
        Me.bsaImpresion.Image = CType(resources.GetObject("bsaImpresion.Image"), System.Drawing.Image)
        Me.bsaImpresion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaImpresion.Text = "Impresion"
        Me.bsaImpresion.ToolTipImage = Nothing
        Me.bsaImpresion.UniqueName = "B63BD0B125A84661B63BD0B125A84661"
        '
        'dgMercaderias
        '
        Me.dgMercaderias.AllowUserToAddRows = False
        Me.dgMercaderias.AllowUserToDeleteRows = False
        Me.dgMercaderias.AllowUserToResizeColumns = False
        Me.dgMercaderias.AllowUserToResizeRows = False
        Me.dgMercaderias.AutoGenerateColumns = False
        Me.dgMercaderias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CFMCLR, Me.M_CGRCLR, Me.M_CMRCLR, Me.M_TMRCD2, Me.M_CMRCD, Me.M_SALDO, Me.M_SESTRG, Me.M_SITUAC})
        Me.dgMercaderias.DataMember = "dtMercaderia"
        Me.dgMercaderias.DataSource = Me.dstMercaderia
        Me.dgMercaderias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderias.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderias.MultiSelect = False
        Me.dgMercaderias.Name = "dgMercaderias"
        Me.dgMercaderias.ReadOnly = True
        Me.dgMercaderias.RowHeadersWidth = 20
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderias.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgMercaderias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderias.Size = New System.Drawing.Size(467, 171)
        Me.dgMercaderias.StandardTab = True
        Me.dgMercaderias.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderias.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.dgMercaderias.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.dgMercaderias.TabIndex = 23
        '
        'M_CFMCLR
        '
        Me.M_CFMCLR.DataPropertyName = "CFMCLR"
        Me.M_CFMCLR.HeaderText = "Familia"
        Me.M_CFMCLR.Name = "M_CFMCLR"
        Me.M_CFMCLR.ReadOnly = True
        Me.M_CFMCLR.Visible = False
        Me.M_CFMCLR.Width = 72
        '
        'M_CGRCLR
        '
        Me.M_CGRCLR.DataPropertyName = "CGRCLR"
        Me.M_CGRCLR.HeaderText = "Grupo"
        Me.M_CGRCLR.Name = "M_CGRCLR"
        Me.M_CGRCLR.ReadOnly = True
        Me.M_CGRCLR.Visible = False
        Me.M_CGRCLR.Width = 69
        '
        'M_CMRCLR
        '
        Me.M_CMRCLR.DataPropertyName = "CMRCLR"
        Me.M_CMRCLR.HeaderText = "Mercadería"
        Me.M_CMRCLR.Name = "M_CMRCLR"
        Me.M_CMRCLR.ReadOnly = True
        Me.M_CMRCLR.Width = 93
        '
        'M_TMRCD2
        '
        Me.M_TMRCD2.DataPropertyName = "TMRCD2"
        Me.M_TMRCD2.HeaderText = "Detalle"
        Me.M_TMRCD2.Name = "M_TMRCD2"
        Me.M_TMRCD2.ReadOnly = True
        Me.M_TMRCD2.Width = 72
        '
        'M_CMRCD
        '
        Me.M_CMRCD.DataPropertyName = "CMRCD"
        Me.M_CMRCD.HeaderText = "Cód. RANSA"
        Me.M_CMRCD.Name = "M_CMRCD"
        Me.M_CMRCD.ReadOnly = True
        Me.M_CMRCD.Visible = False
        Me.M_CMRCD.Width = 98
        '
        'M_SALDO
        '
        Me.M_SALDO.DataPropertyName = "SALDO"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        Me.M_SALDO.DefaultCellStyle = DataGridViewCellStyle15
        Me.M_SALDO.HeaderText = "Saldo"
        Me.M_SALDO.Name = "M_SALDO"
        Me.M_SALDO.ReadOnly = True
        Me.M_SALDO.Visible = False
        Me.M_SALDO.Width = 65
        '
        'M_SESTRG
        '
        Me.M_SESTRG.DataPropertyName = "SESTRG"
        Me.M_SESTRG.HeaderText = "Situación"
        Me.M_SESTRG.Name = "M_SESTRG"
        Me.M_SESTRG.ReadOnly = True
        Me.M_SESTRG.Visible = False
        Me.M_SESTRG.Width = 84
        '
        'M_SITUAC
        '
        Me.M_SITUAC.DataPropertyName = "SITUAC"
        Me.M_SITUAC.HeaderText = "Situación"
        Me.M_SITUAC.Name = "M_SITUAC"
        Me.M_SITUAC.ReadOnly = True
        Me.M_SITUAC.Visible = False
        Me.M_SITUAC.Width = 84
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtMercaderia, Me.dtMercaderiaSeleccionadas})
        '
        'dtMercaderia
        '
        Me.dtMercaderia.Columns.AddRange(New System.Data.DataColumn() {Me.MSTASEL, Me.MCFMCLR, Me.MCGRCLR, Me.MCMRCLR, Me.MTMRCD2, Me.MCMRCD, Me.MSALDO, Me.MSESTRG, Me.MSITUAC})
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
        'dtMercaderiaSeleccionadas
        '
        Me.dtMercaderiaSeleccionadas.Columns.AddRange(New System.Data.DataColumn() {Me.SCMRCLR, Me.STMRCD2, Me.SCMRCD, Me.SNORDSR, Me.SNCNTR, Me.SNCRCTC, Me.SNAUTR, Me.SCUNCNT, Me.SCUNPST, Me.SCUNVLT, Me.SNORCCL, Me.SNGUICL, Me.SNRUCLL, Me.SSTPING, Me.SCTPALM, Me.STALMC, Me.SCALMC, Me.STCMPAL, Me.SCZNALM, Me.STCMZNA, Me.SQTRMC, Me.SQTRMP, Me.SQDSVGN, Me.SCCNTD, Me.SCTPOCN, Me.SFUNDS2, Me.SCTPDPS, Me.STOBSRV, Me.STOBSRL, Me.DataColumn2, Me.DataColumn5})
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
        'STOBSRL
        '
        Me.STOBSRL.ColumnName = "TOBSRL"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "FRLZSR"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "NSERIE"
        '
        'dgnorden
        '
        Me.dgnorden.AllowUserToAddRows = False
        Me.dgnorden.AllowUserToDeleteRows = False
        Me.dgnorden.AllowUserToResizeColumns = False
        Me.dgnorden.AllowUserToResizeRows = False
        Me.dgnorden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgnorden.Location = New System.Drawing.Point(389, 71)
        Me.dgnorden.Name = "dgnorden"
        Me.dgnorden.Size = New System.Drawing.Size(120, 62)
        Me.dgnorden.StateCommon.Background.Color1 = System.Drawing.SystemColors.Menu
        Me.dgnorden.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgnorden.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgnorden.TabIndex = 52
        '
        'hgOS
        '
        Me.hgOS.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaCrearOS, Me.bsaEditarOS, Me.bsaCerrarOrden, Me.bsaAnularOrden, Me.bsaBuscar, Me.bsaAgregaMercaderiaOS, Me.bsaAgregaTicket})
        Me.hgOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgOS.HeaderVisibleSecondary = False
        Me.hgOS.Location = New System.Drawing.Point(0, 316)
        Me.hgOS.Name = "hgOS"
        '
        'hgOS.Panel
        '
        Me.hgOS.Panel.Controls.Add(Me.dgListaOrdenesServicio)
        Me.hgOS.Panel.Controls.Add(Me.hgParametrosCrearOS)
        Me.hgOS.Size = New System.Drawing.Size(469, 310)
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
        'bsaCrearOS
        '
        Me.bsaCrearOS.ExtraText = ""
        Me.bsaCrearOS.Image = CType(resources.GetObject("bsaCrearOS.Image"), System.Drawing.Image)
        Me.bsaCrearOS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaCrearOS.Text = "Crear"
        Me.bsaCrearOS.ToolTipImage = Nothing
        Me.bsaCrearOS.UniqueName = "22A012AE22564A2A22A012AE22564A2A"
        '
        'bsaEditarOS
        '
        Me.bsaEditarOS.ExtraText = ""
        Me.bsaEditarOS.Image = CType(resources.GetObject("bsaEditarOS.Image"), System.Drawing.Image)
        Me.bsaEditarOS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaEditarOS.Text = "Editar"
        Me.bsaEditarOS.ToolTipImage = Nothing
        Me.bsaEditarOS.ToolTipTitle = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bsaEditarOS.UniqueName = "B4F9F70E74D1458FB4F9F70E74D1458F"
        '
        'bsaCerrarOrden
        '
        Me.bsaCerrarOrden.ExtraText = ""
        Me.bsaCerrarOrden.Image = CType(resources.GetObject("bsaCerrarOrden.Image"), System.Drawing.Image)
        Me.bsaCerrarOrden.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaCerrarOrden.Text = "Cerrar "
        Me.bsaCerrarOrden.ToolTipImage = Nothing
        Me.bsaCerrarOrden.UniqueName = "615834D2523C4FA6615834D2523C4FA6"
        '
        'bsaAnularOrden
        '
        Me.bsaAnularOrden.ExtraText = ""
        Me.bsaAnularOrden.Image = CType(resources.GetObject("bsaAnularOrden.Image"), System.Drawing.Image)
        Me.bsaAnularOrden.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaAnularOrden.Text = "Anular"
        Me.bsaAnularOrden.ToolTipImage = Nothing
        Me.bsaAnularOrden.UniqueName = "A4392D318AA54029A4392D318AA54029"
        '
        'bsaBuscar
        '
        Me.bsaBuscar.ExtraText = ""
        Me.bsaBuscar.Image = CType(resources.GetObject("bsaBuscar.Image"), System.Drawing.Image)
        Me.bsaBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaBuscar.Text = "Buscar"
        Me.bsaBuscar.ToolTipImage = Nothing
        Me.bsaBuscar.UniqueName = "A07C4D6F1A2A4B05A07C4D6F1A2A4B05"
        '
        'bsaAgregaMercaderiaOS
        '
        Me.bsaAgregaMercaderiaOS.ExtraText = ""
        Me.bsaAgregaMercaderiaOS.Image = CType(resources.GetObject("bsaAgregaMercaderiaOS.Image"), System.Drawing.Image)
        Me.bsaAgregaMercaderiaOS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaAgregaMercaderiaOS.Text = "Agr Merc"
        Me.bsaAgregaMercaderiaOS.ToolTipImage = Nothing
        Me.bsaAgregaMercaderiaOS.UniqueName = "5033E7CFDAAA4BBF5033E7CFDAAA4BBF"
        '
        'bsaAgregaTicket
        '
        Me.bsaAgregaTicket.ExtraText = ""
        Me.bsaAgregaTicket.Image = CType(resources.GetObject("bsaAgregaTicket.Image"), System.Drawing.Image)
        Me.bsaAgregaTicket.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaAgregaTicket.Text = "Agr Ticket"
        Me.bsaAgregaTicket.ToolTipImage = Nothing
        Me.bsaAgregaTicket.UniqueName = "6486DBB2D51847356486DBB2D5184735"
        '
        'dgListaOrdenesServicio
        '
        Me.dgListaOrdenesServicio.AllowUserToAddRows = False
        Me.dgListaOrdenesServicio.AllowUserToDeleteRows = False
        Me.dgListaOrdenesServicio.AllowUserToResizeColumns = False
        Me.dgListaOrdenesServicio.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgListaOrdenesServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dgListaOrdenesServicio.AutoGenerateColumns = False
        Me.dgListaOrdenesServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgListaOrdenesServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.O_NORDSR, Me.QMRCD1, Me.QPSMR1, Me.O_NCNTR, Me.O_NCRCTC, Me.O_NAUTR, Me.O_FEMORS, Me.O_CTPDP6, Me.O_QSLMC, Me.O_CUNCN5, Me.O_QSLMP, Me.O_CUNPS5, Me.O_QSLMV, Me.O_CUNVL5, Me.O_FUNDS2})
        Me.dgListaOrdenesServicio.DataMember = "dtOrdenServicio"
        Me.dgListaOrdenesServicio.DataSource = Me.dstOrdenServicio
        Me.dgListaOrdenesServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListaOrdenesServicio.Location = New System.Drawing.Point(0, 0)
        Me.dgListaOrdenesServicio.MultiSelect = False
        Me.dgListaOrdenesServicio.Name = "dgListaOrdenesServicio"
        Me.dgListaOrdenesServicio.ReadOnly = True
        Me.dgListaOrdenesServicio.RowHeadersWidth = 20
        Me.dgListaOrdenesServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaOrdenesServicio.Size = New System.Drawing.Size(467, 254)
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
        Me.O_NORDSR.Width = 80
        '
        'QMRCD1
        '
        Me.QMRCD1.DataPropertyName = "QMRCD1"
        Me.QMRCD1.HeaderText = "QMRCD1"
        Me.QMRCD1.Name = "QMRCD1"
        Me.QMRCD1.ReadOnly = True
        Me.QMRCD1.Visible = False
        Me.QMRCD1.Width = 83
        '
        'QPSMR1
        '
        Me.QPSMR1.DataPropertyName = "QPSMR1"
        Me.QPSMR1.HeaderText = "QPSMR1"
        Me.QPSMR1.Name = "QPSMR1"
        Me.QPSMR1.ReadOnly = True
        Me.QPSMR1.Visible = False
        Me.QPSMR1.Width = 80
        '
        'O_NCNTR
        '
        Me.O_NCNTR.DataPropertyName = "NCNTR"
        Me.O_NCNTR.HeaderText = "Contrato"
        Me.O_NCNTR.Name = "O_NCNTR"
        Me.O_NCNTR.ReadOnly = True
        Me.O_NCNTR.Width = 82
        '
        'O_NCRCTC
        '
        Me.O_NCRCTC.DataPropertyName = "NCRCTC"
        Me.O_NCRCTC.HeaderText = "Corr."
        Me.O_NCRCTC.Name = "O_NCRCTC"
        Me.O_NCRCTC.ReadOnly = True
        Me.O_NCRCTC.Width = 61
        '
        'O_NAUTR
        '
        Me.O_NAUTR.DataPropertyName = "NAUTR"
        Me.O_NAUTR.HeaderText = "Autorización"
        Me.O_NAUTR.Name = "O_NAUTR"
        Me.O_NAUTR.ReadOnly = True
        Me.O_NAUTR.Visible = False
        Me.O_NAUTR.Width = 101
        '
        'O_FEMORS
        '
        Me.O_FEMORS.DataPropertyName = "FEMORS"
        Me.O_FEMORS.HeaderText = "Fecha"
        Me.O_FEMORS.Name = "O_FEMORS"
        Me.O_FEMORS.ReadOnly = True
        Me.O_FEMORS.Width = 66
        '
        'O_CTPDP6
        '
        Me.O_CTPDP6.DataPropertyName = "CTPDP6"
        Me.O_CTPDP6.HeaderText = "Tipo Depósito"
        Me.O_CTPDP6.Name = "O_CTPDP6"
        Me.O_CTPDP6.ReadOnly = True
        Me.O_CTPDP6.Width = 108
        '
        'O_QSLMC
        '
        Me.O_QSLMC.DataPropertyName = "QSLMC"
        Me.O_QSLMC.HeaderText = "S. Cantidad"
        Me.O_QSLMC.Name = "O_QSLMC"
        Me.O_QSLMC.ReadOnly = True
        Me.O_QSLMC.Width = 95
        '
        'O_CUNCN5
        '
        Me.O_CUNCN5.DataPropertyName = "CUNCN5"
        Me.O_CUNCN5.HeaderText = "Unidad"
        Me.O_CUNCN5.Name = "O_CUNCN5"
        Me.O_CUNCN5.ReadOnly = True
        Me.O_CUNCN5.Width = 74
        '
        'O_QSLMP
        '
        Me.O_QSLMP.DataPropertyName = "QSLMP"
        Me.O_QSLMP.HeaderText = "S. Peso"
        Me.O_QSLMP.Name = "O_QSLMP"
        Me.O_QSLMP.ReadOnly = True
        Me.O_QSLMP.Width = 72
        '
        'O_CUNPS5
        '
        Me.O_CUNPS5.DataPropertyName = "CUNPS5"
        Me.O_CUNPS5.HeaderText = "Unidad"
        Me.O_CUNPS5.Name = "O_CUNPS5"
        Me.O_CUNPS5.ReadOnly = True
        Me.O_CUNPS5.Width = 74
        '
        'O_QSLMV
        '
        Me.O_QSLMV.DataPropertyName = "QSLMV"
        Me.O_QSLMV.HeaderText = "S. Valor"
        Me.O_QSLMV.Name = "O_QSLMV"
        Me.O_QSLMV.ReadOnly = True
        Me.O_QSLMV.Width = 75
        '
        'O_CUNVL5
        '
        Me.O_CUNVL5.DataPropertyName = "CUNVL5"
        Me.O_CUNVL5.HeaderText = "Unidad"
        Me.O_CUNVL5.Name = "O_CUNVL5"
        Me.O_CUNVL5.ReadOnly = True
        Me.O_CUNVL5.Width = 74
        '
        'O_FUNDS2
        '
        Me.O_FUNDS2.DataPropertyName = "FUNDS2"
        Me.O_FUNDS2.HeaderText = "Status"
        Me.O_FUNDS2.Name = "O_FUNDS2"
        Me.O_FUNDS2.ReadOnly = True
        Me.O_FUNDS2.Visible = False
        Me.O_FUNDS2.Width = 68
        '
        'dstOrdenServicio
        '
        Me.dstOrdenServicio.DataSetName = "NewDataSet"
        Me.dstOrdenServicio.Tables.AddRange(New System.Data.DataTable() {Me.dtOrdenServicio})
        '
        'dtOrdenServicio
        '
        Me.dtOrdenServicio.Columns.AddRange(New System.Data.DataColumn() {Me.ONORDSR, Me.ONCNTR, Me.ONCRCTC, Me.ONAUTR, Me.OFEMORS, Me.OCTPDP6, Me.OQSLMC, Me.OCUNCN5, Me.OQSLMP, Me.OCUNPS5, Me.OQSLMV, Me.OCUNVL5, Me.OFUNDS2, Me.DataColumn1, Me.DataColumn6, Me.DataColumn7})
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
        'DataColumn1
        '
        Me.DataColumn1.Caption = "NGUIIS"
        Me.DataColumn1.ColumnName = "NGUIIS"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "QMRCD1"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "QPSMR1"
        '
        'hgParametrosCrearOS
        '
        Me.hgParametrosCrearOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgParametrosCrearOS.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.hgParametrosCrearOS.HeaderVisibleSecondary = False
        Me.hgParametrosCrearOS.Location = New System.Drawing.Point(0, 254)
        Me.hgParametrosCrearOS.Name = "hgParametrosCrearOS"
        '
        'hgParametrosCrearOS.Panel
        '
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.cbxUnidadDespacho)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblUnidadDespacho)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.btnCancelarCrearOS)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.btnProcesarCrearOS)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.cbxControlLote)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtValor)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblValor)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtUnidadValor)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblUnidadValor)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtPeso)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblPeso)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtCantidad)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblCantidad)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtUnidadPeso)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblUnidadPeso)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtUnidadCantidad)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblUnidadCantidad)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.dgContratosVigentes)
        Me.hgParametrosCrearOS.Size = New System.Drawing.Size(467, 21)
        Me.hgParametrosCrearOS.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgParametrosCrearOS.TabIndex = 50
        Me.hgParametrosCrearOS.Text = "Crear Nueva O/S"
        Me.hgParametrosCrearOS.ValuesPrimary.Description = ""
        Me.hgParametrosCrearOS.ValuesPrimary.Heading = "Crear Nueva O/S"
        Me.hgParametrosCrearOS.ValuesPrimary.Image = Nothing
        Me.hgParametrosCrearOS.ValuesSecondary.Description = ""
        Me.hgParametrosCrearOS.ValuesSecondary.Heading = "Description"
        Me.hgParametrosCrearOS.ValuesSecondary.Image = Nothing
        '
        'cbxUnidadDespacho
        '
        Me.cbxUnidadDespacho.FormattingEnabled = True
        Me.cbxUnidadDespacho.Items.AddRange(New Object() {"CANTIDAD", "PESO"})
        Me.cbxUnidadDespacho.Location = New System.Drawing.Point(108, 174)
        Me.cbxUnidadDespacho.Name = "cbxUnidadDespacho"
        Me.cbxUnidadDespacho.Size = New System.Drawing.Size(88, 21)
        Me.cbxUnidadDespacho.TabIndex = 67
        Me.cbxUnidadDespacho.Text = "CANTIDAD"
        '
        'lblUnidadDespacho
        '
        Me.lblUnidadDespacho.Location = New System.Drawing.Point(40, 177)
        Me.lblUnidadDespacho.Name = "lblUnidadDespacho"
        Me.lblUnidadDespacho.Size = New System.Drawing.Size(67, 19)
        Me.lblUnidadDespacho.TabIndex = 66
        Me.lblUnidadDespacho.Text = "Unid. Desp:"
        Me.lblUnidadDespacho.Values.ExtraText = ""
        Me.lblUnidadDespacho.Values.Image = Nothing
        Me.lblUnidadDespacho.Values.Text = "Unid. Desp:"
        '
        'btnCancelarCrearOS
        '
        Me.btnCancelarCrearOS.Location = New System.Drawing.Point(271, 208)
        Me.btnCancelarCrearOS.Name = "btnCancelarCrearOS"
        Me.btnCancelarCrearOS.Size = New System.Drawing.Size(100, 25)
        Me.btnCancelarCrearOS.TabIndex = 70
        Me.btnCancelarCrearOS.Text = "Cancelar"
        Me.btnCancelarCrearOS.Values.ExtraText = ""
        Me.btnCancelarCrearOS.Values.Image = CType(resources.GetObject("btnCancelarCrearOS.Values.Image"), System.Drawing.Image)
        Me.btnCancelarCrearOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelarCrearOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelarCrearOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelarCrearOS.Values.Text = "Cancelar"
        '
        'btnProcesarCrearOS
        '
        Me.btnProcesarCrearOS.Location = New System.Drawing.Point(153, 208)
        Me.btnProcesarCrearOS.Name = "btnProcesarCrearOS"
        Me.btnProcesarCrearOS.Size = New System.Drawing.Size(100, 25)
        Me.btnProcesarCrearOS.TabIndex = 69
        Me.btnProcesarCrearOS.Text = "Procesar"
        Me.btnProcesarCrearOS.Values.ExtraText = ""
        Me.btnProcesarCrearOS.Values.Image = CType(resources.GetObject("btnProcesarCrearOS.Values.Image"), System.Drawing.Image)
        Me.btnProcesarCrearOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesarCrearOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesarCrearOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesarCrearOS.Values.Text = "Procesar"
        '
        'cbxControlLote
        '
        Me.cbxControlLote.Checked = False
        Me.cbxControlLote.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.cbxControlLote.Location = New System.Drawing.Point(220, 177)
        Me.cbxControlLote.Name = "cbxControlLote"
        Me.cbxControlLote.Size = New System.Drawing.Size(106, 19)
        Me.cbxControlLote.TabIndex = 68
        Me.cbxControlLote.Text = "Control por Lote"
        Me.cbxControlLote.Values.ExtraText = ""
        Me.cbxControlLote.Values.Image = Nothing
        Me.cbxControlLote.Values.Text = "Control por Lote"
        '
        'txtValor
        '
        Me.TypeValidator.SetDecimales(Me.txtValor, 2)
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(108, 147)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(88, 21)
        Me.txtValor.TabIndex = 63
        Me.txtValor.Text = "0.00"
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtValor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblValor
        '
        Me.lblValor.Location = New System.Drawing.Point(40, 150)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(42, 19)
        Me.lblValor.TabIndex = 62
        Me.lblValor.Text = "Valor : "
        Me.lblValor.Values.ExtraText = ""
        Me.lblValor.Values.Image = Nothing
        Me.lblValor.Values.Text = "Valor : "
        '
        'txtUnidadValor
        '
        Me.txtUnidadValor.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny1})
        Me.txtUnidadValor.Enabled = False
        Me.txtUnidadValor.Location = New System.Drawing.Point(271, 147)
        Me.txtUnidadValor.MaxLength = 10
        Me.txtUnidadValor.Name = "txtUnidadValor"
        Me.txtUnidadValor.Size = New System.Drawing.Size(100, 21)
        Me.txtUnidadValor.TabIndex = 65
        Me.txtUnidadValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtUnidadValor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.ButtonSpecAny1.ExtraText = ""
        Me.ButtonSpecAny1.Image = Nothing
        Me.ButtonSpecAny1.Text = ""
        Me.ButtonSpecAny1.ToolTipImage = Nothing
        Me.ButtonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecAny1.UniqueName = "2D4EDDA325914A122D4EDDA325914A12"
        '
        'lblUnidadValor
        '
        Me.lblUnidadValor.Location = New System.Drawing.Point(213, 150)
        Me.lblUnidadValor.Name = "lblUnidadValor"
        Me.lblUnidadValor.Size = New System.Drawing.Size(52, 19)
        Me.lblUnidadValor.TabIndex = 64
        Me.lblUnidadValor.Text = "Unidad :"
        Me.lblUnidadValor.Values.ExtraText = ""
        Me.lblUnidadValor.Values.Image = Nothing
        Me.lblUnidadValor.Values.Text = "Unidad :"
        '
        'txtPeso
        '
        Me.TypeValidator.SetDecimales(Me.txtPeso, 2)
        Me.txtPeso.Location = New System.Drawing.Point(108, 122)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(88, 21)
        Me.txtPeso.TabIndex = 59
        Me.txtPeso.Text = "0.00"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPeso, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblPeso
        '
        Me.lblPeso.Location = New System.Drawing.Point(40, 125)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(39, 19)
        Me.lblPeso.TabIndex = 58
        Me.lblPeso.Text = "Peso : "
        Me.lblPeso.Values.ExtraText = ""
        Me.lblPeso.Values.Image = Nothing
        Me.lblPeso.Values.Text = "Peso : "
        '
        'txtCantidad
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidad, 2)
        Me.txtCantidad.Location = New System.Drawing.Point(108, 97)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(88, 21)
        Me.txtCantidad.TabIndex = 55
        Me.txtCantidad.Text = "0.00"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidad, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(40, 100)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(61, 19)
        Me.lblCantidad.TabIndex = 54
        Me.lblCantidad.Text = "Cantidad : "
        Me.lblCantidad.Values.ExtraText = ""
        Me.lblCantidad.Values.Image = Nothing
        Me.lblCantidad.Values.Text = "Cantidad : "
        '
        'txtUnidadPeso
        '
        Me.txtUnidadPeso.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaListarUnidadPeso})
        Me.txtUnidadPeso.Location = New System.Drawing.Point(271, 122)
        Me.txtUnidadPeso.MaxLength = 10
        Me.txtUnidadPeso.Name = "txtUnidadPeso"
        Me.txtUnidadPeso.Size = New System.Drawing.Size(100, 21)
        Me.txtUnidadPeso.TabIndex = 61
        Me.txtUnidadPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtUnidadPeso, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaListarUnidadPeso
        '
        Me.bsaListarUnidadPeso.ExtraText = ""
        Me.bsaListarUnidadPeso.Image = Nothing
        Me.bsaListarUnidadPeso.Text = ""
        Me.bsaListarUnidadPeso.ToolTipImage = Nothing
        Me.bsaListarUnidadPeso.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaListarUnidadPeso.UniqueName = "2D4EDDA325914A122D4EDDA325914A12"
        '
        'lblUnidadPeso
        '
        Me.lblUnidadPeso.Location = New System.Drawing.Point(213, 125)
        Me.lblUnidadPeso.Name = "lblUnidadPeso"
        Me.lblUnidadPeso.Size = New System.Drawing.Size(52, 19)
        Me.lblUnidadPeso.TabIndex = 60
        Me.lblUnidadPeso.Text = "Unidad :"
        Me.lblUnidadPeso.Values.ExtraText = ""
        Me.lblUnidadPeso.Values.Image = Nothing
        Me.lblUnidadPeso.Values.Text = "Unidad :"
        '
        'txtUnidadCantidad
        '
        Me.txtUnidadCantidad.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaListarUnidadCantidad})
        Me.txtUnidadCantidad.Location = New System.Drawing.Point(271, 97)
        Me.txtUnidadCantidad.MaxLength = 10
        Me.txtUnidadCantidad.Name = "txtUnidadCantidad"
        Me.txtUnidadCantidad.Size = New System.Drawing.Size(100, 21)
        Me.txtUnidadCantidad.TabIndex = 57
        Me.txtUnidadCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtUnidadCantidad, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaListarUnidadCantidad
        '
        Me.bsaListarUnidadCantidad.ExtraText = ""
        Me.bsaListarUnidadCantidad.Image = Nothing
        Me.bsaListarUnidadCantidad.Text = ""
        Me.bsaListarUnidadCantidad.ToolTipImage = Nothing
        Me.bsaListarUnidadCantidad.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaListarUnidadCantidad.UniqueName = "33BE470ED3D044A133BE470ED3D044A1"
        '
        'lblUnidadCantidad
        '
        Me.lblUnidadCantidad.Location = New System.Drawing.Point(213, 100)
        Me.lblUnidadCantidad.Name = "lblUnidadCantidad"
        Me.lblUnidadCantidad.Size = New System.Drawing.Size(52, 19)
        Me.lblUnidadCantidad.TabIndex = 56
        Me.lblUnidadCantidad.Text = "Unidad : "
        Me.lblUnidadCantidad.Values.ExtraText = ""
        Me.lblUnidadCantidad.Values.Image = Nothing
        Me.lblUnidadCantidad.Values.Text = "Unidad : "
        '
        'dgContratosVigentes
        '
        Me.dgContratosVigentes.AllowUserToAddRows = False
        Me.dgContratosVigentes.AllowUserToDeleteRows = False
        Me.dgContratosVigentes.AllowUserToResizeColumns = False
        Me.dgContratosVigentes.AllowUserToResizeRows = False
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgContratosVigentes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgContratosVigentes.AutoGenerateColumns = False
        Me.dgContratosVigentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgContratosVigentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NCNTR, Me.M_CTPDP3, Me.M_TABDPS, Me.M_CTPPR1, Me.M_CUNCN3, Me.M_CUNPS3, Me.M_CUNVL3})
        Me.dgContratosVigentes.DataMember = "dtContratos"
        Me.dgContratosVigentes.DataSource = Me.dstContratos
        Me.dgContratosVigentes.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgContratosVigentes.Location = New System.Drawing.Point(0, 0)
        Me.dgContratosVigentes.MultiSelect = False
        Me.dgContratosVigentes.Name = "dgContratosVigentes"
        Me.dgContratosVigentes.ReadOnly = True
        Me.dgContratosVigentes.RowHeadersWidth = 20
        Me.dgContratosVigentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContratosVigentes.Size = New System.Drawing.Size(465, 85)
        Me.dgContratosVigentes.StandardTab = True
        Me.dgContratosVigentes.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgContratosVigentes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgContratosVigentes.TabIndex = 53
        '
        'M_NCNTR
        '
        Me.M_NCNTR.DataPropertyName = "NCNTR"
        Me.M_NCNTR.HeaderText = "Nro. Contrato"
        Me.M_NCNTR.Name = "M_NCNTR"
        Me.M_NCNTR.ReadOnly = True
        Me.M_NCNTR.Width = 107
        '
        'M_CTPDP3
        '
        Me.M_CTPDP3.DataPropertyName = "CTPDP3"
        Me.M_CTPDP3.HeaderText = "Tipo Depósito"
        Me.M_CTPDP3.Name = "M_CTPDP3"
        Me.M_CTPDP3.ReadOnly = True
        Me.M_CTPDP3.Width = 108
        '
        'M_TABDPS
        '
        Me.M_TABDPS.DataPropertyName = "TABDPS"
        Me.M_TABDPS.HeaderText = "Depósito"
        Me.M_TABDPS.Name = "M_TABDPS"
        Me.M_TABDPS.ReadOnly = True
        Me.M_TABDPS.Width = 83
        '
        'M_CTPPR1
        '
        Me.M_CTPPR1.DataPropertyName = "CTPPR1"
        Me.M_CTPPR1.HeaderText = "Producto"
        Me.M_CTPPR1.Name = "M_CTPPR1"
        Me.M_CTPPR1.ReadOnly = True
        Me.M_CTPPR1.Visible = False
        Me.M_CTPPR1.Width = 83
        '
        'M_CUNCN3
        '
        Me.M_CUNCN3.DataPropertyName = "CUNCN3"
        Me.M_CUNCN3.HeaderText = "Unidad Cantidad"
        Me.M_CUNCN3.Name = "M_CUNCN3"
        Me.M_CUNCN3.ReadOnly = True
        Me.M_CUNCN3.Visible = False
        Me.M_CUNCN3.Width = 124
        '
        'M_CUNPS3
        '
        Me.M_CUNPS3.DataPropertyName = "CUNPS3"
        Me.M_CUNPS3.HeaderText = "Unidad Peso"
        Me.M_CUNPS3.Name = "M_CUNPS3"
        Me.M_CUNPS3.ReadOnly = True
        Me.M_CUNPS3.Visible = False
        Me.M_CUNPS3.Width = 101
        '
        'M_CUNVL3
        '
        Me.M_CUNVL3.DataPropertyName = "CUNVL3"
        Me.M_CUNVL3.HeaderText = "Unidad Valor"
        Me.M_CUNVL3.Name = "M_CUNVL3"
        Me.M_CUNVL3.ReadOnly = True
        Me.M_CUNVL3.Visible = False
        Me.M_CUNVL3.Width = 104
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
        'CTPDP3
        '
        Me.CTPDP3.ColumnName = "CTPDP3"
        '
        'TABDPS
        '
        Me.TABDPS.ColumnName = "TABDPS"
        '
        'CTPPR1
        '
        Me.CTPPR1.ColumnName = "CTPPR1"
        '
        'CUNCN3
        '
        Me.CUNCN3.ColumnName = "CUNCN3"
        '
        'CUNPS3
        '
        Me.CUNPS3.ColumnName = "CUNPS3"
        '
        'CUNVL3
        '
        Me.CUNVL3.ColumnName = "CUNVL3"
        '
        'kpnuevo
        '
        Me.kpnuevo.Controls.Add(Me.hgMercaderiaSeleccionada)
        Me.kpnuevo.Controls.Add(Me.KryptonPanel1)
        Me.kpnuevo.Dock = System.Windows.Forms.DockStyle.Right
        Me.kpnuevo.Location = New System.Drawing.Point(469, 115)
        Me.kpnuevo.Name = "kpnuevo"
        Me.kpnuevo.Size = New System.Drawing.Size(495, 511)
        Me.kpnuevo.TabIndex = 54
        '
        'hgMercaderiaSeleccionada
        '
        Me.hgMercaderiaSeleccionada.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaProcesarRecepcion, Me.bsaEliminarMercaderia})
        Me.hgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgMercaderiaSeleccionada.HeaderVisibleSecondary = False
        Me.hgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 0)
        Me.hgMercaderiaSeleccionada.Name = "hgMercaderiaSeleccionada"
        '
        'hgMercaderiaSeleccionada.Panel
        '
        Me.hgMercaderiaSeleccionada.Panel.Controls.Add(Me.dgNroTicket)
        Me.hgMercaderiaSeleccionada.Panel.Controls.Add(Me.dgMercaderiaSeleccionada)
        Me.hgMercaderiaSeleccionada.Size = New System.Drawing.Size(495, 207)
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
        'bsaProcesarRecepcion
        '
        Me.bsaProcesarRecepcion.ExtraText = ""
        Me.bsaProcesarRecepcion.Image = CType(resources.GetObject("bsaProcesarRecepcion.Image"), System.Drawing.Image)
        Me.bsaProcesarRecepcion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaProcesarRecepcion.Text = "Procesar Recepción"
        Me.bsaProcesarRecepcion.ToolTipImage = Nothing
        Me.bsaProcesarRecepcion.UniqueName = "0F1839EC421141FD0F1839EC421141FD"
        '
        'bsaEliminarMercaderia
        '
        Me.bsaEliminarMercaderia.ExtraText = ""
        Me.bsaEliminarMercaderia.Image = CType(resources.GetObject("bsaEliminarMercaderia.Image"), System.Drawing.Image)
        Me.bsaEliminarMercaderia.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaEliminarMercaderia.Text = "Eliminar Mercaderia"
        Me.bsaEliminarMercaderia.ToolTipImage = Nothing
        Me.bsaEliminarMercaderia.UniqueName = "D811B453385E4894D811B453385E4894"
        '
        'dgNroTicket
        '
        Me.dgNroTicket.AllowUserToAddRows = False
        Me.dgNroTicket.AllowUserToDeleteRows = False
        Me.dgNroTicket.AllowUserToResizeColumns = False
        Me.dgNroTicket.AllowUserToResizeRows = False
        Me.dgNroTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgNroTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ticket})
        Me.dgNroTicket.Location = New System.Drawing.Point(797, 106)
        Me.dgNroTicket.Name = "dgNroTicket"
        Me.dgNroTicket.Size = New System.Drawing.Size(103, 52)
        Me.dgNroTicket.StateCommon.Background.Color1 = System.Drawing.SystemColors.Menu
        Me.dgNroTicket.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgNroTicket.TabIndex = 51
        '
        'Ticket
        '
        Me.Ticket.HeaderText = "Ticket"
        Me.Ticket.Name = "Ticket"
        Me.Ticket.Width = 65
        '
        'dgMercaderiaSeleccionada
        '
        Me.dgMercaderiaSeleccionada.AllowUserToAddRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToDeleteRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeColumns = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeRows = False
        Me.dgMercaderiaSeleccionada.AutoGenerateColumns = False
        Me.dgMercaderiaSeleccionada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaSeleccionada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_CMRCLR, Me.S_TMRCD2, Me.S_CMRCD, Me.S_NORDSR, Me.S_NCNTR, Me.S_NCRCTC, Me.S_NAUTR, Me.S_CUNCNT, Me.S_CUNPST, Me.S_CUNVLT, Me.S_NORCCL, Me.S_NGUICL, Me.S_NRUCLL, Me.S_STPING, Me.S_CTPALM, Me.S_TALMC, Me.S_CALMC, Me.S_TCMPAL, Me.S_CZNALM, Me.S_TCMZNA, Me.S_QTRMC, Me.S_QTRMP, Me.S_QDSVGN, Me.S_CCNTD, Me.S_CTPOCN, Me.S_FUNDS2, Me.S_CTPDPS, Me.S_TOBSRV, Me.NSERIE})
        Me.dgMercaderiaSeleccionada.DataMember = "dtMercaderiaSeleccionadas"
        Me.dgMercaderiaSeleccionada.DataSource = Me.dstMercaderia
        Me.dgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderiaSeleccionada.MultiSelect = False
        Me.dgMercaderiaSeleccionada.Name = "dgMercaderiaSeleccionada"
        Me.dgMercaderiaSeleccionada.ReadOnly = True
        Me.dgMercaderiaSeleccionada.RowHeadersWidth = 20
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaSeleccionada.RowsDefaultCellStyle = DataGridViewCellStyle19
        Me.dgMercaderiaSeleccionada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaSeleccionada.Size = New System.Drawing.Size(493, 177)
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
        Me.S_CMRCLR.Width = 93
        '
        'S_TMRCD2
        '
        Me.S_TMRCD2.DataPropertyName = "TMRCD2"
        Me.S_TMRCD2.HeaderText = "Detalle"
        Me.S_TMRCD2.Name = "S_TMRCD2"
        Me.S_TMRCD2.ReadOnly = True
        Me.S_TMRCD2.Width = 72
        '
        'S_CMRCD
        '
        Me.S_CMRCD.DataPropertyName = "CMRCD"
        Me.S_CMRCD.HeaderText = "Cód. Ransa"
        Me.S_CMRCD.Name = "S_CMRCD"
        Me.S_CMRCD.ReadOnly = True
        Me.S_CMRCD.Width = 94
        '
        'S_NORDSR
        '
        Me.S_NORDSR.DataPropertyName = "NORDSR"
        Me.S_NORDSR.HeaderText = "Orden Servicio"
        Me.S_NORDSR.Name = "S_NORDSR"
        Me.S_NORDSR.ReadOnly = True
        Me.S_NORDSR.Width = 111
        '
        'S_NCNTR
        '
        Me.S_NCNTR.DataPropertyName = "NCNTR"
        Me.S_NCNTR.HeaderText = "No. Contrato"
        Me.S_NCNTR.Name = "S_NCNTR"
        Me.S_NCNTR.ReadOnly = True
        Me.S_NCNTR.Width = 103
        '
        'S_NCRCTC
        '
        Me.S_NCRCTC.DataPropertyName = "NCRCTC"
        Me.S_NCRCTC.HeaderText = "Correlativo"
        Me.S_NCRCTC.Name = "S_NCRCTC"
        Me.S_NCRCTC.ReadOnly = True
        Me.S_NCRCTC.Width = 92
        '
        'S_NAUTR
        '
        Me.S_NAUTR.DataPropertyName = "NAUTR"
        Me.S_NAUTR.HeaderText = "No Autorización"
        Me.S_NAUTR.Name = "S_NAUTR"
        Me.S_NAUTR.ReadOnly = True
        Me.S_NAUTR.Width = 119
        '
        'S_CUNCNT
        '
        Me.S_CUNCNT.DataPropertyName = "CUNCNT"
        Me.S_CUNCNT.HeaderText = "U. Cantidad"
        Me.S_CUNCNT.Name = "S_CUNCNT"
        Me.S_CUNCNT.ReadOnly = True
        Me.S_CUNCNT.Width = 97
        '
        'S_CUNPST
        '
        Me.S_CUNPST.DataPropertyName = "CUNPST"
        Me.S_CUNPST.HeaderText = "U. Peso"
        Me.S_CUNPST.Name = "S_CUNPST"
        Me.S_CUNPST.ReadOnly = True
        Me.S_CUNPST.Width = 74
        '
        'S_CUNVLT
        '
        Me.S_CUNVLT.DataPropertyName = "CUNVLT"
        Me.S_CUNVLT.HeaderText = "U. Valor"
        Me.S_CUNVLT.Name = "S_CUNVLT"
        Me.S_CUNVLT.ReadOnly = True
        Me.S_CUNVLT.Width = 77
        '
        'S_NORCCL
        '
        Me.S_NORCCL.DataPropertyName = "NORCCL"
        Me.S_NORCCL.HeaderText = "No O/C"
        Me.S_NORCCL.Name = "S_NORCCL"
        Me.S_NORCCL.ReadOnly = True
        Me.S_NORCCL.Width = 74
        '
        'S_NGUICL
        '
        Me.S_NGUICL.DataPropertyName = "NGUICL"
        Me.S_NGUICL.HeaderText = "No Guía Cliente"
        Me.S_NGUICL.Name = "S_NGUICL"
        Me.S_NGUICL.ReadOnly = True
        Me.S_NGUICL.Width = 117
        '
        'S_NRUCLL
        '
        Me.S_NRUCLL.DataPropertyName = "NRUCLL"
        Me.S_NRUCLL.HeaderText = "No RUC Cliente"
        Me.S_NRUCLL.Name = "S_NRUCLL"
        Me.S_NRUCLL.ReadOnly = True
        Me.S_NRUCLL.Width = 115
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
        Me.S_CTPALM.Width = 104
        '
        'S_TALMC
        '
        Me.S_TALMC.DataPropertyName = "TALMC"
        Me.S_TALMC.HeaderText = "Detalle"
        Me.S_TALMC.Name = "S_TALMC"
        Me.S_TALMC.ReadOnly = True
        Me.S_TALMC.Width = 72
        '
        'S_CALMC
        '
        Me.S_CALMC.DataPropertyName = "CALMC"
        Me.S_CALMC.HeaderText = "Almacén"
        Me.S_CALMC.Name = "S_CALMC"
        Me.S_CALMC.ReadOnly = True
        Me.S_CALMC.Width = 79
        '
        'S_TCMPAL
        '
        Me.S_TCMPAL.DataPropertyName = "TCMPAL"
        Me.S_TCMPAL.HeaderText = "Detalle"
        Me.S_TCMPAL.Name = "S_TCMPAL"
        Me.S_TCMPAL.ReadOnly = True
        Me.S_TCMPAL.Width = 72
        '
        'S_CZNALM
        '
        Me.S_CZNALM.DataPropertyName = "CZNALM"
        Me.S_CZNALM.HeaderText = "Zona"
        Me.S_CZNALM.Name = "S_CZNALM"
        Me.S_CZNALM.ReadOnly = True
        Me.S_CZNALM.Width = 62
        '
        'S_TCMZNA
        '
        Me.S_TCMZNA.DataPropertyName = "TCMZNA"
        Me.S_TCMZNA.HeaderText = "Detalle"
        Me.S_TCMZNA.Name = "S_TCMZNA"
        Me.S_TCMZNA.ReadOnly = True
        Me.S_TCMZNA.Width = 72
        '
        'S_QTRMC
        '
        Me.S_QTRMC.DataPropertyName = "QTRMC"
        Me.S_QTRMC.HeaderText = "Cantidad"
        Me.S_QTRMC.Name = "S_QTRMC"
        Me.S_QTRMC.ReadOnly = True
        Me.S_QTRMC.Width = 83
        '
        'S_QTRMP
        '
        Me.S_QTRMP.DataPropertyName = "QTRMP"
        Me.S_QTRMP.HeaderText = "Peso"
        Me.S_QTRMP.Name = "S_QTRMP"
        Me.S_QTRMP.ReadOnly = True
        Me.S_QTRMP.Width = 60
        '
        'S_QDSVGN
        '
        Me.S_QDSVGN.DataPropertyName = "QDSVGN"
        Me.S_QDSVGN.HeaderText = "No Días Vigencia"
        Me.S_QDSVGN.Name = "S_QDSVGN"
        Me.S_QDSVGN.ReadOnly = True
        Me.S_QDSVGN.Width = 123
        '
        'S_CCNTD
        '
        Me.S_CCNTD.DataPropertyName = "CCNTD"
        Me.S_CCNTD.HeaderText = "Contenedor"
        Me.S_CCNTD.Name = "S_CCNTD"
        Me.S_CCNTD.ReadOnly = True
        Me.S_CCNTD.Width = 98
        '
        'S_CTPOCN
        '
        Me.S_CTPOCN.DataPropertyName = "CTPOCN"
        Me.S_CTPOCN.HeaderText = "Desglosa"
        Me.S_CTPOCN.Name = "S_CTPOCN"
        Me.S_CTPOCN.ReadOnly = True
        Me.S_CTPOCN.Width = 83
        '
        'S_FUNDS2
        '
        Me.S_FUNDS2.DataPropertyName = "FUNDS2"
        Me.S_FUNDS2.HeaderText = "U. Despacho"
        Me.S_FUNDS2.Name = "S_FUNDS2"
        Me.S_FUNDS2.ReadOnly = True
        Me.S_FUNDS2.Width = 101
        '
        'S_CTPDPS
        '
        Me.S_CTPDPS.DataPropertyName = "CTPDPS"
        Me.S_CTPDPS.HeaderText = "Tipo Depósito"
        Me.S_CTPDPS.Name = "S_CTPDPS"
        Me.S_CTPDPS.ReadOnly = True
        Me.S_CTPDPS.Width = 108
        '
        'S_TOBSRV
        '
        Me.S_TOBSRV.DataPropertyName = "TOBSRV"
        Me.S_TOBSRV.HeaderText = "Observaciones"
        Me.S_TOBSRV.Name = "S_TOBSRV"
        Me.S_TOBSRV.ReadOnly = True
        Me.S_TOBSRV.Width = 111
        '
        'NSERIE
        '
        Me.NSERIE.DataPropertyName = "NSERIE"
        Me.NSERIE.HeaderText = "N° Serie"
        Me.NSERIE.Name = "NSERIE"
        Me.NSERIE.ReadOnly = True
        Me.NSERIE.Width = 76
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 207)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(495, 304)
        Me.KryptonPanel1.TabIndex = 53
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaProcesar, Me.bsaBorrarTicket})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dgticket)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(495, 304)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 55
        Me.KryptonHeaderGroup1.Text = "Ticket a Ingresar"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Ticket a Ingresar"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'bsaProcesar
        '
        Me.bsaProcesar.ExtraText = ""
        Me.bsaProcesar.Image = CType(resources.GetObject("bsaProcesar.Image"), System.Drawing.Image)
        Me.bsaProcesar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaProcesar.Text = "Procesar Ticket"
        Me.bsaProcesar.ToolTipImage = Nothing
        Me.bsaProcesar.UniqueName = "BB1A94E6E429475CBB1A94E6E429475C"
        '
        'bsaBorrarTicket
        '
        Me.bsaBorrarTicket.ExtraText = ""
        Me.bsaBorrarTicket.Image = CType(resources.GetObject("bsaBorrarTicket.Image"), System.Drawing.Image)
        Me.bsaBorrarTicket.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaBorrarTicket.Text = "Eliminar Servicio"
        Me.bsaBorrarTicket.ToolTipImage = Nothing
        Me.bsaBorrarTicket.UniqueName = "CFF7C79F21634A10CFF7C79F21634A10"
        '
        'dgticket
        '
        Me.dgticket.AllowUserToAddRows = False
        Me.dgticket.AllowUserToDeleteRows = False
        Me.dgticket.AllowUserToResizeColumns = False
        Me.dgticket.AllowUserToResizeRows = False
        Me.dgticket.AutoGenerateColumns = False
        Me.dgticket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgticket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORDSR, Me.NSLCSRDataGridViewTextBoxColumn, Me.NROTCKDataGridViewTextBoxColumn, Me.NCRRLTDataGridViewTextBoxColumn, Me.CSRVNVDataGridViewTextBoxColumn, Me.FENVSLDataGridViewTextBoxColumn, Me.FAUTRDataGridViewTextBoxColumn, Me.FATNSRDataGridViewTextBoxColumn, Me.HORAINIDataGridViewTextBoxColumn, Me.HORAFINDataGridViewTextBoxColumn, Me.CTRSPTDataGridViewTextBoxColumn, Me.NDCMFCDataGridViewTextBoxColumn, Me.NHRCALDataGridViewTextBoxColumn, Me.NHRFACDataGridViewTextBoxColumn, Me.OBSERDataGridViewTextBoxColumn})
        Me.dgticket.DataMember = "dtTicket"
        Me.dgticket.DataSource = Me.dstTicket
        Me.dgticket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgticket.Location = New System.Drawing.Point(0, 0)
        Me.dgticket.Name = "dgticket"
        Me.dgticket.RowHeadersWidth = 20
        Me.dgticket.Size = New System.Drawing.Size(493, 271)
        Me.dgticket.StateCommon.Background.Color1 = System.Drawing.SystemColors.Window
        Me.dgticket.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgticket.TabIndex = 54
        '
        'NORDSR
        '
        Me.NORDSR.DataPropertyName = "NORDSR"
        Me.NORDSR.HeaderText = "N° Orden"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.Width = 84
        '
        'NSLCSRDataGridViewTextBoxColumn
        '
        Me.NSLCSRDataGridViewTextBoxColumn.DataPropertyName = "NSLCSR"
        Me.NSLCSRDataGridViewTextBoxColumn.HeaderText = "NSLCSR"
        Me.NSLCSRDataGridViewTextBoxColumn.Name = "NSLCSRDataGridViewTextBoxColumn"
        Me.NSLCSRDataGridViewTextBoxColumn.Visible = False
        Me.NSLCSRDataGridViewTextBoxColumn.Width = 75
        '
        'NROTCKDataGridViewTextBoxColumn
        '
        Me.NROTCKDataGridViewTextBoxColumn.DataPropertyName = "NROTCK"
        Me.NROTCKDataGridViewTextBoxColumn.HeaderText = "NROTCK"
        Me.NROTCKDataGridViewTextBoxColumn.Name = "NROTCKDataGridViewTextBoxColumn"
        Me.NROTCKDataGridViewTextBoxColumn.Visible = False
        Me.NROTCKDataGridViewTextBoxColumn.Width = 78
        '
        'NCRRLTDataGridViewTextBoxColumn
        '
        Me.NCRRLTDataGridViewTextBoxColumn.DataPropertyName = "NCRRLT"
        Me.NCRRLTDataGridViewTextBoxColumn.HeaderText = "NCRRLT"
        Me.NCRRLTDataGridViewTextBoxColumn.Name = "NCRRLTDataGridViewTextBoxColumn"
        Me.NCRRLTDataGridViewTextBoxColumn.Visible = False
        Me.NCRRLTDataGridViewTextBoxColumn.Width = 75
        '
        'CSRVNVDataGridViewTextBoxColumn
        '
        Me.CSRVNVDataGridViewTextBoxColumn.DataPropertyName = "CSRVNV"
        Me.CSRVNVDataGridViewTextBoxColumn.HeaderText = "Cod Serv"
        Me.CSRVNVDataGridViewTextBoxColumn.Name = "CSRVNVDataGridViewTextBoxColumn"
        Me.CSRVNVDataGridViewTextBoxColumn.Width = 81
        '
        'FENVSLDataGridViewTextBoxColumn
        '
        Me.FENVSLDataGridViewTextBoxColumn.DataPropertyName = "FENVSL"
        Me.FENVSLDataGridViewTextBoxColumn.HeaderText = "FENVSL"
        Me.FENVSLDataGridViewTextBoxColumn.Name = "FENVSLDataGridViewTextBoxColumn"
        Me.FENVSLDataGridViewTextBoxColumn.Visible = False
        Me.FENVSLDataGridViewTextBoxColumn.Width = 74
        '
        'FAUTRDataGridViewTextBoxColumn
        '
        Me.FAUTRDataGridViewTextBoxColumn.DataPropertyName = "FAUTR"
        Me.FAUTRDataGridViewTextBoxColumn.HeaderText = "FAUTR"
        Me.FAUTRDataGridViewTextBoxColumn.Name = "FAUTRDataGridViewTextBoxColumn"
        Me.FAUTRDataGridViewTextBoxColumn.Visible = False
        Me.FAUTRDataGridViewTextBoxColumn.Width = 69
        '
        'FATNSRDataGridViewTextBoxColumn
        '
        Me.FATNSRDataGridViewTextBoxColumn.DataPropertyName = "FATNSR"
        Me.FATNSRDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FATNSRDataGridViewTextBoxColumn.Name = "FATNSRDataGridViewTextBoxColumn"
        Me.FATNSRDataGridViewTextBoxColumn.Width = 66
        '
        'HORAINIDataGridViewTextBoxColumn
        '
        Me.HORAINIDataGridViewTextBoxColumn.DataPropertyName = "HORAINI"
        Me.HORAINIDataGridViewTextBoxColumn.HeaderText = "Hora Inicio"
        Me.HORAINIDataGridViewTextBoxColumn.Name = "HORAINIDataGridViewTextBoxColumn"
        Me.HORAINIDataGridViewTextBoxColumn.Width = 92
        '
        'HORAFINDataGridViewTextBoxColumn
        '
        Me.HORAFINDataGridViewTextBoxColumn.DataPropertyName = "HORAFIN"
        Me.HORAFINDataGridViewTextBoxColumn.HeaderText = "Hora Final"
        Me.HORAFINDataGridViewTextBoxColumn.Name = "HORAFINDataGridViewTextBoxColumn"
        Me.HORAFINDataGridViewTextBoxColumn.Width = 89
        '
        'CTRSPTDataGridViewTextBoxColumn
        '
        Me.CTRSPTDataGridViewTextBoxColumn.DataPropertyName = "CTRSPT"
        Me.CTRSPTDataGridViewTextBoxColumn.HeaderText = "CTRSPT"
        Me.CTRSPTDataGridViewTextBoxColumn.Name = "CTRSPTDataGridViewTextBoxColumn"
        Me.CTRSPTDataGridViewTextBoxColumn.Visible = False
        Me.CTRSPTDataGridViewTextBoxColumn.Width = 72
        '
        'NDCMFCDataGridViewTextBoxColumn
        '
        Me.NDCMFCDataGridViewTextBoxColumn.DataPropertyName = "NDCMFC"
        Me.NDCMFCDataGridViewTextBoxColumn.HeaderText = "NDCMFC"
        Me.NDCMFCDataGridViewTextBoxColumn.Name = "NDCMFCDataGridViewTextBoxColumn"
        Me.NDCMFCDataGridViewTextBoxColumn.Visible = False
        Me.NDCMFCDataGridViewTextBoxColumn.Width = 82
        '
        'NHRCALDataGridViewTextBoxColumn
        '
        Me.NHRCALDataGridViewTextBoxColumn.DataPropertyName = "NHRCAL"
        Me.NHRCALDataGridViewTextBoxColumn.HeaderText = "Tiempo Calculado"
        Me.NHRCALDataGridViewTextBoxColumn.Name = "NHRCALDataGridViewTextBoxColumn"
        Me.NHRCALDataGridViewTextBoxColumn.Width = 127
        '
        'NHRFACDataGridViewTextBoxColumn
        '
        Me.NHRFACDataGridViewTextBoxColumn.DataPropertyName = "NHRFAC"
        Me.NHRFACDataGridViewTextBoxColumn.HeaderText = "Tiempo Facturado"
        Me.NHRFACDataGridViewTextBoxColumn.Name = "NHRFACDataGridViewTextBoxColumn"
        Me.NHRFACDataGridViewTextBoxColumn.Width = 128
        '
        'OBSERDataGridViewTextBoxColumn
        '
        Me.OBSERDataGridViewTextBoxColumn.DataPropertyName = "OBSER"
        Me.OBSERDataGridViewTextBoxColumn.HeaderText = "Observacion"
        Me.OBSERDataGridViewTextBoxColumn.Name = "OBSERDataGridViewTextBoxColumn"
        '
        'dstTicket
        '
        Me.dstTicket.DataSetName = "NewDataSet"
        Me.dstTicket.Tables.AddRange(New System.Data.DataTable() {Me.dtTicket})
        '
        'dtTicket
        '
        Me.dtTicket.Columns.AddRange(New System.Data.DataColumn() {Me.TNORDSR, Me.TNSLCSR, Me.TNROTCK, Me.TNCRRLT, Me.TCSRVNV, Me.TFENVSL, Me.TFAUTR, Me.TFATNSR, Me.THORAINI, Me.THORAFIN, Me.TCTRSPT, Me.TOBSER, Me.TNDCMFC, Me.DataColumn3, Me.DataColumn4})
        Me.dtTicket.TableName = "dtTicket"
        '
        'TNORDSR
        '
        Me.TNORDSR.Caption = "NORDSR"
        Me.TNORDSR.ColumnName = "NORDSR"
        Me.TNORDSR.DataType = GetType(Integer)
        '
        'TNSLCSR
        '
        Me.TNSLCSR.Caption = "NSLCSR"
        Me.TNSLCSR.ColumnName = "NSLCSR"
        Me.TNSLCSR.DataType = GetType(Integer)
        '
        'TNROTCK
        '
        Me.TNROTCK.Caption = "NROTCK"
        Me.TNROTCK.ColumnName = "NROTCK"
        Me.TNROTCK.DataType = GetType(Integer)
        '
        'TNCRRLT
        '
        Me.TNCRRLT.Caption = "NCRRLT"
        Me.TNCRRLT.ColumnName = "NCRRLT"
        Me.TNCRRLT.DataType = GetType(Integer)
        '
        'TCSRVNV
        '
        Me.TCSRVNV.Caption = "CSRVNV"
        Me.TCSRVNV.ColumnName = "CSRVNV"
        '
        'TFENVSL
        '
        Me.TFENVSL.Caption = "FENVSL"
        Me.TFENVSL.ColumnName = "FENVSL"
        Me.TFENVSL.DataType = GetType(Date)
        '
        'TFAUTR
        '
        Me.TFAUTR.Caption = "FAUTR"
        Me.TFAUTR.ColumnName = "FAUTR"
        Me.TFAUTR.DataType = GetType(Date)
        '
        'TFATNSR
        '
        Me.TFATNSR.Caption = "FATNSR"
        Me.TFATNSR.ColumnName = "FATNSR"
        Me.TFATNSR.DataType = GetType(Date)
        '
        'THORAINI
        '
        Me.THORAINI.Caption = "HORAINI"
        Me.THORAINI.ColumnName = "HORAINI"
        '
        'THORAFIN
        '
        Me.THORAFIN.Caption = "HORAFIN"
        Me.THORAFIN.ColumnName = "HORAFIN"
        '
        'TCTRSPT
        '
        Me.TCTRSPT.Caption = "CTRSPT"
        Me.TCTRSPT.ColumnName = "CTRSPT"
        Me.TCTRSPT.DataType = GetType(Integer)
        '
        'TOBSER
        '
        Me.TOBSER.Caption = "OBSER"
        Me.TOBSER.ColumnName = "OBSER"
        '
        'TNDCMFC
        '
        Me.TNDCMFC.Caption = "NDCMFC"
        Me.TNDCMFC.ColumnName = "NDCMFC"
        Me.TNDCMFC.DataType = GetType(Integer)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "NHRCAL"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "NHRFAC"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'hgFiltros
        '
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipo)
        Me.hgFiltros.Panel.Controls.Add(Me.lblRegimen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblcodcliente)
        Me.hgFiltros.Panel.Controls.Add(Me.GroupBox1)
        Me.hgFiltros.Panel.Controls.Add(Me.grpLeyenda)
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
        Me.hgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(964, 115)
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
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(393, 13)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(98, 19)
        Me.lblTipo.TabIndex = 39
        Me.lblTipo.Text = "Tipo de Regimen:"
        Me.lblTipo.Values.ExtraText = ""
        Me.lblTipo.Values.Image = Nothing
        Me.lblTipo.Values.Text = "Tipo de Regimen:"
        '
        'lblRegimen
        '
        Me.lblRegimen.Location = New System.Drawing.Point(489, 13)
        Me.lblRegimen.Name = "lblRegimen"
        Me.lblRegimen.Size = New System.Drawing.Size(90, 16)
        Me.lblRegimen.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegimen.TabIndex = 38
        Me.lblRegimen.Text = "KryptonLabel14"
        Me.lblRegimen.Values.ExtraText = ""
        Me.lblRegimen.Values.Image = Nothing
        Me.lblRegimen.Values.Text = "KryptonLabel14"
        '
        'lblcodcliente
        '
        Me.lblcodcliente.Location = New System.Drawing.Point(65, 16)
        Me.lblcodcliente.Name = "lblcodcliente"
        Me.lblcodcliente.Size = New System.Drawing.Size(16, 19)
        Me.lblcodcliente.TabIndex = 37
        Me.lblcodcliente.Text = "0"
        Me.lblcodcliente.Values.ExtraText = ""
        Me.lblcodcliente.Values.Image = Nothing
        Me.lblcodcliente.Values.Text = "0"
        Me.lblcodcliente.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.KryptonLabel12)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(679, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 45)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leyenda"
        Me.GroupBox1.Visible = False
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(129, 19)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel12.TabIndex = 20
        Me.KryptonLabel12.Text = "Opcional"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Opcional"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(36, 18)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel13.TabIndex = 18
        Me.KryptonLabel13.Text = "Obligatorio"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Obligatorio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(104, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "   "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "   "
        '
        'grpLeyenda
        '
        Me.grpLeyenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLeyenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLeyenda.Controls.Add(Me.lblDetalleOpcional)
        Me.grpLeyenda.Controls.Add(Me.lblDetalleObligatorio)
        Me.grpLeyenda.Controls.Add(Me.lblOpcional)
        Me.grpLeyenda.Controls.Add(Me.lblObligatorio)
        Me.grpLeyenda.Location = New System.Drawing.Point(766, 10)
        Me.grpLeyenda.Name = "grpLeyenda"
        Me.grpLeyenda.Size = New System.Drawing.Size(101, 69)
        Me.grpLeyenda.TabIndex = 16
        Me.grpLeyenda.TabStop = False
        Me.grpLeyenda.Text = "Leyenda"
        Me.grpLeyenda.Visible = False
        '
        'lblDetalleOpcional
        '
        Me.lblDetalleOpcional.Location = New System.Drawing.Point(39, 40)
        Me.lblDetalleOpcional.Name = "lblDetalleOpcional"
        Me.lblDetalleOpcional.Size = New System.Drawing.Size(55, 19)
        Me.lblDetalleOpcional.TabIndex = 20
        Me.lblDetalleOpcional.Text = "Opcional"
        Me.lblDetalleOpcional.Values.ExtraText = ""
        Me.lblDetalleOpcional.Values.Image = Nothing
        Me.lblDetalleOpcional.Values.Text = "Opcional"
        '
        'lblDetalleObligatorio
        '
        Me.lblDetalleObligatorio.Location = New System.Drawing.Point(36, 18)
        Me.lblDetalleObligatorio.Name = "lblDetalleObligatorio"
        Me.lblDetalleObligatorio.Size = New System.Drawing.Size(67, 19)
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
        Me.lblOpcional.Location = New System.Drawing.Point(12, 39)
        Me.lblOpcional.Name = "lblOpcional"
        Me.lblOpcional.Size = New System.Drawing.Size(18, 15)
        Me.lblOpcional.TabIndex = 19
        Me.lblOpcional.Text = "   "
        '
        'lblObligatorio
        '
        Me.lblObligatorio.AutoSize = True
        Me.lblObligatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblObligatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblObligatorio.Location = New System.Drawing.Point(12, 18)
        Me.lblObligatorio.Name = "lblObligatorio"
        Me.lblObligatorio.Size = New System.Drawing.Size(18, 15)
        Me.lblObligatorio.TabIndex = 17
        Me.lblObligatorio.Text = "   "
        '
        'cbxPublicarWEB
        '
        Me.cbxPublicarWEB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPublicarWEB.DropDownWidth = 82
        Me.cbxPublicarWEB.FormattingEnabled = False
        Me.cbxPublicarWEB.ItemHeight = 13
        Me.cbxPublicarWEB.Items.AddRange(New Object() {"", "SI", "NO"})
        Me.cbxPublicarWEB.Location = New System.Drawing.Point(468, 61)
        Me.cbxPublicarWEB.Name = "cbxPublicarWEB"
        Me.cbxPublicarWEB.Size = New System.Drawing.Size(82, 21)
        Me.cbxPublicarWEB.TabIndex = 15
        '
        'lblPublicarWEB
        '
        Me.lblPublicarWEB.Location = New System.Drawing.Point(389, 66)
        Me.lblPublicarWEB.Name = "lblPublicarWEB"
        Me.lblPublicarWEB.Size = New System.Drawing.Size(39, 19)
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
        Me.txtFamilia.Location = New System.Drawing.Point(109, 38)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(278, 21)
        Me.txtFamilia.TabIndex = 5
        Me.TypeValidator.SetTypes(Me.txtFamilia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
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
        Me.txtGrupo.Location = New System.Drawing.Point(109, 63)
        Me.txtGrupo.MaxLength = 30
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(278, 21)
        Me.txtGrupo.TabIndex = 7
        Me.TypeValidator.SetTypes(Me.txtGrupo, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
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
        Me.KryptonLabel6.Location = New System.Drawing.Point(7, 66)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(47, 19)
        Me.KryptonLabel6.TabIndex = 6
        Me.KryptonLabel6.Text = "Grupo : "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Grupo : "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(7, 41)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(51, 19)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Familia : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Familia : "
        '
        'lblFechaInventario
        '
        Me.lblFechaInventario.Location = New System.Drawing.Point(557, 41)
        Me.lblFechaInventario.Name = "lblFechaInventario"
        Me.lblFechaInventario.Size = New System.Drawing.Size(98, 19)
        Me.lblFechaInventario.TabIndex = 12
        Me.lblFechaInventario.Text = "Fecha Inventario : "
        Me.lblFechaInventario.Values.ExtraText = ""
        Me.lblFechaInventario.Values.Image = Nothing
        Me.lblFechaInventario.Values.Text = "Fecha Inventario : "
        '
        'txtFechaInventario
        '
        Me.txtFechaInventario.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaInventario.Location = New System.Drawing.Point(664, 38)
        Me.txtFechaInventario.Mask = "##/##/####"
        Me.txtFechaInventario.Name = "txtFechaInventario"
        Me.txtFechaInventario.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaInventario.Size = New System.Drawing.Size(82, 21)
        Me.txtFechaInventario.TabIndex = 13
        Me.txtFechaInventario.Text = "  /  /"
        '
        'lblFechaVencimiento
        '
        Me.lblFechaVencimiento.Location = New System.Drawing.Point(389, 41)
        Me.lblFechaVencimiento.Name = "lblFechaVencimiento"
        Me.lblFechaVencimiento.Size = New System.Drawing.Size(73, 19)
        Me.lblFechaVencimiento.TabIndex = 10
        Me.lblFechaVencimiento.Text = "Fecha Vcto. : "
        Me.lblFechaVencimiento.Values.ExtraText = ""
        Me.lblFechaVencimiento.Values.Image = Nothing
        Me.lblFechaVencimiento.Values.Text = "Fecha Vcto. : "
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(468, 38)
        Me.txtFechaVencimiento.Mask = "##/##/####"
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(82, 21)
        Me.txtFechaVencimiento.TabIndex = 11
        Me.txtFechaVencimiento.Text = "  /  /"
        '
        'txtMercaderia
        '
        Me.txtMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtMercaderia, True)
        Me.txtMercaderia.Location = New System.Drawing.Point(468, 13)
        Me.txtMercaderia.Name = "txtMercaderia"
        Me.txtMercaderia.Size = New System.Drawing.Size(278, 21)
        Me.txtMercaderia.TabIndex = 9
        Me.TypeValidator.SetTypes(Me.txtMercaderia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblMercadaeria
        '
        Me.lblMercadaeria.Location = New System.Drawing.Point(389, 16)
        Me.lblMercadaeria.Name = "lblMercadaeria"
        Me.lblMercadaeria.Size = New System.Drawing.Size(72, 19)
        Me.lblMercadaeria.TabIndex = 8
        Me.lblMercadaeria.Text = "Mercadería : "
        Me.lblMercadaeria.Values.ExtraText = ""
        Me.lblMercadaeria.Values.Image = Nothing
        Me.lblMercadaeria.Values.Text = "Mercadería : "
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnActualizar.Location = New System.Drawing.Point(872, 6)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(78, 55)
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
        'txtCliente
        '
        Me.txtCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaClienteListar})
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCliente, True)
        Me.txtCliente.Location = New System.Drawing.Point(109, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(278, 21)
        Me.txtCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.TabIndex = 3
        Me.TypeValidator.SetTypes(Me.txtCliente, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaClienteListar
        '
        Me.bsaClienteListar.ExtraText = ""
        Me.bsaClienteListar.Image = Nothing
        Me.bsaClienteListar.Text = ""
        Me.bsaClienteListar.ToolTipImage = Nothing
        Me.bsaClienteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaClienteListar.UniqueName = "AAA4BECF6E674984AAA4BECF6E674984"
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
        'KryptonTextBox1
        '
        Me.TypeValidator.SetDecimales(Me.KryptonTextBox1, 2)
        Me.KryptonTextBox1.Location = New System.Drawing.Point(108, 146)
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(88, 19)
        Me.KryptonTextBox1.TabIndex = 63
        Me.KryptonTextBox1.Text = "0.00"
        Me.KryptonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.KryptonTextBox1, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonTextBox2
        '
        Me.KryptonTextBox2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny2})
        Me.KryptonTextBox2.Location = New System.Drawing.Point(271, 146)
        Me.KryptonTextBox2.MaxLength = 10
        Me.KryptonTextBox2.Name = "KryptonTextBox2"
        Me.KryptonTextBox2.Size = New System.Drawing.Size(100, 21)
        Me.KryptonTextBox2.TabIndex = 65
        Me.KryptonTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.KryptonTextBox2, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'ButtonSpecAny2
        '
        Me.ButtonSpecAny2.ExtraText = ""
        Me.ButtonSpecAny2.Image = Nothing
        Me.ButtonSpecAny2.Text = ""
        Me.ButtonSpecAny2.ToolTipImage = Nothing
        Me.ButtonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecAny2.UniqueName = "2D4EDDA325914A122D4EDDA325914A12"
        '
        'KryptonTextBox3
        '
        Me.TypeValidator.SetDecimales(Me.KryptonTextBox3, 2)
        Me.KryptonTextBox3.Location = New System.Drawing.Point(108, 121)
        Me.KryptonTextBox3.Name = "KryptonTextBox3"
        Me.KryptonTextBox3.Size = New System.Drawing.Size(88, 19)
        Me.KryptonTextBox3.TabIndex = 59
        Me.KryptonTextBox3.Text = "0.00"
        Me.KryptonTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.KryptonTextBox3, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonTextBox4
        '
        Me.TypeValidator.SetDecimales(Me.KryptonTextBox4, 2)
        Me.KryptonTextBox4.Location = New System.Drawing.Point(108, 96)
        Me.KryptonTextBox4.Name = "KryptonTextBox4"
        Me.KryptonTextBox4.Size = New System.Drawing.Size(88, 19)
        Me.KryptonTextBox4.TabIndex = 55
        Me.KryptonTextBox4.Text = "0.00"
        Me.KryptonTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.KryptonTextBox4, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonTextBox5
        '
        Me.KryptonTextBox5.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny3})
        Me.KryptonTextBox5.Location = New System.Drawing.Point(271, 121)
        Me.KryptonTextBox5.MaxLength = 10
        Me.KryptonTextBox5.Name = "KryptonTextBox5"
        Me.KryptonTextBox5.Size = New System.Drawing.Size(100, 21)
        Me.KryptonTextBox5.TabIndex = 61
        Me.KryptonTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.KryptonTextBox5, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'ButtonSpecAny3
        '
        Me.ButtonSpecAny3.ExtraText = ""
        Me.ButtonSpecAny3.Image = Nothing
        Me.ButtonSpecAny3.Text = ""
        Me.ButtonSpecAny3.ToolTipImage = Nothing
        Me.ButtonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecAny3.UniqueName = "2D4EDDA325914A122D4EDDA325914A12"
        '
        'KryptonTextBox6
        '
        Me.KryptonTextBox6.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny4})
        Me.KryptonTextBox6.Location = New System.Drawing.Point(271, 96)
        Me.KryptonTextBox6.MaxLength = 10
        Me.KryptonTextBox6.Name = "KryptonTextBox6"
        Me.KryptonTextBox6.Size = New System.Drawing.Size(100, 21)
        Me.KryptonTextBox6.TabIndex = 57
        Me.KryptonTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.KryptonTextBox6, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'ButtonSpecAny4
        '
        Me.ButtonSpecAny4.ExtraText = ""
        Me.ButtonSpecAny4.Image = Nothing
        Me.ButtonSpecAny4.Text = ""
        Me.ButtonSpecAny4.ToolTipImage = Nothing
        Me.ButtonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecAny4.UniqueName = "33BE470ED3D044A133BE470ED3D044A1"
        '
        'KryptonDataGridView1
        '
        Me.KryptonDataGridView1.AllowUserToAddRows = False
        Me.KryptonDataGridView1.AllowUserToDeleteRows = False
        Me.KryptonDataGridView1.AllowUserToResizeColumns = False
        Me.KryptonDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.LemonChiffon
        Me.KryptonDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle20
        Me.KryptonDataGridView1.AutoGenerateColumns = False
        Me.KryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.KryptonDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.KryptonDataGridView1.DataMember = "dtOrdenServicio"
        Me.KryptonDataGridView1.DataSource = Me.dstOrdenServicio
        Me.KryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonDataGridView1.MultiSelect = False
        Me.KryptonDataGridView1.Name = "KryptonDataGridView1"
        Me.KryptonDataGridView1.ReadOnly = True
        Me.KryptonDataGridView1.RowHeadersWidth = 20
        Me.KryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.KryptonDataGridView1.Size = New System.Drawing.Size(415, 235)
        Me.KryptonDataGridView1.StandardTab = True
        Me.KryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.KryptonDataGridView1.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.KryptonDataGridView1.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NORDSR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro. O/S"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NCNTR"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Contrato"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 82
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NCRCTC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Corr."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 61
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NAUTR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Autorización"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 101
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FEMORS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 66
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CTPDP6"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tipo Depósito"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 108
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QSLMC"
        Me.DataGridViewTextBoxColumn7.HeaderText = "S. Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 95
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CUNCN5"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 74
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QSLMP"
        Me.DataGridViewTextBoxColumn9.HeaderText = "S. Peso"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 72
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CUNPS5"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 74
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "QSLMV"
        Me.DataGridViewTextBoxColumn11.HeaderText = "S. Valor"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 75
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CUNVL5"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 74
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FUNDS2"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 68
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonHeaderGroup2.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup2.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 235)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.ComboBox1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonButton2)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonCheckBox1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonTextBox1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonTextBox2)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonTextBox3)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonTextBox4)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonTextBox5)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonTextBox6)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonDataGridView2)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(415, 20)
        Me.KryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 50
        Me.KryptonHeaderGroup2.Text = "Crear Nueva O/S"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Crear Nueva O/S"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"C", "P"})
        Me.ComboBox1.Location = New System.Drawing.Point(108, 171)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(42, 21)
        Me.ComboBox1.TabIndex = 67
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(40, 176)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel2.TabIndex = 66
        Me.KryptonLabel2.Text = "Unid. Desp:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Unid. Desp:"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(271, 208)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(100, 25)
        Me.KryptonButton1.TabIndex = 70
        Me.KryptonButton1.Text = "Cancelar"
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = CType(resources.GetObject("KryptonButton1.Values.Image"), System.Drawing.Image)
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = "Cancelar"
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(153, 208)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.Size = New System.Drawing.Size(100, 25)
        Me.KryptonButton2.TabIndex = 69
        Me.KryptonButton2.Text = "Procesar"
        Me.KryptonButton2.Values.ExtraText = ""
        Me.KryptonButton2.Values.Image = CType(resources.GetObject("KryptonButton2.Values.Image"), System.Drawing.Image)
        Me.KryptonButton2.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton2.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton2.Values.Text = "Procesar"
        '
        'KryptonCheckBox1
        '
        Me.KryptonCheckBox1.Checked = False
        Me.KryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.KryptonCheckBox1.Location = New System.Drawing.Point(220, 176)
        Me.KryptonCheckBox1.Name = "KryptonCheckBox1"
        Me.KryptonCheckBox1.Size = New System.Drawing.Size(106, 19)
        Me.KryptonCheckBox1.TabIndex = 68
        Me.KryptonCheckBox1.Text = "Control por Lote"
        Me.KryptonCheckBox1.Values.ExtraText = ""
        Me.KryptonCheckBox1.Values.Image = Nothing
        Me.KryptonCheckBox1.Values.Text = "Control por Lote"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(40, 149)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(42, 19)
        Me.KryptonLabel4.TabIndex = 62
        Me.KryptonLabel4.Text = "Valor : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Valor : "
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(213, 149)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel7.TabIndex = 64
        Me.KryptonLabel7.Text = "Unidad :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Unidad :"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(40, 124)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(39, 19)
        Me.KryptonLabel8.TabIndex = 58
        Me.KryptonLabel8.Text = "Peso : "
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Peso : "
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(40, 99)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(61, 19)
        Me.KryptonLabel9.TabIndex = 54
        Me.KryptonLabel9.Text = "Cantidad : "
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Cantidad : "
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(213, 124)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel10.TabIndex = 60
        Me.KryptonLabel10.Text = "Unidad :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Unidad :"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(213, 99)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel11.TabIndex = 56
        Me.KryptonLabel11.Text = "Unidad : "
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Unidad : "
        '
        'KryptonDataGridView2
        '
        Me.KryptonDataGridView2.AllowUserToAddRows = False
        Me.KryptonDataGridView2.AllowUserToDeleteRows = False
        Me.KryptonDataGridView2.AllowUserToResizeColumns = False
        Me.KryptonDataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.LemonChiffon
        Me.KryptonDataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.KryptonDataGridView2.AutoGenerateColumns = False
        Me.KryptonDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.KryptonDataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.KryptonDataGridView2.DataMember = "dtContratos"
        Me.KryptonDataGridView2.DataSource = Me.dstContratos
        Me.KryptonDataGridView2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonDataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonDataGridView2.MultiSelect = False
        Me.KryptonDataGridView2.Name = "KryptonDataGridView2"
        Me.KryptonDataGridView2.ReadOnly = True
        Me.KryptonDataGridView2.RowHeadersWidth = 20
        Me.KryptonDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.KryptonDataGridView2.Size = New System.Drawing.Size(413, 85)
        Me.KryptonDataGridView2.StandardTab = True
        Me.KryptonDataGridView2.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.KryptonDataGridView2.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.KryptonDataGridView2.TabIndex = 53
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NCNTR"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nro. Contrato"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 107
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CTPDP3"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tipo Depósito"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 108
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TABDPS"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Depósito"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 83
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CTPPR1"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 83
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CUNCN3"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Unidad Cantidad"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 124
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CUNPS3"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Unidad Peso"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 101
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CUNVL3"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Unidad Valor"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 104
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = CType(resources.GetObject("ButtonSpecHeaderGroup1.Image"), System.Drawing.Image)
        Me.ButtonSpecHeaderGroup1.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.ButtonSpecHeaderGroup1.Text = "Crear O/S"
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.UniqueName = "22A012AE22564A2A22A012AE22564A2A"
        '
        'bsaProcesarTicket
        '
        Me.bsaProcesarTicket.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked
        Me.bsaProcesarTicket.ExtraText = ""
        Me.bsaProcesarTicket.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.bsaProcesarTicket.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaProcesarTicket.Text = "Procesar Ticket"
        Me.bsaProcesarTicket.ToolTipImage = Nothing
        Me.bsaProcesarTicket.UniqueName = "33BBEFB3C4CA408933BBEFB3C4CA4089"
        '
        'frmRecepcionSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 626)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecepcionSDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepción"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgMercaderia.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderia.Panel.ResumeLayout(False)
        CType(Me.hgMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderia.ResumeLayout(False)
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgnorden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgOS.Panel.ResumeLayout(False)
        CType(Me.hgOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgOS.ResumeLayout(False)
        CType(Me.dgListaOrdenesServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgParametrosCrearOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgParametrosCrearOS.Panel.ResumeLayout(False)
        Me.hgParametrosCrearOS.Panel.PerformLayout()
        CType(Me.hgParametrosCrearOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgParametrosCrearOS.ResumeLayout(False)
        CType(Me.dgContratosVigentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kpnuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kpnuevo.ResumeLayout(False)
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.Panel.ResumeLayout(False)
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.ResumeLayout(False)
        CType(Me.dgNroTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dgticket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpLeyenda.ResumeLayout(False)
        Me.grpLeyenda.PerformLayout()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.KryptonDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaClienteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
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
    Friend WithEvents dstContratos As System.Data.DataSet
    Friend WithEvents dtContratos As System.Data.DataTable
    Friend WithEvents NCNTR As System.Data.DataColumn
    Friend WithEvents CTPDP3 As System.Data.DataColumn
    Friend WithEvents TABDPS As System.Data.DataColumn
    Friend WithEvents CTPPR1 As System.Data.DataColumn
    Friend WithEvents CUNCN3 As System.Data.DataColumn
    Friend WithEvents CUNPS3 As System.Data.DataColumn
    Friend WithEvents CUNVL3 As System.Data.DataColumn
    Friend WithEvents OQSLMV As System.Data.DataColumn
    Friend WithEvents OCUNVL5 As System.Data.DataColumn
    Friend WithEvents OFUNDS2 As System.Data.DataColumn
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
    Friend WithEvents STOBSRL As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents KryptonDataGridView1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonCheckBox1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ButtonSpecAny2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox4 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox5 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ButtonSpecAny3 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox6 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ButtonSpecAny4 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonDataGridView2 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents dstTicket As System.Data.DataSet
    Friend WithEvents dtTicket As System.Data.DataTable
    Friend WithEvents TNORDSR As System.Data.DataColumn
    Friend WithEvents TNSLCSR As System.Data.DataColumn
    Friend WithEvents TNROTCK As System.Data.DataColumn
    Friend WithEvents TNCRRLT As System.Data.DataColumn
    Friend WithEvents TCSRVNV As System.Data.DataColumn
    Friend WithEvents TFAUTR As System.Data.DataColumn
    Friend WithEvents TFATNSR As System.Data.DataColumn
    Friend WithEvents THORAINI As System.Data.DataColumn
    Friend WithEvents THORAFIN As System.Data.DataColumn
    Friend WithEvents TCTRSPT As System.Data.DataColumn
    Friend WithEvents TOBSER As System.Data.DataColumn
    Friend WithEvents TNDCMFC As System.Data.DataColumn
    Friend WithEvents TFENVSL As System.Data.DataColumn
    Friend WithEvents bsaProcesarTicket As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents hgMercaderia As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaMercaderia As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaRealizarRecepcion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgMercaderias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgnorden As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaAgregaMercaderiaOS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCrearOS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrarOrden As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaAgregaTicket As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgListaOrdenesServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgParametrosCrearOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cbxUnidadDespacho As System.Windows.Forms.ComboBox
    Friend WithEvents lblUnidadDespacho As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelarCrearOS As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnProcesarCrearOS As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cbxControlLote As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtValor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblValor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadValor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblUnidadValor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPeso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaListarUnidadPeso As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblUnidadPeso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaListarUnidadCantidad As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblUnidadCantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgContratosVigentes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPDP3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TABDPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPPR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNCN3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNPS3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNVL3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kpnuevo As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents hgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaProcesarRecepcion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaEliminarMercaderia As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgNroTicket As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Ticket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaProcesar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaBorrarTicket As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgticket As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsaConsulta As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblcodcliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSLCSRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROTCKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRLTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSRVNVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FENVSLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FAUTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FATNSRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAINIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAFINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTRSPTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCMFCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NHRCALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NHRFACDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsaAnularOrden As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaImpresion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataColumn5 As System.Data.DataColumn
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
    Friend WithEvents S_CCNTD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CTPOCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_FUNDS2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_CTPDPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TOBSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSERIE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblRegimen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bsaBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents O_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QMRCD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPSMR1 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents bsaEditarOS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents M_CFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
