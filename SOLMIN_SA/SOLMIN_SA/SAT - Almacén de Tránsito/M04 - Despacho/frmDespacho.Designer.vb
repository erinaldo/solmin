<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespacho
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDespacho))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dgGuiasSalidas = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.GS_NRGUSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_NMNFTF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_FSLDAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_SMTRCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_MOTREC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_STPDSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_TIPDES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_NPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_CBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GS_CULUSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip()
        Me.tslblTitulo = New System.Windows.Forms.ToolStripLabel()
        Me.ts006 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbVistaPrevia = New System.Windows.Forms.ToolStripButton()
        Me.ts001 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAnular = New System.Windows.Forms.ToolStripButton()
        Me.ts002 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbGenerarGuiaRegu = New System.Windows.Forms.ToolStripButton()
        Me.tsb003 = New System.Windows.Forms.ToolStripSeparator()
        Me.stbGenerarGuia = New System.Windows.Forms.ToolStripButton()
        Me.ts004 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbImpresionMasiva = New System.Windows.Forms.ToolStripButton()
        Me.ts005 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgGuiasRemision = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.GR_NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSNGUIRS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTDGRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GR_FGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GR_SMTGRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GR_MOTTRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GR_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTNMMDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GR_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNNRGUSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSMISION = New System.Windows.Forms.DataGridViewImageColumn()
        Me.STRNEG_IMG = New System.Windows.Forms.DataGridViewImageColumn()
        Me.STRNAG_IMG = New System.Windows.Forms.DataGridViewImageColumn()
        Me.STRNEG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STRNAG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbVistaPreviaGuia = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsm_anular_gr = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstm_eliminar_gr = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstm_anular_gr_electronico = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnularGuias = New System.Windows.Forms.ToolStripButton()
        Me.tsbEnviarGuias = New System.Windows.Forms.ToolStripButton()
        Me.tsbCambiarNroGuia = New System.Windows.Forms.ToolStripButton()
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.txtGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chbPendiente = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.txtClient = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.grpFechaGSalida = New System.Windows.Forms.GroupBox()
        Me.txtFechaInicioGS = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.lblFechaInicioGS = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaFinalGS = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFechaFinalGS = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtNroGuiaSalida = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblNroGuiaSalida = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dstDespacho = New System.Data.DataSet()
        Me.dtGuiaSalida = New System.Data.DataTable()
        Me.NRGUSA = New System.Data.DataColumn()
        Me.NMNFTF = New System.Data.DataColumn()
        Me.FSLDAL = New System.Data.DataColumn()
        Me.SMTRCP = New System.Data.DataColumn()
        Me.MOTREC = New System.Data.DataColumn()
        Me.STPDSP = New System.Data.DataColumn()
        Me.TIPDES = New System.Data.DataColumn()
        Me.SESTRG = New System.Data.DataColumn()
        Me.SITUAC = New System.Data.DataColumn()
        Me.CTRSPT = New System.Data.DataColumn()
        Me.NPLCUN = New System.Data.DataColumn()
        Me.NPLCAC = New System.Data.DataColumn()
        Me.CBRCNT = New System.Data.DataColumn()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker()
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
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgGuiasSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspListadoMercaderia.SuspendLayout()
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.grpFechaGSalida.SuspendLayout()
        CType(Me.dstDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGuiaSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1360, 720)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 181)
        Me.KryptonSplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgGuiasSalidas)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.tspListadoMercaderia)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgGuiasRemision)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1360, 539)
        Me.KryptonSplitContainer1.SplitterDistance = 255
        Me.KryptonSplitContainer1.TabIndex = 4
        '
        'dgGuiasSalidas
        '
        Me.dgGuiasSalidas.AllowUserToAddRows = False
        Me.dgGuiasSalidas.AllowUserToDeleteRows = False
        Me.dgGuiasSalidas.AllowUserToResizeColumns = False
        Me.dgGuiasSalidas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgGuiasSalidas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgGuiasSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGuiasSalidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GS_NRGUSA, Me.GS_NMNFTF, Me.GS_FSLDAL, Me.GS_SMTRCP, Me.GS_MOTREC, Me.GS_STPDSP, Me.GS_TIPDES, Me.GS_SESTRG, Me.GS_SITUAC, Me.GS_CTRSPT, Me.GS_NPLCUN, Me.GS_NPLCAC, Me.GS_CBRCNT, Me.GS_CULUSA})
        Me.dgGuiasSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGuiasSalidas.Location = New System.Drawing.Point(0, 27)
        Me.dgGuiasSalidas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgGuiasSalidas.MultiSelect = False
        Me.dgGuiasSalidas.Name = "dgGuiasSalidas"
        Me.dgGuiasSalidas.ReadOnly = True
        Me.dgGuiasSalidas.RowHeadersWidth = 20
        Me.dgGuiasSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuiasSalidas.Size = New System.Drawing.Size(1360, 228)
        Me.dgGuiasSalidas.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGuiasSalidas.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgGuiasSalidas.TabIndex = 1
        '
        'GS_NRGUSA
        '
        Me.GS_NRGUSA.DataPropertyName = "PNNRGUSA"
        Me.GS_NRGUSA.HeaderText = "Nro. Guía Salida"
        Me.GS_NRGUSA.Name = "GS_NRGUSA"
        Me.GS_NRGUSA.ReadOnly = True
        Me.GS_NRGUSA.Width = 149
        '
        'GS_NMNFTF
        '
        Me.GS_NMNFTF.DataPropertyName = "PSNMNFTF"
        Me.GS_NMNFTF.HeaderText = "Manifiesto"
        Me.GS_NMNFTF.Name = "GS_NMNFTF"
        Me.GS_NMNFTF.ReadOnly = True
        Me.GS_NMNFTF.Width = 112
        '
        'GS_FSLDAL
        '
        Me.GS_FSLDAL.DataPropertyName = "PSFSLDAL"
        Me.GS_FSLDAL.HeaderText = "Fecha"
        Me.GS_FSLDAL.Name = "GS_FSLDAL"
        Me.GS_FSLDAL.ReadOnly = True
        Me.GS_FSLDAL.Width = 80
        '
        'GS_SMTRCP
        '
        Me.GS_SMTRCP.DataPropertyName = "PSSMTRCP"
        Me.GS_SMTRCP.HeaderText = "Motivo Recepción"
        Me.GS_SMTRCP.Name = "GS_SMTRCP"
        Me.GS_SMTRCP.ReadOnly = True
        Me.GS_SMTRCP.Visible = False
        Me.GS_SMTRCP.Width = 128
        '
        'GS_MOTREC
        '
        Me.GS_MOTREC.DataPropertyName = "PSMOTREC"
        Me.GS_MOTREC.HeaderText = "Motivo Recepción"
        Me.GS_MOTREC.Name = "GS_MOTREC"
        Me.GS_MOTREC.ReadOnly = True
        Me.GS_MOTREC.Width = 162
        '
        'GS_STPDSP
        '
        Me.GS_STPDSP.DataPropertyName = "PSSTPDSP"
        Me.GS_STPDSP.HeaderText = "Tipo Despacho"
        Me.GS_STPDSP.Name = "GS_STPDSP"
        Me.GS_STPDSP.ReadOnly = True
        Me.GS_STPDSP.Visible = False
        Me.GS_STPDSP.Width = 112
        '
        'GS_TIPDES
        '
        Me.GS_TIPDES.DataPropertyName = "PSTIPDES"
        Me.GS_TIPDES.HeaderText = "Tipo Despacho"
        Me.GS_TIPDES.Name = "GS_TIPDES"
        Me.GS_TIPDES.ReadOnly = True
        Me.GS_TIPDES.Width = 142
        '
        'GS_SESTRG
        '
        Me.GS_SESTRG.DataPropertyName = "PSSESTRG"
        Me.GS_SESTRG.HeaderText = "Situación"
        Me.GS_SESTRG.Name = "GS_SESTRG"
        Me.GS_SESTRG.ReadOnly = True
        Me.GS_SESTRG.Visible = False
        Me.GS_SESTRG.Width = 84
        '
        'GS_SITUAC
        '
        Me.GS_SITUAC.DataPropertyName = "PSSITUAC"
        Me.GS_SITUAC.HeaderText = "Situación"
        Me.GS_SITUAC.Name = "GS_SITUAC"
        Me.GS_SITUAC.ReadOnly = True
        Me.GS_SITUAC.Width = 103
        '
        'GS_CTRSPT
        '
        Me.GS_CTRSPT.DataPropertyName = "PNCTRSPT"
        Me.GS_CTRSPT.HeaderText = " Transporte"
        Me.GS_CTRSPT.Name = "GS_CTRSPT"
        Me.GS_CTRSPT.ReadOnly = True
        Me.GS_CTRSPT.Width = 116
        '
        'GS_NPLCUN
        '
        Me.GS_NPLCUN.DataPropertyName = "PSNPLCUN"
        Me.GS_NPLCUN.HeaderText = "Unidad"
        Me.GS_NPLCUN.Name = "GS_NPLCUN"
        Me.GS_NPLCUN.ReadOnly = True
        Me.GS_NPLCUN.Width = 90
        '
        'GS_NPLCAC
        '
        Me.GS_NPLCAC.DataPropertyName = "PSNPLCAC"
        Me.GS_NPLCAC.HeaderText = "Acoplado"
        Me.GS_NPLCAC.Name = "GS_NPLCAC"
        Me.GS_NPLCAC.ReadOnly = True
        Me.GS_NPLCAC.Width = 107
        '
        'GS_CBRCNT
        '
        Me.GS_CBRCNT.DataPropertyName = "PSCBRCNT"
        Me.GS_CBRCNT.HeaderText = " Brevete"
        Me.GS_CBRCNT.Name = "GS_CBRCNT"
        Me.GS_CBRCNT.ReadOnly = True
        Me.GS_CBRCNT.Width = 96
        '
        'GS_CULUSA
        '
        Me.GS_CULUSA.DataPropertyName = "PSCULUSA"
        Me.GS_CULUSA.HeaderText = "Usuario"
        Me.GS_CULUSA.Name = "GS_CULUSA"
        Me.GS_CULUSA.ReadOnly = True
        Me.GS_CULUSA.Width = 92
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tspListadoMercaderia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslblTitulo, Me.ts006, Me.tsbVistaPrevia, Me.ts001, Me.tsbAnular, Me.ts002, Me.tsbGenerarGuiaRegu, Me.tsb003, Me.stbGenerarGuia, Me.ts004, Me.tsbImpresionMasiva, Me.ts005})
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(1360, 27)
        Me.tspListadoMercaderia.TabIndex = 61
        Me.tspListadoMercaderia.Text = "ToolStrip1"
        '
        'tslblTitulo
        '
        Me.tslblTitulo.Name = "tslblTitulo"
        Me.tslblTitulo.Size = New System.Drawing.Size(166, 24)
        Me.tslblTitulo.Text = "Lista de Guías de Salida"
        '
        'ts006
        '
        Me.ts006.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ts006.Name = "ts006"
        Me.ts006.Size = New System.Drawing.Size(6, 27)
        '
        'tsbVistaPrevia
        '
        Me.tsbVistaPrevia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbVistaPrevia.Image = CType(resources.GetObject("tsbVistaPrevia.Image"), System.Drawing.Image)
        Me.tsbVistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVistaPrevia.Name = "tsbVistaPrevia"
        Me.tsbVistaPrevia.Size = New System.Drawing.Size(109, 24)
        Me.tsbVistaPrevia.Text = "Vista Previa"
        '
        'ts001
        '
        Me.ts001.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ts001.Name = "ts001"
        Me.ts001.Size = New System.Drawing.Size(6, 27)
        '
        'tsbAnular
        '
        Me.tsbAnular.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAnular.Image = CType(resources.GetObject("tsbAnular.Image"), System.Drawing.Image)
        Me.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnular.Name = "tsbAnular"
        Me.tsbAnular.Size = New System.Drawing.Size(76, 24)
        Me.tsbAnular.Text = "Anular"
        '
        'ts002
        '
        Me.ts002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ts002.Name = "ts002"
        Me.ts002.Size = New System.Drawing.Size(6, 27)
        '
        'tsbGenerarGuiaRegu
        '
        Me.tsbGenerarGuiaRegu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGenerarGuiaRegu.Image = CType(resources.GetObject("tsbGenerarGuiaRegu.Image"), System.Drawing.Image)
        Me.tsbGenerarGuiaRegu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarGuiaRegu.Name = "tsbGenerarGuiaRegu"
        Me.tsbGenerarGuiaRegu.Size = New System.Drawing.Size(221, 24)
        Me.tsbGenerarGuiaRegu.Text = "Generar Guía Regularización"
        '
        'tsb003
        '
        Me.tsb003.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsb003.Name = "tsb003"
        Me.tsb003.Size = New System.Drawing.Size(6, 27)
        '
        'stbGenerarGuia
        '
        Me.stbGenerarGuia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.stbGenerarGuia.Image = CType(resources.GetObject("stbGenerarGuia.Image"), System.Drawing.Image)
        Me.stbGenerarGuia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stbGenerarGuia.Name = "stbGenerarGuia"
        Me.stbGenerarGuia.Size = New System.Drawing.Size(184, 24)
        Me.stbGenerarGuia.Text = "Generar Guía Remisión"
        '
        'ts004
        '
        Me.ts004.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ts004.Name = "ts004"
        Me.ts004.Size = New System.Drawing.Size(6, 27)
        '
        'tsbImpresionMasiva
        '
        Me.tsbImpresionMasiva.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbImpresionMasiva.Image = CType(resources.GetObject("tsbImpresionMasiva.Image"), System.Drawing.Image)
        Me.tsbImpresionMasiva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImpresionMasiva.Name = "tsbImpresionMasiva"
        Me.tsbImpresionMasiva.Size = New System.Drawing.Size(149, 24)
        Me.tsbImpresionMasiva.Text = "Impresión Masiva"
        '
        'ts005
        '
        Me.ts005.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ts005.Name = "ts005"
        Me.ts005.Size = New System.Drawing.Size(6, 27)
        '
        'dgGuiasRemision
        '
        Me.dgGuiasRemision.AllowUserToAddRows = False
        Me.dgGuiasRemision.AllowUserToDeleteRows = False
        Me.dgGuiasRemision.AllowUserToResizeColumns = False
        Me.dgGuiasRemision.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgGuiasRemision.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgGuiasRemision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGuiasRemision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GR_NGUIRM, Me.PSNGUIRS, Me.CTDGRM, Me.GR_FGUIRM, Me.GR_SMTGRM, Me.GR_MOTTRA, Me.GR_SESTRG, Me.PSTNMMDT, Me.GR_SITUAC, Me.PNNRGUSA, Me.TRANSMISION, Me.STRNEG_IMG, Me.STRNAG_IMG, Me.STRNEG, Me.STRNAG, Me.CCLNT})
        Me.dgGuiasRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGuiasRemision.Location = New System.Drawing.Point(0, 27)
        Me.dgGuiasRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.dgGuiasRemision.MultiSelect = False
        Me.dgGuiasRemision.Name = "dgGuiasRemision"
        Me.dgGuiasRemision.ReadOnly = True
        Me.dgGuiasRemision.RowHeadersWidth = 20
        Me.dgGuiasRemision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuiasRemision.Size = New System.Drawing.Size(1360, 252)
        Me.dgGuiasRemision.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGuiasRemision.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgGuiasRemision.TabIndex = 1
        '
        'GR_NGUIRM
        '
        Me.GR_NGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GR_NGUIRM.DataPropertyName = "PSNGUIRM"
        Me.GR_NGUIRM.HeaderText = "Id Guía Remisión"
        Me.GR_NGUIRM.Name = "GR_NGUIRM"
        Me.GR_NGUIRM.ReadOnly = True
        Me.GR_NGUIRM.Width = 154
        '
        'PSNGUIRS
        '
        Me.PSNGUIRS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSNGUIRS.DataPropertyName = "PSNGUIRS"
        Me.PSNGUIRS.HeaderText = "Nro. Guía Remisión Txt"
        Me.PSNGUIRS.Name = "PSNGUIRS"
        Me.PSNGUIRS.ReadOnly = True
        Me.PSNGUIRS.Width = 192
        '
        'CTDGRM
        '
        Me.CTDGRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTDGRM.DataPropertyName = "PSCTDGRM"
        Me.CTDGRM.HeaderText = "Tipo Guía"
        Me.CTDGRM.Name = "CTDGRM"
        Me.CTDGRM.ReadOnly = True
        Me.CTDGRM.Width = 106
        '
        'GR_FGUIRM
        '
        Me.GR_FGUIRM.DataPropertyName = "PSFGUIRM_S"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.GR_FGUIRM.DefaultCellStyle = DataGridViewCellStyle3
        Me.GR_FGUIRM.HeaderText = "Fecha G. Remisión"
        Me.GR_FGUIRM.Name = "GR_FGUIRM"
        Me.GR_FGUIRM.ReadOnly = True
        Me.GR_FGUIRM.Width = 162
        '
        'GR_SMTGRM
        '
        Me.GR_SMTGRM.DataPropertyName = "PSSMTGRM"
        Me.GR_SMTGRM.HeaderText = "Código MotivoTraslado"
        Me.GR_SMTGRM.Name = "GR_SMTGRM"
        Me.GR_SMTGRM.ReadOnly = True
        Me.GR_SMTGRM.Visible = False
        Me.GR_SMTGRM.Width = 198
        '
        'GR_MOTTRA
        '
        Me.GR_MOTTRA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GR_MOTTRA.DataPropertyName = "PSMOTTRA"
        Me.GR_MOTTRA.HeaderText = "Motivo Traslado"
        Me.GR_MOTTRA.Name = "GR_MOTTRA"
        Me.GR_MOTTRA.ReadOnly = True
        '
        'GR_SESTRG
        '
        Me.GR_SESTRG.DataPropertyName = "PSSESTRG"
        Me.GR_SESTRG.HeaderText = "Código Situación"
        Me.GR_SESTRG.Name = "GR_SESTRG"
        Me.GR_SESTRG.ReadOnly = True
        Me.GR_SESTRG.Visible = False
        Me.GR_SESTRG.Width = 156
        '
        'PSTNMMDT
        '
        Me.PSTNMMDT.DataPropertyName = "PSTNMMDT"
        Me.PSTNMMDT.HeaderText = "Medio de Envio"
        Me.PSTNMMDT.Name = "PSTNMMDT"
        Me.PSTNMMDT.ReadOnly = True
        Me.PSTNMMDT.Width = 146
        '
        'GR_SITUAC
        '
        Me.GR_SITUAC.DataPropertyName = "PSSITUAC"
        Me.GR_SITUAC.HeaderText = "Situación"
        Me.GR_SITUAC.Name = "GR_SITUAC"
        Me.GR_SITUAC.ReadOnly = True
        Me.GR_SITUAC.Width = 103
        '
        'PNNRGUSA
        '
        Me.PNNRGUSA.DataPropertyName = "PNNRGUSA"
        Me.PNNRGUSA.HeaderText = "PNNRGUSA"
        Me.PNNRGUSA.Name = "PNNRGUSA"
        Me.PNNRGUSA.ReadOnly = True
        Me.PNNRGUSA.Visible = False
        Me.PNNRGUSA.Width = 119
        '
        'TRANSMISION
        '
        Me.TRANSMISION.HeaderText = "Estado Envio"
        Me.TRANSMISION.Image = CType(resources.GetObject("TRANSMISION.Image"), System.Drawing.Image)
        Me.TRANSMISION.Name = "TRANSMISION"
        Me.TRANSMISION.ReadOnly = True
        Me.TRANSMISION.Width = 104
        '
        'STRNEG_IMG
        '
        Me.STRNEG_IMG.HeaderText = "Emisión GR-E"
        Me.STRNEG_IMG.Name = "STRNEG_IMG"
        Me.STRNEG_IMG.ReadOnly = True
        Me.STRNEG_IMG.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.STRNEG_IMG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.STRNEG_IMG.Width = 131
        '
        'STRNAG_IMG
        '
        Me.STRNAG_IMG.HeaderText = "Anulación GR-E"
        Me.STRNAG_IMG.Name = "STRNAG_IMG"
        Me.STRNAG_IMG.ReadOnly = True
        Me.STRNAG_IMG.Width = 122
        '
        'STRNEG
        '
        Me.STRNEG.DataPropertyName = "PSSTRNEG"
        Me.STRNEG.HeaderText = "STRNEG"
        Me.STRNEG.Name = "STRNEG"
        Me.STRNEG.ReadOnly = True
        Me.STRNEG.Visible = False
        Me.STRNEG.Width = 96
        '
        'STRNAG
        '
        Me.STRNAG.DataPropertyName = "PSSTRNAG"
        Me.STRNAG.HeaderText = "STRNAG"
        Me.STRNAG.Name = "STRNAG"
        Me.STRNAG.ReadOnly = True
        Me.STRNAG.Visible = False
        Me.STRNAG.Width = 98
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "PNCCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        Me.CCLNT.Width = 86
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbVistaPreviaGuia, Me.ToolStripSplitButton1, Me.ToolStripButton1, Me.tsbAnularGuias, Me.tsbEnviarGuias, Me.tsbCambiarNroGuia})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1360, 27)
        Me.ToolStrip1.TabIndex = 62
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(166, 24)
        Me.ToolStripLabel1.Text = "Lista de Guías de Salida"
        '
        'tsbVistaPreviaGuia
        '
        Me.tsbVistaPreviaGuia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbVistaPreviaGuia.Image = CType(resources.GetObject("tsbVistaPreviaGuia.Image"), System.Drawing.Image)
        Me.tsbVistaPreviaGuia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVistaPreviaGuia.Name = "tsbVistaPreviaGuia"
        Me.tsbVistaPreviaGuia.Size = New System.Drawing.Size(109, 24)
        Me.tsbVistaPreviaGuia.Text = "Vista Previa"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_anular_gr, Me.tstm_eliminar_gr, Me.tstm_anular_gr_electronico})
        Me.ToolStripSplitButton1.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(149, 24)
        Me.ToolStripSplitButton1.Text = "Guías Remisión"
        '
        'tsm_anular_gr
        '
        Me.tsm_anular_gr.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.tsm_anular_gr.Name = "tsm_anular_gr"
        Me.tsm_anular_gr.Size = New System.Drawing.Size(200, 26)
        Me.tsm_anular_gr.Text = "Anular Guía"
        '
        'tstm_eliminar_gr
        '
        Me.tstm_eliminar_gr.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.tstm_eliminar_gr.Name = "tstm_eliminar_gr"
        Me.tstm_eliminar_gr.Size = New System.Drawing.Size(200, 26)
        Me.tstm_eliminar_gr.Text = "Eliminar Guía"
        '
        'tstm_anular_gr_electronico
        '
        Me.tstm_anular_gr_electronico.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.tstm_anular_gr_electronico.Name = "tstm_anular_gr_electronico"
        Me.tstm_anular_gr_electronico.Size = New System.Drawing.Size(200, 26)
        Me.tstm_anular_gr_electronico.Text = "Anular Guía Elect."
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(127, 24)
        Me.ToolStripButton1.Text = "Eliminar Guías"
        Me.ToolStripButton1.Visible = False
        '
        'tsbAnularGuias
        '
        Me.tsbAnularGuias.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAnularGuias.Image = CType(resources.GetObject("tsbAnularGuias.Image"), System.Drawing.Image)
        Me.tsbAnularGuias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnularGuias.Name = "tsbAnularGuias"
        Me.tsbAnularGuias.Size = New System.Drawing.Size(116, 24)
        Me.tsbAnularGuias.Text = "Anular Guías"
        Me.tsbAnularGuias.Visible = False
        '
        'tsbEnviarGuias
        '
        Me.tsbEnviarGuias.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEnviarGuias.Image = CType(resources.GetObject("tsbEnviarGuias.Image"), System.Drawing.Image)
        Me.tsbEnviarGuias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEnviarGuias.Name = "tsbEnviarGuias"
        Me.tsbEnviarGuias.Size = New System.Drawing.Size(113, 24)
        Me.tsbEnviarGuias.Text = "Enviar Guías"
        Me.tsbEnviarGuias.Visible = False
        '
        'tsbCambiarNroGuia
        '
        Me.tsbCambiarNroGuia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCambiarNroGuia.Image = Global.SOLMIN_SA.My.Resources.Resources.Revertir
        Me.tsbCambiarNroGuia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCambiarNroGuia.Name = "tsbCambiarNroGuia"
        Me.tsbCambiarNroGuia.Size = New System.Drawing.Size(155, 24)
        Me.tsbCambiarNroGuia.Text = "Cambiar Nro. Guía"
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Margin = New System.Windows.Forms.Padding(4)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.txtGuiaRemision)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.khgFiltros.Panel.Controls.Add(Me.chbPendiente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.txtClient)
        Me.khgFiltros.Panel.Controls.Add(Me.grpFechaGSalida)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroGuiaSalida)
        Me.khgFiltros.Panel.Controls.Add(Me.lblNroGuiaSalida)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Size = New System.Drawing.Size(1360, 181)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 3
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
        'txtGuiaRemision
        '
        Me.txtGuiaRemision.Location = New System.Drawing.Point(145, 103)
        Me.txtGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuiaRemision.MaxLength = 12
        Me.txtGuiaRemision.Name = "txtGuiaRemision"
        Me.txtGuiaRemision.Size = New System.Drawing.Size(292, 26)
        Me.txtGuiaRemision.TabIndex = 60
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(15, 105)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(84, 24)
        Me.KryptonLabel6.TabIndex = 59
        Me.KryptonLabel6.Text = "Nro. Guía : "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Nro. Guía : "
        '
        'chbPendiente
        '
        Me.chbPendiente.Checked = False
        Me.chbPendiente.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chbPendiente.Location = New System.Drawing.Point(452, 106)
        Me.chbPendiente.Margin = New System.Windows.Forms.Padding(4)
        Me.chbPendiente.Name = "chbPendiente"
        Me.chbPendiente.Size = New System.Drawing.Size(100, 24)
        Me.chbPendiente.TabIndex = 58
        Me.chbPendiente.Text = "Pendientes"
        Me.chbPendiente.Values.ExtraText = ""
        Me.chbPendiente.Values.Image = Nothing
        Me.chbPendiente.Values.Text = "Pendientes"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(772, 11)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(61, 24)
        Me.KryptonLabel3.TabIndex = 57
        Me.KryptonLabel3.Text = "Planta : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(452, 14)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(73, 24)
        Me.KryptonLabel2.TabIndex = 56
        Me.KryptonLabel2.Text = "Division : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Division : "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(15, 17)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(88, 24)
        Me.KryptonLabel4.TabIndex = 55
        Me.KryptonLabel4.Text = "Compañia : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañia : "
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(533, 6)
        Me.UcDivision_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(231, 28)
        Me.UcDivision_Cmb011.TabIndex = 53
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(843, 6)
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
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(276, 28)
        Me.UcPLanta_Cmb011.TabIndex = 54
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(145, 6)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(292, 28)
        Me.UcCompania_Cmb011.TabIndex = 52
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'txtClient
        '
        Me.txtClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClient.BackColor = System.Drawing.Color.Transparent
        Me.txtClient.CCMPN = "EZ"
        Me.txtClient.Location = New System.Drawing.Point(145, 42)
        Me.txtClient.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.pAccesoPorUsuario = True
        Me.txtClient.pCDDRSP_CodClienteSAP = ""
        Me.txtClient.pRequerido = True
        Me.txtClient.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClient.pVisualizaNegocio = False
        Me.txtClient.Size = New System.Drawing.Size(292, 26)
        Me.txtClient.TabIndex = 2
        '
        'grpFechaGSalida
        '
        Me.grpFechaGSalida.BackColor = System.Drawing.Color.Transparent
        Me.grpFechaGSalida.Controls.Add(Me.txtFechaInicioGS)
        Me.grpFechaGSalida.Controls.Add(Me.lblFechaInicioGS)
        Me.grpFechaGSalida.Controls.Add(Me.lblFechaFinalGS)
        Me.grpFechaGSalida.Controls.Add(Me.txtFechaFinalGS)
        Me.grpFechaGSalida.Location = New System.Drawing.Point(452, 44)
        Me.grpFechaGSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFechaGSalida.Name = "grpFechaGSalida"
        Me.grpFechaGSalida.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFechaGSalida.Size = New System.Drawing.Size(480, 59)
        Me.grpFechaGSalida.TabIndex = 43
        Me.grpFechaGSalida.TabStop = False
        Me.grpFechaGSalida.Text = "Fecha Guía Salida"
        '
        'txtFechaInicioGS
        '
        Me.txtFechaInicioGS.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaInicioGS.Location = New System.Drawing.Point(131, 23)
        Me.txtFechaInicioGS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaInicioGS.Mask = "00/00/0000"
        Me.txtFechaInicioGS.Name = "txtFechaInicioGS"
        Me.txtFechaInicioGS.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaInicioGS.Size = New System.Drawing.Size(97, 26)
        Me.txtFechaInicioGS.TabIndex = 37
        Me.txtFechaInicioGS.Text = "  /  /"
        '
        'lblFechaInicioGS
        '
        Me.lblFechaInicioGS.Location = New System.Drawing.Point(21, 27)
        Me.lblFechaInicioGS.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaInicioGS.Name = "lblFechaInicioGS"
        Me.lblFechaInicioGS.Size = New System.Drawing.Size(98, 24)
        Me.lblFechaInicioGS.TabIndex = 36
        Me.lblFechaInicioGS.Text = "F. Sal. Inicio : "
        Me.lblFechaInicioGS.Values.ExtraText = ""
        Me.lblFechaInicioGS.Values.Image = Nothing
        Me.lblFechaInicioGS.Values.Text = "F. Sal. Inicio : "
        '
        'lblFechaFinalGS
        '
        Me.lblFechaFinalGS.Location = New System.Drawing.Point(247, 27)
        Me.lblFechaFinalGS.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaFinalGS.Name = "lblFechaFinalGS"
        Me.lblFechaFinalGS.Size = New System.Drawing.Size(93, 24)
        Me.lblFechaFinalGS.TabIndex = 38
        Me.lblFechaFinalGS.Text = "F. Sal. Final : "
        Me.lblFechaFinalGS.Values.ExtraText = ""
        Me.lblFechaFinalGS.Values.Image = Nothing
        Me.lblFechaFinalGS.Values.Text = "F. Sal. Final : "
        '
        'txtFechaFinalGS
        '
        Me.txtFechaFinalGS.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaFinalGS.Location = New System.Drawing.Point(356, 23)
        Me.txtFechaFinalGS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaFinalGS.Mask = "##/##/####"
        Me.txtFechaFinalGS.Name = "txtFechaFinalGS"
        Me.txtFechaFinalGS.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaFinalGS.Size = New System.Drawing.Size(97, 26)
        Me.txtFechaFinalGS.TabIndex = 39
        Me.txtFechaFinalGS.Text = "  /  /"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(1253, 39)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(91, 89)
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
        'txtNroGuiaSalida
        '
        Me.txtNroGuiaSalida.Location = New System.Drawing.Point(145, 73)
        Me.txtNroGuiaSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroGuiaSalida.MaxLength = 10
        Me.txtNroGuiaSalida.Name = "txtNroGuiaSalida"
        Me.txtNroGuiaSalida.Size = New System.Drawing.Size(292, 26)
        Me.txtNroGuiaSalida.TabIndex = 5
        '
        'lblNroGuiaSalida
        '
        Me.lblNroGuiaSalida.Location = New System.Drawing.Point(15, 74)
        Me.lblNroGuiaSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNroGuiaSalida.Name = "lblNroGuiaSalida"
        Me.lblNroGuiaSalida.Size = New System.Drawing.Size(128, 24)
        Me.lblNroGuiaSalida.TabIndex = 4
        Me.lblNroGuiaSalida.Text = "Nro. Guía Salida : "
        Me.lblNroGuiaSalida.Values.ExtraText = ""
        Me.lblNroGuiaSalida.Values.Image = Nothing
        Me.lblNroGuiaSalida.Values.Text = "Nro. Guía Salida : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(15, 48)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(66, 24)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(1057, 106)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(41, 37)
        Me.KryptonLabel5.TabIndex = 35
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'dstDespacho
        '
        Me.dstDespacho.DataSetName = "dstDespacho"
        Me.dstDespacho.Tables.AddRange(New System.Data.DataTable() {Me.dtGuiaSalida})
        '
        'dtGuiaSalida
        '
        Me.dtGuiaSalida.Columns.AddRange(New System.Data.DataColumn() {Me.NRGUSA, Me.NMNFTF, Me.FSLDAL, Me.SMTRCP, Me.MOTREC, Me.STPDSP, Me.TIPDES, Me.SESTRG, Me.SITUAC, Me.CTRSPT, Me.NPLCUN, Me.NPLCAC, Me.CBRCNT})
        Me.dtGuiaSalida.TableName = "dtGuiaSalida"
        '
        'NRGUSA
        '
        Me.NRGUSA.ColumnName = "NRGUSA"
        Me.NRGUSA.DataType = GetType(Long)
        Me.NRGUSA.DefaultValue = CType(0, Long)
        '
        'NMNFTF
        '
        Me.NMNFTF.ColumnName = "NMNFTF"
        Me.NMNFTF.DefaultValue = ""
        '
        'FSLDAL
        '
        Me.FSLDAL.ColumnName = "FSLDAL"
        Me.FSLDAL.DataType = GetType(Date)
        '
        'SMTRCP
        '
        Me.SMTRCP.ColumnName = "SMTRCP"
        Me.SMTRCP.DefaultValue = ""
        '
        'MOTREC
        '
        Me.MOTREC.ColumnName = "MOTREC"
        Me.MOTREC.DefaultValue = ""
        '
        'STPDSP
        '
        Me.STPDSP.ColumnName = "STPDSP"
        Me.STPDSP.DefaultValue = ""
        '
        'TIPDES
        '
        Me.TIPDES.ColumnName = "TIPDES"
        Me.TIPDES.DefaultValue = ""
        '
        'SESTRG
        '
        Me.SESTRG.ColumnName = "SESTRG"
        Me.SESTRG.DefaultValue = ""
        '
        'SITUAC
        '
        Me.SITUAC.ColumnName = "SITUAC"
        Me.SITUAC.DefaultValue = ""
        '
        'CTRSPT
        '
        Me.CTRSPT.ColumnName = "CTRSPT"
        Me.CTRSPT.DataType = GetType(Integer)
        Me.CTRSPT.DefaultValue = 0
        '
        'NPLCUN
        '
        Me.NPLCUN.ColumnName = "NPLCUN"
        Me.NPLCUN.DefaultValue = ""
        '
        'NPLCAC
        '
        Me.NPLCAC.ColumnName = "NPLCAC"
        Me.NPLCAC.DefaultValue = ""
        '
        'CBRCNT
        '
        Me.CBRCNT.ColumnName = "CBRCNT"
        Me.CBRCNT.DefaultValue = ""
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRGUSA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro. Guía Salida"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 119
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NMNFTF"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Manifiesto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 91
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FSLDAL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 66
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SMTRCP"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Motivo Recepción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 123
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MOTREC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Motivo Recepción"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 128
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "STPDSP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tipo Despacho"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 109
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TIPDES"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tipo Despacho"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 112
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Situación"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SITUAC"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Situación"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 84
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CTRSPT"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Transporte"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 87
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 70
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NPLCAC"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Acoplado"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 81
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Brevete"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 73
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nro. Guía Remisión"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 135
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "FGUIRM"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn15.HeaderText = "Fecha G. Remisión"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 130
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "SMTGRM"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Código MotivoTraslado"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 145
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "MOTTRA"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Motivo Traslado"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 118
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Código Situación"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 116
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "SITUAC"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Situación"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 84
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = CType(resources.GetObject("ButtonSpecHeaderGroup1.Image"), System.Drawing.Image)
        Me.ButtonSpecHeaderGroup1.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.ButtonSpecHeaderGroup1.Text = "Generar Guía Remisión"
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.UniqueName = "C163D28417414EC4C163D28417414EC4"
        '
        'frmDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 720)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDespacho"
        Me.Text = "Despacho de Bultos - Guía Salida"
        CType(Me.KryptonPanel,System.ComponentModel.ISupportInitialize).EndInit
        Me.KryptonPanel.ResumeLayout(false)
        Me.KryptonPanel.PerformLayout
        CType(Me.KryptonSplitContainer1.Panel1,System.ComponentModel.ISupportInitialize).EndInit
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(false)
        Me.KryptonSplitContainer1.Panel1.PerformLayout
        CType(Me.KryptonSplitContainer1.Panel2,System.ComponentModel.ISupportInitialize).EndInit
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(false)
        Me.KryptonSplitContainer1.Panel2.PerformLayout
        CType(Me.KryptonSplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.KryptonSplitContainer1.ResumeLayout(false)
        CType(Me.dgGuiasSalidas,System.ComponentModel.ISupportInitialize).EndInit
        Me.tspListadoMercaderia.ResumeLayout(false)
        Me.tspListadoMercaderia.PerformLayout
        CType(Me.dgGuiasRemision,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.khgFiltros.Panel,System.ComponentModel.ISupportInitialize).EndInit
        Me.khgFiltros.Panel.ResumeLayout(false)
        Me.khgFiltros.Panel.PerformLayout
        CType(Me.khgFiltros,System.ComponentModel.ISupportInitialize).EndInit
        Me.khgFiltros.ResumeLayout(false)
        Me.grpFechaGSalida.ResumeLayout(false)
        Me.grpFechaGSalida.PerformLayout
        CType(Me.dstDespacho,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dtGuiaSalida,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

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
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroGuiaSalida As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuiaSalida As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgGuiasSalidas As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtFechaFinalGS As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents txtFechaInicioGS As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents lblFechaFinalGS As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicioGS As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgGuiasRemision As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents grpFechaGSalida As System.Windows.Forms.GroupBox
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtClient As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents dstDespacho As System.Data.DataSet
    Friend WithEvents dtGuiaSalida As System.Data.DataTable
    Friend WithEvents NRGUSA As System.Data.DataColumn
    Friend WithEvents NMNFTF As System.Data.DataColumn
    Friend WithEvents FSLDAL As System.Data.DataColumn
    Friend WithEvents SMTRCP As System.Data.DataColumn
    Friend WithEvents MOTREC As System.Data.DataColumn
    Friend WithEvents STPDSP As System.Data.DataColumn
    Friend WithEvents TIPDES As System.Data.DataColumn
    Friend WithEvents SESTRG As System.Data.DataColumn
    Friend WithEvents SITUAC As System.Data.DataColumn
    Friend WithEvents CTRSPT As System.Data.DataColumn
    Friend WithEvents NPLCUN As System.Data.DataColumn
    Friend WithEvents NPLCAC As System.Data.DataColumn
    Friend WithEvents CBRCNT As System.Data.DataColumn
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As RANSA.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents UcDivision_Cmb011 As RANSA.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents chbPendiente As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
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
    Friend WithEvents GS_NRGUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NMNFTF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_FSLDAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SMTRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_MOTREC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_STPDSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_TIPDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CULUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents tslblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbImpresionMasiva As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts001 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents stbGenerarGuia As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGenerarGuiaRegu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb003 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts004 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbVistaPrevia As System.Windows.Forms.ToolStripButton
    Friend WithEvents ts006 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts005 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbVistaPreviaGuia As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAnularGuias As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEnviarGuias As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCambiarNroGuia As System.Windows.Forms.ToolStripButton
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsm_anular_gr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstm_eliminar_gr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstm_anular_gr_electronico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GR_NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNGUIRS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTDGRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_FGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SMTGRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_MOTTRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTNMMDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRGUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRANSMISION As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents STRNEG_IMG As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents STRNAG_IMG As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents STRNEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STRNAG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
