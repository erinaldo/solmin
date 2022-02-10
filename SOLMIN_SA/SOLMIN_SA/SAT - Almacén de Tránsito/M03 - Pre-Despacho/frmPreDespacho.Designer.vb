<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreDespacho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreDespacho))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.kryptonSplitContainerHorizontal = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.hgPreDespacho = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bshgGuiaRemision = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bshVistraPreviaGuia = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bshgStatusOcultarPreDespacho = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.dgPreDespachos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.hgGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaAnularGR = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaVistaPreviaGR = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnOcultar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.dgGuiasRemision = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.GR_NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GR_FGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GR_SMTGRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GR_MOTTRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GR_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTNMMDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GR_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNNRGUSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kryptonSplitContainerVertical = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.hgBulto = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.btnAgregarPedido = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnQuitarrPedido = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bshgAgregar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bshgElimnar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.dgPreDespachoBultos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.LECTURA = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NRPLTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NROPLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSDESCWB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngAlmacenCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTIPBTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQPSOBL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FGLPRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsPreDespachoBulto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiAgregarBultoPreDespacho = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDesmarcarBultoPreDespacho = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.hgItemsBulto = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bshgStatusOcultarItems = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.dgPreDespachoItemBulto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.D_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_CIDPAQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSNRPDTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSNROSEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCIDPAQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hgSubItemsBulto = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bshgStatusOcultarSubItems = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.dgPreDespachoSubItemBulto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SBITOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QCNRCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bshgStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bshgCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnGenerarPreDespacho = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtCodigoPreDespacho = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCodigoPreDespacho = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.M_NROPLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NROCTL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNNROPLT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSNMMDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCRTLTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNNGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSSMTRCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSSMTRCP_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSSSNCRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSSSNCRG_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCOD_STPDES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonSplitContainerHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonSplitContainerHorizontal.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerHorizontal.Panel1.SuspendLayout()
        CType(Me.kryptonSplitContainerHorizontal.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerHorizontal.Panel2.SuspendLayout()
        Me.kryptonSplitContainerHorizontal.SuspendLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel2.SuspendLayout()
        Me.KryptonSplitContainer2.SuspendLayout()
        CType(Me.hgPreDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgPreDespacho.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgPreDespacho.Panel.SuspendLayout()
        Me.hgPreDespacho.SuspendLayout()
        CType(Me.dgPreDespachos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGuiaRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGuiaRemision.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgGuiaRemision.Panel.SuspendLayout()
        Me.hgGuiaRemision.SuspendLayout()
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonSplitContainerVertical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonSplitContainerVertical.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerVertical.Panel1.SuspendLayout()
        CType(Me.kryptonSplitContainerVertical.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerVertical.Panel2.SuspendLayout()
        Me.kryptonSplitContainerVertical.SuspendLayout()
        CType(Me.hgBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgBulto.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgBulto.Panel.SuspendLayout()
        Me.hgBulto.SuspendLayout()
        CType(Me.dgPreDespachoBultos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPreDespachoBulto.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.hgItemsBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgItemsBulto.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgItemsBulto.Panel.SuspendLayout()
        Me.hgItemsBulto.SuspendLayout()
        CType(Me.dgPreDespachoItemBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgSubItemsBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgSubItemsBulto.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgSubItemsBulto.Panel.SuspendLayout()
        Me.hgSubItemsBulto.SuspendLayout()
        CType(Me.dgPreDespachoSubItemBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.kryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1319, 841)
        Me.KryptonPanel.TabIndex = 0
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kryptonSplitContainerHorizontal)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 153)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.kryptonPanel1.Size = New System.Drawing.Size(1319, 688)
        Me.kryptonPanel1.TabIndex = 3
        '
        'kryptonSplitContainerHorizontal
        '
        Me.kryptonSplitContainerHorizontal.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainerHorizontal.Location = New System.Drawing.Point(7, 6)
        Me.kryptonSplitContainerHorizontal.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonSplitContainerHorizontal.Name = "kryptonSplitContainerHorizontal"
        '
        'kryptonSplitContainerHorizontal.Panel1
        '
        Me.kryptonSplitContainerHorizontal.Panel1.Controls.Add(Me.KryptonSplitContainer2)
        Me.kryptonSplitContainerHorizontal.Panel1MinSize = 100
        '
        'kryptonSplitContainerHorizontal.Panel2
        '
        Me.kryptonSplitContainerHorizontal.Panel2.Controls.Add(Me.kryptonSplitContainerVertical)
        Me.kryptonSplitContainerHorizontal.Panel2MinSize = 100
        Me.kryptonSplitContainerHorizontal.Size = New System.Drawing.Size(1305, 676)
        Me.kryptonSplitContainerHorizontal.SplitterDistance = 545
        Me.kryptonSplitContainerHorizontal.TabIndex = 0
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        Me.KryptonSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer2.Panel1
        '
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.hgPreDespacho)
        '
        'KryptonSplitContainer2.Panel2
        '
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.hgGuiaRemision)
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(545, 676)
        Me.KryptonSplitContainer2.SplitterDistance = 367
        Me.KryptonSplitContainer2.TabIndex = 1
        '
        'hgPreDespacho
        '
        Me.hgPreDespacho.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bshgGuiaRemision, Me.bshVistraPreviaGuia, Me.bshgStatusOcultarPreDespacho})
        Me.hgPreDespacho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgPreDespacho.HeaderVisibleSecondary = False
        Me.hgPreDespacho.Location = New System.Drawing.Point(0, 0)
        Me.hgPreDespacho.Margin = New System.Windows.Forms.Padding(4)
        Me.hgPreDespacho.Name = "hgPreDespacho"
        '
        'hgPreDespacho.Panel
        '
        Me.hgPreDespacho.Panel.Controls.Add(Me.dgPreDespachos)
        Me.hgPreDespacho.Size = New System.Drawing.Size(545, 367)
        Me.hgPreDespacho.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgPreDespacho.TabIndex = 2
        Me.hgPreDespacho.Text = "Pre-Despachos"
        Me.hgPreDespacho.ValuesPrimary.Description = ""
        Me.hgPreDespacho.ValuesPrimary.Heading = "Pre-Despachos"
        Me.hgPreDespacho.ValuesPrimary.Image = Nothing
        Me.hgPreDespacho.ValuesSecondary.Description = ""
        Me.hgPreDespacho.ValuesSecondary.Heading = "Description"
        Me.hgPreDespacho.ValuesSecondary.Image = Nothing
        '
        'bshgGuiaRemision
        '
        Me.bshgGuiaRemision.ExtraText = ""
        Me.bshgGuiaRemision.Image = Nothing
        Me.bshgGuiaRemision.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bshgGuiaRemision.Text = "Generar Guía Remisión"
        Me.bshgGuiaRemision.ToolTipImage = Nothing
        Me.bshgGuiaRemision.UniqueName = "1838E561235F4FF81838E561235F4FF8"
        Me.bshgGuiaRemision.Visible = False
        '
        'bshVistraPreviaGuia
        '
        Me.bshVistraPreviaGuia.ExtraText = ""
        Me.bshVistraPreviaGuia.Image = Nothing
        Me.bshVistraPreviaGuia.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bshVistraPreviaGuia.Text = "Vista Previa"
        Me.bshVistraPreviaGuia.ToolTipImage = Nothing
        Me.bshVistraPreviaGuia.UniqueName = "822CDC5A181E4676822CDC5A181E4676"
        Me.bshVistraPreviaGuia.Visible = False
        '
        'bshgStatusOcultarPreDespacho
        '
        Me.bshgStatusOcultarPreDespacho.ExtraText = ""
        Me.bshgStatusOcultarPreDespacho.Image = Nothing
        Me.bshgStatusOcultarPreDespacho.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bshgStatusOcultarPreDespacho.Text = "Ocultar"
        Me.bshgStatusOcultarPreDespacho.ToolTipImage = Nothing
        Me.bshgStatusOcultarPreDespacho.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
        Me.bshgStatusOcultarPreDespacho.UniqueName = "4676E43EFA4144A44676E43EFA4144A4"
        '
        'dgPreDespachos
        '
        Me.dgPreDespachos.AllowUserToAddRows = False
        Me.dgPreDespachos.AllowUserToDeleteRows = False
        Me.dgPreDespachos.AllowUserToResizeColumns = False
        Me.dgPreDespachos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgPreDespachos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPreDespachos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPreDespachos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NROPLT, Me.M_NROCTL, Me.PNNROPLT, Me.PSNMMDT, Me.PSCRTLTE, Me.PNNGUIRM, Me.PSSMTRCP, Me.PSSMTRCP_D, Me.PSSSNCRG, Me.PSSSNCRG_D, Me.PSCOD_STPDES})
        Me.dgPreDespachos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPreDespachos.Location = New System.Drawing.Point(0, 0)
        Me.dgPreDespachos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgPreDespachos.MultiSelect = False
        Me.dgPreDespachos.Name = "dgPreDespachos"
        Me.dgPreDespachos.ReadOnly = True
        Me.dgPreDespachos.RowHeadersWidth = 20
        Me.dgPreDespachos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPreDespachos.Size = New System.Drawing.Size(543, 332)
        Me.dgPreDespachos.StandardTab = True
        Me.dgPreDespachos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgPreDespachos.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgPreDespachos.TabIndex = 0
        '
        'hgGuiaRemision
        '
        Me.hgGuiaRemision.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaAnularGR, Me.bsaVistaPreviaGR, Me.btnOcultar})
        Me.hgGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgGuiaRemision.HeaderVisibleSecondary = False
        Me.hgGuiaRemision.Location = New System.Drawing.Point(0, 0)
        Me.hgGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.hgGuiaRemision.Name = "hgGuiaRemision"
        '
        'hgGuiaRemision.Panel
        '
        Me.hgGuiaRemision.Panel.Controls.Add(Me.dgGuiasRemision)
        Me.hgGuiaRemision.Size = New System.Drawing.Size(545, 304)
        Me.hgGuiaRemision.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgGuiaRemision.TabIndex = 3
        Me.hgGuiaRemision.Text = "Guía de Remisión"
        Me.hgGuiaRemision.ValuesPrimary.Description = ""
        Me.hgGuiaRemision.ValuesPrimary.Heading = "Guía de Remisión"
        Me.hgGuiaRemision.ValuesPrimary.Image = Nothing
        Me.hgGuiaRemision.ValuesSecondary.Description = ""
        Me.hgGuiaRemision.ValuesSecondary.Heading = "Description"
        Me.hgGuiaRemision.ValuesSecondary.Image = Nothing
        '
        'bsaAnularGR
        '
        Me.bsaAnularGR.ExtraText = ""
        Me.bsaAnularGR.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.bsaAnularGR.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaAnularGR.Text = "Eliminar Guías"
        Me.bsaAnularGR.ToolTipImage = Nothing
        Me.bsaAnularGR.UniqueName = "E84D614FF9224F52E84D614FF9224F52"
        '
        'bsaVistaPreviaGR
        '
        Me.bsaVistaPreviaGR.ExtraText = ""
        Me.bsaVistaPreviaGR.Image = CType(resources.GetObject("bsaVistaPreviaGR.Image"), System.Drawing.Image)
        Me.bsaVistaPreviaGR.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaVistaPreviaGR.Text = "Vista Previa"
        Me.bsaVistaPreviaGR.ToolTipImage = Nothing
        Me.bsaVistaPreviaGR.UniqueName = "67570F8A96AC493B67570F8A96AC493B"
        '
        'btnOcultar
        '
        Me.btnOcultar.ExtraText = ""
        Me.btnOcultar.Image = Nothing
        Me.btnOcultar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnOcultar.Text = "Ocultar"
        Me.btnOcultar.ToolTipImage = Nothing
        Me.btnOcultar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.btnOcultar.UniqueName = "3D460390D875430D3D460390D875430D"
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
        Me.dgGuiasRemision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GR_NGUIRM, Me.GR_FGUIRM, Me.GR_SMTGRM, Me.GR_MOTTRA, Me.GR_SESTRG, Me.PSTNMMDT, Me.GR_SITUAC, Me.PNNRGUSA})
        Me.dgGuiasRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGuiasRemision.Location = New System.Drawing.Point(0, 0)
        Me.dgGuiasRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.dgGuiasRemision.MultiSelect = False
        Me.dgGuiasRemision.Name = "dgGuiasRemision"
        Me.dgGuiasRemision.ReadOnly = True
        Me.dgGuiasRemision.RowHeadersWidth = 20
        Me.dgGuiasRemision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuiasRemision.Size = New System.Drawing.Size(543, 269)
        Me.dgGuiasRemision.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGuiasRemision.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgGuiasRemision.TabIndex = 1
        '
        'GR_NGUIRM
        '
        Me.GR_NGUIRM.DataPropertyName = "PSNGUIRM"
        Me.GR_NGUIRM.HeaderText = "Nro. Guía Remisión"
        Me.GR_NGUIRM.Name = "GR_NGUIRM"
        Me.GR_NGUIRM.ReadOnly = True
        Me.GR_NGUIRM.Width = 169
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
        Me.GR_SMTGRM.Width = 156
        '
        'GR_MOTTRA
        '
        Me.GR_MOTTRA.DataPropertyName = "PSMOTTRA"
        Me.GR_MOTTRA.HeaderText = "Motivo Traslado"
        Me.GR_MOTTRA.Name = "GR_MOTTRA"
        Me.GR_MOTTRA.ReadOnly = True
        Me.GR_MOTTRA.Width = 149
        '
        'GR_SESTRG
        '
        Me.GR_SESTRG.DataPropertyName = "PSSESTRG"
        Me.GR_SESTRG.HeaderText = "Código Situación"
        Me.GR_SESTRG.Name = "GR_SESTRG"
        Me.GR_SESTRG.ReadOnly = True
        Me.GR_SESTRG.Visible = False
        Me.GR_SESTRG.Width = 125
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
        Me.PNNRGUSA.Width = 94
        '
        'kryptonSplitContainerVertical
        '
        Me.kryptonSplitContainerVertical.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainerVertical.Location = New System.Drawing.Point(0, 0)
        Me.kryptonSplitContainerVertical.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonSplitContainerVertical.Name = "kryptonSplitContainerVertical"
        Me.kryptonSplitContainerVertical.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'kryptonSplitContainerVertical.Panel1
        '
        Me.kryptonSplitContainerVertical.Panel1.Controls.Add(Me.hgBulto)
        '
        'kryptonSplitContainerVertical.Panel2
        '
        Me.kryptonSplitContainerVertical.Panel2.Controls.Add(Me.KryptonSplitContainer1)
        Me.kryptonSplitContainerVertical.Size = New System.Drawing.Size(755, 676)
        Me.kryptonSplitContainerVertical.SplitterDistance = 243
        Me.kryptonSplitContainerVertical.TabIndex = 0
        '
        'hgBulto
        '
        Me.hgBulto.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnAgregarPedido, Me.btnQuitarrPedido, Me.bshgAgregar, Me.bshgElimnar})
        Me.hgBulto.CausesValidation = False
        Me.hgBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgBulto.HeaderVisibleSecondary = False
        Me.hgBulto.Location = New System.Drawing.Point(0, 0)
        Me.hgBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.hgBulto.Name = "hgBulto"
        '
        'hgBulto.Panel
        '
        Me.hgBulto.Panel.Controls.Add(Me.dgPreDespachoBultos)
        Me.hgBulto.Size = New System.Drawing.Size(755, 243)
        Me.hgBulto.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgBulto.TabIndex = 1
        Me.hgBulto.Text = "Bultos"
        Me.hgBulto.ValuesPrimary.Description = ""
        Me.hgBulto.ValuesPrimary.Heading = "Bultos"
        Me.hgBulto.ValuesPrimary.Image = Nothing
        Me.hgBulto.ValuesSecondary.Description = ""
        Me.hgBulto.ValuesSecondary.Heading = "Description"
        Me.hgBulto.ValuesSecondary.Image = Nothing
        '
        'btnAgregarPedido
        '
        Me.btnAgregarPedido.ExtraText = ""
        Me.btnAgregarPedido.Image = Nothing
        Me.btnAgregarPedido.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnAgregarPedido.Text = "Agregar Pedido T."
        Me.btnAgregarPedido.ToolTipImage = Nothing
        Me.btnAgregarPedido.UniqueName = "ABD37170DC5948A4E996DA34F218413C"
        '
        'btnQuitarrPedido
        '
        Me.btnQuitarrPedido.ExtraText = ""
        Me.btnQuitarrPedido.Image = Nothing
        Me.btnQuitarrPedido.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnQuitarrPedido.Text = "Quitar Pedido T."
        Me.btnQuitarrPedido.ToolTipImage = Nothing
        Me.btnQuitarrPedido.UniqueName = "58F6EFD1BCBA4D12AD9D5C19B68715CA"
        '
        'bshgAgregar
        '
        Me.bshgAgregar.ExtraText = ""
        Me.bshgAgregar.Image = Nothing
        Me.bshgAgregar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bshgAgregar.Text = "Agregar Bulto"
        Me.bshgAgregar.ToolTipImage = Nothing
        Me.bshgAgregar.UniqueName = "058DC6FB5EA8466D058DC6FB5EA8466D"
        '
        'bshgElimnar
        '
        Me.bshgElimnar.ExtraText = ""
        Me.bshgElimnar.Image = Nothing
        Me.bshgElimnar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bshgElimnar.Text = "Eliminar Bulto"
        Me.bshgElimnar.ToolTipImage = Nothing
        Me.bshgElimnar.UniqueName = "EDEAC2634B1C421CEDEAC2634B1C421C"
        '
        'dgPreDespachoBultos
        '
        Me.dgPreDespachoBultos.AllowUserToAddRows = False
        Me.dgPreDespachoBultos.AllowUserToDeleteRows = False
        Me.dgPreDespachoBultos.AllowUserToOrderColumns = True
        Me.dgPreDespachoBultos.AllowUserToResizeColumns = False
        Me.dgPreDespachoBultos.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PapayaWhip
        Me.dgPreDespachoBultos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgPreDespachoBultos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPreDespachoBultos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LECTURA, Me.NRPLTS, Me.PSCREFFW, Me.NROPLT, Me.PSDESCWB, Me.PSTLUGEN, Me.FechaIngAlmacenCL, Me.PNQREFFW, Me.PSTIPBTO, Me.PNQPSOBL, Me.PSTUNPSO, Me.FGLPRD})
        Me.dgPreDespachoBultos.ContextMenuStrip = Me.cmsPreDespachoBulto
        Me.dgPreDespachoBultos.DataMember = "dtPreDespachoBultos"
        Me.dgPreDespachoBultos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPreDespachoBultos.Location = New System.Drawing.Point(0, 0)
        Me.dgPreDespachoBultos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgPreDespachoBultos.MultiSelect = False
        Me.dgPreDespachoBultos.Name = "dgPreDespachoBultos"
        Me.dgPreDespachoBultos.ReadOnly = True
        Me.dgPreDespachoBultos.RowHeadersWidth = 20
        Me.dgPreDespachoBultos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPreDespachoBultos.Size = New System.Drawing.Size(753, 208)
        Me.dgPreDespachoBultos.StandardTab = True
        Me.dgPreDespachoBultos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgPreDespachoBultos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgPreDespachoBultos.TabIndex = 0
        '
        'LECTURA
        '
        Me.LECTURA.HeaderText = "Lectura"
        Me.LECTURA.Name = "LECTURA"
        Me.LECTURA.ReadOnly = True
        Me.LECTURA.Width = 67
        '
        'NRPLTS
        '
        Me.NRPLTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRPLTS.DataPropertyName = "PSNRPLTS"
        Me.NRPLTS.HeaderText = "Nro Pallet"
        Me.NRPLTS.Name = "NRPLTS"
        Me.NRPLTS.ReadOnly = True
        Me.NRPLTS.Width = 107
        '
        'PSCREFFW
        '
        Me.PSCREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCREFFW.DataPropertyName = "PSCREFFW"
        Me.PSCREFFW.HeaderText = "Bulto"
        Me.PSCREFFW.Name = "PSCREFFW"
        Me.PSCREFFW.ReadOnly = True
        Me.PSCREFFW.Width = 77
        '
        'NROPLT
        '
        Me.NROPLT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NROPLT.DataPropertyName = "NROPLT"
        Me.NROPLT.HeaderText = "NROPLT"
        Me.NROPLT.Name = "NROPLT"
        Me.NROPLT.ReadOnly = True
        Me.NROPLT.Visible = False
        '
        'PSDESCWB
        '
        Me.PSDESCWB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSDESCWB.DataPropertyName = "PSDESCWB"
        Me.PSDESCWB.HeaderText = "Descripción"
        Me.PSDESCWB.Name = "PSDESCWB"
        Me.PSDESCWB.ReadOnly = True
        Me.PSDESCWB.Width = 120
        '
        'PSTLUGEN
        '
        Me.PSTLUGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTLUGEN.DataPropertyName = "PSTLUGEN"
        Me.PSTLUGEN.HeaderText = "Lugar Entrega"
        Me.PSTLUGEN.Name = "PSTLUGEN"
        Me.PSTLUGEN.ReadOnly = True
        Me.PSTLUGEN.Width = 134
        '
        'FechaIngAlmacenCL
        '
        Me.FechaIngAlmacenCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaIngAlmacenCL.DataPropertyName = "FechaIngAlmacenCL"
        Me.FechaIngAlmacenCL.HeaderText = "Fecha"
        Me.FechaIngAlmacenCL.Name = "FechaIngAlmacenCL"
        Me.FechaIngAlmacenCL.ReadOnly = True
        Me.FechaIngAlmacenCL.Width = 80
        '
        'PNQREFFW
        '
        Me.PNQREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNQREFFW.DataPropertyName = "PNQREFFW"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.PNQREFFW.DefaultCellStyle = DataGridViewCellStyle5
        Me.PNQREFFW.HeaderText = "Cantidad"
        Me.PNQREFFW.Name = "PNQREFFW"
        Me.PNQREFFW.ReadOnly = True
        Me.PNQREFFW.Width = 102
        '
        'PSTIPBTO
        '
        Me.PSTIPBTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTIPBTO.DataPropertyName = "PSTIPBTO"
        Me.PSTIPBTO.HeaderText = "Tipo Bulto"
        Me.PSTIPBTO.Name = "PSTIPBTO"
        Me.PSTIPBTO.ReadOnly = True
        Me.PSTIPBTO.Width = 111
        '
        'PNQPSOBL
        '
        Me.PNQPSOBL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNQPSOBL.DataPropertyName = "PNQPSOBL"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.PNQPSOBL.DefaultCellStyle = DataGridViewCellStyle6
        Me.PNQPSOBL.HeaderText = "Peso"
        Me.PNQPSOBL.Name = "PNQPSOBL"
        Me.PNQPSOBL.ReadOnly = True
        Me.PNQPSOBL.Width = 72
        '
        'PSTUNPSO
        '
        Me.PSTUNPSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTUNPSO.DataPropertyName = "PSTUNPSO"
        Me.PSTUNPSO.HeaderText = "Unidad"
        Me.PSTUNPSO.Name = "PSTUNPSO"
        Me.PSTUNPSO.ReadOnly = True
        Me.PSTUNPSO.Width = 90
        '
        'FGLPRD
        '
        Me.FGLPRD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FGLPRD.DataPropertyName = "PSFGLPRD"
        Me.FGLPRD.HeaderText = "FGLPRD"
        Me.FGLPRD.Name = "FGLPRD"
        Me.FGLPRD.ReadOnly = True
        Me.FGLPRD.Visible = False
        '
        'cmsPreDespachoBulto
        '
        Me.cmsPreDespachoBulto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmsPreDespachoBulto.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsPreDespachoBulto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAgregarBultoPreDespacho, Me.tsmiDesmarcarBultoPreDespacho})
        Me.cmsPreDespachoBulto.Name = "cmsPreDespachoBulto"
        Me.cmsPreDespachoBulto.Size = New System.Drawing.Size(182, 48)
        '
        'tsmiAgregarBultoPreDespacho
        '
        Me.tsmiAgregarBultoPreDespacho.Name = "tsmiAgregarBultoPreDespacho"
        Me.tsmiAgregarBultoPreDespacho.Size = New System.Drawing.Size(181, 22)
        Me.tsmiAgregarBultoPreDespacho.Text = "Agregar Bulto"
        '
        'tsmiDesmarcarBultoPreDespacho
        '
        Me.tsmiDesmarcarBultoPreDespacho.Name = "tsmiDesmarcarBultoPreDespacho"
        Me.tsmiDesmarcarBultoPreDespacho.Size = New System.Drawing.Size(181, 22)
        Me.tsmiDesmarcarBultoPreDespacho.Text = "Desmarcar Bulto"
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.hgItemsBulto)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.hgSubItemsBulto)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(755, 428)
        Me.KryptonSplitContainer1.SplitterDistance = 197
        Me.KryptonSplitContainer1.TabIndex = 4
        '
        'hgItemsBulto
        '
        Me.hgItemsBulto.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bshgStatusOcultarItems})
        Me.hgItemsBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgItemsBulto.HeaderVisibleSecondary = False
        Me.hgItemsBulto.Location = New System.Drawing.Point(0, 0)
        Me.hgItemsBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.hgItemsBulto.Name = "hgItemsBulto"
        '
        'hgItemsBulto.Panel
        '
        Me.hgItemsBulto.Panel.Controls.Add(Me.dgPreDespachoItemBulto)
        Me.hgItemsBulto.Size = New System.Drawing.Size(755, 197)
        Me.hgItemsBulto.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgItemsBulto.TabIndex = 2
        Me.hgItemsBulto.Text = "Items del Bultos"
        Me.hgItemsBulto.ValuesPrimary.Description = ""
        Me.hgItemsBulto.ValuesPrimary.Heading = "Items del Bultos"
        Me.hgItemsBulto.ValuesPrimary.Image = Nothing
        Me.hgItemsBulto.ValuesSecondary.Description = ""
        Me.hgItemsBulto.ValuesSecondary.Heading = "Description"
        Me.hgItemsBulto.ValuesSecondary.Image = Nothing
        '
        'bshgStatusOcultarItems
        '
        Me.bshgStatusOcultarItems.ExtraText = ""
        Me.bshgStatusOcultarItems.Image = Nothing
        Me.bshgStatusOcultarItems.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bshgStatusOcultarItems.Text = "Ocultar"
        Me.bshgStatusOcultarItems.ToolTipImage = Nothing
        Me.bshgStatusOcultarItems.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.bshgStatusOcultarItems.UniqueName = "4676E43EFA4144A44676E43EFA4144A4"
        '
        'dgPreDespachoItemBulto
        '
        Me.dgPreDespachoItemBulto.AllowUserToAddRows = False
        Me.dgPreDespachoItemBulto.AllowUserToDeleteRows = False
        Me.dgPreDespachoItemBulto.AllowUserToOrderColumns = True
        Me.dgPreDespachoItemBulto.AllowUserToResizeColumns = False
        Me.dgPreDespachoItemBulto.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dgPreDespachoItemBulto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgPreDespachoItemBulto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPreDespachoItemBulto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D_CREFFW, Me.D_NORCML, Me.D_NRITOC, Me.D_CIDPAQ, Me.D_TDITES, Me.D_QBLTSR, Me.PSNRPDTS, Me.PSNROSEC, Me.PNQCNTIT, Me.PSCIDPAQ})
        Me.dgPreDespachoItemBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPreDespachoItemBulto.Location = New System.Drawing.Point(0, 0)
        Me.dgPreDespachoItemBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.dgPreDespachoItemBulto.MultiSelect = False
        Me.dgPreDespachoItemBulto.Name = "dgPreDespachoItemBulto"
        Me.dgPreDespachoItemBulto.ReadOnly = True
        Me.dgPreDespachoItemBulto.RowHeadersWidth = 20
        Me.dgPreDespachoItemBulto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPreDespachoItemBulto.Size = New System.Drawing.Size(753, 162)
        Me.dgPreDespachoItemBulto.StandardTab = True
        Me.dgPreDespachoItemBulto.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgPreDespachoItemBulto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgPreDespachoItemBulto.TabIndex = 0
        '
        'D_CREFFW
        '
        Me.D_CREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.D_CREFFW.DataPropertyName = "PSCREFFW"
        Me.D_CREFFW.HeaderText = "Bulto"
        Me.D_CREFFW.Name = "D_CREFFW"
        Me.D_CREFFW.ReadOnly = True
        Me.D_CREFFW.Width = 77
        '
        'D_NORCML
        '
        Me.D_NORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.D_NORCML.DataPropertyName = "PSNORCML"
        Me.D_NORCML.HeaderText = "Nro. O/C"
        Me.D_NORCML.Name = "D_NORCML"
        Me.D_NORCML.ReadOnly = True
        '
        'D_NRITOC
        '
        Me.D_NRITOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.D_NRITOC.DataPropertyName = "PNNRITOC"
        Me.D_NRITOC.HeaderText = "Nro. Item O/C"
        Me.D_NRITOC.Name = "D_NRITOC"
        Me.D_NRITOC.ReadOnly = True
        Me.D_NRITOC.Width = 134
        '
        'D_CIDPAQ
        '
        Me.D_CIDPAQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.D_CIDPAQ.DataPropertyName = "PSCIDPAQ"
        Me.D_CIDPAQ.HeaderText = "Nro. Item"
        Me.D_CIDPAQ.Name = "D_CIDPAQ"
        Me.D_CIDPAQ.ReadOnly = True
        Me.D_CIDPAQ.Width = 104
        '
        'D_TDITES
        '
        Me.D_TDITES.DataPropertyName = "PSTDITES"
        Me.D_TDITES.HeaderText = "Descripción"
        Me.D_TDITES.Name = "D_TDITES"
        Me.D_TDITES.ReadOnly = True
        Me.D_TDITES.Width = 120
        '
        'D_QBLTSR
        '
        Me.D_QBLTSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.D_QBLTSR.DataPropertyName = "PNQBLTSR"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.D_QBLTSR.DefaultCellStyle = DataGridViewCellStyle8
        Me.D_QBLTSR.HeaderText = "Cant. Recibida"
        Me.D_QBLTSR.Name = "D_QBLTSR"
        Me.D_QBLTSR.ReadOnly = True
        Me.D_QBLTSR.Width = 137
        '
        'PSNRPDTS
        '
        Me.PSNRPDTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSNRPDTS.DataPropertyName = "PSNRPDTS"
        Me.PSNRPDTS.HeaderText = "Pedido Translado"
        Me.PSNRPDTS.Name = "PSNRPDTS"
        Me.PSNRPDTS.ReadOnly = True
        Me.PSNRPDTS.Width = 156
        '
        'PSNROSEC
        '
        Me.PSNROSEC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSNROSEC.DataPropertyName = "PSNROSEC"
        Me.PSNROSEC.HeaderText = "Posición"
        Me.PSNROSEC.Name = "PSNROSEC"
        Me.PSNROSEC.ReadOnly = True
        Me.PSNROSEC.Width = 96
        '
        'PNQCNTIT
        '
        Me.PNQCNTIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNQCNTIT.DataPropertyName = "PNQCNTIT"
        Me.PNQCNTIT.HeaderText = "Cantidad"
        Me.PNQCNTIT.Name = "PNQCNTIT"
        Me.PNQCNTIT.ReadOnly = True
        Me.PNQCNTIT.Visible = False
        '
        'PSCIDPAQ
        '
        Me.PSCIDPAQ.DataPropertyName = "PSCIDPAQ"
        Me.PSCIDPAQ.HeaderText = "PSCIDPAQ"
        Me.PSCIDPAQ.Name = "PSCIDPAQ"
        Me.PSCIDPAQ.ReadOnly = True
        Me.PSCIDPAQ.Visible = False
        Me.PSCIDPAQ.Width = 110
        '
        'hgSubItemsBulto
        '
        Me.hgSubItemsBulto.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bshgStatusOcultarSubItems})
        Me.hgSubItemsBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgSubItemsBulto.HeaderVisibleSecondary = False
        Me.hgSubItemsBulto.Location = New System.Drawing.Point(0, 0)
        Me.hgSubItemsBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.hgSubItemsBulto.Name = "hgSubItemsBulto"
        '
        'hgSubItemsBulto.Panel
        '
        Me.hgSubItemsBulto.Panel.Controls.Add(Me.dgPreDespachoSubItemBulto)
        Me.hgSubItemsBulto.Size = New System.Drawing.Size(755, 226)
        Me.hgSubItemsBulto.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgSubItemsBulto.TabIndex = 3
        Me.hgSubItemsBulto.Text = "Sub-Items del Bultos"
        Me.hgSubItemsBulto.ValuesPrimary.Description = ""
        Me.hgSubItemsBulto.ValuesPrimary.Heading = "Sub-Items del Bultos"
        Me.hgSubItemsBulto.ValuesPrimary.Image = Nothing
        Me.hgSubItemsBulto.ValuesSecondary.Description = ""
        Me.hgSubItemsBulto.ValuesSecondary.Heading = "Description"
        Me.hgSubItemsBulto.ValuesSecondary.Image = Nothing
        '
        'bshgStatusOcultarSubItems
        '
        Me.bshgStatusOcultarSubItems.AllowInheritExtraText = False
        Me.bshgStatusOcultarSubItems.ExtraText = ""
        Me.bshgStatusOcultarSubItems.Image = Nothing
        Me.bshgStatusOcultarSubItems.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bshgStatusOcultarSubItems.Text = "Ocultar"
        Me.bshgStatusOcultarSubItems.ToolTipImage = Nothing
        Me.bshgStatusOcultarSubItems.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.bshgStatusOcultarSubItems.UniqueName = "4676E43EFA4144A44676E43EFA4144A4"
        '
        'dgPreDespachoSubItemBulto
        '
        Me.dgPreDespachoSubItemBulto.AllowUserToAddRows = False
        Me.dgPreDespachoSubItemBulto.AllowUserToDeleteRows = False
        Me.dgPreDespachoSubItemBulto.AllowUserToOrderColumns = True
        Me.dgPreDespachoSubItemBulto.AllowUserToResizeColumns = False
        Me.dgPreDespachoSubItemBulto.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dgPreDespachoSubItemBulto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgPreDespachoSubItemBulto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPreDespachoSubItemBulto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.SBITOC, Me.TDITES, Me.QCNRCP})
        Me.dgPreDespachoSubItemBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPreDespachoSubItemBulto.Location = New System.Drawing.Point(0, 0)
        Me.dgPreDespachoSubItemBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.dgPreDespachoSubItemBulto.MultiSelect = False
        Me.dgPreDespachoSubItemBulto.Name = "dgPreDespachoSubItemBulto"
        Me.dgPreDespachoSubItemBulto.ReadOnly = True
        Me.dgPreDespachoSubItemBulto.RowHeadersWidth = 20
        Me.dgPreDespachoSubItemBulto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPreDespachoSubItemBulto.Size = New System.Drawing.Size(753, 191)
        Me.dgPreDespachoSubItemBulto.StandardTab = True
        Me.dgPreDespachoSubItemBulto.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgPreDespachoSubItemBulto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgPreDespachoSubItemBulto.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PSCIDPAQ"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nro. Item"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 104
        '
        'SBITOC
        '
        Me.SBITOC.DataPropertyName = "PNSBITOC"
        Me.SBITOC.HeaderText = "Nro. Sub Item"
        Me.SBITOC.Name = "SBITOC"
        Me.SBITOC.ReadOnly = True
        Me.SBITOC.Width = 133
        '
        'TDITES
        '
        Me.TDITES.DataPropertyName = "PSTDITES"
        Me.TDITES.HeaderText = "Descripción"
        Me.TDITES.Name = "TDITES"
        Me.TDITES.ReadOnly = True
        Me.TDITES.Width = 120
        '
        'QCNRCP
        '
        Me.QCNRCP.DataPropertyName = "PNQCNRCP"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.QCNRCP.DefaultCellStyle = DataGridViewCellStyle10
        Me.QCNRCP.HeaderText = "Cant. Recibida"
        Me.QCNRCP.Name = "QCNRCP"
        Me.QCNRCP.ReadOnly = True
        Me.QCNRCP.Width = 137
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bshgStatusOcultarFiltros, Me.bshgCerrarVentana})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Margin = New System.Windows.Forms.Padding(4)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Panel.Controls.Add(Me.btnGenerarPreDespacho)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCodigoPreDespacho)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCodigoPreDespacho)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Size = New System.Drawing.Size(1319, 153)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 2
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bshgStatusOcultarFiltros
        '
        Me.bshgStatusOcultarFiltros.ExtraText = ""
        Me.bshgStatusOcultarFiltros.Image = Nothing
        Me.bshgStatusOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bshgStatusOcultarFiltros.Text = "Ocultar"
        Me.bshgStatusOcultarFiltros.ToolTipImage = Nothing
        Me.bshgStatusOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bshgStatusOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bshgCerrarVentana
        '
        Me.bshgCerrarVentana.ExtraText = ""
        Me.bshgCerrarVentana.Image = Nothing
        Me.bshgCerrarVentana.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bshgCerrarVentana.Text = "Cerrar"
        Me.bshgCerrarVentana.ToolTipImage = Nothing
        Me.bshgCerrarVentana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bshgCerrarVentana.UniqueName = "E5550EDE24014FFFE5550EDE24014FFF"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(504, 42)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(61, 24)
        Me.KryptonLabel3.TabIndex = 51
        Me.KryptonLabel3.Text = "Planta : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(504, 11)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(73, 24)
        Me.KryptonLabel2.TabIndex = 50
        Me.KryptonLabel2.Text = "Division : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Division : "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(13, 16)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(88, 24)
        Me.KryptonLabel4.TabIndex = 49
        Me.KryptonLabel4.Text = "Compañia : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañia : "
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(599, 41)
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
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(324, 28)
        Me.UcPLanta_Cmb011.TabIndex = 3
        Me.UcPLanta_Cmb011.Usuario = ""
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(599, 11)
        Me.UcDivision_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(324, 28)
        Me.UcDivision_Cmb011.TabIndex = 1
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(144, 11)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(341, 28)
        Me.UcCompania_Cmb011.TabIndex = 0
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(144, 42)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(341, 26)
        Me.txtCliente.TabIndex = 2
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(1113, 16)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(91, 89)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'btnGenerarPreDespacho
        '
        Me.btnGenerarPreDespacho.Location = New System.Drawing.Point(1212, 16)
        Me.btnGenerarPreDespacho.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerarPreDespacho.Name = "btnGenerarPreDespacho"
        Me.btnGenerarPreDespacho.Size = New System.Drawing.Size(91, 89)
        Me.btnGenerarPreDespacho.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGenerarPreDespacho.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnGenerarPreDespacho.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnGenerarPreDespacho.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGenerarPreDespacho.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnGenerarPreDespacho.TabIndex = 6
        Me.btnGenerarPreDespacho.Text = "&Despacho"
        Me.btnGenerarPreDespacho.Values.ExtraText = ""
        Me.btnGenerarPreDespacho.Values.Image = CType(resources.GetObject("btnGenerarPreDespacho.Values.Image"), System.Drawing.Image)
        Me.btnGenerarPreDespacho.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGenerarPreDespacho.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGenerarPreDespacho.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGenerarPreDespacho.Values.Text = "&Despacho"
        '
        'txtCodigoPreDespacho
        '
        Me.txtCodigoPreDespacho.Location = New System.Drawing.Point(144, 73)
        Me.txtCodigoPreDespacho.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoPreDespacho.MaxLength = 100
        Me.txtCodigoPreDespacho.Name = "txtCodigoPreDespacho"
        Me.txtCodigoPreDespacho.Size = New System.Drawing.Size(341, 26)
        Me.txtCodigoPreDespacho.TabIndex = 4
        '
        'lblCodigoPreDespacho
        '
        Me.lblCodigoPreDespacho.Location = New System.Drawing.Point(13, 76)
        Me.lblCodigoPreDespacho.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCodigoPreDespacho.Name = "lblCodigoPreDespacho"
        Me.lblCodigoPreDespacho.Size = New System.Drawing.Size(120, 24)
        Me.lblCodigoPreDespacho.TabIndex = 3
        Me.lblCodigoPreDespacho.Text = "Nro. Despacho : "
        Me.lblCodigoPreDespacho.Values.ExtraText = ""
        Me.lblCodigoPreDespacho.Values.Image = Nothing
        Me.lblCodigoPreDespacho.Values.Text = "Nro. Despacho : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 46)
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
        Me.KryptonLabel5.Location = New System.Drawing.Point(1063, 46)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(41, 69)
        Me.KryptonLabel5.TabIndex = 36
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NITEMS"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Items"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 63
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NROCTL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nro. Despacho"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 112
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NROPLT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nro Paleta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 89
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SMTRCP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Motivo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 72
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SMTRCP_D"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Motivo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 72
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SSNCRG"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sentido"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 76
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SSNCRG_D"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Sentido"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 76
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CREFFW"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 64
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DESCWB"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 96
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FREFFW"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 66
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "QREFFW"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 83
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TIPBTO"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Tipo Bulto"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 89
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn14.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 60
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TUNPSO"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 74
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "CREFFW"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn16.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 64
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NORCML"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Nro. O/C"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 81
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "NRITOC"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Nro. Item O/C"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 106
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CIDPAQ"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Nro. Item"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 83
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TDITES"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = "0"
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn20.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 96
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = "0"
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn21.HeaderText = "Cant. Recibida"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 110
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "CIDPAQ"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = "0"
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn22.HeaderText = "Nro. Item"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 83
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "SBITOC"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = "0"
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn23.HeaderText = "Nro. Sub Item"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 106
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        Me.DataGridViewTextBoxColumn24.Width = 96
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "QCNRCP"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = "0"
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn25.HeaderText = "Cant. Recibida"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 110
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "NRITOC"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Nro. Item O/C"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 106
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "CIDPAQ"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = "0"
        Me.DataGridViewTextBoxColumn27.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn27.HeaderText = "Nro. Item"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Width = 83
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 96
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N2"
        DataGridViewCellStyle20.NullValue = "0"
        Me.DataGridViewTextBoxColumn29.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn29.HeaderText = "Cant. Recibida"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 110
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "CIDPAQ"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Nro. Item"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 83
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "SBITOC"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Nro. Sub Item"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Width = 106
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Width = 96
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "QCNRCP"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = "0"
        Me.DataGridViewTextBoxColumn33.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn33.HeaderText = "Cant. Recibida"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 110
        '
        'M_NROPLT
        '
        Me.M_NROPLT.DataPropertyName = "PNNITEMS"
        Me.M_NROPLT.HeaderText = "Items"
        Me.M_NROPLT.Name = "M_NROPLT"
        Me.M_NROPLT.ReadOnly = True
        Me.M_NROPLT.Width = 78
        '
        'M_NROCTL
        '
        Me.M_NROCTL.DataPropertyName = "PNNROCTL"
        Me.M_NROCTL.HeaderText = "Nro. Despacho"
        Me.M_NROCTL.Name = "M_NROCTL"
        Me.M_NROCTL.ReadOnly = True
        Me.M_NROCTL.Width = 140
        '
        'PNNROPLT
        '
        Me.PNNROPLT.DataPropertyName = "PNNROPLT"
        Me.PNNROPLT.HeaderText = "NROPLT"
        Me.PNNROPLT.Name = "PNNROPLT"
        Me.PNNROPLT.ReadOnly = True
        Me.PNNROPLT.Visible = False
        Me.PNNROPLT.Width = 95
        '
        'PSNMMDT
        '
        Me.PSNMMDT.DataPropertyName = "PSNMMDT"
        Me.PSNMMDT.HeaderText = "Medio Sugerido"
        Me.PSNMMDT.Name = "PSNMMDT"
        Me.PSNMMDT.ReadOnly = True
        Me.PSNMMDT.Width = 149
        '
        'PSCRTLTE
        '
        Me.PSCRTLTE.DataPropertyName = "PSCRTLTE"
        Me.PSCRTLTE.HeaderText = "Criterio Lote"
        Me.PSCRTLTE.Name = "PSCRTLTE"
        Me.PSCRTLTE.ReadOnly = True
        Me.PSCRTLTE.Width = 124
        '
        'PNNGUIRM
        '
        Me.PNNGUIRM.DataPropertyName = "PNNGUIRM"
        Me.PNNGUIRM.HeaderText = "Guía de Remisión"
        Me.PNNGUIRM.Name = "PNNGUIRM"
        Me.PNNGUIRM.ReadOnly = True
        Me.PNNGUIRM.Visible = False
        Me.PNNGUIRM.Width = 158
        '
        'PSSMTRCP
        '
        Me.PSSMTRCP.DataPropertyName = "PSSMTRCP"
        Me.PSSMTRCP.HeaderText = "Motivo"
        Me.PSSMTRCP.Name = "PSSMTRCP"
        Me.PSSMTRCP.ReadOnly = True
        Me.PSSMTRCP.Visible = False
        Me.PSSMTRCP.Width = 89
        '
        'PSSMTRCP_D
        '
        Me.PSSMTRCP_D.DataPropertyName = "PSSMTRCP_D"
        Me.PSSMTRCP_D.HeaderText = "Motivo"
        Me.PSSMTRCP_D.Name = "PSSMTRCP_D"
        Me.PSSMTRCP_D.ReadOnly = True
        Me.PSSMTRCP_D.Width = 89
        '
        'PSSSNCRG
        '
        Me.PSSSNCRG.DataPropertyName = "PSSSNCRG"
        Me.PSSSNCRG.HeaderText = "Sentido"
        Me.PSSSNCRG.Name = "PSSSNCRG"
        Me.PSSSNCRG.ReadOnly = True
        Me.PSSSNCRG.Visible = False
        Me.PSSSNCRG.Width = 93
        '
        'PSSSNCRG_D
        '
        Me.PSSSNCRG_D.DataPropertyName = "PSSSNCRG_D"
        Me.PSSSNCRG_D.HeaderText = "Sentido"
        Me.PSSSNCRG_D.Name = "PSSSNCRG_D"
        Me.PSSSNCRG_D.ReadOnly = True
        Me.PSSSNCRG_D.Width = 93
        '
        'PSCOD_STPDES
        '
        Me.PSCOD_STPDES.DataPropertyName = "PSCOD_STPDES"
        Me.PSCOD_STPDES.HeaderText = "COD_STPDES"
        Me.PSCOD_STPDES.Name = "PSCOD_STPDES"
        Me.PSCOD_STPDES.ReadOnly = True
        Me.PSCOD_STPDES.Visible = False
        Me.PSCOD_STPDES.Width = 130
        '
        'frmPreDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 841)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPreDespacho"
        Me.Text = "Pre-Despachos de Bultos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainerHorizontal.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerHorizontal.Panel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainerHorizontal.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerHorizontal.Panel2.ResumeLayout(False)
        CType(Me.kryptonSplitContainerHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerHorizontal.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        CType(Me.hgPreDespacho.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgPreDespacho.Panel.ResumeLayout(False)
        CType(Me.hgPreDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgPreDespacho.ResumeLayout(False)
        CType(Me.dgPreDespachos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgGuiaRemision.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaRemision.Panel.ResumeLayout(False)
        CType(Me.hgGuiaRemision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaRemision.ResumeLayout(False)
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonSplitContainerVertical.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerVertical.Panel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainerVertical.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerVertical.Panel2.ResumeLayout(False)
        CType(Me.kryptonSplitContainerVertical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerVertical.ResumeLayout(False)
        CType(Me.hgBulto.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBulto.Panel.ResumeLayout(False)
        CType(Me.hgBulto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBulto.ResumeLayout(False)
        CType(Me.dgPreDespachoBultos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPreDespachoBulto.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.hgItemsBulto.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgItemsBulto.Panel.ResumeLayout(False)
        CType(Me.hgItemsBulto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgItemsBulto.ResumeLayout(False)
        CType(Me.dgPreDespachoItemBulto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgSubItemsBulto.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgSubItemsBulto.Panel.ResumeLayout(False)
        CType(Me.hgSubItemsBulto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgSubItemsBulto.ResumeLayout(False)
        CType(Me.dgPreDespachoSubItemBulto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnGenerarPreDespacho As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtCodigoPreDespacho As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCodigoPreDespacho As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents bshgStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmsPreDespachoBulto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiDesmarcarBultoPreDespacho As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents kryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents kryptonSplitContainerHorizontal As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tsmiAgregarBultoPreDespacho As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bshgCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Private WithEvents kryptonSplitContainerVertical As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents hgBulto As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bshgAgregar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bshgElimnar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgPreDespachoBultos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgItemsBulto As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bshgStatusOcultarItems As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgPreDespachoItemBulto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgSubItemsBulto As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bshgStatusOcultarSubItems As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgPreDespachoSubItemBulto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_DESCWB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TIPBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QPSOBL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SBITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents hgGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaAnularGR As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaVistaPreviaGR As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgGuiasRemision As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents GR_NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_FGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SMTGRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_MOTTRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTNMMDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRGUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hgPreDespacho As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bshgGuiaRemision As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bshVistraPreviaGuia As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bshgStatusOcultarPreDespacho As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgPreDespachos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnOcultar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnQuitarrPedido As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnAgregarPedido As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents D_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CIDPAQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QBLTSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNRPDTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNROSEC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCIDPAQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LECTURA As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NRPLTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROPLT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESCWB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaIngAlmacenCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTIPBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQPSOBL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FGLPRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NROPLT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NROCTL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNROPLT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNMMDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCRTLTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSMTRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSMTRCP_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSSNCRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSSNCRG_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCOD_STPDES As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
