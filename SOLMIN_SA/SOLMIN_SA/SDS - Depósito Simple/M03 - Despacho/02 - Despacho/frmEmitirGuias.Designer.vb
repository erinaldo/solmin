<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmitirGuias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmitirGuias))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.hgGuiaSalida = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaGenerarGuiaRemision = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaAnularTodasGRs = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaAnularGS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaAnularItemGS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaVistaPreviaGS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaPuntoEntrega = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaReenviar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgGuiasRansa = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.FechaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_DTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_CTRSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_NBRVCH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_STPING = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCPRVD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GS_STRNSM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRANSMISION = New System.Windows.Forms.DataGridViewImageColumn
        Me.hgGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaRestaurarGR = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaAnularGR = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaVistaPreviaGR = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgGuiasRemision = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNNGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaEmisionGuia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GR_SMTGRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GR_MOTTRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GR_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GR_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbProceso = New System.Windows.Forms.ComboBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.txtNroGuiaREMISION = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtNroGuiaRANSA = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroGuiaRansa = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
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
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnTrama = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.hgGuiaSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGuiaSalida.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgGuiaSalida.Panel.SuspendLayout()
        Me.hgGuiaSalida.SuspendLayout()
        CType(Me.dgGuiasRansa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGuiaRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgGuiaRemision.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgGuiaRemision.Panel.SuspendLayout()
        Me.hgGuiaRemision.SuspendLayout()
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1106, 567)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 126)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.hgGuiaSalida)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.hgGuiaRemision)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1106, 441)
        Me.KryptonSplitContainer1.SplitterDistance = 220
        Me.KryptonSplitContainer1.TabIndex = 19
        '
        'hgGuiaSalida
        '
        Me.hgGuiaSalida.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaGenerarGuiaRemision, Me.bsaAnularTodasGRs, Me.bsaAnularGS, Me.bsaAnularItemGS, Me.bsaVistaPreviaGS, Me.bsaPuntoEntrega, Me.bsaReenviar, Me.btnTrama})
        Me.hgGuiaSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgGuiaSalida.HeaderVisibleSecondary = False
        Me.hgGuiaSalida.Location = New System.Drawing.Point(0, 0)
        Me.hgGuiaSalida.Name = "hgGuiaSalida"
        '
        'hgGuiaSalida.Panel
        '
        Me.hgGuiaSalida.Panel.Controls.Add(Me.dgGuiasRansa)
        Me.hgGuiaSalida.Size = New System.Drawing.Size(1106, 220)
        Me.hgGuiaSalida.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgGuiaSalida.TabIndex = 16
        Me.hgGuiaSalida.Text = "Listado de Guías"
        Me.hgGuiaSalida.ValuesPrimary.Description = ""
        Me.hgGuiaSalida.ValuesPrimary.Heading = "Listado de Guías"
        Me.hgGuiaSalida.ValuesPrimary.Image = Nothing
        Me.hgGuiaSalida.ValuesSecondary.Description = ""
        Me.hgGuiaSalida.ValuesSecondary.Heading = ""
        Me.hgGuiaSalida.ValuesSecondary.Image = Nothing
        '
        'bsaGenerarGuiaRemision
        '
        Me.bsaGenerarGuiaRemision.ExtraText = ""
        Me.bsaGenerarGuiaRemision.Image = CType(resources.GetObject("bsaGenerarGuiaRemision.Image"), System.Drawing.Image)
        Me.bsaGenerarGuiaRemision.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaGenerarGuiaRemision.Text = "Generar Guía Remisión"
        Me.bsaGenerarGuiaRemision.ToolTipImage = Nothing
        Me.bsaGenerarGuiaRemision.UniqueName = "C163D28417414EC4C163D28417414EC4"
        '
        'bsaAnularTodasGRs
        '
        Me.bsaAnularTodasGRs.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.bsaAnularTodasGRs.ExtraText = ""
        Me.bsaAnularTodasGRs.Image = CType(resources.GetObject("bsaAnularTodasGRs.Image"), System.Drawing.Image)
        Me.bsaAnularTodasGRs.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaAnularTodasGRs.Text = "Restaurar Guía"
        Me.bsaAnularTodasGRs.ToolTipImage = Nothing
        Me.bsaAnularTodasGRs.UniqueName = "127B9F7FCFF940F3127B9F7FCFF940F3"
        Me.bsaAnularTodasGRs.Visible = False
        '
        'bsaAnularGS
        '
        Me.bsaAnularGS.ExtraText = ""
        Me.bsaAnularGS.Image = CType(resources.GetObject("bsaAnularGS.Image"), System.Drawing.Image)
        Me.bsaAnularGS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaAnularGS.Text = "Anular"
        Me.bsaAnularGS.ToolTipImage = Nothing
        Me.bsaAnularGS.ToolTipTitle = "Anular Guía"
        Me.bsaAnularGS.UniqueName = "51D6D62D19A9491951D6D62D19A94919"
        Me.bsaAnularGS.Visible = False
        '
        'bsaAnularItemGS
        '
        Me.bsaAnularItemGS.ExtraText = ""
        Me.bsaAnularItemGS.Image = Global.SOLMIN_SA.My.Resources.Resources.AnularItem
        Me.bsaAnularItemGS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaAnularItemGS.Text = "Anular Items"
        Me.bsaAnularItemGS.ToolTipImage = Nothing
        Me.bsaAnularItemGS.UniqueName = "381F09901CC24127381F09901CC24127"
        Me.bsaAnularItemGS.Visible = False
        '
        'bsaVistaPreviaGS
        '
        Me.bsaVistaPreviaGS.ExtraText = ""
        Me.bsaVistaPreviaGS.Image = CType(resources.GetObject("bsaVistaPreviaGS.Image"), System.Drawing.Image)
        Me.bsaVistaPreviaGS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaVistaPreviaGS.Text = "Vista Previa"
        Me.bsaVistaPreviaGS.ToolTipImage = Nothing
        Me.bsaVistaPreviaGS.UniqueName = "67570F8A96AC493B67570F8A96AC493B"
        '
        'bsaPuntoEntrega
        '
        Me.bsaPuntoEntrega.ExtraText = ""
        Me.bsaPuntoEntrega.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.bsaPuntoEntrega.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaPuntoEntrega.Text = "RuteoxPuntoEntrega"
        Me.bsaPuntoEntrega.ToolTipImage = Nothing
        Me.bsaPuntoEntrega.UniqueName = "BF9E1471ED8840FABF9E1471ED8840FA"
        '
        'bsaReenviar
        '
        Me.bsaReenviar.ExtraText = ""
        Me.bsaReenviar.Image = Nothing
        Me.bsaReenviar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaReenviar.Text = "Enviar Ing./Des."
        Me.bsaReenviar.ToolTipImage = Nothing
        Me.bsaReenviar.UniqueName = "753CB1DF8BA64B47753CB1DF8BA64B47"
        '
        'dgGuiasRansa
        '
        Me.dgGuiasRansa.AllowUserToAddRows = False
        Me.dgGuiasRansa.AllowUserToDeleteRows = False
        Me.dgGuiasRansa.AllowUserToResizeColumns = False
        Me.dgGuiasRansa.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgGuiasRansa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgGuiasRansa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGuiasRansa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaAsignacion, Me.GS_NGUIRN, Me.GS_CTPOAT, Me.GS_DTPOAT, Me.GS_CTPALM, Me.GS_CALMC, Me.GS_CTRSP, Me.GS_NPLCCM, Me.GS_NBRVCH, Me.GS_STPING, Me.GS_SESTRG, Me.GS_SITUAC, Me.PSCPRVD, Me.GS_STRNSM, Me.TRANSMISION})
        Me.dgGuiasRansa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGuiasRansa.Location = New System.Drawing.Point(0, 0)
        Me.dgGuiasRansa.MultiSelect = False
        Me.dgGuiasRansa.Name = "dgGuiasRansa"
        Me.dgGuiasRansa.ReadOnly = True
        Me.dgGuiasRansa.RowHeadersWidth = 20
        Me.dgGuiasRansa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuiasRansa.Size = New System.Drawing.Size(1104, 189)
        Me.dgGuiasRansa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGuiasRansa.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgGuiasRansa.TabIndex = 17
        '
        'FechaAsignacion
        '
        Me.FechaAsignacion.DataPropertyName = "FechaAsignacion"
        Me.FechaAsignacion.HeaderText = "Fecha"
        Me.FechaAsignacion.Name = "FechaAsignacion"
        Me.FechaAsignacion.ReadOnly = True
        Me.FechaAsignacion.Width = 67
        '
        'GS_NGUIRN
        '
        Me.GS_NGUIRN.DataPropertyName = "PNNGUIRN"
        Me.GS_NGUIRN.HeaderText = "Nro. Guía Ransa"
        Me.GS_NGUIRN.Name = "GS_NGUIRN"
        Me.GS_NGUIRN.ReadOnly = True
        Me.GS_NGUIRN.Width = 120
        '
        'GS_CTPOAT
        '
        Me.GS_CTPOAT.DataPropertyName = "PSCTPOAT"
        Me.GS_CTPOAT.HeaderText = "Proceso"
        Me.GS_CTPOAT.Name = "GS_CTPOAT"
        Me.GS_CTPOAT.ReadOnly = True
        Me.GS_CTPOAT.Visible = False
        Me.GS_CTPOAT.Width = 76
        '
        'GS_DTPOAT
        '
        Me.GS_DTPOAT.DataPropertyName = "PSDTPOAT"
        Me.GS_DTPOAT.HeaderText = "Proceso"
        Me.GS_DTPOAT.Name = "GS_DTPOAT"
        Me.GS_DTPOAT.ReadOnly = True
        Me.GS_DTPOAT.Width = 78
        '
        'GS_CTPALM
        '
        Me.GS_CTPALM.DataPropertyName = "PSCTPALM"
        Me.GS_CTPALM.HeaderText = "Tipo Almacén"
        Me.GS_CTPALM.Name = "GS_CTPALM"
        Me.GS_CTPALM.ReadOnly = True
        Me.GS_CTPALM.Width = 110
        '
        'GS_CALMC
        '
        Me.GS_CALMC.DataPropertyName = "PSCALMC"
        Me.GS_CALMC.HeaderText = "Almacén"
        Me.GS_CALMC.Name = "GS_CALMC"
        Me.GS_CALMC.ReadOnly = True
        Me.GS_CALMC.Width = 83
        '
        'GS_CTRSP
        '
        Me.GS_CTRSP.DataPropertyName = "PNCTRSP"
        Me.GS_CTRSP.HeaderText = "Emp. Transporte"
        Me.GS_CTRSP.Name = "GS_CTRSP"
        Me.GS_CTRSP.ReadOnly = True
        Me.GS_CTRSP.Visible = False
        Me.GS_CTRSP.Width = 119
        '
        'GS_NPLCCM
        '
        Me.GS_NPLCCM.DataPropertyName = "PSNPLCCM"
        Me.GS_NPLCCM.HeaderText = "Unidad"
        Me.GS_NPLCCM.Name = "GS_NPLCCM"
        Me.GS_NPLCCM.ReadOnly = True
        Me.GS_NPLCCM.Visible = False
        Me.GS_NPLCCM.Width = 74
        '
        'GS_NBRVCH
        '
        Me.GS_NBRVCH.DataPropertyName = "PSNBRVCH"
        Me.GS_NBRVCH.HeaderText = "Brevete"
        Me.GS_NBRVCH.Name = "GS_NBRVCH"
        Me.GS_NBRVCH.ReadOnly = True
        Me.GS_NBRVCH.Visible = False
        Me.GS_NBRVCH.Width = 74
        '
        'GS_STPING
        '
        Me.GS_STPING.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GS_STPING.DataPropertyName = "PSSTPING"
        Me.GS_STPING.HeaderText = "Movimiento"
        Me.GS_STPING.Name = "GS_STPING"
        Me.GS_STPING.ReadOnly = True
        '
        'GS_SESTRG
        '
        Me.GS_SESTRG.DataPropertyName = "PSSESTRG"
        Me.GS_SESTRG.HeaderText = "Código Situación"
        Me.GS_SESTRG.Name = "GS_SESTRG"
        Me.GS_SESTRG.ReadOnly = True
        Me.GS_SESTRG.Visible = False
        Me.GS_SESTRG.Width = 125
        '
        'GS_SITUAC
        '
        Me.GS_SITUAC.DataPropertyName = "PSSITUAC"
        Me.GS_SITUAC.HeaderText = "Situación"
        Me.GS_SITUAC.Name = "GS_SITUAC"
        Me.GS_SITUAC.ReadOnly = True
        Me.GS_SITUAC.Width = 85
        '
        'PSCPRVD
        '
        Me.PSCPRVD.DataPropertyName = "PSCPRVD"
        Me.PSCPRVD.HeaderText = "GS_CPRVD"
        Me.PSCPRVD.Name = "PSCPRVD"
        Me.PSCPRVD.ReadOnly = True
        Me.PSCPRVD.Visible = False
        Me.PSCPRVD.Width = 90
        '
        'GS_STRNSM
        '
        Me.GS_STRNSM.DataPropertyName = "PSSTRNSM"
        Me.GS_STRNSM.HeaderText = "Est de Trans."
        Me.GS_STRNSM.Name = "GS_STRNSM"
        Me.GS_STRNSM.ReadOnly = True
        Me.GS_STRNSM.Visible = False
        '
        'TRANSMISION
        '
        Me.TRANSMISION.DataPropertyName = "TRANSMISION"
        Me.TRANSMISION.HeaderText = "Estado de Transmisión"
        Me.TRANSMISION.Image = Global.SOLMIN_SA.My.Resources.Resources.EnBlanco
        Me.TRANSMISION.Name = "TRANSMISION"
        Me.TRANSMISION.ReadOnly = True
        Me.TRANSMISION.Width = 135
        '
        'hgGuiaRemision
        '
        Me.hgGuiaRemision.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaRestaurarGR, Me.bsaAnularGR, Me.bsaVistaPreviaGR})
        Me.hgGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgGuiaRemision.HeaderVisibleSecondary = False
        Me.hgGuiaRemision.Location = New System.Drawing.Point(0, 0)
        Me.hgGuiaRemision.Name = "hgGuiaRemision"
        '
        'hgGuiaRemision.Panel
        '
        Me.hgGuiaRemision.Panel.Controls.Add(Me.dgGuiasRemision)
        Me.hgGuiaRemision.Size = New System.Drawing.Size(1106, 216)
        Me.hgGuiaRemision.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgGuiaRemision.TabIndex = 18
        Me.hgGuiaRemision.Text = "Guía de Remisión"
        Me.hgGuiaRemision.ValuesPrimary.Description = ""
        Me.hgGuiaRemision.ValuesPrimary.Heading = "Guía de Remisión"
        Me.hgGuiaRemision.ValuesPrimary.Image = Nothing
        Me.hgGuiaRemision.ValuesSecondary.Description = ""
        Me.hgGuiaRemision.ValuesSecondary.Heading = "Description"
        Me.hgGuiaRemision.ValuesSecondary.Image = Nothing
        '
        'bsaRestaurarGR
        '
        Me.bsaRestaurarGR.ExtraText = ""
        Me.bsaRestaurarGR.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.bsaRestaurarGR.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaRestaurarGR.Text = "Anular Guías"
        Me.bsaRestaurarGR.ToolTipImage = Nothing
        Me.bsaRestaurarGR.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaRestaurarGR.UniqueName = "BA471D4AE4174FFABA471D4AE4174FFA"
        '
        'bsaAnularGR
        '
        Me.bsaAnularGR.ExtraText = "Eliminar Guías"
        Me.bsaAnularGR.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.bsaAnularGR.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaAnularGR.Text = ""
        Me.bsaAnularGR.ToolTipImage = Nothing
        Me.bsaAnularGR.UniqueName = "A71700FBDAD8498BA71700FBDAD8498B"
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
        'dgGuiasRemision
        '
        Me.dgGuiasRemision.AllowUserToAddRows = False
        Me.dgGuiasRemision.AllowUserToDeleteRows = False
        Me.dgGuiasRemision.AllowUserToResizeColumns = False
        Me.dgGuiasRemision.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgGuiasRemision.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgGuiasRemision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGuiasRemision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNNGUIRM, Me.FechaEmisionGuia, Me.GR_SMTGRM, Me.GR_MOTTRA, Me.GR_SESTRG, Me.GR_SITUAC, Me.PNNGUIRN})
        Me.dgGuiasRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGuiasRemision.Location = New System.Drawing.Point(0, 0)
        Me.dgGuiasRemision.MultiSelect = False
        Me.dgGuiasRemision.Name = "dgGuiasRemision"
        Me.dgGuiasRemision.ReadOnly = True
        Me.dgGuiasRemision.RowHeadersWidth = 20
        Me.dgGuiasRemision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuiasRemision.Size = New System.Drawing.Size(1104, 185)
        Me.dgGuiasRemision.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGuiasRemision.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgGuiasRemision.TabIndex = 19
        '
        'PNNGUIRM
        '
        Me.PNNGUIRM.DataPropertyName = "PNNGUIRM"
        Me.PNNGUIRM.HeaderText = "Nro. Guía Remisión"
        Me.PNNGUIRM.Name = "PNNGUIRM"
        Me.PNNGUIRM.ReadOnly = True
        Me.PNNGUIRM.Width = 138
        '
        'FechaEmisionGuia
        '
        Me.FechaEmisionGuia.DataPropertyName = "FechaEmisionGuia"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaEmisionGuia.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaEmisionGuia.HeaderText = "Fecha G. Remisión"
        Me.FechaEmisionGuia.Name = "FechaEmisionGuia"
        Me.FechaEmisionGuia.ReadOnly = True
        Me.FechaEmisionGuia.Width = 133
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
        Me.GR_SESTRG.Width = 125
        '
        'GR_SITUAC
        '
        Me.GR_SITUAC.DataPropertyName = "PSSITUAC"
        Me.GR_SITUAC.HeaderText = "Situación"
        Me.GR_SITUAC.Name = "GR_SITUAC"
        Me.GR_SITUAC.ReadOnly = True
        Me.GR_SITUAC.Width = 85
        '
        'PNNGUIRN
        '
        Me.PNNGUIRN.HeaderText = "PNGUIRN"
        Me.PNNGUIRN.Name = "PNNGUIRN"
        Me.PNNGUIRN.ReadOnly = True
        Me.PNNGUIRN.Visible = False
        Me.PNNGUIRN.Width = 84
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
        Me.khgFiltros.Panel.Controls.Add(Me.cmbProceso)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroGuiaREMISION)
        Me.khgFiltros.Panel.Controls.Add(Me.lblNroGuiaRemision)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.lblAlmacen)
        Me.khgFiltros.Panel.Controls.Add(Me.txtTipoAlmacen)
        Me.khgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.khgFiltros.Panel.Controls.Add(Me.txtAlmacen)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroGuiaRANSA)
        Me.khgFiltros.Panel.Controls.Add(Me.lblNroGuiaRansa)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Size = New System.Drawing.Size(1106, 126)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 0
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
        'cmbProceso
        '
        Me.cmbProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProceso.FormattingEnabled = True
        Me.cmbProceso.Items.AddRange(New Object() {"TODOS", "RECEPCIÓN", "DESPACHO"})
        Me.cmbProceso.Location = New System.Drawing.Point(820, 12)
        Me.cmbProceso.Name = "cmbProceso"
        Me.cmbProceso.Size = New System.Drawing.Size(144, 21)
        Me.cmbProceso.TabIndex = 37
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(759, 13)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel2.TabIndex = 36
        Me.KryptonLabel2.Text = "Proceso : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Proceso : "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = ""
        Me.txtCliente.Location = New System.Drawing.Point(131, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(233, 22)
        Me.txtCliente.TabIndex = 2
        '
        'txtNroGuiaREMISION
        '
        Me.txtNroGuiaREMISION.Location = New System.Drawing.Point(131, 63)
        Me.txtNroGuiaREMISION.Name = "txtNroGuiaREMISION"
        Me.txtNroGuiaREMISION.Size = New System.Drawing.Size(233, 22)
        Me.txtNroGuiaREMISION.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtNroGuiaREMISION, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblNroGuiaRemision
        '
        Me.lblNroGuiaRemision.Location = New System.Drawing.Point(13, 66)
        Me.lblNroGuiaRemision.Name = "lblNroGuiaRemision"
        Me.lblNroGuiaRemision.Size = New System.Drawing.Size(122, 20)
        Me.lblNroGuiaRemision.TabIndex = 5
        Me.lblNroGuiaRemision.Text = "Nro. Guía Remisión : "
        Me.lblNroGuiaRemision.Values.ExtraText = ""
        Me.lblNroGuiaRemision.Values.Image = Nothing
        Me.lblNroGuiaRemision.Values.Text = "Nro. Guía Remisión : "
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(652, 64)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.ShowCheckBox = True
        Me.dtpFechaFinal.Size = New System.Drawing.Size(101, 20)
        Me.dtpFechaFinal.TabIndex = 14
        Me.dtpFechaFinal.Value = New Date(2008, 12, 18, 0, 0, 0, 0)
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(482, 66)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.ShowCheckBox = True
        Me.dtpFechaInicial.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaInicial.TabIndex = 12
        Me.dtpFechaInicial.Value = New Date(2008, 12, 18, 0, 0, 0, 0)
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(584, 66)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(77, 20)
        Me.lblFechaFinal.TabIndex = 13
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(402, 66)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(81, 20)
        Me.lblFechaInicial.TabIndex = 11
        Me.lblFechaInicial.Text = "Fecha Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inicio : "
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(417, 38)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(64, 20)
        Me.lblAlmacen.TabIndex = 9
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoAlmacenListar})
        Me.txtTipoAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtTipoAlmacen, True)
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(482, 13)
        Me.txtTipoAlmacen.MaxLength = 50
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(271, 22)
        Me.txtTipoAlmacen.TabIndex = 8
        Me.TypeValidator.SetTypes(Me.txtTipoAlmacen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaTipoAlmacenListar
        '
        Me.bsaTipoAlmacenListar.ExtraText = ""
        Me.bsaTipoAlmacenListar.Image = Nothing
        Me.bsaTipoAlmacenListar.Text = ""
        Me.bsaTipoAlmacenListar.ToolTipImage = Nothing
        Me.bsaTipoAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoAlmacenListar.UniqueName = "A81EDC60E5B049C0A81EDC60E5B049C0"
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(392, 13)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(91, 20)
        Me.lblTipoAlmacen.TabIndex = 7
        Me.lblTipoAlmacen.Text = "Tipo Almacen : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo Almacen : "
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaAlmacenListar})
        Me.txtAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtAlmacen, True)
        Me.txtAlmacen.Location = New System.Drawing.Point(482, 38)
        Me.txtAlmacen.MaxLength = 50
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Size = New System.Drawing.Size(271, 22)
        Me.txtAlmacen.TabIndex = 10
        Me.TypeValidator.SetTypes(Me.txtAlmacen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaAlmacenListar
        '
        Me.bsaAlmacenListar.ExtraText = ""
        Me.bsaAlmacenListar.Image = Nothing
        Me.bsaAlmacenListar.Text = ""
        Me.bsaAlmacenListar.ToolTipImage = Nothing
        Me.bsaAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaAlmacenListar.UniqueName = "9BC1C9592405475E9BC1C9592405475E"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(1006, 12)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 72)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'txtNroGuiaRANSA
        '
        Me.txtNroGuiaRANSA.Location = New System.Drawing.Point(131, 38)
        Me.txtNroGuiaRANSA.Name = "txtNroGuiaRANSA"
        Me.txtNroGuiaRANSA.Size = New System.Drawing.Size(233, 22)
        Me.txtNroGuiaRANSA.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtNroGuiaRANSA, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblNroGuiaRansa
        '
        Me.lblNroGuiaRansa.Location = New System.Drawing.Point(29, 38)
        Me.lblNroGuiaRansa.Name = "lblNroGuiaRansa"
        Me.lblNroGuiaRansa.Size = New System.Drawing.Size(104, 20)
        Me.lblNroGuiaRansa.TabIndex = 3
        Me.lblNroGuiaRansa.Text = "Nro. Guía Ransa : "
        Me.lblNroGuiaRansa.Values.ExtraText = ""
        Me.lblNroGuiaRansa.Values.Image = Nothing
        Me.lblNroGuiaRansa.Values.Text = "Nro. Guía Ransa : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(75, 13)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 20)
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FASGTR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 66
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NGUIRN"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nro. Guía Ransa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 119
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CTPOAT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Proceso"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DTPOAT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Proceso"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CTPALM"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo Almacén"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 104
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CALMC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Almacén"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 79
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CTRSP"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Emp. Transporte"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 114
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NPLCCM"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NBRVCH"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Brevete"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 73
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "STPING"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Movimiento"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 97
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Código Situación"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 116
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SITUAC"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Situación"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 84
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Nro. Guía Remisión"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 135
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FGUIRM"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn14.HeaderText = "Fecha G. Remisión"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 130
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "SMTGRM"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Código MotivoTraslado"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 156
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "MOTTRA"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Motivo Traslado"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Código Situación"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "SITUAC"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Situación"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 84
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "SITUAC"
        Me.DataGridViewTextBoxColumn19.HeaderText = "PNNGUIRN"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 92
        '
        'btnTrama
        '
        Me.btnTrama.ExtraText = ""
        Me.btnTrama.Image = Nothing
        Me.btnTrama.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.btnTrama.Text = "Trama Envío"
        Me.btnTrama.ToolTipImage = Nothing
        Me.btnTrama.UniqueName = "30D97F7E53874B3130D97F7E53874B31"
        '
        'frmEmitirGuias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 567)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmEmitirGuias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despacho de Bultos - Guía Salida"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.hgGuiaSalida.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaSalida.Panel.ResumeLayout(False)
        CType(Me.hgGuiaSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaSalida.ResumeLayout(False)
        CType(Me.dgGuiasRansa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgGuiaRemision.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaRemision.Panel.ResumeLayout(False)
        CType(Me.hgGuiaRemision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgGuiaRemision.ResumeLayout(False)
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroGuiaRANSA As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuiaRansa As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents hgGuiaSalida As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgGuiasRansa As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsaVistaPreviaGS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaGenerarGuiaRemision As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents hgGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaVistaPreviaGR As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgGuiasRemision As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents bsaRestaurarGR As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaAnularGS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaAnularTodasGRs As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaTipoAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNroGuiaREMISION As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
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
    Friend WithEvents bsaAnularGR As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaAnularItemGS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaPuntoEntrega As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents PNNGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaEmisionGuia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SMTGRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_MOTTRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GR_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsaReenviar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents FechaAsignacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_DTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_CTRSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_NBRVCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_STPING As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCPRVD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GS_STRNSM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRANSMISION As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cmbProceso As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnTrama As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
