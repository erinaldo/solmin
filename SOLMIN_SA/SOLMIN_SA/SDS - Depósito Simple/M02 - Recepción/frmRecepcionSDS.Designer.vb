<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionSDS
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecepcionSDS))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        'Dim BePlanta1 As Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta = New Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.grpListadoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.dgMercaderias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_MARCRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
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
        Me.DataColumn4 = New System.Data.DataColumn
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.btnRealizarRecepcion = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnMercaderia = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador04 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbTransferencias = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador02 = New System.Windows.Forms.ToolStripSeparator
        Me.txtBuscarMercaderia = New System.Windows.Forms.ToolStripTextBox
        Me.lblBuscar = New System.Windows.Forms.ToolStripLabel
        Me.tssSeparador01 = New System.Windows.Forms.ToolStripSeparator
        Me.hgOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaAgregaMercaderiaOS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCrearOS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaModificarOS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaOcultar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgListaOrdenesServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.O_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.O_FUNCTL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_QMRCD1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_QPSMR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_QVLMR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.OFUNCTL = New System.Data.DataColumn
        Me.OQMRCD1 = New System.Data.DataColumn
        Me.OQPSMR1 = New System.Data.DataColumn
        Me.OQVLMR1 = New System.Data.DataColumn
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
        Me.hgParametrosModificarOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.lblOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbxControlDespacho_M = New System.Windows.Forms.ComboBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancelarModificarOS = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnActualizarModificarOS = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.cbxControlLote_M = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtValor_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUnidadValor_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ButtonSpecAny2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPeso_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCantidad_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUnidadPeso_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ButtonSpecAny3 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUnidadCantidad_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ButtonSpecAny4 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.hgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaProcesarGuia = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaProcesarRecepcion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaEliminarItem = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
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
        Me.S_CTPOCN = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.S_FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_CTPDPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TOBSRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
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
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.grpListadoMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpListadoMercaderia.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpListadoMercaderia.Panel.SuspendLayout()
        Me.grpListadoMercaderia.SuspendLayout()
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspListadoMercaderia.SuspendLayout()
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
        CType(Me.hgParametrosModificarOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgParametrosModificarOS.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgParametrosModificarOS.Panel.SuspendLayout()
        Me.hgParametrosModificarOS.SuspendLayout()
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
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1204, 585)
        Me.KryptonPanel.TabIndex = 0
        '
        'grpListadoMercaderia
        '
        Me.grpListadoMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpListadoMercaderia.Location = New System.Drawing.Point(0, 118)
        Me.grpListadoMercaderia.Name = "grpListadoMercaderia"
        '
        'grpListadoMercaderia.Panel
        '
        Me.grpListadoMercaderia.Panel.Controls.Add(Me.dgMercaderias)
        Me.grpListadoMercaderia.Panel.Controls.Add(Me.tspListadoMercaderia)
        Me.grpListadoMercaderia.Size = New System.Drawing.Size(601, 207)
        Me.grpListadoMercaderia.TabIndex = 53
        '
        'dgMercaderias
        '
        Me.dgMercaderias.AllowUserToAddRows = False
        Me.dgMercaderias.AllowUserToDeleteRows = False
        Me.dgMercaderias.AllowUserToResizeColumns = False
        Me.dgMercaderias.AllowUserToResizeRows = False
        Me.dgMercaderias.AutoGenerateColumns = False
        Me.dgMercaderias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMercaderias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CMRCLR, Me.M_TMRCD2, Me.M_CMRCD, Me.M_SALDO, Me.M_SESTRG, Me.M_MARCRE, Me.M_TFMCLR, Me.M_TGRCLR, Me.M_SITUAC})
        Me.dgMercaderias.DataMember = "dtMercaderia"
        Me.dgMercaderias.DataSource = Me.dstMercaderia
        Me.dgMercaderias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderias.Location = New System.Drawing.Point(0, 25)
        Me.dgMercaderias.MultiSelect = False
        Me.dgMercaderias.Name = "dgMercaderias"
        Me.dgMercaderias.ReadOnly = True
        Me.dgMercaderias.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderias.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgMercaderias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderias.Size = New System.Drawing.Size(599, 180)
        Me.dgMercaderias.StandardTab = True
        Me.dgMercaderias.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderias.TabIndex = 23
        '
        'M_CMRCLR
        '
        Me.M_CMRCLR.DataPropertyName = "CMRCLR"
        Me.M_CMRCLR.FillWeight = 38.49408!
        Me.M_CMRCLR.HeaderText = "Mercadería"
        Me.M_CMRCLR.MinimumWidth = 60
        Me.M_CMRCLR.Name = "M_CMRCLR"
        Me.M_CMRCLR.ReadOnly = True
        '
        'M_TMRCD2
        '
        Me.M_TMRCD2.DataPropertyName = "TMRCD2"
        Me.M_TMRCD2.FillWeight = 469.0355!
        Me.M_TMRCD2.HeaderText = "Detalle"
        Me.M_TMRCD2.MinimumWidth = 120
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
        Me.M_SALDO.FillWeight = 38.49408!
        Me.M_SALDO.HeaderText = "Saldo"
        Me.M_SALDO.MinimumWidth = 30
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
        Me.M_MARCRE.FillWeight = 38.49408!
        Me.M_MARCRE.HeaderText = "CD"
        Me.M_MARCRE.MinimumWidth = 20
        Me.M_MARCRE.Name = "M_MARCRE"
        Me.M_MARCRE.ReadOnly = True
        '
        'M_TFMCLR
        '
        Me.M_TFMCLR.DataPropertyName = "TFMCLR"
        Me.M_TFMCLR.FillWeight = 38.49408!
        Me.M_TFMCLR.HeaderText = "Familia"
        Me.M_TFMCLR.MinimumWidth = 60
        Me.M_TFMCLR.Name = "M_TFMCLR"
        Me.M_TFMCLR.ReadOnly = True
        '
        'M_TGRCLR
        '
        Me.M_TGRCLR.DataPropertyName = "TGRCLR"
        Me.M_TGRCLR.FillWeight = 38.49408!
        Me.M_TGRCLR.HeaderText = "Grupo"
        Me.M_TGRCLR.MinimumWidth = 60
        Me.M_TGRCLR.Name = "M_TGRCLR"
        Me.M_TGRCLR.ReadOnly = True
        '
        'M_SITUAC
        '
        Me.M_SITUAC.DataPropertyName = "SITUAC"
        Me.M_SITUAC.FillWeight = 38.49408!
        Me.M_SITUAC.HeaderText = "Situación"
        Me.M_SITUAC.MinimumWidth = 70
        Me.M_SITUAC.Name = "M_SITUAC"
        Me.M_SITUAC.ReadOnly = True
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
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.AutoSize = False
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTitulo, Me.btnRealizarRecepcion, Me.tssSeparador03, Me.btnMercaderia, Me.tssSeparador04, Me.tsbTransferencias, Me.tssSeparador02, Me.txtBuscarMercaderia, Me.lblBuscar, Me.tssSeparador01})
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(599, 25)
        Me.tspListadoMercaderia.TabIndex = 0
        Me.tspListadoMercaderia.Text = "ToolStrip1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Image = CType(resources.GetObject("lblTitulo.Image"), System.Drawing.Image)
        Me.lblTitulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(180, 22)
        Me.lblTitulo.Text = "Listado de Mercaderia"
        '
        'btnRealizarRecepcion
        '
        Me.btnRealizarRecepcion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnRealizarRecepcion.Image = CType(resources.GetObject("btnRealizarRecepcion.Image"), System.Drawing.Image)
        Me.btnRealizarRecepcion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRealizarRecepcion.Name = "btnRealizarRecepcion"
        Me.btnRealizarRecepcion.Size = New System.Drawing.Size(104, 22)
        Me.btnRealizarRecepcion.Text = "Iniciar Proceso"
        '
        'tssSeparador03
        '
        Me.tssSeparador03.Name = "tssSeparador03"
        Me.tssSeparador03.Size = New System.Drawing.Size(6, 25)
        '
        'btnMercaderia
        '
        Me.btnMercaderia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnMercaderia.Image = CType(resources.GetObject("btnMercaderia.Image"), System.Drawing.Image)
        Me.btnMercaderia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMercaderia.Name = "btnMercaderia"
        Me.btnMercaderia.Size = New System.Drawing.Size(86, 22)
        Me.btnMercaderia.Text = "Mercadería"
        '
        'tssSeparador04
        '
        Me.tssSeparador04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador04.Name = "tssSeparador04"
        Me.tssSeparador04.Size = New System.Drawing.Size(6, 25)
        '
        'tsbTransferencias
        '
        Me.tsbTransferencias.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbTransferencias.Image = Global.SOLMIN_SA.My.Resources.Resources.autostart
        Me.tsbTransferencias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTransferencias.Name = "tsbTransferencias"
        Me.tsbTransferencias.Size = New System.Drawing.Size(103, 22)
        Me.tsbTransferencias.Text = "Transferencias"
        '
        'tssSeparador02
        '
        Me.tssSeparador02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador02.Name = "tssSeparador02"
        Me.tssSeparador02.Size = New System.Drawing.Size(6, 25)
        '
        'txtBuscarMercaderia
        '
        Me.txtBuscarMercaderia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtBuscarMercaderia.MaxLength = 30
        Me.txtBuscarMercaderia.Name = "txtBuscarMercaderia"
        Me.txtBuscarMercaderia.ReadOnly = True
        Me.txtBuscarMercaderia.Size = New System.Drawing.Size(150, 23)
        '
        'lblBuscar
        '
        Me.lblBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(54, 13)
        Me.lblBuscar.Text = "Buscar :"
        '
        'tssSeparador01
        '
        Me.tssSeparador01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador01.Name = "tssSeparador01"
        Me.tssSeparador01.Size = New System.Drawing.Size(6, 25)
        '
        'hgOS
        '
        Me.hgOS.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaAgregaMercaderiaOS, Me.bsaCrearOS, Me.bsaModificarOS, Me.bsaOcultar})
        Me.hgOS.Dock = System.Windows.Forms.DockStyle.Right
        Me.hgOS.HeaderVisibleSecondary = False
        Me.hgOS.Location = New System.Drawing.Point(601, 118)
        Me.hgOS.Name = "hgOS"
        '
        'hgOS.Panel
        '
        Me.hgOS.Panel.Controls.Add(Me.dgListaOrdenesServicio)
        Me.hgOS.Panel.Controls.Add(Me.hgParametrosCrearOS)
        Me.hgOS.Panel.Controls.Add(Me.hgParametrosModificarOS)
        Me.hgOS.Size = New System.Drawing.Size(603, 207)
        Me.hgOS.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgOS.TabIndex = 52
        Me.hgOS.Text = "Orden de Servicios"
        Me.hgOS.ValuesPrimary.Description = ""
        Me.hgOS.ValuesPrimary.Heading = "Orden de Servicios"
        Me.hgOS.ValuesPrimary.Image = Nothing
        Me.hgOS.ValuesSecondary.Description = ""
        Me.hgOS.ValuesSecondary.Heading = "Description"
        Me.hgOS.ValuesSecondary.Image = Nothing
        Me.hgOS.Visible = False
        '
        'bsaAgregaMercaderiaOS
        '
        Me.bsaAgregaMercaderiaOS.ExtraText = ""
        Me.bsaAgregaMercaderiaOS.Image = CType(resources.GetObject("bsaAgregaMercaderiaOS.Image"), System.Drawing.Image)
        Me.bsaAgregaMercaderiaOS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaAgregaMercaderiaOS.Text = "Agregar Mercadería"
        Me.bsaAgregaMercaderiaOS.ToolTipImage = Nothing
        Me.bsaAgregaMercaderiaOS.UniqueName = "5033E7CFDAAA4BBF5033E7CFDAAA4BBF"
        '
        'bsaCrearOS
        '
        Me.bsaCrearOS.ExtraText = ""
        Me.bsaCrearOS.Image = CType(resources.GetObject("bsaCrearOS.Image"), System.Drawing.Image)
        Me.bsaCrearOS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaCrearOS.Text = "Crear O/S"
        Me.bsaCrearOS.ToolTipImage = Nothing
        Me.bsaCrearOS.UniqueName = "22A012AE22564A2A22A012AE22564A2A"
        '
        'bsaModificarOS
        '
        Me.bsaModificarOS.ExtraText = ""
        Me.bsaModificarOS.Image = Nothing
        Me.bsaModificarOS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaModificarOS.Text = "Modificar O/S"
        Me.bsaModificarOS.ToolTipImage = Nothing
        Me.bsaModificarOS.UniqueName = "4061D697752C447A4061D697752C447A"
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
        Me.dgListaOrdenesServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.O_NORDSR, Me.O_NCNTR, Me.O_NCRCTC, Me.O_NAUTR, Me.O_FEMORS, Me.O_CTPDP6, Me.O_QSLMC, Me.O_CUNCN5, Me.O_QSLMP, Me.O_CUNPS5, Me.O_QSLMV, Me.O_CUNVL5, Me.O_FUNDS2, Me.O_FUNCTL, Me.O_QMRCD1, Me.O_QPSMR1, Me.O_QVLMR1})
        Me.dgListaOrdenesServicio.DataMember = "dtOrdenServicio"
        Me.dgListaOrdenesServicio.DataSource = Me.dstOrdenServicio
        Me.dgListaOrdenesServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListaOrdenesServicio.Location = New System.Drawing.Point(0, 0)
        Me.dgListaOrdenesServicio.MultiSelect = False
        Me.dgListaOrdenesServicio.Name = "dgListaOrdenesServicio"
        Me.dgListaOrdenesServicio.ReadOnly = True
        Me.dgListaOrdenesServicio.RowHeadersWidth = 20
        Me.dgListaOrdenesServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaOrdenesServicio.Size = New System.Drawing.Size(601, 136)
        Me.dgListaOrdenesServicio.StandardTab = True
        Me.dgListaOrdenesServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgListaOrdenesServicio.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgListaOrdenesServicio.TabIndex = 52
        '
        'O_NORDSR
        '
        Me.O_NORDSR.DataPropertyName = "NORDSR"
        Me.O_NORDSR.HeaderText = "Nro. O/S"
        Me.O_NORDSR.Name = "O_NORDSR"
        Me.O_NORDSR.ReadOnly = True
        Me.O_NORDSR.Width = 82
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
        Me.O_FEMORS.Width = 67
        '
        'O_CTPDP6
        '
        Me.O_CTPDP6.DataPropertyName = "CTPDP6"
        Me.O_CTPDP6.HeaderText = "Tipo Depósito"
        Me.O_CTPDP6.Name = "O_CTPDP6"
        Me.O_CTPDP6.ReadOnly = True
        Me.O_CTPDP6.Width = 110
        '
        'O_QSLMC
        '
        Me.O_QSLMC.DataPropertyName = "QSLMC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N4"
        DataGridViewCellStyle4.NullValue = "0.0000"
        Me.O_QSLMC.DefaultCellStyle = DataGridViewCellStyle4
        Me.O_QSLMC.HeaderText = "S. Cantidad"
        Me.O_QSLMC.Name = "O_QSLMC"
        Me.O_QSLMC.ReadOnly = True
        Me.O_QSLMC.Width = 96
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N4"
        DataGridViewCellStyle5.NullValue = "0.0000"
        Me.O_QSLMP.DefaultCellStyle = DataGridViewCellStyle5
        Me.O_QSLMP.HeaderText = "S. Peso"
        Me.O_QSLMP.Name = "O_QSLMP"
        Me.O_QSLMP.ReadOnly = True
        Me.O_QSLMP.Width = 73
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N4"
        DataGridViewCellStyle6.NullValue = "0.0000"
        Me.O_QSLMV.DefaultCellStyle = DataGridViewCellStyle6
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
        Me.O_FUNDS2.Width = 66
        '
        'O_FUNCTL
        '
        Me.O_FUNCTL.DataPropertyName = "FUNCTL"
        Me.O_FUNCTL.HeaderText = "U Despacho"
        Me.O_FUNCTL.Name = "O_FUNCTL"
        Me.O_FUNCTL.ReadOnly = True
        Me.O_FUNCTL.Visible = False
        Me.O_FUNCTL.Width = 96
        '
        'O_QMRCD1
        '
        Me.O_QMRCD1.DataPropertyName = "QMRCD1"
        Me.O_QMRCD1.HeaderText = "QMRCD1"
        Me.O_QMRCD1.Name = "O_QMRCD1"
        Me.O_QMRCD1.ReadOnly = True
        Me.O_QMRCD1.Visible = False
        Me.O_QMRCD1.Width = 82
        '
        'O_QPSMR1
        '
        Me.O_QPSMR1.DataPropertyName = "QPSMR1"
        Me.O_QPSMR1.HeaderText = "QPSMR1"
        Me.O_QPSMR1.Name = "O_QPSMR1"
        Me.O_QPSMR1.ReadOnly = True
        Me.O_QPSMR1.Visible = False
        Me.O_QPSMR1.Width = 81
        '
        'O_QVLMR1
        '
        Me.O_QVLMR1.DataPropertyName = "QVLMR1"
        Me.O_QVLMR1.HeaderText = "QVLMR1"
        Me.O_QVLMR1.Name = "O_QVLMR1"
        Me.O_QVLMR1.ReadOnly = True
        Me.O_QVLMR1.Visible = False
        Me.O_QVLMR1.Width = 80
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
        'hgParametrosCrearOS
        '
        Me.hgParametrosCrearOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgParametrosCrearOS.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.hgParametrosCrearOS.HeaderVisibleSecondary = False
        Me.hgParametrosCrearOS.Location = New System.Drawing.Point(0, 136)
        Me.hgParametrosCrearOS.Name = "hgParametrosCrearOS"
        '
        'hgParametrosCrearOS.Panel
        '
        Me.hgParametrosCrearOS.Panel.AutoScroll = True
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
        Me.hgParametrosCrearOS.Size = New System.Drawing.Size(601, 20)
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
        Me.cbxUnidadDespacho.Items.AddRange(New Object() {"C", "P"})
        Me.cbxUnidadDespacho.Location = New System.Drawing.Point(108, 166)
        Me.cbxUnidadDespacho.Name = "cbxUnidadDespacho"
        Me.cbxUnidadDespacho.Size = New System.Drawing.Size(42, 21)
        Me.cbxUnidadDespacho.TabIndex = 67
        '
        'lblUnidadDespacho
        '
        Me.lblUnidadDespacho.Location = New System.Drawing.Point(40, 171)
        Me.lblUnidadDespacho.Name = "lblUnidadDespacho"
        Me.lblUnidadDespacho.Size = New System.Drawing.Size(73, 20)
        Me.lblUnidadDespacho.TabIndex = 66
        Me.lblUnidadDespacho.Text = "Unid. Desp:"
        Me.lblUnidadDespacho.Values.ExtraText = ""
        Me.lblUnidadDespacho.Values.Image = Nothing
        Me.lblUnidadDespacho.Values.Text = "Unid. Desp:"
        '
        'btnCancelarCrearOS
        '
        Me.btnCancelarCrearOS.Location = New System.Drawing.Point(271, 203)
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
        Me.btnProcesarCrearOS.Location = New System.Drawing.Point(153, 203)
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
        Me.cbxControlLote.Location = New System.Drawing.Point(220, 171)
        Me.cbxControlLote.Name = "cbxControlLote"
        Me.cbxControlLote.Size = New System.Drawing.Size(113, 20)
        Me.cbxControlLote.TabIndex = 68
        Me.cbxControlLote.Text = "Control por Lote"
        Me.cbxControlLote.Values.ExtraText = ""
        Me.cbxControlLote.Values.Image = Nothing
        Me.cbxControlLote.Values.Text = "Control por Lote"
        '
        'txtValor
        '
        Me.TypeValidator.SetDecimales(Me.txtValor, 2)
        Me.txtValor.Location = New System.Drawing.Point(108, 141)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(88, 22)
        Me.txtValor.TabIndex = 63
        Me.txtValor.Text = "0.00"
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtValor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblValor
        '
        Me.lblValor.Location = New System.Drawing.Point(40, 144)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(45, 20)
        Me.lblValor.TabIndex = 62
        Me.lblValor.Text = "Valor : "
        Me.lblValor.Values.ExtraText = ""
        Me.lblValor.Values.Image = Nothing
        Me.lblValor.Values.Text = "Valor : "
        '
        'txtUnidadValor
        '
        Me.txtUnidadValor.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny1})
        Me.txtUnidadValor.Location = New System.Drawing.Point(271, 141)
        Me.txtUnidadValor.MaxLength = 10
        Me.txtUnidadValor.Name = "txtUnidadValor"
        Me.txtUnidadValor.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidadValor.TabIndex = 65
        Me.txtUnidadValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtUnidadValor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.ExtraText = ""
        Me.ButtonSpecAny1.Image = Nothing
        Me.ButtonSpecAny1.Text = ""
        Me.ButtonSpecAny1.ToolTipImage = Nothing
        Me.ButtonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecAny1.UniqueName = "2D4EDDA325914A122D4EDDA325914A12"
        '
        'lblUnidadValor
        '
        Me.lblUnidadValor.Location = New System.Drawing.Point(213, 144)
        Me.lblUnidadValor.Name = "lblUnidadValor"
        Me.lblUnidadValor.Size = New System.Drawing.Size(56, 20)
        Me.lblUnidadValor.TabIndex = 64
        Me.lblUnidadValor.Text = "Unidad :"
        Me.lblUnidadValor.Values.ExtraText = ""
        Me.lblUnidadValor.Values.Image = Nothing
        Me.lblUnidadValor.Values.Text = "Unidad :"
        '
        'txtPeso
        '
        Me.TypeValidator.SetDecimales(Me.txtPeso, 2)
        Me.txtPeso.Location = New System.Drawing.Point(108, 116)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(88, 22)
        Me.txtPeso.TabIndex = 59
        Me.txtPeso.Text = "0.00"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPeso, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblPeso
        '
        Me.lblPeso.Location = New System.Drawing.Point(40, 119)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(42, 20)
        Me.lblPeso.TabIndex = 58
        Me.lblPeso.Text = "Peso : "
        Me.lblPeso.Values.ExtraText = ""
        Me.lblPeso.Values.Image = Nothing
        Me.lblPeso.Values.Text = "Peso : "
        '
        'txtCantidad
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidad, 2)
        Me.txtCantidad.Location = New System.Drawing.Point(108, 91)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(88, 22)
        Me.txtCantidad.TabIndex = 55
        Me.txtCantidad.Text = "0.00"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidad, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(40, 94)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(66, 20)
        Me.lblCantidad.TabIndex = 54
        Me.lblCantidad.Text = "Cantidad : "
        Me.lblCantidad.Values.ExtraText = ""
        Me.lblCantidad.Values.Image = Nothing
        Me.lblCantidad.Values.Text = "Cantidad : "
        '
        'txtUnidadPeso
        '
        Me.txtUnidadPeso.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaListarUnidadPeso})
        Me.txtUnidadPeso.Location = New System.Drawing.Point(271, 116)
        Me.txtUnidadPeso.MaxLength = 10
        Me.txtUnidadPeso.Name = "txtUnidadPeso"
        Me.txtUnidadPeso.Size = New System.Drawing.Size(100, 22)
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
        Me.lblUnidadPeso.Location = New System.Drawing.Point(213, 119)
        Me.lblUnidadPeso.Name = "lblUnidadPeso"
        Me.lblUnidadPeso.Size = New System.Drawing.Size(56, 20)
        Me.lblUnidadPeso.TabIndex = 60
        Me.lblUnidadPeso.Text = "Unidad :"
        Me.lblUnidadPeso.Values.ExtraText = ""
        Me.lblUnidadPeso.Values.Image = Nothing
        Me.lblUnidadPeso.Values.Text = "Unidad :"
        '
        'txtUnidadCantidad
        '
        Me.txtUnidadCantidad.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaListarUnidadCantidad})
        Me.txtUnidadCantidad.Location = New System.Drawing.Point(271, 91)
        Me.txtUnidadCantidad.MaxLength = 10
        Me.txtUnidadCantidad.Name = "txtUnidadCantidad"
        Me.txtUnidadCantidad.Size = New System.Drawing.Size(100, 22)
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
        Me.lblUnidadCantidad.Location = New System.Drawing.Point(213, 94)
        Me.lblUnidadCantidad.Name = "lblUnidadCantidad"
        Me.lblUnidadCantidad.Size = New System.Drawing.Size(56, 20)
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
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgContratosVigentes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
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
        Me.dgContratosVigentes.Size = New System.Drawing.Size(599, 71)
        Me.dgContratosVigentes.StandardTab = True
        Me.dgContratosVigentes.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgContratosVigentes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgContratosVigentes.TabIndex = 53
        '
        'M_NCNTR
        '
        Me.M_NCNTR.DataPropertyName = "NCNTR"
        Me.M_NCNTR.HeaderText = "Contrato"
        Me.M_NCNTR.Name = "M_NCNTR"
        Me.M_NCNTR.ReadOnly = True
        Me.M_NCNTR.Width = 83
        '
        'M_CTPDP3
        '
        Me.M_CTPDP3.DataPropertyName = "CTPDP3"
        Me.M_CTPDP3.HeaderText = "Depósito"
        Me.M_CTPDP3.Name = "M_CTPDP3"
        Me.M_CTPDP3.ReadOnly = True
        Me.M_CTPDP3.Visible = False
        Me.M_CTPDP3.Width = 78
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
        Me.M_CTPPR1.Width = 85
        '
        'M_CUNCN3
        '
        Me.M_CUNCN3.DataPropertyName = "CUNCN3"
        Me.M_CUNCN3.HeaderText = "Unidad Cantidad"
        Me.M_CUNCN3.Name = "M_CUNCN3"
        Me.M_CUNCN3.ReadOnly = True
        Me.M_CUNCN3.Width = 125
        '
        'M_CUNPS3
        '
        Me.M_CUNPS3.DataPropertyName = "CUNPS3"
        Me.M_CUNPS3.HeaderText = "Unidad Peso"
        Me.M_CUNPS3.Name = "M_CUNPS3"
        Me.M_CUNPS3.ReadOnly = True
        Me.M_CUNPS3.Width = 102
        '
        'M_CUNVL3
        '
        Me.M_CUNVL3.DataPropertyName = "CUNVL3"
        Me.M_CUNVL3.HeaderText = "Unidad Valor"
        Me.M_CUNVL3.Name = "M_CUNVL3"
        Me.M_CUNVL3.ReadOnly = True
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
        'hgParametrosModificarOS
        '
        Me.hgParametrosModificarOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgParametrosModificarOS.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.hgParametrosModificarOS.HeaderVisibleSecondary = False
        Me.hgParametrosModificarOS.Location = New System.Drawing.Point(0, 156)
        Me.hgParametrosModificarOS.Name = "hgParametrosModificarOS"
        '
        'hgParametrosModificarOS.Panel
        '
        Me.hgParametrosModificarOS.Panel.AutoScroll = True
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.lblOrdenServicio)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel12)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.cbxControlDespacho_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.btnCancelarModificarOS)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.btnActualizarModificarOS)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.cbxControlLote_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtValor_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtUnidadValor_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel7)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtPeso_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel8)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtCantidad_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel9)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtUnidadPeso_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel10)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtUnidadCantidad_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel11)
        Me.hgParametrosModificarOS.Size = New System.Drawing.Size(601, 20)
        Me.hgParametrosModificarOS.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.hgParametrosModificarOS.TabIndex = 51
        Me.hgParametrosModificarOS.Text = "Modificar O/S"
        Me.hgParametrosModificarOS.ValuesPrimary.Description = ""
        Me.hgParametrosModificarOS.ValuesPrimary.Heading = "Modificar O/S"
        Me.hgParametrosModificarOS.ValuesPrimary.Image = Nothing
        Me.hgParametrosModificarOS.ValuesSecondary.Description = ""
        Me.hgParametrosModificarOS.ValuesSecondary.Heading = "Description"
        Me.hgParametrosModificarOS.ValuesSecondary.Image = Nothing
        Me.hgParametrosModificarOS.Visible = False
        '
        'lblOrdenServicio
        '
        Me.lblOrdenServicio.Location = New System.Drawing.Point(275, 173)
        Me.lblOrdenServicio.Name = "lblOrdenServicio"
        Me.lblOrdenServicio.Size = New System.Drawing.Size(16, 20)
        Me.lblOrdenServicio.TabIndex = 89
        Me.lblOrdenServicio.Text = "?"
        Me.lblOrdenServicio.Values.ExtraText = ""
        Me.lblOrdenServicio.Values.Image = Nothing
        Me.lblOrdenServicio.Values.Text = "?"
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(40, 173)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(244, 20)
        Me.KryptonLabel12.TabIndex = 88
        Me.KryptonLabel12.Text = "Se esta Modificando los Valores de la O/S :"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Se esta Modificando los Valores de la O/S :"
        '
        'cbxControlDespacho_M
        '
        Me.cbxControlDespacho_M.Enabled = False
        Me.cbxControlDespacho_M.FormattingEnabled = True
        Me.cbxControlDespacho_M.Items.AddRange(New Object() {"C", "P"})
        Me.cbxControlDespacho_M.Location = New System.Drawing.Point(108, 96)
        Me.cbxControlDespacho_M.Name = "cbxControlDespacho_M"
        Me.cbxControlDespacho_M.Size = New System.Drawing.Size(42, 21)
        Me.cbxControlDespacho_M.TabIndex = 84
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(40, 101)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel2.TabIndex = 83
        Me.KryptonLabel2.Text = "Unid. Desp:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Unid. Desp:"
        '
        'btnCancelarModificarOS
        '
        Me.btnCancelarModificarOS.Location = New System.Drawing.Point(271, 133)
        Me.btnCancelarModificarOS.Name = "btnCancelarModificarOS"
        Me.btnCancelarModificarOS.Size = New System.Drawing.Size(100, 25)
        Me.btnCancelarModificarOS.TabIndex = 87
        Me.btnCancelarModificarOS.Text = "Cancelar"
        Me.btnCancelarModificarOS.Values.ExtraText = ""
        Me.btnCancelarModificarOS.Values.Image = CType(resources.GetObject("btnCancelarModificarOS.Values.Image"), System.Drawing.Image)
        Me.btnCancelarModificarOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelarModificarOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelarModificarOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelarModificarOS.Values.Text = "Cancelar"
        '
        'btnActualizarModificarOS
        '
        Me.btnActualizarModificarOS.Location = New System.Drawing.Point(153, 133)
        Me.btnActualizarModificarOS.Name = "btnActualizarModificarOS"
        Me.btnActualizarModificarOS.Size = New System.Drawing.Size(100, 25)
        Me.btnActualizarModificarOS.TabIndex = 86
        Me.btnActualizarModificarOS.Text = "Actualizar"
        Me.btnActualizarModificarOS.Values.ExtraText = ""
        Me.btnActualizarModificarOS.Values.Image = CType(resources.GetObject("btnActualizarModificarOS.Values.Image"), System.Drawing.Image)
        Me.btnActualizarModificarOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizarModificarOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizarModificarOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizarModificarOS.Values.Text = "Actualizar"
        '
        'cbxControlLote_M
        '
        Me.cbxControlLote_M.Checked = False
        Me.cbxControlLote_M.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.cbxControlLote_M.Enabled = False
        Me.cbxControlLote_M.Location = New System.Drawing.Point(220, 101)
        Me.cbxControlLote_M.Name = "cbxControlLote_M"
        Me.cbxControlLote_M.Size = New System.Drawing.Size(113, 20)
        Me.cbxControlLote_M.TabIndex = 85
        Me.cbxControlLote_M.Text = "Control por Lote"
        Me.cbxControlLote_M.Values.ExtraText = ""
        Me.cbxControlLote_M.Values.Image = Nothing
        Me.cbxControlLote_M.Values.Text = "Control por Lote"
        '
        'txtValor_M
        '
        Me.TypeValidator.SetDecimales(Me.txtValor_M, 2)
        Me.txtValor_M.Location = New System.Drawing.Point(108, 71)
        Me.txtValor_M.Name = "txtValor_M"
        Me.txtValor_M.Size = New System.Drawing.Size(88, 22)
        Me.txtValor_M.TabIndex = 80
        Me.txtValor_M.Text = "0.00"
        Me.txtValor_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtValor_M, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(40, 74)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(45, 20)
        Me.KryptonLabel4.TabIndex = 79
        Me.KryptonLabel4.Text = "Valor : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Valor : "
        '
        'txtUnidadValor_M
        '
        Me.txtUnidadValor_M.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny2})
        Me.txtUnidadValor_M.Enabled = False
        Me.txtUnidadValor_M.Location = New System.Drawing.Point(271, 71)
        Me.txtUnidadValor_M.MaxLength = 10
        Me.txtUnidadValor_M.Name = "txtUnidadValor_M"
        Me.txtUnidadValor_M.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidadValor_M.TabIndex = 82
        Me.txtUnidadValor_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtUnidadValor_M, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
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
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(213, 74)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel7.TabIndex = 81
        Me.KryptonLabel7.Text = "Unidad :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Unidad :"
        '
        'txtPeso_M
        '
        Me.TypeValidator.SetDecimales(Me.txtPeso_M, 2)
        Me.txtPeso_M.Location = New System.Drawing.Point(108, 46)
        Me.txtPeso_M.Name = "txtPeso_M"
        Me.txtPeso_M.Size = New System.Drawing.Size(88, 22)
        Me.txtPeso_M.TabIndex = 76
        Me.txtPeso_M.Text = "0.00"
        Me.txtPeso_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPeso_M, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(40, 49)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(42, 20)
        Me.KryptonLabel8.TabIndex = 75
        Me.KryptonLabel8.Text = "Peso : "
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Peso : "
        '
        'txtCantidad_M
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidad_M, 2)
        Me.txtCantidad_M.Location = New System.Drawing.Point(108, 21)
        Me.txtCantidad_M.Name = "txtCantidad_M"
        Me.txtCantidad_M.Size = New System.Drawing.Size(88, 22)
        Me.txtCantidad_M.TabIndex = 72
        Me.txtCantidad_M.Text = "0.00"
        Me.txtCantidad_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidad_M, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(40, 24)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel9.TabIndex = 71
        Me.KryptonLabel9.Text = "Cantidad : "
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Cantidad : "
        '
        'txtUnidadPeso_M
        '
        Me.txtUnidadPeso_M.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny3})
        Me.txtUnidadPeso_M.Enabled = False
        Me.txtUnidadPeso_M.Location = New System.Drawing.Point(271, 46)
        Me.txtUnidadPeso_M.MaxLength = 10
        Me.txtUnidadPeso_M.Name = "txtUnidadPeso_M"
        Me.txtUnidadPeso_M.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidadPeso_M.TabIndex = 78
        Me.txtUnidadPeso_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtUnidadPeso_M, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
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
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(213, 49)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel10.TabIndex = 77
        Me.KryptonLabel10.Text = "Unidad :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Unidad :"
        '
        'txtUnidadCantidad_M
        '
        Me.txtUnidadCantidad_M.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny4})
        Me.txtUnidadCantidad_M.Enabled = False
        Me.txtUnidadCantidad_M.Location = New System.Drawing.Point(271, 21)
        Me.txtUnidadCantidad_M.MaxLength = 10
        Me.txtUnidadCantidad_M.Name = "txtUnidadCantidad_M"
        Me.txtUnidadCantidad_M.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidadCantidad_M.TabIndex = 74
        Me.txtUnidadCantidad_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtUnidadCantidad_M, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
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
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(213, 24)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel11.TabIndex = 73
        Me.KryptonLabel11.Text = "Unidad : "
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Unidad : "
        '
        'hgMercaderiaSeleccionada
        '
        Me.hgMercaderiaSeleccionada.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaProcesarGuia, Me.bsaProcesarRecepcion, Me.bsaEliminarItem})
        Me.hgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgMercaderiaSeleccionada.HeaderVisibleSecondary = False
        Me.hgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 325)
        Me.hgMercaderiaSeleccionada.Name = "hgMercaderiaSeleccionada"
        '
        'hgMercaderiaSeleccionada.Panel
        '
        Me.hgMercaderiaSeleccionada.Panel.Controls.Add(Me.dgMercaderiaSeleccionada)
        Me.hgMercaderiaSeleccionada.Size = New System.Drawing.Size(1204, 260)
        Me.hgMercaderiaSeleccionada.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgMercaderiaSeleccionada.TabIndex = 51
        Me.hgMercaderiaSeleccionada.Text = "Mercadería Seleccionada"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Heading = "Mercadería Seleccionada"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Image = Nothing
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Heading = "Description"
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Image = Nothing
        Me.hgMercaderiaSeleccionada.Visible = False
        '
        'bsaProcesarGuia
        '
        Me.bsaProcesarGuia.ExtraText = ""
        Me.bsaProcesarGuia.Image = Nothing
        Me.bsaProcesarGuia.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaProcesarGuia.Text = "Procesar Guía"
        Me.bsaProcesarGuia.ToolTipImage = Nothing
        Me.bsaProcesarGuia.UniqueName = "5C97341EF07340AE5C97341EF07340AE"
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
        'bsaEliminarItem
        '
        Me.bsaEliminarItem.ExtraText = ""
        Me.bsaEliminarItem.Image = CType(resources.GetObject("bsaEliminarItem.Image"), System.Drawing.Image)
        Me.bsaEliminarItem.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaEliminarItem.Text = "Eliminar Item"
        Me.bsaEliminarItem.ToolTipImage = Nothing
        Me.bsaEliminarItem.UniqueName = "F793EF8F68DA4BD3F793EF8F68DA4BD3"
        '
        'dgMercaderiaSeleccionada
        '
        Me.dgMercaderiaSeleccionada.AllowUserToAddRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToDeleteRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeColumns = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeRows = False
        Me.dgMercaderiaSeleccionada.AutoGenerateColumns = False
        Me.dgMercaderiaSeleccionada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaSeleccionada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_CMRCLR, Me.S_TMRCD2, Me.S_CMRCD, Me.S_NORDSR, Me.S_NCNTR, Me.S_NCRCTC, Me.S_NAUTR, Me.S_CUNCNT, Me.S_CUNPST, Me.S_CUNVLT, Me.S_NORCCL, Me.S_NGUICL, Me.S_NRUCLL, Me.S_STPING, Me.S_CTPALM, Me.S_TALMC, Me.S_CALMC, Me.S_TCMPAL, Me.S_CZNALM, Me.S_TCMZNA, Me.S_QTRMC, Me.S_QTRMP, Me.S_QDSVGN, Me.S_CCNTD, Me.S_CTPOCN, Me.S_FUNDS2, Me.S_CTPDPS, Me.S_TOBSRV})
        Me.dgMercaderiaSeleccionada.DataMember = "dtMercaderiaSeleccionadas"
        Me.dgMercaderiaSeleccionada.DataSource = Me.dstMercaderia
        Me.dgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderiaSeleccionada.MultiSelect = False
        Me.dgMercaderiaSeleccionada.Name = "dgMercaderiaSeleccionada"
        Me.dgMercaderiaSeleccionada.ReadOnly = True
        Me.dgMercaderiaSeleccionada.RowHeadersWidth = 20
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaSeleccionada.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgMercaderiaSeleccionada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaSeleccionada.Size = New System.Drawing.Size(1202, 229)
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
        Me.S_CMRCLR.Width = 95
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
        Me.S_CMRCD.Width = 95
        '
        'S_NORDSR
        '
        Me.S_NORDSR.DataPropertyName = "NORDSR"
        Me.S_NORDSR.HeaderText = "Orden Servicio"
        Me.S_NORDSR.Name = "S_NORDSR"
        Me.S_NORDSR.ReadOnly = True
        Me.S_NORDSR.Width = 113
        '
        'S_NCNTR
        '
        Me.S_NCNTR.DataPropertyName = "NCNTR"
        Me.S_NCNTR.HeaderText = "No. Contrato"
        Me.S_NCNTR.Name = "S_NCNTR"
        Me.S_NCNTR.ReadOnly = True
        Me.S_NCNTR.Width = 105
        '
        'S_NCRCTC
        '
        Me.S_NCRCTC.DataPropertyName = "NCRCTC"
        Me.S_NCRCTC.HeaderText = "Correlativo"
        Me.S_NCRCTC.Name = "S_NCRCTC"
        Me.S_NCRCTC.ReadOnly = True
        Me.S_NCRCTC.Width = 94
        '
        'S_NAUTR
        '
        Me.S_NAUTR.DataPropertyName = "NAUTR"
        Me.S_NAUTR.HeaderText = "No Autorización"
        Me.S_NAUTR.Name = "S_NAUTR"
        Me.S_NAUTR.ReadOnly = True
        Me.S_NAUTR.Width = 122
        '
        'S_CUNCNT
        '
        Me.S_CUNCNT.DataPropertyName = "CUNCNT"
        Me.S_CUNCNT.HeaderText = "U. Cantidad"
        Me.S_CUNCNT.Name = "S_CUNCNT"
        Me.S_CUNCNT.ReadOnly = True
        Me.S_CUNCNT.Width = 98
        '
        'S_CUNPST
        '
        Me.S_CUNPST.DataPropertyName = "CUNPST"
        Me.S_CUNPST.HeaderText = "U. Peso"
        Me.S_CUNPST.Name = "S_CUNPST"
        Me.S_CUNPST.ReadOnly = True
        Me.S_CUNPST.Width = 75
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
        Me.S_NORCCL.Width = 77
        '
        'S_NGUICL
        '
        Me.S_NGUICL.DataPropertyName = "NGUICL"
        Me.S_NGUICL.HeaderText = "No Guía Cliente"
        Me.S_NGUICL.Name = "S_NGUICL"
        Me.S_NGUICL.ReadOnly = True
        Me.S_NGUICL.Width = 119
        '
        'S_NRUCLL
        '
        Me.S_NRUCLL.DataPropertyName = "NRUCLL"
        Me.S_NRUCLL.HeaderText = "No RUC Cliente"
        Me.S_NRUCLL.Name = "S_NRUCLL"
        Me.S_NRUCLL.ReadOnly = True
        Me.S_NRUCLL.Width = 118
        '
        'S_STPING
        '
        Me.S_STPING.DataPropertyName = "STPING"
        Me.S_STPING.HeaderText = "Tipo Mov."
        Me.S_STPING.Name = "S_STPING"
        Me.S_STPING.ReadOnly = True
        Me.S_STPING.Width = 90
        '
        'S_CTPALM
        '
        Me.S_CTPALM.DataPropertyName = "CTPALM"
        Me.S_CTPALM.HeaderText = "Tipo Almacén"
        Me.S_CTPALM.Name = "S_CTPALM"
        Me.S_CTPALM.ReadOnly = True
        Me.S_CTPALM.Width = 110
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
        Me.S_CALMC.Width = 83
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
        Me.S_CZNALM.Width = 63
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
        Me.S_QTRMC.Width = 84
        '
        'S_QTRMP
        '
        Me.S_QTRMP.DataPropertyName = "QTRMP"
        Me.S_QTRMP.HeaderText = "Peso"
        Me.S_QTRMP.Name = "S_QTRMP"
        Me.S_QTRMP.ReadOnly = True
        Me.S_QTRMP.Width = 61
        '
        'S_QDSVGN
        '
        Me.S_QDSVGN.DataPropertyName = "QDSVGN"
        Me.S_QDSVGN.HeaderText = "No Días Vigencia"
        Me.S_QDSVGN.Name = "S_QDSVGN"
        Me.S_QDSVGN.ReadOnly = True
        Me.S_QDSVGN.Width = 125
        '
        'S_CCNTD
        '
        Me.S_CCNTD.DataPropertyName = "CCNTD"
        Me.S_CCNTD.HeaderText = "Contenedor"
        Me.S_CCNTD.Name = "S_CCNTD"
        Me.S_CCNTD.ReadOnly = True
        Me.S_CCNTD.Width = 99
        '
        'S_CTPOCN
        '
        Me.S_CTPOCN.DataPropertyName = "CTPOCN"
        Me.S_CTPOCN.FalseValue = "FALSE"
        Me.S_CTPOCN.HeaderText = "Desglosa"
        Me.S_CTPOCN.Name = "S_CTPOCN"
        Me.S_CTPOCN.ReadOnly = True
        Me.S_CTPOCN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.S_CTPOCN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.S_CTPOCN.TrueValue = "TRUE"
        Me.S_CTPOCN.Width = 83
        '
        'S_FUNDS2
        '
        Me.S_FUNDS2.DataPropertyName = "FUNDS2"
        Me.S_FUNDS2.HeaderText = "U. Despacho"
        Me.S_FUNDS2.Name = "S_FUNDS2"
        Me.S_FUNDS2.ReadOnly = True
        Me.S_FUNDS2.Width = 102
        '
        'S_CTPDPS
        '
        Me.S_CTPDPS.DataPropertyName = "CTPDPS"
        Me.S_CTPDPS.HeaderText = "Tipo Depósito"
        Me.S_CTPDPS.Name = "S_CTPDPS"
        Me.S_CTPDPS.ReadOnly = True
        Me.S_CTPDPS.Width = 110
        '
        'S_TOBSRV
        '
        Me.S_TOBSRV.DataPropertyName = "TOBSRV"
        Me.S_TOBSRV.HeaderText = "Observaciones"
        Me.S_TOBSRV.Name = "S_TOBSRV"
        Me.S_TOBSRV.ReadOnly = True
        Me.S_TOBSRV.Width = 113
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
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel13)
        Me.hgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
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
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(1204, 118)
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
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(86, 12)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(278, 22)
        Me.txtCliente.TabIndex = 3
        '
        'grpLeyenda
        '
        Me.grpLeyenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLeyenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLeyenda.Controls.Add(Me.lblDetalleOpcional)
        Me.grpLeyenda.Controls.Add(Me.lblDetalleObligatorio)
        Me.grpLeyenda.Controls.Add(Me.lblOpcional)
        Me.grpLeyenda.Controls.Add(Me.lblObligatorio)
        Me.grpLeyenda.Location = New System.Drawing.Point(1424, 12)
        Me.grpLeyenda.Name = "grpLeyenda"
        Me.grpLeyenda.Size = New System.Drawing.Size(110, 70)
        Me.grpLeyenda.TabIndex = 16
        Me.grpLeyenda.TabStop = False
        Me.grpLeyenda.Text = "Leyenda"
        Me.grpLeyenda.Visible = False
        '
        'lblDetalleOpcional
        '
        Me.lblDetalleOpcional.Location = New System.Drawing.Point(37, 44)
        Me.lblDetalleOpcional.Name = "lblDetalleOpcional"
        Me.lblDetalleOpcional.Size = New System.Drawing.Size(59, 20)
        Me.lblDetalleOpcional.TabIndex = 20
        Me.lblDetalleOpcional.Text = "Opcional"
        Me.lblDetalleOpcional.Values.ExtraText = ""
        Me.lblDetalleOpcional.Values.Image = Nothing
        Me.lblDetalleOpcional.Values.Text = "Opcional"
        '
        'lblDetalleObligatorio
        '
        Me.lblDetalleObligatorio.Location = New System.Drawing.Point(37, 22)
        Me.lblDetalleObligatorio.Name = "lblDetalleObligatorio"
        Me.lblDetalleObligatorio.Size = New System.Drawing.Size(73, 20)
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
        Me.lblOpcional.Location = New System.Drawing.Point(12, 45)
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
        Me.lblObligatorio.Location = New System.Drawing.Point(12, 22)
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
        Me.cbxPublicarWEB.ItemHeight = 15
        Me.cbxPublicarWEB.Items.AddRange(New Object() {"", "SI", "NO"})
        Me.cbxPublicarWEB.Location = New System.Drawing.Point(869, 9)
        Me.cbxPublicarWEB.Name = "cbxPublicarWEB"
        Me.cbxPublicarWEB.Size = New System.Drawing.Size(82, 23)
        Me.cbxPublicarWEB.TabIndex = 15
        '
        'lblPublicarWEB
        '
        Me.lblPublicarWEB.Location = New System.Drawing.Point(822, 12)
        Me.lblPublicarWEB.Name = "lblPublicarWEB"
        Me.lblPublicarWEB.Size = New System.Drawing.Size(41, 20)
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
        Me.txtFamilia.Location = New System.Drawing.Point(469, 34)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(278, 22)
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
        Me.txtGrupo.Location = New System.Drawing.Point(86, 61)
        Me.txtGrupo.MaxLength = 30
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(278, 22)
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
        Me.KryptonLabel6.Location = New System.Drawing.Point(7, 65)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(51, 20)
        Me.KryptonLabel6.TabIndex = 6
        Me.KryptonLabel6.Text = "Grupo : "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Grupo : "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(409, 37)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(55, 20)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Familia : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Familia : "
        '
        'lblFechaInventario
        '
        Me.lblFechaInventario.Location = New System.Drawing.Point(558, 62)
        Me.lblFechaInventario.Name = "lblFechaInventario"
        Me.lblFechaInventario.Size = New System.Drawing.Size(106, 20)
        Me.lblFechaInventario.TabIndex = 12
        Me.lblFechaInventario.Text = "Fecha Inventario : "
        Me.lblFechaInventario.Values.ExtraText = ""
        Me.lblFechaInventario.Values.Image = Nothing
        Me.lblFechaInventario.Values.Text = "Fecha Inventario : "
        '
        'txtFechaInventario
        '
        Me.txtFechaInventario.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaInventario.Location = New System.Drawing.Point(665, 59)
        Me.txtFechaInventario.Mask = "##/##/####"
        Me.txtFechaInventario.Name = "txtFechaInventario"
        Me.txtFechaInventario.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaInventario.Size = New System.Drawing.Size(82, 22)
        Me.txtFechaInventario.TabIndex = 13
        Me.txtFechaInventario.Text = "  /  /"
        '
        'lblFechaVencimiento
        '
        Me.lblFechaVencimiento.Location = New System.Drawing.Point(385, 62)
        Me.lblFechaVencimiento.Name = "lblFechaVencimiento"
        Me.lblFechaVencimiento.Size = New System.Drawing.Size(79, 20)
        Me.lblFechaVencimiento.TabIndex = 10
        Me.lblFechaVencimiento.Text = "Fecha Vcto. : "
        Me.lblFechaVencimiento.Values.ExtraText = ""
        Me.lblFechaVencimiento.Values.Image = Nothing
        Me.lblFechaVencimiento.Values.Text = "Fecha Vcto. : "
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(469, 59)
        Me.txtFechaVencimiento.Mask = "##/##/####"
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(82, 22)
        Me.txtFechaVencimiento.TabIndex = 11
        Me.txtFechaVencimiento.Text = "  /  /"
        '
        'txtMercaderia
        '
        Me.txtMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtMercaderia, True)
        Me.txtMercaderia.Location = New System.Drawing.Point(86, 36)
        Me.txtMercaderia.Name = "txtMercaderia"
        Me.txtMercaderia.Size = New System.Drawing.Size(278, 22)
        Me.txtMercaderia.TabIndex = 9
        Me.TypeValidator.SetTypes(Me.txtMercaderia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblMercadaeria
        '
        Me.lblMercadaeria.Location = New System.Drawing.Point(7, 39)
        Me.lblMercadaeria.Name = "lblMercadaeria"
        Me.lblMercadaeria.Size = New System.Drawing.Size(78, 20)
        Me.lblMercadaeria.TabIndex = 8
        Me.lblMercadaeria.Text = "Mercadería : "
        Me.lblMercadaeria.Values.ExtraText = ""
        Me.lblMercadaeria.Values.Image = Nothing
        Me.lblMercadaeria.Values.Text = "Mercadería : "
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(1123, 13)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 69)
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
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(7, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(824, 52)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 30)
        Me.KryptonLabel5.TabIndex = 35
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(413, 15)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel13.TabIndex = 53
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
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(469, 11)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta1
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(154, 23)
        Me.UcPLanta_Cmb011.TabIndex = 52
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'frmRecepcionSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 585)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecepcionSDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepción"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.grpListadoMercaderia.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpListadoMercaderia.Panel.ResumeLayout(False)
        CType(Me.grpListadoMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpListadoMercaderia.ResumeLayout(False)
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.hgParametrosCrearOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgParametrosCrearOS.Panel.ResumeLayout(False)
        Me.hgParametrosCrearOS.Panel.PerformLayout()
        CType(Me.hgParametrosCrearOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgParametrosCrearOS.ResumeLayout(False)
        CType(Me.dgContratosVigentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgParametrosModificarOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgParametrosModificarOS.Panel.ResumeLayout(False)
        Me.hgParametrosModificarOS.Panel.PerformLayout()
        CType(Me.hgParametrosModificarOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgParametrosModificarOS.ResumeLayout(False)
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
    Friend WithEvents dgMercaderias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents hgParametrosCrearOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dstContratos As System.Data.DataSet
    Friend WithEvents dtContratos As System.Data.DataTable
    Friend WithEvents NCNTR As System.Data.DataColumn
    Friend WithEvents CTPDP3 As System.Data.DataColumn
    Friend WithEvents TABDPS As System.Data.DataColumn
    Friend WithEvents CTPPR1 As System.Data.DataColumn
    Friend WithEvents CUNCN3 As System.Data.DataColumn
    Friend WithEvents CUNPS3 As System.Data.DataColumn
    Friend WithEvents CUNVL3 As System.Data.DataColumn
    Friend WithEvents dgContratosVigentes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents cbxControlLote As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents btnCancelarCrearOS As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnProcesarCrearOS As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cbxUnidadDespacho As System.Windows.Forms.ComboBox
    Friend WithEvents lblUnidadDespacho As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents OQSLMV As System.Data.DataColumn
    Friend WithEvents OCUNVL5 As System.Data.DataColumn
    Friend WithEvents OFUNDS2 As System.Data.DataColumn
    Friend WithEvents hgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents hgOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaCrearOS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaOcultar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaAgregaMercaderiaOS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaProcesarRecepcion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents txtCliente As RANSA.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents bsaProcesarGuia As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaModificarOS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents hgParametrosModificarOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cbxControlDespacho_M As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelarModificarOS As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnActualizarModificarOS As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cbxControlLote_M As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtValor_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadValor_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ButtonSpecAny2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPeso_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCantidad_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadPeso_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ButtonSpecAny3 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadCantidad_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ButtonSpecAny4 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents OFUNCTL As System.Data.DataColumn
    Friend WithEvents lblOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents OQMRCD1 As System.Data.DataColumn
    Friend WithEvents OQPSMR1 As System.Data.DataColumn
    Friend WithEvents OQVLMR1 As System.Data.DataColumn
    Friend WithEvents dgListaOrdenesServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPDP3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TABDPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPPR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNCN3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNPS3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNVL3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpListadoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnRealizarRecepcion As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMercaderia As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtBuscarMercaderia As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tssSeparador02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblBuscar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tssSeparador01 As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents O_FUNCTL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_QMRCD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_QPSMR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_QVLMR1 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents S_CTPOCN As System.Windows.Forms.DataGridViewCheckBoxColumn
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
    Friend WithEvents M_TFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsbTransferencias As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssSeparador04 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
End Class
