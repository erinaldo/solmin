<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWDespachoSDSA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWDespachoSDSA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgTicket = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaProcesarTicket = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
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
        Me.hgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaProcesarRecepcion = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaEliminarMercaderia = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
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
        Me.dtStockPorAlmacen = New System.Data.DataTable
        Me.DSTASEL = New System.Data.DataColumn
        Me.DNORDSR = New System.Data.DataColumn
        Me.DCTPALM = New System.Data.DataColumn
        Me.DCALMC = New System.Data.DataColumn
        Me.DCZNALM = New System.Data.DataColumn
        Me.DTCMZNA = New System.Data.DataColumn
        Me.DQSLMC2 = New System.Data.DataColumn
        Me.DCUNCN7 = New System.Data.DataColumn
        Me.DQSLMP2 = New System.Data.DataColumn
        Me.DCUNPS7 = New System.Data.DataColumn
        Me.DQDSVGN = New System.Data.DataColumn
        Me.DQAUTCN = New System.Data.DataColumn
        Me.DQAUTPS = New System.Data.DataColumn
        Me.DSTPING = New System.Data.DataColumn
        Me.DTOBSRV = New System.Data.DataColumn
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
        Me.dtAutorizaciones = New System.Data.DataTable
        Me.ANORSRA = New System.Data.DataColumn
        Me.ANCNTR = New System.Data.DataColumn
        Me.AQAUTCN = New System.Data.DataColumn
        Me.ACUNC11 = New System.Data.DataColumn
        Me.AQAUTPS = New System.Data.DataColumn
        Me.ACUNP11 = New System.Data.DataColumn
        Me.AQTTDSC = New System.Data.DataColumn
        Me.AQTTDSP = New System.Data.DataColumn
        Me.AFESTAT = New System.Data.DataColumn
        Me.AFAUTR = New System.Data.DataColumn
        Me.AFLLGSL = New System.Data.DataColumn
        Me.ANAUTR = New System.Data.DataColumn
        Me.AFUNDS2 = New System.Data.DataColumn
        Me.AQSLMC = New System.Data.DataColumn
        Me.AQSLMP = New System.Data.DataColumn
        Me.ACMRCD = New System.Data.DataColumn
        Me.dgNroTicket = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Ticket = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaAgregarMercaderia = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaAgregarTicket = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgAutorizaciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.A_NORSRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_QAUTCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_CUNC11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_QAUTPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_CUNP11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_FAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_FESTAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_QTTDSC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_QTTDSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_FLLGSL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FUNDS2_A = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QSLMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QSLMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.O_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaClienteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtAutorizacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.dtAutorizacion = New System.Data.DataSet
        Me.Autorizacion = New System.Data.DataTable
        Me.NAUTR = New System.Data.DataColumn
        Me.FAUTR = New System.Data.DataColumn
        Me.NORSRA = New System.Data.DataColumn
        Me.FESTAT = New System.Data.DataColumn
        Me.QAUTCN = New System.Data.DataColumn
        Me.QAUTPC = New System.Data.DataColumn
        Me.QAUTVL = New System.Data.DataColumn
        Me.FUNDS2 = New System.Data.DataColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgTicket.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgTicket.Panel.SuspendLayout()
        Me.hgTicket.SuspendLayout()
        CType(Me.dgticket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgMercaderiaSeleccionada.Panel.SuspendLayout()
        Me.hgMercaderiaSeleccionada.SuspendLayout()
        CType(Me.dgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStockPorAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAutorizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgNroTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.dgAutorizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtAutorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Autorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgTicket)
        Me.KryptonPanel.Controls.Add(Me.hgMercaderiaSeleccionada)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(893, 669)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgTicket
        '
        Me.hgTicket.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaProcesarTicket, Me.bsaBorrarTicket})
        Me.hgTicket.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgTicket.Location = New System.Drawing.Point(502, 337)
        Me.hgTicket.Name = "hgTicket"
        '
        'hgTicket.Panel
        '
        Me.hgTicket.Panel.Controls.Add(Me.dgticket)
        Me.hgTicket.Size = New System.Drawing.Size(391, 332)
        Me.hgTicket.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgTicket.TabIndex = 59
        Me.hgTicket.Text = "Ticket"
        Me.hgTicket.ValuesPrimary.Description = ""
        Me.hgTicket.ValuesPrimary.Heading = "Ticket"
        Me.hgTicket.ValuesPrimary.Image = Nothing
        Me.hgTicket.ValuesSecondary.Description = ""
        Me.hgTicket.ValuesSecondary.Heading = ""
        Me.hgTicket.ValuesSecondary.Image = Nothing
        '
        'bsaProcesarTicket
        '
        Me.bsaProcesarTicket.ExtraText = ""
        Me.bsaProcesarTicket.Image = CType(resources.GetObject("bsaProcesarTicket.Image"), System.Drawing.Image)
        Me.bsaProcesarTicket.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaProcesarTicket.Text = "Procesar Ticket"
        Me.bsaProcesarTicket.ToolTipImage = Nothing
        Me.bsaProcesarTicket.UniqueName = "C3C793640099408EC3C793640099408E"
        '
        'bsaBorrarTicket
        '
        Me.bsaBorrarTicket.ExtraText = ""
        Me.bsaBorrarTicket.Image = CType(resources.GetObject("bsaBorrarTicket.Image"), System.Drawing.Image)
        Me.bsaBorrarTicket.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaBorrarTicket.Text = "Eliminar Servicio"
        Me.bsaBorrarTicket.ToolTipImage = Nothing
        Me.bsaBorrarTicket.UniqueName = "72C54DBD122E43BB72C54DBD122E43BB"
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
        Me.dgticket.MultiSelect = False
        Me.dgticket.Name = "dgticket"
        Me.dgticket.ReadOnly = True
        Me.dgticket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgticket.Size = New System.Drawing.Size(389, 299)
        Me.dgticket.StateCommon.Background.Color1 = System.Drawing.SystemColors.Window
        Me.dgticket.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgticket.TabIndex = 26
        '
        'NORDSR
        '
        Me.NORDSR.DataPropertyName = "NORDSR"
        Me.NORDSR.HeaderText = "N° Orden"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.ReadOnly = True
        Me.NORDSR.Width = 84
        '
        'NSLCSRDataGridViewTextBoxColumn
        '
        Me.NSLCSRDataGridViewTextBoxColumn.DataPropertyName = "NSLCSR"
        Me.NSLCSRDataGridViewTextBoxColumn.HeaderText = "NSLCSR"
        Me.NSLCSRDataGridViewTextBoxColumn.Name = "NSLCSRDataGridViewTextBoxColumn"
        Me.NSLCSRDataGridViewTextBoxColumn.ReadOnly = True
        Me.NSLCSRDataGridViewTextBoxColumn.Visible = False
        Me.NSLCSRDataGridViewTextBoxColumn.Width = 79
        '
        'NROTCKDataGridViewTextBoxColumn
        '
        Me.NROTCKDataGridViewTextBoxColumn.DataPropertyName = "NROTCK"
        Me.NROTCKDataGridViewTextBoxColumn.HeaderText = "NROTCK"
        Me.NROTCKDataGridViewTextBoxColumn.Name = "NROTCKDataGridViewTextBoxColumn"
        Me.NROTCKDataGridViewTextBoxColumn.ReadOnly = True
        Me.NROTCKDataGridViewTextBoxColumn.Visible = False
        Me.NROTCKDataGridViewTextBoxColumn.Width = 81
        '
        'NCRRLTDataGridViewTextBoxColumn
        '
        Me.NCRRLTDataGridViewTextBoxColumn.DataPropertyName = "NCRRLT"
        Me.NCRRLTDataGridViewTextBoxColumn.HeaderText = "NCRRLT"
        Me.NCRRLTDataGridViewTextBoxColumn.Name = "NCRRLTDataGridViewTextBoxColumn"
        Me.NCRRLTDataGridViewTextBoxColumn.ReadOnly = True
        Me.NCRRLTDataGridViewTextBoxColumn.Visible = False
        Me.NCRRLTDataGridViewTextBoxColumn.Width = 80
        '
        'CSRVNVDataGridViewTextBoxColumn
        '
        Me.CSRVNVDataGridViewTextBoxColumn.DataPropertyName = "CSRVNV"
        Me.CSRVNVDataGridViewTextBoxColumn.HeaderText = "Cod Serv"
        Me.CSRVNVDataGridViewTextBoxColumn.Name = "CSRVNVDataGridViewTextBoxColumn"
        Me.CSRVNVDataGridViewTextBoxColumn.ReadOnly = True
        Me.CSRVNVDataGridViewTextBoxColumn.Width = 81
        '
        'FENVSLDataGridViewTextBoxColumn
        '
        Me.FENVSLDataGridViewTextBoxColumn.DataPropertyName = "FENVSL"
        Me.FENVSLDataGridViewTextBoxColumn.HeaderText = "FENVSL"
        Me.FENVSLDataGridViewTextBoxColumn.Name = "FENVSLDataGridViewTextBoxColumn"
        Me.FENVSLDataGridViewTextBoxColumn.ReadOnly = True
        Me.FENVSLDataGridViewTextBoxColumn.Visible = False
        Me.FENVSLDataGridViewTextBoxColumn.Width = 77
        '
        'FAUTRDataGridViewTextBoxColumn
        '
        Me.FAUTRDataGridViewTextBoxColumn.DataPropertyName = "FAUTR"
        Me.FAUTRDataGridViewTextBoxColumn.HeaderText = "FAUTR"
        Me.FAUTRDataGridViewTextBoxColumn.Name = "FAUTRDataGridViewTextBoxColumn"
        Me.FAUTRDataGridViewTextBoxColumn.ReadOnly = True
        Me.FAUTRDataGridViewTextBoxColumn.Visible = False
        Me.FAUTRDataGridViewTextBoxColumn.Width = 72
        '
        'FATNSRDataGridViewTextBoxColumn
        '
        Me.FATNSRDataGridViewTextBoxColumn.DataPropertyName = "FATNSR"
        Me.FATNSRDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FATNSRDataGridViewTextBoxColumn.Name = "FATNSRDataGridViewTextBoxColumn"
        Me.FATNSRDataGridViewTextBoxColumn.ReadOnly = True
        Me.FATNSRDataGridViewTextBoxColumn.Width = 66
        '
        'HORAINIDataGridViewTextBoxColumn
        '
        Me.HORAINIDataGridViewTextBoxColumn.DataPropertyName = "HORAINI"
        Me.HORAINIDataGridViewTextBoxColumn.HeaderText = "Hora Inicio"
        Me.HORAINIDataGridViewTextBoxColumn.Name = "HORAINIDataGridViewTextBoxColumn"
        Me.HORAINIDataGridViewTextBoxColumn.ReadOnly = True
        Me.HORAINIDataGridViewTextBoxColumn.Width = 92
        '
        'HORAFINDataGridViewTextBoxColumn
        '
        Me.HORAFINDataGridViewTextBoxColumn.DataPropertyName = "HORAFIN"
        Me.HORAFINDataGridViewTextBoxColumn.HeaderText = "Hora Final"
        Me.HORAFINDataGridViewTextBoxColumn.Name = "HORAFINDataGridViewTextBoxColumn"
        Me.HORAFINDataGridViewTextBoxColumn.ReadOnly = True
        Me.HORAFINDataGridViewTextBoxColumn.Width = 89
        '
        'CTRSPTDataGridViewTextBoxColumn
        '
        Me.CTRSPTDataGridViewTextBoxColumn.DataPropertyName = "CTRSPT"
        Me.CTRSPTDataGridViewTextBoxColumn.HeaderText = "CTRSPT"
        Me.CTRSPTDataGridViewTextBoxColumn.Name = "CTRSPTDataGridViewTextBoxColumn"
        Me.CTRSPTDataGridViewTextBoxColumn.ReadOnly = True
        Me.CTRSPTDataGridViewTextBoxColumn.Visible = False
        Me.CTRSPTDataGridViewTextBoxColumn.Width = 79
        '
        'NDCMFCDataGridViewTextBoxColumn
        '
        Me.NDCMFCDataGridViewTextBoxColumn.DataPropertyName = "NDCMFC"
        Me.NDCMFCDataGridViewTextBoxColumn.HeaderText = "NDCMFC"
        Me.NDCMFCDataGridViewTextBoxColumn.Name = "NDCMFCDataGridViewTextBoxColumn"
        Me.NDCMFCDataGridViewTextBoxColumn.ReadOnly = True
        Me.NDCMFCDataGridViewTextBoxColumn.Visible = False
        Me.NDCMFCDataGridViewTextBoxColumn.Width = 81
        '
        'NHRCALDataGridViewTextBoxColumn
        '
        Me.NHRCALDataGridViewTextBoxColumn.DataPropertyName = "NHRCAL"
        Me.NHRCALDataGridViewTextBoxColumn.HeaderText = "Tiempo Calculado"
        Me.NHRCALDataGridViewTextBoxColumn.Name = "NHRCALDataGridViewTextBoxColumn"
        Me.NHRCALDataGridViewTextBoxColumn.ReadOnly = True
        Me.NHRCALDataGridViewTextBoxColumn.Width = 127
        '
        'NHRFACDataGridViewTextBoxColumn
        '
        Me.NHRFACDataGridViewTextBoxColumn.DataPropertyName = "NHRFAC"
        Me.NHRFACDataGridViewTextBoxColumn.HeaderText = "Tiempo Facturado"
        Me.NHRFACDataGridViewTextBoxColumn.Name = "NHRFACDataGridViewTextBoxColumn"
        Me.NHRFACDataGridViewTextBoxColumn.ReadOnly = True
        Me.NHRFACDataGridViewTextBoxColumn.Width = 128
        '
        'OBSERDataGridViewTextBoxColumn
        '
        Me.OBSERDataGridViewTextBoxColumn.DataPropertyName = "OBSER"
        Me.OBSERDataGridViewTextBoxColumn.HeaderText = "Observacion"
        Me.OBSERDataGridViewTextBoxColumn.Name = "OBSERDataGridViewTextBoxColumn"
        Me.OBSERDataGridViewTextBoxColumn.ReadOnly = True
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
        'hgMercaderiaSeleccionada
        '
        Me.hgMercaderiaSeleccionada.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaProcesarRecepcion, Me.bsaEliminarMercaderia})
        Me.hgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgMercaderiaSeleccionada.HeaderVisibleSecondary = False
        Me.hgMercaderiaSeleccionada.Location = New System.Drawing.Point(502, 128)
        Me.hgMercaderiaSeleccionada.Name = "hgMercaderiaSeleccionada"
        '
        'hgMercaderiaSeleccionada.Panel
        '
        Me.hgMercaderiaSeleccionada.Panel.Controls.Add(Me.dgMercaderiaSeleccionada)
        Me.hgMercaderiaSeleccionada.Panel.Controls.Add(Me.dgNroTicket)
        Me.hgMercaderiaSeleccionada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hgMercaderiaSeleccionada.Size = New System.Drawing.Size(391, 541)
        Me.hgMercaderiaSeleccionada.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgMercaderiaSeleccionada.TabIndex = 54
        Me.hgMercaderiaSeleccionada.Text = "Mercadería Seleccionada"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Heading = "Mercadería Seleccionada"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Image = Nothing
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Heading = "Description"
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Image = Nothing
        '
        'bsaProcesarRecepcion
        '
        Me.bsaProcesarRecepcion.ExtraText = ""
        Me.bsaProcesarRecepcion.Image = CType(resources.GetObject("bsaProcesarRecepcion.Image"), System.Drawing.Image)
        Me.bsaProcesarRecepcion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaProcesarRecepcion.Text = "Procesar Despacho"
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
        Me.bsaEliminarMercaderia.UniqueName = "4E2448D4619F4C2C4E2448D4619F4C2C"
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaSeleccionada.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMercaderiaSeleccionada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaSeleccionada.Size = New System.Drawing.Size(389, 511)
        Me.dgMercaderiaSeleccionada.StandardTab = True
        Me.dgMercaderiaSeleccionada.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderiaSeleccionada.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderiaSeleccionada.TabIndex = 53
        '
        'S_CMRCLR
        '
        Me.S_CMRCLR.DataPropertyName = "CMRCLR"
        Me.S_CMRCLR.HeaderText = "Mercadería"
        Me.S_CMRCLR.Name = "S_CMRCLR"
        Me.S_CMRCLR.ReadOnly = True
        Me.S_CMRCLR.Visible = False
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
        Me.S_NCRCTC.Visible = False
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
        Me.S_CUNCNT.Visible = False
        Me.S_CUNCNT.Width = 97
        '
        'S_CUNPST
        '
        Me.S_CUNPST.DataPropertyName = "CUNPST"
        Me.S_CUNPST.HeaderText = "U. Peso"
        Me.S_CUNPST.Name = "S_CUNPST"
        Me.S_CUNPST.ReadOnly = True
        Me.S_CUNPST.Visible = False
        Me.S_CUNPST.Width = 74
        '
        'S_CUNVLT
        '
        Me.S_CUNVLT.DataPropertyName = "CUNVLT"
        Me.S_CUNVLT.HeaderText = "U. Valor"
        Me.S_CUNVLT.Name = "S_CUNVLT"
        Me.S_CUNVLT.ReadOnly = True
        Me.S_CUNVLT.Visible = False
        Me.S_CUNVLT.Width = 77
        '
        'S_NORCCL
        '
        Me.S_NORCCL.DataPropertyName = "NORCCL"
        Me.S_NORCCL.HeaderText = "No O/C"
        Me.S_NORCCL.Name = "S_NORCCL"
        Me.S_NORCCL.ReadOnly = True
        Me.S_NORCCL.Visible = False
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
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtMercaderia, Me.dtStockPorAlmacen, Me.dtMercaderiaSeleccionadas, Me.dtAutorizaciones})
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
        'dtStockPorAlmacen
        '
        Me.dtStockPorAlmacen.Columns.AddRange(New System.Data.DataColumn() {Me.DSTASEL, Me.DNORDSR, Me.DCTPALM, Me.DCALMC, Me.DCZNALM, Me.DTCMZNA, Me.DQSLMC2, Me.DCUNCN7, Me.DQSLMP2, Me.DCUNPS7, Me.DQDSVGN, Me.DQAUTCN, Me.DQAUTPS, Me.DSTPING, Me.DTOBSRV})
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
        'DCALMC
        '
        Me.DCALMC.ColumnName = "CALMC"
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
        'dtMercaderiaSeleccionadas
        '
        Me.dtMercaderiaSeleccionadas.Columns.AddRange(New System.Data.DataColumn() {Me.SCMRCLR, Me.STMRCD2, Me.SCMRCD, Me.SNORDSR, Me.SNCNTR, Me.SNCRCTC, Me.SNAUTR, Me.SCUNCNT, Me.SCUNPST, Me.SCUNVLT, Me.SNORCCL, Me.SNGUICL, Me.SNRUCLL, Me.SSTPING, Me.SCTPALM, Me.STALMC, Me.SCALMC, Me.STCMPAL, Me.SCZNALM, Me.STCMZNA, Me.SQTRMC, Me.SQTRMP, Me.SQDSVGN, Me.SCCNTD, Me.SCTPOCN, Me.SFUNDS2, Me.SCTPDPS, Me.STOBSRV})
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
        'SCCNTD
        '
        Me.SCCNTD.ColumnName = "CCNTD"
        '
        'SCTPOCN
        '
        Me.SCTPOCN.ColumnName = "CTPOCN"
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
        'dtAutorizaciones
        '
        Me.dtAutorizaciones.Columns.AddRange(New System.Data.DataColumn() {Me.ANORSRA, Me.ANCNTR, Me.AQAUTCN, Me.ACUNC11, Me.AQAUTPS, Me.ACUNP11, Me.AQTTDSC, Me.AQTTDSP, Me.AFESTAT, Me.AFAUTR, Me.AFLLGSL, Me.ANAUTR, Me.AFUNDS2, Me.AQSLMC, Me.AQSLMP, Me.ACMRCD})
        Me.dtAutorizaciones.TableName = "dtAutorizaciones"
        '
        'ANORSRA
        '
        Me.ANORSRA.Caption = "NORSRA"
        Me.ANORSRA.ColumnName = "NORSRA"
        Me.ANORSRA.DataType = GetType(Long)
        Me.ANORSRA.DefaultValue = CType(0, Long)
        '
        'ANCNTR
        '
        Me.ANCNTR.ColumnName = "NCNTR"
        Me.ANCNTR.DataType = GetType(Long)
        Me.ANCNTR.DefaultValue = CType(0, Long)
        '
        'AQAUTCN
        '
        Me.AQAUTCN.ColumnName = "QAUTCN"
        Me.AQAUTCN.DataType = GetType(Decimal)
        Me.AQAUTCN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 196608})
        '
        'ACUNC11
        '
        Me.ACUNC11.ColumnName = "CUNC11"
        '
        'AQAUTPS
        '
        Me.AQAUTPS.ColumnName = "QAUTPS"
        Me.AQAUTPS.DataType = GetType(Decimal)
        Me.AQAUTPS.DefaultValue = New Decimal(New Integer() {0, 0, 0, 196608})
        '
        'ACUNP11
        '
        Me.ACUNP11.ColumnName = "CUNP11"
        '
        'AQTTDSC
        '
        Me.AQTTDSC.ColumnName = "QTTDSC"
        '
        'AQTTDSP
        '
        Me.AQTTDSP.ColumnName = "QTTDSP"
        Me.AQTTDSP.DataType = GetType(Decimal)
        Me.AQTTDSP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 196608})
        '
        'AFESTAT
        '
        Me.AFESTAT.ColumnName = "FESTAT"
        '
        'AFAUTR
        '
        Me.AFAUTR.ColumnName = "FAUTR"
        Me.AFAUTR.DataType = GetType(Date)
        '
        'AFLLGSL
        '
        Me.AFLLGSL.ColumnName = "FLLGSL"
        Me.AFLLGSL.DataType = GetType(Date)
        '
        'ANAUTR
        '
        Me.ANAUTR.ColumnName = "NAUTR"
        Me.ANAUTR.DataType = GetType(Long)
        Me.ANAUTR.DefaultValue = CType(0, Long)
        '
        'AFUNDS2
        '
        Me.AFUNDS2.ColumnName = "FUNDS2"
        '
        'AQSLMC
        '
        Me.AQSLMC.ColumnName = "QSLMC"
        '
        'AQSLMP
        '
        Me.AQSLMP.ColumnName = "QSLMP"
        '
        'ACMRCD
        '
        Me.ACMRCD.ColumnName = "CMRCD"
        '
        'dgNroTicket
        '
        Me.dgNroTicket.AllowUserToAddRows = False
        Me.dgNroTicket.AllowUserToDeleteRows = False
        Me.dgNroTicket.AllowUserToResizeColumns = False
        Me.dgNroTicket.AllowUserToResizeRows = False
        Me.dgNroTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgNroTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ticket})
        Me.dgNroTicket.Location = New System.Drawing.Point(25, 341)
        Me.dgNroTicket.Name = "dgNroTicket"
        Me.dgNroTicket.Size = New System.Drawing.Size(141, 52)
        Me.dgNroTicket.StateCommon.Background.Color1 = System.Drawing.SystemColors.Menu
        Me.dgNroTicket.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgNroTicket.TabIndex = 52
        '
        'Ticket
        '
        Me.Ticket.HeaderText = "Max Solicitud"
        Me.Ticket.Name = "Ticket"
        Me.Ticket.Width = 105
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaAgregarMercaderia, Me.bsaAgregarTicket})
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Left
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 128)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dgAutorizaciones)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(502, 541)
        Me.KryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.Text = "Autorizaciones"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Autorizaciones"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'bsaAgregarMercaderia
        '
        Me.bsaAgregarMercaderia.ExtraText = ""
        Me.bsaAgregarMercaderia.Image = CType(resources.GetObject("bsaAgregarMercaderia.Image"), System.Drawing.Image)
        Me.bsaAgregarMercaderia.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaAgregarMercaderia.Text = "Despachar Mercaderia"
        Me.bsaAgregarMercaderia.ToolTipImage = Nothing
        Me.bsaAgregarMercaderia.UniqueName = "59030FFA3992401859030FFA39924018"
        '
        'bsaAgregarTicket
        '
        Me.bsaAgregarTicket.ExtraText = ""
        Me.bsaAgregarTicket.Image = CType(resources.GetObject("bsaAgregarTicket.Image"), System.Drawing.Image)
        Me.bsaAgregarTicket.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaAgregarTicket.Text = "Agregar Ticket"
        Me.bsaAgregarTicket.ToolTipImage = Nothing
        Me.bsaAgregarTicket.UniqueName = "92F6061B42E5429B92F6061B42E5429B"
        '
        'dgAutorizaciones
        '
        Me.dgAutorizaciones.AllowUserToAddRows = False
        Me.dgAutorizaciones.AllowUserToDeleteRows = False
        Me.dgAutorizaciones.AllowUserToResizeColumns = False
        Me.dgAutorizaciones.AllowUserToResizeRows = False
        Me.dgAutorizaciones.AutoGenerateColumns = False
        Me.dgAutorizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgAutorizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.A_NORSRA, Me.A_NCNTR, Me.A_NAUTR, Me.A_QAUTCN, Me.A_CUNC11, Me.A_QAUTPS, Me.A_CUNP11, Me.A_FAUTR, Me.A_FESTAT, Me.A_QTTDSC, Me.A_QTTDSP, Me.A_FLLGSL, Me.FUNDS2_A, Me.QSLMC, Me.QSLMP, Me.O_NCNTR, Me.CMRCD})
        Me.dgAutorizaciones.DataMember = "dtAutorizaciones"
        Me.dgAutorizaciones.DataSource = Me.dstMercaderia
        Me.dgAutorizaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAutorizaciones.Location = New System.Drawing.Point(0, 0)
        Me.dgAutorizaciones.MultiSelect = False
        Me.dgAutorizaciones.Name = "dgAutorizaciones"
        Me.dgAutorizaciones.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgAutorizaciones.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgAutorizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAutorizaciones.Size = New System.Drawing.Size(500, 508)
        Me.dgAutorizaciones.StandardTab = True
        Me.dgAutorizaciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgAutorizaciones.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgAutorizaciones.TabIndex = 28
        '
        'A_NORSRA
        '
        Me.A_NORSRA.DataPropertyName = "NORSRA"
        Me.A_NORSRA.HeaderText = "Orden Servicio"
        Me.A_NORSRA.Name = "A_NORSRA"
        Me.A_NORSRA.Width = 111
        '
        'A_NCNTR
        '
        Me.A_NCNTR.DataPropertyName = "NCNTR"
        Me.A_NCNTR.HeaderText = "Contrato"
        Me.A_NCNTR.Name = "A_NCNTR"
        Me.A_NCNTR.Visible = False
        Me.A_NCNTR.Width = 82
        '
        'A_NAUTR
        '
        Me.A_NAUTR.DataPropertyName = "NAUTR"
        Me.A_NAUTR.HeaderText = "Nro. Aut"
        Me.A_NAUTR.Name = "A_NAUTR"
        Me.A_NAUTR.Width = 79
        '
        'A_QAUTCN
        '
        Me.A_QAUTCN.DataPropertyName = "QAUTCN"
        Me.A_QAUTCN.HeaderText = "Cant Aut"
        Me.A_QAUTCN.Name = "A_QAUTCN"
        Me.A_QAUTCN.Visible = False
        Me.A_QAUTCN.Width = 81
        '
        'A_CUNC11
        '
        Me.A_CUNC11.DataPropertyName = "CUNC11"
        Me.A_CUNC11.HeaderText = "Uni Cant"
        Me.A_CUNC11.Name = "A_CUNC11"
        Me.A_CUNC11.Visible = False
        Me.A_CUNC11.Width = 81
        '
        'A_QAUTPS
        '
        Me.A_QAUTPS.DataPropertyName = "QAUTPS"
        Me.A_QAUTPS.HeaderText = "Peso Aut"
        Me.A_QAUTPS.Name = "A_QAUTPS"
        Me.A_QAUTPS.Visible = False
        Me.A_QAUTPS.Width = 81
        '
        'A_CUNP11
        '
        Me.A_CUNP11.DataPropertyName = "CUNP11"
        Me.A_CUNP11.HeaderText = "Uni Peso"
        Me.A_CUNP11.Name = "A_CUNP11"
        Me.A_CUNP11.Visible = False
        Me.A_CUNP11.Width = 81
        '
        'A_FAUTR
        '
        Me.A_FAUTR.DataPropertyName = "FAUTR"
        Me.A_FAUTR.HeaderText = "Fecha Aut"
        Me.A_FAUTR.Name = "A_FAUTR"
        Me.A_FAUTR.Width = 87
        '
        'A_FESTAT
        '
        Me.A_FESTAT.DataPropertyName = "FESTAT"
        Me.A_FESTAT.HeaderText = "Estado"
        Me.A_FESTAT.Name = "A_FESTAT"
        Me.A_FESTAT.Width = 71
        '
        'A_QTTDSC
        '
        Me.A_QTTDSC.DataPropertyName = "QTTDSC"
        Me.A_QTTDSC.HeaderText = "Cant Desp"
        Me.A_QTTDSC.Name = "A_QTTDSC"
        Me.A_QTTDSC.Visible = False
        Me.A_QTTDSC.Width = 89
        '
        'A_QTTDSP
        '
        Me.A_QTTDSP.DataPropertyName = "QTTDSP"
        Me.A_QTTDSP.HeaderText = "Peso Desp"
        Me.A_QTTDSP.Name = "A_QTTDSP"
        Me.A_QTTDSP.Visible = False
        Me.A_QTTDSP.Width = 89
        '
        'A_FLLGSL
        '
        Me.A_FLLGSL.DataPropertyName = "FLLGSL"
        Me.A_FLLGSL.HeaderText = "Fecha Salida"
        Me.A_FLLGSL.Name = "A_FLLGSL"
        Me.A_FLLGSL.Visible = False
        '
        'FUNDS2_A
        '
        Me.FUNDS2_A.DataPropertyName = "FUNDS2"
        Me.FUNDS2_A.HeaderText = "Tipo"
        Me.FUNDS2_A.Name = "FUNDS2_A"
        Me.FUNDS2_A.Visible = False
        Me.FUNDS2_A.Width = 58
        '
        'QSLMC
        '
        Me.QSLMC.DataPropertyName = "QSLMC"
        Me.QSLMC.HeaderText = "Cantidad"
        Me.QSLMC.Name = "QSLMC"
        Me.QSLMC.Visible = False
        Me.QSLMC.Width = 83
        '
        'QSLMP
        '
        Me.QSLMP.DataPropertyName = "QSLMP"
        Me.QSLMP.HeaderText = "Peso"
        Me.QSLMP.Name = "QSLMP"
        Me.QSLMP.Visible = False
        Me.QSLMP.Width = 60
        '
        'O_NCNTR
        '
        Me.O_NCNTR.DataPropertyName = "NCNTR"
        Me.O_NCNTR.HeaderText = "Contrato"
        Me.O_NCNTR.Name = "O_NCNTR"
        Me.O_NCNTR.Width = 82
        '
        'CMRCD
        '
        Me.CMRCD.DataPropertyName = "CMRCD"
        Me.CMRCD.HeaderText = "Cod Ransa"
        Me.CMRCD.Name = "CMRCD"
        Me.CMRCD.Width = 91
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtAutorizacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnActualizar)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(893, 128)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.KryptonLabel12)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(605, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 45)
        Me.GroupBox1.TabIndex = 46
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
        'txtCliente
        '
        Me.txtCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaClienteListar})
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(101, 15)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(278, 21)
        Me.txtCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.TabIndex = 42
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
        'txtAutorizacion
        '
        Me.txtAutorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAutorizacion.Location = New System.Drawing.Point(101, 43)
        Me.txtAutorizacion.Name = "txtAutorizacion"
        Me.txtAutorizacion.Size = New System.Drawing.Size(121, 21)
        Me.txtAutorizacion.TabIndex = 44
        Me.TypeValidator.SetTypes(Me.txtAutorizacion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 18)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 41
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 43)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(75, 19)
        Me.KryptonLabel3.TabIndex = 43
        Me.KryptonLabel3.Text = "Autorizacion: "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Autorizacion: "
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(799, 15)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(77, 65)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 45
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'dtAutorizacion
        '
        Me.dtAutorizacion.DataSetName = "NewDataSet"
        Me.dtAutorizacion.Tables.AddRange(New System.Data.DataTable() {Me.Autorizacion})
        '
        'Autorizacion
        '
        Me.Autorizacion.Columns.AddRange(New System.Data.DataColumn() {Me.NAUTR, Me.FAUTR, Me.NORSRA, Me.FESTAT, Me.QAUTCN, Me.QAUTPC, Me.QAUTVL, Me.FUNDS2})
        Me.Autorizacion.TableName = "Autorizacion"
        '
        'NAUTR
        '
        Me.NAUTR.ColumnName = "Autorizacion"
        '
        'FAUTR
        '
        Me.FAUTR.ColumnName = "Fecha Autorizacion"
        '
        'NORSRA
        '
        Me.NORSRA.ColumnName = "Orden"
        '
        'FESTAT
        '
        Me.FESTAT.ColumnName = "Fecha "
        '
        'QAUTCN
        '
        Me.QAUTCN.ColumnName = "Cantidad"
        '
        'QAUTPC
        '
        Me.QAUTPC.ColumnName = "Peso"
        '
        'QAUTVL
        '
        Me.QAUTVL.ColumnName = "Valor"
        '
        'FUNDS2
        '
        Me.FUNDS2.ColumnName = "Tipo"
        '
        'frmSDSWDespachoSDSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 669)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmSDSWDespachoSDSA"
        Me.Text = "Despacho"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgTicket.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgTicket.Panel.ResumeLayout(False)
        CType(Me.hgTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgTicket.ResumeLayout(False)
        CType(Me.dgticket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.Panel.ResumeLayout(False)
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.ResumeLayout(False)
        CType(Me.dgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStockPorAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderiaSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAutorizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgNroTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.dgAutorizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtAutorizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Autorizacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents hgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaProcesarRecepcion As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaEliminarMercaderia As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgNroTicket As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Ticket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hgTicket As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaProcesarTicket As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaBorrarTicket As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaClienteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtAutorizacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dtAutorizacion As System.Data.DataSet
    Friend WithEvents Autorizacion As System.Data.DataTable
    Friend WithEvents NAUTR As System.Data.DataColumn
    Friend WithEvents FAUTR As System.Data.DataColumn
    Friend WithEvents NORSRA As System.Data.DataColumn
    Friend WithEvents FESTAT As System.Data.DataColumn
    Friend WithEvents QAUTCN As System.Data.DataColumn
    Friend WithEvents QAUTPC As System.Data.DataColumn
    Friend WithEvents QAUTVL As System.Data.DataColumn
    Friend WithEvents bsaAgregarMercaderia As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
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
    Friend WithEvents dtStockPorAlmacen As System.Data.DataTable
    Friend WithEvents DSTASEL As System.Data.DataColumn
    Friend WithEvents DNORDSR As System.Data.DataColumn
    Friend WithEvents DCTPALM As System.Data.DataColumn
    Friend WithEvents DCALMC As System.Data.DataColumn
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
    Friend WithEvents dtAutorizaciones As System.Data.DataTable
    Friend WithEvents ANORSRA As System.Data.DataColumn
    Friend WithEvents ANCNTR As System.Data.DataColumn
    Friend WithEvents AQAUTCN As System.Data.DataColumn
    Friend WithEvents ACUNC11 As System.Data.DataColumn
    Friend WithEvents AQAUTPS As System.Data.DataColumn
    Friend WithEvents ACUNP11 As System.Data.DataColumn
    Friend WithEvents AQTTDSC As System.Data.DataColumn
    Friend WithEvents AQTTDSP As System.Data.DataColumn
    Friend WithEvents AFESTAT As System.Data.DataColumn
    Friend WithEvents AFAUTR As System.Data.DataColumn
    Friend WithEvents AFLLGSL As System.Data.DataColumn
    Friend WithEvents ANAUTR As System.Data.DataColumn
    Friend WithEvents dstTicket As System.Data.DataSet
    Friend WithEvents dtTicket As System.Data.DataTable
    Friend WithEvents TNORDSR As System.Data.DataColumn
    Friend WithEvents TNSLCSR As System.Data.DataColumn
    Friend WithEvents TNROTCK As System.Data.DataColumn
    Friend WithEvents TNCRRLT As System.Data.DataColumn
    Friend WithEvents TCSRVNV As System.Data.DataColumn
    Friend WithEvents TFENVSL As System.Data.DataColumn
    Friend WithEvents TFAUTR As System.Data.DataColumn
    Friend WithEvents TFATNSR As System.Data.DataColumn
    Friend WithEvents THORAINI As System.Data.DataColumn
    Friend WithEvents THORAFIN As System.Data.DataColumn
    Friend WithEvents TCTRSPT As System.Data.DataColumn
    Friend WithEvents TOBSER As System.Data.DataColumn
    Friend WithEvents TNDCMFC As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents dgAutorizaciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents FUNDS2 As System.Data.DataColumn
    Friend WithEvents AFUNDS2 As System.Data.DataColumn
    Friend WithEvents bsaAgregarTicket As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents AQSLMC As System.Data.DataColumn
    Friend WithEvents AQSLMP As System.Data.DataColumn
    Friend WithEvents ACMRCD As System.Data.DataColumn
    Friend WithEvents dgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgticket As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents A_NORSRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_QAUTCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_CUNC11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_QAUTPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_CUNP11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_FAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_FESTAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_QTTDSC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_QTTDSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_FLLGSL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUNDS2_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents O_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
