<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWIngOServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWIngOServicio))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel4 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgTicketSolicitados = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaanular = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrarTicket = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaVistaPreviaT = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgTicket = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORDSRDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NROTCK1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPOATDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESDCMD1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCHCRTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstOServicio = New System.Data.DataSet
        Me.dtServicio = New System.Data.DataTable
        Me.MNORDSR = New System.Data.DataColumn
        Me.MNCNTR = New System.Data.DataColumn
        Me.MNAUTR = New System.Data.DataColumn
        Me.MCMRCD = New System.Data.DataColumn
        Me.MTMRCD2 = New System.Data.DataColumn
        Me.MFEMORS = New System.Data.DataColumn
        Me.MQMRCD1 = New System.Data.DataColumn
        Me.MQPSMR1 = New System.Data.DataColumn
        Me.dtSolSeleccionado = New System.Data.DataTable
        Me.MNSLCSR = New System.Data.DataColumn
        Me.MCTPALM = New System.Data.DataColumn
        Me.MCALMC = New System.Data.DataColumn
        Me.MFRLZSR = New System.Data.DataColumn
        Me.MNORDSR1 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.dtTicket1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.hgTicketGenerado = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsngrabar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsagenerar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaEliminarServicio = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgvticket = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSLCSRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NROTCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CSRVNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FATNSRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HORAINIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HORAFINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.hgGuiaSalida = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dgOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FEMORS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QMRCD1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QPSMR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgVisorPrevia = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.pbxReducir = New System.Windows.Forms.PictureBox
        Me.pbxAmpliar = New System.Windows.Forms.PictureBox
        Me.VisorReportesCrystal = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblcodcliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtNroOrdServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaClienteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblNroGuiaSalida = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel4.SuspendLayout()
        CType(Me.hgTicketSolicitados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgTicketSolicitados.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgTicketSolicitados.Panel.SuspendLayout()
        Me.hgTicketSolicitados.SuspendLayout()
        CType(Me.dgTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstOServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSolSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTicket1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgTicketGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgTicketGenerado.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgTicketGenerado.Panel.SuspendLayout()
        Me.hgTicketGenerado.SuspendLayout()
        CType(Me.dgvticket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGuiaSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGuiaSalida.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgGuiaSalida.Panel.SuspendLayout()
        Me.hgGuiaSalida.SuspendLayout()
        CType(Me.dgOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgVisorPrevia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgVisorPrevia.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgVisorPrevia.Panel.SuspendLayout()
        Me.hgVisorPrevia.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxReducir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAmpliar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel4)
        Me.KryptonPanel.Controls.Add(Me.hgVisorPrevia)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(943, 612)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel4
        '
        Me.KryptonPanel4.Controls.Add(Me.hgTicketSolicitados)
        Me.KryptonPanel4.Controls.Add(Me.hgTicketGenerado)
        Me.KryptonPanel4.Controls.Add(Me.hgGuiaSalida)
        Me.KryptonPanel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.KryptonPanel4.Location = New System.Drawing.Point(0, 125)
        Me.KryptonPanel4.Name = "KryptonPanel4"
        Me.KryptonPanel4.Size = New System.Drawing.Size(616, 487)
        Me.KryptonPanel4.TabIndex = 8
        '
        'hgTicketSolicitados
        '
        Me.hgTicketSolicitados.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaanular, Me.bsaCerrarTicket, Me.bsaVistaPreviaT})
        Me.hgTicketSolicitados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgTicketSolicitados.HeaderVisibleSecondary = False
        Me.hgTicketSolicitados.Location = New System.Drawing.Point(0, 179)
        Me.hgTicketSolicitados.Name = "hgTicketSolicitados"
        '
        'hgTicketSolicitados.Panel
        '
        Me.hgTicketSolicitados.Panel.Controls.Add(Me.dgTicket)
        Me.hgTicketSolicitados.Size = New System.Drawing.Size(616, 94)
        Me.hgTicketSolicitados.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgTicketSolicitados.TabIndex = 9
        Me.hgTicketSolicitados.Text = "Ticket  Solicitados"
        Me.hgTicketSolicitados.ValuesPrimary.Description = ""
        Me.hgTicketSolicitados.ValuesPrimary.Heading = "Ticket  Solicitados"
        Me.hgTicketSolicitados.ValuesPrimary.Image = Nothing
        Me.hgTicketSolicitados.ValuesSecondary.Description = ""
        Me.hgTicketSolicitados.ValuesSecondary.Heading = "Description"
        Me.hgTicketSolicitados.ValuesSecondary.Image = Nothing
        '
        'bsaanular
        '
        Me.bsaanular.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[True]
        Me.bsaanular.ExtraText = ""
        Me.bsaanular.Image = CType(resources.GetObject("bsaanular.Image"), System.Drawing.Image)
        Me.bsaanular.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaanular.Text = "Anular"
        Me.bsaanular.ToolTipImage = Nothing
        Me.bsaanular.UniqueName = "BA471D4AE4174FFABA471D4AE4174FFA"
        '
        'bsaCerrarTicket
        '
        Me.bsaCerrarTicket.ExtraText = ""
        Me.bsaCerrarTicket.Image = CType(resources.GetObject("bsaCerrarTicket.Image"), System.Drawing.Image)
        Me.bsaCerrarTicket.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrarTicket.Text = "Cerrar Ticket"
        Me.bsaCerrarTicket.ToolTipImage = Nothing
        Me.bsaCerrarTicket.UniqueName = "1D005403F00A4F7A1D005403F00A4F7A"
        '
        'bsaVistaPreviaT
        '
        Me.bsaVistaPreviaT.ExtraText = ""
        Me.bsaVistaPreviaT.Image = CType(resources.GetObject("bsaVistaPreviaT.Image"), System.Drawing.Image)
        Me.bsaVistaPreviaT.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaVistaPreviaT.Text = "Vista Previa"
        Me.bsaVistaPreviaT.ToolTipImage = Nothing
        Me.bsaVistaPreviaT.UniqueName = "67570F8A96AC493B67570F8A96AC493B"
        '
        'dgTicket
        '
        Me.dgTicket.AllowUserToAddRows = False
        Me.dgTicket.AllowUserToDeleteRows = False
        Me.dgTicket.AllowUserToResizeColumns = False
        Me.dgTicket.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgTicket.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgTicket.AutoGenerateColumns = False
        Me.dgTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORDSRDataGridViewTextBoxColumn1, Me.NROTCK1, Me.CTPOATDataGridViewTextBoxColumn1, Me.SESDCMD1, Me.SESTRG1, Me.FCHCRTDataGridViewTextBoxColumn})
        Me.dgTicket.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dgTicket.DataMember = "dtTicket"
        Me.dgTicket.DataSource = Me.dstOServicio
        Me.dgTicket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTicket.Location = New System.Drawing.Point(0, 0)
        Me.dgTicket.MultiSelect = False
        Me.dgTicket.Name = "dgTicket"
        Me.dgTicket.ReadOnly = True
        Me.dgTicket.RowHeadersWidth = 20
        Me.dgTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTicket.Size = New System.Drawing.Size(614, 64)
        Me.dgTicket.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgTicket.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgTicket.TabIndex = 1
        '
        'NORDSRDataGridViewTextBoxColumn1
        '
        Me.NORDSRDataGridViewTextBoxColumn1.DataPropertyName = "NORDSR"
        Me.NORDSRDataGridViewTextBoxColumn1.HeaderText = "N° Orden"
        Me.NORDSRDataGridViewTextBoxColumn1.Name = "NORDSRDataGridViewTextBoxColumn1"
        Me.NORDSRDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NORDSRDataGridViewTextBoxColumn1.Visible = False
        Me.NORDSRDataGridViewTextBoxColumn1.Width = 80
        '
        'NROTCK1
        '
        Me.NROTCK1.DataPropertyName = "NROTCK"
        Me.NROTCK1.HeaderText = "N° Ticket"
        Me.NROTCK1.Name = "NROTCK1"
        Me.NROTCK1.ReadOnly = True
        Me.NROTCK1.Width = 80
        '
        'CTPOATDataGridViewTextBoxColumn1
        '
        Me.CTPOATDataGridViewTextBoxColumn1.DataPropertyName = "CTPOAT"
        Me.CTPOATDataGridViewTextBoxColumn1.HeaderText = "Tipo I/S"
        Me.CTPOATDataGridViewTextBoxColumn1.Name = "CTPOATDataGridViewTextBoxColumn1"
        Me.CTPOATDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CTPOATDataGridViewTextBoxColumn1.Width = 74
        '
        'SESDCMD1
        '
        Me.SESDCMD1.DataPropertyName = "SESDCM"
        Me.SESDCMD1.HeaderText = "Flag de Ticket"
        Me.SESDCMD1.Name = "SESDCMD1"
        Me.SESDCMD1.ReadOnly = True
        Me.SESDCMD1.Width = 106
        '
        'SESTRG1
        '
        Me.SESTRG1.DataPropertyName = "SESTRG"
        Me.SESTRG1.HeaderText = "Estado"
        Me.SESTRG1.Name = "SESTRG1"
        Me.SESTRG1.ReadOnly = True
        Me.SESTRG1.Width = 71
        '
        'FCHCRTDataGridViewTextBoxColumn
        '
        Me.FCHCRTDataGridViewTextBoxColumn.DataPropertyName = "FCHCRT"
        Me.FCHCRTDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FCHCRTDataGridViewTextBoxColumn.Name = "FCHCRTDataGridViewTextBoxColumn"
        Me.FCHCRTDataGridViewTextBoxColumn.ReadOnly = True
        Me.FCHCRTDataGridViewTextBoxColumn.Width = 66
        '
        'dstOServicio
        '
        Me.dstOServicio.DataSetName = "dstOServicio"
        Me.dstOServicio.Tables.AddRange(New System.Data.DataTable() {Me.dtServicio, Me.dtSolSeleccionado, Me.dtTicket1})
        '
        'dtServicio
        '
        Me.dtServicio.Columns.AddRange(New System.Data.DataColumn() {Me.MNORDSR, Me.MNCNTR, Me.MNAUTR, Me.MCMRCD, Me.MTMRCD2, Me.MFEMORS, Me.MQMRCD1, Me.MQPSMR1})
        Me.dtServicio.TableName = "dtServicio"
        '
        'MNORDSR
        '
        Me.MNORDSR.ColumnName = "NORDSR"
        Me.MNORDSR.DataType = GetType(Short)
        '
        'MNCNTR
        '
        Me.MNCNTR.ColumnName = "NCNTR"
        Me.MNCNTR.DataType = GetType(Short)
        '
        'MNAUTR
        '
        Me.MNAUTR.Caption = "NAUTR"
        Me.MNAUTR.ColumnName = "NAUTR"
        Me.MNAUTR.DataType = GetType(Short)
        '
        'MCMRCD
        '
        Me.MCMRCD.ColumnName = "CMRCD"
        '
        'MTMRCD2
        '
        Me.MTMRCD2.ColumnName = "TMRCD2"
        '
        'MFEMORS
        '
        Me.MFEMORS.ColumnName = "FEMORS"
        Me.MFEMORS.DataType = GetType(Short)
        '
        'MQMRCD1
        '
        Me.MQMRCD1.ColumnName = "QMRCD1"
        Me.MQMRCD1.DataType = GetType(Decimal)
        '
        'MQPSMR1
        '
        Me.MQPSMR1.ColumnName = "QPSMR1"
        Me.MQPSMR1.DataType = GetType(Decimal)
        '
        'dtSolSeleccionado
        '
        Me.dtSolSeleccionado.Columns.AddRange(New System.Data.DataColumn() {Me.MNSLCSR, Me.MCTPALM, Me.MCALMC, Me.MFRLZSR, Me.MNORDSR1, Me.DataColumn14})
        Me.dtSolSeleccionado.TableName = "dtSolSeleccionado"
        '
        'MNSLCSR
        '
        Me.MNSLCSR.ColumnName = "NSLCSR"
        Me.MNSLCSR.DataType = GetType(Short)
        '
        'MCTPALM
        '
        Me.MCTPALM.ColumnName = "CTPALM"
        '
        'MCALMC
        '
        Me.MCALMC.ColumnName = "CALMC"
        '
        'MFRLZSR
        '
        Me.MFRLZSR.ColumnName = "FRLZSR"
        Me.MFRLZSR.DataType = GetType(Short)
        '
        'MNORDSR1
        '
        Me.MNORDSR1.ColumnName = "NORDSR"
        Me.MNORDSR1.DataType = GetType(Short)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "CTPOAT"
        '
        'dtTicket1
        '
        Me.dtTicket1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn2, Me.DataColumn6})
        Me.dtTicket1.TableName = "dtTicket"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "NORDSR"
        Me.DataColumn1.DataType = GetType(Integer)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "NROTCK"
        Me.DataColumn3.DataType = GetType(Integer)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "SESDCM"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "CSRVNV"
        Me.DataColumn5.ColumnName = "SESTRG"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CTPOAT"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "FCHCRT"
        Me.DataColumn6.DataType = GetType(Date)
        '
        'hgTicketGenerado
        '
        Me.hgTicketGenerado.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsngrabar, Me.bsagenerar, Me.bsaEliminarServicio})
        Me.hgTicketGenerado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgTicketGenerado.HeaderVisibleSecondary = False
        Me.hgTicketGenerado.Location = New System.Drawing.Point(0, 273)
        Me.hgTicketGenerado.Name = "hgTicketGenerado"
        '
        'hgTicketGenerado.Panel
        '
        Me.hgTicketGenerado.Panel.Controls.Add(Me.dgvticket)
        Me.hgTicketGenerado.Size = New System.Drawing.Size(616, 214)
        Me.hgTicketGenerado.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgTicketGenerado.StateDisabled.HeaderPrimary.Content.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgTicketGenerado.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgTicketGenerado.TabIndex = 10
        Me.hgTicketGenerado.Text = "Ticket Generados"
        Me.hgTicketGenerado.ValuesPrimary.Description = ""
        Me.hgTicketGenerado.ValuesPrimary.Heading = "Ticket Generados"
        Me.hgTicketGenerado.ValuesPrimary.Image = Nothing
        Me.hgTicketGenerado.ValuesSecondary.Description = ""
        Me.hgTicketGenerado.ValuesSecondary.Heading = "Description"
        Me.hgTicketGenerado.ValuesSecondary.Image = Nothing
        '
        'bsngrabar
        '
        Me.bsngrabar.ExtraText = ""
        Me.bsngrabar.Image = CType(resources.GetObject("bsngrabar.Image"), System.Drawing.Image)
        Me.bsngrabar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsngrabar.Text = "Procesar Ticket"
        Me.bsngrabar.ToolTipImage = Nothing
        Me.bsngrabar.UniqueName = "D9570296A7494FF6D9570296A7494FF6"
        '
        'bsagenerar
        '
        Me.bsagenerar.ExtraText = ""
        Me.bsagenerar.Image = CType(resources.GetObject("bsagenerar.Image"), System.Drawing.Image)
        Me.bsagenerar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsagenerar.Text = "Generar Ticket"
        Me.bsagenerar.ToolTipImage = Nothing
        Me.bsagenerar.UniqueName = "7E0B3224E2E744E67E0B3224E2E744E6"
        '
        'bsaEliminarServicio
        '
        Me.bsaEliminarServicio.ExtraText = ""
        Me.bsaEliminarServicio.Image = CType(resources.GetObject("bsaEliminarServicio.Image"), System.Drawing.Image)
        Me.bsaEliminarServicio.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaEliminarServicio.Text = "Eliminar Servicio"
        Me.bsaEliminarServicio.ToolTipImage = Nothing
        Me.bsaEliminarServicio.UniqueName = "3EECFF4C4718468B3EECFF4C4718468B"
        '
        'dgvticket
        '
        Me.dgvticket.AllowUserToAddRows = False
        Me.dgvticket.AllowUserToDeleteRows = False
        Me.dgvticket.AllowUserToResizeColumns = False
        Me.dgvticket.AllowUserToResizeRows = False
        Me.dgvticket.AutoGenerateColumns = False
        Me.dgvticket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvticket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORDSR, Me.NSLCSRDataGridViewTextBoxColumn, Me.NROTCKDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.CSRVNVDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.FATNSRDataGridViewTextBoxColumn, Me.HORAINIDataGridViewTextBoxColumn, Me.HORAFINDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.NHRCALDataGridViewTextBoxColumn, Me.NHRFACDataGridViewTextBoxColumn, Me.OBSERDataGridViewTextBoxColumn})
        Me.dgvticket.DataMember = "dtTicket"
        Me.dgvticket.DataSource = Me.dstTicket
        Me.dgvticket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvticket.Location = New System.Drawing.Point(0, 0)
        Me.dgvticket.Name = "dgvticket"
        Me.dgvticket.Size = New System.Drawing.Size(614, 184)
        Me.dgvticket.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvticket.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgvticket.TabIndex = 8
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
        Me.NSLCSRDataGridViewTextBoxColumn.Width = 79
        '
        'NROTCKDataGridViewTextBoxColumn
        '
        Me.NROTCKDataGridViewTextBoxColumn.DataPropertyName = "NROTCK"
        Me.NROTCKDataGridViewTextBoxColumn.HeaderText = "NROTCK"
        Me.NROTCKDataGridViewTextBoxColumn.Name = "NROTCKDataGridViewTextBoxColumn"
        Me.NROTCKDataGridViewTextBoxColumn.Visible = False
        Me.NROTCKDataGridViewTextBoxColumn.Width = 81
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NCRRLT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NCRRLT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'CSRVNVDataGridViewTextBoxColumn
        '
        Me.CSRVNVDataGridViewTextBoxColumn.DataPropertyName = "CSRVNV"
        Me.CSRVNVDataGridViewTextBoxColumn.HeaderText = "Cod Serv"
        Me.CSRVNVDataGridViewTextBoxColumn.Name = "CSRVNVDataGridViewTextBoxColumn"
        Me.CSRVNVDataGridViewTextBoxColumn.Width = 81
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FENVSL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FENVSL"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 77
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FAUTR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FAUTR"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 72
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
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CTRSPT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CTRSPT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 79
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NDCMFC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NDCMFC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 81
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
        Me.dtTicket.Columns.AddRange(New System.Data.DataColumn() {Me.TNORDSR, Me.TNSLCSR, Me.TNROTCK, Me.TNCRRLT, Me.TCSRVNV, Me.TFENVSL, Me.TFAUTR, Me.TFATNSR, Me.THORAINI, Me.THORAFIN, Me.TCTRSPT, Me.TOBSER, Me.TNDCMFC, Me.DataColumn7, Me.DataColumn8})
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
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "NHRCAL"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "NHRFAC"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'hgGuiaSalida
        '
        Me.hgGuiaSalida.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgGuiaSalida.HeaderVisibleSecondary = False
        Me.hgGuiaSalida.Location = New System.Drawing.Point(0, 0)
        Me.hgGuiaSalida.Name = "hgGuiaSalida"
        '
        'hgGuiaSalida.Panel
        '
        Me.hgGuiaSalida.Panel.Controls.Add(Me.dgOrdenServicio)
        Me.hgGuiaSalida.Size = New System.Drawing.Size(616, 179)
        Me.hgGuiaSalida.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgGuiaSalida.TabIndex = 5
        Me.hgGuiaSalida.Text = "Orden de Servicio"
        Me.hgGuiaSalida.ValuesPrimary.Description = ""
        Me.hgGuiaSalida.ValuesPrimary.Heading = "Orden de Servicio"
        Me.hgGuiaSalida.ValuesPrimary.Image = Nothing
        Me.hgGuiaSalida.ValuesSecondary.Description = ""
        Me.hgGuiaSalida.ValuesSecondary.Heading = ""
        Me.hgGuiaSalida.ValuesSecondary.Image = Nothing
        '
        'dgOrdenServicio
        '
        Me.dgOrdenServicio.AllowUserToAddRows = False
        Me.dgOrdenServicio.AllowUserToDeleteRows = False
        Me.dgOrdenServicio.AllowUserToResizeColumns = False
        Me.dgOrdenServicio.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgOrdenServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgOrdenServicio.AutoGenerateColumns = False
        Me.dgOrdenServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgOrdenServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NORDSR, Me.M_NCNTR, Me.M_NAUTR, Me.M_CMRCD, Me.M_TMRCD2, Me.M_FEMORS, Me.M_QMRCD1, Me.M_QPSMR1})
        Me.dgOrdenServicio.DataMember = "dtServicio"
        Me.dgOrdenServicio.DataSource = Me.dstOServicio
        Me.dgOrdenServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrdenServicio.Location = New System.Drawing.Point(0, 0)
        Me.dgOrdenServicio.MultiSelect = False
        Me.dgOrdenServicio.Name = "dgOrdenServicio"
        Me.dgOrdenServicio.ReadOnly = True
        Me.dgOrdenServicio.RowHeadersWidth = 20
        Me.dgOrdenServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOrdenServicio.Size = New System.Drawing.Size(614, 160)
        Me.dgOrdenServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgOrdenServicio.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgOrdenServicio.TabIndex = 1
        '
        'M_NORDSR
        '
        Me.M_NORDSR.DataPropertyName = "NORDSR"
        Me.M_NORDSR.HeaderText = "Nro. Orden Servicio"
        Me.M_NORDSR.Name = "M_NORDSR"
        Me.M_NORDSR.ReadOnly = True
        Me.M_NORDSR.Width = 136
        '
        'M_NCNTR
        '
        Me.M_NCNTR.DataPropertyName = "NCNTR"
        Me.M_NCNTR.HeaderText = "Nro. Contrato"
        Me.M_NCNTR.Name = "M_NCNTR"
        Me.M_NCNTR.ReadOnly = True
        Me.M_NCNTR.Width = 107
        '
        'M_NAUTR
        '
        Me.M_NAUTR.DataPropertyName = "NAUTR"
        Me.M_NAUTR.HeaderText = "Nro. Autorización"
        Me.M_NAUTR.Name = "M_NAUTR"
        Me.M_NAUTR.ReadOnly = True
        Me.M_NAUTR.Width = 126
        '
        'M_CMRCD
        '
        Me.M_CMRCD.DataPropertyName = "CMRCD"
        Me.M_CMRCD.HeaderText = "Cod. Mercaderia"
        Me.M_CMRCD.Name = "M_CMRCD"
        Me.M_CMRCD.ReadOnly = True
        Me.M_CMRCD.Width = 120
        '
        'M_TMRCD2
        '
        Me.M_TMRCD2.DataPropertyName = "TMRCD2"
        Me.M_TMRCD2.HeaderText = "Descrip. Mercaderia"
        Me.M_TMRCD2.Name = "M_TMRCD2"
        Me.M_TMRCD2.ReadOnly = True
        Me.M_TMRCD2.Visible = False
        Me.M_TMRCD2.Width = 131
        '
        'M_FEMORS
        '
        Me.M_FEMORS.DataPropertyName = "FEMORS"
        Me.M_FEMORS.HeaderText = "Fech. Emis. Mercaderia"
        Me.M_FEMORS.Name = "M_FEMORS"
        Me.M_FEMORS.ReadOnly = True
        Me.M_FEMORS.Width = 152
        '
        'M_QMRCD1
        '
        Me.M_QMRCD1.DataPropertyName = "QMRCD1"
        Me.M_QMRCD1.HeaderText = "Cant. Merca. Declarada"
        Me.M_QMRCD1.Name = "M_QMRCD1"
        Me.M_QMRCD1.ReadOnly = True
        Me.M_QMRCD1.Width = 154
        '
        'M_QPSMR1
        '
        Me.M_QPSMR1.DataPropertyName = "QPSMR1"
        Me.M_QPSMR1.HeaderText = "Peso Merc. Declarada"
        Me.M_QPSMR1.Name = "M_QPSMR1"
        Me.M_QPSMR1.ReadOnly = True
        Me.M_QPSMR1.Width = 145
        '
        'hgVisorPrevia
        '
        Me.hgVisorPrevia.Dock = System.Windows.Forms.DockStyle.Right
        Me.hgVisorPrevia.HeaderVisibleSecondary = False
        Me.hgVisorPrevia.Location = New System.Drawing.Point(284, 125)
        Me.hgVisorPrevia.Name = "hgVisorPrevia"
        '
        'hgVisorPrevia.Panel
        '
        Me.hgVisorPrevia.Panel.Controls.Add(Me.pcxEspera)
        Me.hgVisorPrevia.Panel.Controls.Add(Me.pbxReducir)
        Me.hgVisorPrevia.Panel.Controls.Add(Me.pbxAmpliar)
        Me.hgVisorPrevia.Panel.Controls.Add(Me.VisorReportesCrystal)
        Me.hgVisorPrevia.Size = New System.Drawing.Size(659, 487)
        Me.hgVisorPrevia.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgVisorPrevia.TabIndex = 6
        Me.hgVisorPrevia.Text = "Vista Previa"
        Me.hgVisorPrevia.ValuesPrimary.Description = ""
        Me.hgVisorPrevia.ValuesPrimary.Heading = "Vista Previa"
        Me.hgVisorPrevia.ValuesPrimary.Image = Nothing
        Me.hgVisorPrevia.ValuesSecondary.Description = ""
        Me.hgVisorPrevia.ValuesSecondary.Heading = "Description"
        Me.hgVisorPrevia.ValuesSecondary.Image = Nothing
        '
        'pcxEspera
        '
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(195, 255)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 46
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'pbxReducir
        '
        Me.pbxReducir.ErrorImage = Nothing
        Me.pbxReducir.Image = CType(resources.GetObject("pbxReducir.Image"), System.Drawing.Image)
        Me.pbxReducir.InitialImage = Nothing
        Me.pbxReducir.Location = New System.Drawing.Point(368, 3)
        Me.pbxReducir.Name = "pbxReducir"
        Me.pbxReducir.Size = New System.Drawing.Size(16, 16)
        Me.pbxReducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxReducir.TabIndex = 45
        Me.pbxReducir.TabStop = False
        Me.pbxReducir.Visible = False
        '
        'pbxAmpliar
        '
        Me.pbxAmpliar.ErrorImage = Nothing
        Me.pbxAmpliar.Image = CType(resources.GetObject("pbxAmpliar.Image"), System.Drawing.Image)
        Me.pbxAmpliar.InitialImage = Nothing
        Me.pbxAmpliar.Location = New System.Drawing.Point(390, 3)
        Me.pbxAmpliar.Name = "pbxAmpliar"
        Me.pbxAmpliar.Size = New System.Drawing.Size(16, 16)
        Me.pbxAmpliar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxAmpliar.TabIndex = 44
        Me.pbxAmpliar.TabStop = False
        Me.pbxAmpliar.Visible = False
        '
        'VisorReportesCrystal
        '
        Me.VisorReportesCrystal.ActiveViewIndex = -1
        Me.VisorReportesCrystal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisorReportesCrystal.DisplayGroupTree = False
        Me.VisorReportesCrystal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisorReportesCrystal.Location = New System.Drawing.Point(0, 0)
        Me.VisorReportesCrystal.Name = "VisorReportesCrystal"
        Me.VisorReportesCrystal.SelectionFormula = ""
        Me.VisorReportesCrystal.Size = New System.Drawing.Size(657, 468)
        Me.VisorReportesCrystal.TabIndex = 0
        Me.VisorReportesCrystal.ViewTimeSelectionFormula = ""
        Me.VisorReportesCrystal.Visible = False
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbEstado)
        Me.khgFiltros.Panel.Controls.Add(Me.lblcodcliente)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroOrdServicio)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.lblNroGuiaSalida)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Size = New System.Drawing.Size(943, 125)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 4
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
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
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(79, 71)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(46, 19)
        Me.KryptonLabel2.TabIndex = 45
        Me.KryptonLabel2.Text = "Estado:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Estado:"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownWidth = 100
        Me.cmbEstado.FormattingEnabled = False
        Me.cmbEstado.ItemHeight = 13
        Me.cmbEstado.Location = New System.Drawing.Point(133, 69)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(116, 21)
        Me.cmbEstado.TabIndex = 44
        '
        'lblcodcliente
        '
        Me.lblcodcliente.Location = New System.Drawing.Point(87, 16)
        Me.lblcodcliente.Name = "lblcodcliente"
        Me.lblcodcliente.Size = New System.Drawing.Size(16, 19)
        Me.lblcodcliente.TabIndex = 42
        Me.lblcodcliente.Text = "0"
        Me.lblcodcliente.Values.ExtraText = ""
        Me.lblcodcliente.Values.Image = Nothing
        Me.lblcodcliente.Values.Text = "0"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(851, 3)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(79, 77)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 40
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'txtNroOrdServicio
        '
        Me.txtNroOrdServicio.Location = New System.Drawing.Point(133, 40)
        Me.txtNroOrdServicio.Name = "txtNroOrdServicio"
        Me.txtNroOrdServicio.Size = New System.Drawing.Size(231, 21)
        Me.txtNroOrdServicio.TabIndex = 5
        '
        'txtCliente
        '
        Me.txtCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaClienteListar})
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(132, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(232, 21)
        Me.txtCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.TabIndex = 2
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
        'lblNroGuiaSalida
        '
        Me.lblNroGuiaSalida.Location = New System.Drawing.Point(11, 40)
        Me.lblNroGuiaSalida.Name = "lblNroGuiaSalida"
        Me.lblNroGuiaSalida.Size = New System.Drawing.Size(114, 19)
        Me.lblNroGuiaSalida.TabIndex = 4
        Me.lblNroGuiaSalida.Text = "Nro. Orden Servicio : "
        Me.lblNroGuiaSalida.Values.ExtraText = ""
        Me.lblNroGuiaSalida.Values.Image = Nothing
        Me.lblNroGuiaSalida.Values.Text = "Nro. Orden Servicio : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 1
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
        'bgwGifAnimado
        '
        '
        'frmSDSWIngOServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 612)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmSDSWIngOServicio"
        Me.Text = "Ingreso Orden de Servicio - Guía Entrada"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel4.ResumeLayout(False)
        CType(Me.hgTicketSolicitados.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgTicketSolicitados.Panel.ResumeLayout(False)
        CType(Me.hgTicketSolicitados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgTicketSolicitados.ResumeLayout(False)
        CType(Me.dgTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstOServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSolSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTicket1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgTicketGenerado.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgTicketGenerado.Panel.ResumeLayout(False)
        CType(Me.hgTicketGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgTicketGenerado.ResumeLayout(False)
        CType(Me.dgvticket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgGuiaSalida.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaSalida.Panel.ResumeLayout(False)
        CType(Me.hgGuiaSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaSalida.ResumeLayout(False)
        CType(Me.dgOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgVisorPrevia.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgVisorPrevia.Panel.ResumeLayout(False)
        Me.hgVisorPrevia.Panel.PerformLayout()
        CType(Me.hgVisorPrevia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgVisorPrevia.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxReducir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAmpliar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNroOrdServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaClienteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblNroGuiaSalida As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents hgGuiaSalida As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgVisorPrevia As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents pbxReducir As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAmpliar As System.Windows.Forms.PictureBox
    Friend WithEvents VisorReportesCrystal As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dstOServicio As System.Data.DataSet
    Friend WithEvents dtServicio As System.Data.DataTable
    Friend WithEvents MNORDSR As System.Data.DataColumn
    Friend WithEvents MNCNTR As System.Data.DataColumn
    Friend WithEvents MNAUTR As System.Data.DataColumn
    Friend WithEvents MCMRCD As System.Data.DataColumn
    Friend WithEvents MTMRCD2 As System.Data.DataColumn
    Friend WithEvents MFEMORS As System.Data.DataColumn
    Friend WithEvents MQMRCD1 As System.Data.DataColumn
    Friend WithEvents MQPSMR1 As System.Data.DataColumn
    Friend WithEvents dtSolSeleccionado As System.Data.DataTable
    Friend WithEvents MNSLCSR As System.Data.DataColumn
    Friend WithEvents MCTPALM As System.Data.DataColumn
    Friend WithEvents MCALMC As System.Data.DataColumn
    Friend WithEvents MFRLZSR As System.Data.DataColumn
    Friend WithEvents MNORDSR1 As System.Data.DataColumn
    Friend WithEvents KryptonPanel4 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dgvticket As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgTicketGenerado As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsngrabar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents bsagenerar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents M_NSLCSR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NROTCK1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRLTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FENVSLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FAUTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTRSPTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCMFCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESDCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtTicket1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents bsaEliminarServicio As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents hgTicketSolicitados As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaanular As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaVistaPreviaT As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgTicket As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents lblcodcliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents M_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FEMORS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QMRCD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QPSMR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORDSRDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROTCK1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPOATDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESDCMD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCHCRTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSLCSRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROTCKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSRVNVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FATNSRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAINIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAFINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NHRCALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NHRFACDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsaCerrarTicket As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cmbEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
