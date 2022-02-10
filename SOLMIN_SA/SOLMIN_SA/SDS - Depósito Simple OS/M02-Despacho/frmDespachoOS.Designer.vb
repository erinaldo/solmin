<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespachoOS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDespachoOS))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.Contenedor1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.Contenedor2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dgMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPMR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QSLMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPFM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPGR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMMRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCMMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QWRMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SALDIS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnRealizarDespacho = New System.Windows.Forms.ToolStripButton
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator
        Me.hgOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaDespacharMercaderiaOS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaOcultar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtgKardex = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.dgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.S_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TCMPMR = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.tsMenuProcesar = New System.Windows.Forms.ToolStrip
        Me.tss08 = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminarItem = New System.Windows.Forms.ToolStripButton
        Me.tss06 = New System.Windows.Forms.ToolStripSeparator
        Me.btnProcesarDespacho = New System.Windows.Forms.ToolStripButton
        Me.tss05 = New System.Windows.Forms.ToolStripSeparator
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPLanta_Cmb011 = New RANSA.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.cmbDeposito = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMarca = New RANSA.Controls.ucAyudaConectado
        Me.txtCliente = New RANSA.Controls.Cliente.ucCliente_TxtF01
        Me.grpLeyenda = New System.Windows.Forms.GroupBox
        Me.lblDetalleOpcional = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDetalleObligatorio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOpcional = New System.Windows.Forms.Label
        Me.lblObligatorio = New System.Windows.Forms.Label
        Me.lblPublicarWEB = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblMercadaeria = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.PSCTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDESTIPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDESALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNTDSDES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDESZONA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQSLMC2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQSLMP2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.Contenedor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contenedor1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor1.Panel1.SuspendLayout()
        CType(Me.Contenedor1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor1.Panel2.SuspendLayout()
        Me.Contenedor1.SuspendLayout()
        CType(Me.Contenedor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contenedor2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor2.Panel1.SuspendLayout()
        CType(Me.Contenedor2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor2.Panel2.SuspendLayout()
        Me.Contenedor2.SuspendLayout()
        CType(Me.dgMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.hgOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgOS.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgOS.Panel.SuspendLayout()
        Me.hgOS.SuspendLayout()
        CType(Me.dtgKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuProcesar.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.grpLeyenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.Contenedor1)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1254, 526)
        Me.KryptonPanel.TabIndex = 0
        '
        'Contenedor1
        '
        Me.Contenedor1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Contenedor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor1.Location = New System.Drawing.Point(0, 115)
        Me.Contenedor1.Name = "Contenedor1"
        Me.Contenedor1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Contenedor1.Panel1
        '
        Me.Contenedor1.Panel1.Controls.Add(Me.Contenedor2)
        '
        'Contenedor1.Panel2
        '
        Me.Contenedor1.Panel2.Controls.Add(Me.dgMercaderiaSeleccionada)
        Me.Contenedor1.Panel2.Controls.Add(Me.tsMenuProcesar)
        Me.Contenedor1.Size = New System.Drawing.Size(1254, 411)
        Me.Contenedor1.SplitterDistance = 206
        Me.Contenedor1.TabIndex = 99
        '
        'Contenedor2
        '
        Me.Contenedor2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor2.Location = New System.Drawing.Point(0, 0)
        Me.Contenedor2.Name = "Contenedor2"
        '
        'Contenedor2.Panel1
        '
        Me.Contenedor2.Panel1.Controls.Add(Me.dgMercaderia)
        Me.Contenedor2.Panel1.Controls.Add(Me.tsMenuOpciones)
        '
        'Contenedor2.Panel2
        '
        Me.Contenedor2.Panel2.Controls.Add(Me.hgOS)
        Me.Contenedor2.Size = New System.Drawing.Size(1254, 206)
        Me.Contenedor2.SplitterDistance = 664
        Me.Contenedor2.TabIndex = 98
        '
        'dgMercaderia
        '
        Me.dgMercaderia.AllowUserToAddRows = False
        Me.dgMercaderia.AllowUserToDeleteRows = False
        Me.dgMercaderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMercaderia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORDSR, Me.CMRCD, Me.TCMPMR, Me.QSLMC, Me.TCMPFM, Me.TCMPGR, Me.TCMMRC, Me.QCMMC, Me.QWRMC, Me.SALDIS})
        Me.dgMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderia.Location = New System.Drawing.Point(0, 25)
        Me.dgMercaderia.Name = "dgMercaderia"
        Me.dgMercaderia.ReadOnly = True
        Me.dgMercaderia.Size = New System.Drawing.Size(664, 181)
        Me.dgMercaderia.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderia.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderia.TabIndex = 93
        '
        'NORDSR
        '
        Me.NORDSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORDSR.DataPropertyName = "PNNORDSR"
        Me.NORDSR.HeaderText = "OS"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.ReadOnly = True
        Me.NORDSR.Width = 51
        '
        'CMRCD
        '
        Me.CMRCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMRCD.DataPropertyName = "PSCMRCD"
        Me.CMRCD.HeaderText = "Código"
        Me.CMRCD.Name = "CMRCD"
        Me.CMRCD.ReadOnly = True
        Me.CMRCD.Width = 75
        '
        'TCMPMR
        '
        Me.TCMPMR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPMR.DataPropertyName = "PSTCMPMR"
        Me.TCMPMR.HeaderText = "Mercadería"
        Me.TCMPMR.Name = "TCMPMR"
        Me.TCMPMR.ReadOnly = True
        Me.TCMPMR.Width = 95
        '
        'QSLMC
        '
        Me.QSLMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QSLMC.DataPropertyName = "PNQSLMC"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QSLMC.DefaultCellStyle = DataGridViewCellStyle1
        Me.QSLMC.HeaderText = "Saldo"
        Me.QSLMC.Name = "QSLMC"
        Me.QSLMC.ReadOnly = True
        Me.QSLMC.Width = 65
        '
        'TCMPFM
        '
        Me.TCMPFM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPFM.DataPropertyName = "PSTCMPFM"
        Me.TCMPFM.HeaderText = "Familia"
        Me.TCMPFM.Name = "TCMPFM"
        Me.TCMPFM.ReadOnly = True
        Me.TCMPFM.Width = 74
        '
        'TCMPGR
        '
        Me.TCMPGR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPGR.DataPropertyName = "PSTCMPGR"
        Me.TCMPGR.HeaderText = "Grupo"
        Me.TCMPGR.Name = "TCMPGR"
        Me.TCMPGR.ReadOnly = True
        Me.TCMPGR.Width = 69
        '
        'TCMMRC
        '
        Me.TCMMRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMMRC.DataPropertyName = "PSTCMMRC"
        Me.TCMMRC.HeaderText = "Marca"
        Me.TCMMRC.Name = "TCMMRC"
        Me.TCMMRC.ReadOnly = True
        Me.TCMMRC.Width = 69
        '
        'QCMMC
        '
        Me.QCMMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QCMMC.DataPropertyName = "PNQCMMC"
        Me.QCMMC.HeaderText = "Comprometido"
        Me.QCMMC.Name = "QCMMC"
        Me.QCMMC.ReadOnly = True
        Me.QCMMC.Width = 118
        '
        'QWRMC
        '
        Me.QWRMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QWRMC.DataPropertyName = "PNQWRMC"
        Me.QWRMC.HeaderText = "Warran"
        Me.QWRMC.Name = "QWRMC"
        Me.QWRMC.ReadOnly = True
        Me.QWRMC.Width = 74
        '
        'SALDIS
        '
        Me.SALDIS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SALDIS.DataPropertyName = "PNSALDIS"
        Me.SALDIS.HeaderText = "Disponible"
        Me.SALDIS.Name = "SALDIS"
        Me.SALDIS.ReadOnly = True
        Me.SALDIS.Width = 92
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTitulo, Me.btnCancelar, Me.ToolStripSeparator1, Me.btnRealizarDespacho, Me.tssSep_03})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(664, 25)
        Me.tsMenuOpciones.TabIndex = 94
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(121, 22)
        Me.lblTitulo.Text = "Lista de Mercadería"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnRealizarDespacho
        '
        Me.btnRealizarDespacho.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnRealizarDespacho.Image = CType(resources.GetObject("btnRealizarDespacho.Image"), System.Drawing.Image)
        Me.btnRealizarDespacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRealizarDespacho.Name = "btnRealizarDespacho"
        Me.btnRealizarDespacho.Size = New System.Drawing.Size(104, 22)
        Me.btnRealizarDespacho.Text = "Iniciar Proceso"
        '
        'tssSep_03
        '
        Me.tssSep_03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_03.Name = "tssSep_03"
        Me.tssSep_03.Size = New System.Drawing.Size(6, 25)
        '
        'hgOS
        '
        Me.hgOS.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaDespacharMercaderiaOS, Me.bsaOcultar})
        Me.hgOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgOS.HeaderVisibleSecondary = False
        Me.hgOS.Location = New System.Drawing.Point(0, 0)
        Me.hgOS.Name = "hgOS"
        '
        'hgOS.Panel
        '
        Me.hgOS.Panel.Controls.Add(Me.dtgKardex)
        Me.hgOS.Size = New System.Drawing.Size(585, 206)
        Me.hgOS.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgOS.TabIndex = 95
        Me.hgOS.Text = "Almacén"
        Me.hgOS.ValuesPrimary.Description = ""
        Me.hgOS.ValuesPrimary.Heading = "Almacén"
        Me.hgOS.ValuesPrimary.Image = Nothing
        Me.hgOS.ValuesSecondary.Description = ""
        Me.hgOS.ValuesSecondary.Heading = "Description"
        Me.hgOS.ValuesSecondary.Image = Nothing
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
        'dtgKardex
        '
        Me.dtgKardex.AllowUserToAddRows = False
        Me.dtgKardex.AllowUserToDeleteRows = False
        Me.dtgKardex.AllowUserToResizeColumns = False
        Me.dtgKardex.AllowUserToResizeRows = False
        Me.dtgKardex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgKardex.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSCTPALM, Me.PSDESTIPO, Me.PSCALMC, Me.PSDESALM, Me.PNTDSDES, Me.PSTPLNTA, Me.PSCZNALM, Me.PSDESZONA, Me.PNQSLMC2, Me.PNQSLMP2})
        Me.dtgKardex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgKardex.Location = New System.Drawing.Point(0, 0)
        Me.dtgKardex.MultiSelect = False
        Me.dtgKardex.Name = "dtgKardex"
        Me.dtgKardex.ReadOnly = True
        Me.dtgKardex.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgKardex.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgKardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgKardex.Size = New System.Drawing.Size(583, 175)
        Me.dtgKardex.StandardTab = True
        Me.dtgKardex.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgKardex.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgKardex.TabIndex = 25
        '
        'dgMercaderiaSeleccionada
        '
        Me.dgMercaderiaSeleccionada.AllowUserToAddRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToDeleteRows = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeColumns = False
        Me.dgMercaderiaSeleccionada.AllowUserToResizeRows = False
        Me.dgMercaderiaSeleccionada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaSeleccionada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_CMRCD, Me.S_TCMPMR, Me.S_NORDSR, Me.S_NCNTR, Me.S_NCRCTC, Me.S_NAUTR, Me.S_CUNCNT, Me.S_CUNPST, Me.S_CUNVLT, Me.S_NORCCL, Me.S_NGUICL, Me.S_NRUCLL, Me.S_STPING, Me.S_CTPALM, Me.S_CALMC, Me.S_TCMPAL, Me.S_CZNALM, Me.S_TCMZNA, Me.S_QTRMC, Me.S_QTRMP, Me.S_QDSVGN, Me.S_CCNTD, Me.S_CTPOCN, Me.S_FUNDS2, Me.S_CTPDPS, Me.S_TOBSRV})
        Me.dgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 25)
        Me.dgMercaderiaSeleccionada.MultiSelect = False
        Me.dgMercaderiaSeleccionada.Name = "dgMercaderiaSeleccionada"
        Me.dgMercaderiaSeleccionada.ReadOnly = True
        Me.dgMercaderiaSeleccionada.RowHeadersWidth = 20
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaSeleccionada.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgMercaderiaSeleccionada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaSeleccionada.Size = New System.Drawing.Size(1254, 175)
        Me.dgMercaderiaSeleccionada.StandardTab = True
        Me.dgMercaderiaSeleccionada.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderiaSeleccionada.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderiaSeleccionada.TabIndex = 96
        '
        'S_CMRCD
        '
        Me.S_CMRCD.DataPropertyName = "PSCMRCD"
        Me.S_CMRCD.HeaderText = "Cód. Ransa"
        Me.S_CMRCD.Name = "S_CMRCD"
        Me.S_CMRCD.ReadOnly = True
        Me.S_CMRCD.Width = 95
        '
        'S_TCMPMR
        '
        Me.S_TCMPMR.DataPropertyName = "PSTCMPMR"
        Me.S_TCMPMR.HeaderText = "Detalle"
        Me.S_TCMPMR.Name = "S_TCMPMR"
        Me.S_TCMPMR.ReadOnly = True
        Me.S_TCMPMR.Width = 72
        '
        'S_NORDSR
        '
        Me.S_NORDSR.DataPropertyName = "PNNORDSR"
        Me.S_NORDSR.HeaderText = "Orden Servicio"
        Me.S_NORDSR.Name = "S_NORDSR"
        Me.S_NORDSR.ReadOnly = True
        Me.S_NORDSR.Width = 113
        '
        'S_NCNTR
        '
        Me.S_NCNTR.DataPropertyName = "PNNCNTR"
        Me.S_NCNTR.HeaderText = "No. Contrato"
        Me.S_NCNTR.Name = "S_NCNTR"
        Me.S_NCNTR.ReadOnly = True
        Me.S_NCNTR.Width = 105
        '
        'S_NCRCTC
        '
        Me.S_NCRCTC.DataPropertyName = "PNNCRCTC"
        Me.S_NCRCTC.HeaderText = "Correlativo"
        Me.S_NCRCTC.Name = "S_NCRCTC"
        Me.S_NCRCTC.ReadOnly = True
        Me.S_NCRCTC.Width = 94
        '
        'S_NAUTR
        '
        Me.S_NAUTR.DataPropertyName = "PNNAUTR"
        Me.S_NAUTR.HeaderText = "No Autorización"
        Me.S_NAUTR.Name = "S_NAUTR"
        Me.S_NAUTR.ReadOnly = True
        Me.S_NAUTR.Width = 122
        '
        'S_CUNCNT
        '
        Me.S_CUNCNT.DataPropertyName = "PSCUNCNT"
        Me.S_CUNCNT.HeaderText = "U. Cantidad"
        Me.S_CUNCNT.Name = "S_CUNCNT"
        Me.S_CUNCNT.ReadOnly = True
        Me.S_CUNCNT.Width = 98
        '
        'S_CUNPST
        '
        Me.S_CUNPST.DataPropertyName = "PSCUNPST"
        Me.S_CUNPST.HeaderText = "U. Peso"
        Me.S_CUNPST.Name = "S_CUNPST"
        Me.S_CUNPST.ReadOnly = True
        Me.S_CUNPST.Width = 75
        '
        'S_CUNVLT
        '
        Me.S_CUNVLT.DataPropertyName = "PSCUNVLT"
        Me.S_CUNVLT.HeaderText = "U. Valor"
        Me.S_CUNVLT.Name = "S_CUNVLT"
        Me.S_CUNVLT.ReadOnly = True
        Me.S_CUNVLT.Width = 77
        '
        'S_NORCCL
        '
        Me.S_NORCCL.DataPropertyName = "PSNORCCL"
        Me.S_NORCCL.HeaderText = "No O/C"
        Me.S_NORCCL.Name = "S_NORCCL"
        Me.S_NORCCL.ReadOnly = True
        Me.S_NORCCL.Width = 77
        '
        'S_NGUICL
        '
        Me.S_NGUICL.DataPropertyName = "PSNGUICL"
        Me.S_NGUICL.HeaderText = "No Guía Cliente"
        Me.S_NGUICL.Name = "S_NGUICL"
        Me.S_NGUICL.ReadOnly = True
        Me.S_NGUICL.Width = 119
        '
        'S_NRUCLL
        '
        Me.S_NRUCLL.DataPropertyName = "PSNRUCLL"
        Me.S_NRUCLL.HeaderText = "No RUC Cliente"
        Me.S_NRUCLL.Name = "S_NRUCLL"
        Me.S_NRUCLL.ReadOnly = True
        Me.S_NRUCLL.Width = 118
        '
        'S_STPING
        '
        Me.S_STPING.DataPropertyName = "PSSTPING"
        Me.S_STPING.HeaderText = "Tipo Mov."
        Me.S_STPING.Name = "S_STPING"
        Me.S_STPING.ReadOnly = True
        Me.S_STPING.Width = 90
        '
        'S_CTPALM
        '
        Me.S_CTPALM.DataPropertyName = "PSCTPALM"
        Me.S_CTPALM.HeaderText = "Tipo Almacén"
        Me.S_CTPALM.Name = "S_CTPALM"
        Me.S_CTPALM.ReadOnly = True
        Me.S_CTPALM.Width = 110
        '
        'S_CALMC
        '
        Me.S_CALMC.DataPropertyName = "PSCALMC"
        Me.S_CALMC.HeaderText = "Almacén"
        Me.S_CALMC.Name = "S_CALMC"
        Me.S_CALMC.ReadOnly = True
        Me.S_CALMC.Width = 83
        '
        'S_TCMPAL
        '
        Me.S_TCMPAL.DataPropertyName = "PSTCMPAL"
        Me.S_TCMPAL.HeaderText = "Detalle"
        Me.S_TCMPAL.Name = "S_TCMPAL"
        Me.S_TCMPAL.ReadOnly = True
        Me.S_TCMPAL.Width = 72
        '
        'S_CZNALM
        '
        Me.S_CZNALM.DataPropertyName = "PSCZNALM"
        Me.S_CZNALM.HeaderText = "Zona"
        Me.S_CZNALM.Name = "S_CZNALM"
        Me.S_CZNALM.ReadOnly = True
        Me.S_CZNALM.Width = 63
        '
        'S_TCMZNA
        '
        Me.S_TCMZNA.DataPropertyName = "PSTCMZNA"
        Me.S_TCMZNA.HeaderText = "Detalle"
        Me.S_TCMZNA.Name = "S_TCMZNA"
        Me.S_TCMZNA.ReadOnly = True
        Me.S_TCMZNA.Width = 72
        '
        'S_QTRMC
        '
        Me.S_QTRMC.DataPropertyName = "PNQTRMC"
        Me.S_QTRMC.HeaderText = "Cantidad"
        Me.S_QTRMC.Name = "S_QTRMC"
        Me.S_QTRMC.ReadOnly = True
        Me.S_QTRMC.Width = 84
        '
        'S_QTRMP
        '
        Me.S_QTRMP.DataPropertyName = "PNQTRMP"
        Me.S_QTRMP.HeaderText = "Peso"
        Me.S_QTRMP.Name = "S_QTRMP"
        Me.S_QTRMP.ReadOnly = True
        Me.S_QTRMP.Width = 61
        '
        'S_QDSVGN
        '
        Me.S_QDSVGN.DataPropertyName = "PNQDSVGN"
        Me.S_QDSVGN.HeaderText = "No Días Vigencia"
        Me.S_QDSVGN.Name = "S_QDSVGN"
        Me.S_QDSVGN.ReadOnly = True
        Me.S_QDSVGN.Width = 125
        '
        'S_CCNTD
        '
        Me.S_CCNTD.DataPropertyName = "PSCCNTD"
        Me.S_CCNTD.HeaderText = "Contenedor"
        Me.S_CCNTD.Name = "S_CCNTD"
        Me.S_CCNTD.ReadOnly = True
        Me.S_CCNTD.Width = 99
        '
        'S_CTPOCN
        '
        Me.S_CTPOCN.DataPropertyName = "PSCTPOCN"
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
        Me.S_FUNDS2.DataPropertyName = "PSFUNDS2"
        Me.S_FUNDS2.HeaderText = "U. Despacho"
        Me.S_FUNDS2.Name = "S_FUNDS2"
        Me.S_FUNDS2.ReadOnly = True
        Me.S_FUNDS2.Width = 102
        '
        'S_CTPDPS
        '
        Me.S_CTPDPS.DataPropertyName = "PSCTPDPS"
        Me.S_CTPDPS.HeaderText = "Tipo Depósito"
        Me.S_CTPDPS.Name = "S_CTPDPS"
        Me.S_CTPDPS.ReadOnly = True
        Me.S_CTPDPS.Width = 110
        '
        'S_TOBSRV
        '
        Me.S_TOBSRV.DataPropertyName = "PSTOBSRV"
        Me.S_TOBSRV.HeaderText = "Observaciones"
        Me.S_TOBSRV.Name = "S_TOBSRV"
        Me.S_TOBSRV.ReadOnly = True
        Me.S_TOBSRV.Width = 113
        '
        'tsMenuProcesar
        '
        Me.tsMenuProcesar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuProcesar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuProcesar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss08, Me.btnEliminarItem, Me.tss06, Me.btnProcesarDespacho, Me.tss05})
        Me.tsMenuProcesar.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuProcesar.Name = "tsMenuProcesar"
        Me.tsMenuProcesar.Size = New System.Drawing.Size(1254, 25)
        Me.tsMenuProcesar.TabIndex = 97
        '
        'tss08
        '
        Me.tss08.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tss08.Name = "tss08"
        Me.tss08.Size = New System.Drawing.Size(121, 22)
        Me.tss08.Text = "Lista de Mercadería"
        '
        'btnEliminarItem
        '
        Me.btnEliminarItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminarItem.Image = CType(resources.GetObject("btnEliminarItem.Image"), System.Drawing.Image)
        Me.btnEliminarItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarItem.Name = "btnEliminarItem"
        Me.btnEliminarItem.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminarItem.Text = "&Eliminar"
        '
        'tss06
        '
        Me.tss06.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss06.Name = "tss06"
        Me.tss06.Size = New System.Drawing.Size(6, 25)
        '
        'btnProcesarDespacho
        '
        Me.btnProcesarDespacho.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesarDespacho.Image = CType(resources.GetObject("btnProcesarDespacho.Image"), System.Drawing.Image)
        Me.btnProcesarDespacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesarDespacho.Name = "btnProcesarDespacho"
        Me.btnProcesarDespacho.Size = New System.Drawing.Size(127, 22)
        Me.btnProcesarDespacho.Text = "&Procesar Despacho"
        '
        'tss05
        '
        Me.tss05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss05.Name = "tss05"
        Me.tss05.Size = New System.Drawing.Size(6, 25)
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
        Me.hgFiltros.Panel.Controls.Add(Me.cmbDeposito)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgFiltros.Panel.Controls.Add(Me.txtMarca)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.grpLeyenda)
        Me.hgFiltros.Panel.Controls.Add(Me.lblPublicarWEB)
        Me.hgFiltros.Panel.Controls.Add(Me.txtMercaderia)
        Me.hgFiltros.Panel.Controls.Add(Me.lblMercadaeria)
        Me.hgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(1254, 115)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 2
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
        Me.KryptonLabel13.Location = New System.Drawing.Point(390, 15)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(50, 20)
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
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(446, 15)
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
        Me.UcPLanta_Cmb011.TabIndex = 94
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'cmbDeposito
        '
        Me.cmbDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeposito.DropDownWidth = 121
        Me.cmbDeposito.FormattingEnabled = False
        Me.cmbDeposito.ItemHeight = 15
        Me.cmbDeposito.Location = New System.Drawing.Point(85, 43)
        Me.cmbDeposito.Name = "cmbDeposito"
        Me.cmbDeposito.Size = New System.Drawing.Size(263, 23)
        Me.cmbDeposito.TabIndex = 93
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(14, 43)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel2.TabIndex = 92
        Me.KryptonLabel2.Text = "Deposito : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Deposito : "
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.Color.Transparent
        Me.txtMarca.CriterioBusqueda = RANSA.Controls.ParametrosGlobales.TipoBusqueda.Otros
        Me.txtMarca.DataSource = Nothing
        Me.txtMarca.DispleyMember = ""
        Me.txtMarca.ListColumnas = Nothing
        Me.txtMarca.Location = New System.Drawing.Point(446, 42)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(278, 27)
        Me.txtMarca.TabIndex = 90
        Me.txtMarca.ValueMember = ""
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(86, 16)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
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
        Me.grpLeyenda.Location = New System.Drawing.Point(1478, 12)
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
        'lblPublicarWEB
        '
        Me.lblPublicarWEB.Location = New System.Drawing.Point(390, 43)
        Me.lblPublicarWEB.Name = "lblPublicarWEB"
        Me.lblPublicarWEB.Size = New System.Drawing.Size(50, 20)
        Me.lblPublicarWEB.TabIndex = 14
        Me.lblPublicarWEB.Text = "Marca : "
        Me.lblPublicarWEB.Values.ExtraText = ""
        Me.lblPublicarWEB.Values.Image = Nothing
        Me.lblPublicarWEB.Values.Text = "Marca : "
        '
        'txtMercaderia
        '
        Me.txtMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMercaderia.Location = New System.Drawing.Point(861, 13)
        Me.txtMercaderia.Name = "txtMercaderia"
        Me.txtMercaderia.Size = New System.Drawing.Size(262, 22)
        Me.txtMercaderia.TabIndex = 9
        '
        'lblMercadaeria
        '
        Me.lblMercadaeria.Location = New System.Drawing.Point(752, 15)
        Me.lblMercadaeria.Name = "lblMercadaeria"
        Me.lblMercadaeria.Size = New System.Drawing.Size(105, 20)
        Me.lblMercadaeria.TabIndex = 8
        Me.lblMercadaeria.Text = "OS / Mercadería : "
        Me.lblMercadaeria.Values.ExtraText = ""
        Me.lblMercadaeria.Values.Image = Nothing
        Me.lblMercadaeria.Values.Text = "OS / Mercadería : "
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(1160, 9)
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
        Me.KryptonLabel1.Location = New System.Drawing.Point(26, 15)
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
        Me.KryptonLabel5.Location = New System.Drawing.Point(894, 40)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 30)
        Me.KryptonLabel5.TabIndex = 35
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'PSCTPALM
        '
        Me.PSCTPALM.DataPropertyName = "PSCTPALM"
        Me.PSCTPALM.HeaderText = "PSCTPALM"
        Me.PSCTPALM.Name = "PSCTPALM"
        Me.PSCTPALM.ReadOnly = True
        Me.PSCTPALM.Visible = False
        Me.PSCTPALM.Width = 96
        '
        'PSDESTIPO
        '
        Me.PSDESTIPO.DataPropertyName = "PSDESTIPO"
        Me.PSDESTIPO.HeaderText = "Tipo Almacén"
        Me.PSDESTIPO.Name = "PSDESTIPO"
        Me.PSDESTIPO.ReadOnly = True
        Me.PSDESTIPO.Width = 110
        '
        'PSCALMC
        '
        Me.PSCALMC.DataPropertyName = "PSCALMC"
        Me.PSCALMC.HeaderText = "PSCALMC"
        Me.PSCALMC.Name = "PSCALMC"
        Me.PSCALMC.ReadOnly = True
        Me.PSCALMC.Visible = False
        Me.PSCALMC.Width = 90
        '
        'PSDESALM
        '
        Me.PSDESALM.DataPropertyName = "PSDESALM"
        Me.PSDESALM.HeaderText = "Almacén"
        Me.PSDESALM.Name = "PSDESALM"
        Me.PSDESALM.ReadOnly = True
        Me.PSDESALM.Width = 83
        '
        'PNTDSDES
        '
        Me.PNTDSDES.DataPropertyName = "PNTDSDES"
        Me.PNTDSDES.HeaderText = "PNTDSDES"
        Me.PNTDSDES.Name = "PNTDSDES"
        Me.PNTDSDES.ReadOnly = True
        Me.PNTDSDES.Visible = False
        Me.PNTDSDES.Width = 93
        '
        'PSTPLNTA
        '
        Me.PSTPLNTA.DataPropertyName = "PSTPLNTA"
        Me.PSTPLNTA.HeaderText = "Planta"
        Me.PSTPLNTA.Name = "PSTPLNTA"
        Me.PSTPLNTA.ReadOnly = True
        Me.PSTPLNTA.Width = 69
        '
        'PSCZNALM
        '
        Me.PSCZNALM.DataPropertyName = "PSCZNALM"
        Me.PSCZNALM.HeaderText = "PSCZNALM"
        Me.PSCZNALM.Name = "PSCZNALM"
        Me.PSCZNALM.ReadOnly = True
        Me.PSCZNALM.Visible = False
        Me.PSCZNALM.Width = 98
        '
        'PSDESZONA
        '
        Me.PSDESZONA.DataPropertyName = "PSDESZONA"
        Me.PSDESZONA.HeaderText = "Zona Almacén"
        Me.PSDESZONA.Name = "PSDESZONA"
        Me.PSDESZONA.ReadOnly = True
        Me.PSDESZONA.Width = 113
        '
        'PNQSLMC2
        '
        Me.PNQSLMC2.DataPropertyName = "PNQSLMC2"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PNQSLMC2.DefaultCellStyle = DataGridViewCellStyle2
        Me.PNQSLMC2.HeaderText = "Saldo Inventario"
        Me.PNQSLMC2.Name = "PNQSLMC2"
        Me.PNQSLMC2.ReadOnly = True
        Me.PNQSLMC2.Width = 121
        '
        'PNQSLMP2
        '
        Me.PNQSLMP2.DataPropertyName = "PNQSLMP2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PNQSLMP2.DefaultCellStyle = DataGridViewCellStyle3
        Me.PNQSLMP2.HeaderText = "Peso Inventario"
        Me.PNQSLMP2.Name = "PNQSLMP2"
        Me.PNQSLMP2.ReadOnly = True
        Me.PNQSLMP2.Width = 117
        '
        'frmDespachoOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 526)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmDespachoOS"
        Me.Text = "Despacho por Orden de Serivicio"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.Contenedor1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor1.Panel1.ResumeLayout(False)
        CType(Me.Contenedor1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor1.Panel2.ResumeLayout(False)
        Me.Contenedor1.Panel2.PerformLayout()
        CType(Me.Contenedor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor1.ResumeLayout(False)
        CType(Me.Contenedor2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor2.Panel1.ResumeLayout(False)
        Me.Contenedor2.Panel1.PerformLayout()
        CType(Me.Contenedor2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor2.Panel2.ResumeLayout(False)
        CType(Me.Contenedor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor2.ResumeLayout(False)
        CType(Me.dgMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.hgOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgOS.Panel.ResumeLayout(False)
        CType(Me.hgOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgOS.ResumeLayout(False)
        CType(Me.dtgKardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuProcesar.ResumeLayout(False)
        Me.tsMenuProcesar.PerformLayout()
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
    Friend WithEvents txtCliente As RANSA.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents grpLeyenda As System.Windows.Forms.GroupBox
    Friend WithEvents lblDetalleOpcional As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDetalleObligatorio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOpcional As System.Windows.Forms.Label
    Friend WithEvents lblObligatorio As System.Windows.Forms.Label
    Friend WithEvents lblPublicarWEB As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblMercadaeria As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgMercaderia As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaDespacharMercaderiaOS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaOcultar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgKardex As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuProcesar As System.Windows.Forms.ToolStrip
    Private WithEvents tss08 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminarItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss06 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnProcesarDespacho As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents S_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TCMPMR As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRealizarDespacho As System.Windows.Forms.ToolStripButton
    Private WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtMarca As Ransa.Controls.ucAyudaConectado
    Friend WithEvents Contenedor2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents Contenedor1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbDeposito As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPFM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPGR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMMRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCMMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QWRMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALDIS As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As RANSA.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents PSCTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESTIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNTDSDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESZONA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQSLMC2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQSLMP2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
