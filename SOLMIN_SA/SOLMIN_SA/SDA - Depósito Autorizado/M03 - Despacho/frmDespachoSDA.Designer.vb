<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespachoSDA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDespachoSDA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaRealizarDespacho = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgMercaderias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NSLCSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NGUICL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCMPAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CSRVC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCMPMR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FUNDS3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstMercaderia = New System.Data.DataSet
        Me.dtOSPendiente = New System.Data.DataTable
        Me.MNORDSR = New System.Data.DataColumn
        Me.MNSLCSR = New System.Data.DataColumn
        Me.MNGUICL = New System.Data.DataColumn
        Me.MNPLCCM = New System.Data.DataColumn
        Me.MCTPALM = New System.Data.DataColumn
        Me.MCALMC = New System.Data.DataColumn
        Me.MCSRVC = New System.Data.DataColumn
        Me.MTCMPMR = New System.Data.DataColumn
        Me.MTALMC = New System.Data.DataColumn
        Me.MTCMPAL = New System.Data.DataColumn
        Me.MCUNCN6 = New System.Data.DataColumn
        Me.MCUNPS6 = New System.Data.DataColumn
        Me.MCUNVL6 = New System.Data.DataColumn
        Me.MFUNDS3 = New System.Data.DataColumn
        Me.dtMercaderiaSeleccionadas = New System.Data.DataTable
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
        Me.hgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaAgregarMercaderia = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaProcesarDespacho = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORDSRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSLCSRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUICLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCCMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CSRVCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPMRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TALMCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNCN6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNPS6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNVL6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FUNDS3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.grpLeyenda = New System.Windows.Forms.GroupBox
        Me.lblDetalleOpcional = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDetalleObligatorio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOpcional = New System.Windows.Forms.Label
        Me.lblObligatorio = New System.Windows.Forms.Label
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        Me.dstContratos = New System.Data.DataSet
        Me.dtContratos = New System.Data.DataTable
        Me.NCNTR = New System.Data.DataColumn
        Me.CTPDP3 = New System.Data.DataColumn
        Me.TABDPS = New System.Data.DataColumn
        Me.CTPPR1 = New System.Data.DataColumn
        Me.CUNCN3 = New System.Data.DataColumn
        Me.CUNPS3 = New System.Data.DataColumn
        Me.CUNVL3 = New System.Data.DataColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderia.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgMercaderia.Panel.SuspendLayout()
        Me.hgMercaderia.SuspendLayout()
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOSPendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgMercaderia)
        Me.KryptonPanel.Controls.Add(Me.hgMercaderiaSeleccionada)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(986, 585)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgMercaderia
        '
        Me.hgMercaderia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaRealizarDespacho})
        Me.hgMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgMercaderia.HeaderVisibleSecondary = False
        Me.hgMercaderia.Location = New System.Drawing.Point(0, 122)
        Me.hgMercaderia.Name = "hgMercaderia"
        '
        'hgMercaderia.Panel
        '
        Me.hgMercaderia.Panel.Controls.Add(Me.dgMercaderias)
        Me.hgMercaderia.Size = New System.Drawing.Size(986, 237)
        Me.hgMercaderia.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgMercaderia.TabIndex = 53
        Me.hgMercaderia.Text = "Listado de Mercaderías"
        Me.hgMercaderia.ValuesPrimary.Description = ""
        Me.hgMercaderia.ValuesPrimary.Heading = "Listado de Mercaderías"
        Me.hgMercaderia.ValuesPrimary.Image = CType(resources.GetObject("hgMercaderia.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgMercaderia.ValuesSecondary.Description = ""
        Me.hgMercaderia.ValuesSecondary.Heading = "Description"
        Me.hgMercaderia.ValuesSecondary.Image = Nothing
        '
        'bsaRealizarDespacho
        '
        Me.bsaRealizarDespacho.ExtraText = ""
        Me.bsaRealizarDespacho.Image = CType(resources.GetObject("bsaRealizarDespacho.Image"), System.Drawing.Image)
        Me.bsaRealizarDespacho.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaRealizarDespacho.Text = "Realizar Despacho"
        Me.bsaRealizarDespacho.ToolTipImage = Nothing
        Me.bsaRealizarDespacho.UniqueName = "E32F168AB9E044FBE32F168AB9E044FB"
        '
        'dgMercaderias
        '
        Me.dgMercaderias.AllowUserToAddRows = False
        Me.dgMercaderias.AllowUserToDeleteRows = False
        Me.dgMercaderias.AllowUserToResizeColumns = False
        Me.dgMercaderias.AllowUserToResizeRows = False
        Me.dgMercaderias.AutoGenerateColumns = False
        Me.dgMercaderias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NORDSR, Me.M_NSLCSR, Me.M_NGUICL, Me.M_NPLCCM, Me.M_CTPALM, Me.M_TALMC, Me.M_CALMC, Me.M_TCMPAL, Me.M_CSRVC, Me.M_TCMPMR, Me.M_FUNDS3})
        Me.dgMercaderias.DataMember = "dtOSPendiente"
        Me.dgMercaderias.DataSource = Me.dstMercaderia
        Me.dgMercaderias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderias.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderias.MultiSelect = False
        Me.dgMercaderias.Name = "dgMercaderias"
        Me.dgMercaderias.ReadOnly = True
        Me.dgMercaderias.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderias.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMercaderias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderias.Size = New System.Drawing.Size(984, 208)
        Me.dgMercaderias.StandardTab = True
        Me.dgMercaderias.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderias.TabIndex = 23
        '
        'M_NORDSR
        '
        Me.M_NORDSR.DataPropertyName = "NORDSR"
        Me.M_NORDSR.HeaderText = "Nro. O/S"
        Me.M_NORDSR.Name = "M_NORDSR"
        Me.M_NORDSR.ReadOnly = True
        Me.M_NORDSR.Width = 79
        '
        'M_NSLCSR
        '
        Me.M_NSLCSR.DataPropertyName = "NSLCSR"
        Me.M_NSLCSR.HeaderText = "Nro. Solic."
        Me.M_NSLCSR.Name = "M_NSLCSR"
        Me.M_NSLCSR.ReadOnly = True
        Me.M_NSLCSR.Width = 85
        '
        'M_NGUICL
        '
        Me.M_NGUICL.DataPropertyName = "NGUICL"
        Me.M_NGUICL.HeaderText = "Nro. Guía"
        Me.M_NGUICL.Name = "M_NGUICL"
        Me.M_NGUICL.ReadOnly = True
        Me.M_NGUICL.Width = 83
        '
        'M_NPLCCM
        '
        Me.M_NPLCCM.DataPropertyName = "NPLCCM"
        Me.M_NPLCCM.HeaderText = "Placa Camión"
        Me.M_NPLCCM.Name = "M_NPLCCM"
        Me.M_NPLCCM.ReadOnly = True
        Me.M_NPLCCM.Width = 101
        '
        'M_CTPALM
        '
        Me.M_CTPALM.DataPropertyName = "CTPALM"
        Me.M_CTPALM.HeaderText = "Tipo Almacén"
        Me.M_CTPALM.Name = "M_CTPALM"
        Me.M_CTPALM.ReadOnly = True
        Me.M_CTPALM.Width = 101
        '
        'M_TALMC
        '
        Me.M_TALMC.DataPropertyName = "TALMC"
        Me.M_TALMC.HeaderText = "Tipo Almacén"
        Me.M_TALMC.Name = "M_TALMC"
        Me.M_TALMC.ReadOnly = True
        Me.M_TALMC.Width = 101
        '
        'M_CALMC
        '
        Me.M_CALMC.DataPropertyName = "CALMC"
        Me.M_CALMC.HeaderText = "Almacén"
        Me.M_CALMC.Name = "M_CALMC"
        Me.M_CALMC.ReadOnly = True
        Me.M_CALMC.Width = 77
        '
        'M_TCMPAL
        '
        Me.M_TCMPAL.DataPropertyName = "TCMPAL"
        Me.M_TCMPAL.HeaderText = "Almacén"
        Me.M_TCMPAL.Name = "M_TCMPAL"
        Me.M_TCMPAL.ReadOnly = True
        Me.M_TCMPAL.Width = 77
        '
        'M_CSRVC
        '
        Me.M_CSRVC.DataPropertyName = "CSRVC"
        Me.M_CSRVC.HeaderText = "Servicio"
        Me.M_CSRVC.Name = "M_CSRVC"
        Me.M_CSRVC.ReadOnly = True
        Me.M_CSRVC.Width = 74
        '
        'M_TCMPMR
        '
        Me.M_TCMPMR.DataPropertyName = "TCMPMR"
        Me.M_TCMPMR.HeaderText = "Descripción Mercadería"
        Me.M_TCMPMR.Name = "M_TCMPMR"
        Me.M_TCMPMR.ReadOnly = True
        Me.M_TCMPMR.Width = 150
        '
        'M_FUNDS3
        '
        Me.M_FUNDS3.DataPropertyName = "FUNDS3"
        Me.M_FUNDS3.HeaderText = "Unidad Despacho"
        Me.M_FUNDS3.Name = "M_FUNDS3"
        Me.M_FUNDS3.ReadOnly = True
        Me.M_FUNDS3.Width = 122
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtOSPendiente, Me.dtMercaderiaSeleccionadas})
        '
        'dtOSPendiente
        '
        Me.dtOSPendiente.Columns.AddRange(New System.Data.DataColumn() {Me.MNORDSR, Me.MNSLCSR, Me.MNGUICL, Me.MNPLCCM, Me.MCTPALM, Me.MCALMC, Me.MCSRVC, Me.MTCMPMR, Me.MTALMC, Me.MTCMPAL, Me.MCUNCN6, Me.MCUNPS6, Me.MCUNVL6, Me.MFUNDS3})
        Me.dtOSPendiente.TableName = "dtOSPendiente"
        '
        'MNORDSR
        '
        Me.MNORDSR.ColumnName = "NORDSR"
        '
        'MNSLCSR
        '
        Me.MNSLCSR.ColumnName = "NSLCSR"
        Me.MNSLCSR.DataType = GetType(Integer)
        Me.MNSLCSR.DefaultValue = 0
        '
        'MNGUICL
        '
        Me.MNGUICL.ColumnName = "NGUICL"
        '
        'MNPLCCM
        '
        Me.MNPLCCM.ColumnName = "NPLCCM"
        '
        'MCTPALM
        '
        Me.MCTPALM.ColumnName = "CTPALM"
        '
        'MCALMC
        '
        Me.MCALMC.ColumnName = "CALMC"
        '
        'MCSRVC
        '
        Me.MCSRVC.ColumnName = "CSRVC"
        Me.MCSRVC.DataType = GetType(Integer)
        Me.MCSRVC.DefaultValue = 0
        '
        'MTCMPMR
        '
        Me.MTCMPMR.ColumnName = "TCMPMR"
        '
        'MTALMC
        '
        Me.MTALMC.ColumnName = "TALMC"
        '
        'MTCMPAL
        '
        Me.MTCMPAL.ColumnName = "TCMPAL"
        '
        'MCUNCN6
        '
        Me.MCUNCN6.ColumnName = "CUNCN6"
        '
        'MCUNPS6
        '
        Me.MCUNPS6.ColumnName = "CUNPS6"
        '
        'MCUNVL6
        '
        Me.MCUNVL6.ColumnName = "CUNVL6"
        '
        'MFUNDS3
        '
        Me.MFUNDS3.ColumnName = "FUNDS3"
        '
        'dtMercaderiaSeleccionadas
        '
        Me.dtMercaderiaSeleccionadas.Columns.AddRange(New System.Data.DataColumn() {Me.STCMPMR, Me.SNORDSR, Me.SNORCCL, Me.SNGUICL, Me.SNRUCLL, Me.SSTPING, Me.SCTPALM, Me.STALMC, Me.SCALMC, Me.STCMPAL, Me.SCZNALM, Me.STCMZNA, Me.SQTRMC, Me.SQTRMP, Me.SCCNTD, Me.SCTPOCN, Me.SFUNDS3, Me.STOBSRV})
        Me.dtMercaderiaSeleccionadas.TableName = "dtMercaderiaSeleccionadas"
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
        'hgMercaderiaSeleccionada
        '
        Me.hgMercaderiaSeleccionada.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaAgregarMercaderia, Me.bsaProcesarDespacho})
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
        'bsaAgregarMercaderia
        '
        Me.bsaAgregarMercaderia.ExtraText = ""
        Me.bsaAgregarMercaderia.Image = CType(resources.GetObject("bsaAgregarMercaderia.Image"), System.Drawing.Image)
        Me.bsaAgregarMercaderia.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaAgregarMercaderia.Text = "Agregar Mercadería"
        Me.bsaAgregarMercaderia.ToolTipImage = Nothing
        Me.bsaAgregarMercaderia.UniqueName = "D7B113084EF943AAD7B113084EF943AA"
        '
        'bsaProcesarDespacho
        '
        Me.bsaProcesarDespacho.ExtraText = ""
        Me.bsaProcesarDespacho.Image = CType(resources.GetObject("bsaProcesarDespacho.Image"), System.Drawing.Image)
        Me.bsaProcesarDespacho.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaProcesarDespacho.Text = "Procesar Despacho"
        Me.bsaProcesarDespacho.ToolTipImage = Nothing
        Me.bsaProcesarDespacho.UniqueName = "0F1839EC421141FD0F1839EC421141FD"
        '
        'dgMercaderiaSeleccionada
        '
        Me.dgMercaderiaSeleccionada.AllowUserToAddRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToDeleteRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeColumns = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeRows = False
        Me.dgMercaderiaSeleccionada.AutoGenerateColumns = False
        Me.dgMercaderiaSeleccionada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaSeleccionada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORDSRDataGridViewTextBoxColumn, Me.NSLCSRDataGridViewTextBoxColumn, Me.NGUICLDataGridViewTextBoxColumn, Me.NPLCCMDataGridViewTextBoxColumn, Me.CTPALMDataGridViewTextBoxColumn, Me.CALMCDataGridViewTextBoxColumn, Me.CSRVCDataGridViewTextBoxColumn, Me.TCMPMRDataGridViewTextBoxColumn, Me.TALMCDataGridViewTextBoxColumn, Me.TCMPALDataGridViewTextBoxColumn, Me.CUNCN6DataGridViewTextBoxColumn, Me.CUNPS6DataGridViewTextBoxColumn, Me.CUNVL6DataGridViewTextBoxColumn, Me.FUNDS3DataGridViewTextBoxColumn})
        Me.dgMercaderiaSeleccionada.DataMember = "dtOSPendiente"
        Me.dgMercaderiaSeleccionada.DataSource = Me.dstMercaderia
        Me.dgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderiaSeleccionada.MultiSelect = False
        Me.dgMercaderiaSeleccionada.Name = "dgMercaderiaSeleccionada"
        Me.dgMercaderiaSeleccionada.ReadOnly = True
        Me.dgMercaderiaSeleccionada.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaSeleccionada.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgMercaderiaSeleccionada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaSeleccionada.Size = New System.Drawing.Size(984, 197)
        Me.dgMercaderiaSeleccionada.StandardTab = True
        Me.dgMercaderiaSeleccionada.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderiaSeleccionada.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderiaSeleccionada.TabIndex = 24
        '
        'NORDSRDataGridViewTextBoxColumn
        '
        Me.NORDSRDataGridViewTextBoxColumn.DataPropertyName = "NORDSR"
        Me.NORDSRDataGridViewTextBoxColumn.HeaderText = "No O/S"
        Me.NORDSRDataGridViewTextBoxColumn.Name = "NORDSRDataGridViewTextBoxColumn"
        Me.NORDSRDataGridViewTextBoxColumn.ReadOnly = True
        Me.NORDSRDataGridViewTextBoxColumn.Width = 73
        '
        'NSLCSRDataGridViewTextBoxColumn
        '
        Me.NSLCSRDataGridViewTextBoxColumn.DataPropertyName = "NSLCSR"
        Me.NSLCSRDataGridViewTextBoxColumn.HeaderText = "No. Solic."
        Me.NSLCSRDataGridViewTextBoxColumn.Name = "NSLCSRDataGridViewTextBoxColumn"
        Me.NSLCSRDataGridViewTextBoxColumn.ReadOnly = True
        Me.NSLCSRDataGridViewTextBoxColumn.Width = 82
        '
        'NGUICLDataGridViewTextBoxColumn
        '
        Me.NGUICLDataGridViewTextBoxColumn.DataPropertyName = "NGUICL"
        Me.NGUICLDataGridViewTextBoxColumn.HeaderText = "No. Guía"
        Me.NGUICLDataGridViewTextBoxColumn.Name = "NGUICLDataGridViewTextBoxColumn"
        Me.NGUICLDataGridViewTextBoxColumn.ReadOnly = True
        Me.NGUICLDataGridViewTextBoxColumn.Width = 80
        '
        'NPLCCMDataGridViewTextBoxColumn
        '
        Me.NPLCCMDataGridViewTextBoxColumn.DataPropertyName = "NPLCCM"
        Me.NPLCCMDataGridViewTextBoxColumn.HeaderText = "Placa"
        Me.NPLCCMDataGridViewTextBoxColumn.Name = "NPLCCMDataGridViewTextBoxColumn"
        Me.NPLCCMDataGridViewTextBoxColumn.ReadOnly = True
        Me.NPLCCMDataGridViewTextBoxColumn.Width = 63
        '
        'CTPALMDataGridViewTextBoxColumn
        '
        Me.CTPALMDataGridViewTextBoxColumn.DataPropertyName = "CTPALM"
        Me.CTPALMDataGridViewTextBoxColumn.HeaderText = "Tipo Almacén"
        Me.CTPALMDataGridViewTextBoxColumn.Name = "CTPALMDataGridViewTextBoxColumn"
        Me.CTPALMDataGridViewTextBoxColumn.ReadOnly = True
        Me.CTPALMDataGridViewTextBoxColumn.Width = 101
        '
        'CALMCDataGridViewTextBoxColumn
        '
        Me.CALMCDataGridViewTextBoxColumn.DataPropertyName = "CALMC"
        Me.CALMCDataGridViewTextBoxColumn.HeaderText = "Almacén"
        Me.CALMCDataGridViewTextBoxColumn.Name = "CALMCDataGridViewTextBoxColumn"
        Me.CALMCDataGridViewTextBoxColumn.ReadOnly = True
        Me.CALMCDataGridViewTextBoxColumn.Width = 77
        '
        'CSRVCDataGridViewTextBoxColumn
        '
        Me.CSRVCDataGridViewTextBoxColumn.DataPropertyName = "CSRVC"
        Me.CSRVCDataGridViewTextBoxColumn.HeaderText = "Servicio"
        Me.CSRVCDataGridViewTextBoxColumn.Name = "CSRVCDataGridViewTextBoxColumn"
        Me.CSRVCDataGridViewTextBoxColumn.ReadOnly = True
        Me.CSRVCDataGridViewTextBoxColumn.Width = 74
        '
        'TCMPMRDataGridViewTextBoxColumn
        '
        Me.TCMPMRDataGridViewTextBoxColumn.DataPropertyName = "TCMPMR"
        Me.TCMPMRDataGridViewTextBoxColumn.HeaderText = "Mercadería"
        Me.TCMPMRDataGridViewTextBoxColumn.Name = "TCMPMRDataGridViewTextBoxColumn"
        Me.TCMPMRDataGridViewTextBoxColumn.ReadOnly = True
        Me.TCMPMRDataGridViewTextBoxColumn.Width = 91
        '
        'TALMCDataGridViewTextBoxColumn
        '
        Me.TALMCDataGridViewTextBoxColumn.DataPropertyName = "TALMC"
        Me.TALMCDataGridViewTextBoxColumn.HeaderText = "Tipo Almacén"
        Me.TALMCDataGridViewTextBoxColumn.Name = "TALMCDataGridViewTextBoxColumn"
        Me.TALMCDataGridViewTextBoxColumn.ReadOnly = True
        Me.TALMCDataGridViewTextBoxColumn.Width = 101
        '
        'TCMPALDataGridViewTextBoxColumn
        '
        Me.TCMPALDataGridViewTextBoxColumn.DataPropertyName = "TCMPAL"
        Me.TCMPALDataGridViewTextBoxColumn.HeaderText = "Almacén"
        Me.TCMPALDataGridViewTextBoxColumn.Name = "TCMPALDataGridViewTextBoxColumn"
        Me.TCMPALDataGridViewTextBoxColumn.ReadOnly = True
        Me.TCMPALDataGridViewTextBoxColumn.Width = 77
        '
        'CUNCN6DataGridViewTextBoxColumn
        '
        Me.CUNCN6DataGridViewTextBoxColumn.DataPropertyName = "CUNCN6"
        Me.CUNCN6DataGridViewTextBoxColumn.HeaderText = "Unidad Cantidad"
        Me.CUNCN6DataGridViewTextBoxColumn.Name = "CUNCN6DataGridViewTextBoxColumn"
        Me.CUNCN6DataGridViewTextBoxColumn.ReadOnly = True
        Me.CUNCN6DataGridViewTextBoxColumn.Width = 115
        '
        'CUNPS6DataGridViewTextBoxColumn
        '
        Me.CUNPS6DataGridViewTextBoxColumn.DataPropertyName = "CUNPS6"
        Me.CUNPS6DataGridViewTextBoxColumn.HeaderText = "Unidad Peso"
        Me.CUNPS6DataGridViewTextBoxColumn.Name = "CUNPS6DataGridViewTextBoxColumn"
        Me.CUNPS6DataGridViewTextBoxColumn.ReadOnly = True
        Me.CUNPS6DataGridViewTextBoxColumn.Width = 97
        '
        'CUNVL6DataGridViewTextBoxColumn
        '
        Me.CUNVL6DataGridViewTextBoxColumn.DataPropertyName = "CUNVL6"
        Me.CUNVL6DataGridViewTextBoxColumn.HeaderText = "Unidad Valor"
        Me.CUNVL6DataGridViewTextBoxColumn.Name = "CUNVL6DataGridViewTextBoxColumn"
        Me.CUNVL6DataGridViewTextBoxColumn.ReadOnly = True
        Me.CUNVL6DataGridViewTextBoxColumn.Width = 97
        '
        'FUNDS3DataGridViewTextBoxColumn
        '
        Me.FUNDS3DataGridViewTextBoxColumn.DataPropertyName = "FUNDS3"
        Me.FUNDS3DataGridViewTextBoxColumn.HeaderText = "Estado Depósito"
        Me.FUNDS3DataGridViewTextBoxColumn.Name = "FUNDS3DataGridViewTextBoxColumn"
        Me.FUNDS3DataGridViewTextBoxColumn.ReadOnly = True
        Me.FUNDS3DataGridViewTextBoxColumn.Width = 114
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
        Me.hgFiltros.Panel.Controls.Add(Me.grpLeyenda)
        Me.hgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(986, 122)
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
        Me.txtCliente.Location = New System.Drawing.Point(82, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.Size = New System.Drawing.Size(278, 19)
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
        Me.grpLeyenda.Location = New System.Drawing.Point(789, 12)
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
        Me.lblDetalleOpcional.Size = New System.Drawing.Size(55, 16)
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
        Me.lblDetalleObligatorio.Size = New System.Drawing.Size(65, 16)
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
        Me.KryptonLabel1.Location = New System.Drawing.Point(7, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(52, 16)
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
        'frmDespachoSDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 585)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDespachoSDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despacho"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.hgMercaderia.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderia.Panel.ResumeLayout(False)
        CType(Me.hgMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderia.ResumeLayout(False)
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOSPendiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtContratos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtOSPendiente As System.Data.DataTable
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents dgMercaderias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents hgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents hgMercaderia As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaRealizarDespacho As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaProcesarDespacho As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtMercaderiaSeleccionadas As System.Data.DataTable
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
    Friend WithEvents MNORDSR As System.Data.DataColumn
    Friend WithEvents MNSLCSR As System.Data.DataColumn
    Friend WithEvents MNGUICL As System.Data.DataColumn
    Friend WithEvents MNPLCCM As System.Data.DataColumn
    Friend WithEvents MCTPALM As System.Data.DataColumn
    Friend WithEvents MCALMC As System.Data.DataColumn
    Friend WithEvents MCSRVC As System.Data.DataColumn
    Friend WithEvents MTCMPMR As System.Data.DataColumn
    Friend WithEvents MTALMC As System.Data.DataColumn
    Friend WithEvents MTCMPAL As System.Data.DataColumn
    Friend WithEvents bsaAgregarMercaderia As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents M_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NSLCSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGUICL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCMPAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CSRVC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCMPMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FUNDS3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MCUNCN6 As System.Data.DataColumn
    Friend WithEvents MCUNPS6 As System.Data.DataColumn
    Friend WithEvents MCUNVL6 As System.Data.DataColumn
    Friend WithEvents MFUNDS3 As System.Data.DataColumn
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
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
End Class
