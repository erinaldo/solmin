<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionXOPLogistica
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dgBultos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NMRGIM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NSEQIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_DESCWB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUBRFR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SMTRCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TIPBTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QPSOBL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QVLBTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNVOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SSNCRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QAROCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TLUGOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NORAGN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NTCKPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CRTLTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDSCIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FSLFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLGCNL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMMDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CONFIR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FRQALC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCTCST = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCTCSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCTCSF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCNFCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HCNFCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBSEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NROPLT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_STRNSM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CBLTOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NSEQIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblWaybill = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.dgBultosDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.D_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_CIDPAQ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_QPEPQT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_TUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_QVOPQT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_TUNVOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_NGRPRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.X_MARRET = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SUBITEM = New System.Windows.Forms.DataGridViewImageColumn
        Me.NRSITEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgDetalleItem = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.txtInformacionItemBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tsMenuItemBulto = New System.Windows.Forms.ToolStrip
        Me.lblTituloDetalle = New System.Windows.Forms.ToolStripLabel
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.chkRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkDespacho = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.cmbPlanta = New System.Windows.Forms.ComboBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.txtClient = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.cmsBultoCabecera = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiEliminarBultoPaleta = New System.Windows.Forms.ToolStripMenuItem
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
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
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgBultos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dgBultosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgDetalleItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgDetalleItem.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgDetalleItem.Panel.SuspendLayout()
        Me.hgDetalleItem.SuspendLayout()
        Me.tsMenuItemBulto.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.cmsBultoCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1087, 708)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel1.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1087, 708)
        Me.KryptonPanel1.TabIndex = 2
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 137)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgBultos)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.UcPaginacion)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.tsMenuOpciones)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgBultosDetalle)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.hgDetalleItem)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.tsMenuItemBulto)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1087, 571)
        Me.KryptonSplitContainer1.SplitterDistance = 325
        Me.KryptonSplitContainer1.TabIndex = 2
        '
        'dgBultos
        '
        Me.dgBultos.AllowUserToAddRows = False
        Me.dgBultos.AllowUserToDeleteRows = False
        Me.dgBultos.AllowUserToResizeColumns = False
        Me.dgBultos.AllowUserToResizeRows = False
        Me.dgBultos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgBultos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgBultos.ColumnHeadersHeight = 40
        Me.dgBultos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBultos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCLNT, Me.M_NMRGIM, Me.CPLNDV, Me.TPLNTA, Me.M_CREFFW, Me.M_NSEQIN, Me.M_DESCWB, Me.M_FREFFW, Me.Column6, Me.Column7, Me.Column8, Me.M_TUBRFR, Me.M_SMTRCP, Me.M_QREFFW, Me.M_TIPBTO, Me.M_QPSOBL, Me.M_TUNPSO, Me.M_QVLBTO, Me.M_TUNVOL, Me.M_SSNCRG, Me.M_QAROCP, Me.TLUGOR, Me.TLUGEN, Me.M_NORAGN, Me.M_NTCKPS, Me.M_CRTLTE, Me.TDSCIT, Me.FSLFFW, Me.NGUIRM, Me.FLGCNL, Me.TNMMDT, Me.CONFIR, Me.FRQALC, Me.TCTCST, Me.TCTCSA, Me.TCTCSF, Me.FCNFCL, Me.HCNFCL, Me.TOBSEN, Me.M_NROPLT, Me.M_STRNSM, Me.M_CBLTOR, Me.M_NSEQIO})
        Me.dgBultos.DataMember = "dtWayBill"
        Me.dgBultos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBultos.Location = New System.Drawing.Point(0, 25)
        Me.dgBultos.MultiSelect = False
        Me.dgBultos.Name = "dgBultos"
        Me.dgBultos.ReadOnly = True
        Me.dgBultos.RowHeadersWidth = 20
        Me.dgBultos.RowTemplate.ReadOnly = True
        Me.dgBultos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBultos.Size = New System.Drawing.Size(1087, 275)
        Me.dgBultos.StandardTab = True
        Me.dgBultos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgBultos.TabIndex = 28
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        Me.CCLNT.Width = 71
        '
        'M_NMRGIM
        '
        Me.M_NMRGIM.DataPropertyName = "NMRGIM"
        Me.M_NMRGIM.HeaderText = "NMRGIM"
        Me.M_NMRGIM.Name = "M_NMRGIM"
        Me.M_NMRGIM.ReadOnly = True
        Me.M_NMRGIM.Visible = False
        Me.M_NMRGIM.Width = 81
        '
        'CPLNDV
        '
        Me.CPLNDV.DataPropertyName = "CPLNDV"
        Me.CPLNDV.HeaderText = "CPLNDV"
        Me.CPLNDV.Name = "CPLNDV"
        Me.CPLNDV.ReadOnly = True
        Me.CPLNDV.Visible = False
        Me.CPLNDV.Width = 79
        '
        'TPLNTA
        '
        Me.TPLNTA.DataPropertyName = "TPLNTA"
        Me.TPLNTA.HeaderText = "Planta"
        Me.TPLNTA.Name = "TPLNTA"
        Me.TPLNTA.ReadOnly = True
        Me.TPLNTA.Width = 66
        '
        'M_CREFFW
        '
        Me.M_CREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CREFFW.DataPropertyName = "CREFFW"
        Me.M_CREFFW.HeaderText = "Bulto"
        Me.M_CREFFW.Name = "M_CREFFW"
        Me.M_CREFFW.ReadOnly = True
        Me.M_CREFFW.Width = 60
        '
        'M_NSEQIN
        '
        Me.M_NSEQIN.DataPropertyName = "NSEQIN"
        Me.M_NSEQIN.HeaderText = "NSEQIN"
        Me.M_NSEQIN.Name = "M_NSEQIN"
        Me.M_NSEQIN.ReadOnly = True
        Me.M_NSEQIN.Visible = False
        Me.M_NSEQIN.Width = 77
        '
        'M_DESCWB
        '
        Me.M_DESCWB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.M_DESCWB.DataPropertyName = "DESCWB"
        Me.M_DESCWB.HeaderText = "Descripción"
        Me.M_DESCWB.MinimumWidth = 250
        Me.M_DESCWB.Name = "M_DESCWB"
        Me.M_DESCWB.ReadOnly = True
        '
        'M_FREFFW
        '
        Me.M_FREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FREFFW.DataPropertyName = "FREFFW"
        Me.M_FREFFW.HeaderText = "Fecha Recep."
        Me.M_FREFFW.Name = "M_FREFFW"
        Me.M_FREFFW.ReadOnly = True
        Me.M_FREFFW.Width = 96
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.DataPropertyName = "CTPALM"
        Me.Column6.HeaderText = "Tip. Almacén"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 91
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.DataPropertyName = "CALMC"
        Me.Column7.HeaderText = "Almacén"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 77
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.DataPropertyName = "CZNALM"
        Me.Column8.HeaderText = "Zona"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 61
        '
        'M_TUBRFR
        '
        Me.M_TUBRFR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TUBRFR.DataPropertyName = "TUBRFR"
        Me.M_TUBRFR.HeaderText = "Ubicación"
        Me.M_TUBRFR.Name = "M_TUBRFR"
        Me.M_TUBRFR.ReadOnly = True
        Me.M_TUBRFR.Width = 84
        '
        'M_SMTRCP
        '
        Me.M_SMTRCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_SMTRCP.DataPropertyName = "SMTRCP"
        Me.M_SMTRCP.HeaderText = "Incidencia / Motivo"
        Me.M_SMTRCP.MinimumWidth = 120
        Me.M_SMTRCP.Name = "M_SMTRCP"
        Me.M_SMTRCP.ReadOnly = True
        Me.M_SMTRCP.Width = 120
        '
        'M_QREFFW
        '
        Me.M_QREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QREFFW.DataPropertyName = "QREFFW"
        Me.M_QREFFW.HeaderText = "Cantidad"
        Me.M_QREFFW.Name = "M_QREFFW"
        Me.M_QREFFW.ReadOnly = True
        Me.M_QREFFW.Width = 78
        '
        'M_TIPBTO
        '
        Me.M_TIPBTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TIPBTO.DataPropertyName = "TIPBTO"
        Me.M_TIPBTO.HeaderText = "Tipo Bulto"
        Me.M_TIPBTO.Name = "M_TIPBTO"
        Me.M_TIPBTO.ReadOnly = True
        Me.M_TIPBTO.Width = 78
        '
        'M_QPSOBL
        '
        Me.M_QPSOBL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QPSOBL.DataPropertyName = "QPSOBL"
        Me.M_QPSOBL.HeaderText = "Peso"
        Me.M_QPSOBL.Name = "M_QPSOBL"
        Me.M_QPSOBL.ReadOnly = True
        Me.M_QPSOBL.Width = 60
        '
        'M_TUNPSO
        '
        Me.M_TUNPSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TUNPSO.DataPropertyName = "TUNPSO"
        Me.M_TUNPSO.HeaderText = "Unidad"
        Me.M_TUNPSO.Name = "M_TUNPSO"
        Me.M_TUNPSO.ReadOnly = True
        Me.M_TUNPSO.Width = 70
        '
        'M_QVLBTO
        '
        Me.M_QVLBTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QVLBTO.DataPropertyName = "QVLBTO"
        Me.M_QVLBTO.HeaderText = "Volumen"
        Me.M_QVLBTO.Name = "M_QVLBTO"
        Me.M_QVLBTO.ReadOnly = True
        Me.M_QVLBTO.Width = 77
        '
        'M_TUNVOL
        '
        Me.M_TUNVOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TUNVOL.DataPropertyName = "TUNVOL"
        Me.M_TUNVOL.HeaderText = "Unidad"
        Me.M_TUNVOL.Name = "M_TUNVOL"
        Me.M_TUNVOL.ReadOnly = True
        Me.M_TUNVOL.Width = 70
        '
        'M_SSNCRG
        '
        Me.M_SSNCRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_SSNCRG.DataPropertyName = "SSNCRG"
        Me.M_SSNCRG.HeaderText = "Sentido"
        Me.M_SSNCRG.Name = "M_SSNCRG"
        Me.M_SSNCRG.ReadOnly = True
        Me.M_SSNCRG.Width = 72
        '
        'M_QAROCP
        '
        Me.M_QAROCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QAROCP.DataPropertyName = "QAROCP"
        Me.M_QAROCP.HeaderText = "Área Ocupada"
        Me.M_QAROCP.Name = "M_QAROCP"
        Me.M_QAROCP.ReadOnly = True
        Me.M_QAROCP.Width = 97
        '
        'TLUGOR
        '
        Me.TLUGOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TLUGOR.DataPropertyName = "TLUGOR"
        Me.TLUGOR.HeaderText = "Lugar de Origen"
        Me.TLUGOR.Name = "TLUGOR"
        Me.TLUGOR.ReadOnly = True
        Me.TLUGOR.Width = 103
        '
        'TLUGEN
        '
        Me.TLUGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TLUGEN.DataPropertyName = "TLUGEN"
        Me.TLUGEN.HeaderText = "Lugar de Entrega"
        Me.TLUGEN.Name = "TLUGEN"
        Me.TLUGEN.ReadOnly = True
        Me.TLUGEN.Width = 109
        '
        'M_NORAGN
        '
        Me.M_NORAGN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NORAGN.DataPropertyName = "NORAGN"
        Me.M_NORAGN.HeaderText = "Nro. O/S"
        Me.M_NORAGN.Name = "M_NORAGN"
        Me.M_NORAGN.ReadOnly = True
        Me.M_NORAGN.Width = 56
        '
        'M_NTCKPS
        '
        Me.M_NTCKPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NTCKPS.DataPropertyName = "NTCKPS"
        Me.M_NTCKPS.HeaderText = "Nro. Ticket"
        Me.M_NTCKPS.Name = "M_NTCKPS"
        Me.M_NTCKPS.ReadOnly = True
        Me.M_NTCKPS.Width = 83
        '
        'M_CRTLTE
        '
        Me.M_CRTLTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CRTLTE.DataPropertyName = "CRTLTE"
        Me.M_CRTLTE.HeaderText = "Criterio"
        Me.M_CRTLTE.Name = "M_CRTLTE"
        Me.M_CRTLTE.ReadOnly = True
        Me.M_CRTLTE.Width = 68
        '
        'TDSCIT
        '
        Me.TDSCIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDSCIT.DataPropertyName = "TDSCIT"
        Me.TDSCIT.HeaderText = "Observaciones"
        Me.TDSCIT.Name = "TDSCIT"
        Me.TDSCIT.ReadOnly = True
        Me.TDSCIT.Width = 107
        '
        'FSLFFW
        '
        Me.FSLFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FSLFFW.DataPropertyName = "FSLFFW"
        Me.FSLFFW.HeaderText = "Fecha de Salida"
        Me.FSLFFW.Name = "FSLFFW"
        Me.FSLFFW.ReadOnly = True
        Me.FSLFFW.Width = 104
        '
        'NGUIRM
        '
        Me.NGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUIRM.DataPropertyName = "NGUIRM"
        Me.NGUIRM.HeaderText = "Guía de Remisión"
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.ReadOnly = True
        Me.NGUIRM.Width = 111
        '
        'FLGCNL
        '
        Me.FLGCNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLGCNL.DataPropertyName = "FLGCNL"
        Me.FLGCNL.HeaderText = "Estado de Entrega"
        Me.FLGCNL.Name = "FLGCNL"
        Me.FLGCNL.ReadOnly = True
        Me.FLGCNL.Width = 114
        '
        'TNMMDT
        '
        Me.TNMMDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMMDT.DataPropertyName = "TNMMDT"
        Me.TNMMDT.HeaderText = "Medio Sugerido"
        Me.TNMMDT.Name = "TNMMDT"
        Me.TNMMDT.ReadOnly = True
        Me.TNMMDT.Width = 101
        '
        'CONFIR
        '
        Me.CONFIR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CONFIR.DataPropertyName = "CONFIR"
        Me.CONFIR.HeaderText = "Medio Confirmado"
        Me.CONFIR.Name = "CONFIR"
        Me.CONFIR.ReadOnly = True
        Me.CONFIR.Width = 111
        '
        'FRQALC
        '
        Me.FRQALC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FRQALC.DataPropertyName = "FRQALC"
        Me.FRQALC.HeaderText = "Fecha Req."
        Me.FRQALC.Name = "FRQALC"
        Me.FRQALC.ReadOnly = True
        Me.FRQALC.Width = 85
        '
        'TCTCST
        '
        Me.TCTCST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCTCST.DataPropertyName = "TCTCST"
        Me.TCTCST.HeaderText = "Imputación Terrestre"
        Me.TCTCST.Name = "TCTCST"
        Me.TCTCST.ReadOnly = True
        Me.TCTCST.Width = 122
        '
        'TCTCSA
        '
        Me.TCTCSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCTCSA.DataPropertyName = "TCTCSA"
        Me.TCTCSA.HeaderText = "Imputación Aérea"
        Me.TCTCSA.Name = "TCTCSA"
        Me.TCTCSA.ReadOnly = True
        Me.TCTCSA.Width = 110
        '
        'TCTCSF
        '
        Me.TCTCSF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCTCSF.DataPropertyName = "TCTCSF"
        Me.TCTCSF.HeaderText = "Imputación Fluvial"
        Me.TCTCSF.Name = "TCTCSF"
        Me.TCTCSF.ReadOnly = True
        Me.TCTCSF.Width = 111
        '
        'FCNFCL
        '
        Me.FCNFCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FCNFCL.DataPropertyName = "FCNFCL"
        Me.FCNFCL.HeaderText = "Fecha Confirmación"
        Me.FCNFCL.Name = "FCNFCL"
        Me.FCNFCL.ReadOnly = True
        Me.FCNFCL.Width = 119
        '
        'HCNFCL
        '
        Me.HCNFCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HCNFCL.DataPropertyName = "HCNFCL"
        Me.HCNFCL.HeaderText = "Hora de Confirmación"
        Me.HCNFCL.Name = "HCNFCL"
        Me.HCNFCL.ReadOnly = True
        Me.HCNFCL.Width = 127
        '
        'TOBSEN
        '
        Me.TOBSEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBSEN.DataPropertyName = "TOBSEN"
        Me.TOBSEN.HeaderText = "Observación de Entrega"
        Me.TOBSEN.MinimumWidth = 150
        Me.TOBSEN.Name = "TOBSEN"
        Me.TOBSEN.ReadOnly = True
        Me.TOBSEN.Width = 150
        '
        'M_NROPLT
        '
        Me.M_NROPLT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NROPLT.DataPropertyName = "NROPLT"
        Me.M_NROPLT.HeaderText = "Nro. Paleta"
        Me.M_NROPLT.Name = "M_NROPLT"
        Me.M_NROPLT.ReadOnly = True
        Me.M_NROPLT.Width = 83
        '
        'M_STRNSM
        '
        Me.M_STRNSM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_STRNSM.DataPropertyName = "STRNSM"
        Me.M_STRNSM.HeaderText = "St. Transf."
        Me.M_STRNSM.Name = "M_STRNSM"
        Me.M_STRNSM.ReadOnly = True
        Me.M_STRNSM.Visible = False
        Me.M_STRNSM.Width = 79
        '
        'M_CBLTOR
        '
        Me.M_CBLTOR.DataPropertyName = "CBLTOR"
        Me.M_CBLTOR.HeaderText = "CBLTOR"
        Me.M_CBLTOR.Name = "M_CBLTOR"
        Me.M_CBLTOR.ReadOnly = True
        Me.M_CBLTOR.Visible = False
        Me.M_CBLTOR.Width = 79
        '
        'M_NSEQIO
        '
        Me.M_NSEQIO.DataPropertyName = "NSEQIO"
        Me.M_NSEQIO.HeaderText = "NSEQIO"
        Me.M_NSEQIO.Name = "M_NSEQIO"
        Me.M_NSEQIO.ReadOnly = True
        Me.M_NSEQIO.Visible = False
        Me.M_NSEQIO.Width = 77
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 300)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 14
        Me.UcPaginacion.Size = New System.Drawing.Size(1087, 25)
        Me.UcPaginacion.TabIndex = 27
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblWaybill, Me.ToolStripSeparator2, Me.btnBuscar, Me.ToolStripSeparator1, Me.btnExportar, Me.ToolStripSeparator3})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(1087, 25)
        Me.tsMenuOpciones.TabIndex = 25
        '
        'lblWaybill
        '
        Me.lblWaybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaybill.Name = "lblWaybill"
        Me.lblWaybill.Size = New System.Drawing.Size(56, 22)
        Me.lblWaybill.Tag = "BULTOS"
        Me.lblWaybill.Text = "BULTOS"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(60, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(66, 22)
        Me.btnExportar.Text = "Exportar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'dgBultosDetalle
        '
        Me.dgBultosDetalle.AllowUserToAddRows = False
        Me.dgBultosDetalle.AllowUserToDeleteRows = False
        Me.dgBultosDetalle.AllowUserToOrderColumns = True
        Me.dgBultosDetalle.AllowUserToResizeColumns = False
        Me.dgBultosDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip
        Me.dgBultosDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgBultosDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgBultosDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgBultosDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D_CREFFW, Me.D_NORCML, Me.D_NRITOC, Me.D_CIDPAQ, Me.D_TDITES, Me.D_QBLTSR, Me.D_QPEPQT, Me.D_TUNPSO, Me.D_QVOPQT, Me.D_TUNVOL, Me.D_TLUGEN, Me.D_NGRPRV, Me.X_MARRET, Me.SUBITEM, Me.NRSITEM})
        Me.dgBultosDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBultosDetalle.Location = New System.Drawing.Point(0, 25)
        Me.dgBultosDetalle.MultiSelect = False
        Me.dgBultosDetalle.Name = "dgBultosDetalle"
        Me.dgBultosDetalle.ReadOnly = True
        Me.dgBultosDetalle.RowHeadersWidth = 20
        Me.dgBultosDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgBultosDetalle.Size = New System.Drawing.Size(1066, 216)
        Me.dgBultosDetalle.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgBultosDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgBultosDetalle.TabIndex = 24
        '
        'D_CREFFW
        '
        Me.D_CREFFW.DataPropertyName = "PSCREFFW"
        Me.D_CREFFW.HeaderText = "Bulto"
        Me.D_CREFFW.Name = "D_CREFFW"
        Me.D_CREFFW.ReadOnly = True
        Me.D_CREFFW.Visible = False
        Me.D_CREFFW.Width = 41
        '
        'D_NORCML
        '
        Me.D_NORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.D_NORCML.DataPropertyName = "PSNORCML"
        Me.D_NORCML.HeaderText = "Nro. O/C"
        Me.D_NORCML.Name = "D_NORCML"
        Me.D_NORCML.ReadOnly = True
        Me.D_NORCML.Width = 90
        '
        'D_NRITOC
        '
        Me.D_NRITOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.D_NRITOC.DataPropertyName = "PNNRITOC"
        Me.D_NRITOC.HeaderText = "Nro. Item" & Global.Microsoft.VisualBasic.ChrW(10) & " O/C"
        Me.D_NRITOC.Name = "D_NRITOC"
        Me.D_NRITOC.ReadOnly = True
        Me.D_NRITOC.Width = 61
        '
        'D_CIDPAQ
        '
        Me.D_CIDPAQ.DataPropertyName = "PSCIDPAQ"
        Me.D_CIDPAQ.HeaderText = "Cód. Paquete"
        Me.D_CIDPAQ.Name = "D_CIDPAQ"
        Me.D_CIDPAQ.ReadOnly = True
        Me.D_CIDPAQ.Width = 101
        '
        'D_TDITES
        '
        Me.D_TDITES.DataPropertyName = "PSTDITES"
        Me.D_TDITES.HeaderText = "Descripción"
        Me.D_TDITES.Name = "D_TDITES"
        Me.D_TDITES.ReadOnly = True
        Me.D_TDITES.Width = 92
        '
        'D_QBLTSR
        '
        Me.D_QBLTSR.DataPropertyName = "PNQBLTSR"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.D_QBLTSR.DefaultCellStyle = DataGridViewCellStyle2
        Me.D_QBLTSR.HeaderText = "Cantidad"
        Me.D_QBLTSR.Name = "D_QBLTSR"
        Me.D_QBLTSR.ReadOnly = True
        Me.D_QBLTSR.Width = 78
        '
        'D_QPEPQT
        '
        Me.D_QPEPQT.DataPropertyName = "PNQPEPQT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.D_QPEPQT.DefaultCellStyle = DataGridViewCellStyle3
        Me.D_QPEPQT.HeaderText = "Peso"
        Me.D_QPEPQT.Name = "D_QPEPQT"
        Me.D_QPEPQT.ReadOnly = True
        Me.D_QPEPQT.Width = 60
        '
        'D_TUNPSO
        '
        Me.D_TUNPSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.D_TUNPSO.DataPropertyName = "PSTUNPSO"
        Me.D_TUNPSO.HeaderText = "Unidad"
        Me.D_TUNPSO.Name = "D_TUNPSO"
        Me.D_TUNPSO.ReadOnly = True
        Me.D_TUNPSO.Width = 55
        '
        'D_QVOPQT
        '
        Me.D_QVOPQT.DataPropertyName = "PNQVOPQT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.D_QVOPQT.DefaultCellStyle = DataGridViewCellStyle4
        Me.D_QVOPQT.HeaderText = "Volumen"
        Me.D_QVOPQT.Name = "D_QVOPQT"
        Me.D_QVOPQT.ReadOnly = True
        Me.D_QVOPQT.Width = 77
        '
        'D_TUNVOL
        '
        Me.D_TUNVOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.D_TUNVOL.DataPropertyName = "PSTUNVOL"
        Me.D_TUNVOL.HeaderText = "Unidad"
        Me.D_TUNVOL.Name = "D_TUNVOL"
        Me.D_TUNVOL.ReadOnly = True
        Me.D_TUNVOL.Width = 55
        '
        'D_TLUGEN
        '
        Me.D_TLUGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.D_TLUGEN.DataPropertyName = "PSTLUGEN"
        Me.D_TLUGEN.HeaderText = "Lugar Entrega"
        Me.D_TLUGEN.Name = "D_TLUGEN"
        Me.D_TLUGEN.ReadOnly = True
        '
        'D_NGRPRV
        '
        Me.D_NGRPRV.DataPropertyName = "PNNGRPRV"
        Me.D_NGRPRV.HeaderText = "Guia Proveedor"
        Me.D_NGRPRV.Name = "D_NGRPRV"
        Me.D_NGRPRV.ReadOnly = True
        Me.D_NGRPRV.Visible = False
        Me.D_NGRPRV.Width = 101
        '
        'X_MARRET
        '
        Me.X_MARRET.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.X_MARRET.DataPropertyName = "PSMARRET"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.X_MARRET.DefaultCellStyle = DataGridViewCellStyle5
        Me.X_MARRET.HeaderText = "Custodia"
        Me.X_MARRET.Name = "X_MARRET"
        Me.X_MARRET.ReadOnly = True
        Me.X_MARRET.Width = 60
        '
        'SUBITEM
        '
        Me.SUBITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SUBITEM.HeaderText = "SubItems"
        Me.SUBITEM.Image = Global.SOLMIN_SA.My.Resources.Resources.EnBlanco
        Me.SUBITEM.Name = "SUBITEM"
        Me.SUBITEM.ReadOnly = True
        Me.SUBITEM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SUBITEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SUBITEM.Width = 60
        '
        'NRSITEM
        '
        Me.NRSITEM.DataPropertyName = "PNNRSITEM"
        Me.NRSITEM.HeaderText = "NRSITEM"
        Me.NRSITEM.Name = "NRSITEM"
        Me.NRSITEM.ReadOnly = True
        Me.NRSITEM.Visible = False
        Me.NRSITEM.Width = 85
        '
        'hgDetalleItem
        '
        Me.hgDetalleItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.hgDetalleItem.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.hgDetalleItem.HeaderVisibleSecondary = False
        Me.hgDetalleItem.Location = New System.Drawing.Point(1066, 25)
        Me.hgDetalleItem.Name = "hgDetalleItem"
        '
        'hgDetalleItem.Panel
        '
        Me.hgDetalleItem.Panel.Controls.Add(Me.txtInformacionItemBulto)
        Me.hgDetalleItem.Size = New System.Drawing.Size(21, 216)
        Me.hgDetalleItem.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgDetalleItem.StateNormal.HeaderPrimary.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.hgDetalleItem.StateNormal.HeaderPrimary.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.hgDetalleItem.TabIndex = 20
        Me.hgDetalleItem.Text = "INFORMACIÓN O/C"
        Me.hgDetalleItem.ValuesPrimary.Description = ""
        Me.hgDetalleItem.ValuesPrimary.Heading = "INFORMACIÓN O/C"
        Me.hgDetalleItem.ValuesPrimary.Image = Nothing
        Me.hgDetalleItem.ValuesSecondary.Description = ""
        Me.hgDetalleItem.ValuesSecondary.Heading = "Description"
        Me.hgDetalleItem.ValuesSecondary.Image = Nothing
        '
        'txtInformacionItemBulto
        '
        Me.txtInformacionItemBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInformacionItemBulto.Location = New System.Drawing.Point(0, 0)
        Me.txtInformacionItemBulto.Multiline = True
        Me.txtInformacionItemBulto.Name = "txtInformacionItemBulto"
        Me.txtInformacionItemBulto.ReadOnly = True
        Me.txtInformacionItemBulto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInformacionItemBulto.Size = New System.Drawing.Size(0, 214)
        Me.txtInformacionItemBulto.StateCommon.Content.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInformacionItemBulto.TabIndex = 24
        Me.txtInformacionItemBulto.TabStop = False
        Me.TypeValidator.SetTypes(Me.txtInformacionItemBulto, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'tsMenuItemBulto
        '
        Me.tsMenuItemBulto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuItemBulto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuItemBulto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTituloDetalle})
        Me.tsMenuItemBulto.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuItemBulto.Name = "tsMenuItemBulto"
        Me.tsMenuItemBulto.Size = New System.Drawing.Size(1087, 25)
        Me.tsMenuItemBulto.TabIndex = 23
        '
        'lblTituloDetalle
        '
        Me.lblTituloDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloDetalle.Name = "lblTituloDetalle"
        Me.lblTituloDetalle.Size = New System.Drawing.Size(132, 22)
        Me.lblTituloDetalle.Text = "RELACION DE ITEMS"
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaStatusOcultarFiltros, Me.bsaCerrarVentana})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.chkRecepcion)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.chkDespacho)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbPlanta)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCodigoRecepcion)
        Me.khgFiltros.Panel.Controls.Add(Me.lblPlanta)
        Me.khgFiltros.Panel.Controls.Add(Me.lblDivision)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCompania)
        Me.khgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.txtClient)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCodigoRecepcion)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Size = New System.Drawing.Size(1087, 137)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 1
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaStatusOcultarFiltros
        '
        Me.bsaStatusOcultarFiltros.ExtraText = ""
        Me.bsaStatusOcultarFiltros.Image = Nothing
        Me.bsaStatusOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaStatusOcultarFiltros.Text = "Ocultar"
        Me.bsaStatusOcultarFiltros.ToolTipImage = Nothing
        Me.bsaStatusOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaStatusOcultarFiltros.UniqueName = "81C21FD15DF24C0A81C21FD15DF24C0A"
        '
        'bsaCerrarVentana
        '
        Me.bsaCerrarVentana.ExtraText = ""
        Me.bsaCerrarVentana.Image = Nothing
        Me.bsaCerrarVentana.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrarVentana.Text = "Cerrar"
        Me.bsaCerrarVentana.ToolTipImage = Nothing
        Me.bsaCerrarVentana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrarVentana.UniqueName = "43B34B10206C4BD743B34B10206C4BD7"
        '
        'chkRecepcion
        '
        Me.chkRecepcion.Checked = True
        Me.chkRecepcion.Location = New System.Drawing.Point(436, 49)
        Me.chkRecepcion.Name = "chkRecepcion"
        Me.chkRecepcion.Size = New System.Drawing.Size(76, 16)
        Me.chkRecepcion.TabIndex = 0
        Me.chkRecepcion.Text = "Recepción"
        Me.chkRecepcion.Values.ExtraText = ""
        Me.chkRecepcion.Values.Image = Nothing
        Me.chkRecepcion.Values.Text = "Recepción"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(355, 49)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(74, 16)
        Me.KryptonLabel1.TabIndex = 60
        Me.KryptonLabel1.Text = "Movimiento :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Movimiento :"
        '
        'chkDespacho
        '
        Me.chkDespacho.Location = New System.Drawing.Point(521, 49)
        Me.chkDespacho.Name = "chkDespacho"
        Me.chkDespacho.Size = New System.Drawing.Size(73, 16)
        Me.chkDespacho.TabIndex = 1
        Me.chkDespacho.Text = "Despacho"
        Me.chkDespacho.Values.ExtraText = ""
        Me.chkDespacho.Values.Image = Nothing
        Me.chkDespacho.Values.Text = "Despacho"
        '
        'cmbPlanta
        '
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.Location = New System.Drawing.Point(758, 15)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(242, 21)
        Me.cmbPlanta.TabIndex = 58
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(1002, 49)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(10, 16)
        Me.KryptonLabel2.TabIndex = 57
        Me.KryptonLabel2.Text = "                                                                                 " & _
            "                                 "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "                                                                                 " & _
            "                                 "
        '
        'txtCodigoRecepcion
        '
        Me.txtCodigoRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCodigoRecepcion, True)
        Me.txtCodigoRecepcion.Location = New System.Drawing.Point(89, 75)
        Me.txtCodigoRecepcion.MaxLength = 100
        Me.txtCodigoRecepcion.Name = "txtCodigoRecepcion"
        Me.txtCodigoRecepcion.Size = New System.Drawing.Size(248, 19)
        Me.txtCodigoRecepcion.TabIndex = 5
        Me.TypeValidator.SetTypes(Me.txtCodigoRecepcion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(679, 16)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(49, 16)
        Me.lblPlanta.TabIndex = 51
        Me.lblPlanta.Text = "Planta : "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta : "
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(355, 16)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(56, 16)
        Me.lblDivision.TabIndex = 50
        Me.lblDivision.Text = "División : "
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "División : "
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(11, 16)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(68, 16)
        Me.lblCompania.TabIndex = 49
        Me.lblCompania.Text = "Compañia : "
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia : "
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(436, 13)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(237, 23)
        Me.UcDivision_Cmb011.TabIndex = 1
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'txtClient
        '
        Me.txtClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClient.BackColor = System.Drawing.Color.Transparent
        Me.txtClient.CCMPN = "EZ"
        Me.txtClient.Location = New System.Drawing.Point(89, 46)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.pAccesoPorUsuario = True
        Me.txtClient.pRequerido = True
        Me.txtClient.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClient.Size = New System.Drawing.Size(248, 19)
        Me.txtClient.TabIndex = 3
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(917, 45)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(83, 20)
        Me.dteFechaFinal.TabIndex = 8
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(758, 45)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(82, 20)
        Me.dteFechaInicial.TabIndex = 7
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(846, 49)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(63, 16)
        Me.lblFechaFinal.TabIndex = 7
        Me.lblFechaFinal.Text = "Fecha fin : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha fin : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(679, 49)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(77, 16)
        Me.lblFechaInicial.TabIndex = 5
        Me.lblFechaInicial.Text = "Fecha inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha inicio : "
        '
        'lblCodigoRecepcion
        '
        Me.lblCodigoRecepcion.Location = New System.Drawing.Point(11, 74)
        Me.lblCodigoRecepcion.Name = "lblCodigoRecepcion"
        Me.lblCodigoRecepcion.Size = New System.Drawing.Size(42, 16)
        Me.lblCodigoRecepcion.TabIndex = 3
        Me.lblCodigoRecepcion.Text = "Bulto : "
        Me.lblCodigoRecepcion.Values.ExtraText = ""
        Me.lblCodigoRecepcion.Values.Image = Nothing
        Me.lblCodigoRecepcion.Values.Text = "Bulto : "
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(11, 49)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 16)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = "EZ"
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(89, 13)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(248, 37)
        Me.UcCompania_Cmb011.TabIndex = 0
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'cmsBultoCabecera
        '
        Me.cmsBultoCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmsBultoCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEliminarBultoPaleta})
        Me.cmsBultoCabecera.Name = "cmsRecepcion"
        Me.cmsBultoCabecera.Size = New System.Drawing.Size(200, 26)
        '
        'tsmiEliminarBultoPaleta
        '
        Me.tsmiEliminarBultoPaleta.Name = "tsmiEliminarBultoPaleta"
        Me.tsmiEliminarBultoPaleta.Size = New System.Drawing.Size(199, 22)
        Me.tsmiEliminarBultoPaleta.Text = "Eliminar Bulto de la Paleta"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Custodia Retención"
        Me.DataGridViewImageColumn1.Image = Global.SOLMIN_SA.My.Resources.Resources.EnBlanco
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 129
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.DataPropertyName = "Column1"
        Me.DataGridViewImageColumn2.HeaderText = "Column1"
        Me.DataGridViewImageColumn2.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 58
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NMRGIM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NMRGIM"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 85
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CREFFW"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 64
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NSEQIN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NSEQIN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 78
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DESCWB"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 98
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FREFFW"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Recep."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 97
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CTPALM"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tip. Almacén"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 98
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CALMC"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Almacén"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 83
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CZNALM"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 63
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TUBRFR"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ubicación"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 89
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SMTRCP"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Incidencia / Motivo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 93
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "QREFFW"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 84
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TIPBTO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Tipo Bulto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 84
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "QPSOBL"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 61
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TUNPSO"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 74
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "QVLBTO"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 84
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TUNVOL"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 74
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "SSNCRG"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Sentido"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 76
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "QAROCP"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Área Ocupada"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 102
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TLUGOR"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Lugar de Origen"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 111
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TLUGEN"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Lugar de Entrega"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 115
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "NORAGN"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Nro. O/S"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 76
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "NTCKPS"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Nro. Ticket"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 87
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "CRTLTE"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Criterio"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 75
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "TDSCIT"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 113
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "FSLFFW"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Fecha de Salida"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 108
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Guía de Remisión"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 118
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "FLGCNL"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Estado de Entrega"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 119
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "TNMMDT"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Medio Sugerido"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 110
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "CONFIR"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Medio Confirmado"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 126
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "FRQALC"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Fecha Req."
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 86
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "TCTCST"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Imputación Terrestre"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 134
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "TCTCSA"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Imputación Aérea"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 119
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "TCTCSF"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Imputación Fluvial"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 123
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "FCNFCL"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Fecha Confirmación"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 131
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "HCNFCL"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Hora de Confirmación"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 141
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "TOBSEN"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Observación de Entrega"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 111
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "NROPLT"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Nro. Paleta"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 87
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "STRNSM"
        Me.DataGridViewTextBoxColumn38.HeaderText = "St. Transf."
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Width = 82
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "SSTINV"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 71
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Situación"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Width = 85
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "CBLTOR"
        Me.DataGridViewTextBoxColumn41.HeaderText = "CBLTOR"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 80
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "NSEQIO"
        Me.DataGridViewTextBoxColumn42.HeaderText = "NSEQIO"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 78
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "LINK"
        Me.DataGridViewTextBoxColumn43.HeaderText = "LINK"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 61
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "PSCREFFW"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Visible = False
        Me.DataGridViewTextBoxColumn44.Width = 45
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "PSNORCML"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Nro. O/C"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Width = 90
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "PNNRITOC"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Nro. Item" & Global.Microsoft.VisualBasic.ChrW(10) & " O/C"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Width = 61
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "PSCIDPAQ"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Cód. Paquete"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Width = 99
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "PSTDITES"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.Width = 98
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "PNQBLTSR"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.DataGridViewTextBoxColumn49.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn49.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.Width = 84
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "PNQPEPQT"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn50.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn50.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Width = 61
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "PSTUNPSO"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.Width = 55
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "PNQVOPQT"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.DataGridViewTextBoxColumn52.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn52.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.Width = 84
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "PSTUNVOL"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.Width = 55
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "PSTLUGEN"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Lugar Entrega"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.Width = 101
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "PNNGRPRV"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Guia Proveedor"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.Visible = False
        Me.DataGridViewTextBoxColumn55.Width = 108
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "PSMARRET"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn56.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn56.HeaderText = "Custodia" & Global.Microsoft.VisualBasic.ChrW(10) & "Retención"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.Width = 60
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "PNNRSITEM"
        Me.DataGridViewTextBoxColumn57.HeaderText = "NRSITEM"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.Visible = False
        Me.DataGridViewTextBoxColumn57.Width = 85
        '
        'frmRecepcionXOPLogistica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 708)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmRecepcionXOPLogistica"
        Me.Text = "Consulta De Bultos Únicos "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgBultos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dgBultosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgDetalleItem.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgDetalleItem.Panel.ResumeLayout(False)
        Me.hgDetalleItem.Panel.PerformLayout()
        CType(Me.hgDetalleItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgDetalleItem.ResumeLayout(False)
        Me.tsMenuItemBulto.ResumeLayout(False)
        Me.tsMenuItemBulto.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        Me.cmsBultoCabecera.ResumeLayout(False)
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents cmsBultoCabecera As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiEliminarBultoPaleta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgBultosDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents hgDetalleItem As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtInformacionItemBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents tsMenuItemBulto As System.Windows.Forms.ToolStrip
    Private WithEvents lblTituloDetalle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents txtClient As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblWaybill As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbPlanta As System.Windows.Forms.ComboBox
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
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dgBultos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NMRGIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NSEQIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_DESCWB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUBRFR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SMTRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TIPBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QPSOBL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QVLBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNVOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SSNCRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QAROCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TLUGOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NORAGN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NTCKPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CRTLTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDSCIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSLFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLGCNL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMMDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONFIR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FRQALC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCTCST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCTCSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCTCSF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCNFCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HCNFCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NROPLT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_STRNSM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CBLTOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NSEQIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CIDPAQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QBLTSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QPEPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QVOPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TUNVOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_NGRPRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents X_MARRET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUBITEM As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NRSITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkRecepcion As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents chkDespacho As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
