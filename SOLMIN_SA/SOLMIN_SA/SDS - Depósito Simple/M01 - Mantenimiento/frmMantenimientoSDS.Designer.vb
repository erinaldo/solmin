<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoSDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoSDS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.splitHorizontal = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.splitVertical = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.hgFamilia = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaAdministrarFamilia = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgFamilias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.F_CFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_TFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.F_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstMercaderia = New System.Data.DataSet
        Me.dtFamilia = New System.Data.DataTable
        Me.FCFMCLR = New System.Data.DataColumn
        Me.FTFMCLR = New System.Data.DataColumn
        Me.FSESTRG = New System.Data.DataColumn
        Me.FSITUAC = New System.Data.DataColumn
        Me.dtGrupo = New System.Data.DataTable
        Me.GCGRCLR = New System.Data.DataColumn
        Me.GTGRCLR = New System.Data.DataColumn
        Me.GSESTRG = New System.Data.DataColumn
        Me.GSITUAC = New System.Data.DataColumn
        Me.dtMercaderia = New System.Data.DataTable
        Me.MCMRCLR = New System.Data.DataColumn
        Me.MTMRCD2 = New System.Data.DataColumn
        Me.MCMRCD = New System.Data.DataColumn
        Me.MFPUWEB = New System.Data.DataColumn
        Me.MIMVTA = New System.Data.DataColumn
        Me.MIMVTAS = New System.Data.DataColumn
        Me.MTMRCTR = New System.Data.DataColumn
        Me.MFVNCMR = New System.Data.DataColumn
        Me.MFINVRN = New System.Data.DataColumn
        Me.MCPTDAR = New System.Data.DataColumn
        Me.MSESTRG = New System.Data.DataColumn
        Me.MSITUAC = New System.Data.DataColumn
        Me.hgGrupo = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaAdministrarGrupo = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgGrupos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.G_CGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.G_TGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.G_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.G_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tcMercaderia = New System.Windows.Forms.TabControl
        Me.tpMercaderia = New System.Windows.Forms.TabPage
        Me.dgMercaderia = New Ransa.Controls.Mercaderia.ucMercaderia_DgF01
        Me.tpOrdenServicio = New System.Windows.Forms.TabPage
        Me.dgSolicOrdenServicio = New Ransa.Controls.OrdenServicio.ucSolicOrdenServicios_DgF01
        Me.dgOrdenServicio = New Ransa.Controls.OrdenServicio.ucOrdenServicios_DgF01
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonMaskedTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFechaVencimiento = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblMercadaeria = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.CacheducMercaderia_DgF01A1 = New Ransa.Rpt.Mercaderia.CacheducMercaderia_DgF01A
        Me.bgwOrdenServicio = New System.ComponentModel.BackgroundWorker
        Me.bgwSolicOrdServ = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.splitHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitHorizontal.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitHorizontal.Panel1.SuspendLayout()
        CType(Me.splitHorizontal.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitHorizontal.Panel2.SuspendLayout()
        Me.splitHorizontal.SuspendLayout()
        CType(Me.splitVertical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitVertical.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitVertical.Panel1.SuspendLayout()
        CType(Me.splitVertical.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitVertical.Panel2.SuspendLayout()
        Me.splitVertical.SuspendLayout()
        CType(Me.hgFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFamilia.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFamilia.Panel.SuspendLayout()
        Me.hgFamilia.SuspendLayout()
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGrupo.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgGrupo.Panel.SuspendLayout()
        Me.hgGrupo.SuspendLayout()
        CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcMercaderia.SuspendLayout()
        Me.tpMercaderia.SuspendLayout()
        Me.tpOrdenServicio.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.splitHorizontal)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(986, 585)
        Me.KryptonPanel.TabIndex = 0
        '
        'splitHorizontal
        '
        Me.splitHorizontal.Cursor = System.Windows.Forms.Cursors.Default
        Me.splitHorizontal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitHorizontal.Location = New System.Drawing.Point(0, 122)
        Me.splitHorizontal.Name = "splitHorizontal"
        Me.splitHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitHorizontal.Panel1
        '
        Me.splitHorizontal.Panel1.Controls.Add(Me.splitVertical)
        '
        'splitHorizontal.Panel2
        '
        Me.splitHorizontal.Panel2.Controls.Add(Me.tcMercaderia)
        Me.splitHorizontal.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.splitHorizontal.Size = New System.Drawing.Size(986, 463)
        Me.splitHorizontal.SplitterDistance = 220
        Me.splitHorizontal.TabIndex = 5
        '
        'splitVertical
        '
        Me.splitVertical.Cursor = System.Windows.Forms.Cursors.Default
        Me.splitVertical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitVertical.Location = New System.Drawing.Point(0, 0)
        Me.splitVertical.Name = "splitVertical"
        '
        'splitVertical.Panel1
        '
        Me.splitVertical.Panel1.Controls.Add(Me.hgFamilia)
        '
        'splitVertical.Panel2
        '
        Me.splitVertical.Panel2.Controls.Add(Me.hgGrupo)
        Me.splitVertical.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.splitVertical.Size = New System.Drawing.Size(986, 220)
        Me.splitVertical.SplitterDistance = 489
        Me.splitVertical.TabIndex = 0
        '
        'hgFamilia
        '
        Me.hgFamilia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaAdministrarFamilia})
        Me.hgFamilia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgFamilia.HeaderVisibleSecondary = False
        Me.hgFamilia.Location = New System.Drawing.Point(0, 0)
        Me.hgFamilia.Name = "hgFamilia"
        '
        'hgFamilia.Panel
        '
        Me.hgFamilia.Panel.Controls.Add(Me.dgFamilias)
        Me.hgFamilia.Size = New System.Drawing.Size(489, 220)
        Me.hgFamilia.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.hgFamilia.TabIndex = 11
        Me.hgFamilia.Text = "Familia"
        Me.hgFamilia.ValuesPrimary.Description = ""
        Me.hgFamilia.ValuesPrimary.Heading = "Familia"
        Me.hgFamilia.ValuesPrimary.Image = CType(resources.GetObject("hgFamilia.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgFamilia.ValuesSecondary.Description = ""
        Me.hgFamilia.ValuesSecondary.Heading = ""
        Me.hgFamilia.ValuesSecondary.Image = Nothing
        '
        'bsaAdministrarFamilia
        '
        Me.bsaAdministrarFamilia.ExtraText = ""
        Me.bsaAdministrarFamilia.Image = CType(resources.GetObject("bsaAdministrarFamilia.Image"), System.Drawing.Image)
        Me.bsaAdministrarFamilia.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaAdministrarFamilia.Text = "Mantenimiento"
        Me.bsaAdministrarFamilia.ToolTipImage = Nothing
        Me.bsaAdministrarFamilia.UniqueName = "0FE8561499444CFE0FE8561499444CFE"
        '
        'dgFamilias
        '
        Me.dgFamilias.AllowUserToAddRows = False
        Me.dgFamilias.AllowUserToDeleteRows = False
        Me.dgFamilias.AllowUserToResizeColumns = False
        Me.dgFamilias.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgFamilias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgFamilias.AutoGenerateColumns = False
        Me.dgFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgFamilias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.F_CFMCLR, Me.F_TFMCLR, Me.F_SESTRG, Me.F_SITUAC})
        Me.dgFamilias.DataMember = "dtFamilia"
        Me.dgFamilias.DataSource = Me.dstMercaderia
        Me.dgFamilias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFamilias.Location = New System.Drawing.Point(0, 0)
        Me.dgFamilias.MultiSelect = False
        Me.dgFamilias.Name = "dgFamilias"
        Me.dgFamilias.ReadOnly = True
        Me.dgFamilias.RowHeadersWidth = 20
        Me.dgFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFamilias.Size = New System.Drawing.Size(487, 191)
        Me.dgFamilias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgFamilias.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgFamilias.TabIndex = 12
        '
        'F_CFMCLR
        '
        Me.F_CFMCLR.DataPropertyName = "CFMCLR"
        Me.F_CFMCLR.HeaderText = "Familia"
        Me.F_CFMCLR.Name = "F_CFMCLR"
        Me.F_CFMCLR.ReadOnly = True
        Me.F_CFMCLR.Width = 68
        '
        'F_TFMCLR
        '
        Me.F_TFMCLR.DataPropertyName = "TFMCLR"
        Me.F_TFMCLR.HeaderText = "Descripción"
        Me.F_TFMCLR.Name = "F_TFMCLR"
        Me.F_TFMCLR.ReadOnly = True
        Me.F_TFMCLR.Width = 92
        '
        'F_SESTRG
        '
        Me.F_SESTRG.DataPropertyName = "SESTRG"
        Me.F_SESTRG.HeaderText = "Situación"
        Me.F_SESTRG.Name = "F_SESTRG"
        Me.F_SESTRG.ReadOnly = True
        Me.F_SESTRG.Visible = False
        Me.F_SESTRG.Width = 80
        '
        'F_SITUAC
        '
        Me.F_SITUAC.DataPropertyName = "SITUAC"
        Me.F_SITUAC.HeaderText = "Situación"
        Me.F_SITUAC.Name = "F_SITUAC"
        Me.F_SITUAC.ReadOnly = True
        Me.F_SITUAC.Width = 80
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtFamilia, Me.dtGrupo, Me.dtMercaderia})
        '
        'dtFamilia
        '
        Me.dtFamilia.Columns.AddRange(New System.Data.DataColumn() {Me.FCFMCLR, Me.FTFMCLR, Me.FSESTRG, Me.FSITUAC})
        Me.dtFamilia.TableName = "dtFamilia"
        '
        'FCFMCLR
        '
        Me.FCFMCLR.ColumnName = "CFMCLR"
        '
        'FTFMCLR
        '
        Me.FTFMCLR.ColumnName = "TFMCLR"
        '
        'FSESTRG
        '
        Me.FSESTRG.ColumnName = "SESTRG"
        '
        'FSITUAC
        '
        Me.FSITUAC.ColumnName = "SITUAC"
        '
        'dtGrupo
        '
        Me.dtGrupo.Columns.AddRange(New System.Data.DataColumn() {Me.GCGRCLR, Me.GTGRCLR, Me.GSESTRG, Me.GSITUAC})
        Me.dtGrupo.TableName = "dtGrupo"
        '
        'GCGRCLR
        '
        Me.GCGRCLR.ColumnName = "CGRCLR"
        '
        'GTGRCLR
        '
        Me.GTGRCLR.ColumnName = "TGRCLR"
        '
        'GSESTRG
        '
        Me.GSESTRG.ColumnName = "SESTRG"
        '
        'GSITUAC
        '
        Me.GSITUAC.ColumnName = "SITUAC"
        '
        'dtMercaderia
        '
        Me.dtMercaderia.Columns.AddRange(New System.Data.DataColumn() {Me.MCMRCLR, Me.MTMRCD2, Me.MCMRCD, Me.MFPUWEB, Me.MIMVTA, Me.MIMVTAS, Me.MTMRCTR, Me.MFVNCMR, Me.MFINVRN, Me.MCPTDAR, Me.MSESTRG, Me.MSITUAC})
        Me.dtMercaderia.TableName = "dtMercaderia"
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
        'MFPUWEB
        '
        Me.MFPUWEB.ColumnName = "FPUWEB"
        Me.MFPUWEB.DefaultValue = "N"
        '
        'MIMVTA
        '
        Me.MIMVTA.ColumnName = "IMVTA$"
        Me.MIMVTA.DataType = GetType(Decimal)
        '
        'MIMVTAS
        '
        Me.MIMVTAS.ColumnName = "IMVTAS"
        Me.MIMVTAS.DataType = GetType(Decimal)
        '
        'MTMRCTR
        '
        Me.MTMRCTR.ColumnName = "TMRCTR"
        '
        'MFVNCMR
        '
        Me.MFVNCMR.ColumnName = "FVNCMR"
        Me.MFVNCMR.DataType = GetType(Date)
        '
        'MFINVRN
        '
        Me.MFINVRN.ColumnName = "FINVRN"
        '
        'MCPTDAR
        '
        Me.MCPTDAR.ColumnName = "CPTDAR"
        Me.MCPTDAR.DefaultValue = ""
        '
        'MSESTRG
        '
        Me.MSESTRG.ColumnName = "SESTRG"
        Me.MSESTRG.DefaultValue = ""
        '
        'MSITUAC
        '
        Me.MSITUAC.ColumnName = "SITUAC"
        Me.MSITUAC.DefaultValue = ""
        '
        'hgGrupo
        '
        Me.hgGrupo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaAdministrarGrupo})
        Me.hgGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgGrupo.HeaderVisibleSecondary = False
        Me.hgGrupo.Location = New System.Drawing.Point(0, 0)
        Me.hgGrupo.Name = "hgGrupo"
        '
        'hgGrupo.Panel
        '
        Me.hgGrupo.Panel.Controls.Add(Me.dgGrupos)
        Me.hgGrupo.Size = New System.Drawing.Size(492, 220)
        Me.hgGrupo.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.hgGrupo.TabIndex = 13
        Me.hgGrupo.Text = "Grupo"
        Me.hgGrupo.ValuesPrimary.Description = ""
        Me.hgGrupo.ValuesPrimary.Heading = "Grupo"
        Me.hgGrupo.ValuesPrimary.Image = CType(resources.GetObject("hgGrupo.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgGrupo.ValuesSecondary.Description = ""
        Me.hgGrupo.ValuesSecondary.Heading = "Description"
        Me.hgGrupo.ValuesSecondary.Image = Nothing
        '
        'bsaAdministrarGrupo
        '
        Me.bsaAdministrarGrupo.ExtraText = ""
        Me.bsaAdministrarGrupo.Image = CType(resources.GetObject("bsaAdministrarGrupo.Image"), System.Drawing.Image)
        Me.bsaAdministrarGrupo.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaAdministrarGrupo.Text = "Mantenimiento"
        Me.bsaAdministrarGrupo.ToolTipImage = Nothing
        Me.bsaAdministrarGrupo.UniqueName = "27A37BFB475B4E7527A37BFB475B4E75"
        '
        'dgGrupos
        '
        Me.dgGrupos.AllowUserToAddRows = False
        Me.dgGrupos.AllowUserToDeleteRows = False
        Me.dgGrupos.AllowUserToResizeColumns = False
        Me.dgGrupos.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgGrupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgGrupos.AutoGenerateColumns = False
        Me.dgGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.G_CGRCLR, Me.G_TGRCLR, Me.G_SESTRG, Me.G_SITUAC})
        Me.dgGrupos.DataMember = "dtGrupo"
        Me.dgGrupos.DataSource = Me.dstMercaderia
        Me.dgGrupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGrupos.Location = New System.Drawing.Point(0, 0)
        Me.dgGrupos.MultiSelect = False
        Me.dgGrupos.Name = "dgGrupos"
        Me.dgGrupos.ReadOnly = True
        Me.dgGrupos.RowHeadersWidth = 20
        Me.dgGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGrupos.Size = New System.Drawing.Size(490, 191)
        Me.dgGrupos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGrupos.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgGrupos.TabIndex = 14
        '
        'G_CGRCLR
        '
        Me.G_CGRCLR.DataPropertyName = "CGRCLR"
        Me.G_CGRCLR.HeaderText = "Grupo"
        Me.G_CGRCLR.Name = "G_CGRCLR"
        Me.G_CGRCLR.ReadOnly = True
        Me.G_CGRCLR.Width = 65
        '
        'G_TGRCLR
        '
        Me.G_TGRCLR.DataPropertyName = "TGRCLR"
        Me.G_TGRCLR.HeaderText = "Descripción"
        Me.G_TGRCLR.Name = "G_TGRCLR"
        Me.G_TGRCLR.ReadOnly = True
        Me.G_TGRCLR.Width = 92
        '
        'G_SESTRG
        '
        Me.G_SESTRG.DataPropertyName = "SESTRG"
        Me.G_SESTRG.HeaderText = "Situación"
        Me.G_SESTRG.Name = "G_SESTRG"
        Me.G_SESTRG.ReadOnly = True
        Me.G_SESTRG.Visible = False
        Me.G_SESTRG.Width = 80
        '
        'G_SITUAC
        '
        Me.G_SITUAC.DataPropertyName = "SITUAC"
        Me.G_SITUAC.HeaderText = "Situación"
        Me.G_SITUAC.Name = "G_SITUAC"
        Me.G_SITUAC.ReadOnly = True
        Me.G_SITUAC.Width = 80
        '
        'tcMercaderia
        '
        Me.tcMercaderia.Controls.Add(Me.tpMercaderia)
        Me.tcMercaderia.Controls.Add(Me.tpOrdenServicio)
        Me.tcMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tcMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.tcMercaderia.Multiline = True
        Me.tcMercaderia.Name = "tcMercaderia"
        Me.tcMercaderia.SelectedIndex = 0
        Me.tcMercaderia.Size = New System.Drawing.Size(986, 238)
        Me.tcMercaderia.TabIndex = 1
        '
        'tpMercaderia
        '
        Me.tpMercaderia.Controls.Add(Me.dgMercaderia)
        Me.tpMercaderia.Location = New System.Drawing.Point(4, 25)
        Me.tpMercaderia.Name = "tpMercaderia"
        Me.tpMercaderia.Size = New System.Drawing.Size(978, 209)
        Me.tpMercaderia.TabIndex = 0
        Me.tpMercaderia.Text = "Listado"
        Me.tpMercaderia.UseVisualStyleBackColor = True
        '
        'dgMercaderia
        '
        Me.dgMercaderia.BackColor = System.Drawing.Color.Transparent
        Me.dgMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgMercaderia.Name = "dgMercaderia"
        Me.dgMercaderia.pMostrarBotonesGestion = True
        Me.dgMercaderia.pMostrarBotonReporte = True
        Me.dgMercaderia.pMostrarFmtCatalogo = False
        Me.dgMercaderia.pNroRegPorPagina = 300
        Me.dgMercaderia.Size = New System.Drawing.Size(978, 209)
        Me.dgMercaderia.TabIndex = 0
        '
        'tpOrdenServicio
        '
        Me.tpOrdenServicio.Controls.Add(Me.dgSolicOrdenServicio)
        Me.tpOrdenServicio.Controls.Add(Me.dgOrdenServicio)
        Me.tpOrdenServicio.Location = New System.Drawing.Point(4, 25)
        Me.tpOrdenServicio.Name = "tpOrdenServicio"
        Me.tpOrdenServicio.Size = New System.Drawing.Size(978, 209)
        Me.tpOrdenServicio.TabIndex = 1
        Me.tpOrdenServicio.Text = "Orden Servicio"
        Me.tpOrdenServicio.UseVisualStyleBackColor = True
        '
        'dgSolicOrdenServicio
        '
        Me.dgSolicOrdenServicio.BackColor = System.Drawing.Color.Transparent
        Me.dgSolicOrdenServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSolicOrdenServicio.Location = New System.Drawing.Point(0, 133)
        Me.dgSolicOrdenServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dgSolicOrdenServicio.Name = "dgSolicOrdenServicio"
        Me.dgSolicOrdenServicio.Size = New System.Drawing.Size(978, 76)
        Me.dgSolicOrdenServicio.TabIndex = 0
        '
        'dgOrdenServicio
        '
        Me.dgOrdenServicio.BackColor = System.Drawing.Color.Transparent
        Me.dgOrdenServicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgOrdenServicio.Location = New System.Drawing.Point(0, 0)
        Me.dgOrdenServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dgOrdenServicio.Name = "dgOrdenServicio"
        Me.dgOrdenServicio.Size = New System.Drawing.Size(978, 133)
        Me.dgOrdenServicio.TabIndex = 0
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
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonMaskedTextBox1)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgFiltros.Panel.Controls.Add(Me.txtFechaVencimiento)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonTextBox1)
        Me.hgFiltros.Panel.Controls.Add(Me.lblMercadaeria)
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
        Me.txtCliente.Location = New System.Drawing.Point(86, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.Size = New System.Drawing.Size(278, 19)
        Me.txtCliente.TabIndex = 3
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(175, 66)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(101, 16)
        Me.KryptonLabel2.TabIndex = 8
        Me.KryptonLabel2.Text = "Fecha Inventario : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha Inventario : "
        Me.KryptonLabel2.Visible = False
        '
        'KryptonMaskedTextBox1
        '
        Me.KryptonMaskedTextBox1.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.KryptonMaskedTextBox1.Location = New System.Drawing.Point(282, 63)
        Me.KryptonMaskedTextBox1.Mask = "##/##/####"
        Me.KryptonMaskedTextBox1.Name = "KryptonMaskedTextBox1"
        Me.KryptonMaskedTextBox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.KryptonMaskedTextBox1.Size = New System.Drawing.Size(82, 19)
        Me.KryptonMaskedTextBox1.TabIndex = 9
        Me.KryptonMaskedTextBox1.Text = "  /  /"
        Me.KryptonMaskedTextBox1.Visible = False
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(7, 66)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(77, 16)
        Me.KryptonLabel4.TabIndex = 6
        Me.KryptonLabel4.Text = "Fecha Vcto. : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha Vcto. : "
        Me.KryptonLabel4.Visible = False
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(86, 63)
        Me.txtFechaVencimiento.Mask = "##/##/####"
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(82, 19)
        Me.txtFechaVencimiento.TabIndex = 7
        Me.txtFechaVencimiento.Text = "  /  /"
        Me.txtFechaVencimiento.Visible = False
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.Location = New System.Drawing.Point(86, 38)
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(278, 19)
        Me.KryptonTextBox1.TabIndex = 5
        Me.KryptonTextBox1.Visible = False
        '
        'lblMercadaeria
        '
        Me.lblMercadaeria.Location = New System.Drawing.Point(7, 41)
        Me.lblMercadaeria.Name = "lblMercadaeria"
        Me.lblMercadaeria.Size = New System.Drawing.Size(73, 16)
        Me.lblMercadaeria.TabIndex = 4
        Me.lblMercadaeria.Text = "Mercadería : "
        Me.lblMercadaeria.Values.ExtraText = ""
        Me.lblMercadaeria.Values.Image = Nothing
        Me.lblMercadaeria.Values.Text = "Mercadería : "
        Me.lblMercadaeria.Visible = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(905, 13)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 72)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 10
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
        'frmMantenimientoSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 585)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMantenimientoSDS"
        Me.Text = "Mantenimiento"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.splitHorizontal.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitHorizontal.Panel1.ResumeLayout(False)
        CType(Me.splitHorizontal.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitHorizontal.Panel2.ResumeLayout(False)
        CType(Me.splitHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitHorizontal.ResumeLayout(False)
        CType(Me.splitVertical.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitVertical.Panel1.ResumeLayout(False)
        CType(Me.splitVertical.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitVertical.Panel2.ResumeLayout(False)
        CType(Me.splitVertical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitVertical.ResumeLayout(False)
        CType(Me.hgFamilia.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFamilia.Panel.ResumeLayout(False)
        CType(Me.hgFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFamilia.ResumeLayout(False)
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgGrupo.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGrupo.Panel.ResumeLayout(False)
        CType(Me.hgGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGrupo.ResumeLayout(False)
        CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcMercaderia.ResumeLayout(False)
        Me.tpMercaderia.ResumeLayout(False)
        Me.tpOrdenServicio.ResumeLayout(False)
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
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
    Friend WithEvents splitHorizontal As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents splitVertical As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents hgFamilia As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents hgGrupo As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblMercadaeria As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFechaVencimiento As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents bsaAdministrarGrupo As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgFamilias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgGrupos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dstMercaderia As System.Data.DataSet
    Friend WithEvents dtFamilia As System.Data.DataTable
    Friend WithEvents FCFMCLR As System.Data.DataColumn
    Friend WithEvents FTFMCLR As System.Data.DataColumn
    Friend WithEvents dtGrupo As System.Data.DataTable
    Friend WithEvents GCGRCLR As System.Data.DataColumn
    Friend WithEvents GTGRCLR As System.Data.DataColumn
    Friend WithEvents dtMercaderia As System.Data.DataTable
    Friend WithEvents MCMRCLR As System.Data.DataColumn
    Friend WithEvents MTMRCD2 As System.Data.DataColumn
    Friend WithEvents MCMRCD As System.Data.DataColumn
    Friend WithEvents MFPUWEB As System.Data.DataColumn
    Friend WithEvents MIMVTA As System.Data.DataColumn
    Friend WithEvents MIMVTAS As System.Data.DataColumn
    Friend WithEvents MTMRCTR As System.Data.DataColumn
    Friend WithEvents MFVNCMR As System.Data.DataColumn
    Friend WithEvents FSESTRG As System.Data.DataColumn
    Friend WithEvents GSESTRG As System.Data.DataColumn
    Friend WithEvents bsaAdministrarFamilia As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents FSITUAC As System.Data.DataColumn
    Friend WithEvents F_CFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_TFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSITUAC As System.Data.DataColumn
    Friend WithEvents G_CGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G_TGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MFINVRN As System.Data.DataColumn
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonMaskedTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents MCPTDAR As System.Data.DataColumn
    Friend WithEvents MSESTRG As System.Data.DataColumn
    Friend WithEvents MSITUAC As System.Data.DataColumn
    Friend WithEvents dgMercaderia As Ransa.Controls.Mercaderia.ucMercaderia_DgF01
    Friend WithEvents tcMercaderia As System.Windows.Forms.TabControl
    Friend WithEvents tpMercaderia As System.Windows.Forms.TabPage
    Friend WithEvents tpOrdenServicio As System.Windows.Forms.TabPage
    Friend WithEvents dgOrdenServicio As Ransa.Controls.OrdenServicio.ucOrdenServicios_DgF01
    Friend WithEvents dgSolicOrdenServicio As Ransa.Controls.OrdenServicio.ucSolicOrdenServicios_DgF01
    Friend WithEvents CacheducMercaderia_DgF01A1 As Ransa.Rpt.Mercaderia.CacheducMercaderia_DgF01A
    Friend WithEvents bgwOrdenServicio As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwSolicOrdServ As System.ComponentModel.BackgroundWorker
End Class
